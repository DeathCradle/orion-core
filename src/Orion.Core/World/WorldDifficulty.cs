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

namespace Orion.Core.World
{
    /// <summary>
    /// Specifies a world's difficulty.
    /// </summary>
    public enum WorldDifficulty : byte
    {
        /// <summary>
        /// Indicates classic mode.
        /// </summary>
        Classic = 0,

        /// <summary>
        /// Indicates expert mode.
        /// </summary>
        Expert = 1,

        /// <summary>
        /// Indicates master mode.
        /// </summary>
        Master = 2,

        /// <summary>
        /// Indicates journey mode.
        /// </summary>
        Journey = 3
    }
}
