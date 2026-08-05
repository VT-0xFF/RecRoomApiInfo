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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6A97EB0", Offset = "0x6A970B0", VA = "0x186A97EB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum MFMOGPCGJMK
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NCHPPOPOLAP<TPermission>(TPermission KFANFJADKIF);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LHPAOJCFFAL(FGIOJHFMDFP PIDLONEPCMN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FJCDAJGBLOP
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KAJKNPFIIME
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BKLCHGDLDGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool LILNOCFMIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DKCELOBIJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MNPNMJFEMDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MLNEOPPJLAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool LOAEJCHPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class HHFBLEHEIMC
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum FFIOIKBOBHD
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
	public static readonly Guid DFLCKALHDKD;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid KNDDLJKILDF;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid NCPJEDHEDNB;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid FADPKKOCDAH;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid CAIHIIPFMEF;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid GOIDNCLIPDH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly HMFDFIFAPCE<POHMLDHFGOM, Guid> NGGDNHOBHFG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<POHMLDHFGOM> OOHKNBEMMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A8D600", Offset = "0x6A8C800", VA = "0x186A8D600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D570", Offset = "0x6A8C770", VA = "0x186A8D570")]
	public static POHMLDHFGOM FOLBODBDPAD(Guid LDJEJDDHHLO)
	{
		return default(POHMLDHFGOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D680", Offset = "0x6A8C880", VA = "0x186A8D680")]
	public static Guid HKPOPAIIBOM(POHMLDHFGOM KOBCDBKEMNJ)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D7D0", Offset = "0x6A8C9D0", VA = "0x186A8D7D0")]
	public static bool KKEFGNBEOCE(POHMLDHFGOM KOBCDBKEMNJ, [Out] Guid LDJEJDDHHLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D490", Offset = "0x6A8C690", VA = "0x186A8D490")]
	public static bool DMNGKKOIMFJ(Guid LDJEJDDHHLO, [Out] POHMLDHFGOM KOBCDBKEMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D450", Offset = "0x6A8C650", VA = "0x186A8D450")]
	public static POHMLDHFGOM CLNIDGICMCF(POHMLDHFGOM KOBCDBKEMNJ)
	{
		return default(POHMLDHFGOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D720", Offset = "0x6A8C920", VA = "0x186A8D720")]
	public static FFIOIKBOBHD IOIALJMKKKG(POHMLDHFGOM JKBKDNJCNFE)
	{
		return default(FFIOIKBOBHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D530", Offset = "0x6A8C730", VA = "0x186A8D530")]
	internal static POHMLDHFGOM EOEJMCDOFMI(FFIOIKBOBHD EDOJBLIAGDI)
	{
		return default(POHMLDHFGOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JICDIJNOLOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KIGGJGNNFCF KCJIBIFCGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<GBCOHJHDGNM> DNJNEAAFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event LHPAOJCFFAL IMBPHKIFBHN;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<GBCOHJHDGNM> NNLMJOJDCJN(bool HDNEFLHHJLG = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GBCOHJHDGNM EFLKNABGOLB(FGIOJHFMDFP PIDLONEPCMN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BIMLGMGOBDL(FGIOJHFMDFP PIDLONEPCMN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<GBCOHJHDGNM> GIMJPFGMDAJ(FGIOJHFMDFP PIDLONEPCMN, bool ELOGCKKOAJE = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MCFAKPDKJOE(FGIOJHFMDFP FPGLPEEJOAI, POHMLDHFGOM KOBCDBKEMNJ);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GBCOHJHDGNM PCBPMIIAMDL(POHMLDHFGOM KOBCDBKEMNJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DPJIKPNDOKK<T>(POHMLDHFGOM KOBCDBKEMNJ, ICEOFEHCMCE KFANFJADKIF, bool AHJICHALJLL, T HBOMCAJBOPM, [Optional] Action DLIMLODBNKN) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JAPCICPMKFG
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KKPDOMPFNGL(CFOBPFOOGBO LOOHIDPGHKP, CancellationToken GILHKFNDIJP);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMPDLALGLFE(CFOBPFOOGBO LOOHIDPGHKP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BENPIOMDGEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FGIOJHFMDFP NLCCACLMPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KIIPGINHBDD IOJOCEEDMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BILGMHAEOPI IOJCEJDHLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KGLANNHPKFD> HIAGFNDOHIK;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MICPCLKJIHD;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	POHMLDHFGOM PEBJEAIHLCO(FGIOJHFMDFP PIDLONEPCMN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KGLANNHPKFD> NFPHPDCLJNF(CancellationToken GILHKFNDIJP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task NANMKHDBLNC(long EAONINJADDB, long KODOPEGJOJD, IReadOnlyList<HBHFPEBNBAB> JNOONEGHBIK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<FGIOJHFMDFP> EHMFIGBHOPB();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class JCKFHMENLPK
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E9F0", Offset = "0x6A8DBF0", VA = "0x186A8E9F0")]
	public static POHMLDHFGOM FLKHNFIGPAA(this BENPIOMDGEJ ALMGEMJAMON)
	{
		return default(POHMLDHFGOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface AEHGGJNNBML<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string FPKNHEEBCDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NCHPPOPOLAP<TPermission> HEKKLGJHGML;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class IANGPGFBCLH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? MBBGNKFAGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7D5B00", Offset = "0x7D4D00", VA = "0x1807D5B00")]
	protected IANGPGFBCLH(object? HAJLPDBFMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PLJPKDJCJAI(object? HLCKBKFCMPI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class ECMLNJMCKCH<T> : IANGPGFBCLH where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T HBCNNAIGHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> MGOCODLOLKK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x865B90", Offset = "0x864D90", VA = "0x180865B90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x356F120", Offset = "0x356E320", VA = "0x18356F120", Slot = "4")]
	public override bool PLJPKDJCJAI(object? HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x356ED50", Offset = "0x356DF50", VA = "0x18356ED50")]
	public bool EPACIKDLCHM(T BLBLONNCFLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x356F2E0", Offset = "0x356E4E0", VA = "0x18356F2E0")]
	public ECMLNJMCKCH(T AKBALOLNFML, IEqualityComparer<T> MGOCODLOLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class OCKEFFJOCBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<ICEOFEHCMCE, bool> JODOHIJBFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<ICEOFEHCMCE, IANGPGFBCLH> JPOCNJIEHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly GFEOLJMPJHJ BLINCLACOEF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A98400", Offset = "0x6A97600", VA = "0x186A98400")]
	public OCKEFFJOCBH(GFEOLJMPJHJ BLINCLACOEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A982B0", Offset = "0x6A974B0", VA = "0x186A982B0")]
	public bool KGFFHNCICIN(ICEOFEHCMCE KFANFJADKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFFD0", Offset = "0x2AEF1D0", VA = "0x182AEFFD0")]
	public bool KOMABHKFIIK<T>(ICEOFEHCMCE KFANFJADKIF, bool AHJICHALJLL, T HLCKBKFCMPI) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFC00", Offset = "0x2AEEE00", VA = "0x182AEFC00")]
	public (bool, T?) CKEJNALGKIB<T>(ICEOFEHCMCE KFANFJADKIF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A98320", Offset = "0x6A97520", VA = "0x186A98320")]
	public bool KOMABHKFIIK(ICEOFEHCMCE KFANFJADKIF, bool AHJICHALJLL, object HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A98000", Offset = "0x6A97200", VA = "0x186A98000")]
	public (bool, object) CKEJNALGKIB(ICEOFEHCMCE KFANFJADKIF)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2AF04E0", Offset = "0x2AEF6E0", VA = "0x182AF04E0")]
	private void LOFDPOMJNEC<T>(ICEOFEHCMCE KFANFJADKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A97F30", Offset = "0x6A97130", VA = "0x186A97F30")]
	private IANGPGFBCLH CHLJCKOIPIF(ICEOFEHCMCE KFANFJADKIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A980D0", Offset = "0x6A972D0", VA = "0x186A980D0")]
	public void DJJNCPKLPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FFEIJPFDJNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string BEDLHJMHALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type DEGLCLFLDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly FIKFIIFDMDO IOGANBFHJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly ICEOFEHCMCE GLNPBJMLJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public MJDFLAFKNDA IIBLNCCFIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public LKAHMMMBBCI CNFPNFPJMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JCJAACGPDBD KCKCBCMIAOF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BB90", Offset = "0x6A8AD90", VA = "0x186A8BB90")]
	public FFEIJPFDJNJ(Type BINEBINCBOK, string PPHBJCPFGOC, ICEOFEHCMCE KFANFJADKIF, MJDFLAFKNDA HEMKJCKBEKH, LKAHMMMBBCI POLBNPPBLKI, JCJAACGPDBD IMEGHCCOMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BB40", Offset = "0x6A8AD40", VA = "0x186A8BB40")]
	public object ODODJCDMCAH(object? JPLJHFMPDFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2958320", Offset = "0x2957520", VA = "0x182958320")]
	public void LOFDPOMJNEC<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BA90", Offset = "0x6A8AC90", VA = "0x186A8BA90")]
	public void LOFDPOMJNEC(Type EHGFNFNNLHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class JNEBOLMHDCP<T> : FFEIJPFDJNJ where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string OGMKGGFFNKJ(T HLCKBKFCMPI);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T GMDIEIINHPP(string? AJPCGPDIBJO, T AKBALOLNFML);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class AGLDLPMMDKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public OGMKGGFFNKJ serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public GMDIEIINHPP parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AGLDLPMMDKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3BACE90", Offset = "0x3BAC090", VA = "0x183BACE90")]
		internal string MBFHJGINPHH(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3BACE00", Offset = "0x3BAC000", VA = "0x183BACE00")]
		internal object GPEPMCEFMIG(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F9F0", Offset = "0x3D8EBF0", VA = "0x183D8F9F0")]
	public JNEBOLMHDCP(ICEOFEHCMCE KFANFJADKIF, string PPHBJCPFGOC, [Optional] OGMKGGFFNKJ? HEMKJCKBEKH, [Optional] GMDIEIINHPP? POLBNPPBLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D8F150", Offset = "0x3D8E350", VA = "0x183D8F150")]
	private static object? IHPADLGFHBL(GMDIEIINHPP? POLBNPPBLKI, string? AJPCGPDIBJO, object? AKBALOLNFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E6E0", Offset = "0x3D8D8E0", VA = "0x183D8E6E0")]
	private static string GKNEHCEDNDE(OGMKGGFFNKJ? DMGKFLDNOLI, object? HLCKBKFCMPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string MJDFLAFKNDA(object? HLCKBKFCMPI);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object LKAHMMMBBCI(string? AJPCGPDIBJO, [Optional] object AKBALOLNFML);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate IANGPGFBCLH JCJAACGPDBD();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class GFEOLJMPJHJ
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class MJDKMKJNLDM : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static MJDKMKJNLDM LNFBMICMFIL;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6A945B0", Offset = "0x6A937B0", VA = "0x186A945B0", Slot = "4")]
		public bool Equals(List<string> DCHJALFCEJF, List<string> JFJIMNMJLJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6A94700", Offset = "0x6A93900", VA = "0x186A94700", Slot = "5")]
		public int GetHashCode(List<string> CDJAKLIPEBF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public MJDKMKJNLDM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class JBJCBBODLMN : NNBNBBGOECN<MFMOGPCGJMK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E8C0", Offset = "0x6A8DAC0", VA = "0x186A8E8C0", Slot = "9")]
		public override string GKNEHCEDNDE(MFMOGPCGJMK NBFGFAAMIMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E6F0", Offset = "0x6A8D8F0", VA = "0x186A8E6F0", Slot = "10")]
		protected override bool BLEJOEIHMHF(string NBFGFAAMIMJ, [Out] MFMOGPCGJMK HLCKBKFCMPI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A8E9B0", Offset = "0x6A8DBB0", VA = "0x186A8E9B0")]
		public JBJCBBODLMN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly PPCMNKNLPNC PJKNAHKGAIB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly JBJCBBODLMN OMJNMGLIAIP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<FFEIJPFDJNJ> OCCJINNINFG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<ICEOFEHCMCE> LPJGKJHAIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<ICEOFEHCMCE, FFEIJPFDJNJ> BHGPOLHIABB
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8D100", Offset = "0x6A8C300", VA = "0x186A8D100")]
	public GFEOLJMPJHJ([Optional] IList<FFEIJPFDJNJ>? GKCLIMCDNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8BC30", Offset = "0x6A8AE30", VA = "0x186A8BC30")]
	public FFEIJPFDJNJ CBDHNDLEHBA(ICEOFEHCMCE KFANFJADKIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KIGGJGNNFCF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GBCOHJHDGNM GPEFIBODDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class NHLCBALGFDD : KIGGJGNNFCF
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static NHLCBALGFDD FBNDCJKJFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly NNAALNADKLI AMGMHFKILBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<NNAALNADKLI> LKFFMCKBIOM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GBCOHJHDGNM GPEFIBODDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A95BC0", Offset = "0x6A94DC0", VA = "0x186A95BC0")]
	public NHLCBALGFDD(NNAALNADKLI JKDPHGHFAAJ, IReadOnlyList<NNAALNADKLI> HEDIOGLBMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A94FC0", Offset = "0x6A941C0", VA = "0x186A94FC0")]
	private static NHLCBALGFDD EKMMLCBEAOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class IOAEEKHHJEL
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<POHMLDHFGOM> KKACODKIJBN;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E3E0", Offset = "0x6A8D5E0", VA = "0x186A8E3E0")]
	public static bool GLMJFPOMHLE(this FGIOJHFMDFP KOLBLKMAABJ, POHMLDHFGOM KOBCDBKEMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E4C0", Offset = "0x6A8D6C0", VA = "0x186A8E4C0")]
	public static bool KIEFNNOFMEJ(this FGIOJHFMDFP KOLBLKMAABJ, POHMLDHFGOM KOBCDBKEMNJ, BILGMHAEOPI LNJAPFBMLAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BPELINJLINO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool JPCDFMGKKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HMKJOJHMAID
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ANFAHHBLCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool DJEDLBHLLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IAMODIIKCGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AGHODIFDBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BGFGAJNIEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JGILNPHNFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool ICJILCNNNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool JAACPCKJLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool FNLEGFCAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool EDLINMACIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> LIMFKKFLFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MFMOGPCGJMK MOPGIHMCMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface GBCOHJHDGNM : BPELINJLINO, KAJKNPFIIME, AEHGGJNNBML<ICEOFEHCMCE>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string LHGMMLECHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	POHMLDHFGOM ODCCPICJILN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) NLFOHBIIEHG<T>(ICEOFEHCMCE KFANFJADKIF) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum ICEOFEHCMCE
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
internal class NNAALNADKLI : GBCOHJHDGNM, BPELINJLINO, KAJKNPFIIME, AEHGGJNNBML<ICEOFEHCMCE>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly GFEOLJMPJHJ HGIACDEEHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly OCKEFFJOCBH PPJFOLCJIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? OCMLOIACHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? CKFFKLDKPGH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool LIBPMNHBJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6A96E70", Offset = "0x6A96070", VA = "0x186A96E70", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool HGBAILALFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6A96650", Offset = "0x6A95850", VA = "0x186A96650", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool POKEAGGECKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6A96740", Offset = "0x6A95940", VA = "0x186A96740", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool EGKOIMJKJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6A967E0", Offset = "0x6A959E0", VA = "0x186A967E0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool JLKKANLEPLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6A96DD0", Offset = "0x6A95FD0", VA = "0x186A96DD0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool NAIHKEMALBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6A96C80", Offset = "0x6A95E80", VA = "0x186A96C80", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public POHMLDHFGOM ODCCPICJILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x865B90", Offset = "0x864D90", VA = "0x180865B90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(POHMLDHFGOM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7CC960", Offset = "0x7CBB60", VA = "0x1807CC960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string FPKNHEEBCDI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6A97380", Offset = "0x6A96580", VA = "0x186A97380", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6A97960", Offset = "0x6A96B60", VA = "0x186A97960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string LHGMMLECHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6A97380", Offset = "0x6A96580", VA = "0x186A97380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LCLKFCKEHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x90C730", Offset = "0x90B930", VA = "0x18090C730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x90BFF0", Offset = "0x90B1F0", VA = "0x18090BFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JPCDFMGKKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A96F10", Offset = "0x6A96110", VA = "0x186A96F10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public MFMOGPCGJMK MOPGIHMCMFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6A96E20", Offset = "0x6A96020", VA = "0x186A96E20", Slot = "20")]
		get
		{
			return default(MFMOGPCGJMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HMKJOJHMAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6A97BA0", Offset = "0x6A96DA0", VA = "0x186A97BA0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ANFAHHBLCCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6A96EC0", Offset = "0x6A960C0", VA = "0x186A96EC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool DJEDLBHLLKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6A966F0", Offset = "0x6A958F0", VA = "0x186A966F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IAMODIIKCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6A97000", Offset = "0x6A96200", VA = "0x186A97000", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool AGHODIFDBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6A97910", Offset = "0x6A96B10", VA = "0x186A97910", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool BGFGAJNIEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A96FB0", Offset = "0x6A961B0", VA = "0x186A96FB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JGILNPHNFGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6A978C0", Offset = "0x6A96AC0", VA = "0x186A978C0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool ICJILCNNNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6A966A0", Offset = "0x6A958A0", VA = "0x186A966A0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> LIMFKKFLFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6A979B0", Offset = "0x6A96BB0", VA = "0x186A979B0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HKMDIPCACCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A96E70", Offset = "0x6A96070", VA = "0x186A96E70", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OCIMOJPCFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A96DD0", Offset = "0x6A95FD0", VA = "0x186A96DD0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool MMCDBHBNPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A96650", Offset = "0x6A95850", VA = "0x186A96650", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool JAACPCKJLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A97130", Offset = "0x6A96330", VA = "0x186A97130", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool FNLEGFCAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A96F60", Offset = "0x6A96160", VA = "0x186A96F60", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OHHCBPJHJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6A96740", Offset = "0x6A95940", VA = "0x186A96740", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool EDLINMACIPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6A96790", Offset = "0x6A95990", VA = "0x186A96790", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GFJNICOILCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A967E0", Offset = "0x6A959E0", VA = "0x186A967E0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool JJBDKFNLJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A96C80", Offset = "0x6A95E80", VA = "0x186A96C80", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event NCHPPOPOLAP<ICEOFEHCMCE> HEKKLGJHGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6A97AA0", Offset = "0x6A96CA0", VA = "0x186A97AA0", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6A96830", Offset = "0x6A95A30", VA = "0x186A96830", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB740", Offset = "0x2ACA940", VA = "0x182ACB740", Slot = "6")]
	public (bool, T?) NLFOHBIIEHG<T>(ICEOFEHCMCE KFANFJADKIF) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB700", Offset = "0x2ACA900", VA = "0x182ACB700")]
	public NNAALNADKLI MEPNNDCDPGG<T>(ICEOFEHCMCE KFANFJADKIF, bool AHJICHALJLL, T HLCKBKFCMPI) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A97DE0", Offset = "0x6A96FE0", VA = "0x186A97DE0")]
	public NNAALNADKLI(POHMLDHFGOM KOBCDBKEMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A97E00", Offset = "0x6A97000", VA = "0x186A97E00")]
	public NNAALNADKLI(POHMLDHFGOM KOBCDBKEMNJ, [Optional] string? OCMLOIACHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A97E20", Offset = "0x6A97020", VA = "0x186A97E20")]
	public NNAALNADKLI(NNAALNADKLI OMLANFIMPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A97C80", Offset = "0x6A96E80", VA = "0x186A97C80")]
	internal NNAALNADKLI(POHMLDHFGOM GDFLJKIGLFA, [Optional] string? OCMLOIACHBF, [Optional] NNAALNADKLI? OMLANFIMPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A973D0", Offset = "0x6A965D0", VA = "0x186A973D0")]
	public static FIKFIIFDMDO NDCHHNFDIBE(ICEOFEHCMCE KFANFJADKIF)
	{
		return default(FIKFIIFDMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A968E0", Offset = "0x6A95AE0", VA = "0x186A968E0")]
	public void DJJNCPKLPFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A96900", Offset = "0x6A95B00", VA = "0x186A96900")]
	internal NNAALNADKLI DPGIBPJNCPJ(NNAALNADKLI MLGCOLIJPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A97450", Offset = "0x6A96650", VA = "0x186A97450")]
	internal IReadOnlyCollection<ICEOFEHCMCE> NJPJPNDOPCO(NNAALNADKLI OMLANFIMPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A97050", Offset = "0x6A96250", VA = "0x186A97050")]
	public bool KCAFHLBNOKN(ICEOFEHCMCE KFANFJADKIF, bool AHJICHALJLL, string ABMKHLICHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A96CD0", Offset = "0x6A95ED0", VA = "0x186A96CD0")]
	public (bool, string) EOFJEFKHFFN(ICEOFEHCMCE KFANFJADKIF)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A97B50", Offset = "0x6A96D50", VA = "0x186A97B50")]
	internal void PLHCMPHNDIM(ICEOFEHCMCE KFANFJADKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6A97180", Offset = "0x6A96380", VA = "0x186A97180")]
	public GMIFPPNIHMN LIIIBECPAMO(Func<POHMLDHFGOM, Guid> GDFJAFLEOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6A95CD0", Offset = "0x6A94ED0", VA = "0x186A95CD0")]
	public void ADPGHEDIPID(GMIFPPNIHMN BNPNDKBOHAE, Func<Guid, POHMLDHFGOM> NJCCIIJPNBA, [Optional] POHMLDHFGOM? ECIPLFNHPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6A97A10", Offset = "0x6A96C10", VA = "0x186A97A10")]
	[CompilerGenerated]
	private void PGIDFILJGOG(ICEOFEHCMCE IPGNKIPLIFA, MLDLOADPDEP MNFKFKGLFIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MEAGOCGBDCI : JAPCICPMKFG, JICDIJNOLOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class DJBPLFFLKBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public NNAALNADKLI newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public DJBPLFFLKBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B860", Offset = "0x6A8AA60", VA = "0x186A8B860")]
		internal bool HGGEIMHCINL(NNAALNADKLI rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class IEOGPALHBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public POHMLDHFGOM roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public IEOGPALHBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DB80", Offset = "0x6A8CD80", VA = "0x186A8DB80")]
		internal bool DPJEJHHHIMD(POHMLDHFGOM r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct NAJHADJIFEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public MEAGOCGBDCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public CFOBPFOOGBO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<KGLANNHPKFD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6A948F0", Offset = "0x6A93AF0", VA = "0x186A948F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6A94F60", Offset = "0x6A94160", VA = "0x186A94F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class EANAGEFCKED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public EANAGEFCKED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B9B0", Offset = "0x6A8ABB0", VA = "0x186A8B9B0")]
		internal void NMEAIELGEFC(GMIFPPNIHMN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B890", Offset = "0x6A8AA90", VA = "0x186A8B890")]
		internal void KNLEOFCJILF(GMIFPPNIHMN r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct HMKJJJDIGKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CFOBPFOOGBO roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class MEIOPBNLNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<GMIFPPNIHMN, MLDLOADPDEP> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public MEIOPBNLNMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6A94520", Offset = "0x6A93720", VA = "0x186A94520")]
		internal void JBNFOHJMCCL(GMIFPPNIHMN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6A94580", Offset = "0x6A93780", VA = "0x186A94580")]
		internal void POAONPPFFFE(GMIFPPNIHMN r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6A94550", Offset = "0x6A93750", VA = "0x186A94550")]
		internal void KCJJBODKNDK(GMIFPPNIHMN r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class MJOKNIOLPKA<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private struct <<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public MJOKNIOLPKA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private TaskAwaiter<KGLANNHPKFD> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3346020", Offset = "0x3345220", VA = "0x183346020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x939BD0", Offset = "0x938DD0", VA = "0x180939BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public MEAGOCGBDCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public ICEOFEHCMCE rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public POHMLDHFGOM accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public FIKFIIFDMDO recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public MJOKNIOLPKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4140FA0", Offset = "0x41401A0", VA = "0x184140FA0")]
		[AsyncStateMachine(typeof(MJOKNIOLPKA<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void DGFLPPLHBID()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct DCODNONKDHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IReadOnlyList<HBHFPEBNBAB> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CNOCGGEALPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public BENPIOMDGEJ rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public CFOBPFOOGBO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public IReadOnlyDictionary<POHMLDHFGOM, NNAALNADKLI> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public GEOGAPFJNJM debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A8ACF0", Offset = "0x6A89EF0", VA = "0x186A8ACF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A8B800", Offset = "0x6A8AA00", VA = "0x186A8B800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly BENPIOMDGEJ ALMGEMJAMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly NHLCBALGFDD ODLBCCANIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly GEOGAPFJNJM FEEDHCGJCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, NNAALNADKLI> JAGAFMBJDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<POHMLDHFGOM, NNAALNADKLI> JDGDDDBGOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<POHMLDHFGOM, NNAALNADKLI> DHLHFAFLDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<NNAALNADKLI> JEDFENJEHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool ECNCJJAKOLE;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly ICEOFEHCMCE[] GPGIPNHOGDP;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KIGGJGNNFCF KCJIBIFCGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<GBCOHJHDGNM> DNJNEAAFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A904E0", Offset = "0x6A8F6E0", VA = "0x186A904E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LHPAOJCFFAL IMBPHKIFBHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A90100", Offset = "0x6A8F300", VA = "0x186A90100", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A8FFF0", Offset = "0x6A8F1F0", VA = "0x186A8FFF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6A92000", Offset = "0x6A91200", VA = "0x186A92000")]
	[JIMPHGEJKMA(NFKMIHJOIMG.Room, CLDBMEKPFFP.None)]
	private static void KKAGNGKELMI(EHGDBDLIOFB JKHBLMGBLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6A94260", Offset = "0x6A93460", VA = "0x186A94260")]
	[UnityEngine.Scripting.Preserve]
	internal MEAGOCGBDCI([KFHLAIGNCCH(null)] BENPIOMDGEJ PBHKDJNNDHL, [KFHLAIGNCCH(null)] NHLCBALGFDD OPHGIDDHOOA, [KFHLAIGNCCH(null)] GEOGAPFJNJM FEEDHCGJCFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6A90530", Offset = "0x6A8F730", VA = "0x186A90530", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6A90F70", Offset = "0x6A90170", VA = "0x186A90F70")]
	private void HBHGJFMKPKA(IEnumerable<NNAALNADKLI> AMMEMEOMKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FF20", Offset = "0x6A8F120", VA = "0x186A8FF20", Slot = "12")]
	public bool BIMLGMGOBDL(FGIOJHFMDFP PIDLONEPCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6A92C40", Offset = "0x6A91E40", VA = "0x186A92C40")]
	private void MICPCLKJIHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6A90C70", Offset = "0x6A8FE70", VA = "0x186A90C70")]
	private void GBPEIHLIGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6A931D0", Offset = "0x6A923D0", VA = "0x186A931D0", Slot = "10")]
	public IReadOnlyList<GBCOHJHDGNM> NNLMJOJDCJN(bool HDNEFLHHJLG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6A90950", Offset = "0x6A8FB50", VA = "0x186A90950", Slot = "11")]
	public GBCOHJHDGNM EFLKNABGOLB(FGIOJHFMDFP PIDLONEPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6A90A60", Offset = "0x6A8FC60", VA = "0x186A90A60")]
	private POHMLDHFGOM FHGPAOMHLBC(FGIOJHFMDFP PIDLONEPCMN)
	{
		return default(POHMLDHFGOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A92AB0", Offset = "0x6A91CB0", VA = "0x186A92AB0", Slot = "14")]
	public bool MCFAKPDKJOE(FGIOJHFMDFP FPGLPEEJOAI, POHMLDHFGOM KOBCDBKEMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6A93FF0", Offset = "0x6A931F0", VA = "0x186A93FF0", Slot = "15")]
	public GBCOHJHDGNM PCBPMIIAMDL(POHMLDHFGOM KOBCDBKEMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6A92580", Offset = "0x6A91780", VA = "0x186A92580")]
	private static bool LGCHJBIBFKP(KOCFKKDMCGL PJMCNDIBJBB, POHMLDHFGOM KOBCDBKEMNJ, [Out] GMIFPPNIHMN? KNACNEFIPKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6A93C20", Offset = "0x6A92E20", VA = "0x186A93C20")]
	private static void OLFEKGODDFN(KOCFKKDMCGL PJMCNDIBJBB, Action<GMIFPPNIHMN> BKFKIJBHNCM, POHMLDHFGOM AIABOPAIFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6A93990", Offset = "0x6A92B90", VA = "0x186A93990")]
	private static void OLFEKGODDFN(KOCFKKDMCGL PJMCNDIBJBB, Action<GMIFPPNIHMN> BKFKIJBHNCM, Predicate<POHMLDHFGOM> JOOOOGOPGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6A90090", Offset = "0x6A8F290", VA = "0x186A90090")]
	private void BOMBJHKOCEN(FGIOJHFMDFP PIDLONEPCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6A921C0", Offset = "0x6A913C0", VA = "0x186A921C0", Slot = "4")]
	[AsyncStateMachine(typeof(NAJHADJIFEA))]
	public Task KKPDOMPFNGL([CanBeNull] CFOBPFOOGBO LOOHIDPGHKP, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
	public void GMPDLALGLFE(CFOBPFOOGBO LOOHIDPGHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6A901A0", Offset = "0x6A8F3A0", VA = "0x186A901A0")]
	private void CHAPCIFFHFH(KOCFKKDMCGL GMMCDBGLCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6A90640", Offset = "0x6A8F840", VA = "0x186A90640")]
	internal static string EFFCANHODEE(BENPIOMDGEJ ALMGEMJAMON, CFOBPFOOGBO LOOHIDPGHKP, IReadOnlyDictionary<POHMLDHFGOM, NNAALNADKLI> JDGDDDBGOEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EDC0", Offset = "0x6A8DFC0", VA = "0x186A8EDC0")]
	private static void AGFGOKIOILK(CFOBPFOOGBO LOOHIDPGHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6A92C50", Offset = "0x6A91E50", VA = "0x186A92C50")]
	private static void NCNNKFAIIPC(KOCFKKDMCGL CEJNBOBIEKJ, IReadOnlyDictionary<POHMLDHFGOM, NNAALNADKLI> JDGDDDBGOEI, StringBuilder DFHHOFLCNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6A90E50", Offset = "0x6A90050", VA = "0x186A90E50")]
	private static bool GFHLIOCKNPL(string LHOFAEPLIIE, [Out] Guid FMIPLCKPAHE, [Out] POHMLDHFGOM KOBCDBKEMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6A93250", Offset = "0x6A92450", VA = "0x186A93250")]
	private static void OEDDNJOOBNB(CFOBPFOOGBO LOOHIDPGHKP, StringBuilder DFHHOFLCNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A5B190", Offset = "0x2A5A390", VA = "0x182A5B190", Slot = "16")]
	public bool DPJIKPNDOKK<T>(POHMLDHFGOM KOBCDBKEMNJ, ICEOFEHCMCE KFANFJADKIF, bool AHJICHALJLL, T HBOMCAJBOPM, [Optional] Action DLIMLODBNKN) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6A928B0", Offset = "0x6A91AB0", VA = "0x186A928B0")]
	private void LGIJGKJEEGI(POHMLDHFGOM KOBCDBKEMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6A91FE0", Offset = "0x6A911E0", VA = "0x186A91FE0")]
	private bool JBMILLPOHBI(FGIOJHFMDFP PIDLONEPCMN, POHMLDHFGOM KOBCDBKEMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FBF0", Offset = "0x6A8EDF0", VA = "0x186A8FBF0")]
	internal NNAALNADKLI ALKJPKMCGAA(FGIOJHFMDFP PIDLONEPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6A90F60", Offset = "0x6A90160", VA = "0x186A90F60", Slot = "13")]
	public IReadOnlyList<GBCOHJHDGNM> GIMJPFGMDAJ(FGIOJHFMDFP PIDLONEPCMN, bool ELOGCKKOAJE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6A92FA0", Offset = "0x6A921A0", VA = "0x186A92FA0")]
	internal IReadOnlyList<NNAALNADKLI> NFPHJNLKCAA(FGIOJHFMDFP PIDLONEPCMN, bool ELOGCKKOAJE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6A91850", Offset = "0x6A90A50", VA = "0x186A91850")]
	private void IAILKHNCFAI(KGLANNHPKFD IMPEHFDDBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6A93D10", Offset = "0x6A92F10", VA = "0x186A93D10")]
	private static bool OMBDJPGLLGN(NNAALNADKLI BFHJAEAMHOJ, IReadOnlyDictionary<POHMLDHFGOM, NNAALNADKLI> JDGDDDBGOEI, [Out] IReadOnlyList<ICEOFEHCMCE> KFFDNFLFMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6A90B30", Offset = "0x6A8FD30", VA = "0x186A90B30")]
	[AsyncStateMachine(typeof(CNOCGGEALPI))]
	private static Task FMBAJNNMIBA(BENPIOMDGEJ ALMGEMJAMON, CFOBPFOOGBO LOOHIDPGHKP, IReadOnlyDictionary<POHMLDHFGOM, NNAALNADKLI> JDGDDDBGOEI, GEOGAPFJNJM FEEDHCGJCFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6A922E0", Offset = "0x6A914E0", VA = "0x186A922E0")]
	[CompilerGenerated]
	internal static void KMPCPKIAKNN(Func<GMIFPPNIHMN, MLDLOADPDEP> HHLPOICMBGG, HMKJJJDIGKJ P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EA50", Offset = "0x6A8DC50", VA = "0x186A8EA50")]
	[CompilerGenerated]
	internal static bool AEHMGGMOFMC(POHMLDHFGOM KOBCDBKEMNJ, ICEOFEHCMCE KFANFJADKIF, [Out] HBHFPEBNBAB KFGKMEHFKNM, DCODNONKDHP P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface NKBGBDECGJB
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GIGDHDFPPLJ(FGIOJHFMDFP PJFIHLGOLBK, FGIOJHFMDFP EKFFJEAAEJE, IEnumerable<FGIOJHFMDFP> PDLEMIEGHPP, [Out] MFMOGPCGJMK IHOBKFELCFF, [Out] FHGMFGJJBOP GHFCIGPIMFK);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string JOFCKGJJKML(FHGMFGJJBOP EKBHEDHGOGD);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum FHGMFGJJBOP : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	InsufficientPermission,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisabledByRoom,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	CantKickEventOrganizer,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Broadcaster,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	GameInProgress,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	OpponentGameInProgress
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal class IGENEJIAKOI : NKBGBDECGJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly JICDIJNOLOB NNBPMDFEHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly APGDKNAEBBK EJCDHHKCPHL;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7D1780", Offset = "0x7D0980", VA = "0x1807D1780")]
	[RecRoom.NoEngine.Common.Preserve]
	public IGENEJIAKOI([KFHLAIGNCCH(null)] JICDIJNOLOB GJPDDGBDDCD, [KFHLAIGNCCH(null)] APGDKNAEBBK CKMNIAFBCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E3A0", Offset = "0x6A8D5A0", VA = "0x186A8E3A0")]
	private static EIJLCBJKFJC? OOPFKNEACLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DB90", Offset = "0x6A8CD90", VA = "0x186A8DB90", Slot = "4")]
	public bool GIGDHDFPPLJ(FGIOJHFMDFP PJFIHLGOLBK, FGIOJHFMDFP EKFFJEAAEJE, IEnumerable<FGIOJHFMDFP> PDLEMIEGHPP, [Out] MFMOGPCGJMK IHOBKFELCFF, [Out] FHGMFGJJBOP GHFCIGPIMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DC90", Offset = "0x6A8CE90", VA = "0x186A8DC90", Slot = "5")]
	public string JOFCKGJJKML(FHGMFGJJBOP EKBHEDHGOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DD90", Offset = "0x6A8CF90", VA = "0x186A8DD90")]
	internal bool KPFEHBGOAHC(FGIOJHFMDFP PJFIHLGOLBK, FGIOJHFMDFP EKFFJEAAEJE, IEnumerable<FGIOJHFMDFP> PDLEMIEGHPP, BILGMHAEOPI LNJAPFBMLAH, EIJLCBJKFJC? EAOACFOGHPF, [Out] MFMOGPCGJMK IHOBKFELCFF, [Out] FHGMFGJJBOP GHFCIGPIMFK)
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
