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

namespace Orion.Core.Packets.Modules
{
    /// <summary>
    /// An unknown module.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public struct UnknownModule : IModule
    {
        [FieldOffset(4)] private unsafe fixed byte _data[ushort.MaxValue - IPacket.HeaderSize - IModule.HeaderSize];

        /// <summary>
        /// Gets or sets the module length.
        /// </summary>
        /// <value>The module length.</value>
        [field: FieldOffset(0)] public ushort Length { get; set; }

        /// <summary>
        /// Gets or sets the module ID.
        /// </summary>
        /// <value>The module ID.</value>
        [field: FieldOffset(2)] public ModuleId Id { get; set; }

        /// <summary>
        /// Gets the module data.
        /// </summary>
        /// <value>The module data.</value>
        public unsafe Span<byte> Data => MemoryMarshal.CreateSpan(ref _data[0], Length);

        /// <inheritdoc/>
        public unsafe int Read(Span<byte> span, PacketContext context)
        {
            Length = (ushort)span.Length;
            return Length == 0 ? 0 : span.Read(ref this.AsRefByte(4), Length);
        }

        /// <inheritdoc/>
        public unsafe int Write(Span<byte> span, PacketContext context) =>
            Length == 0 ? 0 : span.Write(ref this.AsRefByte(4), Length);
    }
}
