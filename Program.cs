using System;
using System.Text;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

        start:
            for (; ; )
              {

                   
                    Console.WriteLine("Select option:" + "\n" +
                        "1.Reverse String" + "\n" +
                        "2.Check Palindrome" + "\n" +
                        "3.Reverse Order" + "\n" +
                        "4.Reverse each word" + "\n" +
                        "5.Count Occurence" +"\n"+
                        "6.End program");
            
                    int option = Convert.ToInt32(Console.ReadLine());
                    
               
                    if (option == 1)
                    {
                        //while loop

                        start1:
                            //built in reverse method
                            Console.WriteLine("Enter string to reverse");
                            string str = Console.ReadLine();
                            char[] stringArray = str.ToCharArray();
                            Array.Reverse(stringArray);
                            string reverseString = new string(stringArray);
                            Console.WriteLine($"Reversed String is : {reverseString} ");
                            Console.WriteLine("Press enter to continue or press 0 to return to main program ");

                            int zero;
                            var input = Console.ReadKey();
                           
                            if (input.Key == ConsoleKey.Enter) 
                            {
                                goto start1;
                     
                            }
                            else if(char.IsDigit(input.KeyChar)) 
                            {
                               zero = Convert.ToInt32(input.KeyChar.ToString());
                              Console.ReadLine();

                              goto start;
                               
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
                    
                    //ending the outter infinite loop
                    break;

                    }
                    else if (option == 2) 
                    {


                //for loop to check if word is a Palindrome or not
                      start2:
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
                        
                    Console.WriteLine("Press enter to contine or 0 to end program");
                    Console.ReadLine();

                    int zero1;
                    var enter1 = Console.ReadKey();

                    if (enter1.Key == ConsoleKey.Enter)
                    {
                        goto start2;

                    }
                    else if (char.IsDigit(enter1.KeyChar))
                    {
                        zero1 = Convert.ToInt32(enter1.KeyChar.ToString());
                        Console.ReadLine();
                        goto start;
                    }

                    break;

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
                    else if (option == 3)
                    {

                    start3:
                      
                        //Question 3
                        Console.WriteLine("Enter String of words to reverse");
                        string s = Console.ReadLine();
                        string[] StringArray = s.Split(' ');
                        Array.Reverse(StringArray);
                        Console.Write("Reverse String is: ");
                        for (int i = 0; i <= StringArray.Length -1; i++)
                        {
                            Console.Write(StringArray[i] + "" + ' ');

                        }
                      Console.ReadLine();
                      Console.WriteLine("Press enter to continue or press 0 to return to main program ");


                    int zero2;
                    var enter2 = Console.ReadKey();

                    if (enter2.Key == ConsoleKey.Enter)
                    {
                        goto start3;
                    }
                    else if (char.IsDigit(enter2.KeyChar))
                    {
                        zero2 = Convert.ToInt32(enter2.KeyChar.ToString());
                        Console.ReadLine();
                        goto start;
                    }
                    break;

                }
                    else if(option == 4)
                        {

                        start4:

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
                        Console.WriteLine("Press enter to continue or press 0 to return to main program ");


                        int zero3;
                        var enter3 = Console.ReadKey();

                        if (enter3.Key == ConsoleKey.Enter)
                        {
                            goto start4;

                        }
                        else if (char.IsDigit(enter3.KeyChar))
                        {
                            zero3 = Convert.ToInt32(enter3.KeyChar.ToString());
                            Console.ReadLine();
                             goto start;
                        }

                    break;

                    }
                    else if (option == 5) 
                    {

                      start5:
                
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
                        Console.WriteLine("Press enter to continue or press 0 to return to main program ");



                           int zero4;
                            var enter4 = Console.ReadKey();

                            if (enter4.Key == ConsoleKey.Enter)
                            {
                                goto start5;

                            }
                            else if (char.IsDigit(enter4.KeyChar))
                            {
                                zero4 = Convert.ToInt32(enter4.KeyChar.ToString());
                                Console.ReadLine();
                                goto start;
                            }

                    break;
                    }
                   
                    else if(option == 6)
                    {
                     Console.WriteLine("THANK YOU,Bye");
                     Environment.Exit(0);
                    }

                       


            }


        }
    }
    
}