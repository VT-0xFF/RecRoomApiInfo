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
public enum IJOIHDELMHF
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
public struct MBOEDHIFOIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator GFFBPNBAMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public JFLLPCBBFAM EKGGHDNGCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration PJDEHOOHGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject DOKKCJABKFE;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FPLGKJFGKHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform ALKFKIDNHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool MNICIFEAFPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HFLAFCBDBOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public IJOIHDELMHF? MJIEFMCJODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public IJOIHDELMHF? NNNPOEJJCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? PLHAIFKMDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? OBGKHJLCFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? EMCCAOOLDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? BOGDBPPBELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? EHPHECDIBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? EDJOINPBPEH;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JFLLPCBBFAM
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JFOBJNADNNE
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	OBSOLETE_CannedWave = 1000
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PositionAndRotation WatchMenuOriginOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class DNPNAGOHLOF
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly string DNFPIGHPDMG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6095050", Offset = "0x6094050", VA = "0x186095050")]
	public static LPMANJIFANN EFOOKMOMIIM()
	{
		return default(LPMANJIFANN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6095380", Offset = "0x6094380", VA = "0x186095380")]
	public static BJOLIDHLPPI KFNCBGNFHGL(Transform BMMHPEJKFOM, Transform PHKOGKBCCEI, AvatarConfiguration KEGMEDJFHDE, Animator EKHCGHPCFNP, VRIK MMOBGGABNPM, GameObject[] LLACACBPLOJ, Transform DJPNINNGOGK, AssetReference CBKNFKHLDBE, GameObject CEEALONJLMN, GameObject HEKLNECLIPN, SkinnedMeshRenderer FIBPHCDNGJE, Material POHBDMAEGKD, Material JPDPFBEEJAN, Material JKBGKKMBNPC, Shader IHBNIPIJBOC, Shader KFLPBJEPBBB, Transform MODIDJAMGBH, Transform EBKGBBLALOF, Transform FLPCMKDHMLM, Transform KNBOGBNNDKJ, Transform LLNKGMHGIPM, Transform KCKPJJJNBOI, Transform MCGIEHDKHEJ, Renderer[] MCLEGMMKNEN, MEMCONAKEHI NMNHLNLNPNF, MEMCONAKEHI ALIHNIDGDBJ, MEMCONAKEHI NJOIDKPMANO, MEMCONAKEHI EKLJHECPFEI, MEMCONAKEHI EPGNJMGFPIK, MEMCONAKEHI EFOEEEDKCBP, MEMCONAKEHI BAGFNNCKGAN, MEMCONAKEHI GMMFKCGFJJG, Transform HOFPMLNANBJ, Transform KNLJCLHCFKJ, GameObject OBKNKICEJKA, GameObject BPDHKMMMHPF)
	{
		return default(BJOLIDHLPPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6095720", Offset = "0x6094720", VA = "0x186095720")]
	public static ABIFGNOALND KHCIEJCHGDM(string GJELBFCAOAB, bool DPJAENAICOH, bool BMILILMJNMP, bool OEHHGCLIJAJ, Func<GCJKBCHIIEO> AIJKKODBOKJ, Func<Vector3, LPMANJIFANN> KPEGHKJJNMB, RigidbodyEx AHNMHLJBOII, RigidbodyEx EKEFFMEEDBK, RigidbodyEx DPKHIFLLLEA, RigidbodyEx IEHBFKKMCEG, Transform ENFBAKMCNJH, Transform GADGLLIILNG, Transform DKHBMMCGMAI, float AGBBKFENDJI, float OJDALEFGKPC, PlayerAvatarFullBodyColliders ODNMJOCCIAK, SkinnedMeshRenderer[] MOAMMCBDPEH, SkinnedMeshRenderer[] GKNFIMFPLPK, SkinnedMeshRenderer[] LDBENEAAHGL, SkinnedMeshRenderer[] NCDPEIIMDKB)
	{
		return default(ABIFGNOALND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6095140", Offset = "0x6094140", VA = "0x186095140")]
	public static COFGPMKBMIP GBOJPFNGKEH(Transform PHKOGKBCCEI, AssetReference CBKNFKHLDBE, GameObject CEEALONJLMN, GameObject HEKLNECLIPN, SkinnedMeshRenderer FIBPHCDNGJE, Material POHBDMAEGKD, Material JPDPFBEEJAN, Material JKBGKKMBNPC, Shader IIFGOPLEBIM, Shader PPFLJPCBLPM, Animator BELPMELBMAI, Renderer[] MCLEGMMKNEN, AvatarConfiguration BBEFJGFJJNC)
	{
		return default(COFGPMKBMIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6095270", Offset = "0x6094270", VA = "0x186095270")]
	public static FPFCGIGJENB HIFKJJMLPGN(SkinnedMeshRenderer[] MOAMMCBDPEH, SkinnedMeshRenderer[] GKNFIMFPLPK, SkinnedMeshRenderer[] LDBENEAAHGL, SkinnedMeshRenderer[] NCDPEIIMDKB)
	{
		return default(FPFCGIGJENB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6095930", Offset = "0x6094930", VA = "0x186095930")]
	public static PIKANHFODBJ PIHNEHAODLG(Transform MODIDJAMGBH, Transform FLPCMKDHMLM, Transform EBKGBBLALOF, Transform KNBOGBNNDKJ, Transform LLNKGMHGIPM, Transform KCKPJJJNBOI, Transform MCGIEHDKHEJ, AvatarConfiguration KEGMEDJFHDE)
	{
		return default(PIKANHFODBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x14CCC90", Offset = "0x14CBC90", VA = "0x1814CCC90")]
	public static MKOMCBJDJIO BBBKFBOKBOM(SkinnedMeshRenderer[] LMCAGMLBKPG)
	{
		return default(MKOMCBJDJIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6095090", Offset = "0x6094090", VA = "0x186095090")]
	public static FNDGGPJMFOH FHCBHOBKLAF(EBEJOMINEDA JKIAMEHFLED, int PNIMFAEMEGE, int COKFLKHNFEN, Color ODGHAHOFNJN, Color IKCCDCCIHOM, int JNJJLHIENIH, int HLJNKIDHFKF, Color IKJBFGGANCB, Color IFPPMJMKAND, int CLGELPPCNGK, float GNGHMHPPMFK)
	{
		return default(FNDGGPJMFOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6094FA0", Offset = "0x6093FA0", VA = "0x186094FA0")]
	public static POPLICIOBHL DDONCBJNCIE(EBEJOMINEDA JKIAMEHFLED, Vector2 MBLMGPBPLND, float PJELMCDFJLN, Vector2 NGLNPHBKMMN, float OPPHPEDACHE, Vector2 HPFIDJGOCPO, float CJDNGCNGKBP, Vector2 LKLBDEELEBP, float PPPKOKKGHEF)
	{
		return default(POPLICIOBHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60958C0", Offset = "0x60948C0", VA = "0x1860958C0")]
	public static MBOEDHIFOIP LIJAONNMOCP(Animator NEKIGEGNHMJ, JFLLPCBBFAM BLHOOEAKCDB, AvatarConfiguration BBEFJGFJJNC, GameObject NFFLBOOAJEN)
	{
		return default(MBOEDHIFOIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60952F0", Offset = "0x60942F0", VA = "0x1860952F0")]
	public static FPLGKJFGKHC JMFFFECCCPG(Transform DMMNLLPONKL, bool BMILILMJNMP)
	{
		return default(FPLGKJFGKHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6095330", Offset = "0x6094330", VA = "0x186095330")]
	public static HFLAFCBDBOI KACOJHCLANN([Optional] IJOIHDELMHF? PPEFANODMJF, [Optional] int? LDEDKKDKPMI, [Optional] float? KDGDFNGFHFC, [Optional] float? MHDNALCONHF, [Optional] bool? BGKNGIMEGCG, [Optional] bool? NBJBGJIFDCH, [Optional] bool? FKAADCFJAIC, [Optional] IJOIHDELMHF? EJPJEJADNLA)
	{
		return default(HFLAFCBDBOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MPGBBNIPEOJ
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60973D0", Offset = "0x60963D0", VA = "0x1860973D0")]
	public static IJOIHDELMHF DJNOKLPECBH(this JFOBJNADNNE INAHPPFMFHI)
	{
		return default(IJOIHDELMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6097420", Offset = "0x6096420", VA = "0x186097420")]
	public static bool JICJKFLEDEL(this JFOBJNADNNE NDDNKIOPBHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NOENMNEELCE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ONFDNPOKCFH : NOENMNEELCE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform HIHCCNHOFBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BC250", Offset = "0x7BB250", VA = "0x1807BC250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 JBKJGPPCJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD6A7D0", Offset = "0xD697D0", VA = "0x180D6A7D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD6A7C0", Offset = "0xD697C0", VA = "0x180D6A7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? LMEGOLEAODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD6A7A0", Offset = "0xD697A0", VA = "0x180D6A7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD6A7B0", Offset = "0xD697B0", VA = "0x180D6A7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public ONFDNPOKCFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class OEJKPKBFICG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly ONFDNPOKCFH NHLDENIKMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly ONFDNPOKCFH GJAKJIKIBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly ONFDNPOKCFH PABBLEPFPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly ONFDNPOKCFH BMBJOJJGFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected readonly ONFDNPOKCFH PLEIBGPONHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly ONFDNPOKCFH CLMLJKEELPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly ONFDNPOKCFH KNINEHLAGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly ONFDNPOKCFH NKLEJMJFGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected readonly ONFDNPOKCFH MKDDPHKCOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly ONFDNPOKCFH FBCNIMDDMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly ONFDNPOKCFH NPJBCIIHEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly ONFDNPOKCFH FGMCAKHPGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected readonly ONFDNPOKCFH JNGGBPFFECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected ONFDNPOKCFH CHACPHLPIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly ONFDNPOKCFH IBHPMPOLAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly ONFDNPOKCFH PMJJJOOIKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly ONFDNPOKCFH IDNBAMKKPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected ONFDNPOKCFH LHMHAMGNFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly ONFDNPOKCFH AHLBNBGGKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly ONFDNPOKCFH OJLHHDFNBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly ONFDNPOKCFH IFBHGBJKNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected ReadOnlyCollection<ONFDNPOKCFH> JLIGKPMNGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform DJPNINNGOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private (ONFDNPOKCFH Start, ONFDNPOKCFH End)[] PEGPDNLBEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, ONFDNPOKCFH> CNBIALKJCEJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NOENMNEELCE EEDCDMLOEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NOENMNEELCE BNKJOKFMDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NOENMNEELCE DOHHPHBDCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NOENMNEELCE EJPECKBCAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NOENMNEELCE BNKCEIJLAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NOENMNEELCE DOKLNIJGJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3310", Offset = "0x7C2310", VA = "0x1807C3310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NOENMNEELCE DGDCOEPIMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1250", Offset = "0x7C0250", VA = "0x1807C1250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NOENMNEELCE KGBEJAKHJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1230", Offset = "0x7C0230", VA = "0x1807C1230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NOENMNEELCE HJLNFGLMIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C3250", Offset = "0x7C2250", VA = "0x1807C3250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6097C60", Offset = "0x6096C60", VA = "0x186097C60")]
	public void PKPLBHGBBPC(VRIK CMNPPHHCIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6097690", Offset = "0x6096690", VA = "0x186097690")]
	private void CMFGCHGNJME(Transform HLPKKPNOMHG, ONFDNPOKCFH PGJBCOPPFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6097620", Offset = "0x6096620", VA = "0x186097620")]
	public ONFDNPOKCFH CHBMGPJDDGK(string CDIACKHGJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6097720", Offset = "0x6096720", VA = "0x186097720")]
	public void FDJACHODKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6097430", Offset = "0x6096430", VA = "0x186097430")]
	public float BBJFDGLNKCM([In] (ONFDNPOKCFH Start, ONFDNPOKCFH End) CNJECPKEDEC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6097470", Offset = "0x6096470", VA = "0x186097470")]
	public void BEBIENGGDEI([In] LPMANJIFANN NLJIDPFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6097B30", Offset = "0x6096B30", VA = "0x186097B30")]
	private Vector3 IPDBEAMJLOG([In] (ONFDNPOKCFH Start, ONFDNPOKCFH End) CNJECPKEDEC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6098B40", Offset = "0x6097B40", VA = "0x186098B40")]
	public OEJKPKBFICG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6094EC0", Offset = "0x6093EC0", VA = "0x186094EC0")]
		public string BJPIAIDKEKC(string IHLFAEHGDFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6094F10", Offset = "0x6093F10", VA = "0x186094F10")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ABIFGNOALND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string JKJMFKGCOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool MNICIFEAFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool PFACDKMMKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float NIKINCJLMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float EHBLCMMJAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool JPLNHKDFLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public Func<GCJKBCHIIEO> JGNCHNHBFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Func<Vector3, LPMANJIFANN> HBAFHBLHMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public RigidbodyEx CNLFFKJLALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public RigidbodyEx OPAABIPNEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public RigidbodyEx EHJCBOLGGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public RigidbodyEx IFBIEMJIFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Transform BLJEIENGMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform CELGJFIMHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Transform HJHMDFNOFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PlayerAvatarFullBodyColliders PAOGDPOMFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public SkinnedMeshRenderer[] MJKKNEPOEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer[] EBIPLKGDLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public SkinnedMeshRenderer[] AMDJGBBCBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public SkinnedMeshRenderer[] IPEKGDLCDOE;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6094D30", Offset = "0x6093D30", VA = "0x186094D30")]
	public LPMANJIFANN MCIGKCBCIKN(Vector3 ILCIHGGFECH)
	{
		return default(LPMANJIFANN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BJOLIDHLPPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Transform NPPCKHLDKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Transform EGNEJHDKNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public AvatarConfiguration PJDEHOOHGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Animator OMIAJACJHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public VRIK FPCCKGHLPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GameObject[] NGAECBDFKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform ABEOEAPFFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AssetReference FAOJPBFNHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public GameObject DLGOCEJJMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public GameObject IJMOFHEKNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer KAMOELNHFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Material FGDLMIGIOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Material BPDKOFCINCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Material INFGBLLODPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Shader LNFKEMGDFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Shader MFBFNDOGOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform GFEIOJIFECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform AOLAICAKGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform BDGFCNMEMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform BCIMBPPGMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform PBAMEEDJDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform CHGLDOFNGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform GHJPAGKHIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Renderer[] AHADHDBMJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform DADOOFCELKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform HMHDNAICJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public GameObject AJFFEDFPOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GameObject OLKOKEPKNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public MEMCONAKEHI APMNADEPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public MEMCONAKEHI KDLIHPKFBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public MEMCONAKEHI OEPCDKKJDKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public MEMCONAKEHI JPBMBHJMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public MEMCONAKEHI OFJIFCCIJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public MEMCONAKEHI KCHPJOLBDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public MEMCONAKEHI PFCEDPAGEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public MEMCONAKEHI IIPHNEMBJKK;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct GCJKBCHIIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public bool JEDFFGHLCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public GMBNNMLOONM FLCPJDPNDEN;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LPMANJIFANN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class MPFEMGNFHPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly bool HCNLIPGFJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly bool BBLNAHCBEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly bool GAONILKJKBP;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6097380", Offset = "0x6096380", VA = "0x186097380")]
		public MPFEMGNFHPO(bool LDBHDDCDENN, bool FDIIEHHMLGD, bool KGAGJIHGFAL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float KJEOGMMIHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool KNEJJIPFMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float ADENLGAANCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Vector3 LLKDHKANHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3 CDKLCPKDJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Vector3? DPJHLGIPNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Vector3? GACFHLAKCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool HBLJIJIOGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool CALFPBODJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool JHFHPKGEBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool CHKMFNELMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3? KBCDCMMMHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool IHPLDGDCKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? LJHGNMFCAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool HGONPLAPNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Vector3? BDDNPIICDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public float PHBLHGIDIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3? PHPBGHCLLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool LGCGIGNIGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool NMLNENENBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool OACNAIJOAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool DFNAINDMKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool FOMNLBAPNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DPFGDANDCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool KBAKJOHBKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool KALHFMBHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool DELNIABANJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool FFBCMPFFDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool IKIICJDJOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? IKHKGJLPEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public JFOBJNADNNE GBKBECMAGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public JFOBJNADNNE KBIGLJGKHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool MKOHPGKHNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool HOLHCEPCAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public MPFEMGNFHPO CGGBNGCBOKP;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6096F60", Offset = "0x6095F60", VA = "0x186096F60")]
	public void GLEGPPODOOB(Quaternion GOAHENPPMCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CCBNFENLLDJ
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6094F80", Offset = "0x6093F80", VA = "0x186094F80")]
	public static HBNDMEPLGIE PEBLBDMODCL(this IJOKBOMFKOA AOFEPADBPDL)
	{
		return default(HBNDMEPLGIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6094F60", Offset = "0x6093F60", VA = "0x186094F60")]
	public static void KOENEBKFCHD(this IJOKBOMFKOA AOFEPADBPDL, HBNDMEPLGIE CFJDHAGGAJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MEMCONAKEHI
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float HBFOIDKFIJC);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private DABCKACPAND EEOFJPHJPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Collider[] NIKDPJPMOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] MBKKKOONELM;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> BMJPNHLJHDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6099A00", Offset = "0x6098A00", VA = "0x186099A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DABCKACPAND EJOKIBDIMCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6099020", Offset = "0x6098020", VA = "0x186099020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool CKNLKANPKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD50830", Offset = "0xD4F830", VA = "0x180D50830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60999E0", Offset = "0x60989E0", VA = "0x1860999E0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer NLMFCHPACGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6099790", Offset = "0x6098790", VA = "0x186099790")]
		public void SetCollidersEnabled(bool PNLCCPNIGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6099360", Offset = "0x6098360", VA = "0x186099360")]
		public void ReparentBonesUnderOtherBoneCollection(DABCKACPAND HHPNCINHMJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60990C0", Offset = "0x60980C0", VA = "0x1860990C0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KIHBPHOKLOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Transform FGHFKIMLOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform JFIGBOGGJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Transform ELPCDCDAHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform MFNFMGCPLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Transform KPPNHMIGLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Transform HADIGEFLABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Transform KHOAHABHIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Transform KDNMKLNFHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Transform FIENBAPFLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation KBCOBAHAIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PositionAndRotation DGLPGFGCCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private PositionAndRotation LMCDIPKACHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private PositionAndRotation IDEGMBADJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private PositionAndRotation OEHIMEGJLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PositionAndRotation POKHIGBNJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private PositionAndRotation GFHOMENJKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PositionAndRotation JJCMCIPJGAD;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6095A70", Offset = "0x6094A70", VA = "0x186095A70")]
	public void DPGLELIALOP(Transform MBKOGLOAFAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6096720", Offset = "0x6095720", VA = "0x186096720")]
	public void PHADNJBNIDI(HandLogicOffsets FAIEAGEDAFF, JFLLPCBBFAM BKFLLFHKPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6096130", Offset = "0x6095130", VA = "0x186096130")]
	public void KPHPPCICINE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6096380", Offset = "0x6095380", VA = "0x186096380")]
	private PositionAndRotation LKKLAOEEGKD(Transform LFFMLHHAMHA, Transform ELCEDDCEHDO)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6096450", Offset = "0x6095450", VA = "0x186096450")]
	private void LNPMDJPMKNK(Transform LFFMLHHAMHA, Transform ELCEDDCEHDO, PositionAndRotation GABPCOIJOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public KIHBPHOKLOM()
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
