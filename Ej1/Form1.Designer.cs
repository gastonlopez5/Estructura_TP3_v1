namespace Ej1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbElemento = new System.Windows.Forms.TextBox();
            this.lvPilaA = new System.Windows.Forms.ListView();
            this.lvPilaB = new System.Windows.Forms.ListView();
            this.lvPilaC = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCargar = new System.Windows.Forms.Button();
            this.btPasar = new System.Windows.Forms.Button();
            this.btContiene = new System.Windows.Forms.Button();
            this.btSeparar = new System.Windows.Forms.Button();
            this.btInvertir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbContener = new System.Windows.Forms.TextBox();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ELEMENTO";
            // 
            // tbElemento
            // 
            this.tbElemento.Location = new System.Drawing.Point(197, 30);
            this.tbElemento.Name = "tbElemento";
            this.tbElemento.Size = new System.Drawing.Size(146, 20);
            this.tbElemento.TabIndex = 1;
            // 
            // lvPilaA
            // 
            this.lvPilaA.Location = new System.Drawing.Point(60, 241);
            this.lvPilaA.Name = "lvPilaA";
            this.lvPilaA.Size = new System.Drawing.Size(121, 165);
            this.lvPilaA.TabIndex = 2;
            this.lvPilaA.UseCompatibleStateImageBehavior = false;
            // 
            // lvPilaB
            // 
            this.lvPilaB.Location = new System.Drawing.Point(252, 241);
            this.lvPilaB.Name = "lvPilaB";
            this.lvPilaB.Size = new System.Drawing.Size(121, 165);
            this.lvPilaB.TabIndex = 3;
            this.lvPilaB.UseCompatibleStateImageBehavior = false;
            // 
            // lvPilaC
            // 
            this.lvPilaC.Location = new System.Drawing.Point(451, 241);
            this.lvPilaC.Name = "lvPilaC";
            this.lvPilaC.Size = new System.Drawing.Size(121, 165);
            this.lvPilaC.TabIndex = 4;
            this.lvPilaC.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "PILA A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "PILA B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "PILA C";
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(395, 27);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(97, 23);
            this.btCargar.TabIndex = 8;
            this.btCargar.Text = "CARGAR PILA A";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.BtCargar_Click);
            // 
            // btPasar
            // 
            this.btPasar.Location = new System.Drawing.Point(395, 83);
            this.btPasar.Name = "btPasar";
            this.btPasar.Size = new System.Drawing.Size(97, 23);
            this.btPasar.TabIndex = 9;
            this.btPasar.Text = "PASAR A PILA B";
            this.btPasar.UseVisualStyleBackColor = true;
            this.btPasar.Click += new System.EventHandler(this.BtPasar_Click);
            // 
            // btContiene
            // 
            this.btContiene.Location = new System.Drawing.Point(60, 127);
            this.btContiene.Name = "btContiene";
            this.btContiene.Size = new System.Drawing.Size(89, 23);
            this.btContiene.TabIndex = 10;
            this.btContiene.Text = "CONTENER";
            this.btContiene.UseVisualStyleBackColor = true;
            this.btContiene.Click += new System.EventHandler(this.BtContiene_Click);
            // 
            // btSeparar
            // 
            this.btSeparar.Location = new System.Drawing.Point(517, 83);
            this.btSeparar.Name = "btSeparar";
            this.btSeparar.Size = new System.Drawing.Size(89, 23);
            this.btSeparar.TabIndex = 11;
            this.btSeparar.Text = "SEPARAR";
            this.btSeparar.UseVisualStyleBackColor = true;
            this.btSeparar.Click += new System.EventHandler(this.BtSeparar_Click);
            // 
            // btInvertir
            // 
            this.btInvertir.Location = new System.Drawing.Point(395, 130);
            this.btInvertir.Name = "btInvertir";
            this.btInvertir.Size = new System.Drawing.Size(97, 23);
            this.btInvertir.TabIndex = 12;
            this.btInvertir.Text = "INVERTIR";
            this.btInvertir.UseVisualStyleBackColor = true;
            this.btInvertir.Click += new System.EventHandler(this.BtInvertir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contiene la Pila A el elemento?";
            // 
            // tbContener
            // 
            this.tbContener.Location = new System.Drawing.Point(200, 130);
            this.tbContener.Name = "tbContener";
            this.tbContener.Size = new System.Drawing.Size(143, 20);
            this.tbContener.TabIndex = 14;
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(517, 30);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(89, 23);
            this.btQuitar.TabIndex = 15;
            this.btQuitar.Text = "QUITAR";
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.BtQuitar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(517, 130);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(89, 23);
            this.btLimpiar.TabIndex = 16;
            this.btLimpiar.Text = "LIMPIAR";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.BtLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btQuitar);
            this.Controls.Add(this.tbContener);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btInvertir);
            this.Controls.Add(this.btSeparar);
            this.Controls.Add(this.btContiene);
            this.Controls.Add(this.btPasar);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvPilaC);
            this.Controls.Add(this.lvPilaB);
            this.Controls.Add(this.lvPilaA);
            this.Controls.Add(this.tbElemento);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbElemento;
        private System.Windows.Forms.ListView lvPilaA;
        private System.Windows.Forms.ListView lvPilaB;
        private System.Windows.Forms.ListView lvPilaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Button btPasar;
        private System.Windows.Forms.Button btContiene;
        private System.Windows.Forms.Button btSeparar;
        private System.Windows.Forms.Button btInvertir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbContener;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Button btLimpiar;
    }
}

