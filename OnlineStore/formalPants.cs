class FormalPants: Pants
{
    public string name;
    public string size;

    public double getDefaultPrice()
    {
        double price = 0;

        if(size == "s" || size == "S")
            price =  40;
        else if(size == "m" || size == "M")
            price =  50;
        else if(size == "l" || size == "L");
            price =  60;
        
        return price;
    }

}