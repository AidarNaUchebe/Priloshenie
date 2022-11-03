namespace WindowsFormsApp_GAI
{
    partial class Uspev
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
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label ocenkaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uspev));
            System.Windows.Forms.Label studentLabel;
            System.Windows.Forms.Label predmetLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.education_GaisinDataSet = new WindowsFormsApp_GAI.Education_GaisinDataSet();
            this.uspev_GaisinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspev_GaisinTableAdapter = new WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.Uspev_GaisinTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.TableAdapterManager();
            this.students_GaisinTableAdapter = new WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.Students_GaisinTableAdapter();
            this.subjects_GaisinTableAdapter = new WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.Subjects_GaisinTableAdapter();
            this.uspev_GaisinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.uspev_GaisinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.ocenkaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.subjects_GaisinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKUspevGaisinSubjectsGaisinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_GaisinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.predmetComboBox = new System.Windows.Forms.ComboBox();
            dataLabel = new System.Windows.Forms.Label();
            ocenkaLabel = new System.Windows.Forms.Label();
            studentLabel = new System.Windows.Forms.Label();
            predmetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_GaisinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_GaisinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_GaisinBindingNavigator)).BeginInit();
            this.uspev_GaisinBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GaisinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUspevGaisinSubjectsGaisinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GaisinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new System.Drawing.Point(42, 180);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(75, 13);
            dataLabel.TabIndex = 8;
            dataLabel.Text = "Дата оценки:";
            // 
            // ocenkaLabel
            // 
            ocenkaLabel.AutoSize = true;
            ocenkaLabel.Location = new System.Drawing.Point(69, 154);
            ocenkaLabel.Name = "ocenkaLabel";
            ocenkaLabel.Size = new System.Drawing.Size(48, 13);
            ocenkaLabel.TabIndex = 9;
            ocenkaLabel.Text = "Оценка:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(71, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Успеваемость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // education_GaisinDataSet
            // 
            this.education_GaisinDataSet.DataSetName = "Education_GaisinDataSet";
            this.education_GaisinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspev_GaisinBindingSource
            // 
            this.uspev_GaisinBindingSource.DataMember = "Uspev_Gaisin";
            this.uspev_GaisinBindingSource.DataSource = this.education_GaisinDataSet;
            // 
            // uspev_GaisinTableAdapter
            // 
            this.uspev_GaisinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_GaisinTableAdapter = this.students_GaisinTableAdapter;
            this.tableAdapterManager.Subjects_GaisinTableAdapter = this.subjects_GaisinTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_GaisinTableAdapter = this.uspev_GaisinTableAdapter;
            // 
            // students_GaisinTableAdapter
            // 
            this.students_GaisinTableAdapter.ClearBeforeFill = true;
            // 
            // subjects_GaisinTableAdapter
            // 
            this.subjects_GaisinTableAdapter.ClearBeforeFill = true;
            // 
            // uspev_GaisinBindingNavigator
            // 
            this.uspev_GaisinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uspev_GaisinBindingNavigator.BindingSource = this.uspev_GaisinBindingSource;
            this.uspev_GaisinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uspev_GaisinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uspev_GaisinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uspev_GaisinBindingNavigatorSaveItem});
            this.uspev_GaisinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uspev_GaisinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uspev_GaisinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uspev_GaisinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uspev_GaisinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uspev_GaisinBindingNavigator.Name = "uspev_GaisinBindingNavigator";
            this.uspev_GaisinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uspev_GaisinBindingNavigator.Size = new System.Drawing.Size(327, 25);
            this.uspev_GaisinBindingNavigator.TabIndex = 1;
            this.uspev_GaisinBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uspev_GaisinBindingNavigatorSaveItem
            // 
            this.uspev_GaisinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uspev_GaisinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uspev_GaisinBindingNavigatorSaveItem.Image")));
            this.uspev_GaisinBindingNavigatorSaveItem.Name = "uspev_GaisinBindingNavigatorSaveItem";
            this.uspev_GaisinBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uspev_GaisinBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.uspev_GaisinBindingNavigatorSaveItem.Click += new System.EventHandler(this.uspev_GaisinBindingNavigatorSaveItem_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_GaisinBindingSource, "data", true));
            this.dataTextBox.Location = new System.Drawing.Point(126, 177);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(137, 20);
            this.dataTextBox.TabIndex = 9;
            // 
            // ocenkaMaskedTextBox
            // 
            this.ocenkaMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_GaisinBindingSource, "ocenka", true));
            this.ocenkaMaskedTextBox.Location = new System.Drawing.Point(126, 151);
            this.ocenkaMaskedTextBox.Mask = "?";
            this.ocenkaMaskedTextBox.Name = "ocenkaMaskedTextBox";
            this.ocenkaMaskedTextBox.Size = new System.Drawing.Size(137, 20);
            this.ocenkaMaskedTextBox.TabIndex = 10;
            // 
            // subjects_GaisinBindingSource
            // 
            this.subjects_GaisinBindingSource.DataMember = "Subjects_Gaisin";
            this.subjects_GaisinBindingSource.DataSource = this.education_GaisinDataSet;
            // 
            // fKUspevGaisinSubjectsGaisinBindingSource
            // 
            this.fKUspevGaisinSubjectsGaisinBindingSource.DataMember = "FK_Uspev_Gaisin_Subjects_Gaisin";
            this.fKUspevGaisinSubjectsGaisinBindingSource.DataSource = this.subjects_GaisinBindingSource;
            // 
            // students_GaisinBindingSource
            // 
            this.students_GaisinBindingSource.DataMember = "Students_Gaisin";
            this.students_GaisinBindingSource.DataSource = this.education_GaisinDataSet;
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Location = new System.Drawing.Point(72, 102);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new System.Drawing.Size(45, 13);
            studentLabel.TabIndex = 12;
            studentLabel.Text = "student:";
            // 
            // studentTextBox
            // 
            this.studentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_GaisinBindingSource, "student", true));
            this.studentTextBox.Location = new System.Drawing.Point(126, 99);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.Size = new System.Drawing.Size(100, 20);
            this.studentTextBox.TabIndex = 13;
            // 
            // predmetLabel
            // 
            predmetLabel.AutoSize = true;
            predmetLabel.Location = new System.Drawing.Point(72, 127);
            predmetLabel.Name = "predmetLabel";
            predmetLabel.Size = new System.Drawing.Size(48, 13);
            predmetLabel.TabIndex = 13;
            predmetLabel.Text = "predmet:";
            // 
            // predmetComboBox
            // 
            this.predmetComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspev_GaisinBindingSource, "predmet", true));
            this.predmetComboBox.FormattingEnabled = true;
            this.predmetComboBox.Location = new System.Drawing.Point(126, 124);
            this.predmetComboBox.Name = "predmetComboBox";
            this.predmetComboBox.Size = new System.Drawing.Size(121, 21);
            this.predmetComboBox.TabIndex = 14;
            // 
            // Uspev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 265);
            this.Controls.Add(predmetLabel);
            this.Controls.Add(this.predmetComboBox);
            this.Controls.Add(studentLabel);
            this.Controls.Add(this.studentTextBox);
            this.Controls.Add(ocenkaLabel);
            this.Controls.Add(this.ocenkaMaskedTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.uspev_GaisinBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Uspev";
            this.Text = "Успеваемость_Гайсин";
            this.Load += new System.EventHandler(this.Uspev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_GaisinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_GaisinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspev_GaisinBindingNavigator)).EndInit();
            this.uspev_GaisinBindingNavigator.ResumeLayout(false);
            this.uspev_GaisinBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjects_GaisinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUspevGaisinSubjectsGaisinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GaisinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_GaisinDataSet education_GaisinDataSet;
        private System.Windows.Forms.BindingSource uspev_GaisinBindingSource;
        private Education_GaisinDataSetTableAdapters.Uspev_GaisinTableAdapter uspev_GaisinTableAdapter;
        private Education_GaisinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uspev_GaisinBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uspev_GaisinBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.MaskedTextBox ocenkaMaskedTextBox;
        private Education_GaisinDataSetTableAdapters.Subjects_GaisinTableAdapter subjects_GaisinTableAdapter;
        private System.Windows.Forms.BindingSource subjects_GaisinBindingSource;
        private System.Windows.Forms.BindingSource fKUspevGaisinSubjectsGaisinBindingSource;
        private Education_GaisinDataSetTableAdapters.Students_GaisinTableAdapter students_GaisinTableAdapter;
        private System.Windows.Forms.BindingSource students_GaisinBindingSource;
        private System.Windows.Forms.TextBox studentTextBox;
        private System.Windows.Forms.ComboBox predmetComboBox;
    }
}