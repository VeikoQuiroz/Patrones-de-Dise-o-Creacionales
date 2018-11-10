using System;
using System.Collections.Generic;

namespace builder.one
{
    class ClubSandwichBuilder : SandwichBuilder
    {
        public override void addCondiments()
        {
            sandwich.setHasMayo(true);
            sandwich.setHasMustard(true);
        }

        public override void applyMeatAndCheese()
        {
            sandwich.setCheeseType(CheeseType.Swiss);
            sandwich.setMeatType(MeatType.Turkey);
        }

        public override void applyVegetables()
        {
            sandwich.setVegetables(new List<String> { "Tomato", "Onion", "Lettuce" });
        }

        public override void prepareBread()
        {
            sandwich.setBreadType(BreadType.White);
            sandwich.setToasted(true);
        }
    }
}
