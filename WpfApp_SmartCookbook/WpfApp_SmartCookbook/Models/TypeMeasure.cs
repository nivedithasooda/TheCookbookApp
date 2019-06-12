using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_SmartCookbook.models
{
    public class TypeMeasure
    {
        public string measure { get; set; }
        public string type { get; set; }
    }

    public static class Measurement
    {
        public const string gram = "gram(s)";
        public const string kg = "Kilogram(s)";
        public const string ml = "ml(s)";
        public const string liter = "Liter(s)";
        public const string teaspoon = "teaspoon(s)";
        public const string tablespoon = "tablespoon(s)";
    }

    public class TypeMeasurement
    {
        public List<string> measures { get; set; }
        public string type { get; set; }

        public TypeMeasurement(string _type)
        {
            measures = new List<string>();
            switch (_type.ToLower())
            {
                case "solid":
                    measures.Add(Measurement.gram);
                    measures.Add(Measurement.kg);
                    break;
                case "liquid":
                    measures.Add(Measurement.ml);
                    measures.Add(Measurement.liter);
                    break;
                case "cream":
                    measures.Add(Measurement.ml);
                    measures.Add(Measurement.liter);
                    measures.Add(Measurement.teaspoon);
                    measures.Add(Measurement.tablespoon);
                    break;
                case "spice":
                    measures.Add(Measurement.teaspoon);
                    measures.Add(Measurement.tablespoon);
                    measures.Add(Measurement.gram);
                    measures.Add(Measurement.kg);
                    break;
                default:
                    break;
            }
        }
    }
 
}
