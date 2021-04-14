namespace RepeatingString
{
    using System;
    class Program
    {
        static string PrintsTheFinalText(string textToRepeat, int textRetypes)
        {
            string finalTextToPrint = string.Empty;
            for (int i = 0; i < textRetypes; i++)
            {
                finalTextToPrint += textToRepeat;
            }

            return finalTextToPrint;
        }
        static void Main(string[] args)
        {
            string textToRepeat = Console.ReadLine();
            int textRetypes = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintsTheFinalText(textToRepeat, textRetypes));
        }
    }
}
