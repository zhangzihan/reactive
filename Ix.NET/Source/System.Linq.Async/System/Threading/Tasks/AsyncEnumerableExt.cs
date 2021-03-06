﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information. 

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
    internal static class AsyncEnumerableExt
    {
        public static ConfiguredCancelableAsyncEnumerable<T>.Enumerator GetConfiguredAsyncEnumerator<T>(this IAsyncEnumerable<T> enumerable, CancellationToken cancellationToken, bool continueOnCapturedContext)
        {
            return AsyncEnumerableExtensions.ConfigureAwait(enumerable, continueOnCapturedContext).WithCancellation(cancellationToken).GetAsyncEnumerator();
        }
    }
}
