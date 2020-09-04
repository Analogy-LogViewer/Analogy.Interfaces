﻿using System;
using System.Collections.Generic;

namespace Analogy.Interfaces.Factories
{
    public interface IAnalogyCustomActionsFactory
    {
        /// <summary>
        /// the factory id which this actions providers factory belongs to
        /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        IEnumerable<IAnalogyCustomAction> Actions { get; }
    }
}
