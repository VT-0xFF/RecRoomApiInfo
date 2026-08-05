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
		[Cpp2IlInjected.Address(RVA = "0x73948B0", Offset = "0x7392EB0", VA = "0x1873948B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		public AvatarFaceShapeData.NFLOKLBCILG FaceShapeName;

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
		public AvatarBodyShapeData.BKBJCOHDGGC BodyShapeName;

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
		public EEHFKDPJPMH BodyProperty;

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
		public EHLDDELHBFB NoseType;

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
		public EEHFKDPJPMH BodyProperty;

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
		public PPBEEELJDCG BodyPropertyInfluences;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct MKHCFAMCDEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public string MPOOIKLEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public Vector3 KOHIGCEHKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Vector3 JLKJILMAJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Vector3 JCCHJCKKHHO;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[Flags]
public enum PPBEEELJDCG
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
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class AAGOCFDFIBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public AAGOCFDFIBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7394150", Offset = "0x7392750", VA = "0x187394150")]
			internal bool AEFPDIMCMNI(KeyValuePair<string, Transform> bone)
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
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private List<AvatarHeadShapeBoneData> headShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private List<AvatarBodyPropertyBoneData> bodyPropertyBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private List<AvatarNoseTypeBoneData> noseTypeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<AvatarFaceShapeData.NFLOKLBCILG> faceShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private List<AvatarBodyShapeData.BKBJCOHDGGC> bodyShapeIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Dictionary<EEHFKDPJPMH, List<float>> bodyPropertyIncrements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<(string, AvatarFaceShapeData.NFLOKLBCILG), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<(string, AvatarBodyShapeData.BKBJCOHDGGC), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Dictionary<(string, EHLDDELHBFB), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly Dictionary<(string, EEHFKDPJPMH, float), AvatarBodyPartBoneData> bodyPropertyToBoneDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Dictionary<EEHFKDPJPMH, Dictionary<string, PPBEEELJDCG>> bodyPropertyBoneInfluenceInfoMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly List<string> headBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly List<string> noseBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Dictionary<EEHFKDPJPMH, string[]> bonesToUpdatePerProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Dictionary<string, Dictionary<PPBEEELJDCG, int>> influencesPerBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Dictionary<string, Dictionary<PPBEEELJDCG, int>> trackedInfluencesPerBone;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAE920", Offset = "0xAACF20", VA = "0x180AAE920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xAE45B0", Offset = "0xAE2BB0", VA = "0x180AE45B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x73970B0", Offset = "0x73956B0", VA = "0x1873970B0")]
		public void HPHCPPKCEKM(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x73987D0", Offset = "0x7396DD0", VA = "0x1873987D0")]
		public void JMLGLKIHGHG(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, AvatarFaceShapeData.NFLOKLBCILG NGODEJMKEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7398520", Offset = "0x7396B20", VA = "0x187398520")]
		public void JIJAABBPHMI(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7396160", Offset = "0x7394760", VA = "0x187396160")]
		public void DMLNOCMHAJD(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, EHLDDELHBFB DIKOIBEAEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7398AD0", Offset = "0x73970D0", VA = "0x187398AD0")]
		public void KCCKDLJJDAA(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, AvatarBodyShapeData.BKBJCOHDGGC LJFANJBKMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x73999A0", Offset = "0x7397FA0", VA = "0x1873999A0")]
		public void PINMCLDJBMI(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, IReadOnlyDictionary<string, MKHCFAMCDEP> JLDPAJLEAKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7394A40", Offset = "0x7393040", VA = "0x187394A40")]
		public IReadOnlyDictionary<string, MKHCFAMCDEP> BFEIMJAKPLJ(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x73967C0", Offset = "0x7394DC0", VA = "0x1873967C0")]
		public IReadOnlyDictionary<string, MKHCFAMCDEP> GNBNDALMMIB(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, IReadOnlyDictionary<EEHFKDPJPMH, float> HPGJHEIPONK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7394D90", Offset = "0x7393390", VA = "0x187394D90")]
		public float CCINMEKELPO(EEHFKDPJPMH BBBFKIMAKIC, float CENBIHHGGBH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7398E30", Offset = "0x7397430", VA = "0x187398E30")]
		private float KOECIHNKBOL(float KBGCCIOIGBD, List<float> HECMPMHLPEN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7397040", Offset = "0x7395640", VA = "0x187397040")]
		private Vector3 HIDGNCFIHKF(Transform JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7398DD0", Offset = "0x73973D0", VA = "0x187398DD0")]
		private Quaternion KFMPNNAHECA(Transform JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7396580", Offset = "0x7394B80", VA = "0x187396580")]
		private Vector3 EBEOEDAEPOI(Transform JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7398F30", Offset = "0x7397530", VA = "0x187398F30")]
		private void MCJHCKHCJEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x65FC680", Offset = "0x65FAC80", VA = "0x1865FC680")]
		public bool JLEANPJGODL(PPBEEELJDCG NBAJCPGLLAE, PPBEEELJDCG PDOBKDCLHLF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7394F10", Offset = "0x7393510", VA = "0x187394F10")]
		private MKHCFAMCDEP CJEFHICIIFB(EEHFKDPJPMH BBBFKIMAKIC, PPBEEELJDCG LMCMIOECPPL, MKHCFAMCDEP JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM)
		{
			return default(MKHCFAMCDEP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7399D00", Offset = "0x7398300", VA = "0x187399D00")]
		public Dictionary<string, MKHCFAMCDEP> PMCCMDPBLMI(Dictionary<string, MKHCFAMCDEP> HOEOBBOAPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x73965F0", Offset = "0x7394BF0", VA = "0x1873965F0")]
		private void FPGPGEJKHEK(Transform JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM, bool LLHHMGICGLH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x739A550", Offset = "0x7398B50", VA = "0x18739A550")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarBodyPropertyBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EEHFKDPJPMH BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float BodyPropertyValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x739ABE0", Offset = "0x73991E0", VA = "0x18739ABE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AvatarBodyPropertyBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum BKBJCOHDGGC
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			Pear = 1,
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			Apple = 2,
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			Triangle = 3,
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			Hourglass = 4,
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			Square = 5,
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			Thin = 200
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public BKBJCOHDGGC blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Obsolete("Use BodyShapeId instead!")]
		[SerializeField]
		[HideInInspector]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private AvatarBodyShapeData.BKBJCOHDGGC blendShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BLMLNFKIBJD BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1BA0790", Offset = "0x1B9ED90", VA = "0x181BA0790")]
			get
			{
				return default(BLMLNFKIBJD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AvatarBodyShapeData.BKBJCOHDGGC BlendShapeName
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9612B0", Offset = "0x95F8B0", VA = "0x1809612B0")]
			get
			{
				return default(AvatarBodyShapeData.BKBJCOHDGGC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x739B6A0", Offset = "0x7399CA0", VA = "0x18739B6A0")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AvatarBodyShapeData.BKBJCOHDGGC BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x739AF00", Offset = "0x7399500", VA = "0x18739AF00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Dictionary<BLMLNFKIBJD, AvatarBodyShape> NHJJNAJDHHN;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x739B180", Offset = "0x7399780", VA = "0x18739B180")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x739B4A0", Offset = "0x7399AA0", VA = "0x18739B4A0")]
		public AvatarBodyShape Find(BLMLNFKIBJD KIFIPJGPKEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x739B5B0", Offset = "0x7399BB0", VA = "0x18739B5B0")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x739B570", Offset = "0x7399B70", VA = "0x18739B570")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x739B5F0", Offset = "0x7399BF0", VA = "0x18739B5F0")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class IBIDNIBEJMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Transform[] BFCLLDAIHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Dictionary<string, Transform> PKLAFHEMBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Dictionary<Transform, Transform> GHNLEDLOAML;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyDictionary<string, Transform> AFGDHOGDDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Transform[] GMLOJIKNGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x73A3B40", Offset = "0x73A2140", VA = "0x1873A3B40")]
	public void CDDHHLBDFEF(Transform LGGNMPJPOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73A3A60", Offset = "0x73A2060", VA = "0x1873A3A60")]
	public Transform BNLLKCELJEE(Transform AEDHAGPDFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x73A3C20", Offset = "0x73A2220", VA = "0x1873A3C20")]
	public void MPIKIGCJEGP(SkinnedMeshRenderer HNDGMCCOEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x73A3900", Offset = "0x73A1F00", VA = "0x1873A3900")]
	private static void ALHHHCILINH(Transform JGHOOBNHEJB, List<Transform> BLNGGKCOHMF, Dictionary<string, Transform> MKBEILKPCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x73A3E60", Offset = "0x73A2460", VA = "0x1873A3E60")]
	public IBIDNIBEJMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HNNBNAMEAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool JPKLPNCGKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public bool PHGHEPMAOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool KBFCCJKJOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public EJPJNNNFMKK? HHJFAEMPNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public KBAIGJMAONF.FALICHFPADL KBCMAIHKKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public HairData GHPCGDIPDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public AdditionalHatData EHFIOFKPCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool NJDLINEDOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public bool HJHHFNGPPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public bool IANIGHDOMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public IList<LJKKDAKGHIG> ELIADNLOLEN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public HNNBNAMEAIG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("How far apart you can position your eyebrows.")]
		[Header("Face Features")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Header("Hand Animation")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Header("Body Shapes")]
		public BodyShapeConfiguration BodyShapeConfiguration;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x739B730", Offset = "0x7399D30", VA = "0x18739B730")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class AAPPGJCIKLP
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static CNLEJDKNKDJ FJPNCKNOMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x73941B0", Offset = "0x73927B0", VA = "0x1873941B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static KOIFPCMFICK JHEPIBOKGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7394210", Offset = "0x7392810", VA = "0x187394210")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct CFPFBPBKEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Transform BBILCLIAPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public AvatarSkinAssetItem KHDEMFLKOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public AssetReference PMGPBEGOELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public GameObject DOPHPCCIDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public GameObject JBPJAGKJNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public SkinnedMeshRenderer OADHGANNGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public AvatarSkinnedMeshBoneOrderRemapsData KLKLHKHAINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Material MCMDMIJFAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Material IJMPGGGCFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Material FJNGKPMECND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public Shader NBPAFPLLKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public Shader MOKAMMOGEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public Animator GFLIONDIOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public Renderer[] CGLEAOIICHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public AvatarConfiguration PAKNPOKDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public AvatarBodyPartShapesManager IGBPPDODNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public IReadOnlyDictionary<string, Transform> ALCMHLGIDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Transform MFNCOHHLEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public PKOOKMMPLDP MFJBHKOKOAD;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct ADGPJAEELJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public SkinnedMeshRenderer[] ECEADLHIGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public SkinnedMeshRenderer[] ELCODDGGEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public SkinnedMeshRenderer[] BAOOOBJKGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public SkinnedMeshRenderer[] LMMKBPLFEKI;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HCEOCPHCBKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Transform PDGHOKLMBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public Transform BIFBLJNMKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public Transform GHOHCBECAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public Transform LAAOCFMGFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public Transform ADCJOFOCKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Transform GCJOIHOIHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public Transform ONKMNKKHAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public AvatarConfiguration PAKNPOKDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public PKOOKMMPLDP MFJBHKOKOAD;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EBEGNBNODAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public SkinnedMeshRenderer[] LCDDCKKIAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public Material BHJJGIONPII;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct LJHCODOFFPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public JCJBPDFIOHA FJJPIOPJPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public int JELDLDKBAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public int ODNAMKAIMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public Color MBJDFLMJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public Color MLGCPIBMLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public int KBHMCLLFJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public int JPDICELGGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public Color FMPDKKNHEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public Color GEFGOGKLOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public int GNKMHMMJOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public float LFJDFPKIODO;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct KJFGCCOFHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public JCJBPDFIOHA FJJPIOPJPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public Vector2 KGGGEEJADDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public float CPMMDJCPLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Vector2 OMFBECGCKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public float JLCDMPLBLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public Vector2 OKLHJJKIPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public float AINNICNBACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public Vector2 ONJJJPBBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public float ONMCMKANLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public bool LAAPKDCPJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public bool HGONKNJJIIG;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum NFLOKLBCILG
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NFLOKLBCILG blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[HideInInspector]
		[Obsolete("Use FaceShapeId instead!")]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BFBNNFENAIB FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1BA0790", Offset = "0x1B9ED90", VA = "0x181BA0790")]
			get
			{
				return default(BFBNNFENAIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x739C480", Offset = "0x739AA80", VA = "0x18739C480", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x739C4E0", Offset = "0x739AAE0", VA = "0x18739C4E0")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AvatarFaceShapeData.NFLOKLBCILG FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x739BCE0", Offset = "0x739A2E0", VA = "0x18739BCE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Dictionary<BFBNNFENAIB, AvatarFaceShape> NHJJNAJDHHN;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x739BF60", Offset = "0x739A560", VA = "0x18739BF60")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x739C280", Offset = "0x739A880", VA = "0x18739C280")]
		public AvatarFaceShape Find(BFBNNFENAIB NHHOCAJPOEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x739C390", Offset = "0x739A990", VA = "0x18739C390")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x739C350", Offset = "0x739A950", VA = "0x18739C350")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x739C3D0", Offset = "0x739A9D0", VA = "0x18739C3D0")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x739CB40", Offset = "0x739B140", VA = "0x18739CB40")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ICPMIFBJODI HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1BA0790", Offset = "0x1B9ED90", VA = "0x181BA0790")]
			get
			{
				return default(ICPMIFBJODI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x950FD0", VA = "0x1809529D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAE920", Offset = "0xAACF20", VA = "0x180AAE920")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAE45B0", Offset = "0xAE2BB0", VA = "0x180AE45B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x739CD40", Offset = "0x739B340", VA = "0x18739CD40")]
		public Texture2D JBMNAJKBDJF(HairPatternStyle OGGFIINOGPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x739CC40", Offset = "0x739B240", VA = "0x18739CC40", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x739CBD0", Offset = "0x739B1D0", VA = "0x18739CBD0", Slot = "4")]
		public bool Equals(AvatarHairPattern OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x739CE90", Offset = "0x739B490", VA = "0x18739CE90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x739CD00", Offset = "0x739B300", VA = "0x18739CD00", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x739CD10", Offset = "0x739B310", VA = "0x18739CD10")]
		public static bool HKDAGECLGLD(AvatarHairPattern CLHNCHKFPON, AvatarHairPattern KMNANLEEDKO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x739CB50", Offset = "0x739B150", VA = "0x18739CB50")]
		public static bool BFIJCNNIIMH(AvatarHairPattern CLHNCHKFPON, AvatarHairPattern KMNANLEEDKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x739CED0", Offset = "0x739B4D0", VA = "0x18739CED0")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum BKMINCPGJKF
{
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Idle,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Invisible,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	Pointing,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	TPose,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	ThumbUp,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	HandShake,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Grabbing,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	NumStates
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum BDFIOIHGFPK
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	ThumbUp = 1,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Pointing = 2,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	HandShake = 4
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public struct IGLCKFKINMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Animator IPIELEIMEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public ALIFPIFLCBK GAMFGKJDOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public AvatarConfiguration PAKNPOKDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public GameObject CGBDHJPPPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public PKOOKMMPLDP MFJBHKOKOAD;
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct EJIHPHLOCCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public Transform LCILNIGDBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool MNKDJKJBMEJ;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x739CFE0", Offset = "0x739B5E0", VA = "0x18739CFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LJKKDAKGHIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public string OPDMIMOEGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public OutfitType DEKKOCCMKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public OBJHNMCDGDL CHEMOMFDFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public KBAIGJMAONF.FALICHFPADL LIAFJEDKOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool ADGHOEBGMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool EFDFBCJHFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public bool EDHJBEGLBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public Color? DBFOGHLDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool JKNPCHFFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Color? KFFCMLMCCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool LEBJFGDDIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x59")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool PHFBELMLHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5A")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool EGEEBMKALDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public Transform DMNLMOAADAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public Vector2? EPJFOIELPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public FitMeshHemisphere ALEDOCHIIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public AssetReference LMDMGMLONEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public AssetReference ACDEDFBKHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public AssetReference[] KCBICLMLGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public LJKKDAKGHIG KMBBLDJDNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool BHIOIBCKAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool LEPPAAICBBC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public string BAFPMMNNIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x73A5E60", Offset = "0x73A4460", VA = "0x1873A5E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x73A5E60", Offset = "0x73A4460", VA = "0x1873A5E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73A5F10", Offset = "0x73A4510", VA = "0x1873A5F10")]
	public LJKKDAKGHIG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private JECAOCDPOGB? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public MCCAPFKCCCM CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x739D580", Offset = "0x739BB80", VA = "0x18739D580")]
			get
			{
				return default(MCCAPFKCCCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JECAOCDPOGB MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x739D5B0", Offset = "0x739BBB0", VA = "0x18739D5B0")]
			get
			{
				return default(JECAOCDPOGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x956CC0", Offset = "0x9552C0", VA = "0x180956CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x739D070", Offset = "0x739B670", VA = "0x18739D070")]
		public Material[] BNEKEDBACGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x739D310", Offset = "0x739B910", VA = "0x18739D310")]
		public static void PJDFKOKDEGD(AvatarItemMaterial GLLPIKAAACI, Material HJCEHLILOIG, int CLLOKPKIGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x739D160", Offset = "0x739B760", VA = "0x18739D160")]
		private static bool OHCPPADPLFE(AvatarItemMaterial GLLPIKAAACI, int CLLOKPKIGEH, [Out] Material DOLKEGANOCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x739D500", Offset = "0x739BB00", VA = "0x18739D500")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class KIFHJDJPHPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public SkinnedMeshRenderer FIGEBICLGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Material[] NNLECGFCFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private byte[] OKBKNCOIOKL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh KFDGIAJINED
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x73A5680", Offset = "0x73A3C80", VA = "0x1873A5680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Material[] KNEEJKFKEII
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte[] IKOHCDKNDLL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x73A56A0", Offset = "0x73A3CA0", VA = "0x1873A56A0")]
	public KIFHJDJPHPE(SkinnedMeshRenderer BNBIMMBDEGH, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, Material[] GDFHBJLKHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x73A54E0", Offset = "0x73A3AE0", VA = "0x1873A54E0")]
	public static KIFHJDJPHPE DBGIJHFGGDN(Renderer EHMEICJAGNO, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, Material[] GDFHBJLKHMG)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1249A10", Offset = "0x1248010", VA = "0x181249A10")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xAE4160", Offset = "0xAE2760", VA = "0x180AE4160")]
		public void ECFLGDLFBIO(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KBKPAOPPIKM
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x73A5220", Offset = "0x73A3820", VA = "0x1873A5220")]
	public static PositionAndRotation GDOFOCGAAIL(this PositionAndRotation CHFLFONLLOP)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x73A5100", Offset = "0x73A3700", VA = "0x1873A5100")]
	public static float CINANEJNNFN(float CHBEBLKFDBC, Vector2 APGJDJPACGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x73A51A0", Offset = "0x73A37A0", VA = "0x1873A51A0")]
	public static float CINANEJNNFN(float CHBEBLKFDBC, float CDIPILBCKFB, float MJPJCMEJEPK, float HCEBABCAMLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x73A5370", Offset = "0x73A3970", VA = "0x1873A5370")]
	public static float IJNOLFNAGPB(float KBGCCIOIGBD, Vector2 APGJDJPACGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73A5430", Offset = "0x73A3A30", VA = "0x1873A5430")]
	public static float IJNOLFNAGPB(float KBGCCIOIGBD, float CDIPILBCKFB, float MJPJCMEJEPK, float HCEBABCAMLE)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public EHLDDELHBFB NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x739D670", Offset = "0x739BC70", VA = "0x18739D670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public enum FKMNECDKODO
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum IFFGGLLHIDG
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	IdleSwayAimWeapon,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	IdleSwayMeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	IdleSwayLightItem,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	IdleSwayHeavyItem,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	IdleSwayAimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	FastAction,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	NumTypes
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum IIFAJIGINPD
{
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	PotatoAvatar,
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	FullOutfitAvatar
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct PJLHDFEOPIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public Vector2 HNPAKEGDHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public Vector2 HBJLONKDBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public Vector2 ECGDGHKMFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Vector2 GOBPDGPCJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Vector2 JEFLIPNIFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Vector2 IGPIIDPKKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Vector2 DOKHFAIPLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public Vector2 GKNGJAFIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public Vector2 DHAEGFBFMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public Vector2 KFAKDAJHBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public Vector2 KBJPLLDJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	public Vector2 KFKLDFNBOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	public Vector2 DIIIAPCLIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public Vector2 FIKKPPNNDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public Vector2 ANDDBHKPMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public Vector2 AMBNKDINCBD;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class LDGJBAOONFM
{
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public static readonly int LEOLKEGHAPF;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public static readonly string BNKMDADMHIF;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x73A5A20", Offset = "0x73A4020", VA = "0x1873A5A20")]
	public static CFPFBPBKEJA IDPNFHONODB(Transform JFFOPKNCHML, AvatarSkinAssetItem NKOJECCKCBD, AssetReference CEFBPHKNGKO, GameObject DFNDDNMADAP, GameObject JKOKIJCNEIK, SkinnedMeshRenderer DIJFOFCCPHI, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, Material FOIGNFEPFGI, Material OBOFBCJMFHP, Material JIMPKGMGNKH, Shader OEEENOBJCHB, Shader KLLALGPLCJG, Animator CMDMCGFLDIH, Renderer[] CEDAKEBLNNI, AvatarConfiguration BFMGDLDGOKJ, AvatarBodyPartShapesManager IAIJGBADCHE, IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, Transform HANDMKOOGJF, PKOOKMMPLDP HMKELMICGGI)
	{
		return default(CFPFBPBKEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x73A5D60", Offset = "0x73A4360", VA = "0x1873A5D60")]
	public static ADGPJAEELJF PNFNAGCFNDC(SkinnedMeshRenderer[] HBOFPICJAKO, SkinnedMeshRenderer[] MLJIHOJBBAA, SkinnedMeshRenderer[] MJHKCDPIMDJ, SkinnedMeshRenderer[] BDBLKOJGMMO)
	{
		return default(ADGPJAEELJF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x73A5BE0", Offset = "0x73A41E0", VA = "0x1873A5BE0")]
	public static HCEOCPHCBKP JJOGFMCHKJF(Transform FFFNDEIPNLL, Transform LHDKDPDANJD, Transform BCOMCAAOCPC, Transform LJHEAHPOLJB, Transform PIFIEIMDDOL, Transform GEKEPNHNBDI, Transform NICEKCIJKAG, AvatarConfiguration DJCGLEJFHCA, PKOOKMMPLDP HMKELMICGGI)
	{
		return default(HCEOCPHCBKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x25B94A0", Offset = "0x25B7AA0", VA = "0x1825B94A0")]
	public static EBEGNBNODAH JLPIBMMFCMI(SkinnedMeshRenderer[] JCOKBIONLJH, Material NHBABBDAMAE)
	{
		return default(EBEGNBNODAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x73A5CC0", Offset = "0x73A42C0", VA = "0x1873A5CC0")]
	public static LJHCODOFFPO LMJEKOFPCOC(JCJBPDFIOHA DCNNPFLFEKE, int COAEBLGAJNF, int CBEFCPHNIMH, Color PFNEGPFPGNG, Color OBBNAHOPCCA, int MDNDPLDNJEG, int CJKKOAAFKGD, Color CMOIMNFIKPL, Color MKEBEJDDGJJ, int NOGGIMHDECG)
	{
		return default(LJHCODOFFPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x73A58B0", Offset = "0x73A3EB0", VA = "0x1873A58B0")]
	public static KJFGCCOFHCI AFDFFNFELIK(JCJBPDFIOHA DCNNPFLFEKE, Vector2 FCJEMCDEIMF, float BOFGEKFBCFI, Vector2 IGKLIJOGCBM, float IBEBPGOENLH, Vector2 JNINICKAAEA, float HIALDNCJNLM, Vector2 JDEPBGGCMIO, float BANHHPCIFGF)
	{
		return default(KJFGCCOFHCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x73A59A0", Offset = "0x73A3FA0", VA = "0x1873A59A0")]
	public static IGLCKFKINMF DCFKHDKDKHK(Animator IEACKBDAGDE, ALIFPIFLCBK JEGNMOJFJKJ, AvatarConfiguration BFMGDLDGOKJ, GameObject LMHFBDJLIFM, PKOOKMMPLDP HMKELMICGGI)
	{
		return default(IGLCKFKINMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x73A5960", Offset = "0x73A3F60", VA = "0x1873A5960")]
	public static EJIHPHLOCCI BCOPMAMIPGB(Transform HICHCPBOIPK, bool KAHLIPACLNH)
	{
		return default(EJIHPHLOCCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NJMMFMFNAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x73A5F30", Offset = "0x73A4530", VA = "0x1873A5F30")]
	public static BKMINCPGJKF LDIFGIHPLHP(this FKMNECDKODO CCGJGKICAMO)
	{
		return default(BKMINCPGJKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x73A5F20", Offset = "0x73A4520", VA = "0x1873A5F20")]
	public static bool BMCCNMFPLKF(this FKMNECDKODO DEJCMGKBJMI)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public enum MBKPHICBOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BodySkinnedMeshLODs LILHAJIEIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BodySkinnedMeshLODs CFAEMADEJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public BodySkinnedMeshLODs EIILPLHJCJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public BodySkinnedMeshLODs KAAGKHMMBAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x739D8F0", Offset = "0x739BEF0", VA = "0x18739D8F0")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(MBKPHICBOOJ GHHKFIEAPCG, [Optional] EJPJNNNFMKK? IFJJNEIHMGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class DHHBLADBGEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public DHHBLADBGEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x739ECB0", Offset = "0x739D2B0", VA = "0x18739ECB0")]
			internal bool FBNIKMLLJOM(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x739DAF0", Offset = "0x739C0F0", VA = "0x18739DAF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x739DAF0", Offset = "0x739C0F0", VA = "0x18739DAF0")]
		private void JPDALOEPCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x739E560", Offset = "0x739CB60", VA = "0x18739E560")]
		private void PMBMMACDLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x739DA80", Offset = "0x739C080", VA = "0x18739DA80")]
		public byte[] DBOKGCAPEMC(string BKHIEFINECL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x739DB00", Offset = "0x739C100", VA = "0x18739DB00")]
		public bool LCJOBKNOFFP(SkinnedMeshBoneOrderData BOBOFPBGJPB, AvatarSkinnedMeshBonesController KAPENEPPGKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x739E720", Offset = "0x739CD20", VA = "0x18739E720")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class ONAMCNJKKBA
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public struct NNGCLJFCINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public Transform[] GMLOJIKNGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Matrix4x4[] NPKOJEOEIDO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public static readonly string CAHKGEPCIKK;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x73A5F80", Offset = "0x73A4580", VA = "0x1873A5F80")]
	public static byte[] GIKKHKKCPEJ(AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, SkinnedMeshRenderer HNDGMCCOEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73A6070", Offset = "0x73A4670", VA = "0x1873A6070")]
	public static NNGCLJFCINI? MDCPMPOOBFM(AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, SkinnedMeshRenderer HNDGMCCOEDJ)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[ReadOnlyField]
		[SerializeField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string GBHGCGOOHGF
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x739E7F0", Offset = "0x739CDF0", VA = "0x18739E7F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x739EB70", Offset = "0x739D170", VA = "0x18739EB70")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x739EB80", Offset = "0x739D180", VA = "0x18739EB80")]
		private void PMBMMACDLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x739E820", Offset = "0x739CE20", VA = "0x18739E820")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x739E880", Offset = "0x739CE80", VA = "0x18739E880")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer EHMEICJAGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public enum EEHFKDPJPMH
{
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	BicepWidth,
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	ForearmWidth,
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	ChestSize,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	ChestOut,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	WaistSize,
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	HipWidth,
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	NeckLength,
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	NeckThickness,
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	ThighWidth,
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	CalfWidth,
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	FootWidth,
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	FootSize,
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	ShoulderWidth,
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	BellyOut
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class BFADENHOLDI
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x739EC40", Offset = "0x739D240", VA = "0x18739EC40")]
	public static bool JKCIEAECONC(this EEHFKDPJPMH BBBFKIMAKIC)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class BodyShapeConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private List<BodyShapePropertyData> BodyShapePropertyData;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public List<BodyShapePropertyData> AllBodyShapePropertyData
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xA447A0", Offset = "0xA42DA0", VA = "0x180A447A0")]
		public BodyShapeConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public struct BodyShapePropertyData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AvatarBodyShapeData.BKBJCOHDGGC BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public List<BodyPropertySliderData> BodyPropertyValues;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct BodyPropertySliderData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public EEHFKDPJPMH BodyProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public float SliderValue;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public enum OOGJIEHIMKJ
{
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class IKKEFGFKHCN
{
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public static readonly IKKEFGFKHCN MPDPNCAPBBE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int ONPHMDAKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public OOGJIEHIMKJ JOJGPIHLEPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA35E20", Offset = "0xA34420", VA = "0x180A35E20")]
		[CompilerGenerated]
		get
		{
			return default(OOGJIEHIMKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAF2900", Offset = "0xAF0F00", VA = "0x180AF2900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public IKKEFGFKHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x2BF6FD0", Offset = "0x2BF55D0", VA = "0x182BF6FD0")]
	public IKKEFGFKHCN(OOGJIEHIMKJ OALDHMLLKME, int OENLDFNIJMF)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x73A06A0", Offset = "0x739ECA0", VA = "0x1873A06A0")]
		public void DrawPosition(bool IMLBMCFLIEF, Transform EJNLPEDOMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x73A0740", Offset = "0x739ED40", VA = "0x1873A0740")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere HANEBACCPJP, Transform LDIAONMHHPK, Vector2 CCBMCEOJMOG, AnchorParamsRestrictions HBMDEFKGEPA, bool PCBAHHLCABJ = false, bool GCOHCEJDPBK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
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

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x73A65E0", Offset = "0x73A4BE0", VA = "0x1873A65E0")]
		public void HOIGNPKMANP(SkinnedMeshRenderer HNDGMCCOEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x73A6790", Offset = "0x73A4D90", VA = "0x1873A6790")]
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
		[SerializeField]
		[Header("Remapping Mouth Data")]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x739C530", Offset = "0x739AB30", VA = "0x18739C530")]
		public void PPJBOJMBFLL(FOGFGJADBEA MMOKANOMMLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x739CA20", Offset = "0x739B020", VA = "0x18739CA20")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA57410", Offset = "0xA55A10", VA = "0x180A57410", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x739ECA0", Offset = "0x739D2A0", VA = "0x18739ECA0")]
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

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x951A70", Offset = "0x950070", VA = "0x180951A70", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x739F0F0", Offset = "0x739D6F0", VA = "0x18739F0F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x739F150", Offset = "0x739D750", VA = "0x18739F150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x739F110", Offset = "0x739D710", VA = "0x18739F110")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7157660", Offset = "0x7155C60", VA = "0x187157660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x739F130", Offset = "0x739D730", VA = "0x18739F130")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x23F7390", Offset = "0x23F5990", VA = "0x1823F7390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x1B58400", Offset = "0x1B56A00", VA = "0x181B58400")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x739F160", Offset = "0x739D760", VA = "0x18739F160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x739ECE0", Offset = "0x739D2E0", VA = "0x18739ECE0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x739EFE0", Offset = "0x739D5E0", VA = "0x18739EFE0")]
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

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x739FC00", Offset = "0x739E200", VA = "0x18739FC00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x175EDD0", Offset = "0x175D3D0", VA = "0x18175EDD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x12E7800", Offset = "0x12E5E00", VA = "0x1812E7800")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x175C310", Offset = "0x175A910", VA = "0x18175C310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x739F9C0", Offset = "0x739DFC0", VA = "0x18739F9C0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x739FB00", Offset = "0x739E100", VA = "0x18739FB00")]
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

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x73A6B80", Offset = "0x73A5180", VA = "0x1873A6B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x73A7810", Offset = "0x73A5E10", VA = "0x1873A7810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private readonly List<EBHOPDBMNPK<Sprite>> _spriteResourceHandles;

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

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x956D00", Offset = "0x955300", VA = "0x180956D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x956AE0", Offset = "0x9550E0", VA = "0x180956AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x739F910", Offset = "0x739DF10", VA = "0x18739F910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x739F980", Offset = "0x739DF80", VA = "0x18739F980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x739F8A0", Offset = "0x739DEA0", VA = "0x18739F8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x739F8F0", Offset = "0x739DEF0", VA = "0x18739F8F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6869200", Offset = "0x6867800", VA = "0x186869200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x739F380", Offset = "0x739D980", VA = "0x18739F380")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x739F4C0", Offset = "0x739DAC0", VA = "0x18739F4C0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x739F3F0", Offset = "0x739D9F0", VA = "0x18739F3F0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x739F5A0", Offset = "0x739DBA0", VA = "0x18739F5A0")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x739F170", Offset = "0x739D770", VA = "0x18739F170")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x739F6A0", Offset = "0x739DCA0", VA = "0x18739F6A0")]
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
public sealed class JCJBPDFIOHA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct HABICIMJLIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<JCJBPDFIOHA> <>t__builder;

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
		private ANEFDAMIPJL.DDJIBKGDJKD <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x73A3060", Offset = "0x73A1660", VA = "0x1873A3060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x73A3890", Offset = "0x73A1E90", VA = "0x1873A3890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Dictionary<string, int> LOFNKLJGBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool KJIGGBNHALH;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Texture2DArray FBCDPMAMFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public SymmetricalFaceFeature GBMGHNNCNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public EyesFaceFeature HLFFGADKJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9527E0", Offset = "0x950DE0", VA = "0x1809527E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FaceFeature FNDKMNFKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x73A41C0", Offset = "0x73A27C0", VA = "0x1873A41C0")]
	private static void GDFEAFNOLLP(Sprite HPPCDBBBHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x73A4230", Offset = "0x73A2830", VA = "0x1873A4230")]
	public static JCJBPDFIOHA JGFEECJHJKJ(SymmetricalFaceFeature MCHPFJOOKHO, EyesFaceFeature FOPODPFDCII, FaceFeature JJAKFIIKPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x73A4B10", Offset = "0x73A3110", VA = "0x1873A4B10")]
	[AsyncStateMachine(typeof(HABICIMJLIF))]
	public static Task<JCJBPDFIOHA> MOGFBDKKLAL(SymmetricalFaceFeature MCHPFJOOKHO, EyesFaceFeature FOPODPFDCII, FaceFeature JJAKFIIKPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x73A4C50", Offset = "0x73A3250", VA = "0x1873A4C50")]
	private JCJBPDFIOHA(SymmetricalFaceFeature MCHPFJOOKHO, EyesFaceFeature FOPODPFDCII, FaceFeature JJAKFIIKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x73A43B0", Offset = "0x73A29B0", VA = "0x1873A43B0")]
	private void LDEJBMGKPCE(List<Sprite> GAKECAHAAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x73A42C0", Offset = "0x73A28C0", VA = "0x1873A42C0")]
	public bool KCLNGNJBOKN(string BHDEFAKNALA, [Out] int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x73A4190", Offset = "0x73A2790", VA = "0x1873A4190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x73A4080", Offset = "0x73A2680", VA = "0x1873A4080")]
	public bool DLCFPDABHIK(bool KCPMDDJGIJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x73A3FB0", Offset = "0x73A25B0", VA = "0x1873A3FB0")]
	public void AKMEBJCGOMI()
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
		private struct AJDEFLCAPJB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public AsyncTaskMethodBuilder<JCJBPDFIOHA> <>t__builder;

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
			private TaskAwaiter<JCJBPDFIOHA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7394340", Offset = "0x7392940", VA = "0x187394340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7394840", Offset = "0x7392E40", VA = "0x187394840", Slot = "5")]
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
		private Dictionary<EJPJNNNFMKK, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private Dictionary<EJPJNNNFMKK, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private Dictionary<EJPJNNNFMKK, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private Dictionary<EJPJNNNFMKK, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private readonly Dictionary<EJPJNNNFMKK, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private JCJBPDFIOHA _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private JCJBPDFIOHA _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x73A0670", Offset = "0x739EC70", VA = "0x1873A0670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x73A0000", Offset = "0x739E600", VA = "0x1873A0000")]
		public JCJBPDFIOHA JAMPDJANBKD(PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x739FC20", Offset = "0x739E220", VA = "0x18739FC20")]
		[AsyncStateMachine(typeof(AJDEFLCAPJB))]
		public Task<JCJBPDFIOHA> ADPMBGIHOMN(int? JHIBJCEFAPK, int FOPODPFDCII, int JJAKFIIKPIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x73A0320", Offset = "0x739E920", VA = "0x1873A0320")]
		public NoseFaceOption ODNHNHKGLDJ(int ABGHCCKGPOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x73A03C0", Offset = "0x739E9C0", VA = "0x1873A03C0")]
		public SelectableFaceOption PBMDEMBNDJB(FaceFeatureType EFKOOGECDHL, EJPJNNNFMKK EKOKNCCJHCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x739FD50", Offset = "0x739E350", VA = "0x18739FD50")]
		public int AOCOKIJDFEF(EJPJNNNFMKK EKOKNCCJHCA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x739FDD0", Offset = "0x739E3D0", VA = "0x18739FDD0")]
		private void DGNGLBLNCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x33C79D0", Offset = "0x33C5FD0", VA = "0x1833C79D0")]
		private void DMFEBJLGKDP<T>(IDictionary<EJPJNNNFMKK, T> EIEEOCBNIGD, IReadOnlyList<T> PHPDPFNNCJH) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x73A0210", Offset = "0x739E810", VA = "0x1873A0210")]
		public EJPJNNNFMKK NCHNHFBMADF(FaceFeatureType EFKOOGECDHL)
		{
			return default(EJPJNNNFMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x73A0090", Offset = "0x739E690", VA = "0x1873A0090")]
		public EJPJNNNFMKK MBEGLMLOKCJ(FaceFeatureType EFKOOGECDHL)
		{
			return default(EJPJNNNFMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x73A0540", Offset = "0x739EB40", VA = "0x1873A0540")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xA743C0", Offset = "0xA729C0", VA = "0x180A743C0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x739FB00", Offset = "0x739E100", VA = "0x18739FB00")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public EHLDDELHBFB SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA6F6D0", Offset = "0xA6DCD0", VA = "0x180A6F6D0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA447A0", Offset = "0xA42DA0", VA = "0x180A447A0")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
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

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public EJPJNNNFMKK FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1BA0790", Offset = "0x1B9ED90", VA = "0x181BA0790")]
			get
			{
				return default(EJPJNNNFMKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xC1B7C0", Offset = "0xC19DC0", VA = "0x180C1B7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x739C480", Offset = "0x739AA80", VA = "0x18739C480", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA447A0", Offset = "0xA42DA0", VA = "0x180A447A0")]
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

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x73A6B00", Offset = "0x73A5100", VA = "0x1873A6B00")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x68652F0", Offset = "0x68638F0", VA = "0x1868652F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x73A6B40", Offset = "0x73A5140", VA = "0x1873A6B40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x6865300", Offset = "0x6863900", VA = "0x186865300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x73A6B20", Offset = "0x73A5120", VA = "0x1873A6B20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6868480", Offset = "0x6866A80", VA = "0x186868480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x73A6B60", Offset = "0x73A5160", VA = "0x1873A6B60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x6868470", Offset = "0x6866A70", VA = "0x186868470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x73A6820", Offset = "0x73A4E20", VA = "0x1873A6820", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x73A6A30", Offset = "0x73A5030", VA = "0x1873A6A30")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class GNNBCDBCACO
{
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public static readonly float GFJLMJBANCL;

	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public static readonly float HFBKGENFGPM;

	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public static readonly Vector2 POCBHLDKIMP;

	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public static readonly Vector2 ADPICFBOJDP;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public static readonly Vector2 BFMCANHGABC;

	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public static readonly Vector2 NPMDJIIMGLP;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public static readonly Vector2 BOOODNDJPNH;

	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public static readonly Vector2 IKBHBMGOLDD;

	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public static readonly Vector2 OMAFFGCNOIL;

	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public static readonly Vector2 DLLBNDMKENN;

	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public static readonly Vector2 GCDCACPGFPF;

	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public static readonly Vector2 FBCAKKBGKKO;

	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public static readonly Vector2 PCMDALPCNOJ;

	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public static readonly Vector2 HMNFPJBGFEK;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x73A0D40", Offset = "0x739F340", VA = "0x1873A0D40")]
	public static Vector2 AFJMBFGFKEN(FaceFeatureType KGLDHIDPHPP, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x73A2110", Offset = "0x73A0710", VA = "0x1873A2110")]
	public static float KLFKHOGAMCL(FaceFeatureType KGLDHIDPHPP, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x73A1330", Offset = "0x739F930", VA = "0x1873A1330")]
	public static void CEFPDBINDNB(FOGFGJADBEA PPKGJMCKKFG, AvatarConfiguration BFMGDLDGOKJ, PKOOKMMPLDP GOHELOEBLHN, PKOOKMMPLDP IEHDEIFCKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x73A2300", Offset = "0x73A0900", VA = "0x1873A2300")]
	public static float KOLCABMAMBD(FaceFeatureType EFKOOGECDHL, float OIJMFADLAHH, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x73A2DA0", Offset = "0x73A13A0", VA = "0x1873A2DA0")]
	public static float POGBOGPHPAD(FaceFeatureType EFKOOGECDHL, float DHIKJADGNNJ, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x73A2C20", Offset = "0x73A1220", VA = "0x1873A2C20")]
	public static Vector2 PKFDKKENGBD(FaceFeatureType EFKOOGECDHL, Vector2 NHEABMEEBBE, Vector2 OILKJCFPEEE, Vector2 HEGCGICCMGN, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x73A1850", Offset = "0x739FE50", VA = "0x1873A1850")]
	public static Vector2 DABCIFLJCAC(FaceFeatureType EFKOOGECDHL, Vector2 ILINMNBKBOG, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x73A13F0", Offset = "0x739F9F0", VA = "0x1873A13F0")]
	private static Vector2 CLNDEBMHPOA(FaceFeatureType EFKOOGECDHL, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x73A2490", Offset = "0x73A0A90", VA = "0x1873A2490")]
	private static Vector2 NOLGFHKDFMP(FaceFeatureType EFKOOGECDHL, Vector2 NHEABMEEBBE, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x73A26D0", Offset = "0x73A0CD0", VA = "0x1873A26D0")]
	public static Vector2 PEPBOJNHKJJ(FaceFeatureType EFKOOGECDHL, Vector2 ILINMNBKBOG, Vector2 OILKJCFPEEE, Vector2 HEGCGICCMGN, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x73A0FF0", Offset = "0x739F5F0", VA = "0x1873A0FF0")]
	public static float AFPFCBMKPEE(FaceFeatureType EFKOOGECDHL, float DHIKJADGNNJ, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x73A2400", Offset = "0x73A0A00", VA = "0x1873A2400")]
	private static float NKEMHPBDCBM(float CDIPILBCKFB, float HCEBABCAMLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x73A17A0", Offset = "0x739FDA0", VA = "0x1873A17A0")]
	private static Vector2 CPEKAAJPMAG(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x73A1E70", Offset = "0x73A0470", VA = "0x1873A1E70")]
	private static Vector2 HMMDJIFPCAK(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x73A2CF0", Offset = "0x73A12F0", VA = "0x1873A2CF0")]
	private static Vector2 PODHPMEMAGO(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x73A1210", Offset = "0x739F810", VA = "0x1873A1210")]
	private static Vector2 BBDCDKHBMOC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x73A12C0", Offset = "0x739F8C0", VA = "0x1873A12C0")]
	private static float BNGBOHPNHEC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x73A1F20", Offset = "0x73A0520", VA = "0x1873A1F20")]
	private static float IDKFNKDPLJG(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x73A2660", Offset = "0x73A0C60", VA = "0x1873A2660")]
	private static float OIIAMJKFMJK(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x73A2390", Offset = "0x73A0990", VA = "0x1873A2390")]
	private static float NIMDJOPFLJP(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x73A1DB0", Offset = "0x73A03B0", VA = "0x1873A1DB0")]
	private static Vector2 GKEEGNLAKJH(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x73A1B70", Offset = "0x73A0170", VA = "0x1873A1B70")]
	private static Vector2 FFFBFKLABFH(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x73A1CF0", Offset = "0x73A02F0", VA = "0x1873A1CF0")]
	private static Vector2 GDJKPHJIACP(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x73A16E0", Offset = "0x739FCE0", VA = "0x1873A16E0")]
	private static Vector2 COMEBKPKDFK(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x73A1620", Offset = "0x739FC20", VA = "0x1873A1620")]
	private static Vector2 CNGLCCKJFNJ(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x73A1F90", Offset = "0x73A0590", VA = "0x1873A1F90")]
	private static Vector2 JHNBJDDOOIG(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x73A1560", Offset = "0x739FB60", VA = "0x1873A1560")]
	private static Vector2 CLNFHLDAGOC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x73A2B60", Offset = "0x73A1160", VA = "0x1873A2B60")]
	private static Vector2 PGBLHMDDAOC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x73A2050", Offset = "0x73A0650", VA = "0x1873A2050")]
	private static Vector2 JNAGOGIAPFN(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x73A1AB0", Offset = "0x73A00B0", VA = "0x1873A1AB0")]
	private static Vector2 FENPEOODCJC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x73A0C80", Offset = "0x739F280", VA = "0x1873A0C80")]
	private static Vector2 ADIECDCAKHC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x73A1C30", Offset = "0x73A0230", VA = "0x1873A1C30")]
	private static Vector2 FLPEJHLLPCN(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
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
