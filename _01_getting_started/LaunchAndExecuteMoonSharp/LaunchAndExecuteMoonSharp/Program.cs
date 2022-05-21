using System;
using MoonSharp.Interpreter;

namespace LaunchAndExecuteMoonSharp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(rtnHelloWorld());
            Console.WriteLine("Global sum: " + globalSum(16, 31));
        }

        static double globalSum(int a, int b) {
            string scriptCode = @"
                function sum(a, b)
                   return a + b
                end

                return sum(globalA, globalB)
            ";
            Script script = new Script();
            script.Globals["globalA"] = a;
            script.Globals["globalB"] = b;

            DynValue res = script.DoString(scriptCode);
            return res.Number;
        }

        static String rtnHelloWorld() {
            String script = @"
                return 'Hello world!'    
            ";
            DynValue res = Script.RunString(script);
            return res.String;
        }
    }
}
