using CreationalDesignPatternApp.Enums;

namespace CreationalDesignPatternApp.Customization
{
    public class MilkCustomization : ICustomization
    {
        public MilkType MilkType { get; set; }
        public int Quantity { get; set; }

        public MilkCustomization(MilkType milkType, int quantity)
        {
            MilkType = milkType;
            Quantity = quantity;
        }

        public override string? ToString()
        {
            return $"Sugar: {MilkType} - (quantity: {Quantity})";
        }
    }
}
