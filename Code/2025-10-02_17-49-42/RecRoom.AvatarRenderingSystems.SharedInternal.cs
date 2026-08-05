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
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Avatars.Face;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8379740", Offset = "0x8378140", VA = "0x188379740")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_SharedInternal
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8375C10", Offset = "0x8374610", VA = "0x188375C10", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83647E0", Offset = "0x83631E0", VA = "0x1883647E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
		public AvatarFaceShapeData.JNEPACCKGPD FaceShapeName;

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
		public AvatarBodyShapeData.FEJDKIDOGBI BodyShapeName;

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
		public AJEJOKPMFDJ BodyProperty;

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
		public KPABGEBMFHP FaceProperty;

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
		public KFBADBLPJDD NoseProperty;

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
		public EJOAHECBEFE NoseType;

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
		public AJEJOKPMFDJ BodyProperty;

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
		public KPABGEBMFHP FaceProperty;

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
		public KFBADBLPJDD NoseProperty;

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
		public FEOHNMCDHMD PropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Flags]
public enum FEOHNMCDHMD
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
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class JIGGGENBAAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public JIGGGENBAAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8374C90", Offset = "0x8373690", VA = "0x188374C90")]
			internal bool GMONLIDBKBO(KeyValuePair<string, Transform> bone)
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
		private List<AvatarFaceShapeData.JNEPACCKGPD> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private List<AvatarBodyShapeData.FEJDKIDOGBI> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Dictionary<AJEJOKPMFDJ, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private Dictionary<KPABGEBMFHP, List<float>> facePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Dictionary<KFBADBLPJDD, List<float>> nosePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<(string, AvatarFaceShapeData.JNEPACCKGPD), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<(string, AvatarBodyShapeData.FEJDKIDOGBI), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<(string, EJOAHECBEFE), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<(string, AJEJOKPMFDJ, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Dictionary<AJEJOKPMFDJ, Dictionary<string, FEOHNMCDHMD>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Dictionary<(string, KPABGEBMFHP, float), AvatarBodyPartBoneData> facePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Dictionary<KPABGEBMFHP, Dictionary<string, FEOHNMCDHMD>> facePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly Dictionary<(string, KFBADBLPJDD, float), AvatarBodyPartBoneData> nosePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly Dictionary<KFBADBLPJDD, Dictionary<string, FEOHNMCDHMD>> nosePropertyBoneInfluenceInfoMapping;

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
		private readonly Dictionary<AJEJOKPMFDJ, string[]> bonesToUpdatePerBodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Dictionary<KPABGEBMFHP, string[]> bonesToUpdatePerFaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly Dictionary<KFBADBLPJDD, string[]> bonesToUpdatePerNoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Dictionary<string, Dictionary<FEOHNMCDHMD, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x836BA40", Offset = "0x836A440", VA = "0x18836BA40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8366C90", Offset = "0x8365690", VA = "0x188366C90")]
		public void GFALNPPLGKO(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8369950", Offset = "0x8368350", VA = "0x188369950")]
		public void LMFCHAODHCA(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, AvatarFaceShapeData.JNEPACCKGPD ACPFNMCKDKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83691E0", Offset = "0x8367BE0", VA = "0x1883691E0")]
		public void HKMOADDBJFD(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, EJOAHECBEFE PMEKGOFHJPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8366530", Offset = "0x8364F30", VA = "0x188366530")]
		public void EBFJHBCOIMF(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, AvatarBodyShapeData.FEJDKIDOGBI LFOIALMAMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8368D60", Offset = "0x8367760", VA = "0x188368D60")]
		public void GOFLLBHBEGK(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, IReadOnlyDictionary<string, KBGJKKGMBIG> LCEMCKNCMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83668A0", Offset = "0x83652A0", VA = "0x1883668A0")]
		public IReadOnlyDictionary<string, KBGJKKGMBIG> GELGDIIAMFL(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8365100", Offset = "0x8363B00", VA = "0x188365100")]
		public Dictionary<string, KBGJKKGMBIG> AOAOHLDFAAE(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, IReadOnlyDictionary<AJEJOKPMFDJ, float> LAGKJKGNMAE, IReadOnlyDictionary<string, KBGJKKGMBIG> PEEGBBBPOFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x836AD10", Offset = "0x8369710", VA = "0x18836AD10")]
		public Dictionary<string, KBGJKKGMBIG> NHLCOJCKDEO(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, IReadOnlyDictionary<KPABGEBMFHP, float> CDDDIHOLJJN, IReadOnlyDictionary<string, KBGJKKGMBIG> PEEGBBBPOFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83651A0", Offset = "0x8363BA0", VA = "0x1883651A0")]
		public Dictionary<string, KBGJKKGMBIG> BHGOAICLMBF(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, IReadOnlyDictionary<KFBADBLPJDD, float> MJAEDDONIKP, IReadOnlyDictionary<string, KBGJKKGMBIG> PEEGBBBPOFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B1DAE0", Offset = "0x3B1C4E0", VA = "0x183B1DAE0")]
		private Dictionary<string, KBGJKKGMBIG> GKOAGDPJPFJ<T>(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, IReadOnlyDictionary<T, float> IBKKHCNMCBN, IReadOnlyDictionary<string, KBGJKKGMBIG> OGBBODFNLPH, Dictionary<T, Dictionary<string, FEOHNMCDHMD>> EEBPHHIGIBB, Dictionary<(string, T, float), AvatarBodyPartBoneData> CFGCMNCJABD, bool LECGBKKLFPO, bool LAPMFMCKLFD, [Optional] float? AMFNEAIHAIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83696D0", Offset = "0x83680D0", VA = "0x1883696D0")]
		public static (float, float) KGMPGCIOAJG(float LFEHBHHBHAI)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8369180", Offset = "0x8367B80", VA = "0x188369180")]
		public float HGODOGBCHBK(AJEJOKPMFDJ KEGEFGDLPMG, float LLGLLLDLMDB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8369660", Offset = "0x8368060", VA = "0x188369660")]
		public float JMBAOPJGHAC(KPABGEBMFHP BEDDMIIBLAD, float DEGMIAGDEBC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83698E0", Offset = "0x83682E0", VA = "0x1883698E0")]
		public float LIGJFADPODE(KFBADBLPJDD LOKOOJAOCIA, float ELKFBJEMCOB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3B1EF60", Offset = "0x3B1D960", VA = "0x183B1EF60")]
		private float OCHPJFFNNJL<T>(T ELEBIIGLBPL, float PJGKFJLKNCK, Dictionary<T, List<float>> ECIIJPDBALP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8369760", Offset = "0x8368160", VA = "0x188369760")]
		private KBGJKKGMBIG LGNMKJLHKKJ(IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, string JFCAGHAKKFM)
		{
			return default(KBGJKKGMBIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8364970", Offset = "0x8363370", VA = "0x188364970")]
		private float ALMOJJPMFHF(float KMAFNKGMDCF, List<float> BPAMJPLNGMI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8366830", Offset = "0x8365230", VA = "0x188366830")]
		private Vector3 GDIIGLCFDGJ(Transform GOOKJAPFHOF, AvatarBodyPartBoneData PBDFDJKGFHE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8369600", Offset = "0x8368000", VA = "0x188369600")]
		private Quaternion JDHINBIEJCA(Transform GOOKJAPFHOF, AvatarBodyPartBoneData PBDFDJKGFHE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x836ADB0", Offset = "0x83697B0", VA = "0x18836ADB0")]
		private Vector3 PCOHHCJAJAI(Transform GOOKJAPFHOF, AvatarBodyPartBoneData PBDFDJKGFHE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8369C50", Offset = "0x8368650", VA = "0x188369C50")]
		private void LOGBBJIHKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7480520", Offset = "0x747EF20", VA = "0x187480520")]
		public bool HCMGLFHFLGD(FEOHNMCDHMD KCBKGGLIFDJ, FEOHNMCDHMD ILOACJGLHHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83654F0", Offset = "0x8363EF0", VA = "0x1883654F0")]
		private KBGJKKGMBIG DMMJNNABDNK(FEOHNMCDHMD CLAAMKGCJDH, KBGJKKGMBIG GOOKJAPFHOF, AvatarBodyPartBoneData PBDFDJKGFHE)
		{
			return default(KBGJKKGMBIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8364A70", Offset = "0x8363470", VA = "0x188364A70")]
		public Dictionary<string, KBGJKKGMBIG> AMDBFDCKBBN(Dictionary<string, KBGJKKGMBIG> EHNKNPGLGBI, bool LECGBKKLFPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8365320", Offset = "0x8363D20", VA = "0x188365320")]
		private void BIHDCMMJNME(Transform GOOKJAPFHOF, AvatarBodyPartBoneData PBDFDJKGFHE, bool AEFIEMJJBKN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x836B090", Offset = "0x8369A90", VA = "0x18836B090")]
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
		public AJEJOKPMFDJ BodyProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x836BB40", Offset = "0x836A540", VA = "0x18836BB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum FEJDKIDOGBI
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
		public FEJDKIDOGBI blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
		[Obsolete("Use BodyShapeId instead!")]
		[SerializeField]
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
		private AvatarBodyShapeData.FEJDKIDOGBI blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KIAKNBOHMJA BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2161E00", Offset = "0x2160800", VA = "0x182161E00")]
			get
			{
				return default(KIAKNBOHMJA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.FEJDKIDOGBI BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
			get
			{
				return default(AvatarBodyShapeData.FEJDKIDOGBI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x836C5E0", Offset = "0x836AFE0", VA = "0x18836C5E0")]
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
		public AvatarBodyShapeData.FEJDKIDOGBI BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x836BE50", Offset = "0x836A850", VA = "0x18836BE50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly Dictionary<KIAKNBOHMJA, AvatarBodyShape> PCKOEBEHNID;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x836C0C0", Offset = "0x836AAC0", VA = "0x18836C0C0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x836C3E0", Offset = "0x836ADE0", VA = "0x18836C3E0")]
		public AvatarBodyShape Find(KIAKNBOHMJA KPPJENDBNHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x836C4F0", Offset = "0x836AEF0", VA = "0x18836C4F0")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x836C4B0", Offset = "0x836AEB0", VA = "0x18836C4B0")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x836C530", Offset = "0x836AF30", VA = "0x18836C530")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GFHFHNCPDEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Transform[] DOCCCKNBADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly Dictionary<string, Transform> JJEDOBJAAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly Dictionary<Transform, Transform> KGCONAGCCIA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> PPGAKDMEKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] DCOIPLOONEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8373D90", Offset = "0x8372790", VA = "0x188373D90")]
	public void GKNNGDBBDJO(Transform JFELFPLKKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8373B50", Offset = "0x8372550", VA = "0x188373B50")]
	public Transform BACKOJIEABO(Transform GALOPGPCLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8373E70", Offset = "0x8372870", VA = "0x188373E70")]
	public void LEBBGCAKPKO(SkinnedMeshRenderer JGIHOKFFJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8373C30", Offset = "0x8372630", VA = "0x188373C30")]
	private static void DEFBMIONDEA(Transform FAIGKPPBFHA, List<Transform> IDHPHJINHBB, Dictionary<string, Transform> IEAPDEBOPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83740B0", Offset = "0x8372AB0", VA = "0x1883740B0")]
	public GFHFHNCPDEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class EHBONEDLEEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool FODFMHPFAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool PPPNIJMCLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool DBMMFDBABDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public bool NNNHHNHBHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public IBNJPOEEICJ? BBJNHJOIOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public HLHFIFHEPCK.LFIDLNGOLDF EIBODNJKDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public HairData LPJLJGBPKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public AdditionalHatData MAJKHMNCJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public bool OHCJCGAAHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool AFBHHMBCKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public bool OBLOADPLFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public bool AOALOIBPEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public IList<MOJNGFFGLIG> CBHOLJJANBF;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public EHBONEDLEEG()
	{
	}
}
namespace RecRoom.Avatars
{
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
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Header("Hand Animation")]
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
		[Cpp2IlInjected.Address(RVA = "0x836C670", Offset = "0x836B070", VA = "0x18836C670")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum MCCHLKONJKI
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
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct RangeMigration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public MCCHLKONJKI RangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Vector2 Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public JPAFNFENLAC Version;
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AvatarDataRangeMigrationsManager : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<RangeMigration> RangeMigrations;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public List<RangeMigration> AllRangeMigrations
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DPAIFPNAHKL
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static JDDGLHBBGEC LBHDGIBJFIM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83700C0", Offset = "0x836EAC0", VA = "0x1883700C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static AFKHHJFHFCH NHHPINHOFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8370120", Offset = "0x836EB20", VA = "0x188370120")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct JGEMDOMHFFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Transform JDFMEEDKAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public AvatarSkinAssetItem EIFOMIGBPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public AssetReference PGANHCFFGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public AssetReference KFMOKOCIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public AssetReference GMGNNGBNLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public AssetReference BKEHHEHNAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public GameObject ALHBKBKMGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public GameObject GOGCNMLMIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public GameObject AIHJNBCAFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public SkinnedMeshRenderer GEOIMHCFDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public AvatarSkinnedMeshBoneOrderRemapsData CFBOGNEGMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Material[] HEACLLMFMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Material BMAIJMLKEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Material GHAHAOMLEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Material BMOMPHLMDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Material FNMCCAGBJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Shader EIJGMCNIBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public Shader KAFBDGPBDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public Animator ONLHHDEKJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Renderer[] HMCIKCDELNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public AvatarConfiguration OBIIHOKIEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public AvatarBodyPartShapesManager JJIFCNDAAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public IReadOnlyDictionary<string, Transform> DCCIBLBBPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform DOFLNFBFMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public BOIFAILEJMF DGBHIEOFEJM;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct GHDGLCJFLIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public SkinnedMeshRenderer[] BANAEKIGOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public SkinnedMeshRenderer[] GLNNAMOHCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public SkinnedMeshRenderer[] KDDNOJGAKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public SkinnedMeshRenderer[] NEKCLGFKPGL;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct IMLJIOJOHKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Transform BIKBDIMJKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform KGBKIFIDHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Transform KBKGCFOCIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform BONBFCGBNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Transform INKBDNGEKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform LPIPLAEGOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public AvatarConfiguration OBIIHOKIEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public BOIFAILEJMF DGBHIEOFEJM;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FOMDALKDNBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public SkinnedMeshRenderer[] KHENANNAPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Material OGAPOLEHLFK;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct BJBOKDHNHHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public FAIGKHFAAMB KJNMNIODNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int KJLJHEJAEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Color JINBPFNKHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Color NBGHFNAKNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int GGAABOIKLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public Color ILJJGHAFIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Color NFIENJHBLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public int MMCJJJDCHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public float HJPMJOFOGDG;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct EJBCBDCKDOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public FAIGKHFAAMB KJNMNIODNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector2 BDPOOJMHHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public float NHLKKFOCAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public float MMNNHHEOHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public float POEFFEGGCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Vector2 AMNKAFDNILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float LGGKCFBFDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public float IBOMOMMCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public float JABGDPANMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public Vector2 MOKOOILBGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public float NNIBEKOCOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public float FHPDPHJFJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public float GFLEPMHEKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public Vector2 EECLGCEHLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float HDEABEEOFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public float HJPMJOFOGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public float JENJJKKLOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool CPNABHAAJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool OHBKBGEGMBO;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public KPABGEBMFHP FaceProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x836CCE0", Offset = "0x836B6E0", VA = "0x18836CCE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public enum JNEPACCKGPD
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
		public JNEPACCKGPD blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[Obsolete("Use FaceShapeId instead!")]
		[HideInInspector]
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
		private AvatarFaceShapeData.JNEPACCKGPD blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HEKFPEMBJAL FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2161E00", Offset = "0x2160800", VA = "0x182161E00")]
			get
			{
				return default(HEKFPEMBJAL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.JNEPACCKGPD BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB2EC70", Offset = "0xB2D670", VA = "0x180B2EC70")]
			get
			{
				return default(AvatarFaceShapeData.JNEPACCKGPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x836D780", Offset = "0x836C180", VA = "0x18836D780", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x836D7E0", Offset = "0x836C1E0", VA = "0x18836D7E0")]
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
		public AvatarFaceShapeData.JNEPACCKGPD FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x836CFF0", Offset = "0x836B9F0", VA = "0x18836CFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly Dictionary<HEKFPEMBJAL, AvatarFaceShape> PCKOEBEHNID;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x836D260", Offset = "0x836BC60", VA = "0x18836D260")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x836D580", Offset = "0x836BF80", VA = "0x18836D580")]
		public AvatarFaceShape Find(HEKFPEMBJAL IFDLOHPDPCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x836D690", Offset = "0x836C090", VA = "0x18836D690")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x836D650", Offset = "0x836C050", VA = "0x18836D650")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x836D6D0", Offset = "0x836C0D0", VA = "0x18836D6D0")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x836DE40", Offset = "0x836C840", VA = "0x18836DE40")]
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
		public PHIEDCFFKBA HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x2161E00", Offset = "0x2160800", VA = "0x182161E00")]
			get
			{
				return default(PHIEDCFFKBA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDB85A0", Offset = "0xDB6FA0", VA = "0x180DB85A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDD31C0", Offset = "0xDD1BC0", VA = "0x180DD31C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x836DFB0", Offset = "0x836C9B0", VA = "0x18836DFB0")]
		public Texture2D INKLGALPLMC(HairPatternStyle JCCAKJLNFHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x836DEF0", Offset = "0x836C8F0", VA = "0x18836DEF0", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x836DE80", Offset = "0x836C880", VA = "0x18836DE80", Slot = "4")]
		public bool Equals(AvatarHairPattern GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x836E180", Offset = "0x836CB80", VA = "0x18836E180", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x836DFA0", Offset = "0x836C9A0", VA = "0x18836DFA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x836DE50", Offset = "0x836C850", VA = "0x18836DE50")]
		public static bool DFNINOIAFHB(AvatarHairPattern CFAKKPGMPGD, AvatarHairPattern KMGOFHJBCKL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x836E100", Offset = "0x836CB00", VA = "0x18836E100")]
		public static bool NOPNAEDOCOI(AvatarHairPattern CFAKKPGMPGD, AvatarHairPattern KMGOFHJBCKL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x836E1C0", Offset = "0x836CBC0", VA = "0x18836E1C0")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public enum DBPOEHMBPJL
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
public enum KLBMAHPKMOD
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
public struct AIKJMOJDBBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Animator FEGFNAAJGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public KGBHGNCHKEB FCFCIEKNMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public AvatarConfiguration OBIIHOKIEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public GameObject CEIHGCGMEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public BOIFAILEJMF DGBHIEOFEJM;
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct IOCHIHGNBHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Transform FFMLGGBINBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public bool PPKOKPHNMPK;
}
namespace RecRoom.Avatars
{
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
		[Cpp2IlInjected.Address(RVA = "0x836E2D0", Offset = "0x836CCD0", VA = "0x18836E2D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LMLHDPNCKKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private bool DNLPLLBJNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private EHMKAKBCPJB LJNAHBMJLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private DNOBJDOAFEC DNPLBOKDILC;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public static readonly LMLHDPNCKKH DAIOMJPGOHD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public readonly bool PLGNNBLMBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8375200", Offset = "0x8373C00", VA = "0x188375200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x83751F0", Offset = "0x8373BF0", VA = "0x1883751F0")]
	public readonly bool KENCAPCIHJI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x30A5290", Offset = "0x30A3C90", VA = "0x1830A5290")]
	public readonly DNOBJDOAFEC CLODBDENAKO()
	{
		return default(DNOBJDOAFEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x20E2620", Offset = "0x20E1020", VA = "0x1820E2620")]
	public readonly EHMKAKBCPJB KIKCMLDNAAF()
	{
		return default(EHMKAKBCPJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8375260", Offset = "0x8373C60", VA = "0x188375260")]
	public static LMLHDPNCKKH OONBNINEPKN(DNOBJDOAFEC DNPLBOKDILC)
	{
		return default(LMLHDPNCKKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x83751D0", Offset = "0x8373BD0", VA = "0x1883751D0")]
	public static LMLHDPNCKKH FAEFKLMGMML(EHMKAKBCPJB HABODLKIFCJ)
	{
		return default(LMLHDPNCKKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8375280", Offset = "0x8373C80", VA = "0x188375280", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MOJNGFFGLIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public string DDPJMHMICBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public OutfitType PCFMLOHMMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public LMLHDPNCKKH ILBGGFKMPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public AssetReference MBBGEAIJFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public AssetReference FPEALKBOJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public AssetReference[] LFAAPLKCKMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public HLHFIFHEPCK.LFIDLNGOLDF GNHMGGIJKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public bool AAPOCFLKHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public bool JCGBPCBKOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public bool AKDPDMIEAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public Color? DBGIEEMHBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public bool BFIOLNJFICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Color? NCHPGMIBDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public bool OMIHNFICIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public bool BFFOGDNGGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7A")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public bool JKNJAPJBFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public Transform DCKILEIIMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public Vector2? CAHBECNMOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public FitMeshHemisphere KDGLDLCHHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public MOJNGFFGLIG ABFGJMGLIEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public bool NHFDJNIMCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public bool GLLMIJGINJB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string ENMICGMLGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8376400", Offset = "0x8374E00", VA = "0x188376400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8376400", Offset = "0x8374E00", VA = "0x188376400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x83764B0", Offset = "0x8374EB0", VA = "0x1883764B0")]
	public MOJNGFFGLIG()
	{
	}
}
namespace RecRoom.Avatars
{
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
		private CLDEECFFPMA? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CKPKFPAKPLM CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x836E860", Offset = "0x836D260", VA = "0x18836E860")]
			get
			{
				return default(CKPKFPAKPLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public CLDEECFFPMA MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x836E890", Offset = "0x836D290", VA = "0x18836E890")]
			get
			{
				return default(CLDEECFFPMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x836E510", Offset = "0x836CF10", VA = "0x18836E510")]
		public Material[] ENPGGIPMNMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x836E5F0", Offset = "0x836CFF0", VA = "0x18836E5F0")]
		public static void NCDMGOLFLNC(AvatarItemMaterial KJIOPBMDNOO, Material PJPBFBIEGMK, int EMJCACMKDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x836E360", Offset = "0x836CD60", VA = "0x18836E360")]
		private static bool DFNNFBHLLEI(AvatarItemMaterial KJIOPBMDNOO, int EMJCACMKDGG, [Out] Material EKEAEEFKPIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x836E7E0", Offset = "0x836D1E0", VA = "0x18836E7E0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FFGDOHJPCCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public SkinnedMeshRenderer KMJKJCHOHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private Material[] AAIHGCCFBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private IReadOnlyList<byte> DPDGODFEGFH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Mesh DAMOEDIBCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8371CE0", Offset = "0x83706E0", VA = "0x188371CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public Material[] BIIGEAMAGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IReadOnlyList<byte> GCPDLEPEGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8371EA0", Offset = "0x83708A0", VA = "0x188371EA0")]
	public FFGDOHJPCCP(SkinnedMeshRenderer DDEOMDPNNBG, AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG, Material[] PCAFIIJABAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8371D00", Offset = "0x8370700", VA = "0x188371D00")]
	public static FFGDOHJPCCP JANMHGIFFFE(Renderer ALKNEOONPNG, AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG, Material[] PCAFIIJABAB)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
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
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x1764550", Offset = "0x1762F50", VA = "0x181764550")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xE114E0", Offset = "0xE0FEE0", VA = "0x180E114E0")]
		public void FNAEMEPGHFK(Vector3 KFJFDPLEJOD, Quaternion AMHDLJKDJBK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class ENMOGEPGCPO
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x83707C0", Offset = "0x836F1C0", VA = "0x1883707C0")]
	public static PositionAndRotation HBCPCCLFANO(this PositionAndRotation AMKBELOIOAA)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8370A80", Offset = "0x836F480", VA = "0x188370A80")]
	public static float JLPMLIAEMOP(float GGMLEPFJHKP, Vector2 DCPDGJMCMDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8370B20", Offset = "0x836F520", VA = "0x188370B20")]
	public static float JLPMLIAEMOP(float GGMLEPFJHKP, float EPMJNJEPCMJ, float AFLPBMPBNNJ, float JOEBEKPOHKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8370910", Offset = "0x836F310", VA = "0x188370910")]
	public static float IKIGHJBPBFA(float KMAFNKGMDCF, Vector2 DCPDGJMCMDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x83709D0", Offset = "0x836F3D0", VA = "0x1883709D0")]
	public static float IKIGHJBPBFA(float KMAFNKGMDCF, float EPMJNJEPCMJ, float AFLPBMPBNNJ, float JOEBEKPOHKM)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AvatarNosePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public KFBADBLPJDD NoseProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x836E950", Offset = "0x836D350", VA = "0x18836E950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
		public EJOAHECBEFE NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x836EC60", Offset = "0x836D660", VA = "0x18836EC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public enum ALPKJGEEHOD
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
public enum BEIAPHDGACL
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
public enum CBOHKGOBEFH
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	PotatoAvatar,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	FullOutfitAvatar
}
namespace RecRoom.Avatars
{
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
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct ENDPMHNKEKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector2 CMIOBDIGAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector2 AMLGJKEOEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector2 MMJAJMEOPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Vector2 HMGGBOHLCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public Vector2 NKHLJHNCAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public Vector2 JEOKNJPPMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public Vector2 BGDOFHILCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public Vector2 MFGHKCGJBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public Vector2 OLMCONDPFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public Vector2 PDMFLOJCILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Vector2 PCKHNIDOEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public Vector2 EEJPKBHPKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public Vector2 MDKEMAHBBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Vector2 NECFCPFLGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public Vector2 EGPFBBFDMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public Vector2 PDGLCJLEAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public float FOGFKDHONMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public float FICCEJHOCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public float EGEJEMDJKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public float AFPIGADLEHD;
}
namespace RecRoom.Avatars
{
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
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class MEFGCNDGCFE
{
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static readonly int OAJLJKIMPOC;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static readonly string LEMBPLEPKAI;

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8375F70", Offset = "0x8374970", VA = "0x188375F70")]
	public static JGEMDOMHFFG MOEEIPFJKEO(Transform PEJKDLCNJGC, AvatarSkinAssetItem BCDDCOIIGOE, AssetReference NGJGPEPHCAD, AssetReference HAJKJNHGKLI, AssetReference HGEMLMMAMCN, AssetReference ENIAGDKDHLN, GameObject JMHEEPJCGNN, GameObject GHDLFHKPFBL, GameObject HMLMBIDNNCG, SkinnedMeshRenderer KOMEJGBGJLA, AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG, Material EDLFKNABFEL, Material IGKILDAPMCG, Material LDKHNMICAEO, Material NKHIOOCDDII, Material KBJDDKBEPLC, Shader EJANHACCBJH, Shader KEGLONAOMID, Animator IBFJBPPKOLK, Renderer[] PJGJLBBPNDG, AvatarConfiguration JMNPDPKGBHB, AvatarBodyPartShapesManager PLODPAAJOLK, IReadOnlyDictionary<string, Transform> ODHHGHDJNCI, Transform DNHKMMPDPGP, BOIFAILEJMF FJBHHBODDIK)
	{
		return default(JGEMDOMHFFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8375EF0", Offset = "0x83748F0", VA = "0x188375EF0")]
	public static GHDGLCJFLIP MNDGIINBBLP(SkinnedMeshRenderer[] PJFHIPBKKJE, SkinnedMeshRenderer[] OBDKMBLONMG, SkinnedMeshRenderer[] MHKANMFEFAO, SkinnedMeshRenderer[] ALBHAADPFLB)
	{
		return default(GHDGLCJFLIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8375D70", Offset = "0x8374770", VA = "0x188375D70")]
	public static IMLJIOJOHKL HBNBJMJDLEN(Transform NDKPCPDEMJB, Transform MAHNOAHJMDC, Transform NAHKFKGNJDC, Transform OJBJLDJCDAH, Transform CMKJAMAEMBC, Transform MHDBEFJBOPE, AvatarConfiguration OEPEIJIAHEB, BOIFAILEJMF FJBHHBODDIK)
	{
		return default(IMLJIOJOHKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x2AED0A0", Offset = "0x2AEBAA0", VA = "0x182AED0A0")]
	public static FOMDALKDNBC COBEEDOFADO(SkinnedMeshRenderer[] IEIAHPPPOMD, Material NENEFLFLLAD)
	{
		return default(FOMDALKDNBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x8375CE0", Offset = "0x83746E0", VA = "0x188375CE0")]
	public static BJBOKDHNHHN CMDCDCAMICP(FAIGKHFAAMB NKHIEALNOFJ, int KEPGPPCBJLF, Color JGAGHBLKOPP, Color FLIOALELAEM, int BDMMGEKBBHB, Color CLBPCJOAIEJ, Color BEJIILFGOCH, int HBJMGKAMMNK)
	{
		return default(BJBOKDHNHHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x8376260", Offset = "0x8374C60", VA = "0x188376260")]
	public static EJBCBDCKDOK NJFOOOAMMDB(FAIGKHFAAMB NKHIEALNOFJ, Vector2 JIEJIPMNBFK, float IOANAMJLBKK, float LIPENDMMHHC, float MJBEOPEHKDG, Vector2 CIADENGCMLA, float JNIKECPCJIB, float FOGFKDHONMH, float NDMKJFNONHB, Vector2 LFEHBHHBHAI, float AFPJEDMPGHD, float EGEJEMDJKFB, float JHEOFBPPADP, Vector2 FDMEGHMJIJF, float IJLAMNCOEKA, float AFPIGADLEHD, float JJJMEDGOOOI)
	{
		return default(EJBCBDCKDOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x8375E30", Offset = "0x8374830", VA = "0x188375E30")]
	public static AIKJMOJDBBG IGNPHFCPAJH(Animator GJHCDDOAODF, KGBHGNCHKEB EGFMDKOIJIM, AvatarConfiguration JMNPDPKGBHB, GameObject NNBCPPNCJCL, BOIFAILEJMF FJBHHBODDIK)
	{
		return default(AIKJMOJDBBG);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x8375EB0", Offset = "0x83748B0", VA = "0x188375EB0")]
	public static IOCHIHGNBHC JKNEIEJEEIP(Transform FFMOAIFHNCE, bool PPLANEDHBGC)
	{
		return default(IOCHIHGNBHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GEBIAEPGDOM
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8373B00", Offset = "0x8372500", VA = "0x188373B00")]
	public static DBPOEHMBPJL PPNFGAOMJOF(this ALPKJGEEHOD BNPLDBMDKOA)
	{
		return default(DBPOEHMBPJL);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8373AF0", Offset = "0x83724F0", VA = "0x188373AF0")]
	public static bool CHHHGMAKONN(this ALPKJGEEHOD BLJLIKHIKGD)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public enum DJOECECCENC
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs ODBLBFCBMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs FKJDNINLGKE
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs AGJBFNCCJKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public BodySkinnedMeshLODs JCCFINJIKHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x836EED0", Offset = "0x836D8D0", VA = "0x18836EED0")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(DJOECECCENC FLAFGBFIKNL, [Optional] IBNJPOEEICJ? AHPHBJPHKAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[Tooltip("If this is a runtime bone order remapper, set this property to the target bone order data. Setting this field will clear the edit-time data.")]
		[SerializeField]
		private SkinnedMeshBoneOrderData? runtimeBoneOrderData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[FormerlySerializedAs("ValidSkinnedMeshBoneOrderDataReference")]
		[SerializeField]
		[Tooltip("If this is an edit-time bone order remapper, set this property to the target bone order data, BUT make sure to clear the runtime bone order data first.")]
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
		public bool CanCalculateAndUpdateBoneOrderRemapArraysAtRuntime
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x836FB50", Offset = "0x836E550", VA = "0x18836FB50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x836F9A0", Offset = "0x836E3A0", VA = "0x18836F9A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x836F070", Offset = "0x836DA70", VA = "0x18836F070")]
		private void BAPAFLJCMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x836F1C0", Offset = "0x836DBC0", VA = "0x18836F1C0")]
		public bool BJIGIMOMDGJ(string IEGIAODIHOD, [Out] IReadOnlyList<byte> IGFFAABIBLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x836F860", Offset = "0x836E260", VA = "0x18836F860")]
		public bool OBDAEPBEIIJ(SkinnedMeshRenderer JGIHOKFFJPJ, string IEGIAODIHOD, [Out] IReadOnlyList<byte> IGFFAABIBLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x836F230", Offset = "0x836DC30", VA = "0x18836F230")]
		private void GCLJGLOEDFC(SkinnedMeshBoneOrderData FPEBLCDKNGL, bool EGEHOHBKGJF, SkinnedMeshRenderer JGIHOKFFJPJ, string IEGIAODIHOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x836FA80", Offset = "0x836E480", VA = "0x18836FA80")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class JGILOGEHPIM
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct FNJGHOEKHGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public Transform[] DCOIPLOONEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public Matrix4x4[] PNCIGDCCGBK;
	}

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x83746C0", Offset = "0x83730C0", VA = "0x1883746C0")]
	public static IReadOnlyList<byte> PPNGOIDMBGD(AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG, SkinnedMeshRenderer JGIHOKFFJPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x8374180", Offset = "0x8372B80", VA = "0x188374180")]
	public static FNJGHOEKHGH? KFCPBJFOMKH(AvatarSkinnedMeshBoneOrderRemapsData MFHAMCLBKLG, SkinnedMeshRenderer JGIHOKFFJPJ)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	[DisallowMultipleComponent]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string JHNFDMDNJPG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x836FBA0", Offset = "0x836E5A0", VA = "0x18836FBA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8370080", Offset = "0x836EA80", VA = "0x188370080")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x836FFC0", Offset = "0x836E9C0", VA = "0x18836FFC0")]
		private void JKJEBPBIKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x836FBD0", Offset = "0x836E5D0", VA = "0x18836FBD0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x836FC30", Offset = "0x836E630", VA = "0x18836FC30")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer ALKNEOONPNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public enum AJEJOKPMFDJ
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
public static class OCFCAGHJFNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x83797C0", Offset = "0x83781C0", VA = "0x1883797C0")]
	public static bool CAIINFJPPJG(this AJEJOKPMFDJ KEGEFGDLPMG)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
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
		[Cpp2IlInjected.Address(RVA = "0x8370090", Offset = "0x836EA90", VA = "0x188370090")]
		public List<BodyShapePropertyData> JHFOJPLBGKE(BOIFAILEJMF FJBHHBODDIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
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
		public AvatarBodyShapeData.FEJDKIDOGBI BodyShapeName;

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
		public AJEJOKPMFDJ BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public struct KBGJKKGMBIG : IEquatable<KBGJKKGMBIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public string PCNCENGMKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public Vector3 DMEKCHJJJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public Vector3 LAKPFFKFBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public Vector3 EGNLLOCNMLO;

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8374E20", Offset = "0x8373820", VA = "0x188374E20", Slot = "4")]
	public bool Equals(KBGJKKGMBIG GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x8374D70", Offset = "0x8373770", VA = "0x188374D70", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8374F60", Offset = "0x8373960", VA = "0x188374F60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum OICPCOJHLDP
{
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JLDDJMHEPLP
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public static readonly JLDDJMHEPLP IIDHIFPMCOA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int ELFNHMOOKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public OICPCOJHLDP FGGECGMPEKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
		[CompilerGenerated]
		get
		{
			return default(OICPCOJHLDP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7E0", Offset = "0xBAC1E0", VA = "0x180BAD7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JLDDJMHEPLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x32A74D0", Offset = "0x32A5ED0", VA = "0x1832A74D0")]
	public JLDDJMHEPLP(OICPCOJHLDP GDIJNLEACAN, int NLCILLPPAFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum KPABGEBMFHP
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
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class FaceShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private List<FaceShapePropertyData> FaceShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public List<FaceShapePropertyData> AllFaceShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
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
		public AvatarFaceShapeData.JNEPACCKGPD FaceShapeName;

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
		public KPABGEBMFHP FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8373510", Offset = "0x8371F10", VA = "0x188373510")]
		public void DrawPosition(bool JNNEMJKMKNP, Transform HALOMIKDIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83735B0", Offset = "0x8371FB0", VA = "0x1883735B0")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere BBABBCJILCD, Transform AEMEEJKFKNN, Vector2 NGDJPCIAMAO, AnchorParamsRestrictions BMBNMGDDOMM, bool BFAONLGJOAK = false, bool AANLKBLILDL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public FitMeshPreviewGizmo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public enum KFBADBLPJDD
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
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class NoseShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private List<NoseShapePropertyData> NoseShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public List<NoseShapePropertyData> AllNoseShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
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
		public EJOAHECBEFE NoseType;

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
		public KFBADBLPJDD NoseProperty;

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
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8379820", Offset = "0x8378220", VA = "0x188379820")]
		public void GDIEPBLJGEO(SkinnedMeshRenderer JGIHOKFFJPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x83799D0", Offset = "0x83783D0", VA = "0x1883799D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x836D830", Offset = "0x836C230", VA = "0x18836D830")]
		public void CDNGGCDIJOL(EPOPAGLNOMC CDKBFENPNHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x836DD20", Offset = "0x836C720", VA = "0x18836DD20")]
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
			[Cpp2IlInjected.Address(RVA = "0xD419C0", Offset = "0xD403C0", VA = "0x180D419C0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x83700B0", Offset = "0x836EAB0", VA = "0x1883700B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8370FD0", Offset = "0x836F9D0", VA = "0x188370FD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x8176320", Offset = "0x8174D20", VA = "0x188176320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8370FF0", Offset = "0x836F9F0", VA = "0x188370FF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xC34CA0", Offset = "0xC336A0", VA = "0x180C34CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x8371010", Offset = "0x836FA10", VA = "0x188371010")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x8371030", Offset = "0x836FA30", VA = "0x188371030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2113CE0", Offset = "0x21126E0", VA = "0x182113CE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8371040", Offset = "0x836FA40", VA = "0x188371040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8370BA0", Offset = "0x836F5A0", VA = "0x188370BA0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8370EA0", Offset = "0x836F8A0", VA = "0x188370EA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2A7BC50", Offset = "0x2A7A650", VA = "0x182A7BC50")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x1D042C0", Offset = "0x1D02CC0", VA = "0x181D042C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x18261E0", Offset = "0x1824BE0", VA = "0x1818261E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x1D04100", Offset = "0x1D02B00", VA = "0x181D04100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8372850", Offset = "0x8371250", VA = "0x188372850", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8372990", Offset = "0x8371390", VA = "0x188372990")]
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
			[Cpp2IlInjected.Address(RVA = "0x8379DC0", Offset = "0x83787C0", VA = "0x188379DC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x837AA60", Offset = "0x8379460", VA = "0x18837AA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private readonly List<AACADPLMCLK<Sprite>> _spriteResourceHandles;

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
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAB4810", Offset = "0xAB3210", VA = "0x180AB4810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x83727A0", Offset = "0x83711A0", VA = "0x1883727A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8372810", Offset = "0x8371210", VA = "0x188372810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x8372730", Offset = "0x8371130", VA = "0x188372730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8372780", Offset = "0x8371180", VA = "0x188372780")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x2A98D80", Offset = "0x2A97780", VA = "0x182A98D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8372210", Offset = "0x8370C10", VA = "0x188372210")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8372350", Offset = "0x8370D50", VA = "0x188372350", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8372280", Offset = "0x8370C80", VA = "0x188372280")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8372430", Offset = "0x8370E30", VA = "0x188372430")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8372000", Offset = "0x8370A00", VA = "0x188372000")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8372530", Offset = "0x8370F30", VA = "0x188372530")]
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
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class KPONEEONHMG
{
	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x83750A0", Offset = "0x8373AA0", VA = "0x1883750A0")]
	public static NOMMIKCFBEP PHGPPPCMPFB(this FaceFeatureType OKHJLKIMLFB, DECEKEGDNPK AIFAODPNIHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class FAIGKHFAAMB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct LMLPLGHJJAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public AsyncTaskMethodBuilder<FAIGKHFAAMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private HHIPOMEIBHM.LOJCLMCGDHN <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8375370", Offset = "0x8373D70", VA = "0x188375370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8375BA0", Offset = "0x83745A0", VA = "0x188375BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private readonly Dictionary<string, int> BJMJNGKNINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private bool NNONIHKHKAO;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public List<Texture2D> DCFINHALFPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public SymmetricalFaceFeature KNNAHMOOPMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public EyesFaceFeature OAGOMBDKPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public FaceFeature JEAHEKCPIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8371050", Offset = "0x836FA50", VA = "0x188371050")]
	private static void AJOGCPHFBPB(Sprite DGCMKKGIIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8371780", Offset = "0x8370180", VA = "0x188371780")]
	public static FAIGKHFAAMB IBGBNEMMIHL(SymmetricalFaceFeature BKHLKJFFMPC, EyesFaceFeature OGFIDCBJACA, FaceFeature GHCKKEOFFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x83710C0", Offset = "0x836FAC0", VA = "0x1883710C0")]
	[AsyncStateMachine(typeof(LMLPLGHJJAN))]
	public static Task<FAIGKHFAAMB> BEAEBLFBFID(SymmetricalFaceFeature BKHLKJFFMPC, EyesFaceFeature OGFIDCBJACA, FaceFeature GHCKKEOFFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x83719F0", Offset = "0x83703F0", VA = "0x1883719F0")]
	private FAIGKHFAAMB(SymmetricalFaceFeature BKHLKJFFMPC, EyesFaceFeature OGFIDCBJACA, FaceFeature GHCKKEOFFIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8371200", Offset = "0x836FC00", VA = "0x188371200")]
	private void BGJFJIMFNHJ(List<Sprite> GGPFMHCPOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x8371900", Offset = "0x8370300", VA = "0x188371900")]
	public bool OLMIMGBLADF(string HKIIDPABGFE, [Out] int KABGMIEBEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x83715D0", Offset = "0x836FFD0", VA = "0x1883715D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x8371810", Offset = "0x8370210", VA = "0x188371810")]
	public bool OEBGFPNJFBL(bool GFFCKIIKBLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x83716B0", Offset = "0x83700B0", VA = "0x1883716B0")]
	public void HKGMLCFANMA()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct EIEAHHHPOGC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			public AsyncTaskMethodBuilder<FAIGKHFAAMB> <>t__builder;

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
			private TaskAwaiter<FAIGKHFAAMB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8370250", Offset = "0x836EC50", VA = "0x188370250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8370750", Offset = "0x836F150", VA = "0x188370750", Slot = "5")]
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
		private Dictionary<IBNJPOEEICJ, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private Dictionary<IBNJPOEEICJ, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private Dictionary<IBNJPOEEICJ, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private Dictionary<IBNJPOEEICJ, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private readonly Dictionary<IBNJPOEEICJ, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private FAIGKHFAAMB _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private FAIGKHFAAMB _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x83734E0", Offset = "0x8371EE0", VA = "0x1883734E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x83730E0", Offset = "0x8371AE0", VA = "0x1883730E0")]
		public FAIGKHFAAMB LKFFGPNBDMI(BOIFAILEJMF FJBHHBODDIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8373170", Offset = "0x8371B70", VA = "0x188373170")]
		[AsyncStateMachine(typeof(EIEAHHHPOGC))]
		public Task<FAIGKHFAAMB> NKFCBPLHMNP(int? IFKNCADBGEB, int OGFIDCBJACA, int GHCKKEOFFIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8372D40", Offset = "0x8371740", VA = "0x188372D40")]
		public NoseFaceOption GCPKANOGIEP(int DHFLHBMDFEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8372DE0", Offset = "0x83717E0", VA = "0x188372DE0")]
		public SelectableFaceOption IKABPLGDOIH(FaceFeatureType KBFIENDMOAP, IBNJPOEEICJ PAMILKIJNPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8372A90", Offset = "0x8371490", VA = "0x188372A90")]
		public int DPNAEDJCGKB(IBNJPOEEICJ PAMILKIJNPO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8372B10", Offset = "0x8371510", VA = "0x188372B10")]
		private void EGLJOEMCOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3D94580", Offset = "0x3D92F80", VA = "0x183D94580")]
		private void JIEODFJJNPK<T>(IDictionary<IBNJPOEEICJ, T> DDMHDBLMGFA, IReadOnlyList<T> KPJDLFHGDBK) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x83732A0", Offset = "0x8371CA0", VA = "0x1883732A0")]
		public IBNJPOEEICJ NMCCLGNFOKI(FaceFeatureType KBFIENDMOAP)
		{
			return default(IBNJPOEEICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8372F60", Offset = "0x8371960", VA = "0x188372F60")]
		public IBNJPOEEICJ KDMPBEJCMEK(FaceFeatureType KBFIENDMOAP)
		{
			return default(IBNJPOEEICJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x83733B0", Offset = "0x8371DB0", VA = "0x1883733B0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x8372990", Offset = "0x8371390", VA = "0x188372990")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public EJOAHECBEFE SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xC56A80", Offset = "0xC55480", VA = "0x180C56A80", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
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
		public IBNJPOEEICJ FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2161E00", Offset = "0x2160800", VA = "0x182161E00")]
			get
			{
				return default(IBNJPOEEICJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xB041D0", Offset = "0xB02BD0", VA = "0x180B041D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x15C7D40", Offset = "0x15C6740", VA = "0x1815C7D40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
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
		[Cpp2IlInjected.Address(RVA = "0x836D780", Offset = "0x836C180", VA = "0x18836D780", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
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
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8379D40", Offset = "0x8378740", VA = "0x188379D40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x76EA580", Offset = "0x76E8F80", VA = "0x1876EA580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8379D80", Offset = "0x8378780", VA = "0x188379D80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x76EA590", Offset = "0x76E8F90", VA = "0x1876EA590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8379D60", Offset = "0x8378760", VA = "0x188379D60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x76ED930", Offset = "0x76EC330", VA = "0x1876ED930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8379DA0", Offset = "0x83787A0", VA = "0x188379DA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x76ED920", Offset = "0x76EC320", VA = "0x1876ED920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8379A60", Offset = "0x8378460", VA = "0x188379A60", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8379C70", Offset = "0x8378670", VA = "0x188379C70")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class NMLLIJCNEKP
{
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly float MDPOEFAOHLJ;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly float CIMDENDDKFI;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Vector2 BAIKJONAFNL;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Vector2 NJNEKFNOCGG;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly Vector2 HKCGLGMBPFJ;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public static readonly Vector2 NOOKEIEHGAL;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly Vector2 CGMDBGJEOCG;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public static readonly Vector2 PBFHPJCEOBI;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public static readonly Vector2 DIBIHKJFLCH;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public static readonly Vector2 AABBANAPLCB;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public static readonly Vector2 IHKGBGBPKNC;

	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public static readonly Vector2 IAICNLAGKFC;

	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public static readonly Vector2 BJPCNJKCONJ;

	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public static readonly Vector2 ALABMHOCKLC;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x8376780", Offset = "0x8375180", VA = "0x188376780")]
	public static Vector2 BGCHOGJEKKL(FaceFeatureType OKHJLKIMLFB, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x83786D0", Offset = "0x83770D0", VA = "0x1883786D0")]
	public static float LDJOHHHIPOJ(FaceFeatureType OKHJLKIMLFB, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8378B60", Offset = "0x8377560", VA = "0x188378B60")]
	public static void MJNGAFBEPLG(EPOPAGLNOMC JLPGNFFINMN, AvatarConfiguration JMNPDPKGBHB, BOIFAILEJMF DPMLLJHIDJP, BOIFAILEJMF DLIDNHDHEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8376AE0", Offset = "0x83754E0", VA = "0x188376AE0")]
	public static float CAMMGCIKKFI(FaceFeatureType KBFIENDMOAP, float PGBMHAOKGHM, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x83766F0", Offset = "0x83750F0", VA = "0x1883766F0")]
	public static float BAPJMFEGACC(FaceFeatureType KBFIENDMOAP, float HBOHCMBAGOG, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x8377030", Offset = "0x8375A30", VA = "0x188377030")]
	public static float DCJHBCCFIFA(FaceFeatureType KBFIENDMOAP, float AMHDLJKDJBK, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8378A20", Offset = "0x8377420", VA = "0x188378A20")]
	public static float LKGLKOKKNOB(FaceFeatureType KBFIENDMOAP, float DEDMEALJJPH, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x8378350", Offset = "0x8376D50", VA = "0x188378350")]
	public static float KAIBLBDBBFO(FaceFeatureType KBFIENDMOAP, float DHKENAAJMLC, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8376B70", Offset = "0x8375570", VA = "0x188376B70")]
	public static float CEADIIPEJPJ(FaceFeatureType KBFIENDMOAP, float NNIDAMGMKGG, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8379150", Offset = "0x8377B50", VA = "0x188379150")]
	public static Vector2 OILPMELADIM(FaceFeatureType KBFIENDMOAP, Vector2 FLFMNJAAFPM, Vector2 DKLKLJOGEFE, Vector2 MGAKAGAOKFH, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8377AC0", Offset = "0x83764C0", VA = "0x188377AC0")]
	public static Vector2 GGNFPHAEBBO(FaceFeatureType KBFIENDMOAP, Vector2 GBPDMHAFFAI, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8379220", Offset = "0x8377C20", VA = "0x188379220")]
	private static Vector2 OPEPKKANPOC(FaceFeatureType KBFIENDMOAP, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8378C20", Offset = "0x8377620", VA = "0x188378C20")]
	private static Vector2 MOHCFPGAMKB(FaceFeatureType KBFIENDMOAP, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8376C00", Offset = "0x8375600", VA = "0x188376C00")]
	private static Vector2 CFPPJMOGIEL(FaceFeatureType KBFIENDMOAP, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x8378F80", Offset = "0x8377980", VA = "0x188378F80")]
	private static Vector2 NILPNLOFKMN(FaceFeatureType KBFIENDMOAP, Vector2 FLFMNJAAFPM, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x8377230", Offset = "0x8375C30", VA = "0x188377230")]
	public static Vector2 FECIFOLAIJC(FaceFeatureType KBFIENDMOAP, Vector2 GBPDMHAFFAI, Vector2 DKLKLJOGEFE, Vector2 MGAKAGAOKFH, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x83777E0", Offset = "0x83761E0", VA = "0x1883777E0")]
	public static float GFALBBCIOCI(FaceFeatureType KBFIENDMOAP, float HBOHCMBAGOG, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x8377D20", Offset = "0x8376720", VA = "0x188377D20")]
	public static float GIKIHFMLGKG(FaceFeatureType KBFIENDMOAP, float AMHDLJKDJBK, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x83788C0", Offset = "0x83772C0", VA = "0x1883788C0")]
	public static float LFKAKLEPFGI(FaceFeatureType KBFIENDMOAP, float DEDMEALJJPH, BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8377E30", Offset = "0x8376830", VA = "0x188377E30")]
	private static float HJFHAFDPPCL(float EPMJNJEPCMJ, float JOEBEKPOHKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x83770C0", Offset = "0x8375AC0", VA = "0x1883770C0")]
	private static Vector2 DJDKMDCJNFA(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x8378ED0", Offset = "0x83778D0", VA = "0x188378ED0")]
	private static Vector2 NEGDHAHNPEF(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8376A30", Offset = "0x8375430", VA = "0x188376A30")]
	private static Vector2 BNEGNJLHPEA(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8378AB0", Offset = "0x83774B0", VA = "0x188378AB0")]
	private static Vector2 MDLICCDOAOC(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x83780B0", Offset = "0x8376AB0", VA = "0x1883780B0")]
	private static float JACBHPFNIHE(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x8377DC0", Offset = "0x83767C0", VA = "0x188377DC0")]
	private static float HFHAPKODADB(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x8378040", Offset = "0x8376A40", VA = "0x188378040")]
	private static float ICLLLGCGDPD(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x83776C0", Offset = "0x83760C0", VA = "0x1883776C0")]
	private static float FHCFAEKHOGI(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x8377F80", Offset = "0x8376980", VA = "0x188377F80")]
	private static Vector2 IAHEFKJCMOE(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x8377A00", Offset = "0x8376400", VA = "0x188377A00")]
	private static Vector2 GFKNANFBLAD(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x83783E0", Offset = "0x8376DE0", VA = "0x1883783E0")]
	private static Vector2 KDKADGLNHBF(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x83784A0", Offset = "0x8376EA0", VA = "0x1883784A0")]
	private static Vector2 KKEKDMNIAMA(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8377730", Offset = "0x8376130", VA = "0x188377730")]
	private static Vector2 FJLIPLFLMNB(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x8378550", Offset = "0x8376F50", VA = "0x188378550")]
	private static Vector2 KMIJDPDOHCE(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x8376F70", Offset = "0x8375970", VA = "0x188376F70")]
	private static Vector2 CPMHOHODCFG(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8377170", Offset = "0x8375B70", VA = "0x188377170")]
	private static Vector2 DODEDPEGIPD(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x83781E0", Offset = "0x8376BE0", VA = "0x1883781E0")]
	private static Vector2 JLDLLMJFPFE(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x83764C0", Offset = "0x8374EC0", VA = "0x1883764C0")]
	private static Vector2 AJIAPODHBPL(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8378610", Offset = "0x8377010", VA = "0x188378610")]
	private static Vector2 KPLAFJLOHPI(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x8379390", Offset = "0x8377D90", VA = "0x188379390")]
	private static Vector2 PLOBOENPMCE(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8378290", Offset = "0x8376C90", VA = "0x188378290")]
	private static Vector2 JOFAHBHIDCG(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x8376630", Offset = "0x8375030", VA = "0x188376630")]
	private static Vector2 ANDDMJLCNHD(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x8376570", Offset = "0x8374F70", VA = "0x188376570")]
	private static Vector2 AKHFHHAFNCB(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8378960", Offset = "0x8377360", VA = "0x188378960")]
	private static Vector2 LGCPBGGHMPO(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x8376EB0", Offset = "0x83758B0", VA = "0x188376EB0")]
	private static Vector2 CKCAELAEGKC(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x8378120", Offset = "0x8376B20", VA = "0x188378120")]
	private static Vector2 JHLIHHJEPGE(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8377EC0", Offset = "0x83768C0", VA = "0x188377EC0")]
	private static Vector2 HLEKGPKCOBE(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8379450", Offset = "0x8377E50", VA = "0x188379450")]
	private static Vector2 PNJLECMIHAJ(BOIFAILEJMF FJBHHBODDIK, AvatarConfiguration OEPEIJIAHEB)
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
