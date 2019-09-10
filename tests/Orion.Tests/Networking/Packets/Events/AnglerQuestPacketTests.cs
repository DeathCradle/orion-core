﻿using System.IO;
using FluentAssertions;
using Orion.Networking.Packets;
using Orion.Networking.Packets.Events;
using Xunit;

namespace Orion.Tests.Networking.Packets.Events {
    public class AnglerQuestPacketTests {
        public static readonly byte[] AnglerQuestBytes = {5, 0, 74, 1, 1,};

        [Fact]
        public void ReadFromStream_IsCorrect() {
            using (var stream = new MemoryStream(AnglerQuestBytes)) {
                var packet = (AnglerQuestPacket)Packet.ReadFromStream(stream, PacketContext.Server);

                packet.CurrentAnglerQuest.Should().Be(1);
                packet.IsAnglerQuestFinished.Should().BeTrue();
            }
        }

        [Fact]
        public void WriteToStream_IsCorrect() {
            using (var stream = new MemoryStream(AnglerQuestBytes))
            using (var stream2 = new MemoryStream()) {
                var packet = Packet.ReadFromStream(stream, PacketContext.Server);

                packet.WriteToStream(stream2, PacketContext.Server);

                stream2.ToArray().Should().BeEquivalentTo(AnglerQuestBytes);
            }
        }
    }
}
