﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARNET_ASDE
{
    class VerticalTextBox: System.Windows.Forms.TextBox
    {
        private bool bFlip = true;

        public VerticalTextBox()
        {
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.Trimming = StringTrimming.None;
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            Brush textBrush = new SolidBrush(this.ForeColor);

            Matrix storedState = g.Transform;

            if (bFlip)
            {
                g.RotateTransform(180f);
                g.TranslateTransform(-ClientRectangle.Width, -ClientRectangle.Height);
            }
            g.DrawString(
                this.Text,
                this.Font,
                textBrush,
                ClientRectangle,
                stringFormat);

            g.Transform = storedState;
        }

        [Description("When this parameter is true the VLabel flips at 180 degrees."), Category("Appearance")]
        public bool Flip180
        {
            get
            {
                return bFlip;
            }
            set
            {
                bFlip = value;
                this.Invalidate();
            }
        }
    }
}

