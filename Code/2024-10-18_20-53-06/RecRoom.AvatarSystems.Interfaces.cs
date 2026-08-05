using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C7B1C0", Offset = "0x6C7A5C0", VA = "0x186C7B1C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BBCEEFPPLMI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BFNDHBOFNNE HOEBEAFFMIJ(OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BFNDHBOFNNE GMDIPFNNPIO(OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CIBGHHDGNPO IEMOGPONEJF(BFNDHBOFNNE AIKOCCMKKAE, int OFIAEKGDMFK, string? DDDHPCNFCEK, string? OCJLJNPJPKG, FLOAFIFFJHG NPFAKIKEAMF, List<FIOFGMBEDNB>? KOJLKIGKMGM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CKAEDPGDCCD(INHFFNLLDDF HLMKKBLEAFL, [Out] BFNDHBOFNNE? HKAHDMHKEIF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KOKNKBODOCB(CIBGHHDGNPO DCJKICLDAJI, [Out] BFNDHBOFNNE? HKAHDMHKEIF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool OPINHPEDMOM(CIBGHHDGNPO DCJKICLDAJI, [Out] NFJNJHKNJNH? HLMKKBLEAFL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OKJNLEKGHKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NCFKEMPCADI BHLLDFNHACP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float PKBIDOPDPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NCFKEMPCADI MHPEOGEAKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 CEBEHNGKJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Quaternion IGPIPBGNHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDHEALAGHNB(GFOPDLKKFMG NMAIGNOENJN, bool OLDPCMHFMDA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLCLKBGFJNN();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPPIDJOGOEB(int IJFLBMJJJOL, float NPFDNIJCEPE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CBAGMIKGFMN();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HIKEOBAPCLA(bool JFIONMMANLA);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CBBHOGEIAIE();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FCGDLEBHGCB();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LPHKAMJNCGL(bool JFIONMMANLA);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PNMMGHHENLG(Transform DEDHJMDEEIE, Vector3 AIPIPEIGGHJ, Quaternion OOLJKOKKGHB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KMAJMHNAMGE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LDNMACGBDLI APGFLMCHHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	LDNMACGBDLI AFPLBCLGMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	CJCIOJDIDLI GNIKLDIKDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HOKJPOPDING LHHNKMACPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FHKAGHFDKOE LNOLJLEGIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OKJNLEKGHKB FPGFJAOPKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OKJNLEKGHKB EFEPJDJPKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string NIALBJBGCDK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject BCDDMHHPJBD
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	AvatarConfiguration GEMGFFCAADP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	OJHEMGLCFCA ODMIHOFOGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HeadLogicOffsets CPDLICHMFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform JOHDEJFIEOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform CNJDGOJLHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform GEJPNOHFEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Transform HJDNGILDJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 OBGMDDLJHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float KBNGAOKCAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Transform NCONFIKLHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform GJEOLPLBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Transform JPMEIOHKMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Transform MPDGLLKOIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHIIIEDBFNM(string PONIPAHEPEC, FKONMJCFGHH OCKIAHPAICI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECHJKHENBEA(CJCIOJDIDLI GMJMLMCNDLM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPMADKNNDOH();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHNAGGEMALL();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JCBBKJPBKMK(float APIOACIGING);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PMEDNGKAFAI();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BCLJBHEKBCM();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PFNBEEBPCDF();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DJNDCCMNFKN(bool NJHFCPHDEGL);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ADEKMJNNMOI([Out] Vector3 PJDACKDPNCF, [Out] Quaternion NBLNCIPHNAM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Transform NNEKPCCFGBI(string BJANEOFJHLF);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Vector3? IODPBNKADGI(string BJANEOFJHLF);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void AFJDBHAGLFB(float AKBDHFIOJCH);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JPCLDIEAMLJ(float NJDGCAEIHDO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void CFHKLPGOPPN(bool HCJEGOFACJB);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "26")]
	HandLogicOffsets MFECJJPJDPO();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "27")]
	PlatformSpecificPlayerHandOffsets AFLAJPGNJOP();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	DBGGFBFPGLA NGBGAGABHIC();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HNGHHJMOACL
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	KMAJMHNAMGE GEMNBOEOGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	Transform DHCIFDGGJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KMAJMHNAMGE CreateAvatarSystem(string PONIPAHEPEC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdatePostIKAnimControllers(float KDDKBBMEFBN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BMALLHJCHHE
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KMAJMHNAMGE PBCDAGKDPDK(string NKEIOHDBDMI, AvatarSystemConfiguration GPIDEPIIFGL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEOHNMLMGGF(string NKEIOHDBDMI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string DNACAAGCPLP(string IBDADMEEBKF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AJGMPEPJFOL
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	APNMOAFPJAL PHMJKDFPDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	FOOMCMODIOE GNDAPKEFINK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PJEMGANEAJB ELBIMFKBAKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PJEMGANEAJB DPMLHBHNFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	OBBAPCJJCDJ BEKBFOGFJJP(FaceFeatureType IAOGKLDOLJN);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	OBBAPCJJCDJ ENNBGEDABBC(FaceFeatureType IAOGKLDOLJN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "6")]
	APNMOAFPJAL DKIIOABBHCD();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FOOMCMODIOE MBDLKJJOADA();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DJNGKLBNCHI AHIIKCGAPOM();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DJNGKLBNCHI NAMOGNDKJEI();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "10")]
	DJNGKLBNCHI GGLBFLANFNJ();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DJNGKLBNCHI IIOFIPELKEF();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PJEMGANEAJB MGGJEEPCEHK();

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<KPHGBMEHLAH> BNHLBPHGCKN(AvatarItemBodyType NOLIFCMHOEP, bool LENCLEOEKAE = false);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<KPHGBMEHLAH> PFDINMCKNGB(AvatarItemBodyType NOLIFCMHOEP);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task BEHLICEIHPP(bool FAAKNKOCKMD, [Optional] CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task JLJJFFBDGDH();

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task FHGGPACNELJ(bool FAAKNKOCKMD);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task HMOLAKPHMEK(CIBGHHDGNPO AHCAAGNDLMK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NBOFHJGIADK
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 NBLCENELJHJ(FaceFeatureType IAOGKLDOLJN, OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float ELEIKDEOEJO(FaceFeatureType IAOGKLDOLJN, OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIKPMMKHFNK(OJHEMGLCFCA OFELOJDHFHP, AvatarConfiguration GPIDEPIIFGL);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJNKIELPMNB(LEJLBGPEGEO NMJLMAFGBOH, AvatarConfiguration EAJGEMFMPPA, OJHEMGLCFCA LKBBMGAGBGE, OJHEMGLCFCA OGMPMGIMOOI);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float HLJJBOPMNLK(FaceFeatureType FMEOGNKJNMN, float IFPEIOCFBIE, OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "5")]
	float LOOAJOFMACM(FaceFeatureType FMEOGNKJNMN, float GOKIBDGGDIJ, OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 LBBFMGJPJIC(FaceFeatureType FMEOGNKJNMN, Vector2 HEILLAOEIGM, OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 AABAGCPHHHA(FaceFeatureType FMEOGNKJNMN, Vector2 NIPNLAEFABE, Vector2 MNOJOFFNMEH, Vector2 FHPANMAKFLE, OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector2 CGKFOEAJALJ(FaceFeatureType FMEOGNKJNMN, Vector2 HEILLAOEIGM, Vector2 MNOJOFFNMEH, Vector2 FHPANMAKFLE, OJHEMGLCFCA OFELOJDHFHP);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "9")]
	float JNIBEEMFAGG(FaceFeatureType FMEOGNKJNMN, float GOKIBDGGDIJ, OJHEMGLCFCA OFELOJDHFHP);
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
