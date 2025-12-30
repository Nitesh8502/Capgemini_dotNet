using System;
class Program
{
    public static void Main(string[] args)
    {
        string fname, lname;

        fname="Pankaj";
        lname="Sharma";
        char []letters={'h','e','l','l','o'};
        string sarray={"Hello", "World","tutorails","point"};

        string fullname=fname+lname;

        Console.WriteLine("First Name: " + fname);
        Console.WriteLine("Last Name: " + lname);
        Console.WriteLine("Full Name: " + fullname);
        string greeting=new string(letters);
        Console.WriteLine("Greting: (0)", greesting);

        string message=String.Join(" ", sarray);
        Console.WriteLine("Message: " + message);
        
        DateTime waiting =new DateTime(2012,10,10,17,58,1);
        string chat =StringFormat("Mesasage sen at {0:t} on {0:D}",waiting);
        Console.WriteLine("Message :{0}",chat);

        string str1="this is test";
        string str2="this is test";
        if (string.Compare(str1, str2) == 0)
        {
            Console.WriteLine(str1+" and "+str2+" are equal");
        }
        else
        {
            Console.WriteLine(str1+" and "+str2+" are not equal");
        }

        string str="this is test";
        if (str.Contains("test"))
        {
            Console.WriteLine("this sequence contains test");
        }

        string str3="last christmans i gave you my heart";
        Console.WriteLine("Before REplace: "+str3);
        string substr=str3.Substring(23);
        Console.WriteLine(substr);

        Console.WriteLine("Hello\nWorld");
        Console.WriteLine("\"hello world\"");
        Console.WriteLine("D:\\projets\\csharp\\program.cs");
        Console.WriteLine(@"D:\projects\csharp\program.cs");

        var message1=@"Hello bro,
                whatss up
                your files have veen ssaved to this daymnn location 
                \shared\blah
                Thanks.";
        Console.WriteLine(message1);

        Console.ReadKey();

    }
}