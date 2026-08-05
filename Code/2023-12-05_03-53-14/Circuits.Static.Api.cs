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
		[Cpp2IlInjected.Address(RVA = "0x79B610", Offset = "0x79AA10", VA = "0x18079B610")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CCCC40", Offset = "0x1CCC040", VA = "0x181CCCC40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x79C170", Offset = "0x79B570", VA = "0x18079C170")]
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
		[Cpp2IlInjected.Address(RVA = "0x79C1B0", Offset = "0x79B5B0", VA = "0x18079C1B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DCGKLMBAPGE
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
public readonly struct KPPOHPDEAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly PFIKAFBDBJC EIHLKLEHACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly LMAILBALBOE DFNBFIJGGLH;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCB40", Offset = "0x1CCBF40", VA = "0x181CCCB40")]
	public KPPOHPDEAGL([In] PFIKAFBDBJC BMAKDMAHBAB, LMAILBALBOE KEBJLCHLPPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct PFIKAFBDBJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly NCBAEBODCHN IDDKCODKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly JMEGHILKONK EMOEOLKNKEC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82CAC0", Offset = "0x82BEC0", VA = "0x18082CAC0")]
	public PFIKAFBDBJC(NCBAEBODCHN LJIMDIMDAAK, JMEGHILKONK IAOCDLPJLCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct LMAILBALBOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly DKFNCBPCAHP FIOKHANFCOI;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
	public LMAILBALBOE(DKFNCBPCAHP MMJCEIGABEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public readonly struct JKIDIOKLHLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly NDHHEHOGCDH PEJFKEAPIGG;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x871B40", Offset = "0x870F40", VA = "0x180871B40")]
	public JKIDIOKLHLF(NDHHEHOGCDH BAPPOINFDAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum EBLLNNBHJPO
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
public enum DGLKBJCPHKD
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
public interface JHHDDCMKBCA : GKCGBOILFAE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeRecorderData(string JBDAIHCLNJM, Action<string, float> NCBBAKKHJIA);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LNAJLKOOAPJ : AMOKDDIKKGP
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEMMFPIEEOA();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GKCGBOILFAE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnHide();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DoneEditing();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface HGFCKJAPKNI
{
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CJCKMHONKJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	string DJMDIKJBEJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int KNFALKMFMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HJNHFMICIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BPEFCMEJEML : AMOKDDIKKGP
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKKEPFPDOJH(AMOKDDIKKGP NBJNLLBBLLL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILNOFIHDCKG();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBMDGHADMGB(AMOKDDIKKGP NBJNLLBBLLL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AMFJGOPJCBB
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FDILJAFEDGM(string EDGDGCBFPBF, Func<string> GELGLLGMFDP, Action<string> JJPPLLDOAKM, Func<bool> AOPDOABHAKE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JLOBDFKFCPG(string EDGDGCBFPBF, Action EELJAFLIHAM, Func<bool> AOPDOABHAKE);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LILGEPDBCGH(string EDGDGCBFPBF, Func<int> MGHIGAKCLCG, Action<int> GEEPMNCEEKP, Func<bool> AOPDOABHAKE);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHMFKKEEDKA(string EDGDGCBFPBF, Func<int> GELGLLGMFDP, Action<int> JJPPLLDOAKM, Func<bool> AOPDOABHAKE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHELJNENDKG(string EDGDGCBFPBF, Func<int> MDKHHGACNLM, Action<object> BOOOMFDDCMI, Func<object, string> PPNDLFIDECI, Func<bool> AOPDOABHAKE, Type EOJNCJPELFD, IReadOnlyList<object> EBGOFDKMIDM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IIGJHOBNDEN(string EDGDGCBFPBF, Func<string> GELGLLGMFDP, Action<string> JJPPLLDOAKM, Func<bool> AOPDOABHAKE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GELIMLFIOFF(string EDGDGCBFPBF, Func<bool> GELGLLGMFDP, Action<bool> JJPPLLDOAKM, Func<bool> AOPDOABHAKE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OMCFIOLFNKK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface AEFECLIGHML
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Action<OMCFIOLFNKK>? AEMBMNFOKJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Action<OMCFIOLFNKK>? HPEIKIEJJNH
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
		AMOKDDIKKGP PBLPKNBKFMF(Func<bool> OHNLLEJKCKA, Action<bool> HDPAPIPAPKO, Func<byte> GHDFFBIIHJP, Action<byte> EOHJAKBJAJC, Func<int> LHBIHMEACGP, Action<int> MGFFJBADEGO, Func<IReadOnlyList<string>> CAOGHDICGBM, Action<IReadOnlyList<string>> FPGENDMLJFN, [Optional] Func<bool>? AOPDOABHAKE);

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void HJDKHMKGFNK();

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HGHHPMFKOJK(AMOKDDIKKGP NBJNLLBBLLL);
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	AEFECLIGHML DOBIHNOICMN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AMOKDDIKKGP NOOFJIOPMMM(Action EELJAFLIHAM, string EDGDGCBFPBF = "", [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AMOKDDIKKGP FCMEBKNOOKA(IReadOnlyList<AMOKDDIKKGP> OHFHGCFJPNC, [Optional] float? LOMNOIKJMJL, [Optional] int? NLCJLNALCII, [Optional] bool? PHKKEOKDMLI);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AMOKDDIKKGP LCCIEFBIDGB(IReadOnlyList<AMOKDDIKKGP> OHFHGCFJPNC, [Optional] float? LOMNOIKJMJL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AMOKDDIKKGP AKMNELOOCCM(Func<int> MGHIGAKCLCG, Action<int> GEEPMNCEEKP, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, bool NNBLMPDDOIC = false, string EDGDGCBFPBF = "Color", [Optional] Func<bool>? DKINMKGPEMJ, bool IKNBAHOKJNG = true, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AMOKDDIKKGP FMNAJOLMNAG(Action EELJAFLIHAM, string EDGDGCBFPBF = "", [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AMOKDDIKKGP DCGBNLPIDCD(AMOKDDIKKGP NBJNLLBBLLL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BPEFCMEJEML JKILKCMFAGL(int CLNHOKCOILM, string EDGDGCBFPBF, string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] List<AMOKDDIKKGP>? OHFHGCFJPNC, [Optional] Func<bool>? AOPDOABHAKE, bool IIGDFDBCBHD = true, [Optional] Func<bool>? CAPOFFHFAPG, [Optional] Action<bool>? JHKHKGFBKMI, [Optional] float? NIOKLMNHMAK);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AMOKDDIKKGP LFJFIIPCEKD(string NDJGKCEMAJF, [Optional] Func<bool>? AOPDOABHAKE);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	AMOKDDIKKGP DNCDJBCECJE(Func<string> GELGLLGMFDP, Action<string> JJPPLLDOAKM, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] int? LJLEPFPJMBG, bool KFDONHLABPL = false, string EDGDGCBFPBF = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	AMOKDDIKKGP CLKHMOMHIBC(Func<float> GELGLLGMFDP, Action<float> JJPPLLDOAKM, string EDGDGCBFPBF = "", string IBOIOJHBFFE = "", string HINJBFJJDNN = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", bool GJLDHCPDBBG = false, float ECFBBGEEPCF = 0f, float CNMLFNEKDLO = 1000f, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "11")]
	AMOKDDIKKGP GBFLDCFIJCJ(Func<int> GELGLLGMFDP, Action<int> JJPPLLDOAKM, string EDGDGCBFPBF = "", [Optional] Func<string>? KLALNIMFLKP, string IBOIOJHBFFE = "", [Optional] Func<string>? MNMHAKECLLE, string HINJBFJJDNN = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", bool GJLDHCPDBBG = false, int ECFBBGEEPCF = 0, int CNMLFNEKDLO = 1000, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "12")]
	AMOKDDIKKGP OJCOGKNKOGC(Type EOJNCJPELFD, IReadOnlyList<object> EBGOFDKMIDM, Func<int> MDKHHGACNLM, Action<object> BOOOMFDDCMI, string EDGDGCBFPBF = "", string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<object, string>? PPNDLFIDECI, bool DONFGECENGB = true, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AMOKDDIKKGP PCOBIGPKPPM(Func<string> GELGLLGMFDP, Action<string> JJPPLLDOAKM, int AGIKNGIHABG = 1000, DGLKBJCPHKD FGOACFJMMOA = DGLKBJCPHKD.Alphanumeric, [Optional] Func<string, bool>? HGAGEBLIFMG, [Optional] string? HHHIIOBHDCM, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, string EDGDGCBFPBF = "", string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", bool KFDONHLABPL = false, [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AMOKDDIKKGP JLNEMGKGHCN(Func<float> GELGLLGMFDP, Action<float> JJPPLLDOAKM, float ECFBBGEEPCF = 0f, float CNMLFNEKDLO = 1000f, [Optional] Func<bool>? GEHICJKJFLF, int MHPIAOHLGFI = -1, string EDGDGCBFPBF = "", string IBOIOJHBFFE = "", string HINJBFJJDNN = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] Func<float, float>? EGHOFMAGEAM, [Optional] Func<float, float>? BIFKGNFMKCJ, [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AMOKDDIKKGP LCOGEJBDLHP(Func<string> GELGLLGMFDP, Action<string> JJPPLLDOAKM, Action EELJAFLIHAM, [Optional] Func<bool>? AOPDOABHAKE, DGLKBJCPHKD FGOACFJMMOA = DGLKBJCPHKD.Alphanumeric, [Optional] Func<string, bool>? HGAGEBLIFMG, EBLLNNBHJPO OCBIBMEAIGC = EBLLNNBHJPO.Alphanumeric, [Optional] string? HHHIIOBHDCM, [Optional] List<AMOKDDIKKGP>? NNMJPKBCLNC, string EDGDGCBFPBF = "", string JEHIAJEIEGF = "", string EDJGDFCGFME = "", string BDKPFMLGJCJ = "", bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	AMOKDDIKKGP KGHAKIEHKIH(Func<string> GELGLLGMFDP, Action<string> JJPPLLDOAKM, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] int? LJLEPFPJMBG, bool KFDONHLABPL = false, string EDGDGCBFPBF = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	AMOKDDIKKGP FKELBFAMJMP(Func<bool> GELGLLGMFDP, Action<bool> JJPPLLDOAKM, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, string EDGDGCBFPBF = "", string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] int? CLNHOKCOILM, [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	AMOKDDIKKGP HBOOMANNLLE(Func<bool> GELGLLGMFDP, Action<bool> JJPPLLDOAKM, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, string EDGDGCBFPBF = "", string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] int? CLNHOKCOILM, [Optional] Func<bool>? DKINMKGPEMJ, [Optional] Func<bool>? DCFKIAFCHOI, string ILNAEFBHJLA = "", [Optional] Func<string>? IHCGDIECPKF, string DDDIPKIEDJN = "", [Optional] Func<string>? OMFLLCFDBDC, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	LNAJLKOOAPJ OCIKGLFIGOE(Dictionary<string, JGFJPPAAAPI> HFLNDIDMJFD, Func<int> MGHIGAKCLCG, Action<int> GEEPMNCEEKP, string EDGDGCBFPBF, string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] Action? ODOEMJHBHIF, [Optional] Action? JNDCICPPGOK, [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<int, string>? NICLCACAPBM, bool DONFGECENGB = true, bool MICFEMIPMAA = true, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	LNAJLKOOAPJ NEPIFLPBKCP(Func<Dictionary<string, JGFJPPAAAPI>> HHLKBMLHCFM, Func<int> MGHIGAKCLCG, Action<int> GEEPMNCEEKP, string EDGDGCBFPBF, string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<bool>? GOEBAJGHAGE, [Optional] Func<int, string>? NICLCACAPBM, bool DONFGECENGB = true, bool MICFEMIPMAA = true, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	AMOKDDIKKGP FDKFPKOBPED(Func<List<KeyValuePair<string, JGFJPPAAAPI>>> HHLKBMLHCFM, Func<int> MGHIGAKCLCG, Action<int> GEEPMNCEEKP, string EDGDGCBFPBF, string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<bool>? GOEBAJGHAGE, [Optional] Func<int, string>? NICLCACAPBM, [Optional] Action? ODOEMJHBHIF, [Optional] Action? JNDCICPPGOK, bool DONFGECENGB = true, bool MICFEMIPMAA = true, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	AMOKDDIKKGP AMIPAJNJCDC(Func<List<object>> HHLKBMLHCFM, Func<object> MDKHHGACNLM, Action<object> BOOOMFDDCMI, Func<object, string> PPNDLFIDECI, string EDGDGCBFPBF = "", string IBOIOJHBFFE = "", string JEHIAJEIEGF = "", string PCHFPKHGNNB = "", [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, bool DONFGECENGB = true, bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	AMOKDDIKKGP OJMBEAFOPCL(string EDGDGCBFPBF, Func<object> MDKHHGACNLM, Action<object> BOOOMFDDCMI, Func<object, string> PPNDLFIDECI, Func<IReadOnlyList<object>> EIKBCELGMLN, [Optional] Func<bool>? AOPDOABHAKE);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CFAICHEGPHN(AMOKDDIKKGP NBJNLLBBLLL);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NAFONMHACPO(string MNKGOJGPDMH, Action? ANIJHNMIAMD, bool AIHIDJLDMFN, string KIGOLOGCPEI, Action? PKLNNGILGHJ, string KCFFPPIEBHH, string NADJOGPFAND);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AFKKPEDEFJO(Func<string> GELGLLGMFDP, Action<string> JJPPLLDOAKM, Action EELJAFLIHAM, [Optional] Func<bool>? AOPDOABHAKE, DGLKBJCPHKD FGOACFJMMOA = DGLKBJCPHKD.Alphanumeric, [Optional] Func<string, bool>? HGAGEBLIFMG, EBLLNNBHJPO OCBIBMEAIGC = EBLLNNBHJPO.Alphanumeric, [Optional] string? HHHIIOBHDCM, [Optional] List<AMOKDDIKKGP>? NNMJPKBCLNC, string EDGDGCBFPBF = "", string JEHIAJEIEGF = "", string EDJGDFCGFME = "", string BDKPFMLGJCJ = "", bool EKMPBLBLDCL = true);

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EDAPKBMFJIO(string GMMHGFDJEJM);

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "28")]
	AMOKDDIKKGP EENDBGKABGO(List<object> HFLNDIDMJFD, List<string> PPNDLFIDECI, Func<int> MGHIGAKCLCG, Action<int> GEEPMNCEEKP, string CENFECLMGBJ = "", [Optional] Func<bool>? AOPDOABHAKE, [Optional] Func<bool>? LHHHDNMHLGF, [Optional] Func<bool>? DKINMKGPEMJ, bool EKMPBLBLDCL = true, bool FKBKOAJDLGP = false);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AMOKDDIKKGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IGANGJJGDNC
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFHGCOCJLIP();
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ODFKKJDAKEO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPJAHOPKKHJ();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJEKLCCPMAE(string NFPNHJDBDDK, [In] DADKNKEIKDG DDJLPLIEHMO);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PENKAGNHDGA(string KCFFPPIEBHH);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void COBIDCCEDMG(string NDJGKCEMAJF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface MDONBMLNIND
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool GFIPGOEAGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EIGECEIAENE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool KJPJHCGGMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MPMLLJKFCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PMILMKMBDKG(Guid CDDILJNOPLC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ELKKKIKMEEH(JAOLGFHDKJL KKOACPFFAML, IReadOnlyDictionary<OAOLHLLLMNK<OEPBFKIMMIA>, Guid>? PDNPBMCPDMC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CKEBHKPOLLF(JAOLGFHDKJL KKOACPFFAML);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CDJBHFPKJIF(JAOLGFHDKJL KKOACPFFAML, IReadOnlyDictionary<OAOLHLLLMNK<OEPBFKIMMIA>, Guid>? PDNPBMCPDMC);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LIIPBKIPNPF(OAOLHLLLMNK<DBNCELMKNDL> CDDILJNOPLC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface OJOGNEOALFO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OBPBNMACFOC? NMGLFNHIICP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool CMDDKGFGFFA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NDMNFLNKCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<OBPBNMACFOC> IEPAGCGEIMB();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EFPDAHOJLMO<PFIKAFBDBJC, MLDPNJCMKGI> LMMFPAEPFJM([In] PFIKAFBDBJC GCFNFLLJJLD, IEnumerable<GGMHGDCHGBB> NIFDIPPDFLH, int KALNHEBKHEP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface OBPBNMACFOC
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public readonly struct MDIFHFDLEPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly DEOPKAALPDI OJJGOOHLEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly JKIDIOKLHLF LKLHLCCOALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly IEnumerable<GGMHGDCHGBB> MHKMDAAIKCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly bool MHEJDMKHFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly OAOLHLLLMNK<OEPBFKIMMIA> CLHCHDBFCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly int? JBOGDBBKOFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly BOPPJOLNCCI? AGJIGDICAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly BOPPJOLNCCI? HODGPHBMABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public readonly MODMNLNEPFE? DCFIKIKALLK;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1CCCB80", Offset = "0x1CCBF80", VA = "0x181CCCB80")]
		public MDIFHFDLEPK(DEOPKAALPDI LJPPPJEBNNG, [In] JKIDIOKLHLF GCFNFLLJJLD, IEnumerable<GGMHGDCHGBB> NIFDIPPDFLH, bool HGOMEEGAMNE, [In] OAOLHLLLMNK<OEPBFKIMMIA> BLKKFGICLAH, int? IPACNBMGBOD, [In] BOPPJOLNCCI? JOMJPCLCGIO, [In] BOPPJOLNCCI? GCFIPBEIBAI, [In] MODMNLNEPFE? IECANIJMPGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public readonly struct MODMNLNEPFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly IReadOnlyCollection<ByteString> EGDFEJPCHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly IReadOnlyCollection<ByteString> JCLLFEKLHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly IReadOnlyCollection<ByteString> DIMMOECFBFA;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x19B4680", Offset = "0x19B3A80", VA = "0x1819B4680")]
		public MODMNLNEPFE(IReadOnlyCollection<ByteString> KGKBBFMDMJM, IReadOnlyCollection<ByteString> CHMEDMHDJFL, IReadOnlyCollection<ByteString> FNMOFNMADFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct GCDMJDLGGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly JKIDIOKLHLF LKLHLCCOALG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly IReadOnlyDictionary<Guid, Guid> HDLEMHLGHJL;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA4B0", Offset = "0x1CC98B0", VA = "0x181CCA4B0")]
		public GCDMJDLGGBE(JKIDIOKLHLF GCFNFLLJJLD, IReadOnlyDictionary<Guid, Guid> LJDLCHANKMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EIHLGDDJJLI? JBFBNIMHBMG([In] OAOLHLLLMNK<OEPBFKIMMIA> KNOGOHBGIDL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LDNBLGKMKLB? JPDPGDCHHOO([In] OAOLHLLLMNK<ABLFAKCHCDH> OLLLMHFOLHJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<DFCKBIANOIL> GOKFFNKBOIO(bool AAEOAIALJBB, bool JLIOJCLIMJG, bool JKEFPFGPKAJ, bool AHOLCBHONBI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EFPDAHOJLMO<GCDMJDLGGBE, MLDPNJCMKGI> DEPKACNFABJ([In] MDIFHFDLEPK IFILEFKNBLN);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KPPOHPDEAGL AGPACEJHDHB(IEnumerable<GGMHGDCHGBB> NIFDIPPDFLH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KPPOHPDEAGL LFJAOIGFMEF();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JKIDIOKLHLF CGJIFNIAIFJ(DEOPKAALPDI LJPPPJEBNNG, JLMPPIICGFM<OEPBFKIMMIA> IACMBEIPAIP, IEnumerable<OAOLHLLLMNK<ABLFAKCHCDH>> FGNLFBPJJGE, IEnumerable<GGMHGDCHGBB> NIFDIPPDFLH);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FBPOMDLEMKI : IPODJHHPEOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OJOGNEOALFO IHGDGFMCNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface CKBHJGGJPMD : MLDPNJCMKGI
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface EIHLGDDJJLI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	EPIBGBGFOBB? BLPDBNGKBDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface BEMJAKJNNEE : DNMBNDFMKGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	JLMPPIICGFM<LAEPBCLMJCB> DLEANMNPFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool EGPFJCOHMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPNAODEMCGB(IGANGJJGDNC GOAJFJEBBEO);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMHMGNOFDFE(AMFJGOPJCBB IFIEJJCAJKO);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "4")]
	string BLNMIDCOHGE(int MEHPPAAAOIE);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNHMGMONNAM(DKOJPCOGJEC NLMJPNNDBFP);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DNNBOMDKMIC(DKOJPCOGJEC NLMJPNNDBFP);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DKOJPCOGJEC
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnDefaultValueChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface LDNBLGKMKLB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	object JIDIONOIDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OAOLHLLLMNK<DBNCELMKNDL> DNPLLCDPHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CCBBIGMDEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int EGNDENEKJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DADKNKEIKDG DFELAEDKIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string JPPKCPJOPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NodeVisualizationKey BOGLOOJGMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	JLMPPIICGFM<DKJNAMJBHEL> OKKJPLEDLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AMOHNOPFHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PBMMAKJFKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	BHJMCOCNBNP OAHBBJJIOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GCBJBIOPHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool FNPBNGCGKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MAGLGOJIMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	int HJFNBNNPBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool MIGAANOGDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	string KDDBPFGLCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool PMILMKMBDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool DKLGGEGGFOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool MIBJAJFHEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool MINALEBJHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IIAOIPHBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	KJIKFLKINEB ELIFPOBKNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	PDJGENNOLCE NPADIBBPDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	[BKALILCJAOO(true, "FloatingText")]
	bool DIOIBCDAINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CJCKMHONKJP? AFNGKBPHJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	OAOLHLLLMNK<OEPBFKIMMIA> MHAAHHEAAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	[GBPNDICKPEO("This isn't great UX and we should consider removing it.")]
	bool DNGGMBBJMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	OAOLHLLLMNK<OEPBFKIMMIA>? FHFJFKDMFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "53")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	IEnumerable<OAOLHLLLMNK<ABLFAKCHCDH>>? ONIOGBNJOJL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool NPDAIDHAPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool LBLDNEFDHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OAOLHLLLMNK<ABLFAKCHCDH> IHJAPDHGMGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	JCFEIICDFKL<FINPOFMOLBI, MNDHPFDIGMF> AOODDEJOCBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JLMPPIICGFM<FINPOFMOLBI>? AMMABBDAOJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action DEBPMKOODOA;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event KLNAFJGBHKD CILNPPNLKHM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EKMFJPPLGPC JJMPLACGNAC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action COBLBCFDCAA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action CDKCOHEOGJM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JLMPPIICGFM<FINPOFMOLBI>, MNDHPFDIGMF> GEMJJPDNLIE;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JLMPPIICGFM<FINPOFMOLBI>> LPDILFGENLE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<JLMPPIICGFM<FINPOFMOLBI>, MNDHPFDIGMF> BFPNKACGKPI;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<JLMPPIICGFM<FINPOFMOLBI>, JLMPPIICGFM<FINPOFMOLBI>> HDENFOHNMEK;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<JLMPPIICGFM<FINPOFMOLBI>, MNDHPFDIGMF> MPKGLIDECJD;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EAKAIKCKIII(int EHFGJKHLGDC);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	bool OELMEALAMOA([In] KJIKFLKINEB NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	bool IILJLJMKIFH([In] PDJGENNOLCE NMENOOMOOJP);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LJCGJCALJFD();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> NDPNOOEKJOD(KJIKFLKINEB? GOPGKDKAOFI, PDJGENNOLCE? MKPFBAOBFNN);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OJALHHKALCJ();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void HBNILEKKOFF();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void IKDNCIGMCMH();

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool DNPBGDPGNOJ([Out] Guid NDKFLFGGIJB);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool AHJBFONOGLJ([In] Guid KNOGOHBGIDL);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void MADHOJJNIDP();

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void HINFAPDEBAJ(bool JOLIFGGBPNO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "46")]
	GKCGBOILFAE IICNAOBOFAO([In] JHHDDCMKBCA KDEAJCONAPP);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NJEDGLIILGD(object AIOHNKHDMHB);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void AHANHEPIIKO(object AIOHNKHDMHB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void BMHMGNOFDFE(OMCFIOLFNKK FJJOFCJBNAI);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "72")]
	BOPPJOLNCCI GPNMJCKPKAM();

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> DDAMJIOAOHH(JLMPPIICGFM<FINPOFMOLBI> KJJDFNIJPJE);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface HHFIBPCPCFN : DNMBNDFMKGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JLMPPIICGFM<CJDOCELDLDG> MPLNIHIEGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DNMBNDFMKGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IEnumerable<StaticEdge> CFMLLJPLIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	DisplayKind PHALBPBMDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	OAOLHLLLMNK<OEPBFKIMMIA> MHAAHHEAAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	OAOLHLLLMNK<ABLFAKCHCDH> IHJAPDHGMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	JLMPPIICGFM<FINPOFMOLBI> BLGENANGLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	JLMPPIICGFM<PPPDPJGNAHJ> LEMIOKNCKEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	JKPHFEOAHLM PJLLBJDAPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	PortImage PHEBHFJMCKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HIGJOIADLPM(DNBMGHDJPBO NLMJPNNDBFP);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GDLKNCBAGEK(ONELKDBBFCK NLMJPNNDBFP);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PBOMGCIGKDJ(ODFKKJDAKEO DBHFKOKBCNC);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ADOIFCLGFNN(DNBMGHDJPBO NLMJPNNDBFP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OFIHDLKNOGP(ONELKDBBFCK NLMJPNNDBFP);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface DNBMGHDJPBO
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnIsConnectedChanged();

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnInferredTypeChanged();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface MNDHPFDIGMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate void CPDBJEOKFNK(JLMPPIICGFM<FINPOFMOLBI> HHMFGBLJOPM, JLMPPIICGFM<FINPOFMOLBI> BMHEBBMIDGK);

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool ANCMCCBHOEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool OECONAGAMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool GBBCNPGNBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OAOLHLLLMNK<OEPBFKIMMIA> MHAAHHEAAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool IIPJKLPFPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JCFEIICDFKL<LAEPBCLMJCB, BEMJAKJNNEE> FDPBHIGMOML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	OAOLHLLLMNK<ABLFAKCHCDH> IHJAPDHGMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	JCFEIICDFKL<CJDOCELDLDG, HHFIBPCPCFN> LBMKNFPKIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	JLMPPIICGFM<FINPOFMOLBI> BLGENANGLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action PEMMPOMMAHN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action MIOJEELIKKF;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JLMPPIICGFM<LAEPBCLMJCB>, JLMPPIICGFM<LAEPBCLMJCB>> BCCFJNOHMOD;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<JLMPPIICGFM<CJDOCELDLDG>, JLMPPIICGFM<CJDOCELDLDG>> AKJIEAPKFJP;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	event Action<JLMPPIICGFM<LAEPBCLMJCB>, BEMJAKJNNEE> GOMEGCGGNKI;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	event Action<JLMPPIICGFM<LAEPBCLMJCB>> KBAJOKGKMBC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	event Action<JLMPPIICGFM<LAEPBCLMJCB>, BEMJAKJNNEE> HBMHMKNIFGL;

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	event Action<JLMPPIICGFM<CJDOCELDLDG>, HHFIBPCPCFN> KKBOAIFPFKN;

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	event Action<JLMPPIICGFM<CJDOCELDLDG>> HNLGIGEBADK;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event Action<JLMPPIICGFM<CJDOCELDLDG>, HHFIBPCPCFN> DFHNLKCAHID;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> HBCMOPEFFLM();

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> FIHOKKEHJAE(JLMPPIICGFM<PJNBBEJLIEA> JHPOIDHOMCN);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> APGCGFFAADF(JLMPPIICGFM<DNGJJANAMEL> CPKACGIBJLC);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> AMAOPJAMACC(JLMPPIICGFM<PJNBBEJLIEA> JHPOIDHOMCN, JLMPPIICGFM<PJNBBEJLIEA> AGEHEDEHLJE);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "34")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> HLEJLOIHNII(JLMPPIICGFM<DNGJJANAMEL> CPKACGIBJLC, JLMPPIICGFM<DNGJJANAMEL> AGEHEDEHLJE);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "35")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> BGHEKBMNBCB();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> ANLFKFGDFOD(string MNKIIDHFPPP);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "37")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> OIGFMJLHIHE(JLMPPIICGFM<PJNBBEJLIEA> JHPOIDHOMCN, string MDFAJJKMBAI);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> BFLNGJILBKO(JLMPPIICGFM<DNGJJANAMEL> CPKACGIBJLC, string MDFAJJKMBAI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> KLBELAKINFJ(JLMPPIICGFM<PJNBBEJLIEA> JHPOIDHOMCN, DFCKBIANOIL LFLAEPCPMDG);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<EFPDAHOJLMO<CPIOBHNHOJN, CKBHJGGJPMD>> BIDBPEOFIKN(JLMPPIICGFM<DNGJJANAMEL> CPKACGIBJLC, DFCKBIANOIL LFLAEPCPMDG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DFCKBIANOIL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	TypeKey LCLDDCMJFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	string KCPKOHFPGPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<EFPDAHOJLMO<JLMPPIICGFM<PJNBBEJLIEA>, CKBHJGGJPMD>> KKLELPFNILP(OAOLHLLLMNK<OEPBFKIMMIA> KNOGOHBGIDL, OAOLHLLLMNK<ABLFAKCHCDH> OLLLMHFOLHJ, JLMPPIICGFM<FINPOFMOLBI> KJJDFNIJPJE, string MDFAJJKMBAI);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<EFPDAHOJLMO<JLMPPIICGFM<DNGJJANAMEL>, CKBHJGGJPMD>> EPLMEGOKLJC(OAOLHLLLMNK<OEPBFKIMMIA> KNOGOHBGIDL, OAOLHLLLMNK<ABLFAKCHCDH> OLLLMHFOLHJ, JLMPPIICGFM<FINPOFMOLBI> KJJDFNIJPJE, string MDFAJJKMBAI);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface ONELKDBBFCK
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnPortTraversed([In] NJHBLPNFGFD LOGFBJHCJHP);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JKPHFEOAHLM
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool CBAFGKADNOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool GGNBNMPCFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	TypeKey BOGLOOJGMOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool LCJFAIELIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public sealed class DBNCELMKNDL
{
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public sealed class OEPBFKIMMIA
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class ONECNONJLMB : JJEPBIABIPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class PJNBBEJLIEA
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class ABLFAKCHCDH
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class FHCHEHHBNPM
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class IODMFJLPIJF : JJEPBIABIPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class DNGJJANAMEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class JJEPBIABIPG
{
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GBPNDICKPEO("Port groups are known as node groups in legacy codebase. We should rename node group where we see it and can do it conveniently.")]
public sealed class FINPOFMOLBI
{
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class LAEPBCLMJCB : PPPDPJGNAHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class CJDOCELDLDG : PPPDPJGNAHJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class PPPDPJGNAHJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class LBLAPFJLHJJ
{
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class DKJNAMJBHEL
{
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class GPFLBFEGLKP
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class ECAGOPEMKHC
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
public readonly struct EPIBGBGFOBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly OAOLHLLLMNK<ABLFAKCHCDH> LHBDMGGOOMO;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA380", Offset = "0x1CC9780", VA = "0x181CCA380")]
	public EPIBGBGFOBB([In] OAOLHLLLMNK<ABLFAKCHCDH> CABKGAJCKGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public delegate void HOHJJNEBKHJ([In] NJHBLPNFGFD LOGFBJHCJHP);
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
public delegate void KLNAFJGBHKD([In] KJIKFLKINEB CMMBCMGJFFP);
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct GLBCKOEEGMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly DFCKBIANOIL ILNCAAJJGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly DFCKBIANOIL PAKBODHONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly DFCKBIANOIL MNFGBPLMDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly DFCKBIANOIL NEKEFEMNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly DFCKBIANOIL NDCENHBJAJN;

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xF55A20", Offset = "0xF54E20", VA = "0x180F55A20")]
	public GLBCKOEEGMH(DFCKBIANOIL AIHPAMLIKJE, DFCKBIANOIL BKFLKAAIGIA, DFCKBIANOIL NFHEEAKNGPF, DFCKBIANOIL PLOLHCPBBOA, DFCKBIANOIL AOPGBHMOBPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public delegate void EKMFJPPLGPC([In] PDJGENNOLCE AHLGILNAJNH);
namespace Circuits.Static.Api
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public readonly struct StaticEdge : IEquatable<StaticEdge>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly OAOLHLLLMNK<ABLFAKCHCDH> SrcNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly JLMPPIICGFM<FINPOFMOLBI> SrcPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly JLMPPIICGFM<CJDOCELDLDG> SrcPortId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly OAOLHLLLMNK<ABLFAKCHCDH> DstNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly JLMPPIICGFM<FINPOFMOLBI> DstPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public readonly JLMPPIICGFM<LAEPBCLMJCB> DstPortId;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1CCD4B0", Offset = "0x1CCC8B0", VA = "0x181CCD4B0")]
		public StaticEdge([In] OAOLHLLLMNK<ABLFAKCHCDH> KNAGMCCNMFI, JLMPPIICGFM<FINPOFMOLBI> IFHJJBNDOPJ, JLMPPIICGFM<CJDOCELDLDG> OEEFLJAHPIC, [In] OAOLHLLLMNK<ABLFAKCHCDH> IEGBNNHBNHB, JLMPPIICGFM<FINPOFMOLBI> FEKACMGDCJM, JLMPPIICGFM<LAEPBCLMJCB> NMGCEGGBAJE)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1CCCE60", Offset = "0x1CCC260", VA = "0x181CCCE60")]
		public static bool FCHDBNDMOOD([In] StaticEdge OJKFAPKLEMA, [In] StaticEdge BBHLJNIGCPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1CCCD70", Offset = "0x1CCC170", VA = "0x181CCCD70", Slot = "4")]
		public bool Equals(StaticEdge LFMLAKDHEFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1CCCCC0", Offset = "0x1CCC0C0", VA = "0x181CCCCC0", Slot = "0")]
		public override bool Equals(object ECLCDMJMICA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1CCCF50", Offset = "0x1CCC350", VA = "0x181CCCF50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1CCD040", Offset = "0x1CCC440", VA = "0x181CCD040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class FLAMAJDKEMP
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA390", Offset = "0x1CC9790", VA = "0x181CCA390")]
	public static StaticEdge JKMDPBEAKHM(this GJFKKEFGKCO EAODMOEAJOC)
	{
		return default(StaticEdge);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct BICDAJFIBHC : IEquatable<BICDAJFIBHC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly string KBLCOIMBECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly int DPGKKDNKONH;

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x17501B0", Offset = "0x174F5B0", VA = "0x1817501B0")]
	public BICDAJFIBHC(string CJHOCGHDDEP, int DJGADLMBNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA240", Offset = "0x1CC9640", VA = "0x181CCA240", Slot = "4")]
	public bool Equals(BICDAJFIBHC LFMLAKDHEFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct KEEKKLADEDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string MFBMONNEDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly GAEMOJPKIOI.MEPNOGPDLCG.BAHNDCPBGGK FFFJOPIEODJ;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x17501B0", Offset = "0x174F5B0", VA = "0x1817501B0")]
	public KEEKKLADEDH(string MDFAJJKMBAI, GAEMOJPKIOI.MEPNOGPDLCG.BAHNDCPBGGK PJCDDIJLCMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x1CCBBF0", Offset = "0x1CCAFF0", VA = "0x181CCBBF0")]
	internal static KEEKKLADEDH JKMDPBEAKHM(GAEMOJPKIOI KKOACPFFAML)
	{
		return default(KEEKKLADEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1CCBA60", Offset = "0x1CCAE60", VA = "0x181CCBA60")]
	internal GAEMOJPKIOI ALIOEPOJFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1CCBB80", Offset = "0x1CCAF80", VA = "0x181CCBB80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1CCBAD0", Offset = "0x1CCAED0", VA = "0x181CCBAD0", Slot = "0")]
	public override bool Equals(object ECLCDMJMICA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA240", Offset = "0x1CC9640", VA = "0x181CCA240")]
	public bool NLKGOGGMNPH(KEEKKLADEDH LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x1CCBC40", Offset = "0x1CCB040", VA = "0x181CCBC40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct IHKELIOFACE : IEquatable<IHKELIOFACE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly KEMKGILGIAB PGHFNECJBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly string KPEEPIJPLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly IReadOnlyDictionary<OAOLHLLLMNK<ECAGOPEMKHC>, BICDAJFIBHC> LAHLKEOKFPG;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool ECMFHABJICO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1CCA690", Offset = "0x1CC9A90", VA = "0x181CCA690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB7D0", Offset = "0x1CCABD0", VA = "0x181CCB7D0")]
	public IHKELIOFACE(KEMKGILGIAB AIMNGHECNMM, IReadOnlyDictionary<OAOLHLLLMNK<ECAGOPEMKHC>, BICDAJFIBHC> FNNOAMGALCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA710", Offset = "0x1CC9B10", VA = "0x181CCA710")]
	public static IHKELIOFACE COMCECGJPPN(IHKELIOFACE IALONMFFINC, IHKELIOFACE JOJMFJJDMHP)
	{
		return default(IHKELIOFACE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB480", Offset = "0x1CCA880", VA = "0x181CCB480")]
	public static IHKELIOFACE JKMDPBEAKHM(DMIDOPPCNFP KKOACPFFAML)
	{
		return default(IHKELIOFACE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1CCA4F0", Offset = "0x1CC98F0", VA = "0x181CCA4F0")]
	public DMIDOPPCNFP ALIOEPOJFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1CCB020", Offset = "0x1CCA420", VA = "0x181CCB020", Slot = "4")]
	public bool Equals(IHKELIOFACE LFMLAKDHEFO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct KEMKGILGIAB : IEquatable<KEMKGILGIAB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string MFBMONNEDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly IReadOnlyList<KEEKKLADEDH> FDPBHIGMOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly IReadOnlyList<KEEKKLADEDH> LBMKNFPKIFI;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool ECMFHABJICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x1CCC160", Offset = "0x1CCB560", VA = "0x181CCC160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x19B4680", Offset = "0x19B3A80", VA = "0x1819B4680")]
	public KEMKGILGIAB(string MDFAJJKMBAI, IReadOnlyList<KEEKKLADEDH> DGKDOPLIJNF, IReadOnlyList<KEEKKLADEDH> CGIIGHBDHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC2B0", Offset = "0x1CCB6B0", VA = "0x181CCC2B0")]
	public static KEMKGILGIAB JKMDPBEAKHM(MJMBOBEKPFM KKOACPFFAML)
	{
		return default(KEMKGILGIAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1CCBED0", Offset = "0x1CCB2D0", VA = "0x181CCBED0")]
	public MJMBOBEKPFM ALIOEPOJFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC230", Offset = "0x1CCB630", VA = "0x181CCC230", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC590", Offset = "0x1CCB990", VA = "0x181CCC590")]
	private static int PIMCGCFNMDD(IReadOnlyList<KEEKKLADEDH> MOPCODFFHED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC180", Offset = "0x1CCB580", VA = "0x181CCC180", Slot = "4")]
	public bool Equals(KEMKGILGIAB LFMLAKDHEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1CCC780", Offset = "0x1CCBB80", VA = "0x181CCC780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum DEOPKAALPDI
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	CopyPaste,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Invention
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KJHFFNNHPCF
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0xB3FB60", Offset = "0xB3EF60", VA = "0x180B3FB60")]
	public static bool DFMBHGFCFDO(this DEOPKAALPDI BKBNKNNDEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xB3FB60", Offset = "0xB3EF60", VA = "0x180B3FB60")]
	public static bool FCDLOLNPEDP(this DEOPKAALPDI BKBNKNNDEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0xB3FB60", Offset = "0xB3EF60", VA = "0x180B3FB60")]
	public static bool BHNCIPABIID(this DEOPKAALPDI BKBNKNNDEMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum EAKEDNBGIGG
{
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	GetDisplayValue,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	GetBackingValue
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public readonly struct NJHBLPNFGFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public readonly bool PMMKEFGBBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public readonly EAKEDNBGIGG NLFMNDLGCHD;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1CCCC30", Offset = "0x1CCC030", VA = "0x181CCCC30")]
	public NJHBLPNFGFD(bool HICPNDDPCMP, EAKEDNBGIGG GJDABAIDBCH)
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
