using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67749F0", Offset = "0x6773BF0", VA = "0x1867749F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DIJJGJPECNO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly EqualityComparer<T> OMAICHIKKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public T LKDHJKNGKHD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x207A210", Offset = "0x2079410", VA = "0x18207A210")]
	public DIJJGJPECNO(in T IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2079820", Offset = "0x2078A20", VA = "0x182079820", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2079DB0", Offset = "0x2078FB0", VA = "0x182079DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2079F20", Offset = "0x2079120", VA = "0x182079F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class CJOECLANBLD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
	public CJOECLANBLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class MLEFICKODBB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
	public MLEFICKODBB(string NMLCGMDKBFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LLAFNBJDIKE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2210010", Offset = "0x220F210", VA = "0x182210010")]
	public static INNCGMMOCAJ JLNGIEOGALB<T>()
	{
		return default(INNCGMMOCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2210270", Offset = "0x220F470", VA = "0x182210270")]
	public static INNCGMMOCAJ OPLGANCENJE<T>([CallerMemberName] string KNOPFGAGMCN = "") where T : notnull
	{
		return default(INNCGMMOCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x220FF80", Offset = "0x220F180", VA = "0x18220FF80")]
	public static INNCGMMOCAJ JLNGIEOGALB<T>(this T GADDGJANIGG) where T : notnull
	{
		return default(INNCGMMOCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x220FE10", Offset = "0x220F010", VA = "0x18220FE10")]
	public static INNCGMMOCAJ IBNLHLCEONO<T>(this T GADDGJANIGG, [CallerMemberName] string KNOPFGAGMCN = "") where T : notnull
	{
		return default(INNCGMMOCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x22101D0", Offset = "0x220F3D0", VA = "0x1822101D0")]
	public static INNCGMMOCAJ OPLGANCENJE<T>(this T DIJPFIMLAFB, [CallerMemberName] string KNOPFGAGMCN = "") where T : notnull
	{
		return default(INNCGMMOCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67746D0", Offset = "0x67738D0", VA = "0x1867746D0")]
	public static INNCGMMOCAJ OPLGANCENJE(string CCIPKALCCAA, [CallerMemberName] string KNOPFGAGMCN = "")
	{
		return default(INNCGMMOCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6774610", Offset = "0x6773810", VA = "0x186774610")]
	public static string OBNADMCIDEB(this object DIJPFIMLAFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KDMGKFMIFPG
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static FNJCGKNAPAG LPKKJAFIFKE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FNJCGKNAPAG GOJNPBPEIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6773F80", Offset = "0x6773180", VA = "0x186773F80")]
		get
		{
			return default(FNJCGKNAPAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static BOFEMCPBMPM EABAKOHABME
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6773F20", Offset = "0x6773120", VA = "0x186773F20")]
		get
		{
			return default(BOFEMCPBMPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static PJIPKONBIAM IDOJMLEPIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67742A0", Offset = "0x67734A0", VA = "0x1867742A0")]
		get
		{
			return default(PJIPKONBIAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6774140", Offset = "0x6773340", VA = "0x186774140")]
	public static void GOCJHMCAHOE(in FNJCGKNAPAG LHOCBBBINCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6773FE0", Offset = "0x67731E0", VA = "0x186773FE0")]
	public static void FPNMONCCAAE(string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6774090", Offset = "0x6773290", VA = "0x186774090")]
	public static void GGALHNMLAOJ(string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x12F4500", Offset = "0x12F3700", VA = "0x1812F4500")]
	public static void GGALHNMLAOJ<T>(T NKBIKBGEKGL, global::AFLFMHGPGDL<T> OFCFPGACNJB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x67744E0", Offset = "0x67736E0", VA = "0x1867744E0")]
	public static void OFMBMMPONGK(Exception AHHCFDOHCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6774460", Offset = "0x6773660", VA = "0x186774460")]
	public static string OBNADMCIDEB(object ICHBECDKHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6774300", Offset = "0x6773500", VA = "0x186774300")]
	public static long HNIHEEGGFMI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6773E40", Offset = "0x6773040", VA = "0x186773E40")]
	public static bool ENDMCNOPBPO(bool NHJPBHJLFOD, string OFCFPGACNJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6774370", Offset = "0x6773570", VA = "0x186774370")]
	public static double IOBNHHKKEMP()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct FNJCGKNAPAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly BOFEMCPBMPM EABAKOHABME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly PJIPKONBIAM IDOJMLEPIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly GNLFDKEEDKI EEKFBKNGGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly JCBDEBPBKKH JLFFIEKBGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly JPMKCPGLBCM LIFCCEEBAEG;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly GNLFDKEEDKI IFCMAAEGHNF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly JCBDEBPBKKH IDHFAHDCPFJ;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly JPMKCPGLBCM OEAFNNFBIKJ;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly FNJCGKNAPAG DPPJPBMGLNA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KGIFMFOFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6772D90", Offset = "0x6771F90", VA = "0x186772D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6773240", Offset = "0x6772440", VA = "0x186773240")]
	public FNJCGKNAPAG(in BOFEMCPBMPM EBBECDHJPBN, in PJIPKONBIAM GEHAFBHKJBF, GNLFDKEEDKI MCDJEBJJFIH, JCBDEBPBKKH PABPENIOBAH, JPMKCPGLBCM ICADNBJBJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6772ED0", Offset = "0x67720D0", VA = "0x186772ED0")]
	private static string NKBCFBGPLHB(object ICHBECDKHOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F8490", Offset = "0x6F7690", VA = "0x1806F8490")]
	private static long OEFEJGNLFPO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	private static string MBBIDDIDOBL(string EIBIHJOIINF, string? KHCNDENCFFO, bool JIFNEJBKJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6772C70", Offset = "0x6771E70", VA = "0x186772C70")]
	private static FNJCGKNAPAG AHCHCMKDLAE()
	{
		return default(FNJCGKNAPAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CJOECLANBLD]
public delegate long JCBDEBPBKKH();
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CPBLIIAKMEL<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CJCBOJFOGEI(in T HNPEBINPOBO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void AJHEJHEIOMC<T>(in T NKBIKBGEKGL);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ECOHOEILLMN
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1D25230", Offset = "0x1D24430", VA = "0x181D25230")]
	public static bool CJCBOJFOGEI<T, U>(in T DIJPFIMLAFB, in U ICHBECDKHOJ) where T : notnull, global::CPBLIIAKMEL<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate TResult DALDCHIBILG<T, out TResult>(in T NKBIKBGEKGL);
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate TResult DJBNGMKFFNO<T1, T2, out TResult>(in T1 FFDKLDFJBMF, in T2 PFEPDCACLHL);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct MPMCCCNBAHH<T> : IEquatable<global::MPMCCCNBAHH<T>>, global::CPBLIIAKMEL<global::MPMCCCNBAHH<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly T LKDHJKNGKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int BCGMDEIHEMI;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x13CA150", Offset = "0x13C9350", VA = "0x1813CA150")]
	public MPMCCCNBAHH(in T IPMIIEAGJKC, int GMEHLIHLGEH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2418DB0", Offset = "0x2417FB0", VA = "0x182418DB0")]
	public static bool IGOCGGBJBII([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F1620", Offset = "0x5F0A20")] in global::MPMCCCNBAHH<T> DNDNMGOKFEI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F1690", Offset = "0x5F0A90")] in global::MPMCCCNBAHH<T> OHMMPNACNJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1B633C0", Offset = "0x1B625C0", VA = "0x181B633C0", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F1700", Offset = "0x5F0B00")] global::MPMCCCNBAHH<T> HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2418240", Offset = "0x2417440", VA = "0x182418240", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x24181B0", Offset = "0x24173B0", VA = "0x1824181B0")]
	public bool CJCBOJFOGEI([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F1760", Offset = "0x5F0B60")] in global::MPMCCCNBAHH<T> HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x24183E0", Offset = "0x24175E0", VA = "0x1824183E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2419AD0", Offset = "0x2418CD0", VA = "0x182419AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x24188D0", Offset = "0x2417AD0", VA = "0x1824188D0")]
	public void HABFEFJGGOE(out T IPMIIEAGJKC, out int GMEHLIHLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x24192F0", Offset = "0x24184F0", VA = "0x1824192F0")]
	public (T, int) OLCCKFJAOCI()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2419620", Offset = "0x2418820", VA = "0x182419620", Slot = "5")]
	private bool PPFDNFKKIPA([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F17D0", Offset = "0x5F0BD0")] in global::MPMCCCNBAHH<T> HNPEBINPOBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JAENCGHNCHG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x12D6500", Offset = "0x12D5700", VA = "0x1812D6500")]
	public static global::MPMCCCNBAHH<T> ELCFDEFNBDD<T>(in T IPMIIEAGJKC, int GMEHLIHLGEH) where T : notnull
	{
		return default(global::MPMCCCNBAHH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct BOFEMCPBMPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly JOGHMPADCGH IKFIHPAMLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly OHJHGFCOEPK NHLHGFMGIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly JOGHMPADCGH ILNCMDFPNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly OHJHGFCOEPK OMFGGKBNGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly JOGHMPADCGH EEHPIOMDAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly OHJHGFCOEPK GAKMJLJCJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly EHFHBGKMFAL PPMDMNHGIAM;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly JOGHMPADCGH EFJKKHLAOLN;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly OHJHGFCOEPK BNJMMPKHPBN;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly JOGHMPADCGH CFFBHIPPAOO;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly OHJHGFCOEPK LGOGJDHEGAH;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly JOGHMPADCGH GJLCDMMMOAD;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly OHJHGFCOEPK PMAEDINOCHL;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly EHFHBGKMFAL GJNLDNDAFPI;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly BOFEMCPBMPM DPPJPBMGLNA;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly JOGHMPADCGH JEOHIOOBBKF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KGIFMFOFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6772390", Offset = "0x6771590", VA = "0x186772390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1780B70", Offset = "0x177FD70", VA = "0x181780B70")]
	public BOFEMCPBMPM(JOGHMPADCGH DBIIHLKENAJ, OHJHGFCOEPK ADCPJNHOHNB, JOGHMPADCGH LDBKPGHDBMO, OHJHGFCOEPK HDDMKKLKIHC, JOGHMPADCGH ACOJKLGGCCA, OHJHGFCOEPK OFDEHIAEHOG, EHFHBGKMFAL DHIECHKHICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0")]
	private static bool OCNBJFDOJFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void JGOKCBNJCND(string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0")]
	private static bool OFIFJEBIOFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void LLKIMKKCNML(string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F83F0", Offset = "0x6F75F0", VA = "0x1806F83F0")]
	private static bool KFJBFGACJBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void ILJKILPJAGF(string OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void OGIGBKAOMOG(Exception AHHCFDOHCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67721D0", Offset = "0x67713D0", VA = "0x1867721D0")]
	private static BOFEMCPBMPM AHCHCMKDLAE()
	{
		return default(BOFEMCPBMPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0")]
	private static bool LJHJJKBDJON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67725D0", Offset = "0x67717D0", VA = "0x1867725D0")]
	public void FPNMONCCAAE(object OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6772640", Offset = "0x6771840", VA = "0x186772640")]
	public void GGALHNMLAOJ(object OFCFPGACNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x67726B0", Offset = "0x67718B0", VA = "0x1867726B0")]
	public void OFMBMMPONGK(Exception AHHCFDOHCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x217C540", Offset = "0x217B740", VA = "0x18217C540")]
	public void GGALHNMLAOJ<T>(T NKBIKBGEKGL, global::AFLFMHGPGDL<T> OFCFPGACNJB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x217C440", Offset = "0x217B640", VA = "0x18217C440")]
	public void FPNMONCCAAE<T>(in T NKBIKBGEKGL, global::NNEJJHCOBPO<T> OFCFPGACNJB) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6772310", Offset = "0x6771510", VA = "0x186772310")]
	public bool ENDMCNOPBPO(bool NHJPBHJLFOD, string OFCFPGACNJB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct INNCGMMOCAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly string LKDHJKNGKHD;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7AF920", Offset = "0x7AEB20", VA = "0x1807AF920")]
	public INNCGMMOCAJ(string IPMIIEAGJKC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0")]
	public static string GJGPFJHFLAE(in INNCGMMOCAJ DIJPFIMLAFB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x9A0840", Offset = "0x99FA40", VA = "0x1809A0840")]
	public static INNCGMMOCAJ GJGPFJHFLAE(string HNPEBINPOBO)
	{
		return default(INNCGMMOCAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67732D0", Offset = "0x67724D0", VA = "0x1867732D0")]
	public string ALCFHFJIMMB(string IBALDFBGBGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6773320", Offset = "0x6772520", VA = "0x186773320")]
	public string PPBMMLABOOG(object EDEOADKJLJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x75A7C0", Offset = "0x7599C0", VA = "0x18075A7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct MFEHAEMCKCJ : IEquatable<MFEHAEMCKCJ>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7004F0", Offset = "0x6FF6F0", VA = "0x1807004F0", Slot = "4")]
	public bool Equals(MFEHAEMCKCJ HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6774750", Offset = "0x6773950", VA = "0x186774750", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67747A0", Offset = "0x67739A0", VA = "0x1867747A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67747B0", Offset = "0x67739B0", VA = "0x1867747B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[KCLFCDFDKOF("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct FHJHGBHFPAM<T> : IEquatable<global::FHJHGBHFPAM<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T LKDHJKNGKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool GDPKDDGEDDB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PPPOJEGICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1B646C0", Offset = "0x1B638C0", VA = "0x181B646C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1B64CD0", Offset = "0x1B63ED0", VA = "0x181B64CD0")]
	public FHJHGBHFPAM(in T IPMIIEAGJKC, bool HKKOBHOFMGI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1B64500", Offset = "0x1B63700", VA = "0x181B64500")]
	public static bool IGOCGGBJBII([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F18F0", Offset = "0x5F0CF0")] in global::FHJHGBHFPAM<T> DNDNMGOKFEI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F1960", Offset = "0x5F0D60")] in global::FHJHGBHFPAM<T> OHMMPNACNJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1B63A50", Offset = "0x1B62C50", VA = "0x181B63A50", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F19D0", Offset = "0x5F0DD0")] global::FHJHGBHFPAM<T> HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1B63AE0", Offset = "0x1B62CE0", VA = "0x181B63AE0", Slot = "0")]
	public override bool Equals(object HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1B63E40", Offset = "0x1B63040", VA = "0x181B63E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1B647A0", Offset = "0x1B639A0", VA = "0x181B647A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DANOBFHPHOO
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x116ACF0", Offset = "0x1169EF0", VA = "0x18116ACF0")]
	public static global::FHJHGBHFPAM<T> HHNNNGBFLNI<T>(in T IPMIIEAGJKC) where T : notnull
	{
		return default(global::FHJHGBHFPAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x116AE10", Offset = "0x116A010", VA = "0x18116AE10")]
	public static global::FHJHGBHFPAM<T?> NDIAOHNHOFN<T>()
	{
		return default(global::FHJHGBHFPAM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x116AC60", Offset = "0x1169E60", VA = "0x18116AC60")]
	public static bool DBFABJHGJKD<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5F1A30", Offset = "0x5F0E30")] this in global::FHJHGBHFPAM<T> LMLHJHOHCLJ, [MGFEIFFEBML(true)] out T IPMIIEAGJKC) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct PJIPKONBIAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly FEHIFILIDFD BFMECEMBIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly MFEGJGPIGCB KODFMDNJPMP;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly FEHIFILIDFD HHCGBLAJDCH;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly MFEGJGPIGCB AHHHFBMLAOI;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly PJIPKONBIAM DPPJPBMGLNA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KGIFMFOFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6775B30", Offset = "0x6774D30", VA = "0x186775B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7AF930", Offset = "0x7AEB30", VA = "0x1807AF930")]
	public PJIPKONBIAM(FEHIFILIDFD OFCGLJGIKIP, MFEGJGPIGCB FHCHILKLFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void CPIBLGBBNOG(string KNOPFGAGMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0")]
	private static void DAGGFDANHCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6775AA0", Offset = "0x6774CA0", VA = "0x186775AA0")]
	private static PJIPKONBIAM AHCHCMKDLAE()
	{
		return default(PJIPKONBIAM);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CEADIGPFDJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct MFMKOCHFNDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Task selfInternal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x67747E0", Offset = "0x67739E0", VA = "0x1867747E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x67749A0", Offset = "0x6773BA0", VA = "0x1867749A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6772B50", Offset = "0x6771D50", VA = "0x186772B50")]
	public static Task<TaskStatus> OIKCIEHJIPC(this Task DIJPFIMLAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1152A60", Offset = "0x1151C60", VA = "0x181152A60")]
	public static Task<T> JCJNHNIDFIA<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1152500", Offset = "0x1151700", VA = "0x181152500")]
	public static Task<TResult> IOJODKECLFM<TResult>(this Task<TResult> BEONMNODOMN, CancellationToken IALNODEHBNN) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6772B50", Offset = "0x6771D50", VA = "0x186772B50")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(MFMKOCHFNDH))]
	internal static Task<TaskStatus> MJMMFDDNDKF(Task GMDAMHJDPPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AttributeUsage(AttributeTargets.Class)]
public class KALJIFHMJGE : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
	public KALJIFHMJGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IOIOAFPIMDE
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static long DBGAIOKGJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6773420", Offset = "0x6772620", VA = "0x186773420")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static long LFBOMFFCOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67737A0", Offset = "0x67729A0", VA = "0x1867737A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static double CKPJEFONDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x67738C0", Offset = "0x6772AC0", VA = "0x1867738C0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static double GDHAPGNHIAD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x67735E0", Offset = "0x67727E0", VA = "0x1867735E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static double IELODDMCJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6773580", Offset = "0x6772780", VA = "0x186773580")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static double MPCHAHCPFPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6773A40", Offset = "0x6772C40", VA = "0x186773A40")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67736F0", Offset = "0x67728F0", VA = "0x1867736F0")]
	public static double IEEJCIEFINC(long PLKBNOEPPLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6773640", Offset = "0x6772840", VA = "0x186773640")]
	public static double HMDDGGOAENH(long PLKBNOEPPLB)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6773920", Offset = "0x6772B20", VA = "0x186773920")]
	public static double MBKCMJDHLNP(double HIJKHPMDNMK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6773810", Offset = "0x6772A10", VA = "0x186773810")]
	public static long JJCBMGCNIIC(long BGGBEMDBOHE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6773800", Offset = "0x6772A00", VA = "0x186773800")]
	public static long JDJLJHOCFJH(long PHIFDEIKIAJ, long JHEMCJDNAGE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6773480", Offset = "0x6772680", VA = "0x186773480")]
	public static double DICONANGNEP(long PHIFDEIKIAJ, long JHEMCJDNAGE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x67739D0", Offset = "0x6772BD0", VA = "0x1867739D0")]
	public static double OKNBAKECOLJ(long PHIFDEIKIAJ, long JHEMCJDNAGE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[AttributeUsage(AttributeTargets.All)]
public class KCLFCDFDKOF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly string HDJKLNIGFHF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7018E0", Offset = "0x700AE0", VA = "0x1807018E0")]
	public KCLFCDFDKOF(string GKHMKKBKEKC)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct OCOFADMOJIN : IEquatable<OCOFADMOJIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public uint DKCKLKHLHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int JMOLMPILHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public float OIKBGDOBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public ushort CLDIFOKBOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public ushort PHNCEDCILOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public short OOBFEGHKOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public short ILGGDJODBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public char DCKGKJIFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public char ELFFDJBJEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public byte KOGLKLDMFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public byte HMAIJHFHEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public byte KNPLCNALEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public byte GFLMADCPKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool EOKINFMMDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public bool KFHJPDPELIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool AHLLELHJBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public bool KMLPIIPDNGL;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7A5E10", Offset = "0x7A5010", VA = "0x1807A5E10")]
	public static OCOFADMOJIN FDCLLKCFLCN(uint PGCCGKDIAHN)
	{
		return default(OCOFADMOJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7A5E10", Offset = "0x7A5010", VA = "0x1807A5E10")]
	public static OCOFADMOJIN GMGFNADEPEP(int FBBGLPBNJCG)
	{
		return default(OCOFADMOJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5B99340", Offset = "0x5B98540", VA = "0x185B99340")]
	public static OCOFADMOJIN HPCCAHHDEJC(float NDKOKJLBCMA)
	{
		return default(OCOFADMOJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6774B00", Offset = "0x6773D00", VA = "0x186774B00")]
	public static OCOFADMOJIN FKHGIEKKPDK(byte NMDEIOLHEIJ, byte GOLCODCJLOF, byte DDMPALJKKDB, byte AJAHJFMPJFG)
	{
		return default(OCOFADMOJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6774B00", Offset = "0x6773D00", VA = "0x186774B00")]
	public static OCOFADMOJIN PMMCELMHFIM(bool KDDKEEPADBJ, bool HIIOIGPOIKM, bool LCLAILIENGD, bool DBLKEDMOBPD)
	{
		return default(OCOFADMOJIN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x865EB0", Offset = "0x8650B0", VA = "0x180865EB0")]
	public static bool IGOCGGBJBII(OCOFADMOJIN BLFKABPCHLN, OCOFADMOJIN NPFMAENOPCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x865E70", Offset = "0x865070", VA = "0x180865E70", Slot = "4")]
	public bool Equals(OCOFADMOJIN HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6774A80", Offset = "0x6773C80", VA = "0x186774A80", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x865E80", Offset = "0x865080", VA = "0x180865E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6774B20", Offset = "0x6773D20", VA = "0x186774B20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct AOOBODAIEHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public ulong EDDOAGPIMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public long EAKLOAIOEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public double OCPDBPCCDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public uint IDACOCGCPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public uint HKHBJPAFDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int NIODLAGPDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public int PJDBJNHCODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public float OKHCFOPLBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public float PNJBMJDLJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public ushort CLDIFOKBOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public ushort PHNCEDCILOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public ushort ALJIPMKEKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public ushort PNDBJIODFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public short OOBFEGHKOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public short ILGGDJODBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public short POJMHNDKLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public short EALHMGHIHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public char DCKGKJIFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public char ELFFDJBJEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public char JADHOJPPDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public char CMJPIEFBKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public byte KOGLKLDMFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public byte HMAIJHFHEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public byte KNPLCNALEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public byte GFLMADCPKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public byte KCICACIDLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public byte BAEEMGLKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte OGBFGHDEAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte GPMFMIPEKGK;

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6772170", Offset = "0x6771370", VA = "0x186772170")]
	public static AOOBODAIEHJ ELCFDEFNBDD(byte NMDEIOLHEIJ, byte GOLCODCJLOF, byte DDMPALJKKDB, byte AJAHJFMPJFG, byte IAIPKIJPNNE, byte PDNBBFDCBCP, byte IHMLMDICBNO, byte JKCPBGIEPJM)
	{
		return default(AOOBODAIEHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class NJOJGHGJPFK
{
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1C7F530", Offset = "0x1C7E730", VA = "0x181C7F530")]
	public static IEnumerable<T> CIIGKNFDPHF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	public static T[] LFDOJAAEJNP<T>(params T[] KGKKBFIEHIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	public static IEnumerable<T> IBJBIPFFCDA<T>(params T[] KGKKBFIEHIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1151550", Offset = "0x1150750", VA = "0x181151550")]
	public static HashSet<T> HAMLEGBKECM<T>(params T[] KGKKBFIEHIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1C7F540", Offset = "0x1C7E740", VA = "0x181C7F540")]
	public static KeyValuePair<TKey, TValue> LLOBAFBEIDN<TKey, TValue>(in TKey FDAIMOMOHIG, in TValue IPMIIEAGJKC) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1151550", Offset = "0x1150750", VA = "0x181151550")]
	public static List<T> AFCDEOALEKA<T>(IEnumerable<T> JNAAHMPCPAB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CJOECLANBLD]
public delegate void FEHIFILIDFD(string KNOPFGAGMCN);
[Cpp2IlInjected.Token(Token = "0x2000024")]
[CJOECLANBLD]
public delegate void MFEGJGPIGCB();
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate object AFLFMHGPGDL<T>(T ADCFFAJGNAM);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate object NNEJJHCOBPO<T>(in T ADCFFAJGNAM);
[Cpp2IlInjected.Token(Token = "0x2000027")]
[CJOECLANBLD]
public delegate string JPMKCPGLBCM(string EIBIHJOIINF, string? KHCNDENCFFO, bool JIFNEJBKJKK);
[Cpp2IlInjected.Token(Token = "0x2000028")]
[CJOECLANBLD]
public delegate void OHJHGFCOEPK(string OFCFPGACNJB);
[Cpp2IlInjected.Token(Token = "0x2000029")]
[CJOECLANBLD]
public delegate void EHFHBGKMFAL(Exception AHHCFDOHCNE);
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate object DDNDPJHCIHN();
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CJOECLANBLD]
public delegate bool JOGHMPADCGH();
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CJOECLANBLD]
public delegate string GNLFDKEEDKI(object ICHBECDKHOJ);
[Cpp2IlInjected.Token(Token = "0x200002D")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class GIPGJDBPIGB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
	public GIPGJDBPIGB(bool KCNLJMPLNCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class MGFEIFFEBML : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x701910", Offset = "0x700B10", VA = "0x180701910")]
	public MGFEIFFEBML(bool KCNLJMPLNCK)
	{
	}
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
