﻿// Copyright (c) 2020 Pryaxis & Orion Contributors
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
using System.Linq;
using Orion.Events;
using Orion.Events.World.Chests;
using Orion.Packets.World.Chests;
using Orion.Players;
using Orion.World.Tiles;
using Serilog.Core;
using Xunit;

namespace Orion.World.Chests {
    // These tests depend on Terraria state.
    [Collection("TerrariaTestsCollection")]
    public class OrionChestServiceTests {
        [Theory]
        [InlineData(-1)]
        [InlineData(10000)]
        public void Chests_Item_GetInvalidIndex_ThrowsIndexOutOfRangeException(int index) {
            using var kernel = new OrionKernel(Logger.None);
            using var chestService = new OrionChestService(kernel, Logger.None);

            Assert.Throws<IndexOutOfRangeException>(() => chestService.Chests[index]);
        }

        [Fact]
        public void Chests_Item_Get() {
            Terraria.Main.chest[1] = new Terraria.Chest();

            using var kernel = new OrionKernel(Logger.None);
            using var chestService = new OrionChestService(kernel, Logger.None);
            var chest = chestService.Chests[1];

            Assert.Equal(1, chest.Index);
            Assert.Same(Terraria.Main.chest[1], ((OrionChest)chest).Wrapped);
        }

        [Fact]
        public void Chests_Item_GetMultipleTimes_ReturnsSameInstance() {
            Terraria.Main.chest[0] = new Terraria.Chest();

            using var kernel = new OrionKernel(Logger.None);
            using var chestService = new OrionChestService(kernel, Logger.None);

            var chest = chestService.Chests[0];
            var chest2 = chestService.Chests[0];

            Assert.Same(chest, chest2);
        }

        [Fact]
        public void Chests_GetEnumerator() {
            for (var i = 0; i < Terraria.Main.maxChests; ++i) {
                Terraria.Main.chest[i] = new Terraria.Chest();
            }

            using var kernel = new OrionKernel(Logger.None);
            using var chestService = new OrionChestService(kernel, Logger.None);

            var chests = chestService.Chests.ToList();

            for (var i = 0; i < chests.Count; ++i) {
                Assert.Same(Terraria.Main.chest[i], ((OrionChest)chests[i]).Wrapped);
            }
        }

        [Fact]
        public void PacketReceive_ChestOpenEventTriggered() {
            // Set `State` to 10 so that the chest open packet is not ignored by the server.
            var socket = new TestSocket { Connected = true };
            Terraria.Netplay.Clients[5] = new Terraria.RemoteClient { Id = 5, State = 10, Socket = socket };
            Terraria.Main.player[5] = new Terraria.Player { whoAmI = 5 };
            Terraria.Main.tile[256, 100] = new Terraria.Tile { type = (ushort)BlockId.Chests };
            Terraria.Main.chest[0] = new Terraria.Chest { x = 256, y = 100, name = "test" };

            using var kernel = new OrionKernel(Logger.None);
            using var playerService = new OrionPlayerService(kernel, Logger.None);
            using var chestService = new OrionChestService(kernel, Logger.None);

            var isRun = false;
            kernel.RegisterHandler<ChestOpenEvent>(evt => {
                Assert.Same(chestService.Chests[0], evt.Chest);
                Assert.Same(playerService.Players[5], evt.Player);
                isRun = true;
            }, Logger.None);

            TestUtils.FakeReceiveBytes(5, ChestOpenPacketTests.Bytes);

            Assert.True(isRun);
            Assert.NotEmpty(socket.SendData);
        }

        [Fact]
        public void PacketReceive_ChestOpenEventCanceled() {
            // Set `State` to 10 so that the chest open packet is not ignored by the server.
            var socket = new TestSocket { Connected = true };
            Terraria.Netplay.Clients[5] = new Terraria.RemoteClient { Id = 5, State = 10, Socket = socket };
            Terraria.Main.player[5] = new Terraria.Player { whoAmI = 5 };
            Terraria.Main.chest[0] = new Terraria.Chest { x = 256, y = 100, name = "test" };

            using var kernel = new OrionKernel(Logger.None);
            using var playerService = new OrionPlayerService(kernel, Logger.None);
            using var chestService = new OrionChestService(kernel, Logger.None);

            Terraria.Main.tile[256, 100] = new Terraria.Tile { type = (ushort)BlockId.Chests };

            kernel.RegisterHandler<ChestOpenEvent>(evt => evt.Cancel(), Logger.None);

            TestUtils.FakeReceiveBytes(5, ChestOpenPacketTests.Bytes);

            Assert.Empty(socket.SendData);
        }

        [Fact]
        public void PacketReceive_ChestOpenEventNotTriggered() {
            // Set `State` to 10 so that the chest open packet is not ignored by the server.
            var socket = new TestSocket { Connected = true };
            Terraria.Netplay.Clients[5] = new Terraria.RemoteClient { Id = 5, State = 10, Socket = socket };
            Terraria.Main.player[5] = new Terraria.Player { whoAmI = 5 };
            Terraria.Main.tile[256, 100] = new Terraria.Tile { type = (ushort)BlockId.Chests };
            Terraria.Main.chest[0] = new Terraria.Chest { x = 255, y = 100, name = "test" };

            using var kernel = new OrionKernel(Logger.None);
            using var playerService = new OrionPlayerService(kernel, Logger.None);
            using var chestService = new OrionChestService(kernel, Logger.None);

            var isRun = false;
            kernel.RegisterHandler<ChestOpenEvent>(evt => isRun = true, Logger.None);

            TestUtils.FakeReceiveBytes(5, ChestOpenPacketTests.Bytes);

            Assert.False(isRun);
        }

        private class TestSocket : Terraria.Net.Sockets.ISocket {
            public bool Connected { get; set; }
            public byte[] SendData { get; private set; } = Array.Empty<byte>();

            public void AsyncReceive(
                byte[] data, int offset, int size, Terraria.Net.Sockets.SocketReceiveCallback callback,
                object? state = null) =>
                    throw new NotImplementedException();
            public void AsyncSend(
                byte[] data, int offset, int size, Terraria.Net.Sockets.SocketSendCallback callback,
                object? state = null) =>
                    SendData = data[offset..(offset + size)];
            public void Close() => throw new NotImplementedException();
            public void Connect(Terraria.Net.RemoteAddress address) => throw new NotImplementedException();
            public Terraria.Net.RemoteAddress GetRemoteAddress() => throw new NotImplementedException();
            public bool IsConnected() => Connected;
            public bool IsDataAvailable() => throw new NotImplementedException();
            public void SendQueuedPackets() => throw new NotImplementedException();
            public bool StartListening(Terraria.Net.Sockets.SocketConnectionAccepted callback) =>
                throw new NotImplementedException();
            public void StopListening() => throw new NotImplementedException();
        }
    }
}
