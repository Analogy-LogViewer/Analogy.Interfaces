namespace Analogy.Interfaces
{
    public enum AnalogyCustomActionType
    {
        BelongsToProvider,
        Global,
    }
    /// <summary>
    /// LogClass identifies the class of a log event.
    /// </summary>
    public enum AnalogyLogClass
    {
        /// <summary>
        /// Most log events
        /// </summary>
        General,

        /// <summary>
        /// Security logs (audit trails)
        /// </summary>
        Security,

        /// <summary>
        /// Hazard issues
        /// </summary>
        Hazard,
        //
        // Summary:
        //Protected Health Information
        PHI
    }
    /// <summary>
    /// LogLevel enumerates the possible logging levels.
    /// </summary>
    public enum AnalogyLogLevel
    {
        Unknown,
        Trace,
        Verbose,
        Debug,
        Information,
        Warning,
        Error,
        Critical,
        Analogy,
        None
    }
    /// <summary>
    /// The type of data in the RawText Field
    /// </summary>
    public enum AnalogyRowTextType
    {
        None,
        Unknown,
        PlainText,
        RichText,
        JSON,
        XML,
        HTML,
        Markdown,
    }
    public enum AnalogChangeLogType
    {
        None,
        Bug,
        Feature,
        Improvement
    }

    public enum AnalogyLogMessagePropertyName
    {
        Date,
        Id,
        Text,
        Category,
        Source,
        Module,
        MethodName,
        FileName,
        User,
        LineNumber,
        ProcessId,
        ThreadId,
        Level,
        Class,
        MachineName,
        RawText,
        RawTextType
    }

    public enum AnalogyExtensionType
    {
        None = 0,
        InPlace = 1,
        UserControl = 2
    }

    public enum AnalogyDataSourceType
    {
        RealTimeDataSource,
        OfflineDataSource,

    }

    public enum AnalogyPlottingSeriesType
    {
        /// <summary>
        ///   <para>Specifies a series view of the Side-by-Side Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SideBySideBarSeriesView" /> object.</para>
        /// </summary>
        Bar,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StackedBarSeriesView" /> object.</para>
        /// </summary>
        StackedBar,
        /// <summary>
        ///   <para>Specifies a series view of the Full-Stacked Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.FullStackedBarSeriesView" /> object.</para>
        /// </summary>
        FullStackedBar,
        /// <summary>
        ///   <para>Specifies a series view of the Side-by-Side Stacked Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SideBySideStackedBarSeriesView" /> object.</para>
        /// </summary>
        SideBySideStackedBar,
        /// <summary>
        ///   <para>Specifies a series view of the Side-by-Side Full-Stacked Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SideBySideFullStackedBarSeriesView" /> object.</para>
        /// </summary>
        SideBySideFullStackedBar,
        /// <summary>
        ///   <para>Specifies a series view of the Pie type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.PieSeriesView" /> object.</para>
        /// </summary>
        Pie,
        /// <summary>
        ///   <para>Specifies a series view of the Doughnut type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.DoughnutSeriesView" /> object.</para>
        /// </summary>
        Doughnut,
        /// <summary>
        ///   <para>Specifies a series view of the Nested Doughnut type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.NestedDoughnutSeriesView" /> object.</para>
        /// </summary>
        NestedDoughnut,
        /// <summary>
        ///   <para>Specifies a series view of the Funnel type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.FunnelSeriesView" /> object.</para>
        /// </summary>
        Funnel,
        /// <summary>
        ///   <para>Specifies a series view of the Point type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.PointSeriesView" /> object.</para>
        /// </summary>
        Point,
        /// <summary>
        ///   <para>Specifies a series view of the Bubble type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.BubbleSeriesView" /> object.</para>
        /// </summary>
        Bubble,
        /// <summary>
        ///   <para>Specifies a series view of the Line type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.LineSeriesView" /> object.</para>
        /// </summary>
        Line,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Line type. This view type is specified by a <see cref="T:DevExpress.XtraCharts.StackedLineSeriesView" /> object.</para>
        /// </summary>
        StackedLine,
        /// <summary>
        ///   <para>Specifies a series view of the Full-Stacked Line type. This view type is specified by a <see cref="T:DevExpress.XtraCharts.FullStackedLineSeriesView" /> object.</para>
        /// </summary>
        FullStackedLine,
        /// <summary>
        ///   <para>Specifies a series view of the Step Line type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StepLineSeriesView" /> object.</para>
        /// </summary>
        StepLine,
        /// <summary>
        ///   <para>Specifies a series view of the Spline type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SplineSeriesView" /> object.</para>
        /// </summary>
        Spline,
        /// <summary>
        ///   <para>Specifies a series view of the Scatter Line type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.ScatterLineSeriesView" /> object.</para>
        /// </summary>
        ScatterLine,
        /// <summary>
        ///   <para>Specifies a series view of the Swift Plot type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SwiftPlotSeriesView" /> object.</para>
        /// </summary>
        SwiftPlot,
        /// <summary>
        ///   <para>Specifies a series view of the Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.AreaSeriesView" /> object.</para>
        /// </summary>
        Area,
        /// <summary>
        ///   <para>Specifies a series view of the Step Area type. This view type is specified by a <see cref="T:DevExpress.XtraCharts.StepAreaSeriesView" /> object.</para>
        /// </summary>
        StepArea,
        /// <summary>
        ///   <para>Specifies a series view of the Spline Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SplineAreaSeriesView" /> object.</para>
        /// </summary>
        SplineArea,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StackedAreaSeriesView" /> object.</para>
        /// </summary>
        StackedArea,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Step Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StackedStepAreaSeriesView" /> object.</para>
        /// </summary>
        StackedStepArea,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Spline Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StackedSplineAreaSeriesView" /> object.</para>
        /// </summary>
        StackedSplineArea,
        /// <summary>
        ///   <para>Specifies a series view of the Full Stacked Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.FullStackedAreaSeriesView" /> object.</para>
        /// </summary>
        FullStackedArea,
        /// <summary>
        ///   <para>Specifies a series view of the Full-Stacked Spline Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.FullStackedSplineAreaSeriesView" /> object.</para>
        /// </summary>
        FullStackedSplineArea,
        /// <summary>
        ///   <para>Specifies a series view of the Full-Stacked Step Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.FullStackedStepAreaSeriesView" /> object.</para>
        /// </summary>
        FullStackedStepArea,
        /// <summary>
        ///   <para>Specifies a series view of the Range Area type. This view type is specified by a <see cref="T:DevExpress.XtraCharts.RangeAreaSeriesView" /> object.</para>
        /// </summary>
        RangeArea,
        /// <summary>
        ///   <para>Specifies a series view of the Stock type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StockSeriesView" /> object.</para>
        /// </summary>
        Stock,
        /// <summary>
        ///   <para>Specifies a series view of the Candle Stick type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.CandleStickSeriesView" /> object.</para>
        /// </summary>
        CandleStick,
        /// <summary>
        ///   <para>Specifies a series view of the Side-by-Side Range Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SideBySideRangeBarSeriesView" /> object.</para>
        /// </summary>
        SideBySideRangeBar,
        /// <summary>
        ///   <para>Specifies a series view of the Range Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.RangeBarSeriesView" /> object.</para>
        /// </summary>
        RangeBar,
        /// <summary>
        ///   <para>Specifies a series view of the Side-by-Side Gantt type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SideBySideGanttSeriesView" /> object.</para>
        /// </summary>
        SideBySideGantt,
        /// <summary>
        ///   <para>Specifies a series view of the Gantt type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.GanttSeriesView" /> object.</para>
        /// </summary>
        Gantt,
        /// <summary>
        ///   <para>Specifies a series view of the Polar Point type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.PolarPointSeriesView" /> object.</para>
        /// </summary>
        PolarPoint,
        /// <summary>
        ///   <para>Specifies a series view of the Polar Line type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.PolarLineSeriesView" /> object.</para>
        /// </summary>
        PolarLine,
        /// <summary>
        ///   <para>Specifies a series view of the polar scatter line type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.ScatterPolarLineSeriesView" /> object.</para>
        /// </summary>
        ScatterPolarLine,
        /// <summary>
        ///   <para>Specifies a series view of the Polar Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.PolarAreaSeriesView" /> object.</para>
        /// </summary>
        PolarArea,
        /// <summary>
        ///   <para>Specifies a series view of the Polar Range Area Chart type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.PolarRangeAreaSeriesView" /> object.</para>
        /// </summary>
        PolarRangeArea,
        /// <summary>
        ///   <para>Specifies a series view of the Radar Point type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.RadarPointSeriesView" /> object.</para>
        /// </summary>
        RadarPoint,
        /// <summary>
        ///   <para>Specifies a series view of the Radar Line type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.RadarLineSeriesView" /> object.</para>
        /// </summary>
        RadarLine,
        /// <summary>
        ///   <para>Specifies a series view of the radar scatter line type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.ScatterRadarLineSeriesView" /> object.</para>
        /// </summary>
        ScatterRadarLine,
        /// <summary>
        ///   <para>Specifies a series view of the Radar Area type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.RadarAreaSeriesView" /> object.</para>
        /// </summary>
        RadarArea,
        /// <summary>
        ///   <para>Specifies a series view of the Radar Range Area Chart type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.RadarRangeAreaSeriesView" /> object.</para>
        /// </summary>
        RadarRangeArea,
        /// <summary>
        ///   <para>Specifies a series view of the Side-by-Side Bar 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SideBySideBar3DSeriesView" /> object.</para>
        /// </summary>
        Bar3D,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Bar 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StackedBar3DSeriesView" /> object.</para>
        /// </summary>
        StackedBar3D,
        /// <summary>
        ///   <para>Specifies a series view of the Full-Stacked Bar 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.FullStackedBar3DSeriesView" /> object.</para>
        /// </summary>
        FullStackedBar3D,
        /// <summary>
        ///   <para>Specifies a series view of the Manhattan Bar 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.ManhattanBarSeriesView" /> object.</para>
        /// </summary>
        ManhattanBar,
        /// <summary>
        ///   <para>Specifies a series view of the 3D Side-by-Side Stacked Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SideBySideStackedBar3DSeriesView" /> object.</para>
        /// </summary>
        SideBySideStackedBar3D,
        /// <summary>
        ///   <para>Specifies a series view of the 3D Side-by-Side Full-Stacked Bar type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SideBySideFullStackedBar3DSeriesView" /> object.</para>
        /// </summary>
        SideBySideFullStackedBar3D,
        /// <summary>
        ///   <para>Specifies a series view of the Pie 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.Pie3DSeriesView" /> object.</para>
        /// </summary>
        Pie3D,
        /// <summary>
        ///   <para>Specifies a series view of the Doughnut 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.Doughnut3DSeriesView" /> object.</para>
        /// </summary>
        Doughnut3D,
        /// <summary>
        ///   <para>Specifies a series view of the Funnel 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.Funnel3DSeriesView" /> object.</para>
        /// </summary>
        Funnel3D,
        /// <summary>
        ///   <para>Specifies a series view of the Line 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.Line3DSeriesView" /> object.</para>
        /// </summary>
        Line3D,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Line 3D type. This view type is specified by a <see cref="T:DevExpress.XtraCharts.StackedLine3DSeriesView" /> object.</para>
        /// </summary>
        StackedLine3D,
        /// <summary>
        ///   <para>Specifies a series view of the Full-Stacked Line 3D type. This view type is specified by a <see cref="T:DevExpress.XtraCharts.FullStackedLine3DSeriesView" /> object.</para>
        /// </summary>
        FullStackedLine3D,
        /// <summary>
        ///   <para>Specifies a series view of the Step Line 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StepLine3DSeriesView" /> object.</para>
        /// </summary>
        StepLine3D,
        /// <summary>
        ///   <para>Specifies a series view of the Area 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.Area3DSeriesView" /> object.</para>
        /// </summary>
        Area3D,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Area 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StackedArea3DSeriesView" /> object.</para>
        /// </summary>
        StackedArea3D,
        /// <summary>
        ///   <para>Specifies a series view of the Full-Stacked Area 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.FullStackedArea3DSeriesView" /> object.</para>
        /// </summary>
        FullStackedArea3D,
        /// <summary>
        ///   <para>Specifies a series view of the Step Area 3D type. This view type is specified by a <see cref="T:DevExpress.XtraCharts.StepArea3DSeriesView" /> object.</para>
        /// </summary>
        StepArea3D,
        /// <summary>
        ///   <para>Specifies a series view of the Spline 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.Spline3DSeriesView" /> object.</para>
        /// </summary>
        Spline3D,
        /// <summary>
        ///   <para>Specifies a series view of the Spline Area 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.SplineArea3DSeriesView" /> object.</para>
        /// </summary>
        SplineArea3D,
        /// <summary>
        ///   <para>Specifies a series view of the Stacked Spline Area 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.StackedSplineArea3DSeriesView" /> object.</para>
        /// </summary>
        StackedSplineArea3D,
        /// <summary>
        ///   <para>Specifies a series view of the Full-Stacked Spline Area 3D type. This view type is represented by a <see cref="T:DevExpress.XtraCharts.FullStackedSplineArea3DSeriesView" /> object.</para>
        /// </summary>
        FullStackedSplineArea3D,
        /// <summary>
        ///   <para>Specifies a series view of the Range Area 3D type. This view type is specified by a <see cref="T:DevExpress.XtraCharts.RangeArea3DSeriesView" /> object.</para>
        /// </summary>
        RangeArea3D,
    }

    public enum AnalogyFileReadProgressType
    {
        Percentage,
        Incremental
    }

    public enum AnalogyOnDemandPlottingStartupType
    {
        TabbedWindow,
        FloatingWindow
    }

    public enum AnalogyPlottingPointXAxisDataType
    {
        DateTime,
        Numerical,
    }

    public enum AnalogyColumnFilterType
    {
        Include,
        Exclude
    }
}
