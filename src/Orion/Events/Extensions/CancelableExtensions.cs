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
using System.Diagnostics.Contracts;

namespace Orion.Events.Extensions {
    /// <summary>
    /// Provides extensions for the <see cref="ICancelable"/> interface.
    /// </summary>
    public static class CancelableExtensions {
        /// <summary>
        /// Returns a value indicating whether the object is canceled.
        /// </summary>
        /// <param name="cancelable">The cancelable object.</param>
        /// <returns>A value indicating whether the object is canceled.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="cancelable"/> is <c>null</c>.</exception>
        [Pure]
        public static bool IsCanceled(this ICancelable cancelable) {
            if (cancelable is null) throw new ArgumentNullException(nameof(cancelable));

            return cancelable.CancellationReason != null;
        }

        /// <summary>
        /// Cancels the object with the given, optional cancellation reason.
        /// </summary>
        /// <param name="cancelable">The cancelable object.</param>
        /// <param name="cancellationReason">The cancellation reason.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="cancelable"/> or <paramref name="cancellationReason"/> are <c>null</c>.
        /// </exception>
        public static void Cancel(this ICancelable cancelable, string cancellationReason = "") {
            if (cancelable is null) throw new ArgumentNullException(nameof(cancelable));

            cancelable.CancellationReason =
                cancellationReason ?? throw new ArgumentNullException(nameof(cancellationReason));
        }

        /// <summary>
        /// Uncancels the object.
        /// </summary>
        /// <param name="cancelable">The cancelable object.</param>
        /// <exception cref="ArgumentNullException"><paramref name="cancelable"/> is <c>null</c>.</exception>
        public static void Uncancel(this ICancelable cancelable) {
            if (cancelable is null) throw new ArgumentNullException(nameof(cancelable));

            cancelable.CancellationReason = null;
        }
    }
}