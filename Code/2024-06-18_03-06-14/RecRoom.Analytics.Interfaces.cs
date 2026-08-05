using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BACKHJNLNPC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NMLOGLDCMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NOFIKAMMMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KJFALBFGJNA GHIGBBCBKJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LHPLCEBLLHF;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CEOACKNPOAI;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<LEEINKLOHDI> OKCEEBJENCM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CCPNKNOIBEC(string EICGHFIAGFE, [Optional] OBEEFNIONAN KFFELFHDPEN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task LCBBNENHCKP(OBEEFNIONAN KFFELFHDPEN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task JINFCCFDNAI(OBEEFNIONAN KFFELFHDPEN, Dictionary<string, string> IFLBIPKKAND);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ENFLEAOHIAF(string EAHBHOEFKAF);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NLIJFOGGGGC OLMPKHHKCHG(string PMKDJHCKFAG);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DCNDFIMGCKI DCAIAAHPEII(string LJGOAFOKGOP);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task GDOFFJHGOIB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KHPAJCGCDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string IHNHELHKBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T AMGKFNFCLFC<T>(string LDDEKIBHION, [Optional] T JIEGAHKKHCA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NLIJFOGGGGC : KHPAJCGCDDO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KJOFAIPIKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool JCFEBNHEGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IReadOnlyList<string> ALKLIEIGFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DCNDFIMGCKI : KHPAJCGCDDO
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KJFALBFGJNA
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IReadOnlyDictionary<string, object> FNGCDOOHOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LEEINKLOHDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string KCMIHGLAIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public string JBDFPGMFBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public string GLCCJDOAGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public object KFEKFKCICDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool ELFEKJHMLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public string FBHAAJGAJLI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6739BB0", Offset = "0x67385B0", VA = "0x186739BB0")]
	public static LEEINKLOHDI JMDPJCGBKMK(string LJGOAFOKGOP, string JLKCBEKBIPB, object BPDHDOLGOKH, bool AFDLLGJBPCO, string GFHCHIJIAAA)
	{
		return default(LEEINKLOHDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6739B20", Offset = "0x6738520", VA = "0x186739B20")]
	public static LEEINKLOHDI DLOMLBGLABK(string PMKDJHCKFAG, string JLKCBEKBIPB, object BPDHDOLGOKH, bool AFDLLGJBPCO, string GFHCHIJIAAA)
	{
		return default(LEEINKLOHDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GDALDJJNLPH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum CEFFPPJMIEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		ViewedStore,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		ViewedCheckoutDialog,
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		ConfirmButton,
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		PurchaseSuccessful,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		PurchaseFailed,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		NotEnoughTokens
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	long OPGADLMKGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string GPLINBKBCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string BLCNHDGOHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool ECCHNIPKMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	long NKIEIPJDMNB();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MKOKJOBPHEN(long CDOHPIHKAAC, bool GCEDFEFEJLJ = true);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICOPJNFDCFK(string NIDJKNBFFJH, string BCEHIKMCNOK, string HPMGKGNJFLB);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KAEBFJCLAMJ(string NIDJKNBFFJH);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FFANOFLFEAD(string NIDJKNBFFJH, string CJFNIBCIMEP, string KMFDDCBNOML);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OOIJJJDHIEA(string MLBCIJADJGF, object DCNCFGBENEJ, object OMPDCACHGPD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LLLJEJKPFEM(CEFFPPJMIEM KHHIHGOIBBE, int BCKPHDPNMKL, [Optional] NEEJHCPCJGM AHIKICLNNIC, [Optional] string ACEOIBKINAE, [Optional] string BKMJJACFCBK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DFKABLMAEFH(NEEJHCPCJGM AHIKICLNNIC, long CNOEPNADDND, long FIHGLIBMFEH, int KGIALELJFLA, string ACEOIBKINAE, int BCKPHDPNMKL);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EMIHAJNALOB(NEEJHCPCJGM AHIKICLNNIC, bool FBPJJEBDJKF, [Optional] string BKMJJACFCBK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DEBDKIAICBK(NEEJHCPCJGM AHIKICLNNIC, bool FBPJJEBDJKF, [Optional] string BKMJJACFCBK);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GCMNBJNHGNF(NEEJHCPCJGM AHIKICLNNIC, bool FBPJJEBDJKF, [Optional] string BKMJJACFCBK);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PMCLLCPBPNA(long ONILLAPMLEN, string DCECLJAIJHF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OBEEFNIONAN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool LNLDBBIBCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool FGIBCMDILJF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool IFBNLFJNLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool? FCIDEFIJINL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int? DHANKOOCPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int ENNHAGGJKDM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int HHCFKDKALOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string GJKOFMOEBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string FJDPMABFOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string GFCLEGEAECN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	long IGJJDODJIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string NFCILHAEGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	string HGMJADJDDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	string FKFLOJBOHCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	string JNLPBJELECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string ENLHNLOHEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	double OEKFFCCIJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	int KCPECBOCBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string PIEJCICEJJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string DIGJMDEHPGC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	string BLNPPHICCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	Guid? AFACPDNLBLA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}
}
namespace Cpp2IlInjected;

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
