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
public enum KGKILIPHNPL
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
public enum FMEDBBIHPJK
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
public struct BGNLIMAENOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator AODEJMDPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public PEBCFNMPHKM BGBACFFDCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration LGGDKDLHFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject OPFGHIELDIF;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HINONINHLCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform JKHMMMANMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool EIOGGNBKCBG;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PEBCFNMPHKM
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum HBJLEMDEMFE
{
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	OBSOLETE_CannedWave = 1000
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PositionAndRotation WatchMenuOriginOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HEEGAGAGPHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Vector2 GGCCINMBNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector2 GKNBBCLKEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector2 DGDECDJNINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector2 HJJNOHACILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector2 ONHKOAPFIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 MOMGOHEDPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 HKCCDNKOACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 EIDGFEJLKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 PNPIAAEEEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 ONFMPNPANHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 PBKKJODAJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 KFKLENKEAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 BEIOHJNGIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 CHHPEDBHNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 EHFKIFMCNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 ACOIFJLFMBC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NJIDIDHPBJN
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly string PFLGABDLMDA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x673FF50", Offset = "0x673E750", VA = "0x18673FF50")]
	public static EIDPIMGLEDN IOHKHDAMLEF()
	{
		return default(EIDPIMGLEDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6740150", Offset = "0x673E950", VA = "0x186740150")]
	public static CFHNEDCHEKI OEIKEBLPMGL(Transform EJFALKKEFHM, Transform HIJIPCPNDCI, AvatarConfiguration AILGHLBLAFC, Animator LCGLJOFHEED, VRIK EDKHPMGEKEO, GameObject[] POPOCGNDBPM, Transform DOMPEFBONOD, AssetReference EICKPKDICBC, GameObject BOGLCOMPKFA, GameObject HAECEJFLHFD, SkinnedMeshRenderer LKBMCPMOPMH, AvatarSkinnedMeshBoneOrderRemapsData KGDCHEOCJLG, Material LJMNDPCJEEM, Material DHOECBGPMGF, Material GAJLDBEPGGH, Shader HLBOGMKEIFF, Shader PFGNCPONOBM, Transform PAGIPIBGHFG, Transform PENAMEFFBED, Transform JNDJJBIDLEF, Transform NDJBOECNGFG, Transform GANFBGABKLP, Transform CAJAJHLPMGB, Transform PBAFCGAGBCK, Renderer[] CIFKMEIMDPL, HPACEKLCMOF GNLFGFBFEPA, HPACEKLCMOF NKILHCFKDHB, HPACEKLCMOF GHMEEOLDCDM, HPACEKLCMOF BCECFDFLANF, HPACEKLCMOF NMMKCKPEALC, HPACEKLCMOF BNJBEMJIEJH, HPACEKLCMOF MGPPKILABCI, HPACEKLCMOF HBKCNIDJBPF, Transform LJDHBDKNFHF, Transform OAGKIDJMNIM, GameObject BMKCMOBGNLF, GameObject JJFOBKOFKLO)
	{
		return default(CFHNEDCHEKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x673FD70", Offset = "0x673E570", VA = "0x18673FD70")]
	public static NNPAMPJFNNC HKKPFAAJFJJ(string CHLLKEGJLFH, bool GHOGIPNEFMC, bool OFICKFLJOGJ, bool HKEJJPGAKEI, Func<AIBILJPIKDN> PDJMEDBKJAD, Func<Vector3, EIDPIMGLEDN> CAOJFANAJAN, RigidbodyEx ILKHCBLPKIC, RigidbodyEx JJJJONGGCIL, RigidbodyEx MJLNGNGBMGJ, RigidbodyEx BDHCEFLLDJI, Transform GJFBKNPIKEE, Transform KDCNOFJNEDB, Transform IAINBBOKKFL, float IMPKCBEKBMO, float NJHLDALEDDC, PlayerAvatarFullBodyColliders HAEGFKNGIKG, SkinnedMeshRenderer[] JNOFJLALPGN, SkinnedMeshRenderer[] DJDHAJCEGON, SkinnedMeshRenderer[] FCAOBBCBOGO, SkinnedMeshRenderer[] COMNGIAFKEP)
	{
		return default(NNPAMPJFNNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x673FF90", Offset = "0x673E790", VA = "0x18673FF90")]
	public static IFJMLJCMIDP IPFLAPOKCAH(Transform HIJIPCPNDCI, AssetReference EICKPKDICBC, GameObject BOGLCOMPKFA, GameObject HAECEJFLHFD, SkinnedMeshRenderer LKBMCPMOPMH, AvatarSkinnedMeshBoneOrderRemapsData KGDCHEOCJLG, Material LJMNDPCJEEM, Material DHOECBGPMGF, Material GAJLDBEPGGH, Shader BMHNBODMAAH, Shader KJIAKHGOBBI, Animator MOALDPAMLEK, Renderer[] CIFKMEIMDPL, AvatarConfiguration CJCFPAAOJFD)
	{
		return default(IFJMLJCMIDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6740500", Offset = "0x673ED00", VA = "0x186740500")]
	public static OEFBJFINLMA OPBOFCCHHJL(SkinnedMeshRenderer[] JNOFJLALPGN, SkinnedMeshRenderer[] DJDHAJCEGON, SkinnedMeshRenderer[] FCAOBBCBOGO, SkinnedMeshRenderer[] COMNGIAFKEP)
	{
		return default(OEFBJFINLMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6740580", Offset = "0x673ED80", VA = "0x186740580")]
	public static GHHKPKIMDDB PFEDHPBIIGJ(Transform PAGIPIBGHFG, Transform JNDJJBIDLEF, Transform PENAMEFFBED, Transform NDJBOECNGFG, Transform GANFBGABKLP, Transform CAJAJHLPMGB, Transform PBAFCGAGBCK, AvatarConfiguration AILGHLBLAFC)
	{
		return default(GHHKPKIMDDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x937BF0", Offset = "0x9363F0", VA = "0x180937BF0")]
	public static MBDCLDGGKAH BLEGGGDJEOO(SkinnedMeshRenderer[] PGKILHJEGHH)
	{
		return default(MBDCLDGGKAH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x673FC20", Offset = "0x673E420", VA = "0x18673FC20")]
	public static FLNINPFGHMC ENBHOICPAII(APKNNJNMOCP BANJIABLDLM, int DNCHIACAOGO, int IMADCHELGHM, Color CKIIELDPIEI, Color CCGBFAGMAKA, int KHHHLHFFMLL, int KJKOGPKCLOK, Color GACOPHNKNLN, Color HCBLJIDMJIA, int LHGAFMFBBAD)
	{
		return default(FLNINPFGHMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x673FCC0", Offset = "0x673E4C0", VA = "0x18673FCC0")]
	public static IAAAJAOKAHI FJDNCBPGPHK(APKNNJNMOCP BANJIABLDLM, Vector2 MLAIOBHLGBG, float FENIGBIKICJ, Vector2 HLHGOAEKBPF, float PENNGEPBINJ, Vector2 EEOOJLJOBMP, float CGNFBKFLJMG, Vector2 OHKBAIMGPCB, float KHANAFNHIBI)
	{
		return default(IAAAJAOKAHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67400E0", Offset = "0x673E8E0", VA = "0x1867400E0")]
	public static BGNLIMAENOB NCAPONOEIAF(Animator OFPDKFALDBP, PEBCFNMPHKM LBHDODLBHIO, AvatarConfiguration CJCFPAAOJFD, GameObject DPCCPIHFKGP)
	{
		return default(BGNLIMAENOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x673FF10", Offset = "0x673E710", VA = "0x18673FF10")]
	public static HINONINHLCH IABBBIGJBAF(Transform EOPFDFEHGOC, bool OFICKFLJOGJ)
	{
		return default(HINONINHLCH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LKHKLMBGJIO
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x673FBC0", Offset = "0x673E3C0", VA = "0x18673FBC0")]
	public static KGKILIPHNPL CDBGDCGOPEG(this HBJLEMDEMFE LLADMAPNMGE)
	{
		return default(KGKILIPHNPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x673FC10", Offset = "0x673E410", VA = "0x18673FC10")]
	public static bool LHFJABMJLCK(this HBJLEMDEMFE IEHIDMIIKMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PJGPEPMDBPF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NKIBDMDAENE : PJGPEPMDBPF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform BNMINHJAICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 OEHBBAHMEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xD80900", Offset = "0xD7F100", VA = "0x180D80900", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD80880", Offset = "0xD7F080", VA = "0x180D80880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? CKPKLBKBMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE9E440", Offset = "0xE9CC40", VA = "0x180E9E440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xE9E430", Offset = "0xE9CC30", VA = "0x180E9E430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public NKIBDMDAENE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IJLHJEFCCNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected readonly NKIBDMDAENE BOMNOEKFEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly NKIBDMDAENE MANIBOFEHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly NKIBDMDAENE IBJBGBBCPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly NKIBDMDAENE FCJJJMFAOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected readonly NKIBDMDAENE AONMCPKKEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly NKIBDMDAENE KBJGLNEKLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly NKIBDMDAENE AGENPCMIPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly NKIBDMDAENE LCJBFICPAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly NKIBDMDAENE FHMBMDNLPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly NKIBDMDAENE GMGNANBAPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly NKIBDMDAENE GIDIFFEOKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly NKIBDMDAENE MDHPIAGEEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly NKIBDMDAENE CHAEOBLGCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected NKIBDMDAENE PIHFLKIPOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly NKIBDMDAENE EEGDEJKANMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly NKIBDMDAENE LMLDHMEGAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly NKIBDMDAENE PNECCHHJEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected NKIBDMDAENE GKNLMGFILPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly NKIBDMDAENE LJIFJPACBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly NKIBDMDAENE JHILLPFHCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly NKIBDMDAENE HIBFEGACMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected ReadOnlyCollection<NKIBDMDAENE> CDPAFANECFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform DOMPEFBONOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private (NKIBDMDAENE Start, NKIBDMDAENE End)[] LOEJBKNGODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private Dictionary<string, NKIBDMDAENE> BDEPHLPEKOI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PJGPEPMDBPF HMCFNFGFBNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PJGPEPMDBPF IIEHMFDDEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PJGPEPMDBPF DACKCAFNAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PJGPEPMDBPF IMKOKKNCFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PJGPEPMDBPF IHLJFEKHJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PJGPEPMDBPF AHODINGOKAK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8472C0", Offset = "0x845AC0", VA = "0x1808472C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PJGPEPMDBPF JOCKENDGBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x844010", Offset = "0x842810", VA = "0x180844010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PJGPEPMDBPF DPOKMBPHFOA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x843FE0", Offset = "0x8427E0", VA = "0x180843FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PJGPEPMDBPF BPHOLKADKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x843F90", Offset = "0x842790", VA = "0x180843F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x673DF50", Offset = "0x673C750", VA = "0x18673DF50")]
	public void AJPMFCNHNEK(VRIK HJAHKPBLHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x673F270", Offset = "0x673DA70", VA = "0x18673F270")]
	private void DBDDABELKEF(Transform CMAEAOPOFPD, NKIBDMDAENE LFFBLPMMGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x673F620", Offset = "0x673DE20", VA = "0x18673F620")]
	public NKIBDMDAENE PDLKGJJDLHN(string HPFJOEMPMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x673EE70", Offset = "0x673D670", VA = "0x18673EE70")]
	public void BAGMECPBEFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x673F300", Offset = "0x673DB00", VA = "0x18673F300")]
	public float GKCBJPEJCFO([In] (NKIBDMDAENE Start, NKIBDMDAENE End) GOMLMMDNJHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x673F340", Offset = "0x673DB40", VA = "0x18673F340")]
	public void IJEJFPFIEPG([In] EIDPIMGLEDN DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x673F4F0", Offset = "0x673DCF0", VA = "0x18673F4F0")]
	private Vector3 KLMHMEBFLFP([In] (NKIBDMDAENE Start, NKIBDMDAENE End) GOMLMMDNJHF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x673F690", Offset = "0x673DE90", VA = "0x18673F690")]
	public IJLHJEFCCNB()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public GameObject AvatarCollidersPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x673DA50", Offset = "0x673C250", VA = "0x18673DA50")]
		public string JOICFDGHKOM(string DOCABALPDOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x673DAA0", Offset = "0x673C2A0", VA = "0x18673DAA0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NNPAMPJFNNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string IIIDAGABKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool EIOGGNBKCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool LLLPHFEHLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float GLBGBDBKJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float GLFJNIEPGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool NLOOICCDMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Func<AIBILJPIKDN> BNPKKJGABFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Func<Vector3, EIDPIMGLEDN> EOJNLHPPNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public RigidbodyEx JIIBDKMFFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public RigidbodyEx MBPELKBHPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public RigidbodyEx HOMCAIEFDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public RigidbodyEx LEOMAHBDIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform PCIFLNOIPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform JCLOKFHFDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Transform AAJJPDABBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public PlayerAvatarFullBodyColliders EKKNGODHEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer[] CCGJPPNPNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public SkinnedMeshRenderer[] CNIKGFFAHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SkinnedMeshRenderer[] BCEHCIMGKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public SkinnedMeshRenderer[] MLNBCAHDNMM;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67406B0", Offset = "0x673EEB0", VA = "0x1867406B0")]
	public EIDPIMGLEDN FANFEKLIEAI(Vector3 FENIADKMNKC)
	{
		return default(EIDPIMGLEDN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CFHNEDCHEKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform HDDLKLHBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Transform OAAHEIFOBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public AvatarConfiguration LGGDKDLHFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Animator EICDHCFNDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public VRIK NAEIBHCHOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public GameObject[] DDDEMPHNGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform LIFKBGEMLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public AssetReference IJCJFHJDABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject ELCCEJBGJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GameObject EJECMOHLJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public SkinnedMeshRenderer FKDEDGJJFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public AvatarSkinnedMeshBoneOrderRemapsData BNIHDEAGCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Material OAGCKOPNCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Material GCOHAGIHBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Material MMIHHPBKEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Shader GLDHIDLDODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Shader GDIJLJBLHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform HFDMPHMEPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform KLOKMFGMAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Transform JNLFOJAFBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Transform BCFDGPNJOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform PNKBCJMMBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Transform JIKMEEOGDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Transform HOGNGHBDMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Renderer[] HCJNAOOCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Transform NLLPGBBADGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Transform MONNBGJDOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public GameObject DAAJALPHFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public GameObject LEGOOJLCCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public HPACEKLCMOF EENGMOABHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public HPACEKLCMOF APPPKIJJEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public HPACEKLCMOF BGPGPJDMJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public HPACEKLCMOF PDEPIFHIACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public HPACEKLCMOF LJEJHDACCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public HPACEKLCMOF COONCHKDFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public HPACEKLCMOF HFHCMDOGAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public HPACEKLCMOF JPOCOMIEPOP;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct AIBILJPIKDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool LEOOEMJOPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public LPELNIAIFBH IOMEOGCHJON;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EIDPIMGLEDN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class JJIFPGMHONN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly bool LLMABLOEJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly bool JNHOPOFPNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly bool OEOPFEALPJJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x673FB70", Offset = "0x673E370", VA = "0x18673FB70")]
		public JJIFPGMHONN(bool IOMLAKDDEGN, bool DCEHOKAOADL, bool AIBCDJHIFBN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public float BLALBLLCBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool DNJIPIFIHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public float MGLKKBDBICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3 NOILFPBPPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3 LEBIPBBOCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public Vector3? PCGDPFMPEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Vector3? DPGPNGGEDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool NAACHPLCKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool JNCEOINIGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool OELHNHIFNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool ILIJBBDFOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3? NBPBILDFHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool EPAEENHNKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3? ELCIGKALJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool PLHOCCLCKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3? PCLKDBMJCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public float JNNMKOKCDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Vector3? AKEHMPJEJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool PKAOJALKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool LLDBPCPDFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool LGMHKEONHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool JCPEPICPKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool MIOEHFNLIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool BBHDPNOPMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool KDNGODAIFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool OIJJMJNLALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool NEACNFBKCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool LIMHLIPKCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool GJICMPAEFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3? MFLBGEICBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public HBJLEMDEMFE FPEJFOJCPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public HBJLEMDEMFE BFJODJLAFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool JDHMOMLKPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool HADHBKHBLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public JJIFPGMHONN EGFKCJMONLG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x673DB30", Offset = "0x673C330", VA = "0x18673DB30")]
	public void BAKBAGDNCKA(Quaternion LOMIHBHMPMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CBLJPABMBPC
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x673DB10", Offset = "0x673C310", VA = "0x18673DB10")]
	public static COKDDOEMBCP OLNPFNCOFFB(this HADOENGGMPL EGJINJKGIAK)
	{
		return default(COKDDOEMBCP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x673DAF0", Offset = "0x673C2F0", VA = "0x18673DAF0")]
	public static void NGNAMPCHCAF(this HADOENGGMPL EGJINJKGIAK, COKDDOEMBCP IPHHABIKCHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HPACEKLCMOF
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float PNBNBIDOECN);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private CKBOBKDMADL CJHHAAJDADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private Collider[] JGOIPODBKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] HCIBEALBFIB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> JBLCIIJMFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x67427E0", Offset = "0x6740FE0", VA = "0x1867427E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private CKBOBKDMADL OKNGHJNAFAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6741DF0", Offset = "0x67405F0", VA = "0x186741DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JBINLLHCLFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9F1B10", Offset = "0x9F0310", VA = "0x1809F1B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6741D40", Offset = "0x6740540", VA = "0x186741D40")]
		private void CIDHJCLPPPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6741D30", Offset = "0x6740530", VA = "0x186741D30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67427C0", Offset = "0x6740FC0", VA = "0x1867427C0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer MPOJBNMFNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67425D0", Offset = "0x6740DD0", VA = "0x1867425D0")]
		public void SetCollidersEnabled(bool JKFJGFGHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6742160", Offset = "0x6740960", VA = "0x186742160")]
		public void ReparentBonesUnderOtherBoneCollection(CKBOBKDMADL JAIIDDJNPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6741E90", Offset = "0x6740690", VA = "0x186741E90")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class POHFLDIPBLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Transform DIDCKFPCMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Transform JEFIHLEPGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Transform ICLADOIHPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Transform IGOEDBOFIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Transform JMCMLFIGAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Transform FJGPFIIPLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public Transform JCIGGICAOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public Transform IFDNNEKKPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Transform OAOKAFECHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private PositionAndRotation GFCMHDKBGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private PositionAndRotation NHBIIFBMJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private PositionAndRotation IKIFCIEJEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PositionAndRotation FACOMDCNNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PositionAndRotation GFIIBCEPDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation OIHMIAJCIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PositionAndRotation HJGGIHAPOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private PositionAndRotation GEBONCAHDPK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6740840", Offset = "0x673F040", VA = "0x186740840")]
	public void DIHNAABPOCM(Transform EKPBFJDJAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67411D0", Offset = "0x673F9D0", VA = "0x1867411D0")]
	public void JGNHNKGGILD(HandLogicOffsets HHJGIGLLMFI, PEBCFNMPHKM CDLPJEIMEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6741A10", Offset = "0x6740210", VA = "0x186741A10")]
	public void KBCHHOBFMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6741C60", Offset = "0x6740460", VA = "0x186741C60")]
	private PositionAndRotation LCNDMMJGEJN(Transform EJNBHKKIBKG, Transform HAHBOHGMGFK)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6740F00", Offset = "0x673F700", VA = "0x186740F00")]
	private void FJNGMHNBCJN(Transform EJNBHKKIBKG, Transform HAHBOHGMGFK, PositionAndRotation JLCBKILKOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public POHFLDIPBLC()
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
