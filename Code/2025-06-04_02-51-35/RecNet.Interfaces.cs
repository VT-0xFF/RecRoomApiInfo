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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74C9490", Offset = "0x74C7C90", VA = "0x1874C9490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LONONFMAKPF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum BCINBHAFECL
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
	public string FDIDBKEMHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string HMJDCIMIJJG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BCINBHAFECL KCFGFOHGPPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(BCINBHAFECL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KOCMAJDAMME
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x213A290", Offset = "0x2138A90", VA = "0x18213A290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CJDMFMMNEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x181F290", Offset = "0x181DA90", VA = "0x18181F290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74C6400", Offset = "0x74C4C00", VA = "0x1874C6400")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static LONONFMAKPF BNFFGAJIILO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74C6460", Offset = "0x74C4C60", VA = "0x1874C6460")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static LONONFMAKPF IGBOELAKDCI([Optional] string DJFBFBKNBFI, [Optional] string BIMJKFGEANO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LONONFMAKPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LKPJJMJEMMH
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	MakerAI,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	RoomieAI
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KMKIBIHCKNN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string FPAFFOGHFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string MNGIIDFDDMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IIMNHJLFLMP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CLBEGJCCKFF? ODEKANKAKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LBOAOFAOKMM<OMNNILPHCNH> NJLEENNKGBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	LBOAOFAOKMM<AMFIOOCAGIO> ABOOODJHGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFKNGLBFEKD();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<DMFOFLICLDP> ACAFHPGBHEN(bool BAGBPHCGBAM, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DMFOFLICLDP> JFEFBIEGCMM(bool BAGBPHCGBAM, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<AMIACJELMLO> IEHEJGCLGGN(bool HPOEPGBEDJL = false, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<CEEMBFDGDDM> JPLDCMOOKJE([Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<DMFOFLICLDP> KNLPAGBGEHP(bool HPOEPGBEDJL = false, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<DMFOFLICLDP> LGLMDMENIDC([Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<KMKIBIHCKNN> CBDFINBDAIF(LKPJJMJEMMH BDDGJKIKBLC, string NHFDBLECNGK, string ALBECJOMJEH, string KNPFEJFEJJD, string? LIDOOMDJGLD, float GFJKECAGMIL, bool APFFAMDDHGN = false, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<DMFOFLICLDP> IOPLGLLMDND(LKPJJMJEMMH BDDGJKIKBLC, long HHKAEIEEJAI, decimal PHMBAALGNEL, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task AMOHNKOGAAH(LKPJJMJEMMH BDDGJKIKBLC, string IKOFEBOFHLE, string JGMCIDMHJDL, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<HONAADGBBIA> FDLOAGMJJOG(string NHFDBLECNGK, string CMMCANPKKEM, bool DAJKPCJMOEG, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<CLBEGJCCKFF> LOEIEOCKMNB(string CMMCANPKKEM, JPKGLNCJBOH? ELIOILHOKAE, string? DHLMINLOBPB, IReadOnlyList<string> MGCDHABPPNJ, IReadOnlyList<string> GNKAKIKNBDB, GEOHCOMPKGC LDCOIJIBFHA, [Optional] string? KHFJGAIBGHP, [Optional] string? AOAKFGCPMKC, [Optional] string? FBOGDENFCDE, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<CLBEGJCCKFF> HCLHKOCNPOH(string EOKPMGGJEMH, JPKGLNCJBOH? ELIOILHOKAE, IReadOnlyList<string> GNKAKIKNBDB, GEOHCOMPKGC LDCOIJIBFHA, [Optional] string? AOAKFGCPMKC, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<List<string>> LNFHELNBPOH(string CMMCANPKKEM, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> EAPGKOHDDGJ(GEOHCOMPKGC LDCOIJIBFHA, [Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MHOCOODLGCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private string BJMDINFCGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private string ODBJNPAHEOB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string EABLNKBPAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string IHFONIFGCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string BFOKACBLIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public string ONCDNGGLLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int? AHFFIBOCOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int? HPBBOGABFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74C76D0", Offset = "0x74C5ED0", VA = "0x1874C76D0")]
	public MHOCOODLGCL(string ICEPLLIEDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74C76A0", Offset = "0x74C5EA0", VA = "0x1874C76A0")]
	public void MDDCJENILPG(string AFLOKPNAPPB = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74C75A0", Offset = "0x74C5DA0", VA = "0x1874C75A0")]
	private void LCCCOIEFOJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JGNCJBKANKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MGDGHCBONGK HDHFKLPBONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PJHKODPBKAG> FHEKMKOCGDJ;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<BPBEOCCBOFJ> KHEIJCEEJLP;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BPBEOCCBOFJ> IIMKCJGBJJA(bool BAPMNAFNHFK = false, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LDCJCMFMNEP([Out] BPBEOCCBOFJ ECKHMNOBMCL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OGHOFLCBGJE
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x74C98A0", Offset = "0x74C80A0", VA = "0x1874C98A0")]
	public static bool IKGOEPGHMAD(this JGNCJBKANKH EOEHHNOOLNO, [Out] PJHKODPBKAG HDADCHLHGKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x74C97C0", Offset = "0x74C7FC0", VA = "0x1874C97C0")]
	public static bool HEHDADENFPF(this JGNCJBKANKH EOEHHNOOLNO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HLDBHHNHEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HDGCPCCCMFD(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CINNJJKIFCP(int BCAMLHNLCHC, [Out] IAMMEAINIAN? LDCOIJIBFHA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IAMMEAINIAN
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int MKIOMINKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string? NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	string? HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool? FELPOKMDCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? ENBHKIDEGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string? PBEJNKDFHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PONDKPLNPKD? IIJDDNDICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool OIFCBGCHMBK(string LIBMOAPMLBF, [Out] PAOAHGJEOMC? LDCOIJIBFHA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PAOAHGJEOMC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? HPLODLNCFIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string? IFJLHGMMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string? OGGABMPHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	IReadOnlyList<ADOENBOICIH>? KNJEJGMENAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	PONDKPLNPKD? IIJDDNDICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	long? MLLMMMHHEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ADOENBOICIH
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string IFJLHGMMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	string PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IENBAGHAANF HJPGCOIJNLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface PONDKPLNPKD
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string IFJLHGMMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string? FDDANHEBGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[JHLCFIPIAOM]
public class PPCAAMFBEHG
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public List<DEHBBFBJMEE> PNFFJNOODBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Dictionary<string, string> LEBKFGOOLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x74C9BB0", Offset = "0x74C83B0", VA = "0x1874C9BB0")]
	public PPCAAMFBEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[JHLCFIPIAOM]
public class DEHBBFBJMEE
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int MKIOMINKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string ENBHKIDEGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string PBEJNKDFHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool? FELPOKMDCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xDB6C10", Offset = "0xDB5410", VA = "0x180DB6C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xDB6C20", Offset = "0xDB5420", VA = "0x180DB6C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public ADNJKHOAFEP IIJDDNDICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Dictionary<string, NIKOFBDFPND> MEBHAJGJGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74C1C30", Offset = "0x74C0430", VA = "0x1874C1C30")]
	public DEHBBFBJMEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[JHLCFIPIAOM]
public class ADNJKHOAFEP
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string IFJLHGMMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string FDDANHEBGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ADNJKHOAFEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[JHLCFIPIAOM]
public class NIKOFBDFPND
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string HPLODLNCFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string IFJLHGMMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string OGGABMPHAAA
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public List<AFDOGDGEFGB> KNJEJGMENAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public ADNJKHOAFEP IIJDDNDICCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public long MLLMMMHHEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA30040", Offset = "0xA2E840", VA = "0x180A30040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74C8870", Offset = "0x74C7070", VA = "0x1874C8870")]
	public NIKOFBDFPND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IENBAGHAANF
{
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	DismissDialog,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	CloseWatch,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	GoToStore,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	GoToCreate,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	GoToDayPass,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	PositiveEvent,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	NegativeEvent,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	CancelEvent
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[JHLCFIPIAOM]
public class AFDOGDGEFGB
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string IFJLHGMMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public IENBAGHAANF HJPGCOIJNLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(IENBAGHAANF);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public AFDOGDGEFGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct MBBNLLNDDIK : IEquatable<MBBNLLNDDIK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly bool KDKDIKGMGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly DateTime CNKOIPIANLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly bool AAMBPJMOPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly BLIFBLCKHPP? JHKMKBHNNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly string IBOIILNBDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly int? DHBINCKAEAI;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static MBBNLLNDDIK GNAANNMINKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2818C50", Offset = "0x2817450", VA = "0x182818C50")]
		get
		{
			return default(MBBNLLNDDIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x74C6C90", Offset = "0x74C5490", VA = "0x1874C6C90")]
	public MBBNLLNDDIK(DateTime PGCJKONGEMP, bool JAMPHHICEKM, BLIFBLCKHPP? FNKKGCGJHHL, string NHDJIHDOEJO, int? JFFFHEPMINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x74C6B00", Offset = "0x74C5300", VA = "0x1874C6B00")]
	public PJHKODPBKAG MMDDKBMDEIH(MGDGHCBONGK OGDNPJIHHKE)
	{
		return default(PJHKODPBKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x74C6780", Offset = "0x74C4F80", VA = "0x1874C6780")]
	private static PJHKODPBKAG APHGFLAKAEL(MGDGHCBONGK OGDNPJIHHKE, DateTime PGCJKONGEMP)
	{
		return default(PJHKODPBKAG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x74C68F0", Offset = "0x74C50F0", VA = "0x1874C68F0", Slot = "4")]
	public bool Equals(MBBNLLNDDIK KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x74C6840", Offset = "0x74C5040", VA = "0x1874C6840", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x74C6A50", Offset = "0x74C5250", VA = "0x1874C6A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x74C6B90", Offset = "0x74C5390", VA = "0x1874C6B90")]
	public static bool NALNDDPCEFD(MBBNLLNDDIK HGBNKPCDEON, MBBNLLNDDIK DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x74C6800", Offset = "0x74C5000", VA = "0x1874C6800")]
	public static bool BLLMPNNLKNM(MBBNLLNDDIK HGBNKPCDEON, MBBNLLNDDIK DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x74C6BC0", Offset = "0x74C53C0", VA = "0x1874C6BC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct BPBEOCCBOFJ : IEquatable<BPBEOCCBOFJ>
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly BPBEOCCBOFJ GNAANNMINKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly bool KBFIABEIPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly PJHKODPBKAG ECLGCADKJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly MBBNLLNDDIK JEOADFKIMMB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x74C1010", Offset = "0x74BF810", VA = "0x1874C1010")]
	public BPBEOCCBOFJ(PJHKODPBKAG HDADCHLHGKJ, MBBNLLNDDIK CIONJFHGHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x74C0B70", Offset = "0x74BF370", VA = "0x1874C0B70", Slot = "4")]
	public bool Equals(BPBEOCCBOFJ KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x74C0C20", Offset = "0x74BF420", VA = "0x1874C0C20", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x74C0D50", Offset = "0x74BF550", VA = "0x1874C0D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74C0E10", Offset = "0x74BF610", VA = "0x1874C0E10")]
	public static bool NALNDDPCEFD(BPBEOCCBOFJ HGBNKPCDEON, BPBEOCCBOFJ DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x74C0A50", Offset = "0x74BF250", VA = "0x1874C0A50")]
	public static bool BLLMPNNLKNM(BPBEOCCBOFJ HGBNKPCDEON, BPBEOCCBOFJ DPOCHOAKFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x74C0F20", Offset = "0x74BF720", VA = "0x1874C0F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PJHKODPBKAG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GCMPINGAKJL : MGDGHCBONGK
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public const string DDPGLGLHEBN = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Stopwatch PIAKJKGIEDL;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static DateTimeOffset? AGCKNIFDNNK;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly GCMPINGAKJL CMJLAOBGHAL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static MGDGHCBONGK HPECEAELCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74C2D50", Offset = "0x74C1550", VA = "0x1874C2D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	internal static GCMPINGAKJL LPONKIILGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x74C2DA0", Offset = "0x74C15A0", VA = "0x1874C2DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static DateTimeOffset EPMNBIKHGHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x74C3160", Offset = "0x74C1960", VA = "0x1874C3160")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public static DateTime KFMFNEIELKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x74C2DF0", Offset = "0x74C15F0", VA = "0x1874C2DF0")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTime INGIAOJNKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x74C2E80", Offset = "0x74C1680", VA = "0x1874C2E80", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DateTimeOffset PACPBCDMIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x74C32C0", Offset = "0x74C1AC0", VA = "0x1874C32C0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	private GCMPINGAKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74C2F40", Offset = "0x74C1740", VA = "0x1874C2F40")]
	internal static void LJOILPIMCCP(DateTime? JCCKMOLKIAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum NCKPDJBCADI
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum DBIDKOJBJMB
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[JHLCFIPIAOM]
public class GFAGOKJKJAJ : MEPPJFCAKFJ, PNBLFFBKHJH, PEDHEJJFDDO, IBIOIPMKCHN, KFJACODJGAE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private struct FDKJPFJEEGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GFAGOKJKJAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x74C2370", Offset = "0x74C0B70", VA = "0x1874C2370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x74C2710", Offset = "0x74C0F10", VA = "0x1874C2710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[IgnoreDataMember]
	public static KABJJPFJCMP GJMNDNBMGAJ;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int ECHOGNNDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xDED050", Offset = "0xDEB850", VA = "0x180DED050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LLFJILOKJLH LEJIPMPFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA46F40", Offset = "0xA45740", VA = "0x180A46F40", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(LLFJILOKJLH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x156DA90", Offset = "0x156C290", VA = "0x18156DA90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool KELCMEPONED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xC9B990", Offset = "0xC9A190", VA = "0x180C9B990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xD98160", Offset = "0xD96960", VA = "0x180D98160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool ODEEKCPENKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xE06130", Offset = "0xE04930", VA = "0x180E06130", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xE04960", Offset = "0xE03160", VA = "0x180E04960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LKPMLOCIMOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1F62EC0", Offset = "0x1F616C0", VA = "0x181F62EC0", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1F62550", Offset = "0x1F60D50", VA = "0x181F62550")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int? ONIKHLNJFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x74C39D0", Offset = "0x74C21D0", VA = "0x1874C39D0", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x74C39C0", Offset = "0x74C21C0", VA = "0x1874C39C0", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string IGNBFLCMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string NKGHKFAIPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string IDNEOOEEEMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xEE4A50", Offset = "0xEE3250", VA = "0x180EE4A50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public DateTime NHJMHLMMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xEE4EF0", Offset = "0xEE36F0", VA = "0x180EE4EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NCKPDJBCADI DLLCHIEFHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xE433D0", Offset = "0xE41BD0", VA = "0x180E433D0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(NCKPDJBCADI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xF45270", Offset = "0xF43A70", VA = "0x180F45270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string BPPNJDCLCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33860", VA = "0x180A35060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int ILCFOFPDHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD24C0", VA = "0x180CD3CC0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCD3FC0", Offset = "0xCD27C0", VA = "0x180CD3FC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public IReadOnlyList<OEGEBJGFAFG> FLOCNJGOLDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA8C920", Offset = "0xA8B120", VA = "0x180A8C920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public IReadOnlyList<BEEFHHMIDLF> JONOBNOEEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public IFBALPNNAHD ELNJDJDBGEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA35090", Offset = "0xA33890", VA = "0x180A35090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public string LKKALJFMDMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x74C3880", Offset = "0x74C2080", VA = "0x1874C3880", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public EGEILCJOOBK BIDBIMCCNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA76E00", Offset = "0xA75600", VA = "0x180A76E00", Slot = "24")]
		get
		{
			return default(EGEILCJOOBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x74C3880", Offset = "0x74C2080", VA = "0x1874C3880", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public string DAHGILMMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool FGPIDMBKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public EKPGHFMPAMO EBLNGNKGBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xFA4340", Offset = "0xFA2B40", VA = "0x180FA4340", Slot = "30")]
		get
		{
			return default(EKPGHFMPAMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string KCEECFNCIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27550", VA = "0x180A28D50", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public PKFFGNGIAJB? GJONAJHBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x74C3970", Offset = "0x74C2170", VA = "0x1874C3970", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public AHNEIMADPDH MICNHHPCKNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA76E00", Offset = "0xA75600", VA = "0x180A76E00", Slot = "33")]
		get
		{
			return default(AHNEIMADPDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool HPGKFEDFCKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GFAGOKJKJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0xFD82E0", Offset = "0xFD6AE0", VA = "0x180FD82E0")]
	public GFAGOKJKJAJ([Optional] Guid FLLEHMEKPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74C36E0", Offset = "0x74C1EE0", VA = "0x1874C36E0", Slot = "35")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74C38A0", Offset = "0x74C20A0", VA = "0x1874C38A0", Slot = "36")]
	[AsyncStateMachine(typeof(FDKJPFJEEGM))]
	public Task GFJMJFDKHCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x74C3670", Offset = "0x74C1E70", VA = "0x1874C3670")]
	public GFAGOKJKJAJ BFMJNOOKHBJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[JHLCFIPIAOM]
public class NOKEAODMLBL : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int? ONIKHLNJFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x127F160", Offset = "0x127D960", VA = "0x18127F160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xF65EF0", Offset = "0xF646F0", VA = "0x180F65EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public string IGNBFLCMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public LLFJILOKJLH LEJIPMPFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		[CompilerGenerated]
		get
		{
			return default(LLFJILOKJLH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xDED050", Offset = "0xDEB850", VA = "0x180DED050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public NCKPDJBCADI? DLLCHIEFHNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xD35DF0", Offset = "0xD345F0", VA = "0x180D35DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xD35E40", Offset = "0xD34640", VA = "0x180D35E40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NOKEAODMLBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[JHLCFIPIAOM]
public class FFECCBCIIFN : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int ECHOGNNDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int? ONIKHLNJFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1262950", Offset = "0x1261150", VA = "0x181262950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1288E50", Offset = "0x1287650", VA = "0x181288E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string NKGHKFAIPGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public string IGNBFLCMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FFECCBCIIFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[JHLCFIPIAOM]
public class IFAMGMFDBIE : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int? ONIKHLNJFEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string IGNBFLCMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IFAMGMFDBIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct JOJMBLMHDAM
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static int GOEDOFLILDA;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static int MMMPJKGHJDJ;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int GCHFFBOCKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int MCOKIFFMMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x74C5B10", Offset = "0x74C4310", VA = "0x1874C5B10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public static JOJMBLMHDAM JMOEBDABFID
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x74C5B60", Offset = "0x74C4360", VA = "0x1874C5B60")]
		get
		{
			return default(JOJMBLMHDAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x74C5C00", Offset = "0x74C4400", VA = "0x1874C5C00")]
	public JOJMBLMHDAM(int GLABNMPLPMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[JHLCFIPIAOM]
public class ONPHGKLAJEC : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int FNCBDNNJJOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int? DCLPEEOCOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1262950", Offset = "0x1261150", VA = "0x181262950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1288E50", Offset = "0x1287650", VA = "0x181288E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string? IGFPALBFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x74C9980", Offset = "0x74C8180", VA = "0x1874C9980")]
	public ONPHGKLAJEC(int DAOMOCCAFDN, int? ABCFKAIPBDC, string? ILBALOOKKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ONPHGKLAJEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[JHLCFIPIAOM]
public class ANIJOIBJAID : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JLCALMMIAHB.CEJMBAOJDBO POAMNEFNOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(JLCALMMIAHB.CEJMBAOJDBO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string KDGJHABNHOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int? MPKBJDKEMMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ANIJOIBJAID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface BEEFHHMIDLF
{
	[Cpp2IlInjected.Token(Token = "0x17000074")]
	long GFHGKIJHMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Guid LABAJPNFKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string NOLHECGNCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	string DHKICPGFJEK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	int DNFAHGOCPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string JOKLDFOKOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string KAPGJJOIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string GCFEKNLKBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	string ELHKDFDEIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int ILCFOFPDHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[JHLCFIPIAOM]
public class OEGEBJGFAFG : BEEFHHMIDLF, PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public long GFHGKIJHMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xE57670", Offset = "0xE55E70", VA = "0x180E57670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public Guid LABAJPNFKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x139CFD0", Offset = "0x139B7D0", VA = "0x18139CFD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x139CFE0", Offset = "0x139B7E0", VA = "0x18139CFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA30040", Offset = "0xA2E840", VA = "0x180A30040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string NOLHECGNCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public string DHKICPGFJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int DNFAHGOCPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xDC47B0", Offset = "0xDC2FB0", VA = "0x180DC47B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xF00910", Offset = "0xEFF110", VA = "0x180F00910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string JOKLDFOKOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public string KAPGJJOIJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string GCFEKNLKBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA274A0", Offset = "0xA25CA0", VA = "0x180A274A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public string ELHKDFDEIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA274D0", Offset = "0xA25CD0", VA = "0x180A274D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int ILCFOFPDHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xE433D0", Offset = "0xE41BD0", VA = "0x180E433D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xF45270", Offset = "0xF43A70", VA = "0x180F45270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "15")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OEGEBJGFAFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Flags]
public enum HMKIMFNKECN
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum LBNMPPJPHEJ
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DAIEEPCEGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x74C1970", Offset = "0x74C0170", VA = "0x1874C1970")]
	public static int? OMIPMDNEOJM(HMKIMFNKECN? FBCKANLIPIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x74C18E0", Offset = "0x74C00E0", VA = "0x1874C18E0")]
	public static int? EBNGCKFBBMH(LBNMPPJPHEJ? JEFKMBKPDIM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[JHLCFIPIAOM]
public class HDLCNHFFMMI : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int? JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public LLFJILOKJLH? LEJIPMPFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4E0", Offset = "0xA2BCE0", VA = "0x180A2D4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HDLCNHFFMMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[JHLCFIPIAOM]
public class EPFGOPKFNIC : AICPEBEDDBF, PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public byte IKMAIEDBJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public EPFGOPKFNIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DEIPHIODGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x74C1CC0", Offset = "0x74C04C0", VA = "0x1874C1CC0")]
	public static HMDMHEDBGEA PEAHFPFGBBB(this EPFGOPKFNIC DKBBJFIDEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MEPPJFCAKFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	int ECHOGNNDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	int JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	LLFJILOKJLH LEJIPMPFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	bool KELCMEPONED
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	bool ODEEKCPENKG
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	bool LKPMLOCIMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	int? ONIKHLNJFEC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	string IGNBFLCMHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	string NKGHKFAIPGD
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	string IDNEOOEEEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	DateTime NHJMHLMMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	NCKPDJBCADI DLLCHIEFHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string BPPNJDCLCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	int ILCFOFPDHIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string LKKALJFMDMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x74C74B0", Offset = "0x74C5CB0", VA = "0x1874C74B0", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KFJACODJGAE
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	IReadOnlyList<BEEFHHMIDLF> JONOBNOEEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	int ECHOGNNDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	bool LKPMLOCIMOC
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int ILCFOFPDHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	int? ONIKHLNJFEC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	LLFJILOKJLH LEJIPMPFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class KIOKALDCGGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct NPNJPEKNCKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public IEnumerable<IBIOIPMKCHN> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x74C9180", Offset = "0x74C7980", VA = "0x1874C9180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x74C9420", Offset = "0x74C7C20", VA = "0x1874C9420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x74C5FE0", Offset = "0x74C47E0", VA = "0x1874C5FE0")]
	public static bool PKOIEBAEEDH(this IEnumerable<PEDHEJJFDDO> NFJJCCDFOPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x74C5F10", Offset = "0x74C4710", VA = "0x1874C5F10")]
	[AsyncStateMachine(typeof(NPNJPEKNCKC))]
	public static Task CJHCIGIDOIL(this IEnumerable<IBIOIPMKCHN> NFJJCCDFOPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct DOPHJNOBIJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public readonly string IAKMDBPEPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public readonly string NNNDNNKFBHH;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly DOPHJNOBIJD NFLNDOEFHLH;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xB4C820", Offset = "0xB4B020", VA = "0x180B4C820")]
	public DOPHJNOBIJD(string ENNMBIFINAE, string CEGOJJNEECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x129EAA0", Offset = "0x129D2A0", VA = "0x18129EAA0")]
	public bool NELGIOIGCOE(DOPHJNOBIJD KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x74C1DB0", Offset = "0x74C05B0", VA = "0x1874C1DB0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x74C1E80", Offset = "0x74C0680", VA = "0x1874C1E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x74C1EF0", Offset = "0x74C06F0", VA = "0x1874C1EF0")]
	public static bool NALNDDPCEFD(DOPHJNOBIJD HGBNKPCDEON, DOPHJNOBIJD DPOCHOAKFKE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x74C1D30", Offset = "0x74C0530", VA = "0x1874C1D30")]
	public static bool BLLMPNNLKNM(DOPHJNOBIJD HGBNKPCDEON, DOPHJNOBIJD DPOCHOAKFKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface IIEJCJKEOAI
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	MHOCOODLGCL MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string EKJGNJNJFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	string LDMFKCNMLNM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	long BFOBAFGBIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string FLHLAJAEJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string GJDKHNGJBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string NKBHKFLDAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	string FBCCDJMHDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[JHLCFIPIAOM]
public class AJBAEFGOOID : MMNEEGEIPCD
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string FDOFAEIIILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public APMPFMIFEFM CDGKKKOJCGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(APMPFMIFEFM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public IMGEHJGLDDL MFAFFADCNDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
		[CompilerGenerated]
		get
		{
			return default(IMGEHJGLDDL);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public KJDNGCCJNBJ NGKDHFJAOML
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(KJDNGCCJNBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	[DataMember(Name = "Header")]
	public string? OAHKNKCNINA
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string? HPLODLNCFIF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public string? ENGNLIFFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public List<string> KJGODMNINDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public List<OCLJGDALIEB> KNJEJGMENAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x74BFB70", Offset = "0x74BE370", VA = "0x1874BFB70", Slot = "5")]
	public override void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x74BFB80", Offset = "0x74BE380", VA = "0x1874BFB80")]
	public AJBAEFGOOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum MOMGPDFEEMF
{
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum APMPFMIFEFM
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum IMGEHJGLDDL
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum KJDNGCCJNBJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[JHLCFIPIAOM]
public class OCLJGDALIEB : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public MOMGPDFEEMF KFIHDPGLLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(MOMGPDFEEMF);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public string? KGDPFKIPPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	[DataMember(Name = "LinkParameter")]
	public string? NKMHBJGOMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string? IDJDPAKAPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OCLJGDALIEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public abstract class MMNEEGEIPCD : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	[IgnoreDataMember]
	public string? KMNEOCCONEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void CEEOKKGGIIE();

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x74C7F00", Offset = "0x74C6700", VA = "0x1874C7F00")]
	protected MMNEEGEIPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[JHLCFIPIAOM]
public class OAGHPGHLDBJ : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? NDDPEADFJGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OAGHPGHLDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[JHLCFIPIAOM]
public class HNCGKICCLBP : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	internal static Func<string, AJBAEFGOOID>? PFCCEJCFMEH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	internal static Func<string, BEBFAMHPBMK>? FGFLJAOLJKE;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string? NDDPEADFJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public string? BMKOCFDNFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool FCONOPBKLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public BLIFBLCKHPP JDHKDCEDHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
		[CompilerGenerated]
		get
		{
			return default(BLIFBLCKHPP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public DMGJGGMGIKH MLGLCILPNPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(DMGJGGMGIKH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public int EKKGHIIFODE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xCF4D80", Offset = "0xCF3580", VA = "0x180CF4D80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x14C02F0", Offset = "0x14BEAF0", VA = "0x1814C02F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime GMEDNGJBNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D360", Offset = "0xA2BB60", VA = "0x180A2D360")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[DataMember(Name = "IsRead")]
	internal bool ENFDCKGGJJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xE4BC70", Offset = "0xE4A470", VA = "0x180E4BC70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xE4B5D0", Offset = "0xE49DD0", VA = "0x180E4B5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	[IgnoreDataMember]
	public bool DOGHPIHGBAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x13AF740", Offset = "0x13ADF40", VA = "0x1813AF740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x13AF400", Offset = "0x13ADC00", VA = "0x1813AF400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public JCPLFJJHNDA NIIEKDGBPEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA46F40", Offset = "0xA45740", VA = "0x180A46F40")]
		[CompilerGenerated]
		get
		{
			return default(JCPLFJJHNDA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x156DA90", Offset = "0x156C290", VA = "0x18156DA90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public NAMPGLAGOFP CCLEEEDIIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC75DA0", VA = "0x180C775A0")]
		[CompilerGenerated]
		get
		{
			return default(NAMPGLAGOFP);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xEB9080", Offset = "0xEB7880", VA = "0x180EB9080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	internal string? PFFCNDABPFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	[IgnoreDataMember]
	public AJBAEFGOOID? HEMIPJOAFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x74C4B70", Offset = "0x74C3370", VA = "0x1874C4B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	[IgnoreDataMember]
	public BEBFAMHPBMK? AOBIOOCGKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x74C4F10", Offset = "0x74C3710", VA = "0x1874C4F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	[IgnoreDataMember]
	public MMNEEGEIPCD? GPPAIFHAEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x74C4BF0", Offset = "0x74C33F0", VA = "0x1874C4BF0", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0xA534A0", Offset = "0xA51CA0", VA = "0x180A534A0")]
	public HNCGKICCLBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[JHLCFIPIAOM]
public class OCBNOLIEPPL : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public BHCIMCCJLHA LIMNOPJBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(BHCIMCCJLHA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public string AAMCEOGHKKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public int JCBIIDIINHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x74C9700", Offset = "0x74C7F00", VA = "0x1874C9700")]
	public OCBNOLIEPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[JHLCFIPIAOM]
public class BEBFAMHPBMK : MMNEEGEIPCD
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string BLEGDBJIHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public string? NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public JNNHLHBALIA DECDKLECEJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(JNNHLHBALIA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	[DataMember(Name = "all_conditions_required")]
	public bool LECIEAKBNLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1685B20", Offset = "0x1684320", VA = "0x181685B20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0xF5B280", Offset = "0xF59A80", VA = "0x180F5B280")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public List<OCBNOLIEPPL> DPICKAEHGLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x74C0370", Offset = "0x74BEB70", VA = "0x1874C0370", Slot = "5")]
	public override void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x74C0380", Offset = "0x74BEB80", VA = "0x1874C0380")]
	public BEBFAMHPBMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum NAMPGLAGOFP
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum JCPLFJJHNDA
{
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum JNNHLHBALIA
{
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum BHCIMCCJLHA
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	EnteredRoom = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	TimeInRoom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	ObjectInteractionRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	ObjectPlaceStartedRoom = 4
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OGCPCMCKPMH
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	bool CGCIMFOFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	LBOAOFAOKMM<HNCGKICCLBP> LOPFAPPMLJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	LBOAOFAOKMM<string> FHEHMHKBAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	LBOAOFAOKMM<HNCGKICCLBP> POPPJEBGIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	LBOAOFAOKMM<HNCGKICCLBP> CEKFDLDLPCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<HNCGKICCLBP> LKLCKIHANEC(JCPLFJJHNDA EMCANDPJKPB);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HNCGKICCLBP> GNBNEFIOHIH(JCPLFJJHNDA EMCANDPJKPB);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HNCGKICCLBP IDIEAMIKKGA(JCPLFJJHNDA EMCANDPJKPB, string CBOEBACJFKC);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HNCGKICCLBP DAABFCKGGJD(JCPLFJJHNDA EMCANDPJKPB);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OBJECPAMFGM(JCPLFJJHNDA EMCANDPJKPB);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CEMOLONMLFL(JCPLFJJHNDA EMCANDPJKPB);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task IHJKCKCNDBO();

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task NEIDFOLOOAD(HNCGKICCLBP ILBALOOKKCP);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface AGKENCJENIJ
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	GEGDLMNEJFE LELONELFCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	int HHJIEBOHOLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool PCACJJNOFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool ODENHKOBAOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool FLENGFEKMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool FJJOLMGOEAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool HDBOOJCNBGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool PHFEPPKOFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	bool EEPLNFHIKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MEMGBPBNPOM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action MDAMGBIIDDC;

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "13")]
	BFIFKPBFBML<OJOHBAGDGLP> EGIDFLGJBBM(int DJKBOHPOLAF);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FKGMEHDMFDF OCPCFLPFOFH(DateTime LHCLGLHGHOO);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "15")]
	FKGMEHDMFDF OAGEDPMLFHE(string KNIABCNBPEN);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task LAMIMFCPMLE([Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum ECMMPMMCJDJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class FMMFNLGLMDG
{
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x74C2B20", Offset = "0x74C1320", VA = "0x1874C2B20")]
	public static string MOGCODECBMN(this ECMMPMMCJDJ LBEBHDKFJMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface MJCCEJBICLL
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<HNCGKICCLBP>> FMJCHOBKDDJ(JCPLFJJHNDA EMCANDPJKPB);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task NEIDFOLOOAD(string CBOEBACJFKC);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface LCFCJPONBEP
{
	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CMEGLJGBJEI> BNCPJBNCCCP();
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface IDJGEOAKOGJ
{
	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFIFKPBFBML<List<IJJPCADILNA>> CPCNPNDMALE();

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFIFKPBFBML<List<IJJPCADILNA>> OMFPDFPABHM();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<IJJPCADILNA>> GAMAPPBNKJH([Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BFIFKPBFBML<List<IJJPCADILNA>> NILONLGDFEL(List<OOLKLJDECHH> DOJBKHKONDL);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BFIFKPBFBML<List<IJJPCADILNA>> OEEPJJKMPJJ(List<OOLKLJDECHH> DOJBKHKONDL);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface DCLKEJLJDPN
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	List<DEFMBGIMAIE> GDAONMKIPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<LPHNGGDHPGM> JLGNGANKHON;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FKGMEHDMFDF GIPFCOCBHFF(DEFMBGIMAIE PLCAJAONHMH);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	BFIFKPBFBML<DEFMBGIMAIE> CFJLFFJKFPP(BBENDLFLDLL MJAGIMDGJBK, BBENDLFLDLL? FJJKHGKDOMD, bool DPLAMMENOPC, string ILBALOOKKCP);

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BFIFKPBFBML<DEFMBGIMAIE> CFJLFFJKFPP(BBENDLFLDLL MJAGIMDGJBK, string ILBALOOKKCP);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ILHMAIAELDG(DEFMBGIMAIE JJKAFIOHDNL, bool DMNBIOPBKHP = false, bool JHLLIBBGPMM = false, bool EMPPJBBBAEO = true);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BFIFKPBFBML<List<DEFMBGIMAIE>> LBKKLDCOCLO();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface DIKNNKELHNM
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	string JPAHELBKMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	bool DMPCJNJBMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKGMEHDMFDF ACGEJOCPFLK();

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKGMEHDMFDF FNCEGGNCLDB(string NBBMJLJFOAF, string HBJONDIFLEN);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKGMEHDMFDF NPIMEODKFCL(string PNNGOEMPCOJ);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KIBIEMMPJJI();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<NLNHCIHINLB> MABCAPBKDON(string KNIABCNBPEN, string PNNGOEMPCOJ, bool ABNKHMKDMJM, string AOJNLAIGBGE, string OAOBKPLNLAF, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task KLMLAIGANCL(int DJKBOHPOLAF, string PMMNELGEMDB, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task MHAJPKKCHBH(int DJKBOHPOLAF, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task GGDFGNLFBON([Optional] ECMMPMMCJDJ? LPECAGGKBGH, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<AFOMKJEGGBJ>> HBKBMIOCNLH([Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task ABPFKPGPNPL([Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface GFJIOEAIOAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<NBIBCJKMEHN>> ADPPDFEKJIH([Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<MFFHIAGOPEF>> HGBBJHOIICB([Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface DMEOPMDEGCF
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PPECPIGKECC([Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFCHMHAIHIL();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface APBEIGJOMHP
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event FJALKEFOJFE? JGCHFPNCIGA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event FJALKEFOJFE? MMNHAJAJFKJ;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event FJALKEFOJFE? HAMMDLOJLOJ;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<GEDBAJICPKM> GHHHAMILOGD();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<GEDBAJICPKM?>? KCPLKCPNIKB(int DJKBOHPOLAF);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<EKBIBJBFPAL>> ENHFFFPKLLA(List<int> DNIMFDGNNPF);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, GEDBAJICPKM>> BHOIONKONKB();

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<GEDBAJICPKM?>?>? ADOONOADPPN(int DJKBOHPOLAF);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task LIGAHBCBOKF(int MPDDLGFNLIA);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<ABCLBNPPLCC> MDFHKKJEHHL(GEDBAJICPKM IOBNNOLBHHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public delegate void FJALKEFOJFE(int DJKBOHPOLAF, int MPDDLGFNLIA, GEDBAJICPKM? IOBNNOLBHHJ);
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface KABJJPFJCMP : ANLGHOMALKK, KBBDCIOHPCC
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[Flags]
	public enum LOGOMCOELOH
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	string KGBMNCPDBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	BCIIKMHHACJ KKABIJDHJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	BLIFBLCKHPP JDHKDCEDHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	string IBOIILNBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	byte NKENBFNDJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	int ALCODFOCFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	int CDFOBHGJEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	bool KJLMDABLDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	bool KNEDJAMLELH
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	bool BKPMOHMBJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	bool BKJBMGDLGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	bool DGELNKILJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool CDNNLEGEBJN
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool NAEKLFEKADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BFIFKPBFBML<string> CIDFIIKLAOH();

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> FGHNINIDDLD();

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BFIFKPBFBML<bool> IsPlayerCommunicationRestricted(int DJKBOHPOLAF);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string FMAMIHHBMGB(string HPANEBBHGAC, bool IEKOFMCPPKN = true);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> HEOIEFCPEFA(string HPANEBBHGAC, bool IEKOFMCPPKN = true);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	BFIFKPBFBML<string> MakeRoomNameAdhereToPlatformRequirements(long GFHIJAKOMMI, string HPANEBBHGAC);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string MNLOIFPJLDE, LOGOMCOELOH EAFMKGPPCME = LOGOMCOELOH.FilterProfanity | LOGOMCOELOH.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string MNLOIFPJLDE, LOGOMCOELOH EAFMKGPPCME = LOGOMCOELOH.FilterProfanity | LOGOMCOELOH.FilterURL, bool ALDAJIHFPDM = false);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string HPANEBBHGAC, LOGOMCOELOH EAFMKGPPCME = LOGOMCOELOH.FilterProfanity | LOGOMCOELOH.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "23")]
	BFIFKPBFBML<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface PKEPFJKFBOE
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<PKFJJPKHGLD>> BDJLKMFFFPN([Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface AMNCKCIIJDM
{
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FJOODEKCMEC(byte[] CEGOJJNEECN, byte[] BKJHDFNANGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface EMMHEAKHFML
{
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DBGICEIDFOE(string NLAEGKCEFPF);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface BOMOPHAJODK
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	LBOAOFAOKMM<BDAEIJHOJDG> FAKOFKPFICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> IPGANKPNACI(string HFBNHIJFJMA);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<PKGCJLAGKGO> MHJIDHJAEDE(string HFBNHIJFJMA, string HNPDAPLFBGN);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EHIGDJAOJED(string HFBNHIJFJMA, IEnumerable<string> BHFFIGGBLJG, int OAPHLLINKIL = 0);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<LBDOGLKEAGE<FilteredTextDTO>>> OOAPHCIEBFH(uint CHLBIGHKFKL, IEnumerable<string> BHFFIGGBLJG);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface LALJEDMFGGA
{
	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BAHJPEIILOD([Out] bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HPLBJBPEJAE([Out] bool MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MAMCIIGHAGP([Out] int MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum NLPNHIMBAEG
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum HIFGMLOLJII
{
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Flags]
public enum GEGOINBLFBH
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[Flags]
public enum IMAOKCKCPNN
{
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum NHABCIGMBEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum CPONOBHAFDN
{
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface OJOHBAGDGLP
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	int NPAGAHHHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	string MPDAHEFPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	string DGGEMLJOLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	string IIJPMJLAJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	string KGMFNOHOOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	string OODINBEOPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	string JNCGPKAAKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	bool GDOLAIBOOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	bool OLLCEMPJKGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	GEGOINBLFBH JCEBAPJCPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	IMAOKCKCPNN CDCNLHEODNG
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	bool? DKCEOENFCBC
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LDJDNJBGFBG(bool NOLHOILEONC);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KCCDELMLLBP(bool IIEMHAKONPH);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public interface GEGDLMNEJFE : OJOHBAGDGLP
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	string HCEEAOKLEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	string LHFBFPEEKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	DateTime? KMBNHFLJMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	NLPNHIMBAEG EJDAOHGLFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	int? IMCADKOOHGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	int IKKAKDEGIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool FGDKLIBDCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	bool EIEGCIIKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	bool? LCKADFPHFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class GOEBNMKKGBN
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public OJOHBAGDGLP FKGOBBCCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public HIFGMLOLJII OPLEICJIDJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(HIFGMLOLJII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public string JBINJHHBDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x6E57E20", Offset = "0x6E56620", VA = "0x186E57E20")]
	public GOEBNMKKGBN(OJOHBAGDGLP CLICGOAAHHN, HIFGMLOLJII GEKJBCGLPKC, string EDGHNEJPKMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface JDPLJIENNLL
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	int NPAGAHHHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	bool MCGKDNJKEID
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface AKGIDLMNDAB
{
	[Cpp2IlInjected.Token(Token = "0x17000115")]
	int NPAGAHHHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	bool JHLICBGLFJM
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface JDLODCCFIFC
{
	[Cpp2IlInjected.Token(Token = "0x17000117")]
	int NPAGAHHHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	string PHMDBHNHJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public enum PKFFGNGIAJB
{
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IJJPCADILNA
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public PKFFGNGIAJB GJONAJHBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(PKFFGNGIAJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public string DAHGILMMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public string MDMGNIALICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public EKPGHFMPAMO EBLNGNKGBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(EKPGHFMPAMO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public string DDFEEALFDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public int ONCPEFHFHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0xDED050", Offset = "0xDEB850", VA = "0x180DED050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool OCPAAPJJOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0xECB7B0", Offset = "0xEC9FB0", VA = "0x180ECB7B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0xECB110", Offset = "0xEC9910", VA = "0x180ECB110")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public OOLKLJDECHH OHJEAPJEBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x13A23E0", Offset = "0x13A0BE0", VA = "0x1813A23E0")]
		[CompilerGenerated]
		get
		{
			return default(OOLKLJDECHH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x74C5330", Offset = "0x74C3B30", VA = "0x1874C5330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public JEDHAPKMNJI AGIKGKONNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x1A57B50", Offset = "0x1A56350", VA = "0x181A57B50")]
		[CompilerGenerated]
		get
		{
			return default(JEDHAPKMNJI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6137920", Offset = "0x6136120", VA = "0x186137920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public string DKEFAKGBEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33860", VA = "0x180A35060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x55BAC30", Offset = "0x55B9430", VA = "0x1855BAC30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x74C5490", Offset = "0x74C3C90", VA = "0x1874C5490")]
	internal IJJPCADILNA(BAHEIOCONFB FIFJIJHJCFG, PEDPMAPKDEC AGFJCDEBIKP, EHFMOIGBMGN NPKAAOKDEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x74C5350", Offset = "0x74C3B50", VA = "0x1874C5350")]
	public IJJPCADILNA(PKFFGNGIAJB JJIPNADJJCJ = PKFFGNGIAJB.Outfit, [Optional] OOLKLJDECHH MFNLJMJPEGB, [Optional] string AHKKKFOPOCC, [Optional] string OIIFFHEFDML, EKPGHFMPAMO KKGBNCGHPOJ = EKPGHFMPAMO.Common, [Optional] string GALPOFMEIKN, int NBHDLEDEAJP = 0, bool CLKPCOKLICH = false, [Optional] string DPLCNMOFGGH, [Optional] DateTime? LAAJICAAGOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[JHLCFIPIAOM]
public class BAHEIOCONFB : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public PKFFGNGIAJB GJONAJHBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(PKFFGNGIAJB);
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	[DataMember(Name = "AvatarItemDesc")]
	public string ENBKOFIHNHC
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public string DAHGILMMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public string MDMGNIALICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public EKPGHFMPAMO EBLNGNKGBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA30050", Offset = "0xA2E850", VA = "0x180A30050")]
		[CompilerGenerated]
		get
		{
			return default(EKPGHFMPAMO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA2FE60", Offset = "0xA2E660", VA = "0x180A2FE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public string DDFEEALFDBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public int ONCPEFHFHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC75DA0", VA = "0x180C775A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xEB9080", Offset = "0xEB7880", VA = "0x180EB9080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public bool OCPAAPJJOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x178BDF0", Offset = "0x178A5F0", VA = "0x18178BDF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x17A0590", Offset = "0x179ED90", VA = "0x1817A0590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public string FPCPHOCADNK
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xECB420", Offset = "0xEC9C20", VA = "0x180ECB420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BAHEIOCONFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[JHLCFIPIAOM]
public sealed class ICANKDKNDHG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public List<string> EAEMMKKCBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x74C4F90", Offset = "0x74C3790", VA = "0x1874C4F90")]
	public ICANKDKNDHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public ICANKDKNDHG(List<string> DOJBKHKONDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[JHLCFIPIAOM]
public class CMEGLJGBJEI : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public AMDGAJAPCEK PEFPAMLBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public IJKEHPKHNKM OHINGMNBBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CMEGLJGBJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public CMEGLJGBJEI(AMDGAJAPCEK POEOFALNMLJ, IJKEHPKHNKM AMEMEGKHPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum KKFJMCAEPNK
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public enum HAFDHOBGCPD : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[JHLCFIPIAOM]
public class AMDGAJAPCEK : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public KKFJMCAEPNK BHMEJGBKIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(KKFJMCAEPNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public HAFDHOBGCPD? GDOEOEKOHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x2F38680", Offset = "0x2F36E80", VA = "0x182F38680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7355130", Offset = "0x7353930", VA = "0x187355130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool CEJHGKGINFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E572F0", Offset = "0x1E55AF0", VA = "0x181E572F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E57470", Offset = "0x1E55C70", VA = "0x181E57470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x74C01D0", Offset = "0x74BE9D0", VA = "0x1874C01D0")]
	public AMDGAJAPCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x74C01E0", Offset = "0x74BE9E0", VA = "0x1874C01E0")]
	public AMDGAJAPCEK(KKFJMCAEPNK ALFJHBGHEBD, HAFDHOBGCPD KLDJPBNIKND, bool OOKADOGCAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[JHLCFIPIAOM]
public class IJKEHPKHNKM : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public string MEOCMPBIDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public string KHCFBNJIHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IJKEHPKHNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public IJKEHPKHNKM(string DAAMKMMHCEJ, string AOFJBKOHJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public enum BCIIKMHHACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct LPHNGGDHPGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public DEFMBGIMAIE MIALNAOOHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public bool NOIIKOIDEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool LFOCDBMLDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public bool BPNPCOGLENE;
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[JHLCFIPIAOM]
public class DEFMBGIMAIE : IBIOIPMKCHN, PEDHEJJFDDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct OBIBFOBNDLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public DEFMBGIMAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x74C9510", Offset = "0x74C7D10", VA = "0x1874C9510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x74C96A0", Offset = "0x74C7EA0", VA = "0x1874C96A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	internal static Action<DEFMBGIMAIE> GFACEOMBFOH;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	internal static Func<DEFMBGIMAIE, Task> GDLJLCOOLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	[IgnoreDataMember]
	public bool FGAJCKEDHJN;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public long? FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public int CFFHLJNFCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public int? NJBDOMEEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x127F160", Offset = "0x127D960", VA = "0x18127F160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xF65EF0", Offset = "0xF646F0", VA = "0x180F65EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public string KCEECFNCIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public PKFFGNGIAJB? GJONAJHBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA30040", Offset = "0xA2E840", VA = "0x180A30040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	[DataMember(Name = "AvatarItemDesc")]
	public string HNIODJFACEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Guid? OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x74C1BD0", Offset = "0x74C03D0", VA = "0x1874C1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x74C1BF0", Offset = "0x74C03F0", VA = "0x1874C1BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public string OHGABCIKPGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public string HMODFDMHCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0xA274A0", Offset = "0xA25CA0", VA = "0x180A274A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public AFALINLHGMI BEGNPCFKFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xA50730", Offset = "0xA4EF30", VA = "0x180A50730")]
		[CompilerGenerated]
		get
		{
			return default(AFALINLHGMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x13E94D0", Offset = "0x13E7CD0", VA = "0x1813E94D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public int MPCOBIBOCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xA50790", Offset = "0xA4EF90", VA = "0x180A50790")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x13E94E0", Offset = "0x13E7CE0", VA = "0x1813E94E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public int HJEDAODIGNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xE433D0", Offset = "0xE41BD0", VA = "0x180E433D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xF45270", Offset = "0xF43A70", VA = "0x180F45270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public BBENDLFLDLL IHKAACAKLAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0xEDDBA0", Offset = "0xEDC3A0", VA = "0x180EDDBA0")]
		[CompilerGenerated]
		get
		{
			return default(BBENDLFLDLL);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x14470D0", Offset = "0x14458D0", VA = "0x1814470D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public EKPGHFMPAMO KHELJLHCKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xC94200", Offset = "0xC92A00", VA = "0x180C94200")]
		[CompilerGenerated]
		get
		{
			return default(EKPGHFMPAMO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x141EEA0", Offset = "0x141D6A0", VA = "0x18141EEA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	[DataMember(Name = "Message")]
	public string PJKCGFFLJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA34F80", Offset = "0xA33780", VA = "0x180A34F80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public string FNAIOOGNDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA8C920", Offset = "0xA8B120", VA = "0x180A8C920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public bool HGLLCOFJMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xECB790", Offset = "0xEC9F90", VA = "0x180ECB790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xECB400", Offset = "0xEC9C00", VA = "0x180ECB400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public BLIFBLCKHPP JDHKDCEDHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xE41E60", Offset = "0xE40660", VA = "0x180E41E60")]
		[CompilerGenerated]
		get
		{
			return default(BLIFBLCKHPP);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xE40A30", Offset = "0xE3F230", VA = "0x180E40A30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public DMGJGGMGIKH EBKGOPGGDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA34F50", Offset = "0xA33750", VA = "0x180A34F50")]
		[CompilerGenerated]
		get
		{
			return default(DMGJGGMGIKH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA350B0", Offset = "0xA338B0", VA = "0x180A350B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public GIECLLHGNOG? JMJIAHHLKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x74C1C00", Offset = "0x74C0400", VA = "0x1874C1C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x74C1A00", Offset = "0x74C0200", VA = "0x1874C1A00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool DJGIFHPJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x74C1A70", Offset = "0x74C0270", VA = "0x1874C1A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool NEHJEMHFEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x74C1AE0", Offset = "0x74C02E0", VA = "0x1874C1AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public bool LKLJEAGGNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x74C1C10", Offset = "0x74C0410", VA = "0x1874C1C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	[IgnoreDataMember]
	public bool JOKDNCGHHBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA2E590", Offset = "0xA2CD90", VA = "0x180A2E590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA2E5B0", Offset = "0xA2CDB0", VA = "0x180A2E5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	[IgnoreDataMember]
	public bool KBFIABEIPGM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2C17090", Offset = "0x2C15890", VA = "0x182C17090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x2C17080", Offset = "0x2C15880", VA = "0x182C17080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	[IgnoreDataMember]
	public string HIEKFLHPGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xEF9690", Offset = "0xEF7E90", VA = "0x180EF9690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	[IgnoreDataMember]
	public string BNAFPPEOPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0xABDC30", Offset = "0xABC430", VA = "0x180ABDC30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0xABDC40", Offset = "0xABC440", VA = "0x180ABDC40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	[IgnoreDataMember]
	public bool KEBKJDIKAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xF77E80", Offset = "0xF76680", VA = "0x180F77E80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xC5AFE0", Offset = "0xC597E0", VA = "0x180C5AFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x74C1A10", Offset = "0x74C0210", VA = "0x1874C1A10", Slot = "5")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x74C1B00", Offset = "0x74C0300", VA = "0x1874C1B00", Slot = "6")]
	[AsyncStateMachine(typeof(OBIBFOBNDLM))]
	public virtual Task GFJMJFDKHCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x14470D0", Offset = "0x14458D0", VA = "0x1814470D0")]
	public void PHKKHBDOEGO(BBENDLFLDLL MJAGIMDGJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DEFMBGIMAIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface LFONGJIIJNI
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	long AMEENNFCBDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	string MEMKEIFLLJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	int AKPIEAJGCFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	string CPHICCODILL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	string PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	byte EIJCNOMMLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	int POIECIHLNIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	int DOPLDHNNNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	LLFJILOKJLH LEJIPMPFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	bool KELCMEPONED
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	DateTime NHJMHLMMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	DateTime? IDKGJFIKNBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	long? GIAIBCLGOFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	int MBBGNOGANEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	int ABNIBAHHLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	int GPHDEOHCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	HAHLEDDAHPJ PMMFBFGOHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	HAHLEDDAHPJ HPFBLGDLJMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	bool ACCLGBLCPLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	bool NBNCOLAKAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	bool LKPMLOCIMOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	bool OJBMFEKJCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	int? JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	bool KCLABLJOLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	string FPEILIMNGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABFGMMHCINC();

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GBKNPMEFEIE();
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[JHLCFIPIAOM]
public class EPEEHKMAFGD : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public List<EOMFEPNODNF> JMPBFKBLJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x74C21B0", Offset = "0x74C09B0", VA = "0x1874C21B0")]
	public List<string> HLPLHONKMFK(params JNLLMNCNLDH[] KFMFKOLAGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x74C2130", Offset = "0x74C0930", VA = "0x1874C2130")]
	public List<string> DNNGBBPFFAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x74C1FF0", Offset = "0x74C07F0", VA = "0x1874C1FF0")]
	public List<string> BGEJJHEEDCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x74C2040", Offset = "0x74C0840", VA = "0x1874C2040", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public EPEEHKMAFGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[JHLCFIPIAOM]
public class LKBLNDNIHNG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public int AKPIEAJGCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LKBLNDNIHNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[JHLCFIPIAOM]
public class INNFJEFIPGG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public long AMEENNFCBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public string MEMKEIFLLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public int BFHKGKFPNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public bool JFKOOJPHOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xD9E700", Offset = "0xD9CF00", VA = "0x180D9E700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xD9E190", Offset = "0xD9C990", VA = "0x180D9E190")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int LFMHINNILDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public int KKGDILHDFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4D80", Offset = "0xCF3580", VA = "0x180CF4D80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x14C02F0", Offset = "0x14BEAF0", VA = "0x1814C02F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int DIMFDHOEPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xA30050", Offset = "0xA2E850", VA = "0x180A30050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0xA2FE60", Offset = "0xA2E660", VA = "0x180A2FE60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public int BFMELDLBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0xA69AA0", Offset = "0xA682A0", VA = "0x180A69AA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0xA692C0", Offset = "0xA67AC0", VA = "0x180A692C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public string PNLCDPCLGLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public string OOPOFLBKFEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x720E320", Offset = "0x720CB20", VA = "0x18720E320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public LLFJILOKJLH? CCGHKOOGEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xECB420", Offset = "0xEC9C20", VA = "0x180ECB420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public IReadOnlyList<Guid> JGLLBLKFPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public DOPHJNOBIJD CBACIGBGNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x74C5AC0", Offset = "0x74C42C0", VA = "0x1874C5AC0")]
		get
		{
			return default(DOPHJNOBIJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x74C57B0", Offset = "0x74C3FB0", VA = "0x1874C57B0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x74C5AB0", Offset = "0x74C42B0", VA = "0x1874C5AB0")]
	public bool NELGIOIGCOE(INNFJEFIPGG MPMMLNOGKFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x74C58D0", Offset = "0x74C40D0", VA = "0x1874C58D0")]
	private bool JOHJOJKNOJC(INNFJEFIPGG MPMMLNOGKFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x74C5830", Offset = "0x74C4030", VA = "0x1874C5830")]
	private static bool GFOOKLAPIGE(IReadOnlyList<Guid> OJDGLOCNBNN, IReadOnlyList<Guid> CJMKKOGCOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x287F5D0", Offset = "0x287DDD0", VA = "0x18287F5D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public INNFJEFIPGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[JHLCFIPIAOM]
public class KMDCFMNENDH : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public int FHNLEBKAPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KMDCFMNENDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[JHLCFIPIAOM]
public class GGOBLLALNLL : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700017F")]
	public bool EGFFLKNGJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GGOBLLALNLL()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[JHLCFIPIAOM]
	public class NewInventionRequestDTO : PEDHEJJFDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public BAMAEEMHEMC creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xF37F00", Offset = "0xF36700", VA = "0x180F37F00", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x74C9480", Offset = "0x74C7C80", VA = "0x1874C9480")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[JHLCFIPIAOM]
	public class AddVersionInventionRequestDTO : PEDHEJJFDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xF37F00", Offset = "0xF36700", VA = "0x180F37F00", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x74C0300", Offset = "0x74BEB00", VA = "0x1874C0300")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[JHLCFIPIAOM]
	public class ModifyTagsRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[JHLCFIPIAOM]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[JHLCFIPIAOM]
	public class ReportRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public MFLHFKPCIHB ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[JHLCFIPIAOM]
	public class CheerRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[JHLCFIPIAOM]
	public class UpdatePriceRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[JHLCFIPIAOM]
	public class UpdateInventionMetadataRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xF37F00", Offset = "0xF36700", VA = "0x180F37F00", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[JHLCFIPIAOM]
	public class UpdateInventionGeneralPermissionRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public HAHLEDDAHPJ Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(HAHLEDDAHPJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[JHLCFIPIAOM]
	public class PublishInventionRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public HAHLEDDAHPJ Permission
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(HAHLEDDAHPJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public LLFJILOKJLH Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
			[CompilerGenerated]
			get
			{
				return default(LLFJILOKJLH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xDF2160", Offset = "0xDF0960", VA = "0x180DF2160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[JHLCFIPIAOM]
	public class UnpublishInventionRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[JHLCFIPIAOM]
	public class DeleteInventionRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[JHLCFIPIAOM]
	public class SetInventionVersionAccessibilityRequest : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public LLFJILOKJLH NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
			[CompilerGenerated]
			get
			{
				return default(LLFJILOKJLH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xDF2160", Offset = "0xDF0960", VA = "0x180DF2160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[JHLCFIPIAOM]
	public class SpecialTags : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum FHBNECKOINJ
{
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum MFLHFKPCIHB
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public enum FOMGKMEAFEN
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	True,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface AFOMKJEGGBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000193")]
	BLIFBLCKHPP JDHKDCEDHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	string IBOIILNBDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	int NPAGAHHHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	DateTime JCGFGHODMEI
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	bool MKBPFNDNFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	string IKGGFJJCKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000199")]
	OJOHBAGDGLP FKGOBBCCEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CEEOKKGGIIE();

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DDLNEAKGBAI(OJOHBAGDGLP CLICGOAAHHN);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface DELGLPMFPIL
{
	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	string IFJLHGMMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	int FFBDFGAGHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	bool FMMPGBAPFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEEOKKGGIIE();
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct NLNHCIHINLB
{
	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public JPKEDCAMNFB BDMKABPIJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(JPKEDCAMNFB);
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public DELGLPMFPIL JCEDPHJGGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xE2A0E0", Offset = "0xE288E0", VA = "0x180E2A0E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public string HKFOKJGBEJA
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7A10", Offset = "0x5EF6210", VA = "0x185EF7A10")]
	public NLNHCIHINLB(JPKEDCAMNFB ANJMMNAPMHH, [Optional] DELGLPMFPIL GLGLCAEGCDK, [Optional] string OAOBKPLNLAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public enum JPKEDCAMNFB
{
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[JHLCFIPIAOM]
public class NBIBCJKMEHN : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public string HIBNPNFEJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public string GJPBNNIMHMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public string KNLHODAHDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public string GMGFKAFBFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public List<NAFDKPNJHOF> LAPOMJNDGKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NBIBCJKMEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x4BF3DD0", Offset = "0x4BF25D0", VA = "0x184BF3DD0")]
	public NBIBCJKMEHN([Optional] string ICOAFANOIFH, [Optional] string MDJNHOLLJEE, [Optional] string MLDHHHHCDCI, [Optional] string PMCBOGGOFJL, [Optional] List<NAFDKPNJHOF> LHHLJIJDPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[JHLCFIPIAOM]
public class NAFDKPNJHOF : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string NKBHKFLDAPF
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string GMGFKAFBFLC
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NAFDKPNJHOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[JHLCFIPIAOM]
public class MFFHIAGOPEF : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string GJPBNNIMHMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string BDMKABPIJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public string HIBNPNFEJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public List<string> KHGPOBCOKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MFFHIAGOPEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[JHLCFIPIAOM]
public interface PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEEOKKGGIIE();
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[JHLCFIPIAOM]
public interface IBIOIPMKCHN : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GFJMJFDKHCF();
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[IEECPPJDGEM]
public interface AICPEBEDDBF : PEDHEJJFDDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[JHLCFIPIAOM]
public class HMDMHEDBGEA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public int IKMAIEDBJHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string EBLEGNKPGJB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public string DHKICPGFJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HMDMHEDBGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x74C4B00", Offset = "0x74C3300", VA = "0x1874C4B00")]
	public HMDMHEDBGEA([Optional] Guid FLLEHMEKPHP, int BHONCPBICBN = 0, [Optional] string KNIIPMFAJIP, [Optional] string CEPPENKPBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[JHLCFIPIAOM]
public class GEDBAJICPKM : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public const int OJJPMJLHFFO = 0;

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public long MEMDBHBHBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public MFPAOKMPONF FNJPKGPHBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public string MDOEEMDCPLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public List<HMDMHEDBGEA> HBNCNPEGJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public int CINNANFKMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA30050", Offset = "0xA2E850", VA = "0x180A30050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2FE60", Offset = "0xA2E660", VA = "0x180A2FE60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public LLFJILOKJLH LEJIPMPFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC75DA0", VA = "0x180C775A0")]
		[CompilerGenerated]
		get
		{
			return default(LLFJILOKJLH);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xEB9080", Offset = "0xEB7880", VA = "0x180EB9080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public string NOLHECGNCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public bool CMKGAAOADFH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1F18B00", Offset = "0x1F17300", VA = "0x181F18B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x74C3520", Offset = "0x74C1D20", VA = "0x1874C3520")]
	public GEDBAJICPKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x74C3400", Offset = "0x74C1C00", VA = "0x1874C3400")]
	public GEDBAJICPKM(long EMAMGKJEJNC = 0L, [Optional] MFPAOKMPONF GEIPOLEJIKO, [Optional] string CKAPFCMHBPM, [Optional] List<HMDMHEDBGEA> HJHKOGGEAGJ, int MPDDLGFNLIA = 0, [Optional] string HPANEBBHGAC, LLFJILOKJLH JAIHGHAJIFE = LLFJILOKJLH.Private, [Optional] string PIDEMFNHJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class EKBIBJBFPAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public readonly int NPAGAHHHPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public readonly GEDBAJICPKM JIIBJGEMODB;

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xF4EE80", Offset = "0xF4D680", VA = "0x180F4EE80")]
	public EKBIBJBFPAL(int DJKBOHPOLAF, GEDBAJICPKM IOBNNOLBHHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[JHLCFIPIAOM]
public class MFPAOKMPONF : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public string GLCDEDBCGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string JMIGMNHBALK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public string EGMAGDFEBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string DPKFCHEAMNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public string JFMJFDLJIHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public string HBNCNPEGJEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x74C7570", Offset = "0x74C5D70", VA = "0x1874C7570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MFPAOKMPONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x4BF3DD0", Offset = "0x4BF25D0", VA = "0x184BF3DD0")]
	public MFPAOKMPONF([Optional] string IFDCLAMIOCF, [Optional] string ACCJFCAACBH, [Optional] string LMGOPANNLGC, [Optional] string BCPDIPOOKFD, [Optional] string JBDOCKGBBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[JHLCFIPIAOM]
public class LCBIMPOLMDG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public Dictionary<int, GEDBAJICPKM> HOMCNPNGJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LCBIMPOLMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[JHLCFIPIAOM]
public class MLKMIOEPCJG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public List<int> FDIADAJDDGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public byte? NKENBFNDJFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F0D0", Offset = "0x2F1D8D0", VA = "0x182F1F0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2F1F0C0", Offset = "0x2F1D8C0", VA = "0x182F1F0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	public int? ALCODFOCFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x127F150", Offset = "0x127D950", VA = "0x18127F150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x127F180", Offset = "0x127D980", VA = "0x18127F180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MLKMIOEPCJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class ILJFHCDFIEH
{
	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x74C5740", Offset = "0x74C3F40", VA = "0x1874C5740")]
	public static EPFGOPKFNIC BJBPNHIAPLM(this HMDMHEDBGEA DKBBJFIDEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
[Flags]
public enum DMGJGGMGIKH
{
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public enum BLIFBLCKHPP
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[JHLCFIPIAOM]
public class GDIAGMILAGG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	[DataMember(Name = "PlayerId")]
	public int NPAGAHHHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public int ALHPCMAIBOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0xABDC60", Offset = "0xABC460", VA = "0x180ABDC60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public int FGJAPPGIGJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GDIAGMILAGG()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[JHLCFIPIAOM]
	public class ProgressionEventRecordDTO : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public int NPAGAHHHPCC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public int HJEDAODIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xABDC60", Offset = "0xABC460", VA = "0x180ABDC60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public int PKMKMKPHOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public int NEGEMINIIBF
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xDF2160", Offset = "0xDF0960", VA = "0x180DF2160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public int HKMAMKHNHJH
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public DateTime? GMGNMLKJDOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x139CFD0", Offset = "0x139B7D0", VA = "0x18139CFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x139CFE0", Offset = "0x139B7E0", VA = "0x18139CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public int GKNFEFMFJCP
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xDED050", Offset = "0xDEB850", VA = "0x180DED050")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x74C9D20", Offset = "0x74C8520", VA = "0x1874C9D20")]
		public ProgressionEventRecordDTO(int DJKBOHPOLAF = 0, int AEKHPBBDJOA = 0, int LGJHCKLEKBA = 0, int DAEBENPKGAK = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[JHLCFIPIAOM]
	public class ProgressionEventDTO : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public long LHGDNMEJKLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public string NCBGIDALPJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public List<ProgressionEventRewardDTO> MBIMFJMPLOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public List<KeepsakeRoomListDTO> MKHAFKBGILL
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public DateTime JLAOLBCBCOG
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D360", Offset = "0xA2BB60", VA = "0x180A2D360")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public DateTime GOJDDCAGPAN
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0xA30040", Offset = "0xA2E840", VA = "0x180A30040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public DateTime GEJGAKDCFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xECAA70", Offset = "0xEC9270", VA = "0x180ECAA70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public bool HHELMLNMGOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xC9B980", Offset = "0xC9A180", VA = "0x180C9B980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xCCFEA0", Offset = "0xCCE6A0", VA = "0x180CCFEA0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public int DPKFGGICOEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x1446190", Offset = "0x1444990", VA = "0x181446190")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x20E2E80", Offset = "0x20E1680", VA = "0x1820E2E80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public float MOJABOJJDNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x1122AE0", Offset = "0x11212E0", VA = "0x181122AE0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x143F2B0", Offset = "0x143DAB0", VA = "0x18143F2B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public Guid? GCNLFIMGLNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x74C9C40", Offset = "0x74C8440", VA = "0x1874C9C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x74C9C60", Offset = "0x74C8460", VA = "0x1874C9C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public string NEAOLDHJAGD
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xA274A0", Offset = "0xA25CA0", VA = "0x180A274A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public string LLLCOPGGJIP
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xA274D0", Offset = "0xA25CD0", VA = "0x180A274D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public string KHMNMMJIGKG
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xA35000", Offset = "0xA33800", VA = "0x180A35000")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public string OBGINLHEAGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33860", VA = "0x180A35060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x74C9C70", Offset = "0x74C8470", VA = "0x1874C9C70")]
		public ProgressionEventDTO(long CNNKDELNHGM = 0L, [Optional] string HPANEBBHGAC, [Optional] List<ProgressionEventRewardDTO> JJLNDBNLKIA, [Optional] List<KeepsakeRoomListDTO> NLADALOBDPJ, [Optional] DateTime CJPPNNPCEBH, [Optional] DateTime FHGOCKAFABF, [Optional] DateTime KCEEBNPLGND, bool DNBIAEPLLBF = false, int CFEAPICOAMM = 0, float KGLDCEDENHI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[JHLCFIPIAOM]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public long MKBBFMEDOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public long LHGDNMEJKLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public int? EAMKKPANAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public int? EIHOMMNPPGH
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4E0", Offset = "0xA2BCE0", VA = "0x180A2D4E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public long? PJFDOJJOCAH
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0xE57E50", Offset = "0xE56650", VA = "0x180E57E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xE58A80", Offset = "0xE57280", VA = "0x180E58A80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long GNJJJEDBGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xECAA70", Offset = "0xEC9270", VA = "0x180ECAA70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public TimeSpan JKEBGPAGOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x74C62C0", Offset = "0x74C4AC0", VA = "0x1874C62C0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public long OKBPFCBHJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x720E320", Offset = "0x720CB20", VA = "0x18720E320")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public TimeSpan ALABMBAELKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x74C6270", Offset = "0x74C4A70", VA = "0x1874C6270")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public int OOHMIHFNADE
		{
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0xDC47B0", Offset = "0xDC2FB0", VA = "0x180DC47B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0xF00910", Offset = "0xEFF110", VA = "0x180F00910")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public EGMDPNLNOOL MIEEGNIIBEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x1155FA0", Offset = "0x11547A0", VA = "0x181155FA0")]
			[CompilerGenerated]
			get
			{
				return default(EGMDPNLNOOL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x2296D50", Offset = "0x2295550", VA = "0x182296D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public List<KeepsakeRoomDTO> ADFCKDGPNEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x74C6310", Offset = "0x74C4B10", VA = "0x1874C6310")]
		public KeepsakeRoomListDTO(long JDGNBHJADFG = 0L, long CNNKDELNHGM = 0L, [Optional] int? IHIOLOOEDMP, [Optional] int? KFIJBJMHLED, [Optional] long? HEFBCGPFIBC, long OBPGLPKKJKD = 0L, long PNMMEFAOKFL = 0L, int DLKILENOLLO = 0, EGMDPNLNOOL KGGPLKLMBJH = EGMDPNLNOOL.Standard, [Optional] List<KeepsakeRoomDTO> BGPEFAOPBKK)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[JHLCFIPIAOM]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public long IEMKHNBHGBM
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public long OKEIHPDKJML
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public long MKBBFMEDOLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public EGMDPNLNOOL PBNBGAHIAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
			[CompilerGenerated]
			get
			{
				return default(EGMDPNLNOOL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public int PMDGMDMJLCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xCF4D80", Offset = "0xCF3580", VA = "0x180CF4D80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x14C02F0", Offset = "0x14BEAF0", VA = "0x1814C02F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x74C6210", Offset = "0x74C4A10", VA = "0x1874C6210")]
		public KeepsakeRoomDTO(long DONEDEOBDFF = 0L, long GFHIJAKOMMI = 0L, long JDGNBHJADFG = 0L, EGMDPNLNOOL CEPGAJKBPDM = EGMDPNLNOOL.Standard, int FCNCCILAAHD = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[JHLCFIPIAOM]
	public class ProgressionEventRewardDTO : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public long APCGFNNAMCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public int NJENDCCABGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public string PJEGNFPPICA
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public int HJEDAODIGNB
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public int AEDLEHJHGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4D80", Offset = "0xCF3580", VA = "0x180CF4D80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x14C02F0", Offset = "0x14BEAF0", VA = "0x1814C02F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public bool GDDNKDJBICB
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xA56260", Offset = "0xA54A60", VA = "0x180A56260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xA56080", Offset = "0xA54880", VA = "0x180A56080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public bool FJFMIADGFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xE32F80", Offset = "0xE31780", VA = "0x180E32F80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x13EED50", Offset = "0x13ED550", VA = "0x1813EED50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[JHLCFIPIAOM]
	public class ProgressionEventPurchasableXpBoostDTO : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public Guid IIPEKIHEMIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public int OLGIDFPAPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public int JKJHOENFNDK
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public int PLDBCFKHDJC
		{
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public long KFKFIGOEGEI
		{
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000460")]
			[Cpp2IlInjected.Address(RVA = "0xA2D360", Offset = "0xA2BB60", VA = "0x180A2D360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public long JFJOJDAAEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA30040", Offset = "0xA2E840", VA = "0x180A30040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum EGMDPNLNOOL
{
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public enum FENEICOAGDP
{
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[JHLCFIPIAOM]
public class PKFJJPKHGLD : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	public string IAKMDBPEPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	public string? NNNDNNKFBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PKFJJPKHGLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface DMFOFLICLDP
{
	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	bool BNFFGAJIILO
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	string? DIBMEAPKENB
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	string? CDJHDEFJKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public interface CKIDGNDCKKJ<T> : DMFOFLICLDP
{
	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class LFFDDBDDFCD
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA4950", Offset = "0x3AA3150", VA = "0x183AA4950")]
	public static CKIDGNDCKKJ<T> GNOACPCNCKE<T, U>(this CKIDGNDCKKJ<U> KJCFPPKBAOB, Func<U, T> EIJALANKPLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct CHHPDDODNHG<T> : CKIDGNDCKKJ<T>, DMFOFLICLDP
{
	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public bool BNFFGAJIILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0xF79A70", Offset = "0xF78270", VA = "0x180F79A70", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x2AA99A0", Offset = "0x2AA81A0", VA = "0x182AA99A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public string? DIBMEAPKENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xE2A210", Offset = "0xE28A10", VA = "0x180E2A210", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xE2A0E0", Offset = "0xE288E0", VA = "0x180E2A0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	public string? CDJHDEFJKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	public T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x66A2280", Offset = "0x66A0A80", VA = "0x1866A2280")]
	public static CHHPDDODNHG<T> HMKNLNAIJEF(T MGONBEDEDON)
	{
		return default(CHHPDDODNHG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x66A21C0", Offset = "0x66A09C0", VA = "0x1866A21C0")]
	public static CHHPDDODNHG<T> DCAPDILODIC(string MEBFHJECJFA, string HGCNLLFLOKJ = "")
	{
		return default(CHHPDDODNHG<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[JHLCFIPIAOM]
public class ABCLBNPPLCC : DMFOFLICLDP, PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	public bool BNFFGAJIILO
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000204")]
	public string? DIBMEAPKENB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000205")]
	[DataMember(Name = "error_id")]
	public string? CDJHDEFJKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "8")]
	public virtual void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x74BF850", Offset = "0x74BE050", VA = "0x1874BF850")]
	public static ABCLBNPPLCC HMKNLNAIJEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x74BF7C0", Offset = "0x74BDFC0", VA = "0x1874BF7C0")]
	public static ABCLBNPPLCC DCAPDILODIC(string MEBFHJECJFA, string HGCNLLFLOKJ = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ABCLBNPPLCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[IGCAMPCEACD]
public abstract class KBEFGPMPCJE<T> : ABCLBNPPLCC, CKIDGNDCKKJ<T>, DMFOFLICLDP
{
	[Cpp2IlInjected.Token(Token = "0x17000206")]
	public T HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8CCF0", VA = "0x180A8E4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
	protected KBEFGPMPCJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[IGCAMPCEACD]
public class NCJCBPMDFKP<T> : KBEFGPMPCJE<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x55A79E0", Offset = "0x55A61E0", VA = "0x1855A79E0")]
	private static void FBOCBCNMKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x4665B70", Offset = "0x4664370", VA = "0x184665B70")]
	public NCJCBPMDFKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[IGCAMPCEACD]
public class LBDOGLKEAGE<T> : KBEFGPMPCJE<T>, IBIOIPMKCHN, PEDHEJJFDDO where T : PEDHEJJFDDO, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct AKAAMJCHGIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public LBDOGLKEAGE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x4D25AE0", Offset = "0x4D242E0", VA = "0x184D25AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x4D25D60", Offset = "0x4D24560", VA = "0x184D25D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5264B00", Offset = "0x5263300", VA = "0x185264B00", Slot = "8")]
	public override void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5264CF0", Offset = "0x52634F0", VA = "0x185264CF0", Slot = "10")]
	[AsyncStateMachine(typeof(LBDOGLKEAGE<>.AKAAMJCHGIF))]
	public Task GFJMJFDKHCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5264DC0", Offset = "0x52635C0", VA = "0x185264DC0")]
	public static LBDOGLKEAGE<T> HMKNLNAIJEF(T MGONBEDEDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5264B90", Offset = "0x5263390", VA = "0x185264B90")]
	public new static LBDOGLKEAGE<T> DCAPDILODIC(string MEBFHJECJFA, string HGCNLLFLOKJ = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4D0E3E0", Offset = "0x4D0CBE0", VA = "0x184D0E3E0")]
	public LBDOGLKEAGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[IGCAMPCEACD]
public class HJFAKFNLDFN<T> : KBEFGPMPCJE<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x4665B70", Offset = "0x4664370", VA = "0x184665B70")]
	public HJFAKFNLDFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[IGCAMPCEACD]
public class ALPLDHLEFOH<T> : KBEFGPMPCJE<List<T>>, IBIOIPMKCHN, PEDHEJJFDDO where T : PEDHEJJFDDO, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct CCMEDPPFNPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public ALPLDHLEFOH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6691930", Offset = "0x6690130", VA = "0x186691930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x6691B40", Offset = "0x6690340", VA = "0x186691B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x4E347A0", Offset = "0x4E32FA0", VA = "0x184E347A0")]
	public static ALPLDHLEFOH<T> HMKNLNAIJEF(List<T> MGONBEDEDON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x4E34570", Offset = "0x4E32D70", VA = "0x184E34570")]
	public new static ALPLDHLEFOH<T> DCAPDILODIC(string MEBFHJECJFA, string HGCNLLFLOKJ = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x4E342F0", Offset = "0x4E32AF0", VA = "0x184E342F0", Slot = "8")]
	public override void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x4E346D0", Offset = "0x4E32ED0", VA = "0x184E346D0", Slot = "10")]
	[AsyncStateMachine(typeof(ALPLDHLEFOH<>.CCMEDPPFNPD))]
	public Task GFJMJFDKHCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x4E348F0", Offset = "0x4E330F0", VA = "0x184E348F0")]
	public ALPLDHLEFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public enum MJENNKHCNLM
{
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002C0")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class MKGBAOIIDIF
{
	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x74C7D20", Offset = "0x74C6520", VA = "0x1874C7D20")]
	public static bool IAFMGCNCOII(this MJENNKHCNLM OAGNIFCCHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x74C7D20", Offset = "0x74C6520", VA = "0x1874C7D20")]
	public static bool EJGFOEOMNLC(this MJENNKHCNLM OAGNIFCCHFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum AFALINLHGMI
{
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	ProgressionEvent = 400
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum GIECLLHGNOG
{
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	NonPurchasedEarnedByP2Pv2 = 1001
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum BBENDLFLDLL
{
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum EKPGHFMPAMO
{
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public enum KBBBLGAOJOB
{
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[JHLCFIPIAOM]
	public class BalanceResponseDTO : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public AFALINLHGMI CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(AFALINLHGMI);
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[DataMember(Name = "Platform")]
		public GIECLLHGNOG BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
			[CompilerGenerated]
			get
			{
				return default(GIECLLHGNOG);
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0xDF2160", Offset = "0xDF0960", VA = "0x180DF2160")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
		public virtual void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[JHLCFIPIAOM]
	public class FilteredTextDTO : PEDHEJJFDDO
	{
		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		public string IFJLHGMMCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public int HEGLFAIJKCE
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
		public void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[JHLCFIPIAOM]
public class GOLMNHOAKHA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	public string EFEEJJJHLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	public string NJIABIKGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GOLMNHOAKHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[JHLCFIPIAOM]
public class PKGCJLAGKGO : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public List<GOLMNHOAKHA> BABBLDMJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PKGCJLAGKGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[JHLCFIPIAOM]
public class CIFHOCGKMGC : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	public string EDLLFEIKAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public CIFHOCGKMGC(string IBOMDCFDACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[JHLCFIPIAOM]
public class ANMCANBDMME : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000210")]
	public List<GOLMNHOAKHA> BABBLDMJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ANMCANBDMME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[JHLCFIPIAOM]
public class BFPKEMJDKBF : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public List<CIFHOCGKMGC> EGGHAEEAHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public string KIJEHIKHJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public bool NIJGGDDPLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public int NEHNHHPFHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BFPKEMJDKBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x74C0440", Offset = "0x74BEC40", VA = "0x1874C0440")]
	public BFPKEMJDKBF(string HFBNHIJFJMA, List<CIFHOCGKMGC> BHFFIGGBLJG, bool DDODCLBLLKD, int OAPHLLINKIL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[JHLCFIPIAOM]
public class BCJNEIIFIGA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public List<ANMCANBDMME> DFHNDBBLLCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public bool NIJGGDDPLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0xA34760", Offset = "0xA32F60", VA = "0x180A34760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BCJNEIIFIGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[JHLCFIPIAOM]
public class BDAEIJHOJDG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public enum GHGDANODEND
	{
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public const string AMANICFPHMP = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public string KIJEHIKHJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public GHGDANODEND BDMKABPIJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(GHGDANODEND);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x74C0310", Offset = "0x74BEB10", VA = "0x1874C0310")]
	public BDAEIJHOJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x74C0320", Offset = "0x74BEB20", VA = "0x1874C0320")]
	public BDAEIJHOJDG(string HFBNHIJFJMA, GHGDANODEND ANJMMNAPMHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[JHLCFIPIAOM]
public class OEGAFGIGINH : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public bool MJIPAKEJEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OEGAFGIGINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class JLCALMMIAHB
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum CEJMBAOJDBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[JHLCFIPIAOM]
public class FJDBNLBKOBI : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public Guid AGGMDGLCHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0xE57670", Offset = "0xE55E70", VA = "0x180E57670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public long BNFLJGACAHE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4E0", Offset = "0xA2BCE0", VA = "0x180A2D4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public NGKLCBHNDME MLBGBODEHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FJDBNLBKOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x74C2AC0", Offset = "0x74C12C0", VA = "0x1874C2AC0")]
	public FJDBNLBKOBI(long GFHIJAKOMMI, Guid EMJGCACMNPC, long LMIFGKAMFNG, NGKLCBHNDME ANEAEODOJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x74C2AA0", Offset = "0x74C12A0", VA = "0x1874C2AA0", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[JHLCFIPIAOM]
public class OAIPONKLIIO : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public LDODJIJKDBL EOJDHIBJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(LDODJIJKDBL);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public GABLDAGFLGO NPJLPFPMJGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OAIPONKLIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0xF4EE80", Offset = "0xF4D680", VA = "0x180F4EE80")]
	public OAIPONKLIIO(LDODJIJKDBL KJCFPPKBAOB, GABLDAGFLGO JJIBICBENEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[JHLCFIPIAOM]
public class NGKLCBHNDME : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public Guid? IEFDJGPDBMO
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x2EFC2F0", Offset = "0x2EFAAF0", VA = "0x182EFC2F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x74C87A0", Offset = "0x74C6FA0", VA = "0x1874C87A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public Guid JBAGMGMNINI
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0xDC47C0", Offset = "0xDC2FC0", VA = "0x180DC47C0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xF8F3E0", Offset = "0xF8DBE0", VA = "0x180F8F3E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NGKLCBHNDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x74C87B0", Offset = "0x74C6FB0", VA = "0x1874C87B0")]
	public NGKLCBHNDME(Guid? CGEOMHHCBBF, Guid LFFJGJOGOKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[JHLCFIPIAOM]
public class GABLDAGFLGO : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public Guid AGGMDGLCHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0xE57670", Offset = "0xE55E70", VA = "0x180E57670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public long JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4E0", Offset = "0xA2BCE0", VA = "0x180A2D4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public Guid NMLOAIIBEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0xE57E50", Offset = "0xE56650", VA = "0x180E57E50")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0xE58A80", Offset = "0xE57280", VA = "0x180E58A80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0xECAA70", Offset = "0xEC9270", VA = "0x180ECAA70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public DateTime NHJMHLMMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x720E320", Offset = "0x720CB20", VA = "0x18720E320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GABLDAGFLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[JHLCFIPIAOM]
public class HFKOECAENLF : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public string PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public List<long> OLCJFMKDJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public List<LONEAGELCCG> AFHOLFJPNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public string PILGCCKNCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public byte? HCCHEFMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x74C4AC0", Offset = "0x74C32C0", VA = "0x1874C4AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x74C4AD0", Offset = "0x74C32D0", VA = "0x1874C4AD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public int? BINFICANAKK
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x74C39D0", Offset = "0x74C21D0", VA = "0x1874C39D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x74C39C0", Offset = "0x74C21C0", VA = "0x1874C39C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public Guid? ADNFLDDPOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x74C4AE0", Offset = "0x74C32E0", VA = "0x1874C4AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x74C4AB0", Offset = "0x74C32B0", VA = "0x1874C4AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public bool KCBHONMFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4B0", Offset = "0xA2BCB0", VA = "0x180A2D4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA2D490", Offset = "0xA2BC90", VA = "0x180A2D490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HFKOECAENLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[JHLCFIPIAOM]
public class DHLKILNGPGH : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public Guid ADNFLDDPOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public string PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xECAA70", Offset = "0xEC9270", VA = "0x180ECAA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public DateTime NHJMHLMMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x720E320", Offset = "0x720CB20", VA = "0x18720E320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public string PILGCCKNCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public List<long> OLCJFMKDJPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public List<KJIFACFAEFJ> AFHOLFJPNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public byte HCCHEFMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xA927A0", Offset = "0xA90FA0", VA = "0x180A927A0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x12F6330", Offset = "0x12F4B30", VA = "0x1812F6330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public int BINFICANAKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0xA5F4C0", Offset = "0xA5DCC0", VA = "0x180A5F4C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x13E9D10", Offset = "0x13E8510", VA = "0x1813E9D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DHLKILNGPGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public enum LDODJIJKDBL
{
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B2")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003B3")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003B4")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B5")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003B6")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public interface IHFNECFEEKD
{
	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KBEFGPMPCJE<DHLKILNGPGH>> CBHCAOBLLID(Guid? LOEJBFFHLNB, long GFHIJAKOMMI, string HPANEBBHGAC, string LLAMBGFCPPC, string FLCIMENMGDL, string JJENKKPLDMA, byte GOMGOEKJPBC, int BIKIHAKPCIG, [Optional] List<long> JCMELIGOMOI, [Optional] List<KJIFACFAEFJ> LINGPMCBKFF, bool DGBBFPCCGCI = false, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KBEFGPMPCJE<DHLKILNGPGH>> NBBGEFIMBOO(Guid EMJGCACMNPC, long GFHIJAKOMMI, [Optional] string HPANEBBHGAC, [Optional] string LLAMBGFCPPC, [Optional] string FLCIMENMGDL, [Optional] List<long> JCMELIGOMOI, [Optional] Dictionary<string, string> LINGPMCBKFF, [Optional] string JJENKKPLDMA, [Optional] byte? GOMGOEKJPBC, [Optional] int? BIKIHAKPCIG, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ABCLBNPPLCC> GAOKCDACOBC(Guid EMJGCACMNPC, long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<DHLKILNGPGH>> PNIIJKNICBD(long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<GABLDAGFLGO>> BNKPFHGGMAP(long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<OAIPONKLIIO>> DDLDICCMPII(long GFHIJAKOMMI, List<FJDBNLBKOBI> IGDPJPHPMIJ, [Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[JHLCFIPIAOM]
public class LONEAGELCCG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public string PILGCCKNCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LONEAGELCCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[JHLCFIPIAOM]
public class KJIFACFAEFJ : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public long GPFADHNCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public string PILGCCKNCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public KJIFACFAEFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[JHLCFIPIAOM]
public class DCFGKONAJKN : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public long GPFADHNCCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public string PILGCCKNCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x4BF8850", Offset = "0x4BF7050", VA = "0x184BF8850")]
	public DCFGKONAJKN(long GFEINMOMPEO, string JKBGANBHBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public interface KPEHBIOMMLA
{
	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KBEFGPMPCJE<List<KJIFACFAEFJ>>> JFPEIEIBIFI(long GFHIJAKOMMI, List<DCFGKONAJKN> IGDPJPHPMIJ, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ABCLBNPPLCC> FKHELGOAKJH(long GFEINMOMPEO, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<KJIFACFAEFJ>> GDGBBFCGFEK(long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[JHLCFIPIAOM]
public class NIEAHGKNELA : NCLLJDMGMFF, IEquatable<NIEAHGKNELA>
{
	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x74C8670", Offset = "0x74C6E70", VA = "0x1874C8670", Slot = "7")]
	public bool Equals(NIEAHGKNELA KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x74C8800", Offset = "0x74C7000", VA = "0x1874C8800", Slot = "6")]
	public override NCLLJDMGMFF FGIKHGILDDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NIEAHGKNELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class MJBMCKIFMPI
{
	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x74C7BB0", Offset = "0x74C63B0", VA = "0x1874C7BB0")]
	public static NIEAHGKNELA BLEGDBJIHDD(this CJENCPGHKCL NAGJHHJDFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x74C7C20", Offset = "0x74C6420", VA = "0x1874C7C20")]
	public static NIEAHGKNELA ECGKFGLHAIM(string BAEGKMPMDMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[JHLCFIPIAOM]
public class CJENCPGHKCL : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public const int HBJGFKAECAC = 3;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public const int MIFAAEHKDNC = 40;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public const int PGHFADOLNEB = 180;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public const int JHMLOMLOOAM = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public const int EPFKBBALCLL = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	public const int KFMCFKGALOC = 8;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	public const int INBBGKOPEFN = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	public const int DJPNFGDDOMA = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	public const int PEDLOMJKOIB = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? NICLNFLMOMJ;

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public Guid ADNFLDDPOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public string? HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public string? PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public int JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC75DA0", VA = "0x180C775A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xEB9080", Offset = "0xEB7880", VA = "0x180EB9080")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public Guid? OILEMGLGBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x74C1470", Offset = "0x74BFC70", VA = "0x1874C1470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x74C10D0", Offset = "0x74BF8D0", VA = "0x1874C10D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xA877D0", Offset = "0xA85FD0", VA = "0x180A877D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xDF7400", Offset = "0xDF5C00", VA = "0x180DF7400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public int? MMFAPLDDFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7D50", Offset = "0x6EE6550", VA = "0x186EE7D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7D70", Offset = "0x6EE6570", VA = "0x186EE7D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public int? MCJDLLFFMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x74C10C0", Offset = "0x74BF8C0", VA = "0x1874C10C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x74C1500", Offset = "0x74BFD00", VA = "0x1874C1500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	public IReadOnlyList<IKLKKEOCGHN> ODMJDEOHBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xA274D0", Offset = "0xA25CD0", VA = "0x180A274D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xEE4A10", Offset = "0xEE3210", VA = "0x180EE4A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public DateTime NHJMHLMMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0xEE4F00", Offset = "0xEE3700", VA = "0x180EE4F00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	[IgnoreDataMember]
	public CEIOGMEMBOM HBMPCDLPBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x74C1490", Offset = "0x74BFC90", VA = "0x1874C1490")]
		get
		{
			return default(CEIOGMEMBOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> KHLEJOPIPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x74C1420", Offset = "0x74BFC20", VA = "0x1874C1420")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0xA34F80", Offset = "0xA33780", VA = "0x180A34F80")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x74C10E0", Offset = "0x74BF8E0", VA = "0x1874C10E0", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CJENCPGHKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x74C1510", Offset = "0x74BFD10", VA = "0x1874C1510")]
	public CJENCPGHKCL(Guid LOEJBFFHLNB, long GFHIJAKOMMI, string HPANEBBHGAC, string LLAMBGFCPPC, string FLCIMENMGDL, int BIALCILCFBL, int? INOIADMIMOJ, int? BONOJMAHGOL, List<IKLKKEOCGHN> CAJDKOFKMOE, [Optional] DateTime LAAJICAAGOG, [Optional] DateTime ADJGAEEKAAD, [Optional] Guid? FIPBDCAOKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x74C13B0", Offset = "0x74BFBB0", VA = "0x1874C13B0")]
	private CEIOGMEMBOM LIPGIAFCFCD()
	{
		return default(CEIOGMEMBOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x74C10F0", Offset = "0x74BF8F0", VA = "0x1874C10F0")]
	private Dictionary<Guid, int> GOFEEGDJIKC(IReadOnlyList<IKLKKEOCGHN> CAJDKOFKMOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[JHLCFIPIAOM]
public class DPPJIKNBIMI : PEDHEJJFDDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	public Guid ADNFLDDPOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	public long OKEIHPDKJML;

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DPPJIKNBIMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[JHLCFIPIAOM]
public class NKACAKEBBNH : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public string? HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public string? PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public int JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public int? MMFAPLDDFAK
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x127F140", Offset = "0x127D940", VA = "0x18127F140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x127F170", Offset = "0x127D970", VA = "0x18127F170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	public int? MCJDLLFFMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xD35E00", Offset = "0xD34600", VA = "0x180D35E00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xD35E50", Offset = "0xD34650", VA = "0x180D35E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public List<IKLKKEOCGHN> ODMJDEOHBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public Guid? EBCGCADIECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x74C1BD0", Offset = "0x74C03D0", VA = "0x1874C1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x74C1BF0", Offset = "0x74C03F0", VA = "0x1874C1BF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public Guid? ADNFLDDPOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x74C8920", Offset = "0x74C7120", VA = "0x1874C8920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x74C8910", Offset = "0x74C7110", VA = "0x1874C8910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public bool KCBHONMFGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xDC2EA0", Offset = "0xDC16A0", VA = "0x180DC2EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xF06CE0", Offset = "0xF054E0", VA = "0x180F06CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x74C8900", Offset = "0x74C7100", VA = "0x1874C8900", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NKACAKEBBNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[JHLCFIPIAOM]
public class IKLKKEOCGHN : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public JOELEJJNDFI BIDBIMCCNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
		[CompilerGenerated]
		get
		{
			return default(JOELEJJNDFI);
		}
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public Guid IJOKFFEADNI
	{
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x19CE970", Offset = "0x19CD170", VA = "0x1819CE970")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x5AE18D0", Offset = "0x5AE00D0", VA = "0x185AE18D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public int JAJBNKBAONK
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IKLKKEOCGHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x74C56F0", Offset = "0x74C3EF0", VA = "0x1874C56F0")]
	public IKLKKEOCGHN(Guid JJFFHHPPPIB, JOELEJJNDFI CEPGAJKBPDM, int FMGALNGIOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[JHLCFIPIAOM]
public class OCIONGJHJCB : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public Guid KKIADPJKBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public int HCDMMKLFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public DateTime EFLPDKDMKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xA2D360", Offset = "0xA2BB60", VA = "0x180A2D360")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xDED050", Offset = "0xDEB850", VA = "0x180DED050")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x74C9750", Offset = "0x74C7F50", VA = "0x1874C9750")]
	public OCIONGJHJCB(Guid NDKAGDDHHMA, string HPANEBBHGAC, int PMEEOMMGPOJ, DateTime LIMHELJHABJ, int EHCBHNLMEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OCIONGJHJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[JHLCFIPIAOM]
public class HDBLDOMEOMG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public Guid KKIADPJKBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0xDC5290", Offset = "0xDC3A90", VA = "0x180DC5290")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0xDC52A0", Offset = "0xDC3AA0", VA = "0x180DC52A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public int PCBHENHFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HDBLDOMEOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x4752A30", Offset = "0x4751230", VA = "0x184752A30")]
	public HDBLDOMEOMG(Guid NDKAGDDHHMA, int FLOLIIFCANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[JHLCFIPIAOM]
public class GFEDMCFGKGA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public int PCBHENHFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public Guid LCBKKBDGJIN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x19CE970", Offset = "0x19CD170", VA = "0x1819CE970")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x5AE18D0", Offset = "0x5AE00D0", VA = "0x185AE18D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public int DHEFKEPNJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public Guid? ODPLHPBEEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xEF4C30", Offset = "0xEF3430", VA = "0x180EF4C30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x228B630", Offset = "0x2289E30", VA = "0x18228B630")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public int JLFAACKJKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA46F40", Offset = "0xA45740", VA = "0x180A46F40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x156DA90", Offset = "0x156C290", VA = "0x18156DA90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public Dictionary<Guid, Guid?> KBEGGHLCMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GFEDMCFGKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x74C39E0", Offset = "0x74C21E0", VA = "0x1874C39E0")]
	public GFEDMCFGKGA(int FLOLIIFCANP, Guid IKKEHMBLONJ, int LEAJHMAMIBK, Guid? MJABHOKPOMJ, int IOKOFFCJLME, Dictionary<Guid, Guid?> JLOAHJLALCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
[JHLCFIPIAOM]
public class CGAPFFNHJNI : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public OAFHOPCBMLG DGOMJCCKOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9A0", Offset = "0xA9D1A0", VA = "0x180A9E9A0")]
		[CompilerGenerated]
		get
		{
			return default(OAFHOPCBMLG);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0xA9E9B0", Offset = "0xA9D1B0", VA = "0x180A9E9B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public KBBBLGAOJOB? JEMGJAGHIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x1262950", Offset = "0x1261150", VA = "0x181262950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x1288E50", Offset = "0x1287650", VA = "0x181288E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public BalanceResponseDTO AEOAPNGMBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public List<GABLDAGFLGO> NHNJDKDIFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CGAPFFNHJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x74C1050", Offset = "0x74BF850", VA = "0x1874C1050")]
	public CGAPFFNHJNI(OAFHOPCBMLG EJALJBBIOLJ, KBBBLGAOJOB? LPMGMDPOMIM, BalanceResponseDTO NFAJOPIMPEB, List<GABLDAGFLGO> NHEEOMKGNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x74C1040", Offset = "0x74BF840", VA = "0x1874C1040", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public enum JOELEJJNDFI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public enum OAFHOPCBMLG : byte
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
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public enum CEIOGMEMBOM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400040D")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400040E")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x400040F")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
public interface CKIHFLNIBIM
{
	[Cpp2IlInjected.Token(Token = "0x4000410")]
	static LBOAOFAOKMM<CJENCPGHKCL> NFGHJLJEODI;

	[Cpp2IlInjected.Token(Token = "0x4000411")]
	static LBOAOFAOKMM<CJENCPGHKCL> AOJJAMDHKCP;

	[Cpp2IlInjected.Token(Token = "0x4000412")]
	static LBOAOFAOKMM<Guid> OEMEKLNHDMJ;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KBEFGPMPCJE<CJENCPGHKCL?>?>? AGIJOOBMBFH(Guid? LOEJBFFHLNB, long GFHIJAKOMMI, string HPANEBBHGAC, string? LLAMBGFCPPC, string? FLCIMENMGDL, int BIALCILCFBL, CEIOGMEMBOM FAHKMFNKDCA, [Optional] Dictionary<Guid, int>? GFHKKGNJCKD, [Optional] Guid? IFDGEOCAELE, bool DGBBFPCCGCI = false, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KBEFGPMPCJE<CJENCPGHKCL?>?>? JGOPNKDFHPC(Guid NDKAGDDHHMA, long GFHIJAKOMMI, string HPANEBBHGAC, string? LLAMBGFCPPC, string? FLCIMENMGDL, int BIALCILCFBL, CEIOGMEMBOM FAHKMFNKDCA, [Optional] Dictionary<Guid, int>? GFHKKGNJCKD, [Optional] Guid? IFDGEOCAELE, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ABCLBNPPLCC> NGKAADBIPKL(Guid NDKAGDDHHMA, long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<CJENCPGHKCL>> MHOEOEHNLCD(long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<KBEFGPMPCJE<List<HDBLDOMEOMG>>> DEEJLFLFPDN(long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<KBEFGPMPCJE<List<OCIONGJHJCB>>> DDPDGHPJEEM(long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<CGAPFFNHJNI> KDBIMFLLLPI(Guid NDKAGDDHHMA, long GFHIJAKOMMI, int FLOLIIFCANP, int LEAJHMAMIBK, Guid? IJBKDPDHBBM, int IOKOFFCJLME, Dictionary<Guid, Guid?> BBIKHOOCPPK, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x74C1790", Offset = "0x74BFF90", VA = "0x1874C1790")]
	static CKIHFLNIBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
[JHLCFIPIAOM]
public class AMFIPIMDGIB : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public long OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public bool NCNNGMPPHDC
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0xA34760", Offset = "0xA32F60", VA = "0x180A34760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public AMFIPIMDGIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public interface JOKINEFBEPP
{
	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<AMFIPIMDGIB> IDGHPHHAKII(long GFHIJAKOMMI, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<ABCLBNPPLCC> NLJGCHOALFB(long GFHIJAKOMMI, bool GABIAEKLNLF, [Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[IGCAMPCEACD]
public class ADEIMAEPCIE<DataType> where DataType : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public long JKIBGNFDKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public AFALINLHGMI BEGNPCFKFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(AFALINLHGMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public GIECLLHGNOG JMJIAHHLKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
		[CompilerGenerated]
		get
		{
			return default(GIECLLHGNOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xDF2160", Offset = "0xDF0960", VA = "0x180DF2160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public DataType KFMKJLCMCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ADEIMAEPCIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
[IGCAMPCEACD]
public class OAPJDEMDIHE<DataType> where DataType : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public long JKIBGNFDKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000279")]
	public AFALINLHGMI BEGNPCFKFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(AFALINLHGMI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027A")]
	public GIECLLHGNOG JMJIAHHLKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
		[CompilerGenerated]
		get
		{
			return default(GIECLLHGNOG);
		}
		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0xDF2160", Offset = "0xDF0960", VA = "0x180DF2160")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700027B")]
	public List<DataType> KFMKJLCMCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OAPJDEMDIHE()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[IGCAMPCEACD]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : PEDHEJJFDDO, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E5")]
		[IGCAMPCEACD]
		public class EKPKBBPPCGN : IBIOIPMKCHN, PEDHEJJFDDO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E6")]
			[CompilerGenerated]
			private struct ODFHICAJOKF : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000420")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000421")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000422")]
				public EKPKBBPPCGN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000423")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005ED")]
				[Cpp2IlInjected.Address(RVA = "0x57289D0", Offset = "0x57271D0", VA = "0x1857289D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005EE")]
				[Cpp2IlInjected.Address(RVA = "0x5728CB0", Offset = "0x57274B0", VA = "0x185728CB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027D")]
			public KBBBLGAOJOB HEJLPNFIFLB
			{
				[Cpp2IlInjected.Token(Token = "0x60005E6")]
				[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
				[CompilerGenerated]
				get
				{
					return default(KBBBLGAOJOB);
				}
				[Cpp2IlInjected.Token(Token = "0x60005E7")]
				[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027E")]
			public DataTypeDTO KFMKJLCMCLK
			{
				[Cpp2IlInjected.Token(Token = "0x60005E8")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005E9")]
				[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x473B920", Offset = "0x473A120", VA = "0x18473B920", Slot = "5")]
			public void CEEOKKGGIIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x473BA20", Offset = "0x473A220", VA = "0x18473BA20", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.EKPKBBPPCGN.ODFHICAJOKF))]
			public Task GFJMJFDKHCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public EKPKBBPPCGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		public List<EKPKBBPPCGN> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x58F8290", Offset = "0x58F6A90", VA = "0x1858F8290", Slot = "5")]
		public override void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[IGCAMPCEACD]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : PEDHEJJFDDO, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[IGCAMPCEACD]
		public class PGENNCGIFIJ : IBIOIPMKCHN, PEDHEJJFDDO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E9")]
			[CompilerGenerated]
			private struct GLJCFMDNHBL : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000427")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000428")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000429")]
				public PGENNCGIFIJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400042A")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005FA")]
				[Cpp2IlInjected.Address(RVA = "0x4CA4B60", Offset = "0x4CA3360", VA = "0x184CA4B60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005FB")]
				[Cpp2IlInjected.Address(RVA = "0x4CA4DE0", Offset = "0x4CA35E0", VA = "0x184CA4DE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000280")]
			public KBBBLGAOJOB HEJLPNFIFLB
			{
				[Cpp2IlInjected.Token(Token = "0x60005F3")]
				[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
				[CompilerGenerated]
				get
				{
					return default(KBBBLGAOJOB);
				}
				[Cpp2IlInjected.Token(Token = "0x60005F4")]
				[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000281")]
			public List<DataTypeDTO> KFMKJLCMCLK
			{
				[Cpp2IlInjected.Token(Token = "0x60005F5")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005F6")]
				[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x58A69B0", Offset = "0x58A51B0", VA = "0x1858A69B0", Slot = "5")]
			public void CEEOKKGGIIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x58A6C60", Offset = "0x58A5460", VA = "0x1858A6C60", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.PGENNCGIFIJ.GLJCFMDNHBL))]
			public Task GFJMJFDKHCF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public PGENNCGIFIJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		public List<PGENNCGIFIJ> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x58F8290", Offset = "0x58F6A90", VA = "0x1858F8290", Slot = "5")]
		public override void CEEOKKGGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[NMNPGLEPPFM]
public class GKMDLCMKIOI : PurchaseBalanceUpdateResponseDTO<DEFMBGIMAIE>
{
	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x74C3A60", Offset = "0x74C2260", VA = "0x1874C3A60")]
	public GKMDLCMKIOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[NMNPGLEPPFM]
public class NOJEIBFCAMH : PurchaseBalanceUpdateResponseDTO<DEFMBGIMAIE>.PGENNCGIFIJ
{
	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x74C9140", Offset = "0x74C7940", VA = "0x1874C9140")]
	public NOJEIBFCAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[JHLCFIPIAOM]
public class KCLBKEJFNLP : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public FFOPFKAFAOL MNJAPHBMJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public long FNCBDNNJJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000284")]
	public GiftItemDTO? IGLKFICFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000285")]
	public long? COJEJHAGCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x139CFD0", Offset = "0x139B7D0", VA = "0x18139CFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x139CFE0", Offset = "0x139B7E0", VA = "0x18139CFE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000286")]
	public int AHKODKDNHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xDED050", Offset = "0xDEB850", VA = "0x180DED050")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x74C5E90", Offset = "0x74C4690", VA = "0x1874C5E90")]
	public KCLBKEJFNLP(FFOPFKAFAOL NJMICHLHIEE, long DAOMOCCAFDN, GiftItemDTO? PLCAJAONHMH, int HFJDLKNNLHA = 1, [Optional] long? FBLGJDILBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[JHLCFIPIAOM]
public class MMIEOCPIEFE : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000287")]
	public List<KCLBKEJFNLP> FCAJDADHEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000288")]
	public ANEPECIFGOK? CPAPACFPHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000289")]
	public AFALINLHGMI BEGNPCFKFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(AFALINLHGMI);
		}
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public bool BFDJJFKBCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xD9E700", Offset = "0xD9CF00", VA = "0x180D9E700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xD9E190", Offset = "0xD9C990", VA = "0x180D9E190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028B")]
	public bool JKLFBJGIPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x1448F70", Offset = "0x1447770", VA = "0x181448F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x271D190", Offset = "0x271B990", VA = "0x18271D190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x74C7DA0", Offset = "0x74C65A0", VA = "0x1874C7DA0")]
	public MMIEOCPIEFE(List<KCLBKEJFNLP> JGEOKCLPGON, ANEPECIFGOK? AEFPEPBMHMM, AFALINLHGMI BMLDAGLDFMB, bool OOJCJABDDNI, bool KMAMHNPACED = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
[JHLCFIPIAOM]
public class BGJILMKKEPD : IBIOIPMKCHN, PEDHEJJFDDO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct ALGEAHBMICO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public BGJILMKKEPD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x74BFE90", Offset = "0x74BE690", VA = "0x1874BFE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x74C0170", Offset = "0x74BE970", VA = "0x1874C0170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000435")]
	internal static Action<DEFMBGIMAIE>? FICCAEBPONA;

	[Cpp2IlInjected.Token(Token = "0x4000436")]
	internal static Func<DEFMBGIMAIE, Task>? HJKNMHCILHC;

	[Cpp2IlInjected.Token(Token = "0x1700028C")]
	public DEFMBGIMAIE MIALNAOOHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028D")]
	public GFAGOKJKJAJ? PBNHNOGAEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000619")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x74C0520", Offset = "0x74BED20", VA = "0x1874C0520", Slot = "5")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x74C05E0", Offset = "0x74BEDE0", VA = "0x1874C05E0", Slot = "6")]
	[AsyncStateMachine(typeof(ALGEAHBMICO))]
	public virtual Task GFJMJFDKHCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BGJILMKKEPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[NMNPGLEPPFM]
public class FFOFMBJKKII : BalanceUpdateResponseDTO<BGJILMKKEPD>
{
	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x74C2770", Offset = "0x74C0F70", VA = "0x1874C2770")]
	public FFOFMBJKKII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
[NMNPGLEPPFM]
public class BNJKGCBMOBN : BalanceUpdateResponseDTO<BGJILMKKEPD>.EKPKBBPPCGN
{
	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x74C0800", Offset = "0x74BF000", VA = "0x1874C0800")]
	public BNJKGCBMOBN()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[JHLCFIPIAOM]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000622")]
			[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000623")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000624")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public BBENDLFLDLL GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7F0", Offset = "0xA8CFF0", VA = "0x180A8E7F0")]
			[CompilerGenerated]
			get
			{
				return default(BBENDLFLDLL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0xF60F70", Offset = "0xF5F770", VA = "0x180F60F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[JHLCFIPIAOM]
public class IFBALPNNAHD : PEDHEJJFDDO, MPAEOKMMPNG
{
	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public MAMOBBNLCDL? LJKIKBJHLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	[IgnoreDataMember]
	public Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x74C52B0", Offset = "0x74C3AB0", VA = "0x1874C52B0", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public FFOPFKAFAOL? BEJMMOBBBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public List<IEIFNOIIDFI>? EIBLHMPCGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public DateTime? ODDEHEBNGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x139CFD0", Offset = "0x139B7D0", VA = "0x18139CFD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x139CFE0", Offset = "0x139B7E0", VA = "0x18139CFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public DateTime? COBOILPHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x143F200", Offset = "0x143DA00", VA = "0x18143F200", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x143F920", Offset = "0x143E120", VA = "0x18143F920")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	public DateTime? HHPPBFKONFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xDC2EE0", Offset = "0xDC16E0", VA = "0x180DC2EE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x5ADDFC0", Offset = "0x5ADC7C0", VA = "0x185ADDFC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000299")]
	public bool GCNNPELOONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xC84660", Offset = "0xC82E60", VA = "0x180C84660", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0xC839B0", Offset = "0xC821B0", VA = "0x180C839B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public bool GGKDJKHHJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x1128190", Offset = "0x1126990", VA = "0x181128190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x11281A0", Offset = "0x11269A0", VA = "0x1811281A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	public bool FGPIDMBKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xF3FE80", Offset = "0xF3E680", VA = "0x180F3FE80", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x1645970", Offset = "0x1644170", VA = "0x181645970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public bool ODEEKCPENKG
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xF3A530", Offset = "0xF38D30", VA = "0x180F3A530", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xF3F470", Offset = "0xF3DC70", VA = "0x180F3F470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x74C5070", Offset = "0x74C3870", VA = "0x1874C5070")]
	public static IFBALPNNAHD FOHDJOPEDDE(Guid FLLEHMEKPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IFBALPNNAHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[JHLCFIPIAOM]
public class BKIOKLDCPAK
{
	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public int MOHDHMLGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public string AAOCHNPDNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public string CNMKLMBPKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public Dictionary<int, EBMJIBEJOBM> CABMKOIKIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public Dictionary<string, int> OOLDPIPNGNE
	{
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public Dictionary<KJDCGFFBFEA, List<int>> CFFCOMACNAN
	{
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public Dictionary<string, string> BJONPKICLMH
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BKIOKLDCPAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public enum KJDCGFFBFEA
{
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x4000455")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x4000456")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[JHLCFIPIAOM]
public class EBMJIBEJOBM : CCJACIBFIHO
{
	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public DMGJGGMGIKH LFBDGIMLKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(DMGJGGMGIKH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public bool KMDGCNJKPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x11A4EE0", Offset = "0x11A36E0", VA = "0x1811A4EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x143EA80", Offset = "0x143D280", VA = "0x18143EA80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public bool LONBPOLGKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x1E57460", Offset = "0x1E55C60", VA = "0x181E57460")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x1E57300", Offset = "0x1E55B00", VA = "0x181E57300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public string BDOIOIMIMMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public string JEJMENLPEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public string IPPIHNDLDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	public string CKHDCHLCJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	public Dictionary<BLIFBLCKHPP, string> JMLOKDFMNGD
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x143EAD0", Offset = "0x143D2D0", VA = "0x18143EAD0")]
	public EBMJIBEJOBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
[JHLCFIPIAOM]
public class DFEFEEAPOEJ : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	public IReadOnlyList<MAMOBBNLCDL>? IHAGFPBDNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DFEFEEAPOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public DFEFEEAPOEJ(IReadOnlyList<MAMOBBNLCDL>? BOEAPDJBBNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public enum AHNEIMADPDH
{
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface MPAEOKMMPNG
{
	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	FFOPFKAFAOL? BEJMMOBBBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	List<IEIFNOIIDFI>? EIBLHMPCGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	DateTime? ODDEHEBNGJB
	{
		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	DateTime? COBOILPHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	DateTime? HHPPBFKONFI
	{
		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	bool GCNNPELOONI
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	bool FGPIDMBKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	bool ODEEKCPENKG
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface IKFCAHNDGPK
{
	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action JKDBGINDIDL;

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task HDGCPCCCMFD(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task NJBILJPIDKH(CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LFNCEKEMKHC([Out] JJLPGONINDO LDCOIJIBFHA);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface JJLPGONINDO
{
	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	string AAOCHNPDNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	string CNMKLMBPKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	IReadOnlyDictionary<KJDCGFFBFEA, IReadOnlyList<CCJACIBFIHO>> KKNOFDNJBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	IReadOnlyDictionary<string, string> BJONPKICLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface CCJACIBFIHO
{
	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	string JEJMENLPEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	string BDOIOIMIMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	string IPPIHNDLDDB
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	string CKHDCHLCJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public interface PNBLFFBKHJH
{
	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	EGEILCJOOBK BIDBIMCCNBH
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	string FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	string DAHGILMMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	string IDNEOOEEEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	bool ODEEKCPENKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	bool FGPIDMBKILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	EKPGHFMPAMO EBLNGNKGBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	string KCEECFNCIGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	PKFFGNGIAJB? GJONAJHBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	AHNEIMADPDH MICNHHPCKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	bool HPGKFEDFCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
[JHLCFIPIAOM]
public class FFOPFKAFAOL : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	public EGEILCJOOBK PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(EGEILCJOOBK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	public int? KMKLEFAIGFE
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x1262950", Offset = "0x1261150", VA = "0x181262950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x1288E50", Offset = "0x1287650", VA = "0x181288E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	public Guid? JNDDENACFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xA34EF0", Offset = "0xA336F0", VA = "0x180A34EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xA34F70", Offset = "0xA33770", VA = "0x180A34F70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x74C2870", Offset = "0x74C1070", VA = "0x1874C2870")]
	public static FFOPFKAFAOL CAPIMFOFMCC(int MCFDLOCHDBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x74C27B0", Offset = "0x74C0FB0", VA = "0x1874C27B0")]
	public static FFOPFKAFAOL BGIOHGPCIED(Guid FLLEHMEKPHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FFOPFKAFAOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public enum EGEILCJOOBK
{
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[JHLCFIPIAOM]
public class IEIFNOIIDFI : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	public AFALINLHGMI BEGNPCFKFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(AFALINLHGMI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	public int JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xABDC60", Offset = "0xABC460", VA = "0x180ABDC60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	public BNNNKMHLGPM GNNLJBDAGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0xF37F00", Offset = "0xF36700", VA = "0x180F37F00", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x74C5020", Offset = "0x74C3820", VA = "0x1874C5020")]
	public int KKEMGFGDBOF(DateTime FGCHOBJOEME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public IEIFNOIIDFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[JHLCFIPIAOM]
public class BNNNKMHLGPM : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	public int ONJDKNCJPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	public DateTime? HGIBLMJKKLA
	{
		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0xE57670", Offset = "0xE55E70", VA = "0x180E57670")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public DateTime? IOMLDBPDOHH
	{
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x139CFD0", Offset = "0x139B7D0", VA = "0x18139CFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x139CFE0", Offset = "0x139B7E0", VA = "0x18139CFE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x74C0840", Offset = "0x74BF040", VA = "0x1874C0840")]
	public bool AKBAAOKLBJK(DateTime FGCHOBJOEME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x74C0930", Offset = "0x74BF130", VA = "0x1874C0930")]
	public int BOHELIIBGDN(DateTime FGCHOBJOEME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x74C0960", Offset = "0x74BF160", VA = "0x1874C0960")]
	public TimeSpan? EDJCFPAFNIO(DateTime FGCHOBJOEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BNNNKMHLGPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum ANEPECIFGOK
{
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum KBMKJAFCAKI
{
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public enum FAHKIPDJEOD
{
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum IPPFKKGEIAK
{
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004D8")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public enum MNHNCJJIBCI
{
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
[JHLCFIPIAOM]
public class NOGJOGFCIOC : IEquatable<NOGJOGFCIOC>
{
	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	public int? KLMCCFLMKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public int? FFJAOCAJGHF
	{
		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public int? ADCBGGNKBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0xD35E30", Offset = "0xD34630", VA = "0x180D35E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public List<int>? CIBJHBLBIIK
	{
		[Cpp2IlInjected.Token(Token = "0x60006AC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x74C8FD0", Offset = "0x74C77D0", VA = "0x1874C8FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x74C8940", Offset = "0x74C7140", VA = "0x1874C8940")]
	public static NOGJOGFCIOC EHOHPFINECO(int? LDCIDIJEIHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x74C89A0", Offset = "0x74C71A0", VA = "0x1874C89A0", Slot = "4")]
	public bool Equals(NOGJOGFCIOC? KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x74C8F30", Offset = "0x74C7730", VA = "0x1874C8F30")]
	private static bool OMABLEGFIKK(List<int>? HBMOFOICGEH, List<int>? LDEEDNGKJOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x74C8B20", Offset = "0x74C7320", VA = "0x1874C8B20", Slot = "0")]
	public override bool Equals(object? HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x74C8D50", Offset = "0x74C7550", VA = "0x1874C8D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public NOGJOGFCIOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public struct GNKIJBCJIGH : IEquatable<GNKIJBCJIGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public readonly EGEILCJOOBK BIDBIMCCNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	private readonly int KMKLEFAIGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	private readonly Guid JNDDENACFCO;

	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public Guid OLOFPEPFBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x74C3DC0", Offset = "0x74C25C0", VA = "0x1874C3DC0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public int INPICHNICJN
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x74C47F0", Offset = "0x74C2FF0", VA = "0x1874C47F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public string LCEECBHIGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x74C3E30", Offset = "0x74C2630", VA = "0x1874C3E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x74C40E0", Offset = "0x74C28E0", VA = "0x1874C40E0")]
	public static bool MGMJPBJPHJO(string LMNKBMBBAAB, [Out] GNKIJBCJIGH JPCFFNKBADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x74C4520", Offset = "0x74C2D20", VA = "0x1874C4520")]
	public static bool OAAAKMLGKAB(string IBIFMLLGGOA, [Out] GNKIJBCJIGH JPCFFNKBADP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x74C3C00", Offset = "0x74C2400", VA = "0x1874C3C00")]
	public static GNKIJBCJIGH GENCILEALEI(int EBHOIBHGECB)
	{
		return default(GNKIJBCJIGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x74C3E80", Offset = "0x74C2680", VA = "0x1874C3E80")]
	public static GNKIJBCJIGH JMEIBLGEJJO(Guid EBHOIBHGECB)
	{
		return default(GNKIJBCJIGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x74C3FD0", Offset = "0x74C27D0", VA = "0x1874C3FD0")]
	private static bool LPABHJGHNJP(string LMNKBMBBAAB, [Out] EGEILCJOOBK FAOCHKMMFJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x74C48B0", Offset = "0x74C30B0", VA = "0x1874C48B0")]
	private GNKIJBCJIGH(EGEILCJOOBK FAOCHKMMFJK, int? NOEFKNDFFIN, Guid? FLLEHMEKPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(RVA = "0x74C3B90", Offset = "0x74C2390", VA = "0x1874C3B90", Slot = "4")]
	public bool Equals(GNKIJBCJIGH KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x74C3AA0", Offset = "0x74C22A0", VA = "0x1874C3AA0", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x74C3D30", Offset = "0x74C2530", VA = "0x1874C3D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x74C4800", Offset = "0x74C3000", VA = "0x1874C4800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
[JHLCFIPIAOM]
public abstract class NCLLJDMGMFF : IEquatable<NCLLJDMGMFF>, PEDHEJJFDDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	public Guid OLOLBHBJOCA;

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x74C8730", Offset = "0x74C6F30", VA = "0x1874C8730", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x74C86B0", Offset = "0x74C6EB0", VA = "0x1874C86B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x74C8670", Offset = "0x74C6E70", VA = "0x1874C8670", Slot = "4")]
	public bool Equals(NCLLJDMGMFF KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x74C8560", Offset = "0x74C6D60", VA = "0x1874C8560", Slot = "0")]
	public override bool Equals(object HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract NCLLJDMGMFF FGIKHGILDDC();

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected NCLLJDMGMFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public enum HHOJDCOLFLB
{
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[JHLCFIPIAOM]
public class MAMOBBNLCDL : NCLLJDMGMFF, IEquatable<MAMOBBNLCDL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	public HHOJDCOLFLB FAOCHKMMFJK;

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x74C66A0", Offset = "0x74C4EA0", VA = "0x1874C66A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x74C65B0", Offset = "0x74C4DB0", VA = "0x1874C65B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MAMOBBNLCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x74C6740", Offset = "0x74C4F40", VA = "0x1874C6740")]
	public MAMOBBNLCDL(HHOJDCOLFLB FAOCHKMMFJK, Guid OLOLBHBJOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x74C6630", Offset = "0x74C4E30", VA = "0x1874C6630")]
	public static MAMOBBNLCDL JMEIBLGEJJO(Guid NBHDLEDEAJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x74C64F0", Offset = "0x74C4CF0", VA = "0x1874C64F0", Slot = "7")]
	public bool Equals(MAMOBBNLCDL KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x74C6540", Offset = "0x74C4D40", VA = "0x1874C6540", Slot = "6")]
	public override NCLLJDMGMFF FGIKHGILDDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public static class AJDPDHFBHFI
{
	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x74BFCC0", Offset = "0x74BE4C0", VA = "0x1874BFCC0")]
	public static MAMOBBNLCDL BLEGDBJIHDD(this CJPHBFLPBPE NAGJHHJDFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x74BFD30", Offset = "0x74BE530", VA = "0x1874BFD30")]
	public static MAMOBBNLCDL ECGKFGLHAIM(string NMCOBILDAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x74BFE20", Offset = "0x74BE620", VA = "0x1874BFE20")]
	public static MAMOBBNLCDL ICODEPLILAB(Guid GPOFFOABDHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[JHLCFIPIAOM]
public class CJPHBFLPBPE : AICPEBEDDBF, PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public HHOJDCOLFLB BIDBIMCCNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(HHOJDCOLFLB);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public Guid LJKIKBJHLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x19CE970", Offset = "0x19CD170", VA = "0x1819CE970")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x5AE18D0", Offset = "0x5AE00D0", VA = "0x185AE18D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public string PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public long? OKEIHPDKJML
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xF57F00", Offset = "0xF56700", VA = "0x180F57F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0xF57F20", Offset = "0xF56720", VA = "0x180F57F20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public long JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0xECB420", Offset = "0xEC9C20", VA = "0x180ECB420")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public Guid? JLEKHNEOFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x74C1600", Offset = "0x74BFE00", VA = "0x1874C1600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x74C15F0", Offset = "0x74BFDF0", VA = "0x1874C15F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public DateTime JFMBLFDFDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0xEE4EF0", Offset = "0xEE36F0", VA = "0x180EE4EF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public DateTime NHJMHLMMGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0xEE4A10", Offset = "0xEE3210", VA = "0x180EE4A10")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CJPHBFLPBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x74C16D0", Offset = "0x74BFED0", VA = "0x1874C16D0")]
	public CJPHBFLPBPE(HHOJDCOLFLB FAOCHKMMFJK, Guid OLOLBHBJOCA, [Optional] string HPANEBBHGAC, [Optional] string LLAMBGFCPPC, [Optional] string FLCIMENMGDL, [Optional] long? GFHIJAKOMMI, long BIALCILCFBL = 0L, [Optional] Guid? MJIDKDHKPAH, [Optional] DateTime LAAJICAAGOG, [Optional] DateTime ADJGAEEKAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x74C1620", Offset = "0x74BFE20", VA = "0x1874C1620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public enum JNLLMNCNLDH
{
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public enum ODOJOFAJPLF
{
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x4000505")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000508")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[JHLCFIPIAOM]
public class ABNKOAHBFOA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public ODOJOFAJPLF EOJDHIBJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(ODOJOFAJPLF);
		}
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public List<string> JMPBFKBLJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x74BF8C0", Offset = "0x74BE0C0", VA = "0x1874BF8C0")]
	public string NMLABEJGCBB(int BKGKINCLEHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ABNKOAHBFOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
[JHLCFIPIAOM]
public class EOMFEPNODNF : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public string DBKNDJMEDBI
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public JNLLMNCNLDH PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(JNLLMNCNLDH);
		}
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public EOMFEPNODNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public static class PHBJAGIEPNJ
{
	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public const string NIMOLLCBEED = "costume";

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public const string DHKMDILKMKP = "gadget";

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public const string GKFLKGDOCPA = "holotar";

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public const string DJJJNPCKJGJ = "large";

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public const string MEIAEEDDELN = "medium";

	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public const string PIPHPFMBOFH = "small";

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public const string JCJJFOCOOJK = "sound";

	[Cpp2IlInjected.Token(Token = "0x4000515")]
	public const string KEDACLALPDD = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x4000516")]
	public const string IKGFKILHBMC = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x4000517")]
	public const string ICMFONOHOHO = "r2";

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public static List<string> NNEGMNKKBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x74C99E0", Offset = "0x74C81E0", VA = "0x1874C99E0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
public static class EKFJIBBPBOD
{
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	public const string DFNDAMFMJAH = "beta";

	[Cpp2IlInjected.Token(Token = "0x4000519")]
	public const string FCMKFKHDMHE = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
[JHLCFIPIAOM]
public class PFGHDDLOLBG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	public List<string> DCBPMALDEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public List<string> KLIGMIAEGMB
	{
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public List<string> DDJILLPLIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PFGHDDLOLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public class MCGBIKGCEAD : IEquatable<MCGBIKGCEAD>
{
	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	protected virtual Type PLDOLEHNEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x74C7130", Offset = "0x74C5930", VA = "0x1874C7130", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	public MJENNKHCNLM? GGGIJJLFCEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public HttpMethod? JMFBCEBOLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public string? AMACNDIKCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x74C7460", Offset = "0x74C5C60", VA = "0x1874C7460")]
	public MCGBIKGCEAD(MJENNKHCNLM? GGGIJJLFCEC, HttpMethod? JMFBCEBOLOL, string? AMACNDIKCKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x74C72F0", Offset = "0x74C5AF0", VA = "0x1874C72F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x74C7190", Offset = "0x74C5990", VA = "0x1874C7190", Slot = "6")]
	protected virtual bool PELPJELJNBG(StringBuilder HFDEJHBJMLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(RVA = "0x1134EB0", Offset = "0x11336B0", VA = "0x181134EB0")]
	public static bool BLLMPNNLKNM(MCGBIKGCEAD? JGMKEDMHKEL, MCGBIKGCEAD? IKKHHEDCJKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(RVA = "0x11352B0", Offset = "0x1133AB0", VA = "0x1811352B0")]
	public static bool NALNDDPCEFD(MCGBIKGCEAD? JGMKEDMHKEL, MCGBIKGCEAD? IKKHHEDCJKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x74C6FC0", Offset = "0x74C57C0", VA = "0x1874C6FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(RVA = "0x74C6DA0", Offset = "0x74C55A0", VA = "0x1874C6DA0", Slot = "0")]
	public override bool Equals(object? HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(RVA = "0x74C6E30", Offset = "0x74C5630", VA = "0x1874C6E30", Slot = "7")]
	public virtual bool Equals(MCGBIKGCEAD? KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x74C6CD0", Offset = "0x74C54D0", VA = "0x1874C6CD0", Slot = "8")]
	public virtual MCGBIKGCEAD BJGEOMOCHMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x74C7400", Offset = "0x74C5C00", VA = "0x1874C7400")]
	protected MCGBIKGCEAD(MCGBIKGCEAD JOHDLHFLIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0x74C6D60", Offset = "0x74C5560", VA = "0x1874C6D60")]
	public void EBKFCGEKMKA([Out] MJENNKHCNLM? GGGIJJLFCEC, [Out] HttpMethod? JMFBCEBOLOL, [Out] string? AMACNDIKCKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public class NCFLGNGFBCC : IEquatable<NCFLGNGFBCC>
{
	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	protected virtual Type PLDOLEHNEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x74C82B0", Offset = "0x74C6AB0", VA = "0x1874C82B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public int BMOFHIFEEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	public KCJMDENKILN BCHJGNBLOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460")]
		[CompilerGenerated]
		get
		{
			return default(KCJMDENKILN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xABDC60", Offset = "0xABC460", VA = "0x180ABDC60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0x74C8550", Offset = "0x74C6D50", VA = "0x1874C8550")]
	public NCFLGNGFBCC(int BMOFHIFEEMD, KCJMDENKILN BCHJGNBLOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x74C8440", Offset = "0x74C6C40", VA = "0x1874C8440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(RVA = "0x74C8310", Offset = "0x74C6B10", VA = "0x1874C8310", Slot = "6")]
	protected virtual bool PELPJELJNBG(StringBuilder HFDEJHBJMLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(RVA = "0x1134EB0", Offset = "0x11336B0", VA = "0x181134EB0")]
	public static bool BLLMPNNLKNM(NCFLGNGFBCC? JGMKEDMHKEL, NCFLGNGFBCC? IKKHHEDCJKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x11352B0", Offset = "0x1133AB0", VA = "0x1811352B0")]
	public static bool NALNDDPCEFD(NCFLGNGFBCC? JGMKEDMHKEL, NCFLGNGFBCC? IKKHHEDCJKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x74C81A0", Offset = "0x74C69A0", VA = "0x1874C81A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x74C7FD0", Offset = "0x74C67D0", VA = "0x1874C7FD0", Slot = "0")]
	public override bool Equals(object? HPLLAPMNIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x74C8060", Offset = "0x74C6860", VA = "0x1874C8060", Slot = "7")]
	public virtual bool Equals(NCFLGNGFBCC? KEKEFPAJGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x74C7F50", Offset = "0x74C6750", VA = "0x1874C7F50", Slot = "8")]
	public virtual NCFLGNGFBCC BJGEOMOCHMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0xC23B90", Offset = "0xC22390", VA = "0x180C23B90")]
	protected NCFLGNGFBCC(NCFLGNGFBCC JOHDLHFLIEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x74C7FC0", Offset = "0x74C67C0", VA = "0x1874C7FC0")]
	public void EBKFCGEKMKA([Out] int BMOFHIFEEMD, [Out] KCJMDENKILN BCHJGNBLOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public enum KCJMDENKILN
{
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
public interface BKIFPACIBHN
{
	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<MCGBIKGCEAD, NCFLGNGFBCC> MDHKHLHNDFG();

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNNDBEHJIHO(MCGBIKGCEAD MNMCNOJCKAF, NCFLGNGFBCC AMNCPNDDCLP);

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANBMOGJIDJP(MCGBIKGCEAD MNMCNOJCKAF);

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKHENGADAPJ();

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ADEODANDBGD(MJENNKHCNLM OAGNIFCCHFK, HttpMethod LMGEPDDDDPA, string JIDIKKJJCNC, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[IGCAMPCEACD]
public class DLCKLFEAADK<TResult> where TResult : PEDHEJJFDDO, new()
{
	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	public IReadOnlyList<TResult> BHMCIEMBGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	public long OOGGLPJOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DLCKLFEAADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public enum KKNEHBEBNCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public interface ANLGHOMALKK : KBBDCIOHPCC
{
	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	bool NFFOMNFNJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long IKKEHMBLONJ, JONALFHBJCB IFALKKEBFOC);

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<LONONFMAKPF> PurchaseAsync(JONALFHBJCB IFALKKEBFOC, NOGJOGFCIOC DOPCGMGILLO);

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(KLDFNFNLAIO ECNFMLFPFOB, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public interface KBBDCIOHPCC
{
	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	bool PJGMNKECLAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public interface OGLMBCILCIO
{
	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	int GLPDDCKNLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<JONALFHBJCB>> CMFJDHAPJEP(bool BAPMNAFNHFK = false, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HBGFGOJAOKO([Out] JONALFHBJCB? MGONBEDEDON);

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<JONALFHBJCB> NOMCMMDFGEL(bool BAPMNAFNHFK = false, [Optional] CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOBPBIEPEGB(string BEPEOMJMPKF = "");
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public interface EANBALGOGJE
{
	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JIIBMKCKCLC(KLDFNFNLAIO ECNFMLFPFOB, CancellationToken GMEAHOBHMAD);

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task MGKCBBAOEHE(KLDFNFNLAIO ECNFMLFPFOB, CancellationToken GMEAHOBHMAD, [Optional] HOMABNFCOIN? KAHGHJGLACL);
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public interface HOMABNFCOIN
{
	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHOAOBNGJBG(string HFGOALBMNDM);
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public interface FNFOEKFAAJE
{
	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NOGCDIGCIGL(KLDFNFNLAIO NGLPLBOIMKG, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public interface KBMGOJPMJIK
{
	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	bool HLGMLANKAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public interface OCIKFOHDPNH
{
	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KLDFNFNLAIO IDKIEAODCHH(JONALFHBJCB IFALKKEBFOC, NOGJOGFCIOC DOPCGMGILLO, string BOKGBBAEIFA, [Optional] EANBALGOGJE? AALAGBKMGFN);
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public interface FHODBKHCBKO
{
	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HCNABFAMGOK(FNFOEKFAAJE HHPGBAHCBFC);

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBPAOBMNNIK(FNFOEKFAAJE HHPGBAHCBFC);

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task EDEGCDIGMLK(KLDFNFNLAIO ECNFMLFPFOB, CancellationToken GMEAHOBHMAD);
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public interface KLDFNFNLAIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	LJAHEPLBCNK GGAFCKLCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	JONALFHBJCB MDJHMKKPEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	NOGJOGFCIOC PJFMPNHNJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	string PDCCNMBPNCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	string BAAINOGELGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<BGEGNOKNDEI> BKBBKPBLJPE(CancellationToken DGACCOBPOIM, [Optional] HOMABNFCOIN? KAHGHJGLACL);

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JOJOAILEOMF(string INDBGIPGMPI);

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JOJOAILEOMF<T>(Func<T, string> INDBGIPGMPI, [In] T ILNAEBFPION);
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public abstract class CLDOOIJLFEO
{
	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	protected CLDOOIJLFEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public enum GNJBJHENAHO
{
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
public enum EMPCKAMNHBI : byte
{
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
[JHLCFIPIAOM]
public class JONALFHBJCB : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public int MKIOMINKJOP
	{
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public string HBNKCFMFJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public string PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	public int JNNFIGAAELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0xA30050", Offset = "0xA2E850", VA = "0x180A30050")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0xA2FE60", Offset = "0xA2E660", VA = "0x180A2FE60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public string MOHCNALJLJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public string GLKAHEIGADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	[DataMember(Name = "PsnProductLabel")]
	public string ANGKOPEFFKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public string IKBOKEEABFO
	{
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public string MMFPIEIIHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0xA27500", Offset = "0xA25D00", VA = "0x180A27500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public string PCFMKLGJCJG
	{
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0xA274E0", Offset = "0xA25CE0", VA = "0x180A274E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public string FBOECOMNFNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xA274A0", Offset = "0xA25CA0", VA = "0x180A274A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public string ICBINPBLGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xA274D0", Offset = "0xA25CD0", VA = "0x180A274D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	public bool NBIODHNHCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xCD1980", Offset = "0xCD0180", VA = "0x180CD1980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xCD0E30", Offset = "0xCCF630", VA = "0x180CD0E30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	public bool CHFHIPHGLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x16B2130", Offset = "0x16B0930", VA = "0x1816B2130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x16B2310", Offset = "0x16B0B10", VA = "0x1816B2310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	public GNNEEEBHKOG KFMKJLCMCLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0xA35060", Offset = "0xA33860", VA = "0x180A35060")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	[IgnoreDataMember]
	public string IEDNPIIAMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0xA34F80", Offset = "0xA33780", VA = "0x180A34F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	[IgnoreDataMember]
	public string CPHICCODILL
	{
		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xA8C920", Offset = "0xA8B120", VA = "0x180A8C920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	[IgnoreDataMember]
	public string EFAJIFBLMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0xA35090", Offset = "0xA33890", VA = "0x180A35090")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000310")]
	[IgnoreDataMember]
	public CLDOOIJLFEO PKIAHEKMPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0xEEFE60", Offset = "0xEEE660", VA = "0x180EEFE60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	[IgnoreDataMember]
	public bool BMGPIILJGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x74C5D40", Offset = "0x74C4540", VA = "0x1874C5D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	[IgnoreDataMember]
	public string ENBHKIDEGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0xA2B7E0", Offset = "0xA29FE0", VA = "0x180A2B7E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x74C5C50", Offset = "0x74C4450", VA = "0x1874C5C50", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x74C5D60", Offset = "0x74C4560", VA = "0x1874C5D60")]
	public static JONALFHBJCB IDIOBHGPCCO(int EBHOIBHGECB, string HPANEBBHGAC, string FLCIMENMGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x74C5E00", Offset = "0x74C4600", VA = "0x1874C5E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public JONALFHBJCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
[JHLCFIPIAOM]
public class GNNEEEBHKOG : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public List<int> GNFALJGLOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public string IGFPALBFAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public HAEONMLFJAF CJAAEJLGMLI
	{
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0xF37F00", Offset = "0xF36700", VA = "0x180F37F00", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GNNEEEBHKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012A")]
public readonly struct BGEGNOKNDEI
{
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	public enum FDNMICPDOIA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000559")]
	public readonly FDNMICPDOIA GJFJLFIAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400055A")]
	public readonly EMPCKAMNHBI NAMBPDDEHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	public readonly GNJBJHENAHO KEAAFFCKEBM;

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x74C0510", Offset = "0x74BED10", VA = "0x1874C0510")]
	private BGEGNOKNDEI(FDNMICPDOIA OJGLGPLNKGO, EMPCKAMNHBI ODNIPFJGFOA = EMPCKAMNHBI.Unknown, GNJBJHENAHO OBEOOBLNKMM = GNJBJHENAHO.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x74C04B0", Offset = "0x74BECB0", VA = "0x1874C04B0")]
	public static BGEGNOKNDEI BNFFGAJIILO()
	{
		return default(BGEGNOKNDEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x74C04F0", Offset = "0x74BECF0", VA = "0x1874C04F0")]
	public static BGEGNOKNDEI IGBOELAKDCI()
	{
		return default(BGEGNOKNDEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x74C04D0", Offset = "0x74BECD0", VA = "0x1874C04D0")]
	public static BGEGNOKNDEI DIBMEAPKENB(EMPCKAMNHBI ODNIPFJGFOA, GNJBJHENAHO OBEOOBLNKMM)
	{
		return default(BGEGNOKNDEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public enum BBOKEMGNKNP
{
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
public enum INCMJPNHPGC
{
	[Cpp2IlInjected.Token(Token = "0x4000564")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x4000565")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x4000566")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
[JHLCFIPIAOM]
public class HAEONMLFJAF : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public BBOKEMGNKNP ALHPCMAIBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(BBOKEMGNKNP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public INCMJPNHPGC OJMJHHMDOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460")]
		[CompilerGenerated]
		get
		{
			return default(INCMJPNHPGC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0xABDC60", Offset = "0xABC460", VA = "0x180ABDC60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public bool AAMBPJMOPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xA34760", Offset = "0xA32F60", VA = "0x180A34760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HAEONMLFJAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
public enum LJAHEPLBCNK
{
	[Cpp2IlInjected.Token(Token = "0x400056C")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x400056D")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x400056E")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[JHLCFIPIAOM]
public class FCPLFEDPJHL : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public string JNCPKOBKFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public JPKGLNCJBOH? FMAPHEDMOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public string? EFKEBHGFGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public IReadOnlyList<string>? BADIGMBAJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public IReadOnlyList<string>? OMFACFMLGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public GEOHCOMPKGC OKMIOCDLGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public string? CMDLBFPLFHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public string? OOINJDCBHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public string? NJCELGILEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079E")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public FCPLFEDPJHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[JHLCFIPIAOM]
public class DPIDDKJPBIA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public string GJKKOAKOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public JPKGLNCJBOH? FMAPHEDMOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public GEOHCOMPKGC OKMIOCDLGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public string? OOINJDCBHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public IReadOnlyList<string>? OMFACFMLGMC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public DPIDDKJPBIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[JHLCFIPIAOM]
public class GEOHCOMPKGC : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public string KKFGPOLPCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public bool DFBPNFNKMOM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xA76470", Offset = "0xA74C70", VA = "0x180A76470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xA34760", Offset = "0xA32F60", VA = "0x180A34760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public bool OBFEPLCGLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xF96880", Offset = "0xF95080", VA = "0x180F96880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xF967A0", Offset = "0xF94FA0", VA = "0x180F967A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public bool IGGLHNAEMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x10CD600", Offset = "0x10CBE00", VA = "0x1810CD600")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x14F6940", Offset = "0x14F5140", VA = "0x1814F6940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public bool NMPBMGFGBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x10CD5F0", Offset = "0x10CBDF0", VA = "0x1810CD5F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x67969A0", Offset = "0x67951A0", VA = "0x1867969A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public bool HBNONHGMGHC
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA78BE0", Offset = "0xA773E0", VA = "0x180A78BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xD9DF30", Offset = "0xD9C730", VA = "0x180D9DF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public bool FHLKGIOIEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE10", Offset = "0xA9D610", VA = "0x180A9EE10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0xD9E0C0", Offset = "0xD9C8C0", VA = "0x180D9E0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public bool NDPLJOHEHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x1949EE0", Offset = "0x19486E0", VA = "0x181949EE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x74C35C0", Offset = "0x74C1DC0", VA = "0x1874C35C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public bool LLINEBNMKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x1935210", Offset = "0x1933A10", VA = "0x181935210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x74C35B0", Offset = "0x74C1DB0", VA = "0x1874C35B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public bool MPALMDBHPII
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x74C35D0", Offset = "0x74C1DD0", VA = "0x1874C35D0")]
	public GEOHCOMPKGC(string HHFBOHBKGII, bool AKCIJPPAOGC, bool JDIAGKKNBIG, bool CAHMCFCGIEN, bool KGCOPNKOMJC, bool DFHPLBBBLJN, bool GCCBOEOOJIM, bool EIFKENMBIIN, bool AOJFEGIKDEP, bool HKGHJKGFPIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[JHLCFIPIAOM]
public class GFKEMNKEOKM : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public string NJCELGILEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public string CMDLBFPLFHL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public string EPNKPCCCIOC
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public string? GNFEEBOELAA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public float ENJHPDPKOKL
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0xC8D960", Offset = "0xC8C160", VA = "0x180C8D960")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0xF5A0B0", Offset = "0xF588B0", VA = "0x180F5A0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public bool ACEPDLAHAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0xDF5EA0", Offset = "0xDF46A0", VA = "0x180DF5EA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0xDF5E80", Offset = "0xDF4680", VA = "0x180DF5E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public GFKEMNKEOKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[JHLCFIPIAOM]
public class CIANIOJNDHH : KMKIBIHCKNN, PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public string FPAFFOGHFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public string MNGIIDFDDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "6")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CIANIOJNDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[JHLCFIPIAOM]
public class JBKIOAFINHH : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public long HMDJFLJCFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public decimal MGEMIGPKMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0xE57670", Offset = "0xE55E70", VA = "0x180E57670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public JBKIOAFINHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[JHLCFIPIAOM]
public class AGBDEBLLBIJ : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public string FPAFFOGHFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public string FPCDBAGONBB
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public AGBDEBLLBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0xA2A040", Offset = "0xA28840", VA = "0x180A2A040")]
	public AGBDEBLLBIJ(string IKOFEBOFHLE, string JGMCIDMHJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
[JHLCFIPIAOM]
public class BBDPFPIMCNA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public string NJCELGILEIE
	{
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public string JNCPKOBKFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public bool PAPKDHEOJOI
	{
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public BBDPFPIMCNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[JHLCFIPIAOM]
public class HONAADGBBIA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public string IAKMDBPEPML
	{
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public decimal NLLLEOJLFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xE57670", Offset = "0xE55E70", VA = "0x180E57670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public HONAADGBBIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[JHLCFIPIAOM]
public class AOLOFMHFMNJ : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public int FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public string PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public string? NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F7")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public IReadOnlyList<int> GIMFFAMAMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public string? IMCKLOPFHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x74C0270", Offset = "0x74BEA70", VA = "0x1874C0270")]
	public AOLOFMHFMNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[JHLCFIPIAOM]
public class MMLNBFKAIFM : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public int FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000348")]
	public Guid? JNDDENACFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x228B640", Offset = "0x2289E40", VA = "0x18228B640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x228B610", Offset = "0x2289E10", VA = "0x18228B610")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000349")]
	public string PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	public List<AOLOFMHFMNJ> FKINABLDHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	public List<AOLOFMHFMNJ> ADNGEINEAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	public string? NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	public string? IMCKLOPFHGK
	{
		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	public string? ACPGGEAFMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0xA27520", Offset = "0xA25D20", VA = "0x180A27520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x74C7E10", Offset = "0x74C6610", VA = "0x1874C7E10", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x74C7E40", Offset = "0x74C6640", VA = "0x1874C7E40")]
	public MMLNBFKAIFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[JHLCFIPIAOM]
public class MMBMCOFMKJA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public MMLNBFKAIFM FKINABLDHDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public MMLNBFKAIFM ADNGEINEAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public string? ACPGGEAFMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0x74C7D40", Offset = "0x74C6540", VA = "0x1874C7D40", Slot = "5")]
	public virtual void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000819")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public MMBMCOFMKJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[JHLCFIPIAOM]
public class FNHDFPICBPM : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public IReadOnlyList<MMLNBFKAIFM> PAPHPDDNHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public IReadOnlyList<MMBMCOFMKJA> ANMGFCNHKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public IReadOnlyList<FNHDFPICBPM> FDGLKFHABAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public string? ACPGGEAFMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000824")]
	[Cpp2IlInjected.Address(RVA = "0x74C2C00", Offset = "0x74C1400", VA = "0x1874C2C00", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x74C2C30", Offset = "0x74C1430", VA = "0x1874C2C30")]
	public FNHDFPICBPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[JHLCFIPIAOM]
public class OEKPOJPBMPM : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	public const string MDNEGNDBODK = "REPL_";

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public string FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public int FAJBLCGNLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0xA32440", Offset = "0xA30C40", VA = "0x180A32440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OEKPOJPBMPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[JHLCFIPIAOM]
public class JPKGLNCJBOH : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public string NCBGIDALPJM
	{
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public string PBNBGAHIAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public List<JPKGLNCJBOH>? FGPCCDOIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public OEKPOJPBMPM? FDNPIALMAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x74C5E70", Offset = "0x74C4670", VA = "0x1874C5E70", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public JPKGLNCJBOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
[JHLCFIPIAOM]
public class ECBFDEPGOFB : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700035E")]
	public string ILFBNDENCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035F")]
	public string DEGBBHJCEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public ECBFDEPGOFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[JHLCFIPIAOM]
public class BLOPJHKJKAP : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000360")]
	public string FIOOAILODJA
	{
		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000361")]
	public FNHDFPICBPM FBCOLCMOHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000362")]
	public JPKGLNCJBOH? FMAPHEDMOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000363")]
	public IReadOnlyList<MMLNBFKAIFM> FMCFILKNMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000364")]
	public IReadOnlyList<ECBFDEPGOFB> JMMDDDBMBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000365")]
	public string? GJKKOAKOCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x74C06B0", Offset = "0x74BEEB0", VA = "0x1874C06B0", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x74C0730", Offset = "0x74BEF30", VA = "0x1874C0730")]
	public BLOPJHKJKAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
[JHLCFIPIAOM]
public class CLBEGJCCKFF : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000366")]
	public LBDOGLKEAGE<BLOPJHKJKAP> EOJDHIBJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000367")]
	public decimal ELEMHOJIOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAC0", Offset = "0xC8D2C0", VA = "0x180C8EAC0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xE57670", Offset = "0xE55E70", VA = "0x180E57670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x7288760", Offset = "0x7286F60", VA = "0x187288760", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600084F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CLBEGJCCKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public enum PLPNBPIMPNJ
{
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40005C3")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x40005C4")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
[JHLCFIPIAOM]
public class OMNNILPHCNH : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000368")]
	public PLPNBPIMPNJ DHMLACBLCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(PLPNBPIMPNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000369")]
	public DateTime PGAPCICOLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public OMNNILPHCNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[JHLCFIPIAOM]
public class AMFIOOCAGIO : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700036A")]
	public PLPNBPIMPNJ ALOPGJMFIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(PLPNBPIMPNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036B")]
	public float MFFGCDCIDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xD9E9F0", Offset = "0xD9D1F0", VA = "0x180D9E9F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xD9E9E0", Offset = "0xD9D1E0", VA = "0x180D9E9E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600085A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600085B")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public AMFIOOCAGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
[JHLCFIPIAOM]
public class AMIACJELMLO : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x1700036C")]
	public PLPNBPIMPNJ DHMLACBLCHM
	{
		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0xA271A0", Offset = "0xA259A0", VA = "0x180A271A0")]
		[CompilerGenerated]
		get
		{
			return default(PLPNBPIMPNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35CB0", VA = "0x180A374B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036D")]
	public DateTime PGAPCICOLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036E")]
	public PLPNBPIMPNJ ALOPGJMFIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(PLPNBPIMPNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xD133C0", Offset = "0xD11BC0", VA = "0x180D133C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700036F")]
	public float MFFGCDCIDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xF23040", Offset = "0xF21840", VA = "0x180F23040")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x1387300", Offset = "0x1385B00", VA = "0x181387300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000370")]
	public PLPNBPIMPNJ NOEEJOKAEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xA32B70", Offset = "0xA31370", VA = "0x180A32B70")]
		[CompilerGenerated]
		get
		{
			return default(PLPNBPIMPNJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0xA32B90", Offset = "0xA31390", VA = "0x180A32B90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000371")]
	public float LPANPKFGGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0xCD8F80", Offset = "0xCD7780", VA = "0x180CD8F80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0xCD8F90", Offset = "0xCD7790", VA = "0x180CD8F90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public AMIACJELMLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[JHLCFIPIAOM]
public class CEEMBFDGDDM : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000372")]
	public TimeSpan MLLMMMHHEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0xDAE5F0", Offset = "0xDACDF0", VA = "0x180DAE5F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000373")]
	public TimeSpan FHNLEBKAPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0xCE5900", Offset = "0xCE4100", VA = "0x180CE5900")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public CEEMBFDGDDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
[JHLCFIPIAOM]
public class PBHFFGGGHDA : PEDHEJJFDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000374")]
	public List<string> HDAKFEADKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "4")]
	public void CEEOKKGGIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public PBHFFGGGHDA()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000148")]
public class LBHJJCIMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LBHJJCIMPIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x71ED770", Offset = "0x71EBF70", VA = "0x1871ED770")]
	public static string GJDAAFBHHBM(byte[] KCJGAKLGBDK, byte[] ABKKFEKEEMG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
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
