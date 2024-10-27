using System;
using System.Collections;
using System.Collections.Generic;

public class CarCollection : IEnumerable<Car>
{
    private List<Car> cars = new List<Car>();

    public void Add(Car car)
    {
        cars.Add(car);
    }

    public IEnumerator<Car> GetEnumerator()
    {
        return cars.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
