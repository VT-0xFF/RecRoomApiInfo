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
	public class AvatarElbowBendHelperController : MonoBehaviour, IINMNPKDIPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[OBGJPAKDKLL(LNILAIILNJP.Self, false, false, false)]
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
		private Vector3? AKDDLIJELND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool ELFOJPAPENM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5DD0", Offset = "0x5ED4BD0", VA = "0x185ED5DD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5ED63D0", Offset = "0x5ED51D0", VA = "0x185ED63D0", Slot = "4")]
		public void UpdateController(float BLFDEPDEIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x10EDE50", Offset = "0x10ECC50", VA = "0x1810EDE50", Slot = "6")]
		public void SetEnabled(bool MBDKMNBCLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5E70", Offset = "0x5ED4C70", VA = "0x185ED5E70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5ED67E0", Offset = "0x5ED55E0", VA = "0x185ED67E0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AvatarElbowBendTargetController : MonoBehaviour, IINMNPKDIPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[OBGJPAKDKLL(LNILAIILNJP.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private Transform ChestBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private Transform HandAlignBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Vector3 KOBGJKNDLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Vector3 GDPPKLMIBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool ELFOJPAPENM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private float IHLNHAKCHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float KPGECPOHLKG;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6C10", Offset = "0x5ED5A10", VA = "0x185ED6C10", Slot = "4")]
		public void UpdateController(float BLFDEPDEIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A4A590", Offset = "0x1A49390", VA = "0x181A4A590", Slot = "6")]
		public void SetEnabled(bool MBDKMNBCLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6880", Offset = "0x5ED5680", VA = "0x185ED6880")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7360", Offset = "0x5ED6160", VA = "0x185ED7360")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[OBGJPAKDKLL(LNILAIILNJP.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7C80", Offset = "0x5ED6A80", VA = "0x185ED7C80")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7C40", Offset = "0x5ED6A40", VA = "0x185ED7C40")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7390", Offset = "0x5ED6190", VA = "0x185ED7390")]
		private void KCILDABHFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x10AE280", Offset = "0x10AD080", VA = "0x1810AE280", Slot = "4")]
		public void SetEnabled(bool PDBPIJFLAJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7CB0", Offset = "0x5ED6AB0", VA = "0x185ED7CB0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarForearmRollController : MonoBehaviour, IINMNPKDIPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool ELFOJPAPENM;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7CF0", Offset = "0x5ED6AF0", VA = "0x185ED7CF0", Slot = "4")]
		public void UpdateController(float BLFDEPDEIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x79FE70", Offset = "0x79EC70", VA = "0x18079FE70", Slot = "6")]
		public void SetEnabled(bool MBDKMNBCLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8470", Offset = "0x5ED7270", VA = "0x185ED8470")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, HPJGLKBPGCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		[OBGJPAKDKLL(LNILAIILNJP.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private DOEBLLNIJHH FMIAFEJKLFP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DOEBLLNIJHH LFMMIPGPCBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5ED91B0", Offset = "0x5ED7FB0", VA = "0x185ED91B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform GLEPENEOBDK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5ED91F0", Offset = "0x5ED7FF0", VA = "0x185ED91F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8530", Offset = "0x5ED7330", VA = "0x185ED8530")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9070", Offset = "0x5ED7E70", VA = "0x185ED9070")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9020", Offset = "0x5ED7E20", VA = "0x185ED9020")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8FB0", Offset = "0x5ED7DB0", VA = "0x185ED8FB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5ED88F0", Offset = "0x5ED76F0", VA = "0x185ED88F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8FB0", Offset = "0x5ED7DB0", VA = "0x185ED8FB0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED85C0", Offset = "0x5ED73C0", VA = "0x185ED85C0", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED90C0", Offset = "0x5ED7EC0", VA = "0x185ED90C0", Slot = "8")]
		public void UpdatePostIKAnimControllers(float BLFDEPDEIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED84A0", Offset = "0x5ED72A0", VA = "0x185ED84A0")]
		private void ALKNLOKKIDC(GameObject FGANJEAKCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8970", Offset = "0x5ED7770", VA = "0x185ED8970")]
		private DOEBLLNIJHH JGBAMNMNALA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
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
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is turned off.")]
			public float AngleOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is fully on.")]
			public float AngleOn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			[Tooltip("Normalized height (0-1) where IK is turned off.")]
			public float HeightOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			[Tooltip("Normalized height (0-1) where IK is fully on.")]
			public float HeightOn;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5EEB410", Offset = "0x5EEA210", VA = "0x185EEB410")]
			public float AMOPPLHJMCJ(float HMANEBGAEDA, float ELJIOGIOMLL)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Offsets applied to transforms on the players right hand")]
		public HandLogicOffsets RightHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Header("Hand Animation")]
		[Tooltip("Time axis is the normalized distance the hand effector currently is from the origin of the upper arm bone.  A time of 0 implies the hand effector is directly on top of the upper arm origin (ie: up at your shoulder), a time = 1, that implies the hand effector is somewhere exactly a full arm's length away, a time of 1.7 implies the hand effector is somewhere exactly 1.7 times the arm's length away.  Value axis is the effector weight from 0 to 1.")]
		public AnimationCurve HandEffectorWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Time that the hand animator weight changes from 0 to 1 in a second. When the hand gesture system turns on when making a gesture, and off when the gesture system is idle, this determines the speed that it lerps towards the target weight.")]
		public float HandAnimatorWeightChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Time it takes to transition to an open or closed hand pose during an animated hand state transition")]
		public float HandOpenCloseChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E5")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Header("IK Weights")]
		[Tooltip("Blend in speed for screen players hands when hand IK is enabled.")]
		public float HandIKBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("Blend out speed for screen players hands when hand IK is enabled.")]
		public float HandIKBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Control data for when to allow IK to control the head position for screens players.")]
		public WeightData ScreenHeadPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Tooltip("Control data for when to allow IK to control the head rotation for screens players.")]
		public WeightData ScreenHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Control data for when to allow IK to control the pelvis position for screens players.")]
		public WeightData ScreenPelvisPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Control data for when to allow IK to control the pelvis rotation for screens players.")]
		public WeightData ScreenPelvisRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Header("VR runtime weights")]
		[Tooltip("The head is moved flat forward with given amount in VR to match up with our animated head position.")]
		public float StaticHeadForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Tooltip("The animated root is moved flat forward with given amount in VR to match up the physical feet with our animated feet.")]
		public float StaticRootForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("Weight for head while moving. (0 = animated, 1 = VR)")]
		public float MovingHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("Weight for head while idle. (0 = animated, 1 = VR)")]
		public float IdleHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Weight for hands while moving. (0 = animated, 1 = VR)")]
		public float MovingHandWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Angle of arm where blending start")]
		public float MovementHandBlendMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Angle of arm where blending is at full")]
		public float MovementHandBlendMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Arm length where blending starts")]
		public float MovementHandBlendMinLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Arm length where blending is at full")]
		public float MovementHandBlendMaxLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the body faces the vector between the 2 hands in screens mode")]
		public float HandVectorFacingWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		public float ShoulderTwistBlend;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9210", Offset = "0x5ED8010", VA = "0x185ED9210")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LIEAEKELGOA : DKCHMPDAKGH
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int MOHPEHEAAOM;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int MIBLBJEEMIA;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static int ALELKMBMDAD;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int IKAGMGDPBNJ;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int EMAAIMANHLA;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int MPFKHCLBBHP;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int CDHJOBJCFOI;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int AIIDEIPHAFK;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int[] KOCPBMEFNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool CMLOJHHMALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool EGLBFGFJPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool FJHEAPNGIHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private DLMDMFEHFBE OLCMCJFFBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private FMFNILEHHBM JFCLBJNCGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private FMFNILEHHBM AIGNPGDLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private int GOMAGLPFGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float MNHEELGKIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Transform PFEKIAILCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool DLCKAEICMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Animator ECGHPALKLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AvatarFullBodyConfiguration DOAHENDGIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int ANJDONDHDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int FJIONCMEAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int APOOINFNDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private float DHCKDKNBOGE;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA520", Offset = "0x5EE9320", VA = "0x185EEA520", Slot = "6")]
	public void CGDOOEBPPMG(DLMDMFEHFBE OCDBMIHPNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAE90", Offset = "0x5EE9C90", VA = "0x185EEAE90", Slot = "7")]
	public void PCHIAKALKAA(LFOIMEDHNLH MBPBJNMFHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAC90", Offset = "0x5EE9A90", VA = "0x185EEAC90", Slot = "5")]
	public void GNKCHDBIPBF(bool PIDMEIKGKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA6F0", Offset = "0x5EE94F0", VA = "0x185EEA6F0", Slot = "4")]
	public void DKBKCBGCMOH(NKFGJAKLHOM GABNNFLFFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB40", Offset = "0x5EE9940", VA = "0x185EEAB40")]
	private int EFDMPOAIOEJ(FMFNILEHHBM NHHMFGJLKIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAD20", Offset = "0x5EE9B20", VA = "0x185EEAD20")]
	private void IMJAFAFBDLF(int IDPKFJJKKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA330", Offset = "0x5EE9130", VA = "0x185EEA330")]
	private bool CENBOJAFGOO(NKFGJAKLHOM GABNNFLFFPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAE50", Offset = "0x5EE9C50", VA = "0x185EEAE50")]
	private FMFNILEHHBM ONHLCIIBINB()
	{
		return default(FMFNILEHHBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB1C0", Offset = "0x5EE9FC0", VA = "0x185EEB1C0")]
	public LIEAEKELGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x262FC00", Offset = "0x262EA00", VA = "0x18262FC00")]
	[CompilerGenerated]
	internal static bool BKKGDPOELJP<T>(T GINEEPDCIBC, T? MBDKMNBCLGF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class EAJEBPEGJIB : DOEBLLNIJHH
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private enum JNOIENEHNMP
	{
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private enum AJBCABAOPJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HBNGFNKDFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AvatarFullBodyConfiguration config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public CNEADJPKDCJ state;
	}

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly int AADKBEEIAHK;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly int IKCJAMIBMBC;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly int ECFLBAMAKLD;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int ACBKAMAOICM;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int OJHNGFBGLOE;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int OOIOFAOAAPJ;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int LOFGHFMPJAA;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int IIBAECBJKMP;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int PHGKCJIFFHG;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int FMELGLBPBAD;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int AMIMNBBOLHI;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int PKPAGABNFCA;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int HLLCHENIMBN;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int LKMFJHGJKKG;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int MJACHBLAAIP;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int NADDLJECANN;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int LHFNDFKNGBF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int BLIIIGDPAPP;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int EMADMCFEIOO;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int NGGGALLNKLG;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int JDKAAFHEKKB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int JENIOJMEPIP;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int BLMGJFHHOJA;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int EOHBMAADJAA;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GFDCBJHJOKJ;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int JDEKJAIMCEF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int NCKHGOOMPDN;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int MMFGDOGPNFA;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int IEIJIGPHJCH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int LEEDPAIPOFJ;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly Vector3 PDFDHKLHHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private JENPHKAJKFO? OLCMCJFFBMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private IPOAGMGLKNF? NAMJNKFMNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private ALJAJAMLBGK KDPIICICJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private LOECPBOEPGD AJLKDOHJIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private LIEAEKELGOA DMKOFMIEFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private LIEAEKELGOA MGNHEIEMCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool AJHAALEBLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D9")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool IDIHCCAEGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DA")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool NPNCHEMFCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DB")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool KCBMHEDLBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool BNDFPNGDDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DD")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool EHDDMKACOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DE")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool FDNODFJPMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly CCMHEDLJANE AHMGKEIANCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly HKFEKGECDBI NEAGNGIJCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly IIAHAJPLENB HKPMCMKMFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly LKFGDJCJLKP GPOCIDKAMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int IKHGHNOFAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private float LMNCBDNMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private GameObject HACCLOGALPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Transform FHMNDHCEKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Transform JHEPFJGDDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private float IAOGFPOKFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float JCKPBDIKPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private HKFEKGECDBI KHLGOKPNNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private CCMHEDLJANE PFDCEJEKMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private float AAIJPDHLKOP;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker OBKNOJPJJHD;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker MJEGPFEHCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private ProfilerMarker KNOLEEACPPA;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker DJNAACCKIBP;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker CFEAALOMNHK;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker AEGPDKNMLPM;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly List<EAJEBPEGJIB> GHNPCFAJGGC;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static int NGEOPDBDGBP;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> LMDGECDEHFO;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static int EDDBHHAOODK;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int JBCHANGIEMA;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int JIPEEDJKDJG;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int BEINCAEMMBN;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static float ABPEEEAIBFP;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int GDODGODOCCP;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static float EHMBDGMLCHN;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static float BDMHPOBOAAH;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static float GFILPBGGFMJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static float KCGEMNBJAGA;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static LBJKIBPNHPE ANOJBNCMAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float DIFIDKHMEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool NIPIMEHLINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float LJDLNEJFCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private JNOIENEHNMP EFMPOOKNMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private float PIFKFLHBJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly PJNDPCMFKNE BOBHPMPFNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private float JOAPCAIPONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float IAPDMFGPJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Vector3 GLHOLGDEPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly CCMHEDLJANE OCLKMEAGMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly CEEGCJJFMHO MLFLHLPGNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float FEAHLOMBAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private JNOIENEHNMP EJAJGOCLBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private Vector3 HEAGEGEFNBH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AHOMABILGKI LOHNHAOPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x78E290", Offset = "0x78D090", VA = "0x18078E290", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AHOMABILGKI FLFOBCAFMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration DHKLCKGIHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5EE89F0", Offset = "0x5EE77F0", VA = "0x185EE89F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AvatarFullBodyConfiguration MCAAOOFADFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4950", Offset = "0x5EE3750", VA = "0x185EE4950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform PPFBEHKKPFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4DD0", Offset = "0x5EE3BD0", VA = "0x185EE4DD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform DNCLCNNDGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5980", Offset = "0x5EE4780", VA = "0x185EE5980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private SkinnedMeshRenderer HEDCEKKEAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2F60", Offset = "0x5EE1D60", VA = "0x185EE2F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Renderer[] CPMKGNABFON
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5EDC510", Offset = "0x5EDB310", VA = "0x185EDC510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GameObject[] GIGFPEGHLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5880", Offset = "0x5EE4680", VA = "0x185EE5880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Animator GJFLALHDCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EE21B0", Offset = "0x5EE0FB0", VA = "0x185EE21B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private VRIK ABIIKPKPIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4D00", Offset = "0x5EE3B00", VA = "0x185EE4D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private IINMNPKDIPA HBDMOJJCBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2910", Offset = "0x5EE1710", VA = "0x185EE2910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private IINMNPKDIPA HAEGPMJIFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2E90", Offset = "0x5EE1C90", VA = "0x185EE2E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private IINMNPKDIPA IAIEGNFJIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5EE7000", Offset = "0x5EE5E00", VA = "0x185EE7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private IINMNPKDIPA DBHPILDMENA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDCD90", Offset = "0x5EDBB90", VA = "0x185EDCD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private IINMNPKDIPA JCJPKAOADJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5F00", Offset = "0x5EE4D00", VA = "0x185EE5F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private IINMNPKDIPA CNDHIIDOPJL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2630", Offset = "0x5EE1430", VA = "0x185EE2630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private IINMNPKDIPA GNKLNCHNJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EDDD30", Offset = "0x5EDCB30", VA = "0x185EDDD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private IINMNPKDIPA MNLKPGMDOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5EDBE00", Offset = "0x5EDAC00", VA = "0x185EDBE00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IPOAGMGLKNF KCDBGCDDAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE030", Offset = "0x5EDCE30", VA = "0x185EDE030", Slot = "28")]
		get
		{
			return default(IPOAGMGLKNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OGJBGJPIDLF GDKHIMOKAEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F5C00", Offset = "0x8F4A00", VA = "0x1808F5C00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CLNPNBJACDA GNCIMFDGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8F6040", Offset = "0x8F4E40", VA = "0x1808F6040", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DKCHMPDAKGH DBHAOOFIJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F5E50", Offset = "0x8F4C50", VA = "0x1808F5E50", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public DKCHMPDAKGH CPKHHGDAHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8F4C30", Offset = "0x8F3A30", VA = "0x1808F4C30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GameObject FAIKIGMIEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5E60", Offset = "0x5EE4C60", VA = "0x185EE5E60", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform GKPFADBMGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F4AC0", Offset = "0x8F38C0", VA = "0x1808F4AC0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Transform HHKBOGIHDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4EA0", Offset = "0x8F3CA0", VA = "0x1808F4EA0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Transform CFACEHJGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB860", Offset = "0x5EDA660", VA = "0x185EDB860", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool CEKKNNDJPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5EE2550", Offset = "0x5EE1350", VA = "0x185EE2550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9B00", Offset = "0x5EE8900", VA = "0x185EE9B00")]
	public EAJEBPEGJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5A50", Offset = "0x5EE4850", VA = "0x185EE5A50", Slot = "11")]
	public void MPJJAHBBONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3840", Offset = "0x5EE2640", VA = "0x185EE3840", Slot = "12")]
	public void JDLICPPHCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5050", Offset = "0x5EE3E50", VA = "0x185EE5050", Slot = "13")]
	public void LKMAEMIIPAD(bool NACHEGADKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8860", Offset = "0x5EE7660", VA = "0x185EE8860", Slot = "21")]
	public Transform PDLDIBLNHLC(string HCBIBBPNFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2280", Offset = "0x5EE1080", VA = "0x185EE2280", Slot = "22")]
	public Vector3? EMICLGMAMJD(string HCBIBBPNFIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF450", Offset = "0x5EDE250", VA = "0x185EDF450", Slot = "6")]
	public void DIEAFDLMGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDCE60", Offset = "0x5EDBC60", VA = "0x185EDCE60")]
	private void CGOEFJPGACN([In] CNEADJPKDCJ NCJAJOCIOLB, [In] AvatarFullBodyConfiguration FAOOIMBGECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE49E0", Offset = "0x5EE37E0", VA = "0x185EE49E0")]
	private static void KODOAEMPHLP(Transform OKMCACLMLOF, Quaternion NJBEEEBFFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC5E0", Offset = "0x5EDB3E0", VA = "0x185EDC5E0")]
	private void CDFHICBAEED(CNEADJPKDCJ NCJAJOCIOLB, AvatarFullBodyConfiguration FAOOIMBGECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5FD0", Offset = "0x5EE4DD0", VA = "0x185EE5FD0", Slot = "7")]
	public void NPPHAKAOANA(float EHOKMEPLLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE140", Offset = "0x5EDCF40", VA = "0x185EDE140")]
	private void DGIGABEKLHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE190", Offset = "0x5EDCF90", VA = "0x185EDE190", Slot = "4")]
	public void DGOEGCJHPIO(JENPHKAJKFO CMCMOFLGAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2A70", Offset = "0x5EE1870", VA = "0x185EE2A70", Slot = "5")]
	public void GJEIFBFKJIO(IPOAGMGLKNF MBPBJNMFHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9120", Offset = "0x5EE7F20", VA = "0x185EE9120", Slot = "10")]
	public void POKHLLCFBNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EE52B0", Offset = "0x5EE40B0", VA = "0x185EE52B0", Slot = "20")]
	public void MEFIIKBEFLC([Out] Vector3 BOPPMJADFHL, [Out] Quaternion NHKAICAFFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE25B0", Offset = "0x5EE13B0", VA = "0x185EE25B0", Slot = "23")]
	public void EOJHKDILPHJ(float NLGOMFFEGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDE00", Offset = "0x5EDCC00", VA = "0x185EDDE00", Slot = "24")]
	public HandLogicOffsets CLLFMGIGHKH(DHLEAAFCIKG KJCHMNCGKBB)
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC1D0", Offset = "0x5EDAFD0", VA = "0x185EDC1D0")]
	private void BGNMDFPCFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3FD0", Offset = "0x5EE2DD0", VA = "0x185EE3FD0")]
	private void KBCBOIHCMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4B90", Offset = "0x5EE3990", VA = "0x185EE4B90")]
	private void KONHFCNIJCL(RigidbodyEx NCCODOOLGJL, bool CBBCAJJMHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3730", Offset = "0x5EE2530", VA = "0x185EE3730")]
	private void IMNBCPDJNLH(RigidbodyEx NCCODOOLGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4CB0", Offset = "0x5EE3AB0", VA = "0x185EE4CB0")]
	public Vector3 LDHHKHHGPEI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0BF0", Offset = "0x5EDF9F0", VA = "0x185EE0BF0")]
	private void EGBAFBCFDNJ([In] CNEADJPKDCJ NCJAJOCIOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3F90", Offset = "0x5EE2D90", VA = "0x185EE3F90")]
	private void KAEDCNBJDOH(CNEADJPKDCJ NCJAJOCIOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1FF0", Offset = "0x5EE0DF0", VA = "0x185EE1FF0")]
	private void EHGMCKPNNGG(HFPPAPEKKBH MHADHBJJHNK, DHLEAAFCIKG BOLNBJCABJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC290", Offset = "0x5EDB090", VA = "0x185EDC290")]
	private void BGPBIMGPAFJ([In] CNEADJPKDCJ AEMBMKHDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5EE32F0", Offset = "0x5EE20F0", VA = "0x185EE32F0")]
	private void IMFAGBLBDJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4EA0", Offset = "0x5EE3CA0", VA = "0x185EE4EA0")]
	private float LJNLJOHNHOG([In] CNEADJPKDCJ AEMBMKHDECA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAEB0", Offset = "0x5ED9CB0", VA = "0x185EDAEB0")]
	private void AFMNHNPDINE([In] CNEADJPKDCJ FDMFCCAKMFK, [In] PHLDINKIJKH ADLOLMMHNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDF50", Offset = "0x5EDCD50", VA = "0x185EDDF50")]
	private int DEPEBDOLMAJ([In] PHLDINKIJKH ADLOLMMHNFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB1B0", Offset = "0x5ED9FB0", VA = "0x185EDB1B0")]
	private void AHAHABJKAGH([In] CNEADJPKDCJ FDMFCCAKMFK, [In] PHLDINKIJKH ADLOLMMHNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7C80", Offset = "0x5EE6A80", VA = "0x185EE7C80", Slot = "29")]
	protected virtual void PBMMKBCFAMI([In] CNEADJPKDCJ AEMBMKHDECA, [In] AvatarFullBodyConfiguration FAOOIMBGECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5EDBED0", Offset = "0x5EDACD0", VA = "0x185EDBED0")]
	private void BFHCOJMHCAO(CNEADJPKDCJ AEMBMKHDECA, AvatarFullBodyConfiguration FAOOIMBGECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE85E0", Offset = "0x5EE73E0", VA = "0x185EE85E0")]
	private void PDABHJMBOPL(EANEIJAAAEP IAJGOFOLEAD, EANEIJAAAEP KGNOPFKMDDK, IKSolverVR.Arm DIOAMGAGGJD, bool PGLDFMEBPFL, float FGPIELEMBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE89B0", Offset = "0x5EE77B0", VA = "0x185EE89B0")]
	private float PFELPFDFAPE(bool PGLDFMEBPFL, float FGPIELEMBGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2700", Offset = "0x5EE1500", VA = "0x185EE2700")]
	private float FNOAOAGIIFB(EANEIJAAAEP IAJGOFOLEAD, EANEIJAAAEP KGNOPFKMDDK, IKSolverVR.Arm DIOAMGAGGJD, bool PGLDFMEBPFL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5120", Offset = "0x5EE3F20", VA = "0x185EE5120")]
	private void LLINMLHAKDA([In] CNEADJPKDCJ AEMBMKHDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xCABB40", Offset = "0xCAA940", VA = "0x180CABB40")]
	private void FLPHJEKGHLI(RigidbodyEx DDDGCNNHBNI, Transform AGCHKNGJEJN, Transform FFKKGGEMMDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6E40", Offset = "0x5EE5C40", VA = "0x185EE6E40")]
	private void OJICHFLCCKC([In] CNEADJPKDCJ AEMBMKHDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB8C0", Offset = "0x5EDA6C0", VA = "0x185EDB8C0")]
	private void AMHCDEGMBMF(CNEADJPKDCJ NCJAJOCIOLB, bool PLNALIDCLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5650", Offset = "0x5EE4450", VA = "0x185EE5650")]
	private static void MFBAICLNNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EE70F0", Offset = "0x5EE5EF0", VA = "0x185EE70F0")]
	private static void ONHKLDOICHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EE2410", Offset = "0x5EE1210", VA = "0x185EE2410")]
	private float ENBKKBILNHL()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5950", Offset = "0x5EE4750", VA = "0x185EE5950")]
	private static int MJLKFHONNLE(EAJEBPEGJIB PDAKJJLHJDL, EAJEBPEGJIB KKCNPIHMPJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD700", Offset = "0x5EDC500", VA = "0x185EDD700")]
	private void CKCMNOGIDEA([In] CNEADJPKDCJ AEMBMKHDECA, [In] AJBCABAOPJB AJIOHDGDCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EE45F0", Offset = "0x5EE33F0", VA = "0x185EE45F0")]
	private void KHGAMFEKLLN(CNEADJPKDCJ AEMBMKHDECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE70D0", Offset = "0x5EE5ED0", VA = "0x185EE70D0")]
	private void OJPFCFGGGKN(JNOIENEHNMP DGNBAILDDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE43E0", Offset = "0x5EE31E0", VA = "0x185EE43E0")]
	private void KEMLAECKOKN(float AFEHMHALGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6060", Offset = "0x5EE4E60", VA = "0x185EE6060")]
	private void ODHKJMDNHPC([In] CNEADJPKDCJ AEMBMKHDECA, AJBCABAOPJB AJIOHDGDCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE67A0", Offset = "0x5EE55A0", VA = "0x185EE67A0")]
	private Vector3 OHNNJBAAPNL([In] CNEADJPKDCJ AEMBMKHDECA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3360", Offset = "0x5EE2160", VA = "0x185EE3360")]
	private float IMMBBCCCDDB(float CCOFBKPDOIJ, [In] CNEADJPKDCJ AEMBMKHDECA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6040", Offset = "0x5EE4E40", VA = "0x185EE6040")]
	private void ODFALCENKGM(JNOIENEHNMP DGNBAILDDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8AC0", Offset = "0x5EE78C0", VA = "0x185EE8AC0")]
	private void PJOILHFKONM([In] CNEADJPKDCJ AEMBMKHDECA, AJBCABAOPJB AJIOHDGDCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3B80", Offset = "0x5EE2980", VA = "0x185EE3B80")]
	private float JJGKPEEKJBE([In] CNEADJPKDCJ NCJAJOCIOLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EE06D0", Offset = "0x5EDF4D0", VA = "0x185EE06D0")]
	private void EBFKICALLED(CNEADJPKDCJ AEMBMKHDECA, AJBCABAOPJB AJIOHDGDCEF, Vector3 ENJMGLCOLME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3030", Offset = "0x5EE1E30", VA = "0x185EE3030")]
	[CompilerGenerated]
	private void ILGLDMCGGBH(IKSolverVR.Arm MEBFMEEDLAN, Vector3 CAMBMJIMDBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5EE29E0", Offset = "0x5EE17E0", VA = "0x185EE29E0")]
	[CompilerGenerated]
	internal static void GIDIOLMJCDK(float CNFPLHHDGKG, float DHDHKFHBPFC, HBNGFNKDFEC P_2)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum LCAJJKLGCAK
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		[OBGJPAKDKLL(LNILAIILNJP.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private LCAJJKLGCAK handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9A80", Offset = "0x5ED8880", VA = "0x185ED9A80")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9A40", Offset = "0x5ED8840", VA = "0x185ED9A40")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9410", Offset = "0x5ED8210", VA = "0x185ED9410")]
		private void KCILDABHFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x10AE280", Offset = "0x10AD080", VA = "0x1810AE280", Slot = "4")]
		public void SetEnabled(bool PDBPIJFLAJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9AB0", Offset = "0x5ED88B0", VA = "0x185ED9AB0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarKneeBendTargetController : MonoBehaviour, IINMNPKDIPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		[OBGJPAKDKLL(LNILAIILNJP.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 KOBGJKNDLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Vector3 LNJDFKMEDAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 ICDDLLBDNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Matrix4x4 BCLDJJCDDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool ELFOJPAPENM;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9F40", Offset = "0x5ED8D40", VA = "0x185ED9F40", Slot = "4")]
		public void UpdateController(float BLFDEPDEIPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E0ADE0", Offset = "0x5E09BE0", VA = "0x185E0ADE0", Slot = "6")]
		public void SetEnabled(bool MBDKMNBCLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9AE0", Offset = "0x5ED88E0", VA = "0x185ED9AE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA600", Offset = "0x5ED9400", VA = "0x185EDA600")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class FHFIHNCDJOH : DAPNIAEDKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private Dictionary<string, DOEBLLNIJHH> KKIGLBHFAMK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PPBIGHAJFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1A0", Offset = "0x5EE8FA0", VA = "0x185EEA1A0")]
	[OKINHFAHPEJ(OBFBFIBMGDJ.Root, FNGNILODNLI.None)]
	private static void ONCHKFBKOMM(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9E50", Offset = "0x5EE8C50", VA = "0x185EE9E50", Slot = "4")]
	public DOEBLLNIJHH KOAOPCCELDH(string AHKMLCPOMPP, AvatarSystemConfiguration JGHPKNDDJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA010", Offset = "0x5EE8E10", VA = "0x185EEA010", Slot = "5")]
	public void NLIJGHMGJDI(string AHKMLCPOMPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA2A0", Offset = "0x5EE90A0", VA = "0x185EEA2A0")]
	public FHFIHNCDJOH()
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
		public class DNFAIPDPIFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private Dictionary<string, Transform> HHINAOBNHLA;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public bool IJDAKCFEOFC
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x5EDAC60", Offset = "0x5ED9A60", VA = "0x185EDAC60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5EDACA0", Offset = "0x5ED9AA0", VA = "0x185EDACA0")]
			public void JJLBNPDJEGG(VRIK KFNMIPCDEOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840")]
			public void PIKGLLJFGNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5EDADD0", Offset = "0x5ED9BD0", VA = "0x185EDADD0")]
			public void KGLPDGAIIAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5EDAE20", Offset = "0x5ED9C20", VA = "0x185EDAE20")]
			public DNFAIPDPIFC()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		[BIOJMLLEHME(LNILAIILNJP.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		[OBGJPAKDKLL(LNILAIILNJP.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly DNFAIPDPIFC MJKOPAOPPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private HPJGLKBPGCF AMIPCJBIGOK;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA610", Offset = "0x5ED9410", VA = "0x185EDA610")]
		private void CGDOOEBPPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA8D0", Offset = "0x5ED96D0", VA = "0x185EDA8D0")]
		private bool LNJDBGKDLFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA920", Offset = "0x5ED9720", VA = "0x185EDA920")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA990", Offset = "0x5ED9790", VA = "0x185EDA990")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA930", Offset = "0x5ED9730", VA = "0x185EDA930")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDAB80", Offset = "0x5ED9980", VA = "0x185EDAB80")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB1D0", Offset = "0x5EE9FD0", VA = "0x185EEB1D0", Slot = "4")]
		public override void OnStateEnter(Animator HJCEICIDPPC, AnimatorStateInfo IDLFKKNMIJN, int GJBBOFCEIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB2F0", Offset = "0x5EEA0F0", VA = "0x185EEB2F0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5950", Offset = "0x5ED4750", VA = "0x185ED5950")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
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
