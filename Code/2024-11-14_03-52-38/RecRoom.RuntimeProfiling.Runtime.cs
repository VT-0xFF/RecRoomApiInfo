using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BMPKGLOKAOD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76BE6E0", Offset = "0x76BDAE0", VA = "0x1876BE6E0")]
	public static ProfilerCategory FGACKFJBECG(string LIGKHCJAKJC)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct NLBEPKHEEPL : IEquatable<NLBEPKHEEPL>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct GCHGPIKJIMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr HNGFOPINOLL;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x76BE790", Offset = "0x76BDB90", VA = "0x1876BE790")]
		internal GCHGPIKJIMO(IntPtr HNGFOPINOLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76BE780", Offset = "0x76BDB80", VA = "0x1876BE780", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort OFGOJLDGKNO = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr HNGFOPINOLL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x76BE7D0", Offset = "0x76BDBD0", VA = "0x1876BE7D0")]
	public NLBEPKHEEPL(ushort CALMPCHMBCD, string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x76BE800", Offset = "0x76BDC00", VA = "0x1876BE800")]
	public NLBEPKHEEPL(string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x76BE7B0", Offset = "0x76BDBB0", VA = "0x1876BE7B0")]
	public GCHGPIKJIMO NMJEDJIOKBB()
	{
		return default(GCHGPIKJIMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76BE7A0", Offset = "0x76BDBA0", VA = "0x1876BE7A0", Slot = "4")]
	public bool Equals(NLBEPKHEEPL OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76BE7A0", Offset = "0x76BDBA0", VA = "0x1876BE7A0", Slot = "5")]
	public bool Equals(ProfilerMarker OGKFFDCECEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FFBPNJCJLKE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3E60", Offset = "0x2BC3260", VA = "0x182BC3E60")]
	public static ProfilerCategory OFLHIHFDGOM(ushort EGCEIFCDGJE)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76BE6F0", Offset = "0x76BDAF0", VA = "0x1876BE6F0")]
	public static ushort ENPNAOFFPAJ(string BNDLKJKBBNP)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OPPFCICCBHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort EAKLPKBNCLN;
}
namespace Cpp2IlInjected;

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
