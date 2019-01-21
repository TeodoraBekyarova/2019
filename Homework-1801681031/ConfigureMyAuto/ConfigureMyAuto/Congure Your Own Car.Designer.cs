namespace ConfigureMyAuto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pbGallery = new System.Windows.Forms.PictureBox();
            this.rbPorsche = new System.Windows.Forms.RadioButton();
            this.rbMercedes = new System.Windows.Forms.RadioButton();
            this.rbJaguar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Lprice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbABS = new System.Windows.Forms.CheckBox();
            this.cbLight = new System.Windows.Forms.CheckBox();
            this.cbChains = new System.Windows.Forms.CheckBox();
            this.Ldiscount = new System.Windows.Forms.Label();
            this.Ltotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCheck = new System.Windows.Forms.RadioButton();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pbGallery
            // 
            this.pbGallery.Image = ((System.Drawing.Image)(resources.GetObject("pbGallery.Image")));
            this.pbGallery.Location = new System.Drawing.Point(12, 82);
            this.pbGallery.Name = "pbGallery";
            this.pbGallery.Size = new System.Drawing.Size(432, 275);
            this.pbGallery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGallery.TabIndex = 2;
            this.pbGallery.TabStop = false;
            // 
            // rbPorsche
            // 
            this.rbPorsche.AutoSize = true;
            this.rbPorsche.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbPorsche.Location = new System.Drawing.Point(457, 125);
            this.rbPorsche.Name = "rbPorsche";
            this.rbPorsche.Size = new System.Drawing.Size(85, 23);
            this.rbPorsche.TabIndex = 3;
            this.rbPorsche.TabStop = true;
            this.rbPorsche.Text = "Porsche";
            this.rbPorsche.UseVisualStyleBackColor = true;
            this.rbPorsche.CheckedChanged += new System.EventHandler(this.rbPorsche_CheckedChanged);
            // 
            // rbMercedes
            // 
            this.rbMercedes.AutoSize = true;
            this.rbMercedes.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMercedes.Location = new System.Drawing.Point(457, 154);
            this.rbMercedes.Name = "rbMercedes";
            this.rbMercedes.Size = new System.Drawing.Size(97, 23);
            this.rbMercedes.TabIndex = 4;
            this.rbMercedes.TabStop = true;
            this.rbMercedes.Text = "Mercedes";
            this.rbMercedes.UseVisualStyleBackColor = true;
            this.rbMercedes.CheckedChanged += new System.EventHandler(this.rbMercedes_CheckedChanged);
            // 
            // rbJaguar
            // 
            this.rbJaguar.AutoSize = true;
            this.rbJaguar.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbJaguar.Location = new System.Drawing.Point(457, 183);
            this.rbJaguar.Name = "rbJaguar";
            this.rbJaguar.Size = new System.Drawing.Size(77, 23);
            this.rbJaguar.TabIndex = 5;
            this.rbJaguar.TabStop = true;
            this.rbJaguar.Text = "Jaguar";
            this.rbJaguar.UseVisualStyleBackColor = true;
            this.rbJaguar.CheckedChanged += new System.EventHandler(this.rbJaguar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(450, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose your model";
            // 
            // Lprice
            // 
            this.Lprice.AutoSize = true;
            this.Lprice.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lprice.Location = new System.Drawing.Point(453, 293);
            this.Lprice.Name = "Lprice";
            this.Lprice.Size = new System.Drawing.Size(57, 24);
            this.Lprice.TabIndex = 7;
            this.Lprice.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(661, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Extra adds";
            // 
            // cbABS
            // 
            this.cbABS.AutoSize = true;
            this.cbABS.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbABS.Location = new System.Drawing.Point(665, 125);
            this.cbABS.Name = "cbABS";
            this.cbABS.Size = new System.Drawing.Size(60, 23);
            this.cbABS.TabIndex = 9;
            this.cbABS.Text = "ABS";
            this.cbABS.UseVisualStyleBackColor = true;
            this.cbABS.CheckedChanged += new System.EventHandler(this.cbABS_CheckedChanged);
            // 
            // cbLight
            // 
            this.cbLight.AutoSize = true;
            this.cbLight.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbLight.Location = new System.Drawing.Point(665, 155);
            this.cbLight.Name = "cbLight";
            this.cbLight.Size = new System.Drawing.Size(163, 23);
            this.cbLight.TabIndex = 10;
            this.cbLight.Text = "Extra lights for fog";
            this.cbLight.UseVisualStyleBackColor = true;
            this.cbLight.CheckedChanged += new System.EventHandler(this.cbLight_CheckedChanged);
            // 
            // cbChains
            // 
            this.cbChains.AutoSize = true;
            this.cbChains.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbChains.Location = new System.Drawing.Point(665, 184);
            this.cbChains.Name = "cbChains";
            this.cbChains.Size = new System.Drawing.Size(77, 23);
            this.cbChains.TabIndex = 11;
            this.cbChains.Text = "Chains";
            this.cbChains.UseVisualStyleBackColor = true;
            this.cbChains.CheckedChanged += new System.EventHandler(this.cbChains_CheckedChanged);
            // 
            // Ldiscount
            // 
            this.Ldiscount.AutoSize = true;
            this.Ldiscount.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ldiscount.Location = new System.Drawing.Point(453, 333);
            this.Ldiscount.Name = "Ldiscount";
            this.Ldiscount.Size = new System.Drawing.Size(90, 24);
            this.Ldiscount.TabIndex = 16;
            this.Ldiscount.Text = "Discount:";
            // 
            // Ltotal
            // 
            this.Ltotal.AutoSize = true;
            this.Ltotal.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ltotal.Location = new System.Drawing.Point(453, 374);
            this.Ltotal.Name = "Ltotal";
            this.Ltotal.Size = new System.Drawing.Size(106, 24);
            this.Ltotal.TabIndex = 17;
            this.Ltotal.Text = "Total price:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(447, 448);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 34);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGet.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGet.Location = new System.Drawing.Point(584, 448);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(116, 34);
            this.btnGet.TabIndex = 19;
            this.btnGet.Text = "Get Discount";
            this.btnGet.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(722, 448);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 34);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(854, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 34);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(191, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 80);
            this.label6.TabIndex = 22;
            this.label6.Text = "My car";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCredit);
            this.groupBox1.Controls.Add(this.rbCash);
            this.groupBox1.Controls.Add(this.rbCheck);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(854, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 153);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(6, 102);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(126, 28);
            this.rbCredit.TabIndex = 27;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit Card";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(6, 67);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(71, 28);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCheck
            // 
            this.rbCheck.AutoSize = true;
            this.rbCheck.Location = new System.Drawing.Point(6, 29);
            this.rbCheck.Name = "rbCheck";
            this.rbCheck.Size = new System.Drawing.Size(82, 28);
            this.rbCheck.TabIndex = 0;
            this.rbCheck.TabStop = true;
            this.rbCheck.Text = "Check";
            this.rbCheck.UseVisualStyleBackColor = true;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(569, 300);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 17);
            this.lbPrice.TabIndex = 27;
            this.lbPrice.Text = "label2";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(569, 338);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(46, 17);
            this.lbDiscount.TabIndex = 28;
            this.lbDiscount.Text = "label4";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(569, 381);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(46, 17);
            this.lbTotal.TabIndex = 29;
            this.lbTotal.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1023, 526);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.Ltotal);
            this.Controls.Add(this.Ldiscount);
            this.Controls.Add(this.cbChains);
            this.Controls.Add(this.cbLight);
            this.Controls.Add(this.cbABS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbJaguar);
            this.Controls.Add(this.rbMercedes);
            this.Controls.Add(this.rbPorsche);
            this.Controls.Add(this.pbGallery);
            this.Name = "Form1";
            this.Text = "Configure Your Own Car";
          
            ((System.ComponentModel.ISupportInitialize)(this.pbGallery)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pbGallery;
        private System.Windows.Forms.RadioButton rbPorsche;
        private System.Windows.Forms.RadioButton rbMercedes;
        private System.Windows.Forms.RadioButton rbJaguar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbABS;
        private System.Windows.Forms.CheckBox cbLight;
        private System.Windows.Forms.CheckBox cbChains;
        private System.Windows.Forms.Label Ldiscount;
        private System.Windows.Forms.Label Ltotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCheck;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbTotal;
    }
}

