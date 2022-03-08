using System;

namespace Dependency_Injection
{
    internal class Program
    {
        #region Constructor Injection

        interface ConstructorInjectionInf
        {
            void sample();
        }

        class ConstructorInjectionClass1 : ConstructorInjectionInf
        {
            public void sample()
            {
                Console.WriteLine("Overrriden function in constructorInjectionClass1 : Constructor Injection");
            }
        }
        class ConstructorInjectionClass2 : ConstructorInjectionInf
        {
            public void sample()
            {
                Console.WriteLine("Overrriden function in constructorInjectionClass2 : Constructor Injection");
            }
        }
        class ConstructorInjection
        {
            ConstructorInjectionInf i1;

            public ConstructorInjection(ConstructorInjectionInf i1)
            {
                this.i1 = i1;
                this.i1.sample();
            }

        }

        #endregion

        #region Property Injection

        interface PropertyInjectionInf
        {
            void sample(string s);
        }

        class PropertyInjectionClass1 : PropertyInjectionInf
        {
            public void sample(string s)
            {
                Console.WriteLine("Overrriden function in PropertyInjectionClass1 : Property Injection");
            }
        }
        class PropertyInjectionClass2 : PropertyInjectionInf
        {
            public void sample(string s)
            {
                Console.WriteLine("Overrriden function in PropertyInjectionClass2 : Property Injection");
            }
        }
        class PropertyInjection
        {
            PropertyInjectionInf i1;

            public PropertyInjection(PropertyInjectionInf i1, string s)
            {
                this.i1 = i1;
                this.i1.sample(s);
            }

        }

        #endregion

        #region Method Injection

        interface MethodInjectionInf
        {
            void sample();
        }

        class MethodInjectionClass1 : MethodInjectionInf
        {
            public void sample()
            {
                Console.WriteLine("Overrriden function in MethodInjectionClass1 : Method Injection");
            }
        }
        class MethodInjectionClass2 : MethodInjectionInf
        {
            public void sample()
            {
                Console.WriteLine("Overrriden function in MethodInjectionClass2 : Method Injection");
            }
        }
        class MethodInjection
        {
            MethodInjectionInf i1;
            public void MethodInjectionMethod(MethodInjectionInf i1)
            {
                this.i1 = i1;
                this.i1.sample();
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region Constructor Injection

            ConstructorInjection ci = null;
            ci = new ConstructorInjection(new ConstructorInjectionClass1());
            ci = new ConstructorInjection(new ConstructorInjectionClass2());

            #endregion

            #region Property Injection

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            PropertyInjection pi = null;
            pi = new PropertyInjection(new PropertyInjectionClass1(), "Hello");
            pi = new PropertyInjection(new PropertyInjectionClass2(), "Hello");

            #endregion

            #region Method Injection

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine();
            MethodInjection mi = null;
            mi = new MethodInjection();
            mi.MethodInjectionMethod(new MethodInjectionClass1());
            mi.MethodInjectionMethod(new MethodInjectionClass2());

            #endregion

            Console.ReadKey();
        }
    }
}