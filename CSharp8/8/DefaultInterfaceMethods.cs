using static System.Console;

namespace CSharp8
{
    public class DefaultInterfaceMethods
    {
        interface I
        {
            void M() { WriteLine("I.M"); }
        }

        class C : I { } // OK

        void M()
        {
            I i = new C();
            i.M(); // prints "I.M"
        }
    }
}
