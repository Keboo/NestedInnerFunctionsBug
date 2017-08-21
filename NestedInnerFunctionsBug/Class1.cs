using System;

namespace NestedInnerFunctionsBug
{
    public class Class1
    {
        private void Test()
        {
            bool outside = true;

            void Inner() //This can also be a lambda (ie. Action action = () => { ... };)
            {
                void Bar()
                {
                }

                void Foo()
                {
                    Bar();

                    bool captured = outside;
                }
            }
        }
    }
}
