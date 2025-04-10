namespace CalculaterWinForm
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            AddButton = new Button();
            SubtractButton = new Button();
            MultiplyButton = new Button();
            DivideButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(353, 66);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Calculater App";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 117);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "First";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 171);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "Second";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 122);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 31);
            textBox2.TabIndex = 4;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(125, 243);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(112, 34);
            AddButton.TabIndex = 5;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // SubtractButton
            // 
            SubtractButton.Location = new Point(261, 243);
            SubtractButton.Name = "SubtractButton";
            SubtractButton.Size = new Size(112, 34);
            SubtractButton.TabIndex = 6;
            SubtractButton.Text = "Subtract";
            SubtractButton.UseVisualStyleBackColor = true;
            SubtractButton.Click += SubtractButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.Location = new Point(401, 243);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(112, 34);
            MultiplyButton.TabIndex = 7;
            MultiplyButton.Text = "Multiply";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += MultiplyButton_Click;
            // 
            // DivideButton
            // 
            DivideButton.Location = new Point(531, 243);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(112, 34);
            DivideButton.TabIndex = 8;
            DivideButton.Text = "Divison";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += DivideButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(374, 352);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 9;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(DivideButton);
            Controls.Add(MultiplyButton);
            Controls.Add(SubtractButton);
            Controls.Add(AddButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "My App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button AddButton;
        private Button SubtractButton;
        private Button MultiplyButton;
        private Button DivideButton;
        private Label label4;
    }
}
