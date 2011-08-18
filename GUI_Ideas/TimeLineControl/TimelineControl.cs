﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Timeline
{
	public partial class TimelineControl : UserControl
	{
		public TimelineControl()
		{
			InitializeComponent();

			this.DoubleBuffered = true;

			// Reasonable defaults
			TotalTime = TimeSpan.FromMinutes(2);
			VisibleTimeStart = TimeSpan.FromSeconds(0);


			timelineGrid.Scroll += new ScrollEventHandler(OnGridScrolled);
		}

		#region Properties

		public TimeSpan TotalTime
		{
			get { return timelineGrid.TotalTime; }
			set
			{
				timelineGrid.TotalTime = value;
				timelineGrid.Invalidate();
			}
		}

		public TimeSpan VisibleTimeSpan
		{
			get { return timelineGrid.VisibleTimeSpan; }
			set
			{
				timelineGrid.VisibleTimeSpan = value;
				timelineHeader.VisibleTimeSpan = value;
				timelineGrid.Invalidate();
				timelineHeader.Invalidate();
			}
		}

		public TimeSpan VisibleTimeStart
		{
			get { return timelineGrid.VisibleTimeStart; }
			set
			{
				timelineGrid.VisibleTimeStart = value;
                timelineHeader.VisibleTimeStart = value;
				timelineGrid.Invalidate();
				timelineHeader.Invalidate();
			}
		}

		public TimeSpan VisibleTimeEnd
		{
			get { return VisibleTimeStart + VisibleTimeSpan; }
			set
			{
				VisibleTimeStart = value - VisibleTimeSpan;
			}
		}

		#endregion



		void OnGridScrolled(object sender, ScrollEventArgs e)
		{
			if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll) {
                timelineHeader.VisibleTimeStart = timelineGrid.VisibleTimeStart;
				timelineHeader.Invalidate();
			}
		}


		// Zoom in or out (ie. change the visible time span): give a scale < 1.0
		// and it zooms in, > 1.0 and it zooms out.
		public void Zoom(double scale)
		{
			if (scale <= 0.0)
				return;

			VisibleTimeSpan = TimeSpan.FromTicks((long)(VisibleTimeSpan.Ticks * scale));
			timelineHeader.VisibleTimeStart = timelineGrid.VisibleTimeStart;
		}





		// only temporary: remove later on, once there are interfaces for everything in the control
		public TimelineGrid Grid
		{
			get { return this.timelineGrid; }
		}

		public TimelineRowList RowList
		{
			get { return this.timelineRowList; }
		}

		public TimelineHeader Header
		{
			get { return this.timelineHeader; }
		}
	}
}