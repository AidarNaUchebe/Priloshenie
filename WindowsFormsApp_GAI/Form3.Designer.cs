namespace WindowsFormsApp_GAI
{
    partial class Subjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subjects));
            System.Windows.Forms.Label predm_IDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label deptLabel;
            System.Windows.Forms.Label hrsLabel1;
            this.label1 = new System.Windows.Forms.Label();
            this.education_GaisinDataSet = new WindowsFormsApp_GAI.Education_GaisinDataSet();
            this.subjects_GaisinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjects_GaisinTableAdapter = new WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.Subjects_GaisinTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.TableAdapterManager();
            this.subjects_GaisinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.subjects_GaisinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.predm_IDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.hrsMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            predm_IDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            deptLabel = new System.Windows.Forms.Label();
            hrsLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_GaisinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GaisinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GaisinBindingNavigator)).BeginInit();
            this.subjects_GaisinBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(121, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплины";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // education_GaisinDataSet
            // 
            this.education_GaisinDataSet.DataSetName = "Education_GaisinDataSet";
            this.education_GaisinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjects_GaisinBindingSource
            // 
            this.subjects_GaisinBindingSource.DataMember = "Subjects_Gaisin";
            this.subjects_GaisinBindingSource.DataSource = this.education_GaisinDataSet;
            // 
            // subjects_GaisinTableAdapter
            // 
            this.subjects_GaisinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_GaisinTableAdapter = null;
            this.tableAdapterManager.Subjects_GaisinTableAdapter = this.subjects_GaisinTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_GaisinTableAdapter = null;
            // 
            // subjects_GaisinBindingNavigator
            // 
            this.subjects_GaisinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjects_GaisinBindingNavigator.BindingSource = this.subjects_GaisinBindingSource;
            this.subjects_GaisinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjects_GaisinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjects_GaisinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.subjects_GaisinBindingNavigatorSaveItem});
            this.subjects_GaisinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjects_GaisinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjects_GaisinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjects_GaisinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjects_GaisinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjects_GaisinBindingNavigator.Name = "subjects_GaisinBindingNavigator";
            this.subjects_GaisinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjects_GaisinBindingNavigator.Size = new System.Drawing.Size(432, 25);
            this.subjects_GaisinBindingNavigator.TabIndex = 1;
            this.subjects_GaisinBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // subjects_GaisinBindingNavigatorSaveItem
            // 
            this.subjects_GaisinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjects_GaisinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjects_GaisinBindingNavigatorSaveItem.Image")));
            this.subjects_GaisinBindingNavigatorSaveItem.Name = "subjects_GaisinBindingNavigatorSaveItem";
            this.subjects_GaisinBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.subjects_GaisinBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjects_GaisinBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjects_GaisinBindingNavigatorSaveItem_Click);
            // 
            // predm_IDLabel
            // 
            predm_IDLabel.AutoSize = true;
            predm_IDLabel.Location = new System.Drawing.Point(23, 109);
            predm_IDLabel.Name = "predm_IDLabel";
            predm_IDLabel.Size = new System.Drawing.Size(86, 13);
            predm_IDLabel.TabIndex = 2;
            predm_IDLabel.Text = "ID дисциплины:";
            // 
            // predm_IDTextBox
            // 
            this.predm_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GaisinBindingSource, "predm_ID", true));
            this.predm_IDTextBox.Location = new System.Drawing.Point(115, 106);
            this.predm_IDTextBox.Name = "predm_IDTextBox";
            this.predm_IDTextBox.Size = new System.Drawing.Size(269, 20);
            this.predm_IDTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(49, 135);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(60, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GaisinBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(115, 132);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(269, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // deptLabel
            // 
            deptLabel.AutoSize = true;
            deptLabel.Location = new System.Drawing.Point(54, 187);
            deptLabel.Name = "deptLabel";
            deptLabel.Size = new System.Drawing.Size(55, 13);
            deptLabel.TabIndex = 8;
            deptLabel.Text = "Кафедра:";
            // 
            // deptTextBox
            // 
            this.deptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GaisinBindingSource, "dept", true));
            this.deptTextBox.Location = new System.Drawing.Point(115, 184);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(269, 20);
            this.deptTextBox.TabIndex = 9;
            // 
            // hrsLabel1
            // 
            hrsLabel1.AutoSize = true;
            hrsLabel1.Location = new System.Drawing.Point(71, 161);
            hrsLabel1.Name = "hrsLabel1";
            hrsLabel1.Size = new System.Drawing.Size(38, 13);
            hrsLabel1.TabIndex = 9;
            hrsLabel1.Text = "Часы:";
            // 
            // hrsMaskedTextBox
            // 
            this.hrsMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.subjects_GaisinBindingSource, "hrs", true));
            this.hrsMaskedTextBox.Location = new System.Drawing.Point(115, 158);
            this.hrsMaskedTextBox.Mask = "999";
            this.hrsMaskedTextBox.Name = "hrsMaskedTextBox";
            this.hrsMaskedTextBox.Size = new System.Drawing.Size(269, 20);
            this.hrsMaskedTextBox.TabIndex = 10;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 299);
            this.Controls.Add(hrsLabel1);
            this.Controls.Add(this.hrsMaskedTextBox);
            this.Controls.Add(deptLabel);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(predm_IDLabel);
            this.Controls.Add(this.predm_IDTextBox);
            this.Controls.Add(this.subjects_GaisinBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Subjects";
            this.Text = "Дисциплины_Гайсин";
            this.Load += new System.EventHandler(this.Subjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_GaisinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GaisinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GaisinBindingNavigator)).EndInit();
            this.subjects_GaisinBindingNavigator.ResumeLayout(false);
            this.subjects_GaisinBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_GaisinDataSet education_GaisinDataSet;
        private System.Windows.Forms.BindingSource subjects_GaisinBindingSource;
        private Education_GaisinDataSetTableAdapters.Subjects_GaisinTableAdapter subjects_GaisinTableAdapter;
        private Education_GaisinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjects_GaisinBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton subjects_GaisinBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox predm_IDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.MaskedTextBox hrsMaskedTextBox;
    }
}