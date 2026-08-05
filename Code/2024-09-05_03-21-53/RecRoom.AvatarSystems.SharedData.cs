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
public enum DMCEDLDHENL
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
public enum KHNKMFKBAMO
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
public struct NPIOCLAEKFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator GDJFAOFNDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public HGPIBOIJKAI ILCLCPIJFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration DKLBDJOEBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject LJNFMGJOJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public LJIAAKKJMFC EAKPPFDKGHF;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MOJHHEKAHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Transform BNMODMBBHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool HOLDHNBMAEO;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DDCDBMMKLME
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
public enum IBPCPGIHICI
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
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct FEADBNHGDIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 JKCFECLFKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 HNFGGBKOOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 CLGCLIEFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 JJCHHJOFFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 BOCODBIPBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 GEJBJAEHGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 GECKCCHKJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 EFMACBLAGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 NOBOEBHGKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 KLBODBBDGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 OMJEPKPCHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 BILKBEOOOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 CCICDBDLKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 CPJGFBACKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 NDBNFJIDBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 JDFINCHIJOD;
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
public static class PAHCHOGJFLI
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly string HNFFNJDGKMP;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F1F0", Offset = "0x6A8DBF0", VA = "0x186A8F1F0")]
	public static FCMNGFAPMAI EJECMGEBGJK()
	{
		return default(FCMNGFAPMAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FA50", Offset = "0x6A8E450", VA = "0x186A8FA50")]
	public static HAALKJBIFLL NGEAMJDKIIE(LJIAAKKJMFC OGHNIOCONDA, Transform KLBJBBMLEPC, Transform LJPJNEKBBKI, AvatarConfiguration ALLBDHOEBLP, Animator ACAGPAOPAPI, VRIK LCDOIIJFGGM, GameObject[] BJKMDFFHDBP, Transform MJGBJDKMFCM, AssetReference DMONBKPGDHO, GameObject FOAPLBLNGKN, GameObject DIJELNDFLDB, SkinnedMeshRenderer FEJEADMNKBH, AvatarSkinnedMeshBoneOrderRemapsData IIAPJLDPMCL, Material DDDKLGPAHCH, Material GGIIKACHCGB, Material IIIBJPFAIGH, Shader HFEGKCJNCEN, Shader KHDGMHALFLH, Transform LKPOINELDCH, Transform KIOIIGJBLHK, Transform GNMHOHAFPIM, Transform MCOEOABBDBG, Transform DGEIGEAMFEF, Transform BIJIHLEBICE, Transform IFNAHCNIJHP, Renderer[] BJAHLNKEBFN, KDEMKMMCFEE GMMFPJJHFGI, KDEMKMMCFEE AMENNKNCINB, KDEMKMMCFEE OICMIBOFKNB, KDEMKMMCFEE MPKPJIHDEII, KDEMKMMCFEE ALJEDFHEMCI, KDEMKMMCFEE GICKAGLMGBO, KDEMKMMCFEE FIDGNFAMJED, KDEMKMMCFEE IICGICNLMIL, Transform DAIAKPCCJPK, Transform CMHKIHIOBLD, Transform PILNDOINKIF, Transform ILHKCFPKADN, GameObject OACIAIKPNGA, GameObject BJLFAJIPIMA, AvatarBodyPartShapesManager LCELBDIHNEG, Transform NHAMDKNCEEG, Transform FIIJIHNJHJL, Transform GEHGNGPIEOI, Transform CCCEOBMIFFH, Transform PHFCAKEIBFA)
	{
		return default(HAALKJBIFLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F240", Offset = "0x6A8DC40", VA = "0x186A8F240")]
	public static MIODDBCPMAL FLAAKJDKBHB(string JOAGOINDGPK, bool CMHCNHBIHNO, bool EPBIBMMCGEL, GNFHDMEJPIN BNNAIAGKKOM, Func<DFKFFDGMMBA> HLGIFOKLNBO, Func<Vector3, FCMNGFAPMAI> GIEFAMIKOGM, RigidbodyEx HBJDLAKPEIF, RigidbodyEx AKHMNIDLJHE, RigidbodyEx EPCGNGOKIHF, RigidbodyEx BHEPFFGDGNH, Transform POGHMDIPGII, Transform GMLFANBPCHF, Transform OGGLKFKOIOH, Transform DDJCFIPLBGJ, float IIPNGEBFDHN, float MLKMMJJALHO, PlayerAvatarModernBodyColliders GLJIENHDFOB, SkinnedMeshRenderer[] ODELGEOCFNI, SkinnedMeshRenderer[] FGEIFPJIGAG, SkinnedMeshRenderer[] LOKKHAJOKDP, SkinnedMeshRenderer[] FDFHENHDLNL)
	{
		return default(MIODDBCPMAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F410", Offset = "0x6A8DE10", VA = "0x186A8F410")]
	public static PJKBFLPLDHF IBHGDBNPMKB(Transform LJPJNEKBBKI, AssetReference DMONBKPGDHO, GameObject FOAPLBLNGKN, GameObject DIJELNDFLDB, SkinnedMeshRenderer FEJEADMNKBH, AvatarSkinnedMeshBoneOrderRemapsData IIAPJLDPMCL, Material DDDKLGPAHCH, Material GGIIKACHCGB, Material IIIBJPFAIGH, Shader FHBLGOCEOKC, Shader LDGPJINEOFI, Animator BMPLOIMIDIG, Renderer[] BJAHLNKEBFN, AvatarConfiguration IICOAALEPOB, AvatarBodyPartShapesManager LCELBDIHNEG, IReadOnlyDictionary<string, Transform> FHGJCPADPPJ)
	{
		return default(PJKBFLPLDHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F6C0", Offset = "0x6A8E0C0", VA = "0x186A8F6C0")]
	public static LNACEOHGPFJ LJCAIHINPHF(SkinnedMeshRenderer[] ODELGEOCFNI, SkinnedMeshRenderer[] FGEIFPJIGAG, SkinnedMeshRenderer[] LOKKHAJOKDP, SkinnedMeshRenderer[] FDFHENHDLNL)
	{
		return default(LNACEOHGPFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F070", Offset = "0x6A8DA70", VA = "0x186A8F070")]
	public static GHOCBHEIOKH AEJEDALCEOP(Transform LKPOINELDCH, Transform GNMHOHAFPIM, Transform KIOIIGJBLHK, Transform MCOEOABBDBG, Transform DGEIGEAMFEF, Transform BIJIHLEBICE, Transform IFNAHCNIJHP, AvatarConfiguration ALLBDHOEBLP, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(GHOCBHEIOKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xB28530", Offset = "0xB26F30", VA = "0x180B28530")]
	public static BONECKELFCI HLMGIIIPNLO(SkinnedMeshRenderer[] FDBMCCFOAJJ)
	{
		return default(BONECKELFCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F150", Offset = "0x6A8DB50", VA = "0x186A8F150")]
	public static COGHAJMGFJB DBJGOEHFGNI(JDECACOCKCL FCGEKJNFMDP, int MHGGELGMJMF, int FLMCBLOLJLJ, Color BOPGCOLLHKM, Color APAJAJFGLEF, int GEFFLMFIEHH, int KGICHLLOHNN, Color EDFGOAODIGP, Color ABFAIDNKDOP, int ICHALMHGIMH)
	{
		return default(COGHAJMGFJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F590", Offset = "0x6A8DF90", VA = "0x186A8F590")]
	public static DPGDAOADILK IELAPKEOAKF(JDECACOCKCL FCGEKJNFMDP, Vector2 MNIKBMDLLNF, float JJPIMPILBOC, Vector2 JJLLFHDCFBE, float FHGBPAGAADF, Vector2 KJNIBPIBKPN, float ELJLPNPEBBI, Vector2 HNFHPAAIIBK, float BCODGLEHNMN)
	{
		return default(DPGDAOADILK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F640", Offset = "0x6A8E040", VA = "0x186A8F640")]
	public static NPIOCLAEKFF LJBDAKMIEOM(Animator KNMGJLDIANF, HGPIBOIJKAI MIKKPAIAHFJ, AvatarConfiguration IICOAALEPOB, GameObject LFIFJOEELHD, LJIAAKKJMFC OGHNIOCONDA)
	{
		return default(NPIOCLAEKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F030", Offset = "0x6A8DA30", VA = "0x186A8F030")]
	public static MOJHHEKAHMF AAFOLNINKCE(Transform NJHFMHPELGO, bool EPBIBMMCGEL)
	{
		return default(MOJHHEKAHMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8FEF0", Offset = "0x6A8E8F0", VA = "0x186A8FEF0")]
	public static PositionAndRotation NIFGPAHALGM(Transform DLKHALDNBAC, Transform KLBJBBMLEPC)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A8F740", Offset = "0x6A8E140", VA = "0x186A8F740")]
	public static void LLNEFCKJBAN(Transform DLKHALDNBAC, Transform DBEDLNPOLCO, PositionAndRotation CJBLCCKMCKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class APJHPDAFBLI
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DAC0", Offset = "0x6A8C4C0", VA = "0x186A8DAC0")]
	public static DMCEDLDHENL BADLEIDFIEK(this DDCDBMMKLME GNODDFLPNLI)
	{
		return default(DMCEDLDHENL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DB10", Offset = "0x6A8C510", VA = "0x186A8DB10")]
	public static bool JEGPEEOFMIO(this DDCDBMMKLME HODAIGBFNHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HFNAGABCGMO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KGMHPODJLDH : HFNAGABCGMO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform DHHBNJAMIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x882790", Offset = "0x881190", VA = "0x180882790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 DKEMIMKGLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xF6A880", Offset = "0xF69280", VA = "0x180F6A880", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xF6A7A0", Offset = "0xF691A0", VA = "0x180F6A7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? GDILGPKFDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1097810", Offset = "0x1096210", VA = "0x181097810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1097820", Offset = "0x1096220", VA = "0x181097820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public KGMHPODJLDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PNBAKDFDPBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly KGMHPODJLDH BAFAPNNNCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly KGMHPODJLDH BKCBPKIJIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly KGMHPODJLDH PAAKFCLMLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly KGMHPODJLDH LGFBKDNEKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly KGMHPODJLDH FJHPKPNMCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly KGMHPODJLDH JNDNAFJJKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly KGMHPODJLDH KNOGAOOAHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly KGMHPODJLDH BLIOKACCIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly KGMHPODJLDH NFBMEFCCNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly KGMHPODJLDH DDKKKDNMMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly KGMHPODJLDH ONAMDCBIKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly KGMHPODJLDH CEPLEONHHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly KGMHPODJLDH KAGPPEGHLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected KGMHPODJLDH PCKFCMHBEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly KGMHPODJLDH NJDHPOOLACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly KGMHPODJLDH NMCKNOHDHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly KGMHPODJLDH GEHKANMIAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected KGMHPODJLDH PHFGPCMEDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly KGMHPODJLDH AHJEFNAMLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly KGMHPODJLDH PCLDNMHFEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly KGMHPODJLDH NGKFILNBCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected ReadOnlyCollection<KGMHPODJLDH> MBMMKELFLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Transform MJGBJDKMFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private (KGMHPODJLDH Start, KGMHPODJLDH End)[] GGOMFMAMCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Dictionary<string, KGMHPODJLDH> GKHEBJDPOEO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HFNAGABCGMO KDJLIFHJEKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HFNAGABCGMO NCNJACGPDPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HFNAGABCGMO DEIAFKMADGL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HFNAGABCGMO POHKMIBBPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HFNAGABCGMO DDCJLOGJLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HFNAGABCGMO BDFKMAFAMOL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HFNAGABCGMO BJACPKEPLCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x885FC0", Offset = "0x8849C0", VA = "0x180885FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HFNAGABCGMO PALBHOMHCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x885FE0", Offset = "0x8849E0", VA = "0x180885FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HFNAGABCGMO GDICHMLKIGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88E810", Offset = "0x88D210", VA = "0x18088E810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A90620", Offset = "0x6A8F020", VA = "0x186A90620")]
	public void KMIGMHCCJAF(VRIK ILBHHJKACFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A904E0", Offset = "0x6A8EEE0", VA = "0x186A904E0")]
	private void GBENAPGHLNJ(Transform NHGOKBHHHPE, KGMHPODJLDH IPOCAIFIKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A90570", Offset = "0x6A8EF70", VA = "0x186A90570")]
	public KGMHPODJLDH HEFMGLDOAGD(string FLGKLJDBOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A900E0", Offset = "0x6A8EAE0", VA = "0x186A900E0")]
	public void AOPNLFDMHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A905E0", Offset = "0x6A8EFE0", VA = "0x186A905E0")]
	public float KKCDCKBKGGP([In] (KGMHPODJLDH Start, KGMHPODJLDH End) FMCHAOIGDKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A91670", Offset = "0x6A90070", VA = "0x186A91670")]
	public void OCIJCNLIENM([In] FCMNGFAPMAI ACEEMNFHFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A91540", Offset = "0x6A8FF40", VA = "0x186A91540")]
	private Vector3 NNDOMKNHDMA([In] (KGMHPODJLDH Start, KGMHPODJLDH End) FMCHAOIGDKK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A91820", Offset = "0x6A90220", VA = "0x186A91820")]
	public PNBAKDFDPBJ()
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
		[Cpp2IlInjected.Address(RVA = "0x6A8DB20", Offset = "0x6A8C520", VA = "0x186A8DB20")]
		public string ABEKIDGDFNN(string HEEKOHAFHAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DB70", Offset = "0x6A8C570", VA = "0x186A8DB70")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum GNFHDMEJPIN
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
public struct MIODDBCPMAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string FCKNGKHJEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool HOLDHNBMAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool ABEOHOGCAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float AHLENBHBDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float DFAOPJNMJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public GNFHDMEJPIN FLJJELFFKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Func<DFKFFDGMMBA> CFAGIKCPJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Func<Vector3, FCMNGFAPMAI> ENIIDFCIJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public RigidbodyEx HLMDLPFLNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public RigidbodyEx EAGLKEMFBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public RigidbodyEx DMPMEOBBCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public RigidbodyEx EKODCONAKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform LJINHAFKDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform LBMGHCECLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform NAJBOEAMICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform IGDMAOMNAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
	public PlayerAvatarModernBodyColliders GLJIENHDFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public SkinnedMeshRenderer[] JHPIANMMADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public SkinnedMeshRenderer[] IFNOKCMFODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public SkinnedMeshRenderer[] BCGPPKKMDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public SkinnedMeshRenderer[] FHHBNLNFFBM;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EMKGCAKICPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x68FCAD0", Offset = "0x68FB4D0", VA = "0x1868FCAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DLMIKLCPJAE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68FCAA0", Offset = "0x68FB4A0", VA = "0x1868FCAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E9B0", Offset = "0x6A8D3B0", VA = "0x186A8E9B0")]
	public FCMNGFAPMAI LDDJDGCECME(Vector3 IGAIGAAEACK)
	{
		return default(FCMNGFAPMAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HAALKJBIFLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public LJIAAKKJMFC EAKPPFDKGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform AAIAAMEFNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform IEFNEJBDJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public AvatarConfiguration DKLBDJOEBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Animator GIIDOCJPNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public VRIK GOFLLOGFNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public GameObject[] GKEGPPFIOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Transform BFCAAPMGJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public AssetReference FLBHJIHDHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public GameObject CDEJCMHADJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject BMEAPIDDCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public SkinnedMeshRenderer OAFHDAGADBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public AvatarSkinnedMeshBoneOrderRemapsData LLJEHJDEJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Material HBOMDMIJDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Material AHEOJKFBNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Material MAELBDAEMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Shader AGKNBNJLKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Shader FKMPAEOLCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform OPKDLIBFGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform EHGLHCHBJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform GJCBJDNDANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Transform DMPJIPNEODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Transform BBEMMGMPIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Transform BACPMFCJFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Transform GADFHMJDAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Renderer[] KHNJCLFJEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Transform CNLKMKKAFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Transform PLPFCFDDDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public GameObject CDMAKMDAIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public GameObject PFLBJCJCINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Transform MBBJDDJMAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Transform OMOMDEGCIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Transform EAIKHMGOBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public KDEMKMMCFEE HLMJEJBMBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public KDEMKMMCFEE BGNKJNAJNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public KDEMKMMCFEE JBAMPNPFHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public KDEMKMMCFEE JDGGOBMPNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public KDEMKMMCFEE OFMPFKOIOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public KDEMKMMCFEE HNJDHDLOJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public KDEMKMMCFEE JABFLCFFNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public KDEMKMMCFEE CKPABCLFAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public AvatarBodyPartShapesManager GJPJLHIFDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform HANPCHAFKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform DNBHPDNIFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform FKKAEEEHNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Transform IMPKGMCBKOH;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DFKFFDGMMBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool PCEFBMKIHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public JNKKEIFENFB KEFMBCMDIBD;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FCMNGFAPMAI
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class GBNPAHHEJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly bool EMHEKBDFBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly bool CPDABBBDFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly bool NPKJIMAFLOA;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A8DFE0", Offset = "0x6A8C9E0", VA = "0x186A8DFE0")]
		public GBNPAHHEJKI(bool AGCEPFOGJML, bool DJGPCHNOICK, bool DEOEADOCGOP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float KBNLMHFLJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool OLJKLHKLEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float AJJFNKAIKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3 CGCJFLOEAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Vector3 LBFDINJJOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3? CGOBPEPLAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3? CGGGCLIAFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool OPPCCNPOFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool KAKLOIMPHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool AGFAPDPLHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool KKOMHLGBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Vector3? CJDJNBHOCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool LHDDMEDNANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public Vector3? PGDNPIEGGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool CAAKKEHFIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Vector3? BNAMPJLDJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float MBAGKDBFDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Vector3? DAFMIKOAFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool FBHJIIIINGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public bool ALHLLLCLBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public bool ENPJECCBNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool PHKMLIJBEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public bool JGLAKKANBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public bool OBECEPJPGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public bool FGAOEKAKFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public bool KNCNKOHBNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public bool NJDOOAIEGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public bool FDMPHNNBJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public bool EBKFHKGMNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Vector3? BMAIJLALJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public DDCDBMMKLME JINBHKCJEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public DDCDBMMKLME DGMOMFEFPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float LGFHIONCPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public float EAGADMLAOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public IBPCPGIHICI GLLFOMMMAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public IBPCPGIHICI MIEBLOILOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public bool DAJDHADMPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public bool CFBDMIGBFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public bool CKKEIELGOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public GBNPAHHEJKI HBGHNAIALDK;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A8DBC0", Offset = "0x6A8C5C0", VA = "0x186A8DBC0")]
	public void IILCLEHCELG(Quaternion FJFNLINEAKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class KNEEKCDFHAA
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E050", Offset = "0x6A8CA50", VA = "0x186A8E050")]
	public static PLGDACFFJCI NDEHEMKAAEB(this GJJDGJFKAMA PECHDAFMNOO)
	{
		return default(PLGDACFFJCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E030", Offset = "0x6A8CA30", VA = "0x186A8E030")]
	public static void DIILBFKFCHA(this GJJDGJFKAMA PECHDAFMNOO, PLGDACFFJCI CLMKDBDPNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface KDEMKMMCFEE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float OMPPDBKHEPB);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class PlayerAvatarModernBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum KANCPNMHJDP
		{
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			EnabledForFullBody,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			EnabledForModernBeanBody
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private KHJBOPJJEBM AMMMHIOEKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private Collider[] NEDNEGHINDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly HashSet<Collider> HIMMNJDFHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private KANCPNMHJDP? DEPDELBCLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private Collider[] FullBodyOnlyColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] IEFLPEKIALB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<Collider> OONIHHKFMIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6A92A60", Offset = "0x6A91460", VA = "0x186A92A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private KHJBOPJJEBM OEPDCIINKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6A91EE0", Offset = "0x6A908E0", VA = "0x186A91EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GNLLDPGHGJO
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1630010", Offset = "0x162EA10", VA = "0x181630010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6A91DA0", Offset = "0x6A907A0", VA = "0x186A91DA0")]
		private void COAMALPEMFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A91E50", Offset = "0x6A90850", VA = "0x186A91E50")]
		private void EOIDPLFBFMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A91D00", Offset = "0x6A90700", VA = "0x186A91D00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6A929B0", Offset = "0x6A913B0", VA = "0x186A929B0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer CJIODFGFFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6A926E0", Offset = "0x6A910E0", VA = "0x186A926E0")]
		public void SetCollidersEnabled(KANCPNMHJDP ACEEMNFHFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6A92250", Offset = "0x6A90C50", VA = "0x186A92250")]
		public void ReparentBonesUnderOtherBoneCollection(KHJBOPJJEBM JCAELGODDJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A91F80", Offset = "0x6A90980", VA = "0x186A91F80")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A929D0", Offset = "0x6A913D0", VA = "0x186A929D0")]
		public PlayerAvatarModernBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LADEDNDHMNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform IAGAFFIJBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform BPGBMPAAINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Transform FNMHBDBNNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Transform PEMBFFKLEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Transform KEJKJCBFGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Transform GMBNHDPEKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform HKDMGFLCHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Transform HDIPPFDDDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Transform MDGOJDPILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private PositionAndRotation OJGJMCPLFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private PositionAndRotation LIIHMCMBPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private PositionAndRotation KPAFGBPLCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private PositionAndRotation HKIGDBLNCPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PositionAndRotation OMEALBIGDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PositionAndRotation PINCEEBCNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private PositionAndRotation ADPEGLOPGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PositionAndRotation PNPBHINCKKO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E2E0", Offset = "0x6A8CCE0", VA = "0x186A8E2E0")]
	public void PCEEADECCDH(Transform OJDAAGAPMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E4F0", Offset = "0x6A8CEF0", VA = "0x186A8E4F0")]
	public void PEAJDNLBBDH(HandLogicOffsets BAGCJKEKJOP, HGPIBOIJKAI FGJMBHBOGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6A8E070", Offset = "0x6A8CA70", VA = "0x186A8E070")]
	public void EGCHNACHOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public LADEDNDHMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OODOLDKDEFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Transform MAFLKKBOBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Transform MNPHAMHAGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform GDBMLNLENOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Transform NBEJNPFEDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Transform CGMHLEIGHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private PositionAndRotation JLHIGOGFMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private PositionAndRotation GMJCEHJNNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private PositionAndRotation HKEKMIALPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private PositionAndRotation EGMDALPBHMI;

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EF00", Offset = "0x6A8D900", VA = "0x186A8EF00")]
	public void PCEEADECCDH(Transform PPOKHOMMOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6A8ECF0", Offset = "0x6A8D6F0", VA = "0x186A8ECF0")]
	public void ENLIFIDMACK(HeadLogicOffsets CJBLCCKMCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6A8EB40", Offset = "0x6A8D540", VA = "0x186A8EB40")]
	public void BCPENPCMDKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public OODOLDKDEFC()
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
