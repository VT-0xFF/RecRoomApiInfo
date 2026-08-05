using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ACBOBLHBAOO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C58C70", Offset = "0x7C57A70", VA = "0x187C58C70")]
	public static ProfilerCategory NLJPKKDJOFB(string AOIGPNIKDAI)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct OFPGCFNHODP : IEquatable<OFPGCFNHODP>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct NMMGPHKKHIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr NINHOAMLPHJ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C58D20", Offset = "0x7C57B20", VA = "0x187C58D20")]
		internal NMMGPHKKHIP(IntPtr NINHOAMLPHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C58D10", Offset = "0x7C57B10", VA = "0x187C58D10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort EBGCELDFJJE = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr NINHOAMLPHJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C58D60", Offset = "0x7C57B60", VA = "0x187C58D60")]
	public OFPGCFNHODP(ushort KHLNGPGEPMK, string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C58D90", Offset = "0x7C57B90", VA = "0x187C58D90")]
	public OFPGCFNHODP(string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C58D30", Offset = "0x7C57B30", VA = "0x187C58D30")]
	public NMMGPHKKHIP AEELPPGJNNB()
	{
		return default(NMMGPHKKHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C58D50", Offset = "0x7C57B50", VA = "0x187C58D50", Slot = "4")]
	public bool Equals(OFPGCFNHODP LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C58D50", Offset = "0x7C57B50", VA = "0x187C58D50", Slot = "5")]
	public bool Equals(ProfilerMarker LHMPMCLNOPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JPNHPBJINNF
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2FBAAB0", Offset = "0x2FB98B0", VA = "0x182FBAAB0")]
	public static ProfilerCategory OBAHMMOEIII(ushort DEGJDMJMFFH)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C58C80", Offset = "0x7C57A80", VA = "0x187C58C80")]
	public static ushort BDMEJPOLGJB(string HFADCOIECGA)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GAHCHFNAHIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort CAPBONCKNIO;
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
