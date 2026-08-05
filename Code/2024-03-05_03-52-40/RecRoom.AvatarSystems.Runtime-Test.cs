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
	public class AvatarElbowBendHelperController : MonoBehaviour, AOJODJHLOLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
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
		private Vector3? KNDLOFPDIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool BNHHCKJJMBP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5FC64D0", Offset = "0x5FC52D0", VA = "0x185FC64D0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6AD0", Offset = "0x5FC58D0", VA = "0x185FC6AD0", Slot = "4")]
		public void UpdateController(float LDLIGJLNGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCCAC90", Offset = "0xCC9A90", VA = "0x180CCAC90", Slot = "6")]
		public void SetEnabled(bool MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6570", Offset = "0x5FC5370", VA = "0x185FC6570")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6EE0", Offset = "0x5FC5CE0", VA = "0x185FC6EE0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AvatarElbowBendTargetController : MonoBehaviour, AOJODJHLOLL
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const float KBCLJPHFNOE = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
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
		private Vector3 MMJNDGEGFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Vector3 HIHLNCGFIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool BNHHCKJJMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float HONANACKFHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private float GIDHCOLBIDG;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7260", Offset = "0x5FC6060", VA = "0x185FC7260", Slot = "4")]
		public void UpdateController(float LDLIGJLNGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BD890", Offset = "0x9BC690", VA = "0x1809BD890", Slot = "6")]
		public void SetEnabled(bool MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6F80", Offset = "0x5FC5D80", VA = "0x185FC6F80")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7B50", Offset = "0x5FC6950", VA = "0x185FC7B50")]
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
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC8470", Offset = "0x5FC7270", VA = "0x185FC8470")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8430", Offset = "0x5FC7230", VA = "0x185FC8430")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FC7B80", Offset = "0x5FC6980", VA = "0x185FC7B80")]
		private void OBLKBHOCIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x11356F0", Offset = "0x11344F0", VA = "0x1811356F0", Slot = "4")]
		public void SetEnabled(bool IBCOHIKFCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC84A0", Offset = "0x5FC72A0", VA = "0x185FC84A0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarForearmRollController : MonoBehaviour, AOJODJHLOLL
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
		private bool BNHHCKJJMBP;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5FC84E0", Offset = "0x5FC72E0", VA = "0x185FC84E0", Slot = "4")]
		public void UpdateController(float LDLIGJLNGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CAA70", Offset = "0x7C9870", VA = "0x1807CAA70", Slot = "6")]
		public void SetEnabled(bool MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8C60", Offset = "0x5FC7A60", VA = "0x185FC8C60")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, KBFJOBOCLDK
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
		[LNDIHOOGFKF(HLOGMCICCDP.SelfAndChildren, false, false, false)]
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
		private IIHBHCNEHEK MNEHGFOIMPJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IIHBHCNEHEK DLPLEOFNMPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5FC99A0", Offset = "0x5FC87A0", VA = "0x185FC99A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform IHHHDNMEJIN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5FC99E0", Offset = "0x5FC87E0", VA = "0x185FC99E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8C90", Offset = "0x5FC7A90", VA = "0x185FC8C90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FC97D0", Offset = "0x5FC85D0", VA = "0x185FC97D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9780", Offset = "0x5FC8580", VA = "0x185FC9780")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9710", Offset = "0x5FC8510", VA = "0x185FC9710")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9690", Offset = "0x5FC8490", VA = "0x185FC9690", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9710", Offset = "0x5FC8510", VA = "0x185FC9710", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FC8D20", Offset = "0x5FC7B20", VA = "0x185FC8D20", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5FC98B0", Offset = "0x5FC86B0", VA = "0x185FC98B0", Slot = "8")]
		public void UpdatePostIKAnimControllers(float LDLIGJLNGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9820", Offset = "0x5FC8620", VA = "0x185FC9820")]
		private void PHDEAJKAPCM(GameObject KDHDNCADFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9050", Offset = "0x5FC7E50", VA = "0x185FC9050")]
		private IIHBHCNEHEK IGJCOHNLEBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5FDD210", Offset = "0x5FDC010", VA = "0x185FDD210")]
			public float NNLLGANPOGC(float FIHPJMEFNGM, float FAENFMEAMKM)
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
		[Cpp2IlInjected.Address(RVA = "0x5FC9A00", Offset = "0x5FC8800", VA = "0x185FC9A00")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CCFAHOOPDML : NHLKCANPCFG
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int OBLGKDCGMGK;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int OGPEEDEIKKN;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int BDIEMAPPILP;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int BGDCNKFJMED;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int PMGNMBOLODF;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int PBCHOOCEGJM;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int FBGCJENOFIF;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int KILIDBLLIAE;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int[] LCHHGNELAIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool LEAIODJPCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool DIMDIKKGMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool LFNHMEBAKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private MBLMKOGLHEC KPMAOFHLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private BGJNMNIBHPK EAJLGBFCKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private BGJNMNIBHPK OGKCJIDFLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int EIKOIEOMKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private float HGDOKPLIMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform CGEHBADEJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool JPHFKGJIMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Animator AGCCKNLDODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private AvatarFullBodyConfiguration DLFOAEAEGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int MFAFPDNADKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int OEOFJCPPHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int EEBMLBFMLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private float HKDOCCBIDLD;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC640", Offset = "0x5FCB440", VA = "0x185FCC640", Slot = "8")]
	public void KCJBJGBIMAI(MBLMKOGLHEC EJDIMMKPPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC570", Offset = "0x5FCB370", VA = "0x185FCC570", Slot = "9")]
	public void JHMEPIPCLJD(EEGLGMLBPIB JDEFGAPKEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC5B0", Offset = "0x5FCB3B0", VA = "0x185FCC5B0", Slot = "5")]
	public void JPNFEAKJGAH(bool MCFOJMEHHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBDC0", Offset = "0x5FCABC0", VA = "0x185FCBDC0", Slot = "4")]
	public void DGJICOMOOCA(LBKOMDIMHBN CBHJIFHDKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC810", Offset = "0x5FCB610", VA = "0x185FCC810")]
	private int KCKJACGNMDH(BGJNMNIBHPK AIJOAJPEEHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC440", Offset = "0x5FCB240", VA = "0x185FCC440")]
	private void FOMIPBICAPN(int NKMNDOPDIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC250", Offset = "0x5FCB050", VA = "0x185FCC250")]
	private bool FKNHHIODKGK(LBKOMDIMHBN CBHJIFHDKEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x570A400", Offset = "0x5709200", VA = "0x18570A400", Slot = "6")]
	public bool APOGCODJJFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCBDB0", Offset = "0x5FCABB0", VA = "0x185FCBDB0", Slot = "7")]
	public bool DCHDDKMGHAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FCC210", Offset = "0x5FCB010", VA = "0x185FCC210")]
	private BGJNMNIBHPK FIMBIELMOLE()
	{
		return default(BGJNMNIBHPK);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCC50", Offset = "0x5FCBA50", VA = "0x185FCCC50")]
	public CCFAHOOPDML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x258A560", Offset = "0x2589360", VA = "0x18258A560")]
	[CompilerGenerated]
	internal static bool MIBGHPIKLKB<T>(T OMBIDINGJJL, T? MAEBFBHFPDE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class HNPIDBPFDDD : IIHBHCNEHEK
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class BAFMHAOCABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private float LHLCBBIIKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private Vector3 BPNKEBBJGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private bool COPFAEAHLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private float JFLOFKNFHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private bool EIOMGDHKJGP;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBB90", Offset = "0x5FCA990", VA = "0x185FCBB90")]
		public void JAHFGGKNJDK(IKSolverVR.Arm POGGHIABKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB480", Offset = "0x5FCA280", VA = "0x185FCB480")]
		public void AAELAMCDFBM(IKSolverVR.Arm POGGHIABKEF, Transform ABOADCCPKJL, bool LLHOMJLFBDO, AvatarFullBodyConfiguration OMMMKKDJPJK, float APGOABKBKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB6A0", Offset = "0x5FCA4A0", VA = "0x185FCB6A0")]
		public void BELIOIMHOGN(IKSolverVR.Arm POGGHIABKEF, bool EMFEFHEKLLI, bool MCKKMMJDJKJ, AvatarFullBodyConfiguration OMMMKKDJPJK, float APGOABKBKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBBC0", Offset = "0x5FCA9C0", VA = "0x185FCBBC0")]
		private void MDBDHHHIADG(Transform ABOADCCPKJL, IKSolverVR.Arm POGGHIABKEF, float CMMJPPBHOBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBCB0", Offset = "0x5FCAAB0", VA = "0x185FCBCB0")]
		private void PABLHFEMDLG(bool LLHOMJLFBDO, AvatarFullBodyConfiguration OMMMKKDJPJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBD20", Offset = "0x5FCAB20", VA = "0x185FCBD20")]
		private void PFLLJIGGJHP(AvatarFullBodyConfiguration OMMMKKDJPJK, float APGOABKBKLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5FCBB50", Offset = "0x5FCA950", VA = "0x185FCBB50")]
		private void FKMBCEEFOOA(IKSolverVR.Arm POGGHIABKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB750", Offset = "0x5FCA550", VA = "0x185FCB750")]
		public void DIHBJOFNNCG(IKSolverVR.Arm POGGHIABKEF, Transform CNKDNMOALCD, Transform GLIPPAPBBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB910", Offset = "0x5FCA710", VA = "0x185FCB910")]
		private static float DKAHNGNMCME(bool IBCOHIKFCFK, float PCCBOCOMPKF, float DLPFBFCNMON, float LBAKDFMJGFH, float APGOABKBKLL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB9A0", Offset = "0x5FCA7A0", VA = "0x185FCB9A0")]
		private static void EGKBAPKGIJF(Transform AJCECFNBMCP, Transform DMEBABBPAAN, Transform DKCKMCFEOAN, float FIHOJDEAFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public BAFMHAOCABJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private enum IGAHPAFCPPG
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
	private enum BFMMNIGPHMN
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int IPLNLIBBMNI;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int NEMMBHDLJAI;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int DKAIIPEDKDC;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int DHADDCGNHCA;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int GAENHHEGJDI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int JKADAAEDINL;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int FBFNEFCIANO;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int FLAPIKMCEDD;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int ODILNKCBNAD;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int HOLAAJMMOOA;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int CJBPBHIDGOM;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int CJFJHLINDPI;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int MBHMFKNCHPH;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int GJPGFEGIJPB;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int ONCBJPJHFLM;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int OOALDPILPBN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int BECMPEDKLKB;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int KMHIIMPFLKD;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int PHFOOOCMBOA;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int FMBGEKHPBFD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int NIEBPLMPPCA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int ABAMOMMDDNO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int PCKCFLEEOMJ;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int NPMBGLJODGO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int DDMJMAJIBJI;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int HEKENBGMGLD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int EGFKLCFBHNB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int MMEJAMMDEEJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int AHIAALMNMLF;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int FMGFNDJOCMJ;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly Vector3 ELACFECMNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool ELBLIEGEEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool DHENBMECBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool MAPFEHBMPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool LAAMHNAEBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool GJCHGLHEKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private Vector3 HOGMAHGPBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private DEIKAEENBFK? KPMAOFHLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private DJNDBFPCKDA? GBEHODAHABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private FDDEHFBFJDN HCANLPELLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private OGNENPEFHEP LDFMFONMAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private CCFAHOOPDML KLFDIIFLEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private CCFAHOOPDML DDFHMHFDBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool NHMNEJBANFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool JKAPMAKCLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly GECHHFKNOKI PHIKGDOPAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly JJJLBNKOAOM HHMLNHEEAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private int GLMIPNHMBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private float CBMMBHLKBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private GameObject OMLLPFIMEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Transform FGHHAEEKNCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Transform JCMDNGABOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private float DDEHCIAPGMG;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker PKBGJHKEKPE;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker AKHFPNGDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private ProfilerMarker AHJKBECJKBO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker JAIEJNHPIPK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker PHEOPMIFFFF;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker LLHCDKGDOCC;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly List<HNPIDBPFDDD> ELOKFMLEACH;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static int HOPHJGGEENP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> EEEKHGKGFBF;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static int EOFINDJFEGH;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int GGJMIHKPPLM;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int KEHEALFPDCF;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int KHPBEGGEFKL;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static float EJHKNIPEAMA;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int INEGBEBMAGK;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static float HEKCJBBNOKG;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static float AJIALINNNGD;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static float HLLONLFBBPF;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static float PHOBODHGMLM;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static FCHDBGKGDKP ENIICPCIKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float IAMAMJPNBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool NDLDOFIJMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float BBNOHBFBDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private BAFMHAOCABJ POEOEIDBHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private BAFMHAOCABJ GKGFJKDEADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private IGAHPAFCPPG PMEHMGCKNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private float EOINAGCJPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly KDLGFBEEMCE LHMEGDEMDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float HIOEKJBEDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float BAAOHKLAEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private Vector3 JGLIBGGOFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly LHPKODEDFAM HOIEHOINMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly PPPJJCHHJOM KBNMOOBECLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float NMLDBDPGJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private IGAHPAFCPPG AGJEGOOLDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private Vector3 LAAIBKCGAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float CHOEHHFKPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private float ALBCBAHLCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private IJLOAFDFOEO CBNHKLHONNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private LHPKODEDFAM AHHNBCLLPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly LHPKODEDFAM OAJIIIHEIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly IJLOAFDFOEO GPLBPGOIFDC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CGNODMPJOCB LIAJDNBCFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CGNODMPJOCB BMHEBGCEJIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration BDAKCAKJGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5FD72E0", Offset = "0x5FD60E0", VA = "0x185FD72E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AvatarFullBodyConfiguration NFAFOKOOLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5FD6AE0", Offset = "0x5FD58E0", VA = "0x185FD6AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform HEOHEIFNJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB0E0", Offset = "0x5FD9EE0", VA = "0x185FDB0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform MJCGLHIHFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD470", Offset = "0x5FCC270", VA = "0x185FCD470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private SkinnedMeshRenderer MKOCDACCHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8F70", Offset = "0x5FD7D70", VA = "0x185FD8F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Renderer[] PCOEFCEGCCE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB290", Offset = "0x5FDA090", VA = "0x185FDB290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GameObject[] BCHPELNAOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5FDB7E0", Offset = "0x5FDA5E0", VA = "0x185FDB7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Animator JKBFOIOMKFD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD3A0", Offset = "0x5FCC1A0", VA = "0x185FCD3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private VRIK OPEMOLLBNIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7120", Offset = "0x5FD5F20", VA = "0x185FD7120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private AOJODJHLOLL JOGICKEFCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5FD8420", Offset = "0x5FD7220", VA = "0x185FD8420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private AOJODJHLOLL EMAAMMKKCJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0CE0", Offset = "0x5FCFAE0", VA = "0x185FD0CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private AOJODJHLOLL JNJMEBGDFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FD89B0", Offset = "0x5FD77B0", VA = "0x185FD89B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private AOJODJHLOLL EBJDDMFGBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2440", Offset = "0x5FD1240", VA = "0x185FD2440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private AOJODJHLOLL JAOMKGMOKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5FD7050", Offset = "0x5FD5E50", VA = "0x185FD7050")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private AOJODJHLOLL CEILILGHAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5FD22A0", Offset = "0x5FD10A0", VA = "0x185FD22A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private AOJODJHLOLL JAOHLEGIOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FD6A10", Offset = "0x5FD5810", VA = "0x185FD6A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private AOJODJHLOLL GKAMGEBIPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5FD2370", Offset = "0x5FD1170", VA = "0x185FD2370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DJNDBFPCKDA AKAHLBPKKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4A40", Offset = "0x5FD3840", VA = "0x185FD4A40", Slot = "30")]
		get
		{
			return default(DJNDBFPCKDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LFGCKKFEBFK LLDNFLCCDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89C730", Offset = "0x89B530", VA = "0x18089C730", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GILJNEKLJLL HHCKOJIIJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA1BA40", Offset = "0xA1A840", VA = "0x180A1BA40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public NHLKCANPCFG FLOCOAJAPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xD96430", Offset = "0xD95230", VA = "0x180D96430", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public NHLKCANPCFG CPINMKNEPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA21CD0", Offset = "0xA20AD0", VA = "0x180A21CD0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GameObject EAPMMKKAJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FD0C40", Offset = "0x5FCFA40", VA = "0x185FD0C40", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform DNONAIKBLML
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9732C0", Offset = "0x9720C0", VA = "0x1809732C0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Transform NMJMCJDICCB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9732A0", Offset = "0x9720A0", VA = "0x1809732A0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Transform HOOFLMMMOLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5FD3C90", Offset = "0x5FD2A90", VA = "0x185FD3C90", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool DEDHNAKHJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5FCD2D0", Offset = "0x5FCC0D0", VA = "0x185FCD2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool ICGONCDLKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5FD4B70", Offset = "0x5FD3970", VA = "0x185FD4B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0DB0", Offset = "0x5FCFBB0", VA = "0x185FD0DB0")]
	private void EDKIKDOJNFC([In] CODCBNFLDDH LNMEHICKMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FD84F0", Offset = "0x5FD72F0", VA = "0x185FD84F0")]
	private void LEMBAECFNKF(CODCBNFLDDH LNMEHICKMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9510", Offset = "0x5FD8310", VA = "0x185FD9510")]
	private void MOGOJAOMDNF(CCEAABLGCHA FMLCLNALIHF, MADFJECJAOI AJEMCGPEJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD050", Offset = "0x5FCBE50", VA = "0x185FCD050")]
	private void AEIBIIHDMKH([In] CODCBNFLDDH OHBBLINCHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FDC6F0", Offset = "0x5FDB4F0", VA = "0x185FDC6F0")]
	public HNPIDBPFDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD700", Offset = "0x5FCC500", VA = "0x185FCD700", Slot = "11")]
	public void CCCGAJDPGFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB360", Offset = "0x5FDA160", VA = "0x185FDB360", Slot = "12")]
	public void PGFPCDJIJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6F80", Offset = "0x5FD5D80", VA = "0x185FD6F80", Slot = "13")]
	public void IGGIHHOGJHO(bool HKHIOAPLDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAC40", Offset = "0x5FD9A40", VA = "0x185FDAC40", Slot = "21")]
	public Transform OALCNKEHIAB(string KDOOHOOLJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB650", Offset = "0x5FDA450", VA = "0x185FDB650", Slot = "22")]
	public Vector3? PHGGBHIILLJ(string KDOOHOOLJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE6D0", Offset = "0x5FCD4D0", VA = "0x185FCE6D0", Slot = "6")]
	public void CMCAJPHFKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2F00", Offset = "0x5FD1D00", VA = "0x185FD2F00", Slot = "7")]
	public void GIENBPCDPCI(float MIHLOAODPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6120", Offset = "0x5FD4F20", VA = "0x185FD6120")]
	private void HOFIGNEOFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4BF0", Offset = "0x5FD39F0", VA = "0x185FD4BF0", Slot = "4")]
	public void HMDCMDPGHEC(DEIKAEENBFK GBMGNCIFBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FD8530", Offset = "0x5FD7330", VA = "0x185FD8530", Slot = "5")]
	public void LHPHANGFGNG(DJNDBFPCKDA JDEFGAPKEPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FD71F0", Offset = "0x5FD5FF0", VA = "0x185FD71F0", Slot = "10")]
	public void IMOEACLEFDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FD8BD0", Offset = "0x5FD79D0", VA = "0x185FD8BD0", Slot = "20")]
	public void MEOJPCMINEF([Out] Vector3 DPEHJJEHHDK, [Out] Quaternion MNGPCJCMEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE650", Offset = "0x5FCD450", VA = "0x185FCE650", Slot = "23")]
	public void CLDPGMELBMG(float AFGCEFOAOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD21D0", Offset = "0x5FD0FD0", VA = "0x185FD21D0", Slot = "24")]
	public void EFPMEADIDOJ(bool FIIFMLKAIAF, bool EKOHJKKLLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB030", Offset = "0x5FD9E30", VA = "0x185FDB030", Slot = "25")]
	public HandLogicOffsets OMBEOKGOLMG()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDADE0", Offset = "0x5FD9BE0", VA = "0x185FDADE0", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets OHCPPPDCDKM()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5FD73B0", Offset = "0x5FD61B0", VA = "0x185FD73B0")]
	private void JMKKBJHOLHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB8B0", Offset = "0x5FDA6B0", VA = "0x185FDB8B0")]
	private void PNHIIHAJGLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9390", Offset = "0x5FD8190", VA = "0x185FD9390")]
	private void MLGHKHOFIGJ(RigidbodyEx LHEEGIGDIFG, bool LAELABDCPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAEA0", Offset = "0x5FD9CA0", VA = "0x185FDAEA0")]
	private void OKKGLHBIBIN(RigidbodyEx LHEEGIGDIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FDAD90", Offset = "0x5FD9B90", VA = "0x185FDAD90")]
	public Vector3 ODBHODLILNM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD330", Offset = "0x5FCC130", VA = "0x185FCD330")]
	private void AMLLLOFGANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5FCCEB0", Offset = "0x5FCBCB0", VA = "0x185FCCEB0")]
	private float ADJHMCIDPAP([In] CODCBNFLDDH OHBBLINCHPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5FDB1B0", Offset = "0x5FD9FB0", VA = "0x185FDB1B0")]
	private int PDMBEPFGGGM([In] PLECLFNDEJH LPPIMLHBMOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3760", Offset = "0x5FD2560", VA = "0x185FD3760")]
	private void HAEIJANCIDK(CODCBNFLDDH LNMEHICKMNC, bool FMDMGJPBKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD75F0", Offset = "0x5FD63F0", VA = "0x185FD75F0")]
	private static void KCHIDAMMFJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD99D0", Offset = "0x5FD87D0", VA = "0x185FD99D0")]
	private static void NDPFGFNJJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDBCB0", Offset = "0x5FDAAB0", VA = "0x185FDBCB0")]
	private float POMDDDGAIBO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2510", Offset = "0x5FD1310", VA = "0x185FD2510")]
	private static int FAOJKGFPJCH(HNPIDBPFDDD LDPIALBNJEB, HNPIDBPFDDD HLCIAKLFNHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2560", Offset = "0x5FD1360", VA = "0x185FD2560")]
	private void GDCICDFEAGC(CODCBNFLDDH OHBBLINCHPH, AvatarFullBodyConfiguration OMMMKKDJPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0B00", Offset = "0x5FCF900", VA = "0x185FD0B00")]
	private void DIHBJOFNNCG([In] CODCBNFLDDH OHBBLINCHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7470", Offset = "0x5FD6270", VA = "0x185FD7470")]
	private void KAHOIOIJKBH([In] CODCBNFLDDH OHBBLINCHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xD34FD0", Offset = "0xD33DD0", VA = "0x180D34FD0")]
	private void FKIGNGGBAJB(RigidbodyEx KEJCGDNAPEK, Transform GLIPPAPBBCJ, Transform HEGIBJPEGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD540", Offset = "0x5FCC340", VA = "0x185FCD540")]
	private float BDDNBHHPBFJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5FCDB10", Offset = "0x5FCC910", VA = "0x185FCDB10")]
	private void CGANEBGCFKN([In] CODCBNFLDDH OHBBLINCHPH, [In] BFMMNIGPHMN OHEIDHKNFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5FD9040", Offset = "0x5FD7E40", VA = "0x185FD9040")]
	private void MLCGHNGCBKA(CODCBNFLDDH OHBBLINCHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2540", Offset = "0x5FD1340", VA = "0x185FD2540")]
	private void FIOIAOHHDFL(IGAHPAFCPPG FLCGGBBKFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6170", Offset = "0x5FD4F70", VA = "0x185FD6170")]
	private void HOHNKAEHIEL(float IKEBFKPLNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FD42F0", Offset = "0x5FD30F0", VA = "0x185FD42F0")]
	private void HELPBFNHGBK([In] CODCBNFLDDH OHBBLINCHPH, BFMMNIGPHMN OHEIDHKNFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5FDA560", Offset = "0x5FD9360", VA = "0x185FDA560")]
	private Vector3 NOGMOMMMBND([In] CODCBNFLDDH OHBBLINCHPH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0710", Offset = "0x5FCF510", VA = "0x185FD0710")]
	private float DEMJLEKFNPB(float DGGFMILBIAI, [In] CODCBNFLDDH OHBBLINCHPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD69F0", Offset = "0x5FD57F0", VA = "0x185FD69F0")]
	private void HPMKADHLPAO(IGAHPAFCPPG FLCGGBBKFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5FD8A80", Offset = "0x5FD7880", VA = "0x185FD8A80")]
	private void MDNJKLGPMEC(float DGGFMILBIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7820", Offset = "0x5FD6620", VA = "0x185FD7820")]
	private void KNAHIFKABHD([In] CODCBNFLDDH OHBBLINCHPH, BFMMNIGPHMN OHEIDHKNFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6B70", Offset = "0x5FD5970", VA = "0x185FD6B70")]
	private float IEHDEHFAMEC([In] CODCBNFLDDH LNMEHICKMNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5FCE130", Offset = "0x5FCCF30", VA = "0x185FCE130")]
	private void CJJFLEKMEJB(CODCBNFLDDH OHBBLINCHPH, BFMMNIGPHMN OHEIDHKNFOJ, Vector3 BCHIDDHABOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3CF0", Offset = "0x5FD2AF0", VA = "0x185FD3CF0")]
	private static void HBPOIGAHKGP(Transform NBCGMJPEDEM, Quaternion OKEJHHGCFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5FD96D0", Offset = "0x5FD84D0", VA = "0x185FD96D0")]
	private void NDJHPJKNPGP([In] CODCBNFLDDH JJOPHPBKPDG, [In] PLECLFNDEJH LPPIMLHBMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5FD0060", Offset = "0x5FCEE60", VA = "0x185FD0060")]
	private void DELDIICMMLD([In] CODCBNFLDDH JJOPHPBKPDG, [In] PLECLFNDEJH LPPIMLHBMOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5FD6390", Offset = "0x5FD5190", VA = "0x185FD6390")]
	private void HPDPHOGDFDE([In] CODCBNFLDDH OHBBLINCHPH, [In] AvatarFullBodyConfiguration OMMMKKDJPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5FD5EB0", Offset = "0x5FD4CB0", VA = "0x185FD5EB0")]
	public void HMNOOKLMODE([In] CODCBNFLDDH OHBBLINCHPH, [In] AvatarFullBodyConfiguration OMMMKKDJPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5FD7E30", Offset = "0x5FD6C30", VA = "0x185FD7E30", Slot = "31")]
	protected virtual void LANAPDMMPDF([In] CODCBNFLDDH OHBBLINCHPH, [In] AvatarFullBodyConfiguration OMMMKKDJPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF4A0", Offset = "0x5FCE2A0", VA = "0x185FCF4A0")]
	private void CNCHLPOEAKI([In] CODCBNFLDDH OHBBLINCHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5FCF7D0", Offset = "0x5FCE5D0", VA = "0x185FCF7D0")]
	private void CNHHAGBHPOO(float KDINPBMLBPH, [In] CODCBNFLDDH LNMEHICKMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FD3EA0", Offset = "0x5FD2CA0", VA = "0x185FD3EA0")]
	private float HDODELCKOBO([In] AvatarFullBodyConfiguration OMMMKKDJPJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FCD5C0", Offset = "0x5FCC3C0", VA = "0x185FCD5C0")]
	private void BGCDHKOOHDI([In] CODCBNFLDDH LNMEHICKMNC, [In] AvatarFullBodyConfiguration OMMMKKDJPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5FCFC30", Offset = "0x5FCEA30", VA = "0x185FCFC30")]
	private void DCDKGDLNLON([In] CODCBNFLDDH LNMEHICKMNC, float PBBJDMGIPJF, float FMOGOCKLNGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5FD2F70", Offset = "0x5FD1D70", VA = "0x185FD2F70")]
	private void GMEHFIDNHKO(CODCBNFLDDH LNMEHICKMNC, AvatarFullBodyConfiguration OMMMKKDJPJK)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum CBIBLODOLIL
		{
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private CBIBLODOLIL handleType;

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

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA2A0", Offset = "0x5FC90A0", VA = "0x185FCA2A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA260", Offset = "0x5FC9060", VA = "0x185FCA260")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5FC9C30", Offset = "0x5FC8A30", VA = "0x185FC9C30")]
		private void OBLKBHOCIEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x11356F0", Offset = "0x11344F0", VA = "0x1811356F0", Slot = "4")]
		public void SetEnabled(bool IBCOHIKFCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA2D0", Offset = "0x5FC90D0", VA = "0x185FCA2D0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarKneeBendTargetController : MonoBehaviour, AOJODJHLOLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
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
		private Vector3 MMJNDGEGFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Vector3 DFCOCHENLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Vector3 DLJICBLFLOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Matrix4x4 LNFNHOPHFCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private bool BNHHCKJJMBP;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA760", Offset = "0x5FC9560", VA = "0x185FCA760", Slot = "4")]
		public void UpdateController(float LDLIGJLNGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF51D0", Offset = "0x5EF3FD0", VA = "0x185EF51D0", Slot = "6")]
		public void SetEnabled(bool MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5FCA300", Offset = "0x5FC9100", VA = "0x185FCA300")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5FCAE20", Offset = "0x5FC9C20", VA = "0x185FCAE20")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class LMOHHPLHDOG : DKCHPADDOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private Dictionary<string, IIHBHCNEHEK> DOCGJNIIHDH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool CHJEDHINPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D4310", Offset = "0x7D3110", VA = "0x1807D4310", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5FDCAF0", Offset = "0x5FDB8F0", VA = "0x185FDCAF0")]
	[HBAMLEIOGOF(EOCHJKOJDMN.Root, BHCECOANHAK.None)]
	private static void OEFKLOGJPFN(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5FDCD80", Offset = "0x5FDBB80", VA = "0x185FDCD80", Slot = "4")]
	public IIHBHCNEHEK PGGDAMIPHNB(string OEAHJMDCCFM, AvatarSystemConfiguration LPDAJGFHACE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5FDCBF0", Offset = "0x5FDB9F0", VA = "0x185FDCBF0", Slot = "5")]
	public void PCAENJHPFPD(string OEAHJMDCCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5FDCF40", Offset = "0x5FDBD40", VA = "0x185FDCF40")]
	public LMOHHPLHDOG()
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
		public class GNGCICOKFFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private Dictionary<string, Transform> MCGGKFCMGOI;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public bool KOELFDEDMEJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x5FCCCB0", Offset = "0x5FCBAB0", VA = "0x185FCCCB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5FCCCF0", Offset = "0x5FCBAF0", VA = "0x185FCCCF0")]
			public void PLJBPBOGIKG(VRIK OKPLNJHOOEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0")]
			public void NKDACNIINGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x5FCCC60", Offset = "0x5FCBA60", VA = "0x185FCCC60")]
			public void BMDNDNAFIJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x5FCCE20", Offset = "0x5FCBC20", VA = "0x185FCCE20")]
			public GNGCICOKFFO()
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
		[BHDMMFNDOKI(HLOGMCICCDP.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		[LNDIHOOGFKF(HLOGMCICCDP.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly GNGCICOKFFO FBIAFPHKHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private KBFJOBOCLDK FDMKNBJPEFL;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FCAE80", Offset = "0x5FC9C80", VA = "0x185FCAE80")]
		private void KCJBJGBIMAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5FCAE30", Offset = "0x5FC9C30", VA = "0x185FCAE30")]
		private bool DKMAPDOEOPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB140", Offset = "0x5FC9F40", VA = "0x185FCB140")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB1B0", Offset = "0x5FC9FB0", VA = "0x185FCB1B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB150", Offset = "0x5FC9F50", VA = "0x185FCB150")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5FCB3A0", Offset = "0x5FCA1A0", VA = "0x185FCB3A0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x5FDCFD0", Offset = "0x5FDBDD0", VA = "0x185FDCFD0", Slot = "4")]
		public override void OnStateEnter(Animator HEEOMDOAPMH, AnimatorStateInfo NOKGNDEECLH, int KKCCMBFJFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5FDD0F0", Offset = "0x5FDBEF0", VA = "0x185FDD0F0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5FC6050", Offset = "0x5FC4E50", VA = "0x185FC6050")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
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
