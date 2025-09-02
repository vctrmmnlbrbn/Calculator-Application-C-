namespace CalculatorApplication
{
    partial class FrmCalculator
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
            label4 = new Label();
            lblDisplayTotal = new Label();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 127);
            label2.Name = "label2";
            label2.Size = new Size(206, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter Second Number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(146, 204);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 2;
            label3.Text = "Answer :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(257, 218);
            label4.Name = "label4";
            label4.Size = new Size(244, 25);
            label4.TabIndex = 3;
            label4.Text = "_____________________________";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayTotal.Location = new Point(257, 204);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(0, 25);
            lblDisplayTotal.TabIndex = 4;
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput1.Location = new Point(257, 37);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(273, 29);
            txtBoxInput1.TabIndex = 5;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxInput2.Location = new Point(257, 127);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(273, 29);
            txtBoxInput2.TabIndex = 6;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(318, 88);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(121, 27);
            cbOperator.TabIndex = 7;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ControlLight;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(318, 257);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(121, 34);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(btnEqual);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblDisplayTotal;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Button btnEqual;
    }
}
