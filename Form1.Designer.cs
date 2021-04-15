
namespace WeightAndBalance
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhelp = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnaddload = new System.Windows.Forms.Button();
            this.btnflightdata = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wb1 = new WeightAndBalance.WB();
            this.help1 = new WeightAndBalance.help();
            this.addLoad1 = new WeightAndBalance.AddLoad();
            this.flightinfo1 = new WeightAndBalance.Flightinfo();
            this.home1 = new WeightAndBalance.Home();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnhelp);
            this.panel1.Controls.Add(this.btncalculate);
            this.panel1.Controls.Add(this.btnaddload);
            this.panel1.Controls.Add(this.btnflightdata);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 661);
            this.panel1.TabIndex = 0;
            // 
            // btnhelp
            // 
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhelp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnhelp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnhelp.Location = new System.Drawing.Point(0, 428);
            this.btnhelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(153, 54);
            this.btnhelp.TabIndex = 4;
            this.btnhelp.Text = "Help";
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalculate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btncalculate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btncalculate.Location = new System.Drawing.Point(0, 359);
            this.btncalculate.Margin = new System.Windows.Forms.Padding(0);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(153, 63);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "Weight and balance";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnaddload
            // 
            this.btnaddload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddload.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnaddload.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnaddload.Location = new System.Drawing.Point(0, 299);
            this.btnaddload.Margin = new System.Windows.Forms.Padding(0);
            this.btnaddload.Name = "btnaddload";
            this.btnaddload.Size = new System.Drawing.Size(153, 54);
            this.btnaddload.TabIndex = 2;
            this.btnaddload.Text = "Add Load";
            this.btnaddload.UseVisualStyleBackColor = true;
            this.btnaddload.Click += new System.EventHandler(this.btnaddload_Click);
            // 
            // btnflightdata
            // 
            this.btnflightdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnflightdata.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnflightdata.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnflightdata.Location = new System.Drawing.Point(0, 239);
            this.btnflightdata.Margin = new System.Windows.Forms.Padding(0);
            this.btnflightdata.Name = "btnflightdata";
            this.btnflightdata.Size = new System.Drawing.Size(153, 54);
            this.btnflightdata.TabIndex = 1;
            this.btnflightdata.Text = "Flight info";
            this.btnflightdata.UseVisualStyleBackColor = true;
            this.btnflightdata.Click += new System.EventHandler(this.btnflightdata_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnhome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnhome.Location = new System.Drawing.Point(0, 179);
            this.btnhome.Margin = new System.Windows.Forms.Padding(0);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(153, 54);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(556, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Powered by Aircraft Weight and Balace Systems";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wb1
            // 
            this.wb1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.wb1.Location = new System.Drawing.Point(154, 153);
            this.wb1.Name = "wb1";
            this.wb1.Size = new System.Drawing.Size(650, 480);
            this.wb1.TabIndex = 10;
            // 
            // help1
            // 
            this.help1.Location = new System.Drawing.Point(154, 153);
            this.help1.Name = "help1";
            this.help1.Size = new System.Drawing.Size(650, 480);
            this.help1.TabIndex = 9;
            // 
            // addLoad1
            // 
            this.addLoad1.Location = new System.Drawing.Point(154, 153);
            this.addLoad1.Name = "addLoad1";
            this.addLoad1.Size = new System.Drawing.Size(650, 480);
            this.addLoad1.TabIndex = 8;
            // 
            // flightinfo1
            // 
            this.flightinfo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flightinfo1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flightinfo1.Location = new System.Drawing.Point(154, 153);
            this.flightinfo1.Name = "flightinfo1";
            this.flightinfo1.Size = new System.Drawing.Size(650, 480);
            this.flightinfo1.TabIndex = 7;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(154, 153);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(650, 480);
            this.home1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 661);
            this.Controls.Add(this.wb1);
            this.Controls.Add(this.help1);
            this.Controls.Add(this.addLoad1);
            this.Controls.Add(this.flightinfo1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ASL - Weight and balance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnaddload;
        private System.Windows.Forms.Button btnflightdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhome;
        private Home home1;
        private Flightinfo flightinfo1;
        private AddLoad addLoad1;
        private help help1;
        private WB wb1;
    }
}

