using System;

namespace StringResourceTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LocalizableResources.StringWithoutArguments);
            Console.WriteLine(LocalizableResources.StringWithTypeArguments(1, "mystring", DateTime.UtcNow));
            Console.WriteLine(LocalizableResources.StringWithUntypedArgument("default type is string"));
        }
    }
}
