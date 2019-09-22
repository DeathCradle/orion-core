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

namespace Orion.Networking.Packets.Entities {
    /// <summary>
    /// Packet sent to damage an NPC with a player's held item.
    /// </summary>
    public sealed class DamageNpcHeldItemPacket : Packet {
        private short _npcIndex;
        private byte _damagingPlayerIndex;

        /// <inheritdoc />
        public override PacketType Type => PacketType.DamageNpcHeldItem;

        /// <summary>
        /// Gets or sets the NPC index.
        /// </summary>
        public short NpcIndex {
            get => _npcIndex;
            set {
                _npcIndex = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the damaging player index.
        /// </summary>
        public byte DamagingPlayerIndex {
            get => _damagingPlayerIndex;
            set {
                _damagingPlayerIndex = value;
                _isDirty = true;
            }
        }

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[#={NpcIndex} by P={DamagingPlayerIndex}]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            NpcIndex = reader.ReadInt16();
            DamagingPlayerIndex = reader.ReadByte();
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(NpcIndex);
            writer.Write(DamagingPlayerIndex);
        }
    }
}