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

namespace Orion.Core.Players {
    /// <summary>
    /// Specifies a player's difficulty.
    /// </summary>
    public enum PlayerDifficulty : byte {
        /// <summary>
        /// Indicates the classic difficulty.
        /// </summary>
        Classic = 0,

        /// <summary>
        /// Indicates the mediumcore difficulty.
        /// </summary>
        Mediumcore = 1,

        /// <summary>
        /// Indicates the hardcore difficulty.
        /// </summary>
        Hardcore = 2,

        /// <summary>
        /// Indicates the journey difficulty.
        /// </summary>
        Journey = 3
    }
}