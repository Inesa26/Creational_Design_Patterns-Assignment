using CreationalDesignPatternApp.CoffeeShop;
using CreationalDesignPatternApp.Enums;

namespace CreationalDesignPatternApp.Factory
{
    public class CappuccinoCoffeeFactory : CoffeeFactory
    {

        public override Coffee MakeCoffee(MilkType? milkType = null)
        {
            if (milkType is null)
            {
                throw new ArgumentNullException("Milk must be provided for Cappuccino");
            }

            Cappuccino cappuccino = Cappuccino.Create();
            cappuccino.CoffeeType = CoffeeType.Black;
            cappuccino.MilkType = milkType.Value;
            return cappuccino;
        }
    }
}
