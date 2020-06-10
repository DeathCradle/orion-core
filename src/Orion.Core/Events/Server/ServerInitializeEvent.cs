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

namespace Orion.Core.Events.Server {
    /// <summary>
    /// An event that occurs when the server is initializing.
    /// </summary>
    /// <remarks>
    /// This event occurs as soon as the server is opened, and can be used to initialize plugin state.
    /// </remarks>
    [Event("server-init")]
    public sealed class ServerInitializeEvent : Event { }
}