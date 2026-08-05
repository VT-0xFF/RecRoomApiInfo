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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67838A0", Offset = "0x67822A0", VA = "0x1867838A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BJLFDKCLCFG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ALDBLMAPDHF KGDMHPGMPGH(bool HIMEPNJIJOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ALDBLMAPDHF PHJDPGLMJII(bool HIMEPNJIJOD = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KGBMONFGDHD EFDBBOHFBHH(ALDBLMAPDHF EEOBDBMOHPL, int OGJAALGODGH, string? CCMEKJGADHN, string? JDDGHDDMMED, AHOFOGFBAHD NMLLEEDBKBP, List<AMFBJJFGIGL>? LEBGMIOOAPF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BOEPINBPMPK(ALKCDDCCMFA GKHFHIILHMK, [Out] ALDBLMAPDHF? CGJOCNEAIOK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NDNPKLDKNDA(KGBMONFGDHD CIAHOLAHLNL, [Out] ALDBLMAPDHF? CGJOCNEAIOK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DKCCNJKOCLB(KGBMONFGDHD CIAHOLAHLNL, [Out] NCMDMPFPOCI? GKHFHIILHMK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KLIJBAHHPNE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	JCPJICNIBCM KOGMGFCDNME
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float PJBOJDEGOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	JCPJICNIBCM NPKHOHCHBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 HHGPIEOJBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Quaternion EGGPDBAAPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAMBIGLKNKI(GCBOGMDBBHF FAKDNFCMPPB, bool GEBFAKFHJEB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MAKEJAHMGAM();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJMLAPKIEIE(int IPHKKMMMLPJ, float INDJMICMPEL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPOCCDKGPHC();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJKLFCPKJLE(bool MOPHDJCHLDM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AEJOLGIJMJD();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NOICANOHIPA();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FDFMFGPHKFE(bool MOPHDJCHLDM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JFPCLKOLAMD(Transform EMNGIAIDBPA, Vector3 NOCCMNBAPEG, Quaternion CKFPNDJBJHN);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FAPOOABIGOE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	MNIMPDIHNFL NBFNHAKAPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	MNIMPDIHNFL BIHFOBJLECF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BIJPKIHDHNF FGCDGNCPFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FMHFBABHINA CIMNMOLFIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KLIJBAHHPNE NBEDJMAACKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KLIJBAHHPNE PLNCCEKEIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GameObject AOOABPFBFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	AvatarConfiguration ENACLEBELPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform NMIFOFCDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform HKHNAHEEAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 EAOCOCLIHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float KCICADLCEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform GKMBCDPHBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INLBNAINOFL(PPHKJMDKKGL KGGHANMPIHI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHHHHHAKOPI(DKMICAFEOAL JNBHMGOHIEJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AGIBJKFKDNG();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DAHBHDKGNEC();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KKNGPHKJFCF(float INJKGFHHFPF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCBOMMMDEGN();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JNIFGCGFGMJ();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void INMJPOOHJIO();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NAGAIKHGHCB(bool CFFJIANEKDL);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JOPJILBDMBM([Out] Vector3 LOIFAIEFDNM, [Out] Quaternion CFNNJJHJEHC);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Transform OKLNNKCAKHK(string OECDLIOPFKE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Vector3? AJJKAEJOKHM(string OECDLIOPFKE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KJPHHEBHIBL(float KEGNFOFLBAJ);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HandLogicOffsets AMEKMCACKCM();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	PlatformSpecificPlayerHandOffsets DOJFBLHFLNE();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KLAEPMLEANI
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FAPOOABIGOE PEPEICNBEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform GODJEPIBGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdatePostIKAnimControllers(float ECCGJGJKLJB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AANAOGHGNKP
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool JOCBJMPCINF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FAPOOABIGOE NFFJFLHDPMA(string BEHODGENJFG, AvatarSystemConfiguration LBAJEDNDPKN);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEMPGCJBABP(string BEHODGENJFG);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DLFAFDJEKEB
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	EDPKFFIMOMC JJGEKLIJJMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	HLNCNEOFKGK AMALLLNGNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	GLMCIKGKCFG IMELPMJNOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	GLMCIKGKCFG EBAMIOICCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ENFHCMKIOHI DLOILKBMGHO(FaceFeatureType MHPJECMOEDF);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ENFHCMKIOHI ICDCBHFLEBN(FaceFeatureType MHPJECMOEDF);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EDPKFFIMOMC ACHEFHCIJNP();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HLNCNEOFKGK BFBFLPOGLLP();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KJEDFHBBPGK GAEDOBLKOFK();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KJEDFHBBPGK FEPEPMDGALP();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KJEDFHBBPGK AFOFBNDKKFB();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KJEDFHBBPGK CGEEIJMHMPO();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GLMCIKGKCFG NFOEICKJKGD();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<PCPEIICFLOP> IPDFOIKIPEJ(bool MOMCCJOEAGC = false, bool KACPHCGGMFB = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<PCPEIICFLOP> HHAGMNHGPDH(bool MOMCCJOEAGC = false);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task JKHKCJJHLGA(bool GDDPACHAFMP, [Optional] CancellationToken AOLOJHLCMLE);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task KOHHLOKNGDM(KGBMONFGDHD CIIHHONFLLK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GODGGHEMKPA
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 ILFLOFEFDIN(FaceFeatureType MHPJECMOEDF, BOPNNGIGHPK PCDNHANKBKL);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float MDKKECEGAAF(FaceFeatureType MHPJECMOEDF, BOPNNGIGHPK PCDNHANKBKL);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBNLPNKMAJG(BOPNNGIGHPK PCDNHANKBKL, AvatarConfiguration LBAJEDNDPKN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float ANIBEBFPKFH(FaceFeatureType MMNNNGBLLJC, float IPMNNGLJIIP, BOPNNGIGHPK PCDNHANKBKL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float HFBONKICLNI(FaceFeatureType MMNNNGBLLJC, float KOPOBAJPPLK, BOPNNGIGHPK PCDNHANKBKL);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 PJMOEFGGJIC(FaceFeatureType MMNNNGBLLJC, Vector2 GJGJEGIJCGC, BOPNNGIGHPK PCDNHANKBKL);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 PKHLDBFCJKH(FaceFeatureType MMNNNGBLLJC, Vector2 JHHDJGIFBGA, Vector2 JJKDLOGPPAG, Vector2 HEIOEDNANOF, BOPNNGIGHPK PCDNHANKBKL);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 PKMLJOGBAGH(FaceFeatureType MMNNNGBLLJC, Vector2 GJGJEGIJCGC, Vector2 JJKDLOGPPAG, Vector2 HEIOEDNANOF, BOPNNGIGHPK PCDNHANKBKL);
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
