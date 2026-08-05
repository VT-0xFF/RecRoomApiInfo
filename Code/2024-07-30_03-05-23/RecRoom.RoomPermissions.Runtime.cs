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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71183D0", Offset = "0x71169D0", VA = "0x1871183D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum LFLDJKKKNPO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NEOLNBOJFIP<TPermission>(TPermission GMDKJENIEGM);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void EPPDGMIKIAI(JMJBMOCBEJD AKBLJHNIFIE);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum DMLIMHDIJMG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NCNAGHHBMIH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NMKIPMHDFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HMCANGGACKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KCGDAEECCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NNOGEHMLEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ALPGGCNDIGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MIIFBMLFAPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class IEOKPHDDNEF
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum GAIFHJEMDFC
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
	public static readonly Guid JDGGDPFDCKE;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid PODAAGFCANF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid BLGOOABJFAL;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid OFBACNNHPOG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid KGJKLECNBAD;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid FANDHAEAOCP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly MDCAOFOANPI<JKKPOGCBEJM, Guid> BAHMBJANNLJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<JKKPOGCBEJM> KJNBAIKNGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x710D2B0", Offset = "0x710B8B0", VA = "0x18710D2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x710D4A0", Offset = "0x710BAA0", VA = "0x18710D4A0")]
	public static JKKPOGCBEJM KDMLGPNLGNL(Guid IJNLNGBKEAC)
	{
		return default(JKKPOGCBEJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x710D330", Offset = "0x710B930", VA = "0x18710D330")]
	public static Guid HOOJNHGDPGL(JKKPOGCBEJM BBOPAHHLNLP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x710D3D0", Offset = "0x710B9D0", VA = "0x18710D3D0")]
	public static bool HOPNPIMEKAO(JKKPOGCBEJM BBOPAHHLNLP, [Out] Guid IJNLNGBKEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x710D530", Offset = "0x710BB30", VA = "0x18710D530")]
	public static bool PDCKHFFBNJE(Guid IJNLNGBKEAC, [Out] JKKPOGCBEJM BBOPAHHLNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x710D1C0", Offset = "0x710B7C0", VA = "0x18710D1C0")]
	public static JKKPOGCBEJM AHFKBMNNGHN(JKKPOGCBEJM BBOPAHHLNLP)
	{
		return default(JKKPOGCBEJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x710D200", Offset = "0x710B800", VA = "0x18710D200")]
	public static GAIFHJEMDFC DFMHNOKFBNO(JKKPOGCBEJM NLBPOPDHLHB)
	{
		return default(GAIFHJEMDFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x710D460", Offset = "0x710BA60", VA = "0x18710D460")]
	internal static JKKPOGCBEJM JBOGNBJMEDK(GAIFHJEMDFC PFAMODDCFHN)
	{
		return default(JKKPOGCBEJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IBABOCJFFBL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CMKDIHKOMEB MKBDGCCHNPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<PFNHDJHFHJF> LLCOGLPCMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EPPDGMIKIAI BINPNOCJCMJ;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<PFNHDJHFHJF> IBMCKECGDEJ(bool GLPHGEPBHHN = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PFNHDJHFHJF HODGEAHGBCD(JMJBMOCBEJD AKBLJHNIFIE);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PGMAIOKJKGM(JMJBMOCBEJD AKBLJHNIFIE);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<PFNHDJHFHJF> LAMNIPGPPIC(JMJBMOCBEJD AKBLJHNIFIE, bool DDDHFNFHLCO = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FGBONMMCKKL(JMJBMOCBEJD HNDAEJLDHOG, JKKPOGCBEJM BBOPAHHLNLP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PFNHDJHFHJF MGCPAHACJAB(JKKPOGCBEJM BBOPAHHLNLP);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FKCMIKABCJK<T>(JKKPOGCBEJM BBOPAHHLNLP, OAGMENEMPGK GMDKJENIEGM, bool FADHMOCHILH, T CIFNGMCMOJD, [Optional] Action JLMINPEABMO) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string CDCEHDIKFDD(OAGMENEMPGK GMDKJENIEGM);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DEAPBNGOOJP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AHEKMABLOGH(PIMCJABKION FPDNBDDHMAO, CancellationToken FIMAIPEFOAM);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFGJNGHLFFP(PIMCJABKION FPDNBDDHMAO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HOMJDCHDLPH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JMJBMOCBEJD AGGJOLADOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EKDJNKIHINM NDPCPFHJGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MGIHEKMGJGG OAOOHCFLBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<OPAPIMGPOOD> KMHCJMAEAPL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action AJFJIFEGDFI;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JKKPOGCBEJM FABGGKJKIIN(JMJBMOCBEJD AKBLJHNIFIE);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OPAPIMGPOOD> LLIGPCKEADJ(CancellationToken FIMAIPEFOAM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task EFNJJGLODEM(long BLAPHPMDNOF, IReadOnlyList<DDNKOPFKNBM> BILCKIEEODB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task KKCHGHHLBDJ(long BLAPHPMDNOF, long PKGFFCOLPCB, IReadOnlyList<DDNKOPFKNBM> BILCKIEEODB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<JMJBMOCBEJD> AFPJBBKNJLE();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DLILCPGKFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x710B440", Offset = "0x7109A40", VA = "0x18710B440")]
	public static JKKPOGCBEJM JAPGFBADFLD(this HOMJDCHDLPH DMJMDNMOEPE)
	{
		return default(JKKPOGCBEJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FAKDPCPMBGB<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NEOKPALKBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NEOLNBOJFIP<TPermission> LFABHBHOPPP;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class COPFCMDBIIK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? JPEEOOILBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	protected COPFCMDBIIK(object? BGCFCLNFDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool IFICIMIEIPO(object? DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class KOOKOALHFDL<T> : COPFCMDBIIK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T IKCENPKFIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> PAEANBLKLHD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T FJLALGMPANI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E74D0", Offset = "0x8E5AD0", VA = "0x1808E74D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x41CCBE0", Offset = "0x41CB1E0", VA = "0x1841CCBE0", Slot = "4")]
	public override bool IFICIMIEIPO(object? DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x41CCE00", Offset = "0x41CB400", VA = "0x1841CCE00")]
	public bool LGAEIFGBGBM(T JOBOANKNMLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x41CD330", Offset = "0x41CB930", VA = "0x1841CD330")]
	public KOOKOALHFDL(T DNKAMNBGFFH, IEqualityComparer<T> PAEANBLKLHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HDJPOBKKDGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<OAGMENEMPGK, bool> NIPMIBFBLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<OAGMENEMPGK, COPFCMDBIIK> GPODAAIAFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly JEBBDKGGKGC DLIEIPEIBMI;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x710CF10", Offset = "0x710B510", VA = "0x18710CF10")]
	public HDJPOBKKDGI(JEBBDKGGKGC DLIEIPEIBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x710CC20", Offset = "0x710B220", VA = "0x18710CC20")]
	public bool FLKPHDPFLNA(OAGMENEMPGK GMDKJENIEGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2BA27C0", Offset = "0x2BA0DC0", VA = "0x182BA27C0")]
	public bool PGLHLHLIHON<T>(OAGMENEMPGK GMDKJENIEGM, bool FADHMOCHILH, T DMNGPNKHPKF) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BA22C0", Offset = "0x2BA08C0", VA = "0x182BA22C0")]
	public (bool, T?) FMMIAOHPCID<T>(OAGMENEMPGK GMDKJENIEGM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x710CE30", Offset = "0x710B430", VA = "0x18710CE30")]
	public bool PGLHLHLIHON(OAGMENEMPGK GMDKJENIEGM, bool FADHMOCHILH, object DMNGPNKHPKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x710CC90", Offset = "0x710B290", VA = "0x18710CC90")]
	public (bool, object) FMMIAOHPCID(OAGMENEMPGK GMDKJENIEGM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2BA2760", Offset = "0x2BA0D60", VA = "0x182BA2760")]
	private void IEKDOJHFPJF<T>(OAGMENEMPGK GMDKJENIEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x710CD60", Offset = "0x710B360", VA = "0x18710CD60")]
	private COPFCMDBIIK OHNAENGBPNC(OAGMENEMPGK GMDKJENIEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x710CA20", Offset = "0x710B020", VA = "0x18710CA20")]
	public void BPNKMOIPBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class PBHCEAIHGIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string MFMHHDGDGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type BNDADIGKEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly PHEAFPHFFEM NIBCPOOPPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly OAGMENEMPGK MKFMPIDHACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public CJAMEBHEBPA FGPCCDOMHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public DOKKJHOINFL PPDOAIJIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public IMJJEFLFACH GJJNIBHBKCK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7118550", Offset = "0x7116B50", VA = "0x187118550")]
	public PBHCEAIHGIF(Type KIMEBIGKPLK, string GHCKODPDBIH, OAGMENEMPGK GMDKJENIEGM, CJAMEBHEBPA JGLEFOOCPHJ, DOKKJHOINFL DFAMDFGEBKK, IMJJEFLFACH ADGDOGDAMOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7118500", Offset = "0x7116B00", VA = "0x187118500")]
	public object OFIOEEDHBGG(object? BHFGHGMPKOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D22ED0", Offset = "0x2D214D0", VA = "0x182D22ED0")]
	public void IEKDOJHFPJF<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7118450", Offset = "0x7116A50", VA = "0x187118450")]
	public void IEKDOJHFPJF(Type NHLCDNOMPON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CKIPEBAELAH<T> : PBHCEAIHGIF where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string JDMAPFJELJF(T DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T IFLCBKODDGF(string? ODJFDAFOPMB, T DNKAMNBGFFH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class PDCCGPFICGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public JDMAPFJELJF serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public IFLCBKODDGF parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public PDCCGPFICGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4799150", Offset = "0x4797750", VA = "0x184799150")]
		internal string HJPMHDMMJFA(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4798F40", Offset = "0x4797540", VA = "0x184798F40")]
		internal object DHFPJFNBGCL(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5498500", Offset = "0x5496B00", VA = "0x185498500")]
	public CKIPEBAELAH(OAGMENEMPGK GMDKJENIEGM, string GHCKODPDBIH, [Optional] JDMAPFJELJF? JGLEFOOCPHJ, [Optional] IFLCBKODDGF? DFAMDFGEBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x54972D0", Offset = "0x54958D0", VA = "0x1854972D0")]
	private static object? OJPHNAHFOOE(IFLCBKODDGF? DFAMDFGEBKK, string? ODJFDAFOPMB, object? DNKAMNBGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5497C70", Offset = "0x5496270", VA = "0x185497C70")]
	private static string PEGIGFCKLEH(JDMAPFJELJF? BLLKHOAILGM, object? DMNGPNKHPKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string CJAMEBHEBPA(object? DMNGPNKHPKF);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object DOKKJHOINFL(string? ODJFDAFOPMB, [Optional] object DNKAMNBGFFH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate COPFCMDBIIK IMJJEFLFACH();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class JEBBDKGGKGC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KJMPBJPMIDK : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static KJMPBJPMIDK CFNNMJAMDBB;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7115620", Offset = "0x7113C20", VA = "0x187115620", Slot = "4")]
		public bool Equals(List<string> OCPDJIJPMCG, List<string> DEKMKLPIHFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7115770", Offset = "0x7113D70", VA = "0x187115770", Slot = "5")]
		public int GetHashCode(List<string> NJKKPOFFNNJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public KJMPBJPMIDK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class ENNLDCFHLPM : PBMFLIALOCJ<LFLDJKKKNPO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x710C8F0", Offset = "0x710AEF0", VA = "0x18710C8F0", Slot = "9")]
		public override string PEGIGFCKLEH(LFLDJKKKNPO BNBKMKBLLLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x710C710", Offset = "0x710AD10", VA = "0x18710C710", Slot = "10")]
		protected override bool NAKMPOOCLOO(string BNBKMKBLLLG, [Out] LFLDJKKKNPO DMNGPNKHPKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x710C9E0", Offset = "0x710AFE0", VA = "0x18710C9E0")]
		public ENNLDCFHLPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly FOALBFCCLKN HEABNOPEPCL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly ENNLDCFHLPM LKFPJMFDGAO;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<PBHCEAIHGIF> HGHGAGEEKCD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<OAGMENEMPGK> CKOFDHOCONE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<OAGMENEMPGK, PBHCEAIHGIF> LKBDDFNIAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x71152D0", Offset = "0x71138D0", VA = "0x1871152D0")]
	public JEBBDKGGKGC([Optional] IList<PBHCEAIHGIF>? LDHHFGKCPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7113DB0", Offset = "0x71123B0", VA = "0x187113DB0")]
	public PBHCEAIHGIF CNKKNNINABL(OAGMENEMPGK GMDKJENIEGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CMKDIHKOMEB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PFNHDJHFHJF JMOPNADGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class DPEIDBHKCAB : CMKDIHKOMEB
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static DPEIDBHKCAB FHBKGODFMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly MEFOIHHKGFC JFKPMGDEJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<MEFOIHHKGFC> HDFJJPEPHNH;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PFNHDJHFHJF JMOPNADGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x710C600", Offset = "0x710AC00", VA = "0x18710C600")]
	public DPEIDBHKCAB(MEFOIHHKGFC PHLMPIGBKPP, IReadOnlyList<MEFOIHHKGFC> GCIGAFJLGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x710B7B0", Offset = "0x7109DB0", VA = "0x18710B7B0")]
	private static DPEIDBHKCAB IABIDKHBEGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class DNDOJOJMLNE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<JKKPOGCBEJM> KIDEDONGPLF;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x710B4A0", Offset = "0x7109AA0", VA = "0x18710B4A0")]
	public static bool ENHOBDBDLGH(this JMJBMOCBEJD KBPPKHIKFOD, JKKPOGCBEJM BBOPAHHLNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x710B580", Offset = "0x7109B80", VA = "0x18710B580")]
	public static bool NGMAGBADFAK(this JMJBMOCBEJD KBPPKHIKFOD, JKKPOGCBEJM BBOPAHHLNLP, MGIHEKMGJGG HFMFIGFMCGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface KHFNJLOCHKN
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool FPAIHFEFGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OOLIGOHPPEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BMAJFHEFOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool FLPMMONKJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MAEJKLOJCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool ENCJBCMPIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LGCIDMDKJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool LBFGGCDIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IAJDLGLDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BGBKCMOGAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EKMMIMLJMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HNGMBNKBGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> MBKCBBGDDON
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	LFLDJKKKNPO KIEMBKBAEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PFNHDJHFHJF : KHFNJLOCHKN, NCNAGHHBMIH, FAKDPCPMBGB<OAGMENEMPGK>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string DIBNKCEACKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JKKPOGCBEJM AJDOMPCMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) BOPGKMDMBCA<T>(OAGMENEMPGK GMDKJENIEGM) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum OAGMENEMPGK
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
	AUTO_ASSIGNED_PLAYER_TAGS = 24,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	CAN_USE_RRS = 25,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	ROOM_LEVEL_THRESHOLD = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	CAN_SAVE_ROOM = 1001,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	CAN_PUBLISH_ROOM = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	CAN_CLONE_ROOM = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	CAN_RESTORE_ROOM = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	CAN_EDIT_MAIN_ROOM_SETTINGS = 1006,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	CAN_EDIT_ROOM_ECON_SETTINGS = 1007,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	CAN_CREATE_SUBROOMS = 1008,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	CAN_NAME_SUBROOMS = 1009,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	CAN_CLONE_SUBROOMS = 1010,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	CAN_MOVE_SUBROOMS = 1011,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	CAN_DELETE_SUBROOMS = 1012,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	CAN_EDIT_SUBROOM_SETTINGS = 1013,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	CAN_RESET_CLOUD_VARIABLES = 1014,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	CAN_DELETE_CLOUD_VARIABLES = 1015,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	CAN_EDIT_ROOM_PROGRESSION = 1016,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	CAN_REMOVE_ROOM_BANS = 1017,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	CAN_ADD_ROOM_BANS = 1018
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class MEFOIHHKGFC : PFNHDJHFHJF, KHFNJLOCHKN, NCNAGHHBMIH, FAKDPCPMBGB<OAGMENEMPGK>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly JEBBDKGGKGC MPOAFFGFCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly HDJPOBKKDGI MDNBAHDKMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? JCIBDPPIFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? OJBJPPLNEHD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool PNAKDOIHDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7115EA0", Offset = "0x71144A0", VA = "0x187115EA0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool EJIGBJJJJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7116220", Offset = "0x7114820", VA = "0x187116220", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool AAACEBLPCAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7116570", Offset = "0x7114B70", VA = "0x187116570", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool ODKKMLLHJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71160A0", Offset = "0x71146A0", VA = "0x1871160A0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool OHCHGJDJHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7115E50", Offset = "0x7114450", VA = "0x187115E50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool EANNEHNCCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x71160F0", Offset = "0x71146F0", VA = "0x1871160F0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JKKPOGCBEJM AJDOMPCMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8E74D0", Offset = "0x8E5AD0", VA = "0x1808E74D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(JKKPOGCBEJM);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x869EA0", Offset = "0x8684A0", VA = "0x180869EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string NEOKPALKBEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7115FB0", Offset = "0x71145B0", VA = "0x187115FB0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x71162D0", Offset = "0x71148D0", VA = "0x1871162D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string DIBNKCEACKK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7115FB0", Offset = "0x71145B0", VA = "0x187115FB0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JNLEAPLDDOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA10B60", Offset = "0xA0F160", VA = "0x180A10B60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA102D0", Offset = "0xA0E8D0", VA = "0x180A102D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool FPAIHFEFGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x71173A0", Offset = "0x71159A0", VA = "0x1871173A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public LFLDJKKKNPO KIEMBKBAEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x71173F0", Offset = "0x71159F0", VA = "0x1871173F0", Slot = "20")]
		get
		{
			return default(LFLDJKKKNPO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool OOLIGOHPPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7115F40", Offset = "0x7114540", VA = "0x187115F40", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool BMAJFHEFOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7115990", Offset = "0x7113F90", VA = "0x187115990", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool FLPMMONKJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x71166C0", Offset = "0x7114CC0", VA = "0x1871166C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MAEJKLOJCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x71174E0", Offset = "0x7115AE0", VA = "0x1871174E0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ENCJBCMPIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7116670", Offset = "0x7114C70", VA = "0x187116670", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LGCIDMDKJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7116140", Offset = "0x7114740", VA = "0x187116140", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LBFGGCDIEIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7117440", Offset = "0x7115A40", VA = "0x187117440", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool IAJDLGLDHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7115EF0", Offset = "0x71144F0", VA = "0x187115EF0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> MBKCBBGDDON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7116270", Offset = "0x7114870", VA = "0x187116270", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool DJPLDLOBJOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7115EA0", Offset = "0x71144A0", VA = "0x187115EA0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool EGHNGLDJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7115E50", Offset = "0x7114450", VA = "0x187115E50", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool IEFICNNMKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7116220", Offset = "0x7114820", VA = "0x187116220", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool BGBKCMOGAKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7116050", Offset = "0x7114650", VA = "0x187116050", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool EKMMIMLJMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7116000", Offset = "0x7114600", VA = "0x187116000", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool LPJBDILOGEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7116570", Offset = "0x7114B70", VA = "0x187116570", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HNGMBNKBGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7117490", Offset = "0x7115A90", VA = "0x187117490", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PPPINNKKHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x71160A0", Offset = "0x71146A0", VA = "0x1871160A0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool AODCFEPIBOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x71160F0", Offset = "0x71146F0", VA = "0x1871160F0", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NEOLNBOJFIP<OAGMENEMPGK> LFABHBHOPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7116790", Offset = "0x7114D90", VA = "0x187116790", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x71165C0", Offset = "0x7114BC0", VA = "0x1871165C0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F720", Offset = "0x2C6DD20", VA = "0x182C6F720", Slot = "6")]
	public (bool, T?) BOPGKMDMBCA<T>(OAGMENEMPGK GMDKJENIEGM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C6F910", Offset = "0x2C6DF10", VA = "0x182C6F910")]
	public MEFOIHHKGFC LPEEINAJDEC<T>(OAGMENEMPGK GMDKJENIEGM, bool FADHMOCHILH, T DMNGPNKHPKF) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x71179F0", Offset = "0x7115FF0", VA = "0x1871179F0")]
	public MEFOIHHKGFC(JKKPOGCBEJM BBOPAHHLNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7117940", Offset = "0x7115F40", VA = "0x187117940")]
	public MEFOIHHKGFC(JKKPOGCBEJM BBOPAHHLNLP, [Optional] string? JCIBDPPIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7117960", Offset = "0x7115F60", VA = "0x187117960")]
	public MEFOIHHKGFC(MEFOIHHKGFC KLJGMNIDJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7117A10", Offset = "0x7116010", VA = "0x187117A10")]
	internal MEFOIHHKGFC(JKKPOGCBEJM NEKCDNBCBMC, [Optional] string? JCIBDPPIFIH, [Optional] MEFOIHHKGFC? KLJGMNIDJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7116710", Offset = "0x7114D10", VA = "0x187116710")]
	public static PHEAFPHFFEM JODFDPHMMIH(OAGMENEMPGK GMDKJENIEGM)
	{
		return default(PHEAFPHFFEM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7115F90", Offset = "0x7114590", VA = "0x187115F90")]
	public void BPNKMOIPBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7117530", Offset = "0x7115B30", VA = "0x187117530")]
	internal MEFOIHHKGFC PPGANAKKCAO(MEFOIHHKGFC DBJDLCJMJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x71159E0", Offset = "0x7113FE0", VA = "0x1871159E0")]
	internal IReadOnlyCollection<OAGMENEMPGK> AGJCCCHJIOG(MEFOIHHKGFC KLJGMNIDJCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7116940", Offset = "0x7114F40", VA = "0x187116940")]
	public bool KIENFKNJKCM(OAGMENEMPGK GMDKJENIEGM, bool FADHMOCHILH, string IKEMHKHAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7116840", Offset = "0x7114E40", VA = "0x187116840")]
	public (bool, string) KICAFHCCEPE(OAGMENEMPGK GMDKJENIEGM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7116320", Offset = "0x7114920", VA = "0x187116320")]
	internal void HKPLFFFDHBB(OAGMENEMPGK GMDKJENIEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7116370", Offset = "0x7114970", VA = "0x187116370")]
	public CNHPKGECNMI IBLOCMNLMCE(Func<JKKPOGCBEJM, Guid> BMHHPBGFAHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7116A20", Offset = "0x7115020", VA = "0x187116A20")]
	public void LMBHGKOOJLB(CNHPKGECNMI IGAHJCDBAAE, Func<Guid, JKKPOGCBEJM> PKNJPEBLFOD, [Optional] JKKPOGCBEJM? DIHMOOHJKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7116190", Offset = "0x7114790", VA = "0x187116190")]
	[CompilerGenerated]
	private void FCFAIGPALIF(OAGMENEMPGK KIGEPLEEGJP, MDMEICOBJLN HACNKCPPMAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JBCENOALPFH : DEAPBNGOOJP, IBABOCJFFBL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MCBFFBJAKCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public MEFOIHHKGFC newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public MCBFFBJAKCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7115960", Offset = "0x7113F60", VA = "0x187115960")]
		internal bool FFFDKDCKIAM(MEFOIHHKGFC rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class JAFGPDFGHPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public JKKPOGCBEJM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public JAFGPDFGHPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x710E250", Offset = "0x710C850", VA = "0x18710E250")]
		internal bool HAIMEJDMENE(JKKPOGCBEJM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct IFFIKFJBDKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public JBCENOALPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PIMCJABKION roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<OPAPIMGPOOD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x710D8F0", Offset = "0x710BEF0", VA = "0x18710D8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x710DF60", Offset = "0x710C560", VA = "0x18710DF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class IHCJBDPFJEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public IHCJBDPFJEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x710E0E0", Offset = "0x710C6E0", VA = "0x18710E0E0")]
		internal void BGLINGHMEIF(CNHPKGECNMI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x710DFC0", Offset = "0x710C5C0", VA = "0x18710DFC0")]
		internal void BDLBOMMALHI(CNHPKGECNMI r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct NGHIPMBICNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PIMCJABKION roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class INMGGJPLFIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<CNHPKGECNMI, MDMEICOBJLN> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public INMGGJPLFIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x710E1C0", Offset = "0x710C7C0", VA = "0x18710E1C0")]
		internal void ACOCNNNNCHC(CNHPKGECNMI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x710E1F0", Offset = "0x710C7F0", VA = "0x18710E1F0")]
		internal void CBMFDOGLMBF(CNHPKGECNMI r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x710E220", Offset = "0x710C820", VA = "0x18710E220")]
		internal void GLMKCIOCIJA(CNHPKGECNMI r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NKFDCAIADNK<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public NKFDCAIADNK<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<OPAPIMGPOOD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x35BC550", Offset = "0x35BAB50", VA = "0x1835BC550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA20370", Offset = "0xA1E970", VA = "0x180A20370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public OAGMENEMPGK rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public JKKPOGCBEJM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PHEAFPHFFEM recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public JBCENOALPFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public NKFDCAIADNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x45D2CD0", Offset = "0x45D12D0", VA = "0x1845D2CD0")]
		[AsyncStateMachine(typeof(NKFDCAIADNK<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void DKPPAGDJJFM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JMGEILEHNIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<DDNKOPFKNBM> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct AFHJBFOPGLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public HOMJDCHDLPH rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public PIMCJABKION roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<JKKPOGCBEJM, MEFOIHHKGFC> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public PKAMEBFLEIB debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x710A8D0", Offset = "0x7108ED0", VA = "0x18710A8D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x710B3E0", Offset = "0x71099E0", VA = "0x18710B3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HOMJDCHDLPH DMJMDNMOEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly DPEIDBHKCAB OJKFFGIAPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly PKAMEBFLEIB GAECPNEAIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, MEFOIHHKGFC> KMOHPAPBIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<JKKPOGCBEJM, MEFOIHHKGFC> IHFCEHGJMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<JKKPOGCBEJM, MEFOIHHKGFC> LHDJKJPEHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<MEFOIHHKGFC> PGJGJCFHJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool LICBEMPGIOI;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly OAGMENEMPGK[] DJMFHAKMDHP;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public CMKDIHKOMEB MKBDGCCHNPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<PFNHDJHFHJF> LLCOGLPCMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7110A70", Offset = "0x710F070", VA = "0x187110A70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event EPPDGMIKIAI BINPNOCJCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7110300", Offset = "0x710E900", VA = "0x187110300", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x710E720", Offset = "0x710CD20", VA = "0x18710E720", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x71108B0", Offset = "0x710EEB0", VA = "0x1871108B0")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Room, IAFNNCJJPGN.None)]
	private static void GMLBGNJNKIA(GLOPJKBGAFG FDLKLBHIAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7113AF0", Offset = "0x71120F0", VA = "0x187113AF0")]
	[UnityEngine.Scripting.Preserve]
	internal JBCENOALPFH([JAMCDGPOOBO(null)] HOMJDCHDLPH HKOCEDEHFLM, [JAMCDGPOOBO(null)] DPEIDBHKCAB MHFDHMLPFEI, [JAMCDGPOOBO(null)] PKAMEBFLEIB GAECPNEAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x71100E0", Offset = "0x710E6E0", VA = "0x1871100E0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x710F860", Offset = "0x710DE60", VA = "0x18710F860")]
	private void CGNGJBNJEGF(IEnumerable<MEFOIHHKGFC> DJPFJFGPDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7113850", Offset = "0x7111E50", VA = "0x187113850", Slot = "12")]
	public bool PGMAIOKJKGM(JMJBMOCBEJD AKBLJHNIFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x710E710", Offset = "0x710CD10", VA = "0x18710E710")]
	private void AJFJIFEGDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x710E7C0", Offset = "0x710CDC0", VA = "0x18710E7C0")]
	private void APOKFCGKDAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7111420", Offset = "0x710FA20", VA = "0x187111420", Slot = "10")]
	public IReadOnlyList<PFNHDJHFHJF> IBMCKECGDEJ(bool GLPHGEPBHHN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7110FE0", Offset = "0x710F5E0", VA = "0x187110FE0", Slot = "11")]
	public PFNHDJHFHJF HODGEAHGBCD(JMJBMOCBEJD AKBLJHNIFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7111860", Offset = "0x710FE60", VA = "0x187111860")]
	private JKKPOGCBEJM JFLBEPBHMGC(JMJBMOCBEJD AKBLJHNIFIE)
	{
		return default(JKKPOGCBEJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7110720", Offset = "0x710ED20", VA = "0x187110720", Slot = "14")]
	public bool FGBONMMCKKL(JMJBMOCBEJD HNDAEJLDHOG, JKKPOGCBEJM BBOPAHHLNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7111FD0", Offset = "0x71105D0", VA = "0x187111FD0", Slot = "15")]
	public PFNHDJHFHJF MGCPAHACJAB(JKKPOGCBEJM BBOPAHHLNLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x71110F0", Offset = "0x710F6F0", VA = "0x1871110F0")]
	private static bool HOOIMIPMIDL(FHGPEALOEIP OLPHAHMANEO, JKKPOGCBEJM BBOPAHHLNLP, [Out] CNHPKGECNMI? NJIBGOEDMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x71103A0", Offset = "0x710E9A0", VA = "0x1871103A0")]
	private static void FEACDEIBOPG(FHGPEALOEIP OLPHAHMANEO, Action<CNHPKGECNMI> HMEJMBJCGPN, JKKPOGCBEJM COMGGGGOJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7110490", Offset = "0x710EA90", VA = "0x187110490")]
	private static void FEACDEIBOPG(FHGPEALOEIP OLPHAHMANEO, Action<CNHPKGECNMI> HMEJMBJCGPN, Predicate<JKKPOGCBEJM> CNKEMOOPECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x71117F0", Offset = "0x710FDF0", VA = "0x1871117F0")]
	private void JELLMMILMKN(JMJBMOCBEJD AKBLJHNIFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x710E5F0", Offset = "0x710CBF0", VA = "0x18710E5F0", Slot = "4")]
	[AsyncStateMachine(typeof(IFFIKFJBDKC))]
	public Task AHEKMABLOGH([CanBeNull] PIMCJABKION FPDNBDDHMAO, CancellationToken FIMAIPEFOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
	public void OFGJNGHLFFP(PIMCJABKION FPDNBDDHMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7111C90", Offset = "0x7110290", VA = "0x187111C90")]
	private void LIHPIDFECJE(FHGPEALOEIP JOIOMEEAALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7112AA0", Offset = "0x71110A0", VA = "0x187112AA0")]
	internal static string OCEKPGLGOGB(HOMJDCHDLPH DMJMDNMOEPE, PIMCJABKION FPDNBDDHMAO, IReadOnlyDictionary<JKKPOGCBEJM, MEFOIHHKGFC> IHFCEHGJMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x710E9B0", Offset = "0x710CFB0", VA = "0x18710E9B0")]
	private static void BHOECJLOODF(PIMCJABKION FPDNBDDHMAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7113500", Offset = "0x7111B00", VA = "0x187113500")]
	private static void ONNMLEMFDCN(FHGPEALOEIP EMBHEEPICCO, IReadOnlyDictionary<JKKPOGCBEJM, MEFOIHHKGFC> IHFCEHGJMLI, StringBuilder GIBMIBKGLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x71101F0", Offset = "0x710E7F0", VA = "0x1871101F0")]
	private static bool ECGLCLELPLE(string PLFFDOKAEOF, [Out] Guid JAACHPICPPC, [Out] JKKPOGCBEJM BBOPAHHLNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7112DB0", Offset = "0x71113B0", VA = "0x187112DB0")]
	private static void OIBOPCAJOPB(PIMCJABKION FPDNBDDHMAO, StringBuilder GIBMIBKGLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2BF1B60", Offset = "0x2BF0160", VA = "0x182BF1B60", Slot = "16")]
	public bool FKCMIKABCJK<T>(JKKPOGCBEJM BBOPAHHLNLP, OAGMENEMPGK GMDKJENIEGM, bool FADHMOCHILH, T CIFNGMCMOJD, [Optional] Action JLMINPEABMO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x710F7E0", Offset = "0x710DDE0", VA = "0x18710F7E0", Slot = "17")]
	public string CDCEHDIKFDD(OAGMENEMPGK GMDKJENIEGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x71114A0", Offset = "0x710FAA0", VA = "0x1871114A0")]
	private void IMFGFIPKEKO(JKKPOGCBEJM BBOPAHHLNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x710E260", Offset = "0x710C860", VA = "0x18710E260")]
	private bool AAGBOJKJILK(JMJBMOCBEJD AKBLJHNIFIE, JKKPOGCBEJM BBOPAHHLNLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7111930", Offset = "0x710FF30", VA = "0x187111930")]
	internal MEFOIHHKGFC KMPKOIGJDMA(JMJBMOCBEJD AKBLJHNIFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7111C80", Offset = "0x7110280", VA = "0x187111C80", Slot = "13")]
	public IReadOnlyList<PFNHDJHFHJF> LAMNIPGPPIC(JMJBMOCBEJD AKBLJHNIFIE, bool DDDHFNFHLCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7110AC0", Offset = "0x710F0C0", VA = "0x187110AC0")]
	internal IReadOnlyList<MEFOIHHKGFC> HBBOOLJLABO(JMJBMOCBEJD AKBLJHNIFIE, bool DDDHFNFHLCO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7112070", Offset = "0x7110670", VA = "0x187112070")]
	private void MOALMBFLHJI(OPAPIMGPOOD KBLLLBFJMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7110CF0", Offset = "0x710F2F0", VA = "0x187110CF0")]
	private static bool HDFOJFPFGID(MEFOIHHKGFC FOHPPJBBMEN, IReadOnlyDictionary<JKKPOGCBEJM, MEFOIHHKGFC> IHFCEHGJMLI, [Out] IReadOnlyList<OAGMENEMPGK> AGGDNBPKNDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x71116B0", Offset = "0x710FCB0", VA = "0x1871116B0")]
	[AsyncStateMachine(typeof(AFHJBFOPGLO))]
	private static Task JBCNJBICFKH(HOMJDCHDLPH DMJMDNMOEPE, PIMCJABKION FPDNBDDHMAO, IReadOnlyDictionary<JKKPOGCBEJM, MEFOIHHKGFC> IHFCEHGJMLI, PKAMEBFLEIB GAECPNEAIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7112800", Offset = "0x7110E00", VA = "0x187112800")]
	[CompilerGenerated]
	internal static void NCIEEGCPKAH(Func<CNHPKGECNMI, MDMEICOBJLN> HBAIHLNBPHA, NGHIPMBICNO P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x710E280", Offset = "0x710C880", VA = "0x18710E280")]
	[CompilerGenerated]
	internal static bool ACLPILLGAGK(JKKPOGCBEJM BBOPAHHLNLP, OAGMENEMPGK GMDKJENIEGM, [Out] DDNKOPFKNBM LPBJGLHDOAG, JMGEILEHNIK P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HJCMJEDAAKB
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MHELMKOLEMN(JMJBMOCBEJD KBFGCFOPFIJ, JMJBMOCBEJD FCAFPENJFCF, IEnumerable<JMJBMOCBEJD> BFCMJPLAFMP, [Out] LFLDJKKKNPO AIMAPDPCICI, [Out] IGHPIONAFJP ENONEAIIIKF);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HELFEOMNLBC(IGHPIONAFJP JEANHAFFGIF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum IGHPIONAFJP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class NOOJGFEHADI : HJCMJEDAAKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly IBABOCJFFBL JNEFNEHDKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly DIBCAIPHIHA CIHDICMDMJE;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x872E80", Offset = "0x871480", VA = "0x180872E80")]
	[RecRoom.NoEngine.Common.Preserve]
	public NOOJGFEHADI([JAMCDGPOOBO(null)] IBABOCJFFBL AMNAFLHGLNN, [JAMCDGPOOBO(null)] DIBCAIPHIHA MGPNHAFPLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7118390", Offset = "0x7116990", VA = "0x187118390")]
	private static FEGBOHBKPGB? OIHLKBOPJNA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7117C70", Offset = "0x7116270", VA = "0x187117C70", Slot = "4")]
	public bool MHELMKOLEMN(JMJBMOCBEJD KBFGCFOPFIJ, JMJBMOCBEJD FCAFPENJFCF, IEnumerable<JMJBMOCBEJD> BFCMJPLAFMP, [Out] LFLDJKKKNPO AIMAPDPCICI, [Out] IGHPIONAFJP ENONEAIIIKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7117B70", Offset = "0x7116170", VA = "0x187117B70", Slot = "5")]
	public string HELFEOMNLBC(IGHPIONAFJP JEANHAFFGIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7117D70", Offset = "0x7116370", VA = "0x187117D70")]
	internal bool MJPICMMOEOP(JMJBMOCBEJD KBFGCFOPFIJ, JMJBMOCBEJD FCAFPENJFCF, IEnumerable<JMJBMOCBEJD> BFCMJPLAFMP, MGIHEKMGJGG HFMFIGFMCGO, FEGBOHBKPGB? GHHLNFAHPFJ, [Out] LFLDJKKKNPO AIMAPDPCICI, [Out] IGHPIONAFJP ENONEAIIIKF)
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
