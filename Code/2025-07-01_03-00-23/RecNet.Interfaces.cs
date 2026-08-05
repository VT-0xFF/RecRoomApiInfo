using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74906C0", Offset = "0x748ECC0", VA = "0x1874906C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HIPJFLFIKKB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum GMJBGOIGMMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string MLKIKFDCGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string LKHGEANOGNK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public GMJBGOIGMMH NNEOLEAEDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(GMJBGOIGMMH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool INKNCFAIMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2221310", Offset = "0x221F910", VA = "0x182221310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LHJPDBDACKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1915BC0", Offset = "0x19141C0", VA = "0x181915BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x748B5D0", Offset = "0x7489BD0", VA = "0x18748B5D0")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static HIPJFLFIKKB NMGKKEJKHDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x748B540", Offset = "0x7489B40", VA = "0x18748B540")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static HIPJFLFIKKB FJGDPIKDDOL([Optional] string EAKEBNEDEGE, [Optional] string PNKPIBPIKFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HIPJFLFIKKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IKCBACLDDOA
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string FCBCDLCJCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string PCEENEHLFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DCFMHPOJEED
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KCFJOGDOBPF? CBGHHJNPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IAJLDMLJHLB<FCOOFHNJDGL> MMEANCCLICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IAJLDMLJHLB<JNHGOGFLEDL> BNPMKHAJHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AMFNOLNIBCI();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<GINKBDBKNNM> MMPANIMGHOF(bool AEJFMILBJFH, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<FCICBLLIPFB<NFCFPMMJIFP>> NJPLBIEHDLB(bool IDFAICDPILO = false, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<GINKBDBKNNM> OMAKLLJJMCN([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<KBDNIMGLDPN> JGABHIHCJMC(bool KHJAECAMEMC = false, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<JBFLLDPKAIL> HPOPJEALMLH([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<GINKBDBKNNM> FMABEMBOBDJ(bool KHJAECAMEMC = false, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<GINKBDBKNNM> EDHMHEEJLJG([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<GINKBDBKNNM> LBCJIAGBICL(string LGDFKJLNNPH, Guid EBFHBCMIFNJ, long LICAODAKGNG, decimal BNNCAFAHMNG, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<FCICBLLIPFB<NFCFPMMJIFP>> CFCCMPEILKP(Guid EBFHBCMIFNJ, long LICAODAKGNG, decimal BNNCAFAHMNG, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<IKCBACLDDOA> AELKANCNJPI(string LGDFKJLNNPH, string AMDIGMMBNKG, string EBOMGDMOHFL, string? NHAIJEJPEOG, string? IKEOPJAMMMM, float EKFFLEHODKH, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task OBAIJKFPECA(string DLFENPHGOLM, string MGGELLPHCFB, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<CIHBEAMACML> JGLOHFMKPIB(string AMDIGMMBNKG, string DGCPADKLEME, bool BCNKIPKEKJB, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<ABIHHJEILJG> NNBKCMOPFCG(string? AMDIGMMBNKG, string DGCPADKLEME, string IBLIANLGKOB, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<ABIHHJEILJG> NNBKCMOPFCG(string? AMDIGMMBNKG, string DGCPADKLEME, byte[] FNIGFMCPNCM, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task<ABIHHJEILJG> AGCBIODDIJB(string? AMDIGMMBNKG, string DGCPADKLEME, string IBLIANLGKOB, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<ABIHHJEILJG> AGCBIODDIJB(string? AMDIGMMBNKG, string DGCPADKLEME, byte[] FNIGFMCPNCM, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<CIHBEAMACML> CDHDBNHKKEC(JCCNHAIEDKA IPMGANOCOKF, byte[] FNIGFMCPNCM, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<CNDLDEMGNIA> IDCMDKKFJAK(string? AMDIGMMBNKG, string DGCPADKLEME, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<KCFJOGDOBPF> IPGMLJIPKKO(string DGCPADKLEME, EMIHDJEIJLN? PDNBIKLPNEN, IReadOnlyList<EMIHDJEIJLN>? POLBANLLFPP, IReadOnlyList<string> DOOLLJLLMEN, DDLCAJLOKCJ HHBGHAKIGCN, [Optional] string? IOKNDMLKIKP, [Optional] string? IKLEJFGEIDC, [Optional] string? EJFKEBOMEMB, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task<KCFJOGDOBPF> JPMJFKLCGLI(string EFGKEPFKHGG, EMIHDJEIJLN? PDNBIKLPNEN, IReadOnlyList<string> DOOLLJLLMEN, DDLCAJLOKCJ HHBGHAKIGCN, [Optional] string? IKLEJFGEIDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task<List<string>> HIOPGLNNCDJ(string DGCPADKLEME, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task<string> HDMGKOMPCML(DDLCAJLOKCJ HHBGHAKIGCN, [Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MCMHHOGOMOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string POJDPMNMPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string AHPEPFOJIFF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string HGPGFKJICOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string HFHFIKKBCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string CKIHPGCKKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string IKFEOJEFLEG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int? MFOLADBJEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int? HOOAKIKCPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x748EE60", Offset = "0x748D460", VA = "0x18748EE60")]
	public MCMHHOGOMOJ(string BCNBFDHGEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x748ED30", Offset = "0x748D330", VA = "0x18748ED30")]
	public void IIAOMFJHFOF(string HMOPLOJCPCP = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x748ED60", Offset = "0x748D360", VA = "0x18748ED60")]
	private void MCFFELDCIKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MCMONBMNFCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HAADHJPIIJM IMMJHEGBBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<DGOBGMFDDMJ> CJGAKLFGJOD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ILEKCDJBFDF> ALPNEEICGPJ;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ILEKCDJBFDF> LPPNGPJMNMB(bool DAOBJGJLKDC = false, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MFJAPBILCGO([Out] ILEKCDJBFDF MECEKIIPOCN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NEJBOKOBNHG
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x748FC40", Offset = "0x748E240", VA = "0x18748FC40")]
	public static bool MGIIFFDNILJ(this MCMONBMNFCG BMGHPBJLCAA, [Out] DGOBGMFDDMJ LPGGMNDEDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x748FB60", Offset = "0x748E160", VA = "0x18748FB60")]
	public static bool KOPBPDKONDF(this MCMONBMNFCG BMGHPBJLCAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EGAKCOGBGMH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DEBMDBKHLEL(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PAJEHCHEODC(int HIMHKNJFHLE, [Out] AAICCAIJFFK? HHBGHAKIGCN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AAICCAIJFFK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int PGJNJACNFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string? GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string? JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool? LGKNGGDPCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? MEEJEFFMNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string? CCDDHKNCHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PHBLIMLAJDI? BIPHBBEKMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KGPOPMIEMOG(string IINDOPPMLOK, [Out] CGLMICNAPFJ? HHBGHAKIGCN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CGLMICNAPFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? HMOKHIOKDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string? PBOFLFAHHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? MOCFMKFJFFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IReadOnlyList<MPBGMKMJGIG>? CGNPOBEJJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PHBLIMLAJDI? BIPHBBEKMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	long? JNHFCMEPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MPBGMKMJGIG
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string PBOFLFAHHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	GKOHDOODPBG KLDBPEPJFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface PHBLIMLAJDI
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string PBOFLFAHHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string? HLNOCEBLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[CIADMBADCAJ]
public class NJMHCCHLMKA
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public List<OACIOJOJBAN> NFJIDFMKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Dictionary<string, string> PBDABGHLDAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x748FEB0", Offset = "0x748E4B0", VA = "0x18748FEB0")]
	public NJMHCCHLMKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[CIADMBADCAJ]
public class OACIOJOJBAN
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int PGJNJACNFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string MEEJEFFMNJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string CCDDHKNCHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool? LGKNGGDPCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xDE8720", Offset = "0xDE6D20", VA = "0x180DE8720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xDE8730", Offset = "0xDE6D30", VA = "0x180DE8730")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NJJFGKOLCLN BIPHBBEKMHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Dictionary<string, MIHELOEMKLG> BKBIFBELNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7490740", Offset = "0x748ED40", VA = "0x187490740")]
	public OACIOJOJBAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[CIADMBADCAJ]
public class NJJFGKOLCLN
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string PBOFLFAHHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string HLNOCEBLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NJJFGKOLCLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[CIADMBADCAJ]
public class MIHELOEMKLG
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string HMOKHIOKDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string PBOFLFAHHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string MOCFMKFJFFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public List<NIIGJNDCPAB> CGNPOBEJJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NJJFGKOLCLN BIPHBBEKMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public long JNHFCMEPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA47BD0", Offset = "0xA461D0", VA = "0x180A47BD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x748F950", Offset = "0x748DF50", VA = "0x18748F950")]
	public MIHELOEMKLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum GKOHDOODPBG
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	DismissDialog,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	CloseWatch,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	GoToStore,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	GoToCreate,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	GoToDayPass,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	PositiveEvent,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NegativeEvent,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CancelEvent
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CIADMBADCAJ]
public class NIIGJNDCPAB
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string PBOFLFAHHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GKOHDOODPBG KLDBPEPJFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(GKOHDOODPBG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NIIGJNDCPAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct HCCPNEHHMAJ : IEquatable<HCCPNEHHMAJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool APJGBNBBCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime BJACGDILHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool JIHBJKJPFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly KBHKIMMHEIJ? DKJEOICHFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string CBAKGCGHJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? ACCMGNEAIFA;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static HCCPNEHHMAJ DHGFBGFOGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x291C410", Offset = "0x291AA10", VA = "0x18291C410")]
		get
		{
			return default(HCCPNEHHMAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x748AAC0", Offset = "0x74890C0", VA = "0x18748AAC0")]
	public HCCPNEHHMAJ(DateTime KAHHMPMCIDH, bool AGMDOKAHEND, KBHKIMMHEIJ? IJLNCPNLJCK, string EJPFBIGFDON, int? EBMDKILOCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x748A5B0", Offset = "0x7488BB0", VA = "0x18748A5B0")]
	public DGOBGMFDDMJ DDFKAHFCIOE(HAADHJPIIJM JONGNHMEJFC)
	{
		return default(DGOBGMFDDMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x748A940", Offset = "0x7488F40", VA = "0x18748A940")]
	private static DGOBGMFDDMJ IIAADFAILGJ(HAADHJPIIJM JONGNHMEJFC, DateTime KAHHMPMCIDH)
	{
		return default(DGOBGMFDDMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x748A6F0", Offset = "0x7488CF0", VA = "0x18748A6F0", Slot = "4")]
	public bool Equals(HCCPNEHHMAJ HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x748A640", Offset = "0x7488C40", VA = "0x18748A640", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x748A890", Offset = "0x7488E90", VA = "0x18748A890", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x748A9C0", Offset = "0x7488FC0", VA = "0x18748A9C0")]
	public static bool JKIBMILPCGE(HCCPNEHHMAJ DBDIOGELIIH, HCCPNEHHMAJ LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x748A850", Offset = "0x7488E50", VA = "0x18748A850")]
	public static bool FLMCEAOBGCC(HCCPNEHHMAJ DBDIOGELIIH, HCCPNEHHMAJ LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x748A9F0", Offset = "0x7488FF0", VA = "0x18748A9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct ILEKCDJBFDF : IEquatable<ILEKCDJBFDF>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly ILEKCDJBFDF DHGFBGFOGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool LAPKEHOOABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly DGOBGMFDDMJ GDKNPDNLABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly HCCPNEHHMAJ ONFKLOCBEND;

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x748C170", Offset = "0x748A770", VA = "0x18748C170")]
	public ILEKCDJBFDF(DGOBGMFDDMJ LPGGMNDEDFD, HCCPNEHHMAJ AHFOBHAJDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x748BBB0", Offset = "0x748A1B0", VA = "0x18748BBB0", Slot = "4")]
	public bool Equals(ILEKCDJBFDF HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x748BC60", Offset = "0x748A260", VA = "0x18748BC60", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x748BEB0", Offset = "0x748A4B0", VA = "0x18748BEB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x748BF70", Offset = "0x748A570", VA = "0x18748BF70")]
	public static bool JKIBMILPCGE(ILEKCDJBFDF DBDIOGELIIH, ILEKCDJBFDF LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x748BD90", Offset = "0x748A390", VA = "0x18748BD90")]
	public static bool FLMCEAOBGCC(ILEKCDJBFDF DBDIOGELIIH, ILEKCDJBFDF LHANOGJMGBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x748C080", Offset = "0x748A680", VA = "0x18748C080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DGOBGMFDDMJ : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class HCLCHFGDHNN : HAADHJPIIJM
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string NGBEOOBHEGP = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch IALAMKCAECG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? IJGIIIGPEEF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly HCLCHFGDHNN EFKLKBOLJNG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static HAADHJPIIJM FNIBPMLJKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x748AFF0", Offset = "0x74895F0", VA = "0x18748AFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	internal static HCLCHFGDHNN BJMKHDFGGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x748AB00", Offset = "0x7489100", VA = "0x18748AB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static DateTimeOffset NPBMNKGNDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x748ADD0", Offset = "0x74893D0", VA = "0x18748ADD0")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static DateTime PJGLBNIGJFP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x748B040", Offset = "0x7489640", VA = "0x18748B040")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime ONHIDOCPJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x748AF30", Offset = "0x7489530", VA = "0x18748AF30", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTimeOffset LPALMNFFFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x748AB50", Offset = "0x7489150", VA = "0x18748AB50", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	private HCLCHFGDHNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x748ABB0", Offset = "0x74891B0", VA = "0x18748ABB0")]
	internal static void HNILPNPOLDH(DateTime? LMDLJFEAIGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum JLJKPGKKKBO
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum BKHGKLBJKKP
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[CIADMBADCAJ]
public class MGOOJHEAKEA : FCNKIMHMKLB, FDFGOOFMOHM, APOJDGIBLFD, BAFDCGEEMHK, PIEEHLBDLAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct CGNAHMGELAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public MGOOJHEAKEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x74884B0", Offset = "0x7486AB0", VA = "0x1874884B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7488860", Offset = "0x7486E60", VA = "0x187488860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static MKEMADKGGII BFMNIDMIGCC;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int IKFHJLCADHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xE21D10", Offset = "0xE20310", VA = "0x180E21D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public JHEMHCNCGNK ADMCICDNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA635B0", Offset = "0xA61BB0", VA = "0x180A635B0", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(JHEMHCNCGNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1630F50", Offset = "0x162F550", VA = "0x181630F50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool MDFJDJLJDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCCADC0", Offset = "0xCC93C0", VA = "0x180CCADC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xDC9890", Offset = "0xDC7E90", VA = "0x180DC9890")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool KNDGJGKPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xE38FD0", Offset = "0xE375D0", VA = "0x180E38FD0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xE37CD0", Offset = "0xE362D0", VA = "0x180E37CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool EBAEJHIDIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x2032DF0", Offset = "0x20313F0", VA = "0x182032DF0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2032120", Offset = "0x2030720", VA = "0x182032120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int? BOIKHJBONIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x748DDF0", Offset = "0x748C3F0", VA = "0x18748DDF0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x748DDD0", Offset = "0x748C3D0", VA = "0x18748DDD0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string IGHNIJIEOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string FHMLCMCHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA449B0", Offset = "0xA42FB0", VA = "0x180A449B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string GMMNFOEHMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xF2C2B0", Offset = "0xF2A8B0", VA = "0x180F2C2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public DateTime PEKBAAMDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xF2C970", Offset = "0xF2AF70", VA = "0x180F2C970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public JLJKPGKKKBO PJGIBBCLCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xE6CFC0", Offset = "0xE6B5C0", VA = "0x180E6CFC0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(JLJKPGKKKBO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xF7D8F0", Offset = "0xF7BEF0", VA = "0x180F7D8F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string LGGDGCODHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4AA00", VA = "0x180A4C400", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2F0", Offset = "0xA4A8F0", VA = "0x180A4C2F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int JFCLEGDNODA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xD036C0", Offset = "0xD01CC0", VA = "0x180D036C0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xD039C0", Offset = "0xD01FC0", VA = "0x180D039C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public IReadOnlyList<CEJOMCGFFIP> NFOGBMOOCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAB07D0", Offset = "0xAAEDD0", VA = "0x180AB07D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAADC60", VA = "0x180AAF660")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IReadOnlyList<INOGCDIEBNK> NOCDBJHOMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xAB07D0", Offset = "0xAAEDD0", VA = "0x180AB07D0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public CFBLIONAPIL KKOJEMLODAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA4C3C0", Offset = "0xA4A9C0", VA = "0x180A4C3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA4C440", Offset = "0xA4AA40", VA = "0x180A4C440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public string ODFGLDGHGGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x748F860", Offset = "0x748DE60", VA = "0x18748F860", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public INNLOKKDOPN INDPLLFCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA9EFC0", Offset = "0xA9D5C0", VA = "0x180A9EFC0", Slot = "24")]
		get
		{
			return default(INNLOKKDOPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string NJJOPPIMCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x748F860", Offset = "0x748DE60", VA = "0x18748F860", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public string KNEGKBBPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool CFDCONNFBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public APOBPBFLPKF LJJJIGBFKEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA9F130", Offset = "0xA9D730", VA = "0x180A9F130", Slot = "30")]
		get
		{
			return default(APOBPBFLPKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string HGIPEGKEFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA46A00", Offset = "0xA45000", VA = "0x180A46A00", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public ELBENOBCHIN? IPNDFLNHFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x748F880", Offset = "0x748DE80", VA = "0x18748F880", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public BHLGFNNJOMO NGLDHLHHCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA9EFC0", Offset = "0xA9D5C0", VA = "0x180A9EFC0", Slot = "33")]
		get
		{
			return default(BHLGFNNJOMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool EKPLGGEIELI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MGOOJHEAKEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1017A90", Offset = "0x1016090", VA = "0x181017A90")]
	public MGOOJHEAKEA([Optional] Guid BCMAFCIPNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x748F6B0", Offset = "0x748DCB0", VA = "0x18748F6B0", Slot = "35")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x748F5E0", Offset = "0x748DBE0", VA = "0x18748F5E0", Slot = "36")]
	[AsyncStateMachine(typeof(CGNAHMGELAO))]
	public Task EPKGKIENAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x748F8D0", Offset = "0x748DED0", VA = "0x18748F8D0")]
	public MGOOJHEAKEA KOBGMGDADOJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[CIADMBADCAJ]
public class GOOMCANPAPB : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int? BOIKHJBONIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x12C7310", Offset = "0x12C5910", VA = "0x1812C7310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xFB71A0", Offset = "0xFB57A0", VA = "0x180FB71A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public string IGHNIJIEOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public JHEMHCNCGNK ADMCICDNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
		[CompilerGenerated]
		get
		{
			return default(JHEMHCNCGNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xE21D10", Offset = "0xE20310", VA = "0x180E21D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JLJKPGKKKBO? PJGIBBCLCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA924E0", Offset = "0xA90AE0", VA = "0x180A924E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA924F0", Offset = "0xA90AF0", VA = "0x180A924F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GOOMCANPAPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CIADMBADCAJ]
public class PEPLEJMEKMC : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int IKFHJLCADHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int? BOIKHJBONIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x12C7270", Offset = "0x12C5870", VA = "0x1812C7270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x12D1C00", Offset = "0x12D0200", VA = "0x1812D1C00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string FHMLCMCHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public string IGHNIJIEOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public PEPLEJMEKMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[CIADMBADCAJ]
public class LOKMLCPJIIE : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int? BOIKHJBONIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string IGHNIJIEOND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LOKMLCPJIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KOLCLJGOIOA
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int HAAHHDMNNLP;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int NHBFKDBDIJD;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int NNEBCDFPPGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int ODDPMOLEHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x748E1C0", Offset = "0x748C7C0", VA = "0x18748E1C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static KOLCLJGOIOA JLODNOEBAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x748E170", Offset = "0x748C770", VA = "0x18748E170")]
		get
		{
			return default(KOLCLJGOIOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x748E260", Offset = "0x748C860", VA = "0x18748E260")]
	public KOLCLJGOIOA(int IMCAFJHJCNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[CIADMBADCAJ]
public class HLHMFBHJGPH : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int KAKFGMHFONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int? JOHFJFEDEOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x12C7270", Offset = "0x12C5870", VA = "0x1812C7270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x12D1C00", Offset = "0x12D0200", VA = "0x1812D1C00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string? FMPMDNIMCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x748B840", Offset = "0x7489E40", VA = "0x18748B840")]
	public HLHMFBHJGPH(int HONKDHANCMN, int? CFAKMMIJAHD, string? CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HLHMFBHJGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[CIADMBADCAJ]
public class HJAMDHAJEGL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public HNHPKJKAEAN.ELKMAAFFBIF NDFPAGKGODF
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(HNHPKJKAEAN.ELKMAAFFBIF);
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string HCFKIIMFEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int? BMGFLGGNJGO
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HJAMDHAJEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface INOGCDIEBNK
{
	[Cpp2IlInjected.Token(Token = "0x17000074")]
	long AKPPNCHEMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Guid MLKNKNCKMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string AIDDACGLLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string AFLCJACIEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int EDLPPLCPCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string IAGAOMNJNKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string AEDEBCPHCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string LMIJMDDAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string PAFDNFANJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int JFCLEGDNODA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[CIADMBADCAJ]
public class CEJOMCGFFIP : INOGCDIEBNK, APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public long AKPPNCHEMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE90", Offset = "0xE8B490", VA = "0x180E8CE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Guid MLKNKNCKMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x131A980", Offset = "0x1318F80", VA = "0x18131A980", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x142C6E0", Offset = "0x142ACE0", VA = "0x18142C6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA47BD0", Offset = "0xA461D0", VA = "0x180A47BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string AIDDACGLLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public string AFLCJACIEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int EDLPPLCPCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xDF43F0", Offset = "0xDF29F0", VA = "0x180DF43F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xF3AC20", Offset = "0xF39220", VA = "0x180F3AC20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string IAGAOMNJNKE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA449B0", Offset = "0xA42FB0", VA = "0x180A449B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public string AEDEBCPHCBD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string LMIJMDDAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA42F80", VA = "0x180A44980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string PAFDNFANJHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA50C70", Offset = "0xA4F270", VA = "0x180A50C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int JFCLEGDNODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xE6CFC0", Offset = "0xE6B5C0", VA = "0x180E6CFC0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xF7D8F0", Offset = "0xF7BEF0", VA = "0x180F7D8F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "15")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CEJOMCGFFIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum CPPDDDPBNIP
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum LGBEPIEGBBF
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NABOKJHDKGF
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x748FAD0", Offset = "0x748E0D0", VA = "0x18748FAD0")]
	public static int? JFJJIGCKPPP(CPPDDDPBNIP? NIENPMMLMJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x748FA40", Offset = "0x748E040", VA = "0x18748FA40")]
	public static int? FFKMFPBJOHP(LGBEPIEGBBF? NDGCLJFMLOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[CIADMBADCAJ]
public class NJDDEIBHGAI : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int? HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public JHEMHCNCGNK? ADMCICDNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA50EB0", Offset = "0xA4F4B0", VA = "0x180A50EB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NJDDEIBHGAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CIADMBADCAJ]
public class MDMFDAOEDCK : JNHMHMBFGMO, APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public byte PCKBLLJANJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MDMFDAOEDCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class FGJNANMEFEH
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x748A310", Offset = "0x7488910", VA = "0x18748A310")]
	public static FEDPMHOLDJI HEPLDJPJLHM(this MDMFDAOEDCK PIKMBNLEPPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface FCNKIMHMKLB
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	int IKFHJLCADHD
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	int HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	JHEMHCNCGNK ADMCICDNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	bool MDFJDJLJDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	bool KNDGJGKPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool EBAEJHIDIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int? BOIKHJBONIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	string IGHNIJIEOND
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	string FHMLCMCHKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string GMMNFOEHMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	DateTime PEKBAAMDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	JLJKPGKKKBO PJGIBBCLCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string LGGDGCODHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	int JFCLEGDNODA
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string ODFGLDGHGGA
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x748A1E0", Offset = "0x74887E0", VA = "0x18748A1E0", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface PIEEHLBDLAI
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	IReadOnlyList<INOGCDIEBNK> NOCDBJHOMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int IKFHJLCADHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool EBAEJHIDIGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int JFCLEGDNODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	int? BOIKHJBONIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	JHEMHCNCGNK ADMCICDNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LGIOHJOHFGF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct NMOLJJLOKAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<BAFDCGEEMHK> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7490180", Offset = "0x748E780", VA = "0x187490180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7490430", Offset = "0x748EA30", VA = "0x187490430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x748EA80", Offset = "0x748D080", VA = "0x18748EA80")]
	public static bool MLEOEKNMCIO(this IEnumerable<APOJDGIBLFD> BGGFBGFNIID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x748E9B0", Offset = "0x748CFB0", VA = "0x18748E9B0")]
	[AsyncStateMachine(typeof(NMOLJJLOKAO))]
	public static Task KKEAOFBPKID(this IEnumerable<BAFDCGEEMHK> BGGFBGFNIID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct HNKIFFEICOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly string LILOMNMJMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly string BIKEOFBLBNG;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static readonly HNKIFFEICOH ENEIBJMGMOG;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0xB8E8F0", Offset = "0xB8CEF0", VA = "0x180B8E8F0")]
	public HNKIFFEICOH(string DJBGNIBCPPO, string GOFLPLJKKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x12E3420", Offset = "0x12E1A20", VA = "0x1812E3420")]
	public bool GLEOHFCONOB(HNKIFFEICOH HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x748B8A0", Offset = "0x7489EA0", VA = "0x18748B8A0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x748B9F0", Offset = "0x7489FF0", VA = "0x18748B9F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x748BA60", Offset = "0x748A060", VA = "0x18748BA60")]
	public static bool JKIBMILPCGE(HNKIFFEICOH DBDIOGELIIH, HNKIFFEICOH LHANOGJMGBN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x748B970", Offset = "0x7489F70", VA = "0x18748B970")]
	public static bool FLMCEAOBGCC(HNKIFFEICOH DBDIOGELIIH, HNKIFFEICOH LHANOGJMGBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JNKBDPPLCGD
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	MCMHHOGOMOJ IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string HLHBJEDCLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	string EDEGBANCIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	long MHNIKOGIAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string MOECFBFOPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string CEGKJPNEIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string LABLOBPGALG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string EDNNDHGNMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CIADMBADCAJ]
public class LBOAIPOEBED : EOPFDOPCLEK
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string PFFEMADHFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public IPFDJKPFADL KHFIAKAIHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(IPFDJKPFADL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public EMNFKAKJHMG FFJCJKOCEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
		[CompilerGenerated]
		get
		{
			return default(EMNFKAKJHMG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public GKGDMDCBBGF PLGCEICMJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		[CompilerGenerated]
		get
		{
			return default(GKGDMDCBBGF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[DataMember(Name = "Header")]
	public string? EAGJGBBGPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string? HMOKHIOKDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public string? NCBKPCAOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public List<string> NNHCCIANJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public List<CMPPEGJJBHJ> CGNPOBEJJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x748E800", Offset = "0x748CE00", VA = "0x18748E800", Slot = "5")]
	public override void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x748E810", Offset = "0x748CE10", VA = "0x18748E810")]
	public LBOAIPOEBED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum DBDEPFDKOFB
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum IPFDJKPFADL
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum EMNFKAKJHMG
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum GKGDMDCBBGF
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[CIADMBADCAJ]
public class CMPPEGJJBHJ : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public DBDEPFDKOFB JKHDKCIGKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(DBDEPFDKOFB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public string? LHJKKMJDAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	[DataMember(Name = "LinkParameter")]
	public string? AINNJOCDALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? DHPENIMANBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CMPPEGJJBHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class EOPFDOPCLEK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[IgnoreDataMember]
	public string? LGKEIIDDBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void GNBOFPMLAOH();

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x748A180", Offset = "0x7488780", VA = "0x18748A180")]
	protected EOPFDOPCLEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[CIADMBADCAJ]
public class EDEDDDCMMEE : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? MCMHEOLMFND
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EDEDDDCMMEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[CIADMBADCAJ]
public class OHBHEPHPAMK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	internal static Func<string, LBOAIPOEBED>? LJDNALHMEGO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal static Func<string, JHOMADCEMPM>? MINHFONNLAF;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string? MCMHEOLMFND
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? DCABKOCAIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool LNGHBEPNDAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public KBHKIMMHEIJ AOHIDAODMON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
		[CompilerGenerated]
		get
		{
			return default(KBHKIMMHEIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public NDAOEIDIMDM GMPECPFEJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		[CompilerGenerated]
		get
		{
			return default(NDAOEIDIMDM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int PCEHILJIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1CE80", VA = "0x180D1E880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1562E10", Offset = "0x1561410", VA = "0x181562E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime HNLNGOCCNIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA50C90", Offset = "0xA4F290", VA = "0x180A50C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[DataMember(Name = "IsRead")]
	internal bool DMHLEEENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xD68CE0", Offset = "0xD672E0", VA = "0x180D68CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xD68920", Offset = "0xD66F20", VA = "0x180D68920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	[IgnoreDataMember]
	public bool JELAKJAOABI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1442420", Offset = "0x1440A20", VA = "0x181442420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1441CF0", Offset = "0x14402F0", VA = "0x181441CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public GAFBALHPKED JJAKKFDHABN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA635B0", Offset = "0xA61BB0", VA = "0x180A635B0")]
		[CompilerGenerated]
		get
		{
			return default(GAFBALHPKED);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1630F50", Offset = "0x162F550", VA = "0x181630F50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public OLCEADPAJHN GOOPAIBPFPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xCA6390", Offset = "0xCA4990", VA = "0x180CA6390")]
		[CompilerGenerated]
		get
		{
			return default(OLCEADPAJHN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xEE56A0", Offset = "0xEE3CA0", VA = "0x180EE56A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	internal string? LCAOCABGHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	[IgnoreDataMember]
	public LBOAIPOEBED? PGKNFDFHDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7490810", Offset = "0x748EE10", VA = "0x187490810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	[IgnoreDataMember]
	public JHOMADCEMPM? ILKBJLHONLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7490BD0", Offset = "0x748F1D0", VA = "0x187490BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public EOPFDOPCLEK? JLLIEOJFOHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x74908A0", Offset = "0x748EEA0", VA = "0x1874908A0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xA70910", Offset = "0xA6EF10", VA = "0x180A70910")]
	public OHBHEPHPAMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[CIADMBADCAJ]
public class ONFABAJFHMC : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public CANLDFICMMC AKINACGGBNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(CANLDFICMMC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public string CNNMGEPDMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int HDAGOEFLBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7490D50", Offset = "0x748F350", VA = "0x187490D50")]
	public ONFABAJFHMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[CIADMBADCAJ]
public class JHOMADCEMPM : EOPFDOPCLEK
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string FKMEBFFPAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public string? GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public IJLEMPNELEB KFEKJNKABMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		[CompilerGenerated]
		get
		{
			return default(IJLEMPNELEB);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	[DataMember(Name = "all_conditions_required")]
	public bool MAOGEFMDHGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1729B50", Offset = "0x1728150", VA = "0x181729B50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xFA0430", Offset = "0xF9EA30", VA = "0x180FA0430")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public List<ONFABAJFHMC> EPOMGFCCJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x748DD00", Offset = "0x748C300", VA = "0x18748DD00", Slot = "5")]
	public override void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x748DD10", Offset = "0x748C310", VA = "0x18748DD10")]
	public JHOMADCEMPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum OLCEADPAJHN
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum GAFBALHPKED
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum IJLEMPNELEB
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum CANLDFICMMC
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	EnteredRoom = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	TimeInRoom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ObjectInteractionRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ObjectPlaceStartedRoom = 4
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface HKFHEJIGFLB
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	bool LIGBELHMKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	IAJLDMLJHLB<OHBHEPHPAMK> KOKNAKOPLMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	IAJLDMLJHLB<string> NMEPEBJOLCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	IAJLDMLJHLB<OHBHEPHPAMK> LHKJJAOBFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	IAJLDMLJHLB<OHBHEPHPAMK> NHIPEBGFKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<OHBHEPHPAMK> HJCAFGIKLMP(GAFBALHPKED FBIPBHBBCJI);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OHBHEPHPAMK> ABCOBGLCGOJ(GAFBALHPKED FBIPBHBBCJI);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OHBHEPHPAMK CLPNENHKNDH(GAFBALHPKED FBIPBHBBCJI, string EJCJNODAEND);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OHBHEPHPAMK KLBPBFKLMEM(GAFBALHPKED FBIPBHBBCJI);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MOPHFPMDIGJ(GAFBALHPKED FBIPBHBBCJI);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MAPKFBAFDBD(GAFBALHPKED FBIPBHBBCJI);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task BNODIPNIJLB();

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task OKCALOCLKEN(OHBHEPHPAMK CJIMOMNMAGD);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface NONJPMGFCKL
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	IMMMJHKOLLM HMOAGLAJDGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	int GKBPNCKFJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool JDBKMDNANGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool HDEFHJGOCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool ELCGHGGPJAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool FHEIGJMMFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool DBOBDLFFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool ICBAEGNGODG
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool GGMBKEHAJCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	bool KDLEHHHFNCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	bool PKJNGMGNMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool PBDHIOMLEEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action PDPBEGCGMDF;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action MFCKLIJCOJG;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "16")]
	EHBLMFNEKIG<LBNCFOAGKOC> CDLEGMLEPEG(int DKGJDLCFPAB);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "17")]
	NCBJFOCOMOJ EIDODCMJBPO(DateTime NLDMOIFDGLH);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "18")]
	NCBJFOCOMOJ EMPBDPBIMBM(string GFEBAKFJOPL);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task DHJOOPOCJLH([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum GMENELBFKBL
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JPKEEMMFOEK
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x748DE40", Offset = "0x748C440", VA = "0x18748DE40")]
	public static string CMJLDMFIMIJ(this GMENELBFKBL HAJPIJOFJEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface PHMPONMMJOO
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<OHBHEPHPAMK>> PLNBGNMLPMO(GAFBALHPKED FBIPBHBBCJI);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OKCALOCLKEN(string EJCJNODAEND);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface GENPDICLBBC
{
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<NBFHNMDJKFB> BILGEOOHPGA();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface DMNPAEOMKAN
{
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EHBLMFNEKIG<List<PGCAODDCNDM>> EIEAJIMJHEO();

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHBLMFNEKIG<List<PGCAODDCNDM>> FBPAOGEOFJB();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<PGCAODDCNDM>> AJKNJGBDAEL([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EHBLMFNEKIG<List<PGCAODDCNDM>> JDEJNPJHMFM(List<KAMKFCKINLN> CPEHCIFLODH);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHBLMFNEKIG<List<PGCAODDCNDM>> LJCPBBKDBEL(List<KAMKFCKINLN> CPEHCIFLODH);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface CLCHHNPEFDM
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	List<DHFODADIHHB> EHCPDIFLLIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<NFKKOLFFFBJ> MICADMHJFHN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<DHFODADIHHB> IDLHLDPGGCO;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NCBJFOCOMOJ IPMIMMJIEAA(DHFODADIHHB FLFKEEHCLAH);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task MDDDGJFIPDE(DHFODADIHHB FLFKEEHCLAH);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "7")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	EHBLMFNEKIG<DHFODADIHHB> MBCECACHOJF(MDMIDLEFCPL HILCMKALFIH, MDMIDLEFCPL? IIKDGOEFLKP, bool LBKDGBGEACO, string CJIMOMNMAGD);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EHBLMFNEKIG<DHFODADIHHB> MBCECACHOJF(MDMIDLEFCPL HILCMKALFIH, string CJIMOMNMAGD);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GMOAKMFAKIJ(DHFODADIHHB BONONJFIABM, bool GIBOKPCMJGF = false, bool DPNPDHNEPHC = false, bool EPECAGKKCBL = true);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "10")]
	EHBLMFNEKIG<List<DHFODADIHHB>> JMMGIEHPECC();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface EMINAAAAHNI
{
	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	string JBMEJHJCJBH
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	bool MCJJDECGMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NCBJFOCOMOJ DKOMPAODENK();

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NCBJFOCOMOJ IHILFLMDIBK(string HFKHPNOOHFN, string FDMPBOFIKHD);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NCBJFOCOMOJ KMLKBKELFME(string LJFCALFAMIH);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCKEHEECONL();

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<DLJHDEBHCHF> HDMMEILDIHL(string GFEBAKFJOPL, string LJFCALFAMIH, bool HCDLJKEIPLL, string ALJPANGGLGD, string NBGHBAMBPGN, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task NPCEOALEFLO(int DKGJDLCFPAB, string CNJNPHGAFJD, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task OPKOCEGLEGG(int DKGJDLCFPAB, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task GBHPMCDBACL([Optional] GMENELBFKBL? IFCLEOAKKKC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<FELGCMEABMM>> IPFEPGACGBP([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task MEIEGDEKGKK([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface ENDHJDMGIHK
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<ODGFEFFIHKD>> PGGLAOEGMJF([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<AGLPPGBPBLJ>> ILKCKGMPIEK([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface MIFAPMIFHKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OFPCLOFEKIJ([Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPKFLLBBFIB();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface DCMAPDKGBMO
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event EEADKGOAJGC? EBGDDJJEBBD;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EEADKGOAJGC? GNFIBFEMLJM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event EEADKGOAJGC? AEOACHFIGBA;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<EMANPBGJAME> FCPDAJJKCIM();

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<EMANPBGJAME?>? PGKGCIEFBCD(int DKGJDLCFPAB);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<NJNNCHEOPMF>> LKEINMIOLJH(List<int> DFNPFDGIJBG);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, EMANPBGJAME>> PKLDOLDKLCA();

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<EMANPBGJAME?>?>? OEOCEJDOCHL(int DKGJDLCFPAB);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task NGIGHLCHNBP(int EHGJOAMMNGG);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CPMCKEPMDCL> HIKCKLIIPMA(EMANPBGJAME BMFCBBMGAIK);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void EEADKGOAJGC(int DKGJDLCFPAB, int EHGJOAMMNGG, EMANPBGJAME? BMFCBBMGAIK);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface MKEMADKGGII : GMABAJFNOOP, PKLEJAGCMOD
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Flags]
	public enum GGMPIKDHFBF
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string NJNFKHBKIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	ALEBJOJBEGF BKKIMDJNPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	KBHKIMMHEIJ AOHIDAODMON
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	string CBAKGCGHJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	byte NJADKGPBHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	int KOLPLPKGCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	int PAOLLGFOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	bool MDLEMLHFGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	bool DCJHAOMIGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool HMLMDBNAJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool IEDGNLPONIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	bool GDMLACBFPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool IEHMOLPGEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	bool FIKJCMBHFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EHBLMFNEKIG<string> EHCCBHNONFI();

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> PBAOEFBNFPM();

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EHBLMFNEKIG<bool> IsPlayerCommunicationRestricted(int DKGJDLCFPAB);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string CNGAOAABMFF(string IEDAJGLJHNI, bool EAENEFPEIJF = true);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> KFBIOMMGJOB(string IEDAJGLJHNI, bool EAENEFPEIJF = true);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EHBLMFNEKIG<string> MakeRoomNameAdhereToPlatformRequirements(long CDFGHIILPDC, string IEDAJGLJHNI);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string KBNIFCLFKBK, GGMPIKDHFBF LHEPOKBGOII = GGMPIKDHFBF.FilterProfanity | GGMPIKDHFBF.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string KBNIFCLFKBK, GGMPIKDHFBF LHEPOKBGOII = GGMPIKDHFBF.FilterProfanity | GGMPIKDHFBF.FilterURL, bool ODEAJEDKMBF = false);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string IEDAJGLJHNI, GGMPIKDHFBF LHEPOKBGOII = GGMPIKDHFBF.FilterProfanity | GGMPIKDHFBF.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "23")]
	EHBLMFNEKIG<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface HNBDHLDJHKB
{
	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<NCKCMKJJHFP>> LEKPJFMMGED([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface INPILBJECCB
{
	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDBKADJHONA(byte[] GOFLPLJKKOO, byte[] IPIEKEGPDBK);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface KBNDANCIIBF
{
	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PNNPDOMDCPJ(string PIEEABCLLKI);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface KGNBLFPHAJJ
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	IAJLDMLJHLB<PGLEIIHDFPB> EAJDPELJGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> NLPGHJIJJIA(string LOCMJEKPENO);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<DNKADCGKECA> HEBDLPIDOEF(string LOCMJEKPENO, string GDAHGKOGHJK);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FBJOMLKBPPP(string LOCMJEKPENO, IEnumerable<string> HBGNIJNGEOO, int KDMPGHGOLIP = 0);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<GNFLAJOEABN<FilteredTextDTO>>> LKMMPGOBKBK(uint FCDGDDAHJJN, IEnumerable<string> HBGNIJNGEOO);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface EJHNOBIKLKA
{
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPNIGONKAMK([Out] bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHAOPDBKPMH([Out] bool KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NDBCEFKAMCB([Out] int KKGBKLFKCPO);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum NHBPOLEGALC
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum FPAGCJFHPFJ
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[Flags]
public enum BGMPCADBMGI
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Flags]
public enum OHDFPFLBLIH
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum IGMFPBDMBNN
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum LDAFNPNBENC
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface LBNCFOAGKOC
{
	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	int FBKBMAOFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	string JBICOECIAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	string FFBCMBFEBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string LCJCIIPIEJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	string DIIHKJICIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	string DANBHKPHGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	string PMELLDHFCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	bool NNGEIPJGOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	bool LHKILNKKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	BGMPCADBMGI GDIJKDOBFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	OHDFPFLBLIH OGJAAJGENAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	bool? DMLPGNFHFBE
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DFCCEDKOGKK(bool KOLECLDBCDF);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AHGNJJPGIKJ(bool CBMJNDKKOOM);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface IMMMJHKOLLM : LBNCFOAGKOC
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	string AOAAFAHIFHH
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	string GFLEBLJGJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	DateTime? DKEKKOICMLF
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	NHBPOLEGALC DFNBOOKKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	int? EDKKBHPPALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	int MPDNHOPGJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	bool KIIJMJNOFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	bool BNFJEDCOGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	bool? NILBOPNCIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class ACMHIILBLJM
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public LBNCFOAGKOC AAAGBBLNOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public FPAGCJFHPFJ HMDCNNLPJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(FPAGCJFHPFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public string CNDAEKFPEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x6E18AB0", Offset = "0x6E170B0", VA = "0x186E18AB0")]
	public ACMHIILBLJM(LBNCFOAGKOC CLLLCNFEFLO, FPAGCJFHPFJ LLFHBKGGADB, string OGOCOAAIPGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface LKHHDKKJCAG
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	int FBKBMAOFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	bool LLPKKEBHFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface FHALKLOMLOD
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	int FBKBMAOFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	bool PJKAKMHEDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface OAGMBABJHJG
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	int FBKBMAOFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	string FGLECPKBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public enum ELBENOBCHIN
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class PGCAODDCNDM
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public ELBENOBCHIN IPNDFLNHFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(ELBENOBCHIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public string KNEGKBBPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public string EICPJAFKENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public APOBPBFLPKF LJJJIGBFKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		[CompilerGenerated]
		get
		{
			return default(APOBPBFLPKF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public string GEEEIOJNMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public int MOIAGGGLILM
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xE21D10", Offset = "0xE20310", VA = "0x180E21D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public bool AAEANILANIP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xF03940", Offset = "0xF01F40", VA = "0x180F03940")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xF02C80", Offset = "0xF01280", VA = "0x180F02C80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public KAMKFCKINLN BFHHDCILPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1438780", Offset = "0x1436D80", VA = "0x181438780")]
		[CompilerGenerated]
		get
		{
			return default(KAMKFCKINLN);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7491710", Offset = "0x748FD10", VA = "0x187491710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public KFDECOOHAKA EHEKLGBAGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1B06590", Offset = "0x1B04B90", VA = "0x181B06590")]
		[CompilerGenerated]
		get
		{
			return default(KFDECOOHAKA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x4E77970", Offset = "0x4E75F70", VA = "0x184E77970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public string OICKGBIPKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4AA00", VA = "0x180A4C400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2F0", Offset = "0xA4A8F0", VA = "0x180A4C2F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA4C410", Offset = "0xA4AA10", VA = "0x180A4C410")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x52C54C0", Offset = "0x52C3AC0", VA = "0x1852C54C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7491730", Offset = "0x748FD30", VA = "0x187491730")]
	internal PGCAODDCNDM(KFAOFDDLNOF NHNEEDDCDCF, LMFLGOBIABL OPPECMAFHLK, LGKJIPCELAF PONOHPHOPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x7491990", Offset = "0x748FF90", VA = "0x187491990")]
	public PGCAODDCNDM(ELBENOBCHIN MKGBPMEMDKI = ELBENOBCHIN.Outfit, [Optional] KAMKFCKINLN MONEDDKMFFM, [Optional] string OLAMKOHKMJF, [Optional] string ENBJCKJPNAC, APOBPBFLPKF OPAKHACPGJH = APOBPBFLPKF.Common, [Optional] string FMHIIJGOIHI, int KBPGIMIOBMD = 0, bool CCCLLJDCOMI = false, [Optional] string AKHJNBKDDHF, [Optional] DateTime? AMNDDPALDCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[CIADMBADCAJ]
public class KFAOFDDLNOF : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public ELBENOBCHIN IPNDFLNHFNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(ELBENOBCHIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	[DataMember(Name = "AvatarItemDesc")]
	public string BGEIGOIFHAP
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public string KNEGKBBPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public string EICPJAFKENF
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public APOBPBFLPKF LJJJIGBFKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0xA47FE0", Offset = "0xA465E0", VA = "0x180A47FE0")]
		[CompilerGenerated]
		get
		{
			return default(APOBPBFLPKF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0xA47FD0", Offset = "0xA465D0", VA = "0x180A47FD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string GEEEIOJNMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public int MOIAGGGLILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0xCA6390", Offset = "0xCA4990", VA = "0x180CA6390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xEE56A0", Offset = "0xEE3CA0", VA = "0x180EE56A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public bool AAEANILANIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1831C70", Offset = "0x1830270", VA = "0x181831C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x183BDB0", Offset = "0x183A3B0", VA = "0x18183BDB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public string EPCABCFOMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xF02DB0", Offset = "0xF013B0", VA = "0x180F02DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KFAOFDDLNOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[CIADMBADCAJ]
public sealed class PNCCHMKGAEN : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public List<string> HCMOJHCNNGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x7491BA0", Offset = "0x74901A0", VA = "0x187491BA0")]
	public PNCCHMKGAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public PNCCHMKGAEN(List<string> CPEHCIFLODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[CIADMBADCAJ]
public class NBFHNMDJKFB : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public ELCDLGGDAAJ HEMHHMPACCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public EHLFDGNDKAL BHHIICFAPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NBFHNMDJKFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public NBFHNMDJKFB(ELCDLGGDAAJ JCLJLMEKEHE, EHLFDGNDKAL MCGOAKFKKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum MDNFNKAOOPB
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum IJHOKFKGDHN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[CIADMBADCAJ]
public class ELCDLGGDAAJ : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public MDNFNKAOOPB KDAICAMMFCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(MDNFNKAOOPB);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public IJHOKFKGDHN? EADOLHBJIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x305CD90", Offset = "0x305B390", VA = "0x18305CD90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x731BF50", Offset = "0x731A550", VA = "0x18731BF50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool MCFIMNDHMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1F28220", Offset = "0x1F26820", VA = "0x181F28220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1F28210", Offset = "0x1F26810", VA = "0x181F28210")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7489710", Offset = "0x7487D10", VA = "0x187489710")]
	public ELCDLGGDAAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x7489720", Offset = "0x7487D20", VA = "0x187489720")]
	public ELCDLGGDAAJ(MDNFNKAOOPB PIPDICJKDKB, IJHOKFKGDHN FOCLCLEBNCG, bool NGCLCMNOFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CIADMBADCAJ]
public class EHLFDGNDKAL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public string ELPBNONMOCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public string MCIADDHHLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EHLFDGNDKAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public EHLFDGNDKAL(string OAOBFFHCMJK, string KJNKJBMBDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum ALEBJOJBEGF
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct NFKKOLFFFBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public DHFODADIHHB NHEBKCCDHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool MEMFNDFNJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public bool LMIEGOAHONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool FJFCJJNMIGA;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[CIADMBADCAJ]
public class DHFODADIHHB : BAFDCGEEMHK, APOJDGIBLFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct AKIJCNCNEDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public DHFODADIHHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7487820", Offset = "0x7485E20", VA = "0x187487820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x74879B0", Offset = "0x7485FB0", VA = "0x1874879B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal static Action<DHFODADIHHB> AAGHJLHAIHM;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal static Func<DHFODADIHHB, Task> IIAIEBCCIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[IgnoreDataMember]
	public bool JNAKGKCIFFD;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public long? NJJOPPIMCLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public int MKFPDJMEAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public int? FFPKIEPMLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x12C7310", Offset = "0x12C5910", VA = "0x1812C7310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xFB71A0", Offset = "0xFB57A0", VA = "0x180FB71A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public string HGIPEGKEFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public ELBENOBCHIN? IPNDFLNHFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA47BD0", Offset = "0xA461D0", VA = "0x180A47BD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	[DataMember(Name = "AvatarItemDesc")]
	public string LAMCEHCDHAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public Guid? BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7489220", Offset = "0x7487820", VA = "0x187489220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7489340", Offset = "0x7487940", VA = "0x187489340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public string EPKFLJAHLGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public string LFNLNCANCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA42F80", VA = "0x180A44980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public MEPDKFDNMHJ EMPIFJJCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA6CC40", Offset = "0xA6B240", VA = "0x180A6CC40")]
		[CompilerGenerated]
		get
		{
			return default(MEPDKFDNMHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x14964F0", Offset = "0x1494AF0", VA = "0x1814964F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public int AALFIIJEFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA6CCA0", Offset = "0xA6B2A0", VA = "0x180A6CCA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x14964D0", Offset = "0x1494AD0", VA = "0x1814964D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public int EKLKEMDBHME
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xE6CFC0", Offset = "0xE6B5C0", VA = "0x180E6CFC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xF7D8F0", Offset = "0xF7BEF0", VA = "0x180F7D8F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public MDMIDLEFCPL AEAFLBNJHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xF152B0", Offset = "0xF138B0", VA = "0x180F152B0")]
		[CompilerGenerated]
		get
		{
			return default(MDMIDLEFCPL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x14FD290", Offset = "0x14FB890", VA = "0x1814FD290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public APOBPBFLPKF DEGIGMCGDGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xCC2990", Offset = "0xCC0F90", VA = "0x180CC2990")]
		[CompilerGenerated]
		get
		{
			return default(APOBPBFLPKF);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x14CB800", Offset = "0x14C9E00", VA = "0x1814CB800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	[DataMember(Name = "Message")]
	public string BFBHFJDKHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA4C410", Offset = "0xA4AA10", VA = "0x180A4C410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA4C320", Offset = "0xA4A920", VA = "0x180A4C320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public string HEIDBPFPIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xAB07D0", Offset = "0xAAEDD0", VA = "0x180AB07D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAADC60", VA = "0x180AAF660")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public bool MPHFPKKBBEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xF035D0", Offset = "0xF01BD0", VA = "0x180F035D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF02DA0", Offset = "0xF013A0", VA = "0x180F02DA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public KBHKIMMHEIJ AOHIDAODMON
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xE746D0", Offset = "0xE72CD0", VA = "0x180E746D0")]
		[CompilerGenerated]
		get
		{
			return default(KBHKIMMHEIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xE72620", Offset = "0xE70C20", VA = "0x180E72620")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public NDAOEIDIMDM JFGPCFLALEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xA4C350", Offset = "0xA4A950", VA = "0x180A4C350")]
		[CompilerGenerated]
		get
		{
			return default(NDAOEIDIMDM);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C460", Offset = "0xA4AA60", VA = "0x180A4C460")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public ILINBGFIHDA? IDHHFILINKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x13E7E90", Offset = "0x13E6490", VA = "0x1813E7E90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7489240", Offset = "0x7487840", VA = "0x187489240")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool LGFEHDHEDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x74893D0", Offset = "0x74879D0", VA = "0x1874893D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool CBEAJNIJMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x74893B0", Offset = "0x74879B0", VA = "0x1874893B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool LDMOGKLBKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7489250", Offset = "0x7487850", VA = "0x187489250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	[IgnoreDataMember]
	public bool LCPLOFEEMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA54B70", Offset = "0xA53170", VA = "0x180A54B70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0xA54B50", Offset = "0xA53150", VA = "0x180A54B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	[IgnoreDataMember]
	public bool LAPKEHOOABF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2D273E0", Offset = "0x2D259E0", VA = "0x182D273E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x2D26C00", Offset = "0x2D25200", VA = "0x182D26C00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	[IgnoreDataMember]
	public string MBJMEPPGGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0xE23A60", Offset = "0xE22060", VA = "0x180E23A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0xF2B480", Offset = "0xF29A80", VA = "0x180F2B480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	[IgnoreDataMember]
	public string GMHDFNHONFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0xAD80E0", Offset = "0xAD66E0", VA = "0x180AD80E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xAD8100", Offset = "0xAD6700", VA = "0x180AD8100")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	[IgnoreDataMember]
	public bool LEEEEBAEMNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xFCD950", Offset = "0xFCBF50", VA = "0x180FCD950")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0xC89000", Offset = "0xC87600", VA = "0x180C89000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x7489350", Offset = "0x7487950", VA = "0x187489350", Slot = "5")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x7489270", Offset = "0x7487870", VA = "0x187489270", Slot = "6")]
	[AsyncStateMachine(typeof(AKIJCNCNEDF))]
	public virtual Task EPKGKIENAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x14FD290", Offset = "0x14FB890", VA = "0x1814FD290")]
	public void HLINCBCLKPJ(MDMIDLEFCPL HILCMKALFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DHFODADIHHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface MPJPHHECCLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000155")]
	long GDMOJAGPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	string JFBGGJNKPAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	int FJNJLBCIBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	string GLNDDBHINKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	string EAENBKOLAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	byte PBAHFGIJAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	int MNKNDCDKJCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	int NBPDCNLAOJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	JHEMHCNCGNK ADMCICDNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	bool MDFJDJLJDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	DateTime PEKBAAMDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	DateTime? OLCNCFEHELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	long? FHBCJFIKEGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	int DDLMAJINFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	int DDOGJMKKOLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	int MJIAFOIKKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	FLIOJOBPLIK HHPLKPNPAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	FLIOJOBPLIK KHJDMIIGGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	bool DGCEABBICLA
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	bool AHMCLFOBGGM
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool EBAEJHIDIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	bool EPHOOJAGKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	int? HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	bool NNKDHOJFILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	string JFHLACJOEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DGHEPEHOPJL();

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPGCEFGGFNP();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[CIADMBADCAJ]
public class HGICOIJDIIG : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public List<CJJEGCAENDE> ADBKBPIBEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x748B330", Offset = "0x7489930", VA = "0x18748B330")]
	public List<string> LDLCMDHBFJG(params HMHOHDFJNHD[] DMAJEJPFFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x748B1C0", Offset = "0x74897C0", VA = "0x18748B1C0")]
	public List<string> FKENLNMJFOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x748B4F0", Offset = "0x7489AF0", VA = "0x18748B4F0")]
	public List<string> OHIBMFCBMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x748B240", Offset = "0x7489840", VA = "0x18748B240", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HGICOIJDIIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[CIADMBADCAJ]
public class FPGEMLDAAEP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int FJNJLBCIBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FPGEMLDAAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[CIADMBADCAJ]
public class AFLONPIILLK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public long GDMOJAGPIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public string JFBGGJNKPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public int ICBHIBMEHOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public bool JALAFGBOBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xDF4B30", Offset = "0xDF3130", VA = "0x180DF4B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xDF55F0", Offset = "0xDF3BF0", VA = "0x180DF55F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int DHFFKIAFGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public int NIKOENLILEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1CE80", VA = "0x180D1E880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x1562E10", Offset = "0x1561410", VA = "0x181562E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public int JOPCCKBBABK
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xA47FE0", Offset = "0xA465E0", VA = "0x180A47FE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0xA47FD0", Offset = "0xA465D0", VA = "0x180A47FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public int NMHPMBDMPIN
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0xA86E90", Offset = "0xA85490", VA = "0x180A86E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0xA860D0", Offset = "0xA846D0", VA = "0x180A860D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public string LLLJCBCKKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public string KBAMPAMIKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x71C8CF0", Offset = "0x71C72F0", VA = "0x1871C8CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public JHEMHCNCGNK? IHCGBEADGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0xF02DB0", Offset = "0xF013B0", VA = "0x180F02DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public IReadOnlyList<Guid> AMJKFGDNBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA449B0", Offset = "0xA42FB0", VA = "0x180A449B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000180")]
	public HNKIFFEICOH BAPHNBOBLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x74876F0", Offset = "0x7485CF0", VA = "0x1874876F0")]
		get
		{
			return default(HNKIFFEICOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7487650", Offset = "0x7485C50", VA = "0x187487650", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x74876E0", Offset = "0x7485CE0", VA = "0x1874876E0")]
	public bool GLEOHFCONOB(AFLONPIILLK BCLNLNDAPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x7487470", Offset = "0x7485A70", VA = "0x187487470")]
	private bool CBBOOLAFJDL(AFLONPIILLK BCLNLNDAPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x7487740", Offset = "0x7485D40", VA = "0x187487740")]
	private static bool LBHPGKJILNB(IReadOnlyList<Guid> DMNJODFLMIG, IReadOnlyList<Guid> BDPHDKNGKLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x297E140", Offset = "0x297C740", VA = "0x18297E140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public AFLONPIILLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[CIADMBADCAJ]
public class KHFCMFNHADK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000181")]
	public int GEHLAJOBKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KHFCMFNHADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[CIADMBADCAJ]
public class JPBPGMBMDIA : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000182")]
	public bool BAKECPJECFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JPBPGMBMDIA()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CIADMBADCAJ]
	public class NewInventionRequestDTO : APOJDGIBLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public MJGCNECCLCM creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xF817E0", Offset = "0xF7FDE0", VA = "0x180F817E0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x74906B0", Offset = "0x748ECB0", VA = "0x1874906B0")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CIADMBADCAJ]
	public class AddVersionInventionRequestDTO : APOJDGIBLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0xF817E0", Offset = "0xF7FDE0", VA = "0x180F817E0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7487B70", Offset = "0x7486170", VA = "0x187487B70")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CIADMBADCAJ]
	public class ModifyTagsRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CIADMBADCAJ]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CIADMBADCAJ]
	public class ReportRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NDMGDDALHOJ ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CIADMBADCAJ]
	public class CheerRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CIADMBADCAJ]
	public class UpdatePriceRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CIADMBADCAJ]
	public class UpdateInventionMetadataRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xF817E0", Offset = "0xF7FDE0", VA = "0x180F817E0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CIADMBADCAJ]
	public class UpdateInventionGeneralPermissionRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public FLIOJOBPLIK Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(FLIOJOBPLIK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CIADMBADCAJ]
	public class PublishInventionRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public FLIOJOBPLIK Permission
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(FLIOJOBPLIK);
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public JHEMHCNCGNK Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
			[CompilerGenerated]
			get
			{
				return default(JHEMHCNCGNK);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xE25450", Offset = "0xE23A50", VA = "0x180E25450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CIADMBADCAJ]
	public class UnpublishInventionRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CIADMBADCAJ]
	public class DeleteInventionRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CIADMBADCAJ]
	public class SetInventionVersionAccessibilityRequest : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		public JHEMHCNCGNK NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
			[CompilerGenerated]
			get
			{
				return default(JHEMHCNCGNK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xE25450", Offset = "0xE23A50", VA = "0x180E25450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CIADMBADCAJ]
	public class SpecialTags : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x17000194")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum NDDHFLHOMEK
{
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum NDMGDDALHOJ
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum EBCFFFDKKCF
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	True,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface FELGCMEABMM
{
	[Cpp2IlInjected.Token(Token = "0x17000196")]
	KBHKIMMHEIJ AOHIDAODMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	string CBAKGCGHJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	int FBKBMAOFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	DateTime LHGFKKNHEHH
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	bool LHLOBOIHANF
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	string GHBOOLNEHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	LBNCFOAGKOC AAAGBBLNOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GNBOFPMLAOH();

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OCPNNIKNPMC(LBNCFOAGKOC CLLLCNFEFLO);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface MCHHHFPCIBE
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	string PBOFLFAHHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	int GMOIMINMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	bool JOPJOAPHKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GNBOFPMLAOH();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct DLJHDEBHCHF
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public BGMGKBDPODB BMJMMGENPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xC04EB0", Offset = "0xC034B0", VA = "0x180C04EB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(BGMGKBDPODB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x14544D0", Offset = "0x1452AD0", VA = "0x1814544D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public MCHHHFPCIBE DAGJAIGAJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xE5FAD0", Offset = "0xE5E0D0", VA = "0x180E5FAD0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xE5FA00", Offset = "0xE5E000", VA = "0x180E5FA00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public string IBNNPLEKLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5F00DB0", Offset = "0x5EFF3B0", VA = "0x185F00DB0")]
	public DLJHDEBHCHF(BGMGKBDPODB GLNNAENDNMD, [Optional] MCHHHFPCIBE MBKBGABGOII, [Optional] string NBGHBAMBPGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public enum BGMGKBDPODB
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[CIADMBADCAJ]
public class ODGFEFFIHKD : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public string ADFPEOHLHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public string DBJOGLDGPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string MKEIENIKKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string NCNMLGABNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public List<COLAFCKLDGP> HOINHDECDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ODGFEFFIHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x4CC6130", Offset = "0x4CC4730", VA = "0x184CC6130")]
	public ODGFEFFIHKD([Optional] string FLPGELPEIIN, [Optional] string BBLHAHMNBGG, [Optional] string KFEAIMMCCOM, [Optional] string HEDFAJLJHAA, [Optional] List<COLAFCKLDGP> BNCMDANKJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[CIADMBADCAJ]
public class COLAFCKLDGP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string LABLOBPGALG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public string NCNMLGABNFF
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public COLAFCKLDGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[CIADMBADCAJ]
public class AGLPPGBPBLJ : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public string DBJOGLDGPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public string BMJMMGENPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public string ADFPEOHLHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public List<string> NLLBKKMPEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public AGLPPGBPBLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[CIADMBADCAJ]
public interface APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GNBOFPMLAOH();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[CIADMBADCAJ]
public interface BAFDCGEEMHK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EPKGKIENAFF();
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[OJOOIKLBING]
public interface JNHMHMBFGMO : APOJDGIBLFD
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[CIADMBADCAJ]
public class FEDPMHOLDJI : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public int PCKBLLJANJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public string LDIBANEOEDK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public string AFLCJACIEJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FEDPMHOLDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x748A2A0", Offset = "0x74888A0", VA = "0x18748A2A0")]
	public FEDPMHOLDJI([Optional] Guid BCMAFCIPNGO, int HJLDIJBMLBP = 0, [Optional] string CPIHIMFKPCP, [Optional] string HGGIOLLGEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[CIADMBADCAJ]
public class EMANPBGJAME : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public const int KOJIKJIKNEG = 0;

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public long KJGPOIIHCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public KOIECIFOAMK EAGAGEKCDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public string GHADKKBLNFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public List<FEDPMHOLDJI> KKKPCMIEHND
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public int GBENOEJLJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA47FE0", Offset = "0xA465E0", VA = "0x180A47FE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA47FD0", Offset = "0xA465D0", VA = "0x180A47FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public JHEMHCNCGNK ADMCICDNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xCA6390", Offset = "0xCA4990", VA = "0x180CA6390")]
		[CompilerGenerated]
		get
		{
			return default(JHEMHCNCGNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xEE56A0", Offset = "0xEE3CA0", VA = "0x180EE56A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string AIDDACGLLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public bool DBMILPIEODP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FAD9F0", Offset = "0x1FABFF0", VA = "0x181FAD9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x74898D0", Offset = "0x7487ED0", VA = "0x1874898D0")]
	public EMANPBGJAME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x74897B0", Offset = "0x7487DB0", VA = "0x1874897B0")]
	public EMANPBGJAME(long NKIHJKBENEM = 0L, [Optional] KOIECIFOAMK LHCNEFDLOAA, [Optional] string PLBGOKFMBOC, [Optional] List<FEDPMHOLDJI> EPJMCAFPPOI, int EHGJOAMMNGG = 0, [Optional] string IEDAJGLJHNI, JHEMHCNCGNK CEHECLIMMGG = JHEMHCNCGNK.Private, [Optional] string KCIGHNNHGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class NJNNCHEOPMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly int FBKBMAOFNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public readonly EMANPBGJAME CMDNOJCEJBD;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xF84950", Offset = "0xF82F50", VA = "0x180F84950")]
	public NJNNCHEOPMF(int DKGJDLCFPAB, EMANPBGJAME BMFCBBMGAIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[CIADMBADCAJ]
public class KOIECIFOAMK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string OIBKPJGIOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public string KHFDPEBDDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public string BLKOGFFBHJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public string FKFJLPMMJHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public string FFIGBLFDNFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public string KKKPCMIEHND
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x748DFA0", Offset = "0x748C5A0", VA = "0x18748DFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KOIECIFOAMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x4CC6130", Offset = "0x4CC4730", VA = "0x184CC6130")]
	public KOIECIFOAMK([Optional] string CDHNBHFOGAO, [Optional] string CLFILBCPJCA, [Optional] string NJJMIDENMBN, [Optional] string FIJDMNMPGHM, [Optional] string EBKNCBHCOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[CIADMBADCAJ]
public class CHKGPCGIALE : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public Dictionary<int, EMANPBGJAME> DOCHPFACBBE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CHKGPCGIALE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[CIADMBADCAJ]
public class AFNKDBAPDMK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public List<int> CBOFLBICHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public byte? NJADKGPBHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3062760", Offset = "0x3060D60", VA = "0x183062760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x30626D0", Offset = "0x3060CD0", VA = "0x1830626D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public int? KOLPLPKGCCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x12C7300", Offset = "0x12C5900", VA = "0x1812C7300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x12C7330", Offset = "0x12C5930", VA = "0x1812C7330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public AFNKDBAPDMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class JEBDHNDMKKI
{
	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x748D680", Offset = "0x748BC80", VA = "0x18748D680")]
	public static MDMFDAOEDCK OOGMGGKNNFK(this FEDPMHOLDJI PIKMBNLEPPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
public enum NDAOEIDIMDM
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public enum KBHKIMMHEIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[CIADMBADCAJ]
public class DLLPEGBJIHE : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	[DataMember(Name = "PlayerId")]
	public int FBKBMAOFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public int PLLLFHBNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D70", Offset = "0xAA4370", VA = "0x180AA5D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xAD8120", Offset = "0xAD6720", VA = "0x180AD8120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public int KEPEFMBLCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DLLPEGBJIHE()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CIADMBADCAJ]
	public class ProgressionEventRecordDTO : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public int FBKBMAOFNCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public int EKLKEMDBHME
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xAA5D70", Offset = "0xAA4370", VA = "0x180AA5D70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xAD8120", Offset = "0xAD6720", VA = "0x180AD8120")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public int CJMFDBOOOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public int MBJBHKBEAJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xE25450", Offset = "0xE23A50", VA = "0x180E25450")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public int BDIALIBANKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public DateTime? HAKGDLJEDPA
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x131A980", Offset = "0x1318F80", VA = "0x18131A980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x142C6E0", Offset = "0x142ACE0", VA = "0x18142C6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public int EKLDBPKADOL
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xE21D10", Offset = "0xE20310", VA = "0x180E21D10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7491D90", Offset = "0x7490390", VA = "0x187491D90")]
		public ProgressionEventRecordDTO(int DKGJDLCFPAB = 0, int JFHOIAABMIC = 0, int ODDDAIBNOIM = 0, int IFPAFBPPMFP = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CIADMBADCAJ]
	public class ProgressionEventDTO : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public long KDDNLHHBOGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public string GKIMNFGPLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public List<ProgressionEventRewardDTO> FMAJPPIEJNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public List<KeepsakeRoomListDTO> MJCJCFGKJHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public DateTime NFKOEDJOHAN
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xA50C90", Offset = "0xA4F290", VA = "0x180A50C90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public DateTime NFLOOCIPMJK
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xA47BD0", Offset = "0xA461D0", VA = "0x180A47BD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public DateTime FDNPEOAGNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xF03300", Offset = "0xF01900", VA = "0x180F03300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public bool BJFCCIPMLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xCCADB0", Offset = "0xCC93B0", VA = "0x180CCADB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xCFFB40", Offset = "0xCFE140", VA = "0x180CFFB40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public int EONEJDPJOCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x13A7320", Offset = "0x13A5920", VA = "0x1813A7320")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x21C2AA0", Offset = "0x21C10A0", VA = "0x1821C2AA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public float OKMFOIELJCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x118A840", Offset = "0x1188E40", VA = "0x18118A840")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x150A760", Offset = "0x1508D60", VA = "0x18150A760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public Guid? JNFDONABNCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x7491CC0", Offset = "0x74902C0", VA = "0x187491CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x7491CB0", Offset = "0x74902B0", VA = "0x187491CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public string IGAKJGDCHMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA42F80", VA = "0x180A44980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public string GOHAJOEANJO
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xA50C70", Offset = "0xA4F270", VA = "0x180A50C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public string MNKGIEPPHHB
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4E0", Offset = "0xA4AAE0", VA = "0x180A4C4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4C0", Offset = "0xA4AAC0", VA = "0x180A4C4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public string CLFAFPGBMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4AA00", VA = "0x180A4C400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2F0", Offset = "0xA4A8F0", VA = "0x180A4C2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7491CE0", Offset = "0x74902E0", VA = "0x187491CE0")]
		public ProgressionEventDTO(long CCPDACGIOEI = 0L, [Optional] string IEDAJGLJHNI, [Optional] List<ProgressionEventRewardDTO> BJJPNGBNKFL, [Optional] List<KeepsakeRoomListDTO> BLDHNKOIKAE, [Optional] DateTime NCBLJDEEOCD, [Optional] DateTime PBIEBEONIHA, [Optional] DateTime JAEAFKJLNOJ, bool NHIGBHHBKOI = false, int NDPHJLJKHPC = 0, float OMLKFAFBBBC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CIADMBADCAJ]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public long GJEMFBCDPAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public long KDDNLHHBOGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public int? FFLMHCOBLCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public int? DMPFOCNNLLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA50EB0", Offset = "0xA4F4B0", VA = "0x180A50EB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public long? PGGGOKPHJNF
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xE8D3B0", Offset = "0xE8B9B0", VA = "0x180E8D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xE8D3C0", Offset = "0xE8B9C0", VA = "0x180E8D3C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public long NLMKPIAPIEC
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xF03300", Offset = "0xF01900", VA = "0x180F03300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public TimeSpan EHHKACBDJAA
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x748E310", Offset = "0x748C910", VA = "0x18748E310")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public long EOJIFCHCLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x71C8CF0", Offset = "0x71C72F0", VA = "0x1871C8CF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public TimeSpan OJPDNMKADJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x748E360", Offset = "0x748C960", VA = "0x18748E360")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public int GMGMPMCOPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xDF43F0", Offset = "0xDF29F0", VA = "0x180DF43F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xF3AC20", Offset = "0xF39220", VA = "0x180F3AC20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public LAHFMAFBGDD DIJGIPPKFEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x11FF9D0", Offset = "0x11FDFD0", VA = "0x1811FF9D0")]
			[CompilerGenerated]
			get
			{
				return default(LAHFMAFBGDD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x237B1F0", Offset = "0x23797F0", VA = "0x18237B1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public List<KeepsakeRoomDTO> DGDALIPMJBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xA449B0", Offset = "0xA42FB0", VA = "0x180A449B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x748E3B0", Offset = "0x748C9B0", VA = "0x18748E3B0")]
		public KeepsakeRoomListDTO(long MKLOBBGCMNK = 0L, long CCPDACGIOEI = 0L, [Optional] int? DMOJCPGOAEL, [Optional] int? FKLNCIAOFFC, [Optional] long? LKHLLJCGJAN, long HNOIJBNOKHK = 0L, long BJHEDFFLNPG = 0L, int JCNNKAEGGPF = 0, LAHFMAFBGDD HLGGADCGNDK = LAHFMAFBGDD.Standard, [Optional] List<KeepsakeRoomDTO> NPBNEGJJBKK)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CIADMBADCAJ]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public long ADPFKKNGHIC
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public long HAHFIFLNJLA
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public long GJEMFBCDPAI
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public LAHFMAFBGDD AKEHBOGGIOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
			[CompilerGenerated]
			get
			{
				return default(LAHFMAFBGDD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public int GFBIGAMDIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1CE80", VA = "0x180D1E880")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x1562E10", Offset = "0x1561410", VA = "0x181562E10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x748E2B0", Offset = "0x748C8B0", VA = "0x18748E2B0")]
		public KeepsakeRoomDTO(long LCKBJCNHPGD = 0L, long CDFGHIILPDC = 0L, long MKLOBBGCMNK = 0L, LAHFMAFBGDD JLPANLJHHFI = LAHFMAFBGDD.Standard, int JOKGMMAMPPN = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CIADMBADCAJ]
	public class ProgressionEventRewardDTO : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public long FEEEDCMGIAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public int GAHHOELKMHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public string EAENBKOLAIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public int EKLKEMDBHME
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public int IGDIEODMDNO
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xD1E880", Offset = "0xD1CE80", VA = "0x180D1E880")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0x1562E10", Offset = "0x1561410", VA = "0x181562E10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public bool KJNEHCLIMLO
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xA73260", Offset = "0xA71860", VA = "0x180A73260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public bool FDPCDDFOCID
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xE83260", Offset = "0xE81860", VA = "0x180E83260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x149D1F0", Offset = "0x149B7F0", VA = "0x18149D1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CIADMBADCAJ]
	public class ProgressionEventPurchasableXpBoostDTO : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public Guid HHMIDHOEMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public int JBHDMGABLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public int HCJIEODKKKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public int LNODHLPNALB
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		public long AJBPEKOKPLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0xA50C90", Offset = "0xA4F290", VA = "0x180A50C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		public long NBOPNANEFJB
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0xA47BD0", Offset = "0xA461D0", VA = "0x180A47BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum LAHFMAFBGDD
{
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum DJAEGFIGJOO
{
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[CIADMBADCAJ]
public class NCKCMKJJHFP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public string LILOMNMJMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	public string? BIKEOFBLBNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NCKCMKJJHFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface GINKBDBKNNM
{
	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	bool NMGKKEJKHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	string? HPIFBGNILIB
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	string? HHCGFALAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface FCICBLLIPFB<T> : GINKBDBKNNM
{
	[Cpp2IlInjected.Token(Token = "0x17000201")]
	T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class IHPEMOFHAHG
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DAA0", Offset = "0x3B7C0A0", VA = "0x183B7DAA0")]
	public static FCICBLLIPFB<T> BDBOCHCKBIN<T, U>(this FCICBLLIPFB<U> HPCDHGHHCOO, Func<U, T> CEKFCEEECCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct LGIPMGCFHGB<T> : FCICBLLIPFB<T>, GINKBDBKNNM
{
	[Cpp2IlInjected.Token(Token = "0x17000202")]
	public bool NMGKKEJKHDO
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xFC3720", Offset = "0xFC1D20", VA = "0x180FC3720", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x2BCE300", Offset = "0x2BCC900", VA = "0x182BCE300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	public string? HPIFBGNILIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0xE5FAD0", Offset = "0xE5E0D0", VA = "0x180E5FAD0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0xE5FA00", Offset = "0xE5E000", VA = "0x180E5FA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public string? HHCGFALAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x53887E0", Offset = "0x5386DE0", VA = "0x1853887E0")]
	public static LGIPMGCFHGB<T> PLHNOJAOKMC(T KKGBKLFKCPO)
	{
		return default(LGIPMGCFHGB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5388720", Offset = "0x5386D20", VA = "0x185388720")]
	public static LGIPMGCFHGB<T> KGEHHEKJLOE(string NNDNCFBMBFL, string LMLODOAACAD = "")
	{
		return default(LGIPMGCFHGB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[CIADMBADCAJ]
public class CPMCKEPMDCL : GINKBDBKNNM, APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public bool NMGKKEJKHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000207")]
	public string? HPIFBGNILIB
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000208")]
	[DataMember(Name = "error_id")]
	public string? HHCGFALAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
	public virtual void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x74890E0", Offset = "0x74876E0", VA = "0x1874890E0")]
	public static CPMCKEPMDCL PLHNOJAOKMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x7489050", Offset = "0x7487650", VA = "0x187489050")]
	public static CPMCKEPMDCL KGEHHEKJLOE(string NNDNCFBMBFL, string LMLODOAACAD = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CPMCKEPMDCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[OLLONIIMODM]
public abstract class DCJEHMPEJID<T> : CPMCKEPMDCL, FCICBLLIPFB<T>, GINKBDBKNNM
{
	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0xAB10A0", Offset = "0xAAF6A0", VA = "0x180AB10A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0xAB0E60", Offset = "0xAAF460", VA = "0x180AB0E60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
	protected DCJEHMPEJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[OLLONIIMODM]
public class DCCGEMCMFOM<T> : DCJEHMPEJID<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBF50", Offset = "0x6CBA550", VA = "0x186CBBF50")]
	private static void FEGGKBDMAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x4724F50", Offset = "0x4723550", VA = "0x184724F50")]
	public DCCGEMCMFOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[OLLONIIMODM]
public class GNFLAJOEABN<T> : DCJEHMPEJID<T>, BAFDCGEEMHK, APOJDGIBLFD where T : APOJDGIBLFD, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct FFNIJCJJLOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public GNFLAJOEABN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x4C05D50", Offset = "0x4C04350", VA = "0x184C05D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x4C05FD0", Offset = "0x4C045D0", VA = "0x184C05FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x4D9D570", Offset = "0x4D9BB70", VA = "0x184D9D570", Slot = "8")]
	public override void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x4D9D4A0", Offset = "0x4D9BAA0", VA = "0x184D9D4A0", Slot = "10")]
	[AsyncStateMachine(typeof(GNFLAJOEABN<>.FFNIJCJJLOG))]
	public Task EPKGKIENAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x4D9D750", Offset = "0x4D9BD50", VA = "0x184D9D750")]
	public static GNFLAJOEABN<T> PLHNOJAOKMC(T KKGBKLFKCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x4D9D600", Offset = "0x4D9BC00", VA = "0x184D9D600")]
	public new static GNFLAJOEABN<T> KGEHHEKJLOE(string NNDNCFBMBFL, string LMLODOAACAD = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x474AD70", Offset = "0x4749370", VA = "0x18474AD70")]
	public GNFLAJOEABN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[OLLONIIMODM]
public class KFAFIHKMCOE<T> : DCJEHMPEJID<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x4724F50", Offset = "0x4723550", VA = "0x184724F50")]
	public KFAFIHKMCOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[OLLONIIMODM]
public class FJNONMNDDIA<T> : DCJEHMPEJID<List<T>>, BAFDCGEEMHK, APOJDGIBLFD where T : APOJDGIBLFD, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct CBAIDHABBGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public FJNONMNDDIA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x65E1F00", Offset = "0x65E0500", VA = "0x1865E1F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x65E2100", Offset = "0x65E0700", VA = "0x1865E2100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x4C523E0", Offset = "0x4C509E0", VA = "0x184C523E0")]
	public static FJNONMNDDIA<T> PLHNOJAOKMC(List<T> KKGBKLFKCPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x4C52290", Offset = "0x4C50890", VA = "0x184C52290")]
	public new static FJNONMNDDIA<T> KGEHHEKJLOE(string NNDNCFBMBFL, string LMLODOAACAD = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x4C52030", Offset = "0x4C50630", VA = "0x184C52030", Slot = "8")]
	public override void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x4C51F60", Offset = "0x4C50560", VA = "0x184C51F60", Slot = "10")]
	[AsyncStateMachine(typeof(FJNONMNDDIA<>.CBAIDHABBGJ))]
	public Task EPKGKIENAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x4C52510", Offset = "0x4C50B10", VA = "0x184C52510")]
	public FJNONMNDDIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum FIFHILIEFFB
{
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class MPONEIECBIC
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x748FA20", Offset = "0x748E020", VA = "0x18748FA20")]
	public static bool LOHKBLAJIJE(this FIFHILIEFFB BDLLFBOLFCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x748FA20", Offset = "0x748E020", VA = "0x18748FA20")]
	public static bool BDHBGECAKEK(this FIFHILIEFFB BDLLFBOLFCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum MEPDKFDNMHJ
{
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	ProgressionEvent = 400
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum ILINBGFIHDA
{
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	NonPurchasedEarnedByP2Pv2 = 1001
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum MDMIDLEFCPL
{
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum APOBPBFLPKF
{
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum OCFCHOIJOAE
{
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CIADMBADCAJ]
	public class BalanceResponseDTO : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public MEPDKFDNMHJ CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(MEPDKFDNMHJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		[DataMember(Name = "Platform")]
		public ILINBGFIHDA BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
			[CompilerGenerated]
			get
			{
				return default(ILINBGFIHDA);
			}
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xE25450", Offset = "0xE23A50", VA = "0x180E25450")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public virtual void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CIADMBADCAJ]
	public class FilteredTextDTO : APOJDGIBLFD
	{
		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public string PBOFLFAHHLK
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public int JJLCAIHECLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
		public void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[CIADMBADCAJ]
public class NHAMIECELMC : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	public string DDEJOMNLEOE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000210")]
	public string LJMAHEBJFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NHAMIECELMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[CIADMBADCAJ]
public class DNKADCGKECA : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public List<NHAMIECELMC> FCDEEIACGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DNKADCGKECA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[CIADMBADCAJ]
public class LDLMJIOGHGG : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string GKBHCCOJPAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public LDLMJIOGHGG(string DEIEJMGGHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[CIADMBADCAJ]
public class LLGOIFHANFH : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public List<NHAMIECELMC> FCDEEIACGBC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LLGOIFHANFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[CIADMBADCAJ]
public class CJBMFCBIACM : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public List<LDLMJIOGHGG> AHJCIIKGDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public string IFILPLHPLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public bool DFEOECJNDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public int BLEMGIKDHIP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CJBMFCBIACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x74888C0", Offset = "0x7486EC0", VA = "0x1874888C0")]
	public CJBMFCBIACM(string LOCMJEKPENO, List<LDLMJIOGHGG> HBGNIJNGEOO, bool DCGHFCKDHNN, int KDMPGHGOLIP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[CIADMBADCAJ]
public class ALGHOGDHHGB : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public List<LLGOIFHANFH> NIHMKBKEJPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public bool DFEOECJNDKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xA441A0", Offset = "0xA427A0", VA = "0x180A441A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ALGHOGDHHGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[CIADMBADCAJ]
public class PGLEIIHDFPB : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum LNPAHJAJJMK
	{
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	public const string KFPAMMGKGCD = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public string IFILPLHPLFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public LNPAHJAJJMK BMJMMGENPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(LNPAHJAJJMK);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x7491B20", Offset = "0x7490120", VA = "0x187491B20")]
	public PGLEIIHDFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x7491AD0", Offset = "0x74900D0", VA = "0x187491AD0")]
	public PGLEIIHDFPB(string LOCMJEKPENO, LNPAHJAJJMK GLNNAENDNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[CIADMBADCAJ]
public class KJHBLCBPGCE : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public bool BIHGMOEGKJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KJHBLCBPGCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class HNHPKJKAEAN
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum ELKMAAFFBIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[CIADMBADCAJ]
public class EFJNNNEHKNL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public long HAHFIFLNJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public Guid NJCDHLFKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE90", Offset = "0xE8B490", VA = "0x180E8CE90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public long FPOPMLNBAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xA50EB0", Offset = "0xA4F4B0", VA = "0x180A50EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public LEMGKALJIEP PCHMOALFHND
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EFJNNNEHKNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x7489640", Offset = "0x7487C40", VA = "0x187489640")]
	public EFJNNNEHKNL(long CDFGHIILPDC, Guid LLDMDGICDNN, long DGLKMMKHDMO, LEMGKALJIEP GDGDIFDFICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x7489620", Offset = "0x7487C20", VA = "0x187489620", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[CIADMBADCAJ]
public class EEGDINHGLAH : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public NJOOPGNJCDN ILBKEFOPONE
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(NJOOPGNJCDN);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public BELLDAECLLK LFHBPOEBFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EEGDINHGLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0xF84950", Offset = "0xF82F50", VA = "0x180F84950")]
	public EEGDINHGLAH(NJOOPGNJCDN HPCDHGHHCOO, BELLDAECLLK HHPKHOECDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[CIADMBADCAJ]
public class LEMGKALJIEP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public Guid? JCHMPPKGPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x3036CE0", Offset = "0x30352E0", VA = "0x183036CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x748E950", Offset = "0x748CF50", VA = "0x18748E950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public Guid HFBMCILNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0xDF43E0", Offset = "0xDF29E0", VA = "0x180DF43E0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0xFBA9C0", Offset = "0xFB8FC0", VA = "0x180FBA9C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LEMGKALJIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x748E960", Offset = "0x748CF60", VA = "0x18748E960")]
	public LEMGKALJIEP(Guid? JJEFPJDALED, Guid NEJIHFOMHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[CIADMBADCAJ]
public class BELLDAECLLK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public long HAHFIFLNJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public Guid NJCDHLFKHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE90", Offset = "0xE8B490", VA = "0x180E8CE90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public long DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA50EB0", Offset = "0xA4F4B0", VA = "0x180A50EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public Guid OAPPFOFIBHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xE8D3B0", Offset = "0xE8B9B0", VA = "0x180E8D3B0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xE8D3C0", Offset = "0xE8B9C0", VA = "0x180E8D3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xF03300", Offset = "0xF01900", VA = "0x180F03300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public DateTime PEKBAAMDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x71C8CF0", Offset = "0x71C72F0", VA = "0x1871C8CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public BELLDAECLLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[CIADMBADCAJ]
public class JIIGAAMDNFL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public string EAENBKOLAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public List<long> JAAMJDAPCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public List<MBHBFPJCNFD> DMOHCAPHMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public string HFEDAGKHJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public byte? EFLKIKBPDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x748DDE0", Offset = "0x748C3E0", VA = "0x18748DDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x748DE30", Offset = "0x748C430", VA = "0x18748DE30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public int? KJJHNGEBEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x748DDF0", Offset = "0x748C3F0", VA = "0x18748DDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x748DDD0", Offset = "0x748C3D0", VA = "0x18748DDD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public Guid? IPANAIJMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x748DE10", Offset = "0x748C410", VA = "0x18748DE10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x748DE00", Offset = "0x748C400", VA = "0x18748DE00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public bool HLMLHLANMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xA50DF0", Offset = "0xA4F3F0", VA = "0x180A50DF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xA50E10", Offset = "0xA4F410", VA = "0x180A50E10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JIIGAAMDNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[CIADMBADCAJ]
public class JMCINGMMCGL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public Guid IPANAIJMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public long HAHFIFLNJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public string EAENBKOLAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0xF03300", Offset = "0xF01900", VA = "0x180F03300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public DateTime PEKBAAMDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x71C8CF0", Offset = "0x71C72F0", VA = "0x1871C8CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public string HFEDAGKHJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public List<long> JAAMJDAPCHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xA449B0", Offset = "0xA42FB0", VA = "0x180A449B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public List<DFBEKLFJLJF> DMOHCAPHMNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public byte EFLKIKBPDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3A00", VA = "0x180AB5400")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x13B0F40", Offset = "0x13AF540", VA = "0x1813B0F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public int KJJHNGEBEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0xA7C680", Offset = "0xA7AC80", VA = "0x180A7C680")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x14964E0", Offset = "0x1494AE0", VA = "0x1814964E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JMCINGMMCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[CIADMBADCAJ]
public class BPADHCMECNC : JMCINGMMCGL
{
	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public Guid AINOFOIAFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x1B06590", Offset = "0x1B04B90", VA = "0x181B06590")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x4E77970", Offset = "0x4E75F70", VA = "0x184E77970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public BPADHCMECNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum NJOOPGNJCDN
{
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public interface PMEOPNCJNKI
{
	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DCJEHMPEJID<JMCINGMMCGL>> AJBJICCEANI(Guid? HOOANKBDJBP, long CDFGHIILPDC, string IEDAJGLJHNI, string LCNJPNDEDOK, string ODEILPPIMEL, string JPCCDIMJKNM, byte LPCNJBGEJJI, int HFIMNHFKOFL, [Optional] List<long> PCMGOIFKBNK, [Optional] List<DFBEKLFJLJF> AOAOKNMKBPE, bool MOJOKPGGIIO = false, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DCJEHMPEJID<JMCINGMMCGL>> GNFDEFPKBIE(Guid LLDMDGICDNN, long CDFGHIILPDC, [Optional] string IEDAJGLJHNI, [Optional] string LCNJPNDEDOK, [Optional] string ODEILPPIMEL, [Optional] List<long> PCMGOIFKBNK, [Optional] Dictionary<string, string> AOAOKNMKBPE, [Optional] string JPCCDIMJKNM, [Optional] byte? LPCNJBGEJJI, [Optional] int? HFIMNHFKOFL, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CPMCKEPMDCL> BLBGJLGJILF(Guid LLDMDGICDNN, long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<JMCINGMMCGL>> HONJIIKPGLE(long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<BELLDAECLLK>> IIMIGKLJILA(long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<EEGDINHGLAH>> PHIDKMDOJMH(long CDFGHIILPDC, List<EFJNNNEHKNL> BMFONFFIFOI, [Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[CIADMBADCAJ]
public class MBHBFPJCNFD : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public string HFEDAGKHJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MBHBFPJCNFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[CIADMBADCAJ]
public class DFBEKLFJLJF : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public long OPGEIHIMOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public string HFEDAGKHJLL
	{
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DFBEKLFJLJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[CIADMBADCAJ]
public class LJIKNDLFHNA : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public long OPGEIHIMOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string HFEDAGKHJLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x4CCA780", Offset = "0x4CC8D80", VA = "0x184CCA780")]
	public LJIKNDLFHNA(long KGCDEAFINFK, string BKADBAJOKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public interface DIBLEKNMCNC
{
	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DCJEHMPEJID<List<DFBEKLFJLJF>>> CHHMLPMBNFI(long CDFGHIILPDC, List<LJIKNDLFHNA> BMFONFFIFOI, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CPMCKEPMDCL> KPHKFONOBCF(long KGCDEAFINFK, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<DFBEKLFJLJF>> GPNMMNNEIGI(long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[CIADMBADCAJ]
public class NKMLHCHJGBD : CMJANDFMBCA, IEquatable<NKMLHCHJGBD>
{
	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x7488E00", Offset = "0x7487400", VA = "0x187488E00", Slot = "7")]
	public bool Equals(NKMLHCHJGBD HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x7490110", Offset = "0x748E710", VA = "0x187490110", Slot = "6")]
	public override CMJANDFMBCA PLEBMHKEBJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NKMLHCHJGBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class NHKAKIDGKKN
{
	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x748FD30", Offset = "0x748E330", VA = "0x18748FD30")]
	public static NKMLHCHJGBD FKMEBFFPAOD(this BKMAHJDMJAP GANFJJCKLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x748FDA0", Offset = "0x748E3A0", VA = "0x18748FDA0")]
	public static NKMLHCHJGBD ILNEICOLLHJ(string OEBONIJNNAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[CIADMBADCAJ]
public class BKMAHJDMJAP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public const int OCAGPFBDHBH = 3;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public const int BMINIGJHJEK = 40;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public const int ANGNIBALJJD = 180;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public const int PJLDCFLMJJL = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public const int HFCLHDBCODG = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public const int KEHOOFKGPNJ = 8;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public const int NHNGBFJHMAM = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public const int BJEFJCJLDCA = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public const int PHKNOCAHIDI = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? IDOJPGCJMJJ;

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public Guid IPANAIJMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public long HAHFIFLNJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public string? JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public string? EAENBKOLAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public int HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0xCA6390", Offset = "0xCA4990", VA = "0x180CA6390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xEE56A0", Offset = "0xEE3CA0", VA = "0x180EE56A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public Guid? FJHMEEJDOKM
	{
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7487F40", Offset = "0x7486540", VA = "0x187487F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7488090", Offset = "0x7486690", VA = "0x187488090")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0xAA9EE0", Offset = "0xAA84E0", VA = "0x180AA9EE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0xE31810", Offset = "0xE2FE10", VA = "0x180E31810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public int? IOBGBDFBKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8DB0", Offset = "0x6EA73B0", VA = "0x186EA8DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8DD0", Offset = "0x6EA73D0", VA = "0x186EA8DD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public int? KJEBJMNKBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x7487C50", Offset = "0x7486250", VA = "0x187487C50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x7487C60", Offset = "0x7486260", VA = "0x187487C60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public IReadOnlyList<DMBAOJBBLKH> DKHJEGIMLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xA50C70", Offset = "0xA4F270", VA = "0x180A50C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4E0", Offset = "0xA4AAE0", VA = "0x180A4C4E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xF2CFB0", Offset = "0xF2B5B0", VA = "0x180F2CFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public DateTime PEKBAAMDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4AA00", VA = "0x180A4C400")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xF2CF80", Offset = "0xF2B580", VA = "0x180F2CF80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	[IgnoreDataMember]
	public KAAJMKIPCGE LFAIMIKMFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x7488020", Offset = "0x7486620", VA = "0x187488020")]
		get
		{
			return default(KAAJMKIPCGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> LJIEABEHAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7487F60", Offset = "0x7486560", VA = "0x187487F60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xA4C320", Offset = "0xA4A920", VA = "0x180A4C320")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x7487C70", Offset = "0x7486270", VA = "0x187487C70", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public BKMAHJDMJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x74880A0", Offset = "0x74866A0", VA = "0x1874880A0")]
	public BKMAHJDMJAP(Guid HOOANKBDJBP, long CDFGHIILPDC, string IEDAJGLJHNI, string LCNJPNDEDOK, string ODEILPPIMEL, int ADABADLFLPA, int? MJLMNJHIGCO, int? BBJKOHFKMJF, List<DMBAOJBBLKH> CHFBIJLHNDE, [Optional] DateTime AMNDDPALDCL, [Optional] DateTime JBPJPOBFPHA, [Optional] Guid? NKPDHDLIFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x7487FB0", Offset = "0x74865B0", VA = "0x187487FB0")]
	private KAAJMKIPCGE NIMMMAOILCH()
	{
		return default(KAAJMKIPCGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x7487C80", Offset = "0x7486280", VA = "0x187487C80")]
	private Dictionary<Guid, int> IFGCJKMAHON(IReadOnlyList<DMBAOJBBLKH> CHFBIJLHNDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[CIADMBADCAJ]
public class GMKONJEAKBK : APOJDGIBLFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	public Guid IPANAIJMDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	public long HAHFIFLNJLA;

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GMKONJEAKBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[CIADMBADCAJ]
public class MLPAFEDBEFN : BKMAHJDMJAP
{
	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public Guid ADELFJFPBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xF2CC60", Offset = "0xF2B260", VA = "0x180F2CC60")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xF2C590", Offset = "0xF2AB90", VA = "0x180F2C590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	public Guid? HBMFBFJJCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x748FA00", Offset = "0x748E000", VA = "0x18748FA00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x748F9E0", Offset = "0x748DFE0", VA = "0x18748F9E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MLPAFEDBEFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[CIADMBADCAJ]
public class IHOACEKHNGK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public string? JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public string? EAENBKOLAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public int HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public int? IOBGBDFBKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x12C72F0", Offset = "0x12C58F0", VA = "0x1812C72F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x12C7320", Offset = "0x12C5920", VA = "0x1812C7320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public int? KJEBJMNKBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xD64DB0", Offset = "0xD633B0", VA = "0x180D64DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xD64DF0", Offset = "0xD633F0", VA = "0x180D64DF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public List<DMBAOJBBLKH> DKHJEGIMLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public Guid? HBMFBFJJCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7489220", Offset = "0x7487820", VA = "0x187489220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7489340", Offset = "0x7487940", VA = "0x187489340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public Guid? IPANAIJMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x748BB90", Offset = "0x748A190", VA = "0x18748BB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x748BB70", Offset = "0x748A170", VA = "0x18748BB70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public bool HLMLHLANMHF
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xDED9D0", Offset = "0xDEBFD0", VA = "0x180DED9D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0xF43C10", Offset = "0xF42210", VA = "0x180F43C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x748BB80", Offset = "0x748A180", VA = "0x18748BB80", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public IHOACEKHNGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[CIADMBADCAJ]
public class DMBAOJBBLKH : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public HLNMEMIHCNH INDPLLFCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90")]
		[CompilerGenerated]
		get
		{
			return default(HLNMEMIHCNH);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public Guid HFIOCFACBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x1A8E4C0", Offset = "0x1A8CAC0", VA = "0x181A8E4C0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B630", Offset = "0x5B09C30", VA = "0x185B0B630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DMBAOJBBLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x7489440", Offset = "0x7487A40", VA = "0x187489440")]
	public DMBAOJBBLKH(Guid LOHNFMOHPFD, HLNMEMIHCNH JLPANLJHHFI, int FOAMCIPOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[CIADMBADCAJ]
public class EIIKOFCPIKO : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public Guid MPLLFLJHDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public int PIHNNHBHDFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public DateTime CMCCHOPDGEC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xA50C90", Offset = "0xA4F290", VA = "0x180A50C90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xE21D10", Offset = "0xE20310", VA = "0x180E21D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x74896A0", Offset = "0x7487CA0", VA = "0x1874896A0")]
	public EIIKOFCPIKO(Guid PPGDDDBFCDJ, string IEDAJGLJHNI, int PDNLGAOBJAN, DateTime BDKMCBGCNNB, int PFGEKBLLNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EIIKOFCPIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[CIADMBADCAJ]
public class LOCINLJJMIF : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public Guid MPLLFLJHDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public int PKGHMNMLKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LOCINLJJMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x58F3690", Offset = "0x58F1C90", VA = "0x1858F3690")]
	public LOCINLJJMIF(Guid PPGDDDBFCDJ, int BNEBDLPFJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[CIADMBADCAJ]
public class PNPLEFKLINF : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public int PKGHMNMLKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public Guid AFBAHKGFHEO
	{
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x1A8E4C0", Offset = "0x1A8CAC0", VA = "0x181A8E4C0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B630", Offset = "0x5B09C30", VA = "0x185B0B630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public int HOFBEGICEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public Guid? GOEMKGMCLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0xF2E910", Offset = "0xF2CF10", VA = "0x180F2E910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x2385D10", Offset = "0x2384310", VA = "0x182385D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public int BLBMGOBDLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0xA635B0", Offset = "0xA61BB0", VA = "0x180A635B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x1630F50", Offset = "0x162F550", VA = "0x181630F50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public Dictionary<Guid, Guid?> FKDKCIFHPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public PNPLEFKLINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x7491C30", Offset = "0x7490230", VA = "0x187491C30")]
	public PNPLEFKLINF(int BNEBDLPFJNO, Guid FJECJBEFCLN, int GLAMHMIPOBL, Guid? DJCJIKFOAPN, int OPKLOOJGFNL, Dictionary<Guid, Guid?> DPCDMAJJIBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
[CIADMBADCAJ]
public class GHIOCBKPEID : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public EFFKGLIBDGP IPDOMGJGAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F90", Offset = "0xAC1590", VA = "0x180AC2F90")]
		[CompilerGenerated]
		get
		{
			return default(EFFKGLIBDGP);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F80", Offset = "0xAC1580", VA = "0x180AC2F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public OCFCHOIJOAE? CILAAKMKFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x12C7270", Offset = "0x12C5870", VA = "0x1812C7270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x12D1C00", Offset = "0x12D0200", VA = "0x1812D1C00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public BalanceResponseDTO BFANMFKKAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public List<BELLDAECLLK> GFAPGGEBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GHIOCBKPEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x748A3E0", Offset = "0x74889E0", VA = "0x18748A3E0")]
	public GHIOCBKPEID(EFFKGLIBDGP NFDGBEPAHDC, OCFCHOIJOAE? MDGEIGNKDMD, BalanceResponseDTO CKPMJNPOGGK, List<BELLDAECLLK> NKGGHDBJPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x748A3D0", Offset = "0x74889D0", VA = "0x18748A3D0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public enum HLNMEMIHCNH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public enum EFFKGLIBDGP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public enum KAAJMKIPCGE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface APDMPDLKNJD
{
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	static IAJLDMLJHLB<BKMAHJDMJAP> MMIJBBMBNKN;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	static IAJLDMLJHLB<BKMAHJDMJAP> OAACOJLGENE;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	static IAJLDMLJHLB<Guid> BMLBDMHKNLP;

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DCJEHMPEJID<BKMAHJDMJAP?>?>? LLILJLDIMAG(Guid? HOOANKBDJBP, long CDFGHIILPDC, string IEDAJGLJHNI, string? LCNJPNDEDOK, string? ODEILPPIMEL, int ADABADLFLPA, KAAJMKIPCGE ILIOHJMEADC, [Optional] Dictionary<Guid, int>? GNGHGFGEADM, [Optional] Guid? AAEJFJPOPAP, bool MOJOKPGGIIO = false, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<DCJEHMPEJID<BKMAHJDMJAP?>?>? KKILAPGDJGI(Guid PPGDDDBFCDJ, long CDFGHIILPDC, string IEDAJGLJHNI, string? LCNJPNDEDOK, string? ODEILPPIMEL, int ADABADLFLPA, KAAJMKIPCGE ILIOHJMEADC, [Optional] Dictionary<Guid, int>? GNGHGFGEADM, [Optional] Guid? AAEJFJPOPAP, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CPMCKEPMDCL> JGLJJIKPLCM(Guid PPGDDDBFCDJ, long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<BKMAHJDMJAP>> GBEFMJDMNJH(long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<DCJEHMPEJID<List<LOCINLJJMIF>>> DIFHMDKAOBJ(long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DCJEHMPEJID<List<EIIKOFCPIKO>>> IHBMEIIJKCG(long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<GHIOCBKPEID> NHFJDCEEEII(Guid PPGDDDBFCDJ, long CDFGHIILPDC, int BNEBDLPFJNO, int GLAMHMIPOBL, Guid? LKPOGCAANFM, int OPKLOOJGFNL, Dictionary<Guid, Guid?> ILLGANKKKOO, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x7487A10", Offset = "0x7486010", VA = "0x187487A10")]
	static APDMPDLKNJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[CIADMBADCAJ]
public class GCKIODKEJAG : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public long HAHFIFLNJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public bool LHPMPKMIPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0xA441A0", Offset = "0xA427A0", VA = "0x180A441A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public GCKIODKEJAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public interface EOPAGGKIDIG
{
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<GCKIODKEJAG> LKBLBHJOCGM(long CDFGHIILPDC, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<CPMCKEPMDCL> GAACKDBCCCH(long CDFGHIILPDC, bool HLOEKLACGIJ, [Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[OLLONIIMODM]
public class EBHBBHFBPOE<DataType> where DataType : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public long BELJNAMGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public MEPDKFDNMHJ EMPIFJJCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(MEPDKFDNMHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027C")]
	public ILINBGFIHDA IDHHFILINKF
	{
		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
		[CompilerGenerated]
		get
		{
			return default(ILINBGFIHDA);
		}
		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0xE25450", Offset = "0xE23A50", VA = "0x180E25450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027D")]
	public DataType IKFGCCPLOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EBHBBHFBPOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
[OLLONIIMODM]
public class MMEPIGKFMLB<DataType> where DataType : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700027E")]
	public long BELJNAMGEOL
	{
		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public MEPDKFDNMHJ EMPIFJJCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(MEPDKFDNMHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public ILINBGFIHDA IDHHFILINKF
	{
		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
		[CompilerGenerated]
		get
		{
			return default(ILINBGFIHDA);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0xE25450", Offset = "0xE23A50", VA = "0x180E25450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public List<DataType> IKFGCCPLOBI
	{
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MMEPIGKFMLB()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[OLLONIIMODM]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : APOJDGIBLFD, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		[OLLONIIMODM]
		public class CBGGCDPLKFA : BAFDCGEEMHK, APOJDGIBLFD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E7")]
			[CompilerGenerated]
			private struct APALENJDBJB : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000420")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000421")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000422")]
				public CBGGCDPLKFA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000423")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000603")]
				[Cpp2IlInjected.Address(RVA = "0x5074230", Offset = "0x5072830", VA = "0x185074230", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000604")]
				[Cpp2IlInjected.Address(RVA = "0x5074500", Offset = "0x5072B00", VA = "0x185074500", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000283")]
			public OCFCHOIJOAE CIIBACJOPKA
			{
				[Cpp2IlInjected.Token(Token = "0x60005FC")]
				[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
				[CompilerGenerated]
				get
				{
					return default(OCFCHOIJOAE);
				}
				[Cpp2IlInjected.Token(Token = "0x60005FD")]
				[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000284")]
			public DataTypeDTO IKFGCCPLOBI
			{
				[Cpp2IlInjected.Token(Token = "0x60005FE")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005FF")]
				[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x65E4DA0", Offset = "0x65E33A0", VA = "0x1865E4DA0", Slot = "5")]
			public void GNBOFPMLAOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x65E4CD0", Offset = "0x65E32D0", VA = "0x1865E4CD0", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.CBGGCDPLKFA.APALENJDBJB))]
			public Task EPKGKIENAFF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public CBGGCDPLKFA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		public List<CBGGCDPLKFA> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x592C680", Offset = "0x592AC80", VA = "0x18592C680", Slot = "5")]
		public override void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[OLLONIIMODM]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : APOJDGIBLFD, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[OLLONIIMODM]
		public class NEHKOJNNPNN : BAFDCGEEMHK, APOJDGIBLFD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000EA")]
			[CompilerGenerated]
			private struct HLKJMFFAMND : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000428")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000429")]
				public NEHKOJNNPNN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042A")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000610")]
				[Cpp2IlInjected.Address(RVA = "0x4E24390", Offset = "0x4E22990", VA = "0x184E24390", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000611")]
				[Cpp2IlInjected.Address(RVA = "0x4E245F0", Offset = "0x4E22BF0", VA = "0x184E245F0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000286")]
			public OCFCHOIJOAE CIIBACJOPKA
			{
				[Cpp2IlInjected.Token(Token = "0x6000609")]
				[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
				[CompilerGenerated]
				get
				{
					return default(OCFCHOIJOAE);
				}
				[Cpp2IlInjected.Token(Token = "0x600060A")]
				[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000287")]
			public List<DataTypeDTO> IKFGCCPLOBI
			{
				[Cpp2IlInjected.Token(Token = "0x600060B")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600060C")]
				[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x56884B0", Offset = "0x5686AB0", VA = "0x1856884B0", Slot = "5")]
			public void GNBOFPMLAOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x56883E0", Offset = "0x56869E0", VA = "0x1856883E0", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.NEHKOJNNPNN.HLKJMFFAMND))]
			public Task EPKGKIENAFF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public NEHKOJNNPNN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		public List<NEHKOJNNPNN> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x592C680", Offset = "0x592AC80", VA = "0x18592C680", Slot = "5")]
		public override void GNBOFPMLAOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[LNEDEEELBBA]
public class BBFMGGGECEL : PurchaseBalanceUpdateResponseDTO<DHFODADIHHB>
{
	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x7487B80", Offset = "0x7486180", VA = "0x187487B80")]
	public BBFMGGGECEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[LNEDEEELBBA]
public class AJLNJNAEDLD : PurchaseBalanceUpdateResponseDTO<DHFODADIHHB>.NEHKOJNNPNN
{
	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x74877E0", Offset = "0x7485DE0", VA = "0x1874877E0")]
	public AJLNJNAEDLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[CIADMBADCAJ]
public class LOECGPNIFME : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000288")]
	public LBMDELHPEOI FHJEGNBODNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000289")]
	public long KAKFGMHFONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public GiftItemDTO? ADPCABKDLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public long? FHPCBDJLEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x131A980", Offset = "0x1318F80", VA = "0x18131A980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x142C6E0", Offset = "0x142ACE0", VA = "0x18142C6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public int PDLBDFEPICA
	{
		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0xA635A0", Offset = "0xA61BA0", VA = "0x180A635A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0xE21D10", Offset = "0xE20310", VA = "0x180E21D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x748ECB0", Offset = "0x748D2B0", VA = "0x18748ECB0")]
	public LOECGPNIFME(LBMDELHPEOI KAKFLODHAHB, long HONKDHANCMN, GiftItemDTO? FLFKEEHCLAH, int NOIFFBHNGIC = 1, [Optional] long? DKFJBCKFNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[CIADMBADCAJ]
public class KDCBAIHLEJJ : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public List<LOECGPNIFME> HKNNBICIBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028E")]
	public DJOBOOACBNK? NNJDONGEKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	public MEPDKFDNMHJ EMPIFJJCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(MEPDKFDNMHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	public bool HEGJNNMCGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xDF4B30", Offset = "0xDF3130", VA = "0x180DF4B30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0xDF55F0", Offset = "0xDF3BF0", VA = "0x180DF55F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	public bool KFPFMPEBOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x14FF040", Offset = "0x14FD640", VA = "0x1814FF040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x28187E0", Offset = "0x2816DE0", VA = "0x1828187E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public Guid? GBOMKCMIPNF
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xF2E910", Offset = "0xF2CF10", VA = "0x180F2E910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x2385D10", Offset = "0x2384310", VA = "0x182385D10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x748DF20", Offset = "0x748C520", VA = "0x18748DF20")]
	public KDCBAIHLEJJ(List<LOECGPNIFME> BMKGPGOHIAB, DJOBOOACBNK? KBIIPMNNGMC, MEPDKFDNMHJ PEOJMNNJEJM, bool BAPGADOCDFP, bool IHLKKCBENNK = false, [Optional] Guid? ILPDEGHOOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[CIADMBADCAJ]
public class CJCBLCLCIEP : BAFDCGEEMHK, APOJDGIBLFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct CLFFEACMDPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public CJCBLCLCIEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x7488AC0", Offset = "0x74870C0", VA = "0x187488AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x7488DA0", Offset = "0x74873A0", VA = "0x187488DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	internal static Action<DHFODADIHHB>? AGLKGIMMNJG;

	[Cpp2IlInjected.Token(Token = "0x4000437")]
	internal static Func<DHFODADIHHB, Task>? FDPHHDHOOEA;

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public DHFODADIHHB NHEBKCCDHLI
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public int? IJNODFEBCCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public MGOOJHEAKEA? KOHGNONMGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x7488A00", Offset = "0x7487000", VA = "0x187488A00", Slot = "5")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x7488930", Offset = "0x7486F30", VA = "0x187488930", Slot = "6")]
	[AsyncStateMachine(typeof(CLFFEACMDPC))]
	public virtual Task EPKGKIENAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CJCBLCLCIEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[LNEDEEELBBA]
public class PBJHIFOBKDJ : BalanceUpdateResponseDTO<CJCBLCLCIEP>
{
	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x7490DA0", Offset = "0x748F3A0", VA = "0x187490DA0")]
	public PBJHIFOBKDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[LNEDEEELBBA]
public class OGLIKOMEIOI : BalanceUpdateResponseDTO<CJCBLCLCIEP>.CBGGCDPLKFA
{
	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x74907D0", Offset = "0x748EDD0", VA = "0x1874907D0")]
	public OGLIKOMEIOI()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CIADMBADCAJ]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x17000296")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000297")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public MDMIDLEFCPL GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
			[CompilerGenerated]
			get
			{
				return default(MDMIDLEFCPL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[CIADMBADCAJ]
public class CFBLIONAPIL : APOJDGIBLFD, EEAIJCFNHCK
{
	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public MFNLLKPFCKA? DNHOGLPPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	[IgnoreDataMember]
	public Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x74881E0", Offset = "0x74867E0", VA = "0x1874881E0", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public LBMDELHPEOI? ADBJJOFOGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public List<FOFCLFMAPHB>? OCLEPFPDBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public DateTime? CCJFJELPJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x131A980", Offset = "0x1318F80", VA = "0x18131A980", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x142C6E0", Offset = "0x142ACE0", VA = "0x18142C6E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public DateTime? BNAEHFEAFAO
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x1509CC0", Offset = "0x15082C0", VA = "0x181509CC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x150BC30", Offset = "0x150A230", VA = "0x18150BC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public DateTime? EBIENDOKCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xDED9C0", Offset = "0xDEBFC0", VA = "0x180DED9C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x5B08200", Offset = "0x5B06800", VA = "0x185B08200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public bool MPCCMHKLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xCB76A0", Offset = "0xCB5CA0", VA = "0x180CB76A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0xCB6DE0", Offset = "0xCB53E0", VA = "0x180CB6DE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public bool KOPIHELIINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x118DBF0", Offset = "0x118C1F0", VA = "0x18118DBF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x118DC10", Offset = "0x118C210", VA = "0x18118DC10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public bool CFDCONNFBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xF959D0", Offset = "0xF93FD0", VA = "0x180F959D0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x118DC00", Offset = "0x118C200", VA = "0x18118DC00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public bool KNDGJGKPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xF8C6B0", Offset = "0xF8ACB0", VA = "0x180F8C6B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xF95170", Offset = "0xF93770", VA = "0x180F95170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0x7488260", Offset = "0x7486860", VA = "0x187488260")]
	public static CFBLIONAPIL GPJKPBHDBLN(Guid BCMAFCIPNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CFBLIONAPIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[CIADMBADCAJ]
public class BOOIKBDEHMF
{
	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public int IECDKBKDFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public string HOMIPBEGLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public string HCGHICGKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public Dictionary<int, KDCEJCDCLIF> OKLKLAFANOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public Dictionary<string, int> MGCLBJEDFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public Dictionary<NJFCIACBPIJ, List<int>> HOLILAKEKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public Dictionary<string, string> BHEFKHAGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public BOOIKBDEHMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public enum NJFCIACBPIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[CIADMBADCAJ]
public class KDCEJCDCLIF : OKCABBLACHG
{
	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public NDAOEIDIMDM NDALGCINNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(NDAOEIDIMDM);
		}
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	public bool PKHIMGEKOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x12003E0", Offset = "0x11FE9E0", VA = "0x1812003E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x14F2FE0", Offset = "0x14F15E0", VA = "0x1814F2FE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	public bool NHPLDCHDDAC
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x1F28230", Offset = "0x1F26830", VA = "0x181F28230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x1F28240", Offset = "0x1F26840", VA = "0x181F28240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	public string IGEOAJJHEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	public string LGBOJNFPNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	public string LBMGBADKJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	public string KGLFBKDNOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	public Dictionary<KBHKIMMHEIJ, string> OLNDLHHFACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0x14F2FF0", Offset = "0x14F15F0", VA = "0x1814F2FF0")]
	public KDCEJCDCLIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
[CIADMBADCAJ]
public class DMHMFAAGOAO : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	public IReadOnlyList<MFNLLKPFCKA>? BFALOLDCLNP
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DMHMFAAGOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public DMHMFAAGOAO(IReadOnlyList<MFNLLKPFCKA>? JKCNEDNLPHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public enum BHLGFNNJOMO
{
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface EEAIJCFNHCK
{
	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	LBMDELHPEOI? ADBJJOFOGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	List<FOFCLFMAPHB>? OCLEPFPDBNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	DateTime? CCJFJELPJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	DateTime? BNAEHFEAFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	DateTime? EBIENDOKCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	bool MPCCMHKLKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	bool CFDCONNFBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	bool KNDGJGKPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface FNJKGKKHADK
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action MFFJCKBBNGP;

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DEBMDBKHLEL(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task KACJGKNHGFA(CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JMMLDHADEPK([Out] APHAOMPGKAH HHBGHAKIGCN);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface APHAOMPGKAH
{
	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	string HOMIPBEGLKB
	{
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	string HCGHICGKACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	IReadOnlyDictionary<NJFCIACBPIJ, IReadOnlyList<OKCABBLACHG>> MHLGIBAGDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	IReadOnlyDictionary<string, string> BHEFKHAGLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface OKCABBLACHG
{
	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	string LGBOJNFPNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	string IGEOAJJHEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	string LBMGBADKJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	string KGLFBKDNOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public interface FDFGOOFMOHM
{
	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	INNLOKKDOPN INDPLLFCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	string NJJOPPIMCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	string KNEGKBBPKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	string GMMNFOEHMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	bool KNDGJGKPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	bool CFDCONNFBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	APOBPBFLPKF LJJJIGBFKEI
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	string HGIPEGKEFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	ELBENOBCHIN? IPNDFLNHFNF
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	BHLGFNNJOMO NGLDHLHHCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	bool EKPLGGEIELI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[CIADMBADCAJ]
public class LBMDELHPEOI : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public INNLOKKDOPN AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(INNLOKKDOPN);
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	public int? GJGOBFDLFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x12C7270", Offset = "0x12C5870", VA = "0x1812C7270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x12D1C00", Offset = "0x12D0200", VA = "0x1812D1C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public Guid? AEBDEAIIPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xA4C390", Offset = "0xA4A990", VA = "0x180A4C390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xA4C420", Offset = "0xA4AA20", VA = "0x180A4C420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x748E760", Offset = "0x748CD60", VA = "0x18748E760")]
	public static LBMDELHPEOI OGFEFAEGGJN(int CLMNEDNIJMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x748E4A0", Offset = "0x748CAA0", VA = "0x18748E4A0")]
	public static LBMDELHPEOI IHJONIBDPDG(Guid BCMAFCIPNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x748E560", Offset = "0x748CB60", VA = "0x18748E560")]
	public static LBMDELHPEOI NKHEILHHOPP(JCHINFKCNJI KLKAKGPFOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LBMDELHPEOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public enum INNLOKKDOPN
{
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[CIADMBADCAJ]
public class FOFCLFMAPHB : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public MEPDKFDNMHJ EMPIFJJCHFO
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(MEPDKFDNMHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public int HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D70", Offset = "0xAA4370", VA = "0x180AA5D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0xAD8120", Offset = "0xAD6720", VA = "0x180AD8120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public HKKLLODBJAK PMKBNLHNJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0xF817E0", Offset = "0xF7FDE0", VA = "0x180F817E0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x748A380", Offset = "0x7488980", VA = "0x18748A380")]
	public int PKCJPKBDKPK(DateTime DMHNLLDLAHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FOFCLFMAPHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
[CIADMBADCAJ]
public class HKKLLODBJAK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public int APKPCJAGOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public DateTime? GFNJDLEEMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE90", Offset = "0xE8B490", VA = "0x180E8CE90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public DateTime? HADMPFJLBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x131A980", Offset = "0x1318F80", VA = "0x18131A980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x142C6E0", Offset = "0x142ACE0", VA = "0x18142C6E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x748B660", Offset = "0x7489C60", VA = "0x18748B660")]
	public bool JANJGLFPAPC(DateTime DMHNLLDLAHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x748B630", Offset = "0x7489C30", VA = "0x18748B630")]
	public int GCJKPCEKFJF(DateTime DMHNLLDLAHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x748B750", Offset = "0x7489D50", VA = "0x18748B750")]
	public TimeSpan? KCLFMOKDCCC(DateTime DMHNLLDLAHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public HKKLLODBJAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum DJOBOOACBNK
{
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public enum NOECFAIEIMO
{
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum KMOLBCDKKBA
{
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public enum BCCNEACFJGB
{
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public enum HKNDELHPPOI
{
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
[CIADMBADCAJ]
public class EOFFLGKKODI : IEquatable<EOFFLGKKODI>
{
	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public int? MGENMCGCKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public int? EIIIGEBMEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public int? KBAIOPKBMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public List<int>? BBBFEBFAOKA
	{
		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x748A010", Offset = "0x7488610", VA = "0x18748A010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x7489980", Offset = "0x7487F80", VA = "0x187489980")]
	public static EOFFLGKKODI BJIOFPAPAND(int? POFGADGMFOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x7489C10", Offset = "0x7488210", VA = "0x187489C10", Slot = "4")]
	public bool Equals(EOFFLGKKODI? HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x7489F70", Offset = "0x7488570", VA = "0x187489F70")]
	private static bool KNLHHPOBJNL(List<int>? DLGEPLKGJOC, List<int>? OKKFDNDPGLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x74899E0", Offset = "0x7487FE0", VA = "0x1874899E0", Slot = "0")]
	public override bool Equals(object? ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x7489D90", Offset = "0x7488390", VA = "0x187489D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EOFFLGKKODI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public struct JCHINFKCNJI : IEquatable<JCHINFKCNJI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public readonly INNLOKKDOPN INDPLLFCLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly int GJGOBFDLFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly Guid AEBDEAIIPPN;

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public Guid BIJMOEKLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x748CB00", Offset = "0x748B100", VA = "0x18748CB00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public int IJNODFEBCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x748D0F0", Offset = "0x748B6F0", VA = "0x18748D0F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public string EHBDINNMJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x748CAB0", Offset = "0x748B0B0", VA = "0x18748CAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x748C670", Offset = "0x748AC70", VA = "0x18748C670")]
	public static bool BCPBDAOBLPL(string BJIKALEHOLP, [Out] JCHINFKCNJI KLKAKGPFOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x748D100", Offset = "0x748B700", VA = "0x18748D100")]
	public static bool OEIDDEMFNFF(string DIJMJOPAMGK, [Out] JCHINFKCNJI KLKAKGPFOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x748CEB0", Offset = "0x748B4B0", VA = "0x18748CEB0")]
	public static JCHINFKCNJI JNBLMFKILPD(int HLIPPIOIAJK)
	{
		return default(JCHINFKCNJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x748CD60", Offset = "0x748B360", VA = "0x18748CD60")]
	public static JCHINFKCNJI HEKCGJGFCFE(Guid HLIPPIOIAJK)
	{
		return default(JCHINFKCNJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x748CFE0", Offset = "0x748B5E0", VA = "0x18748CFE0")]
	private static bool KFHCOPINAOI(string BJIKALEHOLP, [Out] INNLOKKDOPN IHJHDNAKKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x748D480", Offset = "0x748BA80", VA = "0x18748D480")]
	private JCHINFKCNJI(INNLOKKDOPN IHJHDNAKKAN, int? HBNIGKPEEFH, Guid? BCMAFCIPNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x748CB70", Offset = "0x748B170", VA = "0x18748CB70", Slot = "4")]
	public bool Equals(JCHINFKCNJI HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x748CBE0", Offset = "0x748B1E0", VA = "0x18748CBE0", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0x748CCD0", Offset = "0x748B2D0", VA = "0x18748CCD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x748D3D0", Offset = "0x748B9D0", VA = "0x18748D3D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[CIADMBADCAJ]
public abstract class CMJANDFMBCA : IEquatable<CMJANDFMBCA>, APOJDGIBLFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	public Guid CFEMHJOKDLP;

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x7488FE0", Offset = "0x74875E0", VA = "0x187488FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x7488F60", Offset = "0x7487560", VA = "0x187488F60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x7488E00", Offset = "0x7487400", VA = "0x187488E00", Slot = "4")]
	public bool Equals(CMJANDFMBCA HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x7488E40", Offset = "0x7487440", VA = "0x187488E40", Slot = "0")]
	public override bool Equals(object ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract CMJANDFMBCA PLEBMHKEBJO();

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected CMJANDFMBCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public enum GFAOFPFJBGH
{
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[CIADMBADCAJ]
public class MFNLLKPFCKA : CMJANDFMBCA, IEquatable<MFNLLKPFCKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	public GFAOFPFJBGH IHJHDNAKKAN;

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x748F500", Offset = "0x748DB00", VA = "0x18748F500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x748F3A0", Offset = "0x748D9A0", VA = "0x18748F3A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public MFNLLKPFCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x748F5A0", Offset = "0x748DBA0", VA = "0x18748F5A0")]
	public MFNLLKPFCKA(GFAOFPFJBGH IHJHDNAKKAN, Guid CFEMHJOKDLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x748F420", Offset = "0x748DA20", VA = "0x18748F420")]
	public static MFNLLKPFCKA HEKCGJGFCFE(Guid KBPGIMIOBMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x748F350", Offset = "0x748D950", VA = "0x18748F350", Slot = "7")]
	public bool Equals(MFNLLKPFCKA HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x748F490", Offset = "0x748DA90", VA = "0x18748F490", Slot = "6")]
	public override CMJANDFMBCA PLEBMHKEBJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public static class NKJGEPMPBFM
{
	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x748FF40", Offset = "0x748E540", VA = "0x18748FF40")]
	public static MFNLLKPFCKA FKMEBFFPAOD(this KOJLOCHPMBH GANFJJCKLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x748FFB0", Offset = "0x748E5B0", VA = "0x18748FFB0")]
	public static MFNLLKPFCKA ILNEICOLLHJ(string EOPEGLACBFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x74900A0", Offset = "0x748E6A0", VA = "0x1874900A0")]
	public static MFNLLKPFCKA JPKEGCEOOEO(Guid JKBDBKBOKHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
[CIADMBADCAJ]
public class KOJLOCHPMBH : JNHMHMBFGMO, APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public GFAOFPFJBGH INDPLLFCLBD
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(GFAOFPFJBGH);
		}
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public Guid DNHOGLPPLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x1A8E4C0", Offset = "0x1A8CAC0", VA = "0x181A8E4C0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B630", Offset = "0x5B09C30", VA = "0x185B0B630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public string EAENBKOLAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public long? HAHFIFLNJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0xFAE7A0", Offset = "0xFACDA0", VA = "0x180FAE7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xFAE790", Offset = "0xFACD90", VA = "0x180FAE790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public long HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xF02DB0", Offset = "0xF013B0", VA = "0x180F02DB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public Guid? NBDLLODCJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x748DFD0", Offset = "0x748C5D0", VA = "0x18748DFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x748DFF0", Offset = "0x748C5F0", VA = "0x18748DFF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public DateTime DPGMJFCBFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xF2C970", Offset = "0xF2AF70", VA = "0x180F2C970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public DateTime PEKBAAMDIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4E0", Offset = "0xA4AAE0", VA = "0x180A4C4E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xF2CFB0", Offset = "0xF2B5B0", VA = "0x180F2CFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KOJLOCHPMBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x748E0B0", Offset = "0x748C6B0", VA = "0x18748E0B0")]
	public KOJLOCHPMBH(GFAOFPFJBGH IHJHDNAKKAN, Guid CFEMHJOKDLP, [Optional] string IEDAJGLJHNI, [Optional] string LCNJPNDEDOK, [Optional] string ODEILPPIMEL, [Optional] long? CDFGHIILPDC, long ADABADLFLPA = 0L, [Optional] Guid? PEBLEPLNDAF, [Optional] DateTime AMNDDPALDCL, [Optional] DateTime JBPJPOBFPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x748E000", Offset = "0x748C600", VA = "0x18748E000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public enum HMHOHDFJNHD
{
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public enum CILJBLJBMIM
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x400050B")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
[CIADMBADCAJ]
public class IOFJDDCKIIM : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public CILJBLJBMIM ILBKEFOPONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(CILJBLJBMIM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public List<string> ADBKBPIBEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x748C1A0", Offset = "0x748A7A0", VA = "0x18748C1A0")]
	public string HPBBFMLKHJA(int FIIOOOJCPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public IOFJDDCKIIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
[CIADMBADCAJ]
public class CJJEGCAENDE : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public string HBHKBGCHJLI
	{
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public HMHOHDFJNHD AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(HMHOHDFJNHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CJJEGCAENDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public static class JCDAAHFFMEH
{
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public const string OLNDNAMDECP = "costume";

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public const string PDGODAJBMKE = "gadget";

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public const string DMKFFKPINGL = "holotar";

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public const string FLGEPEFILLM = "large";

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public const string AOCBFJPANIB = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public const string LBOICGPKMLN = "small";

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public const string HDOGPDEDHPL = "sound";

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public const string PMCDAMMJDEN = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public const string ACKOHADAFDL = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public const string KIFPMMIOEAK = "r2";

	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public static List<string> NNFNNMGJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x748C4A0", Offset = "0x748AAA0", VA = "0x18748C4A0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public static class LFAPFJJJANC
{
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	public const string BBKBMCGJCOB = "beta";

	[Cpp2IlInjected.Token(Token = "0x400051B")]
	public const string JEAALPGEPJB = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[CIADMBADCAJ]
public class ODEEIFDGDPM : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public List<string> GGEJNGBEMLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public List<string> HJBAAPDEJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public List<string> GHGEJMBPHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ODEEIFDGDPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public class PCNOKJENMGG : IEquatable<PCNOKJENMGG>
{
	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	protected virtual Type PNONPBIAIIO
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x74914F0", Offset = "0x748FAF0", VA = "0x1874914F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	public FIFHILIEFFB? KOHOONDAPFI
	{
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	public HttpMethod? GJCMOJDENOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	public string? KJKFAAFKLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x74916C0", Offset = "0x748FCC0", VA = "0x1874916C0")]
	public PCNOKJENMGG(FIFHILIEFFB? KOHOONDAPFI, HttpMethod? GJCMOJDENOE, string? KJKFAAFKLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x7491550", Offset = "0x748FB50", VA = "0x187491550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x7490F30", Offset = "0x748F530", VA = "0x187490F30", Slot = "6")]
	protected virtual bool AFDKKGHEFOP(StringBuilder EFJHDEJOACO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x1190260", Offset = "0x118E860", VA = "0x181190260")]
	public static bool FLMCEAOBGCC(PCNOKJENMGG? KJGKKGDJGKG, PCNOKJENMGG? GOLILJEAEPG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x11903C0", Offset = "0x118E9C0", VA = "0x1811903C0")]
	public static bool JKIBMILPCGE(PCNOKJENMGG? KJGKKGDJGKG, PCNOKJENMGG? GOLILJEAEPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x7491380", Offset = "0x748F980", VA = "0x187491380", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x74912B0", Offset = "0x748F8B0", VA = "0x1874912B0", Slot = "0")]
	public override bool Equals(object? ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x7491120", Offset = "0x748F720", VA = "0x187491120", Slot = "7")]
	public virtual bool Equals(PCNOKJENMGG? HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x7491090", Offset = "0x748F690", VA = "0x187491090", Slot = "8")]
	public virtual PCNOKJENMGG ELMEFHHBPLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x7491660", Offset = "0x748FC60", VA = "0x187491660")]
	protected PCNOKJENMGG(PCNOKJENMGG DAODMDNLCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x7491340", Offset = "0x748F940", VA = "0x187491340")]
	public void GMJJAGOJIKC([Out] FIFHILIEFFB? KOHOONDAPFI, [Out] HttpMethod? GJCMOJDENOE, [Out] string? KJKFAAFKLPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public class JFHPJOICJGH : IEquatable<JFHPJOICJGH>
{
	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	protected virtual Type PNONPBIAIIO
	{
		[Cpp2IlInjected.Token(Token = "0x600072F")]
		[Cpp2IlInjected.Address(RVA = "0x748DB80", Offset = "0x748C180", VA = "0x18748DB80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	public int AFBBEHPBIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000730")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	public KPDPAHIIOGF IKLKEHPFIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000732")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D70", Offset = "0xAA4370", VA = "0x180AA5D70")]
		[CompilerGenerated]
		get
		{
			return default(KPDPAHIIOGF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0xAD8120", Offset = "0xAD6720", VA = "0x180AD8120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x748DCF0", Offset = "0x748C2F0", VA = "0x18748DCF0")]
	public JFHPJOICJGH(int AFBBEHPBIFP, KPDPAHIIOGF IKLKEHPFIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x748DBE0", Offset = "0x748C1E0", VA = "0x18748DBE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x748D6F0", Offset = "0x748BCF0", VA = "0x18748D6F0", Slot = "6")]
	protected virtual bool AFDKKGHEFOP(StringBuilder EFJHDEJOACO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x1190260", Offset = "0x118E860", VA = "0x181190260")]
	public static bool FLMCEAOBGCC(JFHPJOICJGH? KJGKKGDJGKG, JFHPJOICJGH? GOLILJEAEPG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x11903C0", Offset = "0x118E9C0", VA = "0x1811903C0")]
	public static bool JKIBMILPCGE(JFHPJOICJGH? KJGKKGDJGKG, JFHPJOICJGH? GOLILJEAEPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x748DA70", Offset = "0x748C070", VA = "0x18748DA70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x748D890", Offset = "0x748BE90", VA = "0x18748D890", Slot = "0")]
	public override bool Equals(object? ODCICEDDLMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x748D920", Offset = "0x748BF20", VA = "0x18748D920", Slot = "7")]
	public virtual bool Equals(JFHPJOICJGH? HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x748D820", Offset = "0x748BE20", VA = "0x18748D820", Slot = "8")]
	public virtual JFHPJOICJGH ELMEFHHBPLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0xC52210", Offset = "0xC50810", VA = "0x180C52210")]
	protected JFHPJOICJGH(JFHPJOICJGH DAODMDNLCCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x748DA60", Offset = "0x748C060", VA = "0x18748DA60")]
	public void GMJJAGOJIKC([Out] int AFBBEHPBIFP, [Out] KPDPAHIIOGF IKLKEHPFIAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public enum KPDPAHIIOGF
{
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x4000527")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public interface DBECMNPBAII
{
	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<PCNOKJENMGG, JFHPJOICJGH> GAAEPOCEEPP();

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGCAFFIJCIP(PCNOKJENMGG BLIBAMJKLIA, JFHPJOICJGH CJDOILFHDJI);

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEGOLCAMNJN(PCNOKJENMGG BLIBAMJKLIA);

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFGPFEEJJFG();

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FCHNDKJNAFC(FIFHILIEFFB BDLLFBOLFCP, HttpMethod PBFMFMMGIGC, string IOIDHBLPKAK, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public interface LNJCPCNCNAP
{
	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<Guid>> DDODDPMDGDE(string BOLJPDCCFNG);
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[OLLONIIMODM]
public class EPJMGKEPGPO<TResult> where TResult : APOJDGIBLFD, new()
{
	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public IReadOnlyList<TResult> AIAMILEDECI
	{
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public long LLKIDAHBGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EPJMGKEPGPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public enum BCKJFIAAFNE
{
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public interface GMABAJFNOOP : PKLEJAGCMOD
{
	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	bool ABCJLOMCGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long FJECJBEFCLN, NOJFFLIOBJI GIDDJMDKBLG);

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HIPJFLFIKKB> PurchaseAsync(NOJFFLIOBJI GIDDJMDKBLG, EOFFLGKKODI KILIJJFBGPG);

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(FKGCGEBMEBD JAEACHNOFIE, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public interface PKLEJAGCMOD
{
	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	bool HMOHGKBOFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public interface HKBHNPICBIE
{
	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	int LCBJKELMFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<NOJFFLIOBJI>> PIIEGCHFGBO(bool DAOBJGJLKDC = false, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCPAFHAOJKF([Out] NOJFFLIOBJI? KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<NOJFFLIOBJI> EPOLHBMJMGO(bool DAOBJGJLKDC = false, [Optional] CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEBJCJLKBGB(string CIOGCOOPLBM = "");
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public interface JMMAMIBLOLO
{
	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BJONNFGPBML(FKGCGEBMEBD JAEACHNOFIE, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EKGPHAIHNNC(FKGCGEBMEBD JAEACHNOFIE, CancellationToken KMHHNOGHBLL, [Optional] GECDEOJJPGN? MBBMJIGJMLG);
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public interface GECDEOJJPGN
{
	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBPPJPALCCC(string GHLKMGHMNIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public interface FGCPKECLPEL
{
	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JPLDLJHANKJ(FKGCGEBMEBD GGHDJCPMGPE, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public interface CGGFBPDMLKB
{
	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	bool AJAADDIEGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public interface JLIJNLGKLLL
{
	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKGCGEBMEBD COGLNFHEGOB(NOJFFLIOBJI GIDDJMDKBLG, EOFFLGKKODI KILIJJFBGPG, string HGKDPLMGNLK, [Optional] JMMAMIBLOLO? DKIOHHGMEGN);
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public interface DNJKAOCMGIA
{
	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMAJCAOHEAF(FGCPKECLPEL NKIIOMEEMNC);

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHKBGCINKEG(FGCPKECLPEL NKIIOMEEMNC);

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LPDNFHEAMAL(FKGCGEBMEBD JAEACHNOFIE, CancellationToken KMHHNOGHBLL);
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public interface FKGCGEBMEBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000300")]
	DKBOJGKNIFA JAMFMPFAIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	NOJFFLIOBJI HGOGHIMHACF
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	EOFFLGKKODI GHGGABPGDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	string IALGEAEIDFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	string AMFFCGONNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PHGLFEPJKHN> CLIJEGFHIDI(CancellationToken BACOGCKOPIE, [Optional] GECDEOJJPGN? MBBMJIGJMLG);

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBBBFCNPOBH(string KDAOOGLIINF);

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBBBFCNPOBH<T>(Func<T, string> KDAOOGLIINF, [In] T HFEOGNFCJLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public abstract class CNFHJHGFDBA
{
	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected CNFHJHGFDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
public enum BMLEBMHGIKO
{
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public enum KFKOOKAELJA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x4000541")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x4000542")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
[CIADMBADCAJ]
public class NOJFFLIOBJI : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public int PGJNJACNFAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public string JCLOOAICKLF
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public string EAENBKOLAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public int HKIAIAHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA47FE0", Offset = "0xA465E0", VA = "0x180A47FE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xA47FD0", Offset = "0xA465D0", VA = "0x180A47FD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public string IKIOAGIEJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public string KEFIEKGCIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	[DataMember(Name = "PsnProductLabel")]
	public string DOCBPAFJPHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	public string CBCFEIKKFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	public string ADCPLNJKJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0xA44970", Offset = "0xA42F70", VA = "0x180A44970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xA449B0", Offset = "0xA42FB0", VA = "0x180A449B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	public string IJGJIEFMNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public string HIBBJNLMMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xA449A0", Offset = "0xA42FA0", VA = "0x180A449A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA44980", Offset = "0xA42F80", VA = "0x180A44980")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public string JMIEMGHIMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA50E50", Offset = "0xA4F450", VA = "0x180A50E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xA50C70", Offset = "0xA4F270", VA = "0x180A50C70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public bool JBLJOPJPLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xD01360", Offset = "0xCFF960", VA = "0x180D01360")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0xD009E0", Offset = "0xCFEFE0", VA = "0x180D009E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public bool NDMLKCNAJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0xFE8080", Offset = "0xFE6680", VA = "0x180FE8080")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x1754C40", Offset = "0x1753240", VA = "0x181754C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public JPGGOPBLONE IKFGCCPLOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4AA00", VA = "0x180A4C400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA4C2F0", Offset = "0xA4A8F0", VA = "0x180A4C2F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	[IgnoreDataMember]
	public string OHEECHNOCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA4C410", Offset = "0xA4AA10", VA = "0x180A4C410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xA4C320", Offset = "0xA4A920", VA = "0x180A4C320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	[IgnoreDataMember]
	public string GLNDDBHINKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xAB07D0", Offset = "0xAAEDD0", VA = "0x180AB07D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAADC60", VA = "0x180AAF660")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	[IgnoreDataMember]
	public string PMCGACIPEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xA4C3C0", Offset = "0xA4A9C0", VA = "0x180A4C3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xA4C440", Offset = "0xA4AA40", VA = "0x180A4C440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	[IgnoreDataMember]
	public CNFHJHGFDBA JOLNFPHMMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0xAB0BF0", Offset = "0xAAF1F0", VA = "0x180AB0BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xF26510", Offset = "0xF24B10", VA = "0x180F26510")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	[IgnoreDataMember]
	public bool MOPGAJFJNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x7490620", Offset = "0x748EC20", VA = "0x187490620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	[IgnoreDataMember]
	public string MEEJEFFMNJE
	{
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0xA51E60", Offset = "0xA50460", VA = "0x180A51E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xA51EE0", Offset = "0xA504E0", VA = "0x180A51EE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x7490530", Offset = "0x748EB30", VA = "0x187490530", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x7490490", Offset = "0x748EA90", VA = "0x187490490")]
	public static NOJFFLIOBJI DDMPPCGGMJA(int HLIPPIOIAJK, string IEDAJGLJHNI, string ODEILPPIMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x7490640", Offset = "0x748EC40", VA = "0x187490640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NOJFFLIOBJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[CIADMBADCAJ]
public class JPGGOPBLONE : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public List<int> LGFHDFFBHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public string FMPMDNIMCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public PFMHJPHDLFG IFBFPIOHFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0xF817E0", Offset = "0xF7FDE0", VA = "0x180F817E0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JPGGOPBLONE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public readonly struct PHGLFEPJKHN
{
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	public enum GEMKKOGOIBD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	public readonly GEMKKOGOIBD DLHKOLJKLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	public readonly KFKOOKAELJA DDKGOEPKELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	public readonly BMLEBMHGIKO EEMDJPMLCCN;

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x7491B90", Offset = "0x7490190", VA = "0x187491B90")]
	private PHGLFEPJKHN(GEMKKOGOIBD DCPJOMEJHIO, KFKOOKAELJA HECMJJBOGHC = KFKOOKAELJA.Unknown, BMLEBMHGIKO IHMJBELMLAP = BMLEBMHGIKO.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x7491B70", Offset = "0x7490170", VA = "0x187491B70")]
	public static PHGLFEPJKHN NMGKKEJKHDO()
	{
		return default(PHGLFEPJKHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x7491B30", Offset = "0x7490130", VA = "0x187491B30")]
	public static PHGLFEPJKHN FJGDPIKDDOL()
	{
		return default(PHGLFEPJKHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x7491B50", Offset = "0x7490150", VA = "0x187491B50")]
	public static PHGLFEPJKHN HPIFBGNILIB(KFKOOKAELJA HECMJJBOGHC, BMLEBMHGIKO IHMJBELMLAP)
	{
		return default(PHGLFEPJKHN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public enum OKEJGNIGJGA
{
	[Cpp2IlInjected.Token(Token = "0x4000563")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public enum KFNOHAKGNGA
{
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[CIADMBADCAJ]
public class PFMHJPHDLFG : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public OKEJGNIGJGA PLLLFHBNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(OKEJGNIGJGA);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public KFNOHAKGNGA BMOFPNJKIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D70", Offset = "0xAA4370", VA = "0x180AA5D70")]
		[CompilerGenerated]
		get
		{
			return default(KFNOHAKGNGA);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xAD8120", Offset = "0xAD6720", VA = "0x180AD8120")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public bool JIHBJKJPFDP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xA441A0", Offset = "0xA427A0", VA = "0x180A441A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public PFMHJPHDLFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public enum DKBOJGKNIFA
{
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[CIADMBADCAJ]
public class NFCFPMMJIFP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public long MKOOEHCIIFF
	{
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public long DHDIOGLBOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public bool FMMPDMMHILA
	{
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NFCFPMMJIFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[CIADMBADCAJ]
public class FEGMAGNCJJM : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public string LFOHLCKGMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public EMIHDJEIJLN? COFOODHEENN
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public IReadOnlyList<EMIHDJEIJLN>? KKBOOGHKJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public IReadOnlyList<string>? HBDFFDBGKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public DDLCAJLOKCJ HIHDKLNGDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public string? GKBBIPJGADE
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public string? DILKFADPICP
	{
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public string? PLHDPGIFKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FEGMAGNCJJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[CIADMBADCAJ]
public class EMLLLKPKINM : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public string GHAPNAILIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public EMIHDJEIJLN? COFOODHEENN
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public DDLCAJLOKCJ HIHDKLNGDFM
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public string? DILKFADPICP
	{
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public IReadOnlyList<string>? HBDFFDBGKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EMLLLKPKINM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[CIADMBADCAJ]
public class DDLCAJLOKCJ : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public string PMNPKLOIFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public bool OLONEJIBHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA441A0", Offset = "0xA427A0", VA = "0x180A441A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public bool IOABPHCADBG
	{
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0xFD1930", Offset = "0xFCFF30", VA = "0x180FD1930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0xFD1610", Offset = "0xFCFC10", VA = "0x180FD1610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public bool HBBPIGODCBO
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x1124C20", Offset = "0x1123220", VA = "0x181124C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x1598D80", Offset = "0x1597380", VA = "0x181598D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public bool HEDHMGPBAHL
	{
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x1124C10", Offset = "0x1123210", VA = "0x181124C10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x57E3760", Offset = "0x57E1D60", VA = "0x1857E3760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public bool IHDCLBNAEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xAA58D0", Offset = "0xAA3ED0", VA = "0x180AA58D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0xDF4C20", Offset = "0xDF3220", VA = "0x180DF4C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public bool HJBOKMABGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0xAB7D70", Offset = "0xAB6370", VA = "0x180AB7D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xDF5190", Offset = "0xDF3790", VA = "0x180DF5190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public bool LCACCDJAAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x19F6DE0", Offset = "0x19F53E0", VA = "0x1819F6DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x7489150", Offset = "0x7487750", VA = "0x187489150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public bool HEEFGIAJPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x19F40B0", Offset = "0x19F26B0", VA = "0x1819F40B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x7489160", Offset = "0x7487760", VA = "0x187489160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public bool CBJBOEDFCMO
	{
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public bool NHHOLJCGNBG
	{
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x146ED60", Offset = "0x146D360", VA = "0x18146ED60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x146E880", Offset = "0x146CE80", VA = "0x18146E880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public bool GPNEHMLMBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x1563280", Offset = "0x1561880", VA = "0x181563280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x1562E70", Offset = "0x1561470", VA = "0x181562E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x7489170", Offset = "0x7487770", VA = "0x187489170")]
	public DDLCAJLOKCJ(string CFMEKHEHAJP, bool KALAGPBFMMG, bool BJPNIBGCLHE, bool LCPEBOALBEA, bool INFEBDDKMBP, bool BELODGKLCDP, bool JPKHCABCKBF, bool CMECAJPBAGE, bool IAPDGEKMMDF, bool EFOFGNCAHKJ, bool HNLOHEMFMLB, bool LFBGAOLEFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[CIADMBADCAJ]
public class OMMFFIIOAGJ : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public string DCDKAOJCJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public string PLHDPGIFKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public string GKBBIPJGADE
	{
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public string? EFGKLGONFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public string? CHAHIMEKKIE
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public float DJOCBPLLIIF
	{
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xA9FB60", Offset = "0xA9E160", VA = "0x180A9FB60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0A90", Offset = "0x1DAF090", VA = "0x181DB0A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OMMFFIIOAGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
[CIADMBADCAJ]
public class JOIGMCEIJIH : IKCBACLDDOA, APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public string FCBCDLCJCDK
	{
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public string PCEENEHLFGO
	{
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "6")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JOIGMCEIJIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[CIADMBADCAJ]
public class LBGCFKHKPEL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public Guid CACEDBKDEME
	{
		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0xDF7680", Offset = "0xDF5C80", VA = "0x180DF7680")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xDF7690", Offset = "0xDF5C90", VA = "0x180DF7690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public long GGKMALGKHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public decimal PGFPOCCFMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x131A980", Offset = "0x1318F80", VA = "0x18131A980")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x142C6E0", Offset = "0x142ACE0", VA = "0x18142C6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public LBGCFKHKPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[CIADMBADCAJ]
public class FHGALHEMFLK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000348")]
	public string FCBCDLCJCDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000349")]
	public string IIKJFFJKHAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FHGALHEMFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public FHGALHEMFLK(string DLFENPHGOLM, string MGGELLPHCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[CIADMBADCAJ]
public class DNJGLPDBIHF : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	public string PLHDPGIFKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	public string LFOHLCKGMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	public bool CFKONFIHNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA50EA0", Offset = "0xA4F4A0", VA = "0x180A50EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA50E40", Offset = "0xA4F440", VA = "0x180A50E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public DNJGLPDBIHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[CIADMBADCAJ]
public class CIHBEAMACML : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	public string LILOMNMJMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	public decimal NKCKLHKCBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE90", Offset = "0xE8B490", VA = "0x180E8CE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CIHBEAMACML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[CIADMBADCAJ]
public class OKKGEOFDHMP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	public string PLHDPGIFKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public string LFOHLCKGMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public string NOIMIBIIPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OKKGEOFDHMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[CIADMBADCAJ]
public class ABIHHJEILJG : CNDLDEMGNIA
{
	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ABIHHJEILJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[CIADMBADCAJ]
public class NPPNBJJGMHO : CDOKLCOLNJN
{
	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NPPNBJJGMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
[CIADMBADCAJ]
public class JCCNHAIEDKA : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public string? PLHDPGIFKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public string LFOHLCKGMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x748C450", Offset = "0x748AA50", VA = "0x18748C450")]
	public JCCNHAIEDKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[CIADMBADCAJ]
public class CDOKLCOLNJN : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public string PLHDPGIFKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public string LFOHLCKGMBK
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CDOKLCOLNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
[CIADMBADCAJ]
public class CNDLDEMGNIA : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public List<string> KFIACHECLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public decimal JBHDMGABLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE90", Offset = "0xE8B490", VA = "0x180E8CE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CNDLDEMGNIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
[CIADMBADCAJ]
public class BFCHMLFBFLH : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public int NJJOPPIMCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public string AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public string? GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public IReadOnlyList<int> MMFKENIJODJ
	{
		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public string? LHHOOLLIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000841")]
	[Cpp2IlInjected.Address(RVA = "0x7487BC0", Offset = "0x74861C0", VA = "0x187487BC0")]
	public BFCHMLFBFLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
[CIADMBADCAJ]
public class OJPLLLJADAP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public int NJJOPPIMCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public Guid? AEBDEAIIPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x2385D20", Offset = "0x2384320", VA = "0x182385D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x2385CF0", Offset = "0x23842F0", VA = "0x182385CF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public string AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000360")]
	public List<BFCHMLFBFLH> MHIADBBLMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	public List<BFCHMLFBFLH> CBOKBLGJAHF
	{
		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000362")]
	public string? GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	public string? LHHOOLLIFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	public string? FOPJNGBMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xA449C0", Offset = "0xA42FC0", VA = "0x180A449C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x7490C60", Offset = "0x748F260", VA = "0x187490C60", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x7490C90", Offset = "0x748F290", VA = "0x187490C90")]
	public OJPLLLJADAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[CIADMBADCAJ]
public class CDEALMAPNPG : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000365")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000366")]
	public OJPLLLJADAP MHIADBBLMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public OJPLLLJADAP CBOKBLGJAHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public string? FOPJNGBMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600085C")]
	[Cpp2IlInjected.Address(RVA = "0x7488180", Offset = "0x7486780", VA = "0x187488180", Slot = "5")]
	public virtual void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CDEALMAPNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[CIADMBADCAJ]
public class PCJEKJKGICP : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public IReadOnlyList<OJPLLLJADAP> GPIMDOKBBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public IReadOnlyList<CDEALMAPNPG> OEBKKOMMHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	public IReadOnlyList<PCJEKJKGICP> ODMCMHAMAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	public string? FOPJNGBMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x7490DE0", Offset = "0x748F3E0", VA = "0x187490DE0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x7490E10", Offset = "0x748F410", VA = "0x187490E10")]
	public PCJEKJKGICP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[CIADMBADCAJ]
public class NIHHNOHOACE : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	public const string PMGEHIPKBJO = "REPL_";

	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	public string NJJOPPIMCLB
	{
		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	public int HPNMEGHPAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED00", Offset = "0xA4D300", VA = "0x180A4ED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public NIHHNOHOACE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
[CIADMBADCAJ]
public class EMIHDJEIJLN : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000370")]
	public int? MBLBFBKCCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000371")]
	public string? GGAPOPGACBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000372")]
	public string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	public string AKEHBOGGIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000374")]
	public List<EMIHDJEIJLN>? OOOMLMJLCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000375")]
	public NIHHNOHOACE? CJDLIPLBHDK
	{
		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0x7489960", Offset = "0x7487F60", VA = "0x187489960", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087D")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EMIHDJEIJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[CIADMBADCAJ]
public class OFMPFCDBKMK : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000376")]
	public string MBBMKMLDOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000377")]
	public string AJPHBINIDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000882")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000883")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public OFMPFCDBKMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
[CIADMBADCAJ]
public class HBGFDODPBPA : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000378")]
	public string NJJOPPIMCLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000379")]
	public PCJEKJKGICP HGGJGDOMAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037A")]
	public EMIHDJEIJLN? COFOODHEENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037B")]
	public List<EMIHDJEIJLN>? KKBOOGHKJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037C")]
	public IReadOnlyList<OJPLLLJADAP> CPAEIAJEIHD
	{
		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037D")]
	public IReadOnlyList<OFMPFCDBKMK> BENMCKGNLJK
	{
		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700037E")]
	public string? GHAPNAILIOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0xA47BF0", Offset = "0xA461F0", VA = "0x180A47BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000892")]
	[Cpp2IlInjected.Address(RVA = "0x748A450", Offset = "0x7488A50", VA = "0x18748A450", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000893")]
	[Cpp2IlInjected.Address(RVA = "0x748A4E0", Offset = "0x7488AE0", VA = "0x18748A4E0")]
	public HBGFDODPBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[CIADMBADCAJ]
public class KCFJOGDOBPF : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700037F")]
	public GNFLAJOEABN<HBGFDODPBPA> ILBKEFOPONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000380")]
	public decimal DCMGANCKEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE90", Offset = "0xE8B490", VA = "0x180E8CE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x724C940", Offset = "0x724AF40", VA = "0x18724C940", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KCFJOGDOBPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public enum AHEFEDOADDN
{
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
[CIADMBADCAJ]
public class FCOOFHNJDGL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000381")]
	public AHEFEDOADDN GFIMJFDINPE
	{
		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(AHEFEDOADDN);
		}
		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000382")]
	public DateTime NGDCLJIOKBH
	{
		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public FCOOFHNJDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[CIADMBADCAJ]
public class JNHGOGFLEDL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000383")]
	public AHEFEDOADDN HFKCJDAJGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(AHEFEDOADDN);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000384")]
	public float MOPMEDOMBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0xDF5520", Offset = "0xDF3B20", VA = "0x180DF5520")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0xDF5600", Offset = "0xDF3C00", VA = "0x180DF5600")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A5")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JNHGOGFLEDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
[CIADMBADCAJ]
public class KBDNIMGLDPN : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x17000385")]
	public AHEFEDOADDN GFIMJFDINPE
	{
		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		[CompilerGenerated]
		get
		{
			return default(AHEFEDOADDN);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000386")]
	public DateTime NGDCLJIOKBH
	{
		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000387")]
	public AHEFEDOADDN HFKCJDAJGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(AHEFEDOADDN);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0xD36F90", Offset = "0xD35590", VA = "0x180D36F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000388")]
	public float MOPMEDOMBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0xF55F60", Offset = "0xF54560", VA = "0x180F55F60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x141C230", Offset = "0x141A830", VA = "0x18141C230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000389")]
	public AHEFEDOADDN EBKMIMMLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0")]
		[CompilerGenerated]
		get
		{
			return default(AHEFEDOADDN);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xA450F0", Offset = "0xA436F0", VA = "0x180A450F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038A")]
	public float PILMHKPPNPC
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xD089C0", Offset = "0xD06FC0", VA = "0x180D089C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0xD089D0", Offset = "0xD06FD0", VA = "0x180D089D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public KBDNIMGLDPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
[CIADMBADCAJ]
public class JBFLLDPKAIL : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700038B")]
	public TimeSpan JNHFCMEPKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B5")]
		[Cpp2IlInjected.Address(RVA = "0xDDC270", Offset = "0xDDA870", VA = "0x180DDC270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700038C")]
	public TimeSpan GEHLAJOBKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60008B6")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B7")]
		[Cpp2IlInjected.Address(RVA = "0xD23850", Offset = "0xD21E50", VA = "0x180D23850")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public JBFLLDPKAIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[CIADMBADCAJ]
public class EOJODJOFJIC : APOJDGIBLFD
{
	[Cpp2IlInjected.Token(Token = "0x1700038D")]
	public List<string> IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void GNBOFPMLAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EOJODJOFJIC()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000151")]
public class ILCOKFFEKFJ
{
	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public ILCOKFFEKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x71B09E0", Offset = "0x71AEFE0", VA = "0x1871B09E0")]
	public static string HJEDGOHBNGI(byte[] CDANPLOBMID, byte[] HJFONKAADOK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
