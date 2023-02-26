using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetTask2
{
    public partial class WordQuantityForm : Form
    {
        private readonly Dictionary<string, int> wordQuantityDictionary;

        public WordQuantityForm(Dictionary<string, int> wordQuantityDictionary)
        {
            this.wordQuantityDictionary= wordQuantityDictionary;
            InitializeComponent();
        }

        private void WordQuantityForm_Load(object sender, EventArgs e)
        {
            foreach (var entry in wordQuantityDictionary)
                dataGridView.Rows.Add(entry.Key, entry.Value);
        }
    }
}
