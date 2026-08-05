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
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IGPEJDHHMCO
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
public enum GLDELPCMEFD
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
public struct OENJMENICAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator FCPKHICNKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public KDACIGBODIF AAHDFADHFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration OPKIJLJIBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject EIDACNHILGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public DBODHIJMFKE OMPGCOJPLCP;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct PKHNBGDANJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Transform OJLPJIODKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool BJHKKKGPJPC;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum LIJCDJPHGMG
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LCEEJICONKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	AimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	MeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	LightItem,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	HeavyItem,
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	AimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	Action,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	NumTypes
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AFJFNDIDDOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 JADHPGBLJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 OHKLLOEKNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 AGCPILIIIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 LGOIIHBBJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 NDGMLPILMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 EEDFOPPMAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 DLJDOMEEDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 LKEOJHMGOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 KCNGOJPHHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 ODJCBAJPADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 FPPAPGECKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Vector2 DNPKKIMGEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Vector2 ELLNCCKMKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Vector2 KDNAPIADMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Vector2 JHICMIBMBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Vector2 AJBKMAMBHMI;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class GAPAKGGLOAE
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly string INOHPNLEIMJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67DDBE0", Offset = "0x67DCFE0", VA = "0x1867DDBE0")]
	public static DEBNEDBKMEC MLOPEBDEMHA()
	{
		return default(DEBNEDBKMEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67DD2E0", Offset = "0x67DC6E0", VA = "0x1867DD2E0")]
	public static IEEALKDNMIP JDJKDBEEOGE(DBODHIJMFKE MCNAHMPHBIK, Transform EKCGGEIDECC, Transform KLDFMIBMJFJ, AvatarConfiguration IOIEICBMGJJ, Animator LNGJDAKLGCK, VRIK GAKMDJDDIGD, GameObject[] ODJDDHCADOI, Transform LMHLNHIIPGK, AssetReference BAIHJOCMHAH, GameObject AOMFDLJOBHL, GameObject GEKBEGBEGMM, SkinnedMeshRenderer DPNLCLIHOPJ, AvatarSkinnedMeshBoneOrderRemapsData HDHIOINDDLB, Material ACIMLCGCNME, Material FGMCMIKABFF, Material JDNLNEIILKJ, Shader GDMENIOEPFN, Shader GHCGNBLBLCM, Transform BFIPMEIEPOM, Transform GAEGLEDHGDP, Transform FDMHILAABKO, Transform BLPBAEIMFFN, Transform OHNGBDBFEGB, Transform AACILJKBEEN, Transform EIOMOKMDEPL, Renderer[] EBECBJOEJJF, APOBEBAKCDA DNGLIOOJKKF, APOBEBAKCDA LOODHNAGOKD, APOBEBAKCDA JHMOAODANOM, APOBEBAKCDA LNAAEJIJNND, APOBEBAKCDA CKNJIDNKCBF, APOBEBAKCDA KFAFAIIEAJL, APOBEBAKCDA BAPFLMAEFNL, APOBEBAKCDA BAAOCBMBELA, Transform IKLGKBKKLFF, Transform HOFIEBILGBP, GameObject IGHEMPFKIOB, GameObject HEJOGLBMBBD, AvatarBodyPartShapesManager HPKCFBELDHN, Transform CPOOGMNJELN, Transform OLMHLIDAIAE, Transform ACDEEJLNIDK, Transform FLFMLBEPADJ, Transform BJCKPIKBLGM)
	{
		return default(IEEALKDNMIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67DCE60", Offset = "0x67DC260", VA = "0x1867DCE60")]
	public static CNPNJDGCEFI DCAFPIBHPBB(string MGNJPLOLDIF, bool GDGAPFPJOCJ, bool EACANEKGNNJ, bool HGAKJGOAIEC, Func<FFIMPPILPEE> NGPAIKONKMA, Func<Vector3, DEBNEDBKMEC> ONPNJLPHPBI, RigidbodyEx APOILMIMJCG, RigidbodyEx CJFOMGAMJHC, RigidbodyEx DJMBNJIJKCK, RigidbodyEx JNLINHEOBOL, Transform MCHDCJFFNHL, Transform CICHNIMDBIB, Transform APMDFHDPELH, float NMPGCNCOGDH, float LIMAKLAOHME, PlayerAvatarModernBodyColliders JKCACCBOMBC, SkinnedMeshRenderer[] KEDMJCGAONF, SkinnedMeshRenderer[] OPGCLDLGKJM, SkinnedMeshRenderer[] ONFDEBHCIHM, SkinnedMeshRenderer[] JDNDDHGDCHH)
	{
		return default(CNPNJDGCEFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67DD160", Offset = "0x67DC560", VA = "0x1867DD160")]
	public static IPIMOJAFBJN IJOLOMADHDJ(Transform KLDFMIBMJFJ, AssetReference BAIHJOCMHAH, GameObject AOMFDLJOBHL, GameObject GEKBEGBEGMM, SkinnedMeshRenderer DPNLCLIHOPJ, AvatarSkinnedMeshBoneOrderRemapsData HDHIOINDDLB, Material ACIMLCGCNME, Material FGMCMIKABFF, Material JDNLNEIILKJ, Shader EPDJGKNEKIB, Shader DFACEPFFCAL, Animator KBBEGFPLOLP, Renderer[] EBECBJOEJJF, AvatarConfiguration JAGAEJAGDCN, AvatarBodyPartShapesManager HPKCFBELDHN, IReadOnlyDictionary<string, Transform> AFNAPJPMPLF)
	{
		return default(IPIMOJAFBJN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67DD000", Offset = "0x67DC400", VA = "0x1867DD000")]
	public static OLBIDEIKGOD DOGKGHGHGAA(SkinnedMeshRenderer[] KEDMJCGAONF, SkinnedMeshRenderer[] OPGCLDLGKJM, SkinnedMeshRenderer[] ONFDEBHCIHM, SkinnedMeshRenderer[] JDNDDHGDCHH)
	{
		return default(OLBIDEIKGOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67DCD90", Offset = "0x67DC190", VA = "0x1867DCD90")]
	public static FGJBFEGGOLH BGGPPBNAINI(Transform BFIPMEIEPOM, Transform FDMHILAABKO, Transform GAEGLEDHGDP, Transform BLPBAEIMFFN, Transform OHNGBDBFEGB, Transform AACILJKBEEN, Transform EIOMOKMDEPL, AvatarConfiguration IOIEICBMGJJ)
	{
		return default(FGJBFEGGOLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xA44C30", Offset = "0xA44030", VA = "0x180A44C30")]
	public static NLHFIIFDHFF JFIJCDAEIMD(SkinnedMeshRenderer[] OMPFLIFEPOG)
	{
		return default(NLHFIIFDHFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67DD080", Offset = "0x67DC480", VA = "0x1867DD080")]
	public static CGEECGJAMAK FDMPOFJAJJP(IGBKCKLFAIA MAKDJOHNBEN, int EJEGPFCJLGH, int NDCLNCNFLAK, Color IKPCKFDFLLP, Color OHIFMOHBNHC, int PPAOHGPFDHO, int AGGHKCJBCII, Color DMGKFGAIJGF, Color FDMMIHDGLGB, int IMBFEIMLACA)
	{
		return default(CGEECGJAMAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67DDCB0", Offset = "0x67DD0B0", VA = "0x1867DDCB0")]
	public static ONOHANILGCF POBPENPHJND(IGBKCKLFAIA MAKDJOHNBEN, Vector2 MMCJCAHPKMM, float HOOJIEKAGAC, Vector2 JICJJKPEEEG, float GDLIBGMOJHO, Vector2 MBDMONMJNBJ, float GNMFGLONAPI, Vector2 CPPEMDLAADC, float AJMHELHPIAK)
	{
		return default(ONOHANILGCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67DDC30", Offset = "0x67DD030", VA = "0x1867DDC30")]
	public static OENJMENICAE PMNKNFNFLKL(Animator HJPKFHLFJEO, KDACIGBODIF AGIEHJMCJLK, AvatarConfiguration JAGAEJAGDCN, GameObject BNBGBGPBHBG, DBODHIJMFKE MCNAHMPHBIK)
	{
		return default(OENJMENICAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67DD120", Offset = "0x67DC520", VA = "0x1867DD120")]
	public static PKHNBGDANJA IJMDAAMJBIB(Transform NOKBBMNAGKH, bool EACANEKGNNJ)
	{
		return default(PKHNBGDANJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67DD740", Offset = "0x67DCB40", VA = "0x1867DD740")]
	public static PositionAndRotation LOKEEHLPABM(Transform DFFDEEHNIAG, Transform EKCGGEIDECC)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67DD8D0", Offset = "0x67DCCD0", VA = "0x1867DD8D0")]
	public static void MFOJBLMDPHF(Transform DFFDEEHNIAG, Transform JINIAODBOBK, PositionAndRotation GMJDEPGAIMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JNINDFGPOGN
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67E0350", Offset = "0x67DF750", VA = "0x1867E0350")]
	public static IGPEJDHHMCO AJEMDICOEEB(this LIJCDJPHGMG AJOFJGPCIOE)
	{
		return default(IGPEJDHHMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67E03A0", Offset = "0x67DF7A0", VA = "0x1867E03A0")]
	public static bool GFADLOHLKDH(this LIJCDJPHGMG DOHMCILIIDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OELEGFGMKCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform PEDBLOEBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ADAOFNDAAPK : OELEGFGMKCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform PEDBLOEBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 BHDDFBMJCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xECAB50", Offset = "0xEC9F50", VA = "0x180ECAB50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xECAA20", Offset = "0xEC9E20", VA = "0x180ECAA20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? CLBLECPFJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xFF9E50", Offset = "0xFF9250", VA = "0x180FF9E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xFF9E40", Offset = "0xFF9240", VA = "0x180FF9E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public ADAOFNDAAPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GIGNLJOCGDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly ADAOFNDAAPK GNHGKCAKHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly ADAOFNDAAPK JJJKALECOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly ADAOFNDAAPK OJBPGGEADMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected readonly ADAOFNDAAPK CFHMGPCDIOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly ADAOFNDAAPK CFOCNLDBCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly ADAOFNDAAPK FGPHJCKPAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly ADAOFNDAAPK GDGPGLPKHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly ADAOFNDAAPK GMLHCOJHEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly ADAOFNDAAPK GAHDKGMHOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly ADAOFNDAAPK MKKPGPCOHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly ADAOFNDAAPK GCLNDKDLHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly ADAOFNDAAPK FICCGKAMOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly ADAOFNDAAPK LNOHNNEJMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected ADAOFNDAAPK ANKMJEDFMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly ADAOFNDAAPK EBFILAMPFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly ADAOFNDAAPK MOAOHGCKGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly ADAOFNDAAPK FJMEOIKPLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected ADAOFNDAAPK FCJMMOINDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly ADAOFNDAAPK FKCPHMMCEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly ADAOFNDAAPK LFPHBMFMBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly ADAOFNDAAPK CJBNEKHDIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected ReadOnlyCollection<ADAOFNDAAPK> NCNNNOGMNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Transform LMHLNHIIPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private (ADAOFNDAAPK Start, ADAOFNDAAPK End)[] DAFKNFJOOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Dictionary<string, ADAOFNDAAPK> BLLMNHFAAOI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public OELEGFGMKCJ CCGBNLDBENA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8517D0", Offset = "0x850BD0", VA = "0x1808517D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OELEGFGMKCJ FNKMPPKIFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OELEGFGMKCJ CALEDHMGFEK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OELEGFGMKCJ KNMCBNFDPME
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public OELEGFGMKCJ FKCCEJGJFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public OELEGFGMKCJ NIKHMDKIKHE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OELEGFGMKCJ ODGBFLNIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OELEGFGMKCJ FLKNLEDEFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84FBD0", VA = "0x1808507D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OELEGFGMKCJ PFEPAPBLBIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x850810", Offset = "0x84FC10", VA = "0x180850810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67DDE20", Offset = "0x67DD220", VA = "0x1867DDE20")]
	public void BMIEABFPOMF(VRIK OLLPNKPJGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67DF4A0", Offset = "0x67DE8A0", VA = "0x1867DF4A0")]
	private void NMDEAGOLGNL(Transform LMADGEINEAF, ADAOFNDAAPK KMCPIOGEAKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x67DEE30", Offset = "0x67DE230", VA = "0x1867DEE30")]
	public ADAOFNDAAPK GFFAJINOPAA(string KFAABPOALLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x67DF090", Offset = "0x67DE490", VA = "0x1867DF090")]
	public void LCPLLPGODAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x67DEEA0", Offset = "0x67DE2A0", VA = "0x1867DEEA0")]
	public float GLAMCDODKEA([In] (ADAOFNDAAPK Start, ADAOFNDAAPK End) DGNMCOODFPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x67DEEE0", Offset = "0x67DE2E0", VA = "0x1867DEEE0")]
	public void JLELGPJHDCI([In] DEBNEDBKMEC AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x67DED00", Offset = "0x67DE100", VA = "0x1867DED00")]
	private Vector3 FJIFADMOBHL([In] (ADAOFNDAAPK Start, ADAOFNDAAPK End) DGNMCOODFPD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x67DF530", Offset = "0x67DE930", VA = "0x1867DF530")]
	public GIGNLJOCGDA()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public GameObject AvatarCollidersPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67DC700", Offset = "0x67DBB00", VA = "0x1867DC700")]
		public string GEPJLOKHECI(string FCLJNMJGCMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67DC750", Offset = "0x67DBB50", VA = "0x1867DC750")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct CNPNJDGCEFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public string HKJMENMEEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool BJHKKKGPJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool PAFMEBBILPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public float LLLIECNKDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public float JODPFHGNABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool CLNEPOAGJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Func<FFIMPPILPEE> FJPLPAJGGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Func<Vector3, DEBNEDBKMEC> DOBOGLJGHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public RigidbodyEx NHCPMEEOMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public RigidbodyEx NKHENPIOOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public RigidbodyEx CKCJKGPDLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public RigidbodyEx NCGAELLEGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform LDPFDKLIMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform LLELAPPEFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform OMDHPGDMPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[FormerlySerializedAs("PlayerAvatarFullBodyColliders")]
	public PlayerAvatarModernBodyColliders JKCACCBOMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public SkinnedMeshRenderer[] LNHJAACDJOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public SkinnedMeshRenderer[] AODMNECLLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public SkinnedMeshRenderer[] HDIGFDNCCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer[] KKFNPDMKOEF;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67DC7A0", Offset = "0x67DBBA0", VA = "0x1867DC7A0")]
	public DEBNEDBKMEC NLLGDDJJBNK(Vector3 ELBLPDIHJFD)
	{
		return default(DEBNEDBKMEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct IEEALKDNMIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public DBODHIJMFKE OMPGCOJPLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform JAIMKBEADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Transform AMOPDPDPODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public AvatarConfiguration OPKIJLJIBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Animator MMNMIDNICFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public VRIK AAEFDLEPNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public GameObject[] CAABLLHEOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform OAAABNGHELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public AssetReference BHBBIPGJJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public GameObject AMJCGEIEFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public GameObject HLBBKLKANEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public SkinnedMeshRenderer JMMGEMLHADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public AvatarSkinnedMeshBoneOrderRemapsData LNOKOCJFFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Material LGCGKHEJCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Material KGKBEBKKBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Material BCGCCHIAEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Shader FMIAMKOMFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Shader JEMJMMPHLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Transform IFDAEBLANGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Transform ENEKGPEDFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Transform DCOEELMHEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Transform MCDANFCECJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Transform AKILIDOKMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform GIHIGBFNGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform KFIPLCJFPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Renderer[] MDABIGPPNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Transform MGBFKNMLMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Transform CPFBAOIPNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public GameObject MHICKANKCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public GameObject HBPPKDAKJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Transform NHHMGFGIJFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public APOBEBAKCDA ABJOBNFOKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public APOBEBAKCDA KKFLPHFMDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public APOBEBAKCDA IDGHOGLLPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public APOBEBAKCDA LGGHFJKLOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public APOBEBAKCDA DMKMHENAAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public APOBEBAKCDA NNLNGANIEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public APOBEBAKCDA CNFACHBHNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public APOBEBAKCDA KBKOEPMEALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public AvatarBodyPartShapesManager GPNECDPNLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Transform JFKGILFNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Transform BGCCHKGPNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Transform EAALCACDNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Transform OKJMBDODIJI;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct FFIMPPILPEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool FAHMGHEDDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public DHNIPGENADJ GBIIHKFBICD;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct DEBNEDBKMEC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class GHDNCEEABMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly bool LIDHCDGJFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public readonly bool BIGCGLEOOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly bool PCHDBCIAHAG;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67DDDD0", Offset = "0x67DD1D0", VA = "0x1867DDDD0")]
		public GHDNCEEABMF(bool IJODLCOCIIG, bool JPPODOOIAJN, bool ILHEMHPPCNO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public float OJFDMMNMNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool JNMOEKHKMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public float CMJLAJFEIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Vector3 EKGOPIKDHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector3 DFKOIIEEBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Vector3? IKCKHPEMLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Vector3? PJKBCFGDFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool LAAKBIKPLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool JGFBJLCOLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool LJHCDDHELMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool ENJCJKGONLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Vector3? POPMBMFPJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool OHCNLGIFNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Vector3? EGNFKMLPPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool MLJCCCHIJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Vector3? IJFFHMFFNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public float OPPLNCMPCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Vector3? JLNBFCLEIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public bool ANENBMHALFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public bool FJAEMKIBCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public bool AJPIGJENJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public bool BBBJOAAJOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public bool PIBGHBAEHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public bool AMFEBFPCHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public bool CCPFCOFEODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool AECKFFKJNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public bool CFMHCCHIMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public bool FNBKINGOHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool NMHDBMLNLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Vector3? DJIMHCIJPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public LIJCDJPHGMG KPKBIABDIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public LIJCDJPHGMG NDKNBHKELOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float LIOMAMGEMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public float ADGBLPLNEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public LCEEJICONKJ KGHAEHMKHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public LCEEJICONKJ MPKLKELPCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public bool IJAKBALOFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public bool LKFILIAPAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public bool FFICEEIEJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public GHDNCEEABMF FOONCEDGNNF;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67DC930", Offset = "0x67DBD30", VA = "0x1867DC930")]
	public void AKFCEJFHJJO(Quaternion MGJIDJKDGAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class EJMALOHEHMK
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x67DCD70", Offset = "0x67DC170", VA = "0x1867DCD70")]
	public static EPOJMBFGCMA MEKGCMJHOOB(this EKFDEJANFPB ABPJKOBADEP)
	{
		return default(EPOJMBFGCMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x67DCD50", Offset = "0x67DC150", VA = "0x1867DCD50")]
	public static void KDPGGHEICON(this EKFDEJANFPB ABPJKOBADEP, EPOJMBFGCMA OBEEJPGJPFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface APOBEBAKCDA
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float OBMBAKPLLKB);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PlayerAvatarModernBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum JNHIEOBMJHA
		{
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			EnabledForFullBody,
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			EnabledForModernBeanBody
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private MDFHPNMEOAF BHODBCLJJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Collider[] EPHKMCPLEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly HashSet<Collider> MNHBFCGGAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private JNHIEOBMJHA? DNPNLCOJNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		private Collider[] FullBodyOnlyColliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] NHLEANLBCMK;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> KHHPCKNKMGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x67E15A0", Offset = "0x67E09A0", VA = "0x1867E15A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MDFHPNMEOAF KCJBAGIOIHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x67E09D0", Offset = "0x67DFDD0", VA = "0x1867E09D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JEPGAGFJCCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x15022F0", Offset = "0x15016F0", VA = "0x1815022F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x67E0A70", Offset = "0x67DFE70", VA = "0x1867E0A70")]
		private void DIJCNDCCJIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67E08A0", Offset = "0x67DFCA0", VA = "0x1867E08A0")]
		private void AJMJFICAGFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67E0930", Offset = "0x67DFD30", VA = "0x1867E0930")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67E14F0", Offset = "0x67E08F0", VA = "0x1867E14F0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer LJCODHGLLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x67E1220", Offset = "0x67E0620", VA = "0x1867E1220")]
		public void SetCollidersEnabled(JNHIEOBMJHA AHEJMLCHHMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x67E0DC0", Offset = "0x67E01C0", VA = "0x1867E0DC0")]
		public void ReparentBonesUnderOtherBoneCollection(MDFHPNMEOAF EGGPBFLIFCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x67E0B20", Offset = "0x67DFF20", VA = "0x1867E0B20")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67E1510", Offset = "0x67E0910", VA = "0x1867E1510")]
		public PlayerAvatarModernBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IALJBCJIJHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public Transform KIPNOIPENHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Transform MEDJLAJCFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public Transform AMGNKIFLGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform IOKPBKFGIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform FJJCOLKHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform GDEEDOFDFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform AHNPGFAPHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform GPJMJPCFGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform GJMMKKHNKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private PositionAndRotation GHDOOJJNFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PositionAndRotation DKPFFEMOMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private PositionAndRotation JPAALBDAKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private PositionAndRotation AFAAOONCBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private PositionAndRotation LMOEHJKPANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private PositionAndRotation EBFMDOGJKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private PositionAndRotation NEECLAKBPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private PositionAndRotation OAPFAIIECDF;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67E0140", Offset = "0x67DF540", VA = "0x1867E0140")]
	public void MGIGIPLLEKC(Transform EKFEFGCHBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x67DFC80", Offset = "0x67DF080", VA = "0x1867DFC80")]
	public void FKNBFNLHLDH(HandLogicOffsets IENNCFOIEGB, KDACIGBODIF JJIPBNBBNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x67DFA10", Offset = "0x67DEE10", VA = "0x1867DFA10")]
	public void EPNCFFDDJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public IALJBCJIJHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ONPLHKENKLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform NOJCPFFHGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Transform EINLCGDEFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Transform HECGIFABBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Transform LPHMDHKOPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Transform GLEAOEFINOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private PositionAndRotation PNLJBPNOEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PositionAndRotation OGNMNEELIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PositionAndRotation JJHMDNGNFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private PositionAndRotation NMPIMHJKLAO;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x67E0560", Offset = "0x67DF960", VA = "0x1867E0560")]
	public void MGIGIPLLEKC(Transform KJIDDICICGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x67E0690", Offset = "0x67DFA90", VA = "0x1867E0690")]
	public void MNAKBDOBECA(HeadLogicOffsets GMJDEPGAIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x67E03B0", Offset = "0x67DF7B0", VA = "0x1867E03B0")]
	public void EAKJCPFBGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public ONPLHKENKLP()
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
