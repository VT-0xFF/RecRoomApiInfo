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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x67B04D0", Offset = "0x67AF8D0", VA = "0x1867B04D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8765E0", Offset = "0x8759E0", VA = "0x1808765E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x876620", Offset = "0x875A20", VA = "0x180876620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MBAJMGKNFMP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GCLNOLIGGFH OADEDNPJHAM(DBODHIJMFKE MCNAHMPHBIK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GCLNOLIGGFH JMCLPCABHEJ(DBODHIJMFKE MCNAHMPHBIK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PLHCOMNHOME EHPGAGDAJGO(GCLNOLIGGFH LDNEPNAGEGN, int LLCPIKPJEFE, string? FIKHOKLHCII, string? NNLJDDEEOND, CEHEBDFBLFJ POHKOLGMMBG, List<EFKHLHPELON>? CHFJOLMLFJL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OBEDPLKLFEG(FAFHFIMHHOA PLMEENDJJJM, [Out] GCLNOLIGGFH? MGJIAIBPJOF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PFIGJKCIHDD(PLHCOMNHOME DFKIBCEBANI, [Out] GCLNOLIGGFH? MGJIAIBPJOF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HKAOFFFNIIO(PLHCOMNHOME DFKIBCEBANI, [Out] OEKMIFOBLEJ? PLMEENDJJJM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FHMJHENMAFA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	IGPEJDHHMCO PHEDCILLPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float NEGNHPNBLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IGPEJDHHMCO CBPEFAOAKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 FMGHILIJPDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Quaternion MBOLNJHCPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BOHEMKDDJAE(GLDELPCMEFD AHEJMLCHHMA, bool LIFMKOAECLK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HEDGFDGCBJA();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CINKIPEJFNM(int NMPPAPHEKHG, float NPOFJIHPDIG);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GBCNIFAAANG();

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BHCPLNDIBJE(bool PEGAAPONPJP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool ACEOOAFMJLL();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool MKAMABJDPNL();

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LGDNAOCIFMN(bool PEGAAPONPJP);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OOMHENNDGLP(Transform KOBAADDGPBN, Vector3 KONFJLEJLEA, Quaternion PHAOIBJDGJB);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HBLKMPJDDAA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IDDBOOGKPOH MDEANGELPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	IDDBOOGKPOH HIAJJKKHPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	DJPJDDCJGDP PIDDMKJDLGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AAHJCJJEOLB KPBNNKAGHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	FHMJHENMAFA ACPHOONLLKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FHMJHENMAFA KAJDAHNECGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string HBGDMHLHLMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	GameObject GODEJCKEDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AvatarConfiguration KOABFLLEDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DBODHIJMFKE OMPGCOJPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HeadLogicOffsets ECEDOPMIDIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Transform MGBFKNMLMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform CPFBAOIPNKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	Vector3 EFCGICNHBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float JGNCMBNMPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	Transform HDFPHPMILCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Transform BGCCHKGPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Transform EAALCACDNFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Transform OKJMBDODIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAJBCOOEDKA(string MDNKLJHMNAJ, IEEALKDNMIP ADMMNMKKJLP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEIHHNLAAFK(CNPNJDGCEFI KHHKOMBFPFB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BJGCJJACGKD();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FMEPPLBAFFM();

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FMPGPHDAOKL(float ODJMAPACBGD);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONNGGOCOBBL();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IMFHDEAGMLO();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CDDADGIIPLK();

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DHBJNFAIKKK(bool MAEGKIDJOLC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HGOHNBECODD([Out] Vector3 EHHJHEDBAEF, [Out] Quaternion AEMGJFFOFJO);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Transform DECDAHLKJMG(string KFAABPOALLM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Vector3? CHBOOHPDOFB(string KFAABPOALLM);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EPPABLLABNI(float FAGFODCOCBH);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void HHIEHDGAJLM(float BIEFJBPGIKA);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "24")]
	HandLogicOffsets OPAMHDDJFPH();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "25")]
	PlatformSpecificPlayerHandOffsets NNKOIFNGKBG();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JJPGNIJLALO
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	HBLKMPJDDAA NFDBLNIACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Transform AEFMLPEGKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HBLKMPJDDAA CreateAvatarSystem(string MDNKLJHMNAJ);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UpdatePostIKAnimControllers(float OBMBAKPLLKB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LHGAFEFIFBI
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBLKMPJDDAA GGBJFFIBNJO(string PFKAJNNOLOO, AvatarSystemConfiguration IOIEICBMGJJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGAOGPPEOFP(string PFKAJNNOLOO);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string HHGHODCPKFN(string KPGEKJPDEEA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BCGADLKLNIG
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	GDOGJLLCBMG NIDDAKHGHPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	EGALLKJKHIB NIHKDJCEGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	LHKFMHHMHDP HMCMEAKKHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	LHKFMHHMHDP GOIKGEGEMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NNBLNMLCNGB FBIPDLODEOF(FaceFeatureType ACKMKCCLCON);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NNBLNMLCNGB MLOONEEABOH(FaceFeatureType ACKMKCCLCON);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GDOGJLLCBMG DKLCJFOKINF();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	EGALLKJKHIB OCJMEPBMMFB();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NBCAAFAKGMC MMNCMPLCAIG();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NBCAAFAKGMC HKGLAPJCNMM();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NBCAAFAKGMC CIKMCPNCOID();

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NBCAAFAKGMC KNCBHDNBHNA();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LHKFMHHMHDP NJBGPGOBGLO();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<EKFDEJANFPB> NFIHBMICOHF(IJCBONOKOKD BCBKGLDPNCH, bool OIKDDPIBNPN = false);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<EKFDEJANFPB> OCFJKLHKGOO(IJCBONOKOKD BCBKGLDPNCH);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task MHHHHJOJLLJ(bool LHCCOOBDPLG, [Optional] CancellationToken GNJJGEHBGKC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task HCBEDKDAABD(PLHCOMNHOME ELHBHPDBKOP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OEKGLDJIPCK
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 DOABCNJEKGA(FaceFeatureType ACKMKCCLCON, DBODHIJMFKE MCNAHMPHBIK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float GPFMEEOHKKJ(FaceFeatureType ACKMKCCLCON, DBODHIJMFKE MCNAHMPHBIK);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOIMPAHMBBO(DBODHIJMFKE MCNAHMPHBIK, AvatarConfiguration IOIEICBMGJJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float DDCLHIFJCHJ(FaceFeatureType OKMBEALBKHJ, float BGFFDNAPEIO, DBODHIJMFKE MCNAHMPHBIK);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float HDBJPDDCEII(FaceFeatureType OKMBEALBKHJ, float CHJIHOLNGNH, DBODHIJMFKE MCNAHMPHBIK);

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 ECNMPPDBDOF(FaceFeatureType OKMBEALBKHJ, Vector2 CLODIDHAAEG, DBODHIJMFKE MCNAHMPHBIK);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 AHPABPIMHHA(FaceFeatureType OKMBEALBKHJ, Vector2 IBEMOMPCMBA, Vector2 JABDCAIOEOA, Vector2 FBLAJGIHOFA, DBODHIJMFKE MCNAHMPHBIK);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 ONHIOALCJLB(FaceFeatureType OKMBEALBKHJ, Vector2 CLODIDHAAEG, Vector2 JABDCAIOEOA, Vector2 FBLAJGIHOFA, DBODHIJMFKE MCNAHMPHBIK);
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
