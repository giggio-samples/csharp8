using static System.Console;
namespace CSharp8
{
    public class NullableReferenceTypes
    {
        void N(string? aNullableString, bool condition)
        {
            WriteLine(aNullableString.Length); // warning
            if (aNullableString != null)
                WriteLine(aNullableString); // no warning
            if (!string.IsNullOrWhiteSpace(aNullableString))
                WriteLine(aNullableString!.Length); // I know better
            var anotherNullableString = condition ? "Hello" : aNullableString;
            WriteLine(anotherNullableString.Length); // warning
            var yetAnotherNullableString = condition ? "Hello" : null;
            WriteLine(yetAnotherNullableString.Length); // warning

            string nonNullableString = null; //warning
            WriteLine(nonNullableString); // no warning
        }
    }
}
