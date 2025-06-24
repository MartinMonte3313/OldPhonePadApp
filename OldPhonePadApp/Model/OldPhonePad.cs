using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldPhonePadApp.Model
{
    internal class OldPhonePad
    {
        // I use a List of List cause using the Number of the Input like caracters List Identifier
        List<List<char>> Lista = new List<List<char>>
        {
            new List<char> { '0', '0', '0'}, // 0 
            new List<char> { '&', '´', '('}, // 1
            new List<char> { 'A', 'B', 'C'},  // 2
            new List<char> { 'D', 'E', 'F'}, // 3
            new List<char> { 'G', 'H', 'I'}, // 4
            new List<char> { 'J', 'K', 'L'}, // 5
            new List<char> { 'M', 'N', 'O'}, // 6
            new List<char> { 'P', 'Q', 'R', 'S'}, // 7
            new List<char> { 'T', 'U', 'V'}, // 8
            new List<char> { 'W', 'X', 'Y', 'Z'}, // 9
        };
        public string OldPhonePadFunction(string input)
        {
            // Its the variable i will return
            string Texto = "";
            if (input.Contains('#'))
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '#')
                    {
                        if (Texto.Length == 0) { Texto = "# is on the first position"; }
                        break;
                    }
                    if (input[i] != ' ' && input[i] != '*') // Ignore spaces and asterisks (*)
                    {
                        if (input[i] != '0') // Ignore 0
                        {
                            int cont = 1;
                            for (int j = i + 1; j < input.Length; j++) // Count how many identical characters are repeated consecutively
                            {
                                if (cont <= Lista[input[i] - '0'].Count)  // Limit repeated characters to the max allowed (3 or 4) based on the digit pressed
                                {
                                    if (input[i] == input[j]) // If characters at positions i and j are equal, increment the count of repeated characters
                                    {
                                        cont++;
                                    }
                                    else
                                    {
                                        i = j - 1; // Add last value to avoid duplicates; subtract 1 since main loop will increment
                                        if (input.Length > j)  // Check not at end of string
                                        {
                                            if (input[j] == '*') // If '*' detected, decrement number count
                                            {
                                                cont--;
                                            }
                                        }
                                        break; // If '*' detected, decrement number count
                                    }
                                }
                            }
                            if (cont > 0)
                            {
                                Texto += Lista[input[i] - '0'][cont - 1];
                            }
                        }
                        else
                        {
                            Texto += ' ';
                        }
                    }
                }
                return Texto;
            }
            else { return null; }
        }
    }
}
