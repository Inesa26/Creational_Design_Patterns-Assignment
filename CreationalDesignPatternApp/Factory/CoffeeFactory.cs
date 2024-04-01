using CreationalDesignPatternApp.CoffeeShop;
using CreationalDesignPatternApp.Enums;

namespace CreationalDesignPatternApp.Factory
{
    public abstract class CoffeeFactory
    {
        public abstract Coffee MakeCoffee(MilkType? milkType = null);
    }
}
