using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.AssetIds;
using RecRoom.Attributes;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Avatars.Face;
using RecRoom.DataLayer;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;
using RecRoom.Protobuf.Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x83AA770", Offset = "0x83A9570", VA = "0x1883AA770")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_SharedInternal
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83AA290", Offset = "0x83A9090", VA = "0x1883AA290", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AvatarBodyPartBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float SampleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public bool HasLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool HasLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public bool HasLocalScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Quaternion LocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public Vector3 LocalScale;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8398C00", Offset = "0x8397A00", VA = "0x188398C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AvatarBodyPartBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct FaceShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AvatarFaceShapeData.BlendShapeName FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AnimationClip FaceShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BodyShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AvatarBodyShapeData.BlendShapeName BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AnimationClip BodyShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct BodyPropertyAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public BodyProperty BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AnimationClip BodyPropertyAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct FacePropertyAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public FaceProperty FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AnimationClip FacePropertyAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NosePropertyAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NoseProperty NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AnimationClip NosePropertyAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct HeadShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AnimationClip HeadShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NoseShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NoseType NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AnimationClip NoseTypeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BodyPropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public BodyProperty BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct FacePropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public FaceProperty FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct NosePropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NoseProperty NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[FormerlySerializedAs("BodyPropertyInfluences")]
		public PropertyInfluences PropertyInfluences;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[Flags]
	public enum PropertyInfluences
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		NONE = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		X_POSITION = 2,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Y_POSITION = 4,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Z_POSITION = 8,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		X_ROTATION = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Y_ROTATION = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Z_ROTATION = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		X_SCALE = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Y_SCALE = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Z_SCALE = 0x200
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class FNNOYKPROUT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public AvatarNoseTypeBoneData WTFRIDDOPGU;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public FNNOYKPROUT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83A53D0", Offset = "0x83A41D0", VA = "0x1883A53D0")]
			internal bool QRZIACRQKSM(KeyValuePair<string, Transform> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string LOCAL_ROTATION_X_PROPERTY_NAME = "m_LocalRotation.x";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string LOCAL_ROTATION_Y_PROPERTY_NAME = "m_LocalRotation.y";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string LOCAL_ROTATION_Z_PROPERTY_NAME = "m_LocalRotation.z";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string LOCAL_ROTATION_W_PROPERTY_NAME = "m_LocalRotation.w";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const string BASE_NOSE_TWEAK_BONE_NAME = "Jnt.Head.Nose.Tweak";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private List<BodyPropertyBoneInfluenceInfo> bodyPropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private List<FacePropertyBoneInfluenceInfo> facePropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private List<NosePropertyBoneInfluenceInfo> nosePropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private List<AvatarHeadShapeBoneData> headShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private List<AvatarBodyPropertyBoneData> bodyPropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private List<AvatarFacePropertyBoneData> facePropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private List<AvatarNoseTypeBoneData> noseTypeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private List<AvatarNosePropertyBoneData> nosePropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private List<AvatarFaceShapeData.BlendShapeName> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<AvatarBodyShapeData.BlendShapeName> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Dictionary<BodyProperty, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private Dictionary<FaceProperty, List<float>> facePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Dictionary<NoseProperty, List<float>> nosePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(string, AvatarFaceShapeData.BlendShapeName), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<(string, AvatarBodyShapeData.BlendShapeName), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<(string, NoseType), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<(string, BodyProperty, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Dictionary<BodyProperty, Dictionary<string, PropertyInfluences>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Dictionary<(string, FaceProperty, float), AvatarBodyPartBoneData> facePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Dictionary<FaceProperty, Dictionary<string, PropertyInfluences>> facePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly Dictionary<(string, NoseProperty, float), AvatarBodyPartBoneData> nosePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly Dictionary<NoseProperty, Dictionary<string, PropertyInfluences>> nosePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly List<string> headBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly List<string> noseBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Dictionary<BodyProperty, string[]> bonesToUpdatePerBodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Dictionary<FaceProperty, string[]> bonesToUpdatePerFaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly Dictionary<NoseProperty, string[]> bonesToUpdatePerNoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<string, Dictionary<PropertyInfluences, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JUHXHEXIQPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x839FB40", Offset = "0x839E940", VA = "0x18839FB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x839AE60", Offset = "0x8399C60", VA = "0x18839AE60")]
		public void Initialize(IReadOnlyDictionary<string, Transform> boneNameMapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8399080", Offset = "0x8397E80", VA = "0x188399080")]
		public void ApplyTransformsForFaceShape(IReadOnlyDictionary<string, Transform> boneNameMapping, AvatarFaceShapeData.BlendShapeName faceShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8399380", Offset = "0x8398180", VA = "0x188399380")]
		public void ApplyTransformsForNoseType(IReadOnlyDictionary<string, Transform> boneNameMapping, NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8398D80", Offset = "0x8397B80", VA = "0x188398D80")]
		public void ApplyTransformsForBodyShape(IReadOnlyDictionary<string, Transform> boneNameMapping, AvatarBodyShapeData.BlendShapeName bodyShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83997A0", Offset = "0x83985A0", VA = "0x1883997A0")]
		public void ApplyTransformsForPropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<string, BoneLocalInfo> bodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x839A900", Offset = "0x8399700", VA = "0x18839A900")]
		public IReadOnlyDictionary<string, BoneLocalInfo> GetInitialInfoForAllBones(IReadOnlyDictionary<string, Transform> boneNameMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x839A640", Offset = "0x8399440", VA = "0x18839A640")]
		public Dictionary<string, BoneLocalInfo> GetCurrentBodyPropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<BodyProperty, float> bodyPropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x839A6E0", Offset = "0x83994E0", VA = "0x18839A6E0")]
		public Dictionary<string, BoneLocalInfo> GetCurrentFacePropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<FaceProperty, float> facePropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x839A780", Offset = "0x8399580", VA = "0x18839A780")]
		public Dictionary<string, BoneLocalInfo> GetCurrentNosePropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<NoseProperty, float> nosePropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3440550", Offset = "0x343F350", VA = "0x183440550")]
		private Dictionary<string, BoneLocalInfo> HQLUFBICGYZ<a>(IReadOnlyDictionary<string, Transform> a, IReadOnlyDictionary<a, float> b, IReadOnlyDictionary<string, BoneLocalInfo> c, Dictionary<a, Dictionary<string, PropertyInfluences>> d, Dictionary<(string, a, float), AvatarBodyPartBoneData> e, bool f, bool g, [Optional] float? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x839A240", Offset = "0x8399040", VA = "0x18839A240")]
		public static (float, float) ComputeNoseTweakAlongCurvedSurface(float nosePositionOffset)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x839A500", Offset = "0x8399300", VA = "0x18839A500")]
		public float GetClosestBodyProperty(BodyProperty bodyProperty, float bodyPropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x839A560", Offset = "0x8399360", VA = "0x18839A560")]
		public float GetClosestFaceProperty(FaceProperty faceProperty, float facePropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x839A5D0", Offset = "0x83993D0", VA = "0x18839A5D0")]
		public float GetClosestNoseProperty(NoseProperty noseProperty, float nosePropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x34410F0", Offset = "0x343FEF0", VA = "0x1834410F0")]
		private float TMHTMSAZSDA<b>(b a, float b, Dictionary<b, List<float>> c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x839ACE0", Offset = "0x8399AE0", VA = "0x18839ACE0")]
		private BoneLocalInfo INCHWXTYDYK(IReadOnlyDictionary<string, Transform> a, string b)
		{
			return default(BoneLocalInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x839CEF0", Offset = "0x839BCF0", VA = "0x18839CEF0")]
		private float RHACPNWWCZG(float a, List<float> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x839D060", Offset = "0x839BE60", VA = "0x18839D060")]
		private Vector3 USZXUWFBRTM(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x839A2D0", Offset = "0x83990D0", VA = "0x18839A2D0")]
		private Quaternion EUYMBFLCMZZ(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x839CFF0", Offset = "0x839BDF0", VA = "0x18839CFF0")]
		private Vector3 SGVNNVATVYJ(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x839D0D0", Offset = "0x839BED0", VA = "0x18839D0D0")]
		private void YHLVNEONOTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75680C0", Offset = "0x7566EC0", VA = "0x1875680C0")]
		public bool PropertyInfluenceContains(PropertyInfluences allInfluences, PropertyInfluences influenceToCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x839E160", Offset = "0x839CF60", VA = "0x18839E160")]
		private BoneLocalInfo YWUMYBGZVSS(PropertyInfluences a, BoneLocalInfo b, AvatarBodyPartBoneData c)
		{
			return default(BoneLocalInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8399BB0", Offset = "0x83989B0", VA = "0x188399BB0")]
		public Dictionary<string, BoneLocalInfo> AverageBoneInfluencesPerProperty(Dictionary<string, BoneLocalInfo> boneLocalInfo, bool averageRotationInfluences)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x839A330", Offset = "0x8399130", VA = "0x18839A330")]
		private void FAXFTJNHZNM(Transform a, AvatarBodyPartBoneData b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x839F2A0", Offset = "0x839E0A0", VA = "0x18839F2A0")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class AvatarBodyPropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public BodyProperty BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public float BodyPropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x839FC40", Offset = "0x839EA40", VA = "0x18839FC40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[HideInInspector]
		[SerializeField]
		[Obsolete("Use BodyShapeId instead!")]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private AvatarBodyShapeData.BlendShapeName blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BodyShapeId BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1658630", Offset = "0x1657430", VA = "0x181658630")]
			get
			{
				return default(BodyShapeId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.BlendShapeName BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAE5670", Offset = "0xAE4470", VA = "0x180AE5670")]
			get
			{
				return default(AvatarBodyShapeData.BlendShapeName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83A0470", Offset = "0x839F270", VA = "0x1883A0470")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AvatarBodyShapeData.BlendShapeName BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x839FE00", Offset = "0x839EC00", VA = "0x18839FE00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly Dictionary<BodyShapeId, AvatarBodyShape> GMOMIUOZUVT;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x839FF60", Offset = "0x839ED60", VA = "0x18839FF60")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x83A0280", Offset = "0x839F080", VA = "0x1883A0280")]
		public AvatarBodyShape Find(BodyShapeId bodyShapeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83A0390", Offset = "0x839F190", VA = "0x1883A0390")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83A0350", Offset = "0x839F150", VA = "0x1883A0350")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83A03D0", Offset = "0x839F1D0", VA = "0x1883A03D0")]
		public AvatarBodyShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class XESQFQRBWDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Transform[] TPVILJMTZWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly Dictionary<string, Transform> AYDIOUYRJLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly Dictionary<Transform, Transform> SOLHUCMXCOW;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyDictionary<string, Transform> JCUVWUKJJSB
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Transform[] RDKEWLOPSJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83AF220", Offset = "0x83AE020", VA = "0x1883AF220")]
		public void LGVXCUHKLPX(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83AF300", Offset = "0x83AE100", VA = "0x1883AF300")]
		public Transform OOCEELENJDH(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83AF590", Offset = "0x83AE390", VA = "0x1883AF590")]
		public void PTVIJETYEJA(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83AF3E0", Offset = "0x83AE1E0", VA = "0x1883AF3E0")]
		private static void PDGJZMZSBOI(Transform a, List<Transform> b, Dictionary<string, Transform> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83AF7D0", Offset = "0x83AE5D0", VA = "0x1883AF7D0")]
		public XESQFQRBWDN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class HPLESDVSUWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool CBREAZALXBY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool PVDQMILGLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public bool RAUCUKFYLFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public bool WXBMWQIHVWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public bool YHSTRQPEQJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FaceFeatureId? ANCYIWEGQHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public IHHTCSCNBJC.SkinCullingMask YJWNAMRNNTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public RecRoom.Avatars.Data.Shared.HairData NCGSRBWFURK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AdditionalHatData NRMSKZSVZDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool UPEKLCXDGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool QLMDTTXGWQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool UKHYIZAPVQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool UZMDZFIZDTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool KVPTGXKONIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IList<UZPACWXLDPR> DZPDANRVITF;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HPLESDVSUWB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Min/Max rotation angle for your eyebrows.")]
		public Vector2 EyebrowsRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Min/Max aspect for your eyebrows.")]
		public Vector2 EyebrowAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Min/Max rotation angle for your eyes.")]
		public Vector2 EyeRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Min/Max aspect for your eyes.")]
		public Vector2 EyeAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Min/Max rotation angle for your mouth.")]
		public Vector2 MouthRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Min/Max aspect for your mouth.")]
		public Vector2 MouthAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Min/Max rotation angle for your nose.")]
		public Vector2 NoseRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Min/Max aspect for your nose.")]
		public Vector2 NoseAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Tooltip("Min uv for eyes")]
		public Vector2 EyeLimitsMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Tooltip("Max uv for eyes")]
		public Vector2 EyeLimitsMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[Header("Body Shapes")]
		public BodyShapeConfiguration BodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[Header("Face Shapes")]
		public FaceShapeConfiguration FaceShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[Header("Nose Shapes")]
		public NoseShapeConfiguration NoseShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[Header("Data Migration Managers")]
		public AvatarDataRangeMigrationsManager AvatarDataRangeMigrationsManager;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83A0500", Offset = "0x839F300", VA = "0x1883A0500")]
		protected AvatarConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum RangeDataType
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		NoseScale_FullBody,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		NoseScale_ModernBean,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		NoseVerticalPosition_FullBody,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		NoseVerticalPosition_ModernBean,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		HeadScale_FullBody,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		HeadScale_ModernBean
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct RangeMigration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public RangeDataType RangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public Vector2 Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public AvatarVersion Version;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class AvatarDataRangeMigrationsManager : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public List<RangeMigration> RangeMigrations;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public List<RangeMigration> TVHSVZXNCHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xB611A0", Offset = "0xB5FFA0", VA = "0x180B611A0")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class WZQUZWVETOS
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static WXLBPARAGPJ TBZCWZPYSWW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x83AF1C0", Offset = "0x83ADFC0", VA = "0x1883AF1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static QDHMFCEYZOH UEAVSKHPDHY
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83AF0A0", Offset = "0x83ADEA0", VA = "0x1883AF0A0")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct AvatarDisplayInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Transform DeformRigRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public AvatarSkinAssetItem PotatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AssetReference SkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AssetReference TorsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AssetReference LegsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AssetReference TorsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public GameObject AllBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public GameObject FirstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public GameObject ThirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Material[] BodyMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Texture2D BodyEmissiveMapTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public Animator MainAvatarAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Renderer[] WatchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AvatarBodyPartShapesManager AvatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public IReadOnlyDictionary<string, Transform> BoneNameMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public AvatarBodyType AvatarBodyType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public struct AvatarDisplaySetupState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public SkinnedMeshRenderer[] CurrentThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public SkinnedMeshRenderer[] NextThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public SkinnedMeshRenderer[] CurrentFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public SkinnedMeshRenderer[] NextFirstPersonSkinnedMeshRenderers;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct AvatarFaceDisplayInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AvatarBodyType AvatarBodyType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct AvatarFaceDisplayUpdateRenderersState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public SkinnedMeshRenderer[] FaceRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public Material FaceSharedMaterial;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct AvatarFaceDisplayUpdateFeatureSelectionState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public TNHDFQBJNXY ActiveFaceStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int LeftEyeSpriteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Color LeftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Color LeftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int RightEyeSpriteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public Color RightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Color RightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int MouthSpriteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public float MouthRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct AvatarFaceDisplayUpdateFeaturePositionsState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNHDFQBJNXY ActiveFaceStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Vector2 EyeBrowPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public float EyeBrowScaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public float EyeBrowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float EyeBrowAspect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Vector2 EyePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float EyeScaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float EyeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public float EyeAspect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Vector2 NosePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float NoseScaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public float NoseRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float NoseAspect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Vector2 MouthPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public float MouthScaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public float MouthRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float MouthAspect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public bool ApplyJitterToBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public bool NoseIsEnabled;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public FaceProperty FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public float FacePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83A0B70", Offset = "0x839F970", VA = "0x1883A0B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[HideInInspector]
		[SerializeField]
		[Obsolete("Use FaceShapeId instead!")]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private AvatarFaceShapeData.BlendShapeName blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FaceShapeId FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1658630", Offset = "0x1657430", VA = "0x181658630")]
			get
			{
				return default(FaceShapeId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.BlendShapeName BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAE5670", Offset = "0xAE4470", VA = "0x180AE5670")]
			get
			{
				return default(AvatarFaceShapeData.BlendShapeName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83A13A0", Offset = "0x83A01A0", VA = "0x1883A13A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83A1400", Offset = "0x83A0200", VA = "0x1883A1400")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public AvatarFaceShapeData.BlendShapeName FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83A0D30", Offset = "0x839FB30", VA = "0x1883A0D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly Dictionary<FaceShapeId, AvatarFaceShape> GMOMIUOZUVT;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83A0E90", Offset = "0x839FC90", VA = "0x1883A0E90")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83A11B0", Offset = "0x839FFB0", VA = "0x1883A11B0")]
		public AvatarFaceShape Find(FaceShapeId faceShapeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83A12C0", Offset = "0x83A00C0", VA = "0x1883A12C0")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x83A1280", Offset = "0x83A0080", VA = "0x1883A1280")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83A1300", Offset = "0x83A0100", VA = "0x1883A1300")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83A1A60", Offset = "0x83A0860", VA = "0x1883A1A60")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private struct <GetTextureAsync>d__11 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public AvatarHairPattern <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public HairPatternStyle style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private (Texture2D texture, XNDFGATNVRQ<Texture2D> handle) <inProgress>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private XNDFGATNVRQ<Texture2D> <resourceHandle>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x83AC180", Offset = "0x83AAF80", VA = "0x1883AC180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x83ACA80", Offset = "0x83AB880", VA = "0x1883ACA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private List<AssetReference> textureReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Dictionary<HairPatternStyle, (Texture2D texture, XNDFGATNVRQ<Texture2D> handle)> loadedTextures;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HairPatternId HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1658630", Offset = "0x1657430", VA = "0x181658630")]
			get
			{
				return default(HairPatternId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB6CC70", Offset = "0xB6BA70", VA = "0x180B6CC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xBA5D10", Offset = "0xBA4B10", VA = "0x180BA5D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x83A1C20", Offset = "0x83A0A20", VA = "0x1883A1C20")]
		[AsyncStateMachine(typeof(<GetTextureAsync>d__11))]
		public Task<Texture2D> GetTextureAsync(HairPatternStyle style)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83A1D40", Offset = "0x83A0B40", VA = "0x1883A1D40")]
		public Texture2D GetTexture(HairPatternStyle style)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x83A2240", Offset = "0x83A1040", VA = "0x1883A2240")]
		public void UnloadTexture(HairPatternStyle style)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83A20D0", Offset = "0x83A0ED0", VA = "0x1883A20D0")]
		public void UnloadAllTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83A1B10", Offset = "0x83A0910", VA = "0x1883A1B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83A1A70", Offset = "0x83A0870", VA = "0x1883A1A70", Slot = "4")]
		public bool Equals(AvatarHairPattern other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x83A2090", Offset = "0x83A0E90", VA = "0x1883A2090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x83A1C10", Offset = "0x83A0A10", VA = "0x1883A1C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83A2540", Offset = "0x83A1340", VA = "0x1883A2540")]
		public static bool operator !=(AvatarHairPattern lhs, AvatarHairPattern rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x83A2490", Offset = "0x83A1290", VA = "0x1883A2490")]
		public static bool operator ==(AvatarHairPattern lhs, AvatarHairPattern rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83A2360", Offset = "0x83A1160", VA = "0x1883A2360")]
		public AvatarHairPattern()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public enum HandVisualState
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Invisible,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Pointing,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		ClosedFist,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		TPose,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		ThumbUp,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		HandShake,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Grabbing,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Flat,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		NumStates
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[Flags]
	public enum HandAnimationOverrideState
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		ThumbUp = 1,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Pointing = 2,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		HandShake = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AvatarHandDisplayInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public Animator AvatarAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public HandType HandSidedness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public GameObject WatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public AvatarBodyType AvatarBodyType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct AvatarHandDisplaySetupState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Transform HandIKEffectorTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public bool IsPlayerUsingScreen;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x83A2570", Offset = "0x83A1370", VA = "0x1883A2570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct ItemDefinitionBodyPart
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool isRoomieBodypart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private AvatarBodyPart avatarBodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private RoomieBodyPart roomieBodyPart;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly ItemDefinitionBodyPart RoomieSkinPlaceholder;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public readonly bool EHNZVAMKHMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x83AA120", Offset = "0x83A8F20", VA = "0x1883AA120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x52F5E90", Offset = "0x52F4C90", VA = "0x1852F5E90")]
		public readonly bool KCRTJUNWXAE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2E7C400", Offset = "0x2E7B200", VA = "0x182E7C400")]
		public readonly RoomieBodyPart CVZYAILFBXC()
		{
			return default(RoomieBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xF00BB0", Offset = "0xEFF9B0", VA = "0x180F00BB0")]
		public readonly AvatarBodyPart RVEXNTKVNAA()
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83AA180", Offset = "0x83A8F80", VA = "0x1883AA180")]
		public static ItemDefinitionBodyPart THHFWFPOMTC(RoomieBodyPart a)
		{
			return default(ItemDefinitionBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83AA100", Offset = "0x83A8F00", VA = "0x1883AA100")]
		public static ItemDefinitionBodyPart AEIOGISFRHW(AvatarBodyPart a)
		{
			return default(ItemDefinitionBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83AA1A0", Offset = "0x83A8FA0", VA = "0x1883AA1A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class UZPACWXLDPR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string CANLOGIQDOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public OutfitType IUGSLNNBIRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public ItemDefinitionBodyPart TROHPLHOTBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AssetReference WLIMDOLYHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AssetReference NKBYSMHXORS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AssetReference[] QCNQSBMDTFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public IHHTCSCNBJC.SkinCullingMask ITTBNGICFJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public bool LESESAHXIOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public bool IKEFEVINFRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public bool ZDTNBWLJSKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Color? MGBLNSKSARK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public bool JPSLYIVQJDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public Color? UCTEAFGADMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public bool HPGXXPWSNMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public bool XUNYUWFXPCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool EIUHNAAWAGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public Transform LMNGHYSDEMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Vector2? XWBEPELLQAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public FitMeshHemisphere GBKIVCMJNKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public UZPACWXLDPR IFMNWUPKGTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public bool VRDOWJCNJGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool STMUYMGLEKP;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string FKHZXZJRGUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x83AE840", Offset = "0x83AD640", VA = "0x1883AE840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83AE840", Offset = "0x83AD640", VA = "0x1883AE840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83AE8F0", Offset = "0x83AD6F0", VA = "0x1883AE8F0")]
		public UZPACWXLDPR()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private MaterialCombinationId? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CombinationId CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x83A2B00", Offset = "0x83A1900", VA = "0x1883A2B00")]
			get
			{
				return default(CombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public MaterialCombinationId MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x83A2B30", Offset = "0x83A1930", VA = "0x1883A2B30")]
			get
			{
				return default(MaterialCombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAC63E0", Offset = "0xAC51E0", VA = "0x180AC63E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAC6400", Offset = "0xAC5200", VA = "0x180AC6400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83A29A0", Offset = "0x83A17A0", VA = "0x1883A29A0")]
		public Material[] GetAllMaterials()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83A2600", Offset = "0x83A1400", VA = "0x1883A2600")]
		public static void Apply(AvatarItemMaterial itemMaterial, Material material, int materialIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83A27F0", Offset = "0x83A15F0", VA = "0x1883A27F0")]
		private static bool EFCFRQFUBIA(AvatarItemMaterial a, int b, [Out] Material c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83A2A80", Offset = "0x83A1880", VA = "0x1883A2A80")]
		public AvatarItemMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class PMIFSVBBHZO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public SkinnedMeshRenderer QFPLOJUBELU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private Material[] CBMNFHLEMDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private IReadOnlyList<byte> GOERSWPHSZA;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Mesh KDGSWIXENOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x83AA7F0", Offset = "0x83A95F0", VA = "0x1883AA7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Material[] JXYSVOXELHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyList<byte> LWHXAQDGSDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83AA9B0", Offset = "0x83A97B0", VA = "0x1883AA9B0")]
		public PMIFSVBBHZO(SkinnedMeshRenderer a, AvatarSkinnedMeshBoneOrderRemapsData b, Material[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83AA810", Offset = "0x83A9610", VA = "0x1883AA810")]
		public static PMIFSVBBHZO XVIEKHWTVQD(Renderer a, AvatarSkinnedMeshBoneOrderRemapsData b, Material[] c)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static PositionAndRotation CJGYMEELLGF
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1548FF0", Offset = "0x1547DF0", VA = "0x181548FF0")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xBA15B0", Offset = "0xBA03B0", VA = "0x180BA15B0")]
		public void Set(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public static class NXSWAQEMFUI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83AA4B0", Offset = "0x83A92B0", VA = "0x1883AA4B0")]
		public static PositionAndRotation FIPDTETJIPL(this PositionAndRotation a)
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83AA410", Offset = "0x83A9210", VA = "0x1883AA410")]
		public static float BUIGMKMHLZR(float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83AA390", Offset = "0x83A9190", VA = "0x1883AA390")]
		public static float BUIGMKMHLZR(float a, float b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83AA6B0", Offset = "0x83A94B0", VA = "0x1883AA6B0")]
		public static float MGRFBKOBYAD(float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83AA600", Offset = "0x83A9400", VA = "0x1883AA600")]
		public static float MGRFBKOBYAD(float a, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class AvatarNosePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public NoseProperty NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public float NosePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x83A2BF0", Offset = "0x83A19F0", VA = "0x1883A2BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AvatarNosePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public NoseType NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x83A2DB0", Offset = "0x83A1BB0", VA = "0x1883A2DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public enum HandGestureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Highfive = 1,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Fistbump = 2,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Handshake = 3,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		GiveTake = 4,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		OpenHand = 100,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Point = 101,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		ThumbsUp = 102,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		ThumbsDown = 103,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		ClosedFist = 104,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		OBSOLETE_CannedWave = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum AnimationPoseType
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		IdleSwayAimWeapon,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		IdleSwayMeleeWeapon,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		IdleSwayLightItem,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		IdleSwayHeavyItem,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		IdleSwayAimOneHandedWeapon,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		FastAction,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		NumTypes
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum AvatarBuildType
	{
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Inactive,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		PotatoAvatar,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		FullOutfitAvatar
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public PositionAndRotation FingerMidOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public HandLogicOffsets()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct FaceFeaturesInUVSpace
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Vector2 leftEyeBrowPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public Vector2 leftEyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public Vector2 leftEyePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Vector2 leftEyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Vector2 leftEyeGleamPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Vector2 leftEyeGleamScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Vector2 rightEyeBrowPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Vector2 rightEyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Vector2 rightEyePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Vector2 rightEyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Vector2 rightEyeGleamPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector2 rightEyeGleamScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Vector2 noseTweakPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Vector2 noseTweakScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Vector2 mouthPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Vector2 mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public float eyeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public float eyebrowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public float noseRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public float mouthRotation;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public PositionAndRotation MouthColliderOffset;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class WOIQCLXLDPU
	{
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public static readonly int MZIQCIPLMLJ;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly string RMPHEWNXMEL;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x83AEB90", Offset = "0x83AD990", VA = "0x1883AEB90")]
		public static AvatarDisplayInitState RHGNJNMYRWO(Transform a, AvatarSkinAssetItem b, AssetReference c, AssetReference d, AssetReference e, AssetReference f, GameObject g, GameObject h, GameObject i, SkinnedMeshRenderer j, AvatarSkinnedMeshBoneOrderRemapsData k, Material l, Material m, Material n, Texture2D o, Material p, Material q, Shader r, Shader s, Animator t, Renderer[] u, AvatarConfiguration v, AvatarBodyPartShapesManager w, IReadOnlyDictionary<string, Transform> x, Transform y, AvatarBodyType z)
		{
			return default(AvatarDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83AEEA0", Offset = "0x83ADCA0", VA = "0x1883AEEA0")]
		public static AvatarDisplaySetupState TUIWQIZXKIZ(SkinnedMeshRenderer[] a, SkinnedMeshRenderer[] b, SkinnedMeshRenderer[] c, SkinnedMeshRenderer[] d)
		{
			return default(AvatarDisplaySetupState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83AEF60", Offset = "0x83ADD60", VA = "0x1883AEF60")]
		public static AvatarFaceDisplayInitState XPRQAHQZEQE(Transform a, Transform b, Transform c, Transform d, Transform e, Transform f, AvatarConfiguration g, AvatarBodyType h)
		{
			return default(AvatarFaceDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x28CB4B0", Offset = "0x28CA2B0", VA = "0x1828CB4B0")]
		public static AvatarFaceDisplayUpdateRenderersState PKSLGYJXKDK(SkinnedMeshRenderer[] a, Material b)
		{
			return default(AvatarFaceDisplayUpdateRenderersState);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x83AEB00", Offset = "0x83AD900", VA = "0x1883AEB00")]
		public static AvatarFaceDisplayUpdateFeatureSelectionState OFLZYABNPAV(TNHDFQBJNXY a, int b, Color c, Color d, int e, Color f, Color g, int h)
		{
			return default(AvatarFaceDisplayUpdateFeatureSelectionState);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x83AE9E0", Offset = "0x83AD7E0", VA = "0x1883AE9E0")]
		public static AvatarFaceDisplayUpdateFeaturePositionsState MTTWRGBKQXT(TNHDFQBJNXY a, Vector2 b, float c, float d, float e, Vector2 f, float g, float h, float i, Vector2 j, float k, float l, float m, Vector2 n, float o, float p, float q)
		{
			return default(AvatarFaceDisplayUpdateFeaturePositionsState);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x83AE960", Offset = "0x83AD760", VA = "0x1883AE960")]
		public static AvatarHandDisplayInitState JJKBQAQUWGY(Animator a, HandType b, AvatarConfiguration c, GameObject d, AvatarBodyType e)
		{
			return default(AvatarHandDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83AEF20", Offset = "0x83ADD20", VA = "0x1883AEF20")]
		public static AvatarHandDisplaySetupState WCXZQDSICWP(Transform a, bool b)
		{
			return default(AvatarHandDisplaySetupState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class WGLHTZEPKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83AE910", Offset = "0x83AD710", VA = "0x1883AE910")]
		public static HandVisualState WHBPKWLVNUN(this HandGestureType a)
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x83AE900", Offset = "0x83AD700", VA = "0x1883AE900")]
		public static bool OQRNRYDHFNJ(this HandGestureType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public enum SkinBodyMeshType
		{
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			FaceSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			TorsoValidationMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			TorsoModestyMesh,
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			LegsModestyMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs XWFEOBQTTVG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs QIYXVAUCASU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs ZQAAKFBSISJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BodySkinnedMeshLODs HDLFHAOBYNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x83A2F10", Offset = "0x83A1D10", VA = "0x1883A2F10")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(SkinBodyMeshType skinBodyMeshType, [Optional] FaceFeatureId? noseFaceOptionFeatureId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		[Tooltip("If this is a runtime bone order remapper, set this property to the target bone order data. Setting this field will clear the edit-time data.")]
		private SkinnedMeshBoneOrderData? runtimeBoneOrderData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		[Tooltip("If this is an edit-time bone order remapper, set this property to the target bone order data, BUT make sure to clear the runtime bone order data first.")]
		[FormerlySerializedAs("ValidSkinnedMeshBoneOrderDataReference")]
		private AssetReference? editorBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		[FormerlySerializedAs("BoneOrderRemapData")]
		private List<BoneOrderRemapEntry> editorBoneOrderRemaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private readonly Dictionary<string, IReadOnlyList<byte>> boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool DAQQVFVMCHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x83A3B90", Offset = "0x83A2990", VA = "0x1883A3B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83A3980", Offset = "0x83A2780", VA = "0x1883A3980")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83A3830", Offset = "0x83A2630", VA = "0x1883A3830")]
		private void GSTMMNISYTK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x83A3990", Offset = "0x83A2790", VA = "0x1883A3990")]
		public bool TryGetBoneOrderRemapArray(string boneOrderChecksum, [Out] IReadOnlyList<byte> remapArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83A30B0", Offset = "0x83A1EB0", VA = "0x1883A30B0")]
		public bool CalculateAndUpdateBoneOrderRemapArraysAtRuntime(SkinnedMeshRenderer skinnedMeshRenderer, string boneOrderChecksum, [Out] IReadOnlyList<byte> remapArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x83A31E0", Offset = "0x83A1FE0", VA = "0x1883A31E0")]
		private void CalculateAndUpdateBoneOrderRemapArraysInternal(SkinnedMeshBoneOrderData validBoneOrderData, bool persistToAsset, SkinnedMeshRenderer skinnedMeshRenderer, string boneOrderChecksum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x83A3AD0", Offset = "0x83A28D0", VA = "0x1883A3AD0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class AvatarSkinnedMeshBoneOrderRuntimeUtils
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public struct SkinnedMeshRendererBoneData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public Transform[] Bones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public Matrix4x4[] BindPoses;
		}

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83A3BE0", Offset = "0x83A29E0", VA = "0x1883A3BE0")]
		public static IReadOnlyList<byte> NKRDWTSMSUL(AvatarSkinnedMeshBoneOrderRemapsData a, SkinnedMeshRenderer b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83A4100", Offset = "0x83A2F00", VA = "0x1883A4100")]
		public static SkinnedMeshRendererBoneData? TIYWLTAVGEK(AvatarSkinnedMeshBoneOrderRemapsData a, SkinnedMeshRenderer b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string IEPSLBMVZAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83A46D0", Offset = "0x83A34D0", VA = "0x1883A46D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x83A4B00", Offset = "0x83A3900", VA = "0x1883A4B00")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x83A4B10", Offset = "0x83A3910", VA = "0x1883A4B10")]
		private void YQLPAYNQDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83A4700", Offset = "0x83A3500", VA = "0x1883A4700")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83A4760", Offset = "0x83A3560", VA = "0x1883A4760")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public struct BoneLocalInfo : IEquatable<BoneLocalInfo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public Vector3 LocalEulerAngles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Vector3 LocalScale;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83A4BD0", Offset = "0x83A39D0", VA = "0x1883A4BD0", Slot = "4")]
		public bool Equals(BoneLocalInfo other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83A4D10", Offset = "0x83A3B10", VA = "0x1883A4D10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83A4DC0", Offset = "0x83A3BC0", VA = "0x1883A4DC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public enum CustomAvatarItemPrivacyMode
	{
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		NeverObscured,
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		AlwaysObscured,
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		PrivateObscured
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class AGFDTAORDKM
	{
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public static readonly AGFDTAORDKM CJGYMEELLGF;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int JFVRNJOSHTA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAD3D80", Offset = "0xAD2B80", VA = "0x180AD3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public CustomAvatarItemPrivacyMode JOGOYCNLJGT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xBD3950", Offset = "0xBD2750", VA = "0x180BD3950")]
			[CompilerGenerated]
			get
			{
				return default(CustomAvatarItemPrivacyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xBD3960", Offset = "0xBD2760", VA = "0x180BD3960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public AGFDTAORDKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3075AA0", Offset = "0x30748A0", VA = "0x183075AA0")]
		public AGFDTAORDKM(CustomAvatarItemPrivacyMode a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x83A68C0", Offset = "0x83A56C0", VA = "0x1883A68C0")]
		public void DrawPosition(bool active, Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83A6960", Offset = "0x83A5760", VA = "0x1883A6960")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere hemisphere, Transform parent, Vector2 normalizedUV, AnchorParamsRestrictions anchorParamsRestrictions, bool hidePositions = false, bool hideNormals = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public FitMeshPreviewGizmo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<string> KOZIXUVXRIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x83AAB00", Offset = "0x83A9900", VA = "0x1883AAB00")]
		public void SaveBoneOrder(SkinnedMeshRenderer skinnedMeshRenderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x83AACA0", Offset = "0x83A9AA0", VA = "0x1883AACA0")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[Header("Remapping Eye Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x83A1450", Offset = "0x83A0250", VA = "0x1883A1450")]
		public void RemapFacialFeatureData(TZKOWMSJFHV faceFeatureCustomizationSettingsData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x83A1940", Offset = "0x83A0740", VA = "0x1883A1940")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB4BC40", Offset = "0xB4AA40", VA = "0x180B4BC40", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x83A4F00", Offset = "0x83A3D00", VA = "0x1883A4F00")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public Vector2 LimitsUVScale;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 KCHCNMFVYUW
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x83A5350", Offset = "0x83A4150", VA = "0x1883A5350")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x815D350", Offset = "0x815C150", VA = "0x18815D350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 GPZZJCJOPRV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x83A5370", Offset = "0x83A4170", VA = "0x1883A5370")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x805F590", Offset = "0x805E390", VA = "0x18805F590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 IYRFHNWJFUH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x83A5390", Offset = "0x83A4190", VA = "0x1883A5390")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1BCFB70", Offset = "0x1BCE970", VA = "0x181BCFB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 QUCGGRYJJGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x83A53B0", Offset = "0x83A41B0", VA = "0x1883A53B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x83A4F10", Offset = "0x83A3D10", VA = "0x1883A4F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83A4F20", Offset = "0x83A3D20", VA = "0x1883A4F20", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x83A5220", Offset = "0x83A4020", VA = "0x1883A5220")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x2861120", Offset = "0x285FF20", VA = "0x182861120")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x77B0980", Offset = "0x77AF780", VA = "0x1877B0980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x2861140", Offset = "0x285FF40", VA = "0x182861140")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x1B10F30", Offset = "0x1B0FD30", VA = "0x181B10F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83A5C10", Offset = "0x83A4A10", VA = "0x1883A5C10", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D50", Offset = "0x83A4B50", VA = "0x1883A5D50")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x83AD390", Offset = "0x83AC190", VA = "0x1883AD390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x83AE0E0", Offset = "0x83ACEE0", VA = "0x1883AE0E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private readonly List<XNDFGATNVRQ<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAC63F0", Offset = "0xAC51F0", VA = "0x180AC63F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAC6150", Offset = "0xAC4F50", VA = "0x180AC6150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x83A5B60", Offset = "0x83A4960", VA = "0x1883A5B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x83A5BD0", Offset = "0x83A49D0", VA = "0x1883A5BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x83A5B10", Offset = "0x83A4910", VA = "0x1883A5B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x15F0B30", Offset = "0x15EF930", VA = "0x1815F0B30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x2874E00", Offset = "0x2873C00", VA = "0x182874E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x83A5640", Offset = "0x83A4440", VA = "0x1883A5640")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x83A5780", Offset = "0x83A4580", VA = "0x1883A5780", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x83A56B0", Offset = "0x83A44B0", VA = "0x1883A56B0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x83A5860", Offset = "0x83A4660", VA = "0x1883A5860")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x83A5430", Offset = "0x83A4230", VA = "0x1883A5430")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x83A5930", Offset = "0x83A4730", VA = "0x1883A5930")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Brows
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class HINWEIYRPYB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x83A6EA0", Offset = "0x83A5CA0", VA = "0x1883A6EA0")]
		public static ZDISWKRHTSH OBGDBTDPPCL(this FaceFeatureType a, AvatarData b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public sealed class TNHDFQBJNXY : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private struct <InitializeFaceStyleAsync>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400021F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000220")]
			public AsyncTaskMethodBuilder<TNHDFQBJNXY> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000221")]
			public SymmetricalFaceFeature eyeBrow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000222")]
			public EyesFaceFeature eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			public FaceFeature mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private DisposeReminder.DisableStackTraceToken <__>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x83ACAF0", Offset = "0x83AB8F0", VA = "0x1883ACAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x83AD320", Offset = "0x83AC120", VA = "0x1883AD320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private readonly Dictionary<string, int> INUMPIBKHZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private bool RVCILFABSNN;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public List<Texture2D> GLRWDKAEWVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACB610", VA = "0x180ACC810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public SymmetricalFaceFeature ICQETQBPDWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public EyesFaceFeature PRPWLSXVHLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C40", Offset = "0xAC7A40", VA = "0x180AC8C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public FaceFeature LYQWWPVDGXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAD0080", Offset = "0xACEE80", VA = "0x180AD0080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x83AB060", Offset = "0x83A9E60", VA = "0x1883AB060")]
		private static void BCIYHGGAGMT(Sprite a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x83AB450", Offset = "0x83AA250", VA = "0x1883AB450")]
		public static TNHDFQBJNXY CHUJHKEOAUX(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x83AB770", Offset = "0x83AA570", VA = "0x1883AB770")]
		[AsyncStateMachine(typeof(<InitializeFaceStyleAsync>d__20))]
		public static Task<TNHDFQBJNXY> LSZHEIVECIE(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x83AB9A0", Offset = "0x83AA7A0", VA = "0x1883AB9A0")]
		private TNHDFQBJNXY(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x83AB0A0", Offset = "0x83A9EA0", VA = "0x1883AB0A0")]
		private void BZKSVKYLGOM(List<Sprite> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x83AB8B0", Offset = "0x83AA6B0", VA = "0x1883AB8B0")]
		public bool TSAXOPEYBHZ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x83AB4D0", Offset = "0x83AA2D0", VA = "0x1883AB4D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x83AB5B0", Offset = "0x83AA3B0", VA = "0x1883AB5B0")]
		public bool IsValid(bool usesModernAvatar)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x83AB6A0", Offset = "0x83AA4A0", VA = "0x1883AB6A0")]
		public void KWPTFUKTXIQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct <BuildFaceStyle>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public AsyncTaskMethodBuilder<TNHDFQBJNXY> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			private TaskAwaiter<TNHDFQBJNXY> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x83ABC10", Offset = "0x83AAA10", VA = "0x1883ABC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x83AC110", Offset = "0x83AAF10", VA = "0x1883AC110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private Dictionary<FaceFeatureId, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private Dictionary<FaceFeatureId, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private Dictionary<FaceFeatureId, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private Dictionary<FaceFeatureId, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private readonly Dictionary<FaceFeatureId, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private TNHDFQBJNXY _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool MEMBHCKZCNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x83A6570", Offset = "0x83A5370", VA = "0x1883A6570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x83A5F80", Offset = "0x83A4D80", VA = "0x1883A5F80")]
		public TNHDFQBJNXY CreateOrGetDefaultFaceStyle(AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x83A5E50", Offset = "0x83A4C50", VA = "0x1883A5E50")]
		[AsyncStateMachine(typeof(<BuildFaceStyle>d__16))]
		public Task<TNHDFQBJNXY> BuildFaceStyle(int? eyeBrows, int eye, int mouth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x83A6350", Offset = "0x83A5150", VA = "0x1883A6350")]
		public NoseFaceOption GetNoseFaceOption(int noseIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83A61D0", Offset = "0x83A4FD0", VA = "0x1883A61D0")]
		public SelectableFaceOption GetFeature(FaceFeatureType featureType, FaceFeatureId faceFeatureId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x83A6150", Offset = "0x83A4F50", VA = "0x1883A6150")]
		public int GetFeatureIndex(FaceFeatureId faceFeatureId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x83A65A0", Offset = "0x83A53A0", VA = "0x1883A65A0")]
		private void VPUWYTRBTWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x376D430", Offset = "0x376C230", VA = "0x18376D430")]
		private void ZUYUZDTHKQU<a>(IDictionary<FaceFeatureId, a> a, IReadOnlyList<a> b) where a : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x83A6040", Offset = "0x83A4E40", VA = "0x1883A6040")]
		public FaceFeatureId GetDefaultFaceOptionId(FaceFeatureType featureType)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x83A63F0", Offset = "0x83A51F0", VA = "0x1883A63F0")]
		public FaceFeatureId GetRandomFaceOptionId(FaceFeatureType featureType)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x83A67A0", Offset = "0x83A55A0", VA = "0x1883A67A0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x83A5D50", Offset = "0x83A4B50", VA = "0x1883A5D50")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public NoseType SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xB611A0", Offset = "0xB5FFA0", VA = "0x180B611A0")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		[SerializeField]
		private bool isNew;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public FaceFeatureId FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x1658630", Offset = "0x1657430", VA = "0x181658630")]
			get
			{
				return default(FaceFeatureId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xAF4620", Offset = "0xAF3420", VA = "0x180AF4620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x1940B30", Offset = "0x193F930", VA = "0x181940B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x83A13A0", Offset = "0x83A01A0", VA = "0x1883A13A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xB611A0", Offset = "0xB5FFA0", VA = "0x180B611A0")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector2 URLPQNBDHIP
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x83AB000", Offset = "0x83A9E00", VA = "0x1883AB000")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x77AC850", Offset = "0x77AB650", VA = "0x1877AC850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 VACHLFCKPUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x83AB020", Offset = "0x83A9E20", VA = "0x1883AB020")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x77AC860", Offset = "0x77AB660", VA = "0x1877AC860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 KQBADPIFYMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x82A6380", Offset = "0x82A5180", VA = "0x1882A6380")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x77AFAD0", Offset = "0x77AE8D0", VA = "0x1877AFAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 OMXNLEWXHQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x83AB040", Offset = "0x83A9E40", VA = "0x1883AB040")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x77AFAC0", Offset = "0x77AE8C0", VA = "0x1877AFAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x83AAD20", Offset = "0x83A9B20", VA = "0x1883AAD20", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x83AAF30", Offset = "0x83A9D30", VA = "0x1883AAF30")]
		protected SymmetricalFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class ICRWCEKNVRW
	{
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public static readonly float ZFYPPGAKVTI;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public static readonly float RYBXTELHLLY;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public static readonly Vector2 LTTLTDBVPCL;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public static readonly Vector2 NXWIDCWPFVX;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public static readonly Vector2 BHWJUUXSZAC;

		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public static readonly Vector2 TXNGGUTZFNL;

		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public static readonly Vector2 GIVNPNJYXEH;

		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public static readonly Vector2 YAFIRJCCDLS;

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public static readonly Vector2 FMHTHLWUHFO;

		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public static readonly Vector2 ZONWAHIPQVE;

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public static readonly Vector2 PGAZIIWSMQT;

		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public static readonly Vector2 CMWFPEAOAUU;

		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public static readonly Vector2 LQCCNOXHAJM;

		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public static readonly Vector2 QDRTOMCWITV;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x83A7440", Offset = "0x83A6240", VA = "0x1883A7440")]
		public static Vector2 BNUPWLNBQCL(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x83A7070", Offset = "0x83A5E70", VA = "0x1883A7070")]
		public static float APODVMIQNHK(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x83A7910", Offset = "0x83A6710", VA = "0x1883A7910")]
		public static void DLDSXDLUJWA(TZKOWMSJFHV a, AvatarConfiguration b, AvatarBodyType c, AvatarBodyType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x83A9430", Offset = "0x83A8230", VA = "0x1883A9430")]
		public static float VJYKZHPYMPZ(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x83A88A0", Offset = "0x83A76A0", VA = "0x1883A88A0")]
		public static float MZMGRCAMORF(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x83A8580", Offset = "0x83A7380", VA = "0x1883A8580")]
		public static float LCTNQQWNOBL(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x83A92E0", Offset = "0x83A80E0", VA = "0x1883A92E0")]
		public static float UKZDOSURQLL(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x83A9AB0", Offset = "0x83A88B0", VA = "0x1883A9AB0")]
		public static float YRGOAKJILFH(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x83A80D0", Offset = "0x83A6ED0", VA = "0x1883A80D0")]
		public static float HIBCOBXOXZP(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x83A8160", Offset = "0x83A6F60", VA = "0x1883A8160")]
		public static Vector2 HRPEUSBKTQV(FaceFeatureType a, Vector2 b, Vector2 c, Vector2 d, AvatarBodyType e, AvatarConfiguration f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x83A8E10", Offset = "0x83A7C10", VA = "0x1883A8E10")]
		public static Vector2 QZHAJZPKZON(FaceFeatureType a, Vector2 b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x83A9CC0", Offset = "0x83A8AC0", VA = "0x1883A9CC0")]
		private static Vector2 ZPZMFJOPYEW(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x83A8930", Offset = "0x83A7730", VA = "0x1883A8930")]
		private static Vector2 OQASBASBWEE(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x83A7A80", Offset = "0x83A6880", VA = "0x1883A7A80")]
		private static Vector2 DYXFDALEYGK(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x83A86D0", Offset = "0x83A74D0", VA = "0x1883A86D0")]
		private static Vector2 MEIWVAVNLVK(FaceFeatureType a, Vector2 b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x83A9560", Offset = "0x83A8360", VA = "0x1883A9560")]
		public static Vector2 XKNBYNOYRPP(FaceFeatureType a, Vector2 b, Vector2 c, Vector2 d, AvatarBodyType e, AvatarConfiguration f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x83A7DF0", Offset = "0x83A6BF0", VA = "0x1883A7DF0")]
		public static float EXGAUPTASRQ(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x83A9E30", Offset = "0x83A8C30", VA = "0x1883A9E30")]
		public static float ZYFJWFYPXQS(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x83A94C0", Offset = "0x83A82C0", VA = "0x1883A94C0")]
		public static float WWVQQETIAJW(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x83A9070", Offset = "0x83A7E70", VA = "0x1883A9070")]
		private static float RCAQHZHPDUG(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x83A8230", Offset = "0x83A7030", VA = "0x1883A8230")]
		private static Vector2 INHWRICWVFJ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x83A8BE0", Offset = "0x83A79E0", VA = "0x1883A8BE0")]
		private static Vector2 PBINMQOKNJO(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x83A9230", Offset = "0x83A8030", VA = "0x1883A9230")]
		private static Vector2 TCGTROCFQVC(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x83A84D0", Offset = "0x83A72D0", VA = "0x1883A84D0")]
		private static Vector2 KEICSGUXGZQ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x83A91C0", Offset = "0x83A7FC0", VA = "0x1883A91C0")]
		private static float STZHCRKXEFS(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x83A9A40", Offset = "0x83A8840", VA = "0x1883A9A40")]
		private static float XZJLVHXCUMG(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x83A7320", Offset = "0x83A6120", VA = "0x1883A7320")]
		private static float BKPHVWTLCCF(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x83A8460", Offset = "0x83A7260", VA = "0x1883A8460")]
		private static float JWUQWWQUWJR(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x83A9370", Offset = "0x83A8170", VA = "0x1883A9370")]
		private static Vector2 VJKHLDMRWGM(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x83A9100", Offset = "0x83A7F00", VA = "0x1883A9100")]
		private static Vector2 RVIAHPSTVWK(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x83A82E0", Offset = "0x83A70E0", VA = "0x1883A82E0")]
		private static Vector2 IXTMFPWKXGX(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x83A6FC0", Offset = "0x83A5DC0", VA = "0x1883A6FC0")]
		private static Vector2 ALSXXPOAAVB(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83A77A0", Offset = "0x83A65A0", VA = "0x1883A77A0")]
		private static Vector2 CEXJKDGUUIV(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x83A8C90", Offset = "0x83A7A90", VA = "0x1883A8C90")]
		private static Vector2 PSHTUQDGFVI(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x83A7850", Offset = "0x83A6650", VA = "0x1883A7850")]
		private static Vector2 CULYWOXAIDK(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x83A8D50", Offset = "0x83A7B50", VA = "0x1883A8D50")]
		private static Vector2 QFHEMNIPMMV(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x83A76F0", Offset = "0x83A64F0", VA = "0x1883A76F0")]
		private static Vector2 BSEXLVELBOF(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x83A7390", Offset = "0x83A6190", VA = "0x1883A7390")]
		private static Vector2 BMQVTJOIYYP(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x83A9980", Offset = "0x83A8780", VA = "0x1883A9980")]
		private static Vector2 XMWERCEKVBX(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x83A7260", Offset = "0x83A6060", VA = "0x1883A7260")]
		private static Vector2 ATHUENHFZYT(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x83A8010", Offset = "0x83A6E10", VA = "0x1883A8010")]
		private static Vector2 GCTBIHEWCQQ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x83A8610", Offset = "0x83A7410", VA = "0x1883A8610")]
		private static Vector2 LNKSEEKLOWW(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x83A98C0", Offset = "0x83A86C0", VA = "0x1883A98C0")]
		private static Vector2 XMUPMCWUCYE(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x83A9B40", Offset = "0x83A8940", VA = "0x1883A9B40")]
		private static Vector2 YYYFYTAWBUZ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x83A79C0", Offset = "0x83A67C0", VA = "0x1883A79C0")]
		private static Vector2 DMULRMUWZAL(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x83A7D30", Offset = "0x83A6B30", VA = "0x1883A7D30")]
		private static Vector2 ESUPCTFVQQQ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x83A9C00", Offset = "0x83A8A00", VA = "0x1883A9C00")]
		private static Vector2 ZFNFBZCAKUS(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x83A83A0", Offset = "0x83A71A0", VA = "0x1883A83A0")]
		private static Vector2 JRZIZJXAQWQ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
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
