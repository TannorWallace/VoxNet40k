namespace VoxNet40k
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label voxIdLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label legionLabel;
            System.Windows.Forms.Label flagShipLabel;
            System.Windows.Forms.Label voxAddressLabel;
            System.Windows.Forms.Label voxNumberLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.voxNetDB_DataSet = new VoxNet40k.VoxNetDB_DataSet();
            this.voxContactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voxContactTableAdapter = new VoxNet40k.VoxNetDB_DataSetTableAdapters.VoxContactTableAdapter();
            this.tableAdapterManager = new VoxNet40k.VoxNetDB_DataSetTableAdapters.TableAdapterManager();
            this.voxContactBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.voxContactBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.voxIdTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.legionTextBox = new System.Windows.Forms.TextBox();
            this.flagShipTextBox = new System.Windows.Forms.TextBox();
            this.voxAddressTextBox = new System.Windows.Forms.TextBox();
            this.voxNumberTextBox = new System.Windows.Forms.TextBox();
            voxIdLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            legionLabel = new System.Windows.Forms.Label();
            flagShipLabel = new System.Windows.Forms.Label();
            voxAddressLabel = new System.Windows.Forms.Label();
            voxNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voxNetDB_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voxContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voxContactBindingNavigator)).BeginInit();
            this.voxContactBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(527, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // voxNetDB_DataSet
            // 
            this.voxNetDB_DataSet.DataSetName = "VoxNetDB_DataSet";
            this.voxNetDB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voxContactBindingSource
            // 
            this.voxContactBindingSource.DataMember = "VoxContact";
            this.voxContactBindingSource.DataSource = this.voxNetDB_DataSet;
            // 
            // voxContactTableAdapter
            // 
            this.voxContactTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = VoxNet40k.VoxNetDB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VoxContactTableAdapter = this.voxContactTableAdapter;
            // 
            // voxContactBindingNavigator
            // 
            this.voxContactBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.voxContactBindingNavigator.BindingSource = this.voxContactBindingSource;
            this.voxContactBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.voxContactBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.voxContactBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.voxContactBindingNavigatorSaveItem});
            this.voxContactBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.voxContactBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.voxContactBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.voxContactBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.voxContactBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.voxContactBindingNavigator.Name = "voxContactBindingNavigator";
            this.voxContactBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.voxContactBindingNavigator.Size = new System.Drawing.Size(819, 25);
            this.voxContactBindingNavigator.TabIndex = 1;
            this.voxContactBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // voxContactBindingNavigatorSaveItem
            // 
            this.voxContactBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.voxContactBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("voxContactBindingNavigatorSaveItem.Image")));
            this.voxContactBindingNavigatorSaveItem.Name = "voxContactBindingNavigatorSaveItem";
            this.voxContactBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.voxContactBindingNavigatorSaveItem.Text = "Save Data";
            this.voxContactBindingNavigatorSaveItem.Click += new System.EventHandler(this.voxContactBindingNavigatorSaveItem_Click_1);
            // 
            // voxIdLabel
            // 
            voxIdLabel.AutoSize = true;
            voxIdLabel.Location = new System.Drawing.Point(36, 95);
            voxIdLabel.Name = "voxIdLabel";
            voxIdLabel.Size = new System.Drawing.Size(40, 13);
            voxIdLabel.TabIndex = 2;
            voxIdLabel.Text = "Vox Id:";
            // 
            // voxIdTextBox
            // 
            this.voxIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voxContactBindingSource, "VoxId", true));
            this.voxIdTextBox.Location = new System.Drawing.Point(111, 92);
            this.voxIdTextBox.Name = "voxIdTextBox";
            this.voxIdTextBox.Size = new System.Drawing.Size(29, 20);
            this.voxIdTextBox.TabIndex = 3;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(36, 121);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "Full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voxContactBindingSource, "FullName", true));
            this.fullNameTextBox.Location = new System.Drawing.Point(111, 118);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fullNameTextBox.TabIndex = 5;
            // 
            // legionLabel
            // 
            legionLabel.AutoSize = true;
            legionLabel.Location = new System.Drawing.Point(36, 147);
            legionLabel.Name = "legionLabel";
            legionLabel.Size = new System.Drawing.Size(42, 13);
            legionLabel.TabIndex = 6;
            legionLabel.Text = "Legion:";
            // 
            // legionTextBox
            // 
            this.legionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voxContactBindingSource, "Legion", true));
            this.legionTextBox.Location = new System.Drawing.Point(111, 144);
            this.legionTextBox.Name = "legionTextBox";
            this.legionTextBox.Size = new System.Drawing.Size(29, 20);
            this.legionTextBox.TabIndex = 7;
            // 
            // flagShipLabel
            // 
            flagShipLabel.AutoSize = true;
            flagShipLabel.Location = new System.Drawing.Point(36, 173);
            flagShipLabel.Name = "flagShipLabel";
            flagShipLabel.Size = new System.Drawing.Size(54, 13);
            flagShipLabel.TabIndex = 8;
            flagShipLabel.Text = "Flag Ship:";
            // 
            // flagShipTextBox
            // 
            this.flagShipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voxContactBindingSource, "FlagShip", true));
            this.flagShipTextBox.Location = new System.Drawing.Point(111, 170);
            this.flagShipTextBox.Name = "flagShipTextBox";
            this.flagShipTextBox.Size = new System.Drawing.Size(138, 20);
            this.flagShipTextBox.TabIndex = 9;
            // 
            // voxAddressLabel
            // 
            voxAddressLabel.AutoSize = true;
            voxAddressLabel.Location = new System.Drawing.Point(36, 199);
            voxAddressLabel.Name = "voxAddressLabel";
            voxAddressLabel.Size = new System.Drawing.Size(69, 13);
            voxAddressLabel.TabIndex = 10;
            voxAddressLabel.Text = "Vox Address:";
            // 
            // voxAddressTextBox
            // 
            this.voxAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voxContactBindingSource, "VoxAddress", true));
            this.voxAddressTextBox.Location = new System.Drawing.Point(111, 196);
            this.voxAddressTextBox.Name = "voxAddressTextBox";
            this.voxAddressTextBox.Size = new System.Drawing.Size(138, 20);
            this.voxAddressTextBox.TabIndex = 11;
            // 
            // voxNumberLabel
            // 
            voxNumberLabel.AutoSize = true;
            voxNumberLabel.Location = new System.Drawing.Point(36, 225);
            voxNumberLabel.Name = "voxNumberLabel";
            voxNumberLabel.Size = new System.Drawing.Size(68, 13);
            voxNumberLabel.TabIndex = 12;
            voxNumberLabel.Text = "Vox Number:";
            // 
            // voxNumberTextBox
            // 
            this.voxNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voxContactBindingSource, "VoxNumber", true));
            this.voxNumberTextBox.Location = new System.Drawing.Point(111, 222);
            this.voxNumberTextBox.Name = "voxNumberTextBox";
            this.voxNumberTextBox.Size = new System.Drawing.Size(69, 20);
            this.voxNumberTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(voxIdLabel);
            this.Controls.Add(this.voxIdTextBox);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(legionLabel);
            this.Controls.Add(this.legionTextBox);
            this.Controls.Add(flagShipLabel);
            this.Controls.Add(this.flagShipTextBox);
            this.Controls.Add(voxAddressLabel);
            this.Controls.Add(this.voxAddressTextBox);
            this.Controls.Add(voxNumberLabel);
            this.Controls.Add(this.voxNumberTextBox);
            this.Controls.Add(this.voxContactBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voxNetDB_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voxContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voxContactBindingNavigator)).EndInit();
            this.voxContactBindingNavigator.ResumeLayout(false);
            this.voxContactBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private VoxNetDB_DataSet voxNetDB_DataSet;
        private System.Windows.Forms.BindingSource voxContactBindingSource;
        private VoxNetDB_DataSetTableAdapters.VoxContactTableAdapter voxContactTableAdapter;
        private VoxNetDB_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator voxContactBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton voxContactBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox voxIdTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox legionTextBox;
        private System.Windows.Forms.TextBox flagShipTextBox;
        private System.Windows.Forms.TextBox voxAddressTextBox;
        private System.Windows.Forms.TextBox voxNumberTextBox;
    }
}

