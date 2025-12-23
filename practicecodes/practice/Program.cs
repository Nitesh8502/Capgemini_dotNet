using System;

class Practice
{
  public static void Main(String[] args)
  {
    // Console.WriteLine("Enter the number");
    // int n=Convert.ToInt32(Console.ReadLine());

    // for(int i = 0; i <= n; i++)
    // {
    //   Console.WriteLine($"number is {i}");
    // }

    // for(int i = 0; i <= n; i++)
    // {
    //   if (i % 2 == 0)
    //   {
    //       Console.WriteLine($"number is {i}");
    //   }
    // }

    // int i=0;
    // int sum=0;
    // while (i <= n)
    // {
    //   sum+=i;
    //   i++;
    // }
    // Console.WriteLine("sum of the numebers is {0}",sum);

    // for(int i = 1; i <= 10; i++)
    // {
    //   Console.WriteLine("{0} X {1} = {2}",i,n,(i*n));
    // }

    // int first=0;
    // int second=1;

    // int sum=0;
    // for(int i = 0; i <= n; i++)
    // {
    //   sum=first+second;
    //   Console.WriteLine($"{sum}");
    //   first=second;
    //   second=sum;
    // }

    // int count=0;

    // for(int i = 1; i <= n; i++)
    // {
    //   if (n % i == 0)
    //   {
    //     count++;
    //   }
    // }
    // if (count > 2)
    // {
    //   Console.WriteLine("number is not prime");
    // }
    // else
    // {
    //   Console.WriteLine("number is prime");
    // }


    // string input;
    // Console.WriteLine("enter the armnumber ");
    // input=Console.ReadLine();
    // int len=input.Length;

    // //Console.WriteLine($"{len}");

    // int armstrong=0;
    // for(int i = 0; i < len; i++)
    // {
    //   int s = int.Parse(input[i].ToString());
    //   armstrong+=(int)Math.Pow(s,len);
    // }
    // Console.WriteLine(armstrong);

    // if(armstrong == int.Parse(input))
    // {
    // Console.WriteLine("Armstrong Number");
    // }
    // else
    // {
    // Console.WriteLine("Not an Armstrong Number");
    // }

    // Console.Write("enter n1: ");
    // int n1 = int.Parse(Console.ReadLine());

    // Console.Write("enter n2: ");
    // int n2 = int.Parse(Console.ReadLine());

    // Console.WriteLine("armstrong numbers between n1 and n2:");

    // for (int num = n1; num <= n2; num++)
    // {
    //   string input = num.ToString();
    //   int len = input.Length;
    //   int armstrong = 0;

    //   for (int i = 0; i < len; i++)
    //   {
    //     int digit = int.Parse(input[i].ToString());
    //     armstrong += (int)Math.Pow(digit, len);
    //   }

    //   if (armstrong==num)
    //   {
    //     Console.WriteLine(num);
    //   }
    // }


    // Console.WriteLine("enter a floating point number: ");
    // float naam = float.Parse(Console.ReadLine());
    // Console.WriteLine("You entered: " +naam);

    // Console.Write("Enter a string: ");
    // string iiii = Console.ReadLine();
    // Console.WriteLine("You entered: " +iiii);

    // Console.Write("eter radius: ");
    // double r = double.Parse(Console.ReadLine());
    // double area = 3.14 * r * r;
    // Console.WriteLine("Area of Circle: "+area);

    // Console.Write("enter first number: ");
    // int a = int.Parse(Console.ReadLine());

    // Console.Write("Enter second number: ");
    // int b = int.Parse(Console.ReadLine());

    // if (a>b)
    // {
    //   Console.WriteLine("greatest: " +a);
    // }
    // else
    // {
    //   Console.WriteLine("greatest: " +b);
    // }

    //  Console.Write("Enter a number: ");
    // int num = int.Parse(Console.ReadLine());

    // if (num>0)
    // {
    //   Console.WriteLine("Positive");
    // }
    // else if (num<0)
    // {
    //   Console.WriteLine("Negative");
    // }
    // else
    // {
    //   Console.WriteLine("Zero");
    // }

    // Console.Write("Enter first number: ");
    // int a = int.Parse(Console.ReadLine());

    // Console.Write("Enter second number: ");
    // int b = int.Parse(Console.ReadLine());

    // Console.Write("Enter third number: ");
    // int c = int.Parse(Console.ReadLine());

    // int greatest = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
    // Console.WriteLine("Greatest: " + greatest);

    // int regno;
    // string name;
    // int[] marks = new int[6];
    // int total = 0;
    // double avg;
    // string division;

    // Console.Write("Enter Student Roll Number: ");
    // regno = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Enter Student Name: ");
    // name = Console.ReadLine();

    // for (int i=0;i<6;i++)
    // {
    //   Console.Write("Enter marks of subject " + (i + 1) + ": ");
    //   marks[i] = Convert.ToInt32(Console.ReadLine());
    //   total += marks[i];
    // }

    // avg = total/6;

    // if (avg>= 60)
    //   division ="First Division";
    // else if (avg>=45)
    //   division ="Second Division";
    // else if (avg>=33)
    //   division="Third Division";
    // else
    //   division ="Fail";

    // Console.WriteLine("Student Result");
    // Console.WriteLine("Roll Number : " +regno);
    // Console.WriteLine("Name        : " +name);
    // Console.WriteLine("Total Marks : " +total);
    // Console.WriteLine("Average     : " +avg);

    // if (avg>=33)
    //   Console.WriteLine("Result      : Pass");
    // else
    //   Console.WriteLine("Result      : Fail");

    // Console.WriteLine("Division    : " +division);


    // int no;
    // string name;
    // double basic,pf,hra,da,gross,net;

    // Console.Write("Enter Employee Number: ");
    // no = Convert.ToInt32(Console.ReadLine());

    // Console.Write("Enter Employee Name: ");
    // name = Console.ReadLine();

    // Console.Write("Enter Basic Salary: ");
    // basic = Convert.ToInt32(Console.ReadLine());

    // pf = basic*12/100;
    // hra = basic*20/100;
    // da = basic*15/100;

    // gross = basic+pf+hra+da;
    // net = gross-pf;

    // Console.WriteLine("Salary Detail");
    // Console.WriteLine("Employee No   : " +no);
    // Console.WriteLine("Employee Name  : " +name);
    // Console.WriteLine("Basic Salary : " +basic);
    // Console.WriteLine("Gross Salary: " +gross);
    // Console.WriteLine("Net Salary   : " +net);

    // int sum=0;
    // for(int i=3;i<=100; i++)
    // {
    //   if(i%3==0 || i % 5 == 0)
    //   {
    //     sum+=i;
    //   }
    // }
    // Console.WriteLine(sum);

    // int ans=0;
    // int i=1;
    // while (ans < 100)
    // {
    //   ans=17*i;
    //   Console.Write(ans+" ");
    //   i++;
    // }

    // int n;
    // Console.WriteLine("enter the number");
    // n=Convert.ToInt32(Console.ReadLine());

    // int sum=0;
    // while (n > 0)
    // {
    //   sum+=n%10;
    //   n=n/10;
    // }
    // Console.Write(sum);


    // int no;
    // string name;
    // float marks;
    // char choice;

    // do
    // {
    //   Console.Write("nter student number");
    //   no = Convert.ToInt32(Console.ReadLine());

    //   Console.Write("enter student name: ");
    //   name = Console.ReadLine();

    //   Console.Write("enter marks: ");
      

    //   Console.WriteLine("Student Details");
    //   Console.WriteLine("Number " +no);
    //   Console.WriteLine("Name " + name);
    //   Console.WriteLine("Marks " + marks);

    //   Console.Write("Do you want to enter another student? (y/n): ");
    //   choice = Convert.ToChar(Console.ReadLine());

    // } while (choice == 'y' || choice == 'Y');

  Console.WriteLine("Write a number between 1-n : ");
    int n = (Convert.ToInt32(Console.ReadLine()));

    System.Console.WriteLine();
    System.Console.WriteLine();
        
    // for(int i = 1; i <= n; i++)
    // {   
    //   for(int j = 1; j <= n-i; j++)
    //   {
    //   System.Console.Write(" ");
    //   }
    //   for(int j = 1; j <= i; j++)
    //   {   
    //   System.Console.Write(j + " ");
    //   }
    //   System.Console.WriteLine();
    // }
  }
}