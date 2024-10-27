using System;

public class Car
{
    private int hp;
    private string brand;

    public int Hp
    {
        set
        {
            if (value < 50)
            {
                throw new ArgumentOutOfRangeException("INVALID HP!");
            }
            hp = value; 
        }
        get
        {
            return hp;
        }
    }

    public string Brand
    {
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentOutOfRangeException("INVALID BRAND!");
            }
            brand = value; 
        }
        get
        {
            return brand;
        }
    }

    public Car(int hp, string brand)
    {
        this.Hp = hp;
        this.Brand = brand;
    }

    public static bool operator ==(Car c1, Car c2)
    {
        return c1.Hp == c2.Hp && c1.Brand == c2.Brand;
    }

    public static Car operator +(Car c1, Car c2)
    {
        Car newCar = new Car(c1.Hp + c2.Hp, c1.Brand);
        return newCar;
    }

    public static bool operator !=(Car c1, Car c2)
    {
        return !(c1 == c2);
    }

     public override string ToString()
    {
        return "HP: " + this.Hp + " BRAND: " + this.Brand;
    }
}
