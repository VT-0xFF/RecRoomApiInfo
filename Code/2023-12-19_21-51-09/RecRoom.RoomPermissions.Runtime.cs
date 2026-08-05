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
		[Cpp2IlInjected.Address(RVA = "0x6455870", Offset = "0x6454470", VA = "0x186455870")]
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
		[Cpp2IlInjected.Address(RVA = "0x644BDE0", Offset = "0x644A9E0", VA = "0x18644BDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x644BE60", Offset = "0x644AA60", VA = "0x18644BE60")]
	public static HIAOFBFELNB LKELMOMDNKL(Guid OGCEPACDHOE)
	{
		return default(HIAOFBFELNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x644BB70", Offset = "0x644A770", VA = "0x18644BB70")]
	public static Guid DHCBMAGNEJD(HIAOFBFELNB AOFAAIODEGH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x644BAE0", Offset = "0x644A6E0", VA = "0x18644BAE0")]
	public static bool DACNMGMEACA(HIAOFBFELNB AOFAAIODEGH, [Out] Guid OGCEPACDHOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x644BC50", Offset = "0x644A850", VA = "0x18644BC50")]
	public static bool FIGCMEABIEN(Guid OGCEPACDHOE, [Out] HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x644BCF0", Offset = "0x644A8F0", VA = "0x18644BCF0")]
	public static HIAOFBFELNB HCHCPFLOKAN(HIAOFBFELNB AOFAAIODEGH)
	{
		return default(HIAOFBFELNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x644BD30", Offset = "0x644A930", VA = "0x18644BD30")]
	public static KMBAPGBMKCG KBAEEDBBGKD(HIAOFBFELNB EGDLOBHLLHN)
	{
		return default(KMBAPGBMKCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x644BC10", Offset = "0x644A810", VA = "0x18644BC10")]
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
	[Cpp2IlInjected.Address(RVA = "0x64560C0", Offset = "0x6454CC0", VA = "0x1864560C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x317BA00", Offset = "0x317A600", VA = "0x18317BA00", Slot = "4")]
	public override bool JFHEACCMIOJ(object? GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x317B4E0", Offset = "0x317A0E0", VA = "0x18317B4E0")]
	public bool COINMLNCJOG(T BNBBGDMBANN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x317BCD0", Offset = "0x317A8D0", VA = "0x18317BCD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6455E10", Offset = "0x6454A10", VA = "0x186455E10")]
	public PHLJIOCNMEC(KLKCBKEKDNM JEBGABLKILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x64559F0", Offset = "0x64545F0", VA = "0x1864559F0")]
	public bool IOEINPGDFAK(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x26639C0", Offset = "0x26625C0", VA = "0x1826639C0")]
	public bool JOMMLPANKBC<T>(KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, T GCPEEAODAIB) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26635B0", Offset = "0x26621B0", VA = "0x1826635B0")]
	public (bool, T?) ENNFBKDIIME<T>(KEGFKEPGJFM PBEFJNAEMNC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6455A60", Offset = "0x6454660", VA = "0x186455A60")]
	public bool JOMMLPANKBC(KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, object GCPEEAODAIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6455920", Offset = "0x6454520", VA = "0x186455920")]
	public (bool, object) ENNFBKDIIME(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2663980", Offset = "0x2662580", VA = "0x182663980")]
	private void GFBBGLINAFH<T>(KEGFKEPGJFM PBEFJNAEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6455D40", Offset = "0x6454940", VA = "0x186455D40")]
	private ODJBADKIPKJ PHJIKJCHMFG(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6455B40", Offset = "0x6454740", VA = "0x186455B40")]
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
	[Cpp2IlInjected.Address(RVA = "0x644D9F0", Offset = "0x644C5F0", VA = "0x18644D9F0")]
	public IGKIGJOLPLD(Type CJHBGECKPGP, string ECILOFOHNLJ, KEGFKEPGJFM PBEFJNAEMNC, DLDLBCHBEPN JIPNGLFMEKD, OKHEECKAEKJ PLLPLAENHFP, NLHHPMNIJJD HIDIPCLDBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x644D8F0", Offset = "0x644C4F0", VA = "0x18644D8F0")]
	public object CFHEEHIMNFG(object? LLMHBOEDHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x252E560", Offset = "0x252D160", VA = "0x18252E560")]
	public void GFBBGLINAFH<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x644D940", Offset = "0x644C540", VA = "0x18644D940")]
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
		[Cpp2IlInjected.Address(RVA = "0x373D630", Offset = "0x373C230", VA = "0x18373D630")]
		internal string JBJBGKEPCGL(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x373D590", Offset = "0x373C190", VA = "0x18373D590")]
		internal object DJHNABNBEJI(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4C569A0", Offset = "0x4C555A0", VA = "0x184C569A0")]
	public CKFLLOMDPBE(KEGFKEPGJFM PBEFJNAEMNC, string ECILOFOHNLJ, [Optional] LLFEGLPFCBP? JIPNGLFMEKD, [Optional] CEEKLDPGHEM? PLLPLAENHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4C55BD0", Offset = "0x4C547D0", VA = "0x184C55BD0")]
	private static object? JFKFFNFOIMD(CEEKLDPGHEM? PLLPLAENHFP, string? HGELIPMJOLA, object? MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C566E0", Offset = "0x4C552E0", VA = "0x184C566E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x644DA90", Offset = "0x644C690", VA = "0x18644DA90", Slot = "4")]
		public bool Equals(List<string> HPIMCNPJDMN, List<string> BKLHNKCOAIA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x644DBE0", Offset = "0x644C7E0", VA = "0x18644DBE0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x644CF60", Offset = "0x644BB60", VA = "0x18644CF60", Slot = "9")]
		public override string OIIEHDKDHEB(LHJMEMIFOMD MAIMNHFMIBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x644CD80", Offset = "0x644B980", VA = "0x18644CD80", Slot = "10")]
		protected override bool KNCCOFHPGOA(string MAIMNHFMIBD, [Out] LHJMEMIFOMD GCPEEAODAIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x644D050", Offset = "0x644BC50", VA = "0x18644D050")]
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
	[Cpp2IlInjected.Address(RVA = "0x644EC40", Offset = "0x644D840", VA = "0x18644EC40")]
	public KLKCBKEKDNM([Optional] IList<IGKIGJOLPLD>? LPABLHGNMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x644DDD0", Offset = "0x644C9D0", VA = "0x18644DDD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x644F9C0", Offset = "0x644E5C0", VA = "0x18644F9C0")]
	public KONBNDKMEEK(BCDBFDMEABJ DMMBLDLKEGD, IReadOnlyList<BCDBFDMEABJ> BBIAIOOJBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x644EF90", Offset = "0x644DB90", VA = "0x18644EF90")]
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
	[Cpp2IlInjected.Address(RVA = "0x644FAD0", Offset = "0x644E6D0", VA = "0x18644FAD0")]
	public static bool BAAIEMGPJLC(this ILLMBLKEFFI NBMIOHDEJJG, HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x644FBB0", Offset = "0x644E7B0", VA = "0x18644FBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x644AC20", Offset = "0x6449820", VA = "0x18644AC20", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LBDOMLGCMBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x644A140", Offset = "0x6448D40", VA = "0x18644A140", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool NGOPFMJDMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x644A0F0", Offset = "0x6448CF0", VA = "0x18644A0F0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool MLKMIMNIDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6449F80", Offset = "0x6448B80", VA = "0x186449F80", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool GIKPAOIEHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6449E00", Offset = "0x6448A00", VA = "0x186449E00", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool FFHFDCAKEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6449C60", Offset = "0x6448860", VA = "0x186449C60", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0x644B110", Offset = "0x6449D10", VA = "0x18644B110", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x644A190", Offset = "0x6448D90", VA = "0x18644A190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string OKIGCOBCAIM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x644B110", Offset = "0x6449D10", VA = "0x18644B110", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x644A0A0", Offset = "0x6448CA0", VA = "0x18644A0A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LHJMEMIFOMD PBJHPLEADFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x644A610", Offset = "0x6449210", VA = "0x18644A610", Slot = "20")]
		get
		{
			return default(LHJMEMIFOMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool AJBCDKCBLNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6449DB0", Offset = "0x64489B0", VA = "0x186449DB0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JHMNEPNEMON
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x644AC70", Offset = "0x6449870", VA = "0x18644AC70", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool LMLDBHHGLPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x644B0C0", Offset = "0x6449CC0", VA = "0x18644B0C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool FMAKFJNIEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6449CB0", Offset = "0x64488B0", VA = "0x186449CB0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LEHKNDLPMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6449E50", Offset = "0x6448A50", VA = "0x186449E50", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool MIJKBMEDEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6449FD0", Offset = "0x6448BD0", VA = "0x186449FD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IOMKIMCIMHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x644A660", Offset = "0x6449260", VA = "0x18644A660", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JCDJMDEKFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6449BC0", Offset = "0x64487C0", VA = "0x186449BC0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> GMIIIIIJJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x644ACC0", Offset = "0x64498C0", VA = "0x18644ACC0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool MEFEFDJJKCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x644AC20", Offset = "0x6449820", VA = "0x18644AC20", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool FJAIFBMFOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6449E00", Offset = "0x6448A00", VA = "0x186449E00", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool BGCBOBINMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x644A140", Offset = "0x6448D40", VA = "0x18644A140", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool PFAJPILGIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6449C10", Offset = "0x6448810", VA = "0x186449C10", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FGIKKNNFNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x644A1E0", Offset = "0x6448DE0", VA = "0x18644A1E0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool AGMGMMNDNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x644A0F0", Offset = "0x6448CF0", VA = "0x18644A0F0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KINIGODLIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x644A230", Offset = "0x6448E30", VA = "0x18644A230", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NKMHFBBKECH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6449F80", Offset = "0x6448B80", VA = "0x186449F80", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool ADLAHDKJBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6449C60", Offset = "0x6448860", VA = "0x186449C60", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event ICMMIFAOJMO<KEGFKEPGJFM> DLJIAFKOHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6449D00", Offset = "0x6448900", VA = "0x186449D00", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x644A4D0", Offset = "0x64490D0", VA = "0x18644A4D0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x22B6170", Offset = "0x22B4D70", VA = "0x1822B6170", Slot = "6")]
	public (bool, T?) IHHANOOCPIF<T>(KEGFKEPGJFM PBEFJNAEMNC) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x22B6300", Offset = "0x22B4F00", VA = "0x1822B6300")]
	public BCDBFDMEABJ ODMEBJLPGFF<T>(KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, T GCPEEAODAIB) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x644B1F0", Offset = "0x6449DF0", VA = "0x18644B1F0")]
	public BCDBFDMEABJ(HIAOFBFELNB AOFAAIODEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x644B400", Offset = "0x644A000", VA = "0x18644B400")]
	public BCDBFDMEABJ(HIAOFBFELNB AOFAAIODEGH, [Optional] string? KMMIIEICNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x644B210", Offset = "0x6449E10", VA = "0x18644B210")]
	public BCDBFDMEABJ(BCDBFDMEABJ BOKFBOMEOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x644B2A0", Offset = "0x6449EA0", VA = "0x18644B2A0")]
	internal BCDBFDMEABJ(HIAOFBFELNB HPDLJIOLFOP, [Optional] string? KMMIIEICNJC, [Optional] BCDBFDMEABJ? BOKFBOMEOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x644A020", Offset = "0x6448C20", VA = "0x18644A020")]
	public static ELIINLLJJHI GHAMICHNMKA(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return default(ELIINLLJJHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x644AD20", Offset = "0x6449920", VA = "0x18644AD20")]
	public void NEFNAOIEKCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x644AD40", Offset = "0x6449940", VA = "0x18644AD40")]
	internal BCDBFDMEABJ OLPBAHOPMIP(BCDBFDMEABJ BCGDFGJKKMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x644A7B0", Offset = "0x64493B0", VA = "0x18644A7B0")]
	internal IReadOnlyCollection<KEGFKEPGJFM> KOCALHGOPKG(BCDBFDMEABJ BOKFBOMEOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6449EA0", Offset = "0x6448AA0", VA = "0x186449EA0")]
	public bool FMPNMLJEEPA(KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, string EGEIOPOIFPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x644A6B0", Offset = "0x64492B0", VA = "0x18644A6B0")]
	public (bool, string) KAOMOLONLCP(KEGFKEPGJFM PBEFJNAEMNC)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x644A280", Offset = "0x6448E80", VA = "0x18644A280")]
	internal void IDHCJHNFDHF(KEGFKEPGJFM PBEFJNAEMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x644A2D0", Offset = "0x6448ED0", VA = "0x18644A2D0")]
	public LBBFHIIFFID IJHKLJFKENE(Func<HIAOFBFELNB, Guid> AAMBMKOGKLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6449240", Offset = "0x6447E40", VA = "0x186449240")]
	public void AAGGGIMKCHN(LBBFHIIFFID AJECPHOKGCK, Func<Guid, HIAOFBFELNB> PKKEOBLLMMC, [Optional] HIAOFBFELNB? PNJEADDJFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x644A580", Offset = "0x6449180", VA = "0x18644A580")]
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
		[Cpp2IlInjected.Address(RVA = "0x64558F0", Offset = "0x64544F0", VA = "0x1864558F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6449230", Offset = "0x6447E30", VA = "0x186449230")]
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
		[Cpp2IlInjected.Address(RVA = "0x644B420", Offset = "0x644A020", VA = "0x18644B420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x644BA80", Offset = "0x644A680", VA = "0x18644BA80", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6449150", Offset = "0x6447D50", VA = "0x186449150")]
		internal void GDCJBFAOCIF(LBBFHIIFFID r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6449030", Offset = "0x6447C30", VA = "0x186449030")]
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
		[Cpp2IlInjected.Address(RVA = "0x6456120", Offset = "0x6454D20", VA = "0x186456120")]
		internal void FIKIPAOLNIO(LBBFHIIFFID r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6456180", Offset = "0x6454D80", VA = "0x186456180")]
		internal void ODOHANHKNPO(LBBFHIIFFID r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6456150", Offset = "0x6454D50", VA = "0x186456150")]
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
			[Cpp2IlInjected.Address(RVA = "0x2F74250", Offset = "0x2F72E50", VA = "0x182F74250", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3915AB0", Offset = "0x39146B0", VA = "0x183915AB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x644C210", Offset = "0x644AE10", VA = "0x18644C210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x644CD20", Offset = "0x644B920", VA = "0x18644CD20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6452B50", Offset = "0x6451750", VA = "0x186452B50", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event DONNHOANPPH GNBPPIEDFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6452EC0", Offset = "0x6451AC0", VA = "0x186452EC0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6450E60", Offset = "0x644FA60", VA = "0x186450E60", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6452F60", Offset = "0x6451B60", VA = "0x186452F60")]
	[GFMBCOBENIN(MGPIABHDDAF.Room, CDPNEOMLNDL.None)]
	private static void JKFPJJDDAIM(OKOCNPPIKGG JGGJFGBKEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x64555B0", Offset = "0x64541B0", VA = "0x1864555B0")]
	[UnityEngine.Scripting.Preserve]
	internal NODNKCKFKDI([DLBAGNNJKKK(null)] HMNNHDGBKNK JHOILKKBABE, [DLBAGNNJKKK(null)] KONBNDKMEEK NJCFCPLHNLI, [DLBAGNNJKKK(null)] KDPJCMIPNDI HEFGEEHLBPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6450F00", Offset = "0x644FB00", VA = "0x186450F00", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x644FE60", Offset = "0x644EA60", VA = "0x18644FE60")]
	private void AOAJGAIDPCD(IEnumerable<BCDBFDMEABJ> MNIHBAOADPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6451C60", Offset = "0x6450860", VA = "0x186451C60", Slot = "12")]
	public bool GBIBJMNGENM(ILLMBLKEFFI EJDJNJMKMJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6452B40", Offset = "0x6451740", VA = "0x186452B40")]
	private void GIBINAPLHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6454390", Offset = "0x6452F90", VA = "0x186454390")]
	private void LGLIEFKEOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x644FDE0", Offset = "0x644E9E0", VA = "0x18644FDE0", Slot = "10")]
	public IReadOnlyList<JJHDCNDHOBL> AJCOPOFBIBF(bool PKNKGBFAFGK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6452BA0", Offset = "0x64517A0", VA = "0x186452BA0", Slot = "11")]
	public JJHDCNDHOBL HDJFFFKLIMN(ILLMBLKEFFI EJDJNJMKMJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6453BB0", Offset = "0x64527B0", VA = "0x186453BB0")]
	private HIAOFBFELNB KEHIKMGELDE(ILLMBLKEFFI EJDJNJMKMJN)
	{
		return default(HIAOFBFELNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6454C60", Offset = "0x6453860", VA = "0x186454C60", Slot = "14")]
	public bool OGMCHNFDPDI(ILLMBLKEFFI NJMFDKNBMPN, HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6453FC0", Offset = "0x6452BC0", VA = "0x186453FC0", Slot = "15")]
	public JJHDCNDHOBL KMDMIBKCEFO(HIAOFBFELNB AOFAAIODEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6454060", Offset = "0x6452C60", VA = "0x186454060")]
	private static bool LDEPECOCEHG(NMNMGAMHPLO FMNIMDICFCD, HIAOFBFELNB AOFAAIODEGH, [Out] LBBFHIIFFID? NOHFOAGBOEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x64517A0", Offset = "0x64503A0", VA = "0x1864517A0")]
	private static void FOKGAOOMLHF(NMNMGAMHPLO FMNIMDICFCD, Action<LBBFHIIFFID> AKNIDDCMEIH, HIAOFBFELNB NGKALMPFEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6451890", Offset = "0x6450490", VA = "0x186451890")]
	private static void FOKGAOOMLHF(NMNMGAMHPLO FMNIMDICFCD, Action<LBBFHIIFFID> AKNIDDCMEIH, Predicate<HIAOFBFELNB> CJGMNKJJAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6454580", Offset = "0x6453180", VA = "0x186454580")]
	private void LJHABFLPDCK(ILLMBLKEFFI EJDJNJMKMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6450A00", Offset = "0x644F600", VA = "0x186450A00", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6453C80", Offset = "0x6452880", VA = "0x186453C80")]
	private void KIMBGDECMEK(NMNMGAMHPLO KKOABBMJKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6454960", Offset = "0x6453560", VA = "0x186454960")]
	internal static string NNEBGDMBNLP(HMNNHDGBKNK ALNFIGKEDDK, PGCGNLKABHG EMCADPHEHCL, IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6451D30", Offset = "0x6450930", VA = "0x186451D30")]
	private static void GHKGDKDPHJC(PGCGNLKABHG EMCADPHEHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6453860", Offset = "0x6452460", VA = "0x186453860")]
	private static void JNBDMDKNEKL(NMNMGAMHPLO BFBLJDFCPOD, IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM, StringBuilder JDANJBNDPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6450B20", Offset = "0x644F720", VA = "0x186450B20")]
	private static bool DNEFKIBLPAH(string ELKLOMIBJLP, [Out] Guid DNJMJODGCDN, [Out] HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6453120", Offset = "0x6451D20", VA = "0x186453120")]
	private static void JMNBDECBLCJ(PGCGNLKABHG EMCADPHEHCL, StringBuilder JDANJBNDPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x262BCA0", Offset = "0x262A8A0", VA = "0x18262BCA0", Slot = "16")]
	public bool PMBGLFKGCKC<T>(HIAOFBFELNB AOFAAIODEGH, KEGFKEPGJFM PBEFJNAEMNC, bool NDOKIAIEHHC, T NGMDGDAKJOP) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6452CB0", Offset = "0x64518B0", VA = "0x186452CB0")]
	private void ICBKJBFCLOA(HIAOFBFELNB AOFAAIODEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x64509E0", Offset = "0x644F5E0", VA = "0x1864509E0")]
	private bool CHBHLECPEBL(ILLMBLKEFFI EJDJNJMKMJN, HIAOFBFELNB AOFAAIODEGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6455090", Offset = "0x6453C90", VA = "0x186455090")]
	internal BCDBFDMEABJ OLJNKAMBMHC(ILLMBLKEFFI EJDJNJMKMJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x64509D0", Offset = "0x644F5D0", VA = "0x1864509D0", Slot = "13")]
	public IReadOnlyList<JJHDCNDHOBL> CDCKBCPBLBA(ILLMBLKEFFI EJDJNJMKMJN, bool DLJBAMEFKNH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6450C30", Offset = "0x644F830", VA = "0x186450C30")]
	internal IReadOnlyList<BCDBFDMEABJ> DOKJFNKAGNK(ILLMBLKEFFI EJDJNJMKMJN, bool DLJBAMEFKNH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6451010", Offset = "0x644FC10", VA = "0x186451010")]
	private void EPHNKKKIPKP(KLMLJLBJNNC KKCDBNDELKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x64506E0", Offset = "0x644F2E0", VA = "0x1864506E0")]
	private static bool BLNJIIPNKIE(BCDBFDMEABJ NKOJBCEJAON, IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM, [Out] IReadOnlyList<KEGFKEPGJFM> OBDBBCHIEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6451B20", Offset = "0x6450720", VA = "0x186451B20")]
	[AsyncStateMachine(typeof(FBGKNEPPKDA))]
	private static Task FOOBCAKLNDB(HMNNHDGBKNK ALNFIGKEDDK, PGCGNLKABHG EMCADPHEHCL, IReadOnlyDictionary<HIAOFBFELNB, BCDBFDMEABJ> JHDCAAKHGCM, KDPJCMIPNDI HEFGEEHLBPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6454DF0", Offset = "0x64539F0", VA = "0x186454DF0")]
	[CompilerGenerated]
	internal static void OLGHMOKMCJC(Func<LBBFHIIFFID, KJAFJGGEDKD> HDLBJBHCDNF, KMJBPPPACBM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x64545F0", Offset = "0x64531F0", VA = "0x1864545F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x644D7B0", Offset = "0x644C3B0", VA = "0x18644D7B0")]
	private static JIMFPMJCDDJ? HIGILIEBKGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x644D7F0", Offset = "0x644C3F0", VA = "0x18644D7F0", Slot = "4")]
	public bool MGGFPAGBHGL(ILLMBLKEFFI NBICGKFNPFB, ILLMBLKEFFI PDDGECLMLNF, IEnumerable<ILLMBLKEFFI> MPKCIBAOJKI, [Out] LHJMEMIFOMD BDFMMBIJODC, [Out] MAICDKECHDN NDMGJJEFOFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x644D6B0", Offset = "0x644C2B0", VA = "0x18644D6B0", Slot = "5")]
	public string EDJEMEJBNOL(MAICDKECHDN PDFEOCGAJPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x644D090", Offset = "0x644BC90", VA = "0x18644D090")]
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
