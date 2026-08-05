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
public enum NNNBHLGDPFP
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
public enum JAEBJFMEEKJ
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
public struct CPGPGEHMHOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator JLPGOJGBHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KJHAHHBINEC DHNLPJLHAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration ODMCEOBGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject LAIAFAMMNAO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CBMPKJMGNCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform AMCPCKGFODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool FNNGJGNPBEJ;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KJHAHHBINEC
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum NHNAPMDMKLL
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
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FLNAILNJOEP
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	AimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	MeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	LightItem,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	HeavyItem,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	AimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Action,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	NumTypes
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public PositionAndRotation WatchMenuOriginOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NOEDMJIDDNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 BLDANJJMBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 LEJCKPGBFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 CHBAJEMELDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 BKBPODGABDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 GBPILCPCLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 CNBFOAMENOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 NIILPHKLMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 OHBCKMEHFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 OOPBOLEOJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 PEHHBJFEIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 HLOKGKNOPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 LPCAEHPMNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 ADJKGEDAHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Vector2 JNJIAPJKBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Vector2 FLIEBEINBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Vector2 BBNHCGHICBM;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class CPNFCDLMOKK
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly string NHOBMKAJDEB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6829480", Offset = "0x6827A80", VA = "0x186829480")]
	public static AILLONLIOPL NPDCPFIBGNM()
	{
		return default(AILLONLIOPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6828DA0", Offset = "0x68273A0", VA = "0x186828DA0")]
	public static KBANNBMGJGE JPJKEAFEDFA(Transform DAOJLEMLDIP, Transform FGGDLIIINCM, AvatarConfiguration LOGLAMBNPJF, Animator NNNDMIAOGFK, VRIK BJIMHBDEEMF, GameObject[] JEGJOGKNLEN, Transform JKOOGDOIHON, AssetReference IOICAJEBIBI, GameObject FHMHELIJOFG, GameObject PALNFOKJEGI, SkinnedMeshRenderer CCPDOIDKMLB, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM, Material IGAJOBMOOPE, Material EADKEGOBEOE, Material EGGHNLJIKNB, Shader HMPJAEMLDGA, Shader MGHNNMLGJDD, Transform IKEPJPGKEJL, Transform POMPLCHFCFE, Transform PKAPBMPHCLI, Transform HOANKOJNLAL, Transform JDDOEBMJGIN, Transform KCIBMLDFODE, Transform ANHJNGAJMDG, Renderer[] LJMIHNHAEHE, CMPPBAAMJMA LPNCIACGOBB, CMPPBAAMJMA PMBBBBMEINN, CMPPBAAMJMA GOCEJOMCHHH, CMPPBAAMJMA GDAEJKCKMOM, CMPPBAAMJMA ACPNCMPFNIB, CMPPBAAMJMA BBILDKPAKOC, CMPPBAAMJMA PMMPKKDBCDA, CMPPBAAMJMA EJAHKHNLGID, Transform IPLOCFJPINM, Transform GGJCPOJEDPO, GameObject OOPNBPDAHGH, GameObject PDAHMHHOJIK, AvatarBodyPartShapesManager PLOOJHHHLAJ)
	{
		return default(KBANNBMGJGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68292E0", Offset = "0x68278E0", VA = "0x1868292E0")]
	public static CEGDCKHDECC LMEEECJELDE(string LEDPPHEBBGP, bool NMHBACKKFAA, bool KBFHFFLGFID, bool IPCKICHMOII, Func<HNHGIGGCOEK> IFMOKICNOCG, Func<Vector3, AILLONLIOPL> HHGBJCMHLEG, RigidbodyEx KOLDPJOJMOP, RigidbodyEx CIOACLIDEKN, RigidbodyEx MBNLGNHFHFC, RigidbodyEx GNLCKAMPIOB, Transform PKMIAPJNIAA, Transform CMFGLKNELHP, Transform PKCBJJIGICK, float EPEMFKJHEPP, float MIEGBNGGDGN, PlayerAvatarFullBodyColliders KKAJAKNCANI, SkinnedMeshRenderer[] AEJIPIEPOPF, SkinnedMeshRenderer[] OMJNDNNJFJC, SkinnedMeshRenderer[] APILKACMMKJ, SkinnedMeshRenderer[] CKBAMPMMABJ)
	{
		return default(CEGDCKHDECC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6828A40", Offset = "0x6827040", VA = "0x186828A40")]
	public static DAPDMFLMPMN ALOFDMOJPOF(Transform FGGDLIIINCM, AssetReference IOICAJEBIBI, GameObject FHMHELIJOFG, GameObject PALNFOKJEGI, SkinnedMeshRenderer CCPDOIDKMLB, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM, Material IGAJOBMOOPE, Material EADKEGOBEOE, Material EGGHNLJIKNB, Shader EOKLFNJNBCK, Shader FCCOCAFELDO, Animator HAAOEPKGKNC, Renderer[] LJMIHNHAEHE, AvatarConfiguration CEPIAMFLECL, AvatarBodyPartShapesManager PLOOJHHHLAJ, IReadOnlyDictionary<string, Transform> ILMAJBPMDCP)
	{
		return default(DAPDMFLMPMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6828BC0", Offset = "0x68271C0", VA = "0x186828BC0")]
	public static OHKKPNMKIGD EGGPDKBEBPO(SkinnedMeshRenderer[] AEJIPIEPOPF, SkinnedMeshRenderer[] OMJNDNNJFJC, SkinnedMeshRenderer[] APILKACMMKJ, SkinnedMeshRenderer[] CKBAMPMMABJ)
	{
		return default(OHKKPNMKIGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6829210", Offset = "0x6827810", VA = "0x186829210")]
	public static ADKNAJDOOKC LCKPGPEDBOM(Transform IKEPJPGKEJL, Transform PKAPBMPHCLI, Transform POMPLCHFCFE, Transform HOANKOJNLAL, Transform JDDOEBMJGIN, Transform KCIBMLDFODE, Transform ANHJNGAJMDG, AvatarConfiguration LOGLAMBNPJF)
	{
		return default(ADKNAJDOOKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x991EE0", Offset = "0x9904E0", VA = "0x180991EE0")]
	public static DOCFECFMOIF NAMAPNGJOAI(SkinnedMeshRenderer[] JAGIHAGDKAD)
	{
		return default(DOCFECFMOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6829170", Offset = "0x6827770", VA = "0x186829170")]
	public static CLGIBKDCNFC KEFDCJOJKGJ(FLPGAIHAKKN BJHCFGNJANO, int FCHANCPEDEI, int HIAHLNNLBHM, Color HBNCCOBMNEI, Color IKPBCMPCCGB, int BOODAAHMDFJ, int CJIPBIDPIDP, Color JAOGADGFAMA, Color EJPCIBBOMNB, int HNFEKDPKDOO)
	{
		return default(CLGIBKDCNFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6828CF0", Offset = "0x68272F0", VA = "0x186828CF0")]
	public static MAEONAPIKCA HNLIHJOGHLP(FLPGAIHAKKN BJHCFGNJANO, Vector2 KIMPBIDMCBA, float KIPAPCIGJFJ, Vector2 HFKPKHNOIID, float DGJNEKHKAEI, Vector2 IMHPHKNALBD, float LMDMIHIPGBD, Vector2 OJLKMBIELCP, float FFNEOGEPMHP)
	{
		return default(MAEONAPIKCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6828C80", Offset = "0x6827280", VA = "0x186828C80")]
	public static CPGPGEHMHOJ GFLGHJNIDBG(Animator PMFGIMLBPAB, KJHAHHBINEC KDPIPDNAOHJ, AvatarConfiguration CEPIAMFLECL, GameObject LGAPJEIIADP)
	{
		return default(CPGPGEHMHOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6828C40", Offset = "0x6827240", VA = "0x186828C40")]
	public static CBMPKJMGNCL EHIBOEICHOO(Transform ACDICOPJJPJ, bool KBFHFFLGFID)
	{
		return default(CBMPKJMGNCL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OOPCNLIPJPC
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x682B1B0", Offset = "0x68297B0", VA = "0x18682B1B0")]
	public static NNNBHLGDPFP KLOFCLAALBK(this NHNAPMDMKLL IMELNGHGLBH)
	{
		return default(NNNBHLGDPFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x682B200", Offset = "0x6829800", VA = "0x18682B200")]
	public static bool LILBLMKBEHD(this NHNAPMDMKLL PDMJKELKPPE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CJJPNJPONEO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PFEBIHKFJOC : CJJPNJPONEO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform ODNLGPAEKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 BDPNJNGAFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDC6200", Offset = "0xDC4800", VA = "0x180DC6200", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDC61F0", Offset = "0xDC47F0", VA = "0x180DC61F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? AJACMKNKBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEF7F30", Offset = "0xEF6530", VA = "0x180EF7F30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xEF7F20", Offset = "0xEF6520", VA = "0x180EF7F20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public PFEBIHKFJOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DOEOAOEMHHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly PFEBIHKFJOC HOLLBGFILFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly PFEBIHKFJOC JFLBPCJLEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly PFEBIHKFJOC BMINNBHAOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly PFEBIHKFJOC PLNNNCIKDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly PFEBIHKFJOC OOMLCKBCICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly PFEBIHKFJOC OCAAOGNDNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly PFEBIHKFJOC DCHBLMFADBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly PFEBIHKFJOC FFIHNDKKLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly PFEBIHKFJOC PFLAGAAFNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly PFEBIHKFJOC DLEDJFENGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly PFEBIHKFJOC IDHAGMGPCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly PFEBIHKFJOC BJIEGEIMMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly PFEBIHKFJOC LMMEAMGJHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected PFEBIHKFJOC MDGLMGLECMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly PFEBIHKFJOC PKMCKKJEMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly PFEBIHKFJOC ANJKABGKMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly PFEBIHKFJOC NJEDKIELJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected PFEBIHKFJOC APJLGHHHONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly PFEBIHKFJOC KPGBADOCAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly PFEBIHKFJOC KDABJNFBMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly PFEBIHKFJOC EGDHCOMEGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected ReadOnlyCollection<PFEBIHKFJOC> MIBCPMLNHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Transform JKOOGDOIHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private (PFEBIHKFJOC Start, PFEBIHKFJOC End)[] OHOGDELHDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private Dictionary<string, PFEBIHKFJOC> AKGFLBJEMPO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CJJPNJPONEO GPFMHPCDAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CJJPNJPONEO FBMFONHHLAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CJJPNJPONEO ECMFKDMMLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CJJPNJPONEO DJNKNIBDJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CJJPNJPONEO ICMBCJFEMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CJJPNJPONEO BPLHCDOCKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x86DC70", Offset = "0x86C270", VA = "0x18086DC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CJJPNJPONEO AOHMDGKFNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x863DF0", Offset = "0x8623F0", VA = "0x180863DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CJJPNJPONEO ONMLEKCDIEI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x863E00", Offset = "0x862400", VA = "0x180863E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CJJPNJPONEO JEBCNKJGJID
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x863E50", Offset = "0x862450", VA = "0x180863E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68296E0", Offset = "0x6827CE0", VA = "0x1868296E0")]
	public void GAMONEPILCD(VRIK NMIMKHLJHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x682A600", Offset = "0x6828C00", VA = "0x18682A600")]
	private void IOEMKBEJMFA(Transform CHNGFEKJHON, PFEBIHKFJOC PKMPGPJICGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x682AAA0", Offset = "0x68290A0", VA = "0x18682AAA0")]
	public PFEBIHKFJOC MLJCDDEKHOF(string GGIILCEGNMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x682A690", Offset = "0x6828C90", VA = "0x18682A690")]
	public void LCIKIMLLDGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x682A5C0", Offset = "0x6828BC0", VA = "0x18682A5C0")]
	public float HLNIIPHMCJK([In] (PFEBIHKFJOC Start, PFEBIHKFJOC End) CBPJCCGFJPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6829530", Offset = "0x6827B30", VA = "0x186829530")]
	public void CAOIKGAHMHH([In] AILLONLIOPL NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x682AB10", Offset = "0x6829110", VA = "0x18682AB10")]
	private Vector3 NEEDPPPNHAE([In] (PFEBIHKFJOC Start, PFEBIHKFJOC End) CBPJCCGFJPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x682AC40", Offset = "0x6829240", VA = "0x18682AC40")]
	public DOEOAOEMHHF()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public GameObject AvatarCollidersPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6828810", Offset = "0x6826E10", VA = "0x186828810")]
		public string LCGPCCBCODK(string IBAJKJPCMHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6828860", Offset = "0x6826E60", VA = "0x186828860")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CEGDCKHDECC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public string DKMNBJMMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool FNNGJGNPBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool MGHLAIKFHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float FHGDKNNHCAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float CJONDCAJKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool HGOABNHKCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Func<HNHGIGGCOEK> PJDFDKOPGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Func<Vector3, AILLONLIOPL> OJDOPHKDEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public RigidbodyEx BOOBIIBDOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public RigidbodyEx IMIJMGLDOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public RigidbodyEx DBIGPHPGGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public RigidbodyEx BLOJBMPCMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Transform GIJHLOCNKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform GFNNIJBJBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform NPDEADGDCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public PlayerAvatarFullBodyColliders OPBKIHNCAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public SkinnedMeshRenderer[] MBEHOKIDMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public SkinnedMeshRenderer[] CEMCFAILCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public SkinnedMeshRenderer[] HIKNGCDLCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public SkinnedMeshRenderer[] PBBEJOACGCO;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68288B0", Offset = "0x6826EB0", VA = "0x1868288B0")]
	public AILLONLIOPL AGADMOMPGJO(Vector3 IJMFLOHMJBC)
	{
		return default(AILLONLIOPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct KBANNBMGJGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Transform NCCPHPCIPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform AOCKHFAPJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public AvatarConfiguration ODMCEOBGOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Animator PPKDHDGCACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public VRIK AFPCDGAKIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public GameObject[] ABJDGLPLHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform GJHLELOADPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public AssetReference HMOLPKOKMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public GameObject MHOBNMEGNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public GameObject ALIAJPMKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public SkinnedMeshRenderer BPAGABBKDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public AvatarSkinnedMeshBoneOrderRemapsData MHMKLILFMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Material FJGCEAPPFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Material KCHDCDMDBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Material HOONCGBLAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Shader IOGKMLOLIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Shader MFHCLECPAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Transform AFPKAKNLBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Transform GDDBLOALDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Transform IMIFFFMNBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Transform AKCCMMBJCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Transform NPHALAFFABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Transform KCNBOPICGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Transform JHEABOJMFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Renderer[] IJOHIFHMJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform CCBHEDIMNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform MMOBACPCDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public GameObject JLIHPDFCABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public GameObject IKKOJMMDEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public CMPPBAAMJMA CAAPIBNMBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public CMPPBAAMJMA DFMJCOAICNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public CMPPBAAMJMA KGILFDMFOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public CMPPBAAMJMA AKCINFFBJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public CMPPBAAMJMA OJAJJCGHNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public CMPPBAAMJMA LPNPDPJGOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public CMPPBAAMJMA CEBKMDHMLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public CMPPBAAMJMA GLPIFIICOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public AvatarBodyPartShapesManager KBHHMGGEAML;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct HNHGIGGCOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool LKGNNIHNKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public HPJFBALBIOJ OEMICALAAIG;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct AILLONLIOPL
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class IPJKFJCFNBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public readonly bool INFPDPDFLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly bool FICJBDHJCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly bool IIOBAMJJKOL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x682B160", Offset = "0x6829760", VA = "0x18682B160")]
		public IPJKFJCFNBO(bool AGKBLFAPGLA, bool DBHMLAHCEBO, bool BHPGPFGPLLK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public float AIFANPKCABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool ODJKHEFKHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public float GDAIGNBMHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3 MEBDGNKOCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3 KMPLHFEHLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3? GEAGICIFHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Vector3? KJGODKDNPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool HFANJEOMMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool DIECMFHMFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool MJJHPHJFAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool DGDMAHHFNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector3? KNMNMIDIKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool JDIAFCBHBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Vector3? JNNBEBIDFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool IKOPPEHBMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Vector3? EGDLLIPLPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public float LDOKHAFLGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3? AEEGFIDCGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool LBAFLGCDEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool JGPNEEGBDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool KNPADPBDEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool MOJNELANPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public bool OLPDDEIOCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool HEFANBAAMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool BAJDILGNKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public bool APHDNENMGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool EHKIMKEBKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public bool ODOHMFCPCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool LEOBBCMFCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Vector3? MLDDFMKPFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public NHNAPMDMKLL DMFNCNFAAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public NHNAPMDMKLL BJCLOBDLHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float EOBPAGMDMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float EIFGNMMGLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public FLNAILNJOEP MEMCBEIFPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public FLNAILNJOEP IOLMGPGFINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public bool HGOJLGPJKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public IPJKFJCFNBO FCGFKJKDFKM;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6826F00", Offset = "0x6825500", VA = "0x186826F00")]
	public void OOPPFFEEEJO(Quaternion ADNGPFKNGFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class EPOHFLBOMKA
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x682B120", Offset = "0x6829720", VA = "0x18682B120")]
	public static CFGFGPACPAK JKLBGBLHFEC(this EPBAMAOALIM OLDDCPCBGIL)
	{
		return default(CFGFGPACPAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x682B140", Offset = "0x6829740", VA = "0x18682B140")]
	public static void OIMFMNFDLAC(this EPBAMAOALIM OLDDCPCBGIL, CFGFGPACPAK CBAEIEAPLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface CMPPBAAMJMA
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float DGOHALMDCDO);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private FGMICPHPGIN EGAPAEMLHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Collider[] GJKLHLLIPBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] JHOKGOLOBGB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> EOECLIKFLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x682BC50", Offset = "0x682A250", VA = "0x18682BC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private FGMICPHPGIN BHDOBPDHPHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x682B220", Offset = "0x6829820", VA = "0x18682B220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CKFLPLIEEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA54210", Offset = "0xA52810", VA = "0x180A54210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x682B2C0", Offset = "0x68298C0", VA = "0x18682B2C0")]
		private void LAJCCKFEMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x682B210", Offset = "0x6829810", VA = "0x18682B210")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x682BC30", Offset = "0x682A230", VA = "0x18682BC30")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer IHBLHBAEOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x682BA40", Offset = "0x682A040", VA = "0x18682BA40")]
		public void SetCollidersEnabled(bool GFLBKNDOAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x682B610", Offset = "0x6829C10", VA = "0x18682B610")]
		public void ReparentBonesUnderOtherBoneCollection(FGMICPHPGIN FMJJBLJIALI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x682B370", Offset = "0x6829970", VA = "0x18682B370")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AKPCGMBJNHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public Transform FCNLEKOJGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public Transform GEAIMHJOIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Transform FAFBHNDHCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Transform MIIJPOPBDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Transform NFJNICNAMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Transform JEPOAMLIJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public Transform EEKIANPPDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Transform IPMGHIENCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private Transform DPOCJKOKBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private PositionAndRotation MBINGILDHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private PositionAndRotation NPHLLDOEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private PositionAndRotation BHDODOOOCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private PositionAndRotation LIHEOBLHBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private PositionAndRotation NLCJEPEKCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private PositionAndRotation HIPIEFFGOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private PositionAndRotation LNDICCAEJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private PositionAndRotation KGPGAPDINBH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6827320", Offset = "0x6825920", VA = "0x186827320")]
	public void BGGINNGCCML(Transform LLCCAPLGNHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x68279E0", Offset = "0x6825FE0", VA = "0x1868279E0")]
	public void BLIFAFLAEGI(HandLogicOffsets FGDOFKAMDHJ, KJHAHHBINEC GONEPKDBPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6828220", Offset = "0x6826820", VA = "0x186828220")]
	public void GEJCOCJJOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6828470", Offset = "0x6826A70", VA = "0x186828470")]
	private PositionAndRotation KLCGMOBHJGN(Transform JCJFBCFBNIA, Transform ODMEEDJIFMO)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6828540", Offset = "0x6826B40", VA = "0x186828540")]
	private void MKEDFMEGMGH(Transform JCJFBCFBNIA, Transform ODMEEDJIFMO, PositionAndRotation AHGGFHPCJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public AKPCGMBJNHJ()
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
