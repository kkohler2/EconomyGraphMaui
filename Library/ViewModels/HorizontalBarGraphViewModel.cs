using EconomyGraph.Models;
using SkiaSharp;

namespace EconomyGraph.ViewModels
{
    public class HorizontalBarGraphViewModel
    {
        public SKColor? BackgroundColor { get; set; }
        public Models.Label Title { get; set; }
        public Models.Label SubTitle { get; set; }
        public Models.Label LeftFooter { get; set; }
        #region RightFooter
        Models.Label rightFooter;
        public Models.Label RightFooter 
        { 
            get { return rightFooter; }
            set
            {
                value.TextAlignment = TextAlignment.End;
                rightFooter = value;
            }
        }
        #endregion
        public List<HorizontalBarGraphDataPoint> DataPoints { get; set; } = new List<HorizontalBarGraphDataPoint>();
    }
}
