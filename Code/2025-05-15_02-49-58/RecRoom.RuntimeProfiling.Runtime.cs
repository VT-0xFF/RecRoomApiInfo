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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x86C6DF0", Offset = "0x86C53F0", VA = "0x1886C6DF0")]
	static CHMOHLHKAMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3654700", Offset = "0x3652D00", VA = "0x183654700")]
	public static byte KGLEENCDBGP<T>()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86C6D70", Offset = "0x86C5370", VA = "0x1886C6D70")]
	public static ProfilerRecorderHandle OJCECBDFMBF(ProfilerCategory EHCCGFJINMJ, string FPOCEOLNCNN)
	{
		return default(ProfilerRecorderHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x86C6D60", Offset = "0x86C5360", VA = "0x1886C6D60")]
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
		[Cpp2IlInjected.Address(RVA = "0x44F7B70", Offset = "0x44F6170", VA = "0x1844F7B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x44F7BA0", Offset = "0x44F61A0", VA = "0x1844F7BA0")]
	public ECIHEKFBODF(ProfilerCategory BMEHNMPPGJP, string NFHOBPDKIPM, ProfilerMarkerDataUnit GOPODFEJGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2153BC0", Offset = "0x21521C0", VA = "0x182153BC0", Slot = "4")]
	public bool Equals(ECIHEKFBODF<T> MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x44F7AC0", Offset = "0x44F60C0", VA = "0x1844F7AC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C7240", Offset = "0x86C5840", VA = "0x1886C7240")]
		internal PLANDBAHPOP(IntPtr EPDGBJPODJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86C7230", Offset = "0x86C5830", VA = "0x1886C7230", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly IntPtr EPDGBJPODJM;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x86C6D30", Offset = "0x86C5330", VA = "0x1886C6D30")]
	public BEDEOPJHJKF(ushort JIMBNKMDPDE, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x86C6CE0", Offset = "0x86C52E0", VA = "0x1886C6CE0")]
	public BEDEOPJHJKF(ProfilerCategory BMEHNMPPGJP, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x86C6CC0", Offset = "0x86C52C0", VA = "0x1886C6CC0")]
	public PLANDBAHPOP HPAGBHHKFMJ()
	{
		return default(PLANDBAHPOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x86C6CB0", Offset = "0x86C52B0", VA = "0x1886C6CB0", Slot = "4")]
	public bool Equals(BEDEOPJHJKF MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x86C6CB0", Offset = "0x86C52B0", VA = "0x1886C6CB0", Slot = "5")]
	public bool Equals(ProfilerMarker MIJLJBIHDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class OEGLCAOEMEA
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x39EAD60", Offset = "0x39E9360", VA = "0x1839EAD60")]
	internal unsafe static bool CLHIOKLJDLN<T>(ProfilerCounterValue<T> LKIMHMMCKPL, [Out] T* LGGPLKNNINE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x34EC7D0", Offset = "0x34EADD0", VA = "0x1834EC7D0")]
	public static ProfilerCategory MDMFBBADAOM(ushort MOLINCJBBHJ)
	{
		return default(ProfilerCategory);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86C7160", Offset = "0x86C5760", VA = "0x1886C7160")]
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
