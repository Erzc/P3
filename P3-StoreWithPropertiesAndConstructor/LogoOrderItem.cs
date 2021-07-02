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
        private bool hasLogo; //added these
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


        //Include the following read-only auto-properties: 
        //A read only decimal for the total price of all items with all options

        //Read-only auto-property:
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






        //this calculates the price of the logo item based on the type of item whether or not it is a graphic or text only logo, number of colors and number of items.
        //Make sure to read the customers’ requirements above carefully and implement their business rules into the Calc() correctly.
        //Instance method..
        private void Calc()
        {
            double baseCost = 0;
            double costPerItemWithText = 0;
            double costPerItemWithLogo = 0;
            double costPerItemWithLogoColors = 0;

            if (itemType == "USB")
            {
                baseCost = 1 * numItems;
            }
            else if (itemType == "Mug")
            {
                baseCost = 3.50 * numItems;
            }
            else if (itemType == "Pen")
            {
                baseCost = 4 * numItems;
            }

            if (text != null)
            {
                costPerItemWithText = .05 * numItems;
            }

            if (hasLogo == true)
            {
                costPerItemWithLogo = .1 * numItems;
            }

            if (numColors > 0)
            {
                costPerItemWithLogoColors = (.03 * numColors) * numItems;
            }

            TotalPrice = baseCost + costPerItemWithText + costPerItemWithLogo + costPerItemWithLogoColors;

        }

        // Each item has a base cost for the item and then a price for the logo. Base prices are:
        // $1.00 for pens, $3.50 for mugs, $4.00 for usb drives. If there is text placed on the object the price is $0.05 per item.
        //Price for the logo are based on the following:
        //•	Graphic Logo: $0.10 per item (pen, mug or usb)
        //•	Color: $0.03 per color per item.





        //A Clear Button resets all the items on the form to the defaults
    }
}
