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

using System;
using System.Diagnostics.CodeAnalysis;
using FluentAssertions;
using Orion.World.Tiles;
using Xunit;

namespace Orion.Packets.World.Tiles {
    public class NetworkTilesTests {
        [Fact]
        public void Ctor_WidthNegative_ThrowsArgumentOutOfRangeException() {
            Func<NetworkTiles> func = () => new NetworkTiles(-1, 0);

            func.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Ctor_HeightNegative_ThrowsArgumentOutOfRangeException() {
            Func<NetworkTiles> func = () => new NetworkTiles(0, -1);

            func.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        [SuppressMessage("ReSharper", "UseObjectOrCollectionInitializer")]
        public void Item_Get_Mutate_MarksAsDirty() {
            var tiles = new NetworkTiles(1, 1);
            tiles[0, 0] = new Tile { BlockType = BlockType.Stone };

            tiles.ShouldBeDirty();
        }
    }
}
