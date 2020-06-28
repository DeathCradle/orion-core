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
using System.Runtime.InteropServices;
using Orion.Core.Utils;

namespace Orion.Core.Packets.DataStructures.Modules
{
    /// <summary>
    /// A module sent for a ping on the map.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct Ping : IModule
    {
        [FieldOffset(0)] private byte _bytes;  // Used to obtain an interior reference.

        /// <summary>
        /// Gets or sets the ping's position.
        /// </summary>
        /// <value>The ping's position.</value>
        [field: FieldOffset(0)] public Vector2f Position { get; set; }

        ModuleId IModule.Id => ModuleId.Ping;

        int IModule.ReadBody(Span<byte> span, PacketContext context) => span.Read(ref _bytes, 8);
        int IModule.WriteBody(Span<byte> span, PacketContext context) => span.Read(ref _bytes, 8);
    }
}
