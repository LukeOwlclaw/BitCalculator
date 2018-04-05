namespace BitCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bit0 = new System.Windows.Forms.CheckBox();
            this.Bit1 = new System.Windows.Forms.CheckBox();
            this.Bit2 = new System.Windows.Forms.CheckBox();
            this.Bit3 = new System.Windows.Forms.CheckBox();
            this.Bit4 = new System.Windows.Forms.CheckBox();
            this.Bit5 = new System.Windows.Forms.CheckBox();
            this.Bit6 = new System.Windows.Forms.CheckBox();
            this.Bit7 = new System.Windows.Forms.CheckBox();
            this.SrcBit0 = new System.Windows.Forms.CheckBox();
            this.SrcBit1 = new System.Windows.Forms.CheckBox();
            this.SrcBit2 = new System.Windows.Forms.CheckBox();
            this.SrcBit3 = new System.Windows.Forms.CheckBox();
            this.SrcBit4 = new System.Windows.Forms.CheckBox();
            this.SrcBit5 = new System.Windows.Forms.CheckBox();
            this.SrcBit6 = new System.Windows.Forms.CheckBox();
            this.SrcBit7 = new System.Windows.Forms.CheckBox();
            this.DestBit0 = new System.Windows.Forms.CheckBox();
            this.DestBit1 = new System.Windows.Forms.CheckBox();
            this.DestBit2 = new System.Windows.Forms.CheckBox();
            this.DestBit3 = new System.Windows.Forms.CheckBox();
            this.DestBit4 = new System.Windows.Forms.CheckBox();
            this.DestBit5 = new System.Windows.Forms.CheckBox();
            this.DestBit6 = new System.Windows.Forms.CheckBox();
            this.DestBit7 = new System.Windows.Forms.CheckBox();
            this.SrcByte = new System.Windows.Forms.TextBox();
            this.DestByte = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BitSwitch = new System.Windows.Forms.TextBox();
            this.BitSwitchShort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Shift2_Right = new System.Windows.Forms.TextBox();
            this.Shift2_Left = new System.Windows.Forms.TextBox();
            this.Shift2 = new System.Windows.Forms.TextBox();
            this.Shift1 = new System.Windows.Forms.TextBox();
            this.Shift1_Right = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Shift1_Left = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CalcResult = new System.Windows.Forms.TextBox();
            this.CalcExpression = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bit0
            // 
            this.Bit0.AutoSize = true;
            this.Bit0.Checked = true;
            this.Bit0.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Bit0.Location = new System.Drawing.Point(203, 37);
            this.Bit0.Name = "Bit0";
            this.Bit0.Size = new System.Drawing.Size(76, 17);
            this.Bit0.TabIndex = 0;
            this.Bit0.Text = "Bit 0 (LSB)";
            this.Bit0.ThreeState = true;
            this.Bit0.UseVisualStyleBackColor = true;
            this.Bit0.CheckStateChanged += new System.EventHandler(this.Bit_CheckedChanged);
            // 
            // Bit1
            // 
            this.Bit1.AutoSize = true;
            this.Bit1.Checked = true;
            this.Bit1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Bit1.Location = new System.Drawing.Point(203, 60);
            this.Bit1.Name = "Bit1";
            this.Bit1.Size = new System.Drawing.Size(47, 17);
            this.Bit1.TabIndex = 0;
            this.Bit1.Text = "Bit 1";
            this.Bit1.ThreeState = true;
            this.Bit1.UseVisualStyleBackColor = true;
            this.Bit1.CheckStateChanged += new System.EventHandler(this.Bit_CheckedChanged);
            // 
            // Bit2
            // 
            this.Bit2.AutoSize = true;
            this.Bit2.Checked = true;
            this.Bit2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Bit2.Location = new System.Drawing.Point(203, 83);
            this.Bit2.Name = "Bit2";
            this.Bit2.Size = new System.Drawing.Size(47, 17);
            this.Bit2.TabIndex = 0;
            this.Bit2.Text = "Bit 2";
            this.Bit2.ThreeState = true;
            this.Bit2.UseVisualStyleBackColor = true;
            this.Bit2.CheckStateChanged += new System.EventHandler(this.Bit_CheckedChanged);
            // 
            // Bit3
            // 
            this.Bit3.AutoSize = true;
            this.Bit3.Checked = true;
            this.Bit3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Bit3.Location = new System.Drawing.Point(203, 106);
            this.Bit3.Name = "Bit3";
            this.Bit3.Size = new System.Drawing.Size(47, 17);
            this.Bit3.TabIndex = 0;
            this.Bit3.Text = "Bit 3";
            this.Bit3.ThreeState = true;
            this.Bit3.UseVisualStyleBackColor = true;
            this.Bit3.CheckStateChanged += new System.EventHandler(this.Bit_CheckedChanged);
            // 
            // Bit4
            // 
            this.Bit4.AutoSize = true;
            this.Bit4.Checked = true;
            this.Bit4.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Bit4.Location = new System.Drawing.Point(203, 129);
            this.Bit4.Name = "Bit4";
            this.Bit4.Size = new System.Drawing.Size(47, 17);
            this.Bit4.TabIndex = 0;
            this.Bit4.Text = "Bit 4";
            this.Bit4.ThreeState = true;
            this.Bit4.UseVisualStyleBackColor = true;
            this.Bit4.CheckStateChanged += new System.EventHandler(this.Bit_CheckedChanged);
            // 
            // Bit5
            // 
            this.Bit5.AutoSize = true;
            this.Bit5.Checked = true;
            this.Bit5.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Bit5.Location = new System.Drawing.Point(203, 152);
            this.Bit5.Name = "Bit5";
            this.Bit5.Size = new System.Drawing.Size(47, 17);
            this.Bit5.TabIndex = 0;
            this.Bit5.Text = "Bit 5";
            this.Bit5.ThreeState = true;
            this.Bit5.UseVisualStyleBackColor = true;
            this.Bit5.CheckStateChanged += new System.EventHandler(this.Bit_CheckedChanged);
            // 
            // Bit6
            // 
            this.Bit6.AutoSize = true;
            this.Bit6.Checked = true;
            this.Bit6.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Bit6.Location = new System.Drawing.Point(203, 175);
            this.Bit6.Name = "Bit6";
            this.Bit6.Size = new System.Drawing.Size(47, 17);
            this.Bit6.TabIndex = 0;
            this.Bit6.Text = "Bit 6";
            this.Bit6.ThreeState = true;
            this.Bit6.UseVisualStyleBackColor = true;
            this.Bit6.CheckStateChanged += new System.EventHandler(this.Bit_CheckedChanged);
            // 
            // Bit7
            // 
            this.Bit7.AutoSize = true;
            this.Bit7.Checked = true;
            this.Bit7.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Bit7.Location = new System.Drawing.Point(203, 198);
            this.Bit7.Name = "Bit7";
            this.Bit7.Size = new System.Drawing.Size(79, 17);
            this.Bit7.TabIndex = 0;
            this.Bit7.Text = "Bit 7 (MSB)";
            this.Bit7.ThreeState = true;
            this.Bit7.UseVisualStyleBackColor = true;
            this.Bit7.CheckStateChanged += new System.EventHandler(this.Bit_CheckedChanged);
            // 
            // SrcBit0
            // 
            this.SrcBit0.AutoSize = true;
            this.SrcBit0.Location = new System.Drawing.Point(53, 37);
            this.SrcBit0.Name = "SrcBit0";
            this.SrcBit0.Size = new System.Drawing.Size(76, 17);
            this.SrcBit0.TabIndex = 0;
            this.SrcBit0.Text = "Bit 0 (LSB)";
            this.SrcBit0.UseVisualStyleBackColor = true;
            this.SrcBit0.CheckedChanged += new System.EventHandler(this.SrcBit_CheckedChanged);
            // 
            // SrcBit1
            // 
            this.SrcBit1.AutoSize = true;
            this.SrcBit1.Location = new System.Drawing.Point(53, 60);
            this.SrcBit1.Name = "SrcBit1";
            this.SrcBit1.Size = new System.Drawing.Size(47, 17);
            this.SrcBit1.TabIndex = 0;
            this.SrcBit1.Text = "Bit 1";
            this.SrcBit1.UseVisualStyleBackColor = true;
            this.SrcBit1.CheckedChanged += new System.EventHandler(this.SrcBit_CheckedChanged);
            // 
            // SrcBit2
            // 
            this.SrcBit2.AutoSize = true;
            this.SrcBit2.Location = new System.Drawing.Point(53, 83);
            this.SrcBit2.Name = "SrcBit2";
            this.SrcBit2.Size = new System.Drawing.Size(47, 17);
            this.SrcBit2.TabIndex = 0;
            this.SrcBit2.Text = "Bit 2";
            this.SrcBit2.UseVisualStyleBackColor = true;
            this.SrcBit2.CheckedChanged += new System.EventHandler(this.SrcBit_CheckedChanged);
            // 
            // SrcBit3
            // 
            this.SrcBit3.AutoSize = true;
            this.SrcBit3.Location = new System.Drawing.Point(53, 106);
            this.SrcBit3.Name = "SrcBit3";
            this.SrcBit3.Size = new System.Drawing.Size(47, 17);
            this.SrcBit3.TabIndex = 0;
            this.SrcBit3.Text = "Bit 3";
            this.SrcBit3.UseVisualStyleBackColor = true;
            this.SrcBit3.CheckedChanged += new System.EventHandler(this.SrcBit_CheckedChanged);
            // 
            // SrcBit4
            // 
            this.SrcBit4.AutoSize = true;
            this.SrcBit4.Location = new System.Drawing.Point(53, 129);
            this.SrcBit4.Name = "SrcBit4";
            this.SrcBit4.Size = new System.Drawing.Size(47, 17);
            this.SrcBit4.TabIndex = 0;
            this.SrcBit4.Text = "Bit 4";
            this.SrcBit4.UseVisualStyleBackColor = true;
            this.SrcBit4.CheckedChanged += new System.EventHandler(this.SrcBit_CheckedChanged);
            // 
            // SrcBit5
            // 
            this.SrcBit5.AutoSize = true;
            this.SrcBit5.Location = new System.Drawing.Point(53, 152);
            this.SrcBit5.Name = "SrcBit5";
            this.SrcBit5.Size = new System.Drawing.Size(47, 17);
            this.SrcBit5.TabIndex = 0;
            this.SrcBit5.Text = "Bit 5";
            this.SrcBit5.UseVisualStyleBackColor = true;
            this.SrcBit5.CheckedChanged += new System.EventHandler(this.SrcBit_CheckedChanged);
            // 
            // SrcBit6
            // 
            this.SrcBit6.AutoSize = true;
            this.SrcBit6.Location = new System.Drawing.Point(53, 175);
            this.SrcBit6.Name = "SrcBit6";
            this.SrcBit6.Size = new System.Drawing.Size(47, 17);
            this.SrcBit6.TabIndex = 0;
            this.SrcBit6.Text = "Bit 6";
            this.SrcBit6.UseVisualStyleBackColor = true;
            this.SrcBit6.CheckedChanged += new System.EventHandler(this.SrcBit_CheckedChanged);
            // 
            // SrcBit7
            // 
            this.SrcBit7.AutoSize = true;
            this.SrcBit7.Location = new System.Drawing.Point(53, 198);
            this.SrcBit7.Name = "SrcBit7";
            this.SrcBit7.Size = new System.Drawing.Size(79, 17);
            this.SrcBit7.TabIndex = 0;
            this.SrcBit7.Text = "Bit 7 (MSB)";
            this.SrcBit7.UseVisualStyleBackColor = true;
            this.SrcBit7.CheckedChanged += new System.EventHandler(this.SrcBit_CheckedChanged);
            // 
            // DestBit0
            // 
            this.DestBit0.AutoSize = true;
            this.DestBit0.Location = new System.Drawing.Point(349, 37);
            this.DestBit0.Name = "DestBit0";
            this.DestBit0.Size = new System.Drawing.Size(76, 17);
            this.DestBit0.TabIndex = 0;
            this.DestBit0.Text = "Bit 0 (LSB)";
            this.DestBit0.UseVisualStyleBackColor = true;
            this.DestBit0.CheckedChanged += new System.EventHandler(this.DestBit_CheckedChanged);
            // 
            // DestBit1
            // 
            this.DestBit1.AutoSize = true;
            this.DestBit1.Location = new System.Drawing.Point(349, 60);
            this.DestBit1.Name = "DestBit1";
            this.DestBit1.Size = new System.Drawing.Size(47, 17);
            this.DestBit1.TabIndex = 0;
            this.DestBit1.Text = "Bit 1";
            this.DestBit1.UseVisualStyleBackColor = true;
            this.DestBit1.CheckedChanged += new System.EventHandler(this.DestBit_CheckedChanged);
            // 
            // DestBit2
            // 
            this.DestBit2.AutoSize = true;
            this.DestBit2.Location = new System.Drawing.Point(349, 83);
            this.DestBit2.Name = "DestBit2";
            this.DestBit2.Size = new System.Drawing.Size(47, 17);
            this.DestBit2.TabIndex = 0;
            this.DestBit2.Text = "Bit 2";
            this.DestBit2.UseVisualStyleBackColor = true;
            this.DestBit2.CheckedChanged += new System.EventHandler(this.DestBit_CheckedChanged);
            // 
            // DestBit3
            // 
            this.DestBit3.AutoSize = true;
            this.DestBit3.Location = new System.Drawing.Point(349, 106);
            this.DestBit3.Name = "DestBit3";
            this.DestBit3.Size = new System.Drawing.Size(47, 17);
            this.DestBit3.TabIndex = 0;
            this.DestBit3.Text = "Bit 3";
            this.DestBit3.UseVisualStyleBackColor = true;
            this.DestBit3.CheckedChanged += new System.EventHandler(this.DestBit_CheckedChanged);
            // 
            // DestBit4
            // 
            this.DestBit4.AutoSize = true;
            this.DestBit4.Location = new System.Drawing.Point(349, 129);
            this.DestBit4.Name = "DestBit4";
            this.DestBit4.Size = new System.Drawing.Size(47, 17);
            this.DestBit4.TabIndex = 0;
            this.DestBit4.Text = "Bit 4";
            this.DestBit4.UseVisualStyleBackColor = true;
            this.DestBit4.CheckedChanged += new System.EventHandler(this.DestBit_CheckedChanged);
            // 
            // DestBit5
            // 
            this.DestBit5.AutoSize = true;
            this.DestBit5.Location = new System.Drawing.Point(349, 152);
            this.DestBit5.Name = "DestBit5";
            this.DestBit5.Size = new System.Drawing.Size(47, 17);
            this.DestBit5.TabIndex = 0;
            this.DestBit5.Text = "Bit 5";
            this.DestBit5.UseVisualStyleBackColor = true;
            this.DestBit5.CheckedChanged += new System.EventHandler(this.DestBit_CheckedChanged);
            // 
            // DestBit6
            // 
            this.DestBit6.AutoSize = true;
            this.DestBit6.Location = new System.Drawing.Point(349, 175);
            this.DestBit6.Name = "DestBit6";
            this.DestBit6.Size = new System.Drawing.Size(47, 17);
            this.DestBit6.TabIndex = 0;
            this.DestBit6.Text = "Bit 6";
            this.DestBit6.UseVisualStyleBackColor = true;
            this.DestBit6.CheckedChanged += new System.EventHandler(this.DestBit_CheckedChanged);
            // 
            // DestBit7
            // 
            this.DestBit7.AutoSize = true;
            this.DestBit7.Location = new System.Drawing.Point(349, 198);
            this.DestBit7.Name = "DestBit7";
            this.DestBit7.Size = new System.Drawing.Size(79, 17);
            this.DestBit7.TabIndex = 0;
            this.DestBit7.Text = "Bit 7 (MSB)";
            this.DestBit7.UseVisualStyleBackColor = true;
            this.DestBit7.CheckedChanged += new System.EventHandler(this.DestBit_CheckedChanged);
            // 
            // SrcByte
            // 
            this.SrcByte.Location = new System.Drawing.Point(53, 221);
            this.SrcByte.Name = "SrcByte";
            this.SrcByte.Size = new System.Drawing.Size(100, 20);
            this.SrcByte.TabIndex = 1;
            this.SrcByte.Text = "0";
            // 
            // DestByte
            // 
            this.DestByte.Location = new System.Drawing.Point(349, 221);
            this.DestByte.Name = "DestByte";
            this.DestByte.Size = new System.Drawing.Size(100, 20);
            this.DestByte.TabIndex = 2;
            this.DestByte.Text = "0";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(53, 286);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(396, 20);
            this.Calc.TabIndex = 1;
            this.Calc.Text = "[ var ]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "= var";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "C-string to calculate output:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 224);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "= output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Set source bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Choose bits to set:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Output is:";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(75, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Switch bit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "with bit ";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(166, 20);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "C-string to calculate output:";
            // 
            // BitSwitch
            // 
            this.BitSwitch.Location = new System.Drawing.Point(13, 129);
            this.BitSwitch.Multiline = true;
            this.BitSwitch.Name = "BitSwitch";
            this.BitSwitch.Size = new System.Drawing.Size(200, 254);
            this.BitSwitch.TabIndex = 1;
            this.BitSwitch.Text = resources.GetString("BitSwitch.Text");
            // 
            // BitSwitchShort
            // 
            this.BitSwitchShort.Location = new System.Drawing.Point(13, 59);
            this.BitSwitchShort.Name = "BitSwitchShort";
            this.BitSwitchShort.Size = new System.Drawing.Size(396, 20);
            this.BitSwitchShort.TabIndex = 1;
            this.BitSwitchShort.Text = "(var & ~(1 << 0) & ~(1 << 0)) | ((1 << 0) & var) >> (0-0) | ((1 << 0) & var) << (" +
                "0-0)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(359, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Note: String can also be used in calculator to the lower left. Define var first!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Bit0);
            this.groupBox1.Controls.Add(this.SrcBit0);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Bit1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DestBit0);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SrcBit1);
            this.groupBox1.Controls.Add(this.Bit2);
            this.groupBox1.Controls.Add(this.DestBit1);
            this.groupBox1.Controls.Add(this.SrcBit2);
            this.groupBox1.Controls.Add(this.Bit3);
            this.groupBox1.Controls.Add(this.DestBit2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SrcBit3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Bit4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DestBit3);
            this.groupBox1.Controls.Add(this.DestByte);
            this.groupBox1.Controls.Add(this.SrcBit4);
            this.groupBox1.Controls.Add(this.Bit5);
            this.groupBox1.Controls.Add(this.DestBit4);
            this.groupBox1.Controls.Add(this.Calc);
            this.groupBox1.Controls.Add(this.SrcBit5);
            this.groupBox1.Controls.Add(this.SrcByte);
            this.groupBox1.Controls.Add(this.Bit6);
            this.groupBox1.Controls.Add(this.DestBit7);
            this.groupBox1.Controls.Add(this.DestBit5);
            this.groupBox1.Controls.Add(this.SrcBit7);
            this.groupBox1.Controls.Add(this.SrcBit6);
            this.groupBox1.Controls.Add(this.DestBit6);
            this.groupBox1.Controls.Add(this.Bit7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 327);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set each bit individually";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.WarningLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.BitSwitchShort);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.BitSwitch);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(485, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 389);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch two bits";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Explaination:";
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(213, 22);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(210, 13);
            this.WarningLabel.TabIndex = 8;
            this.WarningLabel.Text = "Warning: 1st # should be greater than 2nd!";
            this.WarningLabel.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Shift2_Right);
            this.groupBox3.Controls.Add(this.Shift2_Left);
            this.groupBox3.Controls.Add(this.Shift2);
            this.groupBox3.Controls.Add(this.Shift1);
            this.groupBox3.Controls.Add(this.Shift1_Right);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Shift1_Left);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(485, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 94);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculate bit shift";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(187, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Note: Calculator also supports bit shift.";
            // 
            // Shift2_Right
            // 
            this.Shift2_Right.Location = new System.Drawing.Point(141, 45);
            this.Shift2_Right.Name = "Shift2_Right";
            this.Shift2_Right.Size = new System.Drawing.Size(100, 20);
            this.Shift2_Right.TabIndex = 1;
            this.Shift2_Right.Text = "0";
            this.Shift2_Right.TextChanged += new System.EventHandler(this.Shift2_Left_TextChanged);
            // 
            // Shift2_Left
            // 
            this.Shift2_Left.Location = new System.Drawing.Point(12, 45);
            this.Shift2_Left.Name = "Shift2_Left";
            this.Shift2_Left.Size = new System.Drawing.Size(100, 20);
            this.Shift2_Left.TabIndex = 1;
            this.Shift2_Left.Text = "0";
            this.Shift2_Left.TextChanged += new System.EventHandler(this.Shift2_Left_TextChanged);
            // 
            // Shift2
            // 
            this.Shift2.Location = new System.Drawing.Point(266, 45);
            this.Shift2.Name = "Shift2";
            this.Shift2.Size = new System.Drawing.Size(100, 20);
            this.Shift2.TabIndex = 1;
            this.Shift2.Text = "0";
            this.Shift2.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Shift1
            // 
            this.Shift1.Location = new System.Drawing.Point(266, 19);
            this.Shift1.Name = "Shift1";
            this.Shift1.Size = new System.Drawing.Size(100, 20);
            this.Shift1.TabIndex = 1;
            this.Shift1.Text = "0";
            this.Shift1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Shift1_Right
            // 
            this.Shift1_Right.Location = new System.Drawing.Point(141, 19);
            this.Shift1_Right.Name = "Shift1_Right";
            this.Shift1_Right.Size = new System.Drawing.Size(100, 20);
            this.Shift1_Right.TabIndex = 1;
            this.Shift1_Right.Text = "0";
            this.Shift1_Right.TextChanged += new System.EventHandler(this.Shift1_Left_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = ">>";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "=";
            // 
            // Shift1_Left
            // 
            this.Shift1_Left.Location = new System.Drawing.Point(12, 19);
            this.Shift1_Left.Name = "Shift1_Left";
            this.Shift1_Left.Size = new System.Drawing.Size(100, 20);
            this.Shift1_Left.TabIndex = 1;
            this.Shift1_Left.Text = "0";
            this.Shift1_Left.TextChanged += new System.EventHandler(this.Shift1_Left_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(247, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "<<";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.CalcResult);
            this.groupBox4.Controls.Add(this.CalcExpression);
            this.groupBox4.Location = new System.Drawing.Point(11, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 222);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calculator";
            // 
            // CalcResult
            // 
            this.CalcResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CalcResult.Location = new System.Drawing.Point(6, 19);
            this.CalcResult.Multiline = true;
            this.CalcResult.Name = "CalcResult";
            this.CalcResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CalcResult.Size = new System.Drawing.Size(456, 169);
            this.CalcResult.TabIndex = 1;
            this.CalcResult.Text = "Set variable: a=1\r\nAccess variable: a\r\nList all variables: listvar\r\nClear this te" +
                "xt box: clear";
            this.CalcResult.TextChanged += new System.EventHandler(this.CalcResult_TextChanged);
            // 
            // CalcExpression
            // 
            this.CalcExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CalcExpression.Location = new System.Drawing.Point(6, 194);
            this.CalcExpression.Name = "CalcExpression";
            this.CalcExpression.Size = new System.Drawing.Size(456, 20);
            this.CalcExpression.TabIndex = 0;
            this.CalcExpression.Text = "(1+1)<<2";
            this.CalcExpression.Click += new System.EventHandler(this.CalcExpression_Enter);
            this.CalcExpression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcExpression_KeyDown);
            this.CalcExpression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CalcExpression_KeyPress);
            this.CalcExpression.Enter += new System.EventHandler(this.CalcExpression_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 569);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BitCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Bit0;
        private System.Windows.Forms.CheckBox Bit1;
        private System.Windows.Forms.CheckBox Bit2;
        private System.Windows.Forms.CheckBox Bit3;
        private System.Windows.Forms.CheckBox Bit4;
        private System.Windows.Forms.CheckBox Bit5;
        private System.Windows.Forms.CheckBox Bit6;
        private System.Windows.Forms.CheckBox Bit7;
        private System.Windows.Forms.CheckBox SrcBit0;
        private System.Windows.Forms.CheckBox SrcBit1;
        private System.Windows.Forms.CheckBox SrcBit2;
        private System.Windows.Forms.CheckBox SrcBit3;
        private System.Windows.Forms.CheckBox SrcBit4;
        private System.Windows.Forms.CheckBox SrcBit5;
        private System.Windows.Forms.CheckBox SrcBit6;
        private System.Windows.Forms.CheckBox SrcBit7;
        private System.Windows.Forms.CheckBox DestBit0;
        private System.Windows.Forms.CheckBox DestBit1;
        private System.Windows.Forms.CheckBox DestBit2;
        private System.Windows.Forms.CheckBox DestBit3;
        private System.Windows.Forms.CheckBox DestBit4;
        private System.Windows.Forms.CheckBox DestBit5;
        private System.Windows.Forms.CheckBox DestBit6;
        private System.Windows.Forms.CheckBox DestBit7;
        private System.Windows.Forms.TextBox SrcByte;
        private System.Windows.Forms.TextBox DestByte;
        private System.Windows.Forms.TextBox Calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BitSwitch;
        private System.Windows.Forms.TextBox BitSwitchShort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Shift2_Right;
        private System.Windows.Forms.TextBox Shift2_Left;
        private System.Windows.Forms.TextBox Shift1;
        private System.Windows.Forms.TextBox Shift1_Right;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Shift1_Left;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Shift2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox CalcResult;
        private System.Windows.Forms.TextBox CalcExpression;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

