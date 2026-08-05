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
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RecRoom.ObjectModel;
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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86165D0", Offset = "0x8614FD0", VA = "0x1886165D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum ADDNHFOLEPE
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
namespace _AssemblyRegistry.RecRoom_RoomPermissions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8619DF0", Offset = "0x86187F0", VA = "0x188619DF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NEGFLCGAEFH<TPermission>(TPermission JPCKBPIBNCM);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void IHKENFJLDOL(GBDECDHLMJN KPIDJKLDGJJ);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public enum FNLHPJBDJHO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CIGILBBGDNF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DNDJEGCAKOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool HFGGBHLHELE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PCEIFKFKJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AECCABOLGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool OBPFFNNNBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MJAPPHPNEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class HLCLKCHNFKN
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum NNKFBCLIMGL
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
	public static readonly Guid NDFHIBKPKPD;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid HAHOAIKGDDE;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid CMNEEIGKFMM;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid APEDDFMDACI;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid PKPKHPLJILC;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid BLFNDCCCJED;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly OIPLMHOGNKE<IIOJHPILAFO, Guid> AJPIPMAMCOJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<IIOJHPILAFO> JIHMHCNIKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x860C7D0", Offset = "0x860B1D0", VA = "0x18860C7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x860CA10", Offset = "0x860B410", VA = "0x18860CA10")]
	public static IIOJHPILAFO NLCJGJEJDJN(Guid FNKCCICOAII)
	{
		return default(IIOJHPILAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x860C970", Offset = "0x860B370", VA = "0x18860C970")]
	public static Guid DJMJJHFBOPO(IIOJHPILAFO KDHNLBMMLGO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x860C840", Offset = "0x860B240", VA = "0x18860C840")]
	public static bool BCPJOOGJBJP(IIOJHPILAFO KDHNLBMMLGO, [Out] Guid FNKCCICOAII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x860C8D0", Offset = "0x860B2D0", VA = "0x18860C8D0")]
	public static bool DBDBDCBFIAB(Guid FNKCCICOAII, [Out] IIOJHPILAFO KDHNLBMMLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x860CB50", Offset = "0x860B550", VA = "0x18860CB50")]
	public static IIOJHPILAFO ONMNFODJGDH(IIOJHPILAFO KDHNLBMMLGO)
	{
		return default(IIOJHPILAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x860CAA0", Offset = "0x860B4A0", VA = "0x18860CAA0")]
	public static NNKFBCLIMGL OGCAMIFMDLO(IIOJHPILAFO AIDAJBEBAPH)
	{
		return default(NNKFBCLIMGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x860C790", Offset = "0x860B190", VA = "0x18860C790")]
	internal static IIOJHPILAFO AJKODGEICPG(NNKFBCLIMGL JHCOGIFJLGN)
	{
		return default(IIOJHPILAFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EAKJPCNPLGN
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GBDECDHLMJN IGOAGANFOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AKIBJNGPBHA IILAHPGEJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PFLGPOLCCPC LPDLHGOEIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KADDNIPNJBK> GFKNIEJAGIL;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JNLBNDOJMKM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IIOJHPILAFO FBIIDOMCEIP(GBDECDHLMJN KPIDJKLDGJJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KADDNIPNJBK> GCKKDHGEIGN(CancellationToken JKPNCAGHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task PEBGCNOCGAG(long FHOIPEIAACP, IReadOnlyList<IEEEACPCPDD> EEGAECLJDLA);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task HGGOBGJMGKB(long FHOIPEIAACP, long IIHAMPMIGID, IReadOnlyList<IEEEACPCPDD> EEGAECLJDLA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<GBDECDHLMJN> BADAMLGMPBJ();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class LAMAHBMJJID
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8616570", Offset = "0x8614F70", VA = "0x188616570")]
	public static IIOJHPILAFO LOIFDFIHLHN(this EAKJPCNPLGN CCABEEJMCIN)
	{
		return default(IIOJHPILAFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[ServiceLifetime(Lifetime.PhotonRoom)]
public interface IHPPOLLEOED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	POGNDEIKJPP OCLGINDNDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event IHKENFJLDOL GAEFEPKFNAC;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<PIIAMIGEOBL> FOJKNNJKPAP(bool FMFPEBGIJBG = false);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PIIAMIGEOBL HBDBKGNOOFG(GBDECDHLMJN KPIDJKLDGJJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AKJNFFEDMAE(GBDECDHLMJN KPIDJKLDGJJ);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IReadOnlyList<PIIAMIGEOBL> OPCJGODGGCI(GBDECDHLMJN KPIDJKLDGJJ, bool IPOBFOBBJIG = false);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EBAJKOMOPKH(GBDECDHLMJN GMFFMAODLEF, IIOJHPILAFO KDHNLBMMLGO);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PIIAMIGEOBL CAALPKKOAGD(IIOJHPILAFO KDHNLBMMLGO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FOPLDPMOBFA<T>(IIOJHPILAFO KDHNLBMMLGO, INJPECNJBDL JPCKBPIBNCM, bool JFPNIBPHEBA, T EFPDHJCEEGP, [Optional] Action AJKINJLLNIE) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "10")]
	string ILHIDBNLMNG(INJPECNJBDL JPCKBPIBNCM);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MAIJIKFNFAA(GBDECDHLMJN KPIDJKLDGJJ, INJPECNJBDL LDDOPCFAHOI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BEHKNOEKDKO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task MBBODEEFFJH(BGHEHCDAEKD NIAPBNPEIPM, CancellationToken JKPNCAGHEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HJBGBBFHJOP<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string ECAKDIHBBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NEGFLCGAEFH<TPermission> GCFNHPIMIAM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal abstract class IHDAJOMIDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal object? LMDHNHDPMKM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public object? AJLJLFFBIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x860CEB0", Offset = "0x860B8B0", VA = "0x18860CEB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x860CF90", Offset = "0x860B990", VA = "0x18860CF90")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x860D090", Offset = "0x860BA90", VA = "0x18860D090")]
	protected IHDAJOMIDIM(object? KDMOHPEIIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool HIKLPLIFDEP(object? PCDAHJCDHHF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class PGLOCHKCGFA<T> : IHDAJOMIDIM where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly IEqualityComparer<T> CHDLIFCANLJ;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5763C00", Offset = "0x5762600", VA = "0x185763C00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5763870", Offset = "0x5762270", VA = "0x185763870", Slot = "4")]
	public override bool HIKLPLIFDEP(object? PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5763FC0", Offset = "0x57629C0", VA = "0x185763FC0")]
	public bool MEABFLOBIJM(T IAIDEAFEPNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5764530", Offset = "0x5762F30", VA = "0x185764530")]
	public PGLOCHKCGFA(T ALKDPGOIFPD, IEqualityComparer<T> CHDLIFCANLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KAFGOOJOJBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly Dictionary<INJPECNJBDL, bool> CCCDIJGLBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<INJPECNJBDL, IHDAJOMIDIM> MJDICHPGAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IPHJNIMGEPC OMAFELDECML;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8615FC0", Offset = "0x86149C0", VA = "0x188615FC0")]
	public KAFGOOJOJBO(IPHJNIMGEPC OMAFELDECML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8615F50", Offset = "0x8614950", VA = "0x188615F50")]
	public bool OCCKAFKDGEE(INJPECNJBDL JPCKBPIBNCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD840", Offset = "0x3AFC240", VA = "0x183AFD840")]
	public bool BFPCDPMMDIG<T>(INJPECNJBDL JPCKBPIBNCM, bool JFPNIBPHEBA, T PCDAHJCDHHF) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3AFD470", Offset = "0x3AFBE70", VA = "0x183AFD470")]
	public (bool, T?) AGJPJEAKMLI<T>(INJPECNJBDL JPCKBPIBNCM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8615DA0", Offset = "0x86147A0", VA = "0x188615DA0")]
	public bool BFPCDPMMDIG(INJPECNJBDL JPCKBPIBNCM, bool JFPNIBPHEBA, object PCDAHJCDHHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8615A10", Offset = "0x8614410", VA = "0x188615A10")]
	public (bool, object) AGJPJEAKMLI(INJPECNJBDL JPCKBPIBNCM)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDD50", Offset = "0x3AFC750", VA = "0x183AFDD50")]
	private void HJJHHGAEELB<T>(INJPECNJBDL JPCKBPIBNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8615E80", Offset = "0x8614880", VA = "0x188615E80")]
	private IHDAJOMIDIM GKIGOIOIAJL(INJPECNJBDL JPCKBPIBNCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8615BB0", Offset = "0x86145B0", VA = "0x188615BB0")]
	public void AIIBOHJPOHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class OIMIJBHJIIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public readonly string PLIMLAHDBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly Type MNMBHIABCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly BNFHPGPPHLN GKGGPNGEJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly INJPECNJBDL GGBIJDPLOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public LIMENGCOBPK ENAFNKAGGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public HPAGKJKGPMG HFJCDOHGGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public JBELGFJPHLO NCMCHKJCPCD;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8616750", Offset = "0x8615150", VA = "0x188616750")]
	public OIMIJBHJIIK(Type JLCPOFFCMMJ, string AHDGJCPPJHB, INJPECNJBDL JPCKBPIBNCM, LIMENGCOBPK NPAAHJKMKIC, HPAGKJKGPMG MNDFOBLJKBI, JBELGFJPHLO NOCDEIHKFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8616700", Offset = "0x8615100", VA = "0x188616700")]
	public object LEDICOFHJLI(object? NDNHELJMDCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3BFBBD0", Offset = "0x3BFA5D0", VA = "0x183BFBBD0")]
	public void HJJHHGAEELB<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8616650", Offset = "0x8615050", VA = "0x188616650")]
	public void HJJHHGAEELB(Type IHGFIOGCEGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class FNPCNECLHNH<T> : OIMIJBHJIIK where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate string AFPDMPDFAIM(T PCDAHJCDHHF);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal delegate T FMMJMKKFHLO(string? NLLMNIMJNDL, T ALKDPGOIFPD);

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class GLEMAHBPECE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AFPDMPDFAIM serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FMMJMKKFHLO parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public GLEMAHBPECE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4C83320", Offset = "0x4C81D20", VA = "0x184C83320")]
		internal string HKNPEBJEBAB(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4C83440", Offset = "0x4C81E40", VA = "0x184C83440")]
		internal object OKHOIGIFEDD(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4B5D7D0", Offset = "0x4B5C1D0", VA = "0x184B5D7D0")]
	public FNPCNECLHNH(INJPECNJBDL JPCKBPIBNCM, string AHDGJCPPJHB, [Optional] AFPDMPDFAIM? NPAAHJKMKIC, [Optional] FMMJMKKFHLO? MNDFOBLJKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4B5C1C0", Offset = "0x4B5ABC0", VA = "0x184B5C1C0")]
	private static object? PGEPBAPICDN(FMMJMKKFHLO? MNDFOBLJKBI, string? NLLMNIMJNDL, object? ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4B5CF30", Offset = "0x4B5B930", VA = "0x184B5CF30")]
	private static string PGPOMLMDCHO(AFPDMPDFAIM? ALAKLIJLBBG, object? PCDAHJCDHHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate string LIMENGCOBPK(object? PCDAHJCDHHF);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate object HPAGKJKGPMG(string? NLLMNIMJNDL, [Optional] object ALKDPGOIFPD);
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal delegate IHDAJOMIDIM JBELGFJPHLO();
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal class IPHJNIMGEPC
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class HGLLIBLBGLM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		internal static HGLLIBLBGLM FDCAMNOGINK;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x860C460", Offset = "0x860AE60", VA = "0x18860C460", Slot = "4")]
		public bool Equals(List<string> CBPCNABIALH, List<string> CBOHEKOGGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x860C5B0", Offset = "0x860AFB0", VA = "0x18860C5B0", Slot = "5")]
		public int GetHashCode(List<string> OJDHMKOBKLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HGLLIBLBGLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	private class KCJJGAMOBKO : ECGDEBMFEJP<ADDNHFOLEPE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8616440", Offset = "0x8614E40", VA = "0x188616440", Slot = "9")]
		public override string PGPOMLMDCHO(ADDNHFOLEPE OKFHNJPHDOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8616270", Offset = "0x8614C70", VA = "0x188616270", Slot = "10")]
		protected override bool DAGDAPHHHDL(string OKFHNJPHDOP, [Out] ADDNHFOLEPE PCDAHJCDHHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8616530", Offset = "0x8614F30", VA = "0x188616530")]
		public KCJJGAMOBKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly KMIBHPHHBID BLIOFCAMIGK;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly KCJJGAMOBKO EJKCDHFBAIC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private static readonly List<OIMIJBHJIIK> OKAAHIBIIOF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<INJPECNJBDL> ONJBCKMIIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IReadOnlyDictionary<INJPECNJBDL, OIMIJBHJIIK> NGDLPIPADDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x860EFD0", Offset = "0x860D9D0", VA = "0x18860EFD0")]
	public IPHJNIMGEPC([Optional] IList<OIMIJBHJIIK>? FPOLEMINLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x860D1A0", Offset = "0x860BBA0", VA = "0x18860D1A0")]
	public OIMIJBHJIIK LEPLOPLDPLP(INJPECNJBDL JPCKBPIBNCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface POGNDEIKJPP
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	PIIAMIGEOBL IGOMGELPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class PEKAHGDGJLI : POGNDEIKJPP
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static PEKAHGDGJLI EFLOMICBMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly PNAGJONGCHL CEEEPCCNHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly IReadOnlyList<PNAGJONGCHL> LHAEMCHPCBF;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public PIIAMIGEOBL IGOMGELPEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x86178D0", Offset = "0x86162D0", VA = "0x1886178D0")]
	public PEKAHGDGJLI(PNAGJONGCHL IHALIGNBLJP, IReadOnlyList<PNAGJONGCHL> LKGOHBJMKID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x86167F0", Offset = "0x86151F0", VA = "0x1886167F0")]
	private static PEKAHGDGJLI EGHEHGGIEMD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class GEGAGHDJKLM
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<IIOJHPILAFO> KPPMFICNEJJ;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x860C1E0", Offset = "0x860ABE0", VA = "0x18860C1E0")]
	public static bool IEONIBLIPOD(this GBDECDHLMJN IKJHHAOIKGK, IIOJHPILAFO KDHNLBMMLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x860C160", Offset = "0x860AB60", VA = "0x18860C160")]
	public static bool ACIJBFEGDNJ(this GBDECDHLMJN IKJHHAOIKGK, IIOJHPILAFO KDHNLBMMLGO, PFLGPOLCCPC NENGKGBFHCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FALJMEBPHAP
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<string> NCKPCLLGGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	ADDNHFOLEPE PKCEBNMDKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PIIAMIGEOBL : FALJMEBPHAP, CIGILBBGDNF, HJBGBBFHJOP<INJPECNJBDL>
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string NKFKOJHJPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IIOJHPILAFO FDKJJGFMNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) ELGCDBGMEBF<T>(INJPECNJBDL JPCKBPIBNCM) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal class PNAGJONGCHL : PIIAMIGEOBL, FALJMEBPHAP, CIGILBBGDNF, HJBGBBFHJOP<INJPECNJBDL>
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal static readonly IPHJNIMGEPC MKJFDHFOHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal readonly KAFGOOJOJBO LPAAEIJJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private string? OJBDIJENLCO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private bool CLBIAJBGIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8617C30", Offset = "0x8616630", VA = "0x188617C30", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool IHADLDACBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8618C10", Offset = "0x8617610", VA = "0x188618C10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private bool PDMPAIIPDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8617AE0", Offset = "0x86164E0", VA = "0x188617AE0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool LJPKLFFBIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8617C80", Offset = "0x8616680", VA = "0x188617C80", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool LOAMEIMBNIM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8618B10", Offset = "0x8617510", VA = "0x188618B10", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool AKDOOAFGIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8617CD0", Offset = "0x86166D0", VA = "0x188617CD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IIOJHPILAFO FDKJJGFMNNK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA62AE0", Offset = "0xA614E0", VA = "0x180A62AE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(IIOJHPILAFO);
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA129F0", Offset = "0xA113F0", VA = "0x180A129F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string ECAKDIHBBMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8617A90", Offset = "0x8616490", VA = "0x188617A90", Slot = "17")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string NKFKOJHJPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8617A90", Offset = "0x8616490", VA = "0x188617A90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EJOPICMPENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA38610", Offset = "0xA37010", VA = "0x180A38610")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36D90", VA = "0x180A38390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ADDNHFOLEPE PKCEBNMDKGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8618B60", Offset = "0x8617560", VA = "0x188618B60", Slot = "8")]
		get
		{
			return default(ADDNHFOLEPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IReadOnlyList<string> NCKPCLLGGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8618BB0", Offset = "0x86175B0", VA = "0x188618BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool MBPPKABEMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8617C30", Offset = "0x8616630", VA = "0x188617C30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public bool EACDKNNLEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8618B10", Offset = "0x8617510", VA = "0x188618B10", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HBCLFHCHEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8618C10", Offset = "0x8617610", VA = "0x188618C10", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool FJMDLJALJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8617AE0", Offset = "0x86164E0", VA = "0x188617AE0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool HEHJPLANFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8617C80", Offset = "0x8616680", VA = "0x188617C80", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool GLGGKDFLJML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8617CD0", Offset = "0x86166D0", VA = "0x188617CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NEGFLCGAEFH<INJPECNJBDL> GCFNHPIMIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8619370", Offset = "0x8617D70", VA = "0x188619370", Slot = "15")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8618A60", Offset = "0x8617460", VA = "0x188618A60", Slot = "16")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3C29BE0", Offset = "0x3C285E0", VA = "0x183C29BE0", Slot = "6")]
	public (bool, T?) ELGCDBGMEBF<T>(INJPECNJBDL JPCKBPIBNCM) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C29BA0", Offset = "0x3C285A0", VA = "0x183C29BA0")]
	public PNAGJONGCHL DOONCLMIOFD<T>(INJPECNJBDL JPCKBPIBNCM, bool JFPNIBPHEBA, T PCDAHJCDHHF) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8619670", Offset = "0x8618070", VA = "0x188619670")]
	public PNAGJONGCHL(IIOJHPILAFO KDHNLBMMLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x86194A0", Offset = "0x8617EA0", VA = "0x1886194A0")]
	public PNAGJONGCHL(IIOJHPILAFO KDHNLBMMLGO, [Optional] string? OJBDIJENLCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x86195F0", Offset = "0x8617FF0", VA = "0x1886195F0")]
	public PNAGJONGCHL(PNAGJONGCHL MDFBNEAGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x86194C0", Offset = "0x8617EC0", VA = "0x1886194C0")]
	internal PNAGJONGCHL(IIOJHPILAFO GCJCHEPOCAE, [Optional] string? OJBDIJENLCO, [Optional] PNAGJONGCHL? MDFBNEAGBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8618880", Offset = "0x8617280", VA = "0x188618880")]
	public static BNFHPGPPHLN FKCBIIPFHJJ(INJPECNJBDL JPCKBPIBNCM)
	{
		return default(BNFHPGPPHLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8617A70", Offset = "0x8616470", VA = "0x188617A70")]
	public void AIIBOHJPOHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8619080", Offset = "0x8617A80", VA = "0x188619080")]
	internal PNAGJONGCHL MGGDHBOJBCN(PNAGJONGCHL IMJOOIIBDEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8618C60", Offset = "0x8617660", VA = "0x188618C60")]
	internal IReadOnlyCollection<INJPECNJBDL> LKOOONLLMMI(PNAGJONGCHL MDFBNEAGBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x86188F0", Offset = "0x86172F0", VA = "0x1886188F0")]
	public bool GFJNADKKLMK(INJPECNJBDL JPCKBPIBNCM, bool JFPNIBPHEBA, string FOEHOBCGPKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8617B30", Offset = "0x8616530", VA = "0x188617B30")]
	public (bool, string) DHDKAKGMHOD(INJPECNJBDL JPCKBPIBNCM)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x8619030", Offset = "0x8617A30", VA = "0x188619030")]
	internal void LNPMNNCJFNL(INJPECNJBDL JPCKBPIBNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x8618680", Offset = "0x8617080", VA = "0x188618680")]
	public OCMONAANEPK FGPGBIKONNA(Func<IIOJHPILAFO, Guid> MLEEEGCHADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8617D20", Offset = "0x8616720", VA = "0x188617D20")]
	public void FAGIFFCNLBJ(OCMONAANEPK NEHFJGIDMBF, Func<Guid, IIOJHPILAFO> JEFLHKIEHCC, [Optional] IIOJHPILAFO? PACFDAIBNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x86189D0", Offset = "0x86173D0", VA = "0x1886189D0")]
	[CompilerGenerated]
	private void HJJIGGBNDGE(INJPECNJBDL LDDOPCFAHOI, GIOJJCKJBHP IMOCILDOLCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class JJEBHLFLHCA : BEHKNOEKDKO, IHPPOLLEOED, IDisposable, GOBDJDKJDPM
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class HOJGGOOFBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public PNAGJONGCHL newRole;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public HOJGGOOFBLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x860CE80", Offset = "0x860B880", VA = "0x18860CE80")]
		internal bool GBFGCPHBNFM(PNAGJONGCHL rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class DJCOABJEMFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public IIOJHPILAFO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public DJCOABJEMFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E890", Offset = "0x1D5D290", VA = "0x181D5E890")]
		internal bool INFHICALOKD(IIOJHPILAFO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct ACBMCFBAHNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public JJEBHLFLHCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public BGHEHCDAEKD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<KADDNIPNJBK> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x860B030", Offset = "0x8609A30", VA = "0x18860B030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x860B6A0", Offset = "0x860A0A0", VA = "0x18860B6A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FGCFJPPBDEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public FGCFJPPBDEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x860BF60", Offset = "0x860A960", VA = "0x18860BF60")]
		internal void GCHHABIHKFL(OCMONAANEPK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x860C040", Offset = "0x860AA40", VA = "0x18860C040")]
		internal void PLDMHPCBONP(OCMONAANEPK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PIAEJAACEDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public BGHEHCDAEKD roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PLNBDKCEFKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Func<OCMONAANEPK, GIOJJCKJBHP> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public PLNBDKCEFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8617A10", Offset = "0x8616410", VA = "0x188617A10")]
		internal void KPNLGCLJKFE(OCMONAANEPK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x86179E0", Offset = "0x86163E0", VA = "0x1886179E0")]
		internal void IKJPOICDCBG(OCMONAANEPK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8617A40", Offset = "0x8616440", VA = "0x188617A40")]
		internal void LGEPCJGAAHO(OCMONAANEPK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EFBMHAMOFBJ<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public EFBMHAMOFBJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private TaskAwaiter<KADDNIPNJBK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x42366C0", Offset = "0x42350C0", VA = "0x1842366C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public INJPECNJBDL rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public IIOJHPILAFO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public BNFHPGPPHLN recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public JJEBHLFLHCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public EFBMHAMOFBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4690460", Offset = "0x468EE60", VA = "0x184690460")]
		[AsyncStateMachine(typeof(EFBMHAMOFBJ<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void FMOMLNOOBFL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JENEPBFPOOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public IReadOnlyList<IEEEACPCPDD> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JKPIDDAPAMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public EAKJPCNPLGN rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BGHEHCDAEKD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public IReadOnlyDictionary<IIOJHPILAFO, PNAGJONGCHL> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HEILNANPDJC debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8614E90", Offset = "0x8613890", VA = "0x188614E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x86159B0", Offset = "0x86143B0", VA = "0x1886159B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly EAKJPCNPLGN CCABEEJMCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PEKAHGDGJLI MAJBNJACLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HEILNANPDJC MNPKNCJLCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly Dictionary<int, PNAGJONGCHL> HPLEDLGMFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly Dictionary<IIOJHPILAFO, PNAGJONGCHL> FMJMGILBACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal readonly Dictionary<IIOJHPILAFO, PNAGJONGCHL> ELCMPIHPEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly List<PNAGJONGCHL> OKOIKHGHOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool KIIEFONHECJ;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly INJPECNJBDL[] FADEHGKGGPC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public POGNDEIKJPP OCLGINDNDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event IHKENFJLDOL GAEFEPKFNAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8611530", Offset = "0x860FF30", VA = "0x188611530", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8613DA0", Offset = "0x86127A0", VA = "0x188613DA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x8613530", Offset = "0x8611F30", VA = "0x188613530")]
	[CGLGNCLDKHN.DPDEAPAPLBM]
	internal static void JGOIPALGEOO(MHGNCMHMEKD OHEABDJLGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8614BD0", Offset = "0x86135D0", VA = "0x188614BD0")]
	[UnityEngine.Scripting.Preserve]
	internal JJEBHLFLHCA([CNHMBDDCGKB(null)] EAKJPCNPLGN IPFDBCNPPDA, [CNHMBDDCGKB(null)] PEKAHGDGJLI BBHMJFFOEAO, [CNHMBDDCGKB(null)] HEILNANPDJC MNPKNCJLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x86115D0", Offset = "0x860FFD0", VA = "0x1886115D0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x8612670", Offset = "0x8611070", VA = "0x188612670")]
	private void FGCJGNDGPDI(IEnumerable<PNAGJONGCHL> OHIGAJLGPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x860F2F0", Offset = "0x860DCF0", VA = "0x18860F2F0", Slot = "10")]
	public bool AKJNFFEDMAE(GBDECDHLMJN KPIDJKLDGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8613A60", Offset = "0x8612460", VA = "0x188613A60")]
	private void JNLBNDOJMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8613100", Offset = "0x8611B00", VA = "0x188613100")]
	private void GIMKCGEIDBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8613080", Offset = "0x8611A80", VA = "0x188613080", Slot = "8")]
	public IReadOnlyList<PIIAMIGEOBL> FOJKNNJKPAP(bool FMFPEBGIJBG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x86132E0", Offset = "0x8611CE0", VA = "0x1886132E0", Slot = "9")]
	public PIIAMIGEOBL HBDBKGNOOFG(GBDECDHLMJN KPIDJKLDGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8613460", Offset = "0x8611E60", VA = "0x188613460")]
	private IIOJHPILAFO JEBGBHANEBB(GBDECDHLMJN KPIDJKLDGJJ)
	{
		return default(IIOJHPILAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x86116E0", Offset = "0x86100E0", VA = "0x1886116E0", Slot = "12")]
	public bool EBAJKOMOPKH(GBDECDHLMJN GMFFMAODLEF, IIOJHPILAFO KDHNLBMMLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x860F900", Offset = "0x860E300", VA = "0x18860F900", Slot = "13")]
	public PIIAMIGEOBL CAALPKKOAGD(IIOJHPILAFO KDHNLBMMLGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8613A70", Offset = "0x8612470", VA = "0x188613A70")]
	private static bool KJDLIBKAEHN(LPKALDMBNCN DLPMNPBGMII, IIOJHPILAFO KDHNLBMMLGO, [Out] OCMONAANEPK? NKLONNOFONH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x86122F0", Offset = "0x8610CF0", VA = "0x1886122F0")]
	private static void FFPDHCHPNNK(LPKALDMBNCN DLPMNPBGMII, Action<OCMONAANEPK> JLPKHPDMNED, IIOJHPILAFO DEMKDCKINKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x86123E0", Offset = "0x8610DE0", VA = "0x1886123E0")]
	private static void FFPDHCHPNNK(LPKALDMBNCN DLPMNPBGMII, Action<OCMONAANEPK> JLPKHPDMNED, Predicate<IIOJHPILAFO> JCCMFIEPFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x86146A0", Offset = "0x86130A0", VA = "0x1886146A0")]
	private void NHGDPPCCKJH(GBDECDHLMJN KPIDJKLDGJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8614000", Offset = "0x8612A00", VA = "0x188614000", Slot = "4")]
	[AsyncStateMachine(typeof(ACBMCFBAHNO))]
	public Task MBBODEEFFJH([CanBeNull] BGHEHCDAEKD NIAPBNPEIPM, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8610810", Offset = "0x860F210", VA = "0x188610810")]
	private void CMHMLDKAILP(LPKALDMBNCN PMNKCABGOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8611FE0", Offset = "0x86109E0", VA = "0x188611FE0")]
	internal static string EOAKNLIFPGN(EAKJPCNPLGN CCABEEJMCIN, BGHEHCDAEKD NIAPBNPEIPM, IReadOnlyDictionary<IIOJHPILAFO, PNAGJONGCHL> FMJMGILBACM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x860F9A0", Offset = "0x860E3A0", VA = "0x18860F9A0")]
	private static void CDCNEIAOADD(BGHEHCDAEKD NIAPBNPEIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8614120", Offset = "0x8612B20", VA = "0x188614120")]
	private static void MPOKCAHCOKO(LPKALDMBNCN OELIPNHLECI, IReadOnlyDictionary<IIOJHPILAFO, PNAGJONGCHL> FMJMGILBACM, StringBuilder OHFKKEFKPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8610700", Offset = "0x860F100", VA = "0x188610700")]
	private static bool CJNDCIOFBLA(string EOLNDGELLEI, [Out] Guid EPIGKEEDIAC, [Out] IIOJHPILAFO KDHNLBMMLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8610B50", Offset = "0x860F550", VA = "0x188610B50")]
	private static void DDDPIINOIAG(BGHEHCDAEKD NIAPBNPEIPM, StringBuilder OHFKKEFKPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3AC7880", Offset = "0x3AC6280", VA = "0x183AC7880", Slot = "14")]
	public bool FOPLDPMOBFA<T>(IIOJHPILAFO KDHNLBMMLGO, INJPECNJBDL JPCKBPIBNCM, bool JFPNIBPHEBA, T EFPDHJCEEGP, [Optional] Action AJKINJLLNIE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x86133F0", Offset = "0x8611DF0", VA = "0x1886133F0", Slot = "15")]
	public string ILHIDBNLMNG(INJPECNJBDL JPCKBPIBNCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8613E60", Offset = "0x8612860", VA = "0x188613E60", Slot = "16")]
	public bool MAIJIKFNFAA(GBDECDHLMJN KPIDJKLDGJJ, INJPECNJBDL LDDOPCFAHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8613F50", Offset = "0x8612950", VA = "0x188613F50", Slot = "18")]
	public bool MAIJIKFNFAA(int NIHHJEGJCCB, INJPECNJBDL LDDOPCFAHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x860F700", Offset = "0x860E100", VA = "0x18860F700")]
	private void BDCHBCKBKHP(IIOJHPILAFO KDHNLBMMLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8613E40", Offset = "0x8612840", VA = "0x188613E40")]
	private bool LLNGBAJKHOK(GBDECDHLMJN KPIDJKLDGJJ, IIOJHPILAFO KDHNLBMMLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x860F3C0", Offset = "0x860DDC0", VA = "0x18860F3C0")]
	internal PNAGJONGCHL AOCOHMHPHAK(GBDECDHLMJN KPIDJKLDGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x86149F0", Offset = "0x86133F0", VA = "0x1886149F0", Slot = "11")]
	public IReadOnlyList<PIIAMIGEOBL> OPCJGODGGCI(GBDECDHLMJN KPIDJKLDGJJ, bool IPOBFOBBJIG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8614470", Offset = "0x8612E70", VA = "0x188614470")]
	internal IReadOnlyList<PNAGJONGCHL> NCPHEABHDEB(GBDECDHLMJN KPIDJKLDGJJ, bool IPOBFOBBJIG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x8611850", Offset = "0x8610250", VA = "0x188611850")]
	private void ELHJMGLGECB(KADDNIPNJBK PJNCIBLJKPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x8614710", Offset = "0x8613110", VA = "0x188614710")]
	private static bool OFJPDFPHCNF(PNAGJONGCHL FPAHMOPKEEO, IReadOnlyDictionary<IIOJHPILAFO, PNAGJONGCHL> FMJMGILBACM, [Out] IReadOnlyList<INJPECNJBDL> GGKKGAJKIMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x8612F40", Offset = "0x8611940", VA = "0x188612F40")]
	[AsyncStateMachine(typeof(JKPIDDAPAMA))]
	private static Task FNPOJBDCDKH(EAKJPCNPLGN CCABEEJMCIN, BGHEHCDAEKD NIAPBNPEIPM, IReadOnlyDictionary<IIOJHPILAFO, PNAGJONGCHL> FMJMGILBACM, HEILNANPDJC MNPKNCJLCKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x8611290", Offset = "0x860FC90", VA = "0x188611290")]
	[CompilerGenerated]
	internal static void DEGHPJCNNOF(Func<OCMONAANEPK, GIOJJCKJBHP> MANPOKHEIIG, PIAEJAACEDL P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x86136E0", Offset = "0x86120E0", VA = "0x1886136E0")]
	[CompilerGenerated]
	internal static bool JIMCCCJNJNM(IIOJHPILAFO KDHNLBMMLGO, INJPECNJBDL JPCKBPIBNCM, [Out] IEEEACPCPDD FFGDPKAABJH, JENEPBFPOOE P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CCKACAHPJGF
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCIMGMKJHKP(GBDECDHLMJN AOLEJANEAMM, GBDECDHLMJN OEPJCLNGDBD, IEnumerable<GBDECDHLMJN> OMFIKIHOOBN, [Out] ADDNHFOLEPE FEEGCCKNJJN, [Out] PGDKBPLFJBO KFAJOILHLLA);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string FIEDCKIPMFL(PGDKBPLFJBO KAAEKJEFGLP);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum PGDKBPLFJBO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class EAIBBJHJHLL : CCKACAHPJGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly IHPPOLLEOED IEILOHMFJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly GIPMKFMPNBJ KIKBKIAPNNG;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EAIBBJHJHLL([CNHMBDDCGKB(null)] IHPPOLLEOED IEILOHMFJOC, [CNHMBDDCGKB(null)] GIPMKFMPNBJ JIPGHGHOJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x860BF20", Offset = "0x860A920", VA = "0x18860BF20")]
	private static LECHAIBKJDM? NFGBMEGJOKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x860B800", Offset = "0x860A200", VA = "0x18860B800", Slot = "4")]
	public bool LCIMGMKJHKP(GBDECDHLMJN AOLEJANEAMM, GBDECDHLMJN OEPJCLNGDBD, IEnumerable<GBDECDHLMJN> OMFIKIHOOBN, [Out] ADDNHFOLEPE FEEGCCKNJJN, [Out] PGDKBPLFJBO KFAJOILHLLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x860B700", Offset = "0x860A100", VA = "0x18860B700", Slot = "5")]
	public string FIEDCKIPMFL(PGDKBPLFJBO KAAEKJEFGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x860B900", Offset = "0x860A300", VA = "0x18860B900")]
	internal bool MLNKJEOIMGH(GBDECDHLMJN AOLEJANEAMM, GBDECDHLMJN OEPJCLNGDBD, IEnumerable<GBDECDHLMJN> OMFIKIHOOBN, PFLGPOLCCPC NENGKGBFHCF, LECHAIBKJDM? KEJFCIMDEEP, [Out] ADDNHFOLEPE FEEGCCKNJJN, [Out] PGDKBPLFJBO KFAJOILHLLA)
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
