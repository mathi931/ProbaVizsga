
namespace ProbaVizsga
{
    partial class Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSwitch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numRegistered = new System.Windows.Forms.NumericUpDown();
            this.cbExtra = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGas = new System.Windows.Forms.ComboBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lsbVehicles = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRegistered)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSwitch
            // 
            this.cmbSwitch.FormattingEnabled = true;
            this.cmbSwitch.Location = new System.Drawing.Point(116, 12);
            this.cmbSwitch.Name = "cmbSwitch";
            this.cmbSwitch.Size = new System.Drawing.Size(121, 28);
            this.cmbSwitch.TabIndex = 1;
            this.cmbSwitch.SelectedIndexChanged += new System.EventHandler(this.cmbSwitch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registered";
            // 
            // numRegistered
            // 
            this.numRegistered.Location = new System.Drawing.Point(117, 62);
            this.numRegistered.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numRegistered.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numRegistered.Name = "numRegistered";
            this.numRegistered.Size = new System.Drawing.Size(120, 26);
            this.numRegistered.TabIndex = 4;
            this.numRegistered.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbExtra
            // 
            this.cbExtra.AutoSize = true;
            this.cbExtra.Location = new System.Drawing.Point(117, 160);
            this.cbExtra.Name = "cbExtra";
            this.cbExtra.Size = new System.Drawing.Size(119, 24);
            this.cbExtra.TabIndex = 6;
            this.cbExtra.Text = "Double Long";
            this.cbExtra.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(562, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gas";
            // 
            // cmbGas
            // 
            this.cmbGas.FormattingEnabled = true;
            this.cmbGas.Location = new System.Drawing.Point(117, 110);
            this.cmbGas.Name = "cmbGas";
            this.cmbGas.Size = new System.Drawing.Size(121, 28);
            this.cmbGas.TabIndex = 8;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // lsbVehicles
            // 
            this.lsbVehicles.FormattingEnabled = true;
            this.lsbVehicles.ItemHeight = 20;
            this.lsbVehicles.Location = new System.Drawing.Point(260, 12);
            this.lsbVehicles.Name = "lsbVehicles";
            this.lsbVehicles.Size = new System.Drawing.Size(394, 304);
            this.lsbVehicles.TabIndex = 10;
            // 
            // Index
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(666, 390);
            this.Controls.Add(this.lsbVehicles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbGas);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbExtra);
            this.Controls.Add(this.numRegistered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSwitch);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Index_FormClosing);
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRegistered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSwitch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRegistered;
        private System.Windows.Forms.CheckBox cbExtra;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGas;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListBox lsbVehicles;
    }
}