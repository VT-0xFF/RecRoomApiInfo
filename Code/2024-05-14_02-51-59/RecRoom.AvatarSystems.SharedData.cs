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
public enum MLJIIJGFFHE
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
public enum JIOOCOJMACC
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
public struct DBHKFJIHFFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator NOIALIGDMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public HKBGLIPENJH NMCAPGKFOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration PLIHCIOADEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject LIEKEMMDHOA;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OHGDFPPDAHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform BKLMOFNHKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool OLEEBIJAKAJ;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum HKBGLIPENJH
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NJEPMHMFMFN
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
public struct GIMEAAOKOMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Vector2 FOMHEGBOHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector2 GPGKJEMDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector2 OECKKKCJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector2 JKFPKBBNMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector2 BEINLJMIEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 LFIEKOONOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 BFEIFIMIJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 KGMPALKEECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 FLJBLNMNFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 EIAAHEIPMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 JEJCEEDMFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 FJHODMFMKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 JHFIGGAKLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 CCGNBLKPJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 DIJAJMEKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 NJPEPAENADC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OHOEBHPIMCF
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly string MJGLCNIAOEB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x622B5D0", Offset = "0x6229FD0", VA = "0x18622B5D0")]
	public static ELJDAEBKIKC PBIKPMCCMEG()
	{
		return default(ELJDAEBKIKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x622B610", Offset = "0x622A010", VA = "0x18622B610")]
	public static MINOBPJNDBN PKBBFKPHOPE(Transform IDOHLBJMFCJ, Transform AECMCGLJJJO, AvatarConfiguration FJJFOHOHMDC, Animator FDPHAOPPMBE, VRIK NLCDDENAMKJ, GameObject[] IHJIBDLAMDM, Transform BNMBNBPEMIA, AssetReference DMGFCHELKMB, GameObject NDNFPHOECCF, GameObject HGMCCBIBILJ, SkinnedMeshRenderer PCEGOMLDKAE, Material OLGCKBKBGOE, Material HDOIFKDLNNA, Material OALOALDKOEG, Shader FLABDIKCOKC, Shader LFPIKIABBOD, Transform ILJEKIGKBCK, Transform NJFFHEMFMDH, Transform HJHMFBLKMON, Transform AOAAOALBLDJ, Transform BCJGFFMKLPH, Transform BFHMDAJFNNH, Transform LMKJICDKAFC, Renderer[] KGNABGIHLCC, FJKOEONHJGH KJLNMFCNMBH, FJKOEONHJGH ICHCKNEKDFN, FJKOEONHJGH FGKKPIMIMLJ, FJKOEONHJGH LMMANBLDBHL, FJKOEONHJGH DNADCKBBHLD, FJKOEONHJGH JJGOIJJKANM, FJKOEONHJGH JGJPJKMBMCL, FJKOEONHJGH OJAIIMMENLO, Transform JENKHDPGIJB, Transform JNINJNKNAEN, GameObject OILMAABHJLD, GameObject BPGLPJDIJCI)
	{
		return default(MINOBPJNDBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x622B430", Offset = "0x6229E30", VA = "0x18622B430")]
	public static INKOKDMKPEE IHBGHBFIPBM(string GIFIGDCOKMC, bool LBCMEDIOHPG, bool BLJPLADOGAK, bool HJDOJHPDMNB, Func<FGKMNPELKPI> LFDDFMFHKJE, Func<Vector3, ELJDAEBKIKC> DCHFFDNKFJP, RigidbodyEx OCEJLAJDLPJ, RigidbodyEx KIAPMGIALBD, RigidbodyEx PPMOLPJIBBJ, RigidbodyEx HKCIHOLFGMI, Transform NJNAPKNDLGP, Transform JALPKEFOHHN, Transform AIAMJKBEKBC, float FGAKKKHBMFN, float EGDMABAEANE, PlayerAvatarFullBodyColliders LGANMDNHMFO, SkinnedMeshRenderer[] FAHHLEILOKN, SkinnedMeshRenderer[] PKBNOGGADJG, SkinnedMeshRenderer[] BEOOMPGNAKB, SkinnedMeshRenderer[] NHHNHNGCGJE)
	{
		return default(INKOKDMKPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x622B020", Offset = "0x6229A20", VA = "0x18622B020")]
	public static JMFJNMCGOPI BFJADFOGLME(Transform AECMCGLJJJO, AssetReference DMGFCHELKMB, GameObject NDNFPHOECCF, GameObject HGMCCBIBILJ, SkinnedMeshRenderer PCEGOMLDKAE, Material OLGCKBKBGOE, Material HDOIFKDLNNA, Material OALOALDKOEG, Shader CBDGLLEMNNC, Shader JBGEAJDKNAC, Animator MNLNHKAOGGJ, Renderer[] KGNABGIHLCC, AvatarConfiguration ICLBFBLGFJM)
	{
		return default(JMFJNMCGOPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x622B3B0", Offset = "0x6229DB0", VA = "0x18622B3B0")]
	public static MBNCAEBANBB GDOIFBPGOHE(SkinnedMeshRenderer[] FAHHLEILOKN, SkinnedMeshRenderer[] PKBNOGGADJG, SkinnedMeshRenderer[] BEOOMPGNAKB, SkinnedMeshRenderer[] NHHNHNGCGJE)
	{
		return default(MBNCAEBANBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x622B200", Offset = "0x6229C00", VA = "0x18622B200")]
	public static HEHLGEJLBPF CKNFDDELLPG(Transform ILJEKIGKBCK, Transform HJHMFBLKMON, Transform NJFFHEMFMDH, Transform AOAAOALBLDJ, Transform BCJGFFMKLPH, Transform BFHMDAJFNNH, Transform LMKJICDKAFC, AvatarConfiguration FJJFOHOHMDC)
	{
		return default(HEHLGEJLBPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83EA70", Offset = "0x83D470", VA = "0x18083EA70")]
	public static FKNAEFHCDDH ENAPBFBBFDB(SkinnedMeshRenderer[] KFFOOOEAKOG)
	{
		return default(FKNAEFHCDDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x622B310", Offset = "0x6229D10", VA = "0x18622B310")]
	public static OBEEACAADBG FONLLCANNAG(CBBDDFPEFMJ COLMONLPNCH, int MAPIKDGGAJJ, int AHNOOOMGEMC, Color OBIMNDMGBNA, Color DENOIOEFFDK, int IBIABGJGDCA, int IOCDKEJEFNA, Color LPEIMJOPLMJ, Color HGLIHMAELHP, int NJMHGPJGJCD)
	{
		return default(OBEEACAADBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x622B150", Offset = "0x6229B50", VA = "0x18622B150")]
	public static LPMABDDJJDG BFJHIKCILCP(CBBDDFPEFMJ COLMONLPNCH, Vector2 AEEPAHECCNF, float EOCKMBBJOMG, Vector2 NOAPHMKPNAJ, float CDMOHNGJHAM, Vector2 ICHAHLFDAKJ, float AOHGGCBDGOD, Vector2 MMFAHNFODAB, float NDBJDBPCPIP)
	{
		return default(LPMABDDJJDG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x622AFB0", Offset = "0x62299B0", VA = "0x18622AFB0")]
	public static DBHKFJIHFFG AOECHGPMPFE(Animator CIAAGGIGLNN, HKBGLIPENJH OGJCBPIMDOO, AvatarConfiguration ICLBFBLGFJM, GameObject GBNFAHOIIHP)
	{
		return default(DBHKFJIHFFG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x622B2D0", Offset = "0x6229CD0", VA = "0x18622B2D0")]
	public static OHGDFPPDAHB DMEJGHLCOOD(Transform NCHCHDHLBDM, bool BLJPLADOGAK)
	{
		return default(OHGDFPPDAHB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HEGEBNBMJAO
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6229890", Offset = "0x6228290", VA = "0x186229890")]
	public static MLJIIJGFFHE PBELLKCLHJN(this NJEPMHMFMFN APOCOGKDFNL)
	{
		return default(MLJIIJGFFHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6229880", Offset = "0x6228280", VA = "0x186229880")]
	public static bool FDLDNACGGIE(this NJEPMHMFMFN IAMCKFPBDPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BDKBNHBIPHK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FIMIOLLAOBB : BDKBNHBIPHK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform LJJCGBHAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 NHNGOKNMNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDCA950", Offset = "0xDC9350", VA = "0x180DCA950", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDCA980", Offset = "0xDC9380", VA = "0x180DCA980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? NOKGPDMCGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDCA940", Offset = "0xDC9340", VA = "0x180DCA940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDCA970", Offset = "0xDC9370", VA = "0x180DCA970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public FIMIOLLAOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class AMCAHBFPFKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected readonly FIMIOLLAOBB KDFIFPAOIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly FIMIOLLAOBB KBFKJOAIFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly FIMIOLLAOBB BBACINBLCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly FIMIOLLAOBB PIIAPIOKBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected readonly FIMIOLLAOBB NKJMLKILJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly FIMIOLLAOBB AEHDGFCDGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly FIMIOLLAOBB HLFEIBBNDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly FIMIOLLAOBB JGEOMDPEICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly FIMIOLLAOBB ONKEIGJNOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly FIMIOLLAOBB JBPFDPMBLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly FIMIOLLAOBB EHDFPANMPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly FIMIOLLAOBB BFMFEBCBCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly FIMIOLLAOBB PPPDJCCIJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected FIMIOLLAOBB BDFJJAMNJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly FIMIOLLAOBB HEMBELNOAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly FIMIOLLAOBB HKKDMIJCKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly FIMIOLLAOBB JELFNFMLPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected FIMIOLLAOBB DHLIFAOPNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly FIMIOLLAOBB CJJMBMOCLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly FIMIOLLAOBB EPPOJJFAELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly FIMIOLLAOBB FBFBGNMDAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected ReadOnlyCollection<FIMIOLLAOBB> ICMOFGMEBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform BNMBNBPEMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private (FIMIOLLAOBB Start, FIMIOLLAOBB End)[] KMAJOKMCEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private Dictionary<string, FIMIOLLAOBB> HBHGKAOGHLA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BDKBNHBIPHK IJIJANIIFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BDKBNHBIPHK EHNPHEMCAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BDKBNHBIPHK PMKEFOIDMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BDKBNHBIPHK KFBKBLFCMHL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BDKBNHBIPHK GCHIBNHEMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BDKBNHBIPHK HJDNEHOPMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AB0", Offset = "0x7C44B0", VA = "0x1807C5AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BDKBNHBIPHK KAOGDHAOMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6940", Offset = "0x7C5340", VA = "0x1807C6940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BDKBNHBIPHK ADPFKMHIBJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6960", Offset = "0x7C5360", VA = "0x1807C6960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BDKBNHBIPHK BLJEOGKIECI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C68D0", Offset = "0x7C52D0", VA = "0x1807C68D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6227EF0", Offset = "0x62268F0", VA = "0x186227EF0")]
	public void EOKCFBJDIMD(VRIK OBHGABIMBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6228E10", Offset = "0x6227810", VA = "0x186228E10")]
	private void OINHMMAKFHC(Transform HIHHIJKIJFM, FIMIOLLAOBB PJDANIPAHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6227D50", Offset = "0x6226750", VA = "0x186227D50")]
	public FIMIOLLAOBB DOJKLPAOCDE(string CKOCOBJKKJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6227940", Offset = "0x6226340", VA = "0x186227940")]
	public void BMFECIIOJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6228DD0", Offset = "0x62277D0", VA = "0x186228DD0")]
	public float FLOKIIGKBHN([In] (FIMIOLLAOBB Start, FIMIOLLAOBB End) FGPIHFJINFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6227790", Offset = "0x6226190", VA = "0x186227790")]
	public void BGFPCENPIEC([In] ELJDAEBKIKC MLJADEFEEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6227DC0", Offset = "0x62267C0", VA = "0x186227DC0")]
	private Vector3 EJKOEBMMAMA([In] (FIMIOLLAOBB Start, FIMIOLLAOBB End) FGPIHFJINFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6228EA0", Offset = "0x62278A0", VA = "0x186228EA0")]
	public AMCAHBFPFKN()
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
		[Cpp2IlInjected.Address(RVA = "0x6229380", Offset = "0x6227D80", VA = "0x186229380")]
		public string DPHGNKLGBKB(string BDMFDGLNOEE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62293D0", Offset = "0x6227DD0", VA = "0x1862293D0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct INKOKDMKPEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public string HLPMANFMIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool OLEEBIJAKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool GOKGNOBHOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float HKCLKPKHIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float FJLKGJKFHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public bool OJNBLFMBMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Func<FGKMNPELKPI> AOLFJINMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Func<Vector3, ELJDAEBKIKC> JMNCOBFDNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public RigidbodyEx FLFJBGJCPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public RigidbodyEx EHCEAJHGMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public RigidbodyEx MBCFIHFAHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public RigidbodyEx PBPLAAPFNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform PNGDLPLCOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform PNENPDKFOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform EHAKOKIKIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public PlayerAvatarFullBodyColliders FNPIKNCKMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public SkinnedMeshRenderer[] NKLACPNPJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer[] NJDBLMEGIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public SkinnedMeshRenderer[] OENFLFLPHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SkinnedMeshRenderer[] GOGFPEOOLDF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6229930", Offset = "0x6228330", VA = "0x186229930")]
	public ELJDAEBKIKC MNIKLEHNKPO(Vector3 BMIEPPJHBEN)
	{
		return default(ELJDAEBKIKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MINOBPJNDBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Transform BDNLGJLJCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform HKKABNBLIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public AvatarConfiguration PLIHCIOADEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Animator DEIBDFMKCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public VRIK BKJPFGFEKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public GameObject[] MONCMOOCOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform BIBIIMDMMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public AssetReference BJHMPPMEDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GameObject NKFNBAPAHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject LBHAKMNDEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer CLNCDENGODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Material MMHJFHBHMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Material GPEBAACABNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Material AKHLHCJHECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Shader EPFGFCONALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Shader AGKOAFEBEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform MHPDPFBIGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform LILMMEAOAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform FCCLENMOKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform CPDBCJLBIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Transform NOIDOCBFLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Transform KLONDFDIBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform BDGCNOMBFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Renderer[] OCEPNOIIFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Transform IPLBHEJNJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Transform IKAICKFDONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject NFONGJCJECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public GameObject JNKJKKBANDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public FJKOEONHJGH BPHDPJCFBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public FJKOEONHJGH CFFFOHMANOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public FJKOEONHJGH HNKPBHPLEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public FJKOEONHJGH BDPABEDHNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public FJKOEONHJGH HPDPIEJBOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public FJKOEONHJGH AFICDMOPDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public FJKOEONHJGH MOCNCCOOLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public FJKOEONHJGH LGEFENJFHAI;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FGKMNPELKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool PENFFIBKPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public NGCLDJOGPMC EEEBFFGAHLP;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ELJDAEBKIKC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class IJIIEHFLFAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly bool DFPLJPAEOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly bool CAEBIPGCKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly bool LKGGBDNMDIB;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62298E0", Offset = "0x62282E0", VA = "0x1862298E0")]
		public IJIIEHFLFAC(bool LGPNAFHALBH, bool MNLAHMLJOHA, bool LIONNOKOPFA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float PJIBHKJEMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool CIBONEMHKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public float EMOLFLGAPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 KHJJEMOIAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3 HFBDFOGLBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3? KDPJAOMPEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3? FFLNBODIMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool IOIPKAAIGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool EOJMNDFBKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool FMKBOKONNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool KBPBCGKGCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Vector3? GGKEMCCGKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool CLLHLHCALJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3? BJIMGBABHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool GHMDKCDKHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3? HBFADBFDALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public float BAFEIHIHAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3? AKMFIIEENMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool MEIIBGJDAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool EKHNOMOOGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool BCNEGLNPEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool BDJGIPHBHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool FHADMCDLPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool FLBEGNELBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool BGCPJMNADBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool NLPLMJKILKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool LKJPBBLKHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool PMDOOMFKLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool LGPAJJLGOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3? BOEIHADDHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public NJEPMHMFMFN KPICGMGCEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public NJEPMHMFMFN GFEBDBFENLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool CKLLFJPEKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool CAKAGLPOPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public IJIIEHFLFAC DKKHAOBNNDJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6229420", Offset = "0x6227E20", VA = "0x186229420")]
	public void GJEDDDIBLGD(Quaternion DMBBOEJIOJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GKGOLMKAKJB
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6229860", Offset = "0x6228260", VA = "0x186229860")]
	public static DCDDAAOOBKB EOLHCLDPHKA(this LMHGPJNKIML CMJEIEIDHIK)
	{
		return default(DCDDAAOOBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6229840", Offset = "0x6228240", VA = "0x186229840")]
	public static void AOIONCECIKG(this LMHGPJNKIML CMJEIEIDHIK, DCDDAAOOBKB AEJBOLFACJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FJKOEONHJGH
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float JFNONBMGLIA);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private NOFHJNOEPOF LKMPAICODHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Collider[] OEOEBGKOOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] MLNECOACABF;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> EGMJNJEJJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x622C460", Offset = "0x622AE60", VA = "0x18622C460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private NOFHJNOEPOF DKJHLJKDJDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x622BAE0", Offset = "0x622A4E0", VA = "0x18622BAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool NKBCJPEMBEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8F8640", Offset = "0x8F7040", VA = "0x1808F8640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x622BA20", Offset = "0x622A420", VA = "0x18622BA20")]
		private void ABFBKOMMIMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x622BAD0", Offset = "0x622A4D0", VA = "0x18622BAD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x622C440", Offset = "0x622AE40", VA = "0x18622C440")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer OKMLFCJEOLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x622C250", Offset = "0x622AC50", VA = "0x18622C250")]
		public void SetCollidersEnabled(bool IHFMNOOBPFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x622BE20", Offset = "0x622A820", VA = "0x18622BE20")]
		public void ReparentBonesUnderOtherBoneCollection(NOFHJNOEPOF LGHIKDFEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x622BB80", Offset = "0x622A580", VA = "0x18622BB80")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NHCEFAHAKNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Transform DIPEHJMJODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Transform BOMLJIMDHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Transform HKPBPGNLHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Transform KCJHNDGDIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Transform DIAFAHKPLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Transform FCBAMNFCOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Transform JAMOAMDIANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Transform JPOMKMMNKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform DHCJPMJGIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private PositionAndRotation HJCPKIFPIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private PositionAndRotation EGPJJNGGFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private PositionAndRotation INAJGLCODFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private PositionAndRotation DFMIPBMNAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private PositionAndRotation GPBKNGEHOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PositionAndRotation CHLACFFEJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PositionAndRotation IKCBLAKCBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation EIPIPLOJCOP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x622A0B0", Offset = "0x6228AB0", VA = "0x18622A0B0")]
	public void MPOMBMILLLK(Transform ELAPCCLGNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x622A770", Offset = "0x6229170", VA = "0x18622A770")]
	public void NFFKNJICIAA(HandLogicOffsets DDMECHPIPDC, HKBGLIPENJH MMOMBMNMKCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6229B90", Offset = "0x6228590", VA = "0x186229B90")]
	public void FPKGGCKIAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6229AC0", Offset = "0x62284C0", VA = "0x186229AC0")]
	private PositionAndRotation BHAPGHOFFNI(Transform BOOGIPJKCKJ, Transform JFABGJHCDDL)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6229DE0", Offset = "0x62287E0", VA = "0x186229DE0")]
	private void IGFPFILLIGG(Transform BOOGIPJKCKJ, Transform JFABGJHCDDL, PositionAndRotation NEDONFKBDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public NHCEFAHAKNF()
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
