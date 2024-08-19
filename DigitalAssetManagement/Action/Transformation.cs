using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAssetManagement.Action
{
    public class Transformation
    {
        public Transformation() { }

        public Dictionary<string, string> m_transformParams = new Dictionary<string, string>();
        public Transformation Width(object value)
        {
            return Add("w", value.ToString());
        }
        public Transformation Height(object value)
        {
            return Add("h", value.ToString());
        }

        public Transformation AspectRatio(double value)
        {
            return AspectRatio(value.ToString(CultureInfo.InvariantCulture));
        }

        public Transformation AspectRatio(int nom, int denom)
        {
            return AspectRatio(string.Format(CultureInfo.InvariantCulture, "{0}:{1}", nom, denom));
        }

        public Transformation AspectRatio(string value)
        {
            return Add("r", value);
        }

        public Transformation Quality(int value)
        {
            return Add("q", value.ToString());
        }

        public Transformation Add(string key, string value)
        {
            if (m_transformParams.ContainsKey(key))
            {
                m_transformParams[key] = value;
            }
            else
            {
                m_transformParams.Add(key, value);
            }

            return this;
        }
    }
}
