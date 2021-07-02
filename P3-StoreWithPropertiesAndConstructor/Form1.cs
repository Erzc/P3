using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_StoreWithPropertiesAndConstructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Submit Button will do the following:
        //1. >>>Instantiate a LogoOrderItem using the two parameter constructor.
        //Use the Text to Engrave TextBox.Text and Logo Checkbox.Checked for the two arguments needed for the constructor.
        //2.	Read the values of the remaining items on the form and set the appropriate properties in your LogoOrderItem.
        //3.	If there is no logo, do not charge the customer for any colors.
        //This could be handled a number of ways, either in Calc() method or by making sure the Number of colors is
        //set to 0 if Logo is not checked.
        //4.	Once all properties in the LogoOrderItem are set, set the Results TextBox.Text to the return value of calling GetOrderSummary().
        //5.	Wrap the submit button code in a try/catch block.
        //Catch the Exception class.
        //Display the error message to the results text box if the user fails to input correct values.

        private void submitButton_Click(object sender, EventArgs e)
        {
            LogoOrderItem newLogoOrderItem = BuildLogoOrderItem();
            string summary = GetOrderSummary(newLogoOrderItem);
            resultsTextBox.Text = summary;
        }

        private LogoOrderItem BuildLogoOrderItem()
        {
            LogoOrderItem newLogoOrderItem = new LogoOrderItem();

            //Converts string to int so it can be returned
            int orderNumberTextBoxInt = Convert.ToInt32(orderNumberTextBox.Text);
            int numberOfItemsTextBoxInt = Convert.ToInt32(orderNumberTextBox.Text);
            int numberOfColorsTextBoxInt = Convert.ToInt32(orderNumberTextBox.Text);

            newLogoOrderItem.ItemID = orderNumberTextBoxInt; //was "orderNumberTextBox.Text"
            newLogoOrderItem.NumItems = numberOfItemsTextBoxInt;
            newLogoOrderItem.NumColors = numberOfColorsTextBoxInt;
            newLogoOrderItem.Text = textToEngraveTextBox.Text;

            //Property access calls this method and returns appropriate value
            newLogoOrderItem.ItemType = this.SelectedItemType;

            //Sets logo true/false
            newLogoOrderItem.HasLogo = this.SelectedLogo;


            return newLogoOrderItem;
        }

        //Uses the member variables to return formatted string
        private string GetOrderSummary(LogoOrderItem newLogoOrderItem)
        {
            string summary =
                "Order number: " + newLogoOrderItem.ItemID +
                "\r\nNumber of items: " + newLogoOrderItem.NumItems +
                "\r\nItem type: " + newLogoOrderItem.ItemType +
                "\r\nText to engrave/print: " + newLogoOrderItem.Text +
                "\r\nLogo: " + newLogoOrderItem.HasLogo +
                "\r\nNumber of colors: " + newLogoOrderItem.NumColors +
                "\r\nTotal price of all items: " + newLogoOrderItem.TotalPrice;
                //A read only decimal for the total price of all items with all options


            return summary;
        }

        //To get selected item (in groupbox)
        private string SelectedItemType
        {
            get
            {
                if (usbRadioButton.Checked)
                {
                    return "USB";
                }
                else if (mugRadioButton.Checked)
                {
                    return "Mug";
                }
                else if (penRadioButton.Checked)
                {
                    return "Pen";
                }
                else
                {
                    return "Undeclared";
                }

            }
        }

        //To get true/false value for logo checkbox
        private bool SelectedLogo
        {
            get
            {
                if (logoCheckBox.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Sets label and textbox for number of colors to only be visible when Logo is checked
        private void logoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            numberOfColorsLabel.Visible = logoCheckBox.Checked;
            numberOfColorsTextBox.Visible = logoCheckBox.Checked;
        }
    }
}
