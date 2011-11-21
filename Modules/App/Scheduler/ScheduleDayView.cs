﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VixenModules.App.Scheduler {
	partial class ScheduleDayView : UserControl, ISchedulerView {
		public ScheduleDayView() {
			InitializeComponent();
		}

		public event EventHandler<ScheduleEventArgs> TimeDoubleClick {
			add { dayPanel.TimeDoubleClick += value; }
			remove { dayPanel.TimeDoubleClick -= value; }
		}

		public event EventHandler<ScheduleItemArgs> ItemDoubleClick {
			add { dayPanel.ItemDoubleClick += value; }
			remove { dayPanel.ItemDoubleClick -= value; }
		}

		public event EventHandler<ScheduleItemArgs> ItemClick {
			add { dayPanel.ItemClick += value; }
			remove { dayPanel.ItemClick -= value; }
		}

		public IScheduleItem SelectedItem {
			get { return dayPanel.SelectedItem; }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public ObservableList<IScheduleItem> Items {
			get { return dayPanel.Items; }
			set { dayPanel.Items = value; }
		}

	}
}