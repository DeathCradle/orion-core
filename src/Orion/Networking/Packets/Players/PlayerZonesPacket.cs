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
using Terraria;

namespace Orion.Networking.Packets.Players {
    /// <summary>
    /// Packet sent to set a player's zones.
    /// </summary>
    public sealed class PlayerZonesPacket : Packet {
        private byte _playerIndex;
        private bool _isPlayerNearDungeonZone;
        private bool _isPlayerNearCorruptionZone;
        private bool _isPlayerNearHallowedZone;
        private bool _isPlayerNearMeteorZone;
        private bool _isPlayerNearJungleZone;
        private bool _isPlayerNearSnowZone;
        private bool _isPlayerNearCrimsonZone;
        private bool _isPlayerNearWaterCandleZone;
        private bool _isPlayerNearPeaceCandleZone;
        private bool _isPlayerNearSolarTowerZone;
        private bool _isPlayerNearVortexTowerZone;
        private bool _isPlayerNearNebulaTowerZone;
        private bool _isPlayerNearStardustTowerZone;
        private bool _isPlayerNearDesertZone;
        private bool _isPlayerNearGlowingMushroomZone;
        private bool _isPlayerNearUndergroundDesertZone;
        private bool _isPlayerNearSkyHeightZone;
        private bool _isPlayerNearOverworldHeightZone;
        private bool _isPlayerNearDirtLayerHeightZone;
        private bool _isPlayerNearRockLayerHeightZone;
        private bool _isPlayerNearUnderworldHeightZone;
        private bool _isPlayerNearBeachZone;
        private bool _isPlayerNearRainZone;
        private bool _isPlayerNearSandstormZone;
        private bool _isPlayerNearOldOnesArmyZone;

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
        /// Gets or sets a value indicating whether the player is near a dungeon zone.
        /// </summary>
        public bool IsPlayerNearDungeonZone {
            get => _isPlayerNearDungeonZone;
            set {
                _isPlayerNearDungeonZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a corruption zone.
        /// </summary>
        public bool IsPlayerNearCorruptionZone {
            get => _isPlayerNearCorruptionZone;
            set {
                _isPlayerNearCorruptionZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a hallowed zone.
        /// </summary>
        public bool IsPlayerNearHallowedZone {
            get => _isPlayerNearHallowedZone;
            set {
                _isPlayerNearHallowedZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a meteor zone.
        /// </summary>
        public bool IsPlayerNearMeteorZone {
            get => _isPlayerNearMeteorZone;
            set {
                _isPlayerNearMeteorZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a jungle zone.
        /// </summary>
        public bool IsPlayerNearJungleZone {
            get => _isPlayerNearJungleZone;
            set {
                _isPlayerNearJungleZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a snow zone.
        /// </summary>
        public bool IsPlayerNearSnowZone {
            get => _isPlayerNearSnowZone;
            set {
                _isPlayerNearSnowZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a crimson zone.
        /// </summary>
        public bool IsPlayerNearCrimsonZone {
            get => _isPlayerNearCrimsonZone;
            set {
                _isPlayerNearCrimsonZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a water candle zone.
        /// </summary>
        public bool IsPlayerNearWaterCandleZone {
            get => _isPlayerNearWaterCandleZone;
            set {
                _isPlayerNearWaterCandleZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a peace candle zone.
        /// </summary>
        public bool IsPlayerNearPeaceCandleZone {
            get => _isPlayerNearPeaceCandleZone;
            set {
                _isPlayerNearPeaceCandleZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a solar tower zone.
        /// </summary>
        public bool IsPlayerNearSolarTowerZone {
            get => _isPlayerNearSolarTowerZone;
            set {
                _isPlayerNearSolarTowerZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a vortex tower zone.
        /// </summary>
        public bool IsPlayerNearVortexTowerZone {
            get => _isPlayerNearVortexTowerZone;
            set {
                _isPlayerNearVortexTowerZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a nebula tower zone.
        /// </summary>
        public bool IsPlayerNearNebulaTowerZone {
            get => _isPlayerNearNebulaTowerZone;
            set {
                _isPlayerNearNebulaTowerZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a stardust tower zone.
        /// </summary>
        public bool IsPlayerNearStardustTowerZone {
            get => _isPlayerNearStardustTowerZone;
            set {
                _isPlayerNearStardustTowerZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a desert zone.
        /// </summary>
        public bool IsPlayerNearDesertZone {
            get => _isPlayerNearDesertZone;
            set {
                _isPlayerNearDesertZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a glowing mushroom zone.
        /// </summary>
        public bool IsPlayerNearGlowingMushroomZone {
            get => _isPlayerNearGlowingMushroomZone;
            set {
                _isPlayerNearGlowingMushroomZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near an underground desert zone.
        /// </summary>
        public bool IsPlayerNearUndergroundDesertZone {
            get => _isPlayerNearUndergroundDesertZone;
            set {
                _isPlayerNearUndergroundDesertZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the sky height zone.
        /// </summary>
        public bool IsPlayerNearSkyHeightZone {
            get => _isPlayerNearSkyHeightZone;
            set {
                _isPlayerNearSkyHeightZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the overworld height zone.
        /// </summary>
        public bool IsPlayerNearOverworldHeightZone {
            get => _isPlayerNearOverworldHeightZone;
            set {
                _isPlayerNearOverworldHeightZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the dirt layer height zone.
        /// </summary>
        public bool IsPlayerNearDirtLayerHeightZone {
            get => _isPlayerNearDirtLayerHeightZone;
            set {
                _isPlayerNearDirtLayerHeightZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the rock layer height zone.
        /// </summary>
        public bool IsPlayerNearRockLayerHeightZone {
            get => _isPlayerNearRockLayerHeightZone;
            set {
                _isPlayerNearRockLayerHeightZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the underworld layer height zone.
        /// </summary>
        public bool IsPlayerNearUnderworldHeightZone {
            get => _isPlayerNearUnderworldHeightZone;
            set {
                _isPlayerNearUnderworldHeightZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a beach zone.
        /// </summary>
        public bool IsPlayerNearBeachZone {
            get => _isPlayerNearBeachZone;
            set {
                _isPlayerNearBeachZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a rain zone.
        /// </summary>
        public bool IsPlayerNearRainZone {
            get => _isPlayerNearRainZone;
            set {
                _isPlayerNearRainZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a sandstorm zone.
        /// </summary>
        public bool IsPlayerNearSandstormZone {
            get => _isPlayerNearSandstormZone;
            set {
                _isPlayerNearSandstormZone = value;
                IsDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near an Old One's Army zone.
        /// </summary>
        public bool IsPlayerNearOldOnesArmyZone {
            get => _isPlayerNearOldOnesArmyZone;
            set {
                _isPlayerNearOldOnesArmyZone = value;
                IsDirty = true;
            }
        }

        /// <inheritdoc />
        public override PacketType Type => PacketType.PlayerZones;

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[#={PlayerIndex}, ...]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            _playerIndex = reader.ReadByte();

            BitsByte zoneFlags = reader.ReadByte();
            BitsByte zoneFlags2 = reader.ReadByte();
            BitsByte zoneFlags3 = reader.ReadByte();
            BitsByte zoneFlags4 = reader.ReadByte();
            _isPlayerNearDungeonZone = zoneFlags[0];
            _isPlayerNearCorruptionZone = zoneFlags[1];
            _isPlayerNearHallowedZone = zoneFlags[2];
            _isPlayerNearMeteorZone = zoneFlags[3];
            _isPlayerNearJungleZone = zoneFlags[4];
            _isPlayerNearSnowZone = zoneFlags[5];
            _isPlayerNearCrimsonZone = zoneFlags[6];
            _isPlayerNearWaterCandleZone = zoneFlags[7];
            _isPlayerNearPeaceCandleZone = zoneFlags2[0];
            _isPlayerNearSolarTowerZone = zoneFlags2[1];
            _isPlayerNearVortexTowerZone = zoneFlags2[2];
            _isPlayerNearNebulaTowerZone = zoneFlags2[3];
            _isPlayerNearStardustTowerZone = zoneFlags2[4];
            _isPlayerNearDesertZone = zoneFlags2[5];
            _isPlayerNearGlowingMushroomZone = zoneFlags2[6];
            _isPlayerNearUndergroundDesertZone = zoneFlags2[7];
            _isPlayerNearSkyHeightZone = zoneFlags3[0];
            _isPlayerNearOverworldHeightZone = zoneFlags3[1];
            _isPlayerNearDirtLayerHeightZone = zoneFlags3[2];
            _isPlayerNearRockLayerHeightZone = zoneFlags3[3];
            _isPlayerNearUnderworldHeightZone = zoneFlags3[4];
            _isPlayerNearBeachZone = zoneFlags3[5];
            _isPlayerNearRainZone = zoneFlags3[6];
            _isPlayerNearSandstormZone = zoneFlags3[7];
            _isPlayerNearOldOnesArmyZone = zoneFlags4[0];
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(PlayerIndex);

            BitsByte zoneFlags = 0;
            BitsByte zoneFlags2 = 0;
            BitsByte zoneFlags3 = 0;
            BitsByte zoneFlags4 = 0;
            zoneFlags[0] = IsPlayerNearDungeonZone;
            zoneFlags[1] = IsPlayerNearCorruptionZone;
            zoneFlags[2] = IsPlayerNearHallowedZone;
            zoneFlags[3] = IsPlayerNearMeteorZone;
            zoneFlags[4] = IsPlayerNearJungleZone;
            zoneFlags[5] = IsPlayerNearSnowZone;
            zoneFlags[6] = IsPlayerNearCrimsonZone;
            zoneFlags[7] = IsPlayerNearWaterCandleZone;
            zoneFlags2[0] = IsPlayerNearPeaceCandleZone;
            zoneFlags2[1] = IsPlayerNearSolarTowerZone;
            zoneFlags2[2] = IsPlayerNearVortexTowerZone;
            zoneFlags2[3] = IsPlayerNearNebulaTowerZone;
            zoneFlags2[4] = IsPlayerNearStardustTowerZone;
            zoneFlags2[5] = IsPlayerNearDesertZone;
            zoneFlags2[6] = IsPlayerNearGlowingMushroomZone;
            zoneFlags2[7] = IsPlayerNearUndergroundDesertZone;
            zoneFlags3[0] = IsPlayerNearSkyHeightZone;
            zoneFlags3[1] = IsPlayerNearOverworldHeightZone;
            zoneFlags3[2] = IsPlayerNearDirtLayerHeightZone;
            zoneFlags3[3] = IsPlayerNearRockLayerHeightZone;
            zoneFlags3[4] = IsPlayerNearUnderworldHeightZone;
            zoneFlags3[5] = IsPlayerNearBeachZone;
            zoneFlags3[6] = IsPlayerNearRainZone;
            zoneFlags3[7] = IsPlayerNearSandstormZone;
            zoneFlags4[0] = IsPlayerNearOldOnesArmyZone;
            writer.Write(zoneFlags);
            writer.Write(zoneFlags2);
            writer.Write(zoneFlags3);
            writer.Write(zoneFlags4);
        }
    }
}
