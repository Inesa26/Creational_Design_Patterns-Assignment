using CreationalDesignPatternApp.Enums;
using System.Text;

namespace CreationalDesignPatternApp.CoffeeShop
{
    public class FlatWhite : Coffee
    {
        public override string Name => "FlatWhite";
        public override int CoffeeShots => 2;
        public MilkType MilkType { get; set; }


        private FlatWhite() { }

        public static FlatWhite Create()
        {
            return new FlatWhite();
        }

        public override string? ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Coffee Name: {Name}\nCoffee Type: {CoffeeType}\nMilk Type: {MilkType}");

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
