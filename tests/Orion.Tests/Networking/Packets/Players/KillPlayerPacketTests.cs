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

using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace Orion.Networking.Packets.Players {
    public class KillPlayerPacketTests {
        [Fact]
        public void SetDefaultableProperties_MarkAsDirty() {
            var packet = new KillPlayerPacket();

            packet.ShouldHaveDefaultablePropertiesMarkAsDirty();
        }

        [Fact]
        public void SetPlayerDeathReason_MarksAsDirty() {
            var packet = new KillPlayerPacket();

            packet.PlayerDeathReason = Terraria.DataStructures.PlayerDeathReason.ByCustomReason("test");

            packet.ShouldBeDirty();
        }

        [Fact]
        public void SetPlayerDeathReason_NullValue_ThrowsArgumentNullException() {
            var packet = new KillPlayerPacket();
            Action action = () => packet.PlayerDeathReason = null;

            action.Should().Throw<ArgumentNullException>();
        }

        public static readonly byte[] Bytes = {14, 0, 118, 0, 128, 4, 116, 101, 115, 116, 100, 0, 1, 1};

        [Fact]
        public void ReadFromStream_IsCorrect() {
            using (var stream = new MemoryStream(Bytes)) {
                var packet = (KillPlayerPacket)Packet.ReadFromStream(stream, PacketContext.Server);

                packet.PlayerIndex.Should().Be(0);
                packet.PlayerDeathReason.SourceCustomReason.Should().Be("test");
                packet.Damage.Should().Be(100);
                packet.HitDirection.Should().Be(0);
                packet.IsDeathFromPvp.Should().BeTrue();
            }
        }

        [Fact]
        public void WriteToStream_IsCorrect() {
            Bytes.ShouldDeserializeAndSerializeSamePacket();
        }
    }
}
