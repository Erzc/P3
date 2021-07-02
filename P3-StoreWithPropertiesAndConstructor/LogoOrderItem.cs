using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_StoreWithPropertiesAndConstructor
{
    class LogoOrderItem
    {
        //Declare variables
        private bool hasLogo;
        private string itemType;
        private int numColors;
        private int numItems;
        private string text;

        //Properties with backing fields
        public bool HasLogo
        {
            get
            {
                return hasLogo;
            }
            set
            {
                hasLogo = value;
                Calc();
            }
        }

        public string ItemType
        {
            get
            {
                return itemType;
            }
            set
            {
                itemType = value;
                Calc();
            }
        }

        public int NumColors
        {
            get
            {
                return numColors;
            }
            set
            {
                numColors = value;
                Calc();
            }
        }

        public int NumItems
        {
            get
            {
                return numItems;
            }
            set
            {
                numItems = value;
                Calc();
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                Calc();
            }
        }

        //Auto-property
        public int ItemID { get; set; } //added get set


        //Read-only auto-property - decimal for the total price of all items with all options
        public double TotalPrice { get; private set; } //change?



        //Add three constructors to your LogoOrderItem class:


        //1 A constructor that takes six parameters (one for each settable property in the class).
        //In the body of this constructor set each parameter into the appropriate class property or field.

        public LogoOrderItem(bool hasLog, string itemTyp, int numCol, int numItem, string tex, int theID)
        {
            HasLogo = hasLog;
            ItemType = itemTyp;
            NumColors = numCol;
            NumItems = numItem;
            Text = tex;
            ItemID = theID;
        }


        //2 A constructor that takes 2 parameters: a string for text and a bool for has logo. ***Chain this constructor to the six parameter constructor.
        public LogoOrderItem (bool hasLog, string tex)
        {

        }




        //3 A constructor that takes no parameters (a parameterless constructor). Chain this constructor to the six parameter constructor. 
        public LogoOrderItem()
        {

        }





        //Default values for chaining should be:
        //•	itemID: -1
        //•	itemType: “mug”
        //•	numColors: 0
        //•	numItems: 0
        //•	hasLogo: false






        //Instance method calculates the total price of the order
        private void Calc()
        {
            //Declare variables, initializes cost to $0
            double baseCost = 0;
            double costPerItemWithText = 0;
            double costPerItemWithLogo = 0;
            double costPerItemWithLogoColors = 0;

            //$1.00 for pens, $3.50 for mugs, $4.00 for usb drives
            if (itemType == "USB")
            {
                baseCost = 4 * numItems;
            }
            else if (itemType == "Mug")
            {
                baseCost = 3.50 * numItems;
            }
            else if (itemType == "Pen")
            {
                baseCost = 1 * numItems;
            }

            //If text placed on the object, price is $0.05 per item
            if (text != "")
            {
                costPerItemWithText = .05 * numItems;
            }

            //If Graphic Logo, price is $0.10 per item
            if (hasLogo == true)
            {
                costPerItemWithLogo = .1 * numItems;
            }

            //If Graphic Logo and more than 0 colors, $0.03 per color per item
            if (numColors > 0 && hasLogo == true)
            {
                costPerItemWithLogoColors = (.03 * numColors) * numItems;
            }

            TotalPrice = baseCost + costPerItemWithText + costPerItemWithLogo + costPerItemWithLogoColors;
        }
    }
}
