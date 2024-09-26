public class Car
{
    private int hp;
    private string brand; 
    private string model;
    private static int count = 0;

    public Car()
    {
        this.HP = 100;
        this.Brand = "BMW";
        this.Model = "1 - ца";
        Car.count += 1;
    }

    public Car(int hp, string model)
    {
        this.HP = hp;
        this.Brand = "BMW";
        this.Model = model;
        Car.count += 1;
    }

    public Car(string brand, string model)
    {
        this.HP = 90;
        this.Brand = brand;
        this.Model = model;
        Car.count += 1;
    }

    public Car(int hp, string brand, string model)
    {
        this.HP = hp;
        this.Brand = brand;
        this.Model = model;
        Car.count += 1;
    }

    public int HP
    {
        set
        {
            if (value > 0)
            {
                this.hp = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("erro");
            }
        }
        get
        {
            return this.hp;
        }
    }

    public string Model
    {
        set
        {
            this.model = value;
        }
        get
        {
            return this.model;
        }
    }

    public string Brand
    {
        set
        {
            this.brand = value;
        }
        get
        {
            return this.brand;
        }
    }

    public static int Count
    {
        get
        {
            return Car.count;
        }
    }

    public void Info()
    {
        System.Console.WriteLine("--------------------------");
        System.Console.WriteLine("HP: " + this.hp);
        System.Console.WriteLine("Model: " + this.model);
        System.Console.WriteLine("Brand: " + this.brand);
        System.Console.WriteLine("--------------------------");
    }
}