using System.Text.RegularExpressions;

namespace Greeter
{
    public class GreetingMaker
    {
        private readonly List<String> _names = new();

        
        public string Greet(string? name)
        {
            if (name == "") { name = "Captain"; }
            if (name == name.ToUpper()) { return "HELLO, " + name + "!"; }

            return "Hello, " + name + "!";
        }

        public string Greet(string? name1, string? name2) {
            if (name1=="") { name1 = "Captain"; }
            if (name2=="") { name2 = "Captain"; }
            if (name1 == name1.ToUpper()) { return "Hello, " + name2 
                    + " AND " + name1 +"!"; }
            if (name2 == name2.ToUpper()) { return "Hello, " + name1
                    + " AND " + name2 + "!"; }

            return "Hello, " + name1 + " and " + name2 + "!";
        }
    }
}