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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PBHFNFOLAEL
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle CPHONFONODO(ProfilerCategory KPHLJGGNDKB, string DNHPOPJCGCC);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static CPHONFONODO LCANEJEKJMF;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x88C9330", Offset = "0x88C7F30", VA = "0x1888C9330")]
	static PBHFNFOLAEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3C7E030", Offset = "0x3C7CC30", VA = "0x183C7E030")]
	public static byte FBAEJILJCJN<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88C92A0", Offset = "0x88C7EA0", VA = "0x1888C92A0")]
	public static ProfilerRecorderHandle CDJGAELPEBM(ProfilerCategory CJOMCMKJHNJ, string DLPBGOHEOHL)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88C9320", Offset = "0x88C7F20", VA = "0x1888C9320")]
	public static ProfilerCategory IIIBAFJALMH(string CJOMCMKJHNJ)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct EDHKDCDAIMN<T> : IEquatable<EDHKDCDAIMN<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* MJFEDHCJNHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x471B630", Offset = "0x471A230", VA = "0x18471B630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x471BA40", Offset = "0x471A640", VA = "0x18471BA40")]
	public EDHKDCDAIMN(ProfilerCategory KPHLJGGNDKB, string LAOCJKNALFF, ProfilerMarkerDataUnit KMPMINBPCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x230FC30", Offset = "0x230E830", VA = "0x18230FC30", Slot = "4")]
	public bool Equals(EDHKDCDAIMN<T> GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x471B570", Offset = "0x471A170", VA = "0x18471B570", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BDDGMJHOKEH : IEquatable<BDDGMJHOKEH>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct DPDMHALLFGD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr CHKIMNOPLPH;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88C9290", Offset = "0x88C7E90", VA = "0x1888C9290")]
		internal DPDMHALLFGD(IntPtr CHKIMNOPLPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88C9280", Offset = "0x88C7E80", VA = "0x1888C9280", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr CHKIMNOPLPH;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x88C9040", Offset = "0x88C7C40", VA = "0x1888C9040")]
	public BDDGMJHOKEH(ushort GKHHBENOKJH, string LAOCJKNALFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x88C9070", Offset = "0x88C7C70", VA = "0x1888C9070")]
	public BDDGMJHOKEH(ProfilerCategory KPHLJGGNDKB, string LAOCJKNALFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x88C9020", Offset = "0x88C7C20", VA = "0x1888C9020")]
	public DPDMHALLFGD NMCGKGLBFBE()
	{
		return default(DPDMHALLFGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x88C9010", Offset = "0x88C7C10", VA = "0x1888C9010", Slot = "4")]
	public bool Equals(BDDGMJHOKEH GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x88C9010", Offset = "0x88C7C10", VA = "0x1888C9010", Slot = "5")]
	public bool Equals(ProfilerMarker GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class DKPKLDMOANJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38EC510", Offset = "0x38EB110", VA = "0x1838EC510")]
	internal unsafe static bool OOJGNOEEHJE<T>(ProfilerCounterValue<T> APCEIKOINPN, [Out] T* HMCFEJCAPLH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3753D00", Offset = "0x3752900", VA = "0x183753D00")]
	public static ProfilerCategory IIHFKAKKHNJ(ushort PGPLACFABGN)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x88C91B0", Offset = "0x88C7DB0", VA = "0x1888C91B0")]
	public static ushort CBIACABEPJJ(string NLKNLGANBDO)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CJCDGOGPMJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort PPAFBKNLPAP;
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
