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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A22180", Offset = "0x6A20780", VA = "0x186A22180")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JLPMIGIAPFH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HLICDDLODBP LKDHCHCDFCB(MMBBNHOOGFA KLAGAOLBONF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HLICDDLODBP LHEEHIJNBAM(MMBBNHOOGFA KLAGAOLBONF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BKMBOEENOCF LELOEFPBIGB(HLICDDLODBP JGCMECODHDI, int IFGAAGJBJJB, string? KJPHMNNIMDP, string? PHLKCGNACMI, HMAPOJNAMII NCLEFBNEIPE, List<LNLLCGLHGIO>? IEMLJEFHJPN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GIJHEEEAFIJ(FOGBEJFOLCM ELFAHMMNJJI, [Out] HLICDDLODBP? IMKFEKABGOM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool EMFNFJMBMMH(BKMBOEENOCF DOPBGCMNMFK, [Out] HLICDDLODBP? IMKFEKABGOM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BDHBHNPNKAL(BKMBOEENOCF DOPBGCMNMFK, [Out] ICAMEONBIKE? ELFAHMMNJJI);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OBHAINDJFAC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HLBJMBIMBFF LJLMDGLGJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float ECMAPGGBIHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HLBJMBIMBFF JGBFMDKIALI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 GBAMEKGDHML
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Quaternion HAKEKDJGCBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BNBPJJIIFBJ(DBEOJGMKMIH FDKAGJLJMPF, bool OPPPLDKFPNA);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PELOMKKEFAK();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GHELLCNBGEO(int EFMLEILEFEH, float DIOCPDIGPAA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OPJFNAENCMN();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HKCPNNPBDFM(bool BDGDGHAINAE);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CLJCALFJGFM();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EGNGCNCAAPB();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DENMHPPLCOD(bool BDGDGHAINAE);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LICIHFNJCCO(Transform LDJCBIBELIM, Vector3 IAHEMABMPLA, Quaternion DGALDAFMLGE);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DGFMLABLMOB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GHNLMGKLHKE KOGLOJOALGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	GHNLMGKLHKE IKBKLGOMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KICAKJJBBFF LPCGOLMKMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	CDCGOHLJDLI NPCIGPFDCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HBMOFOAEPNJ FFFMDAMCGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OBHAINDJFAC AHHMNOINCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OBHAINDJFAC NBFMDGDBPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string PEPAJCGIHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GameObject MNKAGJEGJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	AvatarConfiguration APKPKHKHPKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	MMBBNHOOGFA GNDMCEHMCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HeadLogicOffsets BCPOIFMJNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform CODDGOCBNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform ODHNCCFOPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform CIFLANIKJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Transform IHCBFPNNFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 FABDDMEMNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float DALBBKIFPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Transform NDIIBIPFAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform ABPCOAHGCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Transform OCAIDCMJLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "37")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	Transform AMNPEDGOEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPMBLACIKKC(string CPHGKKKLKCK, BKNEINGFPBD KHPHBIHFJHM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHPLJKGDFGA(KICAKJJBBFF MPPFDGEFPLB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EJGJKJFPFNH();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGFLDCOBFPD();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MAGIHKBEELD(float LJDIPJFBPBD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AONPGCDOGNO();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BGHCGDOMOLN();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GLIBLAOEGGF();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BDJJFJENIPC(bool DEEICJFAFJB);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CCJJICLDCMH([Out] Vector3 HEIJCLDDEIL, [Out] Quaternion PHBJCMHPNAA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Transform IMPDDFFEBPD(string HCCNHFMDGBD);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Vector3? JFCFKCONMFG(string HCCNHFMDGBD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KNOLGOCJIHK(float ANHGIHGFDOO);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HHMPGLEJKED(float OADFBBBEBHP);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "25")]
	HandLogicOffsets IMLOGMFKOCN();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "26")]
	PlatformSpecificPlayerHandOffsets CAPBDOAGBIA();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	OPAGPNNBGJH KGNJFCMAHGA();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OLKIHHNHEKN
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	DGFMLABLMOB GMDLJHDFBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	Transform GKIPAMJDBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DGFMLABLMOB CreateAvatarSystem(string CPHGKKKLKCK);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdatePostIKAnimControllers(float BKOJCILPMLI);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface OPGKFDNNCCD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGFMLABLMOB JOPOCGJAMGN(string MKHCCJCOBHM, AvatarSystemConfiguration JNHBLCGLMHG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMGAABDEDHJ(string MKHCCJCOBHM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string FLHCPEOHEOG(string MDGJIIBKBLJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface AJNIAJIHFAO
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OAGOEKHDGKK OJFGOKPIPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	NCHIFEMIBHL NFGPKGGDLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	PJKGNECFBON NKLJNMIFDFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	PJKGNECFBON EJDMKMBFNHG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DFIACMOLAPM JDMPCEDLMGF(FaceFeatureType NKBCJKAPIOK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DFIACMOLAPM OMCHAAKJKKA(FaceFeatureType NKBCJKAPIOK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OAGOEKHDGKK IFKHPEDHFJO();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NCHIFEMIBHL MEIIHICBFLG();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IBPLBEBNLMD PPECHEIGAAN();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IBPLBEBNLMD EDIBBDABDHM();

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IBPLBEBNLMD NOFDPJMPINN();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IBPLBEBNLMD HOBOOGNNPEA();

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PJKGNECFBON JFMBECOIENO();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<FBMKHJEBFJF> OJAABACEOCB(FNMAPJHHAKI JNPGJADOLAG, bool IPMFJLFEKJP = false);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<FBMKHJEBFJF> BKOFLLJNCED(FNMAPJHHAKI JNPGJADOLAG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task OKMNLNKJIMC(bool KCAKFIBDMMF, [Optional] CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task MNLKAIAEPAL(BKMBOEENOCF FOKLGEFHOJL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PDJHHOACBKG
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 NLGDMEFFPAE(FaceFeatureType NKBCJKAPIOK, MMBBNHOOGFA KLAGAOLBONF);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float FMDEBFGHGNH(FaceFeatureType NKBCJKAPIOK, MMBBNHOOGFA KLAGAOLBONF);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OBGFPOEOBLL(MMBBNHOOGFA KLAGAOLBONF, AvatarConfiguration JNHBLCGLMHG);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GMCNFBGOMFM(MALLKMKHLID FNIGDBGFJNL, AvatarConfiguration MNJOAJLMFMH, MMBBNHOOGFA PDOGEIHFOPK, MMBBNHOOGFA LMACLBIABNH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float ABKAMMOEOJC(FaceFeatureType KDLEIJBEDLO, float JCBNJOGDJOF, MMBBNHOOGFA KLAGAOLBONF);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	float BPOKEEPIBBK(FaceFeatureType KDLEIJBEDLO, float EDJLNIKJGIK, MMBBNHOOGFA KLAGAOLBONF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 KCMCDHDLFDI(FaceFeatureType KDLEIJBEDLO, Vector2 PGDAIMHHILE, MMBBNHOOGFA KLAGAOLBONF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 HJFBGEPDPCJ(FaceFeatureType KDLEIJBEDLO, Vector2 JEBPIHOLMPI, Vector2 NJFJHDNDIMH, Vector2 CEOPBGEHDCG, MMBBNHOOGFA KLAGAOLBONF);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Vector2 JBNOEPJHKPK(FaceFeatureType KDLEIJBEDLO, Vector2 PGDAIMHHILE, Vector2 NJFJHDNDIMH, Vector2 CEOPBGEHDCG, MMBBNHOOGFA KLAGAOLBONF);
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
