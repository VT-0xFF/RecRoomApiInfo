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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x8385580", Offset = "0x8383B80", VA = "0x188385580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HCGIIOGMDAE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBDFLCGDPFO DANPCDLNOIP(KHBAENPMODP INLGMINCMAD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HBDFLCGDPFO EBPGFDDGNPJ(KHBAENPMODP INLGMINCMAD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AOBPEDPLMGH BCLFOLDACHC(HBDFLCGDPFO CDDIADBJAOB, int HGIMHJPBGBB, string? NDIENANOGEK, string? CFKHGNHHJND, FHBEPOAOIND LBOENHPGDNF, List<PBEHPFBHNOE>? PNMPIKDPNBE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FKHLIJCFDAG(OEMEODNGBLN OIPNDGCMOCE, [Out] HBDFLCGDPFO? CBMCGBCNLPB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OCIAFMDFPFK(AOBPEDPLMGH NLBMKMJLFNN, [Out] HBDFLCGDPFO? CBMCGBCNLPB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JDMMEBJKLFC(AOBPEDPLMGH NLBMKMJLFNN, [Out] LPOLNBIIPNN? OIPNDGCMOCE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NGEOGCLCLHG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CIDBJHEEFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool MIBDNOLMMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 DGFKMHLDMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Vector3 HJNAPJCOEPN;
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HLLOFHFLNHG BMDKLCEKKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	HLLOFHFLNHG HLKEFJICPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ECECEMFDBGO FAONJMPCLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	EEDAILNAJPO GCIKGFAOGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NCFHMNIFFNK KBAFMJLOMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GDGKEFFDPOH HNDCHFIGPGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GDGKEFFDPOH OJFIAGIEMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string NPCMGBMOJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GameObject JJEACKINPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AvatarConfiguration KMINAOBEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KHBAENPMODP KEECKLLMACN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HeadLogicOffsets EFGGLFMNPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform PKBJIKJANFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform GPKIECHAFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform ABLFCDLMIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform IPIFFBOAKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 FIBJHMMAPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float DCKAJKCMAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform OBBMNAPMIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform IKAGPJEKOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Transform MIKHLHEDDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform BEMLJBNHEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	PKBDHHCMFJK<CIDBJHEEFAG> DHNPOHFHBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JKAHBGJFLII(string IEFAAKCFKDD, NGJMPKHEGDC OFLNFPDHHPI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFLPPBMHPME(ECECEMFDBGO GIIEKBECBEK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGALOBAFNEI();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMNEIDKMMPL();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDPJAALGMEB();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKFJEKDMJNN(float AOFJADJGDJD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ADPINCMEABH();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PJLHGGDMNLO();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DLIDACJHEGF();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MJGJJFCNKKK(bool MEOHIAPHNGH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void ELPDPOCLKAL([Out] Vector3 IOEJLLGHEJH, [Out] Quaternion GDHHNPNFMAB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Transform AHNLHDKFCFI(string AOLGENGICKA);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3? EMDGANNGDPD(string AOLGENGICKA);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BKJNNODOLLA(float MDDJPADLPNL);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PFGJFOGPKBE(float FEEPNABPPEG);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BEJNAPAJPEM(bool OODHOCAKIEF);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "27")]
	HandLogicOffsets KPDBBHPPEJO();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PlatformSpecificPlayerHandOffsets BANMBHAGLAK();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "37")]
	ICIOBEGHHIO FMICMIOBNJD();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface PNAEJBOPKFD
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	NGEOGCLCLHG PIFHMPIGOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform HCAAIKKCAEN
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
	NGEOGCLCLHG CreateAvatarSystem(string IEFAAKCFKDD);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdatePostIKAnimControllers(float KJDBPOBDAMF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BGEKLNMEPOG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NGEOGCLCLHG NDGKHENADDJ(string MALIJOPLNPC, AvatarSystemConfiguration EEBLDHEHFBP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFBEIJOHHFK(string MALIJOPLNPC);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LILGKGOPKIH(string APJLABGDCFI);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OBFGCNLFAMP
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AvatarConfiguration HEMOCFEJKDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	NACGCPOMKKF EBKMDNAFIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	CFGBLEDCLBI OPDNEOGLIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	GDAILFHEPJD MOBPGFGNNOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	GDAILFHEPJD IEFGDGFMCAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KKNCLIFJEEB BCKCJEBFEEJ(FaceFeatureType MLPIBMFGLMC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KKNCLIFJEEB GBCEHFACLEF(FaceFeatureType MLPIBMFGLMC);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AvatarBodyShapeData.FBJJGKGEEGN DFHHCEAAPJG(CFGBLEDCLBI GKJFLFMLOPP);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AvatarFaceShapeData.MPDCGGPHANC BCFFILAKAMI(NACGCPOMKKF KKJMNIDBDDN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FHGFAGJLMJA EOGALDLMHOI(KKNCLIFJEEB CPHOPDDGDLN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NACGCPOMKKF HOEKMELCOIK();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CFGBLEDCLBI EFIOJJJLJBO();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HBALGBNKPFA OIHHFKPGJNP();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HBALGBNKPFA JIBPLMACLCC();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HBALGBNKPFA CKBPOALHJHH();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HBALGBNKPFA NJKIPHAPBBC();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	GDAILFHEPJD NPKKJNAIOHA();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "17")]
	List<PBGFHHLAMII> PJIIBIFGLDG(AvatarItemBodyType IBKFAEDAFDO, bool DPEPKJNCFFO = false);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "18")]
	List<PBGFHHLAMII> ONICILALPFO(AvatarItemBodyType IBKFAEDAFDO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task IPHFDPLLICN(bool PHHGDFNHAGL, [Optional] CancellationToken PJCIHHKJKBP);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task BLHJKBNHBNE();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task DLEDIMCPOLE(bool PHHGDFNHAGL);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task NAAEKDIHDBD(AOBPEDPLMGH EMNNDNELFLF);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task NAAEKDIHDBD(IEnumerable<NLMPGIDIMPF> MKPABHPEPCF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task NAAEKDIHDBD(List<MFMJDEMOPNO> PNMPIKDPNBE);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task NAAEKDIHDBD(IReadOnlyList<FLIIEBHJBPE> LCLIFALFFON);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task NAAEKDIHDBD(IEnumerable<SerializedCustomAvatarItemId> IMLEAHGBHHM);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool JFNCKINDNCP(MFMJDEMOPNO DMIOADFKMLA);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void DOLKMJOAMFF(IReadOnlyList<MFMJDEMOPNO> PNMPIKDPNBE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task PJGBMEKPFFO();

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<DMOLDHBFPFH> BOACCAHPMAK(FJFAJKOFEOG ADCLCGOEKOC, bool ICFPLLHCJPE = false);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool IONMHCCAKCP(FLIIEBHJBPE OFMEKMOPPJD, [Out] string HBLOMPPFNJN);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool PGGFBIDNMHG(IEnumerable<NLMPGIDIMPF> MKPABHPEPCF);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "33")]
	OutfitType DPJCDGOFFIM(FLIIEBHJBPE NANHMPOBBLI);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "34")]
	NEKEMFLBPJP FPHIDLKHBKL(FLIIEBHJBPE NANHMPOBBLI);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool DPDAOHDNIGE(FLIIEBHJBPE NANHMPOBBLI, [Out] JFGCJJJDCHI KDEPDKMKCDI);
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
