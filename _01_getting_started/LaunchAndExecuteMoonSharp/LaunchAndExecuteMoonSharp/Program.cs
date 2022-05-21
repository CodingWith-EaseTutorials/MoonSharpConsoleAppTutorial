using System;
using MoonSharp.Interpreter;

namespace LaunchAndExecuteMoonSharp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(rtnHelloWorld());
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
