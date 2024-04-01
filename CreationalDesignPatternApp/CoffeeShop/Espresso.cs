using System.Text;

namespace CreationalDesignPatternApp.CoffeeShop
{
    public class Espresso : Coffee
    {
        public override string Name => "Espresso";

        public override int CoffeeShots => 1;

        private Espresso() { }

        public static Espresso Create()
        {
            return new Espresso();
        }
        public override string? ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Coffee Name: {Name}\nCoffee Type: {CoffeeType}");

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
