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
public enum BKOHMAEBPDN
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
public enum AFGAPBCALJC
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
public struct AELFOKPOCFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Animator GEGAEEDGJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public DEGIBCGGDGO FBDGENPBKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public AvatarConfiguration LCCNNOKELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public GameObject MMPCPPENDPC;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IJMFPHAJMGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Transform BAMNJKDJFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool MFILOMBFMBE;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum DEGIBCGGDGO
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum AMNLOOCBKCE
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
public struct CBGJBFLAIJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Vector2 CFALACIFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Vector2 CKIPDLJGGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Vector2 IIAGOBODGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Vector2 LGHDMFCMCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Vector2 OMIJIBIKBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public Vector2 JFOKPNAFDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public Vector2 GMJEFFBGAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public Vector2 PGGLLLNJMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 KNNFHPNOIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Vector2 DGIHAOOKFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 IFHDANBCHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public Vector2 PHDLGNMPPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 NGFICDBPGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Vector2 NIGPNKNOHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Vector2 ECMFPIOPFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 OCHFJPJKOJA;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class KNAILMPAJJB
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly string GHEPIJAEFPD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61B5800", Offset = "0x61B4800", VA = "0x1861B5800")]
	public static EJHHMOOADDA PPFDMCLLBMN()
	{
		return default(EJHHMOOADDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61B4EB0", Offset = "0x61B3EB0", VA = "0x1861B4EB0")]
	public static HOANFPIONFJ COHINMKNPFK(Transform OCKHJMEPNID, Transform NLPBALCMMKF, AvatarConfiguration KLNABNDDEBF, Animator NEPNDOHOMMB, VRIK PPEHCJIIGGD, GameObject[] GNPBGJKDJAP, Transform BHNKMGNMJNE, AssetReference DGDFIBGMEAA, GameObject KFNJAEFABEH, GameObject NGOCHFBPEIA, SkinnedMeshRenderer CGMJBDNOONK, Material FNGMOFEIJNM, Material FDJPGCCHBKD, Material FCALIDIIPDG, Shader HLPEPIAADCA, Shader DJDLDFCFICH, Transform ONGPIHGHKPB, Transform LOHHLBCFLJG, Transform PPHPNKCBCEI, Transform JADIIJMGKPH, Transform PFKHNOEEHNB, Transform NOCJDKJLAJK, Transform MIFHLGNDFLJ, Renderer[] HEMPCNBAFGK, ADBBINHICBI DJGNCDJCILJ, ADBBINHICBI DIBOADOJFNJ, ADBBINHICBI CAJCACOJOEG, ADBBINHICBI NIAPCOFGBKM, ADBBINHICBI MNCBPHIOGGP, ADBBINHICBI COFJFFLIKFK, ADBBINHICBI ELDHGODOFMN, ADBBINHICBI FHAPHLJNEOL, Transform MHFBGOJGOJD, Transform GCLKKGHBGID, GameObject IAFJKJIOLON, GameObject IFCJKIIEINJ)
	{
		return default(HOANFPIONFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61B5530", Offset = "0x61B4530", VA = "0x1861B5530")]
	public static PPHAPADIDJB OCKAMIPOIKP(string GDMIPKHOCNN, bool OCOPEAGCCLJ, bool OCPNICIDHBG, bool JCONOOAOLBH, Func<GPHMMMCMHJP> OELAPGDOMME, Func<Vector3, EJHHMOOADDA> NKHONFKEELH, RigidbodyEx GJOJCCJMFIN, RigidbodyEx DFKCAKMCJIL, RigidbodyEx IPPGMIIAOEF, RigidbodyEx NMJGJCFGCMK, Transform GLIGOABGECO, Transform HLNELGIHBPO, Transform GAGKHANGNHB, float PIAAOODLEHL, float BIOGECLOLBA, PlayerAvatarFullBodyColliders KFONCCEOANA, SkinnedMeshRenderer[] AMEOAJJGNOF, SkinnedMeshRenderer[] IEILPNECIHC, SkinnedMeshRenderer[] PENPPOIOBPG, SkinnedMeshRenderer[] GBMPAPKADGE)
	{
		return default(PPHAPADIDJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61B56D0", Offset = "0x61B46D0", VA = "0x1861B56D0")]
	public static DFHLMLLLEGL PHAHHFAOLJL(Transform NLPBALCMMKF, AssetReference DGDFIBGMEAA, GameObject KFNJAEFABEH, GameObject NGOCHFBPEIA, SkinnedMeshRenderer CGMJBDNOONK, Material FNGMOFEIJNM, Material FDJPGCCHBKD, Material FCALIDIIPDG, Shader KJDJNDKCGNF, Shader NMGALIJPMLH, Animator MDMHHEFFDND, Renderer[] HEMPCNBAFGK, AvatarConfiguration GHDBCDGIHPI)
	{
		return default(DFHLMLLLEGL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61B5250", Offset = "0x61B4250", VA = "0x1861B5250")]
	public static IDCBPBLAGOH DDCDMHEMJIB(SkinnedMeshRenderer[] AMEOAJJGNOF, SkinnedMeshRenderer[] IEILPNECIHC, SkinnedMeshRenderer[] PENPPOIOBPG, SkinnedMeshRenderer[] GBMPAPKADGE)
	{
		return default(IDCBPBLAGOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61B52D0", Offset = "0x61B42D0", VA = "0x1861B52D0")]
	public static LOJDLDOFCNE LJGFFALPCDH(Transform ONGPIHGHKPB, Transform PPHPNKCBCEI, Transform LOHHLBCFLJG, Transform JADIIJMGKPH, Transform PFKHNOEEHNB, Transform NOCJDKJLAJK, Transform MIFHLGNDFLJ, AvatarConfiguration KLNABNDDEBF)
	{
		return default(LOJDLDOFCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x845830", Offset = "0x844830", VA = "0x180845830")]
	public static ILKKDPDJKAI ONADOMLBMOO(SkinnedMeshRenderer[] DMLENKFIDKD)
	{
		return default(ILKKDPDJKAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61B5450", Offset = "0x61B4450", VA = "0x1861B5450")]
	public static HDBOEFNBABK NDNFJNOFOJO(FJPGEDFHKPN JHLOBGHNEHM, int GJMPHJKJHPA, int HDAKCOHCLHE, Color FAEJJDDMNMF, Color EMBKLGCCPFL, int POFFNFBAAJN, int JLGBJFFDGFO, Color GILCGCNCCPG, Color ODBBJFFOMLI, int JNFLIGDDGGJ)
	{
		return default(HDBOEFNBABK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61B53A0", Offset = "0x61B43A0", VA = "0x1861B53A0")]
	public static JEBHPBONFGK LOLKENBHCIK(FJPGEDFHKPN JHLOBGHNEHM, Vector2 BHGBLEIDGFK, float DJBFELKBBKO, Vector2 HKANKBNBFLN, float KGEONLOCLKE, Vector2 CAEAEHPNOME, float LMGFDLHIGKB, Vector2 JLCJEHOINPA, float DKLIENEBFEP)
	{
		return default(JEBHPBONFGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61B4E40", Offset = "0x61B3E40", VA = "0x1861B4E40")]
	public static AELFOKPOCFO AEGPJIDGDDB(Animator CLDFKPNIJDH, DEGIBCGGDGO DAGGPPGDFFL, AvatarConfiguration GHDBCDGIHPI, GameObject FJADDGPNBOE)
	{
		return default(AELFOKPOCFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61B54F0", Offset = "0x61B44F0", VA = "0x1861B54F0")]
	public static IJMFPHAJMGG NNIMBCPMDGF(Transform AKCOAKEMOLJ, bool OCPNICIDHBG)
	{
		return default(IJMFPHAJMGG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IOBMDFBDLFC
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61B4DB0", Offset = "0x61B3DB0", VA = "0x1861B4DB0")]
	public static BKOHMAEBPDN IBJOJHPOKLM(this AMNLOOCBKCE DMAKBPFPKPO)
	{
		return default(BKOHMAEBPDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61B4DA0", Offset = "0x61B3DA0", VA = "0x1861B4DA0")]
	public static bool HDJHMMFEHAH(this AMNLOOCBKCE CALFFMHIMBD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KOEJNJLNFMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ONFKLFHELGH : KOEJNJLNFMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform EAHPGDBNGDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 MGPMECPLDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xDAEA20", Offset = "0xDADA20", VA = "0x180DAEA20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDAEA00", Offset = "0xDADA00", VA = "0x180DAEA00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? PDEMPPKPAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xDAEA10", Offset = "0xDADA10", VA = "0x180DAEA10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xDAE9F0", Offset = "0xDAD9F0", VA = "0x180DAE9F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public ONFKLFHELGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class CCAGGIOJJBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected readonly ONFKLFHELGH AHCMOPLNNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected readonly ONFKLFHELGH HJDCELFJPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected readonly ONFKLFHELGH NGAJILKCDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected readonly ONFKLFHELGH NLGAKBDCKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected readonly ONFKLFHELGH ECOCKAPCLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected readonly ONFKLFHELGH FAKBELPCGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected readonly ONFKLFHELGH COCHIEEJLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	protected readonly ONFKLFHELGH OBDKPBKFIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	protected readonly ONFKLFHELGH HDOKCLAPBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	protected readonly ONFKLFHELGH KNPMGMEGGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	protected readonly ONFKLFHELGH MAKLLDPKKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	protected readonly ONFKLFHELGH KAJHDHOAOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	protected readonly ONFKLFHELGH HJDKKIDJEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	protected ONFKLFHELGH LDBDIHPOGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected readonly ONFKLFHELGH OCDDBGDPDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	protected readonly ONFKLFHELGH LMFAAFCLNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	protected readonly ONFKLFHELGH MFMCECKELKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected ONFKLFHELGH CKJGMAMABKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly ONFKLFHELGH IGDNOEIEFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly ONFKLFHELGH AEDKLCJBBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly ONFKLFHELGH GNPFHMPMIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected ReadOnlyCollection<ONFKLFHELGH> GANEICEBMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform BHNKMGNMJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private (ONFKLFHELGH Start, ONFKLFHELGH End)[] CDCEBLPHEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private Dictionary<string, ONFKLFHELGH> IKAJOEIJCNO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KOEJNJLNFMJ DHOJCMFCGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KOEJNJLNFMJ CMAJPPFFFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KOEJNJLNFMJ NKEGLFCCIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public KOEJNJLNFMJ OKPOAJPNNEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KOEJNJLNFMJ IFBGJHKDAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public KOEJNJLNFMJ MFENBNNPLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C3300", VA = "0x1807C4300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public KOEJNJLNFMJ NKCLHNIGEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C79B0", Offset = "0x7C69B0", VA = "0x1807C79B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public KOEJNJLNFMJ ALCJNKDFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C7930", Offset = "0x7C6930", VA = "0x1807C7930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public KOEJNJLNFMJ FDAMOEFCDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7C7960", Offset = "0x7C6960", VA = "0x1807C7960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61B3210", Offset = "0x61B2210", VA = "0x1861B3210")]
	public void HDLMBHEBMPC(VRIK PJNGMKFBBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61B4130", Offset = "0x61B3130", VA = "0x1861B4130")]
	private void LCFMNJKHCNJ(Transform KEHDHCINJMM, ONFKLFHELGH AOHFGFEGDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61B2D90", Offset = "0x61B1D90", VA = "0x1861B2D90")]
	public ONFKLFHELGH CNAAGHIPECF(string DIGAONCAEPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61B2E00", Offset = "0x61B1E00", VA = "0x1861B2E00")]
	public void GIIGFGKIOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61B2D50", Offset = "0x61B1D50", VA = "0x1861B2D50")]
	public float AJJNMMMDMAP([In] (ONFKLFHELGH Start, ONFKLFHELGH End) JOKDBEHAKBO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61B42F0", Offset = "0x61B32F0", VA = "0x1861B42F0")]
	public void NAPOKOKGGNB([In] EJHHMOOADDA DKOKOEEPCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61B41C0", Offset = "0x61B31C0", VA = "0x1861B41C0")]
	private Vector3 LEBMEKNODNF([In] (ONFKLFHELGH Start, ONFKLFHELGH End) JOKDBEHAKBO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61B44A0", Offset = "0x61B34A0", VA = "0x1861B44A0")]
	public CCAGGIOJJBD()
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
		[Cpp2IlInjected.Address(RVA = "0x61B2CB0", Offset = "0x61B1CB0", VA = "0x1861B2CB0")]
		public string LIPLMHLHAMO(string KJAKBHBPMIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x61B2D00", Offset = "0x61B1D00", VA = "0x1861B2D00")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct PPHAPADIDJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public string HKMNJEIBFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public bool MFILOMBFMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool DOCLELJBADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float MNHJFBKDJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float GLOOILEJFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public bool HIKGCPFBOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Func<GPHMMMCMHJP> EGNFLKGDJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Func<Vector3, EJHHMOOADDA> LOBHLHODKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public RigidbodyEx EGJLCEFKGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public RigidbodyEx JHANHALFKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public RigidbodyEx EPBDKFBPGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public RigidbodyEx MLIKFNBFAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform MLBNCMPPLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform GGJDCNBONEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform CLMBGONEDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public PlayerAvatarFullBodyColliders JFFNEKBKKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public SkinnedMeshRenderer[] HBDECAFCGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public SkinnedMeshRenderer[] GOHEKEMALBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public SkinnedMeshRenderer[] FEJCEMALEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SkinnedMeshRenderer[] IDFFEOICHCF;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x61B6DA0", Offset = "0x61B5DA0", VA = "0x1861B6DA0")]
	public EJHHMOOADDA IFHOOANENCD(Vector3 PNNAJGACDLK)
	{
		return default(EJHHMOOADDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct HOANFPIONFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Transform OHEGLOHPNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Transform IHJFEPFLNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public AvatarConfiguration LCCNNOKELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Animator MEDFFGINGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public VRIK GPDIGPDFIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public GameObject[] KBFIGKKBLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform IHFNDMJOPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public AssetReference KNAKBLDIBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GameObject DCFPHMLOKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject AIDLGIAPPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer HPLGJIEEKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Material EFJPDKLOEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Material CCEOKNIGDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Material CGFNMHGNHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Shader DOHCBHKHNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Shader FOJFAMBOKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform AEEACODFOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform ONPEPMFGLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform MLGMBPAGIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform HGDCFILKPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Transform OMMDEFPONFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Transform PGFJNFEDBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform EGABINBCLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Renderer[] FCKILMMMJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Transform HFMHELJKLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Transform HOBCOOLNBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public GameObject KLCLHMGMNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public GameObject HDKNFDGKGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public ADBBINHICBI HAKKMOLEPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public ADBBINHICBI EAHPJDNLAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public ADBBINHICBI BBNANMPGDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public ADBBINHICBI PJKKOHLNHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public ADBBINHICBI ECGBADDNJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public ADBBINHICBI ODNKHBMJMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public ADBBINHICBI HOBLFMACCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public ADBBINHICBI OOKCOAFMCAI;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct GPHMMMCMHJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool BMFCKCPPHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public DCFIIAFEJOH ILCIFIAPMHG;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct EJHHMOOADDA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ALCCNDOGGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly bool MCDMKIPEOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly bool FEBDODKNNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly bool LEPIKNAEKKH;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61B2C60", Offset = "0x61B1C60", VA = "0x1861B2C60")]
		public ALCCNDOGGBE(bool AJGCANBBIND, bool BNOGPPNBJOA, bool GCGCNIEDNOL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float HANFADPBCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool FKBKOBDIFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public float MBLMMJGNBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 OLPPNFPGNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3 ELKGOAMMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3? APEHKDGCLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Vector3? FJNENGEEGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool FHBLKGIDPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool GHKMGKGEOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool BKKLDJPIDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool DPLJEIFDFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Vector3? BNGMEKJJFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool MCFCNOILJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3? GKHHGMNJBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool FLKMIHLPFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3? AJMDOHKJHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public float KLBFGIHLHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector3? EJJLGBFIFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool PGFMLPIPMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool FJNODGPBFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool IBDEOGPBIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool NNLGJFIJFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool EIGKHNLNMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool APDBLBLJEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool NNEGHKLDGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool NDCLEOEJJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool NDEGGBAINON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool FCIJOPKKEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool PMJNLEFEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Vector3? MDFJJFKBJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public AMNLOOCBKCE OCPFFEMODME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public AMNLOOCBKCE JKOLGGMJOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public bool MCGGBCANKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public bool NIKNABFAEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public ALCCNDOGGBE EOGCPJKGICG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61B4980", Offset = "0x61B3980", VA = "0x1861B4980")]
	public void ONCNHHBAIHL(Quaternion CKCOAEGKOKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KFFDEHMNFOI
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61B4E20", Offset = "0x61B3E20", VA = "0x1861B4E20")]
	public static CNEMEHGENOO KPBDGFFAPEL(this ECLKMJDGKOF HFLBADIEKAM)
	{
		return default(CNEMEHGENOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61B4E00", Offset = "0x61B3E00", VA = "0x1861B4E00")]
	public static void BAHDBHMIFEB(this ECLKMJDGKOF HFLBADIEKAM, CNEMEHGENOO LDGMLLMKHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface ADBBINHICBI
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float EFPELNMKHCE);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private OGECDHFBAPK MFIFLFPIMLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Collider[] PNHFDLMJMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] MCIMGCFDDPP;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public IReadOnlyList<Collider> OAIFMHMCDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x61B7970", Offset = "0x61B6970", VA = "0x1861B7970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private OGECDHFBAPK COLBCDKDOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x61B6F40", Offset = "0x61B5F40", VA = "0x1861B6F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ILFCJNOFLPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8EA9A0", Offset = "0x8E99A0", VA = "0x1808EA9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61B6FE0", Offset = "0x61B5FE0", VA = "0x1861B6FE0")]
		private void KJELLFNPAJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x61B6F30", Offset = "0x61B5F30", VA = "0x1861B6F30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x61B7950", Offset = "0x61B6950", VA = "0x1861B7950")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer IABEJDMNBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61B7760", Offset = "0x61B6760", VA = "0x1861B7760")]
		public void SetCollidersEnabled(bool IEEBLFDNOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x61B7330", Offset = "0x61B6330", VA = "0x1861B7330")]
		public void ReparentBonesUnderOtherBoneCollection(OGECDHFBAPK EEIAAFKOAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x61B7090", Offset = "0x61B6090", VA = "0x1861B7090")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PBCNAFIDDIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Transform GLGDPLFHMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Transform NACCEHDJGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Transform PPMPJCKMMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Transform AEJPGAIJDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Transform ENBBBCHIFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Transform BOKJKFPOKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Transform CENCIGINCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Transform MLIHEDBCMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Transform HLOAODLMNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private PositionAndRotation KBAHNEDCAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private PositionAndRotation FGOHHIOGIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private PositionAndRotation BFAOEIENGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private PositionAndRotation DFFFDAAOOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private PositionAndRotation MEAHGBKLCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PositionAndRotation FFGJDPMBHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PositionAndRotation CEPJIOOEBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation IJAJCOEGLIG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61B5B00", Offset = "0x61B4B00", VA = "0x1861B5B00")]
	public void CJMKLAKCCOG(Transform PDIMFPFEGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61B61C0", Offset = "0x61B51C0", VA = "0x1861B61C0")]
	public void DDCFLOLAMFG(HandLogicOffsets HLFKPLOIKCE, DEGIBCGGDGO KPJIMOCLNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x61B58B0", Offset = "0x61B48B0", VA = "0x1861B58B0")]
	public void AKPMCEIACJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x61B6A00", Offset = "0x61B5A00", VA = "0x1861B6A00")]
	private PositionAndRotation KNCPPJPMMLC(Transform HIDOAPDDOFA, Transform MAANAGFNCNO)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61B6AD0", Offset = "0x61B5AD0", VA = "0x1861B6AD0")]
	private void MCGEAMDHNGB(Transform HIDOAPDDOFA, Transform MAANAGFNCNO, PositionAndRotation KKGNCOKKNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public PBCNAFIDDIM()
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
