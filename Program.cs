using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*double[] arr = { 2, 5, 8.9, 5.08, 0.8 };
            Console.WriteLine(arr[3]);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Hello World!");
            Console.Write("Whats your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name+" !");
            Console.Write("Enter a number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            char a = 'a';
            string name1 = "khan";
            int age = 30;
            double test = 4.6;
            bool ten = true;
            age++;
            age--;
            Console.WriteLine(a+" "+name+"\n"+ age);
            Console.WriteLine(age);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Length);
            Console.WriteLine(name[2]);
            Console.WriteLine(name.Contains("b"));
            Console.WriteLine(a);*/
            //test("is not good ");
            //test("is like a hell");
            //test("is getting worse day by day");
            /* cube(3);
             cube(5.68);*/
            /*decimal num1 = 45.676M;
            Console.WriteLine(num1);
            int age1 = 18;
            if (age1 < 18)
            {
                Console.WriteLine("you are not eligible for vote");
            } else if (age1 == 18) 
            {
                Console.WriteLine("Go vote !");
            }else if(age1 > 18)
            {
                Console.WriteLine("you are eligble  for vote");
            }*/

            /*
                        Console.Write("Enter a number : ");
                        double num1 = Convert.ToDouble(Console.ReadLine());*/
            /*Console.WriteLine("Choose the operator you want to perform");
            Console.WriteLine("Choose 1 for Addition");
            Console.WriteLine("Choose 2 for Subtraction");
            Console.WriteLine("Choose 3 for Multiplication");
            Console.WriteLine("Choose 4 for Division");
            Console.WriteLine("Choose 5 for Modulas");*/
            /*Console.Write("Enter the operator : ");
            string operation = Console.ReadLine();
            Console.Write("Enter a another number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2)); 
                    break;
                case "-":
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
                    break;
                case "%":
                    Console.WriteLine($"{num1} % {num2} = " + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            if (operation == "+")
            {
                Console.WriteLine(num1+ " + " +num2+ " = " +(num1 + num2));
            }
            else if (operation == "-")
            {
                Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
            }
            else if (operation == "/")
            {
                Console.WriteLine($"{num1} / {num2} = " + (num1/num2));
            }else if(operation == "*")
            {
                Console.WriteLine($"{num1} * {num2} = " + (num1*num2));
            }else if (operation == "%")
            {
                Console.WriteLine($"{num1} % {num2} = " + (num1 % num2));
            }
            else
            {
                Console.WriteLine("Invalid Operator !");
            }
            
            int index = 1;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
                Thread.Sleep(300);
            }*/
            /*try
            {
                Console.Write("Enter a number : ");
                double table = Convert.ToDouble(Console.ReadLine());
                for (double i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{table} X {i} = " + (table * i));
                    Thread.Sleep(100);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }*/
            
            /*string pass = "root";
            Console.WriteLine("you have only 5 chnace to guess the password");
            string password = "";
            int passCount = 0;
            int passLimit = 5;
            bool outOfPass = false;
            while(password != pass && !outOfPass)
            {
                if (passCount < passLimit )
                {
                    Console.WriteLine("Entre passowrd : ");
                    password = Console.ReadLine();
                    passCount++;
                }else
                {
                    outOfPass = true;
                }
            }
            if (outOfPass)
            {
                Console.WriteLine("Wrong password ! \n You LOSE !  \n Hit Enter to close the window");
            }else
            {
                Console.WriteLine("Correct password ! \n You WIN ! \n Hit Enter to close the window");
            }*/

           /* Console.WriteLine("Enter base  number : ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Power number : ");
            int powNum = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i=0; i < powNum; i++)
            {
                result = result * baseNum;
                
            }
            Console.WriteLine(result);
            int[,] arr2D =
            {
                {1,2,7 },
                {3,4 ,8},
                {5,6 ,9}
            };
            Console.WriteLine(arr2D[1, 1]);*/

            Book bk1 = new("JACK");
            bk1.title = "Marvel";
            bk1.author = "Stan lee";
            bk1.pages = 999999999;
            Console.WriteLine(bk1.title);

            Book bk2 = new Book("BOB");
            bk2.title = "DC";
            bk2.author = "Warner Bros";
            bk2.pages = 2321;
            Console.WriteLine(bk2.title);


            Movie m1 = new("khan", 18);
            m1.title = "Hello";
            Console.WriteLine(m1.title);
        }
        static void test(string hello)
        {
            Console.WriteLine("world " +hello);
        }
        static double cube (double num)
        {
            Console.WriteLine(num * num * num);
            return 0;
        }
    }
}
