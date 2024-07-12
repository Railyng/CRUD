namespace CapaPresentacion
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            cNProductosBindingSource = new BindingSource(components);
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDesc = new TextBox();
            label3 = new Label();
            txtmarca = new TextBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            btnGuaradar = new Button();
            cNProductosBindingSource1 = new BindingSource(components);
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cNProductosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cNProductosBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(532, 248);
            dataGridView1.TabIndex = 0;
            // 
            // cNProductosBindingSource
            // 
            cNProductosBindingSource.DataSource = typeof(CapaNegocio.CN_Productos);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(643, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(575, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(550, 67);
            label2.Name = "label2";
            label2.Size = new Size(88, 18);
            label2.TabIndex = 4;
            label2.Text = "Descripcion:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(643, 67);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(157, 23);
            txtDesc.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(577, 119);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 6;
            label3.Text = "Marca:";
            // 
            // txtmarca
            // 
            txtmarca.Location = new Point(643, 116);
            txtmarca.Name = "txtmarca";
            txtmarca.Size = new Size(157, 23);
            txtmarca.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(577, 164);
            label4.Name = "label4";
            label4.Size = new Size(52, 18);
            label4.TabIndex = 8;
            label4.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(643, 161);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(157, 23);
            txtPrecio.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Modern No. 20", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(577, 220);
            label5.Name = "label5";
            label5.Size = new Size(46, 18);
            label5.TabIndex = 10;
            label5.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(643, 217);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(157, 23);
            txtStock.TabIndex = 9;
            // 
            // btnGuaradar
            // 
            btnGuaradar.Location = new Point(615, 264);
            btnGuaradar.Name = "btnGuaradar";
            btnGuaradar.Size = new Size(166, 35);
            btnGuaradar.TabIndex = 11;
            btnGuaradar.Text = "GUARDAR";
            btnGuaradar.UseVisualStyleBackColor = true;
            btnGuaradar.Click += btnGuaradar_Click;
            // 
            // cNProductosBindingSource1
            // 
            cNProductosBindingSource1.DataSource = typeof(CapaNegocio.CN_Productos);
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 266);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 29);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(145, 266);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 29);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(829, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuaradar);
            Controls.Add(label5);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtmarca);
            Controls.Add(label2);
            Controls.Add(txtDesc);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cNProductosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cNProductosBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtDesc;
        private Label label3;
        private TextBox txtmarca;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtStock;
        private Button btnGuaradar;
        private BindingSource cNProductosBindingSource;
        private BindingSource cNProductosBindingSource1;
        private Button btnEditar;
        private Button btnEliminar;
    }
}
