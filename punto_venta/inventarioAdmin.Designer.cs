namespace punto_venta
{
    partial class inventarioAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventarioAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msjBienvenida = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.rbttProductAgotados = new System.Windows.Forms.RadioButton();
            this.rbttVerTodo = new System.Windows.Forms.RadioButton();
            this.rbttProductExistentes = new System.Windows.Forms.RadioButton();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agotado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbViewProduct = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.bttEliminarProducto = new System.Windows.Forms.Button();
            this.bttGuardarCambios = new System.Windows.Forms.Button();
            this.txtAgotado = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbAgotado = new System.Windows.Forms.Label();
            this.lbFechaIngreso = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.imgProduct = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbViewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.msjBienvenida);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 65);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Realizar Venta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estadísticas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuarios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // msjBienvenida
            // 
            this.msjBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msjBienvenida.AutoSize = true;
            this.msjBienvenida.Location = new System.Drawing.Point(842, 16);
            this.msjBienvenida.Name = "msjBienvenida";
            this.msjBienvenida.Size = new System.Drawing.Size(66, 13);
            this.msjBienvenida.TabIndex = 4;
            this.msjBienvenida.Text = "¡Bienvenido!";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::punto_venta.Properties.Resources.icon_ventas;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(200, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 34);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::punto_venta.Properties.Resources.icon_datos2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(138, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 34);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::punto_venta.Properties.Resources.icon_empleados;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(76, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 33);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(6, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 33);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::punto_venta.Properties.Resources.icon_add;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(12, 86);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 54);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nuevo\nProducto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.rbttProductAgotados);
            this.gbBusqueda.Controls.Add(this.rbttVerTodo);
            this.gbBusqueda.Controls.Add(this.rbttProductExistentes);
            this.gbBusqueda.Controls.Add(this.bttBuscar);
            this.gbBusqueda.Controls.Add(this.tbBuscar);
            this.gbBusqueda.Location = new System.Drawing.Point(90, 86);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Size = new System.Drawing.Size(638, 83);
            this.gbBusqueda.TabIndex = 7;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Buscar:";
            // 
            // rbttProductAgotados
            // 
            this.rbttProductAgotados.AutoSize = true;
            this.rbttProductAgotados.Location = new System.Drawing.Point(230, 48);
            this.rbttProductAgotados.Name = "rbttProductAgotados";
            this.rbttProductAgotados.Size = new System.Drawing.Size(143, 17);
            this.rbttProductAgotados.TabIndex = 4;
            this.rbttProductAgotados.Text = "Solo productos agotados";
            this.rbttProductAgotados.UseVisualStyleBackColor = true;
            // 
            // rbttVerTodo
            // 
            this.rbttVerTodo.AutoSize = true;
            this.rbttVerTodo.Checked = true;
            this.rbttVerTodo.Location = new System.Drawing.Point(7, 48);
            this.rbttVerTodo.Name = "rbttVerTodo";
            this.rbttVerTodo.Size = new System.Drawing.Size(65, 17);
            this.rbttVerTodo.TabIndex = 3;
            this.rbttVerTodo.TabStop = true;
            this.rbttVerTodo.Text = "Ver todo";
            this.rbttVerTodo.UseVisualStyleBackColor = true;
            // 
            // rbttProductExistentes
            // 
            this.rbttProductExistentes.AutoSize = true;
            this.rbttProductExistentes.Location = new System.Drawing.Point(78, 48);
            this.rbttProductExistentes.Name = "rbttProductExistentes";
            this.rbttProductExistentes.Size = new System.Drawing.Size(146, 17);
            this.rbttProductExistentes.TabIndex = 2;
            this.rbttProductExistentes.Text = "Solo productos existentes";
            this.rbttProductExistentes.UseVisualStyleBackColor = true;
            // 
            // bttBuscar
            // 
            this.bttBuscar.Location = new System.Drawing.Point(271, 19);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttBuscar.TabIndex = 1;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = true;
            // 
            // tbBuscar
            // 
            this.tbBuscar.AccessibleDescription = "";
            this.tbBuscar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbBuscar.Location = new System.Drawing.Point(6, 19);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(259, 20);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.Tag = "";
            this.tbBuscar.Text = "Ingrese nombre, categoría o descripción";
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_enter);
            this.tbBuscar.Leave += new System.EventHandler(this.tbBuscar_leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom,
            this.categoria,
            this.precio,
            this.cantidad,
            this.fechaingreso,
            this.descripcion,
            this.agotado});
            this.dataGridView1.Location = new System.Drawing.Point(88, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 361);
            this.dataGridView1.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // fechaingreso
            // 
            this.fechaingreso.HeaderText = "Fecha de ingreso";
            this.fechaingreso.Name = "fechaingreso";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descrición";
            this.descripcion.Name = "descripcion";
            // 
            // agotado
            // 
            this.agotado.HeaderText = "Agotado";
            this.agotado.Name = "agotado";
            // 
            // gbViewProduct
            // 
            this.gbViewProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.gbViewProduct.Controls.Add(this.textBox1);
            this.gbViewProduct.Controls.Add(this.lbDescripcion);
            this.gbViewProduct.Controls.Add(this.bttEliminarProducto);
            this.gbViewProduct.Controls.Add(this.bttGuardarCambios);
            this.gbViewProduct.Controls.Add(this.txtAgotado);
            this.gbViewProduct.Controls.Add(this.txtFecha);
            this.gbViewProduct.Controls.Add(this.tbCantidad);
            this.gbViewProduct.Controls.Add(this.tbPrecio);
            this.gbViewProduct.Controls.Add(this.tbCategoria);
            this.gbViewProduct.Controls.Add(this.tbNombre);
            this.gbViewProduct.Controls.Add(this.lbAgotado);
            this.gbViewProduct.Controls.Add(this.lbFechaIngreso);
            this.gbViewProduct.Controls.Add(this.lbCantidad);
            this.gbViewProduct.Controls.Add(this.lbPrecio);
            this.gbViewProduct.Controls.Add(this.lbCategoria);
            this.gbViewProduct.Controls.Add(this.lbNombre);
            this.gbViewProduct.Controls.Add(this.imgProduct);
            this.gbViewProduct.Location = new System.Drawing.Point(746, 105);
            this.gbViewProduct.Name = "gbViewProduct";
            this.gbViewProduct.Size = new System.Drawing.Size(247, 450);
            this.gbViewProduct.TabIndex = 10;
            this.gbViewProduct.TabStop = false;
            this.gbViewProduct.Text = "Vizualizar Producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 16;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(7, 324);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbDescripcion.TabIndex = 15;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // bttEliminarProducto
            // 
            this.bttEliminarProducto.Location = new System.Drawing.Point(138, 399);
            this.bttEliminarProducto.Name = "bttEliminarProducto";
            this.bttEliminarProducto.Size = new System.Drawing.Size(92, 35);
            this.bttEliminarProducto.TabIndex = 14;
            this.bttEliminarProducto.Text = "Eliminar Producto";
            this.bttEliminarProducto.UseVisualStyleBackColor = true;
            // 
            // bttGuardarCambios
            // 
            this.bttGuardarCambios.Location = new System.Drawing.Point(21, 399);
            this.bttGuardarCambios.Name = "bttGuardarCambios";
            this.bttGuardarCambios.Size = new System.Drawing.Size(92, 35);
            this.bttGuardarCambios.TabIndex = 13;
            this.bttGuardarCambios.Text = "Guardar cambios";
            this.bttGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // txtAgotado
            // 
            this.txtAgotado.AutoSize = true;
            this.txtAgotado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgotado.Location = new System.Drawing.Point(65, 371);
            this.txtAgotado.Name = "txtAgotado";
            this.txtAgotado.Size = new System.Drawing.Size(18, 16);
            this.txtAgotado.TabIndex = 12;
            this.txtAgotado.Text = "- -";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(107, 354);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(47, 16);
            this.txtFecha.TabIndex = 11;
            this.txtFecha.Text = "--/--/----";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(70, 286);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 10;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(70, 249);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 9;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Location = new System.Drawing.Point(70, 218);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbCategoria.TabIndex = 8;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(70, 186);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 7;
            // 
            // lbAgotado
            // 
            this.lbAgotado.AutoSize = true;
            this.lbAgotado.Location = new System.Drawing.Point(9, 373);
            this.lbAgotado.Name = "lbAgotado";
            this.lbAgotado.Size = new System.Drawing.Size(50, 13);
            this.lbAgotado.TabIndex = 6;
            this.lbAgotado.Text = "Agotado:";
            // 
            // lbFechaIngreso
            // 
            this.lbFechaIngreso.AutoSize = true;
            this.lbFechaIngreso.Location = new System.Drawing.Point(9, 354);
            this.lbFechaIngreso.Name = "lbFechaIngreso";
            this.lbFechaIngreso.Size = new System.Drawing.Size(92, 13);
            this.lbFechaIngreso.TabIndex = 5;
            this.lbFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(7, 291);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(52, 13);
            this.lbCantidad.TabIndex = 4;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(7, 254);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(49, 13);
            this.lbPrecio.TabIndex = 3;
            this.lbPrecio.Text = "Precio: $";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(7, 222);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(57, 13);
            this.lbCategoria.TabIndex = 2;
            this.lbCategoria.Text = "Categoría:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(7, 189);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // imgProduct
            // 
            this.imgProduct.Location = new System.Drawing.Point(6, 19);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(224, 144);
            this.imgProduct.TabIndex = 0;
            this.imgProduct.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inventarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 578);
            this.Controls.Add(this.gbViewProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Name = "inventarioAdmin";
            this.Tag = "";
            this.Text = "inventarioAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbViewProduct.ResumeLayout(false);
            this.gbViewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label msjBienvenida;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.RadioButton rbttProductAgotados;
        private System.Windows.Forms.RadioButton rbttVerTodo;
        private System.Windows.Forms.RadioButton rbttProductExistentes;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn agotado;
        private System.Windows.Forms.GroupBox gbViewProduct;
        private System.Windows.Forms.Label lbAgotado;
        private System.Windows.Forms.Label lbFechaIngreso;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox imgProduct;
        private System.Windows.Forms.Button bttEliminarProducto;
        private System.Windows.Forms.Button bttGuardarCambios;
        private System.Windows.Forms.Label txtAgotado;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbCategoria;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}