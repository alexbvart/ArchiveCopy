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
using System.Diagnostics;

namespace winArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            byte[] ARREGLO = new byte[1024];
            string salida = txtSalida.Text;
            string ruta = txtRutaArchivo.Text;

            //Transmitir
            FileStream flujodeArchivo;
            BinaryReader leyendo;

//            flujodeArchivo = new FileStream("D:\\1desconprimirdo\\UNT\\comunicacion\\prueba\\NOMBRE.png", FileMode.Open,FileAccess.Read);
            flujodeArchivo = new FileStream($"{ruta}", FileMode.Open, FileAccess.Read);

            leyendo = new BinaryReader(flujodeArchivo);
            

            //recibir
            FileStream flujodeArchivoCopia;
            BinaryWriter Escribiendo;

            flujodeArchivoCopia = new FileStream($"D:\\1desconprimirdo\\UNT\\comunicacion\\prueba\\{salida}", FileMode.Create, FileAccess.Write);
            Escribiendo = new BinaryWriter(flujodeArchivoCopia);

            long tamaño = flujodeArchivo.Length;
            long tamañoCopy = flujodeArchivoCopia.Length;
            int avance = 0;
            // tambien podemos hacer que: flujodeArchivo.Length - flujodeArchivoCopia.Length = 0 xd ose que ya se paso el archivo..
            while ((tamaño-avance)>1024)
            {
                //LEO 1024bytes DEL ARREGLO DESDE LA POSCICION 0
                leyendo.Read(ARREGLO, 0, 1024);
                avance = avance + 1024;
                Escribiendo.Write(ARREGLO,0,1024);
            }

            int colita = Convert.ToInt16((tamaño - avance));
            leyendo.Read(ARREGLO, 0, colita);
            Escribiendo.Write(ARREGLO,0, colita);

            Escribiendo.Close();
            flujodeArchivoCopia.Close();
            leyendo.Close();
            flujodeArchivo.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            string rutaArchivo = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                //File name no devuelve el nombre.. la ruta del archivo
                rutaArchivo = openFileDialog.FileName;
            }

            txtRutaArchivo.Text = rutaArchivo;


        }
    }
}
