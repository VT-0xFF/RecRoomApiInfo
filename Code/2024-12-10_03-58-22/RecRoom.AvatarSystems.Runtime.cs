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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6AFAD10", Offset = "0x6AF9910", VA = "0x186AFAD10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6B15240", Offset = "0x6B13E40", VA = "0x186B15240", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CGPAMFEMIJK]
internal class DGMGMLDPFMP : EFKEMDODMBG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OGKCFKKBKJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public DGMGMLDPFMP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CAJNNHABANH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GACLFEGLDGF HFNJAFCFIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JCEBNIHGDJJ MCBFJAFEOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ELDABPLJFGJ ACABAHMIPAN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6F80", Offset = "0x6AF5B80", VA = "0x186AF6F80")]
	[UsedImplicitly]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void JMDGAILJKOB(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7370", Offset = "0x6AF5F70", VA = "0x186AF7370")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DGMGMLDPFMP([JGAMIMHCGFI(null)] GACLFEGLDGF HFNJAFCFIJN, [JGAMIMHCGFI(null)] JCEBNIHGDJJ MCBFJAFEOAP, [JGAMIMHCGFI(null)] ELDABPLJFGJ ACABAHMIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AF67A0", Offset = "0x6AF53A0", VA = "0x186AF67A0", Slot = "5")]
	public LOGMJPPPGNI JHLKFIMOBAI(CAJNNHABANH HFBIBPKGGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5D20", Offset = "0x6AF4920", VA = "0x186AF5D20", Slot = "4")]
	public LOGMJPPPGNI IGHNCEOFDDC(CAJNNHABANH HFBIBPKGGBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7260", Offset = "0x6AF5E60", VA = "0x186AF7260", Slot = "6")]
	public OJJCFOIIEBB PMMKIACJGHE(LOGMJPPPGNI BFLLAIFBMAJ, int MDHMFNHCIOG, string? GMBAACDNNFI, string? LEONHHEIAIA, MEMJPCPEGPB JEEDFIDDHGM, List<DBJNMBGJHNF>? EHNLCODOEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AF6FF0", Offset = "0x6AF5BF0", VA = "0x186AF6FF0", Slot = "7")]
	public bool OFBJIJDNIIG(DHJJMJBLILM MBOGCCBAJGB, [Out] LOGMJPPPGNI? CKCGPKIPOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5BB0", Offset = "0x6AF47B0", VA = "0x186AF5BB0", Slot = "8")]
	public bool CDICHJDMGHP(OJJCFOIIEBB MMPIAFBHGPC, [Out] LOGMJPPPGNI? CKCGPKIPOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5C90", Offset = "0x6AF4890", VA = "0x186AF5C90", Slot = "9")]
	public bool EGEJEAGKAMG(OJJCFOIIEBB MMPIAFBHGPC, [Out] LDGHCABMLIE? MBOGCCBAJGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2C3B380", Offset = "0x2C39F80", VA = "0x182C3B380")]
	private bool MLIHFAGNABH<TInput, TOutput>(TInput GKMKPBACAOC, IJFLDHBFAJL<TInput, TOutput> FPPLFEGMMGA, [Out] TOutput? CMNKPAFMHMO) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6AF5A00", Offset = "0x6AF4600", VA = "0x186AF5A00")]
	[CompilerGenerated]
	private EBEALDMKIMI ABCAOIHELFB(FaceFeatureType EGNKBNHFGKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7080", Offset = "0x6AF5C80", VA = "0x186AF7080")]
	[CompilerGenerated]
	private EBEALDMKIMI OGDBIJOGPFJ(FaceFeatureType EGNKBNHFGKA, OGKCFKKBKJC P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CGPAMFEMIJK]
internal class MBPFEOLJBLJ : GACLFEGLDGF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void GHJOABBEGBP<in TData>(TData CKCGPKIPOPM, IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly ELDABPLJFGJ ACABAHMIPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PCJJBDFPBKI JKNBMKCLLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GHJOABBEGBP<LOGMJPPPGNI>?[] HFNJAFCFIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GHJOABBEGBP<LDGHCABMLIE>?[] IGFALEMMAJE;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AF99F0", Offset = "0x6AF85F0", VA = "0x186AF99F0")]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	[UsedImplicitly]
	internal static void JMDGAILJKOB(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA960", Offset = "0x6AF9560", VA = "0x186AFA960")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MBPFEOLJBLJ([JGAMIMHCGFI(null)] ELDABPLJFGJ ACABAHMIPAN, [JGAMIMHCGFI(null)] PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA860", Offset = "0x6AF9460", VA = "0x186AFA860", Slot = "4")]
	public bool OKIMFGHMMEC(LOGMJPPPGNI CKCGPKIPOPM, IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6AFA700", Offset = "0x6AF9300", VA = "0x186AFA700", Slot = "5")]
	public bool OKIMFGHMMEC(LDGHCABMLIE MBOGCCBAJGB, IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9CC0", Offset = "0x6AF88C0", VA = "0x186AF9CC0")]
	private void OGNADONGEBA(LOGMJPPPGNI CKCGPKIPOPM, IReadOnlyList<DBJNMBGJHNF>? AEBBBFCJHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9A90", Offset = "0x6AF8690", VA = "0x186AF9A90")]
	private void NLCMNIOPFLM(LOGMJPPPGNI CKCGPKIPOPM, IReadOnlyList<DBJNMBGJHNF>? AEBBBFCJHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6AF99C0", Offset = "0x6AF85C0", VA = "0x186AF99C0")]
	private void JDOLGKPBODO(LOGMJPPPGNI CKCGPKIPOPM, IReadOnlyList<DBJNMBGJHNF>? AEBBBFCJHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6AF9A60", Offset = "0x6AF8660", VA = "0x186AF9A60")]
	private void JPMIFLLJLNH(LOGMJPPPGNI CKCGPKIPOPM, IReadOnlyList<DBJNMBGJHNF>? AEBBBFCJHJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GACLFEGLDGF
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OKIMFGHMMEC(LOGMJPPPGNI CKCGPKIPOPM, IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKIMFGHMMEC(LDGHCABMLIE MBOGCCBAJGB, IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE);
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
		public MALAKPJDCFE AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6AF4AB0", Offset = "0x6AF36B0", VA = "0x186AF4AB0")]
		public void KOBBOEDPEBF(AnimationPoseSetting FDOEIPBMJJM, float JPKGPGBHILN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4BE0", Offset = "0x6AF37E0", VA = "0x186AF4BE0")]
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
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x6AF54D0", Offset = "0x6AF40D0", VA = "0x186AF54D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5490", Offset = "0x6AF4090", VA = "0x186AF5490")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6AF4C00", Offset = "0x6AF3800", VA = "0x186AF4C00")]
		private void ILMDJPIKCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6A95600", Offset = "0x6A94200", VA = "0x186A95600", Slot = "4")]
		public void SetEnabled(bool DHKFDKHEAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5500", Offset = "0x6AF4100", VA = "0x186AF5500")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x369")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Seated animation settings")]
		[Tooltip("How much to twist shoulders when seated.")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Default angle of the foot bone as seen in idle")]
		public float FootRestAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5580", Offset = "0x6AF4180", VA = "0x186AF5580")]
		public AnimationPoseSetting MKHLPENLJCM(MALAKPJDCFE CDBBEGBIEGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6AF5540", Offset = "0x6AF4140", VA = "0x186AF5540")]
		public void CIBOHFMOAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6AF55B0", Offset = "0x6AF41B0", VA = "0x186AF55B0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6AF82A0", Offset = "0x6AF6EA0", VA = "0x186AF82A0")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class OJEKGIEMLCA : LGECBNDMCJN
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class FHGGKHFGOEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private Vector3 DKPDNMNLHAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private Quaternion OLFDOGLJCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private Vector3 LCNFFAKJEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private Transform ELKCCKCAHIC;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Vector3 PMJPHNOIEKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x15FDF60", Offset = "0x15FCB60", VA = "0x1815FDF60")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x15FDF80", Offset = "0x15FCB80", VA = "0x1815FDF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Quaternion HKAKABIMJIB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xCDF1B0", Offset = "0xCDDDB0", VA = "0x180CDF1B0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xCDF450", Offset = "0xCDE050", VA = "0x180CDF450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public float FBGLPFFPEGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xA62990", Offset = "0xA61590", VA = "0x180A62990")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1061BD0", Offset = "0x10607D0", VA = "0x181061BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool ABCAPHKDGEG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x88C4F0", Offset = "0x88B0F0", VA = "0x18088C4F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x88C600", Offset = "0x88B200", VA = "0x18088C600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool ECKHNJHFLDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x88C730", Offset = "0x88B330", VA = "0x18088C730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x88C500", Offset = "0x88B100", VA = "0x18088C500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool PPIKKDDPANL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x88C700", Offset = "0x88B300", VA = "0x18088C700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x88C4C0", Offset = "0x88B0C0", VA = "0x18088C4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float BNDACDECOEM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xA629C0", Offset = "0xA615C0", VA = "0x180A629C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x1E1C0F0", Offset = "0x1E1ACF0", VA = "0x181E1C0F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8280", Offset = "0x6AF6E80", VA = "0x186AF8280")]
		public void PJOMDNBOGCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7720", Offset = "0x6AF6320", VA = "0x186AF7720")]
		public void DIFHKLCJMJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6AF74F0", Offset = "0x6AF60F0", VA = "0x186AF74F0")]
		public float BABJMBFJIIM(Vector3 CBNPAGLOGLL, Quaternion POOIKHAMAMF, [In] FootSettings MPAGBGMBBLN, float DJGBFNHJHHB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7980", Offset = "0x6AF6580", VA = "0x186AF7980")]
		public void KPENKKNBFOB(Vector3 BGKGDDEJDIP, Quaternion EMEEEJJHIJH, Transform DOIMICJLGFG, float LECPCEMCBIM, bool NEPEHENLFLM, bool IEFABLAANFE, float HFLNFOIGIIK, float GGACOHMLGOO, Transform AHFIDHNOIFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8050", Offset = "0x6AF6C50", VA = "0x186AF8050")]
		public void MIKBKMCCACM(Transform MPGFINODBNC, Transform AHFIDHNOIFE, bool CHCFCDGMHND, bool MJFCALIDDKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7880", Offset = "0x6AF6480", VA = "0x186AF7880")]
		private void JIANHFJLAPH(Transform AHFIDHNOIFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7730", Offset = "0x6AF6330", VA = "0x186AF7730")]
		public void HEKEPNKFHDH(Transform AHFIDHNOIFE, AvatarFullBodyConfiguration NLEDHKLDJJG, Vector3 OBIMMKGLIPL, float AMMOPCFLKMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6AF7700", Offset = "0x6AF6300", VA = "0x186AF7700")]
		public void DDIDJONBBAB(float GGACOHMLGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8290", Offset = "0x6AF6E90", VA = "0x186AF8290")]
		public FHGGKHFGOEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class GEDHPJFPELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private float NNDKGFFJGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private bool KAPJHDBIFLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AnimationPoseSetting GKLAOJJAGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private float NMBGPAIALJJ;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9530", Offset = "0x6AF8130", VA = "0x186AF9530")]
		public void JMIDCECDJJG(IKSolverVR.Arm MGPGBCNKPNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8920", Offset = "0x6AF7520", VA = "0x186AF8920")]
		public void ELLHKBEMEMB(IKSolverVR.Arm MGPGBCNKPNI, float CFCMGLLFAKB, bool KAPJHDBIFLC, AvatarFullBodyConfiguration NLEDHKLDJJG, float GFACMBMMNPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6AF82E0", Offset = "0x6AF6EE0", VA = "0x186AF82E0")]
		private void AHPJNPPBKGL(IKSolverVR.Arm MGPGBCNKPNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9560", Offset = "0x6AF8160", VA = "0x186AF9560")]
		public void MDOJIHJBAPH(IKSolverVR.Arm MGPGBCNKPNI, Transform LAFDJFCBEPL, Transform DOIMICJLGFG, Quaternion ODMDBJCNMOB, Vector3 PPGFNFIOOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8AA0", Offset = "0x6AF76A0", VA = "0x186AF8AA0")]
		private (Vector3, Quaternion) JCNCOAHFHIH(FNABKOJMJEA IPLLAPBDJCB, Quaternion CNKHLEBOLOO, Vector3 DFFHIDJEJFB)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8320", Offset = "0x6AF6F20", VA = "0x186AF8320")]
		public void BJLIMBLGDDO(FNABKOJMJEA IPLLAPBDJCB, IKSolverVR.Arm MGPGBCNKPNI, Quaternion CNKHLEBOLOO, Vector3 DFFHIDJEJFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8F30", Offset = "0x6AF7B30", VA = "0x186AF8F30")]
		public void JELHPKNBMIJ(FNABKOJMJEA IPLLAPBDJCB, IKSolverVR.Arm MGPGBCNKPNI, Quaternion CNKHLEBOLOO, Vector3 DFFHIDJEJFB, [In] AvatarFullBodyConfiguration NLEDHKLDJJG, [In] LKADDEKMKEF GFCPLDIMNPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8960", Offset = "0x6AF7560", VA = "0x186AF8960")]
		public void EOMJKBICECI(MALAKPJDCFE GOPFFCONNJL, AvatarFullBodyConfiguration NLEDHKLDJJG, LKADDEKMKEF GFCPLDIMNPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6AF8480", Offset = "0x6AF7080", VA = "0x186AF8480")]
		public void DCGOKMGPDDO(IKSolverVR.Arm MGPGBCNKPNI, Transform LAFDJFCBEPL, Vector3 IGGEBCONMDA, float GKLODBMKLPH, Quaternion FAKAGOGLMBD, Vector3 CECLEKIJJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6AF9940", Offset = "0x6AF8540", VA = "0x186AF9940")]
		public GEDHPJFPELL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private enum JEFOEKHIKIE
	{
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct JJEPPMOODLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct AODMMBPBEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly int GICJGBAIEMO;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly int NHCABFMOPDI;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly int LNIKACKKLKL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly int FNEKPKNJEEB;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly int IEJGDDKGPIO;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly int ABHGGMMNAPD;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly int OHEEDJNMFEI;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly int KCCBEOFNLCM;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly int DONLKICCKCG;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly int IJFHIEPANJE;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly int PAPBCLEBJKB;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly int FPKEKGHCKBJ;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly int HKFPIIMPCMB;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly int BKKAEBFMJFJ;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly int LIGGEJHDHHF;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly int BBGMLBMDGBM;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly int JBCEIDKLLIM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static readonly int OBIHEMHBPLO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly int FFCILNOLBIL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly int OFGNIIFBPBJ;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly int LBEFGAFELFH;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly int FLBMEJAPNAB;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private static readonly int FMPDFDGNBBF;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly int HDMEJGECINM;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly int FAAGOJJJOMC;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly int KHPHNMGGDOA;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static readonly int PHAKDICACFN;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly int CDPHOEOINCI;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private static readonly int PLKJIFDDHBN;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static readonly int MKHCOCNMPAG;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private static readonly int OFLNLEEBCKE;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly Vector3 MAKJFNIOAKD;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static readonly int KIMMIFGOLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool MMGBGEGEICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool DAKDEHNKGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool GOEGJFGPNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private bool GOKNEMINNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool OODLKNGAHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool PHJDPLOJONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Vector3 JBIFGJNGGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private string BIJBOGIDEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private DDBEPLLHOKL? BBHHEHPMHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private ONKDENELBMG? CHDFGJLADFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private PKMJKABHHDM BOMHHNPAFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NFHONDKJAEA LLKFKLJPMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private FNABKOJMJEA MJEJDGNNKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private FNABKOJMJEA CPEJHKENLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool ENOFEHHBGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool LMEJLEKHDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly ANMLKMGMKEG OOIAGDDFECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly EEOHMNMPFBL HOIDKNDCKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int PCLPCGKDAHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private float ONLIFNCMLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private GameObject BLMGAIFJIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Transform PJCPBPGHKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Transform BLCMOJHLMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Transform PIGMFCLFPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Transform EMMKMMAHOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private float LJBBPOJDCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private float AAFNFAAGMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Vector3 DGPFBANPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Quaternion OGHBHDLINBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Transform BPMJHLHMKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Transform NNOHOFPJLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Transform IOEGCPFFADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private GBDAFNIGKIP MHGDJMNNKPI;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly ProfilerMarker LAOFHFJJIJH;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly ProfilerMarker EGJNIPIKFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private ProfilerMarker FEAKECDKFIC;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly ProfilerMarker EOCJDDBLNEC;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly ProfilerMarker KKNAEPLIGJB;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly ProfilerMarker LLMLEGENLOL;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly List<OJEKGIEMLCA> JFNMNOEJJPH;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static int KDNGFJBCJIC;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> PLDAKIAAIPL;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static int HFAPMAGJHHL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static int GDBHDBECFEE;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static int NELFHNOLFIK;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static int HDIAOPBCFHD;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static float CHDHPEPEIOK;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static int KPBIEBMNHHH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static float GPJMGLJLCKP;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static float EMAOEMPANKD;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static float IDPJEJNFJDO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static float BFEHIPBNPKH;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static CGIPMGEGDLO LJGLDGGIEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private float HNOJBAFILHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool IMEMIFFDLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float CLOONLACIIC;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int GLJFFCMLCIJ;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int PDMCPDOHPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private FHGGKHFGOEL KBJAOOILOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private FHGGKHFGOEL AFEMJCGDLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float JJNNPJLIPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Vector3 CLJFFKLLLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Vector3 LNJFFMHDDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool ONKOCANEFHL;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly Quaternion FDBBONJDLAK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly Quaternion DHOPLLBEKLE;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly Vector3 HDEMKGLNGLB;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 JCHABNIAEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private float IMOLICINHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float MOPELFBHFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private GEDHPJFPELL COJPLEHFMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private GEDHPJFPELL CKOHCOOPEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private OHPNHKLHOCH JCKHLMAGKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private DDPKLDJFHOI FOKKGOGMODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private readonly LIIEAHIJDCA MDKLEDAKFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private float BEHBEFNCPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private float CAAOJDPFGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly DDPKLDJFHOI JIMKKNJJKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Vector3 GMKOKICGDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Vector3 DDEMCBDCJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private float PEBNEDNOIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private float MGNDOOJDPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly DDPKLDJFHOI GDNIFENEIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly OHPNHKLHOCH MDJKOJDJBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly DDPKLDJFHOI KMIEBDPKBEH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DBHLBOFDKDO HPJIOINOLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DBHLBOFDKDO MHAJOCDGBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AvatarConfiguration JDGBAIKJENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B117E0", Offset = "0x6B103E0", VA = "0x186B117E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CAJNNHABANH AJOKNLHADPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6B11E80", Offset = "0x6B10A80", VA = "0x186B11E80", Slot = "23")]
		get
		{
			return default(CAJNNHABANH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarFullBodyConfiguration HGJHOMJHFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B114B0", Offset = "0x6B100B0", VA = "0x186B114B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Transform BGJCLEBGKNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6B07090", Offset = "0x6B05C90", VA = "0x186B07090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform PPJEPAJHIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B11F80", Offset = "0x6B10B80", VA = "0x186B11F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private SkinnedMeshRenderer LFAKKHBAECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD7F0", Offset = "0x6AFC3F0", VA = "0x186AFD7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Renderer[] AEFDHNEIOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6B124E0", Offset = "0x6B110E0", VA = "0x186B124E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private GameObject[] OCCIIMDNLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6B12230", Offset = "0x6B10E30", VA = "0x186B12230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Animator PJNOIOPGJLF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6B00470", Offset = "0x6AFF070", VA = "0x186B00470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private VRIK MLNMKKGMHGC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6B14290", Offset = "0x6B12E90", VA = "0x186B14290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private MHCAJPGHMFO JBMCJMBHNJH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6B11540", Offset = "0x6B10140", VA = "0x186B11540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private MHCAJPGHMFO CHGHDGMJHII
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFC830", Offset = "0x6AFB430", VA = "0x186AFC830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private MHCAJPGHMFO COJEIDNFDDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6B03180", Offset = "0x6B01D80", VA = "0x186B03180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private MHCAJPGHMFO CCFMPNPIGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CC00", Offset = "0x6B0B800", VA = "0x186B0CC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private MHCAJPGHMFO NEDHADMNLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CB00", Offset = "0x6B0B700", VA = "0x186B0CB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private MHCAJPGHMFO KMFNHGMACOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6B09250", Offset = "0x6B07E50", VA = "0x186B09250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private MHCAJPGHMFO NMJOJOBOFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6AFCC90", Offset = "0x6AFB890", VA = "0x186AFCC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private MHCAJPGHMFO PLIPIPMMKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6B0B620", Offset = "0x6B0A220", VA = "0x186B0B620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ONKDENELBMG JLAJAIJLDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6B01F70", Offset = "0x6B00B70", VA = "0x186B01F70", Slot = "15")]
		get
		{
			return default(ONKDENELBMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GGDKLOOMBAO MNCNPCHJEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB54960", Offset = "0xB53560", VA = "0x180B54960", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public GGKOGEALPJB EJGFHGDGPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1634AD0", Offset = "0x16336D0", VA = "0x181634AD0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GBABJKDKLCB GFHFMLENLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x141CD40", Offset = "0x141B940", VA = "0x18141CD40", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GBABJKDKLCB PAGLHKAONJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x141CD30", Offset = "0x141B930", VA = "0x18141CD30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string KDMDJKONIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private Transform OGNGCEIAAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B03280", Offset = "0x6B01E80", VA = "0x186B03280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private Transform KJKPCCCAKAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B0D4E0", Offset = "0x6B0C0E0", VA = "0x186B0D4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform IKHAKKGOMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B07830", Offset = "0x6B06430", VA = "0x186B07830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool JNHKBBLGKDI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB430", Offset = "0x6AFA030", VA = "0x186AFB430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool OFJLDONILNK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6AFB430", Offset = "0x6AFA030", VA = "0x186AFB430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform KBIIFOPJAFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6AFF200", Offset = "0x6AFDE00", VA = "0x186AFF200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GameObject DKOODDCANLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B09520", Offset = "0x6B08120", VA = "0x186B09520", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public HeadLogicOffsets EBDLMMCDOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B10940", Offset = "0x6B0F540", VA = "0x186B10940", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Transform LEJLPIIFBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xCCEDF0", Offset = "0xCCD9F0", VA = "0x180CCEDF0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Transform NLKOEPGMLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1635DB0", Offset = "0x16349B0", VA = "0x181635DB0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Transform KDJLJEHLHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1636040", Offset = "0x1634C40", VA = "0x181636040", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Transform DGEFFBDDPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1636050", Offset = "0x1634C50", VA = "0x181636050", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Vector3 IAKKPIAHLBF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6AFD280", Offset = "0x6AFBE80", VA = "0x186AFD280", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float MKIKFOMONAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6B118E0", Offset = "0x6B104E0", VA = "0x186B118E0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform FNEFFCNMHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6B06290", Offset = "0x6B04E90", VA = "0x186B06290", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform GKPLBFIOLHI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1635DA0", Offset = "0x16349A0", VA = "0x181635DA0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform BLFKOEENCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBE4550", Offset = "0xBE3150", VA = "0x180BE4550", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Transform HDCGOKFPOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1962380", Offset = "0x1960F80", VA = "0x181962380", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private bool JMDJOGGLCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6B01520", Offset = "0x6B00120", VA = "0x186B01520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool FJIIECBHDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6B01620", Offset = "0x6B00220", VA = "0x186B01620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private bool MKBAEHPAFBD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6B0CA80", Offset = "0x6B0B680", VA = "0x186B0CA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B078A0", Offset = "0x6B064A0", VA = "0x186B078A0")]
	private void IGNABFFJLMF([In] LKADDEKMKEF AFMLNLMOBBJ, [In] AvatarFullBodyConfiguration NLEDHKLDJJG, bool KHOGOKGGFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B01E90", Offset = "0x6B00A90", VA = "0x186B01E90")]
	private float FDAPMBACLFL([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B077B0", Offset = "0x6B063B0", VA = "0x186B077B0")]
	private float IBGHOCPEJMP([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6B07350", Offset = "0x6B05F50", VA = "0x186B07350")]
	private void IBBJIBGFGHE(LKADDEKMKEF AFMLNLMOBBJ, AvatarFullBodyConfiguration NLEDHKLDJJG, bool KHOGOKGGFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6B03A20", Offset = "0x6B02620", VA = "0x186B03A20")]
	private void FOLHDNOLKLN([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBE80", Offset = "0x6AFAA80", VA = "0x186AFBE80")]
	private void AJHBLGNPKAI([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B14D90", Offset = "0x6B13990", VA = "0x186B14D90")]
	public OJEKGIEMLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B00570", Offset = "0x6AFF170", VA = "0x186B00570", Slot = "12")]
	public void CONLAMBLMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6AFDB10", Offset = "0x6AFC710", VA = "0x186AFDB10", Slot = "13")]
	public void CBJGMJHDCHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6B06E20", Offset = "0x6B05A20", VA = "0x186B06E20", Slot = "14")]
	public void HEOELCELPLI(bool LPCPOCANAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B06140", Offset = "0x6B04D40", VA = "0x186B06140", Slot = "25")]
	public Transform GKOICLJIAFB(string COGFFGKCNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6B065A0", Offset = "0x6B051A0", VA = "0x186B065A0", Slot = "26")]
	public Vector3? HBPKMCDFFJB(string COGFFGKCNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B109C0", Offset = "0x6B0F5C0", VA = "0x186B109C0", Slot = "7")]
	public void MJMBGLICDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB330", Offset = "0x6AF9F30", VA = "0x186AFB330")]
	private void AEFLFCBLDDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B14110", Offset = "0x6B12D10", VA = "0x186B14110")]
	private Vector3 PNGHJKHEDAA([In] LKADDEKMKEF GFCPLDIMNPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B0F550", Offset = "0x6B0E150", VA = "0x186B0F550", Slot = "6")]
	public void LCKBLBNOGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB2C0", Offset = "0x6AF9EC0", VA = "0x186AFB2C0", Slot = "8")]
	public void AEDPELHCCBH(float CLAPKHEPNPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B10500", Offset = "0x6B0F100", VA = "0x186B10500")]
	private void LJNFFBBBHHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D550", Offset = "0x6B0C150", VA = "0x186B0D550", Slot = "4")]
	public void KNHANNELFON(string KELJBLOCODC, DDBEPLLHOKL ECPMPIFHGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6B095F0", Offset = "0x6B081F0", VA = "0x186B095F0", Slot = "5")]
	public void JCDMPBNBFHA(ONKDENELBMG OMKEHCNPOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6B09430", Offset = "0x6B08030", VA = "0x186B09430", Slot = "11")]
	public void ILLBIPEDBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6B13980", Offset = "0x6B12580", VA = "0x186B13980", Slot = "24")]
	public void PIGMBIEIAAB([Out] Vector3 MDNCHBKHCFC, [Out] Quaternion FAKAGOGLMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B095C0", Offset = "0x6B081C0", VA = "0x186B095C0")]
	private void IMAFBBEAKDI([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6B12930", Offset = "0x6B11530", VA = "0x186B12930", Slot = "27")]
	public void OKBPIFGKFMI(float LOEEFHLBENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6B125E0", Offset = "0x6B111E0", VA = "0x186B125E0", Slot = "28")]
	public void OEOFAIMMGEG(float NABFNHJNPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BF50", Offset = "0x6B0AB50", VA = "0x186B0BF50", Slot = "44")]
	public void KELJCKDMOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B01F20", Offset = "0x6B00B20", VA = "0x186B01F20", Slot = "29")]
	public void FEHABMBJPHG(bool IHCDDOOKKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B2B0", Offset = "0x6B09EB0", VA = "0x186B0B2B0", Slot = "30")]
	public HandLogicOffsets JICIJFGEILJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B01AF0", Offset = "0x6B006F0", VA = "0x186B01AF0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets EHPCMKFIMKN()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CD00", Offset = "0x6B0B900", VA = "0x186B0CD00")]
	private void KLGFALMHLMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD310", Offset = "0x6AFBF10", VA = "0x186AFD310")]
	private void BFCFBDDLDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B04420", Offset = "0x6B03020", VA = "0x186B04420")]
	private void GFJPJLCLCDF(FKDGABLNLMI HCIELNHCKAM, bool IHBDDDGGBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B01960", Offset = "0x6B00560", VA = "0x186B01960")]
	private void DJLJMOHMOHL(FKDGABLNLMI HCIELNHCKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B03D30", Offset = "0x6B02930", VA = "0x186B03D30")]
	public Vector3 FPCANPNDPDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B04110", Offset = "0x6B02D10", VA = "0x186B04110")]
	private void GCECDOFJGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B00D10", Offset = "0x6AFF910", VA = "0x186B00D10")]
	private void DCEIFGLLNCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B020A0", Offset = "0x6B00CA0", VA = "0x186B020A0")]
	private void FHBDNIECHPP(LKADDEKMKEF AFMLNLMOBBJ, AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B12330", Offset = "0x6B10F30", VA = "0x186B12330")]
	private float OCHEIEABCJM([In] LKADDEKMKEF GFCPLDIMNPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B09350", Offset = "0x6B07F50", VA = "0x186B09350")]
	private int IJOLBOBONHP([In] DIOBHNALJIF MEPFLKOCALB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6AFAD90", Offset = "0x6AF9990", VA = "0x186AFAD90")]
	private void ABGFEFIGCFO(LKADDEKMKEF AFMLNLMOBBJ, bool PGMBJNHDDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B00B00", Offset = "0x6AFF700", VA = "0x186B00B00")]
	private static void CPGFKDPGAIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B09A80", Offset = "0x6B08680", VA = "0x186B09A80")]
	private static void JCEIOILBHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B135D0", Offset = "0x6B121D0", VA = "0x186B135D0")]
	private float PHGLDJFIEML()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD740", Offset = "0x6AFC340", VA = "0x186AFD740")]
	private static int BFKIMHMBKHF(OJEKGIEMLCA KFIDOCPNAED, OJEKGIEMLCA AMMLBECACOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC930", Offset = "0x6AFB530", VA = "0x186AFC930", Slot = "40")]
	public LKADDEKMKEF ALPOPNNBFDE()
	{
		return default(LKADDEKMKEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD770", Offset = "0x6AFC370", VA = "0x186AFD770")]
	public void BLCFIJHCFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6AFD8F0", Offset = "0x6AFC4F0", VA = "0x186AFD8F0")]
	private (bool, bool) CBBKPOHMNIC()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6B13460", Offset = "0x6B12060", VA = "0x186B13460")]
	private (float, float) PFPNBJNEFEG([In] LKADDEKMKEF GFCPLDIMNPM)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6B04710", Offset = "0x6B03310", VA = "0x186B04710")]
	private void GFMAHIPPBAC([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B300", Offset = "0x6B09F00", VA = "0x186B0B300")]
	private void JJIJCJJFAGI([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6AFFA90", Offset = "0x6AFE690", VA = "0x186AFFA90")]
	private void CJBIALFDNMF([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B100E0", Offset = "0x6B0ECE0", VA = "0x186B100E0")]
	private void LHLOABNBJBM([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG, FootSettings MPAGBGMBBLN, bool ECFECMOBPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6AFBF80", Offset = "0x6AFAB80", VA = "0x186AFBF80")]
	private float AJMKEGMLJDJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BFA0", Offset = "0x6B0ABA0", VA = "0x186B0BFA0")]
	private void KGJLMCHKFFH(LKADDEKMKEF GFCPLDIMNPM, AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6B043D0", Offset = "0x6B02FD0", VA = "0x186B043D0")]
	private float GDBIKDINNLO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6AFCD90", Offset = "0x6AFB990", VA = "0x186AFCD90")]
	private void BBJBOMLLNHF([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6B105F0", Offset = "0x6B0F1F0", VA = "0x186B105F0")]
	private void MDOJIHJBAPH([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6B12EA0", Offset = "0x6B11AA0", VA = "0x186B12EA0")]
	private void PEBPOPPMNPH([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6B11200", Offset = "0x6B0FE00", VA = "0x186B11200")]
	private void MLNAPGMNDKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6AFDED0", Offset = "0x6AFCAD0", VA = "0x186AFDED0")]
	private void CDLHKAJFHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6B06EF0", Offset = "0x6B05AF0", VA = "0x186B06EF0")]
	private void HGBNEDHLNMH([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B020", Offset = "0x6B09C20", VA = "0x186B0B020")]
	private void JHJHECBCKCG(FNABKOJMJEA GJMEOOOAFBA, IKSolverVR.Arm MGPGBCNKPNI, Transform PGJJACGNHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B03D80", Offset = "0x6B02980", VA = "0x186B03D80")]
	private void GAPDKIFIKMB(LKADDEKMKEF GFCPLDIMNPM, AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6B137B0", Offset = "0x6B123B0", VA = "0x186B137B0")]
	private void PHMMCJHKLDN(NMMOJJIJEDB INJJBCPKBLE, GBABJKDKLCB GJMEOOOAFBA, IKSolverVR.Arm MGPGBCNKPNI, float CFCMGLLFAKB, float AOHKNECDCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A960", Offset = "0x6B09560", VA = "0x186B0A960")]
	private void JFEOCGJPEOL([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6B13D10", Offset = "0x6B12910", VA = "0x186B13D10")]
	protected void PKEGKGBGKEC([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6B01BB0", Offset = "0x6B007B0", VA = "0x186B01BB0")]
	private void EJIPMILMPFE([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6B016A0", Offset = "0x6B002A0", VA = "0x186B016A0")]
	protected void DILFIGFCJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6AFC000", Offset = "0x6AFAC00", VA = "0x186AFC000")]
	private void AKFFKKNLHHI([In] LKADDEKMKEF GFCPLDIMNPM, [In] JEFOEKHIKIE LCKCBKHFOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6B0A7B0", Offset = "0x6B093B0", VA = "0x186B0A7B0")]
	private void JDAGDILFJHH(LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6B11E40", Offset = "0x6B10A40", VA = "0x186B11E40")]
	private void NNKFPLJOMJN([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6B11930", Offset = "0x6B10530", VA = "0x186B11930")]
	private Vector3 NKKMBPEELBK([In] LKADDEKMKEF GFCPLDIMNPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BDD0", Offset = "0x6B0A9D0", VA = "0x186B0BDD0")]
	private void KCNCFOBIAPM([In] LKADDEKMKEF GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6B12A50", Offset = "0x6B11650", VA = "0x186B12A50")]
	private float PCEMCBBPODK(float GGACOHMLGOO, [In] LKADDEKMKEF GFCPLDIMNPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6B03BE0", Offset = "0x6B027E0", VA = "0x186B03BE0")]
	private void FPABAKNMPOD(float GGACOHMLGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6B06730", Offset = "0x6B05330", VA = "0x186B06730")]
	private void HCCCIPOONHD([In] LKADDEKMKEF GFCPLDIMNPM, JEFOEKHIKIE LCKCBKHFOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6AFE120", Offset = "0x6AFCD20", VA = "0x186AFE120")]
	private float CDOPFCBGNHA([In] LKADDEKMKEF AFMLNLMOBBJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B00D30", Offset = "0x6AFF930", VA = "0x186B00D30")]
	private void DEBCDPIGBMP(LKADDEKMKEF GFCPLDIMNPM, JEFOEKHIKIE LCKCBKHFOAM, Vector3 GIHDEBKJNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B12080", Offset = "0x6B10C80", VA = "0x186B12080")]
	private static void OAOCNAAGAHE(Transform OHCKGBMFMEE, Quaternion EAGKGJHHIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6B0CE60", Offset = "0x6B0BA60", VA = "0x186B0CE60")]
	private void KMHADKBPGJP([In] LKADDEKMKEF GFOMAJAIDKD, [In] DIOBHNALJIF MEPFLKOCALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6B02910", Offset = "0x6B01510", VA = "0x186B02910")]
	private void FHNDNNNMNHG([In] LKADDEKMKEF GFOMAJAIDKD, [In] DIOBHNALJIF MEPFLKOCALB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6AFCAA0", Offset = "0x6AFB6A0", VA = "0x186AFCAA0")]
	private void AMKCMOFLMJF(float AAHLNNLLAND, [In] LKADDEKMKEF AFMLNLMOBBJ, float FIIECCDOEAK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6B032D0", Offset = "0x6B01ED0", VA = "0x186B032D0")]
	private float FOJNFMBPNCL([In] LKADDEKMKEF AFMLNLMOBBJ, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B720", Offset = "0x6B0A320", VA = "0x186B0B720")]
	private void JPHNNJHGOKG([In] LKADDEKMKEF AFMLNLMOBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6AFE8E0", Offset = "0x6AFD4E0", VA = "0x186AFE8E0")]
	private void CGIMOPHFDAK([In] LKADDEKMKEF AFMLNLMOBBJ, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF6E0", Offset = "0x6AFE2E0", VA = "0x186AFF6E0")]
	private void CILKJOAOBPJ([In] LKADDEKMKEF AFMLNLMOBBJ, float GHEPPPCCNMD, float BPJCGDFAJHI, Vector3 HEHKILIIJOK, float FIIECCDOEAK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6AFB480", Offset = "0x6AFA080", VA = "0x186AFB480")]
	private void AIOCKOCLJOK(LKADDEKMKEF AFMLNLMOBBJ, AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6B062F0", Offset = "0x6B04EF0", VA = "0x186B062F0")]
	private void HBHMKOIBKCE(LKADDEKMKEF GFCPLDIMNPM, AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6AFF300", Offset = "0x6AFDF00", VA = "0x186AFF300")]
	private void CHPKCEDBKOG(LKADDEKMKEF AFMLNLMOBBJ, AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6B07190", Offset = "0x6B05D90", VA = "0x186B07190")]
	public void HIJFJAPCOGC([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6B0D190", Offset = "0x6B0BD90", VA = "0x186B0D190")]
	public void KMNEKPACGMD([In] LKADDEKMKEF GFCPLDIMNPM, [In] AvatarFullBodyConfiguration NLEDHKLDJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6B11640", Offset = "0x6B10240", VA = "0x186B11640")]
	[CompilerGenerated]
	internal static void MPODDCGGAIA(Transform FCAIJJGOPCC, IKSolverVR.Arm MGPGBCNKPNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6B0BEA0", Offset = "0x6B0AAA0", VA = "0x186B0BEA0")]
	[CompilerGenerated]
	internal static void KDLMOGEMONJ(Vector3 LOBDNFIDMGA, Vector3 KDPHJPCPCEG, JJEPPMOODLN P_2, AODMMBPBEGC P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6B10550", Offset = "0x6B0F150", VA = "0x186B10550")]
	[CompilerGenerated]
	internal static void LPMFPGADBGJ(FHGGKHFGOEL AADJAKHKFKA, FHGGKHFGOEL GAKKLPGBLJE, Vector3 FJIKKFGJHEC, float IHNODDPNJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B12940", Offset = "0x6B11540", VA = "0x186B12940")]
	[CompilerGenerated]
	internal static bool ONEGLHEMIND(IKSolverVR.Arm MGPGBCNKPNI, CJDBKFLFAIN NPOGHJKFAJL, float CIBBHMLPNFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B0B990", Offset = "0x6B0A590", VA = "0x186B0B990")]
	[CompilerGenerated]
	internal static float KBJDCHEGKLP(Vector3 EEBEKIFGDDI, Vector3 IJNLPHONMDD, Vector3 EGMIGIJKLJK, LKADDEKMKEF AFMLNLMOBBJ, AvatarFullBodyConfiguration NLEDHKLDJJG, float APMEPKJBNGD)
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
		public enum HBCBBHPGHDI
		{
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private HBCBBHPGHDI handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B16890", Offset = "0x6B15490", VA = "0x186B16890")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B16850", Offset = "0x6B15450", VA = "0x186B16850")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6B16250", Offset = "0x6B14E50", VA = "0x186B16250")]
		private void ILMDJPIKCMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A95600", Offset = "0x6A94200", VA = "0x186A95600", Slot = "4")]
		public void SetEnabled(bool DHKFDKHEAMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B168C0", Offset = "0x6B154C0", VA = "0x186B168C0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, HIOOJPKDKGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[Header("Configuration")]
		[SerializeField]
		private CAJNNHABANH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[GBPOFPPCAAP(KOFDDAAAPEO.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		[Header("Configuration")]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		[Header("Facial Animation")]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		[Header("Equipment Slots")]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private LGECBNDMCJN BKEKDAJMJHA;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public LGECBNDMCJN EFIGIHLJKOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA62A10", Offset = "0xA61610", VA = "0x180A62A10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Transform OMCLIGNHNHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6B17780", Offset = "0x6B16380", VA = "0x186B17780", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B168F0", Offset = "0x6B154F0", VA = "0x186B168F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B17640", Offset = "0x6B16240", VA = "0x186B17640")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B175F0", Offset = "0x6B161F0", VA = "0x186B175F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B17580", Offset = "0x6B16180", VA = "0x186B17580")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6B168F0", Offset = "0x6B154F0", VA = "0x186B168F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6B16D80", Offset = "0x6B15980", VA = "0x186B16D80", Slot = "6")]
		public LGECBNDMCJN CreateAvatarSystem(string KELJBLOCODC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6B17580", Offset = "0x6B16180", VA = "0x186B17580", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B169B0", Offset = "0x6B155B0", VA = "0x186B169B0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6B17690", Offset = "0x6B16290", VA = "0x186B17690", Slot = "9")]
		public void UpdatePostIKAnimControllers(float EOJDMAMGKKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class GDGJBMEPBLH : OGEGDGIDHDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Dictionary<string, LGECBNDMCJN> OIDKDJDLKPO;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A130", Offset = "0x6B18D30", VA = "0x186B1A130")]
	[BOLBLOCFHKO.ENGLBNKHCKK]
	internal static void INAOPNHKFGK(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A1A0", Offset = "0x6B18DA0", VA = "0x186B1A1A0", Slot = "4")]
	public LGECBNDMCJN PJAKFNLBLOP(string LMIALKIPMPB, AvatarSystemConfiguration HHLIGGKGFMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6B19E70", Offset = "0x6B18A70", VA = "0x186B19E70", Slot = "5")]
	public void COILFDNEELF(string LMIALKIPMPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6B19FF0", Offset = "0x6B18BF0", VA = "0x186B19FF0", Slot = "6")]
	public string GPHFHDHLAPH(string HDMIIOEJCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B19E00", Offset = "0x6B18A00", VA = "0x186B19E00")]
	private string ALOJCJKAFAO(string HDMIIOEJCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A3C0", Offset = "0x6B18FC0", VA = "0x186B1A3C0")]
	public GDGJBMEPBLH()
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
		public class ALJKLGALKPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private Dictionary<string, Transform> LNLKDODHNMK;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public bool PEBIHPCGOKK
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x6B156A0", Offset = "0x6B142A0", VA = "0x186B156A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6B15570", Offset = "0x6B14170", VA = "0x186B15570")]
			public void EBCJNILBOII(VRIK NJGPIIENJKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
			public void DMBCHBDFEIP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x6B156E0", Offset = "0x6B142E0", VA = "0x186B156E0")]
			public void OMNFNMJPOGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x6B15730", Offset = "0x6B14330", VA = "0x186B15730")]
			public ALJKLGALKPN()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[KMGHLJENBIC(KOFDDAAAPEO.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[GBPOFPPCAAP(KOFDDAAAPEO.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private readonly ALJKLGALKPN GPIHPMIPKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private HIOOJPKDKGI CBGFPJBKFAP;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6B17820", Offset = "0x6B16420", VA = "0x186B17820")]
		private void KMAKNPIEEHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6B177D0", Offset = "0x6B163D0", VA = "0x186B177D0")]
		private bool GHJOLGAGKNB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6B17B00", Offset = "0x6B16700", VA = "0x186B17B00")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6B17B70", Offset = "0x6B16770", VA = "0x186B17B70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6B17B10", Offset = "0x6B16710", VA = "0x186B17B10")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6B17DE0", Offset = "0x6B169E0", VA = "0x186B17DE0")]
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
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x6B1B0B0", Offset = "0x6B19CB0", VA = "0x186B1B0B0")]
			public void CIBOHFMOAPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x6B1B190", Offset = "0x6B19D90", VA = "0x186B1B190")]
			public (float, float) NNEKIHDNLEA(Animator FJIIHMJBFGA, AnimatorStateInfo EDEFPDFPCGM)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6B1B2D0", Offset = "0x6B19ED0", VA = "0x186B1B2D0")]
		public void CIBOHFMOAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6B1B4C0", Offset = "0x6B1A0C0", VA = "0x186B1B4C0")]
		public (float, float) EDALIMJAHLJ(Animator FJIIHMJBFGA)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6B1B6D0", Offset = "0x6B1A2D0", VA = "0x186B1B6D0")]
		private (float, float) MKNIAMKMGCD(Animator FJIIHMJBFGA, AnimatorStateInfo EDEFPDFPCGM)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6B1B8C0", Offset = "0x6B1A4C0", VA = "0x186B1B8C0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CC20", Offset = "0x6B1B820", VA = "0x186B1CC20", Slot = "4")]
		public override void OnStateEnter(Animator FJIIHMJBFGA, AnimatorStateInfo EDEFPDFPCGM, int ICJDBFCOCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6B1CD80", Offset = "0x6B1B980", VA = "0x186B1CD80")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class NAJEICFKKCI<TInput, TOutput> : IJFLDHBFAJL<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	protected readonly PCJJBDFPBKI JKNBMKCLLCJ;

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x463E8A0", Offset = "0x463D4A0", VA = "0x18463E8A0")]
	protected NAJEICFKKCI(PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput ICHKPGLOBMP(TInput GKMKPBACAOC, [Out] IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x463E800", Offset = "0x463D400", VA = "0x18463E800", Slot = "5")]
	public bool MLIHFAGNABH(TInput GKMKPBACAOC, [Out] TOutput? CMNKPAFMHMO, [Out] IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CGPAMFEMIJK]
public static class NNIMEHPOEOK
{
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly Regex HPHEKPOJEBM;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F450", Offset = "0x6B1E050", VA = "0x186B1F450")]
	public static BHFJLHCICBF JPGDFJIOCNE(CBNBPLCDNIL KMAHLCKHOAN, IDJGAJOPJGM BOPBIFPBOIO, Guid? NDNNLJBLELL, Color? HDHDHOLLDAO, BCGODMJDFFO NOIJPBIAGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F2F0", Offset = "0x6B1DEF0", VA = "0x186B1F2F0")]
	public static DMMPCDIHBGH HNONLLBECKK(BHFJLHCICBF BFLLAIFBMAJ)
	{
		return default(DMMPCDIHBGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2F872B0", Offset = "0x2F85EB0", VA = "0x182F872B0")]
	internal static TModern? LLKDBMDCHDD<TModern>(string? GKMKPBACAOC, JEKDCHAMNLK<TModern> ONDNILEECBO, PCJJBDFPBKI JKNBMKCLLCJ, FGPGFCNOCLB JELLDFEOEKL, TModern JNLBCLFOAGC) where TModern : struct, FABBPMKDCKI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2F85CB0", Offset = "0x2F848B0", VA = "0x182F85CB0")]
	internal static BMLODDAIAKC AADJKFONODP<TModern>(string? GKMKPBACAOC, JEKDCHAMNLK<TModern> ONDNILEECBO, PCJJBDFPBKI JKNBMKCLLCJ, FGPGFCNOCLB JELLDFEOEKL, TModern JNLBCLFOAGC) where TModern : struct, FABBPMKDCKI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F660", Offset = "0x6B1E260", VA = "0x186B1F660")]
	internal static List<DBJNMBGJHNF> PMKOAMKPAMI(IEnumerable<KKAGJGBBKHK>? LFPEEBKMMBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2F86490", Offset = "0x2F85090", VA = "0x182F86490")]
	internal static string HPHHAFNAPKK<TModern>(TModern GKMKPBACAOC, JEKDCHAMNLK<TModern> ONDNILEECBO, PCJJBDFPBKI JKNBMKCLLCJ) where TModern : FABBPMKDCKI
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class HGIOAENAIIF : JCEBNIHGDJJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public IJFLDHBFAJL<DHJJMJBLILM, LOGMJPPPGNI> LGOKHIHHICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IJFLDHBFAJL<OJJCFOIIEBB, LDGHCABMLIE> GGAHBLJHJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IJFLDHBFAJL<OJJCFOIIEBB, LDGHCABMLIE> BIGGCPBDCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FKCIJODFJCD GLKFMAGAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KOLBMJCFDCD OPPLONBHLJL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A980", Offset = "0x6B19580", VA = "0x186B1A980")]
	[UsedImplicitly]
	[BOLBLOCFHKO.ENGLBNKHCKK.CLDNNCAHIAO]
	internal static void JMDGAILJKOB(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A9F0", Offset = "0x6B195F0", VA = "0x186B1A9F0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HGIOAENAIIF([JGAMIMHCGFI("UnitySerialization")] BAOKFCCALLB HFGIJIHBEBE, [JGAMIMHCGFI(null)] JMJDDJJLLLD JBELHFJFFOK, [JGAMIMHCGFI(null)] PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum JGAHLLENHEM
{
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AOFBFGFECCP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6B15830", Offset = "0x6B14430", VA = "0x186B15830")]
	public AOFBFGFECCP(string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6B15860", Offset = "0x6B14460", VA = "0x186B15860")]
	public AOFBFGFECCP(string LFKIGNHCOID, Exception NPMCDNGADCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6B15800", Offset = "0x6B14400", VA = "0x186B15800")]
	public AOFBFGFECCP(JGAHLLENHEM BEJBEGCOGFB, string LFKIGNHCOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6B157C0", Offset = "0x6B143C0", VA = "0x186B157C0")]
	public AOFBFGFECCP(JGAHLLENHEM BEJBEGCOGFB, string LFKIGNHCOID, Exception NPMCDNGADCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class DKLALDBBHID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly BAOKFCCALLB HFGIJIHBEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	protected readonly JMJDDJJLLLD JBELHFJFFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	protected readonly PCJJBDFPBKI JKNBMKCLLCJ;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6B19C80", Offset = "0x6B18880", VA = "0x186B19C80")]
	protected DKLALDBBHID(BAOKFCCALLB HFGIJIHBEBE, JMJDDJJLLLD JBELHFJFFOK, PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6B18540", Offset = "0x6B17140", VA = "0x186B18540")]
	protected string JDDOPAMMCMN(LOGMJPPPGNI CKCGPKIPOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B18350", Offset = "0x6B16F50", VA = "0x186B18350")]
	protected string EEOBEMDEBJI(LOGMJPPPGNI CKCGPKIPOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6B19810", Offset = "0x6B18410", VA = "0x186B19810")]
	private AvatarOutfitSelectionData JPGDFJIOCNE(BHFJLHCICBF OFHBDDMMFEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B19B40", Offset = "0x6B18740", VA = "0x186B19B40")]
	private static AvatarCustomizationSettingsData.AnchorParams KFEJIMFFGGC(KLLNLHCALDO? BJJPJDOLFGP)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IJFLDHBFAJL<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput ICHKPGLOBMP(TInput GKMKPBACAOC, [Out] IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MLIHFAGNABH(TInput GKMKPBACAOC, [Out] TOutput? CMNKPAFMHMO, [Out] IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface JCEBNIHGDJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	IJFLDHBFAJL<DHJJMJBLILM, LOGMJPPPGNI> LGOKHIHHICK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	IJFLDHBFAJL<OJJCFOIIEBB, LDGHCABMLIE> BIGGCPBDCNP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FKCIJODFJCD GLKFMAGAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum FGPGFCNOCLB
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KOLBMJCFDCD
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PJILNJOIEHA IMPFBNFMBKJ(LOGMJPPPGNI BFLLAIFBMAJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FKCIJODFJCD
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJJCFOIIEBB IMPFBNFMBKJ(LOGMJPPPGNI BFLLAIFBMAJ, int MDHMFNHCIOG, string? GMBAACDNNFI, string? LEONHHEIAIA, MEMJPCPEGPB JEEDFIDDHGM, List<DBJNMBGJHNF>? EHNLCODOEEE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CGPAMFEMIJK]
internal class LOCBNMJDKGE : NAJEICFKKCI<DHJJMJBLILM, LOGMJPPPGNI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly JMJDDJJLLLD JBELHFJFFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly NIAKCLHAHDB JMMEKJOJNFM;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C360", Offset = "0x6B1AF60", VA = "0x186B1C360")]
	public LOCBNMJDKGE(BAOKFCCALLB HFGIJIHBEBE, JMJDDJJLLLD JBELHFJFFOK, PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C0C0", Offset = "0x6B1ACC0", VA = "0x186B1C0C0", Slot = "6")]
	public override LOGMJPPPGNI ICHKPGLOBMP(DHJJMJBLILM GKMKPBACAOC, [Out] IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class HJFDGKEDNAE : BAOKFCCALLB
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class PGCHFCGFOIH : JsonConverter<BMLODDAIAKC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6B1F960", Offset = "0x6B1E560", VA = "0x186B1F960", Slot = "9")]
		public override void WriteJson(JsonWriter CDCPEBLNAND, BMLODDAIAKC? CABLCDOIFFL, JsonSerializer JMBMMMHNFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6B1F840", Offset = "0x6B1E440", VA = "0x186B1F840", Slot = "10")]
		public override BMLODDAIAKC ReadJson(JsonReader DMECMNHFOBP, Type KNFCMJNOIOG, BMLODDAIAKC? KOLEBPHAPFH, bool ELIFADECOJM, JsonSerializer JMBMMMHNFMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6B1FA00", Offset = "0x6B1E600", VA = "0x186B1FA00")]
		public PGCHFCGFOIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class KHEPPMDMKOL : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool PBGCMHKJKHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6B1BF80", Offset = "0x6B1AB80", VA = "0x186B1BF80", Slot = "5")]
		public override object ReadJson(JsonReader DMECMNHFOBP, Type KNFCMJNOIOG, object? KOLEBPHAPFH, JsonSerializer JMBMMMHNFMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6B1BBC0", Offset = "0x6B1A7C0", VA = "0x186B1BBC0", Slot = "6")]
		public override bool CanConvert(Type KNFCMJNOIOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6B1BFE0", Offset = "0x6B1ABE0", VA = "0x186B1BFE0", Slot = "4")]
		public override void WriteJson(JsonWriter CDCPEBLNAND, object? CABLCDOIFFL, JsonSerializer JMBMMMHNFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1BDA0", Offset = "0x6B1A9A0", VA = "0x186B1BDA0")]
		private static bool HPACEGLOKGE(object CABLCDOIFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
		public KHEPPMDMKOL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly JsonSerializerSettings ILNMHLLMEHO;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6B1AF50", Offset = "0x6B19B50", VA = "0x186B1AF50")]
	internal HJFDGKEDNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2E302F0", Offset = "0x2E2EEF0", VA = "0x182E302F0", Slot = "4")]
	public string ABDAAAGLDEC<T>(T PLAMADMDGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2E30350", Offset = "0x2E2EF50", VA = "0x182E30350", Slot = "5")]
	public T PCOJLOJDPKH<T>(string CABLCDOIFFL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class EPHHHKACBLA : BAOKFCCALLB
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x2C64150", Offset = "0x2C62D50", VA = "0x182C64150", Slot = "4")]
	public string ABDAAAGLDEC<T>(T PLAMADMDGIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x2C641D0", Offset = "0x2C62DD0", VA = "0x182C641D0", Slot = "5")]
	public T PCOJLOJDPKH<T>(string CABLCDOIFFL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public EPHHHKACBLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CGPAMFEMIJK]
internal class NIAKCLHAHDB : NAJEICFKKCI<OJJCFOIIEBB, LDGHCABMLIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly BAOKFCCALLB HFGIJIHBEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly JMJDDJJLLLD JBELHFJFFOK;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6B1F1B0", Offset = "0x6B1DDB0", VA = "0x186B1F1B0")]
	public NIAKCLHAHDB(BAOKFCCALLB HFGIJIHBEBE, JMJDDJJLLLD JBELHFJFFOK, PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D570", Offset = "0x6B1C170", VA = "0x186B1D570", Slot = "6")]
	public override LDGHCABMLIE ICHKPGLOBMP(OJJCFOIIEBB GKMKPBACAOC, [Out] IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E7D0", Offset = "0x6B1D3D0", VA = "0x186B1E7D0")]
	internal void MNLMBDCCBIC(string KEIEBLDBGFP, LOGMJPPPGNI CKCGPKIPOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D0A0", Offset = "0x6B1BCA0", VA = "0x186B1D0A0")]
	public IEnumerable<BHFJLHCICBF> CNAJMDBKNKM(string EDKGIGIHNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D150", Offset = "0x6B1BD50", VA = "0x186B1D150")]
	private IEnumerable<BHFJLHCICBF> DBMMFDEGPDH(string EDKGIGIHNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E380", Offset = "0x6B1CF80", VA = "0x186B1E380")]
	internal IEnumerable<BHFJLHCICBF> KMDBKPIBBDK(string EDKGIGIHNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DCF0", Offset = "0x6B1C8F0", VA = "0x186B1DCF0")]
	private BHFJLHCICBF KKPNBPBEIIP(AvatarOutfitSelectionData OMADBKECIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E930", Offset = "0x6B1D530", VA = "0x186B1E930")]
	private void PCDGEEPCFBO(AvatarCustomizationSettingsData IJGPJBOEDMD, LOGMJPPPGNI CKCGPKIPOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6B1E070", Offset = "0x6B1CC70", VA = "0x186B1E070")]
	private BHFJLHCICBF KKPNBPBEIIP(string AGEEBFFOLMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CDA0", Offset = "0x6B1B9A0", VA = "0x186B1CDA0")]
	internal static (BCGODMJDFFO, string, string) BGOOPKMFANH(string AGEEBFFOLMF, PCJJBDFPBKI JKNBMKCLLCJ)
	{
		return default((BCGODMJDFFO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6B1D990", Offset = "0x6B1C590", VA = "0x186B1D990")]
	private EBEALDMKIMI? KBPBKAEKHLL(string? OCIHAODAEFD, Vector2 HIAMHGJFEON, float PCECEDCIAJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1DB90", Offset = "0x6B1C790", VA = "0x186B1DB90")]
	private static KLLNLHCALDO KEPBJNLKPAK(AvatarCustomizationSettingsData.AnchorParams BIHBEMKOFNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[CGPAMFEMIJK]
internal class MFDIIAPPBFJ : DKLALDBBHID, KOLBMJCFDCD
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6B19C80", Offset = "0x6B18880", VA = "0x186B19C80")]
	public MFDIIAPPBFJ(BAOKFCCALLB HFGIJIHBEBE, JMJDDJJLLLD JBELHFJFFOK, PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C770", Offset = "0x6B1B370", VA = "0x186B1C770", Slot = "4")]
	public PJILNJOIEHA IMPFBNFMBKJ(LOGMJPPPGNI BFLLAIFBMAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CB20", Offset = "0x6B1B720", VA = "0x186B1CB20")]
	private string JDBFHLOKJPD(LOGMJPPPGNI CKCGPKIPOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6B1C530", Offset = "0x6B1B130", VA = "0x186B1C530")]
	private string ENPBLAFANMM(BHFJLHCICBF OFHBDDMMFEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[CGPAMFEMIJK]
internal class GPNADHKEFMH : NAJEICFKKCI<OJJCFOIIEBB, LDGHCABMLIE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly BAOKFCCALLB HFGIJIHBEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly IJFLDHBFAJL<OJJCFOIIEBB, LDGHCABMLIE> NJOOKBIHOOB;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A880", Offset = "0x6B19480", VA = "0x186B1A880")]
	public GPNADHKEFMH(IJFLDHBFAJL<OJJCFOIIEBB, LDGHCABMLIE> NJOOKBIHOOB, PCJJBDFPBKI JKNBMKCLLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6B1A450", Offset = "0x6B19050", VA = "0x186B1A450", Slot = "6")]
	public override LDGHCABMLIE ICHKPGLOBMP(OJJCFOIIEBB GKMKPBACAOC, [Out] IReadOnlyList<DBJNMBGJHNF>? EHNLCODOEEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CGPAMFEMIJK]
internal class BLKFGLJMIIE : FKCIJODFJCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly BAOKFCCALLB HFGIJIHBEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly KOLBMJCFDCD FPJHGPHIADB;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6B18260", Offset = "0x6B16E60", VA = "0x186B18260")]
	public BLKFGLJMIIE(KOLBMJCFDCD FPJHGPHIADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6B17EC0", Offset = "0x6B16AC0", VA = "0x186B17EC0", Slot = "4")]
	public OJJCFOIIEBB IMPFBNFMBKJ(LOGMJPPPGNI BFLLAIFBMAJ, int MDHMFNHCIOG, string? GMBAACDNNFI, string? LEONHHEIAIA, MEMJPCPEGPB JEEDFIDDHGM, List<DBJNMBGJHNF>? EHNLCODOEEE)
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
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6B15940", Offset = "0x6B14540", VA = "0x186B15940")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JEBLLMKOHNK
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B8D0", Offset = "0x6B1A4D0", VA = "0x186B1B8D0")]
	public static DMMPCDIHBGH ICHKPGLOBMP(this JJHIDGABOAN BFLLAIFBMAJ)
	{
		return default(DMMPCDIHBGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6B1BA40", Offset = "0x6B1A640", VA = "0x186B1BA40")]
	public static JJHIDGABOAN IMPFBNFMBKJ(this DMMPCDIHBGH FKBNFPNPPFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6B1B9E0", Offset = "0x6B1A5E0", VA = "0x186B1B9E0")]
	public static bool IFBBFJEGGOL(this DMMPCDIHBGH FKBNFPNPPFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6B1BB60", Offset = "0x6B1A760", VA = "0x186B1BB60")]
	public static bool LNFGEENAGDH(this DMMPCDIHBGH FKBNFPNPPFB)
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
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4EAC620", Offset = "0x4EAB220", VA = "0x184EAC620")]
			public AnchorParams(Vector2 KMGPBBKFCMA, Vector3 FOHGIAEFOKJ, Vector3 JIEAKCOOOOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6B15890", Offset = "0x6B14490", VA = "0x186B15890")]
			internal KLLNLHCALDO IMPFBNFMBKJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private DMLKGCCJOHI useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x6B16130", Offset = "0x6B14D30", VA = "0x186B16130")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3ED9940", Offset = "0x3ED8540", VA = "0x183ED9940")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x1256DD0", Offset = "0x12559D0", VA = "0x181256DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x91A540", Offset = "0x919140", VA = "0x18091A540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB9ABC0", Offset = "0xB997C0", VA = "0x180B9ABC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x6B161D0", Offset = "0x6B14DD0", VA = "0x186B161D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x893C60", Offset = "0x892860", VA = "0x180893C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xA22450", Offset = "0xA21050", VA = "0x180A22450")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x125EE00", Offset = "0x125DA00", VA = "0x18125EE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x88C620", Offset = "0x88B220", VA = "0x18088C620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x88C4B0", Offset = "0x88B0B0", VA = "0x18088C4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x6B16210", Offset = "0x6B14E10", VA = "0x186B16210")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x1FABCA0", Offset = "0x1FAA8A0", VA = "0x181FABCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA62920", Offset = "0xA61520", VA = "0x180A62920")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1061BC0", Offset = "0x10607C0", VA = "0x181061BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x88D710", Offset = "0x88C310", VA = "0x18088D710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x88D700", Offset = "0x88C300", VA = "0x18088D700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x18F0840", Offset = "0x18EF440", VA = "0x1818F0840")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1FC6010", Offset = "0x1FC4C10", VA = "0x181FC6010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8BE910", Offset = "0x8BD510", VA = "0x1808BE910")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8BE970", Offset = "0x8BD570", VA = "0x1808BE970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x88EA10", Offset = "0x88D610", VA = "0x18088EA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x88EAB0", Offset = "0x88D6B0", VA = "0x18088EAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x88E9F0", Offset = "0x88D5F0", VA = "0x18088E9F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x88EAE0", Offset = "0x88D6E0", VA = "0x18088EAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x88E980", Offset = "0x88D580", VA = "0x18088E980")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x88EA80", Offset = "0x88D680", VA = "0x18088EA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x9237D0", Offset = "0x9223D0", VA = "0x1809237D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xC86510", Offset = "0xC85110", VA = "0x180C86510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x88EB20", Offset = "0x88D720", VA = "0x18088EB20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x88E960", Offset = "0x88D560", VA = "0x18088E960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x94DF30", Offset = "0x94CB30", VA = "0x18094DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD0FDD0", Offset = "0xD0E9D0", VA = "0x180D0FDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8963B0", Offset = "0x894FB0", VA = "0x1808963B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x896370", Offset = "0x894F70", VA = "0x180896370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA4D290", Offset = "0xA4BE90", VA = "0x180A4D290")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xBE9840", Offset = "0xBE8440", VA = "0x180BE9840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xC4AC20", Offset = "0xC49820", VA = "0x180C4AC20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x1301BD0", Offset = "0x13007D0", VA = "0x181301BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public DMLKGCCJOHI UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x920F90", Offset = "0x91FB90", VA = "0x180920F90")]
			get
			{
				return default(DMLKGCCJOHI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x91F750", Offset = "0x91E350", VA = "0x18091F750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x91F6A0", Offset = "0x91E2A0", VA = "0x18091F6A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x91F880", Offset = "0x91E480", VA = "0x18091F880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6B161F0", Offset = "0x6B14DF0", VA = "0x186B161F0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6B16230", Offset = "0x6B14E30", VA = "0x186B16230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6B15DD0", Offset = "0x6B149D0", VA = "0x186B15DD0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public BCGODMJDFFO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private IKMBCIMLILF? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x6B177A0", Offset = "0x6B163A0", VA = "0x186B177A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
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
