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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class CHMOHLHKAMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate ProfilerRecorderHandle KJGDCJANPLK(ProfilerCategory BMEHNMPPGJP, string OKGDECIFINA);

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static KJGDCJANPLK PDDAOMAJHPI;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x86DFB60", Offset = "0x86DEB60", VA = "0x1886DFB60")]
	static CHMOHLHKAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3637980", Offset = "0x3636980", VA = "0x183637980")]
	public static byte KGLEENCDBGP<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86DFAE0", Offset = "0x86DEAE0", VA = "0x1886DFAE0")]
	public static ProfilerRecorderHandle OJCECBDFMBF(ProfilerCategory EHCCGFJINMJ, string FPOCEOLNCNN)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x86DFAD0", Offset = "0x86DEAD0", VA = "0x1886DFAD0")]
	public static ProfilerCategory BCIHMIILIHG(string EHCCGFJINMJ)
	{
		return default(ProfilerCategory);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct ECIHEKFBODF<T> : IEquatable<ECIHEKFBODF<T>>, IEquatable<ProfilerCounterValue<T>> where T : struct
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly T* BOOIBDACFFN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x44B9CF0", Offset = "0x44B8CF0", VA = "0x1844B9CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x44B9D20", Offset = "0x44B8D20", VA = "0x1844B9D20")]
	public ECIHEKFBODF(ProfilerCategory BMEHNMPPGJP, string NFHOBPDKIPM, ProfilerMarkerDataUnit GOPODFEJGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x213C140", Offset = "0x213B140", VA = "0x18213C140", Slot = "4")]
	public bool Equals(ECIHEKFBODF<T> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x44B9C30", Offset = "0x44B8C30", VA = "0x1844B9C30", Slot = "5")]
	public bool Equals(ProfilerCounterValue<T> MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 8)]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct BEDEOPJHJKF : IEquatable<BEDEOPJHJKF>, IEquatable<ProfilerMarker>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct PLANDBAHPOP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[NativeDisableUnsafePtrRestriction]
		internal readonly IntPtr EPDGBJPODJM;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86DFFC0", Offset = "0x86DEFC0", VA = "0x1886DFFC0")]
		internal PLANDBAHPOP(IntPtr EPDGBJPODJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86DFFB0", Offset = "0x86DEFB0", VA = "0x1886DFFB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr EPDGBJPODJM;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x86DFAA0", Offset = "0x86DEAA0", VA = "0x1886DFAA0")]
	public BEDEOPJHJKF(ushort JIMBNKMDPDE, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x86DFA50", Offset = "0x86DEA50", VA = "0x1886DFA50")]
	public BEDEOPJHJKF(ProfilerCategory BMEHNMPPGJP, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x86DFA30", Offset = "0x86DEA30", VA = "0x1886DFA30")]
	public PLANDBAHPOP HPAGBHHKFMJ()
	{
		return default(PLANDBAHPOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x86DFA20", Offset = "0x86DEA20", VA = "0x1886DFA20", Slot = "4")]
	public bool Equals(BEDEOPJHJKF MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x86DFA20", Offset = "0x86DEA20", VA = "0x1886DFA20", Slot = "5")]
	public bool Equals(ProfilerMarker MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class OEGLCAOEMEA
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39CE4D0", Offset = "0x39CD4D0", VA = "0x1839CE4D0")]
	internal unsafe static bool CLHIOKLJDLN<T>(ProfilerCounterValue<T> LKIMHMMCKPL, [Out] T* LGGPLKNNINE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x34D07F0", Offset = "0x34CF7F0", VA = "0x1834D07F0")]
	public static ProfilerCategory MDMFBBADAOM(ushort MOLINCJBBHJ)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86DFEE0", Offset = "0x86DEEE0", VA = "0x1886DFEE0")]
	public static ushort KMHMHGLDAAB(string NLFGEKLPFCD)
	{
		return default(ushort);
	}
}
[StructLayout((LayoutKind)2, Pack = 1, Size = 2)]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct CKILHLHMENH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ushort MGKDEJBIGMC;
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
