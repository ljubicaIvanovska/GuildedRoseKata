using NUnit.Framework;
using System.Collections.Generic;
using csharp.Constants;

namespace csharp
{
    [TestFixture]
    public class ConjuredShould
    {
        [Test]
        public void ConjuredShouldShouldDecradeTwiceFaster()
        {
            int quality = 7;
            IList<Item> items = new List<Item> { new Item { Name = ItemName.Conjured, 
                                                            SellIn = 10, 
                                                            Quality = quality } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(quality-2, items[0].Quality);
        }
        [Test]
        public void ConjuredItemQualityShouldBeMax50()
        {
            int quality = 50;
            IList<Item> items = new List<Item> { new Item { Name = "Laundry Soap",
                                                            SellIn = 10,
                                                            Quality = quality } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(quality, items[0].Quality);
        }
        [Test]
        public void ConjuredItemQualityShouldNotBeNegative()
        {
            int quality = -1;
            IList<Item> items = new List<Item> { new Item { Name = "Soap",
                                                            SellIn = 10,
                                                            Quality = quality } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
        }
    }
}
