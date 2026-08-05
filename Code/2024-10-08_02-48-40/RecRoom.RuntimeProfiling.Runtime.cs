using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NPJHCIFHION
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75C2A80", Offset = "0x75C1C80", VA = "0x1875C2A80")]
	public static ProfilerCategory GDENHDPIOJG(string PHNJNJLLLJG)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct PPLFOIHMFIP : IEquatable<PPLFOIHMFIP>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct KOEFFNNGFLN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr CADGGPLJHKJ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75C2A70", Offset = "0x75C1C70", VA = "0x1875C2A70")]
		internal KOEFFNNGFLN(IntPtr CADGGPLJHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75C2A60", Offset = "0x75C1C60", VA = "0x1875C2A60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort PDPPGFOKILP = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr CADGGPLJHKJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75C2AF0", Offset = "0x75C1CF0", VA = "0x1875C2AF0")]
	public PPLFOIHMFIP(ushort IBPFAJFDJJK, string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75C2AC0", Offset = "0x75C1CC0", VA = "0x1875C2AC0")]
	public PPLFOIHMFIP(string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75C2AA0", Offset = "0x75C1CA0", VA = "0x1875C2AA0")]
	public KOEFFNNGFLN FGDDIMIKPBO()
	{
		return default(KOEFFNNGFLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75C2A90", Offset = "0x75C1C90", VA = "0x1875C2A90", Slot = "4")]
	public bool Equals(PPLFOIHMFIP KDHPJMADEAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75C2A90", Offset = "0x75C1C90", VA = "0x1875C2A90", Slot = "5")]
	public bool Equals(ProfilerMarker KDHPJMADEAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AKFFJKACNHP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2B1D560", Offset = "0x2B1C760", VA = "0x182B1D560")]
	public static ProfilerCategory FIEHABGJBBK(ushort FHHOIODGDCH)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75C29D0", Offset = "0x75C1BD0", VA = "0x1875C29D0")]
	public static ushort KLOPCLHMDOJ(string JLDEJEAFBOC)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct APNGNGFLMJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort NGMDCGFCKDO;
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
