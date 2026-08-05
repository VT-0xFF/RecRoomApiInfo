using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Avatars;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AOMEOBPIGAK
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
public enum HAFHEEELHCF
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
public struct CLEMPNADMBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public AOMEOBPIGAK? KCLHHOGMJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public HAFHEEELHCF? AMPHBPFJGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public Transform HDEOJONOELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float? GOPNGGIJHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public bool? KNIFAHCLEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool? NKCACMKIEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool? CHNNEIMLDBG;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BDLHEELLMFL
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum PLDKDHBBHDN
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
public static class BFFAKBHFIKA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly string MNLIBABODLA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D195B0", Offset = "0x5D185B0", VA = "0x185D195B0")]
	public static KELCHGKNLMK NDJOFHMOFAD()
	{
		return default(KELCHGKNLMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D19410", Offset = "0x5D18410", VA = "0x185D19410")]
	public static PHJOKCJDLKA KDDOFOLPJBH(string GNOGKKDFNBD, bool EOGPLKNOEMM, bool ABPKDJAEEKO, bool OLOCDNKNAJI, Func<OLNDMLDJFOO> HCGPIJABPFE, Func<KELCHGKNLMK> FAJNMBNICBJ, RigidbodyEx IJCOPEEBMFA, RigidbodyEx GMJIEPMDKBA, RigidbodyEx PPFFAOAMKBO, RigidbodyEx FOCPACKCHJJ, Transform PJEIPIBPBPP, Transform DMNGKLLOEIO, Transform MHAPKPJEAOJ, float CJBIDHHJOEO, float NNDMAHOGLIH, PlayerAvatarFullBodyColliders HLOGKFAEMHH)
	{
		return default(PHJOKCJDLKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D19360", Offset = "0x5D18360", VA = "0x185D19360")]
	public static LFDLAJKBJEJ GGDHAIAMDBM(PLJKLFEOKNC PBHNFFEEHAD, int ODLBNPDANOF, int CKFJGACMHOE, Color HJEFGDHDJAO, Color JDFFNDPPHBF, int FHFJJJMNGAB, int OMINAMJIPMB, Color GHPMLKEMPKF, Color FNGNHNIJFIO, int LJBCOBCOMFB, float INCOIADKGNK)
	{
		return default(LFDLAJKBJEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D192B0", Offset = "0x5D182B0", VA = "0x185D192B0")]
	public static KAHGIPCLOHH EECCEDEAOID(PLJKLFEOKNC PBHNFFEEHAD, Vector2 ILGECKAAENF, float MNNMIKNNPIP, Vector2 NGLEBJAEJLF, float AOKAOCABLPG, Vector2 ODNKINBKINI, float MOEDIJHECLN, Vector2 FHMNIGKMGFN, float LBOIJGDDGBN)
	{
		return default(KAHGIPCLOHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D19550", Offset = "0x5D18550", VA = "0x185D19550")]
	public static CLEMPNADMBE MJPFNPIFPEP([Optional] AOMEOBPIGAK? DGGBONABJNM, [Optional] HAFHEEELHCF? KMHJMPCDNKP, [Optional] Transform FGDELCMIOGK, [Optional] float? JBPNJNGDKLM, [Optional] bool? OMCBIJOBFEM, [Optional] bool? IAIJMCJCLIA, [Optional] bool? MGMGKDLJOMM)
	{
		return default(CLEMPNADMBE);
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
		[Cpp2IlInjected.Address(RVA = "0x5D19210", Offset = "0x5D18210", VA = "0x185D19210")]
		public string FFALDIJDPML(string OINNPBJBFPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D19260", Offset = "0x5D18260", VA = "0x185D19260")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PHJOKCJDLKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string CGGCNKJNKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool EIINLJBPIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public bool IICGKHNKDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public float MNGHFPBFBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float OJLLPNOOIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool CKNMNJAFILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Func<OLNDMLDJFOO> NDILNAJPLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Func<KELCHGKNLMK> PBOFLDFLODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public RigidbodyEx MBOGCAAIAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public RigidbodyEx EDLMNLHFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public RigidbodyEx DHDAGNFKBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public RigidbodyEx FLMFLFPIKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Transform FPLAPCEAFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Transform BGAJEHPBHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Transform CELCKHDFJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public PlayerAvatarFullBodyColliders NPLOMKNCALO;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OLNDMLDJFOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public bool IEENCDGNJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public FDHMLINJMLJ GKGBENLCHHD;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KELCHGKNLMK
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FAMCCGBIFFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly bool BIOAJACHHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly bool NLAJHLNFIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly bool CMGDCNDHEPA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D19660", Offset = "0x5D18660", VA = "0x185D19660")]
		public FAMCCGBIFFE(bool COEBCGLDGNL, bool KBIMNCPLFJC, bool HBBOKNGNLCA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public float MDEEKDBOBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public bool PKJOMPBNEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public float GDLLMINEGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector3 DMOIPILLMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector3 PABCNAOOGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector3? PJCOBCJOFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector3? AMHAIHFIDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public bool MBCEOBBJHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public bool KFNADHBNANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool HNKHLKFNBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public bool EJPNDGIMBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool MCKILHHFICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Vector3? DEAAJCLHJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public bool BPHJJOGKPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Vector3? PBCLPCPCEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool DFOOHBNLHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Vector3? MEHGMGCOKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Vector3? OHBKHOBJGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public bool EFBIBHMBLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public bool GEILHCAMAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool MAGBKENBMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool NCECMIEDONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool JINCPEPCAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public bool IBGICJKKANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool GLPFBHPFCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public bool MFGKOHBAKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public bool BKAIFACBAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool OBJHJLMLNNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Vector3? JABLCKFJPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public PLDKDHBBHDN ODIDLDDLOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public PLDKDHBBHDN PHGOPPBLBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float FLOHCNKADMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float KPCBEACAKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public FAMCCGBIFFE FDNHHFMPFJH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D196F0", Offset = "0x5D186F0", VA = "0x185D196F0")]
	public void MCIHPDFLFBH(Quaternion LGOFCBEILGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JMHPNDOGONE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D196B0", Offset = "0x5D186B0", VA = "0x185D196B0")]
	public static GDCDAJMMLIB EJJGPCJMJKC(this BEGAHDJKPIF IEOMMHOPOKN)
	{
		return default(GDCDAJMMLIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D196D0", Offset = "0x5D186D0", VA = "0x185D196D0")]
	public static void LKFAOLDEOJH(this BEGAHDJKPIF IEOMMHOPOKN, GDCDAJMMLIB APPJEOKOGAK)
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
		private HFMDAEIGGGC AJKCIFMPMEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private Collider[] MJHELMEJENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] GDJIHLABPPL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Collider[] BMAJADHMMMG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x5D19BB0", Offset = "0x5D18BB0", VA = "0x185D19BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private HFMDAEIGGGC JIAMHKNAMCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5D19B10", Offset = "0x5D18B10", VA = "0x185D19B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool FKJBBGGCFDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC3BF70", Offset = "0xC3AF70", VA = "0x180C3BF70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A420", Offset = "0x5D19420", VA = "0x185D1A420")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer BFDEMDOMILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A2F0", Offset = "0x5D192F0", VA = "0x185D1A2F0")]
		public void SetCollidersEnabled(bool NHIMOAGIDEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D19EC0", Offset = "0x5D18EC0", VA = "0x185D19EC0")]
		public void ReparentBonesUnderOtherBoneCollection(HFMDAEIGGGC FNLHOAAMKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D19C20", Offset = "0x5D18C20", VA = "0x185D19C20")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
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
