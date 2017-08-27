﻿//The MIT License(MIT)

//Copyright(c) 2016 Alberto Rodríguez Orozco & LiveCharts Contributors

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

using LiveCharts.Definitions.Charts;
using LiveCharts.Definitions.Points;
using LiveCharts.Definitions.Series;
using LiveCharts.Dtos;

namespace LiveCharts
{
    /// <summary>
    /// Defines a point in the chart.
    /// </summary>
    public class ChartPoint
    {
        private bool _selected;

        /// <summary>
        /// Gets the X point value
        /// </summary>
        public double X { get; internal set; }

        /// <summary>
        /// Gets the Y point value
        /// </summary>
        public double Y { get; internal set; }

        /// <summary>
        /// Gets the Fill brush of this point, this property overrides series Fill property 
        /// </summary>
        public object Fill { get; internal set; }
        /// <summary>
        /// Gets the Stroke brush of this point, this property overrides series Stroke property
        /// </summary>
        public object Stroke { get; internal set; }

        /// <summary>
        /// Gets the coordinate where the value is placed at chart
        /// </summary>
        public CorePoint ChartLocation { get; internal set; }

        /// <summary>
        /// Gets or sets the area where the point is in the UI.
        /// </summary>
        /// <value>
        /// The visual area.
        /// </value>
        public ResponsiveArea ResponsiveArea { get; set; }

        /// <summary>
        /// Gets the index of this point in the chart
        /// </summary>
        public int Key { get; internal set; }

        /// <summary>
        /// Gets the object where the chart pulled the point
        /// </summary>
        public object Instance { get; internal set; }

        /// <summary >
        /// Gets or sets the view of this chart point
        /// </summary>
        public IChartPointView View { get; internal set; }

        /// <summary>
        /// Gets the series where the point belongs to
        /// </summary>
        public ISeriesView SeriesView { get; internal set; }

        /// <summary>
        /// Gets the chart view.
        /// </summary>
        /// <value>
        /// The chart view.
        /// </value>
        public IChart2DView ChartView => SeriesView.Core.Chart.View;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ChartPoint"/> is selected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if selected; otherwise, <c>false</c>.
        /// </value>
        public bool Selected
        {
            get { return _selected; }
            set
            {
                var changed = value != _selected;

                _selected = value;

                if (!changed) return;

                if (_selected)
                {
                    View.OnSelection();
                }
                else
                {
                    View.OnSelectionLeave();
                }
            }
        }

        internal double Gci { get; set; }

        /// <summary>
        /// Gets the Weight of the point
        /// </summary>
        public double Weight { get; internal set; }

        /// <summary>
        /// Gets where the stacked value started from
        /// </summary>
        public double From { get; internal set; }

        /// <summary>
        /// Gets where the stacked value finishes
        /// </summary>
        public double To { get; internal set; }

        /// <summary>
        /// Get the total sum of the stacked elements
        /// </summary>
        public double Sum { get; internal set; }

        /// <summary>
        /// Get the participation of the point in the stacked elements
        /// </summary>
        public double Participation { get; internal set; }

        /// <summary>
        /// gets the stacked participation of a point
        /// </summary>
        public double StackedParticipation { get; internal set; }

        /// <summary>
        /// Gets or sets the x start.
        /// </summary>
        /// <value>
        /// The x start.
        /// </value>
        public double XStart { get; set; }

        /// <summary>
        /// Gets or sets the y start.
        /// </summary>
        /// <value>
        /// The y start.
        /// </value>
        public double YStart { get; set; }

        /// <summary>
        /// Gets or sets the x edn.
        /// </summary>
        /// <value>
        /// The x edn.
        /// </value>
        public double XEnd { get; set; }

        /// <summary>
        /// Gets or sets the y end.
        /// </summary>
        /// <value>
        /// The y end.
        /// </value>
        public double YEnd { get; set; }

        /// <summary>
        /// Gets the Open value of the point
        /// </summary>
        public double Open { get; internal set; }

        /// <summary>
        /// Gets the High value of the point
        /// </summary>
        public double High { get; internal set; }

        /// <summary>
        /// Gets the Low value of the point
        /// </summary>
        public double Low { get; internal set; }

        /// <summary>
        /// Gets the Close value of the point
        /// </summary>
        public double Close { get; internal set; }

        /// <summary>
        /// Gets the Radius of a point
        /// </summary>
        public double Radius { get; internal set; }

        /// <summary>
        /// Gets the angle of a point
        /// </summary>
        public double Angle { get; internal set; }
    }

}