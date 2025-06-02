namespace assignmentNO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 01
            //decimal number;
            //bool isValed , isReturn;
            //String inputMassage = "Enter The number : " , isReturnValue;

            //do {
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = decimal.TryParse(Console.ReadLine(), out number);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number : ";
            //        }

            //    } while (!isValed);
            //    Console.WriteLine("===================================================");
            //    Console.WriteLine($"The number you entered is : {number}");
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter The new number : ";
            //    }
            //    Console.WriteLine("===================================================");
            //} while(isReturn);

            #endregion

            #region Problem 02
            //int number;
            //bool isValed, isReturn;
            //String inputMassage = "Enter The number : ", isReturnValue;

            //do
            //{
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = int.TryParse(Console.ReadLine(), out number);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number : ";
            //        }

            //    } while (!isValed);
            //    Console.WriteLine("===================================================");
            //    if(number % 3 == 0 && number % 4 == 0)
            //    {
            //        Console.WriteLine("The number is divisible by both 3 and 4.");
            //    }
            //    else
            //    {
            //        if(number % 3 == 0)
            //        {
            //            Console.WriteLine("The number is divisible by 3 and is not divisble by 4.");
            //        }else if (number % 4 == 0)
            //        {
            //            Console.WriteLine("The number is divisible by 4 and is not divisble by 3.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("The number is not divisible by both 3 and 4.");
            //        }
            //    }
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter The new number : ";
            //    }
            //    Console.WriteLine("===================================================");
            //} while (isReturn);
            #endregion

            #region Problem 03
            //int numberOne, numberTwo ;
            //bool isValed, isReturn;
            //String inputMassage = "Enter The number ", isReturnValue;

            //do
            //{
            //    do
            //    {

            //        Console.Write(inputMassage + "One " + ": ");
            //        isValed = int.TryParse(Console.ReadLine(), out numberOne);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    do
            //    {

            //        Console.Write(inputMassage + "Two " + ": ");
            //        isValed = int.TryParse(Console.ReadLine(), out numberTwo);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    if (numberOne > numberTwo)
            //    {
            //        Console.WriteLine($"The first number ({numberOne}) is greater than the second number ({numberTwo}).");
            //    }
            //    else if (numberTwo > numberOne)
            //    {
            //        Console.WriteLine($"The second number ({numberTwo}) is greater than the first number ({numberOne}).");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Both numbers are equal ({numberOne}).");
            //    }
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter The new number ";
            //    }
            //    Console.WriteLine("===================================================");
            //} while (isReturn);
            #endregion

            #region Problem 04
            //int number;
            //bool isValed, isReturn;
            //String inputMassage = "Enter The number : ", isReturnValue;

            //do
            //{
            //    do
            //    {

            //        Console.Write(inputMassage );
            //        isValed = int.TryParse(Console.ReadLine(), out number);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number : ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);

            //    if (number > 0)
            //    {
            //        Console.WriteLine($"The number ({number}) is positive.");
            //    }
            //    else if (number < 0)
            //    {
            //        Console.WriteLine($"The number ({number}) is negative.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The number is Zero.");
            //    }
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter The new number : ";
            //    }
            //    Console.WriteLine("===================================================");
            //} while (isReturn);
            #endregion

            #region Problem 05
            //int numberOne , numberTwo, numberThree;
            //bool isValed, isReturn;
            //String inputMassage = "Enter The number ", isReturnValue;
            //do
            //{
            //    do
            //    {
            //        Console.Write(inputMassage + "One " + ": ");
            //        isValed = int.TryParse(Console.ReadLine(), out numberOne);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter The number ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    do
            //    {
            //        Console.Write(inputMassage + "Two " + ": ");
            //        isValed = int.TryParse(Console.ReadLine(), out numberTwo);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter The number ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    do
            //    {
            //        Console.Write(inputMassage + "Three " + ": ");
            //        isValed = int.TryParse(Console.ReadLine(), out numberThree);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter The number ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    if(numberOne > numberTwo && numberOne > numberThree || numberOne > numberTwo && numberOne == numberThree)
            //    {
            //        if(numberOne > numberTwo && numberOne > numberThree)
            //        {
            //            Console.WriteLine($"The first number ({numberOne}) is the greatest.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"The first number ({numberOne}) is the greatest, but it is equal to the third number ({numberThree}).");
            //        }

            //    }
            //    else if (numberTwo > numberOne && numberTwo > numberThree || numberTwo > numberOne && numberTwo == numberThree)
            //    {
            //        if(numberTwo > numberOne && numberTwo > numberThree)
            //        {
            //            Console.WriteLine($"The second number ({numberTwo}) is the greatest.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"The second number ({numberTwo}) is the greatest, but it is equal to the third number ({numberThree}).");
            //        }
            //    }
            //    else if (numberThree > numberOne && numberThree > numberTwo || numberThree > numberOne && numberThree == numberTwo)
            //    {
            //        if (numberThree > numberOne && numberThree > numberTwo)
            //        {
            //            Console.WriteLine($"The third number ({numberThree}) is the greatest.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"The third number ({numberThree}) is the greatest, but it is equal to the second number ({numberTwo}).");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("All numbers are equal or there is no single greatest number.");
            //    }
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another set of numbers? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter The new number ";
            //        Console.WriteLine("===================================================");
            //    }
            //} while (isReturn);
            #endregion

            #region Problem 06
            //int number;
            //bool isValed, isReturn;
            //String inputMassage = "Enter The number : ", isReturnValue;
            //do
            //{
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = int.TryParse(Console.ReadLine(), out number);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number : ";
            //        }
            //        Console.WriteLine("===================================================");
            //    }while (!isValed);
            //    if (number % 2 == 0)
            //    {
            //        if(number == 0)
            //        {
            //            Console.WriteLine("The number is Zero, which is considered even.");
            //        }
            //        else {
            //            Console.WriteLine($"The number ({number}) is even.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The number ({number}) is odd.");
            //    }

            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter The new number : ";
            //        Console.WriteLine("===================================================");

            //    }
            //} while (isReturn);
            #endregion

            #region Problem 07
            //char character;
            //bool isValed, isReturn;
            //String inputMassage = "Enter a character: ", isReturnValue;
            //do {
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = char.TryParse(Console.ReadLine(), out character);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid character: ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    switch (character.ToString().ToLower()) {
            //        case "a" or "e" or "i" or "o" or "u" :
            //            Console.WriteLine($"The character '{character}' is a vowel.");
            //            break;
            //        default:
            //            Console.WriteLine($"The character '{character}' is not vowel.");
            //            break;
            //    }
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another character? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter a new character: ";
            //        Console.WriteLine("===================================================");
            //    }
            //} while (isReturn);
            #endregion

            #region Problem 08
            //int number;
            //bool isValed, isReturn;
            //String inputMassage = "Enter a number: ", isReturnValue;
            //do {
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = int.TryParse(Console.ReadLine(), out number);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number: ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    for (int i = 1; i <= number; i++)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter a new number: ";
            //        Console.WriteLine("===================================================");
            //    }
            //} while (isReturn);
            #endregion

            #region Problem 09
            //int number;
            //bool isValed, isReturn;
            //String inputMassage = "Enter a number: ", isReturnValue;
            //do
            //{
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = int.TryParse(Console.ReadLine(), out number);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number: ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    for(int i = 0; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{number} x {i} = {number * i}");
            //    }
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter a new number: ";
            //        Console.WriteLine("===================================================");
            //    }
            //} while (isReturn);

            #endregion

            #region Problem 10
            //int number;
            //bool isValed, isReturn;
            //String inputMassage = "Enter a number : ", isReturnValue;
            //do
            //{
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = int.TryParse(Console.ReadLine(), out number);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid number : ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    for(int i = 1; i <= number; i++){
            //        if(i% 2 == 0)
            //        {
            //            Console.WriteLine($"{i} is even.");
            //        }

            //    }
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter a new number: ";
            //        Console.WriteLine("===================================================");
            //    }
            //} while (isReturn);
            #endregion

            #region Problem 11
            //int baseNumber, power;
            //bool isValed, isReturn;
            //String inputMassage = "Enter the base number : ", isReturnValue;
            //do 
            //{
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = int.TryParse(Console.ReadLine(), out baseNumber);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid base number : ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter the power number : ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    do
            //    {
            //        Console.Write(inputMassage);
            //        isValed = int.TryParse(Console.ReadLine(), out power);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid power number : ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);
            //    Console.WriteLine($"The result of {baseNumber} raised to the power of {power} is: {Math.Pow(baseNumber, power)}");
            //    Console.Write("Do you want to enter another number? (yes/no): ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter a new number: ";
            //        Console.WriteLine("===================================================");
            //    }
            //} while (isReturn);
            #endregion

            #region Problem 12
            //decimal subjectOne , subjectTwo , subjectThree, subjectFour, subjectFive, total, Average , Percentage;
            //bool isValed, isReturn;
            //String inputMassage = "Enter the marks for ", isReturnValue;
            //do {
            //    do
            //    {
            //        Console.Write(inputMassage + "Subject One : ");
            //        isValed = decimal.TryParse(Console.ReadLine(), out subjectOne);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid marks for ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter the marks for ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);

            //    do
            //    {
            //        Console.Write(inputMassage + "Subject Two : ");
            //        isValed = decimal.TryParse(Console.ReadLine(), out subjectTwo);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid marks for  ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter the marks for ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);

            //    do
            //    {
            //        Console.Write(inputMassage + "Subject Three : ");
            //        isValed = decimal.TryParse(Console.ReadLine(), out subjectThree);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid marks for  ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter the marks for ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);

            //    do
            //    {
            //        Console.Write(inputMassage + "Subject Four : ");
            //        isValed = decimal.TryParse(Console.ReadLine(), out subjectFour);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid marks for  ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter the marks for ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);

            //    do
            //    {
            //        Console.Write(inputMassage + "Subject Five : ");
            //        isValed = decimal.TryParse(Console.ReadLine(), out subjectFive);
            //        if (!isValed)
            //        {
            //            inputMassage = "Please enter a valid marks for  ";
            //        }
            //        else
            //        {
            //            inputMassage = "Enter the marks for ";
            //        }
            //        Console.WriteLine("===================================================");
            //    } while (!isValed);

            //    total = subjectOne + subjectTwo + subjectThree + subjectFour + subjectFive;
            //    Average = total / 5;
            //    Percentage = (total / 500) * 100;
            //    Console.WriteLine($"Total Marks: {total}");
            //    Console.WriteLine($"Average Marks: {Average}");
            //    Console.WriteLine($"Percentage: {Percentage}%");
            //    Console.WriteLine("===================================================");
            //    Console.Write("Do you want to enter another studen subjects? (yes/no) : ");
            //    isReturnValue = Console.ReadLine()?.Trim().ToLower();
            //    isReturn = isReturnValue == "yes" || isReturnValue == "y" ? true : false;
            //    if (!isReturn)
            //    {
            //        Console.WriteLine("===================================================");
            //        Console.WriteLine("Thank you for using the program!");
            //    }
            //    else
            //    {
            //        inputMassage = "Enter the marks for";
            //        Console.WriteLine("===================================================");
            //    }
            //    } while (isReturn);
            #endregion


        }
    }
}
