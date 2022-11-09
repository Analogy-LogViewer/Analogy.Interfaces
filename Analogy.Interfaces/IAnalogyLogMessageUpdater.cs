﻿using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    /// <summary>
    /// Interface for changing Loaded Messages instead of creating New one
    /// </summary>
    public interface IAnalogyLogMessageUpdater
    {
        event EventHandler<AnalogyLogMessageUpdaterEventData> OnMessageChanged;
        Task InitializeUpdater(IAnalogyLogger logger);

    }
}