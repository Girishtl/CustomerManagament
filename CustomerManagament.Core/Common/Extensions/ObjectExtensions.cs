using System.Runtime.CompilerServices;
#nullable disable
namespace System
{
    public static class ObjectExtensions
    {
        public static T ThrowIfNull<T>(this T value, [CallerArgumentExpression("value")] string valueName = null) 
            where T:class
        {
            if (value == null) throw new ArgumentNullException($"{valueName} is null");

            return value;
        }
    }
}
