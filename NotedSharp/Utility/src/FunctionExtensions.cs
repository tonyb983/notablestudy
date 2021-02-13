using System;
using JetBrains.Annotations;

namespace Utility
{
    public static class Lambda
    {
        // ReSharper disable once PossibleNullReferenceException
        public static void Do([CanBeNull]
                              Action block) => block.Invoke();

        public static void DoSafe([CanBeNull]
                                  Action block) => block?.Invoke();

        public static void DoAndThrow<T>(Action block,
                                         Func<T> ex) where T : Exception
        {
            block?.Invoke();

            if (ex != null)
            {
                throw ex.Invoke()
                   ?? new Exception($"Exception occurred trying to create exception of type {typeof(T).Name}");
            }
        }

        public static TOut Let<TIn, TOut>(this TIn input,
                                          Func<TIn, TOut> block) => block.Invoke(input);
    }
}
