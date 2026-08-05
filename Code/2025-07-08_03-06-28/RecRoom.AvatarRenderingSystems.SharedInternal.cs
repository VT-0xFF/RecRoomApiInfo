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
		[Cpp2IlInjected.Address(RVA = "0x7F39B40", Offset = "0x7F38940", VA = "0x187F39B40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		public AvatarFaceShapeData.OKAOPGEJICN FaceShapeName;

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
		public AvatarBodyShapeData.LMFFFLIEJEF BodyShapeName;

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
		public BLODKKHJEPD BodyProperty;

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
		public KFIOGNHKBDM FaceProperty;

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
		public MMHOGHLBOGJ NoseProperty;

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
		public BDLLACEJLDO NoseType;

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
		public BLODKKHJEPD BodyProperty;

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
		public KFIOGNHKBDM FaceProperty;

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
		public MMHOGHLBOGJ NoseProperty;

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
		public BKPKMIPFKEI PropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Flags]
public enum BKPKMIPFKEI
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
		private sealed class EHLLKFFDPGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public EHLLKFFDPGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7F46E20", Offset = "0x7F45C20", VA = "0x187F46E20")]
			internal bool PBOBGPMODIL(KeyValuePair<string, Transform> bone)
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
		private List<AvatarFaceShapeData.OKAOPGEJICN> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private List<AvatarBodyShapeData.LMFFFLIEJEF> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<BLODKKHJEPD, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Dictionary<KFIOGNHKBDM, List<float>> facePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Dictionary<MMHOGHLBOGJ, List<float>> nosePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(string, AvatarFaceShapeData.OKAOPGEJICN), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(string, AvatarBodyShapeData.LMFFFLIEJEF), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<(string, BDLLACEJLDO), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<(string, BLODKKHJEPD, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<BLODKKHJEPD, Dictionary<string, BKPKMIPFKEI>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<(string, KFIOGNHKBDM, float), AvatarBodyPartBoneData> facePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Dictionary<KFIOGNHKBDM, Dictionary<string, BKPKMIPFKEI>> facePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Dictionary<(string, MMHOGHLBOGJ, float), AvatarBodyPartBoneData> nosePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Dictionary<MMHOGHLBOGJ, Dictionary<string, BKPKMIPFKEI>> nosePropertyBoneInfluenceInfoMapping;

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
		private readonly Dictionary<BLODKKHJEPD, string[]> bonesToUpdatePerBodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly Dictionary<KFIOGNHKBDM, string[]> bonesToUpdatePerFaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Dictionary<MMHOGHLBOGJ, string[]> bonesToUpdatePerNoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Dictionary<string, Dictionary<BKPKMIPFKEI, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7F40DB0", Offset = "0x7F3FBB0", VA = "0x187F40DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F3B130", Offset = "0x7F39F30", VA = "0x187F3B130")]
		public void DGPDNICIDDD(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F3FE80", Offset = "0x7F3EC80", VA = "0x187F3FE80")]
		public void PPDLKIKIALD(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, AvatarFaceShapeData.OKAOPGEJICN JDNNLNAFKHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F3FA60", Offset = "0x7F3E860", VA = "0x187F3FA60")]
		public void PKHIDAEAJHG(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, BDLLACEJLDO ANFNFAKDIEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F550", Offset = "0x7F3E350", VA = "0x187F3F550")]
		public void MKMCKJPBDDD(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, AvatarBodyShapeData.LMFFFLIEJEF MHODDHFLFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F3AD10", Offset = "0x7F39B10", VA = "0x187F3AD10")]
		public void AOKNFOGFHKE(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, IReadOnlyDictionary<string, HDCLNPHPCJG> CPDGPKKJBGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F3ED60", Offset = "0x7F3DB60", VA = "0x187F3ED60")]
		public IReadOnlyDictionary<string, HDCLNPHPCJG> IIMPGABDNMF(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EC60", Offset = "0x7F3DA60", VA = "0x187F3EC60")]
		public Dictionary<string, HDCLNPHPCJG> HGMGOMGAMIP(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, IReadOnlyDictionary<BLODKKHJEPD, float> DMNGGDCBIML, IReadOnlyDictionary<string, HDCLNPHPCJG> HAHHGMBFJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F950", Offset = "0x7F3E750", VA = "0x187F3F950")]
		public Dictionary<string, HDCLNPHPCJG> PGNBILMLECO(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, IReadOnlyDictionary<KFIOGNHKBDM, float> JHBIJDBOGMF, IReadOnlyDictionary<string, HDCLNPHPCJG> HAHHGMBFJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F150", Offset = "0x7F3DF50", VA = "0x187F3F150")]
		public Dictionary<string, HDCLNPHPCJG> JBHIHFOGOOD(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, IReadOnlyDictionary<MMHOGHLBOGJ, float> OCIEGDFODEB, IReadOnlyDictionary<string, HDCLNPHPCJG> HAHHGMBFJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x392EEB0", Offset = "0x392DCB0", VA = "0x18392EEB0")]
		private Dictionary<string, HDCLNPHPCJG> CELBFKMCGFN<T>(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, IReadOnlyDictionary<T, float> AECNAMJIGMF, IReadOnlyDictionary<string, HDCLNPHPCJG> EMFOOLMLIOG, Dictionary<T, Dictionary<string, BKPKMIPFKEI>> OCIEDAIDJIK, Dictionary<(string, T, float), AvatarBodyPartBoneData> EKFJGMJHHGA, bool OGNNLPHDFNL, bool HBBMDIKIPJP, [Optional] float? HHHFLAFEAKC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F850", Offset = "0x7F3E650", VA = "0x187F3F850")]
		public static (float, float) MKONOBOMMNC(float HDDOMHFGGKH)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3ED00", Offset = "0x7F3DB00", VA = "0x187F3ED00")]
		public float IFDJKFFGBNF(BLODKKHJEPD HNGOMAMNADF, float AKKOKBIJICM)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F3DAC0", Offset = "0x7F3C8C0", VA = "0x187F3DAC0")]
		public float FKFNCILFCPH(KFIOGNHKBDM CAGKPDNHBMJ, float BDFELMNNHDN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F8E0", Offset = "0x7F3E6E0", VA = "0x187F3F8E0")]
		public float OEIPINJEFEG(MMHOGHLBOGJ OACBPNAGKHA, float LCDGDCNCKHG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3930330", Offset = "0x392F130", VA = "0x183930330")]
		private float MBDHJDBJHFF<T>(T DAGPCGHBFAL, float HNDPDPPBDNP, Dictionary<T, List<float>> FHMHHKNEAJD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F2D0", Offset = "0x7F3E0D0", VA = "0x187F3F2D0")]
		private HDCLNPHPCJG KNMHPBJHPCP(IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, string GFAKNNDBMFM)
		{
			return default(HDCLNPHPCJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F450", Offset = "0x7F3E250", VA = "0x187F3F450")]
		private float MDGIBKJAHGC(float BNECONOIKOE, List<float> PANNBKLBHOF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EBF0", Offset = "0x7F3D9F0", VA = "0x187F3EBF0")]
		private Vector3 GPHBBGJHJFO(Transform KGECAEKBFAN, AvatarBodyPartBoneData PCFOJOJNCOJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F3DA60", Offset = "0x7F3C860", VA = "0x187F3DA60")]
		private Quaternion FKAELGLKGCH(Transform KGECAEKBFAN, AvatarBodyPartBoneData PCFOJOJNCOJ)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F9F0", Offset = "0x7F3E7F0", VA = "0x187F3F9F0")]
		private Vector3 PHCHAHKLICA(Transform KGECAEKBFAN, AvatarBodyPartBoneData PCFOJOJNCOJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F3DB30", Offset = "0x7F3C930", VA = "0x187F3DB30")]
		private void GLIDMLKIOGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70AD400", Offset = "0x70AC200", VA = "0x1870AD400")]
		public bool GOGBMGGAKPL(BKPKMIPFKEI EJKEIACNBEL, BKPKMIPFKEI GDMCELABPFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F39CD0", Offset = "0x7F38AD0", VA = "0x187F39CD0")]
		private HDCLNPHPCJG AIPEOGIOLOI(BKPKMIPFKEI LFFMHEHEIEP, HDCLNPHPCJG KGECAEKBFAN, AvatarBodyPartBoneData PCFOJOJNCOJ)
		{
			return default(HDCLNPHPCJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D200", Offset = "0x7F3C000", VA = "0x187F3D200")]
		public Dictionary<string, HDCLNPHPCJG> FBLJADDDKEJ(Dictionary<string, HDCLNPHPCJG> JCLJMKCAAGO, bool OGNNLPHDFNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D890", Offset = "0x7F3C690", VA = "0x187F3D890")]
		private void FIBACHMGKOH(Transform KGECAEKBFAN, AvatarBodyPartBoneData PCFOJOJNCOJ, bool JNOEIHKLGCK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F40400", Offset = "0x7F3F200", VA = "0x187F40400")]
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
		public BLODKKHJEPD BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float BodyPropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7F40EB0", Offset = "0x7F3FCB0", VA = "0x187F40EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum LMFFFLIEJEF
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
		public LMFFFLIEJEF blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[HideInInspector]
		[Obsolete("Use BodyShapeId instead!")]
		[SerializeField]
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
		private AvatarBodyShapeData.LMFFFLIEJEF blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NCJALFIEICP BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x20202A0", Offset = "0x201F0A0", VA = "0x1820202A0")]
			get
			{
				return default(NCJALFIEICP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.LMFFFLIEJEF BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCFF240", Offset = "0xCFE040", VA = "0x180CFF240")]
			get
			{
				return default(AvatarBodyShapeData.LMFFFLIEJEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F41970", Offset = "0x7F40770", VA = "0x187F41970")]
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
		public AvatarBodyShapeData.LMFFFLIEJEF BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F411D0", Offset = "0x7F3FFD0", VA = "0x187F411D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
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
		private readonly Dictionary<NCJALFIEICP, AvatarBodyShape> GBBBPADJEEO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F41450", Offset = "0x7F40250", VA = "0x187F41450")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F41770", Offset = "0x7F40570", VA = "0x187F41770")]
		public AvatarBodyShape Find(NCJALFIEICP DGAOEDCMPNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F41880", Offset = "0x7F40680", VA = "0x187F41880")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F41840", Offset = "0x7F40640", VA = "0x187F41840")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F418C0", Offset = "0x7F406C0", VA = "0x187F418C0")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MMMPMMIOIJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Transform[] BCABKMIBLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<string, Transform> GOPAKCGFDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Transform, Transform> DEEIMEHNIPF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> JCNLDNPOKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] PHIEOCKNAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DFE0", Offset = "0x7F4CDE0", VA = "0x187F4DFE0")]
	public void JADEMDDHMBF(Transform AFIDPPDCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DDA0", Offset = "0x7F4CBA0", VA = "0x187F4DDA0")]
	public Transform CGMDJEJKIAL(Transform JFBINFACHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E0C0", Offset = "0x7F4CEC0", VA = "0x187F4E0C0")]
	public void KEACPJADMCI(SkinnedMeshRenderer FJDBDFIPIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DE80", Offset = "0x7F4CC80", VA = "0x187F4DE80")]
	private static void CJIMCBMDJID(Transform EGPDFGOHLFM, List<Transform> HHNJKGDJJAI, Dictionary<string, Transform> KDBIMPMGGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E300", Offset = "0x7F4D100", VA = "0x187F4E300")]
	public MMMPMMIOIJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KLFJIDEFFIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool CEOCMFMBDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool MJFOABELJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool EFGIMADLAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public JPHJMMINMCH? KIHILNCNNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public KIECLADILAP.NMBEIOMGMML OCMDIDCKEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public HairData BDOGFBLNJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public AdditionalHatData NGHPGHDKHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool BFJFECGJBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public bool PMEFAIMFIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public bool IJPFIJKJMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public bool KGLJHPBADFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public IList<MAJDLGCOKCC> FADBMGHGMFO;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public KLFJIDEFFIK()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("How far apart you can position your eyebrows.")]
		[Header("Face Features")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("Min/Max rotation angle for your eyebrows.")]
		public Vector2 EyebrowsRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Min/Max aspect for your eyebrows.")]
		public Vector2 EyebrowAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Min/Max rotation angle for your eyes.")]
		public Vector2 EyeRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Min/Max aspect for your eyes.")]
		public Vector2 EyeAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Min/Max rotation angle for your mouth.")]
		public Vector2 MouthRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Min/Max aspect for your mouth.")]
		public Vector2 MouthAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Min/Max rotation angle for your nose.")]
		public Vector2 NoseRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Min/Max aspect for your nose.")]
		public Vector2 NoseAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Tooltip("Min uv for eyes")]
		public Vector2 EyeLimitsMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[Tooltip("Max uv for eyes")]
		public Vector2 EyeLimitsMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[Header("Body Shapes")]
		public BodyShapeConfiguration BodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[Header("Face Shapes")]
		public FaceShapeConfiguration FaceShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[Header("Nose Shapes")]
		public NoseShapeConfiguration NoseShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Header("Data Migration Managers")]
		public AvatarDataRangeMigrationsManager AvatarDataRangeMigrationsManager;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7F41A00", Offset = "0x7F40800", VA = "0x187F41A00")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum PMJDFCMACFJ
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
		public PMJDFCMACFJ RangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Vector2 Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public KHCGBJGPDFI Version;
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
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OIKDJMFHLBD
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static FGLPGOLGBPH EMMFCOPFBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E560", Offset = "0x7F4D360", VA = "0x187F4E560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static BHJLPMKOMMK BFMFNIFHJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E430", Offset = "0x7F4D230", VA = "0x187F4E430")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EDCEPGLIIGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public Transform FKNLMJCACKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public AvatarSkinAssetItem JONOGDNMIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public AssetReference CGALKKDFGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public GameObject GOLJJBPMPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public GameObject FAIHHGODGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public SkinnedMeshRenderer IOAHNCCLFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public AvatarSkinnedMeshBoneOrderRemapsData APCLHCFJHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Material FNDHHKCJONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Material NNIBLIKKJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Material FMBBODLLIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Material JPACMFIKEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public Shader GNLAPMPFHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Shader OHFDCDBJLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Animator ALJDMDDFALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Renderer[] NHOMGOFFNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public AvatarConfiguration CNIFEEJALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public AvatarBodyPartShapesManager IJMEKPFKFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public IReadOnlyDictionary<string, Transform> HMNLCLDHDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Transform IIAALKEGJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public PKNFPGJAIIB NCIHFOBJIHK;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct LOFAAGOONHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public SkinnedMeshRenderer[] PNGMIDBDOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public SkinnedMeshRenderer[] DFGFFKKHIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public SkinnedMeshRenderer[] BEEENKKFCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public SkinnedMeshRenderer[] DOKJFOKPPIA;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct NHIEONBOHOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform FDBAJFBKAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform LMDHOHILAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform EAPHNPHMNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform JFGIACPGCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform HACFLHIKIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Transform MPCICLHOJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public AvatarConfiguration CNIFEEJALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public PKNFPGJAIIB NCIHFOBJIHK;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct CBJMEBCKBKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public SkinnedMeshRenderer[] IEHBCIJHLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Material GCAGEAHFAGK;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct OIKNEBEGIMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public BMBJBMCPIGG LEKFMNHKIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public int BGMCCJCBKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Color GBBKFINHFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Color JIDOECMGLBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int IJABPNMAJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Color GCMDHAMGNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Color FIOMNNCAENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int BNNJOIPJAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float LNMFGFBFCCG;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct NJABEJKMDLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public BMBJBMCPIGG LEKFMNHKIHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Vector2 FPLGOOPFLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float AHKKMHDODHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float MGCNELKHHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float CDBLHLKJHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Vector2 PJENPHCOIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public float PLJJPEMGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public float EGAMJDOBCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float OFCGACHPKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector2 MHOINDGHBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public float IJABCBLIEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public float OBPCIJBGPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public float FIPNGEBEOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Vector2 MMHEIGEAFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float MPBGGKMHMIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public float LNMFGFBFCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public float JBNKIOMIKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public bool LJHECOMBPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public bool JBAMAGHDKGC;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public KFIOGNHKBDM FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public float FacePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F42070", Offset = "0x7F40E70", VA = "0x187F42070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum OKAOPGEJICN
		{
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public OKAOPGEJICN blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[Obsolete("Use FaceShapeId instead!")]
		[HideInInspector]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private AvatarFaceShapeData.OKAOPGEJICN blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BMCGFMAECEA FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x20202A0", Offset = "0x201F0A0", VA = "0x1820202A0")]
			get
			{
				return default(BMCGFMAECEA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.OKAOPGEJICN BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xCFF240", Offset = "0xCFE040", VA = "0x180CFF240")]
			get
			{
				return default(AvatarFaceShapeData.OKAOPGEJICN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7F42B30", Offset = "0x7F41930", VA = "0x187F42B30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F42B90", Offset = "0x7F41990", VA = "0x187F42B90")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AvatarFaceShapeData.OKAOPGEJICN FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F42390", Offset = "0x7F41190", VA = "0x187F42390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly Dictionary<BMCGFMAECEA, AvatarFaceShape> GBBBPADJEEO;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F42610", Offset = "0x7F41410", VA = "0x187F42610")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7F42930", Offset = "0x7F41730", VA = "0x187F42930")]
		public AvatarFaceShape Find(BMCGFMAECEA PCBCIJEMABK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7F42A40", Offset = "0x7F41840", VA = "0x187F42A40")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7F42A00", Offset = "0x7F41800", VA = "0x187F42A00")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F42A80", Offset = "0x7F41880", VA = "0x187F42A80")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F431F0", Offset = "0x7F41FF0", VA = "0x187F431F0")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public FNALMPKNBLO HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x20202A0", Offset = "0x201F0A0", VA = "0x1820202A0")]
			get
			{
				return default(FNALMPKNBLO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD238D0", Offset = "0xD226D0", VA = "0x180D238D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD58A40", Offset = "0xD57840", VA = "0x180D58A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7F433E0", Offset = "0x7F421E0", VA = "0x187F433E0")]
		public Texture2D LJMLHIKMDOE(HairPatternStyle LLAOJIJPLGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7F43270", Offset = "0x7F42070", VA = "0x187F43270", Slot = "0")]
		public override bool Equals(object MKPNGAKJFMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F43200", Offset = "0x7F42000", VA = "0x187F43200", Slot = "4")]
		public bool Equals(AvatarHairPattern LOKLFHKEJPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F43530", Offset = "0x7F42330", VA = "0x187F43530", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F43320", Offset = "0x7F42120", VA = "0x187F43320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7F433B0", Offset = "0x7F421B0", VA = "0x187F433B0")]
		public static bool KKINNKAIEFB(AvatarHairPattern PHLJLBDJNIE, AvatarHairPattern GEOHFJAPCHG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7F43330", Offset = "0x7F42130", VA = "0x187F43330")]
		public static bool HAHIHKOBLPE(AvatarHairPattern PHLJLBDJNIE, AvatarHairPattern GEOHFJAPCHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7F43570", Offset = "0x7F42370", VA = "0x187F43570")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum GDNBFNJLEDA
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
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum DPBJDHGJEHD
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
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ENMFPOBIHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Animator EKBJLLBFGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public LOOMHCPHCKH KNIABPFNANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public AvatarConfiguration CNIFEEJALDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public GameObject GCPBCPOPKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public PKNFPGJAIIB NCIHFOBJIHK;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct DOPNBHJAEIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Transform BOBDGGMNFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public bool HMBNIDNNJJO;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7F43680", Offset = "0x7F42480", VA = "0x187F43680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class MAJDLGCOKCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public string OFMLOIDKMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public OutfitType PKMNEOBCBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public EEPOCEICAIB PBGOGNDNPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public KIECLADILAP.NMBEIOMGMML AAMPJLGLHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public bool IIAEJEEMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public bool DGEODCFJBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public bool POBFBLNOCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Color? HKNLGBHPOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool LFDMHFMGICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Color? HHLKLCFFBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool GIPDDIACEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public bool MJHELNDNEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool JGJKFJLCALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Transform KDDILICKNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector2? GODEHCCOCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public FitMeshHemisphere MNGAJOKDDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public AssetReference DCKFMCEGCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public AssetReference OCAGCNOBKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public AssetReference[] AFNFMMMNNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public MAJDLGCOKCC DNIHMNALHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public bool OGLCAGFFFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public bool KGEDDBCAJLA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string NHFKAFLKGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DCE0", Offset = "0x7F4CAE0", VA = "0x187F4DCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DCE0", Offset = "0x7F4CAE0", VA = "0x187F4DCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4DD90", Offset = "0x7F4CB90", VA = "0x187F4DD90")]
	public MAJDLGCOKCC()
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
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private HLNBCOGMHLF? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MKELHNOGKHJ CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7F43C20", Offset = "0x7F42A20", VA = "0x187F43C20")]
			get
			{
				return default(MKELHNOGKHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HLNBCOGMHLF MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7F43C50", Offset = "0x7F42A50", VA = "0x187F43C50")]
			get
			{
				return default(HLNBCOGMHLF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA5F360", Offset = "0xA5E160", VA = "0x180A5F360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA5F330", Offset = "0xA5E130", VA = "0x180A5F330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F43900", Offset = "0x7F42700", VA = "0x187F43900")]
		public Material[] HDCIJNAPPPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F43710", Offset = "0x7F42510", VA = "0x187F43710")]
		public static void EMCMAAAJOAB(AvatarItemMaterial GNMDFOANMEG, Material KKBOKCGIENM, int CABFKOOGELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F439F0", Offset = "0x7F427F0", VA = "0x187F439F0")]
		private static bool LCDEEMLEEAA(AvatarItemMaterial GNMDFOANMEG, int CABFKOOGELP, [Out] Material HBOEEBIFGAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F43BA0", Offset = "0x7F429A0", VA = "0x187F43BA0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FBKAKPJJBLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public SkinnedMeshRenderer HKIJEDILDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Material[] HKFMCFIPOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private byte[] LALMCLPMBAN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh COIEPNIHABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F474D0", Offset = "0x7F462D0", VA = "0x187F474D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Material[] PGHMFBFLLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public byte[] AFEDEINIGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7F474F0", Offset = "0x7F462F0", VA = "0x187F474F0")]
	public FBKAKPJJBLC(SkinnedMeshRenderer OJGKICIDJAB, AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF, Material[] OBPGGJPDFPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7F47330", Offset = "0x7F46130", VA = "0x187F47330")]
	public static FBKAKPJJBLC KFCCEOKLEDB(Renderer MIFBMDMJHAH, AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF, Material[] OBPGGJPDFPN)
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
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x164DFF0", Offset = "0x164CDF0", VA = "0x18164DFF0")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xD846B0", Offset = "0xD834B0", VA = "0x180D846B0")]
		public void LAGAMOKKAFA(Vector3 EMECBHNHILC, Quaternion NOLDGDLLBBL)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class IINMMPAPMLK
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A830", Offset = "0x7F49630", VA = "0x187F4A830")]
	public static PositionAndRotation NLIBMJAEAEH(this PositionAndRotation FKLJFLPHCIE)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A620", Offset = "0x7F49420", VA = "0x187F4A620")]
	public static float GOLBKJMOGKB(float ODOKMLFIJNG, Vector2 GJBIOJHLHMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A5A0", Offset = "0x7F493A0", VA = "0x187F4A5A0")]
	public static float GOLBKJMOGKB(float ODOKMLFIJNG, float IIEOAHPEFEA, float KNIALLIIKDG, float PFNOCLOHBOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A6C0", Offset = "0x7F494C0", VA = "0x187F4A6C0")]
	public static float LOOIGOINCMC(float BNECONOIKOE, Vector2 GJBIOJHLHMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A780", Offset = "0x7F49580", VA = "0x187F4A780")]
	public static float LOOIGOINCMC(float BNECONOIKOE, float IIEOAHPEFEA, float KNIALLIIKDG, float PFNOCLOHBOA)
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
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public MMHOGHLBOGJ NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public float NosePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7F43D10", Offset = "0x7F42B10", VA = "0x187F43D10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarNosePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public BDLLACEJLDO NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7F44030", Offset = "0x7F42E30", VA = "0x187F44030", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum LHKLLOAONCN
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	GiveTake = 4,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum LLNAFKIBAKK
{
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	IdleSwayAimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	IdleSwayMeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	IdleSwayLightItem,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	IdleSwayHeavyItem,
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	IdleSwayAimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	FastAction,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	NumTypes
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum JBOCHFILNBO
{
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	PotatoAvatar,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	FullOutfitAvatar
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct JFDBJABHPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Vector2 LAGPNKNHFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Vector2 LMIEBMJJEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector2 MMCNDCIBFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector2 MJPMHMHDJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector2 PHIDFOKNOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector2 LEEHOLAELNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector2 OBLCPBIOPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector2 HBBMACEALIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Vector2 HKHLHAFLBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public Vector2 HCEPKGKFLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Vector2 NJOFKECCMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector2 BNEFBHDPCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector2 IOENONGILIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector2 PPLLPKPOHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector2 NGICMFGAKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Vector2 KGNABMNDLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public float LFDGDLEMKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public float MAGNPAMCNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float BMHFIJPEJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public float NAHMNHJOEAF;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class BOGLIAIICJD
{
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly int IFAPFOFDJIO;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly string HBNOOOLALIL;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F462E0", Offset = "0x7F450E0", VA = "0x187F462E0")]
	public static EDCEPGLIIGB GBGBLHADDFL(Transform PCEIPJOAMMK, AvatarSkinAssetItem DDOIKDHNBBP, AssetReference CNMJIKKKINN, GameObject DEJPCPGAFOM, GameObject ELJCFDKBABE, SkinnedMeshRenderer ELIOKECAKGB, AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF, Material AAFHLFGHMCO, Material LFCHGJDCOPD, Material BNLKCHICLJG, Material KANKJNPAHEJ, Shader EBGNJFILKJA, Shader GILOJGGDGBN, Animator FIMEHCPBPJO, Renderer[] MDOCCJOOHGB, AvatarConfiguration JHKNFPILNDE, AvatarBodyPartShapesManager FMLBDOOHDDL, IReadOnlyDictionary<string, Transform> NKDBKJFFGGN, Transform CLJNBGLMKFB, PKNFPGJAIIB AFDMCKAKEMD)
	{
		return default(EDCEPGLIIGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7F464D0", Offset = "0x7F452D0", VA = "0x187F464D0")]
	public static LOFAAGOONHO IAAMHONEPON(SkinnedMeshRenderer[] JNBGGPKAMCG, SkinnedMeshRenderer[] GPEPHAAEPJM, SkinnedMeshRenderer[] EOOHLGABJOK, SkinnedMeshRenderer[] ALOENAIMOAA)
	{
		return default(LOFAAGOONHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7F46590", Offset = "0x7F45390", VA = "0x187F46590")]
	public static NHIEONBOHOM JOPKFLBJIEH(Transform PMDIPLDCHHF, Transform CJJPOPHFDMK, Transform MBPANDAEIKO, Transform MFJJMFJMLPC, Transform MIJMFHIHHGC, Transform JIGFFDMHDMD, AvatarConfiguration LDLJKPNAGIO, PKNFPGJAIIB AFDMCKAKEMD)
	{
		return default(NHIEONBOHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x295D0F0", Offset = "0x295BEF0", VA = "0x18295D0F0")]
	public static CBJMEBCKBKK DMBCOBNJPNO(SkinnedMeshRenderer[] OFIADBEEAKD, Material OGEGGDGPHLO)
	{
		return default(CBJMEBCKBKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F46770", Offset = "0x7F45570", VA = "0x187F46770")]
	public static OIKNEBEGIMP NNDOLLKPCCL(BMBJBMCPIGG AGJJAMLNDNF, int IDLDAHIEKKH, Color NMJPAEHHIMD, Color CENKHKKIBHB, int KECGFPOLMLC, Color GALANCBGDHK, Color NBFOCOMAEMC, int DIDAJGLHLBC)
	{
		return default(OIKNEBEGIMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F46650", Offset = "0x7F45450", VA = "0x187F46650")]
	public static NJABEJKMDLB JPCLFCMOLLA(BMBJBMCPIGG AGJJAMLNDNF, Vector2 MMDFBJLNCDK, float PGLPMPFBDIH, float EONHGNHMJGF, float DHBNHJCHOAL, Vector2 CEFDIBOGNCM, float BJOCNHMDMLN, float LFDGDLEMKAO, float MIMGANGCJFK, Vector2 HDDOMHFGGKH, float BAMOGPEOMIE, float BMHFIJPEJKD, float DOIJOJCPMGI, Vector2 NILIABDJGDM, float ELHAEEBOPEI, float NAHMNHJOEAF, float FFIHGKKHFLP)
	{
		return default(NJABEJKMDLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7F46260", Offset = "0x7F45060", VA = "0x187F46260")]
	public static ENMFPOBIHNB EMNKPPIJBGO(Animator NLOMEFIPNDN, LOOMHCPHCKH JDAALGKMKNG, AvatarConfiguration JHKNFPILNDE, GameObject ALKJKKPBAID, PKNFPGJAIIB AFDMCKAKEMD)
	{
		return default(ENMFPOBIHNB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7F46550", Offset = "0x7F45350", VA = "0x187F46550")]
	public static DOPNBHJAEIP IIEOBJMKPAA(Transform BDCPLPEGPGN, bool HHMGOFGKLIG)
	{
		return default(DOPNBHJAEIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JKEPOJJNOKC
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A980", Offset = "0x7F49780", VA = "0x187F4A980")]
	public static GDNBFNJLEDA DGAEDMFCMNN(this LHKLLOAONCN JCDGCHLIEFD)
	{
		return default(GDNBFNJLEDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A9D0", Offset = "0x7F497D0", VA = "0x187F4A9D0")]
	public static bool PHLKPEDCGPE(this LHKLLOAONCN KFMLMJBBIFE)
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
		public enum AMCFCIMPEIC
		{
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public BodySkinnedMeshLODs HPKOPKDGOLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs CBCJEMPNMJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs BNJHBBJIFAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs BBBCJMEDDGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7F442B0", Offset = "0x7F430B0", VA = "0x187F442B0")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(AMCFCIMPEIC HJMFBGHHJCO, [Optional] JPHJMMINMCH? FDOFNDOCNAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
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
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class FNHKMHGKCIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public FNHKMHGKCIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7F47D60", Offset = "0x7F46B60", VA = "0x187F47D60")]
			internal bool BPEAIFMIFFH(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7F45040", Offset = "0x7F43E40", VA = "0x187F45040")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7F45040", Offset = "0x7F43E40", VA = "0x187F45040")]
		private void OIGBKGBHHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7F44440", Offset = "0x7F43240", VA = "0x187F44440")]
		private void BEAFHACIJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7F44590", Offset = "0x7F43390", VA = "0x187F44590")]
		public byte[] EKLAAEPIIHK(string EINLNANHHOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7F44600", Offset = "0x7F43400", VA = "0x187F44600")]
		public bool LMMCCAOCAKP(SkinnedMeshBoneOrderData GDMIIGDJGIE, AvatarSkinnedMeshBonesController FCMEKDCKMBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7F450C0", Offset = "0x7F43EC0", VA = "0x187F450C0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class FHDEFHMOMJB
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct LAFHKCKHJOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Transform[] PHIEOCKNAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Matrix4x4[] FGJEPKKPBNI;
	}

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static readonly string AEDGLLGILID;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F47700", Offset = "0x7F46500", VA = "0x187F47700")]
	public static byte[] HIHCPMFLLHA(AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF, SkinnedMeshRenderer FJDBDFIPIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F477F0", Offset = "0x7F465F0", VA = "0x187F477F0")]
	public static LAFHKCKHJOD? MAPMKOPMJLO(AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF, SkinnedMeshRenderer FJDBDFIPIPC)
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
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[ReadOnlyField]
		[SerializeField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string MDMPCGJCPMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F45190", Offset = "0x7F43F90", VA = "0x187F45190")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F455C0", Offset = "0x7F443C0", VA = "0x187F455C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F451C0", Offset = "0x7F43FC0", VA = "0x187F451C0")]
		private void BEAFHACIJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F45280", Offset = "0x7F44080", VA = "0x187F45280")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F452E0", Offset = "0x7F440E0", VA = "0x187F452E0")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer MIFBMDMJHAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum BLODKKHJEPD
{
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	BicepWidth,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	ForearmWidth,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	ChestSize,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	ChestOut,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	WaistSize,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	HipWidth,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	NeckLength,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	NeckThickness,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	ThighWidth,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	CalfWidth,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	FootWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	FootSize,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ShoulderWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	BellyOut
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class OFDMNBMIHIL
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F4E3D0", Offset = "0x7F4D1D0", VA = "0x187F4E3D0")]
	public static bool DDPOKLPPKEC(this BLODKKHJEPD HNGOMAMNADF)
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
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		[FormerlySerializedAs("BodyShapePropertyData")]
		private List<BodyShapePropertyData> FullBodyShapePropertyData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private List<BodyShapePropertyData> ModernBeanShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F46880", Offset = "0x7F45680", VA = "0x187F46880")]
		public List<BodyShapePropertyData> CNPGCFEHJEO(PKNFPGJAIIB AFDMCKAKEMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
		public BodyShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct BodyShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public AvatarBodyShapeData.LMFFFLIEJEF BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public List<BodyPropertySliderData> BodyPropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct BodyPropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public BLODKKHJEPD BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct HDCLNPHPCJG : IEquatable<HDCLNPHPCJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public string HLOCEIHJEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public Vector3 NHPCBBHHNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public Vector3 FEOJDIKGEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public Vector3 HJAIPMMABIF;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A140", Offset = "0x7F48F40", VA = "0x187F4A140", Slot = "4")]
	public bool Equals(HDCLNPHPCJG LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A280", Offset = "0x7F49080", VA = "0x187F4A280", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A330", Offset = "0x7F49130", VA = "0x187F4A330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum MCLKJMFCGFF
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KMFBMBBKEMD
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly KMFBMBBKEMD CLGJEJAIGBE;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OIKPAHDOKOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public MCLKJMFCGFF EFLMGMNKKDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAAA750", Offset = "0xAA9550", VA = "0x180AAA750")]
		[CompilerGenerated]
		get
		{
			return default(MCLKJMFCGFF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xB28270", Offset = "0xB27070", VA = "0x180B28270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
	public KMFBMBBKEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x30CA6C0", Offset = "0x30C94C0", VA = "0x1830CA6C0")]
	public KMFBMBBKEMD(MCLKJMFCGFF ICPOMAFNIKG, int EAHPAEENFHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum KFIOGNHKBDM
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	CheekPuff,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	JawWidth,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	JawInOut,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	ChinWidth,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ChinSize,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	EarSize,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	EarAngle,
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	HeadStretch
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class FaceShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private List<FaceShapePropertyData> FaceShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<FaceShapePropertyData> AllFaceShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
		public FaceShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct FaceShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public AvatarFaceShapeData.OKAOPGEJICN FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public List<FacePropertySliderData> FacePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct FacePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public KFIOGNHKBDM FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F492C0", Offset = "0x7F480C0", VA = "0x187F492C0")]
		public void DrawPosition(bool BAMJEJIELLP, Transform OLPMPAIMKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F49360", Offset = "0x7F48160", VA = "0x187F49360")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere JKOLBHOGHAL, Transform CMDMCJGFCDK, Vector2 NNPBJABIDCK, AnchorParamsRestrictions OIOOFDNECEO, bool ABFFADKKGHA = false, bool GNPDBOLLHJE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public FitMeshPreviewGizmo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum MMHOGHLBOGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	NoseWidth,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	NoseHeight,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	NoseLength,
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	NoseAngle,
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	NoseBulge,
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	NosePinchFlair,
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	NoseSneer,
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	NoseTipScale,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	NoseScale
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NoseShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private List<NoseShapePropertyData> NoseShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<NoseShapePropertyData> AllNoseShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
		public NoseShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct NoseShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public BDLLACEJLDO NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public List<NosePropertySliderData> NosePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct NosePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public MMHOGHLBOGJ NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E5C0", Offset = "0x7F4D3C0", VA = "0x187F4E5C0")]
		public void GNJJIOBCAEM(SkinnedMeshRenderer FJDBDFIPIPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E770", Offset = "0x7F4D570", VA = "0x187F4E770")]
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
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[Header("Remapping Eye Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F42BE0", Offset = "0x7F419E0", VA = "0x187F42BE0")]
		public void JBJBMFGNCAK(ONBKDGHPAIE DIOJBFKPGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F430D0", Offset = "0x7F41ED0", VA = "0x187F430D0")]
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
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xCCD1A0", Offset = "0xCCBFA0", VA = "0x180CCD1A0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F468A0", Offset = "0x7F456A0", VA = "0x187F468A0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public Vector2 LimitsUVScale;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7F472B0", Offset = "0x7F460B0", VA = "0x187F472B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7D6E650", Offset = "0x7D6D450", VA = "0x187D6E650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7F472D0", Offset = "0x7F460D0", VA = "0x187F472D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xBA7440", Offset = "0xBA6240", VA = "0x180BA7440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7F472F0", Offset = "0x7F460F0", VA = "0x187F472F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7F47310", Offset = "0x7F46110", VA = "0x187F47310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1FD57D0", Offset = "0x1FD45D0", VA = "0x181FD57D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7F47320", Offset = "0x7F46120", VA = "0x187F47320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F46E80", Offset = "0x7F45C80", VA = "0x187F46E80", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F47180", Offset = "0x7F45F80", VA = "0x187F47180")]
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
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x7F48820", Offset = "0x7F47620", VA = "0x187F48820")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1BE22D0", Offset = "0x1BE10D0", VA = "0x181BE22D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x16F85A0", Offset = "0x16F73A0", VA = "0x1816F85A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1BE28E0", Offset = "0x1BE16E0", VA = "0x181BE28E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F485E0", Offset = "0x7F473E0", VA = "0x187F485E0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F48720", Offset = "0x7F47520", VA = "0x187F48720")]
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

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7F4EB60", Offset = "0x7F4D960", VA = "0x187F4EB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7F4F800", Offset = "0x7F4E600", VA = "0x187F4F800", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private readonly List<NONKHMPPJIB<Sprite>> _spriteResourceHandles;

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
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E190", VA = "0x180A5F390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA5F3B0", Offset = "0xA5E1B0", VA = "0x180A5F3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7F48530", Offset = "0x7F47330", VA = "0x187F48530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7F485A0", Offset = "0x7F473A0", VA = "0x187F485A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F484C0", Offset = "0x7F472C0", VA = "0x187F484C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7F48510", Offset = "0x7F47310", VA = "0x187F48510")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x731BF20", Offset = "0x731AD20", VA = "0x18731BF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F47FA0", Offset = "0x7F46DA0", VA = "0x187F47FA0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F480E0", Offset = "0x7F46EE0", VA = "0x187F480E0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F48010", Offset = "0x7F46E10", VA = "0x187F48010")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F481C0", Offset = "0x7F46FC0", VA = "0x187F481C0")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F47D90", Offset = "0x7F46B90", VA = "0x187F47D90")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F482C0", Offset = "0x7F470C0", VA = "0x187F482C0")]
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
public static class HMNKIBLDCDL
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F4A470", Offset = "0x7F49270", VA = "0x187F4A470")]
	public static OCJBFIOACAA DGKKAMHJKJJ(this FaceFeatureType HNBPPNIGJHI, MAMJKFCNJKC HPAFAKCFFEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class BMBJBMCPIGG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct GKPFGACNLBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<BMBJBMCPIGG> <>t__builder;

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
		private CADHCNHOMBK.IHKLIIECGIL <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7F498A0", Offset = "0x7F486A0", VA = "0x187F498A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A0D0", Offset = "0x7F48ED0", VA = "0x187F4A0D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private readonly Dictionary<string, int> PKIOJPHOHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool DAEDCPAJHAI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public List<Texture2D> NALKBILLCEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public SymmetricalFaceFeature DLGBLFECMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EyesFaceFeature OHJDMLMCDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FaceFeature MPOKHKKNKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA59890", Offset = "0xA58690", VA = "0x180A59890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F45830", Offset = "0x7F44630", VA = "0x187F45830")]
	private static void FGHOKOPKMOO(Sprite LEDFMOKNNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F456C0", Offset = "0x7F444C0", VA = "0x187F456C0")]
	public static BMBJBMCPIGG BJBLAMLGOOO(SymmetricalFaceFeature EKJDMLEEAMP, EyesFaceFeature OIHJDJCEDDL, FaceFeature GLNMAKLBOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F45A60", Offset = "0x7F44860", VA = "0x187F45A60")]
	[AsyncStateMachine(typeof(GKPFGACNLBD))]
	public static Task<BMBJBMCPIGG> OGEDLFONDOC(SymmetricalFaceFeature EKJDMLEEAMP, EyesFaceFeature OIHJDJCEDDL, FaceFeature GLNMAKLBOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F45F70", Offset = "0x7F44D70", VA = "0x187F45F70")]
	private BMBJBMCPIGG(SymmetricalFaceFeature EKJDMLEEAMP, EyesFaceFeature OIHJDJCEDDL, FaceFeature GLNMAKLBOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F45BA0", Offset = "0x7F449A0", VA = "0x187F45BA0")]
	private void PDIMJCAPAPA(List<Sprite> KPBPPBNFFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7F455D0", Offset = "0x7F443D0", VA = "0x187F455D0")]
	public bool AGCGLGMBPPC(string BIDLPLDDGPL, [Out] int CKFKPOAGPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7F45750", Offset = "0x7F44550", VA = "0x187F45750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7F45970", Offset = "0x7F44770", VA = "0x187F45970")]
	public bool IHBLCGMONJM(bool HBLFHGDMEMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7F458A0", Offset = "0x7F446A0", VA = "0x187F458A0")]
	public void HKGPICJJCBE()
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
		private struct CPFIDIKMOJD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public AsyncTaskMethodBuilder<BMBJBMCPIGG> <>t__builder;

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
			private TaskAwaiter<BMBJBMCPIGG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7F468B0", Offset = "0x7F456B0", VA = "0x187F468B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7F46DB0", Offset = "0x7F45BB0", VA = "0x187F46DB0", Slot = "5")]
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
		private Dictionary<JPHJMMINMCH, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private Dictionary<JPHJMMINMCH, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private Dictionary<JPHJMMINMCH, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private Dictionary<JPHJMMINMCH, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly Dictionary<JPHJMMINMCH, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private BMBJBMCPIGG _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private BMBJBMCPIGG _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7F49290", Offset = "0x7F48090", VA = "0x187F49290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7F48AE0", Offset = "0x7F478E0", VA = "0x187F48AE0")]
		public BMBJBMCPIGG EJCNJMKGKLE(PKNFPGJAIIB AFDMCKAKEMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F48B70", Offset = "0x7F47970", VA = "0x187F48B70")]
		[AsyncStateMachine(typeof(CPFIDIKMOJD))]
		public Task<BMBJBMCPIGG> FOBIKFCNNOC(int? CNLFGJBLHGJ, int OIHJDJCEDDL, int GLNMAKLBOFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7F488C0", Offset = "0x7F476C0", VA = "0x187F488C0")]
		public NoseFaceOption CLBIAKPFEMF(int ABMPOGAOLEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7F48FE0", Offset = "0x7F47DE0", VA = "0x187F48FE0")]
		public SelectableFaceOption PGBJGHOPCKK(FaceFeatureType HAKIEFDKDCK, JPHJMMINMCH MKCPHENKFFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7F48840", Offset = "0x7F47640", VA = "0x187F48840")]
		public int CAOOPPPHJCO(JPHJMMINMCH MKCPHENKFFI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7F48CA0", Offset = "0x7F47AA0", VA = "0x187F48CA0")]
		private void OBMKHPJBMJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3B6D7E0", Offset = "0x3B6C5E0", VA = "0x183B6D7E0")]
		private void JMBMDGCMNMD<T>(IDictionary<JPHJMMINMCH, T> OBJPMEDBNDI, IReadOnlyList<T> HDGENODGMEG) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7F48ED0", Offset = "0x7F47CD0", VA = "0x187F48ED0")]
		public JPHJMMINMCH OFALKNIPFJK(FaceFeatureType HAKIEFDKDCK)
		{
			return default(JPHJMMINMCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7F48960", Offset = "0x7F47760", VA = "0x187F48960")]
		public JPHJMMINMCH EIECPBMIOFL(FaceFeatureType HAKIEFDKDCK)
		{
			return default(JPHJMMINMCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7F49160", Offset = "0x7F47F60", VA = "0x187F49160")]
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
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAB4B10", Offset = "0xAB3910", VA = "0x180AB4B10", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7F48720", Offset = "0x7F47520", VA = "0x187F48720")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public BDLLACEJLDO SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xCDFFB0", Offset = "0xCDEDB0", VA = "0x180CDFFB0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
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
		public JPHJMMINMCH FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x20202A0", Offset = "0x201F0A0", VA = "0x1820202A0")]
			get
			{
				return default(JPHJMMINMCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0CE0", Offset = "0xAAFAE0", VA = "0x180AB0CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x149E000", Offset = "0x149CE00", VA = "0x18149E000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7F42B30", Offset = "0x7F41930", VA = "0x187F42B30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xCC5E40", Offset = "0xCC4C40", VA = "0x180CC5E40")]
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
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x7F4EAE0", Offset = "0x7F4D8E0", VA = "0x187F4EAE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7317D80", Offset = "0x7316B80", VA = "0x187317D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7F4EB20", Offset = "0x7F4D920", VA = "0x187F4EB20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7317D90", Offset = "0x7316B90", VA = "0x187317D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7F4EB00", Offset = "0x7F4D900", VA = "0x187F4EB00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x731B150", Offset = "0x7319F50", VA = "0x18731B150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7F4EB40", Offset = "0x7F4D940", VA = "0x187F4EB40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x731B140", Offset = "0x7319F40", VA = "0x18731B140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E800", Offset = "0x7F4D600", VA = "0x187F4E800", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EA10", Offset = "0x7F4D810", VA = "0x187F4EA10")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class LHOOPDPBPHB
{
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly float OELFEENBEHJ;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly float JPMMHFPPEPE;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Vector2 OLAIPELKDGK;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Vector2 ENPHIJEMEKB;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Vector2 DLACHLNBIFP;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Vector2 ANAMCCMMAFD;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Vector2 PADDNKNNFCA;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Vector2 HONLLECGPJC;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Vector2 EAPLBGMEFPB;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Vector2 AGMIHBDJJDH;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Vector2 GFEHMPGKCAD;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Vector2 HFELIPHMBMH;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Vector2 NIBMBMJABLD;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Vector2 ALAABNMCNJG;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AA60", Offset = "0x7F49860", VA = "0x187F4AA60")]
	public static Vector2 AEBKJMJBNEJ(FaceFeatureType HNBPPNIGJHI, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AD10", Offset = "0x7F49B10", VA = "0x187F4AD10")]
	public static float BAIPLCEPDNP(FaceFeatureType HNBPPNIGJHI, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AF00", Offset = "0x7F49D00", VA = "0x187F4AF00")]
	public static void BFDHOCGMBED(ONBKDGHPAIE LANFPHDIAEE, AvatarConfiguration JHKNFPILNDE, PKNFPGJAIIB IJPHNHFGJJN, PKNFPGJAIIB BLBDJMNMFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BC50", Offset = "0x7F4AA50", VA = "0x187F4BC50")]
	public static float FHPDDBCNEFF(FaceFeatureType HAKIEFDKDCK, float KMDCHHBNKFK, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BCE0", Offset = "0x7F4AAE0", VA = "0x187F4BCE0")]
	public static float GBNLMBEAMKM(FaceFeatureType HAKIEFDKDCK, float HDFJJEDGFAC, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D6E0", Offset = "0x7F4C4E0", VA = "0x187F4D6E0")]
	public static float OLLOOIOOMDD(FaceFeatureType HAKIEFDKDCK, float NOLDGDLLBBL, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C7C0", Offset = "0x7F4B5C0", VA = "0x187F4C7C0")]
	public static float LAPMGDCPLDP(FaceFeatureType HAKIEFDKDCK, float DAECPIPBCGL, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C5C0", Offset = "0x7F4B3C0", VA = "0x187F4C5C0")]
	public static float KCALCKKLDPM(FaceFeatureType HAKIEFDKDCK, float KMICCMJNIEE, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BE30", Offset = "0x7F4AC30", VA = "0x187F4BE30")]
	public static float GJCKHPNLOLF(FaceFeatureType HAKIEFDKDCK, float AFIHLMGNGNO, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B640", Offset = "0x7F4A440", VA = "0x187F4B640")]
	public static Vector2 DNEEMIOKIKJ(FaceFeatureType HAKIEFDKDCK, Vector2 JCMIDJDOHLA, Vector2 ICHBKNFBNJO, Vector2 DJHNMEFEPFM, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B1F0", Offset = "0x7F49FF0", VA = "0x187F4B1F0")]
	public static Vector2 CPAADCAAGKG(FaceFeatureType HAKIEFDKDCK, Vector2 IAFINMFEHBK, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D940", Offset = "0x7F4C740", VA = "0x187F4D940")]
	private static Vector2 POEMMJJPLMB(FaceFeatureType HAKIEFDKDCK, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C040", Offset = "0x7F4AE40", VA = "0x187F4C040")]
	private static Vector2 HLGFBEBAEOF(FaceFeatureType HAKIEFDKDCK, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D430", Offset = "0x7F4C230", VA = "0x187F4D430")]
	private static Vector2 OHHBGMOEKCC(FaceFeatureType HAKIEFDKDCK, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B9C0", Offset = "0x7F4A7C0", VA = "0x187F4B9C0")]
	private static Vector2 EOHHNOCJNGK(FaceFeatureType HAKIEFDKDCK, Vector2 JCMIDJDOHLA, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CF30", Offset = "0x7F4BD30", VA = "0x187F4CF30")]
	public static Vector2 OBEFADJJKOE(FaceFeatureType HAKIEFDKDCK, Vector2 IAFINMFEHBK, Vector2 ICHBKNFBNJO, Vector2 DJHNMEFEPFM, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CC50", Offset = "0x7F4BA50", VA = "0x187F4CC50")]
	public static float NIGFIFJJDJG(FaceFeatureType HAKIEFDKDCK, float HDFJJEDGFAC, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D8A0", Offset = "0x7F4C6A0", VA = "0x187F4D8A0")]
	public static float PDNIDFFNOBG(FaceFeatureType HAKIEFDKDCK, float NOLDGDLLBBL, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C9D0", Offset = "0x7F4B7D0", VA = "0x187F4C9D0")]
	public static float LJNCPJHHLHO(FaceFeatureType HAKIEFDKDCK, float DAECPIPBCGL, PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B5B0", Offset = "0x7F4A3B0", VA = "0x187F4B5B0")]
	private static float DLOGJFCGPOD(float IIEOAHPEFEA, float PFNOCLOHBOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B450", Offset = "0x7F4A250", VA = "0x187F4B450")]
	private static Vector2 CPPMKGGLKKM(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C460", Offset = "0x7F4B260", VA = "0x187F4C460")]
	private static Vector2 JAPAIBDGIAJ(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C3B0", Offset = "0x7F4B1B0", VA = "0x187F4C3B0")]
	private static Vector2 IMOMCCAFDEJ(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B500", Offset = "0x7F4A300", VA = "0x187F4B500")]
	private static Vector2 DCJCIFPDDFB(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CB30", Offset = "0x7F4B930", VA = "0x187F4CB30")]
	private static float MJGOHJALAJA(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D830", Offset = "0x7F4C630", VA = "0x187F4D830")]
	private static float PACBJCPMHAF(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D3C0", Offset = "0x7F4C1C0", VA = "0x187F4D3C0")]
	private static float OFGCALAECLA(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B710", Offset = "0x7F4A510", VA = "0x187F4B710")]
	private static float DNNIMAJBHDG(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B780", Offset = "0x7F4A580", VA = "0x187F4B780")]
	private static Vector2 EJDCCJFIEBM(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B900", Offset = "0x7F4A700", VA = "0x187F4B900")]
	private static Vector2 EOFDPLFEIHD(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BEC0", Offset = "0x7F4ACC0", VA = "0x187F4BEC0")]
	private static Vector2 GJPCLKHHEFK(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B140", Offset = "0x7F49F40", VA = "0x187F4B140")]
	private static Vector2 CHEMNPOAKBC(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CBA0", Offset = "0x7F4B9A0", VA = "0x187F4CBA0")]
	private static Vector2 MOGOCMDNKPI(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B840", Offset = "0x7F4A640", VA = "0x187F4B840")]
	private static Vector2 ENLOLLNKIEN(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C910", Offset = "0x7F4B710", VA = "0x187F4C910")]
	private static Vector2 LHIKJPNCOLE(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C2F0", Offset = "0x7F4B0F0", VA = "0x187F4C2F0")]
	private static Vector2 IFBKGJOIOFD(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C510", Offset = "0x7F4B310", VA = "0x187F4C510")]
	private static Vector2 JPFCMKJDAOJ(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C710", Offset = "0x7F4B510", VA = "0x187F4C710")]
	private static Vector2 KLNMDOEDCJN(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7F4D770", Offset = "0x7F4C570", VA = "0x187F4D770")]
	private static Vector2 OLPHJKNFIJD(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7F4AFC0", Offset = "0x7F49DC0", VA = "0x187F4AFC0")]
	private static Vector2 BNNCCFIEDNE(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BD70", Offset = "0x7F4AB70", VA = "0x187F4BD70")]
	private static Vector2 GIJDJLKOGAB(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C850", Offset = "0x7F4B650", VA = "0x187F4C850")]
	private static Vector2 LELLNNEMDPP(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7F4C650", Offset = "0x7F4B450", VA = "0x187F4C650")]
	private static Vector2 KKDEDDADACF(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BB90", Offset = "0x7F4A990", VA = "0x187F4BB90")]
	private static Vector2 FGKMLMNMNOA(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CE70", Offset = "0x7F4BC70", VA = "0x187F4CE70")]
	private static Vector2 NMOGHKJMBKL(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F4BF80", Offset = "0x7F4AD80", VA = "0x187F4BF80")]
	private static Vector2 GOINKNFPHCN(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7F4B080", Offset = "0x7F49E80", VA = "0x187F4B080")]
	private static Vector2 BPJKGEBLGKK(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7F4CA70", Offset = "0x7F4B870", VA = "0x187F4CA70")]
	private static Vector2 LNFJMNKHBIM(PKNFPGJAIIB AFDMCKAKEMD, AvatarConfiguration LDLJKPNAGIO)
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
