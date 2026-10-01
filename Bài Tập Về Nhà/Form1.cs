using System.Drawing.Text;
using System.IO;

namespace Bài_Tập_Về_Nhà
{
    public partial class Form1 : Form
    {
        private string currentFile = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đưa tất cả font của hệ thống vào ComboBox Font
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                cmbFonts.Items.Add(font.Name);
            }

            // Đưa các cỡ chữ vào ComboBox Size
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int s in sizes)
            {
                cmbSize.Items.Add(s.ToString());
            }

            // Đặt giá trị mặc định: Tahoma, 14
            SetDefault();
        }
        private void SetDefault()
        {
            richText.Font = new Font("Tahoma", 14);
            richText.ForeColor = Color.Black;

            cmbFonts.SelectedItem = "Tahoma";
            cmbSize.SelectedItem = "14";

            tsbBold.Checked = false;
            tsbItalic.Checked = false;
            tsbUnderline.Checked = false;
        }
        private void ApplyStyle(FontStyle style, bool on)
        {
            // Nếu vùng chọn có nhiều font khác nhau, SelectionFont sẽ là null
            Font current = richText.SelectionFont ?? richText.Font;

            FontStyle newStyle;
            if (on)
                newStyle = current.Style | style;     // Thêm kiểu
            else
                newStyle = current.Style & ~style;    // Bỏ kiểu

            richText.SelectionFont = new Font(current, newStyle);
        }
        private void ChangeFont(object sender, EventArgs e)
        {
            // Chưa chọn đủ font và size thì chưa làm gì
            if (cmbFonts.SelectedIndex == -1 || cmbSize.SelectedIndex == -1)
                return;

            float size = float.Parse(cmbSize.SelectedItem.ToString());
            Font current = richText.SelectionFont ?? richText.Font;

            richText.SelectionFont = new Font(cmbFonts.SelectedItem.ToString(), size, current.Style);
        }
        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            richText.Clear();      // Xóa nội dung hiện có
            currentFile = null;    // Văn bản mới, chưa lưu
            SetDefault();          // Tạo lại Font, Size mặc định
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cmbFonts_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbNew_Click(object sender, EventArgs e)
        {

        }


        private void tsbSave_Click(object sender, EventArgs e)
        {

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text và RTF (*.txt;*.rtf)|*.txt;*.rtf";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(dlg.FileName).ToLower();

                if (ext == ".rtf")
                    richText.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);
                else
                    richText.LoadFile(dlg.FileName, RichTextBoxStreamType.PlainText);

                currentFile = dlg.FileName;   // Nhớ file đang mở
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (currentFile == null)
            {
                // Văn bản mới, chưa lưu lần nào -> hiện hộp thoại chọn nơi lưu, kiểu *.rtf
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "Rich Text Format (*.rtf)|*.rtf";
                dlg.DefaultExt = "rtf";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    richText.SaveFile(dlg.FileName, RichTextBoxStreamType.RichText);
                    currentFile = dlg.FileName;
                }
            }
            else
            {
                // Văn bản đã mở trước đó -> lưu thẳng và thông báo thành công
                if (Path.GetExtension(currentFile).ToLower() == ".rtf")
                    richText.SaveFile(currentFile, RichTextBoxStreamType.RichText);
                else
                    richText.SaveFile(currentFile, RichTextBoxStreamType.PlainText);

                MessageBox.Show("Lưu văn bản thành công!");
            }
        }

        private void tsbBold_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Bold, tsbBold.Checked);
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Italic, tsbItalic.Checked);

        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            ApplyStyle(FontStyle.Underline, tsbUnderline.Checked);

        }

        private void mnuFormat_Click(object sender, EventArgs e)
        {

        }

        private void mnuFont_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDlg.Color;
                richText.Font = fontDlg.Font;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void richText_TextChanged(object sender, EventArgs e)
        {

            string[] words = richText.Text.Split(
                new char[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            lblStatus.Text = "Tổng số từ: " + words.Length;
        }

        private void richText_SelectionChanged(object sender, EventArgs e)
        {
            Font f = richText.SelectionFont;
            if (f != null)
            {
                tsbBold.Checked = f.Bold;
                tsbItalic.Checked = f.Italic;
                tsbUnderline.Checked = f.Underline;
            }
        }

        private void NewFile(object sender, EventArgs e)
        {

        }

        private void OpenFile(object sender, EventArgs e)
        {

        }

        private void SaveFile(object sender, EventArgs e)
        {

        }
    }
}


