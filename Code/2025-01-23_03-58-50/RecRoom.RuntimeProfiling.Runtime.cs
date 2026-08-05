using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NKCPOLHBIIE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x790CD90", Offset = "0x790B590", VA = "0x18790CD90")]
	public static ProfilerCategory HOJMLKAPOOE(string AIEBMEAPJGA)
	{
		return default(ProfilerCategory);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct BAHDNLOHNON : IEquatable<BAHDNLOHNON>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public readonly struct NOKCGJBLCII : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr OFANAHCDBKA;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x790CDB0", Offset = "0x790B5B0", VA = "0x18790CDB0")]
		internal NOKCGJBLCII(IntPtr OFANAHCDBKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x790CDA0", Offset = "0x790B5A0", VA = "0x18790CDA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal const ushort AHGJIGOLNDK = 1;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal readonly IntPtr OFANAHCDBKA;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x790CD60", Offset = "0x790B560", VA = "0x18790CD60")]
	public BAHDNLOHNON(ushort MAOMAMEOODB, string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x790CD30", Offset = "0x790B530", VA = "0x18790CD30")]
	public BAHDNLOHNON(string IKMKCMDHFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x790CD10", Offset = "0x790B510", VA = "0x18790CD10")]
	public NOKCGJBLCII PAKFMEJBMJB()
	{
		return default(NOKCGJBLCII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x790CD00", Offset = "0x790B500", VA = "0x18790CD00", Slot = "4")]
	public bool Equals(BAHDNLOHNON LIHCAHPMPHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x790CD00", Offset = "0x790B500", VA = "0x18790CD00", Slot = "5")]
	public bool Equals(ProfilerMarker LIHCAHPMPHD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OHANKLOBEBO
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D4E200", Offset = "0x2D4CA00", VA = "0x182D4E200")]
	public static ProfilerCategory JFJPMPECEGB(ushort OPKKOCOLMKH)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x790CDC0", Offset = "0x790B5C0", VA = "0x18790CDC0")]
	public static ushort EHBNFGJIIGO(string LDNPOJKFFDM)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AEJKECAGKAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ushort NDAHAMJEKFA;
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
