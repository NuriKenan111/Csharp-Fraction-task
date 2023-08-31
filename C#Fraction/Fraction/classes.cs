namespace Fraction;

public class Point
{
    private int x;
    private int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public int X { get; set; }

    public int Y
    {
        get => y
        set{ if (value > 0) this.x = value;}
    }

    public void Showdata()
    {
        Console.WriteLine($"x : {x} ");
        Console.WriteLine($"y : {y} ");
    }
}


public class Counter{

    private int min;
    private int max;
    private int curdata;

   

    public int Min
    {
        get => min;

        set
        {
            value > 0 ? this.min = value : this.min = default;
        }
    }

    public int Max
    {
        get => max;

        set
        {
            value > 0 ? this.max = value : this.max = default;
        }
    }

    public int CurrentData
    {
        get => curdata;
    }

     public void Increment()
    {
        curdata = min;
        while (curdata <= Max)
        {
            Console.Clear();
            Console.WriteLine(curdata / max);
            curdata++;
            Console.WriteLine("\n\n\n");
        }

    }
     public classes(int min,int max)
    {
        this.min = min;
        this.max = max;
    }
}


public class Fraction
{
    private double num; 
    private double denum;

    public Fraction(int num, int denum)
    {
        this.num = num;
        if (denum != 0)
            this.denum = denum;
        else
            this.denum = 1;
    }

   public Fraction()
    {
        this.num = default;
        this.denum = 1;
    }

    public double num
    {
        get => this.num;

        set => this.num = value;
    }

    public double Denum
    {
        get => this.denum;

        set
        {
            if (value != 0)
                this.denum = value;
        }
    }

    public void Reduction()
    {
       double cr = num;
       for (float i = cpy;i > 0;i--)
        {
            if(denum % i == 0 && num % i == 0)
            {
                denum /= i;
                num /= i;
                break;
            }
        }
       
    }

    public double Add()
    {
        Reduction();
        return num + denum;

    }

    public double Subs()
    {
        Reduction();
        return num - denum ;
    }

    public double Mult()
    {
        Reduction();
        return denum * num;
    }

    public double Divide()
    {
        Reduction();
        return num / denum;
    }

    public void ShowFraction()
    {
        Console.WriteLine($"Numerator: {num}");
        
        Console.WriteLine($"Denumerator: {denum}");
    }
}