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
		public float SampleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public bool HasLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool HasLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public bool HasLocalScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Quaternion LocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Vector3 LocalScale;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x748B490", Offset = "0x748A690", VA = "0x18748B490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarBodyPartBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct FaceShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarFaceShapeData.OHOBBJFCMNG FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AnimationClip FaceShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct BodyShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AvatarBodyShapeData.KNPAADGPPLD BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AnimationClip BodyShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct BodyPropertyAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public OBFILAGNCOE BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AnimationClip BodyPropertyAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct FacePropertyAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public PNKEOEACGPH FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AnimationClip FacePropertyAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct HeadShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AnimationClip HeadShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NoseShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MKBBPKEHLCL NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AnimationClip NoseTypeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct BodyPropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public OBFILAGNCOE BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct FacePropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public PNKEOEACGPH FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[FormerlySerializedAs("BodyPropertyInfluences")]
		public JIACNDKCIMK PropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[Flags]
public enum JIACNDKCIMK
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	NONE = 1,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	X_POSITION = 2,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Y_POSITION = 4,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	Z_POSITION = 8,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	X_ROTATION = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Y_ROTATION = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Z_ROTATION = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	X_SCALE = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Y_SCALE = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Z_SCALE = 0x200
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class JDEDAEFGGIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public JDEDAEFGGIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x749DA70", Offset = "0x749CC70", VA = "0x18749DA70")]
			internal bool GPDGKILONHO(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const string LOCAL_ROTATION_X_PROPERTY_NAME = "m_LocalRotation.x";

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private const string LOCAL_ROTATION_Y_PROPERTY_NAME = "m_LocalRotation.y";

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private const string LOCAL_ROTATION_Z_PROPERTY_NAME = "m_LocalRotation.z";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private const string LOCAL_ROTATION_W_PROPERTY_NAME = "m_LocalRotation.w";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string BASE_NOSE_TWEAK_BONE_NAME = "Jnt.Head.Nose.Tweak";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private List<BodyPropertyBoneInfluenceInfo> bodyPropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private List<FacePropertyBoneInfluenceInfo> facePropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private List<AvatarHeadShapeBoneData> headShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private List<AvatarBodyPropertyBoneData> bodyPropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private List<AvatarFacePropertyBoneData> facePropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private List<AvatarNoseTypeBoneData> noseTypeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<AvatarFaceShapeData.OHOBBJFCMNG> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private List<AvatarBodyShapeData.KNPAADGPPLD> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Dictionary<OBFILAGNCOE, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Dictionary<PNKEOEACGPH, List<float>> facePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<(string, AvatarFaceShapeData.OHOBBJFCMNG), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<(string, AvatarBodyShapeData.KNPAADGPPLD), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Dictionary<(string, MKBBPKEHLCL), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Dictionary<(string, OBFILAGNCOE, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly Dictionary<OBFILAGNCOE, Dictionary<string, JIACNDKCIMK>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly Dictionary<(string, PNKEOEACGPH, float), AvatarBodyPartBoneData> facePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<PNKEOEACGPH, Dictionary<string, JIACNDKCIMK>> facePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly List<string> headBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly List<string> noseBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<OBFILAGNCOE, string[]> bonesToUpdatePerBodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<PNKEOEACGPH, string[]> bonesToUpdatePerFaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Dictionary<string, Dictionary<JIACNDKCIMK, int>> influencesPerBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Dictionary<string, Dictionary<JIACNDKCIMK, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7491DC0", Offset = "0x7490FC0", VA = "0x187491DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x748F880", Offset = "0x748EA80", VA = "0x18748F880")]
		public void PDAIGIIELDH(IReadOnlyDictionary<string, Transform> AABAGHKMKNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x748B620", Offset = "0x748A820", VA = "0x18748B620")]
		public void AEEPOGPBCCD(IReadOnlyDictionary<string, Transform> AABAGHKMKNA, AvatarFaceShapeData.OHOBBJFCMNG HIHFLIMLNAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x748BDC0", Offset = "0x748AFC0", VA = "0x18748BDC0")]
		public void ENEMLJAMIBI(IReadOnlyDictionary<string, Transform> AABAGHKMKNA, MKBBPKEHLCL OIMBBJJFICP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x748C240", Offset = "0x748B440", VA = "0x18748C240")]
		public void ICGLBDCHBJP(IReadOnlyDictionary<string, Transform> AABAGHKMKNA, AvatarBodyShapeData.KNPAADGPPLD HAANFMKKEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x748F520", Offset = "0x748E720", VA = "0x18748F520")]
		public void PANFDIDFIHJ(IReadOnlyDictionary<string, Transform> AABAGHKMKNA, IReadOnlyDictionary<string, HCGNCEABOJF> JKCBPPGBBGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x748F1D0", Offset = "0x748E3D0", VA = "0x18748F1D0")]
		public IReadOnlyDictionary<string, HCGNCEABOJF> OLIPGGDLMOE(IReadOnlyDictionary<string, Transform> AABAGHKMKNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x748EA50", Offset = "0x748DC50", VA = "0x18748EA50")]
		public Dictionary<string, HCGNCEABOJF> OGKPMMMMECG(IReadOnlyDictionary<string, Transform> AABAGHKMKNA, IReadOnlyDictionary<OBFILAGNCOE, float> DKFPCEMAACD, IReadOnlyDictionary<string, HCGNCEABOJF> JDLDENBDJAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x748BCC0", Offset = "0x748AEC0", VA = "0x18748BCC0")]
		public Dictionary<string, HCGNCEABOJF> DJPMPIADBEF(IReadOnlyDictionary<string, Transform> AABAGHKMKNA, IReadOnlyDictionary<PNKEOEACGPH, float> KJCGMNLHNJK, IReadOnlyDictionary<string, HCGNCEABOJF> JDLDENBDJAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x31EC2E0", Offset = "0x31EB4E0", VA = "0x1831EC2E0")]
		private Dictionary<string, HCGNCEABOJF> GKPAKAGLKEJ<T>(IReadOnlyDictionary<string, Transform> AABAGHKMKNA, IReadOnlyDictionary<T, float> BOBFDPJPHHJ, IReadOnlyDictionary<string, HCGNCEABOJF> JDLDENBDJAH, Dictionary<T, Dictionary<string, JIACNDKCIMK>> HILOHBBBODE, Dictionary<(string, T, float), AvatarBodyPartBoneData> IKAPFFNDNPJ, bool BOANEIALGIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x748F170", Offset = "0x748E370", VA = "0x18748F170")]
		public float OHNMFOGCPDP(OBFILAGNCOE MLGJBLMEBNO, float JMBMBJLPEDO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x748C1E0", Offset = "0x748B3E0", VA = "0x18748C1E0")]
		public float HGIFLFGOEIN(PNKEOEACGPH AEKMGAIBEPJ, float JDFLEDKKOBE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x31EC140", Offset = "0x31EB340", VA = "0x1831EC140")]
		private float DPLELFNOMAH<T>(T AKOEHEOHLAC, float DFGDLJOJDBO, Dictionary<T, List<float>> KIAMMPBKBBG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x748BBC0", Offset = "0x748ADC0", VA = "0x18748BBC0")]
		private float BLEINFACOAO(float OMFJNFBDJCA, List<float> MGLPEBAPDCO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x748BD50", Offset = "0x748AF50", VA = "0x18748BD50")]
		private Vector3 EAJLJFDKGMJ(Transform IFMEPLLJIOM, AvatarBodyPartBoneData PBKKDIBNDLI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x748BB60", Offset = "0x748AD60", VA = "0x18748BB60")]
		private Quaternion BJFFJNJGFAE(Transform IFMEPLLJIOM, AvatarBodyPartBoneData PBKKDIBNDLI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x748BAF0", Offset = "0x748ACF0", VA = "0x18748BAF0")]
		private Vector3 BBKAIJHCOJF(Transform IFMEPLLJIOM, AvatarBodyPartBoneData PBKKDIBNDLI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x748D750", Offset = "0x748C950", VA = "0x18748D750")]
		private void LEHAKAJBGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66ECC00", Offset = "0x66EBE00", VA = "0x1866ECC00")]
		public bool FNGMBNEGKFJ(JIACNDKCIMK NPNEKIGAGKK, JIACNDKCIMK AOFLMMFHDLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x748C540", Offset = "0x748B740", VA = "0x18748C540")]
		private HCGNCEABOJF IODBDANNCJM(JIACNDKCIMK EDPFHPJAJEL, HCGNCEABOJF IFMEPLLJIOM, AvatarBodyPartBoneData PBKKDIBNDLI)
		{
			return default(HCGNCEABOJF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x748EAE0", Offset = "0x748DCE0", VA = "0x18748EAE0")]
		public Dictionary<string, HCGNCEABOJF> OHDIFNBHFOG(Dictionary<string, HCGNCEABOJF> JNMEDLFJCMA, bool BOANEIALGIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x748B920", Offset = "0x748AB20", VA = "0x18748B920")]
		private void AMPOCJPKLKK(Transform IFMEPLLJIOM, AvatarBodyPartBoneData PBKKDIBNDLI, bool OFGIOIENNFI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7491580", Offset = "0x7490780", VA = "0x187491580")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarBodyPropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public OBFILAGNCOE BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float BodyPropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7491E90", Offset = "0x7491090", VA = "0x187491E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public enum KNPAADGPPLD
		{
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			Pear = 1,
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			Apple = 2,
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			Triangle = 3,
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			Hourglass = 4,
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			Square = 5,
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			Thin = 200
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public KNPAADGPPLD blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		[Obsolete("Use BodyShapeId instead!")]
		[HideInInspector]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private AvatarBodyShapeData.KNPAADGPPLD blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OICBNHEMJNF BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1C0E0E0", Offset = "0x1C0D2E0", VA = "0x181C0E0E0")]
			get
			{
				return default(OICBNHEMJNF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.KNPAADGPPLD BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x972060", Offset = "0x971260", VA = "0x180972060")]
			get
			{
				return default(AvatarBodyShapeData.KNPAADGPPLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7492940", Offset = "0x7491B40", VA = "0x187492940")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public AvatarBodyShapeData.KNPAADGPPLD BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x74921B0", Offset = "0x74913B0", VA = "0x1874921B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Dictionary<OICBNHEMJNF, AvatarBodyShape> OBOHHDFCIBF;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7492430", Offset = "0x7491630", VA = "0x187492430")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7492750", Offset = "0x7491950", VA = "0x187492750")]
		public AvatarBodyShape Find(OICBNHEMJNF JDOBMGMCPPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7492850", Offset = "0x7491A50", VA = "0x187492850")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7492810", Offset = "0x7491A10", VA = "0x187492810")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7492890", Offset = "0x7491A90", VA = "0x187492890")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DBEJLLNMCPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private Transform[] BCHLGECIKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly Dictionary<string, Transform> DHBGHJICBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Dictionary<Transform, Transform> OINFAKJJAHL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> HBLEHPEBHID
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] KHPCKNPBIMG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7499540", Offset = "0x7498740", VA = "0x187499540")]
	public void GDALJHCADAJ(Transform EJAFKICMLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7499460", Offset = "0x7498660", VA = "0x187499460")]
	public Transform ELOFJIJCAFJ(Transform LJMAMDPMFKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7499620", Offset = "0x7498820", VA = "0x187499620")]
	public void KAKGMPEOCFF(SkinnedMeshRenderer ICFPPCKJDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7499860", Offset = "0x7498A60", VA = "0x187499860")]
	private static void OOGFJDNIPCA(Transform BFPPPKIAFBG, List<Transform> GILMLJNJOPM, Dictionary<string, Transform> DJJIJMDIPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74999C0", Offset = "0x7498BC0", VA = "0x1874999C0")]
	public DBEJLLNMCPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NNBPLOEBEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public bool IHCPNBKGDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool FAEFKDKGKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public bool BGLGOPFKNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public FKCADKOIAIJ? MJNHEHBODPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public LHOPHOECLDF.PDNJAPAFAJM OKGAGCAKNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public HairData CPFDACJCNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public AdditionalHatData MNJOMKAALKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool LPPHIDLDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool CELEBGMPKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool BPBALEOKMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public IList<JCNHDNCLCIK> DMHMNIPGHHI;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public NNBPLOEBEJG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("How far apart you can position your eyebrows.")]
		[Header("Face Features")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("Min/Max rotation angle for your eyebrows.")]
		public Vector2 EyebrowsRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Min/Max aspect for your eyebrows.")]
		public Vector2 EyebrowAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Min/Max rotation angle for your eyes.")]
		public Vector2 EyeRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Min/Max aspect for your eyes.")]
		public Vector2 EyeAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Min/Max rotation angle for your mouth.")]
		public Vector2 MouthRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Min/Max aspect for your mouth.")]
		public Vector2 MouthAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Min/Max rotation angle for your nose.")]
		public Vector2 NoseRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Min/Max aspect for your nose.")]
		public Vector2 NoseAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Header("Hand Animation")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[Header("Body Shapes")]
		public BodyShapeConfiguration BodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Header("Face Shapes")]
		public FaceShapeConfiguration FaceShapeConfiguration;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74929D0", Offset = "0x7491BD0", VA = "0x1874929D0")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class IAMJGNLJADN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static BDLIJJPGICH OFJEJIPKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x749C3C0", Offset = "0x749B5C0", VA = "0x18749C3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static FJJMJDFJPJG EDIINDIJPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x749C420", Offset = "0x749B620", VA = "0x18749C420")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct JJDGBHOOCOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Transform ILJNELIFPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public AvatarSkinAssetItem MMHFILDKDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public AssetReference GLONHJFIOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public GameObject PODAHFAHHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public GameObject MMDOCLCBHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public SkinnedMeshRenderer BJCADJCLOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public AvatarSkinnedMeshBoneOrderRemapsData JPLLEJHBMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Material OIKFLIOELGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Material INIKJNMHHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Material KLGBOOIFOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public Shader MMHONPFACCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public Shader KCFHANMJLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public Animator LCLGHMBBMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Renderer[] HEPCOPMHHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public AvatarConfiguration IEAJFKFDBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public AvatarBodyPartShapesManager JOIJFPFMAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public IReadOnlyDictionary<string, Transform> BKGIKBBLHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public Transform LDNBHGLEFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public KJAEMCJAGMO HFIFGIEOKLC;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GLDJAABLEOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public SkinnedMeshRenderer[] KHABCMDHJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public SkinnedMeshRenderer[] IGBFNPMOHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public SkinnedMeshRenderer[] IGNLHIKNDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public SkinnedMeshRenderer[] JFEPEFLIBPH;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LIDPOGBHMII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public Transform LPAFKCJIKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public Transform DHNMLAEJKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public Transform IBFEMLMCDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Transform CCBLHPBCOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public Transform JNEAGDDANHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public Transform FKAJOHPNNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public Transform DFEALOBAMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public AvatarConfiguration IEAJFKFDBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public KJAEMCJAGMO HFIFGIEOKLC;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct BNDENANPNPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public SkinnedMeshRenderer[] MJPLDFMPCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Material EOGOPPPMFOG;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JOBMFOONMEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public PJNKFCCNBHG AEMHBDONLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public int GMKCNGLGKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public int EDNOFPCNJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Color ENCNPOGIFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Color KACKEHAHFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public int KKDKMDLLJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public int KLHAOIMANPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Color GLPMDABOBPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Color MIKEJFBBENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public int CIPBANFEHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public float KAKMHFLMPKH;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct CNAHKIMNGOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public PJNKFCCNBHG AEMHBDONLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public Vector2 KEOGDNKOPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public float JBNDDILKKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public float KFGOKBELFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public float LONPNNJEFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Vector2 JLNMKAEMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public float FOACPANKAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public float NAIOBEPALBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public float NLEHOEFPPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector2 PLKANNDPJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public float OIIEGAPNJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public float OFMLHOANMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public float PELKFAFFKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Vector2 MLCMDPFKIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public float BEFBMCKOHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public float KAKMHFLMPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public float OFOCBGBGCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public bool BPIEJBIAJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public bool DOEKIGHFIMO;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public PNKEOEACGPH FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public float FacePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7492FF0", Offset = "0x74921F0", VA = "0x187492FF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public enum OHOBBJFCMNG
		{
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public OHOBBJFCMNG blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		[Obsolete("Use FaceShapeId instead!")]
		[HideInInspector]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		private AvatarFaceShapeData.OHOBBJFCMNG blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public COALEIABEBD FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1C0E0E0", Offset = "0x1C0D2E0", VA = "0x181C0E0E0")]
			get
			{
				return default(COALEIABEBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AvatarFaceShapeData.OHOBBJFCMNG BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x972060", Offset = "0x971260", VA = "0x180972060")]
			get
			{
				return default(AvatarFaceShapeData.OHOBBJFCMNG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7493AA0", Offset = "0x7492CA0", VA = "0x187493AA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7493B00", Offset = "0x7492D00", VA = "0x187493B00")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public AvatarFaceShapeData.OHOBBJFCMNG FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7493310", Offset = "0x7492510", VA = "0x187493310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Dictionary<COALEIABEBD, AvatarFaceShape> OBOHHDFCIBF;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7493590", Offset = "0x7492790", VA = "0x187493590")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x74938B0", Offset = "0x7492AB0", VA = "0x1874938B0")]
		public AvatarFaceShape Find(COALEIABEBD BHMGLKDCLLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74939B0", Offset = "0x7492BB0", VA = "0x1874939B0")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7493970", Offset = "0x7492B70", VA = "0x187493970")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x74939F0", Offset = "0x7492BF0", VA = "0x1874939F0")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7494150", Offset = "0x7493350", VA = "0x187494150")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public EHPJCGLIJLP HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1C0E0E0", Offset = "0x1C0D2E0", VA = "0x181C0E0E0")]
			get
			{
				return default(EHPJCGLIJLP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xB05410", Offset = "0xB04610", VA = "0x180B05410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xB52430", Offset = "0xB51630", VA = "0x180B52430")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7494330", Offset = "0x7493530", VA = "0x187494330")]
		public Texture2D GKHPGOCHBKJ(HairPatternStyle CKIDPLGCPBE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x74941D0", Offset = "0x74933D0", VA = "0x1874941D0", Slot = "0")]
		public override bool Equals(object ONELFPFEALD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7494160", Offset = "0x7493360", VA = "0x187494160", Slot = "4")]
		public bool Equals(AvatarHairPattern LDKNLBHIGFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7494490", Offset = "0x7493690", VA = "0x187494490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7494480", Offset = "0x7493680", VA = "0x187494480", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7494280", Offset = "0x7493480", VA = "0x187494280")]
		public static bool GHFFJAPPGNB(AvatarHairPattern DOEPDJPJMCB, AvatarHairPattern DHHGPPJBNNK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x74942B0", Offset = "0x74934B0", VA = "0x1874942B0")]
		public static bool GJNOMHNHJKL(AvatarHairPattern DOEPDJPJMCB, AvatarHairPattern DHHGPPJBNNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x74944D0", Offset = "0x74936D0", VA = "0x1874944D0")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum LJHHNJNPPBE
{
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	Idle,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	Invisible,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Pointing,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	TPose,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	ThumbUp,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	HandShake,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Grabbing,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	NumStates
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Flags]
public enum HLOEDBDLCNI
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ThumbUp = 1,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	Pointing = 2,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	HandShake = 4
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GELLFOBOELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Animator CLJEGDFMCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public HELPMFJLADN OKCEDBJJPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public AvatarConfiguration IEAJFKFDBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public GameObject HLNJODDKGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public KJAEMCJAGMO HFIFGIEOKLC;
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct OLJDBGPHCEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public Transform CPIDGBCNNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public bool EHBONOFHLJJ;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x74945E0", Offset = "0x74937E0", VA = "0x1874945E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JCNHDNCLCIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public string FOBFABOAOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public OutfitType AKPGGBEMNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public OCHNHLJBAPP DKHIKOCMKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public LHOPHOECLDF.PDNJAPAFAJM IFPNPGOEDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public bool HJKKCMKBLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public bool EIJECIDLAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public bool INCEPAHDCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public Color? GCEFCGAIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public bool HNEMPDMBHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public Color? PJHIJDEIINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public bool AKGIIHJAJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public bool FHHAPCIDAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public bool KNCDMFMGECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Transform CLHIBJHCMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Vector2? HBOEBAOCBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public FitMeshHemisphere PEOCNCBADPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public AssetReference BPNDIBLCFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public AssetReference HBBIHGBIFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public AssetReference[] MMFIMKHHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public JCNHDNCLCIK KNDHMAGIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public bool MLDNLIFBHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public bool BFHJMOEBHJL;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public string CAFJGGNHHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x749D9B0", Offset = "0x749CBB0", VA = "0x18749D9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x749D9B0", Offset = "0x749CBB0", VA = "0x18749D9B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x749DA60", Offset = "0x749CC60", VA = "0x18749DA60")]
	public JCNHDNCLCIK()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private FAFHJKJKKAE? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KFKBHGMMOEG CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7494B80", Offset = "0x7493D80", VA = "0x187494B80")]
			get
			{
				return default(KFKBHGMMOEG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public FAFHJKJKKAE MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7494BB0", Offset = "0x7493DB0", VA = "0x187494BB0")]
			get
			{
				return default(FAFHJKJKKAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960820", VA = "0x180961620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7494820", Offset = "0x7493A20", VA = "0x187494820")]
		public Material[] KECAGCPCGMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7494910", Offset = "0x7493B10", VA = "0x187494910")]
		public static void LFMEFAOMOFB(AvatarItemMaterial PKLKFANCJHI, Material MDMIJJAMBMD, int DGMNCEHCMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7494670", Offset = "0x7493870", VA = "0x187494670")]
		private static bool DBNAFBMPCLI(AvatarItemMaterial PKLKFANCJHI, int DGMNCEHCMDA, [Out] Material KJBMIPBEONH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7494B00", Offset = "0x7493D00", VA = "0x187494B00")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MNJBDICHJBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public SkinnedMeshRenderer FBMMFMBPHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private Material[] JKPJDMNPPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private byte[] NIIJAKKONLK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh HEBENAMLBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x749DCF0", Offset = "0x749CEF0", VA = "0x18749DCF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Material[] MBIBGAPAHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public byte[] ILLEJHFKGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x749DD10", Offset = "0x749CF10", VA = "0x18749DD10")]
	public MNJBDICHJBL(SkinnedMeshRenderer MEFKAPPLHEA, AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH, Material[] CAJLNIEKKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x749DB50", Offset = "0x749CD50", VA = "0x18749DB50")]
	public static MNJBDICHJBL DGAGAMKBNBF(Renderer MONNLFCGBEF, AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH, Material[] CAJLNIEKKLL)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x128D560", Offset = "0x128C760", VA = "0x18128D560")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xB51E80", Offset = "0xB51080", VA = "0x180B51E80")]
		public void GFIEJLHFJLN(Vector3 LBPAIJGCICL, Quaternion GLMEOLPKLCA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PICLGNCDAOC
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x749E0B0", Offset = "0x749D2B0", VA = "0x18749E0B0")]
	public static PositionAndRotation BFCHMHBMMLB(this PositionAndRotation KPBPCBENKAA)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x749E3F0", Offset = "0x749D5F0", VA = "0x18749E3F0")]
	public static float OAOLHJJIOME(float FDDEDLKEPIJ, Vector2 BGEMEPKDOPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x749E370", Offset = "0x749D570", VA = "0x18749E370")]
	public static float OAOLHJJIOME(float FDDEDLKEPIJ, float CDNAEODPMGJ, float CIAJFKHDJNB, float PLIBGNKHNME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x749E200", Offset = "0x749D400", VA = "0x18749E200")]
	public static float IMEDAFAHDDB(float OMFJNFBDJCA, Vector2 BGEMEPKDOPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x749E2C0", Offset = "0x749D4C0", VA = "0x18749E2C0")]
	public static float IMEDAFAHDDB(float OMFJNFBDJCA, float CDNAEODPMGJ, float CIAJFKHDJNB, float PLIBGNKHNME)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public MKBBPKEHLCL NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7494C70", Offset = "0x7493E70", VA = "0x187494C70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum MGEENGMJPGI
{
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum KPFKBLJOHLN
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	IdleSwayAimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	IdleSwayMeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	IdleSwayLightItem,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	IdleSwayHeavyItem,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	IdleSwayAimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	FastAction,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	NumTypes
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum DKFIILHCHMC
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	PotatoAvatar,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	FullOutfitAvatar
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct OAGBJLJEEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public Vector2 LNLNABEKCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public Vector2 DPBAOKPDAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public Vector2 IJAINPCHDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public Vector2 NJBNPHMJCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Vector2 FKNHKLBBIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public Vector2 OBDCOJPDCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public Vector2 HPGHAJJBEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Vector2 LBDCBNOHJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Vector2 PKBLLADODJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector2 FPMKBMGBCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector2 DBFBAACCKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector2 IBGHDIECCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector2 HFCOIHENBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector2 ELNBCCEPDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Vector2 MJBLCDEEMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public Vector2 HKHHIDOIPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public float NHPINOHDGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public float OIKHCBFEAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public float FKAMMJHJNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public float AKLEDINHNFC;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class GAKLDOMPMCE
{
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public static readonly int CCMECNDJDBB;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly string JFEANAMONJA;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x749BA70", Offset = "0x749AC70", VA = "0x18749BA70")]
	public static JJDGBHOOCOI BMOMEGJJBBH(Transform HGMDILKIKLC, AvatarSkinAssetItem ILLMFMBMCDD, AssetReference EJLCNEGAALL, GameObject KCKGKGNIBDP, GameObject NIOGFOFNAOP, SkinnedMeshRenderer EMHPPOMBEAG, AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH, Material BINCHEPALAO, Material KMHPKDKDCFA, Material MMMMHLFKPEM, Shader PCLFLCIIPHL, Shader BCGMEGKGEOH, Animator JHOMLBALMCN, Renderer[] NKDGGDFLNOP, AvatarConfiguration DKJOEIJKMHK, AvatarBodyPartShapesManager IMMEIMINBOA, IReadOnlyDictionary<string, Transform> AABAGHKMKNA, Transform GKJLBHCGDEF, KJAEMCJAGMO PJNNOBDKNHH)
	{
		return default(JJDGBHOOCOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x749BDF0", Offset = "0x749AFF0", VA = "0x18749BDF0")]
	public static GLDJAABLEOP JACKKAAFJLJ(SkinnedMeshRenderer[] HBBMKFHPKIH, SkinnedMeshRenderer[] DHMJAPNNGEO, SkinnedMeshRenderer[] LHKOADGAAPF, SkinnedMeshRenderer[] JBNPEKNEMJE)
	{
		return default(GLDJAABLEOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x749BC70", Offset = "0x749AE70", VA = "0x18749BC70")]
	public static LIDPOGBHMII DIHFBBKJEFA(Transform EEMDKDHNKIM, Transform NLBBLEGMMDC, Transform KMOEEDLNJEH, Transform NFLKDAHEINB, Transform GLBDKAEAAHE, Transform ABKNBDGCOJL, Transform HGCGEEMJHCK, AvatarConfiguration OPNCBCHKJOH, KJAEMCJAGMO PJNNOBDKNHH)
	{
		return default(LIDPOGBHMII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x25EDCA0", Offset = "0x25ECEA0", VA = "0x1825EDCA0")]
	public static BNDENANPNPM MIHPMNLKEJP(SkinnedMeshRenderer[] GIIJMKPKMOJ, Material KBIMCELGMPB)
	{
		return default(BNDENANPNPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x749BD50", Offset = "0x749AF50", VA = "0x18749BD50")]
	public static JOBMFOONMEJ FJJMGPKLNJE(PJNKFCCNBHG GJPMMFJNNNG, int FEMNJHGHJNM, int JJIGLEBLCCI, Color HIAGEENGEFJ, Color GAMMJFNANCO, int IHADJEFIJJF, int KOCHBPHJEGF, Color BOJLBBFEMFJ, Color OKKJACGDLNI, int OCOGKLNFEPN)
	{
		return default(JOBMFOONMEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x749BEF0", Offset = "0x749B0F0", VA = "0x18749BEF0")]
	public static CNAHKIMNGOM KBOLCNKOPLA(PJNKFCCNBHG GJPMMFJNNNG, Vector2 JCNGBBNIPJJ, float CANODCCFIPJ, float JKFOGJINCAN, float IDNKNAMPDMB, Vector2 GEKDEHHLAKN, float JMGKKKIKPEA, float NHPINOHDGDH, float HMAGCGKOKGJ, Vector2 LHMLJOJCHMH, float ONLDEDPAANI, float FKAMMJHJNPB, float IOPDOACFODE, Vector2 MOKEGAAHBPG, float ICIJJCKIHDL, float AKLEDINHNFC, float DJDGGBINEHG)
	{
		return default(CNAHKIMNGOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x749BE70", Offset = "0x749B070", VA = "0x18749BE70")]
	public static GELLFOBOELB JGKJEOIJAEJ(Animator MPOHPFPKMMP, HELPMFJLADN DGHIEKFMHII, AvatarConfiguration DKJOEIJKMHK, GameObject DJHKGJGNMMD, KJAEMCJAGMO PJNNOBDKNHH)
	{
		return default(GELLFOBOELB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x749BC30", Offset = "0x749AE30", VA = "0x18749BC30")]
	public static OLJDBGPHCEI CNDNBLGJIDG(Transform JPEKJEHBDBN, bool AMIFOCKNPAN)
	{
		return default(OLJDBGPHCEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FCCLINBHHCH
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7499F10", Offset = "0x7499110", VA = "0x187499F10")]
	public static LJHHNJNPPBE BJGMKPHNDFB(this MGEENGMJPGI NKHPFGCKJIA)
	{
		return default(LJHHNJNPPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7499F60", Offset = "0x7499160", VA = "0x187499F60")]
	public static bool ICLGDDBLFBJ(this MGEENGMJPGI FNLHAKGFIFH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public enum OFCNNHONCHK
		{
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BodySkinnedMeshLODs COEMGMNCOIF
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public BodySkinnedMeshLODs GECAHLGGOKB
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs CAIFDKJLFEB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs MGPHAICPIAF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7494EF0", Offset = "0x74940F0", VA = "0x187494EF0")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(OFCNNHONCHK PKPKGOGGFIO, [Optional] FKCADKOIAIJ? OOADGOCNDBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class ADJEJJFOABM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ADJEJJFOABM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x748B460", Offset = "0x748A660", VA = "0x18748B460")]
			internal bool JCJCPMBMAFH(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74951C0", Offset = "0x74943C0", VA = "0x1874951C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x74951C0", Offset = "0x74943C0", VA = "0x1874951C0")]
		private void ECIPFCGCBJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7495070", Offset = "0x7494270", VA = "0x187495070")]
		private void BLPFNDJDHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7495C10", Offset = "0x7494E10", VA = "0x187495C10")]
		public byte[] POLDJBEAJHE(string HCKEEJODCAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x74951D0", Offset = "0x74943D0", VA = "0x1874951D0")]
		public bool IPGEPMNBPNA(SkinnedMeshBoneOrderData CPGHFJHPDOG, AvatarSkinnedMeshBonesController OEIAKKIIIDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7495CE0", Offset = "0x7494EE0", VA = "0x187495CE0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IMBFIEAJCAP
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct IAACEIJFOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Transform[] KHPCKNPBIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public Matrix4x4[] PJIENPJDECH;
	}

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly string HDMIKKOBGBM;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x749D360", Offset = "0x749C560", VA = "0x18749D360")]
	public static byte[] FOHHIECFKJM(AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH, SkinnedMeshRenderer ICFPPCKJDKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x749D450", Offset = "0x749C650", VA = "0x18749D450")]
	public static IAACEIJFOLI? OINIKGHIDKI(AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH, SkinnedMeshRenderer ICFPPCKJDKO)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public string BNJJKKKHEII
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7495DB0", Offset = "0x7494FB0", VA = "0x187495DB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74961F0", Offset = "0x74953F0", VA = "0x1874961F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7495DE0", Offset = "0x7494FE0", VA = "0x187495DE0")]
		private void BLPFNDJDHHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7495EA0", Offset = "0x74950A0", VA = "0x187495EA0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7495F00", Offset = "0x7495100", VA = "0x187495F00")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer MONNLFCGBEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public enum OBFILAGNCOE
{
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	BicepWidth,
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	ForearmWidth,
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	ChestSize,
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	ChestOut,
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	WaistSize,
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	HipWidth,
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	NeckLength,
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	NeckThickness,
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	ThighWidth,
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	CalfWidth,
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	FootWidth,
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	FootSize,
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	ShoulderWidth,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	BellyOut
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class NEEFAHFDAKH
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x749E050", Offset = "0x749D250", VA = "0x18749E050")]
	public static bool ENLHAEFHDEF(this OBFILAGNCOE MLGJBLMEBNO)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class BodyShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[FormerlySerializedAs("BodyShapePropertyData")]
		[SerializeField]
		private List<BodyShapePropertyData> FullBodyShapePropertyData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private List<BodyShapePropertyData> ModernBeanShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7496200", Offset = "0x7495400", VA = "0x187496200")]
		public List<BodyShapePropertyData> MOAHNHAFICO(KJAEMCJAGMO PJNNOBDKNHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
		public BodyShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct BodyShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public AvatarBodyShapeData.KNPAADGPPLD BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public List<BodyPropertySliderData> BodyPropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct BodyPropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public OBFILAGNCOE BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct HCGNCEABOJF : IEquatable<HCGNCEABOJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public string NDIJMAPCAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public Vector3 JLOEFHABMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public Vector3 BBFEKOPJLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public Vector3 MCFPOCEPGLK;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x749C140", Offset = "0x749B340", VA = "0x18749C140", Slot = "4")]
	public bool Equals(HCGNCEABOJF LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x749C090", Offset = "0x749B290", VA = "0x18749C090", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x749C280", Offset = "0x749B480", VA = "0x18749C280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum NBFCMDJEKPM
{
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LFIOEJONFIO
{
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static readonly LFIOEJONFIO IDMKIMBBHMK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int DCCNKNNJPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9611A0", Offset = "0x9603A0", VA = "0x1809611A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x971850", Offset = "0x970A50", VA = "0x180971850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public NBFCMDJEKPM PJEOMLHHLIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA8A290", Offset = "0xA89490", VA = "0x180A8A290")]
		[CompilerGenerated]
		get
		{
			return default(NBFCMDJEKPM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB62C10", Offset = "0xB61E10", VA = "0x180B62C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public LFIOEJONFIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2C21560", Offset = "0x2C20760", VA = "0x182C21560")]
	public LFIOEJONFIO(NBFCMDJEKPM PCJPKAENIHL, int LMJEPOJBPJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public enum PNKEOEACGPH
{
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	CheekPuff,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	JawWidth,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	JawInOut,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	ChinWidth,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ChinSize,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	EarSize,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	EarAngle,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	HeadStretch
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class FaceShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private List<FaceShapePropertyData> FaceShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public List<FaceShapePropertyData> AllFaceShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
		public FaceShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct FaceShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AvatarFaceShapeData.OHOBBJFCMNG FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public List<FacePropertySliderData> FacePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public struct FacePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public PNKEOEACGPH FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x749B490", Offset = "0x749A690", VA = "0x18749B490")]
		public void DrawPosition(bool NNBKKFCHIFJ, Transform LBAHEDDLOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x749B530", Offset = "0x749A730", VA = "0x18749B530")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere OEAFDECFLPM, Transform JNGEIJHHFEP, Vector2 NCHMIJAAMJK, AnchorParamsRestrictions GCICGHHHLFL, bool OGAOCJNGMCM = false, bool GLOLBNIFAIP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public FitMeshPreviewGizmo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x749F5C0", Offset = "0x749E7C0", VA = "0x18749F5C0")]
		public void EHDEPFCBLFN(SkinnedMeshRenderer ICFPPCKJDKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x749F760", Offset = "0x749E960", VA = "0x18749F760")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		[Header("Remapping Eye Data")]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7493B50", Offset = "0x7492D50", VA = "0x187493B50")]
		public void CCLELFONMFM(DABNGCONOGE FFEIGPODIGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7494030", Offset = "0x7493230", VA = "0x187494030")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAAF9C0", Offset = "0xAAEBC0", VA = "0x180AAF9C0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7496220", Offset = "0x7495420", VA = "0x187496220")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7499E90", Offset = "0x7499090", VA = "0x187499E90")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x7339BD0", Offset = "0x7338DD0", VA = "0x187339BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x7499EB0", Offset = "0x74990B0", VA = "0x187499EB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x7499EF0", Offset = "0x74990F0", VA = "0x187499EF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x7499ED0", Offset = "0x74990D0", VA = "0x187499ED0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x24712C0", Offset = "0x24704C0", VA = "0x1824712C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1BC59E0", Offset = "0x1BC4BE0", VA = "0x181BC59E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x7499F00", Offset = "0x7499100", VA = "0x187499F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7499A90", Offset = "0x7498C90", VA = "0x187499A90", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7499D80", Offset = "0x7498F80", VA = "0x187499D80")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x749A9F0", Offset = "0x7499BF0", VA = "0x18749A9F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x17EBF90", Offset = "0x17EB190", VA = "0x1817EBF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x13477B0", Offset = "0x13469B0", VA = "0x1813477B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x17EB0F0", Offset = "0x17EA2F0", VA = "0x1817EB0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x749A7C0", Offset = "0x74999C0", VA = "0x18749A7C0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x749A900", Offset = "0x7499B00", VA = "0x18749A900")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x749FB50", Offset = "0x749ED50", VA = "0x18749FB50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x74A07D0", Offset = "0x749F9D0", VA = "0x1874A07D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private readonly List<CAFFOJNOKAH<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x966D60", Offset = "0x965F60", VA = "0x180966D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x966D50", Offset = "0x965F50", VA = "0x180966D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x749A710", Offset = "0x7499910", VA = "0x18749A710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x749A780", Offset = "0x7499980", VA = "0x18749A780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x749A6A0", Offset = "0x74998A0", VA = "0x18749A6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x749A6F0", Offset = "0x74998F0", VA = "0x18749A6F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x6957F80", Offset = "0x6957180", VA = "0x186957F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x749A180", Offset = "0x7499380", VA = "0x18749A180")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x749A2C0", Offset = "0x74994C0", VA = "0x18749A2C0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x749A1F0", Offset = "0x74993F0", VA = "0x18749A1F0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x749A3A0", Offset = "0x74995A0", VA = "0x18749A3A0")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7499F70", Offset = "0x7499170", VA = "0x187499F70")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x749A4A0", Offset = "0x74996A0", VA = "0x18749A4A0")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class MNLCHAODKOK
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x749DF20", Offset = "0x749D120", VA = "0x18749DF20")]
	public static CJAOLDPFAPJ CNKLIKIIEPO(this FaceFeatureType GDOCGKIIGKM, CDBIINFMANM PHMGCMMAOFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class PJNKFCCNBHG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct IHIBKLHECEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public AsyncTaskMethodBuilder<PJNKFCCNBHG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private BCBDICAALGE.FFINGPDKDPO <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x749CAC0", Offset = "0x749BCC0", VA = "0x18749CAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x749D2F0", Offset = "0x749C4F0", VA = "0x18749D2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private readonly Dictionary<string, int> EMLBBGGNOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private bool CGFFOGCJKAH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Texture2DArray CKFAHEJAJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public SymmetricalFaceFeature KPALKOBEIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public EyesFaceFeature HDFEBGJPFKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x968CF0", Offset = "0x967EF0", VA = "0x180968CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public FaceFeature OJJOINAAPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x749E750", Offset = "0x749D950", VA = "0x18749E750")]
	private static void KJOGMGOAKCP(Sprite PNLKGKNICPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x749E6C0", Offset = "0x749D8C0", VA = "0x18749E6C0")]
	public static PJNKFCCNBHG KCHGFNCHNML(SymmetricalFaceFeature JNEHFGLLMAP, EyesFaceFeature LFEHMDCKBKN, FaceFeature OFLGOFCIOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x749EF00", Offset = "0x749E100", VA = "0x18749EF00")]
	[AsyncStateMachine(typeof(IHIBKLHECEJ))]
	public static Task<PJNKFCCNBHG> OAENPNHHLEP(SymmetricalFaceFeature JNEHFGLLMAP, EyesFaceFeature LFEHMDCKBKN, FaceFeature OFLGOFCIOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x749F110", Offset = "0x749E310", VA = "0x18749F110")]
	private PJNKFCCNBHG(SymmetricalFaceFeature JNEHFGLLMAP, EyesFaceFeature LFEHMDCKBKN, FaceFeature OFLGOFCIOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x749E7C0", Offset = "0x749D9C0", VA = "0x18749E7C0")]
	private void KPJGHJHEDOA(List<Sprite> DMINAHADGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x749E5D0", Offset = "0x749D7D0", VA = "0x18749E5D0")]
	public bool JBCAMHNHINC(string MLHKKCPGJGE, [Out] int KOOLKCPAFBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x749E490", Offset = "0x749D690", VA = "0x18749E490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x749E4C0", Offset = "0x749D6C0", VA = "0x18749E4C0")]
	public bool IEIFJCLJNMH(bool BLNGGMFAPOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x749F040", Offset = "0x749E240", VA = "0x18749F040")]
	public void PEKEFPHCGLI()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private struct IBJKIAFPIIG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000231")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public AsyncTaskMethodBuilder<PJNKFCCNBHG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			private TaskAwaiter<PJNKFCCNBHG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x749C550", Offset = "0x749B750", VA = "0x18749C550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x749CA50", Offset = "0x749BC50", VA = "0x18749CA50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private Dictionary<FKCADKOIAIJ, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private Dictionary<FKCADKOIAIJ, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private Dictionary<FKCADKOIAIJ, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private Dictionary<FKCADKOIAIJ, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private readonly Dictionary<FKCADKOIAIJ, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private PJNKFCCNBHG _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private PJNKFCCNBHG _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x749B460", Offset = "0x749A660", VA = "0x18749B460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x749AA10", Offset = "0x7499C10", VA = "0x18749AA10")]
		public PJNKFCCNBHG BFNELMEEKJN(KJAEMCJAGMO PJNNOBDKNHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x749AC30", Offset = "0x7499E30", VA = "0x18749AC30")]
		[AsyncStateMachine(typeof(IBJKIAFPIIG))]
		public Task<PJNKFCCNBHG> FMDBFHPKEHH(int? BKHIFKGOMBD, int LFEHMDCKBKN, int OFLGOFCIOGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x749B110", Offset = "0x749A310", VA = "0x18749B110")]
		public NoseFaceOption HDNHLNNCGFK(int JLMFJHDFEKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x749B1B0", Offset = "0x749A3B0", VA = "0x18749B1B0")]
		public SelectableFaceOption JIONIDLJLPJ(FaceFeatureType MKEBMFCLGPB, FKCADKOIAIJ NEKBMPMCJNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x749AAA0", Offset = "0x7499CA0", VA = "0x18749AAA0")]
		public int EGPFAIEDHML(FKCADKOIAIJ NEKBMPMCJNF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x749AD60", Offset = "0x7499F60", VA = "0x18749AD60")]
		private void GKEJBDNPIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3480BB0", Offset = "0x347FDB0", VA = "0x183480BB0")]
		private void IDFIHNNGDFM<T>(IDictionary<FKCADKOIAIJ, T> AJOKDFPIHEH, IReadOnlyList<T> MJEEOEGJKNP) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x749AB20", Offset = "0x7499D20", VA = "0x18749AB20")]
		public FKCADKOIAIJ FJCALLGLPPB(FaceFeatureType MKEBMFCLGPB)
		{
			return default(FKCADKOIAIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x749AF90", Offset = "0x749A190", VA = "0x18749AF90")]
		public FKCADKOIAIJ GKLANGMJFCH(FaceFeatureType MKEBMFCLGPB)
		{
			return default(FKCADKOIAIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x749B330", Offset = "0x749A530", VA = "0x18749B330")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2CC0", Offset = "0xAD1EC0", VA = "0x180AD2CC0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x749A900", Offset = "0x7499B00", VA = "0x18749A900")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public MKBBPKEHLCL SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAC6460", Offset = "0xAC5660", VA = "0x180AC6460", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public FKCADKOIAIJ FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x1C0E0E0", Offset = "0x1C0D2E0", VA = "0x181C0E0E0")]
			get
			{
				return default(FKCADKOIAIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xC6B200", Offset = "0xC6A400", VA = "0x180C6B200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7493AA0", Offset = "0x7492CA0", VA = "0x187493AA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D90", Offset = "0xAA7F90", VA = "0x180AA8D90")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x749FAD0", Offset = "0x749ECD0", VA = "0x18749FAD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x69540A0", Offset = "0x69532A0", VA = "0x1869540A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x749FB10", Offset = "0x749ED10", VA = "0x18749FB10")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x69540B0", Offset = "0x69532B0", VA = "0x1869540B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x749FAF0", Offset = "0x749ECF0", VA = "0x18749FAF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x6957210", Offset = "0x6956410", VA = "0x186957210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x749FB30", Offset = "0x749ED30", VA = "0x18749FB30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6957200", Offset = "0x6956400", VA = "0x186957200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x749F7F0", Offset = "0x749E9F0", VA = "0x18749F7F0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x749FA00", Offset = "0x749EC00", VA = "0x18749FA00")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class CLLPAPHENAO
{
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public static readonly float OJIPAFEOOJC;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	public static readonly float EGPKFGGGPEH;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	public static readonly Vector2 DOLFKALFHNC;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	public static readonly Vector2 MKGCLPNJDOE;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	public static readonly Vector2 AFJKEFPCCNA;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	public static readonly Vector2 PGHPFMOMOJL;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public static readonly Vector2 CPDLLMEPEMC;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public static readonly Vector2 LDKEIHIFICC;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public static readonly Vector2 FAMLMAHBHDA;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public static readonly Vector2 GNNKDCCMFOF;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public static readonly Vector2 BJCNJFIBNCK;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public static readonly Vector2 MEBJELLOCMN;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public static readonly Vector2 FBNFJOLGJJC;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public static readonly Vector2 IAAKGIGNCJA;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x74975C0", Offset = "0x74967C0", VA = "0x1874975C0")]
	public static Vector2 ICOLFCKGOCC(FaceFeatureType GDOCGKIIGKM, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7497930", Offset = "0x7496B30", VA = "0x187497930")]
	public static float IIKNAKKLBMK(FaceFeatureType GDOCGKIIGKM, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x74991A0", Offset = "0x74983A0", VA = "0x1874991A0")]
	public static void ONIIHCMKPGA(DABNGCONOGE EEBNLHEJIHP, AvatarConfiguration DKJOEIJKMHK, KJAEMCJAGMO JOFEGOOELJB, KJAEMCJAGMO IFBDHLMCHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7497FA0", Offset = "0x74971A0", VA = "0x187497FA0")]
	public static float IOPHICJDDNE(FaceFeatureType MKEBMFCLGPB, float FMKMNEKCLJL, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7498FA0", Offset = "0x74981A0", VA = "0x187498FA0")]
	public static float NPKBINPCFJD(FaceFeatureType MKEBMFCLGPB, float DICDCKDEFAH, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7496520", Offset = "0x7495720", VA = "0x187496520")]
	public static float BICGAMBLKHK(FaceFeatureType MKEBMFCLGPB, float GLMEOLPKLCA, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7498790", Offset = "0x7497990", VA = "0x187498790")]
	public static float LJPPBKPFPDM(FaceFeatureType MKEBMFCLGPB, float ONFBOIMHMFP, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7498F10", Offset = "0x7498110", VA = "0x187498F10")]
	public static float NOOGMMFDGGP(FaceFeatureType MKEBMFCLGPB, float OIAEBFDGGDH, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7496EB0", Offset = "0x74960B0", VA = "0x187496EB0")]
	public static float GIFIJHAAOKN(FaceFeatureType MKEBMFCLGPB, float IHGKNKOLPGE, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7496450", Offset = "0x7495650", VA = "0x187496450")]
	public static Vector2 BFCEEOILFHG(FaceFeatureType MKEBMFCLGPB, Vector2 JIHHAGGDEOO, Vector2 IBIFNPLIKCL, Vector2 GLIILHBFEEC, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7498260", Offset = "0x7497460", VA = "0x187498260")]
	public static Vector2 KFMPHCBENGI(FaceFeatureType MKEBMFCLGPB, Vector2 AMJLEEFMHCK, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7498D10", Offset = "0x7497F10", VA = "0x187498D10")]
	private static Vector2 NEANKOMPEDE(FaceFeatureType MKEBMFCLGPB, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7496F40", Offset = "0x7496140", VA = "0x187496F40")]
	private static Vector2 HADNANBEHGB(FaceFeatureType MKEBMFCLGPB, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x74965B0", Offset = "0x74957B0", VA = "0x1874965B0")]
	private static Vector2 BKBCDMLHDAO(FaceFeatureType MKEBMFCLGPB, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7497340", Offset = "0x7496540", VA = "0x187497340")]
	private static Vector2 IAAGFPEPHEB(FaceFeatureType MKEBMFCLGPB, Vector2 JIHHAGGDEOO, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7497B20", Offset = "0x7496D20", VA = "0x187497B20")]
	public static Vector2 INKGOAHBOMO(FaceFeatureType MKEBMFCLGPB, Vector2 AMJLEEFMHCK, Vector2 IBIFNPLIKCL, Vector2 GLIILHBFEEC, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7498AF0", Offset = "0x7497CF0", VA = "0x187498AF0")]
	public static float MOENEJOPHAG(FaceFeatureType MKEBMFCLGPB, float DICDCKDEFAH, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7496230", Offset = "0x7495430", VA = "0x187496230")]
	public static float AJPDMCBFJIH(FaceFeatureType MKEBMFCLGPB, float GLMEOLPKLCA, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7498E70", Offset = "0x7498070", VA = "0x187498E70")]
	public static float NGDGNEAEBLP(FaceFeatureType MKEBMFCLGPB, float ONFBOIMHMFP, KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x74971F0", Offset = "0x74963F0", VA = "0x1874971F0")]
	private static float HBCNDNJJLOB(float CDNAEODPMGJ, float PLIBGNKHNME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7496E00", Offset = "0x7496000", VA = "0x187496E00")]
	private static Vector2 FKFMAGCPCCD(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x74986E0", Offset = "0x74978E0", VA = "0x1874986E0")]
	private static Vector2 LCBEHDEMJAK(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7496A50", Offset = "0x7495C50", VA = "0x187496A50")]
	private static Vector2 CIMEENAPJBA(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x74981B0", Offset = "0x74973B0", VA = "0x1874981B0")]
	private static Vector2 KCOIEBHKKFO(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x74969E0", Offset = "0x7495BE0", VA = "0x1874969E0")]
	private static float CEEPLFGFLOH(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7498A10", Offset = "0x7497C10", VA = "0x187498A10")]
	private static float MFFGIFBPOIC(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7498A80", Offset = "0x7497C80", VA = "0x187498A80")]
	private static float MLJNOHEGLII(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x74988E0", Offset = "0x7497AE0", VA = "0x1874988E0")]
	private static float LKLOOGCCCHM(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7496390", Offset = "0x7495590", VA = "0x187496390")]
	private static Vector2 AOLHPAPJBHE(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7496D40", Offset = "0x7495F40", VA = "0x187496D40")]
	private static Vector2 FBBHMGNCLLG(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7497870", Offset = "0x7496A70", VA = "0x187497870")]
	private static Vector2 IDHGBLGONCA(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x74990F0", Offset = "0x74982F0", VA = "0x1874990F0")]
	private static Vector2 OCMMAOLLCPE(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7498630", Offset = "0x7497830", VA = "0x187498630")]
	private static Vector2 KPJBJLFDBKM(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7496920", Offset = "0x7495B20", VA = "0x187496920")]
	private static Vector2 CADGCDNFMBJ(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7497280", Offset = "0x7496480", VA = "0x187497280")]
	private static Vector2 HMDGJKCLOOB(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7498030", Offset = "0x7497230", VA = "0x187498030")]
	private static Vector2 JBHNDKFLODE(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7497510", Offset = "0x7496710", VA = "0x187497510")]
	private static Vector2 IBBDCGFEKOL(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x74984C0", Offset = "0x74976C0", VA = "0x1874984C0")]
	private static Vector2 KKGHCEOMAKF(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7496B00", Offset = "0x7495D00", VA = "0x187496B00")]
	private static Vector2 CLCIJPJIDBN(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7499030", Offset = "0x7498230", VA = "0x187499030")]
	private static Vector2 OCBNMLEFCHO(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x74980F0", Offset = "0x74972F0", VA = "0x1874980F0")]
	private static Vector2 JKLOBDDKNCH(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7496860", Offset = "0x7495A60", VA = "0x187496860")]
	private static Vector2 BLMGDBMMKGP(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7496C80", Offset = "0x7495E80", VA = "0x187496C80")]
	private static Vector2 EOMAPOJMFMJ(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7496BC0", Offset = "0x7495DC0", VA = "0x187496BC0")]
	private static Vector2 EMCOMEONAJJ(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7498570", Offset = "0x7497770", VA = "0x187498570")]
	private static Vector2 KOIIIPLJELI(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7498950", Offset = "0x7497B50", VA = "0x187498950")]
	private static Vector2 MDHKNEBJGMA(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x74962D0", Offset = "0x74954D0", VA = "0x1874962D0")]
	private static Vector2 AMBJHGELHGM(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7498820", Offset = "0x7497A20", VA = "0x187498820")]
	private static Vector2 LKKPFHLKFGN(KJAEMCJAGMO PJNNOBDKNHH, AvatarConfiguration OPNCBCHKJOH)
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
