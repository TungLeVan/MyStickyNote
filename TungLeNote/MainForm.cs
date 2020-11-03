using System;
using System.IO;
using System.Windows.Forms;

namespace TungLeNote {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {

        private string dataFolder = Path.Combine(Application.StartupPath, "data");
        private RichTextBox focusingRichTextbox;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            SaveData();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            SaveData();
        }

        private void SaveData() {
            try {
                Cursor.Current = Cursors.WaitCursor;
                richTextBox1.SaveFile(Path.Combine(dataFolder, "richTextBox1.rtf"));
                richTextBox2.SaveFile(Path.Combine(dataFolder, "richTextBox2.rtf"));
                richTextBox3.SaveFile(Path.Combine(dataFolder, "richTextBox3.rtf"));
                richTextBox4.SaveFile(Path.Combine(dataFolder, "richTextBox4.rtf"));
                richTextBox5.SaveFile(Path.Combine(dataFolder, "richTextBox5.rtf"));
                richTextBox6.SaveFile(Path.Combine(dataFolder, "richTextBox6.rtf"));
                richTextBox7.SaveFile(Path.Combine(dataFolder, "richTextBox7.rtf"));
                richTextBox8.SaveFile(Path.Combine(dataFolder, "richTextBox8.rtf"));
                richTextBox9.SaveFile(Path.Combine(dataFolder, "richTextBox9.rtf"));
                richTextBox10.SaveFile(Path.Combine(dataFolder, "richTextBox10.rtf"));
                richTextBox11.SaveFile(Path.Combine(dataFolder, "richTextBox11.rtf"));
                richTextBox12.SaveFile(Path.Combine(dataFolder, "richTextBox12.rtf"));
                richTextBox13.SaveFile(Path.Combine(dataFolder, "richTextBox13.rtf"));
                richTextBox14.SaveFile(Path.Combine(dataFolder, "richTextBox14.rtf"));
                richTextBox15.SaveFile(Path.Combine(dataFolder, "richTextBox15.rtf"));
                richTextBox16.SaveFile(Path.Combine(dataFolder, "richTextBox16.rtf"));
                richTextBox17.SaveFile(Path.Combine(dataFolder, "richTextBox17.rtf"));
                richTextBox18.SaveFile(Path.Combine(dataFolder, "richTextBox18.rtf"));
                richTextBox19.SaveFile(Path.Combine(dataFolder, "richTextBox19.rtf"));
                richTextBox20.SaveFile(Path.Combine(dataFolder, "richTextBox20.rtf"));
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }

        private void LoadData() {
            try {
                Cursor.Current = Cursors.WaitCursor;

                if (!Directory.Exists(dataFolder)) {
                    Directory.CreateDirectory(dataFolder);
                }

                richTextBox1.LoadFile(Path.Combine(dataFolder, "richTextBox1.rtf"));
                richTextBox2.LoadFile(Path.Combine(dataFolder, "richTextBox2.rtf"));
                richTextBox3.LoadFile(Path.Combine(dataFolder, "richTextBox3.rtf"));
                richTextBox4.LoadFile(Path.Combine(dataFolder, "richTextBox4.rtf"));
                richTextBox5.LoadFile(Path.Combine(dataFolder, "richTextBox5.rtf"));
                richTextBox6.LoadFile(Path.Combine(dataFolder, "richTextBox6.rtf"));
                richTextBox7.LoadFile(Path.Combine(dataFolder, "richTextBox7.rtf"));
                richTextBox8.LoadFile(Path.Combine(dataFolder, "richTextBox8.rtf"));
                richTextBox9.LoadFile(Path.Combine(dataFolder, "richTextBox9.rtf"));
                richTextBox10.LoadFile(Path.Combine(dataFolder, "richTextBox10.rtf"));
                richTextBox11.LoadFile(Path.Combine(dataFolder, "richTextBox11.rtf"));
                richTextBox12.LoadFile(Path.Combine(dataFolder, "richTextBox12.rtf"));
                richTextBox13.LoadFile(Path.Combine(dataFolder, "richTextBox13.rtf"));
                richTextBox14.LoadFile(Path.Combine(dataFolder, "richTextBox14.rtf"));
                richTextBox15.LoadFile(Path.Combine(dataFolder, "richTextBox15.rtf"));
                richTextBox16.LoadFile(Path.Combine(dataFolder, "richTextBox16.rtf"));
                richTextBox17.LoadFile(Path.Combine(dataFolder, "richTextBox17.rtf"));
                richTextBox18.LoadFile(Path.Combine(dataFolder, "richTextBox18.rtf"));
                richTextBox19.LoadFile(Path.Combine(dataFolder, "richTextBox19.rtf"));
                richTextBox20.LoadFile(Path.Combine(dataFolder, "richTextBox20.rtf"));
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnFont_Click(object sender, EventArgs e) {
            DialogResult fontResult = fontDialog.ShowDialog();
            if (fontResult == DialogResult.OK) {
                if (focusingRichTextbox != null) {
                    focusingRichTextbox.SelectionFont = fontDialog.Font;
                }
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox1;
        }

        private void richTextBox2_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox2;
        }

        private void richTextBox3_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox3;
        }

        private void richTextBox4_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox4;
        }

        private void richTextBox5_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox5;
        }

        private void richTextBox6_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox6;
        }

        private void richTextBox7_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox7;
        }

        private void richTextBox8_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox8;
        }

        private void richTextBox9_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox9;
        }

        private void richTextBox10_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox10;
        }

        private void richTextBox11_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox11;
        }

        private void richTextBox12_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox12;
        }

        private void richTextBox13_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox13;
        }

        private void richTextBox14_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox14;
        }

        private void richTextBox15_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox15;
        }

        private void richTextBox16_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox16;
        }

        private void richTextBox17_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox17;
        }

        private void richTextBox18_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox18;
        }

        private void richTextBox19_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox19;
        }

        private void richTextBox20_Leave(object sender, EventArgs e) {
            focusingRichTextbox = this.richTextBox20;
        }

        private void SaveWhenPressKey(KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.S) {
                SaveData();
                e.SuppressKeyPress = true;  
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox2_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox3_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox4_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox5_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox6_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox7_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox8_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox9_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox10_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox11_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox12_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox13_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox14_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox15_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox16_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox17_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox18_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox19_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
        private void richTextBox20_KeyDown(object sender, KeyEventArgs e) {
            SaveWhenPressKey(e);
        }
    }
}