// ==========================================================================
//  Notifo.io
// ==========================================================================
//  Copyright (c) Sebastian Stehle
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Notifo.Infrastructure;

namespace Notifo.Domain.Log;

public sealed record LogQuery : QueryBase
{
    public string? UserId { get; set; }

    public string? Query { get; set; }

    public string[]? Systems { get; set; }

    public int EventCode { get; set; }
}
