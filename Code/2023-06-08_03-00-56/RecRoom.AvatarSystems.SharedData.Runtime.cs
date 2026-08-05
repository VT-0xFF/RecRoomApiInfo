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
	[Cpp2IlInjected.Address(RVA = "0x6BF05E0", Offset = "0x6BEF3E0", VA = "0x186BF05E0")]
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
		public BBLMJPEOFPH lod;

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
public struct LCKOONNHADC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Transform AFDNLDPCLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public GameObject CLIHFDHLJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public SkinnedMeshRenderer[] GHCLPMFKIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public SkinnedMeshRenderer[] BBDLDKOCLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GameObject MMKBABINNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public SkinnedMeshRenderer[] HFOLCHIGIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public SkinnedMeshRenderer[] LCJOFMMJCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public MFMMLHGMLHF OLFGJGLKNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Material LMMMEMFDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Material FGFMNFKOEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Shader DFEEDAKIFCP;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class JBCMBLGDKBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool IABPHCIJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool GODAOBNJGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool COIOPLNBFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool IFCELMHDLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool MIIGNOBOIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool DMAGGLEADPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool BICFHONPGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public IList<GELJOPPONJE> DKFJKLGLLFO;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public JBCMBLGDKBL()
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
		private MFMMLHGMLHF IMKEAEFAEOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Collider[] IGBLGJFHPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Collider[] OFILFMMIOHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6BF6DA0", Offset = "0x6BF5BA0", VA = "0x186BF6DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6BF6D20", Offset = "0x6BF5B20", VA = "0x186BF6D20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6BF6F60", Offset = "0x6BF5D60", VA = "0x186BF6F60")]
		public void UpdateBones(MFMMLHGMLHF NPLIPJNMACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6BF6E10", Offset = "0x6BF5C10", VA = "0x186BF6E10")]
		public void SetCollidersEnabled(bool HECCKGMOGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6BF6F90", Offset = "0x6BF5D90", VA = "0x186BF6F90")]
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
public static class OHJNIIFFKCB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BF45A0", Offset = "0x6BF33A0", VA = "0x186BF45A0")]
	public static bool NAGMJDGLGFH(this OutfitType LPBHCNDPKCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4550", Offset = "0x6BF3350", VA = "0x186BF4550")]
	public static bool FHDOKAGEEJK(this OutfitType LPBHCNDPKCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF45C0", Offset = "0x6BF33C0", VA = "0x186BF45C0")]
	public static bool PKIGGLLENNN(this OutfitType LPBHCNDPKCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4590", Offset = "0x6BF3390", VA = "0x186BF4590")]
	public static bool MFLLPOIOEFL(this OutfitType LPBHCNDPKCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4580", Offset = "0x6BF3380", VA = "0x186BF4580")]
	public static bool GNFIOEGJFPG(this OutfitType LPBHCNDPKCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4570", Offset = "0x6BF3370", VA = "0x186BF4570")]
	public static bool GLEPJHGIIEE(this OutfitType LPBHCNDPKCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JJCIDKJKCLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Transform GGIEEFLLJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Transform KMNPCHFBGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Transform FMAOFHCLLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Transform NCCMFGLBGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Transform FIOJLDBECKJ;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ONDMGMKIJLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public SkinnedMeshRenderer[] BCOCGAAEFEC;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CHJDKOMNDHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public OJACBJKMFGC BFDGLJJHFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int AMPBDHEHHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int MOLBFLHONBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color KONHJECOFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color KGJIPHDPJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int DAGKPHFBFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int BBBKPEIHBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color PFCOMBCAIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Color NAKJKMKBHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int CMHEBKLAPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float ODGIEEIEOEP;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KBBNCOBJDJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public OJACBJKMFGC BFDGLJJHFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 EDOKDNKEPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float MBHKNHHIECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 PPNPIKBNACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float IGFLOGLLCBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 JDMEONKDGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float IDKBIPOBNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float EEHMAAEJAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 MKNAAMFMMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 BMMMBAAICLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool HNHIGHICNOG;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD69BC0", Offset = "0xD689C0", VA = "0x180D69BC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BF06A0", Offset = "0x6BEF4A0", VA = "0x186BF06A0")]
		public string GNEDHHGOLPL(string LINBHKOKJNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6BF06F0", Offset = "0x6BEF4F0", VA = "0x186BF06F0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum JCCOJOJHFML
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OAFBBHPBKOO
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly OAFBBHPBKOO KBEILLGFBKH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LBLDPOALBBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F20A0", Offset = "0x7F0EA0", VA = "0x1807F20A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JCCOJOJHFML CDJPDINGFAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x838BE0", Offset = "0x8379E0", VA = "0x180838BE0")]
		[CompilerGenerated]
		get
		{
			return default(JCCOJOJHFML);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F2460", Offset = "0x7F1260", VA = "0x1807F2460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public OAFBBHPBKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4510", Offset = "0x6BF3310", VA = "0x186BF4510")]
	public OAFBBHPBKOO(JCCOJOJHFML MCDJPGPBKAG, int BKMLPMHCPAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DKLDBGLOAHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Mesh OJCILGFIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Material[] BKNBKNHEHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool OHFBHNJHFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool DAIPDIJLAMP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	private DKLDBGLOAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0C40", Offset = "0x6BEFA40", VA = "0x186BF0C40")]
	public DKLDBGLOAHD(Mesh GFNFNFOOGBL, Material[] PNIABLOKBLH, bool FGICPBEIFMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0B20", Offset = "0x6BEF920", VA = "0x186BF0B20")]
	public DKLDBGLOAHD(SkinnedMeshRenderer AMANKJNEHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF07B0", Offset = "0x6BEF5B0", VA = "0x186BF07B0")]
	public static DKLDBGLOAHD HMEBEKCANOD(Renderer BMFFGJEAEEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct ANEGPFAJOEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly GameObject AOEBOLHMNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly AvatarItemMaterial MJDFMLACKDI;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
	public ANEGPFAJOEI(GameObject AOEBOLHMNEF, AvatarItemMaterial MJDFMLACKDI)
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
			[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0580", Offset = "0x6BEF380", VA = "0x186BF0580")]
		public static void HNDCEOGGCFP(AvatarItemMaterial LPBPPOLLGLN, Material DMHFIODFBBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF05E0", Offset = "0x6BEF3E0", VA = "0x186BF05E0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LDIECHNDIEB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Transform IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Vector3 HNMDAFHLBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ELFJBLFNHFO : LDIECHNDIEB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Transform IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B90", Offset = "0x7F0990", VA = "0x1807F1B90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 HNMDAFHLBNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x167FB10", Offset = "0x167E910", VA = "0x18167FB10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x167F420", Offset = "0x167E220", VA = "0x18167F420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float? PNNPPJMOKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9D3D20", Offset = "0x9D2B20", VA = "0x1809D3D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9D3D40", Offset = "0x9D2B40", VA = "0x1809D3D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public ELFJBLFNHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PMPMHACMIIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly ELFJBLFNHFO NMHMDALMDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly ELFJBLFNHFO IIGDFGBBBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly ELFJBLFNHFO KNEAEIKDBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly ELFJBLFNHFO CGOLCBJINAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly ELFJBLFNHFO EFDHECHCKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly ELFJBLFNHFO NADDBBDFJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly ELFJBLFNHFO BKEKEMKFGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly ELFJBLFNHFO KAAGOBKHEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly ELFJBLFNHFO AHPDCJFNGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly ELFJBLFNHFO JDLCDFBIJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly ELFJBLFNHFO POIBFDPHGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly ELFJBLFNHFO FOFBLIIELIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly ELFJBLFNHFO DBEMDGCEKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected ELFJBLFNHFO NBAFJKBPMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected readonly ELFJBLFNHFO HEPAOEHJJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	protected readonly ELFJBLFNHFO DBKNOFGEELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	protected readonly ELFJBLFNHFO AHAIFMOMMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected ELFJBLFNHFO JDJKPGKKLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected readonly ELFJBLFNHFO LHFEIKLDBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected readonly ELFJBLFNHFO BJIEOKNPJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	protected readonly ELFJBLFNHFO PNJEPGJHKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected ReadOnlyCollection<ELFJBLFNHFO> GMAHHFKCACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform DMGJGICCMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private (ELFJBLFNHFO Start, ELFJBLFNHFO End)[] BCDDPLDCAMG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LDIECHNDIEB ELNNMPELJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86DAE0", Offset = "0x86C8E0", VA = "0x18086DAE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LDIECHNDIEB OOCINPFMDOA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LDIECHNDIEB EBODOJNPCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LDIECHNDIEB JKGKFAGFOAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LDIECHNDIEB FCCFJNIAMDK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LDIECHNDIEB JONPMOIOJID
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8204A0", Offset = "0x81F2A0", VA = "0x1808204A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LDIECHNDIEB DFJADDABEOG
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ELFJBLFNHFO KJLPCFIGMAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81C6E0", Offset = "0x81B4E0", VA = "0x18081C6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LDIECHNDIEB NMBCJDPIPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ELFJBLFNHFO OABNNGFAPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LDIECHNDIEB EJNKNDAOMOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x825F10", Offset = "0x824D10", VA = "0x180825F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LDIECHNDIEB FMJKMLCILCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x91A260", Offset = "0x919060", VA = "0x18091A260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LDIECHNDIEB GBMBNHACCAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public ELFJBLFNHFO HKEODFHDFCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ELFJBLFNHFO NOFNNPLFGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public LDIECHNDIEB BHGJBLIDHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public LDIECHNDIEB GIOELJLMFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD50", Offset = "0x8F9B50", VA = "0x1808FAD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LDIECHNDIEB PHOJMHDLFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x931890", Offset = "0x930690", VA = "0x180931890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LDIECHNDIEB HOLDJBMCOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x96EF50", Offset = "0x96DD50", VA = "0x18096EF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public LDIECHNDIEB PKGIBBIOOMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x922460", Offset = "0x921260", VA = "0x180922460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public LDIECHNDIEB JKMMNCNJMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921300", VA = "0x180922500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public LDIECHNDIEB HEEIKEFJKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96DD20", VA = "0x18096EF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public LDIECHNDIEB EGHKEENLDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9318A0", Offset = "0x9306A0", VA = "0x1809318A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public LDIECHNDIEB OKCGKCCABFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9318B0", Offset = "0x9306B0", VA = "0x1809318B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LDIECHNDIEB IIMDIPPNOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9318D0", Offset = "0x9306D0", VA = "0x1809318D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyList<LDIECHNDIEB> NGAKGHBAMNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9318C0", Offset = "0x9306C0", VA = "0x1809318C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5F90", Offset = "0x6BF4D90", VA = "0x186BF5F90")]
	public void OECMBCFLFOI(VRIK BBNPJBKKOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x307E270", Offset = "0x307D070", VA = "0x18307E270")]
	private void OANLBHCODPP(Transform KGDHPOJLMNA, ELFJBLFNHFO LMBGOHINBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BF57A0", Offset = "0x6BF45A0", VA = "0x186BF57A0")]
	public void DFNKGFFCBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x307DCC0", Offset = "0x307CAC0", VA = "0x18307DCC0")]
	public float KOIJFCEMCFD(in (ELFJBLFNHFO Start, ELFJBLFNHFO End) DCFMOLDLIAO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5DB0", Offset = "0x6BF4BB0", VA = "0x186BF5DB0")]
	public void IPLIJHOKNPK(in BKAODNGFIEH BKDHMCPKLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5C50", Offset = "0x6BF4A50", VA = "0x186BF5C50")]
	private Vector3 HLBFDPBIIPB(in (ELFJBLFNHFO Start, ELFJBLFNHFO End) DCFMOLDLIAO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6980", Offset = "0x6BF5780", VA = "0x186BF6980")]
	public PMPMHACMIIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MFMMLHGMLHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private List<Transform> KGGBGJPCPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Matrix4x4[] IJDFEHMGBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Dictionary<string, Transform> CLPPFDNKFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private Dictionary<Transform, Transform> AJDNIKOEHDI;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Transform[] JGILPJLHAPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF3940", Offset = "0x6BF2740", VA = "0x186BF3940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Matrix4x4[] MHGEDLIHIID
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6290", Offset = "0x7F5090", VA = "0x1807F6290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3990", Offset = "0x6BF2790", VA = "0x186BF3990")]
	public void KCBIHCHAEEH(SkinnedMeshRenderer BMFFGJEAEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3B40", Offset = "0x6BF2940", VA = "0x186BF3B40")]
	public void LLMCGJPICAB(Transform JLJPHEMBLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF36F0", Offset = "0x6BF24F0", VA = "0x186BF36F0")]
	private Transform CCGLEJJIPDB(Transform JFIFKODKAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3470", Offset = "0x6BF2270", VA = "0x186BF3470")]
	public void BAJIOCNJPNI(MFMMLHGMLHF CFAAEAEBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6BF37D0", Offset = "0x6BF25D0", VA = "0x186BF37D0")]
	private void COLPCEECLEG(Transform BHODGDEIEBD, List<Transform> CKKOBEGDDNI, Dictionary<string, Transform> LAFPKPELCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3BB0", Offset = "0x6BF29B0", VA = "0x186BF3BB0")]
	public MFMMLHGMLHF()
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
		public enum KNCLHENOOAN
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
		private KNCLHENOOAN useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x30B9270", Offset = "0x30B8070", VA = "0x1830B9270")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x91A160", Offset = "0x918F60", VA = "0x18091A160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB9CFF0", Offset = "0xB9BDF0", VA = "0x180B9CFF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9E91F0", Offset = "0x9E7FF0", VA = "0x1809E91F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x952E30", Offset = "0x951C30", VA = "0x180952E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB9D060", Offset = "0xB9BE60", VA = "0x180B9D060")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x91A1B0", Offset = "0x918FB0", VA = "0x18091A1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1B55890", Offset = "0x1B54690", VA = "0x181B55890")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1495C10", Offset = "0x1494A10", VA = "0x181495C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8313A0", Offset = "0x8301A0", VA = "0x1808313A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x91A170", Offset = "0x918F70", VA = "0x18091A170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x18ECE30", Offset = "0x18EBC30", VA = "0x1818ECE30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB34CD0", Offset = "0xB33AD0", VA = "0x180B34CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x203FAF0", Offset = "0x203E8F0", VA = "0x18203FAF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xBF4A40", Offset = "0xBF3840", VA = "0x180BF4A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9318E0", Offset = "0x9306E0", VA = "0x1809318E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x998D70", Offset = "0x997B70", VA = "0x180998D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x998D50", Offset = "0x997B50", VA = "0x180998D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8FAD50", Offset = "0x8F9B50", VA = "0x1808FAD50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x943890", Offset = "0x942690", VA = "0x180943890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x931890", Offset = "0x930690", VA = "0x180931890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x952DE0", Offset = "0x951BE0", VA = "0x180952DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x96EF50", Offset = "0x96DD50", VA = "0x18096EF50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x952DC0", Offset = "0x951BC0", VA = "0x180952DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x922460", Offset = "0x921260", VA = "0x180922460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x996830", Offset = "0x995630", VA = "0x180996830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x922500", Offset = "0x921300", VA = "0x180922500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xC29A60", Offset = "0xC28860", VA = "0x180C29A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x96EF20", Offset = "0x96DD20", VA = "0x18096EF20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCDEF80", Offset = "0xCDDD80", VA = "0x180CDEF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1046130", Offset = "0x1044F30", VA = "0x181046130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1046140", Offset = "0x1044F40", VA = "0x181046140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public KNCLHENOOAN UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6BF0490", Offset = "0x6BEF290", VA = "0x186BF0490")]
			get
			{
				return default(KNCLHENOOAN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1289000", Offset = "0x1287E00", VA = "0x181289000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xBE0E70", Offset = "0xBDFC70", VA = "0x180BE0E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xBE09A0", Offset = "0xBDF7A0", VA = "0x180BE09A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6BF0470", Offset = "0x6BEF270", VA = "0x186BF0470")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6BF0560", Offset = "0x6BEF360", VA = "0x186BF0560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x992890", Offset = "0x991690", VA = "0x180992890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x992CB0", Offset = "0x991AB0", VA = "0x180992CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6BF04C0", Offset = "0x6BEF2C0", VA = "0x186BF04C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x17EFCE0", Offset = "0x17EEAE0", VA = "0x1817EFCE0")]
		public string LKKGLINHIKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0050", Offset = "0x6BEEE50", VA = "0x186BF0050")]
		public static AvatarCustomizationSettings KMIKNNFPDOG(string LEKGDHHINNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6BF01F0", Offset = "0x6BEEFF0", VA = "0x186BF01F0")]
		public AvatarCustomizationSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum AONHCFIMCOB
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
public enum MOLGMKJGEIC
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
public enum DNLNNIPGPLA
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
public enum OKIGBOKDCOC
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
public enum ENPAMPAFIFD
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
public enum ACPOLOHGMFD
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum DODAJODPBGJ
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
public enum KPDEDGDPNNK
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
public enum KNHGBBKMPCM
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
public static class KKEFOONPADI
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly int AOLLBEHEGKH;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static readonly string IGAHDBOHIHF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static readonly string JMDKCGHHJDA;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2A70", Offset = "0x6BF1870", VA = "0x186BF2A70")]
	public static BKAODNGFIEH BIDFDHFNIOI()
	{
		return default(BKAODNGFIEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2C60", Offset = "0x6BF1A60", VA = "0x186BF2C60")]
	public static OKFEDJFGDPE CMGBEHAGDHE(Transform GEDCKAADLAM, Transform GIHHHMHPHFI, AvatarConfiguration MLIOOLHOHEN, Animator OANFFCJIEEP, VRIK CKFCPDMDAAI, SkeletonLODUpdateRate[] DCMGODIIFCF, GameObject[] AGGCLKBCMNK, Transform DMGJGICCMLL, GameObject AJEGPJGDKLP, BodySkinnedMeshLODs GMNNBJHMLJD, BodySkinnedMeshLODs IJCAGBIGOOO, GameObject AHHCMPNHNDO, BodySkinnedMeshLODs MKLABJEOGFM, BodySkinnedMeshLODs EIEPJHACJIK, MFMMLHGMLHF NPLIPJNMACA, Material LDPLBPONPDM, Material DCOINIOCOCH, Shader FLPBAPGBPAO, Transform EMDGLMMPDEM, Transform ONNEMKLGEAN, Transform FOIAAGAADEO, Transform NDFHCBJLBLD, Transform AOJFMNEMFAP)
	{
		return default(OKFEDJFGDPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3270", Offset = "0x6BF2070", VA = "0x186BF3270")]
	public static BNEFLJHDLPL PCFKFCKGIBO(string JAKJNAKLGJB, bool FEKPAMADIBO, bool BLLCCJAJBLE, bool MOKBMJHPOHO, RigidbodyEx PNNBEMLCFLF, RigidbodyEx BJGJGPKEAEE, RigidbodyEx KJFAPAMDECJ, RigidbodyEx BNOGBKPMIKB, Transform LHNNEHBNKCH, Transform MBCGOHADHBO, Transform AKBFILNAHLB, float LBPLLCMPLDA, float DHNKHKHJEJD, PlayerAvatarFullBodyColliders PKKIBBPOMAJ)
	{
		return default(BNEFLJHDLPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2F10", Offset = "0x6BF1D10", VA = "0x186BF2F10")]
	public static LCKOONNHADC HFKCEACAOEO(Transform GIHHHMHPHFI, GameObject AJEGPJGDKLP, SkinnedMeshRenderer[] MNPLCIKJCOH, SkinnedMeshRenderer[] EFCONNHDIPB, GameObject AHHCMPNHNDO, SkinnedMeshRenderer[] HPKNMCOAONL, SkinnedMeshRenderer[] IGGIMMIMHIL, MFMMLHGMLHF NPLIPJNMACA, Material LDPLBPONPDM, Material DCOINIOCOCH, Shader FLPBAPGBPAO)
	{
		return default(LCKOONNHADC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3070", Offset = "0x6BF1E70", VA = "0x186BF3070")]
	public static JJCIDKJKCLA JKGKOFIGDJG(Transform EMDGLMMPDEM, Transform FOIAAGAADEO, Transform ONNEMKLGEAN, Transform NDFHCBJLBLD, Transform AOJFMNEMFAP)
	{
		return default(JJCIDKJKCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x17B4750", Offset = "0x17B3550", VA = "0x1817B4750")]
	public static ONDMGMKIJLO BKPIBPAGLJM(SkinnedMeshRenderer[] IEKMGHIBOKE)
	{
		return default(ONDMGMKIJLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2B40", Offset = "0x6BF1940", VA = "0x186BF2B40")]
	public static CHJDKOMNDHG CBLGEELIFBN(OJACBJKMFGC GOMLAODAMJL, int LEIIPOIIMDC, int GDLFCLILJGK, Color MNIGIOCAKGH, Color ADDIKGJEFAB, int DCJAAGLBPGN, int LBDPEGCDPJO, Color LKLPOLMFAFO, Color JFNLDAKFEBO, int JOHGJAPIMFG, float LEIALEJPJLE)
	{
		return default(CHJDKOMNDHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3140", Offset = "0x6BF1F40", VA = "0x186BF3140")]
	public static KBBNCOBJDJA MDMHGOIHMJG(OJACBJKMFGC GOMLAODAMJL, Vector2 LBPFKEBIHPA, float NPGKGBANODF, Vector2 INCFEIJCAGI, float BJEIDGGCPOB, Vector2 JIADJGMDACF, float HCJHBMIHEEF, float BNJMJDNGJEM, Vector2 MFILKGJADNH, Vector2 LMEMDGKHCOO)
	{
		return default(KBBNCOBJDJA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AJAGGJALNAP
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NGNJEANMKPP();

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GGADDACMMKK<Texture2D> IBCMLEJKEME(OLGHFMGPIJL JKNNLMIHFCA, [Optional] OAFBBHPBKOO FBDHILNJDOE);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MLNLEIILPAC : AJAGGJALNAP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private ADGOECKHGEI MOAFFNLMIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private IRecRoomQualityConfigProvider GLMKHMCDPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool NEHAKCHKHFN;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private const uint OEIJOOMADPK = 16u;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4330", Offset = "0x6BF3130", VA = "0x186BF4330")]
	[GIEEOCCBBIJ(PFHGMCKNAFN.GameOnly)]
	private static void LMMJIFOKKLK(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xB86030", Offset = "0xB84E30", VA = "0x180B86030")]
	[Preserve]
	public MLNLEIILPAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3E70", Offset = "0x6BF2C70", VA = "0x186BF3E70")]
	private void EKIJLINFAJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4420", Offset = "0x6BF3220", VA = "0x186BF4420", Slot = "4")]
	public void NGNJEANMKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3F20", Offset = "0x6BF2D20", VA = "0x186BF3F20", Slot = "5")]
	public GGADDACMMKK<Texture2D> IBCMLEJKEME(OLGHFMGPIJL JKNNLMIHFCA, [Optional] OAFBBHPBKOO FBDHILNJDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3CB0", Offset = "0x6BF2AB0", VA = "0x186BF3CB0")]
	private uint CHOEPMIGDLC(OLGHFMGPIJL JKNNLMIHFCA, OAFBBHPBKOO FBDHILNJDOE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct BNEFLJHDLPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public string ECKOHJIMCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public bool LHIGLPLNCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public bool OMGCJAKGGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public float PGJLPELFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public float KABLDAJNFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public bool KEMLFMIEJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public RigidbodyEx DIKGOJDOBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public RigidbodyEx LPPBKNOEFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public RigidbodyEx POHKONJCOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public RigidbodyEx KEICGOLGFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public Transform KPPCICJDJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform OCCENBJICFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform HKNDMMOJAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public PlayerAvatarFullBodyColliders CMDBEPJJLEO;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct OKFEDJFGDPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform NLIMJFKPLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform FLHGPBIICNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public AvatarConfiguration JIJMIPKEFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Animator ADNDJLBMJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public VRIK FAAHNDGNDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public SkeletonLODUpdateRate[] GCHFHPFPDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public GameObject[] DKLOIBCIMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform EMLDJIFHGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public GameObject CLIHFDHLJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public BodySkinnedMeshLODs FPCCOEMLNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public BodySkinnedMeshLODs IMFMOFJFLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public GameObject MMKBABINNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public BodySkinnedMeshLODs FBNHFCADBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public BodySkinnedMeshLODs GIBIPOJKKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public MFMMLHGMLHF OLFGJGLKNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Material LMMMEMFDDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Material FGFMNFKOEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Shader DFEEDAKIFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Transform GGIEEFLLJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Transform FMAOFHCLLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform KMNPCHFBGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Transform NCCMFGLBGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform FIOJLDBECKJ;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BKAODNGFIEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public float NBIOABJJFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool JPKFBJNOJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public BBLMJPEOFPH OAKINIOIGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 FLNOMAFNECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 OAGMEMBGPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3? JGKGJDGBEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public Vector3? FHINFADJPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool DJKFCIOPLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool JIBPKPDLOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool FLHAAHADEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public bool CDOMDBAEIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public bool ECMCJNPEANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Vector3? LELPFABGJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool IKGANCPNNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public Vector3? GNCFKNGMMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool FBBKEPOBBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3? ILHMCBCDCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3? EAGJFEGANEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public bool FEFNKLJKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool MOPFCIABIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool DONOIMGPMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool LOFMJFADLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool PDJCIAAKLEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool CFCGLFFICID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool JDFJLNJJALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool AJCHILNBOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool KDIKHIOLPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool FPBGFFEJPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? MELBLLPACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public AONHCFIMCOB OPFEFGOPOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public AONHCFIMCOB AFANJFIONKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float PINNGPPDODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public float BGPNLNJAIJA;
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
			[Cpp2IlInjected.Address(RVA = "0x6BF2540", Offset = "0x6BF1340", VA = "0x186BF2540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2480", Offset = "0x6BF1280", VA = "0x186BF2480")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6BF22A0", Offset = "0x6BF10A0", VA = "0x186BF22A0")]
		public void OOAPGEPLJIK(FitMeshHemisphere OFCFABJLPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1F00", Offset = "0x6BF0D00", VA = "0x186BF1F00")]
		public Vector3 JNFAGFMNMIF(Vector2 FFCHEHFGDON, bool BNBGJHAFMFN = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1EA0", Offset = "0x6BF0CA0", VA = "0x186BF1EA0")]
		public Vector3 IOGKKKIOIHI(Vector2 FFCHEHFGDON)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1D70", Offset = "0x6BF0B70", VA = "0x186BF1D70")]
		public Quaternion BAFPJFPBECE(Vector2 FFCHEHFGDON)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1C60", Offset = "0x6BF0A60", VA = "0x186BF1C60")]
		public Quaternion BAFPJFPBECE(Vector2 FFCHEHFGDON, Vector3 HEPMIEGAFLN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2260", Offset = "0x6BF1060", VA = "0x186BF2260")]
		private Vector2 LGHINKEOCPN(Vector2 CIMEJHDBNEP)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class GELJOPPONJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public string KGBBPCBIOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public OutfitType KMDGNDCFKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public DNLNNIPGPLA PKDNEJPEKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public bool HBAPHNMJNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public Color? MEIEKGADEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Vector3? IPLIFLNCKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public float? OKKEIJJGKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public Guid? KDFDKPLLKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public OBIBNJJJMCL? HNKBNBNNECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Color? DAEAFPEHHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool PEJFNDKPKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool CCOEDDLGFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public AnchorParamsRestrictions EBGLBNIEEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public Vector2? MHKHGJMMIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public Transform PGCPMFKPBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public FitMeshHemisphere AMNDPLBEEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public Vector2 BMADLKFKDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private List<AvatarHairPatternOverride> NDCFEEALFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Dictionary<string, Texture2D> EFBFOBLCEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private List<AvatarHairPatternOverride> EJMGKLPFJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Dictionary<string, Texture2D> IBJIKBMFMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public AssetReference LNDDJFLNACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public AssetReference NPPLHNDDHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public AssetReference[] EHAODCHACGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public bool LGBADDOMEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public bool KMHKPMPHFCG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public List<AvatarHairPatternOverride> BPJJBHGGGNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xBE4FB0", Offset = "0xBE3DB0", VA = "0x180BE4FB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2830", Offset = "0x6BF1630", VA = "0x186BF2830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public List<AvatarHairPatternOverride> NHIINGCBNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xBE4FD0", Offset = "0xBE3DD0", VA = "0x180BE4FD0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2600", Offset = "0x6BF1400", VA = "0x186BF2600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string FFLEAJNGBCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2550", Offset = "0x6BF1350", VA = "0x186BF2550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2A60", Offset = "0x6BF1860", VA = "0x186BF2A60")]
	public GELJOPPONJE()
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
			[Cpp2IlInjected.Address(RVA = "0x6BEFFE0", Offset = "0x6BEEDE0", VA = "0x186BEFFE0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFE40", Offset = "0x6BEEC40", VA = "0x186BEFE40")]
		public AnchorParams(Vector2 FBIMEKJEPJA, Vector3 DAIPADAHPGB, Vector3 PCPNBNAAJKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFE70", Offset = "0x6BEEC70", VA = "0x186BEFE70")]
		public AnchorParams(KJMLMKELGDE CAHDALLMADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFD50", Offset = "0x6BEEB50", VA = "0x186BEFD50", Slot = "4")]
		public bool Equals(AnchorParams FGBEDAPNDEP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KJMLMKELGDE
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool OLHFJJJELOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool HMHHCDHBOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool MHLDKDHALGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool CJCLKCICAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool CPEJKHPENGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool ILCFPCLDCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool LFJCEPGFBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool COPLOBFCJOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float FDCHDALKBLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float DLBGDFEIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float LPHCBMOALNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float LDDCPIEKOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float ACELEDAEICC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	float NNEIDIFJJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float MMHABEIGOON
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float HNINDGGFLAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	float KBHCFNIIICF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float IJNAEKEIECH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float EFGBEKFIEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float GCPFFFEHELB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float EFEACFELOMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float KIADBDNKPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float JANNEOABNFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float APGGMFPBOBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 GIKHFCCOMCB(Vector3 PCPNBNAAJKO);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 PAMDFPOJNGL(Vector3 JKAIOFCMHNP);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 FIGFOCLMICD();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 GJJHCCOGNJD();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AnchorParamsRestrictions : KJMLMKELGDE
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
			[Cpp2IlInjected.Address(RVA = "0x6BEFCC0", Offset = "0x6BEEAC0", VA = "0x186BEFCC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6BEFCF0", Offset = "0x6BEEAF0", VA = "0x186BEFCF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6BEFD20", Offset = "0x6BEEB20", VA = "0x186BEFD20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6BEFC30", Offset = "0x6BEEA30", VA = "0x186BEFC30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6BEFC60", Offset = "0x6BEEA60", VA = "0x186BEFC60", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6BEFC90", Offset = "0x6BEEA90", VA = "0x186BEFC90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8041D0", Offset = "0x802FD0", VA = "0x1808041D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9E9C00", Offset = "0x9E8A00", VA = "0x1809E9C00", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xD54DB0", Offset = "0xD53BB0", VA = "0x180D54DB0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x807030", Offset = "0x805E30", VA = "0x180807030", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x9FB450", Offset = "0x9FA250", VA = "0x1809FB450", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x9E9580", Offset = "0x9E8380", VA = "0x1809E9580", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x1285710", Offset = "0x1284510", VA = "0x181285710", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x15144F0", Offset = "0x15132F0", VA = "0x1815144F0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x222D170", Offset = "0x222BF70", VA = "0x18222D170", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1495BD0", Offset = "0x14949D0", VA = "0x181495BD0", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xD5A450", Offset = "0xD59250", VA = "0x180D5A450", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1495B80", Offset = "0x1494980", VA = "0x181495B80", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xBF4910", Offset = "0xBF3710", VA = "0x180BF4910", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xBF4930", Offset = "0xBF3730", VA = "0x180BF4930", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x16AF6D0", Offset = "0x16AE4D0", VA = "0x1816AF6D0", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x144EAD0", Offset = "0x144D8D0", VA = "0x18144EAD0", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x16B0230", Offset = "0x16AF030", VA = "0x1816B0230", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1661CC0", Offset = "0x1660AC0", VA = "0x181661CC0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFBA0", Offset = "0x6BEE9A0", VA = "0x186BEFBA0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF890", Offset = "0x6BEE690", VA = "0x186BEF890")]
		public AnchorParams NEDIDBDJMNJ(AnchorParams GDACBFAFOPM)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF790", Offset = "0x6BEE590", VA = "0x186BEF790", Slot = "30")]
		public Vector3 FIGFOCLMICD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF860", Offset = "0x6BEE660", VA = "0x186BEF860", Slot = "31")]
		public Vector3 GJJHCCOGNJD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF7C0", Offset = "0x6BEE5C0", VA = "0x186BEF7C0", Slot = "28")]
		public Vector3 GIKHFCCOMCB(Vector3 PCPNBNAAJKO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6BEFB00", Offset = "0x6BEE900", VA = "0x186BEFB00", Slot = "29")]
		public Vector3 PAMDFPOJNGL(Vector3 JKAIOFCMHNP)
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
			[Cpp2IlInjected.Address(RVA = "0x936390", Offset = "0x935190", VA = "0x180936390", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4480", Offset = "0x6BF3280", VA = "0x186BF4480")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BF1C40", Offset = "0x6BF0A40", VA = "0x186BF1C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6BF19C0", Offset = "0x6BF07C0", VA = "0x186BF19C0")]
		public OJACBJKMFGC LMAGPIDHMHN(int HFINHNFBELM, int NJBEGIOIOPH, int EHMMFCPBBPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6BF17E0", Offset = "0x6BF05E0", VA = "0x186BF17E0")]
		public FaceFeatureBase JHEEMDDAPPK(FaceFeatureType PMCCLLFINCB, string LOOGPKNLJEM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1930", Offset = "0x6BF0730", VA = "0x186BF1930")]
		public int JLPBKNLJANE(string LOOGPKNLJEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1630", Offset = "0x6BF0430", VA = "0x186BF1630")]
		private void GNELPGFMEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x233E910", Offset = "0x233D710", VA = "0x18233E910")]
		private void KAMBDBBDJEN<T>(Dictionary<string, T> FCBFEOILBOB, T[] NNALCCMIDHM) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1440", Offset = "0x6BF0240", VA = "0x186BF1440")]
		public string EODCNGAOMHI(FaceFeatureType PMCCLLFINCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1510", Offset = "0x6BF0310", VA = "0x186BF1510")]
		public string FKBOBKFKIBE(FaceFeatureType PMCCLLFINCB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1BC0", Offset = "0x6BF09C0", VA = "0x186BF1BC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x81C090", Offset = "0x81AE90", VA = "0x18081C090", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6BF10D0", Offset = "0x6BEFED0", VA = "0x186BF10D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6BF1110", Offset = "0x6BEFF10", VA = "0x186BF1110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x205E510", Offset = "0x205D310", VA = "0x18205E510")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x205DC10", Offset = "0x205CA10", VA = "0x18205DC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x3F6F7B0", Offset = "0x3F6E5B0", VA = "0x183F6F7B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xC24000", Offset = "0xC22E00", VA = "0x180C24000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6BF10F0", Offset = "0x6BEFEF0", VA = "0x186BF10F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xC24010", Offset = "0xC22E10", VA = "0x180C24010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0D50", Offset = "0x6BEFB50", VA = "0x186BF0D50", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0FF0", Offset = "0x6BEFDF0", VA = "0x186BF0FF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x936380", Offset = "0x935180", VA = "0x180936380", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0740", Offset = "0x6BEF540", VA = "0x186BF0740")]
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
			[Cpp2IlInjected.Address(RVA = "0x81BC70", Offset = "0x81AA70", VA = "0x18081BC70", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6BF4480", Offset = "0x6BF3280", VA = "0x186BF4480")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BF1420", Offset = "0x6BF0220", VA = "0x186BF1420")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xBA0260", Offset = "0xB9F060", VA = "0x180BA0260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x14A3930", Offset = "0x14A2730", VA = "0x1814A3930")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xEF9C70", Offset = "0xEF8A70", VA = "0x180EF9C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1310", Offset = "0x6BF0110", VA = "0x186BF1310", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6BF13A0", Offset = "0x6BF01A0", VA = "0x186BF13A0")]
		protected FaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class OJACBJKMFGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class OPCBFNNADJF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public readonly Texture2DArray JIOIKFKLAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public readonly Dictionary<string, int> FMHBAKBOEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly LHKDGCOKKGC CPBIGJGEIKM;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool EBKPJDLGELE
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x19098E0", Offset = "0x19086E0", VA = "0x1819098E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6BF54E0", Offset = "0x6BF42E0", VA = "0x186BF54E0")]
		public OPCBFNNADJF(Texture2DArray BCPHGPJPIFA, Dictionary<string, int> FNKEHMONOJN, OJACBJKMFGC DPCMEAJIHIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1CF06B0", Offset = "0x1CEF4B0", VA = "0x181CF06B0")]
		public void EIMPKGMNFKN(OJACBJKMFGC GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1CEEE30", Offset = "0x1CEDC30", VA = "0x181CEEE30")]
		public void NAMHDBODHDE(OJACBJKMFGC GKNJCIECGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x207F070", Offset = "0x207DE70", VA = "0x18207F070", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private struct PBMFBOMBONE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly string NBDGGALLACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly string PJKCKMEJDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly string FIPIFKMHMMK;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xAFC160", Offset = "0xAFAF60", VA = "0x180AFC160")]
		public PBMFBOMBONE(string CEKGDHCDIKD, string AGPLPIIOFDN, string OKLHPINCELA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF55B0", Offset = "0x6BF43B0", VA = "0x186BF55B0")]
		public bool OCABIOPIOAG(PBMFBOMBONE FGBEDAPNDEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5640", Offset = "0x6BF4440", VA = "0x186BF5640", Slot = "0")]
		public override bool Equals(object GNOEFMFMEOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5E57410", Offset = "0x5E56210", VA = "0x185E57410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6BF55B0", Offset = "0x6BF43B0", VA = "0x186BF55B0")]
		public static bool DDONPFMGGHF(PBMFBOMBONE BGNJLPDNBMK, PBMFBOMBONE MDKJCMEMIDH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6BF5710", Offset = "0x6BF4510", VA = "0x186BF5710")]
		public static bool HDFILCNJOKD(PBMFBOMBONE BGNJLPDNBMK, PBMFBOMBONE MDKJCMEMIDH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Dictionary<string, int> FNKEHMONOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly PBMFBOMBONE ADPGKDIPGAP;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Texture2DArray LOEDFKMNIID
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public SymmetricalFaceFeature ALOLDLPKBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAD40", Offset = "0x8F9B40", VA = "0x1808FAD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x903350", Offset = "0x902150", VA = "0x180903350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public EyesFaceFeature CBCEJIFFNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x838D80", Offset = "0x837B80", VA = "0x180838D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public FaceFeature KMPNOACMODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x952E30", Offset = "0x951C30", VA = "0x180952E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4650", Offset = "0x6BF3450", VA = "0x186BF4650")]
	private static void KKOHMJIIFOO(Sprite DAHNJIHOFJJ, Sprite OBMNHEKEPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6BF45E0", Offset = "0x6BF33E0", VA = "0x186BF45E0")]
	private static void HKFGHKFAFGN(Sprite CLPLHDDACGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6BF54C0", Offset = "0x6BF42C0", VA = "0x186BF54C0")]
	public OJACBJKMFGC(EyesFaceFeature NJBEGIOIOPH, FaceFeature EHMMFCPBBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4960", Offset = "0x6BF3760", VA = "0x186BF4960")]
	public OJACBJKMFGC(SymmetricalFaceFeature HLPLEODJCBC, EyesFaceFeature NJBEGIOIOPH, FaceFeature EHMMFCPBBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4750", Offset = "0x6BF3550", VA = "0x186BF4750")]
	public bool NLLHBALBDMP(Sprite CLPLHDDACGL, out int FHOMILACEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6BF45D0", Offset = "0x6BF33D0", VA = "0x186BF45D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6BF71F0", Offset = "0x6BF5FF0", VA = "0x186BF71F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xCDBFD0", Offset = "0xCDADD0", VA = "0x180CDBFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x203FAD0", Offset = "0x203E8D0", VA = "0x18203FAD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xCDBFB0", Offset = "0xCDADB0", VA = "0x180CDBFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x203FAA0", Offset = "0x203E8A0", VA = "0x18203FAA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x41D20C0", Offset = "0x41D0EC0", VA = "0x1841D20C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x203FA20", Offset = "0x203E820", VA = "0x18203FA20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x6BF7210", Offset = "0x6BF6010", VA = "0x186BF7210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6BF70E0", Offset = "0x6BF5EE0", VA = "0x186BF70E0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0740", Offset = "0x6BEF540", VA = "0x186BF0740")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F6290", Offset = "0x7F5090", VA = "0x1807F6290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x805990", Offset = "0x804790", VA = "0x180805990")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x9086E0", Offset = "0x9074E0", VA = "0x1809086E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x6BF12F0", Offset = "0x6BF00F0", VA = "0x186BF12F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD78CE0", Offset = "0xD77AE0", VA = "0x180D78CE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xB34C90", Offset = "0xB33A90", VA = "0x180B34C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1120", Offset = "0x6BEFF20", VA = "0x186BF1120")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1190", Offset = "0x6BEFF90", VA = "0x186BF1190", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6BF1210", Offset = "0x6BF0010", VA = "0x186BF1210")]
		protected FaceFeatureBase()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
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
