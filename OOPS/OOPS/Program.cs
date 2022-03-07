using System;

namespace OOPS
{
    internal class Program
    {

        class ClassObjectDemo {
            public int a;
        }

        struct StructReferenceDemo { 
            public int a;
        }

        // Encapsulation
        class Encapsulation { 
            private int pri;  // Access of private member is only inside the class
            public int pub;  // Access of public member is anywhere
            protected int pro;  // Access of protected member inside the class and it's child class
            internal int i;  // Internal variable accessed within the same class as well as same namespace or assembly child class.

            // Constructor
            public Encapsulation() {
                pri = 10;
                pub = 20;
                pro = 30;
                i = 40;
            }

            public void display() {
                Console.WriteLine("Private Variable:"+pri);
                Console.WriteLine("Protected Variable:" + pro);
            }
        }

        // Inheritance
        class EncapsulationWithInheritance:Encapsulation {
            // Private member is not inherited
            // Public and Protected member is inherited

            public void show() {
                Console.WriteLine("Private Variable:" + pub);
                Console.WriteLine("Protected Variable:" + pro);
            }
        }

        // Multi-Level-Inheritance
        class A {
            protected void fun1() {
                Console.WriteLine("This is class A");
            }
        }
        class B:A {
            public void fun2() {
                Console.WriteLine("This is class B");
            }
        }

        class C:B {
            public void fun3() {
                fun1();
                Console.WriteLine("This is class C");
            }
        }

        // Polymorphism
        // Function Overloading - Name of function is same but parameters are different
        class funOverloading {
            public void sample() { 
                Console.WriteLine("Function without argument");
            }
            public void sample(int a) {
                Console.WriteLine("Function with one integer argument");
            }
            public void sample(int a, int b) {
                Console.WriteLine("Function with two integer argument");
            }
            public void sample(string a)
            {
                Console.WriteLine("Function with one string argument");
            }
        }

        // Function Overriding - Name of function and parameters both are same
        class Parent_Class {
            public void sample() { 
                Console.WriteLine("Function of Parent Class");
            }
        }
        class funOverriding:Parent_Class {
            public void sample() { 
                Console.WriteLine("Function of Child Class");
            }
        }

        // Difference between Abstraction and Interface
        // Abstract class doesn't support Multiple Inheritance but Interface supports Multiple Inheritance

        // Abstraction - Abstract class have abstract and non-abstract methods
        abstract class absParent {
            public void normalMethod1() {
                Console.WriteLine("This is Normal Method 1 of Parent Class");
            }
            public void normalMethod2() {
                Console.WriteLine("This Normal Method 2 of Parent Class");
            }
            public abstract void abstractMethod1();
            public abstract void abstractMethod2();
        }
        class childClassAbs:absParent {
            public override void abstractMethod1() {
                Console.WriteLine("Abstract Method 1 Definition of Abstract Class in Child Class");
            }

            public override void abstractMethod2() {
                Console.WriteLine("Abstract Method 1 Definition of Abstract Class in Child Class");
            }
            public void normalMethodChildClassAbs() {
                Console.WriteLine("Normal Method of Child Class");
            }
        }

        // Interface
        interface interfaceDemo1 { 
            public void IAbsMethod1();
        }
        interface interfaceDemo2
        {
            public void IAbsMethod2();
        }
        class interfaceClass : interfaceDemo1, interfaceDemo2 {
            void interfaceDemo1.IAbsMethod1() { 
                Console.WriteLine("Interface interfaceDemo1 method override");
            }
            void interfaceDemo2.IAbsMethod2() {
                Console.WriteLine("Interface interfaceDemo2 method override");
            }
            public void normalFunInterfaceClass() {
                Console.WriteLine("Normal Function");
            }
        }

