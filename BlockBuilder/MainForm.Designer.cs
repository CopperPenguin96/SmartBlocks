namespace BlockBuilder
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lboBlocks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.cboStackable = new System.Windows.Forms.CheckBox();
            this.cboDiggable = new System.Windows.Forms.CheckBox();
            this.lblMaxStackSize = new System.Windows.Forms.Label();
            this.numMaxStackSize = new System.Windows.Forms.NumericUpDown();
            this.numHardness = new System.Windows.Forms.NumericUpDown();
            this.lblHardness = new System.Windows.Forms.Label();
            this.numMinStateId = new System.Windows.Forms.NumericUpDown();
            this.lblMinStateId = new System.Windows.Forms.Label();
            this.numMaxStateId = new System.Windows.Forms.NumericUpDown();
            this.lblMaxStateId = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.lblNumericId = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.numItemMeta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStackSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHardness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStateId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemMeta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SmartBlocks Block Builder";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(168, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lboBlocks
            // 
            this.lboBlocks.FormattingEnabled = true;
            this.lboBlocks.ItemHeight = 20;
            this.lboBlocks.Location = new System.Drawing.Point(13, 50);
            this.lboBlocks.Name = "lboBlocks";
            this.lboBlocks.Size = new System.Drawing.Size(150, 364);
            this.lboBlocks.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(168, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(268, 50);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(368, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(261, 118);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(201, 27);
            this.txtNamespace.TabIndex = 8;
            this.txtNamespace.Text = "minecraft";
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(168, 121);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(87, 20);
            this.lblNamespace.TabIndex = 7;
            this.lblNamespace.Text = "Namespace";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(230, 151);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(232, 27);
            this.txtItemId.TabIndex = 10;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.Location = new System.Drawing.Point(168, 154);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(56, 20);
            this.lblItemId.TabIndex = 9;
            this.lblItemId.Text = "Item Id";
            // 
            // cboStackable
            // 
            this.cboStackable.AutoSize = true;
            this.cboStackable.Location = new System.Drawing.Point(168, 184);
            this.cboStackable.Name = "cboStackable";
            this.cboStackable.Size = new System.Drawing.Size(95, 24);
            this.cboStackable.TabIndex = 11;
            this.cboStackable.Text = "Stackable";
            this.cboStackable.UseVisualStyleBackColor = true;
            // 
            // cboDiggable
            // 
            this.cboDiggable.AutoSize = true;
            this.cboDiggable.Location = new System.Drawing.Point(287, 184);
            this.cboDiggable.Name = "cboDiggable";
            this.cboDiggable.Size = new System.Drawing.Size(93, 24);
            this.cboDiggable.TabIndex = 12;
            this.cboDiggable.Text = "Diggable";
            this.cboDiggable.UseVisualStyleBackColor = true;
            // 
            // lblMaxStackSize
            // 
            this.lblMaxStackSize.AutoSize = true;
            this.lblMaxStackSize.Location = new System.Drawing.Point(168, 217);
            this.lblMaxStackSize.Name = "lblMaxStackSize";
            this.lblMaxStackSize.Size = new System.Drawing.Size(107, 20);
            this.lblMaxStackSize.TabIndex = 13;
            this.lblMaxStackSize.Text = "Max Stack Size";
            // 
            // numMaxStackSize
            // 
            this.numMaxStackSize.Location = new System.Drawing.Point(281, 215);
            this.numMaxStackSize.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numMaxStackSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxStackSize.Name = "numMaxStackSize";
            this.numMaxStackSize.Size = new System.Drawing.Size(181, 27);
            this.numMaxStackSize.TabIndex = 15;
            this.numMaxStackSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHardness
            // 
            this.numHardness.DecimalPlaces = 3;
            this.numHardness.Location = new System.Drawing.Point(244, 248);
            this.numHardness.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numHardness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHardness.Name = "numHardness";
            this.numHardness.Size = new System.Drawing.Size(218, 27);
            this.numHardness.TabIndex = 17;
            this.numHardness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHardness
            // 
            this.lblHardness.AutoSize = true;
            this.lblHardness.Location = new System.Drawing.Point(168, 250);
            this.lblHardness.Name = "lblHardness";
            this.lblHardness.Size = new System.Drawing.Size(70, 20);
            this.lblHardness.TabIndex = 16;
            this.lblHardness.Text = "Hardness";
            // 
            // numMinStateId
            // 
            this.numMinStateId.Location = new System.Drawing.Point(263, 281);
            this.numMinStateId.Name = "numMinStateId";
            this.numMinStateId.Size = new System.Drawing.Size(199, 27);
            this.numMinStateId.TabIndex = 19;
            // 
            // lblMinStateId
            // 
            this.lblMinStateId.AutoSize = true;
            this.lblMinStateId.Location = new System.Drawing.Point(168, 283);
            this.lblMinStateId.Name = "lblMinStateId";
            this.lblMinStateId.Size = new System.Drawing.Size(89, 20);
            this.lblMinStateId.TabIndex = 18;
            this.lblMinStateId.Text = "Min State Id";
            // 
            // numMaxStateId
            // 
            this.numMaxStateId.Location = new System.Drawing.Point(261, 314);
            this.numMaxStateId.Name = "numMaxStateId";
            this.numMaxStateId.Size = new System.Drawing.Size(199, 27);
            this.numMaxStateId.TabIndex = 21;
            // 
            // lblMaxStateId
            // 
            this.lblMaxStateId.AutoSize = true;
            this.lblMaxStateId.Location = new System.Drawing.Point(166, 316);
            this.lblMaxStateId.Name = "lblMaxStateId";
            this.lblMaxStateId.Size = new System.Drawing.Size(92, 20);
            this.lblMaxStateId.TabIndex = 20;
            this.lblMaxStateId.Text = "Max State Id";
            // 
            // btnFinish
            // 
            this.btnFinish.Enabled = false;
            this.btnFinish.Location = new System.Drawing.Point(169, 380);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(296, 29);
            this.btnFinish.TabIndex = 22;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // lblNumericId
            // 
            this.lblNumericId.AutoSize = true;
            this.lblNumericId.Location = new System.Drawing.Point(169, 349);
            this.lblNumericId.Name = "lblNumericId";
            this.lblNumericId.Size = new System.Drawing.Size(82, 20);
            this.lblNumericId.TabIndex = 23;
            this.lblNumericId.Text = "Numeric Id";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(257, 347);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(62, 27);
            this.numId.TabIndex = 24;
            // 
            // numItemMeta
            // 
            this.numItemMeta.Location = new System.Drawing.Point(334, 347);
            this.numItemMeta.Name = "numItemMeta";
            this.numItemMeta.Size = new System.Drawing.Size(62, 27);
            this.numItemMeta.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 432);
            this.Controls.Add(this.numItemMeta);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.lblNumericId);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.numMaxStateId);
            this.Controls.Add(this.lblMaxStateId);
            this.Controls.Add(this.numMinStateId);
            this.Controls.Add(this.lblMinStateId);
            this.Controls.Add(this.numHardness);
            this.Controls.Add(this.lblHardness);
            this.Controls.Add(this.numMaxStackSize);
            this.Controls.Add(this.lblMaxStackSize);
            this.Controls.Add(this.cboDiggable);
            this.Controls.Add(this.cboStackable);
            this.Controls.Add(this.txtItemId);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.lblNamespace);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lboBlocks);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartBlocks Block Builder";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStackSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHardness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinStateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxStateId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemMeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblName;
        private ListBox lboBlocks;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private TextBox txtName;
        private TextBox txtNamespace;
        private Label lblNamespace;
        private TextBox txtItemId;
        private Label lblItemId;
        private CheckBox cboStackable;
        private CheckBox cboDiggable;
        private Label lblMaxStackSize;
        private NumericUpDown numMaxStackSize;
        private NumericUpDown numHardness;
        private Label lblHardness;
        private NumericUpDown numMinStateId;
        private Label lblMinStateId;
        private NumericUpDown numMaxStateId;
        private Label lblMaxStateId;
        private Button btnFinish;
        private Label lblNumericId;
        private NumericUpDown numId;
        private NumericUpDown numItemMeta;
    }
}