namespace cyberman_msa
{
    partial class PCForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.change_price = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(185, 19);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(192, 20);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio";
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(185, 71);
            this.inicio.Name = "inicio";
            this.inicio.ReadOnly = true;
            this.inicio.Size = new System.Drawing.Size(192, 20);
            this.inicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiempo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total";
            // 
            // tiempo
            // 
            this.tiempo.Location = new System.Drawing.Point(185, 97);
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.Size = new System.Drawing.Size(192, 20);
            this.tiempo.TabIndex = 6;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(185, 123);
            this.t.Name = "t";
            this.t.ReadOnly = true;
            this.t.Size = new System.Drawing.Size(192, 20);
            this.t.TabIndex = 7;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(302, 183);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "INICIAR";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(221, 183);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 9;
            this.btn_stop.Text = "DETENER";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(185, 45);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(192, 20);
            this.price.TabIndex = 11;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // change_price
            // 
            this.change_price.Location = new System.Drawing.Point(43, 183);
            this.change_price.Name = "change_price";
            this.change_price.Size = new System.Drawing.Size(120, 23);
            this.change_price.TabIndex = 12;
            this.change_price.Text = "CAMBIAR PRECIO";
            this.change_price.UseVisualStyleBackColor = true;
            this.change_price.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 245);
            this.Controls.Add(this.change_price);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.t);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "PCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver PC";
            this.Load += new System.EventHandler(this.PCForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tiempo;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button change_price;
    }
}