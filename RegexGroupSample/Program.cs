using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexGroupSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = " abcd defg 123456";
            string pattern = "^\\s(?<fs>[a-zA-Z]*)\\s(?<ss>[a-zA-Z]*)\\s(?<n>[0-9]{6})$";
            Regex r = new Regex(pattern);

            Match m = r.Match(test);

            Console.WriteLine(m.Groups["fs"] + ":" + m.Groups["ss"] + ":" + m.Groups["n"]);
                
            
        }
    }
}
