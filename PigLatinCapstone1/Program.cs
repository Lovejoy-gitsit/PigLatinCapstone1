using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinCapstone1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                //asking for user input
                Console.WriteLine("Enter a word: ");
                //getting user input
                string input = Console.ReadLine();
                //telling the program what characters I want it to check for
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                //index is an int because want to find index value of the input/basically putting the split part into its own variable 
                int index = input.ToLower().IndexOfAny(vowels);
                //putting the vowel portion of the word in its own variable/so the vowel portion can be placed in the word later by declaring the variable
                string restOfWord = input.Substring(index);
                //putting the consonant portion of the word in its own variable/so it can be declared later
                string firstLetters = input.Substring(0, index);

                //Console.WriteLine(restOfWord);
                //Console.WriteLine(firstLetters);
                //Console.WriteLine(index);

                //checking if the input does start with one of the vowels in char
                if (index == 0)
                {
                    //a.k.a String.Append()
                    input += "way";
                    //printing the input with way on end
                    Console.WriteLine(input);
                }
                //checking if the input does not start with one of the vowels in char
                else if (index != 0)
                {
                    //adds "ay" to the end of input

                    Console.WriteLine($"{restOfWord}{firstLetters}{"ay"}");
                    //printing the input with "ay" on end

                }

                string playAgain;
                Console.WriteLine("Do you want to play again: y/n");
                playAgain = Console.ReadLine().ToLower();

                if (playAgain != "y")
                {
                    Console.WriteLine("This program took me ALL DAY to do and you want to exit?");
                    break;
                }
                else
                {
                    continue;
                }

            }
             








            
        }

            
            

        

            

            
        
    }
}
