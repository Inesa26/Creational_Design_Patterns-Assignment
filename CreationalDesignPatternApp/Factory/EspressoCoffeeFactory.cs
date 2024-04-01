using CreationalDesignPatternApp.CoffeeShop;
using CreationalDesignPatternApp.Enums;

namespace CreationalDesignPatternApp.Factory
{
    public class EspressoCoffeeFactory : CoffeeFactory
    {
        public override Coffee MakeCoffee(MilkType? milkType = null)
        {
            Espresso coffee = Espresso.Create();
            coffee.CoffeeType = CoffeeType.Black;
            return coffee;
        }
    }
}
