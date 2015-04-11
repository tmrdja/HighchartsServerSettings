using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighchartsSettings
{
    public class Chart
    {
        public List<Serie> series = new List<Serie>();
        public List<YAxis> yAxis = new List<YAxis>();
        public XAxis xAxis = new XAxis();
        public Legend legend = new Legend();
        public YAxis.Title title;
    }

    public class YAxis
    {
        public struct Title
        {
            public String text;
        }

        public double? max;
        public double? min;
        public Title title = new Title();
    }

    public class XAxis
    {
        public static class Type
        {
            public static readonly string linear = "linear";
            public static readonly string logarithmic = "logarithmic";
            public static readonly string datetime = "datetime";
            public static readonly string category = "category";
        };

        public string min;
        public string max;
        public String type = Type.linear;
        public double? tickInterval;
        public double? minTickInterval;
        public struct Title
        {
            public String text;
        }
        public Title title = new Title();
        public struct Labels
        {
            public int rotation;
        }
        public Labels labels;
        public List<String> categories;
        public List<int> tickPositions;
    }

    public class Serie
    {
        public string name;
        public string type;
        public Object[][] data;
        public String color;
        public Marker marker = new Marker();
        public Int32? lineWidth;
        public Int32? pointWidth;
        public Int32 yAxis = 0;
    }

    public struct Marker
    {
        public Boolean enabled;
        public Int32 radius;
        public String symbol;
    }

    public struct ChartOptions
    {
        public String type;
    }

    public class Legend
    {
        public Boolean enabled = true;
    }
}
