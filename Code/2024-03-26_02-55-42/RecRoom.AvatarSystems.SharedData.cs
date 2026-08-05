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
public enum AEGBGJIFPJF
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
public struct BLCBLMKJMOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator FCHNHOBOHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public FFDOGLADKEA KJEJGJOPCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration JDHEBCKKDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject ILLMEAKHEDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LDHNOFPMHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform CLGENEFNCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool AOHMFBEHPBO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FOHOLHHIPKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public AEGBGJIFPJF? HAGBKFMLOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AEGBGJIFPJF? OBPPEDOHDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? PMDGHBDEHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? IIMPACKEMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? PELMAMHPHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? OCFHMKOLFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? OEBMKFFEFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? BKIIHLEHKFN;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum FFDOGLADKEA
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum GOJIENDOBAH
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
public static class JKIPMFBLDBA
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly string ANGCCCHFNIH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60C3D10", Offset = "0x60C3110", VA = "0x1860C3D10")]
	public static AJFHEJOPLKI GFEDCOIIGDG()
	{
		return default(AJFHEJOPLKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60C3720", Offset = "0x60C2B20", VA = "0x1860C3720")]
	public static FDDPEIOFHBK CNJGLFIOFLO(Transform HHFOBPJAPDP, Transform DNHFOPLGFPO, AvatarConfiguration CHFFAPAOEHP, Animator AOOCIGPALLD, VRIK CONFIJIBEMD, GameObject[] NALJGLEMAMH, Transform DKIKCLOIOAO, AssetReference DDGEBMEGAHH, GameObject OJBHHJBEJGD, GameObject CIBHJFEDCGN, SkinnedMeshRenderer HKBLBNFLICD, Material EKFNCLMLGEI, Material AFLHEMGFDJG, Material DHAKDOHNBPA, Shader EINFMAKDHLG, Shader EJEIJPFALDA, Transform FAAOJEHMMIA, Transform PFJNNMODIHE, Transform IDKDGKALAEH, Transform NAGFNFMMDKB, Transform CEHIAJCHJOP, Transform OBFDIDCJPND, Transform DFGEBHMMGPJ, Renderer[] AHIPCCOFLOJ, FOGFBFGDCAI FHAFGHBMCHM, FOGFBFGDCAI EHOJIHMBBPM, FOGFBFGDCAI FNLJKFKAOIF, FOGFBFGDCAI FFFBGJCIHOK, FOGFBFGDCAI CNAEDMOGCBJ, FOGFBFGDCAI HPJGBBAHGDG, FOGFBFGDCAI MNNDLFNEBNC, FOGFBFGDCAI NJCHFDEMKMI, Transform NJLNNBANMFO, Transform DCOOGDABFNP, GameObject HNHAEGNAFAJ, GameObject AIBFPPOHDAH)
	{
		return default(FDDPEIOFHBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60C3B70", Offset = "0x60C2F70", VA = "0x1860C3B70")]
	public static AKIMPNKGBCA GECCDALPBOK(string GLPLGCKGFNC, bool DNNBHELKACC, bool NJIIELAOAKH, bool KMOBHAOKLGA, Func<NDFCENBMKOB> HHAMOLDEDLB, Func<Vector3, AJFHEJOPLKI> IDGFDCNPNHH, RigidbodyEx LEKCPBCNCJF, RigidbodyEx BDKCHMCKKIK, RigidbodyEx DAJDEJGBFLK, RigidbodyEx GPGDBNLOEDI, Transform DAKDCPMHGOC, Transform KKBMCMJKHCM, Transform CAFPOCHOLNG, float LIFOONNFPHJ, float EMKKGKAFNAH, PlayerAvatarFullBodyColliders NLDIECDBBHO, SkinnedMeshRenderer[] IOEBIHGHGHD, SkinnedMeshRenderer[] PCDMBJPFLMD, SkinnedMeshRenderer[] ACFHGEOCOBF, SkinnedMeshRenderer[] MPFBOFEENCP)
	{
		return default(AKIMPNKGBCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60C35F0", Offset = "0x60C29F0", VA = "0x1860C35F0")]
	public static GJCIIIBLPMJ ANCECMKLEJB(Transform DNHFOPLGFPO, AssetReference DDGEBMEGAHH, GameObject OJBHHJBEJGD, GameObject CIBHJFEDCGN, SkinnedMeshRenderer HKBLBNFLICD, Material EKFNCLMLGEI, Material AFLHEMGFDJG, Material DHAKDOHNBPA, Shader IKNHMFFIPNA, Shader GDBJBILIFIM, Animator BOEMECJPLGO, Renderer[] AHIPCCOFLOJ, AvatarConfiguration LKLLCNIIBLE)
	{
		return default(GJCIIIBLPMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60C3FD0", Offset = "0x60C33D0", VA = "0x1860C3FD0")]
	public static KLAOJMPJBAB MCJIHNFADDC(SkinnedMeshRenderer[] IOEBIHGHGHD, SkinnedMeshRenderer[] PCDMBJPFLMD, SkinnedMeshRenderer[] ACFHGEOCOBF, SkinnedMeshRenderer[] MPFBOFEENCP)
	{
		return default(KLAOJMPJBAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60C3D50", Offset = "0x60C3150", VA = "0x1860C3D50")]
	public static BGELMENIIJL HEHFAMMELEP(Transform FAAOJEHMMIA, Transform IDKDGKALAEH, Transform PFJNNMODIHE, Transform NAGFNFMMDKB, Transform CEHIAJCHJOP, Transform OBFDIDCJPND, Transform DFGEBHMMGPJ, AvatarConfiguration CHFFAPAOEHP)
	{
		return default(BGELMENIIJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x14D6630", Offset = "0x14D5A30", VA = "0x1814D6630")]
	public static CEOLBDMCLHA FILECCJPGPN(SkinnedMeshRenderer[] EOCBDDNEAJK)
	{
		return default(CEOLBDMCLHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60C3F20", Offset = "0x60C3320", VA = "0x1860C3F20")]
	public static NAEMCPBJBOH KNDKIGPCBIO(MLEMJNNGJJC BNPNGHKNHGK, int EIIAKBNKGAG, int OHMFFMIMLFA, Color LMNGKFEHIIA, Color JEFJBCLCIJE, int NGFNIOKHCCL, int MMLCLAFFKLK, Color JHBGIIHHOFM, Color FAHOECPFKDJ, int KNIHBLLJNLH, float CHGEOMDEKLO)
	{
		return default(NAEMCPBJBOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60C3AC0", Offset = "0x60C2EC0", VA = "0x1860C3AC0")]
	public static IGJDCNEEDAF EKILCBKIFHE(MLEMJNNGJJC BNPNGHKNHGK, Vector2 LPGKFKIDGBO, float JOFNKHPADPK, Vector2 PHNBKCEHCGO, float BLFBKGCCJPH, Vector2 MKIHEEIINBI, float DIMNHKCCOHI, Vector2 PJHKBBNLOKD, float PJHNAOIPOCB)
	{
		return default(IGJDCNEEDAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60C3EB0", Offset = "0x60C32B0", VA = "0x1860C3EB0")]
	public static BLCBLMKJMOC KDIKAEODGJD(Animator PNJBDOKPHID, FFDOGLADKEA ODBDOBPPJKP, AvatarConfiguration LKLLCNIIBLE, GameObject LBKKHKAAPMJ)
	{
		return default(BLCBLMKJMOC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60C3E20", Offset = "0x60C3220", VA = "0x1860C3E20")]
	public static LDHNOFPMHHH INGAALGMGOE(Transform LBOMBILKHAF, bool NJIIELAOAKH)
	{
		return default(LDHNOFPMHHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60C3E60", Offset = "0x60C3260", VA = "0x1860C3E60")]
	public static FOHOLHHIPKF JABEKADEMNI([Optional] AEGBGJIFPJF? IOCBLJLENFN, [Optional] int? LAGMAOEGDHO, [Optional] float? FKNPJPCJECA, [Optional] float? CAKBOOFKBNA, [Optional] bool? JKPDEFPDIGP, [Optional] bool? HPOKBJPFOKN, [Optional] bool? LGLFENBEJGM, [Optional] AEGBGJIFPJF? HMHCBPABNEB)
	{
		return default(FOHOLHHIPKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class ABHFEFHECEB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60BFDD0", Offset = "0x60BF1D0", VA = "0x1860BFDD0")]
	public static AEGBGJIFPJF GAPHKLJMHCB(this GOJIENDOBAH ONDHHGPPLNJ)
	{
		return default(AEGBGJIFPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60BFE20", Offset = "0x60BF220", VA = "0x1860BFE20")]
	public static bool PLPPJBJPHFP(this GOJIENDOBAH JCHHMCFCAKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FAOBHHPCICP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ANCEMBOPFPL : FAOBHHPCICP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform DHEPKMFHJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 KKHAOHDCGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD5C220", Offset = "0xD5B620", VA = "0x180D5C220", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD5C200", Offset = "0xD5B600", VA = "0x180D5C200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? EAKPEIFKHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD5C1F0", Offset = "0xD5B5F0", VA = "0x180D5C1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD5C210", Offset = "0xD5B610", VA = "0x180D5C210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public ANCEMBOPFPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IJGIODMEGPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly ANCEMBOPFPL EKEBKLEMOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly ANCEMBOPFPL CGLIACBGBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly ANCEMBOPFPL FPIKLKBOAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly ANCEMBOPFPL FFHGEPPMLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected readonly ANCEMBOPFPL BJGMHCNMFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly ANCEMBOPFPL CFFEMBGDAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly ANCEMBOPFPL ECNOHNINLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly ANCEMBOPFPL HHDKHENMJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected readonly ANCEMBOPFPL MKMCENOABOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly ANCEMBOPFPL INBJJJOKEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly ANCEMBOPFPL PLDDNKBBCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly ANCEMBOPFPL PLFPGMJMFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected readonly ANCEMBOPFPL GBBPDDKDBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected ANCEMBOPFPL HKJIEEALOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly ANCEMBOPFPL GOONCMPANKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly ANCEMBOPFPL OGMGLCKLBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly ANCEMBOPFPL CMIGJEEOAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected ANCEMBOPFPL DJGKLGIEOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly ANCEMBOPFPL LOACEMOGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly ANCEMBOPFPL OELNBBMIJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly ANCEMBOPFPL FJJFOOPGGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected ReadOnlyCollection<ANCEMBOPFPL> MBPBCAFIKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform DKIKCLOIOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private (ANCEMBOPFPL Start, ANCEMBOPFPL End)[] HBIKEBJEODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, ANCEMBOPFPL> INLHPMOIGOP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FAOBHHPCICP MOIJOBFOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FAOBHHPCICP MFCMBKONMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FAOBHHPCICP GHINJENEJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FAOBHHPCICP JHBNHBKANMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FAOBHHPCICP MCOODNCNEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FAOBHHPCICP JCDHOLNPPAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FAOBHHPCICP LKFCDLFGLBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FAOBHHPCICP LEEIFEOPJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FAOBHHPCICP KMFDCIABECD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC0", Offset = "0x7C30C0", VA = "0x1807C3CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60C1EA0", Offset = "0x60C12A0", VA = "0x1860C1EA0")]
	public void FJPGOHINGLA(VRIK DOJHPIBGBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60C1A00", Offset = "0x60C0E00", VA = "0x1860C1A00")]
	private void CLIKCAHPKLB(Transform CNGBAHCAJJB, ANCEMBOPFPL NDIKGOAJKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60C2D80", Offset = "0x60C2180", VA = "0x1860C2D80")]
	public ANCEMBOPFPL FLJDENLDAGH(string BCOKIFAHHDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60C1A90", Offset = "0x60C0E90", VA = "0x1860C1A90")]
	public void DICDCIKEKIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60C2DF0", Offset = "0x60C21F0", VA = "0x1860C2DF0")]
	public float GDKEGFKHPFF([In] (ANCEMBOPFPL Start, ANCEMBOPFPL End) OEHGLBLNBGG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60C2F60", Offset = "0x60C2360", VA = "0x1860C2F60")]
	public void OMHBPFHILKJ([In] AJFHEJOPLKI KDDFGNJPJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60C2E30", Offset = "0x60C2230", VA = "0x1860C2E30")]
	private Vector3 NPIOJLKPPGO([In] (ANCEMBOPFPL Start, ANCEMBOPFPL End) OEHGLBLNBGG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60C3110", Offset = "0x60C2510", VA = "0x1860C3110")]
	public IJGIODMEGPP()
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
		[Cpp2IlInjected.Address(RVA = "0x60C03E0", Offset = "0x60BF7E0", VA = "0x1860C03E0")]
		public string KPEIOGIHPDC(string BAHJDNGJMJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60C0430", Offset = "0x60BF830", VA = "0x1860C0430")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AKIMPNKGBCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string IOENNEPHJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool AOHMFBEHPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool JNMFMIAEOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float HNBFJCIJKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float CJADEJOAFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool ODAEOMPJLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public Func<NDFCENBMKOB> NIHPBANOAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Func<Vector3, AJFHEJOPLKI> LHNFCOPCDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public RigidbodyEx FCLLKBLICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public RigidbodyEx ILHFBPAINPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public RigidbodyEx BFDHLEPKHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public RigidbodyEx OKGLPLECCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Transform FOFKABIKDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform MLKJFLPCNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Transform PNFLAFLABON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PlayerAvatarFullBodyColliders MJHDGIHNMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public SkinnedMeshRenderer[] AGLMMMEDFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer[] GHGCPIEEKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public SkinnedMeshRenderer[] BDIKKKCCIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public SkinnedMeshRenderer[] HHCJLMCHGCB;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60C0250", Offset = "0x60BF650", VA = "0x1860C0250")]
	public AJFHEJOPLKI LGBHNLLEBEG(Vector3 CAMFAFCPANE)
	{
		return default(AJFHEJOPLKI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FDDPEIOFHBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Transform LJDFJMGHCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Transform IAHHJDPCIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public AvatarConfiguration JDHEBCKKDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Animator EDMOLEAPOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public VRIK NEFENGDCAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GameObject[] ILGDHFJIAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform EODCOIEAAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AssetReference PNMBFNJEENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public GameObject LEACDJPFLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public GameObject BPBMLBAFKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer ONKDFBFINBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Material PKLIBPODCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Material OOJJDODDPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Material CGCAFPFGEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Shader HHJNLEDEMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Shader CDGAHJGKBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform FILCIIJEPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform JBBJADEMNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform KDJOLMDIIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform POABADNLOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform MLAHAPKIGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform COGNCADEDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform AHBHFLPECLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Renderer[] AFFEKCDAMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform DDEAIHPNECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform BIKDFMIEHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public GameObject JLMGBPLPDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GameObject NCNFKNNHAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public FOGFBFGDCAI OAOJKCLJKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public FOGFBFGDCAI NBPMELJGHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public FOGFBFGDCAI IIBMKBPGKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public FOGFBFGDCAI ICBMNGKFCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public FOGFBFGDCAI GJBCNKFJJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public FOGFBFGDCAI IIFJGODONME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public FOGFBFGDCAI LJPFEBPAJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public FOGFBFGDCAI NOKNKAJBNKD;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct NDFCENBMKOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public bool NKNODPEFPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NBPFHEAGOPH NIFMEJPLKBC;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct AJFHEJOPLKI
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class EENDFOJEMAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly bool HJLLNFBBBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly bool PNLJDDANIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly bool EPODHKBKPFA;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60C0480", Offset = "0x60BF880", VA = "0x1860C0480")]
		public EENDFOJEMAD(bool ONCFJKHDAOP, bool LEEKLPIFCAJ, bool GLOGFABBPFB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float GOPPJEEMOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool FGJBCGJEPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float IOBPAEJBJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Vector3 AJHOCDKGLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3 BNAIEHFDEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Vector3? MPDFCABMBOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Vector3? ANINBOGIMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool GEOBAGDPPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool KFIAHJHFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool AGFMGKJBHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool JNIILONBIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3? DFMPDIDLGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool GKFLJBMFFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? APFLLGLGADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool LBEKOPBCEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Vector3? HBCKPHGIGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public float MJHEOPNBNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3? NBFJHGCINJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool GKEKAPPHMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool PAOECKEJPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool LBMLJEEJBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool GGALMBCHMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool IINEGMAHLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool HKHBNEHFGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool LICFILPPKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool AHPLFGNGOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool OBIJAHFICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool FIJFPDEFIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool GJBBDKMADDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? FMACKIKLJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public GOJIENDOBAH GFDNLBILNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public GOJIENDOBAH BBGINDFMABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool LEOIMCJLCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool JPMIEKHMMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public EENDFOJEMAD EDMDOPNFCFM;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60BFE30", Offset = "0x60BF230", VA = "0x1860BFE30")]
	public void COELPLHCLGK(Quaternion APMJJPLCLEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FPKHMOFIIIF
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60C04F0", Offset = "0x60BF8F0", VA = "0x1860C04F0")]
	public static OFLPBPHBOAO IEGMDKDLBJD(this FLKFBOJHJOA MEEBIDIALDO)
	{
		return default(OFLPBPHBOAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60C04D0", Offset = "0x60BF8D0", VA = "0x1860C04D0")]
	public static void HPKKLILLNNE(this FLKFBOJHJOA MEEBIDIALDO, OFLPBPHBOAO PCGOHCLJAPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface FOGFBFGDCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float MEOLIKAEACM);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private OKFIIEJOALB IPMICBOHENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Collider[] DLGNAGOLDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] NLJAKFLONNA;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> EHNJLNNAIFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x60C4AA0", Offset = "0x60C3EA0", VA = "0x1860C4AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private OKFIIEJOALB DBCGDCJGJNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x60C40C0", Offset = "0x60C34C0", VA = "0x1860C40C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KBKJHKMEBHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD4D640", Offset = "0xD4CA40", VA = "0x180D4D640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60C4A80", Offset = "0x60C3E80", VA = "0x1860C4A80")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer LFHFBODMCIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60C4830", Offset = "0x60C3C30", VA = "0x1860C4830")]
		public void SetCollidersEnabled(bool IAGGBJHFOBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60C4400", Offset = "0x60C3800", VA = "0x1860C4400")]
		public void ReparentBonesUnderOtherBoneCollection(OKFIIEJOALB HDAGMAFJIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60C4160", Offset = "0x60C3560", VA = "0x1860C4160")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HIJMLGJKFJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Transform FHCLNDHPALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform OCMJELOBDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Transform BCLLEMFKEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform DEJDOKLBEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Transform IGPAEDDIMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Transform FGPDALAGNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Transform JOLCCOPEAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Transform NGNABHNPLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Transform LINJAACGPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation GOKHMMBAOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PositionAndRotation AMCENPLHNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private PositionAndRotation JEFEMLNFBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private PositionAndRotation JKEHDJDELGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private PositionAndRotation PIEDGDFPJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PositionAndRotation CEBNMBELAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private PositionAndRotation FMNKCBGOLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PositionAndRotation OCCDCOIHDDA;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60C0760", Offset = "0x60BFB60", VA = "0x1860C0760")]
	public void EOPEJCOCBHD(Transform PMMPCEKFBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60C11C0", Offset = "0x60C05C0", VA = "0x1860C11C0")]
	public void HBAEBMLKKBI(HandLogicOffsets EPAOMKDDFEH, FFDOGLADKEA BGOMPHFKLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60C0510", Offset = "0x60BF910", VA = "0x1860C0510")]
	public void BONAJMPLFMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60C0E20", Offset = "0x60C0220", VA = "0x1860C0E20")]
	private PositionAndRotation FPDGBLCKNGD(Transform GNCGNGPDMPF, Transform OLPHDEFPECP)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60C0EF0", Offset = "0x60C02F0", VA = "0x1860C0EF0")]
	private void GGCIOMIJIOC(Transform GNCGNGPDMPF, Transform OLPHDEFPECP, PositionAndRotation HAJFHDAGLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public HIJMLGJKFJC()
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
