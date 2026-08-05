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
		[Cpp2IlInjected.Address(RVA = "0x72FADA0", Offset = "0x72FA1A0", VA = "0x1872FADA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		public AvatarFaceShapeData.NFLOKLBCILG FaceShapeName;

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
		public AvatarBodyShapeData.BKBJCOHDGGC BodyShapeName;

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
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct NoseShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public EHLDDELHBFB NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AnimationClip NoseTypeAnimationClip;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IIEJJDMHEEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AvatarFaceShapeBoneData faceShapeData;

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public IIEJJDMHEEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7306210", Offset = "0x7305610", VA = "0x187306210")]
			internal bool AEFPDIMCMNI(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class FGMCEAPFIKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AvatarBodyShapeBoneData bodyShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public FGMCEAPFIKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x73013F0", Offset = "0x73007F0", VA = "0x1873013F0")]
			internal bool MKCFPINEKNN(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class BBOGKLNBEJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public AvatarHeadShapeBoneData headShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public BBOGKLNBEJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7300E60", Offset = "0x7300260", VA = "0x187300E60")]
			internal bool DENJEOBOKCI(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class EFFLIINDLFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public AvatarNoseTypeBoneData noseShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public EFFLIINDLFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7300F00", Offset = "0x7300300", VA = "0x187300F00")]
			internal bool LLGNKOLCKNM(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private const float ANIM_CLIP_EVAL_TIME = 0f;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private const string LOCAL_ROTATION_X_PROPERTY_NAME = "m_LocalRotation.x";

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const string LOCAL_ROTATION_Y_PROPERTY_NAME = "m_LocalRotation.y";

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private const string LOCAL_ROTATION_Z_PROPERTY_NAME = "m_LocalRotation.z";

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string LOCAL_ROTATION_W_PROPERTY_NAME = "m_LocalRotation.w";

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private const string BASE_NOSE_TWEAK_BONE_NAME = "Jnt.Head.Nose.Tweak";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private List<AvatarHeadShapeBoneData> headShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private List<AvatarNoseTypeBoneData> noseTypeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<(string, AvatarFaceShapeData.NFLOKLBCILG), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly Dictionary<(string, AvatarBodyShapeData.BKBJCOHDGGC), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<string, AvatarBodyPartBoneData> boneNameToHeadShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly Dictionary<(string, EHLDDELHBFB), AvatarBodyPartBoneData> boneNameToNoseTypeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly List<string> headBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly List<string> noseBonesToUpdate;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static string[] validNoseBoneNames;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72FB600", Offset = "0x72FAA00", VA = "0x1872FB600")]
		public void HPHCPPKCEKM(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72FC3F0", Offset = "0x72FB7F0", VA = "0x1872FC3F0")]
		public void JMLGLKIHGHG(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, AvatarFaceShapeData.NFLOKLBCILG NGODEJMKEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72FC6E0", Offset = "0x72FBAE0", VA = "0x1872FC6E0")]
		public void KCCKDLJJDAA(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, AvatarBodyShapeData.BKBJCOHDGGC LJFANJBKMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72FC150", Offset = "0x72FB550", VA = "0x1872FC150")]
		public void JEFDBDCKLJI(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72FAF30", Offset = "0x72FA330", VA = "0x1872FAF30")]
		public void DMLNOCMHAJD(IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, EHLDDELHBFB DIKOIBEAEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72FB590", Offset = "0x72FA990", VA = "0x1872FB590")]
		private Vector3 HIDGNCFIHKF(Transform JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72FC9D0", Offset = "0x72FBDD0", VA = "0x1872FC9D0")]
		private Quaternion KFMPNNAHECA(Transform JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72FB350", Offset = "0x72FA750", VA = "0x1872FB350")]
		private Vector3 EBEOEDAEPOI(Transform JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72FB3C0", Offset = "0x72FA7C0", VA = "0x1872FB3C0")]
		private void FPGPGEJKHEK(Transform JCFEMBBMLPO, AvatarBodyPartBoneData OECJMPAJLBM, bool LLHHMGICGLH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72FCCB0", Offset = "0x72FC0B0", VA = "0x1872FCCB0")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public enum BKBJCOHDGGC
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			Pear,
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			Apple,
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			Hourglass,
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public BKBJCOHDGGC blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[HideInInspector]
		[SerializeField]
		[Obsolete("Use BodyShapeId instead!")]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BLMLNFKIBJD BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x1B84030", Offset = "0x1B83430", VA = "0x181B84030")]
			get
			{
				return default(BLMLNFKIBJD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72FD7F0", Offset = "0x72FCBF0", VA = "0x1872FD7F0")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AvatarBodyShapeData.BKBJCOHDGGC BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72FD050", Offset = "0x72FC450", VA = "0x1872FD050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarBodyShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public List<AvatarBodyShape> AvatarBodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Dictionary<BLMLNFKIBJD, AvatarBodyShape> NHJJNAJDHHN;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72FD2D0", Offset = "0x72FC6D0", VA = "0x1872FD2D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72FD5F0", Offset = "0x72FC9F0", VA = "0x1872FD5F0")]
		public AvatarBodyShape Find(BLMLNFKIBJD KIFIPJGPKEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72FD700", Offset = "0x72FCB00", VA = "0x1872FD700")]
		public AvatarBodyShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72FD6C0", Offset = "0x72FCAC0", VA = "0x1872FD6C0")]
		public AvatarBodyShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72FD740", Offset = "0x72FCB40", VA = "0x1872FD740")]
		public AvatarBodyShapeVault()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IBIDNIBEJMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Transform[] BFCLLDAIHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly Dictionary<string, Transform> PKLAFHEMBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly Dictionary<Transform, Transform> GHNLEDLOAML;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyDictionary<string, Transform> AFGDHOGDDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Transform[] GMLOJIKNGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7305E20", Offset = "0x7305220", VA = "0x187305E20")]
	public void CDDHHLBDFEF(Transform LGGNMPJPOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7305D40", Offset = "0x7305140", VA = "0x187305D40")]
	public Transform BNLLKCELJEE(Transform AEDHAGPDFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7305F00", Offset = "0x7305300", VA = "0x187305F00")]
	public void MPIKIGCJEGP(SkinnedMeshRenderer HNDGMCCOEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7305BE0", Offset = "0x7304FE0", VA = "0x187305BE0")]
	private static void ALHHHCILINH(Transform JGHOOBNHEJB, List<Transform> BLNGGKCOHMF, Dictionary<string, Transform> MKBEILKPCEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7306140", Offset = "0x7305540", VA = "0x187306140")]
	public IBIDNIBEJMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HNNBNAMEAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public bool JPKLPNCGKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public bool PHGHEPMAOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public bool KBFCCJKJOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public EJPJNNNFMKK? HHJFAEMPNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public KBAIGJMAONF.FALICHFPADL KBCMAIHKKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public HairData GHPCGDIPDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public AdditionalHatData EHFIOFKPCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public bool NJDLINEDOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public bool HJHHFNGPPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public bool IANIGHDOMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IList<LJKKDAKGHIG> ELIADNLOLEN;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public HNNBNAMEAIG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("How far apart you can position your eyebrows.")]
		[Header("Face Features")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("How small/large you can scale your head.")]
		public Vector2 HeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Position of head at min scale.")]
		public Vector3 HeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Position of head at max scale.")]
		public Vector3 HeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Rotation of head at min scale.")]
		public Vector3 HeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Rotation of head at max scale.")]
		public Vector3 HeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("How small/large you can scale your modern bean head.")]
		public Vector2 ModernBeanHeadScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Position of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadPositionMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Position of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadPositionMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Rotation of modern bean head at min scale.")]
		public Vector3 ModernBeanHeadRotationMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Rotation of modern bean head at max scale.")]
		public Vector3 ModernBeanHeadRotationMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public Vector2 MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Defines how to remap certain facial features between this legacy bean and modern avatar systems")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromLegacySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Defines how to remap certain facial features between modern avatar systems and the legacy bean")]
		public AvatarFacialFeatureRemapper avatarFacialFeatureRemapperFromModernSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Header("Hat Pivots")]
		public Vector3 DefaultHairFitMeshPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Vector3 DefaultHairFitMeshRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Vector3 AdjustHairPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Vector3 AdjustHairRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Vector3 PivotPositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Vector3 PivotRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Header("Grip Features")]
		public string DefaultGripAnimationStateName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float DefaultGripAnimationBlendAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Header("Hand Animation")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72FD880", Offset = "0x72FCC80", VA = "0x1872FD880")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AAPPGJCIKLP
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly CNLEJDKNKDJ FJPNCKNOMMJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static KOIFPCMFICK JHEPIBOKGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72FA690", Offset = "0x72F9A90", VA = "0x1872FA690")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct CFPFBPBKEJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform BBILCLIAPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public AvatarSkinAssetItem KHDEMFLKOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public AssetReference PMGPBEGOELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GameObject DOPHPCCIDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public GameObject JBPJAGKJNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public SkinnedMeshRenderer OADHGANNGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AvatarSkinnedMeshBoneOrderRemapsData KLKLHKHAINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public Material MCMDMIJFAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Material IJMPGGGCFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Material FJNGKPMECND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Shader NBPAFPLLKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Shader MOKAMMOGEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Animator GFLIONDIOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Renderer[] CGLEAOIICHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public AvatarConfiguration PAKNPOKDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public AvatarBodyPartShapesManager IGBPPDODNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public IReadOnlyDictionary<string, Transform> ALCMHLGIDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform MFNCOHHLEPB;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ADGPJAEELJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public SkinnedMeshRenderer[] ECEADLHIGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public SkinnedMeshRenderer[] ELCODDGGEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public SkinnedMeshRenderer[] BAOOOBJKGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public SkinnedMeshRenderer[] LMMKBPLFEKI;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct HCEOCPHCBKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Transform PDGHOKLMBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Transform BIFBLJNMKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public Transform GHOHCBECAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public Transform LAAOCFMGFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Transform ADCJOFOCKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Transform GCJOIHOIHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public Transform ONKMNKKHAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public AvatarConfiguration PAKNPOKDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public PKOOKMMPLDP MFJBHKOKOAD;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct EBEGNBNODAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public SkinnedMeshRenderer[] LCDDCKKIAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public Material BHJJGIONPII;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct LJHCODOFFPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public JCJBPDFIOHA FJJPIOPJPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int JELDLDKBAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int ODNAMKAIMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Color MBJDFLMJAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Color MLGCPIBMLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public int KBHMCLLFJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public int JPDICELGGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public Color FMPDKKNHEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public Color GEFGOGKLOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public int GNKMHMMJOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public float LFJDFPKIODO;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct KJFGCCOFHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public JCJBPDFIOHA FJJPIOPJPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public Vector2 KGGGEEJADDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public float CPMMDJCPLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public Vector2 OMFBECGCKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public float JLCDMPLBLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public Vector2 OKLHJJKIPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public float AINNICNBACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public Vector2 ONJJJPBBOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public float ONMCMKANLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public bool LAAPKDCPJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public bool HGONKNJJIIG;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum NFLOKLBCILG
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NFLOKLBCILG blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[Obsolete("Use FaceShapeId instead!")]
		[HideInInspector]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public BFBNNFENAIB FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1B84030", Offset = "0x1B83430", VA = "0x181B84030")]
			get
			{
				return default(BFBNNFENAIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72FE5D0", Offset = "0x72FD9D0", VA = "0x1872FE5D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72FE630", Offset = "0x72FDA30", VA = "0x1872FE630")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public AvatarFaceShapeData.NFLOKLBCILG FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72FDE30", Offset = "0x72FD230", VA = "0x1872FDE30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AvatarFaceShapeVault : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[Tooltip("Used only for decorative purposes.")]
		public string Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public List<AvatarFaceShape> AvatarFaceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly Dictionary<BFBNNFENAIB, AvatarFaceShape> NHJJNAJDHHN;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72FE0B0", Offset = "0x72FD4B0", VA = "0x1872FE0B0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72FE3D0", Offset = "0x72FD7D0", VA = "0x1872FE3D0")]
		public AvatarFaceShape Find(BFBNNFENAIB NHHOCAJPOEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72FE4E0", Offset = "0x72FD8E0", VA = "0x1872FE4E0")]
		public AvatarFaceShape GetRandom()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72FE4A0", Offset = "0x72FD8A0", VA = "0x1872FE4A0")]
		public AvatarFaceShape GetDefault()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72FE520", Offset = "0x72FD920", VA = "0x1872FE520")]
		public AvatarFaceShapeVault()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AvatarFullBodyDisplayConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72FEC90", Offset = "0x72FE090", VA = "0x1872FEC90")]
		public AvatarFullBodyDisplayConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AvatarHairPattern : ScriptableObject, IEquatable<AvatarHairPattern>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public bool IsSolidPattern;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		private List<Texture2D> textures;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ICPMIFBJODI HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1B84030", Offset = "0x1B83430", VA = "0x181B84030")]
			get
			{
				return default(ICPMIFBJODI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Unlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A00", Offset = "0xAA5E00", VA = "0x180AA6A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xADC660", Offset = "0xADBA60", VA = "0x180ADC660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72FEE90", Offset = "0x72FE290", VA = "0x1872FEE90")]
		public Texture2D JBMNAJKBDJF(HairPatternStyle OGGFIINOGPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x72FED90", Offset = "0x72FE190", VA = "0x1872FED90", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x72FED20", Offset = "0x72FE120", VA = "0x1872FED20", Slot = "4")]
		public bool Equals(AvatarHairPattern OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72FEFE0", Offset = "0x72FE3E0", VA = "0x1872FEFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x72FEE50", Offset = "0x72FE250", VA = "0x1872FEE50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72FEE60", Offset = "0x72FE260", VA = "0x1872FEE60")]
		public static bool HKDAGECLGLD(AvatarHairPattern CLHNCHKFPON, AvatarHairPattern KMNANLEEDKO)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x72FECA0", Offset = "0x72FE0A0", VA = "0x1872FECA0")]
		public static bool BFIJCNNIIMH(AvatarHairPattern CLHNCHKFPON, AvatarHairPattern KMNANLEEDKO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x72FF020", Offset = "0x72FE420", VA = "0x1872FF020")]
		public AvatarHairPattern()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum BKMINCPGJKF
{
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Idle,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Invisible,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Pointing,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	TPose,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	ThumbUp,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	HandShake,
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	Grabbing,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	NumStates
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[Flags]
public enum BDFIOIHGFPK
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	ThumbUp = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Pointing = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	HandShake = 4
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IGLCKFKINMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public Animator IPIELEIMEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public ALIFPIFLCBK GAMFGKJDOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public AvatarConfiguration PAKNPOKDPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public GameObject CGBDHJPPPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public PKOOKMMPLDP MFJBHKOKOAD;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct EJIHPHLOCCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public Transform LCILNIGDBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public bool MNKDJKJBMEJ;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarHeadShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x72FF130", Offset = "0x72FE530", VA = "0x1872FF130", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AvatarHeadShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LJKKDAKGHIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public string OPDMIMOEGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public OutfitType DEKKOCCMKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public OBJHNMCDGDL CHEMOMFDFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public KBAIGJMAONF.FALICHFPADL LIAFJEDKOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public bool ADGHOEBGMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public bool EFDFBCJHFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public bool EDHJBEGLBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Color? DBFOGHLDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public bool JKNPCHFFOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Color? KFFCMLMCCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public bool LEBJFGDDIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x55")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public bool PHFBELMLHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x56")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public bool EGEEBMKALDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public Transform DMNLMOAADAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Vector2? EPJFOIELPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public FitMeshHemisphere ALEDOCHIIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public AssetReference LMDMGMLONEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public AssetReference ACDEDFBKHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public AssetReference[] KCBICLMLGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public LJKKDAKGHIG KMBBLDJDNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public bool BHIOIBCKAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public bool LEPPAAICBBC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string BAFPMMNNIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73081A0", Offset = "0x73075A0", VA = "0x1873081A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x73081A0", Offset = "0x73075A0", VA = "0x1873081A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7308250", Offset = "0x7307650", VA = "0x187308250")]
	public LJKKDAKGHIG()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private JECAOCDPOGB? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MCCAPFKCCCM CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x72FF6D0", Offset = "0x72FEAD0", VA = "0x1872FF6D0")]
			get
			{
				return default(MCCAPFKCCCM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JECAOCDPOGB MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x72FF700", Offset = "0x72FEB00", VA = "0x1872FF700")]
			get
			{
				return default(JECAOCDPOGB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x94FD70", Offset = "0x94F170", VA = "0x18094FD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x94FCC0", Offset = "0x94F0C0", VA = "0x18094FCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72FF1C0", Offset = "0x72FE5C0", VA = "0x1872FF1C0")]
		public Material[] BNEKEDBACGH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x72FF460", Offset = "0x72FE860", VA = "0x1872FF460")]
		public static void PJDFKOKDEGD(AvatarItemMaterial GLLPIKAAACI, Material HJCEHLILOIG, int CLLOKPKIGEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72FF2B0", Offset = "0x72FE6B0", VA = "0x1872FF2B0")]
		private static bool OHCPPADPLFE(AvatarItemMaterial GLLPIKAAACI, int CLLOKPKIGEH, [Out] Material DOLKEGANOCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x72FF650", Offset = "0x72FEA50", VA = "0x1872FF650")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KIFHJDJPHPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public SkinnedMeshRenderer FIGEBICLGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Material[] NNLECGFCFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private byte[] OKBKNCOIOKL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public Mesh KFDGIAJINED
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x73079C0", Offset = "0x7306DC0", VA = "0x1873079C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public Material[] KNEEJKFKEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public byte[] IKOHCDKNDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x73079E0", Offset = "0x7306DE0", VA = "0x1873079E0")]
	public KIFHJDJPHPE(SkinnedMeshRenderer BNBIMMBDEGH, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, Material[] GDFHBJLKHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7307820", Offset = "0x7306C20", VA = "0x187307820")]
	public static KIFHJDJPHPE DBGIJHFGGDN(Renderer EHMEICJAGNO, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, Material[] GDFHBJLKHMG)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x12207B0", Offset = "0x121FBB0", VA = "0x1812207B0")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xADC210", Offset = "0xADB610", VA = "0x180ADC210")]
		public void ECFLGDLFBIO(Vector3 NDADPNJPMFO, Quaternion MLMNPOCKAAE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KBKPAOPPIKM
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7307560", Offset = "0x7306960", VA = "0x187307560")]
	public static PositionAndRotation GDOFOCGAAIL(this PositionAndRotation CHFLFONLLOP)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7307440", Offset = "0x7306840", VA = "0x187307440")]
	public static float CINANEJNNFN(float CHBEBLKFDBC, Vector2 APGJDJPACGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x73074E0", Offset = "0x73068E0", VA = "0x1873074E0")]
	public static float CINANEJNNFN(float CHBEBLKFDBC, float CDIPILBCKFB, float MJPJCMEJEPK, float HCEBABCAMLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x73076B0", Offset = "0x7306AB0", VA = "0x1873076B0")]
	public static float IJNOLFNAGPB(float KBGCCIOIGBD, Vector2 APGJDJPACGH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7307770", Offset = "0x7306B70", VA = "0x187307770")]
	public static float IJNOLFNAGPB(float KBGCCIOIGBD, float CDIPILBCKFB, float MJPJCMEJEPK, float HCEBABCAMLE)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarNoseTypeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public EHLDDELHBFB NoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x72FF7C0", Offset = "0x72FEBC0", VA = "0x1872FF7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AvatarNoseTypeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public enum FKMNECDKODO
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Highfive = 1,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Fistbump = 2,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Handshake = 3,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	OpenHand = 100,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Point = 101,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	ThumbsUp = 102,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	ThumbsDown = 103,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	ClosedFist = 104,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	OBSOLETE_CannedWave = 1000
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public enum IFFGGLLHIDG
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	IdleSwayAimWeapon,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	IdleSwayMeleeWeapon,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	IdleSwayLightItem,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	IdleSwayHeavyItem,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	IdleSwayAimOneHandedWeapon,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	FastAction,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	NumTypes
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum IIFAJIGINPD
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Inactive,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	PotatoAvatar,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	FullOutfitAvatar
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct PlatformSpecificPlayerHandOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public PositionAndRotation Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool HasSteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public PositionAndRotation SteamVrVive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public bool HasSteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public PositionAndRotation SteamVrOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public bool HasSteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public PositionAndRotation SteamVrMicrosoft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public bool HasOculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public PositionAndRotation Oculus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public bool HasSteamVrIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public PositionAndRotation SteamVrIndex;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class HandLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public PositionAndRotation FingerTipOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public PositionAndRotation HandCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public PositionAndRotation HandShakeOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public PositionAndRotation GravityPickupOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public PositionAndRotation FistBumpOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public PositionAndRotation HighFiveOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public PositionAndRotation WatchMenuOriginOffset;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HandLogicOffsets()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct PJLHDFEOPIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public Vector2 HNPAKEGDHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Vector2 HBJLONKDBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Vector2 ECGDGHKMFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public Vector2 GOBPDGPCJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public Vector2 JEFLIPNIFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public Vector2 IGPIIDPKKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public Vector2 DOKHFAIPLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public Vector2 GKNGJAFIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public Vector2 DHAEGFBFMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public Vector2 KFAKDAJHBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Vector2 KBJPLLDJFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Vector2 KFKLDFNBOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Vector2 DIIIAPCLIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Vector2 FIKKPPNNDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public Vector2 ANDDBHKPMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Vector2 AMBNKDINCBD;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public struct HeadLogicOffsets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public PositionAndRotation VoiceLinesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public PositionAndRotation VFXEmotesOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public PositionAndRotation FaceTriggerOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public PositionAndRotation MouthColliderOffset;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class LDGJBAOONFM
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public static readonly int LEOLKEGHAPF;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public static readonly string BNKMDADMHIF;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7307D60", Offset = "0x7307160", VA = "0x187307D60")]
	public static CFPFBPBKEJA IDPNFHONODB(Transform JFFOPKNCHML, AvatarSkinAssetItem NKOJECCKCBD, AssetReference CEFBPHKNGKO, GameObject DFNDDNMADAP, GameObject JKOKIJCNEIK, SkinnedMeshRenderer DIJFOFCCPHI, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, Material FOIGNFEPFGI, Material OBOFBCJMFHP, Material JIMPKGMGNKH, Shader OEEENOBJCHB, Shader KLLALGPLCJG, Animator CMDMCGFLDIH, Renderer[] CEDAKEBLNNI, AvatarConfiguration BFMGDLDGOKJ, AvatarBodyPartShapesManager IAIJGBADCHE, IReadOnlyDictionary<string, Transform> AJEBPDLPCCI, Transform HANDMKOOGJF)
	{
		return default(CFPFBPBKEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x73080A0", Offset = "0x73074A0", VA = "0x1873080A0")]
	public static ADGPJAEELJF PNFNAGCFNDC(SkinnedMeshRenderer[] HBOFPICJAKO, SkinnedMeshRenderer[] MLJIHOJBBAA, SkinnedMeshRenderer[] MJHKCDPIMDJ, SkinnedMeshRenderer[] BDBLKOJGMMO)
	{
		return default(ADGPJAEELJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7307F20", Offset = "0x7307320", VA = "0x187307F20")]
	public static HCEOCPHCBKP JJOGFMCHKJF(Transform FFFNDEIPNLL, Transform LHDKDPDANJD, Transform BCOMCAAOCPC, Transform LJHEAHPOLJB, Transform PIFIEIMDDOL, Transform GEKEPNHNBDI, Transform NICEKCIJKAG, AvatarConfiguration DJCGLEJFHCA, PKOOKMMPLDP HMKELMICGGI)
	{
		return default(HCEOCPHCBKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2586720", Offset = "0x2585B20", VA = "0x182586720")]
	public static EBEGNBNODAH JLPIBMMFCMI(SkinnedMeshRenderer[] JCOKBIONLJH, Material NHBABBDAMAE)
	{
		return default(EBEGNBNODAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7308000", Offset = "0x7307400", VA = "0x187308000")]
	public static LJHCODOFFPO LMJEKOFPCOC(JCJBPDFIOHA DCNNPFLFEKE, int COAEBLGAJNF, int CBEFCPHNIMH, Color PFNEGPFPGNG, Color OBBNAHOPCCA, int MDNDPLDNJEG, int CJKKOAAFKGD, Color CMOIMNFIKPL, Color MKEBEJDDGJJ, int NOGGIMHDECG)
	{
		return default(LJHCODOFFPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7307BF0", Offset = "0x7306FF0", VA = "0x187307BF0")]
	public static KJFGCCOFHCI AFDFFNFELIK(JCJBPDFIOHA DCNNPFLFEKE, Vector2 FCJEMCDEIMF, float BOFGEKFBCFI, Vector2 IGKLIJOGCBM, float IBEBPGOENLH, Vector2 JNINICKAAEA, float HIALDNCJNLM, Vector2 JDEPBGGCMIO, float BANHHPCIFGF)
	{
		return default(KJFGCCOFHCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7307CE0", Offset = "0x73070E0", VA = "0x187307CE0")]
	public static IGLCKFKINMF DCFKHDKDKHK(Animator IEACKBDAGDE, ALIFPIFLCBK JEGNMOJFJKJ, AvatarConfiguration BFMGDLDGOKJ, GameObject LMHFBDJLIFM, PKOOKMMPLDP HMKELMICGGI)
	{
		return default(IGLCKFKINMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7307CA0", Offset = "0x73070A0", VA = "0x187307CA0")]
	public static EJIHPHLOCCI BCOPMAMIPGB(Transform HICHCPBOIPK, bool KAHLIPACLNH)
	{
		return default(EJIHPHLOCCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class NJMMFMFNAFM
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7308270", Offset = "0x7307670", VA = "0x187308270")]
	public static BKMINCPGJKF LDIFGIHPLHP(this FKMNECDKODO CCGJGKICAMO)
	{
		return default(BKMINCPGJKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7308260", Offset = "0x7307660", VA = "0x187308260")]
	public static bool BMCCNMFPLKF(this FKMNECDKODO DEJCMGKBJMI)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public enum MBKPHICBOOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private BodySkinnedMeshLODs baseNoseSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public BodySkinnedMeshLODs LILHAJIEIIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public BodySkinnedMeshLODs CFAEMADEJPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BodySkinnedMeshLODs EIILPLHJCJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BodySkinnedMeshLODs KAAGKHMMBAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72FFA40", Offset = "0x72FEE40", VA = "0x1872FFA40")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(MBKPHICBOOJ GHHKFIEAPCG, [Optional] EJPJNNNFMKK? IFJJNEIHMGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public AvatarSkinAssetItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class DHHBLADBGEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public DHHBLADBGEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7300ED0", Offset = "0x73002D0", VA = "0x187300ED0")]
			internal bool FBNIKMLLJOM(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72FFC40", Offset = "0x72FF040", VA = "0x1872FFC40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72FFC40", Offset = "0x72FF040", VA = "0x1872FFC40")]
		private void JPDALOEPCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x73006B0", Offset = "0x72FFAB0", VA = "0x1873006B0")]
		private void PMBMMACDLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72FFBD0", Offset = "0x72FEFD0", VA = "0x1872FFBD0")]
		public byte[] DBOKGCAPEMC(string BKHIEFINECL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72FFC50", Offset = "0x72FF050", VA = "0x1872FFC50")]
		public bool LCJOBKNOFFP(SkinnedMeshBoneOrderData BOBOFPBGJPB, AvatarSkinnedMeshBonesController KAPENEPPGKB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7300870", Offset = "0x72FFC70", VA = "0x187300870")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ONAMCNJKKBA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct NNGCLJFCINI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Transform[] GMLOJIKNGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Matrix4x4[] NPKOJEOEIDO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public static readonly string CAHKGEPCIKK;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x73082C0", Offset = "0x73076C0", VA = "0x1873082C0")]
	public static byte[] GIKKHKKCPEJ(AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, SkinnedMeshRenderer HNDGMCCOEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x73083B0", Offset = "0x73077B0", VA = "0x1873083B0")]
	public static NNGCLJFCINI? MDCPMPOOBFM(AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL, SkinnedMeshRenderer HNDGMCCOEDJ)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	[DisallowMultipleComponent]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public string GBHGCGOOHGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7300940", Offset = "0x72FFD40", VA = "0x187300940")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7300D90", Offset = "0x7300190", VA = "0x187300D90")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7300DA0", Offset = "0x73001A0", VA = "0x187300DA0")]
		private void PMBMMACDLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7300970", Offset = "0x72FFD70", VA = "0x187300970")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x73009D0", Offset = "0x72FFDD0", VA = "0x1873009D0")]
		public static string CalculateBoneOrderChecksum(SkinnedMeshRenderer EHMEICJAGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum OOGJIEHIMKJ
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IKKEFGFKHCN
{
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public static readonly IKKEFGFKHCN MPDPNCAPBBE;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int ONPHMDAKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9491A0", Offset = "0x9485A0", VA = "0x1809491A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x952480", Offset = "0x951880", VA = "0x180952480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public OOGJIEHIMKJ JOJGPIHLEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA2E4D0", Offset = "0xA2D8D0", VA = "0x180A2E4D0")]
		[CompilerGenerated]
		get
		{
			return default(OOGJIEHIMKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAEB110", Offset = "0xAEA510", VA = "0x180AEB110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public IKKEFGFKHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1000", Offset = "0x2BC0400", VA = "0x182BC1000")]
	public IKKEFGFKHCN(OOGJIEHIMKJ OALDHMLLKME, int OENLDFNIJMF)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[DisallowMultipleComponent]
	public class FitMeshPreviewGizmo : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7302980", Offset = "0x7301D80", VA = "0x187302980")]
		public void DrawPosition(bool IMLBMCFLIEF, Transform EJNLPEDOMDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7302A20", Offset = "0x7301E20", VA = "0x187302A20")]
		public static void EditorDrawGizmoWithRestrictions(FitMeshHemisphere HANEBACCPJP, Transform LDIAONMHHPK, Vector2 CCBMCEOJMOG, AnchorParamsRestrictions HBMDEFKGEPA, bool PCBAHHLCABJ = false, bool GCOHCEJDPBK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public FitMeshPreviewGizmo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7308920", Offset = "0x7307D20", VA = "0x187308920")]
		public void HOIGNPKMANP(SkinnedMeshRenderer HNDGMCCOEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7308AD0", Offset = "0x7307ED0", VA = "0x187308AD0")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class AvatarFacialFeatureRemapper : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		[Header("Remapping Eye Data")]
		private AnimationCurve RemapHorizontalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private AnimationCurve RemapVerticalEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private AnimationCurve RemapScaleEyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[Header("Remapping Mouth Data")]
		[SerializeField]
		private AnimationCurve RemapHorizontalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private AnimationCurve RemapVerticalMouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private AnimationCurve RemapScaleMouth;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x72FE680", Offset = "0x72FDA80", VA = "0x1872FE680")]
		public void PPJBOJMBFLL(FOGFGJADBEA MMOKANOMMLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x72FEB70", Offset = "0x72FDF70", VA = "0x1872FEB70")]
		public AvatarFacialFeatureRemapper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xA4F470", Offset = "0xA4E870", VA = "0x180A4F470", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7300EC0", Offset = "0x73002C0", VA = "0x187300EC0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x7301370", Offset = "0x7300770", VA = "0x187301370")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x73013D0", Offset = "0x73007D0", VA = "0x1873013D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x7301390", Offset = "0x7300790", VA = "0x187301390")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x70FD6F0", Offset = "0x70FCAF0", VA = "0x1870FD6F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x73013B0", Offset = "0x73007B0", VA = "0x1873013B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x23C4620", Offset = "0x23C3A20", VA = "0x1823C4620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1B3D740", Offset = "0x1B3CB40", VA = "0x181B3D740")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x73013E0", Offset = "0x73007E0", VA = "0x1873013E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7300F60", Offset = "0x7300360", VA = "0x187300F60", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7301260", Offset = "0x7300660", VA = "0x187301260")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7301EE0", Offset = "0x73012E0", VA = "0x187301EE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x1745E70", Offset = "0x1745270", VA = "0x181745E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x12D74B0", Offset = "0x12D68B0", VA = "0x1812D74B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x17433B0", Offset = "0x17427B0", VA = "0x1817433B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7301CA0", Offset = "0x73010A0", VA = "0x187301CA0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7301DE0", Offset = "0x73011E0", VA = "0x187301DE0")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7308EC0", Offset = "0x73082C0", VA = "0x187308EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x7309B50", Offset = "0x7308F50", VA = "0x187309B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private readonly List<EBHOPDBMNPK<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x94FD00", Offset = "0x94F100", VA = "0x18094FD00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x94FAE0", Offset = "0x94EEE0", VA = "0x18094FAE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7301BF0", Offset = "0x7300FF0", VA = "0x187301BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7301C60", Offset = "0x7301060", VA = "0x187301C60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7301B80", Offset = "0x7300F80", VA = "0x187301B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x7301BD0", Offset = "0x7300FD0", VA = "0x187301BD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6803BF0", Offset = "0x6802FF0", VA = "0x186803BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7301660", Offset = "0x7300A60", VA = "0x187301660")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x73017A0", Offset = "0x7300BA0", VA = "0x1873017A0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x73016D0", Offset = "0x7300AD0", VA = "0x1873016D0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7301880", Offset = "0x7300C80", VA = "0x187301880")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7301450", Offset = "0x7300850", VA = "0x187301450")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7301980", Offset = "0x7300D80", VA = "0x187301980")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public sealed class JCJBPDFIOHA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct HABICIMJLIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public AsyncTaskMethodBuilder<JCJBPDFIOHA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private ANEFDAMIPJL.DDJIBKGDJKD <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7305340", Offset = "0x7304740", VA = "0x187305340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7305B70", Offset = "0x7304F70", VA = "0x187305B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly Dictionary<string, int> LOFNKLJGBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private bool KJIGGBNHALH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Texture2DArray FBCDPMAMFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public SymmetricalFaceFeature GBMGHNNCNJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public EyesFaceFeature HLFFGADKJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public FaceFeature FNDKMNFKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7306500", Offset = "0x7305900", VA = "0x187306500")]
	private static void GDFEAFNOLLP(Sprite HPPCDBBBHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7306570", Offset = "0x7305970", VA = "0x187306570")]
	public static JCJBPDFIOHA JGFEECJHJKJ(SymmetricalFaceFeature MCHPFJOOKHO, EyesFaceFeature FOPODPFDCII, FaceFeature JJAKFIIKPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7306E50", Offset = "0x7306250", VA = "0x187306E50")]
	[AsyncStateMachine(typeof(HABICIMJLIF))]
	public static Task<JCJBPDFIOHA> MOGFBDKKLAL(SymmetricalFaceFeature MCHPFJOOKHO, EyesFaceFeature FOPODPFDCII, FaceFeature JJAKFIIKPIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7306F90", Offset = "0x7306390", VA = "0x187306F90")]
	private JCJBPDFIOHA(SymmetricalFaceFeature MCHPFJOOKHO, EyesFaceFeature FOPODPFDCII, FaceFeature JJAKFIIKPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x73066F0", Offset = "0x7305AF0", VA = "0x1873066F0")]
	private void LDEJBMGKPCE(List<Sprite> GAKECAHAAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7306600", Offset = "0x7305A00", VA = "0x187306600")]
	public bool KCLNGNJBOKN(string BHDEFAKNALA, [Out] int EAHKFAJBNDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x73064D0", Offset = "0x73058D0", VA = "0x1873064D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x73063C0", Offset = "0x73057C0", VA = "0x1873063C0")]
	public bool DLCFPDABHIK(bool KCPMDDJGIJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x73062F0", Offset = "0x73056F0", VA = "0x1873062F0")]
	public void AKMEBJCGOMI()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct AJDEFLCAPJB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public AsyncTaskMethodBuilder<JCJBPDFIOHA> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			private TaskAwaiter<JCJBPDFIOHA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x72FA830", Offset = "0x72F9C30", VA = "0x1872FA830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x72FAD30", Offset = "0x72FA130", VA = "0x1872FAD30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Dictionary<EJPJNNNFMKK, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Dictionary<EJPJNNNFMKK, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Dictionary<EJPJNNNFMKK, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Dictionary<EJPJNNNFMKK, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly Dictionary<EJPJNNNFMKK, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private JCJBPDFIOHA _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private JCJBPDFIOHA _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x7302950", Offset = "0x7301D50", VA = "0x187302950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x73022E0", Offset = "0x73016E0", VA = "0x1873022E0")]
		public JCJBPDFIOHA JAMPDJANBKD(PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7301F00", Offset = "0x7301300", VA = "0x187301F00")]
		[AsyncStateMachine(typeof(AJDEFLCAPJB))]
		public Task<JCJBPDFIOHA> ADPMBGIHOMN(int? JHIBJCEFAPK, int FOPODPFDCII, int JJAKFIIKPIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7302600", Offset = "0x7301A00", VA = "0x187302600")]
		public NoseFaceOption ODNHNHKGLDJ(int ABGHCCKGPOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x73026A0", Offset = "0x7301AA0", VA = "0x1873026A0")]
		public SelectableFaceOption PBMDEMBNDJB(FaceFeatureType EFKOOGECDHL, EJPJNNNFMKK EKOKNCCJHCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7302030", Offset = "0x7301430", VA = "0x187302030")]
		public int AOCOKIJDFEF(EJPJNNNFMKK EKOKNCCJHCA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x73020B0", Offset = "0x73014B0", VA = "0x1873020B0")]
		private void DGNGLBLNCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x33832B0", Offset = "0x33826B0", VA = "0x1833832B0")]
		private void DMFEBJLGKDP<T>(IDictionary<EJPJNNNFMKK, T> EIEEOCBNIGD, IReadOnlyList<T> PHPDPFNNCJH) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x73024F0", Offset = "0x73018F0", VA = "0x1873024F0")]
		public EJPJNNNFMKK NCHNHFBMADF(FaceFeatureType EFKOOGECDHL)
		{
			return default(EJPJNNNFMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7302370", Offset = "0x7301770", VA = "0x187302370")]
		public EJPJNNNFMKK MBEGLMLOKCJ(FaceFeatureType EFKOOGECDHL)
		{
			return default(EJPJNNNFMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7302820", Offset = "0x7301C20", VA = "0x187302820")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7301DE0", Offset = "0x73011E0", VA = "0x187301DE0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public EHLDDELHBFB SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA66FC0", Offset = "0xA663C0", VA = "0x180A66FC0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA3C8E0", Offset = "0xA3BCE0", VA = "0x180A3C8E0")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public EJPJNNNFMKK FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x1B84030", Offset = "0x1B83430", VA = "0x181B84030")]
			get
			{
				return default(EJPJNNNFMKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xC14E20", Offset = "0xC14220", VA = "0x180C14E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x72FE5D0", Offset = "0x72FD9D0", VA = "0x1872FE5D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA3C8E0", Offset = "0xA3BCE0", VA = "0x180A3C8E0")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7308E40", Offset = "0x7308240", VA = "0x187308E40")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x67FFCE0", Offset = "0x67FF0E0", VA = "0x1867FFCE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7308E80", Offset = "0x7308280", VA = "0x187308E80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x67FFCF0", Offset = "0x67FF0F0", VA = "0x1867FFCF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7308E60", Offset = "0x7308260", VA = "0x187308E60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6802E70", Offset = "0x6802270", VA = "0x186802E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x7308EA0", Offset = "0x73082A0", VA = "0x187308EA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6802E60", Offset = "0x6802260", VA = "0x186802E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7308B60", Offset = "0x7307F60", VA = "0x187308B60", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7308D70", Offset = "0x7308170", VA = "0x187308D70")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class GNNBCDBCACO
{
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static readonly float GFJLMJBANCL;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static readonly float HFBKGENFGPM;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static readonly Vector2 POCBHLDKIMP;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static readonly Vector2 ADPICFBOJDP;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static readonly Vector2 BFMCANHGABC;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static readonly Vector2 NPMDJIIMGLP;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static readonly Vector2 BOOODNDJPNH;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static readonly Vector2 IKBHBMGOLDD;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static readonly Vector2 OMAFFGCNOIL;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static readonly Vector2 DLLBNDMKENN;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly Vector2 GCDCACPGFPF;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static readonly Vector2 FBCAKKBGKKO;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly Vector2 PCMDALPCNOJ;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static readonly Vector2 HMNFPJBGFEK;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x7303020", Offset = "0x7302420", VA = "0x187303020")]
	public static Vector2 AFJMBFGFKEN(FaceFeatureType KGLDHIDPHPP, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x73043F0", Offset = "0x73037F0", VA = "0x1873043F0")]
	public static float KLFKHOGAMCL(FaceFeatureType KGLDHIDPHPP, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7303610", Offset = "0x7302A10", VA = "0x187303610")]
	public static void CEFPDBINDNB(FOGFGJADBEA PPKGJMCKKFG, AvatarConfiguration BFMGDLDGOKJ, PKOOKMMPLDP GOHELOEBLHN, PKOOKMMPLDP IEHDEIFCKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x73045E0", Offset = "0x73039E0", VA = "0x1873045E0")]
	public static float KOLCABMAMBD(FaceFeatureType EFKOOGECDHL, float OIJMFADLAHH, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7305080", Offset = "0x7304480", VA = "0x187305080")]
	public static float POGBOGPHPAD(FaceFeatureType EFKOOGECDHL, float DHIKJADGNNJ, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7304F00", Offset = "0x7304300", VA = "0x187304F00")]
	public static Vector2 PKFDKKENGBD(FaceFeatureType EFKOOGECDHL, Vector2 NHEABMEEBBE, Vector2 OILKJCFPEEE, Vector2 HEGCGICCMGN, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7303B30", Offset = "0x7302F30", VA = "0x187303B30")]
	public static Vector2 DABCIFLJCAC(FaceFeatureType EFKOOGECDHL, Vector2 ILINMNBKBOG, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x73036D0", Offset = "0x7302AD0", VA = "0x1873036D0")]
	private static Vector2 CLNDEBMHPOA(FaceFeatureType EFKOOGECDHL, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7304770", Offset = "0x7303B70", VA = "0x187304770")]
	private static Vector2 NOLGFHKDFMP(FaceFeatureType EFKOOGECDHL, Vector2 NHEABMEEBBE, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x73049B0", Offset = "0x7303DB0", VA = "0x1873049B0")]
	public static Vector2 PEPBOJNHKJJ(FaceFeatureType EFKOOGECDHL, Vector2 ILINMNBKBOG, Vector2 OILKJCFPEEE, Vector2 HEGCGICCMGN, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x73032D0", Offset = "0x73026D0", VA = "0x1873032D0")]
	public static float AFPFCBMKPEE(FaceFeatureType EFKOOGECDHL, float DHIKJADGNNJ, PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x73046E0", Offset = "0x7303AE0", VA = "0x1873046E0")]
	private static float NKEMHPBDCBM(float CDIPILBCKFB, float HCEBABCAMLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7303A80", Offset = "0x7302E80", VA = "0x187303A80")]
	private static Vector2 CPEKAAJPMAG(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7304150", Offset = "0x7303550", VA = "0x187304150")]
	private static Vector2 HMMDJIFPCAK(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7304FD0", Offset = "0x73043D0", VA = "0x187304FD0")]
	private static Vector2 PODHPMEMAGO(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x73034F0", Offset = "0x73028F0", VA = "0x1873034F0")]
	private static Vector2 BBDCDKHBMOC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x73035A0", Offset = "0x73029A0", VA = "0x1873035A0")]
	private static float BNGBOHPNHEC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7304200", Offset = "0x7303600", VA = "0x187304200")]
	private static float IDKFNKDPLJG(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7304940", Offset = "0x7303D40", VA = "0x187304940")]
	private static float OIIAMJKFMJK(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7304670", Offset = "0x7303A70", VA = "0x187304670")]
	private static float NIMDJOPFLJP(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7304090", Offset = "0x7303490", VA = "0x187304090")]
	private static Vector2 GKEEGNLAKJH(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7303E50", Offset = "0x7303250", VA = "0x187303E50")]
	private static Vector2 FFFBFKLABFH(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7303FD0", Offset = "0x73033D0", VA = "0x187303FD0")]
	private static Vector2 GDJKPHJIACP(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x73039C0", Offset = "0x7302DC0", VA = "0x1873039C0")]
	private static Vector2 COMEBKPKDFK(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7303900", Offset = "0x7302D00", VA = "0x187303900")]
	private static Vector2 CNGLCCKJFNJ(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7304270", Offset = "0x7303670", VA = "0x187304270")]
	private static Vector2 JHNBJDDOOIG(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7303840", Offset = "0x7302C40", VA = "0x187303840")]
	private static Vector2 CLNFHLDAGOC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x7304E40", Offset = "0x7304240", VA = "0x187304E40")]
	private static Vector2 PGBLHMDDAOC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x7304330", Offset = "0x7303730", VA = "0x187304330")]
	private static Vector2 JNAGOGIAPFN(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x7303D90", Offset = "0x7303190", VA = "0x187303D90")]
	private static Vector2 FENPEOODCJC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7302F60", Offset = "0x7302360", VA = "0x187302F60")]
	private static Vector2 ADIECDCAKHC(PKOOKMMPLDP HMKELMICGGI, AvatarConfiguration DJCGLEJFHCA)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7303F10", Offset = "0x7303310", VA = "0x187303F10")]
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
