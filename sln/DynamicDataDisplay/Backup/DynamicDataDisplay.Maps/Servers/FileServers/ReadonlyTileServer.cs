﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Media.Imaging;

namespace Microsoft.Research.DynamicDataDisplay.Charts.Maps
{
	public abstract class ReadonlyTileServer : TileServerBase, IWriteableTileServer
	{
		private ReadonlyTileCache cache = new ReadonlyTileCache();
		public ReadonlyTileCache Cache
		{
			get { return cache; }
			protected set { cache = value; }
		} 

		public override bool Contains(TileIndex id)
		{
			return cache.Contains(id);
		}

		#region ITileStore Members

		public void BeginSaveImage(TileIndex id, BitmapImage image)
		{
			// do nothing
		}

		#endregion
	}
}
