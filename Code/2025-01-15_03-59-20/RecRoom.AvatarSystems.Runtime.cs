using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.Avatars;
using RecRoom.Avatars.Data;
using RecRoom.Avatars.Face;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using RootMotion.FinalIK;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EC6030", Offset = "0x6EC5430", VA = "0x186EC6030")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F1670", Offset = "0x8F0A70", VA = "0x1808F1670")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F16B0", Offset = "0x8F0AB0", VA = "0x1808F16B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EC73F0", Offset = "0x6EC67F0", VA = "0x186EC73F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GFHMGJFENGN]
internal class EHOEPIFJNJA : OLOBDMGKPCC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LGBLAABNADD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public EHOEPIFJNJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public EOPKGKNJKFM avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly KHAFACKHEFA ONGGGOHCCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GJFPCKEKDOI BPEDEJMJKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EPLHPGALBJJ MJJCHDLFAEF;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2E60", Offset = "0x6EC2260", VA = "0x186EC2E60")]
	[UsedImplicitly]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void DMLMOPPEGDC(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3C10", Offset = "0x6EC3010", VA = "0x186EC3C10")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EHOEPIFJNJA([CNGCCDLPGOD(null)] KHAFACKHEFA ONGGGOHCCCK, [CNGCCDLPGOD(null)] GJFPCKEKDOI BPEDEJMJKEB, [CNGCCDLPGOD(null)] EPLHPGALBJJ MJJCHDLFAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2ED0", Offset = "0x6EC22D0", VA = "0x186EC2ED0", Slot = "5")]
	public KKGOEONLCJM GPHAMGJGKMP(EOPKGKNJKFM AAIBGMJAOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EC22F0", Offset = "0x6EC16F0", VA = "0x186EC22F0", Slot = "4")]
	public KKGOEONLCJM BPKHJLHHGCJ(EOPKGKNJKFM AAIBGMJAOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EC2D50", Offset = "0x6EC2150", VA = "0x186EC2D50", Slot = "6")]
	public OJGBLAGOBMN CBCIEHDBBBN(KKGOEONLCJM JGCOLLOOLHL, int PIIALHEOFHP, string? LJAGHAHCFHJ, string? CAMGILFLAKE, HLDJPDEDBEH EOIJHHALHMM, List<ODGELMEONNM>? LDCECHPNDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EC39E0", Offset = "0x6EC2DE0", VA = "0x186EC39E0", Slot = "7")]
	public bool MJLIJFIHJKF(HOEIGNDDKBE CDDCFBHDFOE, [Out] KKGOEONLCJM? MHDNNLLPNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3870", Offset = "0x6EC2C70", VA = "0x186EC3870", Slot = "8")]
	public bool IOGCLEGJFPM(OJGBLAGOBMN KGNFHOGOBAC, [Out] KKGOEONLCJM? MHDNNLLPNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3950", Offset = "0x6EC2D50", VA = "0x186EC3950", Slot = "9")]
	public bool KPHKAOCFAAK(OJGBLAGOBMN KGNFHOGOBAC, [Out] LGFIACEHFON? CDDCFBHDFOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB9E70", Offset = "0x2EB9270", VA = "0x182EB9E70")]
	private bool ADCHEJKAEDP<TInput, TOutput>(TInput AOOGNGKJLKL, GNNMEBNLMNC<TInput, TOutput> BCKADKPHBCA, [Out] TOutput? CEDDFJCBLGM) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3A70", Offset = "0x6EC2E70", VA = "0x186EC3A70")]
	[CompilerGenerated]
	private PLPKIICCMFB MOCPCAMGDGM(FaceFeatureType FAAOPHFGCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EC3690", Offset = "0x6EC2A90", VA = "0x186EC3690")]
	[CompilerGenerated]
	private PLPKIICCMFB IKEMMHCAIIH(FaceFeatureType FAAOPHFGCCJ, LGBLAABNADD P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[GFHMGJFENGN]
internal class OLPOPGECOMO : KHAFACKHEFA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void LMNAHHAHHMH<in TData>(TData MHDNNLLPNCF, IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly EPLHPGALBJJ MJJCHDLFAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CNEHIJMIJDK EDNCHDNMNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly LMNAHHAHHMH<KKGOEONLCJM>?[] ONGGGOHCCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly LMNAHHAHHMH<LGFIACEHFON>?[] DKFFFIAANAB;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6110", Offset = "0x6EC5510", VA = "0x186EC6110")]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	[UsedImplicitly]
	internal static void DMLMOPPEGDC(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EC7040", Offset = "0x6EC6440", VA = "0x186EC7040")]
	[RecRoom.NoEngine.Common.Preserve]
	internal OLPOPGECOMO([CNGCCDLPGOD(null)] EPLHPGALBJJ MJJCHDLFAEF, [CNGCCDLPGOD(null)] CNEHIJMIJDK EDNCHDNMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6BB0", Offset = "0x6EC5FB0", VA = "0x186EC6BB0", Slot = "4")]
	public bool MFCHECMNPCI(KKGOEONLCJM MHDNNLLPNCF, IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6CB0", Offset = "0x6EC60B0", VA = "0x186EC6CB0", Slot = "5")]
	public bool MFCHECMNPCI(LGFIACEHFON CDDCFBHDFOE, IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6180", Offset = "0x6EC5580", VA = "0x186EC6180")]
	private void JEJOOHMJGKL(KKGOEONLCJM MHDNNLLPNCF, IReadOnlyList<ODGELMEONNM>? PGHMIFOEHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6EC6E10", Offset = "0x6EC6210", VA = "0x186EC6E10")]
	private void OJJKNHCCAAK(KKGOEONLCJM MHDNNLLPNCF, IReadOnlyList<ODGELMEONNM>? PGHMIFOEHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EC60B0", Offset = "0x6EC54B0", VA = "0x186EC60B0")]
	private void AAMDCHNFIGE(KKGOEONLCJM MHDNNLLPNCF, IReadOnlyList<ODGELMEONNM>? PGHMIFOEHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EC60E0", Offset = "0x6EC54E0", VA = "0x186EC60E0")]
	private void DJIEIGKIBCB(KKGOEONLCJM MHDNNLLPNCF, IReadOnlyList<ODGELMEONNM>? PGHMIFOEHOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KHAFACKHEFA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MFCHECMNPCI(KKGOEONLCJM MHDNNLLPNCF, IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MFCHECMNPCI(LGFIACEHFON CDDCFBHDFOE, IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA);
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AnimationPoseSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Tooltip("Type of pose")]
		public ABBHCCIFIPP AnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Tooltip("Blend in time")]
		public float BlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Tooltip("How much of the head movement is applied to the hand movement")]
		public float HeadMovementWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Tooltip("Weight between IK hand and Animated hand for position")]
		public float HandAnimationPosWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Tooltip("Weight between IK hand and Animated hand for rotation")]
		public float HandAnimationRotWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Tooltip("Weight between shoulders facing forward and alignment with hands")]
		public float ShoulderFollowWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("How much the aim follows direction of feet vs head (0 = head, 1 = feet)")]
		public float FeetFollowWeight;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1370", Offset = "0x6EC0770", VA = "0x186EC1370")]
		public void ABLHJENOBPO(AnimationPoseSetting BMKPAKCEMFK, float CFIEIHEIEOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC14A0", Offset = "0x6EC08A0", VA = "0x186EC14A0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1500", Offset = "0x6EC0900", VA = "0x186EC1500")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EC14C0", Offset = "0x6EC08C0", VA = "0x186EC14C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1530", Offset = "0x6EC0930", VA = "0x186EC1530")]
		private void PBHCNLCOFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6E42E20", Offset = "0x6E42220", VA = "0x186E42E20", Slot = "4")]
		public void SetEnabled(bool JCDOMELOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1DC0", Offset = "0x6EC11C0", VA = "0x186EC1DC0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		[Header("Turning")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x381")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Default angle of the foot bone as seen in idle")]
		public float FootRestAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1E00", Offset = "0x6EC1200", VA = "0x186EC1E00")]
		public AnimationPoseSetting AAKEKDEMOEN(ABBHCCIFIPP BNBABACAAFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1E30", Offset = "0x6EC1230", VA = "0x186EC1E30")]
		public void LKOIGPCFEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6EC1E70", Offset = "0x6EC1270", VA = "0x186EC1E70")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EC3D90", Offset = "0x6EC3190", VA = "0x186EC3D90")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class APIFALGIOJE : NIHAEOHMDBO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class JKKBFJMHJJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private Vector3 JGJBOAPBCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private Quaternion PFIAMAJCMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private Vector3 MGOJAFEJAKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private Transform GGBONAIAADC;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector3 AIBMPPGFCLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x18E9F60", Offset = "0x18E9360", VA = "0x1818E9F60")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x18E9F80", Offset = "0x18E9380", VA = "0x1818E9F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Quaternion JECICMNMDNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xEFF650", Offset = "0xEFEA50", VA = "0x180EFF650")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xEFF700", Offset = "0xEFEB00", VA = "0x180EFF700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public float LBMFIBKCLII
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xC80030", Offset = "0xC7F430", VA = "0x180C80030")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x1260480", Offset = "0x125F880", VA = "0x181260480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool JPLMFHBDBGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DC0", Offset = "0x8D01C0", VA = "0x1808D0DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DE0", Offset = "0x8D01E0", VA = "0x1808D0DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IAPCOAPOBEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x8D0C90", Offset = "0x8D0090", VA = "0x1808D0C90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8D0C80", Offset = "0x8D0080", VA = "0x1808D0C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool HNBCPBLKDFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x8D0D90", Offset = "0x8D0190", VA = "0x1808D0D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8D0CB0", Offset = "0x8D00B0", VA = "0x1808D0CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public float PGDIOEBICIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xC80050", Offset = "0xC7F450", VA = "0x180C80050")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x2191000", Offset = "0x2190400", VA = "0x182191000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4380", Offset = "0x6EC3780", VA = "0x186EC4380")]
		public void EEFJAIABOCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4390", Offset = "0x6EC3790", VA = "0x186EC4390")]
		public void FHCHNLLHCMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4150", Offset = "0x6EC3550", VA = "0x186EC4150")]
		public float DGPINLCMPPO(Vector3 DDBPOINOBCL, Quaternion EJPKLGPBHMN, [In] FootSettings FFLIABKFJNB, float GMGAMBJDHGN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6EC43A0", Offset = "0x6EC37A0", VA = "0x186EC43A0")]
		public void FJEHIDHKGEC(Vector3 KGFKEADBPDM, Quaternion ADNGHPJKCHM, Transform FIEODFBMMJF, float CGDDLNIFDDO, bool POMHCKFIKCC, bool AFNKGICMDAJ, float MFGGDAJEAND, float BGJPJIGCJIL, Transform NIMLNKDMKHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6EC3DD0", Offset = "0x6EC31D0", VA = "0x186EC3DD0")]
		public void AMOBBHLCFID(Transform MPKMBGOHIFE, Transform NIMLNKDMKHI, bool HOEFLJCCNFP, bool HAIFHLNJNMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4A70", Offset = "0x6EC3E70", VA = "0x186EC4A70")]
		private void NMLCMFJJHMH(Transform NIMLNKDMKHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4000", Offset = "0x6EC3400", VA = "0x186EC4000")]
		public void CGGCGDBENPG(Transform NIMLNKDMKHI, AvatarFullBodyConfiguration JAGODFHKNAI, Vector3 IFOECFKONKI, float KEIDDFFGJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4360", Offset = "0x6EC3760", VA = "0x186EC4360")]
		public void DHLAECOOFIO(float BGJPJIGCJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4B70", Offset = "0x6EC3F70", VA = "0x186EC4B70")]
		public JKKBFJMHJJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class LONFJMMPMMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private float KCNLIBHCAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private bool OOHMKGKIEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public AnimationPoseSetting CNCFKEJPCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private float GFJJGFEOMKC;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5AF0", Offset = "0x6EC4EF0", VA = "0x186EC5AF0")]
		public void MJDPPJNNEFN(IKSolverVR.Arm LAABIBJOALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5290", Offset = "0x6EC4690", VA = "0x186EC5290")]
		public void FHKFIFHLPME(IKSolverVR.Arm LAABIBJOALF, bool GBEPEFGNOFB, bool MCNBIGGBOFE, bool OOHMKGKIEFJ, AvatarFullBodyConfiguration JAGODFHKNAI, float LDKAJOKKAHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5360", Offset = "0x6EC4760", VA = "0x186EC5360")]
		private void IEPMIHBJBJI(IKSolverVR.Arm LAABIBJOALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6EC53A0", Offset = "0x6EC47A0", VA = "0x186EC53A0")]
		public void JHDJHKDHFOB(Transform FBDOIBEDPPF, Transform DCFKKECEBMI, Vector3 AFAPOGKIENB, Quaternion IGPHGIGADAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5B20", Offset = "0x6EC4F20", VA = "0x186EC5B20")]
		private (Vector3, Quaternion) NOBKCNALEGK(BHOLPDLEKNJ AJDIKDINIEI, Quaternion BDKPLANNGMD, Vector3 LCLPPAHNLDM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5140", Offset = "0x6EC4540", VA = "0x186EC5140")]
		public void DIKIGOPBHPA(BHOLPDLEKNJ AJDIKDINIEI, Transform MGPMAFDHMLC, Quaternion BDKPLANNGMD, Vector3 LCLPPAHNLDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5510", Offset = "0x6EC4910", VA = "0x186EC5510")]
		public void LGDPIOCBBHF(BHOLPDLEKNJ AJDIKDINIEI, Transform BHNDMEMGGNE, Quaternion BDKPLANNGMD, Vector3 LCLPPAHNLDM, [In] AvatarFullBodyConfiguration JAGODFHKNAI, [In] MGKDDJPECNM MPLALBADMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4B80", Offset = "0x6EC3F80", VA = "0x186EC4B80")]
		public void BCGMJDEHFOM(ABBHCCIFIPP MMAKEGMFGOA, AvatarFullBodyConfiguration JAGODFHKNAI, MGKDDJPECNM MPLALBADMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4CC0", Offset = "0x6EC40C0", VA = "0x186EC4CC0")]
		public void CBCBJKBAHHP(Transform MGPMAFDHMLC, Transform DCFKKECEBMI, Vector3 DAAINLHLKIJ, float LCFCKEALJNF, Quaternion JFANJGNLMCF, Vector3 APFGGNKNIPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6EC5FB0", Offset = "0x6EC53B0", VA = "0x186EC5FB0")]
		public LONFJMMPMMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private enum ALBPFMOKDEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct EELBNLMJMEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct JIOBLJEACMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly int PLCEPALAKGP;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly int MKBHADOKIDN;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly int HBKONFFCIMM;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly int OEFEGHCPMDA;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly int JCENCCCPLDN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly int JBJNGKNLODJ;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly int FNACDLLHAJI;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly int MGBPAMLALHE;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly int GOCBGFCCMAF;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly int OKKEGCHFJEC;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly int CGHPLPKOGDP;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly int OFBNOMGDOJM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static readonly int FMPLIDICIGA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly int GFKKALBEJKF;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly int HELKMJCGKKN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly int HGGOKGNCIIC;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly int CIPDEPGBDCB;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private static readonly int KNIDKKDOCEP;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly int IAGALPCKJDE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly int JGFOMPPJJLB;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly int HJACDICCLBN;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static readonly int PDJHFDACOCD;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly int NDLOECJHOGF;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly int HLANKCIFAAN;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly int IKHBIPIELBD;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static readonly int GABMOOINEBH;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly int HIJAJGAFAKK;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly int FMLBNJDNPBM;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static readonly int LEDNNPDLJGN;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly int IDJNPBELMCM;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private static readonly int POPCMGKPIMK;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private static readonly Vector3 IDFFFGBBKBA;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static readonly int JHPLJLOMILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool BHCBHIICLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool PAIIFANHOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool GMEJKFCNJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool GJKFANIGDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private bool FEPLLCFIAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private bool MPBNDCPPEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Vector3 PFEMLHEGKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private string BJOFOLMCOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private DHLCOBNHHGL? BEGHDNGILKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private CLKOAINDMBH? MLMECICCFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private CPNADMDACOD PJKDCAGAOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private LHMDEBIIJAK CNNEGJCNIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private BHOLPDLEKNJ BKCIOFKLNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private BHOLPDLEKNJ IJDMCEGKIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private bool KCGAKLLHDNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool FOBOFGGKMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly EFHNBFLDLCB HDOBHBPELCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly EAGKIOFAINI BKHFEEBKFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int MEJJACKKEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private float OOCMJDDCJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private GameObject DENDFEHAMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Transform BBBJMANNPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Transform IFPOKOOLNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Transform GAPPJPHEOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Transform ECIEJMMPBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private float LCPCDMNOLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float FGAEOFOMLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Vector3 EOPDHHEFNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Quaternion IIAEJJCPAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Transform MHMBKBNHMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Transform PJKHENPBJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Transform BFGLLNIOBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private APPOFHHCCIE CLCIHFPDHNL;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly ProfilerMarker KBGAJJAJKBF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly ProfilerMarker IFHGMMEAEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private ProfilerMarker JHDEGOMJGJO;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly ProfilerMarker KOFFMDIKHDN;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly ProfilerMarker MJBILANLOLM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly ProfilerMarker CEENAGHKADA;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly List<APIFALGIOJE> NPOJONLFKHM;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static int HCKMOMBDGGH;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> ILNGNCAEOEN;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static int FEDJGIIGILE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static int ABIGFEBECEK;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static int ICANKECJEEE;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static int AOEGJJJIBGL;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static float NLJJJPPGCPC;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static int KAMPDEHHKCI;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static float BECIIIMFIOB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static float OHBLGPDKBCH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static float AOIPGAGHGCB;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static float CFFLNNGNKDE;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static MDLBOHBOCFI NJFCKNBLGNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private float CDDGKFIJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool CMNEOCCLJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float CLKMFPPPBAE;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int PGOMFIIFJJM;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int CAANNAHGOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private JKKBFJMHJJK IPFOHFECCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private JKKBFJMHJJK NODLKKPJICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private float LKKHNILPNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Vector3 EIPFFEELGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Vector3 FGGPCCMMJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private bool DBLOBKHHBDI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly Quaternion OGFHINFALPL;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly Quaternion CMMFJHFBMCO;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly Vector3 OAKJGAPLPEB;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly Vector3 ICBLAEBMEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private float EABDLIMGACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private float EMOBPNPPLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private LONFJMMPMMH ODPFCBPFHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private LONFJMMPMMH GMBJNPEBKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private LEJFBOIEAEG JJDAJLEFPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private JJBENAGIKAE OGFPGFLLACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly KGNHNJMDLLN PFOMPPHLNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private float PJAOPHNHCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private float GKECBIJFNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly JJBENAGIKAE CGBOADOGGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Vector3 FHNIKJMJLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Vector3 AAAPLNGODHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float CBAICLEBJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float GNLKLJPBLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly JJBENAGIKAE AHBNPMHHKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly LEJFBOIEAEG PIOJHDABPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly JJBENAGIKAE PPNNHILELAL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MIPKPFFHABJ JHPNLAOHKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public MIPKPFFHABJ LJNCFNJJOLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AvatarConfiguration HNBHDFLFLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFE90", Offset = "0x6EAF290", VA = "0x186EAFE90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public EOPKGKNJKFM FLBOGODJCKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EBFBB0", Offset = "0x6EBEFB0", VA = "0x186EBFBB0", Slot = "23")]
		get
		{
			return default(EOPKGKNJKFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarFullBodyConfiguration LNNCNDHJPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6EBECB0", Offset = "0x6EBE0B0", VA = "0x186EBECB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Transform PBJPALIDEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EB1DE0", Offset = "0x6EB11E0", VA = "0x186EB1DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform KIOMKNAFEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE960", Offset = "0x6EBDD60", VA = "0x186EBE960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private SkinnedMeshRenderer IEJCODAIMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6EB44C0", Offset = "0x6EB38C0", VA = "0x186EB44C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Renderer[] NOFOPEMCNII
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EB43C0", Offset = "0x6EB37C0", VA = "0x186EB43C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private GameObject[] AFFBFAAGMLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EBF5B0", Offset = "0x6EBE9B0", VA = "0x186EBF5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Animator NIBJBICCKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9EB0", Offset = "0x6EA92B0", VA = "0x186EA9EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private VRIK LOLEDILKPHH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6EBBEB0", Offset = "0x6EBB2B0", VA = "0x186EBBEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private POJABNNNJLM LIGMJCALGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6EACE60", Offset = "0x6EAC260", VA = "0x186EACE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private POJABNNNJLM MKAHEJIEJFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6EBFAB0", Offset = "0x6EBEEB0", VA = "0x186EBFAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private POJABNNNJLM KIPCDJBCJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8630", Offset = "0x6EA7A30", VA = "0x186EA8630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private POJABNNNJLM OJIKGKAJDIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFD90", Offset = "0x6EAF190", VA = "0x186EAFD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private POJABNNNJLM HGFDEMIEHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE860", Offset = "0x6EBDC60", VA = "0x186EBE860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private POJABNNNJLM FAMJKHJDBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EA65B0", Offset = "0x6EA59B0", VA = "0x186EA65B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private POJABNNNJLM EDHAGJCMFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6640", Offset = "0x6EB5A40", VA = "0x186EB6640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private POJABNNNJLM LBJNCAOODCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6EBF340", Offset = "0x6EBE740", VA = "0x186EBF340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CLKOAINDMBH MEBNKFNINEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6EAA610", Offset = "0x6EA9A10", VA = "0x186EAA610", Slot = "15")]
		get
		{
			return default(CLKOAINDMBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BIPIJKDNBKE LAKGDODDMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9EBAA0", Offset = "0x9EAEA0", VA = "0x1809EBAA0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public OOOHMBDIILN BPDFLHFCCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9EB9D0", Offset = "0x9EADD0", VA = "0x1809EB9D0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IGIKALHDICH KKGGLHKOHII
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9EBAC0", Offset = "0x9EAEC0", VA = "0x1809EBAC0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IGIKALHDICH NNNCHJPKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x180C1E0", Offset = "0x180B5E0", VA = "0x18180C1E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string PDOKGKDEEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private Transform KMAGDDDOMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFF90", Offset = "0x6EAF390", VA = "0x186EAFF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private Transform GKOIBKNMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6EB72E0", Offset = "0x6EB66E0", VA = "0x186EB72E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform ENEIIBMLPKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6EB1EE0", Offset = "0x6EB12E0", VA = "0x186EB1EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform KGNBNOIDLBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6EB35A0", Offset = "0x6EB29A0", VA = "0x186EB35A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform BHNMNAFMJHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6EAD7A0", Offset = "0x6EACBA0", VA = "0x186EAD7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform BDMNDNMCJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6600", Offset = "0x6EB5A00", VA = "0x186EB6600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform FOICIODPNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6EBF6B0", Offset = "0x6EBEAB0", VA = "0x186EBF6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private Transform LIPHLNKGECC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC690", Offset = "0x6EBBA90", VA = "0x186EBC690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool LPIKOIEPDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9D00", Offset = "0x6EA9100", VA = "0x186EA9D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool AONLFMHLPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6EA9D00", Offset = "0x6EA9100", VA = "0x186EA9D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform KMHIBOPNFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6EC03C0", Offset = "0x6EBF7C0", VA = "0x186EC03C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject MCCIFMIMANN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6560", Offset = "0x6EB5960", VA = "0x186EB6560", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets AOBKHKGALPD
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC000", Offset = "0x6EBB400", VA = "0x186EBC000", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform ANFHMGBECPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xEDF720", Offset = "0xEDEB20", VA = "0x180EDF720", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform HPFJJMAHKJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1928370", Offset = "0x1927770", VA = "0x181928370", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform EMPGKBIHOFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1928610", Offset = "0x1927A10", VA = "0x181928610", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform LJOOOHIMOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1928620", Offset = "0x1927A20", VA = "0x181928620", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 IALMDPIHKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EA8AB0", Offset = "0x6EA7EB0", VA = "0x186EA8AB0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float CIHGFADEMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EA7390", Offset = "0x6EA6790", VA = "0x186EA7390", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform PBAHFEPOBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EBFA50", Offset = "0x6EBEE50", VA = "0x186EBFA50", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform HAIKOADJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1928360", Offset = "0x1927760", VA = "0x181928360", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform MOBAHGDLIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1C414B0", Offset = "0x1C408B0", VA = "0x181C414B0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform PMPOFFHFOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1C414A0", Offset = "0x1C408A0", VA = "0x181C414A0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool GEJNOAMJJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6EAAED0", Offset = "0x6EAA2D0", VA = "0x186EAAED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool FOJOAMHKGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6EB1A30", Offset = "0x6EB0E30", VA = "0x186EB1A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool MGNGFKEKMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB0B0", Offset = "0x6EAA4B0", VA = "0x186EAB0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC760", Offset = "0x6EBBB60", VA = "0x186EBC760")]
	private void NHAPCFJDEJO([In] MGKDDJPECNM OIDOLOHOOLI, [In] AvatarFullBodyConfiguration JAGODFHKNAI, bool BHAJHNHGGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7C20", Offset = "0x6EB7020", VA = "0x186EB7C20")]
	private float KNJNFLIKACG([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0860", Offset = "0x6EAFC60", VA = "0x186EB0860")]
	private float GBBEBCDOLED([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC080", Offset = "0x6EBB480", VA = "0x186EBC080")]
	private void NAFMMIFAFNO(MGKDDJPECNM OIDOLOHOOLI, AvatarFullBodyConfiguration JAGODFHKNAI, bool BHAJHNHGGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0200", Offset = "0x6EBF600", VA = "0x186EC0200")]
	private void PKMACHBJLLL([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB49F0", Offset = "0x6EB3DF0", VA = "0x186EB49F0")]
	private void JACMHBFLKFK([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EC0EC0", Offset = "0x6EC02C0", VA = "0x186EC0EC0")]
	public APIFALGIOJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9FB0", Offset = "0x6EA93B0", VA = "0x186EA9FB0", Slot = "12")]
	public void DEHJKKPLOIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE2F0", Offset = "0x6EBD6F0", VA = "0x186EBE2F0", Slot = "13")]
	public void NJGBPCCPIJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA540", Offset = "0x6EA9940", VA = "0x186EAA540", Slot = "14")]
	public void DFDEBBJKHMC(bool BNHDKLDJLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7320", Offset = "0x6EB6720", VA = "0x186EB7320", Slot = "25")]
	public Transform KHGDCOFHBCE(string JLKBGEHOOHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE380", Offset = "0x6EAD780", VA = "0x186EAE380", Slot = "26")]
	public Vector3? FAHOOEAFKJH(string JLKBGEHOOHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EACF60", Offset = "0x6EAC360", VA = "0x186EACF60", Slot = "7")]
	public void EJDFNGGBNKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6BA0", Offset = "0x6EA5FA0", VA = "0x186EA6BA0")]
	private void AJKNCNMCDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF6F0", Offset = "0x6EBEAF0", VA = "0x186EBF6F0")]
	private Vector3 PDLEBHOFADF([In] MGKDDJPECNM MPLALBADMNL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0EA0", Offset = "0x6EB02A0", VA = "0x186EB0EA0", Slot = "6")]
	public void GPADDAINIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB52C0", Offset = "0x6EB46C0", VA = "0x186EB52C0", Slot = "8")]
	public void JCMGIOEJPMM(float OBEEEEBBDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8A60", Offset = "0x6EA7E60", VA = "0x186EA8A60")]
	private void BPBMMIGBHOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7CB0", Offset = "0x6EB70B0", VA = "0x186EB7CB0", Slot = "4")]
	public void KNOEHBHCDMI(string LOHELPMMKLH, DHLCOBNHHGL KBJHAFAHANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBA20", Offset = "0x6EBAE20", VA = "0x186EBBA20", Slot = "5")]
	public void MHDLJPAICEI(CLKOAINDMBH ECIDMJFABIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6EA73E0", Offset = "0x6EA67E0", VA = "0x186EA73E0", Slot = "11")]
	public void APCNPDCCMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6EB61C0", Offset = "0x6EB55C0", VA = "0x186EB61C0", Slot = "24")]
	public void JKCPAANOCNG([Out] Vector3 GKFILBNPGKK, [Out] Quaternion JFANJGNLMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6EBEC80", Offset = "0x6EBE080", VA = "0x186EBEC80")]
	private void ODKEBFMAKJI([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6550", Offset = "0x6EB5950", VA = "0x186EB6550", Slot = "27")]
	public void JKEODDHFPFL(float NKPLEGFMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6EA74D0", Offset = "0x6EA68D0", VA = "0x186EA74D0", Slot = "28")]
	public void APLCBAGCIGE(float LFJKJIOCEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE590", Offset = "0x6EAD990", VA = "0x186EAE590", Slot = "44")]
	public void FBLEEJACCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBFB0", Offset = "0x6EBB3B0", VA = "0x186EBBFB0", Slot = "29")]
	public void MLIMHAMDDOK(bool PNIGIABPKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB130", Offset = "0x6EAA530", VA = "0x186EAB130", Slot = "30")]
	public HandLogicOffsets DMJBMLHHAAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1F10", Offset = "0x6EB1310", VA = "0x186EB1F10", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets HJDMNJNOALH()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9D50", Offset = "0x6EA9150", VA = "0x186EA9D50")]
	private void DBOALHLFKKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EB45C0", Offset = "0x6EB39C0", VA = "0x186EB45C0")]
	private void IPOGOABOIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD8D0", Offset = "0x6EACCD0", VA = "0x186EAD8D0")]
	private void EMFOPFJNMOH(JBMMKMCLEMD HOJNCIGECNO, bool JAMKBEGAKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0B60", Offset = "0x6EAFF60", VA = "0x186EB0B60")]
	private void GKCPIGMFDBK(JBMMKMCLEMD HOJNCIGECNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA830", Offset = "0x6EB9C30", VA = "0x186EBA830")]
	public Vector3 LMKNLKBDDIE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB32E0", Offset = "0x6EB26E0", VA = "0x186EB32E0")]
	private void IIFMOJKPHHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBA00", Offset = "0x6EBAE00", VA = "0x186EBBA00")]
	private void MEHLCAJFIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9450", Offset = "0x6EA8850", VA = "0x186EA9450")]
	private void COBPHPIIFAE(MGKDDJPECNM OIDOLOHOOLI, AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE6B0", Offset = "0x6EBDAB0", VA = "0x186EBE6B0")]
	private float NLPGHAHAAAP([In] MGKDDJPECNM MPLALBADMNL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAFD0", Offset = "0x6EAA3D0", VA = "0x186EAAFD0")]
	private int DLEKPIFJDDM([In] KJELANLCEDO KNGEKNGLBAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7470", Offset = "0x6EB6870", VA = "0x186EB7470")]
	private void KIPFKNFJOME(MGKDDJPECNM OIDOLOHOOLI, bool JIMEJIALHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6EA69A0", Offset = "0x6EA5DA0", VA = "0x186EA69A0")]
	private static void AILGLGGPIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6EAF060", Offset = "0x6EAE460", VA = "0x186EAF060")]
	private static void FGCEOHLDKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF870", Offset = "0x6EBEC70", VA = "0x186EBF870")]
	private float PECCCNHHDGD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA800", Offset = "0x6EB9C00", VA = "0x186EBA800")]
	private static int LGJPBFIJMKM(APIFALGIOJE KLFFMNNBENE, APIFALGIOJE EHNIKEHCICN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF440", Offset = "0x6EBE840", VA = "0x186EBF440", Slot = "40")]
	public MGKDDJPECNM OLODHIPAAAM()
	{
		return default(MGKDDJPECNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7BA0", Offset = "0x6EB6FA0", VA = "0x186EB7BA0")]
	public void KMGNCICFNAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6EBEA60", Offset = "0x6EBDE60", VA = "0x186EBEA60")]
	private (bool, bool) OCPEPINAPPP()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA690", Offset = "0x6EB9A90", VA = "0x186EBA690")]
	private (float, float) LAAHDKEDINM([In] MGKDDJPECNM MPLALBADMNL)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB430", Offset = "0x6EAA830", VA = "0x186EAB430")]
	private void EFIIDIMCADL([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8040", Offset = "0x6EA7440", VA = "0x186EA8040")]
	private void BFJNIDKIKKF([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAF80", Offset = "0x6EBA380", VA = "0x186EBAF80")]
	private void MDHBNEDENJG([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6EAA740", Offset = "0x6EA9B40", VA = "0x186EAA740")]
	private void DHGBOJMGKCH([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI, FootSettings FFLIABKFJNB, bool OEONOMDDCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE510", Offset = "0x6EAD910", VA = "0x186EAE510")]
	private float FBDNPFBJFLG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6EB23A0", Offset = "0x6EB17A0", VA = "0x186EB23A0")]
	private void IGDDGANHMAB(MGKDDJPECNM MPLALBADMNL, AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0230", Offset = "0x6EAF630", VA = "0x186EB0230")]
	private float FJEGJFJKECC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7820", Offset = "0x6EA6C20", VA = "0x186EA7820")]
	private void BCJKICKDDBF([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5770", Offset = "0x6EB4B70", VA = "0x186EB5770")]
	private void JHDJHKDHFOB([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0280", Offset = "0x6EAF680", VA = "0x186EB0280")]
	private void GAOCJFGEHNP([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6EAB180", Offset = "0x6EAA580", VA = "0x186EAB180")]
	private void DPIFMOOLKDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6EAFFE0", Offset = "0x6EAF3E0", VA = "0x186EAFFE0")]
	private void FHPOKPEICIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6EB79A0", Offset = "0x6EB6DA0", VA = "0x186EB79A0")]
	private void KJLCFBLKFHH([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB08E0", Offset = "0x6EAFCE0", VA = "0x186EB08E0")]
	private void GIFPFMDIDBC(BHOLPDLEKNJ KDCEFDKFHMA, Transform FAAHLEFMKIL, Transform AGKBNKKLGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8730", Offset = "0x6EA7B30", VA = "0x186EA8730")]
	private void BONPCFNLLHE(MGKDDJPECNM MPLALBADMNL, AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB960", Offset = "0x6EBAD60", VA = "0x186EBB960")]
	private void MDNEJCMFMAJ(JLINMKOMCOC NJHMMJGPMAJ, BHOLPDLEKNJ KDCEFDKFHMA, IKSolverVR.Arm LAABIBJOALF, float OIFJGHIHKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBED40", Offset = "0x6EBE140", VA = "0x186EBED40")]
	private void OHOPMGOCECD([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1FD0", Offset = "0x6EB13D0", VA = "0x186EB1FD0")]
	protected void IGBBLBBCFAB([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8360", Offset = "0x6EA7760", VA = "0x186EA8360")]
	private void BGAHDBIDFJI([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFFB0", Offset = "0x6EBF3B0", VA = "0x186EBFFB0")]
	protected void PKGEFHNPELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8BE0", Offset = "0x6EA7FE0", VA = "0x186EA8BE0")]
	private void CKGHEMFCABH([In] MGKDDJPECNM MPLALBADMNL, [In] ALBPFMOKDEN PHFHINNEMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFCB0", Offset = "0x6EBF0B0", VA = "0x186EBFCB0")]
	private void PIGCDKBJINH(MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6EA9410", Offset = "0x6EA8810", VA = "0x186EA9410")]
	private void CLAPOLFCAFO([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAA70", Offset = "0x6EB9E70", VA = "0x186EBAA70")]
	private Vector3 MCGEJPNNJFO([In] MGKDDJPECNM MPLALBADMNL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6EAD800", Offset = "0x6EACC00", VA = "0x186EAD800")]
	private void ELABKBMGALP([In] MGKDDJPECNM MPLALBADMNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3F70", Offset = "0x6EB3370", VA = "0x186EB3F70")]
	private float IOIIJLEEEEF(float BGJPJIGCJIL, [In] MGKDDJPECNM MPLALBADMNL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFE60", Offset = "0x6EBF260", VA = "0x186EBFE60")]
	private void PJOPMAGJKOE(float BGJPJIGCJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6EA6CA0", Offset = "0x6EA60A0", VA = "0x186EA6CA0")]
	private void ALFBNONLKKB([In] MGKDDJPECNM MPLALBADMNL, ALBPFMOKDEN PHFHINNEMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6EADBC0", Offset = "0x6EACFC0", VA = "0x186EADBC0")]
	private float EPHCJJCDMOE([In] MGKDDJPECNM OIDOLOHOOLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE870", Offset = "0x6EADC70", VA = "0x186EAE870")]
	private void FDKPCIACNAE(MGKDDJPECNM MPLALBADMNL, ALBPFMOKDEN PHFHINNEMGK, Vector3 IEFJOGMLGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6EB0CF0", Offset = "0x6EB00F0", VA = "0x186EB0CF0")]
	private static void GKPKOOIBGBG(Transform KELFOJAPBEF, Quaternion CBCAIPELAJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1AB0", Offset = "0x6EB0EB0", VA = "0x186EB1AB0")]
	private void HAFJEJHAELJ([In] MGKDDJPECNM OFEIBONNCGH, [In] KJELANLCEDO KNGEKNGLBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3700", Offset = "0x6EB2B00", VA = "0x186EB3700")]
	private void INGCMDMDLGG([In] MGKDDJPECNM OFEIBONNCGH, [In] KJELANLCEDO KNGEKNGLBAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA880", Offset = "0x6EB9C80", VA = "0x186EBA880")]
	private void LPHADHGBPIJ(float MGNCHJOGPPF, [In] MGKDDJPECNM OIDOLOHOOLI, float CGOPACLDHHD = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4AF0", Offset = "0x6EB3EF0", VA = "0x186EB4AF0")]
	private float JBGMIDEGHLM([In] MGKDDJPECNM OIDOLOHOOLI, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6EA66B0", Offset = "0x6EA5AB0", VA = "0x186EA66B0")]
	private void AEHNLGOGDPK([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9CB0", Offset = "0x6EB90B0", VA = "0x186EB9CB0")]
	private void KOLAPDPHJMC([In] MGKDDJPECNM OIDOLOHOOLI, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC2C0", Offset = "0x6EBB6C0", VA = "0x186EBC2C0")]
	private void NEAGLLLDDLL([In] MGKDDJPECNM OIDOLOHOOLI, float KBPLBDDHJLF, float HCJDODDDMNE, Vector3 PMFMDBDHEKE, float CGOPACLDHHD = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6EB68E0", Offset = "0x6EB5CE0", VA = "0x186EB68E0")]
	private void KECNLJPFKEH(MGKDDJPECNM OIDOLOHOOLI, AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6EAE5E0", Offset = "0x6EAD9E0", VA = "0x186EAE5E0")]
	private void FCFCKBFLLAL(MGKDDJPECNM MPLALBADMNL, AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6EA7D00", Offset = "0x6EA7100", VA = "0x186EA7D00")]
	private void BEHGMEBFBFC(MGKDDJPECNM OIDOLOHOOLI, AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE130", Offset = "0x6EBD530", VA = "0x186EBE130")]
	public void NIDJCPAKDDD([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6EAAB60", Offset = "0x6EA9F60", VA = "0x186EAAB60")]
	public void DIHELDMOIFN([In] MGKDDJPECNM MPLALBADMNL, [In] AvatarFullBodyConfiguration JAGODFHKNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6740", Offset = "0x6EB5B40", VA = "0x186EB6740")]
	[CompilerGenerated]
	internal static void KDNLNLHKMHO(Transform DOELFDCMLHC, IKSolverVR.Arm LAABIBJOALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC210", Offset = "0x6EBB610", VA = "0x186EBC210")]
	[CompilerGenerated]
	internal static void NBJOILHKBIL(Vector3 DNILGPOKPCL, Vector3 NJCEDNPNJKI, EELBNLMJMEB P_2, JIOBLJEACMO P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6EA8B40", Offset = "0x6EA7F40", VA = "0x186EA8B40")]
	[CompilerGenerated]
	internal static void CCOPHMJHLOO(JKKBFJMHJJK NFJICLENECB, JKKBFJMHJJK EOFGCNOHEHD, Vector3 IJKAMPLJJHF, float PLAICKAFAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6EB35F0", Offset = "0x6EB29F0", VA = "0x186EB35F0")]
	[CompilerGenerated]
	internal static bool ILNEHCJMFPJ(IKSolverVR.Arm LAABIBJOALF, IALILNLEOOC HACJKEOIMJC, float KOCBFOPJBLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5330", Offset = "0x6EB4730", VA = "0x186EB5330")]
	[CompilerGenerated]
	internal static float JECJCBFIMCC(Vector3 COGCELKDBIJ, Vector3 LBGLHDLBAFI, Vector3 EDHKDNBKMOM, MGKDDJPECNM OIDOLOHOOLI, AvatarFullBodyConfiguration JAGODFHKNAI, float LHBPAMEKCBO)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum AOKBDGINPGO
		{
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private AOKBDGINPGO handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8120", Offset = "0x6EC7520", VA = "0x186EC8120")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6EC80E0", Offset = "0x6EC74E0", VA = "0x186EC80E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8150", Offset = "0x6EC7550", VA = "0x186EC8150")]
		private void PBHCNLCOFIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E42E20", Offset = "0x6E42220", VA = "0x186E42E20", Slot = "4")]
		public void SetEnabled(bool JCDOMELOGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8750", Offset = "0x6EC7B50", VA = "0x186EC8750")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, CDAJJEKMFAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[Header("Configuration")]
		[SerializeField]
		private EOPKGKNJKFM avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private NIHAEOHMDBO AHKJACMDFNH;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public NIHAEOHMDBO MEDBFGLHDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x9EB9B0", Offset = "0x9EADB0", VA = "0x1809EB9B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Transform PMCJPANKADC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x6EC9610", Offset = "0x6EC8A10", VA = "0x186EC9610", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8780", Offset = "0x6EC7B80", VA = "0x186EC8780")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6EC94D0", Offset = "0x6EC88D0", VA = "0x186EC94D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9480", Offset = "0x6EC8880", VA = "0x186EC9480")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9410", Offset = "0x6EC8810", VA = "0x186EC9410")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8780", Offset = "0x6EC7B80", VA = "0x186EC8780", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8C10", Offset = "0x6EC8010", VA = "0x186EC8C10", Slot = "6")]
		public NIHAEOHMDBO CreateAvatarSystem(string LOHELPMMKLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9410", Offset = "0x6EC8810", VA = "0x186EC9410", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6EC8840", Offset = "0x6EC7C40", VA = "0x186EC8840", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9520", Offset = "0x6EC8920", VA = "0x186EC9520", Slot = "9")]
		public void UpdatePostIKAnimControllers(float GNOIEGLKNOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class BIDPKJACOEA : MEJAEAPMNHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<string, NIHAEOHMDBO> LBKEIMPONGK;

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA650", Offset = "0x6EC9A50", VA = "0x186ECA650")]
	[AGCFNMIICNN.OGAOPBBDHOG]
	internal static void LCJIMCILPFH(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA6C0", Offset = "0x6EC9AC0", VA = "0x186ECA6C0", Slot = "4")]
	public NIHAEOHMDBO NONGDHAEFPI(string MJLBFFHPFGL, AvatarSystemConfiguration DIBAFEMAKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA320", Offset = "0x6EC9720", VA = "0x186ECA320", Slot = "5")]
	public void ENPDILOAOJE(string MJLBFFHPFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA510", Offset = "0x6EC9910", VA = "0x186ECA510", Slot = "6")]
	public string KAOGNPOOBEC(string OFPIHGCDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA4A0", Offset = "0x6EC98A0", VA = "0x186ECA4A0")]
	private string GFPJEJBDIAD(string OFPIHGCDNNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA8E0", Offset = "0x6EC9CE0", VA = "0x186ECA8E0")]
	public BIDPKJACOEA()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class FEFPGGLPKHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private Dictionary<string, Transform> NLPJIDHELMO;

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public bool PJCKOFPFAIG
			{
				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0x6ECC140", Offset = "0x6ECB540", VA = "0x186ECC140")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC1D0", Offset = "0x6ECB5D0", VA = "0x186ECC1D0")]
			public void ILMLAFABIFG(VRIK ODKJFIPFOHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
			public void DPLOADCMGFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC180", Offset = "0x6ECB580", VA = "0x186ECC180")]
			public void CALNFFOLFJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC300", Offset = "0x6ECB700", VA = "0x186ECC300")]
			public FEFPGGLPKHN()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		[KHGLLLAOHAN(PGGKFLBMAKK.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly FEFPGGLPKHN CLHMAIEHBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private CDAJJEKMFAI PDKCFHLECNN;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EC96B0", Offset = "0x6EC8AB0", VA = "0x186EC96B0")]
		private void OOJJEJPOBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9660", Offset = "0x6EC8A60", VA = "0x186EC9660")]
		private bool JCKCCKNFOBE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9990", Offset = "0x6EC8D90", VA = "0x186EC9990")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9A00", Offset = "0x6EC8E00", VA = "0x186EC9A00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6EC99A0", Offset = "0x6EC8DA0", VA = "0x186EC99A0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6EC9C70", Offset = "0x6EC9070", VA = "0x186EC9C70")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC390", Offset = "0x6ECB790", VA = "0x186ECC390")]
			public void LKOIGPCFEMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6ECC470", Offset = "0x6ECB870", VA = "0x186ECC470")]
			public (float, float) OOKAKBJNEMK(Animator BJCFDIBGFJG, AnimatorStateInfo MBLMCGLDJOB)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC9B0", Offset = "0x6ECBDB0", VA = "0x186ECC9B0")]
		public void LKOIGPCFEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC7A0", Offset = "0x6ECBBA0", VA = "0x186ECC7A0")]
		public (float, float) HOOKLAJHADF(Animator BJCFDIBGFJG)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6ECC5B0", Offset = "0x6ECB9B0", VA = "0x186ECC5B0")]
		private (float, float) BJCLKKKCEEI(Animator BJCFDIBGFJG, AnimatorStateInfo MBLMCGLDJOB)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCBA0", Offset = "0x6ECBFA0", VA = "0x186ECCBA0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDBF0", Offset = "0x6ECCFF0", VA = "0x186ECDBF0", Slot = "4")]
		public override void OnStateEnter(Animator BJCFDIBGFJG, AnimatorStateInfo MBLMCGLDJOB, int ALIIABJNBLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECDD50", Offset = "0x6ECD150", VA = "0x186ECDD50")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class BHFMBJPKABP<TInput, TOutput> : GNNMEBNLMNC<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected readonly CNEHIJMIJDK EDNCHDNMNOO;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x53D3740", Offset = "0x53D2B40", VA = "0x1853D3740")]
	protected BHFMBJPKABP(CNEHIJMIJDK EDNCHDNMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput KBLFJIABLOP(TInput AOOGNGKJLKL, [Out] IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x53D36A0", Offset = "0x53D2AA0", VA = "0x1853D36A0", Slot = "5")]
	public bool ADCHEJKAEDP(TInput AOOGNGKJLKL, [Out] TOutput? CEDDFJCBLGM, [Out] IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[GFHMGJFENGN]
public static class IONOCEJKDDB
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly Regex DDPHPDKMLJF;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCE50", Offset = "0x6ECC250", VA = "0x186ECCE50")]
	public static CDICMNPJLOI MIHFHOHBGNF(FKEBAHOJOEH CJJEOONCGLJ, DOPNIDFJPBN JBHHFHCKHPG, Guid? DFGGLDDDDMF, Color? LLBMNEDEHEF, HAPHCDJNHOG JBCPDKGINNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCCF0", Offset = "0x6ECC0F0", VA = "0x186ECCCF0")]
	public static HHDIOAFENPE JMPBLIEGBFP(CDICMNPJLOI JGCOLLOOLHL)
	{
		return default(HHDIOAFENPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x30B82D0", Offset = "0x30B76D0", VA = "0x1830B82D0")]
	internal static TModern? KBIKKNEOPMM<TModern>(string? AOOGNGKJLKL, PIBHMOCPPJE<TModern> AHJKPCKLFFM, CNEHIJMIJDK EDNCHDNMNOO, NHGFEIEJHNL CCPBCIAPOGL, TModern AGLJLNGJOBP) where TModern : struct, MDKKLDNPMCM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x30B9920", Offset = "0x30B8D20", VA = "0x1830B9920")]
	internal static IPOHPGCDOAD OAPHMIIKHKM<TModern>(string? AOOGNGKJLKL, PIBHMOCPPJE<TModern> AHJKPCKLFFM, CNEHIJMIJDK EDNCHDNMNOO, NHGFEIEJHNL CCPBCIAPOGL, TModern AGLJLNGJOBP) where TModern : struct, MDKKLDNPMCM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCBB0", Offset = "0x6ECBFB0", VA = "0x186ECCBB0")]
	internal static List<ODGELMEONNM> IELLHJDIPHJ(IEnumerable<FGLCMIGKNLE>? HAPFLLLLELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x30B7450", Offset = "0x30B6850", VA = "0x1830B7450")]
	internal static string BACKFLCBNMM<TModern>(TModern AOOGNGKJLKL, PIBHMOCPPJE<TModern> AHJKPCKLFFM, CNEHIJMIJDK EDNCHDNMNOO) where TModern : MDKKLDNPMCM
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class BHIAJEEANEK : GJFPCKEKDOI
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GNNMEBNLMNC<HOEIGNDDKBE, KKGOEONLCJM> IPKPIGAOHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public GNNMEBNLMNC<OJGBLAGOBMN, LGFIACEHFON> JCPEOEOIGEH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GNNMEBNLMNC<OJGBLAGOBMN, LGFIACEHFON> DPAKIBAGEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public BKOJKAEPOOL OEAKJGGBEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ODECHECIIGO NNDPLLJPBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9D50", Offset = "0x6EC9150", VA = "0x186EC9D50")]
	[UsedImplicitly]
	[AGCFNMIICNN.OGAOPBBDHOG.CHABDOHBNJI]
	internal static void DMLMOPPEGDC(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6EC9DC0", Offset = "0x6EC91C0", VA = "0x186EC9DC0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BHIAJEEANEK([CNGCCDLPGOD("UnitySerialization")] EHAIJMEFJLA BGGAKBLPJEJ, [CNGCCDLPGOD(null)] PLDNGFNJBOA MHNAFPFJGIM, [CNGCCDLPGOD(null)] CNEHIJMIJDK EDNCHDNMNOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum HFKPIMEPIKJ
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DKLBENANFMN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBCA0", Offset = "0x6ECB0A0", VA = "0x186ECBCA0")]
	public DKLBENANFMN(string LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBC30", Offset = "0x6ECB030", VA = "0x186ECBC30")]
	public DKLBENANFMN(string LNICHECHJFC, Exception AMBPMFFJDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBC00", Offset = "0x6ECB000", VA = "0x186ECBC00")]
	public DKLBENANFMN(HFKPIMEPIKJ CFOOJJGCIPD, string LNICHECHJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBC60", Offset = "0x6ECB060", VA = "0x186ECBC60")]
	public DKLBENANFMN(HFKPIMEPIKJ CFOOJJGCIPD, string LNICHECHJFC, Exception AMBPMFFJDPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class OFGBHGFIOON
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly EHAIJMEFJLA BGGAKBLPJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly PLDNGFNJBOA MHNAFPFJGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly CNEHIJMIJDK EDNCHDNMNOO;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB590", Offset = "0x6ECA990", VA = "0x186ECB590")]
	protected OFGBHGFIOON(EHAIJMEFJLA BGGAKBLPJEJ, PLDNGFNJBOA MHNAFPFJGIM, CNEHIJMIJDK EDNCHDNMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6ED08F0", Offset = "0x6ECFCF0", VA = "0x186ED08F0")]
	protected string PEAMFOGKPGN(KKGOEONLCJM MHDNNLLPNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6ED02A0", Offset = "0x6ECF6A0", VA = "0x186ED02A0")]
	protected string DOEPLMIJHGL(KKGOEONLCJM MHDNNLLPNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6ED05C0", Offset = "0x6ECF9C0", VA = "0x186ED05C0")]
	private AvatarOutfitSelectionData MIHFHOHBGNF(CDICMNPJLOI LHIJDKCFGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0480", Offset = "0x6ECF880", VA = "0x186ED0480")]
	private static AvatarCustomizationSettingsData.AnchorParams HDOBFDICILH(NBNLNGHNGFL? OGPPAFCOOFN)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GNNMEBNLMNC<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput KBLFJIABLOP(TInput AOOGNGKJLKL, [Out] IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADCHEJKAEDP(TInput AOOGNGKJLKL, [Out] TOutput? CEDDFJCBLGM, [Out] IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface GJFPCKEKDOI
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GNNMEBNLMNC<HOEIGNDDKBE, KKGOEONLCJM> IPKPIGAOHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GNNMEBNLMNC<OJGBLAGOBMN, LGFIACEHFON> DPAKIBAGEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	BKOJKAEPOOL OEAKJGGBEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum NHGFEIEJHNL
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface ODECHECIIGO
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IHEDDONOIFC GKPJGNLGAKF(KKGOEONLCJM JGCOLLOOLHL);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface BKOJKAEPOOL
{
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJGBLAGOBMN GKPJGNLGAKF(KKGOEONLCJM JGCOLLOOLHL, int PIIALHEOFHP, string? LJAGHAHCFHJ, string? CAMGILFLAKE, HLDJPDEDBEH EOIJHHALHMM, List<ODGELMEONNM>? LDCECHPNDAA);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[GFHMGJFENGN]
internal class ECHOAGMFDNA : BHFMBJPKABP<HOEIGNDDKBE, KKGOEONLCJM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly PLDNGFNJBOA MHNAFPFJGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly NCJKBBIILHK IADHJGKNPML;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBF70", Offset = "0x6ECB370", VA = "0x186ECBF70")]
	public ECHOAGMFDNA(EHAIJMEFJLA BGGAKBLPJEJ, PLDNGFNJBOA MHNAFPFJGIM, CNEHIJMIJDK EDNCHDNMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6ECBCD0", Offset = "0x6ECB0D0", VA = "0x186ECBCD0", Slot = "6")]
	public override KKGOEONLCJM KBLFJIABLOP(HOEIGNDDKBE AOOGNGKJLKL, [Out] IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class MLHNIGPHCNF : EHAIJMEFJLA
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class CLPMPOHAHFM : JsonConverter<IPOHPGCDOAD>
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBB20", Offset = "0x6ECAF20", VA = "0x186ECBB20", Slot = "9")]
		public override void WriteJson(JsonWriter EEKKIBDAGAJ, IPOHPGCDOAD? HCPAOILCJCB, JsonSerializer HBJHPALNCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBA00", Offset = "0x6ECAE00", VA = "0x186ECBA00", Slot = "10")]
		public override IPOHPGCDOAD ReadJson(JsonReader IEMPDPINHLH, Type COHEBDMONKG, IPOHPGCDOAD? OANLBNBPLHG, bool DNHKJEFLPHM, JsonSerializer HBJHPALNCOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6ECBBC0", Offset = "0x6ECAFC0", VA = "0x186ECBBC0")]
		public CLPMPOHAHFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class JDDEEIIMLPC : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override bool ABAOABJDHIE
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD4C0", Offset = "0x6ECC8C0", VA = "0x186ECD4C0", Slot = "5")]
		public override object ReadJson(JsonReader IEMPDPINHLH, Type COHEBDMONKG, object? OANLBNBPLHG, JsonSerializer HBJHPALNCOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD100", Offset = "0x6ECC500", VA = "0x186ECD100", Slot = "6")]
		public override bool CanConvert(Type COHEBDMONKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD520", Offset = "0x6ECC920", VA = "0x186ECD520", Slot = "4")]
		public override void WriteJson(JsonWriter EEKKIBDAGAJ, object? HCPAOILCJCB, JsonSerializer HBJHPALNCOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6ECD2E0", Offset = "0x6ECC6E0", VA = "0x186ECD2E0")]
		private static bool GDPEBNFGHKE(object HCPAOILCJCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public JDDEEIIMLPC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings EKNFDHMIMOD;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDA90", Offset = "0x6ECCE90", VA = "0x186ECDA90")]
	internal MLHNIGPHCNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3143A10", Offset = "0x3142E10", VA = "0x183143A10", Slot = "4")]
	public string ILJNJCANEAL<T>(T NCHBKHMIMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x3143980", Offset = "0x3142D80", VA = "0x183143980", Slot = "5")]
	public T GMFFMOPFHMJ<T>(string HCPAOILCJCB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class KGNPIBCEKKK : EHAIJMEFJLA
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x31129D0", Offset = "0x3111DD0", VA = "0x1831129D0", Slot = "4")]
	public string ILJNJCANEAL<T>(T NCHBKHMIMGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3112950", Offset = "0x3111D50", VA = "0x183112950", Slot = "5")]
	public T GMFFMOPFHMJ<T>(string HCPAOILCJCB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public KGNPIBCEKKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GFHMGJFENGN]
internal class NCJKBBIILHK : BHFMBJPKABP<OJGBLAGOBMN, LGFIACEHFON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly EHAIJMEFJLA BGGAKBLPJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly PLDNGFNJBOA MHNAFPFJGIM;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0160", Offset = "0x6ECF560", VA = "0x186ED0160")]
	public NCJKBBIILHK(EHAIJMEFJLA BGGAKBLPJEJ, PLDNGFNJBOA MHNAFPFJGIM, CNEHIJMIJDK EDNCHDNMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF370", Offset = "0x6ECE770", VA = "0x186ECF370", Slot = "6")]
	public override LGFIACEHFON KBLFJIABLOP(OJGBLAGOBMN AOOGNGKJLKL, [Out] IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6ED0010", Offset = "0x6ECF410", VA = "0x186ED0010")]
	internal void PLAOCFBOBBJ(string MHNDGJKDCJH, KKGOEONLCJM MHDNNLLPNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDF70", Offset = "0x6ECD370", VA = "0x186ECDF70")]
	public IEnumerable<CDICMNPJLOI> AOAGCNKBAFM(string NIJFCCOIOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECEC60", Offset = "0x6ECE060", VA = "0x186ECEC60")]
	private IEnumerable<CDICMNPJLOI> HHCACDHCFCD(string NIJFCCOIOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE810", Offset = "0x6ECDC10", VA = "0x186ECE810")]
	internal IEnumerable<CDICMNPJLOI> GPIJKJPIFBO(string NIJFCCOIOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE180", Offset = "0x6ECD580", VA = "0x186ECE180")]
	private CDICMNPJLOI FBBLOGAHGBF(AvatarOutfitSelectionData DALHBIKPIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF790", Offset = "0x6ECEB90", VA = "0x186ECF790")]
	private void LIACFCKNANI(AvatarCustomizationSettingsData BGEDFPJJNKB, KKGOEONLCJM MHDNNLLPNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE500", Offset = "0x6ECD900", VA = "0x186ECE500")]
	private CDICMNPJLOI FBBLOGAHGBF(string BJBOAGKCAMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECF070", Offset = "0x6ECE470", VA = "0x186ECF070")]
	internal static (HAPHCDJNHOG, string, string) IDCCLPEBLEB(string BJBOAGKCAMI, CNEHIJMIJDK EDNCHDNMNOO)
	{
		return default((HAPHCDJNHOG, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6ECDD70", Offset = "0x6ECD170", VA = "0x186ECDD70")]
	private PLPKIICCMFB? AJDMMBCCCNI(string? FNECNONNEND, Vector2 HMHMIMEGLPH, float CLHFJDEKJBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6ECE020", Offset = "0x6ECD420", VA = "0x186ECE020")]
	private static NBNLNGHNGFL CCEICNPDKJE(AvatarCustomizationSettingsData.AnchorParams EFMBOFGFAFI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GFHMGJFENGN]
internal class CGANHCCCBAK : OFGBHGFIOON, ODECHECIIGO
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB590", Offset = "0x6ECA990", VA = "0x186ECB590")]
	public CGANHCCCBAK(EHAIJMEFJLA BGGAKBLPJEJ, PLDNGFNJBOA MHNAFPFJGIM, CNEHIJMIJDK EDNCHDNMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6ECAFA0", Offset = "0x6ECA3A0", VA = "0x186ECAFA0", Slot = "4")]
	public IHEDDONOIFC GKPJGNLGAKF(KKGOEONLCJM JGCOLLOOLHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECAEA0", Offset = "0x6ECA2A0", VA = "0x186ECAEA0")]
	private string CGDMJMEKEKI(KKGOEONLCJM MHDNNLLPNCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB350", Offset = "0x6ECA750", VA = "0x186ECB350")]
	private string JBGAOGHKIMO(CDICMNPJLOI LHIJDKCFGIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[GFHMGJFENGN]
internal class CFFBOAOGDFG : BHFMBJPKABP<OJGBLAGOBMN, LGFIACEHFON>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly EHAIJMEFJLA BGGAKBLPJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly GNNMEBNLMNC<OJGBLAGOBMN, LGFIACEHFON> OBIAENGABCB;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6ECADA0", Offset = "0x6ECA1A0", VA = "0x186ECADA0")]
	public CFFBOAOGDFG(GNNMEBNLMNC<OJGBLAGOBMN, LGFIACEHFON> OBIAENGABCB, CNEHIJMIJDK EDNCHDNMNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6ECA970", Offset = "0x6EC9D70", VA = "0x186ECA970", Slot = "6")]
	public override LGFIACEHFON KBLFJIABLOP(OJGBLAGOBMN AOOGNGKJLKL, [Out] IReadOnlyList<ODGELMEONNM>? LDCECHPNDAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[GFHMGJFENGN]
internal class MAAKDONEHEB : BKOJKAEPOOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly EHAIJMEFJLA BGGAKBLPJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly ODECHECIIGO EFLBFCLPOCE;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6ECD9A0", Offset = "0x6ECCDA0", VA = "0x186ECD9A0")]
	public MAAKDONEHEB(ODECHECIIGO EFLBFCLPOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6ECD600", Offset = "0x6ECCA00", VA = "0x186ECD600", Slot = "4")]
	public OJGBLAGOBMN GKPJGNLGAKF(KKGOEONLCJM JGCOLLOOLHL, int PIIALHEOFHP, string? LJAGHAHCFHJ, string? CAMGILFLAKE, HLDJPDEDBEH EOIJHHALHMM, List<ODGELMEONNM>? LDCECHPNDAA)
	{
		return null;
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6EC77D0", Offset = "0x6EC6BD0", VA = "0x186EC77D0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CGMMHMJKKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB8F0", Offset = "0x6ECACF0", VA = "0x186ECB8F0")]
	public static HHDIOAFENPE KBLFJIABLOP(this JEBDJBPODNG JGCOLLOOLHL)
	{
		return default(HHDIOAFENPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB7D0", Offset = "0x6ECABD0", VA = "0x186ECB7D0")]
	public static JEBDJBPODNG GKPJGNLGAKF(this HHDIOAFENPE DHKJHIHBFBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB770", Offset = "0x6ECAB70", VA = "0x186ECB770")]
	public static bool BFPPJIPJNOB(this HHDIOAFENPE DHKJHIHBFBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6ECB710", Offset = "0x6ECAB10", VA = "0x186ECB710")]
	public static bool AFDMADPGJLI(this HHDIOAFENPE DHKJHIHBFBK)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x51DE310", Offset = "0x51DD710", VA = "0x1851DE310")]
			public AnchorParams(Vector2 DMHJHKAIDJJ, Vector3 HFHLJCPKBCG, Vector3 AHNDJINOPFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x6EC7720", Offset = "0x6EC6B20", VA = "0x186EC7720")]
			internal NBNLNGHNGFL GKPJGNLGAKF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private JGADMJKLMAM useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x6EC7FC0", Offset = "0x6EC73C0", VA = "0x186EC7FC0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DC0", Offset = "0x8C71C0", VA = "0x1808C7DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4CABFE0", Offset = "0x4CAB3E0", VA = "0x184CABFE0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xA8BDC0", Offset = "0xA8B1C0", VA = "0x180A8BDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xB16330", Offset = "0xB15730", VA = "0x180B16330")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xDC5CA0", Offset = "0xDC50A0", VA = "0x180DC5CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C80", Offset = "0x8C8080", VA = "0x1808C8C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x6EC8060", Offset = "0x6EC7460", VA = "0x186EC8060")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B80", Offset = "0x8C6F80", VA = "0x1808C7B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x933CA0", Offset = "0x9330A0", VA = "0x180933CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x149A160", Offset = "0x1499560", VA = "0x18149A160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA40", Offset = "0x8CEE40", VA = "0x1808CFA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x6EC80A0", Offset = "0x6EC74A0", VA = "0x186EC80A0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xA549C0", Offset = "0xA53DC0", VA = "0x180A549C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xC7FFF0", Offset = "0xC7F3F0", VA = "0x180C7FFF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x12612A0", Offset = "0x12606A0", VA = "0x1812612A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEE0", Offset = "0x8CA2E0", VA = "0x1808CAEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8CAED0", Offset = "0x8CA2D0", VA = "0x1808CAED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1BF5230", Offset = "0x1BF4630", VA = "0x181BF5230")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xA95890", Offset = "0xA94C90", VA = "0x180A95890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8FCB60", Offset = "0x8FBF60", VA = "0x1808FCB60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8FCBC0", Offset = "0x8FBFC0", VA = "0x1808FCBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8CF9F0", Offset = "0x8CEDF0", VA = "0x1808CF9F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAC0", Offset = "0x8CEEC0", VA = "0x1808CFAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8CFAE0", Offset = "0x8CEEE0", VA = "0x1808CFAE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA90", Offset = "0x8CEE90", VA = "0x1808CFA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA20", Offset = "0x8CEE20", VA = "0x1808CFA20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB90", Offset = "0x8CEF90", VA = "0x1808CFB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9A4A00", Offset = "0x9A3E00", VA = "0x1809A4A00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xE97840", Offset = "0xE96C40", VA = "0x180E97840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB40", Offset = "0x8CEF40", VA = "0x1808CFB40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB70", Offset = "0x8CEF70", VA = "0x1808CFB70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA8C290", Offset = "0xA8B690", VA = "0x180A8C290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA8BFE0", Offset = "0xA8B3E0", VA = "0x180A8BFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8CDCD0", Offset = "0x8CD0D0", VA = "0x1808CDCD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x8CDD20", Offset = "0x8CD120", VA = "0x1808CDD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x99A220", Offset = "0x999620", VA = "0x18099A220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xA9C280", Offset = "0xA9B680", VA = "0x180A9C280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x92C6C0", Offset = "0x92BAC0", VA = "0x18092C6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x92A0A0", Offset = "0x9294A0", VA = "0x18092A0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public JGADMJKLMAM UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xB1C6C0", Offset = "0xB1BAC0", VA = "0x180B1C6C0")]
			get
			{
				return default(JGADMJKLMAM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACE0", Offset = "0xB1A0E0", VA = "0x180B1ACE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xB1CC70", Offset = "0xB1C070", VA = "0x180B1CC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xB1B1E0", Offset = "0xB1A5E0", VA = "0x180B1B1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6EC8080", Offset = "0x6EC7480", VA = "0x186EC8080")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x6EC80C0", Offset = "0x6EC74C0", VA = "0x186EC80C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6EC7C60", Offset = "0x6EC7060", VA = "0x186EC7C60")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public HAPHCDJNHOG BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CABHCJKGFMC? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6EC9630", Offset = "0x6EC8A30", VA = "0x186EC9630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AvatarUgcOutfitData()
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
