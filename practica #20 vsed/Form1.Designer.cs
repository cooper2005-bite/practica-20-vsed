namespace practica__20_vsed
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
            lblTitulo = new Label();
            lblEdad = new Label();
            txtEdad = new TextBox();
            btnDeterminarCategoria = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Cooper Black", 15.75F);
            lblTitulo.Location = new Point(65, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(403, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\"determinacion de categoria de edad\"";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Cooper Black", 15.75F);
            lblEdad.Location = new Point(75, 102);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(189, 24);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "\"ingrese su edad\"";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Cooper Black", 14.25F);
            txtEdad.Location = new Point(293, 99);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(121, 29);
            txtEdad.TabIndex = 2;
            // 
            // btnDeterminarCategoria
            // 
            btnDeterminarCategoria.Font = new Font("Cooper Black", 14.25F);
            btnDeterminarCategoria.Location = new Point(158, 191);
            btnDeterminarCategoria.Name = "btnDeterminarCategoria";
            btnDeterminarCategoria.Size = new Size(172, 58);
            btnDeterminarCategoria.TabIndex = 3;
            btnDeterminarCategoria.Text = "determinar categoria";
            btnDeterminarCategoria.UseVisualStyleBackColor = true;
            btnDeterminarCategoria.Click += btnDeterminarCategoria_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(177, 280);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(127, 24);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "\"categoria\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrchid;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnDeterminarCategoria);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblEdad;
        private TextBox txtEdad;
        private Button btnDeterminarCategoria;
        private Label lblResultado;
    }
}
