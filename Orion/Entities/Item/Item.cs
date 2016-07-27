﻿using System;
using Microsoft.Xna.Framework;

namespace Orion.Entities.Item
{
	/// <summary>
	/// Wraps a Terraria item.
	/// </summary>
	public class Item : IItem
	{
		/// <inheritdoc/>
		public int AnimationTime
		{
			get { return WrappedItem.useAnimation; }
			set { WrappedItem.useAnimation = value; }
		}

		/// <inheritdoc/>
		public int AxePower => WrappedItem.axe;

		/// <inheritdoc/>
		public Color Color
		{
			get { return WrappedItem.color; }
			set { WrappedItem.color = value; }
		}

		/// <inheritdoc/>
		public int Damage
		{
			get { return WrappedItem.damage; }
			set { WrappedItem.damage = value; }
		}

		/// <inheritdoc/>
		public int HammerPower => WrappedItem.hammer;

		/// <inheritdoc/>
		public int MaxStackSize => WrappedItem.maxStack;

		/// <inheritdoc/>
		public float Knockback
		{
			get { return WrappedItem.knockBack; }
			set { WrappedItem.knockBack = value; }
		}

		/// <inheritdoc/>
		public string Name => WrappedItem.name;

		/// <inheritdoc/>
		public int PickaxePower => WrappedItem.pick;

		/// <inheritdoc/>
		public Vector2 Position
		{
			get { return WrappedItem.position; }
			set { WrappedItem.position = value; }
		}

		/// <inheritdoc/>
		public int Prefix => WrappedItem.prefix;

		/// <inheritdoc/>
		public int Projectile
		{
			get { return WrappedItem.shoot; }
			set { WrappedItem.shoot = value; }
		}

		/// <inheritdoc/>
		public float ProjectileSpeed
		{
			get { return WrappedItem.shootSpeed; }
			set { WrappedItem.shootSpeed = value; }
		}

		/// <inheritdoc/>
		public int StackSize
		{
			get { return WrappedItem.stack; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException(nameof(value));
				}

				WrappedItem.stack = value;
			}
		}

		/// <inheritdoc/>
		public int Type => WrappedItem.netID;

		/// <inheritdoc/>
		public int UseTime
		{
			get { return WrappedItem.useTime; }
			set { WrappedItem.useTime = value; }
		}

		/// <inheritdoc/>
		public Vector2 Velocity
		{
			get { return WrappedItem.velocity; }
			set { WrappedItem.velocity = value; }
		}

		/// <inheritdoc/>
		public Terraria.Item WrappedItem { get; }

		/// <inheritdoc/>
		public Item(Terraria.Item terrariaItem)
		{
			if (terrariaItem == null)
			{
				throw new ArgumentNullException(nameof(terrariaItem));
			}

			WrappedItem = terrariaItem;
		}

		/// <inheritdoc/>
		public void SetDefaults(int type)
		{
			if (type < 0 || type > Terraria.Main.maxItemTypes)
			{
				throw new ArgumentOutOfRangeException(nameof(type));
			}

			WrappedItem.SetDefaults(type);
		}

		/// <inheritdoc/>
		/// <remarks>
		/// If <paramref name="prefix"/> is not applicable to the item type, then a randomly chosen prefix will be
		/// used.
		/// </remarks>
		public void SetPrefix(int prefix)
		{
			if (prefix < 0 || prefix > Terraria.Item.maxPrefixes)
			{
				throw new ArgumentOutOfRangeException(nameof(prefix));
			}

			WrappedItem.Prefix(prefix);
		}
	}
}
