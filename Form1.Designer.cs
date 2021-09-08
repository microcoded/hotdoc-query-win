
namespace hotdoc_query_win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.suburbInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.postcodeInput = new System.Windows.Forms.TextBox();
            this.vaccineBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.availabilityBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suburb:";
            // 
            // suburbInput
            // 
            this.suburbInput.Location = new System.Drawing.Point(67, 10);
            this.suburbInput.Name = "suburbInput";
            this.suburbInput.Size = new System.Drawing.Size(137, 23);
            this.suburbInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "State:";
            // 
            // stateBox
            // 
            this.stateBox.FormattingEnabled = true;
            this.stateBox.ItemHeight = 15;
            this.stateBox.Items.AddRange(new object[] {
            "ACT",
            "NSW",
            "NT",
            "QLD",
            "SA",
            "VIC",
            "WA"});
            this.stateBox.Location = new System.Drawing.Point(67, 47);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(137, 79);
            this.stateBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Postcode:";
            // 
            // postcodeInput
            // 
            this.postcodeInput.Location = new System.Drawing.Point(78, 138);
            this.postcodeInput.Name = "postcodeInput";
            this.postcodeInput.Size = new System.Drawing.Size(126, 23);
            this.postcodeInput.TabIndex = 5;
            this.postcodeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.postcodeInput_KeyPress);
            // 
            // vaccineBox
            // 
            this.vaccineBox.FormattingEnabled = true;
            this.vaccineBox.ItemHeight = 15;
            this.vaccineBox.Items.AddRange(new object[] {
            "Any",
            "AstraZeneca (above 60)",
            "AstraZeneca (below 60)",
            "Pfizer"});
            this.vaccineBox.Location = new System.Drawing.Point(67, 186);
            this.vaccineBox.Name = "vaccineBox";
            this.vaccineBox.Size = new System.Drawing.Size(137, 64);
            this.vaccineBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vaccine:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dose:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(67, 266);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(114, 266);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 19);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Availability:";
            // 
            // availabilityBox
            // 
            this.availabilityBox.FormattingEnabled = true;
            this.availabilityBox.ItemHeight = 15;
            this.availabilityBox.Items.AddRange(new object[] {
            "Today",
            "Next 7 days",
            "Next 14 days",
            "Next 30 days"});
            this.availabilityBox.Location = new System.Drawing.Point(85, 300);
            this.availabilityBox.Name = "availabilityBox";
            this.availabilityBox.Size = new System.Drawing.Size(119, 64);
            this.availabilityBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.availabilityBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vaccineBox);
            this.Controls.Add(this.postcodeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suburbInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HotDoc Query";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox suburbInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox stateBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox postcodeInput;
        private System.Windows.Forms.ListBox vaccineBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox availabilityBox;
    }
}

