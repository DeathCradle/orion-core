﻿// Copyright (c) 2019 Pryaxis & Orion Contributors
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

using System.IO;

namespace Orion.Packets.Players {
    /// <summary>
    /// Packet sent to set a player's zones.
    /// </summary>
    /// <remarks>This packet is used to synchronize player state.</remarks>
    public sealed class PlayerZonesPacket : Packet {
        private byte _playerIndex;
        private bool _isNearDungeon;
        private bool _isNearCorruption;
        private bool _isNearHallowed;
        private bool _isNearMeteor;
        private bool _isNearJungle;
        private bool _isNearSnow;
        private bool _isNearCrimson;
        private bool _isNearWaterCandle;
        private bool _isNearPeaceCandle;
        private bool _isNearSolarPillar;
        private bool _isNearVortexPillar;
        private bool _isNearNebulaPillar;
        private bool _isNearStardustPillar;
        private bool _isNearDesert;
        private bool _isNearGlowingMushroom;
        private bool _isNearUndergroundDesert;
        private bool _isNearSkyHeight;
        private bool _isNearOverworldHeight;
        private bool _isNearDirtLayerHeight;
        private bool _isNearRockLayerHeight;
        private bool _isNearUnderworldHeight;
        private bool _isNearBeach;
        private bool _isNearRain;
        private bool _isNearSandstorm;
        private bool _isNearOldOnesArmy;

        /// <inheritdoc/>
        public override PacketType Type => PacketType.PlayerZones;

