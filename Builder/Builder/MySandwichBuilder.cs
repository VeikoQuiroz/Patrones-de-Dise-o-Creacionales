using System;
using System.Collections.Generic;
using System.Text;

namespace builder.one
{
    class MySandwichBuilder : SandwichBuilder
    {
        public override void addCondiments()
        {
            sandwich.setHasMayo(false);
            sandwich.setHasMustard(true);
        }

        public override void applyMeatAndCheese()
        {
            sandwich.setCheeseType(CheeseType.Cheddar);
            sandwich.setMeatType(MeatType.Chicken);
        }

        public override void applyVegetables()
        {
            sandwich.setVegetables(new List<String> {"Tomato", "Onion"});
        }

        public override void prepareBread()
        {
            sandwich.setBreadType(BreadType.White);
            sandwich.setToasted(true);
        }
    }
}
