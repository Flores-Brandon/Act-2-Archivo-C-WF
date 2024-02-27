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

namespace _2_Act_Archivos_4_semestre
{
    public partial class Form1 : Form
    {
        private string currentFileName;
        private List<string> data;
        private Dictionary<int, string> indexedData;
        private Dictionary<int, string> directData;
        private int recordSize = 100;
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        //Codigo Archivo Secuenciales
        private void LeerArchivoSecuencial(string fileName)
        {
            // Lógica para leer un archivo secuencial
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    data = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        data.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo secuencial: {ex.Message}");
            }
        }

        private void MostrarDatos(List<string> dataList)
        {
            // Lógica para mostrar datos en algún control (por ejemplo, un ListBox)
            // Puedes adaptar esta lógica según tu interfaz de usuario
            listBoxSecuenciales.Items.Clear();
            foreach (var item in dataList)
            {
                listBoxSecuenciales.Items.Add(item);
            }
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = openFileDialog.FileName;
                // Lógica para abrir el archivo y cargar datos en 'data'
                // Ejemplo: data = LeerArchivo(currentFileName);
                MessageBox.Show("Archivo abierto correctamente.");
            }
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            if (currentFileName != null)
            {
                // Lógica específica para archivos secuenciales
                LeerArchivoSecuencial(currentFileName);
                MostrarDatos(data);
            }
            else
            {
                MessageBox.Show("Por favor, abre un archivo secuencial antes de realizar operaciones.");
            }
        }

        private void btnCerrarArchivo_Click(object sender, EventArgs e)
        {
            listBoxSecuenciales.Items.Clear();
        }
        //Termina Codigo Secuencial



        //Inicia Codigo Indexado
        private void btnAbrirIndexado_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = openFileDialog.FileName;
                // Lógica para abrir el archivo y cargar datos en 'data'
                // Ejemplo: data = LeerArchivo(currentFileName);
                MessageBox.Show("Archivo abierto correctamente.");
            }
        }

        private void btnIndexado_Click(object sender, EventArgs e)
        {
            if (currentFileName != null)
            {
                // Lógica específica para archivos secuenciales indexados
                LeerArchivoIndexado(currentFileName);
                MostrarDatosIndexados(indexedData);
            }
            else
            {
                MessageBox.Show("Por favor, abre un archivo indexado antes de realizar operaciones.");
            }
        }

        private void LeerArchivoIndexado(string fileName)
        {
            // Lógica para leer un archivo secuencial indexado
            try
            {
                indexedData = new Dictionary<int, string>();
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        // Supongamos que el índice está en la primera posición de cada línea
                        string[] parts = line.Split(',');
                        if (parts.Length >= 2 && int.TryParse(parts[0], out int index))
                        {
                            indexedData[index] = line.Substring(parts[0].Length + 1); // El +1 es para ignorar la coma
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo indexado: {ex.Message}");
            }
        }

        private void MostrarDatosIndexados(Dictionary<int, string> indexedData)
        {
            // Lógica para mostrar datos en algún control (por ejemplo, un ListBox)
            // Puedes adaptar esta lógica según tu interfaz de usuario
            listBoxIndexado.Items.Clear();
            foreach (var kvp in indexedData)
            {
                listBoxIndexado.Items.Add($"{kvp.Key}: {kvp.Value}");
            }
        }

        private void btnCerrarIndexado_Click(object sender, EventArgs e)
        {
            listBoxIndexado.Items.Clear();
        }
        //Termina codigo Indexado



        //Inicia codigo Directo
        private void btnAbrirDirecto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFileName = openFileDialog.FileName;
                // Lógica para abrir el archivo y cargar datos en 'data'
                // Ejemplo: data = LeerArchivo(currentFileName);
                MessageBox.Show("Archivo abierto correctamente.");
            }
        }

        private void btnDirecto_Click(object sender, EventArgs e)
        {
            if (currentFileName != null)
            {
                // Lógica específica para archivos de acceso directo
                LeerArchivoDirecto(currentFileName);
                MostrarDatosDirectos(directData);
            }
            else
            {
                MessageBox.Show("Por favor, abre un archivo de acceso directo antes de realizar operaciones.");
            }
        }

        private void LeerArchivoDirecto(string fileName)
        {
            // Lógica para leer un archivo de acceso directo
            try
            {
                directData = new Dictionary<int, string>();
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int key = reader.ReadInt32();
                        byte[] dataBytes = reader.ReadBytes(recordSize - sizeof(int));
                        string data = System.Text.Encoding.UTF8.GetString(dataBytes);
                        directData[key] = data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo de acceso directo: {ex.Message}");
            }
        }

        private void MostrarDatosDirectos(Dictionary<int, string> directData)
        {
            // Lógica para mostrar datos en algún control (por ejemplo, un ListBox)
            // Puedes adaptar esta lógica según tu interfaz de usuario
            listBoxDirecto.Items.Clear();
            foreach (var kvp in directData)
            {
                listBoxDirecto.Items.Add($"{kvp.Key}: {kvp.Value}");
            }
        }

        private void btnCerrarDirecto_Click(object sender, EventArgs e)
        {
            listBoxDirecto.Items.Clear();
        }

        //Termina Codigo DDirecto
    }
}
