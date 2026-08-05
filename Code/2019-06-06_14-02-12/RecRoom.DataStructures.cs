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
		[Cpp2IlInjected.Address(RVA = "0x1B188C0", Offset = "0x1B16EC0", VA = "0x181B188C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1B18810", Offset = "0x1B16E10", VA = "0x181B18810")]
	public TimeSeriesRollingWindow(float sampleInterval, float windowLength)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1B18550", Offset = "0x1B16B50", VA = "0x181B18550")]
	public bool TryToAddSample(float time, T value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1B17D90", Offset = "0x1B16390", VA = "0x181B17D90")]
	public int GetCount(float time)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1B18140", Offset = "0x1B16740", VA = "0x181B18140")]
	public IEnumerable<T> GetSamples(float time, [Optional] float? minTime)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1B17D60", Offset = "0x1B16360", VA = "0x181B17D60")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1B18490", Offset = "0x1B16A90", VA = "0x181B18490")]
	private void RemoveOldSamples(float time)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x17C7900", Offset = "0x17C5F00", VA = "0x1817C7900")]
	public static Tuple<T1> Create<T1>(T1 item1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x18A1080", Offset = "0x189F680", VA = "0x1818A1080")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1A55140", Offset = "0x1A53740", VA = "0x181A55140")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1A554B0", Offset = "0x1A53AB0", VA = "0x181A554B0")]
	public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1A55410", Offset = "0x1A53A10", VA = "0x181A55410")]
	public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1A55360", Offset = "0x1A53960", VA = "0x181A55360")]
	public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1A552A0", Offset = "0x1A538A0", VA = "0x181A552A0")]
	public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1A551D0", Offset = "0x1A537D0", VA = "0x181A551D0")]
	public static Tuple<T1, T2, T3, T4, T5, T6, T7, T8> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11BEC30", Offset = "0x11BD230", VA = "0x1811BEC30")]
	internal static int CombineHashCodes(int h1, int h2)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x13A35A0", Offset = "0x13A1BA0", VA = "0x1813A35A0")]
	internal static int CombineHashCodes(int h1, int h2, int h3)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x13A35B0", Offset = "0x13A1BB0", VA = "0x1813A35B0")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x16E9200", Offset = "0x16E7800", VA = "0x1816E9200")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x16E9250", Offset = "0x16E7850", VA = "0x1816E9250")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x16E9270", Offset = "0x16E7870", VA = "0x1816E9270")]
	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x16E9220", Offset = "0x16E7820", VA = "0x1816E9220")]
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
	[Cpp2IlInjected.Address(RVA = "0xC18240", Offset = "0xC16840", VA = "0x180C18240")]
	public Tuple(T1 item1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A000", Offset = "0x1B18600", VA = "0x181B1A000", Slot = "4")]
	public int CompareTo(Tuple<T1> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A070", Offset = "0x1B18670", VA = "0x181B1A070", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBE04D0", Offset = "0xBDEAD0", VA = "0x180BE04D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A110", Offset = "0x1B18710", VA = "0x181B1A110", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AC60D0", Offset = "0x1AC46D0", VA = "0x181AC60D0")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A330", Offset = "0x1B18930", VA = "0x181B1A330", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A3F0", Offset = "0x1B189F0", VA = "0x181B1A3F0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A750", Offset = "0x1B18D50", VA = "0x181B1A750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1B1A920", Offset = "0x1B18F20", VA = "0x181B1A920", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B1B3A0", Offset = "0x1B199A0", VA = "0x181B1B3A0")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1B1ABC0", Offset = "0x1B191C0", VA = "0x181B1ABC0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1B1AEB0", Offset = "0x1B194B0", VA = "0x181B1AEB0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B020", Offset = "0x1B19620", VA = "0x181B1B020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B210", Offset = "0x1B19810", VA = "0x181B1B210", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1AC8440", Offset = "0x1AC6A40", VA = "0x181AC8440")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B3F0", Offset = "0x1B199F0", VA = "0x181B1B3F0", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B530", Offset = "0x1B19B30", VA = "0x181B1B530", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B650", Offset = "0x1B19C50", VA = "0x181B1B650", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B710", Offset = "0x1B19D10", VA = "0x181B1B710", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B1BD10", Offset = "0x1B1A310", VA = "0x181B1BD10")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B820", Offset = "0x1B19E20", VA = "0x181B1B820", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4, T5> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1B1B9A0", Offset = "0x1B19FA0", VA = "0x181B1B9A0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1B1BAE0", Offset = "0x1B1A0E0", VA = "0x181B1BAE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B1BBE0", Offset = "0x1B1A1E0", VA = "0x181B1BBE0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B1C320", Offset = "0x1B1A920", VA = "0x181B1C320")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B1BD80", Offset = "0x1B1A380", VA = "0x181B1BD80", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4, T5, T6> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1B1BF40", Offset = "0x1B1A540", VA = "0x181B1BF40", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1B1C0B0", Offset = "0x1B1A6B0", VA = "0x181B1C0B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1B1C1D0", Offset = "0x1B1A7D0", VA = "0x181B1C1D0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B1CA00", Offset = "0x1B1B000", VA = "0x181B1CA00")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1B1C390", Offset = "0x1B1A990", VA = "0x181B1C390", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4, T5, T6, T7> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B1C5A0", Offset = "0x1B1ABA0", VA = "0x181B1C5A0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B1C740", Offset = "0x1B1AD40", VA = "0x181B1C740", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1B1C890", Offset = "0x1B1AE90", VA = "0x181B1C890", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B1D190", Offset = "0x1B1B790", VA = "0x181B1D190")]
	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1B1CA80", Offset = "0x1B1B080", VA = "0x181B1CA80", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3, T4, T5, T6, T7, T8> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1B1CCD0", Offset = "0x1B1B2D0", VA = "0x181B1CCD0", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1B1CE90", Offset = "0x1B1B490", VA = "0x181B1CE90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1B1D000", Offset = "0x1B1B600", VA = "0x181B1D000", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x35B270", Offset = "0x359870", VA = "0x18035B270")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3ABF40", Offset = "0x3AA540", VA = "0x1803ABF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float Duration
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x39EB80", Offset = "0x39D180", VA = "0x18039EB80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1EC79B0", Offset = "0x1EC5FB0", VA = "0x181EC79B0")]
	public T Evaluate(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1EC76F0", Offset = "0x1EC5CF0", VA = "0x181EC76F0")]
	public T EvaluateNonNormalized(float t)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T Interpolate(T lhs, T rhs, float t);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xC22F80", Offset = "0xC21580", VA = "0x180C22F80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x16E8A30", Offset = "0x16E7030", VA = "0x1816E8A30", Slot = "4")]
	protected override float Interpolate(float lhs, float rhs, float t)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x16E8AB0", Offset = "0x16E70B0", VA = "0x1816E8AB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16E92A0", Offset = "0x16E78A0", VA = "0x1816E92A0", Slot = "4")]
	protected override Vector3 Interpolate(Vector3 lhs, Vector3 rhs, float t)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x16E9360", Offset = "0x16E7960", VA = "0x1816E9360")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x16E89A0", Offset = "0x16E6FA0", VA = "0x1816E89A0", Slot = "4")]
	protected override Color Interpolate(Color lhs, Color rhs, float t)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x16E89F0", Offset = "0x16E6FF0", VA = "0x1816E89F0")]
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

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x286700", Offset = "0x285B00", VA = "0x180286700")]
			public T Get(Func<T> getter)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x286640", Offset = "0x285A40", VA = "0x180286640")]
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

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x286570", Offset = "0x285970", VA = "0x180286570")]
			public T Get(Func<T> getter)
			{
				return (T)null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x286560", Offset = "0x285960", VA = "0x180286560")]
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
				[Cpp2IlInjected.Token(Token = "0x60000C9")]
				[Cpp2IlInjected.Address(RVA = "0x974E0", Offset = "0x968E0", VA = "0x1800974E0", Slot = "4")]
				get
				{
					return (T)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0x2863C0", Offset = "0x2857C0", VA = "0x1802863C0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x2864D0", Offset = "0x2858D0", VA = "0x1802864D0")]
			public Enumerator(CircularBuffer<T> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7E8A0", Offset = "0x7DCA0", VA = "0x18007E8A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x285D30", Offset = "0x285130", VA = "0x180285D30", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x285F50", Offset = "0x285350", VA = "0x180285F50", Slot = "8")]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x285940", Offset = "0x284D40", VA = "0x180285940")]
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
			[Cpp2IlInjected.Address(RVA = "0x19B3880", Offset = "0x19B1E80", VA = "0x1819B3880")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x19B3920", Offset = "0x19B1F20", VA = "0x1819B3920")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x19B3B30", Offset = "0x19B2130", VA = "0x1819B3B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x19B37F0", Offset = "0x19B1DF0", VA = "0x1819B37F0")]
		public CircularBuffer(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x19B2850", Offset = "0x19B0E50", VA = "0x1819B2850")]
		public void Add(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x19B2240", Offset = "0x19B0840", VA = "0x1819B2240")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x19B2B60", Offset = "0x19B1160", VA = "0x1819B2B60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x19B35D0", Offset = "0x19B1BD0", VA = "0x1819B35D0")]
		public void RemoveFromFront(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x19B3540", Offset = "0x19B1B40", VA = "0x1819B3540")]
		public void RemoveFromEnd(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x19B2E20", Offset = "0x19B1420", VA = "0x1819B2E20")]
		public void CopyTo(T[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x19B3480", Offset = "0x19B1A80", VA = "0x1819B3480")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x19B3770", Offset = "0x19B1D70", VA = "0x1819B3770", Slot = "4")]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x19B3770", Offset = "0x19B1D70", VA = "0x1819B3770", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x19B30C0", Offset = "0x19B16C0", VA = "0x1819B30C0")]
		private int ExternalToInternalIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x19B2B30", Offset = "0x19B1130", VA = "0x1819B2B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x2EF1F0", Offset = "0x2ED7F0", VA = "0x1802EF1F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x17F55C0", Offset = "0x17F3BC0", VA = "0x1817F55C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x17F54D0", Offset = "0x17F3AD0", VA = "0x1817F54D0")]
		public ListEvent(int capacity, bool useTryCatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x17F51E0", Offset = "0x17F37E0", VA = "0x1817F51E0")]
		protected void ProcessQueuedModifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x17F4F80", Offset = "0x17F3580", VA = "0x1817F4F80")]
		public void Add(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x17F5390", Offset = "0x17F3990", VA = "0x1817F5390")]
		public void Remove(T action)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x17F50C0", Offset = "0x17F36C0", VA = "0x1817F50C0")]
		public void Clear()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class ActionEvent : ListEvent<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x16E8880", Offset = "0x16E6E80", VA = "0x1816E8880")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x16E8650", Offset = "0x16E6C50", VA = "0x1816E8650")]
		public void Invoke()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x16E85D0", Offset = "0x16E6BD0", VA = "0x1816E85D0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x16E88E0", Offset = "0x16E6EE0", VA = "0x1816E88E0")]
		public static ActionEvent operator +(ActionEvent actionEvent, Action action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x16E8940", Offset = "0x16E6F40", VA = "0x1816E8940")]
		public static ActionEvent operator -(ActionEvent actionEvent, Action action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class ActionEvent<T> : ListEvent<Action<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xDB2CD0", Offset = "0xDB12D0", VA = "0x180DB2CD0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1A07430", Offset = "0x1A05A30", VA = "0x181A07430")]
		public void Invoke(T t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1A06EB0", Offset = "0x1A054B0", VA = "0x181A06EB0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1A07F00", Offset = "0x1A06500", VA = "0x181A07F00")]
		public static ActionEvent<T> operator +(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A07FA0", Offset = "0x1A065A0", VA = "0x181A07FA0")]
		public static ActionEvent<T> operator -(ActionEvent<T> actionEvent, Action<T> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class ActionEvent<T, U> : ListEvent<Action<T, U>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xDB2CD0", Offset = "0xDB12D0", VA = "0x180DB2CD0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1A08530", Offset = "0x1A06B30", VA = "0x181A08530")]
		public void Invoke(T t, U u)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1A081E0", Offset = "0x1A067E0", VA = "0x181A081E0", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1A07FA0", Offset = "0x1A065A0", VA = "0x181A07FA0")]
		public static ActionEvent<T, U> operator +(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1A08D70", Offset = "0x1A07370", VA = "0x181A08D70")]
		public static ActionEvent<T, U> operator -(ActionEvent<T, U> actionEvent, Action<T, U> action)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class ActionEvent<T, U, V> : ListEvent<Action<T, U, V>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xDB2CD0", Offset = "0xDB12D0", VA = "0x180DB2CD0")]
		public ActionEvent(int capacity = 32, bool useTryCatch = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1A09020", Offset = "0x1A07620", VA = "0x181A09020")]
		public void Invoke(T t, U u, V v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1A08E10", Offset = "0x1A07410", VA = "0x181A08E10", Slot = "4")]
		public override void DynamicInvoke(object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1A08D70", Offset = "0x1A07370", VA = "0x181A08D70")]
		public static ActionEvent<T, U, V> operator +(ActionEvent<T, U, V> actionEvent, Action<T, U, V> action)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1A09300", Offset = "0x1A07900", VA = "0x181A09300")]
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
				[Cpp2IlInjected.Token(Token = "0x60000D0")]
				[Cpp2IlInjected.Address(RVA = "0x1753DE0", Offset = "0x17523E0", VA = "0x181753DE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000D1")]
				[Cpp2IlInjected.Address(RVA = "0x1753E50", Offset = "0x1752450", VA = "0x181753E50", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xF23DB0", Offset = "0xF223B0", VA = "0x180F23DB0")]
			public Enumerator(IndexedMap<T> map)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x1753D50", Offset = "0x1752350", VA = "0x181753D50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xDBE140", Offset = "0xDBC740", VA = "0x180DBE140", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xD3FAB0", Offset = "0xD3E0B0", VA = "0x180D3FAB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x17580B0", Offset = "0x17566B0", VA = "0x1817580B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1757620", Offset = "0x1755C20", VA = "0x181757620")]
		public static IndexedMap<T> FromArray(Pair[] pairs, bool expand)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1757FF0", Offset = "0x17565F0", VA = "0x181757FF0")]
		public IndexedMap(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1489570", Offset = "0x1487B70", VA = "0x181489570")]
		public bool ContainsValue(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x17574B0", Offset = "0x1755AB0", VA = "0x1817574B0")]
		public bool ContainsIndex(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1757510", Offset = "0x1755B10", VA = "0x181757510")]
		public bool Contains(Func<T, bool> filter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x17579F0", Offset = "0x1755FF0", VA = "0x1817579F0")]
		public int GetIndex(T value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1757A40", Offset = "0x1756040", VA = "0x181757A40")]
		public T GetValue(int index)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1757450", Offset = "0x1755A50", VA = "0x181757450")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1757E00", Offset = "0x1756400", VA = "0x181757E00")]
		public bool TryAdd(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1757E20", Offset = "0x1756420", VA = "0x181757E20")]
		public bool TryAdd(T value, int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1757BC0", Offset = "0x17561C0", VA = "0x181757BC0")]
		public bool Remove(T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1757AB0", Offset = "0x17560B0", VA = "0x181757AB0")]
		public bool RemoveAt(int index)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1757B00", Offset = "0x1756100", VA = "0x181757B00")]
		private void RemoveInternal(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1757CC0", Offset = "0x17562C0", VA = "0x181757CC0")]
		public Pair[] ToArray()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x17575C0", Offset = "0x1755BC0", VA = "0x1817575C0")]
		private int FindNextEmptyIndex(int startIndex)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1757C40", Offset = "0x1756240", VA = "0x181757C40", Slot = "5")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1757C40", Offset = "0x1756240", VA = "0x181757C40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x2EF350", Offset = "0x2ED950", VA = "0x1802EF350", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x373C80", Offset = "0x372280", VA = "0x180373C80", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x175DA20", Offset = "0x175C020", VA = "0x18175DA20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x175D620", Offset = "0x175BC20", VA = "0x18175D620")]
		public bool AddValue(T value, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x17543A0", Offset = "0x17529A0", VA = "0x1817543A0")]
		public bool RemoveValue(int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x175D680", Offset = "0x175BC80", VA = "0x18175D680")]
		public T GetPriorityValue(int maxPriority)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x175D910", Offset = "0x175BF10", VA = "0x18175D910")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x175D9A0", Offset = "0x175BFA0", VA = "0x18175D9A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1764070", Offset = "0x1762670", VA = "0x181764070")]
		public bool IsLocked(T itemId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x17640A0", Offset = "0x17626A0", VA = "0x1817640A0")]
		public bool IsLocked(T itemId, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x17640E0", Offset = "0x17626E0", VA = "0x1817640E0")]
		public bool IsLocked(T itemId, object token, out object lockingToken)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1764280", Offset = "0x1762880", VA = "0x181764280")]
		public bool TryAcquireLock(T itemId, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x17641E0", Offset = "0x17627E0", VA = "0x1817641E0")]
		public void ReleaseLock(T itemId, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x17643A0", Offset = "0x17629A0", VA = "0x1817643A0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x19582F0", Offset = "0x19568F0", VA = "0x1819582F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public T Next
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1967540", Offset = "0x1965B40", VA = "0x181967540")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public T Head
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x1967500", Offset = "0x1965B00", VA = "0x181967500")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1967470", Offset = "0x1965A70", VA = "0x181967470")]
		public WalkableStack(int capacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1967290", Offset = "0x1965890", VA = "0x181967290")]
		public void Add(T command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x19673D0", Offset = "0x19659D0", VA = "0x1819673D0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1967420", Offset = "0x1965A20", VA = "0x181967420")]
		public void WalkForward()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1967410", Offset = "0x1965A10", VA = "0x181967410")]
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
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2EF7A0", Offset = "0x2EDDA0", VA = "0x1802EF7A0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1504330", Offset = "0x1502930", VA = "0x181504330", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x17573C0", Offset = "0x17559C0", VA = "0x1817573C0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object HighestPriorityToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x2F0C50", Offset = "0x2EF250", VA = "0x1802F0C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x3A7190", Offset = "0x3A5790", VA = "0x1803A7190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1757320", Offset = "0x1755920", VA = "0x181757320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1958680", Offset = "0x1956C80", VA = "0x181958680")]
		public bool AddValue(T value, object token, int priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x17543A0", Offset = "0x17529A0", VA = "0x1817543A0")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1754550", Offset = "0x1752B50", VA = "0x181754550")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x17553E0", Offset = "0x17539E0", VA = "0x1817553E0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x17572A0", Offset = "0x17558A0", VA = "0x1817572A0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x370DF0", Offset = "0x36F3F0", VA = "0x180370DF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x39F560", Offset = "0x39DB60", VA = "0x18039F560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x16E8AF0", Offset = "0x16E70F0", VA = "0x1816E8AF0")]
		public void AddValue(float value, object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x16E8B60", Offset = "0x16E7160", VA = "0x1816E8B60")]
		public void RemoveValue(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x16E8BC0", Offset = "0x16E71C0", VA = "0x1816E8BC0")]
		private void UpdateProduct()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x16E8CF0", Offset = "0x16E72F0", VA = "0x1816E8CF0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x16E91B0", Offset = "0x16E77B0", VA = "0x1816E91B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x16E8D50", Offset = "0x16E7350", VA = "0x1816E8D50")]
		public void Add(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x16E8DD0", Offset = "0x16E73D0", VA = "0x1816E8DD0")]
		public void Remove(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x16E8E30", Offset = "0x16E7430", VA = "0x1816E8E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x16E9150", Offset = "0x16E7750", VA = "0x1816E9150")]
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
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x155BB20", Offset = "0x155A120", VA = "0x18155BB20", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1757430", Offset = "0x1755A30", VA = "0x181757430", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public object LatestToken
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x35B270", Offset = "0x359870", VA = "0x18035B270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x3ABF40", Offset = "0x3AA540", VA = "0x1803ABF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool ContainsValues
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x1967100", Offset = "0x1965700", VA = "0x181967100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x19650A0", Offset = "0x19636A0", VA = "0x1819650A0")]
		public bool AddValue(T value, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x19652A0", Offset = "0x19638A0", VA = "0x1819652A0")]
		public bool RemoveValue(object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1965270", Offset = "0x1963870", VA = "0x181965270")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1965300", Offset = "0x1963900", VA = "0x181965300")]
		public bool TryGetValue(object token, out T value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x19659A0", Offset = "0x1963FA0", VA = "0x1819659A0")]
		private bool UpdateLatestValue()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1967080", Offset = "0x1965680", VA = "0x181967080")]
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
