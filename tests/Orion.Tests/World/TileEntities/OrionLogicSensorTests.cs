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

using FluentAssertions;
using Orion.World.TileEntities;
using Xunit;
using TDS = Terraria.DataStructures;
using TGCTE = Terraria.GameContent.Tile_Entities;

namespace Orion.Tests.World.TileEntities {
    public class OrionLogicSensorTests {
        [Theory]
        [InlineData(100)]
        public void GetIndex_IsCorrect(int index) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor {ID = index};
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.Index.Should().Be(index);
        }

        [Theory]
        [InlineData(100)]
        public void GetX_IsCorrect(int x) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor {Position = new TDS.Point16(x, 0)};
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.X.Should().Be(x);
        }

        [Theory]
        [InlineData(100)]
        public void SetX_IsCorrect(int x) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor();
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.X = x;

            terrariaLogicSensor.Position.X.Should().Be((short)x);
        }

        [Theory]
        [InlineData(100)]
        public void GetY_IsCorrect(int y) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor {Position = new TDS.Point16(0, y)};
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.Y.Should().Be(y);
        }

        [Theory]
        [InlineData(100)]
        public void SetY_IsCorrect(int y) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor();
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.Y = y;

            terrariaLogicSensor.Position.Y.Should().Be((short)y);
        }

        [Theory]
        [InlineData(LogicSensorType.Day)]
        public void GetType_IsCorrect(LogicSensorType type) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor {logicCheck = (TGCTE.TELogicSensor.LogicCheckType)type};
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.SensorType.Should().Be(type);
        }

        [Theory]
        [InlineData(LogicSensorType.Day)]
        public void SetType_IsCorrect(LogicSensorType type) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor();
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.SensorType = type;

            terrariaLogicSensor.logicCheck.Should().Be((TGCTE.TELogicSensor.LogicCheckType)type);
        }

        [Theory]
        [InlineData(true)]
        public void GetIsActivated_IsCorrect(bool isActivated) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor {On = isActivated};
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.IsActivated.Should().Be(isActivated);
        }

        [Theory]
        [InlineData(true)]
        public void SetIsActivated_IsCorrect(bool isActivated) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor();
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.IsActivated = isActivated;

            terrariaLogicSensor.On.Should().Be(isActivated);
        }

        [Theory]
        [InlineData(100)]
        public void GetData_IsCorrect(int data) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor {CountedData = data};
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.Data.Should().Be(data);
        }

        [Theory]
        [InlineData(100)]
        public void SetData_IsCorrect(int data) {
            var terrariaLogicSensor = new TGCTE.TELogicSensor();
            var logicSensor = new OrionLogicSensor(terrariaLogicSensor);

            logicSensor.Data = data;

            terrariaLogicSensor.CountedData.Should().Be(data);
        }
    }
}
