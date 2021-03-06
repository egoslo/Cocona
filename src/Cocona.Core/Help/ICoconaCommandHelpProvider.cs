﻿using Cocona.Command;
using Cocona.Help.DocumentModel;

namespace Cocona.Help
{
    public interface ICoconaCommandHelpProvider
    {
        HelpMessage CreateCommandHelp(CommandDescriptor command);
        HelpMessage CreateCommandsIndexHelp(CommandCollection commandCollection);
        HelpMessage CreateVersionHelp();
    }
}
