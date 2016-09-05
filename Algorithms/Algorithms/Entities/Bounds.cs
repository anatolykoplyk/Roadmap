﻿using System;

namespace Algorithms.Entities
{
	public class Bounds : Tuple<int, int, int, int>
	{
		public Bounds(int startRow, int startCol, int numRow, int numCol) : base(startRow, startCol, numRow, numCol) { }

		public int StartRow { get { return Item1; } }
		public int StartCol { get { return Item2; } }
		public int NumRow { get { return Item3; } }
		public int NumCol { get { return Item4; } }
	}
}
