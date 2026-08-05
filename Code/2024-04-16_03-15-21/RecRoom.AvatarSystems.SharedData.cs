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
public enum DKKCJDCNCOL
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
public enum IDMAOGIEMDD
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
public struct EENINMFPKND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator LPODLIJKOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public PNBLFLOKDFB NAOHLICIIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration PHJCBHJFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject MDCALEADMKA;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct GGLIJDJHOLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform DBCBFGIMJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool BALIHEEKMMG;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PNBLFLOKDFB
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BNMHJPKGMFH
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
public struct ACDFIFOAFEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Vector2 EJGLBDEKMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector2 LPAPENMIMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector2 OHPAAGOPHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector2 EPCLEHGNGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector2 EBKPNEHEFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 GMPGEFDMOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 BPJOKAJEAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 NKCPILANNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 MNOBHPONICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 ONGDKOLNBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 GFCHDPBHPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 PGAKGNCELJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 BNKENNLDAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 DDJMFLIADAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 MDMAAMBEEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 HLAEJKAPBOP;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JJFLGDLGJIM
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly string FEOMHFGFKMD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x603AD30", Offset = "0x6039F30", VA = "0x18603AD30")]
	public static OBKLBKMLDBK IHPBMJFKOBG()
	{
		return default(OBKLBKMLDBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x603A920", Offset = "0x6039B20", VA = "0x18603A920")]
	public static MFGGFOFOHEO EFEBMFCNLDD(Transform NLGNBPIPJMP, Transform OECAKOGMKIG, AvatarConfiguration DLHOBAFFKOB, Animator BHKENPABNGA, VRIK DNBELCIHCLC, GameObject[] DJDHBCKKCHI, Transform JANFECOLLDJ, AssetReference AKAJNKKGIDF, GameObject JJMPOLDKENI, GameObject DELMBFPNKNB, SkinnedMeshRenderer LPIBBBBPBGK, Material KDCFOKDPHMD, Material AGIKHFOMEOC, Material LPGCACIBIPF, Shader AHOBKMPBHMC, Shader ALAPHFLJDBL, Transform DEEMEHGNINJ, Transform JONOKHAGOPF, Transform JLINDAFANPM, Transform LLFCPCGDEDN, Transform FBEHKDHFAOI, Transform DMDGOGEAJKC, Transform FCEJLIDADJO, Renderer[] EHLFAHJOCHD, PLJPJOIEJMK PIEHMBJIFLM, PLJPJOIEJMK CNDPPALCCCC, PLJPJOIEJMK PAFIMNPAHLI, PLJPJOIEJMK CNMKLKHDCMD, PLJPJOIEJMK MCGMKLCKDGI, PLJPJOIEJMK LMDANLLLEMI, PLJPJOIEJMK ILLKMBAIPGB, PLJPJOIEJMK DANCKOOLDNI, Transform BKEMBEIMBPK, Transform KJGBPAENPJI, GameObject IEPIKGHJCHJ, GameObject FENPCNPCMGE)
	{
		return default(MFGGFOFOHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x603B070", Offset = "0x603A270", VA = "0x18603B070")]
	public static CHBALIPKHIK PFLMGGEGHHK(string LDILHGKHOPC, bool KGEJCBHCLHG, bool KAOFEOLHHEO, bool KKALFKDKNOA, Func<GFKLOKHJCAC> MJBEINPOKDP, Func<Vector3, OBKLBKMLDBK> NEBJOBOENOH, RigidbodyEx HCNGKMJIKEG, RigidbodyEx IAHMEIEDDFF, RigidbodyEx FOCEIGKIDJH, RigidbodyEx CEDIIPPDJMA, Transform IEPHPNMCNED, Transform OABNIOCABDC, Transform IAPONPAJMAF, float LIEGGPODEJB, float NPLPPPKLOPL, PlayerAvatarFullBodyColliders LLCLDDHBGCD, SkinnedMeshRenderer[] PBPENCEJBGF, SkinnedMeshRenderer[] EGKOMPHOFIM, SkinnedMeshRenderer[] OPDJNBOPDKD, SkinnedMeshRenderer[] EPALJCIGOEE)
	{
		return default(CHBALIPKHIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x603AEA0", Offset = "0x603A0A0", VA = "0x18603AEA0")]
	public static CMHAJBBPOFG NLFHBIAIJIM(Transform OECAKOGMKIG, AssetReference AKAJNKKGIDF, GameObject JJMPOLDKENI, GameObject DELMBFPNKNB, SkinnedMeshRenderer LPIBBBBPBGK, Material KDCFOKDPHMD, Material AGIKHFOMEOC, Material LPGCACIBIPF, Shader ODHNKKJCNGG, Shader CIAKBCBABEI, Animator MMBHCLIGMKB, Renderer[] EHLFAHJOCHD, AvatarConfiguration PIMPONLGOMK)
	{
		return default(CMHAJBBPOFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x603AE20", Offset = "0x603A020", VA = "0x18603AE20")]
	public static CEFANMKMJDC NBCMCOMPBON(SkinnedMeshRenderer[] PBPENCEJBGF, SkinnedMeshRenderer[] EGKOMPHOFIM, SkinnedMeshRenderer[] OPDJNBOPDKD, SkinnedMeshRenderer[] EPALJCIGOEE)
	{
		return default(CEFANMKMJDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x603A850", Offset = "0x6039A50", VA = "0x18603A850")]
	public static CNEOJJPDMHK CGGBEMCMPBC(Transform DEEMEHGNINJ, Transform JLINDAFANPM, Transform JONOKHAGOPF, Transform LLFCPCGDEDN, Transform FBEHKDHFAOI, Transform DMDGOGEAJKC, Transform FCEJLIDADJO, AvatarConfiguration DLHOBAFFKOB)
	{
		return default(CNEOJJPDMHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x835A30", Offset = "0x834C30", VA = "0x180835A30")]
	public static OMDOOCCJCGP LMMLOLPNCAJ(SkinnedMeshRenderer[] KEPGFMGCPBP)
	{
		return default(OMDOOCCJCGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x603AFD0", Offset = "0x603A1D0", VA = "0x18603AFD0")]
	public static GPODDAAPKBN NPHCJAHKDHJ(BEEEKFKHBGL FJCBEMKCAMA, int EGHIFAKBLMB, int IFKNEJMIDGM, Color GDOCELHOEFG, Color NEOHELNCNMG, int OIKMHFKMNJO, int BHEOLFDEOLL, Color FNNKDHAMPKA, Color OCBECDCMOFK, int AIJEGAGBMBI)
	{
		return default(GPODDAAPKBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x603AD70", Offset = "0x6039F70", VA = "0x18603AD70")]
	public static JPHJODIDINL KLCADICPLBG(BEEEKFKHBGL FJCBEMKCAMA, Vector2 HBOHNMBPLGM, float DJPFMHMBHFB, Vector2 DBMDMBKLMFB, float EKEIIGOCLJO, Vector2 GFDNFFKNFLD, float BHLCJLNLKJE, Vector2 IMCAIHDBFLK, float FBOCBPGLLBO)
	{
		return default(JPHJODIDINL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x603ACC0", Offset = "0x6039EC0", VA = "0x18603ACC0")]
	public static EENINMFPKND ICPEDIKCOAN(Animator JJANIHMICBN, PNBLFLOKDFB PPCLIBEEJMG, AvatarConfiguration PIMPONLGOMK, GameObject EGKBMJJLPII)
	{
		return default(EENINMFPKND);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x603A810", Offset = "0x6039A10", VA = "0x18603A810")]
	public static GGLIJDJHOLD BOIBPEKLPCI(Transform HGMJBJHOGAL, bool KAOFEOLHHEO)
	{
		return default(GGLIJDJHOLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class NBKIFFNJHGN
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x603B270", Offset = "0x603A470", VA = "0x18603B270")]
	public static DKKCJDCNCOL EHGLCOJHMEN(this BNMHJPKGMFH APKPCLGCLDN)
	{
		return default(DKKCJDCNCOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x603B2C0", Offset = "0x603A4C0", VA = "0x18603B2C0")]
	public static bool MMINJNABBLJ(this BNMHJPKGMFH GIHJPMMBJJC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HAOJAFFJNEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GJKOONHFFKF : HAOJAFFJNEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform MFNBLJPKPCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 AFIFOEGBOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xD5B9E0", Offset = "0xD5ABE0", VA = "0x180D5B9E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA00", Offset = "0xD5AC00", VA = "0x180D5BA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? EBKDBCPAINM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA20", Offset = "0xD5AC20", VA = "0x180D5BA20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD5BA10", Offset = "0xD5AC10", VA = "0x180D5BA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public GJKOONHFFKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CDJBFLIDAKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected readonly GJKOONHFFKF LFPHGADAEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly GJKOONHFFKF NBGDBCDNFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly GJKOONHFFKF LAEMHNJLLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly GJKOONHFFKF NEIJCEKGHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected readonly GJKOONHFFKF EOKOPJOMALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly GJKOONHFFKF FJCABCGGLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly GJKOONHFFKF JGMGALMKHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly GJKOONHFFKF FELIAFENBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly GJKOONHFFKF MJKLKFLFMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly GJKOONHFFKF IFNNNDJPLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly GJKOONHFFKF JMOLDKEIJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly GJKOONHFFKF PNBHECEIKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly GJKOONHFFKF ICNLDBIBABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected GJKOONHFFKF DHOPIINNBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly GJKOONHFFKF ALOIBDAIPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly GJKOONHFFKF ANIGKAGNCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly GJKOONHFFKF LNJABECFCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected GJKOONHFFKF GLFMHGBCNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly GJKOONHFFKF OAHAEMHHLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly GJKOONHFFKF EDKIEGIDJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly GJKOONHFFKF OHGICOGENKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected ReadOnlyCollection<GJKOONHFFKF> AOICILJBKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform JANFECOLLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private (GJKOONHFFKF Start, GJKOONHFFKF End)[] FCNMDJFJJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private Dictionary<string, GJKOONHFFKF> PHAHCMIHKHC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HAOJAFFJNEJ CMDBHPAOBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B4140", Offset = "0x7B3340", VA = "0x1807B4140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HAOJAFFJNEJ LBPBNHNGCGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HAOJAFFJNEJ DGMHGOMBBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HAOJAFFJNEJ POBAGIAKFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HAOJAFFJNEJ LJMIMGIOKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HAOJAFFJNEJ HAMGCKBBNIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF640", Offset = "0x7BE840", VA = "0x1807BF640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HAOJAFFJNEJ HBPPCMKIJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF60", Offset = "0x7BB160", VA = "0x1807BBF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HAOJAFFJNEJ DNPHIFDIFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BBF50", Offset = "0x7BB150", VA = "0x1807BBF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HAOJAFFJNEJ LODEJLMCHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC50", Offset = "0x7BBE50", VA = "0x1807BCC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6038A10", Offset = "0x6037C10", VA = "0x186038A10")]
	public void EOHIFBHDDHM(VRIK DPLJKNCHIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6039960", Offset = "0x6038B60", VA = "0x186039960")]
	private void HNJAMLLLJCD(Transform HEEIDJMADFG, GJKOONHFFKF JGFCAMDGBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60398F0", Offset = "0x6038AF0", VA = "0x1860398F0")]
	public GJKOONHFFKF HBINEGONLCL(string OLOFMGICJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6039BE0", Offset = "0x6038DE0", VA = "0x186039BE0")]
	public void OPCBDNFEENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6039BA0", Offset = "0x6038DA0", VA = "0x186039BA0")]
	public float NGLGILNKGOA([In] (GJKOONHFFKF Start, GJKOONHFFKF End) BOKFALJPOCC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60399F0", Offset = "0x6038BF0", VA = "0x1860399F0")]
	public void LHGPGGCBOCN([In] OBKLBKMLDBK GAEMKAANAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6039FE0", Offset = "0x60391E0", VA = "0x186039FE0")]
	private Vector3 PGKIDHKGFIA([In] (GJKOONHFFKF Start, GJKOONHFFKF End) BOKFALJPOCC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x603A110", Offset = "0x6039310", VA = "0x18603A110")]
	public CDJBFLIDAKJ()
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
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6038970", Offset = "0x6037B70", VA = "0x186038970")]
		public string JCKJNMALHCN(string DLOPDHGGPNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60389C0", Offset = "0x6037BC0", VA = "0x1860389C0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CHBALIPKHIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public string HANPHABKAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool BALIHEEKMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool CDIOIHOEICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float PEMDEHCHMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float BGPGIDHMKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public bool FLLBHFIAKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Func<GFKLOKHJCAC> IHILKNMECHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Func<Vector3, OBKLBKMLDBK> MOFKGBJOGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public RigidbodyEx PAFBGPEFOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public RigidbodyEx MONBCHCBDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public RigidbodyEx AMCHPADGFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public RigidbodyEx PLBMDMGONBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform DNHODCMJDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform NPLHDOALBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform FBAGDNAGIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public PlayerAvatarFullBodyColliders LPPBDIOECKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public SkinnedMeshRenderer[] OHJNIICNMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer[] GGBBCGIKGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public SkinnedMeshRenderer[] BHFKAJPNPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SkinnedMeshRenderer[] LMHLAGLCIDD;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x603A5F0", Offset = "0x60397F0", VA = "0x18603A5F0")]
	public OBKLBKMLDBK PFEOOKEALHP(Vector3 NILFHOLNAMB)
	{
		return default(OBKLBKMLDBK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MFGGFOFOHEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Transform OHFICBOBPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform BLBDEPIJFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public AvatarConfiguration PHJCBHJFLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Animator ELKNNENAMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public VRIK PIJFBAPFEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public GameObject[] GHOGGKCKPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform EFGEBOMEOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public AssetReference EHOLCJNJAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GameObject PNCHKIOCGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject NILMAPNJFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer PIGKAKBEHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Material PIBPJKCFDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Material AMCCCCADIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Material GBLLFGMFLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Shader BEFBOPDGGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Shader EPLGOAMPFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform EJIFIKIKJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform EOOCDBINCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform ABAHPGJANCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform GGEHOAEDCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Transform MCJHKGCEAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Transform IBJHMDEGPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform EGGLCEMIJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Renderer[] COPONNKBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Transform IFLNMGHIKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Transform FEKGAHFEOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject PGAFEPNJOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public GameObject CAFKOBGDHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public PLJPJOIEJMK BCLNAHHMJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public PLJPJOIEJMK FDFHGCENIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public PLJPJOIEJMK AKOCGLMIKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public PLJPJOIEJMK FPJNPEMLIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public PLJPJOIEJMK DEKCJOAFGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public PLJPJOIEJMK EHICMLAAKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public PLJPJOIEJMK GAGBKNGPNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public PLJPJOIEJMK NCGBLLKLPJD;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GFKLOKHJCAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool KCICCKHOKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public LABHNEIMMOD KMHGHHECBEL;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct OBKLBKMLDBK
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FGHGKGNGIII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly bool KJGHJPLFDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly bool GMPJMJAFCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly bool MHMMBNEKFOJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x603A780", Offset = "0x6039980", VA = "0x18603A780")]
		public FGHGKGNGIII(bool KNKKOIHCBHH, bool HDOPMNLMANJ, bool BICKGFIOLNL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float HBOLPLFPJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool PDCHAOOJOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public float HDLNIOOACHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 JGDIIOHBLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3 OOKAAICAEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3? LNDHAEKLPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3? PAGAPFFDBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool CFKLDGKOIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool FMHKLMKOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool CEAFMLNEKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool OOCNFNHGGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Vector3? LMGJNFKEINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool CNCMJGHFEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3? KHOGGOCNDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool ILMNNNIABIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3? EHMBAEBCBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public float NOLCDAGHBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3? FOFBMBNIDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool DJNLEKFOBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool IMCPHIEBGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool NAAKHGJPEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool FKGPHCJCOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool FHAFABCMMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool JHJCDKDHBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool CEEMBLGLJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool NHAJOHMDOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool FIMEJOBJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GEJBDDOACIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool EBPFCLLLIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3? FCDOCMDLBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public BNMHJPKGMFH EJILCEBHOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public BNMHJPKGMFH APADEGDFLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool PJDLJLMNLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool BHEAMJNMLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public FGHGKGNGIII LAHBBPJKNOK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x603B2D0", Offset = "0x603A4D0", VA = "0x18603B2D0")]
	public void PGBMCCKNAON(Quaternion ECLCOOPOABI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GAJDMICNJIP
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x603A7D0", Offset = "0x60399D0", VA = "0x18603A7D0")]
	public static BHLLHPOHOIE AMMBNKLMGHC(this ILIHPJMAOHB AOFIGDLFNLH)
	{
		return default(BHLLHPOHOIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x603A7F0", Offset = "0x60399F0", VA = "0x18603A7F0")]
	public static void ODOHOCMBGKO(this ILIHPJMAOHB AOFIGDLFNLH, BHLLHPOHOIE EKDDCPALANJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface PLJPJOIEJMK
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float PJADGMHMMIA);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private LAAKFPPBFLH NCKFHCJKBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Collider[] OLNHPGFEBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] DNFHGCLCGCN;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> EOGEKKLBKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x603C190", Offset = "0x603B390", VA = "0x18603C190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private LAAKFPPBFLH PPOHGCBGPKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x603B7B0", Offset = "0x603A9B0", VA = "0x18603B7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HJFKKOBAGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D5C50", Offset = "0x8D4E50", VA = "0x1808D5C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x603B700", Offset = "0x603A900", VA = "0x18603B700")]
		private void JIEHHNBIKAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x603B6F0", Offset = "0x603A8F0", VA = "0x18603B6F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x603C170", Offset = "0x603B370", VA = "0x18603C170")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer NGFPIKOHCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x603BF90", Offset = "0x603B190", VA = "0x18603BF90")]
		public void SetCollidersEnabled(bool KIOKGDOKJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x603BB20", Offset = "0x603AD20", VA = "0x18603BB20")]
		public void ReparentBonesUnderOtherBoneCollection(LAAKFPPBFLH CJECBHAGGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x603B850", Offset = "0x603AA50", VA = "0x18603B850")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AAJHFBIHOKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Transform CLNPMCKCBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Transform FJPGJKFIDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Transform PLLIHOIMNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Transform MPECJCPHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Transform IKNOCIMOCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Transform GGACEOEAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Transform AKBLCJCGIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Transform LPPKCGODMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform IIHJHIACEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private PositionAndRotation EBKFGMLHCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private PositionAndRotation GFAGPHCLCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private PositionAndRotation MKMGPCMMFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private PositionAndRotation DIDJIFHICBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private PositionAndRotation KFNKFPHKCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PositionAndRotation BPDNJLPJOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PositionAndRotation FEBAHJMHEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation FGCCNJCELEH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60382B0", Offset = "0x60374B0", VA = "0x1860382B0")]
	public void MEJEOBIHPJE(Transform OFHKJIKDDPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6037550", Offset = "0x6036750", VA = "0x186037550")]
	public void CONBLHHEENE(HandLogicOffsets JCKEOGKENKK, PNBLFLOKDFB AKIAHGACOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6038060", Offset = "0x6037260", VA = "0x186038060")]
	public void MEIMMNJBACB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6037480", Offset = "0x6036680", VA = "0x186037480")]
	private PositionAndRotation BMFFCJBACBI(Transform HLAJHOGGALF, Transform JHMPGLDDCIC)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6037D90", Offset = "0x6036F90", VA = "0x186037D90")]
	private void GGDMGEMMNMK(Transform HLAJHOGGALF, Transform JHMPGLDDCIC, PositionAndRotation FEHOMPOOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public AAJHFBIHOKO()
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
