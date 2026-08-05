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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8419310", Offset = "0x8418110", VA = "0x188419310")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8419250", Offset = "0x8418050", VA = "0x188419250", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8407300", Offset = "0x8406100", VA = "0x188407300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
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
		private sealed class ZPLDCYVNNAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public AvatarNoseTypeBoneData JJRVSNGAXBH;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZPLDCYVNNAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x841CEF0", Offset = "0x841BCF0", VA = "0x18841CEF0")]
			internal bool WJJIBQKCQNJ(KeyValuePair<string, Transform> a)
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
		public bool EBUTVQAGWPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x840E230", Offset = "0x840D030", VA = "0x18840E230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8409450", Offset = "0x8408250", VA = "0x188409450")]
		public void Initialize(IReadOnlyDictionary<string, Transform> boneNameMapping)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8407780", Offset = "0x8406580", VA = "0x188407780")]
		public void ApplyTransformsForFaceShape(IReadOnlyDictionary<string, Transform> boneNameMapping, AvatarFaceShapeData.BlendShapeName faceShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8407A80", Offset = "0x8406880", VA = "0x188407A80")]
		public void ApplyTransformsForNoseType(IReadOnlyDictionary<string, Transform> boneNameMapping, NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8407480", Offset = "0x8406280", VA = "0x188407480")]
		public void ApplyTransformsForBodyShape(IReadOnlyDictionary<string, Transform> boneNameMapping, AvatarBodyShapeData.BlendShapeName bodyShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8407EA0", Offset = "0x8406CA0", VA = "0x188407EA0")]
		public void ApplyTransformsForPropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<string, BoneLocalInfo> bodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8408F70", Offset = "0x8407D70", VA = "0x188408F70")]
		public IReadOnlyDictionary<string, BoneLocalInfo> GetInitialInfoForAllBones(IReadOnlyDictionary<string, Transform> boneNameMapping)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8408CB0", Offset = "0x8407AB0", VA = "0x188408CB0")]
		public Dictionary<string, BoneLocalInfo> GetCurrentBodyPropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<BodyProperty, float> bodyPropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8408D50", Offset = "0x8407B50", VA = "0x188408D50")]
		public Dictionary<string, BoneLocalInfo> GetCurrentFacePropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<FaceProperty, float> facePropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8408DF0", Offset = "0x8407BF0", VA = "0x188408DF0")]
		public Dictionary<string, BoneLocalInfo> GetCurrentNosePropertyState(IReadOnlyDictionary<string, Transform> boneNameMapping, IReadOnlyDictionary<NoseProperty, float> nosePropertyValues, IReadOnlyDictionary<string, BoneLocalInfo> boneInitialPositions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3614D40", Offset = "0x3613B40", VA = "0x183614D40")]
		private Dictionary<string, BoneLocalInfo> EVDUWKDHVEI<a>(IReadOnlyDictionary<string, Transform> a, IReadOnlyDictionary<a, float> b, IReadOnlyDictionary<string, BoneLocalInfo> c, Dictionary<a, Dictionary<string, PropertyInfluences>> d, Dictionary<(string, a, float), AvatarBodyPartBoneData> e, bool f, bool g, [Optional] float? h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8408950", Offset = "0x8407750", VA = "0x188408950")]
		public static (float, float) ComputeNoseTweakAlongCurvedSurface(float nosePositionOffset)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8408B70", Offset = "0x8407970", VA = "0x188408B70")]
		public float GetClosestBodyProperty(BodyProperty bodyProperty, float bodyPropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8408BD0", Offset = "0x84079D0", VA = "0x188408BD0")]
		public float GetClosestFaceProperty(FaceProperty faceProperty, float facePropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8408C40", Offset = "0x8407A40", VA = "0x188408C40")]
		public float GetClosestNoseProperty(NoseProperty noseProperty, float nosePropertyValue)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x36158E0", Offset = "0x36146E0", VA = "0x1836158E0")]
		private float OZRDUOZQZVT<b>(b a, float b, Dictionary<b, List<float>> c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84089E0", Offset = "0x84077E0", VA = "0x1884089E0")]
		private BoneLocalInfo GUZBXKBPKEB(IReadOnlyDictionary<string, Transform> a, string b)
		{
			return default(BoneLocalInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8409350", Offset = "0x8408150", VA = "0x188409350")]
		private float HLEWFRCKXHP(float a, List<float> b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x840C770", Offset = "0x840B570", VA = "0x18840C770")]
		private Vector3 MBCCKCQYTGV(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x840D770", Offset = "0x840C570", VA = "0x18840D770")]
		private Quaternion SLTQBPXFMKE(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x840D7D0", Offset = "0x840C5D0", VA = "0x18840D7D0")]
		private Vector3 WKBQCWOTNQM(Transform a, AvatarBodyPartBoneData b)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x840B6E0", Offset = "0x840A4E0", VA = "0x18840B6E0")]
		private void LQSVDNDAVQE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x75BFDC0", Offset = "0x75BEBC0", VA = "0x1875BFDC0")]
		public bool PropertyInfluenceContains(PropertyInfluences allInfluences, PropertyInfluences influenceToCheck)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x840C7E0", Offset = "0x840B5E0", VA = "0x18840C7E0")]
		private BoneLocalInfo QHQSZIBXHRX(PropertyInfluences a, BoneLocalInfo b, AvatarBodyPartBoneData c)
		{
			return default(BoneLocalInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84082C0", Offset = "0x84070C0", VA = "0x1884082C0")]
		public Dictionary<string, BoneLocalInfo> AverageBoneInfluencesPerProperty(Dictionary<string, BoneLocalInfo> boneLocalInfo, bool averageRotationInfluences)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x840B510", Offset = "0x840A310", VA = "0x18840B510")]
		private void KWUSTHUJWYJ(Transform a, AvatarBodyPartBoneData b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x840D990", Offset = "0x840C790", VA = "0x18840D990")]
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
		[Cpp2IlInjected.Address(RVA = "0x840E330", Offset = "0x840D130", VA = "0x18840E330", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			Pear = 1,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Apple = 2,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			Triangle = 3,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Hourglass = 4,
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			Square = 5,
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			Thin = 200
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public BlendShapeName blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[HideInInspector]
		[SerializeField]
		[Obsolete("Use BodyShapeId instead!")]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private AvatarBodyShapeData.BlendShapeName blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BodyShapeId BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x21170C0", Offset = "0x2115EC0", VA = "0x1821170C0")]
			get
			{
				return default(BodyShapeId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.BlendShapeName BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			get
			{
				return default(AvatarBodyShapeData.BlendShapeName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x840EB50", Offset = "0x840D950", VA = "0x18840EB50")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarBodyShapeData.BlendShapeName BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x840E4F0", Offset = "0x840D2F0", VA = "0x18840E4F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly Dictionary<BodyShapeId, AvatarBodyShape> QPNWWHSXPQU;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x840E650", Offset = "0x840D450", VA = "0x18840E650")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x840E970", Offset = "0x840D770", VA = "0x18840E970")]
		public AvatarBodyShape Find(BodyShapeId bodyShapeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x840EA70", Offset = "0x840D870", VA = "0x18840EA70")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x840EA30", Offset = "0x840D830", VA = "0x18840EA30")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x840EAB0", Offset = "0x840D8B0", VA = "0x18840EAB0")]
		public AvatarBodyShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class QFDIZRSLXAQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Transform[] QTSYJSZTKDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly Dictionary<string, Transform> WVRYKTXFQJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly Dictionary<Transform, Transform> OSNICSWZZMB;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyDictionary<string, Transform> QBTJGLSEMEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Transform[] WIGFENVIMCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8419690", Offset = "0x8418490", VA = "0x188419690")]
		public void JZAWBHKOVLC(Transform a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8419770", Offset = "0x8418570", VA = "0x188419770")]
		public Transform QQAGDWPTGOE(Transform a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8419850", Offset = "0x8418650", VA = "0x188419850")]
		public void TOKLWXNZFSH(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8419A90", Offset = "0x8418890", VA = "0x188419A90")]
		private static void YUPJHVCJCRP(Transform a, List<Transform> b, Dictionary<string, Transform> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8419C40", Offset = "0x8418A40", VA = "0x188419C40")]
		public QFDIZRSLXAQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class XRSHMIISFNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool MRPBFZTAWOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool YWFSJCNLNDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool LEGOYFCEOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool SAZYFVEMFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public FaceFeatureId? ZIGMLWQRBRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FUNEGHNETHP.SkinCullingMask BTVBXMCDUQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public RecRoom.Avatars.Data.Shared.HairData ZIDTNAYHUZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AdditionalHatData RVBEJNGJGPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public bool AKCJUCGSPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public bool MJSYIPJOPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public bool GYKWWVJGGQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool XQNUIRYSHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public IList<SUNXUWUPYMI> HJIDMOOLQEK;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public XRSHMIISFNG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Min/Max rotation angle for your eyebrows.")]
		public Vector2 EyebrowsRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Min/Max aspect for your eyebrows.")]
		public Vector2 EyebrowAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Min/Max rotation angle for your eyes.")]
		public Vector2 EyeRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Min/Max aspect for your eyes.")]
		public Vector2 EyeAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("Min/Max rotation angle for your mouth.")]
		public Vector2 MouthRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("Min/Max aspect for your mouth.")]
		public Vector2 MouthAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Min/Max rotation angle for your nose.")]
		public Vector2 NoseRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Min/Max aspect for your nose.")]
		public Vector2 NoseAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[Tooltip("Min uv for eyes")]
		public Vector2 EyeLimitsMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[Tooltip("Max uv for eyes")]
		public Vector2 EyeLimitsMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Header("Body Shapes")]
		public BodyShapeConfiguration BodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[Header("Face Shapes")]
		public FaceShapeConfiguration FaceShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[Header("Nose Shapes")]
		public NoseShapeConfiguration NoseShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[Header("Data Migration Managers")]
		public AvatarDataRangeMigrationsManager AvatarDataRangeMigrationsManager;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x840EBE0", Offset = "0x840D9E0", VA = "0x18840EBE0")]
		protected AvatarConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum RangeDataType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		NoseScale_FullBody,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		NoseScale_ModernBean,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		NoseVerticalPosition_FullBody,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		NoseVerticalPosition_ModernBean,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		HeadScale_FullBody,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		HeadScale_ModernBean
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct RangeMigration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public RangeDataType RangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Vector2 Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AvatarVersion Version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AvatarDataRangeMigrationsManager : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<RangeMigration> RangeMigrations;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public List<RangeMigration> BIDIZGWZJES
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class XPNOUAKISKP
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static MVJLJJVXCZY VNWYGVARJNF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x841CE90", Offset = "0x841BC90", VA = "0x18841CE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static WNXTHFATTXC TXSFCQQNFBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x841CD70", Offset = "0x841BB70", VA = "0x18841CD70")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct AvatarDisplayInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public Transform DeformRigRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public AvatarSkinAssetItem PotatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public AssetReference SkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public AssetReference TorsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public AssetReference LegsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public AssetReference TorsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public GameObject AllBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public GameObject FirstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public GameObject ThirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Material[] BodyMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Animator MainAvatarAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Renderer[] WatchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public AvatarBodyPartShapesManager AvatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public IReadOnlyDictionary<string, Transform> BoneNameMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AvatarBodyType AvatarBodyType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct AvatarDisplaySetupState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public SkinnedMeshRenderer[] CurrentThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public SkinnedMeshRenderer[] NextThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public SkinnedMeshRenderer[] CurrentFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public SkinnedMeshRenderer[] NextFirstPersonSkinnedMeshRenderers;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct AvatarFaceDisplayInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AvatarBodyType AvatarBodyType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct AvatarFaceDisplayUpdateRenderersState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public SkinnedMeshRenderer[] FaceRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public Material FaceSharedMaterial;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public struct AvatarFaceDisplayUpdateFeatureSelectionState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CTQXWZMTWKP ActiveFaceStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int LeftEyeSpriteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Color LeftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Color LeftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int RightEyeSpriteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Color RightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Color RightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int MouthSpriteIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public float MouthRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct AvatarFaceDisplayUpdateFeaturePositionsState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public CTQXWZMTWKP ActiveFaceStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Vector2 EyeBrowPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public float EyeBrowScaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public float EyeBrowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public float EyeBrowAspect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Vector2 EyePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public float EyeScaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public float EyeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public float EyeAspect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector2 NosePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public float NoseScaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public float NoseRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public float NoseAspect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Vector2 MouthPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float MouthScaleOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public float MouthRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float MouthAspect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public bool ApplyJitterToBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool NoseIsEnabled;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public FaceProperty FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public float FacePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x840F230", Offset = "0x840E030", VA = "0x18840F230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public BlendShapeName blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[HideInInspector]
		[SerializeField]
		[Obsolete("Use FaceShapeId instead!")]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private AvatarFaceShapeData.BlendShapeName blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FaceShapeId FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x21170C0", Offset = "0x2115EC0", VA = "0x1821170C0")]
			get
			{
				return default(FaceShapeId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.BlendShapeName BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xADBF60", Offset = "0xADAD60", VA = "0x180ADBF60")]
			get
			{
				return default(AvatarFaceShapeData.BlendShapeName);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x840FA50", Offset = "0x840E850", VA = "0x18840FA50", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x840FAB0", Offset = "0x840E8B0", VA = "0x18840FAB0")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AvatarFaceShapeData.BlendShapeName FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x840F3F0", Offset = "0x840E1F0", VA = "0x18840F3F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly Dictionary<FaceShapeId, AvatarFaceShape> QPNWWHSXPQU;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x840F550", Offset = "0x840E350", VA = "0x18840F550")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x840F870", Offset = "0x840E670", VA = "0x18840F870")]
		public AvatarFaceShape Find(FaceShapeId faceShapeId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x840F970", Offset = "0x840E770", VA = "0x18840F970")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x840F930", Offset = "0x840E730", VA = "0x18840F930")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x840F9B0", Offset = "0x840E7B0", VA = "0x18840F9B0")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8410100", Offset = "0x840EF00", VA = "0x188410100")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HairPatternId HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x21170C0", Offset = "0x2115EC0", VA = "0x1821170C0")]
			get
			{
				return default(HairPatternId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDAAA60", Offset = "0xDA9860", VA = "0x180DAAA60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xE9A850", Offset = "0xE99650", VA = "0x180E9A850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8410240", Offset = "0x840F040", VA = "0x188410240")]
		public Texture2D GetTexture(HairPatternStyle style)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8410180", Offset = "0x840EF80", VA = "0x188410180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8410110", Offset = "0x840EF10", VA = "0x188410110", Slot = "4")]
		public bool Equals(AvatarHairPattern other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8410390", Offset = "0x840F190", VA = "0x188410390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8410230", Offset = "0x840F030", VA = "0x188410230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8410540", Offset = "0x840F340", VA = "0x188410540")]
		public static bool operator !=(AvatarHairPattern lhs, AvatarHairPattern rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84104C0", Offset = "0x840F2C0", VA = "0x1884104C0")]
		public static bool operator ==(AvatarHairPattern lhs, AvatarHairPattern rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84103D0", Offset = "0x840F1D0", VA = "0x1884103D0")]
		public AvatarHairPattern()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public enum HandVisualState
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Invisible,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Pointing,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		ClosedFist,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		TPose,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		ThumbUp,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		HandShake,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Grabbing,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Flat,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		NumStates
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[Flags]
	public enum HandAnimationOverrideState
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		ThumbUp = 1,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Pointing = 2,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		HandShake = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct AvatarHandDisplayInitState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public Animator AvatarAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public HandType HandSidedness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AvatarConfiguration AvatarConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public GameObject WatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AvatarBodyType AvatarBodyType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct AvatarHandDisplaySetupState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Transform HandIKEffectorTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public bool IsPlayerUsingScreen;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8410570", Offset = "0x840F370", VA = "0x188410570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct ItemDefinitionBodyPart
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private bool isRoomieBodypart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private AvatarBodyPart avatarBodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private RoomieBodyPart roomieBodyPart;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly ItemDefinitionBodyPart RoomieSkinPlaceholder;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public readonly bool BKXXVHDYWDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8418DC0", Offset = "0x8417BC0", VA = "0x188418DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x543F050", Offset = "0x543DE50", VA = "0x18543F050")]
		public readonly bool WMDRWVYCIHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x30206B0", Offset = "0x301F4B0", VA = "0x1830206B0")]
		public readonly RoomieBodyPart CXMJLURFPVD()
		{
			return default(RoomieBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x207F270", Offset = "0x207E070", VA = "0x18207F270")]
		public readonly AvatarBodyPart GILHZLCRLQF()
		{
			return default(AvatarBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8418D10", Offset = "0x8417B10", VA = "0x188418D10")]
		public static ItemDefinitionBodyPart MQXQBWREQAT(RoomieBodyPart a)
		{
			return default(ItemDefinitionBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8418CF0", Offset = "0x8417AF0", VA = "0x188418CF0")]
		public static ItemDefinitionBodyPart HLJRZGUYQOD(AvatarBodyPart a)
		{
			return default(ItemDefinitionBodyPart);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8418D30", Offset = "0x8417B30", VA = "0x188418D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class SUNXUWUPYMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public string JDIPTDKIYCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public OutfitType PNUCLSNHZHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public ItemDefinitionBodyPart SJJMKNAHKMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AssetReference TPHQKFOMNNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AssetReference IYIOLGWTSUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AssetReference[] KKDSMYTLEDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public FUNEGHNETHP.SkinCullingMask DHFUVTXMFIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool AKJKEHQHKQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public bool RCATMPDPNZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public bool LZMZILVIRAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public Color? DNSGRPSOZYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public bool TEXLEXNHONR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Color? TEMYDEJPJIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool LDKAFGXDCRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public bool VVXXHSSGCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public bool RRZFPMIXGSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public Transform LKKXZWURLUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public Vector2? MUYDXZWDZYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public FitMeshHemisphere DNNWKXXYNVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public SUNXUWUPYMI DYPOKNGBOJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public bool FBWWXHRMVBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public bool TJMXLZGRWXK;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string BLVAROODRXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8419D00", Offset = "0x8418B00", VA = "0x188419D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8419D00", Offset = "0x8418B00", VA = "0x188419D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8419DB0", Offset = "0x8418BB0", VA = "0x188419DB0")]
		public SUNXUWUPYMI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private MaterialCombinationId? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CombinationId CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8410B10", Offset = "0x840F910", VA = "0x188410B10")]
			get
			{
				return default(CombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public MaterialCombinationId MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8410B40", Offset = "0x840F940", VA = "0x188410B40")]
			get
			{
				return default(MaterialCombinationId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84107F0", Offset = "0x840F5F0", VA = "0x1884107F0")]
		public Material[] GetAllMaterials()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8410600", Offset = "0x840F400", VA = "0x188410600")]
		public static void Apply(AvatarItemMaterial itemMaterial, Material material, int materialIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84108E0", Offset = "0x840F6E0", VA = "0x1884108E0")]
		private static bool NDBZDJZYOOF(AvatarItemMaterial a, int b, [Out] Material c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8410A90", Offset = "0x840F890", VA = "0x188410A90")]
		public AvatarItemMaterial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class OHEPFJXLFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public SkinnedMeshRenderer HXZNZDVVORV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private Material[] PHKCIMUPTXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private IReadOnlyList<byte> NLFWLQNCJXJ;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Mesh KOADJKQVKDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x8419520", Offset = "0x8418320", VA = "0x188419520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Material[] LWXQDVXMSII
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyList<byte> SJHADTCBQJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8419540", Offset = "0x8418340", VA = "0x188419540")]
		public OHEPFJXLFJH(SkinnedMeshRenderer a, AvatarSkinnedMeshBoneOrderRemapsData b, Material[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8419390", Offset = "0x8418190", VA = "0x188419390")]
		public static OHEPFJXLFJH FNUXKKOLWCQ(Renderer a, AvatarSkinnedMeshBoneOrderRemapsData b, Material[] c)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static PositionAndRotation GUTFKAZYITC
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x173E150", Offset = "0x173CF50", VA = "0x18173E150")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xDFA960", Offset = "0xDF9760", VA = "0x180DFA960")]
		public void Set(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class KGERQXQXJCR
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8419100", Offset = "0x8417F00", VA = "0x188419100")]
		public static PositionAndRotation SLYHIGEZALA(this PositionAndRotation a)
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8418EF0", Offset = "0x8417CF0", VA = "0x188418EF0")]
		public static float IZIYAFLZOWQ(float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8418E70", Offset = "0x8417C70", VA = "0x188418E70")]
		public static float IZIYAFLZOWQ(float a, float b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8418F90", Offset = "0x8417D90", VA = "0x188418F90")]
		public static float MCEYZAKBWNY(float a, Vector2 b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8419050", Offset = "0x8417E50", VA = "0x188419050")]
		public static float MCEYZAKBWNY(float a, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AvatarNosePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public NoseProperty NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public float NosePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8410C00", Offset = "0x840FA00", VA = "0x188410C00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarNosePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public NoseType NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8410DC0", Offset = "0x840FBC0", VA = "0x188410DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum HandGestureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Highfive = 1,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Fistbump = 2,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Handshake = 3,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		GiveTake = 4,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		OpenHand = 100,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		Point = 101,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		ThumbsUp = 102,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		ThumbsDown = 103,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		ClosedFist = 104,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		OBSOLETE_CannedWave = 1000
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum AnimationPoseType
	{
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		IdleSwayAimWeapon,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		IdleSwayMeleeWeapon,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		IdleSwayLightItem,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		IdleSwayHeavyItem,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		IdleSwayAimOneHandedWeapon,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		FastAction,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		NumTypes
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum AvatarBuildType
	{
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Inactive,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		PotatoAvatar,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		FullOutfitAvatar
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public HandLogicOffsets()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct FaceFeaturesInUVSpace
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Vector2 leftEyeBrowPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public Vector2 leftEyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Vector2 leftEyePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public Vector2 leftEyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public Vector2 leftEyeGleamPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Vector2 leftEyeGleamScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Vector2 rightEyeBrowPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Vector2 rightEyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Vector2 rightEyePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Vector2 rightEyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Vector2 rightEyeGleamPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public Vector2 rightEyeGleamScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public Vector2 noseTweakPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public Vector2 noseTweakScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public Vector2 mouthPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public Vector2 mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public float eyeRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public float eyebrowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public float noseRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public float mouthRotation;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public PositionAndRotation MouthColliderOffset;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class VECISXOUUMD
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly int BMIRWIDEHEY;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly string VMGTVSJRVVK;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x841C610", Offset = "0x841B410", VA = "0x18841C610")]
		public static AvatarDisplayInitState CIONBMDEULN(Transform a, AvatarSkinAssetItem b, AssetReference c, AssetReference d, AssetReference e, AssetReference f, GameObject g, GameObject h, GameObject i, SkinnedMeshRenderer j, AvatarSkinnedMeshBoneOrderRemapsData k, Material l, Material m, Material n, Material o, Material p, Shader q, Shader r, Animator s, Renderer[] t, AvatarConfiguration u, AvatarBodyPartShapesManager v, IReadOnlyDictionary<string, Transform> w, Transform x, AvatarBodyType y)
		{
			return default(AvatarDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x841C900", Offset = "0x841B700", VA = "0x18841C900")]
		public static AvatarDisplaySetupState DAZHYAGIKQG(SkinnedMeshRenderer[] a, SkinnedMeshRenderer[] b, SkinnedMeshRenderer[] c, SkinnedMeshRenderer[] d)
		{
			return default(AvatarDisplaySetupState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x841CAA0", Offset = "0x841B8A0", VA = "0x18841CAA0")]
		public static AvatarFaceDisplayInitState KXKKPCCKREV(Transform a, Transform b, Transform c, Transform d, Transform e, Transform f, AvatarConfiguration g, AvatarBodyType h)
		{
			return default(AvatarFaceDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A310", Offset = "0x2A79110", VA = "0x182A7A310")]
		public static AvatarFaceDisplayUpdateRenderersState HEJFLWJKKMZ(SkinnedMeshRenderer[] a, Material b)
		{
			return default(AvatarFaceDisplayUpdateRenderersState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x841CBE0", Offset = "0x841B9E0", VA = "0x18841CBE0")]
		public static AvatarFaceDisplayUpdateFeatureSelectionState RPMCNBLZGXE(CTQXWZMTWKP a, int b, Color c, Color d, int e, Color f, Color g, int h)
		{
			return default(AvatarFaceDisplayUpdateFeatureSelectionState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x841C980", Offset = "0x841B780", VA = "0x18841C980")]
		public static AvatarFaceDisplayUpdateFeaturePositionsState HFZTKHXCIOS(CTQXWZMTWKP a, Vector2 b, float c, float d, float e, Vector2 f, float g, float h, float i, Vector2 j, float k, float l, float m, Vector2 n, float o, float p, float q)
		{
			return default(AvatarFaceDisplayUpdateFeaturePositionsState);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x841CB60", Offset = "0x841B960", VA = "0x18841CB60")]
		public static AvatarHandDisplayInitState QMAMKMNMQJX(Animator a, HandType b, AvatarConfiguration c, GameObject d, AvatarBodyType e)
		{
			return default(AvatarHandDisplayInitState);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x841C5D0", Offset = "0x841B3D0", VA = "0x18841C5D0")]
		public static AvatarHandDisplaySetupState CFKSBJVJUFK(Transform a, bool b)
		{
			return default(AvatarHandDisplaySetupState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class ELCRFRFCGGR
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8413AA0", Offset = "0x84128A0", VA = "0x188413AA0")]
		public static HandVisualState GAXECLLBLTA(this HandGestureType a)
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8413A90", Offset = "0x8412890", VA = "0x188413A90")]
		public static bool CSXDMCKHDKE(this HandGestureType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public enum SkinBodyMeshType
		{
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			FaceSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			TorsoValidationMesh,
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			TorsoModestyMesh,
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			LegsModestyMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs RGWAFETZSJN
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs CVOBTKGDGBV
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs YGFCSYHATBI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BodySkinnedMeshLODs ZZWDQNGXOBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8410F20", Offset = "0x840FD20", VA = "0x188410F20")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(SkinBodyMeshType skinBodyMeshType, [Optional] FaceFeatureId? noseFaceOptionFeatureId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static readonly Log log;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		[Tooltip("If this is a runtime bone order remapper, set this property to the target bone order data. Setting this field will clear the edit-time data.")]
		private SkinnedMeshBoneOrderData? runtimeBoneOrderData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		[Tooltip("If this is an edit-time bone order remapper, set this property to the target bone order data, BUT make sure to clear the runtime bone order data first.")]
		[FormerlySerializedAs("ValidSkinnedMeshBoneOrderDataReference")]
		private AssetReference? editorBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		[FormerlySerializedAs("BoneOrderRemapData")]
		private List<BoneOrderRemapEntry> editorBoneOrderRemaps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private readonly Dictionary<string, IReadOnlyList<byte>> boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool RAQWWZBQBSN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8411B80", Offset = "0x8410980", VA = "0x188411B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8411980", Offset = "0x8410780", VA = "0x188411980")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8411830", Offset = "0x8410630", VA = "0x188411830")]
		private void LYDCQGFOMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8411990", Offset = "0x8410790", VA = "0x188411990")]
		public bool TryGetBoneOrderRemapArray(string boneOrderChecksum, [Out] IReadOnlyList<byte> remapArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x84110C0", Offset = "0x840FEC0", VA = "0x1884110C0")]
		public bool CalculateAndUpdateBoneOrderRemapArraysAtRuntime(SkinnedMeshRenderer skinnedMeshRenderer, string boneOrderChecksum, [Out] IReadOnlyList<byte> remapArray)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84111F0", Offset = "0x840FFF0", VA = "0x1884111F0")]
		private void CalculateAndUpdateBoneOrderRemapArraysInternal(SkinnedMeshBoneOrderData validBoneOrderData, bool persistToAsset, SkinnedMeshRenderer skinnedMeshRenderer, string boneOrderChecksum)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8411AC0", Offset = "0x84108C0", VA = "0x188411AC0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class AvatarSkinnedMeshBoneOrderRuntimeUtils
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public struct SkinnedMeshRendererBoneData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public Transform[] Bones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public Matrix4x4[] BindPoses;
		}

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x8411BD0", Offset = "0x84109D0", VA = "0x188411BD0")]
		public static IReadOnlyList<byte> MWLYPAGYFRW(AvatarSkinnedMeshBoneOrderRemapsData a, SkinnedMeshRenderer b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84120D0", Offset = "0x8410ED0", VA = "0x1884120D0")]
		public static SkinnedMeshRendererBoneData? SAFGULCAQOR(AvatarSkinnedMeshBoneOrderRemapsData a, SkinnedMeshRenderer b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string JMVVBVMCHTC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8412690", Offset = "0x8411490", VA = "0x188412690")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8412B80", Offset = "0x8411980", VA = "0x188412B80")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8412AC0", Offset = "0x84118C0", VA = "0x188412AC0")]
		private void DCTLUGMAEQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x84126C0", Offset = "0x84114C0", VA = "0x1884126C0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8412720", Offset = "0x8411520", VA = "0x188412720")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer renderer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public enum BodyProperty
	{
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		BicepWidth,
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		ForearmWidth,
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		ChestSize,
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		ChestOut,
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		WaistSize,
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		HipWidth,
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		NeckLength,
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		NeckThickness,
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		ThighWidth,
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		CalfWidth,
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		FootWidth,
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		FootSize,
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		ShoulderWidth,
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		BellyOut
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class AIZBVSTNHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84072A0", Offset = "0x84060A0", VA = "0x1884072A0")]
		public static bool WJNEQCJYITL(this BodyProperty a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class BodyShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[FormerlySerializedAs("BodyShapePropertyData")]
		[SerializeField]
		private List<BodyShapePropertyData> FullBodyShapePropertyData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private List<BodyShapePropertyData> ModernBeanShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8412B90", Offset = "0x8411990", VA = "0x188412B90")]
		public List<BodyShapePropertyData> AllBodyShapePropertyData(AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public BodyShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct BodyShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public AvatarBodyShapeData.BlendShapeName BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public List<BodyPropertySliderData> BodyPropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct BodyPropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public BodyProperty BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct BoneLocalInfo : IEquatable<BoneLocalInfo>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public Vector3 LocalEulerAngles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public Vector3 LocalScale;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8412BB0", Offset = "0x84119B0", VA = "0x188412BB0", Slot = "4")]
		public bool Equals(BoneLocalInfo other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8412CF0", Offset = "0x8411AF0", VA = "0x188412CF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8412DA0", Offset = "0x8411BA0", VA = "0x188412DA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public enum CustomAvatarItemPrivacyMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		NeverObscured,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		AlwaysObscured,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		PrivateObscured
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class VHIRCPVHOVD
	{
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public static readonly VHIRCPVHOVD GUTFKAZYITC;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int NLJBWITJDOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xABD110", Offset = "0xABBF10", VA = "0x180ABD110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D40", Offset = "0xAC0B40", VA = "0x180AC1D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public CustomAvatarItemPrivacyMode GJVLNMGVSXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xBBC350", Offset = "0xBBB150", VA = "0x180BBC350")]
			[CompilerGenerated]
			get
			{
				return default(CustomAvatarItemPrivacyMode);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xBBC340", Offset = "0xBBB140", VA = "0x180BBC340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public VHIRCPVHOVD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3217B70", Offset = "0x3216970", VA = "0x183217B70")]
		public VHIRCPVHOVD(CustomAvatarItemPrivacyMode a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum FaceProperty
	{
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		CheekPuff,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		JawWidth,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		JawInOut,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		ChinWidth,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		ChinSize,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		EarSize,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		EarAngle,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		HeadStretch
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class FaceShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private List<FaceShapePropertyData> FaceShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<FaceShapePropertyData> IYFSCTMYVPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public FaceShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct FaceShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AvatarFaceShapeData.BlendShapeName FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public List<FacePropertySliderData> FacePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct FacePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public FaceProperty FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84153C0", Offset = "0x84141C0", VA = "0x1884153C0")]
		public void DrawPosition(bool active, Transform transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8415460", Offset = "0x8414260", VA = "0x188415460")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere hemisphere, Transform parent, Vector2 normalizedUV, AnchorParamsRestrictions anchorParamsRestrictions, bool hidePositions = false, bool hideNormals = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xABE8C0", Offset = "0xABD6C0", VA = "0x180ABE8C0")]
		public FitMeshPreviewGizmo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public enum NoseProperty
	{
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		NoseWidth,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		NoseHeight,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		NoseLength,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		NoseAngle,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		NoseBulge,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		NosePinchFlair,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		NoseSneer,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		NoseTipScale,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		NoseScale
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class NoseShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private List<NoseShapePropertyData> NoseShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<NoseShapePropertyData> ZXHASMMNJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public NoseShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public struct NoseShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public NoseType NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public List<NosePropertySliderData> NosePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public struct NosePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public NoseProperty NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IReadOnlyList<string> TAWDOZUICLO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8419DC0", Offset = "0x8418BC0", VA = "0x188419DC0")]
		public void SaveBoneOrder(SkinnedMeshRenderer skinnedMeshRenderer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8419F60", Offset = "0x8418D60", VA = "0x188419F60")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[Header("Remapping Eye Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x840FB00", Offset = "0x840E900", VA = "0x18840FB00")]
		public void RemapFacialFeatureData(JXQFLLBFXFA faceFeatureCustomizationSettingsData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x840FFE0", Offset = "0x840EDE0", VA = "0x18840FFE0")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C9C0", VA = "0x180D3DBC0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8412EE0", Offset = "0x8411CE0", VA = "0x188412EE0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public Vector2 LimitsUVScale;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 BHHYDGEREMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8413F10", Offset = "0x8412D10", VA = "0x188413F10")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x820AC30", Offset = "0x8209A30", VA = "0x18820AC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 QHUNPIJCYDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8413F30", Offset = "0x8412D30", VA = "0x188413F30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8103CB0", Offset = "0x8102AB0", VA = "0x188103CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 FEOFFAWOXJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8413F50", Offset = "0x8412D50", VA = "0x188413F50")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xC30E60", Offset = "0xC2FC60", VA = "0x180C30E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 OVAFEOXZKIX
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x8413F70", Offset = "0x8412D70", VA = "0x188413F70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8413AF0", Offset = "0x84128F0", VA = "0x188413AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8413B00", Offset = "0x8412900", VA = "0x188413B00", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8413DF0", Offset = "0x8412BF0", VA = "0x188413DF0")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x2A0EB40", Offset = "0x2A0D940", VA = "0x182A0EB40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x78066A0", Offset = "0x78054A0", VA = "0x1878066A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x2A0EB60", Offset = "0x2A0D960", VA = "0x182A0EB60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1CC70E0", Offset = "0x1CC5EE0", VA = "0x181CC70E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8414750", Offset = "0x8413550", VA = "0x188414750", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8414890", Offset = "0x8413690", VA = "0x188414890")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x841B130", Offset = "0x8419F30", VA = "0x18841B130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x841BE70", Offset = "0x841AC70", VA = "0x18841BE70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private readonly List<NMFGCGLVGPZ<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC3ED0", VA = "0x180AC50D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAC58D0", Offset = "0xAC46D0", VA = "0x180AC58D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x84146A0", Offset = "0x84134A0", VA = "0x1884146A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8414710", Offset = "0x8413510", VA = "0x188414710")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8414650", Offset = "0x8413450", VA = "0x188414650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x17FCE00", Offset = "0x17FBC00", VA = "0x1817FCE00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2A242C0", Offset = "0x2A230C0", VA = "0x182A242C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x84141A0", Offset = "0x8412FA0", VA = "0x1884141A0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x84142E0", Offset = "0x84130E0", VA = "0x1884142E0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8414210", Offset = "0x8413010", VA = "0x188414210")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x84143C0", Offset = "0x84131C0", VA = "0x1884143C0")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8413F90", Offset = "0x8412D90", VA = "0x188413F90")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8414480", Offset = "0x8413280", VA = "0x188414480")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		Brows
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class IMFCFTUGWUE
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8418BD0", Offset = "0x84179D0", VA = "0x188418BD0")]
		public static CWRUJWGPZQY RPAPOREHUCS(this FaceFeatureType a, AvatarData b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class CTQXWZMTWKP : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct <InitializeFaceStyleAsync>d__20 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public AsyncTaskMethodBuilder<CTQXWZMTWKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public SymmetricalFaceFeature eyeBrow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public EyesFaceFeature eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			public FaceFeature mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private DisposeReminder.DisableStackTraceToken <__>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x841A890", Offset = "0x8419690", VA = "0x18841A890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x841B0C0", Offset = "0x8419EC0", VA = "0x18841B0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private readonly Dictionary<string, int> RZBZGNYBGYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private bool YVFHDGOKGSO;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public List<Texture2D> VXFHEATIZOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public SymmetricalFaceFeature WZHBWZRQFRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public EyesFaceFeature NDUVRHBBKCU
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xAC0650", Offset = "0xABF450", VA = "0x180AC0650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public FaceFeature CHVTTCKORKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8413110", Offset = "0x8411F10", VA = "0x188413110")]
		private static void HYHDJTKJCCI(Sprite a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8413400", Offset = "0x8412200", VA = "0x188413400")]
		public static CTQXWZMTWKP WYHYKVYIBME(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8412FD0", Offset = "0x8411DD0", VA = "0x188412FD0")]
		[AsyncStateMachine(typeof(<InitializeFaceStyleAsync>d__20))]
		public static Task<CTQXWZMTWKP> HGVFFVYIWSX(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8413820", Offset = "0x8412620", VA = "0x188413820")]
		private CTQXWZMTWKP(SymmetricalFaceFeature a, EyesFaceFeature b, FaceFeature c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8413480", Offset = "0x8412280", VA = "0x188413480")]
		private void YBGOLHRBMER(List<Sprite> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8413310", Offset = "0x8412110", VA = "0x188413310")]
		public bool UGSCKVTEAKA(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8412EF0", Offset = "0x8411CF0", VA = "0x188412EF0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8413150", Offset = "0x8411F50", VA = "0x188413150")]
		public bool IsValid(bool usesModernAvatar)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8413240", Offset = "0x8412040", VA = "0x188413240")]
		public void QCVSFTRJKRB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct <BuildFaceStyle>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			public AsyncTaskMethodBuilder<CTQXWZMTWKP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			private TaskAwaiter<CTQXWZMTWKP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x841A320", Offset = "0x8419120", VA = "0x18841A320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x841A820", Offset = "0x8419620", VA = "0x18841A820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private Dictionary<FaceFeatureId, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private Dictionary<FaceFeatureId, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private Dictionary<FaceFeatureId, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private Dictionary<FaceFeatureId, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private readonly Dictionary<FaceFeatureId, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private CTQXWZMTWKP _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private CTQXWZMTWKP _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool TBUMYVEKSUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8415070", Offset = "0x8413E70", VA = "0x188415070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8414AB0", Offset = "0x84138B0", VA = "0x188414AB0")]
		public CTQXWZMTWKP CreateOrGetDefaultFaceStyle(AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8414980", Offset = "0x8413780", VA = "0x188414980")]
		[AsyncStateMachine(typeof(<BuildFaceStyle>d__17))]
		public Task<CTQXWZMTWKP> BuildFaceStyle(int? eyeBrows, int eye, int mouth)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8414E50", Offset = "0x8413C50", VA = "0x188414E50")]
		public NoseFaceOption GetNoseFaceOption(int noseIndex)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8414CD0", Offset = "0x8413AD0", VA = "0x188414CD0")]
		public SelectableFaceOption GetFeature(FaceFeatureType featureType, FaceFeatureId faceFeatureId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8414C50", Offset = "0x8413A50", VA = "0x188414C50")]
		public int GetFeatureIndex(FaceFeatureId faceFeatureId)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x84150A0", Offset = "0x8413EA0", VA = "0x1884150A0")]
		private void XGVVSQRQWFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x38F3910", Offset = "0x38F2710", VA = "0x1838F3910")]
		private void UFRQVTHRDJH<a>(IDictionary<FaceFeatureId, a> a, IReadOnlyList<a> b) where a : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8414B40", Offset = "0x8413940", VA = "0x188414B40")]
		public FaceFeatureId GetDefaultFaceOptionId(FaceFeatureType featureType)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8414EF0", Offset = "0x8413CF0", VA = "0x188414EF0")]
		public FaceFeatureId GetRandomFaceOptionId(FaceFeatureType featureType)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x84152A0", Offset = "0x84140A0", VA = "0x1884152A0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8414890", Offset = "0x8413690", VA = "0x188414890")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public NoseType SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		[SerializeField]
		private bool isNew;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public FaceFeatureId FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x21170C0", Offset = "0x2115EC0", VA = "0x1821170C0")]
			get
			{
				return default(FaceFeatureId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xAEBAB0", Offset = "0xAEA8B0", VA = "0x180AEBAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x1B1A460", Offset = "0x1B19260", VA = "0x181B1A460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x840FA50", Offset = "0x840E850", VA = "0x18840FA50", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xD53CD0", Offset = "0xD52AD0", VA = "0x180D53CD0")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 MJCVOSYWEEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83439E0", Offset = "0x83427E0", VA = "0x1883439E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7802590", Offset = "0x7801390", VA = "0x187802590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 XLNUUQQYXNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x841A2E0", Offset = "0x84190E0", VA = "0x18841A2E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x78025A0", Offset = "0x78013A0", VA = "0x1878025A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 QUKJIXKDPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x841A2C0", Offset = "0x84190C0", VA = "0x18841A2C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7805800", Offset = "0x7804600", VA = "0x187805800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Vector2 FSRLJIDMYOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x841A300", Offset = "0x8419100", VA = "0x18841A300")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x78057F0", Offset = "0x78045F0", VA = "0x1878057F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8419FE0", Offset = "0x8418DE0", VA = "0x188419FE0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x841A1F0", Offset = "0x8418FF0", VA = "0x18841A1F0")]
		protected SymmetricalFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class HRSJWARAODB
	{
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public static readonly float FOHEBSZDKSP;

		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public static readonly float FSFMYFBFPLH;

		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public static readonly Vector2 DZLEKFWPAHW;

		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public static readonly Vector2 YOKPJHDUMCS;

		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public static readonly Vector2 KTWGZBZRMXN;

		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public static readonly Vector2 DUGTPTEFXIS;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public static readonly Vector2 TLHWSEMLUXC;

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public static readonly Vector2 QHTXNRLMXJH;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public static readonly Vector2 NABWJFUOSWX;

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public static readonly Vector2 SZRRJJJWGCB;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public static readonly Vector2 OZUTXBSAXQC;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public static readonly Vector2 SIJOUSPMOYV;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public static readonly Vector2 HOJIGCRKNKP;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public static readonly Vector2 KLVJDYCTFVS;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8417D30", Offset = "0x8416B30", VA = "0x188417D30")]
		public static Vector2 PFRGCYGVTEU(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x84176A0", Offset = "0x84164A0", VA = "0x1884176A0")]
		public static float MFDWATHTVEB(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x84183A0", Offset = "0x84171A0", VA = "0x1884183A0")]
		public static void WXTMBWFQPLX(JXQFLLBFXFA a, AvatarConfiguration b, AvatarBodyType c, AvatarBodyType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8415D00", Offset = "0x8414B00", VA = "0x188415D00")]
		public static float CIKGCAIUAKQ(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8417610", Offset = "0x8416410", VA = "0x188417610")]
		public static float LUXIXOECLME(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8415BB0", Offset = "0x84149B0", VA = "0x188415BB0")]
		public static float BQLOVVHXINA(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8417950", Offset = "0x8416750", VA = "0x188417950")]
		public static float NDVCQODNNYC(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8416E80", Offset = "0x8415C80", VA = "0x188416E80")]
		public static float JRRFAABHXLQ(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8417580", Offset = "0x8416380", VA = "0x188417580")]
		public static float LTTQDBKPBLI(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8418520", Offset = "0x8417320", VA = "0x188418520")]
		public static Vector2 XQPKHCNTYUO(FaceFeatureType a, Vector2 b, Vector2 c, Vector2 d, AvatarBodyType e, AvatarConfiguration f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8417040", Offset = "0x8415E40", VA = "0x188417040")]
		public static Vector2 KOCKIHQWWRQ(FaceFeatureType a, Vector2 b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x84187B0", Offset = "0x84175B0", VA = "0x1884187B0")]
		private static Vector2 ZSQUDHFUWTT(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8416060", Offset = "0x8414E60", VA = "0x188416060")]
		private static Vector2 EGOHROLIPTX(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x84179E0", Offset = "0x84167E0", VA = "0x1884179E0")]
		private static Vector2 NOXWEGQARGL(FaceFeatureType a, AvatarBodyType b, AvatarConfiguration c)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8416490", Offset = "0x8415290", VA = "0x188416490")]
		private static Vector2 GCFQGMOHPIJ(FaceFeatureType a, Vector2 b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x84167E0", Offset = "0x84155E0", VA = "0x1884167E0")]
		public static Vector2 GTRCYTSNHTG(FaceFeatureType a, Vector2 b, Vector2 c, Vector2 d, AvatarBodyType e, AvatarConfiguration f)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8415D90", Offset = "0x8414B90", VA = "0x188415D90")]
		public static float DNVLFCMXNOB(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x8417C90", Offset = "0x8416A90", VA = "0x188417C90")]
		public static float OWYEZWARRYJ(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8418710", Offset = "0x8417510", VA = "0x188418710")]
		public static float YODXAMBCYDJ(FaceFeatureType a, float b, AvatarBodyType c, AvatarConfiguration d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8415A60", Offset = "0x8414860", VA = "0x188415A60")]
		private static float ATAVZXTYWNR(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x84185F0", Offset = "0x84173F0", VA = "0x1884185F0")]
		private static Vector2 XTPBSWWXYGG(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8416D10", Offset = "0x8415B10", VA = "0x188416D10")]
		private static Vector2 HNSYTVGETAT(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x84172A0", Offset = "0x84160A0", VA = "0x1884172A0")]
		private static Vector2 LIUIKIOLRRP(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x8416C60", Offset = "0x8415A60", VA = "0x188416C60")]
		private static Vector2 HMYZHWRXXLP(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x84186A0", Offset = "0x84174A0", VA = "0x1884186A0")]
		private static float YDIHTJIYCKX(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8417FE0", Offset = "0x8416DE0", VA = "0x188417FE0")]
		private static float QSGWGNRYFXH(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8416F10", Offset = "0x8415D10", VA = "0x188416F10")]
		private static float JZLVHZAUCPY(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8418110", Offset = "0x8416F10", VA = "0x188418110")]
		private static float SJMYJUMLYDE(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8418910", Offset = "0x8417710", VA = "0x188418910")]
		private static Vector2 ZTWTFQSSWAF(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8418180", Offset = "0x8416F80", VA = "0x188418180")]
		private static Vector2 UOUAWXTIMAH(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8416F80", Offset = "0x8415D80", VA = "0x188416F80")]
		private static Vector2 KDTAMVKHOVO(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x84182F0", Offset = "0x84170F0", VA = "0x1884182F0")]
		private static Vector2 WPXAENDJCSG(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8415FB0", Offset = "0x8414DB0", VA = "0x188415FB0")]
		private static Vector2 DWHVUXJMWKI(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8416660", Offset = "0x8415460", VA = "0x188416660")]
		private static Vector2 GGJPEPMDMPB(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8416720", Offset = "0x8415520", VA = "0x188416720")]
		private static Vector2 GIHQNOAJWSF(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84159A0", Offset = "0x84147A0", VA = "0x1884159A0")]
		private static Vector2 AQROJVZKTIG(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8417410", Offset = "0x8416210", VA = "0x188417410")]
		private static Vector2 LPTAKKSRCHS(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8418240", Offset = "0x8417040", VA = "0x188418240")]
		private static Vector2 VTQLKQXJRXY(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8418460", Offset = "0x8417260", VA = "0x188418460")]
		private static Vector2 XCUBPYMTNLW(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8415C40", Offset = "0x8414A40", VA = "0x188415C40")]
		private static Vector2 BXUMOTCEHJU(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x84163D0", Offset = "0x84151D0", VA = "0x1884163D0")]
		private static Vector2 FTMLIIPTVZR(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8417350", Offset = "0x8416150", VA = "0x188417350")]
		private static Vector2 LOLDHOTTQNB(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x84174C0", Offset = "0x84162C0", VA = "0x1884174C0")]
		private static Vector2 LRDOOLWLHCF(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8416310", Offset = "0x8415110", VA = "0x188416310")]
		private static Vector2 EXHTJLSVVTQ(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8418050", Offset = "0x8416E50", VA = "0x188418050")]
		private static Vector2 RYSXQENZTII(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8417890", Offset = "0x8416690", VA = "0x188417890")]
		private static Vector2 MNYOUBNLANX(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8415AF0", Offset = "0x84148F0", VA = "0x188415AF0")]
		private static Vector2 ATGMIBERRBT(AvatarBodyType a, AvatarConfiguration b)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8416DC0", Offset = "0x8415BC0", VA = "0x188416DC0")]
		private static Vector2 IYWOXDGDSDF(AvatarBodyType a, AvatarConfiguration b)
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
