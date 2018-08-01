using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LeetCodes.Test
{
    public static class SolutionHelper
    {
        public static IEnumerable<MethodInfo> GetSolutionMethods(Type type)
        {
            foreach (var info in type.GetCustomAttributes(typeof(SolutionAttribute))){
            }
            return type.GetMethods()
                .Where(m => m.GetCustomAttribute<SolutionAttribute>() != null && m.GetCustomAttribute<SolutionAttribute>().IsSolution)
                .ToArray();
        }
    }
}