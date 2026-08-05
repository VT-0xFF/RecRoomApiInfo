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
public enum PFIGLAALEBN
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
public enum EIGCAIACALM
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
public struct NLMOLHLIMOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator DEMCLFIHNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KLECDKNMKFN OIDKIIGMPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration DHNLNBGAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject JBFJBOEPLPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AAINLMGDNDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform EAENLCHOBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool BMPKEOELFLP;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum EIFHKBPBONM
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
public enum FIFHPLNKIIL
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
public struct ALBKENOMFOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 EEJKLAHDPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 KNPJDGBFGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 MADNMMJJPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 GPCOGGCEBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 OGDKCDOHHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 BPFLHIHNMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 LOHKHCPGJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 GIHPICJBBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 HOEFBDELIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 KALJDLOAOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 KOGDPJBGLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 HLFNCIOEJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 DBHKKJBHMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 PNHECJBJJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 OAOFODNAOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 CPCANIBDKOB;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NOMBNCMFLGD
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly string FFGIKFLOBLB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67DA940", Offset = "0x67D9B40", VA = "0x1867DA940")]
	public static BJDMADHAKMO FNHECBHDOJH()
	{
		return default(BJDMADHAKMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67DAFB0", Offset = "0x67DA1B0", VA = "0x1867DAFB0")]
	public static CPEAGFBICMO OOBAFIKCCCK(Transform BFOKBBAAOIO, Transform BLIPLFLDCHL, AvatarConfiguration PIDIACPCNEF, Animator PIKCGFHLLEM, VRIK FLEODNADBOH, GameObject[] FHHENGEAHNO, Transform GDJIJJIDKNM, AssetReference CJLEPKNFNOK, GameObject JGDIJHEBNME, GameObject LPCMKLNFIKF, SkinnedMeshRenderer IMAOPGKLCCK, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ, Material ONOKOBCCAEJ, Material EGOGFNGFLOP, Material LBEFANCMCPP, Shader NBHIFCHPIDC, Shader IPBLMNHMADO, Transform MHHGMJHNKHJ, Transform JCPOHLLFBEL, Transform CHLHEIJIGND, Transform KBPIJDAJENG, Transform LDGLDMFLLOF, Transform FLKLJHEODNH, Transform OMAKLCPEGLG, Renderer[] ONNCHJNKLDO, KKDELEBFHLA EOBOFNCFFLD, KKDELEBFHLA DOGKIBOFFEF, KKDELEBFHLA HPKPKGHPLDF, KKDELEBFHLA OCNNDHELCID, KKDELEBFHLA MCFFINMGNIP, KKDELEBFHLA APDBEGEAOHE, KKDELEBFHLA LMAPAPGPNHG, KKDELEBFHLA IOGBKCFPGGI, Transform IDFJHIJKENO, Transform NFJDJOOFKPD, GameObject KKOCOGILHOB, GameObject JMHGGFCOGPP, AvatarBodyPartShapesManager JEDNOGPKGNN, Transform NOAANFBPBKJ)
	{
		return default(CPEAGFBICMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67DAB70", Offset = "0x67D9D70", VA = "0x1867DAB70")]
	public static HIKCMCMBIFA KJDFCNKFPHA(string MLBAIKFMDFA, bool EDNPDJMLKNC, bool MPEBKEOFFJE, bool FGEDKLHCHIA, Func<OHGFLKINAAA> GAELEANKJFK, Func<Vector3, BJDMADHAKMO> MDOGAHKMOEE, RigidbodyEx DALDOEBFADL, RigidbodyEx NBMIBCLLHCJ, RigidbodyEx MNJECJCKOPP, RigidbodyEx JLNPLABAGNC, Transform OLOMBEEMNIJ, Transform LKMENBBEGGD, Transform KLNADBHPOHL, float LHFJLPHFEMK, float IHKINKAICEP, PlayerAvatarFullBodyColliders MOINAMNGOCG, SkinnedMeshRenderer[] JBHEHIHNMJN, SkinnedMeshRenderer[] IICPNBOPCNG, SkinnedMeshRenderer[] IGMIPPGDICN, SkinnedMeshRenderer[] IHDFLIFDJMP)
	{
		return default(HIKCMCMBIFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67DAD80", Offset = "0x67D9F80", VA = "0x1867DAD80")]
	public static PCLIHIGPBDC MGHJIKGFJHI(Transform BLIPLFLDCHL, AssetReference CJLEPKNFNOK, GameObject JGDIJHEBNME, GameObject LPCMKLNFIKF, SkinnedMeshRenderer IMAOPGKLCCK, AvatarSkinnedMeshBoneOrderRemapsData JDNGGLBFDLJ, Material ONOKOBCCAEJ, Material EGOGFNGFLOP, Material LBEFANCMCPP, Shader GMMLGEPCIBB, Shader HCNOMBIEHDM, Animator EPLNIMDMILO, Renderer[] ONNCHJNKLDO, AvatarConfiguration GPCJLINMPAG, AvatarBodyPartShapesManager JEDNOGPKGNN, IReadOnlyDictionary<string, Transform> ELGJIIMBIHN)
	{
		return default(PCLIHIGPBDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67DAA50", Offset = "0x67D9C50", VA = "0x1867DAA50")]
	public static JFMKJGFNJLF KFMCNAMPOBK(SkinnedMeshRenderer[] JBHEHIHNMJN, SkinnedMeshRenderer[] IICPNBOPCNG, SkinnedMeshRenderer[] IGMIPPGDICN, SkinnedMeshRenderer[] IHDFLIFDJMP)
	{
		return default(JFMKJGFNJLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67DA980", Offset = "0x67D9B80", VA = "0x1867DA980")]
	public static DNDGIEPGFML HAKCCJBPCPK(Transform MHHGMJHNKHJ, Transform CHLHEIJIGND, Transform JCPOHLLFBEL, Transform KBPIJDAJENG, Transform LDGLDMFLLOF, Transform FLKLJHEODNH, Transform OMAKLCPEGLG, AvatarConfiguration PIDIACPCNEF)
	{
		return default(DNDGIEPGFML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x970590", Offset = "0x96F790", VA = "0x180970590")]
	public static GBJONGNNFPA NCNNKDHEDJO(SkinnedMeshRenderer[] PBCCAEAGADF)
	{
		return default(GBJONGNNFPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67DAAD0", Offset = "0x67D9CD0", VA = "0x1867DAAD0")]
	public static IHEGNEEOHJB KHOJKGLICJI(GPLHFGMFLBD NHKAGFHLPBM, int AGIEOELGOAA, int OLFEHIINEPI, Color CLGEMLOAICO, Color EKCJMBLIIPE, int ABPBEEMNEED, int OCJHILOPHIP, Color JIBGLJCPDMG, Color EHMLPKFCOPI, int BKBGILFBMON)
	{
		return default(IHEGNEEOHJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67DAF00", Offset = "0x67DA100", VA = "0x1867DAF00")]
	public static DCFHDECNJAL MGLLIAMCKJE(GPLHFGMFLBD NHKAGFHLPBM, Vector2 GKJNMPNOHBH, float GFINOFNDDPF, Vector2 BABGHKAMDNI, float LPFBMEDNJLM, Vector2 JBPKKAKBAND, float KLJODHJNCGG, Vector2 LBDADGHKAEB, float AADLIOOBGGE)
	{
		return default(DCFHDECNJAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67DAD10", Offset = "0x67D9F10", VA = "0x1867DAD10")]
	public static NLMOLHLIMOI LDCIBCJEHAM(Animator BICJKDDLECO, KLECDKNMKFN CFCKDBKDEGM, AvatarConfiguration GPCJLINMPAG, GameObject MLFBFDAKDPI)
	{
		return default(NLMOLHLIMOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67DA900", Offset = "0x67D9B00", VA = "0x1867DA900")]
	public static AAINLMGDNDB EHKDGPLFECH(Transform BKJLCDNAKLI, bool MPEBKEOFFJE)
	{
		return default(AAINLMGDNDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67DA770", Offset = "0x67D9970", VA = "0x1867DA770")]
	public static PositionAndRotation CFAAMKCGJEF(Transform OHNMDEGFOLN, Transform BFOKBBAAOIO)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67DA460", Offset = "0x67D9660", VA = "0x1867DA460")]
	public static void BCDOOENHAGI(Transform OHNMDEGFOLN, Transform PMDEKFFLFLE, PositionAndRotation JPOFFJMDKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MDOLNLJEMDJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67DA3C0", Offset = "0x67D95C0", VA = "0x1867DA3C0")]
	public static PFIGLAALEBN GIOFFLJFLBK(this EIFHKBPBONM ONNCFEPKJIM)
	{
		return default(PFIGLAALEBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67DA410", Offset = "0x67D9610", VA = "0x1867DA410")]
	public static bool HODDGNAMJJE(this EIFHKBPBONM FFMLIGEHCLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FCEPGECFGPP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HBODPCDAPGO : FCEPGECFGPP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform IKKMMCBJHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8522F0", VA = "0x1808530F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 MKOKPELJCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDE65E0", Offset = "0xDE57E0", VA = "0x180DE65E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDE6570", Offset = "0xDE5770", VA = "0x180DE6570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? EBKDPCPOLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xEF0D40", Offset = "0xEEFF40", VA = "0x180EF0D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xEF0D30", Offset = "0xEEFF30", VA = "0x180EF0D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public HBODPCDAPGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GLLGCDLCBOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly HBODPCDAPGO DGEDMLKAKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly HBODPCDAPGO JMAHCJIOKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly HBODPCDAPGO INFFMNBINFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly HBODPCDAPGO APLLLGPGBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly HBODPCDAPGO HBLOLGOKIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly HBODPCDAPGO AHDAPEKJEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly HBODPCDAPGO CDGHMDJNOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly HBODPCDAPGO HBAJJJGDELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly HBODPCDAPGO JLLHCMLMMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly HBODPCDAPGO NIELBEHNABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly HBODPCDAPGO FGFIFCOHFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly HBODPCDAPGO KNCCHJGNFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly HBODPCDAPGO AMCHDHGPDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected HBODPCDAPGO AFFENFONDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly HBODPCDAPGO KODINEBCJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly HBODPCDAPGO ODABEPIBKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly HBODPCDAPGO KMIDPMHIKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected HBODPCDAPGO ANFBPMMPKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly HBODPCDAPGO HMEKPIOIOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly HBODPCDAPGO LNKIIDMKLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly HBODPCDAPGO BLFBGGJEOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected ReadOnlyCollection<HBODPCDAPGO> FEFJCEFHFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Transform GDJIJJIDKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private (HBODPCDAPGO Start, HBODPCDAPGO End)[] LCONEEFIIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private Dictionary<string, HBODPCDAPGO> LMGOALDHADG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FCEPGECFGPP NBEFHFLCAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FCEPGECFGPP BLKCGMCBKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FCEPGECFGPP MGBJFPEABPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FCEPGECFGPP OPMPDIBHNLH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855B40", VA = "0x180856940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FCEPGECFGPP APJHEMBELCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FCEPGECFGPP PGAKBHPEJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x855CB0", VA = "0x180856AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FCEPGECFGPP PHDHNLALJNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x855500", VA = "0x180856300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FCEPGECFGPP DHDLMEPACOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x856320", Offset = "0x855520", VA = "0x180856320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FCEPGECFGPP HDJLONMAJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x856BA0", Offset = "0x855DA0", VA = "0x180856BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67D8D80", Offset = "0x67D7F80", VA = "0x1867D8D80")]
	public void HGFIFALLIGO(VRIK JCEOFNBHAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67D8600", Offset = "0x67D7800", VA = "0x1867D8600")]
	private void AIAGGNMNHFJ(Transform LDPKCIGIIMG, HBODPCDAPGO CGKANMHMCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67D9CA0", Offset = "0x67D8EA0", VA = "0x1867D9CA0")]
	public HBODPCDAPGO OMOBHBICJHG(string GLMLBFNCHBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67D8840", Offset = "0x67D7A40", VA = "0x1867D8840")]
	public void FONHCJNGDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67D9D10", Offset = "0x67D8F10", VA = "0x1867D9D10")]
	public float PJFAHKNMIHE([In] (HBODPCDAPGO Start, HBODPCDAPGO End) PHOPNHKJMOD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67D8690", Offset = "0x67D7890", VA = "0x1867D8690")]
	public void EJHLDMHOGMK([In] BJDMADHAKMO DMDDBNBIFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67D8C50", Offset = "0x67D7E50", VA = "0x1867D8C50")]
	private Vector3 GFDOPDCBBFG([In] (HBODPCDAPGO Start, HBODPCDAPGO End) PHOPNHKJMOD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x67D9D50", Offset = "0x67D8F50", VA = "0x1867D9D50")]
	public GLLGCDLCBOA()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GameObject AvatarCollidersPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67D7460", Offset = "0x67D6660", VA = "0x1867D7460")]
		public string FPJDJIAODKA(string KFMBELOIJML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67D74B0", Offset = "0x67D66B0", VA = "0x1867D74B0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HIKCMCMBIFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public string NBLPDPCCPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool BMPKEOELFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool IDJGPJOMMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float AIKCDLNCCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float GGOBOMNAKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool KFMOFDEBPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Func<OHGFLKINAAA> MJDMJKOJDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Func<Vector3, BJDMADHAKMO> IEBGMDHJKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public RigidbodyEx KIPJNADADMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public RigidbodyEx OAIJJFKKBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public RigidbodyEx EEECLMFCDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public RigidbodyEx HMFEGONPNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Transform JFEOIFLMOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform BMFNNJGMMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform HCGJNAJPOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public PlayerAvatarFullBodyColliders DECMELOLDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public SkinnedMeshRenderer[] PFLDJCKMHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public SkinnedMeshRenderer[] PIOOBPJPAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public SkinnedMeshRenderer[] HILCIJCLFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public SkinnedMeshRenderer[] GHPDPIEIIMJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67DA230", Offset = "0x67D9430", VA = "0x1867DA230")]
	public BJDMADHAKMO PIGKPMKLALJ(Vector3 BMAHGGFCADD)
	{
		return default(BJDMADHAKMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CPEAGFBICMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform LACGPNBGHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform EAACIGHGCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public AvatarConfiguration DHNLNBGAPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Animator CJDPIJACEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public VRIK AGLCJMDBJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public GameObject[] OHCAFKKFKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform JGDHAMCGBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public AssetReference DEIILICLLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public GameObject PCFDNNACKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public GameObject GENGHJJGENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public SkinnedMeshRenderer IMMAIGOODMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public AvatarSkinnedMeshBoneOrderRemapsData BABHCKBPCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Material KEIIBFKJCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Material PJOGIJGCPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Material FOLCMIMPLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Shader ABOMODOLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Shader OPHHODDKJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Transform CEOIJFEDFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Transform JKJOIJJGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Transform OGOGIIIAMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Transform OOBJGHPEJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Transform ILGABFPMCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Transform PLOPPJNOKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Transform BBCNOPHGCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Renderer[] JCIIKCEFCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform FILPJJGNPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform OHBJPLFMHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public GameObject HICAIGDJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public GameObject MNGEAJPPOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public KKDELEBFHLA PFKAJJCGDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public KKDELEBFHLA GBAFKEFLGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public KKDELEBFHLA CNLKJMMDPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public KKDELEBFHLA PKILHGIICLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public KKDELEBFHLA HNADLACBGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public KKDELEBFHLA PGEJCOGEBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public KKDELEBFHLA CKAIOINDNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public KKDELEBFHLA NMOCJAJFJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public AvatarBodyPartShapesManager IHJADKDNAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Transform EIKPCEDFEGH;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OHGFLKINAAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool AMBKKJBLKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public FHBBMPGGCGD DFKEEEOMEPO;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct BJDMADHAKMO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class OMBFAPBBBKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly bool ELEMOBAGNBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly bool AFNKOFJHDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly bool GHNILFHABLE;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67DB410", Offset = "0x67DA610", VA = "0x1867DB410")]
		public OMBFAPBBBKM(bool AJGBJLFKBDM, bool LMEECPHOLBE, bool BPDFEHJCGLP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public float KNOOFIBNBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool KPDHFIBBDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public float NEDBEHMNEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3 ONMOMDGIOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3 MLCALFLBFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Vector3? KKMLPCOAKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Vector3? IGAGKCNGLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool IDIKBAGLLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool MPKCKJDNOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool MKDPOMHLJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool NHNKGMHLELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3? MIDOOGBAJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool PNHHKENNNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Vector3? CNGCBFLGOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool ANFHBEHOPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Vector3? ILJGPDNJKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public float DKMMBPBGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Vector3? AABBPABKLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool GHMPJLCHDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool EAPPLFJBBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool GLAJLIHNHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool APFDHOHLGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool HOOBDIFDMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool OBEHNMLGJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public bool EPDJIABJGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool OJOAMBKPIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public bool BGIOLEOAAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool NILFDCKEACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public bool BNKFPAIEMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Vector3? EPLFODKNHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public EIFHKBPBONM HCCBLBNOPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public EIFHKBPBONM GGNEECBIHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float DFPDPEGGDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float FDEBPKDGJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public FIFHPLNKIIL EHFHJECPPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public FIFHPLNKIIL KHNFAHKNEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public bool EACHNPOEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public OMBFAPBBBKM DNBHDIJMGEO;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67D7500", Offset = "0x67D6700", VA = "0x1867D7500")]
	public void NGEJIHOFMHK(Quaternion LCDJINCAHMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class MHGNFPOFDEA
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x67DA440", Offset = "0x67D9640", VA = "0x1867DA440")]
	public static NMIPMBEMGJG HIPLMEJALJL(this ACMLBECACMB HIKEOGPAJAF)
	{
		return default(NMIPMBEMGJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67DA420", Offset = "0x67D9620", VA = "0x1867DA420")]
	public static void AKNEBEGHKHO(this ACMLBECACMB HIKEOGPAJAF, NMIPMBEMGJG JMDCGOKJIDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KKDELEBFHLA
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float LDGBKFKPDEK);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private ICMAELEMJFC HGDGNNBOLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private Collider[] EENPOPJMFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] MKCFKGBOFIP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> PFFCFHBBOII
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x67DBEA0", Offset = "0x67DB0A0", VA = "0x1867DBEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private ICMAELEMJFC FDGLHKLEJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x67DB520", Offset = "0x67DA720", VA = "0x1867DB520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CCJGAAPCCDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA50D20", Offset = "0xA4FF20", VA = "0x180A50D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67DB470", Offset = "0x67DA670", VA = "0x1867DB470")]
		private void DOIHKJEPIKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67DB460", Offset = "0x67DA660", VA = "0x1867DB460")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x67DBE80", Offset = "0x67DB080", VA = "0x1867DBE80")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer IJGHINKJHIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67DBC90", Offset = "0x67DAE90", VA = "0x1867DBC90")]
		public void SetCollidersEnabled(bool CKPMODOEIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x67DB860", Offset = "0x67DAA60", VA = "0x1867DB860")]
		public void ReparentBonesUnderOtherBoneCollection(ICMAELEMJFC JDPCKCNBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x67DB5C0", Offset = "0x67DA7C0", VA = "0x1867DB5C0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x853480", VA = "0x180854280")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ENLMKMALAOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public Transform ECNDGJLOIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Transform JONNNICJOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Transform NBIHPMCCCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Transform MHKDMMAJOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Transform FLMFBJKLGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public Transform JMHMPPPKFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Transform OMICCHHGFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Transform NOKADOHNEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Transform FAMILDKEIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private PositionAndRotation KHLAIJMPJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private PositionAndRotation FECOLFJGBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private PositionAndRotation HCOFFABKFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PositionAndRotation PPAONHJGCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private PositionAndRotation PDDBNELPACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PositionAndRotation FOBIDONHFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private PositionAndRotation OMPJNBPOMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private PositionAndRotation GLBCNADBLPL;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67D8180", Offset = "0x67D7380", VA = "0x1867D8180")]
	public void HMCGAKKBHMB(Transform FDJKONELDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67D7920", Offset = "0x67D6B20", VA = "0x1867D7920")]
	public void HBKEDHBMEKB(HandLogicOffsets HCGMBMEFDJM, KLECDKNMKFN LNOBGMOKBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67D8390", Offset = "0x67D7590", VA = "0x1867D8390")]
	public void JAPNLNCHFND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public ENLMKMALAOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AMECJIINBGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public Transform HGBNCKBGNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform JIAPPGHKDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform FIHAFPAMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform HPGEBPKHEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Transform IAHJNEICOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private PositionAndRotation EJODACLFLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private PositionAndRotation JOIFGIKECEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private PositionAndRotation CLLNEBAHABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PositionAndRotation DPCLCPDCCOK;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67D7330", Offset = "0x67D6530", VA = "0x1867D7330")]
	public void HMCGAKKBHMB(Transform ABMBMPFLNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x67D6F70", Offset = "0x67D6170", VA = "0x1867D6F70")]
	public void BNNFNKMLOBE(HeadLogicOffsets JPOFFJMDKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67D7180", Offset = "0x67D6380", VA = "0x1867D7180")]
	public void GAOHJHJMPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public AMECJIINBGF()
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
