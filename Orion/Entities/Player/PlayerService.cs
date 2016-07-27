﻿using System;
using System.Collections.Generic;
using System.Linq;
using Orion.Events.Player;
using Orion.Framework;
using OTAPI.Core;

namespace Orion.Entities.Player
{
	/// <summary>
	/// Manages <see cref="IPlayer"/>s.
	/// </summary>
	[Service("Player Service", Author = "Nyx Studios")]
	public class PlayerService : ServiceBase, IPlayerService
	{
		private bool _disposed;
		private readonly IPlayer[] _players;

		/// <inheritdoc/>
		public event EventHandler<PlayerJoinedEventArgs> PlayerJoined;

		/// <inheritdoc/>
		public event EventHandler<PlayerJoiningEventArgs> PlayerJoining;

		/// <inheritdoc/>
		public event EventHandler<PlayerQuitEventArgs> PlayerQuit;

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerService"/> class.
		/// </summary>
		/// <param name="orion">The parent <see cref="Orion"/> instance.</param>
		/// <remarks>
		/// This constructor registers the OTAPI hooks.
		/// </remarks>
		public PlayerService(Orion orion) : base(orion)
		{
			_players = new IPlayer[Terraria.Main.player.Length];
			Hooks.Net.RemoteClient.PreReset = InvokePlayerQuit;
			// TODO: change this to use net hooks, so we can have separate greeting hooks
			Hooks.Player.PreGreet = InvokePlayerJoin;
		}

		/// <inheritdoc/>
		/// <remarks>
		/// The <see cref="IPlayer"/>s are cached in an array. Calling this method multiple times will result in the
		/// same <see cref="IPlayer"/> references as long as the Terraria player array is not updated.
		/// </remarks>
		public IEnumerable<IPlayer> Find(Predicate<IPlayer> predicate = null)
		{
			var players = new List<IPlayer>();
			for (int i = 0; i < _players.Length; i++)
			{
				if (_players[i]?.WrappedPlayer != Terraria.Main.player[i])
				{
					_players[i] = new Player(Terraria.Main.player[i]);
				}
				players.Add(_players[i]);
			}
			return players.Where(p => p.WrappedPlayer.active && (predicate?.Invoke(p) ?? true));
		}

		/// <inheritdoc/>
		/// <remarks>
		/// This method deregisters the OTAPI hooks.
		/// </remarks>
		protected override void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					Hooks.Net.RemoteClient.PreReset = null;
					Hooks.Player.PreGreet = null;
				}
				_disposed = true;
			}
			base.Dispose(disposing);
		}

		private HookResult InvokePlayerJoin(ref int playerId)
		{
			if (_players[playerId]?.WrappedPlayer != Terraria.Main.player[playerId])
			{
				_players[playerId] = new Player(Terraria.Main.player[playerId]);
			}
			IPlayer player = _players[playerId];
			var preArgs = new PlayerJoiningEventArgs(player);
			PlayerJoining?.Invoke(this, preArgs);
			if (preArgs.Handled)
			{
				return HookResult.Cancel;
			}

			var postArgs = new PlayerJoinedEventArgs(player);
			PlayerJoined?.Invoke(this, postArgs);
			return HookResult.Continue;
		}

		private HookResult InvokePlayerQuit(Terraria.RemoteClient remoteClient)
		{
			if (remoteClient.Socket == null)
			{
				return HookResult.Continue;
			}

			if (_players[remoteClient.Id]?.WrappedPlayer != Terraria.Main.player[remoteClient.Id])
			{
				_players[remoteClient.Id] = new Player(Terraria.Main.player[remoteClient.Id]);
			}
			IPlayer player = _players[remoteClient.Id];
			var args = new PlayerQuitEventArgs(player);
			PlayerQuit?.Invoke(this, args);
			return HookResult.Continue;
		}
	}
}