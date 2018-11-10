using System;
using System.Collections.Generic;
using System.Text;

namespace builder.one
{
    public class Sandwich
    {
        private BreadType breadType;
        private Boolean isToasted;
        private CheeseType cheeseType;
        private MeatType meatType;
        private Boolean hasMustard;
        private Boolean hasMayo;
        private List<String> vegetables;

        public BreadType getBreadType()
        {
            return breadType;
        }

        public void setBreadType(BreadType breadType)
        {
            this.breadType = breadType;
        }

        public Boolean IsToasted()
        {
            return isToasted;
        }

        public void setToasted(Boolean isToasted)
        {
            this.isToasted = isToasted;
        }

        public CheeseType getCheeseType()
        {
            return cheeseType;
        }

        public void setCheeseType(CheeseType cheeseType)
        {
            this.cheeseType = cheeseType;
        }

        public MeatType getMeatType()
        {
            return meatType;
        }

        public void setMeatType(MeatType meatType)
        {
            this.meatType = meatType;
        }

        public Boolean isHasMustard()
        {
            return hasMustard;
        }

        public void setHasMustard(Boolean hasMustard)
        {
            this.hasMustard = hasMustard;
        }

        public Boolean isHasMayo()
        {
            return hasMayo;
        }

        public void setHasMayo(Boolean hasMayo)
        {
            this.hasMayo = hasMayo;
        }

        public List<String> getVegetables()
        {
            return vegetables;
        }

        public void setVegetables(List<String> vegetables)
        {
            this.vegetables = vegetables;
        }

        public void display()
        {
            Console.WriteLine("Sandwich on " + breadType + "bread" );
            if (isToasted)
            {
                Console.WriteLine("Toasted");
            }
            if (hasMayo)
            {
                Console.WriteLine("With Mayo");
            }
            if (hasMustard)
            {
                Console.WriteLine("With Mustard");
            }
            Console.WriteLine("Meat: " + meatType);
            Console.WriteLine("Cheese: " + cheeseType);
            Console.WriteLine("Veggies: ");
            foreach (String vegetable in vegetables)
            {
                Console.WriteLine(vegetable);
            }
            Console.WriteLine("******************************");
        }
    }
}
