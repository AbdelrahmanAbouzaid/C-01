namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a number : ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number);

            #endregion

            #region Q2

            //Console.Write("Enter a number : "); //input : Ahmed
            //int number = int.Parse(Console.ReadLine()); // can not parsin , incorrect format
            //Console.WriteLine(number); 
            #endregion

            #region Q3
            //float num1 = 1.5f;

            //float num2 = 1.3f;

            //float sum = num1 + num2;
            //Console.WriteLine("sum" + sum);

            //float difference = num1 - num2;
            //Console.WriteLine("difference" + difference);

            //float product = num1 * num2;
            //Console.WriteLine("product" + product);

            //float division = num1 / num2;
            //Console.WriteLine("division" + division);
            #endregion

            #region Q4
            //string str = "Hello world";
            //Console.WriteLine(str.Substring(6)); 

            //Console.Write("Enter the string : ");
            //string str = Console.ReadLine();

            //Console.Write("Enter the number of Substring : ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine(str.Substring(number));

            #endregion

            #region Q5
            //// Declare and initialize a value type variable
            //int number1 = 5;

            ////Assign value to another variable
            //int number2 = number1;

            ////modify the value
            //number1 = 10;

            ////number1 = 10;
            ////number2 = 5;
            //Console.WriteLine(number1); //10
            //Console.WriteLine(number2); //5 
            #endregion

            #region Q6
            ////Declate and initialize a reference type
            //Point point1 = new Point() { x = 5, y = 10 };
            ////Assign value to another variable
            //Point point2 = point1;

            ////modify the value
            //point1.x = 10;
            //point1.y = 15;

            ////point1 = (10 ,15) 
            ////point2 = (10 ,15) //because there is two object refere the same object
            //Console.WriteLine(point1);
            //Console.WriteLine(point2); 
            #endregion

            #region Q7

            //Console.Write("Enter The First String : ");
            //string str1 = Console.ReadLine();

            //Console.Write("Enter The Second String : ");
            //string str2 = Console.ReadLine();

            //string result = str1 +' '+ str2;
            //Console.WriteLine(result); 
            #endregion

            #region Q8
            //Console.Write("Enter the principal amount : ");
            //double principal = double.Parse(Console.ReadLine());

            //Console.Write("Enter the Rate  : ");
            //double rate = double.Parse(Console.ReadLine());

            //Console.Write("Enter the Time : ");
            //double time = double.Parse(Console.ReadLine());

            //double result = (principal * rate * time) / 100;
            //Console.WriteLine( result); 
            #endregion

            #region Q9
            //Console.Write("Enter the weight (kg) : ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.Write("Enter the Height (m) : ");
            //double height = double.Parse(Console.ReadLine());

            //double BMI = weight / (height * height);
            //Console.WriteLine("BMI = " + BMI ); 
            #endregion

            #region Q10
            //Console.Write("Enter the temperature : ");
            //int temperature = int.Parse(Console.ReadLine());

            //string result = temperature > 30 ? "Just Hot" :
            //    temperature < 10 ? "Just Cold" : "Just Good";
            //Console.WriteLine(result); 
            #endregion

            #region Q11
            //Console.Write("Enter the day : ");
            //int day = int.Parse(Console.ReadLine());

            //Console.Write("Enter the month : ");
            //int month = int.Parse(Console.ReadLine());

            //Console.Write("Enter the year : ");
            //int year = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} - {month} - {year}"); 
            #endregion

            #region Q12
            //DateTime date = new DateTime(2024, 6, 14);
            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
            ////The output
            ////C) The event is on 06/14/2024 
            #endregion

            #region Q13
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine(d); //it will be convert true into 1
            ////f)	A value 1 will be assigned to d. 
            #endregion

            #region Q14

            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            ////6 1 -> because it's (int)  
            #endregion

            #region Q15
            //int num = 1, z = 5;

            //if (!(num <= 0)) //!false = true
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            ////output 7 7 
            #endregion

        }
    }
}
