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
		public BHPPPFLNDLP lod;

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
			[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HairPatternId HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9A65D0", Offset = "0x9A55D0", VA = "0x1809A65D0")]
			get
			{
				return default(HairPatternId);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6C584E0", Offset = "0x6C574E0", VA = "0x186C584E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6C584A0", Offset = "0x6C574A0", VA = "0x186C584A0")]
		public AvatarHairPatternOverride(string MEKMJJICOMM, Texture2D FFACFPCPDGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C58260", Offset = "0x6C57260", VA = "0x186C58260", Slot = "6")]
		public bool Equals(AvatarHairPatternOverride JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C582D0", Offset = "0x6C572D0", VA = "0x186C582D0", Slot = "0")]
		public override bool Equals(object DCGPCJKHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28FFD30", Offset = "0x28FED30", VA = "0x1828FFD30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C583B0", Offset = "0x6C573B0", VA = "0x186C583B0")]
		public static bool JFBEPFHBCDN(AvatarHairPatternOverride KOMAFEKIKMM, AvatarHairPatternOverride MKGHCBPGAGB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C58420", Offset = "0x6C57420", VA = "0x186C58420")]
		public static bool NLNNLODOBLO(AvatarHairPatternOverride KOMAFEKIKMM, AvatarHairPatternOverride MKGHCBPGAGB)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ODENLEDKDIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public Transform PKNFLODAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public GameObject JNDALOCJEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public SkinnedMeshRenderer[] HNIIHGDMJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public SkinnedMeshRenderer[] HGHCIFKACMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GameObject LABAMNMMLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public SkinnedMeshRenderer[] DHCLPAPFCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public SkinnedMeshRenderer[] ADDMJEOMMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NEHCDOHEOOM LOGLAELLMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public Material PGLONDCOIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Material MBDEGPKMMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Shader MOPPDHIJMKF;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CKOONKFFNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public bool MFKHJJKBCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public bool DPALLBGPMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public bool PKAJKBHHNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool BGCIGMOKLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool CEDMHBBEELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool BOKHKDOADNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public bool AEBAFNKODHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public IList<OMCPNEMGPHI> MBGEINLPJNA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public CKOONKFFNNM()
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
		private NEHCDOHEOOM EENDOHKCCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Collider[] ALIENJJJBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private Collider[] DPBKMBHHIHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6C5EF80", Offset = "0x6C5DF80", VA = "0x186C5EF80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C5EF00", Offset = "0x6C5DF00", VA = "0x186C5EF00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F130", Offset = "0x6C5E130", VA = "0x186C5F130")]
		public void UpdateBones(NEHCDOHEOOM JKHBHOODOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C5EFF0", Offset = "0x6C5DFF0", VA = "0x186C5EFF0")]
		public void SetCollidersEnabled(bool PINBJOHBLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F160", Offset = "0x6C5E160", VA = "0x186C5F160")]
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
public static class IGIODHNFIIL
{
	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BE10", Offset = "0x6C5AE10", VA = "0x186C5BE10")]
	public static bool IFIHIMLNFNH(this OutfitType COPGBBPANCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BDE0", Offset = "0x6C5ADE0", VA = "0x186C5BDE0")]
	public static bool DNOPPAFPNID(this OutfitType COPGBBPANCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BE00", Offset = "0x6C5AE00", VA = "0x186C5BE00")]
	public static bool IDFCNOHPAJH(this OutfitType COPGBBPANCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BDD0", Offset = "0x6C5ADD0", VA = "0x186C5BDD0")]
	public static bool CNLJFJCMLPA(this OutfitType COPGBBPANCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BE30", Offset = "0x6C5AE30", VA = "0x186C5BE30")]
	public static bool OEHDOAMAGOP(this OutfitType COPGBBPANCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BE40", Offset = "0x6C5AE40", VA = "0x186C5BE40")]
	public static bool OFFAMNMHAEB(this OutfitType COPGBBPANCL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct OHIIJJLFHKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public Transform FFLONAIDBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public Transform GIPECACFCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public Transform HMOJAJHBPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public Transform GJIENPHFECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public Transform LPGGICNBOBG;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DAPFELMKDJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public SkinnedMeshRenderer[] KEGBFCOMNFN;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct GFDNDDHFAGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public JKADKIBKOFL PBEHAMBJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public int FCLHJPDDAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public int IFEGNMMPJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public Color JMBLKDAFEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public Color POGOLDLJNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public int DDFCJAINDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public int BGNEKHJOLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public Color COJEDGMEMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public Color IAHOFFCGNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int AFKMMPKPECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public float CHHCAHJPMLB;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ABPPBPOLKAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public JKADKIBKOFL PBEHAMBJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public Vector2 MGNBMNPCNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public float BIBKNGBFELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public Vector2 GCIJKFFPLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float CAHKABFOHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public Vector2 EPADAAJOLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public float CCOJNAAMMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public float CBBNMLFICAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Vector2 LNOBCICCEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Vector2 PLHCDNCACCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool CEIEGCBGFPA;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A4ED0", Offset = "0x9A3ED0", VA = "0x1809A4ED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C58930", Offset = "0x6C57930", VA = "0x186C58930")]
		public string EFCNILOLBJD(string FAEGFDIJCOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C58980", Offset = "0x6C57980", VA = "0x186C58980")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum JCKIPDAMPNM
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FAFHCJKJJDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly FAFHCJKJJDJ FHJNMCMHCKN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HKCKPGMIJKB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA4D660", Offset = "0xA4C660", VA = "0x180A4D660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JCKIPDAMPNM FNLGKCODNKL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9A6670", Offset = "0x9A5670", VA = "0x1809A6670")]
		[CompilerGenerated]
		get
		{
			return default(JCKIPDAMPNM);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBC0", Offset = "0xA4CBC0", VA = "0x180A4DBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FAFHCJKJJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C593B0", Offset = "0x6C583B0", VA = "0x186C593B0")]
	public FAFHCJKJJDJ(JCKIPDAMPNM MJDCPFELDMF, int GBMMAEBHGPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BDINIDILEHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly Mesh EOOHCAKBOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Material[] AGJCGJLKAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly bool ENOKGJIFDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool OKJGDFIIHKF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	private BDINIDILEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C58E60", Offset = "0x6C57E60", VA = "0x186C58E60")]
	public BDINIDILEHB(Mesh DHAKOBAHEEC, Material[] GNDOLIENPAL, bool MPJCAPMGAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C58D40", Offset = "0x6C57D40", VA = "0x186C58D40")]
	public BDINIDILEHB(SkinnedMeshRenderer JCPEPEDGMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C589D0", Offset = "0x6C579D0", VA = "0x186C589D0")]
	public static BDINIDILEHB AKNAKCPKFEI(Renderer KEIBCBDBMJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BNIFLOJCONB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly GameObject DMLKOBGKLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly AvatarItemMaterial MIENHKAILID;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB2E3C0", Offset = "0xB2D3C0", VA = "0x180B2E3C0")]
	public BNIFLOJCONB(GameObject DMLKOBGKLJF, AvatarItemMaterial MIENHKAILID)
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
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private CombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private PGFEMCEKGHI? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public CombinationId CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6C58840", Offset = "0x6C57840", VA = "0x186C58840")]
			get
			{
				return default(CombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public PGFEMCEKGHI MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6C58870", Offset = "0x6C57870", VA = "0x186C58870")]
			get
			{
				return default(PGFEMCEKGHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x94AC50", Offset = "0x949C50", VA = "0x18094AC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x94AD40", Offset = "0x949D40", VA = "0x18094AD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C58650", Offset = "0x6C57650", VA = "0x186C58650")]
		public Material[] PPAMHBDMFEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C585F0", Offset = "0x6C575F0", VA = "0x186C585F0")]
		public static void BFMAOAFPDDG(AvatarItemMaterial LGBPFBLBDBE, Material AKEPBJIDOFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C58740", Offset = "0x6C57740", VA = "0x186C58740")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EJEGIDJENBH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Transform NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Vector3 AKHFEJMBOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NFOBDEIMPJF : EJEGIDJENBH
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Transform NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x92FA60", Offset = "0x92EA60", VA = "0x18092FA60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public Vector3 AKHFEJMBOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xB2E7F0", Offset = "0xB2D7F0", VA = "0x180B2E7F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xB2E810", Offset = "0xB2D810", VA = "0x180B2E810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public float? PCFHLFFKNDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xB2E820", Offset = "0xB2D820", VA = "0x180B2E820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xB2E7E0", Offset = "0xB2D7E0", VA = "0x180B2E7E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public NFOBDEIMPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GOCGECOEJIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	protected readonly NFOBDEIMPJF CFKPEHLJHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	protected readonly NFOBDEIMPJF PDHOJOMDBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	protected readonly NFOBDEIMPJF DBMMMECMNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	protected readonly NFOBDEIMPJF HKDBBAGEPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	protected readonly NFOBDEIMPJF IGDCMEHNOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	protected readonly NFOBDEIMPJF OEJFGNNJKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	protected readonly NFOBDEIMPJF INMGEGIDHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	protected readonly NFOBDEIMPJF IPMPBCBPJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	protected readonly NFOBDEIMPJF FJGKLBLBMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	protected readonly NFOBDEIMPJF DCDGFFNPIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	protected readonly NFOBDEIMPJF BDIOIOGMCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	protected readonly NFOBDEIMPJF ECHDEMMPOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	protected readonly NFOBDEIMPJF HBGNJNLBNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	protected NFOBDEIMPJF IHPAOKNEFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	protected readonly NFOBDEIMPJF NPEONKPNJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	protected readonly NFOBDEIMPJF HODOHHDGBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	protected readonly NFOBDEIMPJF FKCNDGIENJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	protected NFOBDEIMPJF IGJGAFHABCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	protected readonly NFOBDEIMPJF COGENEPFDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	protected readonly NFOBDEIMPJF MHDCAJEJGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	protected readonly NFOBDEIMPJF DNNLNCIKIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	protected ReadOnlyCollection<NFOBDEIMPJF> PMLADDGCKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Transform OPIEECEHIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private (NFOBDEIMPJF Start, NFOBDEIMPJF End)[] JDIAKPFEJHI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public EJEGIDJENBH PCHLKGBLIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D0", Offset = "0x8395D0", VA = "0x18083A5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EJEGIDJENBH KMMOLIDAIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public EJEGIDJENBH EMJAEJLEOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EJEGIDJENBH OELPJNOJGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EJEGIDJENBH OECEADFPBJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public EJEGIDJENBH LOFJFPFBFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x944E10", Offset = "0x943E10", VA = "0x180944E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EJEGIDJENBH DBHCDPGAMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public NFOBDEIMPJF KCNNCPKIBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x944E20", Offset = "0x943E20", VA = "0x180944E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EJEGIDJENBH BKJLEOHCMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NFOBDEIMPJF JGMFLBAAFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EJEGIDJENBH JIEEKEAODDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x947AC0", Offset = "0x946AC0", VA = "0x180947AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public EJEGIDJENBH GDHJFCCIILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x92FA50", Offset = "0x92EA50", VA = "0x18092FA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public EJEGIDJENBH NJABEBFINAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NFOBDEIMPJF IMGIHCPHKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NFOBDEIMPJF EILPFNMMHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x848B60", Offset = "0x847B60", VA = "0x180848B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public EJEGIDJENBH PMFPGFDBNBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x848B60", Offset = "0x847B60", VA = "0x180848B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EJEGIDJENBH NDAENPFFHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x94AC50", Offset = "0x949C50", VA = "0x18094AC50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public EJEGIDJENBH MGPACNIJIEL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x94AD40", Offset = "0x949D40", VA = "0x18094AD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EJEGIDJENBH KOGJFBECOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x94ABE0", Offset = "0x949BE0", VA = "0x18094ABE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EJEGIDJENBH FPIGLALCODI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA19A10", Offset = "0xA18A10", VA = "0x180A19A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public EJEGIDJENBH GBHHOANONMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA823E0", Offset = "0xA813E0", VA = "0x180A823E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public EJEGIDJENBH JDDKGJDEADI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x842FB0", Offset = "0x841FB0", VA = "0x180842FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public EJEGIDJENBH NAMFBKOMMKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xBEC0C0", Offset = "0xBEB0C0", VA = "0x180BEC0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EJEGIDJENBH PGHMPDEMLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x840E00", Offset = "0x83FE00", VA = "0x180840E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EJEGIDJENBH IGODIOJNHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x977040", Offset = "0x976040", VA = "0x180977040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IReadOnlyList<EJEGIDJENBH> CJEMKCOIAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA19A00", Offset = "0xA18A00", VA = "0x180A19A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AD00", Offset = "0x6C59D00", VA = "0x186C5AD00")]
	public void DBDHHHBJCIG(VRIK LAEGCJPPPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2743460", Offset = "0x2742460", VA = "0x182743460")]
	private void JKALPFBNAHG(Transform PCALNIOABDP, NFOBDEIMPJF EEMPMGBFHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A850", Offset = "0x6C59850", VA = "0x186C5A850")]
	public void BAFJCBHPNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2741510", Offset = "0x2740510", VA = "0x182741510")]
	public float DNEMFFFJPPC(in (NFOBDEIMPJF Start, NFOBDEIMPJF End) HLJMFLIBFIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B850", Offset = "0x6C5A850", VA = "0x186C5B850")]
	public void DIGAIONGCEH(in HDCGCLHCEMA EGNHEHPGBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B6F0", Offset = "0x6C5A6F0", VA = "0x186C5B6F0")]
	private Vector3 DDDGKOOIAFB(in (NFOBDEIMPJF Start, NFOBDEIMPJF End) HLJMFLIBFIG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BA30", Offset = "0x6C5AA30", VA = "0x186C5BA30")]
	public GOCGECOEJIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NEHCDOHEOOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private List<Transform> PPJNAKJMCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private Matrix4x4[] FIELIFAGHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Dictionary<string, Transform> LIFIFKKCDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Dictionary<Transform, Transform> POFGNOLHKEE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform[] PIGHMOIDFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D720", Offset = "0x6C5C720", VA = "0x186C5D720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Matrix4x4[] KGMMDGPIPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x978A80", Offset = "0x977A80", VA = "0x180978A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D180", Offset = "0x6C5C180", VA = "0x186C5D180")]
	public void KAMNDDMAICK(SkinnedMeshRenderer KEIBCBDBMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D030", Offset = "0x6C5C030", VA = "0x186C5D030")]
	public void BLEGJPKBFFK(Transform FPMOHOLCLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D0A0", Offset = "0x6C5C0A0", VA = "0x186C5D0A0")]
	private Transform HOKPFHCPLCH(Transform KPGDJFPJLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D330", Offset = "0x6C5C330", VA = "0x186C5D330")]
	public void MCHMJCFBEKG(NEHCDOHEOOM CNNAENOOLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D5B0", Offset = "0x6C5C5B0", VA = "0x186C5D5B0")]
	private void NJCCIEHBGFH(Transform FMNCHFNIOHH, List<Transform> IPKEGFKMCOE, Dictionary<string, Transform> FCACBGGDBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D770", Offset = "0x6C5C770", VA = "0x186C5D770")]
	public NEHCDOHEOOM()
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
		public enum DLBMHIMGMPH
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private const int SERIALIZATION_VERSION = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private string eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private DLBMHIMGMPH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private string baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1A3FAE0", Offset = "0x1A3EAE0", VA = "0x181A3FAE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA9F750", Offset = "0xA9E750", VA = "0x180A9F750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x97F070", Offset = "0x97E070", VA = "0x18097F070")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x97F010", Offset = "0x97E010", VA = "0x18097F010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x9F7120", Offset = "0x9F6120", VA = "0x1809F7120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x3C35620", Offset = "0x3C34620", VA = "0x183C35620")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xF95C90", Offset = "0xF94C90", VA = "0x180F95C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xBA7CB0", Offset = "0xBA6CB0", VA = "0x180BA7CB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xF402F0", Offset = "0xF3F2F0", VA = "0x180F402F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x94B760", Offset = "0x94A760", VA = "0x18094B760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x94AD10", Offset = "0x949D10", VA = "0x18094AD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6C58160", Offset = "0x6C57160", VA = "0x186C58160")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x103E230", Offset = "0x103D230", VA = "0x18103E230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xF9FE30", Offset = "0xF9EE30", VA = "0x180F9FE30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1032230", Offset = "0x1031230", VA = "0x181032230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x962CB0", Offset = "0x961CB0", VA = "0x180962CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9629F0", Offset = "0x9619F0", VA = "0x1809629F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x848B60", Offset = "0x847B60", VA = "0x180848B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x848B90", Offset = "0x847B90", VA = "0x180848B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x94AC50", Offset = "0x949C50", VA = "0x18094AC50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x94ABD0", Offset = "0x949BD0", VA = "0x18094ABD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x94AD40", Offset = "0x949D40", VA = "0x18094AD40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x94ACA0", Offset = "0x949CA0", VA = "0x18094ACA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x94ABE0", Offset = "0x949BE0", VA = "0x18094ABE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x842370", VA = "0x180843370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA19A10", Offset = "0xA18A10", VA = "0x180A19A10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA8F180", Offset = "0xA8E180", VA = "0x180A8F180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA823E0", Offset = "0xA813E0", VA = "0x180A823E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xADB170", Offset = "0xADA170", VA = "0x180ADB170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x842FB0", Offset = "0x841FB0", VA = "0x180842FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x842EA0", Offset = "0x841EA0", VA = "0x180842EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA9F940", Offset = "0xA9E940", VA = "0x180A9F940")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA9F780", Offset = "0xA9E780", VA = "0x180A9F780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public DLBMHIMGMPH UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6C58180", Offset = "0x6C57180", VA = "0x186C58180")]
			get
			{
				return default(DLBMHIMGMPH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5627580", Offset = "0x5626580", VA = "0x185627580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x131A930", Offset = "0x1319930", VA = "0x18131A930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x131A6C0", Offset = "0x13196C0", VA = "0x18131A6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6C58140", Offset = "0x6C57140", VA = "0x186C58140")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6C58240", Offset = "0x6C57240", VA = "0x186C58240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA2A240", Offset = "0xA29240", VA = "0x180A2A240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA960", Offset = "0xAA9960", VA = "0x180AAA960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6C581A0", Offset = "0x6C571A0", VA = "0x186C581A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x27F6DD0", Offset = "0x27F5DD0", VA = "0x1827F6DD0")]
		public string BCEEACLIKPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C57D10", Offset = "0x6C56D10", VA = "0x186C57D10")]
		public static AvatarCustomizationSettings BPADPDDPOEA(string PHFLADFIICC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C57EB0", Offset = "0x6C56EB0", VA = "0x186C57EB0")]
		public AvatarCustomizationSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum LLFHDJDEJJO
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum CJPNFKAJHFM
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum BAFPHPLPOKD
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum MOAGNEOMFCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum OCMKAFKGFGA
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum OFPFPDKGFGI
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum EDKKBEKPNPB
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HGDBGGOMACJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum CMHCEFEDFMF
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ONGOBKONJHL
{
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public static readonly int ENKKNNBLGED;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static readonly string CAABMEFDJJE;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public static readonly string EFBAIPDPOHP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E1A0", Offset = "0x6C5D1A0", VA = "0x186C5E1A0")]
	public static HDCGCLHCEMA DBMKMECGAIB()
	{
		return default(HDCGCLHCEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C5DD90", Offset = "0x6C5CD90", VA = "0x186C5DD90")]
	public static HEIHHIOGOGN AAGOPFJMPFC(Transform OGHPMJBPMMC, Transform AIFAIBEEOIA, AvatarConfiguration ANOHMKLJKNF, Animator GAACNGCCKAF, VRIK HADFLFJBONO, SkeletonLODUpdateRate[] PBJAHMHLOJN, GameObject[] NHFBIOKHLNH, Transform OPIEECEHIKL, GameObject BDEMAAIEDEN, BodySkinnedMeshLODs MOKGNIMLFHG, BodySkinnedMeshLODs MNEBNPIEBOB, GameObject OBAPMBMNPKE, BodySkinnedMeshLODs PCLLBAKBLEP, BodySkinnedMeshLODs HHGLFGJOIBH, NEHCDOHEOOM JKHBHOODOFF, Material HMPBELCFGEO, Material MEOMFMICKFH, Shader EFOBEOABKFD, Transform JHMLCGAPHBC, Transform GMKJNGBDDKG, Transform MNDHDNLMJGE, Transform LHNLNBKMMFO, Transform KOBFOOBBOMP)
	{
		return default(HEIHHIOGOGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E040", Offset = "0x6C5D040", VA = "0x186C5E040")]
	public static MOBCFEHKFLC BFOLIGJNOBL(string CINLLKKJFDI, bool ACOEEDCBILO, bool HHLEOONGGOO, bool BGOGBKPPGOI, RigidbodyEx LDFCKFPPGBO, RigidbodyEx PAHCCNOFPCG, RigidbodyEx ILNGHLCMDOM, RigidbodyEx AAKIGKOFEHK, Transform GFJDJIDCKLI, Transform CKEGBDBLOOL, Transform KFJOCFCHDLE, float ALNNELHJHDP, float DKJNEMKEDKM, PlayerAvatarFullBodyColliders NOCAEJIKCMJ)
	{
		return default(MOBCFEHKFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E270", Offset = "0x6C5D270", VA = "0x186C5E270")]
	public static ODENLEDKDIE FGADBCJEGHP(Transform AIFAIBEEOIA, GameObject BDEMAAIEDEN, SkinnedMeshRenderer[] BKOFNGMLKFH, SkinnedMeshRenderer[] APAOOIJAPGG, GameObject OBAPMBMNPKE, SkinnedMeshRenderer[] FIOIPGDGNLO, SkinnedMeshRenderer[] DOFDBGFLLFB, NEHCDOHEOOM JKHBHOODOFF, Material HMPBELCFGEO, Material MEOMFMICKFH, Shader EFOBEOABKFD)
	{
		return default(ODENLEDKDIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E4F0", Offset = "0x6C5D4F0", VA = "0x186C5E4F0")]
	public static OHIIJJLFHKH KPJMEJKCFFO(Transform JHMLCGAPHBC, Transform MNDHDNLMJGE, Transform GMKJNGBDDKG, Transform LHNLNBKMMFO, Transform KOBFOOBBOMP)
	{
		return default(OHIIJJLFHKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0xBFFD80", Offset = "0xBFED80", VA = "0x180BFFD80")]
	public static DAPFELMKDJI PJEDPPKBIKC(SkinnedMeshRenderer[] NAMJBLAMJFG)
	{
		return default(DAPFELMKDJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E3D0", Offset = "0x6C5D3D0", VA = "0x186C5E3D0")]
	public static GFDNDDHFAGI KIGGEOKDCKF(JKADKIBKOFL HADNLBLFIBO, int PGENHEEJLEB, int HBLJCPPKDCD, Color MKILMFEHAIC, Color IMDJCLBDPDI, int IDDGFCHIAJE, int MFOCOALOBOA, Color AMJMIHHFDFP, Color MLACOBDLPAM, int ABJEOMAHAKP, float LBPNHMJKOEL)
	{
		return default(GFDNDDHFAGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E5C0", Offset = "0x6C5D5C0", VA = "0x186C5E5C0")]
	public static ABPPBPOLKAG OLAIAHNOGMB(JKADKIBKOFL HADNLBLFIBO, Vector2 KJMCGPIDEOH, float ICJNPCCKIMO, Vector2 PNADLJDKMJG, float LOMPDCJJBMC, Vector2 FLDOGLFJDEH, float OOMKEOACJCF, float EKGKPCFKIHE, Vector2 OGICKCIKDDO, Vector2 DEGAGPAJPBJ)
	{
		return default(ABPPBPOLKAG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface CFIGPNELABP
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDPIJJCJOOG();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ODFNIKOPOEL<Texture2D> IMJILOMGAIH(JKIFBNPCELM PHBPOGNFMKP, [Optional] FAFHCJKJJDJ OBPACCONAMD);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PNNHJJGDKLK : CFIGPNELABP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MFAJGHBDJID LECAGGGKDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private IRecRoomQualityConfigProvider PCPKPMLPHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool CPMDNDCEIFK;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private const uint GCLBKPPAICD = 16u;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E790", Offset = "0x6C5D790", VA = "0x186C5E790")]
	[OHDKPIIHCBL(BGEACDHIFOF.GameOnly)]
	private static void DDAEKMPBAPL(ECDJHHJLGGB LADPAJPBFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E8C0", Offset = "0x3C1D8C0", VA = "0x183C1E8C0")]
	[Preserve]
	public PNNHJJGDKLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C5EDF0", Offset = "0x6C5DDF0", VA = "0x186C5EDF0")]
	private void LGNDNKDEJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C5EEA0", Offset = "0x6C5DEA0", VA = "0x186C5EEA0", Slot = "4")]
	public void PDPIJJCJOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E880", Offset = "0x6C5D880", VA = "0x186C5E880", Slot = "5")]
	public ODFNIKOPOEL<Texture2D> IMJILOMGAIH(JKIFBNPCELM PHBPOGNFMKP, [Optional] FAFHCJKJJDJ OBPACCONAMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C5EC30", Offset = "0x6C5DC30", VA = "0x186C5EC30")]
	private uint LAIGEFDLENF(JKIFBNPCELM PHBPOGNFMKP, FAFHCJKJJDJ OBPACCONAMD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MOBCFEHKFLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public string IBFCKHPDEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public bool JOFIIOOFMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool LADOMMOCBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float KGJCLHEKLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float HEIHKCNNKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public bool CDONDAGJBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public RigidbodyEx PHBLMPNKCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public RigidbodyEx IMJFKCMKKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public RigidbodyEx JCIIBECMGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public RigidbodyEx OBHJOGPDDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform FBIDBBHCECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform MMPNHJJMEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform FJOCAIALGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public PlayerAvatarFullBodyColliders JJFLCCLDMGF;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct HEIHHIOGOGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Transform IAAHOEBPJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Transform ANFHLMBBIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public AvatarConfiguration DKMGELIDDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Animator GFEEDFLNCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public VRIK HMCEFDFHHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public SkeletonLODUpdateRate[] BDAMFJCMEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public GameObject[] KDMNKCOPEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform LFEGFAPLKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public GameObject JNDALOCJEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public BodySkinnedMeshLODs LJCGEGADBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public BodySkinnedMeshLODs ELAHNMDMNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public GameObject LABAMNMMLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public BodySkinnedMeshLODs MGINBEDPMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public BodySkinnedMeshLODs CJJFNOKECFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public NEHCDOHEOOM LOGLAELLMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Material PGLONDCOIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Material MBDEGPKMMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Shader MOPPDHIJMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform FFLONAIDBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform HMOJAJHBPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Transform GIPECACFCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Transform GJIENPHFECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Transform LPGGICNBOBG;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct HDCGCLHCEMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public float PNOHBAEJKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool POCNIMPLFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public BHPPPFLNDLP DENPMLPADIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Vector3 JAIPENLAKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Vector3 OJMBPJCKIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Vector3? LMOBAMHNBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Vector3? DFLJJGAINPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public bool CAACIGDKAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public bool AEGAMKEILOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool MAMIKACAMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool IPGDGMOLJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool IKLFPEMJABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3? DFBLLALKAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public bool IOPMDGHHDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3? IIPDCGEGKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool IKOCMIBJPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3? FGKAIGAHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Vector3? DKIJFAKDFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool OIPHEKPLLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool CIPPBFAJNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool NCJPJNOAFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool IAFOAIOAHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool BGENJDCFGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool FLFOEMIDLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool ODDPJPBKGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool JGDFIALINIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool OFPCNFAGPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool PJKKLBLDPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector3? COEIHIFHJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public LLFHDJDEJJO OAIKNHOBICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public LLFHDJDEJJO AMDONCLIKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public float POBMLJLDLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public float LCCPJIAJKGI;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6C5A840", Offset = "0x6C59840", VA = "0x186C5A840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A780", Offset = "0x6C59780", VA = "0x186C5A780")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C59F50", Offset = "0x6C58F50", VA = "0x186C59F50")]
		public void HKPPNIKLIEG(FitMeshHemisphere JKPGAHNHJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A010", Offset = "0x6C59010", VA = "0x186C5A010")]
		public Vector3 JKCIFHJIODD(Vector2 LANFAFFGOHM, bool LBIPCODIEMP = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C59FA0", Offset = "0x6C58FA0", VA = "0x186C59FA0")]
		public Vector3 JIMOFKEDPBD(Vector2 LANFAFFGOHM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A480", Offset = "0x6C59480", VA = "0x186C5A480")]
		public Quaternion LJABCAABOOP(Vector2 LANFAFFGOHM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A360", Offset = "0x6C59360", VA = "0x186C5A360")]
		public Quaternion LJABCAABOOP(Vector2 LANFAFFGOHM, Vector3 EJNNCJCFPCG)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A5C0", Offset = "0x6C595C0", VA = "0x186C5A5C0")]
		private Vector2 NPHCHLJMCIP(Vector2 MGMPEBHGJLJ)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OMCPNEMGPHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public string EDEDJHKMHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public OutfitType APJDDCFNAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public BAFPHPLPOKD EAHKPGLMMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public bool MBMAPMKJJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Color? HPMDDCLEKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Vector3? BCKJKEKMMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public float? LKBPIPKNKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public Guid? MEAPCEEPOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public JIGHJMOEEPO? DFJFFEANDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public Color? DDHOMBLAMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public bool IKFNJOLBHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public bool CIGIIPEIIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public AnchorParamsRestrictions ODJFOAMJNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Vector2? BHKCGAOEIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Transform FLCCFEJDCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public FitMeshHemisphere MFDJJFNICOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Vector2 PFGFIEAHBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private List<AvatarHairPatternOverride> HDFBOHIKFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Dictionary<string, Texture2D> PEHFOKEGNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<AvatarHairPatternOverride> GFNKAPFPLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Dictionary<string, Texture2D> GFILKGJLCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public AssetReference GIBPFIEPOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public AssetReference HPIMBOIFAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public AssetReference[] BOOPCKBCIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public bool JNLPEEIACEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF1")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public bool NIBHEJNNCGO;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public List<AvatarHairPatternOverride> LGKKJMDDBIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9FE040", Offset = "0x9FD040", VA = "0x1809FE040")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D870", Offset = "0x6C5C870", VA = "0x186C5D870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public List<AvatarHairPatternOverride> AGPKLGHGOGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x97EC80", Offset = "0x97DC80", VA = "0x18097EC80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6C5DB50", Offset = "0x6C5CB50", VA = "0x186C5DB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public string FCOHNFAGEOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C5DAA0", Offset = "0x6C5CAA0", VA = "0x186C5DAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C5DD80", Offset = "0x6C5CD80", VA = "0x186C5DD80")]
	public OMCPNEMGPHI()
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
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public Vector2 NormalizedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Vector3 HemisphereOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public Vector3 HemisphereRotations;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static AnchorParams Default
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6C57CA0", Offset = "0x6C56CA0", VA = "0x186C57CA0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6C57B00", Offset = "0x6C56B00", VA = "0x186C57B00")]
		public AnchorParams(Vector2 GPNNBLENEJI, Vector3 FHDNKEDHAJK, Vector3 GEOGAFEHHGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C57B30", Offset = "0x6C56B30", VA = "0x186C57B30")]
		public AnchorParams(IJLEBNCEOFL FKKJAJJFDLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C57A10", Offset = "0x6C56A10", VA = "0x186C57A10", Slot = "4")]
		public bool Equals(AnchorParams JONIFABKCAI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface IJLEBNCEOFL
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool KKOPDLNMKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool OHJKHFNHLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool BECOGJCBDEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool BKAPOHGOHOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool GGPODBGLEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool FLMKAOHABDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool ILFGNKBEKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MEJIKFKBNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	float FPDBKKIMEJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	float LLDNLJKFNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	float EPGBFAGNBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	float GJAGBBABBAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	float NIDHGNHFDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float OAKJCLAJCNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	float NMCHPHCCJBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	float OBAAFLBFHHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	float ICNINMALFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	float PMECAHHMBOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	float ABAIJAOFIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	float NFEBDIFKPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	float EACNIFMGKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	float KAPBMMJKDFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	float OKMPHMCANEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	float HNPKLNJIGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 FBDINCOPPJL(Vector3 GEOGAFEHHGH);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 KPIGBOPHECN(Vector3 CBOAMGDNHCA);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 KGEECPPEDKP();

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 FJICHACDCGI();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AnchorParamsRestrictions : IJLEBNCEOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GetAllowTranslationX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6C57980", Offset = "0x6C56980", VA = "0x186C57980", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6C579B0", Offset = "0x6C569B0", VA = "0x186C579B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6C579E0", Offset = "0x6C569E0", VA = "0x186C579E0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6C578F0", Offset = "0x6C568F0", VA = "0x186C578F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6C57920", Offset = "0x6C56920", VA = "0x186C57920", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6C57950", Offset = "0x6C56950", VA = "0x186C57950", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9789D0", Offset = "0x9779D0", VA = "0x1809789D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2DF1090", Offset = "0x2DF0090", VA = "0x182DF1090", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x97C0D0", Offset = "0x97B0D0", VA = "0x18097C0D0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xA75BC0", Offset = "0xA74BC0", VA = "0x180A75BC0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1411B90", Offset = "0x1410B90", VA = "0x181411B90", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA78F60", Offset = "0xA77F60", VA = "0x180A78F60", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA78F50", Offset = "0xA77F50", VA = "0x180A78F50", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x203D1E0", Offset = "0x203C1E0", VA = "0x18203D1E0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x168E3F0", Offset = "0x168D3F0", VA = "0x18168E3F0", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x1557F90", Offset = "0x1556F90", VA = "0x181557F90", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA78F40", Offset = "0xA77F40", VA = "0x180A78F40", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xDF04E0", Offset = "0xDEF4E0", VA = "0x180DF04E0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3B5ABA0", Offset = "0x3B59BA0", VA = "0x183B5ABA0", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xE11F80", Offset = "0xE10F80", VA = "0x180E11F80", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAEE730", Offset = "0xAED730", VA = "0x180AEE730", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3B5AB90", Offset = "0x3B59B90", VA = "0x183B5AB90", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x3B5B1A0", Offset = "0x3B5A1A0", VA = "0x183B5B1A0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1748920", Offset = "0x1747920", VA = "0x181748920", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C57860", Offset = "0x6C56860", VA = "0x186C57860")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6C573C0", Offset = "0x6C563C0", VA = "0x186C573C0")]
		public AnchorParams AGAGPBCKOHF(AnchorParams LGDCLLGMAIB)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6C577A0", Offset = "0x6C567A0", VA = "0x186C577A0", Slot = "30")]
		public Vector3 KGEECPPEDKP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C57770", Offset = "0x6C56770", VA = "0x186C57770", Slot = "31")]
		public Vector3 FJICHACDCGI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6C576F0", Offset = "0x6C566F0", VA = "0x186C576F0", Slot = "28")]
		public Vector3 FBDINCOPPJL(Vector3 GEOGAFEHHGH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C577D0", Offset = "0x6C567D0", VA = "0x186C577D0", Slot = "29")]
		public Vector3 KPIGBOPHECN(Vector3 CBOAMGDNHCA)
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
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x843410", Offset = "0x842410", VA = "0x180843410", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D020", Offset = "0x6C5C020", VA = "0x186C5D020")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Dictionary<string, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6C59F30", Offset = "0x6C58F30", VA = "0x186C59F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6C598C0", Offset = "0x6C588C0", VA = "0x186C598C0")]
		public JKADKIBKOFL EJBHGJELEDC(int AANKCANOHGA, int NFBOAEDKEPO, int PFEPODPKGIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6C59C70", Offset = "0x6C58C70", VA = "0x186C59C70")]
		public FaceFeatureBase KJKDHKCHACI(FaceFeatureType EHDNLDJBOLK, string AGKIPDJPNCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C59830", Offset = "0x6C58830", VA = "0x186C59830")]
		public int DMMNNFGJBLP(string AGKIPDJPNCN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C59AC0", Offset = "0x6C58AC0", VA = "0x186C59AC0")]
		private void HBPKKGNMIBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x13EAB70", Offset = "0x13E9B70", VA = "0x1813EAB70")]
		private void HPNAIEGIBOP<T>(Dictionary<string, T> AINALLHHLMD, T[] LGPKIKBPKEI) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C59760", Offset = "0x6C58760", VA = "0x186C59760")]
		public string AGCBCCHMBJK(FaceFeatureType EHDNLDJBOLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6C59D90", Offset = "0x6C58D90", VA = "0x186C59D90")]
		public string NCOHNBNFNHB(FaceFeatureType EHDNLDJBOLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6C59EB0", Offset = "0x6C58EB0", VA = "0x186C59EB0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x84F960", Offset = "0x84E960", VA = "0x18084F960", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3417C90", Offset = "0x3416C90", VA = "0x183417C90")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3417CD0", Offset = "0x3416CD0", VA = "0x183417CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6C592C0", Offset = "0x6C582C0", VA = "0x186C592C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x3DD8070", Offset = "0x3DD7070", VA = "0x183DD8070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x6C592E0", Offset = "0x6C582E0", VA = "0x186C592E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6C59320", Offset = "0x6C58320", VA = "0x186C59320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6C59300", Offset = "0x6C58300", VA = "0x186C59300")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x3C5F790", Offset = "0x3C5E790", VA = "0x183C5F790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C58F80", Offset = "0x6C57F80", VA = "0x186C58F80", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6C59220", Offset = "0x6C58220", VA = "0x186C59220")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x96F410", Offset = "0x96E410", VA = "0x18096F410", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C58F70", Offset = "0x6C57F70", VA = "0x186C58F70")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x842FC0", Offset = "0x841FC0", VA = "0x180842FC0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D020", Offset = "0x6C5C020", VA = "0x186C5D020")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x34166D0", Offset = "0x34156D0", VA = "0x1834166D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x1CA7A20", Offset = "0x1CA6A20", VA = "0x181CA7A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x236D4D0", Offset = "0x236C4D0", VA = "0x18236D4D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x185AED0", Offset = "0x1859ED0", VA = "0x18185AED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6C595E0", Offset = "0x6C585E0", VA = "0x186C595E0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C59680", Offset = "0x6C58680", VA = "0x186C59680")]
		protected FaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class JKADKIBKOFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	private class IKMBKKGFKMD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public readonly Texture2DArray BMEIEPMFIJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public readonly Dictionary<string, int> KAGLKBEKHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private readonly OEMFJNEEEFM APKLANFGEEE;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool FPJPPBOLBOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xC4CB20", Offset = "0xC4BB20", VA = "0x180C4CB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6C5BE50", Offset = "0x6C5AE50", VA = "0x186C5BE50")]
		public IKMBKKGFKMD(Texture2DArray BNMHACLPGOO, Dictionary<string, int> DHDJCPLGCGG, JKADKIBKOFL OMGIEINECNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xC4A910", Offset = "0xC49910", VA = "0x180C4A910")]
		public void DOLECOJHIFO(JKADKIBKOFL DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xC495E0", Offset = "0xC485E0", VA = "0x180C495E0")]
		public void GNAAIMBDCNJ(JKADKIBKOFL DMHDKAFNNAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xE185B0", Offset = "0xE175B0", VA = "0x180E185B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	private struct KJJCGPEPPCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private readonly string DBOGBBBMMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly string KAMENOLPIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private readonly string DOCJIIOJFBJ;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x122BA00", Offset = "0x122AA00", VA = "0x18122BA00")]
		public KJJCGPEPPCE(string PLLPPMFKBFN, string BMEPDOLJKAO, string OECJOONMEOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CF10", Offset = "0x6C5BF10", VA = "0x186C5CF10")]
		public bool IFDICNKLMIJ(KJJCGPEPPCE JONIFABKCAI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CE40", Offset = "0x6C5BE40", VA = "0x186C5CE40", Slot = "0")]
		public override bool Equals(object DCGPCJKHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5B263E0", Offset = "0x5B253E0", VA = "0x185B263E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CF10", Offset = "0x6C5BF10", VA = "0x186C5CF10")]
		public static bool JFBEPFHBCDN(KJJCGPEPPCE KOMAFEKIKMM, KJJCGPEPPCE MKGHCBPGAGB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CF90", Offset = "0x6C5BF90", VA = "0x186C5CF90")]
		public static bool NLNNLODOBLO(KJJCGPEPPCE KOMAFEKIKMM, KJJCGPEPPCE MKGHCBPGAGB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly Dictionary<string, int> DHDJCPLGCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly KJJCGPEPPCE FOHKEHLPDPB;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public Texture2DArray NDLBKKJPMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x92E3F0", Offset = "0x92D3F0", VA = "0x18092E3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public SymmetricalFaceFeature PLIEDCNNALK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x91FD40", Offset = "0x91ED40", VA = "0x18091FD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x93A6D0", Offset = "0x9396D0", VA = "0x18093A6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public EyesFaceFeature OOMDKODIKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x91FD50", Offset = "0x91ED50", VA = "0x18091FD50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x93A760", Offset = "0x939760", VA = "0x18093A760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public FaceFeature GGGGNLIMLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x936350", Offset = "0x935350", VA = "0x180936350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9F7120", Offset = "0x9F6120", VA = "0x1809F7120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BFA0", Offset = "0x6C5AFA0", VA = "0x186C5BFA0")]
	private static void HINPDALKIIF(Sprite OCCPLGMJPPP, Sprite PPCAFMOEPFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BF30", Offset = "0x6C5AF30", VA = "0x186C5BF30")]
	private static void HGBAOBOHACA(Sprite KHDIDNLEFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CE20", Offset = "0x6C5BE20", VA = "0x186C5CE20")]
	public JKADKIBKOFL(EyesFaceFeature NFBOAEDKEPO, FaceFeature PFEPODPKGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C2B0", Offset = "0x6C5B2B0", VA = "0x186C5C2B0")]
	public JKADKIBKOFL(SymmetricalFaceFeature PODAAMGBPEA, EyesFaceFeature NFBOAEDKEPO, FaceFeature PFEPODPKGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C0A0", Offset = "0x6C5B0A0", VA = "0x186C5C0A0")]
	public bool NPNAICNLEDO(Sprite KHDIDNLEFOP, out int EJNMEMKEIOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BF20", Offset = "0x6C5AF20", VA = "0x186C5BF20", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xF9FE50", Offset = "0xF9EE50", VA = "0x180F9FE50")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5626E20", Offset = "0x5625E20", VA = "0x185626E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xF9FDA0", Offset = "0xF9EDA0", VA = "0x180F9FDA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x2DBB100", Offset = "0x2DBA100", VA = "0x182DBB100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x56274F0", Offset = "0x56264F0", VA = "0x1856274F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x4081050", Offset = "0x4080050", VA = "0x184081050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x6C5F490", Offset = "0x6C5E490", VA = "0x186C5F490")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x4081040", Offset = "0x4080040", VA = "0x184081040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F2B0", Offset = "0x6C5E2B0", VA = "0x186C5F2B0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F3C0", Offset = "0x6C5E3C0", VA = "0x186C5F3C0")]
		protected SymmetricalFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class FaceFeatureBase : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private FaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public FaceFeatureId FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x9A65E0", Offset = "0x9A55E0", VA = "0x1809A65E0")]
			get
			{
				return default(FaceFeatureId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9A4E00", Offset = "0x9A3E00", VA = "0x1809A4E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x9FE050", Offset = "0x9FD050", VA = "0x1809FE050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x403B1B0", Offset = "0x403A1B0", VA = "0x18403B1B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x6C58160", Offset = "0x6C57160", VA = "0x186C58160")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x103E230", Offset = "0x103D230", VA = "0x18103E230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6C593F0", Offset = "0x6C583F0", VA = "0x186C593F0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6C59460", Offset = "0x6C58460", VA = "0x186C59460", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6C594E0", Offset = "0x6C584E0", VA = "0x186C594E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x840120", Offset = "0x83F120", VA = "0x180840120", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6C59570", Offset = "0x6C58570", VA = "0x186C59570")]
		protected FaceFeatureBase()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x12847F0", Offset = "0x12837F0", VA = "0x1812847F0")]
	public static string PBLDHIKHPMH(byte[] IHGCJCCJPMA, byte[] NBKBACBBOJK)
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
