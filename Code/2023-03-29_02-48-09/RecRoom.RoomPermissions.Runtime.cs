using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6077F80", Offset = "0x6076D80", VA = "0x186077F80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x740BD0", Offset = "0x73F9D0", VA = "0x180740BD0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB9A310", Offset = "0xB99110", VA = "0x180B9A310")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DGPKFIBBCBF
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KFBJHAKCJMP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MPDKPONGJIM<TPermission>(TPermission FNINEMCHMPL);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void ILHGPBGKBIG(CJKNNGNCCII ECIFJEEMMFF);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CAAIHJCBFMG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CKDAKDJPBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool PHEJPPPHFFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IDFECPCILCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CEJLIBLBHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FHAFDNGPEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BJJDMFMMLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IHIJLCOGJEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	DBCGLHFKKHK MAAOLIPJKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<CDKOJJIOEJG> NFNBMCNAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event ILHGPBGKBIG ICONEAHAFEK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<CDKOJJIOEJG> EFJHNPDPCAJ(bool CIHHMAIFOOF = false);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CDKOJJIOEJG AAEIAFHKABB(CJKNNGNCCII ECIFJEEMMFF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JKIAJCCGPDO(CJKNNGNCCII ECIFJEEMMFF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<CDKOJJIOEJG> JNDOANAJCGJ(CJKNNGNCCII ECIFJEEMMFF, bool BMNMNIAHKNL = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MFAJNPBMNNJ(CJKNNGNCCII LDDPKEFMNIM, KKCLEFJALJE KOMEPFMFJMC);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CDKOJJIOEJG LMBDAOFIIFH(KKCLEFJALJE KOMEPFMFJMC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool CIINCIEABPF<T>(KKCLEFJALJE KOMEPFMFJMC, OEICCCMCELP FNINEMCHMPL, bool GBFJCDPNJHI, T GDIGEJIEHAB) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PDHDJJNGGGJ
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FAOPPDPCKJB(MBMCPLADCOA IMALMBEAIBN, CancellationToken ONFKFAAPNBK);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HLHMBPAFPJN(ref MBMCPLADCOA IMALMBEAIBN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BDIOMBEKFFE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CJKNNGNCCII HBGOIMOOENI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PKFOPMMCGBJ IAGAADHAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	GPALAEGGNLI LJHIJMNOBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GCCFKFPICJJ> KJANALMEEGI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OGOOODGJPLO;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KKCLEFJALJE PFBKEHBAKLE(CJKNNGNCCII ECIFJEEMMFF);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GCCFKFPICJJ> JOBGPNOEOEE(CancellationToken ONFKFAAPNBK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task HGKJGEJEBBA(long JNEOKPAKAMP, long GINOMKDCFML, IReadOnlyList<AENBAMEBDBC> HIOCNAIJKHM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CJKNNGNCCII> KKPPMGJBBAM();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GAAJFFBEBEB
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6070B90", Offset = "0x606F990", VA = "0x186070B90")]
	public static KKCLEFJALJE DBFGICABPPF(this BDIOMBEKFFE OCPDMGCJHMG)
	{
		return default(KKCLEFJALJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JDACJHDEEJA<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string JKBFLDOMGBK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event global::MPDKPONGJIM<TPermission> KICCCLBKPDL;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class AGIFIGPBLCE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum FFHMELBMNJI
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid NOMMANABAAC;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid GIKPGNPOIOO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid MBFKLEGJOII;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid KMLGADDHBJB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid JOFJMOLKMPJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly global::CHGPKKDCPDF<KKCLEFJALJE, Guid> DOBBFHLOOAB;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IEnumerable<KKCLEFJALJE> MKLHPNDECIL
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x606C440", Offset = "0x606B240", VA = "0x18606C440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x606C730", Offset = "0x606B530", VA = "0x18606C730")]
	public static KKCLEFJALJE NNFJHBEJJML(Guid LAJNKLHJFND)
	{
		return default(KKCLEFJALJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x606C5A0", Offset = "0x606B3A0", VA = "0x18606C5A0")]
	public static Guid HIGAOLIEBAL(KKCLEFJALJE KOMEPFMFJMC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x606C500", Offset = "0x606B300", VA = "0x18606C500")]
	public static bool HGCDONDBKDL(KKCLEFJALJE KOMEPFMFJMC, out Guid LAJNKLHJFND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x606C7C0", Offset = "0x606B5C0", VA = "0x18606C7C0")]
	public static bool OBDBJCMNNIO(Guid LAJNKLHJFND, out KKCLEFJALJE KOMEPFMFJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x606C650", Offset = "0x606B450", VA = "0x18606C650")]
	public static KKCLEFJALJE JADDMLMALMN(KKCLEFJALJE KOMEPFMFJMC)
	{
		return default(KKCLEFJALJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x606C680", Offset = "0x606B480", VA = "0x18606C680")]
	public static FFHMELBMNJI KFFABDKJPAC(KKCLEFJALJE CKIPDPOOACK)
	{
		return default(FFHMELBMNJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x606C4C0", Offset = "0x606B2C0", VA = "0x18606C4C0")]
	internal static KKCLEFJALJE GFIPFEKPEKE(FFHMELBMNJI CAGLBGOKDOF)
	{
		return default(KKCLEFJALJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class MGPGLLGKPMP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? GFJOPFLNNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	protected MGPGLLGKPMP(object? JBDLEPBHKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool DJFHMHBCIBN(object? NLHFEJHKLAH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class EJFMJCKLLCN<T> : MGPGLLGKPMP where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T DMAGGLKKJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> LNEIILNMONM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T DKPIGGFDHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3513780", Offset = "0x3512580", VA = "0x183513780", Slot = "4")]
	public override bool DJFHMHBCIBN(object? NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3513A20", Offset = "0x3512820", VA = "0x183513A20")]
	public bool KMOLNDHAEOJ(T EOCEGCLFNKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3513F30", Offset = "0x3512D30", VA = "0x183513F30")]
	public EJFMJCKLLCN(T IMIKACAODIP, IEqualityComparer<T> LNEIILNMONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class FKAOBADJOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<OEICCCMCELP, bool> JEDLIKMLDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<OEICCCMCELP, MGPGLLGKPMP> CLENPPEAIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly BJFNEIEMFCJ GJHHIDAHHBO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6070920", Offset = "0x606F720", VA = "0x186070920")]
	public FKAOBADJOAK(BJFNEIEMFCJ GJHHIDAHHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x60704A0", Offset = "0x606F2A0", VA = "0x1860704A0")]
	public bool GGNLALKDMPM(OEICCCMCELP FNINEMCHMPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2280FA0", Offset = "0x227FDA0", VA = "0x182280FA0")]
	public bool MKMPAABHPEL<T>(OEICCCMCELP FNINEMCHMPL, bool GBFJCDPNJHI, T NLHFEJHKLAH) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2280A90", Offset = "0x227F890", VA = "0x182280A90")]
	public (bool, T?) KJPLKFMJFHD<T>(OEICCCMCELP FNINEMCHMPL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x60705E0", Offset = "0x606F3E0", VA = "0x1860705E0")]
	public bool MKMPAABHPEL(OEICCCMCELP FNINEMCHMPL, bool GBFJCDPNJHI, object NLHFEJHKLAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6070510", Offset = "0x606F310", VA = "0x186070510")]
	public (bool, object) KJPLKFMJFHD(OEICCCMCELP FNINEMCHMPL)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2280850", Offset = "0x227F650", VA = "0x182280850")]
	private void ILMLIBKEFAF<T>(OEICCCMCELP FNINEMCHMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60706C0", Offset = "0x606F4C0", VA = "0x1860706C0")]
	private MGPGLLGKPMP NPHJOOINAIF(OEICCCMCELP FNINEMCHMPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6070780", Offset = "0x606F580", VA = "0x186070780")]
	public void OPHPFEENBAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class ICIOOEKDEJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string KFEOLFOGHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type FAGJGOONDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly PEPLHBHEDOG NMAKLCJHFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly OEICCCMCELP KKJFIIJECEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LAODOHIJECF AMJENGPDGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public BFKCPPGHLJJ FLGANDFIEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MEHHFJGJKGM FPMEHCHCCFO;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6076D70", Offset = "0x6075B70", VA = "0x186076D70")]
	public ICIOOEKDEJH(Type LABJIADKJHG, string JIECLEDMKEK, OEICCCMCELP FNINEMCHMPL, LAODOHIJECF OHEMPDOIOEE, BFKCPPGHLJJ ODMIFADLJIA, MEHHFJGJKGM PBGDLEFHGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6076D30", Offset = "0x6075B30", VA = "0x186076D30")]
	public object PDPLJDHINNP(object? ONICAEEHHFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x270BF30", Offset = "0x270AD30", VA = "0x18270BF30")]
	public void ILMLIBKEFAF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6076C80", Offset = "0x6075A80", VA = "0x186076C80")]
	public void ILMLIBKEFAF(Type MHELFGGGMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class JPCEGJLPGMJ<T> : ICIOOEKDEJH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string MHJPNHHHEMO(T NLHFEJHKLAH);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T DOHGFCMLIAB(string? CONCDJPDJLP, T IMIKACAODIP);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LOGAJKIEPGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public MHJPNHHHEMO serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DOHGFCMLIAB parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public LOGAJKIEPGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x320CC10", Offset = "0x320BA10", VA = "0x18320CC10")]
		internal string <.ctor>b__0(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x320CC80", Offset = "0x320BA80", VA = "0x18320CC80")]
		internal object <.ctor>b__1(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA8920", Offset = "0x2BA7720", VA = "0x182BA8920")]
	public JPCEGJLPGMJ(OEICCCMCELP FNINEMCHMPL, string JIECLEDMKEK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x691E10", Offset = "0x691210")] global::JPCEGJLPGMJ<T>.MHJPNHHHEMO OHEMPDOIOEE, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x691E70", Offset = "0x691270")] global::JPCEGJLPGMJ<T>.DOHGFCMLIAB ODMIFADLJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7ED0", Offset = "0x2BA6CD0", VA = "0x182BA7ED0")]
	private static object? DHABJCANOEO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x691ED0", Offset = "0x6912D0")] global::JPCEGJLPGMJ<T?>.DOHGFCMLIAB? ODMIFADLJIA, string? CONCDJPDJLP, object? IMIKACAODIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA75C0", Offset = "0x2BA63C0", VA = "0x182BA75C0")]
	private static string APDPBGNCGIO([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x691F30", Offset = "0x691330")] global::JPCEGJLPGMJ<T>.MHJPNHHHEMO GFJBHDBADIO, object? NLHFEJHKLAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string LAODOHIJECF(object? NLHFEJHKLAH);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object BFKCPPGHLJJ(string? CONCDJPDJLP, [Optional] object IMIKACAODIP);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate MGPGLLGKPMP MEHHFJGJKGM();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class BJFNEIEMFCJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class PICFBPAEIFB : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static PICFBPAEIFB PDNDNIMAPDO;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6078010", Offset = "0x6076E10", VA = "0x186078010", Slot = "4")]
		public bool Equals(List<string> PAMKNJCGOGK, List<string> IOAMOMOPNDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6078170", Offset = "0x6076F70", VA = "0x186078170", Slot = "5")]
		public int GetHashCode(List<string> BLIKPCIFNNO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PICFBPAEIFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class FFDOAJAGHMC : global::GAGNOOFOIHL<DGPKFIBBCBF>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6070170", Offset = "0x606EF70", VA = "0x186070170", Slot = "9")]
		public override string APDPBGNCGIO(DGPKFIBBCBF LCGINHIJIBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6070270", Offset = "0x606F070", VA = "0x186070270", Slot = "10")]
		protected override bool DOMPMGIJDKC(string LCGINHIJIBJ, out DGPKFIBBCBF NLHFEJHKLAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6070460", Offset = "0x606F260", VA = "0x186070460")]
		public FFDOAJAGHMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly MMIFBIEBEGM APIFEJJPAIB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly FFDOAJAGHMC IEIOKDNJGLB;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<ICIOOEKDEJH> APLPDNKEHHH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<OEICCCMCELP> NMIDMFJDLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<OEICCCMCELP, ICIOOEKDEJH> OPJHEGJDMBE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x606D920", Offset = "0x606C720", VA = "0x18606D920")]
	public BJFNEIEMFCJ([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x691F90", Offset = "0x691390")] IList<ICIOOEKDEJH> LCEIPDEDIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x606CD30", Offset = "0x606BB30", VA = "0x18606CD30")]
	public ICIOOEKDEJH LBPBFBNFLDL(OEICCCMCELP FNINEMCHMPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface DBCGLHFKKHK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CDKOJJIOEJG AKIFEEBMHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class GFOKMBNIKCK : DBCGLHFKKHK
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static GFOKMBNIKCK NEOINMPCKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly EDMHFPCNCNO KLPJAEDNEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<EDMHFPCNCNO> PNKEINHJOAL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public CDKOJJIOEJG AKIFEEBMHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6071430", Offset = "0x6070230", VA = "0x186071430")]
	public GFOKMBNIKCK(EDMHFPCNCNO NILIMKJJGEE, IReadOnlyList<EDMHFPCNCNO> NIAKOIFMLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6070BF0", Offset = "0x606F9F0", VA = "0x186070BF0")]
	private static GFOKMBNIKCK IIFKINJGNKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CFEIMEBAGGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<KKCLEFJALJE> OFHAGBALELL;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x606DD10", Offset = "0x606CB10", VA = "0x18606DD10")]
	public static bool NAKCHDPBILO(this CJKNNGNCCII ONGPLIEJDCK, KKCLEFJALJE KOMEPFMFJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x606DC90", Offset = "0x606CA90", VA = "0x18606DC90")]
	public static bool EAJJNAKLBHE(this CJKNNGNCCII ONGPLIEJDCK, KKCLEFJALJE KOMEPFMFJMC, GPALAEGGNLI EFENIFDKEEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface NCCIJGFFLMI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool ADCLKHAJCDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool EIJJPBPEPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool IOAEAMILFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LKADDAPNNND
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool PGCEGOJIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MMMNGFEFADL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AFKENGKFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EAJFOLMDELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JHIJKAAMOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GKFFEDCLPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IKHEPFPJLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FHCPCKCNHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> CBGEOMBLDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DGPKFIBBCBF EPJPHCMINAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CDKOJJIOEJG : NCCIJGFFLMI, CAAIHJCBFMG, global::JDACJHDEEJA<OEICCCMCELP>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string EOPEKGIGFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KKCLEFJALJE MOMDLDMNBGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ENAOOIMCJMN<T>(OEICCCMCELP FNINEMCHMPL) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum OEICCCMCELP
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class EDMHFPCNCNO : CDKOJJIOEJG, NCCIJGFFLMI, CAAIHJCBFMG, global::JDACJHDEEJA<OEICCCMCELP>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly BJFNEIEMFCJ JOGEMJGKKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly FKAOBADJOAK EFOIPHMPGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? AIFPKCOLABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? IALKJEJPDNN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool ADCLKHAJCDG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x606F770", Offset = "0x606E570", VA = "0x18606F770", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public DGPKFIBBCBF EPJPHCMINAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x606EC30", Offset = "0x606DA30", VA = "0x18606EC30", Slot = "20")]
		get
		{
			return default(DGPKFIBBCBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool EIJJPBPEPHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x606F720", Offset = "0x606E520", VA = "0x18606F720", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IOAEAMILFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x606ECD0", Offset = "0x606DAD0", VA = "0x18606ECD0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LKADDAPNNND
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x606EB90", Offset = "0x606D990", VA = "0x18606EB90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool PGCEGOJIFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x606F9F0", Offset = "0x606E7F0", VA = "0x18606F9F0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MMMNGFEFADL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x606EBE0", Offset = "0x606D9E0", VA = "0x18606EBE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool AFKENGKFBJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x606F7C0", Offset = "0x606E5C0", VA = "0x18606F7C0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool EAJFOLMDELA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x606E9F0", Offset = "0x606D7F0", VA = "0x18606E9F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JHIJKAAMOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x606E020", Offset = "0x606CE20", VA = "0x18606E020", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<string> CBGEOMBLDNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x606EA40", Offset = "0x606D840", VA = "0x18606EA40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LOEEMEAECNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x606E9A0", Offset = "0x606D7A0", VA = "0x18606E9A0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CIEEMBHBPEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x606E950", Offset = "0x606D750", VA = "0x18606E950", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BFNGEIOOLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x606E1A0", Offset = "0x606CFA0", VA = "0x18606E1A0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool GKFFEDCLPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x606EC80", Offset = "0x606DA80", VA = "0x18606EC80", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IKHEPFPJLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x606DFD0", Offset = "0x606CDD0", VA = "0x18606DFD0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ALJNEBPBMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x606ED20", Offset = "0x606DB20", VA = "0x18606ED20", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool FHCPCKCNHIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x606F910", Offset = "0x606E710", VA = "0x18606F910", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GDOAIFDACDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x606E150", Offset = "0x606CF50", VA = "0x18606E150", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool CDLBCGBJLCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x606EAA0", Offset = "0x606D8A0", VA = "0x18606EAA0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool EAMOMNCHABM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x606E9A0", Offset = "0x606D7A0", VA = "0x18606E9A0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool JJGAOJCMIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x606E1A0", Offset = "0x606CFA0", VA = "0x18606E1A0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool DNPLIFLPCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x606ED20", Offset = "0x606DB20", VA = "0x18606ED20", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool JLJOHCJHHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x606E150", Offset = "0x606CF50", VA = "0x18606E150", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool ILIIOKEHANL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x606E950", Offset = "0x606D750", VA = "0x18606E950", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool DIPNFMDFIBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x606EAA0", Offset = "0x606D8A0", VA = "0x18606EAA0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KKCLEFJALJE MOMDLDMNBGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x76B430", Offset = "0x76A230", VA = "0x18076B430", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(KKCLEFJALJE);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D2430", Offset = "0x7D1230", VA = "0x1807D2430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string JKBFLDOMGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x606FA40", Offset = "0x606E840", VA = "0x18606FA40", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x606FE90", Offset = "0x606EC90", VA = "0x18606FE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string EOPEKGIGFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x606FA40", Offset = "0x606E840", VA = "0x18606FA40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HIFHFKHJCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FA370", Offset = "0x6F9170", VA = "0x1806FA370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA3F0", Offset = "0x6F91F0", VA = "0x1806FA3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MPDKPONGJIM<OEICCCMCELP> KICCCLBKPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x606FDF0", Offset = "0x606EBF0", VA = "0x18606FDF0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x606EAF0", Offset = "0x606D8F0", VA = "0x18606EAF0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x606E310", Offset = "0x606D110", VA = "0x18606E310")]
	public NFLLOBICDBG DAIEOOKEGAO(Func<KKCLEFJALJE, Guid> CIPBNBKBLPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x606ED70", Offset = "0x606DB70", VA = "0x18606ED70")]
	public void KPDDMHJPAAJ(NFLLOBICDBG NADAGNIKOME, Func<Guid, KKCLEFJALJE> HJOEINGHOEO, [Optional] KKCLEFJALJE? LLCJJFNCKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2FB0510", Offset = "0x2FAF310", VA = "0x182FB0510", Slot = "6")]
	public (bool, T?) ENAOOIMCJMN<T>(OEICCCMCELP FNINEMCHMPL) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2FB06A0", Offset = "0x2FAF4A0", VA = "0x182FB06A0")]
	public EDMHFPCNCNO HGIPPDBEINE<T>(OEICCCMCELP FNINEMCHMPL, bool GBFJCDPNJHI, T NLHFEJHKLAH) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6070150", Offset = "0x606EF50", VA = "0x186070150")]
	public EDMHFPCNCNO(KKCLEFJALJE KOMEPFMFJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x606FF50", Offset = "0x606ED50", VA = "0x18606FF50")]
	public EDMHFPCNCNO(KKCLEFJALJE KOMEPFMFJMC, [Optional] string? AIFPKCOLABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x606FF70", Offset = "0x606ED70", VA = "0x18606FF70")]
	public EDMHFPCNCNO(EDMHFPCNCNO FMMAEJGABIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6070000", Offset = "0x606EE00", VA = "0x186070000")]
	internal EDMHFPCNCNO(KKCLEFJALJE MNBACLMHOKM, [Optional] string? AIFPKCOLABM, [Optional] EDMHFPCNCNO? FMMAEJGABIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x606E1F0", Offset = "0x606CFF0", VA = "0x18606E1F0")]
	public static PEPLHBHEDOG BEJFPEGGBNP(OEICCCMCELP FNINEMCHMPL)
	{
		return default(PEPLHBHEDOG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x606FDD0", Offset = "0x606EBD0", VA = "0x18606FDD0")]
	public void OPHPFEENBAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x606FA90", Offset = "0x606E890", VA = "0x18606FA90")]
	internal EDMHFPCNCNO OMKNBMCOCHA(EDMHFPCNCNO MMJPNLHCCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x606E520", Offset = "0x606D320", VA = "0x18606E520")]
	internal IReadOnlyCollection<OEICCCMCELP> DMNJIELPLLP(EDMHFPCNCNO FMMAEJGABIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x606E070", Offset = "0x606CE70", VA = "0x18606E070")]
	public bool BBJDLNNOFOJ(OEICCCMCELP FNINEMCHMPL, bool GBFJCDPNJHI, string HLIJFNFKNCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x606F810", Offset = "0x606E610", VA = "0x18606F810")]
	public (bool, string) NCPEEMMJCEM(OEICCCMCELP FNINEMCHMPL)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x606E270", Offset = "0x606D070", VA = "0x18606E270")]
	internal void CGHGBIGKEED(OEICCCMCELP FNINEMCHMPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x606F960", Offset = "0x606E760", VA = "0x18606F960")]
	[CompilerGenerated]
	private void OAIPOJLNHAE(OEICCCMCELP FOGBGDODIPH, BJDOBDOBPEE PPAENDDJPIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GKEOHCMADPC : PDHDJJNGGGJ, IHIJLCOGJEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NGOHLPKHLAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public EDMHFPCNCNO newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public NGOHLPKHLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6077F50", Offset = "0x6076D50", VA = "0x186077F50")]
		internal bool <InitializeRolesLists>b__0(EDMHFPCNCNO rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FMLPCNCDOFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public KKCLEFJALJE roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public FMLPCNCDOFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6070B80", Offset = "0x606F980", VA = "0x186070B80")]
		internal bool <UpdateRoleDatas>b__0(KKCLEFJALJE r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct MFKCEJCCGKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public GKEOHCMADPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MBMCPLADCOA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x692540", Offset = "0x691940")]
		private TaskAwaiter<GCCFKFPICJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6077930", Offset = "0x6076730", VA = "0x186077930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BFNCFDEBGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public BFNCFDEBGFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x606CB30", Offset = "0x606B930", VA = "0x18606CB30")]
		internal void <RunBackwardsCompatibilityMigration>b__0(NFLLOBICDBG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x606CC10", Offset = "0x606BA10", VA = "0x18606CC10")]
		internal void <RunBackwardsCompatibilityMigration>b__1(NFLLOBICDBG r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JOEOMBCLLNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public MBMCPLADCOA roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class KIJCIEOILGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6925A0", Offset = "0x6919A0")]
		public Func<NFLLOBICDBG, BJDOBDOBPEE> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public KIJCIEOILGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6077810", Offset = "0x6076610", VA = "0x186077810")]
		internal void <MigrateLegacyHostSettings>b__1(NFLLOBICDBG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6077870", Offset = "0x6076670", VA = "0x186077870")]
		internal void <MigrateLegacyHostSettings>b__2(NFLLOBICDBG r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x60778D0", Offset = "0x60766D0", VA = "0x1860778D0")]
		internal void <MigrateLegacyHostSettings>b__3(NFLLOBICDBG r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PHOAEBANAKO<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public GKEOHCMADPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public OEICCCMCELP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public KKCLEFJALJE accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PEPLHBHEDOG recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public PHOAEBANAKO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NIKOJGMLHFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<AENBAMEBDBC> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct IDFIGEALOOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public BDIOMBEKFFE rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public MBMCPLADCOA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x6926B0", Offset = "0x691AB0")]
		public IReadOnlyDictionary<KKCLEFJALJE, EDMHFPCNCNO> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public ENCPAGENDDF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6076E00", Offset = "0x6075C00", VA = "0x186076E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly BDIOMBEKFFE OCPDMGCJHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly GFOKMBNIKCK JPIHGIMGDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly ENCPAGENDDF JMMEFKEMNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, EDMHFPCNCNO> MPHLOGBPMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<KKCLEFJALJE, EDMHFPCNCNO> HGJNIJGMONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<KKCLEFJALJE, EDMHFPCNCNO> HDAFLBBGLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<EDMHFPCNCNO> OFMLOGFFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool IOCOCCPAMPP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly OEICCCMCELP[] DADCDJGEIGH;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DBCGLHFKKHK MAAOLIPJKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<CDKOJJIOEJG> NFNBMCNAIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6073070", Offset = "0x6071E70", VA = "0x186073070", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event ILHGPBGKBIG ICONEAHAFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6073810", Offset = "0x6072610", VA = "0x186073810", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6073450", Offset = "0x6072250", VA = "0x186073450", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6073BA0", Offset = "0x60729A0", VA = "0x186073BA0")]
	[NPBDMCLHPNM(LGHNOHBEMLG.Room, AIJEIIPHIJH.None)]
	private static void HEKOMGIGKGF(HKDBAIGILEN OGKNFCDFHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x60769F0", Offset = "0x60757F0", VA = "0x1860769F0")]
	[UnityEngine.Scripting.Preserve]
	internal GKEOHCMADPC([KIJADEHPJBH(null)] BDIOMBEKFFE CACDILHCKEK, [KIJADEHPJBH(null)] GFOKMBNIKCK ENFMBPFPAIL, [KIJADEHPJBH(null)] ENCPAGENDDF JMMEFKEMNPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x60727C0", Offset = "0x60715C0", VA = "0x1860727C0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6071D80", Offset = "0x6070B80", VA = "0x186071D80")]
	private void AIGBOPODDNE(IEnumerable<EDMHFPCNCNO> MIIAGCGPFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6074180", Offset = "0x6072F80", VA = "0x186074180", Slot = "12")]
	public bool JKIAJCCGPDO(CJKNNGNCCII ECIFJEEMMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6076810", Offset = "0x6075610", VA = "0x186076810")]
	private void OGOOODGJPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6072570", Offset = "0x6071370", VA = "0x186072570")]
	private void CAOMLJBIFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x60728D0", Offset = "0x60716D0", VA = "0x1860728D0", Slot = "10")]
	public IReadOnlyList<CDKOJJIOEJG> EFJHNPDPCAJ(bool CIHHMAIFOOF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6071530", Offset = "0x6070330", VA = "0x186071530", Slot = "11")]
	public CDKOJJIOEJG AAEIAFHKABB(CJKNNGNCCII ECIFJEEMMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6072700", Offset = "0x6071500", VA = "0x186072700")]
	private KKCLEFJALJE DKFMNLNMKCG(CJKNNGNCCII ECIFJEEMMFF)
	{
		return default(KKCLEFJALJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6075DD0", Offset = "0x6074BD0", VA = "0x186075DD0", Slot = "14")]
	public bool MFAJNPBMNNJ(CJKNNGNCCII LDDPKEFMNIM, KKCLEFJALJE KOMEPFMFJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6075D20", Offset = "0x6074B20", VA = "0x186075D20", Slot = "15")]
	public CDKOJJIOEJG LMBDAOFIIFH(KKCLEFJALJE KOMEPFMFJMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6073DC0", Offset = "0x6072BC0", VA = "0x186073DC0")]
	private static bool JCBADPJECIK(NIGNPPLEFMI FLBFHELKDNG, KKCLEFJALJE KOMEPFMFJMC, out NFLLOBICDBG? HFBILDBGMLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6074840", Offset = "0x6073640", VA = "0x186074840")]
	private static void KIKLJCGPMJF(NIGNPPLEFMI FLBFHELKDNG, Action<NFLLOBICDBG> GKCLOINECKI, KKCLEFJALJE ELFOFCKJGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6074940", Offset = "0x6073740", VA = "0x186074940")]
	private static void KIKLJCGPMJF(NIGNPPLEFMI FLBFHELKDNG, Action<NFLLOBICDBG> GKCLOINECKI, Predicate<KKCLEFJALJE> DFOKDEJADJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6073D60", Offset = "0x6072B60", VA = "0x186073D60")]
	private void HGJEHBGPKPJ(CJKNNGNCCII ECIFJEEMMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6072F30", Offset = "0x6071D30", VA = "0x186072F30", Slot = "4")]
	[AsyncStateMachine(typeof(MFKCEJCCGKB))]
	public Task FAOPPDPCKJB([CanBeNull] MBMCPLADCOA IMALMBEAIBN, CancellationToken ONFKFAAPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
	public void HLHMBPAFPJN(ref MBMCPLADCOA IMALMBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6075F60", Offset = "0x6074D60", VA = "0x186075F60")]
	private void NDGGOHACAFP(NIGNPPLEFMI OFNHJONMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x60734F0", Offset = "0x60722F0", VA = "0x1860734F0")]
	internal static string FJFDCOBJJOK(BDIOMBEKFFE OCPDMGCJHMG, MBMCPLADCOA IMALMBEAIBN, IReadOnlyDictionary<KKCLEFJALJE, EDMHFPCNCNO> HGJNIJGMONB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6074D60", Offset = "0x6073B60", VA = "0x186074D60")]
	private static void LFFFNHJHLBD(MBMCPLADCOA IMALMBEAIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6074520", Offset = "0x6073320", VA = "0x186074520")]
	private static void JLNFMDHPFAO(NIGNPPLEFMI ODGJDFKIDHF, IReadOnlyDictionary<KKCLEFJALJE, EDMHFPCNCNO> HGJNIJGMONB, StringBuilder BNBBJIGNLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6075BC0", Offset = "0x60749C0", VA = "0x186075BC0")]
	private static bool LLOPHEJDAPO(string ILMFECMEOPO, out Guid GGONFPDILJB, out KKCLEFJALJE KOMEPFMFJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6072950", Offset = "0x6071750", VA = "0x186072950")]
	private static void EHAHOGEPHAN(MBMCPLADCOA IMALMBEAIBN, StringBuilder BNBBJIGNLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x228E400", Offset = "0x228D200", VA = "0x18228E400", Slot = "16")]
	public bool CIINCIEABPF<T>(KKCLEFJALJE KOMEPFMFJMC, OEICCCMCELP FNINEMCHMPL, bool GBFJCDPNJHI, T GDIGEJIEHAB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x60764F0", Offset = "0x60752F0", VA = "0x1860764F0")]
	private void NPBCLMLFEON(KKCLEFJALJE KOMEPFMFJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x60737F0", Offset = "0x60725F0", VA = "0x1860737F0")]
	private bool GGGJCBABDNF(CJKNNGNCCII ECIFJEEMMFF, KKCLEFJALJE KOMEPFMFJMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x60761D0", Offset = "0x6074FD0", VA = "0x1860761D0")]
	internal EDMHFPCNCNO NJOEGHOEALI(CJKNNGNCCII ECIFJEEMMFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6074830", Offset = "0x6073630", VA = "0x186074830", Slot = "13")]
	public IReadOnlyList<CDKOJJIOEJG> JNDOANAJCGJ(CJKNNGNCCII ECIFJEEMMFF, bool BMNMNIAHKNL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6074B40", Offset = "0x6073940", VA = "0x186074B40")]
	internal IReadOnlyList<EDMHFPCNCNO> KOEMJCAPBII(CJKNNGNCCII ECIFJEEMMFF, bool BMNMNIAHKNL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6071640", Offset = "0x6070440", VA = "0x186071640")]
	private void AFNMOGKJKHM(GCCFKFPICJJ BEHNNJPGEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x60738B0", Offset = "0x60726B0", VA = "0x1860738B0")]
	private static bool HCLIDABDPHF(EDMHFPCNCNO OHEIECCAONK, IReadOnlyDictionary<KKCLEFJALJE, EDMHFPCNCNO> HGJNIJGMONB, out IReadOnlyList<OEICCCMCELP> ODDODBEPNOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x60766B0", Offset = "0x60754B0", VA = "0x1860766B0")]
	[AsyncStateMachine(typeof(IDFIGEALOOK))]
	private static Task ODDBLHFDFLM(BDIOMBEKFFE OCPDMGCJHMG, MBMCPLADCOA IMALMBEAIBN, IReadOnlyDictionary<KKCLEFJALJE, EDMHFPCNCNO> HGJNIJGMONB, ENCPAGENDDF JMMEFKEMNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6074250", Offset = "0x6073050", VA = "0x186074250")]
	[CompilerGenerated]
	internal static void JKOCKCDJLPL(Func<NFLLOBICDBG, BJDOBDOBPEE> OGMALFAPOGL, ref JOEOMBCLLNA P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x60730C0", Offset = "0x6071EC0", VA = "0x1860730C0")]
	[CompilerGenerated]
	internal static bool FGBFIAOBNBE(KKCLEFJALJE KOMEPFMFJMC, OEICCCMCELP FNINEMCHMPL, out AENBAMEBDBC LCFPPBBGPIE, ref NIKOJGMLHFO P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BCLGLCCLADA
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONOIECIEBHI(CJKNNGNCCII FIFNLOIIHPE, CJKNNGNCCII KENAIFAOCAC, IEnumerable<CJKNNGNCCII> LJNECAPBJKA, out DGPKFIBBCBF FGDGPAEINGB, out JNJDBMFKMMC CHEIPFMLIIL);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum JNJDBMFKMMC : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class PLOAJLKKCIM : BCLGLCCLADA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly IHIJLCOGJEG IMEHKCNDGJD;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x76B3B0", Offset = "0x76A1B0", VA = "0x18076B3B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PLOAJLKKCIM([KIJADEHPJBH(null)] IHIJLCOGJEG FOAJMEOKMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6078820", Offset = "0x6077620", VA = "0x186078820")]
	private static MPHGAFCMKDN? MGMGMPANIEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6078870", Offset = "0x6077670", VA = "0x186078870", Slot = "4")]
	public bool ONOIECIEBHI(CJKNNGNCCII FIFNLOIIHPE, CJKNNGNCCII KENAIFAOCAC, IEnumerable<CJKNNGNCCII> LJNECAPBJKA, out DGPKFIBBCBF FGDGPAEINGB, out JNJDBMFKMMC CHEIPFMLIIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6078310", Offset = "0x6077110", VA = "0x186078310")]
	internal bool HEIDDEANGCM(CJKNNGNCCII FIFNLOIIHPE, CJKNNGNCCII KENAIFAOCAC, IEnumerable<CJKNNGNCCII> LJNECAPBJKA, GPALAEGGNLI EFENIFDKEEO, MPHGAFCMKDN? CABKPBBDELJ, out DGPKFIBBCBF FGDGPAEINGB, out JNJDBMFKMMC CHEIPFMLIIL)
	{
		return default(bool);
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
