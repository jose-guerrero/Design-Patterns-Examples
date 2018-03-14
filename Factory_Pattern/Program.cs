using System;

namespace Factory_Pattern
{
 
    class Program
    {
        abstract class Position /// An abstract class is a special type of class that cannot be instantiated.
        {
            public abstract string Title {get;}
        }

        class Manager : Position
        {
            public override string Title
            {
                get
                {
                    return "Manager";
                }
            }
        }

        class Clerk : Position
        {
            public override string Title
            {
                get
                {
                    return "Clerk";
                }
            }
        }

        class Programmer : Position
        {
            public override string Title
            {
                get
                {
                    return "Programmer";
                }
            }
        }

        static class Factory
        {
            public static Position Get(int id)
            {
                switch(id)
                {
                    case 0:
                        return new Manager();
                    case 1:
                    case 2:
                        return new Clerk();
                    case 3:
                    default:
                        return new Programmer();
                }
            }
        }

        
        static void Main(string[] args)
        {
            for (int i = 0; i <= 3; i++)
            {
                var position = Factory.Get(i);
                Console.WriteLine("Where id = {0}, position = {1} ", i, position.Title);
            }
        }
    }
}
