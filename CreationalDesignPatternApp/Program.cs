using CreationalDesignPatternApp.CoffeeShop;
using CreationalDesignPatternApp.Enums;
using CreationalDesignPatternApp.Factory;


namespace CreationalDesignPatternApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeFactory espressoFactory = new EspressoCoffeeFactory();
            Coffee espresso = espressoFactory.MakeCoffee();
            espresso.AddSugar(SugarType.White, 1);
            Console.WriteLine(espresso);

            CoffeeFactory cappuccinoFactory = new CappuccinoCoffeeFactory();
            Coffee cappuccino = cappuccinoFactory.MakeCoffee(MilkType.Regular);
            Console.WriteLine(cappuccino);

            CoffeeFactory flatWhiteFactory = new FlatWhiteCoffeeFactory();
            Coffee flatWhite = flatWhiteFactory.MakeCoffee(MilkType.Oat);
            flatWhite.AddMilk(MilkType.Oat, 1);
            Console.WriteLine(flatWhite);
        }
    }
}
