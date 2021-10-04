using System;


namespace HelloWorldApplication 
{
   class Program 
   {
      static void Main(string[] args)
      {     
            TShirts tshirt = new TShirts();
            tshirt.name = "DC Comics";
            tshirt.size = "m";

            Golfer golfer = new Golfer();
            golfer.name = "Polo";
            golfer.size = "l";

            Jeans jean = new Jeans();
            jean.name = "Redbat";
            jean.size = "s";

            FormalPants formalPants = new FormalPants();
            formalPants.name = "Chino";
            formalPants.size = "m";

            Basket basket = new Basket();
            
            basket.add(tshirt);
            basket.add(golfer);
            basket.add(jean);
            basket.add(formalPants);

            Console.WriteLine($"Your total price is {basket.getTotalPrice()}");

        }
}
}