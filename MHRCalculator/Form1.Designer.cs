namespace MHRCalculator
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
            calculateBtn = new Button();
            ageNUD = new NumericUpDown();
            label3 = new Label();
            maleRB = new RadioButton();
            femaleRB = new RadioButton();
            formulaCBB = new ComboBox();
            activityCBB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            lowHRTB = new TextBox();
            label5 = new Label();
            mhrTB = new TextBox();
            label4 = new Label();
            highHRTB = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ageNUD).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(152, 325);
            calculateBtn.Margin = new Padding(5);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(146, 48);
            calculateBtn.TabIndex = 15;
            calculateBtn.Text = "Calculate";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // ageNUD
            // 
            ageNUD.Location = new Point(152, 118);
            ageNUD.Margin = new Padding(5);
            ageNUD.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            ageNUD.Minimum = new decimal(new int[] { 12, 0, 0, 0 });
            ageNUD.Name = "ageNUD";
            ageNUD.Size = new Size(189, 32);
            ageNUD.TabIndex = 14;
            ageNUD.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 123);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 13;
            label3.Text = "Age (years):";
            // 
            // maleRB
            // 
            maleRB.AutoSize = true;
            maleRB.Location = new Point(299, 62);
            maleRB.Margin = new Padding(5);
            maleRB.Name = "maleRB";
            maleRB.Size = new Size(72, 29);
            maleRB.TabIndex = 12;
            maleRB.Text = "Male";
            maleRB.UseVisualStyleBackColor = true;
            // 
            // femaleRB
            // 
            femaleRB.AutoSize = true;
            femaleRB.Checked = true;
            femaleRB.Location = new Point(152, 62);
            femaleRB.Margin = new Padding(5);
            femaleRB.Name = "femaleRB";
            femaleRB.Size = new Size(90, 29);
            femaleRB.TabIndex = 11;
            femaleRB.TabStop = true;
            femaleRB.Text = "Female";
            femaleRB.UseVisualStyleBackColor = true;
            // 
            // formulaCBB
            // 
            formulaCBB.FormattingEnabled = true;
            formulaCBB.Items.AddRange(new object[] { "Choose", "Fox", "Gulati", "HUNT", "Tanaka" });
            formulaCBB.Location = new Point(143, 172);
            formulaCBB.Margin = new Padding(5);
            formulaCBB.Name = "formulaCBB";
            formulaCBB.Size = new Size(188, 33);
            formulaCBB.TabIndex = 16;
            // 
            // activityCBB
            // 
            activityCBB.FormattingEnabled = true;
            activityCBB.Items.AddRange(new object[] { "Choose", "Sedentary", "Minimal Activity", "Exercise Sporadically", "Exercise Regularly", "Exercise Lots at High Intensities" });
            activityCBB.Location = new Point(143, 235);
            activityCBB.Margin = new Padding(5);
            activityCBB.Name = "activityCBB";
            activityCBB.Size = new Size(188, 33);
            activityCBB.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 192);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 18;
            label1.Text = "Formula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 240);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 19;
            label2.Text = "Activity Level:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 131);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 23;
            label6.Text = "Low Target HR:";
            // 
            // lowHRTB
            // 
            lowHRTB.Location = new Point(178, 128);
            lowHRTB.Margin = new Padding(5);
            lowHRTB.Name = "lowHRTB";
            lowHRTB.ReadOnly = true;
            lowHRTB.Size = new Size(155, 32);
            lowHRTB.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 65);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 21;
            label5.Text = "Max Heart Rate:";
            // 
            // mhrTB
            // 
            mhrTB.Location = new Point(178, 60);
            mhrTB.Margin = new Padding(5);
            mhrTB.Name = "mhrTB";
            mhrTB.ReadOnly = true;
            mhrTB.Size = new Size(155, 32);
            mhrTB.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 197);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 25;
            label4.Text = "High Target HR:";
            // 
            // highHRTB
            // 
            highHRTB.Location = new Point(178, 194);
            highHRTB.Margin = new Padding(5);
            highHRTB.Name = "highHRTB";
            highHRTB.ReadOnly = true;
            highHRTB.Size = new Size(155, 32);
            highHRTB.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 65);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 26;
            label7.Text = "Gender:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mhrTB);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(highHRTB);
            groupBox1.Controls.Add(lowHRTB);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(457, 17);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(407, 298);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Results";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(activityCBB);
            groupBox2.Controls.Add(formulaCBB);
            groupBox2.Location = new Point(9, 17);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(409, 298);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Inputs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 384);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(calculateBtn);
            Controls.Add(ageNUD);
            Controls.Add(label3);
            Controls.Add(maleRB);
            Controls.Add(femaleRB);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Heart Rate Calculator - Fall 2023";
            ((System.ComponentModel.ISupportInitialize)ageNUD).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateBtn;
        private NumericUpDown ageNUD;
        private Label label3;
        private RadioButton maleRB;
        private RadioButton femaleRB;
        private ComboBox formulaCBB;
        private ComboBox activityCBB;
        private Label label1;
        private Label label2;
        private Label label6;
        private TextBox lowHRTB;
        private Label label5;
        private TextBox mhrTB;
        private Label label4;
        private TextBox highHRTB;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}