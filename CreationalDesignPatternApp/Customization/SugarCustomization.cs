using CreationalDesignPatternApp.Enums;

namespace CreationalDesignPatternApp.Customization
{
    public class SugarCustomization : ICustomization
    {
        public SugarType SugarType { get; set; }
        public int Quantity { get; set; }

        public SugarCustomization(SugarType sugarType, int quantity)
        {
            SugarType = sugarType;
            Quantity = quantity;
        }

        public override string? ToString()
        {
            return $"Sugar: {SugarType} - (quantity: {Quantity})";
        }
    }
}
