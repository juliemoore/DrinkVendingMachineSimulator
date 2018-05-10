namespace Drink_Vending_Machine_Simulator
{
    partial class mainForm
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
            this.colaPanel = new System.Windows.Forms.Panel();
            this.colaLabel = new System.Windows.Forms.Label();
            this.colaPictureBox = new System.Windows.Forms.PictureBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.selectLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.drinksLeftLlabel = new System.Windows.Forms.Label();
            this.drinksLeftLlabel2 = new System.Windows.Forms.Label();
            this.rootBeerLabel = new System.Windows.Forms.Label();
            this.costLabel2 = new System.Windows.Forms.Label();
            this.rootBeerPanel = new System.Windows.Forms.Panel();
            this.lemonLimePanel = new System.Windows.Forms.Panel();
            this.drinksLeftLlabel3 = new System.Windows.Forms.Label();
            this.lemonLimePictureBox = new System.Windows.Forms.PictureBox();
            this.lemonLimeLabel = new System.Windows.Forms.Label();
            this.costLabel3 = new System.Windows.Forms.Label();
            this.grapeSodaPanel = new System.Windows.Forms.Panel();
            this.drinksLeftLlabel4 = new System.Windows.Forms.Label();
            this.grapeSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.grapeSodaLabel = new System.Windows.Forms.Label();
            this.costLabel4 = new System.Windows.Forms.Label();
            this.creamSodaPanel = new System.Windows.Forms.Panel();
            this.drinksLeftLlabel5 = new System.Windows.Forms.Label();
            this.creamSodaPictureBox = new System.Windows.Forms.PictureBox();
            this.creamSodaLabel = new System.Windows.Forms.Label();
            this.costLabel5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.rootBeerPictureBox = new System.Windows.Forms.PictureBox();
            this.colaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).BeginInit();
            this.rootBeerPanel.SuspendLayout();
            this.lemonLimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).BeginInit();
            this.grapeSodaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).BeginInit();
            this.creamSodaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // colaPanel
            // 
            this.colaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colaPanel.Controls.Add(this.drinksLeftLlabel);
            this.colaPanel.Controls.Add(this.colaPictureBox);
            this.colaPanel.Controls.Add(this.colaLabel);
            this.colaPanel.Controls.Add(this.costLabel);
            this.colaPanel.Location = new System.Drawing.Point(12, 39);
            this.colaPanel.Name = "colaPanel";
            this.colaPanel.Size = new System.Drawing.Size(166, 91);
            this.colaPanel.TabIndex = 0;
            // 
            // colaLabel
            // 
            this.colaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colaLabel.Location = new System.Drawing.Point(84, 51);
            this.colaLabel.Name = "colaLabel";
            this.colaLabel.Size = new System.Drawing.Size(67, 23);
            this.colaLabel.TabIndex = 1;
            this.colaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colaPictureBox
            // 
            this.colaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colaPictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.Cola;
            this.colaPictureBox.Location = new System.Drawing.Point(4, 7);
            this.colaPictureBox.Name = "colaPictureBox";
            this.colaPictureBox.Size = new System.Drawing.Size(67, 70);
            this.colaPictureBox.TabIndex = 0;
            this.colaPictureBox.TabStop = false;
            this.colaPictureBox.Click += new System.EventHandler(this.colaPictureBox_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(35, 51);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 1;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectLabel.Location = new System.Drawing.Point(126, 11);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(122, 20);
            this.selectLabel.TabIndex = 2;
            this.selectLabel.Text = "Select a Drink";
            this.selectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(96, 8);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(43, 15);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "$1.00";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLlabel
            // 
            this.drinksLeftLlabel.AutoSize = true;
            this.drinksLeftLlabel.Location = new System.Drawing.Point(87, 32);
            this.drinksLeftLlabel.Name = "drinksLeftLlabel";
            this.drinksLeftLlabel.Size = new System.Drawing.Size(61, 13);
            this.drinksLeftLlabel.TabIndex = 3;
            this.drinksLeftLlabel.Text = "Drinks Left:";
            this.drinksLeftLlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drinksLeftLlabel2
            // 
            this.drinksLeftLlabel2.AutoSize = true;
            this.drinksLeftLlabel2.Location = new System.Drawing.Point(87, 32);
            this.drinksLeftLlabel2.Name = "drinksLeftLlabel2";
            this.drinksLeftLlabel2.Size = new System.Drawing.Size(61, 13);
            this.drinksLeftLlabel2.TabIndex = 3;
            this.drinksLeftLlabel2.Text = "Drinks Left:";
            this.drinksLeftLlabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootBeerLabel
            // 
            this.rootBeerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootBeerLabel.Location = new System.Drawing.Point(84, 51);
            this.rootBeerLabel.Name = "rootBeerLabel";
            this.rootBeerLabel.Size = new System.Drawing.Size(67, 23);
            this.rootBeerLabel.TabIndex = 1;
            this.rootBeerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel2
            // 
            this.costLabel2.AutoSize = true;
            this.costLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel2.Location = new System.Drawing.Point(96, 8);
            this.costLabel2.Name = "costLabel2";
            this.costLabel2.Size = new System.Drawing.Size(43, 15);
            this.costLabel2.TabIndex = 2;
            this.costLabel2.Text = "$1.00";
            this.costLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rootBeerPanel
            // 
            this.rootBeerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rootBeerPanel.Controls.Add(this.rootBeerPictureBox);
            this.rootBeerPanel.Controls.Add(this.drinksLeftLlabel2);
            this.rootBeerPanel.Controls.Add(this.rootBeerLabel);
            this.rootBeerPanel.Controls.Add(this.costLabel2);
            this.rootBeerPanel.Location = new System.Drawing.Point(184, 39);
            this.rootBeerPanel.Name = "rootBeerPanel";
            this.rootBeerPanel.Size = new System.Drawing.Size(166, 91);
            this.rootBeerPanel.TabIndex = 4;
            // 
            // lemonLimePanel
            // 
            this.lemonLimePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lemonLimePanel.Controls.Add(this.drinksLeftLlabel3);
            this.lemonLimePanel.Controls.Add(this.lemonLimePictureBox);
            this.lemonLimePanel.Controls.Add(this.lemonLimeLabel);
            this.lemonLimePanel.Controls.Add(this.costLabel3);
            this.lemonLimePanel.Location = new System.Drawing.Point(12, 136);
            this.lemonLimePanel.Name = "lemonLimePanel";
            this.lemonLimePanel.Size = new System.Drawing.Size(166, 91);
            this.lemonLimePanel.TabIndex = 5;
            // 
            // drinksLeftLlabel3
            // 
            this.drinksLeftLlabel3.AutoSize = true;
            this.drinksLeftLlabel3.Location = new System.Drawing.Point(87, 32);
            this.drinksLeftLlabel3.Name = "drinksLeftLlabel3";
            this.drinksLeftLlabel3.Size = new System.Drawing.Size(61, 13);
            this.drinksLeftLlabel3.TabIndex = 3;
            this.drinksLeftLlabel3.Text = "Drinks Left:";
            this.drinksLeftLlabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lemonLimePictureBox
            // 
            this.lemonLimePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lemonLimePictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.LemonLime;
            this.lemonLimePictureBox.Location = new System.Drawing.Point(4, 7);
            this.lemonLimePictureBox.Name = "lemonLimePictureBox";
            this.lemonLimePictureBox.Size = new System.Drawing.Size(67, 70);
            this.lemonLimePictureBox.TabIndex = 0;
            this.lemonLimePictureBox.TabStop = false;
            this.lemonLimePictureBox.Click += new System.EventHandler(this.lemonLimePictureBox_Click);
            // 
            // lemonLimeLabel
            // 
            this.lemonLimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lemonLimeLabel.Location = new System.Drawing.Point(84, 51);
            this.lemonLimeLabel.Name = "lemonLimeLabel";
            this.lemonLimeLabel.Size = new System.Drawing.Size(67, 23);
            this.lemonLimeLabel.TabIndex = 1;
            this.lemonLimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel3
            // 
            this.costLabel3.AutoSize = true;
            this.costLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel3.Location = new System.Drawing.Point(96, 8);
            this.costLabel3.Name = "costLabel3";
            this.costLabel3.Size = new System.Drawing.Size(43, 15);
            this.costLabel3.TabIndex = 2;
            this.costLabel3.Text = "$1.00";
            this.costLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grapeSodaPanel
            // 
            this.grapeSodaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grapeSodaPanel.Controls.Add(this.drinksLeftLlabel4);
            this.grapeSodaPanel.Controls.Add(this.grapeSodaPictureBox);
            this.grapeSodaPanel.Controls.Add(this.grapeSodaLabel);
            this.grapeSodaPanel.Controls.Add(this.costLabel4);
            this.grapeSodaPanel.Location = new System.Drawing.Point(184, 136);
            this.grapeSodaPanel.Name = "grapeSodaPanel";
            this.grapeSodaPanel.Size = new System.Drawing.Size(166, 91);
            this.grapeSodaPanel.TabIndex = 6;
            // 
            // drinksLeftLlabel4
            // 
            this.drinksLeftLlabel4.AutoSize = true;
            this.drinksLeftLlabel4.Location = new System.Drawing.Point(87, 32);
            this.drinksLeftLlabel4.Name = "drinksLeftLlabel4";
            this.drinksLeftLlabel4.Size = new System.Drawing.Size(61, 13);
            this.drinksLeftLlabel4.TabIndex = 3;
            this.drinksLeftLlabel4.Text = "Drinks Left:";
            this.drinksLeftLlabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grapeSodaPictureBox
            // 
            this.grapeSodaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grapeSodaPictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.GrapeSoda;
            this.grapeSodaPictureBox.Location = new System.Drawing.Point(4, 7);
            this.grapeSodaPictureBox.Name = "grapeSodaPictureBox";
            this.grapeSodaPictureBox.Size = new System.Drawing.Size(67, 70);
            this.grapeSodaPictureBox.TabIndex = 0;
            this.grapeSodaPictureBox.TabStop = false;
            this.grapeSodaPictureBox.Click += new System.EventHandler(this.grapeSodaPictureBox_Click);
            // 
            // grapeSodaLabel
            // 
            this.grapeSodaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grapeSodaLabel.Location = new System.Drawing.Point(84, 51);
            this.grapeSodaLabel.Name = "grapeSodaLabel";
            this.grapeSodaLabel.Size = new System.Drawing.Size(67, 23);
            this.grapeSodaLabel.TabIndex = 1;
            this.grapeSodaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel4
            // 
            this.costLabel4.AutoSize = true;
            this.costLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel4.Location = new System.Drawing.Point(96, 8);
            this.costLabel4.Name = "costLabel4";
            this.costLabel4.Size = new System.Drawing.Size(43, 15);
            this.costLabel4.TabIndex = 2;
            this.costLabel4.Text = "$1.00";
            this.costLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamSodaPanel
            // 
            this.creamSodaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.creamSodaPanel.Controls.Add(this.drinksLeftLlabel5);
            this.creamSodaPanel.Controls.Add(this.creamSodaPictureBox);
            this.creamSodaPanel.Controls.Add(this.creamSodaLabel);
            this.creamSodaPanel.Controls.Add(this.costLabel5);
            this.creamSodaPanel.Location = new System.Drawing.Point(12, 233);
            this.creamSodaPanel.Name = "creamSodaPanel";
            this.creamSodaPanel.Size = new System.Drawing.Size(166, 91);
            this.creamSodaPanel.TabIndex = 7;
            // 
            // drinksLeftLlabel5
            // 
            this.drinksLeftLlabel5.AutoSize = true;
            this.drinksLeftLlabel5.Location = new System.Drawing.Point(87, 32);
            this.drinksLeftLlabel5.Name = "drinksLeftLlabel5";
            this.drinksLeftLlabel5.Size = new System.Drawing.Size(61, 13);
            this.drinksLeftLlabel5.TabIndex = 3;
            this.drinksLeftLlabel5.Text = "Drinks Left:";
            this.drinksLeftLlabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creamSodaPictureBox
            // 
            this.creamSodaPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.creamSodaPictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.CreamSoda;
            this.creamSodaPictureBox.Location = new System.Drawing.Point(4, 7);
            this.creamSodaPictureBox.Name = "creamSodaPictureBox";
            this.creamSodaPictureBox.Size = new System.Drawing.Size(67, 70);
            this.creamSodaPictureBox.TabIndex = 0;
            this.creamSodaPictureBox.TabStop = false;
            this.creamSodaPictureBox.Click += new System.EventHandler(this.creamSodaPictureBox_Click);
            // 
            // creamSodaLabel
            // 
            this.creamSodaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creamSodaLabel.Location = new System.Drawing.Point(84, 51);
            this.creamSodaLabel.Name = "creamSodaLabel";
            this.creamSodaLabel.Size = new System.Drawing.Size(67, 23);
            this.creamSodaLabel.TabIndex = 1;
            this.creamSodaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costLabel5
            // 
            this.costLabel5.AutoSize = true;
            this.costLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel5.Location = new System.Drawing.Point(96, 8);
            this.costLabel5.Name = "costLabel5";
            this.costLabel5.Size = new System.Drawing.Size(43, 15);
            this.costLabel5.TabIndex = 2;
            this.costLabel5.Text = "$1.00";
            this.costLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.totalSalesLabel);
            this.panel5.Controls.Add(this.totalLabel);
            this.panel5.Location = new System.Drawing.Point(184, 233);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 91);
            this.panel5.TabIndex = 8;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesLabel.Location = new System.Drawing.Point(40, 8);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(88, 16);
            this.totalSalesLabel.TabIndex = 4;
            this.totalSalesLabel.Text = "Total Sales";
            this.totalSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(136, 335);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 24);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // rootBeerPictureBox
            // 
            this.rootBeerPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rootBeerPictureBox.Image = global::Drink_Vending_Machine_Simulator.Properties.Resources.RootBeer;
            this.rootBeerPictureBox.Location = new System.Drawing.Point(4, 7);
            this.rootBeerPictureBox.Name = "rootBeerPictureBox";
            this.rootBeerPictureBox.Size = new System.Drawing.Size(67, 70);
            this.rootBeerPictureBox.TabIndex = 4;
            this.rootBeerPictureBox.TabStop = false;
            this.rootBeerPictureBox.Click += new System.EventHandler(this.rootBeerPictureBox_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 368);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.creamSodaPanel);
            this.Controls.Add(this.grapeSodaPanel);
            this.Controls.Add(this.lemonLimePanel);
            this.Controls.Add(this.rootBeerPanel);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.colaPanel);
            this.Name = "mainForm";
            this.Text = "Drink Vending Machine Simulator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.colaPanel.ResumeLayout(false);
            this.colaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaPictureBox)).EndInit();
            this.rootBeerPanel.ResumeLayout(false);
            this.rootBeerPanel.PerformLayout();
            this.lemonLimePanel.ResumeLayout(false);
            this.lemonLimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lemonLimePictureBox)).EndInit();
            this.grapeSodaPanel.ResumeLayout(false);
            this.grapeSodaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grapeSodaPictureBox)).EndInit();
            this.creamSodaPanel.ResumeLayout(false);
            this.creamSodaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creamSodaPictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootBeerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel colaPanel;
        private System.Windows.Forms.Label colaLabel;
        private System.Windows.Forms.PictureBox colaPictureBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label drinksLeftLlabel;
        private System.Windows.Forms.Label drinksLeftLlabel2;
        private System.Windows.Forms.Label rootBeerLabel;
        private System.Windows.Forms.Label costLabel2;
        private System.Windows.Forms.Panel rootBeerPanel;
        private System.Windows.Forms.Panel lemonLimePanel;
        private System.Windows.Forms.Label drinksLeftLlabel3;
        private System.Windows.Forms.PictureBox lemonLimePictureBox;
        private System.Windows.Forms.Label lemonLimeLabel;
        private System.Windows.Forms.Label costLabel3;
        private System.Windows.Forms.Panel grapeSodaPanel;
        private System.Windows.Forms.Label drinksLeftLlabel4;
        private System.Windows.Forms.PictureBox grapeSodaPictureBox;
        private System.Windows.Forms.Label grapeSodaLabel;
        private System.Windows.Forms.Label costLabel4;
        private System.Windows.Forms.Panel creamSodaPanel;
        private System.Windows.Forms.Label drinksLeftLlabel5;
        private System.Windows.Forms.PictureBox creamSodaPictureBox;
        private System.Windows.Forms.Label creamSodaLabel;
        private System.Windows.Forms.Label costLabel5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox rootBeerPictureBox;
    }
}

