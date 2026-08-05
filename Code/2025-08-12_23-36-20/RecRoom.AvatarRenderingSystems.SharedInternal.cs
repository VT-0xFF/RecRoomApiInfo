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
		[Cpp2IlInjected.Address(RVA = "0x8200080", Offset = "0x81FEE80", VA = "0x188200080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
		public AvatarFaceShapeData.NBPFNGJDNEF FaceShapeName;

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
		public AvatarBodyShapeData.PGBKJOHIBBG BodyShapeName;

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
		public LPJNBIJEEIN BodyProperty;

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
		public OKKHECCBEHE FaceProperty;

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
		public NJAIGHPFLPG NoseProperty;

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
		public PBJKAGHPKMF NoseType;

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
		public LPJNBIJEEIN BodyProperty;

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
		public OKKHECCBEHE FaceProperty;

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
		public NJAIGHPFLPG NoseProperty;

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
		public JEFNLCDPHJN PropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[Flags]
public enum JEFNLCDPHJN
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
		private sealed class AMMOIPAELAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public AMMOIPAELAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8200020", Offset = "0x81FEE20", VA = "0x188200020")]
			internal bool DJCOCPGHOFK(KeyValuePair<string, Transform> bone)
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
		private List<AvatarFaceShapeData.NBPFNGJDNEF> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private List<AvatarBodyShapeData.PGBKJOHIBBG> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Dictionary<LPJNBIJEEIN, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Dictionary<OKKHECCBEHE, List<float>> facePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Dictionary<NJAIGHPFLPG, List<float>> nosePropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly Dictionary<(string, AvatarFaceShapeData.NBPFNGJDNEF), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<(string, AvatarBodyShapeData.PGBKJOHIBBG), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<(string, PBJKAGHPKMF), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Dictionary<(string, LPJNBIJEEIN, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Dictionary<LPJNBIJEEIN, Dictionary<string, JEFNLCDPHJN>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Dictionary<(string, OKKHECCBEHE, float), AvatarBodyPartBoneData> facePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly Dictionary<OKKHECCBEHE, Dictionary<string, JEFNLCDPHJN>> facePropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly Dictionary<(string, NJAIGHPFLPG, float), AvatarBodyPartBoneData> nosePropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Dictionary<NJAIGHPFLPG, Dictionary<string, JEFNLCDPHJN>> nosePropertyBoneInfluenceInfoMapping;

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
		private readonly Dictionary<LPJNBIJEEIN, string[]> bonesToUpdatePerBodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly Dictionary<OKKHECCBEHE, string[]> bonesToUpdatePerFaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Dictionary<NJAIGHPFLPG, string[]> bonesToUpdatePerNoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly Dictionary<string, Dictionary<JEFNLCDPHJN, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8207290", Offset = "0x8206090", VA = "0x188207290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8202F40", Offset = "0x8201D40", VA = "0x188202F40")]
		public void IEHCJBEIMLK(IReadOnlyDictionary<string, Transform> DMBPAMFNILO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8200FD0", Offset = "0x81FFDD0", VA = "0x188200FD0")]
		public void CNOPCAIEOHM(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, AvatarFaceShapeData.NBPFNGJDNEF FKOHDOKFCKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8202B20", Offset = "0x8201920", VA = "0x188202B20")]
		public void HILHEFNLILK(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, PBJKAGHPKMF BDJEBKAJJPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8201560", Offset = "0x8200360", VA = "0x188201560")]
		public void FLOMEJPHLEA(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, AvatarBodyShapeData.PGBKJOHIBBG PNPBMHOHCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82060F0", Offset = "0x8204EF0", VA = "0x1882060F0")]
		public void LEOBLDELGBG(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, IReadOnlyDictionary<string, CFLHAGNENCM> HBFJGJKNFII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8200280", Offset = "0x81FF080", VA = "0x188200280")]
		public IReadOnlyDictionary<string, CFLHAGNENCM> BFNGFJGHDAE(IReadOnlyDictionary<string, Transform> DMBPAMFNILO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8200840", Offset = "0x81FF640", VA = "0x188200840")]
		public Dictionary<string, CFLHAGNENCM> BONKGLEBKKN(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, IReadOnlyDictionary<LPJNBIJEEIN, float> BIMLHIMBABH, IReadOnlyDictionary<string, CFLHAGNENCM> MCFCIIJIJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82014C0", Offset = "0x82002C0", VA = "0x1882014C0")]
		public Dictionary<string, CFLHAGNENCM> FEAHNPMNMGE(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, IReadOnlyDictionary<OKKHECCBEHE, float> AODMIDFHDMO, IReadOnlyDictionary<string, CFLHAGNENCM> MCFCIIJIJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8201340", Offset = "0x8200140", VA = "0x188201340")]
		public Dictionary<string, CFLHAGNENCM> FDMICOHKDNM(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, IReadOnlyDictionary<NJAIGHPFLPG, float> PBGDAAGELIK, IReadOnlyDictionary<string, CFLHAGNENCM> MCFCIIJIJOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x3A9A5E0", Offset = "0x3A993E0", VA = "0x183A9A5E0")]
		private Dictionary<string, CFLHAGNENCM> JFJAIOMIOLN<T>(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, IReadOnlyDictionary<T, float> OFIHCLKBLLG, IReadOnlyDictionary<string, CFLHAGNENCM> DMAPLCNFJPM, Dictionary<T, Dictionary<string, JEFNLCDPHJN>> JEFOGJILOHO, Dictionary<(string, T, float), AvatarBodyPartBoneData> OKMNPOIMEFK, bool OAOIJBGKCHB, bool LJDLNNIJJME, [Optional] float? IJMBINGDJBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8205FF0", Offset = "0x8204DF0", VA = "0x188205FF0")]
		public static (float, float) JJCBLAHACFC(float NDGELBEABLG)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8206510", Offset = "0x8205310", VA = "0x188206510")]
		public float OIIMCLGHJBN(LPJNBIJEEIN GBKLPMDLCID, float IPDHPOJHIPD)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82012D0", Offset = "0x82000D0", VA = "0x1882012D0")]
		public float EGKIEGOHGLF(OKKHECCBEHE GDMCALFNKFD, float IODJOBGPDBL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8200210", Offset = "0x81FF010", VA = "0x188200210")]
		public float AAMEHFKAOIP(NJAIGHPFLPG FHFKIJJNMJA, float GEOBAEACPIB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3A9A4A0", Offset = "0x3A992A0", VA = "0x183A9A4A0")]
		private float IHAHOJBDOAD<T>(T HIGEDKBAGHN, float HGACLCLFMGC, Dictionary<T, List<float>> LFDIKCKJEEI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8202990", Offset = "0x8201790", VA = "0x188202990")]
		private CFLHAGNENCM HDDPLBCLNID(IReadOnlyDictionary<string, Transform> DMBPAMFNILO, string EOIFEFNLELB)
		{
			return default(CFLHAGNENCM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8206570", Offset = "0x8205370", VA = "0x188206570")]
		private float OJCIJBLEMBP(float HGMAIPELJHM, List<float> JIMCHKJFONI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8202920", Offset = "0x8201720", VA = "0x188202920")]
		private Vector3 GOIPNNDCNDM(Transform DAIMEOEHLCC, AvatarBodyPartBoneData LCLPIGMCMOH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8200F70", Offset = "0x81FFD70", VA = "0x188200F70")]
		private Quaternion CMFMJGBBGPF(Transform DAIMEOEHLCC, AvatarBodyPartBoneData LCLPIGMCMOH)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8206080", Offset = "0x8204E80", VA = "0x188206080")]
		private Vector3 LCFIOHCCCFD(Transform DAIMEOEHLCC, AvatarBodyPartBoneData LCLPIGMCMOH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8201860", Offset = "0x8200660", VA = "0x188201860")]
		private void FOGOIGJNLNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x734EEF0", Offset = "0x734DCF0", VA = "0x18734EEF0")]
		public bool OMLIILDFBPO(JEFNLCDPHJN FKCELBLOFMH, JEFNLCDPHJN KPNCFKEEMEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8205010", Offset = "0x8203E10", VA = "0x188205010")]
		private CFLHAGNENCM IHHCMKFCOHN(JEFNLCDPHJN PNMFOJKEMMA, CFLHAGNENCM DAIMEOEHLCC, AvatarBodyPartBoneData LCLPIGMCMOH)
		{
			return default(CFLHAGNENCM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82008E0", Offset = "0x81FF6E0", VA = "0x1882008E0")]
		public Dictionary<string, CFLHAGNENCM> CBDCNNPFDAN(Dictionary<string, CFLHAGNENCM> OKKICAHFDMG, bool OAOIJBGKCHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8200670", Offset = "0x81FF470", VA = "0x188200670")]
		private void BONBIIGAFFB(Transform DAIMEOEHLCC, AvatarBodyPartBoneData LCLPIGMCMOH, bool NLDDJOGACNB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82068E0", Offset = "0x82056E0", VA = "0x1882068E0")]
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
		public LPJNBIJEEIN BodyProperty;

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
		[Cpp2IlInjected.Address(RVA = "0x8207390", Offset = "0x8206190", VA = "0x188207390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public enum PGBKJOHIBBG
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
		public PGBKJOHIBBG blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
		private AvatarBodyShapeData.PGBKJOHIBBG blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LCJKMECGKBD BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x20F1D40", Offset = "0x20F0B40", VA = "0x1820F1D40")]
			get
			{
				return default(LCJKMECGKBD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.PGBKJOHIBBG BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
			get
			{
				return default(AvatarBodyShapeData.PGBKJOHIBBG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8207E20", Offset = "0x8206C20", VA = "0x188207E20")]
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
		public AvatarBodyShapeData.PGBKJOHIBBG BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82076A0", Offset = "0x82064A0", VA = "0x1882076A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
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
		private readonly Dictionary<LCJKMECGKBD, AvatarBodyShape> JCGIFDCABFM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8207910", Offset = "0x8206710", VA = "0x188207910")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8207C30", Offset = "0x8206A30", VA = "0x188207C30")]
		public AvatarBodyShape Find(LCJKMECGKBD JJCCIOLJHCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8207D30", Offset = "0x8206B30", VA = "0x188207D30")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8207CF0", Offset = "0x8206AF0", VA = "0x188207CF0")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8207D70", Offset = "0x8206B70", VA = "0x188207D70")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MDDPEAKDNMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Transform[] GNFOMDCPKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Dictionary<string, Transform> NOIFONAFFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Dictionary<Transform, Transform> PMPPAFBGIGO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> BDILFIBEOLG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] BOBJCILHHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA93B70", Offset = "0xA92970", VA = "0x180A93B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8212D50", Offset = "0x8211B50", VA = "0x188212D50")]
	public void KFBDMKKMDBF(Transform HGODMFJEECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x82128D0", Offset = "0x82116D0", VA = "0x1882128D0")]
	public Transform FLFPPIOKFCK(Transform OGFDNIHGLAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82129B0", Offset = "0x82117B0", VA = "0x1882129B0")]
	public void IKHCGOGPCDI(SkinnedMeshRenderer DMNFKIDEEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8212BF0", Offset = "0x82119F0", VA = "0x188212BF0")]
	private static void JAGAPEGHNJF(Transform MMENCBNBOBJ, List<Transform> ICNOAEFAAMM, Dictionary<string, Transform> NHJMKBAOFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8212E30", Offset = "0x8211C30", VA = "0x188212E30")]
	public MDDPEAKDNMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FMMCEONPFDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool GKCIJOFJBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public bool EAECMMGHLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool FBJBPCENCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool KFIAIOCBOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NJKDBAMDGPL? LLAFFDILBDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public BCIIDHEJBAB.MMBHHGOHKAA JONOKDJAJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public HairData PPNBBHDGAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public AdditionalHatData EJJKNMGCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public bool JADGDJFLGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public bool CDFMEFIGLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public bool KNLCKECHAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x43")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool DHPNOLPGGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public IList<GADJBANEMPG> KJLJOMHCFLC;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public FMMCEONPFDK()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Min/Max rotation angle for your eyebrows.")]
		public Vector2 EyebrowsRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Min/Max aspect for your eyebrows.")]
		public Vector2 EyebrowAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Min/Max rotation angle for your eyes.")]
		public Vector2 EyeRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Min/Max aspect for your eyes.")]
		public Vector2 EyeAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Min/Max rotation angle for your mouth.")]
		public Vector2 MouthRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("Min/Max aspect for your mouth.")]
		public Vector2 MouthAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Min/Max rotation angle for your nose.")]
		public Vector2 NoseRotationRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("Min/Max aspect for your nose.")]
		public Vector2 NoseAspectRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[Tooltip("Min uv for eyes")]
		public Vector2 EyeLimitsMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Tooltip("Max uv for eyes")]
		public Vector2 EyeLimitsMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[Header("Hand Animation")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[Header("Body Shapes")]
		public BodyShapeConfiguration BodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[Header("Face Shapes")]
		public FaceShapeConfiguration FaceShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[Header("Nose Shapes")]
		public NoseShapeConfiguration NoseShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[Header("Data Migration Managers")]
		public AvatarDataRangeMigrationsManager AvatarDataRangeMigrationsManager;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8207EB0", Offset = "0x8206CB0", VA = "0x188207EB0")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HGIEHEPCDPB
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	NoseScale_FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	NoseScale_ModernBean,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	NoseVerticalPosition_FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	NoseVerticalPosition_ModernBean,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	HeadScale_FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	HeadScale_ModernBean
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct RangeMigration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public HGIEHEPCDPB RangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Vector2 Range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public DFPPDPOHHLA Version;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AvatarDataRangeMigrationsManager : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public List<RangeMigration> RangeMigrations;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public List<RangeMigration> AllRangeMigrations
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
		public AvatarDataRangeMigrationsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class GHMAKHMAGCH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static JHKIFIDEDCL MNOKHGLMEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82113F0", Offset = "0x82101F0", VA = "0x1882113F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static NODDIPDIFHA NKIAJPLFPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8211450", Offset = "0x8210250", VA = "0x188211450")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JKKGEALMIHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public Transform DCLCGNOGOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public AvatarSkinAssetItem PIHCDNFKECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public AssetReference NGBDGCPKCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public AssetReference LHIGKFNAANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public AssetReference IJJKLBEGBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public AssetReference ICJOIAFAEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public GameObject CDLBJAFODIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public GameObject MOJJOLLECJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public GameObject HOIALPEGKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public SkinnedMeshRenderer AEHANKJLGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public AvatarSkinnedMeshBoneOrderRemapsData DKMOFGEANPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Material KDGJKLDKOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Material ANJHODDAAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Material IDHPJGKACFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public Material BBADBBLJBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public Material LDAGBOCFGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public Shader CKNDLBDEJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Shader ECDKJFHLAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public Animator KAKPDKMJBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public Renderer[] BNDBHFNAGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public AvatarConfiguration FDAIGEAFLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public AvatarBodyPartShapesManager GJPHAJLEBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public IReadOnlyDictionary<string, Transform> DCALHAFNCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Transform NOABMLNBENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public JLFDMKNKLIE MMCOGLIKBED;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DCMBGIPAEDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public SkinnedMeshRenderer[] HAHLNMLEDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public SkinnedMeshRenderer[] HFJFJLLNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public SkinnedMeshRenderer[] MBKLCMIEJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public SkinnedMeshRenderer[] IDPIJHJCFAE;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct GOGGFHKAIAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Transform EECAPELGHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Transform NFBEJDOFKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public Transform OLLMPPCKCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public Transform MLFEGGNMJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Transform LMKIDGLGFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform MJDMCKAIAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public AvatarConfiguration FDAIGEAFLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public JLFDMKNKLIE MMCOGLIKBED;
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct OCJDGMJKNPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public SkinnedMeshRenderer[] NFIMKKHLAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Material LOFAKJDIECF;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public struct ECOBKGOJIDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public GNPHFACIKNJ CBEFJNBBEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int INFJNDKFHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Color OBAPGPMLLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Color OPHBAEIKDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int MOOFDLOINPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Color OFFIIMJIBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Color NGKAMDADEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int IKGCFHNPOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public float BKMBIDEHBAA;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct AIOPPJOAMKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public GNPHFACIKNJ CBEFJNBBEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector2 EOMMGBIJMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float BFICIIEGICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public float IMHKMKIPNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public float NCBEMGOGDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector2 OKEGEMFPNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public float CCPMCOHJJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public float FKLDMDBJBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public float NALGGGOAPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Vector2 JIGIADIEMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public float PLNPALKEHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public float NLHDAHMDDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public float IGEJIPPMMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public Vector2 GIHCHCAPMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public float BJGHEJKONEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float BKMBIDEHBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float ANFIAEPHIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public bool KLAKOMBMMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public bool OOIHCICHNAK;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarFacePropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public OKKHECCBEHE FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public float FacePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8208500", Offset = "0x8207300", VA = "0x188208500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AvatarFacePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum NBPFNGJDNEF
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public NBPFNGJDNEF blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[HideInInspector]
		[Obsolete("Use FaceShapeId instead!")]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private AvatarFaceShapeData.NBPFNGJDNEF blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public INBBLDDKEIN FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x20F1D40", Offset = "0x20F0B40", VA = "0x1820F1D40")]
			get
			{
				return default(INBBLDDKEIN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public AvatarFaceShapeData.NBPFNGJDNEF BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xB16A90", Offset = "0xB15890", VA = "0x180B16A90")]
			get
			{
				return default(AvatarFaceShapeData.NBPFNGJDNEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8208F90", Offset = "0x8207D90", VA = "0x188208F90", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8208FF0", Offset = "0x8207DF0", VA = "0x188208FF0")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AvatarFaceShapeData.NBPFNGJDNEF FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8208810", Offset = "0x8207610", VA = "0x188208810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly Dictionary<INBBLDDKEIN, AvatarFaceShape> JCGIFDCABFM;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8208A80", Offset = "0x8207880", VA = "0x188208A80")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8208DA0", Offset = "0x8207BA0", VA = "0x188208DA0")]
		public AvatarFaceShape Find(INBBLDDKEIN ONFDJDHHMCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8208EA0", Offset = "0x8207CA0", VA = "0x188208EA0")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8208E60", Offset = "0x8207C60", VA = "0x188208E60")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8208EE0", Offset = "0x8207CE0", VA = "0x188208EE0")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8209640", Offset = "0x8208440", VA = "0x188209640")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HDHJBPNLPKA HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x20F1D40", Offset = "0x20F0B40", VA = "0x1820F1D40")]
			get
			{
				return default(HDHJBPNLPKA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA98B60", Offset = "0xA97960", VA = "0x180A98B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xD913B0", Offset = "0xD901B0", VA = "0x180D913B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xDACDA0", Offset = "0xDABBA0", VA = "0x180DACDA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8209650", Offset = "0x8208450", VA = "0x188209650")]
		public Texture2D ECMMLGHLGAO(HairPatternStyle PKBJDJDCHJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8209810", Offset = "0x8208610", VA = "0x188209810", Slot = "0")]
		public override bool Equals(object ALGAKMGCCLO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82097A0", Offset = "0x82085A0", VA = "0x1882097A0", Slot = "4")]
		public bool Equals(AvatarHairPattern FGAEAFBDBPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8209980", Offset = "0x8208780", VA = "0x188209980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82098F0", Offset = "0x82086F0", VA = "0x1882098F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x82098C0", Offset = "0x82086C0", VA = "0x1882098C0")]
		public static bool GFAFFKCBFKA(AvatarHairPattern CHAEOFDBIAH, AvatarHairPattern EBEGEKLHGJL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8209900", Offset = "0x8208700", VA = "0x188209900")]
		public static bool IKIADGFKNFC(AvatarHairPattern CHAEOFDBIAH, AvatarHairPattern EBEGEKLHGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x82099C0", Offset = "0x82087C0", VA = "0x1882099C0")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum NCBHKEPILOG
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Idle,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Invisible,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Pointing,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	TPose,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	ThumbUp,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	HandShake,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Grabbing,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	NumStates
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Flags]
public enum INJFKIDICAL
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ThumbUp = 1,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	Pointing = 2,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	HandShake = 4
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct DBIIODGJHIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	public Animator OBNNGHEGONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public ABAOCJDIGCP JFBPCINHLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public AvatarConfiguration FDAIGEAFLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public GameObject FDDEDEOMKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public JLFDMKNKLIE MMCOGLIKBED;
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct BNHOFFIMOIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Transform NLGHGKPGPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public bool PGMPFCFEFPI;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8209AD0", Offset = "0x82088D0", VA = "0x188209AD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class GADJBANEMPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public string LBDOKALIJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public OutfitType NLALDDIBAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public PGMODLDJKOM BICAFJOGBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public BCIIDHEJBAB.MMBHHGOHKAA IBHIEAMGMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool JEHLMIOHCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public bool GKDGEGNLGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public bool FBOJMPMMLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Color? PAAFFIJOBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public bool BPMFJOOLECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Color? OJMDEANPEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public bool BAJDLCLLHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public bool BPNDJINMIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public bool BMGFBLPNHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public Transform GDBCLIHLLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public Vector2? PBEBCNFMKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public FitMeshHemisphere IJDAOEJHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public AssetReference GCLGDECKKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public AssetReference KKBPJIKMAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public AssetReference[] MPCGPEKEDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public GADJBANEMPG IPEBCCPPIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public bool AHGCJJNDMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public bool JDELHDHKJGF;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public string ONEJLDMHNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x820E100", Offset = "0x820CF00", VA = "0x18820E100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x820E100", Offset = "0x820CF00", VA = "0x18820E100", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x820E1B0", Offset = "0x820CFB0", VA = "0x18820E1B0")]
	public GADJBANEMPG()
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
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private IEEPKIHFMCL? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public NGBEPHHOLNP CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x820A060", Offset = "0x8208E60", VA = "0x18820A060")]
			get
			{
				return default(NGBEPHHOLNP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IEEPKIHFMCL MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x820A090", Offset = "0x8208E90", VA = "0x18820A090")]
			get
			{
				return default(IEEPKIHFMCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA931C0", Offset = "0xA91FC0", VA = "0x180A931C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8209D10", Offset = "0x8208B10", VA = "0x188209D10")]
		public Material[] JKGFIOAJAIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8209DF0", Offset = "0x8208BF0", VA = "0x188209DF0")]
		public static void ODDGGCFKFOM(AvatarItemMaterial BBFBFOIBAHL, Material GKIFPALLDIK, int IDNAPJMNGPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8209B60", Offset = "0x8208960", VA = "0x188209B60")]
		private static bool DBOMGMBGODB(AvatarItemMaterial BBFBFOIBAHL, int IDNAPJMNGPO, [Out] Material FNGJLMAPJMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8209FE0", Offset = "0x8208DE0", VA = "0x188209FE0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NFFHKHDDAGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public SkinnedMeshRenderer ANEIFJIMHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private Material[] CCHANOFABMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private byte[] GEHGMBLIJMH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public Mesh HHFNFGLOOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x82131D0", Offset = "0x8211FD0", VA = "0x1882131D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public Material[] KOAMJOLJAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public byte[] AJHPJOCDNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82131F0", Offset = "0x8211FF0", VA = "0x1882131F0")]
	public NFFHKHDDAGJ(SkinnedMeshRenderer MKKELNAFDKN, AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN, Material[] FGMEALAJLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8213030", Offset = "0x8211E30", VA = "0x188213030")]
	public static NFFHKHDDAGJ GIGBNDAGNJF(Renderer NNEJGKAIJNN, AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN, Material[] FGMEALAJLOJ)
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
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x17021C0", Offset = "0x1700FC0", VA = "0x1817021C0")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xDEB1B0", Offset = "0xDE9FB0", VA = "0x180DEB1B0")]
		public void BNFJAIPBEBA(Vector3 FLAPAOJCDCM, Quaternion GKEKGHNHKDP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class EGHNIHOIGEF
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x820BDB0", Offset = "0x820ABB0", VA = "0x18820BDB0")]
	public static PositionAndRotation IDPLGOHAONM(this PositionAndRotation LHMKMDKLJAL)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x820BF80", Offset = "0x820AD80", VA = "0x18820BF80")]
	public static float OKAEAMAANCH(float DDCPKPIHIOM, Vector2 ADADIDNPKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x820BF00", Offset = "0x820AD00", VA = "0x18820BF00")]
	public static float OKAEAMAANCH(float DDCPKPIHIOM, float OLBFNPPONEB, float BOPNBJFLGMA, float ANDCPDPHMGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x820C0D0", Offset = "0x820AED0", VA = "0x18820C0D0")]
	public static float PPNJEBAACPG(float HGMAIPELJHM, Vector2 ADADIDNPKBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x820C020", Offset = "0x820AE20", VA = "0x18820C020")]
	public static float PPNJEBAACPG(float HGMAIPELJHM, float OLBFNPPONEB, float BOPNBJFLGMA, float ANDCPDPHMGN)
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
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public NJAIGHPFLPG NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float NosePropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x820A150", Offset = "0x8208F50", VA = "0x18820A150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AvatarNosePropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public PBJKAGHPKMF NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x820A460", Offset = "0x8209260", VA = "0x18820A460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public enum JMEMMAAMOCG
{
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	GiveTake = 4,
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum CFOIPNKKFKM
{
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	IdleSwayAimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	IdleSwayMeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	IdleSwayLightItem,
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	IdleSwayHeavyItem,
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	IdleSwayAimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	FastAction,
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	NumTypes
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public enum JDDEJEECIBC
{
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	PotatoAvatar,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	FullOutfitAvatar
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct EGBJPJADNLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector2 PKPDDOPDGAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector2 PGGPLMCENBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public Vector2 OCBFCKCBFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public Vector2 MMGHMBHLALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public Vector2 COLCLHNKNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public Vector2 HHMEMJHOBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector2 JIEDMPFOIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector2 OLMCIJOHACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector2 LGAAFDMFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public Vector2 DDDLELPLNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public Vector2 ALAKEEDIDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public Vector2 BPHADGEBCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public Vector2 FHEDAPJMNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public Vector2 AEDIJPAAFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public Vector2 OLMOJECHIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public Vector2 AGNGDLDANOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public float PHMIIPKLEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public float JFKMKEGFKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public float MHAFGFKINMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public float NNMIMJIBDBJ;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AIICJJCKEAM
{
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static readonly int DCHAGHENIJH;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public static readonly string FNCECCMHHKH;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x81FFB90", Offset = "0x81FE990", VA = "0x1881FFB90")]
	public static JKKGEALMIHG NAGPIBJPNAN(Transform HEBFKCGPBEA, AvatarSkinAssetItem IHGALNJLFJC, AssetReference INKAANKNIKB, AssetReference PNGDJHDBINH, AssetReference JPOIKKBKIFJ, AssetReference GNKJKHDELHH, GameObject IGBPHMLICDP, GameObject BDJKJMLADNF, GameObject DFOAEFNAOFB, SkinnedMeshRenderer CNPJJGOBDIC, AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN, Material MOPKMFHFFOD, Material BLCCHDKGADL, Material KKNKGMKIFAF, Material CECPHEBKPJK, Material LKDCCOIGFNA, Shader PNABAJHIAHL, Shader AGPGJIACCNK, Animator PPIKNFJLBKM, Renderer[] NEGJHONHCDB, AvatarConfiguration LPDDEHLPANK, AvatarBodyPartShapesManager AAFHAFFFKFA, IReadOnlyDictionary<string, Transform> DMBPAMFNILO, Transform ALMLOGOGAAH, JLFDMKNKLIE FMEDCNPIHLH)
	{
		return default(JKKGEALMIHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x81FF990", Offset = "0x81FE790", VA = "0x1881FF990")]
	public static DCMBGIPAEDP AACEPAKMMGG(SkinnedMeshRenderer[] EFPLPBPJNLF, SkinnedMeshRenderer[] AMEOGICMBAG, SkinnedMeshRenderer[] BLJKAJNCPLJ, SkinnedMeshRenderer[] JDKKNEPDCFC)
	{
		return default(DCMBGIPAEDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x81FFAD0", Offset = "0x81FE8D0", VA = "0x1881FFAD0")]
	public static GOGGFHKAIAA KLPEGKJCKIC(Transform NBHDHOBFFAC, Transform EOJCDKEJOGC, Transform OOBAHOBIAHF, Transform DKCPOIFKPMN, Transform KEAMABDBGMA, Transform LIMANGPBPBP, AvatarConfiguration NGGDLMFKPOA, JLFDMKNKLIE FMEDCNPIHLH)
	{
		return default(GOGGFHKAIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x2A5F020", Offset = "0x2A5DE20", VA = "0x182A5F020")]
	public static OCJDGMJKNPL GPALNAJEENI(SkinnedMeshRenderer[] ICACLHJJOLI, Material FCFLIFBHKJL)
	{
		return default(OCJDGMJKNPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x81FFDF0", Offset = "0x81FEBF0", VA = "0x1881FFDF0")]
	public static ECOBKGOJIDF PBMMBNONNCD(GNPHFACIKNJ LKNDFBHHDKG, int MEPLLFFLGBL, Color OMBABBHOEIC, Color ABHINPEFODM, int DLMAPMNABDN, Color OFHHIKNHEGJ, Color KEIOCCNGIPJ, int POJHBHEHFFB)
	{
		return default(ECOBKGOJIDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x81FFE80", Offset = "0x81FEC80", VA = "0x1881FFE80")]
	public static AIOPPJOAMKI PBPEFBCJFAM(GNPHFACIKNJ LKNDFBHHDKG, Vector2 DNHEKGJBNHN, float ECKFLENCFAP, float DGHHEHAGDCK, float NKPPBKPMLNH, Vector2 NPIMFHFAMHK, float AELPAOMGPCM, float PHMIIPKLEPF, float ILHIECDKHEB, Vector2 NDGELBEABLG, float KOFCFOMGPFF, float MHAFGFKINMK, float HDCNLPBGKHJ, Vector2 CANCIHPHEGO, float IHDEJKBBIDB, float NNMIMJIBDBJ, float ECIDGMLDJLN)
	{
		return default(AIOPPJOAMKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x81FFA10", Offset = "0x81FE810", VA = "0x1881FFA10")]
	public static DBIIODGJHIP EACJBIGDFJH(Animator PIDHJDJCIGI, ABAOCJDIGCP ELLALDEOMFP, AvatarConfiguration LPDDEHLPANK, GameObject DPLNEPNECAP, JLFDMKNKLIE FMEDCNPIHLH)
	{
		return default(DBIIODGJHIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x81FFA90", Offset = "0x81FE890", VA = "0x1881FFA90")]
	public static BNHOFFIMOIG GIOMLDIPGCN(Transform JCIHNHBLABD, bool OMJFOHAJGLP)
	{
		return default(BNHOFFIMOIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class JIPMMHACPKK
{
	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8212850", Offset = "0x8211650", VA = "0x188212850")]
	public static NCBHKEPILOG HBEAMPALGIJ(this JMEMMAAMOCG FCDEKJEHGHA)
	{
		return default(NCBHKEPILOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8212840", Offset = "0x8211640", VA = "0x188212840")]
	public static bool COGHBFLFHPG(this JMEMMAAMOCG EKDFJFFANKA)
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
		public enum ONGODKLFOLL
		{
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			FaceSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			TorsoValidationMesh,
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			TorsoModestyMesh,
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			LegsModestyMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public BodySkinnedMeshLODs MAJCFMJOBID
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs DDILOGBKMPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BodySkinnedMeshLODs ILOHLEOACAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public BodySkinnedMeshLODs CLHAAENENEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x820A6D0", Offset = "0x82094D0", VA = "0x18820A6D0")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(ONGODKLFOLL MMHIJGEMDKI, [Optional] NJKDBAMDGPL? EELGNKMNPML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class KFLJHEJCFHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
			public KFLJHEJCFHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x82128A0", Offset = "0x82116A0", VA = "0x1882128A0")]
			internal bool FIDOALOJJMN(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x820A870", Offset = "0x8209670", VA = "0x18820A870")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x820A870", Offset = "0x8209670", VA = "0x18820A870")]
		private void APNJBEAPCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x820B300", Offset = "0x820A100", VA = "0x18820B300")]
		private void OPKPDOIHOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x820B290", Offset = "0x820A090", VA = "0x18820B290")]
		public byte[] NGIOMPFMKGE(string BPLOEIFGFPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x820A880", Offset = "0x8209680", VA = "0x18820A880")]
		public bool KOIDGMEBKHH(SkinnedMeshBoneOrderData KNLNKJDLLPC, AvatarSkinnedMeshBonesController INKANCDEDOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x820B4B0", Offset = "0x820A2B0", VA = "0x18820B4B0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public static class GNDFCGALGBP
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct KMKPBJCPLFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public Transform[] BOBJCILHHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public Matrix4x4[] CLFHCEJCOHD;
	}

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static readonly string JAEDFDFKPIN;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8211580", Offset = "0x8210380", VA = "0x188211580")]
	public static byte[] KAFKMLHKOKF(AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN, SkinnedMeshRenderer DMNFKIDEEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8211670", Offset = "0x8210470", VA = "0x188211670")]
	public static KMKPBJCPLFH? NBINJHGNCBG(AvatarSkinnedMeshBoneOrderRemapsData DBIPCOFOJLN, SkinnedMeshRenderer DMNFKIDEEEC)
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
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		[LAEBPIHCEIF(FBMDOBLPJCI.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string HAIGCNLDBGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x820B580", Offset = "0x820A380", VA = "0x18820B580")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x820B9C0", Offset = "0x820A7C0", VA = "0x18820B9C0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x820B900", Offset = "0x820A700", VA = "0x18820B900")]
		private void OPKPDOIHOAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x820B5B0", Offset = "0x820A3B0", VA = "0x18820B5B0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x820B610", Offset = "0x820A410", VA = "0x18820B610")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer NNEJGKAIJNN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public enum LPJNBIJEEIN
{
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	BicepWidth,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ForearmWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	ChestSize,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	ChestOut,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	WaistSize,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	HipWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	NeckLength,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	NeckThickness,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	ThighWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	CalfWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	FootWidth,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	FootSize,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	ShoulderWidth,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	BellyOut
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class AIHDIADMLFF
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x81FF930", Offset = "0x81FE730", VA = "0x1881FF930")]
	public static bool NLOJAHDHDIP(this LPJNBIJEEIN GBKLPMDLCID)
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
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		[FormerlySerializedAs("BodyShapePropertyData")]
		private List<BodyShapePropertyData> FullBodyShapePropertyData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private List<BodyShapePropertyData> ModernBeanShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x820B9D0", Offset = "0x820A7D0", VA = "0x18820B9D0")]
		public List<BodyShapePropertyData> OMDIHNGFJIE(JLFDMKNKLIE FMEDCNPIHLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
		public BodyShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct BodyShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public AvatarBodyShapeData.PGBKJOHIBBG BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public List<BodyPropertySliderData> BodyPropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public struct BodyPropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public LPJNBIJEEIN BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public struct CFLHAGNENCM : IEquatable<CFLHAGNENCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public string AEFEFBCHGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public Vector3 FEDOCAEMCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public Vector3 CNALNEHFIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public Vector3 FFPBKDOGKLE;

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x820BA00", Offset = "0x820A800", VA = "0x18820BA00", Slot = "4")]
	public bool Equals(CFLHAGNENCM FGAEAFBDBPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x820BB40", Offset = "0x820A940", VA = "0x18820BB40", Slot = "0")]
	public override bool Equals(object ALGAKMGCCLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x820BBF0", Offset = "0x820A9F0", VA = "0x18820BBF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public enum MLKOMCFKCFK
{
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class CJPLKIFIKIH
{
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public static readonly CJPLKIFIKIH HANIMDCJEMB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int LEOBNGLBDOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public MLKOMCFKCFK JJOEILGKDON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10")]
		[CompilerGenerated]
		get
		{
			return default(MLKOMCFKCFK);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public CJPLKIFIKIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x320F9D0", Offset = "0x320E7D0", VA = "0x18320F9D0")]
	public CJPLKIFIKIH(MLKOMCFKCFK KJLMJGOOKJM, int FCBELBPAEPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public enum OKKHECCBEHE
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	CheekPuff,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	JawWidth,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	JawInOut,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	ChinWidth,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	ChinSize,
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	EarSize,
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	EarAngle,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	HeadStretch
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class FaceShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private List<FaceShapePropertyData> FaceShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public List<FaceShapePropertyData> AllFaceShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
		public FaceShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public struct FaceShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public AvatarFaceShapeData.NBPFNGJDNEF FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public List<FacePropertySliderData> FacePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct FacePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public OKKHECCBEHE FaceProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x820DB20", Offset = "0x820C920", VA = "0x18820DB20")]
		public void DrawPosition(bool HEPPDGLDFNF, Transform DNNOOFELIOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x820DBC0", Offset = "0x820C9C0", VA = "0x18820DBC0")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere OPNLMLNDBBG, Transform PJGOIMBEKPK, Vector2 BFFFFCECEKI, AnchorParamsRestrictions GFNFJIBFLIK, bool BKCIMAJLHHE = false, bool JDLCJFFIDJE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA969E0", Offset = "0xA957E0", VA = "0x180A969E0")]
		public FitMeshPreviewGizmo()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum NJAIGHPFLPG
{
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	NoseWidth,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	NoseHeight,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	NoseLength,
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	NoseAngle,
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	NoseBulge,
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	NosePinchFlair,
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	NoseSneer,
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	NoseTipScale,
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	NoseScale
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class NoseShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private List<NoseShapePropertyData> NoseShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public List<NoseShapePropertyData> AllNoseShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
		public NoseShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct NoseShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public PBJKAGHPKMF NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public List<NosePropertySliderData> NosePropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct NosePropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public NJAIGHPFLPG NoseProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public float SliderValue;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8214210", Offset = "0x8213010", VA = "0x188214210")]
		public void HLOFKJDPABE(SkinnedMeshRenderer DMNFKIDEEEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x82143B0", Offset = "0x82131B0", VA = "0x1882143B0")]
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
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[Header("Remapping Eye Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8209040", Offset = "0x8207E40", VA = "0x188209040")]
		public void LAJCFHFECFB(KCANPOPNEIC NNAIEBPJABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8209520", Offset = "0x8208320", VA = "0x188209520")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1C340", Offset = "0xD1B140", VA = "0x180D1C340", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x820B9F0", Offset = "0x820A7F0", VA = "0x18820B9F0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public Vector2 LimitsUVScale;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA96A00", Offset = "0xA95800", VA = "0x180A96A00", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x820C5A0", Offset = "0x820B3A0", VA = "0x18820C5A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x80132B0", Offset = "0x80120B0", VA = "0x1880132B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x820C5C0", Offset = "0x820B3C0", VA = "0x18820C5C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xC00330", Offset = "0xBFF130", VA = "0x180C00330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x820C5E0", Offset = "0x820B3E0", VA = "0x18820C5E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x820C600", Offset = "0x820B400", VA = "0x18820C600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x20A3A10", Offset = "0x20A2810", VA = "0x1820A3A10")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x820C610", Offset = "0x820B410", VA = "0x18820C610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x820C190", Offset = "0x820AF90", VA = "0x18820C190", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x820C480", Offset = "0x820B280", VA = "0x18820C480")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x29EE350", Offset = "0x29ED150", VA = "0x1829EE350")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1C99F50", Offset = "0x1C98D50", VA = "0x181C99F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x17C6380", Offset = "0x17C5180", VA = "0x1817C6380")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C9BEA0", Offset = "0x1C9ACA0", VA = "0x181C9BEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x820CE70", Offset = "0x820BC70", VA = "0x18820CE70", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x820CFB0", Offset = "0x820BDB0", VA = "0x18820CFB0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x82147A0", Offset = "0x82135A0", VA = "0x1882147A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x8215430", Offset = "0x8214230", VA = "0x188215430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private readonly List<HNDICJJKNNH<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xA98240", Offset = "0xA97040", VA = "0x180A98240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xA98250", Offset = "0xA97050", VA = "0x180A98250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x820CDC0", Offset = "0x820BBC0", VA = "0x18820CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x820CE30", Offset = "0x820BC30", VA = "0x18820CE30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x820CD50", Offset = "0x820BB50", VA = "0x18820CD50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x820CDA0", Offset = "0x820BBA0", VA = "0x18820CDA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x2A099C0", Offset = "0x2A087C0", VA = "0x182A099C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x820C830", Offset = "0x820B630", VA = "0x18820C830")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x820C970", Offset = "0x820B770", VA = "0x18820C970", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x820C8A0", Offset = "0x820B6A0", VA = "0x18820C8A0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x820CA50", Offset = "0x820B850", VA = "0x18820CA50")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x820C620", Offset = "0x820B420", VA = "0x18820C620")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x820CB50", Offset = "0x820B950", VA = "0x18820CB50")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class MHPMKALNGLI
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8212F00", Offset = "0x8211D00", VA = "0x188212F00")]
	public static NCGKAGAAIBB GJEGANDCDIE(this FaceFeatureType BJLOCBNAGBJ, BNICAFPKAPB HHPKINNPBPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class GNPHFACIKNJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct PHIBMEHKCLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<GNPHFACIKNJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private KNMKMPHCMCP.CKFOFNGBBGP <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8213970", Offset = "0x8212770", VA = "0x188213970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x82141A0", Offset = "0x8212FA0", VA = "0x1882141A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private readonly Dictionary<string, int> AFFJOELPCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private bool GMGCDNDOFGP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public List<Texture2D> IAOBCAHADJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA942C0", Offset = "0xA930C0", VA = "0x180A942C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA97FD0", Offset = "0xA96DD0", VA = "0x180A97FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public SymmetricalFaceFeature AGDHPBEMCDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA94B50", Offset = "0xA93950", VA = "0x180A94B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EyesFaceFeature PNHIFIHMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA9C0F0", Offset = "0xA9AEF0", VA = "0x180A9C0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public FaceFeature PJILDOJBDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA94B10", Offset = "0xA93910", VA = "0x180A94B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x8212130", Offset = "0x8210F30", VA = "0x188212130")]
	private static void MMLPNKDPJOD(Sprite BCNAMAKCMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x8211BD0", Offset = "0x82109D0", VA = "0x188211BD0")]
	public static GNPHFACIKNJ DKGMJBPNIBI(SymmetricalFaceFeature CCBFLFDENCN, EyesFaceFeature EHIIBJIFNCD, FaceFeature FFAEJDCACCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x8211FF0", Offset = "0x8210DF0", VA = "0x188211FF0")]
	[AsyncStateMachine(typeof(PHIBMEHKCLG))]
	public static Task<GNPHFACIKNJ> MHFDAFDGHLL(SymmetricalFaceFeature CCBFLFDENCN, EyesFaceFeature EHIIBJIFNCD, FaceFeature FFAEJDCACCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x8212550", Offset = "0x8211350", VA = "0x188212550")]
	private GNPHFACIKNJ(SymmetricalFaceFeature CCBFLFDENCN, EyesFaceFeature EHIIBJIFNCD, FaceFeature FFAEJDCACCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x82121A0", Offset = "0x8210FA0", VA = "0x1882121A0")]
	private void MOAJMKOIBIM(List<Sprite> GGPMKKLMAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x8211E30", Offset = "0x8210C30", VA = "0x188211E30")]
	public bool HGCNIAHJOPK(string CEMDAKIFMAH, [Out] int JJJJBEGKNIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8211C60", Offset = "0x8210A60", VA = "0x188211C60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x8211D40", Offset = "0x8210B40", VA = "0x188211D40")]
	public bool HCIMLNOEIII(bool BFNFJAMIEGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8211F20", Offset = "0x8210D20", VA = "0x188211F20")]
	public void IBLJANMOGFD()
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
		private struct PGOGHHPFODN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public AsyncTaskMethodBuilder<GNPHFACIKNJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000269")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400026A")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			private TaskAwaiter<GNPHFACIKNJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x8213400", Offset = "0x8212200", VA = "0x188213400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x8213900", Offset = "0x8212700", VA = "0x188213900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private Dictionary<NJKDBAMDGPL, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private Dictionary<NJKDBAMDGPL, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private Dictionary<NJKDBAMDGPL, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private Dictionary<NJKDBAMDGPL, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private readonly Dictionary<NJKDBAMDGPL, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private GNPHFACIKNJ _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private GNPHFACIKNJ _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x820DAF0", Offset = "0x820C8F0", VA = "0x18820DAF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x820D350", Offset = "0x820C150", VA = "0x18820D350")]
		public GNPHFACIKNJ IFFNBOBPNGM(JLFDMKNKLIE FMEDCNPIHLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x820D0A0", Offset = "0x820BEA0", VA = "0x18820D0A0")]
		[AsyncStateMachine(typeof(PGOGHHPFODN))]
		public Task<GNPHFACIKNJ> CLCOKFFFJBN(int? CAHFOKLGEIB, int EHIIBJIFNCD, int FFAEJDCACCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x820D8A0", Offset = "0x820C6A0", VA = "0x18820D8A0")]
		public NoseFaceOption NNBDIIGCLKK(int JDDFPKCCMIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x820D1D0", Offset = "0x820BFD0", VA = "0x18820D1D0")]
		public SelectableFaceOption HGAGHIKMIBF(FaceFeatureType IHPPFHNIKKI, NJKDBAMDGPL BDOCIJPOLPO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x820D940", Offset = "0x820C740", VA = "0x18820D940")]
		public int NOPHEDOOLIB(NJKDBAMDGPL BDOCIJPOLPO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x820D3E0", Offset = "0x820C1E0", VA = "0x18820D3E0")]
		private void JECNOCLNIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x3CE6B50", Offset = "0x3CE5950", VA = "0x183CE6B50")]
		private void ILEIHCNBIKA<T>(IDictionary<NJKDBAMDGPL, T> IMNNEOMDPNB, IReadOnlyList<T> HHAIHJFLMOJ) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x820D610", Offset = "0x820C410", VA = "0x18820D610")]
		public NJKDBAMDGPL KBBNBEPAJMF(FaceFeatureType IHPPFHNIKKI)
		{
			return default(NJKDBAMDGPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x820D720", Offset = "0x820C520", VA = "0x18820D720")]
		public NJKDBAMDGPL MJPBHJDEMIN(FaceFeatureType IHPPFHNIKKI)
		{
			return default(NJKDBAMDGPL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x820D9C0", Offset = "0x820C7C0", VA = "0x18820D9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC21FD0", Offset = "0xC20DD0", VA = "0x180C21FD0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x820CFB0", Offset = "0x820BDB0", VA = "0x18820CFB0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public PBJKAGHPKMF SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAEE190", Offset = "0xAECF90", VA = "0x180AEE190", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		[SerializeField]
		private bool isNew;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public NJKDBAMDGPL FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x20F1D40", Offset = "0x20F0B40", VA = "0x1820F1D40")]
			get
			{
				return default(NJKDBAMDGPL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAEFA50", Offset = "0xAEE850", VA = "0x180AEFA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IsNew
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x1567B50", Offset = "0x1566950", VA = "0x181567B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x8208F90", Offset = "0x8207D90", VA = "0x188208F90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xD40920", Offset = "0xD3F720", VA = "0x180D40920")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8214720", Offset = "0x8213520", VA = "0x188214720")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x75B6E10", Offset = "0x75B5C10", VA = "0x1875B6E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8214760", Offset = "0x8213560", VA = "0x188214760")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x75B6E20", Offset = "0x75B5C20", VA = "0x1875B6E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8214740", Offset = "0x8213540", VA = "0x188214740")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x75BA1C0", Offset = "0x75B8FC0", VA = "0x1875BA1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8214780", Offset = "0x8213580", VA = "0x188214780")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x75BA1B0", Offset = "0x75B8FB0", VA = "0x1875BA1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8214440", Offset = "0x8213240", VA = "0x188214440", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8214650", Offset = "0x8213450", VA = "0x188214650")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class GEEBMDCLNIN
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly float PCHLCPCPCPJ;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly float CMELDECLKOF;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly Vector2 MNIHCJNOAEA;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly Vector2 PAJFNDGKKHL;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly Vector2 FIBJOGDPCEP;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly Vector2 LNBEHPHGHDE;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly Vector2 PNCPEMBPLIB;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly Vector2 EDJPOGLKMBH;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly Vector2 IIPPKGOHPJG;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly Vector2 HGHDPHJMEPH;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly Vector2 AJCJACEKFEH;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public static readonly Vector2 OHJHJIMHDOF;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public static readonly Vector2 DCCMJJEJFEB;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public static readonly Vector2 NGCCAFOKAGE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x820F810", Offset = "0x820E610", VA = "0x18820F810")]
	public static Vector2 JHILLEFBPFA(FaceFeatureType BJLOCBNAGBJ, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x8210DC0", Offset = "0x820FBC0", VA = "0x188210DC0")]
	public static float PBGOIMEHKPN(FaceFeatureType BJLOCBNAGBJ, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x820F5E0", Offset = "0x820E3E0", VA = "0x18820F5E0")]
	public static void IOOMHAFEAAL(KCANPOPNEIC HBAELJMOAFN, AvatarConfiguration LPDDEHLPANK, JLFDMKNKLIE EJAOOCKIDPN, JLFDMKNKLIE MCNCKCDJPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8211160", Offset = "0x820FF60", VA = "0x188211160")]
	public static float PPFKMKBECOK(FaceFeatureType IHPPFHNIKKI, float CDEDPJLLBDI, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8210210", Offset = "0x820F010", VA = "0x188210210")]
	public static float MMCPABILIBL(FaceFeatureType IHPPFHNIKKI, float LEBBGIACMDC, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x820EF70", Offset = "0x820DD70", VA = "0x18820EF70")]
	public static float FLBILACEOIJ(FaceFeatureType IHPPFHNIKKI, float GKEKGHNHKDP, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x82110D0", Offset = "0x820FED0", VA = "0x1882110D0")]
	public static float PLJFDOJEHCB(FaceFeatureType IHPPFHNIKKI, float GEHBABBAODJ, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x8210C80", Offset = "0x820FA80", VA = "0x188210C80")]
	public static float OHLPLIOMJJH(FaceFeatureType IHPPFHNIKKI, float MDHLNGGGMPM, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x820EE20", Offset = "0x820DC20", VA = "0x18820EE20")]
	public static float EDAAIOMMPOP(FaceFeatureType IHPPFHNIKKI, float LKGBHKCAFBL, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x820E430", Offset = "0x820D230", VA = "0x18820E430")]
	public static Vector2 BEKDNIAKDLD(FaceFeatureType IHPPFHNIKKI, Vector2 CMKLLLHMFJO, Vector2 MJPMAACCKHI, Vector2 BLHBALEFDFK, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x820F380", Offset = "0x820E180", VA = "0x18820F380")]
	public static Vector2 IJDDHPPCICO(FaceFeatureType IHPPFHNIKKI, Vector2 EHGNGBDPBKM, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x820E5B0", Offset = "0x820D3B0", VA = "0x18820E5B0")]
	private static Vector2 BPEEIHBKDKA(FaceFeatureType IHPPFHNIKKI, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x82109D0", Offset = "0x820F7D0", VA = "0x1882109D0")]
	private static Vector2 OAAINBCPPDM(FaceFeatureType IHPPFHNIKKI, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x820E950", Offset = "0x820D750", VA = "0x18820E950")]
	private static Vector2 CMLOFAJEADL(FaceFeatureType IHPPFHNIKKI, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x820E260", Offset = "0x820D060", VA = "0x18820E260")]
	private static Vector2 AMDNLKOONGE(FaceFeatureType IHPPFHNIKKI, Vector2 CMKLLLHMFJO, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x8210550", Offset = "0x820F350", VA = "0x188210550")]
	public static Vector2 NMKGDNDPHLM(FaceFeatureType IHPPFHNIKKI, Vector2 EHGNGBDPBKM, Vector2 MJPMAACCKHI, Vector2 BLHBALEFDFK, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x820F000", Offset = "0x820DE00", VA = "0x18820F000")]
	public static float FMPOLDDBJPD(FaceFeatureType IHPPFHNIKKI, float LEBBGIACMDC, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x820E1C0", Offset = "0x820CFC0", VA = "0x18820E1C0")]
	public static float AHOJGLLKCEK(FaceFeatureType IHPPFHNIKKI, float GKEKGHNHKDP, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x820F220", Offset = "0x820E020", VA = "0x18820F220")]
	public static float HBGOLDGLCNL(FaceFeatureType IHPPFHNIKKI, float GEHBABBAODJ, JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x820FF50", Offset = "0x820ED50", VA = "0x18820FF50")]
	private static float LEGKMFKFNAG(float OLBFNPPONEB, float ANDCPDPHMGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8210FB0", Offset = "0x820FDB0", VA = "0x188210FB0")]
	private static Vector2 PCHCIKEJMGI(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x820E500", Offset = "0x820D300", VA = "0x18820E500")]
	private static Vector2 BMPANHHEMEP(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x820EC00", Offset = "0x820DA00", VA = "0x18820EC00")]
	private static Vector2 CNIJDLEFEAB(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x82100A0", Offset = "0x820EEA0", VA = "0x1882100A0")]
	private static Vector2 MHJFHMENKPF(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x820FBF0", Offset = "0x820E9F0", VA = "0x18820FBF0")]
	private static float KBPFELEJLNM(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x820FAC0", Offset = "0x820E8C0", VA = "0x18820FAC0")]
	private static float JHMLMDECOJG(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8210420", Offset = "0x820F220", VA = "0x188210420")]
	private static float NFHPJBGFLPK(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x8211060", Offset = "0x820FE60", VA = "0x188211060")]
	private static float PFKPCIBIADC(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x82102A0", Offset = "0x820F0A0", VA = "0x1882102A0")]
	private static Vector2 MODBPBMJHNE(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x8210490", Offset = "0x820F290", VA = "0x188210490")]
	private static Vector2 NGDGJHNECAK(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x820FB30", Offset = "0x820E930", VA = "0x18820FB30")]
	private static Vector2 KAAOPFDJBKN(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x820ECB0", Offset = "0x820DAB0", VA = "0x18820ECB0")]
	private static Vector2 CNOABIDKFOB(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x8210D10", Offset = "0x820FB10", VA = "0x188210D10")]
	private static Vector2 OOLIPIFOLDH(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x820FE90", Offset = "0x820EC90", VA = "0x18820FE90")]
	private static Vector2 LECMCKPEJBO(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8210360", Offset = "0x820F160", VA = "0x188210360")]
	private static Vector2 NEDGCBLGLMB(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x8210150", Offset = "0x820EF50", VA = "0x188210150")]
	private static Vector2 MIBAJNFALBK(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x820F6A0", Offset = "0x820E4A0", VA = "0x18820F6A0")]
	private static Vector2 JGJODJLFHCB(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x820FDE0", Offset = "0x820EBE0", VA = "0x18820FDE0")]
	private static Vector2 LEBMKJBHEIC(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x820FD20", Offset = "0x820EB20", VA = "0x18820FD20")]
	private static Vector2 KMANAGMANCC(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x820EEB0", Offset = "0x820DCB0", VA = "0x18820EEB0")]
	private static Vector2 FDAEPCOKHCF(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x820F2C0", Offset = "0x820E0C0", VA = "0x18820F2C0")]
	private static Vector2 IIENPMNGNCA(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x820ED60", Offset = "0x820DB60", VA = "0x18820ED60")]
	private static Vector2 EAJGACHACEJ(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x820E7D0", Offset = "0x820D5D0", VA = "0x18820E7D0")]
	private static Vector2 CDFBFBONJLK(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x820F750", Offset = "0x820E550", VA = "0x18820F750")]
	private static Vector2 JHHFAMCMGPA(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x820FFE0", Offset = "0x820EDE0", VA = "0x18820FFE0")]
	private static Vector2 LGOGBPAHGOF(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x820E890", Offset = "0x820D690", VA = "0x18820E890")]
	private static Vector2 CLNGGBBPNMB(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x820FC60", Offset = "0x820EA60", VA = "0x18820FC60")]
	private static Vector2 KCOCHPJFENN(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x820E710", Offset = "0x820D510", VA = "0x18820E710")]
	private static Vector2 CBHHDFAJNCD(JLFDMKNKLIE FMEDCNPIHLH, AvatarConfiguration NGGDLMFKPOA)
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
