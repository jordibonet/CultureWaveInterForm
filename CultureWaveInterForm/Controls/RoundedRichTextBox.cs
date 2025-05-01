using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CultureWave_Form.Controls
{
    public partial class RoundedRichTextBox : UserControl
    {
        private RichTextBox richTextBox1 = new RichTextBox();

        private Color borderColor = Color.FromArgb(172, 93, 51);
        private Color borderFocusColor = Color.FromArgb(228, 179, 99);
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private bool isFocused = false;
        private int borderRadius = 0;
        private Color placeholderColor = Color.FromArgb(18, 18, 18);
        private string placeholderText = "";
        private bool isPlaceholder = false;

        public event EventHandler _TextChanged;

        public RoundedRichTextBox()
        {
            this.DoubleBuffered = true;
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(242, 235, 229); // Mismo color de fondo
            this.ForeColor = Color.FromArgb(18, 18, 18);

            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.BackColor = this.BackColor;
            richTextBox1.ForeColor = this.ForeColor;

            // Registrar eventos
            richTextBox1.Enter += richTextBox1_Enter;
            richTextBox1.Leave += richTextBox1_Leave;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.Click += richTextBox1_Click;
            richTextBox1.MouseEnter += richTextBox1_MouseEnter;
            richTextBox1.MouseLeave += richTextBox1_MouseLeave;
            richTextBox1.KeyPress += richTextBox1_KeyPress;

            this.Controls.Add(richTextBox1);

            SetPlaceholder();
            UpdateControlHeight();
        }

        #region Placeholder y bordes

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text) && !string.IsNullOrEmpty(placeholderText))
            {
                isPlaceholder = true;
                richTextBox1.Text = placeholderText;
                richTextBox1.ForeColor = placeholderColor;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder)
            {
                isPlaceholder = false;
                richTextBox1.Text = "";
                richTextBox1.ForeColor = this.ForeColor;
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void UpdateControlHeight()
        {
            if (!richTextBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                richTextBox1.Multiline = true;
                richTextBox1.MinimumSize = new Size(0, txtHeight);
                richTextBox1.Multiline = false;

                this.Height = richTextBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        #endregion

        #region Properties

        [Category("RoundedTextBox")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set { borderFocusColor = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Padding = new Padding(value); this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set { underlinedStyle = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("RoundedTextBox")]
        public string PlaceholderText
        {
            get => placeholderText;
            set { placeholderText = value; SetPlaceholder(); }
        }

        [Category("RoundedTextBox")]
        public Color PlaceholderColor
        {
            get => placeholderColor;
            set { placeholderColor = value; if (isPlaceholder) richTextBox1.ForeColor = value; }
        }

        [Category("RoundedTextBox")]
        public override Color BackColor
        {
            get => base.BackColor;
            set { base.BackColor = value; if (!isPlaceholder) richTextBox1.BackColor = value; }
        }

        [Category("RoundedTextBox")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set { base.ForeColor = value; if (!isPlaceholder) richTextBox1.ForeColor = value; }
        }

        [Category("RoundedTextBox")]
        public override Font Font
        {
            get => base.Font;
            set { base.Font = value; richTextBox1.Font = value; UpdateControlHeight(); }
        }

        [Category("RoundedTextBox")]
        public string Texts
        {
            get => isPlaceholder ? "" : richTextBox1.Text;
            set { richTextBox1.Text = value; SetPlaceholder(); }
        }

        [Browsable(false)]
        public RichTextBox RichTextBox => richTextBox1;

        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            Rectangle rectBorder = this.ClientRectangle;
            rectBorder.Inflate(-1, -1);

            if (borderRadius > 1)
            {
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius))
                using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathBorder);
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
                {
                    this.Region = new Region(rectBorder);
                    graph.SmoothingMode = SmoothingMode.None;
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetPlaceholder();
        }

        #endregion

        #region Eventos RichTextBox

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            RemovePlaceholder();
            Invalidate();
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            SetPlaceholder();
            Invalidate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void richTextBox1_Click(object sender, EventArgs e) => this.OnClick(e);
        private void richTextBox1_MouseEnter(object sender, EventArgs e) => this.OnMouseEnter(e);
        private void richTextBox1_MouseLeave(object sender, EventArgs e) => this.OnMouseLeave(e);
        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e) => this.OnKeyPress(e);

        #endregion
    }
}
