
namespace WinFormsApp1
{
    partial class Frm1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.cbHamburguesas = new System.Windows.Forms.ComboBox();
            this.cbCombo = new System.Windows.Forms.ComboBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rbCebolla = new System.Windows.Forms.RadioButton();
            this.rbKetchup = new System.Windows.Forms.RadioButton();
            this.rbMostaza = new System.Windows.Forms.RadioButton();
            this.rbMayo = new System.Windows.Forms.RadioButton();
            this.rbPepino = new System.Windows.Forms.RadioButton();
            this.txtGaseosa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCombos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources._217_2178445_mcdonalds_logo_white_png_mcdonalds_logo_black_and;
            this.pictureBox1.Location = new System.Drawing.Point(195, 628);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(97, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Combos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(346, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 287);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.BurlyWood;
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 14;
            this.lb1.Location = new System.Drawing.Point(400, 66);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(116, 98);
            this.lb1.TabIndex = 22;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.BurlyWood;
            this.lblPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(372, 487);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(17, 17);
            this.lblPrecio.TabIndex = 23;
            this.lblPrecio.Text = "$";
            this.lblPrecio.Click += new System.EventHandler(this.lblPrueba_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(372, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.Location = new System.Drawing.Point(372, 531);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 26;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(441, 661);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 27;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cbHamburguesas
            // 
            this.cbHamburguesas.BackColor = System.Drawing.SystemColors.Window;
            this.cbHamburguesas.FormattingEnabled = true;
            this.cbHamburguesas.Items.AddRange(new object[] {
            "McNifica",
            "Big Mac",
            "Cuarto de Libra",
            "D. Cuarto de Libra",
            "McBacon",
            "McPollo Crispy"});
            this.cbHamburguesas.Location = new System.Drawing.Point(97, 141);
            this.cbHamburguesas.Name = "cbHamburguesas";
            this.cbHamburguesas.Size = new System.Drawing.Size(121, 23);
            this.cbHamburguesas.TabIndex = 28;
            this.cbHamburguesas.Text = "Hamburguesas";
            this.cbHamburguesas.SelectedIndexChanged += new System.EventHandler(this.cbHamburguesas_SelectedIndexChanged);
            // 
            // cbCombo
            // 
            this.cbCombo.FormattingEnabled = true;
            this.cbCombo.Items.AddRange(new object[] {
            "Combo Regular",
            "Combo Pequeño",
            "Combo Grande"});
            this.cbCombo.Location = new System.Drawing.Point(97, 203);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(121, 23);
            this.cbCombo.TabIndex = 29;
            this.cbCombo.Text = "Combo Regular";
            this.cbCombo.SelectedIndexChanged += new System.EventHandler(this.cbCombo_SelectedIndexChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(97, 303);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtDescuento.TabIndex = 32;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.Color.Transparent;
            this.gb1.Controls.Add(this.rbCebolla);
            this.gb1.Controls.Add(this.rbKetchup);
            this.gb1.Controls.Add(this.rbMostaza);
            this.gb1.Controls.Add(this.rbMayo);
            this.gb1.Controls.Add(this.rbPepino);
            this.gb1.Location = new System.Drawing.Point(70, 411);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(106, 143);
            this.gb1.TabIndex = 33;
            this.gb1.TabStop = false;
            this.gb1.Text = "Condimentos";
            // 
            // rbCebolla
            // 
            this.rbCebolla.AutoSize = true;
            this.rbCebolla.Location = new System.Drawing.Point(6, 120);
            this.rbCebolla.Name = "rbCebolla";
            this.rbCebolla.Size = new System.Drawing.Size(65, 19);
            this.rbCebolla.TabIndex = 4;
            this.rbCebolla.TabStop = true;
            this.rbCebolla.Text = "Cebolla";
            this.rbCebolla.UseVisualStyleBackColor = true;
            this.rbCebolla.CheckedChanged += new System.EventHandler(this.rbCebolla_CheckedChanged);
            // 
            // rbKetchup
            // 
            this.rbKetchup.AutoSize = true;
            this.rbKetchup.Location = new System.Drawing.Point(6, 99);
            this.rbKetchup.Name = "rbKetchup";
            this.rbKetchup.Size = new System.Drawing.Size(69, 19);
            this.rbKetchup.TabIndex = 3;
            this.rbKetchup.TabStop = true;
            this.rbKetchup.Text = "Ketchup";
            this.rbKetchup.UseVisualStyleBackColor = true;
            this.rbKetchup.CheckedChanged += new System.EventHandler(this.rbKetchup_CheckedChanged);
            // 
            // rbMostaza
            // 
            this.rbMostaza.AutoSize = true;
            this.rbMostaza.Location = new System.Drawing.Point(6, 74);
            this.rbMostaza.Name = "rbMostaza";
            this.rbMostaza.Size = new System.Drawing.Size(69, 19);
            this.rbMostaza.TabIndex = 2;
            this.rbMostaza.TabStop = true;
            this.rbMostaza.Text = "Mostaza";
            this.rbMostaza.UseVisualStyleBackColor = true;
            this.rbMostaza.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbMayo
            // 
            this.rbMayo.AutoSize = true;
            this.rbMayo.Location = new System.Drawing.Point(6, 49);
            this.rbMayo.Name = "rbMayo";
            this.rbMayo.Size = new System.Drawing.Size(79, 19);
            this.rbMayo.TabIndex = 1;
            this.rbMayo.TabStop = true;
            this.rbMayo.Text = "Mayonesa";
            this.rbMayo.UseVisualStyleBackColor = true;
            this.rbMayo.CheckedChanged += new System.EventHandler(this.rbMayo_CheckedChanged);
            // 
            // rbPepino
            // 
            this.rbPepino.AutoSize = true;
            this.rbPepino.Location = new System.Drawing.Point(6, 22);
            this.rbPepino.Name = "rbPepino";
            this.rbPepino.Size = new System.Drawing.Size(62, 19);
            this.rbPepino.TabIndex = 0;
            this.rbPepino.TabStop = true;
            this.rbPepino.Text = "Pepino";
            this.rbPepino.UseVisualStyleBackColor = true;
            this.rbPepino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtGaseosa
            // 
            this.txtGaseosa.Location = new System.Drawing.Point(97, 355);
            this.txtGaseosa.Name = "txtGaseosa";
            this.txtGaseosa.Size = new System.Drawing.Size(100, 23);
            this.txtGaseosa.TabIndex = 34;
            this.txtGaseosa.TextChanged += new System.EventHandler(this.txtGaseosa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(97, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cupon de Descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(97, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Bebida";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Location = new System.Drawing.Point(491, 24);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(0, 15);
            this.lblDia.TabIndex = 37;
            this.lblDia.Click += new System.EventHandler(this.lblDia_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCombos
            // 
            this.dgvCombos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCombos.Location = new System.Drawing.Point(251, 203);
            this.dgvCombos.Name = "dgvCombos";
            this.dgvCombos.RowTemplate.Height = 25;
            this.dgvCombos.Size = new System.Drawing.Size(240, 150);
            this.dgvCombos.TabIndex = 40;
            this.dgvCombos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCombos_CellContentClick);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(562, 727);
            this.Controls.Add(this.dgvCombos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGaseosa);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.cbCombo);
            this.Controls.Add(this.cbHamburguesas);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "McDonalds\'s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.ComboBox cbHamburguesas;
        private System.Windows.Forms.ComboBox cbCombo;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rbPepino;
        private System.Windows.Forms.TextBox txtGaseosa;
        private System.Windows.Forms.RadioButton rbKetchup;
        private System.Windows.Forms.RadioButton rbMostaza;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbCebolla;
        private System.Windows.Forms.RadioButton rbMayo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCombos;
    }
}

