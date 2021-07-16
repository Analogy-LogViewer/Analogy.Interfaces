using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Analogy.Interfaces
{
    public interface IAnalogyOnDemandPlotting
    {
        event EventHandler<(Guid Id, IEnumerable<AnalogyPlottingPointData> PointsData)> OnNewPointsData;
        /// <summary>
        /// id of the plot data provider
        /// </summary>
        public Guid Id { get; }
        /// <summary>
        /// called after creation during startup Of Analogy
        /// </summary>
        /// <param name="onDemandPlottingInteractor"> the object that manager UI interactions</param>
        /// <param name="logger"></param>
        /// <returns></returns>
        Task InitializeOnDemandPlotting(IAnalogyOnDemandPlottingInteractor onDemandPlottingInteractor, IAnalogyLogger logger);

    }
}
