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
public enum DDJELBEAPKP
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
public enum OEMMBBGMLDB
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
public struct HBABJMKNLDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator AJAEPOOKDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public PBDOKJEOOED NALAINOOIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration PKKIMNDPHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject OKAECMIAONG;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GDEFOANGIMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform IADJGFAGICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool KJLCNIJJHKP;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FDICCLMPFOA
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
public enum IOBIIAEKPJM
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
public struct GKABBMCDNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 MNJBLGJPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 DLAMFABDACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 FFIGIHDKLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 KODPOMDKHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 KOKDIIGCNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 KGDNNPAAPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 IIBAGDOEDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 IPOPJNMCHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 KNMOBFEKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 DLNIPGCBLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 CGMDMFGLKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 KDAOLGPOENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 LCCKPLEBENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 NHJANPDBOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 AINPEIDBCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 FGLCAJFPKDJ;
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
public static class HFPKAHNKAIC
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly string PBGKJJFJIPE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68ECFA0", Offset = "0x68EB5A0", VA = "0x1868ECFA0")]
	public static ANKFKLNBGCB DFECODMNDBC()
	{
		return default(ANKFKLNBGCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68EC9E0", Offset = "0x68EAFE0", VA = "0x1868EC9E0")]
	public static JHGPPLOMCNA AEOLBHFNIHL(Transform MGFHCPPOOIB, Transform IOAGKGDEJBG, AvatarConfiguration NDDODAELILB, Animator HLPCAIMEOGC, VRIK FOBGDLDBELG, GameObject[] JLMNIMDPFEG, Transform HBPNIDKOBPK, AssetReference AJKKMNJBBAF, GameObject BBBOBAMGGBC, GameObject KGGDCCKLPFN, SkinnedMeshRenderer HNGJIHPKIBH, AvatarSkinnedMeshBoneOrderRemapsData FIHBIKBMFCO, Material NOIFDMDMKNL, Material DEFOJNCGKPN, Material EOEGDDKDFNH, Shader BLFHCNINDNJ, Shader EJCICBDFKPB, Transform JDIGJAHOLIM, Transform BLKFPINLHEH, Transform OBONJFBKBJM, Transform KFKBNDFHJAL, Transform ALNFAGHALOD, Transform MPICNECBGOM, Transform NHDLEEAELMN, Renderer[] NIKPHNIHHCO, DJJFDLKHLKN OLKCLAJIIND, DJJFDLKHLKN DFNKHCPBGIK, DJJFDLKHLKN MANECBOGBFP, DJJFDLKHLKN HCHLDDECCEH, DJJFDLKHLKN AIACCFAHHHJ, DJJFDLKHLKN BBIPFKLHDLK, DJJFDLKHLKN DKLDAKEDBNJ, DJJFDLKHLKN PGJNBJODPOM, Transform LBNNOAICDMA, Transform DEFLGFHGEHD, GameObject CPMNJKDMFBH, GameObject MDCIPGLMIPC, AvatarBodyPartShapesManager HJALAGMPDGL, Transform INPNEECELAK, Transform EBKEHEPIBDM, Transform OPLAKMFKBKO, Transform OCOELIMOKCO)
	{
		return default(JHGPPLOMCNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68ED340", Offset = "0x68EB940", VA = "0x1868ED340")]
	public static KJBALPNAEFI GBKAPJJDJBI(string HEJJMMKJMJD, bool OHAOEHEOJOC, bool CBECOBMENMB, bool MMALDMMHHPL, Func<GDLCGBNGCBM> DFMDPHCAAKO, Func<Vector3, ANKFKLNBGCB> JGFKAOMAGAB, RigidbodyEx FEKNNNOIEBJ, RigidbodyEx IJGEBBDONEJ, RigidbodyEx JMNHJFAMDAA, RigidbodyEx KIDECONCOGC, Transform HGKBDAJJPNG, Transform AAHEJGBKMBP, Transform HMOIADFPPBB, float JAMENMMPMOG, float NPLKALGCKNF, PlayerAvatarFullBodyColliders EMBBBJEHMEA, SkinnedMeshRenderer[] HNAEDBOLNLG, SkinnedMeshRenderer[] AFIKJLHBIOI, SkinnedMeshRenderer[] COFBPCJAAOM, SkinnedMeshRenderer[] NKLNCBMLGCC)
	{
		return default(KJBALPNAEFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68ECE20", Offset = "0x68EB420", VA = "0x1868ECE20")]
	public static JMJADIBIOKB BKMPNJHDOLG(Transform IOAGKGDEJBG, AssetReference AJKKMNJBBAF, GameObject BBBOBAMGGBC, GameObject KGGDCCKLPFN, SkinnedMeshRenderer HNGJIHPKIBH, AvatarSkinnedMeshBoneOrderRemapsData FIHBIKBMFCO, Material NOIFDMDMKNL, Material DEFOJNCGKPN, Material EOEGDDKDFNH, Shader LDDCFOHLNDA, Shader CMJMLCHAHPD, Animator KKLKALDELBC, Renderer[] NIKPHNIHHCO, AvatarConfiguration MKNCGLJODGJ, AvatarBodyPartShapesManager HJALAGMPDGL, IReadOnlyDictionary<string, Transform> HNMDOGLEKDJ)
	{
		return default(JMJADIBIOKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68EC960", Offset = "0x68EAF60", VA = "0x1868EC960")]
	public static FKEGMDJCMPK ACPIEDIMMDI(SkinnedMeshRenderer[] HNAEDBOLNLG, SkinnedMeshRenderer[] AFIKJLHBIOI, SkinnedMeshRenderer[] COFBPCJAAOM, SkinnedMeshRenderer[] NKLNCBMLGCC)
	{
		return default(FKEGMDJCMPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68ED830", Offset = "0x68EBE30", VA = "0x1868ED830")]
	public static CFFIACCNFJP PJCOBAKBFFL(Transform JDIGJAHOLIM, Transform OBONJFBKBJM, Transform BLKFPINLHEH, Transform KFKBNDFHJAL, Transform ALNFAGHALOD, Transform MPICNECBGOM, Transform NHDLEEAELMN, AvatarConfiguration NDDODAELILB)
	{
		return default(CFFIACCNFJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x9B5B10", Offset = "0x9B4110", VA = "0x1809B5B10")]
	public static FFNFPGAJGIC FCPPFNHIKAH(SkinnedMeshRenderer[] KEJHFJHBKEM)
	{
		return default(FFNFPGAJGIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68ED790", Offset = "0x68EBD90", VA = "0x1868ED790")]
	public static GJJFJKENHOH PINJGFHFGKN(KBGIPCJPJGF DHDFIEMLACA, int IFJOIEEPHDN, int CLONFAFGFMH, Color LIOFGAIICAI, Color BOHBCKIDFOD, int OLBEHCDNEJB, int NCOEJMMOKAF, Color EBBJPKAKGOM, Color PGKBMHNCEJB, int DMLGEEOLLKN)
	{
		return default(GJJFJKENHOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68ED4E0", Offset = "0x68EBAE0", VA = "0x1868ED4E0")]
	public static LDEGDJGLODL IIKDAMJBIMA(KBGIPCJPJGF DHDFIEMLACA, Vector2 DAJHDLHNLFJ, float JEGDKOBEJGM, Vector2 AMCEGBENDPK, float KNIDEGDBHJD, Vector2 CDAEBDIOOFA, float DDLGBGNADKC, Vector2 CBLKBKECFGE, float IOENPANLHEM)
	{
		return default(LDEGDJGLODL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68ED720", Offset = "0x68EBD20", VA = "0x1868ED720")]
	public static HBABJMKNLDF OLFAMGCHHIN(Animator AHKJJKGDLCM, PBDOKJEOOED PGJOENDGMDG, AvatarConfiguration MKNCGLJODGJ, GameObject FCHIOOHCJIL)
	{
		return default(HBABJMKNLDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68ECFF0", Offset = "0x68EB5F0", VA = "0x1868ECFF0")]
	public static GDEFOANGIMC DNAPAMOPAPK(Transform IIBBDDMBAHK, bool CBECOBMENMB)
	{
		return default(GDEFOANGIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68ED590", Offset = "0x68EBB90", VA = "0x1868ED590")]
	public static PositionAndRotation JLNJDKNPIMA(Transform GNPDHCFCCHE, Transform MGFHCPPOOIB)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68ED030", Offset = "0x68EB630", VA = "0x1868ED030")]
	public static void EDFAJEFIGDO(Transform GNPDHCFCCHE, Transform OPDPAPLNNBB, PositionAndRotation CBPGPFLBFOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GLHAHPJOJEK
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68EB740", Offset = "0x68E9D40", VA = "0x1868EB740")]
	public static DDJELBEAPKP IABOJLCDCMC(this FDICCLMPFOA JIJNKFNJFDL)
	{
		return default(DDJELBEAPKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68EB730", Offset = "0x68E9D30", VA = "0x1868EB730")]
	public static bool AIMLAPPIJHD(this FDICCLMPFOA JPOOCDOBDGJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AGPIFGMKBJI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PHHGGHJDNNH : AGPIFGMKBJI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform BIPGCHCOEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x868250", Offset = "0x866850", VA = "0x180868250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 FPJFAFBKBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE108C0", Offset = "0xE0EEC0", VA = "0x180E108C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xE109F0", Offset = "0xE0EFF0", VA = "0x180E109F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? BJEFILIJKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xF340B0", Offset = "0xF326B0", VA = "0x180F340B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xF340C0", Offset = "0xF326C0", VA = "0x180F340C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public PHHGGHJDNNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JAGJEEHIKHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly PHHGGHJDNNH HFNJHEGKBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly PHHGGHJDNNH APCEHLBIMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly PHHGGHJDNNH MHFDOHCIOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly PHHGGHJDNNH POHOKPNJPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly PHHGGHJDNNH PAHCEOGGFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly PHHGGHJDNNH PEKJJDDLEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly PHHGGHJDNNH ACEMMABOLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly PHHGGHJDNNH NCBCCAJPPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly PHHGGHJDNNH BHNIGPHIPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly PHHGGHJDNNH MFHKHIONAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly PHHGGHJDNNH NCOCHHFBJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly PHHGGHJDNNH MFOFFACDCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly PHHGGHJDNNH ECFCDDNDOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected PHHGGHJDNNH AHOOGOEBCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly PHHGGHJDNNH KPCAPGHJDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly PHHGGHJDNNH HPPAKMBBDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly PHHGGHJDNNH JMKGCKJGFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected PHHGGHJDNNH JBJEFIHPPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly PHHGGHJDNNH FOFPDHLPNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly PHHGGHJDNNH GOGMIIOKBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly PHHGGHJDNNH BDFBJDLBGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected ReadOnlyCollection<PHHGGHJDNNH> PPLMLJLJLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Transform HBPNIDKOBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private (PHHGGHJDNNH Start, PHHGGHJDNNH End)[] LOLJFHCEFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private Dictionary<string, PHHGGHJDNNH> GLHNLMLCGLJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AGPIFGMKBJI DIHONAJDPJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x868220", Offset = "0x866820", VA = "0x180868220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AGPIFGMKBJI JHMONOGPBPP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AGPIFGMKBJI ALMPCJDHMEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AGPIFGMKBJI GNAKLOPKMFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AGPIFGMKBJI MHKCCJFKCHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AGPIFGMKBJI HDBEAKHOHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8736F0", Offset = "0x871CF0", VA = "0x1808736F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AGPIFGMKBJI ENIDOEPPBGC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86ADF0", Offset = "0x8693F0", VA = "0x18086ADF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AGPIFGMKBJI GIJFJDNEJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86AE10", Offset = "0x869410", VA = "0x18086AE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public AGPIFGMKBJI JDAKIFAGJJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86FA50", Offset = "0x86E050", VA = "0x18086FA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68EDF60", Offset = "0x68EC560", VA = "0x1868EDF60")]
	public void NGCPCDDFMDH(VRIK INBECLIPIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68EEE80", Offset = "0x68ED480", VA = "0x1868EEE80")]
	private void OEFIHCKAIOK(Transform MADFKNCBFBG, PHHGGHJDNNH PABFDMCLKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68ED970", Offset = "0x68EBF70", VA = "0x1868ED970")]
	public PHHGGHJDNNH DKCKMODIDHM(string CAFGNKAIMAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68ED9E0", Offset = "0x68EBFE0", VA = "0x1868ED9E0")]
	public void JAELCFKDJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68EDDF0", Offset = "0x68EC3F0", VA = "0x1868EDDF0")]
	public float JFLFPHOBEAF([In] (PHHGGHJDNNH Start, PHHGGHJDNNH End) CHPKHLLKIHI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68EEF10", Offset = "0x68ED510", VA = "0x1868EEF10")]
	public void OHGBEFKGLEI([In] ANKFKLNBGCB NEIJPCGNELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68EDE30", Offset = "0x68EC430", VA = "0x1868EDE30")]
	private Vector3 MJMFNEEFMLE([In] (PHHGGHJDNNH Start, PHHGGHJDNNH End) CHPKHLLKIHI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68EF0C0", Offset = "0x68ED6C0", VA = "0x1868EF0C0")]
	public JAGJEEHIKHG()
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
		[Cpp2IlInjected.Address(RVA = "0x68EB640", Offset = "0x68E9C40", VA = "0x1868EB640")]
		public string FCKHAIDDAIL(string HNEKICEMJBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68EB690", Offset = "0x68E9C90", VA = "0x1868EB690")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KJBALPNAEFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public string LDBILJKHBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool KJLCNIJJHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool PHINNPIFOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float PLDCDFMGPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float JEGBLKCALML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool NCPBFFEDBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Func<GDLCGBNGCBM> ADFEDLOFBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Func<Vector3, ANKFKLNBGCB> KKJMIACKMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public RigidbodyEx ENDODLPILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public RigidbodyEx PABGCAFDLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public RigidbodyEx GGOCPANFMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public RigidbodyEx OBMDGGGNDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Transform DDNPOJDNMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform NJKKCKNFHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform BBADBMAMDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public PlayerAvatarFullBodyColliders FAGEJMABHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public SkinnedMeshRenderer[] FODAAHLGBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public SkinnedMeshRenderer[] OIIDHIJPJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public SkinnedMeshRenderer[] OGCOPGNNLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public SkinnedMeshRenderer[] ABJJDLOPODK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68EF5A0", Offset = "0x68EDBA0", VA = "0x1868EF5A0")]
	public ANKFKLNBGCB APKPDGPCLLF(Vector3 JEFKCDOBIEP)
	{
		return default(ANKFKLNBGCB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JHGPPLOMCNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform NJIAEDMFBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform AMCNGDNHKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public AvatarConfiguration PKKIMNDPHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Animator NAHACKGKBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public VRIK PHFPACAILLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public GameObject[] BBPGKLODLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform FDJOAFOKDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public AssetReference HEHGOFBCGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public GameObject JALDBCKKLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public GameObject LCJNLLHMILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public SkinnedMeshRenderer LNIGKPEOGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public AvatarSkinnedMeshBoneOrderRemapsData LDIKDAGMOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Material FCFKHOGBLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Material EMIOOLFGPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Material HFNGIGFJGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Shader ACBOIEEFANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Shader ELEECNIIDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Transform NNGDPLIEAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Transform MINJAPLKCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Transform CIHDBPGDLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Transform AFFMPLKLODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Transform KJBDHEKINOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Transform BNPNEBLABHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Transform COHOCDAHNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Renderer[] CJBFKDIBKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform PLODDBGDCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform MCLBOBBPBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public GameObject FIFFDKMPHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public GameObject CCNFNMNFEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public DJJFDLKHLKN HMDGBIHIBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public DJJFDLKHLKN PGNJBCHKCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public DJJFDLKHLKN BEECKGMPMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public DJJFDLKHLKN GGKIGKGALCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public DJJFDLKHLKN JNLINBCBEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public DJJFDLKHLKN IPNDPCCNLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public DJJFDLKHLKN GBICPBLBMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public DJJFDLKHLKN KJJIPDGBIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public AvatarBodyPartShapesManager GCFEJBDFFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Transform NMNPBBLHANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Transform DBNGMFLGMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public Transform DKPFOKOFFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Transform JNPKLMNPLIK;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct GDLCGBNGCBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool HMPGNOKFBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public JCHEPGBFHGG PNNLPICGBCO;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct ANKFKLNBGCB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DIJEOCABHOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly bool IJMHIMLLCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly bool DMGGGDIEAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly bool LJDADEPOFNE;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68EB6E0", Offset = "0x68E9CE0", VA = "0x1868EB6E0")]
		public DIJEOCABHOM(bool PAPBJIFEGAN, bool CDGIAPGIPJB, bool IALKPMLMPJL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public float OJNOBMCHMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool FEDDLIIPPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public float FLMCMLDCPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Vector3 DMDAEJEPNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Vector3 LNHIFJFBDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Vector3? FPBEDJBDGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Vector3? OBHFGDHBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool NKODIMMMCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool OIOEFOJFFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool PPJNAFBDKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool PFLLCJLHGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Vector3? BLELEJLCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool IOEDJBODEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3? OHGIEFDOJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool PDEMIDCADOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3? PBNODBAEDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public float OFMHDMNBHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Vector3? FAGNMONLNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool BNINBMGIAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool ANKNIBCGMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool KJADAONGMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public bool FPHBDIIKKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool FGOLCFBOLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public bool FIHEHMPJKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool JGEHNHEPFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public bool HHDLGCIPGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public bool LFCPIKJKEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public bool NLDCNKEILAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool CJOOMLPNHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Vector3? BJDIPLCGBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public FDICCLMPFOA AIAIAFKGIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public FDICCLMPFOA EPHHHPMGHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float ACNNPKNNKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float BCGPKLEENLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public IOBIIAEKPJM OKKJPLCHAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public IOBIIAEKPJM AEMCADLOHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public bool EMAIDDAEAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public DIJEOCABHOM EJIHIDAFCCJ;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68EB220", Offset = "0x68E9820", VA = "0x1868EB220")]
	public void NOIBDLPIHPN(Quaternion GLKHDAMNPBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class OFONEFKKJFA
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68EF750", Offset = "0x68EDD50", VA = "0x1868EF750")]
	public static JNJJMPPHJEI MKFGDPNBEKG(this APEPIKMHPEE HLIDMKMINHN)
	{
		return default(JNJJMPPHJEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68EF730", Offset = "0x68EDD30", VA = "0x1868EF730")]
	public static void HMAFGLPANCC(this APEPIKMHPEE HLIDMKMINHN, JNJJMPPHJEI DMNGPNKHPKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DJJFDLKHLKN
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float JOOMCFPDCGH);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private KJIEGMMGEGN HFDBMMLGDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private Collider[] EMGBINFPPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] DCAHCEFBKND;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> IIANDDEKJLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x68F01B0", Offset = "0x68EE7B0", VA = "0x1868F01B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KJIEGMMGEGN PAFOMKMDBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x68EF770", Offset = "0x68EDD70", VA = "0x1868EF770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool MDHJFNEIKLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA7F570", Offset = "0xA7DB70", VA = "0x180A7F570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68EF820", Offset = "0x68EDE20", VA = "0x1868EF820")]
		private void OKPCBDOIGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68EF810", Offset = "0x68EDE10", VA = "0x1868EF810")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68F0190", Offset = "0x68EE790", VA = "0x1868F0190")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer PMFNMEFDPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68EFFA0", Offset = "0x68EE5A0", VA = "0x1868EFFA0")]
		public void SetCollidersEnabled(bool PCJPKCENFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68EFB70", Offset = "0x68EE170", VA = "0x1868EFB70")]
		public void ReparentBonesUnderOtherBoneCollection(KJIEGMMGEGN PLFNINEFLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68EF8D0", Offset = "0x68EDED0", VA = "0x1868EF8D0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GNJKKCFIJPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Transform FBCICNLHBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Transform GADKJJMGJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public Transform ICAMEFLAKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Transform IDDIINKFLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Transform MCKOIIDFCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Transform NBBDPPDJOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Transform CPOKGNACDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Transform NIGIGJCOEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform NMOBJEJOHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PositionAndRotation OKPMCNBNJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private PositionAndRotation DGEFAKJDCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PositionAndRotation BDNFOJFBABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private PositionAndRotation IDJBNFHGOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private PositionAndRotation IGCFIBOEGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private PositionAndRotation LKOPIDGEGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private PositionAndRotation DNBBLBHPEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private PositionAndRotation OBDONPMNNEG;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x68EC260", Offset = "0x68EA860", VA = "0x1868EC260")]
	public void PNLKNBIHCGI(Transform EBDCMAAKPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x68EBA00", Offset = "0x68EA000", VA = "0x1868EBA00")]
	public void EKGPMHDLBGH(HandLogicOffsets IJAMEEELAAK, PBDOKJEOOED HOCELAEEOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x68EB790", Offset = "0x68E9D90", VA = "0x1868EB790")]
	public void EEHDJDENJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public GNJKKCFIJPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GOIJFLCDIIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform IEKOCPAOBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform LAILPAFPEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform KIOEFAIAPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform GJNCIAMFNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform JIFNIIPBILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PositionAndRotation IFJEHLOLEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private PositionAndRotation BODGKAFEHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private PositionAndRotation EFFOMNJMCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private PositionAndRotation GHLBGGJLDJB;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x68EC830", Offset = "0x68EAE30", VA = "0x1868EC830")]
	public void PNLKNBIHCGI(Transform GGHKPLFFKAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68EC470", Offset = "0x68EAA70", VA = "0x1868EC470")]
	public void CPGECKCBPJP(HeadLogicOffsets CBPGPFLBFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x68EC680", Offset = "0x68EAC80", VA = "0x1868EC680")]
	public void KOCIGELBLIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public GOIJFLCDIIB()
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
