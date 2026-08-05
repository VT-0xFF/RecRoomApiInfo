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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6455900", Offset = "0x6454500", VA = "0x186455900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79BDE0", Offset = "0x79A9E0", VA = "0x18079BDE0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79BE20", Offset = "0x79AA20", VA = "0x18079BE20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LHJMEMIFOMD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void ICMMIFAOJMO<TPermission>(TPermission PBEFJNAEMNC);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void DONNHOANPPH(ILLMBLKEFFI EJDJNJMKMJN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DCJABDDIMLE
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PGNLIGCMCFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IADIBPAMMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JNJIENKLIMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KIKFFPOAKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CDNKMKFBPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EGMCAGKCLFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CFGOEGFLDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class CAHJCPFDMEO
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum KMBAPGBMKCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		AG_EVERYONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		AG_CREATOR = 0x200000,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		AG_COOWNER = 0x400000,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		AG_HOST = 0x800000,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AG_MODERATOR = 0x1000000
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public static readonly Guid FDBDPFFFGFK;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid NEBBGOAOAOH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid PBMONKGBDOO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid INMDIDGEOAI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid MKAILPHNAEJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid JHGLCOADDOG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly IOALBOALGGP<HIAOFBFELNB, Guid> EHMPBMJGNHH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<HIAOFBFELNB> OGPOHNDHHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x644BE70", Offset = "0x644AA70", VA = "0x18644BE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x644BEF0", Offset = "0x644AAF0", VA = "0x18644BEF0")]
	public static HIAOFBFELNB LKELMOMDNKL(Guid OGCEPACDHOE)
	{
		return default(HIAOFBFELNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x644BC00", Offset = "0x644A800", VA = "0x18644BC00")]
	public static Guid DHCBMAGNEJD(HIAOFBFELNB AOFAAIODEGH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x644BB70", Offset = "0x644A770", VA = "0x18644BB70")]
	public static bool DACNMGMEACA(HIAOFBFELNB AOFAAIODEGH, [Out] Guid OGCEPACDHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x644BCE0", Offset = "0x644A8E0", VA = "0x18644BCE0")]
	public static bool FIGCMEABIEN(Guid OGCEPACDHOE, [Out] HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x644BD80", Offset = "0x644A980", VA = "0x18644BD80")]
	public static HIAOFBFELNB HCHCPFLOKAN(HIAOFBFELNB AOFAAIODEGH)
	{
		return default(HIAOFBFELNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x644BDC0", Offset = "0x644A9C0", VA = "0x18644BDC0")]
	public static KMBAPGBMKCG KBAEEDBBGKD(HIAOFBFELNB EGDLOBHLLHN)
	{
		return default(KMBAPGBMKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x644BCA0", Offset = "0x644A8A0", VA = "0x18644BCA0")]
	internal static HIAOFBFELNB FAFDAKLPBJJ(KMBAPGBMKCG PDNAAIFFDHB)
	{
		return default(HIAOFBFELNB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PMMPPMBONAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HNPIOHGGDAE KAPFLHBIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<JJHDCNDHOBL> GMKLGMKOEMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event DONNHOANPPH GNBPPIEDFAD;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<JJHDCNDHOBL> AJCOPOFBIBF(bool PKNKGBFAFGK = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JJHDCNDHOBL HDJFFFKLIMN(ILLMBLKEFFI EJDJNJMKMJN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GBIBJMNGENM(ILLMBLKEFFI EJDJNJMKMJN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<JJHDCNDHOBL> CDCKBCPBLBA(ILLMBLKEFFI EJDJNJMKMJN, bool DLJBAMEFKNH = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OGMCHNFDPDI(ILLMBLKEFFI NJMFDKNBMPN, HIAOFBFELNB AOFAAIODEGH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	JJHDCNDHOBL KMDMIBKCEFO(HIAOFBFELNB AOFAAIODEGH);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool PMBGLFKGCKC<T>(HIAOFBFELNB AOFAAIODEGH, KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, T NGMDGDAKJOP) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IDBOHPIEIEL
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CPIENBNACAN(PGCGNLKABHG EMCADPHEHCL, CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNOIDPFLGPG(PGCGNLKABHG EMCADPHEHCL);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HMNNHDGBKNK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	ILLMBLKEFFI DDNMCBMEAML
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AKINJJFCBCP EKJCEABIDMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	AADJFGNPPBI LHLEOHECMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KLMLJLBJNNC> HCGIJONLNGE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GIBINAPLHIM;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HIAOFBFELNB CJJFPPPBMCJ(ILLMBLKEFFI EJDJNJMKMJN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KLMLJLBJNNC> MGIGMGAJOBB(CancellationToken BJFJMBIBKLL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task KMLMPBGKJLP(long BPJLDBDKBIJ, long LPIJNBPBLPM, IReadOnlyList<PAIHPGJEJDJ> OFGLDDFKMMJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<ILLMBLKEFFI> CMNJLFHCILM();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PMDJFIICNJG
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6456150", Offset = "0x6454D50", VA = "0x186456150")]
	public static HIAOFBFELNB LCGPNDIPGAJ(this HMNNHDGBKNK ALNFIGKEDDK)
	{
		return default(HIAOFBFELNB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AAOCGEPOPKN<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string JAAPMDHNBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event ICMMIFAOJMO<TPermission> DLJIAFKOHLC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class ODJBADKIPKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? MAAPEFOHFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	protected ODJBADKIPKJ(object? DCPKNLPGANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool JFHEACCMIOJ(object? GCPEEAODAIB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class EJMJPOCFDOA<T> : ODJBADKIPKJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T DGONANDOECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> IAFEMJMABIL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F49A0", Offset = "0x7F35A0", VA = "0x1807F49A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x317BA90", Offset = "0x317A690", VA = "0x18317BA90", Slot = "4")]
	public override bool JFHEACCMIOJ(object? GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x317B570", Offset = "0x317A170", VA = "0x18317B570")]
	public bool COINMLNCJOG(T BNBBGDMBANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x317BD60", Offset = "0x317A960", VA = "0x18317BD60")]
	public EJMJPOCFDOA(T MLNCHKABKBO, IEqualityComparer<T> IAFEMJMABIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PHLJIOCNMEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KEGFKEPGJFM, bool> NHNLGNBBJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<KEGFKEPGJFM, ODJBADKIPKJ> CNCHHHBOKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly KLKCBKEKDNM JEBGABLKILD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6455EA0", Offset = "0x6454AA0", VA = "0x186455EA0")]
	public PHLJIOCNMEC(KLKCBKEKDNM JEBGABLKILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6455A80", Offset = "0x6454680", VA = "0x186455A80")]
	public bool IOEINPGDFAK(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2663A50", Offset = "0x2662650", VA = "0x182663A50")]
	public bool JOMMLPANKBC<T>(KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, T GCPEEAODAIB) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2663640", Offset = "0x2662240", VA = "0x182663640")]
	public (bool, T?) ENNFBKDIIME<T>(KEGFKEPGJFM PBEFJNAEMNC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6455AF0", Offset = "0x64546F0", VA = "0x186455AF0")]
	public bool JOMMLPANKBC(KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, object GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x64559B0", Offset = "0x64545B0", VA = "0x1864559B0")]
	public (bool, object) ENNFBKDIIME(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2663A10", Offset = "0x2662610", VA = "0x182663A10")]
	private void GFBBGLINAFH<T>(KEGFKEPGJFM PBEFJNAEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6455DD0", Offset = "0x64549D0", VA = "0x186455DD0")]
	private ODJBADKIPKJ PHJIKJCHMFG(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6455BD0", Offset = "0x64547D0", VA = "0x186455BD0")]
	public void NEFNAOIEKCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class IGKIGJOLPLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string GABNJEJFCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type HKEIEJHOGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly ELIINLLJJHI BNGBLANCILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KEGFKEPGJFM PGILFKBAAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public DLDLBCHBEPN JKLNDMEODKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public OKHEECKAEKJ NOECCHMOLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NLHHPMNIJJD JPAHLPHMGID;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x644DA80", Offset = "0x644C680", VA = "0x18644DA80")]
	public IGKIGJOLPLD(Type CJHBGECKPGP, string ECILOFOHNLJ, KEGFKEPGJFM PBEFJNAEMNC, DLDLBCHBEPN JIPNGLFMEKD, OKHEECKAEKJ PLLPLAENHFP, NLHHPMNIJJD HIDIPCLDBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x644D980", Offset = "0x644C580", VA = "0x18644D980")]
	public object CFHEEHIMNFG(object? LLMHBOEDHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x252E5F0", Offset = "0x252D1F0", VA = "0x18252E5F0")]
	public void GFBBGLINAFH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x644D9D0", Offset = "0x644C5D0", VA = "0x18644D9D0")]
	public void GFBBGLINAFH(Type OCOCLGDDOLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CKFLLOMDPBE<T> : IGKIGJOLPLD where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string LLFEGLPFCBP(T GCPEEAODAIB);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T CEEKLDPGHEM(string? HGELIPMJOLA, T MLNCHKABKBO);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class IKNKLNKGNFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public LLFEGLPFCBP serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public CEEKLDPGHEM parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public IKNKLNKGNFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x373D6C0", Offset = "0x373C2C0", VA = "0x18373D6C0")]
		internal string JBJBGKEPCGL(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x373D620", Offset = "0x373C220", VA = "0x18373D620")]
		internal object DJHNABNBEJI(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4C56A30", Offset = "0x4C55630", VA = "0x184C56A30")]
	public CKFLLOMDPBE(KEGFKEPGJFM PBEFJNAEMNC, string ECILOFOHNLJ, [Optional] LLFEGLPFCBP? JIPNGLFMEKD, [Optional] CEEKLDPGHEM? PLLPLAENHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C55C60", Offset = "0x4C54860", VA = "0x184C55C60")]
	private static object? JFKFFNFOIMD(CEEKLDPGHEM? PLLPLAENHFP, string? HGELIPMJOLA, object? MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C56770", Offset = "0x4C55370", VA = "0x184C56770")]
	private static string OIIEHDKDHEB(LLFEGLPFCBP? ACHPFBNPMJE, object? GCPEEAODAIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string DLDLBCHBEPN(object? GCPEEAODAIB);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object OKHEECKAEKJ(string? HGELIPMJOLA, [Optional] object MLNCHKABKBO);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate ODJBADKIPKJ NLHHPMNIJJD();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KLKCBKEKDNM
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class JPHJAAHKHEI : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static JPHJAAHKHEI IDAIJJLMAFB;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x644DB20", Offset = "0x644C720", VA = "0x18644DB20", Slot = "4")]
		public bool Equals(List<string> HPIMCNPJDMN, List<string> BKLHNKCOAIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x644DC70", Offset = "0x644C870", VA = "0x18644DC70", Slot = "5")]
		public int GetHashCode(List<string> IIFJCGIHMIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public JPHJAAHKHEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HCMFOFCBGPF : COFOKCABMPJ<LHJMEMIFOMD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x644CFF0", Offset = "0x644BBF0", VA = "0x18644CFF0", Slot = "9")]
		public override string OIIEHDKDHEB(LHJMEMIFOMD MAIMNHFMIBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x644CE10", Offset = "0x644BA10", VA = "0x18644CE10", Slot = "10")]
		protected override bool KNCCOFHPGOA(string MAIMNHFMIBD, [Out] LHJMEMIFOMD GCPEEAODAIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x644D0E0", Offset = "0x644BCE0", VA = "0x18644D0E0")]
		public HCMFOFCBGPF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly GNOKMMCMGEG EEBLBONCAJE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly HCMFOFCBGPF PECEDHCJMPM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<IGKIGJOLPLD> BHJGEOLACBO;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KEGFKEPGJFM> LMEHJPOKCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KEGFKEPGJFM, IGKIGJOLPLD> AJAAFKDEEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x644ECD0", Offset = "0x644D8D0", VA = "0x18644ECD0")]
	public KLKCBKEKDNM([Optional] IList<IGKIGJOLPLD>? LPABLHGNMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x644DE60", Offset = "0x644CA60", VA = "0x18644DE60")]
	public IGKIGJOLPLD OHFFBBOHHNH(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface HNPIOHGGDAE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JJHDCNDHOBL CNPGFMBANFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KONBNDKMEEK : HNPIOHGGDAE
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KONBNDKMEEK HGIEKNJMMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly BCDBFDMEABJ LIADMCHJFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<BCDBFDMEABJ> CKFMALALMDC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public JJHDCNDHOBL CNPGFMBANFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x644FA50", Offset = "0x644E650", VA = "0x18644FA50")]
	public KONBNDKMEEK(BCDBFDMEABJ DMMBLDLKEGD, IReadOnlyList<BCDBFDMEABJ> BBIAIOOJBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x644F020", Offset = "0x644DC20", VA = "0x18644F020")]
	private static KONBNDKMEEK AEAGECBALKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LMNFBAPNHIG
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<HIAOFBFELNB> EABPHLFCJCH;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x644FB60", Offset = "0x644E760", VA = "0x18644FB60")]
	public static bool BAAIEMGPJLC(this ILLMBLKEFFI NBMIOHDEJJG, HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x644FC40", Offset = "0x644E840", VA = "0x18644FC40")]
	public static bool HACFMDMEADD(this ILLMBLKEFFI NBMIOHDEJJG, HIAOFBFELNB AOFAAIODEGH, AADJFGNPPBI OEMMLOOCOAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface PMKJAKGNFOI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool ANINHDMONFA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool AJBCDKCBLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JHMNEPNEMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LMLDBHHGLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool FMAKFJNIEIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LEHKNDLPMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool MIJKBMEDEBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool IOMKIMCIMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JCDJMDEKFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool PFAJPILGIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool FGIKKNNFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool KINIGODLIBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> GMIIIIIJJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LHJMEMIFOMD PBJHPLEADFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JJHDCNDHOBL : PMKJAKGNFOI, PGNLIGCMCFB, AAOCGEPOPKN<KEGFKEPGJFM>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string OKIGCOBCAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	HIAOFBFELNB OOBHAHOILPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) IHHANOOCPIF<T>(KEGFKEPGJFM PBEFJNAEMNC) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KEGFKEPGJFM
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	INVALID = -1,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	CAN_EDIT_ROOM_ROLES = 1,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	VOTE_KICK_PERMISSION = 3,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	CAN_INVITE = 4,
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	CAN_TALK = 6,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	CAN_PRINT_PHOTOS = 7,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	CAN_START_GAMES = 8,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	CAN_SELF_REVIVE = 9,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AUTO_ASSIGNED_GAME_ROLES = 11,
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	CAN_CHANGE_GAME_MODE = 12,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	CAN_USE_MAKER_PEN = 13,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	CAN_USE_DELETE_ALL_BUTTON = 14,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	CAN_SAVE_INVENTIONS = 15,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	DISABLE_MIC_AUTO_MUTE = 16,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	CAN_END_GAMES_EARLY = 17,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	CAN_USE_SHARE_CAM = 18,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	DEPRECATED_CAN_EDIT_CIRCUITS = 19,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	CAN_SPAWN_INVENTIONS = 20,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	CAN_SPAWN_CONSUMABLES = 21,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	CAN_USE_ROOM_RESET_BUTTON = 22,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	CAN_USE_PLAY_GIZMOS_TOGGLE = 23,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AUTO_ASSIGNED_PLAYER_TAGS = 24
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class BCDBFDMEABJ : JJHDCNDHOBL, PMKJAKGNFOI, PGNLIGCMCFB, AAOCGEPOPKN<KEGFKEPGJFM>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly KLKCBKEKDNM EKKDAJPCPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly PHLJIOCNMEC EFENKOOGKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? KMMIIEICNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? FEPMPFNCNJH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool HDHEOIEFKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x644ACB0", Offset = "0x64498B0", VA = "0x18644ACB0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LBDOMLGCMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x644A1D0", Offset = "0x6448DD0", VA = "0x18644A1D0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool NGOPFMJDMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x644A180", Offset = "0x6448D80", VA = "0x18644A180", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool MLKMIMNIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x644A010", Offset = "0x6448C10", VA = "0x18644A010", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool GIKPAOIEHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6449E90", Offset = "0x6448A90", VA = "0x186449E90", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool FFHFDCAKEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6449CF0", Offset = "0x64488F0", VA = "0x186449CF0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public HIAOFBFELNB OOBHAHOILPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F49A0", Offset = "0x7F35A0", VA = "0x1807F49A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(HIAOFBFELNB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x778130", Offset = "0x776D30", VA = "0x180778130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string JAAPMDHNBID
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x644B1A0", Offset = "0x6449DA0", VA = "0x18644B1A0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x644A220", Offset = "0x6448E20", VA = "0x18644A220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string OKIGCOBCAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x644B1A0", Offset = "0x6449DA0", VA = "0x18644B1A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LEKDDDJGHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x857140", Offset = "0x855D40", VA = "0x180857140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x856CD0", Offset = "0x8558D0", VA = "0x180856CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool ANINHDMONFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x644A130", Offset = "0x6448D30", VA = "0x18644A130", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LHJMEMIFOMD PBJHPLEADFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x644A6A0", Offset = "0x64492A0", VA = "0x18644A6A0", Slot = "20")]
		get
		{
			return default(LHJMEMIFOMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AJBCDKCBLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6449E40", Offset = "0x6448A40", VA = "0x186449E40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JHMNEPNEMON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x644AD00", Offset = "0x6449900", VA = "0x18644AD00", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LMLDBHHGLPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x644B150", Offset = "0x6449D50", VA = "0x18644B150", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool FMAKFJNIEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6449D40", Offset = "0x6448940", VA = "0x186449D40", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LEHKNDLPMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6449EE0", Offset = "0x6448AE0", VA = "0x186449EE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MIJKBMEDEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x644A060", Offset = "0x6448C60", VA = "0x18644A060", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IOMKIMCIMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x644A6F0", Offset = "0x64492F0", VA = "0x18644A6F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JCDJMDEKFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6449C50", Offset = "0x6448850", VA = "0x186449C50", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GMIIIIIJJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x644AD50", Offset = "0x6449950", VA = "0x18644AD50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool MEFEFDJJKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x644ACB0", Offset = "0x64498B0", VA = "0x18644ACB0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool FJAIFBMFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6449E90", Offset = "0x6448A90", VA = "0x186449E90", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BGCBOBINMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x644A1D0", Offset = "0x6448DD0", VA = "0x18644A1D0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PFAJPILGIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6449CA0", Offset = "0x64488A0", VA = "0x186449CA0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FGIKKNNFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x644A270", Offset = "0x6448E70", VA = "0x18644A270", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool AGMGMMNDNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x644A180", Offset = "0x6448D80", VA = "0x18644A180", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KINIGODLIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x644A2C0", Offset = "0x6448EC0", VA = "0x18644A2C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NKMHFBBKECH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x644A010", Offset = "0x6448C10", VA = "0x18644A010", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ADLAHDKJBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6449CF0", Offset = "0x64488F0", VA = "0x186449CF0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event ICMMIFAOJMO<KEGFKEPGJFM> DLJIAFKOHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6449D90", Offset = "0x6448990", VA = "0x186449D90", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x644A560", Offset = "0x6449160", VA = "0x18644A560", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x22B6200", Offset = "0x22B4E00", VA = "0x1822B6200", Slot = "6")]
	public (bool, T?) IHHANOOCPIF<T>(KEGFKEPGJFM PBEFJNAEMNC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x22B6390", Offset = "0x22B4F90", VA = "0x1822B6390")]
	public BCDBFDMEABJ ODMEBJLPGFF<T>(KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, T GCPEEAODAIB) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x644B280", Offset = "0x6449E80", VA = "0x18644B280")]
	public BCDBFDMEABJ(HIAOFBFELNB AOFAAIODEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x644B490", Offset = "0x644A090", VA = "0x18644B490")]
	public BCDBFDMEABJ(HIAOFBFELNB AOFAAIODEGH, [Optional] string? KMMIIEICNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x644B2A0", Offset = "0x6449EA0", VA = "0x18644B2A0")]
	public BCDBFDMEABJ(BCDBFDMEABJ BOKFBOMEOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x644B330", Offset = "0x6449F30", VA = "0x18644B330")]
	internal BCDBFDMEABJ(HIAOFBFELNB HPDLJIOLFOP, [Optional] string? KMMIIEICNJC, [Optional] BCDBFDMEABJ? BOKFBOMEOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x644A0B0", Offset = "0x6448CB0", VA = "0x18644A0B0")]
	public static ELIINLLJJHI GHAMICHNMKA(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return default(ELIINLLJJHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x644ADB0", Offset = "0x64499B0", VA = "0x18644ADB0")]
	public void NEFNAOIEKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x644ADD0", Offset = "0x64499D0", VA = "0x18644ADD0")]
	internal BCDBFDMEABJ OLPBAHOPMIP(BCDBFDMEABJ BCGDFGJKKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x644A840", Offset = "0x6449440", VA = "0x18644A840")]
	internal IReadOnlyCollection<KEGFKEPGJFM> KOCALHGOPKG(BCDBFDMEABJ BOKFBOMEOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6449F30", Offset = "0x6448B30", VA = "0x186449F30")]
	public bool FMPNMLJEEPA(KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, string EGEIOPOIFPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x644A740", Offset = "0x6449340", VA = "0x18644A740")]
	public (bool, string) KAOMOLONLCP(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x644A310", Offset = "0x6448F10", VA = "0x18644A310")]
	internal void IDHCJHNFDHF(KEGFKEPGJFM PBEFJNAEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x644A360", Offset = "0x6448F60", VA = "0x18644A360")]
	public LBBFHIIFFID IJHKLJFKENE(Func<HIAOFBFELNB, Guid> AAMBMKOGKLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x64492D0", Offset = "0x6447ED0", VA = "0x1864492D0")]
	public void AAGGGIMKCHN(LBBFHIIFFID AJECPHOKGCK, Func<Guid, HIAOFBFELNB> PKKEOBLLMMC, [Optional] HIAOFBFELNB? PNJEADDJFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x644A610", Offset = "0x6449210", VA = "0x18644A610")]
	[CompilerGenerated]
	private void JEAHCOPJMJB(KEGFKEPGJFM AMNMMCLFFDO, KJAFJGGEDKD IGAOCEDMNDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NODNKCKFKDI : IDBOHPIEIEL, PMMPPMBONAA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OILHJBMEMHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public BCDBFDMEABJ newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public OILHJBMEMHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6455980", Offset = "0x6454580", VA = "0x186455980")]
		internal bool NHNNDJMMAJC(BCDBFDMEABJ rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class ANBLADLEFKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public HIAOFBFELNB roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ANBLADLEFKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x64492C0", Offset = "0x6447EC0", VA = "0x1864492C0")]
		internal bool IKIJGCHKLBF(HIAOFBFELNB r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct BHHPAJMIKAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NODNKCKFKDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PGCGNLKABHG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<KLMLJLBJNNC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x644B4B0", Offset = "0x644A0B0", VA = "0x18644B4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x644BB10", Offset = "0x644A710", VA = "0x18644BB10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class ADAIELNKLPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public ADAIELNKLPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x64491E0", Offset = "0x6447DE0", VA = "0x1864491E0")]
		internal void GDCJBFAOCIF(LBBFHIIFFID r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x64490C0", Offset = "0x6447CC0", VA = "0x1864490C0")]
		internal void AAINAPLIOJA(LBBFHIIFFID r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KMJBPPPACBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public PGCGNLKABHG roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PNFDAJPKODN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<LBBFHIIFFID, KJAFJGGEDKD> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public PNFDAJPKODN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x64561B0", Offset = "0x6454DB0", VA = "0x1864561B0")]
		internal void FIKIPAOLNIO(LBBFHIIFFID r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6456210", Offset = "0x6454E10", VA = "0x186456210")]
		internal void ODOHANHKNPO(LBBFHIIFFID r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x64561E0", Offset = "0x6454DE0", VA = "0x1864561E0")]
		internal void LIHMGIJEDBP(LBBFHIIFFID r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JKCIHACADOD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public JKCIHACADOD<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private object <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private TaskAwaiter<KLMLJLBJNNC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2F742E0", Offset = "0x2F72EE0", VA = "0x182F742E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7EB0C0", Offset = "0x7E9CC0", VA = "0x1807EB0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NODNKCKFKDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KEGFKEPGJFM rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HIAOFBFELNB accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ELIINLLJJHI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public JKCIHACADOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x3915B40", Offset = "0x3914740", VA = "0x183915B40")]
		[AsyncStateMachine(typeof(JKCIHACADOD<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void LBNEKHDJFEK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct KADNJMJFKNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<PAIHPGJEJDJ> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct FBGKNEPPKDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public HMNNHDGBKNK rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PGCGNLKABHG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KDPJCMIPNDI debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x644C2A0", Offset = "0x644AEA0", VA = "0x18644C2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x644CDB0", Offset = "0x644B9B0", VA = "0x18644CDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly HMNNHDGBKNK ALNFIGKEDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly KONBNDKMEEK JKHBCLGCFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KDPJCMIPNDI HEFGEEHLBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, BCDBFDMEABJ> CINAPLOOPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<HIAOFBFELNB, BCDBFDMEABJ> EDEFDPAJOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<BCDBFDMEABJ> MPKLAKEADHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool BOBAPINNBKI;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly KEGFKEPGJFM[] ODGGPBAFMLK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HNPIOHGGDAE KAPFLHBIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<JJHDCNDHOBL> GMKLGMKOEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6452BE0", Offset = "0x64517E0", VA = "0x186452BE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DONNHOANPPH GNBPPIEDFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6452F50", Offset = "0x6451B50", VA = "0x186452F50", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6450EF0", Offset = "0x644FAF0", VA = "0x186450EF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6452FF0", Offset = "0x6451BF0", VA = "0x186452FF0")]
	[GFMBCOBENIN(MGPIABHDDAF.Room, CDPNEOMLNDL.None)]
	private static void JKFPJJDDAIM(OKOCNPPIKGG JGGJFGBKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6455640", Offset = "0x6454240", VA = "0x186455640")]
	[UnityEngine.Scripting.Preserve]
	internal NODNKCKFKDI([DLBAGNNJKKK(null)] HMNNHDGBKNK JHOILKKBABE, [DLBAGNNJKKK(null)] KONBNDKMEEK NJCFCPLHNLI, [DLBAGNNJKKK(null)] KDPJCMIPNDI HEFGEEHLBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6450F90", Offset = "0x644FB90", VA = "0x186450F90", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x644FEF0", Offset = "0x644EAF0", VA = "0x18644FEF0")]
	private void AOAJGAIDPCD(IEnumerable<BCDBFDMEABJ> MNIHBAOADPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6451CF0", Offset = "0x64508F0", VA = "0x186451CF0", Slot = "12")]
	public bool GBIBJMNGENM(ILLMBLKEFFI EJDJNJMKMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6452BD0", Offset = "0x64517D0", VA = "0x186452BD0")]
	private void GIBINAPLHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6454420", Offset = "0x6453020", VA = "0x186454420")]
	private void LGLIEFKEOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x644FE70", Offset = "0x644EA70", VA = "0x18644FE70", Slot = "10")]
	public IReadOnlyList<JJHDCNDHOBL> AJCOPOFBIBF(bool PKNKGBFAFGK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6452C30", Offset = "0x6451830", VA = "0x186452C30", Slot = "11")]
	public JJHDCNDHOBL HDJFFFKLIMN(ILLMBLKEFFI EJDJNJMKMJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6453C40", Offset = "0x6452840", VA = "0x186453C40")]
	private HIAOFBFELNB KEHIKMGELDE(ILLMBLKEFFI EJDJNJMKMJN)
	{
		return default(HIAOFBFELNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6454CF0", Offset = "0x64538F0", VA = "0x186454CF0", Slot = "14")]
	public bool OGMCHNFDPDI(ILLMBLKEFFI NJMFDKNBMPN, HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6454050", Offset = "0x6452C50", VA = "0x186454050", Slot = "15")]
	public JJHDCNDHOBL KMDMIBKCEFO(HIAOFBFELNB AOFAAIODEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x64540F0", Offset = "0x6452CF0", VA = "0x1864540F0")]
	private static bool LDEPECOCEHG(NMNMGAMHPLO FMNIMDICFCD, HIAOFBFELNB AOFAAIODEGH, [Out] LBBFHIIFFID? NOHFOAGBOEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6451830", Offset = "0x6450430", VA = "0x186451830")]
	private static void FOKGAOOMLHF(NMNMGAMHPLO FMNIMDICFCD, Action<LBBFHIIFFID> AKNIDDCMEIH, HIAOFBFELNB NGKALMPFEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6451920", Offset = "0x6450520", VA = "0x186451920")]
	private static void FOKGAOOMLHF(NMNMGAMHPLO FMNIMDICFCD, Action<LBBFHIIFFID> AKNIDDCMEIH, Predicate<HIAOFBFELNB> CJGMNKJJAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6454610", Offset = "0x6453210", VA = "0x186454610")]
	private void LJHABFLPDCK(ILLMBLKEFFI EJDJNJMKMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6450A90", Offset = "0x644F690", VA = "0x186450A90", Slot = "4")]
	[AsyncStateMachine(typeof(BHHPAJMIKAI))]
	public Task CPIENBNACAN([CanBeNull] PGCGNLKABHG EMCADPHEHCL, CancellationToken BJFJMBIBKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "5")]
	public void LNOIDPFLGPG(PGCGNLKABHG EMCADPHEHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6453D10", Offset = "0x6452910", VA = "0x186453D10")]
	private void KIMBGDECMEK(NMNMGAMHPLO KKOABBMJKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x64549F0", Offset = "0x64535F0", VA = "0x1864549F0")]
	internal static string NNEBGDMBNLP(HMNNHDGBKNK ALNFIGKEDDK, PGCGNLKABHG EMCADPHEHCL, IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6451DC0", Offset = "0x64509C0", VA = "0x186451DC0")]
	private static void GHKGDKDPHJC(PGCGNLKABHG EMCADPHEHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x64538F0", Offset = "0x64524F0", VA = "0x1864538F0")]
	private static void JNBDMDKNEKL(NMNMGAMHPLO BFBLJDFCPOD, IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM, StringBuilder JDANJBNDPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6450BB0", Offset = "0x644F7B0", VA = "0x186450BB0")]
	private static bool DNEFKIBLPAH(string ELKLOMIBJLP, [Out] Guid DNJMJODGCDN, [Out] HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x64531B0", Offset = "0x6451DB0", VA = "0x1864531B0")]
	private static void JMNBDECBLCJ(PGCGNLKABHG EMCADPHEHCL, StringBuilder JDANJBNDPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x262BD30", Offset = "0x262A930", VA = "0x18262BD30", Slot = "16")]
	public bool PMBGLFKGCKC<T>(HIAOFBFELNB AOFAAIODEGH, KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, T NGMDGDAKJOP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6452D40", Offset = "0x6451940", VA = "0x186452D40")]
	private void ICBKJBFCLOA(HIAOFBFELNB AOFAAIODEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6450A70", Offset = "0x644F670", VA = "0x186450A70")]
	private bool CHBHLECPEBL(ILLMBLKEFFI EJDJNJMKMJN, HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6455120", Offset = "0x6453D20", VA = "0x186455120")]
	internal BCDBFDMEABJ OLJNKAMBMHC(ILLMBLKEFFI EJDJNJMKMJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6450A60", Offset = "0x644F660", VA = "0x186450A60", Slot = "13")]
	public IReadOnlyList<JJHDCNDHOBL> CDCKBCPBLBA(ILLMBLKEFFI EJDJNJMKMJN, bool DLJBAMEFKNH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6450CC0", Offset = "0x644F8C0", VA = "0x186450CC0")]
	internal IReadOnlyList<BCDBFDMEABJ> DOKJFNKAGNK(ILLMBLKEFFI EJDJNJMKMJN, bool DLJBAMEFKNH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x64510A0", Offset = "0x644FCA0", VA = "0x1864510A0")]
	private void EPHNKKKIPKP(KLMLJLBJNNC KKCDBNDELKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6450770", Offset = "0x644F370", VA = "0x186450770")]
	private static bool BLNJIIPNKIE(BCDBFDMEABJ NKOJBCEJAON, IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM, [Out] IReadOnlyList<KEGFKEPGJFM> OBDBBCHIEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6451BB0", Offset = "0x64507B0", VA = "0x186451BB0")]
	[AsyncStateMachine(typeof(FBGKNEPPKDA))]
	private static Task FOOBCAKLNDB(HMNNHDGBKNK ALNFIGKEDDK, PGCGNLKABHG EMCADPHEHCL, IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM, KDPJCMIPNDI HEFGEEHLBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6454E80", Offset = "0x6453A80", VA = "0x186454E80")]
	[CompilerGenerated]
	internal static void OLGHMOKMCJC(Func<LBBFHIIFFID, KJAFJGGEDKD> HDLBJBHCDNF, KMJBPPPACBM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6454680", Offset = "0x6453280", VA = "0x186454680")]
	[CompilerGenerated]
	internal static bool NGOAFBKHAHC(HIAOFBFELNB AOFAAIODEGH, KEGFKEPGJFM PBEFJNAEMNC, [Out] PAIHPGJEJDJ EAHEHJFIKBF, KADNJMJFKNM P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface AGHAPBNCFBN
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGGFPAGBHGL(ILLMBLKEFFI NBICGKFNPFB, ILLMBLKEFFI PDDGECLMLNF, IEnumerable<ILLMBLKEFFI> MPKCIBAOJKI, [Out] LHJMEMIFOMD BDFMMBIJODC, [Out] MAICDKECHDN NDMGJJEFOFA);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string EDJEMEJBNOL(MAICDKECHDN PDFEOCGAJPP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum MAICDKECHDN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class HIMHLBCPILH : AGHAPBNCFBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly PMMPPMBONAA ONMOHIIIBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly GMNDFNEENOM MANCHHPHGLP;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
	[RecRoom.NoEngine.Common.Preserve]
	public HIMHLBCPILH([DLBAGNNJKKK(null)] PMMPPMBONAA BODKLPDNDBN, [DLBAGNNJKKK(null)] GMNDFNEENOM DIJOJLEKAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x644D840", Offset = "0x644C440", VA = "0x18644D840")]
	private static JIMFPMJCDDJ? HIGILIEBKGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x644D880", Offset = "0x644C480", VA = "0x18644D880", Slot = "4")]
	public bool MGGFPAGBHGL(ILLMBLKEFFI NBICGKFNPFB, ILLMBLKEFFI PDDGECLMLNF, IEnumerable<ILLMBLKEFFI> MPKCIBAOJKI, [Out] LHJMEMIFOMD BDFMMBIJODC, [Out] MAICDKECHDN NDMGJJEFOFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x644D740", Offset = "0x644C340", VA = "0x18644D740", Slot = "5")]
	public string EDJEMEJBNOL(MAICDKECHDN PDFEOCGAJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x644D120", Offset = "0x644BD20", VA = "0x18644D120")]
	internal bool DJPOCDIIEEA(ILLMBLKEFFI NBICGKFNPFB, ILLMBLKEFFI PDDGECLMLNF, IEnumerable<ILLMBLKEFFI> MPKCIBAOJKI, AADJFGNPPBI OEMMLOOCOAN, JIMFPMJCDDJ? LHNHAFOCJAG, [Out] LHJMEMIFOMD BDFMMBIJODC, [Out] MAICDKECHDN NDMGJJEFOFA)
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
