using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace MissionPlanner.Controls
{
    /// <summary>
    /// 客製化下拉選單控制項，支援漸層背景
    /// </summary>
    public class MyCustomComboBox : ComboBox
    {
        // 顏色設定
        private Color _borderColor;
        private Color _buttonColor;
        private Color _arrowColor;
        private Color _bgGradTop;
        private Color _bgGradBot;
        private Color _buttonGradTop;
        private Color _buttonGradBot;

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 122, 204")]
        public Color BorderColor { get { return _borderColor; } set { _borderColor = value; Invalidate(); } }

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 122, 204")]
        public Color ButtonColor { get { return _buttonColor; } set { _buttonColor = value; Invalidate(); } }

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "255, 255, 255")]
        public Color ArrowColor { get { return _arrowColor; } set { _arrowColor = value; Invalidate(); } }

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 122, 204")]
        public Color BGGradTop { get { return _bgGradTop; } set { _bgGradTop = value; Invalidate(); } }

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 72, 154")]
        public Color BGGradBot { get { return _bgGradBot; } set { _bgGradBot = value; Invalidate(); } }

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 72, 154")]
        public Color ButtonGradTop { get { return _buttonGradTop; } set { _buttonGradTop = value; Invalidate(); } }
        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 122, 204")]
        public Color ButtonGradBot { get { return _buttonGradBot; } set { _buttonGradBot = value; Invalidate(); } }


        public MyCustomComboBox()
        {
            SetStyle(ControlStyles.UserPaint, true);
            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;
            BackColor = Color.White;
            FlatStyle = FlatStyle.Flat;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Graphics g = e.Graphics)
            {
                // 繪製漸層背景
                using (LinearGradientBrush gradientBrush = new LinearGradientBrush(ClientRectangle, _bgGradTop, _bgGradBot, LinearGradientMode.Vertical))
                {
                   g.FillRectangle(gradientBrush, ClientRectangle);
                }

                // 繪製下拉按鈕
                Rectangle buttonRect = new Rectangle(Width - 20, 0, 20, Height);
                using (LinearGradientBrush buttonBrush = new LinearGradientBrush(buttonRect, _buttonGradTop, _buttonGradBot, LinearGradientMode.Vertical))
                {
                    g.FillRectangle(buttonBrush, buttonRect);
                }

                // 繪製下拉箭頭
                int arrowSize = 8;
                int arrowX = Width - 14;
                int arrowY = (Height - arrowSize) / 2;
                Point[] arrow = new Point[3] {
                        new Point(arrowX, arrowY),
                        new Point(arrowX + arrowSize, arrowY),
                        new Point(arrowX + arrowSize / 2, arrowY + arrowSize)
                    };

                using (SolidBrush arrowBrush = new SolidBrush(_arrowColor))
                {
                    g.FillPolygon(arrowBrush, arrow);
                }

                // 繪製邊框
                using (Pen borderPen = new Pen(_borderColor))
                {
                    g.DrawRectangle(borderPen, 0, 0, Width - 1, Height - 1);
                }

                // 繪製所選擇的文字
                if (SelectedIndex != -1)
                {
                    string selectedText = GetItemText(SelectedItem);
                    using (SolidBrush textBrush = new SolidBrush(ForeColor))
                    {
                        StringFormat format = new StringFormat
                        {
                            LineAlignment = StringAlignment.Center,
                            Alignment = StringAlignment.Near,
                            FormatFlags = StringFormatFlags.NoWrap
                        };
                        g.DrawString(selectedText, Font, textBrush, new RectangleF(4, 0, Width - 24, Height), format);
                    }
                }
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0)
            {
                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(GetItemText(Items[e.Index]), Font, brush, e.Bounds);
                }
            }

            e.DrawFocusRectangle();
        }
    }
}
