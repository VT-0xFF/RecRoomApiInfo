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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6D70", Offset = "0x5FF5F70", VA = "0x185FF6D70")]
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
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
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
public enum OOPNCLJNMFK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum COIGKPHEGBK
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void MDHJCOEBDEN<TPermission>(TPermission HEGLKMIJHAM);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IENMFGLAGBK(JDCIJIEOFOL EKOFNPFCLMO);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GOMIGOHHACK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NIEBHFGLGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool GLLAPDCJDAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LCJHJDDHJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IBNCKMIGEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KDLGKCDIAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HCBOMENMHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CGOPOAFDIDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CKEMGHEJHPH AOKLLKFNHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IEnumerable<PJCMOOCCFCF> ALIMJOBNFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event IENMFGLAGBK AFJCAMKMKEN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<PJCMOOCCFCF> PLEJNOFAJOC(bool NCNJBBIMFKI = false);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PJCMOOCCFCF FJPGBGEHPAN(JDCIJIEOFOL EKOFNPFCLMO);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LBFEEPOJKOP(JDCIJIEOFOL EKOFNPFCLMO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<PJCMOOCCFCF> IEDDIIDOMBJ(JDCIJIEOFOL EKOFNPFCLMO, bool HLCLEBMPNME = false);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JPJELKNDGAO(JDCIJIEOFOL HAFLMJCDPPI, KPNOJENBPDL CCKHOOHAFFD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PJCMOOCCFCF FHMIPLOGADI(KPNOJENBPDL CCKHOOHAFFD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AJGMFNLMNAP<T>(KPNOJENBPDL CCKHOOHAFFD, IADIMLJDNFP HEGLKMIJHAM, bool FMMJFLMIBAO, T NKBIKBGEKGL) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JAECBOHHODF
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HHLDNOMKLBJ(KHMOHFAFGBI KGMPBFBAMCF, CancellationToken NDKAKDJMDIF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOODPBHPDHM(ref KHMOHFAFGBI KGMPBFBAMCF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PEIMNKFLDCP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	JDCIJIEOFOL BGLAOMPNJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EGGMEJDMHKF DOGAJFPKGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LCEKCFEIEGJ MKMJNBMBMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DJCKFAAOIFO> JFFHMGHDEEK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NJMCOMBNPLN;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KPNOJENBPDL ENDJCOKPDLL(JDCIJIEOFOL EKOFNPFCLMO);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DJCKFAAOIFO> MGKEANMLPBG(CancellationToken NDKAKDJMDIF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MIBIGONMCML(long EPOBIFCHLNM, long FJGKDBAFAGH, IReadOnlyList<BKNBLINKIDO> HNLBNBICHFD);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<JDCIJIEOFOL> MKHOGDJLGLP();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class ADOKBOFPADD
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB050", Offset = "0x5FEA250", VA = "0x185FEB050")]
	public static KPNOJENBPDL KHIBLMPJOGO(this PEIMNKFLDCP PFLAHGGDGIM)
	{
		return default(KPNOJENBPDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NALCDCIGNGH<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string JIINFFODCJO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event global::MDHJCOEBDEN<TPermission> KHAIHIGFJHC;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class HHHGMABEMCB
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[Flags]
	public enum JCGIPAGGCGM
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
	public static readonly Guid NJFNDNFIHMP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid BOJDDCIGGGK;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid OCDJLDCAMJN;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid KAEAPJGIDFD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid LNIDBDDGHEF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly global::NNHJCDEPLCG<KPNOJENBPDL, Guid> EFEIAKENMLD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IEnumerable<KPNOJENBPDL> IADDMMELBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2570", Offset = "0x5FF1770", VA = "0x185FF2570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FF25F0", Offset = "0x5FF17F0", VA = "0x185FF25F0")]
	public static KPNOJENBPDL OMBFEECCPNO(Guid JMIFIJDBMNM)
	{
		return default(KPNOJENBPDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2420", Offset = "0x5FF1620", VA = "0x185FF2420")]
	public static Guid FLJCGKGJNGF(KPNOJENBPDL CCKHOOHAFFD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FF24D0", Offset = "0x5FF16D0", VA = "0x185FF24D0")]
	public static bool HPHHNACOCAC(KPNOJENBPDL CCKHOOHAFFD, out Guid JMIFIJDBMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2290", Offset = "0x5FF1490", VA = "0x185FF2290")]
	public static bool AAOKIFEDBJB(Guid JMIFIJDBMNM, out KPNOJENBPDL CCKHOOHAFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2680", Offset = "0x5FF1880", VA = "0x185FF2680")]
	public static KPNOJENBPDL PANAAMLBDFM(KPNOJENBPDL CCKHOOHAFFD)
	{
		return default(KPNOJENBPDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2330", Offset = "0x5FF1530", VA = "0x185FF2330")]
	public static JCGIPAGGCGM AHHECAJJDBF(KPNOJENBPDL LMEOABKDLHA)
	{
		return default(JCGIPAGGCGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FF23E0", Offset = "0x5FF15E0", VA = "0x185FF23E0")]
	internal static KPNOJENBPDL FDBBNICMFAL(JCGIPAGGCGM NGBCJANKNNM)
	{
		return default(KPNOJENBPDL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class DDKENFJDDAJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ECCMPLBFDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82F780", Offset = "0x82E980", VA = "0x18082F780")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	protected DDKENFJDDAJ(object? LGEFCPBIAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool FIDBGNANPBO(object? IPMIIEAGJKC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class EGIFJIBMFIH<T> : DDKENFJDDAJ where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private T NLCKACNFDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> AHFOJMBPHIP;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T LKDHJKNGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x239A6E0", Offset = "0x23998E0", VA = "0x18239A6E0", Slot = "4")]
	public override bool FIDBGNANPBO(object? IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x239A980", Offset = "0x2399B80", VA = "0x18239A980")]
	public bool IIHAAKBJNCN(T JCPJFEMNJJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x239AD70", Offset = "0x2399F70", VA = "0x18239AD70")]
	public EGIFJIBMFIH(T GFLAEOLMKMC, IEqualityComparer<T> AHFOJMBPHIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ALEDIPFHHGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<IADIMLJDNFP, bool> PGKNPJOFCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<IADIMLJDNFP, DDKENFJDDAJ> PEHABIFDKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly KPGELLHHEJP FAMICCBPNMD;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB530", Offset = "0x5FEA730", VA = "0x185FEB530")]
	public ALEDIPFHHGD(KPGELLHHEJP FAMICCBPNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB0B0", Offset = "0x5FEA2B0", VA = "0x185FEB0B0")]
	public bool CHFFCOFECHA(IADIMLJDNFP HEGLKMIJHAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2782F20", Offset = "0x2782120", VA = "0x182782F20")]
	public bool CMGDHEIJIBE<T>(IADIMLJDNFP HEGLKMIJHAM, bool FMMJFLMIBAO, T IPMIIEAGJKC) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27832A0", Offset = "0x27824A0", VA = "0x1827832A0")]
	public (bool, T?) DNFGKKDMGLM<T>(IADIMLJDNFP HEGLKMIJHAM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB120", Offset = "0x5FEA320", VA = "0x185FEB120")]
	public bool CMGDHEIJIBE(IADIMLJDNFP HEGLKMIJHAM, bool FMMJFLMIBAO, object IPMIIEAGJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB200", Offset = "0x5FEA400", VA = "0x185FEB200")]
	public (bool, object) DNFGKKDMGLM(IADIMLJDNFP HEGLKMIJHAM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x27834B0", Offset = "0x27826B0", VA = "0x1827834B0")]
	private void PIMKGKNFAGB<T>(IADIMLJDNFP HEGLKMIJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB470", Offset = "0x5FEA670", VA = "0x185FEB470")]
	private DDKENFJDDAJ OJKHBJDKGED(IADIMLJDNFP HEGLKMIJHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB2D0", Offset = "0x5FEA4D0", VA = "0x185FEB2D0")]
	public void IEAIPAAIHLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class GPMOKIOJKHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string HGHLBCLFGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type BMMIPLGGAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly ODACJPINABI GPCPJGCMKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly IADIMLJDNFP HAODMJEJOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public CNABFAODCPO DOFKGNLCBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public JANLKJMKMLM IBNMGLEGING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public MBGMFBIMMDB OIBAHDFIEJM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2200", Offset = "0x5FF1400", VA = "0x185FF2200")]
	public GPMOKIOJKHI(Type GHFKDODLJHK, string CEEBKJJBEMB, IADIMLJDNFP HEGLKMIJHAM, CNABFAODCPO JNLEIMIEDNK, JANLKJMKMLM HONKOELDHDG, MBGMFBIMMDB OKIBBPOCNBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2110", Offset = "0x5FF1310", VA = "0x185FF2110")]
	public object CCHLJGAKEGA(object? HNPEBINPOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x22680F0", Offset = "0x22672F0", VA = "0x1822680F0")]
	public void PIMKGKNFAGB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2150", Offset = "0x5FF1350", VA = "0x185FF2150")]
	public void PIMKGKNFAGB(Type AMFLIDEOPMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class PJCKBCNFNKK<T> : GPMOKIOJKHI where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string ECPLDNCIHJD(T IPMIIEAGJKC);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T FNMDHMFMACG(string? CCLCCAKJABO, T GFLAEOLMKMC);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class OFFGLENEJCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public ECPLDNCIHJD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FNMDHMFMACG parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public OFFGLENEJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x202B710", Offset = "0x202A910", VA = "0x18202B710")]
		internal string <.ctor>b__0(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x202B7B0", Offset = "0x202A9B0", VA = "0x18202B7B0")]
		internal object <.ctor>b__1(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEABC0", Offset = "0x2BE9DC0", VA = "0x182BEABC0")]
	public PJCKBCNFNKK(IADIMLJDNFP HEGLKMIJHAM, string CEEBKJJBEMB, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5EDA60", Offset = "0x5ECE60")] global::PJCKBCNFNKK<T>.ECPLDNCIHJD JNLEIMIEDNK, [Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5EDAC0", Offset = "0x5ECEC0")] global::PJCKBCNFNKK<T>.FNMDHMFMACG HONKOELDHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE9860", Offset = "0x2BE8A60", VA = "0x182BE9860")]
	private static object? BBCFAILGGHN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5EDB20", Offset = "0x5ECF20")] global::PJCKBCNFNKK<T?>.FNMDHMFMACG? HONKOELDHDG, string? CCLCCAKJABO, object? GFLAEOLMKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2BEA2B0", Offset = "0x2BE94B0", VA = "0x182BEA2B0")]
	private static string IIADKJHBOIN([Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5EDB80", Offset = "0x5ECF80")] global::PJCKBCNFNKK<T>.ECPLDNCIHJD NOADFBDCOHM, object? IPMIIEAGJKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string CNABFAODCPO(object? IPMIIEAGJKC);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object JANLKJMKMLM(string? CCLCCAKJABO, [Optional] object GFLAEOLMKMC);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate DDKENFJDDAJ MBGMFBIMMDB();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KPGELLHHEJP
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KBCHDBCODBF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static KBCHDBCODBF OFDKPDDLIJC;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2CB0", Offset = "0x5FF1EB0", VA = "0x185FF2CB0", Slot = "4")]
		public bool Equals(List<string> FCCGDNMAHPA, List<string> BADLFKONABM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2E10", Offset = "0x5FF2010", VA = "0x185FF2E10", Slot = "5")]
		public int GetHashCode(List<string> ICHBECDKHOJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public KBCHDBCODBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JBGLBDCHCBB : global::PDIEJEBDKBM<OOPNCLJNMFK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2B70", Offset = "0x5FF1D70", VA = "0x185FF2B70", Slot = "9")]
		public override string IIADKJHBOIN(OOPNCLJNMFK KAEDAICECGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2980", Offset = "0x5FF1B80", VA = "0x185FF2980", Slot = "10")]
		protected override bool CKBHIHJKLLJ(string KAEDAICECGN, out OOPNCLJNMFK IPMIIEAGJKC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5FF2C70", Offset = "0x5FF1E70", VA = "0x185FF2C70")]
		public JBGLBDCHCBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly BLDANIKJLCN FNAANOAIAMP;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly JBGLBDCHCBB DBLODNKLOCC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<GPMOKIOJKHI> FOAMGAACPOA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<IADIMLJDNFP> FOEJJLJFDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<IADIMLJDNFP, GPMOKIOJKHI> GGHGEAGJHMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF44E0", Offset = "0x5FF36E0", VA = "0x185FF44E0")]
	public KPGELLHHEJP([Optional][Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5EDBE0", Offset = "0x5ECFE0")] IList<GPMOKIOJKHI> BGNJGDNPLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF38F0", Offset = "0x5FF2AF0", VA = "0x185FF38F0")]
	public GPMOKIOJKHI DKPBLJEOCCC(IADIMLJDNFP HEGLKMIJHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CKEMGHEJHPH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PJCMOOCCFCF LGCBANFMEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class KIJGLFAIIGF : CKEMGHEJHPH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static KIJGLFAIIGF GJDFKIAPFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly KPLLHCJOPLD JNNMKIALKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<KPLLHCJOPLD> JMHDOFEDHNG;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PJCMOOCCFCF LGCBANFMEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5FF37F0", Offset = "0x5FF29F0", VA = "0x185FF37F0")]
	public KIJGLFAIIGF(KPLLHCJOPLD PAOLFMOKOEB, IReadOnlyList<KPLLHCJOPLD> PJHFGNJJONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5FF2FB0", Offset = "0x5FF21B0", VA = "0x185FF2FB0")]
	private static KIJGLFAIIGF OCHFNIHBGFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NAOCGNBAPEF
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<KPNOJENBPDL> FGJCOGKCDEB;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6A80", Offset = "0x5FF5C80", VA = "0x185FF6A80")]
	public static bool EBMOLAGBGGO(this JDCIJIEOFOL FBKANDGAIBM, KPNOJENBPDL CCKHOOHAFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6A00", Offset = "0x5FF5C00", VA = "0x185FF6A00")]
	public static bool CIBKKLHLPKH(this JDCIJIEOFOL FBKANDGAIBM, KPNOJENBPDL CCKHOOHAFFD, LCEKCFEIEGJ JNJPPHFKKEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface ONHBLPHFIGB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NFCDBCKECHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HELGFGMCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool OBBPIMACODO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DJHIINOJMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KJMFMLPJOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CMIJLCGPKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GADEEBJLLFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PJAKNCADEFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool OKIGFCOCPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool CGADEOCJADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IMGAOLECKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool NAMGNDCKDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> CCKGHFFOLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OOPNCLJNMFK APDBKBNIIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PJCMOOCCFCF : ONHBLPHFIGB, GOMIGOHHACK, global::NALCDCIGNGH<IADIMLJDNFP>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string KIEHPBIOHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	KPNOJENBPDL GJPOIEGAGLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) BICPJLLFCDA<T>(IADIMLJDNFP HEGLKMIJHAM) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum IADIMLJDNFP
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
internal class KPLLHCJOPLD : PJCMOOCCFCF, ONHBLPHFIGB, GOMIGOHHACK, global::NALCDCIGNGH<IADIMLJDNFP>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal static readonly KPGELLHHEJP OLHFHJOOKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly ALEDIPFHHGD INEDLDJGNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private string? EOJDBMEHCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string? GLEIPJAKKJP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool NFCDBCKECHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5380", Offset = "0x5FF4580", VA = "0x185FF5380", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public OOPNCLJNMFK APDBKBNIIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4970", Offset = "0x5FF3B70", VA = "0x185FF4970", Slot = "20")]
		get
		{
			return default(OOPNCLJNMFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool HELGFGMCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5E20", Offset = "0x5FF5020", VA = "0x185FF5E20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OBBPIMACODO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6710", Offset = "0x5FF5910", VA = "0x185FF6710", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DJHIINOJMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4A10", Offset = "0x5FF3C10", VA = "0x185FF4A10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool KJMFMLPJOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF53D0", Offset = "0x5FF45D0", VA = "0x185FF53D0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool CMIJLCGPKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6490", Offset = "0x5FF5690", VA = "0x185FF6490", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool GADEEBJLLFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6620", Offset = "0x5FF5820", VA = "0x185FF6620", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PJAKNCADEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4AB0", Offset = "0x5FF3CB0", VA = "0x185FF4AB0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool OKIGFCOCPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6580", Offset = "0x5FF5780", VA = "0x185FF6580", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyList<string> CCKGHFFOLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5E70", Offset = "0x5FF5070", VA = "0x185FF5E70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool BKEOJJEEMFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5FF49C0", Offset = "0x5FF3BC0", VA = "0x185FF49C0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LEIDCMPOEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4920", Offset = "0x5FF3B20", VA = "0x185FF4920", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BMPILLFMAHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FF66C0", Offset = "0x5FF58C0", VA = "0x185FF66C0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool CGADEOCJADE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FF64E0", Offset = "0x5FF56E0", VA = "0x185FF64E0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IMGAOLECKKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5FF65D0", Offset = "0x5FF57D0", VA = "0x185FF65D0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DNIGEFKJALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6530", Offset = "0x5FF5730", VA = "0x185FF6530", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NAMGNDCKDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4A60", Offset = "0x5FF3C60", VA = "0x185FF4A60", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool KJOLMHMBOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF48D0", Offset = "0x5FF3AD0", VA = "0x185FF48D0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ODFGPMKDHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5F90", Offset = "0x5FF5190", VA = "0x185FF5F90", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private bool FBGGOJBPHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5FF49C0", Offset = "0x5FF3BC0", VA = "0x185FF49C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private bool MMBKCEELKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5FF66C0", Offset = "0x5FF58C0", VA = "0x185FF66C0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private bool BAGNICNHEGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6530", Offset = "0x5FF5730", VA = "0x185FF6530", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private bool ECMIBAFBBLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5FF48D0", Offset = "0x5FF3AD0", VA = "0x185FF48D0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool FFDIAAFLFKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4920", Offset = "0x5FF3B20", VA = "0x185FF4920", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private bool MCINKOEBBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5F90", Offset = "0x5FF5190", VA = "0x185FF5F90", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KPNOJENBPDL GJPOIEGAGLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7E49F0", Offset = "0x7E3BF0", VA = "0x1807E49F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(KPNOJENBPDL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7E47C0", Offset = "0x7E39C0", VA = "0x1807E47C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string JIINFFODCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5420", Offset = "0x5FF4620", VA = "0x185FF5420", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6670", Offset = "0x5FF5870", VA = "0x185FF6670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string KIEHPBIOHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5420", Offset = "0x5FF4620", VA = "0x185FF5420", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool IDGPEDFNGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4980", Offset = "0x7B3B80", VA = "0x1807B4980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B4840", Offset = "0x7B3A40", VA = "0x1807B4840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event global::MDHJCOEBDEN<IADIMLJDNFP> KHAIHIGFJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4C00", Offset = "0x5FF3E00", VA = "0x185FF4C00", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5FF4EB0", Offset = "0x5FF40B0", VA = "0x185FF4EB0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4CA0", Offset = "0x5FF3EA0", VA = "0x185FF4CA0")]
	public IJGJFBPCIGI EIEJLKMEIMJ(Func<KPNOJENBPDL, Guid> CKIHJNEOGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5FF5470", Offset = "0x5FF4670", VA = "0x185FF5470")]
	public void GDDPOGDKNED(IJGJFBPCIGI OHCKIKAFICK, Func<Guid, KPNOJENBPDL> HGPBJFBNICK, [Optional] KPNOJENBPDL? GEGBGOBCJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2200960", Offset = "0x21FFB60", VA = "0x182200960", Slot = "6")]
	public (bool, T?) BICPJLLFCDA<T>(IADIMLJDNFP HEGLKMIJHAM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2200AF0", Offset = "0x21FFCF0", VA = "0x182200AF0")]
	public KPLLHCJOPLD IIHPOEDCAIE<T>(IADIMLJDNFP HEGLKMIJHAM, bool FMMJFLMIBAO, T IPMIIEAGJKC) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5FF67F0", Offset = "0x5FF59F0", VA = "0x185FF67F0")]
	public KPLLHCJOPLD(KPNOJENBPDL CCKHOOHAFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5FF67D0", Offset = "0x5FF59D0", VA = "0x185FF67D0")]
	public KPLLHCJOPLD(KPNOJENBPDL CCKHOOHAFFD, [Optional] string? EOJDBMEHCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6960", Offset = "0x5FF5B60", VA = "0x185FF6960")]
	public KPLLHCJOPLD(KPLLHCJOPLD OEJILPJHPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6810", Offset = "0x5FF5A10", VA = "0x185FF6810")]
	internal KPLLHCJOPLD(KPNOJENBPDL KLBONOOHBND, [Optional] string? EOJDBMEHCOF, [Optional] KPLLHCJOPLD? OEJILPJHPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4850", Offset = "0x5FF3A50", VA = "0x185FF4850")]
	public static ODACJPINABI BCBEAHADIAD(IADIMLJDNFP HEGLKMIJHAM)
	{
		return default(ODACJPINABI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5FF5F70", Offset = "0x5FF5170", VA = "0x185FF5F70")]
	public void IEAIPAAIHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FF60C0", Offset = "0x5FF52C0", VA = "0x185FF60C0")]
	internal KPLLHCJOPLD JGMLMOAPKAE(KPLLHCJOPLD LLCICIBAEOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4F50", Offset = "0x5FF4150", VA = "0x185FF4F50")]
	internal IReadOnlyCollection<IADIMLJDNFP> EKNKDADOBNE(KPLLHCJOPLD OEJILPJHPPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5FF5FE0", Offset = "0x5FF51E0", VA = "0x185FF5FE0")]
	public bool JGAGPNNDMDO(IADIMLJDNFP HEGLKMIJHAM, bool FMMJFLMIBAO, string FHNMALKLNII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FF4B00", Offset = "0x5FF3D00", VA = "0x185FF4B00")]
	public (bool, string) EBIJKJHFEFG(IADIMLJDNFP HEGLKMIJHAM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FF5ED0", Offset = "0x5FF50D0", VA = "0x185FF5ED0")]
	internal void HIPFAEPNAHA(IADIMLJDNFP HEGLKMIJHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6400", Offset = "0x5FF5600", VA = "0x185FF6400")]
	[CompilerGenerated]
	private void KEGLKADHCOO(IADIMLJDNFP OAHMEFCIJFN, IFGGOCIIJGE HMDPNMDIANH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class APFONEMLBBB : JAECBOHHODF, CGOPOAFDIDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class NMMONKPCFKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KPLLHCJOPLD newRole;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NMMONKPCFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6D40", Offset = "0x5FF5F40", VA = "0x185FF6D40")]
		internal bool <InitializeRolesLists>b__0(KPLLHCJOPLD rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MNEEIACHANL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public KPNOJENBPDL roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public MNEEIACHANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5FF69F0", Offset = "0x5FF5BF0", VA = "0x185FF69F0")]
		internal bool <UpdateRoleDatas>b__0(KPNOJENBPDL r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct FPDJJGMHCFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public APFONEMLBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public KHMOHFAFGBI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5EE190", Offset = "0x5ED590")]
		private TaskAwaiter<DJCKFAAOIFO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF1AF0", Offset = "0x5FF0CF0", VA = "0x185FF1AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class DPICBKMNAAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public DPICBKMNAAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5FF18F0", Offset = "0x5FF0AF0", VA = "0x185FF18F0")]
		internal void <RunBackwardsCompatibilityMigration>b__0(IJGJFBPCIGI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5FF19D0", Offset = "0x5FF0BD0", VA = "0x185FF19D0")]
		internal void <RunBackwardsCompatibilityMigration>b__1(IJGJFBPCIGI r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DACKFEACPNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public KHMOHFAFGBI roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OPAGGADHFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5EE1F0", Offset = "0x5ED5F0")]
		public Func<IJGJFBPCIGI, IFGGOCIIJGE> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public OPAGGADHFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6E00", Offset = "0x5FF6000", VA = "0x185FF6E00")]
		internal void <MigrateLegacyHostSettings>b__1(IJGJFBPCIGI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6E60", Offset = "0x5FF6060", VA = "0x185FF6E60")]
		internal void <MigrateLegacyHostSettings>b__2(IJGJFBPCIGI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6EC0", Offset = "0x5FF60C0", VA = "0x185FF6EC0")]
		internal void <MigrateLegacyHostSettings>b__3(IJGJFBPCIGI r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BPBBDAHCKIH<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public APFONEMLBBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public IADIMLJDNFP rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public KPNOJENBPDL accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public ODACJPINABI recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public BPBBDAHCKIH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PLCBBOICPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public IReadOnlyList<BKNBLINKIDO> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CAHEHBMGNPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public PEIMNKFLDCP rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public KHMOHFAFGBI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x5EE300", Offset = "0x5ED700")]
		public IReadOnlyDictionary<KPNOJENBPDL, KPLLHCJOPLD> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public KKMCCLAPGLL debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF0EE0", Offset = "0x5FF00E0", VA = "0x185FF0EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly PEIMNKFLDCP PFLAHGGDGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly KIJGLFAIIGF LFALKHOLLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly KKMCCLAPGLL CCONPAMBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly Dictionary<int, KPLLHCJOPLD> DPFFHDHAFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	internal readonly Dictionary<KPNOJENBPDL, KPLLHCJOPLD> HKCOFEKOIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal readonly Dictionary<KPNOJENBPDL, KPLLHCJOPLD> GHKPAPLOAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly List<KPLLHCJOPLD> BDHNMCGNIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool BEDJGEJKGBJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly IADIMLJDNFP[] IKPOOFPCJKC;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CKEMGHEJHPH AOKLLKFNHFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<PJCMOOCCFCF> ALIMJOBNFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5FECDA0", Offset = "0x5FEBFA0", VA = "0x185FECDA0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event IENMFGLAGBK AFJCAMKMKEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5FEB790", Offset = "0x5FEA990", VA = "0x185FEB790", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FECFB0", Offset = "0x5FEC1B0", VA = "0x185FECFB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC330", Offset = "0x5FEB530", VA = "0x185FEC330")]
	[IOFOCEAPGPD(NAFLJHIHEAG.Room, NPBJMIOJGOK.None)]
	private static void CPPCJDFOIOD(MNALHHOLFGL NHHKPMOGNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0C50", Offset = "0x5FEFE50", VA = "0x185FF0C50")]
	[UnityEngine.Scripting.Preserve]
	internal APFONEMLBBB([CDOANEBODFP(null)] PEIMNKFLDCP HAFMKLDNLPO, [CDOANEBODFP(null)] KIJGLFAIIGF OBEJGKCJCIF, [CDOANEBODFP(null)] KKMCCLAPGLL CCONPAMBIDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5FECC90", Offset = "0x5FEBE90", VA = "0x185FECC90", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5FEB830", Offset = "0x5FEAA30", VA = "0x185FEB830")]
	private void AFFBIIALOGB(IEnumerable<KPLLHCJOPLD> EHHOMONLLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF740", Offset = "0x5FEE940", VA = "0x185FEF740", Slot = "12")]
	public bool LBFEEPOJKOP(JDCIJIEOFOL EKOFNPFCLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF810", Offset = "0x5FEEA10", VA = "0x185FEF810")]
	private void NJMCOMBNPLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0300", Offset = "0x5FEF500", VA = "0x185FF0300")]
	private void PHPNPDKCKIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0490", Offset = "0x5FEF690", VA = "0x185FF0490", Slot = "10")]
	public IReadOnlyList<PJCMOOCCFCF> PLEJNOFAJOC(bool NCNJBBIMFKI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5FECEA0", Offset = "0x5FEC0A0", VA = "0x185FECEA0", Slot = "11")]
	public PJCMOOCCFCF FJPGBGEHPAN(JDCIJIEOFOL EKOFNPFCLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5FEEDB0", Offset = "0x5FEDFB0", VA = "0x185FEEDB0")]
	private KPNOJENBPDL JKJJJCENFBN(JDCIJIEOFOL EKOFNPFCLMO)
	{
		return default(KPNOJENBPDL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF5B0", Offset = "0x5FEE7B0", VA = "0x185FEF5B0", Slot = "14")]
	public bool JPJELKNDGAO(JDCIJIEOFOL HAFLMJCDPPI, KPNOJENBPDL CCKHOOHAFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5FECDF0", Offset = "0x5FEBFF0", VA = "0x185FECDF0", Slot = "15")]
	public PJCMOOCCFCF FHMIPLOGADI(KPNOJENBPDL CCKHOOHAFFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFDE0", Offset = "0x5FEEFE0", VA = "0x185FEFDE0")]
	private static bool PDCPNFDFNKN(IBFPPJLGAEF DFGGDGCDHCG, KPNOJENBPDL CCKHOOHAFFD, out IJGJFBPCIGI? IEAAPHNNIBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0780", Offset = "0x5FEF980", VA = "0x185FF0780")]
	private static void PNCCEOCJKKP(IBFPPJLGAEF DFGGDGCDHCG, Action<IJGJFBPCIGI> OBPCGHCMALI, KPNOJENBPDL CEAINCEIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0880", Offset = "0x5FEFA80", VA = "0x185FF0880")]
	private static void PNCCEOCJKKP(IBFPPJLGAEF DFGGDGCDHCG, Action<IJGJFBPCIGI> OBPCGHCMALI, Predicate<KPNOJENBPDL> DFECOLCBKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC4F0", Offset = "0x5FEB6F0", VA = "0x185FEC4F0")]
	private void DHFMMJMDMEF(JDCIJIEOFOL EKOFNPFCLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5FED370", Offset = "0x5FEC570", VA = "0x185FED370", Slot = "4")]
	[AsyncStateMachine(typeof(FPDJJGMHCFC))]
	public Task HHLDNOMKLBJ([CanBeNull] KHMOHFAFGBI KGMPBFBAMCF, CancellationToken NDKAKDJMDIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
	public void BOODPBHPDHM(ref KHMOHFAFGBI KGMPBFBAMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5FF0510", Offset = "0x5FEF710", VA = "0x185FF0510")]
	private void PMCIHFBPKFG(IBFPPJLGAEF OICIKBCLLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE700", Offset = "0x5FED900", VA = "0x185FEE700")]
	internal static string IOOOBCEGAEO(PEIMNKFLDCP PFLAHGGDGIM, KHMOHFAFGBI KGMPBFBAMCF, IReadOnlyDictionary<KPNOJENBPDL, KPLLHCJOPLD> HKCOFEKOIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5FED680", Offset = "0x5FEC880", VA = "0x185FED680")]
	private static void IFLKMCGJOMG(KHMOHFAFGBI KGMPBFBAMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC020", Offset = "0x5FEB220", VA = "0x185FEC020")]
	private static void BBCMBOLDCCJ(IBFPPJLGAEF MCEPDLBLJMI, IReadOnlyDictionary<KPNOJENBPDL, KPLLHCJOPLD> HKCOFEKOIMK, StringBuilder EFJGBPOLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF450", Offset = "0x5FEE650", VA = "0x185FEF450")]
	private static bool JPAELMOEAMN(string KKDIBMPPPGI, out Guid JKHAGFEKALE, out KPNOJENBPDL CCKHOOHAFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5FEEE70", Offset = "0x5FEE070", VA = "0x185FEEE70")]
	private static void JKKPICPAHAO(KHMOHFAFGBI KGMPBFBAMCF, StringBuilder EFJGBPOLAHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2784870", Offset = "0x2783A70", VA = "0x182784870", Slot = "16")]
	public bool AJGMFNLMNAP<T>(KPNOJENBPDL CCKHOOHAFFD, IADIMLJDNFP HEGLKMIJHAM, bool FMMJFLMIBAO, T NKBIKBGEKGL) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5FED4B0", Offset = "0x5FEC6B0", VA = "0x185FED4B0")]
	private void IDAKPDNFMLE(KPNOJENBPDL CCKHOOHAFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5FEEA00", Offset = "0x5FEDC00", VA = "0x185FEEA00")]
	private bool JCNMEONLBCN(JDCIJIEOFOL EKOFNPFCLMO, KPNOJENBPDL CCKHOOHAFFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FED050", Offset = "0x5FEC250", VA = "0x185FED050")]
	internal KPLLHCJOPLD HEICCGCCJPO(JDCIJIEOFOL EKOFNPFCLMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5FED670", Offset = "0x5FEC870", VA = "0x185FED670", Slot = "13")]
	public IReadOnlyList<PJCMOOCCFCF> IEDDIIDOMBJ(JDCIJIEOFOL EKOFNPFCLMO, bool HLCLEBMPNME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FEE4E0", Offset = "0x5FED6E0", VA = "0x185FEE4E0")]
	internal IReadOnlyList<KPLLHCJOPLD> IGFIAPILGHC(JDCIJIEOFOL EKOFNPFCLMO, bool HLCLEBMPNME = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FEC550", Offset = "0x5FEB750", VA = "0x185FEC550")]
	private void DKIECJIGJCF(DJCKFAAOIFO CDCMBIMBPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FEFAF0", Offset = "0x5FEECF0", VA = "0x185FEFAF0")]
	private static bool OKEIIFJIACG(KPLLHCJOPLD EMBJHFALMGI, IReadOnlyDictionary<KPNOJENBPDL, KPLLHCJOPLD> HKCOFEKOIMK, out IReadOnlyList<IADIMLJDNFP> LEHCEJIIKMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5FF01A0", Offset = "0x5FEF3A0", VA = "0x185FF01A0")]
	[AsyncStateMachine(typeof(CAHEHBMGNPC))]
	private static Task PGHFEKGCHCO(PEIMNKFLDCP PFLAHGGDGIM, KHMOHFAFGBI KGMPBFBAMCF, IReadOnlyDictionary<KPNOJENBPDL, KPLLHCJOPLD> HKCOFEKOIMK, KKMCCLAPGLL CCONPAMBIDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5FEF820", Offset = "0x5FEEA20", VA = "0x185FEF820")]
	[CompilerGenerated]
	internal static void OIBJDMAKIID(Func<IJGJFBPCIGI, IFGGOCIIJGE> EIOPAEIDLNC, ref DACKFEACPNG P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5FEEA20", Offset = "0x5FEDC20", VA = "0x185FEEA20")]
	[CompilerGenerated]
	internal static bool JGOCLLDAINK(KPNOJENBPDL CCKHOOHAFFD, IADIMLJDNFP HEGLKMIJHAM, out BKNBLINKIDO JMENBNABINB, ref PLCBBOICPKF P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface LHAFCODAJNM
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HLLCEMKLKBL(JDCIJIEOFOL MEIDOJEOCJI, JDCIJIEOFOL HALBMCBBHOK, IEnumerable<JDCIJIEOFOL> EBODCNOOACA, out OOPNCLJNMFK IOMLKEMFBNI, out GCKONFGIPML CFGAHMAKEMM);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum GCKONFGIPML : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	CantKickEventOrganizer
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class PENBEBNLOCE : LHAFCODAJNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly CGOPOAFDIDN MBCIDBKFADG;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7A4ED0", Offset = "0x7A40D0", VA = "0x1807A4ED0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PENBEBNLOCE([CDOANEBODFP(null)] CGOPOAFDIDN AAKFKPKFDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6F20", Offset = "0x5FF6120", VA = "0x185FF6F20")]
	private static IMIJPHJKLIM? APFJLNDFADM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5FF6F70", Offset = "0x5FF6170", VA = "0x185FF6F70", Slot = "4")]
	public bool HLLCEMKLKBL(JDCIJIEOFOL MEIDOJEOCJI, JDCIJIEOFOL HALBMCBBHOK, IEnumerable<JDCIJIEOFOL> EBODCNOOACA, out OOPNCLJNMFK IOMLKEMFBNI, out GCKONFGIPML CFGAHMAKEMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5FF7080", Offset = "0x5FF6280", VA = "0x185FF7080")]
	internal bool PJKGOPFNKPE(JDCIJIEOFOL MEIDOJEOCJI, JDCIJIEOFOL HALBMCBBHOK, IEnumerable<JDCIJIEOFOL> EBODCNOOACA, LCEKCFEIEGJ JNJPPHFKKEN, IMIJPHJKLIM? IGGPIMCKMBP, out OOPNCLJNMFK IOMLKEMFBNI, out GCKONFGIPML CFGAHMAKEMM)
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
