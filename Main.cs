using LUNA.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing.Drawing2D;

namespace LUNA
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        public ContextMenuStrip menu;

        private void newButton_Click(object sender, EventArgs e)
        {
            textBox.Text = string.Empty;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter =
                "Text files (*.txt)|*.txt|Markdown files (*.md)|*.md|Rich text files (*.rtf)|*.rtf";
            saveFileDialog1.Title = "Save file";
            var result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // maybe add dropdown menu here eventually
        }

        // this is the open button i just forgot to name it first
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter =
                "Text files (*.txt)|*.txt|Markdown files (*.md)|*.md|Rich text files (*.rtf)|*.rtf";
            openFileDialog1.Title = "Open file";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var text = File.ReadAllText(openFileDialog1.FileName);

                textBox.Text = text;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            int charCount = textBox.Text.Length;
            charCountLabel.Text = $"characters: {charCount}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        // function from here, thank god, credit to this person
        // https://learn.microsoft.com/en-us/answers/questions/530055/how-to-color-a-specific-string-s-in-richtextbox-te
        void HighlightPhrase(RichTextBox box, string phrase, Color color)
        {
            string results = "";
            int pos = box.SelectionStart;
            string s = box.Text;
            for (int ix = 0; ix < s.Length; ix++)
            {
                int jx = s.IndexOf(phrase, ix, StringComparison.CurrentCultureIgnoreCase);
                if (jx < 0)
                {
                    break;
                }
                else
                {
                    box.SelectionStart = jx;
                    box.SelectionLength = phrase.Length;
                    box.SelectionColor = color;
                    ix = jx + 1;
                    results += jx;
                }
            }

            box.SelectionStart = 0;
            box.SelectionLength = 0;

        }

        private void render_Click(object sender, EventArgs e)
        {
            List<string> MarkdownBaseElements = new List<string>
            {
                "#", "##", "###", "~~", "*", "**", "---", ">", "-", "`", "```", "|", "=="
            };

            // headers
            HighlightPhrase(textBox, MarkdownBaseElements[0], Color.Firebrick);
            HighlightPhrase(textBox, MarkdownBaseElements[1], Color.Firebrick);
            HighlightPhrase(textBox, MarkdownBaseElements[2], Color.Firebrick);

            //strikethrough
            HighlightPhrase(textBox, MarkdownBaseElements[3], Color.Teal);

            //italics
            HighlightPhrase(textBox, MarkdownBaseElements[4], Color.CornflowerBlue);

            // bold
            HighlightPhrase(textBox, MarkdownBaseElements[5], Color.Fuchsia);

            // horizontal rule
            HighlightPhrase(textBox, MarkdownBaseElements[6], Color.Purple);

            // dash / list bullet
            HighlightPhrase(textBox, MarkdownBaseElements[8], Color.Purple);

            // blockquote 
            HighlightPhrase(textBox, MarkdownBaseElements[7], Color.Lime);

            // codeblock
            HighlightPhrase(textBox, MarkdownBaseElements[9], Color.Crimson);
            HighlightPhrase(textBox, MarkdownBaseElements[10], Color.Crimson);

            // pipe character
            HighlightPhrase(textBox, MarkdownBaseElements[11], Color.Blue);

            //highlight
            HighlightPhrase(textBox, MarkdownBaseElements[12], Color.Cyan);
        }

        int theme = 1; // theme thingie
        private void lightMode_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "/theme"))
            {
                File.WriteAllText((Directory.GetCurrentDirectory() + "/theme"), themeButton.Text.ToString());
            }
            else
            {
                MessageBox.Show("Theme file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            switch (theme)
            {
                // light mode
                case 1:
                    // form coloring
                    this.ForeColor = Color.Black;
                    this.BackColor = Color.LightSkyBlue;
                    themeChange1.ForeColor = Color.Black;
                    themeChange2.ForeColor = Color.Black;

                    // buttons
                    openButton.BackColor = Color.LightCyan;
                    saveButton.BackColor = Color.LightCyan;
                    newButton.BackColor = Color.LightCyan;
                    renderButton.BackColor = Color.LightCyan;
                    themeButton.BackColor = Color.LightCyan;
                    themeChange1.BackColor = Color.LightCyan;
                    themeChange2.BackColor = Color.LightCyan;
                    aboutButton.BackColor = Color.LightCyan;

                    // textbox
                    textBox.BackColor = Color.SeaShell;
                    textBox.ForeColor = Color.Black;
                    break;
                // dark mode
                case 2: // not commenting on the rest bc i think u already know what the code is
                    this.ForeColor = Color.White;
                    this.BackColor = Color.DarkSlateBlue;
                    themeChange1.ForeColor = Color.White;
                    themeChange2.ForeColor = Color.White;

                    openButton.BackColor = Color.RoyalBlue;
                    saveButton.BackColor = Color.RoyalBlue;
                    newButton.BackColor = Color.RoyalBlue;
                    renderButton.BackColor = Color.RoyalBlue;
                    themeButton.BackColor = Color.RoyalBlue;
                    themeChange1.BackColor = Color.RoyalBlue;
                    themeChange2.BackColor = Color.RoyalBlue;
                    aboutButton.BackColor = Color.RoyalBlue;

                    textBox.BackColor = Color.Black;
                    textBox.ForeColor = Color.White;
                    break;
                // matcha tea
                case 3:
                    this.ForeColor = Color.Black;
                    this.BackColor = Color.YellowGreen;
                    themeChange1.ForeColor = Color.Black;
                    themeChange2.ForeColor = Color.Black;

                    openButton.BackColor = Color.LightGreen;
                    saveButton.BackColor = Color.LightGreen;
                    newButton.BackColor = Color.LightGreen;
                    renderButton.BackColor = Color.LightGreen;
                    themeButton.BackColor = Color.LightGreen;
                    themeChange1.BackColor = Color.LightGreen;
                    themeChange2.BackColor = Color.LightGreen;
                    aboutButton.BackColor = Color.LightGreen;

                    textBox.BackColor = Color.DarkSeaGreen;
                    textBox.ForeColor = Color.Black;
                    break;
                // hubba bubba
                case 4:
                    this.ForeColor = Color.Black;
                    this.BackColor = Color.DarkRed;
                    themeChange1.ForeColor = Color.Black;
                    themeChange2.ForeColor = Color.Black;

                    openButton.BackColor = Color.Crimson;
                    saveButton.BackColor = Color.Crimson;
                    newButton.BackColor = Color.Crimson;
                    renderButton.BackColor = Color.Crimson;
                    themeButton.BackColor = Color.Crimson;
                    themeChange1.BackColor = Color.Crimson;
                    themeChange2.BackColor = Color.Crimson;
                    aboutButton.BackColor = Color.Crimson;

                    textBox.BackColor = Color.IndianRed;
                    textBox.ForeColor = Color.Black;
                    break;
                // dracula (dracula)
                case 5:
                    this.ForeColor = Color.White;
                    this.BackColor = ColorTranslator.FromHtml("#282a36");
                    themeChange1.ForeColor = Color.White;
                    themeChange2.ForeColor = Color.White;

                    openButton.BackColor = ColorTranslator.FromHtml("#44475A");
                    saveButton.BackColor = ColorTranslator.FromHtml("#44475A");
                    newButton.BackColor = ColorTranslator.FromHtml("#44475A");
                    renderButton.BackColor = ColorTranslator.FromHtml("#44475A");
                    themeButton.BackColor = ColorTranslator.FromHtml("#44475A");
                    themeChange1.BackColor = ColorTranslator.FromHtml("#44475A");
                    themeChange2.BackColor = ColorTranslator.FromHtml("#44475A");
                    aboutButton.BackColor = ColorTranslator.FromHtml("#44475A");

                    textBox.BackColor = ColorTranslator.FromHtml("#6272A4");
                    textBox.ForeColor = Color.White;
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e) // this is themechange 2
        {
            theme += 1;

            // changes the button name so it corresponds with the theme
            switch (theme)
            {
                case 1:
                    themeButton.Text = "Light";
                    break;
                case 2:
                    themeButton.Text = "Dark";
                    break;
                case 3:
                    themeButton.Text = "Matcha";
                    break;
                case 4:
                    themeButton.Text = "Gum";
                    break;
                case 5:
                    themeButton.Text = "Dracula";
                    break;
            }

            // clamp system
            if (theme >= 5)
            {
                theme = 5;
            }
        }

        private void themeChange1_Click(object sender, EventArgs e)
        {
            theme -= 1;

            switch (theme)
            {
                case 1:
                    themeButton.Text = "Light";
                    break;
                case 2:
                    themeButton.Text = "Dark";
                    break;
                case 3:
                    themeButton.Text = "Matcha";
                    break;
                case 4:
                    themeButton.Text = "Gum";
                    break;
                case 5:
                    themeButton.Text = "Dracula";
                    break;
            }

            // clamp system
            if (theme <= 1)
            {
                theme = 1;
            }

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            // opens the about window
            About form = new About();
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // save system
            if (!File.Exists(Directory.GetCurrentDirectory() + "/theme")) 
            {
                File.WriteAllText((Directory.GetCurrentDirectory() + "/theme"), themeButton.Text.ToString());
            }

            // read themes
            switch (File.ReadAllText(Directory.GetCurrentDirectory() + "/theme"))
            {
                case "Light": // these fellas change the theme number and theme text to the corresponding theme, and trigger the button clicking function
                    theme = 1;
                    themeButton.Text = "Light";
                    lightMode_Click(sender, e);
                    break;
                case "Dark":
                    theme = 2;
                    themeButton.Text = "Dark";
                    lightMode_Click(sender, e);
                    break;
                case "Matcha":
                    theme = 3;
                    themeButton.Text = "Matcha";
                    lightMode_Click(sender, e);
                    break;
                case "Gum":
                    theme = 4;
                    themeButton.Text = "Gum";
                    lightMode_Click(sender, e);
                    break;
                case "Dracula":
                    theme = 5;
                    themeButton.Text = "Dracula";
                    lightMode_Click(sender, e);
                    break;
            }
        }
    }
}