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

namespace Orion.Networking.Packets.World {
    /// <summary>
    /// Packet sent from the client to the server to start the Old One's Army event.
    /// </summary>
    public sealed class StartOldOnesArmyPacket : Packet {
        private short _crystalX;
        private short _crystalY;

        /// <inheritdoc />
        public override PacketType Type => PacketType.StartOldOnesArmy;

        /// <summary>
        /// Gets or sets the crystal's X coordinate.
        /// </summary>
        public short CrystalX {
            get => _crystalX;
            set {
                _crystalX = value;
                _isDirty = true;
            }
        }

        /// <summary>
        /// Gets or sets the crystal's Y coordinate.
        /// </summary>
        public short CrystalY {
            get => _crystalY;
            set {
                _crystalY = value;
                _isDirty = true;
            }
        }

        /// <inheritdoc />
        [ExcludeFromCodeCoverage]
        public override string ToString() => $"{Type}[({CrystalX}, {CrystalY})]";

        private protected override void ReadFromReader(BinaryReader reader, PacketContext context) {
            CrystalX = reader.ReadInt16();
            CrystalY = reader.ReadInt16();
        }

        private protected override void WriteToWriter(BinaryWriter writer, PacketContext context) {
            writer.Write(CrystalX);
            writer.Write(CrystalY);
        }
    }
}
