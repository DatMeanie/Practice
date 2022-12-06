using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        /////////////////////////////////////////////////////////////////////
        //
        //                    SIMPLE CALCULATOR APP
        //
        // - Addition, Subtraction, Multiplication, Division
        // TODO: More keyboard input
        //
        /////////////////////////////////////////////////////////////////////

        /////////////////////////////////////////////////////////////////////
        // Four different kinds of math
        enum CalculatorMode
        {
            Addition = '+',
            Subtraction = '-',
            Multiply = '*',
            Division = '/'
        }
        CalculatorMode mathMode = CalculatorMode.Addition;

        /////////////////////////////////////////////////////////////////////

        // num1 + num2, num1 - num2, etc. calculation stored in result
        double number1 = 0; 
        double number2 = 0;
        double result = 0;
        
        /////////////////////////////////////////////////////////////////////

        bool useNumber1 = true;

        /////////////////////////////////////////////////////////////////////
        // INITIALIZE
        /////////////////////////////////////////////////////////////////////

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load( object sender, EventArgs e )
        {
            ResultLabel.Text = number1.ToString();
        }

        /////////////////////////////////////////////////////////////////////
        // INPUT
        /////////////////////////////////////////////////////////////////////

        private void Input( char KeyPress )
        {
            /////////////////////////////////////////////////////////////////////
            // DIGITS
            /////////////////////////////////////////////////////////////////////
            
            if ( KeyPress >= 48 && KeyPress <= 57 )
            {
                if ( useNumber1 )
                {
                    /////////////////////////////////////////////////////////////////////
                    // Check if too big of a number

                    number2Label.Text = " ";
                    if ( number1.ToString().Length >= 17 )
                    {
                        ResultLabel.Text = "Error: Out of bounds";
                        number1 = 0;
                        number2 = 0;
                        return;
                    }

                    /////////////////////////////////////////////////////////////////////
                    // Add inputted digit to last of number1

                    string combined = string.Concat( number1, Int32.Parse( KeyPress.ToString() ) );
                    bool err = double.TryParse( combined, out number1 );
                    if ( err == false )
                    {
                        ResultLabel.Text = "Error: Could not convert keyboard input";
                        number2Label.Text = " ";
                    }
                    else
                        ResultLabel.Text = number1.ToString();
                    
                    /////////////////////////////////////////////////////////////////////
                }
                else
                {
                    /////////////////////////////////////////////////////////////////////
                    // Check if too big of a number

                    if ( number2.ToString().Length >= 17 )
                    {
                        ResultLabel.Text = "Error: Out of bounds";
                        number1 = 0;
                        number2 = 0;
                        return;
                    }
                    
                    /////////////////////////////////////////////////////////////////////
                    // Add inputted digit to last of number2

                    string combined = string.Concat( number2, Int32.Parse( KeyPress.ToString() ) );
                    bool err = double.TryParse( combined, out number2 );
                    if ( err == false )
                    {
                        ResultLabel.Text = "Error: Could not convert keyboard input";
                        number2Label.Text = " ";
                    }
                    else
                        number2Label.Text = number1.ToString() + " " + (char)mathMode + " " + number2.ToString();


                    /////////////////////////////////////////////////////////////////////
                }
            }

            /////////////////////////////////////////////////////////////////////
            // TODO: Keyboard input such as enter for equals, + for add, etc
            switch ( KeyPress.ToString() )
            {
                case "Enter":
                    Equals();
                    break;

                default:
                    break;
            }
            
            /////////////////////////////////////////////////////////////////////
        }

        /////////////////////////////////////////////////////////////////////
        // MATH FUNCTIONS
        /////////////////////////////////////////////////////////////////////

        // Calculations using 2 numbers then stored in result
        // Number 1 is set to result to make several calcs after one another
        // Sent back as string mainly for if an error happens and be written to window

        private string Addition()
        {
            result = number1 + number2;
            number1 = result;
            return result.ToString();
        }
        
        /////////////////////////////////////////////////////////////////////

        private string Subtraction()
        {
            result = number1 - number2;
            number1 = result;
            return result.ToString();
        }
        
        /////////////////////////////////////////////////////////////////////

        private string Multiply()
        {
            // Unsure if overflow error can occur. Loops back to infinity if big numbers
            result = number1 * number2;
            number1 = result;
            return result.ToString();
        }
        
        /////////////////////////////////////////////////////////////////////

        private string Division()
        {
            if( number2 == 0 )
            {
                return "Error: Division by zero";
            }
            else
            {
                result = number1 / number2;
                number1 = result;
                return result.ToString();
            }
        }
        
        /////////////////////////////////////////////////////////////////////

        private void NextNumber( CalculatorMode newMode )
        {
            /////////////////////////////////////////////////////////////////////
            // If it's one calculation after another without doing equals first

            if ( useNumber1 == false )
                Equals();

            /////////////////////////////////////////////////////////////////////
            
            mathMode = newMode;

            /////////////////////////////////////////////////////////////////////

            useNumber1 = false;
            number2Label.Text = number1.ToString() + " " + (char)mathMode;
        }
        
        /////////////////////////////////////////////////////////////////////

        private void Equals()
        {
            /////////////////////////////////////////////////////////////////////
            
            switch ( mathMode )
            {
                case CalculatorMode.Addition:
                    ResultLabel.Text = Addition();
                    break;
                case CalculatorMode.Subtraction:
                    ResultLabel.Text = Subtraction();
                    break;
                case CalculatorMode.Multiply:
                    ResultLabel.Text = Multiply();
                    break;
                case CalculatorMode.Division:
                    ResultLabel.Text = Division();
                    break;
                default:
                    break;
            }
            
            /////////////////////////////////////////////////////////////////////

            number2Label.Text = number1.ToString() + " " + (char)mathMode + " " + number2.ToString();
            number2 = 0;
            useNumber1 = true;
        }

        /////////////////////////////////////////////////////////////////////
        // FORM BUTTONS AND KEYPRESSES
        /////////////////////////////////////////////////////////////////////

        void Calculator_KeyPress( object sender, KeyPressEventArgs e )
        {
            Input( e.KeyChar );
        }

        private void AddBtn_Click( object sender, EventArgs e )
        {
            NextNumber( CalculatorMode.Addition );
        }

        private void SubBtn_Click( object sender, EventArgs e )
        {
            NextNumber( CalculatorMode.Subtraction );
        }

        private void MultBtn_Click( object sender, EventArgs e )
        {
            NextNumber( CalculatorMode.Multiply );
        }

        private void DivBtn_Click( object sender, EventArgs e )
        {
            NextNumber( CalculatorMode.Division );
        }

        private void EqualsBtn_Click( object sender, EventArgs e )
        {
            Equals();
        }

        private void Num1Btn_Click( object sender, EventArgs e )
        {
            Input( '1' );
        }

        private void Num2Btn_Click( object sender, EventArgs e )
        {
            Input( '2' );
        }

        private void Num3Btn_Click( object sender, EventArgs e )
        {
            Input( '3' );
        }

        private void Num4Btn_Click( object sender, EventArgs e )
        {
            Input( '4' );
        }

        private void Num5Btn_Click( object sender, EventArgs e )
        {
            Input( '5' );
        }

        private void Num6Btn_Click( object sender, EventArgs e )
        {
            Input( '6' );
        }

        private void Num7Btn_Click( object sender, EventArgs e )
        {
            Input( '7' );

        }

        private void Num8Btn_Click( object sender, EventArgs e )
        {
            Input( '8' );
        }

        private void Num9Btn_Click( object sender, EventArgs e )
        {
            Input( '9' );
        }

        private void Num0Btn_Click( object sender, EventArgs e )
        {
            Input( '0' );
        }
    }
}
