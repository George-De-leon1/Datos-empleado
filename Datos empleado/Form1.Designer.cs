namespace Datos_empleado
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
            btnGuardar = new Button();
            colorDialog1 = new ColorDialog();
            labelRegistro_empleado = new Label();
            textNombre = new TextBox();
            dateTimePickerFecha = new DateTimePicker();
            comboBoxGenero = new ComboBox();
            btnAbrir = new Button();
            btnSalir = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textID = new TextBox();
            textApellido = new TextBox();
            textCargo = new TextBox();
            textEmail = new TextBox();
            textTelefono = new TextBox();
            textDireccion = new TextBox();
            textSalario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labelTelefono = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(129, 442);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // labelRegistro_empleado
            // 
            labelRegistro_empleado.AutoSize = true;
            labelRegistro_empleado.Font = new Font("Segoe UI", 15F);
            labelRegistro_empleado.Location = new Point(338, 69);
            labelRegistro_empleado.Margin = new Padding(4, 0, 4, 0);
            labelRegistro_empleado.Name = "labelRegistro_empleado";
            labelRegistro_empleado.Size = new Size(212, 28);
            labelRegistro_empleado.TabIndex = 2;
            labelRegistro_empleado.Text = "Registro de Empleados";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(87, 214);
            textNombre.Margin = new Padding(4, 3, 4, 3);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 3;
            textNombre.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.Location = new Point(583, 217);
            dateTimePickerFecha.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(200, 23);
            dateTimePickerFecha.TabIndex = 4;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(583, 160);
            comboBoxGenero.Margin = new Padding(4, 3, 4, 3);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 5;
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = Color.White;
            btnAbrir.FlatStyle = FlatStyle.Flat;
            btnAbrir.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnAbrir.ForeColor = Color.Black;
            btnAbrir.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrir.Location = new Point(416, 442);
            btnAbrir.Margin = new Padding(4, 3, 4, 3);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(100, 35);
            btnAbrir.TabIndex = 6;
            btnAbrir.Text = "Abrir";
            btnAbrir.TextAlign = ContentAlignment.MiddleRight;
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnSalir.ForeColor = Color.Black;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(683, 442);
            btnSalir.Margin = new Padding(4, 3, 4, 3);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 35);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // textID
            // 
            textID.Location = new Point(87, 157);
            textID.Margin = new Padding(4, 3, 4, 3);
            textID.Name = "textID";
            textID.Size = new Size(100, 23);
            textID.TabIndex = 8;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(87, 263);
            textApellido.Margin = new Padding(4, 3, 4, 3);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 9;
            // 
            // textCargo
            // 
            textCargo.Location = new Point(326, 264);
            textCargo.Margin = new Padding(4, 3, 4, 3);
            textCargo.Name = "textCargo";
            textCargo.Size = new Size(100, 23);
            textCargo.TabIndex = 10;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(326, 214);
            textEmail.Margin = new Padding(4, 3, 4, 3);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(100, 23);
            textEmail.TabIndex = 11;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(326, 160);
            textTelefono.Margin = new Padding(4, 3, 4, 3);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(100, 23);
            textTelefono.TabIndex = 12;
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(87, 313);
            textDireccion.Margin = new Padding(4, 3, 4, 3);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(100, 23);
            textDireccion.TabIndex = 12;
            // 
            // textSalario
            // 
            textSalario.Location = new Point(326, 308);
            textSalario.Margin = new Padding(4, 3, 4, 3);
            textSalario.Name = "textSalario";
            textSalario.Size = new Size(100, 23);
            textSalario.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 160);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 14;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 217);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 15;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 267);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 16;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 316);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Direccion";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(267, 163);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(52, 15);
            labelTelefono.TabIndex = 18;
            labelTelefono.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 223);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 19;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(267, 270);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 20;
            label7.Text = "Cargo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(267, 316);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 21;
            label8.Text = "Salario";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(525, 168);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 22;
            label9.Text = "Genero";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(474, 222);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 23;
            label10.Text = "Fecha de ingreso";
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 516);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelTelefono);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textSalario);
            Controls.Add(textDireccion);
            Controls.Add(textTelefono);
            Controls.Add(textEmail);
            Controls.Add(textCargo);
            Controls.Add(textApellido);
            Controls.Add(textID);
            Controls.Add(btnSalir);
            Controls.Add(btnAbrir);
            Controls.Add(comboBoxGenero);
            Controls.Add(dateTimePickerFecha);
            Controls.Add(textNombre);
            Controls.Add(labelRegistro_empleado);
            Controls.Add(btnGuardar);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private ColorDialog colorDialog1;
        private Label labelRegistro_empleado;
        private TextBox textNombre;
        private DateTimePicker dateTimePickerFecha;
        private ComboBox comboBoxGenero;
        private Button btnAbrir;
        private Button btnSalir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textID;
        private TextBox textApellido;
        private TextBox textCargo;
        private TextBox textEmail;
        private TextBox textTelefono;
        private TextBox textDireccion;
        private TextBox textSalario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labelTelefono;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
