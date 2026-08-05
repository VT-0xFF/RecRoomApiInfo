using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Avatars.Face;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AvatarBodyPartBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public bool HasLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public bool HasLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool HasLocalScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Quaternion LocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Vector3 LocalScale;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6C40", Offset = "0x6AE5840", VA = "0x186AE6C40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarBodyPartBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct FaceShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AvatarFaceShapeData.DAHCNBNLNOG FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AnimationClip FaceShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct BodyShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AvatarBodyShapeData.AIFEAPBJMOI BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AnimationClip BodyShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct HeadShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AnimationClip HeadShapeAnimationClip;
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class KIOPHLPDIOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AvatarFaceShapeBoneData faceShapeData;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public KIOPHLPDIOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6AF2630", Offset = "0x6AF1230", VA = "0x186AF2630")]
			internal bool IABPMHCFDDE(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BGCEICBHFAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public AvatarBodyShapeBoneData bodyShapeData;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public BGCEICBHFAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6AEBFE0", Offset = "0x6AEABE0", VA = "0x186AEBFE0")]
			internal bool EHNHIEHCLNG(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class EGFHPEFJNMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AvatarHeadShapeBoneData headShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public EGFHPEFJNMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6AECD90", Offset = "0x6AEB990", VA = "0x186AECD90")]
			internal bool PLENIHLDBAP(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float ANIM_CLIP_EVAL_TIME = 0f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private List<AvatarHeadShapeBoneData> headShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<(string, AvatarFaceShapeData.DAHCNBNLNOG), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Dictionary<(string, AvatarBodyShapeData.AIFEAPBJMOI), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<string> headBonesToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6AE74D0", Offset = "0x6AE60D0", VA = "0x186AE74D0")]
		public void KMAKNPIEEHP(IReadOnlyDictionary<string, Transform> DCFGGPOAAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6AE6DD0", Offset = "0x6AE59D0", VA = "0x186AE6DD0")]
		public void AGAGPGCECHC(IReadOnlyDictionary<string, Transform> DCFGGPOAAIF, AvatarFaceShapeData.DAHCNBNLNOG AOBAPGLIILH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7D50", Offset = "0x6AE6950", VA = "0x186AE7D50")]
		public void NECFPEAFBBP(IReadOnlyDictionary<string, Transform> DCFGGPOAAIF, AvatarBodyShapeData.AIFEAPBJMOI GADFFFNBFBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7230", Offset = "0x6AE5E30", VA = "0x186AE7230")]
		public void DJDOHDMKCOC(IReadOnlyDictionary<string, Transform> DCFGGPOAAIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7160", Offset = "0x6AE5D60", VA = "0x186AE7160")]
		private Vector3 CKFDNMOBGMH(Transform NPOGHJKFAJL, AvatarBodyPartBoneData INMEDPCEMDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6AE71D0", Offset = "0x6AE5DD0", VA = "0x186AE71D0")]
		private Quaternion DIOPJOHOPPB(Transform NPOGHJKFAJL, AvatarBodyPartBoneData INMEDPCEMDP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7460", Offset = "0x6AE6060", VA = "0x186AE7460")]
		private Vector3 GDEJIHJEEAG(Transform NPOGHJKFAJL, AvatarBodyPartBoneData INMEDPCEMDP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7060", Offset = "0x6AE5C60", VA = "0x186AE7060")]
		private void CHPKABANHOB(Transform NPOGHJKFAJL, AvatarBodyPartBoneData INMEDPCEMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE7FE0", Offset = "0x6AE6BE0", VA = "0x186AE7FE0")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum AIFEAPBJMOI
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			Pear,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Apple,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Hourglass,
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AIFEAPBJMOI blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[HideInInspector]
		[Obsolete("Use BodyShapeId instead!")]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NEHAEFNHPDF BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x12AB770", Offset = "0x12AA370", VA = "0x1812AB770")]
			get
			{
				return default(NEHAEFNHPDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8A30", Offset = "0x6AE7630", VA = "0x186AE8A30")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AvatarBodyShapeData.AIFEAPBJMOI BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AE82B0", Offset = "0x6AE6EB0", VA = "0x186AE82B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<NEHAEFNHPDF, AvatarBodyShape> MKOEPJBJLPE;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8520", Offset = "0x6AE7120", VA = "0x186AE8520")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8840", Offset = "0x6AE7440", VA = "0x186AE8840")]
		public AvatarBodyShape Find(NEHAEFNHPDF FJKPPCEADKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8940", Offset = "0x6AE7540", VA = "0x186AE8940")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8900", Offset = "0x6AE7500", VA = "0x186AE8900")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8980", Offset = "0x6AE7580", VA = "0x186AE8980")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EEOHMNMPFBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private Transform[] HOFHMMEJBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly Dictionary<string, Transform> JPGCLNHAFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly Dictionary<Transform, Transform> BIGNGCJGHMF;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<string, Transform> NEAMIIBDNBM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Transform[] IDDIIDILEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC9A0", Offset = "0x6AEB5A0", VA = "0x186AEC9A0")]
	public void DNBNDCIPJIB(Transform JKEPKGLGLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6AECA80", Offset = "0x6AEB680", VA = "0x186AECA80")]
	public Transform ECAPIOKELEF(Transform OCEHGOCFLOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC760", Offset = "0x6AEB360", VA = "0x186AEC760")]
	public void DKBCEIFLLFP(SkinnedMeshRenderer HOBMEDAJNBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6AECB60", Offset = "0x6AEB760", VA = "0x186AECB60")]
	private static void HALHMCKFFKB(Transform AHFIDHNOIFE, List<Transform> IOMCJDOMECE, Dictionary<string, Transform> NKJLCCJEAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6AECCC0", Offset = "0x6AEB8C0", VA = "0x186AECCC0")]
	public EEOHMNMPFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NPOOPLDBDAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public bool PGCLEFIIPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public bool NMGILEFBANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public bool GFKEGFGALPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public OCAFLGKEFMJ? EOEDNCMAOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public HDFJPOEIMPO.CLDPEDONPKD PEMBKCPHOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public HairData DGAAPAKIJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public AdditionalHatData HMBPPIBAJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public bool NAPLEDELHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool KGCPMKOBDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool OLODLKGDICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public IList<MCOGOHBOKKE> GACLBIIABHC;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public NPOOPLDBDAC()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("How far apart you can position your eyebrows.")]
		[Header("Face Features")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Header("Hand Animation")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8AC0", Offset = "0x6AE76C0", VA = "0x186AE8AC0")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KJHPJMBPNCL
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly OAECLKNPHFM KLNBIAHEHPJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static KLLNLHCALDO DEEEEJMIOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AF2690", Offset = "0x6AF1290", VA = "0x186AF2690")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct LOPJKEANIKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Transform LGMDEOOGBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public AssetReference JANBCPLNDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public GameObject PAFDDNFOMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public GameObject HMAGFFCDCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public SkinnedMeshRenderer FAOHFMFPCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public AvatarSkinnedMeshBoneOrderRemapsData CFFEMGGILPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Material GPHPDLFBEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Material FNAHEKPKOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Material ECJIGHCFOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Shader LGMAMIAAMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Shader LIBNGHGBOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Animator MKCEHIJGKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Renderer[] IEFHMLODHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AvatarConfiguration NEPAENHGIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public AvatarBodyPartShapesManager MNBFIBKDDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public IReadOnlyDictionary<string, Transform> AIJLCJOEDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Transform EIEMHMIAJML;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct NEEDEDOCBFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public SkinnedMeshRenderer[] INNAKFLAJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public SkinnedMeshRenderer[] HDEJEKFGMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer[] DBOKIAPNJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public SkinnedMeshRenderer[] HODCDLEMCDA;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct BCCKEDHFHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Transform IGNEFMGPGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Transform MGHCKDHANMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Transform LPIEFNACDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform OPOHAALHPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform GCAGHBGIFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform DFHDHPFJGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform MOHBJBPHBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public AvatarConfiguration NEPAENHGIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public CAJNNHABANH AJOKNLHADPE;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IJIJJOAHEKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public SkinnedMeshRenderer[] MHIOOGHDHPK;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ENAMNFICJJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public FHBHPBPNMDC LKBIBOHPELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public int BPICCGDDHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public int IHPEHKDCDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public Color LIEBOEMOJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public Color GAFMFKAGGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public int MFKFFAJGAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int JJDFCHJLADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Color OAENKOBOHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Color ALDMJPLIOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public int EPJLBGOEJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public float NLDFOBMFOIF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PBNIDPLGMPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public FHBHPBPNMDC LKBIBOHPELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Vector2 HNOGJBNINAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public float PMOHMKMDFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Vector2 INIDMBFAGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float PPHKNFHBLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Vector2 PMFGHAEADCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public float NNDKMGCNEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector2 IMCOCBLBFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public float BAOFFCFFADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public bool FMEBNJFJCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public bool EGGLEAPNLPA;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum DAHCNBNLNOG
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public DAHCNBNLNOG blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[HideInInspector]
		[SerializeField]
		[Obsolete("Use FaceShapeId instead!")]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public HDCHENBKBCD FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x12AB770", Offset = "0x12AA370", VA = "0x1812AB770")]
			get
			{
				return default(HDCHENBKBCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9750", Offset = "0x6AE8350", VA = "0x186AE9750", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6AE97B0", Offset = "0x6AE83B0", VA = "0x186AE97B0")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AvatarFaceShapeData.DAHCNBNLNOG FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8FD0", Offset = "0x6AE7BD0", VA = "0x186AE8FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly Dictionary<HDCHENBKBCD, AvatarFaceShape> MKOEPJBJLPE;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9240", Offset = "0x6AE7E40", VA = "0x186AE9240")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9560", Offset = "0x6AE8160", VA = "0x186AE9560")]
		public AvatarFaceShape Find(HDCHENBKBCD LNDEBGHHLCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9660", Offset = "0x6AE8260", VA = "0x186AE9660")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9620", Offset = "0x6AE8220", VA = "0x186AE9620")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6AE96A0", Offset = "0x6AE82A0", VA = "0x186AE96A0")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9E00", Offset = "0x6AE8A00", VA = "0x186AE9E00")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BMMFMLLGCKA HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x12AB770", Offset = "0x12AA370", VA = "0x1812AB770")]
			get
			{
				return default(BMMFMLLGCKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4160", Offset = "0x8F2D60", VA = "0x1808F4160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8F3BB0", Offset = "0x8F27B0", VA = "0x1808F3BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9E10", Offset = "0x6AE8A10", VA = "0x186AE9E10")]
		public Texture2D CMIPOJCEGHD(HairPatternStyle GFBDAABEOLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9FD0", Offset = "0x6AE8BD0", VA = "0x186AE9FD0", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9F60", Offset = "0x6AE8B60", VA = "0x186AE9F60", Slot = "4")]
		public bool Equals(AvatarHairPattern FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA140", Offset = "0x6AE8D40", VA = "0x186AEA140", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA0B0", Offset = "0x6AE8CB0", VA = "0x186AEA0B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA080", Offset = "0x6AE8C80", VA = "0x186AEA080")]
		public static bool GBEMIEIJNBP(AvatarHairPattern CKONCFGMELN, AvatarHairPattern GAAMPOEMOPE)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA0C0", Offset = "0x6AE8CC0", VA = "0x186AEA0C0")]
		public static bool PCHFOHOKDFG(AvatarHairPattern CKONCFGMELN, AvatarHairPattern GAAMPOEMOPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA180", Offset = "0x6AE8D80", VA = "0x186AEA180")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum MBPKGLMAGIN
{
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Idle,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Invisible,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Pointing,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	TPose,
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	ThumbUp,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	HandShake,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Grabbing,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	NumStates
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[Flags]
public enum OGEPNFICIOA
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	ThumbUp = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Pointing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HandShake = 4
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PAANAJPJBBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public Animator JPDCDJINBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public KOEIKGEMDHH GDDJJEABJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public AvatarConfiguration NEPAENHGIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public GameObject LOGGHBJPPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public CAJNNHABANH AJOKNLHADPE;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct GKLAGBPIGPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public Transform DJKGCICENCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public bool AMCBHJAGHMD;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA290", Offset = "0x6AE8E90", VA = "0x186AEA290", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MCOGOHBOKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public string IHBMAHBKJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public OutfitType GBKMBDPHJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public BCGODMJDFFO KMNONFEOPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public HDFJPOEIMPO.CLDPEDONPKD MJFOPINEILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public bool DPHECJAIBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public bool BMFDODPPPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public bool COEIGNMJALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Color? BOKOBEGKHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Guid? CODBDEHDFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Color? EJFLILPINED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public bool OHFOHJLJNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public bool BOLEBIMFMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public bool CDJDHKBCNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Transform ICDJBIBDFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public Vector2? AIKFBIFOIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public FitMeshHemisphere KJPMOJOEJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public AssetReference DEALELKOHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public AssetReference KCELFLNAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public AssetReference[] LKDLKBBOPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public MCOGOHBOKKE DLIKNCGLEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public bool ALNMKGDMBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public bool BJPHHANOBDF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string KDMDJKONIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6AF2830", Offset = "0x6AF1430", VA = "0x186AF2830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6AF2830", Offset = "0x6AF1430", VA = "0x186AF2830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AF28E0", Offset = "0x6AF14E0", VA = "0x186AF28E0")]
	public MCOGOHBOKKE()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private IKMBCIMLILF? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IDJGAJOPJGM CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6AEA860", Offset = "0x6AE9460", VA = "0x186AEA860")]
			get
			{
				return default(IDJGAJOPJGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IKMBCIMLILF MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6AEA890", Offset = "0x6AE9490", VA = "0x186AEA890")]
			get
			{
				return default(IKMBCIMLILF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x88C740", Offset = "0x88B340", VA = "0x18088C740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x88C530", Offset = "0x88B130", VA = "0x18088C530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA510", Offset = "0x6AE9110", VA = "0x186AEA510")]
		public Material[] IPFNBGJGKHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA320", Offset = "0x6AE8F20", VA = "0x186AEA320")]
		public static void CBBBMNAMPHM(AvatarItemMaterial FOMGNODOPGA, Material OFCNJEFMNEM, int PFCHKADCENO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA5F0", Offset = "0x6AE91F0", VA = "0x186AEA5F0")]
		private static bool PPDJOEFNEDG(AvatarItemMaterial FOMGNODOPGA, int PFCHKADCENO, [Out] Material LGAPAPNGGON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA7A0", Offset = "0x6AE93A0", VA = "0x186AEA7A0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CDFOCDBLBEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public SkinnedMeshRenderer MIEKKAJIMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Material[] LOECIALBCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private byte[] NHHEEAFIHJJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Mesh NHOPBGNMJJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC1F0", Offset = "0x6AEADF0", VA = "0x186AEC1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Material[] PLBPEIEHHPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public byte[] AGFGBOKCCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC210", Offset = "0x6AEAE10", VA = "0x186AEC210")]
	public CDFOCDBLBEP(SkinnedMeshRenderer CJKFIKFIAMM, AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN, Material[] OMIMDKJHAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC050", Offset = "0x6AEAC50", VA = "0x186AEC050")]
	public static CDFOCDBLBEP DMINAPPOGGC(Renderer HKFOEGKIJPH, AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN, Material[] OMIMDKJHAKM)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD854F0", Offset = "0xD840F0", VA = "0x180D854F0")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xFCB2B0", Offset = "0xFC9EB0", VA = "0x180FCB2B0")]
		public void GAOLHIMCFIN(Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DDMMIGKPJHF
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC4A0", Offset = "0x6AEB0A0", VA = "0x186AEC4A0")]
	public static PositionAndRotation FIGIMIPLIOB(this PositionAndRotation PDBGMIGPDFI)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC400", Offset = "0x6AEB000", VA = "0x186AEC400")]
	public static float CGHADILPOMF(float APOGBJPOAAH, Vector2 DLPMHDHAPCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC380", Offset = "0x6AEAF80", VA = "0x186AEC380")]
	public static float CGHADILPOMF(float APOGBJPOAAH, float FDBDHJDBKGA, float PHHIFEMAANE, float CAIIHNDCIIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC5F0", Offset = "0x6AEB1F0", VA = "0x186AEC5F0")]
	public static float PGHHHKCCBJA(float CABLCDOIFFL, Vector2 DLPMHDHAPCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6AEC6B0", Offset = "0x6AEB2B0", VA = "0x186AEC6B0")]
	public static float PGHHHKCCBJA(float CABLCDOIFFL, float FDBDHJDBKGA, float PHHIFEMAANE, float CAIIHNDCIIE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum NMMOJJIJEDB
{
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum MALAKPJDCFE
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	AimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	MeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	LightItem,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	HeavyItem,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	AimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Action,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	NumTypes
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct OAECIPABEIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public Vector2 KNGMGAPDFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public Vector2 EAOPBEAMJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector2 DDDJEIMCIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector2 DDAIKIKGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector2 OKAHABMAJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public Vector2 KNMLIPOAFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Vector2 FFFOHKMMIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector2 LHDNPGCKHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector2 PAJCCAFAHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector2 MIGBICNBFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector2 DMJGIEAIKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector2 KIHJGGDEBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Vector2 BOIBIFNNMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public Vector2 NJEBJFNGDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public Vector2 HIGFGFOJKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public Vector2 GAJAGBCGPNJ;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class FOCDJODOKKI
{
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public static readonly int EEOAHMOKOMA;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public static readonly string OEJDPPCLMKO;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6AF06D0", Offset = "0x6AEF2D0", VA = "0x186AF06D0")]
	public static LOPJKEANIKI EBGJFNPNOBE(Transform CGKOIDCAPPO, AssetReference ILIFCPMOMKA, GameObject MCEKFBCPALG, GameObject PAIMPCKICBE, SkinnedMeshRenderer FIDIINEDMPA, AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN, Material MMGOHCCJAEP, Material JMCHKAHGEKH, Material KNKMFKPBFHH, Shader CBLFIINEPDK, Shader KODMBDAGABO, Animator ICHGCFIBMGO, Renderer[] EFDIACPKMCF, AvatarConfiguration GFGAGDKNLPB, AvatarBodyPartShapesManager KJGNDEFFIOJ, IReadOnlyDictionary<string, Transform> DCFGGPOAAIF, Transform MCDCIMLOKMK)
	{
		return default(LOPJKEANIKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6AF08E0", Offset = "0x6AEF4E0", VA = "0x186AF08E0")]
	public static NEEDEDOCBFK LINHENHGHKN(SkinnedMeshRenderer[] EIFNABKIHIB, SkinnedMeshRenderer[] PPDCJNMKNLH, SkinnedMeshRenderer[] GEALCHPEAJK, SkinnedMeshRenderer[] FNEIPOAJKBG)
	{
		return default(NEEDEDOCBFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0A50", Offset = "0x6AEF650", VA = "0x186AF0A50")]
	public static BCCKEDHFHFC NJFNIJGHGGP(Transform KPNLOFGBHIL, Transform CNJKKIPMONJ, Transform JGPLHOBAGLP, Transform OHJEPFBDNCG, Transform FOHLCMFDMIL, Transform CHJOPFBKIHO, Transform KEPOAHBJEKJ, AvatarConfiguration HHLIGGKGFMB, CAJNNHABANH HFBIBPKGGBP)
	{
		return default(BCCKEDHFHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xB491A0", Offset = "0xB47DA0", VA = "0x180B491A0")]
	public static IJIJJOAHEKP OOLCNBLANOP(SkinnedMeshRenderer[] EDFGAIMJKHG)
	{
		return default(IJIJJOAHEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0B30", Offset = "0x6AEF730", VA = "0x186AF0B30")]
	public static ENAMNFICJJE OCLNIHBFEGL(FHBHPBPNMDC JFLGHEIFNMB, int DOGOMPEGJME, int IHMCCKNDNCJ, Color CCPEENNKJBI, Color OMOAFKKLPOL, int LNDAGNBDEBI, int KIPGNHELPIK, Color EHNKEHOPNEK, Color BEFDAHMFHGG, int DEMFBIANDKB)
	{
		return default(ENAMNFICJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0960", Offset = "0x6AEF560", VA = "0x186AF0960")]
	public static PBNIDPLGMPH LMJIHNMJIFH(FHBHPBPNMDC JFLGHEIFNMB, Vector2 AIKPGLEGGJG, float PDHEPKLFGCC, Vector2 AEHPFFAJOOK, float JBCDBHMBNIE, Vector2 OFIJEOEBDBD, float BBJGNHIMGBG, Vector2 OBJGNDFKDNI, float EFKLBENPEFB)
	{
		return default(PBNIDPLGMPH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0860", Offset = "0x6AEF460", VA = "0x186AF0860")]
	public static PAANAJPJBBM HJAAHACHICE(Animator DOFMOKPAFJE, KOEIKGEMDHH HPPNBIGMALD, AvatarConfiguration GFGAGDKNLPB, GameObject ICBIOEBGECE, CAJNNHABANH HFBIBPKGGBP)
	{
		return default(PAANAJPJBBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0A10", Offset = "0x6AEF610", VA = "0x186AF0A10")]
	public static GKLAGBPIGPE NDIPGINIBBK(Transform IAAOALNEPOB, bool OAEJOFPEHGL)
	{
		return default(GKLAGBPIGPE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class FDKLGIJNAMK
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6AED2F0", Offset = "0x6AEBEF0", VA = "0x186AED2F0")]
	public static MBPKGLMAGIN BJMEGJAGHCI(this NMMOJJIJEDB JLGIAOIGDHH)
	{
		return default(MBPKGLMAGIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6AED340", Offset = "0x6AEBF40", VA = "0x186AED340")]
	public static bool KCCECJNACDK(this NMMOJJIJEDB MDIMNMOCHHB)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum AKLBINDGFJM
		{
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private NoseMeshConfiguration[] noseMeshConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Dictionary<OCAFLGKEFMJ, BodySkinnedMeshLODs> JCMBOJIKMOJ;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public BodySkinnedMeshLODs ILGGFIFNBPC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public BodySkinnedMeshLODs PLKGNJMLDKK
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BodySkinnedMeshLODs HCGNDLGJGMC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BodySkinnedMeshLODs LLMIMGOEION
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6AEABF0", Offset = "0x6AE97F0", VA = "0x186AEABF0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6AEA950", Offset = "0x6AE9550", VA = "0x186AEA950")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(AKLBINDGFJM HKOOCHBBHLN, [Optional] OCAFLGKEFMJ? MJOGIHLEJDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6AEACF0", Offset = "0x6AE98F0", VA = "0x186AEACF0")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class IIHEABNLHNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public IIHEABNLHNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x6AF2600", Offset = "0x6AF1200", VA = "0x186AF2600")]
			internal bool DKKAEDLINJJ(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAD80", Offset = "0x6AE9980", VA = "0x186AEAD80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAD80", Offset = "0x6AE9980", VA = "0x186AEAD80")]
		private void EAJCEBIHJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB830", Offset = "0x6AEA430", VA = "0x186AEB830")]
		private void JICAJABEHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAD90", Offset = "0x6AE9990", VA = "0x186AEAD90")]
		public byte[] EALCKIMHNDO(string ABGCACLOJHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6AEAE00", Offset = "0x6AE9A00", VA = "0x186AEAE00")]
		public bool EOCBODAFAFN(SkinnedMeshBoneOrderData ICIPBCGMEAO, AvatarSkinnedMeshBonesController OIBIFABMHKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6AEB9E0", Offset = "0x6AEA5E0", VA = "0x186AEB9E0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class ANOJCMEGGIP
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct PHIEEFHFKLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform[] IDDIIDILEDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Matrix4x4[] PFGBMHOCNGH;
	}

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static readonly string FINEICEAJGO;

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6AF0", Offset = "0x6AE56F0", VA = "0x186AE6AF0")]
	public static byte[] PGJAAAOFGIH(AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN, SkinnedMeshRenderer HOBMEDAJNBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE65F0", Offset = "0x6AE51F0", VA = "0x186AE65F0")]
	public static PHIEEFHFKLO? LAHCFABOMKB(AvatarSkinnedMeshBoneOrderRemapsData PJODNPEPLIN, SkinnedMeshRenderer HOBMEDAJNBP)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[ReadOnlyField]
		[SerializeField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string GKFPAJFNHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBAB0", Offset = "0x6AEA6B0", VA = "0x186AEBAB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBFD0", Offset = "0x6AEABD0", VA = "0x186AEBFD0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBF10", Offset = "0x6AEAB10", VA = "0x186AEBF10")]
		private void JICAJABEHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBAE0", Offset = "0x6AEA6E0", VA = "0x186AEBAE0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6AEBB40", Offset = "0x6AEA740", VA = "0x186AEBB40")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer HKFOEGKIJPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum GEDNGKCDJJI
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EHJFAJIMFLL
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public static readonly EHJFAJIMFLL GHFEJGGLAKB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int DINNHMNHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x88FB90", Offset = "0x88E790", VA = "0x18088FB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GEDNGKCDJJI OMGDNIOOMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x917870", Offset = "0x916470", VA = "0x180917870")]
		[CompilerGenerated]
		get
		{
			return default(GEDNGKCDJJI);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x916BE0", Offset = "0x9157E0", VA = "0x180916BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public EHJFAJIMFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x277A040", Offset = "0x2778C40", VA = "0x18277A040")]
	public EHJFAJIMFLL(GEDNGKCDJJI DCNHCLKJAMO, int BCNBAKKCPHP)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6AF2020", Offset = "0x6AF0C20", VA = "0x186AF2020")]
		public void DrawPosition(bool ACJNCMDHMAI, Transform OHCKGBMFMEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6AF20C0", Offset = "0x6AF0CC0", VA = "0x186AF20C0")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere PAMJEKBLJGL, Transform CDBGCEIGNJC, Vector2 OBOCMMHOGDA, AnchorParamsRestrictions MIJBBDFKOGC, bool ECDMGNAGPGK = false, bool KAKJDHLOACO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public FitMeshPreviewGizmo()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct NoseMeshConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public NoseFaceOption NoseOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public BodySkinnedMeshLODs Meshes;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3500", Offset = "0x6AF2100", VA = "0x186AF3500")]
		public void CIJJOIJGMBO(SkinnedMeshRenderer HOBMEDAJNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6AF36A0", Offset = "0x6AF22A0", VA = "0x186AF36A0")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[Header("Remapping Eye Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9800", Offset = "0x6AE8400", VA = "0x186AE9800")]
		public void ENBDGEJOBAP(ACMANOBCHLK DGPOLJALFIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9CE0", Offset = "0x6AE88E0", VA = "0x186AE9CE0")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA69BA0", Offset = "0xA687A0", VA = "0x180A69BA0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6AEC040", Offset = "0x6AEAC40", VA = "0x186AEC040")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x88A150", Offset = "0x888D50", VA = "0x18088A150", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x6AED270", Offset = "0x6AEBE70", VA = "0x186AED270")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x6AED2D0", Offset = "0x6AEBED0", VA = "0x186AED2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x6AED290", Offset = "0x6AEBE90", VA = "0x186AED290")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x68F6E80", Offset = "0x68F5A80", VA = "0x1868F6E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x6AED2B0", Offset = "0x6AEBEB0", VA = "0x186AED2B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1CBB0A0", Offset = "0x1CB9CA0", VA = "0x181CBB0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xFFFE00", Offset = "0xFFEA00", VA = "0x180FFFE00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x6AED2E0", Offset = "0x6AEBEE0", VA = "0x186AED2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6AECE70", Offset = "0x6AEBA70", VA = "0x186AECE70", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6AED160", Offset = "0x6AEBD60", VA = "0x186AED160")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x6AF16D0", Offset = "0x6AF02D0", VA = "0x186AF16D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x127EE40", Offset = "0x127DA40", VA = "0x18127EE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xE406F0", Offset = "0xE3F2F0", VA = "0x180E406F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x127F020", Offset = "0x127DC20", VA = "0x18127F020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6AF14A0", Offset = "0x6AF00A0", VA = "0x186AF14A0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6AF15E0", Offset = "0x6AF01E0", VA = "0x186AF15E0")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x6AF3A90", Offset = "0x6AF2690", VA = "0x186AF3A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x6AF4720", Offset = "0x6AF3320", VA = "0x186AF4720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly List<MGEGMLPKNPK<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x88C490", Offset = "0x88B090", VA = "0x18088C490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x88C5F0", Offset = "0x88B1F0", VA = "0x18088C5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6AF13F0", Offset = "0x6AEFFF0", VA = "0x186AF13F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6AF1460", Offset = "0x6AF0060", VA = "0x186AF1460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x6AF1380", Offset = "0x6AEFF80", VA = "0x186AF1380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6AF13D0", Offset = "0x6AEFFD0", VA = "0x186AF13D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x60596E0", Offset = "0x60582E0", VA = "0x1860596E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0E60", Offset = "0x6AEFA60", VA = "0x186AF0E60")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0FA0", Offset = "0x6AEFBA0", VA = "0x186AF0FA0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0ED0", Offset = "0x6AEFAD0", VA = "0x186AF0ED0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1080", Offset = "0x6AEFC80", VA = "0x186AF1080")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6AF0C50", Offset = "0x6AEF850", VA = "0x186AF0C50")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1180", Offset = "0x6AEFD80", VA = "0x186AF1180")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class FHBHPBPNMDC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct OFFEOBKCDDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public AsyncTaskMethodBuilder<FHBHPBPNMDC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private KBDLCKKEKFO.AMLCGEIIEIJ <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6AF2E60", Offset = "0x6AF1A60", VA = "0x186AF2E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3490", Offset = "0x6AF2090", VA = "0x186AF3490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly Dictionary<string, int> FPCLMNABCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private bool KEPPICNGJJG;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Texture2DArray IPHODHEDKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public SymmetricalFaceFeature HCMILDBMLML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public EyesFaceFeature PEMMNMCKAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x88ABC0", Offset = "0x8897C0", VA = "0x18088ABC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public FaceFeature DFGGCNKBLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6AF01E0", Offset = "0x6AEEDE0", VA = "0x186AF01E0")]
	private static void NBIMEJKBHNF(Sprite CGPIFPCHDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0150", Offset = "0x6AEED50", VA = "0x186AF0150")]
	public static FHBHPBPNMDC EGOPIDLMMAP(SymmetricalFaceFeature PELODBIFDLD, EyesFaceFeature DPKLBNGAKMN, FaceFeature POLEGOOKPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF6E0", Offset = "0x6AEE2E0", VA = "0x186AEF6E0")]
	[AsyncStateMachine(typeof(OFFEOBKCDDK))]
	public static Task<FHBHPBPNMDC> AMDMHLBGICN(SymmetricalFaceFeature PELODBIFDLD, EyesFaceFeature DPKLBNGAKMN, FaceFeature POLEGOOKPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0310", Offset = "0x6AEEF10", VA = "0x186AF0310")]
	private FHBHPBPNMDC(SymmetricalFaceFeature PELODBIFDLD, EyesFaceFeature DPKLBNGAKMN, FaceFeature POLEGOOKPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF910", Offset = "0x6AEE510", VA = "0x186AEF910")]
	private void COOBGFFKIAK(List<Sprite> KENOMOODGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF820", Offset = "0x6AEE420", VA = "0x186AEF820")]
	public bool CGALFFAMBIF(string MIMLJJIOMLJ, [Out] int MFJLAMOCOBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0120", Offset = "0x6AEED20", VA = "0x186AF0120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0250", Offset = "0x6AEEE50", VA = "0x186AF0250")]
	public bool OFMFOLKKKLF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6AF0050", Offset = "0x6AEEC50", VA = "0x186AF0050")]
	public void DMLLKANAFMJ()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct NDFKKANEGHE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public AsyncTaskMethodBuilder<FHBHPBPNMDC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			private TaskAwaiter<FHBHPBPNMDC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x6AF28F0", Offset = "0x6AF14F0", VA = "0x186AF28F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x6AF2DF0", Offset = "0x6AF19F0", VA = "0x186AF2DF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private Dictionary<OCAFLGKEFMJ, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Dictionary<OCAFLGKEFMJ, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private Dictionary<OCAFLGKEFMJ, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private Dictionary<OCAFLGKEFMJ, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly Dictionary<OCAFLGKEFMJ, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private FHBHPBPNMDC _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private FHBHPBPNMDC _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x6AF1FF0", Offset = "0x6AF0BF0", VA = "0x186AF1FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6AF16F0", Offset = "0x6AF02F0", VA = "0x186AF16F0")]
		public FHBHPBPNMDC CPGDAHAFKHI(CAJNNHABANH HFBIBPKGGBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1820", Offset = "0x6AF0420", VA = "0x186AF1820")]
		[AsyncStateMachine(typeof(NDFKKANEGHE))]
		public Task<FHBHPBPNMDC> DMAOCFFGNIG(int? OLJNGDAIDDG, int DPKLBNGAKMN, int POLEGOOKPAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1780", Offset = "0x6AF0380", VA = "0x186AF1780")]
		public NoseFaceOption DCCLINNBAHM(int EPAOKMMFMAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1C30", Offset = "0x6AF0830", VA = "0x186AF1C30")]
		public SelectableFaceOption NBNLOGGFLPH(FaceFeatureType BOCNMNBFMDO, OCAFLGKEFMJ HAANOCJKGJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1DB0", Offset = "0x6AF09B0", VA = "0x186AF1DB0")]
		public int PABGPPDNCMD(OCAFLGKEFMJ HAANOCJKGJH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1A00", Offset = "0x6AF0600", VA = "0x186AF1A00")]
		private void GICADNAIOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2DF34E0", Offset = "0x2DF20E0", VA = "0x182DF34E0")]
		private void BIPIAKJOJPM<T>(IDictionary<OCAFLGKEFMJ, T> MPMLAHPFKKM, IReadOnlyList<T> GBAJOIIBJPC) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1950", Offset = "0x6AF0550", VA = "0x186AF1950")]
		public OCAFLGKEFMJ GHIDHJAKJBB(FaceFeatureType BOCNMNBFMDO)
		{
			return default(OCAFLGKEFMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1E30", Offset = "0x6AF0A30", VA = "0x186AF1E30")]
		public OCAFLGKEFMJ PNBOAFPCIKF(FaceFeatureType BOCNMNBFMDO)
		{
			return default(OCAFLGKEFMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6AF1F60", Offset = "0x6AF0B60", VA = "0x186AF1F60")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8EA970", Offset = "0x8E9570", VA = "0x1808EA970", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6AF15E0", Offset = "0x6AF01E0", VA = "0x186AF15E0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public BPOIGNIBKFG SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F6D0", VA = "0x180910AD0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8F3410", Offset = "0x8F2010", VA = "0x1808F3410")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public OCAFLGKEFMJ FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x12AB770", Offset = "0x12AA370", VA = "0x1812AB770")]
			get
			{
				return default(OCAFLGKEFMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA22400", Offset = "0xA21000", VA = "0x180A22400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6AE9750", Offset = "0x6AE8350", VA = "0x186AE9750", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8F3410", Offset = "0x8F2010", VA = "0x1808F3410")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x6AF3A10", Offset = "0x6AF2610", VA = "0x186AF3A10")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6055810", Offset = "0x6054410", VA = "0x186055810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x6AF3A50", Offset = "0x6AF2650", VA = "0x186AF3A50")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x6055820", Offset = "0x6054420", VA = "0x186055820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6AF3A30", Offset = "0x6AF2630", VA = "0x186AF3A30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6058970", Offset = "0x6057570", VA = "0x186058970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6AF3A70", Offset = "0x6AF2670", VA = "0x186AF3A70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6058960", Offset = "0x6057560", VA = "0x186058960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3730", Offset = "0x6AF2330", VA = "0x186AF3730", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6AF3940", Offset = "0x6AF2540", VA = "0x186AF3940")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class FEIMABKCHMA
{
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly float GCHPAIACKCP;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public static readonly float PMMHMJKJGFP;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static readonly Vector2 BFHKAIKKGBI;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static readonly Vector2 DAAOPPINGMG;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static readonly Vector2 KFMHKEPGJGP;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static readonly Vector2 KAFBDIKAOHC;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static readonly Vector2 HLMGAGHLLHE;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static readonly Vector2 LPMIGMIGEDF;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static readonly Vector2 JIIIAGPNKEF;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static readonly Vector2 AAOFHMIIMPN;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly Vector2 OFPGLFKNDHJ;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static readonly Vector2 JBJCJLEDJJE;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static readonly Vector2 DKDLLODMJNM;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static readonly Vector2 LKNGJILOHBA;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDAC0", Offset = "0x6AEC6C0", VA = "0x186AEDAC0")]
	public static Vector2 CMHJPGLKFEC(FaceFeatureType EGNKBNHFGKA, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEAD0", Offset = "0x6AED6D0", VA = "0x186AEEAD0")]
	public static float KJPLKNJMODI(FaceFeatureType EGNKBNHFGKA, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE9A0", Offset = "0x6AED5A0", VA = "0x186AEE9A0")]
	public static void JMLADCMDLLI(ACMANOBCHLK APJAKMAJEKA, AvatarConfiguration GFGAGDKNLPB, CAJNNHABANH GJCOEHJLIAD, CAJNNHABANH OLNKABCKMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDF70", Offset = "0x6AECB70", VA = "0x186AEDF70")]
	public static float FIIGNFBIEJH(FaceFeatureType BOCNMNBFMDO, float KLOCMHNDOOE, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF380", Offset = "0x6AEDF80", VA = "0x186AEF380")]
	public static float OPJEMECHAGM(FaceFeatureType BOCNMNBFMDO, float PCECEDCIAJJ, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF410", Offset = "0x6AEE010", VA = "0x186AEF410")]
	public static Vector2 PEGDOKFCICF(FaceFeatureType BOCNMNBFMDO, Vector2 KMGPBBKFCMA, Vector2 GBBAOKLDAHG, Vector2 PHMPDJLEBPN, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6AED630", Offset = "0x6AEC230", VA = "0x186AED630")]
	public static Vector2 BNBPJBCBLGH(FaceFeatureType BOCNMNBFMDO, Vector2 JINJJMHMJDB, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6AED4D0", Offset = "0x6AEC0D0", VA = "0x186AED4D0")]
	private static Vector2 BMFKEGKDALD(FaceFeatureType BOCNMNBFMDO, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE1E0", Offset = "0x6AECDE0", VA = "0x186AEE1E0")]
	private static Vector2 IEIIMMGKGCH(FaceFeatureType BOCNMNBFMDO, Vector2 KMGPBBKFCMA, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE460", Offset = "0x6AED060", VA = "0x186AEE460")]
	public static Vector2 JCFKMGCNHBI(FaceFeatureType BOCNMNBFMDO, Vector2 JINJJMHMJDB, Vector2 GBBAOKLDAHG, Vector2 PHMPDJLEBPN, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6AEECC0", Offset = "0x6AED8C0", VA = "0x186AEECC0")]
	public static float LEHLDONPPLG(FaceFeatureType BOCNMNBFMDO, float PCECEDCIAJJ, CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDE20", Offset = "0x6AECA20", VA = "0x186AEDE20")]
	private static float DIMJBLPMBJN(float FDBDHJDBKGA, float CAIIHNDCIIE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE0C0", Offset = "0x6AECCC0", VA = "0x186AEE0C0")]
	private static Vector2 HCAHMKNFHEB(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDA10", Offset = "0x6AEC610", VA = "0x186AEDA10")]
	private static Vector2 CLMOKFKMHBH(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE3B0", Offset = "0x6AECFB0", VA = "0x186AEE3B0")]
	private static Vector2 IKIGGDBCGKG(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDD70", Offset = "0x6AEC970", VA = "0x186AEDD70")]
	private static Vector2 DCNMMDBHLHJ(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE170", Offset = "0x6AECD70", VA = "0x186AEE170")]
	private static float IAOBCAFEKDH(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF120", Offset = "0x6AEDD20", VA = "0x186AEF120")]
	private static float NOOFPCKHGNE(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF190", Offset = "0x6AEDD90", VA = "0x186AEF190")]
	private static float OAMHMPPIGPH(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEA60", Offset = "0x6AED660", VA = "0x186AEEA60")]
	private static float KJLPKJMKLKI(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6AED890", Offset = "0x6AEC490", VA = "0x186AED890")]
	private static Vector2 BPNHDPEHPHJ(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEFA0", Offset = "0x6AEDBA0", VA = "0x186AEEFA0")]
	private static Vector2 LMAKJHMOELO(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6AED950", Offset = "0x6AEC550", VA = "0x186AED950")]
	private static Vector2 CBFHIGDILIC(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF200", Offset = "0x6AEDE00", VA = "0x186AEF200")]
	private static Vector2 OIMGOLCLMMO(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE000", Offset = "0x6AECC00", VA = "0x186AEE000")]
	private static Vector2 FJMEHJILLOC(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6AED410", Offset = "0x6AEC010", VA = "0x186AED410")]
	private static Vector2 AMPDJKNIIIL(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF2C0", Offset = "0x6AEDEC0", VA = "0x186AEF2C0")]
	private static Vector2 OPDPOJGAEBH(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6AEE8E0", Offset = "0x6AED4E0", VA = "0x186AEE8E0")]
	private static Vector2 JFIDGJEHACD(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6AED350", Offset = "0x6AEBF50", VA = "0x186AED350")]
	private static Vector2 ABDAAHFCCOL(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6AEDEB0", Offset = "0x6AECAB0", VA = "0x186AEDEB0")]
	private static Vector2 FFDIJKABPKA(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6AEEEE0", Offset = "0x6AEDAE0", VA = "0x186AEEEE0")]
	private static Vector2 LJODKKDDONO(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6AEF060", Offset = "0x6AEDC60", VA = "0x186AEF060")]
	private static Vector2 NAIBOFEBOEO(CAJNNHABANH HFBIBPKGGBP, AvatarConfiguration HHLIGGKGFMB)
	{
		return default(Vector2);
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
