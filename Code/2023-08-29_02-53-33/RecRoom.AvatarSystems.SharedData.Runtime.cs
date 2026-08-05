using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
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
	public struct AvatarHairPatternOverride : ISerializationCallbackReceiver, IEquatable<AvatarHairPatternOverride>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[FormerlySerializedAs("PatternGuid")]
		private string patternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Texture2D Texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private HairPatternId hairPatternId;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string PatternGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7E80A0", Offset = "0x7E74A0", VA = "0x1807E80A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D57FB0", Offset = "0x6D573B0", VA = "0x186D57FB0")]
		public AvatarHairPatternOverride(string CAJGDKBBPHA, Texture2D ONDELHFOLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6D57E60", Offset = "0x6D57260", VA = "0x186D57E60", Slot = "6")]
		public bool Equals(AvatarHairPatternOverride LNOOAJJNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6D57ED0", Offset = "0x6D572D0", VA = "0x186D57ED0", Slot = "0")]
		public override bool Equals(object ICNDEPGFBMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2D12D70", Offset = "0x2D12170", VA = "0x182D12D70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ODJAPADIJPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool CNBAIHLKKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool GHFKGICGKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public bool CJOMAHHNDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public bool FHKFAKFDPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public bool EOKPNEHGCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public IList<DCLPLBLIGDP> IIAEINEAAGD;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public ODJAPADIJPC()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private FLDNCMILGHG DCLJDICAEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Collider[] JIELFBMJFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Collider[] JDOMANJMDPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6D5C500", Offset = "0x6D5B900", VA = "0x186D5C500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C480", Offset = "0x6D5B880", VA = "0x186D5C480")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C6B0", Offset = "0x6D5BAB0", VA = "0x186D5C6B0")]
		public void UpdateBones(FLDNCMILGHG CMFACOCNNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C570", Offset = "0x6D5B970", VA = "0x186D5C570")]
		public void SetCollidersEnabled(bool GDHKPCGLKJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C6E0", Offset = "0x6D5BAE0", VA = "0x186D5C6E0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MIOHKOCLMKE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C3F0", Offset = "0x6D5B7F0", VA = "0x186D5C3F0")]
	public static bool CCFMLFOAFKI(this OutfitType OOPLMBGIKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C450", Offset = "0x6D5B850", VA = "0x186D5C450")]
	public static bool PBFHGBKJKMC(this OutfitType OOPLMBGIKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C410", Offset = "0x6D5B810", VA = "0x186D5C410")]
	public static bool CFEGJJLIIMJ(this OutfitType OOPLMBGIKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C440", Offset = "0x6D5B840", VA = "0x186D5C440")]
	public static bool MKODNMOBMPG(this OutfitType OOPLMBGIKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C430", Offset = "0x6D5B830", VA = "0x186D5C430")]
	public static bool IHMCDDLCLGO(this OutfitType OOPLMBGIKAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C420", Offset = "0x6D5B820", VA = "0x186D5C420")]
	public static bool EFMDEOFKINN(this OutfitType OOPLMBGIKAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DANKLNPDPMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public FFICKPBCJJH LEFIAIGHGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public int HFHFBKJKAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public int BBJAGLOMOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Color GEGPJNIGLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Color ELMEEIOCPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int GNHCIDPBOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int EOENEGNJDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Color IJCDCKJMAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Color PHLJLGNJFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int KFECIDHPKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float OOBPNADELCO;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CDADMFGIFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public FFICKPBCJJH LEFIAIGHGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Vector2 EMIKDIFJCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float MGFKODNMGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Vector2 CGKKOLELHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float OGNNFBBDBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector2 ONCDMIMJPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float PEFBCCALFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float PINICIEKEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Vector2 OGIJKOMMNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector2 PHFDKEFAAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool ECCHGEDAMGI;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x992770", Offset = "0x991B70", VA = "0x180992770")]
		protected AvatarConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D58330", Offset = "0x6D57730", VA = "0x186D58330")]
		public string IGHCENKGDDH(string IOJHGLPPGLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D58380", Offset = "0x6D57780", VA = "0x186D58380")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum MMAODGLKKDD
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MADBAAANBHJ
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly MADBAAANBHJ DEEICBABDMJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NOLGPNIIFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7E8250", Offset = "0x7E7650", VA = "0x1807E8250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x902B60", Offset = "0x901F60", VA = "0x180902B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MMAODGLKKDD DMIDNGLDOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9CDAB0", Offset = "0x9CCEB0", VA = "0x1809CDAB0")]
		[CompilerGenerated]
		get
		{
			return default(MMAODGLKKDD);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB61F40", Offset = "0xB61340", VA = "0x180B61F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public MADBAAANBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C260", Offset = "0x6D5B660", VA = "0x186D5C260")]
	public MADBAAANBHJ(MMAODGLKKDD MMGKIPGKNHG, int BBBJDDLJKOC)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private CombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private CMMHAHDNPCK? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public CombinationId CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6D58240", Offset = "0x6D57640", VA = "0x186D58240")]
			get
			{
				return default(CombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public CMMHAHDNPCK MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6D58270", Offset = "0x6D57670", VA = "0x186D58270")]
			get
			{
				return default(CMMHAHDNPCK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x91F290", Offset = "0x91E690", VA = "0x18091F290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6D58050", Offset = "0x6D57450", VA = "0x186D58050")]
		public Material[] DPAEGPIIHCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D57FF0", Offset = "0x6D573F0", VA = "0x186D57FF0")]
		public static void BHNLCNNGPGH(AvatarItemMaterial ACFMDONAOJO, Material JMOIMJGFABM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6D58140", Offset = "0x6D57540", VA = "0x186D58140")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class FLDNCMILGHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private List<Transform> HGPEPCKFKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Matrix4x4[] JGDPOIPELJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Dictionary<string, Transform> AHMGLFMCBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Dictionary<Transform, Transform> JMJBPLJANCG;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Transform[] OAJPBAGNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6D59A70", Offset = "0x6D58E70", VA = "0x186D59A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6D59A00", Offset = "0x6D58E00", VA = "0x186D59A00")]
	public void BCDALPFMKJG(Transform HJMKLHOELOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6D59EB0", Offset = "0x6D592B0", VA = "0x186D59EB0")]
	private Transform LNCCFGOMBAG(Transform KPNBDPJALOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6D59AC0", Offset = "0x6D58EC0", VA = "0x186D59AC0")]
	public void FNNIMHHDJGI(FLDNCMILGHG GCMEKAMANFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6D59D40", Offset = "0x6D59140", VA = "0x186D59D40")]
	private void LFFAAMJJJPF(Transform COMCNEGAGFF, List<Transform> OMMMDDPFLCJ, Dictionary<string, Transform> HDKLEGCLHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6D59F90", Offset = "0x6D59390", VA = "0x186D59F90")]
	public FLDNCMILGHG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum KLGMPMMBMEI
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private const int SERIALIZATION_VERSION = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private string eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private KLGMPMMBMEI useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private string baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x26AFA20", Offset = "0x26AEE20", VA = "0x1826AFA20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x10EE000", Offset = "0x10ED400", VA = "0x1810EE000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCCDA40", Offset = "0xCCCE40", VA = "0x180CCDA40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCCDA30", Offset = "0xCCCE30", VA = "0x180CCDA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x38F9540", Offset = "0x38F8940", VA = "0x1838F9540")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x97D5D0", Offset = "0x97C9D0", VA = "0x18097D5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xB56C80", Offset = "0xB56080", VA = "0x180B56C80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB56C70", Offset = "0xB56070", VA = "0x180B56C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x94B820", Offset = "0x94AC20", VA = "0x18094B820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6D57D60", Offset = "0x6D57160", VA = "0x186D57D60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x97D430", Offset = "0x97C830", VA = "0x18097D430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCF9D30", Offset = "0xCF9130", VA = "0x180CF9D30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA580D0", Offset = "0xA574D0", VA = "0x180A580D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x94B840", Offset = "0x94AC40", VA = "0x18094B840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x94CE10", Offset = "0x94C210", VA = "0x18094CE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x94B180", Offset = "0x94A580", VA = "0x18094B180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x91F290", Offset = "0x91E690", VA = "0x18091F290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x98D750", Offset = "0x98CB50", VA = "0x18098D750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x94CE00", Offset = "0x94C200", VA = "0x18094CE00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x94C610", Offset = "0x94BA10", VA = "0x18094C610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8C3110", Offset = "0x8C2510", VA = "0x1808C3110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8C26F0", Offset = "0x8C1AF0", VA = "0x1808C26F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x94B230", Offset = "0x94A630", VA = "0x18094B230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x94BE40", Offset = "0x94B240", VA = "0x18094BE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA49860", Offset = "0xA48C60", VA = "0x180A49860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9EA9B0", Offset = "0x9E9DB0", VA = "0x1809EA9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9F6090", Offset = "0x9F5490", VA = "0x1809F6090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9F8780", Offset = "0x9F7B80", VA = "0x1809F8780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public KLGMPMMBMEI UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6D57D80", Offset = "0x6D57180", VA = "0x186D57D80")]
			get
			{
				return default(KLGMPMMBMEI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x561C130", Offset = "0x561B530", VA = "0x18561C130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1004230", Offset = "0x1003630", VA = "0x181004230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1002070", Offset = "0x1001470", VA = "0x181002070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6D57D40", Offset = "0x6D57140", VA = "0x186D57D40")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6D57E40", Offset = "0x6D57240", VA = "0x186D57E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x905C80", Offset = "0x905080", VA = "0x180905C80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA04BE0", Offset = "0xA03FE0", VA = "0x180A04BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6D57DA0", Offset = "0x6D571A0", VA = "0x186D57DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x30623F0", Offset = "0x30617F0", VA = "0x1830623F0")]
		public string IBKPGJDIIJI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D57910", Offset = "0x6D56D10", VA = "0x186D57910")]
		public static AvatarCustomizationSettings LFPLIBEJFBF(string NGGDDMBBPDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D57AB0", Offset = "0x6D56EB0", VA = "0x186D57AB0")]
		public AvatarCustomizationSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum DGJOCKFPPMG
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	CannedWave,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum KJMKDJCALGA
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum MCABODCAPIE
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum LBNEGNOPDCK
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum FOFMGBAOMFO
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KCFJLCFGMCN
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly int BEPAFPLANHO;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly string INCMFMCFEBE;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly string KKGFJMELCHM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BF50", Offset = "0x6D5B350", VA = "0x186D5BF50")]
	public static CPMPJNPJPIL FLIHNLMDLPM()
	{
		return default(CPMPJNPJPIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BDF0", Offset = "0x6D5B1F0", VA = "0x186D5BDF0")]
	public static IGDMHPCBAHD EPKMBLPOOEF(string BKGGNHJGBFG, bool NMLNOEPPKDO, bool IDKHINPPMDP, bool LDHJLHMAIKJ, RigidbodyEx ICDIEOCCPKD, RigidbodyEx NCHLNDGPHID, RigidbodyEx LPFOOBBFNGJ, RigidbodyEx PEGBOGAHDGF, Transform FCNGOFGJENL, Transform OCMPAIOHFNF, Transform JFBJKNOPEOG, float ELDFLLLILAD, float GACFLBHFJEH, PlayerAvatarFullBodyColliders OOBILPPDOMA)
	{
		return default(IGDMHPCBAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C020", Offset = "0x6D5B420", VA = "0x186D5C020")]
	public static DANKLNPDPMP LFENDLPGCHG(FFICKPBCJJH JIMLGENDNEJ, int DOJGBCFDEAA, int BDKBAIKLKML, Color IBAOCNACJPC, Color NIHIIHCEOGD, int KOCDCNBMBJG, int FGLPNHJLPJF, Color AGEJIKKKOFA, Color HBECPIFOOKG, int LGLAAFKMIEN, float AAENDOOILAG)
	{
		return default(DANKLNPDPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BCC0", Offset = "0x6D5B0C0", VA = "0x186D5BCC0")]
	public static CDADMFGIFFK CFKOINECBHJ(FFICKPBCJJH JIMLGENDNEJ, Vector2 CHCPFBHKGKC, float OLOAKFPCOOB, Vector2 HMGBGFCKAHG, float BIMMJFHINDA, Vector2 EGMELHAKBIB, float GBGPMMKOLJL, float NFHNLFODEFN, Vector2 ENFDLFNMBAI, Vector2 NIANECLLBAG)
	{
		return default(CDADMFGIFFK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BOEOGCOLJOO
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLPGPDLDMKF<Texture2D> DLJNONHBJDM(KEEJFONHJNN PDFAJKJDKEP, [Optional] MADBAAANBHJ ANKHOKAAJLH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IDBHGPLAMLB : BOEOGCOLJOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JOEAPODPDLH FMOKAFMHDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private IRecRoomQualityConfigProvider GEEKHPKICCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool LAKIECGAIPI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BB20", Offset = "0x6D5AF20", VA = "0x186D5BB20")]
	[GHLDKGGJCDP(FGNCLGKDFDK.GameOnly)]
	private static void LFBCBMIPACI(EPBOEGFMAOO OHJGEOICJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x30AF2A0", Offset = "0x30AE6A0", VA = "0x1830AF2A0")]
	[Preserve]
	public IDBHGPLAMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BC10", Offset = "0x6D5B010", VA = "0x186D5BC10")]
	private void MMMBEFEGKHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D5BAC0", Offset = "0x6D5AEC0", VA = "0x186D5BAC0", Slot = "6")]
	public void INBBFHAGKNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B6B0", Offset = "0x6D5AAB0", VA = "0x186D5B6B0", Slot = "4")]
	public DLPGPDLDMKF<Texture2D> DLJNONHBJDM(KEEJFONHJNN PDFAJKJDKEP, [Optional] MADBAAANBHJ ANKHOKAAJLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6D5B4F0", Offset = "0x6D5A8F0", VA = "0x186D5B4F0")]
	private uint DADGAJPPHPG(KEEJFONHJNN PDFAJKJDKEP, MADBAAANBHJ ANKHOKAAJLH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct IGDMHPCBAHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public string ILIMBBDPLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool FNEPPAPJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool OPPNNMHAJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float LIFODOJKPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float FIMDGECJDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool JHAPFBPJHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public RigidbodyEx HDKOOEMCCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public RigidbodyEx BJBBJBILINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public RigidbodyEx ECEHGLGJIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public RigidbodyEx BEBGDAIHGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Transform GPMBELNFFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform LGNPIJGEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform JKBJKKHCLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public PlayerAvatarFullBodyColliders KICONBAOJOG;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct CPMPJNPJPIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float AMFANLAHEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public bool BBHDEBBAHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public JCCBPCLKPNF OBAFHPCBFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Vector3 MBGHOCECECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector3 KGLGKLPNGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Vector3? EGNFCMFLGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector3? CGAMAMBEBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool DHMHJPLAJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool BJGDFFDNNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public bool NHELJKDFAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public bool PNCHOCJBKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public bool OJPANJMABNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public Vector3? MGMDLLHMAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public bool GMNPAHFAIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector3? COGPILDGGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public bool AAFAFMAONOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector3? MAIEHECGDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Vector3? KHLLEAIOPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool IKHIBCFLPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public bool LBFJKCELJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public bool PAJPHDKILBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public bool CEFFNGPLMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool LKOMPECNLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool BAGCMDAGJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool ODDGIHAMMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public bool JKDDKJENLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool BPADDLLEPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public bool GAGKIEMGHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public Vector3? LCOGKHDJGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public DGJOCKFPPMG DKOBAOOCHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public DGJOCKFPPMG NMDBMFLBLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public float JIOMGJGAFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public float DAPPLKOIODM;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6D5B4E0", Offset = "0x6D5A8E0", VA = "0x186D5B4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B420", Offset = "0x6D5A820", VA = "0x186D5B420")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AFF0", Offset = "0x6D5A3F0", VA = "0x186D5AFF0")]
		public void JLILLHOODFI(FitMeshHemisphere OODFDDLECJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6D5ABF0", Offset = "0x6D59FF0", VA = "0x186D5ABF0")]
		public Vector3 FIIHPIIPEJE(Vector2 KBHMGGAHBEC, bool NJHFMAHCOPI = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AF40", Offset = "0x6D5A340", VA = "0x186D5AF40")]
		public Vector3 GPDHDKIADEN(Vector2 KBHMGGAHBEC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B040", Offset = "0x6D5A440", VA = "0x186D5B040")]
		public Quaternion NMJLMJDGILB(Vector2 KBHMGGAHBEC)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6D5B180", Offset = "0x6D5A580", VA = "0x186D5B180")]
		public Quaternion NMJLMJDGILB(Vector2 KBHMGGAHBEC, Vector3 NKCMLLLFGAF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AFB0", Offset = "0x6D5A3B0", VA = "0x186D5AFB0")]
		private Vector2 IOJFDDBANNP(Vector2 NEOAOHPAKPE)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class DCLPLBLIGDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public string GHALHBJBCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public OutfitType FPMMFKFIHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public MCABODCAPIE EGIBOPPCDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool OPCPIJGEAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Color? HFENJPHMHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Vector3? EPGEDBFMJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float? DMODBHDHENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public Guid? NHOIGDKHNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Color? HMAAGALCCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public bool NLEGGJAPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private List<AvatarHairPatternOverride> BEOOOKKBOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Dictionary<string, Texture2D> JABCHNOMAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private List<AvatarHairPatternOverride> HEFICGOJLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, Texture2D> LJGAKPLHGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public AssetReference IIMBGEILBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public AssetReference HIIPLMAHAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public AssetReference[] GFOHGBMFMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public bool NDIKDGJHCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public bool APHNFCIODBB;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<AvatarHairPatternOverride> NJDJIGEPABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6D58610", Offset = "0x6D57A10", VA = "0x186D58610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public List<AvatarHairPatternOverride> GGPBIMFLLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6D583E0", Offset = "0x6D577E0", VA = "0x186D583E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6D58840", Offset = "0x6D57C40", VA = "0x186D58840")]
	public DCLPLBLIGDP()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct AnchorParams : IEquatable<AnchorParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Vector2 NormalizedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Vector3 HemisphereOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Vector3 HemisphereRotations;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static AnchorParams Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6D578A0", Offset = "0x6D56CA0", VA = "0x186D578A0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6D57870", Offset = "0x6D56C70", VA = "0x186D57870")]
		public AnchorParams(Vector2 MNBHPINNLEN, Vector3 JEEBGPJMEEB, Vector3 LPMPMMIFIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6D57700", Offset = "0x6D56B00", VA = "0x186D57700")]
		public AnchorParams(FEHIIFINHAJ HIHBPPDEJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6D57610", Offset = "0x6D56A10", VA = "0x186D57610", Slot = "4")]
		public bool Equals(AnchorParams LNOOAJJNCAE)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FEHIIFINHAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool EHJOIFEFGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool KHEMJDPBFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool AONEPIJKDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool JMEPPFFEPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool OODGCKOENHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool JBMCGCHPANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	float ALBHOFBMJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	float FIEGDNFJFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	float AFKPLONGMLP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	float AAFBDLFEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	float PEKPFGDLIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	float BIMKCIIMHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	float MIJHNONAJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	float JPPLOCEIINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	float ELPEDPDAABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	float EBDHLJJPMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	float IFBFJMDFOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	float OIAFAIIPLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	float FFOOFJMHJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	float GBMFPPLPFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	float PCMIHLCMJIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	float GJCFBCFPAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Vector3 BKKAOAEIGPI(Vector3 LPMPMMIFIDN);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3 OJGDJEABBLK(Vector3 PFOAHAOOKIO);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 JGOPJOAIIKL();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 FKIGKMMDFJP();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AnchorParamsRestrictions : FEHIIFINHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool GetAllowTranslationX
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x6D57580", Offset = "0x6D56980", VA = "0x186D57580", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x6D575B0", Offset = "0x6D569B0", VA = "0x186D575B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x6D575E0", Offset = "0x6D569E0", VA = "0x186D575E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x6D574F0", Offset = "0x6D568F0", VA = "0x186D574F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6D57520", Offset = "0x6D56920", VA = "0x186D57520", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6D57550", Offset = "0x6D56950", VA = "0x186D57550", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xE29690", Offset = "0xE28A90", VA = "0x180E29690", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1E24D20", Offset = "0x1E24120", VA = "0x181E24D20", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xE2CCB0", Offset = "0xE2C0B0", VA = "0x180E2CCB0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA71D50", Offset = "0xA71150", VA = "0x180A71D50", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1380EE0", Offset = "0x13802E0", VA = "0x181380EE0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8C69F0", Offset = "0x8C5DF0", VA = "0x1808C69F0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xA751D0", Offset = "0xA745D0", VA = "0x180A751D0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1A590E0", Offset = "0x1A584E0", VA = "0x181A590E0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xFC87A0", Offset = "0xFC7BA0", VA = "0x180FC87A0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x11C9BB0", Offset = "0x11C8FB0", VA = "0x1811C9BB0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA751C0", Offset = "0xA745C0", VA = "0x180A751C0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xDD9FC0", Offset = "0xDD93C0", VA = "0x180DD9FC0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4ADC2E0", Offset = "0x4ADB6E0", VA = "0x184ADC2E0", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xA58040", Offset = "0xA57440", VA = "0x180A58040", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x18D4A30", Offset = "0x18D3E30", VA = "0x1818D4A30", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4AEB6F0", Offset = "0x4AEAAF0", VA = "0x184AEB6F0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6299590", Offset = "0x6298990", VA = "0x186299590", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x165E030", Offset = "0x165D430", VA = "0x18165E030", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6D57460", Offset = "0x6D56860", VA = "0x186D57460")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6D57040", Offset = "0x6D56440", VA = "0x186D57040")]
		public AnchorParams BPKEIBEJOLL(AnchorParams MNCNDGOBIFA)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6D573A0", Offset = "0x6D567A0", VA = "0x186D573A0", Slot = "28")]
		public Vector3 JGOPJOAIIKL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6D57370", Offset = "0x6D56770", VA = "0x186D57370", Slot = "29")]
		public Vector3 FKIGKMMDFJP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6D56FC0", Offset = "0x6D563C0", VA = "0x186D56FC0", Slot = "26")]
		public Vector3 BKKAOAEIGPI(Vector3 LPMPMMIFIDN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6D573D0", Offset = "0x6D567D0", VA = "0x186D573D0", Slot = "27")]
		public Vector3 OJGDJEABBLK(Vector3 PFOAHAOOKIO)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9427E0", Offset = "0x941BE0", VA = "0x1809427E0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C470", Offset = "0x6D5B870", VA = "0x186D5C470")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private Dictionary<string, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6D5ABD0", Offset = "0x6D59FD0", VA = "0x186D5ABD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A490", Offset = "0x6D59890", VA = "0x186D5A490")]
		public FFICKPBCJJH EPPDAOBIIGA(int HFNAGMLONFP, int MIBIMAPFJJB, int GCMEFFFPLDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A690", Offset = "0x6D59A90", VA = "0x186D5A690")]
		public FaceFeatureBase HAECAFEMIDE(FaceFeatureType ALJGIHHODBL, string EBABBHGKMJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A400", Offset = "0x6D59800", VA = "0x186D5A400")]
		public int EGEDFBMFHNN(string EBABBHGKMJL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A9A0", Offset = "0x6D59DA0", VA = "0x186D5A9A0")]
		private void NAHHLOKHNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x19695B0", Offset = "0x19689B0", VA = "0x1819695B0")]
		private void IPPMKLMBLCN<T>(Dictionary<string, T> CEDFPOKBHBN, T[] AAPDBGLJIOI) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A8D0", Offset = "0x6D59CD0", VA = "0x186D5A8D0")]
		public string IJMBGDHEDAP(FaceFeatureType ALJGIHHODBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A7B0", Offset = "0x6D59BB0", VA = "0x186D5A7B0")]
		public string HBLFJIGDLOH(FaceFeatureType ALJGIHHODBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6D5AB50", Offset = "0x6D59F50", VA = "0x186D5AB50")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7F35A0", Offset = "0x7F29A0", VA = "0x1807F35A0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x2EEDB20", Offset = "0x2EECF20", VA = "0x182EEDB20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x2EEDB60", Offset = "0x2EECF60", VA = "0x182EEDB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x6D58B90", Offset = "0x6D57F90", VA = "0x186D58B90")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x3ABF420", Offset = "0x3ABE820", VA = "0x183ABF420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6D58BB0", Offset = "0x6D57FB0", VA = "0x186D58BB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6D58BF0", Offset = "0x6D57FF0", VA = "0x186D58BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6D58BD0", Offset = "0x6D57FD0", VA = "0x186D58BD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x3AC3010", Offset = "0x3AC2410", VA = "0x183AC3010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6D58850", Offset = "0x6D57C50", VA = "0x186D58850", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6D58AF0", Offset = "0x6D57EF0", VA = "0x186D58AF0")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x9D3070", Offset = "0x9D2470", VA = "0x1809D3070", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6D583D0", Offset = "0x6D577D0", VA = "0x186D583D0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x9EA990", Offset = "0x9E9D90", VA = "0x1809EA990", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C470", Offset = "0x6D5B870", VA = "0x186D5C470")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x2EEC550", Offset = "0x2EEB950", VA = "0x182EEC550")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x97D5C0", Offset = "0x97C9C0", VA = "0x18097D5C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x2195130", Offset = "0x2194530", VA = "0x182195130")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x97CE50", Offset = "0x97C250", VA = "0x18097CE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A280", Offset = "0x6D59680", VA = "0x186D5A280", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A320", Offset = "0x6D59720", VA = "0x186D5A320")]
		protected FaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FFICKPBCJJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private struct MBFCLIEGHBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly string PHHIECLJAFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly string FMEMJNDBOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly string LPGCOPDEDIH;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1072160", Offset = "0x1071560", VA = "0x181072160")]
		public MBFCLIEGHBP(string NMNOONOJFEE, string APOPPGLHCFO, string EMJJLLIAIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C2A0", Offset = "0x6D5B6A0", VA = "0x186D5C2A0")]
		public bool BLOEHGLCONB(MBFCLIEGHBP LNOOAJJNCAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C320", Offset = "0x6D5B720", VA = "0x186D5C320", Slot = "0")]
		public override bool Equals(object ICNDEPGFBMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x47EF320", Offset = "0x47EE720", VA = "0x1847EF320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly Dictionary<string, int> PMPLDCEMJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly MBFCLIEGHBP GMAEKOKGMHE;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Texture2DArray PLEAMEFIGMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public SymmetricalFaceFeature DJEDIBOMFOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public EyesFaceFeature HKBFIGDFAOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F3120", Offset = "0x7F2520", VA = "0x1807F3120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public FaceFeature BOEHPNPJOID
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6D58C10", Offset = "0x6D58010", VA = "0x186D58C10")]
	private static void LJFDBBKNBON(Sprite PLOHDOPBCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6D58E90", Offset = "0x6D58290", VA = "0x186D58E90")]
	public FFICKPBCJJH(SymmetricalFaceFeature KJBKNLOICPI, EyesFaceFeature MIBIMAPFJJB, FaceFeature GCMEFFFPLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6D58C80", Offset = "0x6D58080", VA = "0x186D58C80")]
	public bool MGAANDNNBIP(Sprite PLOHDOPBCDF, out int NANJAGEOPJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6D58C00", Offset = "0x6D58000", VA = "0x186D58C00", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCF9D60", Offset = "0xCF9160", VA = "0x180CF9D60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x561B9C0", Offset = "0x561ADC0", VA = "0x18561B9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCF9CA0", Offset = "0xCF90A0", VA = "0x180CF9CA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x2F00F70", Offset = "0x2F00370", VA = "0x182F00F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x561C090", Offset = "0x561B490", VA = "0x18561C090")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x561C0E0", Offset = "0x561B4E0", VA = "0x18561C0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x6D5CA10", Offset = "0x6D5BE10", VA = "0x186D5CA10")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x6D5CA30", Offset = "0x6D5BE30", VA = "0x186D5CA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C830", Offset = "0x6D5BC30", VA = "0x186D5C830", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6D5C940", Offset = "0x6D5BD40", VA = "0x186D5C940")]
		protected SymmetricalFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class FaceFeatureBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private FaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public FaceFeatureId FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x9CDA80", Offset = "0x9CCE80", VA = "0x1809CDA80")]
			get
			{
				return default(FaceFeatureId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x9CC2B0", Offset = "0x9CB6B0", VA = "0x1809CC2B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9A2C70", Offset = "0x9A2070", VA = "0x1809A2C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3CFAF70", Offset = "0x3CFA370", VA = "0x183CFAF70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6D57D60", Offset = "0x6D57160", VA = "0x186D57D60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x97D430", Offset = "0x97C830", VA = "0x18097D430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A090", Offset = "0x6D59490", VA = "0x186D5A090")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A100", Offset = "0x6D59500", VA = "0x186D5A100", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A180", Offset = "0x6D59580", VA = "0x186D5A180", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6D5A210", Offset = "0x6D59610", VA = "0x186D5A210")]
		protected FaceFeatureBase()
		{
		}
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
