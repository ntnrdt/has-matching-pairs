using System;

namespace HasMatchingPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = "Hello World!";
            var result = HasMatchingPairs(content);

            Console.WriteLine($"Has matching pairs: {result}");
        }

        static bool HasMatchingPairs(string content)
        {   
            var allPossibleChars = new int[256];

            for(var i = 0; i < content.Length; i++)
            {
                var charAsInt = (int)content[i];
                allPossibleChars[charAsInt]++;

                if (allPossibleChars[charAsInt] >= 2){
                    return true;
                }
            }

            return false;
        }
    }
}