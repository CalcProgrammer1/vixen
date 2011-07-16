﻿namespace TestClient
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
			if(disposing && (components != null))
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxSequenceName = new System.Windows.Forms.TextBox();
			this.textBoxSequenceFileName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonFindFile = new System.Windows.Forms.Button();
			this.buttonWriteSequence = new System.Windows.Forms.Button();
			this.buttonReadSequence = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.labelActiveEditor = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.buttonDeleteController = new System.Windows.Forms.Button();
			this.comboBoxOutputModule = new System.Windows.Forms.ComboBox();
			this.comboBoxCombinationStrategy = new System.Windows.Forms.ComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.numericUpDownOutputCount = new System.Windows.Forms.NumericUpDown();
			this.buttonControllerSetup = new System.Windows.Forms.Button();
			this.buttonLinkController = new System.Windows.Forms.Button();
			this.buttonRemoveControllerLink = new System.Windows.Forms.Button();
			this.comboBoxLinkedTo = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.buttonUpdateController = new System.Windows.Forms.Button();
			this.listViewControllers = new System.Windows.Forms.ListView();
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonAddController = new System.Windows.Forms.Button();
			this.textBoxControllerName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.buttonCommitControllerOutputChanges = new System.Windows.Forms.Button();
			this.buttonUpdateControllerOutputName = new System.Windows.Forms.Button();
			this.textBoxControllerOutputName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.listBoxControllerOutputs = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBoxControllerOutputsControllers = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.buttonFileTemplateSetup = new System.Windows.Forms.Button();
			this.comboBoxFileTemplates = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.buttonRefreshLoadedModules = new System.Windows.Forms.Button();
			this.buttonUnloadModule = new System.Windows.Forms.Button();
			this.treeViewLoadedModules = new System.Windows.Forms.TreeView();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.comboBoxNodeTemplates = new System.Windows.Forms.ComboBox();
			this.buttonImportNodeTemplate = new System.Windows.Forms.Button();
			this.panelEditorControlContainer = new System.Windows.Forms.Panel();
			this.buttonFireEffect = new System.Windows.Forms.Button();
			this.label23 = new System.Windows.Forms.Label();
			this.numericUpDownEffectLength = new System.Windows.Forms.NumericUpDown();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.comboBoxEffects = new System.Windows.Forms.ComboBox();
			this.buttonPatchSystemChannels = new System.Windows.Forms.Button();
			this.buttonRemoveSystemFixtureChannel = new System.Windows.Forms.Button();
			this.buttonAddSystemFixtureChannel = new System.Windows.Forms.Button();
			this.treeViewSystemChannels = new System.Windows.Forms.TreeView();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.buttonNodeProperties = new System.Windows.Forms.Button();
			this.buttonCreateNodeTemplate = new System.Windows.Forms.Button();
			this.treeViewNodes = new System.Windows.Forms.TreeView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutputCount)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffectLength)).BeginInit();
			this.tabPage8.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sequence name";
			// 
			// textBoxSequenceName
			// 
			this.textBoxSequenceName.Location = new System.Drawing.Point(114, 72);
			this.textBoxSequenceName.Name = "textBoxSequenceName";
			this.textBoxSequenceName.Size = new System.Drawing.Size(202, 20);
			this.textBoxSequenceName.TabIndex = 1;
			// 
			// textBoxSequenceFileName
			// 
			this.textBoxSequenceFileName.Location = new System.Drawing.Point(114, 98);
			this.textBoxSequenceFileName.Name = "textBoxSequenceFileName";
			this.textBoxSequenceFileName.Size = new System.Drawing.Size(202, 20);
			this.textBoxSequenceFileName.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "File I/O";
			// 
			// buttonFindFile
			// 
			this.buttonFindFile.Location = new System.Drawing.Point(322, 94);
			this.buttonFindFile.Name = "buttonFindFile";
			this.buttonFindFile.Size = new System.Drawing.Size(25, 24);
			this.buttonFindFile.TabIndex = 10;
			this.buttonFindFile.Text = "...";
			this.buttonFindFile.UseVisualStyleBackColor = true;
			this.buttonFindFile.Click += new System.EventHandler(this.buttonFindFile_Click);
			// 
			// buttonWriteSequence
			// 
			this.buttonWriteSequence.Location = new System.Drawing.Point(114, 125);
			this.buttonWriteSequence.Name = "buttonWriteSequence";
			this.buttonWriteSequence.Size = new System.Drawing.Size(75, 23);
			this.buttonWriteSequence.TabIndex = 11;
			this.buttonWriteSequence.Text = "Write";
			this.buttonWriteSequence.UseVisualStyleBackColor = true;
			this.buttonWriteSequence.Click += new System.EventHandler(this.buttonWriteSequence_Click);
			// 
			// buttonReadSequence
			// 
			this.buttonReadSequence.Location = new System.Drawing.Point(192, 125);
			this.buttonReadSequence.Name = "buttonReadSequence";
			this.buttonReadSequence.Size = new System.Drawing.Size(75, 23);
			this.buttonReadSequence.TabIndex = 12;
			this.buttonReadSequence.Text = "Read";
			this.buttonReadSequence.UseVisualStyleBackColor = true;
			this.buttonReadSequence.Click += new System.EventHandler(this.buttonReadSequence_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.CheckFileExists = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(520, 526);
			this.tabControl1.TabIndex = 24;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.labelActiveEditor);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.textBoxSequenceName);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.textBoxSequenceFileName);
			this.tabPage1.Controls.Add(this.buttonFindFile);
			this.tabPage1.Controls.Add(this.buttonWriteSequence);
			this.tabPage1.Controls.Add(this.buttonReadSequence);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(512, 500);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Sequence";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// labelActiveEditor
			// 
			this.labelActiveEditor.AutoSize = true;
			this.labelActiveEditor.Location = new System.Drawing.Point(23, 157);
			this.labelActiveEditor.Name = "labelActiveEditor";
			this.labelActiveEditor.Size = new System.Drawing.Size(86, 13);
			this.labelActiveEditor.TabIndex = 30;
			this.labelActiveEditor.Text = "labelActiveEditor";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(512, 500);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Controller";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.buttonDeleteController);
			this.groupBox2.Controls.Add(this.comboBoxOutputModule);
			this.groupBox2.Controls.Add(this.comboBoxCombinationStrategy);
			this.groupBox2.Controls.Add(this.label24);
			this.groupBox2.Controls.Add(this.numericUpDownOutputCount);
			this.groupBox2.Controls.Add(this.buttonControllerSetup);
			this.groupBox2.Controls.Add(this.buttonLinkController);
			this.groupBox2.Controls.Add(this.buttonRemoveControllerLink);
			this.groupBox2.Controls.Add(this.comboBoxLinkedTo);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.buttonUpdateController);
			this.groupBox2.Controls.Add(this.listViewControllers);
			this.groupBox2.Controls.Add(this.buttonAddController);
			this.groupBox2.Controls.Add(this.textBoxControllerName);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(22, 19);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(465, 451);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Controller";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(38, 341);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Output module:";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(45, 314);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Output count:";
			// 
			// buttonDeleteController
			// 
			this.buttonDeleteController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDeleteController.Location = new System.Drawing.Point(288, 422);
			this.buttonDeleteController.Name = "buttonDeleteController";
			this.buttonDeleteController.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteController.TabIndex = 15;
			this.buttonDeleteController.Text = "Delete";
			this.buttonDeleteController.UseVisualStyleBackColor = true;
			this.buttonDeleteController.Click += new System.EventHandler(this.buttonDeleteController_Click);
			// 
			// comboBoxOutputModule
			// 
			this.comboBoxOutputModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxOutputModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOutputModule.FormattingEnabled = true;
			this.comboBoxOutputModule.Location = new System.Drawing.Point(126, 338);
			this.comboBoxOutputModule.Name = "comboBoxOutputModule";
			this.comboBoxOutputModule.Size = new System.Drawing.Size(211, 21);
			this.comboBoxOutputModule.TabIndex = 3;
			// 
			// comboBoxCombinationStrategy
			// 
			this.comboBoxCombinationStrategy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxCombinationStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCombinationStrategy.FormattingEnabled = true;
			this.comboBoxCombinationStrategy.Location = new System.Drawing.Point(126, 365);
			this.comboBoxCombinationStrategy.Name = "comboBoxCombinationStrategy";
			this.comboBoxCombinationStrategy.Size = new System.Drawing.Size(320, 21);
			this.comboBoxCombinationStrategy.TabIndex = 14;
			// 
			// label24
			// 
			this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(9, 368);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(108, 13);
			this.label24.TabIndex = 13;
			this.label24.Text = "Combination strategy:";
			// 
			// numericUpDownOutputCount
			// 
			this.numericUpDownOutputCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDownOutputCount.Location = new System.Drawing.Point(126, 312);
			this.numericUpDownOutputCount.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
			this.numericUpDownOutputCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDownOutputCount.Name = "numericUpDownOutputCount";
			this.numericUpDownOutputCount.Size = new System.Drawing.Size(58, 20);
			this.numericUpDownOutputCount.TabIndex = 2;
			this.numericUpDownOutputCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// buttonControllerSetup
			// 
			this.buttonControllerSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonControllerSetup.Location = new System.Drawing.Point(6, 422);
			this.buttonControllerSetup.Name = "buttonControllerSetup";
			this.buttonControllerSetup.Size = new System.Drawing.Size(75, 23);
			this.buttonControllerSetup.TabIndex = 12;
			this.buttonControllerSetup.Text = "Setup";
			this.buttonControllerSetup.UseVisualStyleBackColor = true;
			this.buttonControllerSetup.Click += new System.EventHandler(this.buttonControllerSetup_Click);
			// 
			// buttonLinkController
			// 
			this.buttonLinkController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLinkController.Location = new System.Drawing.Point(303, 390);
			this.buttonLinkController.Name = "buttonLinkController";
			this.buttonLinkController.Size = new System.Drawing.Size(75, 23);
			this.buttonLinkController.TabIndex = 11;
			this.buttonLinkController.Text = "Set";
			this.buttonLinkController.UseVisualStyleBackColor = true;
			this.buttonLinkController.Click += new System.EventHandler(this.buttonLinkController_Click);
			// 
			// buttonRemoveControllerLink
			// 
			this.buttonRemoveControllerLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRemoveControllerLink.Location = new System.Drawing.Point(384, 390);
			this.buttonRemoveControllerLink.Name = "buttonRemoveControllerLink";
			this.buttonRemoveControllerLink.Size = new System.Drawing.Size(75, 23);
			this.buttonRemoveControllerLink.TabIndex = 10;
			this.buttonRemoveControllerLink.Text = "Remove";
			this.buttonRemoveControllerLink.UseVisualStyleBackColor = true;
			this.buttonRemoveControllerLink.Click += new System.EventHandler(this.buttonRemoveControllerLink_Click);
			// 
			// comboBoxLinkedTo
			// 
			this.comboBoxLinkedTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxLinkedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLinkedTo.FormattingEnabled = true;
			this.comboBoxLinkedTo.Location = new System.Drawing.Point(126, 392);
			this.comboBoxLinkedTo.Name = "comboBoxLinkedTo";
			this.comboBoxLinkedTo.Size = new System.Drawing.Size(169, 21);
			this.comboBoxLinkedTo.TabIndex = 9;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(63, 395);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 13);
			this.label11.TabIndex = 8;
			this.label11.Text = "Linked to:";
			// 
			// buttonUpdateController
			// 
			this.buttonUpdateController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonUpdateController.Location = new System.Drawing.Point(207, 422);
			this.buttonUpdateController.Name = "buttonUpdateController";
			this.buttonUpdateController.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdateController.TabIndex = 6;
			this.buttonUpdateController.Text = "Update";
			this.buttonUpdateController.UseVisualStyleBackColor = true;
			this.buttonUpdateController.Click += new System.EventHandler(this.buttonUpdateController_Click);
			// 
			// listViewControllers
			// 
			this.listViewControllers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewControllers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listViewControllers.FullRowSelect = true;
			this.listViewControllers.Location = new System.Drawing.Point(19, 19);
			this.listViewControllers.MultiSelect = false;
			this.listViewControllers.Name = "listViewControllers";
			this.listViewControllers.Size = new System.Drawing.Size(427, 252);
			this.listViewControllers.TabIndex = 5;
			this.listViewControllers.UseCompatibleStateImageBehavior = false;
			this.listViewControllers.View = System.Windows.Forms.View.Details;
			this.listViewControllers.SelectedIndexChanged += new System.EventHandler(this.listViewControllers_SelectedIndexChanged);
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Name";
			this.columnHeader4.Width = 137;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Outputs";
			this.columnHeader5.Width = 63;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Output module";
			this.columnHeader6.Width = 176;
			// 
			// buttonAddController
			// 
			this.buttonAddController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAddController.Location = new System.Drawing.Point(126, 422);
			this.buttonAddController.Name = "buttonAddController";
			this.buttonAddController.Size = new System.Drawing.Size(75, 23);
			this.buttonAddController.TabIndex = 4;
			this.buttonAddController.Text = "Add";
			this.buttonAddController.UseVisualStyleBackColor = true;
			this.buttonAddController.Click += new System.EventHandler(this.buttonAddController_Click);
			// 
			// textBoxControllerName
			// 
			this.textBoxControllerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxControllerName.Location = new System.Drawing.Point(126, 286);
			this.textBoxControllerName.Name = "textBoxControllerName";
			this.textBoxControllerName.Size = new System.Drawing.Size(321, 20);
			this.textBoxControllerName.TabIndex = 3;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(79, 289);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 2;
			this.label10.Text = "Name:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.buttonCommitControllerOutputChanges);
			this.tabPage3.Controls.Add(this.buttonUpdateControllerOutputName);
			this.tabPage3.Controls.Add(this.textBoxControllerOutputName);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.listBoxControllerOutputs);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.comboBoxControllerOutputsControllers);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(512, 500);
			this.tabPage3.TabIndex = 8;
			this.tabPage3.Text = "Controller Outputs";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// buttonCommitControllerOutputChanges
			// 
			this.buttonCommitControllerOutputChanges.Location = new System.Drawing.Point(35, 459);
			this.buttonCommitControllerOutputChanges.Name = "buttonCommitControllerOutputChanges";
			this.buttonCommitControllerOutputChanges.Size = new System.Drawing.Size(110, 23);
			this.buttonCommitControllerOutputChanges.TabIndex = 8;
			this.buttonCommitControllerOutputChanges.Text = "Commit Changes";
			this.buttonCommitControllerOutputChanges.UseVisualStyleBackColor = true;
			this.buttonCommitControllerOutputChanges.Click += new System.EventHandler(this.buttonCommitControllerOutputChanges_Click);
			// 
			// buttonUpdateControllerOutputName
			// 
			this.buttonUpdateControllerOutputName.Location = new System.Drawing.Point(351, 412);
			this.buttonUpdateControllerOutputName.Name = "buttonUpdateControllerOutputName";
			this.buttonUpdateControllerOutputName.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdateControllerOutputName.TabIndex = 7;
			this.buttonUpdateControllerOutputName.Text = "Update";
			this.buttonUpdateControllerOutputName.UseVisualStyleBackColor = true;
			this.buttonUpdateControllerOutputName.Click += new System.EventHandler(this.buttonUpdateControllerOutputName_Click);
			// 
			// textBoxControllerOutputName
			// 
			this.textBoxControllerOutputName.Location = new System.Drawing.Point(109, 415);
			this.textBoxControllerOutputName.Name = "textBoxControllerOutputName";
			this.textBoxControllerOutputName.Size = new System.Drawing.Size(236, 20);
			this.textBoxControllerOutputName.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(32, 418);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(71, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Output name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(32, 372);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(299, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "There are other Output properties that could be edited as well.";
			// 
			// listBoxControllerOutputs
			// 
			this.listBoxControllerOutputs.FormattingEnabled = true;
			this.listBoxControllerOutputs.Location = new System.Drawing.Point(30, 90);
			this.listBoxControllerOutputs.Name = "listBoxControllerOutputs";
			this.listBoxControllerOutputs.Size = new System.Drawing.Size(418, 264);
			this.listBoxControllerOutputs.TabIndex = 3;
			this.listBoxControllerOutputs.SelectedIndexChanged += new System.EventHandler(this.listBoxControllerOutputs_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Outputs";
			// 
			// comboBoxControllerOutputsControllers
			// 
			this.comboBoxControllerOutputsControllers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxControllerOutputsControllers.FormattingEnabled = true;
			this.comboBoxControllerOutputsControllers.Location = new System.Drawing.Point(84, 22);
			this.comboBoxControllerOutputsControllers.Name = "comboBoxControllerOutputsControllers";
			this.comboBoxControllerOutputsControllers.Size = new System.Drawing.Size(364, 21);
			this.comboBoxControllerOutputsControllers.TabIndex = 1;
			this.comboBoxControllerOutputsControllers.SelectedIndexChanged += new System.EventHandler(this.comboBoxControllerOutputsControllers_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Controller";
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.buttonFileTemplateSetup);
			this.tabPage5.Controls.Add(this.comboBoxFileTemplates);
			this.tabPage5.Controls.Add(this.label20);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(512, 500);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "File Template";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// buttonFileTemplateSetup
			// 
			this.buttonFileTemplateSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFileTemplateSetup.Location = new System.Drawing.Point(403, 23);
			this.buttonFileTemplateSetup.Name = "buttonFileTemplateSetup";
			this.buttonFileTemplateSetup.Size = new System.Drawing.Size(75, 23);
			this.buttonFileTemplateSetup.TabIndex = 2;
			this.buttonFileTemplateSetup.Text = "Setup";
			this.buttonFileTemplateSetup.UseVisualStyleBackColor = true;
			this.buttonFileTemplateSetup.Click += new System.EventHandler(this.buttonFileTemplateSetup_Click);
			// 
			// comboBoxFileTemplates
			// 
			this.comboBoxFileTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxFileTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFileTemplates.FormattingEnabled = true;
			this.comboBoxFileTemplates.Location = new System.Drawing.Point(112, 25);
			this.comboBoxFileTemplates.Name = "comboBoxFileTemplates";
			this.comboBoxFileTemplates.Size = new System.Drawing.Size(285, 21);
			this.comboBoxFileTemplates.TabIndex = 1;
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(35, 28);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(71, 13);
			this.label20.TabIndex = 0;
			this.label20.Text = "File templates";
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.buttonRefreshLoadedModules);
			this.tabPage6.Controls.Add(this.buttonUnloadModule);
			this.tabPage6.Controls.Add(this.treeViewLoadedModules);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(512, 500);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "System";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// buttonRefreshLoadedModules
			// 
			this.buttonRefreshLoadedModules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRefreshLoadedModules.Location = new System.Drawing.Point(406, 395);
			this.buttonRefreshLoadedModules.Name = "buttonRefreshLoadedModules";
			this.buttonRefreshLoadedModules.Size = new System.Drawing.Size(75, 23);
			this.buttonRefreshLoadedModules.TabIndex = 2;
			this.buttonRefreshLoadedModules.Text = "Refresh";
			this.buttonRefreshLoadedModules.UseVisualStyleBackColor = true;
			this.buttonRefreshLoadedModules.Click += new System.EventHandler(this.buttonRefreshLoadedModules_Click);
			// 
			// buttonUnloadModule
			// 
			this.buttonUnloadModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonUnloadModule.Location = new System.Drawing.Point(32, 395);
			this.buttonUnloadModule.Name = "buttonUnloadModule";
			this.buttonUnloadModule.Size = new System.Drawing.Size(75, 23);
			this.buttonUnloadModule.TabIndex = 1;
			this.buttonUnloadModule.Text = "Unload";
			this.buttonUnloadModule.UseVisualStyleBackColor = true;
			this.buttonUnloadModule.Visible = false;
			this.buttonUnloadModule.Click += new System.EventHandler(this.buttonUnloadModule_Click);
			// 
			// treeViewLoadedModules
			// 
			this.treeViewLoadedModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewLoadedModules.Location = new System.Drawing.Point(32, 22);
			this.treeViewLoadedModules.Name = "treeViewLoadedModules";
			this.treeViewLoadedModules.Size = new System.Drawing.Size(449, 367);
			this.treeViewLoadedModules.TabIndex = 0;
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.comboBoxNodeTemplates);
			this.tabPage7.Controls.Add(this.buttonImportNodeTemplate);
			this.tabPage7.Controls.Add(this.panelEditorControlContainer);
			this.tabPage7.Controls.Add(this.buttonFireEffect);
			this.tabPage7.Controls.Add(this.label23);
			this.tabPage7.Controls.Add(this.numericUpDownEffectLength);
			this.tabPage7.Controls.Add(this.label22);
			this.tabPage7.Controls.Add(this.label21);
			this.tabPage7.Controls.Add(this.comboBoxEffects);
			this.tabPage7.Controls.Add(this.buttonPatchSystemChannels);
			this.tabPage7.Controls.Add(this.buttonRemoveSystemFixtureChannel);
			this.tabPage7.Controls.Add(this.buttonAddSystemFixtureChannel);
			this.tabPage7.Controls.Add(this.treeViewSystemChannels);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(512, 500);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "System Channels";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// comboBoxNodeTemplates
			// 
			this.comboBoxNodeTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNodeTemplates.FormattingEnabled = true;
			this.comboBoxNodeTemplates.Location = new System.Drawing.Point(59, 305);
			this.comboBoxNodeTemplates.Name = "comboBoxNodeTemplates";
			this.comboBoxNodeTemplates.Size = new System.Drawing.Size(166, 21);
			this.comboBoxNodeTemplates.TabIndex = 36;
			// 
			// buttonImportNodeTemplate
			// 
			this.buttonImportNodeTemplate.Location = new System.Drawing.Point(231, 305);
			this.buttonImportNodeTemplate.Name = "buttonImportNodeTemplate";
			this.buttonImportNodeTemplate.Size = new System.Drawing.Size(121, 23);
			this.buttonImportNodeTemplate.TabIndex = 35;
			this.buttonImportNodeTemplate.Text = "Import Template";
			this.buttonImportNodeTemplate.UseVisualStyleBackColor = true;
			this.buttonImportNodeTemplate.Click += new System.EventHandler(this.buttonImportNodeTemplate_Click);
			// 
			// panelEditorControlContainer
			// 
			this.panelEditorControlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panelEditorControlContainer.AutoSize = true;
			this.panelEditorControlContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelEditorControlContainer.Location = new System.Drawing.Point(286, 401);
			this.panelEditorControlContainer.Name = "panelEditorControlContainer";
			this.panelEditorControlContainer.Size = new System.Drawing.Size(0, 0);
			this.panelEditorControlContainer.TabIndex = 34;
			// 
			// buttonFireEffect
			// 
			this.buttonFireEffect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonFireEffect.Location = new System.Drawing.Point(105, 427);
			this.buttonFireEffect.Name = "buttonFireEffect";
			this.buttonFireEffect.Size = new System.Drawing.Size(75, 23);
			this.buttonFireEffect.TabIndex = 32;
			this.buttonFireEffect.Text = "Fire";
			this.buttonFireEffect.UseVisualStyleBackColor = true;
			this.buttonFireEffect.Click += new System.EventHandler(this.buttonFireEffect_Click);
			// 
			// label23
			// 
			this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(174, 403);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(20, 13);
			this.label23.TabIndex = 31;
			this.label23.Text = "ms";
			// 
			// numericUpDownEffectLength
			// 
			this.numericUpDownEffectLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numericUpDownEffectLength.Location = new System.Drawing.Point(105, 401);
			this.numericUpDownEffectLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDownEffectLength.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownEffectLength.Name = "numericUpDownEffectLength";
			this.numericUpDownEffectLength.Size = new System.Drawing.Size(63, 20);
			this.numericUpDownEffectLength.TabIndex = 30;
			this.numericUpDownEffectLength.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			// 
			// label22
			// 
			this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(56, 403);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(19, 13);
			this.label22.TabIndex = 29;
			this.label22.Text = "for";
			// 
			// label21
			// 
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(56, 377);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(43, 13);
			this.label21.TabIndex = 28;
			this.label21.Text = "Effects:";
			// 
			// comboBoxEffects
			// 
			this.comboBoxEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBoxEffects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxEffects.FormattingEnabled = true;
			this.comboBoxEffects.Location = new System.Drawing.Point(105, 374);
			this.comboBoxEffects.Name = "comboBoxEffects";
			this.comboBoxEffects.Size = new System.Drawing.Size(167, 21);
			this.comboBoxEffects.TabIndex = 27;
			this.comboBoxEffects.SelectedIndexChanged += new System.EventHandler(this.comboBoxEffects_SelectedIndexChanged);
			// 
			// buttonPatchSystemChannels
			// 
			this.buttonPatchSystemChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonPatchSystemChannels.Location = new System.Drawing.Point(371, 26);
			this.buttonPatchSystemChannels.Name = "buttonPatchSystemChannels";
			this.buttonPatchSystemChannels.Size = new System.Drawing.Size(75, 23);
			this.buttonPatchSystemChannels.TabIndex = 26;
			this.buttonPatchSystemChannels.Text = "Patch";
			this.buttonPatchSystemChannels.UseVisualStyleBackColor = true;
			this.buttonPatchSystemChannels.Click += new System.EventHandler(this.buttonPatchSystemChannels_Click);
			// 
			// buttonRemoveSystemFixtureChannel
			// 
			this.buttonRemoveSystemFixtureChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRemoveSystemFixtureChannel.Enabled = false;
			this.buttonRemoveSystemFixtureChannel.Location = new System.Drawing.Point(167, 274);
			this.buttonRemoveSystemFixtureChannel.Name = "buttonRemoveSystemFixtureChannel";
			this.buttonRemoveSystemFixtureChannel.Size = new System.Drawing.Size(102, 23);
			this.buttonRemoveSystemFixtureChannel.TabIndex = 25;
			this.buttonRemoveSystemFixtureChannel.Text = "Remove Channel";
			this.buttonRemoveSystemFixtureChannel.UseVisualStyleBackColor = true;
			this.buttonRemoveSystemFixtureChannel.Click += new System.EventHandler(this.buttonRemoveSystemFixtureChannel_Click);
			// 
			// buttonAddSystemFixtureChannel
			// 
			this.buttonAddSystemFixtureChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAddSystemFixtureChannel.Location = new System.Drawing.Point(59, 274);
			this.buttonAddSystemFixtureChannel.Name = "buttonAddSystemFixtureChannel";
			this.buttonAddSystemFixtureChannel.Size = new System.Drawing.Size(102, 23);
			this.buttonAddSystemFixtureChannel.TabIndex = 23;
			this.buttonAddSystemFixtureChannel.Text = "Add Channel";
			this.buttonAddSystemFixtureChannel.UseVisualStyleBackColor = true;
			this.buttonAddSystemFixtureChannel.Click += new System.EventHandler(this.buttonAddSystemFixtureChannel_Click);
			// 
			// treeViewSystemChannels
			// 
			this.treeViewSystemChannels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewSystemChannels.CheckBoxes = true;
			this.treeViewSystemChannels.HideSelection = false;
			this.treeViewSystemChannels.Location = new System.Drawing.Point(59, 55);
			this.treeViewSystemChannels.Name = "treeViewSystemChannels";
			this.treeViewSystemChannels.Size = new System.Drawing.Size(387, 213);
			this.treeViewSystemChannels.TabIndex = 21;
			this.treeViewSystemChannels.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSystemFixtures_AfterCheck);
			this.treeViewSystemChannels.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSystemFixtures_AfterSelect);
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.buttonNodeProperties);
			this.tabPage8.Controls.Add(this.buttonCreateNodeTemplate);
			this.tabPage8.Controls.Add(this.treeViewNodes);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(512, 500);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "Nodes";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// buttonNodeProperties
			// 
			this.buttonNodeProperties.Enabled = false;
			this.buttonNodeProperties.Location = new System.Drawing.Point(150, 469);
			this.buttonNodeProperties.Name = "buttonNodeProperties";
			this.buttonNodeProperties.Size = new System.Drawing.Size(75, 23);
			this.buttonNodeProperties.TabIndex = 2;
			this.buttonNodeProperties.Text = "Properties";
			this.buttonNodeProperties.UseVisualStyleBackColor = true;
			this.buttonNodeProperties.Click += new System.EventHandler(this.buttonNodeProperties_Click);
			// 
			// buttonCreateNodeTemplate
			// 
			this.buttonCreateNodeTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonCreateNodeTemplate.Location = new System.Drawing.Point(27, 469);
			this.buttonCreateNodeTemplate.Name = "buttonCreateNodeTemplate";
			this.buttonCreateNodeTemplate.Size = new System.Drawing.Size(106, 23);
			this.buttonCreateNodeTemplate.TabIndex = 1;
			this.buttonCreateNodeTemplate.Text = "Create Template";
			this.buttonCreateNodeTemplate.UseVisualStyleBackColor = true;
			this.buttonCreateNodeTemplate.Click += new System.EventHandler(this.buttonCreateNodeTemplate_Click);
			// 
			// treeViewNodes
			// 
			this.treeViewNodes.AllowDrop = true;
			this.treeViewNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.treeViewNodes.Location = new System.Drawing.Point(27, 22);
			this.treeViewNodes.Name = "treeViewNodes";
			this.treeViewNodes.Size = new System.Drawing.Size(463, 441);
			this.treeViewNodes.TabIndex = 0;
			this.treeViewNodes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNodes_AfterSelect);
			this.treeViewNodes.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewNodes_DragDrop);
			this.treeViewNodes.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewNodes_DragOver);
			this.treeViewNodes.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.treeViewNodes_GiveFeedback);
			this.treeViewNodes.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.treeViewNodes_QueryContinueDrag);
			this.treeViewNodes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewNodes_MouseDown);
			this.treeViewNodes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeViewNodes_MouseMove);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(520, 24);
			this.menuStrip1.TabIndex = 25;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 550);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutputCount)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownEffectLength)).EndInit();
			this.tabPage8.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxSequenceName;
        private System.Windows.Forms.TextBox textBoxSequenceFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFindFile;
        private System.Windows.Forms.Button buttonWriteSequence;
        private System.Windows.Forms.Button buttonReadSequence;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxOutputModule;
		private System.Windows.Forms.NumericUpDown numericUpDownOutputCount;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxControllerName;
        private System.Windows.Forms.Button buttonAddController;
        private System.Windows.Forms.ListView listViewControllers;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.Button buttonUpdateController;
		private System.Windows.Forms.ComboBox comboBoxLinkedTo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button buttonRemoveControllerLink;
		private System.Windows.Forms.Button buttonLinkController;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Button buttonFileTemplateSetup;
		private System.Windows.Forms.ComboBox comboBoxFileTemplates;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TreeView treeViewLoadedModules;
		private System.Windows.Forms.Button buttonUnloadModule;
		private System.Windows.Forms.Button buttonRefreshLoadedModules;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.Button buttonPatchSystemChannels;
		private System.Windows.Forms.Button buttonRemoveSystemFixtureChannel;
		private System.Windows.Forms.Button buttonAddSystemFixtureChannel;
		private System.Windows.Forms.TreeView treeViewSystemChannels;
		private System.Windows.Forms.Button buttonFireEffect;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.NumericUpDown numericUpDownEffectLength;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ComboBox comboBoxEffects;
		private System.Windows.Forms.Panel panelEditorControlContainer;
		private System.Windows.Forms.Button buttonControllerSetup;
		private System.Windows.Forms.Label labelActiveEditor;
		private System.Windows.Forms.ComboBox comboBoxCombinationStrategy;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.TreeView treeViewNodes;
		private System.Windows.Forms.Button buttonCreateNodeTemplate;
		private System.Windows.Forms.Button buttonImportNodeTemplate;
		private System.Windows.Forms.ComboBox comboBoxNodeTemplates;
		private System.Windows.Forms.Button buttonDeleteController;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button buttonUpdateControllerOutputName;
		private System.Windows.Forms.TextBox textBoxControllerOutputName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox listBoxControllerOutputs;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBoxControllerOutputsControllers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonCommitControllerOutputChanges;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Button buttonNodeProperties;
	}
}

