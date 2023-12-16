using SkiaSharp;

namespace EconomyGraph.Models
{
    public class Footer
    {
        public string Text { get; set; }
        public SKColor Color { get; set; } = SKColors.Black;
        public int PointSize { get; set; } = -1;
        public bool Bold { get; set; }
        public float Scale { get; set; } = 1;
        public float Height
        {
            get 
            { 
                if (DeviceInfo.Platform == DevicePlatform.Android)
                {
                    return PointSize * Scale;
                }
                else  if (DeviceInfo.Platform == DevicePlatform.WinUI)
                {
                    return PointSize * Scale;
                }
                return PointSize * 1.25f * Scale; 
            }
        }
        // Top - xPos (of drawing point) - PointSiuze * Scale
        public float Top(float xPos) { return xPos - PointSize * Scale; }
    }
}
