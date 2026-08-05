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
public enum NPCCGMLEOLA
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
public enum MOGPEEFLIPO
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
public struct HAAGELDNEFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator JNOJKNHDKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public PGDNBCEICAP CIMHLMLCBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration AOGJCJPENPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject KEAKEDBOOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public HEGHLNFMEGC IDGOFJLOIJO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AKLLHGNFJLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Transform CCKHDAEIENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool MEMOJFNGLLK;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PJHLCOJOHEC
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
public enum DOCMDIBFMFN
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
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LDKDNFOJIAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 HFIAOCPNDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 NMLGLCEMDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 MCKJICHDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 NBAIBEAPMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 LGCGEIPABKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 OPKKAHAIPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 DKIKGLCMCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 OAJEGJELKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 BLMFBLBCJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 JOAGEHKLNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 DDPPFNPGGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 GKJLBFEAFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 DNEMHGPOENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 JNBABOIMBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 DEHGHDJFOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 INLKIFJAKBB;
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
public static class IIHMAKEJICM
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly string DPOAIJLFOJM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D84DD0", Offset = "0x6D83DD0", VA = "0x186D84DD0")]
	public static KLDJADNODDC JPJBCDIPJDP()
	{
		return default(KLDJADNODDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D843B0", Offset = "0x6D833B0", VA = "0x186D843B0")]
	public static HNKMHACJBEN GGJDLHGJMBG(HEGHLNFMEGC KJFGNCHICJH, Transform KNPJEDGMHIK, Transform OOBJAPDOJKC, AvatarConfiguration AGFCEIEGNEC, Animator FDPOILHLPPD, VRIK LLHPAPIIPPB, GameObject[] LEPCOCAMHLH, Transform CEDPCMKKIEL, AssetReference LILLOGLJLHI, GameObject BFMKAGPCAGL, GameObject KKNJLPMFPCC, SkinnedMeshRenderer MEAHDOKIAJD, AvatarSkinnedMeshBoneOrderRemapsData GCCPFEFIEGO, Material DLADMHMPNDP, Material IOOCIFEJIAP, Material DOMGOJBBPJJ, Shader JKGIFOCFEDF, Shader KBFCAPOLJIG, Transform IIHFMPHLCHF, Transform LHLHHPGIFNL, Transform HENCJLAMEDM, Transform EJACFKIDHKH, Transform FHNNCMNPAJH, Transform AHDMBPCEFEI, Transform MBIECKOBLCM, Renderer[] KJJHKBPNBMN, HEIFOMILKAA NGMNJKJFLHG, HEIFOMILKAA FKEMDPKHAMI, HEIFOMILKAA GNKLKHIEKOA, HEIFOMILKAA BFGOGDOMHNA, HEIFOMILKAA KGJLOAFBLKL, HEIFOMILKAA CEGIIGJPEJD, HEIFOMILKAA GDFJOIIKAIE, HEIFOMILKAA KJJIIEGDHME, Transform CJPJKIJHDKJ, Transform OKJOMDGHEPC, Transform IJBEFLONEKH, Transform GHMIAKCIEPF, GameObject DKLFAIMGCKA, GameObject PMAKKHEIBJP, AvatarBodyPartShapesManager MBKAGNEGKNM, Transform MHICOKFANFI, Transform NFDPIFMHPLA, Transform ONIMLILBFOE, Transform OANNJKGIEBF, Transform FPEMLLCBJBH)
	{
		return default(HNKMHACJBEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D841A0", Offset = "0x6D831A0", VA = "0x186D841A0")]
	public static DCPCIMEHGCI FDOBNHCGMJL(string BOFAOIFMLED, bool GPBHNDBKFJA, bool EOPFBLAPNKK, KDAFKEECBOA AOKBCMJKPAP, Func<HKOKIGGHPCN> GDIBPFDEFOE, Func<Vector3, KLDJADNODDC> KKFBMNJLBEN, RigidbodyEx FJAMDAOLKDE, RigidbodyEx GGNAMHPBEOC, RigidbodyEx OPJLOGOOEKL, RigidbodyEx FIJNAKJECJG, Transform GILEBHDBFFA, Transform BDOLGMFOOFJ, Transform HKNBMNDKHNJ, Transform EKIPLMNLFIJ, float MCFLOJPMNKN, float IACLBIDEMJB, PlayerAvatarModernBodyColliders OOCIDPILBAL, SkinnedMeshRenderer[] HBHOGCHDGDO, SkinnedMeshRenderer[] ALDFPCAJBME, SkinnedMeshRenderer[] NGDEHHJDNHN, SkinnedMeshRenderer[] MJDPPJEGFIM)
	{
		return default(DCPCIMEHGCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D84EA0", Offset = "0x6D83EA0", VA = "0x186D84EA0")]
	public static IHJMHHJNOCP NHJJKKOJIOB(Transform OOBJAPDOJKC, AssetReference LILLOGLJLHI, GameObject BFMKAGPCAGL, GameObject KKNJLPMFPCC, SkinnedMeshRenderer MEAHDOKIAJD, AvatarSkinnedMeshBoneOrderRemapsData GCCPFEFIEGO, Material DLADMHMPNDP, Material IOOCIFEJIAP, Material DOMGOJBBPJJ, Shader KGKAKNPBECM, Shader NKGHABFCNAN, Animator LLGLKLNCACM, Renderer[] KJJHKBPNBMN, AvatarConfiguration BMGBEPGFPKO, AvatarBodyPartShapesManager MBKAGNEGKNM, IReadOnlyDictionary<string, Transform> DMMFMLFCBHI)
	{
		return default(IHJMHHJNOCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D84080", Offset = "0x6D83080", VA = "0x186D84080")]
	public static NIGJOAAEPMP DCINKMHBPLK(SkinnedMeshRenderer[] HBHOGCHDGDO, SkinnedMeshRenderer[] ALDFPCAJBME, SkinnedMeshRenderer[] NGDEHHJDNHN, SkinnedMeshRenderer[] MJDPPJEGFIM)
	{
		return default(NIGJOAAEPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D84CF0", Offset = "0x6D83CF0", VA = "0x186D84CF0")]
	public static KJHOPANKMFM JLLJFOEAOMJ(Transform IIHFMPHLCHF, Transform HENCJLAMEDM, Transform LHLHHPGIFNL, Transform EJACFKIDHKH, Transform FHNNCMNPAJH, Transform AHDMBPCEFEI, Transform MBIECKOBLCM, AvatarConfiguration AGFCEIEGNEC, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(KJHOPANKMFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xD4EBE0", Offset = "0xD4DBE0", VA = "0x180D4EBE0")]
	public static BMOBDGFPEEH HBGBELMJBMC(SkinnedMeshRenderer[] LLLAHPFKCOB)
	{
		return default(BMOBDGFPEEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D84100", Offset = "0x6D83100", VA = "0x186D84100")]
	public static CLPNELMHOBN EMPBCMBGLKJ(GIJJKIDEJBL BPMEKFLJHOO, int KCLOOFAPAJJ, int KMCACNDIHGO, Color CBDKKLGLJCA, Color NOIBDNPCKCN, int GINLHKNOCHO, int FJKBEBDEBEN, Color OGMNJDBKIJC, Color BCMHCLBPACF, int KADJFCBBBEO)
	{
		return default(CLPNELMHOBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D83FD0", Offset = "0x6D82FD0", VA = "0x186D83FD0")]
	public static IIJEKAACEBL CMHFLHHCGHJ(GIJJKIDEJBL BPMEKFLJHOO, Vector2 NJONDDGPBOB, float ELBNCPIHDBC, Vector2 IMMGFDJCNHE, float GMCHJPMFLOA, Vector2 KJKBLBKDMEB, float DDGHNDCFFCB, Vector2 AKAKMDLJCPO, float NGMAIDJEDOC)
	{
		return default(IIJEKAACEBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D84E20", Offset = "0x6D83E20", VA = "0x186D84E20")]
	public static HAAGELDNEFG KMMMDMCEEHF(Animator CCKHAGPNJKE, PGDNBCEICAP HNPLJMLFIDG, AvatarConfiguration BMGBEPGFPKO, GameObject FOMPCOIAODG, HEGHLNFMEGC KJFGNCHICJH)
	{
		return default(HAAGELDNEFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6D84370", Offset = "0x6D83370", VA = "0x186D84370")]
	public static AKLLHGNFJLD FKCMAPEFNEH(Transform IHKMAPCKHGF, bool EOPFBLAPNKK)
	{
		return default(AKLLHGNFJLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D84B60", Offset = "0x6D83B60", VA = "0x186D84B60")]
	public static PositionAndRotation JCHCLBPJCDH(Transform BNNGBANBCEG, Transform KNPJEDGMHIK)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D84850", Offset = "0x6D83850", VA = "0x186D84850")]
	public static void IICKNJEPDJJ(Transform BNNGBANBCEG, Transform NOMLNPDJLBO, PositionAndRotation DDIDCKOBMMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HNBGKFNCCGP
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D83F70", Offset = "0x6D82F70", VA = "0x186D83F70")]
	public static NPCCGMLEOLA CGLJMIHFEMA(this PJHLCOJOHEC IHPCIIGPLNJ)
	{
		return default(NPCCGMLEOLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D83FC0", Offset = "0x6D82FC0", VA = "0x186D83FC0")]
	public static bool HHCNACEJODH(this PJHLCOJOHEC CJKGBILBNCP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DCLNENPEBDC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform JAFJFBMIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KLEDGFDFDON : DCLNENPEBDC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform JAFJFBMIFFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BD0", Offset = "0x8B8BD0", VA = "0x1808B9BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 AFPBBBAOFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x11D0DD0", Offset = "0x11CFDD0", VA = "0x1811D0DD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x11D0ED0", Offset = "0x11CFED0", VA = "0x1811D0ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? APNDGFNACLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1312240", Offset = "0x1311240", VA = "0x181312240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1312230", Offset = "0x1311230", VA = "0x181312230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public KLEDGFDFDON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DONANKAIBGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly KLEDGFDFDON KMMMNCDLKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly KLEDGFDFDON PHCLNCMLAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly KLEDGFDFDON HFONALEJCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly KLEDGFDFDON MLGCIKGDNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly KLEDGFDFDON FMLBMMHHMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly KLEDGFDFDON BBBMPBOBCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly KLEDGFDFDON BEKAFOEPJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly KLEDGFDFDON OAIPCKCDDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly KLEDGFDFDON LHAKLODMNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly KLEDGFDFDON CLFIOKEPFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly KLEDGFDFDON EGBPPGBIBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly KLEDGFDFDON MLGHHPOBJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly KLEDGFDFDON EBACJMHJBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected KLEDGFDFDON IHCMCJLHGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly KLEDGFDFDON HOKHKMDDGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly KLEDGFDFDON HIFIPCBBBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly KLEDGFDFDON CIKFEIPCELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected KLEDGFDFDON OAFBFPMIMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly KLEDGFDFDON HIMEKDBJONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly KLEDGFDFDON AHGKIADDMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly KLEDGFDFDON PBCJLCOAHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected ReadOnlyCollection<KLEDGFDFDON> JGDOONFCDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Transform CEDPCMKKIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private (KLEDGFDFDON Start, KLEDGFDFDON End)[] PPGKKJPPEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Dictionary<string, KLEDGFDFDON> IDHBAKFPLFN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DCLNENPEBDC GIIGHJIJCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DCLNENPEBDC DKEEMEHKNHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DCLNENPEBDC AOLGPJGAKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DCLNENPEBDC GMFIALBLLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DCLNENPEBDC LAHJHNHMLKO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DCLNENPEBDC DIOFOIIIENJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public DCLNENPEBDC PDPPPGAIACI
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public DCLNENPEBDC BBCAOHNDPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B4290", Offset = "0x8B3290", VA = "0x1808B4290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DCLNENPEBDC IOHLOEHJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B4260", Offset = "0x8B3260", VA = "0x1808B4260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6D82550", Offset = "0x6D81550", VA = "0x186D82550")]
	public void IIDPIHFFOIK(VRIK KLFKDOGOCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6D824C0", Offset = "0x6D814C0", VA = "0x186D824C0")]
	private void IGOLFANIABB(Transform LNLOCMMGLOB, KLEDGFDFDON CECLKDDLGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6D839D0", Offset = "0x6D829D0", VA = "0x186D839D0")]
	public KLEDGFDFDON PJBCGLHODHP(string IEGKLHJGLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6D835D0", Offset = "0x6D825D0", VA = "0x186D835D0")]
	public void PEFLKODJBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6D82350", Offset = "0x6D81350", VA = "0x186D82350")]
	public float DPFNGLPHNJB([In] (KLEDGFDFDON Start, KLEDGFDFDON End) LKMPIPJBINE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D83430", Offset = "0x6D82430", VA = "0x186D83430")]
	public void MJFPDIGGIPN([In] KLDJADNODDC LNHGKEAKACI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D82390", Offset = "0x6D81390", VA = "0x186D82390")]
	private Vector3 EDIOJBJALGA([In] (KLEDGFDFDON Start, KLEDGFDFDON End) LKMPIPJBINE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D83A40", Offset = "0x6D82A40", VA = "0x186D83A40")]
	public DONANKAIBGH()
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
		[Cpp2IlInjected.Address(RVA = "0x6D820D0", Offset = "0x6D810D0", VA = "0x186D820D0")]
		public string PDIMFPDFNMC(string PNMFOMGLLCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D82120", Offset = "0x6D81120", VA = "0x186D82120")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum KDAFKEECBOA
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
public struct DCPCIMEHGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string GFJKEECDNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool MEMOJFNGLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool AGOBBGINCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public float DEIMCMPEDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float MJGPJKLJBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public KDAFKEECBOA IDGDFAIMPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Func<HKOKIGGHPCN> NFFJINDNPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Func<Vector3, KLDJADNODDC> JOHEODOJOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public RigidbodyEx MJJGJECKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public RigidbodyEx PAGIHPLPKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public RigidbodyEx ODFGOEPFOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public RigidbodyEx DPANHNPJHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform CELPBEFFPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform PDJHEPNGIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform KBGGEBOMJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform EAIEIPDEKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
	public PlayerAvatarModernBodyColliders OOCIDPILBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public SkinnedMeshRenderer[] MACMDGDKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public SkinnedMeshRenderer[] NDHDPEDDBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public SkinnedMeshRenderer[] LLEGCJHGIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public SkinnedMeshRenderer[] NIHEFJJMKAP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool LOGHFJCHMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C12A80", Offset = "0x6C11A80", VA = "0x186C12A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IGDHPKHGIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C12AB0", Offset = "0x6C11AB0", VA = "0x186C12AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6D821B0", Offset = "0x6D811B0", VA = "0x186D821B0")]
	public KLDJADNODDC KDFLLJCEGGE(Vector3 JBIIDDCPDMH)
	{
		return default(KLDJADNODDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HNKMHACJBEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public HEGHLNFMEGC IDGOFJLOIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform FAEDAADPHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform GIDFCAKNBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public AvatarConfiguration AOGJCJPENPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Animator LLELHKLICAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public VRIK KNBDIOLGNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public GameObject[] BJELKCPMNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Transform MIOHFAMILJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public AssetReference LEPBPDHODJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public GameObject DIJGPBGFICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject PGGIDAGGMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public SkinnedMeshRenderer JEGAOHKADON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public AvatarSkinnedMeshBoneOrderRemapsData LLGNMJPNIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Material NNCBLGAONNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Material GPDBKCABBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Material EHNCBLDEGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Shader EHKKDCIALAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Shader KLNEALMOJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform HDJHFBPLKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform KIDBICJDLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform HFGMLNACEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Transform KEFFHDLMNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Transform HKKLAJDPGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Transform OABLOCKPCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Transform GLKJOFFELGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Renderer[] LEPOLNJAFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Transform DMNEKKPOONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Transform ABHIJMHFAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public GameObject BFMMECNCKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public GameObject DKLPHGIGGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Transform LCIGDGECBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Transform NEMFOOFIDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Transform DGEJBENHPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public HEIFOMILKAA DBCNFOKKKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public HEIFOMILKAA OBKBNCOCHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public HEIFOMILKAA CHABGMAGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public HEIFOMILKAA LCOPEKINFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public HEIFOMILKAA LMNKGLGKJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public HEIFOMILKAA KKLBHDGIKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public HEIFOMILKAA FJKKONJMDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public HEIFOMILKAA GBFKOCMNDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public AvatarBodyPartShapesManager MGKPBMHACLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform CPKDDOALHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform OJJBPOHFODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform BBENOELFOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Transform FDMMGEDECFD;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HKOKIGGHPCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool GEKDFNBDDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public DJFOEHMHKBO ALGAEIOAICH;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KLDJADNODDC
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class HHFFIBCCBBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly bool FGOJDKKCGIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly bool FLNHNBBFANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly bool PEIMOCFOFLJ;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6D83F20", Offset = "0x6D82F20", VA = "0x186D83F20")]
		public HHFFIBCCBBL(bool IKMCCDGFNLH, bool OKMOCDENNBH, bool PEJDNOJAHNB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float EOELMMMOANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool POACDBIPDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float PCFGAMCHBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3 FFOMNNLPIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Vector3 CIBHEPDKIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Vector3? NJPFGMMHNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3? OBHCLBGOFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool CEAEIGOPMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool MEKJGBKLKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool GNCAJCGBLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool MFGFKOELKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Vector3? JHDMKPMIJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool NMBCMLECINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public Vector3? PPNEMMHADME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool LKDBANHAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Vector3? OOBKPJAJDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float PDGMJABJLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Vector3? JAACJKMICEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool JKPDCPCAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public bool DKENMJJMPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public bool MCHPGLMDOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool CLGMNGNFIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public bool GMKPLDPPHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public bool GHLDAPCMPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public bool FAGGJELCLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public bool IPGBJOLBHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public bool HEAKGAHGNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public bool JBEGCEFELOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public bool GAGMCHIFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Vector3? MCDLNGKKJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public PJHLCOJOHEC KLGLGLGOBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public PJHLCOJOHEC CKJLHJAFJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float OFJDPKEJKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public float NNBNPPHNMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public DOCMDIBFMFN KCFHNIPJEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public DOCMDIBFMFN HJALCKNBKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public bool GDPFHLNMODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public bool JBOEPAMBEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public bool MNBIHLPAMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public float LEONGFHDPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public float GMDGANJPKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public float ICOOPIPAANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public HHFFIBCCBBL KCCGOFJNCHO;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6D85080", Offset = "0x6D84080", VA = "0x186D85080")]
	public void NCCGHCGEIMD(Quaternion JKJHCABJJIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DAIIMAALNBO
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6D82170", Offset = "0x6D81170", VA = "0x186D82170")]
	public static PPEPNMKDOKP FIOJOPDOBDB(this KANBAKOHKIG GFJPFDOHONG)
	{
		return default(PPEPNMKDOKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6D82190", Offset = "0x6D81190", VA = "0x186D82190")]
	public static void HOAOBONJPDP(this KANBAKOHKIG GFJPFDOHONG, PPEPNMKDOKP BJDKOHEGDOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class OMPCJCLCKEB
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D85DE0", Offset = "0x6D84DE0", VA = "0x186D85DE0")]
	public static bool GIKIMOGLAFG(this LLHAHCOPPAC BMNHLLBGNPK, JGHFHJBGHPA BMLKMEAHKAO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HEIFOMILKAA
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float MLPBAIIBHBN);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class PlayerAvatarModernBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum EKDCLJGFHJE
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
		private NEGLEJLBGIL AIGOJLILIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private List<Collider> OIEOGOFEMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private List<Collider> JHMLNOIMBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private List<Collider> BOPAHKGDDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private EKDCLJGFHJE? KNFNNGMCOFP;

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
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] LLICDFCLMLH;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public IReadOnlyList<Collider> FLHMOJAAPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6D871E0", Offset = "0x6D861E0", VA = "0x186D871E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public IReadOnlyList<Collider> OAIDBHLIIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6D87200", Offset = "0x6D86200", VA = "0x186D87200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> BDEPPOFENJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6D87220", Offset = "0x6D86220", VA = "0x186D87220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private NEGLEJLBGIL PAGOJALOLMO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D86620", Offset = "0x6D85620", VA = "0x186D86620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JKJMGMAGOPI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB165A0", Offset = "0xB155A0", VA = "0x180B165A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6D86350", Offset = "0x6D85350", VA = "0x186D86350")]
		private void JDJLOJICILF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D86320", Offset = "0x6D85320", VA = "0x186D86320")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D871C0", Offset = "0x6D861C0", VA = "0x186D871C0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer DLDDBGGPFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D86E20", Offset = "0x6D85E20", VA = "0x186D86E20")]
		public void SetCollidersEnabled(EKDCLJGFHJE LNHGKEAKACI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6D86990", Offset = "0x6D85990", VA = "0x186D86990")]
		public void ReparentBonesUnderOtherBoneCollection(NEGLEJLBGIL EOBCOHHGJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6D866C0", Offset = "0x6D856C0", VA = "0x186D866C0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public PlayerAvatarModernBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class OCMJJNANHPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Transform EIELMJOLKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Transform MAEBGNABBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform KHAJOLCCCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Transform ICIJONKMBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform CKFGKJCJAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Transform GIBGDIEMNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform DPJAOFAPALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Transform LGHGGNAHLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform JBFKELJBFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PositionAndRotation GHDDHCOJOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private PositionAndRotation KCGJMLGNMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private PositionAndRotation JNHDNPKGFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PositionAndRotation NCHBLPADGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PositionAndRotation LLFNJDDNAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private PositionAndRotation HDOKJABNMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private PositionAndRotation ABKBMGFOBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private PositionAndRotation OONDDLGNKJI;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D856F0", Offset = "0x6D846F0", VA = "0x186D856F0")]
	public void CPDDJGLEDNE(Transform NCGEHGIGFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6D85900", Offset = "0x6D84900", VA = "0x186D85900")]
	public void DDAIKLBMCLH(HandLogicOffsets JBHBLHOAMMC, PGDNBCEICAP HGGBKOJLLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D854A0", Offset = "0x6D844A0", VA = "0x186D854A0")]
	public void CJAIBHOIPGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OCMJJNANHPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class PJCFIAKOBCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform PMEAEIMMCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform AJCDJKODOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Transform PMBGKAGFPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Transform CKAAPAOHCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private Transform BLFDPMEMNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private PositionAndRotation IHFIFHCANLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private PositionAndRotation KHBNJIJIIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private PositionAndRotation CJHAENMKCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private PositionAndRotation ECFDDJFIFBA;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6D85E60", Offset = "0x6D84E60", VA = "0x186D85E60")]
	public void CPDDJGLEDNE(Transform EIJJFFNCBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6D85F90", Offset = "0x6D84F90", VA = "0x186D85F90")]
	public void EEEILOLFFPO(HeadLogicOffsets DDIDCKOBMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D86190", Offset = "0x6D85190", VA = "0x186D86190")]
	public void HCOFNHENGIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public PJCFIAKOBCJ()
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
