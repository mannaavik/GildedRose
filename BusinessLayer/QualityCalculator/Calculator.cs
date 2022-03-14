
namespace csharp.BusinessLayer
{
    public class Calculator
    {
        IGildedRose guildedRose;

        public Calculator(IGildedRose guildedRose)
        {
            this.guildedRose = guildedRose;
        }

        public void UpdateQuality()
        {
            guildedRose.UpdateQuality();
        }
    }
}
