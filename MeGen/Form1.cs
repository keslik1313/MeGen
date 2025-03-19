namespace MeGen
{
    public partial class Form_main : Form
    {
        private List<string> _selectedPngFiles = new List<string>();

        public Form_main()
        {
            InitializeComponent();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            if (CheckInputAllowDigits(textBox_sizeX.Text) == true &&
                CheckInputAllowDigits(textBox_sizeY.Text) == true)
            {
                GenerateJsonFile();
            }
            else
            {
                MessageBox.Show("Incorrect size.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenerateJsonFile()
        {
            try
            {
                // transfer data and write states from user specified files
                int version = int.Parse(textBox_version.Text);
                string license = comboBox_license.Text;
                string copyright = textBox_copyright.Text;
                int sizeX = int.Parse(textBox_sizeX.Text);
                int sizeY = int.Parse(textBox_sizeY.Text);
                var states = new List<object>();
                foreach (var filePath in _selectedPngFiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    states.Add(new { name = fileName });
                }

                JsonGenerator.GenerateJson(version, license, copyright, sizeX, sizeY, states);

                label_attention.Text = "Saved successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // return true if all symbols are digits
        private bool CheckInputAllowDigits(string isChecked)
        {
            foreach (char c in isChecked)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void button_selectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PNG files (*.png)|*.png";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedPngFiles.Clear();
                    _selectedPngFiles.AddRange(openFileDialog.FileNames);

                    listBox_selectedFiles.Items.Clear();
                    listBox_selectedFiles.Items.AddRange(openFileDialog.FileNames);
                }
            }
        }
    }
}
