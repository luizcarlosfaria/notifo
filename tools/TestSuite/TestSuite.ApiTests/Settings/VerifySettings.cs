﻿// ==========================================================================
//  Notifo.io
// ==========================================================================
//  Copyright (c) Sebastian Stehle
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.Runtime.CompilerServices;

namespace TestSuite.ApiTests.Settings;

public static class VerifySettings
{
    [ModuleInitializer]
    public static void Initialize()
    {
        DerivePathInfo((sourceFile, projectDirectory, type, method) =>
        {
            var path = Path.Combine(projectDirectory, "Verify");

            return new PathInfo(path, type.Name, method.Name);
        });
    }
}
