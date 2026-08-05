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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70B0B30", Offset = "0x70AF130", VA = "0x1870B0B30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BPCDFINEJLB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void POKMCGFGILP<TPermission>(TPermission CDNIAHDDGCA);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void JBFOPFGHCEA(HDIGMKHIDBN PGLIJHMIECI);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KKJMJOFGGDD
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BPJKLAMFADF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EBKBPFMBEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ILMNHIOAAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GFLNGDJMIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool OHIPFBDNCCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HPGGPIHAGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool NOIAENNCMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class ODLAFMNFIEF
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum KKKPADFHMAL
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
	public static readonly Guid HFKHJKHEKGJ;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid HAKOKOIBEOA;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid IMOOHLNINEE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid HBIMLMDFKJG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid NLCEMODPEJI;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid IIGFODIFKNA;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly NFGBMIEKGOH<IDJDNLONMLP, Guid> KJIOBKIIHCF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<IDJDNLONMLP> GIIILFPGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70B0C40", Offset = "0x70AF240", VA = "0x1870B0C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70B0BB0", Offset = "0x70AF1B0", VA = "0x1870B0BB0")]
	public static IDJDNLONMLP COLHAOOMANI(Guid DHEKBCJKGBC)
	{
		return default(IDJDNLONMLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70B0D60", Offset = "0x70AF360", VA = "0x1870B0D60")]
	public static Guid HNDLHKLOPEH(IDJDNLONMLP NDDNAIHEOGI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70B0E00", Offset = "0x70AF400", VA = "0x1870B0E00")]
	public static bool KEJCCOBIAJO(IDJDNLONMLP NDDNAIHEOGI, [Out] Guid DHEKBCJKGBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x70B0E90", Offset = "0x70AF490", VA = "0x1870B0E90")]
	public static bool LJCKLGOPPDD(Guid DHEKBCJKGBC, [Out] IDJDNLONMLP NDDNAIHEOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70B0F70", Offset = "0x70AF570", VA = "0x1870B0F70")]
	public static IDJDNLONMLP NNCPOGELFAC(IDJDNLONMLP NDDNAIHEOGI)
	{
		return default(IDJDNLONMLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70B0CB0", Offset = "0x70AF2B0", VA = "0x1870B0CB0")]
	public static KKKPADFHMAL HIIOPKDPLIC(IDJDNLONMLP IHDNECMGLKG)
	{
		return default(KKKPADFHMAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70B0F30", Offset = "0x70AF530", VA = "0x1870B0F30")]
	internal static IDJDNLONMLP NKOPBIDEACO(KKKPADFHMAL GIKBHCAMNMG)
	{
		return default(IDJDNLONMLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GCHMLCFDFJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	GKKKMDAEABP JMAALHEFDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<ILNKEDGOOPM> HEIIBGALOBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event JBFOPFGHCEA IALJGLDFNJN;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<ILNKEDGOOPM> JBIDFOOEPPC(bool KBEEJPHPGBM = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ILNKEDGOOPM OIKJMLCFAIA(HDIGMKHIDBN PGLIJHMIECI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool BPHIBGLFGLK(HDIGMKHIDBN PGLIJHMIECI);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<ILNKEDGOOPM> HHAAKBCCHFF(HDIGMKHIDBN PGLIJHMIECI, bool MFEIEDLPNHB = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LBABPPPKJOP(HDIGMKHIDBN LLEMICNBOGL, IDJDNLONMLP NDDNAIHEOGI);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ILNKEDGOOPM CKBIKMDEPIH(IDJDNLONMLP NDDNAIHEOGI);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NFNICJPFEJI<T>(IDJDNLONMLP NDDNAIHEOGI, JDIGCFHLCBN CDNIAHDDGCA, bool DOLMNOKKLMN, T BBMJLAKPCGK, [Optional] Action OFPHNFLEKIB) where T : notnull;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "11")]
	string NNPFLJPONPP(JDIGCFHLCBN CDNIAHDDGCA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BGFCEEHHJAF
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BMLMMMFOBMG(POGNJKLFFHD BMLBCLGKFJE, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JALEHJOHLEP(POGNJKLFFHD BMLBCLGKFJE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DKBGPFFCGBH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HDIGMKHIDBN ABFMBIMEGBL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HGMCNBIJHOL OGKLDAINFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EKOKDGMBHGJ IMBPCENLKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AIMNGHMNFAE> ALCGHPOMKBE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action OONEKJBAKPG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IDJDNLONMLP LPKPMLKCIKJ(HDIGMKHIDBN PGLIJHMIECI);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<AIMNGHMNFAE> FHKAKHEPEDM(CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task OMPHNEMJBIP(long ECHGOOGHLEN, IReadOnlyList<DLCNHKKPELP> DIHIBKFDLNP);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task FCMGAJNFFEN(long ECHGOOGHLEN, long IMIHMEAMIDO, IReadOnlyList<DLCNHKKPELP> DIHIBKFDLNP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<HDIGMKHIDBN> DEKJNEOJMFD();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EDIHIMLEJNK
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x70A5B00", Offset = "0x70A4100", VA = "0x1870A5B00")]
	public static IDJDNLONMLP PLKBOJICBAI(this DKBGPFFCGBH CNDJNCBBGOM)
	{
		return default(IDJDNLONMLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LNKPLFNFKDG<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string ONGPLLJHHIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event POKMCGFGILP<TPermission> BGGKPCNLLNA;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class FCMKCJKLBMK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? GOGHDCDEDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	protected FCMKCJKLBMK(object? FDBPKMKOBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PGBPILIJKHH(object? FEBGGALLBNN);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class OMGAFHEAGCF<T> : FCMKCJKLBMK where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T MGIFIMCJOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> JNJFJFBCDJD;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T MDPJKNKDANF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x96BEB0", Offset = "0x96A4B0", VA = "0x18096BEB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4730740", Offset = "0x472ED40", VA = "0x184730740", Slot = "4")]
	public override bool PGBPILIJKHH(object? FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47303F0", Offset = "0x472E9F0", VA = "0x1847303F0")]
	public bool NGEHEMNGLPG(T OHLDLACCBCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4730A00", Offset = "0x472F000", VA = "0x184730A00")]
	public OMGAFHEAGCF(T PBAONJMDGEK, IEqualityComparer<T> JNJFJFBCDJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class LFICPIPJKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<JDIGCFHLCBN, bool> KKCBJIACKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<JDIGCFHLCBN, FCMKCJKLBMK> GHNEBIOPPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly AANPPLDNPEI FALPGGNIPFL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70AA9B0", Offset = "0x70A8FB0", VA = "0x1870AA9B0")]
	public LFICPIPJKOK(AANPPLDNPEI FALPGGNIPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70AA750", Offset = "0x70A8D50", VA = "0x1870AA750")]
	public bool HDNBKAILDCH(JDIGCFHLCBN CDNIAHDDGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2C12510", Offset = "0x2C10B10", VA = "0x182C12510")]
	public bool GFACBDECHKO<T>(JDIGCFHLCBN CDNIAHDDGCA, bool DOLMNOKKLMN, T FEBGGALLBNN) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2C12070", Offset = "0x2C10670", VA = "0x182C12070")]
	public (bool, T?) EMDAEEGLBOB<T>(JDIGCFHLCBN CDNIAHDDGCA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x70AA670", Offset = "0x70A8C70", VA = "0x1870AA670")]
	public bool GFACBDECHKO(JDIGCFHLCBN CDNIAHDDGCA, bool DOLMNOKKLMN, object FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x70AA4D0", Offset = "0x70A8AD0", VA = "0x1870AA4D0")]
	public (bool, object) EMDAEEGLBOB(JDIGCFHLCBN CDNIAHDDGCA)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2C12A90", Offset = "0x2C11090", VA = "0x182C12A90")]
	private void OHIOBEDOCNO<T>(JDIGCFHLCBN CDNIAHDDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70AA5A0", Offset = "0x70A8BA0", VA = "0x1870AA5A0")]
	private FCMKCJKLBMK GDFFHCHGFMM(JDIGCFHLCBN CDNIAHDDGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70AA7C0", Offset = "0x70A8DC0", VA = "0x1870AA7C0")]
	public void IBJILOOMAJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class FKHLBLGKLHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string MOCPHNBJHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type AJKAOKPHPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly PLEFBCEOACA IFJLDNPMDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly JDIGCFHLCBN MGIKDKGKMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public ABKBNLILODK PGLFGBANOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public GHPCKPMBFFJ NDEOODPDDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public LMCGNLNPAEB NKPOEEJKPJO;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x70A6BB0", Offset = "0x70A51B0", VA = "0x1870A6BB0")]
	public FKHLBLGKLHH(Type BGOAFPJPDGC, string HDMJEHFFBMG, JDIGCFHLCBN CDNIAHDDGCA, ABKBNLILODK OBNFFINFELK, GHPCKPMBFFJ FCFMGGLDAHG, LMCGNLNPAEB PCJKEFOOPNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70A6AB0", Offset = "0x70A50B0", VA = "0x1870A6AB0")]
	public object NGDLAOCIIAB(object? OGEIJLCLBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2B54AE0", Offset = "0x2B530E0", VA = "0x182B54AE0")]
	public void OHIOBEDOCNO<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70A6B00", Offset = "0x70A5100", VA = "0x1870A6B00")]
	public void OHIOBEDOCNO(Type OHELLCIDHPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class LNMKNLIFPKP<T> : FKHLBLGKLHH where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string NOOPEAEINOD(T FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T JFIGGGFCLCA(string? DNLCMMJOMLK, T PBAONJMDGEK);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class LHBIKJHOCMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public NOOPEAEINOD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public JFIGGGFCLCA parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public LHBIKJHOCMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x42A9F20", Offset = "0x42A8520", VA = "0x1842A9F20")]
		internal string JIKBKHJFEJJ(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x42A9D10", Offset = "0x42A8310", VA = "0x1842A9D10")]
		internal object GEECOCOOFFE(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x42EAAD0", Offset = "0x42E90D0", VA = "0x1842EAAD0")]
	public LNMKNLIFPKP(JDIGCFHLCBN CDNIAHDDGCA, string HDMJEHFFBMG, [Optional] NOOPEAEINOD? OBNFFINFELK, [Optional] JFIGGGFCLCA? FCFMGGLDAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x42EA450", Offset = "0x42E8A50", VA = "0x1842EA450")]
	private static object? DIPBOAAMMJI(JFIGGGFCLCA? FCFMGGLDAHG, string? DNLCMMJOMLK, object? PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x42E9B10", Offset = "0x42E8110", VA = "0x1842E9B10")]
	private static string ALGEABNCNAB(NOOPEAEINOD? LBIJEEPDLMD, object? FEBGGALLBNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string ABKBNLILODK(object? FEBGGALLBNN);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object GHPCKPMBFFJ(string? DNLCMMJOMLK, [Optional] object PBAONJMDGEK);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate FCMKCJKLBMK LMCGNLNPAEB();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class AANPPLDNPEI
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class ALMGDKIDPEF : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static ALMGDKIDPEF HHHOBHGDEHO;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70A57D0", Offset = "0x70A3DD0", VA = "0x1870A57D0", Slot = "4")]
		public bool Equals(List<string> OEMFOJFNECE, List<string> DPKOFHFGJKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x70A5920", Offset = "0x70A3F20", VA = "0x1870A5920", Slot = "5")]
		public int GetHashCode(List<string> CDBNFNMIHPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ALMGDKIDPEF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class KFMGEGJDENE : KKLJAMDAKLB<BPCDFINEJLB>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x70AA1D0", Offset = "0x70A87D0", VA = "0x1870AA1D0", Slot = "9")]
		public override string ALGEABNCNAB(BPCDFINEJLB NGALCNCLJMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70AA2C0", Offset = "0x70A88C0", VA = "0x1870AA2C0", Slot = "10")]
		protected override bool GNOPHAHAJLF(string NGALCNCLJMG, [Out] BPCDFINEJLB FEBGGALLBNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x70AA490", Offset = "0x70A8A90", VA = "0x1870AA490")]
		public KFMGEGJDENE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly NHAPOOLDGGA IJLANIBLKNN;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly KFMGEGJDENE LPHKNMKKJAP;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<FKHLBLGKLHH> MAJKHLKKNKM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<JDIGCFHLCBN> GAOAPJKOAJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<JDIGCFHLCBN, FKHLBLGKLHH> KFANEGLEPIE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x70A4DE0", Offset = "0x70A33E0", VA = "0x1870A4DE0")]
	public AANPPLDNPEI([Optional] IList<FKHLBLGKLHH>? GMGCCHPMIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x70A38E0", Offset = "0x70A1EE0", VA = "0x1870A38E0")]
	public FKHLBLGKLHH FKFJAKBNJIP(JDIGCFHLCBN CDNIAHDDGCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface GKKKMDAEABP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ILNKEDGOOPM AOBKKNAAJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class EIGJKDLPKDB : GKKKMDAEABP
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static EIGJKDLPKDB PBDOOOCMNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly GLGECJPJAOG KPAHNJPJBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<GLGECJPJAOG> OAGLEOHDGAL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ILNKEDGOOPM AOBKKNAAJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70A69A0", Offset = "0x70A4FA0", VA = "0x1870A69A0")]
	public EIGJKDLPKDB(GLGECJPJAOG IDNBOMGKMJH, IReadOnlyList<GLGECJPJAOG> JBOMAHGFIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70A5B60", Offset = "0x70A4160", VA = "0x1870A5B60")]
	private static EIGJKDLPKDB BCGHMNECCBE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NIHLDJABFPO
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<IDJDNLONMLP> HIAIKPHFBMN;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70B0830", Offset = "0x70AEE30", VA = "0x1870B0830")]
	public static bool BJDMOHJKECF(this HDIGMKHIDBN CJFAPAOPNFG, IDJDNLONMLP NDDNAIHEOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x70B0910", Offset = "0x70AEF10", VA = "0x1870B0910")]
	public static bool LLEHAPBCECD(this HDIGMKHIDBN CJFAPAOPNFG, IDJDNLONMLP NDDNAIHEOGI, EKOKDGMBHGJ GGGFNCHABMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GMJMBIMHPGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool OHENBKMKJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool LCKCDHOEOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ECBELDKOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool HPEFAOKJIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BJEFLFHJNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BLFPKKJFDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool CPNNBIFECJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool GFNAMEIGMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KKIJOGPLMMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EDBOKCIBHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ELIBJCAOOJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JLHDDNJNHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> IHEJJEGKBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	BPCDFINEJLB JHBICBAOFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface ILNKEDGOOPM : GMJMBIMHPGJ, BPJKLAMFADF, LNKPLFNFKDG<JDIGCFHLCBN>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string FJOILDENLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IDJDNLONMLP JDNHBEHDMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) AMCBDKPEKEB<T>(JDIGCFHLCBN CDNIAHDDGCA) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum JDIGCFHLCBN
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
internal class GLGECJPJAOG : ILNKEDGOOPM, GMJMBIMHPGJ, BPJKLAMFADF, LNKPLFNFKDG<JDIGCFHLCBN>
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	internal static readonly AANPPLDNPEI LFPBBBPKHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	internal readonly LFICPIPJKOK AMFEGOHBENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string? MMPHHOHAPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string? GKLDODMBFOP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool PLGKNIFLDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x70A8650", Offset = "0x70A6C50", VA = "0x1870A8650", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool IFLDBPFADCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x70A8500", Offset = "0x70A6B00", VA = "0x1870A8500", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool FOODDLFPHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x70A77C0", Offset = "0x70A5DC0", VA = "0x1870A77C0", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool IDMDMFDAGCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x70A7AF0", Offset = "0x70A60F0", VA = "0x1870A7AF0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool FJPDIKBGLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x70A7CA0", Offset = "0x70A62A0", VA = "0x1870A7CA0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool LFKBEAKAFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x70A7810", Offset = "0x70A5E10", VA = "0x1870A7810", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public IDJDNLONMLP JDNHBEHDMKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x96BEB0", Offset = "0x96A4B0", VA = "0x18096BEB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(IDJDNLONMLP);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x85D420", Offset = "0x85BA20", VA = "0x18085D420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string ONGPLLJHHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x70A8740", Offset = "0x70A6D40", VA = "0x1870A8740", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x70A91B0", Offset = "0x70A77B0", VA = "0x1870A91B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FJOILDENLMA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x70A8740", Offset = "0x70A6D40", VA = "0x1870A8740", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool JNKFOEALPME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x96BE50", Offset = "0x96A450", VA = "0x18096BE50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAE08A0", Offset = "0xADEEA0", VA = "0x180AE08A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool OHENBKMKJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x70A9200", Offset = "0x70A7800", VA = "0x1870A9200", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public BPCDFINEJLB JHBICBAOFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x70A86A0", Offset = "0x70A6CA0", VA = "0x1870A86A0", Slot = "20")]
		get
		{
			return default(BPCDFINEJLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LCKCDHOEOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x70A86F0", Offset = "0x70A6CF0", VA = "0x1870A86F0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool ECBELDKOFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x70A7E40", Offset = "0x70A6440", VA = "0x1870A7E40", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool HPEFAOKJIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x70A7B90", Offset = "0x70A6190", VA = "0x1870A7B90", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool BJEFLFHJNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x70A7860", Offset = "0x70A5E60", VA = "0x1870A7860", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BLFPKKJFDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x70A9160", Offset = "0x70A7760", VA = "0x1870A9160", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CPNNBIFECJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x70A7DF0", Offset = "0x70A63F0", VA = "0x1870A7DF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GFNAMEIGMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x70A95D0", Offset = "0x70A7BD0", VA = "0x1870A95D0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool KKIJOGPLMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x70A8790", Offset = "0x70A6D90", VA = "0x1870A8790", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> IHEJJEGKBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x70A9670", Offset = "0x70A7C70", VA = "0x1870A9670", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool EIFMPJLDLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x70A8650", Offset = "0x70A6C50", VA = "0x1870A8650", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JFHLLCCOJOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x70A7CA0", Offset = "0x70A62A0", VA = "0x1870A7CA0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool KMOHBAFHKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x70A8500", Offset = "0x70A6B00", VA = "0x1870A8500", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool EDBOKCIBHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x70A9620", Offset = "0x70A7C20", VA = "0x1870A9620", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ELIBJCAOOJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x70A7BE0", Offset = "0x70A61E0", VA = "0x1870A7BE0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IBECLAJEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x70A77C0", Offset = "0x70A5DC0", VA = "0x1870A77C0", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool JLHDDNJNHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x70A7CF0", Offset = "0x70A62F0", VA = "0x1870A7CF0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PODPDDIDOCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x70A7AF0", Offset = "0x70A60F0", VA = "0x1870A7AF0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool FECOCBCJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x70A7810", Offset = "0x70A5E10", VA = "0x1870A7810", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event POKMCGFGILP<JDIGCFHLCBN> BGGKPCNLLNA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x70A7D40", Offset = "0x70A6340", VA = "0x1870A7D40", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x70A79B0", Offset = "0x70A5FB0", VA = "0x1870A79B0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2B73070", Offset = "0x2B71670", VA = "0x182B73070", Slot = "6")]
	public (bool, T?) AMCBDKPEKEB<T>(JDIGCFHLCBN CDNIAHDDGCA) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2B733E0", Offset = "0x2B719E0", VA = "0x182B733E0")]
	public GLGECJPJAOG FGHCIKELPLN<T>(JDIGCFHLCBN CDNIAHDDGCA, bool DOLMNOKKLMN, T FEBGGALLBNN) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x70A98C0", Offset = "0x70A7EC0", VA = "0x1870A98C0")]
	public GLGECJPJAOG(IDJDNLONMLP NDDNAIHEOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x70A98A0", Offset = "0x70A7EA0", VA = "0x1870A98A0")]
	public GLGECJPJAOG(IDJDNLONMLP NDDNAIHEOGI, [Optional] string? MMPHHOHAPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x70A98E0", Offset = "0x70A7EE0", VA = "0x1870A98E0")]
	public GLGECJPJAOG(GLGECJPJAOG FEGJMDDBFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x70A9750", Offset = "0x70A7D50", VA = "0x1870A9750")]
	internal GLGECJPJAOG(IDJDNLONMLP HGLFGJOEPGL, [Optional] string? MMPHHOHAPGB, [Optional] GLGECJPJAOG? FEGJMDDBFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x70A7C30", Offset = "0x70A6230", VA = "0x1870A7C30")]
	public static PLEFBCEOACA DNNBBKEAELA(JDIGCFHLCBN CDNIAHDDGCA)
	{
		return default(PLEFBCEOACA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x70A8630", Offset = "0x70A6C30", VA = "0x1870A8630")]
	public void IBJILOOMAJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x70A9250", Offset = "0x70A7850", VA = "0x1870A9250")]
	internal GLGECJPJAOG NCBIPAEHFBM(GLGECJPJAOG LMLCCILBCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x70A8090", Offset = "0x70A6690", VA = "0x1870A8090")]
	internal IReadOnlyCollection<JDIGCFHLCBN> GOBEFKIIDAP(GLGECJPJAOG FEGJMDDBFKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x70A8550", Offset = "0x70A6B50", VA = "0x1870A8550")]
	public bool HOIKKBINBPH(JDIGCFHLCBN CDNIAHDDGCA, bool DOLMNOKKLMN, string MICKHOLDFAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x70A78B0", Offset = "0x70A5EB0", VA = "0x1870A78B0")]
	public (bool, string) BANDHELJNAG(JDIGCFHLCBN CDNIAHDDGCA)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x70A7B40", Offset = "0x70A6140", VA = "0x1870A7B40")]
	internal void BOGHEKDDBNF(JDIGCFHLCBN CDNIAHDDGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x70A7E90", Offset = "0x70A6490", VA = "0x1870A7E90")]
	public JHBCLPEPAKD GJAHCJJGDGN(Func<IDJDNLONMLP, Guid> ENFHLCBPLIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x70A87E0", Offset = "0x70A6DE0", VA = "0x1870A87E0")]
	public void KGLMFHIHMIH(JHBCLPEPAKD FLNAOIKAOCL, Func<Guid, IDJDNLONMLP> MGPCHKAKLHL, [Optional] IDJDNLONMLP? ABMGFHCHMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x70A7A60", Offset = "0x70A6060", VA = "0x1870A7A60")]
	[CompilerGenerated]
	private void BICDPGJBGMB(JDIGCFHLCBN GPJBFHLHGBJ, OFKEOGADKPH LCFEAILKLJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LIKHOJKNCFH : BGFCEEHHJAF, GCHMLCFDFJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class POELKFEHEHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public GLGECJPJAOG newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public POELKFEHEHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x70B1330", Offset = "0x70AF930", VA = "0x1870B1330")]
		internal bool EBJMFHMEMOC(GLGECJPJAOG rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class HFFJBDAHPKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public IDJDNLONMLP roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HFFJBDAHPKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x70A9960", Offset = "0x70A7F60", VA = "0x1870A9960")]
		internal bool MKGPPBILPLL(IDJDNLONMLP r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct AFNCHIOFPNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public LIKHOJKNCFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public POGNJKLFFHD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<AIMNGHMNFAE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x70A5100", Offset = "0x70A3700", VA = "0x1870A5100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x70A5770", Offset = "0x70A3D70", VA = "0x1870A5770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NFHGEGOOPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NFHGEGOOPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x70B0630", Offset = "0x70AEC30", VA = "0x1870B0630")]
		internal void DHAMKMBIJOM(JHBCLPEPAKD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x70B0710", Offset = "0x70AED10", VA = "0x1870B0710")]
		internal void PFEGHIKPKIE(JHBCLPEPAKD r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct EJFNKOPALNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public POGNJKLFFHD roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OKDOJCHHMDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public Func<JHBCLPEPAKD, OFKEOGADKPH> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public OKDOJCHHMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x70B12D0", Offset = "0x70AF8D0", VA = "0x1870B12D0")]
		internal void KELGOPBGHBH(JHBCLPEPAKD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x70B12A0", Offset = "0x70AF8A0", VA = "0x1870B12A0")]
		internal void FEKKCLPKILD(JHBCLPEPAKD r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x70B1300", Offset = "0x70AF900", VA = "0x1870B1300")]
		internal void NIDNGJJGDBA(JHBCLPEPAKD r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HMMFEPEKHHG<T> where T : notnull
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
			public HMMFEPEKHHG<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<AIMNGHMNFAE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x3586A80", Offset = "0x3585080", VA = "0x183586A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA798A0", Offset = "0xA77EA0", VA = "0x180A798A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public JDIGCFHLCBN rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public IDJDNLONMLP accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PLEFBCEOACA recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public string serializedNewValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LIKHOJKNCFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public Action onComplete;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HMMFEPEKHHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3D4F330", Offset = "0x3D4D930", VA = "0x183D4F330")]
		[AsyncStateMachine(typeof(HMMFEPEKHHG<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void GJFOLKHEJBN()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct JMJKFAOHJNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public IReadOnlyList<DLCNHKKPELP> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct GDDHODKCCOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public DKBGPFFCGBH rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public POGNJKLFFHD roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public IReadOnlyDictionary<IDJDNLONMLP, GLGECJPJAOG> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public JILCFFKJCFH debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x70A6C50", Offset = "0x70A5250", VA = "0x1870A6C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x70A7760", Offset = "0x70A5D60", VA = "0x1870A7760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly DKBGPFFCGBH CNDJNCBBGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EIGJKDLPKDB HNJJMJNJOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly JILCFFKJCFH JMJIOGGBFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Dictionary<int, GLGECJPJAOG> LCBGLOEHJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	internal readonly Dictionary<IDJDNLONMLP, GLGECJPJAOG> KLHCKLHGKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	internal readonly Dictionary<IDJDNLONMLP, GLGECJPJAOG> IPBAKIKLDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	internal readonly List<GLGECJPJAOG> MOJDONHANFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private bool ALLKFLPEBAF;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly JDIGCFHLCBN[] BNDFJNNJMPD;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GKKKMDAEABP JMAALHEFDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<ILNKEDGOOPM> HEIIBGALOBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x70ABBB0", Offset = "0x70AA1B0", VA = "0x1870ABBB0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event JBFOPFGHCEA IALJGLDFNJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x70AE050", Offset = "0x70AC650", VA = "0x1870AE050", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x70AE160", Offset = "0x70AC760", VA = "0x1870AE160", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x70ADAA0", Offset = "0x70AC0A0", VA = "0x1870ADAA0")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Room, CFIDNIINJOK.None)]
	private static void EPFABJKOPAP(JJHPIOCMJGA KDALJJNBEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x70B0370", Offset = "0x70AE970", VA = "0x1870B0370")]
	[UnityEngine.Scripting.Preserve]
	internal LIKHOJKNCFH([JLPFJOFFNLM(null)] DKBGPFFCGBH FLPCFPCAOLO, [JLPFJOFFNLM(null)] EIGJKDLPKDB JMEMDCNNMPB, [JLPFJOFFNLM(null)] JILCFFKJCFH JMJIOGGBFLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x70AC760", Offset = "0x70AAD60", VA = "0x1870AC760", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x70AC870", Offset = "0x70AAE70", VA = "0x1870AC870")]
	private void EBANHDGGMHH(IEnumerable<GLGECJPJAOG> JMCKCFIJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x70ABAE0", Offset = "0x70AA0E0", VA = "0x1870ABAE0", Slot = "12")]
	public bool BPHIBGLFGLK(HDIGMKHIDBN PGLIJHMIECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x70AFC10", Offset = "0x70AE210", VA = "0x1870AFC10")]
	private void OONEKJBAKPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x70AF5D0", Offset = "0x70ADBD0", VA = "0x1870AF5D0")]
	private void NONAAEAGEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x70ADDA0", Offset = "0x70AC3A0", VA = "0x1870ADDA0", Slot = "10")]
	public IReadOnlyList<ILNKEDGOOPM> JBIDFOOEPPC(bool KBEEJPHPGBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x70AF7B0", Offset = "0x70ADDB0", VA = "0x1870AF7B0", Slot = "11")]
	public ILNKEDGOOPM OIKJMLCFAIA(HDIGMKHIDBN PGLIJHMIECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x70AF490", Offset = "0x70ADA90", VA = "0x1870AF490")]
	private IDJDNLONMLP NLIEGIMFFOI(HDIGMKHIDBN PGLIJHMIECI)
	{
		return default(IDJDNLONMLP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x70AE570", Offset = "0x70ACB70", VA = "0x1870AE570", Slot = "14")]
	public bool LBABPPPKJOP(HDIGMKHIDBN LLEMICNBOGL, IDJDNLONMLP NDDNAIHEOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x70AC380", Offset = "0x70AA980", VA = "0x1870AC380", Slot = "15")]
	public ILNKEDGOOPM CKBIKMDEPIH(IDJDNLONMLP NDDNAIHEOGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x70AE700", Offset = "0x70ACD00", VA = "0x1870AE700")]
	private static bool LIKGKGIOAEO(PFCLKLEFGIG IICGBFBMNHD, IDJDNLONMLP NDDNAIHEOGI, [Out] JHBCLPEPAKD? FBJICFDJFEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x70AFEB0", Offset = "0x70AE4B0", VA = "0x1870AFEB0")]
	private static void PAHHJKBDGNH(PFCLKLEFGIG IICGBFBMNHD, Action<JHBCLPEPAKD> AFGJNKMFGFL, IDJDNLONMLP LKKCMBFBOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x70AFC20", Offset = "0x70AE220", VA = "0x1870AFC20")]
	private static void PAHHJKBDGNH(PFCLKLEFGIG IICGBFBMNHD, Action<JHBCLPEPAKD> AFGJNKMFGFL, Predicate<IDJDNLONMLP> ANAOFMNPGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x70AE0F0", Offset = "0x70AC6F0", VA = "0x1870AE0F0")]
	private void KGIGLPBCFLM(HDIGMKHIDBN PGLIJHMIECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x70AB9C0", Offset = "0x70A9FC0", VA = "0x1870AB9C0", Slot = "4")]
	[AsyncStateMachine(typeof(AFNCHIOFPNM))]
	public Task BMLMMMFOBMG([CanBeNull] POGNJKLFFHD BMLBCLGKFJE, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
	public void JALEHJOHLEP(POGNJKLFFHD BMLBCLGKFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x70AC420", Offset = "0x70AAA20", VA = "0x1870AC420")]
	private void DHNHHKJJBID(PFCLKLEFGIG HJINKDGLGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x70AEB40", Offset = "0x70AD140", VA = "0x1870AEB40")]
	internal static string MNEACFANCCL(DKBGPFFCGBH CNDJNCBBGOM, POGNJKLFFHD BMLBCLGKFJE, IReadOnlyDictionary<IDJDNLONMLP, GLGECJPJAOG> KLHCKLHGKLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x70AAC60", Offset = "0x70A9260", VA = "0x1870AAC60")]
	private static void ABNHJGCPECH(POGNJKLFFHD BMLBCLGKFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x70AF8C0", Offset = "0x70ADEC0", VA = "0x1870AF8C0")]
	private static void OLGEDKOHGBN(PFCLKLEFGIG AKBMALEHBDA, IReadOnlyDictionary<IDJDNLONMLP, GLGECJPJAOG> KLHCKLHGKLF, StringBuilder JEMLHHKEJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x70AEA30", Offset = "0x70AD030", VA = "0x1870AEA30")]
	private static bool MEABLNPPEDK(string HCGFFKDJBGK, [Out] Guid IDJALDPPFIE, [Out] IDJDNLONMLP NDDNAIHEOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x70AD0C0", Offset = "0x70AB6C0", VA = "0x1870AD0C0")]
	private static void EEDBJKPHALB(POGNJKLFFHD BMLBCLGKFJE, StringBuilder JEMLHHKEJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2C15E50", Offset = "0x2C14450", VA = "0x182C15E50", Slot = "16")]
	public bool NFNICJPFEJI<T>(IDJDNLONMLP NDDNAIHEOGI, JDIGCFHLCBN CDNIAHDDGCA, bool DOLMNOKKLMN, T BBMJLAKPCGK, [Optional] Action OFPHNFLEKIB) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x70AF560", Offset = "0x70ADB60", VA = "0x1870AF560", Slot = "17")]
	public string NNPFLJPONPP(JDIGCFHLCBN CDNIAHDDGCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x70AFFA0", Offset = "0x70AE5A0", VA = "0x1870AFFA0")]
	private void PEOOKOLIPAL(IDJDNLONMLP NDDNAIHEOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x70AEE50", Offset = "0x70AD450", VA = "0x1870AEE50")]
	private bool NEEADAOPECJ(HDIGMKHIDBN PGLIJHMIECI, IDJDNLONMLP NDDNAIHEOGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x70AEE70", Offset = "0x70AD470", VA = "0x1870AEE70")]
	internal GLGECJPJAOG NFGHNEFEEJA(HDIGMKHIDBN PGLIJHMIECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x70ADD90", Offset = "0x70AC390", VA = "0x1870ADD90", Slot = "13")]
	public IReadOnlyList<ILNKEDGOOPM> HHAAKBCCHFF(HDIGMKHIDBN PGLIJHMIECI, bool MFEIEDLPNHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x70ADE20", Offset = "0x70AC420", VA = "0x1870ADE20")]
	internal IReadOnlyList<GLGECJPJAOG> JDKNPBGHACI(HDIGMKHIDBN PGLIJHMIECI, bool MFEIEDLPNHB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x70ABC00", Offset = "0x70AA200", VA = "0x1870ABC00")]
	private void CIMEFLAGMIG(AIMNGHMNFAE FOIHOGNDOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x70AF1B0", Offset = "0x70AD7B0", VA = "0x1870AF1B0")]
	private static bool NKDEFNKNJAC(GLGECJPJAOG MCOOCDFEALJ, IReadOnlyDictionary<IDJDNLONMLP, GLGECJPJAOG> KLHCKLHGKLF, [Out] IReadOnlyList<JDIGCFHLCBN> FHDKPAAEEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x70ADC50", Offset = "0x70AC250", VA = "0x1870ADC50")]
	[AsyncStateMachine(typeof(GDDHODKCCOC))]
	private static Task FEBMGNMFKMJ(DKBGPFFCGBH CNDJNCBBGOM, POGNJKLFFHD BMLBCLGKFJE, IReadOnlyDictionary<IDJDNLONMLP, GLGECJPJAOG> KLHCKLHGKLF, JILCFFKJCFH JMJIOGGBFLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x70AD800", Offset = "0x70ABE00", VA = "0x1870AD800")]
	[CompilerGenerated]
	internal static void EKLODNCNGNJ(Func<JHBCLPEPAKD, OFKEOGADKPH> BANPLEIMDFN, EJFNKOPALNA P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x70AE200", Offset = "0x70AC800", VA = "0x1870AE200")]
	[CompilerGenerated]
	internal static bool KLKFHPOPDBM(IDJDNLONMLP NDDNAIHEOGI, JDIGCFHLCBN CDNIAHDDGCA, [Out] DLCNHKKPELP DGOEPBJKAMG, JMJKFAOHJNA P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KAHEDGPJKHL
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AEMCKEEKDIG(HDIGMKHIDBN MEABPLLNLKN, HDIGMKHIDBN JNDKLJMEBLB, IEnumerable<HDIGMKHIDBN> BFKOECPFIIJ, [Out] BPCDFINEJLB GBHILMFANFL, [Out] HGAFCBADFAI KLMMJGIICGA);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NFNAFKFBDEN(HGAFCBADFAI MKFKCINHBFK);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum HGAFCBADFAI : byte
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
internal class JFEDPEODKLI : KAHEDGPJKHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly GCHMLCFDFJL KPIMEGIFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly OOIMHJLKHBB OKMLMDLACKJ;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x86D260", Offset = "0x86B860", VA = "0x18086D260")]
	[RecRoom.NoEngine.Common.Preserve]
	public JFEDPEODKLI([JLPFJOFFNLM(null)] GCHMLCFDFJL HHIGBOAHFIB, [JLPFJOFFNLM(null)] OOIMHJLKHBB JHBHDPINALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x70AA090", Offset = "0x70A8690", VA = "0x1870AA090")]
	private static IPCLLIFIJEG? MBGFPIOEELH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x70A9970", Offset = "0x70A7F70", VA = "0x1870A9970", Slot = "4")]
	public bool AEMCKEEKDIG(HDIGMKHIDBN MEABPLLNLKN, HDIGMKHIDBN JNDKLJMEBLB, IEnumerable<HDIGMKHIDBN> BFKOECPFIIJ, [Out] BPCDFINEJLB GBHILMFANFL, [Out] HGAFCBADFAI KLMMJGIICGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x70AA0D0", Offset = "0x70A86D0", VA = "0x1870AA0D0", Slot = "5")]
	public string NFNAFKFBDEN(HGAFCBADFAI MKFKCINHBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x70A9A70", Offset = "0x70A8070", VA = "0x1870A9A70")]
	internal bool LFEOCODHPBA(HDIGMKHIDBN MEABPLLNLKN, HDIGMKHIDBN JNDKLJMEBLB, IEnumerable<HDIGMKHIDBN> BFKOECPFIIJ, EKOKDGMBHGJ GGGFNCHABMK, IPCLLIFIJEG? PFBJOPHJOFD, [Out] BPCDFINEJLB GBHILMFANFL, [Out] HGAFCBADFAI KLMMJGIICGA)
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
