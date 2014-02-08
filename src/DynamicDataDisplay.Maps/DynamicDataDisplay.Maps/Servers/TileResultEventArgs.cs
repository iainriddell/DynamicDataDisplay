﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Microsoft.Research.DynamicDataDisplay.Charts.Maps
{
	public class TileLoadResultEventArgs : EventArgs
	{
		public TileLoadResult Result { get; internal set; }
		public BitmapImage Image { get; internal set; }
		public TileIndex ID { get; internal set; }
	}

	public enum TileLoadResult
	{
		Success,
		Failure
	}
}
