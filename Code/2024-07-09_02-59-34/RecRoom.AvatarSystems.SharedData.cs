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

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MOHACDPOFED
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
public enum DIHIDCHNPMP
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
public struct FJOEBMLCDOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator FPICPMONEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KGCGGBFKMOO FEFPLLCKCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration GOEPEGMCIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject NIIGMMFPOEA;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PMCNHIBKFLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform HEGFJKNJFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool EBOAGJFCBEG;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FNIEINJFJCL
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum CJHKPNLBDLG
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	AimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	MeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	LightItem,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	HeavyItem,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	AimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Action,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	NumTypes
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public PositionAndRotation WatchMenuOriginOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HGELFFJEGPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 HNKCKLEGLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 BKDKKHDDHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 CIJIMLLJGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 IBMHDMHJBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 IMDKPBIPGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 EEDFBOPHBGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 OMOJBIDHDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 BGBJCCDCLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 MIKPLLFILPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 LLGJCJGDKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 EEBJCAFOGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 CBJPOKKEJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 DOKOEAMPHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 HJCFJLJCEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 DENOJLDMPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 IAHNKEKBKFA;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class IEFOPFKKMIM
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly string MLPHFAHFJII;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68B7060", Offset = "0x68B5C60", VA = "0x1868B7060")]
	public static DNBDNPFFHFC KBPGAOHLJCJ()
	{
		return default(DNBDNPFFHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68B6AB0", Offset = "0x68B56B0", VA = "0x1868B6AB0")]
	public static LGINAHDHIGK HNBMMBKJHGB(Transform IFGLEMAFOAB, Transform IBPCDHOPCOA, AvatarConfiguration AAPAGCKHJDD, Animator FACDFBAFONJ, VRIK NGGJGCKBJIK, GameObject[] HGALAGJPIPJ, Transform IIHNBDFNHFD, AssetReference EIDBMJAOIPM, GameObject BNJCABHLENI, GameObject LNILNHLPIDB, SkinnedMeshRenderer JDDNLNGEBJK, AvatarSkinnedMeshBoneOrderRemapsData MIAGPBGLDJL, Material NFPBFEDDNLK, Material GNJHLAFPOEL, Material JHJHGOKFFLF, Shader FKJGEJDEFPD, Shader BIKBNPMJOEH, Transform NMBIOFNANNN, Transform GBPBJPLHGJG, Transform MFDFOLDONMM, Transform CIFPBKMHGKL, Transform OCNIIPHJIEA, Transform CCLDFCLHLKG, Transform LNIFCKOKKGA, Renderer[] PNJIMLFLEMD, LFGCKEHOFJB KDBGPAPDDFO, LFGCKEHOFJB AFADLNCPHHI, LFGCKEHOFJB NLLFAJJOMFB, LFGCKEHOFJB PEMJPNKPEKI, LFGCKEHOFJB DMJACJJNCOA, LFGCKEHOFJB CAOGJIKHMDN, LFGCKEHOFJB IIIBPPAPGDC, LFGCKEHOFJB OONOMLHLFDG, Transform BMCMFNEOPAD, Transform JJGKLBIAFEF, GameObject DDBPDHKGGPC, GameObject NOKJDJJEHBE, AvatarBodyPartShapesManager HDIPDMHJIKB, Transform FPLKEMBPEHH)
	{
		return default(LGINAHDHIGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68B6910", Offset = "0x68B5510", VA = "0x1868B6910")]
	public static PEPAIEEAPFC HDHHDHBINEB(string MAGEGMJLOBH, bool DLBDHANCJEB, bool GHMNEPHFCON, bool EFDKODEEJIL, Func<OFEGJJLCHOA> FFMHACIOIME, Func<Vector3, DNBDNPFFHFC> JCODLDIBLED, RigidbodyEx OBGKLMAALAK, RigidbodyEx KBHJCOAFLCF, RigidbodyEx DACIGLFGGBD, RigidbodyEx NEAPDDANJDE, Transform FHEOJDKCFEF, Transform MLGJGIOPKKC, Transform MJGCOAGLBFL, float JHLKINONJHJ, float DFPONLFAAPN, PlayerAvatarFullBodyColliders CBBPPKJOIJC, SkinnedMeshRenderer[] IGFMELICILI, SkinnedMeshRenderer[] IBCICPHHOCF, SkinnedMeshRenderer[] NIPIICCJDNI, SkinnedMeshRenderer[] EKBNFFPJGGG)
	{
		return default(PEPAIEEAPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68B70E0", Offset = "0x68B5CE0", VA = "0x1868B70E0")]
	public static FJKADEHHJBJ PDFOGHBNBNN(Transform IBPCDHOPCOA, AssetReference EIDBMJAOIPM, GameObject BNJCABHLENI, GameObject LNILNHLPIDB, SkinnedMeshRenderer JDDNLNGEBJK, AvatarSkinnedMeshBoneOrderRemapsData MIAGPBGLDJL, Material NFPBFEDDNLK, Material GNJHLAFPOEL, Material JHJHGOKFFLF, Shader MEKIIIAKPAN, Shader IKCPLBIALBD, Animator NFAGPNEOPJM, Renderer[] PNJIMLFLEMD, AvatarConfiguration ANDCKBBIEOC, AvatarBodyPartShapesManager HDIPDMHJIKB, IReadOnlyDictionary<string, Transform> AAEFOKAAOJD)
	{
		return default(FJKADEHHJBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68B67C0", Offset = "0x68B53C0", VA = "0x1868B67C0")]
	public static AENDMGEHOHH EGAPFDMEIOF(SkinnedMeshRenderer[] IGFMELICILI, SkinnedMeshRenderer[] IBCICPHHOCF, SkinnedMeshRenderer[] NIPIICCJDNI, SkinnedMeshRenderer[] EKBNFFPJGGG)
	{
		return default(AENDMGEHOHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68B6840", Offset = "0x68B5440", VA = "0x1868B6840")]
	public static BCKLOGLNNHM FCGHFCLIBPI(Transform NMBIOFNANNN, Transform MFDFOLDONMM, Transform GBPBJPLHGJG, Transform CIFPBKMHGKL, Transform OCNIIPHJIEA, Transform CCLDFCLHLKG, Transform LNIFCKOKKGA, AvatarConfiguration AAPAGCKHJDD)
	{
		return default(BCKLOGLNNHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x998E40", Offset = "0x997A40", VA = "0x180998E40")]
	public static IMEOOPLDHNE HEPLKIBFEMD(SkinnedMeshRenderer[] GOPLIBIPGFA)
	{
		return default(IMEOOPLDHNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68B6F10", Offset = "0x68B5B10", VA = "0x1868B6F10")]
	public static NCJCNOMJPHJ JEMEFHKKGPI(GACKPBEBADM BIFKNMAOLJN, int KJGNKBKACGD, int CBCIEHBHCJP, Color EKGJMKJAAFG, Color MMKMMKBDILD, int LEIEHNAEDCB, int NLOBKFAAJGG, Color JPCHGAECMOO, Color IFJPCJODELI, int MACCLEMMMKJ)
	{
		return default(NCJCNOMJPHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68B6FB0", Offset = "0x68B5BB0", VA = "0x1868B6FB0")]
	public static PICBPEHMOKB JINPIFJHBKP(GACKPBEBADM BIFKNMAOLJN, Vector2 IEGMJFAGPEC, float ANLIKEAJBDF, Vector2 HIFFDEFGNGG, float PKBKNJGNBGG, Vector2 FEBFBHDEMCO, float AHGCBECOKBP, Vector2 ACNHDDFJKKP, float HPDCLIBAOJK)
	{
		return default(PICBPEHMOKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68B6EA0", Offset = "0x68B5AA0", VA = "0x1868B6EA0")]
	public static FJOEBMLCDOJ IMEEFONBPOA(Animator IBJOKNKGBHF, KGCGGBFKMOO JNNEDGLDGFC, AvatarConfiguration ANDCKBBIEOC, GameObject LDMHLJMNEDM)
	{
		return default(FJOEBMLCDOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68B70A0", Offset = "0x68B5CA0", VA = "0x1868B70A0")]
	public static PMCNHIBKFLA MJKBKAEFLGL(Transform FANFCHGCEEC, bool GHMNEPHFCON)
	{
		return default(PMCNHIBKFLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class MJEDFBFEJLD
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68B72D0", Offset = "0x68B5ED0", VA = "0x1868B72D0")]
	public static MOHACDPOFED DPIAGLDHFDJ(this FNIEINJFJCL POAOJAEALBH)
	{
		return default(MOHACDPOFED);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68B7320", Offset = "0x68B5F20", VA = "0x1868B7320")]
	public static bool FGMGAIBMGCH(this FNIEINJFJCL MKMLILOLKCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ECFFLCDNOJM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MNHNGBGKPDG : ECFFLCDNOJM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform LHELEJKIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 GDADHHAFKJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDE88F0", Offset = "0xDE74F0", VA = "0x180DE88F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDE8970", Offset = "0xDE7570", VA = "0x180DE8970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? JMAJJJIHLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xF08110", Offset = "0xF06D10", VA = "0x180F08110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF08100", Offset = "0xF06D00", VA = "0x180F08100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public MNHNGBGKPDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PPDEDGIPHKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly MNHNGBGKPDG FPAOKEKJFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly MNHNGBGKPDG IFHPNFFBCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly MNHNGBGKPDG KPHMJLCOMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly MNHNGBGKPDG HAACHJDGMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly MNHNGBGKPDG CPCFJMLEEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly MNHNGBGKPDG DEMOPLLLAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly MNHNGBGKPDG PEJMPGKCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly MNHNGBGKPDG JJMMIFKPCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly MNHNGBGKPDG DCHJMJFPDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly MNHNGBGKPDG GIFBENHBDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly MNHNGBGKPDG OMFPNNLEPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly MNHNGBGKPDG LDDEHKKMCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly MNHNGBGKPDG KIALELJBKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected MNHNGBGKPDG DKALPLHPGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly MNHNGBGKPDG GKCCGJMNFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly MNHNGBGKPDG CDCEHJLBLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly MNHNGBGKPDG KEMCHDCDDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected MNHNGBGKPDG HCHJLEPKHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly MNHNGBGKPDG LGFFLHOCEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly MNHNGBGKPDG JPJCKJCPIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly MNHNGBGKPDG BBBEOJEDNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected ReadOnlyCollection<MNHNGBGKPDG> LGLNEDIGCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform IIHNBDFNHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private (MNHNGBGKPDG Start, MNHNGBGKPDG End)[] MEJMGMHLOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private Dictionary<string, MNHNGBGKPDG> AEPPILGJCBI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ECFFLCDNOJM ECKDAJMMONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ECFFLCDNOJM NDHMPIEPLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ECFFLCDNOJM NOCLPJDIMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ECFFLCDNOJM JCHEFJJEGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ECFFLCDNOJM KAJDIBOFBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ECFFLCDNOJM KDGHFBDPAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86A490", Offset = "0x869090", VA = "0x18086A490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ECFFLCDNOJM JIPHGOBHBIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86B550", Offset = "0x86A150", VA = "0x18086B550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ECFFLCDNOJM DOLOCOAPMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86B540", Offset = "0x86A140", VA = "0x18086B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ECFFLCDNOJM MONELGNHKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86DF40", Offset = "0x86CB40", VA = "0x18086DF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68B7550", Offset = "0x68B6150", VA = "0x1868B7550")]
	public void ACAOIGKOFGM(VRIK EPKFFDPKPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68B8A30", Offset = "0x68B7630", VA = "0x1868B8A30")]
	private void GECOILKCABC(Transform LNMFGKOJMJG, MNHNGBGKPDG EEOLDJILHGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68B8B00", Offset = "0x68B7700", VA = "0x1868B8B00")]
	public MNHNGBGKPDG KDFDPAAHLDO(string DAONFMLPOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68B8470", Offset = "0x68B7070", VA = "0x1868B8470")]
	public void BHBLBNFFPPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68B8AC0", Offset = "0x68B76C0", VA = "0x1868B8AC0")]
	public float HJGBGFDLOKF([In] (MNHNGBGKPDG Start, MNHNGBGKPDG End) MPKOAAJCJFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68B8880", Offset = "0x68B7480", VA = "0x1868B8880")]
	public void CKODAJFIOLA([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68B8B70", Offset = "0x68B7770", VA = "0x1868B8B70")]
	private Vector3 OCJBMOKIHLD([In] (MNHNGBGKPDG Start, MNHNGBGKPDG End) MPKOAAJCJFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68B8CA0", Offset = "0x68B78A0", VA = "0x1868B8CA0")]
	public PPDEDGIPHKO()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public GameObject AvatarCollidersPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68B4E10", Offset = "0x68B3A10", VA = "0x1868B4E10")]
		public string BBICJIFMGMG(string GPJCLMLEINF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68B4E60", Offset = "0x68B3A60", VA = "0x1868B4E60")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PEPAIEEAPFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public string NEIEAHFBLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public bool EBOAGJFCBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool NPKBPMJMBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float MFCAAJDMJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float LNFMCJAMBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool FAMJOPGAKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Func<OFEGJJLCHOA> MFCOEFAAFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Func<Vector3, DNBDNPFFHFC> BBLGDHNDJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public RigidbodyEx JFOKBJGPNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public RigidbodyEx GFDJMLPFLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public RigidbodyEx EJAICKOEEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public RigidbodyEx KGCAIMIIBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Transform ILFJDIDKAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Transform FDKNLJGOOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Transform CFPJDCPEPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public PlayerAvatarFullBodyColliders KFBGOABMBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public SkinnedMeshRenderer[] HNMNEIHMPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public SkinnedMeshRenderer[] IMGCFLJMIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public SkinnedMeshRenderer[] BPAPGLCNAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public SkinnedMeshRenderer[] GJKLEJEABFL;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68B73C0", Offset = "0x68B5FC0", VA = "0x1868B73C0")]
	public DNBDNPFFHFC APKPOKFLIBE(Vector3 PLEGDCLFJLN)
	{
		return default(DNBDNPFFHFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LGINAHDHIGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform ENIOOHONLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform BAHMFJBDCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public AvatarConfiguration GOEPEGMCIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Animator NDLOLPFMNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public VRIK OGALKGADCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public GameObject[] AEAMGOGCNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform JBEPPOALAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public AssetReference MNMMCDBIFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GameObject MNADICMEJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public GameObject BEOEAPJBDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public SkinnedMeshRenderer AFHHNJPOFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public AvatarSkinnedMeshBoneOrderRemapsData KIKKJGKNGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Material IOHLHBIJOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Material LAKOAOKGKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Material PHPLKMMNICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Shader MLPOFHCBBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Shader JKILBKIGFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Transform NMBNLFFFIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Transform GEIAMBEEIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Transform LINGJPPNFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Transform JFHHEBJIDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Transform KBCPBNMCANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Transform IJIMIIHMGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Transform AMFABOMFKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Renderer[] PINGEMAPEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Transform HPBBHNMNCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Transform IALEAABCKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public GameObject AAGAHBOHKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public GameObject BFJLNKOKMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public LFGCKEHOFJB GBHOIGPONOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public LFGCKEHOFJB IENNBFFFOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public LFGCKEHOFJB DOBPLHHCPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public LFGCKEHOFJB HAHPGIEEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public LFGCKEHOFJB CEDCNBIBCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public LFGCKEHOFJB CGNINOAAAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public LFGCKEHOFJB ABBEJBJJCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public LFGCKEHOFJB HFNCAFKNMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public AvatarBodyPartShapesManager FBPOAPONMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Transform OPAPDBFNCNL;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OFEGJJLCHOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool CMCOBGLCFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public IABFIAOBIIB MHEHMPMMFHD;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DNBDNPFFHFC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NHGJABCJNGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly bool HEMELGALEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly bool MHKKIILDAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly bool AKHLDMHDNKL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x68B7330", Offset = "0x68B5F30", VA = "0x1868B7330")]
		public NHGJABCJNGJ(bool JCOLMBFDIOK, bool NBFEEINMHFK, bool GAIFNCDNAGI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public float NLHGAOLBGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool FMCFJJIHNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public float NEPNHPGELNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public Vector3 IIMGIGCIEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3 EDDOEEIEBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Vector3? DJBJJOHAIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3? AFAINAPDIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool LBIMCCLLMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool BNICCJGPJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool NPLAJEFKBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool OJLFKHPLLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Vector3? MDKGMFFDFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool OOFBKGLCACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Vector3? DKDDINFILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool EEBEGBBACMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3? ICOLGIDBEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public float LMHDHBKHIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Vector3? IJEFMMBEOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool JGEPLDLCEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool EPHNGJLFFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool NFJIJGPDEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool LLOBPKNLDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool LGFHDAGHNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool IJKMNPHDJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool OCIKADOGIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool LGMFKIMOBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool CDDONCMGGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool OBDHINCMFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public bool LEIAGBNDEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public Vector3? PGHGFDBHIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public FNIEINJFJCL JDBADOANMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public FNIEINJFJCL JDLGFKNPEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public float HHPAAPEGCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float OACIMLKCFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public CJHKPNLBDLG OFPKMKHKBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public CJHKPNLBDLG AFNIJKPGKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public bool GPIGMAIGGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public NHGJABCJNGJ ECJFKPIEIKK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68B4EB0", Offset = "0x68B3AB0", VA = "0x1868B4EB0")]
	public void JBBPJCPNHIB(Quaternion GPEICHFGELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OKIIPNFFIAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68B73A0", Offset = "0x68B5FA0", VA = "0x1868B73A0")]
	public static OJAMEGDJJME KPKHBGJNNIE(this HPGPCNLFDMN ENEDBNLKLJL)
	{
		return default(OJAMEGDJJME);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68B7380", Offset = "0x68B5F80", VA = "0x1868B7380")]
	public static void GGCABPNHJOK(this HPGPCNLFDMN ENEDBNLKLJL, OJAMEGDJJME IIPLJLPCLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LFGCKEHOFJB
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float GFJHAHMFGFJ);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private MHBGEOGEBCB OMAICDLABEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private Collider[] BNCNDJEGKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] NOCELEAEOPF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> PHJDOJHPCCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x68B9BA0", Offset = "0x68B87A0", VA = "0x1868B9BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MHBGEOGEBCB COLHHEPCECM
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x68B9240", Offset = "0x68B7E40", VA = "0x1868B9240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JAHEMDONKLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA600F0", Offset = "0xA5ECF0", VA = "0x180A600F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68B9190", Offset = "0x68B7D90", VA = "0x1868B9190")]
		private void EPIDOOPCKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x68B9180", Offset = "0x68B7D80", VA = "0x1868B9180")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x68B9B80", Offset = "0x68B8780", VA = "0x1868B9B80")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer MALJFBJNFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68B99B0", Offset = "0x68B85B0", VA = "0x1868B99B0")]
		public void SetCollidersEnabled(bool NODMMGDBLME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68B9580", Offset = "0x68B8180", VA = "0x1868B9580")]
		public void ReparentBonesUnderOtherBoneCollection(MHBGEOGEBCB IDNCOAELLCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x68B92E0", Offset = "0x68B7EE0", VA = "0x1868B92E0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EDJHCDHFBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public Transform ODMHEOIOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Transform POPNMLOFBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public Transform PLHMFGPHOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public Transform DJBEELDFBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public Transform JFHLNFIEFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Transform KGLHLMGPCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Transform FKBCJJHKDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Transform JKMAKIPKJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Transform IHCOINDODMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private PositionAndRotation PPLKIKFHBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private PositionAndRotation BDDBHJCGFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private PositionAndRotation HPMEEDKIGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private PositionAndRotation BODDMBBINAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private PositionAndRotation ABCEFEMEEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private PositionAndRotation IOGPKLGGKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private PositionAndRotation NOJIPKCLPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PositionAndRotation BHADDDKNLNJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x68B6100", Offset = "0x68B4D00", VA = "0x1868B6100")]
	public void NJFEGHENHFC(Transform ONBALHPOFNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68B53A0", Offset = "0x68B3FA0", VA = "0x1868B53A0")]
	public void IAPOCLGJCCA(HandLogicOffsets DINMNPJEAFP, KGCGGBFKMOO MPMLBKLNKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68B5EB0", Offset = "0x68B4AB0", VA = "0x1868B5EB0")]
	public void KNGOAPEMGJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68B52D0", Offset = "0x68B3ED0", VA = "0x1868B52D0")]
	private PositionAndRotation HNBPALJENMK(Transform NBFNNBJJBHN, Transform BHPHEDIIGKD)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68B5BE0", Offset = "0x68B47E0", VA = "0x1868B5BE0")]
	private void KHGMDPOKAOG(Transform NBFNNBJJBHN, Transform BHPHEDIIGKD, PositionAndRotation GDPFFJNEFII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public EDJHCDHFBIO()
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
