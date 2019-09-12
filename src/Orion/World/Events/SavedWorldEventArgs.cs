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
using System.Diagnostics.CodeAnalysis;

namespace Orion.World.Events {
    /// <summary>
    /// Provides data for the <see cref="IWorldService.SavedWorld"/> handlers.
    /// </summary>
    public sealed class SavedWorldEventArgs : EventArgs {
        /// <summary>
        /// Gets a value indicating whether to reset the time.
        /// </summary>
        [ExcludeFromCodeCoverage]
        public bool ShouldResetTime { get; internal set; }
    }
}
