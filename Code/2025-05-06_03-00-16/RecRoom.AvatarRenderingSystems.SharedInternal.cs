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
		[Cpp2IlInjected.Address(RVA = "0x79AEA90", Offset = "0x79AD290", VA = "0x1879AEA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		public AvatarFaceShapeData.KHOFAFCPDPE FaceShapeName;

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
		public AvatarBodyShapeData.IKDIGDKBAMJ BodyShapeName;

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
		public JIFBLNLKJIG BodyProperty;

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
		public CNOECLPIEKB FaceProperty;

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
		public FEBPCDMMGMN NoseProperty;

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
		public DPOJOKMIJDG NoseType;

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
		public JIFBLNLKJIG BodyProperty;

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
		public CNOECLPIEKB FaceProperty;

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
		public FEBPCDMMGMN NoseProperty;

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
		public OHFOMCMDBHP PropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Flags]
public enum OHFOMCMDBHP
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
		private sealed class CMCGDGKICIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public CMCGDGKICIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x79BA850", Offset = "0x79B9050", VA = "0x1879BA850")]
			internal bool KJCNLIGDPGP(KeyValuePair<string, Transform> bone)
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
		private List<AvatarFaceShapeData.KHOFAFCPDPE> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private List<AvatarBodyShapeData.IKDIGDKBAMJ> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<JIFBLNLKJIG, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Dictionary<CNOECLPIEKB, List<float>> facePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Dictionary<FEBPCDMMGMN, List<float>> nosePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(string, AvatarFaceShapeData.KHOFAFCPDPE), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(string, AvatarBodyShapeData.IKDIGDKBAMJ), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<(string, DPOJOKMIJDG), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<(string, JIFBLNLKJIG, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<JIFBLNLKJIG, Dictionary<string, OHFOMCMDBHP>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<(string, CNOECLPIEKB, float), AvatarBodyPartBoneData> facePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Dictionary<CNOECLPIEKB, Dictionary<string, OHFOMCMDBHP>> facePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Dictionary<(string, FEBPCDMMGMN, float), AvatarBodyPartBoneData> nosePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Dictionary<FEBPCDMMGMN, Dictionary<string, OHFOMCMDBHP>> nosePropertyBoneInfluenceInfoMapping;

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
		private readonly Dictionary<JIFBLNLKJIG, string[]> bonesToUpdatePerBodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly Dictionary<CNOECLPIEKB, string[]> bonesToUpdatePerFaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Dictionary<FEBPCDMMGMN, string[]> bonesToUpdatePerNoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Dictionary<string, Dictionary<OHFOMCMDBHP, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x79B5AB0", Offset = "0x79B42B0", VA = "0x1879B5AB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x79B29D0", Offset = "0x79B11D0", VA = "0x1879B29D0")]
		public void NPIOKLMMDIH(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x79B26D0", Offset = "0x79B0ED0", VA = "0x1879B26D0")]
		public void NAONGIPPJBA(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, AvatarFaceShapeData.KHOFAFCPDPE JFHNLKMCHKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x79B4A70", Offset = "0x79B3270", VA = "0x1879B4A70")]
		public void PFFBFNMPCLE(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, DPOJOKMIJDG BCGOGBNIGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x79B0F10", Offset = "0x79AF710", VA = "0x1879B0F10")]
		public void EHHHOMOCNAD(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, AvatarBodyShapeData.IKDIGDKBAMJ NAPFJCHLPMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79B2230", Offset = "0x79B0A30", VA = "0x1879B2230")]
		public void MGAKLGKGHJJ(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, IReadOnlyDictionary<string, DOBLLPEHFPB> LACMMDOBOIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79B1C60", Offset = "0x79B0460", VA = "0x1879B1C60")]
		public IReadOnlyDictionary<string, DOBLLPEHFPB> JPHOBGGPNDE(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x79B1B40", Offset = "0x79B0340", VA = "0x1879B1B40")]
		public Dictionary<string, DOBLLPEHFPB> HIIPFLEKILH(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, IReadOnlyDictionary<JIFBLNLKJIG, float> JILKBDHFLIP, IReadOnlyDictionary<string, DOBLLPEHFPB> FOBGMOLMDBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x79B2640", Offset = "0x79B0E40", VA = "0x1879B2640")]
		public Dictionary<string, DOBLLPEHFPB> NABJMGJLCIK(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, IReadOnlyDictionary<CNOECLPIEKB, float> IMOCAICLBMG, IReadOnlyDictionary<string, DOBLLPEHFPB> FOBGMOLMDBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x79B1BD0", Offset = "0x79B03D0", VA = "0x1879B1BD0")]
		public Dictionary<string, DOBLLPEHFPB> JJIFNMOGCHL(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, IReadOnlyDictionary<FEBPCDMMGMN, float> CLDDDKHHNMB, IReadOnlyDictionary<string, DOBLLPEHFPB> FOBGMOLMDBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x34FC3A0", Offset = "0x34FABA0", VA = "0x1834FC3A0")]
		private Dictionary<string, DOBLLPEHFPB> DNDMMKKBFKH<T>(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, IReadOnlyDictionary<T, float> OCLPCJCAALM, IReadOnlyDictionary<string, DOBLLPEHFPB> MAOJOGGKPCJ, Dictionary<T, Dictionary<string, OHFOMCMDBHP>> HMEGMGBEOJN, Dictionary<(string, T, float), AvatarBodyPartBoneData> DNCPLNIMILN, bool MLAAHFEEMPJ, bool FCNGFJOFEFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79B2040", Offset = "0x79B0840", VA = "0x1879B2040")]
		public float KMAFDKHDPCE(JIFBLNLKJIG OFFLKMPHDPK, float JCCBCDAFNMA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x79B1270", Offset = "0x79AFA70", VA = "0x1879B1270")]
		public float EOOJKEMGKPI(CNOECLPIEKB JJOCGLIBDAN, float PLECHAMFBID)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79AED00", Offset = "0x79AD500", VA = "0x1879AED00")]
		public float CEKBOPIPJAJ(FEBPCDMMGMN KKCCMLIGNFL, float ILLNLFGIHGL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x34FD880", Offset = "0x34FC080", VA = "0x1834FD880")]
		private float IGFIHKLFCPK<T>(T KIIAJPLCJIE, float KJOACKDAHHL, Dictionary<T, List<float>> DENLAJJAIHI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79B20A0", Offset = "0x79B08A0", VA = "0x1879B20A0")]
		private DOBLLPEHFPB LICFACNHFDD(IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, string KJMMMDHHBDO)
		{
			return default(DOBLLPEHFPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x79AED70", Offset = "0x79AD570", VA = "0x1879AED70")]
		private float CGIEJLNJOCE(float OPMIAMEJKDH, List<float> IIMLBKKHLOH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x79AEC90", Offset = "0x79AD490", VA = "0x1879AEC90")]
		private Vector3 ANGIADOCOJM(Transform PBMCIAKIPDK, AvatarBodyPartBoneData FLHMEMMNEIE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79B1210", Offset = "0x79AFA10", VA = "0x1879B1210")]
		private Quaternion EMEPFBIKADM(Transform PBMCIAKIPDK, AvatarBodyPartBoneData FLHMEMMNEIE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x79AEC20", Offset = "0x79AD420", VA = "0x1879AEC20")]
		private Vector3 AIAFFMPPENO(Transform PBMCIAKIPDK, AvatarBodyPartBoneData FLHMEMMNEIE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x79AFE50", Offset = "0x79AE650", VA = "0x1879AFE50")]
		private void DJNIIPPAMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B906F0", Offset = "0x6B8EEF0", VA = "0x186B906F0")]
		public bool LHDFPODJINH(OHFOMCMDBHP CHACEMKJIMB, OHFOMCMDBHP JBBLOABKPPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x79AEE70", Offset = "0x79AD670", VA = "0x1879AEE70")]
		private DOBLLPEHFPB COOIFNABPLD(OHFOMCMDBHP MCKHFDCCKBE, DOBLLPEHFPB PBMCIAKIPDK, AvatarBodyPartBoneData FLHMEMMNEIE)
		{
			return default(DOBLLPEHFPB);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x79B12E0", Offset = "0x79AFAE0", VA = "0x1879B12E0")]
		public Dictionary<string, DOBLLPEHFPB> FMKHLGCACLE(Dictionary<string, DOBLLPEHFPB> KFDMHLLEAJB, bool MLAAHFEEMPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x79B1970", Offset = "0x79B0170", VA = "0x1879B1970")]
		private void GFCNIDIDNKL(Transform PBMCIAKIPDK, AvatarBodyPartBoneData FLHMEMMNEIE, bool JDMGEFBCDJN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x79B5100", Offset = "0x79B3900", VA = "0x1879B5100")]
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
		public JIFBLNLKJIG BodyProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x79B5BB0", Offset = "0x79B43B0", VA = "0x1879B5BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum IKDIGDKBAMJ
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
		public IKDIGDKBAMJ blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		private AvatarBodyShapeData.IKDIGDKBAMJ blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GIIEABJDIBB BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1DA05C0", Offset = "0x1D9EDC0", VA = "0x181DA05C0")]
			get
			{
				return default(GIIEABJDIBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.IKDIGDKBAMJ BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
			get
			{
				return default(AvatarBodyShapeData.IKDIGDKBAMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x79B6640", Offset = "0x79B4E40", VA = "0x1879B6640")]
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
		public AvatarBodyShapeData.IKDIGDKBAMJ BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x79B5EC0", Offset = "0x79B46C0", VA = "0x1879B5EC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		private readonly Dictionary<GIIEABJDIBB, AvatarBodyShape> PJNKGEHKFCI;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79B6130", Offset = "0x79B4930", VA = "0x1879B6130")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79B6450", Offset = "0x79B4C50", VA = "0x1879B6450")]
		public AvatarBodyShape Find(GIIEABJDIBB AIEHABKGEEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79B6550", Offset = "0x79B4D50", VA = "0x1879B6550")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x79B6510", Offset = "0x79B4D10", VA = "0x1879B6510")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x79B6590", Offset = "0x79B4D90", VA = "0x1879B6590")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DPKNBNLLFGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Transform[] JMHMHCCLNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<string, Transform> MAHBKHNJMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Transform, Transform> NNIJFICEFMF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> FIHFINBNCJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] PHFFNKEOCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79BB250", Offset = "0x79B9A50", VA = "0x1879BB250")]
	public void ODNEBHNPCCJ(Transform GNIBEOONDLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x79BB330", Offset = "0x79B9B30", VA = "0x1879BB330")]
	public Transform OOJNEMPKOIB(Transform LICPCDOOOKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x79BB010", Offset = "0x79B9810", VA = "0x1879BB010")]
	public void BMDIBNKBKCG(SkinnedMeshRenderer CJBEHDJJKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x79BB410", Offset = "0x79B9C10", VA = "0x1879BB410")]
	private static void OPLMDDNBIOK(Transform PNDCHGJLEGG, List<Transform> HODLOHLIOFK, Dictionary<string, Transform> IIONFLKAFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x79BB570", Offset = "0x79B9D70", VA = "0x1879BB570")]
	public DPKNBNLLFGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MCGPNNFIPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool ABPPFOMIPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool BBMDIBPHDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool NAEHNIMMGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public MFGHHKBHMBD? OKJGNLCAMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public HHPKDLEJEOP.OOIFDIEICOH BGEBLKJCPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public HairData KDIHJFJJKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public AdditionalHatData IMHMBNNJGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool FCANAIFGFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public bool GJPKNHANKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public bool JPANHOBOLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public IList<KNAIBICOJFM> IKJLPJBCPJL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public MCGPNNFIPKM()
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
		[Cpp2IlInjected.Address(RVA = "0x79B66D0", Offset = "0x79B4ED0", VA = "0x1879B66D0")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IOPOMOOJGAE
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
		public IOPOMOOJGAE RangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Vector2 Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public PBBOLHBJGGN Version;
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FCLGMMIGDNM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static BLDANHJAEOK FHLPGAGIEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x79BBAB0", Offset = "0x79BA2B0", VA = "0x1879BBAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static PNINFJFLLCD NHLLJBLEPBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x79BBB10", Offset = "0x79BA310", VA = "0x1879BBB10")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EDPBDFELEDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public Transform DCMBCBGAKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public AvatarSkinAssetItem IFKEOFFDAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public AssetReference CBNPKIBJGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public GameObject IHHAIAIKPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public GameObject NJKFJJEHDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public SkinnedMeshRenderer CIGLHBGEMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public AvatarSkinnedMeshBoneOrderRemapsData EEFKKLILDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Material GEDHEDGNLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Material CGFGNNIHKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Material EFFKFKDKLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Shader HAMJMEKKKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public Shader OIDMINCCOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Animator PAPAKPEPCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Renderer[] BODKGAIOGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public AvatarConfiguration MNCOGNLFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public AvatarBodyPartShapesManager HDAHPMGOGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public IReadOnlyDictionary<string, Transform> PFFMOIJDGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Transform AODJDALODIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public DODMAGIBHBA FNKKGBAANJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct EKBHECGFNJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public SkinnedMeshRenderer[] PPPLEEPGBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public SkinnedMeshRenderer[] PLNENJEJPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public SkinnedMeshRenderer[] MPEACBHIPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public SkinnedMeshRenderer[] MPAPIAMKIIL;
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
public struct NLEPPIICHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform LBDAAGPOOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform LGIMLCGNODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform MINAKJJGDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform OCABGDICJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform BOBHHKGNMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform AOACIOIPHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Transform MDDJHLGJFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public AvatarConfiguration MNCOGNLFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public DODMAGIBHBA FNKKGBAANJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct CFNIEHNGKLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public SkinnedMeshRenderer[] CANAIDHIOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Material CGKGFEEIOEE;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct GDJMINGHPLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public HDJOIAGFMIA MAEAABBPJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public int MDKHJAKNPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public int BPAKHHKMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Color PNEDIHHHEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public Color HLAPBIOKMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public int FGIANPCEFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public int LPKJANAECLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Color GLOCPBJBLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Color HGDBBCOIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public int MMDAFLCMGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public float ODIOGFDHPPP;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct HHCGMBNDBPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public HDJOIAGFMIA MAEAABBPJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Vector2 GBJNMMPLLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float DLGPNBCPNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public float EOMIEAAOILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public float GMFHHAANELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector2 GOPKMPOOOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float LENPDOEPFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public float GPIMHLFCDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public float OABBOEOHFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector2 OGCLLNEPHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public float NECHNKKFFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public float BOMHOCGBONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float OANFMHCPBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Vector2 AOKJFCDNMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public float DKPLOHNHHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public float ODIOGFDHPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public float KNHJFMOPCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool OACIPNPFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool GBNIGPKBOGB;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public CNOECLPIEKB FaceProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x79B6D30", Offset = "0x79B5530", VA = "0x1879B6D30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum KHOFAFCPDPE
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
		public KHOFAFCPDPE blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		private AvatarFaceShapeData.KHOFAFCPDPE blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EGPFHAHNEED FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x1DA05C0", Offset = "0x1D9EDC0", VA = "0x181DA05C0")]
			get
			{
				return default(EGPFHAHNEED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.KHOFAFCPDPE BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9EDEE0", Offset = "0x9EC6E0", VA = "0x1809EDEE0")]
			get
			{
				return default(AvatarFaceShapeData.KHOFAFCPDPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79B77C0", Offset = "0x79B5FC0", VA = "0x1879B77C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x79B7820", Offset = "0x79B6020", VA = "0x1879B7820")]
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
		public AvatarFaceShapeData.KHOFAFCPDPE FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x79B7040", Offset = "0x79B5840", VA = "0x1879B7040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		private readonly Dictionary<EGPFHAHNEED, AvatarFaceShape> PJNKGEHKFCI;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x79B72B0", Offset = "0x79B5AB0", VA = "0x1879B72B0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x79B75D0", Offset = "0x79B5DD0", VA = "0x1879B75D0")]
		public AvatarFaceShape Find(EGPFHAHNEED PCJLGEKIICA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x79B76D0", Offset = "0x79B5ED0", VA = "0x1879B76D0")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x79B7690", Offset = "0x79B5E90", VA = "0x1879B7690")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x79B7710", Offset = "0x79B5F10", VA = "0x1879B7710")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x79B7E70", Offset = "0x79B6670", VA = "0x1879B7E70")]
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
		public DAMJGPCPPIE HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1DA05C0", Offset = "0x1D9EDC0", VA = "0x181DA05C0")]
			get
			{
				return default(DAMJGPCPPIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9E2460", Offset = "0x9E0C60", VA = "0x1809E2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xBFD9E0", Offset = "0xBFC1E0", VA = "0x180BFD9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xC03A50", Offset = "0xC02250", VA = "0x180C03A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x79B7E80", Offset = "0x79B6680", VA = "0x1879B7E80")]
		public Texture2D AOFINOGLCPJ(HairPatternStyle CBECCFLDGHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x79B8040", Offset = "0x79B6840", VA = "0x1879B8040", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x79B7FD0", Offset = "0x79B67D0", VA = "0x1879B7FD0", Slot = "4")]
		public bool Equals(AvatarHairPattern PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x79B81B0", Offset = "0x79B69B0", VA = "0x1879B81B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x79B80F0", Offset = "0x79B68F0", VA = "0x1879B80F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x79B8180", Offset = "0x79B6980", VA = "0x1879B8180")]
		public static bool ONONOJDPAAN(AvatarHairPattern ANGFJALIIBO, AvatarHairPattern LNEMONKDKMJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x79B8100", Offset = "0x79B6900", VA = "0x1879B8100")]
		public static bool NIDGPKKMDPO(AvatarHairPattern ANGFJALIIBO, AvatarHairPattern LNEMONKDKMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x79B81F0", Offset = "0x79B69F0", VA = "0x1879B81F0")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum CFPNNJDNDCC
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
public enum JMDBCOCCLED
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
public struct FGCGEOOLAMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Animator NMFKIPAPJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public ELGEGIFKKGD CPALJANAGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public AvatarConfiguration MNCOGNLFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public GameObject NJLFKLOACJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public DODMAGIBHBA FNKKGBAANJJ;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct ADEKGPFKEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Transform FLHBEDLJIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public bool IEMNLAKDHNI;
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
		[Cpp2IlInjected.Address(RVA = "0x79B8300", Offset = "0x79B6B00", VA = "0x1879B8300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KNAIBICOJFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public string ACOJEEABMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public OutfitType GGNBKBNHGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public PNLIIGCPIIK GALNAPPAFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public HHPKDLEJEOP.OOIFDIEICOH INIBFNFLOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public bool PNBCGFANHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public bool EHNBBIDONCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool BENHKFFJIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Color? MEHEKLAKENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool HKDFDMLFHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Color? CCGFBHOMIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool OMIGIFIMGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public bool NFCDFKKFMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public bool AOBHHACJBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Transform LEGJLHGAACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Vector2? BBIFDGPGAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public FitMeshHemisphere GEDNMFICIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public AssetReference ILKEALHLPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public AssetReference IIAFEJMAFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public AssetReference[] GNBPPHFIFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public KNAIBICOJFM AJLNKKBMPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public bool ACANLCKBBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public bool OGNEOONHGKH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string DCDLIDOFHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x79BF490", Offset = "0x79BDC90", VA = "0x1879BF490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x79BF490", Offset = "0x79BDC90", VA = "0x1879BF490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x79BF540", Offset = "0x79BDD40", VA = "0x1879BF540")]
	public KNAIBICOJFM()
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
		private HICLAFCEFNC? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public EGIKODNAABF CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x79B8890", Offset = "0x79B7090", VA = "0x1879B8890")]
			get
			{
				return default(EGIKODNAABF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HICLAFCEFNC MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x79B88C0", Offset = "0x79B70C0", VA = "0x1879B88C0")]
			get
			{
				return default(HICLAFCEFNC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9DD200", Offset = "0x9DBA00", VA = "0x1809DD200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x79B8390", Offset = "0x79B6B90", VA = "0x1879B8390")]
		public Material[] BFCFJPMPFKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x79B8620", Offset = "0x79B6E20", VA = "0x1879B8620")]
		public static void LOFFIDBDCOJ(AvatarItemMaterial HCLNPCFCLPF, Material OALKCGACMLD, int JNNOAPGEOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x79B8470", Offset = "0x79B6C70", VA = "0x1879B8470")]
		private static bool FMDHJHMJHMF(AvatarItemMaterial HCLNPCFCLPF, int JNNOAPGEOAD, [Out] Material NKCOAPCFOAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x79B8810", Offset = "0x79B7010", VA = "0x1879B8810")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DDJFKHBJKPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public SkinnedMeshRenderer NHFGEMMEOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Material[] CBCONCJOOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private byte[] DKLEGMMPOLJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh JHGJDPBIIIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x79BAA50", Offset = "0x79B9250", VA = "0x1879BAA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Material[] JJEFBDJBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public byte[] DFDEFILGBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x79BAA70", Offset = "0x79B9270", VA = "0x1879BAA70")]
	public DDJFKHBJKPH(SkinnedMeshRenderer CCHCFBGLLFL, AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG, Material[] HNAJPAELIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x79BA8B0", Offset = "0x79B90B0", VA = "0x1879BA8B0")]
	public static DDJFKHBJKPH CPBALNPMHLD(Renderer JGPHFKDOCBN, AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG, Material[] HNAJPAELIIB)
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
			[Cpp2IlInjected.Address(RVA = "0x14064D0", Offset = "0x1404CD0", VA = "0x1814064D0")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xC41D90", Offset = "0xC40590", VA = "0x180C41D90")]
		public void AFOHMCJECDO(Vector3 NCGKJMOKFAF, Quaternion PMHMEKBKJJA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class AKPODJGLGLK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x79AE7D0", Offset = "0x79ACFD0", VA = "0x1879AE7D0")]
	public static PositionAndRotation JMPLIOEIKLI(this PositionAndRotation COOCCHNGLNK)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x79AE6B0", Offset = "0x79ACEB0", VA = "0x1879AE6B0")]
	public static float DEMDFCCDKOO(float NACLDKPPPKG, Vector2 NJJAMDGPPIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x79AE750", Offset = "0x79ACF50", VA = "0x1879AE750")]
	public static float DEMDFCCDKOO(float NACLDKPPPKG, float EDGENFDJJHO, float JMODEPAHCCJ, float FGNFJAMALCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x79AE920", Offset = "0x79AD120", VA = "0x1879AE920")]
	public static float OKGJEHFODAF(float OPMIAMEJKDH, Vector2 NJJAMDGPPIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x79AE9E0", Offset = "0x79AD1E0", VA = "0x1879AE9E0")]
	public static float OKGJEHFODAF(float OPMIAMEJKDH, float EDGENFDJJHO, float JMODEPAHCCJ, float FGNFJAMALCL)
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
		public FEBPCDMMGMN NoseProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x79B8980", Offset = "0x79B7180", VA = "0x1879B8980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
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
		public DPOJOKMIJDG NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x79B8C90", Offset = "0x79B7490", VA = "0x1879B8C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum CGLPDKPEOLH
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
public enum GFPEBKLBEPB
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
public enum GKEGCDPOLMK
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
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OPDLEHKLJNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector2 AHCPLAEGDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector2 DAGCADJAJNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector2 PHJBOHGHGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector2 HCGFPOOJKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector2 EDPKECLJDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector2 DAHMLDIJGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Vector2 LNMODHCACLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public Vector2 NIDAODAJNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Vector2 DAHGHGLIPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector2 FPPFFHCONEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector2 IGANAFDGMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector2 BPBFCAJIDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector2 BLCJELEAOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Vector2 ONEAKEMJPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public Vector2 NBLGJBMLIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public Vector2 KEMNDOCKCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float CONMJJJDBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public float MMAPPLIDKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public float CBBJPDGBPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float GHOCDALLBBF;
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
public static class BADJHHMBJBC
{
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public static readonly int ACFECACEEBH;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly string BGHLOCBMPOK;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x79BA4C0", Offset = "0x79B8CC0", VA = "0x1879BA4C0")]
	public static EDPBDFELEDH HALFEJPHFPD(Transform JDPFHELEAIN, AvatarSkinAssetItem NGCNMLCEKNA, AssetReference GHOPIJHBEIC, GameObject PBCIGPNIGMP, GameObject CFFHOHKNKKJ, SkinnedMeshRenderer EGHOCGOOKDA, AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG, Material DEJFGMEDKKJ, Material CEBAPDIOKFP, Material DCKOFGDPGKF, Shader NJJIFFAANKA, Shader BBLELNDDPGI, Animator MCCOBBMEECF, Renderer[] EPKKGNNNGGP, AvatarConfiguration HGGOEBFPIIL, AvatarBodyPartShapesManager MGJCPMIDLKB, IReadOnlyDictionary<string, Transform> IDLKDOCMIDO, Transform FJIGFAAMAMM, DODMAGIBHBA CLLFKOMCOND)
	{
		return default(EDPBDFELEDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x79BA720", Offset = "0x79B8F20", VA = "0x1879BA720")]
	public static EKBHECGFNJC MBMPCPJFJAB(SkinnedMeshRenderer[] CAOFHHIELAC, SkinnedMeshRenderer[] IBPIILPBEHA, SkinnedMeshRenderer[] CCBBIKJBHGE, SkinnedMeshRenderer[] FBHPOHDHPBA)
	{
		return default(EKBHECGFNJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x79BA320", Offset = "0x79B8B20", VA = "0x1879BA320")]
	public static NLEPPIICHML CCFPNOOKHCN(Transform FLELJJJDICO, Transform EOMFPHMNFBA, Transform NKKODLHLMHO, Transform GFPCIEDFNKC, Transform GCFLLOMMMHM, Transform GPNECNGIKFK, Transform PMIIIANOINE, AvatarConfiguration COMMPENJPKB, DODMAGIBHBA CLLFKOMCOND)
	{
		return default(NLEPPIICHML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x26FCAF0", Offset = "0x26FB2F0", VA = "0x1826FCAF0")]
	public static CFNIEHNGKLF NKHHNAPJOMO(SkinnedMeshRenderer[] FPMCAMNKNME, Material KLMJGIMPHKM)
	{
		return default(CFNIEHNGKLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x79BA680", Offset = "0x79B8E80", VA = "0x1879BA680")]
	public static GDJMINGHPLL HILCIJMKFKH(HDJOIAGFMIA PILCIHPNKBK, int HEEKHGMDPBK, int JDPCCKGIKLH, Color NGPIBHNGDAH, Color HGKHBDKJMHL, int OFFDHGGLANH, int MBBBIDKHIBF, Color BHICMPJFHML, Color FBNIMKNBHHI, int KCKLDGBAMDD)
	{
		return default(GDJMINGHPLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x79BA200", Offset = "0x79B8A00", VA = "0x1879BA200")]
	public static HHCGMBNDBPG BECHGOAEBHJ(HDJOIAGFMIA PILCIHPNKBK, Vector2 HEOCEBNBKNA, float GBKACOBJLPI, float PMIJCKDFEKE, float MMCECBGMCCF, Vector2 FOJCDDPDCKE, float HEDCGKCECON, float CONMJJJDBPL, float NJFHKDMGNOB, Vector2 OPHNDHGPPFB, float KFIFLMCMCAH, float CBBJPDGBPAM, float NKOHDCELJEH, Vector2 IBBBEIGBDHD, float GFGLBILHLII, float GHOCDALLBBF, float HEGNONNFJOH)
	{
		return default(HHCGMBNDBPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x79BA400", Offset = "0x79B8C00", VA = "0x1879BA400")]
	public static FGCGEOOLAMI EACCIMHHBCM(Animator LMMBLCNMFGE, ELGEGIFKKGD DIIAAKFKHKD, AvatarConfiguration HGGOEBFPIIL, GameObject MCFLFALJAKC, DODMAGIBHBA CLLFKOMCOND)
	{
		return default(FGCGEOOLAMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x79BA480", Offset = "0x79B8C80", VA = "0x1879BA480")]
	public static ADEKGPFKEJG GNMCIOLLEFO(Transform PGLBPACBADC, bool DKEAHKBPFPF)
	{
		return default(ADEKGPFKEJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JEHHNGNALLG
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x79BEEC0", Offset = "0x79BD6C0", VA = "0x1879BEEC0")]
	public static CFPNNJDNDCC AOIOHGANPKN(this CGLPDKPEOLH CNNIIJDCMKP)
	{
		return default(CFPNNJDNDCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x79BEF10", Offset = "0x79BD710", VA = "0x1879BEF10")]
	public static bool JODMENDACFI(this CGLPDKPEOLH IKLGGLDBDBD)
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
		public enum JOEMGEIOIPE
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
		public BodySkinnedMeshLODs MPICMHGFGIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs DKIHAGNLNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs KDIDCFCGBIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs CCEGOKPEHNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x9E0DB0", Offset = "0x9DF5B0", VA = "0x1809E0DB0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x79B8F00", Offset = "0x79B7700", VA = "0x1879B8F00")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(JOEMGEIOIPE BJENAEIKOON, [Optional] MFGHHKBHMBD? PPGHGKIFDAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
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
		private sealed class PHHAADPDJKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public PHHAADPDJKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x79C31D0", Offset = "0x79C19D0", VA = "0x1879C31D0")]
			internal bool LIJIKBEJFCE(BoneOrderRemapEntry item)
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
		[Cpp2IlInjected.Address(RVA = "0x79B90F0", Offset = "0x79B78F0", VA = "0x1879B90F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x79B90F0", Offset = "0x79B78F0", VA = "0x1879B90F0")]
		private void MLJIHDLBHEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x79B9100", Offset = "0x79B7900", VA = "0x1879B9100")]
		private void NBMDJKMLJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x79B9080", Offset = "0x79B7880", VA = "0x1879B9080")]
		public byte[] FDKNFBADCGF(string DJKLMCAGDNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x79B9250", Offset = "0x79B7A50", VA = "0x1879B9250")]
		public bool NHOEEINCNFK(SkinnedMeshBoneOrderData DAJMAOHDAMN, AvatarSkinnedMeshBonesController JCBCDNJJKKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x79B9CE0", Offset = "0x79B84E0", VA = "0x1879B9CE0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class HIKOEEFLKEM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct FHPDHHCJIID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public Transform[] PHFFNKEOCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public Matrix4x4[] JHEIPHBBFJL;
	}

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static readonly string HHDKMNBKPEA;

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x79BED70", Offset = "0x79BD570", VA = "0x1879BED70")]
	public static byte[] PNFEDJIACPH(AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG, SkinnedMeshRenderer CJBEHDJJKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x79BE870", Offset = "0x79BD070", VA = "0x1879BE870")]
	public static FHPDHHCJIID? GPIPEFMPOGG(AvatarSkinnedMeshBoneOrderRemapsData PBJLLLJMBGG, SkinnedMeshRenderer CJBEHDJJKDF)
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
		[DAFFCFHPHBO(HNCMILCNFNF.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string KEHOHNNIMCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x79B9DB0", Offset = "0x79B85B0", VA = "0x1879B9DB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x79BA1F0", Offset = "0x79B89F0", VA = "0x1879BA1F0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x79BA130", Offset = "0x79B8930", VA = "0x1879BA130")]
		private void NBMDJKMLJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x79B9DE0", Offset = "0x79B85E0", VA = "0x1879B9DE0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x79B9E40", Offset = "0x79B8640", VA = "0x1879B9E40")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer JGPHFKDOCBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum JIFBLNLKJIG
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
public static class DMFDOEOIOEB
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x79BAC80", Offset = "0x79B9480", VA = "0x1879BAC80")]
	public static bool LOPNPOMCFPL(this JIFBLNLKJIG OFFLKMPHDPK)
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
		[Cpp2IlInjected.Address(RVA = "0x79BA820", Offset = "0x79B9020", VA = "0x1879BA820")]
		public List<BodyShapePropertyData> NEEINPNLEMG(DODMAGIBHBA CLLFKOMCOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
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
		public AvatarBodyShapeData.IKDIGDKBAMJ BodyShapeName;

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
		public JIFBLNLKJIG BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct DOBLLPEHFPB : IEquatable<DOBLLPEHFPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public string DLDHOKEFMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public Vector3 CHPCAADKHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public Vector3 MEKKGLHOJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public Vector3 KLAJACPANNP;

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x79BACE0", Offset = "0x79B94E0", VA = "0x1879BACE0", Slot = "4")]
	public bool Equals(DOBLLPEHFPB PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x79BAE20", Offset = "0x79B9620", VA = "0x1879BAE20", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x79BAED0", Offset = "0x79B96D0", VA = "0x1879BAED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum JDJDGFLDBPO
{
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class NLDCDOOJMDE
{
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public static readonly NLDCDOOJMDE CONOIFPANGO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NMBNDFDHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9EBF60", Offset = "0x9EA760", VA = "0x1809EBF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public JDJDGFLDBPO ECCNGMGPILF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB5FCA0", Offset = "0xB5E4A0", VA = "0x180B5FCA0")]
		[CompilerGenerated]
		get
		{
			return default(JDJDGFLDBPO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xC57CC0", Offset = "0xC564C0", VA = "0x180C57CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NLDCDOOJMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2DD3F30", Offset = "0x2DD2730", VA = "0x182DD3F30")]
	public NLDCDOOJMDE(JDJDGFLDBPO MGNGIPCHJJA, int HOFNFJIEDHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum CNOECLPIEKB
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
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
		public AvatarFaceShapeData.KHOFAFCPDPE FaceShapeName;

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
		public CNOECLPIEKB FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x79BD160", Offset = "0x79BB960", VA = "0x1879BD160")]
		public void DrawPosition(bool AKADIMLNNID, Transform POFBAOBKAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x79BD200", Offset = "0x79BBA00", VA = "0x1879BD200")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere OKELLFHGFCL, Transform DFPCBMGPBFO, Vector2 KHMLGLOKJNO, AnchorParamsRestrictions DPFCGKICJNA, bool HGGOLLNDAHH = false, bool ENOELDBBKKJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
		public FitMeshPreviewGizmo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum FEBPCDMMGMN
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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
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
		public DPOJOKMIJDG NoseType;

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
		public FEBPCDMMGMN NoseProperty;

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
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x79C3200", Offset = "0x79C1A00", VA = "0x1879C3200")]
		public void GDDDPADNDOB(SkinnedMeshRenderer CJBEHDJJKDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x79C33A0", Offset = "0x79C1BA0", VA = "0x1879C33A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B7870", Offset = "0x79B6070", VA = "0x1879B7870")]
		public void FNNNOMNCOED(MGPCHDKFLHE AGEMPPFGJPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x79B7D50", Offset = "0x79B6550", VA = "0x1879B7D50")]
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
			[Cpp2IlInjected.Address(RVA = "0xB705C0", Offset = "0xB6EDC0", VA = "0x180B705C0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x79BA840", Offset = "0x79B9040", VA = "0x1879BA840")]
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
			[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x79BBA40", Offset = "0x79BA240", VA = "0x1879BBA40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7810CD0", Offset = "0x780F4D0", VA = "0x187810CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x79BBA60", Offset = "0x79BA260", VA = "0x1879BBA60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7810970", Offset = "0x780F170", VA = "0x187810970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x79BBA80", Offset = "0x79BA280", VA = "0x1879BBA80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xA73AA0", Offset = "0xA722A0", VA = "0x180A73AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1D72000", Offset = "0x1D70800", VA = "0x181D72000")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x79BBAA0", Offset = "0x79BA2A0", VA = "0x1879BBAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x79BB640", Offset = "0x79B9E40", VA = "0x1879BB640", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x79BB930", Offset = "0x79BA130", VA = "0x1879BB930")]
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
			[Cpp2IlInjected.Address(RVA = "0x79BC6C0", Offset = "0x79BAEC0", VA = "0x1879BC6C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1969580", Offset = "0x1967D80", VA = "0x181969580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x14BD0B0", Offset = "0x14BB8B0", VA = "0x1814BD0B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x1969C20", Offset = "0x1968420", VA = "0x181969C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x79BC490", Offset = "0x79BAC90", VA = "0x1879BC490", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x79BC5D0", Offset = "0x79BADD0", VA = "0x1879BC5D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x79C3790", Offset = "0x79C1F90", VA = "0x1879C3790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x79C4410", Offset = "0x79C2C10", VA = "0x1879C4410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private readonly List<GOANNPAHNKI<Sprite>> _spriteResourceHandles;

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
			[Cpp2IlInjected.Address(RVA = "0x9DD1F0", Offset = "0x9DB9F0", VA = "0x1809DD1F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1E0", Offset = "0x9DB9E0", VA = "0x1809DD1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x79BC3E0", Offset = "0x79BABE0", VA = "0x1879BC3E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x79BC450", Offset = "0x79BAC50", VA = "0x1879BC450")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x79BC370", Offset = "0x79BAB70", VA = "0x1879BC370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x79BC3C0", Offset = "0x79BABC0", VA = "0x1879BC3C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x6DFBC20", Offset = "0x6DFA420", VA = "0x186DFBC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x79BBE50", Offset = "0x79BA650", VA = "0x1879BBE50")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x79BBF90", Offset = "0x79BA790", VA = "0x1879BBF90", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x79BBEC0", Offset = "0x79BA6C0", VA = "0x1879BBEC0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x79BC070", Offset = "0x79BA870", VA = "0x1879BC070")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x79BBC40", Offset = "0x79BA440", VA = "0x1879BBC40")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x79BC170", Offset = "0x79BA970", VA = "0x1879BC170")]
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
public static class NKDOEMHCBNE
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x79C3020", Offset = "0x79C1820", VA = "0x1879C3020")]
	public static JKHHFLAMEIB FCPJNDHLIIP(this FaceFeatureType GJOMIGIHMND, AHOGOONMGAK BAEHAEFCNBH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class HDJOIAGFMIA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct LBOONDPCJOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<HDJOIAGFMIA> <>t__builder;

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
		private MBIIGEKJFNE.HKDKBBNMCKI <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x79BF550", Offset = "0x79BDD50", VA = "0x1879BF550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x79BFD80", Offset = "0x79BE580", VA = "0x1879BFD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private readonly Dictionary<string, int> COGPEKJDGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool NNGOKAOGOHB;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Texture2DArray NKGBLIPDHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public SymmetricalFaceFeature DCHBCPDAIHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9DF740", Offset = "0x9DDF40", VA = "0x1809DF740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EyesFaceFeature IGNAPAELLMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9DF790", Offset = "0x9DDF90", VA = "0x1809DF790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9DF780", Offset = "0x9DDF80", VA = "0x1809DF780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FaceFeature FGMFFJBJBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9DF750", Offset = "0x9DDF50", VA = "0x1809DF750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x79BD840", Offset = "0x79BC040", VA = "0x1879BD840")]
	private static void ENBNMIEEJJA(Sprite BBJADLNBAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x79BE100", Offset = "0x79BC900", VA = "0x1879BE100")]
	public static HDJOIAGFMIA KBILKELKMBH(SymmetricalFaceFeature CNPMFINLOFP, EyesFaceFeature ANMBGLCIEAC, FaceFeature CMNAFDFNHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x79BE190", Offset = "0x79BC990", VA = "0x1879BE190")]
	[AsyncStateMachine(typeof(LBOONDPCJOO))]
	public static Task<HDJOIAGFMIA> NPKEBEJPBLD(SymmetricalFaceFeature CNPMFINLOFP, EyesFaceFeature ANMBGLCIEAC, FaceFeature CMNAFDFNHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x79BE3C0", Offset = "0x79BCBC0", VA = "0x1879BE3C0")]
	private HDJOIAGFMIA(SymmetricalFaceFeature CNPMFINLOFP, EyesFaceFeature ANMBGLCIEAC, FaceFeature CMNAFDFNHBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x79BD9C0", Offset = "0x79BC1C0", VA = "0x1879BD9C0")]
	private void FOGINMBOMDJ(List<Sprite> MHCAKOLNGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x79BE2D0", Offset = "0x79BCAD0", VA = "0x1879BE2D0")]
	public bool OBNNNJNGKNG(string MKPFPNFLDOG, [Out] int FPEOONOJHML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x79BD810", Offset = "0x79BC010", VA = "0x1879BD810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x79BD8B0", Offset = "0x79BC0B0", VA = "0x1879BD8B0")]
	public bool FFFKLPKJBMG(bool EIAJBPOAHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x79BD740", Offset = "0x79BBF40", VA = "0x1879BD740")]
	public void ABBHEPKAOFI()
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
		private struct KKMFOCANPDJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public AsyncTaskMethodBuilder<HDJOIAGFMIA> <>t__builder;

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
			private TaskAwaiter<HDJOIAGFMIA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x79BEF20", Offset = "0x79BD720", VA = "0x1879BEF20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x79BF420", Offset = "0x79BDC20", VA = "0x1879BF420", Slot = "5")]
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
		private Dictionary<MFGHHKBHMBD, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private Dictionary<MFGHHKBHMBD, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private Dictionary<MFGHHKBHMBD, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private Dictionary<MFGHHKBHMBD, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly Dictionary<MFGHHKBHMBD, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private HDJOIAGFMIA _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private HDJOIAGFMIA _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x79BD130", Offset = "0x79BB930", VA = "0x1879BD130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x79BCCB0", Offset = "0x79BB4B0", VA = "0x1879BCCB0")]
		public HDJOIAGFMIA KDFPIJFAKKD(DODMAGIBHBA CLLFKOMCOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x79BCE50", Offset = "0x79BB650", VA = "0x1879BCE50")]
		[AsyncStateMachine(typeof(KKMFOCANPDJ))]
		public Task<HDJOIAGFMIA> NNKKFDLEDFD(int? PKJCIJDOCFH, int ANMBGLCIEAC, int CMNAFDFNHBP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x79BCA90", Offset = "0x79BB290", VA = "0x1879BCA90")]
		public NoseFaceOption ICFODMHNOBO(int NMFJOCPIJJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x79BC6E0", Offset = "0x79BAEE0", VA = "0x1879BC6E0")]
		public SelectableFaceOption CCEHIOOKDDK(FaceFeatureType KIMBBBOIMAP, MFGHHKBHMBD DEDDEMFLPGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x79BCF80", Offset = "0x79BB780", VA = "0x1879BCF80")]
		public int PNJGCACKHEC(MFGHHKBHMBD DEDDEMFLPGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x79BC860", Offset = "0x79BB060", VA = "0x1879BC860")]
		private void FIKMFLKFHIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x378E6D0", Offset = "0x378CED0", VA = "0x18378E6D0")]
		private void ACIFPNNFKID<T>(IDictionary<MFGHHKBHMBD, T> BFIDNFGDLKJ, IReadOnlyList<T> JPLMHAAEBKA) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x79BCD40", Offset = "0x79BB540", VA = "0x1879BCD40")]
		public MFGHHKBHMBD NBGADKHJLMO(FaceFeatureType KIMBBBOIMAP)
		{
			return default(MFGHHKBHMBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x79BCB30", Offset = "0x79BB330", VA = "0x1879BCB30")]
		public MFGHHKBHMBD KAGBAPPDFLN(FaceFeatureType KIMBBBOIMAP)
		{
			return default(MFGHHKBHMBD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x79BD000", Offset = "0x79BB800", VA = "0x1879BD000")]
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
			[Cpp2IlInjected.Address(RVA = "0xBCB360", Offset = "0xBC9B60", VA = "0x180BCB360", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x79BC5D0", Offset = "0x79BADD0", VA = "0x1879BC5D0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public DPOJOKMIJDG SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xBB4EE0", Offset = "0xBB36E0", VA = "0x180BB4EE0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
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
		public MFGHHKBHMBD FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x1DA05C0", Offset = "0x1D9EDC0", VA = "0x181DA05C0")]
			get
			{
				return default(MFGHHKBHMBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xD58CC0", Offset = "0xD574C0", VA = "0x180D58CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD58CD0", Offset = "0xD574D0", VA = "0x180D58CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9DF770", Offset = "0x9DDF70", VA = "0x1809DF770")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B77C0", Offset = "0x79B5FC0", VA = "0x1879B77C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xB90A50", Offset = "0xB8F250", VA = "0x180B90A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x79C3710", Offset = "0x79C1F10", VA = "0x1879C3710")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6DF7AA0", Offset = "0x6DF62A0", VA = "0x186DF7AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x79C3750", Offset = "0x79C1F50", VA = "0x1879C3750")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x6DF7AB0", Offset = "0x6DF62B0", VA = "0x186DF7AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x79C3730", Offset = "0x79C1F30", VA = "0x1879C3730")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x6DFAE50", Offset = "0x6DF9650", VA = "0x186DFAE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x79C3770", Offset = "0x79C1F70", VA = "0x1879C3770")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6DFAE40", Offset = "0x6DF9640", VA = "0x186DFAE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x79C3430", Offset = "0x79C1C30", VA = "0x1879C3430", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x79C3640", Offset = "0x79C1E40", VA = "0x1879C3640")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class LNICJJLJDGA
{
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly float PKBKBHKLMEO;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly float DBOEBNILBFJ;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Vector2 KAKBKANKJGM;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Vector2 DHNDPPIIOLH;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Vector2 AHCDBCFPDPA;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Vector2 ABEDMAPAHNK;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Vector2 GICONOGLLFM;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Vector2 JLNJOEKHKAO;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Vector2 NOPKKLCKMFK;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Vector2 LKGEEIOBJCJ;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Vector2 MOGMNOCANOC;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Vector2 IKCPGCAJDIK;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Vector2 AAAPHMPODPP;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Vector2 MCJHKDILOJN;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x79C1A50", Offset = "0x79C0250", VA = "0x1879C1A50")]
	public static Vector2 JPILDIHHFFD(FaceFeatureType GJOMIGIHMND, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x79C2A20", Offset = "0x79C1220", VA = "0x1879C2A20")]
	public static float OKIMEBBOECL(FaceFeatureType GJOMIGIHMND, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x79C0230", Offset = "0x79BEA30", VA = "0x1879C0230")]
	public static void EEDMDCENIMO(MGPCHDKFLHE MOLPOJOPBIC, AvatarConfiguration HGGOEBFPIIL, DODMAGIBHBA IPPNOLIPCLO, DODMAGIBHBA BELHGIKGNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x79C09D0", Offset = "0x79BF1D0", VA = "0x1879C09D0")]
	public static float GHNBKGHDLBL(FaceFeatureType KIMBBBOIMAP, float ALFNELEBCCM, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x79C2990", Offset = "0x79C1190", VA = "0x1879C2990")]
	public static float OIHDCOGAPNO(FaceFeatureType KIMBBBOIMAP, float DMPEMPFKELM, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x79C2850", Offset = "0x79C1050", VA = "0x1879C2850")]
	public static float NECHBIAINKM(FaceFeatureType KIMBBBOIMAP, float PMHMEKBKJJA, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x79C03B0", Offset = "0x79BEBB0", VA = "0x1879C03B0")]
	public static float EMGMMCBAEDP(FaceFeatureType KIMBBBOIMAP, float GOKBHMBGOCI, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x79C0600", Offset = "0x79BEE00", VA = "0x1879C0600")]
	public static float FEDJHACDKLN(FaceFeatureType KIMBBBOIMAP, float OPOFKLAOFOE, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x79C01A0", Offset = "0x79BE9A0", VA = "0x1879C01A0")]
	public static float CKNHIIKKGGH(FaceFeatureType KIMBBBOIMAP, float JPHBHBJJNHG, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x79C0020", Offset = "0x79BE820", VA = "0x1879C0020")]
	public static Vector2 BPJADJJGJOL(FaceFeatureType KIMBBBOIMAP, Vector2 BMIOGPDPFFN, Vector2 AJDLKCAMIGF, Vector2 ENMBECMAHJB, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x79C1550", Offset = "0x79BFD50", VA = "0x1879C1550")]
	public static Vector2 JBNPDIKCIMB(FaceFeatureType KIMBBBOIMAP, Vector2 AIKKKIPJCNA, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x79C0700", Offset = "0x79BEF00", VA = "0x1879C0700")]
	private static Vector2 FMFNGKOHJMG(FaceFeatureType KIMBBBOIMAP, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x79C0B20", Offset = "0x79BF320", VA = "0x1879C0B20")]
	private static Vector2 GJKFGINPBMN(FaceFeatureType KIMBBBOIMAP, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x79C1FB0", Offset = "0x79C07B0", VA = "0x1879C1FB0")]
	private static Vector2 LHANLCNBNNJ(FaceFeatureType KIMBBBOIMAP, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x79C0FE0", Offset = "0x79BF7E0", VA = "0x1879C0FE0")]
	private static Vector2 HKDBFJDLEDJ(FaceFeatureType KIMBBBOIMAP, Vector2 BMIOGPDPFFN, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x79C2320", Offset = "0x79C0B20", VA = "0x1879C2320")]
	public static Vector2 LKPIMHBGPLO(FaceFeatureType KIMBBBOIMAP, Vector2 AIKKKIPJCNA, Vector2 AJDLKCAMIGF, Vector2 ENMBECMAHJB, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x79C1330", Offset = "0x79BFB30", VA = "0x1879C1330")]
	public static float IOAJMGBNANB(FaceFeatureType KIMBBBOIMAP, float DMPEMPFKELM, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x79C0440", Offset = "0x79BEC40", VA = "0x1879C0440")]
	public static float EMKONDMPGAB(FaceFeatureType KIMBBBOIMAP, float PMHMEKBKJJA, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x79C2C10", Offset = "0x79C1410", VA = "0x1879C2C10")]
	public static float PDHMMDMOCML(FaceFeatureType KIMBBBOIMAP, float GOKBHMBGOCI, DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x79C0F50", Offset = "0x79BF750", VA = "0x1879C0F50")]
	private static float HIODJPACFLI(float EDGENFDJJHO, float FGNFJAMALCL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x79C27A0", Offset = "0x79C0FA0", VA = "0x1879C27A0")]
	private static Vector2 MAGHEBNEDEO(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x79C0860", Offset = "0x79BF060", VA = "0x1879C0860")]
	private static Vector2 FNJJGIPKDEC(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x79C18E0", Offset = "0x79C00E0", VA = "0x1879C18E0")]
	private static Vector2 JNOHLNKKPAP(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x79C28E0", Offset = "0x79C10E0", VA = "0x1879C28E0")]
	private static Vector2 OEFMLLOHIJB(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x79C17B0", Offset = "0x79BFFB0", VA = "0x1879C17B0")]
	private static float JDOAOFBBCMP(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x79C04E0", Offset = "0x79BECE0", VA = "0x1879C04E0")]
	private static float ENJKLFAGGJG(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x79C0690", Offset = "0x79BEE90", VA = "0x1879C0690")]
	private static float FMCENIKFPAJ(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x79C1E80", Offset = "0x79C0680", VA = "0x1879C1E80")]
	private static float KJBEIBMMHJO(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x79C0E90", Offset = "0x79BF690", VA = "0x1879C0E90")]
	private static Vector2 HBLNKMBBAGC(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x79C1DC0", Offset = "0x79C05C0", VA = "0x1879C1DC0")]
	private static Vector2 KECLPHGAKGO(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x79C1270", Offset = "0x79BFA70", VA = "0x1879C1270")]
	private static Vector2 IJJOPMJAHMH(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x79C00F0", Offset = "0x79BE8F0", VA = "0x1879C00F0")]
	private static Vector2 CDCAGGNFLPN(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x79C2CB0", Offset = "0x79C14B0", VA = "0x1879C2CB0")]
	private static Vector2 PKIHFEGFGGG(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x79C0910", Offset = "0x79BF110", VA = "0x1879C0910")]
	private static Vector2 GAGBLHDDGEO(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x79C11B0", Offset = "0x79BF9B0", VA = "0x1879C11B0")]
	private static Vector2 IDNANBNLPLG(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x79C1820", Offset = "0x79C0020", VA = "0x1879C1820")]
	private static Vector2 JJBPOHCADOG(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x79C0550", Offset = "0x79BED50", VA = "0x1879C0550")]
	private static Vector2 FAFLFHHLBMK(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x79BFEB0", Offset = "0x79BE6B0", VA = "0x1879BFEB0")]
	private static Vector2 AKENDANLPJO(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x79C1EF0", Offset = "0x79C06F0", VA = "0x1879C1EF0")]
	private static Vector2 LCNNDOHMAIF(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x79C2D60", Offset = "0x79C1560", VA = "0x1879C2D60")]
	private static Vector2 PNFPKMHLIGI(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x79BFF60", Offset = "0x79BE760", VA = "0x1879BFF60")]
	private static Vector2 BEKOCHPMEDP(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x79C1D00", Offset = "0x79C0500", VA = "0x1879C1D00")]
	private static Vector2 KAFDAAPJPBD(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x79C0DD0", Offset = "0x79BF5D0", VA = "0x1879C0DD0")]
	private static Vector2 GLOEDJAEDCA(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x79C02F0", Offset = "0x79BEAF0", VA = "0x1879C02F0")]
	private static Vector2 EEHFDNCMLGN(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x79C1990", Offset = "0x79C0190", VA = "0x1879C1990")]
	private static Vector2 JOELEJFNNIJ(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x79C0A60", Offset = "0x79BF260", VA = "0x1879C0A60")]
	private static Vector2 GHNKLEAMLEL(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x79BFDF0", Offset = "0x79BE5F0", VA = "0x1879BFDF0")]
	private static Vector2 AHABFADNEMG(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x79C2260", Offset = "0x79C0A60", VA = "0x1879C2260")]
	private static Vector2 LJAILPBPIPA(DODMAGIBHBA CLLFKOMCOND, AvatarConfiguration COMMPENJPKB)
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
