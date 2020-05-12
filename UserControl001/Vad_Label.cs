using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl001
{
    class Vad_Label : Control

    {


        private StringFormat sf = new StringFormat();
        private bool MouseEntred = false;
        private bool MousePressed = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;
            Invalidate();
        }


        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntred = true;
            Invalidate();
        }


        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntred = false;
            Invalidate();
        }


        public Vad_Label()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(100, 30); // Egolds video
            BackColor = Color.Aqua;
                ForeColor = Color.Gray;

            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;
                graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width-1, Height-1);

            graph.DrawRectangle(new Pen(BackColor), rect);

            graph.FillRectangle(new SolidBrush(Color.BlueViolet), rect);
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, sf);


            if (MouseEntred)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(25, Color.White)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(45, Color.White)), rect);

            }


            if (MousePressed)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(55, Color.Red)), rect);
                graph.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Green)), rect);

            }


        }




    }
}
