﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M68K {
	public abstract class MemoryMappedDevice {
		public abstract int Size { get; }
	}
}