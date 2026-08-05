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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HJNKOELOPDE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle LJHGDMLBCFM(ProfilerCategory JDEHBEJMLMF, string DPENNPEMPOM);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static LJHGDMLBCFM AEMMELIEHDL;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8744860", Offset = "0x8743A60", VA = "0x188744860")]
	static HJNKOELOPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3A25F10", Offset = "0x3A25110", VA = "0x183A25F10")]
	public static byte LLDOFFNDDDB<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x87447E0", Offset = "0x87439E0", VA = "0x1887447E0")]
	public static ProfilerRecorderHandle KNBMNLMPLHF(ProfilerCategory HLEMOEJMDDH, string ALMIGMHNGNB)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x87447D0", Offset = "0x87439D0", VA = "0x1887447D0")]
	public static ProfilerCategory FJNBEIMPFLO(string HLEMOEJMDDH)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct NEGKCDAGDPM<T> : IEquatable<NEGKCDAGDPM<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* CNGNJMCFMEP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T LFLEGEJLLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x547DC00", Offset = "0x547CE00", VA = "0x18547DC00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x547DD80", Offset = "0x547CF80", VA = "0x18547DD80")]
	public NEGKCDAGDPM(ProfilerCategory JDEHBEJMLMF, string GBOCGPJOEEK, ProfilerMarkerDataUnit GGEFBMMMNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x22758D0", Offset = "0x2274AD0", VA = "0x1822758D0", Slot = "4")]
	public bool Equals(NEGKCDAGDPM<T> CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x547DB50", Offset = "0x547CD50", VA = "0x18547DB50", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> CMOCFNBHPLJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PMAPHKHKBMM : IEquatable<PMAPHKHKBMM>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KNBOBKGBJON : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr EEPPNHNGDBD;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8744AF0", Offset = "0x8743CF0", VA = "0x188744AF0")]
		internal KNBOBKGBJON(IntPtr EEPPNHNGDBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8744AE0", Offset = "0x8743CE0", VA = "0x188744AE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr EEPPNHNGDBD;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8744C20", Offset = "0x8743E20", VA = "0x188744C20")]
	public PMAPHKHKBMM(ushort NHIEMDOFDHK, string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8744C50", Offset = "0x8743E50", VA = "0x188744C50")]
	public PMAPHKHKBMM(ProfilerCategory JDEHBEJMLMF, string GBOCGPJOEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8744C00", Offset = "0x8743E00", VA = "0x188744C00")]
	public KNBOBKGBJON JCLMNFMNLME()
	{
		return default(KNBOBKGBJON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x8744BF0", Offset = "0x8743DF0", VA = "0x188744BF0", Slot = "4")]
	public bool Equals(PMAPHKHKBMM CMOCFNBHPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8744BF0", Offset = "0x8743DF0", VA = "0x188744BF0", Slot = "5")]
	public bool Equals(ProfilerMarker CMOCFNBHPLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class ELPJJJGNCOK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x38993C0", Offset = "0x38985C0", VA = "0x1838993C0")]
	internal unsafe static bool BCJHJHOEJPH<T>(ProfilerCounterValue<T> IFONDMCEGAD, [Out] T* KJMKMHLBAJO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x36AAE60", Offset = "0x36AA060", VA = "0x1836AAE60")]
	public static ProfilerCategory FNFHBBMPOCI(ushort NGLLFFILHNA)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8744700", Offset = "0x8743900", VA = "0x188744700")]
	public static ushort KPMGEIPFAOB(string FOHGMAIHDLM)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KGFJINAOCBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort GANGIEPPCGJ;
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
