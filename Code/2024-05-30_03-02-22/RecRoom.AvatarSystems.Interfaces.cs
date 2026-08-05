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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x62C00E0", Offset = "0x62BF2E0", VA = "0x1862C00E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KAPBCAAAFNH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FHLLPALLHDJ AOLKIMEFIDC(bool HDADLPEMHHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHLLPALLHDJ MEABGICCPDE(bool HDADLPEMHHI = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NGIKAEILDNH HDBLJNGGPLA(FHLLPALLHDJ JLJKEBMIIPF, int NCBKMGNHDGN, string? IIADHBOODBK, string? INONBEFGGDI, AKODDEGLAJD HOIOLGNGDKB, List<GKGJJLPPBJJ>? PGAJLHABNBK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LDNLCBDEMLG(FGOGKGFGMCE CJFMPGGIAHK, [Out] FHLLPALLHDJ? KCGHAIFCGDC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AFDPEHLOGPB(NGIKAEILDNH AGJEBHOMKJE, [Out] FHLLPALLHDJ? KCGHAIFCGDC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MABIPODFBNO(NGIKAEILDNH AGJEBHOMKJE, [Out] PIKJNPPHNFL? CJFMPGGIAHK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MMFLFMKHJCD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NACKJAPOKPC MLFDOOCLMLI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float AMMJPJJNEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NACKJAPOKPC PFAMGKNIBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPKEMENJOOJ(KDCGCEPHGCE JLPFJEBDMDB, bool OAPODLLOLMF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEMCANOJOGE();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GIMBFFJOLNI(int OGBANGLLCKG, float LFIAPDMKENF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KGMANGCFGIH();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EHCPHBGHBJP(bool AIDBJIBCPEA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BMCMMAKALHF();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KEPEBPJACPL();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DEJOBGAGNGN(bool AIDBJIBCPEA);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IIDKIMFHBIC(Transform BGILIGANMHA, Vector3 EPBDOJIGBNK, Quaternion OIABDDBOMEM);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NKABEMAIHCK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	OJHEJHCKNBB KJNAIMBGCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OJHEJHCKNBB OOBAMCHLGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LEDFPFHJFMG PALDJBMEFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CPMGGIIMFCP DMDDNKFGDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	MMFLFMKHJCD DCAGMOEMDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	MMFLFMKHJCD BCHMAMPJFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GameObject IIDBEBHLIGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AvatarConfiguration AAFDDCAMDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform LDAPMOKGPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform MMLDMKNHLPG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Vector3 FNMPLMAEPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float APHGMHIHIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform DDGPLIHIGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLEOOJLHBPD(MHFIOJEMHHH MJGEAFMJGNF);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGIJDECFOCE(EMPNJLBEJFP CBJNINNJGKB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GBOLNMBJNHI();

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPKAADAOHGD();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKFMPPPOLGA(float DKLEKKEOKGH);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DINBNMNAFLP();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EFEJMNNMILK();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void POKIIHIMJAN();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ILMHNKIBMMG(bool BNKENPJOJJO);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DFJKFPBKMMJ([Out] Vector3 KDKAGOFAPAI, [Out] Quaternion CCBGFBDMNFL);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Transform CBGKLNICGHP(string BOAMHPHPKFO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Vector3? NEAJIFINEJI(string BOAMHPHPKFO);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GOMMHMGMPEL(float KDNBPCABKHM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HandLogicOffsets AKLHFHJILKD();

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PlatformSpecificPlayerHandOffsets FFPJLALPLNC();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JKEIMLHAAKN
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	NKABEMAIHCK LEBKOPIJAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform ICNJCJFKBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdatePostIKAnimControllers(float ADBEIAHCPGL);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GFPMJMHNIMN
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool PHCIIJBOLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NKABEMAIHCK KFPDJOGHLKO(string LJIKBHPIACO, AvatarSystemConfiguration KLCLAEOMFKN);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJADKIJDPPK(string LJIKBHPIACO);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface NAOINCMPCBL
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	KOJBJIADMMM BJNAALNENDC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JMPHDKBEGLF NFGNMLJIOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PKFGAFHOMKH IJKEPFBLJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	PKFGAFHOMKH HPNKMDFLPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PLPCONDGDMD INPDNNFPBCM(FaceFeatureType EEFMHBCJMJG);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PLPCONDGDMD DENNIPOKLPG(FaceFeatureType EEFMHBCJMJG);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KOJBJIADMMM ABMBFGIFMCJ();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JMPHDKBEGLF LGHPHCBGNBF();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KDLAJGECGFL KFAOIMJOFPB();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KDLAJGECGFL LFDHDLGHAHP();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KDLAJGECGFL HLKGCPANKPO();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KDLAJGECGFL FPHPBFFJNOP();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PKFGAFHOMKH NHNBJLOOHJN();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<HFLFBGANNAH> JHMLGDMAGIC(bool BNJDBLFFJPO = false, bool HGBGGPLEAIH = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<HFLFBGANNAH> MJPNDBOKEIC(bool BNJDBLFFJPO = false);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task CHCNEKKGLOL(bool HIGDHPGKKHD, [Optional] CancellationToken GILHKFNDIJP);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task NEBJHFOCLBL(NGIKAEILDNH DLGHCPKKBMG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface CNGMAALJPOG
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 NEGPANKHIBB(FaceFeatureType EEFMHBCJMJG, AGINKKHFHPM MJLHADOOOBD);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float NBLLGMOJCCC(FaceFeatureType EEFMHBCJMJG, AGINKKHFHPM MJLHADOOOBD);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEHAPBPOEGE(AGINKKHFHPM MJLHADOOOBD, AvatarConfiguration KLCLAEOMFKN);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float IIJELGHACGB(FaceFeatureType MJGEJCKDLFG, float CAFGOBADANC, AGINKKHFHPM MJLHADOOOBD);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float PNGGGDEDLHO(FaceFeatureType MJGEJCKDLFG, float FBCJMLBEBAA, AGINKKHFHPM MJLHADOOOBD);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 PJCDMFDFCDA(FaceFeatureType MJGEJCKDLFG, Vector2 IJAFEPBNIOC, AGINKKHFHPM MJLHADOOOBD);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 JKCNJFGJHKB(FaceFeatureType MJGEJCKDLFG, Vector2 JEMICNDHDHE, Vector2 ONOPBIIHHDP, Vector2 GJDEGPNFLPI, AGINKKHFHPM MJLHADOOOBD);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 CMILKPMIGOE(FaceFeatureType MJGEJCKDLFG, Vector2 IJAFEPBNIOC, Vector2 ONOPBIIHHDP, Vector2 GJDEGPNFLPI, AGINKKHFHPM MJLHADOOOBD);
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
