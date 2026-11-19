
using System;
using System.IO;
using System.Windows.Forms;

namespace toli_bichig
{
    public partial class Form1 : Form
    {
        private string dbPath = string.Empty;
        private string savedDbPath = string.Empty;
        private string connStr = string.Empty;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string appDir =
                AppDomain.CurrentDomain.BaseDirectory;

            string dataDir = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "Toli");

            Directory.CreateDirectory(dataDir);

            // dict.db файлын зам
            dbPath = Path.Combine(dataDir, "dict.db");

            // dict.db байхгүй бол хуулна
            if (!File.Exists(dbPath))
            {
                File.Copy(
                    Path.Combine(appDir, "dict.db"),
                    dbPath);
            }

            // saved.db файлын зам
            savedDbPath = Path.Combine(dataDir, "saved.db");

            // saved.db байхгүй бол хуулна
            if (!File.Exists(savedDbPath))
            {
                File.Copy(
                    Path.Combine(appDir, "saved.db"),
                    savedDbPath);
            }

            // SQLite холболтын мөр
            connStr = $"Data Source={dbPath}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
