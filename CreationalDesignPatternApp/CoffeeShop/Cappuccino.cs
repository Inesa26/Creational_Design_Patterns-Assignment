using CreationalDesignPatternApp.Enums;
using System.Text;

namespace CreationalDesignPatternApp.CoffeeShop
{
    public class Cappuccino : Coffee
    {
        public override string Name => "Cappuccino";
        public override int CoffeeShots => 1;
        public MilkType MilkType { get; set; }

        private Cappuccino() { }

        public static Cappuccino Create()
        {
            return new Cappuccino();
        }
        public override string? ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Coffee Name: {Name}\nCoffee Type: {CoffeeType}\nCoffee shots: {CoffeeShots}\nMilk Type: {MilkType}");

            if (Customizations.Count > 0)
            {
                result.AppendLine("Customizations:");
                foreach (var customization in Customizations)
                {
                    result.AppendLine($"{customization}");
                }
            }
            else
            {
                result.AppendLine("No customizations.");
            }

            return result.ToString();
        }
    }
}
