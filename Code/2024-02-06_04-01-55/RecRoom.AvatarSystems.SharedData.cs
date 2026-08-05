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
public enum GBCLDCNEIMM
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
public struct AGCKAOAIKFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator CJAGEHEFMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public KOKFHMDEBKN LBNAOLDMDAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration GFNFLEEMCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject LHGKACCDELH;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CNALILKPMIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform HEAIDKAGFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool KLAONEBCDFK;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct EJGLCJGMPJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public GBCLDCNEIMM? JEPBBIDBIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public GBCLDCNEIMM? INJFODGHDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? FOJAMAHOECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? GDLOAMKHOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? LIEMCBHIHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? AMFFIKLHLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? FALKFAPLIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? EFMFKPPLLPJ;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum KOKFHMDEBKN
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum FAKFELCBKPP
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
public static class GFJLOAPLCAO
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly string DBHFHBHCDEO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8DF0", Offset = "0x5FA81F0", VA = "0x185FA8DF0")]
	public static HDEEBOHJIHD LAPFIPNDMJG()
	{
		return default(HDEEBOHJIHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8A50", Offset = "0x5FA7E50", VA = "0x185FA8A50")]
	public static OJMDMINAEFB JEKFJFKFHPE(Transform EAIDDIJMLKJ, Transform HGBDGAPAFNB, AvatarConfiguration OLPLPHOIFBH, Animator IKPODIAODLP, VRIK BKLANFFJEPB, GameObject[] OJAOHEPJFLM, Transform LFKIHOJONIO, AssetReference KMABIPOIOJG, GameObject JELJOAEKOHK, GameObject LKNMIBGFAEA, SkinnedMeshRenderer KALHPLMGKEL, Material JLAAENGBBKE, Material LNHKMKMBPBA, Material GLHEEEGAMAP, Shader DAFIMPLDFGN, Shader HLBNEBNPGAP, Transform OGIOJIMKHIF, Transform BKOBEDDIOFA, Transform JNDCNABMLJA, Transform BADBMDHALKC, Transform MFFBPDIMIFE, Transform KPNCGKJFOIM, Transform FDNCGBKPNCP, Renderer[] JPDCCBBPNPI, ACDILOGFDMI PNIDHHAHJJL, ACDILOGFDMI DMCDGFMBFJP, ACDILOGFDMI MOPLNKNKIGM, ACDILOGFDMI HAOLEDHMGHE, ACDILOGFDMI EOCDGAFDNKA, ACDILOGFDMI AJKCJPGGAEL, ACDILOGFDMI GMJBIGKPPPA, ACDILOGFDMI HMFECACFHEB, Transform AMEGCOCKGJP, Transform GFCGBMJHHGK, GameObject MFKJHMIFPDI, GameObject LAJHMLGHNMF)
	{
		return default(OJMDMINAEFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8770", Offset = "0x5FA7B70", VA = "0x185FA8770")]
	public static FHIOOJHHBOL CBIDEKGHIDM(string JBJBPHJJPMA, bool EGNHLDKJILN, bool BMDNPGFMHNI, bool CIIOLOGNACB, Func<HOIKKMCLAHO> NKDKFBDNBLH, Func<HDEEBOHJIHD> HADJPGEDJEF, RigidbodyEx GLIPNEBADAC, RigidbodyEx MDNODIJBNJA, RigidbodyEx KAEDLIHFLAF, RigidbodyEx NJPMJHMBOKE, Transform GIMPDBBDICA, Transform KGLPHMBAGNA, Transform DOPCOALKLPP, float JJGIPGJOJJB, float FDNIJCFLBIG, PlayerAvatarFullBodyColliders BAHBEAIJPJP)
	{
		return default(FHIOOJHHBOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8920", Offset = "0x5FA7D20", VA = "0x185FA8920")]
	public static HGNKDMIIFFC GCNBMAOBLCM(Transform HGBDGAPAFNB, AssetReference KMABIPOIOJG, GameObject JELJOAEKOHK, GameObject LKNMIBGFAEA, SkinnedMeshRenderer KALHPLMGKEL, Material JLAAENGBBKE, Material LNHKMKMBPBA, Material GLHEEEGAMAP, Shader PKNCIDLFDAO, Shader ELFNGKDHJBB, Animator JCIOIGGPEBM, Renderer[] JPDCCBBPNPI, AvatarConfiguration KNNJHCAMLKB)
	{
		return default(HGNKDMIIFFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8F30", Offset = "0x5FA8330", VA = "0x185FA8F30")]
	public static COLEDMOOCBI ODFHNOLILDI(Transform OGIOJIMKHIF, Transform JNDCNABMLJA, Transform BKOBEDDIOFA, Transform BADBMDHALKC, Transform MFFBPDIMIFE, Transform KPNCGKJFOIM, Transform FDNCGBKPNCP, AvatarConfiguration OLPLPHOIFBH)
	{
		return default(COLEDMOOCBI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13E54F0", Offset = "0x13E48F0", VA = "0x1813E54F0")]
	public static HANEPPFMEEH EGNABIJBCBI(SkinnedMeshRenderer[] OCJLPILAAPN)
	{
		return default(HANEPPFMEEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8E80", Offset = "0x5FA8280", VA = "0x185FA8E80")]
	public static CFMNDGHDEIJ OCGPDOKPDKC(NDBLOOHJAFN OHFEMKIKOHG, int FNNKFMPEMFD, int PJOIHJFFDDG, Color ELGMKFLGMBJ, Color ECNBMGBMIOL, int PBFPMGFLPIC, int HMDCKNPPGHC, Color OBCKBMIKIIA, Color NBOKODCEJNO, int NHJPGOJPIJP, float COCKJHHILKB)
	{
		return default(CFMNDGHDEIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9040", Offset = "0x5FA8440", VA = "0x185FA9040")]
	public static ONPNEGEFLGF PIDJCOGKCCL(NDBLOOHJAFN OHFEMKIKOHG, Vector2 KNACKAKAMKG, float IACPAIPCNKJ, Vector2 EPFAAOGHPPI, float HIBLHLFGKEH, Vector2 ONNOKKNABPL, float KPACMHKACIC, Vector2 CGPMFEDFLJE, float CFBIIEJFHDA)
	{
		return default(ONPNEGEFLGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FA88B0", Offset = "0x5FA7CB0", VA = "0x185FA88B0")]
	public static AGCKAOAIKFO DDNMJKMPDOI(Animator IJMFFNGPBLP, KOKFHMDEBKN GEOCHDCFMON, AvatarConfiguration KNNJHCAMLKB, GameObject FOLFHAIMGMN)
	{
		return default(AGCKAOAIKFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9000", Offset = "0x5FA8400", VA = "0x185FA9000")]
	public static CNALILKPMIB PDKEEKIAMLO(Transform HFJIKJOLFJC, bool BMDNPGFMHNI)
	{
		return default(CNALILKPMIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8E30", Offset = "0x5FA8230", VA = "0x185FA8E30")]
	public static EJGLCJGMPJE NPPGMGNLHEM([Optional] GBCLDCNEIMM? CCGILOLAEKA, [Optional] int? LDGFAFGDNDK, [Optional] float? LKGNGJHNKDG, [Optional] float? DNGOGFAGKGA, [Optional] bool? HNEBFENCNBN, [Optional] bool? IEOBDCHHDBB, [Optional] bool? AGKJPENLGHK, [Optional] GBCLDCNEIMM? DJPMMODIEAL)
	{
		return default(EJGLCJGMPJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class JHNHGIFAJPO
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA95E0", Offset = "0x5FA89E0", VA = "0x185FA95E0")]
	public static GBCLDCNEIMM OGEGLKFEOAJ(this FAKFELCBKPP NHJBPKBCNKI)
	{
		return default(GBCLDCNEIMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA95D0", Offset = "0x5FA89D0", VA = "0x185FA95D0")]
	public static bool KMCAKAKLKOI(this FAKFELCBKPP EKDNGEMIOGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MMDCIPEMFED
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FEBKBDAADFN : MMDCIPEMFED
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform ODAEKBBDPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A26E0", Offset = "0x7A1AE0", VA = "0x1807A26E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 LADLGIHOBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCEE8D0", Offset = "0xCEDCD0", VA = "0x180CEE8D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCEE900", Offset = "0xCEDD00", VA = "0x180CEE900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? CIDLBFIFMHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCEE8F0", Offset = "0xCEDCF0", VA = "0x180CEE8F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCEE8C0", Offset = "0xCEDCC0", VA = "0x180CEE8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public FEBKBDAADFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LHBJJGFOFAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly FEBKBDAADFN DHMKAGMOENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly FEBKBDAADFN MNOGMCHAIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly FEBKBDAADFN MDNBNBEIOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly FEBKBDAADFN GGNIKNDMECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected readonly FEBKBDAADFN PMIHFFEMJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly FEBKBDAADFN PBIMMHGEIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly FEBKBDAADFN MPFNNIIBIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly FEBKBDAADFN OPGGIIMAHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected readonly FEBKBDAADFN OKNEKAGEIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly FEBKBDAADFN FEIJGLCLLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly FEBKBDAADFN MGOAFPHPCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly FEBKBDAADFN KCFKNIHFPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected readonly FEBKBDAADFN MNOHAKHEPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected FEBKBDAADFN AGOMFDPKELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly FEBKBDAADFN GOHCOBALGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly FEBKBDAADFN POJIBCBFNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly FEBKBDAADFN KFDMIFJPDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected FEBKBDAADFN OIFDPMLDIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly FEBKBDAADFN JFIKDPMHFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly FEBKBDAADFN LGNDGKEEJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly FEBKBDAADFN AHGKFJIAINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected ReadOnlyCollection<FEBKBDAADFN> OBPPCPCLGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform LFKIHOJONIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private (FEBKBDAADFN Start, FEBKBDAADFN End)[] KFICMJEGBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private Dictionary<string, FEBKBDAADFN> AMGPFHEBKAG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MMDCIPEMFED LPCPPGOANLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7A26D0", Offset = "0x7A1AD0", VA = "0x1807A26D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MMDCIPEMFED EDICLCBCOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7A2690", Offset = "0x7A1A90", VA = "0x1807A2690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MMDCIPEMFED FEABDAGNBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MMDCIPEMFED IAGAPENBPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MMDCIPEMFED EFAABDHEOMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7A26C0", Offset = "0x7A1AC0", VA = "0x1807A26C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MMDCIPEMFED LGMPLLFJBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A47A0", Offset = "0x7A3BA0", VA = "0x1807A47A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MMDCIPEMFED IPLJGAHNGII
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7A6790", Offset = "0x7A5B90", VA = "0x1807A6790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public MMDCIPEMFED FLLNDDGNGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A6820", Offset = "0x7A5C20", VA = "0x1807A6820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MMDCIPEMFED AHEEHIMGFDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7A67F0", Offset = "0x7A5BF0", VA = "0x1807A67F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9C80", Offset = "0x5FA9080", VA = "0x185FA9C80")]
	public void HCNEBCGILBB(VRIK CNBPPADOKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FA97E0", Offset = "0x5FA8BE0", VA = "0x185FA97E0")]
	private void DJAHHDHNEJJ(Transform HEKLPNHIOGD, FEBKBDAADFN JILDGEDOLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAB60", Offset = "0x5FA9F60", VA = "0x185FAAB60")]
	public FEBKBDAADFN HGGIHCBCCLJ(string KAACLHCICJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9870", Offset = "0x5FA8C70", VA = "0x185FA9870")]
	public void EPNMIAICFCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAD00", Offset = "0x5FAA100", VA = "0x185FAAD00")]
	public float PBMNOKCHIJA([In] (FEBKBDAADFN Start, FEBKBDAADFN End) BNAIMOACLHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9630", Offset = "0x5FA8A30", VA = "0x185FA9630")]
	public void CBODKHAKLFK([In] HDEEBOHJIHD DMBLKCJLHHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FAABD0", Offset = "0x5FA9FD0", VA = "0x185FAABD0")]
	private Vector3 HNHLJAAGJPK([In] (FEBKBDAADFN Start, FEBKBDAADFN End) BNAIMOACLHM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAD40", Offset = "0x5FAA140", VA = "0x185FAAD40")]
	public LHBJJGFOFAM()
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
		[Cpp2IlInjected.Address(RVA = "0x5FA8690", Offset = "0x5FA7A90", VA = "0x185FA8690")]
		public string BAHCPMHOONP(string ANPKLCKIDED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FA86E0", Offset = "0x5FA7AE0", VA = "0x185FA86E0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FHIOOJHHBOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public string BKDHHMLJEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public bool KLAONEBCDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public bool DOIEGOPDAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public float HNGPHMGHMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public float CCECDFKJIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public bool MKNLOFHJEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public Func<HOIKKMCLAHO> PDLAKKALJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Func<HDEEBOHJIHD> PGDPAEKFLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public RigidbodyEx NGEGKOHHHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public RigidbodyEx HGLLDFLJKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public RigidbodyEx FDGEIPDHBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public RigidbodyEx CKLMACKBIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Transform DMKEEDMPGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform GMGCKFIJGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Transform GEPGBGCJOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public PlayerAvatarFullBodyColliders FHNPEHHMMEM;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OJMDMINAEFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Transform DDLDMAPPNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Transform IGPCCCDACNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public AvatarConfiguration GFNFLEEMCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Animator GPDGBPDEJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public VRIK POPPBFANBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public GameObject[] NHGIEKGLNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Transform OILBNFEJHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public AssetReference NLLOJKDIFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public GameObject ICBDMNEKCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public GameObject JEMNJOHLIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public SkinnedMeshRenderer JFMCJOGHFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Material MHPJENFPCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Material LONPEOJOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Material BNBEDBBCPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Shader CDIAGCBCLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Shader FNNDEIMDFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Transform DOHEKDIAMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Transform GIGNJKANOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform DBEOMGIPPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Transform FEMINGOPGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform EDMKADPDDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Transform GJHAMHGPHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform FADGKHGEKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Renderer[] LNDFEJDJKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform OPOJGMKEJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform FAEIFGGJHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject HKAEMHCFBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public GameObject EEKEBDEOPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public ACDILOGFDMI MJHKMNFBMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public ACDILOGFDMI KBMPIMHABED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public ACDILOGFDMI DPNCHIHMFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public ACDILOGFDMI ELAFOCJLKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public ACDILOGFDMI EHJKFOKEJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public ACDILOGFDMI AEMDPDNMNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public ACDILOGFDMI LICGHLAJHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public ACDILOGFDMI EDJNBJHMOLN;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HOIKKMCLAHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public bool GOHNNFNMLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public MMMOHCNLPFL JLFMCJAEFFB;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HDEEBOHJIHD
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class GGFDAAGEKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public readonly bool KOJHPMOAJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public readonly bool IKFEEPPCJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public readonly bool DINCCJNNMDB;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5FA9160", Offset = "0x5FA8560", VA = "0x185FA9160")]
		public GGFDAAGEKHK(bool HAMBEIJNEPK, bool NPMLBBMMODH, bool EPODHAGDMMA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public float GJLIGEFLJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public bool KFEPLJHELOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public float GLAINNPAGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Vector3 PAGBGFBPJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Vector3 BBFJIEHEALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Vector3? KCLNNNAFMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Vector3? IOJDHBMGAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool CEBNMOJGKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public bool PABOHOIDLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public bool NLJHLJKLCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public bool HBNDAKFJLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Vector3? ALIHHLMEBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool PALKJGDGMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Vector3? KEJDOFGALCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool NHGILLINDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Vector3? INIBDIIIDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float CPJJDGALJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? OJKJKMIDKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool AFPKIAHIKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public bool MEJIIKPJHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public bool MCEPPKFLAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public bool JCINDABOHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool KOJBELDGEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool APNHPFJOODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool BOLJCPILIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool CEJPDGPKOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool NJNBBKGHIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool MGAGIBPJJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public bool LCGJAEGHHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public Vector3? MHLIBDDBBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public FAKFELCBKPP GFGMBAIFLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public FAKFELCBKPP GDMBFOLFMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public bool DJPIHIACHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public bool GHPLIFIEJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public GGFDAAGEKHK FGPFLCDPFKA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA91B0", Offset = "0x5FA85B0", VA = "0x185FA91B0")]
	public void PEJBHJHGEDK(Quaternion IKFFGJBHBIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GFHHDLHHMKA
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8750", Offset = "0x5FA7B50", VA = "0x185FA8750")]
	public static KNDCACCAKGA HJKPFPOABHM(this DJLDFBNNPAN LOMPFKEACIP)
	{
		return default(KNDCACCAKGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8730", Offset = "0x5FA7B30", VA = "0x185FA8730")]
	public static void ECCAEHNDCMG(this DJLDFBNNPAN LOMPFKEACIP, KNDCACCAKGA ANJCCKHBJJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface ACDILOGFDMI
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float FANKMGPLGGP);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private KPEKDGHGCGB NBONGBABNJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private Collider[] AJMKMNBJIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] MDPIKIDFLAL;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> MELKFGGPKGA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5FABC00", Offset = "0x5FAB000", VA = "0x185FABC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private KPEKDGHGCGB EOFMHMIEPKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5FAB220", Offset = "0x5FAA620", VA = "0x185FAB220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JNOILHBEEAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCD3A50", Offset = "0xCD2E50", VA = "0x180CD3A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FABBE0", Offset = "0x5FAAFE0", VA = "0x185FABBE0")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer HBELBJBLGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB990", Offset = "0x5FAAD90", VA = "0x185FAB990")]
		public void SetCollidersEnabled(bool FAEFLPADKEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB560", Offset = "0x5FAA960", VA = "0x185FAB560")]
		public void ReparentBonesUnderOtherBoneCollection(KPEKDGHGCGB HNCHBKBPNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB2C0", Offset = "0x5FAA6C0", VA = "0x185FAB2C0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AGCDOBKAKDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Transform MELGPJGIJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Transform PBHJGNPIOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Transform IJIDKPBFJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Transform OKJDKJIGMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Transform JPCICOAOMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform MCODBBDBLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public Transform MHJGPKCLNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform PLGNFAMGOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Transform KGAIFFMDBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private PositionAndRotation ODMHAFHEBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private PositionAndRotation KFAOKJEHCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private PositionAndRotation HEACJNOIDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private PositionAndRotation ENJPPNNCHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation IIJIDONHKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private PositionAndRotation FFCEFNHFFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private PositionAndRotation FGGDBBAHFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private PositionAndRotation CKJBEFNNPNP;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7790", Offset = "0x5FA6B90", VA = "0x185FA7790")]
	public void OBMDJKKOMOC(Transform KDKBHDHPADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7E50", Offset = "0x5FA7250", VA = "0x185FA7E50")]
	public void ONOFJGEIBDG(HandLogicOffsets HPDKEHBMHEM, KOKFHMDEBKN GPBEHHJBIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7540", Offset = "0x5FA6940", VA = "0x185FA7540")]
	public void HEHBEKGPCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA71A0", Offset = "0x5FA65A0", VA = "0x185FA71A0")]
	private PositionAndRotation AHBCJDAFPHF(Transform LIKDFIBICME, Transform EDNOPEFDHFL)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7270", Offset = "0x5FA6670", VA = "0x185FA7270")]
	private void CBFBPHCEJOE(Transform LIKDFIBICME, Transform EDNOPEFDHFL, PositionAndRotation ALCGGHFAOOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public AGCDOBKAKDC()
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
