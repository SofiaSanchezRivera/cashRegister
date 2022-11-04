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
using System.IO;

//Sofia Sanchez Rivera
//4 October 2022
//Create a cash register of Dunkin Donuts

namespace cashRegister
{
    public partial class Form1 : Form
    {
        // Create global variables
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

        // Funtionality to manage the order number increasing receipt by receipt
        // To invoke the function uses: orderNumberString = orderNumberControl("OrderNumber.txt", "C:\\OrderNumber");

        // Declare order number counter
        int orderNumber = 0;
        string orderNumberString = "0";

        // Procedure order number control record, recording in a text file
        private static void orderNumberControlRecord(string orderNumberString, string filePath)
        {
            // Create the file to write the order number 
            using (StreamWriter sw = File.CreateText(filePath))
            {
                // Write the order number
                sw.WriteLine(orderNumberString);
                // Close the text file
                sw.Close();
            }
        }

        // Function order number control read, reading from a text file and return the order number value
        private static string orderNumberControlRead(string filePath)
        {
            // Read from the file the order number 
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Read the order number
                return sr.ReadLine();
            }
        }

        // Function order number control
        private static string myOrderNumberControl(string fileOrderNumber, string directoryOrderNumber)

        {
            string pathFileOrderNumber = directoryOrderNumber + "\\" + fileOrderNumber;
            int orderNumberNext = 0;
            string orderNumberNextString = "0";

            // If don´t exists the directory we need to create first
            if (!Directory.Exists(directoryOrderNumber))
            {
                // Create the directory where we will put the receips file
                Directory.CreateDirectory(directoryOrderNumber);
            }

            // If don´t exists the file we need to create and the order number will be increase
            if (!File.Exists(pathFileOrderNumber))
            {
                // Increase order number
                orderNumberNext = orderNumberNext + 1;
                // Invoke the procedure to create the file to write the order number
                orderNumberControlRecord(orderNumberNext.ToString(), pathFileOrderNumber);
                // Return the function value
                return orderNumberNext.ToString();
            }
            else // The file exists
            {
                // Order number will be the next to the value in the file 
                // Read order number from the file and increase
                orderNumberNextString = orderNumberControlRead(pathFileOrderNumber);
                orderNumberNext = Int32.Parse(orderNumberNextString) + 1;
                orderNumberNextString = orderNumberNext.ToString();
                // Record the new order number into the file
                orderNumberControlRecord(orderNumberNextString, pathFileOrderNumber);
                // Return the function value
                return orderNumberNextString;
            }
        }

        // Funtionality to record the receipt into a text file to contability control
        // To invoke the procedure uses: recordReceipt();

        // Procedure that record the registers of information in a text file C:\Receipts\Receipts.txt
        private void recordReceipt()
        {
            // Declare path: directory and file 
            string directory = "C:\\Receipts";
            string txtReceiptsFile = "Receipts.txt";
            string path = directory + "\\" + txtReceiptsFile;
            // Declare heads of receipts file
            string headReceipts1 = "Nº PEDIDO FECHA_HORA         CAFÉS DONUTS GALLETAS SUBTOTAL TAX        TOTAL      LICITADO CAMBIO";
            string headReceipts2 = "--------- ------------------ ----- ------ -------- -------- ---------- ---------- -------- ----------";
            // Declare receipt number
            string numberReceiptString = "";

            string myCoffeeInput = "";
            string myDonutsInput = "";
            string myCookiesInput = "";

            // Format data imputs
            myCoffeeInput = coffeeInput.Text.PadLeft(5, ' ');
            myDonutsInput = donutsInput.Text.PadLeft(6, ' ');
            myCookiesInput = cookiesInput.Text.PadLeft(8, ' ');
            // Get and format order number
            numberReceiptString = myOrderNumberControl("OrderNumber.txt", "C:\\OrderNumber");
            numberReceiptString = numberReceiptString.PadLeft(9, ' ');
            
            // Create the receipt line to insert into the receipts file
            string Text = numberReceiptString + " " + DateTime.Now + " " + myCoffeeInput + " " + myDonutsInput + " " + myCookiesInput;

            // If do not exists the directory we need to create first
            if (!Directory.Exists(directory))
            {
                // Create the directory where we will put the receipts file
                Directory.CreateDirectory(directory);
            }

            // If don´t exists the file we need to create first
            if (!File.Exists(path))
            {
                // Create the file to write to
                using (StreamWriter sw = File.CreateText(path))
                {
                    // Write the heads of the file, and the receipt and close file
                    sw.WriteLine(headReceipts1);
                    sw.WriteLine(headReceipts2);
                    sw.WriteLine(Text);
                    sw.Close();
                }
            }
            else // The file exists
            {
                // Open text file, add the receipt and close the file
                File.AppendAllLines(path, new String[] { Text });
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                neworderbutton.Enabled = true;

                printer.Play();

                // Prints items to the receipt
                titlereceiptLabel.Text = $"DUNKIN DONUTS";
                Refresh();
                Thread.Sleep(500);

                orderNumberString = orderNumberControlRead("C:\\OrderNumber\\OrderNumber.txt");
                receiptLabel.Text += $"\n\n                        Número de pedido " + orderNumberString;
                Refresh();
                Thread.Sleep(500);

                receiptLabel.Text += $"\n                       "+ DateTime.Now + "\n";
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

                // Invoke record receipt into text file
                recordReceipt();

                neworderbutton.Enabled = true;
            }
            catch 
            {
                // Error handling
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

                    // Calculate the change
                    change = tenderedAmount - totalCost;
                    changeOutput.Text = $"{change.ToString("c")}";

                    receiptButton.Enabled = true;
                }
                else
                {
                    // Error handling
                    error.Play();

                    receiptLabel.BackColor = Color.Red;
                    receiptLabel.Text = "Insuficiente cantidad de dinero";

                    Refresh();
                    Thread.Sleep(1000);

                    receiptLabel.BackColor = Color.White;
                    receiptLabel.Text = "";

                    // Clear input
                    tenderedInput.Text = "";
                }
            }
            catch 
            {
                // Error handling
                error.Play();

                receiptLabel.BackColor = Color.Red;
                receiptLabel.Text = $"Error";

                Refresh(); 
                Thread.Sleep(1000);

                receiptLabel.BackColor = Color.White;
                receiptLabel.Text = "";

                // Clear input
                tenderedInput.Text = "";
            }
        }

        private void totalsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                cash.Play();

                // ReceiptButton.Enabled = true;
                changebutton.Enabled = true;

                coffeeAmount = Convert.ToDouble(coffeeInput.Text);
                donutAmount = Convert.ToDouble(donutsInput.Text);
                cookieAmount = Convert.ToDouble(cookiesInput.Text);

                // Do calculations
                subTotal = coffeeAmount * coffeePrice + donutAmount * donutPrice + cookieAmount * cookiePrice;
                tax = subTotal * taxRate;
                totalCost = subTotal + tax;

                // Show outputs
                subTotalOutput.Text = $"{subTotal.ToString("c")}";
                taxOutput.Text = $"{tax.ToString("c")}";
                totalOutput.Text = $"{totalCost.ToString("c")}";
            }
            catch
            {
                // Error handling
                error.Play();

                receiptLabel.BackColor = Color.Red;
                receiptLabel.Text = $"Error";

                Refresh();
                Thread.Sleep(1000);

                receiptLabel.BackColor = Color.White;
                receiptLabel.Text = "";

                // Clean inputs
                coffeeInput.Text = "";
                donutsInput.Text = "";
                cookiesInput.Text = "";
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

                // Clear the labels
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
                // Error handling
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
