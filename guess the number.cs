using System;

public class MantejeNumber
{
    public static void Main(string[] args)
    {
        int sn;         //secret number
        int mantevw;
        int counter = 10;
        bool flag = true;

        Console.Write("Player 1 give me your secret number: \n"); // o paikyhs 1 tha dwsw to secret number
        Console.Write("\n");
        sn = int.Parse(Console.ReadLine());

        Console.Write("Guess a number between 1 - 100\n");
        do
        {
            Console.Write("Player 2 give me number: \n");   //o paikths 2 tha balei ton arithmo pou pisteyei pws einai 
            mantevw = int.Parse(Console.ReadLine());
            
            // έλεγχος εγκυρότητας
            while(mantevw > 100 || mantevw < 1)
            {
                Console.Write("Player 2 give me number between 1 - 100: \n");   //o paikths 2 tha balei ton arithmo pou pisteyei pws einai 
                mantevw = int.Parse(Console.ReadLine());
            }

            // ελέγχω αν κέρδισε
            if (mantevw == sn)
            {
                Console.WriteLine("Win!\n");
                flag = false;
            }
            else if (mantevw > sn)
            {
                Console.WriteLine("Bale mikrotero\n");
            }
            else if (mantevw < sn)
            {
                Console.WriteLine("Bale megalytero\n");
            }

            // κατεβάζω τις προσπάθειες
            counter--;
            
        } while (counter > 0 && flag == true);
        
        Console.WriteLine("Game is over!\n");
            
    }
}