// ==========================================================================
//  Notifo.io
// ==========================================================================
//  Copyright (c) Sebastian Stehle
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using NodaTime;

namespace Notifo.Domain.UserNotifications;

public sealed class DeviceNotificationsQuery
{
    public string? DeviceIdentifier { get; set; }

    public Instant After { get; set; }

    public DeviceNotificationsQueryScope Scope { get; set; }

    public int Take { get; set; }

    public UserNotificationQuery ToBaseQuery()
    {
        return new UserNotificationQuery { Take = Take, After = After };
    }
}
