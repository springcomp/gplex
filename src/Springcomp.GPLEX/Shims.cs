using System;
using System.Reflection;

namespace QUT.Gplex.Automaton {
    internal static class Shims {
        public static string MachineName
            => Environment.GetEnvironmentVariable("CUMPUTERNAME") ?? Environment.GetEnvironmentVariable("HOSTNAME");

        public static Assembly GetEntryAssembly()
            => typeof(Parser.ResourceUtils).GetTypeInfo().Assembly;
    }
}
