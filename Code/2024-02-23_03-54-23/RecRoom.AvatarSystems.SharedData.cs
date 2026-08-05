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
	[Cpp2IlInjected.Address(RVA = "0x5ED0AB0", Offset = "0x5ECF4B0", VA = "0x185ED0AB0")]
	public static NPMBMNBLJLD EPCJPLPMFEE()
	{
		return default(NPMBMNBLJLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0710", Offset = "0x5ECF110", VA = "0x185ED0710")]
	public static BIKDKIGJELB CMCDCCHBNKI(Transform LIGDJMDPDAF, Transform AOLBHMOANAP, AvatarConfiguration DENIBFLGGBC, Animator JODHCMHFFMO, VRIK EMPJADFBDDD, GameObject[] LIGBCGMAIMD, Transform BENIBHDHEMD, AssetReference DDHOAGFCOCL, GameObject CBKAHIABOJC, GameObject EKCJOGLNDAD, SkinnedMeshRenderer EOABKCCCOGL, Material BOAAHOOHCPO, Material HALEOMECIHH, Material FCGPIKLOGKI, Shader IKANOCLGJKF, Shader PLBNOKNDLJF, Transform OAPLDJLANAB, Transform IGFLFIFLHKL, Transform DBOMMIFJJBP, Transform CBADMIAGDDJ, Transform LMHNIGJKHMM, Transform LEJKGEHNNIF, Transform EGPOGHLGMGI, Renderer[] HHAFHPELJPN, LGGDAKBIKCD FJDINHDJHKD, LGGDAKBIKCD NHIKIOKPNGH, LGGDAKBIKCD KAONKMNALIB, LGGDAKBIKCD EJMEGJFJEJF, LGGDAKBIKCD FKPJKLHIJBA, LGGDAKBIKCD ADOCLIBLMCI, LGGDAKBIKCD GLGFNIHMCFM, LGGDAKBIKCD JBPDFDNAOIC, Transform BINHENOODBD, Transform EPIFEHBPEPI, GameObject KIHNKDPFPAE, GameObject FLCBMFKPDBJ)
	{
		return default(BIKDKIGJELB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0BA0", Offset = "0x5ECF5A0", VA = "0x185ED0BA0")]
	public static MDPHMGPGNLM FILMPAENHAO(string JAMMKGBHFAP, bool KANEGHDFNGG, bool IPJPKIJJFIM, bool IOIMENLPJCH, Func<MDFCICOHMDC> PCLONNJKIAE, Func<Vector3, NPMBMNBLJLD> KKBCEGCBIBL, RigidbodyEx DKCNMENDLIN, RigidbodyEx MKFGMGILJKP, RigidbodyEx AINIJFKKMEK, RigidbodyEx FIPHBHMMDGL, Transform JNOMKNJOPII, Transform DPIPKHDFDNI, Transform BDALFBIEJMP, float BFMNJHNGKID, float MGBLKMHHHPK, PlayerAvatarFullBodyColliders FNEANFGMNDG, SkinnedMeshRenderer[] HIFPEMICOOA, SkinnedMeshRenderer[] NPNILPACJGD, SkinnedMeshRenderer[] PCOIBFNJHCA, SkinnedMeshRenderer[] JEHDFKCGAJN)
	{
		return default(MDPHMGPGNLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0E70", Offset = "0x5ECF870", VA = "0x185ED0E70")]
	public static AHDCNFHNGDB NGKMAGKNACL(Transform AOLBHMOANAP, AssetReference DDHOAGFCOCL, GameObject CBKAHIABOJC, GameObject EKCJOGLNDAD, SkinnedMeshRenderer EOABKCCCOGL, Material BOAAHOOHCPO, Material HALEOMECIHH, Material FCGPIKLOGKI, Shader JJOEKHJPDKK, Shader NMGMKJJCPAO, Animator BEAPLJABDGA, Renderer[] HHAFHPELJPN, AvatarConfiguration GLIOOOFMFOK)
	{
		return default(AHDCNFHNGDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0DF0", Offset = "0x5ECF7F0", VA = "0x185ED0DF0")]
	public static KGDHELIGPJF KALENNFFMBK(SkinnedMeshRenderer[] HIFPEMICOOA, SkinnedMeshRenderer[] NPNILPACJGD, SkinnedMeshRenderer[] PCOIBFNJHCA, SkinnedMeshRenderer[] JEHDFKCGAJN)
	{
		return default(KGDHELIGPJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0FA0", Offset = "0x5ECF9A0", VA = "0x185ED0FA0")]
	public static PLOPFHCNAFB NIGPNOMFAEK(Transform OAPLDJLANAB, Transform DBOMMIFJJBP, Transform IGFLFIFLHKL, Transform CBADMIAGDDJ, Transform LMHNIGJKHMM, Transform LEJKGEHNNIF, Transform EGPOGHLGMGI, AvatarConfiguration DENIBFLGGBC)
	{
		return default(PLOPFHCNAFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1401FB0", Offset = "0x14009B0", VA = "0x181401FB0")]
	public static KJLIAHPLPLP LDIMHPHDAJI(SkinnedMeshRenderer[] EFAIJNMJFLL)
	{
		return default(KJLIAHPLPLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0AF0", Offset = "0x5ECF4F0", VA = "0x185ED0AF0")]
	public static FHFFAKAKALE FIACBFOPDLO(LIMIMDHOPOE GDMLAMFAFPI, int CGOFJLPDOBP, int LIGGIMFKAII, Color JJGPLIFOIOL, Color PMEPFPMGOIG, int KPEDCDLIGNK, int DGJPLLNLJHO, Color KEBJGOOGGID, Color IODCFIEGOOL, int GEAIPGCIOEH, float OPDPENHOKNO)
	{
		return default(FHFFAKAKALE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0D40", Offset = "0x5ECF740", VA = "0x185ED0D40")]
	public static AABDMLCIAPH HDBFMLNJGEI(LIMIMDHOPOE GDMLAMFAFPI, Vector2 JMIDAGHIJOM, float GPFIFOIGMLJ, Vector2 IPJHMNALOOM, float NLPCHJAECFC, Vector2 LOOBHPLADIO, float NBCGHNEEBNK, Vector2 KEEFJHHHPMA, float JPLIKAKJGDG)
	{
		return default(AABDMLCIAPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1070", Offset = "0x5ECFA70", VA = "0x185ED1070")]
	public static GNMNEEABJKN PAJJPJBIMFK(Animator FMHOGMIFOMM, DIGFPOKJDGC MEOIGLIGEMC, AvatarConfiguration GLIOOOFMFOK, GameObject EMIKOEHJLGJ)
	{
		return default(GNMNEEABJKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED10E0", Offset = "0x5ECFAE0", VA = "0x185ED10E0")]
	public static FDGNKMINBPJ PBBLFAKLJPL(Transform BCBNANNGFGO, bool IPJPKIJJFIM)
	{
		return default(FDGNKMINBPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1120", Offset = "0x5ECFB20", VA = "0x185ED1120")]
	public static NEKCIHCBHBL PJDFIFKNNDE([Optional] JKFBGABCLOM? OBIICMLGNEI, [Optional] int? EDFKPHCIIMJ, [Optional] float? LJBADFLODEF, [Optional] float? JGHLFPMPPIA, [Optional] bool? EKAGBLOOFDO, [Optional] bool? LMDLECIGPBE, [Optional] bool? ANGPMIDHGGP, [Optional] JKFBGABCLOM? HEPKNIMHKMB)
	{
		return default(NEKCIHCBHBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GEGPJGIINFH
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED06B0", Offset = "0x5ECF0B0", VA = "0x185ED06B0")]
	public static JKFBGABCLOM CKFPIJDPCEF(this AJCNIAGLLEP MHIBJOONCKH)
	{
		return default(JKFBGABCLOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0700", Offset = "0x5ECF100", VA = "0x185ED0700")]
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
		[Cpp2IlInjected.Token(Token = "0x6000010")]
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
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A9440", Offset = "0x7A7E40", VA = "0x1807A9440")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 AACCFFFKNOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCF4A00", Offset = "0xCF3400", VA = "0x180CF4A00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCF49F0", Offset = "0xCF33F0", VA = "0x180CF49F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? EMGEPFNIKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCF49E0", Offset = "0xCF33E0", VA = "0x180CF49E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCF4A20", Offset = "0xCF3420", VA = "0x180CF4A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BDBLJJNGKDH JFLPMMNLLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A9170", Offset = "0x7A7B70", VA = "0x1807A9170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BDBLJJNGKDH FIMBODMPJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BDBLJJNGKDH KIMFAIBDIHN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BDBLJJNGKDH BHKBCBEIKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BDBLJJNGKDH HNGKNIFINFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A9150", Offset = "0x7A7B50", VA = "0x1807A9150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BDBLJJNGKDH HAGHBCMCHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A91A0", Offset = "0x7A7BA0", VA = "0x1807A91A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BDBLJJNGKDH OMMAAEAHMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7ACD20", Offset = "0x7AB720", VA = "0x1807ACD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BDBLJJNGKDH BKIGLPEIFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7A9130", Offset = "0x7A7B30", VA = "0x1807A9130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD10", Offset = "0x5ECC710", VA = "0x185ECDD10")]
	public void OCDOBKIKKMD(VRIK NKBBLCCOJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD7C0", Offset = "0x5ECC1C0", VA = "0x185ECD7C0")]
	private void CJHAKELBCOK(Transform JIBNFGIMNPP, LMDKIGOCGPM DAPOBFHGAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD850", Offset = "0x5ECC250", VA = "0x185ECD850")]
	public LMDKIGOCGPM EKEKEOBPBOE(string AJFPBBJIECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD8C0", Offset = "0x5ECC2C0", VA = "0x185ECD8C0")]
	public void JBMOOBDGOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDCD0", Offset = "0x5ECC6D0", VA = "0x185ECDCD0")]
	public float NABIOMAKIKJ([In] (LMDKIGOCGPM Start, LMDKIGOCGPM End) GCOCAAPJKAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD610", Offset = "0x5ECC010", VA = "0x185ECD610")]
	public void AOELIPMLEFP([In] NPMBMNBLJLD ILNNMFPHEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD4E0", Offset = "0x5ECBEE0", VA = "0x185ECD4E0")]
	private Vector3 AMLMEMDAIHE([In] (LMDKIGOCGPM Start, LMDKIGOCGPM End) GCOCAAPJKAO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEBF0", Offset = "0x5ECD5F0", VA = "0x185ECEBF0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF0D0", Offset = "0x5ECDAD0", VA = "0x185ECF0D0")]
		public string DEAMCJGDEBP(string FGNPJNBHMME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF120", Offset = "0x5ECDB20", VA = "0x185ECF120")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public SkinnedMeshRenderer[] PJKGGDEOOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer[] CONIMNBEPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public SkinnedMeshRenderer[] MDGAMJPNBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public SkinnedMeshRenderer[] CBIDFNEJHKA;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED11E0", Offset = "0x5ECFBE0", VA = "0x185ED11E0")]
	public NPMBMNBLJLD IGJFFKNCEDE(Vector3 BHMJMBFMJFD)
	{
		return default(NPMBMNBLJLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct BIKDKIGJELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Transform MBBPIPNLFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Transform EGDONBGOMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public AvatarConfiguration GDGKLPBCDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Animator EBGEIGGAAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public VRIK NANOFBGNAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GameObject[] PBPEKJCDFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform GKAPMDKOFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AssetReference FKHKOKCIKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public GameObject IAMKEKKMIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public GameObject IOABDIICOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer PEAFPMPKHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Material CONBELJPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Material POEAAGEEAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Material JNPBCDMKCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Shader GKCLALNEIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Shader BCFJLPNLFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform FLDHBLEJKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform FPOJFLNJNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform JCPECLLCBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform CHBMHBGLGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform HBEONNIPJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform CEKFFMAABEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Transform GBGBDBPEGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Renderer[] KPNCGOCHBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Transform CDBMKAPEJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Transform JLMOBNILFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public GameObject MCJEDAEMBOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public GameObject DGJFDADBGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public LGGDAKBIKCD NBOJAOHCBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public LGGDAKBIKCD PFGDCKBILKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public LGGDAKBIKCD KAPHMABKOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public LGGDAKBIKCD MNKCEBCLFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public LGGDAKBIKCD KNIJEONMCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public LGGDAKBIKCD NBAODMOGNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public LGGDAKBIKCD HEJFDIDIHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public LGGDAKBIKCD JNKABFFEPLG;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MDFCICOHMDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public bool NNPACEJKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public FOIDAKOAIBK BNBKLHMIFNO;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NPMBMNBLJLD
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class BGJAKCGIINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public readonly bool MECJPMCDGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly bool LLDCPHBJMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly bool LOGHABPDMON;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF170", Offset = "0x5ECDB70", VA = "0x185ECF170")]
		public BGJAKCGIINI(bool MMPBJCFAABF, bool IHJLLBHOFCE, bool GMMOAPOLNMD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public float EKJJKNJAKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool BGGFBPDCLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float IOIPMGDAAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Vector3 ENJLPHOPGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3 OPABPMGKKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Vector3? DBOMNEHMJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Vector3? CFIOOELDAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool BDKHLPODDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool FMHOOMHGOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool IILFNIBHHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool BGPDKEHNKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3? LDKKMMHCJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool PEDKEPCBGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? GJNJKNLBDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool GAOHDEOLNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Vector3? ILLLIAHOMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public float EFFDGGJJIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3? OFJNJHHDLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool DLDIPEIOAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool MACJGNNDIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool CEDMNGBEIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool APHFKABNPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool BDMJNBMIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool FDDAFCLAJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool LIEIFFLDJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool CLBFNCGBIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public bool AJNOFJFIEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool BOEHGIOCONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool BCHFOLJGDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? PFDMOMHPMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public AJCNIAGLLEP FPPJHMHEMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public AJCNIAGLLEP NHIFCDKJLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool IBNEICKAOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool EFCCHNPDPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public BGJAKCGIINI LDAKAINHAME;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1370", Offset = "0x5ECFD70", VA = "0x185ED1370")]
	public void ONMCAOBMKJP(Quaternion PGPLGEJKHLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class OFOABKEMLBC
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1790", Offset = "0x5ED0190", VA = "0x185ED1790")]
	public static NIOEOHLPCDI CFHIKMEOJAA(this KMFFBMLOIOL NHHBAHIFHJK)
	{
		return default(NIOEOHLPCDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED17B0", Offset = "0x5ED01B0", VA = "0x185ED17B0")]
	public static void GNCFEEBIEDJ(this KMFFBMLOIOL NHHBAHIFHJK, NIOEOHLPCDI FDFHGIHHGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LGGDAKBIKCD
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float PLEPJKNDBHF);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private HKKILEMEOKK LNNDEFCFEFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Collider[] IIHBNECAHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] APGJLDDPDPD;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> OLPNLANNPFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5ED21B0", Offset = "0x5ED0BB0", VA = "0x185ED21B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private HKKILEMEOKK CGCLPILMNLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5ED17D0", Offset = "0x5ED01D0", VA = "0x185ED17D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool AJKIMDOCPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xCD9C00", Offset = "0xCD8600", VA = "0x180CD9C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2190", Offset = "0x5ED0B90", VA = "0x185ED2190")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer EEIMIAMHCCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1F40", Offset = "0x5ED0940", VA = "0x185ED1F40")]
		public void SetCollidersEnabled(bool PPMNKMLMNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1B10", Offset = "0x5ED0510", VA = "0x185ED1B10")]
		public void ReparentBonesUnderOtherBoneCollection(HKKILEMEOKK OHJKCHKIHAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1870", Offset = "0x5ED0270", VA = "0x185ED1870")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EPNFCAFMGAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Transform IIHDJIGPHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform DHEFPAMAIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Transform PMJIPBDAKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform AHGKNHCLHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Transform KGAOOALEGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Transform GDMHKGFGMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Transform PBIKFGKBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Transform OPMHAHAAMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Transform OIICJGNNMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation JKCOOIMMLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PositionAndRotation HAEPGACEMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private PositionAndRotation MBLNLFIFMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private PositionAndRotation GNEJEMCCDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private PositionAndRotation CNHHJCGIAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PositionAndRotation KDJNHMMKPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private PositionAndRotation DPFFJEBCLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PositionAndRotation CMMHFCPGLJO;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFD20", Offset = "0x5ECE720", VA = "0x185ECFD20")]
	public void NGFHLNOOHDK(Transform PMMDAGPAOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF1C0", Offset = "0x5ECDBC0", VA = "0x185ECF1C0")]
	public void FEKKJGLHLHB(HandLogicOffsets LCFJNAPNECE, DIGFPOKJDGC NPFECNDLLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFA00", Offset = "0x5ECE400", VA = "0x185ECFA00")]
	public void HCDAPLKPKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFC50", Offset = "0x5ECE650", VA = "0x185ECFC50")]
	private PositionAndRotation JPKDENOGPOC(Transform DBLGNBKEJHA, Transform NILPKFLLHOB)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED03E0", Offset = "0x5ECEDE0", VA = "0x185ED03E0")]
	private void PBICFPBEELP(Transform DBLGNBKEJHA, Transform NILPKFLLHOB, PositionAndRotation CDHEKFEJDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
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
