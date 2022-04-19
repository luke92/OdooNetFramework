using System;
using System.ComponentModel;
using System.Diagnostics;

namespace OdooIntegration.ConsoleApp.Helpers
{
    public static class ConverterHelper
    {
        public static T Convert<T>(this string input)
        {
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    // Cast ConvertFromString(string text) : object to (T)
                    return (T)converter.ConvertFromString(input);
                }
                return default(T);
            }
            catch (NotSupportedException)
            {
                return default(T);
            }
        }

        public static T? TryParse<T>(string value, TryParseHandler<T> handler) where T : struct
        {
            if (String.IsNullOrEmpty(value))
                return null;
            T result;
            if (handler(value, out result))
                return result;
            Trace.TraceWarning("Invalid value '{0}'", value);
            return null;
        }

        public delegate bool TryParseHandler<T>(string value, out T result);
    }

    /// <summary>
    /// Provides some extra parsing functionality for value types.
    /// </summary>
    /// <typeparam name="T">The value type T to operate on.</typeparam>
    public static class TryParseHelper<T> where T : struct
    {
        private delegate bool TryParseFunc(string str, out T result);

        private static TryParseFunc tryParseFuncCached;

        private static TryParseFunc tryParseCached
        {
            get
            {
                return tryParseFuncCached ?? (tryParseFuncCached = Delegate.CreateDelegate(typeof(TryParseFunc), typeof(T), "TryParse") as TryParseFunc);
            }
        }

        /// <summary>
        /// Tries to convert the specified string representation of a logical value to
        /// its type T equivalent. A return value indicates whether the conversion
        /// succeeded or failed.
        /// </summary>
        /// <param name="value">A string containing the value to try and convert.</param>
        /// <param name="result">If the conversion was successful, the converted value of type T.</param>
        /// <returns>If value was converted successfully, true; otherwise false.</returns>
        public static bool TryParse(string value, out T result)
        {
            return tryParseCached(value, out result);
        }

        /// <summary>
        /// Tries to convert the specified string representation of a logical value to
        /// its type T equivalent. A return value indicates whether the conversion
        /// succeeded or failed.
        /// </summary>
        /// <param name="value">A string containing the value to try and convert.</param>
        /// <returns>If value was converted successfully, true; otherwise false.</returns>
        public static bool TryParse(string value)
        {
            T throwaway;
            return TryParse(value, out throwaway);
        }
    }
}
