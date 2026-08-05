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
public enum JCPJICNIBCM
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
public enum GCBOGMDBBHF
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
public struct AAPCOIPLNKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator KOMEGKKOOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public CABDNDNGIBH DNIFEGNDLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration FEOJDAHBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject HJCCBONGOHM;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DCIMNDGHMOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform HILJKFKNNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool HLFMACHDKNN;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CABDNDNGIBH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NMIKOKHEDGB
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
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum CHIICFMKKAH
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	AimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	MeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	LightItem,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	HeavyItem,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	AimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	NumTypes
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public PositionAndRotation WatchMenuOriginOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KMDCEFIPDEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 FOPEEBLKKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 MJHHNAIMOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 KANEHAFDKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 MNHCGFAJFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 BHLFDEAOABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 OCOGDKEHNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 ALCBMEAIKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 KIBHLHAFNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 NLFFOGPNIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 FCJEDBKIAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 IEHEMCBHDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 PPKMOPEEIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 CENAOLJIKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 GDOIDBOEDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Vector2 CIJFJNJDGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Vector2 ACEJLPDFBOC;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class EPKHHBGHDFM
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly string DLAHPAPEGPB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67AC750", Offset = "0x67AB150", VA = "0x1867AC750")]
	public static OFIEPFIPJJG GBGDJDGENDH()
	{
		return default(OFIEPFIPJJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67AC380", Offset = "0x67AAD80", VA = "0x1867AC380")]
	public static PPHKJMDKKGL FHOIBPGHDHM(Transform NEGPNIDHHGH, Transform OJABKFFNLBO, AvatarConfiguration LBAJEDNDPKN, Animator EFAAKLGKOJH, VRIK DDAAPKBOIDG, GameObject[] FGEEIADCEKL, Transform ODHLODKJGEF, AssetReference DOFDMMIIPCN, GameObject OICDAFCDBHO, GameObject DJECMMBCBCC, SkinnedMeshRenderer BJBACJIADEM, AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ, Material AMEBJHKICCE, Material FOAFMKOGCDG, Material OCKHCIGMNIE, Shader CJGEOHIONEP, Shader MHFHOAHIBOD, Transform MMHOFPGGMEN, Transform GNMJFGLJIPP, Transform LNBIKKMEJPC, Transform MDLAPOJHBHB, Transform IFPHBMLDLJG, Transform PHKCCJHMDNM, Transform PAKGHKGDKAE, Renderer[] JCMNHEKPNMB, JKJNNLGEJBH EMBKNJCNGLB, JKJNNLGEJBH CKEECLOPDNC, JKJNNLGEJBH EDLJGKGBJAA, JKJNNLGEJBH GGFLKJBPKCA, JKJNNLGEJBH MNCEPIILIBD, JKJNNLGEJBH DMOCENOGBLI, JKJNNLGEJBH AMIOJJMNBIL, JKJNNLGEJBH PPGKFFGEGFB, Transform LCPDNKOKIPM, Transform NFIOIDFALIB, GameObject OMPMOCFGJLO, GameObject KBFDKLLIDIF, AvatarBodyPartShapesManager NFLFEBMIFHK)
	{
		return default(PPHKJMDKKGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67ACAF0", Offset = "0x67AB4F0", VA = "0x1867ACAF0")]
	public static DKMICAFEOAL NMPCFPCBCPF(string BIBHKGEANBC, bool KJAINMAOCPC, bool FDPEFEEGPLO, bool DHMJLBJIENN, Func<JKFEBJECJCA> DFBIGHCMMDB, Func<Vector3, OFIEPFIPJJG> AIFDNCCOAPF, RigidbodyEx EFLGNOBAFAP, RigidbodyEx IKHIMKNDNMG, RigidbodyEx ELJIJKEKIEJ, RigidbodyEx LNCBMMDKKLE, Transform NDBMCPMNEHE, Transform AOAHIPHOIOG, Transform AIMPOEPNIMB, float JLJOAJMAEBJ, float AOIGLAMKMKG, PlayerAvatarFullBodyColliders KNHNHFEABJF, SkinnedMeshRenderer[] PEBIKOIBAAN, SkinnedMeshRenderer[] ODGBIEMMMCK, SkinnedMeshRenderer[] NGANFDHBOCN, SkinnedMeshRenderer[] GIJEEIKCFKH)
	{
		return default(DKMICAFEOAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67AC970", Offset = "0x67AB370", VA = "0x1867AC970")]
	public static FMONJEAPHMB MKDCMHMECJD(Transform OJABKFFNLBO, AssetReference DOFDMMIIPCN, GameObject OICDAFCDBHO, GameObject DJECMMBCBCC, SkinnedMeshRenderer BJBACJIADEM, AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ, Material AMEBJHKICCE, Material FOAFMKOGCDG, Material OCKHCIGMNIE, Shader MLBLEMAEBED, Shader DOIJCDODJGG, Animator MOIIHPMJOFM, Renderer[] JCMNHEKPNMB, AvatarConfiguration JJMMKOLHANB, AvatarBodyPartShapesManager NFLFEBMIFHK, IReadOnlyDictionary<string, Transform> KNJFFEADPPI)
	{
		return default(FMONJEAPHMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67AC880", Offset = "0x67AB280", VA = "0x1867AC880")]
	public static GEOMLACBKFM KMNKAKHNEKE(SkinnedMeshRenderer[] PEBIKOIBAAN, SkinnedMeshRenderer[] ODGBIEMMMCK, SkinnedMeshRenderer[] NGANFDHBOCN, SkinnedMeshRenderer[] GIJEEIKCFKH)
	{
		return default(GEOMLACBKFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67AC2B0", Offset = "0x67AACB0", VA = "0x1867AC2B0")]
	public static LKMCODCLMGM DGGHIDLIAGC(Transform MMHOFPGGMEN, Transform LNBIKKMEJPC, Transform GNMJFGLJIPP, Transform MDLAPOJHBHB, Transform IFPHBMLDLJG, Transform PHKCCJHMDNM, Transform PAKGHKGDKAE, AvatarConfiguration LBAJEDNDPKN)
	{
		return default(LKMCODCLMGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x97B890", Offset = "0x97A290", VA = "0x18097B890")]
	public static EGBJIADLBKF AJBEEPONEHP(SkinnedMeshRenderer[] LMKMMKKILMP)
	{
		return default(EGBJIADLBKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67AC210", Offset = "0x67AAC10", VA = "0x1867AC210")]
	public static CLNDJONOGLP ADJJPAHPAFD(OEMMBNJFFOI JHCMAOGGICK, int GBHFGHKLKLM, int MHBIBJIDOPJ, Color AMONHGMCPMC, Color DOFLHILLGAL, int CFPIMEPKAOB, int CACGJJGGFIC, Color KCOFMMILDJB, Color FDKOCHBNGPG, int EKCKMCMOHIG)
	{
		return default(CLNDJONOGLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67AC7D0", Offset = "0x67AB1D0", VA = "0x1867AC7D0")]
	public static HANBPEILFJA KHBFIIOHHOM(OEMMBNJFFOI JHCMAOGGICK, Vector2 IHBOKNGLBIC, float DAKKNDEJPFK, Vector2 HEACMDJGFIH, float DBPKMMFOFMF, Vector2 OHBIOFBNLPF, float NKCANFPPFLK, Vector2 JPBNLNFLCGB, float ANEPIPILGFD)
	{
		return default(HANBPEILFJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67AC900", Offset = "0x67AB300", VA = "0x1867AC900")]
	public static AAPCOIPLNKD MBFIFMDBCJF(Animator FNFACMLNPJH, CABDNDNGIBH NCEBIOAIPAK, AvatarConfiguration JJMMKOLHANB, GameObject MGGNGLFDGMM)
	{
		return default(AAPCOIPLNKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67AC790", Offset = "0x67AB190", VA = "0x1867AC790")]
	public static DCIMNDGHMOF IICMDLHAPDD(Transform COMBHPHFCAN, bool FDPEFEEGPLO)
	{
		return default(DCIMNDGHMOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BKJGEADKAPI
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67AA3F0", Offset = "0x67A8DF0", VA = "0x1867AA3F0")]
	public static JCPJICNIBCM FPAFJBNFCDK(this NMIKOKHEDGB HGOKLPAFEGH)
	{
		return default(JCPJICNIBCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67AA440", Offset = "0x67A8E40", VA = "0x1867AA440")]
	public static bool GNBPDJDILJN(this NMIKOKHEDGB LMOOCLJHGPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BKKMILPIPCA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class FLPOAMJMINJ : BKKMILPIPCA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform JKDHBCECKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 KNAENKABPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDB4030", Offset = "0xDB2A30", VA = "0x180DB4030", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDB3F40", Offset = "0xDB2940", VA = "0x180DB3F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? JOELEKFOCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEE5180", Offset = "0xEE3B80", VA = "0x180EE5180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xEE5170", Offset = "0xEE3B70", VA = "0x180EE5170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public FLPOAMJMINJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DEBKIKFAMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly FLPOAMJMINJ KKAAGGNJCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly FLPOAMJMINJ AJOPFFOPLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly FLPOAMJMINJ HKBOMICMACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly FLPOAMJMINJ KEKHALKMIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly FLPOAMJMINJ DKNBDKJELPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly FLPOAMJMINJ NJHAHHJOECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly FLPOAMJMINJ GPMPMJDJEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly FLPOAMJMINJ BJEGBMKMFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly FLPOAMJMINJ HHICKHDBHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly FLPOAMJMINJ OHOEJJHNEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly FLPOAMJMINJ JHGDMBEJPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly FLPOAMJMINJ EIPDFMDMDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly FLPOAMJMINJ NFPGMBOPFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected FLPOAMJMINJ PKOKBMFFBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly FLPOAMJMINJ PDAPABAGIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly FLPOAMJMINJ NBPPGPENODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly FLPOAMJMINJ LNPJKENFGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected FLPOAMJMINJ ILKJHOCKJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly FLPOAMJMINJ ELLLKFOHPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly FLPOAMJMINJ ANPINEKKEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly FLPOAMJMINJ DEFBNDJMOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected ReadOnlyCollection<FLPOAMJMINJ> IPIMLIIKFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Transform ODHLODKJGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private (FLPOAMJMINJ Start, FLPOAMJMINJ End)[] KNNBANCLHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<string, FLPOAMJMINJ> EAPGNKNCLGP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BKKMILPIPCA JPLHMNCBEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BKKMILPIPCA JKPLGMOBDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BKKMILPIPCA BPBACHONFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BKKMILPIPCA CBIJHCLKIJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BKKMILPIPCA NAIOBMIOFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BKKMILPIPCA EJGHECKICII
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84FE00", Offset = "0x84E800", VA = "0x18084FE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BKKMILPIPCA JPPBLHNHIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84FCE0", Offset = "0x84E6E0", VA = "0x18084FCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BKKMILPIPCA CPDKFBEKBPC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BKKMILPIPCA CMEJLDGNLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84FE40", Offset = "0x84E840", VA = "0x18084FE40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67AABB0", Offset = "0x67A95B0", VA = "0x1867AABB0")]
	public void IKKIMJJNOKC(VRIK MGMNEBMIENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67ABAD0", Offset = "0x67AA4D0", VA = "0x1867ABAD0")]
	private void PDHMFBHMKKL(Transform LBIKMBJEOGO, FLPOAMJMINJ PIBCCEDJCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67AA600", Offset = "0x67A9000", VA = "0x1867AA600")]
	public FLPOAMJMINJ EJNMMPMAGMG(string OECDLIOPFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67AA7A0", Offset = "0x67A91A0", VA = "0x1867AA7A0")]
	public void IGHOAPBMPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67ABB60", Offset = "0x67AA560", VA = "0x1867ABB60")]
	public float PNMHAKHGILD([In] (FLPOAMJMINJ Start, FLPOAMJMINJ End) CKPAHBHHOFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67AA450", Offset = "0x67A8E50", VA = "0x1867AA450")]
	public void ECDIMLLMNIB([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67AA670", Offset = "0x67A9070", VA = "0x1867AA670")]
	private Vector3 GMBABHDKLMH([In] (FLPOAMJMINJ Start, FLPOAMJMINJ End) CKPAHBHHOFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67ABBA0", Offset = "0x67AA5A0", VA = "0x1867ABBA0")]
	public DEBKIKFAMLO()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public GameObject AvatarCollidersPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67AA350", Offset = "0x67A8D50", VA = "0x1867AA350")]
		public string DDPLGCHNPEA(string BJCPJJIGFCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67AA3A0", Offset = "0x67A8DA0", VA = "0x1867AA3A0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DKMICAFEOAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public string KCDJBJPANOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool HLFMACHDKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool IICPAEAGCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float KAMLGKMPMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float LPJPEEHGBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool IOBCFBGJFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Func<JKFEBJECJCA> FAIAHIIANHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Func<Vector3, OFIEPFIPJJG> POGBDIADNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public RigidbodyEx CILMLBEJHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public RigidbodyEx HJGKOJMFCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public RigidbodyEx NFCOPOBAEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public RigidbodyEx MIMDIHFOIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform IEDINPGFLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Transform BPKNEJCBIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform KKLGPNLNAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public PlayerAvatarFullBodyColliders AGGGMCJILMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public SkinnedMeshRenderer[] CLPOBNKEOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public SkinnedMeshRenderer[] GFHPNLOCFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public SkinnedMeshRenderer[] NGIBCNEOHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public SkinnedMeshRenderer[] PGKLJNMGIGG;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67AC080", Offset = "0x67AAA80", VA = "0x1867AC080")]
	public OFIEPFIPJJG KKOHHBPAFKF(Vector3 HEPLPKDLPNJ)
	{
		return default(OFIEPFIPJJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct PPHKJMDKKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform GANLOAKMBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform DEBFPHOLHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AvatarConfiguration FEOJDAHBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Animator MLEPKFKNMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public VRIK JJAPBICEGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GameObject[] JICCEDCFIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Transform JILDJDEKCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public AssetReference CHKJFFKCGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public GameObject ADOCMEOHMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public GameObject JOKGDCCDGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public SkinnedMeshRenderer KAGGAHIABAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public AvatarSkinnedMeshBoneOrderRemapsData APMKKHOFKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Material CMGIOLIGLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Material ANCFKMGFPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Material MLOEOKAOCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Shader EKEGDCBCAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Shader BMDNGDPCKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Transform FKGCILANHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Transform FGFHMAAGGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Transform FPBKPNHCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Transform FPBICDNJBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Transform GLFBKHLFNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Transform DFLKHMHIBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Transform FINFEAAAEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Renderer[] NNKLAAEKIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform NMIFOFCDOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform HKHNAHEEAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public GameObject MJFFKALGHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public GameObject CDNKLAPPNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public JKJNNLGEJBH HPMNKECAEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public JKJNNLGEJBH OBIHHPEAKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public JKJNNLGEJBH HBPDNGBAOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public JKJNNLGEJBH LCJOADHPLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public JKJNNLGEJBH ONLEDLNCMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public JKJNNLGEJBH JLDFLOKFPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public JKJNNLGEJBH DLAIDIHDHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public JKJNNLGEJBH MBLEMBJIEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public AvatarBodyPartShapesManager DBJMAGJHBID;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct JKFEBJECJCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool NJDFLNNHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public KFIHHKNEBMF ALOOBFMAMGF;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct OFIEPFIPJJG
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class JOKAOADJEOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public readonly bool AKBDIJAFJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly bool BOCHIGEDCAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly bool ODLDNAEOCOO;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67ACD40", Offset = "0x67AB740", VA = "0x1867ACD40")]
		public JOKAOADJEOF(bool AFAEHFKPMGE, bool BNJNLAEKBFL, bool PCEGKFNHDBK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public float CFIOCNFCMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool LNEBBHINFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public float GDIKOANDMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Vector3 CCHJADMGDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3 EGCELAJLKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? PBJIPFGMMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3? JHALLKANKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool GAJMPLKEOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool JGJBMCGOCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool AMMPIMHMLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool GPLBGCODIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Vector3? HOCPJINBCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool JGCDJHOAEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3? BIFGDPBICHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool KNADDIGHOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Vector3? HBAADOGPDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float PGPEEJCDBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Vector3? BCHMKNCNHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool IKFLFLFNLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool IFKLDBALIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool OHPIPDJCCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool KFKMNLBBEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool JNANLPAIDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool DOOOLELACBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool DGKELPNEEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool DDOLBDEPNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public bool FDHLADCJGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool FKBKIGAOKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public bool MBACNFIKHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public Vector3? EHMJNFLAGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public NMIKOKHEDGB EAPBEPNGPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public NMIKOKHEDGB ACGKMOCEAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float HDIPPDPDBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float JLJOEBFAAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public CHIICFMKKAH AFCJHDKAOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public CHIICFMKKAH GFOKNMGBONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool DPJBGFNGOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public JOKAOADJEOF DIOPBPPOKEF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67AE280", Offset = "0x67ACC80", VA = "0x1867AE280")]
	public void BHOJIHILGNN(Quaternion NGGFFKDNCFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HOKGAPCAHMO
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67ACD00", Offset = "0x67AB700", VA = "0x1867ACD00")]
	public static INEMDIPNFNK ILBPGLOJACG(this PCPEIICFLOP BBCPNLGGBMJ)
	{
		return default(INEMDIPNFNK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67ACD20", Offset = "0x67AB720", VA = "0x1867ACD20")]
	public static void JHPEIIMMEAK(this PCPEIICFLOP BBCPNLGGBMJ, INEMDIPNFNK DBOBEHLEAAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface JKJNNLGEJBH
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float ECCGJGJKLJB);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private EKFEJFAGNND NKGAFPPKANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private Collider[] BAIKLHHEGAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] JHGFHOOGEKB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> JFKDFMHEDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x67AF0C0", Offset = "0x67ADAC0", VA = "0x1867AF0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private EKFEJFAGNND MANDILAPGKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x67AE760", Offset = "0x67AD160", VA = "0x1867AE760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NDKDJCJBFGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA43B20", Offset = "0xA42520", VA = "0x180A43B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67AE6B0", Offset = "0x67AD0B0", VA = "0x1867AE6B0")]
		private void JAGJEDICJPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67AE6A0", Offset = "0x67AD0A0", VA = "0x1867AE6A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67AF0A0", Offset = "0x67ADAA0", VA = "0x1867AF0A0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer GBABIGPJACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67AEED0", Offset = "0x67AD8D0", VA = "0x1867AEED0")]
		public void SetCollidersEnabled(bool OPDIOPBPNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67AEAA0", Offset = "0x67AD4A0", VA = "0x1867AEAA0")]
		public void ReparentBonesUnderOtherBoneCollection(EKFEJFAGNND ALCMACAGIOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67AE800", Offset = "0x67AD200", VA = "0x1867AE800")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MNHPALJKDMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public Transform DIMKJNFFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public Transform DLMOIJFGCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public Transform LNMFAOJFAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Transform CHLFEAEONAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Transform DCMDCNCJIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Transform JAJFHCCLGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Transform DOFDEJDGDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public Transform KJDFPKJLMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Transform DNLHNNABLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private PositionAndRotation GONFNNKNEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private PositionAndRotation JPINCEDBIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private PositionAndRotation IJCFOLFILLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private PositionAndRotation OGDLFOACCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private PositionAndRotation BHPFILELHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PositionAndRotation OPKPLMHAGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private PositionAndRotation MJECNPPNBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PositionAndRotation DCILHMBGDOL;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67AD0B0", Offset = "0x67ABAB0", VA = "0x1867AD0B0")]
	public void CCPNKNOIBEC(Transform APJCNHJPGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67AD770", Offset = "0x67AC170", VA = "0x1867AD770")]
	public void LDDCBGDAHCJ(HandLogicOffsets OKBDKPKFEEL, CABDNDNGIBH PDOLMFKPHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67ACE60", Offset = "0x67AB860", VA = "0x1867ACE60")]
	public void BDBOKNAJOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67ACD90", Offset = "0x67AB790", VA = "0x1867ACD90")]
	private PositionAndRotation AEJIOGNBEJI(Transform CODMEEGPOGH, Transform KNFAJPIPLNG)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67ADFB0", Offset = "0x67AC9B0", VA = "0x1867ADFB0")]
	private void LHDJIEPJALC(Transform CODMEEGPOGH, Transform KNFAJPIPLNG, PositionAndRotation BANCGLIPOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public MNHPALJKDMB()
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
