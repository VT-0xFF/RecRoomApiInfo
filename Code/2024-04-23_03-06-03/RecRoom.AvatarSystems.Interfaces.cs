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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x618F040", Offset = "0x618E040", VA = "0x18618F040")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface APHKBJOEGFM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCCJFFBFPKH OHIIIIJGHCE(bool HBOCLOCACGA = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCCJFFBFPKH BIDDANKIIPG(bool HBOCLOCACGA = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KJEIOOBJOBK DGGNHBIACEP(DCCJFFBFPKH GPKMLHOONCL, int CAHGPKLKBPL, string? ONGJKHHOIAM, string? JEIAMALICBO, PGLGNPLKCBJ CBOLANFKMCK, List<GJLHKJPBONO>? OFHKNGGDLAE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KKNPKBJAEJO(BAGKJGPGAAO NPMIMDFLKBL, [Out] DCCJFFBFPKH? AIMALDADPFH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ACFDLNBHMFC(KJEIOOBJOBK DAMDJOIOODP, [Out] DCCJFFBFPKH? AIMALDADPFH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BIOPICDBIDJ(KJEIOOBJOBK DAMDJOIOODP, [Out] APNOANHNCNF? NPMIMDFLKBL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IBKHJIGCKCN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BKOHMAEBPDN FPDGLHIHHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float HLPHNOBAAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	BKOHMAEBPDN JNAHJAEGBDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LAFJPPPNNBM(AFGAPBCALJC DKOKOEEPCNN, bool PPMCKDBJGCH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HJDGNJECFLO();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AJDBINPLMLL(int DMPLHAACIJD, float CBDJDOLDGOA);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HABMKIPGDNC();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IAFGMDLPEGO(bool GEEDEEIHDHN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DDCPBHDIICB();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JDIGMMEKDID();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DABKFPCKIEM(bool GEEDEEIHDHN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ONGCKFLCNAK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	ONDMBBPPJJI ANBBDILKCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	ONDMBBPPJJI HIAKJNIANPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JBOGDIBCGKA PALHKLDJNCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IDKEEJLCMGB DKOLOKKFPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IBKHJIGCKCN PFMHLBCFNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	IBKHJIGCKCN FLBLNEHMAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GameObject HOHLOJNOGCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AvatarConfiguration PKGPGPOMPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform HFMHELJKLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform HOBCOOLNBND
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Vector3 MLENNKFDBJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float FFDAGLIBKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform MLOFBIFNIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJGMCAADNFF(HOANFPIONFJ HNHGBGICNKL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFEFGDALHDJ(PPHAPADIDJB EPHAGJMDFNJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGFAIGILNAC();

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHPJJDFNOGK(float DMMDDFFBNCG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NBDDMPOOCFK();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NPLCPFJBINB();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHFONFMHKPD();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AOOCKEKINHH(bool IJEHHALKIKO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GEAEIFJAGKF([Out] Vector3 LDDOIEHGLLJ, [Out] Quaternion MCEFAAPJENC);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Transform FKPGFLLFKDJ(string DIGAONCAEPM);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3? MMNMAGMPBAN(string DIGAONCAEPM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HPPKGKNPKBP(float PLNFBACCBAM);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "20")]
	HandLogicOffsets JKGNCLEBEJD();

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "21")]
	PlatformSpecificPlayerHandOffsets DPAJINOLCDK();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FBAANLAPPDA
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	ONGCKFLCNAK MFDFOCJKIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform IFAOGGBMDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdatePostIKAnimControllers(float EFPELNMKHCE);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CJAJAPIEFBP
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool ICEDHCLPEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ONGCKFLCNAK LGJEDABGMAK(string GGKFFODLMIE, AvatarSystemConfiguration KLNABNDDEBF);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCFMMAPLDMI(string GGKFFODLMIE);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DOPOEKOKONB
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HBMKPAAGLIC JLJFLJFIGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OOPDGGIOCLF COMGMNHNNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	LOACGBAGCFM POEHACNJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	LOACGBAGCFM NCLCLMPAGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FHLAPGIAMKK CBKNCFGEFOF(FaceFeatureType JDIDCNPPIGI);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FHLAPGIAMKK MHPEFEDGLFI(FaceFeatureType JDIDCNPPIGI);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HBMKPAAGLIC JOCHGBMPIOP();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "7")]
	OOPDGGIOCLF IGGHNBLIFOM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ENMELFEIEBP DHDJEKHAIJJ();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ENMELFEIEBP CCKFAGOIPKD();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "10")]
	ENMELFEIEBP BDHKNHABPJH();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ENMELFEIEBP DNJNNEIIMAO();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LOACGBAGCFM DNGNFJPPMLO();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<ECLKMJDGKOF> CCGKBAIBGIB(bool HNCIBOGKFBN = false, bool EDBNNBFENHP = false);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<ECLKMJDGKOF> FKCDPOCCDFD(bool HNCIBOGKFBN = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task KIBKHNPIGDF(bool LCIIBOCPMLI, [Optional] CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task OEJBJENGPKF(KJEIOOBJOBK KKIEBPCELFJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LEEEOENIBIH
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 GLEFIAJPJPO(FaceFeatureType JDIDCNPPIGI, JCDBJMPKGGK KDKIMPHIJDA);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float GFCAKIONBPL(FaceFeatureType JDIDCNPPIGI, JCDBJMPKGGK KDKIMPHIJDA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJIBONIABCP(JCDBJMPKGGK KDKIMPHIJDA, AvatarConfiguration KLNABNDDEBF);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float EIHFGBAPAKN(FaceFeatureType FCEEBJHKJCF, float DPFGNADAIED, JCDBJMPKGGK KDKIMPHIJDA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float DEMNFAEFHIA(FaceFeatureType FCEEBJHKJCF, float IMLKFBMLCND, JCDBJMPKGGK KDKIMPHIJDA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 ECONIKEFEKI(FaceFeatureType FCEEBJHKJCF, Vector2 PLOOIHGCCGG, JCDBJMPKGGK KDKIMPHIJDA);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 NLBFJEFBIGO(FaceFeatureType FCEEBJHKJCF, Vector2 DGHMBNJMBBC, Vector2 COLPDJNANBO, Vector2 LKJMGAHJEAK, JCDBJMPKGGK KDKIMPHIJDA);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 OPICFCIFKEP(FaceFeatureType FCEEBJHKJCF, Vector2 PLOOIHGCCGG, Vector2 COLPDJNANBO, Vector2 LKJMGAHJEAK, JCDBJMPKGGK KDKIMPHIJDA);
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
