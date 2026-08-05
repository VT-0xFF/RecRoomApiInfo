using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.AssetIds;
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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x82157B0", Offset = "0x82145B0", VA = "0x1882157B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ACLMIKLBCIL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BNICAFPKAPB AIPBJFEGMPE(JLFDMKNKLIE FMEDCNPIHLH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BNICAFPKAPB KCBEKJMMLGP(JLFDMKNKLIE FMEDCNPIHLH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DBKPFJPOFHC CGKKFNLAODC(BNICAFPKAPB KANAIIDGHCH, int HPEFGPPMOIE, string? PFLDDMDPCBI, string? IIHGKMIFHHF, IHPKKIOOIAO FHOECEOGNGE, List<ECJGOBMDJGD>? MHOHKDCDHOE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DBHIAOAHMFL(JOPDFCKLKOH OILEKNGLFHO, [Out] BNICAFPKAPB? HHPKINNPBPL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CJCAGADJJAH(DBKPFJPOFHC FKFEIKMGOCI, [Out] BNICAFPKAPB? HHPKINNPBPL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EOBMPCICDBK(DBKPFJPOFHC FKFEIKMGOCI, [Out] CLOGEGKIKOE? OILEKNGLFHO);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PPALDFNLNHA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct JAPLGIFFLIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool MIKICGEDOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 CELEOJHNICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Vector3 HEIHIAHAMHC;
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	MKAEDPHCCBC OGMECMMEJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	MKAEDPHCCBC ABIEBLDGABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MKPNDPDPNLP KFEFJBEOIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FCEMHMOCEFP DPBCJNMFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EDFBLEEALAN CHGFBPCCMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ELMDBEFEDJJ EJAMPLFEAKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	ELMDBEFEDJJ FAOMJFLPCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string ONEJLDMHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GameObject DFFAMKHOIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AvatarConfiguration JLBHAGOLLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	JLFDMKNKLIE MMCOGLIKBED
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HeadLogicOffsets KMDFJDEJLIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform BDMPLCIMMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform MABMBCFLOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform FGFCOJDHNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform BAGAEBEAELN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 DNBNBFAPHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float DMALKJJNFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform EFJLAGLEKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform EONJDPIJGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Transform IFGPOPMFGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform CAEHMKHMNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	GBCEOPMAPJH<JAPLGIFFLIB> PMCLODDFMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DCJJGMOFDIB(string KKIFLDDKBNC, BNIMIEOPIIA NKCCJIBMBED);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CADAANHFMNB(MKPNDPDPNLP PAKFCFMEHHB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHFADJNGEEC();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFHNLMPJOEF();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDLJGDCMAAE();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BHHNFKNOAPA(float APBPLCHJFIC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NMAHNEJEOKL();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NGONMBKKENA();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KNLKPDIHHFL();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BHJOLHKJDDM(bool JPGDOAGJAEN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OAEFOFJMKBF([Out] Vector3 PGOBAMLEIOJ, [Out] Quaternion CCLCBBKFIND);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Transform OAAPOGDEGCL(string EOIFEFNLELB);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3? KDMFNCDAPPM(string EOIFEFNLELB);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void EGCFPFFDCBG(float ODFBIDNPCFH);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void ENJFLGIMGOI(float EIKJACBLMBN);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NKCMHLLCIPN(bool ONICGHEMIMA);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "27")]
	HandLogicOffsets ELNHCEHEJPK();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PlatformSpecificPlayerHandOffsets FMGBOABPINE();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "37")]
	HFOHEOCIICK EOCIDPDBJLD();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface IFPMCPKDOOL
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PPALDFNLNHA INJAHAPBLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform CGCOEIEGHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PPALDFNLNHA CreateAvatarSystem(string KKIFLDDKBNC);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdatePostIKAnimControllers(float GCGEIJPOBEE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GMAFHHFMILN
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPALDFNLNHA GHOAJNEEBNM(string HHDDOMDMGOD, AvatarSystemConfiguration NGGDLMFKPOA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHOBKKFKFNK(string HHDDOMDMGOD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string EFAAGMOOKKD(string NCPLECCNPFN);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HEJDANFBOBB
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AvatarConfiguration FDAIGEAFLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	INBBLDDKEIN LCIOHFEBKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LCJKMECGKBD OOOKNHHNICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	HDHJBPNLPKA MPABDHKIOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	HDHJBPNLPKA EOJCJEBHANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NJKDBAMDGPL KBBNBEPAJMF(FaceFeatureType BJLOCBNAGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NJKDBAMDGPL OCIOFGNEKPL(FaceFeatureType BJLOCBNAGBJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AvatarBodyShapeData.PGBKJOHIBBG HEMHHJEILEK(LCJKMECGKBD JJCCIOLJHCC);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AvatarFaceShapeData.NBPFNGJDNEF IEMNLEOJPMP(INBBLDDKEIN ONFDJDHHMCJ);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "9")]
	PBJKAGHPKMF GEGILPFCDKA(NJKDBAMDGPL PJAPNCPOMIK);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "10")]
	INBBLDDKEIN MPJEHFOCLMM();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LCJKMECGKBD ABOCJCOAKOJ();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	OEOJAONNJFH OEJAMJANJGM();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	OEOJAONNJFH ECBCCGIDLEP();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	OEOJAONNJFH EICGBLMIJCL();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	OEOJAONNJFH OGDPHODHBKH();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HDHJBPNLPKA ADLNPJFDACI();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "17")]
	List<OCPPLBMCLHD> JGIHICAANAH(AvatarItemBodyType HNMPLNFBDFG, bool MHGJBDNLCND = false);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "18")]
	List<OCPPLBMCLHD> EBOOIICLOHB(AvatarItemBodyType HNMPLNFBDFG);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task PBGGDLOKBEF(bool AGIJFMNAHPJ, [Optional] CancellationToken BKHGNHANFKK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task DIBKIOBFILN();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task JKHIOOFOLKP(bool AGIJFMNAHPJ);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task LBPEKOKJAJN(DBKPFJPOFHC AFPCNDFAMIF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task LBPEKOKJAJN(IEnumerable<FHKJPADBPKM> MEGEOPFGMOF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task LBPEKOKJAJN(List<FAFHAGKOPBD> MHOHKDCDHOE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task LBPEKOKJAJN(IReadOnlyList<OBCKBDNDNAI> AGIIFDCNHJK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task LBPEKOKJAJN(IEnumerable<SerializedCustomAvatarItemId> FOLGIHDCDFF);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KCFPGKGFOFA(FAFHAGKOPBD BDOCOCCFHJH);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GMGPNFIFPNH(IReadOnlyList<FAFHAGKOPBD> MHOHKDCDHOE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task BCMHMMJDHJC();

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<HMBKNNBIBKF> GDHHNGJEILL(BKMPEOKAHJC DFJCPOCMFHP, bool MHNKNHCGLMO = false);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool AMHCBOBFCOC(OBCKBDNDNAI OMLNADHFEFF, [Out] string EFJIJMEJHNP);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool AEAFPPDEGJL(IEnumerable<FHKJPADBPKM> MEGEOPFGMOF);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "33")]
	OutfitType GFPEOAAMGHH(OBCKBDNDNAI IIHDHELGAFA);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "34")]
	KCJKPDCALJH BKJFHIJMJID(OBCKBDNDNAI IIHDHELGAFA);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool PKGICFPHFIJ(OBCKBDNDNAI IIHDHELGAFA, [Out] FEMEFNJLDFL IHCNIMKNMIG);
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
