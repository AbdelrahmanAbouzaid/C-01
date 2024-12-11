using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variable Declaration
            //Variable Declaration
            //Datatype VaruableName;
            // int number; //Declare Variable
            // Allocate UnInitialized 4 bytes at stack
            //Console.WriteLine(number);//Invalid, unassigned local variable

            //number = 5;//Initialization

            //Variable
            //1.Datatype :int
            //2.Name     :number
            //3.Value    :5
            //4.Size     :4 bytes
            //5.Address  :0xA2sf

            //Console.WriteLine(number);  
            #endregion

            #region Datatype (Value Type) : Stack
            // Datatype (Value Type) : Stack
            // Declare Variable
            // int Number; // Value Type

            // Allocate Unlnitialized 4 Bytes At Stack
            // int keyword
            // BCE : Int32
            //Int32 Number02;
            // Number = 12
            // "Console.WriteLine(Number02); 
            #endregion

            #region Datatypr (Reference Type) : Heap
            //Point P01; 
            // null
            // Declare Refernce From Type ' Point '
            // P01 : Can Refer To Object From Type 'Point'
            // 8 Bytes Will Be Allocated At Stack For The
            // 0 Bytes Will Be Allocated At Heap

            //ConsoIe.WriteLine(P01);
            //Console.WriteLine(P01.X); //Invalid
            //P01 = new Point();
            // new
            // 1. A1 locate The Number Of Required Bytes For The Object at Heap
            // 2. Initialized The Allocated Byte With The Defaul Value of The Datatype
            // 3. Call user-define Constructor if Exsits
            // 4. Assign The Object Address To The Reference 'P01'

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y); 
            #endregion

            #region Object
            //object O01;
            //// Declare For Reference From Type 'Object'
            ////Can Refer To Instance From Type 'Object' Or Any Type Inherited From Object
            //O01 = new object();

            //O01 = new object();
            //O01 = 1;
            //O01 = 'A';
            //O01 = 1.5;
            //O01 = true;
            //O01 = new Point();

            //Point P01 = new Point();
            //Point P02 = P01;

            //P01.GetType();
            //P01.ToString();
            //P01.GetHashCode();
            //P01.Equals(P02);

            //Console.WriteLine(P01);
            //Console.WriteLine(P01.GetHashCode());
            #endregion

            #region Implicit And Explicit Casting
            // Casting : Convert From Any Datatype To Any Datatype
            // 1. Implicit Casting
            //int X = 5;
            //double Y = X; // Implicit Casting(Safe Casting)
            //Console.WriteLine(Y);

            // 2. Explicit Casting

            //double X = 2.5;
            // int Y = (int) X; // Explicit Casting (UnSafe)
            //ConsoIe.WriteLine(Y) ;

            //long x = 1111111111111111111;
            //int y = (int)x;
            //Console.WriteLine(y);
            //Console.WriteLine(int.MaxValue);
            #endregion

            #region Parse and TryParse
            // Parse : Function

            //Console.Write("Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Age : " + Age);

            // convert : Function

            //Console.Write("Enter Your Age : ");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Age : " + Age);

            // TryParse
            //Console.Write("Enter Your Age : ");
            //bool flag = int.TryParse(Console.ReadLine(), out int age);
            //Console.WriteLine("Age : " + Age);
            //Console.WriteLine("Flag : " + Flag); 
            #endregion

            #region Fractions
            //double d = 1.5;
            //float f = 1.5f;
            //decimal dec = 1.5m;

            //int x = 1_000_000_000; //Discard _ 
            #endregion

            #region Operations
            // 1. Unary Operators Works On One Operand(Variable) 
            //int X = 10;
            //PreFix[Increment then print]
            //Console.WriteLine(++X); // 11
            //PostFix (Print then Increment]
            //ConsoIe.WriteLine(X++); // 10
            //Consote.WriteLine(X); // 11

            //PreFix[Decrement then print]
            //Console.WriteLine(--X); // 9
            //PostFix (Print then Decrement]
            //ConsoIe.WriteLine(X--); // 10
            //Consote.WriteLine(X); // 9

            // 2. Binary Operators Works on Two Operands (Variables)
            //int sum, mul, sub, mod;
            //int number01 = 2, number02 = 6;

            //sum = number01 + number02;
            //mul = number01 * number02;
            //sub = number01 - number02;
            //mod = number01 % number02;


            // 3. Assign Operator
            //int x;
            //x = 5;
            //x += 2;
            //x -= 2;
            //x *= 2;
            //x /= 2;
            //x %= 2;


            // 4. Relational Operators [Comparsion]

            //int x = 5, y = 6;

            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x <= y);


            // 5. Logical Operators 
            //Console.WriteLine(!false);
            //Console.WriteLine(true && false);
            //Console.WriteLine(true || false);

            // 6. Bitwise Operators 
            //Console.WriteLine(!false);
            //Console.WriteLine(true & false);
            //Console.WriteLine(true | false);

            // Ternary Operator

            //string flag = 4 > 2 ? "True" : "False";
            //Console.WriteLine(flag); 
            #endregion
        }
    }
}
