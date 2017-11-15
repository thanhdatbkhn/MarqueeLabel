using System;
using ObjCRuntime;

namespace MarqueeLabel
{
	[Native]
	public enum MarqueeType : ulong
	{
		LeftRight = 0,
		RightLeft,
		Continuous,
		ContinuousReverse
	}
}
