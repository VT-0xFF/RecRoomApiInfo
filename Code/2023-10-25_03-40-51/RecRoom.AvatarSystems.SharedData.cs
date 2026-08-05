using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Avatars;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum CMADADBHHAK
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
public enum GMIBPBMCIDF
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
public struct CLOHEOCAKPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public CMADADBHHAK? BCKCKDJMEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public GMIBPBMCIDF? KIEHKBEEKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Transform BHNGONDHDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float? PGFKKDAGJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool? JGICLGCAJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool? HBAHLIFLIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool? JJBINJONJJK;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum IJACPLOCLOK
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum GJLPEKAOLFP
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
public static class CBPLGBFAKEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly string PHNGBOPBCCH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8C40", Offset = "0x5BA7A40", VA = "0x185BA8C40")]
	public static GMAAJKBCMFB CHGGPDKGHLH()
	{
		return default(GMAAJKBCMFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8B00", Offset = "0x5BA7900", VA = "0x185BA8B00")]
	public static JMCAMBAIGHN ADCKKLOJEBH(string FDKPNCEPFMK, bool FJBGKBCDFHE, bool DPDLNBBCBFN, bool OCBPELOJMLI, Func<BJCODBEHPAD> DEFAOFPMHCC, Func<GMAAJKBCMFB> ANDMKFDKKOA, RigidbodyEx KLKOGKPADNH, RigidbodyEx JJOHDMHOJNM, RigidbodyEx HFDEMKFNAKB, RigidbodyEx KAOEBBPGADC, Transform JNJAGDIINCG, Transform EFKOKBMJBCD, Transform DPDPOMAEKGL, float PHPHPODAGPG, float NKKKPDKIHPB, PlayerAvatarFullBodyColliders ONEJCOACABE)
	{
		return default(JMCAMBAIGHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8D90", Offset = "0x5BA7B90", VA = "0x185BA8D90")]
	public static OGGDODDAHDP LIFDHPDIMOH(HBJBPLHAOEF INCDGJAOBCB, int MMOBBHCNCGE, int IHFNCCEFFFP, Color GLMNPPHAMBH, Color FABPCALFOLL, int ANEKLADHCAJ, int FJIMLGJBMNK, Color PFFMCNEKLFO, Color GKIADLCFPNM, int LIGGJINGIOL, float HLGAKPKEMAD)
	{
		return default(OGGDODDAHDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8C80", Offset = "0x5BA7A80", VA = "0x185BA8C80")]
	public static ABEGDOLENBA EFCJPCNMBDD(HBJBPLHAOEF INCDGJAOBCB, Vector2 AGDOMNIHGFO, float POAIGBNCBLI, Vector2 GGAFMBDOCLO, float MODLIKMMJAM, Vector2 MLLCAKLGDPH, float DGBANNDJIIE, Vector2 LJCIPLALBKG, float FFHJKGJOPIO)
	{
		return default(ABEGDOLENBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8D30", Offset = "0x5BA7B30", VA = "0x185BA8D30")]
	public static CLOHEOCAKPB ILKDNBDCMHK([Optional] CMADADBHHAK? BADBFHBIABF, [Optional] GMIBPBMCIDF? JHNCPMMNDEB, [Optional] Transform CHHCJKENCKE, [Optional] float? OHLGFHHNJPG, [Optional] bool? OFCLPGJELBD, [Optional] bool? JMFGLBBFOIP, [Optional] bool? DLBOIFBINLN)
	{
		return default(CLOHEOCAKPB);
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
		[Cpp2IlInjected.Address(RVA = "0x5BA8A60", Offset = "0x5BA7860", VA = "0x185BA8A60")]
		public string JIHMNJOKJIH(string JMJGCIFNEIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BA8AB0", Offset = "0x5BA78B0", VA = "0x185BA8AB0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JMCAMBAIGHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string LCNIPNDFNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool JMENIGBALCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool KOLGLELMIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float ILMADKGKPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float FCENANJHFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool BLOMOMHHHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Func<BJCODBEHPAD> JFGBMFFMGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Func<GMAAJKBCMFB> IGDAHFMONNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public RigidbodyEx PPMEHNAOOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public RigidbodyEx MHGNHDDPIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public RigidbodyEx MBIDJBCOKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public RigidbodyEx DAOOCMFAGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Transform FCMGJLNMFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Transform PPEOIDOGAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Transform OPDFEEOMPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public PlayerAvatarFullBodyColliders GFIAPBNDDBH;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BJCODBEHPAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool MENMMAPEEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public CMHABJECOFN LFHHPMFGPFD;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GMAAJKBCMFB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AAAIEOKEPPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool KHHMGFJCCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly bool OIBEFKJAJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly bool CKACEOACCFC;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BA8A10", Offset = "0x5BA7810", VA = "0x185BA8A10")]
		public AAAIEOKEPPE(bool GCHBOFEGPDF, bool HLCGLFDLBDM, bool DHHPHDMIJPD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float IKKCFOFHFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public bool PDDHMHCLBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float NHJCLCPJABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector3 BOFKENCBPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector3 LJLJBEAAFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector3? KLHLHHJDLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector3? MLJBEJJKBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public bool JAGAMGHMPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public bool KAAALKOGBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool NBOFFJKHHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool MNPDJGLKKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool LEIMMGGDPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Vector3? PMEBELLDOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool FFEJKJFBIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Vector3? BHBBNECCLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool BBFBOFDCMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Vector3? ANOELJIEIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Vector3? CGHDAECPGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public bool CBIHILHFHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool MCBGEJFGNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool MOMOEBHGFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool GLPNGJMGDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool HBNANBDIJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool DJNGAMOPLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool FAKEPEKHHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool BAOKHANCMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool IEPOKJIKDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool MAMGEOOGEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Vector3? GBKJKHMIABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public GJLPEKAOLFP JLGJDOKGKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public GJLPEKAOLFP KKLMEMPJIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float BIKIABLMKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float MDPEKGIMKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public AAAIEOKEPPE EOGMDOOMCFI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BA8EB0", Offset = "0x5BA7CB0", VA = "0x185BA8EB0")]
	public void HAKFDANAFEG(Quaternion ALADLBOMNEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LAPMIDNLJBM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BA92D0", Offset = "0x5BA80D0", VA = "0x185BA92D0")]
	public static EDMKLHMOLIO HAMFBGCCKOH(this GLICEEHOPJP PECKHAMCEFO)
	{
		return default(EDMKLHMOLIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5BA92F0", Offset = "0x5BA80F0", VA = "0x185BA92F0")]
	public static void IHBEAKDNEBF(this GLICEEHOPJP PECKHAMCEFO, EDMKLHMOLIO POACLGOFKAJ)
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
		private BOKMHMICHEJ IJJOLJIOEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Collider[] ABACJLPLCBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] DFEIJFJICOD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Collider[] OKKICNKLGOM
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5BA9310", Offset = "0x5BA8110", VA = "0x185BA9310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private BOKMHMICHEJ AIIGIMKFIBN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5BA9380", Offset = "0x5BA8180", VA = "0x185BA9380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool MAGNEAAOJBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xBFB640", Offset = "0xBFA440", VA = "0x180BFB640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5BA9C20", Offset = "0x5BA8A20", VA = "0x185BA9C20")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer BKCMOKEJMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5BA9AF0", Offset = "0x5BA88F0", VA = "0x185BA9AF0")]
		public void SetCollidersEnabled(bool FCMINLNDGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5BA96C0", Offset = "0x5BA84C0", VA = "0x185BA96C0")]
		public void ReparentBonesUnderOtherBoneCollection(BOKMHMICHEJ HOENHAJJKBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5BA9420", Offset = "0x5BA8220", VA = "0x185BA9420")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
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
