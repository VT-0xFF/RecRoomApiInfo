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
public enum LLEOMDDHGBI
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
public enum HCCLLALHLCD
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
public struct CHEABBJKBHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator MBPAFKOHIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public BDPJGDLIMJG ECHIJEBNHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration IBFACOPPGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject CDOGPCKMBON;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LILIKACMDLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform GNEFDOMPCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool FOCFONFHDLF;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum BDPJGDLIMJG
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum EJEHFCIHAJD
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
public struct KHMDJPEHGBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Vector2 GKHNFCFGNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector2 MBNCNKIJPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector2 PNJNANHFHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector2 PDEDLCNGPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector2 GACIPOAHHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 OGDMMNKEKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 OLBBCAFCKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 OELAIKIIHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 CADCOCKDDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 MAEFNKNJLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 AFDMMHKAKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 FECGLEMBIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 LHCOCLKADBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 LOMNMPNNIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 OALNMFGLDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 BOPHJAAMJOG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HPCNFIBENKL
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly string CCDGGJLOODP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67B3F80", Offset = "0x67B2B80", VA = "0x1867B3F80")]
	public static AFNNLHFGIKH LHKHBENPIOH()
	{
		return default(AFNNLHFGIKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67B3BB0", Offset = "0x67B27B0", VA = "0x1867B3BB0")]
	public static ANDALEBLIHI KLGCPJPCMPC(Transform AENEBDOMFOD, Transform KNOEAFIGPHC, AvatarConfiguration PBPFIONKOGP, Animator PANPCOFGFBC, VRIK HNNIEAFMLBO, GameObject[] AHBIBLMPFMN, Transform IHKMDDJLAKN, AssetReference PHDEBLGIEOO, GameObject GENNCACINBJ, GameObject NONJKPGOACJ, SkinnedMeshRenderer JLNJCDPEGHE, AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM, Material FAECFFAGOKM, Material AJMJLGGNOAD, Material BCIAHCCGEIA, Shader DCIPPLEHNDF, Shader EHHJAMFBNLE, Transform GBMLPPABHPG, Transform AIJADFBBOGB, Transform GFAKODJAPIO, Transform BFFKGKEFOBJ, Transform OLEADIILADF, Transform LHHBFPHPKIP, Transform KJNDCLNOBHO, Renderer[] DABJDEJABFJ, DBCBOAKCJHM CCOPHJBCELC, DBCBOAKCJHM PMOGNEMOMKD, DBCBOAKCJHM PNLMHGABGMC, DBCBOAKCJHM LPAOKAKOGBJ, DBCBOAKCJHM DNMDJOIDONH, DBCBOAKCJHM BHALGEANIPA, DBCBOAKCJHM DNODBGIIJDA, DBCBOAKCJHM KOIGBGBLEHL, Transform KIKEHMCNHDF, Transform EBFDJCEBKON, GameObject CIMIBCMHFFI, GameObject OFFIBALNEFP, AvatarBodyPartShapesManager OODDDFCIELP)
	{
		return default(ANDALEBLIHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67B3880", Offset = "0x67B2480", VA = "0x1867B3880")]
	public static AGBFGICDBPI GBPHJPGENPI(string FGMMDEPIDOF, bool DNGDAKKGHID, bool LKIFDIFKEFL, bool CGMPADLPDNO, Func<AOIOICAPEPC> GNCOPBPLKME, Func<Vector3, AFNNLHFGIKH> FGFCLGIKENP, RigidbodyEx MGJONAGJKJP, RigidbodyEx CIKKGAPMCGN, RigidbodyEx DKJDGCBKNLP, RigidbodyEx LEPNNKIABJO, Transform MFOAHCLGLIK, Transform IOAKPLLAENB, Transform DPANCMCENJO, float NMBCLNKPENL, float NEILLDDFGHD, PlayerAvatarFullBodyColliders JAFECKKNDIC, SkinnedMeshRenderer[] LFJPMHNACFN, SkinnedMeshRenderer[] JNABCJIHJDN, SkinnedMeshRenderer[] BPIOCKMMKOJ, SkinnedMeshRenderer[] MMMBHHANCFH)
	{
		return default(AGBFGICDBPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67B3650", Offset = "0x67B2250", VA = "0x1867B3650")]
	public static MFBFMPCFHEP BHMOFLECJCH(Transform KNOEAFIGPHC, AssetReference PHDEBLGIEOO, GameObject GENNCACINBJ, GameObject NONJKPGOACJ, SkinnedMeshRenderer JLNJCDPEGHE, AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM, Material FAECFFAGOKM, Material AJMJLGGNOAD, Material BCIAHCCGEIA, Shader CDMDAJLPLDI, Shader EHKADOEKOGM, Animator FLHDNFMKMIK, Renderer[] DABJDEJABFJ, AvatarConfiguration EFBONAFBAGN, AvatarBodyPartShapesManager OODDDFCIELP, IReadOnlyDictionary<string, Transform> DMKPIOFOPMP)
	{
		return default(MFBFMPCFHEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67B3AF0", Offset = "0x67B26F0", VA = "0x1867B3AF0")]
	public static AIOPABHBAFF JNKDNOHIJHN(SkinnedMeshRenderer[] LFJPMHNACFN, SkinnedMeshRenderer[] JNABCJIHJDN, SkinnedMeshRenderer[] BPIOCKMMKOJ, SkinnedMeshRenderer[] MMMBHHANCFH)
	{
		return default(AIOPABHBAFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67B3A20", Offset = "0x67B2620", VA = "0x1867B3A20")]
	public static POJPECEJPPN JAAIJKKHGAL(Transform GBMLPPABHPG, Transform GFAKODJAPIO, Transform AIJADFBBOGB, Transform BFFKGKEFOBJ, Transform OLEADIILADF, Transform LHHBFPHPKIP, Transform KJNDCLNOBHO, AvatarConfiguration PBPFIONKOGP)
	{
		return default(POJPECEJPPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x96B4D0", Offset = "0x96A0D0", VA = "0x18096B4D0")]
	public static OOHMCNLKMGM JOCNMMEGHFC(SkinnedMeshRenderer[] EACMGBENBPO)
	{
		return default(OOHMCNLKMGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67B4030", Offset = "0x67B2C30", VA = "0x1867B4030")]
	public static AJPBPBCKEJN MPKLAPJNKHD(OFIAGAGHOCM NNMEEADCPAH, int NLIDNDLBJJE, int MOFNGDGFENG, Color LIPPBFFLIGO, Color AOAPGPGDIML, int IFEFANMIBAD, int HPCHAIGMBOP, Color NBMCMJGJIKH, Color LPEILBBGEAN, int KHPLPGMCJKD)
	{
		return default(AJPBPBCKEJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67B37D0", Offset = "0x67B23D0", VA = "0x1867B37D0")]
	public static CLAMMCFGNOO EPPNGFIGCFD(OFIAGAGHOCM NNMEEADCPAH, Vector2 KDAIMBBJGFG, float NCPKBNDAFIN, Vector2 APPNAPBJPDA, float NPOJMLHBIBA, Vector2 CEBMFEAHHKJ, float MMPMIOLFJAM, Vector2 LFJLMGMJMNM, float EOGFFCOPNPB)
	{
		return default(CLAMMCFGNOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67B3FC0", Offset = "0x67B2BC0", VA = "0x1867B3FC0")]
	public static CHEABBJKBHM MIPKJLKGKNK(Animator HKOPEBEPNBD, BDPJGDLIMJG CFFOMHLLDBL, AvatarConfiguration EFBONAFBAGN, GameObject DAFAMPOKCCH)
	{
		return default(CHEABBJKBHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67B3B70", Offset = "0x67B2770", VA = "0x1867B3B70")]
	public static LILIKACMDLC KFAOBAJPGCJ(Transform HCNNNKOIPKB, bool LKIFDIFKEFL)
	{
		return default(LILIKACMDLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KODILCHNJPH
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67B4150", Offset = "0x67B2D50", VA = "0x1867B4150")]
	public static LLEOMDDHGBI LBBFMMLCPCG(this EJEHFCIHAJD KNLCOGBBFJO)
	{
		return default(LLEOMDDHGBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67B4140", Offset = "0x67B2D40", VA = "0x1867B4140")]
	public static bool DJCDIDMGDME(this EJEHFCIHAJD IHBPKIDFHEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GEIIBLKDFCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OEMBFANBGHJ : GEIIBLKDFCL
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform KIMEAEOEPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 HKJOPLEHNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDB3200", Offset = "0xDB1E00", VA = "0x180DB3200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDB3250", Offset = "0xDB1E50", VA = "0x180DB3250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? HNDHKFBIOIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEDBE70", Offset = "0xEDAA70", VA = "0x180EDBE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xEDBE80", Offset = "0xEDAA80", VA = "0x180EDBE80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OEMBFANBGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class OANEKPMHIDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected readonly OEMBFANBGHJ CODGAEGBBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly OEMBFANBGHJ HEDJPBCKEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly OEMBFANBGHJ BHCNOJGPJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly OEMBFANBGHJ GDFGLOLGCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected readonly OEMBFANBGHJ MHBDEDCNIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly OEMBFANBGHJ NMJBGLFIFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly OEMBFANBGHJ HDEBICKNDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly OEMBFANBGHJ GDGPOKOFNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly OEMBFANBGHJ OBGFJEABABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly OEMBFANBGHJ LMGOGOGANMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly OEMBFANBGHJ HJPMIGDGHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly OEMBFANBGHJ OONBOKGMGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly OEMBFANBGHJ PGBMKGMFINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected OEMBFANBGHJ NKGPACDNIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly OEMBFANBGHJ OFIAHNMBPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly OEMBFANBGHJ MKOEOOOOGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly OEMBFANBGHJ NFJKNFNCGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected OEMBFANBGHJ MBFEAHPPJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly OEMBFANBGHJ AGFLKHJKBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly OEMBFANBGHJ GLMPKOPLKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly OEMBFANBGHJ JNBKPOMFGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected ReadOnlyCollection<OEMBFANBGHJ> LJGEEABAEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform IHKMDDJLAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private (OEMBFANBGHJ Start, OEMBFANBGHJ End)[] MJLACPEJKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private Dictionary<string, OEMBFANBGHJ> LCDGFOLMLAJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GEIIBLKDFCL PKDKFLOOOAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GEIIBLKDFCL OCBOFGNOKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GEIIBLKDFCL IEOEFDJDPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GEIIBLKDFCL BMMEGGHLAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public GEIIBLKDFCL FNIGFMHGINO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GEIIBLKDFCL EOBJKCHKHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GEIIBLKDFCL CFLJECFLNMC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8433B0", Offset = "0x841FB0", VA = "0x1808433B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GEIIBLKDFCL JBPFBKDKAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x848BE0", Offset = "0x8477E0", VA = "0x180848BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GEIIBLKDFCL CBBPFAHLNBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8431C0", Offset = "0x841DC0", VA = "0x1808431C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67B4830", Offset = "0x67B3430", VA = "0x1867B4830")]
	public void ILOKNJDNCBG(VRIK FKKNMOJBPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67B45F0", Offset = "0x67B31F0", VA = "0x1867B45F0")]
	private void FPGFKOOECEF(Transform OGOLDJHPDFA, OEMBFANBGHJ PJIFCLGMLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67B5750", Offset = "0x67B4350", VA = "0x1867B5750")]
	public OEMBFANBGHJ MGCHOMAIPLB(string LFLHDCPMFGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67B41E0", Offset = "0x67B2DE0", VA = "0x1867B41E0")]
	public void FIMLLGELHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67B41A0", Offset = "0x67B2DA0", VA = "0x1867B41A0")]
	public float AGLMLOPKFGP([In] (OEMBFANBGHJ Start, OEMBFANBGHJ End) KNAPJDGIIEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67B4680", Offset = "0x67B3280", VA = "0x1867B4680")]
	public void GPDDLAFPNOL([In] AFNNLHFGIKH GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67B57C0", Offset = "0x67B43C0", VA = "0x1867B57C0")]
	private Vector3 OENLNDPBFHJ([In] (OEMBFANBGHJ Start, OEMBFANBGHJ End) KNAPJDGIIEM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67B58F0", Offset = "0x67B44F0", VA = "0x1867B58F0")]
	public OANEKPMHIDJ()
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
		public GameObject AvatarCollidersPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67B35B0", Offset = "0x67B21B0", VA = "0x1867B35B0")]
		public string LLBGCGODLIG(string DFFNDLJKMFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67B3600", Offset = "0x67B2200", VA = "0x1867B3600")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AGBFGICDBPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public string KOOIDFHNMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool FOCFONFHDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public bool AIKJPFHFBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float JCELJAGHCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float NKHNENKKOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool HCMHPGEFFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Func<AOIOICAPEPC> LCKGGIKLFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Func<Vector3, AFNNLHFGIKH> LMMNANFBBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public RigidbodyEx BDCCFHLAGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public RigidbodyEx ILIMELMDMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public RigidbodyEx CCOHCDDDHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public RigidbodyEx CEPEAGMDICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform MBOKKLMDAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform FFCEGMGJLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Transform FIKGGBOJLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public PlayerAvatarFullBodyColliders KJPHJAGBEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer[] LFNPDDHMJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public SkinnedMeshRenderer[] PLOKAGEDJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SkinnedMeshRenderer[] EJEPCGPEKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public SkinnedMeshRenderer[] CDEPLPKABDE;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67B33E0", Offset = "0x67B1FE0", VA = "0x1867B33E0")]
	public AFNNLHFGIKH EKKIHFGJGBL(Vector3 OHMHHJAFELK)
	{
		return default(AFNNLHFGIKH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct ANDALEBLIHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform PPMBPFBDHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Transform BNKKKNFKHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public AvatarConfiguration IBFACOPPGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Animator CEPINNGNBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public VRIK IHNMHFAIJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public GameObject[] ANHKLKCLCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform OICOBHIILFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public AssetReference NFEHBHEOGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject NNBOCBJNEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GameObject DNDFNLCKFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public SkinnedMeshRenderer KGFDENONOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public AvatarSkinnedMeshBoneOrderRemapsData OLKCMPAIMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Material LOFNDJKEGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Material KCDFFIJGFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Material CFMFJCNABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Shader INOBODGCNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Shader DGGFCLEMLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform KJNHKEIHJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform KCCAPDGHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Transform DCOJILOCLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Transform IKIMFAMPNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform GPOJGDFIBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Transform OBFEMNEFOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Transform GINENDNHBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Renderer[] BAOOJKMJFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Transform MOHHBBAHOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Transform OEGLCIGICBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public GameObject CEAFIEKNGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public GameObject CLDAJADGKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public DBCBOAKCJHM AIFPHFKAALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public DBCBOAKCJHM ENBNAEMOJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public DBCBOAKCJHM MPAPMJOCCEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public DBCBOAKCJHM JJDDLJFLAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public DBCBOAKCJHM PHCDLGLLHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public DBCBOAKCJHM BDHJNIIGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public DBCBOAKCJHM KBMKCKNMGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public DBCBOAKCJHM ICHHKPELKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public AvatarBodyPartShapesManager NAKPDCFIGMO;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct AOIOICAPEPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool NEFMNNAKHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public PHMIKAKJJJM OPFLILIFKLM;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct AFNNLHFGIKH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class OPOPELIPKFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly bool BNJEBBMBJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly bool NBEFAONMCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public readonly bool LEFFGMOHMGP;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67B72C0", Offset = "0x67B5EC0", VA = "0x1867B72C0")]
		public OPOPELIPKFK(bool NAENEJBLMGM, bool MPNDDDKKOLG, bool GBCMPLPGFON)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public float DKHFCDOCFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool OEDBFINBMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public float KJGMPBICJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3 EJOODACPLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public Vector3 HMICJAPBMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Vector3? HDDAOLADJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Vector3? PMCMHPMHJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool ANLLCFEPCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool EPKMEAGAJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool EPKFFEMKIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool NOHJEPLIDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Vector3? KDLLMOGGNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool IFPHFHBGGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? HAMLLOPPPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool EEJOCOFMAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Vector3? MJKECAIGIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public float JGFIOPEBAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Vector3? FMHGFEBBJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool BNIFEKCBHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool AFGODCHHMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool FEGALJEEJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool AHLJIEENDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool DHGJJMDJCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool AEFLIPFHBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool COOALDPDFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool AHCHBNHCDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool JHFICOKHPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool IMNKGFKFNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool CNLMJIOFAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3? BMMENEICMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public EJEHFCIHAJD EPBHKMIHGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public EJEHFCIHAJD KGEIKGHMNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool MPNGECHPDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool IIIHJEHFEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public OPOPELIPKFK HDODLLHFLBJ;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67B2FC0", Offset = "0x67B1BC0", VA = "0x1867B2FC0")]
	public void JJBEHNHMMBG(Quaternion DELGPMLKBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AGJMLEBBPND
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67B3590", Offset = "0x67B2190", VA = "0x1867B3590")]
	public static BHNAMMMFFGC FKDBMAPPECH(this DFANCAMLMFG HNFMOHFACKF)
	{
		return default(BHNAMMMFFGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67B3570", Offset = "0x67B2170", VA = "0x1867B3570")]
	public static void DAHJLKOKINL(this DFANCAMLMFG HNFMOHFACKF, BHNAMMMFFGC GLMEMJNJKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DBCBOAKCJHM
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float HHCAAOJDKHN);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private DEPGENALEBH HKPPEHCDAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Collider[] FJEBFFNFFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] BDPCDFOHLJJ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> BKLNDFJKHHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x67B7D50", Offset = "0x67B6950", VA = "0x1867B7D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DEPGENALEBH GMDMFIFNCCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x67B73D0", Offset = "0x67B5FD0", VA = "0x1867B73D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool OIPKAAAKLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA377D0", Offset = "0xA363D0", VA = "0x180A377D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67B7320", Offset = "0x67B5F20", VA = "0x1867B7320")]
		private void KPMFDBCPOMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67B7310", Offset = "0x67B5F10", VA = "0x1867B7310")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67B7D30", Offset = "0x67B6930", VA = "0x1867B7D30")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer JEOIALKABFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67B7B40", Offset = "0x67B6740", VA = "0x1867B7B40")]
		public void SetCollidersEnabled(bool MPKDEMAOPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67B7710", Offset = "0x67B6310", VA = "0x1867B7710")]
		public void ReparentBonesUnderOtherBoneCollection(DEPGENALEBH LHMCOAONKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67B7470", Offset = "0x67B6070", VA = "0x1867B7470")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OCCNHJHPHLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Transform KFLBMNHCOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Transform KDEAEIALDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Transform ELDOHDEPCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Transform DPCFLOMLOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Transform DPFMDNCDPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public Transform HOLMNHEEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public Transform IDCKEFENGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public Transform PCPFLFEEILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Transform DMIFKBNNGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private PositionAndRotation HMNOHGMCGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private PositionAndRotation AAJJOHNENBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PositionAndRotation JIAOBHNIKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PositionAndRotation OGIOOOIOICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation ODLLIIANDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PositionAndRotation JNHNMCJFDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private PositionAndRotation ALGEIGFBNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private PositionAndRotation ILCHDLBNGJJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67B6610", Offset = "0x67B5210", VA = "0x1867B6610")]
	public void EHHLDMLDHNI(Transform OGGAGAMALCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x67B5DD0", Offset = "0x67B49D0", VA = "0x1867B5DD0")]
	public void DACANEIBLCD(HandLogicOffsets BPJPNNILICA, BDPJGDLIMJG MHNHNOPHPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x67B6FA0", Offset = "0x67B5BA0", VA = "0x1867B6FA0")]
	public void KBDILIHGDNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67B71F0", Offset = "0x67B5DF0", VA = "0x1867B71F0")]
	private PositionAndRotation NGPBJJMLNHJ(Transform PAGBFIKNKIO, Transform OBKDIPGFCLF)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67B6CD0", Offset = "0x67B58D0", VA = "0x1867B6CD0")]
	private void HPEMBDBOKJA(Transform PAGBFIKNKIO, Transform OBKDIPGFCLF, PositionAndRotation DJMPNPEHHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public OCCNHJHPHLF()
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
