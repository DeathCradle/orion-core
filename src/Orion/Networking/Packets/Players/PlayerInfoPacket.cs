﻿// Copyright (c) 2015-2019 Pryaxis & Orion Contributors
// 
// This file is part of Orion.
// 
// Orion is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Orion is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Orion.  If not, see <https://www.gnu.org/licenses/>.

using System.Diagnostics.CodeAnalysis;
using System.IO;
using Microsoft.Xna.Framework;
using Orion.Networking.Packets.Extensions;
using Terraria;

namespace Orion.Networking.Packets.Players {
    /// <summary>
    /// Packet sent to set player information.
    /// </summary>
    public sealed class PlayerInfoPacket : Packet {
        private byte _playerIndex;
        private bool _isPlayerHoldingUp;
        private bool _isPlayerHoldingDown;
        private bool _isPlayerHoldingLeft;
        private bool _isPlayerHoldingRight;
        private bool _isPlayerHoldingJump;
        private bool _isPlayerHoldingUseItem;
        private bool _playerDirection;
        private bool _isPlayerClimbingRope;
        private bool _playerClimbingRopeDirection;
        private bool _isPlayerVortexStealthed;
        private bool _isPlayerRightSideUp;
        private bool _isPlayerRaisingShield;
        private byte _playerSelectedItemIndex;
        private Vector2 _playerPosition;
        private Vector2 _playerVelocity;

        /// <summary>
        /// Gets or sets the player index.
        /// </summary>
        public byte PlayerIndex {
            get => _playerIndex;
            set {
                _playerIndex = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is holding up.
        /// </summary>
        public bool IsPlayerHoldingUp {
            get => _isPlayerHoldingUp;
            set {
                _isPlayerHoldingUp = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is holding down.
        /// </summary>
        public bool IsPlayerHoldingDown {
            get => _isPlayerHoldingDown;
            set {
                _isPlayerHoldingDown = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is holding left.
        /// </summary>
        public bool IsPlayerHoldingLeft {
            get => _isPlayerHoldingLeft;
            set {
                _isPlayerHoldingLeft = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is holding right.
        /// </summary>
        public bool IsPlayerHoldingRight {
            get => _isPlayerHoldingRight;
            set {
                _isPlayerHoldingRight = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is holding jump.
        /// </summary>
        public bool IsPlayerHoldingJump {
            get => _isPlayerHoldingJump;
            set {
                _isPlayerHoldingJump = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is holding 'use item'.
        /// </summary>
        public bool IsPlayerHoldingUseItem {
            get => _isPlayerHoldingUseItem;
            set {
                _isPlayerHoldingUseItem = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating the direction of the player.
        /// </summary>
        public bool PlayerDirection {
            get => _playerDirection;
            set {
                _playerDirection = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is climbing a rope.
        /// </summary>
        public bool IsPlayerClimbingRope {
            get => _isPlayerClimbingRope;
            set {
                _isPlayerClimbingRope = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating the direction of the player when climbing a rope.
        /// </summary>
        public bool PlayerClimbingRopeDirection {
            get => _playerClimbingRopeDirection;
            set {
                _playerClimbingRopeDirection = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is stealthed with vortex armor.
        /// </summary>
        public bool IsPlayerVortexStealthed {
            get => _isPlayerVortexStealthed;
            set {
                _isPlayerVortexStealthed = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is right-side up.
        /// </summary>
        public bool IsPlayerRightSideUp {
            get => _isPlayerRightSideUp;
            set {
                _isPlayerRightSideUp = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is raising a shield.
        /// </summary>
        public bool IsPlayerRaisingShield {
            get => _isPlayerRaisingShield;
            set {
                _isPlayerRaisingShield = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the player's selected item index.
        /// </summary>
        public byte PlayerSelectedItemIndex {
            get => _playerSelectedItemIndex;
            set {
                _playerSelectedItemIndex = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the player's position.
        /// </summary>
        public Vector2 PlayerPosition {
            get => _playerPosition;
            set {
                _playerPosition = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the player's velocity.
        /// </summary>
        public Vector2 PlayerVelocity {
            get => _playerVelocity;
            set {
                _playerVelocity = value;
                IsDirty = true;
            }
        }

        /// <inheritdoc />
        public override PacketType Type => PacketType.PlayerInfo;

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[#={PlayerIndex} @ {PlayerPosition}, ...]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            _playerIndex = reader.ReadByte();

            BitsByte flags = reader.ReadByte();
            BitsByte flags2 = reader.ReadByte();
            _isPlayerHoldingUp = flags[0];
            _isPlayerHoldingDown = flags[1];
            _isPlayerHoldingLeft = flags[2];
            _isPlayerHoldingRight = flags[3];
            _isPlayerHoldingJump = flags[4];
            _isPlayerHoldingUseItem = flags[5];
            _playerDirection = flags[6];
            _isPlayerClimbingRope = flags2[0];
            _playerClimbingRopeDirection = flags2[1];
            _isPlayerVortexStealthed = flags2[3];
            _isPlayerRightSideUp = flags2[4];
            _isPlayerRaisingShield = flags2[5];

            _playerSelectedItemIndex = reader.ReadByte();
            _playerPosition = BinaryExtensions.ReadVector2(reader);
            if (flags2[2]) _playerVelocity = BinaryExtensions.ReadVector2(reader);
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(PlayerIndex);

            BitsByte flags = 0;
            BitsByte flags2 = 0;
            flags[0] = IsPlayerHoldingUp;
            flags[1] = IsPlayerHoldingDown;
            flags[2] = IsPlayerHoldingLeft;
            flags[3] = IsPlayerHoldingRight;
            flags[4] = IsPlayerHoldingJump;
            flags[5] = IsPlayerHoldingUseItem;
            flags[6] = PlayerDirection;
            flags2[0] = IsPlayerClimbingRope;
            flags2[1] = PlayerClimbingRopeDirection;
            flags2[2] = PlayerVelocity != Vector2.Zero;
            flags2[3] = IsPlayerVortexStealthed;
            flags2[4] = IsPlayerRightSideUp;
            flags2[5] = IsPlayerRaisingShield;
            writer.Write(flags);
            writer.Write(flags2);

            writer.Write(PlayerSelectedItemIndex);
            writer.Write(PlayerPosition);
            if (flags2[2]) writer.Write(PlayerVelocity);
        }
    }
}
