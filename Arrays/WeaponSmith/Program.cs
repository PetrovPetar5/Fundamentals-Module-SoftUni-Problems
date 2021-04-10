namespace WeaponSmith
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string[] weaponWords = Console.ReadLine().Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] curInput = command.Split().ToArray();
                long movingIndex = 0;
                string temp = string.Empty;
                string curToPrint = String.Empty;

                if (curInput[1] == "Left")
                {
                    movingIndex = int.Parse(curInput[2]);
                    if (movingIndex > 0 && movingIndex <= weaponWords.Length - 1)
                    {
                        temp = weaponWords[movingIndex - 1];
                        weaponWords[movingIndex - 1] = weaponWords[movingIndex];
                        weaponWords[movingIndex] = temp;
                    }
                }
                else if (curInput[1] == "Right")
                {
                    movingIndex = int.Parse(curInput[2]);
                    if (movingIndex >= 0 && movingIndex < weaponWords.Length - 1)
                    {
                        temp = weaponWords[movingIndex + 1];
                        weaponWords[movingIndex + 1] = weaponWords[movingIndex];
                        weaponWords[movingIndex] = temp;
                    }
                }
                else if (curInput[1] == "Even")
                {
                    for (int i = 0; i <= weaponWords.Length - 1; i += 2)
                    {
                        curToPrint += weaponWords[i] + " ";
                    }

                    Console.WriteLine(curToPrint);
                }
                else if (curInput[1] == "Odd")
                {
                    for (int i = 1; i <= weaponWords.Length - 1; i += 2)
                    {
                        curToPrint += weaponWords[i] + " ";
                    }

                    Console.WriteLine(curToPrint);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You crafted {String.Join("", weaponWords)}!");
        }
    }
}
