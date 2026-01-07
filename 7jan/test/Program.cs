using System;

interface Ireport
{
    string returnstring();
}
abstract class Transaction : Ireport
{
    
    public int id{get; set;}
    public DateTime date{get;set;}
    public int amount{get;set;}
    public string description{get;set;}
    public abstract string returnstring();
}
class EarnTransaction : Transaction
{
    public string source;

    public override string returnstring()
    {
        return "earneed Amount  " + amount + " eaerned from=> " + source;
    }
}
class SpendTransaction : Transaction
{
    public string category;

    public override string returnstring()
    {
        return "spent amount  " + amount + " category(on): " + category;
    }
}
class Record<T> where T : Transaction
{
    List<T> value = new List<T>();

    public void Add(T item)
    {
        value.Add(item);
    }

    public int Sum()
    {
        int sum = 0;

        for (int i = 0; i < value.Count; i++)
        {
            sum = sum + value[i].amount;
        }

        return sum;
    }

    public List<T> GetAll()
    {
        return value;
    }
}

class Program
{
    static void Main()
    {
        Record<EarnTransaction> salary = new Record<EarnTransaction>();

        EarnTransaction ear = new EarnTransaction();
        ear.id = 1;
        ear.date = DateTime.Now;
        ear.amount = 500;
        ear.description = "moneyy Added";
        ear.source = " Cash";

        salary.Add(ear);

        Record<SpendTransaction> spentrecord = new Record<SpendTransaction>();

        SpendTransaction obj1 = new SpendTransaction();
        obj1.id = 2;
        obj1.date = DateTime.Now;
        obj1.amount = 20;
        obj1.description = "benchh";
        obj1.category = "work";

        SpendTransaction obj2 = new SpendTransaction();
        obj2.id = 3;
        obj2.date = DateTime.Now;
        obj2.amount = 15;
        obj2.description = "fastfood";
        obj2.category = "fruitss";

        spentrecord.Add(obj1);
        spentrecord.Add(obj2);

        int totalsalary = salary.Sum();
        int totalspent = spentrecord.Sum();
        int balance = totalsalary - totalspent;

        Console.WriteLine("earned = " + totalsalary);
        Console.WriteLine("spent = " + totalspent);
        Console.WriteLine("avail balance = " + balance);

        List<Transaction> finallist = new List<Transaction>();
        finallist.AddRange(salary.GetAll());
        finallist.AddRange(spentrecord.GetAll());
        Console.WriteLine("tranansactions:");
        for (int i = 0; i < finallist.Count; i++)
        {
            Console.WriteLine(finallist[i].returnstring());
        }
    }
}