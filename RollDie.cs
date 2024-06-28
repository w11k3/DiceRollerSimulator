public class RollDie
{
    public static void Main(string[] args)
    {
        Random randomNumbers = new Random(); // random-number generator

        int frequency1 = 0; // count of 1s rolled
        int frequency2 = 0; // count of 2s rolled
        int frequency3 = 0; // count of 3s rolled
        int frequency4 = 0; // count of 4s rolled
        int frequency5 = 0; // count of 5s rolled
        int frequency6 = 0; // count of 6s rolled

        int face; // stores most recently rolled value

        // summarize results of 6,000,000 rolls of a die
        for (int roll = 1; roll <= 6000000; ++roll)
        {
            face = randomNumbers.Next(1, 7); // number from 1 to 6

            // determine roll value 1-6 and increment appropriate counter
            switch (face)
            {
                case 1:
                    ++frequency1; // increment the 1s counter
                    break;
                case 2:
                    ++frequency2; // increment the 2s counter
                    break;
                case 3:
                    ++frequency3; // increment the 3s counter
                    break;
                case 4:
                    ++frequency4; // increment the 4s counter
                    break;
                case 5:
                    ++frequency5; // increment the 5s counter
                    break;
                case 6:
                    ++frequency6; // increment the 6s counter
                    break;
            } // end switch
        } // end for

        Console.WriteLine("Face\tFrequency"); // output headers
        Console.WriteLine($"1\t{frequency1}\n2\t{frequency2}\n3\t{frequency3}\n4\t{frequency4}\n5\t{frequency5}\n6\t{frequency6}");
    } // end Main
} // end class RollDie