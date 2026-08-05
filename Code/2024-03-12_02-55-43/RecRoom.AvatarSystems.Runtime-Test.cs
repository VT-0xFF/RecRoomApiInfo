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
	public class AvatarElbowBendHelperController : MonoBehaviour, OIAGDKLIOKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
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
		private Vector3? OAHIDHHNACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool KHLHODKLMLA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6036110", Offset = "0x6035310", VA = "0x186036110", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6036710", Offset = "0x6035910", VA = "0x186036710", Slot = "4")]
		public void UpdateController(float HDOBGNHLIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCF8300", Offset = "0xCF7500", VA = "0x180CF8300", Slot = "6")]
		public void SetEnabled(bool AFCGKMGKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60361B0", Offset = "0x60353B0", VA = "0x1860361B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6036B20", Offset = "0x6035D20", VA = "0x186036B20")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AvatarElbowBendTargetController : MonoBehaviour, OIAGDKLIOKA
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const float LACLJGEACCA = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private Transform NeckBone;

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
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Vector3 MMLIOCLGBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3 KCLABJHLOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool KHLHODKLMLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float EEHIJBKBGOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float CCHHDJLLDCL;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6036EA0", Offset = "0x60360A0", VA = "0x186036EA0", Slot = "4")]
		public void UpdateController(float HDOBGNHLIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA19DD0", Offset = "0xA18FD0", VA = "0x180A19DD0", Slot = "6")]
		public void SetEnabled(bool AFCGKMGKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6036BC0", Offset = "0x6035DC0", VA = "0x186036BC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6037880", Offset = "0x6036A80", VA = "0x186037880")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60381A0", Offset = "0x60373A0", VA = "0x1860381A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6038160", Offset = "0x6037360", VA = "0x186038160")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60378B0", Offset = "0x6036AB0", VA = "0x1860378B0")]
		private void FAENIODGNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1162880", Offset = "0x1161A80", VA = "0x181162880", Slot = "4")]
		public void SetEnabled(bool CMIINBJIIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60381D0", Offset = "0x60373D0", VA = "0x1860381D0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarForearmRollController : MonoBehaviour, OIAGDKLIOKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private bool KHLHODKLMLA;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6038210", Offset = "0x6037410", VA = "0x186038210", Slot = "4")]
		public void UpdateController(float HDOBGNHLIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CCEF0", Offset = "0x7CC0F0", VA = "0x1807CCEF0", Slot = "6")]
		public void SetEnabled(bool AFCGKMGKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6038990", Offset = "0x6037B90", VA = "0x186038990")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, AOKDKGJABMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private JNHHHFECLDI DOFEHLONAJB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public JNHHHFECLDI DEBKMOPPHMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x60396D0", Offset = "0x60388D0", VA = "0x1860396D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform EHNBMHMCMAF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6039710", Offset = "0x6038910", VA = "0x186039710", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60389C0", Offset = "0x6037BC0", VA = "0x1860389C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6039590", Offset = "0x6038790", VA = "0x186039590")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6039540", Offset = "0x6038740", VA = "0x186039540")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60394D0", Offset = "0x60386D0", VA = "0x1860394D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6039450", Offset = "0x6038650", VA = "0x186039450", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60394D0", Offset = "0x60386D0", VA = "0x1860394D0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6038A50", Offset = "0x6037C50", VA = "0x186038A50", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60395E0", Offset = "0x60387E0", VA = "0x1860395E0", Slot = "8")]
		public void UpdatePostIKAnimControllers(float HDOBGNHLIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6038D80", Offset = "0x6037F80", VA = "0x186038D80")]
		private void FCAGBKKMAMG(GameObject MFLACBLODGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6038E10", Offset = "0x6038010", VA = "0x186038E10")]
		private JNHHHFECLDI GEFELEFJCIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is turned off.")]
			public float AngleOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			[Tooltip("Head pitch angle (+90 to -90) where IK is fully on.")]
			public float AngleOn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			[Tooltip("Normalized height (0-1) where IK is turned off.")]
			public float HeightOff;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			[Tooltip("Normalized height (0-1) where IK is fully on.")]
			public float HeightOn;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x604C740", Offset = "0x604B940", VA = "0x18604C740")]
			public float PLFINIMGIAC(float MBJLPPDLBKF, float BKKMNEGLKDE)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Header("Hand Animation")]
		[Tooltip("Time axis is the normalized distance the hand effector currently is from the origin of the upper arm bone.  A time of 0 implies the hand effector is directly on top of the upper arm origin (ie: up at your shoulder), a time = 1, that implies the hand effector is somewhere exactly a full arm's length away, a time of 1.7 implies the hand effector is somewhere exactly 1.7 times the arm's length away.  Value axis is the effector weight from 0 to 1.")]
		public AnimationCurve HandEffectorWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Time that the hand animator weight changes from 0 to 1 in a second. When the hand gesture system turns on when making a gesture, and off when the gesture system is idle, this determines the speed that it lerps towards the target weight.")]
		public float HandAnimatorWeightChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Time it takes to transition to an open or closed hand pose during an animated hand state transition")]
		public float HandOpenCloseChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D5")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Header("IK Weights")]
		[Tooltip("Control data for when to allow IK to control the head position for screens players.")]
		public WeightData ScreenHeadPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("Control data for when to allow IK to control the head rotation for screens players.")]
		public WeightData ScreenHeadRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("Control data for when to allow IK to control the pelvis position for screens players.")]
		public WeightData ScreenPelvisPositionWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Tooltip("Control data for when to allow IK to control the pelvis rotation for screens players.")]
		public WeightData ScreenPelvisRotationWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Header("VR runtime weights")]
		[Tooltip("The head is moved flat forward with given amount in VR to match up with our animated head position.")]
		public float StaticHeadForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("The animated root is moved flat forward with given amount in VR to match up the physical feet with our animated feet.")]
		public float StaticRootForward;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("Weight for head while moving. (0 = animated, 1 = VR)")]
		public float MovingHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Weight for head while idle. (0 = animated, 1 = VR)")]
		public float IdleHeadWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("Max head height offset compensation")]
		public float MaxHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("Min head height offset compensation")]
		public float MinHeadHeightOffsetCompensation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("Head height offset compensation smooth time")]
		public float HeadHeightCompensationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Distance to apply head movement dampening")]
		public float HeadHeightDampeningDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		public float ShoulderTwistBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("How much to twist when hands are at ShoulderTwistMinDist or ShoulderTwistMaxDist.")]
		public float ShoulderTwistAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Min distance between neck and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("Max distance between neck and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6039730", Offset = "0x6038930", VA = "0x186039730")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CMDJAFFBPLF : GBFPMEJODKB
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int IOOLPBIODOE;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int DDMCPNPLDOF;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int NLMPODHCAAL;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int OAOKAIJJFJO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int CJGDEODBFOL;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int NCEKBIJAIBJ;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int LMLPEBIHCCN;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int FFFIPIBIGLI;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static int[] FBOLNHADFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool BOFILBGLBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool COJEOLFDFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private bool IGFPMGEBALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private KAGLCMIKGAE DJPAJGGDKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private OMCPMJCHOGH JLIFHEICJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private OMCPMJCHOGH AMJJOEGBNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int HIEAEOOEAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private float MOIKFJDOEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Transform HPJFCIDKOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool GLOCBMDDMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Animator OGGEPBEBEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private AvatarFullBodyConfiguration AGALHGEFOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int KPABADHECOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int NOHBBNOCLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int IEJDHFEHFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private float MMIEFKFHJKG;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x603B1C0", Offset = "0x603A3C0", VA = "0x18603B1C0", Slot = "8")]
	public void AKCGAJHNOGB(KAGLCMIKGAE JLMMNPBANHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x603BC60", Offset = "0x603AE60", VA = "0x18603BC60", Slot = "9")]
	public void HHBLFPOCOIH(FGFJODOJHFO EEOIDMKGCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x603BCE0", Offset = "0x603AEE0", VA = "0x18603BCE0", Slot = "5")]
	public void MOOJPHEPGFF(bool ACHPDDADFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x603B390", Offset = "0x603A590", VA = "0x18603B390", Slot = "4")]
	public void BFKFDKJKHGE(BEDHNNAIJKL KMMPFOMKGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x603BB10", Offset = "0x603AD10", VA = "0x18603BB10")]
	private int FANHMDCLCHO(OMCPMJCHOGH GAPIPLACMCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x603B7E0", Offset = "0x603A9E0", VA = "0x18603B7E0")]
	private void CKOCDMNBOHJ(int KFNAEJAGHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x603B910", Offset = "0x603AB10", VA = "0x18603B910")]
	private bool CMBGGIEBBMB(BEDHNNAIJKL KMMPFOMKGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5772B40", Offset = "0x5771D40", VA = "0x185772B40", Slot = "6")]
	public bool IPMHHDMLGHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x603BB00", Offset = "0x603AD00", VA = "0x18603BB00", Slot = "7")]
	public bool EOLBDLEJIKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x603BCA0", Offset = "0x603AEA0", VA = "0x18603BCA0")]
	private OMCPMJCHOGH KHCLEIIAGDI()
	{
		return default(OMCPMJCHOGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x603C060", Offset = "0x603B260", VA = "0x18603C060")]
	public CMDJAFFBPLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25EFC80", Offset = "0x25EEE80", VA = "0x1825EFC80")]
	[CompilerGenerated]
	internal static bool GGJGAOICCFO<T>(T ICDPGDDEMLH, T? AFCGKMGKPEF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class OIBCKKMCDGN : JNHHHFECLDI
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class ANBDBHOBMCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private float ALPJMIFIMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private Vector3 EBFDPKPOBPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool KEAOILNBDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private float FFGMKJAGNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private bool AGJGJIFEBAI;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6035C60", Offset = "0x6034E60", VA = "0x186035C60")]
		public void PHMOHFNJMPB(IKSolverVR.Arm PAIJNFHPLPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6035650", Offset = "0x6034850", VA = "0x186035650")]
		public void GLMDBJHKNOF(IKSolverVR.Arm PAIJNFHPLPH, Transform FNJJNDELAEK, bool PKHJPDHNMEK, AvatarFullBodyConfiguration DELMKJICJBB, float PKGJJIILBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6035AB0", Offset = "0x6034CB0", VA = "0x186035AB0")]
		public void IGDMBNAAGDK(IKSolverVR.Arm PAIJNFHPLPH, bool OGNDGMONIKE, bool OKDLFPHPNDC, AvatarFullBodyConfiguration DELMKJICJBB, float PKGJJIILBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6035360", Offset = "0x6034560", VA = "0x186035360")]
		private void APLBEEEHNHD(Transform FNJJNDELAEK, IKSolverVR.Arm PAIJNFHPLPH, float FLFHANELBEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6035BF0", Offset = "0x6034DF0", VA = "0x186035BF0")]
		private void PDGOGJLMNEE(bool PKHJPDHNMEK, AvatarFullBodyConfiguration DELMKJICJBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6035870", Offset = "0x6034A70", VA = "0x186035870")]
		private void HGMCOENOOFD(AvatarFullBodyConfiguration DELMKJICJBB, float PKGJJIILBNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6035610", Offset = "0x6034810", VA = "0x186035610")]
		private void FAHFNJAIAJH(IKSolverVR.Arm PAIJNFHPLPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6035450", Offset = "0x6034650", VA = "0x186035450")]
		public void EOFFEMOIIHC(IKSolverVR.Arm PAIJNFHPLPH, Transform NBPMAACOGHD, Transform CHPAHKIBACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6035B60", Offset = "0x6034D60", VA = "0x186035B60")]
		private static float IKILMDHOLAE(bool CMIINBJIIDH, float OENBNGCFBKC, float FNMECGBNCHK, float KEGDPEHKNLI, float PKGJJIILBNO)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6035900", Offset = "0x6034B00", VA = "0x186035900")]
		private static void HKAJFFGJBAA(Transform NCFDKDOHGJF, Transform JHJPBIECOBN, Transform FGDNIGADAFI, float EBKMJKFMIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public ANBDBHOBMCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private enum KLEFJINGFJC
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private enum BMKFBEDOCHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int DADADPHJFLE;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int IEPPLMCFCHB;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int MLKPGPPFEFK;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int FDLMEIDKINE;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int DHIMJFNIENN;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int LBDCNIEBMDO;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int KPBJIFDFDBD;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int PKMMFMCFKBD;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int HGOJGEEPADJ;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int NKAGILCPNKL;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int BEFECLEFLDH;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int ACGHJFILNNO;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int ILIJACCPAJL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int LKGIKEBHDCM;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int OEBGLMMABJB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int PLOCMECJPDM;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int CACPFMDDGFE;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int CNFPMEBHEGP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int GIFAJKIDDFI;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int PMOHDAJBKIB;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int FPDCLCIEDNM;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int HLHMJGGOIDO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int ENMCEMDGIMB;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int FJKOFNFIJJD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int DPHJHELALJE;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int ANCEPMJNJFG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int CLEOBDNAPFC;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int HJCNGGOPOEF;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int MNALAGOLAGJ;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int MLBHLJMOEAA;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 PFDBCPIBHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool ICNOMBKPLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool HHCEBHKJHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool HOBGKBGCONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool LCEGKJEKJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool HHNOAEHKFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Vector3 MLALPOOGBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JGKDMDJGOMC? DJPAJGGDKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private IIJACPAFGNC? GPEBJEGPMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NHMGPAIJFOH CNALNPDNBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private ILOGNEPBCFJ BPJCKOHEKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private CMDJAFFBPLF CLMIFNBGAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private CMDJAFFBPLF ONFFFGHOJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool MJICBKKHLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool BJFJMAGHAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly HMPJKDNEANA PJNKKGHOHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly LLAIDNAJOMJ HKMPBAFEIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int MOIOJEPDGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private float JFEBFOGHCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private GameObject HHDIPHPJBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform NOKCOMPJIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform CKIMBJNBBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private float DPKBHPDJPBJ;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker JDFLEDDIGCH;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker NPGJKMFEIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private ProfilerMarker GHLPCEIIBCN;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker OCJMCOBNHLP;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker FBLHGKNMJJJ;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker FJKCCECJNBC;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly List<OIBCKKMCDGN> MMIPLPKJODA;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int PDBGHLIMJLN;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> EIPIIPKLDEO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int EHONCMODGBC;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static int BCEHABNMFFE;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int HFDPCAGFKJN;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static int JMBOCINKOBK;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static float DFNJNBOKAHD;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int LDAMMPDEPPD;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static float FIMBBOOKMBL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static float DMLJGDJPJMO;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static float PDCMOAPIGNC;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static float GAFCEHGNPIO;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static EEFCCADMMBC HEMBBCOJNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private float DFPAOEAOEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private bool OCNMLBIBLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float MLINDNDJOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private ANBDBHOBMCG CPGAMPNBKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private ANBDBHOBMCG DGKPCOAEHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private KLEFJINGFJC NNMKFOBINLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float OKOFIOFKFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly FFOEHGOPPMA BDBNMGBKHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float BIICOFAMNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private float KFBEGAPOPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private Vector3 FMOJKECGGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly CDACBHEOJMO BHDEENDHDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly AENDDEKNOII DBIEELNFCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float PFJOMJEMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private KLEFJINGFJC DGBIGKCDBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Vector3 IGFPCIBKIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private float DKIKHBGPNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private float IPLBMADCDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private FOIBOOLMBOJ MAFLOEHGNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private CDACBHEOJMO AAODOLLJNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly CDACBHEOJMO INPIOEJFNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly FOIBOOLMBOJ LPPLIDPGIHO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DIKKIJJDOON PDBOHAELGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DIKKIJJDOON FKEOFMEFNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration CFFAJBIIAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6042E30", Offset = "0x6042030", VA = "0x186042E30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AvatarFullBodyConfiguration PEJDICBFJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x604A510", Offset = "0x6049710", VA = "0x18604A510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform FILLKEHNBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6042D60", Offset = "0x6041F60", VA = "0x186042D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform OJMOBGBABAK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6049A40", Offset = "0x6048C40", VA = "0x186049A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private SkinnedMeshRenderer PHIJHLNMNOK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6044570", Offset = "0x6043770", VA = "0x186044570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Renderer[] DAGNIDEMOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x604A670", Offset = "0x6049870", VA = "0x18604A670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GameObject[] OFKNEEFINLH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60432A0", Offset = "0x60424A0", VA = "0x1860432A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Animator IHINEDIONAI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x604B5E0", Offset = "0x604A7E0", VA = "0x18604B5E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private VRIK IEDLOPEBLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60444A0", Offset = "0x60436A0", VA = "0x1860444A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private OIAGDKLIOKA DCEFAGDENJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x604A030", Offset = "0x6049230", VA = "0x18604A030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private OIAGDKLIOKA BLANFIHCPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x604A5A0", Offset = "0x60497A0", VA = "0x18604A5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private OIAGDKLIOKA CADDJOJOLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x60443D0", Offset = "0x60435D0", VA = "0x1860443D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private OIAGDKLIOKA FLCFOOHJAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60415E0", Offset = "0x60407E0", VA = "0x1860415E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private OIAGDKLIOKA IOMBEGGDPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60406E0", Offset = "0x603F8E0", VA = "0x1860406E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private OIAGDKLIOKA AFAMIBADMLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x604AD60", Offset = "0x6049F60", VA = "0x18604AD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private OIAGDKLIOKA FNOOBNBPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x604A810", Offset = "0x6049A10", VA = "0x18604A810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private OIAGDKLIOKA ACIOCPPGCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x603CD30", Offset = "0x603BF30", VA = "0x18603CD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IIJACPAFGNC HGHEGKPLMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x603EE80", Offset = "0x603E080", VA = "0x18603EE80", Slot = "30")]
		get
		{
			return default(IIJACPAFGNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public NHMMPKEDMBO IGAIJPFLAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8BDDA0", Offset = "0x8BCFA0", VA = "0x1808BDDA0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ABNNEBAAPJA OMDLBGGJEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA42980", Offset = "0xA41B80", VA = "0x180A42980", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GBFPMEJODKB NNIKFCECEJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xD9F850", Offset = "0xD9EA50", VA = "0x180D9F850", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GBFPMEJODKB BFKNHECGJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA48C10", Offset = "0xA47E10", VA = "0x180A48C10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GameObject JLBELLDLMIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60481D0", Offset = "0x60473D0", VA = "0x1860481D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform MLKDMAJCIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1920", Offset = "0x9B0B20", VA = "0x1809B1920", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Transform NBJJENNDLDL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1900", Offset = "0x9B0B00", VA = "0x1809B1900", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Transform DALBNDKIIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x603F940", Offset = "0x603EB40", VA = "0x18603F940", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool OEPMKALBLKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6040680", Offset = "0x603F880", VA = "0x186040680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool DIMLDABDDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x604B560", Offset = "0x604A760", VA = "0x18604B560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x603D530", Offset = "0x603C730", VA = "0x18603D530")]
	private void ANEGJPFHFEC([In] OGGLKAANNHD EOMMONLOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x604B6B0", Offset = "0x604A8B0", VA = "0x18604B6B0")]
	private void PDJMJLHKMDP(OGGLKAANNHD EOMMONLOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60434C0", Offset = "0x60426C0", VA = "0x1860434C0")]
	private void GHIEEJCJJDA(GCGKPAAFDCB FANMHDGCKKH, FHIMAIMKMAM MDHCALKIILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60416B0", Offset = "0x60408B0", VA = "0x1860416B0")]
	private void EBEIKNKCCFA([In] OGGLKAANNHD MJCOPLGCMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x604BFE0", Offset = "0x604B1E0", VA = "0x18604BFE0")]
	public OIBCKKMCDGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6044810", Offset = "0x6043A10", VA = "0x186044810", Slot = "11")]
	public void IBGNKKGIKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6043680", Offset = "0x6042880", VA = "0x186043680", Slot = "12")]
	public void GHMMMFKHBFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x604A740", Offset = "0x6049940", VA = "0x18604A740", Slot = "13")]
	public void MBGFEFNNNLA(bool BKJDJHLKJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x60426E0", Offset = "0x60418E0", VA = "0x1860426E0", Slot = "21")]
	public Transform EEKKKAKIBMO(string NAOILIBFHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x60468A0", Offset = "0x6045AA0", VA = "0x1860468A0", Slot = "22")]
	public Vector3? ILMGBCELCHK(string NAOILIBFHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x60455F0", Offset = "0x60447F0", VA = "0x1860455F0", Slot = "6")]
	public void IKBOEHJHPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x603FB20", Offset = "0x603ED20", VA = "0x18603FB20", Slot = "7")]
	public void CFDPDFNMGND(float EOONHGBNKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x603D4E0", Offset = "0x603C6E0", VA = "0x18603D4E0")]
	private void ALLNEBLPKCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6048430", Offset = "0x6047630", VA = "0x186048430", Slot = "4")]
	public void KCCNFIMOANB(JGKDMDJGOMC HBAFFMGMJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x604A8E0", Offset = "0x6049AE0", VA = "0x18604A8E0", Slot = "5")]
	public void MDNJACCGHMA(IIJACPAFGNC EEOIDMKGCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6043040", Offset = "0x6042240", VA = "0x186043040", Slot = "10")]
	public void FCPKNGHJNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6042830", Offset = "0x6041A30", VA = "0x186042830", Slot = "20")]
	public void EEMLCIGCMFF([Out] Vector3 EOLDBEIEBJI, [Out] Quaternion COHJPDAOKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6044640", Offset = "0x6043840", VA = "0x186044640", Slot = "23")]
	public void HOHBNBAEODP(float ANOEEOCIKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6043130", Offset = "0x6042330", VA = "0x186043130", Slot = "24")]
	public void FEEHDBFMGGK(bool FHJAPBIIMMB, bool PLBCHGFDIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x603EFB0", Offset = "0x603E1B0", VA = "0x18603EFB0", Slot = "25")]
	public HandLogicOffsets BLIKKLBLMJL()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x603F290", Offset = "0x603E490", VA = "0x18603F290", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets BMFPLIDPGJP()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x604B0C0", Offset = "0x604A2C0", VA = "0x18604B0C0")]
	private void NMOLOKINFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6043FD0", Offset = "0x60431D0", VA = "0x186043FD0")]
	private void HGPJMOIKHJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6044C20", Offset = "0x6043E20", VA = "0x186044C20")]
	private void ICFHKDAGEEK(RigidbodyEx NPOMOMAGCCP, bool OACHBGFPODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6042BD0", Offset = "0x6041DD0", VA = "0x186042BD0")]
	private void EFDAGLKABDA(RigidbodyEx NPOMOMAGCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6043970", Offset = "0x6042B70", VA = "0x186043970")]
	public Vector3 GOIMBMAIGKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6043230", Offset = "0x6042430", VA = "0x186043230")]
	private void FODHPCBGDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6048270", Offset = "0x6047470", VA = "0x186048270")]
	private float KBDMAIDPHAE([In] OGGLKAANNHD MJCOPLGCMGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x604AE30", Offset = "0x604A030", VA = "0x18604AE30")]
	private int NEMOEAKHHNK([In] DJJNKJIIHPO NEADAICMLHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x603E950", Offset = "0x603DB50", VA = "0x18603E950")]
	private void BAEACDHOEHN(OGGLKAANNHD EOMMONLOCCD, bool OANLCBJPADD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x603F060", Offset = "0x603E260", VA = "0x18603F060")]
	private static void BMBPNGOIAHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6041B50", Offset = "0x6040D50", VA = "0x186041B50")]
	private static void EDJLEEBDGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6043370", Offset = "0x6042570", VA = "0x186043370")]
	private float GDHBAOMLMAI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6043200", Offset = "0x6042400", VA = "0x186043200")]
	private static int FMMNEJOMDEC(OIBCKKMCDGN GNBALBEAIKA, OIBCKKMCDGN ODFCMCFCPMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6047830", Offset = "0x6046A30", VA = "0x186047830")]
	private void JFIEGEMPPDA(OGGLKAANNHD MJCOPLGCMGI, AvatarFullBodyConfiguration DELMKJICJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6042F00", Offset = "0x6042100", VA = "0x186042F00")]
	private void EOFFEMOIIHC([In] OGGLKAANNHD MJCOPLGCMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x603F9A0", Offset = "0x603EBA0", VA = "0x18603F9A0")]
	private void CDLFJKKLJNI([In] OGGLKAANNHD MJCOPLGCMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xD5F0C0", Offset = "0xD5E2C0", VA = "0x180D5F0C0")]
	private void GPPBCBLDLPO(RigidbodyEx IPCJOHCFKHH, Transform CHPAHKIBACA, Transform JJDBOKOLMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6040E10", Offset = "0x6040010", VA = "0x186040E10")]
	private float DAGBFPNIKMG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6046DC0", Offset = "0x6045FC0", VA = "0x186046DC0")]
	private void IOJLBHFAHNK([In] OGGLKAANNHD MJCOPLGCMGI, [In] BMKFBEDOCHA IIIOPLEHJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60496F0", Offset = "0x60488F0", VA = "0x1860496F0")]
	private void KCFGBDHGKOD(OGGLKAANNHD MJCOPLGCMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x604B180", Offset = "0x604A380", VA = "0x18604B180")]
	private void OCIDCMODMDC(KLEFJINGFJC OMJFHBACBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6041930", Offset = "0x6040B30", VA = "0x186041930")]
	private void EDCHMHKNGJC(float NCFPACNHJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6040E90", Offset = "0x6040090", VA = "0x186040E90")]
	private void DCABINJKOKN([In] OGGLKAANNHD MJCOPLGCMGI, BMKFBEDOCHA IIIOPLEHJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x603CE00", Offset = "0x603C000", VA = "0x18603CE00")]
	private Vector3 AGOICFCHEGJ([In] OGGLKAANNHD MJCOPLGCMGI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6045200", Offset = "0x6044400", VA = "0x186045200")]
	private float IHFKJFGGGKG(float LMAIEPGCEDB, [In] OGGLKAANNHD MJCOPLGCMGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6048410", Offset = "0x6047610", VA = "0x186048410")]
	private void KBIHNJDOIEC(KLEFJINGFJC OMJFHBACBIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60446C0", Offset = "0x60438C0", VA = "0x1860446C0")]
	private void IAFKGKIBPMN(float LMAIEPGCEDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60439C0", Offset = "0x6042BC0", VA = "0x1860439C0")]
	private void HGDLGFNFKBC([In] OGGLKAANNHD MJCOPLGCMGI, BMKFBEDOCHA IIIOPLEHJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x604A100", Offset = "0x6049300", VA = "0x18604A100")]
	private float LGPNMDEBHHB([In] OGGLKAANNHD EOMMONLOCCD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6049B10", Offset = "0x6048D10", VA = "0x186049B10")]
	private void KJGNJJDEKFL(OGGLKAANNHD MJCOPLGCMGI, BMKFBEDOCHA IIIOPLEHJEB, Vector3 FLEFLJLLMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x604AF10", Offset = "0x604A110", VA = "0x18604AF10")]
	private static void NKJAIKFBLIL(Transform ABJBIFMIENO, Quaternion KIIONLKEIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x603FB90", Offset = "0x603ED90", VA = "0x18603FB90")]
	private void CFMNGDHKGEC([In] OGGLKAANNHD LOOPHDCDDEP, [In] DJJNKJIIHPO NEADAICMLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x603C680", Offset = "0x603B880", VA = "0x18603C680")]
	private void ABMPHKMPKBM([In] OGGLKAANNHD LOOPHDCDDEP, [In] DJJNKJIIHPO NEADAICMLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60407B0", Offset = "0x603F9B0", VA = "0x1860407B0")]
	private void CMAJKCPNLIK([In] OGGLKAANNHD MJCOPLGCMGI, [In] AvatarFullBodyConfiguration DELMKJICJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x60462D0", Offset = "0x60454D0", VA = "0x1860462D0")]
	public void IKIKLMNFDDL([In] OGGLKAANNHD MJCOPLGCMGI, [In] AvatarFullBodyConfiguration DELMKJICJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x603F350", Offset = "0x603E550", VA = "0x18603F350", Slot = "31")]
	protected virtual void BNDDAACDAHO([In] OGGLKAANNHD MJCOPLGCMGI, [In] AvatarFullBodyConfiguration DELMKJICJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6046570", Offset = "0x6045770", VA = "0x186046570")]
	private void IKKMJADCIHG([In] OGGLKAANNHD MJCOPLGCMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6044DA0", Offset = "0x6043FA0", VA = "0x186044DA0")]
	private void IFEELCFEHAI(float ICHGHKKFBCK, [In] OGGLKAANNHD EOMMONLOCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60473E0", Offset = "0x60465E0", VA = "0x1860473E0")]
	private float IPIAKMHPIGG([In] AvatarFullBodyConfiguration DELMKJICJBB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6046A30", Offset = "0x6045C30", VA = "0x186046A30")]
	private void IOHPFFODNKF([In] OGGLKAANNHD EOMMONLOCCD, [In] AvatarFullBodyConfiguration DELMKJICJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x604B1A0", Offset = "0x604A3A0", VA = "0x18604B1A0")]
	private void OLAIPNAFDEH([In] OGGLKAANNHD EOMMONLOCCD, float AECMLGDOMAD, float AGIAKMCPJOL, Vector3 ADBCACFJLMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x603FE90", Offset = "0x603F090", VA = "0x18603FE90")]
	private void CGDEBEJILJE(OGGLKAANNHD EOMMONLOCCD, AvatarFullBodyConfiguration DELMKJICJBB)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum OFPIIDBDAOM
		{
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private OFPIIDBDAOM handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6039FE0", Offset = "0x60391E0", VA = "0x186039FE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6039FA0", Offset = "0x60391A0", VA = "0x186039FA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6039970", Offset = "0x6038B70", VA = "0x186039970")]
		private void FAENIODGNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1162880", Offset = "0x1161A80", VA = "0x181162880", Slot = "4")]
		public void SetEnabled(bool CMIINBJIIDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x603A010", Offset = "0x6039210", VA = "0x18603A010")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarKneeBendTargetController : MonoBehaviour, OIAGDKLIOKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 MMLIOCLGBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 FNGHINJEKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 HJNHHIHKBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Matrix4x4 LOLGPIDBKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private bool KHLHODKLMLA;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x603A4A0", Offset = "0x60396A0", VA = "0x18603A4A0", Slot = "4")]
		public void UpdateController(float HDOBGNHLIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5F6BE20", Offset = "0x5F6B020", VA = "0x185F6BE20", Slot = "6")]
		public void SetEnabled(bool AFCGKMGKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x603A040", Offset = "0x6039240", VA = "0x18603A040")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x603AB60", Offset = "0x6039D60", VA = "0x18603AB60")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class KIDFAJKLMEI : CFMEABNBKGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Dictionary<string, JNHHHFECLDI> DJPFOODDLML;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool OKNCLMOCKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x603C3C0", Offset = "0x603B5C0", VA = "0x18603C3C0")]
	[JKGCDNJCKNE(MDFHPBOGAKL.Root, LIEILBDPEFI.None)]
	private static void KGONFBCPGMH(IAIHJGNDPNA DEFANHHPGKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x603C200", Offset = "0x603B400", VA = "0x18603C200", Slot = "4")]
	public JNHHHFECLDI KCAFJECGOCL(string CDMBOKOKNOF, AvatarSystemConfiguration FGECKGHIPEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x603C070", Offset = "0x603B270", VA = "0x18603C070", Slot = "5")]
	public void CPOGALAPDLC(string CDMBOKOKNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x603C4C0", Offset = "0x603B6C0", VA = "0x18603C4C0")]
	public KIDFAJKLMEI()
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
		public class ONMEPIAFEHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private Dictionary<string, Transform> KOBLGGDFBEH;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public bool IOBGPOINBGP
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x604C3E0", Offset = "0x604B5E0", VA = "0x18604C3E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x604C420", Offset = "0x604B620", VA = "0x18604C420")]
			public void CCMEEKLBMPH(VRIK NFFCNNCGPFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0")]
			public void CENKKLCELIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x604C550", Offset = "0x604B750", VA = "0x18604C550")]
			public void HBHCINBKNHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x604C5A0", Offset = "0x604B7A0", VA = "0x18604C5A0")]
			public ONMEPIAFEHH()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		[FNMOBJNDEPF(DOGHHGCAALN.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		[PFGEJILCEKJ(DOGHHGCAALN.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private readonly ONMEPIAFEHH EBFHDGGIPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private AOKDKGJABMP GAJJEOFLMNA;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x603AB70", Offset = "0x6039D70", VA = "0x18603AB70")]
		private void AKCGAJHNOGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x603AE30", Offset = "0x603A030", VA = "0x18603AE30")]
		private bool JGGBICMNGHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x603AE80", Offset = "0x603A080", VA = "0x18603AE80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x603AEF0", Offset = "0x603A0F0", VA = "0x18603AEF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x603AE90", Offset = "0x603A090", VA = "0x18603AE90")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x603B0E0", Offset = "0x603A2E0", VA = "0x18603B0E0")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x603C550", Offset = "0x603B750", VA = "0x18603C550", Slot = "4")]
		public override void OnStateEnter(Animator DICJNPNJAAB, AnimatorStateInfo FEFIJIBIEGI, int ENKELHFIFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x603C670", Offset = "0x603B870", VA = "0x18603C670")]
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
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6035C90", Offset = "0x6034E90", VA = "0x186035C90")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
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
