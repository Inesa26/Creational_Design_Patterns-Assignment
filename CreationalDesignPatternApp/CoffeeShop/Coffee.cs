using CreationalDesignPatternApp.Customization;
using CreationalDesignPatternApp.Enums;

namespace CreationalDesignPatternApp.CoffeeShop
{
    public abstract class Coffee
    {
        public abstract string Name { get; }
        public CoffeeType CoffeeType { get; set; }
        public abstract int CoffeeShots { get; }

        public List<ICustomization> Customizations { get; }

        public Coffee()
        {
            Customizations = new List<ICustomization>();
        }

        public void AddSugar(SugarType sugarType, int quantity)
        {
            Customizations.Add(new SugarCustomization(sugarType, quantity));
        }

        public void AddMilk(MilkType milkType, int quantity)
        {
            Customizations.Add(new MilkCustomization(milkType, quantity));
        }



    }
}
