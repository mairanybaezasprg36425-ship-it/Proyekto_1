/*
 * Creado por SharpDevelop.
 * Usuario: elmak
 * Fecha: 26/11/2026
 * Hora: 12:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_1
{
	/// <summary>
	/// Description of Programa3.
	/// </summary>
	public partial class Programa3 : Form
	{
		public Programa3()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnImprimirClick(object sender, EventArgs e)
		{
			string palabra = txtPalabra.Text;

		    char[] caracteres = palabra.ToCharArray();
		    Array.Reverse(caracteres);
		    string palabraAlReves = new string(caracteres);
		
		    lblResultado.Text = palabraAlReves;
		}
	}
}
