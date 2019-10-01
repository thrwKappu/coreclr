// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.X86
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["ConvertToInt64.Vector128Single"] = ConvertToInt64Vector128Single,
                ["ConvertToInt64WithTruncation.Vector128Single"] = ConvertToInt64WithTruncationVector128Single,
                ["ConvertScalarToVector128Single.Single"] = ConvertScalarToVector128SingleSingle,
            };
        }
    }
}