        static void Main(string[] args) {
            // *************************** CLASS ***********************************
            //*** NEW OBJECTS OF CLASS ClassObjectDemo.***
            // First new object of class ClassObjectDemo - As constructor is called.
            ClassObjectDemo classObjectDemo1 = new ClassObjectDemo();
            // Second new object of class ClassObjectDemo - As constructor is called.
            ClassObjectDemo classObjectDemo2 = new ClassObjectDemo();
            // Third new object of class ClassObjectDemo - As constructor is called.
            ClassObjectDemo classObjectDemo3 = classObjectDemo1;
            // Fourth new object of class ClassObjectDemo - As constructor is called.
            ClassObjectDemo classObjectDemo4 = classObjectDemo3;
            // Fifth new object of class ClassObjectDemo - As constructor is called.
            ClassObjectDemo classObjectDemo5 = classObjectDemo2;
            // Sixth new object of class ClassObjectDemo - As constructor is called.
            ClassObjectDemo classObjectDemo6 = new ClassObjectDemo();
            // Seventh new object of class ClassObjectDemo - As constructor is called.
            ClassObjectDemo classObjectDemo7 = classObjectDemo6;

            // Set Values
            classObjectDemo1.a = 10;
            classObjectDemo2.a = 20;
            classObjectDemo3.a = 30;
            classObjectDemo4.a = 40;
            classObjectDemo5.a = 50;
            classObjectDemo6.a = 60;
            classObjectDemo7.a = 70;

            // Print all values on console
            Console.WriteLine("classObjectDemo1.a:" + classObjectDemo1.a);
            Console.WriteLine("classObjectDemo2.a:" + classObjectDemo2.a);
            Console.WriteLine("classObjectDemo3.a:" + classObjectDemo3.a);
            Console.WriteLine("classObjectDemo4.a:" + classObjectDemo4.a);
            Console.WriteLine("classObjectDemo5.a:" + classObjectDemo5.a);
            Console.WriteLine("classObjectDemo6.a:" + classObjectDemo6.a);
            Console.WriteLine("classObjectDemo7.a:" + classObjectDemo7.a);

            // *************************** STRUCTURE ***********************************
            //*** NEW OBJECTS OF CLASS StructReferenceDemo.***
            // First new object of class StructReferenceDemo - As constructor is called.
            StructReferenceDemo structReferenceDemo1 = new StructReferenceDemo();
            // Second new object of class StructReferenceDemo - As constructor is called.
            StructReferenceDemo structReferenceDemo2 = new StructReferenceDemo();
            // Third new object of class StructReferenceDemo - As constructor is called.
            StructReferenceDemo structReferenceDemo3 = structReferenceDemo1;
            // Fourth new object of class StructReferenceDemo - As constructor is called.
            StructReferenceDemo structReferenceDemo4 = structReferenceDemo3;
            // Fifth new object of class StructReferenceDemo - As constructor is called.
            StructReferenceDemo structReferenceDemo5 = structReferenceDemo2;
            // Sixth new object of class StructReferenceDemo - As constructor is called.
            StructReferenceDemo structReferenceDemo6 = new StructReferenceDemo();
            // Seventh new object of class StructReferenceDemo - As constructor is called.
            StructReferenceDemo structReferenceDemo7 = structReferenceDemo6;

            // Set Values
            structReferenceDemo1.a = 10;
            structReferenceDemo2.a = 20;
            structReferenceDemo3.a = 30;
            structReferenceDemo4.a = 40;
            structReferenceDemo5.a = 50;
            structReferenceDemo6.a = 60;
            structReferenceDemo7.a = 70;

            // Print all values on console
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("structReferenceDemo1.a:" + structReferenceDemo1.a);
            Console.WriteLine("structReferenceDemo2.a:" + structReferenceDemo2.a);
            Console.WriteLine("structReferenceDemo3.a:" + structReferenceDemo3.a);
            Console.WriteLine("structReferenceDemo4.a:" + structReferenceDemo4.a);
            Console.WriteLine("structReferenceDemo5.a:" + structReferenceDemo5.a);
            Console.WriteLine("structReferenceDemo6.a:" + structReferenceDemo6.a);
            Console.WriteLine("structReferenceDemo7.a:" + structReferenceDemo7.a);

            // Encapsulation
            Encapsulation encap = new Encapsulation();

            // Print all values on console
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Public Variable:"+encap.pub);
            encap.display();

            // Encapsulation with Inheritance
            EncapsulationWithInheritance encapInheri = new EncapsulationWithInheritance();

            // Print all values on console
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            encapInheri.show();

            // Multi-Level-Inheritance
            C o1 = new C();

            // Print all values on console
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            o1.fun2();
            o1.fun3();

            // Polymorphism
            // Function Overloading - Name of function is same but parameters are different
            funOverloading fo = new funOverloading();

            // Print all values on console
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            fo.sample();
            fo.sample(10);
            fo.sample(10,20);
            fo.sample("Hello");

            // Function Overriding - Name of function and parameters both are same
            funOverriding fov = new funOverriding();

            // Print all values on console
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            fov.sample();

            // Abstraction
            childClassAbs cca = new childClassAbs();

            // Print all values on console
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            cca.normalMethod1();
            cca.normalMethod2();
            cca.abstractMethod1();
            cca.abstractMethod2();
            cca.normalMethodChildClassAbs();

            // Interface
            interfaceDemo1 i1 = new interfaceClass();
            interfaceDemo2 i2 = new interfaceClass();
            interfaceClass ic = new interfaceClass();

            // Print all values on console
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            i1.IAbsMethod1();
            i2.IAbsMethod2();
            ic.normalFunInterfaceClass();
        }
    }
}