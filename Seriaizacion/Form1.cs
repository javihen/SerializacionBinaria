using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//lIBRERIAS NECESARIAS PARA LA SERIAIZACION
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Seriaizacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsSerializar_Click(object sender, EventArgs e)
        {
            //objeto de la clase SaveFileDialog
            SaveFileDialog sv = new SaveFileDialog();
            //Ddefinir el tipo de archivo
            sv.Filter = "Archivo Binario | *.bin";
            //Mostramos el de dialogo de la grabacion
            if(sv.ShowDialog() == DialogResult.OK)
            {
                //Crear el archivo binario
                using (FileStream fs = new FileStream(sv.FileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs,txtCadena.Text);
                }
            }
        }

        private void tsDeserializar_Click(object sender, EventArgs e)
        {
            //Objeto de la clase OpenFileDialog
            OpenFileDialog op = new OpenFileDialog();

            //definir el tipo de archivo a abrir
            op.Filter = "Archivo binario | *.bin";

            //mostrar el cuadro de dialogo
            if(op.ShowDialog() == DialogResult.OK)
            {
                //abriendo el archivo binario
                using (FileStream fs = new FileStream(op.FileName, FileMode.Open))
                {
                    //creamos e objeto Formato binario
                    BinaryFormatter bf = new BinaryFormatter();
                    txtCadena.Text = bf.Deserialize(fs).ToString();
                }
            }
        }

















        private void tsSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


















        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        
    }
}
