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
		[Cpp2IlInjected.Address(RVA = "0x7982250", Offset = "0x7981650", VA = "0x187982250", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
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
		public AvatarFaceShapeData.BMGPHLCKOHO FaceShapeName;

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
		public AvatarBodyShapeData.KDFLAIKEMGD BodyShapeName;

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
		public BCKKHHFAGPP BodyProperty;

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
		public FGBECOOKEOM FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AnimationClip FacePropertyAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct NosePropertyAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public JCIMPJGFJKG NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AnimationClip NosePropertyAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct HeadShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AnimationClip HeadShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NoseShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public EKLJAOFDFFM NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AnimationClip NoseTypeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct BodyPropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BCKKHHFAGPP BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct FacePropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public FGBECOOKEOM FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct NosePropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public JCIMPJGFJKG NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct BoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[FormerlySerializedAs("BodyPropertyInfluences")]
		public PNKBELOPAEE PropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Flags]
public enum PNKBELOPAEE
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	NONE = 1,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	X_POSITION = 2,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	Y_POSITION = 4,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Z_POSITION = 8,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	X_ROTATION = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Y_ROTATION = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Z_ROTATION = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	X_SCALE = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Y_SCALE = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	Z_SCALE = 0x200
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MMCAAMBHPBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public MMCAAMBHPBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7995400", Offset = "0x7994800", VA = "0x187995400")]
			internal bool ADNGFJCIIJO(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string LOCAL_ROTATION_X_PROPERTY_NAME = "m_LocalRotation.x";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string LOCAL_ROTATION_Y_PROPERTY_NAME = "m_LocalRotation.y";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string LOCAL_ROTATION_Z_PROPERTY_NAME = "m_LocalRotation.z";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string LOCAL_ROTATION_W_PROPERTY_NAME = "m_LocalRotation.w";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string BASE_NOSE_TWEAK_BONE_NAME = "Jnt.Head.Nose.Tweak";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private List<BodyPropertyBoneInfluenceInfo> bodyPropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private List<FacePropertyBoneInfluenceInfo> facePropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private List<NosePropertyBoneInfluenceInfo> nosePropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private List<AvatarHeadShapeBoneData> headShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private List<AvatarBodyPropertyBoneData> bodyPropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private List<AvatarFacePropertyBoneData> facePropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private List<AvatarNoseTypeBoneData> noseTypeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private List<AvatarNosePropertyBoneData> nosePropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private List<AvatarFaceShapeData.BMGPHLCKOHO> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private List<AvatarBodyShapeData.KDFLAIKEMGD> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<BCKKHHFAGPP, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Dictionary<FGBECOOKEOM, List<float>> facePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Dictionary<JCIMPJGFJKG, List<float>> nosePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(string, AvatarFaceShapeData.BMGPHLCKOHO), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(string, AvatarBodyShapeData.KDFLAIKEMGD), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<(string, EKLJAOFDFFM), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<(string, BCKKHHFAGPP, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<BCKKHHFAGPP, Dictionary<string, PNKBELOPAEE>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<(string, FGBECOOKEOM, float), AvatarBodyPartBoneData> facePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Dictionary<FGBECOOKEOM, Dictionary<string, PNKBELOPAEE>> facePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Dictionary<(string, JCIMPJGFJKG, float), AvatarBodyPartBoneData> nosePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Dictionary<JCIMPJGFJKG, Dictionary<string, PNKBELOPAEE>> nosePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private readonly List<string> headBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly List<string> noseBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Dictionary<BCKKHHFAGPP, string[]> bonesToUpdatePerBodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly Dictionary<FGBECOOKEOM, string[]> bonesToUpdatePerFaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Dictionary<JCIMPJGFJKG, string[]> bonesToUpdatePerNoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Dictionary<string, Dictionary<PNKBELOPAEE, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7989330", Offset = "0x7988730", VA = "0x187989330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7984620", Offset = "0x7983A20", VA = "0x187984620")]
		public void ENMMELFAOHH(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7988160", Offset = "0x7987560", VA = "0x187988160")]
		public void OIGGLLPIJHA(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, AvatarFaceShapeData.BMGPHLCKOHO KDHMLIJJJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79829D0", Offset = "0x7981DD0", VA = "0x1879829D0")]
		public void BMJKEFPEDGA(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, EKLJAOFDFFM EFBDDCCBBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7987A40", Offset = "0x7986E40", VA = "0x187987A40")]
		public void NBNIDHHBOGH(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, AvatarBodyShapeData.KDFLAIKEMGD CBKGAIGIBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7987D40", Offset = "0x7987140", VA = "0x187987D40")]
		public void OHKBAPADCOP(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, IReadOnlyDictionary<string, PNBEAKMENNH> OKCCKABJEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7982550", Offset = "0x7981950", VA = "0x187982550")]
		public IReadOnlyDictionary<string, PNBEAKMENNH> BFBCPIPBFOD(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79867E0", Offset = "0x7985BE0", VA = "0x1879867E0")]
		public Dictionary<string, PNBEAKMENNH> JPDIHDJBOKF(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, IReadOnlyDictionary<BCKKHHFAGPP, float> JDHIBJPFGJC, IReadOnlyDictionary<string, PNBEAKMENNH> JMIBEGIDFDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7982940", Offset = "0x7981D40", VA = "0x187982940")]
		public Dictionary<string, PNBEAKMENNH> BHEPFPMJPPN(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, IReadOnlyDictionary<FGBECOOKEOM, float> MAPMIIMKJLA, IReadOnlyDictionary<string, PNBEAKMENNH> JMIBEGIDFDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79866F0", Offset = "0x7985AF0", VA = "0x1879866F0")]
		public Dictionary<string, PNBEAKMENNH> GFAELNJIEIC(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, IReadOnlyDictionary<JCIMPJGFJKG, float> LOHGLMPFOCF, IReadOnlyDictionary<string, PNBEAKMENNH> JMIBEGIDFDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x343A940", Offset = "0x3439D40", VA = "0x18343A940")]
		private Dictionary<string, PNBEAKMENNH> HALJMLCGDDH<T>(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, IReadOnlyDictionary<T, float> DOPGNLDOCHK, IReadOnlyDictionary<string, PNBEAKMENNH> FALJOJMMIFJ, Dictionary<T, Dictionary<string, PNKBELOPAEE>> OBKCPBBJMID, Dictionary<(string, T, float), AvatarBodyPartBoneData> NFJKDCMKOCA, bool MEHBLKIDLIC, bool DKPMOFJJGCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7986780", Offset = "0x7985B80", VA = "0x187986780")]
		public float HGCENDEINJA(BCKKHHFAGPP CBKABMIGHBO, float CONOJEJIMKA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7982E60", Offset = "0x7982260", VA = "0x187982E60")]
		public float DDICGCJKFCH(FGBECOOKEOM EJGKLLLLALH, float MPLJDLPKNFD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7982DF0", Offset = "0x79821F0", VA = "0x187982DF0")]
		public float CHEAFMHLNFP(JCIMPJGFJKG OLCFOJACJIG, float OGMEPBLAPGM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x343BE30", Offset = "0x343B230", VA = "0x18343BE30")]
		private float INBCEDPNACI<T>(T EKNPKHOHCLO, float DGDAOMHJFLO, Dictionary<T, List<float>> MNFGOIEACHM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79878B0", Offset = "0x7986CB0", VA = "0x1879878B0")]
		private PNBEAKMENNH MHCMBAGFBGH(IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, string MBKADIIBEKE)
		{
			return default(PNBEAKMENNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7982450", Offset = "0x7981850", VA = "0x187982450")]
		private float AHIIIEOLLLF(float OOEMJLHLIHJ, List<float> GHLNFJAHFIL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7988690", Offset = "0x7987A90", VA = "0x187988690")]
		private Vector3 PPOMIMFJLIA(Transform AIINFJBAELC, AvatarBodyPartBoneData HJBHJGFNOLP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7988630", Offset = "0x7987A30", VA = "0x187988630")]
		private Quaternion PGOHFMPEFBK(Transform AIINFJBAELC, AvatarBodyPartBoneData HJBHJGFNOLP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x79823E0", Offset = "0x79817E0", VA = "0x1879823E0")]
		private Vector3 AEHCENKLJKC(Transform AIINFJBAELC, AvatarBodyPartBoneData HJBHJGFNOLP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7982ED0", Offset = "0x79822D0", VA = "0x187982ED0")]
		private void DGCJOEGCKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B5B2D0", Offset = "0x6B5A6D0", VA = "0x186B5B2D0")]
		public bool EMEGNMHFLKD(PNKBELOPAEE JEBIFDMICCH, PNKBELOPAEE COGBDFKBMIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7986870", Offset = "0x7985C70", VA = "0x187986870")]
		private PNBEAKMENNH MDIELNDILGI(PNKBELOPAEE BHCHGGPODEK, PNBEAKMENNH AIINFJBAELC, AvatarBodyPartBoneData HJBHJGFNOLP)
		{
			return default(PNBEAKMENNH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7983F90", Offset = "0x7983390", VA = "0x187983F90")]
		public Dictionary<string, PNBEAKMENNH> ECDDIHLICFK(Dictionary<string, PNBEAKMENNH> IJLEGELLCGL, bool MEHBLKIDLIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7988460", Offset = "0x7987860", VA = "0x187988460")]
		private void PECJPCCLAKE(Transform AIINFJBAELC, AvatarBodyPartBoneData HJBHJGFNOLP, bool IKEEOPPHAOK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7988980", Offset = "0x7987D80", VA = "0x187988980")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AvatarBodyPropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public BCKKHHFAGPP BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float BodyPropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7989430", Offset = "0x7988830", VA = "0x187989430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum KDFLAIKEMGD
		{
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			Pear = 1,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			Apple = 2,
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			Triangle = 3,
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			Hourglass = 4,
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			Square = 5,
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			Thin = 200
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public KDFLAIKEMGD blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		[Obsolete("Use BodyShapeId instead!")]
		[HideInInspector]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private AvatarBodyShapeData.KDFLAIKEMGD blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KODNMIGJFEI BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1D57C80", Offset = "0x1D57080", VA = "0x181D57C80")]
			get
			{
				return default(KODNMIGJFEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.KDFLAIKEMGD BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9DA090", Offset = "0x9D9490", VA = "0x1809DA090")]
			get
			{
				return default(AvatarBodyShapeData.KDFLAIKEMGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7989EF0", Offset = "0x79892F0", VA = "0x187989EF0")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AvatarBodyShapeData.KDFLAIKEMGD BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7989750", Offset = "0x7988B50", VA = "0x187989750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly Dictionary<KODNMIGJFEI, AvatarBodyShape> FPGJFDEHGLH;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79899D0", Offset = "0x7988DD0", VA = "0x1879899D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7989CF0", Offset = "0x79890F0", VA = "0x187989CF0")]
		public AvatarBodyShape Find(KODNMIGJFEI NJPDMMHBCHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7989E00", Offset = "0x7989200", VA = "0x187989E00")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7989DC0", Offset = "0x79891C0", VA = "0x187989DC0")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7989E40", Offset = "0x7989240", VA = "0x187989E40")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NBIPKNEDJNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Transform[] BOKPGGKBAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<string, Transform> OGHGGAPMGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Transform, Transform> GPMLOICFCMO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> IMGMEDENGJB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] IDLAPFOPHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7995460", Offset = "0x7994860", VA = "0x187995460")]
	public void DJMKCGGEGFC(Transform PJNKKHHLDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7995540", Offset = "0x7994940", VA = "0x187995540")]
	public Transform GDGJNCIAPGK(Transform OHODBFEGGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7995780", Offset = "0x7994B80", VA = "0x187995780")]
	public void NLALOPFGOAG(SkinnedMeshRenderer DJKECNLDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7995620", Offset = "0x7994A20", VA = "0x187995620")]
	private static void KIMPLGEHEFM(Transform DGFFJNKGDJD, List<Transform> AAPOEDBDHOK, Dictionary<string, Transform> ENDAJOJOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x79959C0", Offset = "0x7994DC0", VA = "0x1879959C0")]
	public NBIPKNEDJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class LAAPKAPFAKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool EEEOHDKMINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool HNGCIDAGEII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool ANAIENINJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public CEIANKIDECD? GNPJCBGDLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public MOJPHFECLPK.JODCMICJPOD FKHONOPFBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public HairData LGBACBJNDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public AdditionalHatData HCGDLFEJGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool CPFJDOHHKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public bool AJBHEDOHHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public bool MBPDPPOMNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public IList<NDKAGBMMFHK> MPCOGGHEHCC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public LAAPKAPFAKB()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Min/Max rotation angle for your eyebrows.")]
		public Vector2 EyebrowsRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Min/Max aspect for your eyebrows.")]
		public Vector2 EyebrowAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Min/Max rotation angle for your eyes.")]
		public Vector2 EyeRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Min/Max aspect for your eyes.")]
		public Vector2 EyeAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Min/Max rotation angle for your mouth.")]
		public Vector2 MouthRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Min/Max aspect for your mouth.")]
		public Vector2 MouthAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("Min/Max rotation angle for your nose.")]
		public Vector2 NoseRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Min/Max aspect for your nose.")]
		public Vector2 NoseAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Min uv for eyes")]
		public Vector2 EyeLimitsMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Tooltip("Max uv for eyes")]
		public Vector2 EyeLimitsMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[Tooltip("Scalar to reach border of limits on sprite")]
		public Vector2 EyeLimitsUVScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[Header("Body Shapes")]
		public BodyShapeConfiguration BodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[Header("Face Shapes")]
		public FaceShapeConfiguration FaceShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[Header("Nose Shapes")]
		public NoseShapeConfiguration NoseShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Header("Data Migration Managers")]
		public AvatarDataRangeMigrationsManager AvatarDataRangeMigrationsManager;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7989F80", Offset = "0x7989380", VA = "0x187989F80")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HCLLDJJOBIO
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	NoseScale_FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	NoseScale_ModernBean,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	NoseVerticalPosition_FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	NoseVerticalPosition_ModernBean,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	HeadScale_FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	HeadScale_ModernBean
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct RangeMigration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public HCLLDJJOBIO RangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Vector2 Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GHAPOEOFOLK Version;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AvatarDataRangeMigrationsManager : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<RangeMigration> RangeMigrations;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public List<RangeMigration> AllRangeMigrations
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB7EE00", Offset = "0xB7E200", VA = "0x180B7EE00")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MAKNKKGMFBD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static PHPIGAMMLHE LFKHFOLCGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x79953A0", Offset = "0x79947A0", VA = "0x1879953A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static AOFLICKOANP LPBAHNPMOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7995270", Offset = "0x7994670", VA = "0x187995270")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct ICCCEGHKHFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public Transform OKNDDPINICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public AvatarSkinAssetItem OMLABFNHELI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public AssetReference CIKODJBOGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public GameObject FHDIINBOBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public GameObject LEADEOCAAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public SkinnedMeshRenderer FBPFNCAAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public AvatarSkinnedMeshBoneOrderRemapsData PPEJEJELNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Material LEOJJMNLADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Material BDAPPGNAGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Material IHCOMFPILBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Shader BDPBKOCJAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public Shader NELBMLFNJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Animator IHNCJHANBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Renderer[] LCCDEHKMFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public AvatarConfiguration NOFLFOEPMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public AvatarBodyPartShapesManager KJHIIEPCABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public IReadOnlyDictionary<string, Transform> NNGCLBCHOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Transform NKFANECCMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public LOHMIPEBFLA PDBNGGNFIDB;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct FOIKDEKIGMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public SkinnedMeshRenderer[] ENLKMJAFLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public SkinnedMeshRenderer[] DNANBHCOODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public SkinnedMeshRenderer[] JNEBANPKNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public SkinnedMeshRenderer[] KOJDLOKBKOP;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct PNONPLLEHFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform LIAAJMGBOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform BHBFKPMMJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform OABOBKPNOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform CEKIKBDHPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform ENCFPAAAIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform KGIPIAJKGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Transform MALCEPNIENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public AvatarConfiguration NOFLFOEPMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public LOHMIPEBFLA PDBNGGNFIDB;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct GLAINGLAKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public SkinnedMeshRenderer[] LILJMMOKHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Material OLBHAMIIFIB;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct KBGOENLLBFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public IKECNDGIGBG ODNNIKAJGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public int IMLPNDCNFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public int NIIHLEABPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Color OLMJICEOKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Color KFEKGFEHLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int KGAAGFCBODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int FCCPENICBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Color PLNJPGDEEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Color JIEKFDBHPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int APKHEKAJHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float KPJKGAFFBHI;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IKMDDOEMNLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public IKECNDGIGBG ODNNIKAJGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Vector2 GCKPDDBIJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float JGJJIHDIIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public float NKHCDBMMHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public float LKEDFDCILFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector2 KKCAJLEHOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float OLDCFLNLHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public float IHFJJCLIECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public float NIFMNJAPAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector2 BPMGNCJAFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public float KMLPEOLGNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public float CAPNCGEAPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float MHLFMDHDIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Vector2 HNJCAEFJFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public float KGOFALGFMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public float KPJKGAFFBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public float PHIGCIIKIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool HBDEOFOPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool EHLALFDDPPA;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public FGBECOOKEOM FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public float FacePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x798A600", Offset = "0x7989A00", VA = "0x18798A600", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum BMGPHLCKOHO
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public BMGPHLCKOHO blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		[HideInInspector]
		[Obsolete("Use FaceShapeId instead!")]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private AvatarFaceShapeData.BMGPHLCKOHO blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HKFNMLCCPDK FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x1D57C80", Offset = "0x1D57080", VA = "0x181D57C80")]
			get
			{
				return default(HKFNMLCCPDK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.BMGPHLCKOHO BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9DA090", Offset = "0x9D9490", VA = "0x1809DA090")]
			get
			{
				return default(AvatarFaceShapeData.BMGPHLCKOHO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x798B0C0", Offset = "0x798A4C0", VA = "0x18798B0C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x798B120", Offset = "0x798A520", VA = "0x18798B120")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AvatarFaceShapeData.BMGPHLCKOHO FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x798A920", Offset = "0x7989D20", VA = "0x18798A920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly Dictionary<HKFNMLCCPDK, AvatarFaceShape> FPGJFDEHGLH;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x798ABA0", Offset = "0x7989FA0", VA = "0x18798ABA0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x798AEC0", Offset = "0x798A2C0", VA = "0x18798AEC0")]
		public AvatarFaceShape Find(HKFNMLCCPDK LALOEJAHDPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x798AFD0", Offset = "0x798A3D0", VA = "0x18798AFD0")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x798AF90", Offset = "0x798A390", VA = "0x18798AF90")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x798B010", Offset = "0x798A410", VA = "0x18798B010")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x798B780", Offset = "0x798AB80", VA = "0x18798B780")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public MBDBBLGDPFC HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1D57C80", Offset = "0x1D57080", VA = "0x181D57C80")]
			get
			{
				return default(MBDBBLGDPFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9CE520", Offset = "0x9CD920", VA = "0x1809CE520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xBEB240", Offset = "0xBEA640", VA = "0x180BEB240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xBF1640", Offset = "0xBF0A40", VA = "0x180BF1640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x798B790", Offset = "0x798AB90", VA = "0x18798B790")]
		public Texture2D BAGBHAMLGJI(HairPatternStyle DHHDPMKIOOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x798B950", Offset = "0x798AD50", VA = "0x18798B950", Slot = "0")]
		public override bool Equals(object KLANNNFBLNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x798B8E0", Offset = "0x798ACE0", VA = "0x18798B8E0", Slot = "4")]
		public bool Equals(AvatarHairPattern DMMBOHMLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x798BAC0", Offset = "0x798AEC0", VA = "0x18798BAC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x798BA00", Offset = "0x798AE00", VA = "0x18798BA00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x798BA90", Offset = "0x798AE90", VA = "0x18798BA90")]
		public static bool PBNEENGPCHJ(AvatarHairPattern PPPJAHNPKAO, AvatarHairPattern DFIFINAEGII)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x798BA10", Offset = "0x798AE10", VA = "0x18798BA10")]
		public static bool HGJBAFCOLON(AvatarHairPattern PPPJAHNPKAO, AvatarHairPattern DFIFINAEGII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x798BB00", Offset = "0x798AF00", VA = "0x18798BB00")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum KGMJJNNLLGP
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Idle,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Invisible,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Pointing,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	TPose,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	ThumbUp,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	HandShake,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	Grabbing,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	NumStates
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum NFFIGFBDIBD
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	ThumbUp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Pointing = 2,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	HandShake = 4
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct FLJPPGGDPCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Animator DPCLCDGLECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public DFGGMLJPKKG GNPDPBAKGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public AvatarConfiguration NOFLFOEPMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public GameObject DPHGGJBLLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public LOHMIPEBFLA PDBNGGNFIDB;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GIPKBMEGECK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Transform FCJKPMGEEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public bool EENFFFLOMAD;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x798BC10", Offset = "0x798B010", VA = "0x18798BC10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class NDKAGBMMFHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public string LIPJOHOCCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public OutfitType EOGHIAIPAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public MJGMDPCOPJP HOFMJDPMKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public MOJPHFECLPK.JODCMICJPOD INNFJDNAOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public bool BGANDGJNCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public bool PPDEAGIKEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool FIMFALMDHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Color? JAFAGFCIBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool PICHEHKBAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Color? NAPLEABBKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool NFCMOLAKGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public bool DNKIEJLGKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public bool HECMIFGFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Transform MGKBLPAEBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Vector2? KFMNMELGPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public FitMeshHemisphere HNMPPAAPOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public AssetReference NCFEBEOCPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public AssetReference HELNLOHJHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public AssetReference[] FDHIIOAPANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public NDKAGBMMFHK NOFJMBFFIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public bool OHBAJGBPIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public bool NJOMGCOMLKA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string BCNFMIOEPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7995A90", Offset = "0x7994E90", VA = "0x187995A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7995A90", Offset = "0x7994E90", VA = "0x187995A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7995B40", Offset = "0x7994F40", VA = "0x187995B40")]
	public NDKAGBMMFHK()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private OHPFOIBFOHH? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BCAJBMEKGPP CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x798C1B0", Offset = "0x798B5B0", VA = "0x18798C1B0")]
			get
			{
				return default(BCAJBMEKGPP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public OHPFOIBFOHH MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x798C1E0", Offset = "0x798B5E0", VA = "0x18798C1E0")]
			get
			{
				return default(OHPFOIBFOHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9CD800", Offset = "0x9CCC00", VA = "0x1809CD800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9CD810", Offset = "0x9CCC10", VA = "0x1809CD810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x798BE50", Offset = "0x798B250", VA = "0x18798BE50")]
		public Material[] JHKCMLHNIGN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x798BF40", Offset = "0x798B340", VA = "0x18798BF40")]
		public static void OFDACBAHPKK(AvatarItemMaterial MJEKBMDGLLB, Material FFHFAEDNMPG, int LDDICKCHFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x798BCA0", Offset = "0x798B0A0", VA = "0x18798BCA0")]
		private static bool HLNEENHDEPF(AvatarItemMaterial MJEKBMDGLLB, int LDDICKCHFNB, [Out] Material DNABBPEFGOB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x798C130", Offset = "0x798B530", VA = "0x18798C130")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EFDMKOADJOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public SkinnedMeshRenderer ABBPGFFOGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Material[] LIKIGFEIDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private byte[] ALOCNJFNBBE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh IONJHIKMOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x798EC30", Offset = "0x798E030", VA = "0x18798EC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Material[] KLBFOAGBPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public byte[] DAGFPBEBLAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x798EC50", Offset = "0x798E050", VA = "0x18798EC50")]
	public EFDMKOADJOE(SkinnedMeshRenderer INOCKJOPLCC, AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK, Material[] IBEDBNMDDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x798EA90", Offset = "0x798DE90", VA = "0x18798EA90")]
	public static EFDMKOADJOE NAFOHLPFIAO(Renderer JBNKAEBEMAK, AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK, Material[] IBEDBNMDDID)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x13BC090", Offset = "0x13BB490", VA = "0x1813BC090")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xC2F5A0", Offset = "0xC2E9A0", VA = "0x180C2F5A0")]
		public void KFMFOPCGNHM(Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class NHCFFCLNILI
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7995CC0", Offset = "0x79950C0", VA = "0x187995CC0")]
	public static PositionAndRotation NAJJLNHGJHM(this PositionAndRotation EBGIDOGKOHE)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7995E90", Offset = "0x7995290", VA = "0x187995E90")]
	public static float POEKJIJHJFK(float DEEHPBDAIHI, Vector2 LEKMCLHIAAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7995E10", Offset = "0x7995210", VA = "0x187995E10")]
	public static float POEKJIJHJFK(float DEEHPBDAIHI, float JLCBKIPFKML, float MDCFGAHHODF, float CBHAMKJGEOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7995B50", Offset = "0x7994F50", VA = "0x187995B50")]
	public static float BNJCNKIMNGD(float OOEMJLHLIHJ, Vector2 LEKMCLHIAAD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7995C10", Offset = "0x7995010", VA = "0x187995C10")]
	public static float BNJCNKIMNGD(float OOEMJLHLIHJ, float JLCBKIPFKML, float MDCFGAHHODF, float CBHAMKJGEOB)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class AvatarNosePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public JCIMPJGFJKG NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public float NosePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x798C2A0", Offset = "0x798B6A0", VA = "0x18798C2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarNosePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public EKLJAOFDFFM NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x798C5C0", Offset = "0x798B9C0", VA = "0x18798C5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum PGLBIBBFLBI
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	GiveTake = 4,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum ONJNNKNKEPP
{
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	IdleSwayAimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	IdleSwayMeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	IdleSwayLightItem,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	IdleSwayHeavyItem,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	IdleSwayAimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	FastAction,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	NumTypes
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum BFMHJLAEPMI
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	PotatoAvatar,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	FullOutfitAvatar
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OGLMLNLEBHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector2 BJFNJFDPCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector2 ENIHEONILHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector2 JDBFJABJLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector2 AOGOPOGIDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector2 AEOCCGLLDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector2 EPPJBAPFHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Vector2 PBAONMLEPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public Vector2 GDKLKFMCLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Vector2 HEMEDHMNNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector2 LAMPJCKMLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector2 MBIOPNBFMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector2 FKOHAAKCMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector2 CDJGKOEEADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Vector2 DLGEPGGGOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public Vector2 HCMDIKAAFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public Vector2 IIIDACHEFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float HMCKDDOJPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public float LHDNFEOKHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float MJNDBLMMMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float OJFOPGEFKCN;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AEHOENDFALP
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public static readonly int OBEMKJOBDIJ;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly string ABCANCOMBCB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7981EE0", Offset = "0x79812E0", VA = "0x187981EE0")]
	public static ICCCEGHKHFM PIGJNCJOGDL(Transform JFHKKMFCAAG, AvatarSkinAssetItem GDBMCGJFFAD, AssetReference GAFIHHIEKOF, GameObject IGFLODMNLND, GameObject ECJPGIPKOPO, SkinnedMeshRenderer BDPHIHEANDK, AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK, Material FDNMKOEFLCF, Material KJAFKCBBBMO, Material PMEEOMMCGPG, Shader NIGCDCOPOBK, Shader EHCDALJKCGG, Animator OCGDILDAHHF, Renderer[] BBOJADOFBCN, AvatarConfiguration DOGJIOIGOCA, AvatarBodyPartShapesManager NONMGIJJBKP, IReadOnlyDictionary<string, Transform> CLLIMGNPLLB, Transform BJMDHIJNHHB, LOHMIPEBFLA EEBDILJINIH)
	{
		return default(ICCCEGHKHFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7981E60", Offset = "0x7981260", VA = "0x187981E60")]
	public static FOIKDEKIGMP JEFHDDDOLPG(SkinnedMeshRenderer[] ECHEMBDOBDE, SkinnedMeshRenderer[] PMAHHIDDKAC, SkinnedMeshRenderer[] NEKJJILPMCJ, SkinnedMeshRenderer[] MLHFPLOADMB)
	{
		return default(FOIKDEKIGMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7981C20", Offset = "0x7981020", VA = "0x187981C20")]
	public static PNONPLLEHFK FNBHJKJLFGC(Transform OJFKBNHENKG, Transform FDCAPGOOPKM, Transform COJDNGAMIGB, Transform OJIEBJAHGMH, Transform DMNHAGDPIOJ, Transform INCCKIDAKPN, Transform KCJDNEMJHNB, AvatarConfiguration BOICKNJEBMF, LOHMIPEBFLA EEBDILJINIH)
	{
		return default(PNONPLLEHFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x27305A0", Offset = "0x272F9A0", VA = "0x1827305A0")]
	public static GLAINGLAKFD IDOMGJMDIDJ(SkinnedMeshRenderer[] OCOGJABMGJA, Material FPNFHPFAHMO)
	{
		return default(GLAINGLAKFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7981D80", Offset = "0x7981180", VA = "0x187981D80")]
	public static KBGOENLLBFA HGLFDLGPBAP(IKECNDGIGBG KPFNENIPADP, int GFIODDBOBNL, int PLMGCCEHLKD, Color AKINAHMKHLK, Color KEMHMMJLNOJ, int HJCCFPLKILP, int DBIBNEPOHFM, Color IOGKMDAKCFB, Color AMGALHNNNBM, int DMBMJCBPFAM)
	{
		return default(KBGOENLLBFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7981B00", Offset = "0x7980F00", VA = "0x187981B00")]
	public static IKMDDOEMNLG DBHMFDNJCEC(IKECNDGIGBG KPFNENIPADP, Vector2 COPAGAPCLKP, float GGAOACFJAPO, float AHBOHEHLAGL, float EINIBEKKBFE, Vector2 MHKFAFILPKA, float JOJFGCGDBEE, float HMCKDDOJPHI, float HEOLBOJJLII, Vector2 BHEPDFLNELB, float KJMDDCGJCOP, float MJNDBLMMMJA, float HOHJOGKILIK, Vector2 CKPKFEBCNID, float BJJCGELLANE, float OJFOPGEFKCN, float JBCCFBKHKKF)
	{
		return default(IKMDDOEMNLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7981D00", Offset = "0x7981100", VA = "0x187981D00")]
	public static FLJPPGGDPCK GEDKLLLOKPC(Animator LJDONNMIBEG, DFGGMLJPKKG LILKDMIEALN, AvatarConfiguration DOGJIOIGOCA, GameObject ICHABFFNDCB, LOHMIPEBFLA EEBDILJINIH)
	{
		return default(FLJPPGGDPCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7981E20", Offset = "0x7981220", VA = "0x187981E20")]
	public static GIPKBMEGECK IHIHJFFEGCO(Transform CNHGKKLPILF, bool FGDJPJJDJGP)
	{
		return default(GIPKBMEGECK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class BLLBLDNEBHK
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x798DBA0", Offset = "0x798CFA0", VA = "0x18798DBA0")]
	public static KGMJJNNLLGP KKPDMCCDPLH(this PGLBIBBFLBI EONGDHOKNIJ)
	{
		return default(KGMJJNNLLGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x798DB90", Offset = "0x798CF90", VA = "0x18798DB90")]
	public static bool HPHCPCDEHHA(this PGLBIBBFLBI NPPGCIPNJFD)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public enum AMNFGBEAJLI
		{
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public BodySkinnedMeshLODs DMCCCIDJIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs FENOIHALGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs INPHCFHKKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs JHKBCLBDIDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x798C840", Offset = "0x798BC40", VA = "0x18798C840")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(AMNFGBEAJLI KJOKBHGGNJC, [Optional] CEIANKIDECD? PAGDHJNGOMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class INAKDEGGKAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public INAKDEGGKAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x79951C0", Offset = "0x79945C0", VA = "0x1879951C0")]
			internal bool MGHEAMDDMPH(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x798D5F0", Offset = "0x798C9F0", VA = "0x18798D5F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x798D5F0", Offset = "0x798C9F0", VA = "0x18798D5F0")]
		private void LIOHDBPMLPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x798D4A0", Offset = "0x798C8A0", VA = "0x18798D4A0")]
		private void FLMBCCCBLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x798C9D0", Offset = "0x798BDD0", VA = "0x18798C9D0")]
		public byte[] BKCCCHIGAKO(string LDIMALFKIMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x798CA40", Offset = "0x798BE40", VA = "0x18798CA40")]
		public bool CAICEMNKAAL(SkinnedMeshBoneOrderData FIMHKNHNJBN, AvatarSkinnedMeshBonesController GFALEOCOHCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x798D670", Offset = "0x798CA70", VA = "0x18798D670")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class NINECFLJACM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct CMFIGIANPFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Transform[] IDLAPFOPHEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Matrix4x4[] NJAKBINIOLG;
	}

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static readonly string EKMPCPBINBH;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7995F30", Offset = "0x7995330", VA = "0x187995F30")]
	public static byte[] AJLIHPGHPHB(AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK, SkinnedMeshRenderer DJKECNLDGNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7996020", Offset = "0x7995420", VA = "0x187996020")]
	public static CMFIGIANPFC? COLPLBNODGO(AvatarSkinnedMeshBoneOrderRemapsData LBMBMFENBLK, SkinnedMeshRenderer DJKECNLDGNA)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[HAKPMKJKBJL(ANEAJGIOFML.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string FDPINEKPJMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x798D740", Offset = "0x798CB40", VA = "0x18798D740")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x798DB80", Offset = "0x798CF80", VA = "0x18798DB80")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x798DAC0", Offset = "0x798CEC0", VA = "0x18798DAC0")]
		private void FLMBCCCBLNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x798D770", Offset = "0x798CB70", VA = "0x18798D770")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x798D7D0", Offset = "0x798CBD0", VA = "0x18798D7D0")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer JBNKAEBEMAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum BCKKHHFAGPP
{
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	BicepWidth,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ForearmWidth,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	ChestSize,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	ChestOut,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	WaistSize,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	HipWidth,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	NeckLength,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	NeckThickness,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ThighWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	CalfWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	FootWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	FootSize,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	ShoulderWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	BellyOut
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class COHGMLGGEEH
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x798E190", Offset = "0x798D590", VA = "0x18798E190")]
	public static bool BOKCEGCCABA(this BCKKHHFAGPP CBKABMIGHBO)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class BodyShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[SerializeField]
		[FormerlySerializedAs("BodyShapePropertyData")]
		private List<BodyShapePropertyData> FullBodyShapePropertyData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		private List<BodyShapePropertyData> ModernBeanShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x798DBF0", Offset = "0x798CFF0", VA = "0x18798DBF0")]
		public List<BodyShapePropertyData> APNNDNJODPI(LOHMIPEBFLA EEBDILJINIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xB7EE00", Offset = "0xB7E200", VA = "0x180B7EE00")]
		public BodyShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct BodyShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AvatarBodyShapeData.KDFLAIKEMGD BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public List<BodyPropertySliderData> BodyPropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct BodyPropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public BCKKHHFAGPP BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct PNBEAKMENNH : IEquatable<PNBEAKMENNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public string INLKEBPMMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public Vector3 BDNGLNKLDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public Vector3 MFDAOGCKLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public Vector3 GODBJDAFMMF;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7996590", Offset = "0x7995990", VA = "0x187996590", Slot = "4")]
	public bool Equals(PNBEAKMENNH DMMBOHMLHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x79966D0", Offset = "0x7995AD0", VA = "0x1879966D0", Slot = "0")]
	public override bool Equals(object KLANNNFBLNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7996780", Offset = "0x7995B80", VA = "0x187996780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum GEDKDKIABJC
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KIDHHIPBIAG
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly KIDHHIPBIAG GCAAODGDGAI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int CFNBKDNJDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public GEDKDKIABJC EBBJOCLBGKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB52460", Offset = "0xB51860", VA = "0x180B52460")]
		[CompilerGenerated]
		get
		{
			return default(GEDKDKIABJC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC35ED0", Offset = "0xC352D0", VA = "0x180C35ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public KIDHHIPBIAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2D628A0", Offset = "0x2D61CA0", VA = "0x182D628A0")]
	public KIDHHIPBIAG(GEDKDKIABJC FDNGPAPMHIO, int KFILDIHNIHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum FGBECOOKEOM
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	CheekPuff,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	JawWidth,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	JawInOut,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	ChinWidth,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	ChinSize,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	EarSize,
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	EarAngle,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	HeadStretch
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class FaceShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private List<FaceShapePropertyData> FaceShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<FaceShapePropertyData> AllFaceShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB7EE00", Offset = "0xB7E200", VA = "0x180B7EE00")]
		public FaceShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct FaceShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public AvatarFaceShapeData.BMGPHLCKOHO FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public List<FacePropertySliderData> FacePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct FacePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public FGBECOOKEOM FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7990810", Offset = "0x798FC10", VA = "0x187990810")]
		public void DrawPosition(bool KOIDOLHMLNK, Transform NIBJBBEPHBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x79908B0", Offset = "0x798FCB0", VA = "0x1879908B0")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere KABKNNBLKNP, Transform GEFLCBDBKHP, Vector2 FMGALALJCDP, AnchorParamsRestrictions IOPKEJAOLLI, bool BIMDCCILOBC = false, bool EMAAMMECHNL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public FitMeshPreviewGizmo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum JCIMPJGFJKG
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	NoseWidth,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	NoseHeight,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	NoseLength,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	NoseAngle,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	NoseBulge,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	NosePinchFlair,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	NoseSneer,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	NoseTipScale
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NoseShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private List<NoseShapePropertyData> NoseShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<NoseShapePropertyData> AllNoseShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xB7EE00", Offset = "0xB7E200", VA = "0x180B7EE00")]
		public NoseShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct NoseShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public EKLJAOFDFFM NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public List<NosePropertySliderData> NosePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct NosePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public JCIMPJGFJKG NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x79968C0", Offset = "0x7995CC0", VA = "0x1879968C0")]
		public void DPDBGBLJLDP(SkinnedMeshRenderer DJKECNLDGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7996A70", Offset = "0x7995E70", VA = "0x187996A70")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		[Header("Remapping Eye Data")]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x798B170", Offset = "0x798A570", VA = "0x18798B170")]
		public void BCBAACPNAKC(GMMIFAFABHN PHHCLEBFMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x798B660", Offset = "0x798AA60", VA = "0x18798B660")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB5D430", Offset = "0xB5C830", VA = "0x180B5D430", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x798DC10", Offset = "0x798D010", VA = "0x18798DC10")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x798F270", Offset = "0x798E670", VA = "0x18798F270")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x77E2880", Offset = "0x77E1C80", VA = "0x1877E2880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x798F290", Offset = "0x798E690", VA = "0x18798F290")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x77E2AC0", Offset = "0x77E1EC0", VA = "0x1877E2AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x798F2B0", Offset = "0x798E6B0", VA = "0x18798F2B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA5E730", Offset = "0xA5DB30", VA = "0x180A5E730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1D2B850", Offset = "0x1D2AC50", VA = "0x181D2B850")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x798F2D0", Offset = "0x798E6D0", VA = "0x18798F2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x798EE60", Offset = "0x798E260", VA = "0x18798EE60", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x798F160", Offset = "0x798E560", VA = "0x18798F160")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x798FD70", Offset = "0x798F170", VA = "0x18798FD70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1921C40", Offset = "0x1921040", VA = "0x181921C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x14720F0", Offset = "0x14714F0", VA = "0x1814720F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1921C50", Offset = "0x1921050", VA = "0x181921C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x798FB30", Offset = "0x798EF30", VA = "0x18798FB30", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x798FC70", Offset = "0x798F070", VA = "0x18798FC70")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x7996E60", Offset = "0x7996260", VA = "0x187996E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7997B00", Offset = "0x7996F00", VA = "0x187997B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private readonly List<PKCCCOBBKFK<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9CD840", Offset = "0x9CCC40", VA = "0x1809CD840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9CD830", Offset = "0x9CCC30", VA = "0x1809CD830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x798FA80", Offset = "0x798EE80", VA = "0x18798FA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x798FAF0", Offset = "0x798EEF0", VA = "0x18798FAF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x798FA10", Offset = "0x798EE10", VA = "0x18798FA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x798FA60", Offset = "0x798EE60", VA = "0x18798FA60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x6DC9A20", Offset = "0x6DC8E20", VA = "0x186DC9A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x798F4F0", Offset = "0x798E8F0", VA = "0x18798F4F0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x798F630", Offset = "0x798EA30", VA = "0x18798F630", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x798F560", Offset = "0x798E960", VA = "0x18798F560")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x798F710", Offset = "0x798EB10", VA = "0x18798F710")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x798F2E0", Offset = "0x798E6E0", VA = "0x18798F2E0")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x798F810", Offset = "0x798EC10", VA = "0x18798F810")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class ANJGEPFOKAG
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7982120", Offset = "0x7981520", VA = "0x187982120")]
	public static JEPNDKFIAON MBKDHJOBIJO(this FaceFeatureType IBMEGOHDDJB, BJFLFCHJINB NMNEBNPOIJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class IKECNDGIGBG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct EDIILPMCFIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<IKECNDGIGBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private FMDNBBJKFJO.AIIJDPEBKKG <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x798E1F0", Offset = "0x798D5F0", VA = "0x18798E1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x798EA20", Offset = "0x798DE20", VA = "0x18798EA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private readonly Dictionary<string, int> DNKEPCIAALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool JMNBGNDJFIF;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Texture2DArray OPFNDKIAEKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public SymmetricalFaceFeature BFJNOILHDCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9CFD20", Offset = "0x9CF120", VA = "0x1809CFD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9CCC50", Offset = "0x9CC050", VA = "0x1809CCC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EyesFaceFeature MFGFOJINJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FaceFeature GFOGCFMDCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x7994450", Offset = "0x7993850", VA = "0x187994450")]
	private static void LHIHOPEJPAA(Sprite BIIKEEGLLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7994070", Offset = "0x7993470", VA = "0x187994070")]
	public static IKECNDGIGBG AEBELDBGCKG(SymmetricalFaceFeature DKFPCPGIMCG, EyesFaceFeature EHFMPFJCNFN, FaceFeature GGLIMPKBALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7994310", Offset = "0x7993710", VA = "0x187994310")]
	[AsyncStateMachine(typeof(EDIILPMCFIO))]
	public static Task<IKECNDGIGBG> JNINDIGDAHI(SymmetricalFaceFeature DKFPCPGIMCG, EyesFaceFeature EHFMPFJCNFN, FaceFeature GGLIMPKBALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7994D10", Offset = "0x7994110", VA = "0x187994D10")]
	private IKECNDGIGBG(SymmetricalFaceFeature DKFPCPGIMCG, EyesFaceFeature EHFMPFJCNFN, FaceFeature GGLIMPKBALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x79944C0", Offset = "0x79938C0", VA = "0x1879944C0")]
	private void MIHHKKEKBNO(List<Sprite> EHHEDHFINFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7994C20", Offset = "0x7994020", VA = "0x187994C20")]
	public bool NALFENFGGOC(string FEADKKBPHOM, [Out] int COPLIEINKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7994210", Offset = "0x7993610", VA = "0x187994210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7994100", Offset = "0x7993500", VA = "0x187994100")]
	public bool CMMDKLGDPDP(bool DLLKGPNFLON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7994240", Offset = "0x7993640", VA = "0x187994240")]
	public void FFBHHNIOGNI()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct CKOKKFKBAPP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public AsyncTaskMethodBuilder<IKECNDGIGBG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			private TaskAwaiter<IKECNDGIGBG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x798DC20", Offset = "0x798D020", VA = "0x18798DC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x798E120", Offset = "0x798D520", VA = "0x18798E120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private Dictionary<CEIANKIDECD, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private Dictionary<CEIANKIDECD, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private Dictionary<CEIANKIDECD, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private Dictionary<CEIANKIDECD, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly Dictionary<CEIANKIDECD, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private IKECNDGIGBG _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private IKECNDGIGBG _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x79907E0", Offset = "0x798FBE0", VA = "0x1879907E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7990580", Offset = "0x798F980", VA = "0x187990580")]
		public IKECNDGIGBG PKKPDNDFMCM(LOHMIPEBFLA EEBDILJINIH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7990150", Offset = "0x798F550", VA = "0x187990150")]
		[AsyncStateMachine(typeof(CKOKKFKBAPP))]
		public Task<IKECNDGIGBG> KHJMLGIMECF(int? IBAJHOIBNJN, int EHFMPFJCNFN, int GGLIMPKBALL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7990610", Offset = "0x798FA10", VA = "0x187990610")]
		public NoseFaceOption PNEGNKBGLGI(int PCAFMIDLJPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7990280", Offset = "0x798F680", VA = "0x187990280")]
		public SelectableFaceOption LIDEKJODBPI(FaceFeatureType JAPIFDOMPDD, CEIANKIDECD FMKKMDNPMIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x79900D0", Offset = "0x798F4D0", VA = "0x1879900D0")]
		public int IAMCPLDGEGM(CEIANKIDECD FMKKMDNPMIN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x798FEA0", Offset = "0x798F2A0", VA = "0x18798FEA0")]
		private void FKEGPPDAGJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x36962A0", Offset = "0x36956A0", VA = "0x1836962A0")]
		private void AFDPBEKKFMO<T>(IDictionary<CEIANKIDECD, T> CGCBFDCMBPH, IReadOnlyList<T> DJHCFIJIFEH) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x798FD90", Offset = "0x798F190", VA = "0x18798FD90")]
		public CEIANKIDECD FJKNJPFIGND(FaceFeatureType JAPIFDOMPDD)
		{
			return default(CEIANKIDECD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7990400", Offset = "0x798F800", VA = "0x187990400")]
		public CEIANKIDECD OLGDDMJOMNM(FaceFeatureType JAPIFDOMPDD)
		{
			return default(CEIANKIDECD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x79906B0", Offset = "0x798FAB0", VA = "0x1879906B0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xBB21D0", Offset = "0xBB15D0", VA = "0x180BB21D0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x798FC70", Offset = "0x798F070", VA = "0x18798FC70")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public EKLJAOFDFFM SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xBA6200", Offset = "0xBA5600", VA = "0x180BA6200", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xB7EE00", Offset = "0xB7E200", VA = "0x180B7EE00")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		[SerializeField]
		private bool isNew;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public CEIANKIDECD FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1D57C80", Offset = "0x1D57080", VA = "0x181D57C80")]
			get
			{
				return default(CEIANKIDECD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xD4A610", Offset = "0xD49A10", VA = "0x180D4A610")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD4A620", Offset = "0xD49A20", VA = "0x180D4A620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x798B0C0", Offset = "0x798A4C0", VA = "0x18798B0C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xB7EE00", Offset = "0xB7E200", VA = "0x180B7EE00")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7996DE0", Offset = "0x79961E0", VA = "0x187996DE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6DC5880", Offset = "0x6DC4C80", VA = "0x186DC5880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7996E20", Offset = "0x7996220", VA = "0x187996E20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x6DC5890", Offset = "0x6DC4C90", VA = "0x186DC5890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7996E00", Offset = "0x7996200", VA = "0x187996E00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x6DC8C50", Offset = "0x6DC8050", VA = "0x186DC8C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7996E40", Offset = "0x7996240", VA = "0x187996E40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6DC8C40", Offset = "0x6DC8040", VA = "0x186DC8C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7996B00", Offset = "0x7995F00", VA = "0x187996B00", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7996D10", Offset = "0x7996110", VA = "0x187996D10")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class GIKNEJAMCIA
{
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly float FNKDLBEJKGL;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly float OOINDNDAPGM;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Vector2 JFFNNILGPGN;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Vector2 BCLJPNDPANL;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Vector2 JIDGKFINFKJ;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Vector2 KNOLFNPAMLL;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Vector2 FCDBMKFJDCF;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Vector2 KEONONDNOOM;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Vector2 JOAHLCIJBMH;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Vector2 BCEGFEPJLCG;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Vector2 IOFJFEGBJAL;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Vector2 OIEEGGFKLAN;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Vector2 EACHFHODGOJ;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Vector2 MLLKHGDJNCG;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7990F70", Offset = "0x7990370", VA = "0x187990F70")]
	public static Vector2 AMHPLFKPOLI(FaceFeatureType IBMEGOHDDJB, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x79933B0", Offset = "0x79927B0", VA = "0x1879933B0")]
	public static float MAFKGBCNBPH(FaceFeatureType IBMEGOHDDJB, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7991510", Offset = "0x7990910", VA = "0x187991510")]
	public static void DMADDNELHBC(GMMIFAFABHN GFJBGILENMA, AvatarConfiguration DOGJIOIGOCA, LOHMIPEBFLA HAGOHDDIOKI, LOHMIPEBFLA LEEGHCHFEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x79912D0", Offset = "0x79906D0", VA = "0x1879912D0")]
	public static float BIEPPEALPBB(FaceFeatureType JAPIFDOMPDD, float LPDCNHLGHCB, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7991FD0", Offset = "0x79913D0", VA = "0x187991FD0")]
	public static float GLBKMEGFEKF(FaceFeatureType JAPIFDOMPDD, float IDAOOBNOFGA, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7991360", Offset = "0x7990760", VA = "0x187991360")]
	public static float BPEIGMBOGHL(FaceFeatureType JAPIFDOMPDD, float PNEDBEMJDJJ, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7991480", Offset = "0x7990880", VA = "0x187991480")]
	public static float DCIDGJKHOLE(FaceFeatureType JAPIFDOMPDD, float OEKMAIKEGFB, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x79913F0", Offset = "0x79907F0", VA = "0x1879913F0")]
	public static float CBMJFIFPJFI(FaceFeatureType JAPIFDOMPDD, float CMPAPBNNJEI, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x79935A0", Offset = "0x79929A0", VA = "0x1879935A0")]
	public static float MDMIGPIJODE(FaceFeatureType JAPIFDOMPDD, float OMCKAMAKMMA, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7991880", Offset = "0x7990C80", VA = "0x187991880")]
	public static Vector2 ECHENGIDCNI(FaceFeatureType JAPIFDOMPDD, Vector2 LJELBPGLBJP, Vector2 JJICHINIFEN, Vector2 LGIDNOCHKOF, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7992280", Offset = "0x7991680", VA = "0x187992280")]
	public static Vector2 IACBKEOKELA(FaceFeatureType JAPIFDOMPDD, Vector2 JAELDEOGPAD, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7991E60", Offset = "0x7991260", VA = "0x187991E60")]
	private static Vector2 GFMJCLGLOGO(FaceFeatureType JAPIFDOMPDD, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7993040", Offset = "0x7992440", VA = "0x187993040")]
	private static Vector2 LDHMBDDHPPE(FaceFeatureType JAPIFDOMPDD, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x79915D0", Offset = "0x79909D0", VA = "0x1879915D0")]
	private static Vector2 DMOCPFDMBGP(FaceFeatureType JAPIFDOMPDD, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7991B20", Offset = "0x7990F20", VA = "0x187991B20")]
	private static Vector2 FMLADKKFIFC(FaceFeatureType JAPIFDOMPDD, Vector2 LJELBPGLBJP, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7992BB0", Offset = "0x7991FB0", VA = "0x187992BB0")]
	public static Vector2 KEFBLBCEOKD(FaceFeatureType JAPIFDOMPDD, Vector2 JAELDEOGPAD, Vector2 JJICHINIFEN, Vector2 LGIDNOCHKOF, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7992060", Offset = "0x7991460", VA = "0x187992060")]
	public static float HEJBENPGAPK(FaceFeatureType JAPIFDOMPDD, float IDAOOBNOFGA, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7993980", Offset = "0x7992D80", VA = "0x187993980")]
	public static float NCKPBHEJICD(FaceFeatureType JAPIFDOMPDD, float PNEDBEMJDJJ, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7991950", Offset = "0x7990D50", VA = "0x187991950")]
	public static float EKMLBLGIFFJ(FaceFeatureType JAPIFDOMPDD, float OEKMAIKEGFB, LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x79924E0", Offset = "0x79918E0", VA = "0x1879924E0")]
	private static float IAIPHOHFLLK(float JLCBKIPFKML, float CBHAMKJGEOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7991CF0", Offset = "0x79910F0", VA = "0x187991CF0")]
	private static Vector2 GCFHAFJIANP(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7991220", Offset = "0x7990620", VA = "0x187991220")]
	private static Vector2 BBFAHICPEDP(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7993630", Offset = "0x7992A30", VA = "0x187993630")]
	private static Vector2 MEMLPBEAMKK(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7992630", Offset = "0x7991A30", VA = "0x187992630")]
	private static Vector2 IPLDEMDOFPO(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7993A20", Offset = "0x7992E20", VA = "0x187993A20")]
	private static float NHLOLHDFMGD(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7992B40", Offset = "0x7991F40", VA = "0x187992B40")]
	private static float JPMDBBJDJEJ(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x79937A0", Offset = "0x7992BA0", VA = "0x1879937A0")]
	private static float MMCIENFGDHC(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x79919F0", Offset = "0x7990DF0", VA = "0x1879919F0")]
	private static float FAOANGIBALA(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x79938C0", Offset = "0x7992CC0", VA = "0x1879938C0")]
	private static Vector2 MPKICKDMANO(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x79926E0", Offset = "0x7991AE0", VA = "0x1879926E0")]
	private static Vector2 JBEOFOMFCDJ(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7993C10", Offset = "0x7993010", VA = "0x187993C10")]
	private static Vector2 NPGLMHNDKMN(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x79927A0", Offset = "0x7991BA0", VA = "0x1879927A0")]
	private static Vector2 JEGMIIMABJI(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7993810", Offset = "0x7992C10", VA = "0x187993810")]
	private static Vector2 MPDHAHDOBEH(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7993D80", Offset = "0x7993180", VA = "0x187993D80")]
	private static Vector2 OMMAKMBDCDM(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7992570", Offset = "0x7991970", VA = "0x187992570")]
	private static Vector2 ILMGLILPDNH(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7990EB0", Offset = "0x79902B0", VA = "0x187990EB0")]
	private static Vector2 AJHFIACLPHI(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7993CD0", Offset = "0x79930D0", VA = "0x187993CD0")]
	private static Vector2 ODLIEFOHJEK(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7992910", Offset = "0x7991D10", VA = "0x187992910")]
	private static Vector2 JGGIEOHDGNO(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7992A80", Offset = "0x7991E80", VA = "0x187992A80")]
	private static Vector2 JLNBOCNLOJM(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7993B50", Offset = "0x7992F50", VA = "0x187993B50")]
	private static Vector2 NLGFHMHAHAH(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x79932F0", Offset = "0x79926F0", VA = "0x1879932F0")]
	private static Vector2 LDNKHMMMFLI(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x79936E0", Offset = "0x7992AE0", VA = "0x1879936E0")]
	private static Vector2 MHILFECCJGE(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7992850", Offset = "0x7991C50", VA = "0x187992850")]
	private static Vector2 JFICNDIMIDN(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7990DF0", Offset = "0x79901F0", VA = "0x187990DF0")]
	private static Vector2 AEAMFHJCENB(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7991A60", Offset = "0x7990E60", VA = "0x187991A60")]
	private static Vector2 FIDOPOAKJKI(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x79929C0", Offset = "0x7991DC0", VA = "0x1879929C0")]
	private static Vector2 JJDDOMHHLFN(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7991DA0", Offset = "0x79911A0", VA = "0x187991DA0")]
	private static Vector2 GEJFECNHDIF(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7993A90", Offset = "0x7992E90", VA = "0x187993A90")]
	private static Vector2 NIDOEBCJMJM(LOHMIPEBFLA EEBDILJINIH, AvatarConfiguration BOICKNJEBMF)
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
