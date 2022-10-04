using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Linq.Expressions;

//Sofia Sanchez Rivera, 4 October 2022
//Create a cash register of Dunkin Donuts

namespace cashRegister
{
    public partial class Form1 : Form
    {
        //create global variables
        SoundPlayer printer = new SoundPlayer(Properties.Resources.Printer);
        SoundPlayer error =new SoundPlayer(Properties.Resources.Error);
        SoundPlayer cash =new SoundPlayer(Properties.Resources.Cash);
        SoundPlayer neworder = new SoundPlayer(Properties.Resources.Neworder);

        double coffeePrice = 2;
        double donutPrice = 1.50;
        double cookiePrice = 2;
        double coffeeAmount = 0;
        double donutAmount = 0;
        double cookieAmount = 0;
        double totalCost = 0;
        double taxRate = 0.13;
        double subTotal = 0;
        double tax = 0;
        double tenderedAmount = 0;
        double change = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void receiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                neworderbutton.Enabled = true;

                printer.Play();

                //prints items to the receipt
                titlereceiptLabel.Text = $"DUNKIN DONUTS";
                Refresh();
                Thread.Sleep(500);
                receiptLabel.Text += $"\n\n               Número de pedido 24178494";
                Refresh();
                Thread.Sleep(500);
                receiptLabel.Text += $"\n                          Octubre 4, 2022\n";
                Refresh();
                Thread.Sleep(500);

                if (coffeeAmount > 0)
                {
                    Refresh();
                    Thread.Sleep(500);
                    receiptLabel.Text += $"\n   café                                                     x{coffeeAmount} @ 2€";
                }

                if (donutAmount > 0)
                {
                    Refresh();
                    Thread.Sleep(500);
                    receiptLabel.Text += $"\n   donut                                           x{donutAmount} @ 1.50€";
                }

                if (cookieAmount > 0)
                {
                    Refresh();
                    Thread.Sleep(500);
                    receiptLabel.Text += $"\n   galleta                                               x{cookieAmount} @ 2€";
                }

                receiptLabel.Text += $"\n\n   SubTotal                                              {subTotal.ToString("c")}";
                Refresh();
                Thread.Sleep(500);
                receiptLabel.Text += $"\n   Tax                                                        {tax.ToString("c")}";
                Refresh();
                Thread.Sleep(500);
                receiptLabel.Text += $"\n   Coste total                                           {totalCost.ToString("c")}";
                Refresh();
                Thread.Sleep(500);
                receiptLabel.Text += $"\n\n   Licitado                                             {tenderedAmount.ToString("c")}";
                Refresh();
                Thread.Sleep(500);
                receiptLabel.Text += $"\n\n   Cambio                                                {change.ToString("c")}";
                Refresh();
                Thread.Sleep(500);
                receiptLabel.Text += $"\n\n\n\n\n\n\n           ¡Muchas gracias por su compra!";
                Refresh();
                Thread.Sleep(500);

                neworderbutton.Enabled = true;
            }
            catch 
            {
                //error handling
                error.Play();
                receiptLabel.BackColor = Color.Red;
                receiptLabel.Text = $"Error";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.BackColor = Color.White;
                receiptLabel.Text = "";
            }
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            try
            {
                tenderedAmount = Convert.ToDouble(tenderedInput.Text);

                if (tenderedAmount >= totalCost)
                {
                    cash.Play();

                    //Calculate the change
                    change = tenderedAmount - totalCost;
                    changeOutput.Text = $"{change.ToString("c")}";

                    receiptButton.Enabled = true;
                }
                else
                {
                    //error handling
                    error.Play();
                    receiptLabel.BackColor = Color.Red;
                    receiptLabel.Text = "Insuficiente cantidad de dinero";
                    Refresh();
                    Thread.Sleep(1000);
                    receiptLabel.BackColor = Color.White;
                    receiptLabel.Text = "";
                }
            }
            catch 
            {
                //error handling
                error.Play();
                receiptLabel.BackColor = Color.Red;
                receiptLabel.Text = $"Error";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.BackColor = Color.White;
                receiptLabel.Text = "";
            }
        }

        private void totalsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                cash.Play();
                //receiptButton.Enabled = true;
                changebutton.Enabled = true;
                coffeeAmount = Convert.ToDouble(coffeeInput.Text);
                donutAmount = Convert.ToDouble(donutsInput.Text);
                cookieAmount = Convert.ToDouble(cookiesInput.Text);

                //do calculations
                subTotal = coffeeAmount * coffeePrice + donutAmount * donutPrice + cookieAmount * cookiePrice;
                tax = subTotal * taxRate;
                totalCost = subTotal + tax;

                //show outputs
                subTotalOutput.Text = $"{subTotal.ToString("c")}";
                taxOutput.Text = $"{tax.ToString("c")}";
                totalOutput.Text = $"{totalCost.ToString("c")}";
            }
            catch
            {
                //error handling
                error.Play();
                receiptLabel.BackColor = Color.Red;
                receiptLabel.Text = $"Error";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.BackColor = Color.White;
                receiptLabel.Text = "";
            }
        }

        private void neworderbutton_Click(object sender, EventArgs e)
        {
            try
            {
                neworder.Play();
                changebutton.Enabled = false;
                neworderbutton.Enabled = false;
                receiptButton.Enabled = false;

                //clear the labels
                subTotalOutput.Text = "";
                taxOutput.Text = "";
                totalOutput.Text = "";
                changeOutput.Text = "";
                receiptLabel.Text = "";
                titlereceiptLabel.Text = "";
                coffeeInput.Text = "";
                donutsInput.Text = "";
                cookiesInput.Text = "";
                tenderedInput.Text = "";
            }
            catch
            {
                //error handling
                error.Play();
                receiptLabel.BackColor = Color.Red;
                receiptLabel.Text = $"Error";
                Refresh();
                Thread.Sleep(1000);
                receiptLabel.BackColor = Color.White;
                receiptLabel.Text = "";
            }
        }
    }
    }
