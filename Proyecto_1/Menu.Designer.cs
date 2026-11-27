/*
 * Creado por SharpDevelop.
 * Usuario: elmak
 * Fecha: 26/11/2026
 * Hora: 12:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_1
{
	partial class Menu
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnPrograma1 = new System.Windows.Forms.Button();
			this.btnPrograma2 = new System.Windows.Forms.Button();
			this.btnPrograma3 = new System.Windows.Forms.Button();
			this.btnPrograma4 = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(644, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Stencil", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(76, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(484, 47);
			this.label1.TabIndex = 1;
			this.label1.Text = "ELIJA EL PROGRAMA A EJECUTAR";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(101, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Programa 1:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(457, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Programa 2:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(101, 305);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Programa 3:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(457, 305);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Programa 4:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(34, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(253, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Arreglo Menor a Mayor";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(379, 169);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(253, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "Arreglo Menor a Mayor";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(379, 338);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(253, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "Arreglo Menor a Mayor";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(24, 338);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(253, 23);
			this.label11.TabIndex = 12;
			this.label11.Text = "Arreglo Menor a Mayor";
			// 
			// btnPrograma1
			// 
			this.btnPrograma1.Location = new System.Drawing.Point(76, 219);
			this.btnPrograma1.Name = "btnPrograma1";
			this.btnPrograma1.Size = new System.Drawing.Size(151, 42);
			this.btnPrograma1.TabIndex = 13;
			this.btnPrograma1.Text = "Boop";
			this.btnPrograma1.UseVisualStyleBackColor = true;
			// 
			// btnPrograma2
			// 
			this.btnPrograma2.Location = new System.Drawing.Point(428, 219);
			this.btnPrograma2.Name = "btnPrograma2";
			this.btnPrograma2.Size = new System.Drawing.Size(151, 42);
			this.btnPrograma2.TabIndex = 14;
			this.btnPrograma2.Text = "Boop";
			this.btnPrograma2.UseVisualStyleBackColor = true;
			// 
			// btnPrograma3
			// 
			this.btnPrograma3.Location = new System.Drawing.Point(76, 407);
			this.btnPrograma3.Name = "btnPrograma3";
			this.btnPrograma3.Size = new System.Drawing.Size(151, 42);
			this.btnPrograma3.TabIndex = 15;
			this.btnPrograma3.Text = "Boop";
			this.btnPrograma3.UseVisualStyleBackColor = true;
			this.btnPrograma3.Click += new System.EventHandler(this.BtnPrograma3Click);
			// 
			// btnPrograma4
			// 
			this.btnPrograma4.Location = new System.Drawing.Point(428, 407);
			this.btnPrograma4.Name = "btnPrograma4";
			this.btnPrograma4.Size = new System.Drawing.Size(151, 42);
			this.btnPrograma4.TabIndex = 16;
			this.btnPrograma4.Text = "Boop";
			this.btnPrograma4.UseVisualStyleBackColor = true;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 523);
			this.Controls.Add(this.btnPrograma4);
			this.Controls.Add(this.btnPrograma3);
			this.Controls.Add(this.btnPrograma2);
			this.Controls.Add(this.btnPrograma1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Menu";
			this.Text = "Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnPrograma4;
		private System.Windows.Forms.Button btnPrograma3;
		private System.Windows.Forms.Button btnPrograma2;
		private System.Windows.Forms.Button btnPrograma1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
