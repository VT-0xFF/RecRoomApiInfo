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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PCNBDPAGPPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle NDHPNLMLEPM(ProfilerCategory AKJBFKHJGJP, string LCLAIBGABHI);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static NDHPNLMLEPM HNNOBCAKFMN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x856F9C0", Offset = "0x856EDC0", VA = "0x18856F9C0")]
	static PCNBDPAGPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x38BE460", Offset = "0x38BD860", VA = "0x1838BE460")]
	public static byte AMGAMFNHHEK<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x856F940", Offset = "0x856ED40", VA = "0x18856F940")]
	public static ProfilerRecorderHandle MLMKPKDHBAM(ProfilerCategory KBEBJMKDEMA, string FEOPOHAOPBG)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x856F930", Offset = "0x856ED30", VA = "0x18856F930")]
	public static ProfilerCategory LPEBEKDLNML(string KBEBJMKDEMA)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct IELLNLLEEAO<T> : IEquatable<IELLNLLEEAO<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* KHGGIGEJKJE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T APFNDOMNAPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4A4EEF0", Offset = "0x4A4E2F0", VA = "0x184A4EEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A4F390", Offset = "0x4A4E790", VA = "0x184A4F390")]
	public IELLNLLEEAO(ProfilerCategory AKJBFKHJGJP, string KCCMEIDBNGP, ProfilerMarkerDataUnit BEIJJEEJPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x20D2930", Offset = "0x20D1D30", VA = "0x1820D2930", Slot = "4")]
	public bool Equals(IELLNLLEEAO<T> DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A4EE20", Offset = "0x4A4E220", VA = "0x184A4EE20", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> DMMBOHMLHLF)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ODOPGKFMFPF : IEquatable<ODOPGKFMFPF>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct AFENEDOLCFE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr CNAEODDAPNL;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x856F6B0", Offset = "0x856EAB0", VA = "0x18856F6B0")]
		internal AFENEDOLCFE(IntPtr CNAEODDAPNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x856F6A0", Offset = "0x856EAA0", VA = "0x18856F6A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr CNAEODDAPNL;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x856F8B0", Offset = "0x856ECB0", VA = "0x18856F8B0")]
	public ODOPGKFMFPF(ushort GANEICPOJAD, string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x856F8E0", Offset = "0x856ECE0", VA = "0x18856F8E0")]
	public ODOPGKFMFPF(ProfilerCategory AKJBFKHJGJP, string KCCMEIDBNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x856F890", Offset = "0x856EC90", VA = "0x18856F890")]
	public AFENEDOLCFE HACKLCKGHKL()
	{
		return default(AFENEDOLCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x856F880", Offset = "0x856EC80", VA = "0x18856F880", Slot = "4")]
	public bool Equals(ODOPGKFMFPF DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x856F880", Offset = "0x856EC80", VA = "0x18856F880", Slot = "5")]
	public bool Equals(ProfilerMarker DMMBOHMLHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class KKDGPMMOGGG
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3787260", Offset = "0x3786660", VA = "0x183787260")]
	internal unsafe static bool LJFMOPLLGIH<T>(ProfilerCounterValue<T> AOCLKNEFPLO, [Out] T* HIJODIMIOGM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x33739A0", Offset = "0x3372DA0", VA = "0x1833739A0")]
	public static ProfilerCategory ECICKIGJELH(ushort OHIELJBOJDE)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x856F6C0", Offset = "0x856EAC0", VA = "0x18856F6C0")]
	public static ushort ACGLJHNHJCC(string DDBAIFPOENN)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CCCDCOAFAHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort GCCIPINBCGO;
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
