using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Avatars;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum ANBMMDFIHBA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Idle,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Invisible,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Pointing,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	TPose,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	ThumbUp,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	HandShake,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Grabbing,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	NumStates
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum PCMMCMPCLFH
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ThumbUp = 1,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Pointing = 2,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	HandShake = 4
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NDOANFGOBGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator IIBACJPNDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public IGDIBPEEMHD ABFKFKDGHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration HDNNGKEGDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject IALGNGGOCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public DANEJOKJCGO LMGEKMKCDGC;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HNIHPLCACCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Transform DMONCHEEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool HFCHFJMFANK;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KOKMAFANCEF
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum DADJPCJNGEE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	AimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	MeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	LightItem,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	HeavyItem,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	AimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Action,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NumTypes
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DMGEMBLIOCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 EELDFEKGPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 EGJGJOBCLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 GJMLBNBLEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 MGHDPPHKGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 OANDNOPKNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 FOEODPCOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 FICKFBFMNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 LGPLHOIKBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 EGDNGEMGMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 GOOHGPEMOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 EBFBLCFOHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 EHJFFDGNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 MCHPEJNIKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 DIOHAJDEIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 INHIFNGDIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 ILJNKNGJLGJ;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KAEBBAOPBDA
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly string JIEGMNBIJCA;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B41470", Offset = "0x6B40670", VA = "0x186B41470")]
	public static MHOABJOJNEL BNAPJIBLFNK()
	{
		return default(MHOABJOJNEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B41FE0", Offset = "0x6B411E0", VA = "0x186B41FE0")]
	public static CPJJKCJALHG PDFEGLCFMAN(DANEJOKJCGO HAELGLMEIMP, Transform EIIAHDPLMGC, Transform LIMEBBNBFLL, AvatarConfiguration IDLPLLJJIPO, Animator PGLLCEDFJOO, VRIK FAFOOECDOEM, GameObject[] NFICGPHPAIN, Transform AOFAJLNPJNB, AssetReference BDAHBNLBKKG, GameObject LFLKIKHCJJG, GameObject NGNJMOGJDGA, SkinnedMeshRenderer NPFDMJBCGHA, AvatarSkinnedMeshBoneOrderRemapsData LEMGCDHNPIO, Material PFIJGOICGMF, Material COGIAPEOOCF, Material BIFOFEMLABN, Shader DIEKIEDBEMG, Shader DNJICMCOPML, Transform LKPELBPEBGH, Transform HBAPILLOHKG, Transform NOCGKGBAKJG, Transform BBDLICDFCBJ, Transform FLANANPDGKG, Transform HGENNODILAI, Transform NMKMMDGHIAD, Renderer[] EALDBIJMNFO, PNBCFBEJCEK PPCIDFJHHBI, PNBCFBEJCEK FHJJBHNBPLO, PNBCFBEJCEK MEOMBELMKII, PNBCFBEJCEK GFGEDFCBFCJ, PNBCFBEJCEK IPICLMALOJB, PNBCFBEJCEK KPOKGBKCKGB, PNBCFBEJCEK GMMLKODJOGK, PNBCFBEJCEK CPBAHGGNANI, Transform MCOHPMEEHHD, Transform KHPLPDIBOIO, Transform BFHGFOAPFMP, Transform JOBGJJCPMDJ, GameObject IFNABFAGJOO, GameObject NJIACFGPEAL, AvatarBodyPartShapesManager IPEEKAMLNMC, Transform KDHKGLKOGKF, Transform OBBOALEEHGA, Transform MDIKLDEIDPD, Transform HFKOKMEAOPC, Transform ALNCKMHMIKM)
	{
		return default(CPJJKCJALHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B414C0", Offset = "0x6B406C0", VA = "0x186B414C0")]
	public static KLMMLBILLMG CDCIANPLCFD(string MLHPMIGOANA, bool CAOKCNJNGGP, bool LHOHJJBHLGL, AJLLIEJFPPH LKNMJHHABGJ, Func<CDJLLHFFCLC> COJPJLMEAPK, Func<Vector3, MHOABJOJNEL> MIEGDCMBHCB, RigidbodyEx GELKOBAJNAO, RigidbodyEx LCBDOINIHOP, RigidbodyEx NMNKJMJJOPA, RigidbodyEx NCOELECONOJ, Transform KPDDNIPIEKM, Transform PLEPKOCKLID, Transform KAGMGCDJKOC, Transform OLIJAKBHDLC, float MIEAKGNNAEC, float PAKJGNMEPBD, PlayerAvatarModernBodyColliders LCBIHOJNGJK, SkinnedMeshRenderer[] GHPGONBGCMF, SkinnedMeshRenderer[] NOPPKGHKIPM, SkinnedMeshRenderer[] DGFMGCECDFK, SkinnedMeshRenderer[] GHOFPJCOAIB)
	{
		return default(KLMMLBILLMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B417F0", Offset = "0x6B409F0", VA = "0x186B417F0")]
	public static MMHACACOCJN IODPOCKGDBA(Transform LIMEBBNBFLL, AssetReference BDAHBNLBKKG, GameObject LFLKIKHCJJG, GameObject NGNJMOGJDGA, SkinnedMeshRenderer NPFDMJBCGHA, AvatarSkinnedMeshBoneOrderRemapsData LEMGCDHNPIO, Material PFIJGOICGMF, Material COGIAPEOOCF, Material BIFOFEMLABN, Shader HPJPPGFEPNK, Shader IMMHJONIIAH, Animator LEOFEHOHMNC, Renderer[] EALDBIJMNFO, AvatarConfiguration ODPKPFKMAJM, AvatarBodyPartShapesManager IPEEKAMLNMC, IReadOnlyDictionary<string, Transform> GOPANEOGFGF)
	{
		return default(MMHACACOCJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B41C50", Offset = "0x6B40E50", VA = "0x186B41C50")]
	public static BFELLOJLFHE NNDNPKMOECK(SkinnedMeshRenderer[] GHPGONBGCMF, SkinnedMeshRenderer[] NOPPKGHKIPM, SkinnedMeshRenderer[] DGFMGCECDFK, SkinnedMeshRenderer[] GHOFPJCOAIB)
	{
		return default(BFELLOJLFHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B41690", Offset = "0x6B40890", VA = "0x186B41690")]
	public static ICONOBCDNKF FLEABMDDCIF(Transform LKPELBPEBGH, Transform NOCGKGBAKJG, Transform HBAPILLOHKG, Transform BBDLICDFCBJ, Transform FLANANPDGKG, Transform HGENNODILAI, Transform NMKMMDGHIAD, AvatarConfiguration IDLPLLJJIPO, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(ICONOBCDNKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xC43E20", Offset = "0xC43020", VA = "0x180C43E20")]
	public static GFNIKGLNNEI FNFHAFJOMJP(SkinnedMeshRenderer[] EMJADHAGGNI)
	{
		return default(GFNIKGLNNEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B41BB0", Offset = "0x6B40DB0", VA = "0x186B41BB0")]
	public static KEOHOAOFCFA LEJMCPBMIDC(HBFKEPBAMCF BFAPBOEDDHJ, int PIEPNHAFDJN, int CBLILBALJCG, Color HINCMIJPAHK, Color OJPLCHMJNPL, int HOAKJKPJLNB, int INDMJABGFJM, Color DMNMNMNBCIO, Color OIMAHIJDIEP, int MLJCNGMCNIM)
	{
		return default(KEOHOAOFCFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B41B00", Offset = "0x6B40D00", VA = "0x186B41B00")]
	public static BEBEJFPBALF KAFPBIHCBMB(HBFKEPBAMCF BFAPBOEDDHJ, Vector2 LNKEFLDKFME, float JAJHFNECNOE, Vector2 ICIJIEGICJL, float GMKOOODHBGI, Vector2 PCPJLMECMML, float CODEEJKJPOK, Vector2 JEELPOHDCND, float INMNILAJBHP)
	{
		return default(BEBEJFPBALF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B41770", Offset = "0x6B40970", VA = "0x186B41770")]
	public static NDOANFGOBGA FPLEJDPHPFI(Animator MNBDGLMHEOJ, IGDIBPEEMHD BNLLCDNIEKG, AvatarConfiguration ODPKPFKMAJM, GameObject GHDONFIKLKO, DANEJOKJCGO HAELGLMEIMP)
	{
		return default(NDOANFGOBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B41430", Offset = "0x6B40630", VA = "0x186B41430")]
	public static HNIHPLCACCG AOILBEINJFF(Transform EDMIHPPGBGA, bool LHOHJJBHLGL)
	{
		return default(HNIHPLCACCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B41970", Offset = "0x6B40B70", VA = "0x186B41970")]
	public static PositionAndRotation JMNLODPDHNI(Transform HKFNHOCKLFM, Transform EIIAHDPLMGC)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B41CD0", Offset = "0x6B40ED0", VA = "0x186B41CD0")]
	public static void NPPIHGAOMMI(Transform HKFNHOCKLFM, Transform IHAFJCMHJIC, PositionAndRotation OIDCHCODOPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JFBMOMIDIIF
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B413E0", Offset = "0x6B405E0", VA = "0x186B413E0")]
	public static ANBMMDFIHBA EJELCIMGCAH(this KOKMAFANCEF JLEGCJNKPHO)
	{
		return default(ANBMMDFIHBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B413D0", Offset = "0x6B405D0", VA = "0x186B413D0")]
	public static bool BHLJOLDPCNG(this KOKMAFANCEF FMLIEGGDOGI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LNIJLNBPJIM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform HFFBGEFJFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CIKDMEOBMDI : LNIJLNBPJIM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform HFFBGEFJFMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8941F0", Offset = "0x8933F0", VA = "0x1808941F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 MBINAALEGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x10A1770", Offset = "0x10A0970", VA = "0x1810A1770", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10A1760", Offset = "0x10A0960", VA = "0x1810A1760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? KNMIFNBMNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x11D1490", Offset = "0x11D0690", VA = "0x1811D1490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11D14A0", Offset = "0x11D06A0", VA = "0x1811D14A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public CIKDMEOBMDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HGFBPMFBFDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly CIKDMEOBMDI GCECBKJPPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly CIKDMEOBMDI BNPMMLKGPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly CIKDMEOBMDI PLJFPCNGBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly CIKDMEOBMDI AKGEDJBCAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly CIKDMEOBMDI LKJAOGMDIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly CIKDMEOBMDI IOPFEFKEIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly CIKDMEOBMDI FFKGOGIFKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly CIKDMEOBMDI AFDGOJMODDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly CIKDMEOBMDI OCDKDHKKMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly CIKDMEOBMDI KHMHMLIJPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly CIKDMEOBMDI HOPJIIAOEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly CIKDMEOBMDI PNLFLFMANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly CIKDMEOBMDI GKBNABHKPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected CIKDMEOBMDI HELHBIIIPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly CIKDMEOBMDI FBPHJDEPJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly CIKDMEOBMDI IBFJNBEPLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly CIKDMEOBMDI CHFAGGIDGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected CIKDMEOBMDI PMBAEPHAMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly CIKDMEOBMDI LIKKFHMNMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly CIKDMEOBMDI HOENEMNJFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly CIKDMEOBMDI OKEGHALFGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected ReadOnlyCollection<CIKDMEOBMDI> CNLCBIFJJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Transform AOFAJLNPJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private (CIKDMEOBMDI Start, CIKDMEOBMDI End)[] EACEIMJMCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Dictionary<string, CIKDMEOBMDI> POKOIOMMCCF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LNIJLNBPJIM PPFDJPAHPFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LNIJLNBPJIM ADHGIBBKGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LNIJLNBPJIM JDOCCPIPDPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LNIJLNBPJIM OMHBCHJHGMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LNIJLNBPJIM JFDDCMMGPBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LNIJLNBPJIM PEMJAANCFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LNIJLNBPJIM ADIIECBCJDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x894480", Offset = "0x893680", VA = "0x180894480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LNIJLNBPJIM LALGMGABKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x897130", Offset = "0x896330", VA = "0x180897130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LNIJLNBPJIM DMNCAOMCJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x894380", Offset = "0x893580", VA = "0x180894380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FEE0", Offset = "0x6B3F0E0", VA = "0x186B3FEE0")]
	public void KDCBBKOGOKI(VRIK LEHPFFKBBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F800", Offset = "0x6B3EA00", VA = "0x186B3F800")]
	private void AMFLOBFBFEG(Transform KLCFDAPKGEC, CIKDMEOBMDI LCMBJJGJCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FA30", Offset = "0x6B3EC30", VA = "0x186B3FA30")]
	public CIKDMEOBMDI EHOIPHPFOGN(string HMONCPNNKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FAE0", Offset = "0x6B3ECE0", VA = "0x186B3FAE0")]
	public void ILJDMNGFMKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FAA0", Offset = "0x6B3ECA0", VA = "0x186B3FAA0")]
	public float FHCCCPIFNCM([In] (CIKDMEOBMDI Start, CIKDMEOBMDI End) EHLHEAEOBLL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F890", Offset = "0x6B3EA90", VA = "0x186B3F890")]
	public void COICLEOBBKA([In] MHOABJOJNEL NHDPLCKEAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B40DC0", Offset = "0x6B3FFC0", VA = "0x186B40DC0")]
	private Vector3 PLPGBIOPFIP([In] (CIKDMEOBMDI Start, CIKDMEOBMDI End) EHLHEAEOBLL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B40EF0", Offset = "0x6B400F0", VA = "0x186B40EF0")]
	public HGFBPMFBFDD()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3ED50", Offset = "0x6B3DF50", VA = "0x186B3ED50")]
		public string GGCPNBBFMJM(string NCHJFPDHODI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B3EDA0", Offset = "0x6B3DFA0", VA = "0x186B3EDA0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum AJLLIEJFPPH
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Input,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	AnimationPlayback,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	HolotarPreviewOrPlayback
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KLMMLBILLMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string AHHNGABGMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool HFCHFJMFANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool MCMMIIMLOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float HFCCOFOOMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float ADBDCAACDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public AJLLIEJFPPH NFFMJOJJFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Func<CDJLLHFFCLC> MFKPLBCFGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Func<Vector3, MHOABJOJNEL> JLKNFPAEBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public RigidbodyEx NANCLHNLCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public RigidbodyEx GNNKGMDBBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public RigidbodyEx BHLCCMGEECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public RigidbodyEx CBCOAOIJNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform BPLDJDCCGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform CIOABMJIDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform JDNHAENEPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform IKAOOEOPICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
	public PlayerAvatarModernBodyColliders LCBIHOJNGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public SkinnedMeshRenderer[] HKECHAJEFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public SkinnedMeshRenderer[] FNJLONICGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public SkinnedMeshRenderer[] EGIDCLKENDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public SkinnedMeshRenderer[] BBAHNPGHJFK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool PMBIGFAMNFH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69C83E0", Offset = "0x69C75E0", VA = "0x1869C83E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KMPIICAMCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69C8380", Offset = "0x69C7580", VA = "0x1869C8380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B429A0", Offset = "0x6B41BA0", VA = "0x186B429A0")]
	public MHOABJOJNEL GCBCBPDKKOA(Vector3 OIMJLGPCNAE)
	{
		return default(MHOABJOJNEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct CPJJKCJALHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public DANEJOKJCGO LMGEKMKCDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform MNNFGIMFDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform PDKENCABDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public AvatarConfiguration HDNNGKEGDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Animator LIJMFMJPOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public VRIK DEEBLIEBPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public GameObject[] OJMEJFIDMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Transform PNIHMCJHFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public AssetReference BEOFCOKNCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public GameObject FEKBOPMHHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject HJELJHOLGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public SkinnedMeshRenderer POHEPGJOCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public AvatarSkinnedMeshBoneOrderRemapsData CKPNFHJFJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Material KHFJJNEINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Material OLCENGGMPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Material OOACBLNHGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Shader ABAAAODPAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Shader KFLPLJKKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform AIPNNADNFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform CLBBIBEPKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform CDJLHKMIHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Transform JLAAMIDGGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Transform GPFPJOKKBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Transform IPMCINFFEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Transform FKNHENMMOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Renderer[] BPBBPMKONHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Transform HJDBMINKBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Transform MHLOAFNCHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public GameObject MLBNBAMBBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public GameObject KAGINMNJFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Transform OBHLILMHLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Transform NFDKKIADNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Transform PCIGLKGOBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public PNBCFBEJCEK FPFMBKADFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public PNBCFBEJCEK BNAJNAJCCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public PNBCFBEJCEK GDMLLLGABHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public PNBCFBEJCEK LODDFOGFMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public PNBCFBEJCEK BDAKINKILBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public PNBCFBEJCEK NFPJLMLGMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public PNBCFBEJCEK IEJIHFHEIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public PNBCFBEJCEK IKGOAMPGOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public AvatarBodyPartShapesManager DNNAOGAOKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform MFAEMNJMGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform BHNOLANKFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform HDGCCLDBJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Transform NMBBAJJLPOE;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CDJLLHFFCLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool EBOCGBABLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public KOEAFBADJNF GKPBHKDHPFD;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MHOABJOJNEL
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class FEFPKCAHPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly bool MBAMLPLKCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly bool JPKNHBBGLAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly bool PMAJEMKGOLC;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6B3EE70", Offset = "0x6B3E070", VA = "0x186B3EE70")]
		public FEFPKCAHPNL(bool KLLFFCOADHF, bool BBHIGNFACAO, bool HCFGEFGLILH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float LGDKAGOJMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool DOOACCLOLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float OIPANGFJKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3 KNBOPGCFMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Vector3 KGGOPFBKJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3? EEGHHGEOGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3? HMKCFDAEOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool BMBNEBJNIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool CLMMPODDLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool GAKNGOLMOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool OKLJBKJNKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Vector3? FNHMEJMELLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool JCPAHKCDFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public Vector3? HBAOEMMJBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool OBKJPIDBHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Vector3? PBNMAGLLGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float KHOJEFLANFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Vector3? HBBNGCHDJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool DMKFFCGPHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public bool PELOCMLJIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public bool BLIBNLBEPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool OJDOKEEGCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public bool OCELFHFJJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public bool GNNMPDLPGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public bool HCFLKHBJJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public bool HGFLOEHOKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public bool LEDCEBHHHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public bool IFOPNCKLKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public bool ABNFJOLCEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Vector3? OMKPLNGKJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public KOKMAFANCEF OAIJGEKDMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public KOKMAFANCEF FFGCCBBEIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float JNGCDLCBDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public float ALKOOFJMCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public DADJPCJNGEE EEOIJEHKCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public DADJPCJNGEE DLMJGPEJLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public bool AOLPBACHINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public bool OCEKCODBCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public bool DHHHDLEBPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public float IMNGPNKIEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public float ALPHCKFOPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public float GNGEJBMPHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public FEFPKCAHPNL KDOFDBDOCDE;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B42B80", Offset = "0x6B41D80", VA = "0x186B42B80")]
	public void GNKGPJFEGAB(Quaternion MBMKLLFOFFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KNAHIHDJGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6B42B60", Offset = "0x6B41D60", VA = "0x186B42B60")]
	public static IPFKHDEMKPH LPADKMBGEMH(this FENDCALOPLC AEFKHDNCNFD)
	{
		return default(IPFKHDEMKPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6B42B40", Offset = "0x6B41D40", VA = "0x186B42B40")]
	public static void FEOPFNLIJPM(this FENDCALOPLC AEFKHDNCNFD, IPFKHDEMKPH JECHHBGMFLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DOMPDEIDMOK
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EDF0", Offset = "0x6B3DFF0", VA = "0x186B3EDF0")]
	public static bool NDHGADOLBPO(this ADIPFKJJNGC JAEJPMKJPEM, AKBDHMBAAAA JMFDAFBPNNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PNBCFBEJCEK
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float GCFLAEHGPCH);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class PlayerAvatarModernBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum BFODJIMNBKC
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			EnabledForFullBody,
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			EnabledForModernBeanBody
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private JMGHCKNLFAK MFAHJJNDOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private List<Collider> LKLMBLHFPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private List<Collider> HNKNLPDKDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private List<Collider> GBACCLLLBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private BFODJIMNBKC? LJIMHMBOLBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[SerializeField]
		private Collider[] FullBodyOnlyColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] GGPDHMBJICL;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<Collider> AMPCAAHPHDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6B43E60", Offset = "0x6B43060", VA = "0x186B43E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyList<Collider> OFBNIALCNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6B43E80", Offset = "0x6B43080", VA = "0x186B43E80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> NHBCJJOLPEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6B43EA0", Offset = "0x6B430A0", VA = "0x186B43EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private JMGHCKNLFAK NFONFFHNPIF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6B42FA0", Offset = "0x6B421A0", VA = "0x186B42FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool LKOEGDIEJKE
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9F2020", Offset = "0x9F1220", VA = "0x1809F2020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B43070", Offset = "0x6B42270", VA = "0x186B43070")]
		private void CCAPAPEPLCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6B43040", Offset = "0x6B42240", VA = "0x186B43040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6B43E40", Offset = "0x6B43040", VA = "0x186B43E40")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer LKJCNHIPHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6B43AA0", Offset = "0x6B42CA0", VA = "0x186B43AA0")]
		public void SetCollidersEnabled(BFODJIMNBKC NHDPLCKEAAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B43610", Offset = "0x6B42810", VA = "0x186B43610")]
		public void ReparentBonesUnderOtherBoneCollection(JMGHCKNLFAK CAADNMMGBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6B43340", Offset = "0x6B42540", VA = "0x186B43340")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public PlayerAvatarModernBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FICCMPINIIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Transform HJBPNOGOPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Transform GMHFCFOEHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform HNLKKICIOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Transform KJKPEGPCKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform GNECBGGIFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Transform IIDNBADCBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform BFLMHJOGFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Transform AMPDJPLOBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform MPNBCMJJNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PositionAndRotation JPJMOOAHDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PositionAndRotation IEPEKLOEPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private PositionAndRotation LNGIJPMPPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PositionAndRotation IJDHEDONPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PositionAndRotation LIFCOOGECBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private PositionAndRotation PCDPMMNJJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private PositionAndRotation LDJKKEMDNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private PositionAndRotation FAGIBOBBEHG;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EEC0", Offset = "0x6B3E0C0", VA = "0x186B3EEC0")]
	public void DDNLIMMJHCH(Transform AOOPEBGHPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F0D0", Offset = "0x6B3E2D0", VA = "0x186B3F0D0")]
	public void DIEOKPFEEDK(HandLogicOffsets IEFIGLOMAKA, IGDIBPEEMHD HDCCCKFEBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F5B0", Offset = "0x6B3E7B0", VA = "0x186B3F5B0")]
	public void HDHDNBAACOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public FICCMPINIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class KIEEOHGIMMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform CBIOAAOOHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform FKJBOOCDAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Transform GMLEEEOHIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Transform FPEDLIDCCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private Transform JJLACMNOHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private PositionAndRotation MDCPOPOHLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private PositionAndRotation BKDEAHNLBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private PositionAndRotation CLNKLPGEJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private PositionAndRotation CIGDCGKOPAO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6B424E0", Offset = "0x6B416E0", VA = "0x186B424E0")]
	public void DDNLIMMJHCH(Transform MAFNBHOMAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B427A0", Offset = "0x6B419A0", VA = "0x186B427A0")]
	public void OKKBMGCLBOP(HeadLogicOffsets OIDCHCODOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B42610", Offset = "0x6B41810", VA = "0x186B42610")]
	public void NFNFNJBENAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KIEEOHGIMMM()
	{
	}
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