        /// <summary>
        /// Gets or sets the player index.
        /// </summary>
        /// <value>The player index.</value>
        public byte PlayerIndex {
            get => _playerIndex;
            set {
                _playerIndex = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a dungeon zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a dungeon zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearDungeon {
            get => _isNearDungeon;
            set {
                _isNearDungeon = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a corruption zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a corruption zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearCorruption {
            get => _isNearCorruption;
            set {
                _isNearCorruption = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a hallowed zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a hallowed zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearHallowed {
            get => _isNearHallowed;
            set {
                _isNearHallowed = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a meteor zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a meteor zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearMeteor {
            get => _isNearMeteor;
            set {
                _isNearMeteor = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a jungle zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a jungle zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearJungle {
            get => _isNearJungle;
            set {
                _isNearJungle = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a snow zone.
        /// </summary>
        /// <value><see langword="true"/> if the player is near a snow zone; otherwise, <see langword="false"/>.</value>
        public bool IsNearSnow {
            get => _isNearSnow;
            set {
                _isNearSnow = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a crimson zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a crimson zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearCrimson {
            get => _isNearCrimson;
            set {
                _isNearCrimson = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a water candle zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a water candle zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearWaterCandle {
            get => _isNearWaterCandle;
            set {
                _isNearWaterCandle = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a peace candle zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a peace candle zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearPeaceCandle {
            get => _isNearPeaceCandle;
            set {
                _isNearPeaceCandle = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a solar pillar.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a solar pillar; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearSolarPillar {
            get => _isNearSolarPillar;
            set {
                _isNearSolarPillar = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a vortex pillar.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a vortex pillar; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearVortexPillar {
            get => _isNearVortexPillar;
            set {
                _isNearVortexPillar = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a nebula pillar.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a nebula pillar; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearNebulaPillar {
            get => _isNearNebulaPillar;
            set {
                _isNearNebulaPillar = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a stardust pillar.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a stardust pillar; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearStardustPillar {
            get => _isNearStardustPillar;
            set {
                _isNearStardustPillar = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a desert zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a desert zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearDesert {
            get => _isNearDesert;
            set {
                _isNearDesert = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a glowing mushroom zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a glowing mushroom zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearGlowingMushroom {
            get => _isNearGlowingMushroom;
            set {
                _isNearGlowingMushroom = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near an underground desert zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near an underground desert zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearUndergroundDesert {
            get => _isNearUndergroundDesert;
            set {
                _isNearUndergroundDesert = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the sky height zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near the sky height zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearSkyHeight {
            get => _isNearSkyHeight;
            set {
                _isNearSkyHeight = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the overworld height zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near the overworld height zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearOverworldHeight {
            get => _isNearOverworldHeight;
            set {
                _isNearOverworldHeight = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the dirt layer height zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near the dirt layer height zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearDirtLayerHeight {
            get => _isNearDirtLayerHeight;
            set {
                _isNearDirtLayerHeight = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the rock layer height zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near the rock layer height zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearRockLayerHeight {
            get => _isNearRockLayerHeight;
            set {
                _isNearRockLayerHeight = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near the underworld layer height zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near the underworld layer height zone; otherwise,
        /// <see langword="false"/>.
        /// </value>
        public bool IsNearUnderworldHeight {
            get => _isNearUnderworldHeight;
            set {
                _isNearUnderworldHeight = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a beach zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a beach zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearBeach {
            get => _isNearBeach;
            set {
                _isNearBeach = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a rain zone.
        /// </summary>
        /// <value><see langword="true"/> if the player is near a rain zone; otherwise, <see langword="false"/>.</value>
        public bool IsNearRain {
            get => _isNearRain;
            set {
                _isNearRain = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near a sandstorm zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near a sandstorm zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearSandstorm {
            get => _isNearSandstorm;
            set {
                _isNearSandstorm = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the player is near an Old One's Army zone.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the player is near an Old One's Army zone; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsNearOldOnesArmy {
            get => _isNearOldOnesArmy;
            set {
                _isNearOldOnesArmy = value;
                _isDirty = true;
            }
        }

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            _playerIndex = reader.ReadByte();

            Terraria.BitsByte zoneFlags = reader.ReadByte();
            Terraria.BitsByte zoneFlags2 = reader.ReadByte();
            Terraria.BitsByte zoneFlags3 = reader.ReadByte();
            Terraria.BitsByte zoneFlags4 = reader.ReadByte();
            _isNearDungeon = zoneFlags[0];
            _isNearCorruption = zoneFlags[1];
            _isNearHallowed = zoneFlags[2];
            _isNearMeteor = zoneFlags[3];
            _isNearJungle = zoneFlags[4];
            _isNearSnow = zoneFlags[5];
            _isNearCrimson = zoneFlags[6];
            _isNearWaterCandle = zoneFlags[7];
            _isNearPeaceCandle = zoneFlags2[0];
            _isNearSolarPillar = zoneFlags2[1];
            _isNearVortexPillar = zoneFlags2[2];
            _isNearNebulaPillar = zoneFlags2[3];
            _isNearStardustPillar = zoneFlags2[4];
            _isNearDesert = zoneFlags2[5];
            _isNearGlowingMushroom = zoneFlags2[6];
            _isNearUndergroundDesert = zoneFlags2[7];
            _isNearSkyHeight = zoneFlags3[0];
            _isNearOverworldHeight = zoneFlags3[1];
            _isNearDirtLayerHeight = zoneFlags3[2];
            _isNearRockLayerHeight = zoneFlags3[3];
            _isNearUnderworldHeight = zoneFlags3[4];
            _isNearBeach = zoneFlags3[5];
            _isNearRain = zoneFlags3[6];
            _isNearSandstorm = zoneFlags3[7];
            _isNearOldOnesArmy = zoneFlags4[0];
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(_playerIndex);

            Terraria.BitsByte zoneFlags = 0;
            Terraria.BitsByte zoneFlags2 = 0;
            Terraria.BitsByte zoneFlags3 = 0;
            Terraria.BitsByte zoneFlags4 = 0;
            zoneFlags[0] = _isNearDungeon;
            zoneFlags[1] = _isNearCorruption;
            zoneFlags[2] = _isNearHallowed;
            zoneFlags[3] = _isNearMeteor;
            zoneFlags[4] = _isNearJungle;
            zoneFlags[5] = _isNearSnow;
            zoneFlags[6] = _isNearCrimson;
            zoneFlags[7] = _isNearWaterCandle;
            zoneFlags2[0] = _isNearPeaceCandle;
            zoneFlags2[1] = _isNearSolarPillar;
            zoneFlags2[2] = _isNearVortexPillar;
            zoneFlags2[3] = _isNearNebulaPillar;
            zoneFlags2[4] = _isNearStardustPillar;
            zoneFlags2[5] = _isNearDesert;
            zoneFlags2[6] = _isNearGlowingMushroom;
            zoneFlags2[7] = _isNearUndergroundDesert;
            zoneFlags3[0] = _isNearSkyHeight;
            zoneFlags3[1] = _isNearOverworldHeight;
            zoneFlags3[2] = _isNearDirtLayerHeight;
            zoneFlags3[3] = _isNearRockLayerHeight;
            zoneFlags3[4] = _isNearUnderworldHeight;
            zoneFlags3[5] = _isNearBeach;
            zoneFlags3[6] = _isNearRain;
            zoneFlags3[7] = _isNearSandstorm;
            zoneFlags4[0] = _isNearOldOnesArmy;
            writer.Write(zoneFlags);
            writer.Write(zoneFlags2);
            writer.Write(zoneFlags3);
            writer.Write(zoneFlags4);
        }
    }
}
