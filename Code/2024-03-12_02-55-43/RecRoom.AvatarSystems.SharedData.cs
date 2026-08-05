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
public enum OMCPMJCHOGH
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
public struct KAGLCMIKGAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator BPOIDBGDOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public FHIMAIMKMAM DDENIGKLNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration NOICIFDENOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject DJBJOFGANEA;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FGFJODOJHFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform CJLHGMHOCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool MBPJEPGEIAF;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BEDHNNAIJKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public OMCPMJCHOGH? CPFNIKFHOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public OMCPMJCHOGH? MKHJEJMABCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? NFAFDEKMPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? GJBCBLCPOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? OMPANFHHLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? DFEOJLOCFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? IGEOLBNEAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? BILBLPCMIHE;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FHIMAIMKMAM
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GCGKPAAFDCB
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
public static class LADJBIGGIJO
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly string HNKOAMMLPHC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6059500", Offset = "0x6058700", VA = "0x186059500")]
	public static OGGLKAANNHD IMFAGNBMCLK()
	{
		return default(OGGLKAANNHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6058F10", Offset = "0x6058110", VA = "0x186058F10")]
	public static JGKDMDJGOMC AKEGIEJOOPJ(Transform EELPEPBCIDH, Transform IDCPOEEEEBO, AvatarConfiguration FGECKGHIPEA, Animator FPGOCOBPEHC, VRIK OPGAAKJCADA, GameObject[] JOJFCKKNEGO, Transform DBPMHILGOEC, AssetReference KNEFFFNNBMF, GameObject GGIBJGGLGAE, GameObject BGNPDDDNCFF, SkinnedMeshRenderer ONGNLOKIGOK, Material PDBEMMKEAPM, Material LJEGEPKOLLH, Material AIHHKNMJAKG, Shader PIDIPDCCFAH, Shader EEJCCFJKACJ, Transform CLGFLCIDODO, Transform BJOBONBEMLM, Transform LNKJJFLKOPG, Transform DBPPJLCNOEL, Transform BLCDJFKNNPD, Transform FFIPDGKJIAJ, Transform AENBDOCCDOC, Renderer[] OIJJPKKHEKI, OIAGDKLIOKA OLADDHGFNGN, OIAGDKLIOKA JEGKCPIHFMH, OIAGDKLIOKA CAPGDCCKDKN, OIAGDKLIOKA EHHJCEILNIN, OIAGDKLIOKA CLENJBNFGDN, OIAGDKLIOKA FFMNCILGPOB, OIAGDKLIOKA AEDCKKGIPNJ, OIAGDKLIOKA LKFHJJFGGHL, Transform JPNGDIIMFHI, Transform IOFAEEBBIDE, GameObject AGOJLMEEICL, GameObject MLMAGDNCPEP)
	{
		return default(JGKDMDJGOMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6058CF0", Offset = "0x6057EF0", VA = "0x186058CF0")]
	public static IIJACPAFGNC AGIFNLLOAEI(string EFDNFFBFLHE, bool HKCGPHJJEIJ, bool IPDAAKNCGGM, bool PFCGGOKIEBI, Func<DJJNKJIIHPO> FGMKPJOHMPA, Func<Vector3, OGGLKAANNHD> IKJCCDDFBFO, RigidbodyEx GILLAIFHHIB, RigidbodyEx BDCJIHEIELO, RigidbodyEx EFMBNNOHPCM, RigidbodyEx PNDIBHPDPKO, Transform CCABAOPFCAI, Transform EJJJMEBMDCH, Transform NNEBJFHGGIE, float IHCMPDLMCHI, float BGPCGAAOHJE, PlayerAvatarFullBodyColliders FJNFICOCOHK, SkinnedMeshRenderer[] DCAKLGKIOIC, SkinnedMeshRenderer[] GLEONOJDGJD, SkinnedMeshRenderer[] OHBOMPNFLLF, SkinnedMeshRenderer[] NLGDKCLDOAI)
	{
		return default(IIJACPAFGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6059380", Offset = "0x6058580", VA = "0x186059380")]
	public static PDBGDDIPIOJ GAAECLIGKJN(Transform IDCPOEEEEBO, AssetReference KNEFFFNNBMF, GameObject GGIBJGGLGAE, GameObject BGNPDDDNCFF, SkinnedMeshRenderer ONGNLOKIGOK, Material PDBEMMKEAPM, Material LJEGEPKOLLH, Material AIHHKNMJAKG, Shader PIMHKKCIECI, Shader KMKJJCOJPEM, Animator MAIIFHKGJCN, Renderer[] OIJJPKKHEKI, AvatarConfiguration ANJHAPOHCKL)
	{
		return default(PDBGDDIPIOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6058E90", Offset = "0x6058090", VA = "0x186058E90")]
	public static KMKBPHENBJL AJIJLGFLPOI(SkinnedMeshRenderer[] DCAKLGKIOIC, SkinnedMeshRenderer[] GLEONOJDGJD, SkinnedMeshRenderer[] OHBOMPNFLLF, SkinnedMeshRenderer[] NLGDKCLDOAI)
	{
		return default(KMKBPHENBJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60592B0", Offset = "0x60584B0", VA = "0x1860592B0")]
	public static MMEGNOPOMAL DAINONJHKJK(Transform CLGFLCIDODO, Transform LNKJJFLKOPG, Transform BJOBONBEMLM, Transform DBPPJLCNOEL, Transform BLCDJFKNNPD, Transform FFIPDGKJIAJ, Transform AENBDOCCDOC, AvatarConfiguration FGECKGHIPEA)
	{
		return default(MMEGNOPOMAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x14C41C0", Offset = "0x14C33C0", VA = "0x1814C41C0")]
	public static IHPPONBIPCH MAEIJOHNNHB(SkinnedMeshRenderer[] NHJEENBEEEA)
	{
		return default(IHPPONBIPCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60596A0", Offset = "0x60588A0", VA = "0x1860596A0")]
	public static BCCLHPIHKJC NOMLLPOPMJA(NMHNIKHIAOM OFAJMEEFLFH, int HMIFGMGNMPN, int PAAENNMINAN, Color ONOBAPGHBBP, Color NMFMNDGCEDD, int DEDKIBHFOEK, int POPBOFMCFHO, Color LALPDDBMAJO, Color ODNOJKIFOEA, int MBNJGJPECFH, float OMPKKEDABIE)
	{
		return default(BCCLHPIHKJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60595F0", Offset = "0x60587F0", VA = "0x1860595F0")]
	public static CPKLONGOPNH MCMCLDNHLMN(NMHNIKHIAOM OFAJMEEFLFH, Vector2 BDHALLFAMGF, float MEFDIBKMMEE, Vector2 BDDFNJAADOD, float KHPLLNFAECF, Vector2 GIJNMMOABHB, float PCHKGGJHHOL, Vector2 JKPALANFLJA, float IEHLGANLHLI)
	{
		return default(CPKLONGOPNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6059540", Offset = "0x6058740", VA = "0x186059540")]
	public static KAGLCMIKGAE JDAFCGBKLKL(Animator AAMBDEBKGKM, FHIMAIMKMAM MDHCALKIILH, AvatarConfiguration ANJHAPOHCKL, GameObject CHLPOPPGFFK)
	{
		return default(KAGLCMIKGAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60595B0", Offset = "0x60587B0", VA = "0x1860595B0")]
	public static FGFJODOJHFO LFBAEKIDPCB(Transform NCDGHADILHB, bool IPDAAKNCGGM)
	{
		return default(FGFJODOJHFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60594B0", Offset = "0x60586B0", VA = "0x1860594B0")]
	public static BEDHNNAIJKL GDFHCLIADMG([Optional] OMCPMJCHOGH? AMJLODDJNGI, [Optional] int? HPGNENAJGCO, [Optional] float? KGDKPJKPEAN, [Optional] float? CDCPDNPCDOO, [Optional] bool? IGMBALFDABI, [Optional] bool? FIEDMPGNBCO, [Optional] bool? HHPKCPKCHNK, [Optional] OMCPMJCHOGH? AGOHJMANIEM)
	{
		return default(BEDHNNAIJKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JFJKMBCAOKN
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6058CA0", Offset = "0x6057EA0", VA = "0x186058CA0")]
	public static OMCPMJCHOGH LILFAPLBEFB(this GCGKPAAFDCB GBAKBJKHMHP)
	{
		return default(OMCPMJCHOGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6058C90", Offset = "0x6057E90", VA = "0x186058C90")]
	public static bool GANOGNKONJL(this GCGKPAAFDCB PMIMGPMNKDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FCFFNEBJAGO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MMIAALMKDGG : FCFFNEBJAGO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform CNPCIAFGBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BA400", Offset = "0x7B9600", VA = "0x1807BA400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 KDFGDFAFIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD5B410", Offset = "0xD5A610", VA = "0x180D5B410", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD5B400", Offset = "0xD5A600", VA = "0x180D5B400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? FFCJPIBDCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD5B3E0", Offset = "0xD5A5E0", VA = "0x180D5B3E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD5B3F0", Offset = "0xD5A5F0", VA = "0x180D5B3F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public MMIAALMKDGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HMPJKDNEANA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly MMIAALMKDGG CPLOODLCOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly MMIAALMKDGG CCBNFNIBNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly MMIAALMKDGG FPCMLANCIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly MMIAALMKDGG NPHANBMKDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected readonly MMIAALMKDGG DNDEFFAPJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly MMIAALMKDGG EJMMJFDHJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly MMIAALMKDGG PEIAJKCCIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly MMIAALMKDGG IHJMHEBJIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected readonly MMIAALMKDGG IMGBIGLGBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly MMIAALMKDGG OBIGOEMGFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly MMIAALMKDGG MCFODNEIFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly MMIAALMKDGG LIDGKGPJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected readonly MMIAALMKDGG KHPGMKOPHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected MMIAALMKDGG OPAHOEGHJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly MMIAALMKDGG EDFPIKDJLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly MMIAALMKDGG GNOCKIGBEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly MMIAALMKDGG FHHINJKMELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected MMIAALMKDGG OANJGMCGEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly MMIAALMKDGG OJLDMBPAGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly MMIAALMKDGG PAHDJOIOAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly MMIAALMKDGG IHOMINFNOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected ReadOnlyCollection<MMIAALMKDGG> JIEIGFOHKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform DBPMHILGOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private (MMIAALMKDGG Start, MMIAALMKDGG End)[] OHAKJEBGICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, MMIAALMKDGG> HJLPKILENGF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FCFFNEBJAGO NMKEPMJNIPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FCFFNEBJAGO OONINDPIKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FCFFNEBJAGO CODFBNKLGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FCFFNEBJAGO KCFCOPKEKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FCFFNEBJAGO EPOFNDCLPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FCFFNEBJAGO ICBDMAGNJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D60", Offset = "0x7C0F60", VA = "0x1807C1D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FCFFNEBJAGO INNCCHPDMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFB0", Offset = "0x7BD1B0", VA = "0x1807BDFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FCFFNEBJAGO DEBEOCMNMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDFD0", Offset = "0x7BD1D0", VA = "0x1807BDFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FCFFNEBJAGO KHDCJDLHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BDF80", Offset = "0x7BD180", VA = "0x1807BDF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6057550", Offset = "0x6056750", VA = "0x186057550")]
	public void IDDGLCCBOMP(VRIK APDIALGNDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6056F40", Offset = "0x6056140", VA = "0x186056F40")]
	private void AHEDNGHJELC(Transform CGONJAIKCGI, MMIAALMKDGG MJBOJGOCOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6056ED0", Offset = "0x60560D0", VA = "0x186056ED0")]
	public MMIAALMKDGG AEGPLGGEALJ(string NAOILIBFHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6056FD0", Offset = "0x60561D0", VA = "0x186056FD0")]
	public void BFNMGJBMJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6057510", Offset = "0x6056710", VA = "0x186057510")]
	public float HHNLOEJBOHC([In] (MMIAALMKDGG Start, MMIAALMKDGG End) KDENDDJACLN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6058430", Offset = "0x6057630", VA = "0x186058430")]
	public void PEJHEDOBDKL([In] OGGLKAANNHD MJCOPLGCMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60573E0", Offset = "0x60565E0", VA = "0x1860573E0")]
	private Vector3 CJIDNKGGLME([In] (MMIAALMKDGG Start, MMIAALMKDGG End) KDENDDJACLN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60585E0", Offset = "0x60577E0", VA = "0x1860585E0")]
	public HMPJKDNEANA()
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
		[Cpp2IlInjected.Address(RVA = "0x6056DE0", Offset = "0x6055FE0", VA = "0x186056DE0")]
		public string NGDILKEHMED(string OOFCBKFFFBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6056E30", Offset = "0x6056030", VA = "0x186056E30")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IIJACPAFGNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string KIFMPHMKBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool MBPJEPGEIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool APDMACAGHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float PFNOHKNMMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float CONHJNJGDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool CLGEEIICGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public Func<DJJNKJIIHPO> DJKJJPEBBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Func<Vector3, OGGLKAANNHD> DLDCJMEFJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public RigidbodyEx OEHGDCNJCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public RigidbodyEx MJGKLFBACAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public RigidbodyEx ECNCBNLELHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public RigidbodyEx OHBAHHOEAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Transform NHDJFGKNDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform LAONDEHBKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Transform MEDIBMMBMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PlayerAvatarFullBodyColliders PGNGDDBIAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public SkinnedMeshRenderer[] NMNMBFJBJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer[] BPLJLBILABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public SkinnedMeshRenderer[] BNPKOJFOCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public SkinnedMeshRenderer[] ONHNPCNPGOH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6058AC0", Offset = "0x6057CC0", VA = "0x186058AC0")]
	public OGGLKAANNHD PNEOPMKHOGL(Vector3 LMDGNDBGFFF)
	{
		return default(OGGLKAANNHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JGKDMDJGOMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Transform KOKBLCIBPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Transform LCLOBJFHNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public AvatarConfiguration NOICIFDENOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Animator GNDJBBADDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public VRIK NALJIGKNPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GameObject[] LBNNLNBKCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform JMCIDFPGOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AssetReference PONONONHAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public GameObject BILJELPIOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public GameObject NALGFIGJAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer OLNDHGFIGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Material OKBKBOBGMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Material MFIIKJCGNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Material NKINMHHJCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Shader KHHMMBNMMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Shader NGBLJMHLKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform ODHHIHEBOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform KJCPDDMLNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform FEHAFMAEAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform NJEFPBKJGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform PPGPIAJDKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform MDOAIEHNGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform GMJGAFHDCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Renderer[] IDECEOOKEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform MLKDMAJCIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform NBJJENNDLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public GameObject ELIKOCEDKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GameObject MGAEHBCJGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public OIAGDKLIOKA BPDFOMOGJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public OIAGDKLIOKA DDDKKMEDNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public OIAGDKLIOKA EAOPDMNGMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public OIAGDKLIOKA FJGNHMPJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public OIAGDKLIOKA PBFDEAMBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public OIAGDKLIOKA ODAKAOPBEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public OIAGDKLIOKA EDAKMJOLAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public OIAGDKLIOKA LFFBIAKOHFF;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DJJNKJIIHPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public bool IJGHBKPFJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public OCINGNKOJDN BNAKJCPMFOF;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OGGLKAANNHD
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class GHLAIMMLHOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly bool NJOFAFBHKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly bool HNFLKOPBGKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly bool OKKNJJDNJOO;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6056E80", Offset = "0x6056080", VA = "0x186056E80")]
		public GHLAIMMLHOE(bool IFPOGGAOEHI, bool JJPHPPADPFM, bool BPJOAKANGBF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float JGFOKDNPEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool PEMIGOOCLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float NEPKHAPCDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Vector3 MHLGPJLCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3 KMDMHNEBMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Vector3? DOKBDHOHJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Vector3? KEJEDPEPEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool GJENFOFMEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool FBFPDKEDDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool FKKOJOKAEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool KJPICIICIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3? OFJLABFILKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool IOKDNONONII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? IMNHOMBFLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool DPLNHLJLBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Vector3? MCFEPMFMAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public float NGCIBOHAMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3? DPCKCMJOOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool NGPIHBFCACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool BPALGFHCBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool JBAOKKMJDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool DOEDGCCAFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool KMFBNNCGMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool BMBAEAFAGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool LMAMBGCCAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool CNLLBNCKKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool DFLAHDOFDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool EBOAOBHCNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool ONADCHHPCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? OEBONJFKJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public GCGKPAAFDCB OJPHPIDENLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public GCGKPAAFDCB AHJGHICGPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool OBIHPLGAPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool CFLBPJCOKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public GHLAIMMLHOE NEAIKJAKHJE;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x605ACB0", Offset = "0x6059EB0", VA = "0x18605ACB0")]
	public void GFEBFHCFDDM(Quaternion KIIONLKEIBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class IKOJPEKBLHB
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6058C50", Offset = "0x6057E50", VA = "0x186058C50")]
	public static MGDKKCABMBA DOEGKLGFAMD(this MABFNBCPJGB KPBGCHDNDLM)
	{
		return default(MGDKKCABMBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6058C70", Offset = "0x6057E70", VA = "0x186058C70")]
	public static void HJFFLBOOMIG(this MABFNBCPJGB KPBGCHDNDLM, MGDKKCABMBA AFCGKMGKPEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OIAGDKLIOKA
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float HDOBGNHLIBL);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private LLAIDNAJOMJ NPGHGIMCIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Collider[] PCBAGADKODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] GBINPIGPBFB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> KBBEMEOMELB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x605BAB0", Offset = "0x605ACB0", VA = "0x18605BAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private LLAIDNAJOMJ JHBNNOLJKKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x605B0D0", Offset = "0x605A2D0", VA = "0x18605B0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NGFNMFHCCMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD4C8E0", Offset = "0xD4BAE0", VA = "0x180D4C8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x605BA90", Offset = "0x605AC90", VA = "0x18605BA90")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer GPFKNDKFIEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x605B840", Offset = "0x605AA40", VA = "0x18605B840")]
		public void SetCollidersEnabled(bool CMIINBJIIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x605B410", Offset = "0x605A610", VA = "0x18605B410")]
		public void ReparentBonesUnderOtherBoneCollection(LLAIDNAJOMJ EHELIFJFPBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x605B170", Offset = "0x605A370", VA = "0x18605B170")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MOGJEKLBLJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Transform FKDDHEIJNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform FIGEODBGLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Transform CPIKFJOHIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform KEJKALLHNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Transform JFKHBJAIHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Transform EABKLHGAEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Transform OIGLFKNNDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Transform NNCLJAPDPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Transform FKDMPCEGDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation AGOKHPOBMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PositionAndRotation LCDBPFPHPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private PositionAndRotation IDAHGGGDCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private PositionAndRotation LMBEDDMDMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private PositionAndRotation APJLDPNFAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PositionAndRotation ILJLIPBKNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private PositionAndRotation FABKICJGHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PositionAndRotation BEGIEABKJBJ;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6059890", Offset = "0x6058A90", VA = "0x186059890")]
	public void AKCGAJHNOGB(Transform MACLBLPFBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x605A470", Offset = "0x6059670", VA = "0x18605A470")]
	public void OHJJPJLGCEF(HandLogicOffsets IEOOJHMCGJO, FHIMAIMKMAM CMNJFOHGCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6059F50", Offset = "0x6059150", VA = "0x186059F50")]
	public void CLDKJBDFJDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60597C0", Offset = "0x60589C0", VA = "0x1860597C0")]
	private PositionAndRotation ABMHDLAFECH(Transform KGHIGIKIHNJ, Transform KADKMOOFMHO)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x605A1A0", Offset = "0x60593A0", VA = "0x18605A1A0")]
	private void NMKFADLMNNI(Transform KGHIGIKIHNJ, Transform KADKMOOFMHO, PositionAndRotation IEPPHJKKACN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public MOGJEKLBLJF()
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
