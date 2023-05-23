using System;
using System.Text;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select option:" + "\n" +
                "1.Reverse String" + "\n" +
                "2.Check Palindrome" + "\n" +
                "3.Reverse Order" + "\n" +
                "4.Reverse each word" + "\n" +
                "5.Count Occurence");
            
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                //while loop
                
                while (true)
                {
                    //built in reverse method
                    Console.WriteLine("Enter string to reverse");
                    string str = Console.ReadLine();
                    char[] stringArray = str.ToCharArray();
                    Array.Reverse(stringArray);
                    string reverseString = new string(stringArray);
                    Console.Write($"Reversed String is : {reverseString} ");
                    Console.ReadLine();

                }

                //For each loop
                //Console.Write("Enter a String : ");

                //string word = Console.ReadLine();

                //string revStr = string.Empty;

                //foreach (char c in word)
                //{

                //    revStr = c + word;

                //}

                //Console.Write($"Reverse String is : {revStr} ");

                //Console.ReadLine();


            }
            else if (option == 2) 
            {
                 
                while (true) {
                    
                //for loop to check if word is a Palindrome or not

                Console.WriteLine("Enter a word");
                string word = Console.ReadLine();

                string reverse = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse += word[i];
                }

                if (word == reverse)
                {
                    Console.WriteLine("Palindrome");
                }
                else
                {
                    Console.WriteLine("Not Palindrome");
                }
                    Console.Write("Press enter to contine or 0 to end program");

                    //BUILT IN METHOD

                    //Console.WriteLine("Enter any word");
                    //string text = Console.ReadLine();
                    //string reverse = string.Join("", text.Reverse());

                    //if (text == reverse)
                    //{
                    //    Console.WriteLine("Palindrome");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Not palindrome");
                    //}


                }
            }
            else if (option == 3)
            {
                while (true)
                {

                
                //Question 3
                Console.WriteLine("Enter String of words to reverse");
                string s = Console.ReadLine();
                string[] StringArray = s.Split(' ');
                Array.Reverse(StringArray);
                Console.WriteLine("Reversed String is:");
                for (int i = 0; i <= StringArray.Length -1; i++)
                {
                    Console.Write(StringArray[i] + "" + ' ');

                }
                Console.ReadKey();
                }
            }
            else if (option == 4)
            {
                while (true)
                {

                
                Console.Write("Enter words to reverse : ");
                string originalString = Console.ReadLine();
                StringBuilder reverseWordString = new StringBuilder();
                List<char> charlist = new List<char>();
                for (int i = 0; i < originalString.Length; i++)
                {
                    if (originalString[i] == ' ' || i == originalString.Length - 1)
                    {
                        if (i == originalString.Length - 1)
                            charlist.Add(originalString[i]);
                        for (int j = charlist.Count - 1; j >= 0; j--)
                            reverseWordString.Append(charlist[j]);
                            reverseWordString.Append(' ');
                            charlist = new List<char>();
                    }
                    else
                    {
                        charlist.Add(originalString[i]);
                    }
                }
                Console.WriteLine($"Reversed words : {reverseWordString.ToString()}");
                Console.ReadKey();
                }


            }
            else if (option == 5) 
            {
                while (true)
                {

                
                Console.WriteLine("Enter a string to count occurrence of characters: ");
                string stringOccurence = Console.ReadLine();
                Console.WriteLine("String: " + stringOccurence);
                while (stringOccurence.Length > 0)
                {
                    Console.Write(stringOccurence[0] + " = ");
                    int cal = 0;
                    for (int j = 0; j < stringOccurence.Length; j++)
                    {
                        if (stringOccurence[0] == stringOccurence[j])
                        {
                            cal++;
                        }
                    }
                    Console.WriteLine(cal);
                    stringOccurence = stringOccurence.Replace(stringOccurence[0].ToString(), string.Empty);
                }
                Console.ReadLine();

                }
            }


        }
    }
    
}