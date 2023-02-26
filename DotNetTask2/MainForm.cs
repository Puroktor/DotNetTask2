namespace DotNetTask2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

		private void MainForm_Load(object sender, EventArgs e)
		{
			openFileDialog.Filter = "Text file|*.txt";
			openFileDialog.FileName = null;
		}

		private void ChooseFileButton_Click(object sender, EventArgs e)
        {
			if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				return;
			pathTextBox.Text = openFileDialog.FileName;
		}

        private async void CountButton_Click(object sender, EventArgs e)
        {
			await Task.Run(() =>
			{
				try
				{
					var wordQuantityDictionary = WordCounter.CountWordsInFile(pathTextBox.Text);
					var wordQuantityForm = new WordQuantityForm(wordQuantityDictionary);
                    wordQuantityForm.ShowDialog();

                } catch(Exception) {
					MessageBox.Show("File format was invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			});
		}
    }
}