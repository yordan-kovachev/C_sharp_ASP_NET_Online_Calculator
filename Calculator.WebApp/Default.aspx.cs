using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Calculator.WebApp
{
    public partial class _Default : Page
    {

        double value1, value2, value3, value4, value5, value6, value7, value8 = 0;
        bool operatorPressed = false;

        protected void buttonNumber_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0" || operatorPressed == true)
            {
                resultTextBox.Text = ""; ;
            }
            operatorPressed = false;
            Button button = (Button)sender;
            resultTextBox.Text += button.Text;
        }

        protected void buttonPeriod_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!resultTextBox.Text.Contains("."))
            {
                resultTextBox.Text += button.Text;
            }
            else if (resultTextBox.Text =="")
            {
                resultTextBox.Text = "0" + button.Text;
            }
        }

        bool plus, minus, multiply, divide = false;
        protected void buttonPlus_Click(object sender, EventArgs e)
        {
            plus = true;
            value1 = value1 + double.Parse(resultTextBox.Text);
            ViewState["value1"] = value1;
            resultTextBox.Text = "";
            ViewState["plus"] = plus;
            if (plus == true)
            {
                entryStatusLabel.Text = value1.ToString() + " +";
            }
        }

        protected void buttonMinus_Click(object sender, EventArgs e)
        {
            minus = true;
            value3 = value3 + double.Parse(resultTextBox.Text);
            ViewState["value3"] = value3;
            resultTextBox.Text = "";
            entryStatusLabel.Text = resultTextBox.Text + value3.ToString();
            ViewState["minus"] = minus;
            if (minus == true)
            {
                entryStatusLabel.Text = value3.ToString() + " -";
            }
        }

        protected void buttonMultiply_Click(object sender, EventArgs e)
        {
            multiply = true;
            value5 = value5 + double.Parse(resultTextBox.Text);
            ViewState["value5"] = value5;
            resultTextBox.Text = "";
            entryStatusLabel.Text = resultTextBox.Text + value5.ToString();
            ViewState["multiply"] = multiply;
            if (multiply == true)
            {
                entryStatusLabel.Text = value5.ToString() + " x";
            }
        }

        protected void buttonDivide_Click(object sender, EventArgs e)
        {
            divide = true;
            value7 = value7 + double.Parse(resultTextBox.Text);
            ViewState["value7"] = value7;
            resultTextBox.Text = "";
            entryStatusLabel.Text = resultTextBox.Text + value7.ToString();
            ViewState["divide"] = divide;
            if (divide == true)
            {
                entryStatusLabel.Text = value7.ToString() + " /";
            }
        }

        protected void buttonEquals_Click(object sender, EventArgs e)
        {
            if(plus = Convert.ToBoolean(ViewState["plus"]))
            {
                value2 = double.Parse((ViewState["value1"]).ToString()) + double.Parse(resultTextBox.Text);
                resultTextBox.Text = value2.ToString();
                value1 = 0;
                entryStatusLabel.Text = "";
                ViewState["plus"] = false;
                
            }
            else if (minus = Convert.ToBoolean(ViewState["minus"]))
            {
                value4 = double.Parse((ViewState["value3"]).ToString()) - double.Parse(resultTextBox.Text);
                resultTextBox.Text = value4.ToString();
                value3 = 0;
                entryStatusLabel.Text = "";
                ViewState["minus"] = false;

            }
            else if (multiply = Convert.ToBoolean(ViewState["multiply"]))
            {
                value6 = double.Parse((ViewState["value5"]).ToString()) * double.Parse(resultTextBox.Text);
                resultTextBox.Text = value6.ToString();
                value5 = 0;
                entryStatusLabel.Text = "";
                ViewState["miltiply"] = false;

            }
            else if (divide = Convert.ToBoolean(ViewState["divide"]))
            {
                value8 = double.Parse((ViewState["value7"]).ToString()) / double.Parse(resultTextBox.Text);
                resultTextBox.Text = value8.ToString();
                value7 = 0;
                entryStatusLabel.Text = "";
                ViewState["divide"] = false;
            }
        }
        
        protected void buttonClear_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            entryStatusLabel.Text = "";
        }

        protected void buttonDelete_Click(object sender, EventArgs e)
        {
            if(resultTextBox.Text != null)
                try
                {
                    string resultText = resultTextBox.Text;
                    int LastIndex = resultText.Length;
                    resultTextBox.Text = resultTextBox.Text.Remove(LastIndex - 1);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Page.ClientScript.RegisterStartupScript
                        (this.GetType(), "alert", "alert('Field is cleared! Press OK button to continue with new calculation.');", true);
                }
            
        }

        protected void buttonNegative_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            if (!resultTextBox.Text.Contains("-"))
            {
                resultTextBox.Text = button.Text + resultTextBox.Text;
            }
        }

        protected void bottonPercentage_Click(object sender, EventArgs e)
        {
            
            Double currentPercent = Double.Parse(resultTextBox.Text);
            Double percentageGross = currentPercent * 0.01;
            resultTextBox.Text = percentageGross.ToString();
            
          
            //            Double fullNumber = Double.Parse(entryStatusLabel.Text);
            //            Double percentageOut = fullNumber * percentageGross;
            //            resultTextBox.Text = percentageOut.ToString();
            //       
       }

        protected void Page_Load(object sender, EventArgs e)
        {
        
        }
    }
}