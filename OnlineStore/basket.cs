using System.Collections.Generic;

class Basket: List<Products>
{
    public List<Products> basketList = new List<Products>();

    public void add(Products bl)
    {
        basketList.Add(bl);
    }
    
    public double getTotalPrice()
    {
        double total = 0;

        foreach(Products bl in basketList)
        {
            total += bl.getDefaultPrice();
        }

        return total;

    }
} 