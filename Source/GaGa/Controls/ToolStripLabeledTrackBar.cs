﻿
// GaGa.
// A minimal radio player for the Windows Tray.


using System;
using System.Drawing;
using System.Windows.Forms;


namespace GaGa.Controls
{
    [System.ComponentModel.DesignerCategory("")]
    internal class LabeledTrackBar : Panel
    {
        public Label Label;
        public TrackBar TrackBar;

        public LabeledTrackBar()
        {
            Label = new Label();
            Label.Location = new Point(0, 0);

            TrackBar = new TrackBar();
            TrackBar.Location = new Point(0, Label.Bottom);

            TrackBar.AutoSize = false;
            TrackBar.TickStyle = TickStyle.None;
            TrackBar.Height = (Int32) (TrackBar.PreferredSize.Height * 0.65);
            TrackBar.Width = (Int32) (TrackBar.PreferredSize.Width * 1.2);

            Controls.Add(Label);
            Controls.Add(TrackBar);

            Width = Math.Max(Label.Width, TrackBar.Width);
        }
    }

    [System.ComponentModel.DesignerCategory("")]
    internal class ToolStripLabeledTrackBar : ToolStripControlHost
    {
        public Label Label;
        public TrackBar TrackBar;

        public ToolStripLabeledTrackBar() : base(new LabeledTrackBar())
        {
            LabeledTrackBar control = (LabeledTrackBar) this.Control;
            
            Label = control.Label;
            TrackBar = control.TrackBar;
        }
    }
}
