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
		[Cpp2IlInjected.Address(RVA = "0x79A600", Offset = "0x799600", VA = "0x18079A600")]
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
		[Cpp2IlInjected.Address(RVA = "0x64310D0", Offset = "0x64300D0", VA = "0x1864310D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79B560", Offset = "0x79A560", VA = "0x18079B560")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B5A0", Offset = "0x79A5A0", VA = "0x18079B5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OMNPIHMBIGM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Vote,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Instant,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Off
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JFAPMFJAGCJ<TPermission>(TPermission BBODAJLOAPB);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void CHKAEKKIDLN(HANCNHADEOE ADFODKEMPJP);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum KMHIGKLCPOG
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Hosts,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Everyone
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NHMNOJPJPFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BMEOKFONCCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool KIBDDEFCGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ENJOKIPPOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNMFNJHLADP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool EOOOCJKPKOH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GIONEKJADEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal static class LMDDDIBEKOL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[Flags]
	public enum NBFANFDLHIP
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
	public static readonly Guid HGMHCNDFLBJ;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public static readonly Guid JHBMGDMMAFC;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly Guid CLPEFPHODFH;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static readonly Guid KIPPAHFJOJB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public static readonly Guid GMBJKFAOAJP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static readonly Guid DEOFNGHBOMC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly GKCOMMCOGDC<AHGDGDEKINO, Guid> AGHOLJBECHO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	internal static IEnumerable<AHGDGDEKINO> IKMEKOBMCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6430B70", Offset = "0x642FB70", VA = "0x186430B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64309A0", Offset = "0x642F9A0", VA = "0x1864309A0")]
	public static AHGDGDEKINO EMJNGGNBILB(Guid BCPPFHNPEMA)
	{
		return default(AHGDGDEKINO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6430C70", Offset = "0x642FC70", VA = "0x186430C70")]
	public static Guid OMFFEJIGMMI(AHGDGDEKINO BKLDOBCPMOF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6430A30", Offset = "0x642FA30", VA = "0x186430A30")]
	public static bool FJDNMMBFIGD(AHGDGDEKINO BKLDOBCPMOF, [Out] Guid BCPPFHNPEMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6430900", Offset = "0x642F900", VA = "0x186430900")]
	public static bool DKDBNEDNIEH(Guid BCPPFHNPEMA, [Out] AHGDGDEKINO BKLDOBCPMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6430C30", Offset = "0x642FC30", VA = "0x186430C30")]
	public static AHGDGDEKINO LBACGJOHFKA(AHGDGDEKINO BKLDOBCPMOF)
	{
		return default(AHGDGDEKINO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6430AC0", Offset = "0x642FAC0", VA = "0x186430AC0")]
	public static NBFANFDLHIP FLGLJLJABJN(AHGDGDEKINO HMHOKGIMFPP)
	{
		return default(NBFANFDLHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6430BF0", Offset = "0x642FBF0", VA = "0x186430BF0")]
	internal static AHGDGDEKINO IMNOFKEJFKH(NBFANFDLHIP IDOBJCDBIJN)
	{
		return default(AHGDGDEKINO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LAANLCJHLEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BLGEJKKPJEA FMNJLAIEMKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IEnumerable<MBGGKDGALBN> AJFGFHMBEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event CHKAEKKIDLN JNJNKGOFGFH;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IReadOnlyList<MBGGKDGALBN> MNAABJHDLHC(bool DNHKJJLHBEJ = false);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MBGGKDGALBN EBGDCNMLJLI(HANCNHADEOE ADFODKEMPJP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NDLILGODIFP(HANCNHADEOE ADFODKEMPJP);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IReadOnlyList<MBGGKDGALBN> KNGFILEJAGD(HANCNHADEOE ADFODKEMPJP, bool HBBINJDIBMP = false);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NFPHHLMMDLF(HANCNHADEOE BGPMNMENKCD, AHGDGDEKINO BKLDOBCPMOF);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MBGGKDGALBN IDLKENFIMCM(AHGDGDEKINO BKLDOBCPMOF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NLFAKAJHIFC<T>(AHGDGDEKINO BKLDOBCPMOF, KMMIINIMNBB BBODAJLOAPB, bool KKGFNCJCBDG, T DKCNDPMKPNO) where T : notnull;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GNEJNJHGPKH
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LDJOOOJOKKA(LNIMNABFGFK EINEAGMJDPE, CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIGBNPJCNHG(LNIMNABFGFK EINEAGMJDPE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KOCAFJOODCI
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HANCNHADEOE GALCGBAAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LPJIABDOGLI ABNIKJDIBIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	MCEIHIBECAG MMLJLCILFNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GBGNKBGLLMN> INFJNCHDNHP;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FIFIANIMFFO;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AHGDGDEKINO DGKEBJDNCNJ(HANCNHADEOE ADFODKEMPJP);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GBGNKBGLLMN> MKMLFMDAHJJ(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task IIDELKFANAL(long KAOIBEOBDCN, long BBEDBHIBLKF, IReadOnlyList<LDKGEDJMAPF> NFDEHAEHAIO);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<HANCNHADEOE> DIAPJBJPDPJ();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LPACNENFABN
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6431030", Offset = "0x6430030", VA = "0x186431030")]
	public static AHGDGDEKINO BFEIAPLCPLL(this KOCAFJOODCI DIAIDFNIGEM)
	{
		return default(AHGDGDEKINO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CKGOOJHEMLM<TPermission> where TPermission : notnull
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NJHJGLEBOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event JFAPMFJAGCJ<TPermission> FJBIOLDAMOJ;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal abstract class OCKOHONFCFB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public object? GGFGCCCHNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x76F1B0", Offset = "0x76E1B0", VA = "0x18076F1B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x77EBC0", Offset = "0x77DBC0", VA = "0x18077EBC0")]
	protected OCKOHONFCFB(object? CIMHOCPGGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KNEHGBCAFFN(object? APPJEOKOGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class LFBAFGLNLCH<T> : OCKOHONFCFB where T : notnull, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private T BPKEGOJMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IEqualityComparer<T> ABOMPCEIBOE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public T INAJMIAKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB0", Offset = "0x81DBB0", VA = "0x18081EBB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A74CE0", Offset = "0x3A73CE0", VA = "0x183A74CE0", Slot = "4")]
	public override bool KNEHGBCAFFN(object? APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A749B0", Offset = "0x3A739B0", VA = "0x183A749B0")]
	public bool AEAHHMIMLMO(T GIDPGCKIDNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A75200", Offset = "0x3A74200", VA = "0x183A75200")]
	public LFBAFGLNLCH(T ELMPJJEOKEH, IEqualityComparer<T> ABOMPCEIBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class ENEILGDBLJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private readonly Dictionary<KMMIINIMNBB, bool> HJNBFFOCBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly Dictionary<KMMIINIMNBB, OCKOHONFCFB> IEDOOMPLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly KPBLOHDGBDL KBDDMCJBEEI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x64260E0", Offset = "0x64250E0", VA = "0x1864260E0")]
	public ENEILGDBLJF(KPBLOHDGBDL KBDDMCJBEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6425FA0", Offset = "0x6424FA0", VA = "0x186425FA0")]
	public bool EHNNJPGFCGJ(KMMIINIMNBB BBODAJLOAPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x23C32F0", Offset = "0x23C22F0", VA = "0x1823C32F0")]
	public bool BAGHEMOBHFK<T>(KMMIINIMNBB BBODAJLOAPB, bool KKGFNCJCBDG, T APPJEOKOGAK) where T : notnull, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x23C3840", Offset = "0x23C2840", VA = "0x1823C3840")]
	public (bool, T?) ONCLNOKDIMN<T>(KMMIINIMNBB BBODAJLOAPB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6425EC0", Offset = "0x6424EC0", VA = "0x186425EC0")]
	public bool BAGHEMOBHFK(KMMIINIMNBB BBODAJLOAPB, bool KKGFNCJCBDG, object APPJEOKOGAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6426010", Offset = "0x6425010", VA = "0x186426010")]
	public (bool, object) ONCLNOKDIMN(KMMIINIMNBB BBODAJLOAPB)
	{
		return default((bool, object));
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x23C3800", Offset = "0x23C2800", VA = "0x1823C3800")]
	private void IGNAMMGMHEM<T>(KMMIINIMNBB BBODAJLOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6425DF0", Offset = "0x6424DF0", VA = "0x186425DF0")]
	private OCKOHONFCFB BADDPKGCODM(KMMIINIMNBB BBODAJLOAPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6425BF0", Offset = "0x6424BF0", VA = "0x186425BF0")]
	public void AAHJGLMEOBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class CAKPHNBPLDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly string GHBCCHGNIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly Type GKIDEINJKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly ELBFLPIMIIK EMICFNFLOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly KMMIINIMNBB BGNLIMEMGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GGMACNGCOKL BGHMMDGAJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public LEHDHFKPCIC EJLBNMIEPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public OIMIPBOCIIP CECFDFGCDMG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6424FE0", Offset = "0x6423FE0", VA = "0x186424FE0")]
	public CAKPHNBPLDC(Type FFENHMKNHNO, string ADNIEBEKHMI, KMMIINIMNBB BBODAJLOAPB, GGMACNGCOKL FPMMPKDMIGB, LEHDHFKPCIC ANIKBFJECAE, OIMIPBOCIIP KAKFGALMCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6424F90", Offset = "0x6423F90", VA = "0x186424F90")]
	public object KHGEHILJPIO(object? EJEDDDCGMMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x231D030", Offset = "0x231C030", VA = "0x18231D030")]
	public void IGNAMMGMHEM<T>()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6424EE0", Offset = "0x6423EE0", VA = "0x186424EE0")]
	public void IGNAMMGMHEM(Type MMKOIJOINLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NDBBIEKMPBP<T> : CAKPHNBPLDC where T : new()
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal delegate string CHIGNLPKMJD(T APPJEOKOGAK);

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal delegate T ODOMBICBEJJ(string? NAEPIEAMGBK, T ELMPJJEOKEH);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class GBMMCCEMONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CHIGNLPKMJD serializeRecNetString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public ODOMBICBEJJ parseRecNetString;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public GBMMCCEMONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x34FD310", Offset = "0x34FC310", VA = "0x1834FD310")]
		internal string OOPOJJJHBLC(object? v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x34FD160", Offset = "0x34FC160", VA = "0x1834FD160")]
		internal object EIPCPEHLLJG(string? s, object d)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DE20", Offset = "0x3D0CE20", VA = "0x183D0DE20")]
	public NDBBIEKMPBP(KMMIINIMNBB BBODAJLOAPB, string ADNIEBEKHMI, [Optional] CHIGNLPKMJD? FPMMPKDMIGB, [Optional] ODOMBICBEJJ? ANIKBFJECAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CD50", Offset = "0x3D0BD50", VA = "0x183D0CD50")]
	private static object? AJBPOCIDFHA(ODOMBICBEJJ? ANIKBFJECAE, string? NAEPIEAMGBK, object? ELMPJJEOKEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D630", Offset = "0x3D0C630", VA = "0x183D0D630")]
	private static string KJONJHMMAMK(CHIGNLPKMJD? JADKPEFBEFL, object? APPJEOKOGAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal delegate string GGMACNGCOKL(object? APPJEOKOGAK);
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal delegate object LEHDHFKPCIC(string? NAEPIEAMGBK, [Optional] object ELMPJJEOKEH);
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal delegate OCKOHONFCFB OIMIPBOCIIP();
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class KPBLOHDGBDL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class LGNDKBLAMGC : IEqualityComparer<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		internal static LGNDKBLAMGC NKFKDADGOPA;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x64305C0", Offset = "0x642F5C0", VA = "0x1864305C0", Slot = "4")]
		public bool Equals(List<string> LNKHMLIBJEP, List<string> DLOPBGEOAKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6430710", Offset = "0x642F710", VA = "0x186430710", Slot = "5")]
		public int GetHashCode(List<string> GPCHHCACPPJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public LGNDKBLAMGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class ODBOMCCPBCN : PGJGCHCDCHE<OMNPIHMBIGM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6431150", Offset = "0x6430150", VA = "0x186431150", Slot = "9")]
		public override string KJONJHMMAMK(OMNPIHMBIGM JPKFBEJOHFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6431240", Offset = "0x6430240", VA = "0x186431240", Slot = "10")]
		protected override bool NDCCBNIMJMF(string JPKFBEJOHFJ, [Out] OMNPIHMBIGM APPJEOKOGAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6431420", Offset = "0x6430420", VA = "0x186431420")]
		public ODBOMCCPBCN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly MMNGFPDFLEE PEOJCBAJFEE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static readonly ODBOMCCPBCN NFDBIKOCAHM;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private static readonly List<CAKPHNBPLDC> POMMENPEAEM;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<KMMIINIMNBB> JGOMDBJCLBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IReadOnlyDictionary<KMMIINIMNBB, CAKPHNBPLDC> AOAHNHKBOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6430270", Offset = "0x642F270", VA = "0x186430270")]
	public KPBLOHDGBDL([Optional] IList<CAKPHNBPLDC>? KEPDPBHMIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x642F400", Offset = "0x642E400", VA = "0x18642F400")]
	public CAKPHNBPLDC ELPIKONADME(KMMIINIMNBB BBODAJLOAPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface BLGEJKKPJEA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MBGGKDGALBN PHNCCGOABFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class IDPNKALLIJK : BLGEJKKPJEA
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static IDPNKALLIJK MLFMPHDEMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal readonly GJPIMMMOJDC PLAOJBLAGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal readonly IReadOnlyList<GJPIMMMOJDC> LKGEFPMKANO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MBGGKDGALBN PHNCCGOABFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E200", VA = "0x18076F200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x64291A0", Offset = "0x64281A0", VA = "0x1864291A0")]
	public IDPNKALLIJK(GJPIMMMOJDC GCBIMFNOOBF, IReadOnlyList<GJPIMMMOJDC> JCFHDJMCEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6428770", Offset = "0x6427770", VA = "0x186428770")]
	private static IDPNKALLIJK KONGNEPJIDJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CLIEPIEGHBH
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<AHGDGDEKINO> HLLDBHMFJEB;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6425100", Offset = "0x6424100", VA = "0x186425100")]
	public static bool MDFEMPOLACF(this HANCNHADEOE AENINCMMGKC, AHGDGDEKINO BKLDOBCPMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6425080", Offset = "0x6424080", VA = "0x186425080")]
	public static bool DCGEENABBGF(this HANCNHADEOE AENINCMMGKC, AHGDGDEKINO BKLDOBCPMOF, MCEIHIBECAG HJBIKPLBJHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface LGCOMGAKCHE
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool FPJCPDBKMPG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GDNNOJFCCMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JGMMDCFPEEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MPHHGOPIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KMIBKCJGAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BFELDJIMPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool NCGHIBPJDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool CEIDOGIJKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool PCEADAOICBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EKNJECIIEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool IICKDFBCIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool HCPBLFBBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	IReadOnlyList<string> LDBFLHJCKBN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OMNPIHMBIGM BJCOOGOFPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface MBGGKDGALBN : LGCOMGAKCHE, NHMNOJPJPFJ, CKGOOJHEMLM<KMMIINIMNBB>
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string IHGGMFMONCM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	AHGDGDEKINO HBKCECLGABH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	(bool, T?) GCNKJCBMONG<T>(KMMIINIMNBB BBODAJLOAPB) where T : new();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum KMMIINIMNBB
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
internal class GJPIMMMOJDC : MBGGKDGALBN, LGCOMGAKCHE, NHMNOJPJPFJ, CKGOOJHEMLM<KMMIINIMNBB>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal static readonly KPBLOHDGBDL FNDJEOKPDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	internal readonly ENEILGDBLJF OJIHNJEMCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private string? BKEIHJBLJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private string? FIBDLJDIPLP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool FCNMKPIFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6426CB0", Offset = "0x6425CB0", VA = "0x186426CB0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool KPDKNMMOHBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6426D80", Offset = "0x6425D80", VA = "0x186426D80", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private bool NOOJGCEALDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6426C10", Offset = "0x6425C10", VA = "0x186426C10", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool JKCDDKDACOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6426EC0", Offset = "0x6425EC0", VA = "0x186426EC0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private bool AJMKOJAADPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6426BC0", Offset = "0x6425BC0", VA = "0x186426BC0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool DMNILMFIDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6426B20", Offset = "0x6425B20", VA = "0x186426B20", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public AHGDGDEKINO HBKCECLGABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x81EBB0", Offset = "0x81DBB0", VA = "0x18081EBB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(AHGDGDEKINO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7775F0", Offset = "0x7765F0", VA = "0x1807775F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public string NJHJGLEBOHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6426F10", Offset = "0x6425F10", VA = "0x186426F10", Slot = "29")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6427590", Offset = "0x6426590", VA = "0x186427590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string IHGGMFMONCM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6426F10", Offset = "0x6425F10", VA = "0x186426F10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool HBHAOOKEDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x822440", Offset = "0x821440", VA = "0x180822440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x821D40", Offset = "0x820D40", VA = "0x180821D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool FPJCPDBKMPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6427190", Offset = "0x6426190", VA = "0x186427190", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public OMNPIHMBIGM BJCOOGOFPCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6426FF0", Offset = "0x6425FF0", VA = "0x186426FF0", Slot = "20")]
		get
		{
			return default(OMNPIHMBIGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool GDNNOJFCCMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6427490", Offset = "0x6426490", VA = "0x186427490", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool JGMMDCFPEEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6427040", Offset = "0x6426040", VA = "0x186427040", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool MPHHGOPIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x64275E0", Offset = "0x64265E0", VA = "0x1864275E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool KMIBKCJGAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6427AE0", Offset = "0x6426AE0", VA = "0x186427AE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool BFELDJIMPBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x64265B0", Offset = "0x64255B0", VA = "0x1864265B0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool NCGHIBPJDIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6426C60", Offset = "0x6425C60", VA = "0x186426C60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool CEIDOGIJKIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6427A90", Offset = "0x6426A90", VA = "0x186427A90", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool PCEADAOICBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6426DD0", Offset = "0x6425DD0", VA = "0x186426DD0", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IReadOnlyList<string> LDBFLHJCKBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x64273E0", Offset = "0x64263E0", VA = "0x1864273E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool HPLBLHOOCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6426CB0", Offset = "0x6425CB0", VA = "0x186426CB0", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool LLOEBBJPHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6426BC0", Offset = "0x6425BC0", VA = "0x186426BC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EBBMFACEEFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6426D80", Offset = "0x6425D80", VA = "0x186426D80", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool EKNJECIIEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6426E20", Offset = "0x6425E20", VA = "0x186426E20", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool IICKDFBCIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6426E70", Offset = "0x6425E70", VA = "0x186426E70", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EAKENGAOMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6426C10", Offset = "0x6425C10", VA = "0x186426C10", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool HCPBLFBBHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6427440", Offset = "0x6426440", VA = "0x186427440", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FKMINEDMFBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6426EC0", Offset = "0x6425EC0", VA = "0x186426EC0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GMFBKPPAIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6426B20", Offset = "0x6425B20", VA = "0x186426B20", Slot = "35")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JFAPMFJAGCJ<KMMIINIMNBB> FJBIOLDAMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6426600", Offset = "0x6425600", VA = "0x186426600", Slot = "27")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x64274E0", Offset = "0x64264E0", VA = "0x1864274E0", Slot = "28")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x24EF2F0", Offset = "0x24EE2F0", VA = "0x1824EF2F0", Slot = "6")]
	public (bool, T?) GCNKJCBMONG<T>(KMMIINIMNBB BBODAJLOAPB) where T : new()
	{
		return default((bool, T));
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x24EF480", Offset = "0x24EE480", VA = "0x1824EF480")]
	public GJPIMMMOJDC LAPCFCCLLLO<T>(KMMIINIMNBB BBODAJLOAPB, bool KKGFNCJCBDG, T APPJEOKOGAK) where T : notnull, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x64285F0", Offset = "0x64275F0", VA = "0x1864285F0")]
	public GJPIMMMOJDC(AHGDGDEKINO BKLDOBCPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x64285D0", Offset = "0x64275D0", VA = "0x1864285D0")]
	public GJPIMMMOJDC(AHGDGDEKINO BKLDOBCPMOF, [Optional] string? BKEIHJBLJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6428540", Offset = "0x6427540", VA = "0x186428540")]
	public GJPIMMMOJDC(GJPIMMMOJDC BKCKMNFOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6428610", Offset = "0x6427610", VA = "0x186428610")]
	internal GJPIMMMOJDC(AHGDGDEKINO AIMLNCBNJLA, [Optional] string? BKEIHJBLJDH, [Optional] GJPIMMMOJDC? BKCKMNFOHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6426D00", Offset = "0x6425D00", VA = "0x186426D00")]
	public static ELBFLPIMIIK EGADIBJLLBH(KMMIINIMNBB BBODAJLOAPB)
	{
		return default(ELBFLPIMIIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6426590", Offset = "0x6425590", VA = "0x186426590")]
	public void AAHJGLMEOBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6427710", Offset = "0x6426710", VA = "0x186427710")]
	internal GJPIMMMOJDC NJHDLBONFKF(GJPIMMMOJDC NFLEEFCGFJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x64266B0", Offset = "0x64256B0", VA = "0x1864266B0")]
	internal IReadOnlyCollection<KMMIINIMNBB> BDJPDEJCMDM(GJPIMMMOJDC BKCKMNFOHEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6427630", Offset = "0x6426630", VA = "0x186427630")]
	public bool NEGILCADGFN(KMMIINIMNBB BBODAJLOAPB, bool KKGFNCJCBDG, string EKNNKJMBIKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6427090", Offset = "0x6426090", VA = "0x186427090")]
	public (bool, string) HMBKFCKLPDB(KMMIINIMNBB BBODAJLOAPB)
	{
		return default((bool, string));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6426B70", Offset = "0x6425B70", VA = "0x186426B70")]
	internal void CEHLPPEFIDO(KMMIINIMNBB BBODAJLOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x64271E0", Offset = "0x64261E0", VA = "0x1864271E0")]
	public BKPGJKOMNCK IPBBDKMJBOM(Func<AHGDGDEKINO, Guid> EJADBGCGEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6427B30", Offset = "0x6426B30", VA = "0x186427B30")]
	public void PKMCJLPNCEC(BKPGJKOMNCK FHBBLFCKEJD, Func<Guid, AHGDGDEKINO> MJGEPKECDED, [Optional] AHGDGDEKINO? FLCOBGOBDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6426F60", Offset = "0x6425F60", VA = "0x186426F60")]
	[CompilerGenerated]
	private void HDDNFFCANEB(KMMIINIMNBB NCJKPHKDDDK, EGEOKLPPDBH GEDNNKPCJKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class IIBOPMMPPBL : GNEJNJHGPKH, LAANLCJHLEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class MHLJJGAEFPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public GJPIMMMOJDC newRole;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MHLJJGAEFPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x64310A0", Offset = "0x64300A0", VA = "0x1864310A0")]
		internal bool PFKFDNIKNDG(GJPIMMMOJDC rc)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class MBHGDGGADEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AHGDGDEKINO roleTypeToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public MBHGDGGADEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6431090", Offset = "0x6430090", VA = "0x186431090")]
		internal bool ELAKIEAKAJF(AHGDGDEKINO r)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct KKLLMACKCJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public IIBOPMMPPBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LNIMNABFGFK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool <isOffline>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter<GBGNKBGLLMN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x642ED40", Offset = "0x642DD40", VA = "0x18642ED40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x642F3A0", Offset = "0x642E3A0", VA = "0x18642F3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class FJDHLAKKPFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public StringBuilder migrationMessageBuilder;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public FJDHLAKKPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x64264B0", Offset = "0x64254B0", VA = "0x1864264B0")]
		internal void HFBNILKFKLO(BKPGJKOMNCK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6426390", Offset = "0x6425390", VA = "0x186426390")]
		internal void BCEOLPHPAEK(BKPGJKOMNCK r)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LFBIHKFKKHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LNIMNABFGFK roomData;
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BODLAHCJNPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Func<BKPGJKOMNCK, EGEOKLPPDBH> dataFunc;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public BODLAHCJNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6424EB0", Offset = "0x6423EB0", VA = "0x186424EB0")]
		internal void NFGGAHIHBCG(BKPGJKOMNCK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6424E50", Offset = "0x6423E50", VA = "0x186424E50")]
		internal void FPEHEPIKGKA(BKPGJKOMNCK r)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6424E80", Offset = "0x6423E80", VA = "0x186424E80")]
		internal void KGONNFNOHBJ(BKPGJKOMNCK r)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AHKLBAGDOLG<T> where T : notnull
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
			public AHKLBAGDOLG<T> <>4__this;

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
			private TaskAwaiter<GBGNKBGLLMN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2F61D00", Offset = "0x2F60D00", VA = "0x182F61D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8C2E60", Offset = "0x8C1E60", VA = "0x1808C2E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public IIBOPMMPPBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public KMMIINIMNBB rolePermission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AHGDGDEKINO accountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public ELBFLPIMIIK recNetPermissionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public string serializedNewValue;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
		public AHKLBAGDOLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x355E0F0", Offset = "0x355D0F0", VA = "0x18355E0F0")]
		[AsyncStateMachine(typeof(AHKLBAGDOLG<>.<<LocalRequestModifyRolePermission>g__ChangeAndRefresh|0>d))]
		internal void HMIDKNEHDJH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PGKGGHBJCDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public IReadOnlyList<LDKGEDJMAPF> newPermissionOverrides;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct PJEBJLOBPEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KOCAFJOODCI rolesDataProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LNIMNABFGFK roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public IReadOnlyDictionary<AHGDGDEKINO, GJPIMMMOJDC> defaultRoles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PKBIFGBFCCE debugLogger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6431460", Offset = "0x6430460", VA = "0x186431460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6431F70", Offset = "0x6430F70", VA = "0x186431F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly KOCAFJOODCI DIAIDFNIGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly IDPNKALLIJK FDIIAAFJKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly PKBIFGBFCCE FKJNOLJAAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly Dictionary<int, GJPIMMMOJDC> KDGLMACJNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly Dictionary<AHGDGDEKINO, GJPIMMMOJDC> INBIGAHCMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal readonly Dictionary<AHGDGDEKINO, GJPIMMMOJDC> LJAHPKDDEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal readonly List<GJPIMMMOJDC> OHLHMOOKAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private bool PMGAKCCHGLK;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly KMMIINIMNBB[] MAHIGGDDJHG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BLGEJKKPJEA FMNJLAIEMKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public IEnumerable<MBGGKDGALBN> AJFGFHMBEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x642BBB0", Offset = "0x642ABB0", VA = "0x18642BBB0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event CHKAEKKIDLN JNJNKGOFGFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x642BC00", Offset = "0x642AC00", VA = "0x18642BC00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x642BF90", Offset = "0x642AF90", VA = "0x18642BF90", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x642CEF0", Offset = "0x642BEF0", VA = "0x18642CEF0")]
	[PKDJMILODMH(OPHHJIDIAGK.Room, OMIAJJHDDGO.None)]
	private static void KIGOHJFFCIM(EIABFOFJCDK ENBCIOEOBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x642EA80", Offset = "0x642DA80", VA = "0x18642EA80")]
	[UnityEngine.Scripting.Preserve]
	internal IIBOPMMPPBL([KHIPNIHHNOH(null)] KOCAFJOODCI PJAPALMJNIE, [KHIPNIHHNOH(null)] IDPNKALLIJK NOAEJDJGNKF, [KHIPNIHHNOH(null)] PKBIFGBFCCE FKJNOLJAAGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x642A5D0", Offset = "0x64295D0", VA = "0x18642A5D0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6429620", Offset = "0x6428620", VA = "0x186429620")]
	private void AKBJNPAFDBM(IEnumerable<GJPIMMMOJDC> JHJOOKMJCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x642DE80", Offset = "0x642CE80", VA = "0x18642DE80", Slot = "12")]
	public bool NDLILGODIFP(HANCNHADEOE ADFODKEMPJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x642BBA0", Offset = "0x642ABA0", VA = "0x18642BBA0")]
	private void FIFIANIMFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x642CD00", Offset = "0x642BD00", VA = "0x18642CD00")]
	private void JENMNNMKHNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x642DE00", Offset = "0x642CE00", VA = "0x18642DE00", Slot = "10")]
	public IReadOnlyList<MBGGKDGALBN> MNAABJHDLHC(bool DNHKJJLHBEJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x642B4F0", Offset = "0x642A4F0", VA = "0x18642B4F0", Slot = "11")]
	public MBGGKDGALBN EBGDCNMLJLI(HANCNHADEOE ADFODKEMPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x642A2F0", Offset = "0x64292F0", VA = "0x18642A2F0")]
	private AHGDGDEKINO CDMDPIBOGPE(HANCNHADEOE ADFODKEMPJP)
	{
		return default(AHGDGDEKINO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x642DF50", Offset = "0x642CF50", VA = "0x18642DF50", Slot = "14")]
	public bool NFPHHLMMDLF(HANCNHADEOE BGPMNMENKCD, AHGDGDEKINO BKLDOBCPMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x642CC60", Offset = "0x642BC60", VA = "0x18642CC60", Slot = "15")]
	public MBGGKDGALBN IDLKENFIMCM(AHGDGDEKINO BKLDOBCPMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x642C030", Offset = "0x642B030", VA = "0x18642C030")]
	private static bool GOCBGNPGLOH(BAJDDEIFJDP BEGOKLLJMKL, AHGDGDEKINO BKLDOBCPMOF, [Out] BKPGJKOMNCK? PHDOIFPEMHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x642C360", Offset = "0x642B360", VA = "0x18642C360")]
	private static void HFENDOHNEBE(BAJDDEIFJDP BEGOKLLJMKL, Action<BKPGJKOMNCK> DLKIAEBKACE, AHGDGDEKINO HIMHHIGAOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x642C450", Offset = "0x642B450", VA = "0x18642C450")]
	private static void HFENDOHNEBE(BAJDDEIFJDP BEGOKLLJMKL, Action<BKPGJKOMNCK> DLKIAEBKACE, Predicate<AHGDGDEKINO> PJMCBIBKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x642E840", Offset = "0x642D840", VA = "0x18642E840")]
	private void PABNDIPBCNB(HANCNHADEOE ADFODKEMPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x642D200", Offset = "0x642C200", VA = "0x18642D200", Slot = "4")]
	[AsyncStateMachine(typeof(KKLLMACKCJJ))]
	public Task LDJOOOJOKKA([CanBeNull] LNIMNABFGFK EINEAGMJDPE, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "5")]
	public void CIGBNPJCNHG(LNIMNABFGFK EINEAGMJDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6429EA0", Offset = "0x6428EA0", VA = "0x186429EA0")]
	private void AMJIMIPEBIN(BAJDDEIFJDP KOIJHNDEOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x642B600", Offset = "0x642A600", VA = "0x18642B600")]
	internal static string EODONFFMPAG(KOCAFJOODCI DIAIDFNIGEM, LNIMNABFGFK EINEAGMJDPE, IReadOnlyDictionary<AHGDGDEKINO, GJPIMMMOJDC> INBIGAHCMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x642A6E0", Offset = "0x64296E0", VA = "0x18642A6E0")]
	private static void EBBPFNGGION(LNIMNABFGFK EINEAGMJDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x642C6E0", Offset = "0x642B6E0", VA = "0x18642C6E0")]
	private static void HLNCNBDKBCH(BAJDDEIFJDP FFDCIGHJMJL, IReadOnlyDictionary<AHGDGDEKINO, GJPIMMMOJDC> INBIGAHCMOF, StringBuilder DKAMMANCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x642A1E0", Offset = "0x64291E0", VA = "0x18642A1E0")]
	private static bool CAPIEGCAAJP(string KLPFPGJEPNP, [Out] Guid KIDLAFFGEFE, [Out] AHGDGDEKINO BKLDOBCPMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x642E0E0", Offset = "0x642D0E0", VA = "0x18642E0E0")]
	private static void NILGKEBPFDI(LNIMNABFGFK EINEAGMJDPE, StringBuilder DKAMMANCHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x250CF80", Offset = "0x250BF80", VA = "0x18250CF80", Slot = "16")]
	public bool NLFAKAJHIFC<T>(AHGDGDEKINO BKLDOBCPMOF, KMMIINIMNBB BBODAJLOAPB, bool KKGFNCJCBDG, T DKCNDPMKPNO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x642A3C0", Offset = "0x64293C0", VA = "0x18642A3C0")]
	private void DMNLGEDPIOP(AHGDGDEKINO BKLDOBCPMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x642E820", Offset = "0x642D820", VA = "0x18642E820")]
	private bool OCMOLADCPGO(HANCNHADEOE ADFODKEMPJP, AHGDGDEKINO BKLDOBCPMOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x642D320", Offset = "0x642C320", VA = "0x18642D320")]
	internal GJPIMMMOJDC LGFJPGHGPBK(HANCNHADEOE ADFODKEMPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x642D1F0", Offset = "0x642C1F0", VA = "0x18642D1F0", Slot = "13")]
	public IReadOnlyList<MBGGKDGALBN> KNGFILEJAGD(HANCNHADEOE ADFODKEMPJP, bool HBBINJDIBMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x642CA30", Offset = "0x642BA30", VA = "0x18642CA30")]
	internal IReadOnlyList<GJPIMMMOJDC> IBOBAIMKNHG(HANCNHADEOE ADFODKEMPJP, bool HBBINJDIBMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x642D670", Offset = "0x642C670", VA = "0x18642D670")]
	private void LHBEOMEPKCC(GBGNKBGLLMN AMAHDIHJANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x642BCA0", Offset = "0x642ACA0", VA = "0x18642BCA0")]
	private static bool GDPILAOJGDB(GJPIMMMOJDC CNFKPGLPHBH, IReadOnlyDictionary<AHGDGDEKINO, GJPIMMMOJDC> INBIGAHCMOF, [Out] IReadOnlyList<KMMIINIMNBB> GMECFAMDPOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x642D0B0", Offset = "0x642C0B0", VA = "0x18642D0B0")]
	[AsyncStateMachine(typeof(PJEBJLOBPEG))]
	private static Task KKLJMMNAKBB(KOCAFJOODCI DIAIDFNIGEM, LNIMNABFGFK EINEAGMJDPE, IReadOnlyDictionary<AHGDGDEKINO, GJPIMMMOJDC> INBIGAHCMOF, PKBIFGBFCCE FKJNOLJAAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x642B900", Offset = "0x642A900", VA = "0x18642B900")]
	[CompilerGenerated]
	internal static void FDFFJIFLKLM(Func<BKPGJKOMNCK, EGEOKLPPDBH> OFBPKBMCICG, LFBIHKFKKHD P_1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x64292B0", Offset = "0x64282B0", VA = "0x1864292B0")]
	[CompilerGenerated]
	internal static bool ACHGAPBGLAM(AHGDGDEKINO BKLDOBCPMOF, KMMIINIMNBB BBODAJLOAPB, [Out] LDKGEDJMAPF DJEAHOHOCDK, PGKGGHBJCDB P_3)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface KGFEDAIAPOG
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHMNAPAHHNN(HANCNHADEOE LJJKNOKNNAP, HANCNHADEOE OPIOLFMAAEI, IEnumerable<HANCNHADEOE> LHDIPDENDDA, [Out] OMNPIHMBIGM NPGLFBGDEMF, [Out] DFJCBLGIJFO IEBJLAEJAGJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string KINFJMAEIPD(DFJCBLGIJFO FHNMKDILPNG);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum DFJCBLGIJFO : byte
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
internal class EHOJBEGJDPH : KGFEDAIAPOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly LAANLCJHLEJ OBDKCPLJDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly NFOLFLPDENE LEPGAHMCPLK;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
	[RecRoom.NoEngine.Common.Preserve]
	public EHOJBEGJDPH([KHIPNIHHNOH(null)] LAANLCJHLEJ NNBLMBJGNNI, [KHIPNIHHNOH(null)] NFOLFLPDENE NKDMOPOGPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x64259B0", Offset = "0x64249B0", VA = "0x1864259B0")]
	private static EKDAFODBJMI? FKJINHPDFPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x64259F0", Offset = "0x64249F0", VA = "0x1864259F0", Slot = "4")]
	public bool KHMNAPAHHNN(HANCNHADEOE LJJKNOKNNAP, HANCNHADEOE OPIOLFMAAEI, IEnumerable<HANCNHADEOE> LHDIPDENDDA, [Out] OMNPIHMBIGM NPGLFBGDEMF, [Out] DFJCBLGIJFO IEBJLAEJAGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6425AF0", Offset = "0x6424AF0", VA = "0x186425AF0", Slot = "5")]
	public string KINFJMAEIPD(DFJCBLGIJFO FHNMKDILPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6425390", Offset = "0x6424390", VA = "0x186425390")]
	internal bool DIJCJIGHMBL(HANCNHADEOE LJJKNOKNNAP, HANCNHADEOE OPIOLFMAAEI, IEnumerable<HANCNHADEOE> LHDIPDENDDA, MCEIHIBECAG HJBIKPLBJHF, EKDAFODBJMI? LECPDPOBAKO, [Out] OMNPIHMBIGM NPGLFBGDEMF, [Out] DFJCBLGIJFO IEBJLAEJAGJ)
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
