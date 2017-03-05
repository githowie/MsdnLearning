using System;

namespace StaticMember
{
    /* Have a class which you may use without instantiating it, or at least a class where you can use members of it without creating an object for it. 
     * For instance, you may have a class with a variable that always remains the same, no matter where and how it's used. This is called a static member, static because it remains the same.
    
     * A class can be static, and it can have static members, both functions and fields. 
     * A static class can't be instantiated, so in other words, it will work more as a grouping of related members than an actual class. 
     * You may choose to create a non-static class instead, but let it have certain static members. 
     * A non-static class can still be instantiated and used like a regular class, but you can't use a static member on an object of the class. 
     * A static class may only contain static members.
    */

    class Program
    {
        public static class Rectangle
        {
            public static int CalculateArea(int width, int height)
            {
                return width * height;
            }
        }
        
        static void Main(string[] args)
        {

            // To use this method, we call it directly on the class, like this: 
            Console.WriteLine("The area is: " + Rectangle.CalculateArea(5, 4));
            Console.ReadKey();
        }
    }
}
