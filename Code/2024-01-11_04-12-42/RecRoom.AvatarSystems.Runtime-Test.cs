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
	public class AvatarElbowBendHelperController : MonoBehaviour, HNMDBONEBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
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
		private Vector3? KMLBEMBKFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool GCNKPGPEDBM;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4750", Offset = "0x5ED3150", VA = "0x185ED4750", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4D50", Offset = "0x5ED3750", VA = "0x185ED4D50", Slot = "4")]
		public void UpdateController(float HNNKCGDCJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x10E99C0", Offset = "0x10E83C0", VA = "0x1810E99C0", Slot = "6")]
		public void SetEnabled(bool BEEGCHJLJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5ED47F0", Offset = "0x5ED31F0", VA = "0x185ED47F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5160", Offset = "0x5ED3B60", VA = "0x185ED5160")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AvatarElbowBendTargetController : MonoBehaviour, HNMDBONEBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
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
		private Vector3 LJEJHHJCIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Vector3 OCLMJHDNHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool GCNKPGPEDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private float IHIMBBMKIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private float PKKADDJNPLI;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5590", Offset = "0x5ED3F90", VA = "0x185ED5590", Slot = "4")]
		public void UpdateController(float HNNKCGDCJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1A490E0", Offset = "0x1A47AE0", VA = "0x181A490E0", Slot = "6")]
		public void SetEnabled(bool BEEGCHJLJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5200", Offset = "0x5ED3C00", VA = "0x185ED5200")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5CE0", Offset = "0x5ED46E0", VA = "0x185ED5CE0")]
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
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x5ED6600", Offset = "0x5ED5000", VA = "0x185ED6600")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED65C0", Offset = "0x5ED4FC0", VA = "0x185ED65C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5D10", Offset = "0x5ED4710", VA = "0x185ED5D10")]
		private void LAJADFEOEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x10AF5E0", Offset = "0x10ADFE0", VA = "0x1810AF5E0", Slot = "4")]
		public void SetEnabled(bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6630", Offset = "0x5ED5030", VA = "0x185ED6630")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarForearmRollController : MonoBehaviour, HNMDBONEBPB
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
		private bool GCNKPGPEDBM;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6670", Offset = "0x5ED5070", VA = "0x185ED6670", Slot = "4")]
		public void UpdateController(float HNNKCGDCJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7A0FB0", Offset = "0x79F9B0", VA = "0x1807A0FB0", Slot = "6")]
		public void SetEnabled(bool BEEGCHJLJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6DF0", Offset = "0x5ED57F0", VA = "0x185ED6DF0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, GLPEAABBMKG
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
		[IGEHDIPFLIF(EEBNILOIPCE.SelfAndChildren, false, false, false)]
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
		private DFHNMIPAGLL DDNMKCGBGJL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DFHNMIPAGLL EDGJBMEGACD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5ED7B30", Offset = "0x5ED6530", VA = "0x185ED7B30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform LJKDDLMANNC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5ED7B70", Offset = "0x5ED6570", VA = "0x185ED7B70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6E20", Offset = "0x5ED5820", VA = "0x185ED6E20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5ED79F0", Offset = "0x5ED63F0", VA = "0x185ED79F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5ED79A0", Offset = "0x5ED63A0", VA = "0x185ED79A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7930", Offset = "0x5ED6330", VA = "0x185ED7930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7820", Offset = "0x5ED6220", VA = "0x185ED7820", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7930", Offset = "0x5ED6330", VA = "0x185ED7930", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6EB0", Offset = "0x5ED58B0", VA = "0x185ED6EB0", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7A40", Offset = "0x5ED6440", VA = "0x185ED7A40", Slot = "8")]
		public void UpdatePostIKAnimControllers(float HNNKCGDCJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED78A0", Offset = "0x5ED62A0", VA = "0x185ED78A0")]
		private void JELBMLBOGFN(GameObject GKNPKJAGNGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED71E0", Offset = "0x5ED5BE0", VA = "0x185ED71E0")]
		private DFHNMIPAGLL FBJAEMOECAD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EE9D90", Offset = "0x5EE8790", VA = "0x185EE9D90")]
			public float KHGJIAEHOPI(float AEOAHOCMCGP, float OHCCCPONLAC)
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
		[Cpp2IlInjected.Address(RVA = "0x5ED7B90", Offset = "0x5ED6590", VA = "0x185ED7B90")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MBEAIPOCCIF : JIMHFNIEBOC
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static int APJKNHJAGAE;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static int EBNHJPDNKJI;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static int EABJGAIJJCG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static int GMLGBHAFFHF;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static int EPOEKGHGENN;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static int IMECMAPLJBD;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static int OOBCLCNNACI;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static int GGCKOAAJBEI;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int[] OAIPHFLHLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool EJCACCDGBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool NICFFOBBOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool BPNIPDJFBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private CHGMIPNOIIB PPFAKANBDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private GFMBNELHABF PFLOGGHDIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private GFMBNELHABF ONCEAELGDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private int AOOGJEGHEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private float DHAALEEKLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Transform KDNEELEPEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool BJEBGLJLFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Animator OLOCODIGALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private AvatarFullBodyConfiguration DDBDNIOCBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int PFACMDIKEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int ENHADGBNLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int EMFLDMJCFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private float JNIEPPMGJEH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA180", Offset = "0x5ED8B80", VA = "0x185EDA180", Slot = "6")]
	public void IAMMEFBKIFH(CHGMIPNOIIB OFMKHBNDOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA390", Offset = "0x5ED8D90", VA = "0x185EDA390", Slot = "7")]
	public void PPPJPLNOMOO(IJIHAECAPAF JIEBFPDKBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9830", Offset = "0x5ED8230", VA = "0x185ED9830", Slot = "5")]
	public void ABAHOHMNDDH(bool DIGMNOMJFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9AB0", Offset = "0x5ED84B0", VA = "0x185ED9AB0", Slot = "4")]
	public void HBNNLDGDMAP(KPMHICAJMCE EKELKLFMHOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA030", Offset = "0x5ED8A30", VA = "0x185EDA030")]
	private int HLLDCIEAOMF(GFMBNELHABF LKLHEHCDENH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5ED9F00", Offset = "0x5ED8900", VA = "0x185ED9F00")]
	private void HGNHIFAHIIE(int MEDPDBPAKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5ED98C0", Offset = "0x5ED82C0", VA = "0x185ED98C0")]
	private bool GOEOOJKLJBE(KPMHICAJMCE EKELKLFMHOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA350", Offset = "0x5ED8D50", VA = "0x185EDA350")]
	private GFMBNELHABF NNCAHBEIECC()
	{
		return default(GFMBNELHABF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA6C0", Offset = "0x5ED90C0", VA = "0x185EDA6C0")]
	public MBEAIPOCCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x26CDE50", Offset = "0x26CC850", VA = "0x1826CDE50")]
	[CompilerGenerated]
	internal static bool CNBMBJGMEBB<T>(T BDOIFLDIKDA, T? BEEGCHJLJFC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class OAEJLNBOHOJ : DFHNMIPAGLL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private enum GLGADAPHDOD
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
	private enum JPFOOHGAEOE
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
	private struct PJNJJKLFOAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AvatarFullBodyConfiguration config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public NFBDDOEPPAF state;
	}

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly int HHFFDOGMNIE;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly int OOOHJHFNLLA;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly int DLPLLLKDGBI;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int JHPCMJHKLIC;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int AHLCFLBHEDP;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int NCDEAAMDMHH;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int ADIMLEGAPJD;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int PKPGAKJBIOA;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int IILLEGAIIKH;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int AIPPCLDBIHE;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int DMLDBKOLNCM;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int HOHOEFGHFJP;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int GMFOJDMGAGA;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int CKJCMMHAJFO;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int OOMKMFCAGMG;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int NHDJIINDONN;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int BGPDLBOFKDB;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int FNJLKCPOBOH;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int JIJJFECFFNE;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int KINNHNCLFLK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int DCFAIJICPFK;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int OFODFEHBMKB;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int LNMGPKKAODF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int OEFKAKFEDOJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int ACMPPKKECLL;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int PNJIIKLBCAJ;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int EAJPEIKBGLD;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int CBKFMHHJINN;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int JKACEKFDOJJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int HJBOODMCPFL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly Vector3 CBDGFIHGJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private LDPHMLBGNIJ? PPFAKANBDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NGDFIDEPELD? JEMLHNJMAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private EIBNHKMHJND MFGHOKBNCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private MDBJAJGFNJM NDLONGNGGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private MBEAIPOCCIF NPMNMLEPAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private MBEAIPOCCIF FLJJNJAPHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool ALBEEKDOLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D9")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool CIKPHKEEEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DA")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool IMLNJPOMFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DB")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool MFGBOFOLIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool FEFEBOKFDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DD")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool PAMBCBEAAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DE")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool EEGFNJKBMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly KMEOOFCNBKF GAKEJBNOGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly HDFOFKGAJAD IJNOGHJCNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly IAHPHAIIJMM KFCAKLFABOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly OOCOCLLNIGB CJPMDMAMCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int KCJOEIGGHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private float EBINHGIOAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private GameObject PFFPHNOAJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Transform PHHCDAENLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Transform OGELMFBDFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private float KJDJCMLJLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float JJLDFJCEING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private HDFOFKGAJAD HKMLGBGLCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private KMEOOFCNBKF PKADMLFONLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private float NDIBEGLCODF;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly ProfilerMarker JFEOLGIOJBE;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly ProfilerMarker ADOADLIEGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private ProfilerMarker AFNPAIJOBPK;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker FHNJAPGLGPH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker BGCAPEPNKKD;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly ProfilerMarker JPGHFLLEOBG;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly List<OAEJLNBOHOJ> KFGBPJEIBBG;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static int MEBCKPAEEHM;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> JEBGHNOLODH;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static int IDEKGKFBOMF;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int JBMDNFLHJNH;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static int JOOKPJPOMBJ;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int LJPOPBINGIP;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static float NAALEIDDDIP;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int MJBNKKOGEAO;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static float ECOBIAENKAO;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static float MEPOFFNHOKI;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static float NAHEADHDNCJ;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static float AFEMENBLDLL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static BIKAFFDNJLI HMGGMHMHFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private float LGMGPDLDMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private bool JLIMBICFPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private float JMIGKCELINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GLGADAPHDOD PIFFEAJKFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private float FBCBBDKCBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly CHBDJHGJAEP NACGNEPJIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private float GCGHNGJHIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float PHGJDFFOANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private Vector3 JGJJGILLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly KMEOOFCNBKF DIGDDBBJOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly JDMJIKKLLOK IBCJKFNDKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float DPBJILKHNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private GLGADAPHDOD NIEGKLIJGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private Vector3 JKAKCONPFCK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BCNLEBGHOIF MDPMJNJNHBM
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x790430", Offset = "0x78EE30", VA = "0x180790430", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BCNLEBGHOIF AGOBGKMCIFD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration PCPDGLIPNBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5EE33E0", Offset = "0x5EE1DE0", VA = "0x185EE33E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AvatarFullBodyConfiguration ADPPBNGDMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0CF0", Offset = "0x5EDF6F0", VA = "0x185EE0CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform CGCJEKHHBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EDDA10", Offset = "0x5EDC410", VA = "0x185EDDA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform DKKLDCFOIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0A10", Offset = "0x5EDF410", VA = "0x185EE0A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private SkinnedMeshRenderer BDBKDGEPBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EE34B0", Offset = "0x5EE1EB0", VA = "0x185EE34B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Renderer[] GMNGIHANADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5EDD940", Offset = "0x5EDC340", VA = "0x185EDD940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GameObject[] FKHGIBJFGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB0F0", Offset = "0x5ED9AF0", VA = "0x185EDB0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Animator BIIHJNNMCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5EDDFA0", Offset = "0x5EDC9A0", VA = "0x185EDDFA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private VRIK ONOONLKNAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB4E0", Offset = "0x5ED9EE0", VA = "0x185EDB4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private HNMDBONEBPB FDHEBACDLJN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5EE8BA0", Offset = "0x5EE75A0", VA = "0x185EE8BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private HNMDBONEBPB LFBOHJEFOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0870", Offset = "0x5EDF270", VA = "0x185EE0870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private HNMDBONEBPB MPCDJMEIPAE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5EE0940", Offset = "0x5EDF340", VA = "0x185EE0940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private HNMDBONEBPB KOPFFONMDON
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5EE3310", Offset = "0x5EE1D10", VA = "0x185EE3310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private HNMDBONEBPB AHPEDHMFLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EDB1C0", Offset = "0x5ED9BC0", VA = "0x185EDB1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private HNMDBONEBPB AIICLNPOPOO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE53F0", Offset = "0x5EE3DF0", VA = "0x185EE53F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private HNMDBONEBPB ANBIIKHMFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EE83F0", Offset = "0x5EE6DF0", VA = "0x185EE83F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private HNMDBONEBPB LKEMDJOIOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5290", Offset = "0x5EE3C90", VA = "0x185EE5290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public NGDFIDEPELD CEPODCJOHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE310", Offset = "0x5EDCD10", VA = "0x185EDE310", Slot = "28")]
		get
		{
			return default(NGDFIDEPELD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MNEKCMBPDGC PCFEDGMILPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F7400", Offset = "0x8F5E00", VA = "0x1808F7400", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AMMOOFCPHFE BDDNDHCGIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8F7840", Offset = "0x8F6240", VA = "0x1808F7840", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JIMHFNIEBOC DBANMBDCKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F7650", Offset = "0x8F6050", VA = "0x1808F7650", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JIMHFNIEBOC FJGNANLHLKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8F6430", Offset = "0x8F4E30", VA = "0x1808F6430", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GameObject PKKHAEKNIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5EDDF00", Offset = "0x5EDC900", VA = "0x185EDDF00", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform ICMGELCKEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8F62C0", Offset = "0x8F4CC0", VA = "0x1808F62C0", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Transform OKDMFJHANHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F66A0", Offset = "0x8F50A0", VA = "0x1808F66A0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Transform EEPPGDMJPIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5EE5360", Offset = "0x5EE3D60", VA = "0x185EE5360", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool OFNDOGCNBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5EDE100", Offset = "0x5EDCB00", VA = "0x185EDE100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5EE9930", Offset = "0x5EE8330", VA = "0x185EE9930")]
	public OAEJLNBOHOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5EE47D0", Offset = "0x5EE31D0", VA = "0x185EE47D0", Slot = "11")]
	public void KLHPPKDEGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEC80", Offset = "0x5EDD680", VA = "0x185EDEC80", Slot = "12")]
	public void GJLJAKDJDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDC00", Offset = "0x5EDC600", VA = "0x185EDDC00", Slot = "13")]
	public void ECMKMAFOMLF(bool EOPGLCEBNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3580", Offset = "0x5EE1F80", VA = "0x185EE3580", Slot = "21")]
	public Transform JHPILOGELBI(string GJBMMFFPGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8860", Offset = "0x5EE7260", VA = "0x185EE8860", Slot = "22")]
	public Vector3? PEOKLJPMMGF(string GJBMMFFPGGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5BF0", Offset = "0x5EE45F0", VA = "0x185EE5BF0", Slot = "6")]
	public void MHHPBOIJOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDC9B0", Offset = "0x5EDB3B0", VA = "0x185EDC9B0")]
	private void DCMJKFDMPKI([In] NFBDDOEPPAF EKKCOGMCPPC, [In] AvatarFullBodyConfiguration LODBFAHDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE160", Offset = "0x5EDCB60", VA = "0x185EDE160")]
	private static void FONMFBFDILP(Transform BDCAJJAMFEO, Quaternion KPKKBKKOGOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3AF0", Offset = "0x5EE24F0", VA = "0x185EE3AF0")]
	private void JIHONGHMDGH(NFBDDOEPPAF EKKCOGMCPPC, AvatarFullBodyConfiguration LODBFAHDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE090", Offset = "0x5EDCA90", VA = "0x185EDE090", Slot = "7")]
	public void FJHLMLFGKHP(float KMNPGOGANCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4BE0", Offset = "0x5EE35E0", VA = "0x185EE4BE0")]
	private void KOCMKJCHMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1D40", Offset = "0x5EE0740", VA = "0x185EE1D40", Slot = "4")]
	public void IGKDFCLEBMO(LDPHMLBGNIJ BGKCPOIJMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5EE36D0", Offset = "0x5EE20D0", VA = "0x185EE36D0", Slot = "5")]
	public void JIEIKNCLMEO(NGDFIDEPELD JIEBFPDKBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7240", Offset = "0x5EE5C40", VA = "0x185EE7240", Slot = "10")]
	public void NEBOMLPBPOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5EE42A0", Offset = "0x5EE2CA0", VA = "0x185EE42A0", Slot = "20")]
	public void JKAFMPGGHLL([Out] Vector3 OMNAALDMCLI, [Out] Quaternion CFAKIPDDGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5EE54C0", Offset = "0x5EE3EC0", VA = "0x185EE54C0", Slot = "23")]
	public void MELCLFNPHAK(float GJCBIPNDAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6E70", Offset = "0x5EE5870", VA = "0x185EE6E70", Slot = "24")]
	public HandLogicOffsets MNJDLMBOEIM(OINOEKBNMMI PACDHKFCGCI)
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7330", Offset = "0x5EE5D30", VA = "0x185EE7330")]
	private void NLBBICGBIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDACE0", Offset = "0x5ED96E0", VA = "0x185EDACE0")]
	private void AJFHPNNEGDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDAE0", Offset = "0x5EDC4E0", VA = "0x185EDDAE0")]
	private void EADBKMMPHNN(RigidbodyEx ONOGEHCIPOH, bool OOJFFOBBJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0D80", Offset = "0x5EDF780", VA = "0x185EE0D80")]
	private void IALBICGDBBN(RigidbodyEx ONOGEHCIPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD250", Offset = "0x5EDBC50", VA = "0x185EDD250")]
	public Vector3 DHMDIMOILGG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB5B0", Offset = "0x5ED9FB0", VA = "0x185EDB5B0")]
	private void DCCBAJDMKLL([In] NFBDDOEPPAF EKKCOGMCPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB4A0", Offset = "0x5ED9EA0", VA = "0x185EDB4A0")]
	private void CCHNNDLADAK(NFBDDOEPPAF EKKCOGMCPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8230", Offset = "0x5EE6C30", VA = "0x185EE8230")]
	private void OMCEDAPLLNG(JKKBMMOOKOP MHOMFHJLDPD, OINOEKBNMMI MAECDDMGDID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EE6FC0", Offset = "0x5EE59C0", VA = "0x185EE6FC0")]
	private void NBIFJGBEMAM([In] NFBDDOEPPAF HELMNHPMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF620", Offset = "0x5EDE020", VA = "0x185EDF620")]
	private void GOHHNALEADC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EE89F0", Offset = "0x5EE73F0", VA = "0x185EE89F0")]
	private float PFFFMCGOBDF([In] NFBDDOEPPAF HELMNHPMHNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE980", Offset = "0x5EDD380", VA = "0x185EDE980")]
	private void GJEAJOKIBJP([In] NFBDDOEPPAF MDFJIBNEGCK, [In] IBHDPHPOKGK ECFHHPEDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EE84C0", Offset = "0x5EE6EC0", VA = "0x185EE84C0")]
	private int ONBEGFEHIHC([In] IBHDPHPOKGK ECFHHPEDPLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EE5540", Offset = "0x5EE3F40", VA = "0x185EE5540")]
	private void MFPBOEGLOOA([In] NFBDDOEPPAF MDFJIBNEGCK, [In] IBHDPHPOKGK ECFHHPEDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE12A0", Offset = "0x5EDFCA0", VA = "0x185EE12A0", Slot = "29")]
	protected virtual void IBLDFAGFCOI([In] NFBDDOEPPAF HELMNHPMHNC, [In] AvatarFullBodyConfiguration LODBFAHDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4F90", Offset = "0x5EE3990", VA = "0x185EE4F90")]
	private void KPILHFMNHJB(NFBDDOEPPAF HELMNHPMHNC, AvatarFullBodyConfiguration LODBFAHDGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3090", Offset = "0x5EE1A90", VA = "0x185EE3090")]
	private void ILAOPMLEAEM(HIDAMLDFGNO PMCJEPPLDHE, HIDAMLDFGNO PFHNNKMJLHL, IKSolverVR.Arm FBJOOGPBDJC, bool OMFOJFICBEH, float LMOPNELFAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE940", Offset = "0x5EDD340", VA = "0x185EDE940")]
	private float GHGNOCAHCBK(bool OMFOJFICBEH, float LMOPNELFAGP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5EDB290", Offset = "0x5ED9C90", VA = "0x185EDB290")]
	private float CCDELMKFILM(HIDAMLDFGNO PMCJEPPLDHE, HIDAMLDFGNO PFHNNKMJLHL, IKSolverVR.Arm FBJOOGPBDJC, bool OMFOJFICBEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4640", Offset = "0x5EE3040", VA = "0x185EE4640")]
	private void KBCADLFHOJL([In] NFBDDOEPPAF HELMNHPMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xCAC2A0", Offset = "0xCAACA0", VA = "0x180CAC2A0")]
	private void DCPEBDIAENC(RigidbodyEx ABDFNCIFACA, Transform MHDNAPELNLH, Transform JCDAGBPOHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8070", Offset = "0x5EE6A70", VA = "0x185EE8070")]
	private void OCPKJJHOMKF([In] NFBDDOEPPAF HELMNHPMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5EE7B30", Offset = "0x5EE6530", VA = "0x185EE7B30")]
	private void OAPBLFDCNFA(NFBDDOEPPAF EKKCOGMCPPC, bool DPFEKIONBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EDDCD0", Offset = "0x5EDC6D0", VA = "0x185EDDCD0")]
	private static void EGMPFICCNPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EDF690", Offset = "0x5EDE090", VA = "0x185EDF690")]
	private static void HBHJFDIKJAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EE1C00", Offset = "0x5EE0600", VA = "0x185EE1C00")]
	private float IDJOALFACEH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EE53C0", Offset = "0x5EE3DC0", VA = "0x185EE53C0")]
	private static int LNFEPNHDFIP(OAEJLNBOHOJ GHGBJDGFDKJ, OAEJLNBOHOJ PHPPILHFFME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0240", Offset = "0x5EDEC40", VA = "0x185EE0240")]
	private void HBLBFFIHNMO([In] NFBDDOEPPAF HELMNHPMHNC, [In] JPFOOHGAEOE KKHJMAFPMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4C30", Offset = "0x5EE3630", VA = "0x185EE4C30")]
	private void KOOAEKJFKBP(NFBDDOEPPAF HELMNHPMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE070", Offset = "0x5EDCA70", VA = "0x185EDE070")]
	private void FDLGFDJPOKL(GLGADAPHDOD KCPIIMHNNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0AE0", Offset = "0x5EDF4E0", VA = "0x185EE0AE0")]
	private void HMPAIEBHJFN(float MKKLHDDAJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EE73F0", Offset = "0x5EE5DF0", VA = "0x185EE73F0")]
	private void OANKGCJHCIN([In] NFBDDOEPPAF HELMNHPMHNC, JPFOOHGAEOE KKHJMAFPMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EDD2A0", Offset = "0x5EDBCA0", VA = "0x185EDD2A0")]
	private Vector3 DIFHMFKHAHG([In] NFBDDOEPPAF HELMNHPMHNC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EE8C70", Offset = "0x5EE7670", VA = "0x185EE8C70")]
	private float POMGKGJBEDP(float KCIBLENDPNO, [In] NFBDDOEPPAF HELMNHPMHNC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0220", Offset = "0x5EDEC20", VA = "0x185EE0220")]
	private void HBKBLKNLKHD(GLGADAPHDOD KCPIIMHNNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5EDEFC0", Offset = "0x5EDD9C0", VA = "0x185EDEFC0")]
	private void GNLCEHKKABI([In] NFBDDOEPPAF HELMNHPMHNC, JPFOOHGAEOE KKHJMAFPMPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5EE0E90", Offset = "0x5EDF890", VA = "0x185EE0E90")]
	private float IANCLOOKBCP([In] NFBDDOEPPAF EKKCOGMCPPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5EDE420", Offset = "0x5EDCE20", VA = "0x185EDE420")]
	private void GACBOACJGME(NFBDDOEPPAF HELMNHPMHNC, JPFOOHGAEOE KKHJMAFPMPC, Vector3 HFKCDIKIBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5EE85A0", Offset = "0x5EE6FA0", VA = "0x185EE85A0")]
	[CompilerGenerated]
	private void PAMLMGAKPEJ(IKSolverVR.Arm GICKMPKJLPF, Vector3 BJMIHBMBHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5EE3000", Offset = "0x5EE1A00", VA = "0x185EE3000")]
	[CompilerGenerated]
	internal static void IKDBAKGBPGJ(float ENBLOMKHKAC, float OFNIJOLIAMO, PJNJJKLFOAN P_2)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum KOGFBIBMNCC
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private KOGFBIBMNCC handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x5ED8400", Offset = "0x5ED6E00", VA = "0x185ED8400")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED83C0", Offset = "0x5ED6DC0", VA = "0x185ED83C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED7D90", Offset = "0x5ED6790", VA = "0x185ED7D90")]
		private void LAJADFEOEBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x10AF5E0", Offset = "0x10ADFE0", VA = "0x1810AF5E0", Slot = "4")]
		public void SetEnabled(bool GJMLPIHBLBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8430", Offset = "0x5ED6E30", VA = "0x185ED8430")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarKneeBendTargetController : MonoBehaviour, HNMDBONEBPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.Self, false, false, false)]
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
		private Vector3 LJEJHHJCIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Vector3 MPNLIBDKFHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 MECNOPLIFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Matrix4x4 AOALBGGNCFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool GCNKPGPEDBM;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5ED88C0", Offset = "0x5ED72C0", VA = "0x185ED88C0", Slot = "4")]
		public void UpdateController(float HNNKCGDCJIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E0F6B0", Offset = "0x5E0E0B0", VA = "0x185E0F6B0", Slot = "6")]
		public void SetEnabled(bool BEEGCHJLJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8460", Offset = "0x5ED6E60", VA = "0x185ED8460")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8F80", Offset = "0x5ED7980", VA = "0x185ED8F80")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class NFICFJKHOBE : KAMFELHPIPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private Dictionary<string, DFHNMIPAGLL> IPCKMJCEOGK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PHAKKKLDFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7AA930", Offset = "0x7A9330", VA = "0x1807AA930", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAB50", Offset = "0x5ED9550", VA = "0x185EDAB50")]
	[BBBFDPEBAMC(JFAJKKONDHJ.Root, HLEKCCEDPHP.None)]
	private static void NENFOAMNIOH(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA800", Offset = "0x5ED9200", VA = "0x185EDA800", Slot = "4")]
	public DFHNMIPAGLL IINNCLJHGEM(string JKPHAONAGOH, AvatarSystemConfiguration OMJEAMJCIID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5EDA9C0", Offset = "0x5ED93C0", VA = "0x185EDA9C0", Slot = "5")]
	public void ILNHIFPIGLC(string JKPHAONAGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5EDAC50", Offset = "0x5ED9650", VA = "0x185EDAC50")]
	public NFICFJKHOBE()
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
		public class HAJNLAOLPCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private Dictionary<string, Transform> MOHKGNGOGOD;

			[Cpp2IlInjected.Token(Token = "0x17000021")]
			public bool KBMKICIKMEP
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x5ED95E0", Offset = "0x5ED7FE0", VA = "0x185ED95E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5ED9670", Offset = "0x5ED8070", VA = "0x185ED9670")]
			public void PHCEFOOOJBJ(VRIK LANOEOFFIJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210")]
			public void KHJJMHMGEMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5ED9620", Offset = "0x5ED8020", VA = "0x185ED9620")]
			public void JGPBMMKLMDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5ED97A0", Offset = "0x5ED81A0", VA = "0x185ED97A0")]
			public HAJNLAOLPCK()
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
		[HAPNNLGHBBJ(EEBNILOIPCE.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		[IGEHDIPFLIF(EEBNILOIPCE.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly HAJNLAOLPCK JNNOAMBLNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private GLPEAABBMKG HAJEEDPAFCM;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8FE0", Offset = "0x5ED79E0", VA = "0x185ED8FE0")]
		private void IAMMEFBKIFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED8F90", Offset = "0x5ED7990", VA = "0x185ED8F90")]
		private bool DIGNJFMEKMD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED92A0", Offset = "0x5ED7CA0", VA = "0x185ED92A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9310", Offset = "0x5ED7D10", VA = "0x185ED9310")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED92B0", Offset = "0x5ED7CB0", VA = "0x185ED92B0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED9500", Offset = "0x5ED7F00", VA = "0x185ED9500")]
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
		[Cpp2IlInjected.Address(RVA = "0x5EDA6D0", Offset = "0x5ED90D0", VA = "0x185EDA6D0", Slot = "4")]
		public override void OnStateEnter(Animator GKPLMKKIACD, AnimatorStateInfo EIMGKNOJHHE, int DODLKMECIKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5EDA7F0", Offset = "0x5ED91F0", VA = "0x185EDA7F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5ED42D0", Offset = "0x5ED2CD0", VA = "0x185ED42D0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
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
