using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Avatars;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum EJOLDPDJGFD
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
public enum CFOBDHLIPHK
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
public struct JFJLDBBBGGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public EJOLDPDJGFD? GOOMOHJHPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public CFOBDHLIPHK? ICMCBALDGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Transform LHGEHAGDJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float? GHFHPNCIEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool? DKKDCKJEPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool? CMBCKKHFPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool? AAEKFPGDBIO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DJDBCCIPELJ
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BBNFJHHGBNE
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
public static class MDKLMAPEGFO
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly string CHAODOCDLJO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7510", Offset = "0x5BA6910", VA = "0x185BA7510")]
	public static FHAGNKDJPJH GBFFJAKLCFP()
	{
		return default(FHAGNKDJPJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7550", Offset = "0x5BA6950", VA = "0x185BA7550")]
	public static AGEHBLDMNMH OCAJFNFAKFN(string KACKMHKNFCD, bool ECOKPBCHKMF, bool FDNCAOKKBNG, bool EHABCBIMJBF, Func<NHEBCBLJEMG> FJIKOCLKMBG, Func<FHAGNKDJPJH> CMOFKPAPGOM, RigidbodyEx GLGEJEELMGE, RigidbodyEx FLBGDMDFBIG, RigidbodyEx PNKJDOBFCDG, RigidbodyEx IAILILBBMFL, Transform IHCIICBONFD, Transform DEPOLFJAOKK, Transform JJOKBAMNIIB, float GIHKJGGEEKN, float LMDOIJLDHHP, PlayerAvatarFullBodyColliders AJLEGGPLDMC)
	{
		return default(AGEHBLDMNMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7690", Offset = "0x5BA6A90", VA = "0x185BA7690")]
	public static GNBLIFNFCBI PHEBKGBLNAP(DMHKLCPNFMM GJLJDAPFEKO, int JADJPHLPMGE, int PKIEAJPJEMO, Color IDGPHMCCBMG, Color DMAEGECEPFB, int LIAEAGMDGFG, int NPNBDFJKJJA, Color INMOBPEEDOP, Color ICFDLNOPGIL, int GBOJOPPLHKN, float KALADKMGMOP)
	{
		return default(GNBLIFNFCBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7460", Offset = "0x5BA6860", VA = "0x185BA7460")]
	public static ACGAMNOAAEO EJNDEFCBMGL(DMHKLCPNFMM GJLJDAPFEKO, Vector2 JJKOLFDKNIB, float OIENLAJNAOE, Vector2 BLAIJDBKJJG, float JKMCPELANKL, Vector2 LOLDFOALBKM, float PENGIIEJNDN, Vector2 EKNHKKCJHPC, float PBLHGNLAHBA)
	{
		return default(ACGAMNOAAEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BA7400", Offset = "0x5BA6800", VA = "0x185BA7400")]
	public static JFJLDBBBGGB DJDLBHMBOFG([Optional] EJOLDPDJGFD? LLFAFJPFJLP, [Optional] CFOBDHLIPHK? GDCFLFAOKNJ, [Optional] Transform BPGCNKFDJGK, [Optional] float? LCILFLFOKPO, [Optional] bool? PMOOMPJFACF, [Optional] bool? DPBOGBDOIOI, [Optional] bool? EHOBGNHGPOH)
	{
		return default(JFJLDBBBGGB);
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
		[Cpp2IlInjected.Address(RVA = "0x5BA6EB0", Offset = "0x5BA62B0", VA = "0x185BA6EB0")]
		public string CGHMCKBBKIE(string NCGDNHODJJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5BA6F00", Offset = "0x5BA6300", VA = "0x185BA6F00")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct AGEHBLDMNMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string HPDECNEHIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool EJKGNDBHJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool LFHICEJMKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float DKACJKAIAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float NAECLBFIDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool IMMNNPEDLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Func<NHEBCBLJEMG> JLABKECOHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Func<FHAGNKDJPJH> KKHKFDFIPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public RigidbodyEx ECEJLCDNENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public RigidbodyEx PDCHAHHDNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public RigidbodyEx HAIGKCKLJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public RigidbodyEx DKNLIEDNAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Transform CGJEPFHNEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Transform MELLFJFNMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Transform BCAHMGBHOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public PlayerAvatarFullBodyColliders NFCPCPACFIM;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NHEBCBLJEMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool FFPEDPCJIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public ADKLLFONPNJ GMEHMOGEGJD;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FHAGNKDJPJH
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class HHAFKLNMKPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool FGLHBFCKHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly bool IECHKICDIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly bool BOBCNMPIHCG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BA7370", Offset = "0x5BA6770", VA = "0x185BA7370")]
		public HHAFKLNMKPI(bool HJPDOLMHODJ, bool AHLFCHALBIP, bool JAGNKEJDCEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float AKBPEHCGMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public bool FIKKKOPHLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float EPOONGMBJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector3 OOPGNDECFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector3 CPENDHKPFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector3? AJHAONHMNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector3? MAFLKNHDOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public bool NKLKFNCFCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public bool CBFNJAJIFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool AJNFHGBNNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool FBIPHOOFBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool KMCPPNHINGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Vector3? OLMCDEDBPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool HKFMNOEACKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Vector3? JCJFJNKPHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool CPOMKBHIDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Vector3? MIAEMNHCOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Vector3? GMAKLOIOMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public bool PLFFLJLMCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool APGPLJEHMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool EBIHHLPCMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool BGLOEJIMOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool PHCIDELOMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool OHLBMJNJJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool OJGJLECGIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool NLCKHMNOFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool JGNECEIEEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool PDKEBDEEAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Vector3? MIPCOCALFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public BBNFJHHGBNE KALDOFAHIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public BBNFJHHGBNE LDEDMOEDFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float IEBKLPEKICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float LGGPFANGHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public HHAFKLNMKPI OJCLAHGCEJP;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BA6F50", Offset = "0x5BA6350", VA = "0x185BA6F50")]
	public void FCMCMMKENCG(Quaternion KBKHJHIFKGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HPLDBLLGOKD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BA73C0", Offset = "0x5BA67C0", VA = "0x185BA73C0")]
	public static PAPKNMIEAPO KPPLPMNOGDN(this FGEKMJDGEOD LDMHFMNLDHG)
	{
		return default(PAPKNMIEAPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5BA73E0", Offset = "0x5BA67E0", VA = "0x185BA73E0")]
	public static void OKFLEIFHIFK(this FGEKMJDGEOD LDMHFMNLDHG, PAPKNMIEAPO EOHMJBFGDPD)
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
		private AECHJODMHID JACFFGEHPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Collider[] FDOFKHDNOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] GINADAEOBDC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Collider[] LDMEEJLOOCL
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5BA77B0", Offset = "0x5BA6BB0", VA = "0x185BA77B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private AECHJODMHID LGDDDPKOOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5BA7820", Offset = "0x5BA6C20", VA = "0x185BA7820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KMOLHHCGMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xBFA670", Offset = "0xBF9A70", VA = "0x180BFA670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5BA80C0", Offset = "0x5BA74C0", VA = "0x185BA80C0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer HFLDPMGKHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5BA7F90", Offset = "0x5BA7390", VA = "0x185BA7F90")]
		public void SetCollidersEnabled(bool EGKJFJONNCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5BA7B60", Offset = "0x5BA6F60", VA = "0x185BA7B60")]
		public void ReparentBonesUnderOtherBoneCollection(AECHJODMHID AKFLBGIOKOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5BA78C0", Offset = "0x5BA6CC0", VA = "0x185BA78C0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
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
