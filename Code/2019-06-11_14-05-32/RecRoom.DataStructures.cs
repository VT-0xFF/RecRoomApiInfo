using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class TimeSeriesRollingWindow<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly float SampleInterval;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly float WindowLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private List<Tuple<float, T>> samples;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MaxSampleCount
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x19C2270", Offset = "0x19C1670", VA = "0x1819C2270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x19C21C0", Offset = "0x19C15C0", VA = "0x1819C21C0")]
	public TimeSeriesRollingWindow(float sampleInterval, float windowLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x19C1F00", Offset = "0x19C1300", VA = "0x1819C1F00")]
	public bool TryToAddSample(float time, T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x19C1740", Offset = "0x19C0B40", VA = "0x1819C1740")]
	public int GetCount(float time)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x19C1AF0", Offset = "0x19C0EF0", VA = "0x1819C1AF0")]
	public IEnumerable<T> GetSamples(float time, [Optional] float? minTime)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x19C1710", Offset = "0x19C0B10", VA = "0x1819C1710")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x19C1E40", Offset = "0x19C1240", VA = "0x1819C1E40")]
	private void RemoveOldSamples(float time)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xE34880", Offset = "0xE33C80", VA = "0x180E34880")]
	public static Tuple<T1> Create<T1>(T1 item1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x10166B0", Offset = "0x1015AB0", VA = "0x1810166B0")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1016220", Offset = "0x1015620", VA = "0x181016220")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1016590", Offset = "0x1015990", VA = "0x181016590")]
	public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x10164F0", Offset = "0x10158F0", VA = "0x1810164F0")]
	public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1016440", Offset = "0x1015840", VA = "0x181016440")]
	public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1016380", Offset = "0x1015780", VA = "0x181016380")]
	public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x10162B0", Offset = "0x10156B0", VA = "0x1810162B0")]
	public static Tuple<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x15FA670", Offset = "0x15F9A70", VA = "0x1815FA670")]
	internal static int CombineHashCodes(int h1, int h2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1888850", Offset = "0x1887C50", VA = "0x181888850")]
	internal static int CombineHashCodes(int h1, int h2, int h3)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1888860", Offset = "0x1887C60", VA = "0x181888860")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EDCC40", Offset = "0x1EDC040", VA = "0x181EDCC40")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1EDCC90", Offset = "0x1EDC090", VA = "0x181EDCC90")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1EDCCB0", Offset = "0x1EDC0B0", VA = "0x181EDCCB0")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1EDCC60", Offset = "0x1EDC060", VA = "0x181EDCC60")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class Tuple<T1> : IComparable<Tuple<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly T1 Item1;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xFB10E0", Offset = "0xFB04E0", VA = "0x180FB10E0")]
	public Tuple(T1 item1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x19C39B0", Offset = "0x19C2DB0", VA = "0x1819C39B0", Slot = "4")]
	public int CompareTo(Tuple<T1> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x19C3A20", Offset = "0x19C2E20", VA = "0x1819C3A20", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4B96E0", Offset = "0x4B8AE0", VA = "0x1804B96E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x19C3AC0", Offset = "0x19C2EC0", VA = "0x1819C3AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class Tuple<T1, T2> : IComparable<Tuple<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly T2 Item2;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x18093E0", Offset = "0x18087E0", VA = "0x1818093E0")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x19C3CE0", Offset = "0x19C30E0", VA = "0x1819C3CE0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x19C3DA0", Offset = "0x19C31A0", VA = "0x1819C3DA0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x19C4100", Offset = "0x19C3500", VA = "0x1819C4100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x19C42D0", Offset = "0x19C36D0", VA = "0x1819C42D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class Tuple<T1, T2, T3> : IComparable<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly T2 Item2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly T3 Item3;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x19C4D50", Offset = "0x19C4150", VA = "0x1819C4D50")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x19C4570", Offset = "0x19C3970", VA = "0x1819C4570", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x19C4860", Offset = "0x19C3C60", VA = "0x1819C4860", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x19C49D0", Offset = "0x19C3DD0", VA = "0x1819C49D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x19C4BC0", Offset = "0x19C3FC0", VA = "0x1819C4BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class Tuple<T1, T2, T3, T4> : IComparable<Tuple<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly T2 Item2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly T3 Item3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly T4 Item4;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x180B750", Offset = "0x180AB50", VA = "0x18180B750")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x19C4DA0", Offset = "0x19C41A0", VA = "0x1819C4DA0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x19C4EE0", Offset = "0x19C42E0", VA = "0x1819C4EE0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x19C5000", Offset = "0x19C4400", VA = "0x1819C5000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x19C50C0", Offset = "0x19C44C0", VA = "0x1819C50C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class Tuple<T1, T2, T3, T4, T5> : IComparable<Tuple<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly T2 Item2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly T3 Item3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly T4 Item4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly T5 Item5;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x19C56C0", Offset = "0x19C4AC0", VA = "0x1819C56C0")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x19C51D0", Offset = "0x19C45D0", VA = "0x1819C51D0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4, T5> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x19C5350", Offset = "0x19C4750", VA = "0x1819C5350", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x19C5490", Offset = "0x19C4890", VA = "0x1819C5490", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x19C5590", Offset = "0x19C4990", VA = "0x1819C5590", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class Tuple<T1, T2, T3, T4, T5, T6> : IComparable<Tuple<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly T2 Item2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly T3 Item3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly T4 Item4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly T5 Item5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly T6 Item6;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x19C5CD0", Offset = "0x19C50D0", VA = "0x1819C5CD0")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x19C5730", Offset = "0x19C4B30", VA = "0x1819C5730", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4, T5, T6> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x19C58F0", Offset = "0x19C4CF0", VA = "0x1819C58F0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x19C5A60", Offset = "0x19C4E60", VA = "0x1819C5A60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x19C5B80", Offset = "0x19C4F80", VA = "0x1819C5B80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class Tuple<T1, T2, T3, T4, T5, T6, T7> : IComparable<Tuple<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly T2 Item2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly T3 Item3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public readonly T4 Item4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly T5 Item5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T6 Item6;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T7 Item7;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x19C63B0", Offset = "0x19C57B0", VA = "0x1819C63B0")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x19C5D40", Offset = "0x19C5140", VA = "0x1819C5D40", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4, T5, T6, T7> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x19C5F50", Offset = "0x19C5350", VA = "0x1819C5F50", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x19C60F0", Offset = "0x19C54F0", VA = "0x1819C60F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x19C6240", Offset = "0x19C5640", VA = "0x1819C6240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class Tuple<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 Item1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 Item2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 Item3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly T4 Item4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T5 Item5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T6 Item6;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T7 Item7;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T8 Item8;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x19C6B40", Offset = "0x19C5F40", VA = "0x1819C6B40")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x19C6430", Offset = "0x19C5830", VA = "0x1819C6430", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4, T5, T6, T7, T8> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x19C6680", Offset = "0x19C5A80", VA = "0x1819C6680", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x19C6840", Offset = "0x19C5C40", VA = "0x1819C6840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x19C69B0", Offset = "0x19C5DB0", VA = "0x1819C69B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public T Value
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA40", Offset = "0x2FAE40", VA = "0x1802FBA40")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2FBA50", Offset = "0x2FAE50", VA = "0x1802FBA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float Duration
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6696E0", Offset = "0x668AE0", VA = "0x1806696E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E9C0C0", Offset = "0x1E9B4C0", VA = "0x181E9C0C0")]
	public T Evaluate(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E9BE00", Offset = "0x1E9B200", VA = "0x181E9BE00")]
	public T EvaluateNonNormalized(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T Interpolate(T lhs, T rhs, float t);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xC146C0", Offset = "0xC13AC0", VA = "0x180C146C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1EDC470", Offset = "0x1EDB870", VA = "0x181EDC470", Slot = "4")]
	protected override float Interpolate(float lhs, float rhs, float t)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1EDC4F0", Offset = "0x1EDB8F0", VA = "0x181EDC4F0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1EDCCE0", Offset = "0x1EDC0E0", VA = "0x181EDCCE0", Slot = "4")]
	protected override Vector3 Interpolate(Vector3 lhs, Vector3 rhs, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1EDCDA0", Offset = "0x1EDC1A0", VA = "0x181EDCDA0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1EDC3E0", Offset = "0x1EDB7E0", VA = "0x181EDC3E0", Slot = "4")]
	protected override Color Interpolate(Color lhs, Color rhs, float t)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1EDC430", Offset = "0x1EDB830", VA = "0x181EDC430")]
	public ColorValueCurve()
	{
	}
}
namespace RecRoom
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct CachedProperty
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct UntilCleared<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private T value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private bool hasValue;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x24FC00", Offset = "0x24F000", VA = "0x18024FC00")]
			public T Get(Func<T> getter)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x24FB40", Offset = "0x24EF40", VA = "0x18024FB40")]
			public void Clear()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct PerFrame<T>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private T value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private bool hasValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int frame;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x24FA70", Offset = "0x24EE70", VA = "0x18024FA70")]
			public T Get(Func<T> getter)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x24FA60", Offset = "0x24EE60", VA = "0x18024FA60")]
			public void Clear()
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private CircularBuffer<T> buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private T current;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			public T Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0x1976A0", Offset = "0x196AA0", VA = "0x1801976A0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CF")]
				[Cpp2IlInjected.Address(RVA = "0x24F8C0", Offset = "0x24ECC0", VA = "0x18024F8C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x24F9D0", Offset = "0x24EDD0", VA = "0x18024F9D0")]
			public Enumerator(CircularBuffer<T> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2C00", Offset = "0x2000", VA = "0x180002C00", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x24F230", Offset = "0x24E630", VA = "0x18024F230", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x24F450", Offset = "0x24E850", VA = "0x18024F450", Slot = "8")]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x24EE40", Offset = "0x24E240", VA = "0x18024EE40")]
			private void CheckVersion()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private T[] entries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private int startIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int endIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int version;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1678CF0", Offset = "0x16780F0", VA = "0x181678CF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1678D90", Offset = "0x1678190", VA = "0x181678D90")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1678FA0", Offset = "0x16783A0", VA = "0x181678FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1678C60", Offset = "0x1678060", VA = "0x181678C60")]
		public CircularBuffer(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1677CC0", Offset = "0x16770C0", VA = "0x181677CC0")]
		public void Add(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x16776B0", Offset = "0x1676AB0", VA = "0x1816776B0")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1677FD0", Offset = "0x16773D0", VA = "0x181677FD0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1678A40", Offset = "0x1677E40", VA = "0x181678A40")]
		public void RemoveFromFront(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x16789B0", Offset = "0x1677DB0", VA = "0x1816789B0")]
		public void RemoveFromEnd(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1678290", Offset = "0x1677690", VA = "0x181678290")]
		public void CopyTo(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x16788F0", Offset = "0x1677CF0", VA = "0x1816788F0")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1678BE0", Offset = "0x1677FE0", VA = "0x181678BE0", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1678BE0", Offset = "0x1677FE0", VA = "0x181678BE0", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1678530", Offset = "0x1677930", VA = "0x181678530")]
		private int ExternalToInternalIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1677FA0", Offset = "0x16773A0", VA = "0x181677FA0")]
		private int ClampIndexToRange(int index)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class ListEvent
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void DynamicInvoke(object[] args);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x2F9C70", Offset = "0x2F9070", VA = "0x1802F9C70")]
		protected ListEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class ListEvent<T> : ListEvent
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		protected struct ModificationData
		{
			[Cpp2IlInjected.Token(Token = "0x200002C")]
			public enum Type
			{
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				ADD,
				[Cpp2IlInjected.Token(Token = "0x4000062")]
				REMOVE,
				[Cpp2IlInjected.Token(Token = "0x4000063")]
				CLEAR
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public T action;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected bool isIterating;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected readonly bool useTryCatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected readonly List<T> actionList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly List<ModificationData> queuedModifications;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HasEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xE47310", Offset = "0xE46710", VA = "0x180E47310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE47220", Offset = "0xE46620", VA = "0x180E47220")]
		public ListEvent(int capacity, bool useTryCatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xE46F30", Offset = "0xE46330", VA = "0x180E46F30")]
		protected void ProcessQueuedModifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xE46CD0", Offset = "0xE460D0", VA = "0x180E46CD0")]
		public void Add(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xE470E0", Offset = "0xE464E0", VA = "0x180E470E0")]
		public void Remove(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xE46E10", Offset = "0xE46210", VA = "0x180E46E10")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class ActionEvent : ListEvent<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC2C0", Offset = "0x1EDB6C0", VA = "0x181EDC2C0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC090", Offset = "0x1EDB490", VA = "0x181EDC090")]
		public void Invoke()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC010", Offset = "0x1EDB410", VA = "0x181EDC010", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC320", Offset = "0x1EDB720", VA = "0x181EDC320")]
		public static ActionEvent operator +(ActionEvent actionEvent, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC380", Offset = "0x1EDB780", VA = "0x181EDC380")]
		public static ActionEvent operator -(ActionEvent actionEvent, Action action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class ActionEvent<T> : ListEvent<Action<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x11F1530", Offset = "0x11F0930", VA = "0x1811F1530")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x16F81D0", Offset = "0x16F75D0", VA = "0x1816F81D0")]
		public void Invoke(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x16F7C50", Offset = "0x16F7050", VA = "0x1816F7C50", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x16F8CA0", Offset = "0x16F80A0", VA = "0x1816F8CA0")]
		public static ActionEvent<T> operator +(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x16F8D40", Offset = "0x16F8140", VA = "0x1816F8D40")]
		public static ActionEvent<T> operator -(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class ActionEvent<T, U> : ListEvent<Action<T, U>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x11F1530", Offset = "0x11F0930", VA = "0x1811F1530")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x16F92D0", Offset = "0x16F86D0", VA = "0x1816F92D0")]
		public void Invoke(T t, U u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x16F8F80", Offset = "0x16F8380", VA = "0x1816F8F80", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x16F8D40", Offset = "0x16F8140", VA = "0x1816F8D40")]
		public static ActionEvent<T, U> operator +(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x16F9B10", Offset = "0x16F8F10", VA = "0x1816F9B10")]
		public static ActionEvent<T, U> operator -(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class ActionEvent<T, U, V> : ListEvent<Action<T, U, V>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x11F1530", Offset = "0x11F0930", VA = "0x1811F1530")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x16F9DC0", Offset = "0x16F91C0", VA = "0x1816F9DC0")]
		public void Invoke(T t, U u, V v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x16F9BB0", Offset = "0x16F8FB0", VA = "0x1816F9BB0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x16F9B10", Offset = "0x16F8F10", VA = "0x1816F9B10")]
		public static ActionEvent<T, U, V> operator +(ActionEvent<T, U, V> actionEvent, Action<T, U, V> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x16FA0A0", Offset = "0x16F94A0", VA = "0x1816FA0A0")]
		public static ActionEvent<T, U, V> operator -(ActionEvent<T, U, V> actionEvent, Action<T, U, V> action)
		{
			return null;
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class IndexedMap<T> : IEnumerable<IndexedMap<T>.Pair>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public struct Pair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public T value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public int index;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public class Enumerator : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private IndexedMap<T> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0xC03F80", Offset = "0xC03380", VA = "0x180C03F80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0xC03FF0", Offset = "0xC033F0", VA = "0x180C03FF0", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x4BE170", Offset = "0x4BD570", VA = "0x1804BE170")]
			public Enumerator(IndexedMap<T> map)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xC03EF0", Offset = "0xC032F0", VA = "0x180C03EF0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x4BE160", Offset = "0x4BD560", VA = "0x1804BE160", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xC03EE0", Offset = "0xC032E0", VA = "0x180C03EE0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private struct ListEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public bool hasValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public T value;
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const int DEFAULT_CAPACITY = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private Dictionary<T, int> valueToIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private ListEntry[] indexToValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int firstEmptyIndex;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xC082C0", Offset = "0xC076C0", VA = "0x180C082C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xC07830", Offset = "0xC06C30", VA = "0x180C07830")]
		public static IndexedMap<T> FromArray(Pair[] pairs, bool expand)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xC08200", Offset = "0xC07600", VA = "0x180C08200")]
		public IndexedMap(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xC076F0", Offset = "0xC06AF0", VA = "0x180C076F0")]
		public bool ContainsValue(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xC07690", Offset = "0xC06A90", VA = "0x180C07690")]
		public bool ContainsIndex(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC07720", Offset = "0xC06B20", VA = "0x180C07720")]
		public bool Contains(Func<T, bool> filter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xC07C00", Offset = "0xC07000", VA = "0x180C07C00")]
		public int GetIndex(T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xC07C50", Offset = "0xC07050", VA = "0x180C07C50")]
		public T GetValue(int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xC07630", Offset = "0xC06A30", VA = "0x180C07630")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xC08010", Offset = "0xC07410", VA = "0x180C08010")]
		public bool TryAdd(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xC08030", Offset = "0xC07430", VA = "0x180C08030")]
		public bool TryAdd(T value, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xC07DD0", Offset = "0xC071D0", VA = "0x180C07DD0")]
		public bool Remove(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xC07CC0", Offset = "0xC070C0", VA = "0x180C07CC0")]
		public bool RemoveAt(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xC07D10", Offset = "0xC07110", VA = "0x180C07D10")]
		private void RemoveInternal(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xC07ED0", Offset = "0xC072D0", VA = "0x180C07ED0")]
		public Pair[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC077D0", Offset = "0xC06BD0", VA = "0x180C077D0")]
		private int FindNextEmptyIndex(int startIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xC07E50", Offset = "0xC07250", VA = "0x180C07E50", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xC07E50", Offset = "0xC07250", VA = "0x180C07E50", Slot = "4")]
		private IEnumerator<Pair> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PriorityMap<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private Dictionary<int, T> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x302310", Offset = "0x301710", VA = "0x180302310", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x304580", Offset = "0x303980", VA = "0x180304580", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xC0DC50", Offset = "0xC0D050", VA = "0x180C0DC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xC0D850", Offset = "0xC0CC50", VA = "0x180C0D850")]
		public bool AddValue(T value, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xC04540", Offset = "0xC03940", VA = "0x180C04540")]
		public bool RemoveValue(int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xC0D8B0", Offset = "0xC0CCB0", VA = "0x180C0D8B0")]
		public T GetPriorityValue(int maxPriority)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xC0DB40", Offset = "0xC0CF40", VA = "0x180C0DB40")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC0DBD0", Offset = "0xC0CFD0", VA = "0x180C0DBD0")]
		public PriorityMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class TokenLockMap<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Dictionary<T, object> itemLockMap;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xC142D0", Offset = "0xC136D0", VA = "0x180C142D0")]
		public bool IsLocked(T itemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xC14300", Offset = "0xC13700", VA = "0x180C14300")]
		public bool IsLocked(T itemId, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xC14340", Offset = "0xC13740", VA = "0x180C14340")]
		public bool IsLocked(T itemId, object token, out object lockingToken)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xC144E0", Offset = "0xC138E0", VA = "0x180C144E0")]
		public bool TryAcquireLock(T itemId, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xC14520", Offset = "0xC13920", VA = "0x180C14520")]
		public bool TryAcquireLock(T itemId, object token, out object lockingToken)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xC142A0", Offset = "0xC136A0", VA = "0x180C142A0")]
		public void ForceAcquireLock(T itemId, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xC14440", Offset = "0xC13840", VA = "0x180C14440")]
		public void ReleaseLock(T itemId, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xC14640", Offset = "0xC13A40", VA = "0x180C14640")]
		public TokenLockMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class WalkableStack<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int nextIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private List<T> elements;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x158D720", Offset = "0x158CB20", VA = "0x18158D720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T Next
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x159C970", Offset = "0x159BD70", VA = "0x18159C970")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T Head
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x159C930", Offset = "0x159BD30", VA = "0x18159C930")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x159C8A0", Offset = "0x159BCA0", VA = "0x18159C8A0")]
		public WalkableStack(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x159C6C0", Offset = "0x159BAC0", VA = "0x18159C6C0")]
		public void Add(T command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x159C800", Offset = "0x159BC00", VA = "0x18159C800")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x159C850", Offset = "0x159BC50", VA = "0x18159C850")]
		public void WalkForward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x159C840", Offset = "0x159BC40", VA = "0x18159C840")]
		public void WalkBack()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class TokenFlagEditor
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x2E50D0", Offset = "0x2E44D0", VA = "0x1802E50D0")]
		public static void RenderEditorGUI(TokenFlag flag, string flagName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ExplicitTokenMap<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private struct PrioritizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int Priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Dictionary<object, PrioritizedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private T _highestPriorityValue;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public virtual T HighestPriorityValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xC07500", Offset = "0xC06900", VA = "0x180C07500", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xC075A0", Offset = "0xC069A0", VA = "0x180C075A0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object HighestPriorityToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x3018D0", Offset = "0x300CD0", VA = "0x1803018D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x3394A0", Offset = "0x3388A0", VA = "0x1803394A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xC074C0", Offset = "0xC068C0", VA = "0x180C074C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x158DAB0", Offset = "0x158CEB0", VA = "0x18158DAB0")]
		public bool AddValue(T value, object token, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xC04540", Offset = "0xC03940", VA = "0x180C04540")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xC046F0", Offset = "0xC03AF0", VA = "0x180C046F0")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xC05580", Offset = "0xC04980", VA = "0x180C05580")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xC07440", Offset = "0xC06840", VA = "0x180C07440")]
		public ExplicitTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MultiplicativeTokenMap
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Dictionary<object, float> dictionary;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public float Product
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5285C0", Offset = "0x5279C0", VA = "0x1805285C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4C0190", Offset = "0x4BF590", VA = "0x1804C0190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC530", Offset = "0x1EDB930", VA = "0x181EDC530")]
		public void AddValue(float value, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC5A0", Offset = "0x1EDB9A0", VA = "0x181EDC5A0")]
		public void RemoveValue(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC600", Offset = "0x1EDBA00", VA = "0x181EDC600")]
		private void UpdateProduct()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC730", Offset = "0x1EDBB30", VA = "0x181EDC730")]
		public MultiplicativeTokenMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TokenFlag
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<object> tokens;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool HasTokens
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x1EDCBF0", Offset = "0x1EDBFF0", VA = "0x181EDCBF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC790", Offset = "0x1EDBB90", VA = "0x181EDC790")]
		public void Add(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC810", Offset = "0x1EDBC10", VA = "0x181EDC810")]
		public void Remove(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1EDC870", Offset = "0x1EDBC70", VA = "0x181EDC870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1EDCB90", Offset = "0x1EDBF90", VA = "0x181EDCB90")]
		public TokenFlag()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class TokenMap<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private struct TimestampedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float Timestamp;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public T Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Dictionary<object, TimestampedData> dictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private T _latestValue;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public virtual T LatestValue
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xC07520", Offset = "0xC06920", VA = "0x180C07520", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xC07610", Offset = "0xC06A10", VA = "0x180C07610", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object LatestToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x2FBA40", Offset = "0x2FAE40", VA = "0x1802FBA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x2FBA50", Offset = "0x2FAE50", VA = "0x1802FBA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x159C530", Offset = "0x159B930", VA = "0x18159C530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x159A4D0", Offset = "0x15998D0", VA = "0x18159A4D0")]
		public bool AddValue(T value, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x159A6D0", Offset = "0x1599AD0", VA = "0x18159A6D0")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x159A6A0", Offset = "0x1599AA0", VA = "0x18159A6A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x159A730", Offset = "0x1599B30", VA = "0x18159A730")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x159ADD0", Offset = "0x159A1D0", VA = "0x18159ADD0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x159C4B0", Offset = "0x159B8B0", VA = "0x18159C4B0")]
		public TokenMap()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
