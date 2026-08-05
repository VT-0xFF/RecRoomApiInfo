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
public enum OLDFGPPKNAJ
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
public enum OLHELEJCABF
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
public struct ACIPDMCDGFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator EKKLLPADJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public IHMLADNPNHK JMCLJGABDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration IHOJKINCMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject OCMBFODKHBH;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct BIEEIKMMJLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform ABCIMKGOMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool LJCGMNJALEI;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum IHMLADNPNHK
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum LMHHLALGGLF
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
public struct CHGPGFOGKAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Vector2 HNFMDOHIMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector2 OLHJIDPGCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector2 DMPHGBOMNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector2 CPEMOIGOLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector2 BKKGKOMPOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 DFNKGBBAEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 GJHMAEJIAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 FJPBCBPKDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 KFMNHFDLHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 AJBLNAAHAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 KLMLAIJEAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 KBBHJCNIGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 ALCMMEPGGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 OJJFLJAEGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 AEEOPIONCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 ADIJPHAIELI;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DIODICBFBDC
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly string MJKDOAEHMLA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6105E80", Offset = "0x6104C80", VA = "0x186105E80")]
	public static IGDJFNFKNNN KHGEOCAMJGJ()
	{
		return default(IGDJFNFKNNN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61054C0", Offset = "0x61042C0", VA = "0x1861054C0")]
	public static KPJCGEGCCBE AFPDJOKGFOL(Transform DMOFAIGEHPM, Transform CADMKPMCENO, AvatarConfiguration IBPFJAOGNJF, Animator IBKOKPBNDKJ, VRIK ILNHGHDKADG, GameObject[] KAJGHMNBFJJ, Transform BPLECLPABEJ, AssetReference GOCPFIMBDCM, GameObject DGPHNADICJL, GameObject LNDNMIFFMIH, SkinnedMeshRenderer IABGPOHGICP, Material ANGJAFKDPOI, Material CEKAALCKBHL, Material BBBJAGJCEDM, Shader KLECJINOHOK, Shader OPKKIOEDGFP, Transform MANNAPKMFJB, Transform HDBIFLMOLLF, Transform AKCPNAJJHMJ, Transform KDGAJICPKEO, Transform CNPPEIEPHOD, Transform OOBAPNCOKGI, Transform CCLPIKANOID, Renderer[] OABGFEFCPJG, DOEDFENABFJ KNABMIOMHBB, DOEDFENABFJ LMCOKFDODNL, DOEDFENABFJ MKLAKIKJGOG, DOEDFENABFJ ELFCBNJGCCF, DOEDFENABFJ NBCHHHJBHFH, DOEDFENABFJ EHPPGIKMFEC, DOEDFENABFJ OFCLFFOBGML, DOEDFENABFJ HAJOLEDNGCO, Transform APPNPFNAJGC, Transform JIENDIHNNJE, GameObject NNHMGMCGGBA, GameObject CFHGKGKEHMH)
	{
		return default(KPJCGEGCCBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61058E0", Offset = "0x61046E0", VA = "0x1861058E0")]
	public static OOJIHOHDEFL AMLHLNEFKLL(string BPFNCMCDLIF, bool NDMDPGKFEHD, bool BLKDKDGIMAK, bool FCFLPOIKFPN, Func<FIEBHAMKILN> PJJGGHPFLBJ, Func<Vector3, IGDJFNFKNNN> PGDAHKKBEEA, RigidbodyEx GAJBJOIDKIG, RigidbodyEx PLNJPJMPENF, RigidbodyEx FAAEPOAHNDJ, RigidbodyEx NIBJKLKGABC, Transform MMNKHNMCGMB, Transform LLHKCOCPBLE, Transform HOOCIOGBLLB, float MHAFKJBEFCB, float MCJABLMHEIG, PlayerAvatarFullBodyColliders FLMPGEAKHCL, SkinnedMeshRenderer[] IEAPMBACLMF, SkinnedMeshRenderer[] PPGINACBGJA, SkinnedMeshRenderer[] CCIBIPAGCAM, SkinnedMeshRenderer[] JAJIHOALPNO)
	{
		return default(OOJIHOHDEFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6105BD0", Offset = "0x61049D0", VA = "0x186105BD0")]
	public static OMOLKENECLO GIJEIBHDNFG(Transform CADMKPMCENO, AssetReference GOCPFIMBDCM, GameObject DGPHNADICJL, GameObject LNDNMIFFMIH, SkinnedMeshRenderer IABGPOHGICP, Material ANGJAFKDPOI, Material CEKAALCKBHL, Material BBBJAGJCEDM, Shader GLJGOFAEHCL, Shader JKHPFKBNHNJ, Animator NLPGNPFIPOJ, Renderer[] OABGFEFCPJG, AvatarConfiguration OKPIKJKBKFB)
	{
		return default(OMOLKENECLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6105860", Offset = "0x6104660", VA = "0x186105860")]
	public static DIAKCGKHGHK AGNCNNCCONM(SkinnedMeshRenderer[] IEAPMBACLMF, SkinnedMeshRenderer[] PPGINACBGJA, SkinnedMeshRenderer[] CCIBIPAGCAM, SkinnedMeshRenderer[] JAJIHOALPNO)
	{
		return default(DIAKCGKHGHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6105DB0", Offset = "0x6104BB0", VA = "0x186105DB0")]
	public static NGIIEKPEOGO KDBIDBHNJIB(Transform MANNAPKMFJB, Transform AKCPNAJJHMJ, Transform HDBIFLMOLLF, Transform KDGAJICPKEO, Transform CNPPEIEPHOD, Transform OOBAPNCOKGI, Transform CCLPIKANOID, AvatarConfiguration IBPFJAOGNJF)
	{
		return default(NGIIEKPEOGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x819E90", Offset = "0x818C90", VA = "0x180819E90")]
	public static HBELCEIBMJF ECBOMDBHIFJ(SkinnedMeshRenderer[] BHCCEDCDCGA)
	{
		return default(HBELCEIBMJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6105AF0", Offset = "0x61048F0", VA = "0x186105AF0")]
	public static FGBLPFKFEMG EEIGMPMAPCE(EECMHFMEFGK OOFGAJFFONM, int KFJMBNCNNAE, int FOMGKOIDMHO, Color CCDKNBMLKJC, Color MKHDMJNJLEF, int MACCDELAEDJ, int PNCJCAEANOJ, Color HACLFHKEMOJ, Color KOJLMKNMMIB, int IBFEAMNHNAP)
	{
		return default(FGBLPFKFEMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6105D00", Offset = "0x6104B00", VA = "0x186105D00")]
	public static IFEPJBGCLOH IFKKCIKBABN(EECMHFMEFGK OOFGAJFFONM, Vector2 KMGMIPPICIL, float KPBNGDMDHIF, Vector2 NGDKDPAKIML, float HNBABFFKJJD, Vector2 KNEILDPDDMK, float ADEKMNAHJMA, Vector2 PNLDFOIGJGO, float HBOHCNEEMNN)
	{
		return default(IFEPJBGCLOH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6105A80", Offset = "0x6104880", VA = "0x186105A80")]
	public static ACIPDMCDGFA BJJHLLOPEHG(Animator PEDFEMLBJCA, IHMLADNPNHK PPMALENDDHL, AvatarConfiguration OKPIKJKBKFB, GameObject NDAFEGELJGN)
	{
		return default(ACIPDMCDGFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6105B90", Offset = "0x6104990", VA = "0x186105B90")]
	public static BIEEIKMMJLA FCCEIJIFDFK(Transform NOIOCJDELBO, bool BLKDKDGIMAK)
	{
		return default(BIEEIKMMJLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BAIEIAJFBDB
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6105460", Offset = "0x6104260", VA = "0x186105460")]
	public static OLDFGPPKNAJ CGCCGDCDFOG(this LMHHLALGGLF FIPEPMMFHGI)
	{
		return default(OLDFGPPKNAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61054B0", Offset = "0x61042B0", VA = "0x1861054B0")]
	public static bool JIEOJIJIAPC(this LMHHLALGGLF OODOIOJOMGK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface ICKJBLMPNAC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class CCBPLHHJPNB : ICKJBLMPNAC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform IBPFDOOAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 PPMODBMCGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xD9C5C0", Offset = "0xD9B3C0", VA = "0x180D9C5C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD9C5E0", Offset = "0xD9B3E0", VA = "0x180D9C5E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? PIHIIDGLEPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD9C5A0", Offset = "0xD9B3A0", VA = "0x180D9C5A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD9C5B0", Offset = "0xD9B3B0", VA = "0x180D9C5B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CCBPLHHJPNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class JAFKCJNGCOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected readonly CCBPLHHJPNB NKHDECIFGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly CCBPLHHJPNB MGMNDHGGPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly CCBPLHHJPNB BEPMENELLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly CCBPLHHJPNB HAKDEKMAEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected readonly CCBPLHHJPNB BOKOIGFLOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly CCBPLHHJPNB GIDBBNMLDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly CCBPLHHJPNB OBOOJJCFCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly CCBPLHHJPNB HMDOGJBAIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly CCBPLHHJPNB CFAPAHEPEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly CCBPLHHJPNB AJCPFNEOEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly CCBPLHHJPNB OIMJOJBPEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly CCBPLHHJPNB PJGFHEOBKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly CCBPLHHJPNB CEAGFPMGELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected CCBPLHHJPNB IGCHAKFKCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly CCBPLHHJPNB CJCPEBALBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly CCBPLHHJPNB CNNFECCPHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly CCBPLHHJPNB NDEGCAPGKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected CCBPLHHJPNB EEIMFOAFANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly CCBPLHHJPNB LHNGHHCGGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly CCBPLHHJPNB HGOKJNAOEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly CCBPLHHJPNB ABKNOMPAHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected ReadOnlyCollection<CCBPLHHJPNB> FJBCIAPBKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform BPLECLPABEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private (CCBPLHHJPNB Start, CCBPLHHJPNB End)[] NOPHBJMBPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private Dictionary<string, CCBPLHHJPNB> PGGOFAPLLEC;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ICKJBLMPNAC BONMKFKPMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ICKJBLMPNAC DDFJCMCMFLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ICKJBLMPNAC FNOLIFIIDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ICKJBLMPNAC MHCANBAHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ICKJBLMPNAC GCEAHLKOJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ICKJBLMPNAC DFIEBLCODGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F00", Offset = "0x7B0D00", VA = "0x1807B1F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ICKJBLMPNAC HONKEDBFNKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5870", Offset = "0x7B4670", VA = "0x1807B5870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ICKJBLMPNAC CDPEKAJOMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5840", Offset = "0x7B4640", VA = "0x1807B5840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ICKJBLMPNAC IOHJPFPOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61069B0", Offset = "0x61057B0", VA = "0x1861069B0")]
	public void OAAEPKGBPKL(VRIK DDGPJOFKGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6106870", Offset = "0x6105670", VA = "0x186106870")]
	private void JGPGDHOMPHL(Transform PFNKIIMPMKG, CCBPLHHJPNB KCDBINENHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6106900", Offset = "0x6105700", VA = "0x186106900")]
	public CCBPLHHJPNB KADAHGAAKAJ(string GNBBHFKFKMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6106340", Offset = "0x6105140", VA = "0x186106340")]
	public void FMIDGHGNBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6106970", Offset = "0x6105770", VA = "0x186106970")]
	public float MMGAMFNDIOG([In] (CCBPLHHJPNB Start, CCBPLHHJPNB End) FLNADFKCIDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61078D0", Offset = "0x61066D0", VA = "0x1861078D0")]
	public void ODHMKIMDEEA([In] IGDJFNFKNNN DEPIDMABJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6106740", Offset = "0x6105540", VA = "0x186106740")]
	private Vector3 HGMIGAPJBNK([In] (CCBPLHHJPNB Start, CCBPLHHJPNB End) FLNADFKCIDK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6107A80", Offset = "0x6106880", VA = "0x186107A80")]
	public JAFKCJNGCOI()
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
		[Cpp2IlInjected.Address(RVA = "0x61053C0", Offset = "0x61041C0", VA = "0x1861053C0")]
		public string IJIOCKCDAPA(string FLCIKHGGCCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6105410", Offset = "0x6104210", VA = "0x186105410")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OOJIHOHDEFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public string ICBLAJECEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool LJCGMNJALEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool DDONFDAAHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float OFNJIFKBIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float KOBJEBGGINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public bool NCGOLAOGPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Func<FIEBHAMKILN> DFCHIEKOOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Func<Vector3, IGDJFNFKNNN> HBPICADHIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public RigidbodyEx AKPEMCADJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public RigidbodyEx LLHMMLPONAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public RigidbodyEx MMCIMDKOGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public RigidbodyEx HAPDIENHCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform LNINHAPCDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform AGPLMGGJLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform IHNPIAGMAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public PlayerAvatarFullBodyColliders NAKIAJJCIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public SkinnedMeshRenderer[] EAFIFCGMCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer[] IAGOBEJFGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public SkinnedMeshRenderer[] JMGKJIPIGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SkinnedMeshRenderer[] PCLHDINOGNB;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61094E0", Offset = "0x61082E0", VA = "0x1861094E0")]
	public IGDJFNFKNNN GHKMDMMLGEL(Vector3 LMKFDACMDGA)
	{
		return default(IGDJFNFKNNN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KPJCGEGCCBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Transform KJIBJGGBCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform EPBDBIAILKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public AvatarConfiguration IHOJKINCMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Animator EMGMEEOICOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public VRIK HHLCHDHBOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public GameObject[] KKKDEAMLLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform BLAIPHLICHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public AssetReference NJGOHEFLKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GameObject JFPEGOGCMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject KFCLBHAHGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer KNMMENGMCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Material HHDNLMPLAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Material FOIJGPINPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Material EDGHPGLAGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Shader OIDNEANNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Shader DPDFJDMILGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform HAJIENNHKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform CKBHPMLBHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform KJHEBIFFJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform OKACCFFLNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Transform KNIHICIDBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Transform LBONBNDCNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform NFBKMMAHAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Renderer[] FDDPINPBJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Transform PDKGHDNBHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Transform KIDFHDFNDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject FEKHAAKJFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public GameObject GIIABLCMBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public DOEDFENABFJ NIGOIEGCLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public DOEDFENABFJ ANJLDOHIKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public DOEDFENABFJ NGABEEBLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public DOEDFENABFJ FEEBMKGHNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public DOEDFENABFJ IAPDMINFONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public DOEDFENABFJ DKECBLMIBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public DOEDFENABFJ MGAHJELIEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public DOEDFENABFJ CAFEGLJGHKJ;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FIEBHAMKILN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool OBFMMOPFOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public LJIBDJGPFIC MHDCBFODIEE;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IGDJFNFKNNN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class NDFJBGPHCOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly bool HMLDPPDAJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly bool OIOIOEKKNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly bool IGAEOPIMAPH;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6107FA0", Offset = "0x6106DA0", VA = "0x186107FA0")]
		public NDFJBGPHCOJ(bool GAHEBLCHIKD, bool JMMBGJFNAIN, bool AJOBKFLEONI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float NKIGPAAPPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool NPCDJAGDMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public float MAFPFJCIPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 KCKAEGFMENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3 AIHJPFHAEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3? IAEDNMMBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3? JHCHHMPCLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool GNIDNLNEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool ADPPPEHLGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool OAPNFJGIOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool BIEDDIIIOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Vector3? LHIOMBPJDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool HNOANNAIOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3? ODLNPNJBHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool BBAGEBPGLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3? IEBACLJBKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public float CAGLONMLENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3? HHJIFALBBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool FEIOJCJHHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool FNDDKGDLDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool MKEFBDNFKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool OMNGEMKIJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool DLFLDHMPJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool GKOJLGMLBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool KGEAKHNENIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool GHMECIKGBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool FDLIIADNEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool GPPAIHOFNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool IPKDDCFKGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3? PPFPPFDHKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public LMHHLALGGLF FOKFLNCIJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public LMHHLALGGLF MFPCOOPECPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool LFPEJBFHCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool IBJMNMMFNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public NDFJBGPHCOJ PNEKEAEHEJK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6105F20", Offset = "0x6104D20", VA = "0x186105F20")]
	public void PPBNMFBGHCP(Quaternion IHHAEIJMAPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KCBPLIMHJKP
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6107F60", Offset = "0x6106D60", VA = "0x186107F60")]
	public static ECLNJFJJGAI AHNLHDAKMAG(this LCBHLOHHMDF ILACEKALGJH)
	{
		return default(ECLNJFJJGAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6107F80", Offset = "0x6106D80", VA = "0x186107F80")]
	public static void FAOGNLBMEBO(this LCBHLOHHMDF ILACEKALGJH, ECLNJFJJGAI DIBNBLEEFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DOEDFENABFJ
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float KAFHCFGLIGM);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private BMDLMLPEJPH BPONCKBKMCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Collider[] PEBPMACDHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] CGENLGAJDBM;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> MCFEBINEMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x610A100", Offset = "0x6108F00", VA = "0x18610A100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private BMDLMLPEJPH PKCGHDHLIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6109680", Offset = "0x6108480", VA = "0x186109680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool BBFGAOFIKCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8D1840", Offset = "0x8D0640", VA = "0x1808D1840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6109720", Offset = "0x6108520", VA = "0x186109720")]
		private void LMLPKBOMLPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6109670", Offset = "0x6108470", VA = "0x186109670")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x610A0E0", Offset = "0x6108EE0", VA = "0x18610A0E0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer IMBJJEHONAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6109F10", Offset = "0x6108D10", VA = "0x186109F10")]
		public void SetCollidersEnabled(bool CDHMHHFKHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6109AA0", Offset = "0x61088A0", VA = "0x186109AA0")]
		public void ReparentBonesUnderOtherBoneCollection(BMDLMLPEJPH BNLACLPDGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x61097D0", Offset = "0x61085D0", VA = "0x1861097D0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NKDILICJDKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Transform CLBHEEMKBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Transform KNMCEPJPJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Transform DIECHHBAGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Transform FPNIFEHMCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Transform CGKHBCHANDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Transform EEKAMFOECAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Transform IGMCPHDAOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Transform KALLGDFFPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform KICKHOFAOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private PositionAndRotation PELENMIMOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private PositionAndRotation KMDOBEFFOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private PositionAndRotation KHAIDHLAKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private PositionAndRotation JCONMBNJCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private PositionAndRotation MLDPEFKDCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PositionAndRotation DGBHGJKALOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PositionAndRotation HNPPKLMLPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation HHMOBPJFOBC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6108240", Offset = "0x6107040", VA = "0x186108240")]
	public void HBPIHILNAPB(Transform AOBNLNGMNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6108900", Offset = "0x6107700", VA = "0x186108900")]
	public void IHLLPEPALIA(HandLogicOffsets NECDMPHGIDI, IHMLADNPNHK IFDHDMHEPPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6107FF0", Offset = "0x6106DF0", VA = "0x186107FF0")]
	public void FKCNHIKDNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6109140", Offset = "0x6107F40", VA = "0x186109140")]
	private PositionAndRotation MKKANCBEHBG(Transform CLKCEEFJBGK, Transform JLDPBDDLIHO)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6109210", Offset = "0x6108010", VA = "0x186109210")]
	private void PMKBMMCCEHD(Transform CLKCEEFJBGK, Transform JLDPBDDLIHO, PositionAndRotation AIOOBBBLDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NKDILICJDKF()
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
