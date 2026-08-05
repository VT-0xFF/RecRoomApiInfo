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
public enum BBBNIHJOJMN
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
public struct FPJNPNIHHEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator NKKJBLOOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public DOIEKAPMIIJ JCJECMLHOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration OFCAPGMFNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject BLAKMKDLHFK;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ENJCCNICECL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform BOOIDLJFEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool GLNPDKEIHCO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PEFCLMLGCKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public BBBNIHJOJMN? CNMBOGMLJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public BBBNIHJOJMN? EGDCMKCJNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? AFIKBKBEGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? OFLENEOHJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? LHHCBNOMPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? LGOBHAHEDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? HBBIOHFOAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? GFDIJHIAMDO;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DOIEKAPMIIJ
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JLMNBAKIELL
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	OBSOLETE_CannedWave = 1000
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PositionAndRotation WatchMenuOriginOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NLCKNHGKBDP
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly string CKBPCHHLAPG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x602E290", Offset = "0x602CE90", VA = "0x18602E290")]
	public static NNLIOPCOPAE NNANKMKFHNJ()
	{
		return default(NNLIOPCOPAE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x602E2D0", Offset = "0x602CED0", VA = "0x18602E2D0")]
	public static NIEHJAFDFPL NOHGIIHINKI(Transform KPJEKNECPLO, Transform CLELGKLPIOF, AvatarConfiguration EHHOCGIGAAD, Animator JGNHOHBHBKJ, VRIK KHNBKNKLGDO, GameObject[] ODBLKOOKBAJ, Transform DKCPAHHCOBM, AssetReference JAMEIBGBLDN, GameObject HDNEIIKKLDE, GameObject PIDOEMCGICF, SkinnedMeshRenderer LCOMHOALGHK, Material MMBJCOIJGHP, Material BMJNICNPOAG, Material BNDLLPGPPBO, Shader HGBFGPDFAMP, Shader NHFOILFAFPO, Transform GFIPPNIEAKH, Transform KIPBHNOHNGC, Transform MGLNMNAODJI, Transform BIFAIMFBEIM, Transform BFDOPIMADIM, Transform PDKFJDJDINI, Transform KPLPCFONNIB, Renderer[] AJOJCOOPJMK, NCAIEEHOMEO GENAGLKOBHC, NCAIEEHOMEO FFOOJPPEFOB, NCAIEEHOMEO GECCCCHJLKN, NCAIEEHOMEO IMLEELCDKGB, NCAIEEHOMEO OFCEKMAOHGP, NCAIEEHOMEO GANMCONHICP, NCAIEEHOMEO PPIOEKPMBAA, NCAIEEHOMEO CKJJOICJIHO, Transform OAMMOPNLDBK, Transform BHLDHHEKGFF, GameObject CLLLJDBCFEJ, GameObject JJILDAHKGIG)
	{
		return default(NIEHJAFDFPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x602DE70", Offset = "0x602CA70", VA = "0x18602DE70")]
	public static DINCCMCODNK EAADBNDBDFE(string GLIOIMAEIJG, bool JNAKIGNKKCE, bool MFKDGJDAGPE, bool OIMEBEOHFPL, Func<BJPLGHBNMPE> DEKJHGFPKML, Func<Vector3, NNLIOPCOPAE> HEHCPFHCMHF, RigidbodyEx AOEPBGMCBDG, RigidbodyEx IGOOFEPKMDA, RigidbodyEx NBPIKAFHFGF, RigidbodyEx IHOMPNNMBAG, Transform MHEAMOBMOFD, Transform FFFFFIHGHPL, Transform NPCMPIJAFIJ, float CDHECDIGOGG, float JHNCNPJKIBC, PlayerAvatarFullBodyColliders AAIGCKKOFOB, SkinnedMeshRenderer[] NJCDMDFHGAE, SkinnedMeshRenderer[] DDJBAFFPMHG, SkinnedMeshRenderer[] FGOKBAKLNCP, SkinnedMeshRenderer[] HEPODKPOEHG)
	{
		return default(DINCCMCODNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x602E0E0", Offset = "0x602CCE0", VA = "0x18602E0E0")]
	public static PPNGGMMHJEA HNJFOIMJBGE(Transform CLELGKLPIOF, AssetReference JAMEIBGBLDN, GameObject HDNEIIKKLDE, GameObject PIDOEMCGICF, SkinnedMeshRenderer LCOMHOALGHK, Material MMBJCOIJGHP, Material BMJNICNPOAG, Material BNDLLPGPPBO, Shader KIMNBEHCFGA, Shader JKLODGFIOIE, Animator NGOOCOLOKGM, Renderer[] AJOJCOOPJMK, AvatarConfiguration BBFACDHGJAM)
	{
		return default(PPNGGMMHJEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x602E210", Offset = "0x602CE10", VA = "0x18602E210")]
	public static JEGOFEKFJKJ LOMDJJPBFAD(SkinnedMeshRenderer[] NJCDMDFHGAE, SkinnedMeshRenderer[] DDJBAFFPMHG, SkinnedMeshRenderer[] FGOKBAKLNCP, SkinnedMeshRenderer[] HEPODKPOEHG)
	{
		return default(JEGOFEKFJKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x602E010", Offset = "0x602CC10", VA = "0x18602E010")]
	public static EDNGEAPGAFO HJAEAJEIBDI(Transform GFIPPNIEAKH, Transform MGLNMNAODJI, Transform KIPBHNOHNGC, Transform BIFAIMFBEIM, Transform BFDOPIMADIM, Transform PDKFJDJDINI, Transform KPLPCFONNIB, AvatarConfiguration EHHOCGIGAAD)
	{
		return default(EDNGEAPGAFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x14E45E0", Offset = "0x14E31E0", VA = "0x1814E45E0")]
	public static PJANNKOEDIL IKHPDMMACKM(SkinnedMeshRenderer[] MDGJBHLFKJL)
	{
		return default(PJANNKOEDIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x602DD80", Offset = "0x602C980", VA = "0x18602DD80")]
	public static NMIOBLCACFJ CJEPKBOEJGH(CNEOIDFKNGA KGMFKMIOIAK, int CHCNANIFFDA, int NODPOPIFJCG, Color HAOGKFGADNM, Color CCAJFANKOCN, int FGGABGMJAGK, int FDNNGALJJCE, Color OPAMCKBHJCK, Color ONHNMNOBCLM, int HLKCKFKCIEA, float FIKPIFFBOOE)
	{
		return default(NMIOBLCACFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x602E670", Offset = "0x602D270", VA = "0x18602E670")]
	public static OOJGOJECIBM PDIBJKLJNOK(CNEOIDFKNGA KGMFKMIOIAK, Vector2 LBHCDHMGIFJ, float LOBMEOJOJDF, Vector2 KGKKKOHBDNF, float IBKEENDNADH, Vector2 PONENPLMAJK, float FEEBILCGAFL, Vector2 CNHEFNNFEDI, float CBJBJENDHLM)
	{
		return default(OOJGOJECIBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x602DCC0", Offset = "0x602C8C0", VA = "0x18602DCC0")]
	public static FPJNPNIHHEC AFKBJGLFKJO(Animator EEOIIKPCBHG, DOIEKAPMIIJ GPNPILIBCGE, AvatarConfiguration BBFACDHGJAM, GameObject NPALEMOJPHN)
	{
		return default(FPJNPNIHHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x602DE30", Offset = "0x602CA30", VA = "0x18602DE30")]
	public static ENJCCNICECL CNICIELHCNK(Transform ONLCFOFLPPN, bool MFKDGJDAGPE)
	{
		return default(ENJCCNICECL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x602DD30", Offset = "0x602C930", VA = "0x18602DD30")]
	public static PEFCLMLGCKB BLBFLJLJPKM([Optional] BBBNIHJOJMN? OLDNEFHIOKD, [Optional] int? OCAGEHKHAMF, [Optional] float? MLDJBGCJBHD, [Optional] float? PCFHMOGBFAA, [Optional] bool? DHPHGINBNFD, [Optional] bool? OCGLGEOIOID, [Optional] bool? KHLCEIAMLDF, [Optional] BBBNIHJOJMN? MIEBEFLGIKP)
	{
		return default(PEFCLMLGCKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HANFOIJMOEB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x602C740", Offset = "0x602B340", VA = "0x18602C740")]
	public static BBBNIHJOJMN NLILAGKKKNG(this JLMNBAKIELL AEOKBIGIIFJ)
	{
		return default(BBBNIHJOJMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x602C730", Offset = "0x602B330", VA = "0x18602C730")]
	public static bool LCLMACDADDB(this JLMNBAKIELL KNADKOFECPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EJMBNEBCBCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HGMCFCDDMJF : EJMBNEBCBCL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform OAKAFONNBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B0C80", Offset = "0x7AF880", VA = "0x1807B0C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 FBBFMPMEDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD67AC0", Offset = "0xD666C0", VA = "0x180D67AC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD67A90", Offset = "0xD66690", VA = "0x180D67A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? GGFMBMNPFGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD67AB0", Offset = "0xD666B0", VA = "0x180D67AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD67AA0", Offset = "0xD666A0", VA = "0x180D67AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public HGMCFCDDMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OPPEBKJHBNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly HGMCFCDDMJF MDDOOBFEAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly HGMCFCDDMJF EBMHPEOMMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly HGMCFCDDMJF CFNIPAOGHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly HGMCFCDDMJF HDCMMCGNMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected readonly HGMCFCDDMJF GHCFMHFAOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly HGMCFCDDMJF FEOMIIIOOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly HGMCFCDDMJF HFOKOAALLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly HGMCFCDDMJF MEGPMFCIAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected readonly HGMCFCDDMJF FGJPDDKBGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly HGMCFCDDMJF GIGGAFELCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly HGMCFCDDMJF PEGDFEIHHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly HGMCFCDDMJF KAFANKDCCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected readonly HGMCFCDDMJF NGPGGCOFFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected HGMCFCDDMJF HFEIHDJFLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly HGMCFCDDMJF PJENLIOGNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly HGMCFCDDMJF HGCLGMPOLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly HGMCFCDDMJF OADLKDJIGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected HGMCFCDDMJF GJJPGIPFLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly HGMCFCDDMJF PEHOCGHKEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly HGMCFCDDMJF PFGEHFCMENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly HGMCFCDDMJF HHJKIBIJBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected ReadOnlyCollection<HGMCFCDDMJF> OPMOIEINHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform DKCPAHHCOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private (HGMCFCDDMJF Start, HGMCFCDDMJF End)[] ODLEAMNJHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, HGMCFCDDMJF> NHBGPOLFOJP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EJMBNEBCBCL EJDLJOBCOOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFAE0", VA = "0x1807B0EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EJMBNEBCBCL GPBGDKMDMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EJMBNEBCBCL FELGHGLIFIO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EJMBNEBCBCL HNNKPAKAMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B60", Offset = "0x7B1760", VA = "0x1807B2B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public EJMBNEBCBCL OIEEHIDNKFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public EJMBNEBCBCL FKJJPMEBGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B50", Offset = "0x7B1750", VA = "0x1807B2B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public EJMBNEBCBCL OGHMCJIODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7990", Offset = "0x7B6590", VA = "0x1807B7990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public EJMBNEBCBCL LMPBIBPLILC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A10", Offset = "0x7B6610", VA = "0x1807B7A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EJMBNEBCBCL CGNFKNLMKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B79F0", Offset = "0x7B65F0", VA = "0x1807B79F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x602F430", Offset = "0x602E030", VA = "0x18602F430")]
	public void OBFPFAEDPGG(VRIK PGLLLCHDLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x602F1B0", Offset = "0x602DDB0", VA = "0x18602F1B0")]
	private void GMFLJOBBFLE(Transform KNENCIBJOEN, HGMCFCDDMJF PMKKKDOAOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x602EC00", Offset = "0x602D800", VA = "0x18602EC00")]
	public HGMCFCDDMJF AMPENMGNAIP(string CBEGJCLGJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x602EC70", Offset = "0x602D870", VA = "0x18602EC70")]
	public void EKJFAPBMBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x602F240", Offset = "0x602DE40", VA = "0x18602F240")]
	public float MCJOEICOLND([In] (HGMCFCDDMJF Start, HGMCFCDDMJF End) PIAPFFMNLHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x602F280", Offset = "0x602DE80", VA = "0x18602F280")]
	public void MGNNIMGELIP([In] NNLIOPCOPAE KAADEKGDAHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x602F080", Offset = "0x602DC80", VA = "0x18602F080")]
	private Vector3 GBBKKCPNBJA([In] (HGMCFCDDMJF Start, HGMCFCDDMJF End) PIAPFFMNLHP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6030310", Offset = "0x602EF10", VA = "0x186030310")]
	public OPPEBKJHBNG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x602C500", Offset = "0x602B100", VA = "0x18602C500")]
		public string ADKMBJIKEFP(string NJBIEMOKHOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x602C550", Offset = "0x602B150", VA = "0x18602C550")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DINCCMCODNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string COOFHEPLKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool GLNPDKEIHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool BGDLLCKPDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float AHDHPPACJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float MMNOOMCLHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool DPNDPPBIFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public Func<BJPLGHBNMPE> ODFPMHPFHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Func<Vector3, NNLIOPCOPAE> EODODCCPMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public RigidbodyEx GMKLLLCKCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public RigidbodyEx BOJDCDCNODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public RigidbodyEx MKDHOOJJFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public RigidbodyEx HFOJJEDEIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Transform MMLCAELIHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform FHKMDKOAMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Transform NFKPJNFDNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PlayerAvatarFullBodyColliders PMPHGKMMDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public SkinnedMeshRenderer[] GPFKLGHDMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer[] HJIMIFGMJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public SkinnedMeshRenderer[] LJGKDJNPCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public SkinnedMeshRenderer[] HIHPAANKKEL;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x602C5A0", Offset = "0x602B1A0", VA = "0x18602C5A0")]
	public NNLIOPCOPAE EKAJAIIOALF(Vector3 LPHAAEHFJOO)
	{
		return default(NNLIOPCOPAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct NIEHJAFDFPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Transform IBPIGCJCHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Transform CFGDCAMEJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public AvatarConfiguration OFCAPGMFNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Animator KMLOEICJMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public VRIK MOMLANDHBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GameObject[] OCGKPEMBCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform LIALNDCHJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AssetReference BKOMAFDHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public GameObject BBMEMJELNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public GameObject AHMELDAHEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer EBLJFAGECIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Material LGEDHGKFEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Material PENFMHMOHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Material EMPMGBKMKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Shader FLOCOGJCMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Shader OKOPEFPJHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform BMKONJBAMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform CFJOOOLLFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform ELDIOKDBEPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform BAFCKOJNGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform EOOMFFIMDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform HLPBLEIMJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform DIKCOOHBICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Renderer[] IAJKFFDOFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform CPOCCCDHHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform MOKIFCIFDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public GameObject HNIHJENHPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GameObject KPIEKPICJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NCAIEEHOMEO ONMJOBBLNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public NCAIEEHOMEO LGLPLLPNNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NCAIEEHOMEO APMAIFHNAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public NCAIEEHOMEO APGHEDAHIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public NCAIEEHOMEO OGHPKKKJPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public NCAIEEHOMEO HMNAEHHLAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NCAIEEHOMEO LHOKFLANDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NCAIEEHOMEO EODNKLJCGCO;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BJPLGHBNMPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public bool OOFMCPEKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public FPPFILBLGKN DKJJFKAEJHP;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NNLIOPCOPAE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class OINPJOKCCCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly bool HIDLEEFEKIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly bool LKNLPHNPOEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly bool IENAJLBCDHE;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x602EBB0", Offset = "0x602D7B0", VA = "0x18602EBB0")]
		public OINPJOKCCCI(bool FDIANNMAFBK, bool PMACANHMAJD, bool LJPEBHLDJMB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float HMEIHLDBNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool KGFDIMLKOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float DMIKCLFCNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Vector3 CBOFCOOECEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3 NJLKPPENFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Vector3? JBMMIIJAIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Vector3? OEBJOECDMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool GBIBJLFEHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool LFCGADBEJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool CPIACJOGAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool BMMONNNBKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3? IKIMAAAEIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool IJDDJIJJLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? HPGFOMBKLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool EDOADAGFLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Vector3? FBCLIACIGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public float JBGDNFLEDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3? IFMKLGGGMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DMMGBAMMPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool BAJGANNGGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool EOBJCIPNIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool PLJOHGOBDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool LLGNFEJNFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DJHCBNHICJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool CMMKMJMGEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool AMKBGIDDHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool ONOBDNDFDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool APNJJAHOJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool PMIBGDFEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? FOGAKPAHFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public JLMNBAKIELL IEBJDPJEMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public JLMNBAKIELL ANLJCCAHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool ENIMKGEECFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool CEDPJJACBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public OINPJOKCCCI FMPDKJNIHEJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x602E790", Offset = "0x602D390", VA = "0x18602E790")]
	public void ICIGEOCIFLL(Quaternion MJCNDCDLGEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LOEPODNCMAL
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x602DC80", Offset = "0x602C880", VA = "0x18602DC80")]
	public static ANHEOJDHDHN BBFDPDMCHEA(this HHBHIEFEFMD NOLNJDLEMAA)
	{
		return default(ANHEOJDHDHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x602DCA0", Offset = "0x602C8A0", VA = "0x18602DCA0")]
	public static void IELPJFFFOFN(this HHBHIEFEFMD NOLNJDLEMAA, ANHEOJDHDHN BLKAHBIJBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NCAIEEHOMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float HINGOJPJBCE);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private FIJAAKJMKFP PPEOIKIEBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Collider[] HMEIDLKGFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] EFNLJLJPIBD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> CBEBGMMJJFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x60311D0", Offset = "0x602FDD0", VA = "0x1860311D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private FIJAAKJMKFP NMEHIBPACEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x60307F0", Offset = "0x602F3F0", VA = "0x1860307F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OKCKOAAFFED
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD4CCF0", Offset = "0xD4B8F0", VA = "0x180D4CCF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60311B0", Offset = "0x602FDB0", VA = "0x1860311B0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer LFOGGANOEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6030F60", Offset = "0x602FB60", VA = "0x186030F60")]
		public void SetCollidersEnabled(bool OOAKOKIGOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6030B30", Offset = "0x602F730", VA = "0x186030B30")]
		public void ReparentBonesUnderOtherBoneCollection(FIJAAKJMKFP FCABJJPDHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6030890", Offset = "0x602F490", VA = "0x186030890")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JDJLOFEOKDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Transform IPNPGKJPCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform EMKNCJILPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Transform NLBCLEPNPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform PNDNBBGNHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Transform NLLIBPODCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Transform DBNGEAGFPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Transform ILLDEAOMFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Transform NLMAIEDKGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Transform IDPNBLMHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation IAJAMCACOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PositionAndRotation KLHDIOBGEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private PositionAndRotation CBEAGKJOPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private PositionAndRotation DBEAOCHCIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private PositionAndRotation NBICMENLONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PositionAndRotation JEKAIDLPPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private PositionAndRotation EPNKJEDFMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PositionAndRotation CAOHHGFIEGG;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x602D2A0", Offset = "0x602BEA0", VA = "0x18602D2A0")]
	public void HAJAGMDCLHL(Transform JBCJLLKONNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x602CA60", Offset = "0x602B660", VA = "0x18602CA60")]
	public void FLNHPALMPEC(HandLogicOffsets CAFJAEMFEFL, DOIEKAPMIIJ LOFGEJONCMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x602D960", Offset = "0x602C560", VA = "0x18602D960")]
	public void IKNBFKAGNCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x602DBB0", Offset = "0x602C7B0", VA = "0x18602DBB0")]
	private PositionAndRotation NMNLHNPEMHG(Transform OPFBHDKKMHM, Transform EEJKJBNPJPI)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x602C790", Offset = "0x602B390", VA = "0x18602C790")]
	private void ELOJOJHBIDI(Transform OPFBHDKKMHM, Transform EEJKJBNPJPI, PositionAndRotation GBHCCKLMHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	public JDJLOFEOKDJ()
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
