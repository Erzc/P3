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

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Try catch block for exception handling
            try
            {
                //Instantiates a new instance of the LogoOrderItem class
                LogoOrderItem newLogoOrderItem = BuildLogoOrderItem();

                //Uses textToEngraveTextBox.Text and SelectedLogo for the two arguments needed for the constructor
                newLogoOrderItem.HasLogo = this.SelectedLogo; //Sets logo true/false
                newLogoOrderItem.Text = textToEngraveTextBox.Text;

                //Sets the resultsTextBox.Text to the return value of calling GetOrderSummary() [summary]
                string summary = GetOrderSummary(newLogoOrderItem);
                resultsTextBox.Text = summary;
            }

            //Catches format/type that is not valid for conversion
            catch (System.FormatException)
            {
                resultsTextBox.Text = "Error! Incorrect format.";
            }

            //Catches unexpectedly deep recursion
            catch (System.OverflowException)
            {
                resultsTextBox.Text = "Error! Value is either too small or too large.";
            }

            //Catches all other exceptions thrown and writes type
            catch (System.Exception exc)
            {
                resultsTextBox.Text = "Error! " + exc.Message + "\nException type: " + exc.GetType();
            }
        }

        private LogoOrderItem BuildLogoOrderItem()
        {
            LogoOrderItem newLogoOrderItem = new LogoOrderItem();

            //If text box not empty, converts string to int so it can be returned. Many format errors without this!
            if (orderNumberTextBox.Text != "")
            {
                int orderNumberTextBoxInt = Convert.ToInt32(orderNumberTextBox.Text);
                newLogoOrderItem.ItemID = orderNumberTextBoxInt;
            }
            if (numberOfItemsTextBox.Text != "")
            {
                int numberOfItemsTextBoxInt = Convert.ToInt32(numberOfItemsTextBox.Text);
                newLogoOrderItem.NumItems = numberOfItemsTextBoxInt;
            }
            if (numberOfColorsTextBox.Text != "")
            {
                int numberOfColorsTextBoxInt = Convert.ToInt32(numberOfColorsTextBox.Text);
                newLogoOrderItem.NumColors = numberOfColorsTextBoxInt;
            }

            //Property access calls this method and returns appropriate value
            newLogoOrderItem.ItemType = this.SelectedItemType;

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

        //Clear Button resets all the items on the form -- this is a little buggy.. -E
        private void clearButton_Click(object sender, EventArgs e)
        {
            orderNumberTextBox.Text = "";
            numberOfItemsTextBox.Text = "";
            numberOfColorsTextBox.Text = "";
            textToEngraveTextBox.Text = "";
            mugRadioButton.Checked = true;
            logoCheckBox.Checked = false;
            resultsTextBox.Text = "";
        }
    }
}