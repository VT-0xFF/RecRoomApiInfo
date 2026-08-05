using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;
using Unity.Profiling.LowLevel.Unsafe;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DKOHLIJDLGB
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle HDCIFEPBNNB(ProfilerCategory KDIPEHDJNCB, string PFOJOPNBPMK);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static HDCIFEPBNNB NDFDPMMHDCA;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x80404E0", Offset = "0x803F6E0", VA = "0x1880404E0")]
	static DKOHLIJDLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x32D06A0", Offset = "0x32CF8A0", VA = "0x1832D06A0")]
	public static byte BPLBHBIOBNI<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8040460", Offset = "0x803F660", VA = "0x188040460")]
	public static ProfilerRecorderHandle FBHEOFGGJHJ(ProfilerCategory KMEJDKFMHBJ, string DNPDNKPFGMD)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8040450", Offset = "0x803F650", VA = "0x188040450")]
	public static ProfilerCategory CGHOJCAILEC(string KMEJDKFMHBJ)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct JGACPJNDMPH<T> : IEquatable<JGACPJNDMPH<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* ADAJFLICOJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T CADNOMLIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x497A7F0", Offset = "0x49799F0", VA = "0x18497A7F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x497AB00", Offset = "0x4979D00", VA = "0x18497AB00")]
	public JGACPJNDMPH(ProfilerCategory KDIPEHDJNCB, string MBDFMCIDAOB, ProfilerMarkerDataUnit PGCKCPDOCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1F64780", Offset = "0x1F63980", VA = "0x181F64780", Slot = "4")]
	public bool Equals(JGACPJNDMPH<T> LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x497A740", Offset = "0x4979940", VA = "0x18497A740", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CGLNPFGOEKM : IEquatable<CGLNPFGOEKM>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct EDNLADBIIEA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr BNBCPKKLHEA;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8040770", Offset = "0x803F970", VA = "0x188040770")]
		internal EDNLADBIIEA(IntPtr BNBCPKKLHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8040760", Offset = "0x803F960", VA = "0x188040760", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr BNBCPKKLHEA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x80403D0", Offset = "0x803F5D0", VA = "0x1880403D0")]
	public CGLNPFGOEKM(ushort GOFGGHMBPJK, string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8040400", Offset = "0x803F600", VA = "0x188040400")]
	public CGLNPFGOEKM(ProfilerCategory KDIPEHDJNCB, string MBDFMCIDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x80403B0", Offset = "0x803F5B0", VA = "0x1880403B0")]
	public EDNLADBIIEA FOBABGHLNFO()
	{
		return default(EDNLADBIIEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x80403A0", Offset = "0x803F5A0", VA = "0x1880403A0", Slot = "4")]
	public bool Equals(CGLNPFGOEKM LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x80403A0", Offset = "0x803F5A0", VA = "0x1880403A0", Slot = "5")]
	public bool Equals(ProfilerMarker LDKNLBHIGFL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class PJJDGANNHKH
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3674020", Offset = "0x3673220", VA = "0x183674020")]
	internal unsafe static bool DECDKLDNNGE<T>(ProfilerCounterValue<T> DNCGDDLAGBO, [Out] T* DLFACBNDLBJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x312CE70", Offset = "0x312C070", VA = "0x18312CE70")]
	public static ProfilerCategory NPEOOAGFKEF(ushort OMNIGNFPFEN)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8040870", Offset = "0x803FA70", VA = "0x188040870")]
	public static ushort PHHPNFMMDJD(string DDHCMHJHKJJ)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IJLJAGDIDAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort JHEIBCAEGPM;
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
