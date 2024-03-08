namespace Ejercicio1_Captura_datos
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
            lbl_1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_nombre = new TextBox();
            txt_matricula = new TextBox();
            txt_carrera = new TextBox();
            txt_edad = new TextBox();
            txt_apellido = new TextBox();
            btnImprimir = new Button();
            btn_limpiar = new Button();
            btn_cerrar = new Button();
            label6 = new Label();
            label7 = new Label();
            lblDatos_Nombre = new Label();
            lblDatos_Carrera = new Label();
            lblDatos_Matricula = new Label();
            lblDatos_Apellido = new Label();
            lblDatos_Edad = new Label();
            SuspendLayout();
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_1.Location = new Point(56, 45);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(159, 21);
            lbl_1.TabIndex = 0;
            lbl_1.Text = "Datos del Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(56, 147);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(51, 176);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Carrera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(32, 205);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Matricula";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 119);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "label5";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(95, 86);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 5;
            // 
            // txt_matricula
            // 
            txt_matricula.Location = new Point(95, 202);
            txt_matricula.Name = "txt_matricula";
            txt_matricula.Size = new Size(100, 23);
            txt_matricula.TabIndex = 6;
            // 
            // txt_carrera
            // 
            txt_carrera.Location = new Point(95, 173);
            txt_carrera.Name = "txt_carrera";
            txt_carrera.Size = new Size(100, 23);
            txt_carrera.TabIndex = 7;
            // 
            // txt_edad
            // 
            txt_edad.Location = new Point(95, 144);
            txt_edad.Name = "txt_edad";
            txt_edad.Size = new Size(100, 23);
            txt_edad.TabIndex = 8;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(95, 115);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 9;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.FromArgb(0, 192, 0);
            btnImprimir.Location = new Point(477, 86);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 10;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.Yellow;
            btn_limpiar.Location = new Point(477, 115);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(75, 23);
            btn_limpiar.TabIndex = 11;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.BackColor = Color.Red;
            btn_cerrar.Location = new Point(477, 144);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(75, 23);
            btn_cerrar.TabIndex = 12;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(38, 89);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(38, 119);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "Apellido";
            // 
            // lblDatos_Nombre
            // 
            lblDatos_Nombre.AutoSize = true;
            lblDatos_Nombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDatos_Nombre.Location = new Point(275, 94);
            lblDatos_Nombre.Name = "lblDatos_Nombre";
            lblDatos_Nombre.Size = new Size(77, 15);
            lblDatos_Nombre.TabIndex = 15;
            lblDatos_Nombre.Text = "Esperando.....";
            // 
            // lblDatos_Carrera
            // 
            lblDatos_Carrera.AutoSize = true;
            lblDatos_Carrera.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDatos_Carrera.Location = new Point(275, 148);
            lblDatos_Carrera.Name = "lblDatos_Carrera";
            lblDatos_Carrera.Size = new Size(77, 15);
            lblDatos_Carrera.TabIndex = 16;
            lblDatos_Carrera.Text = "Esperando.....";
            // 
            // lblDatos_Matricula
            // 
            lblDatos_Matricula.AutoSize = true;
            lblDatos_Matricula.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDatos_Matricula.Location = new Point(275, 205);
            lblDatos_Matricula.Name = "lblDatos_Matricula";
            lblDatos_Matricula.Size = new Size(77, 15);
            lblDatos_Matricula.TabIndex = 17;
            lblDatos_Matricula.Text = "Esperando.....";
            // 
            // lblDatos_Apellido
            // 
            lblDatos_Apellido.AutoSize = true;
            lblDatos_Apellido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDatos_Apellido.Location = new Point(275, 119);
            lblDatos_Apellido.Name = "lblDatos_Apellido";
            lblDatos_Apellido.Size = new Size(77, 15);
            lblDatos_Apellido.TabIndex = 18;
            lblDatos_Apellido.Text = "Esperando.....";
            // 
            // lblDatos_Edad
            // 
            lblDatos_Edad.AutoSize = true;
            lblDatos_Edad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDatos_Edad.Location = new Point(275, 176);
            lblDatos_Edad.Name = "lblDatos_Edad";
            lblDatos_Edad.Size = new Size(77, 15);
            lblDatos_Edad.TabIndex = 19;
            lblDatos_Edad.Text = "Esperando.....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(573, 289);
            Controls.Add(lblDatos_Edad);
            Controls.Add(lblDatos_Apellido);
            Controls.Add(lblDatos_Matricula);
            Controls.Add(lblDatos_Carrera);
            Controls.Add(lblDatos_Nombre);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_limpiar);
            Controls.Add(btnImprimir);
            Controls.Add(txt_apellido);
            Controls.Add(txt_edad);
            Controls.Add(txt_carrera);
            Controls.Add(txt_matricula);
            Controls.Add(txt_nombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_nombre;
        private TextBox txt_matricula;
        private TextBox txt_carrera;
        private TextBox txt_edad;
        private TextBox txt_apellido;
        private Button btnImprimir;
        private Button btn_limpiar;
        private Button btn_cerrar;
        private Label label6;
        private Label label7;
        private Label lblDatos_Nombre;
        private Label lblDatos_Carrera;
        private Label lblDatos_Matricula;
        private Label lblDatos_Apellido;
        private Label lblDatos_Edad;
    }
}
