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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C5FE40", Offset = "0x7C5EA40", VA = "0x187C5FE40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DDKPICELNPL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FKBFMJFEIFH JPKBFJBOBEK(CIFHCHIGFCF GLKFEKCCCKO);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FKBFMJFEIFH FFKJPFJGIBE(CIFHCHIGFCF GLKFEKCCCKO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IPDMPCLJLFG FJFEKMKLHFM(FKBFMJFEIFH PEDMEJIDLNB, int HCPPMGFJDNL, string? LAOCJKNALFF, string? CPIOEEDDFDB, ECKLOIPKONK DNKFMFAHMGK, List<BDDPIPFODIL>? NIEADMJLLKI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GNDIHGGGJBA(KNGBOKKHLPJ HJJGGDONDMM, [Out] FKBFMJFEIFH? HCIFJIKKCEI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DCHNCLOAKGN(IPDMPCLJLFG KIBIEPEAFMA, [Out] FKBFMJFEIFH? HCIFJIKKCEI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PNLJIGPMCDH(IPDMPCLJLFG KIBIEPEAFMA, [Out] CNEBKLMIIBL? HJJGGDONDMM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HPGNGAKAOMH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct BOHHDOCMPIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool KPECCFEFLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 MFCEODCJAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Vector3 OLKKLGHEJEH;
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	HBAAEHCBNNO CCAAPCFDHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	HBAAEHCBNNO CAFHJCFFOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	ANAKAIIKOLB HCKFABCFFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	JOAGHKKNMDI IGDIPBCAEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	DKHBNCECMKL AJNOHKDKICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KGCOEBBKGCN KCPFOGJKIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KGCOEBBKGCN ALBLEJFMLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string AMLAEGNGNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	GameObject AOALCMHDOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	AvatarConfiguration DHGFBPPBBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CIFHCHIGFCF HMOHOLHLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HeadLogicOffsets CACMBHBNKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform JCBFFCBAFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform EDFGEGFPOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform EKLJMILHADH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform OBPKBEAOLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Vector3 MAADKEJPJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float AFFEPBKNAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Transform KLECCCGJIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform LBHAPFAPJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Transform FKIDJIOGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform MFPBIAOFBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "40")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	PJAJEBBNNBK<BOHHDOCMPIB> EPNKCDGJHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLMKJDCNBCH(string GLJPECOKOED, MNKCPAPAJBJ HNAOKANIONM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFDDEDMFNHA(ANAKAIIKOLB DFNMCAPPCOP);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BEJFCODFKAP();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BPFGNBJFCDO();

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAJHGIIKELK();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BMJBFIJHMHC(float JGGBJLNAKNN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EOCGMENPPEG();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JONJNOFONEM();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JDKHCLLKLME();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JOJNMKNLFEI(bool BKALBKDFAKM);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EHFJOEOMMID([Out] Vector3 NCEGLLCEOFC, [Out] Quaternion PHEPIFIFFBL);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Transform CFANJIFBNDE(string NHALHFDGPIO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3? AAGKPMJPDPM(string NHALHFDGPIO);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GLDEDGFIDFM(float OMJBFEOIKLO);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void NNBHJBGKMCD(float NDFJDMPJJAJ);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DMBOAAMCPGG(bool PHALDAPECKK);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "27")]
	HandLogicOffsets GOECMNEKCLE();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PlatformSpecificPlayerHandOffsets HAOBCPODBLF();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "37")]
	MBLBODMJALG KGNLKOEOLBB();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GCBMLMHDBMA
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	HPGNGAKAOMH EGOBPGILIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	Transform GNLOAOBIKGL
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
	HPGNGAKAOMH CreateAvatarSystem(string GLJPECOKOED);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdatePostIKAnimControllers(float DJGAODFCDIF);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GCPMMEBPHON
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HPGNGAKAOMH NMOBLLKLDBA(string ALHIDLGGBEP, AvatarSystemConfiguration MGIFPBNOLMM);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDEEHBEAEFP(string ALHIDLGGBEP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string NLDHJGHLIMA(string LOILLGDHCBH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EEHKELBBLDP
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AvatarConfiguration LKMFCECIBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	ANPCAKLHJAE BFKKFFLPKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	LIEKGDGCODL CKKBCABNGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	KIGICGBMFCD CLPAOIHCJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	KIGICGBMFCD MNDHJAFLPAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DOLBAFHNJDK INDJHMALPNG(FaceFeatureType PKPCHIEAIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DOLBAFHNJDK CMFJFOLBLPP(FaceFeatureType PKPCHIEAIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AvatarBodyShapeData.IPHFNEHEGNI EKLPADPHOMP(LIEKGDGCODL DKCOIIJHEGD);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AvatarFaceShapeData.LBCIECHIFGF OCJEMOKPMLL(ANPCAKLHJAE KDMHOIMFDLF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KMBJPNFNLBA GAPDEAFBEHK(DOLBAFHNJDK IGLMLGJNBLF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ANPCAKLHJAE LOAMEEEPGIG();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LIEKGDGCODL IMELMGDPBNG();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MIAOGILCLPA JAEEICCOBFH();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MIAOGILCLPA FHEEBEHCCIB();

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MIAOGILCLPA CKODMGGDFEN();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MIAOGILCLPA MPBCOONFJAM();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KIGICGBMFCD CKMBJBKEAHH();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "17")]
	List<HOLLOHBCIIF> PDLNPBIEJGI(AvatarItemBodyType KOFINMMLEPL, bool BJFGJMIAAJM = false);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "18")]
	List<HOLLOHBCIIF> OBAFIAJFINF(AvatarItemBodyType KOFINMMLEPL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BAPLCENDKPC(bool MLCPIFKOCPF, [Optional] CancellationToken DKKNFNCKCEB);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task OOOEHJCCHEA();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task KDKKBKBGPKH(bool MLCPIFKOCPF);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task CBKIAOCBDJB(IPDMPCLJLFG NLIMCNGLOCC);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Task CBKIAOCBDJB(IEnumerable<IGJKBFHNFPI> HICDIPMJINP);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Task CBKIAOCBDJB(List<DOIGMHDFEGI> NIEADMJLLKI);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task CBKIAOCBDJB(IReadOnlyList<KDBKLMKLCNH> ECECCIIPJMI);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task CBKIAOCBDJB(IEnumerable<SerializedCustomAvatarItemId> NECCKKNJGHA);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool PGJIABBBKGG(DOIGMHDFEGI HKEHHGCGFCF);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AGIOLBBKBON(IReadOnlyList<DOIGMHDFEGI> NIEADMJLLKI);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task IGBCKAGODHE();

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "30")]
	Task<ACHDJIFELNF> CKMLDGBHNKO(CNFHKDPOPCB CEJPAANJMMG, bool LODPBNJOLCE = false);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool PHJCKAFCECA(KDBKLMKLCNH GCAAIHKGLKH, [Out] string KGOOGIFAHJH);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool LJEHGIHAOJH(IEnumerable<IGJKBFHNFPI> HICDIPMJINP);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "33")]
	OutfitType HDKKBEKFKOO(KDBKLMKLCNH ONKLOOMCJOM);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "34")]
	FKFDNAOIIJD OPKMDNEOAED(KDBKLMKLCNH ONKLOOMCJOM);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool GOHJIOKKCHE(KDBKLMKLCNH ONKLOOMCJOM, [Out] ELBHACMOKDM CPDACKADFEF);
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
