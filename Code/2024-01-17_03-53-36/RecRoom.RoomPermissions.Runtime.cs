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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6637C40", Offset = "0x6636A40", VA = "0x186637C40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7B9560", Offset = "0x7B8360", VA = "0x1807B9560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B83A0", VA = "0x1807B95A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KBJDCLLOOGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JCOPJFCJADO<TPermission>(TPermission JIIEFMNJLEG);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void BLBLJELJCGL(DBPLNALEGHH HDDJHFKECEL);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum LPHHLOGOCBO
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NOGECAMDKKH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KICBBCKJLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MDAACPDJGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JLNGJIAKEII
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IJEAJCOKKND
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool LOCLLOMKCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FNLNHCGKKKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class LJFJPCOLIGE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum GMOGMEJKPFI
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
	public static readonly Guid OOGIKMACAIO;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid DNHEAEFCAKN;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid OFLMPFGOHJI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid PEHNGGAHFCJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid OKACJIGHJAL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid JDOJLBGKCMO;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly LPLAKEEEEEM<MPLBPIHCELM, Guid> BFPNGIKOPLP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<MPLBPIHCELM> AOGHNOHLIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6637510", Offset = "0x6636310", VA = "0x186637510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6637670", Offset = "0x6636470", VA = "0x186637670")]
	public static MPLBPIHCELM DGDAGHGIGAK(Guid FILMEIPENDI)
	{
		return default(MPLBPIHCELM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6637590", Offset = "0x6636390", VA = "0x186637590")]
	public static Guid CJKPOCCDACC(MPLBPIHCELM FJNHCMIICOD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6637890", Offset = "0x6636690", VA = "0x186637890")]
	public static bool NNPCJNBPHDJ(MPLBPIHCELM FJNHCMIICOD, [Out] Guid FILMEIPENDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x66377F0", Offset = "0x66365F0", VA = "0x1866377F0")]
	public static bool HBKBGBKODID(Guid FILMEIPENDI, [Out] MPLBPIHCELM FJNHCMIICOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6637700", Offset = "0x6636500", VA = "0x186637700")]
	public static MPLBPIHCELM FNMLLFAABLI(MPLBPIHCELM FJNHCMIICOD)
	{
		return default(MPLBPIHCELM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6637740", Offset = "0x6636540", VA = "0x186637740")]
	public static GMOGMEJKPFI GNOAOFDNCLH(MPLBPIHCELM DIFKBCFIKOA)
	{
		return default(GMOGMEJKPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6637630", Offset = "0x6636430", VA = "0x186637630")]
	internal static MPLBPIHCELM DDAALOGNJLK(GMOGMEJKPFI ELJFJOHDJHJ)
	{
		return default(MPLBPIHCELM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JLLEECBONBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IKIPLFPJJNO LHOOILAFANK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<NNMKGLGMHHH> DJKFNNGCNNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BLBLJELJCGL DPEIPDPJAAD;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<NNMKGLGMHHH> EDPCKKDMODD(bool PPDECFGAKBA = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NNMKGLGMHHH HHPKANFPAKF(DBPLNALEGHH HDDJHFKECEL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HCNMHINDJIK(DBPLNALEGHH HDDJHFKECEL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<NNMKGLGMHHH> GPMJGKKLGBA(DBPLNALEGHH HDDJHFKECEL, bool JLDAIIDONDK = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LAPCOPCCHID(DBPLNALEGHH PGFAMBNEOPB, MPLBPIHCELM FJNHCMIICOD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NNMKGLGMHHH MDHEECFCKJD(MPLBPIHCELM FJNHCMIICOD);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AIDGJFHPPFL<T>(MPLBPIHCELM FJNHCMIICOD, KAEOHFPKKBH JIIEFMNJLEG, bool IMDMJFNFLIP, T EOMAHDAGOPF) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DBCCMJCODPA
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HCJBNJHLOLG(NAGNHACOKFH CPKEOAPOOKP, CancellationToken EHAEIHNIHFM);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEHPJJALEFE(NAGNHACOKFH CPKEOAPOOKP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PGAFPFKJBHI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DBPLNALEGHH GHHPILAHFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KMNEBHNBJDD GOLAFIBCIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NDDGIKIFEIH OFGBDFPEIJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<MLIKIGHHEII> PFLDGAHLIMP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LJBALPJOIAL;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MPLBPIHCELM HAAADOEHELH(DBPLNALEGHH HDDJHFKECEL);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<MLIKIGHHEII> JJOIDGIDIFM(CancellationToken EHAEIHNIHFM);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IOAFGGBNCDF(long NJOOPBBHHDG, long PFNFPELEIPI, IReadOnlyList<EMPDPDJOHOP> OCKIJDFNNGP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<DBPLNALEGHH> NPDCDHKNBCN();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LCJEKCEKLIF
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x66374B0", Offset = "0x66362B0", VA = "0x1866374B0")]
	public static MPLBPIHCELM GPJEKOJOKJK(this PGAFPFKJBHI LMAIJBMOMKA)
	{
		return default(MPLBPIHCELM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DJANCKPFJCI<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string PECAIAEKIMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JCOPJFCJADO<TPermission> AJLPKHPLMFB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class ALPAHKCCEDC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? ONKIOCKLFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78CFA0", VA = "0x18078E1A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	protected ALPAHKCCEDC(object? AIEDLMINOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool GCKNNHFHAPA(object? MBDKMNBCLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class MCGOOENNBOE<T> : ALPAHKCCEDC where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T DCGGMCDDLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> FIJEPNBNICC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T AOJPLLHPPML
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x814B60", Offset = "0x813960", VA = "0x180814B60")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3D411A0", Offset = "0x3D3FFA0", VA = "0x183D411A0", Slot = "4")]
	public override bool GCKNNHFHAPA(object? MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3D40F70", Offset = "0x3D3FD70", VA = "0x183D40F70")]
	public bool ANEDMABPPCO(T NANBNPEGAPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3D414F0", Offset = "0x3D402F0", VA = "0x183D414F0")]
	public MCGOOENNBOE(T NNIKDBJKMOA, IEqualityComparer<T> FIJEPNBNICC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class HLCMAIMGLEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KAEOHFPKKBH, bool> PADEAMCOCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<KAEOHFPKKBH, ALPAHKCCEDC> FLAIMPJFLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly FONKEPPFHOC EJDIOGBIDNL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x662FCC0", Offset = "0x662EAC0", VA = "0x18662FCC0")]
	public HLCMAIMGLEK(FONKEPPFHOC EJDIOGBIDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x662F8A0", Offset = "0x662E6A0", VA = "0x18662F8A0")]
	public bool HIHGMHOEKHJ(KAEOHFPKKBH JIIEFMNJLEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25D2430", Offset = "0x25D1230", VA = "0x1825D2430")]
	public bool OBOBBILHFPN<T>(KAEOHFPKKBH JIIEFMNJLEG, bool IMDMJFNFLIP, T MBDKMNBCLGF) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25D2060", Offset = "0x25D0E60", VA = "0x1825D2060")]
	public (bool, T?) BPGNNHFCCHM<T>(KAEOHFPKKBH JIIEFMNJLEG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x662FBE0", Offset = "0x662E9E0", VA = "0x18662FBE0")]
	public bool OBOBBILHFPN(KAEOHFPKKBH JIIEFMNJLEG, bool IMDMJFNFLIP, object MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x662F7D0", Offset = "0x662E5D0", VA = "0x18662F7D0")]
	public (bool, object) BPGNNHFCCHM(KAEOHFPKKBH JIIEFMNJLEG)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25D2020", Offset = "0x25D0E20", VA = "0x1825D2020")]
	private void BGEFCBFAMLG<T>(KAEOHFPKKBH JIIEFMNJLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x662FB10", Offset = "0x662E910", VA = "0x18662FB10")]
	private ALPAHKCCEDC MPGCDIGPIHG(KAEOHFPKKBH JIIEFMNJLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x662F910", Offset = "0x662E710", VA = "0x18662F910")]
	public void LKIJPJAIMDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class KKOLBFKAKKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string LOGCOHNAJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type GNPONMIHEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly EOLNBPGKKCC GBOFMGNOAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KAEOHFPKKBH BBLIGCPOKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public HEJBIHGLIBD KFLMAAJBPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public EBLCIEADEOC BPJAFKGMAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public AJJPOFBJPHI BEPHDPNLOBN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6637410", Offset = "0x6636210", VA = "0x186637410")]
	public KKOLBFKAKKF(Type DHBNPJLHDBE, string DDCJBJKCDAI, KAEOHFPKKBH JIIEFMNJLEG, HEJBIHGLIBD LKGPHILPIAP, EBLCIEADEOC ANCNGNFFOKD, AJJPOFBJPHI ONBMDGFEDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x66373C0", Offset = "0x66361C0", VA = "0x1866373C0")]
	public object KINDKKMAGEN(object? GDMGBCDFBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2623000", Offset = "0x2621E00", VA = "0x182623000")]
	public void BGEFCBFAMLG<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6637310", Offset = "0x6636110", VA = "0x186637310")]
	public void BGEFCBFAMLG(Type KHMHDHPEPFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LPHNBNOAHAG<T> : KKOLBFKAKKF where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string PDGIMCHIOIE(T MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T FJCKNEBCEHL(string? MIOCGIEHDBE, T NNIKDBJKMOA);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class JHJNHGANNGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public PDGIMCHIOIE serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FJCKNEBCEHL parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public JHJNHGANNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x39F5DA0", Offset = "0x39F4BA0", VA = "0x1839F5DA0")]
		internal string MBBAJEHOCMN(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x39F5D00", Offset = "0x39F4B00", VA = "0x1839F5D00")]
		internal object JHFGADKAJGN(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B807B0", Offset = "0x3B7F5B0", VA = "0x183B807B0")]
	public LPHNBNOAHAG(KAEOHFPKKBH JIIEFMNJLEG, string DDCJBJKCDAI, [Optional] PDGIMCHIOIE? LKGPHILPIAP, [Optional] FJCKNEBCEHL? ANCNGNFFOKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B7FCC0", Offset = "0x3B7EAC0", VA = "0x183B7FCC0")]
	private static object? HONCKFFEJNK(FJCKNEBCEHL? ANCNGNFFOKD, string? MIOCGIEHDBE, object? NNIKDBJKMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B80240", Offset = "0x3B7F040", VA = "0x183B80240")]
	private static string OKNECDBNGHE(PDGIMCHIOIE? OKMGFHHLDBC, object? MBDKMNBCLGF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string HEJBIHGLIBD(object? MBDKMNBCLGF);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object EBLCIEADEOC(string? MIOCGIEHDBE, [Optional] object NNIKDBJKMOA);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate ALPAHKCCEDC AJJPOFBJPHI();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class FONKEPPFHOC
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class KAGMMGEAPEL : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static KAGMMGEAPEL CEIKCOHBGGB;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6636600", Offset = "0x6635400", VA = "0x186636600", Slot = "4")]
		public bool Equals(List<string> PCOMFHJKLCD, List<string> EANLPGFBDDM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6636750", Offset = "0x6635550", VA = "0x186636750", Slot = "5")]
		public int GetHashCode(List<string> FGANJEAKCMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public KAGMMGEAPEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class KECNHCPMDPK : ANIKIHFFAIF<KBJDCLLOOGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x66371E0", Offset = "0x6635FE0", VA = "0x1866371E0", Slot = "9")]
		public override string OKNECDBNGHE(KBJDCLLOOGJ PIMDNKIGEGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6637000", Offset = "0x6635E00", VA = "0x186637000", Slot = "10")]
		protected override bool IJBNKLNBBHE(string PIMDNKIGEGF, [Out] KBJDCLLOOGJ MBDKMNBCLGF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x66372D0", Offset = "0x66360D0", VA = "0x1866372D0")]
		public KECNHCPMDPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly DIKKNMBNMDL GDFIBCEGHEF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly KECNHCPMDPK EHKLPHFOLPB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<KKOLBFKAKKF> NJDJDJAFEJN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KAEOHFPKKBH> CHEOGMOADCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KAEOHFPKKBH, KKOLBFKAKKF> EOEGLIPJFIE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x662E930", Offset = "0x662D730", VA = "0x18662E930")]
	public FONKEPPFHOC([Optional] IList<KKOLBFKAKKF>? IGPBGLNALPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x662DAC0", Offset = "0x662C8C0", VA = "0x18662DAC0")]
	public KKOLBFKAKKF GPKPNOCCEKP(KAEOHFPKKBH JIIEFMNJLEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IKIPLFPJJNO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NNMKGLGMHHH HDIOLEGMICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class HFADFFHKKPO : IKIPLFPJJNO
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static HFADFFHKKPO AFCKEGDPEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly AOLEEJMNAKM JLLBOCBBPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<AOLEEJMNAKM> MDIINLPHDJO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public NNMKGLGMHHH HDIOLEGMICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x662F6C0", Offset = "0x662E4C0", VA = "0x18662F6C0")]
	public HFADFFHKKPO(AOLEEJMNAKM KNGHLJKAHNF, IReadOnlyList<AOLEEJMNAKM> CKGHPBANDNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x662EC90", Offset = "0x662DA90", VA = "0x18662EC90")]
	private static HFADFFHKKPO PLJAEJHNEHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class PGJELDIDLCE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<MPLBPIHCELM> HJPPBNKCMBH;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6637D70", Offset = "0x6636B70", VA = "0x186637D70")]
	public static bool KGFLIFNOGLD(this DBPLNALEGHH BJGGNCFEDKM, MPLBPIHCELM FJNHCMIICOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6637CF0", Offset = "0x6636AF0", VA = "0x186637CF0")]
	public static bool ENJGKCIPACP(this DBPLNALEGHH BJGGNCFEDKM, MPLBPIHCELM FJNHCMIICOD, NDDGIKIFEIH MBFBPMEBMEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface FDNJJLEMGBI
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CFEEJMFHHMO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool CKEJHDJCOBG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool MIBBCJGNEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool EOANNCAOBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LMKOOBGMOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool LKHBDBKIFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NJIPKKCDIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool FCLJFCBENLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool JEGNDJJJEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool ONFALDKHLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool JPECICIDHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool OODHJJKMGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> ECEHFDAJEDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	KBJDCLLOOGJ LANIOKEBGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface NNMKGLGMHHH : FDNJJLEMGBI, NOGECAMDKKH, DJANCKPFJCI<KAEOHFPKKBH>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string HCOFOBLKPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	MPLBPIHCELM GJDFIHHIPEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) JAENDDBICIO<T>(KAEOHFPKKBH JIIEFMNJLEG) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KAEOHFPKKBH
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
internal class AOLEEJMNAKM : NNMKGLGMHHH, FDNJJLEMGBI, NOGECAMDKKH, DJANCKPFJCI<KAEOHFPKKBH>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly FONKEPPFHOC KJHIGMINKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly HLCMAIMGLEK IMKGLJKPIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? ABCHJHCKLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? FOJKBFGJNIM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool HHAKBIEDNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x662B1A0", Offset = "0x6629FA0", VA = "0x18662B1A0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FLEAAJDGODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x662BAB0", Offset = "0x662A8B0", VA = "0x18662BAB0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool AAMCJEIGJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x662CB80", Offset = "0x662B980", VA = "0x18662CB80", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool LDIAFGCBHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x662B060", Offset = "0x6629E60", VA = "0x18662B060", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool MKACCPCOFEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x662CC70", Offset = "0x662BA70", VA = "0x18662CC70", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool NHPKPJHHIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x662B150", Offset = "0x6629F50", VA = "0x18662B150", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public MPLBPIHCELM GJDFIHHIPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x814B60", Offset = "0x813960", VA = "0x180814B60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(MPLBPIHCELM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x796F10", Offset = "0x795D10", VA = "0x180796F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string PECAIAEKIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x662B0B0", Offset = "0x6629EB0", VA = "0x18662B0B0", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x662BCF0", Offset = "0x662AAF0", VA = "0x18662BCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string HCOFOBLKPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x662B0B0", Offset = "0x6629EB0", VA = "0x18662B0B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NGOIEBPMJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8138C0", Offset = "0x8126C0", VA = "0x1808138C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x812C10", Offset = "0x811A10", VA = "0x180812C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool CFEEJMFHHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x662CBD0", Offset = "0x662B9D0", VA = "0x18662CBD0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public KBJDCLLOOGJ LANIOKEBGEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x662AF20", Offset = "0x6629D20", VA = "0x18662AF20", Slot = "20")]
		get
		{
			return default(KBJDCLLOOGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool CKEJHDJCOBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x662B010", Offset = "0x6629E10", VA = "0x18662B010", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool MIBBCJGNEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x662AE80", Offset = "0x6629C80", VA = "0x18662AE80", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool EOANNCAOBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x662CC20", Offset = "0x662BA20", VA = "0x18662CC20", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LMKOOBGMOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x662CD50", Offset = "0x662BB50", VA = "0x18662CD50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LKHBDBKIFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x662AED0", Offset = "0x6629CD0", VA = "0x18662AED0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NJIPKKCDIAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x662BA60", Offset = "0x662A860", VA = "0x18662BA60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FCLJFCBENLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x662B630", Offset = "0x662A430", VA = "0x18662B630", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JEGNDJJJEME
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x662B100", Offset = "0x6629F00", VA = "0x18662B100", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> ECEHFDAJEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x662BA00", Offset = "0x662A800", VA = "0x18662BA00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool KAHKBLFLEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x662B1A0", Offset = "0x6629FA0", VA = "0x18662B1A0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool KLCECMIMCNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x662CC70", Offset = "0x662BA70", VA = "0x18662CC70", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MKFOLAGNJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x662BAB0", Offset = "0x662A8B0", VA = "0x18662BAB0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool ONFALDKHLBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x662AF70", Offset = "0x6629D70", VA = "0x18662AF70", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JPECICIDHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x662BB80", Offset = "0x662A980", VA = "0x18662BB80", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool LADCFCOIMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x662CB80", Offset = "0x662B980", VA = "0x18662CB80", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OODHJJKMGAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x662AFC0", Offset = "0x6629DC0", VA = "0x18662AFC0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HKKEFANOPKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x662B060", Offset = "0x6629E60", VA = "0x18662B060", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CKNBNKCPDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x662B150", Offset = "0x6629F50", VA = "0x18662B150", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JCOPJFCJADO<KAEOHFPKKBH> AJLPKHPLMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x662B4D0", Offset = "0x662A2D0", VA = "0x18662B4D0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x662B580", Offset = "0x662A380", VA = "0x18662B580", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2C31E60", Offset = "0x2C30C60", VA = "0x182C31E60", Slot = "6")]
	public (bool, T?) JAENDDBICIO<T>(KAEOHFPKKBH JIIEFMNJLEG) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2C31FF0", Offset = "0x2C30DF0", VA = "0x182C31FF0")]
	public AOLEEJMNAKM MBPPAJMPNAE<T>(KAEOHFPKKBH JIIEFMNJLEG, bool IMDMJFNFLIP, T MBDKMNBCLGF) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x662D040", Offset = "0x662BE40", VA = "0x18662D040")]
	public AOLEEJMNAKM(MPLBPIHCELM FJNHCMIICOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x662CEC0", Offset = "0x662BCC0", VA = "0x18662CEC0")]
	public AOLEEJMNAKM(MPLBPIHCELM FJNHCMIICOD, [Optional] string? ABCHJHCKLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x662CE30", Offset = "0x662BC30", VA = "0x18662CE30")]
	public AOLEEJMNAKM(AOLEEJMNAKM HJOIKOLEPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x662CEE0", Offset = "0x662BCE0", VA = "0x18662CEE0")]
	internal AOLEEJMNAKM(MPLBPIHCELM DEHLFIHGFNL, [Optional] string? ABCHJHCKLAB, [Optional] AOLEEJMNAKM? HJOIKOLEPCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x662BB00", Offset = "0x662A900", VA = "0x18662BB00")]
	public static EOLNBPGKKCC KKNGFGJLNOH(KAEOHFPKKBH JIIEFMNJLEG)
	{
		return default(EOLNBPGKKCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x662BCD0", Offset = "0x662AAD0", VA = "0x18662BCD0")]
	public void LKIJPJAIMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x662B680", Offset = "0x662A480", VA = "0x18662B680")]
	internal AOLEEJMNAKM JACONPOALCJ(AOLEEJMNAKM FPNDAKDCCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x662BD40", Offset = "0x662AB40", VA = "0x18662BD40")]
	internal IReadOnlyCollection<KAEOHFPKKBH> MAACLPMGJID(AOLEEJMNAKM HJOIKOLEPCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x662B1F0", Offset = "0x6629FF0", VA = "0x18662B1F0")]
	public bool FIPHLEODMGO(KAEOHFPKKBH JIIEFMNJLEG, bool IMDMJFNFLIP, string DMKHNBKJJKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x662BBD0", Offset = "0x662A9D0", VA = "0x18662BBD0")]
	public (bool, string) LJGCMBOOEHB(KAEOHFPKKBH JIIEFMNJLEG)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x662C1B0", Offset = "0x662AFB0", VA = "0x18662C1B0")]
	internal void MGBKDFGKENA(KAEOHFPKKBH JIIEFMNJLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x662B2D0", Offset = "0x662A0D0", VA = "0x18662B2D0")]
	public ODBFEFFBHEM HDIKKCMKFJN(Func<MPLBPIHCELM, Guid> LAEJFAJENAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x662C200", Offset = "0x662B000", VA = "0x18662C200")]
	public void MHBCELKNGFM(ODBFEFFBHEM AHNAAGAODGB, Func<Guid, MPLBPIHCELM> LNJNKINBBAC, [Optional] MPLBPIHCELM? PJJBIOLAELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x662CCC0", Offset = "0x662BAC0", VA = "0x18662CCC0")]
	[CompilerGenerated]
	private void PMNBGLDNDPB(KAEOHFPKKBH BMIHCBCDMJL, DBFBHFDGFFC BMOCCGECEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class INGHGFBGNEI : DBCCMJCODPA, JLLEECBONBE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class PCBMBGGGONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AOLEEJMNAKM newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public PCBMBGGGONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6637CC0", Offset = "0x6636AC0", VA = "0x186637CC0")]
		internal bool LAMLPHEFAKH(AOLEEJMNAKM rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class GLNMAMOIJLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public MPLBPIHCELM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public GLNMAMOIJLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x662EC80", Offset = "0x662DA80", VA = "0x18662EC80")]
		internal bool ABPBMNJFHOE(MPLBPIHCELM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KCMLMCFICJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public INGHGFBGNEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public NAGNHACOKFH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<MLIKIGHHEII> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6636940", Offset = "0x6635740", VA = "0x186636940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6636FA0", Offset = "0x6635DA0", VA = "0x186636FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class BGOPEJDMHHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public BGOPEJDMHHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x662D060", Offset = "0x662BE60", VA = "0x18662D060")]
		internal void BDDBKNGDFKD(ODBFEFFBHEM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x662D140", Offset = "0x662BF40", VA = "0x18662D140")]
		internal void JJJKDHJEKAD(ODBFEFFBHEM r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PNHOCPDCKGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NAGNHACOKFH roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class IMKPCNBMNCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<ODBFEFFBHEM, DBFBHFDGFFC> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public IMKPCNBMNCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x662FF70", Offset = "0x662ED70", VA = "0x18662FF70")]
		internal void AKKDADLLLDC(ODBFEFFBHEM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x662FFA0", Offset = "0x662EDA0", VA = "0x18662FFA0")]
		internal void MCKNAEFACCB(ODBFEFFBHEM r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x662FFD0", Offset = "0x662EDD0", VA = "0x18662FFD0")]
		internal void PMHDOOFNJPF(ODBFEFFBHEM r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class FFIOKAMNEHI<T> where T : notnull
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
			public FFIOKAMNEHI<T> <>4__this;

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
			private TaskAwaiter<MLIKIGHHEII> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x304C780", Offset = "0x304B580", VA = "0x18304C780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x92F090", Offset = "0x92DE90", VA = "0x18092F090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public INGHGFBGNEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KAEOHFPKKBH rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public MPLBPIHCELM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public EOLNBPGKKCC recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public FFIOKAMNEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x35FDA40", Offset = "0x35FC840", VA = "0x1835FDA40")]
		[AsyncStateMachine(typeof(FFIOKAMNEHI<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void CBHFFEANODK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct EPDIALBAAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<EMPDPDJOHOP> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct JBHGDPIGJKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public PGAFPFKJBHI rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public NAGNHACOKFH roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<MPLBPIHCELM, AOLEEJMNAKM> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public KPBPBOKGNCF debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6635A90", Offset = "0x6634890", VA = "0x186635A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x66365A0", Offset = "0x66353A0", VA = "0x1866365A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly PGAFPFKJBHI LMAIJBMOMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly HFADFFHKKPO IAFDHDPHJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly KPBPBOKGNCF OJHBJEFIAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, AOLEEJMNAKM> ABDJJNADFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<MPLBPIHCELM, AOLEEJMNAKM> GDFLKEJHKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<MPLBPIHCELM, AOLEEJMNAKM> HDLFCJIBENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<AOLEEJMNAKM> BLBDOLMEGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool LNLINKFDNGJ;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly KAEOHFPKKBH[] EGCDBPIFFLK;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public IKIPLFPJJNO LHOOILAFANK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<NNMKGLGMHHH> DJKFNNGCNNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6633200", Offset = "0x6632000", VA = "0x186633200", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event BLBLJELJCGL DPEIPDPJAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6630880", Offset = "0x662F680", VA = "0x186630880", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6631680", Offset = "0x6630480", VA = "0x186631680", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x66350C0", Offset = "0x6633EC0", VA = "0x1866350C0")]
	[OKINHFAHPEJ(OBFBFIBMGDJ.Room, FNGNILODNLI.None)]
	private static void PFLOEECCCOH(LPFNGCMIAEC KNABOHCCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x66357D0", Offset = "0x66345D0", VA = "0x1866357D0")]
	[UnityEngine.Scripting.Preserve]
	internal INGHGFBGNEI([MCCEMKLKAEE(null)] PGAFPFKJBHI MFBGBNNHKPG, [MCCEMKLKAEE(null)] HFADFFHKKPO BMAPPJDEAJE, [MCCEMKLKAEE(null)] KPBPBOKGNCF OJHBJEFIAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6630CD0", Offset = "0x662FAD0", VA = "0x186630CD0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6630000", Offset = "0x662EE00", VA = "0x186630000")]
	private void ACNGFAIPFGG(IEnumerable<AOLEEJMNAKM> GBFFJOFOBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6632210", Offset = "0x6631010", VA = "0x186632210", Slot = "12")]
	public bool HCNMHINDJIK(DBPLNALEGHH HDDJHFKECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6633D90", Offset = "0x6632B90", VA = "0x186633D90")]
	private void LJBALPJOIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6631130", Offset = "0x662FF30", VA = "0x186631130")]
	private void EDJDIANCJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6631320", Offset = "0x6630120", VA = "0x186631320", Slot = "10")]
	public IReadOnlyList<NNMKGLGMHHH> EDPCKKDMODD(bool PPDECFGAKBA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x66322E0", Offset = "0x66310E0", VA = "0x1866322E0", Slot = "11")]
	public NNMKGLGMHHH HHPKANFPAKF(DBPLNALEGHH HDDJHFKECEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x66315B0", Offset = "0x66303B0", VA = "0x1866315B0")]
	private MPLBPIHCELM FHCGMJHFOJN(DBPLNALEGHH HDDJHFKECEL)
	{
		return default(MPLBPIHCELM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6633C00", Offset = "0x6632A00", VA = "0x186633C00", Slot = "14")]
	public bool LAPCOPCCHID(DBPLNALEGHH PGFAMBNEOPB, MPLBPIHCELM FJNHCMIICOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x66340E0", Offset = "0x6632EE0", VA = "0x1866340E0", Slot = "15")]
	public NNMKGLGMHHH MDHEECFCKJD(MPLBPIHCELM FJNHCMIICOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6634630", Offset = "0x6633430", VA = "0x186634630")]
	private static bool MKIJDJMMKEM(AJKADOEJKKN EBOADFLMCOE, MPLBPIHCELM FJNHCMIICOD, [Out] ODBFEFFBHEM? AMGLNNIFAHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6635280", Offset = "0x6634080", VA = "0x186635280")]
	private static void PLDJBPOKFJN(AJKADOEJKKN EBOADFLMCOE, Action<ODBFEFFBHEM> MDCJHJAJBDP, MPLBPIHCELM MPKFOGLMEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6635370", Offset = "0x6634170", VA = "0x186635370")]
	private static void PLDJBPOKFJN(AJKADOEJKKN EBOADFLMCOE, Action<ODBFEFFBHEM> MDCJHJAJBDP, Predicate<MPLBPIHCELM> KCKPPENMIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x66338A0", Offset = "0x66326A0", VA = "0x1866338A0")]
	private void KGPILEHMEAP(DBPLNALEGHH HDDJHFKECEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x66320F0", Offset = "0x6630EF0", VA = "0x1866320F0", Slot = "4")]
	[AsyncStateMachine(typeof(KCMLMCFICJK))]
	public Task HCJBNJHLOLG([CanBeNull] NAGNHACOKFH CPKEOAPOOKP, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
	public void GEHPJJALEFE(NAGNHACOKFH CPKEOAPOOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6633DA0", Offset = "0x6632BA0", VA = "0x186633DA0")]
	private void LMFBNHLHPEI(AJKADOEJKKN BCLMFHIPFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x66335A0", Offset = "0x66323A0", VA = "0x1866335A0")]
	internal static string JIHAAMMFMPO(PGAFPFKJBHI LMAIJBMOMKA, NAGNHACOKFH CPKEOAPOOKP, IReadOnlyDictionary<MPLBPIHCELM, AOLEEJMNAKM> GDFLKEJHKBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x66323F0", Offset = "0x66311F0", VA = "0x1866323F0")]
	private static void HJHMNILDBEP(NAGNHACOKFH CPKEOAPOOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6633250", Offset = "0x6632050", VA = "0x186633250")]
	private static void JFBOEEIKCCN(AJKADOEJKKN GDMJNMDEGEE, IReadOnlyDictionary<MPLBPIHCELM, AOLEEJMNAKM> GDFLKEJHKBG, StringBuilder BIOEMOBFKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6630BC0", Offset = "0x662F9C0", VA = "0x186630BC0")]
	private static bool DIKNFMHDEGI(string NHHGOODJGJM, [Out] Guid NMHPDOGFMGJ, [Out] MPLBPIHCELM FJNHCMIICOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6634980", Offset = "0x6633780", VA = "0x186634980")]
	private static void OGMPCLCMILF(NAGNHACOKFH CPKEOAPOOKP, StringBuilder BIOEMOBFKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x25ECE10", Offset = "0x25EBC10", VA = "0x1825ECE10", Slot = "16")]
	public bool AIDGJFHPPFL<T>(MPLBPIHCELM FJNHCMIICOD, KAEOHFPKKBH JIIEFMNJLEG, bool IMDMJFNFLIP, T EOMAHDAGOPF) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x66313A0", Offset = "0x66301A0", VA = "0x1866313A0")]
	private void EJKNOBLCJAP(MPLBPIHCELM FJNHCMIICOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6634960", Offset = "0x6633760", VA = "0x186634960")]
	private bool NNCGHAFLGJK(DBPLNALEGHH HDDJHFKECEL, MPLBPIHCELM FJNHCMIICOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6630DE0", Offset = "0x662FBE0", VA = "0x186630DE0")]
	internal AOLEEJMNAKM EBENBAOIOPO(DBPLNALEGHH HDDJHFKECEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x66320E0", Offset = "0x6630EE0", VA = "0x1866320E0", Slot = "13")]
	public IReadOnlyList<NNMKGLGMHHH> GPMJGKKLGBA(DBPLNALEGHH HDDJHFKECEL, bool JLDAIIDONDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6631EB0", Offset = "0x6630CB0", VA = "0x186631EB0")]
	internal IReadOnlyList<AOLEEJMNAKM> GJKMNBPAIAC(DBPLNALEGHH HDDJHFKECEL, bool JLDAIIDONDK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6631720", Offset = "0x6630520", VA = "0x186631720")]
	private void FOPDDPJGMDI(MLIKIGHHEII BHEHLHEPALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6633910", Offset = "0x6632710", VA = "0x186633910")]
	private static bool KMNIFPLJOPH(AOLEEJMNAKM JKMHJEELCJN, IReadOnlyDictionary<MPLBPIHCELM, AOLEEJMNAKM> GDFLKEJHKBG, [Out] IReadOnlyList<KAEOHFPKKBH> HECIEPGIMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x66344F0", Offset = "0x66332F0", VA = "0x1866344F0")]
	[AsyncStateMachine(typeof(JBHGDPIGJKH))]
	private static Task MIFMPMGDFNJ(PGAFPFKJBHI LMAIJBMOMKA, NAGNHACOKFH CPKEOAPOOKP, IReadOnlyDictionary<MPLBPIHCELM, AOLEEJMNAKM> GDFLKEJHKBG, KPBPBOKGNCF OJHBJEFIAPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6630920", Offset = "0x662F720", VA = "0x186630920")]
	[CompilerGenerated]
	internal static void DBMCEBHPIOG(Func<ODBFEFFBHEM, DBFBHFDGFFC> OPANJJDIOLO, PNHOCPDCKGM P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6634180", Offset = "0x6632F80", VA = "0x186634180")]
	[CompilerGenerated]
	internal static bool MFMMHHNDHIN(MPLBPIHCELM FJNHCMIICOD, KAEOHFPKKBH JIIEFMNJLEG, [Out] EMPDPDJOHOP APPCDJPLBGA, EPDIALBAAIN P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface OMMPDDIIOJI
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AIPJNNLKDFF(DBPLNALEGHH DCJHDJEFPFL, DBPLNALEGHH NNJHDDFJCGP, IEnumerable<DBPLNALEGHH> DGEACADPFJK, [Out] KBJDCLLOOGJ MHIKGMCJOOC, [Out] IJEKJDCOFLO AFGPJBIANPD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KMPAOMLOOKB(IJEKJDCOFLO IEPCAOKOCGE);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum IJEKJDCOFLO : byte
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
internal class ECPPNLPIBJC : OMMPDDIIOJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JLLEECBONBE FCDEBENKHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NDHJPIAMABM PLNOODHINGE;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x79B830", Offset = "0x79A630", VA = "0x18079B830")]
	[RecRoom.NoEngine.Common.Preserve]
	public ECPPNLPIBJC([MCCEMKLKAEE(null)] JLLEECBONBE NAFMPPBPDPA, [MCCEMKLKAEE(null)] NDHJPIAMABM LPHMDPLCHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x662D360", Offset = "0x662C160", VA = "0x18662D360")]
	private static APEPLDIMBOE? ENAAIKKEDCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x662D260", Offset = "0x662C060", VA = "0x18662D260", Slot = "4")]
	public bool AIPJNNLKDFF(DBPLNALEGHH DCJHDJEFPFL, DBPLNALEGHH NNJHDDFJCGP, IEnumerable<DBPLNALEGHH> DGEACADPFJK, [Out] KBJDCLLOOGJ MHIKGMCJOOC, [Out] IJEKJDCOFLO AFGPJBIANPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x662D3A0", Offset = "0x662C1A0", VA = "0x18662D3A0", Slot = "5")]
	public string KMPAOMLOOKB(IJEKJDCOFLO IEPCAOKOCGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x662D4A0", Offset = "0x662C2A0", VA = "0x18662D4A0")]
	internal bool POACHGLLOJJ(DBPLNALEGHH DCJHDJEFPFL, DBPLNALEGHH NNJHDDFJCGP, IEnumerable<DBPLNALEGHH> DGEACADPFJK, NDDGIKIFEIH MBFBPMEBMEL, APEPLDIMBOE? JDKDGKPPGPE, [Out] KBJDCLLOOGJ MHIKGMCJOOC, [Out] IJEKJDCOFLO AFGPJBIANPD)
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
