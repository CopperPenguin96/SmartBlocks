using MinecraftTypes;
using Newtonsoft.Json;
using SmartBlocks.Blocks;

namespace BlockBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadBlocks();
            lboBlocks.MouseHover += Hover;
            numId.GotFocus += IdFocus;
            numItemMeta.GotFocus += IdFocus;
            MessageBox.Show($"There are {_blocks.Count} items loaded.");
        }

        private void IdFocus(object? sender, EventArgs e)
        {
            ((NumericUpDown) sender).Select(0, numId.Text.Length);
        }
        
        private void Hover(object? sender, EventArgs e)
        {
            if (lboBlocks.SelectedIndex > -1)
                tipNames.SetToolTip(lboBlocks,
                    _blocks[lboBlocks.SelectedIndex].Name);
        }

        private void DrawItem(object? sender, DrawItemEventArgs e)
        {
            lboBlocks.SelectedIndex = lboBlocks.Items.Count - 1;
        }

        private const string File = "blocks.json";

        private void LoadBlocks()
        {
            ClearForm();
            lboBlocks.Items.Clear();
            
            if (!System.IO.File.Exists(File))
            {
                MessageBox.Show("Blocks file does not exist.");
            }
            else
            {
                string json = System.IO.File.ReadAllText(File);
                _blocks = JsonConvert.DeserializeObject<List<Block>>(json)!;
                foreach (Block block in _blocks)
                {
                    lboBlocks.Items.Add(block.ItemId.ToString());
                    lboBlocks.SelectedIndex = lboBlocks.Items.Count - 1;
                }
            }
        }

        private void SaveBlocks()
        {
            string json = JsonConvert.SerializeObject(_blocks, Formatting.Indented);
            var writer = System.IO.File.CreateText(File);
            writer.WriteLine(json);
            writer.Flush();
            writer.Close();
            LoadBlocks(); // To reload list
        }

        private List<Block> _blocks = new();

        private byte _method;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            btnFinish.Enabled = true;
            btnFinish.Text = "Add Block";
            _method = 0x01;
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            if (lboBlocks.SelectedIndex == -1)
            {
                MessageBox.Show("No block selected");
                return;
            }

            ClearForm();
            btnFinish.Enabled = true;
            btnFinish.Text = "Edit Block";
            _method = 0x02;

            Block blk = _blocks[lboBlocks.SelectedIndex];
            txtName.Text = blk.Name;
            txtNamespace.Text = blk.ItemId.Namespace;
            txtItemId.Text = blk.ItemId.Name;
            numId.Value = blk.Id;
            numItemMeta.Value = blk.Type;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lboBlocks.SelectedIndex == -1)
            {
                MessageBox.Show("No block selected");
                return;
            }

            _blocks.RemoveAt(lboBlocks.SelectedIndex);
            SaveBlocks();
            ClearForm();
            _method = 0x00;
        }

        private void ClearForm()
        {
            txtName.Text = string.Empty;
            txtNamespace.Text = "minecraft";
            txtItemId.Text = string.Empty;
            numId.Value = 0;
            numItemMeta.Value = 0;
            btnFinish.Enabled = false;
            btnFinish.Text = string.Empty;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            Block block = new()
            {
                Name = txtName.Text,
                ItemId = new Identifier(txtNamespace.Text, txtItemId.Text),
                Id = (uint)numId.Value,
                Type = (uint)numItemMeta.Value
            };
            switch (_method)
            {
                case 0x00:
                    return;
                case 0x01: // Adding
                    _blocks.Add(block);
                    SaveBlocks();
                    MessageBox.Show("Block added");
                    btnAdd_Click(sender, e);
                    return;
                case 0x02: // Editing
                    if (lboBlocks.SelectedIndex == -1)
                    {
                        MessageBox.Show("No block selected");
                        return;
                    }

                    for (int x = 0; x < _blocks.Count; x++)
                    {
                        Block blk = _blocks[x];
                        if (blk.ItemId.ToString() != lboBlocks.Text) continue;
                        _blocks[x] = block;
                        SaveBlocks();
                        MessageBox.Show("Block updated");
                        return;
                    }
                    return;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string[] parts = txtName.Text.Split(" ");
            if (parts.Length == 1)
            {
                txtItemId.Text = parts[0].ToLower();
            }
            else
            {
                string newStr = "";

                for (int x = 0; x < parts.Length; x++)
                {
                    if (x == 0) newStr += parts[x].ToLower();
                    else newStr += "_" + parts[x].ToLower();
                }

                txtItemId.Text = newStr;
            }
        }

        private void lboBlocks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void numId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}