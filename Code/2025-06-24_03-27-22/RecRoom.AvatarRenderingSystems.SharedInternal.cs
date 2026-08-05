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
		[Cpp2IlInjected.Address(RVA = "0x7C49FE0", Offset = "0x7C48BE0", VA = "0x187C49FE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
		public AvatarFaceShapeData.LBCIECHIFGF FaceShapeName;

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
		public AvatarBodyShapeData.IPHFNEHEGNI BodyShapeName;

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
		public IEKNNJIHFMK BodyProperty;

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
		public AFLDMIJCCDM FaceProperty;

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
		public PPFKBBIJKBH NoseProperty;

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
		public KMBJPNFNLBA NoseType;

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
		public IEKNNJIHFMK BodyProperty;

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
		public AFLDMIJCCDM FaceProperty;

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
		public PPFKBBIJKBH NoseProperty;

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
		public CGEIFNKNMGB PropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Flags]
public enum CGEIFNKNMGB
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
		private sealed class LGHJHNGJGNE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public LGHJHNGJGNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7C5C4F0", Offset = "0x7C5B0F0", VA = "0x187C5C4F0")]
			internal bool GOBHAFCBOLF(KeyValuePair<string, Transform> bone)
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
		private List<AvatarFaceShapeData.LBCIECHIFGF> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private List<AvatarBodyShapeData.IPHFNEHEGNI> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<IEKNNJIHFMK, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Dictionary<AFLDMIJCCDM, List<float>> facePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Dictionary<PPFKBBIJKBH, List<float>> nosePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(string, AvatarFaceShapeData.LBCIECHIFGF), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(string, AvatarBodyShapeData.IPHFNEHEGNI), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<(string, KMBJPNFNLBA), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<(string, IEKNNJIHFMK, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<IEKNNJIHFMK, Dictionary<string, CGEIFNKNMGB>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<(string, AFLDMIJCCDM, float), AvatarBodyPartBoneData> facePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Dictionary<AFLDMIJCCDM, Dictionary<string, CGEIFNKNMGB>> facePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Dictionary<(string, PPFKBBIJKBH, float), AvatarBodyPartBoneData> nosePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Dictionary<PPFKBBIJKBH, Dictionary<string, CGEIFNKNMGB>> nosePropertyBoneInfluenceInfoMapping;

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
		private readonly Dictionary<IEKNNJIHFMK, string[]> bonesToUpdatePerBodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly Dictionary<AFLDMIJCCDM, string[]> bonesToUpdatePerFaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Dictionary<PPFKBBIJKBH, string[]> bonesToUpdatePerNoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Dictionary<string, Dictionary<CGEIFNKNMGB, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C511A0", Offset = "0x7C4FDA0", VA = "0x187C511A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D340", Offset = "0x7C4BF40", VA = "0x187C4D340")]
		public void LEIJOMGLGOC(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FCD0", Offset = "0x7C4E8D0", VA = "0x187C4FCD0")]
		public void OKCDIBGCDOF(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, AvatarFaceShapeData.LBCIECHIFGF OANIPCLJBHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C4BD30", Offset = "0x7C4A930", VA = "0x187C4BD30")]
		public void GNDLFGGAPBB(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, KMBJPNFNLBA MAPLPIGEHBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F800", Offset = "0x7C4E400", VA = "0x187C4F800")]
		public void OCBCDMCGDBI(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, AvatarBodyShapeData.IPHFNEHEGNI NLMAEIDEOID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B290", Offset = "0x7C49E90", VA = "0x187C4B290")]
		public void DCMIFDEIJGP(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, IReadOnlyDictionary<string, LMCCLMLIJIC> LLPIDCGMAHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C500D0", Offset = "0x7C4ECD0", VA = "0x187C500D0")]
		public IReadOnlyDictionary<string, LMCCLMLIJIC> PDONPAMMCMD(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F760", Offset = "0x7C4E360", VA = "0x187C4F760")]
		public Dictionary<string, LMCCLMLIJIC> NLFMBHDJCGI(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, IReadOnlyDictionary<IEKNNJIHFMK, float> JELBFNHIGOP, IReadOnlyDictionary<string, LMCCLMLIJIC> CBEBMEPPNCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F650", Offset = "0x7C4E250", VA = "0x187C4F650")]
		public Dictionary<string, LMCCLMLIJIC> MAMKMIOIEHD(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, IReadOnlyDictionary<AFLDMIJCCDM, float> HCJHLMIHPBO, IReadOnlyDictionary<string, LMCCLMLIJIC> CBEBMEPPNCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D130", Offset = "0x7C4BD30", VA = "0x187C4D130")]
		public Dictionary<string, LMCCLMLIJIC> JIGFHDPELMJ(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, IReadOnlyDictionary<PPFKBBIJKBH, float> NAFHBEBKMAL, IReadOnlyDictionary<string, LMCCLMLIJIC> CBEBMEPPNCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x382EFF0", Offset = "0x382DBF0", VA = "0x18382EFF0")]
		private Dictionary<string, LMCCLMLIJIC> GOHBOCOEOHF<T>(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, IReadOnlyDictionary<T, float> MGOPLNGBKII, IReadOnlyDictionary<string, LMCCLMLIJIC> BHJHCCIDEKP, Dictionary<T, Dictionary<string, CGEIFNKNMGB>> MMGJHBGGOJE, Dictionary<(string, T, float), AvatarBodyPartBoneData> OFDLJJAGPOF, bool HJLHFGNNOOJ, bool BKOBGCLCJLG, [Optional] float? IMDOMLLGCAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D2B0", Offset = "0x7C4BEB0", VA = "0x187C4D2B0")]
		public static (float, float) JLGFFCKJJDB(float IEAOONNIHEF)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B230", Offset = "0x7C49E30", VA = "0x187C4B230")]
		public float DBOMEAMBGGP(IEKNNJIHFMK EGADONEDPAC, float DCHGEOKLPMN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F6F0", Offset = "0x7C4E2F0", VA = "0x187C4F6F0")]
		public float NDLOCIDICEH(AFLDMIJCCDM MDFALFHFLME, float IBKCAEGEFHE)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F5E0", Offset = "0x7C4E1E0", VA = "0x187C4F5E0")]
		public float MAEIFFCKPOO(PPFKBBIJKBH EEMPKBDIOGI, float NJGOMKMBBJI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3830470", Offset = "0x382F070", VA = "0x183830470")]
		private float LIHPMECFDGG<T>(T NMCGBFDKCMK, float BNNDMKEAJNH, Dictionary<T, List<float>> NEONOFKMHHD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F450", Offset = "0x7C4E050", VA = "0x187C4F450")]
		private LMCCLMLIJIC LKJGIDGGIIH(IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, string NHALHFDGPIO)
		{
			return default(LMCCLMLIJIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FFD0", Offset = "0x7C4EBD0", VA = "0x187C4FFD0")]
		private float OLAFPNAABMJ(float OOHGFGHCOAJ, List<float> GAAHBNDIFFN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C4F3E0", Offset = "0x7C4DFE0", VA = "0x187C4F3E0")]
		private Vector3 LGIFCJADHBL(Transform OKEPFFAIAAN, AvatarBodyPartBoneData JMJHOFJGIDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C50520", Offset = "0x7C4F120", VA = "0x187C50520")]
		private Quaternion PPFOPKOCEJJ(Transform OKEPFFAIAAN, AvatarBodyPartBoneData JMJHOFJGIDD)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C504B0", Offset = "0x7C4F0B0", VA = "0x187C504B0")]
		private Vector3 PKGEAIPCIMP(Transform OKEPFFAIAAN, AvatarBodyPartBoneData JMJHOFJGIDD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C4A170", Offset = "0x7C48D70", VA = "0x187C4A170")]
		private void DBCGFDDBMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6DDCB00", Offset = "0x6DDB700", VA = "0x186DDCB00")]
		public bool KKJGAEPIPKO(CGEIFNKNMGB NAGJEAAIJAD, CGEIFNKNMGB IBAGBODOCEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4C150", Offset = "0x7C4AD50", VA = "0x187C4C150")]
		private LMCCLMLIJIC IIAJGIBOIME(CGEIFNKNMGB BMMFIIMCNCG, LMCCLMLIJIC OKEPFFAIAAN, AvatarBodyPartBoneData JMJHOFJGIDD)
		{
			return default(LMCCLMLIJIC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4B6A0", Offset = "0x7C4A2A0", VA = "0x187C4B6A0")]
		public Dictionary<string, LMCCLMLIJIC> GMBHBJIOGJK(Dictionary<string, LMCCLMLIJIC> IJDKFMFECNH, bool HJLHFGNNOOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7C4FB00", Offset = "0x7C4E700", VA = "0x187C4FB00")]
		private void OGHBCMNEGID(Transform OKEPFFAIAAN, AvatarBodyPartBoneData JMJHOFJGIDD, bool CPFFDLMOOCE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7C507F0", Offset = "0x7C4F3F0", VA = "0x187C507F0")]
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
		public IEKNNJIHFMK BodyProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x7C512A0", Offset = "0x7C4FEA0", VA = "0x187C512A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum IPHFNEHEGNI
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
		public IPHFNEHEGNI blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
		private AvatarBodyShapeData.IPHFNEHEGNI blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LIEKGDGCODL BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7070", Offset = "0x1FA5C70", VA = "0x181FA7070")]
			get
			{
				return default(LIEKGDGCODL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.IPHFNEHEGNI BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xC96C30", Offset = "0xC95830", VA = "0x180C96C30")]
			get
			{
				return default(AvatarBodyShapeData.IPHFNEHEGNI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C51D30", Offset = "0x7C50930", VA = "0x187C51D30")]
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
		public AvatarBodyShapeData.IPHFNEHEGNI BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C515B0", Offset = "0x7C501B0", VA = "0x187C515B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
		private readonly Dictionary<LIEKGDGCODL, AvatarBodyShape> GALHNMPGLJE;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C51820", Offset = "0x7C50420", VA = "0x187C51820")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C51B40", Offset = "0x7C50740", VA = "0x187C51B40")]
		public AvatarBodyShape Find(LIEKGDGCODL DKCOIIJHEGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C51C40", Offset = "0x7C50840", VA = "0x187C51C40")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C51C00", Offset = "0x7C50800", VA = "0x187C51C00")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C51C80", Offset = "0x7C50880", VA = "0x187C51C80")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GAMNICMFGDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Transform[] LJPFOHHAEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<string, Transform> GICCIIFOOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Transform, Transform> HECACIAIEHG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> NHGNHFBJCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] CAKHFNMIIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BC80", Offset = "0x7C5A880", VA = "0x187C5BC80")]
	public void HHFJAKADELB(Transform KIEMKFLPAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C150", Offset = "0x7C5AD50", VA = "0x187C5C150")]
	public Transform OIAJPCAMFMO(Transform APBIAHDCDIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BF10", Offset = "0x7C5AB10", VA = "0x187C5BF10")]
	public void LPCDJBMKHKE(SkinnedMeshRenderer DGNBGAOENKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C5BD60", Offset = "0x7C5A960", VA = "0x187C5BD60")]
	private static void LEICFAFLCFA(Transform HMGDINOCJAI, List<Transform> AJDCHCNBIKJ, Dictionary<string, Transform> EJBJFCOLJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C230", Offset = "0x7C5AE30", VA = "0x187C5C230")]
	public GAMNICMFGDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BPPOMJONOGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool DOJINEKCJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool ILAGFNEGFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool FLHKDMDGJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public DOLBAFHNJDK? JKAGEOOKOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public IONAMLJCLBI.EPMFDMLBDCD HLIKHNMEDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public HairData APCEIELJPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public AdditionalHatData PJJONLIABJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool GPFCCPLLGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public bool KJJFOOOEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public bool HFOIPNDKLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public bool ALAAFFDEJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public IList<LLGDDBJNDAK> MLPMCOPCMAE;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public BPPOMJONOGG()
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
		[Cpp2IlInjected.Address(RVA = "0x7C51DC0", Offset = "0x7C509C0", VA = "0x187C51DC0")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum OKPBOLNLMDJ
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
		public OKPBOLNLMDJ RangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Vector2 Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public KFOBCPDEMJM Version;
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KLFAMOOIGJO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static AAGNIDDOHPO LMBEMAJLKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C360", Offset = "0x7C5AF60", VA = "0x187C5C360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static JJMEKHLKNJB MHBINLIAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C3C0", Offset = "0x7C5AFC0", VA = "0x187C5C3C0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EPLCEEHGJGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public Transform FKEEALGNACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public AvatarSkinAssetItem CMBBBFHLNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public AssetReference LDDJJMBEHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public GameObject DLBGNCILOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public GameObject KKENGMCLGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public SkinnedMeshRenderer CBILDEOCEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public AvatarSkinnedMeshBoneOrderRemapsData AIBOEOOKHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Material DAHMEGKGCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Material BDFNONJJGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Material AKEJFPLEPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Material JBHEJOANIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public Shader CGOCINCACNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Shader OCAMBIMDHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Animator NAKFIMNBDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Renderer[] POLOKJHDFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public AvatarConfiguration LKMFCECIBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public AvatarBodyPartShapesManager JINDKIOPPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public IReadOnlyDictionary<string, Transform> AGBNBHPBNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Transform DJPPDMLDHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public CIFHCHIGFCF HMOHOLHLCEL;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct MMNFJHLEJHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public SkinnedMeshRenderer[] BOGNJNINLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public SkinnedMeshRenderer[] MBENCIPBOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public SkinnedMeshRenderer[] CCFEBELMFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public SkinnedMeshRenderer[] FBDPILJHDLG;
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
public struct MHLPKNEKDOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public Transform MCNPOJCDLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public Transform KJNPMNMLEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public Transform HAIMIGGPLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public Transform MHAKCNEIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Transform IAPGKFNLNMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Transform DMBHDDEAFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public AvatarConfiguration LKMFCECIBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public CIFHCHIGFCF HMOHOLHLCEL;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HEILDFICPPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public SkinnedMeshRenderer[] JANJLBCBBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Material IFNKPPEELDE;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct LMICPILDBNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public BEKEHOGMLKK JMJCCJPAOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public int IMIFGBFPFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Color OEILPKHOGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Color NMHKINNIOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public int HHLDOHHGGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Color NPPCKDHDNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Color GMKABBFOMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int NKPIIJLMAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float PHOBNIEGECF;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct EABIGMNFGNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public BEKEHOGMLKK JMJCCJPAOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Vector2 DJGJPBBILKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public float AFMFKAPDDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public float CMHGFJNECKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public float OOPKFNKKGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Vector2 PIIBOMMJHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public float FGJNKDKBLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public float MPDMGAACCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float JAFCAMDNKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector2 EIABLEALGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public float GNEMIKPPEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public float FGJOHJBNIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public float APGNLMCHNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Vector2 NNHNCGPEEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float IBABIPPIJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public float PHOBNIEGECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public float MEPKBGBFPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public bool OLEKJMDCEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public bool KKCGAGDIKFA;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AFLDMIJCCDM FaceProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x7C52410", Offset = "0x7C51010", VA = "0x187C52410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum LBCIECHIFGF
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
		public LBCIECHIFGF blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
		private AvatarFaceShapeData.LBCIECHIFGF blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ANPCAKLHJAE FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7070", Offset = "0x1FA5C70", VA = "0x181FA7070")]
			get
			{
				return default(ANPCAKLHJAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.LBCIECHIFGF BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xC96C30", Offset = "0xC95830", VA = "0x180C96C30")]
			get
			{
				return default(AvatarFaceShapeData.LBCIECHIFGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C52EA0", Offset = "0x7C51AA0", VA = "0x187C52EA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C52F00", Offset = "0x7C51B00", VA = "0x187C52F00")]
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
		public AvatarFaceShapeData.LBCIECHIFGF FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C52720", Offset = "0x7C51320", VA = "0x187C52720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
		private readonly Dictionary<ANPCAKLHJAE, AvatarFaceShape> GALHNMPGLJE;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7C52990", Offset = "0x7C51590", VA = "0x187C52990")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7C52CB0", Offset = "0x7C518B0", VA = "0x187C52CB0")]
		public AvatarFaceShape Find(ANPCAKLHJAE KDMHOIMFDLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C52DB0", Offset = "0x7C519B0", VA = "0x187C52DB0")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7C52D70", Offset = "0x7C51970", VA = "0x187C52D70")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7C52DF0", Offset = "0x7C519F0", VA = "0x187C52DF0")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7C53550", Offset = "0x7C52150", VA = "0x187C53550")]
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
		public KIGICGBMFCD HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7070", Offset = "0x1FA5C70", VA = "0x181FA7070")]
			get
			{
				return default(KIGICGBMFCD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA24670", Offset = "0xA23270", VA = "0x180A24670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xCBAD60", Offset = "0xCB9960", VA = "0x180CBAD60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCEF8C0", Offset = "0xCEE4C0", VA = "0x180CEF8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7C536B0", Offset = "0x7C522B0", VA = "0x187C536B0")]
		public Texture2D GHGPCLNDOHC(HairPatternStyle LKOJKNIMGJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C535D0", Offset = "0x7C521D0", VA = "0x187C535D0", Slot = "0")]
		public override bool Equals(object KDKJDFFGNJJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C53560", Offset = "0x7C52160", VA = "0x187C53560", Slot = "4")]
		public bool Equals(AvatarHairPattern GMNGNCHKEBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C53890", Offset = "0x7C52490", VA = "0x187C53890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C53800", Offset = "0x7C52400", VA = "0x187C53800", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7C53680", Offset = "0x7C52280", VA = "0x187C53680")]
		public static bool FOFOJFKGMNN(AvatarHairPattern HLPEBKMLKLE, AvatarHairPattern MAELALMKOEM)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C53810", Offset = "0x7C52410", VA = "0x187C53810")]
		public static bool JOHLOKGLNML(AvatarHairPattern HLPEBKMLKLE, AvatarHairPattern MAELALMKOEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C538D0", Offset = "0x7C524D0", VA = "0x187C538D0")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum CNIBPJLPBFA
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
public enum NFIEDKKPELO
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
public struct IKGGABJJCMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Animator PCMHMCJOBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public AHDEEIHKKKF HMNBDJGAPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public AvatarConfiguration LKMFCECIBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public GameObject MJMDHCGKOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public CIFHCHIGFCF HMOHOLHLCEL;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct ILCGLEGGDGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	public Transform LMJOPGOHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public bool IBJPLGKIFLJ;
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
		[Cpp2IlInjected.Address(RVA = "0x7C539E0", Offset = "0x7C525E0", VA = "0x187C539E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class LLGDDBJNDAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public string AJPMCBKCCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public OutfitType FEMDHAMIGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public HBNDGNKPEKC IGJFEOCOCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public IONAMLJCLBI.EPMFDMLBDCD FBJHBFBPFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public bool CHDHOGJEKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public bool DAGEDEFKFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public bool AAAFMEOGFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Color? LBNBBCJLKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool PJEPLKIJNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public Color? KOCMILDENNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool BLPAAOFCENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public bool HDPGAHAJCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool FHMCPGIIMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Transform LMJPONIMPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector2? EBLPNABLKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public FitMeshHemisphere GNOANFJBKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public AssetReference GFEBGLHIAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public AssetReference OFLGABCNLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public AssetReference[] GKNPBFBDFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public LLGDDBJNDAK LFJCFKDBNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public bool HMLMBMOKJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public bool KBKGKCIPLBG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string AMLAEGNGNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CDF0", Offset = "0x7C5B9F0", VA = "0x187C5CDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CDF0", Offset = "0x7C5B9F0", VA = "0x187C5CDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CEA0", Offset = "0x7C5BAA0", VA = "0x187C5CEA0")]
	public LLGDDBJNDAK()
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
		private CIDEIGJIEDC? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PLMOHPIJHDA CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7C53F70", Offset = "0x7C52B70", VA = "0x187C53F70")]
			get
			{
				return default(PLMOHPIJHDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public CIDEIGJIEDC MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7C53FA0", Offset = "0x7C52BA0", VA = "0x187C53FA0")]
			get
			{
				return default(CIDEIGJIEDC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6A0", Offset = "0xA1B2A0", VA = "0x180A1C6A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA1C6E0", Offset = "0xA1B2E0", VA = "0x180A1C6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7C53A70", Offset = "0x7C52670", VA = "0x187C53A70")]
		public Material[] BFDGOICGHPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7C53D00", Offset = "0x7C52900", VA = "0x187C53D00")]
		public static void NOMMJENLIKP(AvatarItemMaterial CABPBIPNCCM, Material IMKAMKEPJBL, int BNDMLLLLIFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7C53B50", Offset = "0x7C52750", VA = "0x187C53B50")]
		private static bool LDKNKGIFJKN(AvatarItemMaterial CABPBIPNCCM, int BNDMLLLLIFG, [Out] Material OFMAOKCHFMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7C53EF0", Offset = "0x7C52AF0", VA = "0x187C53EF0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EMKPFPGHPGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public SkinnedMeshRenderer DBCKODGBDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Material[] PKNLIBACDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private byte[] AFEFJOMNAME;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh MAPHLJEMNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7C59920", Offset = "0x7C58520", VA = "0x187C59920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Material[] GPIOFJCAEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public byte[] JPNINHEJBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7C59AE0", Offset = "0x7C586E0", VA = "0x187C59AE0")]
	public EMKPFPGHPGK(SkinnedMeshRenderer APIEKGDHKJG, AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL, Material[] INOMMMLPMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7C59940", Offset = "0x7C58540", VA = "0x187C59940")]
	public static EMKPFPGHPGK ODHDDCCGBOG(Renderer GJIEBJCNJLG, AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL, Material[] INOMMMLPMED)
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
			[Cpp2IlInjected.Address(RVA = "0x15A5D70", Offset = "0x15A4970", VA = "0x1815A5D70")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xD1EDF0", Offset = "0xD1D9F0", VA = "0x180D1EDF0")]
		public void PEPEIECOOBP(Vector3 IIBJECFMAJC, Quaternion BFEELDCLMGM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class OIGKPICDDDD
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E030", Offset = "0x7C5CC30", VA = "0x187C5E030")]
	public static PositionAndRotation LLNHFPKMEMC(this PositionAndRotation OCLECFPEPDE)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DF10", Offset = "0x7C5CB10", VA = "0x187C5DF10")]
	public static float IGIEDHKEPCF(float LPCHKKFEGJO, Vector2 FABADMMOBPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DFB0", Offset = "0x7C5CBB0", VA = "0x187C5DFB0")]
	public static float IGIEDHKEPCF(float LPCHKKFEGJO, float PNMBBJAACMD, float MKJDLLMDMCK, float LMOAHCJOHNJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DE50", Offset = "0x7C5CA50", VA = "0x187C5DE50")]
	public static float GINBPNPCFOI(float OOHGFGHCOAJ, Vector2 FABADMMOBPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DDA0", Offset = "0x7C5C9A0", VA = "0x187C5DDA0")]
	public static float GINBPNPCFOI(float OOHGFGHCOAJ, float PNMBBJAACMD, float MKJDLLMDMCK, float LMOAHCJOHNJ)
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
		public PPFKBBIJKBH NoseProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x7C54060", Offset = "0x7C52C60", VA = "0x187C54060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
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
		public KMBJPNFNLBA NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C54370", Offset = "0x7C52F70", VA = "0x187C54370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum GOIKDCLLPDK
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
public enum NCHDLFMKIIB
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
public enum FPAJOPAEPNO
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
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct HGJOAKNDMGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Vector2 BPMDGPCDIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Vector2 HPHBBAGNLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector2 JHHMAHPDAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector2 CEBMMAEIFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector2 IFBEAAPOLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector2 BJBEPFDNCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector2 PKLOPGBALCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector2 LGHNNIINJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Vector2 NKBDJCHLPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public Vector2 CPHFHBNFABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Vector2 FNADEFKKDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector2 FMKFMJIOBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector2 BHINIGLLBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector2 FFHCBGEDKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector2 HIHJIBOJGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Vector2 DPDLNIBGNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public float POILAGHFOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public float GHGIBPFAMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float DPGOJAOMLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public float AGLNBDLNAGM;
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
public static class OKPPJBJDNEB
{
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public static readonly int LCFDEDFLOBC;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public static readonly string HHHIPFEAEJJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E180", Offset = "0x7C5CD80", VA = "0x187C5E180")]
	public static EPLCEEHGJGF ANJPIKCNFCF(Transform JCKBODFHJCM, AvatarSkinAssetItem DPKGCJEIJKC, AssetReference ILMILFKJPCG, GameObject GLNOGALFIEO, GameObject HEHJMDIFMIG, SkinnedMeshRenderer NBCCNMHLHOL, AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL, Material NEEILEKOCDH, Material CLPMPCDDCAK, Material BHFOLFEKBGC, Material KFBABCEGCJD, Shader CHJHDPDFOCK, Shader AABENNHBDDJ, Animator DHAIDOLDPLL, Renderer[] IINDDNKBHHG, AvatarConfiguration PMPPDEBFBJJ, AvatarBodyPartShapesManager FAPBKCHKLGH, IReadOnlyDictionary<string, Transform> PLNEMJGEDOO, Transform NKBDMDLBDMP, CIFHCHIGFCF GLKFEKCCCKO)
	{
		return default(EPLCEEHGJGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E370", Offset = "0x7C5CF70", VA = "0x187C5E370")]
	public static MMNFJHLEJHG CMJEEKHPHEA(SkinnedMeshRenderer[] JCKFAFPAEDG, SkinnedMeshRenderer[] DMCGACILMCE, SkinnedMeshRenderer[] LDFEMMBBHGJ, SkinnedMeshRenderer[] LOCFEHFPLDP)
	{
		return default(MMNFJHLEJHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E620", Offset = "0x7C5D220", VA = "0x187C5E620")]
	public static MHLPKNEKDOF MECGHNLKFAI(Transform DBGFABNCELL, Transform JINPABHIKNF, Transform KBMPOKKENGL, Transform LHBNEIJAKIB, Transform CIAMFNBJMND, Transform ELPLEPAIOJK, AvatarConfiguration MGIFPBNOLMM, CIFHCHIGFCF GLKFEKCCCKO)
	{
		return default(MHLPKNEKDOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x28BE660", Offset = "0x28BD260", VA = "0x1828BE660")]
	public static HEILDFICPPP JFPCCIEPJIF(SkinnedMeshRenderer[] POMCHNHBLFC, Material KLNKMOJDMBN)
	{
		return default(HEILDFICPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E590", Offset = "0x7C5D190", VA = "0x187C5E590")]
	public static LMICPILDBNN LPFEENKLDDG(BEKEHOGMLKK KPLCODIIMOK, int JOKDMGBFLHC, Color IAEBGOAMNBL, Color EPBMHNMEKDP, int AAMCADPGPJH, Color FHDDCHMBOBO, Color NLEKFPILEPI, int OJHBLLNEONH)
	{
		return default(LMICPILDBNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E470", Offset = "0x7C5D070", VA = "0x187C5E470")]
	public static EABIGMNFGNA HNHMDJMEODN(BEKEHOGMLKK KPLCODIIMOK, Vector2 CNCLODPNDNP, float ELOGIFPJKDM, float PHDOIFPNIBJ, float LKGELOGGDKI, Vector2 JIABOLHDDAD, float MLLBPEEAHJO, float POILAGHFOKN, float FAHKHHLBGJK, Vector2 IEAOONNIHEF, float HLKKBGIIOOO, float DPGOJAOMLAF, float PHIBMKCEBNM, Vector2 LFCOMNKACDK, float NBBBDECOKBC, float AGLNBDLNAGM, float PAEOCGADOOD)
	{
		return default(EABIGMNFGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E3F0", Offset = "0x7C5CFF0", VA = "0x187C5E3F0")]
	public static IKGGABJJCMA DABJJFFFLOE(Animator DDILOAJJFEN, AHDEEIHKKKF INLJLFAMJPL, AvatarConfiguration PMPPDEBFBJJ, GameObject MKLHDJENGGO, CIFHCHIGFCF GLKFEKCCCKO)
	{
		return default(IKGGABJJCMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E6E0", Offset = "0x7C5D2E0", VA = "0x187C5E6E0")]
	public static ILCGLEGGDGK PNAKODKKMMK(Transform JDKCPOJAKMK, bool BJANKDLLEML)
	{
		return default(ILCGLEGGDGK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class CECDPIIOHKL
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C56690", Offset = "0x7C55290", VA = "0x187C56690")]
	public static CNIBPJLPBFA ICDMHILMDOB(this GOIKDCLLPDK EKIEIGGNBEB)
	{
		return default(CNIBPJLPBFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C566E0", Offset = "0x7C552E0", VA = "0x187C566E0")]
	public static bool OPODDNCKJEE(this GOIKDCLLPDK PIFOOEPOKGK)
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
		public enum GAFFNLKCHJN
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
		public BodySkinnedMeshLODs NICLCEJGMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs EJCIGIADFCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs FENGCNHJHIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs LFNJGNDAKEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7C545E0", Offset = "0x7C531E0", VA = "0x187C545E0")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(GAFFNLKCHJN PBOIINNJFOK, [Optional] DOLBAFHNJDK? HAHIPFJADAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
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
		private sealed class PALENJDKMOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public PALENJDKMOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x7C5E7A0", Offset = "0x7C5D3A0", VA = "0x187C5E7A0")]
			internal bool MNFLMOFIPEI(BoneOrderRemapEntry item)
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
		[Cpp2IlInjected.Address(RVA = "0x7C54760", Offset = "0x7C53360", VA = "0x187C54760")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C54760", Offset = "0x7C53360", VA = "0x187C54760")]
		private void GHAKLLEEJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C547E0", Offset = "0x7C533E0", VA = "0x187C547E0")]
		private void LFDKLMDJMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C54770", Offset = "0x7C53370", VA = "0x187C54770")]
		public byte[] KJIGCEOKFFB(string GAAHKKHPMFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C54930", Offset = "0x7C53530", VA = "0x187C54930")]
		public bool MHMIFMDLLDE(SkinnedMeshBoneOrderData NGGGIIACIKD, AvatarSkinnedMeshBonesController LEADAFFOGGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C553A0", Offset = "0x7C53FA0", VA = "0x187C553A0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class NNOLENAHNAM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct DDPKJNGDKJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Transform[] CAKHFNMIIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public Matrix4x4[] MAEPACMACGB;
	}

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static readonly string MFANFPJANKB;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DC50", Offset = "0x7C5C850", VA = "0x187C5DC50")]
	public static byte[] FMKAFBDPLBO(AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL, SkinnedMeshRenderer DGNBGAOENKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D750", Offset = "0x7C5C350", VA = "0x187C5D750")]
	public static DDPKJNGDKJE? COHAFGLODIA(AvatarSkinnedMeshBoneOrderRemapsData KOGIGHLMGHL, SkinnedMeshRenderer DGNBGAOENKG)
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
		[GHKDIKFNBMM(EBAHNMNBCJP.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string IGOCMEILJNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C55470", Offset = "0x7C54070", VA = "0x187C55470")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C558B0", Offset = "0x7C544B0", VA = "0x187C558B0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C557F0", Offset = "0x7C543F0", VA = "0x187C557F0")]
		private void LFDKLMDJMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C554A0", Offset = "0x7C540A0", VA = "0x187C554A0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C55500", Offset = "0x7C54100", VA = "0x187C55500")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer GJIEBJCNJLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum IEKNNJIHFMK
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
public static class JBAICENBGPO
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C300", Offset = "0x7C5AF00", VA = "0x187C5C300")]
	public static bool MLKNAGEPONG(this IEKNNJIHFMK EGADONEDPAC)
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
		[Cpp2IlInjected.Address(RVA = "0x7C56660", Offset = "0x7C55260", VA = "0x187C56660")]
		public List<BodyShapePropertyData> EHDKOMMAIIJ(CIFHCHIGFCF GLKFEKCCCKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
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
		public AvatarBodyShapeData.IPHFNEHEGNI BodyShapeName;

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
		public IEKNNJIHFMK BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct LMCCLMLIJIC : IEquatable<LMCCLMLIJIC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public string KFJCKFHGCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public Vector3 GKIMFBHMEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public Vector3 OIJOCHEHLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public Vector3 CAFENJPBDIL;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CEB0", Offset = "0x7C5BAB0", VA = "0x187C5CEB0", Slot = "4")]
	public bool Equals(LMCCLMLIJIC GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CFF0", Offset = "0x7C5BBF0", VA = "0x187C5CFF0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D0A0", Offset = "0x7C5BCA0", VA = "0x187C5D0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum NJKKIFEJDKC
{
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class AKKOOIDKLNO
{
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public static readonly AKKOOIDKLNO DIACPKGMELN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JFMCKAHGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA20EC0", Offset = "0xA1FAC0", VA = "0x180A20EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public NJKKIFEJDKC BOKBKKBBHBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA6B430", Offset = "0xA6A030", VA = "0x180A6B430")]
		[CompilerGenerated]
		get
		{
			return default(NJKKIFEJDKC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xAC4340", Offset = "0xAC2F40", VA = "0x180AC4340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public AKKOOIDKLNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x30132C0", Offset = "0x3011EC0", VA = "0x1830132C0")]
	public AKKOOIDKLNO(NJKKIFEJDKC KEGLMDPKKID, int MODEJBKMLCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum AFLDMIJCCDM
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
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
		public AvatarFaceShapeData.LBCIECHIFGF FaceShapeName;

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
		public AFLDMIJCCDM FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B6A0", Offset = "0x7C5A2A0", VA = "0x187C5B6A0")]
		public void DrawPosition(bool AENDFIMJKFK, Transform NMIBCHFJGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B740", Offset = "0x7C5A340", VA = "0x187C5B740")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere CKPENIGENNI, Transform LIPFJJEAFCE, Vector2 DOMCPOKKECE, AnchorParamsRestrictions HICPJJOGLBD, bool LAMNHHGPDPH = false, bool ODLFIOCAOMB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public FitMeshPreviewGizmo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum PPFKBBIJKBH
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
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
		public KMBJPNFNLBA NoseType;

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
		public PPFKBBIJKBH NoseProperty;

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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E7D0", Offset = "0x7C5D3D0", VA = "0x187C5E7D0")]
		public void PFFONJHOKBD(SkinnedMeshRenderer DGNBGAOENKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E970", Offset = "0x7C5D570", VA = "0x187C5E970")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C52F50", Offset = "0x7C51B50", VA = "0x187C52F50")]
		public void KMFGAPKBONM(NJANNEBBMIO FBJNAKADCGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C53430", Offset = "0x7C52030", VA = "0x187C53430")]
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
			[Cpp2IlInjected.Address(RVA = "0xC64BF0", Offset = "0xC637F0", VA = "0x180C64BF0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C56680", Offset = "0x7C55280", VA = "0x187C56680")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A100", Offset = "0x7C58D00", VA = "0x187C5A100")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x7A86550", Offset = "0x7A85150", VA = "0x187A86550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A120", Offset = "0x7C58D20", VA = "0x187C5A120")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xB52110", Offset = "0xB50D10", VA = "0x180B52110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A140", Offset = "0x7C58D40", VA = "0x187C5A140")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A160", Offset = "0x7C58D60", VA = "0x187C5A160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F29D70", Offset = "0x1F28970", VA = "0x181F29D70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A170", Offset = "0x7C58D70", VA = "0x187C5A170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C59CF0", Offset = "0x7C588F0", VA = "0x187C59CF0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7C59FE0", Offset = "0x7C58BE0", VA = "0x187C59FE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C5AC00", Offset = "0x7C59800", VA = "0x187C5AC00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1B33810", Offset = "0x1B32410", VA = "0x181B33810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x165C200", Offset = "0x165AE00", VA = "0x18165C200")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1B33D60", Offset = "0x1B32960", VA = "0x181B33D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A9D0", Offset = "0x7C595D0", VA = "0x187C5A9D0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AB10", Offset = "0x7C59710", VA = "0x187C5AB10")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C5ED60", Offset = "0x7C5D960", VA = "0x187C5ED60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7C5FAC0", Offset = "0x7C5E6C0", VA = "0x187C5FAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private readonly List<PHKGFEHMLBA<Sprite>> _spriteResourceHandles;

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
			[Cpp2IlInjected.Address(RVA = "0xA1FDD0", Offset = "0xA1E9D0", VA = "0x180A1FDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA1FDC0", Offset = "0xA1E9C0", VA = "0x180A1FDC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A920", Offset = "0x7C59520", VA = "0x187C5A920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A990", Offset = "0x7C59590", VA = "0x187C5A990")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A8B0", Offset = "0x7C594B0", VA = "0x187C5A8B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x7C5A900", Offset = "0x7C59500", VA = "0x187C5A900")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1114BC0", Offset = "0x11137C0", VA = "0x181114BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A390", Offset = "0x7C58F90", VA = "0x187C5A390")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A4D0", Offset = "0x7C590D0", VA = "0x187C5A4D0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A400", Offset = "0x7C59000", VA = "0x187C5A400")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A5B0", Offset = "0x7C591B0", VA = "0x187C5A5B0")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A180", Offset = "0x7C58D80", VA = "0x187C5A180")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A6B0", Offset = "0x7C592B0", VA = "0x187C5A6B0")]
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
public static class BJPIPEIEADM
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7C56530", Offset = "0x7C55130", VA = "0x187C56530")]
	public static BEALCFCAMAO CKNCMHCGCKE(this FaceFeatureType PKPCHIEAIOJ, FKBFMJFEIFH HCIFJIKKCEI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class BEKEHOGMLKK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct LGLGDEABJJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public AsyncTaskMethodBuilder<BEKEHOGMLKK> <>t__builder;

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
		private IOPBNOLGHPI.JPGODFCLGMJ <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C550", Offset = "0x7C5B150", VA = "0x187C5C550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CD80", Offset = "0x7C5B980", VA = "0x187C5CD80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private readonly Dictionary<string, int> LDCNIFNGDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool NBIBILPEFCG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public List<Texture2D> MGMADKPFAED
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public SymmetricalFaceFeature GMOGHOOPMNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7C0", Offset = "0xA1E3C0", VA = "0x180A1F7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EyesFaceFeature BKMKBFOFOGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA27D40", Offset = "0xA26940", VA = "0x180A27D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FaceFeature NMDJFELALNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA217E0", Offset = "0xA203E0", VA = "0x180A217E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x7C55ED0", Offset = "0x7C54AD0", VA = "0x187C55ED0")]
	private static void FJPHGHNIJAG(Sprite GDMMNKKLCOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x7C55C70", Offset = "0x7C54870", VA = "0x187C55C70")]
	public static BEKEHOGMLKK CCPFPNGBAID(SymmetricalFaceFeature LEJNGIOKOCI, EyesFaceFeature LNNPCGOMLKP, FaceFeature BNDNCNACPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x7C55F40", Offset = "0x7C54B40", VA = "0x187C55F40")]
	[AsyncStateMachine(typeof(LGLGDEABJJF))]
	public static Task<BEKEHOGMLKK> FLCCCNBAGKI(SymmetricalFaceFeature LEJNGIOKOCI, EyesFaceFeature LNNPCGOMLKP, FaceFeature BNDNCNACPNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x7C56240", Offset = "0x7C54E40", VA = "0x187C56240")]
	private BEKEHOGMLKK(SymmetricalFaceFeature LEJNGIOKOCI, EyesFaceFeature LNNPCGOMLKP, FaceFeature BNDNCNACPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x7C558C0", Offset = "0x7C544C0", VA = "0x187C558C0")]
	private void BCGEEABMNEH(List<Sprite> EECKBKMMENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7C55D00", Offset = "0x7C54900", VA = "0x187C55D00")]
	public bool CLIFJLNFEMF(string JJPFPBDAIAO, [Out] int EMMACFPOKFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C55DF0", Offset = "0x7C549F0", VA = "0x187C55DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7C56080", Offset = "0x7C54C80", VA = "0x187C56080")]
	public bool JICHDGIBAGD(bool AOKACGMIBPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7C56170", Offset = "0x7C54D70", VA = "0x187C56170")]
	public void LGEKNJBHLDG()
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
		private struct NKGHNBLIPJA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public AsyncTaskMethodBuilder<BEKEHOGMLKK> <>t__builder;

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
			private TaskAwaiter<BEKEHOGMLKK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7C5D1E0", Offset = "0x7C5BDE0", VA = "0x187C5D1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7C5D6E0", Offset = "0x7C5C2E0", VA = "0x187C5D6E0", Slot = "5")]
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
		private Dictionary<DOLBAFHNJDK, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private Dictionary<DOLBAFHNJDK, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private Dictionary<DOLBAFHNJDK, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private Dictionary<DOLBAFHNJDK, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private readonly Dictionary<DOLBAFHNJDK, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private BEKEHOGMLKK _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private BEKEHOGMLKK _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B670", Offset = "0x7C5A270", VA = "0x187C5B670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AED0", Offset = "0x7C59AD0", VA = "0x187C5AED0")]
		public BEKEHOGMLKK BNJJMDIFNIC(CIFHCHIGFCF GLKFEKCCCKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B290", Offset = "0x7C59E90", VA = "0x187C5B290")]
		[AsyncStateMachine(typeof(NKGHNBLIPJA))]
		public Task<BEKEHOGMLKK> OIOGEKFJDPH(int? FPOPNIKKOCN, int LNNPCGOMLKP, int BNDNCNACPNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B0E0", Offset = "0x7C59CE0", VA = "0x187C5B0E0")]
		public NoseFaceOption GBLAJLNPDPA(int KNCKEIPBPGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B3C0", Offset = "0x7C59FC0", VA = "0x187C5B3C0")]
		public SelectableFaceOption PCGONFMBDFE(FaceFeatureType PLAKOGIALAM, DOLBAFHNJDK DPAFHHMCBDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AE50", Offset = "0x7C59A50", VA = "0x187C5AE50")]
		public int BIPMANDAGGM(DOLBAFHNJDK DPAFHHMCBDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AC20", Offset = "0x7C59820", VA = "0x187C5AC20")]
		private void AMDIMMPNLKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FBF0", Offset = "0x3A6E7F0", VA = "0x183A6FBF0")]
		private void PIANAHHBHIN<T>(IDictionary<DOLBAFHNJDK, T> NJHNNBNFCIE, IReadOnlyList<T> AAEBKFOGPGD) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B180", Offset = "0x7C59D80", VA = "0x187C5B180")]
		public DOLBAFHNJDK INDJHMALPNG(FaceFeatureType PLAKOGIALAM)
		{
			return default(DOLBAFHNJDK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AF60", Offset = "0x7C59B60", VA = "0x187C5AF60")]
		public DOLBAFHNJDK COMPBCHAKKC(FaceFeatureType PLAKOGIALAM)
		{
			return default(DOLBAFHNJDK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B540", Offset = "0x7C5A140", VA = "0x187C5B540")]
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
			[Cpp2IlInjected.Address(RVA = "0xA7BBF0", Offset = "0xA7A7F0", VA = "0x180A7BBF0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AB10", Offset = "0x7C59710", VA = "0x187C5AB10")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public KMBJPNFNLBA SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xC78550", Offset = "0xC77150", VA = "0x180C78550", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
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
		public DOLBAFHNJDK FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x1FA7070", Offset = "0x1FA5C70", VA = "0x181FA7070")]
			get
			{
				return default(DOLBAFHNJDK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA7B230", Offset = "0xA79E30", VA = "0x180A7B230")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x140DC50", Offset = "0x140C850", VA = "0x18140DC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C52EA0", Offset = "0x7C51AA0", VA = "0x187C52EA0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xC51910", Offset = "0xC50510", VA = "0x180C51910")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C5ECE0", Offset = "0x7C5D8E0", VA = "0x187C5ECE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7044C40", Offset = "0x7043840", VA = "0x187044C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7C5ED20", Offset = "0x7C5D920", VA = "0x187C5ED20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x7044C50", Offset = "0x7043850", VA = "0x187044C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7C5ED00", Offset = "0x7C5D900", VA = "0x187C5ED00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7047FF0", Offset = "0x7046BF0", VA = "0x187047FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x7C5ED40", Offset = "0x7C5D940", VA = "0x187C5ED40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7047FE0", Offset = "0x7046BE0", VA = "0x187047FE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EA00", Offset = "0x7C5D600", VA = "0x187C5EA00", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5EC10", Offset = "0x7C5D810", VA = "0x187C5EC10")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class EHPANCFPHNM
{
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly float KCCIJABFJOG;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly float FCKJNFHCCAB;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly Vector2 BDMEEMLNPFI;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly Vector2 DDMEKINBPCJ;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly Vector2 EMFAEMMCHNA;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly Vector2 NNBMOHANNOB;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly Vector2 NGGKNKNPEOM;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly Vector2 IFJGFNCCEML;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly Vector2 JODFKBKELNO;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly Vector2 KAKIBBCKOFC;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly Vector2 OKDCCNGACCL;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Vector2 GABDDOECDJO;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Vector2 LFGECPEEJOE;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Vector2 OIGOPIFAHEM;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7C57830", Offset = "0x7C56430", VA = "0x187C57830")]
	public static Vector2 GCAJDCCJJDB(FaceFeatureType PKPCHIEAIOJ, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7C57640", Offset = "0x7C56240", VA = "0x187C57640")]
	public static float GBGOMEPMENO(FaceFeatureType PKPCHIEAIOJ, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7C59270", Offset = "0x7C57E70", VA = "0x187C59270")]
	public static void NPJHJEAHGOE(NJANNEBBMIO OIDABOLGGCE, AvatarConfiguration PMPPDEBFBJJ, CIFHCHIGFCF MKDEIHEEGBN, CIFHCHIGFCF FJOLKNNBODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7C57DB0", Offset = "0x7C569B0", VA = "0x187C57DB0")]
	public static float IMFEMMOLMHA(FaceFeatureType PLAKOGIALAM, float NKHFILFCACH, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7C572D0", Offset = "0x7C55ED0", VA = "0x187C572D0")]
	public static float DFPDACAIMAN(FaceFeatureType PLAKOGIALAM, float CBGOOAGMHKM, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7C58880", Offset = "0x7C57480", VA = "0x187C58880")]
	public static float MCOMNANLEKD(FaceFeatureType PLAKOGIALAM, float BFEELDCLMGM, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7C56CE0", Offset = "0x7C558E0", VA = "0x187C56CE0")]
	public static float ADFKIMGBODK(FaceFeatureType PLAKOGIALAM, float OHLKEIOKDNG, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7C57C60", Offset = "0x7C56860", VA = "0x187C57C60")]
	public static float HLIOKCEOLLI(FaceFeatureType PLAKOGIALAM, float NJBOBEIEPMD, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7C57060", Offset = "0x7C55C60", VA = "0x187C57060")]
	public static float BOLHGNBMIBF(FaceFeatureType PLAKOGIALAM, float JOLCCDJKBJA, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7C56F90", Offset = "0x7C55B90", VA = "0x187C56F90")]
	public static Vector2 BFHCDCADNMH(FaceFeatureType PLAKOGIALAM, Vector2 DGMAFGEPDGF, Vector2 BFPDCHOLEFK, Vector2 CAFKMPFIHNL, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7C57E40", Offset = "0x7C56A40", VA = "0x187C57E40")]
	public static Vector2 INHFGBJAFOL(FaceFeatureType PLAKOGIALAM, Vector2 OJBMIFEPHEK, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7C59330", Offset = "0x7C57F30", VA = "0x187C59330")]
	private static Vector2 OGNEADECKMI(FaceFeatureType PLAKOGIALAM, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7C58910", Offset = "0x7C57510", VA = "0x187C58910")]
	private static Vector2 MDBAJKPEGCP(FaceFeatureType PLAKOGIALAM, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7C58F00", Offset = "0x7C57B00", VA = "0x187C58F00")]
	private static Vector2 NFCPBLHOPIP(FaceFeatureType PLAKOGIALAM, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7C59550", Offset = "0x7C58150", VA = "0x187C59550")]
	private static Vector2 POGCDCBOLCC(FaceFeatureType PLAKOGIALAM, Vector2 DGMAFGEPDGF, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7C566F0", Offset = "0x7C552F0", VA = "0x187C566F0")]
	public static Vector2 ABEFPBPJMML(FaceFeatureType PLAKOGIALAM, Vector2 OJBMIFEPHEK, Vector2 BFPDCHOLEFK, Vector2 CAFKMPFIHNL, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C580A0", Offset = "0x7C56CA0", VA = "0x187C580A0")]
	public static float IOBLLCODCCF(FaceFeatureType PLAKOGIALAM, float CBGOOAGMHKM, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C583F0", Offset = "0x7C56FF0", VA = "0x187C583F0")]
	public static float JJBCKMBMGAI(FaceFeatureType PLAKOGIALAM, float BFEELDCLMGM, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7C58490", Offset = "0x7C57090", VA = "0x187C58490")]
	public static float JKPHPGJGNEL(FaceFeatureType PLAKOGIALAM, float OHLKEIOKDNG, CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7C58C80", Offset = "0x7C57880", VA = "0x187C58C80")]
	private static float MKFMMIEJJDO(float PNMBBJAACMD, float LMOAHCJOHNJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7C56B70", Offset = "0x7C55770", VA = "0x187C56B70")]
	private static Vector2 ABHCENBGCIN(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7C56E20", Offset = "0x7C55A20", VA = "0x187C56E20")]
	private static Vector2 ALHIFGDEGMA(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7C57160", Offset = "0x7C55D60", VA = "0x187C57160")]
	private static Vector2 CPFKNJHEEGE(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7C58530", Offset = "0x7C57130", VA = "0x187C58530")]
	private static Vector2 KHDHIKNFKEK(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7C58DD0", Offset = "0x7C579D0", VA = "0x187C58DD0")]
	private static float NCNICOMMJII(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7C570F0", Offset = "0x7C55CF0", VA = "0x187C570F0")]
	private static float COAFLPCEPMN(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7C585E0", Offset = "0x7C571E0", VA = "0x187C585E0")]
	private static float KLLHCEPPPMI(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7C58380", Offset = "0x7C56F80", VA = "0x187C58380")]
	private static float JHJAEAFDIMD(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7C57210", Offset = "0x7C55E10", VA = "0x187C57210")]
	private static Vector2 DECACBGCNEE(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7C57BA0", Offset = "0x7C567A0", VA = "0x187C57BA0")]
	private static Vector2 HAPCOIFBCLO(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7C58E40", Offset = "0x7C57A40", VA = "0x187C58E40")]
	private static Vector2 NEFMOIHGFFP(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7C57410", Offset = "0x7C56010", VA = "0x187C57410")]
	private static Vector2 FAIAANJAAPH(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7C56D70", Offset = "0x7C55970", VA = "0x187C56D70")]
	private static Vector2 AJPGCPLBIFD(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7C57AE0", Offset = "0x7C566E0", VA = "0x187C57AE0")]
	private static Vector2 GIMFDIDMAMF(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7C58BC0", Offset = "0x7C577C0", VA = "0x187C58BC0")]
	private static Vector2 MFGDBHCCHKF(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x7C56ED0", Offset = "0x7C55AD0", VA = "0x187C56ED0")]
	private static Vector2 BAGJMFDNDAE(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7C57360", Offset = "0x7C55F60", VA = "0x187C57360")]
	private static Vector2 DGMHNKFNKEG(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7C58710", Offset = "0x7C57310", VA = "0x187C58710")]
	private static Vector2 LGCJNOLNADI(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7C587C0", Offset = "0x7C573C0", VA = "0x187C587C0")]
	private static Vector2 LHCNBHIDDPN(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C56C20", Offset = "0x7C55820", VA = "0x187C56C20")]
	private static Vector2 ADFEINFNKOD(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7C59490", Offset = "0x7C58090", VA = "0x187C59490")]
	private static Vector2 OOBDLEFBHBH(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7C57580", Offset = "0x7C56180", VA = "0x187C57580")]
	private static Vector2 FOKNJCIHFKK(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7C57CF0", Offset = "0x7C568F0", VA = "0x187C57CF0")]
	private static Vector2 IGJLKFEEMNA(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7C574C0", Offset = "0x7C560C0", VA = "0x187C574C0")]
	private static Vector2 FGLPPBHDKGG(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7C58D10", Offset = "0x7C57910", VA = "0x187C58D10")]
	private static Vector2 MLDFDIAEHMO(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7C591B0", Offset = "0x7C57DB0", VA = "0x187C591B0")]
	private static Vector2 NJJONOHHFJM(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7C58650", Offset = "0x7C57250", VA = "0x187C58650")]
	private static Vector2 LCFMCCJONIJ(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7C582C0", Offset = "0x7C56EC0", VA = "0x187C582C0")]
	private static Vector2 IOFDGDCEJLC(CIFHCHIGFCF GLKFEKCCCKO, AvatarConfiguration MGIFPBNOLMM)
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
