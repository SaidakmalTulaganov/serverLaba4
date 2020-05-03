namespace clientLaba4
{
    partial class frmAdd
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblKol = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNoParam = new System.Windows.Forms.RadioButton();
            this.rdbYesParam = new System.Windows.Forms.RadioButton();
            this.btnAddTovar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbFloor = new System.Windows.Forms.ComboBox();
            this.spnPlace = new System.Windows.Forms.NumericUpDown();
            this.scrClock = new System.Windows.Forms.HScrollBar();
            this.scrPrice = new System.Windows.Forms.HScrollBar();
            this.cmbBonus = new System.Windows.Forms.ComboBox();
            this.lblClockInfo = new System.Windows.Forms.Label();
            this.lblPriceInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPlace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Этаж";
            // 
            // lblKol
            // 
            this.lblKol.AutoSize = true;
            this.lblKol.Location = new System.Drawing.Point(13, 79);
            this.lblKol.Name = "lblKol";
            this.lblKol.Size = new System.Drawing.Size(49, 17);
            this.lblKol.TabIndex = 1;
            this.lblKol.Text = "Место";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 220);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 17);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Цена";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Часы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Бонусы и акции";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNoParam);
            this.groupBox1.Controls.Add(this.rdbYesParam);
            this.groupBox1.Location = new System.Drawing.Point(16, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оплата";
            // 
            // rdbNoParam
            // 
            this.rdbNoParam.AutoSize = true;
            this.rdbNoParam.Location = new System.Drawing.Point(176, 60);
            this.rdbNoParam.Name = "rdbNoParam";
            this.rdbNoParam.Size = new System.Drawing.Size(77, 21);
            this.rdbNoParam.TabIndex = 1;
            this.rdbNoParam.TabStop = true;
            this.rdbNoParam.Text = "Картой";
            this.rdbNoParam.UseVisualStyleBackColor = true;
            // 
            // rdbYesParam
            // 
            this.rdbYesParam.AutoSize = true;
            this.rdbYesParam.Location = new System.Drawing.Point(43, 60);
            this.rdbYesParam.Name = "rdbYesParam";
            this.rdbYesParam.Size = new System.Drawing.Size(106, 21);
            this.rdbYesParam.TabIndex = 0;
            this.rdbYesParam.TabStop = true;
            this.rdbYesParam.Text = "Наличными";
            this.rdbYesParam.UseVisualStyleBackColor = true;
            // 
            // btnAddTovar
            // 
            this.btnAddTovar.Location = new System.Drawing.Point(59, 519);
            this.btnAddTovar.Name = "btnAddTovar";
            this.btnAddTovar.Size = new System.Drawing.Size(94, 23);
            this.btnAddTovar.TabIndex = 6;
            this.btnAddTovar.Text = "Добавить";
            this.btnAddTovar.UseVisualStyleBackColor = true;
            this.btnAddTovar.Click += new System.EventHandler(this.btnAddTovar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(192, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbFloor
            // 
            this.cmbFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloor.Items.AddRange(new object[] {
            "1 этаж",
            "2 этаж",
            "3 этаж",
            "4 этаж",
            "5 этаж",
            "6 этаж"});
            this.cmbFloor.Location = new System.Drawing.Point(163, 10);
            this.cmbFloor.Name = "cmbFloor";
            this.cmbFloor.Size = new System.Drawing.Size(202, 24);
            this.cmbFloor.TabIndex = 8;
            this.cmbFloor.SelectedIndexChanged += new System.EventHandler(this.cmbFloor_SelectedIndexChanged);
            // 
            // spnPlace
            // 
            this.spnPlace.Location = new System.Drawing.Point(163, 77);
            this.spnPlace.Name = "spnPlace";
            this.spnPlace.Size = new System.Drawing.Size(202, 22);
            this.spnPlace.TabIndex = 9;
            this.spnPlace.ValueChanged += new System.EventHandler(this.spnPlace_ValueChanged);
            // 
            // scrClock
            // 
            this.scrClock.Location = new System.Drawing.Point(163, 143);
            this.scrClock.Maximum = 250;
            this.scrClock.Minimum = 1;
            this.scrClock.Name = "scrClock";
            this.scrClock.Size = new System.Drawing.Size(202, 21);
            this.scrClock.TabIndex = 10;
            this.scrClock.Value = 24;
            this.scrClock.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrClock_Scroll);
            // 
            // scrPrice
            // 
            this.scrPrice.Location = new System.Drawing.Point(163, 216);
            this.scrPrice.Maximum = 1010;
            this.scrPrice.Minimum = 300;
            this.scrPrice.Name = "scrPrice";
            this.scrPrice.Size = new System.Drawing.Size(202, 21);
            this.scrPrice.TabIndex = 11;
            this.scrPrice.Value = 500;
            this.scrPrice.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrPrice_Scroll);
            // 
            // cmbBonus
            // 
            this.cmbBonus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBonus.Items.AddRange(new object[] {
            "Ставь на 10 часов, 11 - й бесплатно",
            "Ставь на 20 часов, 3 часа бесплатно",
            "Ставь на 10 дней, 1 день бесплатно"});
            this.cmbBonus.Location = new System.Drawing.Point(163, 287);
            this.cmbBonus.Name = "cmbBonus";
            this.cmbBonus.Size = new System.Drawing.Size(202, 24);
            this.cmbBonus.TabIndex = 12;
            this.cmbBonus.SelectedIndexChanged += new System.EventHandler(this.cmbBonus_SelectedIndexChanged);
            // 
            // lblClockInfo
            // 
            this.lblClockInfo.AutoSize = true;
            this.lblClockInfo.Location = new System.Drawing.Point(445, 147);
            this.lblClockInfo.Name = "lblClockInfo";
            this.lblClockInfo.Size = new System.Drawing.Size(24, 17);
            this.lblClockInfo.TabIndex = 13;
            this.lblClockInfo.Text = "50";
            // 
            // lblPriceInfo
            // 
            this.lblPriceInfo.AutoSize = true;
            this.lblPriceInfo.Location = new System.Drawing.Point(445, 220);
            this.lblPriceInfo.Name = "lblPriceInfo";
            this.lblPriceInfo.Size = new System.Drawing.Size(32, 17);
            this.lblPriceInfo.TabIndex = 14;
            this.lblPriceInfo.Text = "500";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 565);
            this.Controls.Add(this.lblPriceInfo);
            this.Controls.Add(this.lblClockInfo);
            this.Controls.Add(this.cmbBonus);
            this.Controls.Add(this.scrPrice);
            this.Controls.Add(this.scrClock);
            this.Controls.Add(this.spnPlace);
            this.Controls.Add(this.cmbFloor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTovar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblKol);
            this.Controls.Add(this.lblName);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblKol;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNoParam;
        private System.Windows.Forms.RadioButton rdbYesParam;
        private System.Windows.Forms.Button btnAddTovar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbFloor;
        private System.Windows.Forms.NumericUpDown spnPlace;
        private System.Windows.Forms.HScrollBar scrClock;
        private System.Windows.Forms.HScrollBar scrPrice;
        private System.Windows.Forms.ComboBox cmbBonus;
        private System.Windows.Forms.Label lblClockInfo;
        private System.Windows.Forms.Label lblPriceInfo;
    }
}