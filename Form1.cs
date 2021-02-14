using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _OLC2_Proyecto1_201709029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                //FileChooser
                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Filter = "Documento de carga | *.txt";
                abrir.Title = "Cargar archivo";
                abrir.ShowDialog();

                //Lector. Le mandamos la ruta del archivo seleccionado
                StreamReader leer = new StreamReader(abrir.FileName);

                richTextBox2.Text = leer.ReadToEnd();

                String RutaArchivoAbierto = abrir.FileName;
                //Cerrar lector
                leer.Close();
            }
            catch (Exception)
            {

            }
        }

    }
}
