/*
 * Creado por SharpDevelop.
 * Usuario: elmak
 * Fecha: 26/11/2026
 * Hora: 12:02 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_1
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnPrograma3Click(object sender, EventArgs e)
		{
				Programa3 P = new Programa3();
				P.Show();
				this.Hide();			
		}
	}
}

//prueba
