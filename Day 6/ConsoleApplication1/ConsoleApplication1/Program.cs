//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApplication1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1, num2,result=0;
//            char choice;
//            while(true) 
//            {
//                Console.Write("enter number 1 : ");
//                num1 = int.Parse(Console.ReadLine());
//                Console.Write("enter number 2 : ");
//                num2 = int.Parse(Console.ReadLine());
//                Console.Write("enter your choice : ");
//                choice = char.Parse(Console.ReadLine());
//                if (choice == '+')
//                    result = num1 + num2;
//                else if (choice == '-')
//                    result = num1 - num2;
//                else if (choice == '*')
//                    result = num1 + num2;
//                else if (choice == '/')
//                    result = num1 / num2;
//                Console.WriteLine("Result is : {0}", result);
//                char opt = ' ';
//                Console.Write("do you want more calculation! :{ y or n } ? : ");
//                opt = char.Parse(Console.ReadLine());
//                if(opt == 'y' )
//                {
//                    continue;
//                }
//                else
//                {
//                    break;
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}
