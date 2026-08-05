using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CBA610", Offset = "0x1CB9410", VA = "0x181CBA610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JHFIFBBDBFH
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Follow,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Orbit,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Attached,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Detached
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct LIJLIMALJEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly ILKDAPKCHJN PJNCKJINFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly JDNIOKNAPLJ EGHKHLJKJFA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1CB9060", Offset = "0x1CB7E60", VA = "0x181CB9060")]
	public LIJLIMALJEN([In] ILKDAPKCHJN PBPDKBKCOEP, JDNIOKNAPLJ FKKHKCBMBBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct ILKDAPKCHJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly BKADKCCHKCG MABKJMLFEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly CIHHGOOFMKE AJPCMJBPMCO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
	public ILKDAPKCHJN(BKADKCCHKCG HCEEMHFFJGA, CIHHGOOFMKE FHAHPPKCPJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct JDNIOKNAPLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly IAHEKKJENGP OHFOLMIDJLC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
	public JDNIOKNAPLJ(IAHEKKJENGP OJKNIBCDOFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct MJBNFFKAGNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly FKAILKKLIJK CDNPMEEOLLM;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x83D460", Offset = "0x83C260", VA = "0x18083D460")]
	public MJBNFFKAGNJ(FKAILKKLIJK GLPOHIBPHPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DDGJOAHNCLH
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Digit,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Integer,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Decimal,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	Regex,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CustomValidator
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum POOEHGEJNIG
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Autocorrected,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	IntegerNumber,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	DecimalNumber,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Alphanumeric,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Name,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	EmailAddress,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Password,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Pin,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Custom
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum DisplayKind
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		CanInteract,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		CanNotInteract
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GODFODJCNKP : IOLPDFNHGCK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeRecorderData(string HFFCKFNMFBL, Action<string, float> ONEEEOICFKJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BDPHIAIHNLI : CMOKKPPHEIE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABMENMCJJKB();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IOLPDFNHGCK
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnHide();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DoneEditing();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface LFCEOAGECHC
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DNNEGAFCGNA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string LEHMDLOIFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int GOEAHFLIEIA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IEMGOEMGEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JMLOMIAIHJF : CMOKKPPHEIE
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHPNFEHLKNP(CMOKKPPHEIE BFPCANAHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPNBJONBLDG();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BFKGBCINJJC(CMOKKPPHEIE BFPCANAHFDO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CBGHKPMGMAE
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMHEOLACLNP(string OLGOFOLAMPB, Func<string> MNMCPBMFPCF, Action<string> DAKJDKHNLJN, Func<bool> EFDNEBFFPIE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void COMLDFNDEON(string OLGOFOLAMPB, Action MJADEGBBKGL, Func<bool> EFDNEBFFPIE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBLGFLLBJLH(string OLGOFOLAMPB, Func<int> NGOGDJIIKEG, Action<int> EGJFBCCOFMI, Func<bool> EFDNEBFFPIE);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBFPBEGFJNB(string OLGOFOLAMPB, Func<int> MNMCPBMFPCF, Action<int> DAKJDKHNLJN, Func<bool> EFDNEBFFPIE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNPBMBHOMJF(string OLGOFOLAMPB, Func<int> HBHFBJGKKFM, Action<object> MGPGFPKAHEB, Func<object, string> EJGEDLEKJPL, Func<bool> EFDNEBFFPIE, Type NDICMDDBLLC, IReadOnlyList<object> KEFMHNKIJPN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJAKKEJKDFP(string OLGOFOLAMPB, Func<string> MNMCPBMFPCF, Action<string> DAKJDKHNLJN, Func<bool> EFDNEBFFPIE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMFOFLGGBGB(string OLGOFOLAMPB, Func<bool> MNMCPBMFPCF, Action<bool> DAKJDKHNLJN, Func<bool> EFDNEBFFPIE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface JHJDHALIBOP
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface JKAPFCCKFDA
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Action<JHJDHALIBOP>? LCONPIOKFNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Action<JHJDHALIBOP>? CDNMEGOKCPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		CMOKKPPHEIE MOMFHNMLGCK(Func<bool> AFDHDPMOCNF, Action<bool> HHOEGKLBGNL, Func<byte> NEKJHGLICGJ, Action<byte> HLPHMMGPDDC, Func<int> BMGCHECNGNJ, Action<int> PLPEFJDEGOJ, Func<IReadOnlyList<string>> KFHMGJNGBJP, Action<IReadOnlyList<string>> DMANKDAEBKG, [Optional] Func<bool>? EFDNEBFFPIE);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AKFCCOIAMKK();

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DAPBDADNFIA(CMOKKPPHEIE BFPCANAHFDO);
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JKAPFCCKFDA ELLFHMGHCFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMOKKPPHEIE DDPAEGOICEK(Action MJADEGBBKGL, string OLGOFOLAMPB = "", [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CMOKKPPHEIE KFNGJOACJCO(IReadOnlyList<CMOKKPPHEIE> JGKKOAMEPPD, [Optional] float? OLMGGBNNEOB, [Optional] int? DMHLFAMCBLO, [Optional] bool? PHFNBLIAFFD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CMOKKPPHEIE NOCLGCODBKH(IReadOnlyList<CMOKKPPHEIE> JGKKOAMEPPD, [Optional] float? OLMGGBNNEOB);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CMOKKPPHEIE BACOAACHBEB(Func<int> NGOGDJIIKEG, Action<int> EGJFBCCOFMI, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, bool FGNHHJJDKEP = false, string OLGOFOLAMPB = "Color", [Optional] Func<bool>? OMIOALCCEPJ, bool FCFHGGJNFBL = true, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CMOKKPPHEIE DCMAEGOJFBK(Action MJADEGBBKGL, string OLGOFOLAMPB = "", [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CMOKKPPHEIE BANLLNEMFOD(CMOKKPPHEIE BFPCANAHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JMLOMIAIHJF HOMILBJPFBK(int CFGOOEPMJGN, string OLGOFOLAMPB, string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] List<CMOKKPPHEIE>? JGKKOAMEPPD, [Optional] Func<bool>? EFDNEBFFPIE, bool MLFJFEFOLKA = true, [Optional] Func<bool>? HKEIDGMKHGL, [Optional] Action<bool>? LAIDJBOHJNL, [Optional] float? JNHMLLLOOOB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CMOKKPPHEIE JKBAIGEKJBK(string BLCJAOOBJMG, [Optional] Func<bool>? EFDNEBFFPIE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CMOKKPPHEIE DPFCMPGEODM(Func<string> MNMCPBMFPCF, Action<string> DAKJDKHNLJN, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] int? MHHIAIONMGF, bool JMJLNJIHMJN = false, string OLGOFOLAMPB = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CMOKKPPHEIE EHOADGDMJFC(Func<float> MNMCPBMFPCF, Action<float> DAKJDKHNLJN, string OLGOFOLAMPB = "", string NEFJNEDGDJD = "", string LHOEMJICDGO = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", bool GNHHLMBECNF = false, float AMFPINEGIGK = 0f, float DNMDMILIMDN = 1000f, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CMOKKPPHEIE EENMMFHDHEB(Func<int> MNMCPBMFPCF, Action<int> DAKJDKHNLJN, string OLGOFOLAMPB = "", [Optional] Func<string>? MNGHEFHLNNO, string NEFJNEDGDJD = "", [Optional] Func<string>? AHPJHEMLLDF, string LHOEMJICDGO = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", bool GNHHLMBECNF = false, int AMFPINEGIGK = 0, int DNMDMILIMDN = 1000, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CMOKKPPHEIE MKPAEIOBMPD(Type NDICMDDBLLC, IReadOnlyList<object> KEFMHNKIJPN, Func<int> HBHFBJGKKFM, Action<object> MGPGFPKAHEB, string OLGOFOLAMPB = "", string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<object, string>? EJGEDLEKJPL, bool GCMCKCLCJEP = true, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CMOKKPPHEIE JIPCACLFKLF(Func<string> MNMCPBMFPCF, Action<string> DAKJDKHNLJN, int BBPGLDMPMNJ = 1000, POOEHGEJNIG POMJFKNDECN = POOEHGEJNIG.Alphanumeric, [Optional] Func<string, bool>? NFEPENOHDML, [Optional] string? PFHFPIKDCLP, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, string OLGOFOLAMPB = "", string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", bool JMJLNJIHMJN = false, [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CMOKKPPHEIE APGFPCIAILM(Func<float> MNMCPBMFPCF, Action<float> DAKJDKHNLJN, float AMFPINEGIGK = 0f, float DNMDMILIMDN = 1000f, [Optional] Func<bool>? MFPCEOPDGIJ, int GGJFBADKOLE = -1, string OLGOFOLAMPB = "", string NEFJNEDGDJD = "", string LHOEMJICDGO = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] Func<float, float>? JFINDEELLHL, [Optional] Func<float, float>? AANNPLEPHDP, [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CMOKKPPHEIE EBMNNGHHNGF(Func<string> MNMCPBMFPCF, Action<string> DAKJDKHNLJN, Action MJADEGBBKGL, [Optional] Func<bool>? EFDNEBFFPIE, POOEHGEJNIG POMJFKNDECN = POOEHGEJNIG.Alphanumeric, [Optional] Func<string, bool>? NFEPENOHDML, DDGJOAHNCLH BFDMNHDJGFI = DDGJOAHNCLH.Alphanumeric, [Optional] string? PFHFPIKDCLP, [Optional] List<CMOKKPPHEIE>? LPKGHFJLIGL, string OLGOFOLAMPB = "", string PINEAEBKMFI = "", string GKKNEPPFAFO = "", string AALFLCGCGBM = "", bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CMOKKPPHEIE KBDBJHHOPCB(Func<string> MNMCPBMFPCF, Action<string> DAKJDKHNLJN, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] int? MHHIAIONMGF, bool JMJLNJIHMJN = false, string OLGOFOLAMPB = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	CMOKKPPHEIE NBHFANJJGJG(Func<bool> MNMCPBMFPCF, Action<bool> DAKJDKHNLJN, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, string OLGOFOLAMPB = "", string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] int? CFGOOEPMJGN, [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CMOKKPPHEIE CLALOHFNKPF(Func<bool> MNMCPBMFPCF, Action<bool> DAKJDKHNLJN, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, string OLGOFOLAMPB = "", string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] int? CFGOOEPMJGN, [Optional] Func<bool>? OMIOALCCEPJ, [Optional] Func<bool>? EJBMFNJFNFA, string INHKECJEGKN = "", [Optional] Func<string>? AFOHJCGBHAC, string KFEDJPBDKPO = "", [Optional] Func<string>? KNKGKOKCDKN, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	BDPHIAIHNLI LNBIMGDENPO(Dictionary<string, LLMJAGHJFMC> KFIJLJLHGLL, Func<int> NGOGDJIIKEG, Action<int> EGJFBCCOFMI, string OLGOFOLAMPB, string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] Action? JFOHHIGKHID, [Optional] Action? OCKJNHNKPFG, [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<int, string>? JGNKDMFFEKO, bool GCMCKCLCJEP = true, bool KHODPMALEFP = true, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BDPHIAIHNLI FJLJCLDDLPB(Func<Dictionary<string, LLMJAGHJFMC>> NNOAAHFNNIF, Func<int> NGOGDJIIKEG, Action<int> EGJFBCCOFMI, string OLGOFOLAMPB, string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<bool>? GIJNDINPCKL, [Optional] Func<int, string>? JGNKDMFFEKO, bool GCMCKCLCJEP = true, bool KHODPMALEFP = true, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	CMOKKPPHEIE PNDOKDADFBC(Func<List<KeyValuePair<string, LLMJAGHJFMC>>> NNOAAHFNNIF, Func<int> NGOGDJIIKEG, Action<int> EGJFBCCOFMI, string OLGOFOLAMPB, string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<bool>? GIJNDINPCKL, [Optional] Func<int, string>? JGNKDMFFEKO, [Optional] Action? JFOHHIGKHID, [Optional] Action? OCKJNHNKPFG, bool GCMCKCLCJEP = true, bool KHODPMALEFP = true, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	CMOKKPPHEIE JLAMCHFDEFE(Func<List<object>> NNOAAHFNNIF, Func<object> HBHFBJGKKFM, Action<object> MGPGFPKAHEB, Func<object, string> EJGEDLEKJPL, string OLGOFOLAMPB = "", string NEFJNEDGDJD = "", string PINEAEBKMFI = "", string NFCGOLDMKJG = "", [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, bool GCMCKCLCJEP = true, bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CMOKKPPHEIE OMAENKBJLIH(string OLGOFOLAMPB, Func<object> HBHFBJGKKFM, Action<object> MGPGFPKAHEB, Func<object, string> EJGEDLEKJPL, Func<IReadOnlyList<object>> NPEPKLEHLJN, [Optional] Func<bool>? EFDNEBFFPIE);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HPAOMOFPFDL(CMOKKPPHEIE BFPCANAHFDO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void AAMEOIBCHEG(string BAOABHOBBFH, Action? OHONFAHMFLF, bool EKGDJCNMHKE, string KJDOGLDPGHA, Action? HCBNPKKIBHH, string KHIFMDJDLEG, string BKPKODIPKOP);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EAFKOJAAFOI(Func<string> MNMCPBMFPCF, Action<string> DAKJDKHNLJN, Action MJADEGBBKGL, [Optional] Func<bool>? EFDNEBFFPIE, POOEHGEJNIG POMJFKNDECN = POOEHGEJNIG.Alphanumeric, [Optional] Func<string, bool>? NFEPENOHDML, DDGJOAHNCLH BFDMNHDJGFI = DDGJOAHNCLH.Alphanumeric, [Optional] string? PFHFPIKDCLP, [Optional] List<CMOKKPPHEIE>? LPKGHFJLIGL, string OLGOFOLAMPB = "", string PINEAEBKMFI = "", string GKKNEPPFAFO = "", string AALFLCGCGBM = "", bool GLFABLDNOHJ = true);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EFPMLMDAKIB(string GCJHMCOBNMD);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "28")]
	CMOKKPPHEIE DDHJMDLMMKG(List<object> KFIJLJLHGLL, List<string> EJGEDLEKJPL, Func<int> NGOGDJIIKEG, Action<int> EGJFBCCOFMI, string AELPIILDAHI = "", [Optional] Func<bool>? EFDNEBFFPIE, [Optional] Func<bool>? EOEIMMBNOCJ, [Optional] Func<bool>? OMIOALCCEPJ, bool GLFABLDNOHJ = true, bool OANBMEGLODN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CMOKKPPHEIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ENPKDDOGJPE
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJNOCDFKHKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface HCKCICNNHAN
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MIPJDCNHHAO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHJKKMOKDOM(string LGEDKCOFKPP, [In] GOPKJBGDKJO HBLLOHAOGDJ);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKHMBKIANEG(string KHIFMDJDLEG);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNPDLJMNGPD(string BLCJAOOBJMG);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MPLLBHNCAAM
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool AHAEJCAFBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool BJKEDLFIEAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GLALOLDDFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool NKHJIEEJDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GHBELEIKFMD(Guid FIIKOPJKJCE);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BFIBIFJJGIM(KFGENKOPJGC KNAIEKIJLBC, IReadOnlyDictionary<BEBLNOOFELI<BJGNAPHFBHH>, Guid>? JPFBFADNMHM);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JLIGONPODEK(KFGENKOPJGC KNAIEKIJLBC);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NNKFLPENAKP(KFGENKOPJGC KNAIEKIJLBC, IReadOnlyDictionary<BEBLNOOFELI<BJGNAPHFBHH>, Guid>? JPFBFADNMHM);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DOBOLDGPCPG(BEBLNOOFELI<PFMIKBJCBJK> FIIKOPJKJCE);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface CGFNIJJPEIE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BGICKMOFPDK? ANGIAPALHML
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool DJPEFKLMFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool BNDGFPAMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<BGICKMOFPDK> AAMBGBJICGP();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EFFPFBGFCJB<ILKDAPKCHJN, PILBJIJHFMF> KNKMIAFIPNG([In] ILKDAPKCHJN KHHNFDNJANP, IEnumerable<DAOFGAIMCID> HBLCKDIJKNP, int LALPJHCLFNL);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface BGICKMOFPDK
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct LDEGHIHLCLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly PJPOBLJMCAB EABIPLIICEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly MJBNFFKAGNJ BMKHMGHJFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly IEnumerable<DAOFGAIMCID> HKCILCPHIHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly bool OJMPFKIOMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly BEBLNOOFELI<BJGNAPHFBHH> BJDDJOLMAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly int? NBKFCFAEJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly DINMCNDDOHA? KNNKKOEGKAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly DINMCNDDOHA? LCCJGKMLGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly BFKCPCMBBPN? MLJFLMFLNAJ;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8EC0", Offset = "0x1CB7CC0", VA = "0x181CB8EC0")]
		public LDEGHIHLCLC(PJPOBLJMCAB INNGOFDOKHL, [In] MJBNFFKAGNJ KHHNFDNJANP, IEnumerable<DAOFGAIMCID> HBLCKDIJKNP, bool FKFJEMPNPHC, [In] BEBLNOOFELI<BJGNAPHFBHH> GPHGEJNHDKC, int? DMLJJFLGKDB, [In] DINMCNDDOHA? CNNFJEKDNLJ, [In] DINMCNDDOHA? JMEMPGIMGCN, [In] BFKCPCMBBPN? BOOCKOJGFON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public readonly struct BFKCPCMBBPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly IReadOnlyCollection<ByteString> NOHKLIABEIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly IReadOnlyCollection<ByteString> KHBGDDJADDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly IReadOnlyCollection<ByteString> PMLCINKCAIC;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x19743C0", Offset = "0x19731C0", VA = "0x1819743C0")]
		public BFKCPCMBBPN(IReadOnlyCollection<ByteString> NJEFPNBGEHO, IReadOnlyCollection<ByteString> HMIKDOLCMIM, IReadOnlyCollection<ByteString> KLCPMPCDEOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct ENPCMCHNJCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly MJBNFFKAGNJ BMKHMGHJFDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly IReadOnlyDictionary<Guid, Guid> MBBKDLKKOMG;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1CB8890", Offset = "0x1CB7690", VA = "0x181CB8890")]
		public ENPCMCHNJCF(MJBNFFKAGNJ KHHNFDNJANP, IReadOnlyDictionary<Guid, Guid> OFKFNGOAKLK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NMFJLPOPFLE? NCNMDLOJOLK([In] BEBLNOOFELI<BJGNAPHFBHH> MOFFGNIDNJM);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JHNFOICKJMP? LOHANKDFOLL([In] BEBLNOOFELI<DOHDAHLOGBC> CNNNLFIFOJC);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JLIKJAJDGAB> GBHBNOIOOAB(bool MNGEIINFBNO, bool HPNEPMDKEKH, bool LDBDNNAEKLD, bool NPPKMJKAEND);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EFFPFBGFCJB<ENPCMCHNJCF, PILBJIJHFMF> JPIHEPIBDAJ([In] LDEGHIHLCLC BONEGMDLPMG);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LIJLIMALJEN GCECFLLPANH(IEnumerable<DAOFGAIMCID> HBLCKDIJKNP);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LIJLIMALJEN JOPJPAKEDEH();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MJBNFFKAGNJ NMBMJAPMFDA(PJPOBLJMCAB INNGOFDOKHL, MLOCHKHLPON<BJGNAPHFBHH> MPDMMACMJMP, IEnumerable<BEBLNOOFELI<DOHDAHLOGBC>> OEFKDMKMBCC, IEnumerable<DAOFGAIMCID> HBLCKDIJKNP);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface GGJOLFIMBAP : OMKKCINCAAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CGFNIJJPEIE FDGPMGAFGOA
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FCBFPODNPBP : PILBJIJHFMF
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NMFJLPOPFLE
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DOBAGPAAMFF? BCDGOLHIFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface PKGDMOFPOHN : AILOKPCNNJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MLOCHKHLPON<HMGADFDFNMI> EICOHJDDNHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ECIMBMFOOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKKHLFNLLLD(ENPKDDOGJPE ILFPKGHINAH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOLECDGMHBN(CBGHKPMGMAE DKGODMBGFBH);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string NOMLIKGFJII(int EHMLDAMGILJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OALCJFGAJDG(LODBDDOLMEO PJBPBPIPFHJ);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GENBNMEKMLK(LODBDDOLMEO PJBPBPIPFHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface LODBDDOLMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface JHNFOICKJMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	object JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BEBLNOOFELI<PFMIKBJCBJK> ENBIKGLDHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool LCEMEJPIIEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int PLFNHDOOCAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	GOPKJBGDKJO FMCNKABKLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string OJAACADCALB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NodeVisualizationKey OLNAGICFANI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	MLOCHKHLPON<PGEFBBLOHLK> KBGDJKMDOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool BKJMFBCDLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool ACEOOEIDPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DIOBPGEPPCE BFLMAAGDIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EOEDECAPGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool EEFHGJLCIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool FMHDADMFMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	int DMBNLKPBDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool EOJHFKAJMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string PBFHMOEPMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool GHBELEIKFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KGNDBIJCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool EPGBCMAGLMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool APMDLNLBPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool MGAPONIEPAO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	ALABNNELONF BEDPIAEOKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	PFGFFEFKBLO FGBNJMGCCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[LIBOMGMFGCD(true, "FloatingText")]
	bool NJDNFHBMOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DNNEGAFCGNA? EMNFCOKAHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BEBLNOOFELI<BJGNAPHFBHH> CLAECJANOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	[DLHFDGJCDNB("This isn't great UX and we should consider removing it.")]
	bool GBNOEIKOKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BEBLNOOFELI<BJGNAPHFBHH>? JLIAMDJDHIC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IEnumerable<BEBLNOOFELI<DOHDAHLOGBC>>? ACIAKKNKGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool FHDNFMMFEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool DKKFNMFOPPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	BEBLNOOFELI<DOHDAHLOGBC> KLIBDGJKFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	GLCJHMMKBBG<ILGHHCCPMNE, PEHCPIAMAPK> EMJNALIIDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	MLOCHKHLPON<ILGHHCCPMNE>? IOFLEFNNJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GCPBJFHKDAK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FELMDHLGBBB NBDJOBLOONC;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event JAEDCAIJIAA KFOEMFAJJAG;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action KCPCKMEAFII;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action DKEDHAFKAPA;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<MLOCHKHLPON<ILGHHCCPMNE>, PEHCPIAMAPK> HECCALLIIKC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<MLOCHKHLPON<ILGHHCCPMNE>> DMFACJDCPPO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<MLOCHKHLPON<ILGHHCCPMNE>, PEHCPIAMAPK> PJLEJIDDHIA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MLOCHKHLPON<ILGHHCCPMNE>, MLOCHKHLPON<ILGHHCCPMNE>> IIBAJMAHKID;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<MLOCHKHLPON<ILGHHCCPMNE>, PEHCPIAMAPK> EDCGFBJJHIF;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JNEMHHENPJF(int HBHLMDENNFC);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool NEIODKDNKEF([In] ALABNNELONF PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool HLHPOEMONOG([In] PFGFFEFKBLO PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void DLLOGEIAOMM();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> PGGIELLMCKA(ALABNNELONF? EHFMGFPLNPD, PFGFFEFKBLO? GBLLLKBIFDK);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void PEHDKDGPBAP();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GFFHHIPCCAB();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IFOLOGGDELP();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool COLOMENHGPL([Out] Guid MDNADACNBIH);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool GDNCIMNBDFB([In] Guid MOFFGNIDNJM);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void KICOEKABIEM();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void BOLCFNEMBFL(bool IJLHPGGFIHB);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "46")]
	IOLPDFNHGCK CABAHMCONAG([In] GODFODJCNKP JDCDNDIIBAK);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void IFLGIGCPNMI(object EMGABDKPONI);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void IGDOIHKNJOP(object EMGABDKPONI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void NOLECDGMHBN(JHJDHALIBOP EHEGBGNMGCF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "72")]
	DINMCNDDOHA LALGFILPDCF();

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> EGEIDBGLJIF(MLOCHKHLPON<ILGHHCCPMNE> NKOLGBOGIJG);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DNFDLANIPFG : AILOKPCNNJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	MLOCHKHLPON<MOLLOJAGGPE> JHOPEKCBLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AILOKPCNNJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IEnumerable<StaticEdge> CECPENHJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DisplayKind PHIJKCAGMMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	BEBLNOOFELI<BJGNAPHFBHH> CLAECJANOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BEBLNOOFELI<DOHDAHLOGBC> KLIBDGJKFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MLOCHKHLPON<ILGHHCCPMNE> CAKFFKCALEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MLOCHKHLPON<AHMMIBDGAJI> PIOOCAMBNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	GNHGPCMNPKN NIMJFCJGPKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	PortImage MPDDHEONPMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AIELCIFEOEI(CGHPKDDIBNH PJBPBPIPFHJ);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PJKEIGHKBFN(OFOCMJFGMHB PJBPBPIPFHJ);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LEMCPOOKFLO(HCKCICNNHAN HDAABAKKPPI);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DHIGFNCGMKJ(CGHPKDDIBNH PJBPBPIPFHJ);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OGMEDONGCHN(OFOCMJFGMHB PJBPBPIPFHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CGHPKDDIBNH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface PEHCPIAMAPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate void LHDDEEBEFDP(MLOCHKHLPON<ILGHHCCPMNE> IBLOAPAOIFJ, MLOCHKHLPON<ILGHHCCPMNE> NCOLHKPFHLG);

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool KDDNMMJMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool HAOBIODHMNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool GKADNBHJKJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	BEBLNOOFELI<BJGNAPHFBHH> CLAECJANOFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool ODMOBHMNCCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GLCJHMMKBBG<HMGADFDFNMI, PKGDMOFPOHN> ELKKKACNHPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	BEBLNOOFELI<DOHDAHLOGBC> KLIBDGJKFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	GLCJHMMKBBG<MOLLOJAGGPE, DNFDLANIPFG> KOKPAKJGFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	MLOCHKHLPON<ILGHHCCPMNE> CAKFFKCALEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action ECCLFFBOIMJ;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action BJJIMIGMGLA;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<MLOCHKHLPON<HMGADFDFNMI>, MLOCHKHLPON<HMGADFDFNMI>> DCKGKHOAEFO;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<MLOCHKHLPON<MOLLOJAGGPE>, MLOCHKHLPON<MOLLOJAGGPE>> JEMMMIPBOCG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<MLOCHKHLPON<HMGADFDFNMI>, PKGDMOFPOHN> EIGIGKNFPJP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<MLOCHKHLPON<HMGADFDFNMI>> NIINBKENMJF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<MLOCHKHLPON<HMGADFDFNMI>, PKGDMOFPOHN> FBKECJPCLLJ;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<MLOCHKHLPON<MOLLOJAGGPE>, DNFDLANIPFG> CHMEDCINOID;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<MLOCHKHLPON<MOLLOJAGGPE>> DPILLKENMNO;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<MLOCHKHLPON<MOLLOJAGGPE>, DNFDLANIPFG> LJBOPFKFBJO;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> FCAHFECFDJD();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> NEJNHMCKOMF(MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> BKOGJJFICJD(MLOCHKHLPON<GPPPMJHGDAG> OBCBIFNKCHG);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> OFLLPLHKEBP(MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP, MLOCHKHLPON<JNFHCKPJEOI> OBDHJPCAEIM);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> KEJAMHPIEEI(MLOCHKHLPON<GPPPMJHGDAG> OBCBIFNKCHG, MLOCHKHLPON<GPPPMJHGDAG> OBDHJPCAEIM);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> GDPHJNKJBPF();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> FFHPHELNLEF(string CIGIGKOKCIM);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> CBCLGBECGCP(MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP, string NDLLBBKGIJD);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> CFBEFDGJFLJ(MLOCHKHLPON<GPPPMJHGDAG> OBCBIFNKCHG, string NDLLBBKGIJD);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> OGAHBCCPMJI(MLOCHKHLPON<JNFHCKPJEOI> ELCIADGJMFP, JLIKJAJDGAB AOPDMLJGEMB);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<EFFPFBGFCJB<CJPHMHJPNKO, FCBFPODNPBP>> NCKBMPEKPFF(MLOCHKHLPON<GPPPMJHGDAG> OBCBIFNKCHG, JLIKJAJDGAB AOPDMLJGEMB);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface JLIKJAJDGAB
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	TypeKey NAJMHGGDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string MLBHNDOOCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EFFPFBGFCJB<MLOCHKHLPON<JNFHCKPJEOI>, FCBFPODNPBP>> HIJEFCINMJC(BEBLNOOFELI<BJGNAPHFBHH> MOFFGNIDNJM, BEBLNOOFELI<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<ILGHHCCPMNE> NKOLGBOGIJG, string NDLLBBKGIJD);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<EFFPFBGFCJB<MLOCHKHLPON<GPPPMJHGDAG>, FCBFPODNPBP>> ENDALMJBCGC(BEBLNOOFELI<BJGNAPHFBHH> MOFFGNIDNJM, BEBLNOOFELI<DOHDAHLOGBC> CNNNLFIFOJC, MLOCHKHLPON<ILGHHCCPMNE> NKOLGBOGIJG, string NDLLBBKGIJD);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OFOCMJFGMHB
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed([In] IDOIOGNGCLE NJIFEAMEHPB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GNHGPCMNPKN
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool EONBGGMMKML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool AGINDIHEPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	TypeKey OLNAGICFANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool JOBOCCPHMPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class PFMIKBJCBJK
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class BJGNAPHFBHH
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class IKFLLCHHAHF : MPADCKAHBFE
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class JNFHCKPJEOI
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DOHDAHLOGBC
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class NMEGILIBHGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class OGAMGKFNOJD : MPADCKAHBFE
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class GPPPMJHGDAG
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class MPADCKAHBFE
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[DLHFDGJCDNB("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class ILGHHCCPMNE
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class HMGADFDFNMI : AHMMIBDGAJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class MOLLOJAGGPE : AHMMIBDGAJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class AHMMIBDGAJI
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class JGKJEEBDFCN
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class PGEFBBLOHLK
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class APCBADPDPEO
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class INBNJBDFPHO
{
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum NodeVisualizationKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Execution,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Circuit,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		EventSender,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		EventReceiver,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		EventDefinition,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		ControlPanel,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		InBus,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		OutBus,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		Reroute,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		Comment,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		StudioEventSender,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		Constant,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		DataTable
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct DOBAGPAAMFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly BEBLNOOFELI<DOHDAHLOGBC> NCOAHPDODLD;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8880", Offset = "0x1CB7680", VA = "0x181CB8880")]
	public DOBAGPAAMFF([In] BEBLNOOFELI<DOHDAHLOGBC> AIHOCENLAPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public delegate void HLKPLJKLNBA([In] IDOIOGNGCLE NJIFEAMEHPB);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum PortImage
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		List,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		StateTransition
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public delegate void FELMDHLGBBB([In] ALABNNELONF BCCGBAKEOMJ);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct GDHFKFDGNPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly JLIKJAJDGAB BHBEANBMONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly JLIKJAJDGAB KPINKKBMKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly JLIKJAJDGAB HNNHPGFKODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly JLIKJAJDGAB POAMMLANBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly JLIKJAJDGAB JPHPCKAJNFP;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xF1AD10", Offset = "0xF19B10", VA = "0x180F1AD10")]
	public GDHFKFDGNPB(JLIKJAJDGAB OAGCDKHJCEN, JLIKJAJDGAB ENAKNACBCGL, JLIKJAJDGAB MACNLIFKNNN, JLIKJAJDGAB CAKOEIHJHJJ, JLIKJAJDGAB PLJPMLHOHOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void JAEDCAIJIAA([In] PFGFFEFKBLO HBPKBIAHANO);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly BEBLNOOFELI<DOHDAHLOGBC> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly MLOCHKHLPON<ILGHHCCPMNE> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly MLOCHKHLPON<MOLLOJAGGPE> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly BEBLNOOFELI<DOHDAHLOGBC> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly MLOCHKHLPON<ILGHHCCPMNE> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly MLOCHKHLPON<HMGADFDFNMI> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1CBAE80", Offset = "0x1CB9C80", VA = "0x181CBAE80")]
		public StaticEdge([In] BEBLNOOFELI<DOHDAHLOGBC> NIDJKIHIBKD, MLOCHKHLPON<ILGHHCCPMNE> MGHFJAPCDCG, MLOCHKHLPON<MOLLOJAGGPE> DEOEJIDLFLG, [In] BEBLNOOFELI<DOHDAHLOGBC> LABDPACAKJH, MLOCHKHLPON<ILGHHCCPMNE> EGMNCPJGOHE, MLOCHKHLPON<HMGADFDFNMI> AKAIFCILMBB)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1CBA920", Offset = "0x1CB9720", VA = "0x181CBA920")]
		public static bool HIHGGPGGFPN([In] StaticEdge CJNLLBDPPAC, [In] StaticEdge CCDAOMDJCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1CBA740", Offset = "0x1CB9540", VA = "0x181CBA740", Slot = "4")]
		public bool Equals(StaticEdge LCIDHBCOPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1CBA690", Offset = "0x1CB9490", VA = "0x181CBA690", Slot = "0")]
		public override bool Equals(object KANAGAAAGHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1CBA830", Offset = "0x1CB9630", VA = "0x181CBA830", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1CBAA10", Offset = "0x1CB9810", VA = "0x181CBAA10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FMLGPFBAIAN
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1CB88D0", Offset = "0x1CB76D0", VA = "0x181CB88D0")]
	public static StaticEdge LKNPCKIALBL(this BEJDGGCOHDO HLCOOGAGOEK)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct OFIHMNDIPNH : IEquatable<OFIHMNDIPNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string FKJJGKIGADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly int GBMBDACHNAB;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x170FDF0", Offset = "0x170EBF0", VA = "0x18170FDF0")]
	public OFIHMNDIPNH(string PHPPAMIKEEH, int KBPOOJNMCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8BE0", Offset = "0x1CB79E0", VA = "0x181CB8BE0", Slot = "4")]
	public bool Equals(OFIHMNDIPNH LCIDHBCOPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct KBOLLCIFDHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string NKCKPGIEOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly LCIGCODLFKA.FFJMBHEICPN.HPKGDGOPEFC HIALADOGBNC;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x170FDF0", Offset = "0x170EBF0", VA = "0x18170FDF0")]
	public KBOLLCIFDHB(string NDLLBBKGIJD, LCIGCODLFKA.FFJMBHEICPN.HPKGDGOPEFC FBDBDJGGPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8B20", Offset = "0x1CB7920", VA = "0x181CB8B20")]
	internal static KBOLLCIFDHB LKNPCKIALBL(LCIGCODLFKA KNAIEKIJLBC)
	{
		return default(KBOLLCIFDHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8B70", Offset = "0x1CB7970", VA = "0x181CB8B70")]
	internal LCIGCODLFKA OJBJHHLKILJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8AB0", Offset = "0x1CB78B0", VA = "0x181CB8AB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8A00", Offset = "0x1CB7800", VA = "0x181CB8A00", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8BE0", Offset = "0x1CB79E0", VA = "0x181CB8BE0")]
	public bool PMFKIKELGCM(KBOLLCIFDHB LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8C30", Offset = "0x1CB7A30", VA = "0x181CB8C30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct MNNKBBNDIMM : IEquatable<MNNKBBNDIMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly DDLALFALBLB AJPCLBEOHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string GCOFHNNFNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly IReadOnlyDictionary<BEBLNOOFELI<INBNJBDFPHO>, OFIHMNDIPNH> MICGGABLILH;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool ACDJDJBKPCD
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1CB90A0", Offset = "0x1CB7EA0", VA = "0x181CB90A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1CBA380", Offset = "0x1CB9180", VA = "0x181CBA380")]
	public MNNKBBNDIMM(DDLALFALBLB BLLMJJIEHEK, IReadOnlyDictionary<BEBLNOOFELI<INBNJBDFPHO>, OFIHMNDIPNH> GOJLHCMHDNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1CB98D0", Offset = "0x1CB86D0", VA = "0x181CB98D0")]
	public static MNNKBBNDIMM NHOIHCLIPLB(MNNKBBNDIMM EAKPDAOOLMF, MNNKBBNDIMM HMMBLHHCIOL)
	{
		return default(MNNKBBNDIMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1CB9580", Offset = "0x1CB8380", VA = "0x181CB9580")]
	public static MNNKBBNDIMM LKNPCKIALBL(EHNAHDFAMPK KNAIEKIJLBC)
	{
		return default(MNNKBBNDIMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1CBA1E0", Offset = "0x1CB8FE0", VA = "0x181CBA1E0")]
	public EHNAHDFAMPK OJBJHHLKILJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1CB9120", Offset = "0x1CB7F20", VA = "0x181CB9120", Slot = "4")]
	public bool Equals(MNNKBBNDIMM LCIDHBCOPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct DDLALFALBLB : IEquatable<DDLALFALBLB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string NKCKPGIEOEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly IReadOnlyList<KBOLLCIFDHB> ELKKKACNHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly IReadOnlyList<KBOLLCIFDHB> KOKPAKJGFOB;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ACDJDJBKPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1CB7C10", Offset = "0x1CB6A10", VA = "0x181CB7C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x19743C0", Offset = "0x19731C0", VA = "0x1819743C0")]
	public DDLALFALBLB(string NDLLBBKGIJD, IReadOnlyList<KBOLLCIFDHB> IPPPJIKJIOK, IReadOnlyList<KBOLLCIFDHB> ANLOCKABCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7F50", Offset = "0x1CB6D50", VA = "0x181CB7F50")]
	public static DDLALFALBLB LKNPCKIALBL(CFJPLGIGKCJ KNAIEKIJLBC)
	{
		return default(DDLALFALBLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1CB8230", Offset = "0x1CB7030", VA = "0x181CB8230")]
	public CFJPLGIGKCJ OJBJHHLKILJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7ED0", Offset = "0x1CB6CD0", VA = "0x181CB7ED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7CE0", Offset = "0x1CB6AE0", VA = "0x181CB7CE0")]
	private static int FGAEDBPNGGM(IReadOnlyList<KBOLLCIFDHB> IACELFLAPAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1CB7C30", Offset = "0x1CB6A30", VA = "0x181CB7C30", Slot = "4")]
	public bool Equals(DDLALFALBLB LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1CB84C0", Offset = "0x1CB72C0", VA = "0x181CB84C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum PJPOBLJMCAB
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class IPHBJNCOJCB
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xAFA1F0", Offset = "0xAF8FF0", VA = "0x180AFA1F0")]
	public static bool IJCEHAJKBLK(this PJPOBLJMCAB HGDPOIIJHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xAFA1F0", Offset = "0xAF8FF0", VA = "0x180AFA1F0")]
	public static bool GHPOIPJKFJG(this PJPOBLJMCAB HGDPOIIJHAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xAFA1F0", Offset = "0xAF8FF0", VA = "0x180AFA1F0")]
	public static bool FNOICCNCCIC(this PJPOBLJMCAB HGDPOIIJHAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum NBONJLHKIEP
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct IDOIOGNGCLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool EMHFGOEFOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly NBONJLHKIEP PJCNOOLIFDH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1CB89F0", Offset = "0x1CB77F0", VA = "0x181CB89F0")]
	public IDOIOGNGCLE(bool JOOKOCEGACL, NBONJLHKIEP NBGKEADJOCL)
	{
	}
}
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum TypeKey
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Bool,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Int,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		Float,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Color
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
