namespace cashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.makeupshopLabel = new System.Windows.Forms.Label();
            this.coffeeLabel = new System.Windows.Forms.Label();
            this.donutsLabel = new System.Windows.Forms.Label();
            this.cookiesLabel = new System.Windows.Forms.Label();
            this.coffeeInput = new System.Windows.Forms.TextBox();
            this.cookiesInput = new System.Windows.Forms.TextBox();
            this.donutsInput = new System.Windows.Forms.TextBox();
            this.totalsbutton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changebutton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.neworderbutton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.titlereceiptLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeupshopLabel
            // 
            this.makeupshopLabel.BackColor = System.Drawing.Color.Sienna;
            this.makeupshopLabel.Location = new System.Drawing.Point(0, 0);
            this.makeupshopLabel.Name = "makeupshopLabel";
            this.makeupshopLabel.Size = new System.Drawing.Size(604, 63);
            this.makeupshopLabel.TabIndex = 0;
            this.makeupshopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coffeeLabel
            // 
            this.coffeeLabel.AutoSize = true;
            this.coffeeLabel.BackColor = System.Drawing.Color.Transparent;
            this.coffeeLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeLabel.Location = new System.Drawing.Point(30, 92);
            this.coffeeLabel.Name = "coffeeLabel";
            this.coffeeLabel.Size = new System.Drawing.Size(104, 14);
            this.coffeeLabel.TabIndex = 1;
            this.coffeeLabel.Text = "Número de cafés ";
            // 
            // donutsLabel
            // 
            this.donutsLabel.AutoSize = true;
            this.donutsLabel.BackColor = System.Drawing.Color.Transparent;
            this.donutsLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donutsLabel.Location = new System.Drawing.Point(30, 120);
            this.donutsLabel.Name = "donutsLabel";
            this.donutsLabel.Size = new System.Drawing.Size(112, 14);
            this.donutsLabel.TabIndex = 2;
            this.donutsLabel.Text = "Número de donuts";
            // 
            // cookiesLabel
            // 
            this.cookiesLabel.AutoSize = true;
            this.cookiesLabel.BackColor = System.Drawing.Color.Transparent;
            this.cookiesLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookiesLabel.Location = new System.Drawing.Point(30, 154);
            this.cookiesLabel.Name = "cookiesLabel";
            this.cookiesLabel.Size = new System.Drawing.Size(118, 14);
            this.cookiesLabel.TabIndex = 3;
            this.cookiesLabel.Text = "Número de galletas";
            // 
            // coffeeInput
            // 
            this.coffeeInput.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeInput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.coffeeInput.Location = new System.Drawing.Point(206, 89);
            this.coffeeInput.Name = "coffeeInput";
            this.coffeeInput.Size = new System.Drawing.Size(44, 20);
            this.coffeeInput.TabIndex = 4;
            // 
            // cookiesInput
            // 
            this.cookiesInput.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookiesInput.Location = new System.Drawing.Point(206, 147);
            this.cookiesInput.Name = "cookiesInput";
            this.cookiesInput.Size = new System.Drawing.Size(44, 20);
            this.cookiesInput.TabIndex = 5;
            // 
            // donutsInput
            // 
            this.donutsInput.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donutsInput.Location = new System.Drawing.Point(206, 117);
            this.donutsInput.Name = "donutsInput";
            this.donutsInput.Size = new System.Drawing.Size(44, 20);
            this.donutsInput.TabIndex = 6;
            // 
            // totalsbutton
            // 
            this.totalsbutton.BackgroundImage = global::cashRegister.Properties.Resources.rosa;
            this.totalsbutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsbutton.Location = new System.Drawing.Point(33, 209);
            this.totalsbutton.Name = "totalsbutton";
            this.totalsbutton.Size = new System.Drawing.Size(217, 26);
            this.totalsbutton.TabIndex = 7;
            this.totalsbutton.Text = "Calcular Totales";
            this.totalsbutton.UseVisualStyleBackColor = true;
            this.totalsbutton.Click += new System.EventHandler(this.totalsbutton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(30, 257);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(62, 14);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(30, 286);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(29, 14);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(30, 312);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(37, 14);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(34, 361);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 14);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Licitado";
            // 
            // changebutton
            // 
            this.changebutton.BackgroundImage = global::cashRegister.Properties.Resources.rosa;
            this.changebutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changebutton.Location = new System.Drawing.Point(36, 389);
            this.changebutton.Name = "changebutton";
            this.changebutton.Size = new System.Drawing.Size(214, 23);
            this.changebutton.TabIndex = 12;
            this.changebutton.Text = "Calcular el cambio";
            this.changebutton.UseVisualStyleBackColor = true;
            this.changebutton.Click += new System.EventHandler(this.changebutton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(144, 354);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(106, 20);
            this.tenderedInput.TabIndex = 13;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(298, 108);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(258, 350);
            this.receiptLabel.TabIndex = 14;
            // 
            // receiptButton
            // 
            this.receiptButton.BackgroundImage = global::cashRegister.Properties.Resources.rosa;
            this.receiptButton.Enabled = false;
            this.receiptButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(37, 480);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(213, 23);
            this.receiptButton.TabIndex = 15;
            this.receiptButton.Text = "Imprimir Recivo";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // neworderbutton
            // 
            this.neworderbutton.BackgroundImage = global::cashRegister.Properties.Resources.marron;
            this.neworderbutton.Enabled = false;
            this.neworderbutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neworderbutton.Location = new System.Drawing.Point(298, 480);
            this.neworderbutton.Name = "neworderbutton";
            this.neworderbutton.Size = new System.Drawing.Size(260, 23);
            this.neworderbutton.TabIndex = 16;
            this.neworderbutton.Text = "Nuevo Pedido";
            this.neworderbutton.UseVisualStyleBackColor = true;
            this.neworderbutton.Click += new System.EventHandler(this.neworderbutton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(34, 432);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(51, 14);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Cambio";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.AutoSize = true;
            this.subTotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subTotalOutput.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(220, 257);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(0, 14);
            this.subTotalOutput.TabIndex = 18;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(220, 286);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 14);
            this.taxOutput.TabIndex = 19;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(220, 311);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 14);
            this.totalOutput.TabIndex = 20;
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(215, 432);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 14);
            this.changeOutput.TabIndex = 21;
            // 
            // titlereceiptLabel
            // 
            this.titlereceiptLabel.BackColor = System.Drawing.Color.SaddleBrown;
            this.titlereceiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titlereceiptLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlereceiptLabel.Location = new System.Drawing.Point(298, 83);
            this.titlereceiptLabel.Name = "titlereceiptLabel";
            this.titlereceiptLabel.Size = new System.Drawing.Size(258, 26);
            this.titlereceiptLabel.TabIndex = 22;
            this.titlereceiptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::cashRegister.Properties.Resources.dunkin_donuts_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(250, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cashRegister.Properties.Resources.Imagen3;
            this.ClientSize = new System.Drawing.Size(602, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titlereceiptLabel);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.neworderbutton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changebutton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalsbutton);
            this.Controls.Add(this.donutsInput);
            this.Controls.Add(this.cookiesInput);
            this.Controls.Add(this.coffeeInput);
            this.Controls.Add(this.cookiesLabel);
            this.Controls.Add(this.donutsLabel);
            this.Controls.Add(this.coffeeLabel);
            this.Controls.Add(this.makeupshopLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(618, 551);
            this.Name = "Form1";
            this.Text = "Cash Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label makeupshopLabel;
        private System.Windows.Forms.Label coffeeLabel;
        private System.Windows.Forms.Label donutsLabel;
        private System.Windows.Forms.Label cookiesLabel;
        private System.Windows.Forms.TextBox coffeeInput;
        private System.Windows.Forms.TextBox cookiesInput;
        private System.Windows.Forms.TextBox donutsInput;
        private System.Windows.Forms.Button totalsbutton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changebutton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button neworderbutton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Label titlereceiptLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

