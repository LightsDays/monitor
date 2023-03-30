using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Monitor2
{
    public class LightButton : Control
    {
        private StringFormat stringFormat = new();

        private bool mouseEntered = false;
        private bool mousePressed = false;

        public LightButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint 
                | ControlStyles.OptimizedDoubleBuffer 
                | ControlStyles.ResizeRedraw 
                | ControlStyles.SupportsTransparentBackColor 
                | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(260, 100);

            BackColor = Color.Green;
            ForeColor = Color.White;

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;

            graphics.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            graphics.DrawRectangle(new Pen(BackColor), rect);
            graphics.FillRectangle(new SolidBrush(BackColor), rect);

            if (mouseEntered)
            {
                graphics.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rect);
            }

            if (mousePressed)
            {
                graphics.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
            }

            graphics.DrawString(Text, Font, new SolidBrush(ForeColor), rect, stringFormat);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            mouseEntered = true;

            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            mouseEntered = false;

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            mousePressed = true;

            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            mousePressed = false;

            Invalidate();
        }
    }
}
