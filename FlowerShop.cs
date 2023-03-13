
namespace FlowerShop
{
    using System.Collections.Generic;

    public class FlowerShopModel
     {
        public List<Rose> Roses { get; set; } = new List<Rose>();
        public List<Lilly> lillies { get; set; } = new List<Lilly>();
        public List<Marigold> marigolds { get; set; } = new List<Marigold>();
        public List<Sunflower> sunflowers { get; set; } = new List<Sunflower>();

public List<IMothersDay> MothersDayArrangement()
{
         List<IMothersDay> arrangement = new List<IMothersDay>()
        {
            new Rose() { StemLength = 5.35 },
            new Lilly() { StemLength = 7.87 },
            new Marigold() { StemLength = 6.87 },
            new Sunflower() { StemLength = 9.87 }
        };

        return arrangement;
}

public List<IBirthday> BirthdayArrangement()
      {
         List<IBirthday> arrangement = new List<IBirthday>()
        {
                new Rose() { Color = "Blue & White" },
                new Rose() { Color = "Red & White" },
                new Rose() { Color = "Blue & White" },
                new Marigold() { Color = "Purple & White"},
                new Marigold() { Color = "White" },
        };
        return arrangement;
      }
   }
}


// Choose the two flowers you want to be in the Mother's Day
//  arrangement and make sure both have a StemLength property. 
//  Any flower, even in the future, needs to have a stem length of 5 inches.
//   This means that the StemLength property must exist on those flowers. 
//   It can optional on other flowers.


// The other two flowers will be in the birthday arrangement.
//  Flowers in the birthday arrangement will always have some white in them. 
//  That means that the Color property must be on flowers for that arrangement. 
//  It can be optional on other flower