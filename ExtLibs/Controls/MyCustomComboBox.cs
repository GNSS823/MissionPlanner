using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace MissionPlanner.Controls
{
    /// <summary>
    /// 客製化下拉選單控制項
    /// </summary>
    public class MyCustomComboBox : ComboBox
    {
        // 顏色設定
        private Color _borderColor = Color.FromArgb(0, 122, 204);
        private Color _buttonColor = Color.FromArgb(0, 122, 204);
        private Color _arrowColor = Color.White;
        
        [Category("外觀")]
        public Color BorderColor 
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }
        
        [Category("外觀")]
        public Color ButtonColor 
        {
            get { return _buttonColor; }
            set { _buttonColor = value; Invalidate(); }
        }
        
        [Category("外觀")]
        public Color ArrowColor 
        {
            get { return _arrowColor; }
            set { _arrowColor = value; Invalidate(); }
        }
        
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
            
            // 繪製控制項外框
            using (Graphics g = e.Graphics)
            {
                // 繪製背景
                using (SolidBrush backBrush = new SolidBrush(BackColor))
                {
                    g.FillRectangle(backBrush, ClientRectangle);
                }
                
                // 繪製下拉按鈕
                Rectangle buttonRect = new Rectangle(
                    Width - 20, 0, 20, Height);
                using (SolidBrush buttonBrush = new SolidBrush(_buttonColor))
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
                    new Point(arrowX + arrowSize/2, arrowY + arrowSize)
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
                        g.DrawString(selectedText, Font, textBrush, 
                            new RectangleF(4, 0, Width - 24, Height), format);
                    }
                }
            }
        }
        
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            // 繪製下拉項目
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
