using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AvatarSelectionElement : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string Guid;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6CF19A0", Offset = "0x6CF0BA0", VA = "0x186CF19A0")]
	public AvatarSelectionElement()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public GHPGHMJFCDB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct AvatarHairPatternOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public string PatternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Texture2D Texture;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FBAFMMHEDFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Transform CJLNOCNGNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public GameObject FIHFENHJJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public SkinnedMeshRenderer[] BBKGBEPBLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public SkinnedMeshRenderer[] KPEELJMCBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GameObject KLKABGHNGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public SkinnedMeshRenderer[] CIDOOJPJCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public SkinnedMeshRenderer[] PJKJMNKHIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public LPBJEJAENEH EMODKPINOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Material LIOOCCAIJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Material NIEEBBPLELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Shader AIGFCAIHHAP;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PPACHLHGIOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool CIDACICEKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool MPGMDEPCMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool PGGKHOFNKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool AKJOEDOAMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool AMMMNEBJEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool GMGDBDPEKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool KGPGNFHOGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public IList<EIKMBILGGCM> KDEPOMGAJMM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public PPACHLHGIOF()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private LPBJEJAENEH NBOLPDMFAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Collider[] MPIHAPFBIIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Collider[] GKCECBKIGIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6CF8150", Offset = "0x6CF7350", VA = "0x186CF8150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6CF80D0", Offset = "0x6CF72D0", VA = "0x186CF80D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8300", Offset = "0x6CF7500", VA = "0x186CF8300")]
		public void UpdateBones(LPBJEJAENEH MFCBMPKONIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6CF81C0", Offset = "0x6CF73C0", VA = "0x186CF81C0")]
		public void SetCollidersEnabled(bool IKKHNLLIAGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8330", Offset = "0x6CF7530", VA = "0x186CF8330")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BNJHGGMMBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1B20", Offset = "0x6CF0D20", VA = "0x186CF1B20")]
	public static bool HGFKGECDCOD(this OutfitType PNDMPAEJEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1B40", Offset = "0x6CF0D40", VA = "0x186CF1B40")]
	public static bool KEJBBGENCDI(this OutfitType PNDMPAEJEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1B00", Offset = "0x6CF0D00", VA = "0x186CF1B00")]
	public static bool ALGFKBGGHCA(this OutfitType PNDMPAEJEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1B10", Offset = "0x6CF0D10", VA = "0x186CF1B10")]
	public static bool DDHEDEGJAEG(this OutfitType PNDMPAEJEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1B60", Offset = "0x6CF0D60", VA = "0x186CF1B60")]
	public static bool LFOIGFCLGHD(this OutfitType PNDMPAEJEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1B70", Offset = "0x6CF0D70", VA = "0x186CF1B70")]
	public static bool PHFFMCMFKFI(this OutfitType PNDMPAEJEBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct HNHNHGBLFFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Transform EBMAHGLJFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Transform DLJCCBFOGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Transform EEIHEJNHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Transform MDFFKFGHAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Transform GJPKCPCKEEG;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct HCMGLLCAOGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public SkinnedMeshRenderer[] EHGEPDIGDHF;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BIDKMGBKDEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public PNGFNKOELFA LLGPCMFAHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int DCLPGJIGBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int HHJPCLONMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color MHJJAHBLEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color IBKFDALIFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int NHOOCOFGFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int LABBPDEFPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color ELDLCAMDALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Color HHBJNCDDAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int GOKIAKOIJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float IOCCJNHJPFM;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct HHJJEMONJKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public PNGFNKOELFA LLGPCMFAHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 NDMMACKFGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float OPLHNMOICHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 CDADKBEMFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float LONBEJOKKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 DIEHBECALNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float AEPLHJOJPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float BGNDPFBDLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 DEAEEKKOHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 LMBACPHIKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool HLKGDHKOALI;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC7A8A0", Offset = "0xC79AA0", VA = "0x180C7A8A0")]
		protected AvatarConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1A60", Offset = "0x6CF0C60", VA = "0x186CF1A60")]
		public string JCGAOPHJCAL(string GDPKBLAHHNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1AB0", Offset = "0x6CF0CB0", VA = "0x186CF1AB0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum EIFAPAEKOPN
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CFFHEFBJFMN
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly CFFHEFBJFMN OONGDIKAKHH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DABMHEALGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x841A60", Offset = "0x840C60", VA = "0x180841A60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x841E20", Offset = "0x841020", VA = "0x180841E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EIFAPAEKOPN NDKMJHBPOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x841C80", Offset = "0x840E80", VA = "0x180841C80")]
		[CompilerGenerated]
		get
		{
			return default(EIFAPAEKOPN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x841E30", Offset = "0x841030", VA = "0x180841E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CFFHEFBJFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2440", Offset = "0x6CF1640", VA = "0x186CF2440")]
	public CFFHEFBJFMN(EIFAPAEKOPN LLKIENGKJDC, int NLJBOFEBCEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CGOCPCIPOBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Mesh NGJJMKJDALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Material[] NIEKPOGOENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool HFFHKMKPIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool DGAFMDHEJFE;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	private CGOCPCIPOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6CF27F0", Offset = "0x6CF19F0", VA = "0x186CF27F0")]
	public CGOCPCIPOBP(Mesh BOIPJLCFOOL, Material[] KBHHAKCKJBG, bool GIKFJJJNLHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2900", Offset = "0x6CF1B00", VA = "0x186CF2900")]
	public CGOCPCIPOBP(SkinnedMeshRenderer GFADDOCPCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2480", Offset = "0x6CF1680", VA = "0x186CF2480")]
	public static CGOCPCIPOBP CNAJBHFHNIN(Renderer MEIDGKDNIIE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct DOCPBAJPLBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly GameObject MHOJHMGLBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly AvatarItemMaterial PAGKILCEFBK;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
	public DOCPBAJPLBG(GameObject MHOJHMGLBHC, AvatarItemMaterial PAGKILCEFBK)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarItemMaterial : AvatarSelectionElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1940", Offset = "0x6CF0B40", VA = "0x186CF1940")]
		public static void IAIIDMOILJC(AvatarItemMaterial KJCMEPHOJCF, Material LGBCNNOGHMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6CF19A0", Offset = "0x6CF0BA0", VA = "0x186CF19A0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GIOCJAFLHBK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Transform CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Vector3 GPFNBCIEEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EMCDLHNAJEC : GIOCJAFLHBK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Transform CMDBMJDLKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8F7D20", Offset = "0x8F6F20", VA = "0x1808F7D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 GPFNBCIEEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x12F74E0", Offset = "0x12F66E0", VA = "0x1812F74E0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x12F6E20", Offset = "0x12F6020", VA = "0x1812F6E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float? LGICCOCGIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1A29120", Offset = "0x1A28320", VA = "0x181A29120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1A29110", Offset = "0x1A28310", VA = "0x181A29110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public EMCDLHNAJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MIGIDHJBIOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly EMCDLHNAJEC CDHOLMLNBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly EMCDLHNAJEC JBKFKAMHHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly EMCDLHNAJEC KGHAFBCCPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly EMCDLHNAJEC AOBHACENMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly EMCDLHNAJEC IBFNPHFCKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly EMCDLHNAJEC GLBHHPCMNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly EMCDLHNAJEC MCFNAPPLIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly EMCDLHNAJEC BMPEDCBAJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly EMCDLHNAJEC FBFMAPFMHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly EMCDLHNAJEC DBJKEGOFKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly EMCDLHNAJEC PHANJGGGMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly EMCDLHNAJEC LBNEJKCDPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly EMCDLHNAJEC BNANNDGHLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected EMCDLHNAJEC MPMLFGGMNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected readonly EMCDLHNAJEC BBKEICCGNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	protected readonly EMCDLHNAJEC BDOOMIJDJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	protected readonly EMCDLHNAJEC KBCJOOHODHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected EMCDLHNAJEC KIPICBJGPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected readonly EMCDLHNAJEC OIAIBMEMPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected readonly EMCDLHNAJEC FMBLEHECLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	protected readonly EMCDLHNAJEC FFNDGDJPLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected ReadOnlyCollection<EMCDLHNAJEC> BIGGGCLJFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform COHIGCNKOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private (EMCDLHNAJEC Start, EMCDLHNAJEC End)[] NDCAIHEAFNK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GIOCJAFLHBK JCCJOKHBAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8D4AB0", Offset = "0x8D3CB0", VA = "0x1808D4AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public GIOCJAFLHBK CPEBPJPEGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GIOCJAFLHBK FBMCMOFKBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GIOCJAFLHBK JKGJEHKCJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public GIOCJAFLHBK EIPEHEPHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public GIOCJAFLHBK DBLFHIOHCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8293D0", Offset = "0x8285D0", VA = "0x1808293D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public GIOCJAFLHBK EBKEICJDBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public EMCDLHNAJEC IKHCEPKOAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x826EA0", Offset = "0x8260A0", VA = "0x180826EA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public GIOCJAFLHBK JEDEAGKNOGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EMCDLHNAJEC PJOHDDBPAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GIOCJAFLHBK NJCOEDMNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8EE410", Offset = "0x8ED610", VA = "0x1808EE410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GIOCJAFLHBK ACKNIGDEFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8D6BE0", Offset = "0x8D5DE0", VA = "0x1808D6BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GIOCJAFLHBK EGGMEPHKNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EMCDLHNAJEC IMNMNIMJOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EMCDLHNAJEC JCNOBNBDMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8EE430", Offset = "0x8ED630", VA = "0x1808EE430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GIOCJAFLHBK GAAFFBDBJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8EE430", Offset = "0x8ED630", VA = "0x1808EE430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GIOCJAFLHBK PGCLINGKGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3B0", Offset = "0x8ED5B0", VA = "0x1808EE3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GIOCJAFLHBK GONCFDKINPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3C0", Offset = "0x8ED5C0", VA = "0x1808EE3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GIOCJAFLHBK ACDMOLMEKHK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x912480", Offset = "0x911680", VA = "0x180912480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public GIOCJAFLHBK HEIAGHGIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE60", Offset = "0x8DE060", VA = "0x1808DEE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public GIOCJAFLHBK KGAENDFIKDD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF00", Offset = "0x8DE100", VA = "0x1808DEF00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public GIOCJAFLHBK GMJGKHAIIKL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x912450", Offset = "0x911650", VA = "0x180912450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public GIOCJAFLHBK PFKLCPGHFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3D0", Offset = "0x8ED5D0", VA = "0x1808EE3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GIOCJAFLHBK CPBLPNCAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3E0", Offset = "0x8ED5E0", VA = "0x1808EE3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public GIOCJAFLHBK DHALELGCNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8EE400", Offset = "0x8ED600", VA = "0x1808EE400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyList<GIOCJAFLHBK> DEFLJJOFAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8EE3F0", Offset = "0x8ED5F0", VA = "0x1808EE3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6CF5E80", Offset = "0x6CF5080", VA = "0x186CF5E80")]
	public void KGBGOLGPHLO(VRIK OFHHJLIKAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3B75310", Offset = "0x3B74510", VA = "0x183B75310")]
	private void PGMNLEPHINN(Transform PHDPIMPEHFJ, EMCDLHNAJEC PDDCMNAKECC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6870", Offset = "0x6CF5A70", VA = "0x186CF6870")]
	public void OHLDBLHCFOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B729E0", Offset = "0x3B71BE0", VA = "0x183B729E0")]
	public float JDLIDBJGJMP(in (EMCDLHNAJEC Start, EMCDLHNAJEC End) BCALBAHMBBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6CF5B40", Offset = "0x6CF4D40", VA = "0x186CF5B40")]
	public void ABAEBOEIDEF(in FBJDFBFNHPH OJBGFLKOHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6CF5D20", Offset = "0x6CF4F20", VA = "0x186CF5D20")]
	private Vector3 DLEFDKOGIDH(in (EMCDLHNAJEC Start, EMCDLHNAJEC End) BCALBAHMBBK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6D20", Offset = "0x6CF5F20", VA = "0x186CF6D20")]
	public MIGIDHJBIOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LPBJEJAENEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private List<Transform> NOOFJOJGPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Matrix4x4[] KAAFDFMKOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Dictionary<string, Transform> JMJJJAECHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private Dictionary<Transform, Transform> NPNIIJNMBDN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Transform[] GLJJAIGLBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CF5300", Offset = "0x6CF4500", VA = "0x186CF5300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Matrix4x4[] NFFIOMFGGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x96EA60", Offset = "0x96DC60", VA = "0x18096EA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6CF5350", Offset = "0x6CF4550", VA = "0x186CF5350")]
	public void EKELHCGKCHI(SkinnedMeshRenderer MEIDGKDNIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6CF5670", Offset = "0x6CF4870", VA = "0x186CF5670")]
	public void IMHPPELBAJE(Transform EIHBKIACPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6CF56E0", Offset = "0x6CF48E0", VA = "0x186CF56E0")]
	private Transform NIKHFJLOADK(Transform DHNLGGAGJFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6CF57C0", Offset = "0x6CF49C0", VA = "0x186CF57C0")]
	public void ODIFPAINMKN(LPBJEJAENEH GFHFDCCPLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6CF5500", Offset = "0x6CF4700", VA = "0x186CF5500")]
	private void FJDCLFKKJEG(Transform NPDELNKHCNM, List<Transform> DCLLBMFALAJ, Dictionary<string, Transform> JFBNGLOICOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6CF5A40", Offset = "0x6CF4C40", VA = "0x186CF5A40")]
	public LPBJEJAENEH()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum JPIJGOGEPLN
		{
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private const int SERIALIZATION_VERSION = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private string eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private JPIJGOGEPLN useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private string baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public string EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1CCE350", Offset = "0x1CCD550", VA = "0x181CCE350")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x98C980", Offset = "0x98BB80", VA = "0x18098C980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB0D690", Offset = "0xB0C890", VA = "0x180B0D690")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB0DB90", Offset = "0xB0CD90", VA = "0x180B0DB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x943020", Offset = "0x942220", VA = "0x180943020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB0D700", Offset = "0xB0C900", VA = "0x180B0D700")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA1BC50", Offset = "0xA1AE50", VA = "0x180A1BC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x18EA630", Offset = "0x18E9830", VA = "0x1818EA630")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x125BA90", Offset = "0x125AC90", VA = "0x18125BA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8D6BF0", Offset = "0x8D5DF0", VA = "0x1808D6BF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x983E90", Offset = "0x983090", VA = "0x180983E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x15519C0", Offset = "0x1550BC0", VA = "0x1815519C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA64A0", Offset = "0xAA56A0", VA = "0x180AA64A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x991CE0", Offset = "0x990EE0", VA = "0x180991CE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x991C40", Offset = "0x990E40", VA = "0x180991C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x8EE420", Offset = "0x8ED620", VA = "0x1808EE420")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x93C0D0", Offset = "0x93B2D0", VA = "0x18093C0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8EE430", Offset = "0x8ED630", VA = "0x1808EE430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x93C0B0", Offset = "0x93B2B0", VA = "0x18093C0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8EE3B0", Offset = "0x8ED5B0", VA = "0x1808EE3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x900430", Offset = "0x8FF630", VA = "0x180900430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8EE3C0", Offset = "0x8ED5C0", VA = "0x1808EE3C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x90DFB0", Offset = "0x90D1B0", VA = "0x18090DFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x912480", Offset = "0x911680", VA = "0x180912480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x90DF90", Offset = "0x90D190", VA = "0x18090DF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8DEE60", Offset = "0x8DE060", VA = "0x1808DEE60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x939B80", Offset = "0x938D80", VA = "0x180939B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8DEF00", Offset = "0x8DE100", VA = "0x1808DEF00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xABAFC0", Offset = "0xABA1C0", VA = "0x180ABAFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x912450", Offset = "0x911650", VA = "0x180912450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xABB1B0", Offset = "0xABA3B0", VA = "0x180ABB1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xEC2DF0", Offset = "0xEC1FF0", VA = "0x180EC2DF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xEC2E00", Offset = "0xEC2000", VA = "0x180EC2E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public JPIJGOGEPLN UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6CF1860", Offset = "0x6CF0A60", VA = "0x186CF1860")]
			get
			{
				return default(JPIJGOGEPLN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x107CE10", Offset = "0x107C010", VA = "0x18107CE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xBFB0B0", Offset = "0xBFA2B0", VA = "0x180BFB0B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xBFB160", Offset = "0xBFA360", VA = "0x180BFB160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6CF1840", Offset = "0x6CF0A40", VA = "0x186CF1840")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6CF1920", Offset = "0x6CF0B20", VA = "0x186CF1920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x935BB0", Offset = "0x934DB0", VA = "0x180935BB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6CF1880", Offset = "0x6CF0A80", VA = "0x186CF1880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x14591C0", Offset = "0x14583C0", VA = "0x1814591C0")]
		public string IOEANABOGCL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1410", Offset = "0x6CF0610", VA = "0x186CF1410")]
		public static AvatarCustomizationSettings AKLCAJOKCCK(string PLBIEEFAOCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6CF15B0", Offset = "0x6CF07B0", VA = "0x186CF15B0")]
		public AvatarCustomizationSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum JHECAPNFMEG
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum DMINIILHLNP
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum OHMHPALNPAN
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Flags]
public enum IDOAMHLHJEH
{
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum AOBGAOFNFLD
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum OCDDBCHPNGG
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum FKBHKCGGEBD
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum KMGOGBPJCHF
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum EHELDNMNLDA
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DMGCFGPMAHA
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly int IMBCBBIJJKG;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static readonly string LDLBKIGDDCC;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static readonly string AODPNHDLGLC;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2A20", Offset = "0x6CF1C20", VA = "0x186CF2A20")]
	public static FBJDFBFNHPH DBIMKOOHMLB()
	{
		return default(FBJDFBFNHPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6CF30D0", Offset = "0x6CF22D0", VA = "0x186CF30D0")]
	public static GLLCAEAEONB OKPPFAAANJI(Transform ODAELDOHFOA, Transform IJPPCFCODNE, AvatarConfiguration GPNCDFDBEDA, Animator ONPJGMKMKJI, VRIK PNEALIJKKLK, SkeletonLODUpdateRate[] MNMOPDGDCPC, GameObject[] FHPELCKKNEL, Transform COHIGCNKOBG, GameObject LOJFKMLJGOC, BodySkinnedMeshLODs MPGGLGGBFPH, BodySkinnedMeshLODs AIOFIBAGMGE, GameObject AIMOPPDKLBP, BodySkinnedMeshLODs HIBFHGFEKJG, BodySkinnedMeshLODs CENJJOEOOHM, LPBJEJAENEH MFCBMPKONIC, Material PKDCIOIEKLP, Material DCOCEOPPLLE, Shader GMNCPDCBDGB, Transform LPNNKFICNII, Transform KGLNOBJPMPP, Transform IPEJLHCJNGO, Transform FPFKFAIALIN, Transform CKCGBEGPJCN)
	{
		return default(GLLCAEAEONB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2AF0", Offset = "0x6CF1CF0", VA = "0x186CF2AF0")]
	public static EIMONHJBEDG HHGIGGBNKOL(string AFOKIKOJKOM, bool KDABPGMIJEL, bool PKGPHIGFPDP, bool AMEAJOBPLII, RigidbodyEx GJCDEJPKDFG, RigidbodyEx IJFBGFPILNP, RigidbodyEx GOOBMAGADPH, RigidbodyEx PGGCBCGCMCK, Transform JFJFCBHOHDA, Transform BJIDFIJELGE, Transform DJLDJIJFOAB, float OGGBGBJOGKH, float BLBOFHJOCCO, PlayerAvatarFullBodyColliders IJMIOPAAFFC)
	{
		return default(EIMONHJBEDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2C50", Offset = "0x6CF1E50", VA = "0x186CF2C50")]
	public static FBAFMMHEDFK HMOIFFGEGBA(Transform IJPPCFCODNE, GameObject LOJFKMLJGOC, SkinnedMeshRenderer[] AELDHIJCGOA, SkinnedMeshRenderer[] BHODHMMIFBH, GameObject AIMOPPDKLBP, SkinnedMeshRenderer[] BNHPGDEDBON, SkinnedMeshRenderer[] KPOABGBNBGG, LPBJEJAENEH MFCBMPKONIC, Material PKDCIOIEKLP, Material DCOCEOPPLLE, Shader GMNCPDCBDGB)
	{
		return default(FBAFMMHEDFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2ED0", Offset = "0x6CF20D0", VA = "0x186CF2ED0")]
	public static HNHNHGBLFFP NAGFHNCLHLI(Transform LPNNKFICNII, Transform IPEJLHCJNGO, Transform KGLNOBJPMPP, Transform FPFKFAIALIN, Transform CKCGBEGPJCN)
	{
		return default(HNHNHGBLFFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x141E120", Offset = "0x141D320", VA = "0x18141E120")]
	public static HCMGLLCAOGM MEOKMGIKEGM(SkinnedMeshRenderer[] KCCKCEFFNKB)
	{
		return default(HCMGLLCAOGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2DB0", Offset = "0x6CF1FB0", VA = "0x186CF2DB0")]
	public static BIDKMGBKDEC KCHLBIGOJJP(PNGFNKOELFA EEGBIHNMJEA, int IGNIANHFJPN, int KDNMENJGNLO, Color GCDNBAMKEGE, Color MKMDMDNIBME, int JJCDEMGOFHO, int AJOABGOBHMH, Color CDDPDDGIFPF, Color HCBHHDINFIG, int FIPHOFEEEKG, float MPEHIFMGECH)
	{
		return default(BIDKMGBKDEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6CF2FA0", Offset = "0x6CF21A0", VA = "0x186CF2FA0")]
	public static HHJJEMONJKK NDMFJGNECBB(PNGFNKOELFA EEGBIHNMJEA, Vector2 MEEPINAIOJA, float FABFFHODMJD, Vector2 HMOKCOKLNAL, float AJBMBMJNLFI, Vector2 JGEMHOIDBFI, float KOEFBFONLNL, float LIKHLMEMLGJ, Vector2 IIGADPANIFB, Vector2 DGCGPHBLADK)
	{
		return default(HHJJEMONJKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface EICCOMFNNBB
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJFBGELMDCG();

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GHFDPPJAELF<Texture2D> KADECEOKABK(DHKPHIAECBH IJMMJFGKFKD, [Optional] CFFHEFBJFMN OGEINKONADM);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class CCKLENHJKLL : EICCOMFNNBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private HLBKEKNJGKK AAANEGLIBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private IRecRoomQualityConfigProvider LPEBLCHDPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool EAKBIDEMMAK;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private const uint MMKHGNKJJFE = 16u;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1D00", Offset = "0x6CF0F00", VA = "0x186CF1D00")]
	[MPKPGFJAEKF(OJBJGAAILBP.GameOnly)]
	private static void IPFHOBEMGIF(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xAF6770", Offset = "0xAF5970", VA = "0x180AF6770")]
	[Preserve]
	public CCKLENHJKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1C50", Offset = "0x6CF0E50", VA = "0x186CF1C50")]
	private void ICBAFFCGBHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1BF0", Offset = "0x6CF0DF0", VA = "0x186CF1BF0", Slot = "4")]
	public void GJFBGELMDCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1FB0", Offset = "0x6CF11B0", VA = "0x186CF1FB0", Slot = "5")]
	public GHFDPPJAELF<Texture2D> KADECEOKABK(DHKPHIAECBH IJMMJFGKFKD, [Optional] CFFHEFBJFMN OGEINKONADM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6CF1DF0", Offset = "0x6CF0FF0", VA = "0x186CF1DF0")]
	private uint JLINOOGFBMF(DHKPHIAECBH IJMMJFGKFKD, CFFHEFBJFMN OGEINKONADM)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct EIMONHJBEDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public string JIKFECNJLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public bool JNCNJGEDDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public bool EBHBJGDIPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public float DLLOMEGGGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public float BLMABJCGLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public bool DAABLCHLMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public RigidbodyEx LOMKFCBNGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public RigidbodyEx JFDLPCEMMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public RigidbodyEx FPHGBFPLGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public RigidbodyEx DILLLKCDGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public Transform DAMJKBINECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform IJLELNHAMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform OKPEKJFJDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public PlayerAvatarFullBodyColliders ONKFILKGDNP;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct GLLCAEAEONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform FHHHDKAHHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform BBCKDPKGPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public AvatarConfiguration BDCIKJDHFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Animator KJOGEDKNBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public VRIK ENENEOEKBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public SkeletonLODUpdateRate[] EJNDGOIALPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public GameObject[] NGHCOIJCCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform KEKHCCKLFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public GameObject FIHFENHJJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public BodySkinnedMeshLODs CMANHGHJKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public BodySkinnedMeshLODs DPGAHNDJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public GameObject KLKABGHNGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public BodySkinnedMeshLODs LJDINBGDCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public BodySkinnedMeshLODs OPBEGHEDHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public LPBJEJAENEH EMODKPINOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Material LIOOCCAIJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Material NIEEBBPLELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Shader AIGFCAIHHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Transform EBMAHGLJFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Transform EEIHEJNHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform DLJCCBFOGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Transform MDFFKFGHAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform GJPKCPCKEEG;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct FBJDFBFNHPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public float HGMDHOGALIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool OOLJMKLPICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public GHPGHMJFCDB AHLOMNMEEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 LACNNHACBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 FFLBGAOMHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3? FNGDMLJILPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public Vector3? EHNKEBMBHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool LDHEAKLJPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool MAEPBBFFNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool DALFMPKMDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public bool HPDEIGJFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public bool ELKAGOLKAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Vector3? NOPNINLODJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool BCLIODGGEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public Vector3? PLHBAEDHHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool PDIGDCDPGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3? HEBNGOMNPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3? IDPOFJBLNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public bool CBLAKLLCLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool BDNFHGMOAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool FAPHDMJBFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool BIGJMFMOAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool LNODALOBLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool BLCMLMCGHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool GBCPKIKGNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool DJOPFHMFHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool IMDJBMANHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool ACFCFHJLAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? CDKDMFMHHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public JHECAPNFMEG GKNEEJLFADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public JHECAPNFMEG CCCPBPJGGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float HFBODPABHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public float LMLBAGNBEKK;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6CF5110", Offset = "0x6CF4310", VA = "0x186CF5110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6CF5050", Offset = "0x6CF4250", VA = "0x186CF5050")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4B30", Offset = "0x6CF3D30", VA = "0x186CF4B30")]
		public void OGHODAFPIEH(FitMeshHemisphere CHHAJGIADLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4B80", Offset = "0x6CF3D80", VA = "0x186CF4B80")]
		public Vector3 OHLFIGFMPCN(Vector2 AGIGAFDMFJP, bool JIGFPLHGHPF = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4820", Offset = "0x6CF3A20", VA = "0x186CF4820")]
		public Vector3 DGDAAAMPPAL(Vector2 AGIGAFDMFJP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4890", Offset = "0x6CF3A90", VA = "0x186CF4890")]
		public Quaternion DIKEMDPBNOG(Vector2 AGIGAFDMFJP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6CF49D0", Offset = "0x6CF3BD0", VA = "0x186CF49D0")]
		public Quaternion DIKEMDPBNOG(Vector2 AGIGAFDMFJP, Vector3 BCOFCBHAAKG)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4AF0", Offset = "0x6CF3CF0", VA = "0x186CF4AF0")]
		private Vector2 LHCHLHKNNAN(Vector2 EEFNJEEMEKK)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class EIKMBILGGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public string AOPINHAKJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public OutfitType BDFDDAJGBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public OHMHPALNPAN BIDJIDBBBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public bool BLHJNNMDOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public Color? FLFLEANLADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Vector3? GLBHGIKFGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public float? CEMHLLLBEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public Guid? BKGCJEAFFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public HNMOELBCPMF? DGHEPBDNDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Color? MFMOOAHPKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool EOJPPCBGPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool AADBGOLPKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public AnchorParamsRestrictions GBMBHMLADDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public Vector2? AILHELJFILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public Transform IIGNOIHAGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public FitMeshHemisphere BEEPKACBILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public Vector2 GLFKOCIHLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private List<AvatarHairPatternOverride> JCCNKLNIKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Dictionary<string, Texture2D> NNLBIPMOMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private List<AvatarHairPatternOverride> GBDDBDIKIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Dictionary<string, Texture2D> FHAODBKCNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public AssetReference PMIIBFLADCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public AssetReference MPGNNAIHPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public AssetReference[] NNHIHFLIMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public bool PAMECGNDCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public bool JGIHBACMJBE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public List<AvatarHairPatternOverride> HPHFNEIAHJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCB62F0", Offset = "0xCB54F0", VA = "0x180CB62F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3650", Offset = "0x6CF2850", VA = "0x186CF3650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public List<AvatarHairPatternOverride> JPEHHENJEJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCB6310", Offset = "0xCB5510", VA = "0x180CB6310")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3420", Offset = "0x6CF2620", VA = "0x186CF3420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string GNCJFEGHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3880", Offset = "0x6CF2A80", VA = "0x186CF3880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CF3930", Offset = "0x6CF2B30", VA = "0x186CF3930")]
	public EIKMBILGGCM()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct AnchorParams : IEquatable<AnchorParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Vector2 NormalizedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public Vector3 HemisphereOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Vector3 HemisphereRotations;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static AnchorParams Default
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6CF13A0", Offset = "0x6CF05A0", VA = "0x186CF13A0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1200", Offset = "0x6CF0400", VA = "0x186CF1200")]
		public AnchorParams(Vector2 BGBOEEBDOBG, Vector3 PFEMABDEOGN, Vector3 DNEGGDLGIAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1230", Offset = "0x6CF0430", VA = "0x186CF1230")]
		public AnchorParams(GJLNJGPEAGD PJMHLIICMIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1110", Offset = "0x6CF0310", VA = "0x186CF1110", Slot = "4")]
		public bool Equals(AnchorParams HPOECFLNEOJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface GJLNJGPEAGD
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool KDIOPLLCMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool JAPBBBHMIMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool AEILNHLJOLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool JHKALADFLJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool KHJEIEHKMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool CHCDGCMPIPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool JJGGKPCCIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool OKDIGJOGGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float MCJGCIGPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float PEEMFCDEFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float MLKFLEAICOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float LBIFPEKLBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float JMCJMEDGPBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	float KNHBDPHDEBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float MNMCCLJDAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float PPBNGHFHONB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	float AHFAKPLIGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float NONLKFEGGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float LAHNDDKCHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float JIFPKFKCNML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float MNDBOOIFEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float HIGJJKLFEMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float DMAFAMPIABO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float BPKIDMKPHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 INJHIOACDOI(Vector3 DNEGGDLGIAN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 BADLGHEONBO(Vector3 JLLAAAJKFDN);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 DECLAGJEEFA();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 ILLGOBGLHJG();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AnchorParamsRestrictions : GJLNJGPEAGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool GetAllowTranslationX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6CF1080", Offset = "0x6CF0280", VA = "0x186CF1080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6CF10B0", Offset = "0x6CF02B0", VA = "0x186CF10B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6CF10E0", Offset = "0x6CF02E0", VA = "0x186CF10E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6CF0FF0", Offset = "0x6CF01F0", VA = "0x186CF0FF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6CF1020", Offset = "0x6CF0220", VA = "0x186CF1020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6CF1050", Offset = "0x6CF0250", VA = "0x186CF1050", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xA25640", Offset = "0xA24840", VA = "0x180A25640", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x1146C10", Offset = "0x1145E10", VA = "0x181146C10", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1136680", Offset = "0x1135880", VA = "0x181136680", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x11436A0", Offset = "0x11428A0", VA = "0x1811436A0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x1079460", Offset = "0x1078660", VA = "0x181079460", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x1076960", Offset = "0x1075B60", VA = "0x181076960", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1079470", Offset = "0x1078670", VA = "0x181079470", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x10F69C0", Offset = "0x10F5BC0", VA = "0x1810F69C0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x110C730", Offset = "0x110B930", VA = "0x18110C730", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x125BA30", Offset = "0x125AC30", VA = "0x18125BA30", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x125B9D0", Offset = "0x125ABD0", VA = "0x18125B9D0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x125B9E0", Offset = "0x125ABE0", VA = "0x18125B9E0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x514AAF0", Offset = "0x5149CF0", VA = "0x18514AAF0", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1B913C0", Offset = "0x1B905C0", VA = "0x181B913C0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2B2D230", Offset = "0x2B2C430", VA = "0x182B2D230", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x122AC30", Offset = "0x1229E30", VA = "0x18122AC30", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6577CA0", Offset = "0x6576EA0", VA = "0x186577CA0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2553410", Offset = "0x2552610", VA = "0x182553410", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0F60", Offset = "0x6CF0160", VA = "0x186CF0F60")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0B50", Offset = "0x6CEFD50", VA = "0x186CF0B50")]
		public AnchorParams BBPCPNDGFPP(AnchorParams ADOCLEPGGJP)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0E80", Offset = "0x6CF0080", VA = "0x186CF0E80", Slot = "30")]
		public Vector3 DECLAGJEEFA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0EB0", Offset = "0x6CF00B0", VA = "0x186CF0EB0", Slot = "31")]
		public Vector3 ILLGOBGLHJG()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0EE0", Offset = "0x6CF00E0", VA = "0x186CF0EE0", Slot = "28")]
		public Vector3 INJHIOACDOI(Vector3 DNEGGDLGIAN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0AC0", Offset = "0x6CEFCC0", VA = "0x186CF0AC0", Slot = "29")]
		public Vector3 BADLGHEONBO(Vector3 JLLAAAJKFDN)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8F2F00", Offset = "0x8F2100", VA = "0x1808F2F00", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6CF70C0", Offset = "0x6CF62C0", VA = "0x186CF70C0")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private Dictionary<string, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x6CF4800", Offset = "0x6CF3A00", VA = "0x186CF4800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6CF42B0", Offset = "0x6CF34B0", VA = "0x186CF42B0")]
		public PNGFNKOELFA LGCLMGOMLAM(int OKBDCLGANIK, int KOJDEHOLPCK, int PLHIDJINJEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4030", Offset = "0x6CF3230", VA = "0x186CF4030")]
		public FaceFeatureBase BHGIFPIILJK(FaceFeatureType FFGKGAOEEOJ, string CNDCJIFNLGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4220", Offset = "0x6CF3420", VA = "0x186CF4220")]
		public int ELPJAIBFPKJ(string CNDCJIFNLGE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6CF45D0", Offset = "0x6CF37D0", VA = "0x186CF45D0")]
		private void NDDFEBJEJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x383C1D0", Offset = "0x383B3D0", VA = "0x18383C1D0")]
		private void FLAKHAOKAED<T>(Dictionary<string, T> FIPHIMEAJGH, T[] FPJNIBIHJPB) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4150", Offset = "0x6CF3350", VA = "0x186CF4150")]
		public string DNGAEPKDNCL(FaceFeatureType FFGKGAOEEOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6CF44B0", Offset = "0x6CF36B0", VA = "0x186CF44B0")]
		public string MGIIEMEAMHH(FaceFeatureType FFGKGAOEEOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4780", Offset = "0x6CF3980", VA = "0x186CF4780")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x825480", Offset = "0x824680", VA = "0x180825480", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6CF3CB0", Offset = "0x6CF2EB0", VA = "0x186CF3CB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6CF3CF0", Offset = "0x6CF2EF0", VA = "0x186CF3CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x1908320", Offset = "0x1907520", VA = "0x181908320")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x19073A0", Offset = "0x19065A0", VA = "0x1819073A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x3B16380", Offset = "0x3B15580", VA = "0x183B16380")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xB55030", Offset = "0xB54230", VA = "0x180B55030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6CF3CD0", Offset = "0x6CF2ED0", VA = "0x186CF3CD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xB55040", Offset = "0xB54240", VA = "0x180B55040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3940", Offset = "0x6CF2B40", VA = "0x186CF3940", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3BD0", Offset = "0x6CF2DD0", VA = "0x186CF3BD0")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8F2EF0", Offset = "0x8F20F0", VA = "0x1808F2EF0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1B80", Offset = "0x6CF0D80", VA = "0x186CF1B80")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x825660", Offset = "0x824860", VA = "0x180825660", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6CF70C0", Offset = "0x6CF62C0", VA = "0x186CF70C0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6CF4010", Offset = "0x6CF3210", VA = "0x186CF4010")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xB108C0", Offset = "0xB0FAC0", VA = "0x180B108C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1268270", Offset = "0x1267470", VA = "0x181268270")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA0ABA0", Offset = "0xA09DA0", VA = "0x180A0ABA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3EF0", Offset = "0x6CF30F0", VA = "0x186CF3EF0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3F90", Offset = "0x6CF3190", VA = "0x186CF3F90")]
		protected FaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PNGFNKOELFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class NDDOADIFHNJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public readonly Texture2DArray HIFKNIINDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public readonly Dictionary<string, int> JMAMIFDOBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly COJCOIOHKKE ININHCMPKLF;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool IGGMEFGCGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1570D10", Offset = "0x156FF10", VA = "0x181570D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6CF70D0", Offset = "0x6CF62D0", VA = "0x186CF70D0")]
		public NDDOADIFHNJ(Texture2DArray JMBBGKPIMNC, Dictionary<string, int> HANLFKKFMML, PNGFNKOELFA DPBBFKIEECM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x193DA20", Offset = "0x193CC20", VA = "0x18193DA20")]
		public void JCFNINDDHAG(PNGFNKOELFA IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x193C9F0", Offset = "0x193BBF0", VA = "0x18193C9F0")]
		public void LEHKKLOIING(PNGFNKOELFA IBIKCCMDMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1B90F90", Offset = "0x1B90190", VA = "0x181B90F90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private struct LALMIIEMAED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly string ECNFILMDPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly string PFHFHHBFGNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly string KJJBCMCMBBJ;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA5D850", Offset = "0xA5CA50", VA = "0x180A5D850")]
		public LALMIIEMAED(string APGAJGOGHKJ, string AHNJEBCNJHA, string ECMGBHPGJPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6CF51F0", Offset = "0x6CF43F0", VA = "0x186CF51F0")]
		public bool KKBGDLBHIFL(LALMIIEMAED HPOECFLNEOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6CF5120", Offset = "0x6CF4320", VA = "0x186CF5120", Slot = "0")]
		public override bool Equals(object BHEOHCEHIBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D220", Offset = "0x5D2C420", VA = "0x185D2D220", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6CF51F0", Offset = "0x6CF43F0", VA = "0x186CF51F0")]
		public static bool JGKKLLGINAK(LALMIIEMAED NGKKOMJDENH, LALMIIEMAED KEJINCBACKA)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6CF5270", Offset = "0x6CF4470", VA = "0x186CF5270")]
		public static bool NGNNEMMJMMJ(LALMIIEMAED NGKKOMJDENH, LALMIIEMAED KEJINCBACKA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Dictionary<string, int> HANLFKKFMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly LALMIIEMAED EKNFEEEEPAA;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Texture2DArray HKPNLFGEOLL
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public SymmetricalFaceFeature EBPCHMNGEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C00", Offset = "0x8D6E00", VA = "0x1808D7C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8D7C10", Offset = "0x8D6E10", VA = "0x1808D7C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public EyesFaceFeature OOLIEJCLJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x82A5F0", Offset = "0x8297F0", VA = "0x18082A5F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x841E50", Offset = "0x841050", VA = "0x180841E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public FaceFeature LPLBDGINHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x943020", Offset = "0x942220", VA = "0x180943020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7220", Offset = "0x6CF6420", VA = "0x186CF7220")]
	private static void EGGLONACGAB(Sprite OENBEJNJPDB, Sprite IPBEAAIABLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6CF71A0", Offset = "0x6CF63A0", VA = "0x186CF71A0")]
	private static void DOGJNIDBECJ(Sprite HGKPDKDHOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7530", Offset = "0x6CF6730", VA = "0x186CF7530")]
	public PNGFNKOELFA(EyesFaceFeature KOJDEHOLPCK, FaceFeature PLHIDJINJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7550", Offset = "0x6CF6750", VA = "0x186CF7550")]
	public PNGFNKOELFA(SymmetricalFaceFeature HKLCGPFFFGI, EyesFaceFeature KOJDEHOLPCK, FaceFeature PLHIDJINJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7320", Offset = "0x6CF6520", VA = "0x186CF7320")]
	public bool PHDCDCOFPMF(Sprite HGKPDKDHOJN, out int MMFFFGBLCAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7210", Offset = "0x6CF6410", VA = "0x186CF7210", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x6CF8580", Offset = "0x6CF7780", VA = "0x186CF8580")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xC2CB80", Offset = "0xC2BD80", VA = "0x180C2CB80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x1CAC320", Offset = "0x1CAB520", VA = "0x181CAC320")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xC2CB70", Offset = "0xC2BD70", VA = "0x180C2CB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x1CAC2F0", Offset = "0x1CAB4F0", VA = "0x181CAC2F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x983EA0", Offset = "0x9830A0", VA = "0x180983EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x1CAC290", Offset = "0x1CAB490", VA = "0x181CAC290")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x6CF85A0", Offset = "0x6CF77A0", VA = "0x186CF85A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8480", Offset = "0x6CF7680", VA = "0x186CF8480", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1B80", Offset = "0x6CF0D80", VA = "0x186CF1B80")]
		protected SymmetricalFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class FaceFeatureBase : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x96EA60", Offset = "0x96DC60", VA = "0x18096EA60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x96EA70", Offset = "0x96DC70", VA = "0x18096EA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x96E290", Offset = "0x96D490", VA = "0x18096E290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x6CF3ED0", Offset = "0x6CF30D0", VA = "0x186CF3ED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xC895D0", Offset = "0xC887D0", VA = "0x180C895D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x983BB0", Offset = "0x982DB0", VA = "0x180983BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3D00", Offset = "0x6CF2F00", VA = "0x186CF3D00")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3D70", Offset = "0x6CF2F70", VA = "0x186CF3D70", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3DF0", Offset = "0x6CF2FF0", VA = "0x186CF3DF0")]
		protected FaceFeatureBase()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
