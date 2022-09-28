
namespace WinFormsKitchen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chblstSnacks = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chblstDrinks = new System.Windows.Forms.CheckedListBox();
            this.btnCooking = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню закусок";
            // 
            // chblstSnacks
            // 
            this.chblstSnacks.FormattingEnabled = true;
            this.chblstSnacks.Items.AddRange(new object[] {
            "Бекон",
            "Яичница",
            "Тост с сыром",
            "Тост с мясом",
            "Ягоды"});
            this.chblstSnacks.Location = new System.Drawing.Point(15, 43);
            this.chblstSnacks.Name = "chblstSnacks";
            this.chblstSnacks.Size = new System.Drawing.Size(120, 94);
            this.chblstSnacks.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Меню напитков";
            // 
            // chblstDrinks
            // 
            this.chblstDrinks.FormattingEnabled = true;
            this.chblstDrinks.Items.AddRange(new object[] {
            "Чай",
            "Кофе"});
            this.chblstDrinks.Location = new System.Drawing.Point(194, 43);
            this.chblstDrinks.Name = "chblstDrinks";
            this.chblstDrinks.Size = new System.Drawing.Size(120, 94);
            this.chblstDrinks.TabIndex = 3;
            // 
            // btnCooking
            // 
            this.btnCooking.Location = new System.Drawing.Point(15, 170);
            this.btnCooking.Name = "btnCooking";
            this.btnCooking.Size = new System.Drawing.Size(108, 23);
            this.btnCooking.TabIndex = 4;
            this.btnCooking.Text = "Приготовить";
            this.btnCooking.UseVisualStyleBackColor = true;
            this.btnCooking.Click += new System.EventHandler(this.btnSnacks_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 15;
            this.lstResult.Location = new System.Drawing.Point(15, 247);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(299, 94);
            this.lstResult.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnCooking);
            this.Controls.Add(this.chblstDrinks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chblstSnacks);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Завтрак туриста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chblstSnacks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chblstDrinks;
        private System.Windows.Forms.Button btnCooking;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label label4;
    }
}

