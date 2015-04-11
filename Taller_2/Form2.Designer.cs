namespace Taller_2
{
    partial class Form2
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
            this.lbldirr = new System.Windows.Forms.Label();
            this.txtbxdirr = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnend = new System.Windows.Forms.Button();
            this.txtbxpass = new System.Windows.Forms.TextBox();
            this.txtbxuser = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbeligebd = new System.Windows.Forms.ComboBox();
            this.lblselecbd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtable = new System.Windows.Forms.ComboBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldirr
            // 
            this.lbldirr.AutoSize = true;
            this.lbldirr.Location = new System.Drawing.Point(6, 32);
            this.lbldirr.Name = "lbldirr";
            this.lbldirr.Size = new System.Drawing.Size(136, 13);
            this.lbldirr.TabIndex = 0;
            this.lbldirr.Text = "Dirrecion del servidor SQL: ";
            this.lbldirr.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbxdirr
            // 
            this.txtbxdirr.Location = new System.Drawing.Point(148, 29);
            this.txtbxdirr.Name = "txtbxdirr";
            this.txtbxdirr.Size = new System.Drawing.Size(172, 20);
            this.txtbxdirr.TabIndex = 1;
            this.txtbxdirr.Text = "192.168.10.100";
            this.txtbxdirr.TextChanged += new System.EventHandler(this.txtbxdirr_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnend);
            this.groupBox1.Controls.Add(this.txtbxpass);
            this.groupBox1.Controls.Add(this.txtbxuser);
            this.groupBox1.Controls.Add(this.lblpass);
            this.groupBox1.Controls.Add(this.lbluser);
            this.groupBox1.Controls.Add(this.btnstart);
            this.groupBox1.Controls.Add(this.txtbxdirr);
            this.groupBox1.Controls.Add(this.lbldirr);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnend
            // 
            this.btnend.Enabled = false;
            this.btnend.Location = new System.Drawing.Point(222, 149);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(110, 23);
            this.btnend.TabIndex = 8;
            this.btnend.Text = "Cerrar sesion";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // txtbxpass
            // 
            this.txtbxpass.Location = new System.Drawing.Point(148, 100);
            this.txtbxpass.Name = "txtbxpass";
            this.txtbxpass.PasswordChar = '•';
            this.txtbxpass.Size = new System.Drawing.Size(172, 20);
            this.txtbxpass.TabIndex = 7;
            this.txtbxpass.Text = "MasterKey.1";
            this.txtbxpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            // 
            // txtbxuser
            // 
            this.txtbxuser.Location = new System.Drawing.Point(148, 64);
            this.txtbxuser.Name = "txtbxuser";
            this.txtbxuser.Size = new System.Drawing.Size(172, 20);
            this.txtbxuser.TabIndex = 6;
            this.txtbxuser.Text = "test_1";
            this.txtbxuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(75, 103);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(67, 13);
            this.lblpass.TabIndex = 5;
            this.lblpass.Text = "Contraseña: ";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(93, 67);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(49, 13);
            this.lbluser.TabIndex = 4;
            this.lbluser.Text = "Usuario: ";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(32, 149);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(110, 23);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "Iniciar sesion";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btntest1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbtable);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbeligebd);
            this.groupBox2.Controls.Add(this.lblselecbd);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 106);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base de datos";
            // 
            // cmbeligebd
            // 
            this.cmbeligebd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbeligebd.FormattingEnabled = true;
            this.cmbeligebd.Location = new System.Drawing.Point(157, 36);
            this.cmbeligebd.Name = "cmbeligebd";
            this.cmbeligebd.Size = new System.Drawing.Size(185, 21);
            this.cmbeligebd.TabIndex = 1;
            this.cmbeligebd.SelectedIndexChanged += new System.EventHandler(this.comboeligebd_SelectedIndexChanged);
            // 
            // lblselecbd
            // 
            this.lblselecbd.AutoSize = true;
            this.lblselecbd.Location = new System.Drawing.Point(15, 39);
            this.lblselecbd.Name = "lblselecbd";
            this.lblselecbd.Size = new System.Drawing.Size(136, 13);
            this.lblselecbd.TabIndex = 0;
            this.lblselecbd.Text = "Selecciona base de datos: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar tabla: ";
            // 
            // cmbtable
            // 
            this.cmbtable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtable.FormattingEnabled = true;
            this.cmbtable.Location = new System.Drawing.Point(157, 71);
            this.cmbtable.Name = "cmbtable";
            this.cmbtable.Size = new System.Drawing.Size(185, 21);
            this.cmbtable.TabIndex = 3;
            this.cmbtable.SelectedIndexChanged += new System.EventHandler(this.cmbtable_SelectedIndexChanged);
            // 
            // btnnext
            // 
            this.btnnext.Enabled = false;
            this.btnnext.Location = new System.Drawing.Point(353, 328);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 5;
            this.btnnext.Text = "Conectar ->";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(12, 328);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Salir";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 360);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbldirr;
        private System.Windows.Forms.TextBox txtbxdirr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtbxpass;
        private System.Windows.Forms.TextBox txtbxuser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblselecbd;
        private System.Windows.Forms.ComboBox cmbeligebd;
        private System.Windows.Forms.ComboBox cmbtable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnexit;
    }
}