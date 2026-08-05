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

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AvatarBodyPartBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public bool HasLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public bool HasLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool HasLocalScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public Quaternion LocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Vector3 LocalScale;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A195B0", Offset = "0x6A17BB0", VA = "0x186A195B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AvatarBodyPartBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct FaceShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AvatarFaceShapeData.EIAKKEDFMHH FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AnimationClip FaceShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct BodyShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AvatarBodyShapeData.GGAPFHCEDBE BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AnimationClip BodyShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct HeadShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public AnimationClip HeadShapeAnimationClip;
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HDPEPKKPHNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AvatarFaceShapeBoneData faceShapeData;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public HDPEPKKPHNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6A1EA90", Offset = "0x6A1D090", VA = "0x186A1EA90")]
			internal bool DJFCKCFDDJE(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NJONHDHGKJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public AvatarBodyShapeBoneData bodyShapeData;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public NJONHDHGKJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F4D0", Offset = "0x6A1DAD0", VA = "0x186A1F4D0")]
			internal bool CANGCNLJMOD(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class MPCKGGCCAJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AvatarHeadShapeBoneData headShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public MPCKGGCCAJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6A1F470", Offset = "0x6A1DA70", VA = "0x186A1F470")]
			internal bool PLNPOOELKMI(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float ANIM_CLIP_EVAL_TIME = 0f;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private List<AvatarHeadShapeBoneData> headShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly Dictionary<(string, AvatarFaceShapeData.EIAKKEDFMHH), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Dictionary<(string, AvatarBodyShapeData.GGAPFHCEDBE), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<string> headBonesToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A19970", Offset = "0x6A17F70", VA = "0x186A19970")]
		public void AIFHKOLJDOL(IReadOnlyDictionary<string, Transform> ELMBFAHPFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A6C0", Offset = "0x6A18CC0", VA = "0x186A1A6C0")]
		public void PEEJFMNOFNA(IReadOnlyDictionary<string, Transform> ELMBFAHPFLC, AvatarFaceShapeData.EIAKKEDFMHH KOMGNJEMGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A350", Offset = "0x6A18950", VA = "0x186A1A350")]
		public void KHFCADINEFF(IReadOnlyDictionary<string, Transform> ELMBFAHPFLC, AvatarBodyShapeData.GGAPFHCEDBE NMCDICFFHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A19740", Offset = "0x6A17D40", VA = "0x186A19740")]
		public void AEFMCMEJPID(IReadOnlyDictionary<string, Transform> ELMBFAHPFLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A5E0", Offset = "0x6A18BE0", VA = "0x186A1A5E0")]
		private Vector3 LPKJLPEFAHB(Transform PKGFFGFMKLK, AvatarBodyPartBoneData JGACKBACBDF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A1F0", Offset = "0x6A187F0", VA = "0x186A1A1F0")]
		private Quaternion JDGDNJMKHMO(Transform PKGFFGFMKLK, AvatarBodyPartBoneData JGACKBACBDF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A650", Offset = "0x6A18C50", VA = "0x186A1A650")]
		private Vector3 NJDMHCJCNHM(Transform PKGFFGFMKLK, AvatarBodyPartBoneData JGACKBACBDF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A250", Offset = "0x6A18850", VA = "0x186A1A250")]
		private void JEGMNPCCHBF(Transform PKGFFGFMKLK, AvatarBodyPartBoneData JGACKBACBDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1A950", Offset = "0x6A18F50", VA = "0x186A1A950")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum GGAPFHCEDBE
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			Pear,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Apple,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			Hourglass,
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GGAPFHCEDBE blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Obsolete("Use BodyShapeId instead!")]
		[SerializeField]
		[HideInInspector]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NCHIFEMIBHL BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB7F5B0", Offset = "0xB7DBB0", VA = "0x180B7F5B0")]
			get
			{
				return default(NCHIFEMIBHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A1AE90", Offset = "0x6A19490", VA = "0x186A1AE90")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AvatarBodyShapeData.GGAPFHCEDBE BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A1AC20", Offset = "0x6A19220", VA = "0x186A1AC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ABHPOGICKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private Transform[] HAACGLOJJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<string, Transform> HEIOEBDNNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<Transform, Transform> ACKLLDNFDNN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<string, Transform> LKJKKHAIGHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Transform[] LAIODEACNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A192A0", Offset = "0x6A178A0", VA = "0x186A192A0")]
	public void GPCIFKMJFNA(Transform OEDOJNBCIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A191C0", Offset = "0x6A177C0", VA = "0x186A191C0")]
	public Transform GHAPKMIODGF(Transform MOBAFCFNBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A18F80", Offset = "0x6A17580", VA = "0x186A18F80")]
	public void GCLKODNHDML(SkinnedMeshRenderer CBLCMCOGHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A19380", Offset = "0x6A17980", VA = "0x186A19380")]
	private static void OCMHKJPANBI(Transform JPBBEMPIGCM, List<Transform> MEDPHPPCKBJ, Dictionary<string, Transform> EBDHENGLPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A194E0", Offset = "0x6A17AE0", VA = "0x186A194E0")]
	public ABHPOGICKMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ALFLIOIIDKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool CCKCIAPIKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool LBHAOECEPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public bool PFGPDECDGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public DFIACMOLAPM? ANMIHIBGPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public JAKMGBMNCCH.MGOIBKLDNOG HKDJLCNCAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public FitMeshHemisphere MBJLIOOLABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public AdditionalHatData EBHMNHHBEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public IList<BEICOJMJHMH> MIGEHNEPINF;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public ALFLIOIIDKL()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public float MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHatAnchorPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector3 DefaultHatAnchorRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6A1AF20", Offset = "0x6A19520", VA = "0x186A1AF20")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum GLHPDDDHLIA
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum BFLHHFOPLKK
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum GFOGIFDMNJB
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum GABPAHOMPGH
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum GFPOJCNDFBH
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum BIKBNBBNMKK
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FEJLIAELKEP
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	None
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DGLKPMBKEHO
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly GGOBIAMEGAD BMHJEDMFPBL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static FMFJFNMKGFN DPOGNLNNBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D5E0", Offset = "0x6A1BBE0", VA = "0x186A1D5E0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HONBEFLPIDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Transform CFCDNOFONFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public AssetReference OCMIEJEDCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public GameObject PFFAIKEBHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public GameObject MJOJDFPKCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public SkinnedMeshRenderer FEKDFGEGALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public AvatarSkinnedMeshBoneOrderRemapsData OOKDMCANCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Material ABGONJMNCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public Material JOJCDHHMICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Material ANCILLBBLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Shader MHMKCPEOOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Shader CAEDJCGJLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public Animator KLPEOJBFABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public Renderer[] PNFBHKNGOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public AvatarConfiguration BKIKNKOGMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public AvatarBodyPartShapesManager EENNPIHLPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public IReadOnlyDictionary<string, Transform> GPGKHEBLDGP;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct OPAPCMIDHAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public SkinnedMeshRenderer[] HMAKINAPCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public SkinnedMeshRenderer[] JKJIOICJPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public SkinnedMeshRenderer[] LIJCNAHDAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public SkinnedMeshRenderer[] OPMFMJFNFPD;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct EPNEOLKGKFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public Transform PHAJMDBHNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Transform CHGFIDNEHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public Transform ABJFBDBKJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Transform FMJOKOMPKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public Transform OBLAJOOIKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public Transform BIJMJNCOEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Transform LPJBJJGKFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public AvatarConfiguration BKIKNKOGMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public MMBBNHOOGFA GNDMCEHMCBI;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct DJLPGLPOCIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public SkinnedMeshRenderer[] HDACCBCHEON;
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct GMCBLBHANHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public OJKMAKKPOEK CCGJPBCGDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public int FNAENAPICKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public int JJBIOAADAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public Color BCDPPDNLFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public Color GGGGAJMNNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public int HANLECJIIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public int BCOCANLHJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Color FDGEEDJBKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Color EFDHANAHPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public int ICFNHMBOLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public float CJPIPMNJDIN;
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OOLHBCEMDGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public OJKMAKKPOEK CCGJPBCGDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public Vector2 JDMFMPHIIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public float JAGEAELGBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public Vector2 FKPMBKNIMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public float GGHBDBJHILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public Vector2 JAGCHEMKPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float NPEHBGJOLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public Vector2 GCAKMANONGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float EGKKCJHIPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public bool DJECIBLNEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public bool HNKJLCANDBD;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum EIAKKEDFMHH
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public EIAKKEDFMHH blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[HideInInspector]
		[SerializeField]
		[Obsolete("Use FaceShapeId instead!")]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public OAGOEKHDGKK FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB7F5B0", Offset = "0xB7DBB0", VA = "0x180B7F5B0")]
			get
			{
				return default(OAGOEKHDGKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B620", Offset = "0x6A19C20", VA = "0x186A1B620", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B680", Offset = "0x6A19C80", VA = "0x186A1B680")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public AvatarFaceShapeData.EIAKKEDFMHH FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B3B0", Offset = "0x6A199B0", VA = "0x186A1B3B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BCC0", Offset = "0x6A1A2C0", VA = "0x186A1BCC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class BEICOJMJHMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public string FHACOBMPENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public OutfitType MHAFLKPCNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public GLHPDDDHLIA AEPKCJLNNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public JAKMGBMNCCH.MGOIBKLDNOG JBFMCDFEMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool MLDPLJNIPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public bool ACKHAGAIKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public bool MANBBHNDNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Color? MCGAFOOCAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public Guid? GCIKBDPJIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public Color? AOGGMAJFHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public bool OAKCPCFDECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public bool NAIFPHABKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public AssetReference IPNMODLOJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public AssetReference DLOLIKIGONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public AssetReference[] OKLPCKLNJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool CEHBMNGHFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool FDNCPGLHFDF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public string PEPAJCGIHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D3E0", Offset = "0x6A1B9E0", VA = "0x186A1D3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D3E0", Offset = "0x6A1B9E0", VA = "0x186A1D3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D490", Offset = "0x6A1BA90", VA = "0x186A1D490")]
	public BEICOJMJHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MGCEPBEPFBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public SkinnedMeshRenderer ELELDFIFJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Material[] BFBALECEMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private byte[] GPJJKABKCPO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Mesh MNMHCDHACBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A1EAF0", Offset = "0x6A1D0F0", VA = "0x186A1EAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Material[] BCOLHDOPJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public byte[] LMGIEKHMECM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A1ECB0", Offset = "0x6A1D2B0", VA = "0x186A1ECB0")]
	public MGCEPBEPFBJ(SkinnedMeshRenderer BFPEPDDOBLA, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM, Material[] HOPECDKHBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EB10", Offset = "0x6A1D110", VA = "0x186A1EB10")]
	public static MGCEPBEPFBJ ILMDGLCJKGJ(Renderer MGJKLBPNDCE, AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM, Material[] HOPECDKHBGO)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD6B0B0", Offset = "0xD696B0", VA = "0x180D6B0B0")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xF8E120", Offset = "0xF8C720", VA = "0x180F8E120")]
		public void ENCKAHEIPGI(Vector3 LEELMECKGCG, Quaternion JOLHFCINNMA)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class EDMHEGIKDCD
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D780", Offset = "0x6A1BD80", VA = "0x186A1D780")]
	public static PositionAndRotation HJPAFJBDOPM(this PositionAndRotation PIIGIPCPLHG)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DAE0", Offset = "0x6A1C0E0", VA = "0x186A1DAE0")]
	public static float MOOLBNBINBK(float KGPMLIHPPAA, Vector2 EIJIFGPECAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1DA60", Offset = "0x6A1C060", VA = "0x186A1DA60")]
	public static float MOOLBNBINBK(float KGPMLIHPPAA, float GDAPDOPOOAD, float DPGLFJKGBIM, float EMFANHEMBJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D990", Offset = "0x6A1BF90", VA = "0x186A1D990")]
	public static float LGGLINOILIE(float KLABJGGMBGH, Vector2 EIJIFGPECAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1D8E0", Offset = "0x6A1BEE0", VA = "0x186A1D8E0")]
	public static float LGGLINOILIE(float KLABJGGMBGH, float GDAPDOPOOAD, float DPGLFJKGBIM, float EMFANHEMBJM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DBLLPFGLDEK
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static readonly int BHINDJGKNGN;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public static readonly string KIHAOOBIBNM;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public enum IDEHBGCIOLK
		{
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		private NoseMeshConfiguration[] noseMeshConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private Dictionary<DFIACMOLAPM, BodySkinnedMeshLODs> DOHGCFEJMCH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BodySkinnedMeshLODs NGBCINAFEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BodySkinnedMeshLODs OELOPDIJMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BodySkinnedMeshLODs EBJHBFJCIAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BodySkinnedMeshLODs GCNBIPBLFPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BFE0", Offset = "0x6A1A5E0", VA = "0x186A1BFE0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BD50", Offset = "0x6A1A350", VA = "0x186A1BD50")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(IDEHBGCIOLK MIACGHPGDLD, [Optional] DFIACMOLAPM? DHLLGPMIOPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C0E0", Offset = "0x6A1A6E0", VA = "0x186A1C0E0")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class CDFBJAHDCCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
			public CDFBJAHDCCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6A1D530", Offset = "0x6A1BB30", VA = "0x186A1D530")]
			internal bool BGHCFEEBMBH(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CD70", Offset = "0x6A1B370", VA = "0x186A1CD70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CD70", Offset = "0x6A1B370", VA = "0x186A1CD70")]
		private void NDGFIFLJNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C170", Offset = "0x6A1A770", VA = "0x186A1C170")]
		private void AOBEGDFBGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C2C0", Offset = "0x6A1A8C0", VA = "0x186A1C2C0")]
		public byte[] EBCIEIBLJEN(string NLONCLGKACF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1C330", Offset = "0x6A1A930", VA = "0x186A1C330")]
		public bool FLNFHGCAIOE(SkinnedMeshBoneOrderData LBLNJANFPLH, AvatarSkinnedMeshBonesController JNCOFBPJFPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CDE0", Offset = "0x6A1B3E0", VA = "0x186A1CDE0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class MGFEHKNENAI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct DCPEPNGPOMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Transform[] LAIODEACNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Matrix4x4[] FNMNMEKLPMH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static readonly string CELEPNAJGIM;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EE20", Offset = "0x6A1D420", VA = "0x186A1EE20")]
	public static byte[] CMCFDFGCLAK(AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM, SkinnedMeshRenderer CBLCMCOGHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6A1EF10", Offset = "0x6A1D510", VA = "0x186A1EF10")]
	public static DCPEPNGPOMJ? PGOBOHPGMBC(AvatarSkinnedMeshBoneOrderRemapsData KKDPDMAGMEM, SkinnedMeshRenderer CBLCMCOGHBN)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	[DisallowMultipleComponent]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[ReadOnlyField]
		[SerializeField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string KAIGCCBAEBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CF70", Offset = "0x6A1B570", VA = "0x186A1CF70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D3D0", Offset = "0x6A1B9D0", VA = "0x186A1D3D0")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CEB0", Offset = "0x6A1B4B0", VA = "0x186A1CEB0")]
		private void AOBEGDFBGEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A1CFA0", Offset = "0x6A1B5A0", VA = "0x186A1CFA0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D000", Offset = "0x6A1B600", VA = "0x186A1D000")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer MGJKLBPNDCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum PLBDJHAPMHA
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class CCNPMMKEMIA
{
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public static readonly CCNPMMKEMIA CLODJPHKAPB;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PJEIAKFLHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x887070", Offset = "0x885670", VA = "0x180887070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PLBDJHAPMHA OOHICHHCEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9023F0", Offset = "0x9009F0", VA = "0x1809023F0")]
		[CompilerGenerated]
		get
		{
			return default(PLBDJHAPMHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8FF980", Offset = "0x8FDF80", VA = "0x1808FF980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public CCNPMMKEMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x26982A0", Offset = "0x26968A0", VA = "0x1826982A0")]
	public CCNPMMKEMIA(PLBDJHAPMHA COEMAIGHGPP, int GMAAOPCONOP)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct NoseMeshConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NoseFaceOption NoseOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public BodySkinnedMeshLODs Meshes;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6A20C70", Offset = "0x6A1F270", VA = "0x186A20C70")]
		public void MANOFJBNFBG(SkinnedMeshRenderer CBLCMCOGHBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6A20E10", Offset = "0x6A1F410", VA = "0x186A20E10")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[Header("Remapping Eye Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		[Header("Remapping Mouth Data")]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B6D0", Offset = "0x6A19CD0", VA = "0x186A1B6D0")]
		public void INKJGPBAFMA(MALLKMKHLID CFCOHJEMFIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6A1BBA0", Offset = "0x6A1A1A0", VA = "0x186A1BBA0")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA64FD0", Offset = "0xA635D0", VA = "0x180A64FD0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6A1D4A0", Offset = "0x6A1BAA0", VA = "0x186A1D4A0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x885360", Offset = "0x883960", VA = "0x180885360", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6A1DF90", Offset = "0x6A1C590", VA = "0x186A1DF90")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6A1DFF0", Offset = "0x6A1C5F0", VA = "0x186A1DFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6A1DFB0", Offset = "0x6A1C5B0", VA = "0x186A1DFB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x6889580", Offset = "0x6887B80", VA = "0x186889580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x116D6A0", Offset = "0x116BCA0", VA = "0x18116D6A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1C27660", Offset = "0x1C25C60", VA = "0x181C27660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6A1DFD0", Offset = "0x6A1C5D0", VA = "0x186A1DFD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6A1E000", Offset = "0x6A1C600", VA = "0x186A1E000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DB80", Offset = "0x6A1C180", VA = "0x186A1DB80", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1DE80", Offset = "0x6A1C480", VA = "0x186A1DE80")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6A1EA70", Offset = "0x6A1D070", VA = "0x186A1EA70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1237D20", Offset = "0x1236320", VA = "0x181237D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xE15F60", Offset = "0xE14560", VA = "0x180E15F60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1239610", Offset = "0x1237C10", VA = "0x181239610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E840", Offset = "0x6A1CE40", VA = "0x186A1E840", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E980", Offset = "0x6A1CF80", VA = "0x186A1E980")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x6A211F0", Offset = "0x6A1F7F0", VA = "0x186A211F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x6A21E70", Offset = "0x6A20470", VA = "0x186A21E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly List<POLPOFEBNLM<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x887950", Offset = "0x885F50", VA = "0x180887950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x887980", Offset = "0x885F80", VA = "0x180887980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6A1E790", Offset = "0x6A1CD90", VA = "0x186A1E790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x6A1E800", Offset = "0x6A1CE00", VA = "0x186A1E800")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6A1E740", Offset = "0x6A1CD40", VA = "0x186A1E740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5873500", Offset = "0x5871B00", VA = "0x185873500")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x5873700", Offset = "0x5871D00", VA = "0x185873700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E220", Offset = "0x6A1C820", VA = "0x186A1E220")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E360", Offset = "0x6A1C960", VA = "0x186A1E360", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E290", Offset = "0x6A1C890", VA = "0x186A1E290")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E440", Offset = "0x6A1CA40", VA = "0x186A1E440")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E010", Offset = "0x6A1C610", VA = "0x186A1E010")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E540", Offset = "0x6A1CB40", VA = "0x186A1E540")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class OJKMAKKPOEK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct PAKHDPPKPLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder<OJKMAKKPOEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private OGMGECKBGAC.DEGIHAFPOIK <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6A20620", Offset = "0x6A1EC20", VA = "0x186A20620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6A20C00", Offset = "0x6A1F200", VA = "0x186A20C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly Dictionary<string, int> DPJIBHCLKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool JMGCMIKJPJL;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Texture2DArray AHCGAHDMIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public SymmetricalFaceFeature HMOPJKLILAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public EyesFaceFeature OFMLKOAGHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x88B6B0", Offset = "0x889CB0", VA = "0x18088B6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public FaceFeature LPAMPOACMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FC70", Offset = "0x6A1E270", VA = "0x186A1FC70")]
	private static void BMHGENDHFOK(Sprite OGHEOOIPDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FF80", Offset = "0x6A1E580", VA = "0x186A1FF80")]
	public static OJKMAKKPOEK ILAKFDGEBNH(SymmetricalFaceFeature DFHEEOHCFOE, EyesFaceFeature PNGADIHBOKA, FaceFeature IMHJOCILKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A20010", Offset = "0x6A1E610", VA = "0x186A20010")]
	[AsyncStateMachine(typeof(PAKHDPPKPLB))]
	public static Task<OJKMAKKPOEK> KONBAOKCIJC(SymmetricalFaceFeature DFHEEOHCFOE, EyesFaceFeature PNGADIHBOKA, FaceFeature IMHJOCILKDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A20240", Offset = "0x6A1E840", VA = "0x186A20240")]
	private OJKMAKKPOEK(SymmetricalFaceFeature DFHEEOHCFOE, EyesFaceFeature PNGADIHBOKA, FaceFeature IMHJOCILKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F530", Offset = "0x6A1DB30", VA = "0x186A1F530")]
	private void AEFKGLNOOHB(List<Sprite> AMOHDMOIPGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FD10", Offset = "0x6A1E310", VA = "0x186A1FD10")]
	public bool GGAAACKDADP(string AEADIHHOACO, [Out] int HGFDMIDEFHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FCE0", Offset = "0x6A1E2E0", VA = "0x186A1FCE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A20150", Offset = "0x6A1E750", VA = "0x186A20150")]
	public bool OGCLLAHCFGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FF00", Offset = "0x6A1E500", VA = "0x186A1FF00")]
	public void HGNDGMHLALF()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8FB3E0", Offset = "0x8F99E0", VA = "0x1808FB3E0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6A1E980", Offset = "0x6A1CF80", VA = "0x186A1E980")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public FEJLIAELKEP SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x91FD90", Offset = "0x91E390", VA = "0x18091FD90", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x903180", Offset = "0x901780", VA = "0x180903180")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public DFIACMOLAPM FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB7F5B0", Offset = "0xB7DBB0", VA = "0x180B7F5B0")]
			get
			{
				return default(DFIACMOLAPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9F2CE0", Offset = "0x9F12E0", VA = "0x1809F2CE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6A1B620", Offset = "0x6A19C20", VA = "0x186A1B620", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x903180", Offset = "0x901780", VA = "0x180903180")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x6A21170", Offset = "0x6A1F770", VA = "0x186A21170")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x10373A0", Offset = "0x10359A0", VA = "0x1810373A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6A211B0", Offset = "0x6A1F7B0", VA = "0x186A211B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x5FDFAC0", Offset = "0x5FDE0C0", VA = "0x185FDFAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6A21190", Offset = "0x6A1F790", VA = "0x186A21190")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x5FE2D60", Offset = "0x5FE1360", VA = "0x185FE2D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6A211D0", Offset = "0x6A1F7D0", VA = "0x186A211D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5FE2D50", Offset = "0x5FE1350", VA = "0x185FE2D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6A20EA0", Offset = "0x6A1F4A0", VA = "0x186A20EA0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6A210A0", Offset = "0x6A1F6A0", VA = "0x186A210A0")]
		protected SymmetricalFaceFeature()
		{
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
