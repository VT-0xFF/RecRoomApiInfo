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
using RecRoom.Avatars.Face;
using UnityEngine;
using UnityEngine.AddressableAssets;

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
		[Cpp2IlInjected.Address(RVA = "0x677B440", Offset = "0x6779E40", VA = "0x18677B440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
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
		public AvatarFaceShapeData.GDEJDPFCHLE FaceShapeName;

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
		public AvatarBodyShapeData.KNNKGENOCJD BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AnimationClip BodyShapeAnimationClip;
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		[CompilerGenerated]
		private sealed class JIIPFBDENDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public AvatarFaceShapeBoneData faceShapeData;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public JIIPFBDENDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6780F80", Offset = "0x677F980", VA = "0x186780F80")]
			internal bool IGBLCPKKLGI(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class KEDBHEKHIFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AvatarBodyShapeBoneData bodyShapeData;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public KEDBHEKHIFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6780FE0", Offset = "0x677F9E0", VA = "0x186780FE0")]
			internal bool EOCJENBHDAP(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private const float ANIM_CLIP_EVAL_TIME = 0f;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private List<FaceShapeAnimationInfo> faceShapeAnimationInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private List<BodyShapeAnimationInfo> bodyShapeAnimationInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<(string, AvatarFaceShapeData.GDEJDPFCHLE), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Dictionary<(string, AvatarBodyShapeData.KNNKGENOCJD), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x677B5D0", Offset = "0x6779FD0", VA = "0x18677B5D0")]
		public void CCPNKNOIBEC(IReadOnlyDictionary<string, Transform> KNJFFEADPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x677BE10", Offset = "0x677A810", VA = "0x18677BE10")]
		public void LJOAIDIBABA(IReadOnlyDictionary<string, Transform> KNJFFEADPPI, AvatarFaceShapeData.GDEJDPFCHLE POGPDBLPEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x677C0A0", Offset = "0x677AAA0", VA = "0x18677C0A0")]
		public void OIMOCHEKBPG(IReadOnlyDictionary<string, Transform> KNJFFEADPPI, AvatarBodyShapeData.KNNKGENOCJD HLALPKAKJJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x677BDA0", Offset = "0x677A7A0", VA = "0x18677BDA0")]
		private Vector3 LEBPFFICOHJ(Transform ACGEPKKMOAN, AvatarBodyPartBoneData FJFKPELKEJC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x677BBD0", Offset = "0x677A5D0", VA = "0x18677BBD0")]
		private Quaternion CHALKBNAHKA(Transform ACGEPKKMOAN, AvatarBodyPartBoneData FJFKPELKEJC)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x677BC30", Offset = "0x677A630", VA = "0x18677BC30")]
		private Vector3 CNOAGIMENJB(Transform ACGEPKKMOAN, AvatarBodyPartBoneData FJFKPELKEJC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x677BCA0", Offset = "0x677A6A0", VA = "0x18677BCA0")]
		private void EHGLKDKPKHI(Transform ACGEPKKMOAN, AvatarBodyPartBoneData FJFKPELKEJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x677C330", Offset = "0x677AD30", VA = "0x18677C330")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum KNNKGENOCJD
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			Pear,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			Apple,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			Hourglass,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public KNNKGENOCJD blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Obsolete("Use BodyShapeId instead!")]
		[SerializeField]
		[HideInInspector]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HLNCNEOFKGK BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9CA150", Offset = "0x9C8B50", VA = "0x1809CA150")]
			get
			{
				return default(HLNCNEOFKGK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x677C7B0", Offset = "0x677B1B0", VA = "0x18677C7B0")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AvatarBodyShapeData.KNNKGENOCJD BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x677C530", Offset = "0x677AF30", VA = "0x18677C530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EKFEJFAGNND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Transform[] MLOPGPKLEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<string, Transform> KDGMLJIOMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly Dictionary<Transform, Transform> FDAOBCFKGDP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<string, Transform> FEHOLFIJOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Transform[] FKOEDICHGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x677F160", Offset = "0x677DB60", VA = "0x18677F160")]
	public void HCKJKECHKIK(Transform PHKCLFELCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x677EF20", Offset = "0x677D920", VA = "0x18677EF20")]
	public Transform AONHPLCHBJM(Transform OFGLNKECLKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x677F240", Offset = "0x677DC40", VA = "0x18677F240")]
	public void INAHNAMBKIC(SkinnedMeshRenderer GBABIGPJACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x677F000", Offset = "0x677DA00", VA = "0x18677F000")]
	private static void GEFFBDLIKLG(Transform GPKGNPPAAHE, List<Transform> PIONNIHKKIG, Dictionary<string, Transform> AJGEEPJIGCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x677F480", Offset = "0x677DE80", VA = "0x18677F480")]
	public EKFEJFAGNND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PFICEOBELNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public bool MGCKMHJDLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public bool FPPBGMAOOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public ENFHCMKIOHI? CNHNKJFKLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public BFJEAAGLFCO.DNAKBNCOFJG MMCKMHFJBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public Texture2D DCNHPJBJHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public Texture2D BKONKMMMMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public IList<OBJBFOFBDMJ> FNOLHJDKFMG;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public PFICEOBELNB()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("How far apart you can position your eyebrows.")]
		[Header("Face Features")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public float MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x677C840", Offset = "0x677B240", VA = "0x18677C840")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum INEMDIPNFNK
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum PPDDIBMPJFC
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum EHPBBFOJBKA
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum DKHEMOFFMBB
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum EFBPHIIBPIG
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum IMNGDKEFCMP
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum MCJBJCHOLEJ
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	None
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GCICFJMNIBB
{
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly AONPPFFFNAI AFLAHFPLPCM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static IFEDJPPADLJ LCKCBLHMGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6780A70", Offset = "0x677F470", VA = "0x186780A70")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FMONJEAPHMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Transform PNEJJFMFNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public AssetReference CHKJFFKCGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public GameObject ADOCMEOHMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public GameObject JOKGDCCDGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public SkinnedMeshRenderer KAGGAHIABAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public AvatarSkinnedMeshBoneOrderRemapsData APMKKHOFKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Material CMGIOLIGLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Material ANCFKMGFPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Material MLOEOKAOCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Shader EKEGDCBCAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Shader BMDNGDPCKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public Animator PODDJMPMHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public Renderer[] NNKLAAEKIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public AvatarConfiguration FEOJDAHBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public AvatarBodyPartShapesManager DBJMAGJHBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public IReadOnlyDictionary<string, Transform> BIGAFBOLKID;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GEOMLACBKFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public SkinnedMeshRenderer[] CLPOBNKEOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public SkinnedMeshRenderer[] GFHPNLOCFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public SkinnedMeshRenderer[] NGIBCNEOHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public SkinnedMeshRenderer[] PGKLJNMGIGG;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LKMCODCLMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform FKGCILANHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public Transform FPBKPNHCCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public Transform FGFHMAAGGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Transform FPBICDNJBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Transform GLFBKHLFNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Transform DFLKHMHIBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Transform FINFEAAAEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public AvatarConfiguration FEOJDAHBHKA;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EGBJIADLBKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public SkinnedMeshRenderer[] DNMBEGLCKAB;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct CLNDJONOGLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public OEMMBNJFFOI IOBJMHJECFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int JDFNKMDLMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int LBOJGLEMDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Color ABCKDCCPFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Color PCIJINCGBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int EDGLFBBMPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public int ICENCKBLJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public Color ABNNINNMMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Color ACGOAPODLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public int LEBOALNGAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public float LHENEKONLJG;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HANBPEILFJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public OEMMBNJFFOI IOBJMHJECFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector2 KIOHMKMGCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public float LLHKKCAIGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Vector2 OKPMMMFFEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public float KMPMAMKFCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Vector2 CBNNLNIGCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public float GPKHDKDPFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Vector2 MGNLAIGEMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public float ANFMPFILOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public bool OBKANDJBKKN;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum GDEJDPFCHLE
		{
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public GDEJDPFCHLE blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[Obsolete("Use FaceShapeId instead!")]
		[SerializeField]
		[HideInInspector]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public EDPKFFIMOMC FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9CA150", Offset = "0x9C8B50", VA = "0x1809CA150")]
			get
			{
				return default(EDPKFFIMOMC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x677CD70", Offset = "0x677B770", VA = "0x18677CD70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x677CDD0", Offset = "0x677B7D0", VA = "0x18677CDD0")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public AvatarFaceShapeData.GDEJDPFCHLE FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x677CAF0", Offset = "0x677B4F0", VA = "0x18677CAF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OBJBFOFBDMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public string JGFOABOCNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public OutfitType CBAKGCMAKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public INEMDIPNFNK FMPEAKBHOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public BFJEAAGLFCO.DNAKBNCOFJG AKGLOKIHHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool HPEGDGCIHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public bool MLIEKLPIBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public bool BLEPPBAOOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public Color? LKOFHGABBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public Guid? IFOAHMLBJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public Color? PNJFMKMGMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public bool BNAEACKADPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public bool CAFCGKCBHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Transform MPNHDHAAFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public Vector2? ICCCJFHJCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public FitMeshHemisphere IBBNCAOBMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public AssetReference OFFGOLLNDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public AssetReference BOBFMABIAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public AssetReference[] IJJKNDKEFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public bool JLFDFPLKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public bool FOMIODLPEPE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public string HOJBIINNJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67810C0", Offset = "0x677FAC0", VA = "0x1867810C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x67810C0", Offset = "0x677FAC0", VA = "0x1867810C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6781170", Offset = "0x677FB70", VA = "0x186781170")]
	public OBJBFOFBDMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HMPGADGOOKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public SkinnedMeshRenderer ANNHBOAAFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Material[] FKLOGLLKFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private byte[] IKAFGNEPGNI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Mesh HIDJBLAAMFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6780C40", Offset = "0x677F640", VA = "0x186780C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Material[] OMHCIEIBJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte[] HIEFNJAPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6780DF0", Offset = "0x677F7F0", VA = "0x186780DF0")]
	public HMPGADGOOKG(SkinnedMeshRenderer GEBGAKKKJIM, AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ, [Optional] Material[] HMEELBLBEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6780C60", Offset = "0x677F660", VA = "0x186780C60")]
	public static HMPGADGOOKG PLBFNBKHHCE(Renderer EBCGCCILOJN, AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xBBD6A0", Offset = "0xBBC0A0", VA = "0x180BBD6A0")]
			get
			{
				return default(PositionAndRotation);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CNKHDJDMGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x677ECA0", Offset = "0x677D6A0", VA = "0x18677ECA0")]
	public static PositionAndRotation AJPKNDBDAAD(this PositionAndRotation LAOLCJALHFN)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x677EE80", Offset = "0x677D880", VA = "0x18677EE80")]
	public static float HGJDDLMCBFA(float FOCADABILLC, Vector2 INPPBACOBOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x677EE00", Offset = "0x677D800", VA = "0x18677EE00")]
	public static float HGJDDLMCBFA(float FOCADABILLC, float MJGGCDOBPLJ, float GDMMNJCMFII, float NFEEPMFGNGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x677EB20", Offset = "0x677D520", VA = "0x18677EB20")]
	public static float AJFEFEJEMKG(float DBOBEHLEAAE, Vector2 INPPBACOBOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x677EBF0", Offset = "0x677D5F0", VA = "0x18677EBF0")]
	public static float AJFEFEJEMKG(float DBOBEHLEAAE, float MJGGCDOBPLJ, float GDMMNJCMFII, float NFEEPMFGNGE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class OILNHPPCMLA
{
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public static readonly int HPNHKHNLKHB;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public static readonly string MIPGNHILJFL;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum NJLFBEGMKJC
		{
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private NoseMeshConfiguration[] noseMeshConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private Dictionary<ENFHCMKIOHI, BodySkinnedMeshLODs> DFGNAAPLNHL;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BodySkinnedMeshLODs LINIFNFHELL
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BodySkinnedMeshLODs MOFNFOKHLNI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BodySkinnedMeshLODs AHJIDBAAKHL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BodySkinnedMeshLODs BMEEJELCCHF
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84EC40", Offset = "0x84D640", VA = "0x18084EC40")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x677D0C0", Offset = "0x677BAC0", VA = "0x18677D0C0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x677CE20", Offset = "0x677B820", VA = "0x18677CE20")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(NJLFBEGMKJC FAAJIONIPLO, [Optional] ENFHCMKIOHI? KKMAKFHMKDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x677D1C0", Offset = "0x677BBC0", VA = "0x18677D1C0")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class GJGEGNFDKKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
			public GJGEGNFDKKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6780C10", Offset = "0x677F610", VA = "0x186780C10")]
			internal bool OGBHBEDGDCF(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x677D250", Offset = "0x677BC50", VA = "0x18677D250")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x677D250", Offset = "0x677BC50", VA = "0x18677D250")]
		private void EPBJHENAKAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x677D260", Offset = "0x677BC60", VA = "0x18677D260")]
		private void GFPMMKHMEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x677DE00", Offset = "0x677C800", VA = "0x18677DE00")]
		public byte[] LHHGPONLNON(string GNEDEOHMJKB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x677D3B0", Offset = "0x677BDB0", VA = "0x18677D3B0")]
		public bool JEIDPAMBGAF(SkinnedMeshBoneOrderData JBFCCHMMNJE, AvatarSkinnedMeshBonesController MHGFKFHAHFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x677DEE0", Offset = "0x677C8E0", VA = "0x18677DEE0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ELKKBGCDOPK
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct BOCMDNFNLLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Transform[] FKOEDICHGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Matrix4x4[] ELGGHDOPFFC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static readonly string GDJOPFIGBGM;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x677F9F0", Offset = "0x677E3F0", VA = "0x18677F9F0")]
	public static byte[] MGMHICCOJON(AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ, SkinnedMeshRenderer GBABIGPJACM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x677F550", Offset = "0x677DF50", VA = "0x18677F550")]
	public static BOCMDNFNLLE? HFINEFNPKNP(AvatarSkinnedMeshBoneOrderRemapsData ADEAIGOJDGJ, SkinnedMeshRenderer GBABIGPJACM)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string JNFOLEJPDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x677DFB0", Offset = "0x677C9B0", VA = "0x18677DFB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x677E4B0", Offset = "0x677CEB0", VA = "0x18677E4B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x677E3F0", Offset = "0x677CDF0", VA = "0x18677E3F0")]
		private void GFPMMKHMEDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x677DFE0", Offset = "0x677C9E0", VA = "0x18677DFE0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x677E040", Offset = "0x677CA40", VA = "0x18677E040")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer EBCGCCILOJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public enum DJPLMEDLKIG
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class NGNMNMDGIGH
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public static readonly NGNMNMDGIGH LDMJBAPJLGF;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LJJEDCILILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84C1A0", Offset = "0x84ABA0", VA = "0x18084C1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x856690", Offset = "0x855090", VA = "0x180856690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DJPLMEDLKIG IHBKOIIBAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8C0BE0", Offset = "0x8BF5E0", VA = "0x1808C0BE0")]
		[CompilerGenerated]
		get
		{
			return default(DJPLMEDLKIG);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xBBD300", Offset = "0xBBBD00", VA = "0x180BBD300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public NGNMNMDGIGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x25706B0", Offset = "0x256F0B0", VA = "0x1825706B0")]
	public NGNMNMDGIGH(DJPLMEDLKIG MBMNLIPEPEP, int LPOCCKBAAAH)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct NoseMeshConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NoseFaceOption NoseOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public BodySkinnedMeshLODs Meshes;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6782310", Offset = "0x6780D10", VA = "0x186782310")]
		public void LEMPLHFNICM(SkinnedMeshRenderer GBABIGPJACM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x67824C0", Offset = "0x6780EC0", VA = "0x1867824C0")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8C5180", Offset = "0x8C3B80", VA = "0x1808C5180", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x677EB10", Offset = "0x677D510", VA = "0x18677EB10")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x84CBB0", Offset = "0x84B5B0", VA = "0x18084CBB0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x677FF60", Offset = "0x677E960", VA = "0x18677FF60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x660D530", Offset = "0x660BF30", VA = "0x18660D530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x677FF80", Offset = "0x677E980", VA = "0x18677FF80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x677FFC0", Offset = "0x677E9C0", VA = "0x18677FFC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xB69FF0", Offset = "0xB689F0", VA = "0x180B69FF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x19B19B0", Offset = "0x19B03B0", VA = "0x1819B19B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x677FFA0", Offset = "0x677E9A0", VA = "0x18677FFA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x677FFD0", Offset = "0x677E9D0", VA = "0x18677FFD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x677FB50", Offset = "0x677E550", VA = "0x18677FB50", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x677FE50", Offset = "0x677E850", VA = "0x18677FE50")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6780A50", Offset = "0x677F450", VA = "0x186780A50")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1089060", Offset = "0x1087A60", VA = "0x181089060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xC77270", Offset = "0xC75C70", VA = "0x180C77270")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1089050", Offset = "0x1087A50", VA = "0x181089050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6780810", Offset = "0x677F210", VA = "0x186780810", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6780950", Offset = "0x677F350", VA = "0x186780950")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x67828B0", Offset = "0x67812B0", VA = "0x1867828B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x6783540", Offset = "0x6781F40", VA = "0x186783540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly List<AMHDMMJJKND<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x84FE40", Offset = "0x84E840", VA = "0x18084FE40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x84FCB0", Offset = "0x84E6B0", VA = "0x18084FCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6780760", Offset = "0x677F160", VA = "0x186780760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x67807D0", Offset = "0x677F1D0", VA = "0x1867807D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6780710", Offset = "0x677F110", VA = "0x186780710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x535D050", Offset = "0x535BA50", VA = "0x18535D050")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x535D250", Offset = "0x535BC50", VA = "0x18535D250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x67801F0", Offset = "0x677EBF0", VA = "0x1867801F0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6780330", Offset = "0x677ED30", VA = "0x186780330", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6780260", Offset = "0x677EC60", VA = "0x186780260")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6780410", Offset = "0x677EE10", VA = "0x186780410")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x677FFE0", Offset = "0x677E9E0", VA = "0x18677FFE0")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6780510", Offset = "0x677EF10", VA = "0x186780510")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class OEMMBNJFFOI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct BBGODGJAKAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder<OEMMBNJFFOI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private EIFADGOBFBO.AIIKFCMMCOB <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x677E4C0", Offset = "0x677CEC0", VA = "0x18677E4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x677EAA0", Offset = "0x677D4A0", VA = "0x18677EAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly Dictionary<string, int> PAKALCDLKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private bool AONLPLHOPCD;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Texture2DArray HFMGLLIHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public SymmetricalFaceFeature MJCPAODHLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x850E40", Offset = "0x84F840", VA = "0x180850E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public EyesFaceFeature GKPBLELNBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x850E30", Offset = "0x84F830", VA = "0x180850E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public FaceFeature MCCCFIOMEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x850E60", Offset = "0x84F860", VA = "0x180850E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6781180", Offset = "0x677FB80", VA = "0x186781180")]
	private static void DLFCMMONPFG(Sprite LDGNGNBIKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6781220", Offset = "0x677FC20", VA = "0x186781220")]
	public static OEMMBNJFFOI EKFDAGCMDNE(SymmetricalFaceFeature DDCBGMOBJPI, EyesFaceFeature EKNBNOJMNHL, FaceFeature NCLMKKPFNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6781D70", Offset = "0x6780770", VA = "0x186781D70")]
	[AsyncStateMachine(typeof(BBGODGJAKAF))]
	public static Task<OEMMBNJFFOI> KCCEFIMPDDA(SymmetricalFaceFeature DDCBGMOBJPI, EyesFaceFeature EKNBNOJMNHL, FaceFeature NCLMKKPFNIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6781EB0", Offset = "0x67808B0", VA = "0x186781EB0")]
	private OEMMBNJFFOI(SymmetricalFaceFeature DDCBGMOBJPI, EyesFaceFeature EKNBNOJMNHL, FaceFeature NCLMKKPFNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6781520", Offset = "0x677FF20", VA = "0x186781520")]
	private void JNIFGICGNKL(List<Sprite> KCLLDPAPOAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6781330", Offset = "0x677FD30", VA = "0x186781330")]
	public bool HKMOAGLFFBJ(string OHJLBKADDED, [Out] int ILOCEPPJPDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67811F0", Offset = "0x677FBF0", VA = "0x1867811F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6781C80", Offset = "0x6780680", VA = "0x186781C80")]
	public bool JPOGMMCJBGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67812B0", Offset = "0x677FCB0", VA = "0x1867812B0")]
	public void GHBPDEJJLFK()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8B8450", Offset = "0x8B6E50", VA = "0x1808B8450", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6780950", Offset = "0x677F350", VA = "0x186780950")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public MCJBJCHOLEJ SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x8BF4A0", Offset = "0x8BDEA0", VA = "0x1808BF4A0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBC0", Offset = "0x8BA5C0", VA = "0x1808BBBC0")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public ENFHCMKIOHI FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x9CA150", Offset = "0x9C8B50", VA = "0x1809CA150")]
			get
			{
				return default(ENFHCMKIOHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x9D3DE0", Offset = "0x9D27E0", VA = "0x1809D3DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x677CD70", Offset = "0x677B770", VA = "0x18677CD70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8BBBC0", Offset = "0x8BA5C0", VA = "0x1808BBBC0")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x6782830", Offset = "0x6781230", VA = "0x186782830")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xE6D1F0", Offset = "0xE6BBF0", VA = "0x180E6D1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6782870", Offset = "0x6781270", VA = "0x186782870")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5D46660", Offset = "0x5D45060", VA = "0x185D46660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6782850", Offset = "0x6781250", VA = "0x186782850")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5D49930", Offset = "0x5D48330", VA = "0x185D49930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x6782890", Offset = "0x6781290", VA = "0x186782890")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5D49920", Offset = "0x5D48320", VA = "0x185D49920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6782550", Offset = "0x6780F50", VA = "0x186782550", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6782760", Offset = "0x6781160", VA = "0x186782760")]
		protected SymmetricalFaceFeature()
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
