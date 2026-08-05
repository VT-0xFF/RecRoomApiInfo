using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PKHJENNBCPB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75CDCB0", Offset = "0x75CC8B0", VA = "0x1875CDCB0")]
	public static ProfilerCategory PEBCMAGOFCO(string MHHDDEOKFBI)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct PGKCFHHEBHO : IEquatable<PGKCFHHEBHO>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct PCFNFLJFGFN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr IIOIBMDNPHH;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x75CDC10", Offset = "0x75CC810", VA = "0x1875CDC10")]
		internal PCFNFLJFGFN(IntPtr IIOIBMDNPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x75CDC00", Offset = "0x75CC800", VA = "0x1875CDC00", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort EBBHINKPCJN = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr IIOIBMDNPHH;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75CDC50", Offset = "0x75CC850", VA = "0x1875CDC50")]
	public PGKCFHHEBHO(ushort EMBPBLMHPCJ, string GMBAACDNNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75CDC80", Offset = "0x75CC880", VA = "0x1875CDC80")]
	public PGKCFHHEBHO(string GMBAACDNNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75CDC30", Offset = "0x75CC830", VA = "0x1875CDC30")]
	public PCFNFLJFGFN HHAOHOBPBIO()
	{
		return default(PCFNFLJFGFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75CDC20", Offset = "0x75CC820", VA = "0x1875CDC20", Slot = "4")]
	public bool Equals(PGKCFHHEBHO FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75CDC20", Offset = "0x75CC820", VA = "0x1875CDC20", Slot = "5")]
	public bool Equals(ProfilerMarker FDOEIPBMJJM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BIDHKFBADHB
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2AFAA60", Offset = "0x2AF9660", VA = "0x182AFAA60")]
	public static ProfilerCategory BNNIEEGJFJC(ushort HKKBLMLEHID)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75CDB70", Offset = "0x75CC770", VA = "0x1875CDB70")]
	public static ushort GPFAGIPFDOD(string JPNAAJLJECJ)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AGMOALLFJKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort OFFKOBNIEHI;
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
