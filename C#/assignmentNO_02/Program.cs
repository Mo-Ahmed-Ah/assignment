namespace assignmentNO_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1

            #region Problem 1
            //int monthNumber;
            //bool isValidMonth = false , isReturn;
            //string inputMassage = "Enter a month number (1-12):";
            //do
            //{
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValidMonth = int.TryParse(Console.ReadLine(), out monthNumber);
            //        if (!isValidMonth || monthNumber < 1 || monthNumber > 12)
            //        {
            //            isValidMonth = false;
            //            inputMassage = "Invalid month number. Please enter a number between 1 and 12 :";
            //        }
            //        else
            //        {
            //            isValidMonth = true;
            //        }
            //        Console.WriteLine("=============================================");
            //    } while (!isValidMonth);

            //    switch (monthNumber)
            //    {
            //        case 1 or 3 or 4 or 5 or 6 or 7 or 8 or 9 or 10 or 11 or 12:
            //            Console.WriteLine("The month has 31 days.");
            //            break;
            //        case 2:
            //            Console.WriteLine("The month has 28 days.");
            //            break;
            //    }
            //    Console.WriteLine("=============================================");
            //    Console.Write("Do you want to check another month? (yes/no) : ");
            //    string userResponse = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = userResponse == "yes" || userResponse == "y";
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter a month number (1-12):";
            //        Console.WriteLine("=============================================");
            //    }

            //} while (isReturn);
            #endregion

            #region Problem 2

            #region solution 1
            /*
            decimal Physics, Chemistry, Biology, Mathematics, Computer, percentage;
            bool isValidInput = false, isReturn;
            string inputMassage = "Enter the marks for ";
            do
            {
                do
                {
                    Console.Write(inputMassage + "Physics between 0 and 100 : ");
                    isValidInput = decimal.TryParse(Console.ReadLine(), out Physics);
                    if (!isValidInput || Physics < 0 || Physics > 100)
                    {
                        inputMassage = "Invalid input. Please enter a valid number ";
                    }
                    else
                    {
                        inputMassage = "Enter the marks for ";
                    }
                    Console.WriteLine("=============================================");
                } while (!isValidInput);

                do
                {
                    Console.Write(inputMassage + "Chemistry between 0 and 100 : ");
                    isValidInput = decimal.TryParse(Console.ReadLine(), out Chemistry);
                    if (!isValidInput || Chemistry < 0 || Chemistry > 100)
                    {
                        inputMassage = "Invalid input. Please enter a valid number ";
                    }
                    else
                    {
                        inputMassage = "Enter the marks for ";
                    }
                    Console.WriteLine("=============================================");
                } while (!isValidInput);

                do
                {
                    Console.Write(inputMassage + "Biology between 0 and 100 : ");
                    isValidInput = decimal.TryParse(Console.ReadLine(), out Biology);
                    if (!isValidInput || Biology < 0 || Biology > 100)
                    {
                        inputMassage = "Invalid input. Please enter a valid number ";
                    }
                    else
                    {
                        inputMassage = "Enter the marks for ";
                    }
                    Console.WriteLine("=============================================");
                } while (!isValidInput);

                do
                {
                    Console.Write(inputMassage + "Mathematics between 0 and 100 : ");
                    isValidInput = decimal.TryParse(Console.ReadLine(), out Mathematics);
                    if (!isValidInput || Mathematics < 0 || Mathematics > 100)
                    {
                        inputMassage = "Invalid input. Please enter a valid number ";
                    }
                    else
                    {
                        inputMassage = "Enter the marks for ";
                    }
                    Console.WriteLine("=============================================");
                } while (!isValidInput);

                do
                {
                    Console.Write(inputMassage + "Computer between 0 and 100 : ");
                    isValidInput = decimal.TryParse(Console.ReadLine(), out Computer);
                    if (!isValidInput || Computer < 0 || Computer > 100)
                    {
                        inputMassage = "Invalid input. Please enter a valid number ";
                    }
                    else
                    {
                        inputMassage = "Enter the marks for ";
                    }
                    Console.WriteLine("=============================================");
                } while (!isValidInput);

                percentage = ((Physics + Chemistry + Biology + Mathematics + Computer) * 100) / 500;
                Console.WriteLine($"Your percentage is : {percentage}%");
                switch (percentage)
                {
                    case >= 90:
                        Console.WriteLine("Your grade is : A+");
                        break;
                    case >= 80:
                        Console.WriteLine("Your grade is : A");
                        break;
                    case >= 70:
                        Console.WriteLine("Your grade is : B");
                        break;
                    case >= 60:
                        Console.WriteLine("Your grade is : C");
                        break;
                    case >= 50:
                        Console.WriteLine("Your grade is : D");
                        break;
                    case >= 40:
                        Console.WriteLine("Your grade is : E");
                        break;
                    default:
                        Console.WriteLine("Your grade is : F");
                        break;
                }

                Console.WriteLine("=============================================");
                Console.Write("Do you want to add another marks? (yes/no) : ");
                string userResponse = Console.ReadLine()?.Trim().ToLower();
                isReturn = userResponse == "yes" || userResponse == "y";
                if (!isReturn)
                {
                    Console.WriteLine("Thank you for using the program!");
                }
                else
                {
                    inputMassage = "Enter the marks for ";
                    Console.WriteLine("=============================================");
                }
            } while (isReturn);
            */
            #endregion

            #region solution 2
            /*
            decimal[] marks = new decimal[5];
            string[] subjects = { "Physics", "Chemistry", "Biology", "Mathematics", "Computer" };
            bool isValidInput = false, isReturn;
            string inputMassage = "Enter the marks for ";
            do
            {
                for (int i = 0; i < subjects.Length; i++)
                {
                    do
                    {
                        Console.Write(inputMassage + subjects[i] + " between 0 and 100: ");
                        isValidInput = decimal.TryParse(Console.ReadLine(), out marks[i]);
                        if (!isValidInput || marks[i] < 0 || marks[i] > 100)
                        {
                            inputMassage = "Invalid input. Please enter a valid number ";
                        }
                        else
                        {
                            inputMassage = "Enter the marks for ";
                        }
                        Console.WriteLine("=============================================");
                    } while (!isValidInput);
                }
                decimal percentage = (marks.Sum() * 100) / 500;
                Console.WriteLine($"Your percentage is: {percentage}%");
                switch (percentage)
                {
                    case >= 90:
                        Console.WriteLine("Your grade is: A+");
                        break;
                    case >= 80:
                        Console.WriteLine("Your grade is: A");
                        break;
                    case >= 70:
                        Console.WriteLine("Your grade is: B");
                        break;
                    case >= 60:
                        Console.WriteLine("Your grade is: C");
                        break;
                    case >= 50:
                        Console.WriteLine("Your grade is: D");
                        break;
                    case >= 40:
                        Console.WriteLine("Your grade is: E");
                        break;
                    default:
                        Console.WriteLine("Your grade is: F");
                        break;
                }
                Console.WriteLine("=============================================");
                Console.Write("Do you want to add another marks? (yes/no): ");
                string userResponse = Console.ReadLine()?.Trim().ToLower();
                isReturn = userResponse == "yes" || userResponse == "y";
                if (!isReturn)
                {
                    Console.WriteLine("Thank you for using the program!");
                }
                else
                {
                    inputMassage = "Enter the marks for ";
                    Console.WriteLine("=============================================");
                }
            } while (isReturn);
            */
            #endregion

            #endregion

            #region Problem 3
            //int number;
            //bool isValidnumber = false, isReturn;
            //string inputMessage = "Enter number : ";
            //do
            //{
            //    do
            //    {
            //        Console.Write(inputMessage);
            //        isValidnumber = int.TryParse(Console.ReadLine(), out number);
            //        if (!isValidnumber)
            //        {
            //            inputMessage = "Invalid input. Please enter a valid number : ";
            //        }
            //    } while (!isValidnumber);
            //    switch (number)
            //    {
            //        case > 0:
            //            Console.WriteLine("=============================================");
            //            Console.WriteLine("The number is positive.");
            //            break;
            //        case < 0:
            //            Console.WriteLine("=============================================");
            //            Console.WriteLine("The number is negative.");
            //            break;
            //        case 0:
            //            Console.WriteLine("=============================================");
            //            Console.WriteLine("The number is zero.");
            //            break;
            //    }
            //    Console.WriteLine("=============================================");
            //    Console.Write("Do you want to check another number? (yes/no) : ");
            //    string userResponse = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = userResponse == "yes" || userResponse == "y";
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMessage = "Enter number : ";
            //        Console.WriteLine("=============================================");
            //    }
            //} while (isReturn);

            #endregion

            #region Problem 4
            //int numberOne , numberTwo;
            //Char operatorChoice;
            //bool isValidInput = false, isReturn;
            //string inputMessage = "Enter number ";
            //do
            //{
            //    do
            //    {
            //        Console.Write(inputMessage + "One : ");
            //        isValidInput = int.TryParse(Console.ReadLine(), out numberOne);
            //        if (!isValidInput)
            //        {
            //            inputMessage = "Invalid input. Please enter a valid number ";
            //        }
            //        else
            //        {
            //            inputMessage = "Enter  number ";
            //        }
            //    } while(!isValidInput);
            //    Console.WriteLine("===============================================");
            //    do
            //    {
            //        Console.Write(inputMessage + "Two : ");
            //        isValidInput = int.TryParse(Console.ReadLine(), out numberTwo);
            //        if (!isValidInput)
            //        {
            //            inputMessage = "Invalid input. Please enter a valid number ";
            //        }
            //        else
            //        {
            //            inputMessage = "Enter number ";
            //        }
            //    } while (!isValidInput);
            //    Console.WriteLine("===============================================");
            //    inputMessage = "Enter number ";
            //    do
            //    {
            //        Console.Write("Enter an operator (+, -, *, /) : ");
            //        isValidInput = char.TryParse(Console.ReadLine(), out operatorChoice);
            //        if (!isValidInput || (operatorChoice != '+' && operatorChoice != '-' && operatorChoice != '*' && operatorChoice != '/'))
            //        {
            //            inputMessage = "Invalid operator. Please enter a valid operator (+, -, *, /) : ";
            //            isValidInput = false;
            //        }

            //    } while (!isValidInput);

            //    switch (operatorChoice)
            //    {
            //        case '+':
            //            Console.WriteLine($"The result of {numberOne} + {numberTwo} is : {numberOne + numberTwo}");
            //            break;
            //        case '-':
            //            Console.WriteLine($"The result of {numberOne} - {numberTwo} is : {numberOne - numberTwo}");
            //            break;
            //        case '*':
            //            Console.WriteLine($"The result of {numberOne} * {numberTwo} is : {numberOne * numberTwo}");
            //            break;
            //        case '/':
            //            if (numberTwo != 0)
            //            {
            //                Console.WriteLine($"The result of {numberOne} / {numberTwo} is : {numberOne / numberTwo}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Division by zero is not allowed.");
            //            }
            //            break;
            //    }

            //    Console.WriteLine("=============================================");
            //    Console.Write("Do you want to check another number? (yes/no) : ");
            //    string userResponse = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = userResponse == "yes" || userResponse == "y";
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMessage = "Enter number  ";
            //        Console.WriteLine("=============================================");
            //    }
            //} while (isReturn);
            #endregion

            #region Problem 5
            #region Solve One
            //Solve One 
            //string notReversedString, reversedString="";

            //Console.Write("Enter a string to reverse : ");
            //notReversedString = Console.ReadLine(); 
            //foreach(char character in notReversedString)
            //{
            //    if (character != ' ')
            //    {
            //        reversedString = character + reversedString;
            //    }
            //    else
            //    {
            //        reversedString = ' ' + reversedString;
            //    }
            //}
            //Console.WriteLine(reversedString); 
            #endregion

            #region Solve Two
            //Solve Two
            //int splitIndex = 0, stopIndex = 0;
            //string notReversedString = "", reversedString = "";
            //Console.Write("Enter a string to reverse : ");
            //notReversedString = Console.ReadLine();
            //stopIndex = notReversedString.Length - 1;
            //for (int i = notReversedString.Length - 1 ; i >= 0 ; i--)
            //{
            //    if (notReversedString[i].ToString() == " " || i == 0)
            //    {
            //        splitIndex = i;
            //        if (splitIndex == 0)
            //        {
            //            reversedString =  reversedString.ToString() + ' '.ToString() ;
            //        }
            //        for (int j = splitIndex; j <= stopIndex; j++)
            //        {
            //            reversedString = reversedString.ToString() + notReversedString[j].ToString();
            //        }
            //        stopIndex = splitIndex;
            //    }

            //}
            //Console.WriteLine(reversedString);


            #endregion
            #endregion

            #region Problem 6
            #region Solve_one
            //int number;
            //string numberString, reversNumber = "";

            //Console.Write("Enter a number : ");
            //int.TryParse(Console.ReadLine(), out number);
            //numberString = number.ToString();
            //for (int i = numberString.Length - 1; i >= 0; i--)
            //{
            //    reversNumber += numberString[i];
            //}
            //number = int.Parse(reversNumber);
            //Console.WriteLine($"The reverse of the number is : {number}"); 
            #endregion

            #region Solve_two
            //int numberNotReversed, numberReversed = 0, remainder;
            //Console.Write("Enter the number : ");
            //int.TryParse(Console.ReadLine(), out numberNotReversed);
            //Console.WriteLine("=================================================");
            //Console.WriteLine($"The number is : {numberNotReversed}");
            //while (numberNotReversed > 0)
            //{
            //    remainder = numberNotReversed % 10;
            //    numberReversed = (numberReversed * 10) + remainder;
            //    numberNotReversed /= 10;
            //}
            //Console.WriteLine("=================================================");
            //Console.WriteLine($"The reverse of the number is : {numberReversed}");
            #endregion
            #endregion

            #endregion

            #region part 2

            #region Problem 1   
           
            int[] numbers ;
            int numberOfElements;
            int longesIndex = 0, fristIndex =0;
            bool havGotDuble = false;

            Console.Write("Enter the array length : ");
            int.TryParse(Console.ReadLine(), out numberOfElements);
            numbers = new int[numberOfElements];
            Console.WriteLine("=================================================");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter the {i + 1} number : ");
                int.TryParse(Console.ReadLine(), out numbers[i]);
            }

            for (int i = 0; i < numbers.Length ; i++)
            {
                fristIndex = i ;
                for (int j = 1; j < numbers.Length - 1; j++) 
                {
                    
                    if (numbers[i] == numbers[j])
                    {
                        if(longesIndex < j)
                        {
                            longesIndex = j;
                        }
                        havGotDuble = true;

                    }
                }
                if (havGotDuble)
                {
                    Console.WriteLine(fristIndex);
                    Console.WriteLine(longesIndex);
                    break;
                }
            }
            if(!havGotDuble)
            {
                Console.WriteLine("There is no duplicate number in the array.");
                return;
            }
            else
            {
                Console.WriteLine($"The {numbers[fristIndex]} has duplicate and longest distance is {longesIndex - fristIndex} indexes");
            }
            #endregion

            #region Problem 2
            #endregion

            #endregion




        }
    }
}
