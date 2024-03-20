// ==========================================================================
//  Notifo.io
// ==========================================================================
//  Copyright (c) Sebastian Stehle
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Notifo.Domain.Apps;
using Notifo.Domain.ChannelTemplates;
using Notifo.Domain.Users;
using Notifo.Domain.Utils;

namespace Notifo.Domain.Channels.Messaging;

public interface IMessagingFormatter : IChannelTemplateFactory<MessagingTemplate>
{
    (string Result, List<TemplateError>? Errors) Format(MessagingTemplate? template, MessagingJob job, App app, User user);
}
