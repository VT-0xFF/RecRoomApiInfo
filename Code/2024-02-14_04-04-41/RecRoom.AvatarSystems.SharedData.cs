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
public enum JKFBGABCLOM
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
public struct GNMNEEABJKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator MKGNLCBMKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public DIGFPOKJDGC AKOBPDKKFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration GDGKLPBCDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject PIAKGJBCPNC;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FDGNKMINBPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform KJDKKPLIIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool MKHGFCBBAAK;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct NEKCIHCBHBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public JKFBGABCLOM? HGOOMINBIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public JKFBGABCLOM? JEOLDNOEAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? JPEOLOIBCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? CBOLPLLAFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? PKEFOCNAJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? EMMKBBBBDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? NNCOCMLJPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? DFKJCMKLBJK;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DIGFPOKJDGC
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AJCNIAGLLEP
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
public static class ILHDKDEAGOJ
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly string NCNCMHKPMEH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E57890", Offset = "0x5E56C90", VA = "0x185E57890")]
	public static NPMBMNBLJLD EPCJPLPMFEE()
	{
		return default(NPMBMNBLJLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E574F0", Offset = "0x5E568F0", VA = "0x185E574F0")]
	public static BIKDKIGJELB CMCDCCHBNKI(Transform LIGDJMDPDAF, Transform AOLBHMOANAP, AvatarConfiguration DENIBFLGGBC, Animator JODHCMHFFMO, VRIK EMPJADFBDDD, GameObject[] LIGBCGMAIMD, Transform BENIBHDHEMD, AssetReference DDHOAGFCOCL, GameObject CBKAHIABOJC, GameObject EKCJOGLNDAD, SkinnedMeshRenderer EOABKCCCOGL, Material BOAAHOOHCPO, Material HALEOMECIHH, Material FCGPIKLOGKI, Shader IKANOCLGJKF, Shader PLBNOKNDLJF, Transform OAPLDJLANAB, Transform IGFLFIFLHKL, Transform DBOMMIFJJBP, Transform CBADMIAGDDJ, Transform LMHNIGJKHMM, Transform LEJKGEHNNIF, Transform EGPOGHLGMGI, Renderer[] HHAFHPELJPN, LGGDAKBIKCD FJDINHDJHKD, LGGDAKBIKCD NHIKIOKPNGH, LGGDAKBIKCD KAONKMNALIB, LGGDAKBIKCD EJMEGJFJEJF, LGGDAKBIKCD FKPJKLHIJBA, LGGDAKBIKCD ADOCLIBLMCI, LGGDAKBIKCD GLGFNIHMCFM, LGGDAKBIKCD JBPDFDNAOIC, Transform BINHENOODBD, Transform EPIFEHBPEPI, GameObject KIHNKDPFPAE, GameObject FLCBMFKPDBJ)
	{
		return default(BIKDKIGJELB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E57980", Offset = "0x5E56D80", VA = "0x185E57980")]
	public static MDPHMGPGNLM FILMPAENHAO(string JAMMKGBHFAP, bool KANEGHDFNGG, bool IPJPKIJJFIM, bool IOIMENLPJCH, Func<MDFCICOHMDC> PCLONNJKIAE, Func<Vector3, NPMBMNBLJLD> KKBCEGCBIBL, RigidbodyEx DKCNMENDLIN, RigidbodyEx MKFGMGILJKP, RigidbodyEx AINIJFKKMEK, RigidbodyEx FIPHBHMMDGL, Transform JNOMKNJOPII, Transform DPIPKHDFDNI, Transform BDALFBIEJMP, float BFMNJHNGKID, float MGBLKMHHHPK, PlayerAvatarFullBodyColliders FNEANFGMNDG)
	{
		return default(MDPHMGPGNLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E57B70", Offset = "0x5E56F70", VA = "0x185E57B70")]
	public static KGDHELIGPJF KALENNFFMBK(Transform AOLBHMOANAP, AssetReference DDHOAGFCOCL, GameObject CBKAHIABOJC, GameObject EKCJOGLNDAD, SkinnedMeshRenderer EOABKCCCOGL, Material BOAAHOOHCPO, Material HALEOMECIHH, Material FCGPIKLOGKI, Shader JJOEKHJPDKK, Shader NMGMKJJCPAO, Animator BEAPLJABDGA, Renderer[] HHAFHPELJPN, AvatarConfiguration GLIOOOFMFOK)
	{
		return default(KGDHELIGPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E57CA0", Offset = "0x5E570A0", VA = "0x185E57CA0")]
	public static PLOPFHCNAFB NIGPNOMFAEK(Transform OAPLDJLANAB, Transform DBOMMIFJJBP, Transform IGFLFIFLHKL, Transform CBADMIAGDDJ, Transform LMHNIGJKHMM, Transform LEJKGEHNNIF, Transform EGPOGHLGMGI, AvatarConfiguration DENIBFLGGBC)
	{
		return default(PLOPFHCNAFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13ED020", Offset = "0x13EC420", VA = "0x1813ED020")]
	public static KJLIAHPLPLP LDIMHPHDAJI(SkinnedMeshRenderer[] EFAIJNMJFLL)
	{
		return default(KJLIAHPLPLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E578D0", Offset = "0x5E56CD0", VA = "0x185E578D0")]
	public static FHFFAKAKALE FIACBFOPDLO(LIMIMDHOPOE GDMLAMFAFPI, int CGOFJLPDOBP, int LIGGIMFKAII, Color JJGPLIFOIOL, Color PMEPFPMGOIG, int KPEDCDLIGNK, int DGJPLLNLJHO, Color KEBJGOOGGID, Color IODCFIEGOOL, int GEAIPGCIOEH, float OPDPENHOKNO)
	{
		return default(FHFFAKAKALE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E57AC0", Offset = "0x5E56EC0", VA = "0x185E57AC0")]
	public static AABDMLCIAPH HDBFMLNJGEI(LIMIMDHOPOE GDMLAMFAFPI, Vector2 JMIDAGHIJOM, float GPFIFOIGMLJ, Vector2 IPJHMNALOOM, float NLPCHJAECFC, Vector2 LOOBHPLADIO, float NBCGHNEEBNK, Vector2 KEEFJHHHPMA, float JPLIKAKJGDG)
	{
		return default(AABDMLCIAPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E57D70", Offset = "0x5E57170", VA = "0x185E57D70")]
	public static GNMNEEABJKN PAJJPJBIMFK(Animator FMHOGMIFOMM, DIGFPOKJDGC MEOIGLIGEMC, AvatarConfiguration GLIOOOFMFOK, GameObject EMIKOEHJLGJ)
	{
		return default(GNMNEEABJKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E57DE0", Offset = "0x5E571E0", VA = "0x185E57DE0")]
	public static FDGNKMINBPJ PBBLFAKLJPL(Transform BCBNANNGFGO, bool IPJPKIJJFIM)
	{
		return default(FDGNKMINBPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E57E20", Offset = "0x5E57220", VA = "0x185E57E20")]
	public static NEKCIHCBHBL PJDFIFKNNDE([Optional] JKFBGABCLOM? OBIICMLGNEI, [Optional] int? EDFKPHCIIMJ, [Optional] float? LJBADFLODEF, [Optional] float? JGHLFPMPPIA, [Optional] bool? EKAGBLOOFDO, [Optional] bool? LMDLECIGPBE, [Optional] bool? ANGPMIDHGGP, [Optional] JKFBGABCLOM? HEPKNIMHKMB)
	{
		return default(NEKCIHCBHBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GEGPJGIINFH
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E57490", Offset = "0x5E56890", VA = "0x185E57490")]
	public static JKFBGABCLOM CKFPIJDPCEF(this AJCNIAGLLEP MHIBJOONCKH)
	{
		return default(JKFBGABCLOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E574E0", Offset = "0x5E568E0", VA = "0x185E574E0")]
	public static bool HGKLEMKBPPA(this AJCNIAGLLEP OOEEGBEGKDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BDBLJJNGKDH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class LMDKIGOCGPM : BDBLJJNGKDH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform KIHKPGMJDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x79F440", Offset = "0x79E840", VA = "0x18079F440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 AACCFFFKNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCEC2C0", Offset = "0xCEB6C0", VA = "0x180CEC2C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCEC2B0", Offset = "0xCEB6B0", VA = "0x180CEC2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? EMGEPFNIKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCEC2A0", Offset = "0xCEB6A0", VA = "0x180CEC2A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCEC2E0", Offset = "0xCEB6E0", VA = "0x180CEC2E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public LMDKIGOCGPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AENIPHDDKDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly LMDKIGOCGPM DJLFDKFNPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly LMDKIGOCGPM IBCFGKCJOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly LMDKIGOCGPM ILNHLJHLJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly LMDKIGOCGPM ECEEMPHKKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected readonly LMDKIGOCGPM ODFMMMMNAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly LMDKIGOCGPM DPFEPIAAGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly LMDKIGOCGPM AIJIGPHFHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly LMDKIGOCGPM EGDKNDDEFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected readonly LMDKIGOCGPM JGCBGMNDELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly LMDKIGOCGPM OBDMCLJFOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly LMDKIGOCGPM PBHCBLABMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly LMDKIGOCGPM GIMHDPGLGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected readonly LMDKIGOCGPM JKONCPIAFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected LMDKIGOCGPM ADGBKGMNIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly LMDKIGOCGPM ELFCOEICMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly LMDKIGOCGPM EDNGFFIGOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly LMDKIGOCGPM DIFPCOGDHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected LMDKIGOCGPM HOJPCJNBBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly LMDKIGOCGPM GPMFBLONLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly LMDKIGOCGPM BPIMPHMJDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly LMDKIGOCGPM GDNHEGPNADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected ReadOnlyCollection<LMDKIGOCGPM> GMENMAMOIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform BENIBHDHEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private (LMDKIGOCGPM Start, LMDKIGOCGPM End)[] HLINPADDNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, LMDKIGOCGPM> BLAELDNCOGO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BDBLJJNGKDH FNPOIOOKNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BDBLJJNGKDH JFLPMMNLLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x79F170", Offset = "0x79E570", VA = "0x18079F170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BDBLJJNGKDH FIMBODMPJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BDBLJJNGKDH KIMFAIBDIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BDBLJJNGKDH BHKBCBEIKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BDBLJJNGKDH HNGKNIFINFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x79F150", Offset = "0x79E550", VA = "0x18079F150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BDBLJJNGKDH HAGHBCMCHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x79F1A0", Offset = "0x79E5A0", VA = "0x18079F1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BDBLJJNGKDH OMMAAEAHMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A2D20", Offset = "0x7A2120", VA = "0x1807A2D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BDBLJJNGKDH BKIGLPEIFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x79F130", Offset = "0x79E530", VA = "0x18079F130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E54AF0", Offset = "0x5E53EF0", VA = "0x185E54AF0")]
	public void OCDOBKIKKMD(VRIK NKBBLCCOJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E545A0", Offset = "0x5E539A0", VA = "0x185E545A0")]
	private void CJHAKELBCOK(Transform JIBNFGIMNPP, LMDKIGOCGPM DAPOBFHGAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E54630", Offset = "0x5E53A30", VA = "0x185E54630")]
	public LMDKIGOCGPM EKEKEOBPBOE(string AJFPBBJIECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E546A0", Offset = "0x5E53AA0", VA = "0x185E546A0")]
	public void JBMOOBDGOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E54AB0", Offset = "0x5E53EB0", VA = "0x185E54AB0")]
	public float NABIOMAKIKJ([In] (LMDKIGOCGPM Start, LMDKIGOCGPM End) GCOCAAPJKAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E543F0", Offset = "0x5E537F0", VA = "0x185E543F0")]
	public void AOELIPMLEFP([In] NPMBMNBLJLD ILNNMFPHEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E542C0", Offset = "0x5E536C0", VA = "0x185E542C0")]
	private Vector3 AMLMEMDAIHE([In] (LMDKIGOCGPM Start, LMDKIGOCGPM End) GCOCAAPJKAO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E559D0", Offset = "0x5E54DD0", VA = "0x185E559D0")]
	public AENIPHDDKDH()
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

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E55EB0", Offset = "0x5E552B0", VA = "0x185E55EB0")]
		public string DEAMCJGDEBP(string FGNPJNBHMME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E55F00", Offset = "0x5E55300", VA = "0x185E55F00")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MDPHMGPGNLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string MDIIEICEFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool MKHGFCBBAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool HKBMPLNHKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float GNKMMLHPHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float OOIGPGAONBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool OJIJIACFFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public Func<MDFCICOHMDC> HPGLKHCHOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Func<Vector3, NPMBMNBLJLD> OCEOGLAADPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public RigidbodyEx DLMKENNIEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public RigidbodyEx AGDDDDHKDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public RigidbodyEx BEAKKKAAIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public RigidbodyEx NMMANFCCEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Transform DNHPCMDHKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform JIHOIEBBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Transform EEEEKLBCMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PlayerAvatarFullBodyColliders LILCINNKGEA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E57EE0", Offset = "0x5E572E0", VA = "0x185E57EE0")]
	public NPMBMNBLJLD IGJFFKNCEDE(Vector3 BHMJMBFMJFD)
	{
		return default(NPMBMNBLJLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BIKDKIGJELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Transform MBBPIPNLFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Transform EGDONBGOMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public AvatarConfiguration GDGKLPBCDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Animator EBGEIGGAAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public VRIK NANOFBGNAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public GameObject[] PBPEKJCDFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Transform GKAPMDKOFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public AssetReference FKHKOKCIKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public GameObject IAMKEKKMIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GameObject IOABDIICOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public SkinnedMeshRenderer PEAFPMPKHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Material CONBELJPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Material POEAAGEEAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Material JNPBCDMKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Shader GKCLALNEIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Shader BCFJLPNLFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Transform FLDHBLEJKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Transform FPOJFLNJNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform JCPECLLCBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Transform CHBMHBGLGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform HBEONNIPJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform CEKFFMAABEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform GBGBDBPEGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Renderer[] KPNCGOCHBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform CDBMKAPEJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform JLMOBNILFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject MCJEDAEMBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GameObject DGJFDADBGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public LGGDAKBIKCD NBOJAOHCBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public LGGDAKBIKCD PFGDCKBILKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public LGGDAKBIKCD KAPHMABKOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public LGGDAKBIKCD MNKCEBCLFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public LGGDAKBIKCD KNIJEONMCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public LGGDAKBIKCD NBAODMOGNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public LGGDAKBIKCD HEJFDIDIHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public LGGDAKBIKCD JNKABFFEPLG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MDFCICOHMDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public bool NNPACEJKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public FOIDAKOAIBK BNBKLHMIFNO;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NPMBMNBLJLD
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class BGJAKCGIINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly bool MECJPMCDGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly bool LLDCPHBJMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly bool LOGHABPDMON;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E55F50", Offset = "0x5E55350", VA = "0x185E55F50")]
		public BGJAKCGIINI(bool MMPBJCFAABF, bool IHJLLBHOFCE, bool GMMOAPOLNMD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public float EKJJKNJAKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public bool BGGFBPDCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public float IOIPMGDAAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Vector3 ENJLPHOPGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Vector3 OPABPMGKKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Vector3? DBOMNEHMJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Vector3? CFIOOELDAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool BDKHLPODDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public bool FMHOOMHGOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public bool IILFNIBHHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public bool BGPDKEHNKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Vector3? LDKKMMHCJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool PEDKEPCBGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Vector3? GJNJKNLBDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool GAOHDEOLNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3? ILLLIAHOMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float EFFDGGJJIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? OFJNJHHDLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool DLDIPEIOAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public bool MACJGNNDIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool CEDMNGBEIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool APHFKABNPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool BDMJNBMIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool FDDAFCLAJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool LIEIFFLDJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool CLBFNCGBIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool AJNOFJFIEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool BOEHGIOCONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool BCHFOLJGDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public Vector3? PFDMOMHPMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public AJCNIAGLLEP FPPJHMHEMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public AJCNIAGLLEP NHIFCDKJLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool IBNEICKAOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool EFCCHNPDPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public BGJAKCGIINI LDAKAINHAME;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E58070", Offset = "0x5E57470", VA = "0x185E58070")]
	public void ONMCAOBMKJP(Quaternion PGPLGEJKHLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OFOABKEMLBC
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E58490", Offset = "0x5E57890", VA = "0x185E58490")]
	public static NIOEOHLPCDI CFHIKMEOJAA(this KMFFBMLOIOL NHHBAHIFHJK)
	{
		return default(NIOEOHLPCDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E584B0", Offset = "0x5E578B0", VA = "0x185E584B0")]
	public static void GNCFEEBIEDJ(this KMFFBMLOIOL NHHBAHIFHJK, NIOEOHLPCDI FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LGGDAKBIKCD
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float PLEPJKNDBHF);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private HKKILEMEOKK LNNDEFCFEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private Collider[] IIHBNECAHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] APGJLDDPDPD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> OLPNLANNPFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5E58EB0", Offset = "0x5E582B0", VA = "0x185E58EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private HKKILEMEOKK CGCLPILMNLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5E584D0", Offset = "0x5E578D0", VA = "0x185E584D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool AJKIMDOCPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCD31A0", Offset = "0xCD25A0", VA = "0x180CD31A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E58E90", Offset = "0x5E58290", VA = "0x185E58E90")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer EEIMIAMHCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E58C40", Offset = "0x5E58040", VA = "0x185E58C40")]
		public void SetCollidersEnabled(bool PPMNKMLMNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E58810", Offset = "0x5E57C10", VA = "0x185E58810")]
		public void ReparentBonesUnderOtherBoneCollection(HKKILEMEOKK OHJKCHKIHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E58570", Offset = "0x5E57970", VA = "0x185E58570")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EPNFCAFMGAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Transform IIHDJIGPHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Transform DHEFPAMAIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Transform PMJIPBDAKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Transform AHGKNHCLHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Transform KGAOOALEGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform GDMHKGFGMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Transform PBIKFGKBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform OPMHAHAAMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Transform OIICJGNNMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private PositionAndRotation JKCOOIMMLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private PositionAndRotation HAEPGACEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private PositionAndRotation MBLNLFIFMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private PositionAndRotation GNEJEMCCDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation CNHHJCGIAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PositionAndRotation KDJNHMMKPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private PositionAndRotation DPFFJEBCLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private PositionAndRotation CMMHFCPGLJO;

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E56B00", Offset = "0x5E55F00", VA = "0x185E56B00")]
	public void NGFHLNOOHDK(Transform PMMDAGPAOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E55FA0", Offset = "0x5E553A0", VA = "0x185E55FA0")]
	public void FEKKJGLHLHB(HandLogicOffsets LCFJNAPNECE, DIGFPOKJDGC NPFECNDLLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E567E0", Offset = "0x5E55BE0", VA = "0x185E567E0")]
	public void HCDAPLKPKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E56A30", Offset = "0x5E55E30", VA = "0x185E56A30")]
	private PositionAndRotation JPKDENOGPOC(Transform DBLGNBKEJHA, Transform NILPKFLLHOB)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E571C0", Offset = "0x5E565C0", VA = "0x185E571C0")]
	private void PBICFPBEELP(Transform DBLGNBKEJHA, Transform NILPKFLLHOB, PositionAndRotation CDHEKFEJDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public EPNFCAFMGAP()
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
