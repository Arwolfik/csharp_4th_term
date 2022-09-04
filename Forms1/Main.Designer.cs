
namespace task1
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.OutputButton = new System.Windows.Forms.Button();
            this.DisclenButton = new System.Windows.Forms.Button();
            this.LengthBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.BeginTextBox = new System.Windows.Forms.TextBox();
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.ResTextBox = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.StyletextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(388, 5);
            this.listBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(618, 160);
            this.listBox.TabIndex = 0;
            // 
            // OutputButton
            // 
            this.OutputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputButton.Location = new System.Drawing.Point(6, 5);
            this.OutputButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(373, 30);
            this.OutputButton.TabIndex = 1;
            this.OutputButton.Text = "Вывести сборку на диске";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // DisclenButton
            // 
            this.DisclenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DisclenButton.Location = new System.Drawing.Point(6, 126);
            this.DisclenButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisclenButton.Name = "DisclenButton";
            this.DisclenButton.Size = new System.Drawing.Size(183, 32);
            this.DisclenButton.TabIndex = 2;
            this.DisclenButton.Text = "Продолжительность диска";
            this.DisclenButton.UseVisualStyleBackColor = true;
            this.DisclenButton.Click += new System.EventHandler(this.DisclenButton_Click);
            // 
            // LengthBox
            // 
            this.LengthBox.Location = new System.Drawing.Point(192, 126);
            this.LengthBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LengthBox.Multiline = true;
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(187, 33);
            this.LengthBox.TabIndex = 3;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(6, 194);
            this.FindButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(182, 32);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Узнать трек";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // BeginTextBox
            // 
            this.BeginTextBox.Location = new System.Drawing.Point(191, 194);
            this.BeginTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BeginTextBox.Name = "BeginTextBox";
            this.BeginTextBox.Size = new System.Drawing.Size(98, 20);
            this.BeginTextBox.TabIndex = 5;
            this.BeginTextBox.TextChanged += new System.EventHandler(this.BeginTextBox_TextChanged);
            // 
            // EndTextBox
            // 
            this.EndTextBox.Location = new System.Drawing.Point(291, 194);
            this.EndTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(87, 20);
            this.EndTextBox.TabIndex = 6;
            this.EndTextBox.TextChanged += new System.EventHandler(this.EndTextBox_TextChanged);
            // 
            // ResTextBox
            // 
            this.ResTextBox.Location = new System.Drawing.Point(388, 169);
            this.ResTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResTextBox.Multiline = true;
            this.ResTextBox.Name = "ResTextBox";
            this.ResTextBox.Size = new System.Drawing.Size(618, 58);
            this.ResTextBox.TabIndex = 7;
            // 
            // SortButton
            // 
            this.SortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortButton.Location = new System.Drawing.Point(6, 94);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(183, 28);
            this.SortButton.TabIndex = 8;
            this.SortButton.Text = "Отсортировать по стилю";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // StyletextBox
            // 
            this.StyletextBox.Location = new System.Drawing.Point(192, 94);
            this.StyletextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StyletextBox.Multiline = true;
            this.StyletextBox.Name = "StyletextBox";
            this.StyletextBox.Size = new System.Drawing.Size(187, 28);
            this.StyletextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Представлены следующие стили: ROCK, POP, METAL, ALTERNATIVE, CLASSICAL, JAZZ, RAP" +
    ", ELECTRONIC, DISCO, HIPHOP_RAP. \r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Начало диапазона";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Конец диапазона";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 235);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StyletextBox);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.ResTextBox);
            this.Controls.Add(this.EndTextBox);
            this.Controls.Add(this.BeginTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.DisclenButton);
            this.Controls.Add(this.OutputButton);
            this.Controls.Add(this.listBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Button DisclenButton;
        private System.Windows.Forms.TextBox LengthBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox BeginTextBox;
        private System.Windows.Forms.TextBox EndTextBox;
        private System.Windows.Forms.TextBox ResTextBox;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.TextBox StyletextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

