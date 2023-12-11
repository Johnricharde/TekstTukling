namespace TekstTukling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] Rotate Text");
            Console.WriteLine("[2] Change Text\n");
            string menuChoice = Console.ReadLine();
            string userInput;

            switch (menuChoice)
            {
                case "1": // Reverses the entire string
                    Console.WriteLine("Enter the text you want to rotate:");

                    userInput = Console.ReadLine();
                    char[] chars = userInput.ToCharArray();
                    Array.Reverse(chars);
                    Console.WriteLine(new string(chars));

                    Console.ReadKey();
                    break;
                case "2": // Replaces every 'e' with an 'a'
                    Console.WriteLine("Enter the text you want to change:");

                    userInput = Console.ReadLine().ToLower();
                    Console.WriteLine(userInput.Replace('e', 'a'));

                    Console.ReadKey();
                    break;
            }
        }
    }
}
