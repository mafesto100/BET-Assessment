class Pants: Products
{
    public string name;
    public string size;

    public override double getDefaultPrice()
    {   
        double price = 0;

        if(size == "s" || size == "S")
            price =  10;
        else if(size == "m" || size == "M")
            price =  20;
        else if(size == "l" || size == "L");
            price =  30;
        
        return price;
    }
}