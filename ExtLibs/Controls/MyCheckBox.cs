using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{

    public class MyCheckBox : CheckBox
    {
        private Color _checkedColor = Color.FromArgb(0, 175, 175); // Teal/cyan color when checked
        private Color _uncheckedColor = Color.FromArgb(40, 40, 40); // Dark background when unchecked
        private Color _borderColor = Color.FromArgb(0, 175, 175); // Teal border
        private Color _textColor = Color.White; // White text

        private int boxSize = 16;
        private int boxRadisu = 2;

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 122, 204")]
        public Color CheckedBackColor{ get { return _checkedColor; } set { _checkedColor = value; Invalidate(); } }

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 72, 154")]
        public Color UncheckedBackColor { get { return _uncheckedColor; } set { _uncheckedColor = value; Invalidate(); } }

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 72, 154")]
        public Color BorderColor { get { return _borderColor; } set { _borderColor = value; Invalidate(); } }

        [Browsable(true), Category("Colors")]
        [DefaultValue(typeof(Color), "0, 72, 154")]
        public Color TextColor { get { return _textColor; } set { _textColor = value; Invalidate(); } }

        public MyCheckBox()
        {
            SetStyle(ControlStyles.UserPaint, true);
            FlatStyle = FlatStyle.Flat;
            AutoSize = false;
            Height = boxSize + 4;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 繪製外框
            using (Pen borderPen = new Pen(_borderColor, 1))
            {
                g.DrawRectangle(borderPen, 0, 0, boxSize - 1, boxSize - 1);
            }

            // 如果選中，繪製內部填充方框
            if (Checked)
            {
                using (SolidBrush fillBrush = new SolidBrush(_checkedColor))
                {
                    g.FillRectangle(fillBrush, boxRadisu, boxRadisu,
                                   boxSize - (boxRadisu * 2), boxSize - (boxRadisu * 2));
                }
            }
            else
            {
                // 未選中時可以選擇是否填充背景
                using (SolidBrush backBrush = new SolidBrush(_uncheckedColor))
                {
                    // 如果需要背景填充，取消下面這行的註釋
                    // g.FillRectangle(backBrush, 1, 1, boxSize - 2, boxSize - 2);
                }
            }

            // 繪製文字
            using (SolidBrush textBrush = new SolidBrush(TextColor))
            {
                // 設定文字位置
                int textX = boxSize + 4;
                int textY = (Height - Font.Height) / 2;

                // 繪製文字
                g.DrawString(Text, Font, textBrush, textX, textY);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Invalidate();
        }
    }
}
