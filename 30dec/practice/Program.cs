using System;
using System.Reflection.Metadata;

class Program {

 // 1)))
  static void Main() {
    // string str = Console.ReadLine();
    // Console.WriteLine(str);

    // //2)))

    // string[] arr = new string[10];

    // for(int i = 0; i < 10; i++) 
    // {
    //   arr[i] = Console.ReadLine();
    // }

    // for(int i = 0; i < 10; i++) 
    // {
    //   Console.WriteLine(arr[i]);
    // }

    //3))

    // int[,] brr=new int[2,2];
    // for(int i = 0; i < 2; i++)
    // {
    //   for(int j = 0; j < 2; j++)
    //   {
    //     brr[i,j]=int.Parse(Console.ReadLine());
    //   }
    // }
    
    // for(int i = 0; i < 2; i++) {
    //   for(int j = 0; j < 2; j++)
    //   {
    //     Console.Write(brr[i,j] + " ");
    // }
    //   Console.WriteLine();
    // }

    //4)))

    //  int[,] a = new int[2,2];
    // int[,] b = new int[2,2];
    // int[,] c = new int[2,2];

    // for(int i = 0; i < 2; i++)
    //   for(int j = 0; j < 2; j++)
    //     a[i,j] = int.Parse(Console.ReadLine());

    // for(int i = 0; i < 2; i++)
    //   for(int j = 0; j < 2; j++)
    //     b[i,j] = int.Parse(Console.ReadLine());
    
    // for(int i = 0; i < 2; i++)
    // {
    //   for(int j = 0; j < 2; j++)
    //   {
    //     c[i,j]=a[i,j]+b[i,j];
    //   }
    // }
    // for(int i = 0; i < 2; i++)
    // {
    //   for(int j = 0; j < 2; j++)
    //   {
    //     Console.Write(c[i,j]);

    //   }
    //   Console.WriteLine();
    // }

    //5)))

    // int[,] a = new int[2,2];
    // int[,] b = new int[2,2];
    // int[,] c = new int[2,2];

    // for(int i = 0; i < 2; i++){
    //   for(int j = 0; j < 2; j++){
    //     a[i,j] = int.Parse(Console.ReadLine());
        //}
        //}     

    // for(int i = 0; i < 2; i++)
    //   for(int j = 0; j < 2; j++)
    //     b[i,j] = int.Parse(Console.ReadLine());

    // for(int i = 0; i < 2; i++)
    //   for(int j = 0; j < 2; j++)
    //     for(int k = 0; k < 2; k++)
    //       c[i,j] += a[i,k] * b[k,j];

    // for(int i = 0; i < 2; i++) {
    //   for(int j = 0; j < 2; j++)
    //     Console.Write(c[i,j] + " ");
    //   Console.WriteLine();
    // }


    //6))
    // for(int i = 0; i < 2; i++) {
    //   for(int j = 0; j < 2; j++){
    //     Console.Write(a[j,i] + " ");
    //   }
    //   Console.WriteLine();
    // }

    //7))
    // int[,] a=new int[3,3];
    // for(int i = 0; i < 3; i++)
    // {
    //   for(int j = 0; j < 3; j++)
    //   {
    //    a[i,j]=int.Parse(Console.ReadLine());
    //   }
    // }
    // bool isdiagonal=true;
    // for(int i = 0; i < 3; i++)
    // {
    //   for(int j = 0; j < 3; j++)
    //   {
    //     if(i!=j && a[i, j] != 0)
    //     {
    //       isdiagonal=false;
    //     }
    //   }
    // }
    // Console.WriteLine(isdiagonal);

    //8))

    // string str = Console.ReadLine();
    // char[] arr = str.ToCharArray();
    // Array.Reverse(arr);
    // Console.WriteLine(new string(arr));

    //9))
    // string str = Console.ReadLine();

    // for(int i = str.Length - 1; i >= 0; i--)
    //   Console.Write(str[i]);

    //10)))
    //char ch = char.Parse(Console.ReadLine());
    // if(ch >= 'a' && ch <= 'z')
    // ch = Convert.ToChar(ch - 32);
    // else if(ch >= 'A' && ch <= 'Z')
    // ch = Convert.ToChar(ch + 32);


    // Console.WriteLine(ch);

    //11))

    // string str = Console.ReadLine();
    // char[] arr = str.ToCharArray();

    // for(int i = 0; i < arr.Length; i++) {
    //   if(arr[i] >= 'a' && arr[i] <= 'z')
    //     arr[i] = Convert.ToChar(arr[i] - 32);
    //   else if(arr[i] >= 'A' && arr[i] <= 'Z')
    //     arr[i] = Convert.ToChar(arr[i] + 32);
    // }

    // Console.WriteLine(new string(arr));

    //12))
    // string a = Console.ReadLine();
    // string b = Console.ReadLine();

    // if(a.Equals(b))
    //   Console.WriteLine("equal");
    // else
    //   Console.WriteLine("not Equal");

    //13))
    //  string a = Console.ReadLine();
    // string b = Console.ReadLine();
    // bool equal = true;

    // if(a.Length != b.Length)
    //   equal = false;
    // else {
    //   for(int i = 0; i < a.Length; i++) {
    //     if(a[i] != b[i]) {
    //       equal = false;
    //       break;
    //     }
    //   }
    // }

    // Console.WriteLine(equal ? "equal" : "not equal");

    //14))
    // string str1=Console.ReadLine();
    // string str2=Console.ReadLine();

    // string result=string.Concat(str1,str2);
    // Console.WriteLine(result);

    //15)))
    // string a=Console.ReadLine();
    // string b=Console.ReadLine();

    // char[] result=new char[a.Length+b.Length];
    // int k=0;
    // for(int i = 0; i < a.Length; i++)
    // {
    //   result[k]=a[i];
    //   k++;
    // }
    // for(int i = 0; i < b.Length; i++)
    // {
    //   result[k]=b[i];
    //   k++;
    // }
    // for(int i = 0; i < result.Length; i++)
    // {
    //   Console.Write(result[i]);
    // }

    //16))
    // string a=Console.ReadLine();
    // string result=null;
    // if (a.Contains("dev"))
    // {
    //   result= "lodu";
    // }
    // else result= " no lodu found";
    // Console.WriteLine(result);
  }
}
