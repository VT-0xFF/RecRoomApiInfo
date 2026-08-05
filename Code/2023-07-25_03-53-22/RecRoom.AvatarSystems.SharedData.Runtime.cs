using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public CDHDCBBOJLO lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct AvatarHairPatternOverride : ISerializationCallbackReceiver, IEquatable<AvatarHairPatternOverride>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[FormerlySerializedAs("PatternGuid")]
		private string patternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Texture2D Texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private HairPatternId hairPatternId;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string PatternGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HairPatternId HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA76DE0", Offset = "0xA75DE0", VA = "0x180A76DE0")]
			get
			{
				return default(HairPatternId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6C7CAF0", Offset = "0x6C7BAF0", VA = "0x186C7CAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CAB0", Offset = "0x6C7BAB0", VA = "0x186C7CAB0")]
		public AvatarHairPatternOverride(string CMKJEJCNJBB, Texture2D HCCFKEMJLAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C870", Offset = "0x6C7B870", VA = "0x186C7C870", Slot = "6")]
		public bool Equals(AvatarHairPatternOverride BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C8E0", Offset = "0x6C7B8E0", VA = "0x186C7C8E0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2441970", Offset = "0x2440970", VA = "0x182441970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CA40", Offset = "0x6C7BA40", VA = "0x186C7CA40")]
		public static bool LFCPNLBCIDE(AvatarHairPatternOverride EEDCFNGAAFO, AvatarHairPatternOverride OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C9C0", Offset = "0x6C7B9C0", VA = "0x186C7C9C0")]
		public static bool JIPCNIGMDBL(AvatarHairPatternOverride EEDCFNGAAFO, AvatarHairPatternOverride OFBPOJFNNIJ)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LBJAFIPGLBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Transform MPBLEHHDFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public GameObject MLBILMJOAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public SkinnedMeshRenderer[] OMIHODPJKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public SkinnedMeshRenderer[] BHHOPDLMNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GameObject PPHMLJHLGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public SkinnedMeshRenderer[] PKLPINHBGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public SkinnedMeshRenderer[] LKDHCEMLKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public AGPAJCEPOEA CNIIOCDKBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Material PKMIKMNDHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Material PEHIOGDHOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Shader OAEGKNFJFNF;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IACNGGIDPOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool LEDKPCIEALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool AKKHEEDIFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool BAOHCIBLHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool FPBELGBKIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool MLLOFNBLFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool EDACIGLOKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool OJAICFDBDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public IList<BFEEHPFKJCP> PBKGJGLOMAD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public IACNGGIDPOE()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private AGPAJCEPOEA KEMKLMOCAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Collider[] CAFIFIIKDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Collider[] JEHOPLJJCKI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C82520", Offset = "0x6C81520", VA = "0x186C82520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C824A0", Offset = "0x6C814A0", VA = "0x186C824A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C826D0", Offset = "0x6C816D0", VA = "0x186C826D0")]
		public void UpdateBones(AGPAJCEPOEA BGMAELJGJPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C82590", Offset = "0x6C81590", VA = "0x186C82590")]
		public void SetCollidersEnabled(bool DDHDBPLDGLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C82700", Offset = "0x6C81700", VA = "0x186C82700")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
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
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OGCNBMIOEIE
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C80690", Offset = "0x6C7F690", VA = "0x186C80690")]
	public static bool JNMMDPLACPN(this OutfitType PLBADGFEHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C806C0", Offset = "0x6C7F6C0", VA = "0x186C806C0")]
	public static bool PODHKAGOAKO(this OutfitType PLBADGFEHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C806B0", Offset = "0x6C7F6B0", VA = "0x186C806B0")]
	public static bool OMKIFMMIDMF(this OutfitType PLBADGFEHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C80680", Offset = "0x6C7F680", VA = "0x186C80680")]
	public static bool ILEMJCOECPG(this OutfitType PLBADGFEHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C80660", Offset = "0x6C7F660", VA = "0x186C80660")]
	public static bool GALNEFEAFAP(this OutfitType PLBADGFEHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C80670", Offset = "0x6C7F670", VA = "0x186C80670")]
	public static bool IAFAGBHDKCK(this OutfitType PLBADGFEHPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct DIHKOKECHMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Transform NAPLLHKDEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Transform IAFKJAEFLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Transform ALJPKMOAGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Transform MMDKMDAMAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Transform GAIKKAIJFFJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LPJDEELDPDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public SkinnedMeshRenderer[] JGDIENJACAL;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ELHIDOFOAFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public CMJAAGKAKLO CMDLPCGNLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int EAFIMDEBHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int OMPIBJABJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color KFMBNMDPGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color BGAFBOKKGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int JGCDIPAIABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int BPNPIHGEMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color CDOBLEBEJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Color IFIFEIBOEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int OADMOLLJGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float HBMHOCKMLDA;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EBJJDOPFKME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public CMJAAGKAKLO CMDLPCGNLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 GEKLDNKIFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float BCAANLIHNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 IJNDJCANNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float JDHEOGHPNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 FNFCPMEFGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float COINDLOFIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float PJFBBFPBIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 HGHNBDPBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 EAEMJHGHCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool KNAIACGHPMN;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA756E0", Offset = "0xA746E0", VA = "0x180A756E0")]
		protected AvatarConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CCB0", Offset = "0x6C7BCB0", VA = "0x186C7CCB0")]
		public string OLGNNDEDIKB(string NHKGAMJHDKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CD00", Offset = "0x6C7BD00", VA = "0x186C7CD00")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum ABOBGOJOLBN
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class OEBFBBPIOEA
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly OEBFBBPIOEA JCGFDJGGMMP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HHBGFONIKCP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x91AF80", Offset = "0x919F80", VA = "0x18091AF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ABOBGOJOLBN EBLPIEAFHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x91B190", Offset = "0x91A190", VA = "0x18091B190")]
		[CompilerGenerated]
		get
		{
			return default(ABOBGOJOLBN);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x91AF90", Offset = "0x919F90", VA = "0x18091AF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public OEBFBBPIOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C80620", Offset = "0x6C7F620", VA = "0x186C80620")]
	public OEBFBBPIOEA(ABOBGOJOLBN LPLFJNECDIF, int CMAIHHMIJBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class AGLKGDOJLBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Mesh FHCCKNBIIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Material[] PIHKPDIJHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool MOEGMNPEFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool FPIMLPHOLMC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	private AGLKGDOJLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B080", Offset = "0x6C7A080", VA = "0x186C7B080")]
	public AGLKGDOJLBL(Mesh CAFDMHFNNHI, Material[] ECJOPNFNJLF, bool KOEOEECIECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C7AF60", Offset = "0x6C79F60", VA = "0x186C7AF60")]
	public AGLKGDOJLBL(SkinnedMeshRenderer CIGELADKGKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C7ABF0", Offset = "0x6C79BF0", VA = "0x186C7ABF0")]
	public static AGLKGDOJLBL LPBJHKMMENC(Renderer ELPJNGIEOGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct FMAFALLNDEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly GameObject PHIKBHCMLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly AvatarItemMaterial IAKNMGGFGKF;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA891D0", Offset = "0xA881D0", VA = "0x180A891D0")]
	public FMAFALLNDEL(GameObject PHIKBHCMLCO, AvatarItemMaterial IAKNMGGFGKF)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private CombinationId combinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public CombinationId CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2FCE190", Offset = "0x2FCD190", VA = "0x182FCE190")]
			get
			{
				return default(CombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CC00", Offset = "0x6C7BC00", VA = "0x186C7CC00")]
		public static void PNGLIPKHLDF(AvatarItemMaterial BKKMLDBJLAL, Material HDEIKJNIFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CC60", Offset = "0x6C7BC60", VA = "0x186C7CC60")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface MNMGMFBKDAL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Transform CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 IMHGPPJMCPD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AIFAMLGGGEA : MNMGMFBKDAL
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 IMHGPPJMCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA81810", Offset = "0xA80810", VA = "0x180A81810", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA81830", Offset = "0xA80830", VA = "0x180A81830")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public float? DDEJCOFHDKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA81840", Offset = "0xA80840", VA = "0x180A81840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA81850", Offset = "0xA80850", VA = "0x180A81850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public AIFAMLGGGEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OLKFAOAHMED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	protected readonly AIFAMLGGGEA EGEMPFKKMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	protected readonly AIFAMLGGGEA LODHNIEGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly AIFAMLGGGEA ODPFBIHABPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly AIFAMLGGGEA OHNAJGOLKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly AIFAMLGGGEA APECGEJNMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly AIFAMLGGGEA HEAJLBMOABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly AIFAMLGGGEA PCBNCLDIPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly AIFAMLGGGEA BJAHFKHJCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly AIFAMLGGGEA AOJIJMKHDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly AIFAMLGGGEA KFANNJAKIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly AIFAMLGGGEA HDPAFEDLFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly AIFAMLGGGEA BEJGOJIPLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected readonly AIFAMLGGGEA MFOAEFAKGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	protected AIFAMLGGGEA GGOGECBMFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	protected readonly AIFAMLGGGEA GLLCNHEMDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected readonly AIFAMLGGGEA KEFFMDDLNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected readonly AIFAMLGGGEA JBPFCPDOCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected AIFAMLGGGEA OEGIGOKALFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	protected readonly AIFAMLGGGEA DJPFCBNHHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected readonly AIFAMLGGGEA MGKNGOIFLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	protected readonly AIFAMLGGGEA MJPKJODCMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	protected ReadOnlyCollection<AIFAMLGGGEA> AEHADMACAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Transform AOBLLFBLMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private (AIFAMLGGGEA Start, AIFAMLGGGEA End)[] DEEDKBPLOHK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MNMGMFBKDAL INAFAFCLPML
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public MNMGMFBKDAL NMBBKGLGDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MNMGMFBKDAL PCDDPOHKPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MNMGMFBKDAL FELKCKOKPGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public MNMGMFBKDAL DLIGPLLMHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MNMGMFBKDAL GIHCKKMJFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MNMGMFBKDAL GBMPDDPMEBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public AIFAMLGGGEA OAKJGHHLBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MNMGMFBKDAL BBMBCMLLAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public AIFAMLGGGEA OAPHHKHGKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MNMGMFBKDAL FEFPELMKICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x97E580", Offset = "0x97D580", VA = "0x18097E580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MNMGMFBKDAL GBGAEKOCKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x97E720", Offset = "0x97D720", VA = "0x18097E720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MNMGMFBKDAL LAAMFILEEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public AIFAMLGGGEA HEBFHFANNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public AIFAMLGGGEA CHBGCCHGABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MNMGMFBKDAL DCODFJDIGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MNMGMFBKDAL NLACNMEDLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9AD4B0", Offset = "0x9AC4B0", VA = "0x1809AD4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public MNMGMFBKDAL ACEFILBMICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AB9D0", Offset = "0x9AA9D0", VA = "0x1809AB9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public MNMGMFBKDAL PJGMCJJOPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B3910", Offset = "0x9B2910", VA = "0x1809B3910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public MNMGMFBKDAL OPCMMBHPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AD920", Offset = "0x9AC920", VA = "0x1809AD920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public MNMGMFBKDAL HMAAIKLLMLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAAC140", Offset = "0xAAB140", VA = "0x180AAC140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public MNMGMFBKDAL PGOLMFJLFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x90F2C0", Offset = "0x90E2C0", VA = "0x18090F2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public MNMGMFBKDAL HBBDALLMGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAA24A0", Offset = "0xAA14A0", VA = "0x180AA24A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public MNMGMFBKDAL DCNIOLEBKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA23950", Offset = "0xA22950", VA = "0x180A23950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public MNMGMFBKDAL PFHFEKHNMIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x97F530", Offset = "0x97E530", VA = "0x18097F530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IReadOnlyList<MNMGMFBKDAL> PMNLNGOBLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xBC7CF0", Offset = "0xBC6CF0", VA = "0x180BC7CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C80ED0", Offset = "0x6C7FED0", VA = "0x186C80ED0")]
	public void PHOMKFCCJPP(VRIK MLNDPPPDODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x149F490", Offset = "0x149E490", VA = "0x18149F490")]
	private void FFAHIKNGNOC(Transform LPNPMOOMCIB, AIFAMLGGGEA FBOMMBLFPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C808C0", Offset = "0x6C7F8C0", VA = "0x186C808C0")]
	public void GKJNGJONFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x14A1730", Offset = "0x14A0730", VA = "0x1814A1730")]
	public float MHFLADKHJCP(in (AIFAMLGGGEA Start, AIFAMLGGGEA End) LIBMGFJMPAC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C806E0", Offset = "0x6C7F6E0", VA = "0x186C806E0")]
	public void GCJIFHNGAGM(in NDFOKDAMMDK CILNOBBJOLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C80D70", Offset = "0x6C7FD70", VA = "0x186C80D70")]
	private Vector3 NOFLKDMMGNM(in (AIFAMLGGGEA Start, AIFAMLGGGEA End) LIBMGFJMPAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C818C0", Offset = "0x6C808C0", VA = "0x186C818C0")]
	public OLKFAOAHMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class AGPAJCEPOEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private List<Transform> ENDCLOOCEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private Matrix4x4[] DBKBGDHINLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private Dictionary<string, Transform> DCEACJGOPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private Dictionary<Transform, Transform> DDEAHFECLNA;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform[] BHNKAAJAJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B2E0", Offset = "0x6C7A2E0", VA = "0x186C7B2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Matrix4x4[] JLPAOPDPEJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85E990", Offset = "0x85D990", VA = "0x18085E990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B5B0", Offset = "0x6C7A5B0", VA = "0x186C7B5B0")]
	public void LGOAENFEOML(SkinnedMeshRenderer ELPJNGIEOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B270", Offset = "0x6C7A270", VA = "0x186C7B270")]
	public void DCEMCHKAPMI(Transform HCJMGELHINI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B190", Offset = "0x6C7A190", VA = "0x186C7B190")]
	private Transform AGKMMMAFOHN(Transform FKLMKMDIGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B330", Offset = "0x6C7A330", VA = "0x186C7B330")]
	public void GLNONBBJOOM(AGPAJCEPOEA KJEMFGENKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B760", Offset = "0x6C7A760", VA = "0x186C7B760")]
	private void OEOPENNNLJD(Transform EMIPEAKIENF, List<Transform> OAGPGHOCMHI, Dictionary<string, Transform> MPDGAKJHELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B8D0", Offset = "0x6C7A8D0", VA = "0x186C7B8D0")]
	public AGPAJCEPOEA()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum LBPKFJBMOII
		{
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private const int SERIALIZATION_VERSION = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private string eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private LBPKFJBMOII useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private string baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2BDF520", Offset = "0x2BDE520", VA = "0x182BDF520")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xA2BFC0", Offset = "0xA2AFC0", VA = "0x180A2BFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8650D0", Offset = "0x8640D0", VA = "0x1808650D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x864DA0", Offset = "0x863DA0", VA = "0x180864DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3B243E0", Offset = "0x3B233E0", VA = "0x183B243E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x15D2930", Offset = "0x15D1930", VA = "0x1815D2930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xC62FA0", Offset = "0xC61FA0", VA = "0x180C62FA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xC62DC0", Offset = "0xC61DC0", VA = "0x180C62DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x977C50", Offset = "0x976C50", VA = "0x180977C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C770", Offset = "0x6C7B770", VA = "0x186C7C770")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xDFA9A0", Offset = "0xDF99A0", VA = "0x180DFA9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x10B4E20", Offset = "0x10B3E20", VA = "0x1810B4E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x17C4180", Offset = "0x17C3180", VA = "0x1817C4180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9768A0", Offset = "0x9758A0", VA = "0x1809768A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x98DE00", Offset = "0x98CE00", VA = "0x18098DE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9AD4B0", Offset = "0x9AC4B0", VA = "0x1809AD4B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9F66A0", Offset = "0x9F56A0", VA = "0x1809F66A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x9AB9D0", Offset = "0x9AA9D0", VA = "0x1809AB9D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA23920", Offset = "0xA22920", VA = "0x180A23920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x9B3910", Offset = "0x9B2910", VA = "0x1809B3910")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x98E260", Offset = "0x98D260", VA = "0x18098E260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x9AD920", Offset = "0x9AC920", VA = "0x1809AD920")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA23960", Offset = "0xA22960", VA = "0x180A23960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC140", Offset = "0xAAB140", VA = "0x180AAC140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAAC130", Offset = "0xAAB130", VA = "0x180AAC130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x90F2C0", Offset = "0x90E2C0", VA = "0x18090F2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x90F0F0", Offset = "0x90E0F0", VA = "0x18090F0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xDCF5B0", Offset = "0xDCE5B0", VA = "0x180DCF5B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xDCF380", Offset = "0xDCE380", VA = "0x180DCF380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public LBPKFJBMOII UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C790", Offset = "0x6C7B790", VA = "0x186C7C790")]
			get
			{
				return default(LBPKFJBMOII);
			}
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x552AC80", Offset = "0x5529C80", VA = "0x18552AC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x992420", Offset = "0x991420", VA = "0x180992420")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x98DDF0", Offset = "0x98CDF0", VA = "0x18098DDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C750", Offset = "0x6C7B750", VA = "0x186C7C750")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C850", Offset = "0x6C7B850", VA = "0x186C7C850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x98D1F0", Offset = "0x98C1F0", VA = "0x18098D1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x98CF00", Offset = "0x98BF00", VA = "0x18098CF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C7B0", Offset = "0x6C7B7B0", VA = "0x186C7C7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x24E26B0", Offset = "0x24E16B0", VA = "0x1824E26B0")]
		public string IKBIGFALLCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C320", Offset = "0x6C7B320", VA = "0x186C7C320")]
		public static AvatarCustomizationSettings EILKNJCKJNI(string LGPPOEBMJLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C4C0", Offset = "0x6C7B4C0", VA = "0x186C7C4C0")]
		public AvatarCustomizationSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum MBKBLNEHAOA
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum CNCDAIHOHAO
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum NNBJANNCBED
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum CKEOKPEOOPE
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum KFPFJAFAJFP
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum KHLLJOEHIIO
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum OHJEAAAOPKF
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum FAMIDPDDOCO
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum ANCLDKADAPM
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OCHOJAFFBHL
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public static readonly int JCMJENHIDPB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public static readonly string GGHMCLIAPBD;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static readonly string MIOGJKEILBH;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FE50", Offset = "0x6C7EE50", VA = "0x186C7FE50")]
	public static NDFOKDAMMDK DNPOHOIAOIM()
	{
		return default(NDFOKDAMMDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FBA0", Offset = "0x6C7EBA0", VA = "0x186C7FBA0")]
	public static FGGCBHOLBJF APDAFNNNJFP(Transform PADEFKCDJKB, Transform BAPAOMKOBPG, AvatarConfiguration HMEPKFBBFMH, Animator EIJIMLIFALG, VRIK AGKGEHJDINP, SkeletonLODUpdateRate[] KMKIBOBIPNA, GameObject[] CJDFKHNLOHF, Transform AOBLLFBLMOB, GameObject IMIJNMPDBHB, BodySkinnedMeshLODs LDEDIPADAHP, BodySkinnedMeshLODs LPOOEOAKGJJ, GameObject CFIOBGHHAAC, BodySkinnedMeshLODs LOCODLMPFDO, BodySkinnedMeshLODs IEGDENEHBAM, AGPAJCEPOEA BGMAELJGJPN, Material FJCNJHDEODL, Material GLNNEKIMMOC, Shader LAIKFELDPKN, Transform LHFIMJAOJHK, Transform PDNEOOAOEEI, Transform FNDNELBLCFG, Transform DLDABCODOHE, Transform MCCCJKMEFKP)
	{
		return default(FGGCBHOLBJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C802D0", Offset = "0x6C7F2D0", VA = "0x186C802D0")]
	public static HOGAGLDIIEM LCJPBKOOFEN(string AJMKKOCGGIM, bool GINOFLMFANL, bool EIPLHAJIJAM, bool OGCIEEGGOOL, RigidbodyEx IGAOABFGGFB, RigidbodyEx CLNLIDCFCBM, RigidbodyEx LBFMNAAMCCE, RigidbodyEx LJGCGHJPNKE, Transform LCJHPKDEENG, Transform COGKAIANNFN, Transform FNOCMAEDGHA, float DFLPLNPFALP, float ICIJIELOOFJ, PlayerAvatarFullBodyColliders KBPFICBLHKM)
	{
		return default(HOGAGLDIIEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C80170", Offset = "0x6C7F170", VA = "0x186C80170")]
	public static LBJAFIPGLBN JEPLEIHHECF(Transform BAPAOMKOBPG, GameObject IMIJNMPDBHB, SkinnedMeshRenderer[] NCPLJHKHPLO, SkinnedMeshRenderer[] DCLOLICKHED, GameObject CFIOBGHHAAC, SkinnedMeshRenderer[] ODECFCGLIJI, SkinnedMeshRenderer[] AKEPEBMHFOD, AGPAJCEPOEA BGMAELJGJPN, Material FJCNJHDEODL, Material GLNNEKIMMOC, Shader LAIKFELDPKN)
	{
		return default(LBJAFIPGLBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C80430", Offset = "0x6C7F430", VA = "0x186C80430")]
	public static DIHKOKECHMA LGMPHGHMLIB(Transform LHFIMJAOJHK, Transform FNDNELBLCFG, Transform PDNEOOAOEEI, Transform DLDABCODOHE, Transform MCCCJKMEFKP)
	{
		return default(DIHKOKECHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xADB180", Offset = "0xADA180", VA = "0x180ADB180")]
	public static LPJDEELDPDP EMGMOJKLBFP(SkinnedMeshRenderer[] GLDGNGIPOIF)
	{
		return default(LPJDEELDPDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C80050", Offset = "0x6C7F050", VA = "0x186C80050")]
	public static ELHIDOFOAFK GADOJHIEFKN(CMJAAGKAKLO KEPPGIFOCJG, int LFCLDEHLBBI, int DKFLGIGDJPK, Color BNIOINNODCP, Color LGHIAKLIEBN, int MNIFLBHGEFE, int LNLHBEKEEEE, Color AAMMMHLHEEJ, Color NKDHJPODNBE, int LFEHMDHKEEH, float KBEAIJEGOOH)
	{
		return default(ELHIDOFOAFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C7FF20", Offset = "0x6C7EF20", VA = "0x186C7FF20")]
	public static EBJJDOPFKME FPIBAHJCOLE(CMJAAGKAKLO KEPPGIFOCJG, Vector2 CGIOPLJACEJ, float IKBCAABILHF, Vector2 NFDOHPMECNN, float KINCNIOEPLJ, Vector2 FFHEDFNKDEB, float OCIDLNCPHCL, float CDHBEJKNBOI, Vector2 CPIMNGIADOC, Vector2 NMCMHIBNCGK)
	{
		return default(EBJJDOPFKME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface HPDJCHKIKGL
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HNNIMMDCLKO();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODMBHKBFLMB<Texture2D> KIDLAHGCLDC(PGEKEHHMDMG ELNOPFJIMGJ, [Optional] OEBFBBPIOEA BPFIFAEKGCN);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OPNALBKIFIP : HPDJCHKIKGL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private LBAPHNPKBLD ADDKNIADHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private IRecRoomQualityConfigProvider MEECGIHOMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool EELBPNLDCFK;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private const uint GABNHAGGBJJ = 16u;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C81D30", Offset = "0x6C80D30", VA = "0x186C81D30")]
	[FBCFLFBFGIL(LAFFCBAHJKM.GameOnly)]
	private static void GLLAGPFEGFH(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2F4EBC0", Offset = "0x2F4DBC0", VA = "0x182F4EBC0")]
	[Preserve]
	public OPNALBKIFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C81E80", Offset = "0x6C80E80", VA = "0x186C81E80")]
	private void IMDOKINEJHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6C81E20", Offset = "0x6C80E20", VA = "0x186C81E20", Slot = "4")]
	public void HNNIMMDCLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6C820F0", Offset = "0x6C810F0", VA = "0x186C820F0", Slot = "5")]
	public ODMBHKBFLMB<Texture2D> KIDLAHGCLDC(PGEKEHHMDMG ELNOPFJIMGJ, [Optional] OEBFBBPIOEA BPFIFAEKGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C81F30", Offset = "0x6C80F30", VA = "0x186C81F30")]
	private uint JJJBMHICPMP(PGEKEHHMDMG ELNOPFJIMGJ, OEBFBBPIOEA BPFIFAEKGCN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct HOGAGLDIIEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public string JMGEFMFIJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public bool EIGMBGIDPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public bool BJBGDDPEAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public float OLPFJIHJOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public float DKOMGDLOOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public bool NGIOIOPHGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public RigidbodyEx KIEKMNDGLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public RigidbodyEx MKCOOFGDOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public RigidbodyEx FBLBLGEACDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public RigidbodyEx GFOKAIKAKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform EJKNHBFJFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform PMBGOLBBINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform MOPDHOFHHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public PlayerAvatarFullBodyColliders GDNOGAAIOIB;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct FGGCBHOLBJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform OALABEBKNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Transform NPGCALKLBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public AvatarConfiguration IDMEIFMPHAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Animator GGNCOFKFJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public VRIK MDLMBJDDBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public SkeletonLODUpdateRate[] JNIPHKAAJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public GameObject[] NCPDHMHJPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform PFLDOMLECLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public GameObject MLBILMJOAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public BodySkinnedMeshLODs KJPNFEOKLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public BodySkinnedMeshLODs JOAGHAOOMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public GameObject PPHMLJHLGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public BodySkinnedMeshLODs BBFJJAMCJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public BodySkinnedMeshLODs CJGMHMGNAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public AGPAJCEPOEA CNIIOCDKBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Material PKMIKMNDHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Material PEHIOGDHOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Shader OAEGKNFJFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform NAPLLHKDEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Transform ALJPKMOAGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform IAFKJAEFLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform MMDKMDAMAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Transform GAIKKAIJFFJ;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct NDFOKDAMMDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float GBEDNHIKMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public bool KHMKPPPLHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public CDHDCBBOJLO JEAHDMIJJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 JLFPHILENHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public Vector3 PGOFGLHJGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Vector3? MGAMJEOLCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Vector3? DNMNKFABBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool IANGKLBBBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public bool ADKICDABLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public bool INKBMCMGBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public bool GLEMEGLABPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool CBKEDPPLKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public Vector3? OFGNNAAHPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool LEIBHKFNIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3? BDJBBMGFKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public bool AOAHLCNHMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3? DLLKKABEIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3? JIIOIFNBGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool POLOPIAJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool MDHLLECACAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool BEAPDEHHPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool ICMEOMBCDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool GPIMIDFAIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool BKGPFHAPBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool OHJEEDBEFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool HKDIKJLJAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool JGNPFKCECJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool IOCGMKIDLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3? GKBPPPCLINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public MBKBLNEHAOA FIIOKDGDPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public MBKBLNEHAOA MPKAONJNNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public float GLHAHEHHNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public float GBLLFDPEIEP;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6C7FB80", Offset = "0x6C7EB80", VA = "0x186C7FB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C7FAC0", Offset = "0x6C7EAC0", VA = "0x186C7FAC0")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F880", Offset = "0x6C7E880", VA = "0x186C7F880")]
		public void NPLGFAFCLIO(FitMeshHemisphere KACGPCCPGOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F530", Offset = "0x6C7E530", VA = "0x186C7F530")]
		public Vector3 NCJBLMKNKPO(Vector2 KKDHHLLHLHL, bool OBLOLFBLOKC = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F8D0", Offset = "0x6C7E8D0", VA = "0x186C7F8D0")]
		public Vector3 PBKDCBJODEN(Vector2 KKDHHLLHLHL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F3F0", Offset = "0x6C7E3F0", VA = "0x186C7F3F0")]
		public Quaternion JLMOOKJAMOA(Vector2 KKDHHLLHLHL)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F2D0", Offset = "0x6C7E2D0", VA = "0x186C7F2D0")]
		public Quaternion JLMOOKJAMOA(Vector2 KKDHHLLHLHL, Vector3 BEAMDCEKACG)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F290", Offset = "0x6C7E290", VA = "0x186C7F290")]
		private Vector2 CHENHLCOGGF(Vector2 HOCMBLHNHIJ)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BFEEHPFKJCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public string CJABCEFOIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public OutfitType EMFHKMIOPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public NNBJANNCBED OILOMGDNAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool OAOFNDELKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public Color? GHJAOEPLNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public Vector3? KKKPAPDBHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public float? IKJBGJHHCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Guid? PBDCNBJMIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public CBPKPCMHDJG? FNFBAHHLJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public Color? BOKEANIMNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public bool GHIPPCPKLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public bool GHONMDOKPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public AnchorParamsRestrictions PFFODBKAFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public Vector2? AEAFFPIGCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public Transform BDCHOGGNDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public FitMeshHemisphere OFHGGFGCBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Vector2 LFLEMDJIACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private List<AvatarHairPatternOverride> OFGIFODPODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Dictionary<string, Texture2D> CNMPDCFNNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private List<AvatarHairPatternOverride> AMCCFJLKBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Dictionary<string, Texture2D> PLECKEEDAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public AssetReference EPBLJPAKDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public AssetReference LFKFHGNDGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public AssetReference[] PFDNCBPMHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public bool ELGILMLPJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public bool CBAIJJLBHJC;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public List<AvatarHairPatternOverride> BDAGPNMNPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9AD830", Offset = "0x9AC830", VA = "0x1809AD830")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CD50", Offset = "0x6C7BD50", VA = "0x186C7CD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public List<AvatarHairPatternOverride> HNKOPECLCJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x864CE0", Offset = "0x863CE0", VA = "0x180864CE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C7CF80", Offset = "0x6C7BF80", VA = "0x186C7CF80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public string DGBKDMMDCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D1B0", Offset = "0x6C7C1B0", VA = "0x186C7D1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D260", Offset = "0x6C7C260", VA = "0x186C7D260")]
	public BFEEHPFKJCP()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct AnchorParams : IEquatable<AnchorParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public Vector2 NormalizedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public Vector3 HemisphereOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public Vector3 HemisphereRotations;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static AnchorParams Default
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C2B0", Offset = "0x6C7B2B0", VA = "0x186C7C2B0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C110", Offset = "0x6C7B110", VA = "0x186C7C110")]
		public AnchorParams(Vector2 NFHANPEMJNL, Vector3 ENLNIEBPEJD, Vector3 AODAPENLPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C140", Offset = "0x6C7B140", VA = "0x186C7C140")]
		public AnchorParams(GAKLOKAGANO EFPBEHIMPDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C020", Offset = "0x6C7B020", VA = "0x186C7C020", Slot = "4")]
		public bool Equals(AnchorParams BKLMLPFOMCO)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface GAKLOKAGANO
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool PBEHFFEIDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool IFJAOPJOEGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KMIKOFCHBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool FBNMIAJBDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool EDOOGFEOOOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool ALICNNEFKOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool OOKAKBIGIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool HOKGPNPCJCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	float JHNFPJAMGCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	float MLOJBKDOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	float FHJJMFFHEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float IBMOLEIHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float KIGFJICINJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	float ONHNFNENIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float GDFBCOOKCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float ELCBNLBAGIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float IOAKCGLBCEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float ENJMIKNBHAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float GLKMNDJKONI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float IJIAOGEJCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float OIJLJHIAKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float IOPMGHMGEHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float LMOCLIHPFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float GFPJHLHFEKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 KCEDILJEDJK(Vector3 AODAPENLPMA);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 ONAKDKBCNNG(Vector3 MCFNEEIAFPF);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 AFLEDNDJDDI();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 NAGPGIFIEAK();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AnchorParamsRestrictions : GAKLOKAGANO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool GetAllowTranslationX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BF90", Offset = "0x6C7AF90", VA = "0x186C7BF90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BFC0", Offset = "0x6C7AFC0", VA = "0x186C7BFC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BFF0", Offset = "0x6C7AFF0", VA = "0x186C7BFF0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BF00", Offset = "0x6C7AF00", VA = "0x186C7BF00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BF30", Offset = "0x6C7AF30", VA = "0x186C7BF30", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6C7BF60", Offset = "0x6C7AF60", VA = "0x186C7BF60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x85E9A0", Offset = "0x85D9A0", VA = "0x18085E9A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x347F2C0", Offset = "0x347E2C0", VA = "0x18347F2C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x862130", Offset = "0x861130", VA = "0x180862130", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xBBF6E0", Offset = "0xBBE6E0", VA = "0x180BBF6E0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xF118A0", Offset = "0xF108A0", VA = "0x180F118A0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xBC2B70", Offset = "0xBC1B70", VA = "0x180BC2B70", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xBC2B60", Offset = "0xBC1B60", VA = "0x180BC2B60", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1BB2170", Offset = "0x1BB1170", VA = "0x181BB2170", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1BE5200", Offset = "0x1BE4200", VA = "0x181BE5200", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x122D000", Offset = "0x122C000", VA = "0x18122D000", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xBC2B50", Offset = "0xBC1B50", VA = "0x180BC2B50", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xF0BD90", Offset = "0xF0AD90", VA = "0x180F0BD90", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x3E94D50", Offset = "0x3E93D50", VA = "0x183E94D50", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x101CE40", Offset = "0x101BE40", VA = "0x18101CE40", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1D37510", Offset = "0x1D36510", VA = "0x181D37510", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5F2FF20", Offset = "0x5F2EF20", VA = "0x185F2FF20", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x62A2240", Offset = "0x62A1240", VA = "0x1862A2240", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x1005670", Offset = "0x1004670", VA = "0x181005670", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BE70", Offset = "0x6C7AE70", VA = "0x186C7BE70")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BA00", Offset = "0x6C7AA00", VA = "0x186C7BA00")]
		public AnchorParams FCMJKMFMPCN(AnchorParams OEFNDEDAEAM)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C7B9D0", Offset = "0x6C7A9D0", VA = "0x186C7B9D0", Slot = "30")]
		public Vector3 AFLEDNDJDDI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BDB0", Offset = "0x6C7ADB0", VA = "0x186C7BDB0", Slot = "31")]
		public Vector3 NAGPGIFIEAK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BD30", Offset = "0x6C7AD30", VA = "0x186C7BD30", Slot = "28")]
		public Vector3 KCEDILJEDJK(Vector3 AODAPENLPMA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C7BDE0", Offset = "0x6C7ADE0", VA = "0x186C7BDE0", Slot = "29")]
		public Vector3 ONAKDKBCNNG(Vector3 MCFNEEIAFPF)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86EB10", VA = "0x18086FB10", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C7FB90", Offset = "0x6C7EB90", VA = "0x186C7FB90")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private Dictionary<string, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6C7F270", Offset = "0x6C7E270", VA = "0x186C7F270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C7EAA0", Offset = "0x6C7DAA0", VA = "0x186C7EAA0")]
		public CMJAAGKAKLO EJOKIDBHGOL(int LELBELIBIAN, int DGAKHJIDGKL, int CDAEIFKMLDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F040", Offset = "0x6C7E040", VA = "0x186C7F040")]
		public FaceFeatureBase LJHJNBMJAIO(FaceFeatureType IIODIEEODJE, string PLBICILNGEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F160", Offset = "0x6C7E160", VA = "0x186C7F160")]
		public int MOELLBMNKKA(string PLBICILNGEB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6C7ECA0", Offset = "0x6C7DCA0", VA = "0x186C7ECA0")]
		private void GEPCMBGHBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1B74950", Offset = "0x1B73950", VA = "0x181B74950")]
		private void MJMNBIFCMKN<T>(Dictionary<string, T> NAHIDMOBGIL, T[] GAPODPBDJJO) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C7EE50", Offset = "0x6C7DE50", VA = "0x186C7EE50")]
		public string IHHGMJGLOEK(FaceFeatureType IIODIEEODJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C7EF20", Offset = "0x6C7DF20", VA = "0x186C7EF20")]
		public string JIJJJJOCEPB(FaceFeatureType IIODIEEODJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6C7F1F0", Offset = "0x6C7E1F0", VA = "0x186C7F1F0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x3126C80", Offset = "0x3125C80", VA = "0x183126C80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x3126CC0", Offset = "0x3125CC0", VA = "0x183126CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6C7E6C0", Offset = "0x6C7D6C0", VA = "0x186C7E6C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3CFF8D0", Offset = "0x3CFE8D0", VA = "0x183CFF8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6C7E6E0", Offset = "0x6C7D6E0", VA = "0x186C7E6E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6C7E720", Offset = "0x6C7D720", VA = "0x186C7E720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6C7E700", Offset = "0x6C7D700", VA = "0x186C7E700")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x3B86D80", Offset = "0x3B85D80", VA = "0x183B86D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E380", Offset = "0x6C7D380", VA = "0x186C7E380", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E620", Offset = "0x6C7D620", VA = "0x186C7E620")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x974040", Offset = "0x973040", VA = "0x180974040", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C7D270", Offset = "0x6C7C270", VA = "0x186C7D270")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x90AF50", Offset = "0x909F50", VA = "0x18090AF50", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C7FB90", Offset = "0x6C7EB90", VA = "0x186C7FB90")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x31256B0", Offset = "0x31246B0", VA = "0x1831256B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x1D42AC0", Offset = "0x1D41AC0", VA = "0x181D42AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x238C410", Offset = "0x238B410", VA = "0x18238C410")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x1D42AB0", Offset = "0x1D41AB0", VA = "0x181D42AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E920", Offset = "0x6C7D920", VA = "0x186C7E920", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E9C0", Offset = "0x6C7D9C0", VA = "0x186C7E9C0")]
		protected FaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class CMJAAGKAKLO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class OMOOBIDLEGE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public readonly Texture2DArray HEGDIIFFNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public readonly Dictionary<string, int> EBIBBFEPCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly FPCHIOCGOJB JFAEDEHPALB;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool IGPIMPKGHJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x20D8EE0", Offset = "0x20D7EE0", VA = "0x1820D8EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6C81C60", Offset = "0x6C80C60", VA = "0x186C81C60")]
		public OMOOBIDLEGE(Texture2DArray MOFEEAPHLNN, Dictionary<string, int> OHIAAFENCEP, CMJAAGKAKLO OEDCPCNHPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA41A60", Offset = "0xA40A60", VA = "0x180A41A60")]
		public void GPACLPKBJKP(CMJAAGKAKLO FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xA42B00", Offset = "0xA41B00", VA = "0x180A42B00")]
		public void PHIABMCCPAA(CMJAAGKAKLO FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x101E6D0", Offset = "0x101D6D0", VA = "0x18101E6D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct EFBMMOIONAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly string OGKGGIILGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly string ACFEBHFFCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private readonly string MOKGLKEPNEE;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x916640", Offset = "0x915640", VA = "0x180916640")]
		public EFBMMOIONAF(string EOGNMCBMKPJ, string JONHLLOJOHN, string BGDFDCMEIIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E300", Offset = "0x6C7D300", VA = "0x186C7E300")]
		public bool LPGOAMJEJHA(EFBMMOIONAF BKLMLPFOMCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E1A0", Offset = "0x6C7D1A0", VA = "0x186C7E1A0", Slot = "0")]
		public override bool Equals(object EOHGDDIECBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5A488A0", Offset = "0x5A478A0", VA = "0x185A488A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E300", Offset = "0x6C7D300", VA = "0x186C7E300")]
		public static bool LFCPNLBCIDE(EFBMMOIONAF EEDCFNGAAFO, EFBMMOIONAF OFBPOJFNNIJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E270", Offset = "0x6C7D270", VA = "0x186C7E270")]
		public static bool JIPCNIGMDBL(EFBMMOIONAF EEDCFNGAAFO, EFBMMOIONAF OFBPOJFNNIJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly Dictionary<string, int> OHIAAFENCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly EFBMMOIONAF DLDJJNNMJDN;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Texture2DArray AKCGOPHLFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public SymmetricalFaceFeature JCLFAFJKLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public EyesFaceFeature HKJLHKFEMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9132B0", Offset = "0x9122B0", VA = "0x1809132B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FaceFeature AIHGLFEMHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D300", Offset = "0x6C7C300", VA = "0x186C7D300")]
	private static void FIEONOHNOHI(Sprite AGNOINLEEOB, Sprite GINGFNDGMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D280", Offset = "0x6C7C280", VA = "0x186C7D280")]
	private static void CEDCDGNMAAH(Sprite PMBILBGCDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6C7E180", Offset = "0x6C7D180", VA = "0x186C7E180")]
	public CMJAAGKAKLO(EyesFaceFeature DGAKHJIDGKL, FaceFeature CDAEIFKMLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D610", Offset = "0x6C7C610", VA = "0x186C7D610")]
	public CMJAAGKAKLO(SymmetricalFaceFeature JHENPCJNEFE, EyesFaceFeature DGAKHJIDGKL, FaceFeature CDAEIFKMLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D400", Offset = "0x6C7C400", VA = "0x186C7D400")]
	public bool IKPKHKFKFKA(Sprite PMBILBGCDCB, out int CCELBNKPBGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C7D2F0", Offset = "0x6C7C2F0", VA = "0x186C7D2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x10B4E50", Offset = "0x10B3E50", VA = "0x1810B4E50")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x552A520", Offset = "0x5529520", VA = "0x18552A520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x10B4D90", Offset = "0x10B3D90", VA = "0x1810B4D90")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x352FF30", Offset = "0x352EF30", VA = "0x18352FF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x552ABF0", Offset = "0x5529BF0", VA = "0x18552ABF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x3FEED00", Offset = "0x3FEDD00", VA = "0x183FEED00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x6C82A30", Offset = "0x6C81A30", VA = "0x186C82A30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x3FEECF0", Offset = "0x3FEDCF0", VA = "0x183FEECF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6C82850", Offset = "0x6C81850", VA = "0x186C82850", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6C82960", Offset = "0x6C81960", VA = "0x186C82960")]
		protected SymmetricalFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class FaceFeatureBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private FaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public FaceFeatureId FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xA76DF0", Offset = "0xA75DF0", VA = "0x180A76DF0")]
			get
			{
				return default(FaceFeatureId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xA75610", Offset = "0xA74610", VA = "0x180A75610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xCF3910", Offset = "0xCF2910", VA = "0x180CF3910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3F9F590", Offset = "0x3F9E590", VA = "0x183F9F590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x6C7C770", Offset = "0x6C7B770", VA = "0x186C7C770")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xDFA9A0", Offset = "0xDF99A0", VA = "0x180DFA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E730", Offset = "0x6C7D730", VA = "0x186C7E730")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E7A0", Offset = "0x6C7D7A0", VA = "0x186C7E7A0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E820", Offset = "0x6C7D820", VA = "0x186C7E820", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6C7E8B0", Offset = "0x6C7D8B0", VA = "0x186C7E8B0")]
		protected FaceFeatureBase()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
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
