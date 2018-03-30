using System;

namespace Inheritance10
{
    class Program
    {
        static void Main(string[] args)
        {
            var parent = new Parent();
            parent.One();
            parent.Two();

            var child = new Child();
            child.One();
            child.Two();

            // This is the key to this example ... 
            // C# 'as' operator:
            // The 'as' operator is like a cast operation. 
            // However, if the conversion isn't possible, 
            // 'as' returns null instead of raising an exception.
            Parent manChild = child as Parent;

            Console.WriteLine("-------------");

            manChild.One();

            // Here we're hiding the child's Two()
            // method ... under the right circumstance
            // ignore the child's version of this method
            // and revert back to the parent.
            manChild.Two();
            // Admittedly, this is a rare situation.
            // https://blogs.msdn.microsoft.com/ericlippert/2008/05/21/method-hiding-apologia/


            Console.ReadLine();
        }
    }

    public class Parent
    {
        public virtual void One() { Console.WriteLine("Parent.One"); }
        public void Two() { Console.WriteLine("Parent.Two"); }
    }

    public class Child : Parent
    {
        public override void One() { Console.WriteLine("Child.One"); }

        // Method Hiding means "hide this version of the method 
        // and allow the parent's version of the method to shine
        // through."

        // The 'new' keyword is really just for readability
        // It doesn't do anything except express your intent.
        public new void Two() { Console.WriteLine("Child.Two"); }
    }
}
