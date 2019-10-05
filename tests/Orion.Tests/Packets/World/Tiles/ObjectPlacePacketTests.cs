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
using FluentAssertions;
using Orion.World.Tiles;
using Xunit;

namespace Orion.Packets.World.Tiles {
    public class ObjectPlacePacketTests {
        [Fact]
        public void SimpleProperties_Set_MarkAsDirty() {
            var packet = new ObjectPlacePacket();

            packet.SetSimplePropertiesShouldMarkAsDirty();
        }

        public static readonly byte[] Bytes = { 14, 0, 79, 0, 1, 100, 0, 21, 0, 1, 0, 0, 255, 1 };

        [Fact]
        public void ReadFromStream() {
            using var stream = new MemoryStream(Bytes);
            var packet = (ObjectPlacePacket)Packet.ReadFromStream(stream, PacketContext.Server);

            packet.ObjectX.Should().Be(256);
            packet.ObjectY.Should().Be(100);
            packet.ObjectType.Should().Be(BlockType.Chests);
            packet.ObjectStyle.Should().Be(1);
            packet.ObjectRandomState.Should().Be(-1);
            packet.ObjectDirection.Should().BeTrue();
        }

        [Fact]
        public void DeserializeAndSerialize_SamePacket() => Bytes.ShouldDeserializeAndSerializeSamePacket();
    }
}
