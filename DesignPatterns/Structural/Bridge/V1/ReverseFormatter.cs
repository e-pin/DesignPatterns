using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge.V1
{
    public class ReverseFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return new string($"{key}: {value}".Reverse().ToArray());
        }
    }
}
