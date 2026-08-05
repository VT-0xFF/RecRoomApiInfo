using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Avatars;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NGNHPAPNOGA
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
public enum AOOFKIIHDNB
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
public struct GICPBNNDHKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NGNHPAPNOGA? HEJNNPNIBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public AOOFKIIHDNB? MEMHKJNDOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Transform BNLGMGFPINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float? KODAPPAEFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool? NIAHHEPMFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool? DONFHGEBKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool? OFABIOKGHPI;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EAHDGODKODE
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum POEPJDKBJPP
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
public static class AGMLGMPAMFA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly string HGDOHKOGFGE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D35BD0", Offset = "0x5D343D0", VA = "0x185D35BD0")]
	public static BECPHPLDPGG BJPCECKEGOC()
	{
		return default(BECPHPLDPGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D35C10", Offset = "0x5D34410", VA = "0x185D35C10")]
	public static KILGGAPFJPH EGJCBBIGJDA(string DNHOKABFOMN, bool AMEDMOBLFAE, bool BJGCFOBCOLP, bool MDEBOHGIOGK, Func<OKAFOCAIBNN> IMNIDDDBKHJ, Func<BECPHPLDPGG> LCFNFKOFGJD, RigidbodyEx KNPCGDOOHAG, RigidbodyEx HIGPCCLLHGC, RigidbodyEx LJDBCBLNDAM, RigidbodyEx KGOMEJGJIOC, Transform OGEHILBPOJA, Transform MCDHAMDMKLH, Transform MFOMLBCPMII, float MOJPOLHAMJB, float KLGOEIKDEDJ, PlayerAvatarFullBodyColliders HNHEOBDBCMM)
	{
		return default(KILGGAPFJPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D35D50", Offset = "0x5D34550", VA = "0x185D35D50")]
	public static BLBMGDADDJJ HGBAOCJGPLN(IHHFLFOBFPM MDJMBCOBHAA, int HDBJEKCBKNM, int FABFHFODHPJ, Color BADAEGJKNLP, Color NLFGLGGLOBM, int OBDDBINMBEM, int DBNDPLKLDFA, Color FBGLDJNNBNN, Color FNILPLKFCFA, int DOKDGJKHCHI, float OCOHFIIKFME)
	{
		return default(BLBMGDADDJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D35E60", Offset = "0x5D34660", VA = "0x185D35E60")]
	public static KCGLHDAGKFL PPAJFPNBNGB(IHHFLFOBFPM MDJMBCOBHAA, Vector2 ONFEGFIJIAF, float GAFOKGGPCHP, Vector2 ANPHHKAMMHL, float HHHHKPLKKFM, Vector2 JLAHJCFDODA, float HPGCKDHKNJJ, Vector2 HLAMIACFMGE, float EENBBACNEKI)
	{
		return default(KCGLHDAGKFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D35E00", Offset = "0x5D34600", VA = "0x185D35E00")]
	public static GICPBNNDHKB LHFGJHHLMIO([Optional] NGNHPAPNOGA? NEKJEADMNJL, [Optional] AOOFKIIHDNB? FCACBCGNBIP, [Optional] Transform POAIJLJLPHC, [Optional] float? DKFALOBAEPC, [Optional] bool? CJMMDIJEBJD, [Optional] bool? PBELCKMEGMG, [Optional] bool? JMLAKIKCMHC)
	{
		return default(GICPBNNDHKB);
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
		[Cpp2IlInjected.Address(RVA = "0x5D35F80", Offset = "0x5D34780", VA = "0x185D35F80")]
		public string AFLCNDKBKMK(string JGHCILHMNNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D35FD0", Offset = "0x5D347D0", VA = "0x185D35FD0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KILGGAPFJPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string HEEJPHJAMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool GEHPFLOBGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool FNMGDIDLDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float IIJEBHKPKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float DMAHGJPPIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool IPEFPKNAMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Func<OKAFOCAIBNN> KHHLPCNFDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Func<BECPHPLDPGG> FNBCMACEFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public RigidbodyEx NFOFBBCFOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public RigidbodyEx JECPHDPHEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public RigidbodyEx JDAKCEADNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public RigidbodyEx NGEINAKONCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Transform PPIFKEMHJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Transform NOMKIKEJKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Transform PAJMDNEPBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public PlayerAvatarFullBodyColliders KFAHLPOELOH;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OKAFOCAIBNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool NNNNAKJMCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public CNMEGLEHJFK INLINDNHMPH;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct BECPHPLDPGG
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MLKEPICINLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool BJHIAPBMOOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly bool AINJJFNHDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly bool OHKLMNANAIP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D36480", Offset = "0x5D34C80", VA = "0x185D36480")]
		public MLKEPICINLG(bool CLMFOJBHNAB, bool LKFDKOBKCCM, bool ENHNHJGCJHC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float LBFHFHBOMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public bool CDINOINCENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float MOBBAHOEBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector3 DKAEHJALFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector3 AIMIOEBDFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector3? HLALCCAAOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector3? BCPDDMMPEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public bool LPIJNHDMPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public bool AJJAKPPFFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool ANEENMJGMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool HDMNAIMBJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool NHPBHPOLKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Vector3? KICBKBJGPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool DNMMFBPELDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Vector3? LNDLDGDEAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool ONEHGKCJMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Vector3? NINGAIAJCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Vector3? DHAHLCKMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public bool MPMJOLCKADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool GAFOEEOJKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool OJDKJFONEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool CGAHEOHFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool PBKJFCPIOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool MLNDINFPCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool OABLKMCNBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool MKLJBKPEJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool LNDIAHCJJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool HDCAKFMAJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Vector3? FIPCFODPLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public POEPJDKBJPP FOJJOONJAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public POEPJDKBJPP PDGFIDIALPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float KIIKLKOPALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float HPNKBFBGBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public MLKEPICINLG IJBAIHEBGDA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D36020", Offset = "0x5D34820", VA = "0x185D36020")]
	public void KBGMFIIMMAD(Quaternion JOBDANNFLEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DEFDEEEOMIB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D36440", Offset = "0x5D34C40", VA = "0x185D36440")]
	public static JFMNOKBIDAL JNKCGKKHJEO(this LDHBNHCJKJO PIEBBHMNEOG)
	{
		return default(JFMNOKBIDAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D36460", Offset = "0x5D34C60", VA = "0x185D36460")]
	public static void LECHAIJPCGJ(this LDHBNHCJKJO PIEBBHMNEOG, JFMNOKBIDAL DOLICEBFIPF)
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
		private HCOIDAOHLDC DHDCLDEPPKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Collider[] FKMPEELABOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] EAEABEILLLG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Collider[] EKEIPGBPLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5D364D0", Offset = "0x5D34CD0", VA = "0x185D364D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private HCOIDAOHLDC DMDDPDKJFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5D36540", Offset = "0x5D34D40", VA = "0x185D36540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GLKCILJHKGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC741D0", Offset = "0xC729D0", VA = "0x180C741D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D36DE0", Offset = "0x5D355E0", VA = "0x185D36DE0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer KINMPCCPLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D36CB0", Offset = "0x5D354B0", VA = "0x185D36CB0")]
		public void SetCollidersEnabled(bool KAJOKJADDID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D36880", Offset = "0x5D35080", VA = "0x185D36880")]
		public void ReparentBonesUnderOtherBoneCollection(HCOIDAOHLDC JNDABJCDCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D365E0", Offset = "0x5D34DE0", VA = "0x185D365E0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7721F0", Offset = "0x7709F0", VA = "0x1807721F0")]
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
