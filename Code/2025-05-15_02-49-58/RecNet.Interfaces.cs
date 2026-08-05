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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x71669E0", Offset = "0x7164FE0", VA = "0x1871669E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HFNGOCGJOMO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum HGEIOAHFFBF
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
	public string FGGCIOFGMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string PDNFAIKBCJO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HGEIOAHFFBF OJLEPIEOLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(HGEIOAHFFBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IFOBPLPDPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x202ADF0", Offset = "0x20293F0", VA = "0x18202ADF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FNJBFKLHKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x173EAA0", Offset = "0x173D0A0", VA = "0x18173EAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7162200", Offset = "0x7160800", VA = "0x187162200")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static HFNGOCGJOMO JPLAKFPJJKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7162170", Offset = "0x7160770", VA = "0x187162170")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static HFNGOCGJOMO FKJBHNMNOGE([Optional] string GNANGFGOPEH, [Optional] string KNLBMBLGDAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HFNGOCGJOMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PGNAHLEOJHC
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string OHDIDODLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string IBFJODFHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PFJBEGCDCID
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NPNKPOOAOFG<PGOAANHEJBG> JIFCBPEHAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NPNKPOOAOFG<HFOJOBCEKAK> NIILHJGCIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KICNHCAEGMA<BHMLJBEAHPD?, BHMLJBEAHPD> BGPKFLGEFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJHPANODDAM();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<JNFBFBMIKLM> FCACJHFFLPE(bool OIHKAMOAGPO, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BHMLJBEAHPD> PFBEJOJBFCA(bool HNABELBCGEA = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<PGNAHLEOJHC> HHLLGFHLGBG(string NPLGNNPICKO, string LFLBLDPJMBC, string JJHBEMCOPJF, string? CJGPEFPOBBJ, float HNBENKBGPAC, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<JNFBFBMIKLM> JNKLGCMHJEE(long CFBANPJJEAK, decimal LFFLFPPOBFA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task JKBNKKGFGAG(string PNBLCEBBDDJ, string CAGGFIHFLKF, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task DLHAFBEHLBO(long KFBNLDNKNID, string CAGGFIHFLKF, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<string> LDPDCMGHLPB(long KFBNLDNKNID, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<string> CENDBIMILIB(string NPLGNNPICKO, string HIFFKLNHIEF, [Optional] string? CFNMLMNHCMF, [Optional] string? PBOJKGAIIPK, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<GIOJGGIGFKG?>? DPAFLPPGAMP(string HIFFKLNHIEF, [Optional] ONOOOJEFPBH? JMAOGCEDADG, [Optional] string? KLGLENDFPGC, bool CGNEBFLMGLH = false, [Optional] string? LFLBLDPJMBC, [Optional] string? DPDEBNILFJJ, [Optional] string? NPLGNNPICKO, [Optional] bool? LOBPONCMADD, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<GIOJGGIGFKG> FAKOHOABPJF(string DAOAPLFBLDC, [Optional] ONOOOJEFPBH? JMAOGCEDADG, bool CGNEBFLMGLH = false, [Optional] string? DPDEBNILFJJ, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JKCKIBDLOBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string JMFFIFHDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string CMCLMJAIBIM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string ILNNINHEHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string EGBOFAHGAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string AAJKGFBPKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string GEHGGOLACCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int? HEFNBFIDINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int? IABOMJEHJOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7163900", Offset = "0x7161F00", VA = "0x187163900")]
	public JKCKIBDLOBO(string JGMFGDGALBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x71638D0", Offset = "0x7161ED0", VA = "0x1871638D0")]
	public void HIDIHJMCHCH(string AJJLFHDFEEI = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x71637D0", Offset = "0x7161DD0", VA = "0x1871637D0")]
	private void GGNIMFIJHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JDEEEMCCBGE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	HGAOMCLAJHP FGBMLAMOLHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PHGAFJJAAOB> MMBEBCDKPPF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GAJFFPKLOEG> CHABPKINKDK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GAJFFPKLOEG> MKCFBCFHFOM(bool LJLJHJONNNE = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CAGOJCFILKC([Out] GAJFFPKLOEG BJLJHPBLMED);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AOAIKNNCLMM
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x715D9B0", Offset = "0x715BFB0", VA = "0x18715D9B0")]
	public static bool MFPONPFNCND(this JDEEEMCCBGE DCGILIKEFGE, [Out] PHGAFJJAAOB FPAJFCJDKLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x715DA90", Offset = "0x715C090", VA = "0x18715DA90")]
	public static bool NNPDFMOFLAN(this JDEEEMCCBGE DCGILIKEFGE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BMKCIAMKPLD
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BKJFNLCKCLM(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHKJJCJDEFE(int DGJLNFJHMKG, [Out] CFDEPPHCIPB? NFFGNPJGBOO);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CFDEPPHCIPB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int MGEMGHMBLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string? IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string? BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool? IJJCNOGLBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? NGHILNCCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string? IBGJCOLKKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CGMHNIOFJFK? DPAACGNNAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KADFFBCIDGM(string HDBLICOOCLH, [Out] GHGMBNHHIGA? NFFGNPJGBOO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GHGMBNHHIGA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string? KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? JGINLOCIGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IReadOnlyList<JNJIIDDPIFI>? JGDFHHCGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	CGMHNIOFJFK? DPAACGNNAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	long? LKLMJNHGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface JNJIIDDPIFI
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	GPEIPJPGKNC PICPFGEFJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CGMHNIOFJFK
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string? GLOKAOHPEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[KGJMAOFDNAE]
public class BMGFBOJHNHE
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public List<NHDBEPMOOGG> IIBMBEOPNGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Dictionary<string, string> OBDCLFOAIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x715F490", Offset = "0x715DA90", VA = "0x18715F490")]
	public BMGFBOJHNHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KGJMAOFDNAE]
public class NHDBEPMOOGG
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int MGEMGHMBLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string NGHILNCCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string IBGJCOLKKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool? IJJCNOGLBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF00", Offset = "0xD2A500", VA = "0x180D2BF00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF10", Offset = "0xD2A510", VA = "0x180D2BF10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public PCFLEAPBMMB DPAACGNNAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Dictionary<string, PMBJKLIAHJF> JBFLAIIKOCL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x71665B0", Offset = "0x7164BB0", VA = "0x1871665B0")]
	public NHDBEPMOOGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[KGJMAOFDNAE]
public class PCFLEAPBMMB
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string GLOKAOHPEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PCFLEAPBMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[KGJMAOFDNAE]
public class PMBJKLIAHJF
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string JGINLOCIGBG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public List<ICNEEIOAFOL> JGDFHHCGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PCFLEAPBMMB DPAACGNNAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public long LKLMJNHGCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7167270", Offset = "0x7165870", VA = "0x187167270")]
	public PMBJKLIAHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum GPEIPJPGKNC
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
[KGJMAOFDNAE]
public class ICNEEIOAFOL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public GPEIPJPGKNC PICPFGEFJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(GPEIPJPGKNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public ICNEEIOAFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct BEJKEHBAEFJ : IEquatable<BEJKEHBAEFJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool LHPCJNJIGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime IBDEHGDKNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool FEJEMBMGEGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly KBKDLGNDCGI? KLOGBIFGMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string PBCJMOLFCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? ICLPLFHLAFD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static BEJKEHBAEFJ JAJLEBKKLPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x27321F0", Offset = "0x27307F0", VA = "0x1827321F0")]
		get
		{
			return default(BEJKEHBAEFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x715E570", Offset = "0x715CB70", VA = "0x18715E570")]
	public BEJKEHBAEFJ(DateTime GNOINOIKIEA, bool PLPPEJDLOOJ, KBKDLGNDCGI? ONFAIAACMCL, string GLJFPJNEONO, int? OFMBJGJIHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x715E3E0", Offset = "0x715C9E0", VA = "0x18715E3E0")]
	public PHGAFJJAAOB KOPBPDOIIOH(HGAOMCLAJHP POFHCGLLAAJ)
	{
		return default(PHGAFJJAAOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x715E360", Offset = "0x715C960", VA = "0x18715E360")]
	private static PHGAFJJAAOB ICMCNCLDKAN(HGAOMCLAJHP POFHCGLLAAJ, DateTime GNOINOIKIEA)
	{
		return default(PHGAFJJAAOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x715E0A0", Offset = "0x715C6A0", VA = "0x18715E0A0", Slot = "4")]
	public bool Equals(BEJKEHBAEFJ MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x715E200", Offset = "0x715C800", VA = "0x18715E200", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x715E2B0", Offset = "0x715C8B0", VA = "0x18715E2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x715E470", Offset = "0x715CA70", VA = "0x18715E470")]
	public static bool MMJMCICIDNJ(BEJKEHBAEFJ JOOBCOFNIAM, BEJKEHBAEFJ MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x715E060", Offset = "0x715C660", VA = "0x18715E060")]
	public static bool DIKHMNDIIDO(BEJKEHBAEFJ JOOBCOFNIAM, BEJKEHBAEFJ MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x715E4A0", Offset = "0x715CAA0", VA = "0x18715E4A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GAJFFPKLOEG : IEquatable<GAJFFPKLOEG>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly GAJFFPKLOEG JAJLEBKKLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool LKIDIFGHMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly PHGAFJJAAOB LIAKGICCCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly BEJKEHBAEFJ OHIGKJNOOCJ;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7161540", Offset = "0x715FB40", VA = "0x187161540")]
	public GAJFFPKLOEG(PHGAFJJAAOB FPAJFCJDKLL, BEJKEHBAEFJ DDFGJMJMGBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71610A0", Offset = "0x715F6A0", VA = "0x1871610A0", Slot = "4")]
	public bool Equals(GAJFFPKLOEG MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7161150", Offset = "0x715F750", VA = "0x187161150", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7161280", Offset = "0x715F880", VA = "0x187161280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7161340", Offset = "0x715F940", VA = "0x187161340")]
	public static bool MMJMCICIDNJ(GAJFFPKLOEG JOOBCOFNIAM, GAJFFPKLOEG MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7160F80", Offset = "0x715F580", VA = "0x187160F80")]
	public static bool DIKHMNDIIDO(GAJFFPKLOEG JOOBCOFNIAM, GAJFFPKLOEG MCIIEEEAOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7161450", Offset = "0x715FA50", VA = "0x187161450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum PHGAFJJAAOB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IFNLPLPFJEE : HGAOMCLAJHP
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string JNDMLDCDAKC = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch FBAMPJKHFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? IILICNCIJBP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly IFNLPLPFJEE ELJDCHFNJGK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static HGAOMCLAJHP MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7162D80", Offset = "0x7161380", VA = "0x187162D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	internal static IFNLPLPFJEE JBAJDODDAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7162DD0", Offset = "0x71613D0", VA = "0x187162DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static DateTimeOffset DKGBKFFBNGE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7162E20", Offset = "0x7161420", VA = "0x187162E20")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static DateTime LJPOEDLDEHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7162F80", Offset = "0x7161580", VA = "0x187162F80")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime JDNILLIMBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7163010", Offset = "0x7161610", VA = "0x187163010", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTimeOffset IGHAHCNICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7162D20", Offset = "0x7161320", VA = "0x187162D20", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	private IFNLPLPFJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7162B00", Offset = "0x7161100", VA = "0x187162B00")]
	internal static void ALLBAHHKPDK(DateTime? LHMGHABDEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum DGMMFMEHEGC
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum LDCHEJDAADP
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[KGJMAOFDNAE]
public class EHGDCJFOLHP : NEKJHAOPALN, FBAKIBIPOMC, MHLEMOAMOMP, HADCGNIOBLA, MBIJMOAAOBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct IMLBOLJKMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public EHGDCJFOLHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x71631B0", Offset = "0x71617B0", VA = "0x1871631B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7163550", Offset = "0x7161B50", VA = "0x187163550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static ILOOKKAOHHD CBANHHDKBKB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int GNFOCGLAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD62250", Offset = "0xD60850", VA = "0x180D62250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA088F0", Offset = "0xA06EF0", VA = "0x180A088F0", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(GGBJCIFEEKL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1482A00", Offset = "0x1481000", VA = "0x181482A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool CLMMDKBAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC17800", Offset = "0xC15E00", VA = "0x180C17800", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCF1F40", Offset = "0xCF0540", VA = "0x180CF1F40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xD7B0D0", Offset = "0xD796D0", VA = "0x180D7B0D0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD799D0", Offset = "0xD77FD0", VA = "0x180D799D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PLKKACFMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E615D0", Offset = "0x1E5FBD0", VA = "0x181E615D0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1E609C0", Offset = "0x1E5EFC0", VA = "0x181E609C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x715FD40", Offset = "0x715E340", VA = "0x18715FD40", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x715FD30", Offset = "0x715E330", VA = "0x18715FD30", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string BBLNFMBBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string HJFBOJCGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xE58CD0", Offset = "0xE572D0", VA = "0x180E58CD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xE594D0", Offset = "0xE57AD0", VA = "0x180E594D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public DGMMFMEHEGC DFFMIBCOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xDAE3B0", Offset = "0xDAC9B0", VA = "0x180DAE3B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(DGMMFMEHEGC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xE94C10", Offset = "0xE93210", VA = "0x180E94C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string PLJJPGMKJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F3010", Offset = "0x9F1610", VA = "0x1809F3010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC4FF50", Offset = "0xC4E550", VA = "0x180C4FF50", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xC50250", Offset = "0xC4E850", VA = "0x180C50250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public IReadOnlyList<LLNKGMGMKMM> LCNGDBOOPGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xBEE060", Offset = "0xBEC660", VA = "0x180BEE060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x13038B0", Offset = "0x1301EB0", VA = "0x1813038B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IReadOnlyList<JOJMLIAFJPJ> KDDINMHENKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xBEE060", Offset = "0xBEC660", VA = "0x180BEE060", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public PIGJKMDEGFL MFDGEHGDJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F3040", Offset = "0x9F1640", VA = "0x1809F3040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F3050", Offset = "0x9F1650", VA = "0x1809F3050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public string HOFNFAEDOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x715F9C0", Offset = "0x715DFC0", VA = "0x18715F9C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public OILBOLBBFDD KPPMOCAOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "24")]
		get
		{
			return default(OILBOLBBFDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x715F9C0", Offset = "0x715DFC0", VA = "0x18715F9C0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool CKFBECEKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public NGFKJBKJKIN PKGBFGMFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xF74700", Offset = "0xF72D00", VA = "0x180F74700", Slot = "30")]
		get
		{
			return default(NGFKJBKJKIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string MCOPKJANMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public DKDANGFCEKG? GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x715FB90", Offset = "0x715E190", VA = "0x18715FB90", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public APCAKCGDFCO MOLJGCJNBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "33")]
		get
		{
			return default(APCAKCGDFCO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool JKHBCDJKKDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public EHGDCJFOLHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xF6A3B0", Offset = "0xF689B0", VA = "0x180F6A3B0")]
	public EHGDCJFOLHP([Optional] Guid DGPIPOJOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x715F9E0", Offset = "0x715DFE0", VA = "0x18715F9E0", Slot = "35")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x715FC60", Offset = "0x715E260", VA = "0x18715FC60", Slot = "36")]
	[AsyncStateMachine(typeof(IMLBOLJKMOA))]
	public Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x715FBE0", Offset = "0x715E1E0", VA = "0x18715FBE0")]
	public EHGDCJFOLHP JDEFNGBGNOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[KGJMAOFDNAE]
public class JHLODMJOFDG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xED4D20", Offset = "0xED3320", VA = "0x180ED4D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xED4D50", Offset = "0xED3350", VA = "0x180ED4D50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
		[CompilerGenerated]
		get
		{
			return default(GGBJCIFEEKL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xD62250", Offset = "0xD60850", VA = "0x180D62250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DGMMFMEHEGC? DFFMIBCOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B40", Offset = "0xCB0140", VA = "0x180CB1B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B90", Offset = "0xCB0190", VA = "0x180CB1B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public JHLODMJOFDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[KGJMAOFDNAE]
public class AFLEGFMKPCB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int GNFOCGLAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xED4C90", Offset = "0xED3290", VA = "0x180ED4C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xEDDBC0", Offset = "0xEDC1C0", VA = "0x180EDDBC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string BBLNFMBBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AFLEGFMKPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[KGJMAOFDNAE]
public class FNLIDBHCCBL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FNLIDBHCCBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct MLIOIHJELNO
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int BOKEFODAJKJ;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int FBLKIDGDPGA;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int MBINPGNLKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x12AC0B0", Offset = "0x12AA6B0", VA = "0x1812AC0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int NOHEMFCIIDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7165D00", Offset = "0x7164300", VA = "0x187165D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static MLIOIHJELNO OPJKGEJPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7165CB0", Offset = "0x71642B0", VA = "0x187165CB0")]
		get
		{
			return default(MLIOIHJELNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7165DA0", Offset = "0x71643A0", VA = "0x187165DA0")]
	public MLIOIHJELNO(int EIJIDJLAJNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[KGJMAOFDNAE]
public class IBNJPOOGIEA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int PNCAEHGBKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int? EIAEMBHMEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xED4C90", Offset = "0xED3290", VA = "0x180ED4C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xEDDBC0", Offset = "0xEDC1C0", VA = "0x180EDDBC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string? LNILHMKIEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7162A50", Offset = "0x7161050", VA = "0x187162A50")]
	public IBNJPOOGIEA(int GAFFJGMGEBD, int? DCIACCAIHKA, string? NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public IBNJPOOGIEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[KGJMAOFDNAE]
public class GJANAOLJBDF : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public FDJLKDLAMMF.IAAEJFMKBFM JOOIIHPJJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(FDJLKDLAMMF.IAAEJFMKBFM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string OPCCKLMJHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int? JAAEHGFDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GJANAOLJBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface JOJMLIAFJPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000074")]
	long NFJGMBPENOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Guid KJPMNOCOJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string MGDLKIILDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string AFMOJMFJELP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int CGILOPKPFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string KNFFGMHAKBD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string LJMIGGGJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string DKKKBPGIAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string IPLLECGCDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[KGJMAOFDNAE]
public class LLNKGMGMKMM : JOJMLIAFJPJ, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public long NFJGMBPENOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xDCB800", Offset = "0xDC9E00", VA = "0x180DCB800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Guid KJPMNOCOJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x12A0680", Offset = "0x129EC80", VA = "0x1812A0680", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x12A0670", Offset = "0x129EC70", VA = "0x1812A0670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string MGDLKIILDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public string AFMOJMFJELP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int CGILOPKPFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF70", Offset = "0xD2A570", VA = "0x180D2BF70", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xE82880", Offset = "0xE80E80", VA = "0x180E82880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string KNFFGMHAKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public string LJMIGGGJMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string DKKKBPGIAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string IPLLECGCDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xDAE3B0", Offset = "0xDAC9B0", VA = "0x180DAE3B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xE94C10", Offset = "0xE93210", VA = "0x180E94C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "15")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public LLNKGMGMKMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum MMHDOGHDONC
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum HLIAJHAKCLG
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
public static class JDDPGEAAJDO
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7163630", Offset = "0x7161C30", VA = "0x187163630")]
	public static int? FEFKHJNIFBA(MMHDOGHDONC? ANPMJHBKDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x71636C0", Offset = "0x7161CC0", VA = "0x1871636C0")]
	public static int? JDIGBLOCCIC(HLIAJHAKCLG? JIGDGMFFPDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[KGJMAOFDNAE]
public class PPIOEJJHFFG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int? DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public GGBJCIFEEKL? PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9EB790", Offset = "0x9E9D90", VA = "0x1809EB790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PPIOEJJHFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KGJMAOFDNAE]
public class GIPABNFHILC : EGONCOPCFDP, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public byte IFCMMFOJBML
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GIPABNFHILC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class PMPOENLHNPI
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7167300", Offset = "0x7165900", VA = "0x187167300")]
	public static HIPIMHFHIGB CJNHOABNGJJ(this GIPABNFHILC OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface NEKJHAOPALN
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	int GNFOCGLAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	bool CLMMDKBAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool PLKKACFMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	string OLCLBHJADBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	string BBLNFMBBACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string HJFBOJCGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	DGMMFMEHEGC DFFMIBCOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string PLJJPGMKJBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string HOFNFAEDOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7166230", Offset = "0x7164830", VA = "0x187166230", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MBIJMOAAOBD
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	IReadOnlyList<JOJMLIAFJPJ> KDDINMHENKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int GNFOCGLAMGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool PLKKACFMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int FCFODIKFBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	int? DDIAOPDGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DMJJPFNNOJB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct BFPNFCCADEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<HADCGNIOBLA> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x715E930", Offset = "0x715CF30", VA = "0x18715E930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x715EBD0", Offset = "0x715D1D0", VA = "0x18715EBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x715F620", Offset = "0x715DC20", VA = "0x18715F620")]
	public static bool IDOHCKEHAHL(this IEnumerable<MHLEMOAMOMP> OLEDHEBBJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x715F860", Offset = "0x715DE60", VA = "0x18715F860")]
	[AsyncStateMachine(typeof(BFPNFCCADEE))]
	public static Task NAIKLHDMABG(this IEnumerable<HADCGNIOBLA> OLEDHEBBJPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NGHKAOKDFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly string NGGJMDLHLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly string CBNMGIONGIA;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static readonly NGHKAOKDFBL APCCKFBGCNM;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0xABB7D0", Offset = "0xAB9DD0", VA = "0x180ABB7D0")]
	public NGHKAOKDFBL(string PAONAEKBGCN, string CNOOJBJPLMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0xEF3CE0", Offset = "0xEF22E0", VA = "0x180EF3CE0")]
	public bool NJNJIHOCGFM(NGHKAOKDFBL MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7166370", Offset = "0x7164970", VA = "0x187166370", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7166440", Offset = "0x7164A40", VA = "0x187166440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x71664B0", Offset = "0x7164AB0", VA = "0x1871664B0")]
	public static bool MMJMCICIDNJ(NGHKAOKDFBL JOOBCOFNIAM, NGHKAOKDFBL MCIIEEEAOOL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x71662F0", Offset = "0x71648F0", VA = "0x1871662F0")]
	public static bool DIKHMNDIIDO(NGHKAOKDFBL JOOBCOFNIAM, NGHKAOKDFBL MCIIEEEAOOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface FAIABEOMBBM
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	JKCKIBDLOBO IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string ADPLKAINAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	string GMGIIIOBJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	long JNNBINDIFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string GOPHGEBAOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string JKIKGAPMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string FPLINFGDKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string ALPGIIOOIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[KGJMAOFDNAE]
public class AEKFKLABGJK : NMDCCOHFGKK
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string OPBIIMFNBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public BNOGHPPINOH KGLBEKHHDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(BNOGHPPINOH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public GJADFEIIIAK DKAPNGMOKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
		[CompilerGenerated]
		get
		{
			return default(GJADFEIIIAK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public CCGPKJHPLDM OMJAKKKOOBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(CCGPKJHPLDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[DataMember(Name = "Header")]
	public string? CJHNOHPFJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string? GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public string? IOBNGFEIHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public List<string> JDFMABHAPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public List<ECCDOHOFADD> JGDFHHCGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x715D2D0", Offset = "0x715B8D0", VA = "0x18715D2D0", Slot = "5")]
	public override void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x715D2E0", Offset = "0x715B8E0", VA = "0x18715D2E0")]
	public AEKFKLABGJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum PGMIOGDDAOF
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
public enum BNOGHPPINOH
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum GJADFEIIIAK
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum CCGPKJHPLDM
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[KGJMAOFDNAE]
public class ECCDOHOFADD : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public PGMIOGDDAOF EMDBDINAPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(PGMIOGDDAOF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public string? AFBELPHLHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	[DataMember(Name = "LinkParameter")]
	public string? GPKCCOPICDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? FKMNPLIAMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public ECCDOHOFADD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class NMDCCOHFGKK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[IgnoreDataMember]
	public string? MLOEKADOBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void FOGENAANJJN();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7166980", Offset = "0x7164F80", VA = "0x187166980")]
	protected NMDCCOHFGKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[KGJMAOFDNAE]
public class PFDPJDEMONB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? OOAAJPONLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PFDPJDEMONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[KGJMAOFDNAE]
public class GKKPPPDDHFG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	internal static Func<string, AEKFKLABGJK>? DLPGPNHOCOG;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal static Func<string, LJKFOKNDHCE>? PGILNDIHIFD;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string? OOAAJPONLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? CCKJGJEPHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool FCCADEJJPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public KBKDLGNDCGI BPIJIKNKMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
		[CompilerGenerated]
		get
		{
			return default(KBKDLGNDCGI);
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public FFEEJALAFLP HIJHOAMJFBB
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(FFEEJALAFLP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int MHNIDGOLKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xC642E0", Offset = "0xC628E0", VA = "0x180C642E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x13C0D50", Offset = "0x13BF350", VA = "0x1813C0D50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime PFNLONAOJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB520", Offset = "0x9E9B20", VA = "0x1809EB520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[DataMember(Name = "IsRead")]
	internal bool JEKOCCGDAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xD81E20", Offset = "0xD80420", VA = "0x180D81E20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xD81E40", Offset = "0xD80440", VA = "0x180D81E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	[IgnoreDataMember]
	public bool NNMGBHEAMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xD81E30", Offset = "0xD80430", VA = "0x180D81E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xD81E50", Offset = "0xD80450", VA = "0x180D81E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NHAIEPOALMF JCJACEFDCOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA088F0", Offset = "0xA06EF0", VA = "0x180A088F0")]
		[CompilerGenerated]
		get
		{
			return default(NHAIEPOALMF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1482A00", Offset = "0x1481000", VA = "0x181482A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public MMLDAEHGKLI LDDBOPCAMLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
		[CompilerGenerated]
		get
		{
			return default(MMLDAEHGKLI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xE169A0", Offset = "0xE14FA0", VA = "0x180E169A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	internal string? KDFLLFPAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	[IgnoreDataMember]
	public AEKFKLABGJK? DENFOHKNIPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7161920", Offset = "0x715FF20", VA = "0x187161920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	[IgnoreDataMember]
	public LJKFOKNDHCE? OAOGOPJOGIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7161570", Offset = "0x715FB70", VA = "0x187161570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public NMDCCOHFGKK? FGDGIGKOGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7161600", Offset = "0x715FC00", VA = "0x187161600", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0xA156C0", Offset = "0xA13CC0", VA = "0x180A156C0")]
	public GKKPPPDDHFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[KGJMAOFDNAE]
public class IFLODLDHBJN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public BGJDLGFHCCD FJCNBDPIEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(BGJDLGFHCCD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public string CLDLCAHHBMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int BBALHJGNFKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7162AB0", Offset = "0x71610B0", VA = "0x187162AB0")]
	public IFLODLDHBJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[KGJMAOFDNAE]
public class LJKFOKNDHCE : NMDCCOHFGKK
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string FPFIMAEMPOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public string? IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public KMOOOBCFFBE AGDACFKAIAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(KMOOOBCFFBE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	[DataMember(Name = "all_conditions_required")]
	public bool MIEKHIKHLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x15962F0", Offset = "0x15948F0", VA = "0x1815962F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xF1A9E0", Offset = "0xF18FE0", VA = "0x180F1A9E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public List<IFLODLDHBJN> ABDFGJPDMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7165470", Offset = "0x7163A70", VA = "0x187165470", Slot = "5")]
	public override void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7165480", Offset = "0x7163A80", VA = "0x187165480")]
	public LJKFOKNDHCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum MMLDAEHGKLI
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum NHAIEPOALMF
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum KMOOOBCFFBE
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum BGJDLGFHCCD
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
public interface FHMCFJPHEOM
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	bool NPPPOBAOHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	NPNKPOOAOFG<GKKPPPDDHFG> AFPJKILAGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	NPNKPOOAOFG<string> BAGEFDIEJNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	NPNKPOOAOFG<GKKPPPDDHFG> KKDFOPBBGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	NPNKPOOAOFG<GKKPPPDDHFG> LEHAFEJKDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<GKKPPPDDHFG> JMFDALPLDHH(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GKKPPPDDHFG> BJKOKNLBCGI(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKKPPPDDHFG GJJDKMOHCBC(NHAIEPOALMF DHLCHOOBMKM, string BFCPMLOIACK);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GKKPPPDDHFG BKBJHMALMOI(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DOBBHKDLLNC(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JCPPOEMBOAG(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task CBCKGPMMHOP();

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task CGDCCGAINLC(GKKPPPDDHFG NAAMEAFIHJI);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface HEAKNPJEKDG
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	ONBMKFDDMAD AIEHPPFGPJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	int EHCOECBJJLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool BDDLNMFEPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool MFMCPMALIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool GPHDADNBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool PCKNODGNJOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool IEHPNMIOBAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool ENCBJNLBMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool IGOOMIHJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NOOAHJMIJKN;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KGAPFDAFEHM<JFGPKDMFMOH> IKIEICFDNGO(int BEKCOFDFFEG);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HPIGCMLNLFB LCCLHFKMFGH(DateTime IBFJLLIGGKF);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HPIGCMLNLFB NEGLFGLKDJE(string PJKIBMBJMLL);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EAFMGGFNJPD([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum PAGEBMJHNMA
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class HAKOGLGMAMH
{
	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7162010", Offset = "0x7160610", VA = "0x187162010")]
	public static string MFABOCDKDIF(this PAGEBMJHNMA ODEKBMAHGAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface DNJLPEMGFLO
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<GKKPPPDDHFG>> EPGJMHIHLEP(NHAIEPOALMF DHLCHOOBMKM);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CGDCCGAINLC(string BFCPMLOIACK);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface LHJHKPHOIPF
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IFMFNMCPIIB> JPOMFMJLHAO();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface MNMGKIJOEEF
{
	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGAPFDAFEHM<List<JLJPDCFPEAB>> IBKOBHFPMFH();

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KGAPFDAFEHM<List<JLJPDCFPEAB>> KCEKPHHGHBB();

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<JLJPDCFPEAB>> MIPGLEHNPMI([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KGAPFDAFEHM<List<JLJPDCFPEAB>> LAPNKAMACOA(List<KEEOBDBOKHK> EHENMIPFPKJ);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KGAPFDAFEHM<List<JLJPDCFPEAB>> OBOJCMFNALB(List<KEEOBDBOKHK> EHENMIPFPKJ);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface HGPCKPIAKLB
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	List<BAAIMDALMOP> DOCDGJPEJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<NPAEHGHLPDF> HCJEKNACNKK;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HPIGCMLNLFB MBLNNEACNII(BAAIMDALMOP BMIKDHDIMIN);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	KGAPFDAFEHM<BAAIMDALMOP> OHKEEGFFNKN(IPAJFKBAJFI INLEBAAACKH, IPAJFKBAJFI? LMEKGIKJNGO, bool DGJNAOKPFEG, string NAAMEAFIHJI);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KGAPFDAFEHM<BAAIMDALMOP> OHKEEGFFNKN(IPAJFKBAJFI INLEBAAACKH, string NAAMEAFIHJI);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CHBCJKEAPNK(BAAIMDALMOP GHLFOEEBLEN, bool ABLOBMJHCPI = false, bool CGIJEIBCJPJ = false, bool OELBEIDCFLI = true);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KGAPFDAFEHM<List<BAAIMDALMOP>> EOMAIKAIDKG();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface MCAJCMLHMPD
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	string HOFKIDHKOFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool KFELMJPKNCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPIGCMLNLFB LCKJDMPFFCM();

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HPIGCMLNLFB PEBPALOOLKP(string HMHABFKHOID, string LOGDAPLBFPM);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HPIGCMLNLFB MGFFLKANDMD(string LPEKAIKOLIB);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CICCKIHIBHE();

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<IFIFDHFHHIE> NGMJHJIHIGA(string PJKIBMBJMLL, string LPEKAIKOLIB, bool KDCGOMKBNKC, string KDKFAKBGOFJ, string OCLBKOCJHKH, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BBOKGIJMMDI(int BEKCOFDFFEG, string EPIGDNGDLGL, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task CDOINDIMGNB(int BEKCOFDFFEG, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task BELIGBHDAKF([Optional] PAGEBMJHNMA? PPILDELEEAF, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<KDPMHAHADHO>> PBBLGKLKHLO([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task DKNCPKGFLLP([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface HFBIPKHKMKP
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<OEICLKBONKJ>> JCJIGNIMFMA([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<DJCCPAPFEMK>> NDKEOPILOON([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface LCPHDMAJEKI
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task FGBFCHNBHLC([Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJEEFCHPPAF();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface KCBAIAGLJEB
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event AINGCLHLHDA? CFBJFFDHCDL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event AINGCLHLHDA? EPPIKDLJBCJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event AINGCLHLHDA? PDIGOOFEGHD;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<MBEOFKNNOOM> HMICJLONDHK();

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<MBEOFKNNOOM?>? GJNOLMBFPFM(int BEKCOFDFFEG);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<DBFCKDINKKA>> LPCKGHGOHBE(List<int> NCFPKCADDII);

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, MBEOFKNNOOM>> HPJAAJKKKJN();

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<MBEOFKNNOOM?>?>? ICFPAGMIHAC(int BEKCOFDFFEG);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task KHHKNHCANKF(int LKOLHBGNLLI);

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<MDPKOJIHEAN> OBDKAMODCIA(MBEOFKNNOOM IEAHLNFHDKK);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void AINGCLHLHDA(int BEKCOFDFFEG, int LKOLHBGNLLI, MBEOFKNNOOM? IEAHLNFHDKK);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface ILOOKKAOHHD : FOOACHOHIKD, JMJLBFPPABC
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Flags]
	public enum KCLECBIEILG
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	string BGKIHPJFBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	CDIGONBLHDF GMKMEHMDCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	KBKDLGNDCGI BPIJIKNKMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string PBCJMOLFCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	byte AMINPLLLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	int CGDFHMJKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	int BIHKMEFLCLD
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	bool OBCJEAHPJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	bool HODBOLBFCHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	bool EKANCJBFEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	bool EKKPBEAKGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	bool COIGKBOPLKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool GOMCNBIPLII
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool NMCJBEKDFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KGAPFDAFEHM<string> IOOBAEBBHAG();

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> FNKCELKKPLN();

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KGAPFDAFEHM<bool> IsPlayerCommunicationRestricted(int BEKCOFDFFEG);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string DAGJLAMACPP(string NFHOBPDKIPM, bool NKBMFJNILBG = true);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> HFKGMFGDANB(string NFHOBPDKIPM, bool NKBMFJNILBG = true);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "18")]
	KGAPFDAFEHM<string> MakeRoomNameAdhereToPlatformRequirements(long CINEDGEJAIA, string NFHOBPDKIPM);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string GNCPKBNDNHP, KCLECBIEILG OCMONDCMAAI = KCLECBIEILG.FilterProfanity | KCLECBIEILG.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string GNCPKBNDNHP, KCLECBIEILG OCMONDCMAAI = KCLECBIEILG.FilterProfanity | KCLECBIEILG.FilterURL, bool MAPKEPAONIM = false);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string NFHOBPDKIPM, KCLECBIEILG OCMONDCMAAI = KCLECBIEILG.FilterProfanity | KCLECBIEILG.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	KGAPFDAFEHM<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface JEDNOEGENMO
{
	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<COKEPAOCGGE>> KKMGJMFLDJK([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface GALIJNKHELC
{
	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KKEKMMDAIEK(byte[] CNOOJBJPLMK, byte[] GDKCMGFFGDG);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface PJCGDKDHENN
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CEDLDHCAFHF(string PACCIEDDEHK);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface ODJDPMOCLIM
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	NPNKPOOAOFG<PLJDCCENOPO> DCIMHGPJLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> JCDBGJCILJJ(string IMMCNGPOMNH);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<KOOBFFMABND> BOKGHGAHMCD(string IMMCNGPOMNH, string INCILAOOKDC);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task HCFFIEFIKCD(string IMMCNGPOMNH, IEnumerable<string> CDPALGEMJCK, int LLLNDHJJMGP = 0);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<BBMBJJIMEEM<FilteredTextDTO>>> HAOGMFJKHND(uint HBKAMIDNPLA, IEnumerable<string> CDPALGEMJCK);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface ANCLPPOKBID
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ONFPPKHLLJM([Out] bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHAIOCLMHEM([Out] bool OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GEBMELFDCFP([Out] int OHLIHBDBKCE);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum CJDEGHKPNCH
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum HNBABOOCKOM
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
public enum DFCIKPLNGKE
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
public enum GNDIGJJHAFN
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
public enum MHNCGGBFGKA
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
public enum EMAMJKINDIA
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
public interface JFGPKDMFMOH
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	string LLIPOLEDJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	string NJIPKMNFOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	string KEMBBHGHICP
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	string IKAANCGJELC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	string GENCAMEKGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string MEJCHGPNHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	bool GMCHEDEKECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	bool MFMGAHNBGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	DFCIKPLNGKE FAPHDPOIOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	GNDIGJJHAFN JMAAOIPNPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool? JEBMEKLCHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NLLNGFKCBNJ(bool EDGAPCIGLOE);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KADELGGOFIF(bool IFPEEGHGDJO);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface ONBMKFDDMAD : JFGPKDMFMOH
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	string BLCCOOJNOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	string MFIBCJKGBPH
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	DateTime? EIPCKGGGILG
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	CJDEGHKPNCH JJBGIHKELAG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	int? AKAJPKGFIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	int EEFMPDFFCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool EEOIPKJABFG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	bool EOBPJHAHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	bool? FDEFLLOAPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class AEFPEOMJMHM
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public JFGPKDMFMOH JEOBLJDGKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public HNBABOOCKOM OOLDDABNBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(HNBABOOCKOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public string JAPPAIFKPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5610", Offset = "0x6AF3C10", VA = "0x186AF5610")]
	public AEFPEOMJMHM(JFGPKDMFMOH CEOAPELDBLE, HNBABOOCKOM DPDADNHOKAB, string KFIEAPNKGBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface LMKECDLMKKK
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	bool KLHIKGJKBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface KNNLDGKGGMC
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	bool FIFCBHEINEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface PHMNOIEDKBE
{
	[Cpp2IlInjected.Token(Token = "0x17000117")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	string PJNBFAPMEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public enum DKDANGFCEKG
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class JLJPDCFPEAB
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public DKDANGFCEKG GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(DKDANGFCEKG);
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public string MMIOLPJIDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public NGFKJBKJKIN PKGBFGMFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(NGFKJBKJKIN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public string DHAGEEEOPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public int ILJCGCMLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xD62250", Offset = "0xD60850", VA = "0x180D62250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool FDGHDMGJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xE28200", Offset = "0xE26800", VA = "0x180E28200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xE281F0", Offset = "0xE267F0", VA = "0x180E281F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public KEEOBDBOKHK GOMMIAFJHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x129C6A0", Offset = "0x129ACA0", VA = "0x18129C6A0")]
		[CompilerGenerated]
		get
		{
			return default(KEEOBDBOKHK);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7163DE0", Offset = "0x71623E0", VA = "0x187163DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public ODFBDNOADGM CDJDBMFGDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x193FCB0", Offset = "0x193E2B0", VA = "0x18193FCB0")]
		[CompilerGenerated]
		get
		{
			return default(ODFBDNOADGM);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x641C6C0", Offset = "0x641ACC0", VA = "0x18641C6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string NMHEGGBKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x9F3010", Offset = "0x9F1610", VA = "0x1809F3010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x67F7FB0", Offset = "0x67F65B0", VA = "0x1867F7FB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x7163F40", Offset = "0x7162540", VA = "0x187163F40")]
	internal JLJPDCFPEAB(JGHCOLCIHBH DFKPMMPAOIH, NGJIPCEJOIB KIIDBFFMGDI, POAKPCMKJOA ABPDFJDNHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x7163E00", Offset = "0x7162400", VA = "0x187163E00")]
	public JLJPDCFPEAB(DKDANGFCEKG IOPNLAOPFJE = DKDANGFCEKG.Outfit, [Optional] KEEOBDBOKHK PFACNPFKJLB, [Optional] string OMCLCFINMNI, [Optional] string LAADEINHGNK, NGFKJBKJKIN NFFLJBGMIFL = NGFKJBKJKIN.Common, [Optional] string LNDEEENNHEG, int MONOBEAOLBH = 0, bool MKJJHAEABJC = false, [Optional] string KKGBCDKONEC, [Optional] DateTime? IPOPOEOJDBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[KGJMAOFDNAE]
public class JGHCOLCIHBH : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public DKDANGFCEKG GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(DKDANGFCEKG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	[DataMember(Name = "AvatarItemDesc")]
	public string IONOIHBEKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string MMIOLPJIDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public NGFKJBKJKIN PKGBFGMFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430")]
		[CompilerGenerated]
		get
		{
			return default(NGFKJBKJKIN);
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EEE00", VA = "0x1809F0800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public string DHAGEEEOPOM
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public int ILJCGCMLCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xE169A0", Offset = "0xE14FA0", VA = "0x180E169A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool FDGHDMGJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1680F00", Offset = "0x167F500", VA = "0x181680F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x168CC80", Offset = "0x168B280", VA = "0x18168CC80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string JFAANGGIFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xE281D0", Offset = "0xE267D0", VA = "0x180E281D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public JGHCOLCIHBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[KGJMAOFDNAE]
public sealed class LFMHPJKHHOI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public List<string> FHIBKJDFFNO
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x71653E0", Offset = "0x71639E0", VA = "0x1871653E0")]
	public LFMHPJKHHOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public LFMHPJKHHOI(List<string> EHENMIPFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[KGJMAOFDNAE]
public class IFMFNMCPIIB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public OBPDLECDCNE OBJIPBLANCI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public HKINNEJNOLG IOLPOANDKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public IFMFNMCPIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public IFMFNMCPIIB(OBPDLECDCNE GJEIAMFFDBB, HKINNEJNOLG JEMEJLOOADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum BOCJAADNIKD
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum DDKOGNJJHEL : byte
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
[KGJMAOFDNAE]
public class OBPDLECDCNE : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public BOCJAADNIKD NCFILFHNEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(BOCJAADNIKD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public DDKOGNJJHEL? IOHILMJJLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x2DEEA30", Offset = "0x2DED030", VA = "0x182DEEA30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6FEFB90", Offset = "0x6FEE190", VA = "0x186FEFB90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool DBPFJCPGBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F9E0", Offset = "0x1D5DFE0", VA = "0x181D5F9E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F880", Offset = "0x1D5DE80", VA = "0x181D5F880")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7166A60", Offset = "0x7165060", VA = "0x187166A60")]
	public OBPDLECDCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x7166A70", Offset = "0x7165070", VA = "0x187166A70")]
	public OBPDLECDCNE(BOCJAADNIKD GECANHIHOBF, DDKOGNJJHEL LPNNMFBNEPK, bool DJHOKCFODCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KGJMAOFDNAE]
public class HKINNEJNOLG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public string GAEKNFLPFNI
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public string GDNJCPHFFME
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HKINNEJNOLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public HKINNEJNOLG(string FHAABJIJMKK, string LNOPMAJCJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum CDIGONBLHDF
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
public struct NPAEHGHLPDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public BAAIMDALMOP MJPJCLIEJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool FNPMLGMPJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public bool ECDILLNGBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool ONFOJANOANO;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[KGJMAOFDNAE]
public class BAAIMDALMOP : HADCGNIOBLA, MHLEMOAMOMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct ELEIAJKDLNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public BAAIMDALMOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x715FD80", Offset = "0x715E380", VA = "0x18715FD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x715FF10", Offset = "0x715E510", VA = "0x18715FF10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal static Action<BAAIMDALMOP> OIFBLKPKOGE;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal static Func<BAAIMDALMOP, Task> EFOFCHAKHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[IgnoreDataMember]
	public bool GEEBJGIMIDG;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public long? OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public int AGOECKHDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public int? BNBDOOOIPND
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xED4D20", Offset = "0xED3320", VA = "0x180ED4D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xED4D50", Offset = "0xED3350", VA = "0x180ED4D50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public string MCOPKJANMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public DKDANGFCEKG? GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	[DataMember(Name = "AvatarItemDesc")]
	public string PKLEIEIGDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Guid? BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x715DEF0", Offset = "0x715C4F0", VA = "0x18715DEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x715DEE0", Offset = "0x715C4E0", VA = "0x18715DEE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public string BFFDHJKHCAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public string NEHLIKDHFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA12060", Offset = "0xA10660", VA = "0x180A12060")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x131BED0", Offset = "0x131A4D0", VA = "0x18131BED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public int FIPPELPIBNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA120C0", Offset = "0xA106C0", VA = "0x180A120C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x131BEB0", Offset = "0x131A4B0", VA = "0x18131BEB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public int ICJCBNEJBLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xDAE3B0", Offset = "0xDAC9B0", VA = "0x180DAE3B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xE94C10", Offset = "0xE93210", VA = "0x180E94C10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public IPAJFKBAJFI PNEKJCEICLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xE3C7E0", Offset = "0xE3ADE0", VA = "0x180E3C7E0")]
		[CompilerGenerated]
		get
		{
			return default(IPAJFKBAJFI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x135F8F0", Offset = "0x135DEF0", VA = "0x18135F8F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public NGFKJBKJKIN DKHJLBKCGGC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xC0E380", Offset = "0xC0C980", VA = "0x180C0E380")]
		[CompilerGenerated]
		get
		{
			return default(NGFKJBKJKIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x13321C0", Offset = "0x13307C0", VA = "0x1813321C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	[DataMember(Name = "Message")]
	public string KBOHHPHOMBM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FF0", Offset = "0x9F15F0", VA = "0x1809F2FF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public string JGOGPEGPAFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xBEE060", Offset = "0xBEC660", VA = "0x180BEE060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x13038B0", Offset = "0x1301EB0", VA = "0x1813038B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool GNCDAKMMHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xE28510", Offset = "0xE26B10", VA = "0x180E28510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xE28810", Offset = "0xE26E10", VA = "0x180E28810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public KBKDLGNDCGI BPIJIKNKMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xDB9610", Offset = "0xDB7C10", VA = "0x180DB9610")]
		[CompilerGenerated]
		get
		{
			return default(KBKDLGNDCGI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xDB6CB0", Offset = "0xDB52B0", VA = "0x180DB6CB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public FFEEJALAFLP EBCADCJGKAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F3170", Offset = "0x9F1770", VA = "0x1809F3170")]
		[CompilerGenerated]
		get
		{
			return default(FFEEJALAFLP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F30E0", Offset = "0x9F16E0", VA = "0x1809F30E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public ENBJEHKMOJF? FOCHGGKBCJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x715DE80", Offset = "0x715C480", VA = "0x18715DE80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x715DE90", Offset = "0x715C490", VA = "0x18715DE90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool EGJOMEIGCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x715DDB0", Offset = "0x715C3B0", VA = "0x18715DDB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool PBOGAIHILKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x715DEA0", Offset = "0x715C4A0", VA = "0x18715DEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool EIEJHGCIALK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x715DEC0", Offset = "0x715C4C0", VA = "0x18715DEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	[IgnoreDataMember]
	public bool AKBMEBLPHON
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4B0", Offset = "0x9EDAB0", VA = "0x1809EF4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4F0", Offset = "0x9EDAF0", VA = "0x1809EF4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	[IgnoreDataMember]
	public bool LKIDIFGHMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE370", Offset = "0x2ADC970", VA = "0x182ADE370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x2ADE360", Offset = "0x2ADC960", VA = "0x182ADE360")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	[IgnoreDataMember]
	public string KGOINKIPJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xD65080", Offset = "0xD63680", VA = "0x180D65080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xE6ABC0", Offset = "0xE691C0", VA = "0x180E6ABC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	[IgnoreDataMember]
	public string OGIHIEGMJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xD49D80", Offset = "0xD48380", VA = "0x180D49D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xD49D90", Offset = "0xD48390", VA = "0x180D49D90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	[IgnoreDataMember]
	public bool BJIBDABGNND
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xF46350", Offset = "0xF44950", VA = "0x180F46350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xBD80F0", Offset = "0xBD66F0", VA = "0x180BD80F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x715DE20", Offset = "0x715C420", VA = "0x18715DE20", Slot = "5")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x715DF10", Offset = "0x715C510", VA = "0x18715DF10", Slot = "6")]
	[AsyncStateMachine(typeof(ELEIAJKDLNH))]
	public virtual Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x135F8F0", Offset = "0x135DEF0", VA = "0x18135F8F0")]
	public void CIKDEECJNBF(IPAJFKBAJFI INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public BAAIMDALMOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface BBOPBAIMAHN
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	long MFGIGBBNBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	string ENLDADCHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	int LMMOJLGOGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	string JMBIKEHOJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	byte MDGICHBHHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	int HDJPHOGLDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	int MJJNKLAINMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	bool CLMMDKBAGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	DateTime? HDEEMKMNJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	long? EJAEPDAPGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	int OAADMGABLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	int BGBHODMEGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	int IMIEBPOCLHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	IJNDBPBABID KABEGOJOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	IJNDBPBABID AOCHFLKEHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	bool CPBKJAIMBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	bool JJBLAKOPNEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	bool PLKKACFMMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	bool LFKKFPCPPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	int? DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool EKDHIHGBFDM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	string LFBIPPGCJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PMFMMFNCOHI();

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OOGMFHOHBIL();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[KGJMAOFDNAE]
public class BEKBAAJDHFF : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public List<APPNANGFABC> NEGJPANFFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x715E6F0", Offset = "0x715CCF0", VA = "0x18715E6F0")]
	public List<string> NLLADEKCHPI(params OAPMNGPFEMF[] IKDGFDAFKMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x715E8B0", Offset = "0x715CEB0", VA = "0x18715E8B0")]
	public List<string> PIANKCJJDPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x715E5B0", Offset = "0x715CBB0", VA = "0x18715E5B0")]
	public List<string> CEIELPIPMOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x715E600", Offset = "0x715CC00", VA = "0x18715E600", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public BEKBAAJDHFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[KGJMAOFDNAE]
public class FJFADKEHNHB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int LMMOJLGOGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FJFADKEHNHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[KGJMAOFDNAE]
public class MCKOHDKGJNJ : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public long MFGIGBBNBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public string ENLDADCHJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int OPDMJMAFFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool GIOEBEDIGKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xD1ED00", Offset = "0xD1D300", VA = "0x180D1ED00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xD1E310", Offset = "0xD1C910", VA = "0x180D1E310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int NNGDNFLIKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public int BBGGIBAEDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xC642E0", Offset = "0xC628E0", VA = "0x180C642E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x13C0D50", Offset = "0x13BF350", VA = "0x1813C0D50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int KOGOGLKDFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EEE00", VA = "0x1809F0800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int JKJEGDOOHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA2AD90", Offset = "0xA29390", VA = "0x180A2AD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA29ED0", Offset = "0xA284D0", VA = "0x180A29ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public string JBFBNODCJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public string CDIHJLGPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x6EA02A0", Offset = "0x6E9E8A0", VA = "0x186EA02A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public GGBJCIFEEKL? NAEMFACIBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xE281D0", Offset = "0xE267D0", VA = "0x180E281D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public IReadOnlyList<Guid> GCHOGJDJOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public NGHKAOKDFBL HJONKKMKMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x7165B60", Offset = "0x7164160", VA = "0x187165B60")]
		get
		{
			return default(NGHKAOKDFBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x71658E0", Offset = "0x7163EE0", VA = "0x1871658E0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x7165970", Offset = "0x7163F70", VA = "0x187165970")]
	public bool NJNJIHOCGFM(MCKOHDKGJNJ IFMEGLHJPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x7165980", Offset = "0x7163F80", VA = "0x187165980")]
	private bool OEJBCLEHKDL(MCKOHDKGJNJ IFMEGLHJPDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x7165840", Offset = "0x7163E40", VA = "0x187165840")]
	private static bool ACPBNGPHPOO(IReadOnlyList<Guid> HFGDJHPPLMD, IReadOnlyList<Guid> CPGDAONACLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x278D6F0", Offset = "0x278BCF0", VA = "0x18278D6F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MCKOHDKGJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[KGJMAOFDNAE]
public class INGDBPKOLAP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public int GKIGMCHANCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public INGDBPKOLAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[KGJMAOFDNAE]
public class NNGKJHFPNFO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public bool PFFJKLLLFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public NNGKJHFPNFO()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[KGJMAOFDNAE]
	public class NewInventionRequestDTO : MHLEMOAMOMP
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
		public PFBDGKHFNEC creatorAccountRole;

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

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0xEADE30", Offset = "0xEAC430", VA = "0x180EADE30", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x71669D0", Offset = "0x7164FD0", VA = "0x1871669D0")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[KGJMAOFDNAE]
	public class AddVersionInventionRequestDTO : MHLEMOAMOMP
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

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xEADE30", Offset = "0xEAC430", VA = "0x180EADE30", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x715DDA0", Offset = "0x715C3A0", VA = "0x18715DDA0")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[KGJMAOFDNAE]
	public class ModifyTagsRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[KGJMAOFDNAE]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[KGJMAOFDNAE]
	public class ReportRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public MBNLFGINNEI ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[KGJMAOFDNAE]
	public class CheerRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[KGJMAOFDNAE]
	public class UpdatePriceRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[KGJMAOFDNAE]
	public class UpdateInventionMetadataRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xEADE30", Offset = "0xEAC430", VA = "0x180EADE30", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[KGJMAOFDNAE]
	public class UpdateInventionGeneralPermissionRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public IJNDBPBABID Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(IJNDBPBABID);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[KGJMAOFDNAE]
	public class PublishInventionRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public IJNDBPBABID Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(IJNDBPBABID);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public GGBJCIFEEKL Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10")]
			[CompilerGenerated]
			get
			{
				return default(GGBJCIFEEKL);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD65620", VA = "0x180D67020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[KGJMAOFDNAE]
	public class UnpublishInventionRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[KGJMAOFDNAE]
	public class DeleteInventionRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[KGJMAOFDNAE]
	public class SetInventionVersionAccessibilityRequest : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public GGBJCIFEEKL NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10")]
			[CompilerGenerated]
			get
			{
				return default(GGBJCIFEEKL);
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD65620", VA = "0x180D67020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[KGJMAOFDNAE]
	public class SpecialTags : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum ONBJAEBDEPH
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
public enum MBNLFGINNEI
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
public enum NJKKDIBNBAF
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	True,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface KDPMHAHADHO
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	KBKDLGNDCGI BPIJIKNKMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	string PBCJMOLFCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	DateTime ACDJGGIIDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	bool FNDEDJAFKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	string JDOHLKKDJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	JFGPKDMFMOH JEOBLJDGKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FOGENAANJJN();

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PMNHBGKMAPL(JFGPKDMFMOH CEOAPELDBLE);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface FCILJAKDADM
{
	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	int JPLLFCIDPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool FAPAOCIAFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOGENAANJJN();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct IFIFDHFHHIE
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public NEEFMAAKKAO CKMENNJIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA36AF0", Offset = "0xA350F0", VA = "0x180A36AF0")]
		[CompilerGenerated]
		readonly get
		{
			return default(NEEFMAAKKAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x12AC0B0", Offset = "0x12AA6B0", VA = "0x1812AC0B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public FCILJAKDADM MOFEEBEHCAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0xD8EFF0", Offset = "0xD8D5F0", VA = "0x180D8EFF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public string PHGPDMJKCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x1605870", Offset = "0x1603E70", VA = "0x181605870")]
	public IFIFDHFHHIE(NEEFMAAKKAO PJPCILIKLGM, [Optional] FCILJAKDADM GHGFGLNBOCD, [Optional] string OCLBKOCJHKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public enum NEEFMAAKKAO
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
[KGJMAOFDNAE]
public class OEICLKBONKJ : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public string DCILLECPBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public string MJOFILIHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public string HODBMJAFBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public string HGCCICIMLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public List<OEJNELGLGIK> OIFBNNEBFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OEICLKBONKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x48DF790", Offset = "0x48DDD90", VA = "0x1848DF790")]
	public OEICLKBONKJ([Optional] string MFJEOAKPFFI, [Optional] string AHENDINOEMN, [Optional] string MBGHKIHGPGO, [Optional] string DGJKDOBDAIK, [Optional] List<OEJNELGLGIK> IBHKIAHKKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[KGJMAOFDNAE]
public class OEJNELGLGIK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string FPLINFGDKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string HGCCICIMLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OEJNELGLGIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[KGJMAOFDNAE]
public class DJCCPAPFEMK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string MJOFILIHFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string CKMENNJIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public string DCILLECPBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public List<string> IMHDCLDLHDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public DJCCPAPFEMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[KGJMAOFDNAE]
public interface MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOGENAANJJN();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[KGJMAOFDNAE]
public interface HADCGNIOBLA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PGKHKEHPKKI();
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[HKHKLFECEBO]
public interface EGONCOPCFDP : MHLEMOAMOMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[KGJMAOFDNAE]
public class HIPIMHFHIGB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public int IFCMMFOJBML
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string BJKMDIGACOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public string AFMOJMFJELP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HIPIMHFHIGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x7162260", Offset = "0x7160860", VA = "0x187162260")]
	public HIPIMHFHIGB([Optional] Guid DGPIPOJOJGM, int BDNPFHIBMNH = 0, [Optional] string ICBGIMNNDLE, [Optional] string FDAEHOMAPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[KGJMAOFDNAE]
public class MBEOFKNNOOM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public const int IIKPDFKIFLL = 0;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public long PFCGKIECHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public EIMFOIMANHI HMIEIKHLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public string ILNMKENBOBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public List<HIPIMHFHIGB> BHFEMJNMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public int KACOMNMFMMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EEE00", VA = "0x1809F0800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public GGBJCIFEEKL PEDJKOGJKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
		[CompilerGenerated]
		get
		{
			return default(GGBJCIFEEKL);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xE169A0", Offset = "0xE14FA0", VA = "0x180E169A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public string MGDLKIILDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public bool LDFILLBMMEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1DE6350", Offset = "0x1DE4950", VA = "0x181DE6350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x7165690", Offset = "0x7163C90", VA = "0x187165690")]
	public MBEOFKNNOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x7165720", Offset = "0x7163D20", VA = "0x187165720")]
	public MBEOFKNNOOM(long LDDIFOMLAII = 0L, [Optional] EIMFOIMANHI OGPLBHCJHNM, [Optional] string DAMLLFNDABK, [Optional] List<HIPIMHFHIGB> CBOLBPFMLPH, int LKOLHBGNLLI = 0, [Optional] string NFHOBPDKIPM, GGBJCIFEEKL MPCIGGLFCOI = GGBJCIFEEKL.Private, [Optional] string FKOLFGDCNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class DBFCKDINKKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly int COMMLBDCOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public readonly MBEOFKNNOOM HDCILAIAACI;

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xEBEA90", Offset = "0xEBD090", VA = "0x180EBEA90")]
	public DBFCKDINKKA(int BEKCOFDFFEG, MBEOFKNNOOM IEAHLNFHDKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[KGJMAOFDNAE]
public class EIMFOIMANHI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public string CBPJJLJOIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string FMLBNLNKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public string NOGLCKDLIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string HBBFGFAMEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public string PBAANIFKDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public string BHFEMJNMGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x715FD50", Offset = "0x715E350", VA = "0x18715FD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public EIMFOIMANHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x48DF790", Offset = "0x48DDD90", VA = "0x1848DF790")]
	public EIMFOIMANHI([Optional] string BGDJGEILILH, [Optional] string BJDJCACPIDH, [Optional] string EAMKCDPGGCO, [Optional] string HOKBFOFIGDG, [Optional] string FAOPFFICEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[KGJMAOFDNAE]
public class NPHEIDGBBMN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public Dictionary<int, MBEOFKNNOOM> KJPGIMEDGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public NPHEIDGBBMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[KGJMAOFDNAE]
public class LPOJDIBHIKJ : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public List<int> PGKOLIKCAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public byte? AMINPLLLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x2DF77B0", Offset = "0x2DF5DB0", VA = "0x182DF77B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2DF77C0", Offset = "0x2DF5DC0", VA = "0x182DF77C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public int? CGDFHMJKGNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xED4D10", Offset = "0xED3310", VA = "0x180ED4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xED4D40", Offset = "0xED3340", VA = "0x180ED4D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public LPOJDIBHIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class DJMNNKNLABB
{
	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x715F5B0", Offset = "0x715DBB0", VA = "0x18715F5B0")]
	public static GIPABNFHILC OAMAOGBKNOB(this HIPIMHFHIGB OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
public enum FFEEJALAFLP
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
public enum KBKDLGNDCGI
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
[KGJMAOFDNAE]
public class LDIOKDFMNKL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	[DataMember(Name = "PlayerId")]
	public int COMMLBDCOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public int HOAMCOAEJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0xC5E800", Offset = "0xC5CE00", VA = "0x180C5E800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public int LNKNENKHMKG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public LDIOKDFMNKL()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[KGJMAOFDNAE]
	public class ProgressionEventRecordDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public int COMMLBDCOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public int ICJCBNEJBLP
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xC5E800", Offset = "0xC5CE00", VA = "0x180C5E800")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public int KIKOKOPPJBI
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public int FEKHCMFEDAD
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD65620", VA = "0x180D67020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public int ABLIJMBICFO
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public DateTime? HFHNAHPIKAL
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x12A0680", Offset = "0x129EC80", VA = "0x1812A0680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x12A0670", Offset = "0x129EC70", VA = "0x1812A0670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7167470", Offset = "0x7165A70", VA = "0x187167470")]
		public ProgressionEventRecordDTO(int BEKCOFDFFEG = 0, int DDMGJKPNDFD = 0, int LHAJDKCPLHI = 0, int LAKMGFPAABD = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[KGJMAOFDNAE]
	public class ProgressionEventDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public long HBGELNIFCPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public List<ProgressionEventRewardDTO> PBPOCFNBPIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public List<KeepsakeRoomListDTO> BKIIEGNHKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public DateTime NLFLOIODJFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x9EB520", Offset = "0x9E9B20", VA = "0x1809EB520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public DateTime FNNFCOOJGKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public DateTime DGGIIDCFBNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xE28760", Offset = "0xE26D60", VA = "0x180E28760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public bool NAFNNCHOEDO
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xC177F0", Offset = "0xC15DF0", VA = "0x180C177F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xC4C130", Offset = "0xC4A730", VA = "0x180C4C130")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public int IEPDJJFPEEN
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x1372530", Offset = "0x1370B30", VA = "0x181372530")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x1FF3920", Offset = "0x1FF1F20", VA = "0x181FF3920")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public float BBFBKMDEGHL
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x10BFCF0", Offset = "0x10BE2F0", VA = "0x1810BFCF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x136B320", Offset = "0x1369920", VA = "0x18136B320")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public Guid? BLGPJMCGJNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x71673A0", Offset = "0x71659A0", VA = "0x1871673A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x7167390", Offset = "0x7165990", VA = "0x187167390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public string MLDBMKBIFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public string NLCILMFNBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public string OIAGEAAMPBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x9F3080", Offset = "0x9F1680", VA = "0x1809F3080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public string BBDAKEBLNKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x9F3010", Offset = "0x9F1610", VA = "0x1809F3010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x71673C0", Offset = "0x71659C0", VA = "0x1871673C0")]
		public ProgressionEventDTO(long FMIBHJAGMML = 0L, [Optional] string NFHOBPDKIPM, [Optional] List<ProgressionEventRewardDTO> GNAJKFJECJL, [Optional] List<KeepsakeRoomListDTO> AALCIFBIFJE, [Optional] DateTime OMDABEJMMKM, [Optional] DateTime MKDGBOGGCJD, [Optional] DateTime ABHKGEFJGGA, bool KPBKEAAFJEO = false, int HHEGDLMGOAK = 0, float AHJBKKPEIIG = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[KGJMAOFDNAE]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public long LLLHIPOOHBI
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public long HBGELNIFCPB
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public int? FMMNJGCCFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public int? LHALKDENJDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x9EB790", Offset = "0x9E9D90", VA = "0x1809EB790")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public long? LPEOMNBLDNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xDCD450", Offset = "0xDCBA50", VA = "0x180DCD450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xDCCC90", Offset = "0xDCB290", VA = "0x180DCCC90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public long MAGNPGIJPCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xE28760", Offset = "0xE26D60", VA = "0x180E28760")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public TimeSpan JAGNLJJIGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x7164510", Offset = "0x7162B10", VA = "0x187164510")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public long ILIANAOHKLF
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x6EA02A0", Offset = "0x6E9E8A0", VA = "0x186EA02A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public TimeSpan JFGFEPPAJAG
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x71644C0", Offset = "0x7162AC0", VA = "0x1871644C0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public int ELOIBOHABIB
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xD2BF70", Offset = "0xD2A570", VA = "0x180D2BF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xE82880", Offset = "0xE80E80", VA = "0x180E82880")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public MCEBFBBCOHL CGNNPKJMGFE
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x1132560", Offset = "0x1130B60", VA = "0x181132560")]
			[CompilerGenerated]
			get
			{
				return default(MCEBFBBCOHL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x2182810", Offset = "0x2180E10", VA = "0x182182810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public List<KeepsakeRoomDTO> APCPCHANDPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7164560", Offset = "0x7162B60", VA = "0x187164560")]
		public KeepsakeRoomListDTO(long LEFNFFBHJLH = 0L, long FMIBHJAGMML = 0L, [Optional] int? OAGAPIGKNKI, [Optional] int? JHKCMKCCJJA, [Optional] long? HOLFNHCGGDA, long KKLHCCKEPGO = 0L, long HLGCLOKKIID = 0L, int OFPBFFCPAKA = 0, MCEBFBBCOHL COMHFDPJFFN = MCEBFBBCOHL.Standard, [Optional] List<KeepsakeRoomDTO> EDKLNJCHBGM)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[KGJMAOFDNAE]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public long IPFOGPLCAOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public long BJFFDFGEMMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public long LLLHIPOOHBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public MCEBFBBCOHL KFIKOGBAHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
			[CompilerGenerated]
			get
			{
				return default(MCEBFBBCOHL);
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public int JOMGBPGGHFM
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xC642E0", Offset = "0xC628E0", VA = "0x180C642E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x13C0D50", Offset = "0x13BF350", VA = "0x1813C0D50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x7164460", Offset = "0x7162A60", VA = "0x187164460")]
		public KeepsakeRoomDTO(long NOPNHMAKDDC = 0L, long CINEDGEJAIA = 0L, long LEFNFFBHJLH = 0L, MCEBFBBCOHL MLCOGCMJLBB = MCEBFBBCOHL.Standard, int PFCGPNCOPEG = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[KGJMAOFDNAE]
	public class ProgressionEventRewardDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public long EENFEJAOJBD
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public int DIPFACLGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public string PNHKFKCEKNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public int ICJCBNEJBLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public int MPDBNBMBOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xC642E0", Offset = "0xC628E0", VA = "0x180C642E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x13C0D50", Offset = "0x13BF350", VA = "0x1813C0D50")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public bool MMJEBPBIAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[KGJMAOFDNAE]
	public class ProgressionEventPurchasableXpBoostDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public Guid CBMLOHFODLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public int ANJOOKPGOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public int FEDCHNAEDNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public int NLHBIOGCFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public long IJOMAFIGBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x9EB520", Offset = "0x9E9B20", VA = "0x1809EB520")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public long CLLFNALMCDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum MCEBFBBCOHL
{
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum AFACIFHCNFE
{
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[KGJMAOFDNAE]
public class COKEPAOCGGE : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	public string NGGJMDLHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	public string? CBNMGIONGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public COKEPAOCGGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface JNFBFBMIKLM
{
	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	bool JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	string? FMNIANNOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	string? BGEBLMBMMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface PADGCDDPPLM<T> : JNFBFBMIKLM
{
	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class DEPGPLOBNFG
{
	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x36B26B0", Offset = "0x36B0CB0", VA = "0x1836B26B0")]
	public static PADGCDDPPLM<T> IOFGLPCMIME<T, U>(this PADGCDDPPLM<U> OBOOAPELMPF, Func<U, T> JFBCMFKBFGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct NPMGGJIHKDI<T> : PADGCDDPPLM<T>, JNFBFBMIKLM
{
	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	public bool JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xF3E440", Offset = "0xF3CA40", VA = "0x180F3E440", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x29A9300", Offset = "0x29A7900", VA = "0x1829A9300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	public string? FMNIANNOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0xD8EFF0", Offset = "0xD8D5F0", VA = "0x180D8EFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public string? BGEBLMBMMJF
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x5426620", Offset = "0x5424C20", VA = "0x185426620")]
	public static NPMGGJIHKDI<T> IIJKJPIHGDF(T OHLIHBDBKCE)
	{
		return default(NPMGGJIHKDI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5426560", Offset = "0x5424B60", VA = "0x185426560")]
	public static NPMGGJIHKDI<T> ANFNACBHEOD(string JHEMEKBLBHP, string DOCGHMMILII = "")
	{
		return default(NPMGGJIHKDI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[KGJMAOFDNAE]
public class MDPKOJIHEAN : JNFBFBMIKLM, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000201")]
	public bool JPLAKFPJJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	public string? FMNIANNOKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000203")]
	[DataMember(Name = "error_id")]
	public string? BGEBLMBMMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
	public virtual void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x7165C40", Offset = "0x7164240", VA = "0x187165C40")]
	public static MDPKOJIHEAN IIJKJPIHGDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x7165BB0", Offset = "0x71641B0", VA = "0x187165BB0")]
	public static MDPKOJIHEAN ANFNACBHEOD(string JHEMEKBLBHP, string DOCGHMMILII = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MDPKOJIHEAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[NHFDOLIJPLM]
public abstract class OKKDFMAGFDP<T> : MDPKOJIHEAN, PADGCDDPPLM<T>, JNFBFBMIKLM
{
	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
	protected OKKDFMAGFDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[NHFDOLIJPLM]
public class LPHNAEFEAEB<T> : OKKDFMAGFDP<T>
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x5164D60", Offset = "0x5163360", VA = "0x185164D60")]
	private static void CLNMLGKPBBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x44C62B0", Offset = "0x44C48B0", VA = "0x1844C62B0")]
	public LPHNAEFEAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[NHFDOLIJPLM]
public class BBMBJJIMEEM<T> : OKKDFMAGFDP<T>, HADCGNIOBLA, MHLEMOAMOMP where T : MHLEMOAMOMP, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct KOGACFDPKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public BBMBJJIMEEM<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x501FF60", Offset = "0x501E560", VA = "0x18501FF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x50201E0", Offset = "0x501E7E0", VA = "0x1850201E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6140100", Offset = "0x613E700", VA = "0x186140100", Slot = "8")]
	public override void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x61402F0", Offset = "0x613E8F0", VA = "0x1861402F0", Slot = "10")]
	[AsyncStateMachine(typeof(BBMBJJIMEEM<>.KOGACFDPKGH))]
	public Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6140190", Offset = "0x613E790", VA = "0x186140190")]
	public static BBMBJJIMEEM<T> IIJKJPIHGDF(T OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x613FFB0", Offset = "0x613E5B0", VA = "0x18613FFB0")]
	public new static BBMBJJIMEEM<T> ANFNACBHEOD(string JHEMEKBLBHP, string DOCGHMMILII = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x44F6890", Offset = "0x44F4E90", VA = "0x1844F6890")]
	public BBMBJJIMEEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[NHFDOLIJPLM]
public class GOGPAKPFOPC<T> : OKKDFMAGFDP<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x44C62B0", Offset = "0x44C48B0", VA = "0x1844C62B0")]
	public GOGPAKPFOPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[NHFDOLIJPLM]
public class DEGJCEGDGEL<T> : OKKDFMAGFDP<List<T>>, HADCGNIOBLA, MHLEMOAMOMP where T : MHLEMOAMOMP, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct PGFCIELCIJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public DEGJCEGDGEL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x56174B0", Offset = "0x5615AB0", VA = "0x1856174B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x56176C0", Offset = "0x5615CC0", VA = "0x1856176C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x6A381A0", Offset = "0x6A367A0", VA = "0x186A381A0")]
	public static DEGJCEGDGEL<T> IIJKJPIHGDF(List<T> OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x6A37DE0", Offset = "0x6A363E0", VA = "0x186A37DE0")]
	public new static DEGJCEGDGEL<T> ANFNACBHEOD(string JHEMEKBLBHP, string DOCGHMMILII = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x6A37F30", Offset = "0x6A36530", VA = "0x186A37F30", Slot = "8")]
	public override void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x6A382E0", Offset = "0x6A368E0", VA = "0x186A382E0", Slot = "10")]
	[AsyncStateMachine(typeof(DEGJCEGDGEL<>.PGFCIELCIJE))]
	public Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x4F17A00", Offset = "0x4F16000", VA = "0x184F17A00")]
	public DEGJCEGDGEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum MLOJOBKDNHB
{
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class COFANCKLEAH
{
	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x715F590", Offset = "0x715DB90", VA = "0x18715F590")]
	public static bool CHGOOKFABIO(this MLOJOBKDNHB BEGHPONNAEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x715F590", Offset = "0x715DB90", VA = "0x18715F590")]
	public static bool HGLIDLKOCON(this MLOJOBKDNHB BEGHPONNAEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum COAFHABICNE
{
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	ProgressionEvent = 400
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum ENBJEHKMOJF
{
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	NonPurchasedEarnedByP2Pv2 = 1001
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum IPAJFKBAJFI
{
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum NGFKJBKJKIN
{
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum LNDBPNALOAJ
{
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[KGJMAOFDNAE]
	public class BalanceResponseDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		public COAFHABICNE CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(COAFHABICNE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		[DataMember(Name = "Platform")]
		public ENBJEHKMOJF BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10")]
			[CompilerGenerated]
			get
			{
				return default(ENBJEHKMOJF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD65620", VA = "0x180D67020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public virtual void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[KGJMAOFDNAE]
	public class FilteredTextDTO : MHLEMOAMOMP
	{
		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public string KNHBLAEFJHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		public int AMIMCOABLJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
		public void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[KGJMAOFDNAE]
public class DBFOCDHPDNL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public string ADNBFJBNKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	public string AKHCLEMCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public DBFOCDHPDNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[KGJMAOFDNAE]
public class KOOBFFMABND : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	public List<DBFOCDHPDNL> LJHHLMOEBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KOOBFFMABND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[KGJMAOFDNAE]
public class CCIKHOCIHFN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	public string FECNNIONHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public CCIKHOCIHFN(string PCGODPPEEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[KGJMAOFDNAE]
public class KFPCNBPFNEI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public List<DBFOCDHPDNL> LJHHLMOEBHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KFPCNBPFNEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[KGJMAOFDNAE]
public class FPBIDMIFHHI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	public List<CCIKHOCIHFN> AFMBHLJAIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000210")]
	public string IJLGNAMOBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public bool IFPBODAFCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public int CFKMKPGJDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FPBIDMIFHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x7160EA0", Offset = "0x715F4A0", VA = "0x187160EA0")]
	public FPBIDMIFHHI(string IMMCNGPOMNH, List<CCIKHOCIHFN> CDPALGEMJCK, bool JLGICOENDFB, int LLLNDHJJMGP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[KGJMAOFDNAE]
public class IKBBJGPKKDL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public List<KFPCNBPFNEI> AAKKEJMNPBE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public bool IFPBODAFCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F41E0", Offset = "0x9F27E0", VA = "0x1809F41E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public IKBBJGPKKDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[KGJMAOFDNAE]
public class PLJDCCENOPO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum BFLPOHOBAHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public const string NIMAPEEDKOM = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public string IJLGNAMOBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public BFLPOHOBAHL CKMENNJIKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(BFLPOHOBAHL);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x7167260", Offset = "0x7165860", VA = "0x187167260")]
	public PLJDCCENOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x7167210", Offset = "0x7165810", VA = "0x187167210")]
	public PLJDCCENOPO(string IMMCNGPOMNH, BFLPOHOBAHL PJPCILIKLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[KGJMAOFDNAE]
public class KFLMEHKALKM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public bool OPDOKEKIOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KFLMEHKALKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class FDJLKDLAMMF
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum IAAEJFMKBFM
	{
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[KGJMAOFDNAE]
public class HENJIKJCDIM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public Guid ILLPHDAEAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xDCB800", Offset = "0xDC9E00", VA = "0x180DCB800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public long BKBODBHPALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB790", Offset = "0x9E9D90", VA = "0x1809EB790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public LLPFEKMCAFA CEBJFKOAOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HENJIKJCDIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x7162110", Offset = "0x7160710", VA = "0x187162110")]
	public HENJIKJCDIM(long CINEDGEJAIA, Guid GCPABOHEHBJ, long GFNDILIHOFK, LLPFEKMCAFA HBDOGANPNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x71620F0", Offset = "0x71606F0", VA = "0x1871620F0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[KGJMAOFDNAE]
public class PDCJOEIFKPI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public MFEBDNMCCIM CIJAJIIDNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(MFEBDNMCCIM);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public AOLCJDKHAPO HJAEAMNIHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PDCJOEIFKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0xEBEA90", Offset = "0xEBD090", VA = "0x180EBEA90")]
	public PDCJOEIFKPI(MFEBDNMCCIM OBOOAPELMPF, AOLCJDKHAPO JOGAAHCGFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[KGJMAOFDNAE]
public class LLPFEKMCAFA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public Guid? FKLPDLPILFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x2DBD190", Offset = "0x2DBB790", VA = "0x182DBD190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x7165540", Offset = "0x7163B40", VA = "0x187165540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public Guid MGBHGNBHKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF50", Offset = "0xD2A550", VA = "0x180D2BF50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xF38230", Offset = "0xF36830", VA = "0x180F38230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public LLPFEKMCAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x7165550", Offset = "0x7163B50", VA = "0x187165550")]
	public LLPFEKMCAFA(Guid? ANJBPBOPKKL, Guid JLOCCHKBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[KGJMAOFDNAE]
public class AOLCJDKHAPO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public Guid ILLPHDAEAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xDCB800", Offset = "0xDC9E00", VA = "0x180DCB800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public long CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x9EB790", Offset = "0x9E9D90", VA = "0x1809EB790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public Guid LPENJNOHPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0xDCD450", Offset = "0xDCBA50", VA = "0x180DCD450")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xDCCC90", Offset = "0xDCB290", VA = "0x180DCCC90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xE28760", Offset = "0xE26D60", VA = "0x180E28760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x6EA02A0", Offset = "0x6E9E8A0", VA = "0x186EA02A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AOLCJDKHAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[KGJMAOFDNAE]
public class LBPKMPNHPIM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public List<long> GANFANEEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public List<PAMGBGGCNEB> IJEDNGOMPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public byte? OIJHMBNJPML
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x7164660", Offset = "0x7162C60", VA = "0x187164660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x7164650", Offset = "0x7162C50", VA = "0x187164650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public int? OCFGLAAIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x715FD40", Offset = "0x715E340", VA = "0x18715FD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x715FD30", Offset = "0x715E330", VA = "0x18715FD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public Guid? EJGKABCGLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x7164670", Offset = "0x7162C70", VA = "0x187164670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x7164690", Offset = "0x7162C90", VA = "0x187164690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public bool ANBKOOJICFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CA0", Offset = "0x9F32A0", VA = "0x1809F4CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x9F4C90", Offset = "0x9F3290", VA = "0x1809F4C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public LBPKMPNHPIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[KGJMAOFDNAE]
public class NAHKCOBJMOP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public Guid EJGKABCGLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xE28760", Offset = "0xE26D60", VA = "0x180E28760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x6EA02A0", Offset = "0x6E9E8A0", VA = "0x186EA02A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public List<long> GANFANEEDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public List<HKDBDNMIAHA> IJEDNGOMPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public byte OIJHMBNJPML
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xD31730", Offset = "0xD2FD30", VA = "0x180D31730")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x12268C0", Offset = "0x1224EC0", VA = "0x1812268C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public int OCFGLAAIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F3D0", VA = "0x180A20DD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x131BEC0", Offset = "0x131A4C0", VA = "0x18131BEC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public NAHKCOBJMOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum MFEBDNMCCIM
{
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface KIBFFJKINMA
{
	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKKDFMAGFDP<NAHKCOBJMOP>> MEMDAIDDBGB(Guid? LBDJDJIFMMO, long CINEDGEJAIA, string NFHOBPDKIPM, string HHPFBMBMELN, string PCHIHCHIMHB, string NOLCGMINIOC, byte HIECCNNOPLP, int NGGKCKILBNF, [Optional] List<long> FNAGIFOGJOE, [Optional] List<HKDBDNMIAHA> HLMEELBCLMF, bool NHLBKAEBPKA = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OKKDFMAGFDP<NAHKCOBJMOP>> BJBHJOGMKDI(Guid GCPABOHEHBJ, long CINEDGEJAIA, [Optional] string NFHOBPDKIPM, [Optional] string HHPFBMBMELN, [Optional] string PCHIHCHIMHB, [Optional] List<long> FNAGIFOGJOE, [Optional] Dictionary<string, string> HLMEELBCLMF, [Optional] string NOLCGMINIOC, [Optional] byte? HIECCNNOPLP, [Optional] int? NGGKCKILBNF, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MDPKOJIHEAN> ELAEIOLHINB(Guid GCPABOHEHBJ, long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<NAHKCOBJMOP>> HGFOEGAALKJ(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<AOLCJDKHAPO>> LMCBPIIJKEO(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<PDCJOEIFKPI>> ALNACKNNHJI(long CINEDGEJAIA, List<HENJIKJCDIM> NNFECOKKCKG, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[KGJMAOFDNAE]
public class PAMGBGGCNEB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PAMGBGGCNEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[KGJMAOFDNAE]
public class HKDBDNMIAHA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public long LGADKPMDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HKDBDNMIAHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[KGJMAOFDNAE]
public class KCDNBFAMPMM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public long LGADKPMDFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public string CDFPJGOFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x48D8BC0", Offset = "0x48D71C0", VA = "0x1848D8BC0")]
	public KCDNBFAMPMM(long HJPBKGBOCJN, string FBEFHOGBKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public interface DFCGDGCKGFF
{
	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKKDFMAGFDP<List<HKDBDNMIAHA>>> OHGMEGBHLPA(long CINEDGEJAIA, List<KCDNBFAMPMM> NNFECOKKCKG, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MDPKOJIHEAN> JKFODGKEBMG(long HJPBKGBOCJN, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<HKDBDNMIAHA>> GIFIPLCJJDM(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[KGJMAOFDNAE]
public class KHDEJMAKAOC : KEGPDCCONLK, IEquatable<KHDEJMAKAOC>
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x71642C0", Offset = "0x71628C0", VA = "0x1871642C0", Slot = "7")]
	public bool Equals(KHDEJMAKAOC MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x71643F0", Offset = "0x71629F0", VA = "0x1871643F0", Slot = "6")]
	public override KEGPDCCONLK OKKBPPIELHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KHDEJMAKAOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class HMHPAMPBGMF
{
	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x71622D0", Offset = "0x71608D0", VA = "0x1871622D0")]
	public static KHDEJMAKAOC FPFIMAEMPOF(this ENODKHBAMBO HOJKNIMMINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x7162340", Offset = "0x7160940", VA = "0x187162340")]
	public static KHDEJMAKAOC IFOLFJOHHKB(string PGAKCPFNKFA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[KGJMAOFDNAE]
public class ENODKHBAMBO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public const int FDFBCFDGDBP = 3;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public const int PCPNIPPGMEP = 40;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public const int PJANKBFCOIJ = 180;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public const int KLDDHDPJICC = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public const int OLBMEPEJLGH = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public const int MLNBBILJGIH = 8;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public const int OLDKLELICFP = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public const int BGMEJPNNOJO = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public const int EGEKNNNBDAK = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? ONDPIGFLLMI;

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public Guid EJGKABCGLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public string? BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public string? PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xE169A0", Offset = "0xE14FA0", VA = "0x180E169A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public Guid? FLGLFGFONKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x71603A0", Offset = "0x715E9A0", VA = "0x1871603A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x7160390", Offset = "0x715E990", VA = "0x187160390")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xD75B20", Offset = "0xD74120", VA = "0x180D75B20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xD75B10", Offset = "0xD74110", VA = "0x180D75B10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public int? GDNNGMOHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x6B856E0", Offset = "0x6B83CE0", VA = "0x186B856E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x6B85700", Offset = "0x6B83D00", VA = "0x186B85700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public int? KACEGKAACEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x71603C0", Offset = "0x715E9C0", VA = "0x1871603C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x715FFC0", Offset = "0x715E5C0", VA = "0x18715FFC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public IReadOnlyList<ECNEMCKPFCK> IGKHLLEFMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xE58970", Offset = "0xE56F70", VA = "0x180E58970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xE58CA0", Offset = "0xE572A0", VA = "0x180E58CA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	[IgnoreDataMember]
	public LBKMNBNEGGK KHACGJDONCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x715FFE0", Offset = "0x715E5E0", VA = "0x18715FFE0")]
		get
		{
			return default(LBKMNBNEGGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> ABNHEMBPOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x715FF70", Offset = "0x715E570", VA = "0x18715FF70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FF0", Offset = "0x9F15F0", VA = "0x1809F2FF0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x715FFD0", Offset = "0x715E5D0", VA = "0x18715FFD0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public ENODKHBAMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x71603D0", Offset = "0x715E9D0", VA = "0x1871603D0")]
	public ENODKHBAMBO(Guid LBDJDJIFMMO, long CINEDGEJAIA, string NFHOBPDKIPM, string HHPFBMBMELN, string PCHIHCHIMHB, int NBDBEANPNJP, int? FENKFHBMCEE, int? GCBMCFGOEPN, List<ECNEMCKPFCK> ABNJJLEHKMC, [Optional] DateTime IPOPOEOJDBB, [Optional] DateTime FMICMNKNFFM, [Optional] Guid? DABAMLICNDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x7160320", Offset = "0x715E920", VA = "0x187160320")]
	private LBKMNBNEGGK JAPHJFELOCD()
	{
		return default(LBKMNBNEGGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x7160050", Offset = "0x715E650", VA = "0x187160050")]
	private Dictionary<Guid, int> IJCBGHMJIPC(IReadOnlyList<ECNEMCKPFCK> ABNJJLEHKMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[KGJMAOFDNAE]
public class NDNFMOBEGDM : MHLEMOAMOMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public Guid EJGKABCGLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public long BJFFDFGEMMF;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public NDNFMOBEGDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[KGJMAOFDNAE]
public class BGLAHANGAJA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public string? BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public string? PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public int? GDNNGMOHMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0xED4D00", Offset = "0xED3300", VA = "0x180ED4D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0xED4D30", Offset = "0xED3330", VA = "0x180ED4D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public int? KACEGKAACEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B50", Offset = "0xCB0150", VA = "0x180CB1B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xCB1BA0", Offset = "0xCB01A0", VA = "0x180CB1BA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public List<ECNEMCKPFCK> IGKHLLEFMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	public Guid? AGONOIKDIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x715DEF0", Offset = "0x715C4F0", VA = "0x18715DEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x715DEE0", Offset = "0x715C4E0", VA = "0x18715DEE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public Guid? EJGKABCGLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x715EC40", Offset = "0x715D240", VA = "0x18715EC40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x715EC60", Offset = "0x715D260", VA = "0x18715EC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public bool ANBKOOJICFP
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0xD31720", Offset = "0xD2FD20", VA = "0x180D31720")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0xE8A7F0", Offset = "0xE88DF0", VA = "0x180E8A7F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x715EC30", Offset = "0x715D230", VA = "0x18715EC30", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public BGLAHANGAJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[KGJMAOFDNAE]
public class ECNEMCKPFCK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public CEMHNBIBILO KPPMOCAOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0")]
		[CompilerGenerated]
		get
		{
			return default(CEMHNBIBILO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public Guid EKCPLOPLIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x18BFF00", Offset = "0x18BE500", VA = "0x1818BFF00")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x5846ED0", Offset = "0x58454D0", VA = "0x185846ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public ECNEMCKPFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x715F930", Offset = "0x715DF30", VA = "0x18715F930")]
	public ECNEMCKPFCK(Guid FJMKDAIDLCG, CEMHNBIBILO MLCOGCMJLBB, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[KGJMAOFDNAE]
public class FPEDDFNDPOC : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public Guid PINHBFGJNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public int DPEGLBCIGEO
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public DateTime HFHBLLIHHCH
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB520", Offset = "0x9E9B20", VA = "0x1809EB520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0xD62250", Offset = "0xD60850", VA = "0x180D62250")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x7160F10", Offset = "0x715F510", VA = "0x187160F10")]
	public FPEDDFNDPOC(Guid ACMIOGGCAFC, string NFHOBPDKIPM, int ICCLHCNGGKE, DateTime KPHHLDOPKCN, int DJNGLBELENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FPEDDFNDPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[KGJMAOFDNAE]
public class BMIPONGKFFG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public Guid PINHBFGJNJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xF8C3F0", Offset = "0xF8A9F0", VA = "0x180F8C3F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public int CLMEBBPBOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public BMIPONGKFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x4B79FB0", Offset = "0x4B785B0", VA = "0x184B79FB0")]
	public BMIPONGKFFG(Guid ACMIOGGCAFC, int JBDHEJLKLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[KGJMAOFDNAE]
public class JAIAAGECEBA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public int CLMEBBPBOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public Guid IMMDBMJFEAI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x18BFF00", Offset = "0x18BE500", VA = "0x1818BFF00")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x5846ED0", Offset = "0x58454D0", VA = "0x185846ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public int EEELOGDGPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public Guid? NGKJFHPADCB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xE64060", Offset = "0xE62660", VA = "0x180E64060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x218B5D0", Offset = "0x2189BD0", VA = "0x18218B5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public int HILPHCEMOBP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xA088F0", Offset = "0xA06EF0", VA = "0x180A088F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x1482A00", Offset = "0x1481000", VA = "0x181482A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public Dictionary<Guid, Guid?> IDFKGLAIELG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public JAIAAGECEBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x71635B0", Offset = "0x7161BB0", VA = "0x1871635B0")]
	public JAIAAGECEBA(int JBDHEJLKLPP, Guid MADIDFMKIGI, int EINEBHDPMPB, Guid? MCFDCCNBJDI, int PFIIKHDBDDL, Dictionary<Guid, Guid?> DDFLCMACKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[KGJMAOFDNAE]
public class JJGKBGIHCCM : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public FFNCJAJHGHI OBPCBMKAENI
	{
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0")]
		[CompilerGenerated]
		get
		{
			return default(FFNCJAJHGHI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public LNDBPNALOAJ? DHOBHHFICOF
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xED4C90", Offset = "0xED3290", VA = "0x180ED4C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xEDDBC0", Offset = "0xEDC1C0", VA = "0x180EDDBC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public BalanceResponseDTO CBNMHFPCHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public List<AOLCJDKHAPO> EGCBAFLHJMF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public JJGKBGIHCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x7163760", Offset = "0x7161D60", VA = "0x187163760")]
	public JJGKBGIHCCM(FFNCJAJHGHI MHNLACILOFC, LNDBPNALOAJ? BJJCPOKICNF, BalanceResponseDTO GEBELIMGKPC, List<AOLCJDKHAPO> GNLBCGGIPBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x7163750", Offset = "0x7161D50", VA = "0x187163750", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public enum CEMHNBIBILO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public enum FFNCJAJHGHI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public enum LBKMNBNEGGK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public interface AJCBKGPINID
{
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	static NPNKPOOAOFG<ENODKHBAMBO> BOEDNFLINLO;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	static NPNKPOOAOFG<ENODKHBAMBO> HFIGBMIHKLC;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	static NPNKPOOAOFG<Guid> GGLCJMAOIMC;

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OKKDFMAGFDP<ENODKHBAMBO?>?>? MFGPBMLENDN(Guid? LBDJDJIFMMO, long CINEDGEJAIA, string NFHOBPDKIPM, string? HHPFBMBMELN, string? PCHIHCHIMHB, int NBDBEANPNJP, LBKMNBNEGGK NPCDGFOONOH, [Optional] Dictionary<Guid, int>? LFJOIJADHHP, [Optional] Guid? BEEIKGNACJP, bool NHLBKAEBPKA = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OKKDFMAGFDP<ENODKHBAMBO?>?>? KHAGPLLNDAC(Guid ACMIOGGCAFC, long CINEDGEJAIA, string NFHOBPDKIPM, string? HHPFBMBMELN, string? PCHIHCHIMHB, int NBDBEANPNJP, LBKMNBNEGGK NPCDGFOONOH, [Optional] Dictionary<Guid, int>? LFJOIJADHHP, [Optional] Guid? BEEIKGNACJP, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MDPKOJIHEAN> AMJDGFAMIKC(Guid ACMIOGGCAFC, long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<ENODKHBAMBO>> FJKGKELNGNC(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<OKKDFMAGFDP<List<BMIPONGKFFG>>> HOCDLCOKGHO(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OKKDFMAGFDP<List<FPEDDFNDPOC>>> HDMDJOECEJH(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<JJGKBGIHCCM> LMCLGPBEFBD(Guid ACMIOGGCAFC, long CINEDGEJAIA, int JBDHEJLKLPP, int EINEBHDPMPB, Guid? MCADMAJFPLF, int PFIIKHDBDDL, Dictionary<Guid, Guid?> FKMNMMFFPBL, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x715D5B0", Offset = "0x715BBB0", VA = "0x18715D5B0")]
	static AJCBKGPINID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[KGJMAOFDNAE]
public class LNHNFGKPJHC : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public long BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public bool EJECJELJAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F41E0", Offset = "0x9F27E0", VA = "0x1809F41E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public LNHNFGKPJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface KAMAILPHFOH
{
	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LNHNFGKPJHC> CJAKGOOBKCL(long CINEDGEJAIA, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<MDPKOJIHEAN> JIAJFEKLGDF(long CINEDGEJAIA, bool KIOEPLCGDFB, [Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[NHFDOLIJPLM]
public class AFAFCGCCJFL<DataType> where DataType : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public long KLEDGCNLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public ENBJEHKMOJF FOCHGGKBCJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10")]
		[CompilerGenerated]
		get
		{
			return default(ENBJEHKMOJF);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD65620", VA = "0x180D67020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public DataType HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AFAFCGCCJFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[NHFDOLIJPLM]
public class FAAICHAJFEG<DataType> where DataType : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public long KLEDGCNLIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public ENBJEHKMOJF FOCHGGKBCJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA12D10", Offset = "0xA11310", VA = "0x180A12D10")]
		[CompilerGenerated]
		get
		{
			return default(ENBJEHKMOJF);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xD67020", Offset = "0xD65620", VA = "0x180D67020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public List<DataType> HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FAAICHAJFEG()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[NHFDOLIJPLM]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : MHLEMOAMOMP, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NHFDOLIJPLM]
		public class DCMOODBCEDF : HADCGNIOBLA, MHLEMOAMOMP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			[CompilerGenerated]
			private struct JDFDOGJOBML : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041C")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041D")]
				public DCMOODBCEDF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041E")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005E3")]
				[Cpp2IlInjected.Address(RVA = "0x4E6F460", Offset = "0x4E6DA60", VA = "0x184E6F460", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005E4")]
				[Cpp2IlInjected.Address(RVA = "0x4E6F740", Offset = "0x4E6DD40", VA = "0x184E6F740", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027B")]
			public LNDBPNALOAJ KHCENHMPCJE
			{
				[Cpp2IlInjected.Token(Token = "0x60005DC")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				[CompilerGenerated]
				get
				{
					return default(LNDBPNALOAJ);
				}
				[Cpp2IlInjected.Token(Token = "0x60005DD")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027C")]
			public DataTypeDTO HCNIDPKECHH
			{
				[Cpp2IlInjected.Token(Token = "0x60005DE")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005DF")]
				[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x6A34F60", Offset = "0x6A33560", VA = "0x186A34F60", Slot = "5")]
			public void FOGENAANJJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0x6A35050", Offset = "0x6A33650", VA = "0x186A35050", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.DCMOODBCEDF.JDFDOGJOBML))]
			public Task PGKHKEHPKKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public DCMOODBCEDF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		public List<DCMOODBCEDF> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x5678CF0", Offset = "0x56772F0", VA = "0x185678CF0", Slot = "5")]
		public override void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[NHFDOLIJPLM]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : MHLEMOAMOMP, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[NHFDOLIJPLM]
		public class BOJNIBECDEI : HADCGNIOBLA, MHLEMOAMOMP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			[CompilerGenerated]
			private struct LCFGFCFBKCN : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000422")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000423")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000424")]
				public BOJNIBECDEI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000425")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005F0")]
				[Cpp2IlInjected.Address(RVA = "0x5100790", Offset = "0x50FED90", VA = "0x185100790", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F1")]
				[Cpp2IlInjected.Address(RVA = "0x5100A00", Offset = "0x50FF000", VA = "0x185100A00", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027E")]
			public LNDBPNALOAJ KHCENHMPCJE
			{
				[Cpp2IlInjected.Token(Token = "0x60005E9")]
				[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
				[CompilerGenerated]
				get
				{
					return default(LNDBPNALOAJ);
				}
				[Cpp2IlInjected.Token(Token = "0x60005EA")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027F")]
			public List<DataTypeDTO> HCNIDPKECHH
			{
				[Cpp2IlInjected.Token(Token = "0x60005EB")]
				[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005EC")]
				[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x6412030", Offset = "0x6410630", VA = "0x186412030", Slot = "5")]
			public void FOGENAANJJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x64122D0", Offset = "0x64108D0", VA = "0x1864122D0", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.BOJNIBECDEI.LCFGFCFBKCN))]
			public Task PGKHKEHPKKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public BOJNIBECDEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		public List<BOJNIBECDEI> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x5678CF0", Offset = "0x56772F0", VA = "0x185678CF0", Slot = "5")]
		public override void FOGENAANJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[EHDNHPMPEGO]
public class GLNHGANNJCC : PurchaseBalanceUpdateResponseDTO<BAAIMDALMOP>
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x7161D90", Offset = "0x7160390", VA = "0x187161D90")]
	public GLNHGANNJCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[EHDNHPMPEGO]
public class BHMFCOGJOFJ : PurchaseBalanceUpdateResponseDTO<BAAIMDALMOP>.BOJNIBECDEI
{
	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x715EC70", Offset = "0x715D270", VA = "0x18715EC70")]
	public BHMFCOGJOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[KGJMAOFDNAE]
public class BBECJNGCOMP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public EPDOOECNGMH NHGMCBMLOHA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public long PNCAEHGBKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public GiftItemDTO? NOLKNKICJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public long? CGNJNDDBJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x12A0680", Offset = "0x129EC80", VA = "0x1812A0680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x12A0670", Offset = "0x129EC70", VA = "0x1812A0670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000284")]
	public int CGEKPMCPFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0xA088E0", Offset = "0xA06EE0", VA = "0x180A088E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0xD62250", Offset = "0xD60850", VA = "0x180D62250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x715DFE0", Offset = "0x715C5E0", VA = "0x18715DFE0")]
	public BBECJNGCOMP(EPDOOECNGMH PEJCCPLAEAH, long GAFFJGMGEBD, GiftItemDTO? BMIKDHDIMIN, int BILIHFEFION = 1, [Optional] long? FNNPIONLMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[KGJMAOFDNAE]
public class PFAEBGPDKBN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000285")]
	public List<BBECJNGCOMP> CCAFLAOJPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000286")]
	public NDHNCEHANCH? NCJPFJDOOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000287")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000288")]
	public bool OHOMMCMDHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xD1ED00", Offset = "0xD1D300", VA = "0x180D1ED00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xD1E310", Offset = "0xD1C910", VA = "0x180D1E310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000289")]
	public bool KJFPCCMAEBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x135DA50", Offset = "0x135C050", VA = "0x18135DA50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x2631680", Offset = "0x262FC80", VA = "0x182631680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x7166EE0", Offset = "0x71654E0", VA = "0x187166EE0")]
	public PFAEBGPDKBN(List<BBECJNGCOMP> LKJAGBDLHBA, NDHNCEHANCH? JLKOEGKPAAA, COAFHABICNE JIIJIDFJIGK, bool LAPONJDPKEK, bool KLCPALLGAMN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[KGJMAOFDNAE]
public class GLJLLBFCNKJ : HADCGNIOBLA, MHLEMOAMOMP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct NKNMNFCLDMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public GLJLLBFCNKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x7166640", Offset = "0x7164C40", VA = "0x187166640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x7166920", Offset = "0x7164F20", VA = "0x187166920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	internal static Action<BAAIMDALMOP>? PFMBKLNGPLF;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	internal static Func<BAAIMDALMOP, Task>? AIPKKILGDOP;

	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public BAAIMDALMOP MJPJCLIEJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public EHGDCJFOLHP? EABDGGDMKHH
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x7161C00", Offset = "0x7160200", VA = "0x187161C00", Slot = "5")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x7161CC0", Offset = "0x71602C0", VA = "0x187161CC0", Slot = "6")]
	[AsyncStateMachine(typeof(NKNMNFCLDMH))]
	public virtual Task PGKHKEHPKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GLJLLBFCNKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[EHDNHPMPEGO]
public class EDJEGAEANJC : BalanceUpdateResponseDTO<GLJLLBFCNKJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x715F980", Offset = "0x715DF80", VA = "0x18715F980")]
	public EDJEGAEANJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[EHDNHPMPEGO]
public class GLGGDJIBKGO : BalanceUpdateResponseDTO<GLJLLBFCNKJ>.DCMOODBCEDF
{
	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x7161BC0", Offset = "0x71601C0", VA = "0x187161BC0")]
	public GLGGDJIBKGO()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[KGJMAOFDNAE]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public IPAJFKBAJFI GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
			[CompilerGenerated]
			get
			{
				return default(IPAJFKBAJFI);
			}
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[KGJMAOFDNAE]
public class PIGJKMDEGFL : MHLEMOAMOMP, GBONMBHCOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000290")]
	public MMOPDGKBAEH? BEDCKOANOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	[IgnoreDataMember]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7167190", Offset = "0x7165790", VA = "0x187167190", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public EPDOOECNGMH? HAMALLJNAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public List<PAMBPODMHLK>? IDIBNFCBPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public DateTime? OLLPENDCGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x12A0680", Offset = "0x129EC80", VA = "0x1812A0680", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x12A0670", Offset = "0x129EC70", VA = "0x1812A0670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public DateTime? MAHMPFMIFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x1369220", Offset = "0x1367820", VA = "0x181369220", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x136B330", Offset = "0x1369930", VA = "0x18136B330")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public DateTime? BLDPNGBCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0xD316F0", Offset = "0xD2FCF0", VA = "0x180D316F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x5843830", Offset = "0x5841E30", VA = "0x185843830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public bool AFHLPLGFLFH
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xC03FA0", Offset = "0xC025A0", VA = "0x180C03FA0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xC03560", Offset = "0xC01B60", VA = "0x180C03560")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	public bool IGFMDEAIBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x10C3180", Offset = "0x10C1780", VA = "0x1810C3180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x10C3190", Offset = "0x10C1790", VA = "0x1810C3190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000299")]
	public bool CKFBECEKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0xEB5260", Offset = "0xEB3860", VA = "0x180EB5260", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x15B9820", Offset = "0x15B7E20", VA = "0x1815B9820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xEB0250", Offset = "0xEAE850", VA = "0x180EB0250", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0xEB4EF0", Offset = "0xEB34F0", VA = "0x180EB4EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x7166F50", Offset = "0x7165550", VA = "0x187166F50")]
	public static PIGJKMDEGFL KIAHOAKCICH(Guid DGPIPOJOJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PIGJKMDEGFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[KGJMAOFDNAE]
public class HJNGBICMFAI
{
	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	public int IDOBOHLCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public string HPKGABDCMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public string CICDEPBHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public Dictionary<int, FKFJEBFACDM> LFDKECOFCLK
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public Dictionary<string, int> BFKCOFHKCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public Dictionary<EKMFBCAKACJ, List<int>> EEDPNIHOGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public Dictionary<string, string> OEEAHJGEMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HJNGBICMFAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum EKMFBCAKACJ
{
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[KGJMAOFDNAE]
public class FKFJEBFACDM : OIGCECFCALE
{
	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public FFEEJALAFLP IBDPCJNEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(FFEEJALAFLP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public bool IBPAAHDJFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x1132F70", Offset = "0x1131570", VA = "0x181132F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x1372D50", Offset = "0x1371350", VA = "0x181372D50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public bool JMOLHBDDPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F890", Offset = "0x1D5DE90", VA = "0x181D5F890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FA00", Offset = "0x1D5E000", VA = "0x181D5FA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public string GPEHAKCLMIK
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public string NDGLACAKMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public string ODEPCLKLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public string JOAANNEFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public Dictionary<KBKDLGNDCGI, string> CGKBOONGHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x1372D60", Offset = "0x1371360", VA = "0x181372D60")]
	public FKFJEBFACDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[KGJMAOFDNAE]
public class CLMJHLFPLGN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public IReadOnlyList<MMOPDGKBAEH>? EEJNKLINIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public CLMJHLFPLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public CLMJHLFPLGN(IReadOnlyList<MMOPDGKBAEH>? DOGFLLCGOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public enum APCAKCGDFCO
{
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface GBONMBHCOAE
{
	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	EPDOOECNGMH? HAMALLJNAAE
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	List<PAMBPODMHLK>? IDIBNFCBPNO
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	DateTime? OLLPENDCGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	DateTime? MAHMPFMIFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	DateTime? BLDPNGBCHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	bool AFHLPLGFLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	bool CKFBECEKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface LNNECACOFKO
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BGMFODNKBKG;

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BKJFNLCKCLM(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MHHLKGHDLEE(CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FFCEAPKPDAP([Out] MFHIIDPIAOF NFFGNPJGBOO);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface MFHIIDPIAOF
{
	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	string HPKGABDCMBH
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	string CICDEPBHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	IReadOnlyDictionary<EKMFBCAKACJ, IReadOnlyList<OIGCECFCALE>> HMLALOKOLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	IReadOnlyDictionary<string, string> OEEAHJGEMOM
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface OIGCECFCALE
{
	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	string NDGLACAKMKB
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	string GPEHAKCLMIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	string ODEPCLKLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	string JOAANNEFMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface FBAKIBIPOMC
{
	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	OILBOLBBFDD KPPMOCAOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	string OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	string HKGGJOPMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	string HJFBOJCGKGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	bool OCHOLGOLIHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	bool CKFBECEKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	NGFKJBKJKIN PKGBFGMFFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	string MCOPKJANMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	DKDANGFCEKG? GOPBNIHHAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	APCAKCGDFCO MOLJGCJNBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	bool JKHBCDJKKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[KGJMAOFDNAE]
public class EPDOOECNGMH : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	public OILBOLBBFDD KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(OILBOLBBFDD);
		}
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	public int? MOMEODJELMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0xED4C90", Offset = "0xED3290", VA = "0x180ED4C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0xEDDBC0", Offset = "0xEDC1C0", VA = "0x180EDDBC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	public Guid? EEEHCCDKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FD0", Offset = "0x9F15D0", VA = "0x1809F2FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x9F3090", Offset = "0x9F1690", VA = "0x1809F3090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x7160540", Offset = "0x715EB40", VA = "0x187160540")]
	public static EPDOOECNGMH IMDGNDKDFBD(int LADFILOPOFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x71605E0", Offset = "0x715EBE0", VA = "0x1871605E0")]
	public static EPDOOECNGMH PJGCMDLKDPB(Guid DGPIPOJOJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public EPDOOECNGMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public enum OILBOLBBFDD
{
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[KGJMAOFDNAE]
public class PAMBPODMHLK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	public COAFHABICNE HHNPLOFGEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(COAFHABICNE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xC5E800", Offset = "0xC5CE00", VA = "0x180C5E800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	public GKOCLAEFPKE CMABFDNKMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0xEADE30", Offset = "0xEAC430", VA = "0x180EADE30", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x7166CC0", Offset = "0x71652C0", VA = "0x187166CC0")]
	public int CIONIKJEHEA(DateTime PLBAFGHLBPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PAMBPODMHLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[KGJMAOFDNAE]
public class GKOCLAEFPKE : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	public int HKAKOGOJGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	public DateTime? FCCJNMBJGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xDCB800", Offset = "0xDC9E00", VA = "0x180DCB800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	public DateTime? NNJAHMAPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x12A0680", Offset = "0x129EC80", VA = "0x1812A0680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x12A0670", Offset = "0x129EC70", VA = "0x1812A0670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x7161AD0", Offset = "0x71600D0", VA = "0x187161AD0")]
	public bool LBHMAIODDKB(DateTime PLBAFGHLBPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x7161AA0", Offset = "0x71600A0", VA = "0x187161AA0")]
	public int KCJBPCMIOPM(DateTime PLBAFGHLBPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x71619B0", Offset = "0x715FFB0", VA = "0x1871619B0")]
	public TimeSpan? FGJJLMLPPFA(DateTime PLBAFGHLBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GKOCLAEFPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public enum NDHNCEHANCH
{
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum AAGBAMPLMIJ
{
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum CMDDEGLKAEL
{
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public enum DAGGDADKPAE
{
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum FAOKEPNFPED
{
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[KGJMAOFDNAE]
public class FOANPJIEHHD : IEquatable<FOANPJIEHHD>
{
	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	public int? MMAFONCBOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public int? EFOJIFFEFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	public int? AIIKFEMBEEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xCB1B80", Offset = "0xCB0180", VA = "0x180CB1B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public List<int>? GCIFPCNAICA
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x7160D30", Offset = "0x715F330", VA = "0x187160D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x7160740", Offset = "0x715ED40", VA = "0x187160740")]
	public static FOANPJIEHHD EKFLJJMLJIB(int? BNMDDHMNHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x71607A0", Offset = "0x715EDA0", VA = "0x1871607A0", Slot = "4")]
	public bool Equals(FOANPJIEHHD? MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x71606A0", Offset = "0x715ECA0", VA = "0x1871606A0")]
	private static bool AJNHLKGHGHH(List<int>? FDJHCIBLFFB, List<int>? CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x7160920", Offset = "0x715EF20", VA = "0x187160920", Slot = "0")]
	public override bool Equals(object? BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x7160B50", Offset = "0x715F150", VA = "0x187160B50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FOANPJIEHHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct LDJBIDEBIAE : IEquatable<LDJBIDEBIAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly OILBOLBBFDD KPPMOCAOEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private readonly int MOMEODJELMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private readonly Guid EEEHCCDKBHJ;

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public Guid BJLCIJDDMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x71650C0", Offset = "0x71636C0", VA = "0x1871650C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public int IEECKJOAMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0x71650B0", Offset = "0x71636B0", VA = "0x1871650B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public string CBMMLKBCLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x71647F0", Offset = "0x7162DF0", VA = "0x1871647F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x7164B60", Offset = "0x7163160", VA = "0x187164B60")]
	public static bool HBGMKAEOAKP(string AMDHAEEMHLI, [Out] LDJBIDEBIAE JEHIAMEMOAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x71649A0", Offset = "0x7162FA0", VA = "0x1871649A0")]
	public static LDJBIDEBIAE GKAIMDPHPLD(int HJPLNJNIFLL)
	{
		return default(LDJBIDEBIAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x71646A0", Offset = "0x7162CA0", VA = "0x1871646A0")]
	public static LDJBIDEBIAE BCMMCGGJJAM(Guid HJPLNJNIFLL)
	{
		return default(LDJBIDEBIAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x7164FA0", Offset = "0x71635A0", VA = "0x187164FA0")]
	private static bool IFBJBCMDKEE(string AMDHAEEMHLI, [Out] OILBOLBBFDD OHMPGLBFBMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x71651E0", Offset = "0x71637E0", VA = "0x1871651E0")]
	private LDJBIDEBIAE(OILBOLBBFDD OHMPGLBFBMP, int? PFDDAIJJAOE, Guid? DGPIPOJOJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x7164930", Offset = "0x7162F30", VA = "0x187164930", Slot = "4")]
	public bool Equals(LDJBIDEBIAE MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x7164840", Offset = "0x7162E40", VA = "0x187164840", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x7164AD0", Offset = "0x71630D0", VA = "0x187164AD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x7165130", Offset = "0x7163730", VA = "0x187165130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
[KGJMAOFDNAE]
public abstract class KEGPDCCONLK : IEquatable<KEGPDCCONLK>, MHLEMOAMOMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public Guid JPEKMHAKLEC;

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x7164380", Offset = "0x7162980", VA = "0x187164380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x7164300", Offset = "0x7162900", VA = "0x187164300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x71642C0", Offset = "0x71628C0", VA = "0x1871642C0", Slot = "4")]
	public bool Equals(KEGPDCCONLK MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x71641A0", Offset = "0x71627A0", VA = "0x1871641A0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract KEGPDCCONLK OKKBPPIELHH();

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected KEGPDCCONLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum JKDLJAFLBMC
{
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[KGJMAOFDNAE]
public class MMOPDGKBAEH : KEGPDCCONLK, IEquatable<MMOPDGKBAEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public JKDLJAFLBMC OHMPGLBFBMP;

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x7165FA0", Offset = "0x71645A0", VA = "0x187165FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x7165EB0", Offset = "0x71644B0", VA = "0x187165EB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MMOPDGKBAEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x7166040", Offset = "0x7164640", VA = "0x187166040")]
	public MMOPDGKBAEH(JKDLJAFLBMC OHMPGLBFBMP, Guid JPEKMHAKLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x7165DF0", Offset = "0x71643F0", VA = "0x187165DF0")]
	public static MMOPDGKBAEH BCMMCGGJJAM(Guid MONOBEAOLBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x7165E60", Offset = "0x7164460", VA = "0x187165E60", Slot = "7")]
	public bool Equals(MMOPDGKBAEH MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x7165F30", Offset = "0x7164530", VA = "0x187165F30", Slot = "6")]
	public override KEGPDCCONLK OKKBPPIELHH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public static class PEIEENGMMJI
{
	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x7166D10", Offset = "0x7165310", VA = "0x187166D10")]
	public static MMOPDGKBAEH FPFIMAEMPOF(this OJGMLCKBDIB HOJKNIMMINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x7166D80", Offset = "0x7165380", VA = "0x187166D80")]
	public static MMOPDGKBAEH IFOLFJOHHKB(string JFCAPPIKPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x7166E70", Offset = "0x7165470", VA = "0x187166E70")]
	public static MMOPDGKBAEH LIOFCHNKFOL(Guid BHICOBAOBDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[KGJMAOFDNAE]
public class OJGMLCKBDIB : EGONCOPCFDP, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public JKDLJAFLBMC KPPMOCAOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(JKDLJAFLBMC);
		}
		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public Guid BEDCKOANOKF
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x18BFF00", Offset = "0x18BE500", VA = "0x1818BFF00")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x5846ED0", Offset = "0x58454D0", VA = "0x185846ED0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public long? BJFFDFGEMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xEC1FE0", Offset = "0xEC05E0", VA = "0x180EC1FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xEC1EB0", Offset = "0xEC04B0", VA = "0x180EC1EB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public long DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xE281D0", Offset = "0xE267D0", VA = "0x180E281D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public Guid? BGJPHFKJAAB
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x7166B00", Offset = "0x7165100", VA = "0x187166B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7166B20", Offset = "0x7165120", VA = "0x187166B20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public DateTime HLEKPMBEFEF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xE594D0", Offset = "0xE57AD0", VA = "0x180E594D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public DateTime GJGOMALEFKE
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xE58970", Offset = "0xE56F70", VA = "0x180E58970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DC")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OJGMLCKBDIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DD")]
	[Cpp2IlInjected.Address(RVA = "0x7166BE0", Offset = "0x71651E0", VA = "0x187166BE0")]
	public OJGMLCKBDIB(JKDLJAFLBMC OHMPGLBFBMP, Guid JPEKMHAKLEC, [Optional] string NFHOBPDKIPM, [Optional] string HHPFBMBMELN, [Optional] string PCHIHCHIMHB, [Optional] long? CINEDGEJAIA, long NBDBEANPNJP = 0L, [Optional] Guid? CFDJJCFFGGK, [Optional] DateTime IPOPOEOJDBB, [Optional] DateTime FMICMNKNFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x7166B30", Offset = "0x7165130", VA = "0x187166B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public enum OAPMNGPFEMF
{
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public enum JDLCPNJPBHB
{
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[KGJMAOFDNAE]
public class AJCDICPBHHL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public JDLCPNJPBHB CIJAJIIDNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(JDLCPNJPBHB);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public List<string> NEGJPANFFBD
	{
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0x715D700", Offset = "0x715BD00", VA = "0x18715D700")]
	public string IOKFJCBMLHN(int CMDLDHKKGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AJCDICPBHHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[KGJMAOFDNAE]
public class APPNANGFABC : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public string ACJOIMALHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public OAPMNGPFEMF KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(OAPMNGPFEMF);
		}
		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public APPNANGFABC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public static class HAIBNEAFKGA
{
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public const string BLKDNBEAPBD = "costume";

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public const string FNNKBHACFMP = "gadget";

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public const string ODNKLPEAMOE = "holotar";

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public const string MCBCHFCBDMD = "large";

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public const string GHNKLEIPGOG = "medium";

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public const string EFMDMNEMPJK = "small";

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public const string HBEPFOKCMPO = "sound";

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public const string MGGMCEFKFJE = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public const string CDDNNPHNCLI = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public const string ICJCPCHEJOA = "r2";

	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public static List<string> DKNPEKGAPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x7161E40", Offset = "0x7160440", VA = "0x187161E40")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public static class FELIDNINBMH
{
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public const string IGIGMBNMIKC = "beta";

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public const string OKDOJKNNMJL = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[KGJMAOFDNAE]
public class ENMAJHPHPEK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public List<string> HJBBGBOKCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public List<string> ENMMHNBGOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public List<string> OBLAGADFCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public ENMAJHPHPEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public class BJKJNBKDHEG : IEquatable<BJKJNBKDHEG>
{
	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	protected virtual Type KEGGKEILPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x715F270", Offset = "0x715D870", VA = "0x18715F270", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public MLOJOBKDNHB? MDIIFCDHOCD
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public HttpMethod? PADEOJAGNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public string? FGODBGGPKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x715F3E0", Offset = "0x715D9E0", VA = "0x18715F3E0")]
	public BJKJNBKDHEG(MLOJOBKDNHB? MDIIFCDHOCD, HttpMethod? PADEOJAGNOG, string? FGODBGGPKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x715F2D0", Offset = "0x715D8D0", VA = "0x18715F2D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x715ECF0", Offset = "0x715D2F0", VA = "0x18715ECF0", Slot = "6")]
	protected virtual bool EPCHDBBEJNC(StringBuilder KBOCLOKOKJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0xEF38E0", Offset = "0xEF1EE0", VA = "0x180EF38E0")]
	public static bool DIKHMNDIIDO(BJKJNBKDHEG? PLHEPGEBJJB, BJKJNBKDHEG? AOBOBFPJKKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0xEF38B0", Offset = "0xEF1EB0", VA = "0x180EF38B0")]
	public static bool MMJMCICIDNJ(BJKJNBKDHEG? PLHEPGEBJJB, BJKJNBKDHEG? AOBOBFPJKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x715F070", Offset = "0x715D670", VA = "0x18715F070", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x715EE50", Offset = "0x715D450", VA = "0x18715EE50", Slot = "0")]
	public override bool Equals(object? BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x715EEE0", Offset = "0x715D4E0", VA = "0x18715EEE0", Slot = "7")]
	public virtual bool Equals(BJKJNBKDHEG? MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x715F1E0", Offset = "0x715D7E0", VA = "0x18715F1E0", Slot = "8")]
	public virtual BJKJNBKDHEG IFEAKEOGCHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x715F430", Offset = "0x715DA30", VA = "0x18715F430")]
	protected BJKJNBKDHEG(BJKJNBKDHEG MKDGMAIADPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x715ECB0", Offset = "0x715D2B0", VA = "0x18715ECB0")]
	public void BGDNOIMKKGE([Out] MLOJOBKDNHB? MDIIFCDHOCD, [Out] HttpMethod? PADEOJAGNOG, [Out] string? FGODBGGPKJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public class IBEKFPOONAD : IEquatable<IBEKFPOONAD>
{
	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	protected virtual Type KEGGKEILPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x71628D0", Offset = "0x7160ED0", VA = "0x1871628D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public int PDMBJPPIKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public MGHOHDHDIIM AKCFIMAFAOC
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480")]
		[CompilerGenerated]
		get
		{
			return default(MGHOHDHDIIM);
		}
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0xC5E800", Offset = "0xC5CE00", VA = "0x180C5E800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x7162A40", Offset = "0x7161040", VA = "0x187162A40")]
	public IBEKFPOONAD(int PDMBJPPIKBF, MGHOHDHDIIM AKCFIMAFAOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x7162930", Offset = "0x7160F30", VA = "0x187162930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x7162450", Offset = "0x7160A50", VA = "0x187162450", Slot = "6")]
	protected virtual bool EPCHDBBEJNC(StringBuilder KBOCLOKOKJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0xEF38E0", Offset = "0xEF1EE0", VA = "0x180EF38E0")]
	public static bool DIKHMNDIIDO(IBEKFPOONAD? PLHEPGEBJJB, IBEKFPOONAD? AOBOBFPJKKO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0xEF38B0", Offset = "0xEF1EB0", VA = "0x180EF38B0")]
	public static bool MMJMCICIDNJ(IBEKFPOONAD? PLHEPGEBJJB, IBEKFPOONAD? AOBOBFPJKKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x7162750", Offset = "0x7160D50", VA = "0x187162750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x71626C0", Offset = "0x7160CC0", VA = "0x1871626C0", Slot = "0")]
	public override bool Equals(object? BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x7162580", Offset = "0x7160B80", VA = "0x187162580", Slot = "7")]
	public virtual bool Equals(IBEKFPOONAD? MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x7162860", Offset = "0x7160E60", VA = "0x187162860", Slot = "8")]
	public virtual IBEKFPOONAD IFEAKEOGCHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0xB76580", Offset = "0xB74B80", VA = "0x180B76580")]
	protected IBEKFPOONAD(IBEKFPOONAD MKDGMAIADPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x7162440", Offset = "0x7160A40", VA = "0x187162440")]
	public void BGDNOIMKKGE([Out] int PDMBJPPIKBF, [Out] MGHOHDHDIIM AKCFIMAFAOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public enum MGHOHDHDIIM
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public interface IFCNDIKBIKD
{
	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<BJKJNBKDHEG, IBEKFPOONAD> CKFIBILHLIK();

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJPPCPAEPEI(BJKJNBKDHEG OEHHKNIGGMI, IBEKFPOONAD BDCLNIJAFBF);

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BGMGLGCNDHB(BJKJNBKDHEG OEHHKNIGGMI);

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CMHEBPLKCCB();

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PPKBKBEOBBG(MLOJOBKDNHB BEGHPONNAEO, HttpMethod OAKFMPLKGOM, string ONEIEOBHEBH, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[NHFDOLIJPLM]
public class FDPGAAIPEKA<TResult> where TResult : MHLEMOAMOMP, new()
{
	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public IReadOnlyList<TResult> PNOBAFODHLK
	{
		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public long IONEPHOFJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FDPGAAIPEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public enum AALOKKMMDMA
{
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public interface FOOACHOHIKD : JMJLBFPPABC
{
	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	bool EEAECMAOEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long MADIDFMKIGI, AOAKNJHJFNK ABGDMNNPPIN);

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HFNGOCGJOMO> PurchaseAsync(AOAKNJHJFNK ABGDMNNPPIN, FOANPJIEHHD DGFFKAIOMCG);

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(EAFBBJLBANJ NOLDLCPOCDE, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public interface JMJLBFPPABC
{
	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	bool IGNGCLIPKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public interface OPHBAIBOAEJ
{
	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	int IMLNLBPBDKN
	{
		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<AOAKNJHJFNK>> MEOGLCNEICC(bool LJLJHJONNNE = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOBMKNMLLJB([Out] AOAKNJHJFNK? OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<AOAKNJHJFNK> FNMOBJKHBJJ(bool LJLJHJONNNE = false, [Optional] CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LEEJBDOBACO(string DKBCGBFNIGO = "");
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public interface AICICAEPBLH
{
	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CMFCLHJDAJM(EAFBBJLBANJ NOLDLCPOCDE, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task LDMEGHJLGCO(EAFBBJLBANJ NOLDLCPOCDE, CancellationToken CBJPDIFOEKF, [Optional] MGGMMMFAFDA? IMKLICDJPDJ);
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public interface MGGMMMFAFDA
{
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOFBHHDHAOO(string HKOKFJFBOCK);
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public interface LKOIGHOJMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task IBKJPJLKIHM(EAFBBJLBANJ IMODOCEFDDK, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public interface OKGHEKOKIIL
{
	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	bool LOCIAHKNHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public interface JLEAPCLPICI
{
	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EAFBBJLBANJ DHPCFBDMEKK(AOAKNJHJFNK ABGDMNNPPIN, FOANPJIEHHD DGFFKAIOMCG, string ECANGAOBBGM, [Optional] AICICAEPBLH? KOGLCPNHFGK);
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public interface LDMHKJMFALF
{
	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBBCLCHPCDL(LKOIGHOJMIE DLNPOEEPFML);

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ABKOOBLIJDE(LKOIGHOJMIE DLNPOEEPFML);

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task GFGKGBDECFN(EAFBBJLBANJ NOLDLCPOCDE, CancellationToken CBJPDIFOEKF);
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public interface EAFBBJLBANJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	IKGLKEHHCCJ NNEABAOJLAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	AOAKNJHJFNK JOOKEKKGIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	FOANPJIEHHD JKBJOOODKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	string IANNOMGFAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	string EKOBDINGLOL
	{
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<COECJEHEDBG> CBHCLJGGHJO(CancellationToken EBOFCHGLLPK, [Optional] MGGMMMFAFDA? IMKLICDJPDJ);

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILBINBEFAGH(string AACKKPGJBPA);

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILBINBEFAGH<T>(Func<T, string> AACKKPGJBPA, [In] T AJOONPNONCF);
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public abstract class MJJLFHCALIK
{
	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected MJJLFHCALIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public enum KBEGPEKHPGB
{
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public enum POFDJDAFGGB : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
[KGJMAOFDNAE]
public class AOAKNJHJFNK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public int MGEMGHMBLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public string PNHKFKCEKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public int DFMBJPCDEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EEE00", VA = "0x1809F0800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public string NDFFBHAIGDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public string BNPLCDIONJE
	{
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	[DataMember(Name = "PsnProductLabel")]
	public string NOKHLJAJJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public string FDCBHENHOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public string ECKJPKPJCNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public string AJPGCADEODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public string NODGINDEHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public string NKOEHNDFICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public bool DLFLDCCIPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xC4DC10", Offset = "0xC4C210", VA = "0x180C4DC10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xC4D830", Offset = "0xC4BE30", VA = "0x180C4D830")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public bool CJGDKBHLJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x15BF3D0", Offset = "0x15BD9D0", VA = "0x1815BF3D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x15BF5B0", Offset = "0x15BDBB0", VA = "0x1815BF5B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public ADPEFCELODP HCNIDPKECHH
	{
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x9F3010", Offset = "0x9F1610", VA = "0x1809F3010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	[IgnoreDataMember]
	public string IBBFJOMFMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FF0", Offset = "0x9F15F0", VA = "0x1809F2FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	[IgnoreDataMember]
	public string JMBIKEHOJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xBEE060", Offset = "0xBEC660", VA = "0x180BEE060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x13038B0", Offset = "0x1301EB0", VA = "0x1813038B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	[IgnoreDataMember]
	public string KMAJPIMCPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x9F3040", Offset = "0x9F1640", VA = "0x1809F3040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x9F3050", Offset = "0x9F1650", VA = "0x1809F3050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	[IgnoreDataMember]
	public MJJLFHCALIK PMEJPDEMBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xCD6750", Offset = "0xCD4D50", VA = "0x180CD6750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xE59ED0", Offset = "0xE584D0", VA = "0x180E59ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	[IgnoreDataMember]
	public bool JOPHLLJHKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x715DB80", Offset = "0x715C180", VA = "0x18715DB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	[IgnoreDataMember]
	public string NGHILNCCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x9F64A0", Offset = "0x9F4AA0", VA = "0x1809F64A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x9F64C0", Offset = "0x9F4AC0", VA = "0x1809F64C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x715DBA0", Offset = "0x715C1A0", VA = "0x18715DBA0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x715DC90", Offset = "0x715C290", VA = "0x18715DC90")]
	public static AOAKNJHJFNK LJOGPKPCFOI(int HJPLNJNIFLL, string NFHOBPDKIPM, string PCHIHCHIMHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x715DD30", Offset = "0x715C330", VA = "0x18715DD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public AOAKNJHJFNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
[KGJMAOFDNAE]
public class ADPEFCELODP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public List<int> GNDENGMKICA
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public string LNILHMKIEOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public DOIHELLICBB PNJHDCAAOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0xEADE30", Offset = "0xEAC430", VA = "0x180EADE30", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public ADPEFCELODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public readonly struct COECJEHEDBG
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	public enum FJGIMNPMOEK : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public readonly FJGIMNPMOEK NKALCNEKGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	public readonly POFDJDAFGGB EEOEELFGAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public readonly KBEGPEKHPGB BHAMEGACDKB;

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x715F580", Offset = "0x715DB80", VA = "0x18715F580")]
	private COECJEHEDBG(FJGIMNPMOEK IDAKFFICKHC, POFDJDAFGGB DPJOCPAEPPA = POFDJDAFGGB.Unknown, KBEGPEKHPGB JPDNDHMPILG = KBEGPEKHPGB.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x715F560", Offset = "0x715DB60", VA = "0x18715F560")]
	public static COECJEHEDBG JPLAKFPJJKE()
	{
		return default(COECJEHEDBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x715F520", Offset = "0x715DB20", VA = "0x18715F520")]
	public static COECJEHEDBG FKJBHNMNOGE()
	{
		return default(COECJEHEDBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x715F540", Offset = "0x715DB40", VA = "0x18715F540")]
	public static COECJEHEDBG FMNIANNOKLL(POFDJDAFGGB DPJOCPAEPPA, KBEGPEKHPGB JPDNDHMPILG)
	{
		return default(COECJEHEDBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public enum BIOAFDJHLFI
{
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public enum PBLOJCMGPDI
{
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[KGJMAOFDNAE]
public class DOIHELLICBB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public BIOAFDJHLFI HOAMCOAEJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(BIOAFDJHLFI);
		}
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public PBLOJCMGPDI LDNFOOKPEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xB76480", Offset = "0xB74A80", VA = "0x180B76480")]
		[CompilerGenerated]
		get
		{
			return default(PBLOJCMGPDI);
		}
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xC5E800", Offset = "0xC5CE00", VA = "0x180C5E800")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public bool FEJEMBMGEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x9F41E0", Offset = "0x9F27E0", VA = "0x1809F41E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public DOIHELLICBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public enum IKGLKEHHCCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[KGJMAOFDNAE]
public class PPICDCDJIDN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public string BGGIEPIKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public ONOOOJEFPBH? NAOKMAGJDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public string? BLJANOOBBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public bool CKOLJBHFBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xDBBFE0", Offset = "0xDBA5E0", VA = "0x180DBBFE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xAA4630", Offset = "0xAA2C30", VA = "0x180AA4630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public string? GKJCACGNALC
	{
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public string? PIKIOHDOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public string? LPKAAPOKHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public bool? BKNBFMKBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x7167380", Offset = "0x7165980", VA = "0x187167380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x7167370", Offset = "0x7165970", VA = "0x187167370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PPICDCDJIDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[KGJMAOFDNAE]
public class MFEAGLFKJML : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public string BLPCOOECADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public ONOOOJEFPBH? NAOKMAGJDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public bool CKOLJBHFBAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public string? PIKIOHDOMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MFEAGLFKJML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[KGJMAOFDNAE]
public class KCBONAHKPGL : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public string LPKAAPOKHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public string GKJCACGNALC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public string GHAJJFBIBCF
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public string? PMGNEGOCDKD
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public float ILHLPJHEMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xC096D0", Offset = "0xC07CD0", VA = "0x180C096D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xF1A9B0", Offset = "0xF18FB0", VA = "0x180F1A9B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KCBONAHKPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[KGJMAOFDNAE]
public class JHAIGFEHKHO : PGNAHLEOJHC, MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public string OHDIDODLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public string IBFJODFHPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "6")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AF")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public JHAIGFEHKHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[KGJMAOFDNAE]
public class BLGPPCOBJLI : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public long BJJANAEJEBD
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xD240A0", Offset = "0xD226A0", VA = "0x180D240A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public decimal NGFNNBIBPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xDCB800", Offset = "0xDC9E00", VA = "0x180DCB800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B4")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B5")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public BLGPPCOBJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[KGJMAOFDNAE]
public class MDBIHINDEFN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public string OHDIDODLMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public string GPEIFEKIGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MDBIHINDEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public MDBIHINDEFN(string PNBLCEBBDDJ, string CAGGFIHFLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[KGJMAOFDNAE]
public class DEBKODPFNKO : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public string GPEIFEKIGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public DEBKODPFNKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[KGJMAOFDNAE]
public class GJMKGBHHFBK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public string LPKAAPOKHCG
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public string BGGIEPIKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public string? EOMGDLMNCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public string? NHEGOKCPOIC
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GJMKGBHHFBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
[KGJMAOFDNAE]
public class OONFFOANBJN : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public string NGGJMDLHLLA
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OONFFOANBJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[KGJMAOFDNAE]
public class EOOLNPLGDMJ : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public int OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public string? IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public IReadOnlyList<int> EFHJGCECLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public string? POCLMFPBHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x71604B0", Offset = "0x715EAB0", VA = "0x1871604B0")]
	public EOOLNPLGDMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[KGJMAOFDNAE]
public class LPMFJAFAOON : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public int OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x60007DB")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public Guid? EEEHCCDKBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x218B600", Offset = "0x2189C00", VA = "0x18218B600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x218B5F0", Offset = "0x2189BF0", VA = "0x18218B5F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public List<EOOLNPLGDMJ> IFHJMMDMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public List<EOOLNPLGDMJ> JMILCLGNEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public string? IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public string? POCLMFPBHKO
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public string? AIFFBGAFCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x71655A0", Offset = "0x7163BA0", VA = "0x1871655A0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x71655D0", Offset = "0x7163BD0", VA = "0x1871655D0")]
	public LPMFJAFAOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[KGJMAOFDNAE]
public class MOIGIIHPFMA : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public LPMFJAFAOON IFHJMMDMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public LPMFJAFAOON JMILCLGNEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public string? AIFFBGAFCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x7166080", Offset = "0x7164680", VA = "0x187166080", Slot = "5")]
	public virtual void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MOIGIIHPFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[KGJMAOFDNAE]
public class MPBOJILBLOB : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public IReadOnlyList<LPMFJAFAOON> BIEFAAFIEMG
	{
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public IReadOnlyList<MOIGIIHPFMA> DJIFCIGFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000348")]
	public IReadOnlyList<MPBOJILBLOB> ABNMLMMAEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000349")]
	public string? AIFFBGAFCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x71660E0", Offset = "0x71646E0", VA = "0x1871660E0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x7166110", Offset = "0x7164710", VA = "0x187166110")]
	public MPBOJILBLOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[KGJMAOFDNAE]
public class ONOOOJEFPBH : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	public List<ONOOOJEFPBH>? CKOCFIAIKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x7166CA0", Offset = "0x71652A0", VA = "0x187166CA0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public ONOOOJEFPBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[KGJMAOFDNAE]
public class GOPFPGFCCEP : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	public string OJLJBFKDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	public MPBOJILBLOB BOJGKNCLAOB
	{
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	public ONOOOJEFPBH? NAOKMAGJDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public string? BLPCOOECADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x7161DD0", Offset = "0x71603D0", VA = "0x187161DD0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GOPFPGFCCEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[KGJMAOFDNAE]
public class GIOJGGIGFKG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public BBMBJJIMEEM<GOPFPGFCCEP> CIJAJIIDNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public decimal BAPPIBMCJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0xDCB800", Offset = "0xDC9E00", VA = "0x180DCB800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0x6F260C0", Offset = "0x6F246C0", VA = "0x186F260C0", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GIOJGGIGFKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public enum BJLFFPCCMKO
{
	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[KGJMAOFDNAE]
public class PGOAANHEJBG : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public BJLFFPCCMKO GBAEAGCCJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(BJLFFPCCMKO);
		}
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public DateTime FDAMNHLHDLA
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PGOAANHEJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
[KGJMAOFDNAE]
public class HFOJOBCEKAK : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public BJLFFPCCMKO DCALOGMKKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(BJLFFPCCMKO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public float PGPNJBOGBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xD1E700", Offset = "0xD1CD00", VA = "0x180D1E700")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0xD1E320", Offset = "0xD1C920", VA = "0x180D1E320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000826")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public HFOJOBCEKAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
[KGJMAOFDNAE]
public class BHMLJBEAHPD : MHLEMOAMOMP
{
	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public BJLFFPCCMKO GBAEAGCCJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(BJLFFPCCMKO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public DateTime FDAMNHLHDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xC5E900", Offset = "0xC5CF00", VA = "0x180C5E900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public BJLFFPCCMKO DCALOGMKKLG
	{
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(BJLFFPCCMKO);
		}
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xC8FD50", Offset = "0xC8E350", VA = "0x180C8FD50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public float PGPNJBOGBOE
	{
		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0x1076350", Offset = "0x1074950", VA = "0x181076350")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0x12805D0", Offset = "0x127EBD0", VA = "0x1812805D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public BJLFFPCCMKO FOHKAFANGFH
	{
		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(BJLFFPCCMKO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public float FJNHAGKHGCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xC55210", Offset = "0xC53810", VA = "0x180C55210")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xC55220", Offset = "0xC53820", VA = "0x180C55220")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void FOGENAANJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public BHMLJBEAHPD()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
public class PPHBBBBMJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PPHBBBBMJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x6E8BA40", Offset = "0x6E8A040", VA = "0x186E8BA40")]
	public static string GEGBLCCMNJF(byte[] KIEHMFJADIM, byte[] IAEAOGJCDGG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
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
