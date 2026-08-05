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
public enum JNIDLKJBAKF
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
public enum BDDKNKOIDIM
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
public struct PIGMELIDGBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator CAJNMECJIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public JFADJIMIMKD OMMMKPMFJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration MCGAMLGHFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject PGODNGFGOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public MKCGKHDCIPE ANPDMNFNKOO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OLBKGJFMMAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Transform DENLMEAHCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool EEEECPEIFAI;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HMBMAFDHFMJ
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
public enum CAKDFCOLKEE
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
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct ANOBNMBDHAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 BONKOOMJDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 DAOMJKJDEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 EBKKDCAOMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 FGHOODDMNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 IGCGCJLMECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 LECHCCDEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 EONFMPNOLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 EGHGBNNMFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 KOBNNABEFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 PBKFIHOAKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 BJDDGADCOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 PCJKNHCKPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 HGIPCDAPEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 IBBJDBHJJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 OLEPEGIKLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 BHPGFJANMGN;
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
public static class GDKGBNPDIMC
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly string BPPIPFNBNDN;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x689BE60", Offset = "0x689A460", VA = "0x18689BE60")]
	public static HDDEAEHIPHI HFEPGOCJKLJ()
	{
		return default(HDDEAEHIPHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x689B490", Offset = "0x6899A90", VA = "0x18689B490")]
	public static DEMOBJKCGNC DJNOEDIEDCF(MKCGKHDCIPE ANDJEELBFAD, Transform GEJNFOBHGNJ, Transform JCOOPJDAOLH, AvatarConfiguration LKCFMBNLPOO, Animator HAKAKGEMLAG, VRIK HPEKFHKOHCL, GameObject[] DNHDJDOLGJI, Transform PCEGBFIFOPE, AssetReference GIBCBJCLFFF, GameObject KIPBECEFBEB, GameObject JHHOIEIJCBF, SkinnedMeshRenderer KFEPGIGOLOH, AvatarSkinnedMeshBoneOrderRemapsData NHNIGGPJCLA, Material FMHJPMNKGCA, Material MGCBGNCHOOJ, Material CHBAHLFCFHF, Shader HODFNHDOOED, Shader BNPKKJNPKLM, Transform IOMMPKEILBF, Transform KBLDBCDDBIH, Transform LPCPFBOHDNA, Transform INDDFJCOLNF, Transform KKNOONHKCPN, Transform OELJHDLLLKN, Transform KIKJAMEKOIJ, Renderer[] DKJJMOAEBNP, DLECCJNCNEO FMGLDIFFPDD, DLECCJNCNEO DHKOPNFCLOO, DLECCJNCNEO DJEHBLJGAOF, DLECCJNCNEO LHFOMFNAGFE, DLECCJNCNEO DGBFHGFDKFA, DLECCJNCNEO NKANDJHBBKE, DLECCJNCNEO BLCCHFMLIOO, DLECCJNCNEO PHHOEENJNJF, Transform KECDHFKKOMC, Transform MKJFGBEOOEH, GameObject NAIBLEPGAGL, GameObject GHIJNAEEOJO, AvatarBodyPartShapesManager OLLJJGNFHHH, Transform HDIIDCHLPNL, Transform MGCDJCLLEFD, Transform NNJILMDAGKA, Transform GIKADJADANP, Transform IJLDHLOAMDB)
	{
		return default(DEMOBJKCGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x689BFB0", Offset = "0x689A5B0", VA = "0x18689BFB0")]
	public static LNFDPEGDEGJ MLIFBKFLGHN(string MNMIBCNOCDD, bool EDIMGHGKLMI, bool BNOEFCDFMJN, bool GECFFMJCAFG, Func<ECLHIAFDGGI> KAGADNPDKKO, Func<Vector3, HDDEAEHIPHI> MIJOHLMJIJK, RigidbodyEx HHBMNDFBHGE, RigidbodyEx IBADHDENMAJ, RigidbodyEx GMFDCOBIJGF, RigidbodyEx LBHOCFKIGEA, Transform NNHPDDEBOIG, Transform LBIBONALEOD, Transform JCICGIBJKAK, float KKLMKGPCEGJ, float PGCILKKLAPG, PlayerAvatarModernBodyColliders IBPMHBDGKPL, SkinnedMeshRenderer[] NHLGJFHKFFM, SkinnedMeshRenderer[] GKHLCNPAKKA, SkinnedMeshRenderer[] CLAJMBMJPHO, SkinnedMeshRenderer[] FHGFAONKBNN)
	{
		return default(LNFDPEGDEGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x689B310", Offset = "0x6899910", VA = "0x18689B310")]
	public static GMHBGOLIPKM BLIJFNGFEGM(Transform JCOOPJDAOLH, AssetReference GIBCBJCLFFF, GameObject KIPBECEFBEB, GameObject JHHOIEIJCBF, SkinnedMeshRenderer KFEPGIGOLOH, AvatarSkinnedMeshBoneOrderRemapsData NHNIGGPJCLA, Material FMHJPMNKGCA, Material MGCBGNCHOOJ, Material CHBAHLFCFHF, Shader IAAFEKLFCOD, Shader PNBHMGDFMLE, Animator MKKNMHNMDND, Renderer[] DKJJMOAEBNP, AvatarConfiguration PMHKPDLAADM, AvatarBodyPartShapesManager OLLJJGNFHHH, IReadOnlyDictionary<string, Transform> BFLLODAGBCH)
	{
		return default(GMHBGOLIPKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x689BF30", Offset = "0x689A530", VA = "0x18689BF30")]
	public static CPAJFNAHJIL LGEIOFEIKKI(SkinnedMeshRenderer[] NHLGJFHKFFM, SkinnedMeshRenderer[] GKHLCNPAKKA, SkinnedMeshRenderer[] CLAJMBMJPHO, SkinnedMeshRenderer[] FHGFAONKBNN)
	{
		return default(CPAJFNAHJIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x689BC00", Offset = "0x689A200", VA = "0x18689BC00")]
	public static FAIFPEGDEPG FGLOAGKNFGB(Transform IOMMPKEILBF, Transform LPCPFBOHDNA, Transform KBLDBCDDBIH, Transform INDDFJCOLNF, Transform KKNOONHKCPN, Transform OELJHDLLLKN, Transform KIKJAMEKOIJ, AvatarConfiguration LKCFMBNLPOO)
	{
		return default(FAIFPEGDEPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA54FA0", Offset = "0xA535A0", VA = "0x180A54FA0")]
	public static GPGKGAIBADN PNONBDJIEFO(SkinnedMeshRenderer[] KKAIEKOAOAI)
	{
		return default(GPGKGAIBADN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x689C190", Offset = "0x689A790", VA = "0x18689C190")]
	public static GANCGFPKNOE PKEHMGFKLPG(LJOKFJLCIAC DHKKPHOHEGM, int CDPBDFLKDAC, int DCLEBCDAGKF, Color AFENEMMHPPD, Color ALHJNOMJJAL, int HPMIOGJHBNM, int DMJJEMDLEFA, Color LCOMNIDIELM, Color KHBCKGADCLP, int GDEKCLEOCFH)
	{
		return default(GANCGFPKNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x689B260", Offset = "0x6899860", VA = "0x18689B260")]
	public static JEBFMEMAPLC ACPHLAOCKDC(LJOKFJLCIAC DHKKPHOHEGM, Vector2 JANGMIMOFEJ, float OJAHKKBOBDN, Vector2 ODJFKKCDKFD, float HIAOJKNGPFN, Vector2 EHDPADPHGPK, float BNIJEECKAJK, Vector2 GDBCEEANBPL, float OMNJLHLMNJF)
	{
		return default(JEBFMEMAPLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x689BEB0", Offset = "0x689A4B0", VA = "0x18689BEB0")]
	public static PIGMELIDGBP JPJAFKFBEGD(Animator GONAJEEDANL, JFADJIMIMKD CAFLDOOLAJA, AvatarConfiguration PMHKPDLAADM, GameObject CLFMPPOGAFH, MKCGKHDCIPE ANDJEELBFAD)
	{
		return default(PIGMELIDGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x689C150", Offset = "0x689A750", VA = "0x18689C150")]
	public static OLBKGJFMMAC PAABJMFIJAE(Transform BINBKHLOEAC, bool BNOEFCDFMJN)
	{
		return default(OLBKGJFMMAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x689BCD0", Offset = "0x689A2D0", VA = "0x18689BCD0")]
	public static PositionAndRotation FIALJHGOJCD(Transform KJFNBKOBMLP, Transform GEJNFOBHGNJ)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x689B8F0", Offset = "0x6899EF0", VA = "0x18689B8F0")]
	public static void DLMBCKGOPHK(Transform KJFNBKOBMLP, Transform KOHFOIPPAAF, PositionAndRotation MHODBBJHBOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class GGBHHOOFKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x689C290", Offset = "0x689A890", VA = "0x18689C290")]
	public static JNIDLKJBAKF BAPIPEOPKKO(this HMBMAFDHFMJ NBKHCEHDNIB)
	{
		return default(JNIDLKJBAKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x689C2E0", Offset = "0x689A8E0", VA = "0x18689C2E0")]
	public static bool DDDIIABIPGN(this HMBMAFDHFMJ JACAHJLLBLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MMLFGJAKCMF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform BFKELEPPJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DGFAKJKNFOB : MMLFGJAKCMF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform BFKELEPPJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 NAKELFMMECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xED50C0", Offset = "0xED36C0", VA = "0x180ED50C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xED4F60", Offset = "0xED3560", VA = "0x180ED4F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? CABALGHNBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xFF5B70", Offset = "0xFF4170", VA = "0x180FF5B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xFF5B80", Offset = "0xFF4180", VA = "0x180FF5B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DGFAKJKNFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AMKALJGEJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly DGFAKJKNFOB BHHPMOEINCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly DGFAKJKNFOB EPEDJFJPNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly DGFAKJKNFOB ABKJINENOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly DGFAKJKNFOB NGOAALGLEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly DGFAKJKNFOB GIOELBAHOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly DGFAKJKNFOB ELEIDLJIGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly DGFAKJKNFOB FKNIPLJANAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly DGFAKJKNFOB LMGIAGKNNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly DGFAKJKNFOB MBNLCHKNFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly DGFAKJKNFOB JAJDBEDJEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly DGFAKJKNFOB GCKFGHMIAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly DGFAKJKNFOB LHLPKDDGBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly DGFAKJKNFOB KNNHOILDFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected DGFAKJKNFOB DDHBDALINKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly DGFAKJKNFOB KAHBAMBCOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly DGFAKJKNFOB GGDNNALHBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly DGFAKJKNFOB LCGAHKFILDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected DGFAKJKNFOB FOMGEBCJAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly DGFAKJKNFOB FKEAMNDLKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly DGFAKJKNFOB MPEPBCDLIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly DGFAKJKNFOB OMDBICNJNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected ReadOnlyCollection<DGFAKJKNFOB> JNLEANGKOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Transform PCEGBFIFOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private (DGFAKJKNFOB Start, DGFAKJKNFOB End)[] HNPHJJGGIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Dictionary<string, DGFAKJKNFOB> OGHFIEJLJED;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MMLFGJAKCMF EHPOPOGJMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MMLFGJAKCMF BNAJINAAPLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MMLFGJAKCMF BKJMDBCBJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MMLFGJAKCMF EKGHJHPECKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MMLFGJAKCMF LPHKANMOKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MMLFGJAKCMF MKAJHIJMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8632E0", Offset = "0x8618E0", VA = "0x1808632E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MMLFGJAKCMF GJDJMPFEBBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x861750", Offset = "0x85FD50", VA = "0x180861750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MMLFGJAKCMF PDJJLIABPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x861760", Offset = "0x85FD60", VA = "0x180861760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MMLFGJAKCMF FKJEEFLGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8656F0", Offset = "0x863CF0", VA = "0x1808656F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6898880", Offset = "0x6896E80", VA = "0x186898880")]
	public void ELMJMGCDKGO(VRIK EILMOMHLPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68987F0", Offset = "0x6896DF0", VA = "0x1868987F0")]
	private void EHJPNGJFDCF(Transform JOCJMGGBHIC, DGFAKJKNFOB MNAGKONPJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6899E40", Offset = "0x6898440", VA = "0x186899E40")]
	public DGFAKJKNFOB NMNPBNCGEEL(string FMAIGBOMKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6899760", Offset = "0x6897D60", VA = "0x186899760")]
	public void GLJDBLDDCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68987B0", Offset = "0x6896DB0", VA = "0x1868987B0")]
	public float CAENPKCAPAE([In] (DGFAKJKNFOB Start, DGFAKJKNFOB End) CCHGAGKBKGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6899C90", Offset = "0x6898290", VA = "0x186899C90")]
	public void JHFPEHDJDGL([In] HDDEAEHIPHI HJBEGIDNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6899B60", Offset = "0x6898160", VA = "0x186899B60")]
	private Vector3 IIMLINNKJBI([In] (DGFAKJKNFOB Start, DGFAKJKNFOB End) CCHGAGKBKGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6899EB0", Offset = "0x68984B0", VA = "0x186899EB0")]
	public AMKALJGEJNA()
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
		public GameObject AvatarCollidersPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x689A390", Offset = "0x6898990", VA = "0x18689A390")]
		public string BNNKMIIDIEM(string FMGMOLPKMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x689A3E0", Offset = "0x68989E0", VA = "0x18689A3E0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LNFDPEGDEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public string NNECNPBGCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool EEEECPEIFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool CIEGDLDLOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float ENIOMHADGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float EDLPKNNOLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool JKAANEIBMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Func<ECLHIAFDGGI> GHGPHNHPKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Func<Vector3, HDDEAEHIPHI> FKMFPDFNDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public RigidbodyEx CBMAJJBGOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public RigidbodyEx NHLLMIHPNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public RigidbodyEx IDPHJCDBLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public RigidbodyEx IKCBAKMIPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform GMGMGHDPHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform ABBOAHFKGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform POJBNKHDCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
	public PlayerAvatarModernBodyColliders IBPMHBDGKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public SkinnedMeshRenderer[] BDKELMBCDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public SkinnedMeshRenderer[] OOFMAAMIEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public SkinnedMeshRenderer[] KCGGDPOINKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer[] MKELOBBDJLA;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x689C710", Offset = "0x689AD10", VA = "0x18689C710")]
	public HDDEAEHIPHI EFIAMDGGNJN(Vector3 PLNEOADFFDA)
	{
		return default(HDDEAEHIPHI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct DEMOBJKCGNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public MKCGKHDCIPE ANPDMNFNKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform KLOHNOFBMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Transform EJMBIJENHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public AvatarConfiguration MCGAMLGHFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Animator CIKDFIKOGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public VRIK CLPLOEEOKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public GameObject[] LGILAOAIEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform BOHKBACLPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public AssetReference HOPANDMCNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public GameObject AMMGMCPHMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public GameObject FDHKBBALIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public SkinnedMeshRenderer AKBNIJINONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public AvatarSkinnedMeshBoneOrderRemapsData EABIKLDICON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Material KDPEPNKBGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Material EAHMABELANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Material JIFMAKFOJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Shader AJFCIIKHNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Shader MHJPJHJEPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Transform AJKJLMIMJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Transform CMEHFEJAIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Transform ICHAIGNIMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Transform HJJFEDMANDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Transform IJCGLENIHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform CECPMOMKKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform JLACLGBANEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Renderer[] EHIMNAIDGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Transform NHLKBDHJEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Transform DGINAANCHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public GameObject NNNJAPLJCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public GameObject GBMCOBPGNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Transform MMCHCJPMBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public DLECCJNCNEO BEPIMBHBCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public DLECCJNCNEO HNIFDCEKJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public DLECCJNCNEO HFFFLGJHKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public DLECCJNCNEO EOGNAKBIAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public DLECCJNCNEO HGLMKKJCFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public DLECCJNCNEO ICDIGIOAPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public DLECCJNCNEO HOBGNPNOPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public DLECCJNCNEO DBINCDDLFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public AvatarBodyPartShapesManager KKPJBBNBOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Transform IHHBIJACPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Transform PMCNACDLECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Transform HPNDDJKEBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Transform KBALAHOCFKM;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ECLHIAFDGGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool KEBOBLAGMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public GHLGGPNNOMD HFOOLHIJBND;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct HDDEAEHIPHI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class MMGOLENOOAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly bool MNPJLGJPMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly bool EDOPEHBDBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly bool GAMDGNOAJPB;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x689C8A0", Offset = "0x689AEA0", VA = "0x18689C8A0")]
		public MMGOLENOOAG(bool MMBEMNCDFKJ, bool CEHJGODHFNM, bool LHKPFFOGGLD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public float GBGHOFHIODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool CENFJEBNKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public float BPBGDDOJHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Vector3 MGFNIFOGFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector3 HECMMBCCPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3? BNKIODEDPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Vector3? ENFCPHJMEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool MJHFNAFNALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool AHLIDMCHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool FINOHNJOKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool HILMPMPBCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Vector3? LBFGLOLKPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool ECOFBDIJGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3? PDNLGOJHBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool ONBMBFJEJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Vector3? AMIAPLLOMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public float LIONHLDFDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Vector3? COIPLFIBJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public bool EMCDBEIOGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool GHDBKDHJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public bool HGMJALJGILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool DNDBGDACKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public bool PMPIKNEEOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public bool NCGODFAEBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public bool GKGDIKKAKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool EFPBMFHJIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public bool GMHHABOPIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public bool DKBFNMNBLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool NDFBLNIDGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Vector3? DHAOCEMLBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public HMBMAFDHFMJ KHJMLIPCMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public HMBMAFDHFMJ PKDHBFNFJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float BOFBKDLENGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float OCCMFADJCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public CAKDFCOLKEE BEKFOPMFFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public CAKDFCOLKEE BINJNEOAHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public bool GENNEDHNIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public bool DNBBLCNNDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public bool AKLJIGGDPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public MMGOLENOOAG MAOFCAHAIOC;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x689C2F0", Offset = "0x689A8F0", VA = "0x18689C2F0")]
	public void KDNIEIIEGGN(Quaternion CNNBBFFJNHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class PEBCEGIAHHH
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x689C910", Offset = "0x689AF10", VA = "0x18689C910")]
	public static PAHGFPMKCPO OBAFONOCPNA(this FDJINODIBOM ELMHNMGFNPC)
	{
		return default(PAHGFPMKCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x689C8F0", Offset = "0x689AEF0", VA = "0x18689C8F0")]
	public static void KJABLELNGCF(this FDJINODIBOM ELMHNMGFNPC, PAHGFPMKCPO FEBGGALLBNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DLECCJNCNEO
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float KNACCMPDNHB);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PlayerAvatarModernBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum MCIHNGFLAKC
		{
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			EnabledForFullBody,
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			EnabledForModernBeanBody
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private EMLNHCBMDEF LMIOFMNHMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Collider[] MFDIAMMCCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly HashSet<Collider> AOELOMPKEKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private MCIHNGFLAKC? CFOFMFPPIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private Collider[] FullBodyOnlyColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] LDLJLHDIANH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> IHGODENHJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x689D670", Offset = "0x689BC70", VA = "0x18689D670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private EMLNHCBMDEF BHKDDLCFPPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x689CA60", Offset = "0x689B060", VA = "0x18689CA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool DHLHPBAPCCL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x15042E0", Offset = "0x15028E0", VA = "0x1815042E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x689CB00", Offset = "0x689B100", VA = "0x18689CB00")]
		private void MGFDLKDEIIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x689C9D0", Offset = "0x689AFD0", VA = "0x18689C9D0")]
		private void KPPLCGMOLKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x689C930", Offset = "0x689AF30", VA = "0x18689C930")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x689D5C0", Offset = "0x689BBC0", VA = "0x18689D5C0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer OBIGIMFGHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x689D310", Offset = "0x689B910", VA = "0x18689D310")]
		public void SetCollidersEnabled(MCIHNGFLAKC HJBEGIDNCHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x689CE80", Offset = "0x689B480", VA = "0x18689CE80")]
		public void ReparentBonesUnderOtherBoneCollection(EMLNHCBMDEF PFKJGFHFJHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x689CBB0", Offset = "0x689B1B0", VA = "0x18689CBB0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x689D5E0", Offset = "0x689BBE0", VA = "0x18689D5E0")]
		public PlayerAvatarModernBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CBMLBAGCAAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public Transform PCBIAKIHDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Transform JBENBMDFHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public Transform JIMHFNHEEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform NHKJCMHKPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform HBBOEKIHEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform HDAIMPOMBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform BJEPKHIJHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform MDELDLHIHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform JOLJCFNHCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private PositionAndRotation BCNPODBEKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PositionAndRotation GDFMFJDJMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private PositionAndRotation KEBCAMBBBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private PositionAndRotation CIOOGOGPFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private PositionAndRotation BMCEEEEENPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private PositionAndRotation IPEOLFMFMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private PositionAndRotation JPPDEOHCHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private PositionAndRotation HPABICKCEFE;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x689A8F0", Offset = "0x6898EF0", VA = "0x18689A8F0")]
	public void HGDANEHJCNG(Transform PLLOHFEFDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x689A430", Offset = "0x6898A30", VA = "0x18689A430")]
	public void CNKPAHCFEDL(HandLogicOffsets EFGDFEOEPMA, JFADJIMIMKD FPJBKCBHPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x689AB00", Offset = "0x6899100", VA = "0x18689AB00")]
	public void NFAAMEAMDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public CBMLBAGCAAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DDKOFDOGKIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform IBDPBDJOHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Transform PCCJFKNKGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Transform HGDMEKEEPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Transform PDGNCIFLJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Transform LLDIPJHMPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private PositionAndRotation JCFFGJDPAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PositionAndRotation MDCOLPGMOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PositionAndRotation PJCPLGCCGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private PositionAndRotation DJAKKCLBBAK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x689AD70", Offset = "0x6899370", VA = "0x18689AD70")]
	public void HGDANEHJCNG(Transform LPJNKLLIOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x689B050", Offset = "0x6899650", VA = "0x18689B050")]
	public void OEKGEBAFEBL(HeadLogicOffsets MHODBBJHBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x689AEA0", Offset = "0x68994A0", VA = "0x18689AEA0")]
	public void LFMJGKEKILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public DDKOFDOGKIH()
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
