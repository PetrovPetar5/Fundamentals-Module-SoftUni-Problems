namespace SnowBalls
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main(string[] args)
        {
            BigInteger snowBallsNum = BigInteger.Parse(Console.ReadLine());
            BigInteger bestSnowBallSnow = 0;
            BigInteger bestSnowBallTime = 0;
            BigInteger bestSnowBallQuality = 0;
            BigInteger snowBallValue = 0;

            for (BigInteger i = 1; i <= snowBallsNum; i++)
            {
                BigInteger currSnowBallSnow = BigInteger.Parse(Console.ReadLine());
                BigInteger currSnowBallTime = BigInteger.Parse(Console.ReadLine());
                BigInteger currSnowBallQuality = BigInteger.Parse(Console.ReadLine());
                BigInteger currValue = BigInteger.Pow(currSnowBallSnow / currSnowBallTime, (int)currSnowBallQuality);
                if (currValue > snowBallValue)
                {
                    snowBallValue = currValue;
                    bestSnowBallSnow = currSnowBallSnow;
                    bestSnowBallTime = currSnowBallTime;
                    bestSnowBallQuality = currSnowBallQuality;
                }
            }

            Console.WriteLine($"{bestSnowBallSnow} : {bestSnowBallTime} = {snowBallValue} ({bestSnowBallQuality})");
        }
    }
}
