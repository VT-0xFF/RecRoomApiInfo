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
public enum GFMBNELHABF
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
public struct CHGMIPNOIIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public Animator BLPEOEECOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public OINOEKBNMMI HAKFBODEKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AvatarConfiguration EPDAHOKOAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public GameObject IFKNLGCHAED;
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IJIHAECAPAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Transform AJOKAHFJKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public bool BPPAEFGHMGD;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KPMHICAJMCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public GFMBNELHABF? LGJICFFEIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public GFMBNELHABF? KJCPGODMFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public int? FEGMEEFFJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float? CHBFADPIBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float? POGOIDLMNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool? PCCPAGAEBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool? PACDALKHBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool? OGLLMJFNGJI;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OINOEKBNMMI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Left,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Right
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public enum JKKBMMOOKOP
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
public static class CCGJKDOAKAA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly string HLIPCJEOHJE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4260", Offset = "0x5EF2C60", VA = "0x185EF4260")]
	public static NFBDDOEPPAF EAHAEPOCBMO()
	{
		return default(NFBDDOEPPAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4840", Offset = "0x5EF3240", VA = "0x185EF4840")]
	public static LDPHMLBGNIJ PEDFIKAFGOL(Transform EOHLMBCMKEP, Transform HGIJCIBFNBG, AvatarConfiguration OMJEAMJCIID, Animator MFNIJNHAEGL, VRIK OCMIHMEJGJI, GameObject[] KLDBJODAPKD, Transform CLAOGLINPIL, AssetReference MIEJOMEIGIC, GameObject NAOOPBPJPMD, GameObject FLONNDMDFCM, SkinnedMeshRenderer PMNCPKIJMFI, Material AINAHIJIMGN, Material EKIGKMAKLBP, Material OHHPIPPEJGJ, Shader ODLHGNLACEC, Shader CGKDDIENPLL, Transform KEHHKPBPPHG, Transform PNINCACHHCK, Transform PIGPHPGLGND, Transform MKGLDIKLPNB, Transform KBADGEDNCDJ, Transform MAMAHHOFCMF, Transform NJOLHAFOCKF, Renderer[] HMKKEHBGHNB, HNMDBONEBPB LPLGEHDMPPD, HNMDBONEBPB ALKLBNOHJNL, HNMDBONEBPB IJCBFEBKKMF, HNMDBONEBPB KCEKOOGBFBO, HNMDBONEBPB JOFMKBMPNDA, HNMDBONEBPB AKKIEHIOJEA, HNMDBONEBPB KIEMPJAABEH, HNMDBONEBPB NNHLOFEJPDL, Transform LPFMFHHBMBL, Transform JHNNDOMGPON, GameObject BEHEDFEOBIG, GameObject OLEFKONHPDD)
	{
		return default(LDPHMLBGNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4390", Offset = "0x5EF2D90", VA = "0x185EF4390")]
	public static NGDFIDEPELD JABFOPEALPE(string HPGEOFEBOKH, bool JOGJNEPDOKN, bool HMGENMCGNDD, bool JHEKKAHAKGE, Func<IBHDPHPOKGK> OBFJKNLFEPP, Func<NFBDDOEPPAF> DKPPJIHHNKG, RigidbodyEx KEBCFDGHKBG, RigidbodyEx ADCMCFLKKDF, RigidbodyEx HNHCFAOHEND, RigidbodyEx AJAPCKCAPCN, Transform MPJGLEAKGAC, Transform MLKINJCCLNF, Transform CMGHMJPHOEB, float PCCJPFLFAIG, float EOFNJHLLFFE, PlayerAvatarFullBodyColliders ONFHFFPCBND)
	{
		return default(NGDFIDEPELD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4660", Offset = "0x5EF3060", VA = "0x185EF4660")]
	public static OEOELCOLDOD OONLJIKMDNI(Transform HGIJCIBFNBG, AssetReference MIEJOMEIGIC, GameObject NAOOPBPJPMD, GameObject FLONNDMDFCM, SkinnedMeshRenderer PMNCPKIJMFI, Material AINAHIJIMGN, Material EKIGKMAKLBP, Material OHHPIPPEJGJ, Shader IEGJOLLHPEA, Shader MLEEBFKJADC, Animator NOJENFAEKBM, Renderer[] HMKKEHBGHNB, AvatarConfiguration CNAOIPEGHKI)
	{
		return default(OEOELCOLDOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4590", Offset = "0x5EF2F90", VA = "0x185EF4590")]
	public static GABOCIFFCBH NDHNBJOBIGP(Transform KEHHKPBPPHG, Transform PIGPHPGLGND, Transform PNINCACHHCK, Transform MKGLDIKLPNB, Transform KBADGEDNCDJ, Transform MAMAHHOFCMF, Transform NJOLHAFOCKF, AvatarConfiguration OMJEAMJCIID)
	{
		return default(GABOCIFFCBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x13F3930", Offset = "0x13F2330", VA = "0x1813F3930")]
	public static HKJAFIAPOLI EPDIIPPPIIL(SkinnedMeshRenderer[] MENIFOHPELH)
	{
		return default(HKJAFIAPOLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4790", Offset = "0x5EF3190", VA = "0x185EF4790")]
	public static AJMBKDNNHKC PCLOHDNMKPD(CBBHMBIOANA HLOEPFOPLKC, int NBOHPIIGNAJ, int JEAEHHEDCBK, Color PLLINHMEOGD, Color DHPMCCEMKEB, int BEBFCBJBFGK, int DBOKKPCFNMI, Color DHFFEHCJMJL, Color EKLCIAALNHJ, int JKDPEFBLJKH, float PGMNHAMJHAH)
	{
		return default(AJMBKDNNHKC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EF42E0", Offset = "0x5EF2CE0", VA = "0x185EF42E0")]
	public static KKDIJPPEDJA IADOLBALMJC(CBBHMBIOANA HLOEPFOPLKC, Vector2 FBKHAIBCBFN, float FHOJDFMNMBD, Vector2 CGCBHGEOIAL, float PMCNBANEFNK, Vector2 BGKOIHPMLGJ, float MMHJELNPALF, Vector2 MIKPMDBHLLI, float PEPCJPABNEL)
	{
		return default(KKDIJPPEDJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4520", Offset = "0x5EF2F20", VA = "0x185EF4520")]
	public static CHGMIPNOIIB MNOAFICFDAH(Animator MJPMCMJIEIE, OINOEKBNMMI MAECDDMGDID, AvatarConfiguration CNAOIPEGHKI, GameObject OEIEBMPDMJD)
	{
		return default(CHGMIPNOIIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF42A0", Offset = "0x5EF2CA0", VA = "0x185EF42A0")]
	public static IJIHAECAPAF HOIGKJEODOK(Transform DCGFGIJINEH, bool HMGENMCGNDD)
	{
		return default(IJIHAECAPAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF44D0", Offset = "0x5EF2ED0", VA = "0x185EF44D0")]
	public static KPMHICAJMCE KHJAJOODMFM([Optional] GFMBNELHABF? NNNJKIOPKHO, [Optional] int? INHIGKDLABP, [Optional] float? ANFNAJDLJNG, [Optional] float? IGAMMKOBBIL, [Optional] bool? GICJGJHIGCI, [Optional] bool? PGGMLHHEDEE, [Optional] bool? LGDCOGHJGDN, [Optional] GFMBNELHABF? LJONPNNMJEG)
	{
		return default(KPMHICAJMCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NAFKCEJGFBE
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7BC0", Offset = "0x5EF65C0", VA = "0x185EF7BC0")]
	public static GFMBNELHABF CDHFIMFIHKG(this JKKBMMOOKOP MLFBJCPOKDP)
	{
		return default(GFMBNELHABF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JCHAEHFCNAN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Transform EDLKPFGIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HIDAMLDFGNO : JCHAEHFCNAN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Transform EDLKPFGIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x790420", Offset = "0x78EE20", VA = "0x180790420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public Vector3 HGJCOEGINDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCD0FD0", Offset = "0xCCF9D0", VA = "0x180CD0FD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCD0FB0", Offset = "0xCCF9B0", VA = "0x180CD0FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float? ENFCLHHJAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCD0FC0", Offset = "0xCCF9C0", VA = "0x180CD0FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCD0FF0", Offset = "0xCCF9F0", VA = "0x180CD0FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public HIDAMLDFGNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IAHPHAIIJMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	protected readonly HIDAMLDFGNO MNFCIPBJJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	protected readonly HIDAMLDFGNO NIBHMAGBKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	protected readonly HIDAMLDFGNO PFPCOJLOCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	protected readonly HIDAMLDFGNO KILIEEKEDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected readonly HIDAMLDFGNO IBNPGMGOPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected readonly HIDAMLDFGNO HJBLOPGGNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected readonly HIDAMLDFGNO JMCABGELBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected readonly HIDAMLDFGNO HCHPCJMFKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected readonly HIDAMLDFGNO DGPBAMMNMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected readonly HIDAMLDFGNO HFPMGCDIMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected readonly HIDAMLDFGNO BFFHBBGJLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected readonly HIDAMLDFGNO MDOGHHILICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected readonly HIDAMLDFGNO KLLGJFJDEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected HIDAMLDFGNO HMNLPMODLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected readonly HIDAMLDFGNO MJNMGJDOHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected readonly HIDAMLDFGNO KDLKHDOGBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected readonly HIDAMLDFGNO JDHOLJIOIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected HIDAMLDFGNO FPEPAKLGNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected readonly HIDAMLDFGNO ALEMDFNLKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected readonly HIDAMLDFGNO JLKKAFHCAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected readonly HIDAMLDFGNO OEKADPKLGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected ReadOnlyCollection<HIDAMLDFGNO> MHGMPHCOHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Transform CLAOGLINPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private (HIDAMLDFGNO Start, HIDAMLDFGNO End)[] FEOMGPJBJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private Dictionary<string, HIDAMLDFGNO> GBBEBDIMJMM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JCHAEHFCNAN KHLCKPHAFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JCHAEHFCNAN HECBHCGJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JCHAEHFCNAN ONLGAPHDABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JCHAEHFCNAN DLPKDKAGEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JCHAEHFCNAN PGMAOCEEMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JCHAEHFCNAN ADKINPCLBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x793D40", Offset = "0x792740", VA = "0x180793D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HIDAMLDFGNO IJNLKDGEOLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x793D40", Offset = "0x792740", VA = "0x180793D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HIDAMLDFGNO IMACGHGOPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7976F0", Offset = "0x7960F0", VA = "0x1807976F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JCHAEHFCNAN KNGBGALFKNE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78FC90", Offset = "0x78E690", VA = "0x18078FC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JCHAEHFCNAN LOCMELOJMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x78FC80", Offset = "0x78E680", VA = "0x18078FC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public HIDAMLDFGNO OJCMGNGFEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78FC80", Offset = "0x78E680", VA = "0x18078FC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public HIDAMLDFGNO MBNJPDFDHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x78FCB0", Offset = "0x78E6B0", VA = "0x18078FCB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JCHAEHFCNAN CBMFPBDBJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x791C70", Offset = "0x790670", VA = "0x180791C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EF67C0", Offset = "0x5EF51C0", VA = "0x185EF67C0")]
	public void OGBPBGILAJD(VRIK GNJDFDMEILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6140", Offset = "0x5EF4B40", VA = "0x185EF6140")]
	private void FBEMKLLOOPL(Transform DMOGDONOGKM, HIDAMLDFGNO DMFBOAFMPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EF62A0", Offset = "0x5EF4CA0", VA = "0x185EF62A0")]
	public HIDAMLDFGNO JDDCLJPCHHN(string GJBMMFFPGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6310", Offset = "0x5EF4D10", VA = "0x185EF6310")]
	public void JONNHPGNHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EF61D0", Offset = "0x5EF4BD0", VA = "0x185EF61D0")]
	public float IAGPCMLOKMC([In] (HIDAMLDFGNO Start, HIDAMLDFGNO End) IKOADIEPHBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5E80", Offset = "0x5EF4880", VA = "0x185EF5E80")]
	public void AHDHEJMAEDO([In] NFBDDOEPPAF HELMNHPMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6020", Offset = "0x5EF4A20", VA = "0x185EF6020")]
	private Vector3 EANJJDNEDPB([In] (HIDAMLDFGNO Start, HIDAMLDFGNO End) IKOADIEPHBC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF76A0", Offset = "0x5EF60A0", VA = "0x185EF76A0")]
	public IAHPHAIIJMM()
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
		[Cpp2IlInjected.Address(RVA = "0x5EF4170", Offset = "0x5EF2B70", VA = "0x185EF4170")]
		public string OOKKANFFHIG(string LGJLPIFKGHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF41C0", Offset = "0x5EF2BC0", VA = "0x185EF41C0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NGDFIDEPELD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public string MGIGCLCLBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public bool BPPAEFGHMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public bool JCPJDOGIJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public float GFPIPBHJBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public float JDJLAPKJCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool LDECMADELOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Func<IBHDPHPOKGK> AMGHDNKAGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Func<NFBDDOEPPAF> MJADNMKKMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public RigidbodyEx JPDAKJJGHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public RigidbodyEx JPEOCMHMODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public RigidbodyEx MDHOIGGMCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public RigidbodyEx OMDGDNPDHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Transform JJEFABIAIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Transform IDIDGEAAGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public Transform FLPEABLIFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public PlayerAvatarFullBodyColliders GPFGKLHAPIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LDPHMLBGNIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Transform PCFFPJFBKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Transform GGEJLGCHAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public AvatarConfiguration EPDAHOKOAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Animator AMCPPAHMBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public VRIK DALIFNHNOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public GameObject[] BHANPJOAHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Transform BKGOFGACFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public AssetReference NHCOFANDPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public GameObject LDPLEKLOMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public GameObject OFOIDMIGIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public SkinnedMeshRenderer HEKFCEJNPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Material NGAEGNLBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Material AFDDMPPLOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Material HMEDHNAECNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Shader KNHDHKEOEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Shader DIPEAKJNIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Transform MAJBIBBIKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Transform MACPOLHACFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform PMJIBDJHEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Transform CAFFKBLKDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform EGFCIPHHDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Transform IBMILCAMFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Transform MMEEKEJKPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Renderer[] BJMBLIDFLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Transform ICMGELCKEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Transform OKDMFJHANHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public GameObject LEDJFIPKHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public GameObject CEEMHEMGCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public HNMDBONEBPB OEDJMIMGMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public HNMDBONEBPB LFFJDBEBHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public HNMDBONEBPB CLBGJNGNHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public HNMDBONEBPB EIFCBILJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public HNMDBONEBPB EOPHEADMIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public HNMDBONEBPB MKOMOAJEFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public HNMDBONEBPB ODJKMBEHALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public HNMDBONEBPB HBJNHCFNEKL;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct IBHDPHPOKGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool JDPODOOFEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public CPDDDNECHFB MHMNHIDOFHE;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct NFBDDOEPPAF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class BDINOJAALOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public readonly bool DEPFGIIIBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public readonly bool GLJIOPKBNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly bool DFINMLGFBDM;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4210", Offset = "0x5EF2C10", VA = "0x185EF4210")]
		public BDINOJAALOM(bool ALACFACJDFL, bool KDIJIAOEFJA, bool MBDKLJKOJDA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float CALMNLMMBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool EMKPDOKBKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public float AHHDEBOIPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3 CGJHEBICNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 AMAEPEJAPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Vector3? POLDINMHMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Vector3? ENEPHENHEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public bool ABDLDGPOKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool GJELMKLEPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public bool LLJKENFDCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public bool MLFECADNLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Vector3? CJCLGHEJGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool PLKJEDINFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Vector3? CDIJFEGPFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public bool ELGJJOPKAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Vector3? MEFHHNMAEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public float MEAOCCFINGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Vector3? DACNOCEDAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public bool BEKNGOEIPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public bool ABKAFBBOEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool GHPGHDLPOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool ADDAKOPKKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool ELPNIJPCKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool MNOIKABKPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool PEHFEMGIOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool LCEIOJBJCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool IOPFAMIEAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public bool ANDIIPBOJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public bool MIFIIKOKIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3? LEBCALCJDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public JKKBMMOOKOP KHEEPLNFEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public JKKBMMOOKOP CCJCAEEHLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public float FOFNJONPBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public float EGEFBBANPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public BDINOJAALOM PPMEMDNJDDA;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7C20", Offset = "0x5EF6620", VA = "0x185EF7C20")]
	public void HPIMENCMGNE(Quaternion KPKKBKKOGOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JALGFHAHLFM
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7BA0", Offset = "0x5EF65A0", VA = "0x185EF7BA0")]
	public static AGOPKGAFNNB NIDPCNBIHDF(this HNEMCKPMAJP JFFAAHPEFOB)
	{
		return default(AGOPKGAFNNB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7B80", Offset = "0x5EF6580", VA = "0x185EF7B80")]
	public static void CCAGKPFBMLN(this HNEMCKPMAJP JFFAAHPEFOB, AGOPKGAFNNB BEEGCHJLJFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HNMDBONEBPB
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void UpdateController(float HNNKCGDCJIJ);
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private OOCOCLLNIGB MKMGGBKMICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private Collider[] PBFNAKAJACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private (Transform parent, Vector3 localPosition, Quaternion localRotation, Vector3 localScale)[] NNEDFEIALNK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IReadOnlyList<Collider> IKAMDLCELBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5EF8A20", Offset = "0x5EF7420", VA = "0x185EF8A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private OOCOCLLNIGB EJMNMAFMPLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5EF8040", Offset = "0x5EF6A40", VA = "0x185EF8040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MLGAOLMBGLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCA16D0", Offset = "0xCA00D0", VA = "0x180CA16D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8A00", Offset = "0x5EF7400", VA = "0x185EF8A00")]
		public void UpdateBonesToMatchSkinnedMeshRenderer(SkinnedMeshRenderer JAOPFBICAKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EF87B0", Offset = "0x5EF71B0", VA = "0x185EF87B0")]
		public void SetCollidersEnabled(bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8380", Offset = "0x5EF6D80", VA = "0x185EF8380")]
		public void ReparentBonesUnderOtherBoneCollection(OOCOCLLNIGB CGPFGFLOIND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EF80E0", Offset = "0x5EF6AE0", VA = "0x185EF80E0")]
		public void ParentBonesBackToOriginalTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EMFBINBEABL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Transform GJNODFGKBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Transform GFBHNGGOIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Transform GLLAIHEJEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Transform BBGNMLNDEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform GAJLKFLNNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform HDIGJNMNOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform FDHNABCEDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Transform BFJJHPFOPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Transform KHIDDNAMPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private PositionAndRotation IPJNAECPFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation OKKDBFPOPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private PositionAndRotation DFGEKKEFDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PositionAndRotation EHHJONPFDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private PositionAndRotation BKDEDPJPKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private PositionAndRotation HBFFJPFJFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private PositionAndRotation PHHLGAIKDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PositionAndRotation KGKJMLBMEBP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4FF0", Offset = "0x5EF39F0", VA = "0x185EF4FF0")]
	public void IAMMEFBKIFH(Transform FPMNFDPIOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5900", Offset = "0x5EF4300", VA = "0x185EF5900")]
	public void OKEDLBCJHGA(HandLogicOffsets IOPKMPOHNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF56B0", Offset = "0x5EF40B0", VA = "0x185EF56B0")]
	public void IHNGEOLNNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4C50", Offset = "0x5EF3650", VA = "0x185EF4C50")]
	private PositionAndRotation BLKIHALHHJE(Transform AJDCHMHOLMH, Transform BEBKPOOFCGE)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4D20", Offset = "0x5EF3720", VA = "0x185EF4D20")]
	private void FCBLOMPDIMK(Transform AJDCHMHOLMH, Transform BEBKPOOFCGE, PositionAndRotation IOPKMPOHNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public EMFBINBEABL()
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
