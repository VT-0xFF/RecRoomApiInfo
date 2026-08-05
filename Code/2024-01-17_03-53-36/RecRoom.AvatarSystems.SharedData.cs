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
public enum FMFNILEHHBM
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
public struct DLMDMFEHFBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator ILPBJALOJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public DHLEAAFCIKG JINNOBJKHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration PFOIANPNNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject HLHLMJAHPNK;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LFOIMEDHNLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform NOBNPPNONMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool HKMAEIPPPNA;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NKFGJAKLHOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public FMFNILEHHBM? NPBLKCDHGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public FMFNILEHHBM? MPHNHBFOBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? AEGKCFECDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? LLMOKJADMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? IFKNKGKMAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? JEDIPJIDDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? IJKJMMDHACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? IDMCCKGDKDK;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DHLEAAFCIKG
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum HFPPAPEKKBH
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	OBSOLETE_CannedWave,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	OpenHand
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Quaternion Rotation;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PositionAndRotation WatchMenuOriginOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AEGDCKIJACJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly string FHADHMPOBKN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EF59A0", Offset = "0x5EF47A0", VA = "0x185EF59A0")]
	public static CNEADJPKDCJ IFIFIFIKNGF()
	{
		return default(CNEADJPKDCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5CA0", Offset = "0x5EF4AA0", VA = "0x185EF5CA0")]
	public static JENPHKAJKFO NHCABIIEMIO(Transform LEAKIOKLJGK, Transform LPANPFFGHAN, AvatarConfiguration JGHPKNDDJKE, Animator JGABJCCJOOJ, VRIK KMOIIFHMKKJ, GameObject[] HKDMJCDIOOO, Transform BCKAPODLONJ, AssetReference NGNMCPEFDIM, GameObject KCCCFIJPJNC, GameObject GMOFLDIJNIN, SkinnedMeshRenderer HFKDBIDKJHM, Material BPCPADIDMNC, Material GBDCKGFGFFG, Material NFLMOJHBBBJ, Shader OALCLHIHJJC, Shader OKGOEAPPPAM, Transform PLELNLFHHKB, Transform CBIKPCGPJJH, Transform JEFOJDGCNOG, Transform NMELDBAHFHF, Transform AGCOPLAMJPH, Transform NHPIJAIMAMK, Transform AAAMIPEIAGJ, Renderer[] KAPMJKOGBIA, IINMNPKDIPA IGDPLIHPBPO, IINMNPKDIPA HOMNKILOKMM, IINMNPKDIPA OAKHDAGMCIJ, IINMNPKDIPA MOIGBLHPAAF, IINMNPKDIPA PBCHCLFEIHN, IINMNPKDIPA EADIEFBFCKC, IINMNPKDIPA DFFCGALADHJ, IINMNPKDIPA KKDAKEJHCCG, Transform NJEAGJMNMEA, Transform JMPPCBFHCNK, GameObject GCINDHKIKAL, GameObject ABPKJIDOFCA)
	{
		return default(JENPHKAJKFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5B60", Offset = "0x5EF4960", VA = "0x185EF5B60")]
	public static IPOAGMGLKNF NGMICEIDGKJ(string NCIHLIMMJKL, bool IFOHCGHCHFN, bool FCPBEBGFIKI, bool JCPKDGNKPCB, Func<PHLDINKIJKH> AGKNDHBFHMA, Func<CNEADJPKDCJ> OJNFCMGBFML, RigidbodyEx LJOFCHIMMOE, RigidbodyEx NANOMAMBDCN, RigidbodyEx OGJPBFODCDL, RigidbodyEx LOKLDMODKHI, Transform HNBANCIIDHB, Transform FEGJPDLCJLK, Transform CKGCKPIBKFB, float DGNGBOGLNJO, float BCCOAEEPPBA, PlayerAvatarFullBodyColliders CPLIGKNKBGK)
	{
		return default(IPOAGMGLKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6040", Offset = "0x5EF4E40", VA = "0x185EF6040")]
	public static BACFKINFBKA OENPNFJGFML(Transform LPANPFFGHAN, AssetReference NGNMCPEFDIM, GameObject KCCCFIJPJNC, GameObject GMOFLDIJNIN, SkinnedMeshRenderer HFKDBIDKJHM, Material BPCPADIDMNC, Material GBDCKGFGFFG, Material NFLMOJHBBBJ, Shader HEKCOAHLGKA, Shader JEALKNJJGLK, Animator IOCPBBMOOPP, Renderer[] KAPMJKOGBIA, AvatarConfiguration CIGDKGDLEMI)
	{
		return default(BACFKINFBKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5A90", Offset = "0x5EF4890", VA = "0x185EF5A90")]
	public static KHMKOBPDCGE LOIBKDFPJIA(Transform PLELNLFHHKB, Transform JEFOJDGCNOG, Transform CBIKPCGPJJH, Transform NMELDBAHFHF, Transform AGCOPLAMJPH, Transform NHPIJAIMAMK, Transform AAAMIPEIAGJ, AvatarConfiguration JGHPKNDDJKE)
	{
		return default(KHMKOBPDCGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13DAAA0", Offset = "0x13D98A0", VA = "0x1813DAAA0")]
	public static IKEOKHONKJG CBDODJILEMD(SkinnedMeshRenderer[] LPCINBJPKON)
	{
		return default(IKEOKHONKJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EF59E0", Offset = "0x5EF47E0", VA = "0x185EF59E0")]
	public static FBOHEEBBBHE JHKPCLNNJGN(EDMFFDJIEDG AIEEPGABOLD, int AFGOGHBAAEA, int OIDJJOANDCA, Color DENNGFBKMBO, Color LDDBBAJPAGF, int CGMKICJIGCE, int MBPFAAAHPGP, Color JGCLHPANGAL, Color OCGMFJMNHIF, int NEBFLJPJDGM, float EEDJMDDJBNG)
	{
		return default(FBOHEEBBBHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EF57F0", Offset = "0x5EF45F0", VA = "0x185EF57F0")]
	public static KENFNBIBLPK BDBLJHKANIE(EDMFFDJIEDG AIEEPGABOLD, Vector2 LENECDEALHN, float GEBKIDCDCEO, Vector2 HCHAMLKDKMI, float COJJHNAKJFL, Vector2 MHJINALHBNG, float JIHPGCADPJP, Vector2 EIGOLPGIJGB, float OPLKMMMFOHF)
	{
		return default(KENFNBIBLPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EF58A0", Offset = "0x5EF46A0", VA = "0x185EF58A0")]
	public static DLMDMFEHFBE CGGHPKDAILD(Animator NPLBNABNGBO, DHLEAAFCIKG BOLNBJCABJL, AvatarConfiguration CIGDKGDLEMI, GameObject MODBPJBKLDA)
	{
		return default(DLMDMFEHFBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5910", Offset = "0x5EF4710", VA = "0x185EF5910")]
	public static LFOIMEDHNLH EAAOAGMNIEF(Transform MAKCIOGBLJP, bool FCPBEBGFIKI)
	{
		return default(LFOIMEDHNLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5950", Offset = "0x5EF4750", VA = "0x185EF5950")]
	public static NKFGJAKLHOM GIGJLGDDFPO([Optional] FMFNILEHHBM? CEKNGHCGPOE, [Optional] int? GIBEHKFEHMM, [Optional] float? IGAOFAIGKEB, [Optional] float? DBINIFJAOOD, [Optional] bool? NEMBPKLHIFM, [Optional] bool? BGFNEHBDMIM, [Optional] bool? ADAIFJHACCF, [Optional] FMFNILEHHBM? CJBMONFKNPE)
	{
		return default(NKFGJAKLHOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AGFPEOCJCIP
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF61E0", Offset = "0x5EF4FE0", VA = "0x185EF61E0")]
	public static FMFNILEHHBM CIMMLGIGAHJ(this HFPPAPEKKBH PAKHDDEOMDA)
	{
		return default(FMFNILEHHBM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DOBGJEOMHBD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EANEIJAAAEP : DOBGJEOMHBD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78E1A0", Offset = "0x78CFA0", VA = "0x18078E1A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 KFPIEEOKCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCCDE40", Offset = "0xCCCC40", VA = "0x180CCDE40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCCDE80", Offset = "0xCCCC80", VA = "0x180CCDE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? HAMHNDNAPBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCCDE60", Offset = "0xCCCC60", VA = "0x180CCDE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCCDE70", Offset = "0xCCCC70", VA = "0x180CCDE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public EANEIJAAAEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IIAHAJPLENB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	protected readonly EANEIJAAAEP IBFLNACDGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	protected readonly EANEIJAAAEP ANKGNNLMDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	protected readonly EANEIJAAAEP EHOEKHGIFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	protected readonly EANEIJAAAEP DDJBLPOIDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected readonly EANEIJAAAEP IDJNEMCGCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected readonly EANEIJAAAEP IFFFKBPBEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected readonly EANEIJAAAEP KKOBPKCBEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected readonly EANEIJAAAEP JEAPFLOICCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected readonly EANEIJAAAEP NMNGECNNCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly EANEIJAAAEP EFFJEDPPKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly EANEIJAAAEP OMCGHMMKJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly EANEIJAAAEP KKHKPOBPGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly EANEIJAAAEP LEONBIMPFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected EANEIJAAAEP NPFAGFHLLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly EANEIJAAAEP LONMADEEBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly EANEIJAAAEP KNDJJMACJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly EANEIJAAAEP GFKBMAGFCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected EANEIJAAAEP OMEEKLGNCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly EANEIJAAAEP OMOLCBFILNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly EANEIJAAAEP NAPBFPAFMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly EANEIJAAAEP FJLJBGLFHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected ReadOnlyCollection<EANEIJAAAEP> APHPPOAADKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Transform BCKAPODLONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private (EANEIJAAAEP Start, EANEIJAAAEP End)[] LOBAEMAPJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Dictionary<string, EANEIJAAAEP> LKKEMEBPHCE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DOBGJEOMHBD BAHGOGIBNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DOBGJEOMHBD JMOCIBGBMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DOBGJEOMHBD GBOILMPMJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DOBGJEOMHBD AJLLEDBBFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x78E2A0", Offset = "0x78D0A0", VA = "0x18078E2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DOBGJEOMHBD AFLNOEHONEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DOBGJEOMHBD KINBLBADMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x78E1F0", Offset = "0x78CFF0", VA = "0x18078E1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EANEIJAAAEP JJKHDEDEBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x78E1F0", Offset = "0x78CFF0", VA = "0x18078E1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EANEIJAAAEP JMELPJIANFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78E0D0", Offset = "0x78CED0", VA = "0x18078E0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public DOBGJEOMHBD KALOHFCPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78D1A0", Offset = "0x78BFA0", VA = "0x18078D1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public DOBGJEOMHBD KIGICKGBGAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78D1E0", Offset = "0x78BFE0", VA = "0x18078D1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EANEIJAAAEP MOJBNGAIMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78D1E0", Offset = "0x78BFE0", VA = "0x18078D1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EANEIJAAAEP PDKOAKPOHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78E210", Offset = "0x78D010", VA = "0x18078E210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public DOBGJEOMHBD NJLCOFGEHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x78E0C0", Offset = "0x78CEC0", VA = "0x18078E0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EF69D0", Offset = "0x5EF57D0", VA = "0x185EF69D0")]
	public void KHMLFBPLJKJ(VRIK ONLAKLCBIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6750", Offset = "0x5EF5550", VA = "0x185EF6750")]
	private void AHLLHFGNKAK(Transform LGDFGELLOEL, EANEIJAAAEP KEENMLGJEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7A50", Offset = "0x5EF6850", VA = "0x185EF7A50")]
	public EANEIJAAAEP LALLPCMKFDK(string HCBIBBPNFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7AC0", Offset = "0x5EF68C0", VA = "0x185EF7AC0")]
	public void MJOBJGOHHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6900", Offset = "0x5EF5700", VA = "0x185EF6900")]
	public float IFGBGKCEFBC([In] (EANEIJAAAEP Start, EANEIJAAAEP End) NOODNJOFEFN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EF78B0", Offset = "0x5EF66B0", VA = "0x185EF78B0")]
	public void KOKEJOEPFGF([In] CNEADJPKDCJ AEMBMKHDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EF67E0", Offset = "0x5EF55E0", VA = "0x185EF67E0")]
	private Vector3 GEPHJFNADOF([In] (EANEIJAAAEP Start, EANEIJAAAEP End) NOODNJOFEFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7F70", Offset = "0x5EF6D70", VA = "0x185EF7F70")]
	public IIAHAJPLENB()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6240", Offset = "0x5EF5040", VA = "0x185EF6240")]
		public string ENJKBJBAHHL(string IIAPKDLEDKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6290", Offset = "0x5EF5090", VA = "0x185EF6290")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IPOAGMGLKNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public string EDGDDADLNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool HKMAEIPPPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public bool PKEDBPEGHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float JIKFPLLJDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float GNNCOHIGCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool LICKDCJHMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Func<PHLDINKIJKH> KIJEEIKDGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Func<CNEADJPKDCJ> IMMLEFHCEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public RigidbodyEx DLHOFHOHFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public RigidbodyEx GCPJMHKAGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public RigidbodyEx IMOJFCBGKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public RigidbodyEx LBCGBJAJAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Transform MEOCPIDKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Transform MDOJLOMAGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public Transform GGCLBLKEJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public PlayerAvatarFullBodyColliders LEJLDBGBOHA;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JENPHKAJKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Transform GKHLOHJGEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform IFEICBPKONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public AvatarConfiguration PFOIANPNNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Animator EBMGGJFLGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public VRIK EBNFGOBAGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public GameObject[] LMKLPEDNMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform LHDEOEJKHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public AssetReference EHCNDMMMHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public GameObject LDIKODDHCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public GameObject LMHOHOMABHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer HKBAOGCHKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Material FAGECDOAPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Material NFDDAILINEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Material JCLDHHICOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Shader DBBJCGMCBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Shader ADPGPHMOEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Transform IOLFMALJAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Transform JIFLGCJBJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform HCKMKOJBNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform OGILLKOCJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform AJBNDAKFKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Transform PHIHFPEOLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Transform EAGFBCFJDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Renderer[] LANPOACOIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Transform GKPFADBMGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Transform HHKBOGIHDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public GameObject APFJPMLOJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public GameObject DPENGAPOPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public IINMNPKDIPA CKLCPMGJNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public IINMNPKDIPA ELFEOMKHFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public IINMNPKDIPA GJNMBJNIAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public IINMNPKDIPA DHHHLJNBPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public IINMNPKDIPA IJAOPCFEPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public IINMNPKDIPA JBFGPCAGNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public IINMNPKDIPA LPDINCNIHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public IINMNPKDIPA PMFGIJHCIAO;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PHLDINKIJKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool MLBBLPCKKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public DBLNOAOKDFO NEGCFCLBNHI;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct CNEADJPKDCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class EBAPDEPLNDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly bool KHDPKDAHNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly bool KKKHBJLNPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly bool CHJPGBGNDMB;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6700", Offset = "0x5EF5500", VA = "0x185EF6700")]
		public EBAPDEPLNDC(bool HCLAOKNGLPP, bool IFNKFNKJBHN, bool KFNNELNOHPC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float LNLMNMMPJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool ILHHENMHMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public float GNFBALJCKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3 KPCLGFGBDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 MPPBCNLECPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Vector3? LNEFLBBHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Vector3? DGKJFMGCMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public bool DDFFOCKFJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool EIAOHIMIBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public bool KPNFIDGAADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public bool FBEJNMDBBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Vector3? MKLGEGLGEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool FDIKJOFCCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Vector3? OPOEFBLJGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool FEGBAPJEOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Vector3? MLEPNDMIJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public float ONEHJGLIENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3? NOJAOEGNIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public bool OFBLELGIPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public bool KBCHDCHLPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool GOOGJDBELIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool IAPBGBOIAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool NINHFFDIPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool DJCFJHKNJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool HLGEIBBJBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool GIJHAKEDDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool MOEHLGPLJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool APCCGHNHJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public bool MLDEOLGPCJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3? CMJHIGOBBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public HFPPAPEKKBH CEOLNFIOCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public HFPPAPEKKBH IHJJDKKKJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public float HBBPDDCJMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public float KEDOBKJDBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public EBAPDEPLNDC HDODKOABEAK;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF62E0", Offset = "0x5EF50E0", VA = "0x185EF62E0")]
	public void NNGEJHLDLIM(Quaternion NJBEEEBFFMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OEAFPBAHBKL
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9680", Offset = "0x5EF8480", VA = "0x185EF9680")]
	public static EAPIFMMNJHB AKFIOFNHLNE(this ENINIMKGFJC OJFDNDCDDBK)
	{
		return default(EAPIFMMNJHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EF96A0", Offset = "0x5EF84A0", VA = "0x185EF96A0")]
	public static void FOAJLJPAALA(this ENINIMKGFJC OJFDNDCDDBK, EAPIFMMNJHB MBDKMNBCLGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IINMNPKDIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float BLFDEPDEIPK);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private LKFGDJCJLKP CHKCLCHLEBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private Collider[] HEHBHGAIGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] ALONIDPIBFH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> MELNMFGNNNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5EFA0A0", Offset = "0x5EF8EA0", VA = "0x185EFA0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private LKFGDJCJLKP CACMNHBCBHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5EF96C0", Offset = "0x5EF84C0", VA = "0x185EF96C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool JNPOGKGJGMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCA0F50", Offset = "0xC9FD50", VA = "0x180CA0F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA080", Offset = "0x5EF8E80", VA = "0x185EFA080")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer IHJJNDKJGFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9E30", Offset = "0x5EF8C30", VA = "0x185EF9E30")]
		public void SetCollidersEnabled(bool PDBPIJFLAJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9A00", Offset = "0x5EF8800", VA = "0x185EF9A00")]
		public void ReparentBonesUnderOtherBoneCollection(LKFGDJCJLKP ALINHANNFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9760", Offset = "0x5EF8560", VA = "0x185EF9760")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LNGEMFOCFKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Transform JAPGFPKFABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Transform JMJJOFPGCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Transform NHEFBKJDMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Transform LAENMBBFAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform HPKKMCGGMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform LGLEMNBLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform FNJLNFHNPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Transform DFOAKNCNOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Transform HOHJKAGMIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PositionAndRotation EOBMPEHHNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation EGPCIINGEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private PositionAndRotation LBFELLFOLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PositionAndRotation FMPBLBOAHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private PositionAndRotation DHBPEKLBKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private PositionAndRotation MHONLCHOFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private PositionAndRotation EGKNNANOPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PositionAndRotation NOCJOODENDF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8720", Offset = "0x5EF7520", VA = "0x185EF8720")]
	public void CGDOOEBPPMG(Transform DBCHEMMBOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8DE0", Offset = "0x5EF7BE0", VA = "0x185EF8DE0")]
	public void FDFMIMAMAND(HandLogicOffsets EGEIDAMEHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9360", Offset = "0x5EF8160", VA = "0x185EF9360")]
	public void LPILJOJOCJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF95B0", Offset = "0x5EF83B0", VA = "0x185EF95B0")]
	private PositionAndRotation MJHDDFCPGOB(Transform JJJNNOPIPAJ, Transform PIDDBPMMNMI)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8450", Offset = "0x5EF7250", VA = "0x185EF8450")]
	private void CDBOJGLGLNL(Transform JJJNNOPIPAJ, Transform PIDDBPMMNMI, PositionAndRotation EGEIDAMEHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public LNGEMFOCFKA()
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
