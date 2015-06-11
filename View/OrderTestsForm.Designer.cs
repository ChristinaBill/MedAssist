namespace MedAssist.View
{
    partial class OrderTestsForm
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
            System.Windows.Forms.Label testNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderTestsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new MedAssist.TestDataSet();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrderTest = new System.Windows.Forms.Button();
            this.btnAddTest = new System.Windows.Forms.Button();
            this.testsTableAdapter = new MedAssist.TestDataSetTableAdapters.TestsTableAdapter();
            this.tableAdapterManager = new MedAssist.TestDataSetTableAdapters.TableAdapterManager();
            this.testsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.testsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            testNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingNavigator)).BeginInit();
            this.testsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // testNameLabel
            // 
            testNameLabel.AutoSize = true;
            testNameLabel.Location = new System.Drawing.Point(27, 34);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new System.Drawing.Size(31, 13);
            testNameLabel.TabIndex = 41;
            testNameLabel.Text = "Test:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTest);
            this.groupBox1.Controls.Add(this.dgvTests);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnOrderTest);
            this.groupBox1.Controls.Add(this.btnAddTest);
            this.groupBox1.Controls.Add(testNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 321);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Tests";
            // 
            // cmbTest
            // 
            this.cmbTest.DataSource = this.testsBindingSource;
            this.cmbTest.DisplayMember = "TestName";
            this.cmbTest.FormattingEnabled = true;
            this.cmbTest.Location = new System.Drawing.Point(64, 31);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(206, 21);
            this.cmbTest.TabIndex = 45;
            this.cmbTest.ValueMember = "TestID";
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "Tests";
            this.testsBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvTests
            // 
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTests.Location = new System.Drawing.Point(30, 90);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.ReadOnly = true;
            this.dgvTests.Size = new System.Drawing.Size(242, 182);
            this.dgvTests.TabIndex = 43;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 23);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrderTest
            // 
            this.btnOrderTest.Location = new System.Drawing.Point(30, 278);
            this.btnOrderTest.Name = "btnOrderTest";
            this.btnOrderTest.Size = new System.Drawing.Size(108, 23);
            this.btnOrderTest.TabIndex = 33;
            this.btnOrderTest.Text = "Order";
            this.btnOrderTest.UseVisualStyleBackColor = true;
            this.btnOrderTest.Click += new System.EventHandler(this.btnOrderTest_Click);
            // 
            // btnAddTest
            // 
            this.btnAddTest.Location = new System.Drawing.Point(162, 61);
            this.btnAddTest.Name = "btnAddTest";
            this.btnAddTest.Size = new System.Drawing.Size(108, 23);
            this.btnAddTest.TabIndex = 43;
            this.btnAddTest.Text = "Add";
            this.btnAddTest.UseVisualStyleBackColor = true;
            this.btnAddTest.Click += new System.EventHandler(this.btnAddTest_Click);
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TestsTableAdapter = this.testsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MedAssist.TestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testsBindingNavigator
            // 
            this.testsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testsBindingNavigator.BindingSource = this.testsBindingSource;
            this.testsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.testsBindingNavigatorSaveItem});
            this.testsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testsBindingNavigator.Name = "testsBindingNavigator";
            this.testsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testsBindingNavigator.Size = new System.Drawing.Size(335, 25);
            this.testsBindingNavigator.TabIndex = 47;
            this.testsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // testsBindingNavigatorSaveItem
            // 
            this.testsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testsBindingNavigatorSaveItem.Image")));
            this.testsBindingNavigatorSaveItem.Name = "testsBindingNavigatorSaveItem";
            this.testsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.testsBindingNavigatorSaveItem.Text = "Save Data";
            this.testsBindingNavigatorSaveItem.Click += new System.EventHandler(this.testsBindingNavigatorSaveItem_Click);
            // 
            // OrderTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 359);
            this.Controls.Add(this.testsBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderTestsForm";
            this.Text = "OrderTestsForm";
            this.Load += new System.EventHandler(this.OrderTestsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingNavigator)).EndInit();
            this.testsBindingNavigator.ResumeLayout(false);
            this.testsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrderTest;
        private System.Windows.Forms.Button btnAddTest;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private TestDataSetTableAdapters.TestsTableAdapter testsTableAdapter;
        private TestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testsBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox cmbTest;
    }
}