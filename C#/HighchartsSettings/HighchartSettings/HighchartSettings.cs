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
            public static readonly string LINEAR = "linear";
            public static readonly string LOGARITHMIC = "logarithmic";
            public static readonly string DATETIME = "datetime";
            public static readonly string CATEGORY = "category";
        };

        public string min;
        public string max;
        public String type = Type.LINEAR;
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

        public static class Type
        {
            public static readonly string LINE = "line";
            public static readonly string SPLINE = "spline";
            public static readonly string AREA = "area";
            public static readonly string AREASPLINE = "areaspline";
            public static readonly string COLUMN = "column";
            public static readonly string BAR = "bar";
            public static readonly string PIE = "pie";
            public static readonly string SCATTER = "scatter";
            public static readonly string GAUGE = "gauge";
            public static readonly string AREARANGE = "arearange";
            public static readonly string AREASPLINERANGE = "areasplinerange";
            public static readonly string COLUMNRANGE = "columnrange";
        };
    }

    public struct Marker
    {
        public Boolean enabled;
        public Int32 radius;
        public String symbol;
    }

    /*public struct ChartOptions
    {
        public String type;
    }*/

    public class Legend
    {
        public Boolean enabled = true;
    }
}
