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
public enum BOJNKBHGGPE
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
public enum DGCAIIMNGIE
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
public struct GBOKCIDGIJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator DHFLBBBBGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public DDNKCILDOHO DDDNJACJOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration NGFKMPOEEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject LOAGNBPEELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public BMFEHMICIHN DFMKHMJNACE;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MAEOMLDLGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Transform CIKDMOCFEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool FPLOAJGHOPE;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HNKCNCFNFJH
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
public enum MGAHEHBANKD
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
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct IGCPANEJIJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 GFBEEFACJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 NPJNPAJGPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 LPPDGOGBJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 IGJGJOOFIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 KKDHOFOCHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 NIOLAPCMINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 NBLJPDFGJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 DBOOLEMGLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 CJIJHABPIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 GEIJPPGJCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 DLMIJMLPPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 MMGBKBENICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 PMCAEBGOLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 CLIDCBGNOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 CGBJKGGICBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 JJKNLDEJLGP;
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
public static class DNKFIPKNNJM
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly string MNJAAKBOPCJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFF40", Offset = "0x6CBF340", VA = "0x186CBFF40")]
	public static LEJDNPAGPEF DIDIEGJEKNM()
	{
		return default(LEJDNPAGPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFAA0", Offset = "0x6CBEEA0", VA = "0x186CBFAA0")]
	public static HEDEKFGCFKP CPJAEBBPDHK(BMFEHMICIHN JEIAKJBAGMN, Transform LHMGKIHIEIJ, Transform CLDFPKAIDJA, AvatarConfiguration JADMOJIMCOO, Animator KIACOAACCLO, VRIK JNLGNEGCNNE, GameObject[] IGPBPJDOJAG, Transform GBBDCLAEABM, AssetReference OJAFOHKLILG, GameObject FCOLPABEDPN, GameObject INANFNBGAFI, SkinnedMeshRenderer BNGIMJDLEMN, AvatarSkinnedMeshBoneOrderRemapsData AKMMAOHIHCL, Material PBDEIAPIJKM, Material MOKJMIKFMJB, Material LPFCIIOLFCK, Shader CGPPBJDCEFJ, Shader FOHBIDNCBEO, Transform CFPDDAMHJNH, Transform EPFPDLHMDJI, Transform FBLBAFBJFGM, Transform EOPJDFCLHIN, Transform IGBGKFKICAD, Transform AHICGPGGEFA, Transform LLEBPLJMANE, Renderer[] AMDHLPEGBJG, HPNMBNLPJGF EDBJJGOMJMG, HPNMBNLPJGF FNPNFAEIKOC, HPNMBNLPJGF KGDJNGAOBFE, HPNMBNLPJGF MBCDANFFCLP, HPNMBNLPJGF MCIJFKLIJDO, HPNMBNLPJGF LGJDKMPJIAA, HPNMBNLPJGF DDDJFLLPHOO, HPNMBNLPJGF GJGGECEDIFD, Transform BIDOCCMIMBK, Transform DBMNHFNOOIF, Transform HDJHBJEHCBH, Transform EICLNAEKKMI, GameObject NBOCPLIJCGE, GameObject LGILOKAHJEB, AvatarBodyPartShapesManager GELCCPPAGEG, Transform GBBPKAIADJN, Transform JOEPKBCLGDE, Transform FIPEBPFBAGH, Transform PJHFMHBJJNL, Transform PMLEAHKKMDI)
	{
		return default(HEDEKFGCFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0640", Offset = "0x6CBFA40", VA = "0x186CC0640")]
	public static MEDIMDINCLB KAOOMKEINMG(string NHMKDDADANJ, bool KCPINEGJCCB, bool FMHMPMIGODL, JDBMGGIEIFK MKCCFGJKJKL, Func<HHMKGBKOOEK> LFNCHNHFNCK, Func<Vector3, LEJDNPAGPEF> NFOJAFCJMKE, RigidbodyEx KOOIAMCLKDP, RigidbodyEx NPKKGEODCMG, RigidbodyEx JOKFOPJKNFL, RigidbodyEx GMMOBHKPLOI, Transform PJFIKJKFJLN, Transform LHHBJLIDEEF, Transform JJNGDDFDALL, Transform IOHJLGAKPOM, float JPFBHELMJKC, float BCDIODJBJLH, PlayerAvatarModernBodyColliders PEODHEGKPPM, SkinnedMeshRenderer[] FAOLFIBODIF, SkinnedMeshRenderer[] PKEIAOBKHNI, SkinnedMeshRenderer[] AIKPEOAAONN, SkinnedMeshRenderer[] GNOCFMIDDMD)
	{
		return default(MEDIMDINCLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0360", Offset = "0x6CBF760", VA = "0x186CC0360")]
	public static BAKIGAPKNDG GMIABGHOJOD(Transform CLDFPKAIDJA, AssetReference OJAFOHKLILG, GameObject FCOLPABEDPN, GameObject INANFNBGAFI, SkinnedMeshRenderer BNGIMJDLEMN, AvatarSkinnedMeshBoneOrderRemapsData AKMMAOHIHCL, Material PBDEIAPIJKM, Material MOKJMIKFMJB, Material LPFCIIOLFCK, Shader NJJIACDDBKF, Shader NFCOLIKNKJF, Animator NLDCMOGEGGG, Renderer[] AMDHLPEGBJG, AvatarConfiguration FKGDGNOMPNB, AvatarBodyPartShapesManager GELCCPPAGEG, IReadOnlyDictionary<string, Transform> MANLJJJDOIN)
	{
		return default(BAKIGAPKNDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6CC04E0", Offset = "0x6CBF8E0", VA = "0x186CC04E0")]
	public static FOEJLBFFBDN GPDHKHKOBBH(SkinnedMeshRenderer[] FAOLFIBODIF, SkinnedMeshRenderer[] PKEIAOBKHNI, SkinnedMeshRenderer[] AIKPEOAAONN, SkinnedMeshRenderer[] GNOCFMIDDMD)
	{
		return default(FOEJLBFFBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0560", Offset = "0x6CBF960", VA = "0x186CC0560")]
	public static IIBEGEDGKFE IJEHNKFBKPD(Transform CFPDDAMHJNH, Transform FBLBAFBJFGM, Transform EPFPDLHMDJI, Transform EOPJDFCLHIN, Transform IGBGKFKICAD, Transform AHICGPGGEFA, Transform LLEBPLJMANE, AvatarConfiguration JADMOJIMCOO, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(IIBEGEDGKFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xC8CD00", Offset = "0xC8C100", VA = "0x180C8CD00")]
	public static DILPCLIJOMM LCCNHCOBNJK(SkinnedMeshRenderer[] CPBKNGIKDOI)
	{
		return default(DILPCLIJOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CC08C0", Offset = "0x6CBFCC0", VA = "0x186CC08C0")]
	public static GHNJMFAKMLI LGGHENINNJF(LKIFMGPDMFI PNJJAIPHOHJ, int EIOOLEGIBJJ, int MBCBMFJNFOC, Color NCKLFFNMJNB, Color KCOKMHAOMKA, int HJJMICHNMFI, int EPIBMNILHDL, Color CPPJPLDHKKL, Color AJMNLEOHKMH, int ABGCPFECKKM)
	{
		return default(GHNJMFAKMLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0810", Offset = "0x6CBFC10", VA = "0x186CC0810")]
	public static ILOJDILMKBL KOFOLIGFKEH(LKIFMGPDMFI PNJJAIPHOHJ, Vector2 PLDAMNJGMEP, float IFHAKEDACCJ, Vector2 LLHGBPKLHHN, float FDCGGKOFDPO, Vector2 JNBENGOHNKB, float AAKIGHEDANG, Vector2 NGEICDDFHJE, float ONAINAMNPFE)
	{
		return default(ILOJDILMKBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFF90", Offset = "0x6CBF390", VA = "0x186CBFF90")]
	public static GBOKCIDGIJF FLPJCHNCPJN(Animator GCHFPEBFJDN, DDNKCILDOHO ENHAAEBCFBL, AvatarConfiguration FKGDGNOMPNB, GameObject MLLAKJGFIOE, BMFEHMICIHN JEIAKJBAGMN)
	{
		return default(GBOKCIDGIJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0320", Offset = "0x6CBF720", VA = "0x186CC0320")]
	public static MAEOMLDLGKL GGPBLCLILJM(Transform BGNPDJPIFOJ, bool FMHMPMIGODL)
	{
		return default(MAEOMLDLGKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF910", Offset = "0x6CBED10", VA = "0x186CBF910")]
	public static PositionAndRotation ANPMKNGIIGA(Transform FKPPOKBBDKK, Transform LHMGKIHIEIJ)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0010", Offset = "0x6CBF410", VA = "0x186CC0010")]
	public static void GAMAKLBIPDN(Transform FKPPOKBBDKK, Transform LOKBJOLNEFC, PositionAndRotation EHFLPLIOEAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PAJKBNNJPAO
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1E90", Offset = "0x6CC1290", VA = "0x186CC1E90")]
	public static BOJNKBHGGPE KBLDONJGDOJ(this HNKCNCFNFJH HLPNCLEAGBF)
	{
		return default(BOJNKBHGGPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1EE0", Offset = "0x6CC12E0", VA = "0x186CC1EE0")]
	public static bool KGNGGGDMFAD(this HNKCNCFNFJH BGIAGDKACEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MJJKOPMGBLO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform GCKCOGKHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EELPDAJIFHL : MJJKOPMGBLO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform GCKCOGKHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LKKALACBNHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x10E6CF0", Offset = "0x10E60F0", VA = "0x1810E6CF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10E6BA0", Offset = "0x10E5FA0", VA = "0x1810E6BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? LECMHICLFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x12248E0", Offset = "0x1223CE0", VA = "0x1812248E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12248F0", Offset = "0x1223CF0", VA = "0x1812248F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public EELPDAJIFHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AHLBMLCALGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly EELPDAJIFHL MHEPNEEOFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly EELPDAJIFHL HHBHNCGIPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly EELPDAJIFHL HENDMIHPMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly EELPDAJIFHL KCMODCGBDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly EELPDAJIFHL AINACEOHIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly EELPDAJIFHL OOGOCIMLKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly EELPDAJIFHL JFJFOLIJGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly EELPDAJIFHL IMOCLGKJIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly EELPDAJIFHL COEMFAOGIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly EELPDAJIFHL EEHHKINIPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly EELPDAJIFHL IGMHMNNBDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly EELPDAJIFHL BLCEHNBIPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly EELPDAJIFHL JLIGMBDPPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected EELPDAJIFHL IHGEILLILGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly EELPDAJIFHL EOBAKKEGJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly EELPDAJIFHL CJAEAMOKJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly EELPDAJIFHL BKOOEKMMODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected EELPDAJIFHL HHPHEMCPOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly EELPDAJIFHL GDMMGINMHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly EELPDAJIFHL IFKNEINKGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly EELPDAJIFHL CHAMGGIOEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected ReadOnlyCollection<EELPDAJIFHL> FFKBKADIPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Transform GBBDCLAEABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private (EELPDAJIFHL Start, EELPDAJIFHL End)[] ADPHOCICAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Dictionary<string, EELPDAJIFHL> LPOPLPCNGEP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MJJKOPMGBLO CBBLFNOJJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MJJKOPMGBLO BMANGDIPJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MJJKOPMGBLO JEGANIGDGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MJJKOPMGBLO OAEEMOBJCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MJJKOPMGBLO DGMMCNBIPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MJJKOPMGBLO OGCGAHEINHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MJJKOPMGBLO HPILJPIKLJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBA0", Offset = "0x8ACFA0", VA = "0x1808ADBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MJJKOPMGBLO ENKFGEMCNPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBE0", Offset = "0x8ACFE0", VA = "0x1808ADBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MJJKOPMGBLO PKGMFGONOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBD0", Offset = "0x8ACFD0", VA = "0x1808ADBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDED0", Offset = "0x6CBD2D0", VA = "0x186CBDED0")]
	public void IEKHEODPKHF(VRIK GAGPNIPELOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDCA0", Offset = "0x6CBD0A0", VA = "0x186CBDCA0")]
	private void EBLLCPGEKOC(Transform PPIMIKDHEBO, EELPDAJIFHL ANHPPPBDANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF320", Offset = "0x6CBE720", VA = "0x186CBF320")]
	public EELPDAJIFHL PKJGHOGIOOM(string MOGIFHOJGII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEDF0", Offset = "0x6CBE1F0", VA = "0x186CBEDF0")]
	public void NDAHNAEBNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDC60", Offset = "0x6CBD060", VA = "0x186CBDC60")]
	public float COALAMGLCGC([In] (EELPDAJIFHL Start, EELPDAJIFHL End) FPNOEMINGOJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD30", Offset = "0x6CBD130", VA = "0x186CBDD30")]
	public void GEJKOKGFFOI([In] LEJDNPAGPEF NOGEMBGGBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF1F0", Offset = "0x6CBE5F0", VA = "0x186CBF1F0")]
	private Vector3 NLDCKNJOHPA([In] (EELPDAJIFHL Start, EELPDAJIFHL End) FPNOEMINGOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF390", Offset = "0x6CBE790", VA = "0x186CBF390")]
	public AHLBMLCALGL()
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
		[Cpp2IlInjected.Address(RVA = "0x6CBF870", Offset = "0x6CBEC70", VA = "0x186CBF870")]
		public string BGEHNCMCIIG(string AFEHHCHAIEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF8C0", Offset = "0x6CBECC0", VA = "0x186CBF8C0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum JDBMGGIEIFK
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
public struct MEDIMDINCLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string GLOJHHINMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool FPLOAJGHOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool GPCCDEOJILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float FCBFBJIKLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float ALKHFDNAJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public JDBMGGIEIFK HHAIGHKOIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Func<HHMKGBKOOEK> IDGGFGJKLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Func<Vector3, LEJDNPAGPEF> EJPGGECEPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public RigidbodyEx KBHGOMCCPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public RigidbodyEx PHCMCJMJBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public RigidbodyEx JKBJBNMKOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public RigidbodyEx FMKIJALCAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform OEMDHNOKGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform IHHEJMHEDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform MMMDLBLBAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform MBKMHHFOFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
	public PlayerAvatarModernBodyColliders PEODHEGKPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public SkinnedMeshRenderer[] CICDHEJIIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public SkinnedMeshRenderer[] LLJNDLBOGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public SkinnedMeshRenderer[] GJGGIILEMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public SkinnedMeshRenderer[] GJELANPHDBD;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LBIDJHKLHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6B378E0", Offset = "0x6B36CE0", VA = "0x186B378E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool BNIHPAALCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6B378A0", Offset = "0x6B36CA0", VA = "0x186B378A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0EF0", Offset = "0x6CC02F0", VA = "0x186CC0EF0")]
	public LEJDNPAGPEF DFANPIGEKDG(Vector3 NOENAILFCLB)
	{
		return default(LEJDNPAGPEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HEDEKFGCFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public BMFEHMICIHN DFMKHMJNACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform FHLGBBKCAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform PLLOGPPNEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public AvatarConfiguration NGFKMPOEEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Animator HIOOKPALKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public VRIK LECOJNONCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public GameObject[] MIIBCAKOHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Transform FFLOCAHGPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public AssetReference BFHAOHKNDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public GameObject LAGLHNCKDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject DANLNEJLHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public SkinnedMeshRenderer FBOCELEFMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public AvatarSkinnedMeshBoneOrderRemapsData GODEPEIIION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Material PHKOIKCMDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Material PHBCEIEFKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Material OIJPPJBCHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Shader IJDGBLOCAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Shader EGLCOOLMJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform IGMNCFMCIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform MJFGOHHCHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform NAGGKHFCKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Transform BEFHEPJDBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Transform FOFCGFBFBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Transform MGNPMDMAIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Transform KEIKCEBOMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Renderer[] FLLBLJLMNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Transform KFECFBONCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Transform DOIKNILGMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public GameObject EEOMAOBDEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public GameObject MLANFPACNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Transform OEILNKINANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Transform JGIFPDFHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Transform KAICDPMDMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public HPNMBNLPJGF IBIFAKIPMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public HPNMBNLPJGF BLJDGBGFBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public HPNMBNLPJGF NHLCHLAGKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public HPNMBNLPJGF IMABMAMEOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public HPNMBNLPJGF GELNHINGIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public HPNMBNLPJGF PMFNHNIICJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public HPNMBNLPJGF EIJMADDGCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public HPNMBNLPJGF GEGGDDPPNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public AvatarBodyPartShapesManager GFFFFFLFMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform JCFEDAFLDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform BCFNNKEIGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform ACEBBPILEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Transform PEFEDKPOCFG;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HHMKGBKOOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool CICOCLNIOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public GGHKEJOODBA KELNGNCHPGE;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LEJDNPAGPEF
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class GCDNJIAEMCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly bool EDDLNOKGDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly bool DNODLCMNLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly bool IDHEBJBHANK;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0A00", Offset = "0x6CBFE00", VA = "0x186CC0A00")]
		public GCDNJIAEMCB(bool HJGMLIEIGOI, bool IPIIHDIMJMM, bool FPMFCCCCCOH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float KIEOLBEMBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool MKKJIDJBAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float INLIPHHJANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3 BOAHPKOFJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Vector3 DLKOBAOKDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3? EEIHAOBLEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3? MDCFGBFKFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool LNBKBDPFOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool PKFFIOAJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool DIKFIJFAIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool BFBHJDECLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Vector3? DLGPJPBPONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool CDEMGLCHGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public Vector3? MHHKMFGFNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool DCGPNGMFLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Vector3? OJCHHJFAAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float HFKFBMPKDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Vector3? BNNPIKAPPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool GJKDIJACNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public bool OMBDCLNJPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public bool PODKGBPLIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool AJLIBIJNHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public bool ECKCBGEINGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public bool GNHEPDEDNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public bool BOCJJAFNJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public bool HKLPMIPFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public bool DNCFIOCFJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public bool NFIMLGKDNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public bool HFHIDHPDJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Vector3? BDGDJDPAJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public HNKCNCFNFJH JLJLCHNENBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public HNKCNCFNFJH ACKLPNNOADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float JJPKNMPFEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public float CNIEFLOBOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public MGAHEHBANKD ONEMMKKKPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public MGAHEHBANKD IDKFLJDFILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public bool GAHNAPOACHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public bool JJICHBPLFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public bool HOGCADNBPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public float NAJBIDCGGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public float JPFOCNBLALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public float CDPEPIKMOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public GCDNJIAEMCB HCDGCKKHHHP;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0AD0", Offset = "0x6CBFED0", VA = "0x186CC0AD0")]
	public void EKDGLNAFFOB(Quaternion EFFHGIJAIIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FAKBGHDABIC
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6CC09E0", Offset = "0x6CBFDE0", VA = "0x186CC09E0")]
	public static KJCIGENAPJO KJFPGJCLJGK(this HAJALDHAKAI MBGHIKEGJAA)
	{
		return default(KJCIGENAPJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6CC09C0", Offset = "0x6CBFDC0", VA = "0x186CC09C0")]
	public static void KIMADFBELNK(this HAJALDHAKAI MBGHIKEGJAA, KJCIGENAPJO LIHHDPOHLDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HFIDKPIINJG
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0A50", Offset = "0x6CBFE50", VA = "0x186CC0A50")]
	public static bool NILMJGHBPAG(this KHMIFHAEBNK DABCNNICBCP, KKELKFJEAOL KHMAICDCBBO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HPNMBNLPJGF
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float GJPMFKBAIBN);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class PlayerAvatarModernBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum KJDMJPCEMDA
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
		private BLDLAPDPBID BACHHMKHGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private List<Collider> EMOKCPMOFCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private List<Collider> INAHLJKJJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private List<Collider> EJEGAKADDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private KJDMJPCEMDA? CANIGIBJCPM;

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
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] KHOCAFDCCEP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<Collider> OAAMHOPMNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6CC2DB0", Offset = "0x6CC21B0", VA = "0x186CC2DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyList<Collider> OFEPCBHKMFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6CC2DD0", Offset = "0x6CC21D0", VA = "0x186CC2DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> CJGPJADAAOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6CC2DF0", Offset = "0x6CC21F0", VA = "0x186CC2DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private BLDLAPDPBID MCALILFPMDI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6CC1EF0", Offset = "0x6CC12F0", VA = "0x186CC1EF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool FNMGEGELIGI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA42330", Offset = "0xA41730", VA = "0x180A42330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1FC0", Offset = "0x6CC13C0", VA = "0x186CC1FC0")]
		private void ENNCPDPAOPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1F90", Offset = "0x6CC1390", VA = "0x186CC1F90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2D90", Offset = "0x6CC2190", VA = "0x186CC2D90")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer CGFJPBHOFBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6CC29F0", Offset = "0x6CC1DF0", VA = "0x186CC29F0")]
		public void SetCollidersEnabled(KJDMJPCEMDA NOGEMBGGBHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2560", Offset = "0x6CC1960", VA = "0x186CC2560")]
		public void ReparentBonesUnderOtherBoneCollection(BLDLAPDPBID EKPBHHFMMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2290", Offset = "0x6CC1690", VA = "0x186CC2290")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE20", Offset = "0x8AB220", VA = "0x1808ABE20")]
		public PlayerAvatarModernBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OGNGAHPMJDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Transform ONLINJCNJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Transform LMAHBPLGOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform BDDHLBPCJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Transform IKJLDEIFCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform JKFGGFPMFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Transform MAABCABNOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform ECPANBAFEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Transform IOPFMDLKHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform OHPENNCEFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PositionAndRotation FOOLPGJOGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PositionAndRotation MPAIIJPLELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private PositionAndRotation NPFMIONHAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PositionAndRotation DKAEADFAPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PositionAndRotation FJNDJKPBIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private PositionAndRotation FLLPLGHLFAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private PositionAndRotation HMPBAJOIHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private PositionAndRotation DFFMPJFGIDJ;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1550", Offset = "0x6CC0950", VA = "0x186CC1550")]
	public void JLABJFAHLGH(Transform MHFHILPPBCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6CC19B0", Offset = "0x6CC0DB0", VA = "0x186CC19B0")]
	public void OLEBIHOADPN(HandLogicOffsets LILNEFJEHAL, DDNKCILDOHO ACAHHJFECHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1760", Offset = "0x6CC0B60", VA = "0x186CC1760")]
	public void KIDGIEKICJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public OGNGAHPMJDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MFMLKDBMEIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform GBNHDDJJMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform NIPECMFJNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Transform JDDABIIEBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Transform NJPKFPIPIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private Transform FPIKNCHNNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private PositionAndRotation EJJGGJAOJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private PositionAndRotation IAGGCIPNKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private PositionAndRotation JPOJLGECLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private PositionAndRotation JHPHFKOFDBE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1290", Offset = "0x6CC0690", VA = "0x186CC1290")]
	public void JLABJFAHLGH(Transform GIOHLLECGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1090", Offset = "0x6CC0490", VA = "0x186CC1090")]
	public void AEJKDHEEBHA(HeadLogicOffsets EHFLPLIOEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6CC13C0", Offset = "0x6CC07C0", VA = "0x186CC13C0")]
	public void KEBJDOFHAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public MFMLKDBMEIP()
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
