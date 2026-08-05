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
public enum PCHLGAICDCO
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
public enum EILAKOKDEEF
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
public struct HICNFDHGCAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator FDONNMCHDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public BMCGMHMIIJE LOIPJEEJDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration HPLFIAHPAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject GHPPEBPGGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public KPAFIKBMJHO HNNNBEDDMKD;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GJPEHIFCNFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Transform BHNGBGCPHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool ENPPCJCFHEE;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BCIEKGFGGCK
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
public enum JFNLIAEECCK
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
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OIEHFNCIHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 OALJNNGHMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 JGDKDMGPAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 LODFGILPGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 HBGMBJFGEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 CEFMGGNBLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 MAAAIJAJGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 MCABPLKJILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 JEDDKMKIOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 GGMBPLCBFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 BLGLOLNGDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 IGPFLJFDDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 GEPDCIACPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 EMBDGCFAEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 JCLAJHBIMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 HPFBJAFGJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 NHBGNELLDIC;
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
public static class DCPPKEEMDJC
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly string BDFMPBEKNDN;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A140", Offset = "0x6A78B40", VA = "0x186A7A140")]
	public static LIIDFOAKDJP INJOOJLLMKA()
	{
		return default(LIIDFOAKDJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A79510", Offset = "0x6A77F10", VA = "0x186A79510")]
	public static KDMJBOGGEPA ACLGLAAMAPF(KPAFIKBMJHO CEJNFGHJJOB, Transform PAJBIGFDMMI, Transform AIAMFFLLOBJ, AvatarConfiguration GKOIFCHMJKH, Animator ECHEILANBLL, VRIK KOJLIKFIAMM, GameObject[] OFMPENCDJBC, Transform IFNKMCPKOFG, AssetReference BKNBPMNPGHE, GameObject APHPDKDEDNO, GameObject KEJKJDENIIA, SkinnedMeshRenderer CEEFBBFFEAI, AvatarSkinnedMeshBoneOrderRemapsData DNAFOCBMOHD, Material BJCGHHGDOPK, Material INBJFNLIDKP, Material IGKNHOGNGPG, Shader AIOKHPBGPBI, Shader MFPJEMOHONI, Transform CFPMHCIKHEJ, Transform APDCDFLGAAJ, Transform EAMFNCCBGMD, Transform IGPOPIBMFMO, Transform BAFDOPMEBNO, Transform MAGEFAKHFKH, Transform HBCAKBLIFDI, Renderer[] PDDPNCNBKNJ, IFKIABHOMBF CBMCHFOMPIB, IFKIABHOMBF PLBNGOGDDHP, IFKIABHOMBF NJCMOADHHJF, IFKIABHOMBF NEGOBNINPOL, IFKIABHOMBF LAOEAKEPEIH, IFKIABHOMBF ANPIBNFCKEN, IFKIABHOMBF CAKIOOAMMGP, IFKIABHOMBF FLKEMBPJNBM, Transform JGCKCCBHCII, Transform JMEPFAJODFI, Transform JPLNLJEJBFE, Transform CIFCELGPPDL, GameObject NKBHBBBFMEM, GameObject AEMLPNFBMPD, AvatarBodyPartShapesManager ALGOGFKLPEF, Transform LLNKNCEIPPN, Transform ANJOCAJNIEJ, Transform GFNOEKMMCNE, Transform ANEKLILAIFM, Transform GNJMAJMBNNJ)
	{
		return default(KDMJBOGGEPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A79DE0", Offset = "0x6A787E0", VA = "0x186A79DE0")]
	public static MKJGAODFAGO IKMMADMCBJP(string EDANJGHIGGA, bool GJGMEGEKDAH, bool BFKEPJLMOJN, GBDEJNPIPIE AEELAMEGCNB, Func<KJANIDNFMPP> JCOCOJDNEAF, Func<Vector3, LIIDFOAKDJP> GEPAGDEHGEB, RigidbodyEx OFNKECFBLBK, RigidbodyEx JFMKHFDHOMA, RigidbodyEx EIPGEPLOHCB, RigidbodyEx LEOMJGJLCDM, Transform LCNPBJHLELI, Transform EDOBNKIMLOD, Transform HOFAIAEKGGH, Transform AGOPHOPKHBA, float DNJPMIGGCEP, float BMJPNKGKAAH, PlayerAvatarModernBodyColliders ALEBLOABAJO, SkinnedMeshRenderer[] MLHLPAOONMH, SkinnedMeshRenderer[] NMJGKNOIKIB, SkinnedMeshRenderer[] IJIGPEGJMAJ, SkinnedMeshRenderer[] JNCDJJBMIGJ)
	{
		return default(MKJGAODFAGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A79BB0", Offset = "0x6A785B0", VA = "0x186A79BB0")]
	public static BNGLNOLJEED GDPMMKIKOKP(Transform AIAMFFLLOBJ, AssetReference BKNBPMNPGHE, GameObject APHPDKDEDNO, GameObject KEJKJDENIIA, SkinnedMeshRenderer CEEFBBFFEAI, AvatarSkinnedMeshBoneOrderRemapsData DNAFOCBMOHD, Material BJCGHHGDOPK, Material INBJFNLIDKP, Material IGKNHOGNGPG, Shader PFJGCENGGIO, Shader GLFHLGJCLAF, Animator NDBBKHDIODJ, Renderer[] PDDPNCNBKNJ, AvatarConfiguration MAJDHPGOBHN, AvatarBodyPartShapesManager ALGOGFKLPEF, IReadOnlyDictionary<string, Transform> EBEPJGIBODB)
	{
		return default(BNGLNOLJEED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A79A50", Offset = "0x6A78450", VA = "0x186A79A50")]
	public static GBNJAHHGEHF CMKLBFDFGJM(SkinnedMeshRenderer[] MLHLPAOONMH, SkinnedMeshRenderer[] NMJGKNOIKIB, SkinnedMeshRenderer[] IJIGPEGJMAJ, SkinnedMeshRenderer[] JNCDJJBMIGJ)
	{
		return default(GBNJAHHGEHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A79AD0", Offset = "0x6A784D0", VA = "0x186A79AD0")]
	public static GOGHNMGGMND DIAFMJDMJCC(Transform CFPMHCIKHEJ, Transform EAMFNCCBGMD, Transform APDCDFLGAAJ, Transform IGPOPIBMFMO, Transform BAFDOPMEBNO, Transform MAGEFAKHFKH, Transform HBCAKBLIFDI, AvatarConfiguration GKOIFCHMJKH, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(GOGHNMGGMND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xBB9300", Offset = "0xBB7D00", VA = "0x180BB9300")]
	public static ONAHENLDIGE DKHGBFFDCBN(SkinnedMeshRenderer[] BDAMLHHJBLA)
	{
		return default(ONAHENLDIGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A799B0", Offset = "0x6A783B0", VA = "0x186A799B0")]
	public static OFGOGHGHFLP AHMHOJLAIAG(DLDNONNNGBI COJEGIAANOC, int BNDCKPFNCIN, int GCCFIKDLIFJ, Color BJHDBAJEPIP, Color AKBIGPPCHEL, int PEOBJOMJJOL, int BKHPFKNLMGA, Color OBLMKOGCAPK, Color DPDHMIOKPCN, int DFJNJBLLFPG)
	{
		return default(OFGOGHGHFLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A79D30", Offset = "0x6A78730", VA = "0x186A79D30")]
	public static PIOIGEACCKI IDBBCAAGDKB(DLDNONNNGBI COJEGIAANOC, Vector2 IHMCFMMGCOH, float DCNDPDBJOHL, Vector2 EEHHNLCMBPO, float GCJOBFIOGKD, Vector2 PDOBKPNOFII, float NIDJGMDIPFE, Vector2 OINDODJEOPO, float AADFNAECFFE)
	{
		return default(PIOIGEACCKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A4E0", Offset = "0x6A78EE0", VA = "0x186A7A4E0")]
	public static HICNFDHGCAO MBGNJNDCKHG(Animator GMOCOJEEIJB, BMCGMHMIIJE GIABCELMOIA, AvatarConfiguration MAJDHPGOBHN, GameObject IIEPGMJHFFA, KPAFIKBMJHO CEJNFGHJJOB)
	{
		return default(HICNFDHGCAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A4A0", Offset = "0x6A78EA0", VA = "0x186A7A4A0")]
	public static GJPEHIFCNFC LICGHPNIHJH(Transform LGFDKJAOAPG, bool BFKEPJLMOJN)
	{
		return default(GJPEHIFCNFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A79FB0", Offset = "0x6A789B0", VA = "0x186A79FB0")]
	public static PositionAndRotation IMBENPKELDK(Transform ILDIFIEKECO, Transform PAJBIGFDMMI)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A190", Offset = "0x6A78B90", VA = "0x186A7A190")]
	public static void JHEDBNMGEHD(Transform ILDIFIEKECO, Transform JDEEBLNAMMO, PositionAndRotation HBHIEACHGEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LBGDNDGNPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CAE0", Offset = "0x6A7B4E0", VA = "0x186A7CAE0")]
	public static PCHLGAICDCO OCGEBPOBKFH(this BCIEKGFGGCK LFEJAJIGKEI)
	{
		return default(PCHLGAICDCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CAD0", Offset = "0x6A7B4D0", VA = "0x186A7CAD0")]
	public static bool KNDGMOBPOHO(this BCIEKGFGGCK PALOAFBHJKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface APJLGFDLFBG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HIKMEAJPICK : APJLGFDLFBG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform LFKJKOHKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 KLNKOLCOJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x101F9B0", Offset = "0x101E3B0", VA = "0x18101F9B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x101FA60", Offset = "0x101E460", VA = "0x18101FA60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? MEHDBKCGGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1163860", Offset = "0x1162260", VA = "0x181163860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1163870", Offset = "0x1162270", VA = "0x181163870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public HIKMEAJPICK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EJDBMMGGFDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly HIKMEAJPICK IIDDOGJMICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly HIKMEAJPICK NFIACOGONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly HIKMEAJPICK NEJILBJAIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly HIKMEAJPICK LBAJEDEMEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly HIKMEAJPICK LCJLHNFLCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly HIKMEAJPICK JNIPPDNJBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly HIKMEAJPICK LMAKAPDLFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly HIKMEAJPICK LKNMOGHKDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly HIKMEAJPICK PFPBIJJCEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly HIKMEAJPICK MPNALFKAOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly HIKMEAJPICK GPFOHCMLBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly HIKMEAJPICK ACDEICLJJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly HIKMEAJPICK JAOFCEOBEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected HIKMEAJPICK JIECBCGFCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly HIKMEAJPICK PBEIJOLJABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly HIKMEAJPICK LJMFBIEBBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly HIKMEAJPICK BHJBAEKJAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected HIKMEAJPICK PDNHMDCCJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly HIKMEAJPICK CBFPAMGNKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly HIKMEAJPICK HADOHGFCNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly HIKMEAJPICK IKLLIJOFAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected ReadOnlyCollection<HIKMEAJPICK> FPAPGLONLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Transform IFNKMCPKOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private (HIKMEAJPICK Start, HIKMEAJPICK End)[] NLCJFCPIKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Dictionary<string, HIKMEAJPICK> BMBHFGHMJOF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public APJLGFDLFBG CACCKKOIJED
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public APJLGFDLFBG MGENJIOOKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public APJLGFDLFBG KIDCJFKJNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public APJLGFDLFBG HCNFGHHIEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public APJLGFDLFBG PGOEPOFEANI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public APJLGFDLFBG HFKIIFFNGKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public APJLGFDLFBG AGILIJKCJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88B2B0", Offset = "0x889CB0", VA = "0x18088B2B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public APJLGFDLFBG HDCEHLBOMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88C420", Offset = "0x88AE20", VA = "0x18088C420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public APJLGFDLFBG IHINLDMAHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88B1C0", Offset = "0x889BC0", VA = "0x18088B1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AD90", Offset = "0x6A79790", VA = "0x186A7AD90")]
	public void LDBFHDDFKCM(VRIK MFBAJMKLLON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A890", Offset = "0x6A79290", VA = "0x186A7A890")]
	private void DFNJAPPHGPD(Transform FCLIEHCKPJG, HIKMEAJPICK CDHECNAFHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A7AD20", Offset = "0x6A79720", VA = "0x186A7AD20")]
	public HIKMEAJPICK IOOMHAAIILO(string KKGJMHJKAPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A920", Offset = "0x6A79320", VA = "0x186A7A920")]
	public void HOBHPDLBJDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BC70", Offset = "0x6A7A670", VA = "0x186A7BC70")]
	public float MAJCCECBONG([In] (HIKMEAJPICK Start, HIKMEAJPICK End) MCDFMOHNDOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A6F0", Offset = "0x6A790F0", VA = "0x186A7A6F0")]
	public void CKEGMCBMHCN([In] LIIDFOAKDJP PFFGBBPKGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A7A5C0", Offset = "0x6A78FC0", VA = "0x186A7A5C0")]
	private Vector3 BJOOLMOHJJG([In] (HIKMEAJPICK Start, HIKMEAJPICK End) MCDFMOHNDOC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A7BCB0", Offset = "0x6A7A6B0", VA = "0x186A7BCB0")]
	public EJDBMMGGFDF()
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
		[Cpp2IlInjected.Address(RVA = "0x6A79470", Offset = "0x6A77E70", VA = "0x186A79470")]
		public string IPOBEOKCHEO(string OIILKBCNAKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A794C0", Offset = "0x6A77EC0", VA = "0x186A794C0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GBDEJNPIPIE
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
public struct MKJGAODFAGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string CADCFOACPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool ENPPCJCFHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool HLKAPNNFNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float KBKAPHNHNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float HHBAIEKLKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public GBDEJNPIPIE JOJLJKPHKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Func<KJANIDNFMPP> OIBLDLNBHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Func<Vector3, LIIDFOAKDJP> KMEEHNKDICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public RigidbodyEx LKHPJCHLPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public RigidbodyEx MNPAIJPPNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public RigidbodyEx DABOAILBEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public RigidbodyEx AIOHLMNNAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform EFPDAOOEOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform ELPFGDOKNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform PGLKEBIKOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform MHEBMPHIFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
	public PlayerAvatarModernBodyColliders ALEBLOABAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public SkinnedMeshRenderer[] IBIFEAGMKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public SkinnedMeshRenderer[] AFANDIKAFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public SkinnedMeshRenderer[] FCFDOLGNPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public SkinnedMeshRenderer[] KPMAAMLDHPI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool KOMFLABMBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68EAC30", Offset = "0x68E9630", VA = "0x1868EAC30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KHKNPNJPAGI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68EAC60", Offset = "0x68E9660", VA = "0x1868EAC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D410", Offset = "0x6A7BE10", VA = "0x186A7D410")]
	public LIIDFOAKDJP ACFKHCJIEJF(Vector3 KIMDIHPGCJJ)
	{
		return default(LIIDFOAKDJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct KDMJBOGGEPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public KPAFIKBMJHO HNNNBEDDMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform FKLAFGFHMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform JGPACCBJPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public AvatarConfiguration HPLFIAHPAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Animator BHIDBJMDKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public VRIK GKLEDENMDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public GameObject[] CLMFDHLIFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Transform AEBKCODLMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public AssetReference PMOAAOAPNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public GameObject AIHIKFKEOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject JJOKONCDDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public SkinnedMeshRenderer HPFBCMNFIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public AvatarSkinnedMeshBoneOrderRemapsData MAPNBEJMPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Material JGBCFKOHMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Material CCDEHAEFJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Material EKEDLNOGLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Shader ILFGCKPCAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Shader DAKHFFOMKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform GFPAPDFPHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform GAMJODPIKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform PEMMBPGELOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Transform HBLBLNPCANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Transform JDCDJIKDFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Transform NLIKHJHLOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Transform NMNABMFKOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Renderer[] EHKMIJNEMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Transform IDKIGLHHNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Transform DPPCICCIICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public GameObject EAAGKIPFCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public GameObject NNFFLNBLEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Transform CGNNDIGKNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Transform PCMJFGLABMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Transform JKPPGMBPANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public IFKIABHOMBF HLDFJJDBOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public IFKIABHOMBF KGPKHHGFMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public IFKIABHOMBF LAIPGADBMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public IFKIABHOMBF AMCKLINAKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public IFKIABHOMBF JAFNFPENFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public IFKIABHOMBF IHNDPIHMAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public IFKIABHOMBF CGLDOODGOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public IFKIABHOMBF IPMDMLLLDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public AvatarBodyPartShapesManager CMPJMPBFKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform KNLGCKCJNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform PEBBLCGIEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform LGOKNNEMPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Transform EAHKJPLDHCJ;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KJANIDNFMPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool CBDDEPDFAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public HDLBMLPIHPN PMJOIHDLFKB;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct LIIDFOAKDJP
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class NGKFHGDFHLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly bool IMJHNCIPFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly bool GKCNAEOHOIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly bool KDMCAHGAPPI;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D5E0", Offset = "0x6A7BFE0", VA = "0x186A7D5E0")]
		public NGKFHGDFHLG(bool NMMFILBDKCL, bool LKBCDOHPECP, bool BBIOHMDMGDP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float ENNFMIEAMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool IJLINPJNBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float EHADJCEMDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3 FKONIGNEOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Vector3 HMLOGCKGJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3? BEBJEFPNJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3? KPBJLEOFHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool DPDKHOBFPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool FDBDDEGOJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool FAPCFEBABJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool ODBLBADHCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Vector3? LBDNIBIFKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool DIBMJDGKFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public Vector3? JNHMLBABMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool DEBALIMDDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Vector3? BEHFDOELIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float KCMOLPKOPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Vector3? GJBAMEEILKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool NIPFMFOCMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public bool GCGANCJFEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public bool FHJHICHJAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool GEJMEJKJLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public bool MHIJBBOKOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public bool IFIGPEEFEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public bool HHKLAOGMECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public bool AFCEHNKPGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public bool PKHGCGBMGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public bool NBMIKLIGKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public bool AFIGNPAMJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Vector3? ODHELEJJCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public BCIEKGFGGCK ECFLOJIHNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public BCIEKGFGGCK LKDKCKBMKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float OPOHKMJILDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public float BBCFONLOBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public JFNLIAEECCK PGIBFPFPNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public JFNLIAEECCK MNGKANNIFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public bool LNJJAKHLEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public bool AFABFBJBEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public bool AMPNBBEPEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public NGKFHGDFHLG JCNBKKLOEIN;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CB30", Offset = "0x6A7B530", VA = "0x186A7CB30")]
	public void BJCJFIDGFFE(Quaternion PCIAHIPKDFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NEKDALBGOBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D5A0", Offset = "0x6A7BFA0", VA = "0x186A7D5A0")]
	public static BDAPCPEBHHJ ABCKHFAMJOK(this KHAHGFBEPPJ NKCEKILMAAM)
	{
		return default(BDAPCPEBHHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D5C0", Offset = "0x6A7BFC0", VA = "0x186A7D5C0")]
	public static void JIEPPNOPFPD(this KHAHGFBEPPJ NKCEKILMAAM, BDAPCPEBHHJ IPHMAHBENGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface IFKIABHOMBF
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float CPLJOMEDMHK);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class PlayerAvatarModernBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum KJKAKHJKFMB
		{
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			EnabledForFullBody,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			EnabledForModernBeanBody
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private GIHLAEGKLGC GCKMNHBHBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private List<Collider> NLDAMMDCAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private List<Collider> HEFDOKCAICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private List<Collider> DCBPEDBHBME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private KJKAKHJKFMB? JCECEHGMEOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeField]
		private Collider[] FullBodyOnlyColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] AGBPLMKCBFP;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<Collider> IAIJGLADIPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6A7E4F0", Offset = "0x6A7CEF0", VA = "0x186A7E4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyList<Collider> MHCGGJOIDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6A7E510", Offset = "0x6A7CF10", VA = "0x186A7E510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> GEOGNOKDDLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6A7E530", Offset = "0x6A7CF30", VA = "0x186A7E530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private GIHLAEGKLGC JGNMABCLNBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6A7D630", Offset = "0x6A7C030", VA = "0x186A7D630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JGIDHBMEGPM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9752A0", Offset = "0x973CA0", VA = "0x1809752A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D700", Offset = "0x6A7C100", VA = "0x186A7D700")]
		private void DMHDCIDCBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D6D0", Offset = "0x6A7C0D0", VA = "0x186A7D6D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E4D0", Offset = "0x6A7CED0", VA = "0x186A7E4D0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer BGGDLLKPBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6A7E130", Offset = "0x6A7CB30", VA = "0x186A7E130")]
		public void SetCollidersEnabled(KJKAKHJKFMB PFFGBBPKGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A7DCA0", Offset = "0x6A7C6A0", VA = "0x186A7DCA0")]
		public void ReparentBonesUnderOtherBoneCollection(GIHLAEGKLGC IODAGOPJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A7D9D0", Offset = "0x6A7C3D0", VA = "0x186A7D9D0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		public PlayerAvatarModernBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class KPKMFADHOKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform KMPMDJMMBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Transform JHHLHOONHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Transform GFONLILGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Transform NMHALBJMJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Transform MAJDGNACDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform OBMIGKJIJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Transform OAICIMNNDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform IACKLADPINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Transform OIGNPPNLBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private PositionAndRotation JKBHCBHCPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private PositionAndRotation NEAEAKLJJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private PositionAndRotation PMKEANOJLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PositionAndRotation KECJMPOCIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PositionAndRotation LOIFGDJHNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private PositionAndRotation FJPJCIEEOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PositionAndRotation HHGBGJKLKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PositionAndRotation CGOCCKADBIC;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C3E0", Offset = "0x6A7ADE0", VA = "0x186A7C3E0")]
	public void HINDDHMAHAN(Transform MLMHFCNEFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C5F0", Offset = "0x6A7AFF0", VA = "0x186A7C5F0")]
	public void PDPCDFNHGMI(HandLogicOffsets OBODBBLDNMJ, BMCGMHMIIJE IPFDBPLMHNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6A7C190", Offset = "0x6A7AB90", VA = "0x186A7C190")]
	public void HBMJHIAPONA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public KPKMFADHOKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MEFAHOGNHIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Transform LNOMAEJFMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform IGMBNPOKDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Transform MJFJMPLNEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform HDPCMPDLGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Transform LCGGLBNINLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private PositionAndRotation NCDOBOHIGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private PositionAndRotation APOHKAMFGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private PositionAndRotation FNICLKKHIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private PositionAndRotation BILIFPLPKOM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D2E0", Offset = "0x6A7BCE0", VA = "0x186A7D2E0")]
	public void HINDDHMAHAN(Transform MKPFEJEDIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A7D0E0", Offset = "0x6A7BAE0", VA = "0x186A7D0E0")]
	public void HFBEELPHIMF(HeadLogicOffsets HBHIEACHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A7CF50", Offset = "0x6A7B950", VA = "0x186A7CF50")]
	public void EAHFJADDEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public MEFAHOGNHIG()
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
