namespace VhdAttach {
    partial class SettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.erp = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupContextMenu = new System.Windows.Forms.GroupBox();
            this.checkIsoOpen = new System.Windows.Forms.CheckBox();
            this.checkVhdOpen = new System.Windows.Forms.CheckBox();
            this.checkIsoDetach = new System.Windows.Forms.CheckBox();
            this.checkIsoAttachReadOnly = new System.Windows.Forms.CheckBox();
            this.checkVhdAttachReadOnly = new System.Windows.Forms.CheckBox();
            this.checkVhdDetachDrive = new System.Windows.Forms.CheckBox();
            this.checkVhdDetach = new System.Windows.Forms.CheckBox();
            this.checkVhdAttach = new System.Windows.Forms.CheckBox();
            this.groupAutoAttach = new System.Windows.Forms.GroupBox();
            this.toolVhdOrder = new System.Windows.Forms.ToolStrip();
            this.buttonMoveVhdUp = new System.Windows.Forms.ToolStripButton();
            this.buttonMoveVhdDown = new System.Windows.Forms.ToolStripButton();
            this.buttonVhdReadOnly = new System.Windows.Forms.ToolStripButton();
            this.buttonVhdRemove = new System.Windows.Forms.Button();
            this.buttonVhdAdd = new System.Windows.Forms.Button();
            this.listAutoAttach = new System.Windows.Forms.ListView();
            this.columnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imagesAutoAttach = new System.Windows.Forms.ImageList(this.components);
            this.btnRegisterExtensionVhd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erp)).BeginInit();
            this.groupContextMenu.SuspendLayout();
            this.groupAutoAttach.SuspendLayout();
            this.toolVhdOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(320, 365);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(214, 365);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(100, 28);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // erp
            // 
            this.erp.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erp.ContainerControl = this;
            this.erp.Icon = ((System.Drawing.Icon)(resources.GetObject("erp.Icon")));
            // 
            // groupContextMenu
            // 
            this.groupContextMenu.Controls.Add(this.checkIsoOpen);
            this.groupContextMenu.Controls.Add(this.checkVhdOpen);
            this.groupContextMenu.Controls.Add(this.checkIsoDetach);
            this.groupContextMenu.Controls.Add(this.checkIsoAttachReadOnly);
            this.groupContextMenu.Controls.Add(this.checkVhdAttachReadOnly);
            this.groupContextMenu.Controls.Add(this.checkVhdDetachDrive);
            this.groupContextMenu.Controls.Add(this.checkVhdDetach);
            this.groupContextMenu.Controls.Add(this.checkVhdAttach);
            this.groupContextMenu.Location = new System.Drawing.Point(12, 12);
            this.groupContextMenu.Name = "groupContextMenu";
            this.groupContextMenu.Size = new System.Drawing.Size(408, 108);
            this.groupContextMenu.TabIndex = 1;
            this.groupContextMenu.TabStop = false;
            this.groupContextMenu.Text = "Explorer context menu";
            // 
            // checkIsoOpen
            // 
            this.checkIsoOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIsoOpen.AutoSize = true;
            this.checkIsoOpen.Location = new System.Drawing.Point(290, 27);
            this.checkIsoOpen.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.checkIsoOpen.Name = "checkIsoOpen";
            this.checkIsoOpen.Size = new System.Drawing.Size(102, 21);
            this.checkIsoOpen.TabIndex = 5;
            this.checkIsoOpen.Text = "Open (ISO)";
            this.checkIsoOpen.UseVisualStyleBackColor = true;
            // 
            // checkVhdOpen
            // 
            this.checkVhdOpen.AutoSize = true;
            this.checkVhdOpen.Location = new System.Drawing.Point(6, 27);
            this.checkVhdOpen.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.checkVhdOpen.Name = "checkVhdOpen";
            this.checkVhdOpen.Size = new System.Drawing.Size(65, 21);
            this.checkVhdOpen.TabIndex = 0;
            this.checkVhdOpen.Text = "Open";
            this.checkVhdOpen.UseVisualStyleBackColor = true;
            // 
            // checkIsoDetach
            // 
            this.checkIsoDetach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIsoDetach.AutoSize = true;
            this.checkIsoDetach.Location = new System.Drawing.Point(290, 80);
            this.checkIsoDetach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkIsoDetach.Name = "checkIsoDetach";
            this.checkIsoDetach.Size = new System.Drawing.Size(112, 21);
            this.checkIsoDetach.TabIndex = 7;
            this.checkIsoDetach.Text = "Detach (ISO)";
            this.checkIsoDetach.UseVisualStyleBackColor = true;
            // 
            // checkIsoAttachReadOnly
            // 
            this.checkIsoAttachReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkIsoAttachReadOnly.AutoSize = true;
            this.checkIsoAttachReadOnly.Location = new System.Drawing.Point(290, 54);
            this.checkIsoAttachReadOnly.Name = "checkIsoAttachReadOnly";
            this.checkIsoAttachReadOnly.Size = new System.Drawing.Size(107, 21);
            this.checkIsoAttachReadOnly.TabIndex = 6;
            this.checkIsoAttachReadOnly.Text = "Attach (ISO)";
            this.checkIsoAttachReadOnly.UseVisualStyleBackColor = true;
            // 
            // checkVhdAttachReadOnly
            // 
            this.checkVhdAttachReadOnly.AutoSize = true;
            this.checkVhdAttachReadOnly.Location = new System.Drawing.Point(112, 54);
            this.checkVhdAttachReadOnly.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.checkVhdAttachReadOnly.Name = "checkVhdAttachReadOnly";
            this.checkVhdAttachReadOnly.Size = new System.Drawing.Size(144, 21);
            this.checkVhdAttachReadOnly.TabIndex = 2;
            this.checkVhdAttachReadOnly.Text = "Attach (read-only)";
            this.checkVhdAttachReadOnly.UseVisualStyleBackColor = true;
            // 
            // checkVhdDetachDrive
            // 
            this.checkVhdDetachDrive.AutoSize = true;
            this.checkVhdDetachDrive.Location = new System.Drawing.Point(112, 81);
            this.checkVhdDetachDrive.Name = "checkVhdDetachDrive";
            this.checkVhdDetachDrive.Size = new System.Drawing.Size(110, 21);
            this.checkVhdDetachDrive.TabIndex = 4;
            this.checkVhdDetachDrive.Text = "Detach drive";
            this.checkVhdDetachDrive.UseVisualStyleBackColor = true;
            // 
            // checkVhdDetach
            // 
            this.checkVhdDetach.AutoSize = true;
            this.checkVhdDetach.Location = new System.Drawing.Point(6, 81);
            this.checkVhdDetach.Name = "checkVhdDetach";
            this.checkVhdDetach.Size = new System.Drawing.Size(75, 21);
            this.checkVhdDetach.TabIndex = 3;
            this.checkVhdDetach.Text = "Detach";
            this.checkVhdDetach.UseVisualStyleBackColor = true;
            // 
            // checkVhdAttach
            // 
            this.checkVhdAttach.AutoSize = true;
            this.checkVhdAttach.Location = new System.Drawing.Point(6, 54);
            this.checkVhdAttach.Name = "checkVhdAttach";
            this.checkVhdAttach.Size = new System.Drawing.Size(70, 21);
            this.checkVhdAttach.TabIndex = 1;
            this.checkVhdAttach.Text = "Attach";
            this.checkVhdAttach.UseVisualStyleBackColor = true;
            // 
            // groupAutoAttach
            // 
            this.groupAutoAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupAutoAttach.Controls.Add(this.toolVhdOrder);
            this.groupAutoAttach.Controls.Add(this.buttonVhdRemove);
            this.groupAutoAttach.Controls.Add(this.buttonVhdAdd);
            this.groupAutoAttach.Controls.Add(this.listAutoAttach);
            this.groupAutoAttach.Location = new System.Drawing.Point(12, 132);
            this.groupAutoAttach.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.groupAutoAttach.Name = "groupAutoAttach";
            this.groupAutoAttach.Size = new System.Drawing.Size(408, 215);
            this.groupAutoAttach.TabIndex = 2;
            this.groupAutoAttach.TabStop = false;
            this.groupAutoAttach.Text = "Auto-attach VHDs";
            // 
            // toolVhdOrder
            // 
            this.toolVhdOrder.AllowMerge = false;
            this.toolVhdOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolVhdOrder.AutoSize = false;
            this.toolVhdOrder.CanOverflow = false;
            this.toolVhdOrder.Dock = System.Windows.Forms.DockStyle.None;
            this.toolVhdOrder.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolVhdOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonMoveVhdUp,
            this.buttonMoveVhdDown,
            this.buttonVhdReadOnly});
            this.toolVhdOrder.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolVhdOrder.Location = new System.Drawing.Point(374, 27);
            this.toolVhdOrder.Name = "toolVhdOrder";
            this.toolVhdOrder.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolVhdOrder.Size = new System.Drawing.Size(32, 148);
            this.toolVhdOrder.TabIndex = 1;
            // 
            // buttonMoveVhdUp
            // 
            this.buttonMoveVhdUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonMoveVhdUp.Enabled = false;
            this.buttonMoveVhdUp.Image = global::VhdAttach.Properties.Resources.buttonMoveVhdUp_16;
            this.buttonMoveVhdUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonMoveVhdUp.Name = "buttonMoveVhdUp";
            this.buttonMoveVhdUp.Size = new System.Drawing.Size(23, 20);
            this.buttonMoveVhdUp.Text = "Move Up";
            this.buttonMoveVhdUp.ToolTipText = "Move up (Alt+Up)";
            this.buttonMoveVhdUp.Click += new System.EventHandler(this.buttonMoveVhdUp_Click);
            // 
            // buttonMoveVhdDown
            // 
            this.buttonMoveVhdDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonMoveVhdDown.Enabled = false;
            this.buttonMoveVhdDown.Image = global::VhdAttach.Properties.Resources.buttonMoveVhdDown_16;
            this.buttonMoveVhdDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonMoveVhdDown.Name = "buttonMoveVhdDown";
            this.buttonMoveVhdDown.RightToLeftAutoMirrorImage = true;
            this.buttonMoveVhdDown.Size = new System.Drawing.Size(23, 20);
            this.buttonMoveVhdDown.Text = "Move down";
            this.buttonMoveVhdDown.ToolTipText = "Move down (Alt+Down)";
            this.buttonMoveVhdDown.Click += new System.EventHandler(this.buttonMoveVhdDown_Click);
            // 
            // buttonVhdReadOnly
            // 
            this.buttonVhdReadOnly.CheckOnClick = true;
            this.buttonVhdReadOnly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonVhdReadOnly.Image = global::VhdAttach.Properties.Resources.buttonVhdReadOnly_16;
            this.buttonVhdReadOnly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonVhdReadOnly.Margin = new System.Windows.Forms.Padding(0, 8, 0, 2);
            this.buttonVhdReadOnly.Name = "buttonVhdReadOnly";
            this.buttonVhdReadOnly.Size = new System.Drawing.Size(23, 20);
            this.buttonVhdReadOnly.Text = "Read-only";
            this.buttonVhdReadOnly.Click += new System.EventHandler(this.buttonVhdReadOnly_Click);
            // 
            // buttonVhdRemove
            // 
            this.buttonVhdRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVhdRemove.Enabled = false;
            this.buttonVhdRemove.Location = new System.Drawing.Point(112, 181);
            this.buttonVhdRemove.Name = "buttonVhdRemove";
            this.buttonVhdRemove.Size = new System.Drawing.Size(100, 28);
            this.buttonVhdRemove.TabIndex = 3;
            this.buttonVhdRemove.Text = "&Remove";
            this.buttonVhdRemove.UseVisualStyleBackColor = true;
            this.buttonVhdRemove.Click += new System.EventHandler(this.buttonVhdRemove_Click);
            // 
            // buttonVhdAdd
            // 
            this.buttonVhdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVhdAdd.Location = new System.Drawing.Point(6, 181);
            this.buttonVhdAdd.Name = "buttonVhdAdd";
            this.buttonVhdAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonVhdAdd.TabIndex = 2;
            this.buttonVhdAdd.Text = "&Add";
            this.buttonVhdAdd.UseVisualStyleBackColor = true;
            this.buttonVhdAdd.Click += new System.EventHandler(this.buttonVhdAdd_Click);
            // 
            // listAutoAttach
            // 
            this.listAutoAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAutoAttach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFileName});
            this.listAutoAttach.FullRowSelect = true;
            this.listAutoAttach.GridLines = true;
            this.listAutoAttach.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listAutoAttach.HideSelection = false;
            this.listAutoAttach.Location = new System.Drawing.Point(6, 27);
            this.listAutoAttach.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.listAutoAttach.MultiSelect = false;
            this.listAutoAttach.Name = "listAutoAttach";
            this.listAutoAttach.ShowItemToolTips = true;
            this.listAutoAttach.Size = new System.Drawing.Size(365, 148);
            this.listAutoAttach.SmallImageList = this.imagesAutoAttach;
            this.listAutoAttach.TabIndex = 0;
            this.listAutoAttach.UseCompatibleStateImageBehavior = false;
            this.listAutoAttach.View = System.Windows.Forms.View.Details;
            this.listAutoAttach.SelectedIndexChanged += new System.EventHandler(this.listAutoAttach_SelectedIndexChanged);
            this.listAutoAttach.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.listAutoAttach_PreviewKeyDown);
            // 
            // columnFileName
            // 
            this.columnFileName.Text = "File name";
            this.columnFileName.Width = 200;
            // 
            // imagesAutoAttach
            // 
            this.imagesAutoAttach.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imagesAutoAttach.ImageSize = new System.Drawing.Size(16, 16);
            this.imagesAutoAttach.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRegisterExtensionVhd
            // 
            this.btnRegisterExtensionVhd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegisterExtensionVhd.Location = new System.Drawing.Point(12, 365);
            this.btnRegisterExtensionVhd.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnRegisterExtensionVhd.Name = "btnRegisterExtensionVhd";
            this.btnRegisterExtensionVhd.Size = new System.Drawing.Size(149, 28);
            this.btnRegisterExtensionVhd.TabIndex = 3;
            this.btnRegisterExtensionVhd.Text = "&Register extension";
            this.btnRegisterExtensionVhd.UseVisualStyleBackColor = true;
            this.btnRegisterExtensionVhd.Visible = false;
            this.btnRegisterExtensionVhd.Click += new System.EventHandler(this.btnRegisterExtensionVhd_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(432, 405);
            this.Controls.Add(this.btnRegisterExtensionVhd);
            this.Controls.Add(this.groupAutoAttach);
            this.Controls.Add(this.groupContextMenu);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.erp)).EndInit();
            this.groupContextMenu.ResumeLayout(false);
            this.groupContextMenu.PerformLayout();
            this.groupAutoAttach.ResumeLayout(false);
            this.toolVhdOrder.ResumeLayout(false);
            this.toolVhdOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ErrorProvider erp;
        private System.Windows.Forms.GroupBox groupContextMenu;
        private System.Windows.Forms.CheckBox checkVhdDetachDrive;
        private System.Windows.Forms.CheckBox checkVhdDetach;
        private System.Windows.Forms.CheckBox checkVhdAttach;
        private System.Windows.Forms.GroupBox groupAutoAttach;
        private System.Windows.Forms.Button buttonVhdRemove;
        private System.Windows.Forms.Button buttonVhdAdd;
        private System.Windows.Forms.ListView listAutoAttach;
        private System.Windows.Forms.ColumnHeader columnFileName;
        private System.Windows.Forms.ToolStrip toolVhdOrder;
        private System.Windows.Forms.ToolStripButton buttonMoveVhdUp;
        private System.Windows.Forms.ToolStripButton buttonMoveVhdDown;
        private System.Windows.Forms.ImageList imagesAutoAttach;
        private System.Windows.Forms.CheckBox checkVhdAttachReadOnly;
        private System.Windows.Forms.Button btnRegisterExtensionVhd;
        private System.Windows.Forms.ToolStripButton buttonVhdReadOnly;
        private System.Windows.Forms.CheckBox checkIsoDetach;
        private System.Windows.Forms.CheckBox checkIsoAttachReadOnly;
        private System.Windows.Forms.CheckBox checkVhdOpen;
        private System.Windows.Forms.CheckBox checkIsoOpen;
    }
}