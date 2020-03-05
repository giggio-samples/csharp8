namespace CSharp8
{
    public class Interpolation
    {
        void M()
        {
            var i = 1;
            var s1 = $@"\a string {i}";
            var s2 = @$"\another string {i}";
        }
    }
}
