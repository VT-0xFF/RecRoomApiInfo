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
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A9D3C0", Offset = "0x6A9BDC0", VA = "0x186A9D3C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
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
		[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DBBHBFKJAKC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly EqualityComparer<T> EDHBBLAFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public T ONBMIOJBCHK;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x435FC30", Offset = "0x435E630", VA = "0x18435FC30")]
	public DBBHBFKJAKC(in T MFBGAMJDOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x435F680", Offset = "0x435E080", VA = "0x18435F680", Slot = "0")]
	public override bool Equals(object OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x435F8E0", Offset = "0x435E2E0", VA = "0x18435F8E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x435FA80", Offset = "0x435E480", VA = "0x18435FA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate)]
public class NHKABPFKCJN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
	public NHKABPFKCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
public class GJMCDPCEPFO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
	public GJMCDPCEPFO(string LALLDPHPJJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PJBOBICLPNJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x394CC90", Offset = "0x394B690", VA = "0x18394CC90")]
	public static OHOBHEJOLPF HHGGEBIBPHC<T>()
	{
		return default(OHOBHEJOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x394CF40", Offset = "0x394B940", VA = "0x18394CF40")]
	public static OHOBHEJOLPF NEBBODCGEOO<T>([CallerMemberName] string KMEGKECOLPJ = "") where T : notnull
	{
		return default(OHOBHEJOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x394CC00", Offset = "0x394B600", VA = "0x18394CC00")]
	public static OHOBHEJOLPF HHGGEBIBPHC<T>(this T NHAGEBCMLPC) where T : notnull
	{
		return default(OHOBHEJOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x394CD20", Offset = "0x394B720", VA = "0x18394CD20")]
	public static OHOBHEJOLPF LGAPAACNAGB<T>(this T NHAGEBCMLPC, [CallerMemberName] string KMEGKECOLPJ = "") where T : notnull
	{
		return default(OHOBHEJOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x394CEA0", Offset = "0x394B8A0", VA = "0x18394CEA0")]
	public static OHOBHEJOLPF NEBBODCGEOO<T>(this T IKHBPJOEIEB, [CallerMemberName] string KMEGKECOLPJ = "") where T : notnull
	{
		return default(OHOBHEJOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DFE0", Offset = "0x6A9C9E0", VA = "0x186A9DFE0")]
	public static OHOBHEJOLPF NEBBODCGEOO(string IONEBCEKGBF, [CallerMemberName] string KMEGKECOLPJ = "")
	{
		return default(OHOBHEJOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DF20", Offset = "0x6A9C920", VA = "0x186A9DF20")]
	public static string DBJIKJDOMCK(this object IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NHKABPFKCJN]
public delegate long FOLGFMMCMAM();
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class GOFMPCNKAAL
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static POHKMEOJGAC MCNFDKFMEOD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static POHKMEOJGAC DHMADLHHKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C1F0", Offset = "0x6A9ABF0", VA = "0x186A9C1F0")]
		get
		{
			return default(POHKMEOJGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static ONADMHJLKCP IDMOKPBCAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C300", Offset = "0x6A9AD00", VA = "0x186A9C300")]
		get
		{
			return default(ONADMHJLKCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static KCOGADDKGEK IMLIEIMJJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C060", Offset = "0x6A9AA60", VA = "0x186A9C060")]
		get
		{
			return default(KCOGADDKGEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C360", Offset = "0x6A9AD60", VA = "0x186A9C360")]
	public static void LEIPNONHIKG(in POHKMEOJGAC LLLKLDEPHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C250", Offset = "0x6A9AC50", VA = "0x186A9C250")]
	public static void KIMAHGDPAHN(string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C0C0", Offset = "0x6A9AAC0", VA = "0x186A9C0C0")]
	public static void HNGFIMPFPEH(string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x30DAE90", Offset = "0x30D9890", VA = "0x1830DAE90")]
	public static void HNGFIMPFPEH<T>(T NMPNMHNJPAA, global::LLHCBCFHKJO<T> MDEEJIBNIAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C170", Offset = "0x6A9AB70", VA = "0x186A9C170")]
	public static void ILGEHOKOJKB(Exception HELJFFINGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BEF0", Offset = "0x6A9A8F0", VA = "0x186A9BEF0")]
	public static string DBJIKJDOMCK(object OMHIFHKMIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BE80", Offset = "0x6A9A880", VA = "0x186A9BE80")]
	public static long BKJCKPEDHCJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BDA0", Offset = "0x6A9A7A0", VA = "0x186A9BDA0")]
	public static bool ABFFCDKLDFJ(bool NEMBILNJMDF, string MDEEJIBNIAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A9BF70", Offset = "0x6A9A970", VA = "0x186A9BF70")]
	public static double EIPDOPJGGBO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public readonly struct POHKMEOJGAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly ONADMHJLKCP IDMOKPBCAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KCOGADDKGEK IMLIEIMJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly FFGNLDLIMFC EOIALLKKHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly FOLGFMMCMAM IADHKLPBMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly MMLODJBCFBA DMPJPFPOPNO;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly FFGNLDLIMFC DAPAHHIAAAP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly FOLGFMMCMAM FELIOPCHFEL;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly MMLODJBCFBA DNKAPPDOPFH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly POHKMEOJGAC INOBADPFMME;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MPMONFPIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6A9E060", Offset = "0x6A9CA60", VA = "0x186A9E060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E630", Offset = "0x6A9D030", VA = "0x186A9E630")]
	public POHKMEOJGAC(in ONADMHJLKCP DBBHBIBKMKE, in KCOGADDKGEK AIGNMBPGNOL, FFGNLDLIMFC JNBMEBDHDAL, FOLGFMMCMAM IEDLMHJBOPB, MMLODJBCFBA KFAJEEHIAOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E2C0", Offset = "0x6A9CCC0", VA = "0x186A9E2C0")]
	private static string MDDKKJMKMPM(object OMHIFHKMIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0")]
	private static long DJJKGLLKDGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0")]
	private static string KAGABPGBHCI(string ANIDBJJMJNL, string? IJIPLLNGNDB, bool CIPGEMPKIOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A9E1A0", Offset = "0x6A9CBA0", VA = "0x186A9E1A0")]
	private static POHKMEOJGAC KAPNLMPAIAM()
	{
		return default(POHKMEOJGAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NEEDEFGOBIK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ACLNEIIIAFO(in T EHBPAFKHADK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void CLDFGDLLMFJ<T>(in T NMPNMHNJPAA);
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class EPKFOLGJGBO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3224810", Offset = "0x3223210", VA = "0x183224810")]
	public static bool ACLNEIIIAFO<T, U>(in T IKHBPJOEIEB, in U OMHIFHKMIMJ) where T : notnull, global::NEEDEFGOBIK<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public delegate TResult LDODKIGAHAJ<T, out TResult>(in T NMPNMHNJPAA);
[Cpp2IlInjected.Token(Token = "0x2000010")]
public delegate TResult JHNJCHBAKHO<T1, T2, out TResult>(in T1 AAMHGJKKOHN, in T2 BLOPLJAABAI);
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct FOLNIBIFEAJ<T> : IEquatable<global::FOLNIBIFEAJ<T>>, global::NEEDEFGOBIK<global::FOLNIBIFEAJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly T ONBMIOJBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int EOGKCECFNOA;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1C53D40", Offset = "0x1C52740", VA = "0x181C53D40")]
	public FOLNIBIFEAJ(in T MFBGAMJDOKA, int ALJOMNDNEBM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x465EAA0", Offset = "0x465D4A0", VA = "0x18465EAA0")]
	public static bool ENMIHMCKBEN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC030", Offset = "0x6FB430")] in global::FOLNIBIFEAJ<T> BBDDOKEDLCI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC0A0", Offset = "0x6FB4A0")] in global::FOLNIBIFEAJ<T> NAHMKAGEEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B99770", Offset = "0x3B98170", VA = "0x183B99770", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC110", Offset = "0x6FB510")] global::FOLNIBIFEAJ<T> EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x465F010", Offset = "0x465DA10", VA = "0x18465F010", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x465E650", Offset = "0x465D050", VA = "0x18465E650")]
	public bool ACLNEIIIAFO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC170", Offset = "0x6FB570")] in global::FOLNIBIFEAJ<T> EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x465F3C0", Offset = "0x465DDC0", VA = "0x18465F3C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x465FC40", Offset = "0x465E640", VA = "0x18465FC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x465F950", Offset = "0x465E350", VA = "0x18465F950")]
	public void NIELGFEEDGF(out T MFBGAMJDOKA, out int ALJOMNDNEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x465E6E0", Offset = "0x465D0E0", VA = "0x18465E6E0")]
	public (T, int) AEMCLGEAGNA()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x465F480", Offset = "0x465DE80", VA = "0x18465F480", Slot = "5")]
	private bool LNAOBAMJAIH([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC1E0", Offset = "0x6FB5E0")] in global::FOLNIBIFEAJ<T> EHBPAFKHADK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CIAPKIEBMKH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3453BD0", Offset = "0x34525D0", VA = "0x183453BD0")]
	public static global::FOLNIBIFEAJ<T> IDLIIDOEAFG<T>(in T MFBGAMJDOKA, int ALJOMNDNEBM) where T : notnull
	{
		return default(global::FOLNIBIFEAJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public readonly struct ONADMHJLKCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly HJKKJLDADJM PABNBMABICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly KPIJGCFNCBN FJKKGGGKBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly HJKKJLDADJM AKLGJHPMFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly KPIJGCFNCBN DPBPMELIFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly HJKKJLDADJM AAMBFHKDDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly KPIJGCFNCBN HPGPPLGOHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly CDNHPPFNBKA JOCKODEAHLA;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static readonly HJKKJLDADJM IFHMKEELPIF;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly KPIJGCFNCBN MIBAFKJIFGJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public static readonly HJKKJLDADJM INCPLOJJIKK;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly KPIJGCFNCBN BKCNAAIJNMC;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public static readonly HJKKJLDADJM DMPGBDCLNIN;

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly KPIJGCFNCBN AHBCEABDBPF;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly CDNHPPFNBKA CMDECLAKKJG;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly ONADMHJLKCP INOBADPFMME;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly HJKKJLDADJM BIIHGHBCKKA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MPMONFPIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A9D620", Offset = "0x6A9C020", VA = "0x186A9D620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x21AB280", Offset = "0x21A9C80", VA = "0x1821AB280")]
	public ONADMHJLKCP(HJKKJLDADJM BJJDJCEIFNG, KPIJGCFNCBN ABIHKCAEOGB, HJKKJLDADJM CGCAKANDIPG, KPIJGCFNCBN KJDGPDPGJHP, HJKKJLDADJM HPHFFGBBJOO, KPIJGCFNCBN FEPKKHNIKBN, CDNHPPFNBKA IMDOBHIMHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0")]
	private static bool EHGADNOLPGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void CMPDHCMBBMN(string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0")]
	private static bool JPIAHFPHMKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void BNABMELHMFN(string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0")]
	private static bool KKJFNANHGIJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void HMCBPAFCGNA(string MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void BHDLKIDJMCK(Exception HELJFFINGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D8F0", Offset = "0x6A9C2F0", VA = "0x186A9D8F0")]
	private static ONADMHJLKCP KAPNLMPAIAM()
	{
		return default(ONADMHJLKCP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80")]
	private static bool DCJPFNCCMKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9DA30", Offset = "0x6A9C430", VA = "0x186A9DA30")]
	public void KIMAHGDPAHN(object MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D860", Offset = "0x6A9C260", VA = "0x186A9D860")]
	public void HNGFIMPFPEH(object MDEEJIBNIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D8D0", Offset = "0x6A9C2D0", VA = "0x186A9D8D0")]
	public void ILGEHOKOJKB(Exception HELJFFINGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3687030", Offset = "0x3685A30", VA = "0x183687030")]
	public void HNGFIMPFPEH<T>(T NMPNMHNJPAA, global::LLHCBCFHKJO<T> MDEEJIBNIAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x36870B0", Offset = "0x3685AB0", VA = "0x1836870B0")]
	public void KIMAHGDPAHN<T>(in T NMPNMHNJPAA, global::FOLHNAHGELK<T> MDEEJIBNIAD) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D5A0", Offset = "0x6A9BFA0", VA = "0x186A9D5A0")]
	public bool ABFFCDKLDFJ(bool NEMBILNJMDF, string MDEEJIBNIAD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public readonly struct OHOBHEJOLPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly string ONBMIOJBCHK;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x875C70", Offset = "0x874670", VA = "0x180875C70")]
	public OHOBHEJOLPF(string MFBGAMJDOKA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x875BB0", Offset = "0x8745B0", VA = "0x180875BB0")]
	public static string EHMKDPHHPBI(in OHOBHEJOLPF IKHBPJOEIEB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8BD3E0", Offset = "0x8BBDE0", VA = "0x1808BD3E0")]
	public static OHOBHEJOLPF EHMKDPHHPBI(string EHBPAFKHADK)
	{
		return default(OHOBHEJOLPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D550", Offset = "0x6A9BF50", VA = "0x186A9D550")]
	public string NOJFIHDPHMG(string LLLCELNKBJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D450", Offset = "0x6A9BE50", VA = "0x186A9D450")]
	public string NBGPGJHNAJD(object KOEBIOOCLIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x875BB0", Offset = "0x8745B0", VA = "0x180875BB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct LEKKGHCNCEK : IEquatable<LEKKGHCNCEK>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE80", Offset = "0x7FC880", VA = "0x1807FDE80", Slot = "4")]
	public bool Equals(LEKKGHCNCEK EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C910", Offset = "0x6A9B310", VA = "0x186A9C910", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C960", Offset = "0x6A9B360", VA = "0x186A9C960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C970", Offset = "0x6A9B370", VA = "0x186A9C970", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FGCFFGCIPKG("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct DOMIPLFCMFE<T> : IEquatable<global::DOMIPLFCMFE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T ONBMIOJBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly bool KPBGOMHKFPJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BNNMCEDPEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3B99060", Offset = "0x3B97A60", VA = "0x183B99060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3B9AA80", Offset = "0x3B99480", VA = "0x183B9AA80")]
	public DOMIPLFCMFE(in T MFBGAMJDOKA, bool EHLNJADOFMP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3B99460", Offset = "0x3B97E60", VA = "0x183B99460")]
	public static bool ENMIHMCKBEN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC300", Offset = "0x6FB700")] in global::DOMIPLFCMFE<T> BBDDOKEDLCI, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC370", Offset = "0x6FB770")] in global::DOMIPLFCMFE<T> NAHMKAGEEEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A070", Offset = "0x3B98A70", VA = "0x183B9A070", Slot = "4")]
	public bool Equals([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC3E0", Offset = "0x6FB7E0")] global::DOMIPLFCMFE<T> EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3B99AF0", Offset = "0x3B984F0", VA = "0x183B99AF0", Slot = "0")]
	public override bool Equals(object EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A150", Offset = "0x3B98B50", VA = "0x183B9A150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3B9A530", Offset = "0x3B98F30", VA = "0x183B9A530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OHODKEHBBNM
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3685F10", Offset = "0x3684910", VA = "0x183685F10")]
	public static global::DOMIPLFCMFE<T> BLONLAAAIOA<T>(in T MFBGAMJDOKA) where T : notnull
	{
		return default(global::DOMIPLFCMFE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3686040", Offset = "0x3684A40", VA = "0x183686040")]
	public static global::DOMIPLFCMFE<T?> DPJOCLONKLN<T>()
	{
		return default(global::DOMIPLFCMFE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x36860F0", Offset = "0x3684AF0", VA = "0x1836860F0")]
	public static bool KGMOEBNPNOJ<T>([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6FC480", Offset = "0x6FB880")] this in global::DOMIPLFCMFE<T> BKGCICDOKFA, [OFMILDPNIPJ(true)] out T MFBGAMJDOKA) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct KCOGADDKGEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly LEGINELIAAI IGNJDKBIPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly FLCPFEPLPEM APFGKBPGOPJ;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly LEGINELIAAI AHKIPGFPKPH;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly FLCPFEPLPEM OGLMFFMAMEM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KCOGADDKGEK INOBADPFMME;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MPMONFPIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C620", Offset = "0x6A9B020", VA = "0x186A9C620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xC33810", Offset = "0xC32210", VA = "0x180C33810")]
	public KCOGADDKGEK(LEGINELIAAI IMGPDABDBJP, FLCPFEPLPEM IBDPLIPLCNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void KGDFPKFOBEE(string KMEGKECOLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60")]
	private static void NPAKJDMAJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A9C6F0", Offset = "0x6A9B0F0", VA = "0x186A9C6F0")]
	private static KCOGADDKGEK KAPNLMPAIAM()
	{
		return default(KCOGADDKGEK);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ACKDAJLEPGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private struct EIAFMBDHELI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6A9BB90", Offset = "0x6A9A590", VA = "0x186A9BB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A9BD50", Offset = "0x6A9A750", VA = "0x186A9BD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A910", Offset = "0x6A99310", VA = "0x186A9A910")]
	public static Task<TaskStatus> DLOGCCFNKKC(this Task IKHBPJOEIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x254C040", Offset = "0x254AA40", VA = "0x18254C040")]
	public static Task<T> OGGNPDPHBIL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x254BAE0", Offset = "0x254A4E0", VA = "0x18254BAE0")]
	public static Task<TResult> JAKENFKEHAI<TResult>(this Task<TResult> CLOLJDGJLBF, CancellationToken HMAOAMDKNDD) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A910", Offset = "0x6A99310", VA = "0x186A9A910")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(EIAFMBDHELI))]
	internal static Task<TaskStatus> MJLDOKFPBJG(Task CNICCPLOEME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[AttributeUsage(AttributeTargets.Class)]
public class OIOHPIGADGP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x805E70", Offset = "0x804870", VA = "0x180805E70")]
	public OIOHPIGADGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IONJALDOMGG : GCJHKDPHCIF
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly GCJHKDPHCIF FINLHCLDLDF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DateTime EGDAFOCKENB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6A9C570", Offset = "0x6A9AF70", VA = "0x186A9C570", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public IONJALDOMGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GCJHKDPHCIF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DateTime EGDAFOCKENB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class NEDIBJLDLOE
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static long IOILJCCNHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CAE0", Offset = "0x6A9B4E0", VA = "0x186A9CAE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static long LPKFCBADBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CE20", Offset = "0x6A9B820", VA = "0x186A9CE20")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static double NHFFKPNIFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CFE0", Offset = "0x6A9B9E0", VA = "0x186A9CFE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static double MIIMFMONOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CDC0", Offset = "0x6A9B7C0", VA = "0x186A9CDC0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static double HBLBHLGKHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CF80", Offset = "0x6A9B980", VA = "0x186A9CF80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static double FIOELDBEBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6A9CD50", Offset = "0x6A9B750", VA = "0x186A9CD50")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CB40", Offset = "0x6A9B540", VA = "0x186A9CB40")]
	public static double DFLNJOKGDFA(long ELBMBHOBBKO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CCA0", Offset = "0x6A9B6A0", VA = "0x186A9CCA0")]
	public static double EHKKOHDCDBP(long ELBMBHOBBKO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CA30", Offset = "0x6A9B430", VA = "0x186A9CA30")]
	public static double BOEPLENGIPB(double HFGLJDFHJML)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CBF0", Offset = "0x6A9B5F0", VA = "0x186A9CBF0")]
	public static long DPNKICAHHCB(long GOMMNCLFDIF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CDB0", Offset = "0x6A9B7B0", VA = "0x186A9CDB0")]
	public static long FGENKHMABAF(long JMMHHAEJEKK, long ECMLLNBMINI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A9CE80", Offset = "0x6A9B880", VA = "0x186A9CE80")]
	public static double LPIGGOCDKHB(long JMMHHAEJEKK, long ECMLLNBMINI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9D040", Offset = "0x6A9BA40", VA = "0x186A9D040")]
	public static double OLOMPGLPGOC(long JMMHHAEJEKK, long ECMLLNBMINI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class AAOKKAMBPEG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly Timer FCGBKHLAIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly TimeSpan BELNMJHFEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Action BOOGKFJKELO;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A7E0", Offset = "0x6A991E0", VA = "0x186A9A7E0")]
	public AAOKKAMBPEG(TimeSpan BELNMJHFEGJ, Action BOOGKFJKELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x25FEC10", Offset = "0x25FD610", VA = "0x1825FEC10")]
	private void DKPHEFKDDNH(object GFHEAAHHEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A750", Offset = "0x6A99150", VA = "0x186A9A750")]
	public void ODEEIEIKPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A9A730", Offset = "0x6A99130", VA = "0x186A9A730", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[AttributeUsage(AttributeTargets.All)]
public class FGCFFGCIPKG : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly string LLHNHBOMKEI;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
	public FGCFFGCIPKG(string OCAEDNMNFHK)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct CBPAGDMNDPJ : IEquatable<CBPAGDMNDPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public uint LNNOJDAAIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int FLCPICEGPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float LIPDLLDHMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public ushort BGPNDEFGCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public ushort IHMJHOFIOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public short IOFKNBHCEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public short PPAJMPEAKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public char AHHFCFJPFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public char FGCCHMDJNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public byte HKEGBDBPKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public byte OJFOMPODEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public byte FNHEKIAHBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public byte BNGPILMIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool OEOEDPDPBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public bool INFLHKHNKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public bool ECJGAHDJPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public bool CNJPLABIOJH;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x95B490", Offset = "0x959E90", VA = "0x18095B490")]
	public static CBPAGDMNDPJ MOPCGJDIPDB(uint FHNPPKIAOFO)
	{
		return default(CBPAGDMNDPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x95B490", Offset = "0x959E90", VA = "0x18095B490")]
	public static CBPAGDMNDPJ LJKGLKOGBGE(int NNBMMMKDEAF)
	{
		return default(CBPAGDMNDPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1B4C6F0", Offset = "0x1B4B0F0", VA = "0x181B4C6F0")]
	public static CBPAGDMNDPJ EAABKGGAJNM(float JDCHHLPFHMM)
	{
		return default(CBPAGDMNDPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AB70", Offset = "0x6A99570", VA = "0x186A9AB70")]
	public static CBPAGDMNDPJ CDEEFHADDKH(byte LFAGICFFHOA, byte KIONOALNCAI, byte DBNJIFHPAJK, byte FNODLBHMBKC)
	{
		return default(CBPAGDMNDPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AB70", Offset = "0x6A99570", VA = "0x186A9AB70")]
	public static CBPAGDMNDPJ AAJHMKDCLDM(bool BKJLIJPCHCK, bool JGIMOCOPCHF, bool JEBGABJBGLN, bool BMIAHFKCBOB)
	{
		return default(CBPAGDMNDPJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x95B8C0", Offset = "0x95A2C0", VA = "0x18095B8C0")]
	public static bool ENMIHMCKBEN(CBPAGDMNDPJ OLGHNLLKLDL, CBPAGDMNDPJ JPDHFMDKHGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x95B480", Offset = "0x959E80", VA = "0x18095B480", Slot = "4")]
	public bool Equals(CBPAGDMNDPJ EHBPAFKHADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AB90", Offset = "0x6A99590", VA = "0x186A9AB90", Slot = "0")]
	public override bool Equals(object OMHIFHKMIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x14337C0", Offset = "0x14321C0", VA = "0x1814337C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AC10", Offset = "0x6A99610", VA = "0x186A9AC10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct AEFFPANPOFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public ulong NJAHDCEPDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public long DPANAJPOMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public double CBHFPLOACOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public uint CAPGIGBMPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public uint GOCGCEKENOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int MFNGEJGLNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public int LIELBOPABDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float COHANPNAILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float PBEJJAFBEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public ushort BGPNDEFGCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public ushort IHMJHOFIOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public ushort HABFBNCBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public ushort FLCMGKEJKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public short IOFKNBHCEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public short PPAJMPEAKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public short DDOLAGHJFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public short KEOGFFMAMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public char AHHFCFJPFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public char FGCCHMDJNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public char PEDINENLOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public char DJJLEJCMGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public byte HKEGBDBPKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public byte OJFOMPODEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public byte FNHEKIAHBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public byte BNGPILMIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public byte IPMADIHJCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public byte HPDGDGMPENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public byte CMLIAIJICEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public byte LDCAHLPGOMG;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AA30", Offset = "0x6A99430", VA = "0x186A9AA30")]
	public static AEFFPANPOFL IDLIIDOEAFG(byte LFAGICFFHOA, byte KIONOALNCAI, byte DBNJIFHPAJK, byte FNODLBHMBKC, byte PNBLDBDDFKB, byte NJGCIMACDBH, byte AEAOMPIANHD, byte IOLCBLJIPBD)
	{
		return default(AEFFPANPOFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NABNCANBDCO
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3C71BD0", Offset = "0x3C705D0", VA = "0x183C71BD0")]
	public static IEnumerable<T> OCFLHFHAPPL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0")]
	public static T[] JAIJHCMHPPK<T>(params T[] DCGODGEJKFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8426B0", Offset = "0x8410B0", VA = "0x1808426B0")]
	public static IEnumerable<T> GJNIFHJDCMC<T>(params T[] DCGODGEJKFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2918CA0", Offset = "0x29176A0", VA = "0x182918CA0")]
	public static HashSet<T> KPCJBMFKMLO<T>(params T[] DCGODGEJKFL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C71AE0", Offset = "0x3C704E0", VA = "0x183C71AE0")]
	public static KeyValuePair<TKey, TValue> DMCPPLNHIFH<TKey, TValue>(in TKey IGFDDANAMMH, in TValue MFBGAMJDOKA) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x2918CA0", Offset = "0x29176A0", VA = "0x182918CA0")]
	public static List<T> JEJGELONOGJ<T>(IEnumerable<T> FGILJLADPAP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[AttributeUsage(AttributeTargets.All)]
public sealed class KMCFPCOAJNM : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly string BJNHFFGCJDE;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x847190", Offset = "0x845B90", VA = "0x180847190")]
	public KMCFPCOAJNM(string CCAKDIALPDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[NHKABPFKCJN]
public delegate void LEGINELIAAI(string KMEGKECOLPJ);
[Cpp2IlInjected.Token(Token = "0x2000028")]
[NHKABPFKCJN]
public delegate void FLCPFEPLPEM();
[Cpp2IlInjected.Token(Token = "0x2000029")]
public delegate object LLHCBCFHKJO<T>(T LIKLGHJBPPH);
[Cpp2IlInjected.Token(Token = "0x200002A")]
public delegate object FOLHNAHGELK<T>(in T LIKLGHJBPPH);
[Cpp2IlInjected.Token(Token = "0x200002B")]
[NHKABPFKCJN]
public delegate string MMLODJBCFBA(string ANIDBJJMJNL, string? IJIPLLNGNDB, bool CIPGEMPKIOO);
[Cpp2IlInjected.Token(Token = "0x200002C")]
[NHKABPFKCJN]
public delegate void KPIJGCFNCBN(string MDEEJIBNIAD);
[Cpp2IlInjected.Token(Token = "0x200002D")]
[NHKABPFKCJN]
public delegate void CDNHPPFNBKA(Exception HELJFFINGAN);
[Cpp2IlInjected.Token(Token = "0x200002E")]
public delegate object ILMFLEANNFL();
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NHKABPFKCJN]
public delegate bool HJKKJLDADJM();
[Cpp2IlInjected.Token(Token = "0x2000030")]
[NHKABPFKCJN]
public delegate string FFGNLDLIMFC(object OMHIFHKMIMJ);
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class DDPOCPLIPKP : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
	public DDPOCPLIPKP(bool CPEFOJLOEIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public sealed class CBKILEIFAJG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A9AA90", Offset = "0x6A99490", VA = "0x186A9AA90")]
	public CBKILEIFAJG(bool CPEFOJLOEIJ, string OELIALHFIAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class OFMILDPNIPJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x143BBF0", Offset = "0x143A5F0", VA = "0x18143BBF0")]
	public OFMILDPNIPJ(bool CPEFOJLOEIJ)
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
