using Android.App;
using Android.Widget;
using Android.OS;
using Com.Syncfusion.Gauges.SfCircularGauge;
using System.Collections.ObjectModel;
using Android.Graphics;

namespace DoubleGaugeAndroid
{
    [Activity(Label = "DoubleGaugeAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SfCircularGauge circularGauge = new SfCircularGauge(this);
            circularGauge.SetBackgroundColor(Color.White);
            ObservableCollection<CircularScale> scales = new ObservableCollection<CircularScale>();

           

            CircularScale scale1 = new CircularScale();
            scale1.ShowTicks = false;
            scale1.StartValue = 0;
            scale1.EndValue = 100;
            scale1.StartAngle = 160;
            scale1.SweepAngle = 220;
            scale1.ShowLabels = false;
            scale1.RimColor = Color.ParseColor("#f4deeb");
            scale1.ScaleStartOffset = 0.9;
            scale1.ScaleEndOffset = 0.5;
            

            CircularRange range1 = new CircularRange();
            range1.StartValue = 0;
            range1.EndValue = 70;
            range1.OuterStartOffset = 0.9;
            range1.OuterEndOffset = 0.9;
            range1.InnerStartOffset = 0.7;
            range1.InnerEndOffset = 0.7;
            scale1.CircularRanges.Add(range1);

            ObservableCollection<GaugeGradientStop> gradientColor1 = new ObservableCollection<GaugeGradientStop>();

            GaugeGradientStop gaugeGradientStop = new GaugeGradientStop();
            gaugeGradientStop.Value = 0;
            gaugeGradientStop.Color = Color.WhiteSmoke;
            gradientColor1.Add(gaugeGradientStop);

            GaugeGradientStop gaugeGradientStop1 = new GaugeGradientStop();
            gaugeGradientStop1.Value = 50;
            gaugeGradientStop1.Color = Color.Olive;
            gradientColor1.Add(gaugeGradientStop1);

            CircularRange range2 = new CircularRange();
            range2.StartValue = 0;
            range2.EndValue = 40;
            range2.OuterStartOffset = 0.7;
            range2.OuterEndOffset = 0.7;
            range2.InnerStartOffset = 0.5;
            range2.InnerEndOffset = 0.5;


            ObservableCollection<GaugeGradientStop> gradientColor2 = new ObservableCollection<GaugeGradientStop>();


            GaugeGradientStop gaugeGradientStop2 = new GaugeGradientStop();
            gaugeGradientStop2.Value = 0;
            gaugeGradientStop2.Color = Color.ParseColor("#d5f7cd");
            gradientColor2.Add(gaugeGradientStop2);

            GaugeGradientStop gaugeGradientStop3 = new GaugeGradientStop();
            gaugeGradientStop3.Value = 20;
            gaugeGradientStop3.Color = Color.ParseColor("#5af736");
            gradientColor2.Add(gaugeGradientStop3);

            GaugeGradientStop gaugeGradientStop4 = new GaugeGradientStop();
            gaugeGradientStop4.Value = 35;
            gaugeGradientStop4.Color = Color.DarkGreen;
            gradientColor2.Add(gaugeGradientStop4);

            range1.GradientStops = gradientColor1;
            range2.GradientStops = gradientColor2;

            scale1.CircularRanges.Add(range1);
            scale1.CircularRanges.Add(range2);

            scales.Add(scale1);

           
          
            circularGauge.CircularScales = scales;

            SetContentView(circularGauge);
        }
    }
}

