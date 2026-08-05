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
		[Obsolete]
		[Obsolete("Use HairPatternId instead!")]
		[FormerlySerializedAs("PatternGuid")]
		private string patternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Texture2D Texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MHPMGBKNHIJ HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6AC0", Offset = "0x6FE5EC0", VA = "0x186FE6AC0")]
			get
			{
				return default(MHPMGBKNHIJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6AF0", Offset = "0x6FE5EF0", VA = "0x186FE6AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6A70", Offset = "0x6FE5E70", VA = "0x186FE6A70")]
		public AvatarHairPatternOverride(MHPMGBKNHIJ HGEAEFMBIFB, Texture2D FFBJCPPFNGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6970", Offset = "0x6FE5D70", VA = "0x186FE6970", Slot = "6")]
		public bool Equals(AvatarHairPatternOverride ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FE69B0", Offset = "0x6FE5DB0", VA = "0x186FE69B0", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6A60", Offset = "0x6FE5E60", VA = "0x186FE6A60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class OMACOCJEEBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public bool BMMLDHPBCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public bool IKCBDKGBNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public bool CHMBEFFOMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public bool BJGPOBAHAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public bool ABLFLFLMFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public IList<FEENCAAJJIA> MEFKCDMNIOE;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public OMACOCJEEBI()
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
		private NEOJDJCDKPD EHAHNIAKICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Collider[] HDMMNENOELO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private Collider[] NNKOILODODD
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FEA1B0", Offset = "0x6FE95B0", VA = "0x186FEA1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA130", Offset = "0x6FE9530", VA = "0x186FEA130")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA360", Offset = "0x6FE9760", VA = "0x186FEA360")]
		public void UpdateBones(NEOJDJCDKPD EMBKMCHCBCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA220", Offset = "0x6FE9620", VA = "0x186FEA220")]
		public void SetCollidersEnabled(bool OMIGIJBCKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA390", Offset = "0x6FE9790", VA = "0x186FEA390")]
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
public static class PPJOLJDENMK
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA0D0", Offset = "0x6FE94D0", VA = "0x186FEA0D0")]
	public static bool HEDMIOGIMGK(this OutfitType ELHADLGIBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA0B0", Offset = "0x6FE94B0", VA = "0x186FEA0B0")]
	public static bool ALEPPODCEGM(this OutfitType ELHADLGIBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA0F0", Offset = "0x6FE94F0", VA = "0x186FEA0F0")]
	public static bool KCDGGILDICM(this OutfitType ELHADLGIBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA120", Offset = "0x6FE9520", VA = "0x186FEA120")]
	public static bool NJIFPIOENBI(this OutfitType ELHADLGIBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA100", Offset = "0x6FE9500", VA = "0x186FEA100")]
	public static bool LCCKBJJMKFA(this OutfitType ELHADLGIBHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FEA110", Offset = "0x6FE9510", VA = "0x186FEA110")]
	public static bool MONDLJCKJDP(this OutfitType ELHADLGIBHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct AAJEBBBAMPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public AJMMEHLOLDD MKANOJMOBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public int JMEFIANIPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public int GLBFBFMODHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Color BDJFEEKNKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public Color LNGMKLCHCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int AOFKECHLECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int KLCGGJIFEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Color MNJMHIABMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Color FECGAMMLLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public int MLNLJOBBJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float APJMJGIHMPK;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GKNBAGHHGLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public AJMMEHLOLDD MKANOJMOBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Vector2 HFEMECIAADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public float PDIHDOEJOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public Vector2 PDNFDKGIKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public float DLNDLHHJHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Vector2 CDKKDMDJBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float JICOBNFHPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float MEIBMKKONLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Vector2 HEOOGNNENHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Vector2 JMBKGNLDAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public bool GMGEPJCHGOM;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9840D0", Offset = "0x9834D0", VA = "0x1809840D0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6F90", Offset = "0x6FE6390", VA = "0x186FE6F90")]
		public string KFHNKBDCJJM(string NENCHCIEMLO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6FE0", Offset = "0x6FE63E0", VA = "0x186FE6FE0")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum PKIFJGEHJOL
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MBPJILJHFGG
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly MBPJILJHFGG KCIIGNIKLNC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EFMKJMCEOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9C1170", Offset = "0x9C0570", VA = "0x1809C1170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PKIFJGEHJOL PJLOKDELCHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x985830", Offset = "0x984C30", VA = "0x180985830")]
		[CompilerGenerated]
		get
		{
			return default(PKIFJGEHJOL);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9FC620", Offset = "0x9FBA20", VA = "0x1809FC620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MBPJILJHFGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9830", Offset = "0x6FE8C30", VA = "0x186FE9830")]
	public MBPJILJHFGG(PKIFJGEHJOL ADMMGKCBODC, int GCIGPOALOOJ)
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
		[Obsolete]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private PJOBPGBABLP? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public MFHLJNIJHGK CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6E80", Offset = "0x6FE6280", VA = "0x186FE6E80")]
			get
			{
				return default(MFHLJNIJHGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public PJOBPGBABLP MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6ED0", Offset = "0x6FE62D0", VA = "0x186FE6ED0")]
			get
			{
				return default(PJOBPGBABLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8F8D80", Offset = "0x8F8180", VA = "0x1808F8D80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6C90", Offset = "0x6FE6090", VA = "0x186FE6C90")]
		public Material[] OIPGBCJCGII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6C30", Offset = "0x6FE6030", VA = "0x186FE6C30")]
		public static void HMLKCGJPGCO(AvatarItemMaterial INCGAPGLFAH, Material NKAMKIHOODJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6D80", Offset = "0x6FE6180", VA = "0x186FE6D80")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MILGJALKCCA
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly HKEBIJNAEAM OCOEBHBKBNK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static IPALEFGGLBM JECFOEPAMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9870", Offset = "0x6FE8C70", VA = "0x186FE9870")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class NEOJDJCDKPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private List<Transform> POBPMMHGODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Matrix4x4[] OCJKGIABOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Dictionary<string, Transform> NJODBPKBNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private Dictionary<Transform, Transform> LDMBKBMBIMF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Transform[] LBNPCBFAAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9EF0", Offset = "0x6FE92F0", VA = "0x186FE9EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9F40", Offset = "0x6FE9340", VA = "0x186FE9F40")]
	public void KNEKKKBIANL(Transform IIGPCKAOCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9E10", Offset = "0x6FE9210", VA = "0x186FE9E10")]
	private Transform JGPCGPAJCKF(Transform BEGPAFLHBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9A20", Offset = "0x6FE8E20", VA = "0x186FE9A20")]
	public void DBIIACFODJK(NEOJDJCDKPD FNAKBODHCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9CA0", Offset = "0x6FE90A0", VA = "0x186FE9CA0")]
	private void DOMGEOBGCGC(Transform AOCBEEBNJPK, List<Transform> GBNCCHKANIH, Dictionary<string, Transform> MMENCHNCDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9FB0", Offset = "0x6FE93B0", VA = "0x186FE9FB0")]
	public NEOJDJCDKPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum PABGLBIEHDA
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	CannedWave,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum PHFPOMHIHLE
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum LINLIEGLBCE
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum EBCPKBDGLPH
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum GBBBLMEHKKF
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FAIDDNKFANE
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly int AEBINONGGEN;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly string GKKEGLBKLIM;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly string KEJPONFIECK;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7560", Offset = "0x6FE6960", VA = "0x186FE7560")]
	public static FMNBKMPCKMH FDCMKGEPNOJ()
	{
		return default(FMNBKMPCKMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7630", Offset = "0x6FE6A30", VA = "0x186FE7630")]
	public static CCMFOIMPBLM HOJOOGMOEFP(string HBCBHBBIDLI, bool ICADKMNOCLG, bool OAEGKBPNPDC, bool HGJJOHDMLBN, RigidbodyEx HMILDBDGMBN, RigidbodyEx APDFNKLMDKA, RigidbodyEx PKIGPFNKLJE, RigidbodyEx CALOILFCONM, Transform ODFPEIOKNLE, Transform CBINLOEEMMC, Transform PJKJPDDMIMI, float LFDBLEGKCPM, float ABMDKCEOINB, PlayerAvatarFullBodyColliders FCAHLELANHA)
	{
		return default(CCMFOIMPBLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7790", Offset = "0x6FE6B90", VA = "0x186FE7790")]
	public static AAJEBBBAMPD MICHKFIPBMK(AJMMEHLOLDD DAHGDEKLECK, int EEAHOIGCJOJ, int HIKGMGEPALF, Color JPPJKGDNFGN, Color BELGHJCDPNA, int CLBPPJOHHPD, int JKIANKGOFPE, Color OBDJGPMMDBH, Color BIJKNJJPIDL, int OGBEHBIIAPE, float AMIINNABDKK)
	{
		return default(AAJEBBBAMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7430", Offset = "0x6FE6830", VA = "0x186FE7430")]
	public static GKNBAGHHGLD EEGFGHBEAEI(AJMMEHLOLDD DAHGDEKLECK, Vector2 IFNAJNBHMPI, float OBBGMKHMCNA, Vector2 KONLDJEJLDO, float DFDKMMKJHKL, Vector2 GELHLCHGBNN, float LMJDCKFOGJM, float KMPCBDOAPDH, Vector2 DAGJJJMDGPC, Vector2 CIGFIDMBAEN)
	{
		return default(GKNBAGHHGLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DFIICBBOELG
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IBBDJDIFPNE<Texture2D> AKICBMODIHE(HNBBHIBDFGE AGNEPLGBOMM, [Optional] MBPJILJHFGG NPOLKGPPPJC);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JHOJFOPKNCC : DFIICBBOELG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private OKDGAOBFNEG EHNJPCODHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private IRecRoomQualityConfigProvider ICJEKDGMDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool KFOGNAIAFOE;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FE96C0", Offset = "0x6FE8AC0", VA = "0x186FE96C0")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.GameOnly)]
	private static void PDNKNMFOMOM(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x284FEB0", Offset = "0x284F2B0", VA = "0x18284FEB0")]
	[Preserve]
	public JHOJFOPKNCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6FE93F0", Offset = "0x6FE87F0", VA = "0x186FE93F0")]
	private void ALCPNMODLMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE94A0", Offset = "0x6FE88A0", VA = "0x186FE94A0", Slot = "6")]
	public void FOKGFBNDCEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9040", Offset = "0x6FE8440", VA = "0x186FE9040", Slot = "4")]
	public IBBDJDIFPNE<Texture2D> AKICBMODIHE(HNBBHIBDFGE AGNEPLGBOMM, [Optional] MBPJILJHFGG NPOLKGPPPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9500", Offset = "0x6FE8900", VA = "0x186FE9500")]
	private uint LNDMLHFKJHF(HNBBHIBDFGE AGNEPLGBOMM, MBPJILJHFGG NPOLKGPPPJC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class DDJGHMEJPEK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7060", Offset = "0x6FE6460", VA = "0x186FE7060")]
	public static LINLIEGLBCE CNAFMFJLGKM(this AGLCNMBLMLO ODBHDBFBMOB)
	{
		return default(LINLIEGLBCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7040", Offset = "0x6FE6440", VA = "0x186FE7040")]
	public static void CFLFKAMHIMA(this AGLCNMBLMLO ODBHDBFBMOB, LINLIEGLBCE AGLCIEKHLEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct CCMFOIMPBLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public string ALLJMHMJFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool DDLMANIJLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool LHKJFIPLIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float FBPKKFOMAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float FNJIKNHPCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool AJOBCIJOJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public RigidbodyEx GLMOKCDCNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public RigidbodyEx PBCKKCMKANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public RigidbodyEx NIJLEDLNODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public RigidbodyEx LGPCFLHLLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform CIHJGGLBBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform MFKIOGOIIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Transform FMDFDLAFGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public PlayerAvatarFullBodyColliders CBIAEFHIHNJ;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FMNBKMPCKMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public float EPMHGOGCHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool GLJAKIKGEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public FGLEPFCKOAH MKIHNNLIPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Vector3 KNKEPKEBNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Vector3 EDHBGKHPOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Vector3? FBLJOIEAOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3? KEAGONBJFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public bool OIJGFKOILAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool IGMLLGCOPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public bool JEBBBPAEHIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool DOLBDPPJDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public bool BNOBJHPLFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Vector3? ICIDJFMAGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public bool ONPMMEDCEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Vector3? OFKLNAFCNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool PCCIBNCPFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Vector3? GLCJKNPONNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Vector3? BGOMIGKHKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool IACLIEAMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public bool KBHJNLKCCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public bool OBBIOJMOBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public bool DPPAGDFOHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public bool HIIOOBGPCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public bool GGHMOGPDOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public bool LNFIHGFAKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public bool PCCPDCAEGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public bool PJOLOJPHGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public bool LBOGLKPMNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Vector3? BFOLFAIOHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public PABGLBIEHDA EAHOFPMHFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public PABGLBIEHDA EPMGANCLKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public float MDPLOPDAPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public float FKDHPGFKHEC;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6FE8DE0", Offset = "0x6FE81E0", VA = "0x186FE8DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8D20", Offset = "0x6FE8120", VA = "0x186FE8D20")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6FE88F0", Offset = "0x6FE7CF0", VA = "0x186FE88F0")]
		public void KEEFHEKLILM(FitMeshHemisphere GNCNMBBFOGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8560", Offset = "0x6FE7960", VA = "0x186FE8560")]
		public Vector3 GDCFHEMBIAO(Vector2 HNIJCGLDNFD, bool NNGHNFBIEIM = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6FE84F0", Offset = "0x6FE78F0", VA = "0x186FE84F0")]
		public Vector3 AALDHDIOOLE(Vector2 HNIJCGLDNFD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8940", Offset = "0x6FE7D40", VA = "0x186FE8940")]
		public Quaternion NHKEAKNFDFO(Vector2 HNIJCGLDNFD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8A80", Offset = "0x6FE7E80", VA = "0x186FE8A80")]
		public Quaternion NHKEAKNFDFO(Vector2 HNIJCGLDNFD, Vector3 GBMFCAEDBGI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6FE88B0", Offset = "0x6FE7CB0", VA = "0x186FE88B0")]
		private Vector2 HHMHNJHNLDI(Vector2 LLIKJIGPMMI)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FEENCAAJJIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public string ANHHJLAHIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public OutfitType LKEDKFGPDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public LINLIEGLBCE FHNJDOLGNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public bool JNBEPNOGJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Color? BEFJFHLHCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Vector3? LBHECCHKEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public float? HODOJBACHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Guid? MJPKDICFCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Color? GFDKAOBCKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public bool FEMBPIGPAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public AssetReference BEJNNIJBBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public AssetReference MMEAPJFCKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public AssetReference[] AKGBJFMHINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public bool OJAGAGOLCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public bool BPNJCPMDDDF;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7950", Offset = "0x6FE6D50", VA = "0x186FE7950")]
	public FEENCAAJJIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface PFFLKJBADGC
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool LBMKGPHMBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool KKGJHBMBADC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MAAHHEKAIEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool CFHOKHJMKKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool HGCMFJCEDBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool MJBKPCCPALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float FBJGANJHMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float FPCGIJJAOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float PKGGIPKEPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float AGJIGANAACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float BCEKNPBJJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float DNHNBKGAFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float MFECGMIPAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float LLFACJMAMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	float GEBPHFAOBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	float PFOLCPOAOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	float FGFFOIFBELN
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	float NAJJCOOKIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	float ANPGCGEHFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	float HOMMDDFIAHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	float LHAMPAMECCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	float DOLNNOAKHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Vector3 GFADBNFIBCE(Vector3 FMKJNECBPBG);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "23")]
	Vector3 GGDBEFLKCGL(Vector3 ELJACILJDDI);

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 ICMEGLFOJJL();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class AnchorParamsRestrictions : PFFLKJBADGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool GetAllowTranslationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6FE68E0", Offset = "0x6FE5CE0", VA = "0x186FE68E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6910", Offset = "0x6FE5D10", VA = "0x186FE6910", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6940", Offset = "0x6FE5D40", VA = "0x186FE6940", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6850", Offset = "0x6FE5C50", VA = "0x186FE6850", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6880", Offset = "0x6FE5C80", VA = "0x186FE6880", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6FE68B0", Offset = "0x6FE5CB0", VA = "0x186FE68B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB78270", Offset = "0xB77670", VA = "0x180B78270", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x3514FD0", Offset = "0x35143D0", VA = "0x183514FD0", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB7B930", Offset = "0xB7AD30", VA = "0x180B7B930", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA29CC0", Offset = "0xA290C0", VA = "0x180A29CC0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x110C0E0", Offset = "0x110B4E0", VA = "0x18110C0E0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA2D060", Offset = "0xA2C460", VA = "0x180A2D060", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA2D050", Offset = "0xA2C450", VA = "0x180A2D050", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x19F9B10", Offset = "0x19F8F10", VA = "0x1819F9B10", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1A7D260", Offset = "0x1A7C660", VA = "0x181A7D260", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1091A20", Offset = "0x1090E20", VA = "0x181091A20", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA2D030", Offset = "0xA2C430", VA = "0x180A2D030", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xDA5410", Offset = "0xDA4810", VA = "0x180DA5410", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x4D08150", Offset = "0x4D07550", VA = "0x184D08150", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xD40220", Offset = "0xD3F620", VA = "0x180D40220", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x13A6C60", Offset = "0x13A6060", VA = "0x1813A6C60", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4D17560", Offset = "0x4D16960", VA = "0x184D17560", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x574A460", Offset = "0x5749860", VA = "0x18574A460", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xEA5D30", Offset = "0xEA5130", VA = "0x180EA5D30", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE67C0", Offset = "0x6FE5BC0", VA = "0x186FE67C0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6370", Offset = "0x6FE5770", VA = "0x186FE6370")]
		public IPALEFGGLBM NCANDDLLODH(IPALEFGGLBM PJJGBPKLCJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6200", Offset = "0x6FE5600", VA = "0x186FE6200", Slot = "31")]
		public Vector3 BHMGNMPGLHL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6340", Offset = "0x6FE5740", VA = "0x186FE6340", Slot = "28")]
		public Vector3 ICMEGLFOJJL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6230", Offset = "0x6FE5630", VA = "0x186FE6230", Slot = "26")]
		public Vector3 GFADBNFIBCE(Vector3 FMKJNECBPBG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6FE62B0", Offset = "0x6FE56B0", VA = "0x186FE62B0", Slot = "27")]
		public Vector3 GGDBEFLKCGL(Vector3 ELJACILJDDI)
		{
			return default(Vector3);
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8C05F0", Offset = "0x8BF9F0", VA = "0x1808C05F0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9A10", Offset = "0x6FE8E10", VA = "0x186FE9A10")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private Dictionary<DNFDFLJPDAL, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private Dictionary<DNFDFLJPDAL, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private Dictionary<DNFDFLJPDAL, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly Dictionary<DNFDFLJPDAL, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6FE84D0", Offset = "0x6FE78D0", VA = "0x186FE84D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6FE80F0", Offset = "0x6FE74F0", VA = "0x186FE80F0")]
		public AJMMEHLOLDD IBJDKDMOLHK(int LELCBMDBPCF, int GIKGMHADPEJ, int LHLONHGAIKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6FE82F0", Offset = "0x6FE76F0", VA = "0x186FE82F0")]
		public FaceFeatureBase JIBIMKDHKBL(FaceFeatureType MJHDFHHIOKO, DNFDFLJPDAL NGMECNBNAOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7CD0", Offset = "0x6FE70D0", VA = "0x186FE7CD0")]
		public int FHNHPKIKBHA(DNFDFLJPDAL NGMECNBNAOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7D60", Offset = "0x6FE7160", VA = "0x186FE7D60")]
		private void FIPHBMNMKDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x16D14E0", Offset = "0x16D08E0", VA = "0x1816D14E0")]
		private void HHEJDLGDEPD<T>(IDictionary<DNFDFLJPDAL, T> IOKFOMHMAHF, IReadOnlyList<T> LOHPHEBOMPJ) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7F10", Offset = "0x6FE7310", VA = "0x186FE7F10")]
		public DNFDFLJPDAL GKDAPKDJBJN(FaceFeatureType MJHDFHHIOKO)
		{
			return default(DNFDFLJPDAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7FD0", Offset = "0x6FE73D0", VA = "0x186FE7FD0")]
		public DNFDFLJPDAL HALJAJJHGOI(FaceFeatureType MJHDFHHIOKO)
		{
			return default(DNFDFLJPDAL);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8450", Offset = "0x6FE7850", VA = "0x186FE8450")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x821EB0", Offset = "0x8212B0", VA = "0x180821EB0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x327FEC0", Offset = "0x327F2C0", VA = "0x18327FEC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x327FF00", Offset = "0x327F300", VA = "0x18327FF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6FE73C0", Offset = "0x6FE67C0", VA = "0x186FE73C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x3C3F560", Offset = "0x3C3E960", VA = "0x183C3F560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6FE73E0", Offset = "0x6FE67E0", VA = "0x186FE73E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6FE7420", Offset = "0x6FE6820", VA = "0x186FE7420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6FE7400", Offset = "0x6FE6800", VA = "0x186FE7400")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x3AAD2B0", Offset = "0x3AAC6B0", VA = "0x183AAD2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7080", Offset = "0x6FE6480", VA = "0x186FE7080", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7320", Offset = "0x6FE6720", VA = "0x186FE7320")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x98AE40", Offset = "0x98A240", VA = "0x18098AE40", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7030", Offset = "0x6FE6430", VA = "0x186FE7030")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x822D80", Offset = "0x822180", VA = "0x180822D80", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9A10", Offset = "0x6FE8E10", VA = "0x186FE9A10")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x327E8F0", Offset = "0x327DCF0", VA = "0x18327E8F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA7C430", Offset = "0xA7B830", VA = "0x180A7C430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x22E1FA0", Offset = "0x22E13A0", VA = "0x1822E1FA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA7C9F0", Offset = "0xA7BDF0", VA = "0x180A7C9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7B50", Offset = "0x6FE6F50", VA = "0x186FE7B50", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7BF0", Offset = "0x6FE6FF0", VA = "0x186FE7BF0")]
		protected FaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class AJMMEHLOLDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private struct HOAJGKEPMNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly DNFDFLJPDAL IMFIFINDGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly DNFDFLJPDAL PEFONHGPKIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly DNFDFLJPDAL KNHMCCCPKEF;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x292D4F0", Offset = "0x292C8F0", VA = "0x18292D4F0")]
		public HOAJGKEPMNC(DNFDFLJPDAL JLJLJAENJLG, DNFDFLJPDAL PEBMJNNABDB, DNFDFLJPDAL FDMPBBLKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8DF0", Offset = "0x6FE81F0", VA = "0x186FE8DF0")]
		public bool EKENCFDIDKH(HOAJGKEPMNC ICELKIGIKKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8F30", Offset = "0x6FE8330", VA = "0x186FE8F30", Slot = "0")]
		public override bool Equals(object HFAGBIOODHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8FE0", Offset = "0x6FE83E0", VA = "0x186FE8FE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Dictionary<string, int> IDOCDNGLFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly HOAJGKEPMNC MMDNLMDMMCO;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Texture2DArray PHPKDAHJHLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public SymmetricalFaceFeature GCEGFINCADF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public EyesFaceFeature DEOFCFJAFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD30", Offset = "0x8BB130", VA = "0x1808BBD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public FaceFeature HENKEFABONC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5440", Offset = "0x6FE4840", VA = "0x186FE5440")]
	private static void HKDNAHHKPJP(Sprite KBDOOBFPCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6FE56C0", Offset = "0x6FE4AC0", VA = "0x186FE56C0")]
	public AJMMEHLOLDD(SymmetricalFaceFeature EAKJIHMDBBL, EyesFaceFeature GIKGMHADPEJ, FaceFeature LHLONHGAIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6FE54B0", Offset = "0x6FE48B0", VA = "0x186FE54B0")]
	public bool PFOFHKHPKJD(Sprite KBDOOBFPCNA, out int BNOAGGNAMKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6FE5430", Offset = "0x6FE4830", VA = "0x186FE5430", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xC2F7A0", Offset = "0xC2EBA0", VA = "0x180C2F7A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x57B6C70", Offset = "0x57B6070", VA = "0x1857B6C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xC2F6E0", Offset = "0xC2EAE0", VA = "0x180C2F6E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x30AABC0", Offset = "0x30A9FC0", VA = "0x1830AABC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x57B7340", Offset = "0x57B6740", VA = "0x1857B7340")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x57B7390", Offset = "0x57B6790", VA = "0x1857B7390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6FEA6C0", Offset = "0x6FE9AC0", VA = "0x186FEA6C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6FEA6E0", Offset = "0x6FE9AE0", VA = "0x186FEA6E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA4E0", Offset = "0x6FE98E0", VA = "0x186FEA4E0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6FEA5F0", Offset = "0x6FE99F0", VA = "0x186FEA5F0")]
		protected SymmetricalFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class FaceFeatureBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[SerializeField]
		[Obsolete]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[Obsolete("Use FaceFeatureId instead!")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public DNFDFLJPDAL FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x1C6D7F0", Offset = "0x1C6CBF0", VA = "0x181C6D7F0")]
			get
			{
				return default(DNFDFLJPDAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x984000", Offset = "0x983400", VA = "0x180984000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA68280", Offset = "0xA67680", VA = "0x180A68280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3ED9480", Offset = "0x3ED8880", VA = "0x183ED9480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6DEF0D0", Offset = "0x6DEE4D0", VA = "0x186DEF0D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xA7C440", Offset = "0xA7B840", VA = "0x180A7C440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7960", Offset = "0x6FE6D60", VA = "0x186FE7960")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6FE79D0", Offset = "0x6FE6DD0", VA = "0x186FE79D0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7A50", Offset = "0x6FE6E50", VA = "0x186FE7A50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7AE0", Offset = "0x6FE6EE0", VA = "0x186FE7AE0")]
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
