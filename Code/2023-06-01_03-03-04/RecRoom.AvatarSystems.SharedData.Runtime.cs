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
	[Cpp2IlInjected.Address(RVA = "0x6B8A100", Offset = "0x6B88D00", VA = "0x186B8A100")]
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
		public GBAHALBBEFO lod;

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
public struct HODFHMJIMBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Transform PFIIKGJGEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public GameObject DACIOBKDLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public SkinnedMeshRenderer[] LGGKDCJDDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public SkinnedMeshRenderer[] PPEBBBEHOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GameObject DEPKGOOGJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public SkinnedMeshRenderer[] PDDAPGANCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public SkinnedMeshRenderer[] GHJHFDLLGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public BPENBINGFEG IOLGMJGGMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Material ONHINMLPEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Material OCGEHLGDJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Shader PMMIJKHHFLO;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GKOBCNEHGDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool KOINKKEPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool CMEDELPODLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool DIGPLEHLBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool GPEKJGPHOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool KGIENKLDBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool DOKPDCGECGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool AFPLMPHALMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public IList<LGPEMFBELOM> LIMPCNNHIEG;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public GKOBCNEHGDK()
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
		private BPENBINGFEG NAJEGOKIOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Collider[] KIHEGJBMFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Collider[] JKLAGLFNIDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6B908C0", Offset = "0x6B8F4C0", VA = "0x186B908C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B90840", Offset = "0x6B8F440", VA = "0x186B90840")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B90A80", Offset = "0x6B8F680", VA = "0x186B90A80")]
		public void UpdateBones(BPENBINGFEG ACINIJFNLCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B90930", Offset = "0x6B8F530", VA = "0x186B90930")]
		public void SetCollidersEnabled(bool CNIPDMAOMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B90AB0", Offset = "0x6B8F6B0", VA = "0x186B90AB0")]
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
public static class GNPIMDGJEJG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E850", Offset = "0x6B8D450", VA = "0x186B8E850")]
	public static bool EMDPCMPEBIJ(this OutfitType IKBANGCDGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E830", Offset = "0x6B8D430", VA = "0x186B8E830")]
	public static bool CALHIAEHCDB(this OutfitType IKBANGCDGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E8A0", Offset = "0x6B8D4A0", VA = "0x186B8E8A0")]
	public static bool KLPFLMHEJAH(this OutfitType IKBANGCDGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E870", Offset = "0x6B8D470", VA = "0x186B8E870")]
	public static bool FILEKNCJFKB(this OutfitType IKBANGCDGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E890", Offset = "0x6B8D490", VA = "0x186B8E890")]
	public static bool KJJODPOEIFJ(this OutfitType IKBANGCDGJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E880", Offset = "0x6B8D480", VA = "0x186B8E880")]
	public static bool GGKAFHGIBMI(this OutfitType IKBANGCDGJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MDIGMGPMAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Transform HCKBFBJOIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Transform JOODNJOOBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Transform AEAOOEFKOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Transform GDLBAKALCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Transform NIGOLENJDND;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OEGHAAJOEPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public SkinnedMeshRenderer[] KDCPDJJBPPG;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct CFABIGPOLKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NBGAHJGPDCB JNLDBPOCGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int CJJHKCJEJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int KHMKJEJNJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color MLGLNDGLLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color HLJOHLKJOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int JHBFCKPAKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int MGGMBOMDEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color DABAAHBFFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Color NJOFPGHMLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int JLCFKPLDKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float AJAFNAPIPPA;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LPNHJHPGICP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public NBGAHJGPDCB JNLDBPOCGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 POCCBEDMHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float BCPMABAKMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 GEOKAHCPEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float IEGPFGEOOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 LGBDPKNGJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float IPFFKELNFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float JEMGMAMBLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 DEENDPMHCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 ICJBMFAPGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool KFPDFPDIMHJ;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x10C7230", Offset = "0x10C5E30", VA = "0x1810C7230")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B8A1C0", Offset = "0x6B88DC0", VA = "0x186B8A1C0")]
		public string JNAHDGIKJJA(string NLGIGIIDJDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A210", Offset = "0x6B88E10", VA = "0x186B8A210")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum BPKPEFGIOMG
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NLIHKHOHEFB
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly NLIHKHOHEFB OAEIAFEPBFB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HEDEBEIEAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F3000", Offset = "0x7F1C00", VA = "0x1807F3000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F33D0", Offset = "0x7F1FD0", VA = "0x1807F33D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BPKPEFGIOMG JGALFJHBHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F3220", Offset = "0x7F1E20", VA = "0x1807F3220")]
		[CompilerGenerated]
		get
		{
			return default(BPKPEFGIOMG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F33E0", Offset = "0x7F1FE0", VA = "0x1807F33E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public NLIHKHOHEFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FF60", Offset = "0x6B8EB60", VA = "0x186B8FF60")]
	public NLIHKHOHEFB(BPKPEFGIOMG JBENBACJFCK, int FDEKFCEMPEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DKEAEIFKBPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Mesh EDPBDPPOBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Material[] MAKJEMFEEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool GLDHJDDFLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool OCJBOFGLEBO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	private DKEAEIFKBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C400", Offset = "0x6B8B000", VA = "0x186B8C400")]
	public DKEAEIFKBPE(Mesh BJKOLELNNLB, Material[] HFEAIJALGOB, bool IDOCIAPBMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C510", Offset = "0x6B8B110", VA = "0x186B8C510")]
	public DKEAEIFKBPE(SkinnedMeshRenderer FLHJDPHFAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C090", Offset = "0x6B8AC90", VA = "0x186B8C090")]
	public static DKEAEIFKBPE BLCEFHIOAAD(Renderer HNDABHJLKOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IOCOKPJKHEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly GameObject GAOJGJLCNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly AvatarItemMaterial JDLPHFOGKAA;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
	public IOCOKPJKHEA(GameObject GAOJGJLCNBK, AvatarItemMaterial JDLPHFOGKAA)
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
			[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A0A0", Offset = "0x6B88CA0", VA = "0x186B8A0A0")]
		public static void FHDOJMBIMOM(AvatarItemMaterial BGFCKLHIKLO, Material IJIKACDMPFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B8A100", Offset = "0x6B88D00", VA = "0x186B8A100")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AAEPAFEJHPH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Vector3 MHBJHMMMLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OGBLEPNHKFG : AAEPAFEJHPH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Transform ELJOBKLNFLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x842A50", Offset = "0x841650", VA = "0x180842A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 MHBJHMMMLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x13A9640", Offset = "0x13A8240", VA = "0x1813A9640", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x13A9610", Offset = "0x13A8210", VA = "0x1813A9610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float? BEABJCCHAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x13A9620", Offset = "0x13A8220", VA = "0x1813A9620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x13A9630", Offset = "0x13A8230", VA = "0x1813A9630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public OGBLEPNHKFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BJNNJEBABAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	protected readonly OGBLEPNHKFG FBGGMPMEFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	protected readonly OGBLEPNHKFG IFHBGNIGKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly OGBLEPNHKFG ILAFDPHBPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly OGBLEPNHKFG KHAHDPNGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly OGBLEPNHKFG EFDEJLPDPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly OGBLEPNHKFG PPEAKCMILPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly OGBLEPNHKFG HHCOPJPFPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly OGBLEPNHKFG ILMDBLIPCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly OGBLEPNHKFG JOFMEKPOIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly OGBLEPNHKFG KNAGPOPBDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly OGBLEPNHKFG IALDCOLODKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly OGBLEPNHKFG HLDPIPDLCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly OGBLEPNHKFG BNBCNKKMDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected OGBLEPNHKFG LJNBJJPEAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected readonly OGBLEPNHKFG GJKDNLKLDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	protected readonly OGBLEPNHKFG ILKACDPFFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	protected readonly OGBLEPNHKFG LCEBMPFKMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected OGBLEPNHKFG HHKIAMKGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected readonly OGBLEPNHKFG MDABIBGGEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected readonly OGBLEPNHKFG OELAJBCCLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	protected readonly OGBLEPNHKFG MGCHNDKEMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected ReadOnlyCollection<OGBLEPNHKFG> DNNPDIDPJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Transform FKHFCBJDPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private (OGBLEPNHKFG Start, OGBLEPNHKFG End)[] GKNBLNNFGNI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public AAEPAFEJHPH FMHFFCEHDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x839000", Offset = "0x837C00", VA = "0x180839000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AAEPAFEJHPH DECKCNOIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AAEPAFEJHPH CBMGOONFBHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public AAEPAFEJHPH GOCOHOKFBBB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public AAEPAFEJHPH MNCDNMPMGHL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public AAEPAFEJHPH JFMNGHANNML
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x843910", Offset = "0x842510", VA = "0x180843910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AAEPAFEJHPH DEKCEEDDDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89C580", Offset = "0x89B180", VA = "0x18089C580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OGBLEPNHKFG JMELAMJKBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89C580", Offset = "0x89B180", VA = "0x18089C580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AAEPAFEJHPH HNKOAFBIGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8390B0", Offset = "0x837CB0", VA = "0x1808390B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public OGBLEPNHKFG DNNDCGLBONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8390B0", Offset = "0x837CB0", VA = "0x1808390B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public AAEPAFEJHPH IPOIPNOKEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x839070", Offset = "0x837C70", VA = "0x180839070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AAEPAFEJHPH DAIGGMDIILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8390A0", Offset = "0x837CA0", VA = "0x1808390A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public AAEPAFEJHPH CDDCBJCJACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x839080", Offset = "0x837C80", VA = "0x180839080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OGBLEPNHKFG LIEGIJMFBME
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x839080", Offset = "0x837C80", VA = "0x180839080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public OGBLEPNHKFG KAEOEJGCLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x839090", Offset = "0x837C90", VA = "0x180839090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AAEPAFEJHPH MOMDOEBLJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x839090", Offset = "0x837C90", VA = "0x180839090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public AAEPAFEJHPH NIIFCIJAAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x839010", Offset = "0x837C10", VA = "0x180839010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public AAEPAFEJHPH DPAABACBNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x839020", Offset = "0x837C20", VA = "0x180839020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AAEPAFEJHPH OFDJEFDMPME
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85F070", Offset = "0x85DC70", VA = "0x18085F070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public AAEPAFEJHPH ALNKNNBMNOB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9A4AD0", Offset = "0x9A36D0", VA = "0x1809A4AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AAEPAFEJHPH APHLKOMGMON
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x886AE0", Offset = "0x8856E0", VA = "0x180886AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public AAEPAFEJHPH LNCBPNJKAMM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85F040", Offset = "0x85DC40", VA = "0x18085F040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public AAEPAFEJHPH GGLMEKMEOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x839030", Offset = "0x837C30", VA = "0x180839030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public AAEPAFEJHPH FPALGBNGICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x839040", Offset = "0x837C40", VA = "0x180839040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public AAEPAFEJHPH DEKOMFKEMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x839060", Offset = "0x837C60", VA = "0x180839060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public IReadOnlyList<AAEPAFEJHPH> JLGPNLKCABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x839050", Offset = "0x837C50", VA = "0x180839050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6B8A260", Offset = "0x6B88E60", VA = "0x186B8A260")]
	public void CDPDNHGALAJ(VRIK BEMIKFAFEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1170", Offset = "0x1D9FD70", VA = "0x181DA1170")]
	private void OPIFGKBACPM(Transform PDHOFJLLEID, OGBLEPNHKFG CBHLPGJGAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AE30", Offset = "0x6B89A30", VA = "0x186B8AE30")]
	public void MGHJDPHEMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1BA0", Offset = "0x1DA07A0", VA = "0x181DA1BA0")]
	public float PKDAHGOHGMC(in (OGBLEPNHKFG Start, OGBLEPNHKFG End) ECJIFPDEKEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6B8AC50", Offset = "0x6B89850", VA = "0x186B8AC50")]
	public void FJAHBNKLCCG(in BKMAIDLGMJM LLBKKANHBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B2E0", Offset = "0x6B89EE0", VA = "0x186B8B2E0")]
	private Vector3 NFKJOCHMGOF(in (OGBLEPNHKFG Start, OGBLEPNHKFG End) ECJIFPDEKEH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B440", Offset = "0x6B8A040", VA = "0x186B8B440")]
	public BJNNJEBABAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BPENBINGFEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private List<Transform> BDNNNNMDAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Matrix4x4[] NMCICEGHMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private Dictionary<string, Transform> HADHCKJCCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private Dictionary<Transform, Transform> OELELCNMANC;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Transform[] OMLAFHFDADJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BED0", Offset = "0x6B8AAD0", VA = "0x186B8BED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Matrix4x4[] OACNNMKCAND
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9897A0", Offset = "0x9883A0", VA = "0x1809897A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B7E0", Offset = "0x6B8A3E0", VA = "0x186B8B7E0")]
	public void CDNDMNOFLGJ(SkinnedMeshRenderer HNDABHJLKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8B990", Offset = "0x6B8A590", VA = "0x186B8B990")]
	public void FHBIEGACMCB(Transform AAIPFFMAKJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BA00", Offset = "0x6B8A600", VA = "0x186B8BA00")]
	private Transform HEGLGLCODKI(Transform ECDNDIBFKBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BAE0", Offset = "0x6B8A6E0", VA = "0x186B8BAE0")]
	public void HMJIBKKCMGC(BPENBINGFEG GKJCDCMFONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BD60", Offset = "0x6B8A960", VA = "0x186B8BD60")]
	private void PAMEPMNNAKM(Transform PMBNHDHBMIA, List<Transform> MMMOCGAEDDF, Dictionary<string, Transform> DCAEPAPLFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BF20", Offset = "0x6B8AB20", VA = "0x186B8BF20")]
	public BPENBINGFEG()
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
		public enum OBOMAONGKKM
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
		private OBOMAONGKKM useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1C79A00", Offset = "0x1C78600", VA = "0x181C79A00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA58090", Offset = "0xA56C90", VA = "0x180A58090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9A1940", Offset = "0x9A0540", VA = "0x1809A1940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9A1E40", Offset = "0x9A0A40", VA = "0x1809A1E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x88FE20", Offset = "0x88EA20", VA = "0x18088FE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9A19B0", Offset = "0x9A05B0", VA = "0x1809A19B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9A1EC0", Offset = "0x9A0AC0", VA = "0x1809A1EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x13F6100", Offset = "0x13F4D00", VA = "0x1813F6100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x13F64C0", Offset = "0x13F50C0", VA = "0x1813F64C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8390B0", Offset = "0x837CB0", VA = "0x1808390B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9660D0", Offset = "0x964CD0", VA = "0x1809660D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1128B70", Offset = "0x1127770", VA = "0x181128B70")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x989550", Offset = "0x988150", VA = "0x180989550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x165C120", Offset = "0x165AD20", VA = "0x18165C120")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1D2AC20", Offset = "0x1D29820", VA = "0x181D2AC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x839080", Offset = "0x837C80", VA = "0x180839080")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x888F20", Offset = "0x887B20", VA = "0x180888F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x839090", Offset = "0x837C90", VA = "0x180839090")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x888F00", Offset = "0x887B00", VA = "0x180888F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x839010", Offset = "0x837C10", VA = "0x180839010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x84B170", Offset = "0x849D70", VA = "0x18084B170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x839020", Offset = "0x837C20", VA = "0x180839020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x85A6F0", Offset = "0x8592F0", VA = "0x18085A6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x85F070", Offset = "0x85DC70", VA = "0x18085F070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x85A6D0", Offset = "0x8592D0", VA = "0x18085A6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9A4AD0", Offset = "0x9A36D0", VA = "0x1809A4AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8869D0", Offset = "0x8855D0", VA = "0x1808869D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x886AE0", Offset = "0x8856E0", VA = "0x180886AE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9F1260", Offset = "0x9EFE60", VA = "0x1809F1260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x85F040", Offset = "0x85DC40", VA = "0x18085F040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA5B070", Offset = "0xA59C70", VA = "0x180A5B070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xC97590", Offset = "0xC96190", VA = "0x180C97590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC975A0", Offset = "0xC961A0", VA = "0x180C975A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public OBOMAONGKKM UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x6B89FB0", Offset = "0x6B88BB0", VA = "0x186B89FB0")]
			get
			{
				return default(OBOMAONGKKM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xE1EC00", Offset = "0xE1D800", VA = "0x180E1EC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1D3C2B0", Offset = "0x1D3AEB0", VA = "0x181D3C2B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1D3C130", Offset = "0x1D3AD30", VA = "0x181D3C130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6B89F90", Offset = "0x6B88B90", VA = "0x186B89F90")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6B8A080", Offset = "0x6B88C80", VA = "0x186B8A080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x882A10", Offset = "0x881610", VA = "0x180882A10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x882E30", Offset = "0x881A30", VA = "0x180882E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6B89FE0", Offset = "0x6B88BE0", VA = "0x186B89FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1078BA0", Offset = "0x10777A0", VA = "0x181078BA0")]
		public string ECCPKOGLKLF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6B89B70", Offset = "0x6B88770", VA = "0x186B89B70")]
		public static AvatarCustomizationSettings NLJPEOGMFGO(string EMENJDCGEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6B89D10", Offset = "0x6B88910", VA = "0x186B89D10")]
		public AvatarCustomizationSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum FIHDNPMKAPL
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
public enum FLIFJGIIKPM
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
public enum BHILEJJCHLD
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
public enum PHNJJLHBDBB
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
public enum OFDBOJDJLCL
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
public enum PJLDFNCNHNL
{
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum MFHBNBBMBDF
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
public enum AKJEDMFCHAG
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
public enum DFGFMPAIPCC
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
public static class EICFOIFBFKJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly int DJFJLGDPGFG;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static readonly string MAOCGALAMPD;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static readonly string PEMLEDAFMFH;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C8C0", Offset = "0x6B8B4C0", VA = "0x186B8C8C0")]
	public static BKMAIDLGMJM IDDOGLMFEHD()
	{
		return default(BKMAIDLGMJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C990", Offset = "0x6B8B590", VA = "0x186B8C990")]
	public static OCHJCOLAMFO JBIIJHBPPCH(Transform GIKHMDFMMPA, Transform NOMLHHDBPNK, AvatarConfiguration NHDPMDDKIPK, Animator BAKKICBEBEO, VRIK LLMFOIMOAPE, SkeletonLODUpdateRate[] HPDJCPHCFMF, GameObject[] PHENAHHEAPM, Transform FKHFCBJDPBM, GameObject HLLELDMHBCF, BodySkinnedMeshLODs ADNPPGNKLPF, BodySkinnedMeshLODs ONHEPLPEHPM, GameObject EDPEBPEIEND, BodySkinnedMeshLODs MDGDPMMKMAH, BodySkinnedMeshLODs MPLEBELCKEK, BPENBINGFEG ACINIJFNLCB, Material LKHAJJOFNGA, Material HBIMJJBJCPK, Shader EPBODOEMMEK, Transform IGGLMDIDFEB, Transform NBJPFENICCM, Transform CMEPONFGDEF, Transform AEDDHJNEDHA, Transform GFMLBENFEHL)
	{
		return default(OCHJCOLAMFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CD10", Offset = "0x6B8B910", VA = "0x186B8CD10")]
	public static HGABCAOHBOO PDIHOGMBDNO(string JEDPGPDIHHP, bool NOIJIDLNHPB, bool FJBBHJHGLCK, bool ICJNPNDNPID, RigidbodyEx ECPGJKIIMGB, RigidbodyEx FLHKONCNAJO, RigidbodyEx OGANBKHLINE, RigidbodyEx LAICNMCCFDC, Transform PKBMEEKAOPG, Transform CNAPEFBLJLC, Transform LLNFPOHIHNH, float MIANNJMFGNE, float NAOEENCEEEF, PlayerAvatarFullBodyColliders JELJNIKONPD)
	{
		return default(HGABCAOHBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C630", Offset = "0x6B8B230", VA = "0x186B8C630")]
	public static HODFHMJIMBJ EKBIBPOGJLA(Transform NOMLHHDBPNK, GameObject HLLELDMHBCF, SkinnedMeshRenderer[] GHKMFHBBEEL, SkinnedMeshRenderer[] LPCCHHABICA, GameObject EDPEBPEIEND, SkinnedMeshRenderer[] MCNMADAFALG, SkinnedMeshRenderer[] OJBKDKGMGPD, BPENBINGFEG ACINIJFNLCB, Material LKHAJJOFNGA, Material HBIMJJBJCPK, Shader EPBODOEMMEK)
	{
		return default(HODFHMJIMBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CC40", Offset = "0x6B8B840", VA = "0x186B8CC40")]
	public static MDIGMGPMAGF OKKKBLKGPDD(Transform IGGLMDIDFEB, Transform CMEPONFGDEF, Transform NBJPFENICCM, Transform AEDDHJNEDHA, Transform GFMLBENFEHL)
	{
		return default(MDIGMGPMAGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x14241C0", Offset = "0x1422DC0", VA = "0x1814241C0")]
	public static OEGHAAJOEPF GNFGLBHBOKJ(SkinnedMeshRenderer[] OOMLONHMHMD)
	{
		return default(OEGHAAJOEPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CE70", Offset = "0x6B8BA70", VA = "0x186B8CE70")]
	public static CFABIGPOLKH PDPJHJPHOPP(NBGAHJGPDCB MEBANHKGFLO, int CNFCALFDDPL, int BBOJCJDDLEG, Color KDHEPJLFCDI, Color AJJBNJJAFIL, int HCAHNPGKMOM, int KAIDKHKEEBH, Color IIFGDCCPMGO, Color DGHGPBIHOLB, int OKLIKHDKPEP, float FLPMJNHNNDM)
	{
		return default(CFABIGPOLKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C790", Offset = "0x6B8B390", VA = "0x186B8C790")]
	public static LPNHJHPGICP ENBFMBPEPOP(NBGAHJGPDCB MEBANHKGFLO, Vector2 JEOHBDFJPJB, float FEBBJJCAOJC, Vector2 KDEMOFJMDGN, float CLCPNDBAKMC, Vector2 FGEJIEOPNNN, float EKJGMPENBJP, float BOKDIJICMMI, Vector2 MDGFFBINFCG, Vector2 CIPMKEPAFIL)
	{
		return default(LPNHJHPGICP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FHJNILBJLMD
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLMEOJBKKNE();

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BMMLLBKLJDM<Texture2D> BHDJHDHMLOD(CDBHCNMGOKC JCPJGLNCOPL, [Optional] NLIHKHOHEFB DAKKAABHBLK);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class OGPLEODFKGH : FHJNILBJLMD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NFDAHAJDIJE OAOGFDMJFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private IRecRoomQualityConfigProvider FINBNFJNEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool HAGLEANKLEF;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private const uint ANEGKPKGBFD = 16u;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B90410", Offset = "0x6B8F010", VA = "0x186B90410")]
	[BBAPFPLPODF(EDNJEIFHIMJ.GameOnly)]
	private static void IFNFNIBBJEP(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x98A950", Offset = "0x989550", VA = "0x18098A950")]
	[Preserve]
	public OGPLEODFKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B906C0", Offset = "0x6B8F2C0", VA = "0x186B906C0")]
	private void NDBOMMNIGKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B903B0", Offset = "0x6B8EFB0", VA = "0x186B903B0", Slot = "4")]
	public void HLMEOJBKKNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FFA0", Offset = "0x6B8EBA0", VA = "0x186B8FFA0", Slot = "5")]
	public BMMLLBKLJDM<Texture2D> BHDJHDHMLOD(CDBHCNMGOKC JCPJGLNCOPL, [Optional] NLIHKHOHEFB DAKKAABHBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6B90500", Offset = "0x6B8F100", VA = "0x186B90500")]
	private uint MFNDPMIEGFE(CDBHCNMGOKC JCPJGLNCOPL, NLIHKHOHEFB DAKKAABHBLK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HGABCAOHBOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public string PDDEAPEEHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public bool KKEEIKKKIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public bool JHDPLGIJPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public float ONHKKEELLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public float GIFMLENHHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public bool KNPBCKDIMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public RigidbodyEx JAOHOAHANNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public RigidbodyEx IHFHFPJDIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public RigidbodyEx BLCCFCNMDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public RigidbodyEx LDEDJHEEDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public Transform EBONDBMHAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform JHLHPANAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform JDCCDJFFGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public PlayerAvatarFullBodyColliders LHBOOIHIOKH;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct OCHJCOLAMFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform KBGCOCFPMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform ABGAMKKLPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public AvatarConfiguration MPBPOLHBNOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Animator LKMLKLPJDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public VRIK ICEBHIKHOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public SkeletonLODUpdateRate[] NLEFGPIHOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public GameObject[] PIPJLCILAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform BLINAJIKLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public GameObject DACIOBKDLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public BodySkinnedMeshLODs BIDGOHKFKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public BodySkinnedMeshLODs INCMPGCLKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public GameObject DEPKGOOGJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public BodySkinnedMeshLODs OLIBCKFBMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public BodySkinnedMeshLODs CFEKNMOJAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public BPENBINGFEG IOLGMJGGMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Material ONHINMLPEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Material OCGEHLGDJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Shader PMMIJKHHFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Transform HCKBFBJOIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Transform AEAOOEFKOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform JOODNJOOBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Transform GDLBAKALCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform NIGOLENJDND;
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BKMAIDLGMJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public float DPLBEPDJHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public bool JPNLCENJBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public GBAHALBBEFO JKHKBEPHNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 BMKBOHDJIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 JPHGKPPNKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3? KMFHKMOEPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public Vector3? GAOKFGHAFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool BPBFLJEOGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public bool COCPNCGAGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool PPMFNAMNENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public bool PCGKPPBFKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public bool CHDJIBJCNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Vector3? DHJDFOHDNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool DMIGJPOEOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public Vector3? ICJJHIJCHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool NBDMPNFFOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3? DFJPHPFEELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3? FJDGDNNCNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public bool PNKCLFOEEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool LCCHEGNBBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool NGMHOBLDPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool HLEHPLEBJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool HGMEDHOMLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool CNLMPLHAIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool MCDOEPFOGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool LGAJMIIANGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool EILMKAMBNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool CMLINLGHPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? OBPLOIHPIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public FIHDNPMKAPL KPBLFODEPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public FIHDNPMKAPL JLJPIDILICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public float FEPDELLLIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public float NFLFIBFNKAC;
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
			[Cpp2IlInjected.Address(RVA = "0x6B8E820", Offset = "0x6B8D420", VA = "0x186B8E820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6B8E760", Offset = "0x6B8D360", VA = "0x186B8E760")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DFA0", Offset = "0x6B8CBA0", VA = "0x186B8DFA0")]
		public void FKBNGAHEJIF(FitMeshHemisphere LPMGKHEEBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6B8E030", Offset = "0x6B8CC30", VA = "0x186B8E030")]
		public Vector3 KHJNLADEAPA(Vector2 AKGGPABKICO, bool CDPDJNDNFAI = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DF40", Offset = "0x6B8CB40", VA = "0x186B8DF40")]
		public Vector3 BPDBAEKOCIM(Vector2 AKGGPABKICO)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8E4A0", Offset = "0x6B8D0A0", VA = "0x186B8E4A0")]
		public Quaternion MLJPFMOCGPE(Vector2 AKGGPABKICO)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6B8E390", Offset = "0x6B8CF90", VA = "0x186B8E390")]
		public Quaternion MLJPFMOCGPE(Vector2 AKGGPABKICO, Vector3 BCCBMBAIMGA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DFF0", Offset = "0x6B8CBF0", VA = "0x186B8DFF0")]
		private Vector2 HNPEFJLOLOP(Vector2 KIBLFJGAABN)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LGPEMFBELOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public string EKPDCEFJBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public OutfitType OCMHEKALANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public BHILEJJCHLD CBMNMCFEDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public bool KJGEKKHFOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public Color? INGINNEEGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Vector3? MCBABLLLBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public float? ECJNCMNLBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public Guid? BDLDJHHAJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public OLJOPCMAMGM? HDDAIDJJGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Color? KJFGAJNMMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool FPFGGJOMNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool PLCCKDFFCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public AnchorParamsRestrictions HBBNIOMKFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public Vector2? LGFGJCIKIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public Transform LPOBGJGEFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public FitMeshHemisphere NMGNMNNIIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public Vector2 HPPKDNLADGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private List<AvatarHairPatternOverride> JEBIPJJKDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Dictionary<string, Texture2D> DAPAOMGMKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private List<AvatarHairPatternOverride> EPCLOIINOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Dictionary<string, Texture2D> JIMEDMBNHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public AssetReference BCNGBMBBIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public AssetReference DEOAFADJNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public AssetReference[] OEKOJADFDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public bool JAJDDJAFPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public bool PGLMLOOLCJK;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public List<AvatarHairPatternOverride> OKEENDFLNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE77CE0", Offset = "0xE768E0", VA = "0x180E77CE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EAA0", Offset = "0x6B8D6A0", VA = "0x186B8EAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public List<AvatarHairPatternOverride> BHJGLFBPIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x12E0B30", Offset = "0x12DF730", VA = "0x1812E0B30")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6B8ED80", Offset = "0x6B8D980", VA = "0x186B8ED80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string JAPINFBOCIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6B8ECD0", Offset = "0x6B8D8D0", VA = "0x186B8ECD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EFB0", Offset = "0x6B8DBB0", VA = "0x186B8EFB0")]
	public LGPEMFBELOM()
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
			[Cpp2IlInjected.Address(RVA = "0x6B89B00", Offset = "0x6B88700", VA = "0x186B89B00")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6B89AD0", Offset = "0x6B886D0", VA = "0x186B89AD0")]
		public AnchorParams(Vector2 FHPPMALLHNF, Vector3 PAJCDGGAEIM, Vector3 LKOHMLFAMEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6B89960", Offset = "0x6B88560", VA = "0x186B89960")]
		public AnchorParams(KCKPMJEGJBK IPDFOPOOJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6B89870", Offset = "0x6B88470", VA = "0x186B89870", Slot = "4")]
		public bool Equals(AnchorParams MDHJAFNLPON)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KCKPMJEGJBK
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool EMLIDHEFHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool MJPMIJFCKMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool KKHFLPLOJCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool NHDLCNEOCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool LILOMNADJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool HHILKAOMFEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FKOLFBHJKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool NMLHFIIFJAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	float GHIGAINAHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	float PIONMKNMPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	float PPNEOBLJHGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float IBPLEMLNIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float MDPDOBPIOIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	float PHHNCNENJFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float MOFOGPJJPFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float CPKPCPFGNKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	float BOOGCIONMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float HHPBCHPMEIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float GGEJAFCIEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float MGIMGHDABJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float KFKLEHIPHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float CNEDLCCNAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float JMJLIDABGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float LEIFJMFFOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 HGBGDONJBIG(Vector3 LKOHMLFAMEJ);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FHKPDOPACPH(Vector3 DGLKANAOFAL);

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 BOLPEBBFIIN();

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 ELAKNGMEMBL();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AnchorParamsRestrictions : KCKPMJEGJBK
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
			[Cpp2IlInjected.Address(RVA = "0x6B897E0", Offset = "0x6B883E0", VA = "0x186B897E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6B89810", Offset = "0x6B88410", VA = "0x186B89810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x6B89840", Offset = "0x6B88440", VA = "0x186B89840", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6B89750", Offset = "0x6B88350", VA = "0x186B89750", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x6B89780", Offset = "0x6B88380", VA = "0x186B89780", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6B897B0", Offset = "0x6B883B0", VA = "0x186B897B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xDF50D0", Offset = "0xDF3CD0", VA = "0x180DF50D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2CBBA80", Offset = "0x2CBA680", VA = "0x182CBBA80", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1125150", Offset = "0x1123D50", VA = "0x181125150", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1143F70", Offset = "0x1142B70", VA = "0x181143F70", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xE1B280", Offset = "0xE19E80", VA = "0x180E1B280", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xE186F0", Offset = "0xE172F0", VA = "0x180E186F0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xE1B290", Offset = "0xE19E90", VA = "0x180E1B290", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xE71260", Offset = "0xE6FE60", VA = "0x180E71260", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xE87210", Offset = "0xE85E10", VA = "0x180E87210", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1940280", Offset = "0x193EE80", VA = "0x181940280", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x12E5510", Offset = "0x12E4110", VA = "0x1812E5510", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x15F43E0", Offset = "0x15F2FE0", VA = "0x1815F43E0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x4D846A0", Offset = "0x4D832A0", VA = "0x184D846A0", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x16886B0", Offset = "0x16872B0", VA = "0x1816886B0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x20C9650", Offset = "0x20C8250", VA = "0x1820C9650", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xF22010", Offset = "0xF20C10", VA = "0x180F22010", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x638E2B0", Offset = "0x638CEB0", VA = "0x18638E2B0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1BE12D0", Offset = "0x1BDFED0", VA = "0x181BE12D0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B896C0", Offset = "0x6B882C0", VA = "0x186B896C0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B89450", Offset = "0x6B88050", VA = "0x186B89450")]
		public AnchorParams LLMLEAHOOPA(AnchorParams KCOBKDPJDJC)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B892B0", Offset = "0x6B87EB0", VA = "0x186B892B0", Slot = "30")]
		public Vector3 BOLPEBBFIIN()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6B892E0", Offset = "0x6B87EE0", VA = "0x186B892E0", Slot = "31")]
		public Vector3 ELAKNGMEMBL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6B893B0", Offset = "0x6B87FB0", VA = "0x186B893B0", Slot = "28")]
		public Vector3 HGBGDONJBIG(Vector3 LKOHMLFAMEJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B89310", Offset = "0x6B87F10", VA = "0x186B89310", Slot = "29")]
		public Vector3 FHKPDOPACPH(Vector3 DGLKANAOFAL)
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
			[Cpp2IlInjected.Address(RVA = "0x83DBC0", Offset = "0x83C7C0", VA = "0x18083DBC0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EFC0", Offset = "0x6B8DBC0", VA = "0x186B8EFC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B8DF20", Offset = "0x6B8CB20", VA = "0x186B8DF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D720", Offset = "0x6B8C320", VA = "0x186B8D720")]
		public NBGAHJGPDCB AHJICAKOJON(int MAPCKMLDOCO, int OAFAGICEJDE, int APALAMANPAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DC30", Offset = "0x6B8C830", VA = "0x186B8DC30")]
		public FaceFeatureBase NFBBCOKLPDF(FaceFeatureType BCEDBKLELIB, string PCFHAIHNKAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D920", Offset = "0x6B8C520", VA = "0x186B8D920")]
		public int DJIIHAOCIHN(string PCFHAIHNKAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DA80", Offset = "0x6B8C680", VA = "0x186B8DA80")]
		private void MLFJDCBPPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4251420", Offset = "0x4250020", VA = "0x184251420")]
		private void GJEBJMIAGDK<T>(Dictionary<string, T> BAOLHJKGDLB, T[] OOFCAFKOAFA) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D9B0", Offset = "0x6B8C5B0", VA = "0x186B8D9B0")]
		public string IPCHPOLBOFF(FaceFeatureType BCEDBKLELIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DD80", Offset = "0x6B8C980", VA = "0x186B8DD80")]
		public string NGDEPCNEGFF(FaceFeatureType BCEDBKLELIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6B8DEA0", Offset = "0x6B8CAA0", VA = "0x186B8DEA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x83D520", Offset = "0x83C120", VA = "0x18083D520", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6B8D3B0", Offset = "0x6B8BFB0", VA = "0x186B8D3B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6B8D3F0", Offset = "0x6B8BFF0", VA = "0x186B8D3F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x20FD050", Offset = "0x20FBC50", VA = "0x1820FD050")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x20FD9D0", Offset = "0x20FC5D0", VA = "0x1820FD9D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x38330C0", Offset = "0x3831CC0", VA = "0x1838330C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7B0", Offset = "0x9EA3B0", VA = "0x1809EB7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6B8D3D0", Offset = "0x6B8BFD0", VA = "0x186B8D3D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7C0", Offset = "0x9EA3C0", VA = "0x1809EB7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D030", Offset = "0x6B8BC30", VA = "0x186B8D030", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D2D0", Offset = "0x6B8BED0", VA = "0x186B8D2D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x83DBB0", Offset = "0x83C7B0", VA = "0x18083DBB0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C020", Offset = "0x6B8AC20", VA = "0x186B8C020")]
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
			[Cpp2IlInjected.Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EFC0", Offset = "0x6B8DBC0", VA = "0x186B8EFC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B8D700", Offset = "0x6B8C300", VA = "0x186B8D700")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9A4BE0", Offset = "0x9A37E0", VA = "0x1809A4BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1A48210", Offset = "0x1A46E10", VA = "0x181A48210")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xD20EE0", Offset = "0xD1FAE0", VA = "0x180D20EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D5F0", Offset = "0x6B8C1F0", VA = "0x186B8D5F0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D680", Offset = "0x6B8C280", VA = "0x186B8D680")]
		protected FaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class NBGAHJGPDCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private class OMOCFLEPDMM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public readonly Texture2DArray CANBIMGOPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public readonly Dictionary<string, int> PNIAJBLKMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private readonly FMDOKKBAPOM MEOOLPIHAHO;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool AFLIKODPLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x150D940", Offset = "0x150C540", VA = "0x18150D940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6B90770", Offset = "0x6B8F370", VA = "0x186B90770")]
		public OMOCFLEPDMM(Texture2DArray HFNACOCLGLD, Dictionary<string, int> FJDKKONFAAP, NBGAHJGPDCB BDJFFKGEILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x150C1E0", Offset = "0x150ADE0", VA = "0x18150C1E0")]
		public void JNFIEFGFBCF(NBGAHJGPDCB FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x150BDE0", Offset = "0x150A9E0", VA = "0x18150BDE0")]
		public void KLCBFGAJLHO(NBGAHJGPDCB FLDJLPKNKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x168A740", Offset = "0x1689340", VA = "0x18168A740", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private struct KIAFEEDLPDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly string HFNHIMOMMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly string FILPPJEEMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly string GEEOEKGNFKE;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x91C510", Offset = "0x91B110", VA = "0x18091C510")]
		public KIAFEEDLPDH(string PNNJIGHFJBP, string PACDGFCIIPM, string JOKDFPBKOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EA10", Offset = "0x6B8D610", VA = "0x186B8EA10")]
		public bool FMOLALLCICL(KIAFEEDLPDH MDHJAFNLPON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6B8E940", Offset = "0x6B8D540", VA = "0x186B8E940", Slot = "0")]
		public override bool Equals(object HHNPCHNMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5B35DE0", Offset = "0x5B349E0", VA = "0x185B35DE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EA10", Offset = "0x6B8D610", VA = "0x186B8EA10")]
		public static bool FMMDKFLNNFA(KIAFEEDLPDH FDMHBFLJJHC, KIAFEEDLPDH DNGDHCADJJH)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6B8E8B0", Offset = "0x6B8D4B0", VA = "0x186B8E8B0")]
		public static bool BDPOAMCDIDB(KIAFEEDLPDH FDMHBFLJJHC, KIAFEEDLPDH DNGDHCADJJH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly Dictionary<string, int> FJDKKONFAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly KIAFEEDLPDH JKGIGAGBJKD;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public Texture2DArray OEICHPKFGJN
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public SymmetricalFaceFeature HHINKHEIEOE
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83D1E0", Offset = "0x83BDE0", VA = "0x18083D1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x85E2C0", Offset = "0x85CEC0", VA = "0x18085E2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public EyesFaceFeature KJJHFGELBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3240", Offset = "0x7F1E40", VA = "0x1807F3240")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3400", Offset = "0x7F2000", VA = "0x1807F3400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public FaceFeature IMLNMELFOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x88FE20", Offset = "0x88EA20", VA = "0x18088FE20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F050", Offset = "0x6B8DC50", VA = "0x186B8F050")]
	private static void OBMBJCGDKAP(Sprite FJOCJPJEAML, Sprite JJJPPPHKEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EFE0", Offset = "0x6B8DBE0", VA = "0x186B8EFE0")]
	private static void KAFNOFKGDFB(Sprite POCNICPLMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F360", Offset = "0x6B8DF60", VA = "0x186B8F360")]
	public NBGAHJGPDCB(EyesFaceFeature OAFAGICEJDE, FaceFeature APALAMANPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F380", Offset = "0x6B8DF80", VA = "0x186B8F380")]
	public NBGAHJGPDCB(SymmetricalFaceFeature EKMDHPKGHHJ, EyesFaceFeature OAFAGICEJDE, FaceFeature APALAMANPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F150", Offset = "0x6B8DD50", VA = "0x186B8F150")]
	public bool PCKMEKPCCEL(Sprite POCNICPLMKL, out int NHHNPPKPBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6B8EFD0", Offset = "0x6B8DBD0", VA = "0x186B8EFD0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B90D10", Offset = "0x6B8F910", VA = "0x186B90D10")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xA580B0", Offset = "0xA56CB0", VA = "0x180A580B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x165C0E0", Offset = "0x165ACE0", VA = "0x18165C0E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA58080", Offset = "0xA56C80", VA = "0x180A58080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x14D62F0", Offset = "0x14D4EF0", VA = "0x1814D62F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x33F0E70", Offset = "0x33EFA70", VA = "0x1833F0E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x165C010", Offset = "0x165AC10", VA = "0x18165C010")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x6B90D30", Offset = "0x6B8F930", VA = "0x186B90D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6B90C00", Offset = "0x6B8F800", VA = "0x186B90C00", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C020", Offset = "0x6B8AC20", VA = "0x186B8C020")]
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
			[Cpp2IlInjected.Address(RVA = "0x9897A0", Offset = "0x9883A0", VA = "0x1809897A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xA500A0", Offset = "0xA4ECA0", VA = "0x180A500A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xA2B0A0", Offset = "0xA29CA0", VA = "0x180A2B0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x6B8D5D0", Offset = "0x6B8C1D0", VA = "0x186B8D5D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x461E6C0", Offset = "0x461D2C0", VA = "0x18461E6C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xA5B0C0", Offset = "0xA59CC0", VA = "0x180A5B0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D400", Offset = "0x6B8C000", VA = "0x186B8D400")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D470", Offset = "0x6B8C070", VA = "0x186B8D470", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6B8D4F0", Offset = "0x6B8C0F0", VA = "0x186B8D4F0")]
		protected FaceFeatureBase()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
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
