namespace dekstopApp
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
            button1 = new Button();
            label1 = new Label();
            datepicker = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(330, 328);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Click Me\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 72);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 1;
            label1.Text = "Date";
            label1.Click += label1_Click;
            // 
            // datepicker
            // 
            datepicker.CustomFormat = "dd-mmmm-yyyy";
            datepicker.Format = DateTimePickerFormat.Custom;
            datepicker.Location = new Point(267, 70);
            datepicker.Name = "datepicker";
            datepicker.Size = new Size(300, 31);
            datepicker.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 300);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 3;
            label2.Text = "Your Date";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(datepicker);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Hello World";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DateTimePicker datepicker;
        private Label label2;
        private TextBox textBox1;
    }
}
