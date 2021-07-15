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
        /// called after creation 
        /// </summary>
        /// <param name="onDemandPlottingManager"> the object that manager UI interactions</param>
        /// <param name="logger"></param>
        /// <returns></returns>
        Task InitializeOnDemandPlottingAsync(IAnalogyOnDemandPlottingInteractor onDemandPlottingManager, IAnalogyLogger logger);

    }
}
