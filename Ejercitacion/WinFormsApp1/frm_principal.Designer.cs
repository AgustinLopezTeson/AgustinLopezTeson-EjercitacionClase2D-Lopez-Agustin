namespace WinFormsApp1
{
    partial class frm_principal
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
            this.btn_Saludar = new System.Windows.Forms.Button();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Saludar
            // 
            this.btn_Saludar.Location = new System.Drawing.Point(362, 124);
            this.btn_Saludar.Name = "btn_Saludar";
            this.btn_Saludar.Size = new System.Drawing.Size(94, 29);
            this.btn_Saludar.TabIndex = 0;
            this.btn_Saludar.Text = "Saludar";
            this.btn_Saludar.UseVisualStyleBackColor = true;
            this.btn_Saludar.Click += new System.EventHandler(this.btn_Saludar_Click);
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(284, 67);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(172, 27);
            this.tb_apellido.TabIndex = 1;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(29, 67);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(174, 27);
            this.tb_nombre.TabIndex = 2;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nombre.Location = new System.Drawing.Point(29, 28);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(67, 20);
            this.lb_nombre.TabIndex = 3;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_apellido.Location = new System.Drawing.Point(284, 28);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(67, 20);
            this.lb_apellido.TabIndex = 4;
            this.lb_apellido.Text = "Apellido";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 184);
            this.Controls.Add(this.lb_apellido);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.btn_Saludar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola,Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Saludar;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_apellido;
    }
}
