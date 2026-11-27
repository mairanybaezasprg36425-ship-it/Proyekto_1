/*
 * Creado por SharpDevelop.
 * Usuario: elmak
 * Fecha: 26/11/2026
 * Hora: 12:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto_1
{
	partial class Programa3
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtPalabra = new System.Windows.Forms.TextBox();
			this.btnImprimir = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(169, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ingrese una palabra:";
			// 
			// txtPalabra
			// 
			this.txtPalabra.Location = new System.Drawing.Point(133, 87);
			this.txtPalabra.Name = "txtPalabra";
			this.txtPalabra.Size = new System.Drawing.Size(241, 26);
			this.txtPalabra.TabIndex = 1;
			// 
			// btnImprimir
			// 
			this.btnImprimir.Location = new System.Drawing.Point(169, 263);
			this.btnImprimir.Name = "btnImprimir";
			this.btnImprimir.Size = new System.Drawing.Size(149, 34);
			this.btnImprimir.TabIndex = 2;
			this.btnImprimir.Text = "boop";
			this.btnImprimir.UseVisualStyleBackColor = true;
			this.btnImprimir.Click += new System.EventHandler(this.BtnImprimirClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(109, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(297, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Haga click aqui para imprimirla al revez";
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(109, 160);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(297, 23);
			this.lblResultado.TabIndex = 4;
			// 
			// Programa3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 379);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnImprimir);
			this.Controls.Add(this.txtPalabra);
			this.Controls.Add(this.label1);
			this.Name = "Programa3";
			this.Text = "Programa3";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.TextBox txtPalabra;
		private System.Windows.Forms.Label label1;
	}
}
