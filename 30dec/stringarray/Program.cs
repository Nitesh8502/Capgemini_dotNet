using System;
class Program
{
    public static void Main(string[] args)
    {
        // string fname, lname;

        // fname="Pankaj";
        // lname="Sharma";
        // char []letters={'h','e','l','l','o'};
        // string sarray={"Hello", "World","tutorails","point"};

        // string fullname=fname+lname;

        // Console.WriteLine("First Name: " + fname);
        // Console.WriteLine("Last Name: " + lname);
        // Console.WriteLine("Full Name: " + fullname);
        // string greeting=new string(letters);
        // Console.WriteLine("Greting: (0)", greesting);

        // string message=String.Join(" ", sarray);
        // Console.WriteLine("Message: " + message);
        
        // DateTime waiting =new DateTime(2012,10,10,17,58,1);
        // string chat =StringFormat("Mesasage sen at {0:t} on {0:D}",waiting);
        // Console.WriteLine("Message :{0}",chat);

        // string str1="this is test";
        // string str2="this is test";
        // if (string.Compare(str1, str2) == 0)
        // {
        //     Console.WriteLine(str1+" and "+str2+" are equal");
        // }
        // else
        // {
        //     Console.WriteLine(str1+" and "+str2+" are not equal");
        // }

        // string str="this is test";
        // if (str.Contains("test"))
        // {
        //     Console.WriteLine("this sequence contains test");
        // }

        // string str3="last christmans i gave you my heart";
        // Console.WriteLine("Before REplace: "+str3);
        // string substr=str3.Substring(23);
        // Console.WriteLine(substr);

        // Console.WriteLine("Hello\nWorld");
        // Console.WriteLine("\"hello world\"");
        // Console.WriteLine("D:\\projets\\csharp\\program.cs");
        // Console.WriteLine(@"D:\projects\csharp\program.cs");

        // var message1=@"Hello bro,
        //         whatss up
        //         your files have veen ssaved to this daymnn location 
        //         \shared\blah
        //         Thanks.";
        // Console.WriteLine(message1);
        

        // var name="yolo";
        // var greet="have a  bad day";
        // var greeting=String.Format($"HEllo {name}.{greet}");


        // var num=12;

        // Console.WriteLine(greeting);
        // Console.WriteLine($"square of {num}= {num*num}");


        // var text="hello world";
        // var subtet=text.Substring(6,5);

        // Console.WriteLine(subtet);
        // Console.WriteLine(text.ToUpper());

        // Console.WriteLine(text.ToLower());

        // var text5="   Hello world f ";
        // Console.WriteLine(text5.Trim());

        // var csv="alicd,bob,chris,dave,eric,fred";

        // var names=csv.Split(',');
        // for(var i = 0; i < names.Length; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }
        // var greeeet="helllo boysss letsss go";
        // var index=greeeet.IndexOf("el");
        // var index4=greeeet.LastIndexOf("el");
        // Console.WriteLine(index4);

        int[][] jaggerarr=new int[4][];

        jaggedarr[0]=new int[] {1,2,3,4};
        jaggedarr[1]=new int[] {5,6,7,8};
        jaggedarr[2]=new int[] {23,56};
        jaggedarr[3]=new int[] {7,56,12,0,78,56,33};

        for(int n = 0; n < jaggerarr.Length; n++)
        {
          System.Console.Write("Row{0}",n); 

            for(int k = 0; k < jaggerarr.Length; k++)
            {
                System.Console.Write("{0}",jaggerarr[n][k]);
            }
        }
        System.Console.WriteLine();

        Console.ReadKey();

    }
}