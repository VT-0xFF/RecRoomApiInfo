using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Avatars;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum BLONGIHKCKK
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
	Grabbing
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum OJFHGAOKOBL
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	NotGrabbing,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	GrippedTrigger,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	BallGrip,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	FrisbeeGrip,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	WaterbottleGrip,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	FoodThickGrip,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	BucketGrip,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	MugGrip,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	SoloCupGrip,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	DartGrip,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	MarkerGrip,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	EraserGrip,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	LaundryCartGrip,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	ConstructionConeGrip,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	BoomboxGrip,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	BowHandleGrip
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ALKIGDEHDJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public BLONGIHKCKK? OPACADFBMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public OJFHGAOKOBL? GKJNFEMNEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Transform BPOCLLLAEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float? PEGDJAMDBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool? NKAGCBAEKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool? DINNHOMEHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool? BHCFJNDKKID;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum OCIIIMGJEEO
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JIKGFANENKE
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CannedWave,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class MJCIEMMLBHH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly string DDHKGNFPGHF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D37610", Offset = "0x5D36A10", VA = "0x185D37610")]
	public static JJKBPAMLNDA HKDPIEPBKDE()
	{
		return default(JJKBPAMLNDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D37700", Offset = "0x5D36B00", VA = "0x185D37700")]
	public static MDLNKDKGCKM KJGLOKCPKPO(string CBHKDKLEBAE, bool IGKGPHGBNLF, bool OHAGILDOPOD, bool EKGKKFMJILI, Func<GKPJCEKMCEP> NJPLLEKMCDG, Func<JJKBPAMLNDA> APMCMLJHMEP, RigidbodyEx OFGDPHKBGHN, RigidbodyEx AHEBDOABDND, RigidbodyEx EBNFFGACJFO, RigidbodyEx ADLPGFPKPPD, Transform PPAMFHKGPCA, Transform PJFIGBPHAEB, Transform JAEEGOFADHM, float HNMKHBMNAMA, float LOOOKHBDMEJ, PlayerAvatarFullBodyColliders EANOFAFFMFH)
	{
		return default(MDLNKDKGCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D37650", Offset = "0x5D36A50", VA = "0x185D37650")]
	public static KFIKAELFDNJ KIMPJPPLLHO(LCOHJFODCBF POEILOPBBJH, int PCBKFJEJGHK, int LICOAEJDGBG, Color HPDEDLKEGFD, Color DKCGNHODOBL, int IPJMGKABGJO, int LCHFPDFIJJK, Color AOOPEILDEHL, Color GFGBEBPLJMM, int MADJNBKNGHA, float OGAMHNNABBC)
	{
		return default(KFIKAELFDNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D37840", Offset = "0x5D36C40", VA = "0x185D37840")]
	public static JODHMKLNMCG LOHPOGNMDHB(LCOHJFODCBF POEILOPBBJH, Vector2 GNJIBJDHJEE, float GABFCPDEAKJ, Vector2 MKJHPCGIAKA, float IBIJNIOAOCK, Vector2 EKHHBEBJMNN, float IPFIHHMBDNN, Vector2 NOJHHFEKAIK, float IOKCPCGBNMI)
	{
		return default(JODHMKLNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D375B0", Offset = "0x5D369B0", VA = "0x185D375B0")]
	public static ALKIGDEHDJP BABLIDADANK([Optional] BLONGIHKCKK? OMJNOBGJJMO, [Optional] OJFHGAOKOBL? IDBBEACCJHD, [Optional] Transform ONKBPDKHCGB, [Optional] float? JEGPGIEKLIF, [Optional] bool? LHNHELEDLMF, [Optional] bool? CNEOFJBDLFC, [Optional] bool? LHODOHLAOIK)
	{
		return default(ALKIGDEHDJP);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D370B0", Offset = "0x5D364B0", VA = "0x185D370B0")]
		public string OANCPHGFMGO(string IKGKFMOFIIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D37100", Offset = "0x5D36500", VA = "0x185D37100")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MDLNKDKGCKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string ALLLCKACGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool HMGNKPIBHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool MBNNJHHNGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float LMKNGOENOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float NCFABHHOLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool GBBPAEDBFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Func<GKPJCEKMCEP> KOCFEGLNEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Func<JJKBPAMLNDA> POCJCLFPNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public RigidbodyEx ADMCNNNJPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public RigidbodyEx AFHOCKMBBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public RigidbodyEx APIDCEKBAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public RigidbodyEx JNHBIEMCGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Transform BKPJGJMDIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Transform DPHFAKLMLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Transform BDMGBCEEJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public PlayerAvatarFullBodyColliders FEPHGDHBLNO;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GKPJCEKMCEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool PNGMJPHNDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public EFOCEKEKLEE JBPONBLIGFM;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JJKBPAMLNDA
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AFEKAOFHKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool FPPOBBGEPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly bool JNEHJPBFAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly bool FPFBADHBDGF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D37060", Offset = "0x5D36460", VA = "0x185D37060")]
		public AFEKAOFHKHK(bool MBHIBHAIOMF, bool LAJAFPFHBKO, bool OLFEOACNOOE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float HIPFFOBKPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public bool EPPACOOHNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float OPANBIAJBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector3 MAKMMDFLDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector3 ECPPGILPICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector3? BDGDAKGEHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector3? FFHCIAIILFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public bool KGBPLMMOEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public bool JHHKEEOFLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool NBOFJONFHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool AIICILDBKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool LDBCMNBMOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Vector3? DDMFLIFOEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool NEPINMIBBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Vector3? DODLPFBLHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool MCMEPJAPGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Vector3? INKDIIMAMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Vector3? GDJICEOECLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public bool PHPNCOGNEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool HIPKNEIBAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool NGBOACDJPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool DBBPDDLHMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool LJPJNKDCBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool BCHPDNLOEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool NFFKNDCJPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool EHPFLJHMHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool NBMECCDOOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool MFBICKAJFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Vector3? OAHBAFNGGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public JIKGFANENKE NFMPJOKHDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public JIKGFANENKE KIHNDGIPGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float EPBPEELBPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float OFJNLMAKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public AFEKAOFHKHK CKCOMGDJFGH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D37190", Offset = "0x5D36590", VA = "0x185D37190")]
	public void JJMDAPKMEMM(Quaternion KCLDFAAPKAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EEJAHFCJKNC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D37150", Offset = "0x5D36550", VA = "0x185D37150")]
	public static BKGJCBGGAIP FNNNHMHKHHH(this OJFECICJMDA EAODMOEAJOC)
	{
		return default(BKGJCBGGAIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D37170", Offset = "0x5D36570", VA = "0x185D37170")]
	public static void GMCEMEDNHAI(this OJFECICJMDA EAODMOEAJOC, BKGJCBGGAIP NMENOOMOOJP)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private JGGEKHJOHLA AELPOIHLLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Collider[] AJKGIMBBHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] KIPFJNDEGEF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Collider[] IKGNDOANFNP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5D37A00", Offset = "0x5D36E00", VA = "0x185D37A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private JGGEKHJOHLA ELAHODAAKAB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5D37960", Offset = "0x5D36D60", VA = "0x185D37960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DBHONDPIEKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC73390", Offset = "0xC72790", VA = "0x180C73390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D38270", Offset = "0x5D37670", VA = "0x185D38270")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer CFPAGDMBAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D38140", Offset = "0x5D37540", VA = "0x185D38140")]
		public void SetCollidersEnabled(bool BFEPOIFAJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D37D10", Offset = "0x5D37110", VA = "0x185D37D10")]
		public void ReparentBonesUnderOtherBoneCollection(JGGEKHJOHLA OLILEFCDPHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D37A70", Offset = "0x5D36E70", VA = "0x185D37A70")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x772DA0", Offset = "0x7721A0", VA = "0x180772DA0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
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
