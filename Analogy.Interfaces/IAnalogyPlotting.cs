﻿using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    public interface IAnalogyPlotting
    {
        event EventHandler<AnalogyPlottingPointData> OnNewPointData;
        IEnumerable<(string SeriesName, AnalogyPlottingSeriesType SeriesViewType)> GetChartSeries();
        Guid Id { get; set; }
        /// <summary>
        /// the factory id which this Data providers factory belongs to
        /// </summary>
        Guid FactoryId { get; set; }
        string Title { get; set; }
        Task InitializePlottingAsync(IAnalogyLogger logger);
        Task StartPlotting();
        Task StopPlotting();
    }
}
