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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F4FBE0", Offset = "0x7F4E9E0", VA = "0x187F4FBE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NNDCGEJFCCN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MAMJKFCNJKC OCJBEPJEDEN(PKNFPGJAIIB AFDMCKAKEMD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MAMJKFCNJKC BHFAAOAMLGK(PKNFPGJAIIB AFDMCKAKEMD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LFOGLJADGMO CCHIMIIDKEK(MAMJKFCNJKC BOIPFNOKGBJ, int MGGAEMKOADB, string? GGDFKFACHGG, string? CPPBIPFENNP, NGHFCMNNGJM KNADKFHEGDI, List<NOFBPEFCPEN>? EPCMJFMMJNB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NIDAFPALOHN(LMJHLONIKBE LAMLBHGLINN, [Out] MAMJKFCNJKC? HPAFAKCFFEI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LJNPNFEMHEF(LFOGLJADGMO CMNDMCDJNKB, [Out] MAMJKFCNJKC? HPAFAKCFFEI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PBGGHAKIFMN(LFOGLJADGMO CMNDMCDJNKB, [Out] OPAAGPPHAEP? LAMLBHGLINN);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HGPIEJBGKCA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CMCDHKNDNNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool MOCEJPEAEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 IGPNJJBIGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Vector3 AILICAGLLAM;
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	EPBKGABEMJJ NHGNLOMKAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	EPBKGABEMJJ JJGFJIKOFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BPCADBPEGHO NKMCHGAJEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	DKKDNHKBJLF CHEOCMJHINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GLADMCEDLEP MFIOCIPJPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FKLMPLDDLKB KDIOOGJEIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	FKLMPLDDLKB AAFNBMBFOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string NHFKAFLKGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GameObject JLNNGPHDMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AvatarConfiguration BDODILEIPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	PKNFPGJAIIB NCIHFOBJIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HeadLogicOffsets KLMPJOONLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform FEEOCGHIBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform EJGOHLKLMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform CFGHFINCBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform FFLGHOFOPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 LHMLAFPKMPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float FJCOMLNANEK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform FNPBDOAGEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform KPNDCHEHKLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Transform IDGBMDLEELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform ILODIBADOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IKLFNFDBNDM<CMCDHKNDNNO> EFHHPIBHDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IELIFJPNDCF(string DIIOOLNJPKJ, JKJLHBMPFJH FGDANIJPPMK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKCIJICPKHL(BPCADBPEGHO BAHBHJFPCLP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBGKJNOPCFD();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDPBNGHHMEG();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPGIEFJHDLF();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AMLBLBBEMEE(float OEMIIAHPBAJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CJPHMCIGGIA();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HOPAFNAGMHD();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OPKHMLPELEM();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CMPDFNFMPKL(bool OECGBAAEAPL);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OPDAMEEINON([Out] Vector3 PMPFJDHPHCK, [Out] Quaternion KCMNAEPBKCM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Transform NMHAECNIHBM(string GFAKNNDBMFM);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3? MLJHIJCFEEP(string GFAKNNDBMFM);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HABDNDDDDCH(float DFGFCDJJKGK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void JEJNOOJMMDF(float FFBFCKPLKDB);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void LHECIGBMKHG(bool LEFBHBHKHBJ);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "27")]
	HandLogicOffsets MPAFKJHNGHI();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PlatformSpecificPlayerHandOffsets MKBIFMKELBK();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "37")]
	MGHNOBKDCAE MLABBLDCJCK();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BLHAPJFGHFD
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HGPIEJBGKCA HBEBPAIANLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform FDBGHPPJADH
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
	HGPIEJBGKCA CreateAvatarSystem(string DIIOOLNJPKJ);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdatePostIKAnimControllers(float GJELOGAKDKA);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NBJFPJIMJFL
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HGPIEJBGKCA IAKNMHDFJBD(string FBKHBPIFHEL, AvatarSystemConfiguration LDLJKPNAGIO);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IODDCLIKFBF(string FBKHBPIFHEL);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string LMKOIGCNGAF(string GNMBNMKMIBM);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OAGLLEEAHJE
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AvatarConfiguration CNIFEEJALDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BMCGFMAECEA NIEJGLPOMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	NCJALFIEICP CEPGNFNMMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	FNALMPKNBLO ICBMMHHAKJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FNALMPKNBLO HFLPNLPPEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JPHJMMINMCH OFALKNIPFJK(FaceFeatureType HNBPPNIGJHI);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JPHJMMINMCH FEIDDNFOLKE(FaceFeatureType HNBPPNIGJHI);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AvatarBodyShapeData.LMFFFLIEJEF KLEIGKNKPFD(NCJALFIEICP DGAOEDCMPNJ);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AvatarFaceShapeData.OKAOPGEJICN BNIAOBKEHAJ(BMCGFMAECEA PCBCIJEMABK);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BDLLACEJLDO KBAPFLJADAA(JPHJMMINMCH NJDOJMGKMEE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BMCGFMAECEA LBCAMCAADLP();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NCJALFIEICP ACKFKJGNLGH();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DFHCMGJACBB MMPMCAENOPL();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DFHCMGJACBB HKCJCBAEJIL();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DFHCMGJACBB BLNKMCLFKBC();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DFHCMGJACBB FGMJFJOKGKG();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	FNALMPKNBLO GOJDCHPPMFI();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "17")]
	List<NHAPPPHCCCK> EOBCBNHPFEB(AvatarItemBodyType JAHJCJGODCJ, bool FKECBKDDDNB = false);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "18")]
	List<NHAPPPHCCCK> LNDGLIDOBOJ(AvatarItemBodyType JAHJCJGODCJ);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task OMCNKHBGNCO(bool OFHLKCCLIEP, [Optional] CancellationToken HIMDFBHMPLL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task HALDOMCIPKF();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task KABANBLKPOM(bool OFHLKCCLIEP);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task PIHDIILMHGL(LFOGLJADGMO DPJEDFHOOLH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task PIHDIILMHGL(IEnumerable<KNCBLIHIANP> HHLIAFPLKJH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task PIHDIILMHGL(List<FNHOEBPLBMN> EPCMJFMMJNB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task PIHDIILMHGL(IReadOnlyList<AMBIDEBMCDP> FFGBADGFNKM);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task PIHDIILMHGL(IEnumerable<SerializedCustomAvatarItemId> KLFPINPIDLG);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool ENBOFDALJBB(FNHOEBPLBMN NABNPGPHNNO);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ELDLPLJJHBP(IReadOnlyList<FNHOEBPLBMN> EPCMJFMMJNB);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task OFELMOIMKFK();

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<FOMHJBMENLO> LDIIIFBELIG(MKHKBBDILNJ EHCAMONKEKN, bool CIDJEEOJLAC = false);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool GPHDHGABCKI(AMBIDEBMCDP HIDKIFCOPJE, [Out] string EMDLJAJEJDO);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool DJLNNKHKKOB(IEnumerable<KNCBLIHIANP> HHLIAFPLKJH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "33")]
	OutfitType KNCDEHLIAMD(AMBIDEBMCDP EHKDLJBBGDB);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "34")]
	MFNBFOEPFBI CIBDBHPAAGE(AMBIDEBMCDP EHKDLJBBGDB);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool NLAHMHFJFLK(AMBIDEBMCDP EHKDLJBBGDB, [Out] CBOBHFCKHLA GCPCKKDFCNK);
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
