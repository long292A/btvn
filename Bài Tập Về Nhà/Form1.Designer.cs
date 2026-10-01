namespace Bài_Tập_Về_Nhà
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mnuFont = new MenuStrip();
            mnuSystem = new ToolStripMenuItem();
            mnuNew = new ToolStripMenuItem();
            mnuOpen = new ToolStripMenuItem();
            mnuFormat = new ToolStripMenuItem();
            mnuSave = new ToolStripMenuItem();
            mnuExit = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbNew = new ToolStripButton();
            tsbSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            cmbFonts = new ToolStripComboBox();
            cmbSize = new ToolStripComboBox();
            tsbBold = new ToolStripButton();
            tsbItalic = new ToolStripButton();
            tsbUnderline = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            richText = new RichTextBox();
            mnuFont.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mnuFont
            // 
            mnuFont.ImageScalingSize = new Size(20, 20);
            mnuFont.Items.AddRange(new ToolStripItem[] { mnuSystem, mnuFormat });
            mnuFont.Location = new Point(0, 0);
            mnuFont.Name = "mnuFont";
            mnuFont.Size = new Size(859, 28);
            mnuFont.TabIndex = 1;
            mnuFont.Text = "menuStrip1";
            mnuFont.ItemClicked += mnuFont_ItemClicked;
            // 
            // mnuSystem
            // 
            mnuSystem.DropDownItems.AddRange(new ToolStripItem[] { mnuNew, mnuOpen });
            mnuSystem.Name = "mnuSystem";
            mnuSystem.Size = new Size(88, 24);
            mnuSystem.Text = "Hệ Thống";
            mnuSystem.Click += hệThốngToolStripMenuItem_Click;
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuNew.Size = new Size(256, 26);
            mnuNew.Text = "Tạo văn bản mới";
            mnuNew.Click += NewFile;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.Size = new Size(256, 26);
            mnuOpen.Text = "Mở tập tin";
            mnuOpen.Click += OpenFile;
            // 
            // mnuFormat
            // 
            mnuFormat.DropDownItems.AddRange(new ToolStripItem[] { mnuSave, mnuExit });
            mnuFormat.Name = "mnuFormat";
            mnuFormat.Size = new Size(94, 24);
            mnuFormat.Text = "Định Dạng";
            mnuFormat.Click += mnuFormat_Click;
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            mnuSave.Size = new Size(285, 26);
            mnuSave.Text = "Lưu nội dung văn bản";
            mnuSave.Click += SaveFile;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new Size(285, 26);
            mnuExit.Text = "Thoát";
            mnuExit.Click += mnuExit_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNew, tsbSave, toolStripSeparator1, cmbFonts, cmbSize, tsbBold, tsbItalic, tsbUnderline });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(859, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbNew
            // 
            tsbNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNew.Image = (Image)resources.GetObject("tsbNew.Image");
            tsbNew.ImageTransparentColor = Color.Magenta;
            tsbNew.Name = "tsbNew";
            tsbNew.Size = new Size(29, 25);
            tsbNew.Text = "&New";
            tsbNew.Click += NewFile;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (Image)resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new Size(29, 25);
            tsbSave.Text = "&Save";
            tsbSave.Click += SaveFile;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // cmbFonts
            // 
            cmbFonts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFonts.DropDownWidth = 150;
            cmbFonts.Name = "cmbFonts";
            cmbFonts.Size = new Size(121, 28);
            cmbFonts.SelectedIndexChanged += ChangeFont;
            cmbFonts.Click += cmbFonts_Click;
            // 
            // cmbSize
            // 
            cmbSize.DropDownWidth = 60;
            cmbSize.Name = "cmbSize";
            cmbSize.Size = new Size(121, 28);
            cmbSize.SelectedIndexChanged += ChangeFont;
            // 
            // tsbBold
            // 
            tsbBold.CheckOnClick = true;
            tsbBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbBold.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbBold.Image = (Image)resources.GetObject("tsbBold.Image");
            tsbBold.ImageTransparentColor = Color.Magenta;
            tsbBold.Name = "tsbBold";
            tsbBold.Size = new Size(29, 25);
            tsbBold.Text = "B";
            tsbBold.Click += tsbBold_Click;
            // 
            // tsbItalic
            // 
            tsbItalic.CheckOnClick = true;
            tsbItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbItalic.Font = new Font("Times New Roman", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tsbItalic.Image = (Image)resources.GetObject("tsbItalic.Image");
            tsbItalic.ImageTransparentColor = Color.Magenta;
            tsbItalic.Name = "tsbItalic";
            tsbItalic.Size = new Size(29, 25);
            tsbItalic.Text = "I";
            tsbItalic.Click += tsbItalic_Click;
            // 
            // tsbUnderline
            // 
            tsbUnderline.CheckOnClick = true;
            tsbUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbUnderline.Font = new Font("Times New Roman", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            tsbUnderline.Image = (Image)resources.GetObject("tsbUnderline.Image");
            tsbUnderline.ImageTransparentColor = Color.Magenta;
            tsbUnderline.Name = "tsbUnderline";
            tsbUnderline.Size = new Size(29, 25);
            tsbUnderline.Text = "U";
            tsbUnderline.Click += tsbUnderline_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 479);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(859, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            statusStrip1.ItemClicked += statusStrip1_ItemClicked;
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(95, 20);
            lblStatus.Text = "Tổng số từ: 0";
            // 
            // richText
            // 
            richText.Dock = DockStyle.Fill;
            richText.Location = new Point(0, 56);
            richText.Name = "richText";
            richText.Size = new Size(859, 423);
            richText.TabIndex = 4;
            richText.Text = "";
            richText.SelectionChanged += richText_SelectionChanged;
            richText.TextChanged += richText_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 505);
            Controls.Add(richText);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(mnuFont);
            MainMenuStrip = mnuFont;
            Name = "Form1";
            Text = "Soạn Thảo Văn Bản ";
            Load += Form1_Load;
            mnuFont.ResumeLayout(false);
            mnuFont.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip mnuFont;
        private ToolStripMenuItem mnuSystem;
        private ToolStripMenuItem mnuFormat;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem mnuNew;
        private ToolStripMenuItem mnuOpen;
        private ToolStripMenuItem mnuSave;
        private ToolStripMenuItem mnuExit;
        private ToolStripButton tsbNew;
        private ToolStripButton tsbSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox cmbFonts;
        private ToolStripComboBox cmbSize;
        private ToolStripButton tsbBold;
        private ToolStripButton tsbItalic;
        private ToolStripButton tsbUnderline;
        private ToolStripStatusLabel lblStatus;
        private RichTextBox richText;
    }
}
