namespace Practicn7
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
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 27);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "Программный буфер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(537, 27);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 1;
            label2.Text = "Файловый буфер";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(27, 55);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(349, 494);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(537, 55);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(349, 494);
            richTextBox2.TabIndex = 3;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(382, 99);
            button1.Name = "button1";
            button1.Size = new Size(149, 31);
            button1.TabIndex = 4;
            button1.Text = "=>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(382, 167);
            button2.Name = "button2";
            button2.Size = new Size(149, 31);
            button2.TabIndex = 5;
            button2.Text = "<=";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 567);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 6;
            label3.Text = "Количество строк";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 598);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "0";
            // 
            // button3
            // 
            button3.Location = new Point(28, 631);
            button3.Name = "button3";
            button3.Size = new Size(228, 26);
            button3.TabIndex = 8;
            button3.Text = "Сгенерировать";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(274, 572);
            button4.Name = "button4";
            button4.Size = new Size(102, 85);
            button4.TabIndex = 9;
            button4.Text = "Очистить \n программный \n буфер";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(537, 572);
            button5.Name = "button5";
            button5.Size = new Size(236, 38);
            button5.TabIndex = 10;
            button5.Text = "Загрузить из файла в файловый буфер";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(537, 625);
            button6.Name = "button6";
            button6.Size = new Size(236, 38);
            button6.TabIndex = 11;
            button6.Text = "Сохранить из файлового буфера в файл";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(797, 572);
            button7.Name = "button7";
            button7.Size = new Size(102, 91);
            button7.TabIndex = 12;
            button7.Text = "Очистить \n программный \n буфер";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 667);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Нет, не смотрите сюда";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}