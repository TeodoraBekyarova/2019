namespace TicketManager
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rbtChildren = new System.Windows.Forms.RadioButton();
            this.rbtSchool = new System.Windows.Forms.RadioButton();
            this.rbtStudent = new System.Windows.Forms.RadioButton();
            this.txbNumber = new System.Windows.Forms.TextBox();
            this.title2nd = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.btnPrice = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rbtChildren
            // 
            this.rbtChildren.AutoSize = true;
            this.rbtChildren.Location = new System.Drawing.Point(217, 150);
            this.rbtChildren.Name = "rbtChildren";
            this.rbtChildren.Size = new System.Drawing.Size(123, 21);
            this.rbtChildren.TabIndex = 3;
            this.rbtChildren.TabStop = true;
            this.rbtChildren.Text = "Children Ticket";
            this.rbtChildren.UseVisualStyleBackColor = true;
            // 
            // rbtSchool
            // 
            this.rbtSchool.AutoSize = true;
            this.rbtSchool.Location = new System.Drawing.Point(382, 150);
            this.rbtSchool.Name = "rbtSchool";
            this.rbtSchool.Size = new System.Drawing.Size(114, 21);
            this.rbtSchool.TabIndex = 4;
            this.rbtSchool.TabStop = true;
            this.rbtSchool.Text = "School Ticket";
            this.rbtSchool.UseVisualStyleBackColor = true;
            // 
            // rbtStudent
            // 
            this.rbtStudent.AutoSize = true;
            this.rbtStudent.Location = new System.Drawing.Point(546, 150);
            this.rbtStudent.Name = "rbtStudent";
            this.rbtStudent.Size = new System.Drawing.Size(120, 21);
            this.rbtStudent.TabIndex = 5;
            this.rbtStudent.TabStop = true;
            this.rbtStudent.Text = "Student Ticket";
            this.rbtStudent.UseVisualStyleBackColor = true;
            // 
            // txbNumber
            // 
            this.txbNumber.BackColor = System.Drawing.Color.SeaShell;
            this.txbNumber.Location = new System.Drawing.Point(217, 240);
            this.txbNumber.Name = "txbNumber";
            this.txbNumber.Size = new System.Drawing.Size(100, 22);
            this.txbNumber.TabIndex = 9;
            // 
            // title2nd
            // 
            this.title2nd.AutoSize = true;
            this.title2nd.BackColor = System.Drawing.Color.LightSalmon;
            this.title2nd.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title2nd.Location = new System.Drawing.Point(309, 76);
            this.title2nd.Name = "title2nd";
            this.title2nd.Size = new System.Drawing.Size(164, 19);
            this.title2nd.TabIndex = 11;
            this.title2nd.Text = "Buy tickets from here.";
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Coral;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(7, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(781, 43);
            this.title.TabIndex = 12;
            this.title.Text = "Cinema City";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.BackColor = System.Drawing.Color.LightSalmon;
            this.Type.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.Location = new System.Drawing.Point(115, 150);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(44, 20);
            this.Type.TabIndex = 13;
            this.Type.Text = "Type:";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.BackColor = System.Drawing.Color.LightSalmon;
            this.Number.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number.Location = new System.Drawing.Point(27, 241);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(132, 20);
            this.Number.TabIndex = 14;
            this.Number.Text = "Number of tickets:";
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.Color.LightSalmon;
            this.btnPrice.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrice.Location = new System.Drawing.Point(382, 355);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(103, 43);
            this.btnPrice.TabIndex = 15;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.BackColor = System.Drawing.Color.DarkSalmon;
            this.money.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.Location = new System.Drawing.Point(522, 361);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(0, 27);
            this.money.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.money);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.title);
            this.Controls.Add(this.title2nd);
            this.Controls.Add(this.txbNumber);
            this.Controls.Add(this.rbtStudent);
            this.Controls.Add(this.rbtSchool);
            this.Controls.Add(this.rbtChildren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton rbtChildren;
        private System.Windows.Forms.RadioButton rbtSchool;
        private System.Windows.Forms.RadioButton rbtStudent;
        private System.Windows.Forms.TextBox txbNumber;
        private System.Windows.Forms.Label title2nd;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Label money;
    }
}

