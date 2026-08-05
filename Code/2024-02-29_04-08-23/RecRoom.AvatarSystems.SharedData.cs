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
public enum MPOBHJGDLAC
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
public struct ONCMABEJCBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator CIKNKPNIMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public DKEGCHDAJPG KCCNHAPBCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration OJJJEAAKHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject JBOCBGAHGCO;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GFMCPOLOLKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform AJKDHOIJICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool PIAKIJIELBO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NAEFEJHAAAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public MPOBHJGDLAC? DMOEAJHJBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public MPOBHJGDLAC? JBIJANDIAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? IMLLIKPHHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? LHPOKKLNPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? LODAJFCJLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? OJGGLDMHOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? DFDBFNDIBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? AHHECHIECCI;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DKEGCHDAJPG
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum HIAHHEOBBNO
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
public static class PKIFLGDJHLK
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly string LFJFPHLGJDI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F01590", Offset = "0x5F00390", VA = "0x185F01590")]
	public static ELBGEHEHOCD HHGHFCNHBGM()
	{
		return default(ELBGEHEHOCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F01650", Offset = "0x5F00450", VA = "0x185F01650")]
	public static IIIHJOCEJDL JOJCLMHNDDM(Transform MAAHMMDDMHI, Transform IPFGDIHMCEL, AvatarConfiguration LKCLDCILMGD, Animator KJHNPIEHAHP, VRIK MGPEIBLNNNP, GameObject[] LKIPEEKONMI, Transform MLGHJJIKEKB, AssetReference FMPIJLCGJJC, GameObject DPCELEPADJP, GameObject CGAEEBJFPFI, SkinnedMeshRenderer LCPIOONHPCG, Material GBMFNKLCMKJ, Material IICDEKCCJNJ, Material JBDJHPCNDKO, Shader BJPLAIPHBBO, Shader BIACINAEBHC, Transform BNKPMNNCHPL, Transform AINGCOLJCAG, Transform JNBJOPJHHCJ, Transform DNKBAAHDPDP, Transform IIPMKBCJIAE, Transform GOMELPDLHPG, Transform DOLLGFGBJFN, Renderer[] PGKECBOHNMP, EEEGEKGFIKO OOJHFDHMFDA, EEEGEKGFIKO OFJKJGAJJIK, EEEGEKGFIKO PLKKMFECMEK, EEEGEKGFIKO KMAJDDIEIFD, EEEGEKGFIKO JIAIOKDEBHM, EEEGEKGFIKO IEKGNEHNEOD, EEEGEKGFIKO OFHEACGNMNK, EEEGEKGFIKO GBKFJKMNMBP, Transform HLECGIILHAC, Transform DFBFCBLIACI, GameObject GNEINGKDBIK, GameObject MLBKBKGCBPO)
	{
		return default(IIIHJOCEJDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F01380", Offset = "0x5F00180", VA = "0x185F01380")]
	public static AGNPDFIPELD EIHPJOFKDLI(string KEPHOEOFBDG, bool OHDGMFGLIGG, bool JNJIBDKDLDF, bool JPCDNPBNLFF, Func<OELKAFHNDMO> MDIPNELOKJM, Func<Vector3, ELBGEHEHOCD> IFDJCAKPGKF, RigidbodyEx MDNCKPOMDDL, RigidbodyEx LAABFBKINLF, RigidbodyEx FDJEDNMLHCG, RigidbodyEx KKLGOBJJLFN, Transform HNLCIJKEPIE, Transform DIPENPAHNOE, Transform JNKMIKLEOGN, float BEKGMFEBCDJ, float KCBBIPAAACE, PlayerAvatarFullBodyColliders FHGDHLBIJBH, SkinnedMeshRenderer[] BJFDPAKBPKC, SkinnedMeshRenderer[] GDNOJOBIMJF, SkinnedMeshRenderer[] LAPLFILFLPL, SkinnedMeshRenderer[] KMJNEKDFFDA)
	{
		return default(AGNPDFIPELD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F01AE0", Offset = "0x5F008E0", VA = "0x185F01AE0")]
	public static MHDODINPDHG MAJANMCNNLM(Transform IPFGDIHMCEL, AssetReference FMPIJLCGJJC, GameObject DPCELEPADJP, GameObject CGAEEBJFPFI, SkinnedMeshRenderer LCPIOONHPCG, Material GBMFNKLCMKJ, Material IICDEKCCJNJ, Material JBDJHPCNDKO, Shader CABKNHCCKNN, Shader DBCLGLDINDH, Animator JPNBLPIKLNB, Renderer[] PGKECBOHNMP, AvatarConfiguration CEJPGNGJHAJ)
	{
		return default(MHDODINPDHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F015D0", Offset = "0x5F003D0", VA = "0x185F015D0")]
	public static GLCMJJEMCFG JDHNKLLEFAM(SkinnedMeshRenderer[] BJFDPAKBPKC, SkinnedMeshRenderer[] GDNOJOBIMJF, SkinnedMeshRenderer[] LAPLFILFLPL, SkinnedMeshRenderer[] KMJNEKDFFDA)
	{
		return default(GLCMJJEMCFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F01CC0", Offset = "0x5F00AC0", VA = "0x185F01CC0")]
	public static MGKKIECBKCE OFHANJABNHP(Transform BNKPMNNCHPL, Transform JNBJOPJHHCJ, Transform AINGCOLJCAG, Transform DNKBAAHDPDP, Transform IIPMKBCJIAE, Transform GOMELPDLHPG, Transform DOLLGFGBJFN, AvatarConfiguration LKCLDCILMGD)
	{
		return default(MGKKIECBKCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x13F5C10", Offset = "0x13F4A10", VA = "0x1813F5C10")]
	public static LNNLFIHCPKF ACBIKBPDONI(SkinnedMeshRenderer[] OLKLLBLJAIL)
	{
		return default(LNNLFIHCPKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5F01A30", Offset = "0x5F00830", VA = "0x185F01A30")]
	public static CMKKCIGIGHF KOFDGNMAGCB(BECKDPKAFAF CHPOCGFFIJH, int IAPCIBOFBHP, int LDNDAJEEIND, Color IBECIIHLDBP, Color OKMMKCFNIPL, int ENFPAIILMMP, int LNPFHNJKAKC, Color OHGPAOLGLDA, Color KFCKMFOBDCA, int BDKLJNNFDNF, float LADMJEDBJAL)
	{
		return default(CMKKCIGIGHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5F01C10", Offset = "0x5F00A10", VA = "0x185F01C10")]
	public static HAEDGCIOGEH MBPOCDOGLFA(BECKDPKAFAF CHPOCGFFIJH, Vector2 BNEFHGLPOHO, float OJPANIAGLNO, Vector2 HHHBHDJGKFC, float OPMACGKIOIC, Vector2 DFOFMOKDBHL, float NNIPMAJLPKP, Vector2 LMFMIJPFOMO, float PNKCLDEMGJG)
	{
		return default(HAEDGCIOGEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5F01520", Offset = "0x5F00320", VA = "0x185F01520")]
	public static ONCMABEJCBE GAPKODNCIBP(Animator GFMJKDNMCJO, DKEGCHDAJPG PEGNHDEFBOI, AvatarConfiguration CEJPGNGJHAJ, GameObject MMPKDPJEJON)
	{
		return default(ONCMABEJCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5F019F0", Offset = "0x5F007F0", VA = "0x185F019F0")]
	public static GFMCPOLOLKF KFPLIGCFABJ(Transform OBJGHONPMJD, bool JNJIBDKDLDF)
	{
		return default(GFMCPOLOLKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5F01330", Offset = "0x5F00130", VA = "0x185F01330")]
	public static NAEFEJHAAAF AACCFPBNGIM([Optional] MPOBHJGDLAC? JFGBEFKNONG, [Optional] int? BLHJCCOOBEJ, [Optional] float? EEFLGLNCNLJ, [Optional] float? IGOFNHFLPCI, [Optional] bool? LBMCEOAGNAP, [Optional] bool? CKJFJDNMDLA, [Optional] bool? FJPLNOKIAJJ, [Optional] MPOBHJGDLAC? NOJNOFNBEKC)
	{
		return default(NAEFEJHAAAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MKBOAKEFIAB
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F012A0", Offset = "0x5F000A0", VA = "0x185F012A0")]
	public static MPOBHJGDLAC DKGGAJFFJCK(this HIAHHEOBBNO OAJJLCOHFIH)
	{
		return default(MPOBHJGDLAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5F01290", Offset = "0x5F00090", VA = "0x185F01290")]
	public static bool AIFOMLNJJBP(this HIAHHEOBBNO OHCMCEAPMIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PAMBOPEDELO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ALBBBEEMAIL : PAMBOPEDELO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform EHAKBGMPING
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LJAMHEBGAGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD00580", Offset = "0xCFF380", VA = "0x180D00580", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD00570", Offset = "0xCFF370", VA = "0x180D00570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? IFNCGDHDANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD005A0", Offset = "0xCFF3A0", VA = "0x180D005A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD00560", Offset = "0xCFF360", VA = "0x180D00560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public ALBBBEEMAIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DOJLGLJGCPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly ALBBBEEMAIL CBHODONEIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly ALBBBEEMAIL PBJFIAGCAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly ALBBBEEMAIL CKLBEODBCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly ALBBBEEMAIL LHLCPOICFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected readonly ALBBBEEMAIL IFFGBAMHHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly ALBBBEEMAIL NMDDLCNOGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly ALBBBEEMAIL NNEFIOGKKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly ALBBBEEMAIL LKMJPOFNGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected readonly ALBBBEEMAIL FOPEBEMELEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly ALBBBEEMAIL ENDKBIEKKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly ALBBBEEMAIL CHGKGHAIBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly ALBBBEEMAIL DHAFJHNFEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected readonly ALBBBEEMAIL JDAMKOGIHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected ALBBBEEMAIL PAKMFNIIPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly ALBBBEEMAIL GCPJOIEHLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly ALBBBEEMAIL FEGIANIBMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly ALBBBEEMAIL BLNFAJCOPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected ALBBBEEMAIL ALAMECJBKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly ALBBBEEMAIL AHKMKLLKAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly ALBBBEEMAIL IIKIPENOAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly ALBBBEEMAIL KJIFHPKBHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected ReadOnlyCollection<ALBBBEEMAIL> HPNMPJJKDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform MLGHJJIKEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private (ALBBBEEMAIL Start, ALBBBEEMAIL End)[] POKKIHJIIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, ALBBBEEMAIL> LOFEKGDFMBB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public PAMBOPEDELO GDHANFLBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PAMBOPEDELO ELFDOPNIBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public PAMBOPEDELO MKOOHGJDHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public PAMBOPEDELO OFBCLDDOIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PAMBOPEDELO LOHAPEPKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PAMBOPEDELO OFLHHGODGGE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public PAMBOPEDELO EAJLDJBKHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PAMBOPEDELO ICJCCFNCNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PAMBOPEDELO FCDNBGKCLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CD0", Offset = "0x7A7AD0", VA = "0x1807A8CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EFDD40", Offset = "0x5EFCB40", VA = "0x185EFDD40")]
	public void BEGBNDOFBLI(VRIK PEMAGOEHHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EFF3C0", Offset = "0x5EFE1C0", VA = "0x185EFF3C0")]
	private void PGAFPCKMAJE(Transform DIIPJIMFFMD, ALBBBEEMAIL KAKJJOAALHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EFF220", Offset = "0x5EFE020", VA = "0x185EFF220")]
	public ALBBBEEMAIL EIEPMCAICAK(string MEBOOKFANFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EFEE10", Offset = "0x5EFDC10", VA = "0x185EFEE10")]
	public void DGMBEKBFNNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EFEDD0", Offset = "0x5EFDBD0", VA = "0x185EFEDD0")]
	public float BKPOBDLLGGI([In] (ALBBBEEMAIL Start, ALBBBEEMAIL End) PEDBKLIBFED)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EFEC20", Offset = "0x5EFDA20", VA = "0x185EFEC20")]
	public void BFGEDNHIDAF([In] ELBGEHEHOCD DCBJOKKHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EFF290", Offset = "0x5EFE090", VA = "0x185EFF290")]
	private Vector3 IEGCCBGFAGN([In] (ALBBBEEMAIL Start, ALBBBEEMAIL End) PEDBKLIBFED)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EFF450", Offset = "0x5EFE250", VA = "0x185EFF450")]
	public DOJLGLJGCPP()
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
		[Cpp2IlInjected.Address(RVA = "0x5EFDCA0", Offset = "0x5EFCAA0", VA = "0x185EFDCA0")]
		public string HHJHJKFEOLM(string FEIJAECMHKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5EFDCF0", Offset = "0x5EFCAF0", VA = "0x185EFDCF0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct AGNPDFIPELD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string OFPEIEOHDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool PIAKIJIELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool EMBOHFCIGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float FIDMEKJHDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float LMNHHOFBLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool BAENCIPCPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public Func<OELKAFHNDMO> FJPNKBHJKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Func<Vector3, ELBGEHEHOCD> HEFLMGFCIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public RigidbodyEx MCLPPBPCBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public RigidbodyEx AKOHLCJKCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public RigidbodyEx HJEKBFJLDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public RigidbodyEx CDLANBFCOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Transform JJGODOBBLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform ODAEMMDPNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Transform OLCFJCKFPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PlayerAvatarFullBodyColliders COGAGEKLCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public SkinnedMeshRenderer[] AGFJEEEIFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer[] DKNKMNMLKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public SkinnedMeshRenderer[] MAGLFMBJJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public SkinnedMeshRenderer[] IAFFBAJGEGL;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EFDB10", Offset = "0x5EFC910", VA = "0x185EFDB10")]
	public ELBGEHEHOCD OCEEOMEPOOF(Vector3 BFODCGKOLEO)
	{
		return default(ELBGEHEHOCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IIIHJOCEJDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Transform OAGNIGMKJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Transform FDJKDMLLFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public AvatarConfiguration OJJJEAAKHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Animator PCNGCOHCKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public VRIK OOADCNLOFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GameObject[] JPNEKJNOMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform AIEGPJPENOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AssetReference HGBJMFHEDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public GameObject LFHHDMNLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public GameObject GDDDMIAEJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer OBANJENIIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Material HIGOIMGBJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Material FADJEJLPPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Material DOHDGEFIDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Shader CNJEBIPAANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Shader PPHHGOGPFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform BLFJLGAOMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform COOBGLCBJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform MJEMANNPJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform AGFLLENNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform MOKABIJBBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform CBPIDGHBMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform MDCACNKBINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Renderer[] BFDAOIJLHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform OOHKOJEJGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform CLNGMCDPILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public GameObject HOGKLCBIPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GameObject FCBOHBLOHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public EEEGEKGFIKO GAMNNDBLAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public EEEGEKGFIKO PLFNCKJLJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public EEEGEKGFIKO GCBMDAMLKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public EEEGEKGFIKO NNNGPDKABCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public EEEGEKGFIKO EAIPFMKBKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public EEEGEKGFIKO FHJGNNJDBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public EEEGEKGFIKO JHMOOELKMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public EEEGEKGFIKO FGPABKLNHBC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct OELKAFHNDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public bool CLJCIMMHFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public AMOHOHNPBGH GIOGGOPBEGA;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ELBGEHEHOCD
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class KGNOAAJAIHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly bool EPNFHHCPAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly bool MFOEKKGIBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly bool ADFLBDFNDLK;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F01240", Offset = "0x5F00040", VA = "0x185F01240")]
		public KGNOAAJAIHE(bool OJOOGFOOJGH, bool ILPMHNKIONI, bool FLILNGEEELJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float LKIPGOJHJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool PDEEBAHLEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float HHEDJCPPHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Vector3 NJOBCPNBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3 IHJNCCOEHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Vector3? OICMNHLCIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Vector3? CAJNGBBECIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool LFELBFBHJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool NADGDBIDCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool BDAOIGNHDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool IALJEJNHGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3? DEHKNILNMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool CGOOFOGLKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? BAFBJHLHKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool ACMIBBMBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Vector3? LLOFIAMHGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public float HBJKINPAAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3? HFDJGKLCAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool BJOLLCPBEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool LANPLOGKAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool KDLNFEPBEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool CNKPMAJBBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool LBFNNMJIBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool MMCHMKBMNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool HHNGHKHCPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool CDAKLAPGPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool KKBEGJEGMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool ENBODPIGLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool JPMANEGIIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? MEPMGMMBLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public HIAHHEOBBNO NGGGKONKLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public HIAHHEOBBNO OLFDLDFBPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool DCDPCLCMNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool MHPPDINMPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public KGNOAAJAIHE IAFAAAEANEF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5F00E20", Offset = "0x5EFFC20", VA = "0x185F00E20")]
	public void MOJDBFDKLAL(Quaternion GJMDICOFEBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NOLFFFJHOCN
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5F01310", Offset = "0x5F00110", VA = "0x185F01310")]
	public static AELIAAKPGEF ONHMAGNGGOK(this IJBCNFLNIKE CNFBJPGPBBJ)
	{
		return default(AELIAAKPGEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5F012F0", Offset = "0x5F000F0", VA = "0x185F012F0")]
	public static void KJHOOHGMIMD(this IJBCNFLNIKE CNFBJPGPBBJ, AELIAAKPGEF NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface EEEGEKGFIKO
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float KNBDFHCBHGA);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private FCKFLMOMCOM IECONHPAAMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Collider[] PNIJIKABANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] GOIDKGDNBNI;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> IMCOCNNJAOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5F027E0", Offset = "0x5F015E0", VA = "0x185F027E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private FCKFLMOMCOM GNAONFFAPMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5F01E00", Offset = "0x5F00C00", VA = "0x185F01E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EABBHAGFGFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCE6490", Offset = "0xCE5290", VA = "0x180CE6490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5F027C0", Offset = "0x5F015C0", VA = "0x185F027C0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer HPFDJEHDLAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F02570", Offset = "0x5F01370", VA = "0x185F02570")]
		public void SetCollidersEnabled(bool IFBLBHFFNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F02140", Offset = "0x5F00F40", VA = "0x185F02140")]
		public void ReparentBonesUnderOtherBoneCollection(FCKFLMOMCOM NCGKJAICMAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5F01EA0", Offset = "0x5F00CA0", VA = "0x185F01EA0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EGJLFBFBEFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Transform GCGAJJKFAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform JMHEDKJMLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Transform ANNADOIECEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform OKJJMGCLNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Transform KFELEPEEBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Transform FNPHKOLKDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Transform CFJMIBIPIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Transform IMDLMFAIOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Transform CNMEDNFIILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation DENJOJDKFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PositionAndRotation KDABENOCPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private PositionAndRotation HFMKGIFIBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private PositionAndRotation MFAFEIJMILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private PositionAndRotation GCDLBPGLGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PositionAndRotation JPKFFAJIPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private PositionAndRotation CHBDPIJIPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PositionAndRotation IGJCAGPANDO;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F00170", Offset = "0x5EFEF70", VA = "0x185F00170")]
	public void FCIFMHNEBDM(Transform HAIILKLLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EFF930", Offset = "0x5EFE730", VA = "0x185EFF930")]
	public void BDGBAFPENLP(HandLogicOffsets JHMJIOLDGEK, DKEGCHDAJPG NENIOEPNMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5F00B00", Offset = "0x5EFF900", VA = "0x185F00B00")]
	public void KJCOOMINGDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F00D50", Offset = "0x5EFFB50", VA = "0x185F00D50")]
	private PositionAndRotation PGEPJPNPOBH(Transform FFBOBMDPNGB, Transform PLNFENNIFCO)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5F00830", Offset = "0x5EFF630", VA = "0x185F00830")]
	private void GLOJHBLGBID(Transform FFBOBMDPNGB, Transform PLNFENNIFCO, PositionAndRotation CPKGJOMIPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public EGJLFBFBEFP()
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
