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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x818A200", Offset = "0x8188A00", VA = "0x18818A200")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x8189D20", Offset = "0x8188520", VA = "0x188189D20", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x8177E90", Offset = "0x8176690", VA = "0x188177E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
		private sealed class LJVOSBJTYSO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public AvatarNoseTypeBoneData MNHIIPTRPTX;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public LJVOSBJTYSO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8189CC0", Offset = "0x81884C0", VA = "0x188189CC0")]
			internal bool XDEXAPCQUBV(KeyValuePair<string, Transform> a)
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
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x817ED80", Offset = "0x817D580", VA = "0x18817ED80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x817B040", Offset = "0x8179840", VA = "0x18817B040")]
		public void Initialize(IReadOnlyDictionary<string, Transform> boneNameMapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8178310", Offset = "0x8176B10", VA = "0x188178310")]
		public void ApplyTransformsForFaceShape(IReadOnlyDictionary<string, Transform> boneNameMapping, AvatarFaceShapeData.BlendShapeName faceShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8178610", Offset = "0x8176E10", VA = "0x188178610")]
		public void ApplyTransformsForNoseType(IReadOnlyDictionary<string, Transform> boneNameMapping, NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8178010", Offset = "0x8176810", VA = "0x188178010")]
		public void ApplyTransformsForBodyShape(IReadOnlyDictionary<string, Transform> boneNameMapping, AvatarBodyShapeData.BlendShapeName bodyShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8178A30", Offset = "0x8177230", VA = "0x188178A30")]
		public void ApplyTransformsForPropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<string, BoneLocalInfo> bodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x817AAD0", Offset = "0x81792D0", VA = "0x18817AAD0")]
		public IReadOnlyDictionary<string, BoneLocalInfo> GetInitialInfoForAllBones(IReadOnlyDictionary<string, Transform> boneNameMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x817A810", Offset = "0x8179010", VA = "0x18817A810")]
		public Dictionary<string, BoneLocalInfo> GetCurrentBodyPropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<BodyProperty, float> bodyPropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x817A8B0", Offset = "0x81790B0", VA = "0x18817A8B0")]
		public Dictionary<string, BoneLocalInfo> GetCurrentFacePropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<FaceProperty, float> facePropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x817A950", Offset = "0x8179150", VA = "0x18817A950")]
		public Dictionary<string, BoneLocalInfo> GetCurrentNosePropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<NoseProperty, float> nosePropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x33D60C0", Offset = "0x33D48C0", VA = "0x1833D60C0")]
		private Dictionary<string, BoneLocalInfo> UTZFXAMLQUA<a>(IReadOnlyDictionary<string, Transform> a, IReadOnlyDictionary<a, float> b, IReadOnlyDictionary<string, BoneLocalInfo> c, Dictionary<a, Dictionary<string, PropertyInfluences>> d, Dictionary<(string, a, float), AvatarBodyPartBoneData> e, bool f, bool g, [Optional] float? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8179540", Offset = "0x8177D40", VA = "0x188179540")]
		public static (float, float) ComputeNoseTweakAlongCurvedSurface(float nosePositionOffset)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x817A6D0", Offset = "0x8178ED0", VA = "0x18817A6D0")]
		public float GetClosestBodyProperty(BodyProperty bodyProperty, float bodyPropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x817A730", Offset = "0x8178F30", VA = "0x18817A730")]
		public float GetClosestFaceProperty(FaceProperty faceProperty, float facePropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x817A7A0", Offset = "0x8178FA0", VA = "0x18817A7A0")]
		public float GetClosestNoseProperty(NoseProperty noseProperty, float nosePropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x33D53A0", Offset = "0x33D3BA0", VA = "0x1833D53A0")]
		private float TUQAFOYJEIV<b>(b a, float b, Dictionary<b, List<float>> c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x817AEB0", Offset = "0x81796B0", VA = "0x18817AEB0")]
		private BoneLocalInfo HUPFHKBPQUN(IReadOnlyDictionary<string, Transform> a, string b)
		{
			return default(BoneLocalInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x817D0D0", Offset = "0x817B8D0", VA = "0x18817D0D0")]
		private float OEQMTTQBBXL(float a, List<float> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81794D0", Offset = "0x8177CD0", VA = "0x1881794D0")]
		private Vector3 BRKIARCFLCB(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x817D1D0", Offset = "0x817B9D0", VA = "0x18817D1D0")]
		private Quaternion OKRPXVXGIWY(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81795D0", Offset = "0x8177DD0", VA = "0x1881795D0")]
		private Vector3 EPXQXMIHCHW(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8179640", Offset = "0x8177E40", VA = "0x188179640")]
		private void GWSOMQHRJRG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7377C60", Offset = "0x7376460", VA = "0x187377C60")]
		public bool PropertyInfluenceContains(PropertyInfluences allInfluences, PropertyInfluences influenceToCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x817D230", Offset = "0x817BA30", VA = "0x18817D230")]
		private BoneLocalInfo VYWYXVPXRUF(PropertyInfluences a, BoneLocalInfo b, AvatarBodyPartBoneData c)
		{
			return default(BoneLocalInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8178E40", Offset = "0x8177640", VA = "0x188178E40")]
		public Dictionary<string, BoneLocalInfo> AverageBoneInfluencesPerProperty(Dictionary<string, BoneLocalInfo> boneLocalInfo, bool averageRotationInfluences)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x817E1C0", Offset = "0x817C9C0", VA = "0x18817E1C0")]
		private void XGTNMVIMLAZ(Transform a, AvatarBodyPartBoneData b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x817E4E0", Offset = "0x817CCE0", VA = "0x18817E4E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x817EE80", Offset = "0x817D680", VA = "0x18817EE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
			[Cpp2IlInjected.Address(RVA = "0x163C6C0", Offset = "0x163AEC0", VA = "0x18163C6C0")]
			get
			{
				return default(BodyShapeId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.BlendShapeName BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xACB450", Offset = "0xAC9C50", VA = "0x180ACB450")]
			get
			{
				return default(AvatarBodyShapeData.BlendShapeName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x817F6A0", Offset = "0x817DEA0", VA = "0x18817F6A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x817F040", Offset = "0x817D840", VA = "0x18817F040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
		private readonly Dictionary<BodyShapeId, AvatarBodyShape> ESYVBFIQACQ;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x817F1A0", Offset = "0x817D9A0", VA = "0x18817F1A0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x817F4C0", Offset = "0x817DCC0", VA = "0x18817F4C0")]
		public AvatarBodyShape Find(BodyShapeId bodyShapeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x817F5C0", Offset = "0x817DDC0", VA = "0x18817F5C0")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x817F580", Offset = "0x817DD80", VA = "0x18817F580")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x817F600", Offset = "0x817DE00", VA = "0x18817F600")]
		public AvatarBodyShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class YPGXFEFEWTC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Transform[] CZVVWFOHYUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly Dictionary<string, Transform> LOQXPJCFSCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly Dictionary<Transform, Transform> DXBNHFOYVGZ;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyDictionary<string, Transform> PGQKRWXEFUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Transform[] YVMCFKZTXHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x818D310", Offset = "0x818BB10", VA = "0x18818D310")]
		public void RPYNPAGBFEE(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x818D630", Offset = "0x818BE30", VA = "0x18818D630")]
		public Transform YOPKRCQAOSQ(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x818D3F0", Offset = "0x818BBF0", VA = "0x18818D3F0")]
		public void YIPOZDWNAHF(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x818D710", Offset = "0x818BF10", VA = "0x18818D710")]
		private static void ZQZIILNSIJT(Transform a, List<Transform> b, Dictionary<string, Transform> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x818D8C0", Offset = "0x818C0C0", VA = "0x18818D8C0")]
		public YPGXFEFEWTC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ZVZUWTELACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public bool KVORZKDPTDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public bool JZXRXZPHSIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public bool HAMSVMQLGCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public bool DOXUZZNTYVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public bool SNUYPKKIYRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public FaceFeatureId? ACBWMIWBEKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public YUYCEVTIIQN.SkinCullingMask RGLZSSILJWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public RecRoom.Avatars.Data.Shared.HairData ECFJPHFZHQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AdditionalHatData XQLSIIHXVTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool WMRFGPBAXZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool QHSPGVBQJHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool VUMWZIMCEVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool ZCBLCELAHZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool ZJUOMHYHITF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IList<VLWQEDFNTAI> PJNOOPRWOVU;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZVZUWTELACM()
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
		[Cpp2IlInjected.Address(RVA = "0x817F730", Offset = "0x817DF30", VA = "0x18817F730")]
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
		public List<RangeMigration> FVFCAJIMSSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xC12910", Offset = "0xC11110", VA = "0x180C12910")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class JIYEDUGKYGD
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static SALXGGKYXAC COLCTKIJGJV
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8186B60", Offset = "0x8185360", VA = "0x188186B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static SDZUMEDZFPG BOACETFPIHV
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8186A40", Offset = "0x8185240", VA = "0x188186A40")]
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
		public EMVQPZWRSOL ActiveFaceStyle;

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
		public EMVQPZWRSOL ActiveFaceStyle;

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
		[Cpp2IlInjected.Address(RVA = "0x817FD80", Offset = "0x817E580", VA = "0x18817FD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
			[Cpp2IlInjected.Address(RVA = "0x163C6C0", Offset = "0x163AEC0", VA = "0x18163C6C0")]
			get
			{
				return default(FaceShapeId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.BlendShapeName BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xACB450", Offset = "0xAC9C50", VA = "0x180ACB450")]
			get
			{
				return default(AvatarFaceShapeData.BlendShapeName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81805A0", Offset = "0x817EDA0", VA = "0x1881805A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8180600", Offset = "0x817EE00", VA = "0x188180600")]
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
		[Cpp2IlInjected.Address(RVA = "0x817FF40", Offset = "0x817E740", VA = "0x18817FF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
		private readonly Dictionary<FaceShapeId, AvatarFaceShape> ESYVBFIQACQ;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x81800A0", Offset = "0x817E8A0", VA = "0x1881800A0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81803C0", Offset = "0x817EBC0", VA = "0x1881803C0")]
		public AvatarFaceShape Find(FaceShapeId faceShapeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81804C0", Offset = "0x817ECC0", VA = "0x1881804C0")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8180480", Offset = "0x817EC80", VA = "0x188180480")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8180500", Offset = "0x817ED00", VA = "0x188180500")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8180C50", Offset = "0x817F450", VA = "0x188180C50")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HairPatternId HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x163C6C0", Offset = "0x163AEC0", VA = "0x18163C6C0")]
			get
			{
				return default(HairPatternId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB9D590", Offset = "0xB9BD90", VA = "0x180B9D590")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xBF0AE0", Offset = "0xBEF2E0", VA = "0x180BF0AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8180D90", Offset = "0x817F590", VA = "0x188180D90")]
		public Texture2D GetTexture(HairPatternStyle style)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8180CD0", Offset = "0x817F4D0", VA = "0x188180CD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8180C60", Offset = "0x817F460", VA = "0x188180C60", Slot = "4")]
		public bool Equals(AvatarHairPattern other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8180EE0", Offset = "0x817F6E0", VA = "0x188180EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8180D80", Offset = "0x817F580", VA = "0x188180D80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8181090", Offset = "0x817F890", VA = "0x188181090")]
		public static bool operator !=(AvatarHairPattern lhs, AvatarHairPattern rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8181010", Offset = "0x817F810", VA = "0x188181010")]
		public static bool operator ==(AvatarHairPattern lhs, AvatarHairPattern rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8180F20", Offset = "0x817F720", VA = "0x188180F20")]
		public AvatarHairPattern()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum HandVisualState
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Invisible,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Pointing,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		ClosedFist,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		TPose,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		ThumbUp,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		HandShake,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Grabbing,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Flat,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		NumStates
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Flags]
	public enum HandAnimationOverrideState
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		ThumbUp = 1,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Pointing = 2,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		HandShake = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct AvatarHandDisplayInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public Animator AvatarAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public HandType HandSidedness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public GameObject WatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AvatarBodyType AvatarBodyType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct AvatarHandDisplaySetupState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Transform HandIKEffectorTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public bool IsPlayerUsingScreen;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x81810C0", Offset = "0x817F8C0", VA = "0x1881810C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public struct ItemDefinitionBodyPart
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool isRoomieBodypart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private AvatarBodyPart avatarBodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private RoomieBodyPart roomieBodyPart;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly ItemDefinitionBodyPart RoomieSkinPlaceholder;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public readonly bool PZXANOZJTQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x81868C0", Offset = "0x81850C0", VA = "0x1881868C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x515FDA0", Offset = "0x515E5A0", VA = "0x18515FDA0")]
		public readonly bool MHQQMSSYZGL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2E1D5E0", Offset = "0x2E1BDE0", VA = "0x182E1D5E0")]
		public readonly RoomieBodyPart FFGDHGUJLSN()
		{
			return default(RoomieBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xF95A20", Offset = "0xF94220", VA = "0x180F95A20")]
		public readonly AvatarBodyPart XJEYVCYGLAZ()
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81869D0", Offset = "0x81851D0", VA = "0x1881869D0")]
		public static ItemDefinitionBodyPart XNLRTPOYZAT(RoomieBodyPart a)
		{
			return default(ItemDefinitionBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8186920", Offset = "0x8185120", VA = "0x188186920")]
		public static ItemDefinitionBodyPart QOOGTIVMPZN(AvatarBodyPart a)
		{
			return default(ItemDefinitionBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8186940", Offset = "0x8185140", VA = "0x188186940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class VLWQEDFNTAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public string TYWDEKEDEIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public OutfitType PGNMBSHMRJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public ItemDefinitionBodyPart RTJYXVDBNYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AssetReference YUFIOEHLJQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AssetReference SDORPSVWGNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AssetReference[] WFLNMBKKUUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public YUYCEVTIIQN.SkinCullingMask LIPEEVPRDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public bool UXAXBIGJZED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public bool BIQOPWJEHQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public bool KOTPBIZHUVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public Color? LYELKQDZFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public bool GMQMGOPDJZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public Color? KBUOVBLRSNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public bool RKEEGHGUWMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool QKJJLPUIDWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public bool QISASGTMCXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public Transform BUNWVVEUWRX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public Vector2? YYVNDSWAEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public FitMeshHemisphere NSADGUYTLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public VLWQEDFNTAI OGCKLBGIGHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public bool LAAEOFPTQRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public bool DBMOLVCCFRO;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string GYKJPXPTTAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x818D250", Offset = "0x818BA50", VA = "0x18818D250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x818D250", Offset = "0x818BA50", VA = "0x18818D250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x818D300", Offset = "0x818BB00", VA = "0x18818D300")]
		public VLWQEDFNTAI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private MaterialCombinationId? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CombinationId CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8181660", Offset = "0x817FE60", VA = "0x188181660")]
			get
			{
				return default(CombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public MaterialCombinationId MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x8181690", Offset = "0x817FE90", VA = "0x188181690")]
			get
			{
				return default(MaterialCombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xAB3470", Offset = "0xAB1C70", VA = "0x180AB3470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8181340", Offset = "0x817FB40", VA = "0x188181340")]
		public Material[] GetAllMaterials()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8181150", Offset = "0x817F950", VA = "0x188181150")]
		public static void Apply(AvatarItemMaterial itemMaterial, Material material, int materialIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8181430", Offset = "0x817FC30", VA = "0x188181430")]
		private static bool OGBZYRGWWCZ(AvatarItemMaterial a, int b, [Out] Material c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81815E0", Offset = "0x817FDE0", VA = "0x1881815E0")]
		public AvatarItemMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class MPRYZNKLXLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public SkinnedMeshRenderer DUMTACLZBJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private Material[] IJAEAKVMUGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private IReadOnlyList<byte> ZZXFMZKVFNZ;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Mesh VAVULMTYFRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8189DE0", Offset = "0x81885E0", VA = "0x188189DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Material[] RTEMCLOFHKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyList<byte> VLSHRCUWNZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8189F90", Offset = "0x8188790", VA = "0x188189F90")]
		public MPRYZNKLXLP(SkinnedMeshRenderer a, AvatarSkinnedMeshBoneOrderRemapsData b, Material[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8189E00", Offset = "0x8188600", VA = "0x188189E00")]
		public static MPRYZNKLXLP WOOZYFNKSOU(Renderer a, AvatarSkinnedMeshBoneOrderRemapsData b, Material[] c)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static PositionAndRotation BIGUOPIZRYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x14B6250", Offset = "0x14B4A50", VA = "0x1814B6250")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB3C5F0", Offset = "0xB3ADF0", VA = "0x180B3C5F0")]
		public void Set(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public static class FLRKZUPXLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8184B60", Offset = "0x8183360", VA = "0x188184B60")]
		public static PositionAndRotation LGHPPBSSAYS(this PositionAndRotation a)
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8184A40", Offset = "0x8183240", VA = "0x188184A40")]
		public static float ITURKQETJWI(float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8184AE0", Offset = "0x81832E0", VA = "0x188184AE0")]
		public static float ITURKQETJWI(float a, float b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8184D60", Offset = "0x8183560", VA = "0x188184D60")]
		public static float SDUSMMVUUGK(float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8184CB0", Offset = "0x81834B0", VA = "0x188184CB0")]
		public static float SDUSMMVUUGK(float a, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class AvatarNosePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public NoseProperty NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public float NosePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8181750", Offset = "0x817FF50", VA = "0x188181750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public AvatarNosePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public NoseType NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8181910", Offset = "0x8180110", VA = "0x188181910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public enum HandGestureType
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Highfive = 1,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Fistbump = 2,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Handshake = 3,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		GiveTake = 4,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		OpenHand = 100,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Point = 101,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		ThumbsUp = 102,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		ThumbsDown = 103,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		ClosedFist = 104,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		OBSOLETE_CannedWave = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public enum AnimationPoseType
	{
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		IdleSwayAimWeapon,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		IdleSwayMeleeWeapon,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		IdleSwayLightItem,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		IdleSwayHeavyItem,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		IdleSwayAimOneHandedWeapon,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		FastAction,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		NumTypes
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum AvatarBuildType
	{
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Inactive,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		PotatoAvatar,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		FullOutfitAvatar
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public PositionAndRotation FingerMidOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public HandLogicOffsets()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct FaceFeaturesInUVSpace
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Vector2 leftEyeBrowPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public Vector2 leftEyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Vector2 leftEyePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public Vector2 leftEyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public Vector2 leftEyeGleamPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Vector2 leftEyeGleamScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public Vector2 rightEyeBrowPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public Vector2 rightEyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public Vector2 rightEyePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public Vector2 rightEyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public Vector2 rightEyeGleamPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public Vector2 rightEyeGleamScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Vector2 noseTweakPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Vector2 noseTweakScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public Vector2 mouthPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Vector2 mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public float eyeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public float eyebrowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float noseRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public float mouthRotation;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public PositionAndRotation MouthColliderOffset;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class TGLTTEHLZJB
	{
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public static readonly int RYIRCFSPFNC;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public static readonly string MJUWWYTEWRC;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x818AA40", Offset = "0x8189240", VA = "0x18818AA40")]
		public static AvatarDisplayInitState JLTVJFDZCKT(Transform a, AvatarSkinAssetItem b, AssetReference c, AssetReference d, AssetReference e, AssetReference f, GameObject g, GameObject h, GameObject i, SkinnedMeshRenderer j, AvatarSkinnedMeshBoneOrderRemapsData k, Material l, Material m, Material n, Texture2D o, Material p, Material q, Shader r, Shader s, Animator t, Renderer[] u, AvatarConfiguration v, AvatarBodyPartShapesManager w, IReadOnlyDictionary<string, Transform> x, Transform y, AvatarBodyType z)
		{
			return default(AvatarDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x818AEA0", Offset = "0x81896A0", VA = "0x18818AEA0")]
		public static AvatarDisplaySetupState WYNMYMGAXMW(SkinnedMeshRenderer[] a, SkinnedMeshRenderer[] b, SkinnedMeshRenderer[] c, SkinnedMeshRenderer[] d)
		{
			return default(AvatarDisplaySetupState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x818A980", Offset = "0x8189180", VA = "0x18818A980")]
		public static AvatarFaceDisplayInitState EQEEIJBYCQF(Transform a, Transform b, Transform c, Transform d, Transform e, Transform f, AvatarConfiguration g, AvatarBodyType h)
		{
			return default(AvatarFaceDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2873CD0", Offset = "0x28724D0", VA = "0x182873CD0")]
		public static AvatarFaceDisplayUpdateRenderersState QXIAYVVWMUN(SkinnedMeshRenderer[] a, Material b)
		{
			return default(AvatarFaceDisplayUpdateRenderersState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x818ADD0", Offset = "0x81895D0", VA = "0x18818ADD0")]
		public static AvatarFaceDisplayUpdateFeatureSelectionState QRIUTRVMPZA(EMVQPZWRSOL a, int b, Color c, Color d, int e, Color f, Color g, int h)
		{
			return default(AvatarFaceDisplayUpdateFeatureSelectionState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x818A860", Offset = "0x8189060", VA = "0x18818A860")]
		public static AvatarFaceDisplayUpdateFeaturePositionsState APNIBCQSYVA(EMVQPZWRSOL a, Vector2 b, float c, float d, float e, Vector2 f, float g, float h, float i, Vector2 j, float k, float l, float m, Vector2 n, float o, float p, float q)
		{
			return default(AvatarFaceDisplayUpdateFeaturePositionsState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x818AD50", Offset = "0x8189550", VA = "0x18818AD50")]
		public static AvatarHandDisplayInitState PBUAYLLMRIZ(Animator a, HandType b, AvatarConfiguration c, GameObject d, AvatarBodyType e)
		{
			return default(AvatarHandDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x818AE60", Offset = "0x8189660", VA = "0x18818AE60")]
		public static AvatarHandDisplaySetupState RCCLVIUPHBC(Transform a, bool b)
		{
			return default(AvatarHandDisplaySetupState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class ILTIGRXTDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8186870", Offset = "0x8185070", VA = "0x188186870")]
		public static HandVisualState KVMWLORXITI(this HandGestureType a)
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8186860", Offset = "0x8185060", VA = "0x188186860")]
		public static bool JKRCTNWJMHS(this HandGestureType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public enum SkinBodyMeshType
		{
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			FaceSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			TorsoValidationMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			TorsoModestyMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			LegsModestyMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs OJKQWDAQWMD
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs KCTTRHHWTFN
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs TOSGLYQLALM
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BodySkinnedMeshLODs EOTVVYWKNPW
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8181A70", Offset = "0x8180270", VA = "0x188181A70")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(SkinBodyMeshType skinBodyMeshType, [Optional] FaceFeatureId? noseFaceOptionFeatureId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		[Tooltip("If this is a runtime bone order remapper, set this property to the target bone order data. Setting this field will clear the edit-time data.")]
		private SkinnedMeshBoneOrderData? runtimeBoneOrderData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		[Tooltip("If this is an edit-time bone order remapper, set this property to the target bone order data, BUT make sure to clear the runtime bone order data first.")]
		[FormerlySerializedAs("ValidSkinnedMeshBoneOrderDataReference")]
		private AssetReference? editorBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		[FormerlySerializedAs("BoneOrderRemapData")]
		private List<BoneOrderRemapEntry> editorBoneOrderRemaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private readonly Dictionary<string, IReadOnlyList<byte>> boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool OOSHKGTUCWV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x81826C0", Offset = "0x8180EC0", VA = "0x1881826C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x81824C0", Offset = "0x8180CC0", VA = "0x1881824C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8182370", Offset = "0x8180B70", VA = "0x188182370")]
		private void DBBYMQIVTAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81824D0", Offset = "0x8180CD0", VA = "0x1881824D0")]
		public bool TryGetBoneOrderRemapArray(string boneOrderChecksum, [Out] IReadOnlyList<byte> remapArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8181C10", Offset = "0x8180410", VA = "0x188181C10")]
		public bool CalculateAndUpdateBoneOrderRemapArraysAtRuntime(SkinnedMeshRenderer skinnedMeshRenderer, string boneOrderChecksum, [Out] IReadOnlyList<byte> remapArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8181D40", Offset = "0x8180540", VA = "0x188181D40")]
		private void CalculateAndUpdateBoneOrderRemapArraysInternal(SkinnedMeshBoneOrderData validBoneOrderData, bool persistToAsset, SkinnedMeshRenderer skinnedMeshRenderer, string boneOrderChecksum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8182600", Offset = "0x8180E00", VA = "0x188182600")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class AvatarSkinnedMeshBoneOrderRuntimeUtils
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public struct SkinnedMeshRendererBoneData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public Transform[] Bones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public Matrix4x4[] BindPoses;
		}

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8182710", Offset = "0x8180F10", VA = "0x188182710")]
		public static IReadOnlyList<byte> DTRJNFGUVYU(AvatarSkinnedMeshBoneOrderRemapsData a, SkinnedMeshRenderer b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8182C10", Offset = "0x8181410", VA = "0x188182C10")]
		public static SkinnedMeshRendererBoneData? IRBBLKWQFGJ(AvatarSkinnedMeshBoneOrderRemapsData a, SkinnedMeshRenderer b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string STXKITMZEKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x81831D0", Offset = "0x81819D0", VA = "0x1881831D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x81836B0", Offset = "0x8181EB0", VA = "0x1881836B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x81835F0", Offset = "0x8181DF0", VA = "0x1881835F0")]
		private void ILPRDDMFTSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8183200", Offset = "0x8181A00", VA = "0x188183200")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8183260", Offset = "0x8181A60", VA = "0x188183260")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct BoneLocalInfo : IEquatable<BoneLocalInfo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public Vector3 LocalEulerAngles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public Vector3 LocalScale;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x81836C0", Offset = "0x8181EC0", VA = "0x1881836C0", Slot = "4")]
		public bool Equals(BoneLocalInfo other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8183800", Offset = "0x8182000", VA = "0x188183800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x81838B0", Offset = "0x81820B0", VA = "0x1881838B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public enum CustomAvatarItemPrivacyMode
	{
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		NeverObscured,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		AlwaysObscured,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		PrivateObscured
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class PCLHBEYKOMB
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public static readonly PCLHBEYKOMB BIGUOPIZRYA;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int TAJWLFUKIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public CustomAvatarItemPrivacyMode LZNLSGIZYRA
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300")]
			[CompilerGenerated]
			get
			{
				return default(CustomAvatarItemPrivacyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB5F310", Offset = "0xB5DB10", VA = "0x180B5F310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public PCLHBEYKOMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3014FB0", Offset = "0x30137B0", VA = "0x183014FB0")]
		public PCLHBEYKOMB(CustomAvatarItemPrivacyMode a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8186280", Offset = "0x8184A80", VA = "0x188186280")]
		public void DrawPosition(bool active, Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8186320", Offset = "0x8184B20", VA = "0x188186320")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere hemisphere, Transform parent, Vector2 normalizedUV, AnchorParamsRestrictions anchorParamsRestrictions, bool hidePositions = false, bool hideNormals = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public FitMeshPreviewGizmo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<string> RSRLMNOUXXW
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x818A300", Offset = "0x8188B00", VA = "0x18818A300")]
		public void SaveBoneOrder(SkinnedMeshRenderer skinnedMeshRenderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x818A4A0", Offset = "0x8188CA0", VA = "0x18818A4A0")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[Header("Remapping Eye Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8180650", Offset = "0x817EE50", VA = "0x188180650")]
		public void RemapFacialFeatureData(ZXLCJDEDETM faceFeatureCustomizationSettingsData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8180B30", Offset = "0x817F330", VA = "0x188180B30")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xBB3DB0", Offset = "0xBB25B0", VA = "0x180BB3DB0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x81839F0", Offset = "0x81821F0", VA = "0x1881839F0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public Vector2 LimitsUVScale;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 KABRAHPYYAN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x81849C0", Offset = "0x81831C0", VA = "0x1881849C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x7F58C90", Offset = "0x7F57490", VA = "0x187F58C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 ZLVFDIXWHKW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x81849E0", Offset = "0x81831E0", VA = "0x1881849E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7E5BB40", Offset = "0x7E5A340", VA = "0x187E5BB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 ANKMECVRQHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8184A00", Offset = "0x8183200", VA = "0x188184A00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1B59030", Offset = "0x1B57830", VA = "0x181B59030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 PNERABMCZYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x8184A20", Offset = "0x8183220", VA = "0x188184A20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x81845A0", Offset = "0x8182DA0", VA = "0x1881845A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x81845B0", Offset = "0x8182DB0", VA = "0x1881845B0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x81848A0", Offset = "0x81830A0", VA = "0x1881848A0")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x2807D60", Offset = "0x2806560", VA = "0x182807D60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x75BEE00", Offset = "0x75BD600", VA = "0x1875BEE00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x2807D80", Offset = "0x2806580", VA = "0x182807D80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1A7BD80", Offset = "0x1A7A580", VA = "0x181A7BD80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x81855E0", Offset = "0x8183DE0", VA = "0x1881855E0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8185720", Offset = "0x8183F20", VA = "0x188185720")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x818BDB0", Offset = "0x818A5B0", VA = "0x18818BDB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x818CAF0", Offset = "0x818B2F0", VA = "0x18818CAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private readonly List<XTMHCAFEIFZ<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAB4120", Offset = "0xAB2920", VA = "0x180AB4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB3A00", Offset = "0xAB2200", VA = "0x180AB3A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8185530", Offset = "0x8183D30", VA = "0x188185530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x81855A0", Offset = "0x8183DA0", VA = "0x1881855A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x81854E0", Offset = "0x8183CE0", VA = "0x1881854E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x157F390", Offset = "0x157DB90", VA = "0x18157F390")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x2827940", Offset = "0x2826140", VA = "0x182827940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8185030", Offset = "0x8183830", VA = "0x188185030")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8185170", Offset = "0x8183970", VA = "0x188185170", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x81850A0", Offset = "0x81838A0", VA = "0x1881850A0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8185250", Offset = "0x8183A50", VA = "0x188185250")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8184E20", Offset = "0x8183620", VA = "0x188184E20")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8185310", Offset = "0x8183B10", VA = "0x188185310")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		Brows
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class NWNUCVKGVGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x818A0E0", Offset = "0x81888E0", VA = "0x18818A0E0")]
		public static HUBJOIYZBOY XUDBMJLKUTM(this FaceFeatureType a, AvatarData b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class EMVQPZWRSOL : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private struct <InitializeFaceStyleAsync>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public AsyncTaskMethodBuilder<EMVQPZWRSOL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			public SymmetricalFaceFeature eyeBrow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			public EyesFaceFeature eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			public FaceFeature mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			private DisposeReminder.DisableStackTraceToken <__>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x818B510", Offset = "0x8189D10", VA = "0x18818B510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x818BD40", Offset = "0x818A540", VA = "0x18818BD40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private readonly Dictionary<string, int> QEMNRYAPWYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private bool AWOBYQZAVUK;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public List<Texture2D> ZDBGYAGXPMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public SymmetricalFaceFeature YAVEXDPMYZE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public EyesFaceFeature YPKQVRLWBQA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public FaceFeature QNVOIZLIEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAB1230", Offset = "0xAAFA30", VA = "0x180AB1230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x81840B0", Offset = "0x81828B0", VA = "0x1881840B0")]
		private static void HJCHIBYMJZC(Sprite a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x81841E0", Offset = "0x81829E0", VA = "0x1881841E0")]
		public static EMVQPZWRSOL SEIHGQKMGYE(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8183F70", Offset = "0x8182770", VA = "0x188183F70")]
		[AsyncStateMachine(typeof(<InitializeFaceStyleAsync>d__20))]
		public static Task<EMVQPZWRSOL> GMHFCENKOLB(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8184330", Offset = "0x8182B30", VA = "0x188184330")]
		private EMVQPZWRSOL(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8183AE0", Offset = "0x81822E0", VA = "0x188183AE0")]
		private void FCJBLVJCTOV(List<Sprite> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8183E80", Offset = "0x8182680", VA = "0x188183E80")]
		public bool FUVXNFIIPDO(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8183A00", Offset = "0x8182200", VA = "0x188183A00", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x81840F0", Offset = "0x81828F0", VA = "0x1881840F0")]
		public bool IsValid(bool usesModernAvatar)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8184260", Offset = "0x8182A60", VA = "0x188184260")]
		public void TSCFAESERFJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private struct <BuildFaceStyle>d__16 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			public AsyncTaskMethodBuilder<EMVQPZWRSOL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400022E")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400022F")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000230")]
			private TaskAwaiter<EMVQPZWRSOL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x818AFA0", Offset = "0x81897A0", VA = "0x18818AFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x818B4A0", Offset = "0x8189CA0", VA = "0x18818B4A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private Dictionary<FaceFeatureId, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private Dictionary<FaceFeatureId, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private Dictionary<FaceFeatureId, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private Dictionary<FaceFeatureId, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private readonly Dictionary<FaceFeatureId, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private EMVQPZWRSOL _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool TQLQYRTWOUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8186130", Offset = "0x8184930", VA = "0x188186130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8185940", Offset = "0x8184140", VA = "0x188185940")]
		public EMVQPZWRSOL CreateOrGetDefaultFaceStyle(AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8185810", Offset = "0x8184010", VA = "0x188185810")]
		[AsyncStateMachine(typeof(<BuildFaceStyle>d__16))]
		public Task<EMVQPZWRSOL> BuildFaceStyle(int? eyeBrows, int eye, int mouth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8185F10", Offset = "0x8184710", VA = "0x188185F10")]
		public NoseFaceOption GetNoseFaceOption(int noseIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8185D90", Offset = "0x8184590", VA = "0x188185D90")]
		public SelectableFaceOption GetFeature(FaceFeatureType featureType, FaceFeatureId faceFeatureId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8185D10", Offset = "0x8184510", VA = "0x188185D10")]
		public int GetFeatureIndex(FaceFeatureId faceFeatureId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8185A00", Offset = "0x8184200", VA = "0x188185A00")]
		private void EABNPWYMKOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x36B49A0", Offset = "0x36B31A0", VA = "0x1836B49A0")]
		private void PHNLGNXLILD<a>(IDictionary<FaceFeatureId, a> a, IReadOnlyList<a> b) where a : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8185C00", Offset = "0x8184400", VA = "0x188185C00")]
		public FaceFeatureId GetDefaultFaceOptionId(FaceFeatureType featureType)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8185FB0", Offset = "0x81847B0", VA = "0x188185FB0")]
		public FaceFeatureId GetRandomFaceOptionId(FaceFeatureType featureType)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8186160", Offset = "0x8184960", VA = "0x188186160")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8185720", Offset = "0x8183F20", VA = "0x188185720")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public NoseType SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xC12910", Offset = "0xC11110", VA = "0x180C12910")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		[SerializeField]
		private bool isNew;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public FaceFeatureId FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x163C6C0", Offset = "0x163AEC0", VA = "0x18163C6C0")]
			get
			{
				return default(FaceFeatureId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xADAAF0", Offset = "0xAD92F0", VA = "0x180ADAAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x1893680", Offset = "0x1891E80", VA = "0x181893680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x81805A0", Offset = "0x817EDA0", VA = "0x1881805A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xC12910", Offset = "0xC11110", VA = "0x180C12910")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector2 PMKNXIGCTAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x818A800", Offset = "0x8189000", VA = "0x18818A800")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x75BACC0", Offset = "0x75B94C0", VA = "0x1875BACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 GVXBNOTMFKC
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x818A820", Offset = "0x8189020", VA = "0x18818A820")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x75BACD0", Offset = "0x75B94D0", VA = "0x1875BACD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 HQPUPBXFEJH
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8094EC0", Offset = "0x80936C0", VA = "0x188094EC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x75BDF50", Offset = "0x75BC750", VA = "0x1875BDF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 CCRJGGDDKNV
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x818A840", Offset = "0x8189040", VA = "0x18818A840")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x75BDF40", Offset = "0x75BC740", VA = "0x1875BDF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x818A520", Offset = "0x8188D20", VA = "0x18818A520", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x818A730", Offset = "0x8188F30", VA = "0x18818A730")]
		protected SymmetricalFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class KSACSSLMEQT
	{
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public static readonly float SLTJTZWSSEX;

		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public static readonly float PSQFYIXOBGN;

		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public static readonly Vector2 GOZVPOYXMOE;

		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public static readonly Vector2 JHPSVFUYJHI;

		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public static readonly Vector2 IBPLACYYRRR;

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public static readonly Vector2 GEOKDAPMLZU;

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public static readonly Vector2 JEZBHAZORPS;

		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public static readonly Vector2 NDDRPXXBWYR;

		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public static readonly Vector2 KDRWULPJHCP;

		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public static readonly Vector2 GHFCDFITAER;

		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public static readonly Vector2 MDHNYNTPYNQ;

		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public static readonly Vector2 QAJPTUNIEWN;

		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public static readonly Vector2 WMULIDQMSZJ;

		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public static readonly Vector2 AWWGAJXGLIQ;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8188090", Offset = "0x8186890", VA = "0x188188090")]
		public static Vector2 LTMYTGCERHC(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x81895A0", Offset = "0x8187DA0", VA = "0x1881895A0")]
		public static float XBCJQQNSRWZ(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8186C70", Offset = "0x8185470", VA = "0x188186C70")]
		public static void ARLFTCKFONT(ZXLCJDEDETM a, AvatarConfiguration b, AvatarBodyType c, AvatarBodyType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8188D20", Offset = "0x8187520", VA = "0x188188D20")]
		public static float QZNVHLBDXGY(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8187D00", Offset = "0x8186500", VA = "0x188187D00")]
		public static float IYHZOTYIQYM(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8189790", Offset = "0x8187F90", VA = "0x188189790")]
		public static float YDAUDPTQQNM(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x81898D0", Offset = "0x81880D0", VA = "0x1881898D0")]
		public static float ZUPNCXIHCNQ(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8187430", Offset = "0x8185C30", VA = "0x188187430")]
		public static float EQURKOJAMRM(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8189450", Offset = "0x8187C50", VA = "0x188189450")]
		public static float WLNECHYRCSS(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8188BB0", Offset = "0x81873B0", VA = "0x188188BB0")]
		public static Vector2 QLQGSRXOHSC(FaceFeatureType a, Vector2 b, Vector2 c, Vector2 d, AvatarBodyType e, AvatarConfiguration f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8188750", Offset = "0x8186F50", VA = "0x188188750")]
		public static Vector2 MCXDAIZULJA(FaceFeatureType a, Vector2 b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8189960", Offset = "0x8188160", VA = "0x188189960")]
		private static Vector2 ZZYQYIVPYGR(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x81870C0", Offset = "0x81858C0", VA = "0x1881870C0")]
		private static Vector2 DYTQTZJDWGR(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8187A50", Offset = "0x8186250", VA = "0x188187A50")]
		private static Vector2 IBBYJXTTJFR(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x81890E0", Offset = "0x81878E0", VA = "0x1881890E0")]
		private static Vector2 SXGVRZXTKZH(FaceFeatureType a, Vector2 b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x81883F0", Offset = "0x8186BF0", VA = "0x1881883F0")]
		public static Vector2 MBQRTZDFSQU(FaceFeatureType a, Vector2 b, Vector2 c, Vector2 d, AvatarBodyType e, AvatarConfiguration f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8186DE0", Offset = "0x81855E0", VA = "0x188186DE0")]
		public static float BSYYQMJHCQN(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8188C80", Offset = "0x8187480", VA = "0x188188C80")]
		public static float QYXXPOPZHFT(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8188E60", Offset = "0x8187660", VA = "0x188188E60")]
		public static float RVKBSFQSVPJ(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x81889B0", Offset = "0x81871B0", VA = "0x1881889B0")]
		private static float MULVYJCNISL(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8188DB0", Offset = "0x81875B0", VA = "0x188188DB0")]
		private static Vector2 RACTJSTWJSO(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x81876B0", Offset = "0x8185EB0", VA = "0x1881876B0")]
		private static Vector2 GKHKASMFPWT(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8187760", Offset = "0x8185F60", VA = "0x188187760")]
		private static Vector2 GLBESXKMWOV(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8188F70", Offset = "0x8187770", VA = "0x188188F70")]
		private static Vector2 SPVKXRCSXAZ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8187580", Offset = "0x8185D80", VA = "0x188187580")]
		private static float FVEXXBOJSVV(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8188F00", Offset = "0x8187700", VA = "0x188188F00")]
		private static float RWZNSNRJBKV(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x81893E0", Offset = "0x8187BE0", VA = "0x1881893E0")]
		private static float WGHJRQEFSLU(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x81892B0", Offset = "0x8187AB0", VA = "0x1881892B0")]
		private static float TBGDTAVICQO(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8187990", Offset = "0x8186190", VA = "0x188187990")]
		private static Vector2 HPTIEORKNPP(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8189320", Offset = "0x8187B20", VA = "0x188189320")]
		private static Vector2 VTWYKTHOOTV(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8188A40", Offset = "0x8187240", VA = "0x188188A40")]
		private static Vector2 ORFIRAHPWBS(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8186BC0", Offset = "0x81853C0", VA = "0x188186BC0")]
		private static Vector2 ANIYGABQWTQ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8188B00", Offset = "0x8187300", VA = "0x188188B00")]
		private static Vector2 OVIKPKZZGLK(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8189020", Offset = "0x8187820", VA = "0x188189020")]
		private static Vector2 SQRKRWKESEL(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8187FD0", Offset = "0x81867D0", VA = "0x188187FD0")]
		private static Vector2 KZBGPTJQUTP(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x81894E0", Offset = "0x8187CE0", VA = "0x1881894E0")]
		private static Vector2 WTNFIMPZBYC(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8188340", Offset = "0x8186B40", VA = "0x188188340")]
		private static Vector2 LZTDWADOZOU(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8189820", Offset = "0x8188020", VA = "0x188189820")]
		private static Vector2 ZBKYXOZBSJE(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8186D20", Offset = "0x8185520", VA = "0x188186D20")]
		private static Vector2 ASALXWCJYLO(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8187D90", Offset = "0x8186590", VA = "0x188187D90")]
		private static Vector2 JBNRWPDCCVM(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8187000", Offset = "0x8185800", VA = "0x188187000")]
		private static Vector2 DNUQTRTUBTZ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x81875F0", Offset = "0x8185DF0", VA = "0x1881875F0")]
		private static Vector2 GFSPZLAQCVV(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x81878D0", Offset = "0x81860D0", VA = "0x1881878D0")]
		private static Vector2 HHQAKIYDLFD(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x81874C0", Offset = "0x8185CC0", VA = "0x1881874C0")]
		private static Vector2 EWKPTUKWVCG(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8187E50", Offset = "0x8186650", VA = "0x188187E50")]
		private static Vector2 KTGZMVJGUHC(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8187F10", Offset = "0x8186710", VA = "0x188187F10")]
		private static Vector2 KVBKACNHCAF(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8187370", Offset = "0x8185B70", VA = "0x188187370")]
		private static Vector2 EOVRYAUJEVT(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8187810", Offset = "0x8186010", VA = "0x188187810")]
		private static Vector2 HDZQJTSURBB(AvatarBodyType a, AvatarConfiguration b)
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
