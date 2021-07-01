using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_StoreWithPropertiesAndConstructor
{
    class LogoOrderItem
    {
        //properties with backing fields:

        public bool HasLogo;
        public string ItemType;
        public int NumColors;
        public int NumItems;
        public string Text;


        //auto-property:
        public int ItemID;
        //A read only decimal for the total price of all items with all options


        //Default values for chaining should be:

        //1 A constructor that takes six parameters (one for each settable property in the class).
        //In the body of this constructor set each parameter into the appropriate class property or field.

        //2 A constructor that takes 2 parameters: a string for text and a bool for has logo. Chain this constructor to the six parameter constructor.

        //3 A constructor that takes no parameters (a parameterless constructor). Chain this constructor to the six parameter constructor. 


        //this calculates the price of the logo item based on the type of item whether or not it is a graphic or text only logo, number of colors and number of items.
        //Make sure to read the customers’ requirements above carefully and implement their business rules into the Calc() correctly.
        private void Calc()
        {
        }



        public string GetOrderSummary()
        {
            //Use the member variables to return a nicely formatted string like:
            //Order num 1: 20 mugs with 3 color logo with the following text: C# is a great language! Price: $74.80


            //return stuff
        }



        //DO THIS: Submit Button will do the following:
        //1. Instantiate a LogoOrderItem using the two parameter constructor.
                    //Use the Text to Engrave TextBox.Text and Logo Checkbox.Checked for the two arguments needed for the constructor.
        //2.	Read the values of the remaining items on the form and set the appropriate properties in your LogoOrderItem.
        //3.	If there is no logo, do not charge the customer for any colors.
                    //This could be handled a number of ways, either in Calc() method or by making sure the Number of colors is
                    //set to 0 if Logo is not checked.
        //4.	Once all properties in the LogoOrderItem are set, set the Results TextBox.Text to the return value of calling GetOrderSummary().
        //5.	Wrap the submit button code in a try/catch block.
                    //Catch the Exception class.
                    //Display the error message to the results text box if the user fails to input correct values.



        //A Clear Button resets all the items on the form to the defaults.



        //DO THIS: Set label and textbox for number of colors to only be visible when Logo is checked.
        //To do this, handle the CheckBox.CheckedChanged event to set the Visibility properties for the Label and Checkbox.
}
}
