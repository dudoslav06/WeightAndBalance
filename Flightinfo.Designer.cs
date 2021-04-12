
namespace WeightAndBalance
{
    partial class Flightinfo
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxdate = new System.Windows.Forms.DateTimePicker();
            this.boxfltnumber = new System.Windows.Forms.TextBox();
            this.boxorgin = new System.Windows.Forms.TextBox();
            this.boxdestination = new System.Windows.Forms.TextBox();
            this.boxbf = new System.Windows.Forms.TextBox();
            this.boxtaxi = new System.Windows.Forms.TextBox();
            this.boxtrip = new System.Windows.Forms.TextBox();
            this.boxregistration = new System.Windows.Forms.ComboBox();
            this.boxcrew = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(203, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(152, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(130, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Flight number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(203, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Orgin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(147, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Registration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(205, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Crew";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(165, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Block Fuel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(180, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Taxi Fuel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(183, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Trip Fuel";
            // 
            // boxdate
            // 
            this.boxdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.boxdate.Location = new System.Drawing.Point(270, 63);
            this.boxdate.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.boxdate.MinDate = new System.DateTime(2021, 4, 12, 18, 37, 48, 0);
            this.boxdate.Name = "boxdate";
            this.boxdate.Size = new System.Drawing.Size(110, 23);
            this.boxdate.TabIndex = 9;
            this.boxdate.Value = new System.DateTime(2021, 4, 12, 18, 38, 10, 0);
            // 
            // boxfltnumber
            // 
            this.boxfltnumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxfltnumber.Location = new System.Drawing.Point(270, 101);
            this.boxfltnumber.Name = "boxfltnumber";
            this.boxfltnumber.Size = new System.Drawing.Size(110, 23);
            this.boxfltnumber.TabIndex = 10;
            // 
            // boxorgin
            // 
            this.boxorgin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxorgin.Location = new System.Drawing.Point(270, 142);
            this.boxorgin.Name = "boxorgin";
            this.boxorgin.Size = new System.Drawing.Size(110, 23);
            this.boxorgin.TabIndex = 11;
            // 
            // boxdestination
            // 
            this.boxdestination.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxdestination.Location = new System.Drawing.Point(270, 181);
            this.boxdestination.Name = "boxdestination";
            this.boxdestination.Size = new System.Drawing.Size(110, 23);
            this.boxdestination.TabIndex = 12;
            // 
            // boxbf
            // 
            this.boxbf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxbf.Location = new System.Drawing.Point(270, 298);
            this.boxbf.Name = "boxbf";
            this.boxbf.Size = new System.Drawing.Size(110, 23);
            this.boxbf.TabIndex = 15;
            // 
            // boxtaxi
            // 
            this.boxtaxi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxtaxi.Location = new System.Drawing.Point(270, 336);
            this.boxtaxi.Name = "boxtaxi";
            this.boxtaxi.Size = new System.Drawing.Size(110, 23);
            this.boxtaxi.TabIndex = 16;
            // 
            // boxtrip
            // 
            this.boxtrip.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxtrip.Location = new System.Drawing.Point(270, 374);
            this.boxtrip.Name = "boxtrip";
            this.boxtrip.Size = new System.Drawing.Size(110, 23);
            this.boxtrip.TabIndex = 17;
            // 
            // boxregistration
            // 
            this.boxregistration.DisplayMember = "sdf";
            this.boxregistration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxregistration.FormattingEnabled = true;
            this.boxregistration.Items.AddRange(new object[] {
            "EI-STJ",
            "EI-STK",
            "EI-STL",
            "EI-STM",
            "EI-STN",
            "EI-STO",
            "EI-STP",
            "EI-STS",
            "EI-STU"});
            this.boxregistration.Location = new System.Drawing.Point(270, 220);
            this.boxregistration.Name = "boxregistration";
            this.boxregistration.Size = new System.Drawing.Size(110, 25);
            this.boxregistration.TabIndex = 13;
            // 
            // boxcrew
            // 
            this.boxcrew.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.boxcrew.CausesValidation = false;
            this.boxcrew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boxcrew.FormattingEnabled = true;
            this.boxcrew.Items.AddRange(new object[] {
            "2",
            "3"});
            this.boxcrew.Location = new System.Drawing.Point(270, 259);
            this.boxcrew.Name = "boxcrew";
            this.boxcrew.Size = new System.Drawing.Size(110, 25);
            this.boxcrew.TabIndex = 14;
            this.boxcrew.Text = "2";
            this.boxcrew.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Red;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclear.Location = new System.Drawing.Point(158, 416);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(101, 33);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnsave.Location = new System.Drawing.Point(270, 416);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 33);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // Flightinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.boxcrew);
            this.Controls.Add(this.boxregistration);
            this.Controls.Add(this.boxtrip);
            this.Controls.Add(this.boxtaxi);
            this.Controls.Add(this.boxbf);
            this.Controls.Add(this.boxdestination);
            this.Controls.Add(this.boxorgin);
            this.Controls.Add(this.boxfltnumber);
            this.Controls.Add(this.boxdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Flightinfo";
            this.Size = new System.Drawing.Size(650, 480);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker boxdate;
        private System.Windows.Forms.TextBox boxfltnumber;
        private System.Windows.Forms.TextBox boxorgin;
        private System.Windows.Forms.TextBox boxdestination;
        private System.Windows.Forms.TextBox boxbf;
        private System.Windows.Forms.TextBox boxtaxi;
        private System.Windows.Forms.TextBox boxtrip;
        private System.Windows.Forms.ComboBox boxregistration;
        private System.Windows.Forms.ComboBox boxcrew;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
    }
}
