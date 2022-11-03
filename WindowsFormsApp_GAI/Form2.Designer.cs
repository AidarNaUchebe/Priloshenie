namespace WindowsFormsApp_GAI
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.Label no_zkLabel;
            System.Windows.Forms.Label famLabel;
            System.Windows.Forms.Label imLabel;
            System.Windows.Forms.Label otLabel;
            System.Windows.Forms.Label specLabel;
            System.Windows.Forms.Label kursLabel;
            System.Windows.Forms.Label grLabel;
            System.Windows.Forms.Label biogrLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.education_GaisinDataSet = new WindowsFormsApp_GAI.Education_GaisinDataSet();
            this.students_GaisinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.students_GaisinTableAdapter = new WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.Students_GaisinTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.TableAdapterManager();
            this.students_GaisinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.students_GaisinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.no_zkTextBox = new System.Windows.Forms.TextBox();
            this.famTextBox = new System.Windows.Forms.TextBox();
            this.imTextBox = new System.Windows.Forms.TextBox();
            this.otTextBox = new System.Windows.Forms.TextBox();
            this.specTextBox = new System.Windows.Forms.TextBox();
            this.kursTextBox = new System.Windows.Forms.TextBox();
            this.grTextBox = new System.Windows.Forms.TextBox();
            this.biogrTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            no_zkLabel = new System.Windows.Forms.Label();
            famLabel = new System.Windows.Forms.Label();
            imLabel = new System.Windows.Forms.Label();
            otLabel = new System.Windows.Forms.Label();
            specLabel = new System.Windows.Forms.Label();
            kursLabel = new System.Windows.Forms.Label();
            grLabel = new System.Windows.Forms.Label();
            biogrLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.education_GaisinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GaisinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GaisinBindingNavigator)).BeginInit();
            this.students_GaisinBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(126, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Студенты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // education_GaisinDataSet
            // 
            this.education_GaisinDataSet.DataSetName = "Education_GaisinDataSet";
            this.education_GaisinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // students_GaisinBindingSource
            // 
            this.students_GaisinBindingSource.DataMember = "Students_Gaisin";
            this.students_GaisinBindingSource.DataSource = this.education_GaisinDataSet;
            // 
            // students_GaisinTableAdapter
            // 
            this.students_GaisinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Students_GaisinTableAdapter = this.students_GaisinTableAdapter;
            this.tableAdapterManager.Subjects_GaisinTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp_GAI.Education_GaisinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Uspev_GaisinTableAdapter = null;
            // 
            // students_GaisinBindingNavigator
            // 
            this.students_GaisinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.students_GaisinBindingNavigator.BindingSource = this.students_GaisinBindingSource;
            this.students_GaisinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.students_GaisinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.students_GaisinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.students_GaisinBindingNavigatorSaveItem});
            this.students_GaisinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.students_GaisinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.students_GaisinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.students_GaisinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.students_GaisinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.students_GaisinBindingNavigator.Name = "students_GaisinBindingNavigator";
            this.students_GaisinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.students_GaisinBindingNavigator.Size = new System.Drawing.Size(490, 25);
            this.students_GaisinBindingNavigator.TabIndex = 1;
            this.students_GaisinBindingNavigator.Text = "bindingNavigator1";
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
            // students_GaisinBindingNavigatorSaveItem
            // 
            this.students_GaisinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.students_GaisinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("students_GaisinBindingNavigatorSaveItem.Image")));
            this.students_GaisinBindingNavigatorSaveItem.Name = "students_GaisinBindingNavigatorSaveItem";
            this.students_GaisinBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.students_GaisinBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.students_GaisinBindingNavigatorSaveItem.Click += new System.EventHandler(this.students_GaisinBindingNavigatorSaveItem_Click);
            // 
            // no_zkLabel
            // 
            no_zkLabel.AutoSize = true;
            no_zkLabel.Location = new System.Drawing.Point(13, 106);
            no_zkLabel.Name = "no_zkLabel";
            no_zkLabel.Size = new System.Drawing.Size(111, 13);
            no_zkLabel.TabIndex = 2;
            no_zkLabel.Text = "№ зачетной книжки:";
            // 
            // no_zkTextBox
            // 
            this.no_zkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GaisinBindingSource, "no_zk", true));
            this.no_zkTextBox.Location = new System.Drawing.Point(130, 99);
            this.no_zkTextBox.Name = "no_zkTextBox";
            this.no_zkTextBox.Size = new System.Drawing.Size(202, 20);
            this.no_zkTextBox.TabIndex = 3;
            // 
            // famLabel
            // 
            famLabel.AutoSize = true;
            famLabel.Location = new System.Drawing.Point(65, 131);
            famLabel.Name = "famLabel";
            famLabel.Size = new System.Drawing.Size(59, 13);
            famLabel.TabIndex = 4;
            famLabel.Text = "Фамилия:";
            // 
            // famTextBox
            // 
            this.famTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GaisinBindingSource, "fam", true));
            this.famTextBox.Location = new System.Drawing.Point(130, 128);
            this.famTextBox.Name = "famTextBox";
            this.famTextBox.Size = new System.Drawing.Size(202, 20);
            this.famTextBox.TabIndex = 5;
            // 
            // imLabel
            // 
            imLabel.AutoSize = true;
            imLabel.Location = new System.Drawing.Point(92, 159);
            imLabel.Name = "imLabel";
            imLabel.Size = new System.Drawing.Size(32, 13);
            imLabel.TabIndex = 6;
            imLabel.Text = "Имя:";
            // 
            // imTextBox
            // 
            this.imTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GaisinBindingSource, "im", true));
            this.imTextBox.Location = new System.Drawing.Point(130, 156);
            this.imTextBox.Name = "imTextBox";
            this.imTextBox.Size = new System.Drawing.Size(202, 20);
            this.imTextBox.TabIndex = 7;
            // 
            // otLabel
            // 
            otLabel.AutoSize = true;
            otLabel.Location = new System.Drawing.Point(67, 188);
            otLabel.Name = "otLabel";
            otLabel.Size = new System.Drawing.Size(57, 13);
            otLabel.TabIndex = 8;
            otLabel.Text = "Отчество:";
            // 
            // otTextBox
            // 
            this.otTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GaisinBindingSource, "ot", true));
            this.otTextBox.Location = new System.Drawing.Point(130, 185);
            this.otTextBox.Name = "otTextBox";
            this.otTextBox.Size = new System.Drawing.Size(202, 20);
            this.otTextBox.TabIndex = 9;
            // 
            // specLabel
            // 
            specLabel.AutoSize = true;
            specLabel.Location = new System.Drawing.Point(36, 217);
            specLabel.Name = "specLabel";
            specLabel.Size = new System.Drawing.Size(88, 13);
            specLabel.TabIndex = 10;
            specLabel.Text = "Специальность:";
            // 
            // specTextBox
            // 
            this.specTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GaisinBindingSource, "spec", true));
            this.specTextBox.Location = new System.Drawing.Point(130, 214);
            this.specTextBox.Name = "specTextBox";
            this.specTextBox.Size = new System.Drawing.Size(202, 20);
            this.specTextBox.TabIndex = 11;
            // 
            // kursLabel
            // 
            kursLabel.AutoSize = true;
            kursLabel.Location = new System.Drawing.Point(90, 245);
            kursLabel.Name = "kursLabel";
            kursLabel.Size = new System.Drawing.Size(34, 13);
            kursLabel.TabIndex = 12;
            kursLabel.Text = "Курс:";
            // 
            // kursTextBox
            // 
            this.kursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GaisinBindingSource, "kurs", true));
            this.kursTextBox.Location = new System.Drawing.Point(130, 242);
            this.kursTextBox.Name = "kursTextBox";
            this.kursTextBox.Size = new System.Drawing.Size(202, 20);
            this.kursTextBox.TabIndex = 13;
            // 
            // grLabel
            // 
            grLabel.AutoSize = true;
            grLabel.Location = new System.Drawing.Point(79, 277);
            grLabel.Name = "grLabel";
            grLabel.Size = new System.Drawing.Size(45, 13);
            grLabel.TabIndex = 14;
            grLabel.Text = "Группа:";
            // 
            // grTextBox
            // 
            this.grTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GaisinBindingSource, "gr", true));
            this.grTextBox.Location = new System.Drawing.Point(130, 274);
            this.grTextBox.Name = "grTextBox";
            this.grTextBox.Size = new System.Drawing.Size(202, 20);
            this.grTextBox.TabIndex = 15;
            // 
            // biogrLabel
            // 
            biogrLabel.AutoSize = true;
            biogrLabel.Location = new System.Drawing.Point(58, 306);
            biogrLabel.Name = "biogrLabel";
            biogrLabel.Size = new System.Drawing.Size(66, 13);
            biogrLabel.TabIndex = 16;
            biogrLabel.Text = "Биография:";
            // 
            // biogrTextBox
            // 
            this.biogrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.students_GaisinBindingSource, "biogr", true));
            this.biogrTextBox.Location = new System.Drawing.Point(130, 303);
            this.biogrTextBox.Name = "biogrTextBox";
            this.biogrTextBox.Size = new System.Drawing.Size(202, 20);
            this.biogrTextBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(153, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Список студентов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(biogrLabel);
            this.Controls.Add(this.biogrTextBox);
            this.Controls.Add(grLabel);
            this.Controls.Add(this.grTextBox);
            this.Controls.Add(kursLabel);
            this.Controls.Add(this.kursTextBox);
            this.Controls.Add(specLabel);
            this.Controls.Add(this.specTextBox);
            this.Controls.Add(otLabel);
            this.Controls.Add(this.otTextBox);
            this.Controls.Add(imLabel);
            this.Controls.Add(this.imTextBox);
            this.Controls.Add(famLabel);
            this.Controls.Add(this.famTextBox);
            this.Controls.Add(no_zkLabel);
            this.Controls.Add(this.no_zkTextBox);
            this.Controls.Add(this.students_GaisinBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Students";
            this.Text = "Студенты_Гайсин";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.education_GaisinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GaisinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.students_GaisinBindingNavigator)).EndInit();
            this.students_GaisinBindingNavigator.ResumeLayout(false);
            this.students_GaisinBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Education_GaisinDataSet education_GaisinDataSet;
        private System.Windows.Forms.BindingSource students_GaisinBindingSource;
        private Education_GaisinDataSetTableAdapters.Students_GaisinTableAdapter students_GaisinTableAdapter;
        private Education_GaisinDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator students_GaisinBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton students_GaisinBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox no_zkTextBox;
        private System.Windows.Forms.TextBox famTextBox;
        private System.Windows.Forms.TextBox imTextBox;
        private System.Windows.Forms.TextBox otTextBox;
        private System.Windows.Forms.TextBox specTextBox;
        private System.Windows.Forms.TextBox kursTextBox;
        private System.Windows.Forms.TextBox grTextBox;
        private System.Windows.Forms.TextBox biogrTextBox;
        private System.Windows.Forms.Button button1;
    }
}