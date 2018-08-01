using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LeetCodes.Test
{
    public class TestTemplate : IDisposable
    {
        protected readonly IEnumerable<MethodInfo> Solutions;

        private readonly object _instance;

        protected TestTemplate()
        {
            var types = Assembly.Load(new AssemblyName("LeetCodes")).GetTypes();
            var thisTypeName = GetType().Name;
            Type solutionType = null;
            
            foreach (var type in types)
            {
                if (thisTypeName.Contains(type.Name))
                {
                    solutionType = type;
                }
            }

            _instance = Activator.CreateInstance(solutionType);

            Solutions = SolutionHelper.GetSolutionMethods(solutionType);

            if (!Solutions.Any())
            {
                throw new Exception("No solution found.");
            }
        }

        protected object Invoke(MethodInfo mi, object[] parameters)
        {
            return mi.Invoke(_instance, parameters);
        }

        public void Dispose()
        {
        }
    }
}