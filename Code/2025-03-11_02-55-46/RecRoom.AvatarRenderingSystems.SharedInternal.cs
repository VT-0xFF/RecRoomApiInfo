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
		[Cpp2IlInjected.Address(RVA = "0x747B910", Offset = "0x747AD10", VA = "0x18747B910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
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
		public AvatarFaceShapeData.HIOMJMOBCNN FaceShapeName;

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
		public AvatarBodyShapeData.CGGHALEEMLL BodyShapeName;

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
		public PCMIOJDPABF BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AnimationClip BodyPropertyAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct HeadShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AnimationClip HeadShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct NoseShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public HDEGHEIKKJI NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public AnimationClip NoseTypeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BodyPropertyBoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public PCMIOJDPABF BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public List<BoneInfluenceInfo> BoneInfluenceInfo;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct BoneInfluenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public IKHDAJFIDDC BodyPropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[Flags]
public enum IKHDAJFIDDC
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	NONE = 1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	X_POSITION = 2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Y_POSITION = 4,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Z_POSITION = 8,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	X_ROTATION = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Y_ROTATION = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Z_ROTATION = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	X_SCALE = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Y_SCALE = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Z_SCALE = 0x200
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class HIBFEDABLDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public HIBFEDABLDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x748B2C0", Offset = "0x748A6C0", VA = "0x18748B2C0")]
			internal bool ACAEJDCGIPG(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private const string LOCAL_ROTATION_X_PROPERTY_NAME = "m_LocalRotation.x";

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private const string LOCAL_ROTATION_Y_PROPERTY_NAME = "m_LocalRotation.y";

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private const string LOCAL_ROTATION_Z_PROPERTY_NAME = "m_LocalRotation.z";

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private const string LOCAL_ROTATION_W_PROPERTY_NAME = "m_LocalRotation.w";

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string BASE_NOSE_TWEAK_BONE_NAME = "Jnt.Head.Nose.Tweak";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private List<BodyPropertyBoneInfluenceInfo> bodyPropertyBoneInfluenceInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private List<AvatarHeadShapeBoneData> headShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private List<AvatarBodyPropertyBoneData> bodyPropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private List<AvatarNoseTypeBoneData> noseTypeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private List<AvatarFaceShapeData.HIOMJMOBCNN> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private List<AvatarBodyShapeData.CGGHALEEMLL> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private Dictionary<PCMIOJDPABF, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<(string, AvatarFaceShapeData.HIOMJMOBCNN), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Dictionary<(string, AvatarBodyShapeData.CGGHALEEMLL), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Dictionary<(string, HDEGHEIKKJI), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly Dictionary<(string, PCMIOJDPABF, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<PCMIOJDPABF, Dictionary<string, IKHDAJFIDDC>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<string> headBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<string> noseBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Dictionary<PCMIOJDPABF, string[]> bonesToUpdatePerProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Dictionary<string, Dictionary<IKHDAJFIDDC, int>> influencesPerBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly Dictionary<string, Dictionary<IKHDAJFIDDC, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7481C50", Offset = "0x7481050", VA = "0x187481C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x747FE60", Offset = "0x747F260", VA = "0x18747FE60")]
		public void OBBALIPJEND(IReadOnlyDictionary<string, Transform> BDHFKLIDMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x747E2E0", Offset = "0x747D6E0", VA = "0x18747E2E0")]
		public void FOBFLEKJFLH(IReadOnlyDictionary<string, Transform> BDHFKLIDMOG, AvatarFaceShapeData.HIOMJMOBCNN DDJACKDKDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x747C8E0", Offset = "0x747BCE0", VA = "0x18747C8E0")]
		public void CIINGHEDMKL(IReadOnlyDictionary<string, Transform> BDHFKLIDMOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x747F9D0", Offset = "0x747EDD0", VA = "0x18747F9D0")]
		public void KKKKLAPDLHL(IReadOnlyDictionary<string, Transform> BDHFKLIDMOG, HDEGHEIKKJI MGIHACEIMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x747F5D0", Offset = "0x747E9D0", VA = "0x18747F5D0")]
		public void IHPDDNLKJAP(IReadOnlyDictionary<string, Transform> BDHFKLIDMOG, AvatarBodyShapeData.CGGHALEEMLL EBNHCAOCMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x747C500", Offset = "0x747B900", VA = "0x18747C500")]
		public void BFMNIMPKDDN(IReadOnlyDictionary<string, Transform> BDHFKLIDMOG, IReadOnlyDictionary<string, FOBKBIDNGNH> ALNICOIEBLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x747DF30", Offset = "0x747D330", VA = "0x18747DF30")]
		public IReadOnlyDictionary<string, FOBKBIDNGNH> DNPGCAONKPB(IReadOnlyDictionary<string, Transform> BDHFKLIDMOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x747E5E0", Offset = "0x747D9E0", VA = "0x18747E5E0")]
		public Dictionary<string, FOBKBIDNGNH> FOENAMKMOKE(IReadOnlyDictionary<string, Transform> BDHFKLIDMOG, IReadOnlyDictionary<PCMIOJDPABF, float> CJFFAHGBDLA, IReadOnlyDictionary<string, FOBKBIDNGNH> CBOEEMIOCJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x747F450", Offset = "0x747E850", VA = "0x18747F450")]
		public float IHICGJJBLHM(PCMIOJDPABF CEHFLGNGNNM, float CFANLIACNFP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x747F8D0", Offset = "0x747ECD0", VA = "0x18747F8D0")]
		private float JCHMDMOJPBA(float PEBNJNGMMHE, List<float> AOIFJMJALDF)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x747FDF0", Offset = "0x747F1F0", VA = "0x18747FDF0")]
		private Vector3 MJLDHBPDOMP(Transform MHJHFBGHAHI, AvatarBodyPartBoneData MBABAHGBAJF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x747E280", Offset = "0x747D680", VA = "0x18747E280")]
		private Quaternion EPOMIDPMIHK(Transform MHJHFBGHAHI, AvatarBodyPartBoneData MBABAHGBAJF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x747C870", Offset = "0x747BC70", VA = "0x18747C870")]
		private Vector3 BHNEOIMLJME(Transform MHJHFBGHAHI, AvatarBodyPartBoneData MBABAHGBAJF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x747BAA0", Offset = "0x747AEA0", VA = "0x18747BAA0")]
		private void BCABKECMFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x66E7B00", Offset = "0x66E6F00", VA = "0x1866E7B00")]
		public bool HMOBGOJAIJM(IKHDAJFIDDC DHCPAIFKBDO, IKHDAJFIDDC BNPINIOKODD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x747CD50", Offset = "0x747C150", VA = "0x18747CD50")]
		private FOBKBIDNGNH DGNDBIOKHFA(PCMIOJDPABF CEHFLGNGNNM, IKHDAJFIDDC MELGKLMKJPM, FOBKBIDNGNH MHJHFBGHAHI, AvatarBodyPartBoneData MBABAHGBAJF)
		{
			return default(FOBKBIDNGNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x747EE80", Offset = "0x747E280", VA = "0x18747EE80")]
		public Dictionary<string, FOBKBIDNGNH> IEAPKDJHJOE(Dictionary<string, FOBKBIDNGNH> JLGMIEBLLLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x747CB80", Offset = "0x747BF80", VA = "0x18747CB80")]
		private void DALNDLFMCNH(Transform MHJHFBGHAHI, AvatarBodyPartBoneData MBABAHGBAJF, bool MOKHKCMOJAP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74815C0", Offset = "0x74809C0", VA = "0x1874815C0")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarBodyPropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PCMIOJDPABF BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float BodyPropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7481D00", Offset = "0x7481100", VA = "0x187481D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum CGGHALEEMLL
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			Pear = 1,
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			Apple = 2,
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			Triangle = 3,
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			Hourglass = 4,
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			Square = 5,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			Thin = 200
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CGGHALEEMLL blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Obsolete("Use BodyShapeId instead!")]
		[HideInInspector]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private AvatarBodyShapeData.CGGHALEEMLL blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MBDMAMDEGNN BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1C0C130", Offset = "0x1C0B530", VA = "0x181C0C130")]
			get
			{
				return default(MBDMAMDEGNN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.CGGHALEEMLL BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x975090", Offset = "0x974490", VA = "0x180975090")]
			get
			{
				return default(AvatarBodyShapeData.CGGHALEEMLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7482790", Offset = "0x7481B90", VA = "0x187482790")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public AvatarBodyShapeData.CGGHALEEMLL BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7482010", Offset = "0x7481410", VA = "0x187482010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Dictionary<MBDMAMDEGNN, AvatarBodyShape> JLHBIPMFNKB;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7482280", Offset = "0x7481680", VA = "0x187482280")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74825A0", Offset = "0x74819A0", VA = "0x1874825A0")]
		public AvatarBodyShape Find(MBDMAMDEGNN DBDHAHMCHKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x74826A0", Offset = "0x7481AA0", VA = "0x1874826A0")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7482660", Offset = "0x7481A60", VA = "0x187482660")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74826E0", Offset = "0x7481AE0", VA = "0x1874826E0")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IPBJOKENCEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private Transform[] GAPKFBMLGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Dictionary<string, Transform> OLIKJHHDDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly Dictionary<Transform, Transform> PJBDJPLDLPI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> HMCBMJBLLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] KPNPOEEOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x748BB80", Offset = "0x748AF80", VA = "0x18748BB80")]
	public void NEGFLILEGLK(Transform NNENFCEMDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x748B860", Offset = "0x748AC60", VA = "0x18748B860")]
	public Transform BKBKJDGFLCK(Transform FFPBAKAGFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x748B940", Offset = "0x748AD40", VA = "0x18748B940")]
	public void JIJIOGMDKLC(SkinnedMeshRenderer CLHBENNNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x748B700", Offset = "0x748AB00", VA = "0x18748B700")]
	private static void BAOPHIHGHCO(Transform HAIKBOLEOOP, List<Transform> LKGFMADIEBG, Dictionary<string, Transform> NLOGEHHJDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x748BC60", Offset = "0x748B060", VA = "0x18748BC60")]
	public IPBJOKENCEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IAKNPHOHNEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public bool EEKBFIIBBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool DMHOLHMMKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public bool MPDAIIONPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public AFEABOIFMLA? IIJPKGCBOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public JEMKHCHMBLO.IFCJAEMECIM CPHGNNOGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public HairData BOJCDIEHEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public AdditionalHatData CHFOCIJFDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool OPAMIIBHHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool BOHHCNDJKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool GOMLAAIFDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public IList<PFLMFICBCEJ> CJBFKFBLJDM;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public IAKNPHOHNEA()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Header("Hand Animation")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Header("Body Shapes")]
		public BodyShapeConfiguration BodyShapeConfiguration;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7482820", Offset = "0x7481C20", VA = "0x187482820")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BMIIIHCKPKC
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static GKMHKJJPKEC BIFOBPHNPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7488160", Offset = "0x7487560", VA = "0x187488160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static CFIMFIIKPEO IAAIEICHKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7488030", Offset = "0x7487430", VA = "0x187488030")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CIDCFKJJJAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Transform EBJILPJCBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public AvatarSkinAssetItem FDBNKMBJFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public AssetReference NDIBGGKOFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public GameObject JOAMHOPFPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public GameObject CDKNBINHDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public SkinnedMeshRenderer GGBBPJCNLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public AvatarSkinnedMeshBoneOrderRemapsData BOMOFMOBJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Material KAEHNHLOCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Material ICOCDMNJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Material NCHGFAPLDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Shader JOLONPNDDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Shader KJIIHNBAGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Animator AKEHBPJFPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Renderer[] LKIPBGPHECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public AvatarConfiguration EFEEBJKNCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public AvatarBodyPartShapesManager PDPPEPLKEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public IReadOnlyDictionary<string, Transform> BPFJFBIFHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Transform IHGKEDANGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public DIINEKIAPFE CCBKMGCAFKO;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct PEIMOGJCFOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public SkinnedMeshRenderer[] CPMPEKBIFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public SkinnedMeshRenderer[] FEMOGDPOFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public SkinnedMeshRenderer[] MKLGMONOOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public SkinnedMeshRenderer[] KCDOAHNAMDF;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct NBPJKDKHJND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Transform FPPGFDLLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Transform HHJMGFMGLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Transform FONOLIOJJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public Transform KBMCDHFPNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Transform GAAGEGNDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Transform KDGDFMHBBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public Transform AHPFHKBOPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public AvatarConfiguration EFEEBJKNCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public DIINEKIAPFE CCBKMGCAFKO;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FHOFHKOENLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public SkinnedMeshRenderer[] IAFHGBIBGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Material BKMHIJCELBJ;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NIJKPLPHOCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public LFLFMHLHDIK KOKEOKGNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public int EAPAPEKEMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public int CNCKCCAGFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Color IHOIOIAJLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Color OPOEILHDJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public int NBIKGKIHEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public int NLAPFBKAOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public Color LGEMNKOJLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public Color GPDCFBBKLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public int EDANPLHPMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public float BNIDDDOEEFO;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct FIBNFDNIBFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public LFLFMHLHDIK KOKEOKGNDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Vector2 OHEDDGLOJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public float AJEJELHKBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public Vector2 NOCJBMDLJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float NCCFOGBAHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public Vector2 LCJDNILLEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public float OMOMFMEBGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public Vector2 GEBLJOIHFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public float PKHCEKCOFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public bool BMGEIDMDIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public bool MBAJNGAJCKI;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public enum HIOMJMOBCNN
		{
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public HIOMJMOBCNN blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[HideInInspector]
		[Obsolete("Use FaceShapeId instead!")]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BFMALJPIEON FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1C0C130", Offset = "0x1C0B530", VA = "0x181C0C130")]
			get
			{
				return default(BFMALJPIEON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7483520", Offset = "0x7482920", VA = "0x187483520", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7483580", Offset = "0x7482980", VA = "0x187483580")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AvatarFaceShapeData.HIOMJMOBCNN FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7482DA0", Offset = "0x74821A0", VA = "0x187482DA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private readonly Dictionary<BFMALJPIEON, AvatarFaceShape> JLHBIPMFNKB;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7483010", Offset = "0x7482410", VA = "0x187483010")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7483330", Offset = "0x7482730", VA = "0x187483330")]
		public AvatarFaceShape Find(BFMALJPIEON PPEEPMCCBBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7483430", Offset = "0x7482830", VA = "0x187483430")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74833F0", Offset = "0x74827F0", VA = "0x1874833F0")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7483470", Offset = "0x7482870", VA = "0x187483470")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7483BD0", Offset = "0x7482FD0", VA = "0x187483BD0")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LACLLNIICDF HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1C0C130", Offset = "0x1C0B530", VA = "0x181C0C130")]
			get
			{
				return default(LACLLNIICDF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x96E0E0", Offset = "0x96D4E0", VA = "0x18096E0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB07F00", Offset = "0xB07300", VA = "0x180B07F00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB54B50", Offset = "0xB53F50", VA = "0x180B54B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7483DA0", Offset = "0x74831A0", VA = "0x187483DA0")]
		public Texture2D NBACGAPKKBP(HairPatternStyle HEBHDMBGMCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7483C50", Offset = "0x7483050", VA = "0x187483C50", Slot = "0")]
		public override bool Equals(object NBAMGPFDMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7483BE0", Offset = "0x7482FE0", VA = "0x187483BE0", Slot = "4")]
		public bool Equals(AvatarHairPattern MNALNBMKJLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7483F20", Offset = "0x7483320", VA = "0x187483F20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7483D10", Offset = "0x7483110", VA = "0x187483D10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7483EF0", Offset = "0x74832F0", VA = "0x187483EF0")]
		public static bool NEBBLIKBPGD(AvatarHairPattern HGHHJPDLMPJ, AvatarHairPattern OLNKLOFDFBI)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7483D20", Offset = "0x7483120", VA = "0x187483D20")]
		public static bool JECEAGOPPKI(AvatarHairPattern HGHHJPDLMPJ, AvatarHairPattern OLNKLOFDFBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7483F60", Offset = "0x7483360", VA = "0x187483F60")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum EFMOGLDOMFL
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Idle,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Invisible,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Pointing,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	TPose,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	ThumbUp,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	HandShake,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Grabbing,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	NumStates
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[Flags]
public enum KHIKDCNOCPN
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	ThumbUp = 1,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Pointing = 2,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	HandShake = 4
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OACCOHEPABJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Animator CHNIKABPLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public PMBKDIGAKIN OHDLLNHKAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public AvatarConfiguration EFEEBJKNCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public GameObject MPELMBCJILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public DIINEKIAPFE CCBKMGCAFKO;
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct AAGHDAAJACF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Transform CCGNPBDMLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public bool COOKALLEEJP;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7484070", Offset = "0x7483470", VA = "0x187484070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PFLMFICBCEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public string NAMECGEJFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public OutfitType PCPAJECLIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public FGFOFKPBCAF HMHGMKLFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public JEMKHCHMBLO.IFCJAEMECIM DPAKLGLNPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public bool HPHMBLDDGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public bool DNMBOEFPGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool PIPJPFHEEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Color? CPHGMAOMDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool PBLJPCMBMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public Color? NNPPGJNHEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool EFEDHILFPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool FDBBOIADILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool PBKLEJGLAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public Transform LAAJBJFCKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector2? ICOOICBNKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public FitMeshHemisphere LAPEPCHKICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public AssetReference JDHDKPLPOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public AssetReference CMCBMPLPHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public AssetReference[] GICHLGJAEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public PFLMFICBCEJ IJAHILFEOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool FCBMCCJCNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool ICBLKENLAEH;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string AGHJIAELIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x748DEC0", Offset = "0x748D2C0", VA = "0x18748DEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x748DEC0", Offset = "0x748D2C0", VA = "0x18748DEC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x748DF70", Offset = "0x748D370", VA = "0x18748DF70")]
	public PFLMFICBCEJ()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private KKPPLOGPOPC? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public APAOJHILPJK CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7484600", Offset = "0x7483A00", VA = "0x187484600")]
			get
			{
				return default(APAOJHILPJK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public KKPPLOGPOPC MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7484630", Offset = "0x7483A30", VA = "0x187484630")]
			get
			{
				return default(KKPPLOGPOPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9636B0", VA = "0x1809642B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9642C0", Offset = "0x9636C0", VA = "0x1809642C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x74844A0", Offset = "0x74838A0", VA = "0x1874844A0")]
		public Material[] ODFECLMJPDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7484100", Offset = "0x7483500", VA = "0x187484100")]
		public static void DDBLKPDNMJG(AvatarItemMaterial IHMOMCICCLF, Material GIEDFKFHBFF, int HJFKPBMKNKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x74842F0", Offset = "0x74836F0", VA = "0x1874842F0")]
		private static bool IIGDGEFEMGC(AvatarItemMaterial IHMOMCICCLF, int HJFKPBMKNKH, [Out] Material CFOELHEPKBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7484580", Offset = "0x7483980", VA = "0x187484580")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class JIDPIGAIGOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public SkinnedMeshRenderer FLGIOICJCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Material[] NHOONKEPCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private byte[] CPFPMIKLMIB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh MOPHOAEDCKD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x748BED0", Offset = "0x748B2D0", VA = "0x18748BED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Material[] LIAEKGIDOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte[] LDLOCDMJNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x748BEF0", Offset = "0x748B2F0", VA = "0x18748BEF0")]
	public JIDPIGAIGOP(SkinnedMeshRenderer AKKIOLPGAEI, AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC, Material[] KGONHFGLNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x748BD30", Offset = "0x748B130", VA = "0x18748BD30")]
	public static JIDPIGAIGOP BEHBHCNKOLB(Renderer CJJNPFGBHFH, AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC, Material[] KGONHFGLNJE)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x12A1C10", Offset = "0x12A1010", VA = "0x1812A1C10")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB54710", Offset = "0xB53B10", VA = "0x180B54710")]
		public void FHPKMMCODGE(Vector3 HJBDDDIFEBJ, Quaternion NBFJKGINHEC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class HNPCINEDHHP
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x748B320", Offset = "0x748A720", VA = "0x18748B320")]
	public static PositionAndRotation ADNBGJIKION(this PositionAndRotation DCJAMPFPFEG)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x748B470", Offset = "0x748A870", VA = "0x18748B470")]
	public static float GJPPBEIBPBD(float MPAMMAGABHA, Vector2 CPFPNAMAHJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x748B510", Offset = "0x748A910", VA = "0x18748B510")]
	public static float GJPPBEIBPBD(float MPAMMAGABHA, float IKENCPHIKGM, float FPBMNANBNNI, float MNJHKANCBHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x748B640", Offset = "0x748AA40", VA = "0x18748B640")]
	public static float KECKHLDNFPC(float PEBNJNGMMHE, Vector2 CPFPNAMAHJJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x748B590", Offset = "0x748A990", VA = "0x18748B590")]
	public static float KECKHLDNFPC(float PEBNJNGMMHE, float IKENCPHIKGM, float FPBMNANBNNI, float MNJHKANCBHC)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public HDEGHEIKKJI NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x74846F0", Offset = "0x7483AF0", VA = "0x1874846F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public enum MEOCNJEEBBM
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public enum LPFNJMNNCNC
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	IdleSwayAimWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	IdleSwayMeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	IdleSwayLightItem,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	IdleSwayHeavyItem,
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	IdleSwayAimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	FastAction,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	NumTypes
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum FOJIEICEIIC
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	PotatoAvatar,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	FullOutfitAvatar
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct DMFKIMMOAIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public Vector2 IELEBBEAIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public Vector2 KKGJCAEFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public Vector2 IHHGPIBMIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public Vector2 HAKKJMEMEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public Vector2 HEKMJCMEPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Vector2 HEPHGFODLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public Vector2 FLAALELIHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public Vector2 CKEBKGHHDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Vector2 OGBAAPOLEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Vector2 MPHBLJHKGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Vector2 AMLIMKGEBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Vector2 MKEHJMPHNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public Vector2 FJOPBENIHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public Vector2 OONLLHGOJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public Vector2 POAKDJHIHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public Vector2 NHCAKMOLGGC;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class NOMJJFPABLN
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public static readonly int HEFFENCAGFL;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public static readonly string IFIJBINMEOB;

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x748DC20", Offset = "0x748D020", VA = "0x18748DC20")]
	public static CIDCFKJJJAE NHPANONMOBN(Transform DPGGEKOKAGB, AvatarSkinAssetItem DAEHDKOMAFF, AssetReference GIDCCLDJINI, GameObject DOLFEMGIEDH, GameObject MBHGKBADDNE, SkinnedMeshRenderer JNNHCIODBKB, AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC, Material EKPBEHHFKOE, Material OMBBEBFLEKM, Material NCGMKBEKHJI, Shader NDMPGLJFBIG, Shader LPJBDMIGHLP, Animator NHNEIGPDFFE, Renderer[] CLJDPDHPGKC, AvatarConfiguration FDDIIONJAJJ, AvatarBodyPartShapesManager DJHJJLBKELP, IReadOnlyDictionary<string, Transform> BDHFKLIDMOG, Transform BNMNBLKMHBF, DIINEKIAPFE NKOMJFFJMEP)
	{
		return default(CIDCFKJJJAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x748D9D0", Offset = "0x748CDD0", VA = "0x18748D9D0")]
	public static PEIMOGJCFOI CLEOEGGONLC(SkinnedMeshRenderer[] ELEHIPAMKBG, SkinnedMeshRenderer[] NCHDEHPFOFM, SkinnedMeshRenderer[] PGCJMOEMKLM, SkinnedMeshRenderer[] AGCOJDBLCFO)
	{
		return default(PEIMOGJCFOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x748DB00", Offset = "0x748CF00", VA = "0x18748DB00")]
	public static NBPJKDKHJND LOBIKKMKCNH(Transform HPFPIJFCILJ, Transform AAPLGGFIMMK, Transform IJLBAIDPJCK, Transform FIJKMHFAKPN, Transform DBAFFOOKKFA, Transform HBKMPJBLINC, Transform CMBBKIGCNNG, AvatarConfiguration AMOMBCNFLFB, DIINEKIAPFE NKOMJFFJMEP)
	{
		return default(NBPJKDKHJND);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x25EC0C0", Offset = "0x25EB4C0", VA = "0x1825EC0C0")]
	public static FHOFHKOENLI AGEGAJEPAOL(SkinnedMeshRenderer[] EHCNDLLHLMF, Material INPIHLMBIBP)
	{
		return default(FHOFHKOENLI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x748D930", Offset = "0x748CD30", VA = "0x18748D930")]
	public static NIJKPLPHOCE BKFLPALBHAJ(LFLFMHLHDIK NPADIINPPJE, int BOFEEEPGEHG, int HFPABGCPDMN, Color DIDJODOINMF, Color KBOHKFMCMNK, int FLHHHOFNFBL, int PALECFCHJIP, Color FNKFMJCLLJA, Color EGALDECGMPE, int HKKECCINNGG)
	{
		return default(NIJKPLPHOCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x748DA50", Offset = "0x748CE50", VA = "0x18748DA50")]
	public static FIBNFDNIBFJ HPBKPCHBGDG(LFLFMHLHDIK NPADIINPPJE, Vector2 CHKMPNMDMDO, float JDOAMFCDNLJ, Vector2 AJIIOHJNNLM, float OAMLOJNABDA, Vector2 MCOCNKCDPHM, float KGGLLFJPOHH, Vector2 JGGDIKHPPEC, float OAEJKCHOMPL)
	{
		return default(FIBNFDNIBFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x748D8B0", Offset = "0x748CCB0", VA = "0x18748D8B0")]
	public static OACCOHEPABJ ACPPEBGOOOK(Animator FDOGPBCNLKM, PMBKDIGAKIN HAPKBJEEDCN, AvatarConfiguration FDDIIONJAJJ, GameObject HNCIGDLIIPJ, DIINEKIAPFE NKOMJFFJMEP)
	{
		return default(OACCOHEPABJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x748DBE0", Offset = "0x748CFE0", VA = "0x18748DBE0")]
	public static AAGHDAAJACF MFFEGCAKAEI(Transform BFMGEFJMMDK, bool NBNKHLNAKNI)
	{
		return default(AAGHDAAJACF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class BFNNENLMIDC
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7487FE0", Offset = "0x74873E0", VA = "0x187487FE0")]
	public static EFMOGLDOMFL EOEJAMPNBKF(this MEOCNJEEBBM NEOOFPKPJJH)
	{
		return default(EFMOGLDOMFL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7487FD0", Offset = "0x74873D0", VA = "0x187487FD0")]
	public static bool ADMJLIBFPKK(this MEOCNJEEBBM CIGNDCJFINH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum BNPPOKIJAMP
		{
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BodySkinnedMeshLODs MAMCPPICAFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BodySkinnedMeshLODs GOGECGHHEEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public BodySkinnedMeshLODs ICMAOPFFGFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs CPHCOLGJCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x96A760", Offset = "0x969B60", VA = "0x18096A760")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7484960", Offset = "0x7483D60", VA = "0x187484960")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(BNPPOKIJAMP BFOCKINCOPP, [Optional] AFEABOIFMLA? IJENEBIDOCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class LBGCIDPEAEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public LBGCIDPEAEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x748C750", Offset = "0x748BB50", VA = "0x18748C750")]
			internal bool EIEGKLMMDGL(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x74856C0", Offset = "0x7484AC0", VA = "0x1874856C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x74856C0", Offset = "0x7484AC0", VA = "0x1874856C0")]
		private void MBCMJECPIOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7484B50", Offset = "0x7483F50", VA = "0x187484B50")]
		private void DFGPGHHJBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7484AE0", Offset = "0x7483EE0", VA = "0x187484AE0")]
		public byte[] BOPBAFJMLJF(string EHOAHADHJDD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7484CA0", Offset = "0x74840A0", VA = "0x187484CA0")]
		public bool GJKNLINMNMC(SkinnedMeshBoneOrderData CIHBHDIBHEH, AvatarSkinnedMeshBonesController GBNDEJLBLPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7485730", Offset = "0x7484B30", VA = "0x187485730")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class KIMKFPPHCEO
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CBIPOIMFJBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Transform[] KPNPOEEOFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Matrix4x4[] HDPCBMEIODG;
	}

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public static readonly string OIJOHAALPCO;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x748C100", Offset = "0x748B500", VA = "0x18748C100")]
	public static byte[] LLECBKCBELP(AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC, SkinnedMeshRenderer CLHBENNNNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x748C1F0", Offset = "0x748B5F0", VA = "0x18748C1F0")]
	public static CBIPOIMFJBI? NHOKGCGDEEJ(AvatarSkinnedMeshBoneOrderRemapsData KCLPCDEHJNC, SkinnedMeshRenderer CLHBENNNNGM)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[ReadOnlyField]
		[SerializeField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		[IGKHBFEOLOG(MFMOBKOPAIF.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string EALOJNPBKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7485800", Offset = "0x7484C00", VA = "0x187485800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7485C30", Offset = "0x7485030", VA = "0x187485C30")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7485B70", Offset = "0x7484F70", VA = "0x187485B70")]
		private void DFGPGHHJBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7485830", Offset = "0x7484C30", VA = "0x187485830")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7485890", Offset = "0x7484C90", VA = "0x187485890")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer CJJNPFGBHFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public enum PCMIOJDPABF
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	BicepWidth,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	ForearmWidth,
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	ChestSize,
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	ChestOut,
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	WaistSize,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	HipWidth,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	NeckLength,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	NeckThickness,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ThighWidth,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	CalfWidth,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	FootWidth,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	FootSize,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	ShoulderWidth,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	BellyOut
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class OBEJLMDFIAN
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x748DE60", Offset = "0x748D260", VA = "0x18748DE60")]
	public static bool PMLGGNGKBBN(this PCMIOJDPABF CEHFLGNGNNM)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class BodyShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[FormerlySerializedAs("BodyShapePropertyData")]
		[SerializeField]
		private List<BodyShapePropertyData> FullBodyShapePropertyData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private List<BodyShapePropertyData> ModernBeanShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7488730", Offset = "0x7487B30", VA = "0x187488730")]
		public List<BodyShapePropertyData> DPJOHHJBOOB(DIINEKIAPFE NKOMJFFJMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xAA00D0", Offset = "0xA9F4D0", VA = "0x180AA00D0")]
		public BodyShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct BodyShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public AvatarBodyShapeData.CGGHALEEMLL BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public List<BodyPropertySliderData> BodyPropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct BodyPropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public PCMIOJDPABF BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct FOBKBIDNGNH : IEquatable<FOBKBIDNGNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public string FLPHKFBFLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public Vector3 FCBPBALDGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public Vector3 IJGOGLEGOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public Vector3 MEGIBCMFDHC;

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7488BF0", Offset = "0x7487FF0", VA = "0x187488BF0", Slot = "4")]
	public bool Equals(FOBKBIDNGNH MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7488D30", Offset = "0x7488130", VA = "0x187488D30", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7488DE0", Offset = "0x74881E0", VA = "0x187488DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum HGKNBDOHBHB
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class AIJALJOGGJG
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public static readonly AIJALJOGGJG LPOHMOGIBPI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int JCMDJKEGFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9641A0", Offset = "0x9635A0", VA = "0x1809641A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x968380", Offset = "0x967780", VA = "0x180968380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public HGKNBDOHBHB MLHCNBMFBBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA80880", Offset = "0xA7FC80", VA = "0x180A80880")]
		[CompilerGenerated]
		get
		{
			return default(HGKNBDOHBHB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xB70020", Offset = "0xB6F420", VA = "0x180B70020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public AIJALJOGGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2C15F90", Offset = "0x2C15390", VA = "0x182C15F90")]
	public AIJALJOGGJG(HGKNBDOHBHB PMFPMLHADKP, int HLMCODEHGGK)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x748A440", Offset = "0x7489840", VA = "0x18748A440")]
		public void DrawPosition(bool CJIJMMBOCLH, Transform NCNOHDPHPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x748A4E0", Offset = "0x74898E0", VA = "0x18748A4E0")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere FMMOCKMFLKE, Transform HKNGNFLDPKM, Vector2 FEEIPPMOLLD, AnchorParamsRestrictions DBHNBCEFIAN, bool OEABJPEDGEP = false, bool HNJPBPJCCPD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9668F0", Offset = "0x965CF0", VA = "0x1809668F0")]
		public FitMeshPreviewGizmo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x748DF80", Offset = "0x748D380", VA = "0x18748DF80")]
		public void MIIGJMBBGJA(SkinnedMeshRenderer CLHBENNNNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x748E120", Offset = "0x748D520", VA = "0x18748E120")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[Header("Remapping Eye Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x74835D0", Offset = "0x74829D0", VA = "0x1874835D0")]
		public void DHBFPFPFMKE(MDKBPDIPAFE NOOIFNECLCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7483AB0", Offset = "0x7482EB0", VA = "0x187483AB0")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB2660", Offset = "0xAB1A60", VA = "0x180AB2660", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7488750", Offset = "0x7487B50", VA = "0x187488750")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7488B60", Offset = "0x7487F60", VA = "0x187488B60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7488BC0", Offset = "0x7487FC0", VA = "0x187488BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x7488B80", Offset = "0x7487F80", VA = "0x187488B80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7488BD0", Offset = "0x7487FD0", VA = "0x187488BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x7488BA0", Offset = "0x7487FA0", VA = "0x187488BA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x246FAA0", Offset = "0x246EEA0", VA = "0x18246FAA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x1BC36F0", Offset = "0x1BC2AF0", VA = "0x181BC36F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7488BE0", Offset = "0x7487FE0", VA = "0x187488BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7488760", Offset = "0x7487B60", VA = "0x187488760", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7488A50", Offset = "0x7487E50", VA = "0x187488A50")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x74899A0", Offset = "0x7488DA0", VA = "0x1874899A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x17EA8A0", Offset = "0x17E9CA0", VA = "0x1817EA8A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x133EED0", Offset = "0x133E2D0", VA = "0x18133EED0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x17EA880", Offset = "0x17E9C80", VA = "0x1817EA880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7489770", Offset = "0x7488B70", VA = "0x187489770", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x74898B0", Offset = "0x7488CB0", VA = "0x1874898B0")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x748E510", Offset = "0x748D910", VA = "0x18748E510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x748F1A0", Offset = "0x748E5A0", VA = "0x18748F1A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private readonly List<JCAOOGBCPCO<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x9650D0", Offset = "0x9644D0", VA = "0x1809650D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x9650E0", Offset = "0x9644E0", VA = "0x1809650E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x74896C0", Offset = "0x7488AC0", VA = "0x1874896C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7489730", Offset = "0x7488B30", VA = "0x187489730")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x7489650", Offset = "0x7488A50", VA = "0x187489650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x74896A0", Offset = "0x7488AA0", VA = "0x1874896A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6952090", Offset = "0x6951490", VA = "0x186952090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7489130", Offset = "0x7488530", VA = "0x187489130")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7489270", Offset = "0x7488670", VA = "0x187489270", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x74891A0", Offset = "0x74885A0", VA = "0x1874891A0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7489350", Offset = "0x7488750", VA = "0x187489350")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7488F20", Offset = "0x7488320", VA = "0x187488F20")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7489450", Offset = "0x7488850", VA = "0x187489450")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public sealed class LFLFMHLHDIK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GFFAPDFCKJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<LFLFMHLHDIK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private JKGLJHBPGHO.CCKAEJOKCCD <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x748AA20", Offset = "0x7489E20", VA = "0x18748AA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x748B250", Offset = "0x748A650", VA = "0x18748B250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Dictionary<string, int> EMEAFPJNLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool DECDHEIMGNB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Texture2DArray DDBOMEKEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public SymmetricalFaceFeature BJMKAAICLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x968070", Offset = "0x967470", VA = "0x180968070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EyesFaceFeature DPIFDKLLLOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x969450", Offset = "0x968850", VA = "0x180969450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x969430", Offset = "0x968830", VA = "0x180969430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FaceFeature BNCFJIICDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x969460", Offset = "0x968860", VA = "0x180969460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x748CFD0", Offset = "0x748C3D0", VA = "0x18748CFD0")]
	private static void DIONJAFCEEB(Sprite AMOKLCAMJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x748D370", Offset = "0x748C770", VA = "0x18748D370")]
	public static LFLFMHLHDIK LKDIGICJNLA(SymmetricalFaceFeature GBLKCAPNMNE, EyesFaceFeature OJHGEAGDHJC, FaceFeature AJMIJHKOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x748D070", Offset = "0x748C470", VA = "0x18748D070")]
	[AsyncStateMachine(typeof(GFFAPDFCKJM))]
	public static Task<LFLFMHLHDIK> EHBOHNMKFKA(SymmetricalFaceFeature GBLKCAPNMNE, EyesFaceFeature OJHGEAGDHJC, FaceFeature AJMIJHKOCNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x748D400", Offset = "0x748C800", VA = "0x18748D400")]
	private LFLFMHLHDIK(SymmetricalFaceFeature GBLKCAPNMNE, EyesFaceFeature OJHGEAGDHJC, FaceFeature AJMIJHKOCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x748C780", Offset = "0x748BB80", VA = "0x18748C780")]
	private void BHPPFHIMNJE(List<Sprite> BMEJMDCNHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x748D1B0", Offset = "0x748C5B0", VA = "0x18748D1B0")]
	public bool KIBBLMBAFDP(string KDPFFMGAKEG, [Out] int FFCBHHABFJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x748D040", Offset = "0x748C440", VA = "0x18748D040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x748CEC0", Offset = "0x748C2C0", VA = "0x18748CEC0")]
	public bool DAHIKGIHLLP(bool NDKANNEDCBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x748D2A0", Offset = "0x748C6A0", VA = "0x18748D2A0")]
	public void KOECGLGMMCD()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct BPCMCFMJOPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public AsyncTaskMethodBuilder<LFLFMHLHDIK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private TaskAwaiter<LFLFMHLHDIK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x74881C0", Offset = "0x74875C0", VA = "0x1874881C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x74886C0", Offset = "0x7487AC0", VA = "0x1874886C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private Dictionary<AFEABOIFMLA, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private Dictionary<AFEABOIFMLA, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private Dictionary<AFEABOIFMLA, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private Dictionary<AFEABOIFMLA, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private readonly Dictionary<AFEABOIFMLA, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private LFLFMHLHDIK _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private LFLFMHLHDIK _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x748A410", Offset = "0x7489810", VA = "0x18748A410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7489CF0", Offset = "0x74890F0", VA = "0x187489CF0")]
		public LFLFMHLHDIK GPGPHIFCCJN(DIINEKIAPFE NKOMJFFJMEP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7489BC0", Offset = "0x7488FC0", VA = "0x187489BC0")]
		[AsyncStateMachine(typeof(BPCMCFMJOPJ))]
		public Task<LFLFMHLHDIK> FLJMOPIHGDO(int? ODAHCHFNPDD, int OJHGEAGDHJC, int AJMIJHKOCNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x748A240", Offset = "0x7489640", VA = "0x18748A240")]
		public NoseFaceOption POHGBJIKOPM(int NCIJEBCCOHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7489FB0", Offset = "0x74893B0", VA = "0x187489FB0")]
		public SelectableFaceOption MJPBDGDLFJC(FaceFeatureType NMALLOBNLKG, AFEABOIFMLA FJPOLNGOPFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7489B40", Offset = "0x7488F40", VA = "0x187489B40")]
		public int EAEJDIEAGFK(AFEABOIFMLA FJPOLNGOPFA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7489D80", Offset = "0x7489180", VA = "0x187489D80")]
		private void JFNDGMDKPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3486150", Offset = "0x3485550", VA = "0x183486150")]
		private void NBENNNKAKEN<T>(IDictionary<AFEABOIFMLA, T> EHAMKEJBOAG, IReadOnlyList<T> FENEMHOICCC) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x748A130", Offset = "0x7489530", VA = "0x18748A130")]
		public AFEABOIFMLA NPKIEFPABAO(FaceFeatureType NMALLOBNLKG)
		{
			return default(AFEABOIFMLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x74899C0", Offset = "0x7488DC0", VA = "0x1874899C0")]
		public AFEABOIFMLA BOILFIIHOHD(FaceFeatureType NMALLOBNLKG)
		{
			return default(AFEABOIFMLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x748A2E0", Offset = "0x74896E0", VA = "0x18748A2E0")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xACC550", Offset = "0xACB950", VA = "0x180ACC550", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x74898B0", Offset = "0x7488CB0", VA = "0x1874898B0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public HDEGHEIKKJI SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xACB320", Offset = "0xACA720", VA = "0x180ACB320", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xAA00D0", Offset = "0xA9F4D0", VA = "0x180AA00D0")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[Obsolete("Use FaceFeatureId instead!")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public AFEABOIFMLA FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1C0C130", Offset = "0x1C0B530", VA = "0x181C0C130")]
			get
			{
				return default(AFEABOIFMLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xC6AD40", Offset = "0xC6A140", VA = "0x180C6AD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x969440", Offset = "0x968840", VA = "0x180969440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7483520", Offset = "0x7482920", VA = "0x187483520", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAA00D0", Offset = "0xA9F4D0", VA = "0x180AA00D0")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x748E490", Offset = "0x748D890", VA = "0x18748E490")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x694E1B0", Offset = "0x694D5B0", VA = "0x18694E1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x748E4D0", Offset = "0x748D8D0", VA = "0x18748E4D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x694E1C0", Offset = "0x694D5C0", VA = "0x18694E1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x748E4B0", Offset = "0x748D8B0", VA = "0x18748E4B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x6951310", Offset = "0x6950710", VA = "0x186951310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x748E4F0", Offset = "0x748D8F0", VA = "0x18748E4F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6951300", Offset = "0x6950700", VA = "0x186951300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x748E1B0", Offset = "0x748D5B0", VA = "0x18748E1B0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x748E3C0", Offset = "0x748D7C0", VA = "0x18748E3C0")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class BCCNCGGOOPM
{
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public static readonly float FNCHIFIJOFI;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public static readonly float FLDPIINGOMD;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public static readonly Vector2 LHDDKMGPFNK;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public static readonly Vector2 GFBAHOAELFH;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public static readonly Vector2 FGOJNGKJBKC;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public static readonly Vector2 EEGDEAEBMHD;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public static readonly Vector2 FENDOABHAOL;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public static readonly Vector2 GFDJPINFLJG;

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public static readonly Vector2 PEJLPGHJDMK;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public static readonly Vector2 LGDDNADEPDA;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public static readonly Vector2 ECBOFHALIBF;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly Vector2 EAADNIBJNFI;

	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly Vector2 OEAKIGNIINH;

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly Vector2 KOMIKDOIDBF;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7486BD0", Offset = "0x7485FD0", VA = "0x187486BD0")]
	public static Vector2 GBDOPGDLAII(FaceFeatureType FHBFDOFHNME, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x74875C0", Offset = "0x74869C0", VA = "0x1874875C0")]
	public static float LABFKAPJNJJ(FaceFeatureType FHBFDOFHNME, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x74862D0", Offset = "0x74856D0", VA = "0x1874862D0")]
	public static void COLOJGGMHAF(MDKBPDIPAFE PLKEDHAFNFH, AvatarConfiguration FDDIIONJAJJ, DIINEKIAPFE MCLGCIKONDN, DIINEKIAPFE OGGDLPACIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7487D40", Offset = "0x7487140", VA = "0x187487D40")]
	public static float PNFIOGAKOBN(FaceFeatureType NMALLOBNLKG, float EBLCHJBCPMF, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7485DC0", Offset = "0x74851C0", VA = "0x187485DC0")]
	public static float CFCFLKFOLPB(FaceFeatureType NMALLOBNLKG, float JFONOIBEFKK, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x74879D0", Offset = "0x7486DD0", VA = "0x1874879D0")]
	public static Vector2 MODIPKHHINL(FaceFeatureType NMALLOBNLKG, Vector2 JEEPPACFOCD, Vector2 FOGHNDMGKIC, Vector2 COMNAGONLMP, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7487120", Offset = "0x7486520", VA = "0x187487120")]
	public static Vector2 JKOPGICJMOB(FaceFeatureType NMALLOBNLKG, Vector2 DPHJFNLKJME, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x74868F0", Offset = "0x7485CF0", VA = "0x1874868F0")]
	private static Vector2 ELFPBMLCIIP(FaceFeatureType NMALLOBNLKG, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7486500", Offset = "0x7485900", VA = "0x187486500")]
	private static Vector2 DOJGOCMCMDO(FaceFeatureType NMALLOBNLKG, Vector2 JEEPPACFOCD, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7485E50", Offset = "0x7485250", VA = "0x187485E50")]
	public static Vector2 COBPGMCNDHM(FaceFeatureType NMALLOBNLKG, Vector2 DPHJFNLKJME, Vector2 FOGHNDMGKIC, Vector2 COMNAGONLMP, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x74866D0", Offset = "0x7485AD0", VA = "0x1874866D0")]
	public static float EFHLDKBPGOF(FaceFeatureType NMALLOBNLKG, float JFONOIBEFKK, DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7487820", Offset = "0x7486C20", VA = "0x187487820")]
	private static float LPFHMCDGAGF(float IKENCPHIKGM, float MNJHKANCBHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x74878B0", Offset = "0x7486CB0", VA = "0x1874878B0")]
	private static Vector2 MADBAHAGHPC(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7486EF0", Offset = "0x74862F0", VA = "0x187486EF0")]
	private static Vector2 JCEGCHKNFKH(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7487BD0", Offset = "0x7486FD0", VA = "0x187487BD0")]
	private static Vector2 OEPCECKIKCA(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7486390", Offset = "0x7485790", VA = "0x187486390")]
	private static Vector2 DKLCICPBELM(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7486E80", Offset = "0x7486280", VA = "0x187486E80")]
	private static float IFMNLLBMCMB(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x7487960", Offset = "0x7486D60", VA = "0x187487960")]
	private static float MBJFMDHGEJO(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x74877B0", Offset = "0x7486BB0", VA = "0x1874877B0")]
	private static float LKHOGGCONJP(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7487B60", Offset = "0x7486F60", VA = "0x187487B60")]
	private static float NLCCHIJOKEH(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7486A50", Offset = "0x7485E50", VA = "0x187486A50")]
	private static Vector2 FHOJIABDGBA(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7486B10", Offset = "0x7485F10", VA = "0x187486B10")]
	private static Vector2 FHPDKLBMGNA(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x7487C80", Offset = "0x7487080", VA = "0x187487C80")]
	private static Vector2 PHDNBLHHJJO(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7487060", Offset = "0x7486460", VA = "0x187487060")]
	private static Vector2 JILOALOPBFD(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7487380", Offset = "0x7486780", VA = "0x187487380")]
	private static Vector2 JMHGOMIODBB(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7486440", Offset = "0x7485840", VA = "0x187486440")]
	private static Vector2 DMFCFAFLGAG(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7487500", Offset = "0x7486900", VA = "0x187487500")]
	private static Vector2 LAALMBDLCBE(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7487AA0", Offset = "0x7486EA0", VA = "0x187487AA0")]
	private static Vector2 MPAPDKOCMCN(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x7485C40", Offset = "0x7485040", VA = "0x187485C40")]
	private static Vector2 ACKJECMGMDH(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7486FA0", Offset = "0x74863A0", VA = "0x187486FA0")]
	private static Vector2 JGLDGGPHCOC(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7485D00", Offset = "0x7485100", VA = "0x187485D00")]
	private static Vector2 BLJFNKFELJF(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7487440", Offset = "0x7486840", VA = "0x187487440")]
	private static Vector2 JOHLGDDMHEP(DIINEKIAPFE NKOMJFFJMEP, AvatarConfiguration AMOMBCNFLFB)
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
