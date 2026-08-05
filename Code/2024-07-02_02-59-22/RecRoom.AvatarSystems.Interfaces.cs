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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6830250", Offset = "0x682F250", VA = "0x186830250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OFOLBJMNMGE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGKNAIDPAJD PHHPNIEEMCO(bool EJIBDDGFJJE = false);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DGKNAIDPAJD JOANFAHKPIG(bool EJIBDDGFJJE = false);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GAJOGHLFFIO JOJKNMCGGEG(DGKNAIDPAJD FHNKDHIILBL, int PELKODHFFGF, string? LCLKDNPLMED, string? AHGIJDBMKEJ, GOCILOCPHNM HBGFNCNPMFK, List<GKMGBKADAJN>? MNBBNGOOGMB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PKKECHAPOAC(OJNLLGMGBIP GGBAOPBACDD, [Out] DGKNAIDPAJD? BMIPHJFPOAO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LNFFPJPACFN(GAJOGHLFFIO EPFDCONIBPD, [Out] DGKNAIDPAJD? BMIPHJFPOAO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PBNPAOCJINC(GAJOGHLFFIO EPFDCONIBPD, [Out] ALHKOGGDKHM? GGBAOPBACDD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KEOJJFEMGHE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	NNNBHLGDPFP NLGHGKCNDMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float MPGJIBPMNEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NNNBHLGDPFP PKHALDCAAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Vector3 AIHJNKNHHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Quaternion JMBIPPKNIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JFALIGGKHCF(JAEBJFMEEKJ NGHALOPECFO, bool GMNLPDCHGDJ);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJPOLEEMPJI();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLLCBEHKPKI(int MJKCLKCGEIP, float MDOIIPJHJJF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GBFAMFOABCH();

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HNACMKLCEEB(bool OHFAELGDCKO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BKHHHGINHCA();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HPPFPPNGNKF();

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LMEFCIABOAJ(bool OHFAELGDCKO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GDEJOKOKFGP(Transform HHMPHBNGMGF, Vector3 KCKFECPEICH, Quaternion JPAKCFIICPA);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HDMELEDKJMC
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BGECMLEGDCD MGAFGHMOJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BGECMLEGDCD DBFGHKFBGLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	IIPFAIHICNK FJBMJAMFDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	KFANBJCCOLL HOJDIEPCEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	KEOJJFEMGHE NMANJOKKMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KEOJJFEMGHE IKOOOIOFKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GameObject INALOLPJOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	AvatarConfiguration LEEEOGFHBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform CCBHEDIMNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform MMOBACPCDJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 MCIPHIILBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float MDNCNCNIOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform AIKPGIKIEIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LPOICOKCJJL(KBANNBMGJGE JOEOOAOBLCD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPNNNPNPPJO(CEGDCKHDECC GLPJLLPJKGO);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OHOCMLGJCHO();

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDFGILDEPDI();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBHAFJDGNNG(float DAFIFBHNPBO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FKPIGLMGCNL();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HKOFMDOIPHJ();

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ICCFEIPIENI();

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LJGLCFICHIP(bool DEOFCJPMPBO);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NMPKDNKBEMP([Out] Vector3 IHDDHDBEHPJ, [Out] Quaternion BAJBLBPFPNF);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Transform CGEFPHHPDED(string GGIILCEGNMA);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Vector3? MAIIPBOOMJB(string GGIILCEGNMA);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GCBMAJKFOJO(float NKJDAOJLGPE);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void HAFPLCLCLOM(float OIADPFNJLCE);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	HandLogicOffsets CFIHGLLKAND();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "23")]
	PlatformSpecificPlayerHandOffsets FNGKAFKNOIJ();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface JOONONOGMAB
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HDMELEDKJMC NFLNNGFDILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	Transform LIAGDHCHNHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void TeardownAvatarSystem();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CleanupDisplayMeshes();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdatePostIKAnimControllers(float DGOHALMDCDO);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MPCHACNCAGL
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GHHDKCJNKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HDMELEDKJMC FLBJBKMGHFK(string GGKICEPNPHD, AvatarSystemConfiguration LOGLAMBNPJF);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EDAPOJBFKNO(string GGKICEPNPHD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OCPEHBFLGHI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FJODIMOLBCE DEGCJMGFAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AFILLJLDDLH JKELEKKMKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	CFBACMJFMHA DLHBBBNIFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	CFBACMJFMHA HMMMOGLHANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DONNKKJBKEB FNFAOKJFPNE(FaceFeatureType CDPIIJCPHBI);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DONNKKJBKEB NMAFJFLIPKB(FaceFeatureType CDPIIJCPHBI);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FJODIMOLBCE OKBEKHJGDOH();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AFILLJLDDLH CJCIHIPCIGO();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CICICDBLCFP PAABEIJIMKP();

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "9")]
	CICICDBLCFP ELJMJEKFBKM();

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "10")]
	CICICDBLCFP JJJPBKDHBNJ();

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CICICDBLCFP EJMCAJJONNN();

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	CFBACMJFMHA AGFHDKEECLA();

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "13")]
	List<EPBAMAOALIM> JDLLPFAONJG(bool DMDJKFAMLCC = false, bool AFODNGFACPH = false);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "14")]
	List<EPBAMAOALIM> AAONMIJDNBN(bool DMDJKFAMLCC = false);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task NGFCAHIPLFB(bool GOMFPPHCONI, [Optional] CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task PNBOODADPCJ(GAJOGHLFFIO NFJAKGLMNLN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LJBINCFCALP
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector2 IBMENODALHH(FaceFeatureType CDPIIJCPHBI, PKLKNBHIDDA LHEGLCAAFHK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "1")]
	float GFKPNLCMBLC(FaceFeatureType CDPIIJCPHBI, PKLKNBHIDDA LHEGLCAAFHK);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OIKOMOHFMMJ(PKLKNBHIDDA LHEGLCAAFHK, AvatarConfiguration LOGLAMBNPJF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float NEFLPIHADEG(FaceFeatureType NIFKLDNIBPI, float BGBANMEEMGD, PKLKNBHIDDA LHEGLCAAFHK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "4")]
	float GMMPMHJHEEI(FaceFeatureType NIFKLDNIBPI, float NKLJGNMFDCD, PKLKNBHIDDA LHEGLCAAFHK);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Vector2 EPNACMGMDMG(FaceFeatureType NIFKLDNIBPI, Vector2 LLFCCOMMMGN, PKLKNBHIDDA LHEGLCAAFHK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Vector2 GDFCJCNMCJM(FaceFeatureType NIFKLDNIBPI, Vector2 NLOAKGCNEMF, Vector2 FABJGBLGIHK, Vector2 IBBEBMMMLKP, PKLKNBHIDDA LHEGLCAAFHK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Vector2 PIKGGDCCGOD(FaceFeatureType NIFKLDNIBPI, Vector2 LLFCCOMMMGN, Vector2 FABJGBLGIHK, Vector2 IBBEBMMMLKP, PKLKNBHIDDA LHEGLCAAFHK);
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
