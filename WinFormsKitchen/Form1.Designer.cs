
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
            this.btnSnacks = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chblTable = new System.Windows.Forms.CheckedListBox();
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
            // btnSnacks
            // 
            this.btnSnacks.Location = new System.Drawing.Point(15, 170);
            this.btnSnacks.Name = "btnSnacks";
            this.btnSnacks.Size = new System.Drawing.Size(108, 23);
            this.btnSnacks.TabIndex = 4;
            this.btnSnacks.Text = "Приготовить";
            this.btnSnacks.UseVisualStyleBackColor = true;
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(194, 170);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(95, 23);
            this.btnDrinks.TabIndex = 5;
            this.btnDrinks.Text = "Приготовить";
            this.btnDrinks.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кухонные принадлежности";
            // 
            // chblTable
            // 
            this.chblTable.FormattingEnabled = true;
            this.chblTable.Items.AddRange(new object[] {
            "Сковорода",
            "Тостер",
            "Чайник"});
            this.chblTable.Location = new System.Drawing.Point(383, 43);
            this.chblTable.Name = "chblTable";
            this.chblTable.Size = new System.Drawing.Size(120, 94);
            this.chblTable.TabIndex = 7;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 15;
            this.lstResult.Location = new System.Drawing.Point(15, 247);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(120, 94);
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
            this.Controls.Add(this.chblTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnSnacks);
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
        private System.Windows.Forms.Button btnSnacks;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chblTable;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label label4;
    }
}

