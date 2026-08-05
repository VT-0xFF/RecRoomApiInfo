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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DFAOBEFMPCH
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle MCBBDBDOHGJ(ProfilerCategory PEBMNBDINBA, string JBIJIAPEHHE);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static MCBBDBDOHGJ CCEAMJFHBJL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8362A00", Offset = "0x8361400", VA = "0x188362A00")]
	static DFAOBEFMPCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x34625F0", Offset = "0x3460FF0", VA = "0x1834625F0")]
	public static byte HKCCDJDPMBO<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8362970", Offset = "0x8361370", VA = "0x188362970")]
	public static ProfilerRecorderHandle GGNJFLBGDLE(ProfilerCategory MKJDOOMAFNK, string CGEEJGGINOC)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x83629F0", Offset = "0x83613F0", VA = "0x1883629F0")]
	public static ProfilerCategory JAPPMBPOLKM(string MKJDOOMAFNK)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct HAPMIJHPKPE<T> : IEquatable<HAPMIJHPKPE<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* EKFAOKAPLPI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x49321D0", Offset = "0x4930BD0", VA = "0x1849321D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x49322B0", Offset = "0x4930CB0", VA = "0x1849322B0")]
	public HAPMIJHPKPE(ProfilerCategory PEBMNBDINBA, string EMLAIMJKHOE, ProfilerMarkerDataUnit MPABDCNLJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2068850", Offset = "0x2067250", VA = "0x182068850", Slot = "4")]
	public bool Equals(HAPMIJHPKPE<T> OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4932210", Offset = "0x4930C10", VA = "0x184932210", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct NMFJFPDKNGC : IEquatable<NMFJFPDKNGC>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct IKLJLJOIDEM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr LNEENCBNNLK;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8362C90", Offset = "0x8361690", VA = "0x188362C90")]
		internal IKLJLJOIDEM(IntPtr LNEENCBNNLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8362C80", Offset = "0x8361680", VA = "0x188362C80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr LNEENCBNNLK;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8362E10", Offset = "0x8361810", VA = "0x188362E10")]
	public NMFJFPDKNGC(ushort IGACOHJKPJK, string EMLAIMJKHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8362DC0", Offset = "0x83617C0", VA = "0x188362DC0")]
	public NMFJFPDKNGC(ProfilerCategory PEBMNBDINBA, string EMLAIMJKHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8362DA0", Offset = "0x83617A0", VA = "0x188362DA0")]
	public IKLJLJOIDEM OPAAHPFHDFH()
	{
		return default(IKLJLJOIDEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8362D90", Offset = "0x8361790", VA = "0x188362D90", Slot = "4")]
	public bool Equals(NMFJFPDKNGC OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8362D90", Offset = "0x8361790", VA = "0x188362D90", Slot = "5")]
	public bool Equals(ProfilerMarker OLKLGHOAKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class APCEEJFNNMB
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3DB80B0", Offset = "0x3DB6AB0", VA = "0x183DB80B0")]
	internal unsafe static bool CBKOCGAKFJD<T>(ProfilerCounterValue<T> KEHICOEGIOE, [Out] T* GBCKNPAIAPN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x32E5F10", Offset = "0x32E4910", VA = "0x1832E5F10")]
	public static ProfilerCategory KODLCBLPOCK(ushort PIDKIJCKDNC)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x83628A0", Offset = "0x83612A0", VA = "0x1883628A0")]
	public static ushort DBFPJPKCMEN(string HKOEKJEAKFM)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GMLGOAPCCPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort JCGBDGDJMHP;
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
