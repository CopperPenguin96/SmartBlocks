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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
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
            cboStackable.Checked = blk.IsStackable;
            cboDiggable.Checked = blk.IsDiggable;
            numMaxStackSize.Value = blk.MaxStackSize;
            numHardness.Value = (decimal)blk.Hardness;
            numMinStateId.Value = blk.MinStateId;
            numMaxStateId.Value = blk.MaxStateId;
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
            cboStackable.Checked = false;
            cboDiggable.Checked = false;
            numMaxStackSize.Value = 1;
            numHardness.Value = (decimal) 1.0;
            numMinStateId.Value = 0;
            numMaxStateId.Value = 0;
            numId.Value = 0;
            numItemMeta.Value = 0;
            btnFinish.Enabled = false;
            btnFinish.Text = string.Empty;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Block block = new()
            {
                Name = txtName.Text,
                ItemId = new Identifier(txtNamespace.Text, txtItemId.Text),
                IsStackable = cboStackable.Checked,
                IsDiggable = cboDiggable.Checked,
                MaxStackSize = (short)numMaxStackSize.Value,
                Hardness = (double)numHardness.Value,
                MinStateId = (short)numMinStateId.Value,
                MaxStateId = (short)numMaxStateId.Value,
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
                        if (!blk.Id.ToString().Equals(lboBlocks.Text)) continue;
                        _blocks[x] = block;
                        SaveBlocks();
                        MessageBox.Show("Block updated");
                        return;
                    }
                    return;
            }
        }
    }
}