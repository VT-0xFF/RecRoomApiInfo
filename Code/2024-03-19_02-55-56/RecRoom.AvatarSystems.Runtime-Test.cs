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
	public class AvatarElbowBendHelperController : MonoBehaviour, MEMCONAKEHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
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
		private Vector3? MNMOFAJCJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private bool JJKCNAPNFBK;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6073730", Offset = "0x6072730", VA = "0x186073730", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6073D30", Offset = "0x6072D30", VA = "0x186073D30", Slot = "4")]
		public void UpdateController(float HBFOIDKFIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xCF05C0", Offset = "0xCEF5C0", VA = "0x180CF05C0", Slot = "6")]
		public void SetEnabled(bool CFJDHAGGAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x60737D0", Offset = "0x60727D0", VA = "0x1860737D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6074140", Offset = "0x6073140", VA = "0x186074140")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AvatarElbowBendTargetController : MonoBehaviour, MEMCONAKEHI
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private const float CAMDHNAENNC = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
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
		private Vector3 DNKCCJAMEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Vector3 MBIGFIKMFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool JJKCNAPNFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private float AKOFJNGCKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private float PGGOGOCMDOG;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60744C0", Offset = "0x60734C0", VA = "0x1860744C0", Slot = "4")]
		public void UpdateController(float HBFOIDKFIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA189C0", Offset = "0xA179C0", VA = "0x180A189C0", Slot = "6")]
		public void SetEnabled(bool CFJDHAGGAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60741E0", Offset = "0x60731E0", VA = "0x1860741E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6074EA0", Offset = "0x6073EA0", VA = "0x186074EA0")]
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
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x60757C0", Offset = "0x60747C0", VA = "0x1860757C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6075780", Offset = "0x6074780", VA = "0x186075780")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6074ED0", Offset = "0x6073ED0", VA = "0x186074ED0")]
		private void JIPLDMNIJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x11694F0", Offset = "0x11684F0", VA = "0x1811694F0", Slot = "4")]
		public void SetEnabled(bool PNLCCPNIGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60757F0", Offset = "0x60747F0", VA = "0x1860757F0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AvatarForearmRollController : MonoBehaviour, MEMCONAKEHI
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
		private bool JJKCNAPNFBK;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6075830", Offset = "0x6074830", VA = "0x186075830", Slot = "4")]
		public void UpdateController(float HBFOIDKFIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CCA70", Offset = "0x7CBA70", VA = "0x1807CCA70", Slot = "6")]
		public void SetEnabled(bool CFJDHAGGAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6075FB0", Offset = "0x6074FB0", VA = "0x186075FB0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, AEFGNMCBDFJ
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
		[JMOFFDBDEHI(HLBGFFAONPF.SelfAndChildren, false, false, false)]
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
		private KJNONANIEAC MJGJNCOPCNA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KJNONANIEAC OBCLLGBFGPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6076CF0", Offset = "0x6075CF0", VA = "0x186076CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform MEAOPPEALJD
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6076D30", Offset = "0x6075D30", VA = "0x186076D30", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6075FE0", Offset = "0x6074FE0", VA = "0x186075FE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6076BB0", Offset = "0x6075BB0", VA = "0x186076BB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6076B60", Offset = "0x6075B60", VA = "0x186076B60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6076AF0", Offset = "0x6075AF0", VA = "0x186076AF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60769E0", Offset = "0x60759E0", VA = "0x1860769E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6076AF0", Offset = "0x6075AF0", VA = "0x186076AF0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6076070", Offset = "0x6075070", VA = "0x186076070", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6076C00", Offset = "0x6075C00", VA = "0x186076C00", Slot = "8")]
		public void UpdatePostIKAnimControllers(float HBFOIDKFIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6076A60", Offset = "0x6075A60", VA = "0x186076A60")]
		private void MCHJNLHDOOA(GameObject FGOCJODIEMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60763A0", Offset = "0x60753A0", VA = "0x1860763A0")]
		private KJNONANIEAC DKIJOGBGNEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
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
			[Cpp2IlInjected.Address(RVA = "0x608A690", Offset = "0x6089690", VA = "0x18608A690")]
			public float JMICPDIOEEH(float KHKICEKFDCF, float PANFPCKOBON)
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
		[Cpp2IlInjected.Address(RVA = "0x6076D50", Offset = "0x6075D50", VA = "0x186076D50")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LPFLEIKGKAD : FNMEKIPLEIA
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static int CFBLAFOPCOE;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static int OJEADIFBFIK;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int GHIHJMJCKOK;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int COGFKHKGOEL;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int GGKHMDFJMCF;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int PENELDHGJNH;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int JMHMLHMNEAA;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static int LILJGKJMPBM;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static int[] NABICMKNDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool LGPODEOPKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool IBGLHPCNLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private bool EMBPKGEMPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private MBOEDHIFOIP HNGHBEMDLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private IJOIHDELMHF FBEHGDPLCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IJOIHDELMHF FLCFCJJICGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int DNLNAKKGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private float IMPGCFJKOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Transform IEDOAIICPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool HDGEHLODMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Animator DCMICLOONAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private AvatarFullBodyConfiguration AOEIIIACKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int JAINIIACGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int DBPICBKCNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int BMFGMHODEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private float OPGCMOPBPHM;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6079750", Offset = "0x6078750", VA = "0x186079750", Slot = "8")]
	public void DPGLELIALOP(MBOEDHIFOIP NLNJNAOHNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x607A090", Offset = "0x6079090", VA = "0x18607A090", Slot = "9")]
	public void LCBMHAEPGKO(FPLGKJFGKHC JLPJDGDOCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x607A110", Offset = "0x6079110", VA = "0x18607A110", Slot = "5")]
	public void NGMIIGFAMJM(bool DLLADFNIMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6079C40", Offset = "0x6078C40", VA = "0x186079C40", Slot = "4")]
	public void KKDJCKHPLND(HFLAFCBDBOI DOOLMIKNBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6079600", Offset = "0x6078600", VA = "0x186079600")]
	private int BKLEDHMNDIO(IJOIHDELMHF APGEMDKJKBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6079920", Offset = "0x6078920", VA = "0x186079920")]
	private void GMNGIDOGHMF(int GGMLNBBHGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6079A50", Offset = "0x6078A50", VA = "0x186079A50")]
	private bool JEFGFMPPOGO(HFLAFCBDBOI DOOLMIKNBKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x57AE090", Offset = "0x57AD090", VA = "0x1857AE090", Slot = "6")]
	public bool GMIPFJABCPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60795F0", Offset = "0x60785F0", VA = "0x1860795F0", Slot = "7")]
	public bool AAPEAOMOPPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x607A0D0", Offset = "0x60790D0", VA = "0x18607A0D0")]
	private IJOIHDELMHF MHLKEOILGHB()
	{
		return default(IJOIHDELMHF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x607A490", Offset = "0x6079490", VA = "0x18607A490")]
	public LPFLEIKGKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x284D5A0", Offset = "0x284C5A0", VA = "0x18284D5A0")]
	[CompilerGenerated]
	internal static bool AOGIDODOHAD<T>(T JJOIPFFFGPK, T? CFJDHAGGAJO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class NKEDALBPFNF : KJNONANIEAC
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class EPEHPGMKHMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private float KHJDHIEHGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private Vector3 MMADONFBFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool LDEBEILDINL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private float MMFLEKLHNOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private bool MHAEEICHFOM;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x60792B0", Offset = "0x60782B0", VA = "0x1860792B0")]
		public void HOLFFGBFLMA(IKSolverVR.Arm EMAEOJCBFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x60793D0", Offset = "0x60783D0", VA = "0x1860793D0")]
		public void OMCGAMKHHGL(IKSolverVR.Arm EMAEOJCBFHB, Transform GJLACOMEIFJ, bool CKJIBJPFPKP, AvatarFullBodyConfiguration DJEDGNFIGON, float PCLIIKDIPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6079320", Offset = "0x6078320", VA = "0x186079320")]
		public void NFOIMLDNJAE(IKSolverVR.Arm EMAEOJCBFHB, bool HKDLJKDGKJI, bool BHHJDLLBEEK, AvatarFullBodyConfiguration DJEDGNFIGON, float PCLIIKDIPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6078E80", Offset = "0x6077E80", VA = "0x186078E80")]
		private void ECFMDLHBDOP(Transform GJLACOMEIFJ, IKSolverVR.Arm EMAEOJCBFHB, float MHBKGIPPLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6079000", Offset = "0x6078000", VA = "0x186079000")]
		private void GHHMJBOMJBB(bool CKJIBJPFPKP, AvatarFullBodyConfiguration DJEDGNFIGON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6078F70", Offset = "0x6077F70", VA = "0x186078F70")]
		private void FKFLLMFDLOP(AvatarFullBodyConfiguration DJEDGNFIGON, float PCLIIKDIPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x60792E0", Offset = "0x60782E0", VA = "0x1860792E0")]
		private void KFIGPIHNKCC(IKSolverVR.Arm EMAEOJCBFHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6078CC0", Offset = "0x6077CC0", VA = "0x186078CC0")]
		public void EBCOJPHONIF(IKSolverVR.Arm EMAEOJCBFHB, Transform BOMDHABGDFD, Transform FJMIHGFDCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6079220", Offset = "0x6078220", VA = "0x186079220")]
		private static float HLEGEDPMLBD(bool PNLCCPNIGII, float GMAICFHLBBK, float DNPAHELAOGC, float LCHANFCDFJB, float PCLIIKDIPFP)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6079070", Offset = "0x6078070", VA = "0x186079070")]
		private static void HICLAOMJBFM(Transform DGEFAJIGFBJ, Transform HNHDMAPHPKF, Transform CIMNLHIDKNH, float DGHBKKEKGNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public EPEHPGMKHMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private enum NLHCAEFMLNK
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
	private enum FBLPKFPMDHB
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int PIMHLMAGOBP;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int HDCEIIOCIKG;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int NBKPKJBMANK;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int PJJIHCBPMPI;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int PBOPDKFOIGI;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int LLOJCBGEJLB;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int HBLKFINJIBC;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int JOCMEOGDKAF;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int KOPGAJKLLCN;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int JNNOBBMODFA;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int DMCPKJPMJGI;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int ADMAAMBBFGK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int KNHNNKBHJOF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int JMEBLAHIBLO;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int GPPNFECINAK;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int HDGDIIICEMC;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int JLJKDJEMBKF;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int CEMMEKOCAPA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int ONIFDDKIHPP;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int LAFDFCNFCNB;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int NCJLBAAJOAL;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int GBBBPJAAMOL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int LKPGIHKKHEK;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int DDONNHABCGC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int MGFCFIHLDEK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int LKDGBJACIDJ;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int JELIKMKCLDK;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int MEKEMOOBMNE;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int NCGEBGOGCIB;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int GGFAEHJKLJN;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Vector3 LFKBGPMCEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool APGOHPGLLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool LGKPPGNNDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool FLOIDLAOAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool MHOPIIFGKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool LFLELDIHMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Vector3 IGJIMLNINOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private BJOLIDHLPPI? HNGHBEMDLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private ABIFGNOALND? FKNCBKFOMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private CAGBLKLHPCD AAMAJHFHJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private EBJBENHNOON NHBFPMHGDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private LPFLEIKGKAD NLCLFLLDPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private LPFLEIKGKAD EPKBBCHKAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool ICBIKKEOHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x211")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool ELPNNIEDCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly OEJKPKBFICG BCHAMMIPJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly DABCKACPAND AFIEGCHMKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int KMCLLGAAGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private float GPBIOAIAMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private GameObject GCLCJFDJCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform FHEJMGDEPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform ACICPPOCOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private float MDMEKDCFIMO;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly ProfilerMarker LFEJJEKCECG;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly ProfilerMarker LLGCILIKPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private ProfilerMarker EAEDCFKFOEA;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly ProfilerMarker KIBCIIBCGCE;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private static readonly ProfilerMarker NJDPJAFLPLE;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private static readonly ProfilerMarker CECKKPJKBDK;

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private static readonly List<NKEDALBPFNF> BDMEPBGDHLM;

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static int BEKKKELFHGB;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> DMBFEMADIAO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static int DJHEMFGHHII;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static int GLINLGOFLPG;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static int PCPEPPICMGA;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static int JJHLBJAIFKJ;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static float NODJOGMCBNP;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static int LDAKNPNNBPG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static float LGKDFOCECLD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static float LBMEPNFBMFF;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static float OLBCGFIEJNA;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static float DKMFDENJBBA;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static DHBFCCJLCIE BADJJAEICKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private float JALMMOHEHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private bool OHEFPNFAJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private float DMNALAJJJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private EPEHPGMKHMH DOFOKOJBOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private EPEHPGMKHMH KCCFHOICODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private NLHCAEFMLNK DOHEMALHLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private float CHNMOABFPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly PPFCPCAKHKK KGKGLJLJGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float CPDHHIOJNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private float HGOICOPFEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private Vector3 NMBKHCHNLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly IJJEDEGPDIF DGACFGNFECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly ENPMBOEHHHH JABPHDPBDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private float GKCIGOFKECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NLHCAEFMLNK DODPAOKMJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Vector3 PLOCJDPCMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private float BPPAHBLNADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private float MCFNCKJEABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private IBLMKEDKAMJ BKGJCKACDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private IJJEDEGPDIF JOIOEKPNKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly IJJEDEGPDIF OBHIFOLOLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly IBLMKEDKAMJ ONECBDHHNPA;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LHMMLLGDOFK GCLMIMFJEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LHMMLLGDOFK HFOBGDLNMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration LIKKAJHBOFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x607DE00", Offset = "0x607CE00", VA = "0x18607DE00", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AvatarFullBodyConfiguration NGDKMEONMKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x607F9A0", Offset = "0x607E9A0", VA = "0x18607F9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform IHLJNCEOHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6088C90", Offset = "0x6087C90", VA = "0x186088C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform JIINDELOHGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x607D740", Offset = "0x607C740", VA = "0x18607D740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private SkinnedMeshRenderer BKDDHBDGOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x607FA30", Offset = "0x607EA30", VA = "0x18607FA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private Renderer[] LFGPMMJJFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x607C040", Offset = "0x607B040", VA = "0x18607C040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private GameObject[] IHDBFGGLNON
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x607BC00", Offset = "0x607AC00", VA = "0x18607BC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private Animator NJOPNEJMNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x607AD00", Offset = "0x6079D00", VA = "0x18607AD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private VRIK HFGHDIOFPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6080090", Offset = "0x607F090", VA = "0x186080090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private MEMCONAKEHI BOLBAGKBDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x607C110", Offset = "0x607B110", VA = "0x18607C110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private MEMCONAKEHI FIMJEFLFOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x607EFB0", Offset = "0x607DFB0", VA = "0x18607EFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private MEMCONAKEHI AOMBLGPDGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6087CD0", Offset = "0x6086CD0", VA = "0x186087CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private MEMCONAKEHI CAMGMDDNPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6083160", Offset = "0x6082160", VA = "0x186083160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private MEMCONAKEHI CAEDMMJFNCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x607A770", Offset = "0x6079770", VA = "0x18607A770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private MEMCONAKEHI COKJHHHFAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6084230", Offset = "0x6083230", VA = "0x186084230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private MEMCONAKEHI BMPMCMKHAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6081000", Offset = "0x6080000", VA = "0x186081000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private MEMCONAKEHI EPMMLGHKPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60829A0", Offset = "0x60819A0", VA = "0x1860829A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ABIFGNOALND HFBABDGJKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6082640", Offset = "0x6081640", VA = "0x186082640", Slot = "30")]
		get
		{
			return default(ABIFGNOALND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public IDFLJADJJAG ADCCIPNHABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8BBF20", Offset = "0x8BAF20", VA = "0x1808BBF20", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public KKPBJLIGLDA NNDPKOIAOEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA3C990", Offset = "0xA3B990", VA = "0x180A3C990", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FNMEKIPLEIA CJPOPDDGJJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xDA3690", Offset = "0xDA2690", VA = "0x180DA3690", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FNMEKIPLEIA EPLIFMKLKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA42C20", Offset = "0xA41C20", VA = "0x180A42C20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GameObject LNIPGKDIFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60810D0", Offset = "0x60800D0", VA = "0x1860810D0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Transform DADOOFCELKA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF2B0", Offset = "0x9AE2B0", VA = "0x1809AF2B0", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Transform HMHDNAICJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF290", Offset = "0x9AE290", VA = "0x1809AF290", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Transform LIPBBHMOJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6089510", Offset = "0x6088510", VA = "0x186089510", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool LAMDPDEOKOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6084480", Offset = "0x6083480", VA = "0x186084480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private bool GAEPONODMGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6089170", Offset = "0x6088170", VA = "0x186089170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x607C320", Offset = "0x607B320", VA = "0x18607C320")]
	private void CNLMLBLKANL([In] LPMANJIFANN CEGGPAHNOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6082A70", Offset = "0x6081A70", VA = "0x186082A70")]
	private void JJDHEFLBIMA(LPMANJIFANN CEGGPAHNOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x607BE80", Offset = "0x607AE80", VA = "0x18607BE80")]
	private void CBDJNODKIFP(JFOBJNADNNE KEFBMNFMNLA, JFLLPCBBFAM BLHOOEAKCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6087A50", Offset = "0x6086A50", VA = "0x186087A50")]
	private void NDJAIKLHIIB([In] LPMANJIFANN NLJIDPFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6089F30", Offset = "0x6088F30", VA = "0x186089F30")]
	public NKEDALBPFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6088D60", Offset = "0x6087D60", VA = "0x186088D60", Slot = "11")]
	public void ONDHEGFMJIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x607B910", Offset = "0x607A910", VA = "0x18607B910", Slot = "12")]
	public void BJJIPCCOKPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6087930", Offset = "0x6086930", VA = "0x186087930", Slot = "13")]
	public void MBHOHGACNLE(bool NIEFMBNKLCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x607F850", Offset = "0x607E850", VA = "0x18607F850", Slot = "21")]
	public Transform EIODKGOGJPI(string CDIACKHGJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x60824B0", Offset = "0x60814B0", VA = "0x1860824B0", Slot = "22")]
	public Vector3? IAKNIMMLOGH(string CDIACKHGJCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6086890", Offset = "0x6085890", VA = "0x186086890", Slot = "6")]
	public void LMADKMBCLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6081E30", Offset = "0x6080E30", VA = "0x186081E30", Slot = "7")]
	public void HIEHAPCLHJC(float JFJGCIFIMLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x607ADD0", Offset = "0x6079DD0", VA = "0x18607ADD0")]
	private void BCFJDNLMLPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60855D0", Offset = "0x60845D0", VA = "0x1860855D0", Slot = "4")]
	public void LKKGLBAKCCG(BJOLIDHLPPI DIDCLMHLHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6083880", Offset = "0x6082880", VA = "0x186083880", Slot = "5")]
	public void KFKNPOCBCNN(ABIFGNOALND JLPJDGDOCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6081C90", Offset = "0x6080C90", VA = "0x186081C90", Slot = "10")]
	public void HBKMCMKPAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6088210", Offset = "0x6087210", VA = "0x186088210", Slot = "20")]
	public void NKOEKEHFDBG([Out] Vector3 KCLKPIPLEIF, [Out] Quaternion BCEMLJHJNAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x607C2A0", Offset = "0x607B2A0", VA = "0x18607C2A0", Slot = "23")]
	public void CMJBNOIEFND(float GBLMDMFHNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6089570", Offset = "0x6088570", VA = "0x186089570", Slot = "24")]
	public void PNGDAICDMHD(bool JINEFHKDIOP, bool DFFDKENBLKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6081D80", Offset = "0x6080D80", VA = "0x186081D80", Slot = "25")]
	public HandLogicOffsets HECLNHKHBOG()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x607C1E0", Offset = "0x607B1E0", VA = "0x18607C1E0", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets CJCLIHHBHLG()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6088150", Offset = "0x6087150", VA = "0x186088150")]
	private void NKKOHCAGNOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x607FB00", Offset = "0x607EB00", VA = "0x18607FB00")]
	private void FBAPLMCMDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6081B10", Offset = "0x6080B10", VA = "0x186081B10")]
	private void HAHMCOOLMDC(RigidbodyEx APHMPEPNIKB, bool KIHKHFOPMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x607FF00", Offset = "0x607EF00", VA = "0x18607FF00")]
	private void FCGJDOAIAAA(RigidbodyEx APHMPEPNIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6087A00", Offset = "0x6086A00", VA = "0x186087A00")]
	public Vector3 MCPOHPANEAG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x607B750", Offset = "0x607A750", VA = "0x18607B750")]
	private void BIOBNDGEHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x607A5D0", Offset = "0x60795D0", VA = "0x18607A5D0")]
	private float ABAGHHNPOGN([In] LPMANJIFANN NLJIDPFGNFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6085070", Offset = "0x6084070", VA = "0x186085070")]
	private int LFDBDNCBCAI([In] GCJKBCHIIEO GNAOGDMBEJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6083D00", Offset = "0x6082D00", VA = "0x186083D00")]
	private void KHGGHNBPDPA(LPMANJIFANN CEGGPAHNOCB, bool IHGDEJGFCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6082770", Offset = "0x6081770", VA = "0x186082770")]
	private static void IJNPCFENGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60844E0", Offset = "0x60834E0", VA = "0x1860844E0")]
	private static void LEPNLIGEKAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x607B7C0", Offset = "0x607A7C0", VA = "0x18607B7C0")]
	private float BJAOFDOFKED()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6083850", Offset = "0x6082850", VA = "0x186083850")]
	private static int KCIIONLENIJ(NKEDALBPFNF FKOPFOECIGH, NKEDALBPFNF DGKDEKELGHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6081170", Offset = "0x6080170", VA = "0x186081170")]
	private void GKGBNMMLLPB(LPMANJIFANN NLJIDPFGNFP, AvatarFullBodyConfiguration DJEDGNFIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x607EE70", Offset = "0x607DE70", VA = "0x18607EE70")]
	private void EBCOJPHONIF([In] LPMANJIFANN NLJIDPFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6084300", Offset = "0x6083300", VA = "0x186084300")]
	private void KKIIPIPCLAP([In] LPMANJIFANN NLJIDPFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xD657A0", Offset = "0xD647A0", VA = "0x180D657A0")]
	private void OFGBPFCJLAP(RigidbodyEx JHJEJJLFABP, Transform FJMIHGFDCIN, Transform PLEABGBMIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x607F7D0", Offset = "0x607E7D0", VA = "0x18607F7D0")]
	private float EDNFMIKIKON()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6083230", Offset = "0x6082230", VA = "0x186083230")]
	private void KCEHOINOKEJ([In] LPMANJIFANN NLJIDPFGNFP, [In] FBLPKFPMDHB JAFPFJJKCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x607EB20", Offset = "0x607DB20", VA = "0x18607EB20")]
	private void EALAPAIHILH(LPMANJIFANN NLJIDPFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60891F0", Offset = "0x60881F0", VA = "0x1860891F0")]
	private void OPPKKDOKHEN(NLHCAEFMLNK KANHHOCBLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x607AAE0", Offset = "0x6079AE0", VA = "0x18607AAE0")]
	private void AHMNMKNIMHK(float PFENALJFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x607F080", Offset = "0x607E080", VA = "0x18607F080")]
	private void EDHMDANJMJK([In] LPMANJIFANN NLJIDPFGNFP, FBLPKFPMDHB JAFPFJJKCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60885B0", Offset = "0x60875B0", VA = "0x1860885B0")]
	private Vector3 OGAKCCPJPBN([In] LPMANJIFANN NLJIDPFGNFP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6080C10", Offset = "0x607FC10", VA = "0x186080C10")]
	private float GCDACJPBCHA(float ALLGEGEOBOM, [In] LPMANJIFANN NLJIDPFGNFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6088130", Offset = "0x6087130", VA = "0x186088130")]
	private void NJKMBJBFMOH(NLHCAEFMLNK KANHHOCBLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6085150", Offset = "0x6084150", VA = "0x186085150")]
	private void LFFFFBCFDFC(float ALLGEGEOBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6081EA0", Offset = "0x6080EA0", VA = "0x186081EA0")]
	private void HJHKOJMHNNG([In] LPMANJIFANN NLJIDPFGNFP, FBLPKFPMDHB JAFPFJJKCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x607AE20", Offset = "0x6079E20", VA = "0x18607AE20")]
	private float BGCIMKIPDAJ([In] LPMANJIFANN CEGGPAHNOCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x607B230", Offset = "0x607A230", VA = "0x18607B230")]
	private void BGGFJNECOOJ(LPMANJIFANN NLJIDPFGNFP, FBLPKFPMDHB JAFPFJJKCPJ, Vector3 IMJDNCAEAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x607BCD0", Offset = "0x607ACD0", VA = "0x18607BCD0")]
	private static void CBBLMOMBKIF(Transform NJKBLELAEGN, Quaternion GOAHENPPMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6089210", Offset = "0x6088210", VA = "0x186089210")]
	private void PEBKLIADJIG([In] LPMANJIFANN BGHPMOMJNCK, [In] GCJKBCHIIEO GNAOGDMBEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6082AB0", Offset = "0x6081AB0", VA = "0x186082AB0")]
	private void JMAEGNJDCNM([In] LPMANJIFANN BGHPMOMJNCK, [In] GCJKBCHIIEO GNAOGDMBEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6080160", Offset = "0x607F160", VA = "0x186080160")]
	private void FJBNDNOEACJ([In] LPMANJIFANN NLJIDPFGNFP, [In] AvatarFullBodyConfiguration DJEDGNFIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x607A840", Offset = "0x6079840", VA = "0x18607A840")]
	public void AELFKPINLPD([In] LPMANJIFANN NLJIDPFGNFP, [In] AvatarFullBodyConfiguration DJEDGNFIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x607D810", Offset = "0x607C810", VA = "0x18607D810", Slot = "31")]
	protected virtual void DBJEIAIEFGK([In] LPMANJIFANN NLJIDPFGNFP, [In] AvatarFullBodyConfiguration DJEDGNFIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60852A0", Offset = "0x60842A0", VA = "0x1860852A0")]
	private void LHGPKBAPCGB([In] LPMANJIFANN NLJIDPFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x607E6C0", Offset = "0x607D6C0", VA = "0x18607E6C0")]
	private void DPPHDOCJMBD(float DPPFCNNHOLN, [In] LPMANJIFANN CEGGPAHNOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60807C0", Offset = "0x607F7C0", VA = "0x1860807C0")]
	private float FOBMFBCEEBA([In] AvatarFullBodyConfiguration DJEDGNFIGON)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6087DA0", Offset = "0x6086DA0", VA = "0x186087DA0")]
	private void NIEHBGDOOMF([In] LPMANJIFANN CEGGPAHNOCB, [In] AvatarFullBodyConfiguration DJEDGNFIGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6087570", Offset = "0x6086570", VA = "0x186087570")]
	private void LOJGHNBAJFB([In] LPMANJIFANN CEGGPAHNOCB, float HLJBNOBJMCG, float OLMOPGFCIKE, Vector3 NFJEFKJHOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x607DED0", Offset = "0x607CED0", VA = "0x18607DED0")]
	private void DOKJIDGBEGK(LPMANJIFANN CEGGPAHNOCB, AvatarFullBodyConfiguration DJEDGNFIGON)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum AGKMIDNKGGP
		{
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private AGKMIDNKGGP handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x6077600", Offset = "0x6076600", VA = "0x186077600")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60775C0", Offset = "0x60765C0", VA = "0x1860775C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6076F90", Offset = "0x6075F90", VA = "0x186076F90")]
		private void JIPLDMNIJNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x11694F0", Offset = "0x11684F0", VA = "0x1811694F0", Slot = "4")]
		public void SetEnabled(bool PNLCCPNIGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6077630", Offset = "0x6076630", VA = "0x186077630")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class AvatarKneeBendTargetController : MonoBehaviour, MEMCONAKEHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		[JMOFFDBDEHI(HLBGFFAONPF.Self, false, false, false)]
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
		private Vector3 DNKCCJAMEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 IDGCMLIENCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 ECIAGPOKANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Matrix4x4 OLGKKCMLEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private bool JJKCNAPNFBK;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6077AC0", Offset = "0x6076AC0", VA = "0x186077AC0", Slot = "4")]
		public void UpdateController(float HBFOIDKFIJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5F9AFB0", Offset = "0x5F99FB0", VA = "0x185F9AFB0", Slot = "6")]
		public void SetEnabled(bool CFJDHAGGAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6077660", Offset = "0x6076660", VA = "0x186077660")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6078180", Offset = "0x6077180", VA = "0x186078180")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Preserve]
internal class CJNFINBHJCK : EEHNOPJICNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Dictionary<string, KJNONANIEAC> GGMNNNLNFAH;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool OAJDKFKFHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D6100", Offset = "0x7D5100", VA = "0x1807D6100", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x60787E0", Offset = "0x60777E0", VA = "0x1860787E0")]
	[KEBGMDILACL(LNECJMDANHH.Root, JMIJNHPDBML.None)]
	private static void CBONKAJJAMN(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6078A70", Offset = "0x6077A70", VA = "0x186078A70", Slot = "4")]
	public KJNONANIEAC MDIOHJMEIFG(string GOPFFKNOFAP, AvatarSystemConfiguration KEGMEDJFHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x60788E0", Offset = "0x60778E0", VA = "0x1860788E0", Slot = "5")]
	public void HCOECANADOH(string GOPFFKNOFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6078C30", Offset = "0x6077C30", VA = "0x186078C30")]
	public CJNFINBHJCK()
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
		public class OOGBBGBNCEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private Dictionary<string, Transform> MEMCBMFBPBJ;

			[Cpp2IlInjected.Token(Token = "0x17000022")]
			public bool EKAOBJEABNJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000B2")]
				[Cpp2IlInjected.Address(RVA = "0x608A380", Offset = "0x6089380", VA = "0x18608A380")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x608A3C0", Offset = "0x60893C0", VA = "0x18608A3C0")]
			public void JFMLJEFIEDD(VRIK ILAMHKADHIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280")]
			public void PLDBMKHNKDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x608A330", Offset = "0x6089330", VA = "0x18608A330")]
			public void FPNJJPKFGNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x608A4F0", Offset = "0x60894F0", VA = "0x18608A4F0")]
			public OOGBBGBNCEC()
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
		[HEAANNMEKMO(HLBGFFAONPF.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		[JMOFFDBDEHI(HLBGFFAONPF.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private readonly OOGBBGBNCEC COBIAMBAPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private AEFGNMCBDFJ NEFDNOMFEEJ;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6078190", Offset = "0x6077190", VA = "0x186078190")]
		private void DPGLELIALOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6078450", Offset = "0x6077450", VA = "0x186078450")]
		private bool EKBCLMHALIB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x60784A0", Offset = "0x60774A0", VA = "0x1860784A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6078510", Offset = "0x6077510", VA = "0x186078510")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x60784B0", Offset = "0x60774B0", VA = "0x1860784B0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6078700", Offset = "0x6077700", VA = "0x186078700")]
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
		[Cpp2IlInjected.Address(RVA = "0x607A4A0", Offset = "0x60794A0", VA = "0x18607A4A0", Slot = "4")]
		public override void OnStateEnter(Animator HBCGJOCCGOC, AnimatorStateInfo HHIIDBMMOOB, int ECAJBKMNHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x607A5C0", Offset = "0x60795C0", VA = "0x18607A5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60732B0", Offset = "0x60722B0", VA = "0x1860732B0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
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
