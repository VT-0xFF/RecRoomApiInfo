using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Avatars;
using RecRoom.NoEngine.Common;
using RootMotion.FinalIK;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AvatarElbowBendHelperController : MonoBehaviour, EEEGEKGFIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[AHOEPOHPCNC(ONGLIIBHLOO.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private bool DebugExecutionInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private Vector3? BPFKOKHONMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool JBLAMKLONHJ;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC660", Offset = "0x5EEB460", VA = "0x185EEC660", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5EECC60", Offset = "0x5EEBA60", VA = "0x185EECC60", Slot = "4")]
		public void UpdateController(float KNBDFHCBHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC976B0", Offset = "0xC964B0", VA = "0x180C976B0", Slot = "6")]
		public void SetEnabled(bool NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC700", Offset = "0x5EEB500", VA = "0x185EEC700")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5EED070", Offset = "0x5EEBE70", VA = "0x185EED070")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AvatarElbowBendTargetController : MonoBehaviour, EEEGEKGFIKO
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const float AKAGIGHADPE = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[AHOEPOHPCNC(ONGLIIBHLOO.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private Transform ChestBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Vector3 IIBLIOGOELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Vector3 IHEMLJNKJFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool JBLAMKLONHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float APPAFJHAJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float ELBJNLGLAGE;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EED3F0", Offset = "0x5EEC1F0", VA = "0x185EED3F0", Slot = "4")]
		public void UpdateController(float KNBDFHCBHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x94DE50", Offset = "0x94CC50", VA = "0x18094DE50", Slot = "6")]
		public void SetEnabled(bool NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5EED110", Offset = "0x5EEBF10", VA = "0x185EED110")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDCE0", Offset = "0x5EECAE0", VA = "0x185EEDCE0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[AHOEPOHPCNC(ONGLIIBHLOO.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE600", Offset = "0x5EED400", VA = "0x185EEE600")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE5C0", Offset = "0x5EED3C0", VA = "0x185EEE5C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDD10", Offset = "0x5EECB10", VA = "0x185EEDD10")]
		private void BMHOCDLGEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x10E8DE0", Offset = "0x10E7BE0", VA = "0x1810E8DE0", Slot = "4")]
		public void SetEnabled(bool IFBLBHFFNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE630", Offset = "0x5EED430", VA = "0x185EEE630")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarForearmRollController : MonoBehaviour, EEEGEKGFIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private bool JBLAMKLONHJ;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE670", Offset = "0x5EED470", VA = "0x185EEE670", Slot = "4")]
		public void UpdateController(float KNBDFHCBHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BADA0", Offset = "0x7B9BA0", VA = "0x1807BADA0", Slot = "6")]
		public void SetEnabled(bool NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEDF0", Offset = "0x5EEDBF0", VA = "0x185EEEDF0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, NOHPFJOKJCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[AHOEPOHPCNC(ONGLIIBHLOO.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private DADPHPPAKDE GHGCJFDGHEH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DADPHPPAKDE GDHPACLEAIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5EEFB30", Offset = "0x5EEE930", VA = "0x185EEFB30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform PHEHCMAJAEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5EEFB70", Offset = "0x5EEE970", VA = "0x185EEFB70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEE20", Offset = "0x5EEDC20", VA = "0x185EEEE20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF9F0", Offset = "0x5EEE7F0", VA = "0x185EEF9F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF9A0", Offset = "0x5EEE7A0", VA = "0x185EEF9A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF930", Offset = "0x5EEE730", VA = "0x185EEF930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF8B0", Offset = "0x5EEE6B0", VA = "0x185EEF8B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF930", Offset = "0x5EEE730", VA = "0x185EEF930", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEEB0", Offset = "0x5EEDCB0", VA = "0x185EEEEB0", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFA40", Offset = "0x5EEE840", VA = "0x185EEFA40", Slot = "8")]
		public void UpdatePostIKAnimControllers(float KNBDFHCBHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF820", Offset = "0x5EEE620", VA = "0x185EEF820")]
		private void FEKLPDHJGLG(GameObject NHLNHJGAONN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF1E0", Offset = "0x5EEDFE0", VA = "0x185EEF1E0")]
		private DADPHPPAKDE EJAJGMGGHOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public AvatarFullBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct WeightData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is turned off.")]
			public float AngleOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is fully on.")]
			public float AngleOn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			[Tooltip("Normalized height (0-1) where IK is turned off.")]
			public float HeightOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			[Tooltip("Normalized height (0-1) where IK is fully on.")]
			public float HeightOn;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5EF3760", Offset = "0x5EF2560", VA = "0x185EF3760")]
			public float NJPPIGAPOKA(float PMMIOIFDAGO, float DLNIHMNKBAA)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Header("Hand Animation")]
		[Tooltip("Time axis is the normalized distance the hand effector currently is from the origin of the upper arm bone.  A time of 0 implies the hand effector is directly on top of the upper arm origin (ie: up at your shoulder), a time = 1, that implies the hand effector is somewhere exactly a full arm's length away, a time of 1.7 implies the hand effector is somewhere exactly 1.7 times the arm's length away.  Value axis is the effector weight from 0 to 1.")]
		public AnimationCurve HandEffectorWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Time that the hand animator weight changes from 0 to 1 in a second. When the hand gesture system turns on when making a gesture, and off when the gesture system is idle, this determines the speed that it lerps towards the target weight.")]
		public float HandAnimatorWeightChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Time it takes to transition to an open or closed hand pose during an animated hand state transition")]
		public float HandOpenCloseChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D5")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Header("IK Weights")]
		[Tooltip("Control data for when to allow IK to control the head position for screens players.")]
		public WeightData ScreenHeadPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Control data for when to allow IK to control the head rotation for screens players.")]
		public WeightData ScreenHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Control data for when to allow IK to control the pelvis position for screens players.")]
		public WeightData ScreenPelvisPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Control data for when to allow IK to control the pelvis rotation for screens players.")]
		public WeightData ScreenPelvisRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Header("VR runtime weights")]
		[Tooltip("The head is moved flat forward with given amount in VR to match up with our animated head position.")]
		public float StaticHeadForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("The animated root is moved flat forward with given amount in VR to match up the physical feet with our animated feet.")]
		public float StaticRootForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("Weight for head while moving. (0 = animated, 1 = VR)")]
		public float MovingHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("Weight for head while idle. (0 = animated, 1 = VR)")]
		public float IdleHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("Max head height offset compensation")]
		public float MaxHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Min head height offset compensation")]
		public float MinHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Head height offset compensation smooth time")]
		public float HeadHeightCompensationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Distance to apply head movement dampening")]
		public float HeadHeightDampeningDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		public float ShoulderTwistBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("How much to twist when hands are at ShoulderTwistMinDist or ShoulderTwistMaxDist.")]
		public float ShoulderTwistAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Min distance between neck and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Max distance between neck and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFB90", Offset = "0x5EEE990", VA = "0x185EEFB90")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LDFFDKCCEKP : EFNOCEENGMK
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int EPPBHBMPHNE;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int NHBLGDPGFJL;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int DJBEKALIEAA;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int KONDJADCBGE;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int LINBMEFKPHP;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int NCJFHMHHHOD;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int LBLGNAMJKKO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int PCPEEOKIBLN;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int[] IDDAOPLPHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool KDADOAKGADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool BFKFMEOEBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool CIGEKOHMPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private ONCMABEJCBE JBPBEFCHIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private MPOBHJGDLAC NGNGINKBOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private MPOBHJGDLAC AEHMLJCKAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int AMFJBNPFDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private float JIHFAPLDIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform HNDGDNLLDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool AKAKBCKIDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Animator KEELGBOFJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private AvatarFullBodyConfiguration JCKNBPFEBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int DFJKNKFOHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int DFPBPJNLEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int CMOHGBMEEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private float EOFHGBIFFHH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EF27A0", Offset = "0x5EF15A0", VA = "0x185EF27A0", Slot = "8")]
	public void FCIFMHNEBDM(ONCMABEJCBE BMHEKPHNNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2B60", Offset = "0x5EF1960", VA = "0x185EF2B60", Slot = "9")]
	public void IGFFCGBBBDN(GFMCPOLOLKF PPAPJHIJFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2BA0", Offset = "0x5EF19A0", VA = "0x185EF2BA0", Slot = "5")]
	public void IOHFMIFKNBD(bool FDOMNJMGLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2C30", Offset = "0x5EF1A30", VA = "0x185EF2C30", Slot = "4")]
	public void NEKBKGBCGKG(NAEFEJHAAAF BHCHHACICHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EF30C0", Offset = "0x5EF1EC0", VA = "0x185EF30C0")]
	private int ONGOAMOKMGM(MPOBHJGDLAC JMIEJBIMPFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2670", Offset = "0x5EF1470", VA = "0x185EF2670")]
	private void ADJOMBOOKLI(int ACDGGHFIJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2970", Offset = "0x5EF1770", VA = "0x185EF2970")]
	private bool ICCBCKAOEFJ(NAEFEJHAAAF BHCHHACICHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x56243A0", Offset = "0x56231A0", VA = "0x1856243A0", Slot = "6")]
	public bool CGCPFLGEJCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3210", Offset = "0x5EF2010", VA = "0x185EF3210", Slot = "7")]
	public bool PLPKEMIHGKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3080", Offset = "0x5EF1E80", VA = "0x185EF3080")]
	private MPOBHJGDLAC OJPEAEAEBFJ()
	{
		return default(MPOBHJGDLAC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3510", Offset = "0x5EF2310", VA = "0x185EF3510")]
	public LDFFDKCCEKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x27860E0", Offset = "0x2784EE0", VA = "0x1827860E0")]
	[CompilerGenerated]
	internal static bool MBACJKNCGIK<T>(T JGBMOKAGIPB, T? NKKIECLCEML) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class APGLCCJIIIO : DADPHPPAKDE
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class DBKEBDHFFOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private float BKKNGNPAAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private Vector3 HIEKFNKGNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private bool OMNBCOAKENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private float IHKHLOBBMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private bool KGAGJLNNOJP;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1E80", Offset = "0x5EF0C80", VA = "0x185EF1E80")]
		public void ODJLMDJDOAA(IKSolverVR.Arm BGGMBJKLEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1AE0", Offset = "0x5EF08E0", VA = "0x185EF1AE0")]
		public void KHELFFFJIAH(IKSolverVR.Arm BGGMBJKLEFI, Transform IGEPCBKMPJL, bool EEMIENBCFPL, AvatarFullBodyConfiguration LLPOOCEMMPM, float IIECBBHLNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1D40", Offset = "0x5EF0B40", VA = "0x185EF1D40")]
		public void MJKJDBAHFAN(IKSolverVR.Arm BGGMBJKLEFI, bool BADAMNBEGKC, bool NALAJJJKBKL, AvatarFullBodyConfiguration LLPOOCEMMPM, float IIECBBHLNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1610", Offset = "0x5EF0410", VA = "0x185EF1610")]
		private void EPKEIHNFBJA(Transform IGEPCBKMPJL, IKSolverVR.Arm BGGMBJKLEFI, float LKMJCFCHMHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5EF18C0", Offset = "0x5EF06C0", VA = "0x185EF18C0")]
		private void GOGLPHIPOEF(bool EEMIENBCFPL, AvatarFullBodyConfiguration LLPOOCEMMPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1DF0", Offset = "0x5EF0BF0", VA = "0x185EF1DF0")]
		private void MLDEJGPBGCC(AvatarFullBodyConfiguration LLPOOCEMMPM, float IIECBBHLNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1D00", Offset = "0x5EF0B00", VA = "0x185EF1D00")]
		private void LKOLOBBDEGL(IKSolverVR.Arm BGGMBJKLEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1700", Offset = "0x5EF0500", VA = "0x185EF1700")]
		public void FGNOBJOHDHI(IKSolverVR.Arm BGGMBJKLEFI, Transform EJCEABFPDFN, Transform IBGKABIBEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1EB0", Offset = "0x5EF0CB0", VA = "0x185EF1EB0")]
		private static float PNILKECEDAE(bool IFBLBHFFNFB, float BBLKDIDBOGP, float HDBGNJFIPFC, float IKFPMLDOPCG, float IIECBBHLNFH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1930", Offset = "0x5EF0730", VA = "0x185EF1930")]
		private static void JEFLBNCLLMP(Transform HHPFDEKKJDO, Transform KCGGBHNKAEH, Transform DNBELKDLOFB, float EKPEGKHJDKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public DBKEBDHFFOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private enum NNFHCCPMBGI
	{
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private enum GNHGCOHNNPE
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int BIOOGMOHFNO;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int IOMGPMKHKAM;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int DBOOPPMELAG;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int JGLMFCEDJBN;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int JOOIFJCBCDN;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int ABOJBOCILPO;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int IKFIKALOMNP;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int GDJMPENJAME;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int HJJIHBHJPOA;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int AELJICGAFHG;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int FPJHOJODPNK;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int GDJFKCMILGP;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int IOPAGONGPHO;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int GENBCKPHLOJ;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int MEIPCHNNOBA;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int KDANAAOKHED;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int BHOHPLPFMLG;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int ACAGKBDGNNI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int FKLLJOMGHPE;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GMCDKAALMIA;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int FHBIGHMNIJJ;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int DPLBFNFIJMM;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int COENMBIGBPD;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int OOEHIDANDEE;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int MLFJGOFPGKA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int GADLOOAFBCK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int FOBGNIAGIFJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int AOKPIALLFPL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int NJPINKHMNPB;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int FNPLJNILBIM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly Vector3 BBPNHHMNHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool JIJOCDCJHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool EAKOMKKKPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool HJKNEOAMCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool EODOBLICEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool BGJHAGKHBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private Vector3 DLIPNAGJLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private IIIHJOCEJDL? JBPBEFCHIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private AGNPDFIPELD? NMGNGHBGHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private BLHDAANEAHC JGDMIPMMMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private POBPEHPEMEL HFDIEHDCAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private LDFFDKCCEKP LBPJOADFHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private LDFFDKCCEKP LHOMKPMPDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool DMFOGINPLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool OCGAFFLBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly DOJLGLJGCPP BGLJMPGOBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly FCKFLMOMCOM BLBCABADPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int NLFCGICOGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private float HCOPGBCHDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private GameObject ENANFDMGFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Transform DKBKKGOEFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform FNOOEDKPDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private float ECBLENHPMGE;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker FGIOJPLDHNL;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker GCCNMKPACLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private ProfilerMarker ABCGDNMPKEB;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker GMAEGEMKEIK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker DGBJNLGIJDM;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker HKABAOLBFKP;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly List<APGLCCJIIIO> LCNMGFLAFDB;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static int LLACANDDHCB;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> DIKDKJCKJEK;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static int IHLJLPAMEJL;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int DJKNMOHKCDK;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int GBKJDKBPDFC;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int EBEHNADPMFE;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static float LIKDKHDPPFP;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int INJHCCICHCB;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static float OFADNBKIMEF;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static float OAFJDINMPEO;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static float HPBDCEHAGGO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static float JMDMFFCKKGO;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static DDNCIBLHFHO BHELCECMKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float JAPPKLHFAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool DHGKNKHIGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float OMDNAGLKMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private DBKEBDHFFOD GLBBLBOBKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private DBKEBDHFFOD EIJPMBIPMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private NNFHCCPMBGI HBPKEEEPCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private float HPMCPNFFAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly LIENDOFIMNJ DEFCLFBJMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float KGDJAPIBPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float PNHHOGCCLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private Vector3 MJCOJKCJCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly NFPIJNJJLKK JNCODHHBJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly LFFJKBFACIB IECFKKLGPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float AKJFKLGOECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private NNFHCCPMBGI PFDHBIKOLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Vector3 AGPKMHCCPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float AFFLODPAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float MCEAPHNMFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private JJOMFAILCPC PAPMKENPMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private NFPIJNJJLKK LLGIBBMHOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly NFPIJNJJLKK LBIBOAHMFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly JJOMFAILCPC KAJHMOCHJEG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BHHPLLLFBGO IIALMIHIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BHHPLLLFBGO EHOGAJPOOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration APFNDANLLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF340", Offset = "0x5EDE140", VA = "0x185EDF340", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AvatarFullBodyConfiguration HEFKBHEKNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE040", Offset = "0x5EDCE40", VA = "0x185EDE040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform AMNLEGMGEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD500", Offset = "0x5EDC300", VA = "0x185EDD500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform EGCOJCHFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF4E0", Offset = "0x5EDE2E0", VA = "0x185EDF4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private SkinnedMeshRenderer GODMMJOHCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7F70", Offset = "0x5EE6D70", VA = "0x185EE7F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Renderer[] JFPHGJFNDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC690", Offset = "0x5EDB490", VA = "0x185EDC690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GameObject[] LNFPAONGCNF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE400", Offset = "0x5EDD200", VA = "0x185EDE400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Animator EIEOIMNFPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3CC0", Offset = "0x5EE2AC0", VA = "0x185EE3CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private VRIK OKGFCDBBIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EDFC90", Offset = "0x5EDEA90", VA = "0x185EDFC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private EEEGEKGFIKO GFAGKDHNHPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3E60", Offset = "0x5EE2C60", VA = "0x185EE3E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private EEEGEKGFIKO AKFMOJJCHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7060", Offset = "0x5EE5E60", VA = "0x185EE7060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private EEEGEKGFIKO LOHFDBBNEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2250", Offset = "0x5EE1050", VA = "0x185EE2250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EEEGEKGFIKO DDNPCBFGOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3D90", Offset = "0x5EE2B90", VA = "0x185EE3D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private EEEGEKGFIKO DHICLMEAEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5350", Offset = "0x5EE4150", VA = "0x185EE5350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private EEEGEKGFIKO AMKGNGNEBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EE72F0", Offset = "0x5EE60F0", VA = "0x185EE72F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private EEEGEKGFIKO ONCLDLNDOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5EDF410", Offset = "0x5EDE210", VA = "0x185EDF410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private EEEGEKGFIKO DDFNKJFNCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5EE73C0", Offset = "0x5EE61C0", VA = "0x185EE73C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public AGNPDFIPELD BINNECAEMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE0D0", Offset = "0x5EDCED0", VA = "0x185EDE0D0", Slot = "29")]
		get
		{
			return default(AGNPDFIPELD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public BPCILIJFJAB CLCBMOOLAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8489C0", Offset = "0x8477C0", VA = "0x1808489C0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public HMJFCAJBLKB MPJFODEILEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9C6370", Offset = "0x9C5170", VA = "0x1809C6370", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EFNOCEENGMK DDFMMHBNKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xC2E540", Offset = "0xC2D340", VA = "0x180C2E540", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public EFNOCEENGMK LJAEFLOKCAL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9CC600", Offset = "0x9CB400", VA = "0x1809CC600", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GameObject IPHCMOEHILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCF60", Offset = "0x5EDBD60", VA = "0x185EDCF60", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform OOHKOJEJGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x91E420", Offset = "0x91D220", VA = "0x18091E420", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Transform CLNGMCDPILA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x91E400", Offset = "0x91D200", VA = "0x18091E400", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Transform GEAJNOILAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8590", Offset = "0x5EE7390", VA = "0x185EE8590", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool PDDJIIFONBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE4D0", Offset = "0x5EDD2D0", VA = "0x185EDE4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool NBAHJPHEIFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA040", Offset = "0x5EE8E40", VA = "0x185EEA040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3F30", Offset = "0x5EE2D30", VA = "0x185EE3F30")]
	private void JHBFCMPLMFE([In] ELBGEHEHOCD BGEGHPGJPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6450", Offset = "0x5EE5250", VA = "0x185EE6450")]
	private void KJGBFCLFIFH(ELBGEHEHOCD BGEGHPGJPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7130", Offset = "0x5EE5F30", VA = "0x185EE7130")]
	private void LGEABLAMIHD(HIAHHEOBBNO GOPNHEBIDMP, DKEGCHDAJPG PEGNHDEFBOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3A40", Offset = "0x5EE2840", VA = "0x185EE3A40")]
	private void JDAKKLJEGEK([In] ELBGEHEHOCD DCBJOKKHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBDE0", Offset = "0x5EEABE0", VA = "0x185EEBDE0")]
	public APGLCCJIIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCB50", Offset = "0x5EDB950", VA = "0x185EDCB50", Slot = "11")]
	public void AMCICLCLBPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6160", Offset = "0x5EE4F60", VA = "0x185EE6160", Slot = "12")]
	public void KINCFGFDBCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0A00", Offset = "0x5EDF800", VA = "0x185EE0A00", Slot = "13")]
	public void GKLFLLIKMPM(bool AJJAGFJFEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5420", Offset = "0x5EE4220", VA = "0x185EE5420", Slot = "21")]
	public Transform KABMGHMJLPI(string MEBOOKFANFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD100", Offset = "0x5EDBF00", VA = "0x185EDD100", Slot = "22")]
	public Vector3? BBIHBMAFELP(string MEBOOKFANFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9270", Offset = "0x5EE8070", VA = "0x185EE9270", Slot = "6")]
	public void OPGJHECAAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE200", Offset = "0x5EDD000", VA = "0x185EDE200", Slot = "7")]
	public void DEACOGCAJBJ(float HLDFPDCGGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD0B0", Offset = "0x5EDBEB0", VA = "0x185EDD0B0")]
	private void BAKEPGIPBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA230", Offset = "0x5EE9030", VA = "0x185EEA230", Slot = "4")]
	public void PLHOJBLJBLP(IIIHJOCEJDL CMHIJJLGINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EDED80", Offset = "0x5EDDB80", VA = "0x185EDED80", Slot = "5")]
	public void EILAPFJJAGD(AGNPDFIPELD PPAPJHIJFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6DF0", Offset = "0x5EE5BF0", VA = "0x185EE6DF0", Slot = "10")]
	public void KOHKNHGNOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7BD0", Offset = "0x5EE69D0", VA = "0x185EE7BD0", Slot = "20")]
	public void NHGLOLGLAHK([Out] Vector3 BEHDJLPKEHI, [Out] Quaternion DBGOOEMEIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7490", Offset = "0x5EE6290", VA = "0x185EE7490", Slot = "23")]
	public void LPDFJHAHOMO(float EJEMALFNEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD000", Offset = "0x5EDBE00", VA = "0x185EDD000", Slot = "24")]
	public HandLogicOffsets AOHNJHFJCBL()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE76B0", Offset = "0x5EE64B0", VA = "0x185EE76B0", Slot = "25")]
	public PlatformSpecificPlayerHandOffsets NEOIFAJMIAA()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0940", Offset = "0x5EDF740", VA = "0x185EE0940")]
	private void GBEKMJGIPFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8190", Offset = "0x5EE6F90", VA = "0x185EE8190")]
	private void NJEEKNBEODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6EE0", Offset = "0x5EE5CE0", VA = "0x185EE6EE0")]
	private void LEEBKJKNJHK(RigidbodyEx LANGNEMCBEP, bool JEJBEBJPFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE270", Offset = "0x5EDD070", VA = "0x185EDE270")]
	private void DINAEICILJK(RigidbodyEx LANGNEMCBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9070", Offset = "0x5EE7E70", VA = "0x185EE9070")]
	public Vector3 OKCKKMCPPIO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EE00C0", Offset = "0x5EDEEC0", VA = "0x185EE00C0")]
	private void FIBDCGEIPNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7510", Offset = "0x5EE6310", VA = "0x185EE7510")]
	private float NAPMKHDBOIO([In] ELBGEHEHOCD DCBJOKKHJFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EE07E0", Offset = "0x5EDF5E0", VA = "0x185EE07E0")]
	private int FONEEJGMDLB([In] OELKAFHNDMO GAEFJKPEPHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EE68C0", Offset = "0x5EE56C0", VA = "0x185EE68C0")]
	private void KNGJAKELLBK(ELBGEHEHOCD BGEGHPGJPJF, bool HJJEBCJMAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2C80", Offset = "0x5EE1A80", VA = "0x185EE2C80")]
	private static void HLHEFMJHOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2EB0", Offset = "0x5EE1CB0", VA = "0x185EE2EB0")]
	private static void IMPOJKEBJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8040", Offset = "0x5EE6E40", VA = "0x185EE8040")]
	private float NINKAAOJNIE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE85F0", Offset = "0x5EE73F0", VA = "0x185EE85F0")]
	private static int OIBICGEHNFB(APGLCCJIIIO DPMPIPDPNFG, APGLCCJIIIO DJCBILALFKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE18B0", Offset = "0x5EE06B0", VA = "0x185EE18B0")]
	private void HBOJCNMBEOO(ELBGEHEHOCD DCBJOKKHJFC, AvatarFullBodyConfiguration LLPOOCEMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFF80", Offset = "0x5EDED80", VA = "0x185EDFF80")]
	private void FGNOBJOHDHI([In] ELBGEHEHOCD DCBJOKKHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5570", Offset = "0x5EE4370", VA = "0x185EE5570")]
	private void KBIMCHFDJBH([In] ELBGEHEHOCD DCBJOKKHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xCFAAC0", Offset = "0xCF98C0", VA = "0x180CFAAC0")]
	private void OGKMMGMLLGN(RigidbodyEx HEDJKCMPOFO, Transform IBGKABIBEOJ, Transform IKNDOCNOHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5EE08C0", Offset = "0x5EDF6C0", VA = "0x185EE08C0")]
	private float GBDEPGFIAKG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD5D0", Offset = "0x5EDC3D0", VA = "0x185EDD5D0")]
	private void CLMMNGDMNPH([In] ELBGEHEHOCD DCBJOKKHJFC, [In] GNHGCOHNNPE DACDNJNIEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2930", Offset = "0x5EE1730", VA = "0x185EE2930")]
	private void HLBFBNDICON(ELBGEHEHOCD DCBJOKKHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA210", Offset = "0x5EE9010", VA = "0x185EEA210")]
	private void PKHOKBKONOJ(NNFHCCPMBGI IMOMLMOCFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EDFD60", Offset = "0x5EDEB60", VA = "0x185EDFD60")]
	private void FGNKCFJIGKE(float MDAELMJNFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8620", Offset = "0x5EE7420", VA = "0x185EE8620")]
	private void OIJDFPCEFPH([In] ELBGEHEHOCD DCBJOKKHJFC, GNHGCOHNNPE DACDNJNIEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF5B0", Offset = "0x5EDE3B0", VA = "0x185EDF5B0")]
	private Vector3 FFBAOLJHBMC([In] ELBGEHEHOCD DCBJOKKHJFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC760", Offset = "0x5EDB560", VA = "0x185EDC760")]
	private float AKAMNACJBEP(float IGCBBGGEGKK, [In] ELBGEHEHOCD DCBJOKKHJFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC670", Offset = "0x5EDB470", VA = "0x185EDC670")]
	private void ACNDNGPLFJH(NNFHCCPMBGI IMOMLMOCFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA0C0", Offset = "0x5EE8EC0", VA = "0x185EEA0C0")]
	private void PKEIGCDMDKF(float IGCBBGGEGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2320", Offset = "0x5EE1120", VA = "0x185EE2320")]
	private void HKBIGCBJMNF([In] ELBGEHEHOCD DCBJOKKHJFC, GNHGCOHNNPE DACDNJNIEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE56F0", Offset = "0x5EE44F0", VA = "0x185EE56F0")]
	private float KCMDJOMAFCH([In] ELBGEHEHOCD BGEGHPGJPJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE860", Offset = "0x5EDD660", VA = "0x185EDE860")]
	private void EHLCKHMHDIE(ELBGEHEHOCD DCBJOKKHJFC, GNHGCOHNNPE DACDNJNIEGL, Vector3 FEAEIGBFDNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EE90C0", Offset = "0x5EE7EC0", VA = "0x185EE90C0")]
	private static void OLGNLNNDJCF(Transform PFIKOEBPDGA, Quaternion GJMDICOFEBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8D70", Offset = "0x5EE7B70", VA = "0x185EE8D70")]
	private void OJIBGLBBNJP([In] ELBGEHEHOCD JNMMGILKPCL, [In] OELKAFHNDMO GAEFJKPEPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0130", Offset = "0x5EDEF30", VA = "0x185EE0130")]
	private void FNEGFAMDFPM([In] ELBGEHEHOCD JNMMGILKPCL, [In] OELKAFHNDMO GAEFJKPEPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5B00", Offset = "0x5EE4900", VA = "0x185EE5B00")]
	private void KEKEJFEDLMJ([In] ELBGEHEHOCD DCBJOKKHJFC, [In] AvatarFullBodyConfiguration LLPOOCEMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD290", Offset = "0x5EDC090", VA = "0x185EDD290")]
	public void BENGNHMLLHJ([In] ELBGEHEHOCD DCBJOKKHJFC, [In] AvatarFullBodyConfiguration LLPOOCEMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5EE12C0", Offset = "0x5EE00C0", VA = "0x185EE12C0", Slot = "30")]
	protected virtual void HAOCCMLCLCL([In] ELBGEHEHOCD DCBJOKKHJFC, [In] AvatarFullBodyConfiguration LLPOOCEMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE530", Offset = "0x5EDD330", VA = "0x185EDE530")]
	private void EHJOJENGLMG([In] ELBGEHEHOCD DCBJOKKHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7770", Offset = "0x5EE6570", VA = "0x185EE7770")]
	private void NGJCEAPFFHJ(float BDMEBCIPFDC, [In] ELBGEHEHOCD BGEGHPGJPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDBF0", Offset = "0x5EDC9F0", VA = "0x185EDDBF0")]
	private float CMFADJBOHPO([In] AvatarFullBodyConfiguration LLPOOCEMMPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF200", Offset = "0x5EDE000", VA = "0x185EDF200")]
	private void EMBBPELMPOJ([In] ELBGEHEHOCD BGEGHPGJPJF, [In] AvatarFullBodyConfiguration LLPOOCEMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6490", Offset = "0x5EE5290", VA = "0x185EE6490")]
	private void KKPEJLCHOOA([In] ELBGEHEHOCD BGEGHPGJPJF, float NLLKKKPLBPC, float JKNGOMBLOOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0AD0", Offset = "0x5EDF8D0", VA = "0x185EE0AD0")]
	private void GPEKGIBDLNI(ELBGEHEHOCD BGEGHPGJPJF, AvatarFullBodyConfiguration LLPOOCEMMPM)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum MDOMOLHPINM
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		[AHOEPOHPCNC(ONGLIIBHLOO.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private MDOMOLHPINM handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0430", Offset = "0x5EEF230", VA = "0x185EF0430")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF03F0", Offset = "0x5EEF1F0", VA = "0x185EF03F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFDC0", Offset = "0x5EEEBC0", VA = "0x185EEFDC0")]
		private void BMHOCDLGEBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x10E8DE0", Offset = "0x10E7BE0", VA = "0x1810E8DE0", Slot = "4")]
		public void SetEnabled(bool IFBLBHFFNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0460", Offset = "0x5EEF260", VA = "0x185EF0460")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarKneeBendTargetController : MonoBehaviour, EEEGEKGFIKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		[AHOEPOHPCNC(ONGLIIBHLOO.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Vector3 IIBLIOGOELJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Vector3 IPKOKOEAOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Vector3 DIPLBINOMEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Matrix4x4 PCIKDNGDHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private bool JBLAMKLONHJ;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EF08F0", Offset = "0x5EEF6F0", VA = "0x185EF08F0", Slot = "4")]
		public void UpdateController(float KNBDFHCBHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E07AF0", Offset = "0x5E068F0", VA = "0x185E07AF0", Slot = "6")]
		public void SetEnabled(bool NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0490", Offset = "0x5EEF290", VA = "0x185EF0490")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0FB0", Offset = "0x5EEFDB0", VA = "0x185EF0FB0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class FGJFNKAHGON : AFAOOOOPPHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private Dictionary<string, DADPHPPAKDE> PBIFDIJFIAH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool KDBGHBDDDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2100", Offset = "0x5EF0F00", VA = "0x185EF2100")]
	[NAAAALLPNIA(KMIEHGCCHON.Root, PBKIGNPNCFO.None)]
	private static void JEDOJGHIGGJ(IBPIJCMLLGH PPDHICBEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1F40", Offset = "0x5EF0D40", VA = "0x185EF1F40", Slot = "4")]
	public DADPHPPAKDE FHLFHMLACJO(string LHGBCFFFIGB, AvatarSystemConfiguration LKCLDCILMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2200", Offset = "0x5EF1000", VA = "0x185EF2200", Slot = "5")]
	public void PPOIPKAICLH(string LHGBCFFFIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2390", Offset = "0x5EF1190", VA = "0x185EF2390")]
	public FGJFNKAHGON()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public class FMEILPOCCJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private Dictionary<string, Transform> MBBFHKILBNO;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public bool CHDBPBGLOPC
			{
				[Cpp2IlInjected.Token(Token = "0x60000B1")]
				[Cpp2IlInjected.Address(RVA = "0x5EF2420", Offset = "0x5EF1220", VA = "0x185EF2420")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5EF2460", Offset = "0x5EF1260", VA = "0x185EF2460")]
			public void KMCPJDPPDAF(VRIK LGLJFKAHPCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
			public void BLNEOGMNCBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x5EF2590", Offset = "0x5EF1390", VA = "0x185EF2590")]
			public void MNGHADJNDMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5EF25E0", Offset = "0x5EF13E0", VA = "0x185EF25E0")]
			public FMEILPOCCJE()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		[KNLLPIHNEKK(ONGLIIBHLOO.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		[AHOEPOHPCNC(ONGLIIBHLOO.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly FMEILPOCCJE IHKCANBCEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private NOHPFJOKJCB MMKCEAHICAA;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1010", Offset = "0x5EEFE10", VA = "0x185EF1010")]
		private void FCIFMHNEBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0FC0", Offset = "0x5EEFDC0", VA = "0x185EF0FC0")]
		private bool FBGKGPMECJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5EF12D0", Offset = "0x5EF00D0", VA = "0x185EF12D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1340", Offset = "0x5EF0140", VA = "0x185EF1340")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF12E0", Offset = "0x5EF00E0", VA = "0x185EF12E0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1530", Offset = "0x5EF0330", VA = "0x185EF1530")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3520", Offset = "0x5EF2320", VA = "0x185EF3520", Slot = "4")]
		public override void OnStateEnter(Animator KLPFFLMNLMJ, AnimatorStateInfo BHBEJJPAKMI, int IAMLPCJJMKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3640", Offset = "0x5EF2440", VA = "0x185EF3640")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC1E0", Offset = "0x5EEAFE0", VA = "0x185EEC1E0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public AnimatorDebugUtil()
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
