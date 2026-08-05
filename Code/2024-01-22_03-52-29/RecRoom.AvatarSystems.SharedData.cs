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
public enum JKAKIBIFJJG
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
public struct BPCBALDBNJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator EHMFEGLOGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public OKJGIMPKHDP JNPPDPKMCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration PICFCNMBOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject HKCEEKMIMIG;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IHOMOIJNMJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform NOILIKJAONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool FNLAKOJFCPD;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KPJNACOFPIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public JKAKIBIFJJG? BEPPGBFKJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public JKAKIBIFJJG? LEOCFEJGOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? JGPBMJJKABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? NLACBHGGIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? NCDEMCHPGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? DJCCIADCLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? JNGPHPKFEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? LFCPKAFGOKO;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OKJGIMPKHDP
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum BMGLMCGNIFD
{
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	OBSOLETE_CannedWave,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	OpenHand
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public Quaternion Rotation;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PositionAndRotation WatchMenuOriginOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class LCCBLJMEBAD
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly string EGAKNNBCDPH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F33B10", Offset = "0x5F32F10", VA = "0x185F33B10")]
	public static MIHMENGHHFD JFBKBAKLJFJ()
	{
		return default(MIHMENGHHFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F33670", Offset = "0x5F32A70", VA = "0x185F33670")]
	public static JGDBDJFCKME HKKJPCCGAIP(Transform OFBICMIPCED, Transform ONFDEOEELAO, AvatarConfiguration NCNJPLCGBNO, Animator GLJBOICCELJ, VRIK ELECIBLNHBE, GameObject[] EDJLAEIAMAK, Transform JMHOEDPJJBE, AssetReference IGMNPMPHPOC, GameObject JPOAPHBAIGD, GameObject OOAFGPFDOLI, SkinnedMeshRenderer BHMKPNDKGEJ, Material PPNJOOOFNNJ, Material AMPOFIAPDJG, Material FEPAKDAKHJF, Shader OHPDLCJCPGI, Shader GJFELODHEOK, Transform BGJNAECJKFC, Transform KGEDAPNDECN, Transform HJBEIKMCABN, Transform ANBLPEDLPOB, Transform DLNAPKABBDM, Transform MHICCMHEADO, Transform NOJMHPJNFCH, Renderer[] HLJGPDECKDA, HIELNJLEHFL PGKFMGKBPCD, HIELNJLEHFL HOEBELLMNEI, HIELNJLEHFL EACBLBHIKFJ, HIELNJLEHFL KMJANMEEGMM, HIELNJLEHFL IBPAFFGOMNC, HIELNJLEHFL HILNNBKFBGI, HIELNJLEHFL ACOHHMOONIE, HIELNJLEHFL IFIBLHLCJHI, Transform OCHEKLGHLEF, Transform IEOKLBHDEIG, GameObject CIAOKNHACLD, GameObject KDNHHOHBLMB)
	{
		return default(JGDBDJFCKME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F33350", Offset = "0x5F32750", VA = "0x185F33350")]
	public static ENCEPGEKGNM APEFGLDJEAJ(string FNKMICKIEDM, bool ENIFAPLMFHD, bool MBENELHNPKC, bool LPKMNPNNNLL, Func<OELDENOELAE> LIMFCNAJHBA, Func<MIHMENGHHFD> NICICCCDGPB, RigidbodyEx CKLOFGBGCCF, RigidbodyEx OADKLMBMEKD, RigidbodyEx BICHBHDEJHF, RigidbodyEx JGMLJKKFCDA, Transform JOKBHEGPHDL, Transform OAILDHGHJIP, Transform KANKKBDGLGL, float FDOFODBEOFK, float IDGPJFAODFK, PlayerAvatarFullBodyColliders NOJCEKBMPDI)
	{
		return default(ENCEPGEKGNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F33540", Offset = "0x5F32940", VA = "0x185F33540")]
	public static HFEDCAPHLPH GGPFIOBPPKJ(Transform ONFDEOEELAO, AssetReference IGMNPMPHPOC, GameObject JPOAPHBAIGD, GameObject OOAFGPFDOLI, SkinnedMeshRenderer BHMKPNDKGEJ, Material PPNJOOOFNNJ, Material AMPOFIAPDJG, Material FEPAKDAKHJF, Shader EIDAHGMONBB, Shader FDINGOBLEKE, Animator AELNIBIPOII, Renderer[] HLJGPDECKDA, AvatarConfiguration PDPCEAJCPHO)
	{
		return default(HFEDCAPHLPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F33B50", Offset = "0x5F32F50", VA = "0x185F33B50")]
	public static MCKDFAKJDAI LJLIGBHPCAD(Transform BGJNAECJKFC, Transform HJBEIKMCABN, Transform KGEDAPNDECN, Transform ANBLPEDLPOB, Transform DLNAPKABBDM, Transform MHICCMHEADO, Transform NOJMHPJNFCH, AvatarConfiguration NCNJPLCGBNO)
	{
		return default(MCKDFAKJDAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13FD7A0", Offset = "0x13FCBA0", VA = "0x1813FD7A0")]
	public static LGEBBAIIBIC ICAOACAMJKF(SkinnedMeshRenderer[] LMFPNCOEOFM)
	{
		return default(LGEBBAIIBIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F33A60", Offset = "0x5F32E60", VA = "0x185F33A60")]
	public static KKILFBKANPD IDNANBGAGMG(DEPEFJCDGGH DGAFNPAJCPC, int AFIHEHODENM, int NMKMDFPNGKM, Color FBBODHDNMCC, Color INPGPEGKJKH, int CONNCGJJGMH, int IAJDNJNKPLB, Color OLDDLONIIEM, Color NFIBKGICNBM, int NIANNPMLHNH, float LEKGLCMFNNF)
	{
		return default(KKILFBKANPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5F33490", Offset = "0x5F32890", VA = "0x185F33490")]
	public static JDODAPONPNE FDHJMFADLAC(DEPEFJCDGGH DGAFNPAJCPC, Vector2 ABIPEJFKOCP, float OFKKDCKOLNI, Vector2 IFOFFAGFJPG, float EDKPOMGPDKJ, Vector2 GFFGNDDDBPL, float LCJCAAMLKND, Vector2 LODLANLCMDA, float MKBEIGOCJHK)
	{
		return default(JDODAPONPNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5F33C20", Offset = "0x5F33020", VA = "0x185F33C20")]
	public static BPCBALDBNJB NCNLENNHDDL(Animator IKNMBEHGLMG, OKJGIMPKHDP HAMCHCEEECJ, AvatarConfiguration PDPCEAJCPHO, GameObject PEPHMMCPEIC)
	{
		return default(BPCBALDBNJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5F33C90", Offset = "0x5F33090", VA = "0x185F33C90")]
	public static IHOMOIJNMJD PPECMANDBDE(Transform FMLGIGFNAML, bool MBENELHNPKC)
	{
		return default(IHOMOIJNMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F33A10", Offset = "0x5F32E10", VA = "0x185F33A10")]
	public static KPJNACOFPIO IDLOJDDAJBC([Optional] JKAKIBIFJJG? LINFAMPGMAF, [Optional] int? ELFJDKMNDKC, [Optional] float? DPDKOHPAOGE, [Optional] float? KHIJCPHKMAJ, [Optional] bool? FGCPHMDOEGN, [Optional] bool? EBENIHJMBOE, [Optional] bool? JHLHIABHPKG, [Optional] JKAKIBIFJJG? PIODOHGAFFF)
	{
		return default(KPJNACOFPIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FAIDFIDLEIP
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5F33260", Offset = "0x5F32660", VA = "0x185F33260")]
	public static JKAKIBIFJJG EENIMAGOIDO(this BMGLMCGNIFD EFIKKDCIJAG)
	{
		return default(JKAKIBIFJJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NHCLAAFMBOC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KBMGHHOFLKE : NHCLAAFMBOC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform KKHBKNPBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x793930", Offset = "0x792D30", VA = "0x180793930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 JKFFEJFIAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCD2740", Offset = "0xCD1B40", VA = "0x180CD2740", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCD2720", Offset = "0xCD1B20", VA = "0x180CD2720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? EIBNKGDOEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCD2710", Offset = "0xCD1B10", VA = "0x180CD2710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCD2730", Offset = "0xCD1B30", VA = "0x180CD2730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public KBMGHHOFLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PHIPNJBGAKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	protected readonly KBMGHHOFLKE CMLFIMFAHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	protected readonly KBMGHHOFLKE LBEPMAKKOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	protected readonly KBMGHHOFLKE EFKBFKPLFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	protected readonly KBMGHHOFLKE CKGHHOEGCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected readonly KBMGHHOFLKE JLFJNKBNENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected readonly KBMGHHOFLKE OHKGEIGDBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected readonly KBMGHHOFLKE EKIHKNPODJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected readonly KBMGHHOFLKE EBGAMPPNJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected readonly KBMGHHOFLKE GDGGCCBJFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly KBMGHHOFLKE FMPJOBAOPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly KBMGHHOFLKE FGLIAFLDGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly KBMGHHOFLKE BHJCCNGPGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly KBMGHHOFLKE CCCODIABLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected KBMGHHOFLKE POHLNOIDECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly KBMGHHOFLKE MLENEJHIGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly KBMGHHOFLKE KAGPGKAOBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly KBMGHHOFLKE JCADDGEKAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected KBMGHHOFLKE KOEEHFDEFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly KBMGHHOFLKE AIDEBMHLJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly KBMGHHOFLKE HAIEMGMJMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly KBMGHHOFLKE HOGLMDKMNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected ReadOnlyCollection<KBMGHHOFLKE> HMFFKEPJACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Transform JMHOEDPJJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private (KBMGHHOFLKE Start, KBMGHHOFLKE End)[] BBGNMEFBEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Dictionary<string, KBMGHHOFLKE> KKCNEOKPADD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NHCLAAFMBOC NGHCLPFINJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NHCLAAFMBOC HMFHJMECAOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NHCLAAFMBOC AGJAACCFKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NHCLAAFMBOC EOGCHFPFJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NHCLAAFMBOC IFCHBODACMH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NHCLAAFMBOC GGLCJKGEDKI
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x793E80", Offset = "0x793280", VA = "0x180793E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KBMGHHOFLKE HBIPDPMMDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x793E80", Offset = "0x793280", VA = "0x180793E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public KBMGHHOFLKE AMBPOMOOOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x78F350", Offset = "0x78E750", VA = "0x18078F350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NHCLAAFMBOC HAIGDFNFKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x792F30", Offset = "0x792330", VA = "0x180792F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NHCLAAFMBOC ANOKKJACDEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x792F20", Offset = "0x792320", VA = "0x180792F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public KBMGHHOFLKE DGKKJOCHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x792F20", Offset = "0x792320", VA = "0x180792F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public KBMGHHOFLKE GHIDPLNHHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x792F70", Offset = "0x792370", VA = "0x180792F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NHCLAAFMBOC DGKLHOPKHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x793FA0", Offset = "0x7933A0", VA = "0x180793FA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5F35390", Offset = "0x5F34790", VA = "0x185F35390")]
	public void AAJLDPDELNM(VRIK LAOIAIABPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5F36B20", Offset = "0x5F35F20", VA = "0x185F36B20")]
	private void ONBFCDNECPK(Transform GDMGHBDKKDG, KBMGHHOFLKE GOOANMNBGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5F36410", Offset = "0x5F35810", VA = "0x185F36410")]
	public KBMGHHOFLKE HPOJNKKOCDD(string DHJJHDMHDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5F36670", Offset = "0x5F35A70", VA = "0x185F36670")]
	public void OFKIHPODDEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5F36480", Offset = "0x5F35880", VA = "0x185F36480")]
	public float IONNLOKCELB([In] (KBMGHHOFLKE Start, KBMGHHOFLKE End) KPINBEPGOHL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5F36270", Offset = "0x5F35670", VA = "0x185F36270")]
	public void ENEANKHBOGB([In] MIHMENGHHFD ADCHACEKJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5F36550", Offset = "0x5F35950", VA = "0x185F36550")]
	private Vector3 KNIOIENIDOC([In] (KBMGHHOFLKE Start, KBMGHHOFLKE End) KPINBEPGOHL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5F36BB0", Offset = "0x5F35FB0", VA = "0x185F36BB0")]
	public PHIPNJBGAKG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F331C0", Offset = "0x5F325C0", VA = "0x185F331C0")]
		public string DEDDDAJGAHG(string NFNMKGMMECO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F33210", Offset = "0x5F32610", VA = "0x185F33210")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ENCEPGEKGNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public string MELEEIKDKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool FNLAKOJFCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public bool NPPKMOHALMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float GNKMBDAIIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float BIJJLPGEEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool EJHDPBHLAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Func<OELDENOELAE> NIBCFIBMKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Func<MIHMENGHHFD> DMNAOAMDIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public RigidbodyEx KHIMMOMFOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public RigidbodyEx OIGOOEDIGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public RigidbodyEx MMFCKBCBCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public RigidbodyEx EEEAMMJKDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Transform KGCDDJENKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Transform NKEJGPOIGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public Transform IMKDHBDKGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public PlayerAvatarFullBodyColliders EGOJCFKOGGC;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct JGDBDJFCKME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Transform AJFKCDCBGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform ADAEOENHBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public AvatarConfiguration PICFCNMBOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Animator JICEBAHBFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public VRIK GBEPNKNENFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public GameObject[] IKHKJMKFHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform ECDNHFGGEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public AssetReference CCEEKLOCJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public GameObject LHJODNDDNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public GameObject DMHJFCHNEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer EEGIHCMPMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Material BMDIJHCPDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Material EDHJMHLOAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Material DDEOBJHNDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Shader MEAGNDMMALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Shader LJIANGMNFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Transform MIDMDJIDOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Transform AFKJNGEINOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform NADKOIIOBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform EEENAJPLBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform KCPLKMADBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Transform LBMOGKHPDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Transform LNCGKGBCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Renderer[] KDFIJEBDKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Transform BOBFPIAAPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Transform LEBDLPMOMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public GameObject GJGEKGPFIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public GameObject KAPGMOCCCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public HIELNJLEHFL LCINIOKEJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public HIELNJLEHFL NDLFNBBBDGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public HIELNJLEHFL CEBGJMFMLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public HIELNJLEHFL PFHHLPIGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public HIELNJLEHFL CALCGILMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public HIELNJLEHFL LBDFLLAFIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public HIELNJLEHFL FGNPPJLACEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public HIELNJLEHFL HDMPALMOAEF;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OELDENOELAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool POHDBOLNAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ELKPCEJHCMJ JOADPNDIFHP;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct MIHMENGHHFD
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class GHMIPHILDAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly bool FHLOKDONAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly bool FBNCBCIENMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly bool MFJBPICLEFI;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F332C0", Offset = "0x5F326C0", VA = "0x185F332C0")]
		public GHMIPHILDAG(bool LCFPNNMCLKJ, bool EOKGHGDDNFB, bool DDDOPNDDHHN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float PFLACNDJPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool DEBOEGJJFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public float KPLMELFKOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3 JKGLCLFKEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 FNPHNOCKJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Vector3? KINBDNNALJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Vector3? DCLOPEMIGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public bool CABAAENIPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool DNCKLMOKILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public bool HFNHBINPCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public bool MFLLMIFBNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Vector3? MKFDHFPECKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool CNGNHDIFNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Vector3? LLONJAPFDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool FHJKAAGILHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Vector3? FPPOGJHBMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public float DDFBIDDBAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3? LBCFBAAIAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public bool BMPNPOKPPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public bool LDAJPEEOFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool ELNEILDJFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool LBHEGMNDEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool NLJLLIOHAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool FGAPNANDNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool CJHAHLJAHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool HHODIMOCDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool HIEJKOPCKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool GIMMHOLGKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public bool PIHKOLOLHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3? HCOPLIHLBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public BMGLMCGNIFD AECIHDADNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public BMGLMCGNIFD NGIFPFJPFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public float FANDCIABHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public float PCCAONPGJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public GHMIPHILDAG JHPMIMMEHLL;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5F33D40", Offset = "0x5F33140", VA = "0x185F33D40")]
	public void JEKFFFFAKCP(Quaternion GIJALKLADPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JEJJMOEFJNB
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F33330", Offset = "0x5F32730", VA = "0x185F33330")]
	public static EGFGHFHFMGF EHDABHFBCKI(this FMGALIDCOMN LHCHBOKBAPK)
	{
		return default(EGFGHFHFMGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F33310", Offset = "0x5F32710", VA = "0x185F33310")]
	public static void CGIMDLAILNG(this FMGALIDCOMN LHCHBOKBAPK, EGFGHFHFMGF PAHKKNONPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HIELNJLEHFL
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float IILLPFGJNOB);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private HLEPNMFDPCA GPBDHEIPCNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private Collider[] JPNBKHLBOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] DFEOLIIHNKH;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> NKLMPECFNPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5F37A70", Offset = "0x5F36E70", VA = "0x185F37A70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private HLEPNMFDPCA LPIABFFHCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5F37090", Offset = "0x5F36490", VA = "0x185F37090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool GHEJECMPFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCBB010", Offset = "0xCBA410", VA = "0x180CBB010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F37A50", Offset = "0x5F36E50", VA = "0x185F37A50")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer HIMHMMHAAPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5F37800", Offset = "0x5F36C00", VA = "0x185F37800")]
		public void SetCollidersEnabled(bool MKECFCAPOLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5F373D0", Offset = "0x5F367D0", VA = "0x185F373D0")]
		public void ReparentBonesUnderOtherBoneCollection(HLEPNMFDPCA NJGIBBPCNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5F37130", Offset = "0x5F36530", VA = "0x185F37130")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MOEIDCJJCMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Transform PBCOHOABHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Transform JFIBKPBHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Transform IAIPNIGKAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Transform ILFKGNEFGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform DCHBLGEGFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform ECFGEJJMFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform ADFMFEHFOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Transform KHAEGMABLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Transform CNIPNCBKGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PositionAndRotation CHEPMJLIDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation EJLKLBAIIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private PositionAndRotation DNMACACGCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PositionAndRotation BFALLHFICNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private PositionAndRotation JCDLEDDECOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private PositionAndRotation OELHFNLNPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private PositionAndRotation NHPDDBINPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PositionAndRotation DKMLNFAMIKF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5F343B0", Offset = "0x5F337B0", VA = "0x185F343B0")]
	public void FILODNFGCKM(Transform ANONFFHJOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F34A70", Offset = "0x5F33E70", VA = "0x185F34A70")]
	public void GCLJDFGHJGA(HandLogicOffsets LPPEDAANPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F34160", Offset = "0x5F33560", VA = "0x185F34160")]
	public void ANCPBCLAFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5F352C0", Offset = "0x5F346C0", VA = "0x185F352C0")]
	private PositionAndRotation OPPGLDJFJAI(Transform MOENMPPLBCL, Transform JPKNACNKDLC)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F34FF0", Offset = "0x5F343F0", VA = "0x185F34FF0")]
	private void KHOGOINLDHK(Transform MOENMPPLBCL, Transform JPKNACNKDLC, PositionAndRotation LPPEDAANPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public MOEIDCJJCMN()
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
