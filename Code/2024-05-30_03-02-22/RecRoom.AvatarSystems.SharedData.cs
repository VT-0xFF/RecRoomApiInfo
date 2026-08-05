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
public enum NACKJAPOKPC
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
public enum KDCGCEPHGCE
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
public struct OHPCKPHJDGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator KLKPJJGLADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public POPNFCIOKLF JPOILLPGFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration AKLDGNGLCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject PJMLKIMHINF;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ODAPEFHJEMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform KLPEGLLIGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool BKJJDEODJAF;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum POPNFCIOKLF
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum APFBMFFMKMG
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
public struct BJNLIBNCJDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Vector2 LDAOCGBDLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector2 KHBGJAAKLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector2 NAAADJINIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector2 KIPBLMKLIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector2 GPLICIGJJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 CKMFNEGNJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 JPGODBNBLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 JDMAKCAEAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 NDCCPGEKBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 CIHDFFMDCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 PINCPBLFAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 NKNJMIPCNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 FDPOONCHCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 KPBENAHGFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 FJOBEMGODOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 ACPIDCDLKAC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class AKCIBAJJHFG
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly string CEBALMCIMNA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62E59A0", Offset = "0x62E4BA0", VA = "0x1862E59A0")]
	public static FIBIAIABFAD EEFNJGHOGIB()
	{
		return default(FIBIAIABFAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62E59E0", Offset = "0x62E4BE0", VA = "0x1862E59E0")]
	public static MHFIOJEMHHH FAILOEKHMFJ(Transform COJGEBAHKPI, Transform DOJNKAEONDO, AvatarConfiguration KLCLAEOMFKN, Animator KHJELLGNJFN, VRIK JNINFINFBPD, GameObject[] JBBFPPJBAHG, Transform NHCCGLHJNJI, AssetReference FHEOGGIFABF, GameObject INCEEADKLHI, GameObject PKEJGPJEHPP, SkinnedMeshRenderer GLCOJNNHJIH, Material BHHHELDGOIH, Material GCBAILMCLNO, Material OCPILHKGLPG, Shader GJEJNMCDCLP, Shader FDAJMHHPGNF, Transform EDIPAAPEGJP, Transform NNICOLKBNCN, Transform HAHJAIOPELE, Transform PFEELJLFJFC, Transform GAOAEFNCHBA, Transform IHONKEPBLCB, Transform ALBOKHNLPEB, Renderer[] EAENBBDNFIF, JPOGGGNNBOJ AAECAKNJEEC, JPOGGGNNBOJ CNKCIKIFPEL, JPOGGGNNBOJ AMLEHDPPCFH, JPOGGGNNBOJ KHJFDDCMMGE, JPOGGGNNBOJ DOOIOEMELJC, JPOGGGNNBOJ FGJMIMOIAKB, JPOGGGNNBOJ FDHIBMKJLBB, JPOGGGNNBOJ JLIDGNDDLNG, Transform KPFHGGDGGPJ, Transform BMHPCAODGGC, GameObject IINDDEFOEJC, GameObject KIDOJOPHIGP)
	{
		return default(MHFIOJEMHHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62E5690", Offset = "0x62E4890", VA = "0x1862E5690")]
	public static EMPNJLBEJFP BOLPKPIDAJB(string GCGOBKACAAE, bool FFNDECGBJEB, bool BCGNDCJOBBH, bool EDLNHJHAOOC, Func<LIKEGDLPNPN> KBGIBFOMHCB, Func<Vector3, FIBIAIABFAD> GFIDBDCIFHM, RigidbodyEx MDDPHLBKLOD, RigidbodyEx MMHPEJDKJHN, RigidbodyEx OBHNLDIKLNG, RigidbodyEx AIPFPILEPEF, Transform NGGMNGEHEAD, Transform DIAMKLHNKFN, Transform GMELALBGIKF, float OEKABBIEJFJ, float MBMDAEANPKA, PlayerAvatarFullBodyColliders PAFEEMKHKEE, SkinnedMeshRenderer[] LJAOFCCIKOL, SkinnedMeshRenderer[] KJBCHDODAHG, SkinnedMeshRenderer[] KHDDBMLKKMB, SkinnedMeshRenderer[] BLOODILGGHE)
	{
		return default(EMPNJLBEJFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x62E5870", Offset = "0x62E4A70", VA = "0x1862E5870")]
	public static FGHFJOIPDFD CIPNIIPACMG(Transform DOJNKAEONDO, AssetReference FHEOGGIFABF, GameObject INCEEADKLHI, GameObject PKEJGPJEHPP, SkinnedMeshRenderer GLCOJNNHJIH, Material BHHHELDGOIH, Material GCBAILMCLNO, Material OCPILHKGLPG, Shader KFAKBKFDBGP, Shader NNPJJLAINGO, Animator LAEIGDGBMJN, Renderer[] EAENBBDNFIF, AvatarConfiguration INHEHFMPADI)
	{
		return default(FGHFJOIPDFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x62E5DF0", Offset = "0x62E4FF0", VA = "0x1862E5DF0")]
	public static PFAODCKNIFO JKJINNDCPKP(SkinnedMeshRenderer[] LJAOFCCIKOL, SkinnedMeshRenderer[] KJBCHDODAHG, SkinnedMeshRenderer[] KHDDBMLKKMB, SkinnedMeshRenderer[] BLOODILGGHE)
	{
		return default(PFAODCKNIFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x62E5E70", Offset = "0x62E5070", VA = "0x1862E5E70")]
	public static POABKCDCHCA KJOHLMFIGAI(Transform EDIPAAPEGJP, Transform HAHJAIOPELE, Transform NNICOLKBNCN, Transform PFEELJLFJFC, Transform GAOAEFNCHBA, Transform IHONKEPBLCB, Transform ALBOKHNLPEB, AvatarConfiguration KLCLAEOMFKN)
	{
		return default(POABKCDCHCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8D4580", Offset = "0x8D3780", VA = "0x1808D4580")]
	public static ILIABBNEMKB MHGEIHPFHFO(SkinnedMeshRenderer[] HMMALMEGIKB)
	{
		return default(ILIABBNEMKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x62E55F0", Offset = "0x62E47F0", VA = "0x1862E55F0")]
	public static BECMCNIPBEM ADEFHLCIGIF(CBIMLGEJDAN EEIEGABHJKC, int FFHKCFOEGFP, int EKMKNLJGEPG, Color ADJGJPDOKDM, Color HEJJOKECPHM, int LJNJGEHKHNI, int LBAHBHCGHOL, Color HLCOHLFPBOF, Color IFJMKJBJECP, int MJPDGNFHPLC)
	{
		return default(BECMCNIPBEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62E5F40", Offset = "0x62E5140", VA = "0x1862E5F40")]
	public static KAIBKFCKHGP LCLHIBIAJPJ(CBIMLGEJDAN EEIEGABHJKC, Vector2 OPEAEPCOJDC, float JOHLIFGLHPP, Vector2 CAOMKKHEMMN, float DCFIPGBFDPC, Vector2 EFNMNAALOMG, float MABALBNDAKK, Vector2 HECBGMEHJPI, float OCDAHGIAJLH)
	{
		return default(KAIBKFCKHGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x62E5D80", Offset = "0x62E4F80", VA = "0x1862E5D80")]
	public static OHPCKPHJDGP GDCHLCIOFGL(Animator DABOEJDIGFO, POPNFCIOKLF MCIKACMLILL, AvatarConfiguration INHEHFMPADI, GameObject MPIOHMLNMCC)
	{
		return default(OHPCKPHJDGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62E5830", Offset = "0x62E4A30", VA = "0x1862E5830")]
	public static ODAPEFHJEMJ CHFEJECEOIH(Transform OOLHJDGCFGK, bool BCGNDCJOBBH)
	{
		return default(ODAPEFHJEMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GFJMLHABNCJ
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62E7BE0", Offset = "0x62E6DE0", VA = "0x1862E7BE0")]
	public static NACKJAPOKPC APMPKFABLEO(this APFBMFFMKMG AFDPKJPGNCB)
	{
		return default(NACKJAPOKPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x62E7C30", Offset = "0x62E6E30", VA = "0x1862E7C30")]
	public static bool DNAFMDPLAHC(this APFBMFFMKMG CMOMPGICBMM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JMOGMKKCKCA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CBCOOEGLGHE : JMOGMKKCKCA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform CGDFLGLNEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 EIOOMFENJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xE28950", Offset = "0xE27B50", VA = "0x180E28950", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE28940", Offset = "0xE27B40", VA = "0x180E28940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? BHCHAHDPDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE28970", Offset = "0xE27B70", VA = "0x180E28970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xE28980", Offset = "0xE27B80", VA = "0x180E28980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public CBCOOEGLGHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OBLDGDJFGLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected readonly CBCOOEGLGHE OLHIEKPBNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly CBCOOEGLGHE LMMOIFDFCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly CBCOOEGLGHE AOAJFNOGDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly CBCOOEGLGHE DBKEKPDGEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected readonly CBCOOEGLGHE LAGDKHHCPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly CBCOOEGLGHE AMPBHHLHBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly CBCOOEGLGHE FPCICMHAAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly CBCOOEGLGHE CENCKNAKCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly CBCOOEGLGHE IJLEPNOHDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly CBCOOEGLGHE GPEDJAALJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly CBCOOEGLGHE NLLJNCDECGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly CBCOOEGLGHE HJFBKODPMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly CBCOOEGLGHE AHIGGHDNKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected CBCOOEGLGHE MGGFPIHMMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly CBCOOEGLGHE KONKOBBJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly CBCOOEGLGHE CDIAOLMNCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly CBCOOEGLGHE EGBKLKEBPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected CBCOOEGLGHE CNPGBIBECDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly CBCOOEGLGHE PMDDFAINAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly CBCOOEGLGHE JMNKNNBOEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly CBCOOEGLGHE APGCJKFDMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected ReadOnlyCollection<CBCOOEGLGHE> PCAEBCDPIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform NHCCGLHJNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private (CBCOOEGLGHE Start, CBCOOEGLGHE End)[] PNOMEJANPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private Dictionary<string, CBCOOEGLGHE> LCMBFNPCGDD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JMOGMKKCKCA CIJGCKICCIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JMOGMKKCKCA CMGHHBHHBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JMOGMKKCKCA IDGKPLCEMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JMOGMKKCKCA BOLKJDMEOMG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JMOGMKKCKCA CHBPHLAECII
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JMOGMKKCKCA FAHPOADMOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8A0", Offset = "0x7CDAA0", VA = "0x1807CE8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JMOGMKKCKCA BEKNDKDHCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF80", Offset = "0x7CB180", VA = "0x1807CBF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JMOGMKKCKCA FCFEFBDMCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBFA0", Offset = "0x7CB1A0", VA = "0x1807CBFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JMOGMKKCKCA EHGMINKDMHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE890", Offset = "0x7CDA90", VA = "0x1807CE890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x62E81A0", Offset = "0x62E73A0", VA = "0x1862E81A0")]
	public void DHHMPCAMHPH(VRIK JLCGDIGAPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62E7D00", Offset = "0x62E6F00", VA = "0x1862E7D00")]
	private void BCKCELHFKNM(Transform GNIGPOPNBEB, CBCOOEGLGHE FMEDEJNEJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62E7C90", Offset = "0x62E6E90", VA = "0x1862E7C90")]
	public CBCOOEGLGHE AMFJKPLIKPF(string BOAMHPHPKFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x62E7D90", Offset = "0x62E6F90", VA = "0x1862E7D90")]
	public void BHOAGMIMELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62E93A0", Offset = "0x62E85A0", VA = "0x1862E93A0")]
	public float MFINIAHKEAF([In] (CBCOOEGLGHE Start, CBCOOEGLGHE End) EGLLOOJBDGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62E90C0", Offset = "0x62E82C0", VA = "0x1862E90C0")]
	public void FPMABIEAGFA([In] FIBIAIABFAD JLPFJEBDMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62E9270", Offset = "0x62E8470", VA = "0x1862E9270")]
	private Vector3 KKDIKGJAFNL([In] (CBCOOEGLGHE Start, CBCOOEGLGHE End) EGLLOOJBDGA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62E93E0", Offset = "0x62E85E0", VA = "0x1862E93E0")]
	public OBLDGDJFGLF()
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
		[Cpp2IlInjected.Address(RVA = "0x62E6060", Offset = "0x62E5260", VA = "0x1862E6060")]
		public string BGOIEHMMEEL(string PJDPHFJCBFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x62E60B0", Offset = "0x62E52B0", VA = "0x1862E60B0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct EMPNJLBEJFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public string GFIBFDKBMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool BKJJDEODJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool MOLPKADJOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float DEDFLCAPIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float DKEJBMBOIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public bool JGLEPCNHOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Func<LIKEGDLPNPN> IDJLFDPLDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Func<Vector3, FIBIAIABFAD> CICPGDGAFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public RigidbodyEx JNIDMAHLFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public RigidbodyEx CFLGKKMEMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public RigidbodyEx DHMDCDEMOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public RigidbodyEx AKOLIGEBLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform MPLCENHLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform HEMDIONAMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform ONGGKDFOBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public PlayerAvatarFullBodyColliders KLILDOAKGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public SkinnedMeshRenderer[] PKLAHIIEDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer[] CPHDPMMCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public SkinnedMeshRenderer[] DOEKNPADADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SkinnedMeshRenderer[] LNOIDNMLLLA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62E6100", Offset = "0x62E5300", VA = "0x1862E6100")]
	public FIBIAIABFAD BOMIHIOBFMA(Vector3 KACEDJMNFOP)
	{
		return default(FIBIAIABFAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MHFIOJEMHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Transform MCPAKCDMHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform CCOFDIHIDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public AvatarConfiguration AKLDGNGLCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Animator KKGFLCCDMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public VRIK LAOPLPLJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public GameObject[] FLFBMFBCJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform EKDFGNDDMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public AssetReference DHEAHHENOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GameObject ACGBGNKJJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject EEGJOLHCFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer NBGHHDIEKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Material GGMCBGNKCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Material DKEOMKINBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Material IAJIFJBJGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Shader CBPBEFCPNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Shader LBIHGOJEHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform AFNEBKCEOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform NABBPPFMFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform GMKJIGDOLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform DGGPEKJDKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Transform LKEKGNPBEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Transform CMHFPMABDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform NEEMMMDNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Renderer[] DFOKOFHHLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Transform LDAPMOKGPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Transform MMLDMKNHLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject MABFNNODMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public GameObject NHFJMOILOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public JPOGGGNNBOJ NCPENEJBADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public JPOGGGNNBOJ NKDECDLGCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public JPOGGGNNBOJ CJBEMAPMGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public JPOGGGNNBOJ EPKOBADODKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public JPOGGGNNBOJ HJKBHCHDBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public JPOGGGNNBOJ IICKPLPCLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public JPOGGGNNBOJ FFMJHMLBBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public JPOGGGNNBOJ IOCEFAPIHDE;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LIKEGDLPNPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool GGHAOAMMAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public IEIKJHNHGAC LAEBAJKNAJP;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FIBIAIABFAD
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NFNHKDMDJPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly bool CEKIDOPFCPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly bool HLLCKOECAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly bool EANFELPJGED;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62E7C40", Offset = "0x62E6E40", VA = "0x1862E7C40")]
		public NFNHKDMDJPN(bool OHBJFIPAMAO, bool OPNAPPNDJBO, bool HJEPFIFLEPG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float KKINDPBIMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool LAPBKFPCGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public float BLMJFGBPHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 NMMINBJOCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3 IBDEACPGDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3? OEKPLIAIEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3? GBOHPHKHMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool CIIGOJIJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool AFGCHAHBCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool MFDALLELHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DBCOIIODDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Vector3? IKPFIGFGAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool FOPJILGDNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3? MCPJEDPDOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool JNOEHAJJEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3? OAFNLMEBLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public float KEOHNPEBMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3? LHAPCCMGCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool CKECJKBPOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool LLKBAFBOFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool KKCHAJLGEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool POFDNMFDOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool GGEDANIKLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool HLCEIBLCKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool ABEIOBKKOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool MABBFBDJGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool JFLILLLKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool BCPCKKNHHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool ODAKDFFDKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3? LNDLPMNGOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public APFBMFFMKMG PNKNCDONGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public APFBMFFMKMG PFOJKAKOEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool MFCBHODGGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool MLOGHIBGCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public NFNHKDMDJPN LALOBDLMPHH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x62E6290", Offset = "0x62E5490", VA = "0x1862E6290")]
	public void JICAOBCMNEP(Quaternion JCCMNAMJFGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GAFIHIMLCBF
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x62E7BA0", Offset = "0x62E6DA0", VA = "0x1862E7BA0")]
	public static HPNPAHEDPFN AGHMIJOIPFL(this HFLFBGANNAH CJKIBFNGPNM)
	{
		return default(HPNPAHEDPFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62E7BC0", Offset = "0x62E6DC0", VA = "0x1862E7BC0")]
	public static void ALNCJNKMILP(this HFLFBGANNAH CJKIBFNGPNM, HPNPAHEDPFN HLCKBKFCMPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface JPOGGGNNBOJ
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float ADBEIAHCPGL);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private MGFFLAIFAPE LEHJOHDIBHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Collider[] DOFNOEEOAKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] NEKPNNBNLHC;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> KBAMKHFGMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x62EA2E0", Offset = "0x62E94E0", VA = "0x1862EA2E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MGFFLAIFAPE FOLOIHKGKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x62E9980", Offset = "0x62E8B80", VA = "0x1862E9980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BMMGBFBCJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9719E0", Offset = "0x970BE0", VA = "0x1809719E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62E98D0", Offset = "0x62E8AD0", VA = "0x1862E98D0")]
		private void CLEOOELHINH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62E98C0", Offset = "0x62E8AC0", VA = "0x1862E98C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62EA2C0", Offset = "0x62E94C0", VA = "0x1862EA2C0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer CDECJOIBEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62EA0F0", Offset = "0x62E92F0", VA = "0x1862EA0F0")]
		public void SetCollidersEnabled(bool IJMGAKGNGDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x62E9CC0", Offset = "0x62E8EC0", VA = "0x1862E9CC0")]
		public void ReparentBonesUnderOtherBoneCollection(MGFFLAIFAPE HFDNECAIDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x62E9A20", Offset = "0x62E8C20", VA = "0x1862E9A20")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FIMKAKAIIKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Transform HFLOEHEKJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Transform EHICIPPJLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Transform DGECNHHKMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Transform GJDFCDHHABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Transform GGHLPIPNJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Transform MOPKAIKGIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Transform PIBNELNPHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Transform HOLFCDNOKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform LLLDKNNCMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private PositionAndRotation LGLGDPLECFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private PositionAndRotation DCLOCHLALME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private PositionAndRotation LACAEONODCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private PositionAndRotation FHBMIKANGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private PositionAndRotation KNKFHKBMMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PositionAndRotation OPKMIIEIIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PositionAndRotation NPNDMAGMEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation KPIPKOLFAIP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62E6980", Offset = "0x62E5B80", VA = "0x1862E6980")]
	public void CNOOLEDIEBH(Transform KJILHDFJPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62E7040", Offset = "0x62E6240", VA = "0x1862E7040")]
	public void EEDNAGGAEHH(HandLogicOffsets FAKOFAEFFGH, POPNFCIOKLF KLICGJIIBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x62E7880", Offset = "0x62E6A80", VA = "0x1862E7880")]
	public void JDEIHBOOBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x62E7AD0", Offset = "0x62E6CD0", VA = "0x1862E7AD0")]
	private PositionAndRotation PGCDPPLLONG(Transform DHFJELJFMPG, Transform ILMPINGBOMF)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x62E66B0", Offset = "0x62E58B0", VA = "0x1862E66B0")]
	private void CCNCKEIIDOG(Transform DHFJELJFMPG, Transform ILMPINGBOMF, PositionAndRotation NLOCCCKIBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FIMKAKAIIKO()
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
