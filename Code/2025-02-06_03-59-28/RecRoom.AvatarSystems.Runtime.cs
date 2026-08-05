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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7130770", Offset = "0x712F570", VA = "0x187130770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
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
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x714A3C0", Offset = "0x71491C0", VA = "0x18714A3C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2408FF0", Offset = "0x2407DF0", VA = "0x182408FF0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HLDENJBKDHO]
internal class AIHLFAOOJJF : BOAFNHIKBJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GAIPHEGEPKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public AIHLFAOOJJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public ENGPMKLLDHI avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HEBMOEHMHEA KOMPEMCBEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NMACEEKHOED KKFEPLOGGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HBPJLKBFONG KBEOILBDDML;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x712AB60", Offset = "0x7129960", VA = "0x18712AB60")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	[UsedImplicitly]
	internal static void EEDFJDPDFHM(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x712C060", Offset = "0x712AE60", VA = "0x18712C060")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AIHLFAOOJJF([MHFJPMCEEAM(null)] HEBMOEHMHEA KOMPEMCBEAN, [MHFJPMCEEAM(null)] NMACEEKHOED KKFEPLOGGDP, [MHFJPMCEEAM(null)] HBPJLKBFONG KBEOILBDDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x712ABD0", Offset = "0x71299D0", VA = "0x18712ABD0", Slot = "5")]
	public IICGJDJAKCL JNNEAJGAAEH(ENGPMKLLDHI GJAKIONDJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x712B390", Offset = "0x712A190", VA = "0x18712B390", Slot = "4")]
	public IICGJDJAKCL KJOJECFOIJO(ENGPMKLLDHI GJAKIONDJGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x712AA50", Offset = "0x7129850", VA = "0x18712AA50", Slot = "6")]
	public JDDHNOOKCGJ EBKMNKBMAMF(IICGJDJAKCL JOAPLPPIFPC, int CFNGNNDNPAC, string? PPKJBGAOBJL, string? CKLJLDLJILL, DAMMPNMOABG LGONAIKLBOC, List<MIDEEOPAAHG>? FHPJGNJKLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x712BDF0", Offset = "0x712ABF0", VA = "0x18712BDF0", Slot = "7")]
	public bool OHCGHPGENOK(ABIBCFLEEAC AAPOHDKEOON, [Out] IICGJDJAKCL? NDCJJNCPEFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x712A8E0", Offset = "0x71296E0", VA = "0x18712A8E0", Slot = "8")]
	public bool CBLJMAIJJEJ(JDDHNOOKCGJ JDGEIDAONAA, [Out] IICGJDJAKCL? NDCJJNCPEFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x712A9C0", Offset = "0x71297C0", VA = "0x18712A9C0", Slot = "9")]
	public bool CIOBJOMCCKH(JDDHNOOKCGJ JDGEIDAONAA, [Out] PHAIHMHKJOH? AAPOHDKEOON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3A21F50", Offset = "0x3A20D50", VA = "0x183A21F50")]
	private bool KOHDCJOCNHG<TInput, TOutput>(TInput HEILFBEALON, AKLGOFGEMIB<TInput, TOutput> KIPEEHEILMG, [Out] TOutput? LDEANEOLAOA) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x712A740", Offset = "0x7129540", VA = "0x18712A740")]
	[CompilerGenerated]
	private KKINHFDAKCH AEENNELHJOI(FaceFeatureType PHFFGCMCHPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x712BE80", Offset = "0x712AC80", VA = "0x18712BE80")]
	[CompilerGenerated]
	private KKINHFDAKCH OIMBEKDBFCM(FaceFeatureType PHFFGCMCHPI, GAIPHEGEPKC P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HLDENJBKDHO]
internal class KGICOEHHJDO : HEBMOEHMHEA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void CIJLPJKGDED<in TData>(TData NDCJJNCPEFJ, IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HBPJLKBFONG KBEOILBDDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LADPBGMMBAL GLBCCMFAHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CIJLPJKGDED<IICGJDJAKCL>?[] KOMPEMCBEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CIJLPJKGDED<PHAIHMHKJOH>?[] BMAFFFHBCLM;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x712F410", Offset = "0x712E210", VA = "0x18712F410")]
	[UsedImplicitly]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	internal static void EEDFJDPDFHM(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x71303B0", Offset = "0x712F1B0", VA = "0x1871303B0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KGICOEHHJDO([MHFJPMCEEAM(null)] HBPJLKBFONG KBEOILBDDML, [MHFJPMCEEAM(null)] LADPBGMMBAL GLBCCMFAHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7130150", Offset = "0x712EF50", VA = "0x187130150", Slot = "4")]
	public bool PNIKOIKFHFM(IICGJDJAKCL NDCJJNCPEFJ, IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7130250", Offset = "0x712F050", VA = "0x187130250", Slot = "5")]
	public bool PNIKOIKFHFM(PHAIHMHKJOH AAPOHDKEOON, IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x712F4B0", Offset = "0x712E2B0", VA = "0x18712F4B0")]
	private void HOFEJHIHJIC(IICGJDJAKCL NDCJJNCPEFJ, IReadOnlyList<MIDEEOPAAHG>? BHICHJIFLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x712FF20", Offset = "0x712ED20", VA = "0x18712FF20")]
	private void OLCCJFIGIOK(IICGJDJAKCL NDCJJNCPEFJ, IReadOnlyList<MIDEEOPAAHG>? BHICHJIFLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x712F480", Offset = "0x712E280", VA = "0x18712F480")]
	private void FFDLIIDJFNJ(IICGJDJAKCL NDCJJNCPEFJ, IReadOnlyList<MIDEEOPAAHG>? BHICHJIFLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x712FEF0", Offset = "0x712ECF0", VA = "0x18712FEF0")]
	private void NCPBBKIEHOG(IICGJDJAKCL NDCJJNCPEFJ, IReadOnlyList<MIDEEOPAAHG>? BHICHJIFLJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HEBMOEHMHEA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PNIKOIKFHFM(IICGJDJAKCL NDCJJNCPEFJ, IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PNIKOIKFHFM(PHAIHMHKJOH AAPOHDKEOON, IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC);
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
		public GILICCAILEB AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x712C1E0", Offset = "0x712AFE0", VA = "0x18712C1E0")]
		public void HMNLEDDPMJI(AnimationPoseSetting LHMPMCLNOPG, float HFKODMNFOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x712C310", Offset = "0x712B110", VA = "0x18712C310")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		[SerializeField]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
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
		[Cpp2IlInjected.Address(RVA = "0x712CC20", Offset = "0x712BA20", VA = "0x18712CC20")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x712CBE0", Offset = "0x712B9E0", VA = "0x18712CBE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x712C330", Offset = "0x712B130", VA = "0x18712C330")]
		private void IOELKDGGPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x70C3BE0", Offset = "0x70C29E0", VA = "0x1870C3BE0", Slot = "4")]
		public void SetEnabled(bool KKHNIMMKCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x712CC50", Offset = "0x712BA50", VA = "0x18712CC50")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x712CC90", Offset = "0x712BA90", VA = "0x18712CC90")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x381")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Header("Seated animation settings")]
		[Tooltip("How much to twist shoulders when seated.")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Header("Hand Poses")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x43C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Local offset from pelvis to foot center")]
		[Header("Shoe Settings")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x470")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x712CD10", Offset = "0x712BB10", VA = "0x18712CD10")]
		public AnimationPoseSetting FNDLNCLGLFE(GILICCAILEB KLONIABNOOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x712CCD0", Offset = "0x712BAD0", VA = "0x18712CCD0")]
		public void EODJIAICOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x712CD40", Offset = "0x712BB40", VA = "0x18712CD40")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum IJANHJLGHBO
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private IJANHJLGHBO handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x712D810", Offset = "0x712C610", VA = "0x18712D810")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x712D7D0", Offset = "0x712C5D0", VA = "0x18712D7D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x712D1B0", Offset = "0x712BFB0", VA = "0x18712D1B0")]
		private void IOELKDGGPEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70C3BE0", Offset = "0x70C29E0", VA = "0x1870C3BE0", Slot = "4")]
		public void SetEnabled(bool KKHNIMMKCDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x712D840", Offset = "0x712C640", VA = "0x18712D840")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, EILHJGIINON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Header("Configuration")]
		private ENGPMKLLDHI avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[EECICDBJENE(ADIKDNKOEBP.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private HFCEBCMOEFA BDOFLLOBGAI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HFCEBCMOEFA PCGEKFHNDME
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x969210", Offset = "0x968010", VA = "0x180969210", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform EGFCCCDKJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x712E630", Offset = "0x712D430", VA = "0x18712E630", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x712D870", Offset = "0x712C670", VA = "0x18712D870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x712E4F0", Offset = "0x712D2F0", VA = "0x18712E4F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x712E4A0", Offset = "0x712D2A0", VA = "0x18712E4A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x712E430", Offset = "0x712D230", VA = "0x18712E430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x712D870", Offset = "0x712C670", VA = "0x18712D870", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x712DC00", Offset = "0x712CA00", VA = "0x18712DC00", Slot = "6")]
		public HFCEBCMOEFA CreateAvatarSystem(string GLHKGLOFEFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x712E430", Offset = "0x712D230", VA = "0x18712E430", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x712D930", Offset = "0x712C730", VA = "0x18712D930", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x712E540", Offset = "0x712D340", VA = "0x18712E540", Slot = "9")]
		public void UpdatePostIKAnimControllers(float GLDLKCMKFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class PIMOINFLBDK : HFCEBCMOEFA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class EDLMCHJAGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 BBOKLBFMOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Quaternion GOOBJEHHHEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 NLLODKLKDFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Transform AFNIOLMCFDO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 OIMFIHAFHEH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x1C94920", Offset = "0x1C93720", VA = "0x181C94920")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1C94940", Offset = "0x1C93740", VA = "0x181C94940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion OHKKKAONPDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1174A10", Offset = "0x1173810", VA = "0x181174A10")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x1174A00", Offset = "0x1173800", VA = "0x181174A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float GAIIKFMEAHI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xEFA770", Offset = "0xEF9570", VA = "0x180EFA770")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1517B50", Offset = "0x1516950", VA = "0x181517B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool FHDBMFAKIOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8F4200", Offset = "0x8F3000", VA = "0x1808F4200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8F4210", Offset = "0x8F3010", VA = "0x1808F4210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool AMEDAABNPND
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8F4500", Offset = "0x8F3300", VA = "0x1808F4500")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8F44A0", Offset = "0x8F32A0", VA = "0x1808F44A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool KCFKKPDIBGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8F44E0", Offset = "0x8F32E0", VA = "0x1808F44E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8F4340", Offset = "0x8F3140", VA = "0x1808F4340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float PEIOPFPBGAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB10", Offset = "0xB49910", VA = "0x180B4AB10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB4B200", Offset = "0xB4A000", VA = "0x180B4B200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x712EE40", Offset = "0x712DC40", VA = "0x18712EE40")]
		public void GBDLOIJFIAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x712E750", Offset = "0x712D550", VA = "0x18712E750")]
		public void EHPKBFONDIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x712EE50", Offset = "0x712DC50", VA = "0x18712EE50")]
		public float GDEKABGCKMO(Vector3 FLBEFOJPLCP, Quaternion PHOCLIHHPNC, [In] AvatarFootSettings NBIIAEFKJKD, float FODOLHEDAEN)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x712E760", Offset = "0x712D560", VA = "0x18712E760")]
		public void EPILLHCKEBG(Vector3 NFIDBDKEOBN, Quaternion DNMNOKAODKH, Transform IDGCAOJCKEE, float JMJMKADLHJL, bool OHIIDLGMJNJ, bool KCAMJKFONBM, float DNDKADPJMBK, float MJGIAEOCJGJ, Transform DOJENPPADJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x712F060", Offset = "0x712DE60", VA = "0x18712F060")]
		public void GLJBPBLPHDL(Transform MOKGKKOBKIF, Transform DOJENPPADJD, bool EMHFCIMALLM, bool JIPMDJGOAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x712E650", Offset = "0x712D450", VA = "0x18712E650")]
		private void BIIDPNICKNN(Transform DOJENPPADJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x712F290", Offset = "0x712E090", VA = "0x18712F290")]
		public void LONKOKOFGJP(Transform DOJENPPADJD, AvatarFullBodyConfiguration LHCHLNOABPH, Vector3 MCMHGHFEGIG, float AMIDAOBPIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x712F3E0", Offset = "0x712E1E0", VA = "0x18712F3E0")]
		public void NJBAHCBHOLP(float MJGIAEOCJGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x712F400", Offset = "0x712E200", VA = "0x18712F400")]
		public EDLMCHJAGNH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class DEDMHIIEBIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float AHHKCHFPIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool OEMJILFGDJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AnimationPoseSetting GMPLJKGPKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private float AEFDJPPIJKN;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x714D800", Offset = "0x714C600", VA = "0x18714D800")]
		public void LFHOHINBMPM(IKSolverVR.Arm KEHIFHBIOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x714CD50", Offset = "0x714BB50", VA = "0x18714CD50")]
		public void FEIKMCGLGAG(IKSolverVR.Arm KEHIFHBIOHF, float EMMBAJCDLJK, bool OEMJILFGDJN, AvatarFullBodyConfiguration LHCHLNOABPH, float KAHALBDEBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x714C5B0", Offset = "0x714B3B0", VA = "0x18714C5B0")]
		private void BDIBJIAGFNE(IKSolverVR.Arm KEHIFHBIOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x714D830", Offset = "0x714C630", VA = "0x18714D830")]
		public void MIGGJPIJPJB(IKSolverVR.Arm KEHIFHBIOHF, Transform OLOAIOEEBPN, Transform IDGCAOJCKEE, Quaternion DDNPNCFIDDL, Vector3 ILIMHLONJEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x714D370", Offset = "0x714C170", VA = "0x18714D370")]
		private (Vector3, Quaternion) IHLPEJABFEJ(LIKFABAHPMB JPBEJOADEEF, Quaternion HFACIBFPMND, Vector3 MIHKCECHEKL)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x714CBF0", Offset = "0x714B9F0", VA = "0x18714CBF0")]
		public void EIOPDABLBJI(LIKFABAHPMB JPBEJOADEEF, IKSolverVR.Arm KEHIFHBIOHF, Quaternion HFACIBFPMND, Vector3 MIHKCECHEKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x714C5F0", Offset = "0x714B3F0", VA = "0x18714C5F0")]
		public void EHDMAODGACL(LIKFABAHPMB JPBEJOADEEF, IKSolverVR.Arm KEHIFHBIOHF, Quaternion HFACIBFPMND, Vector3 MIHKCECHEKL, [In] AvatarFullBodyConfiguration LHCHLNOABPH, [In] MIJDFMEOCDB DKNLFDPIIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x714CD90", Offset = "0x714BB90", VA = "0x18714CD90")]
		public void FGELMIAPNFL(GILICCAILEB FKCMHEAAKLM, AvatarFullBodyConfiguration LHCHLNOABPH, MIJDFMEOCDB DKNLFDPIIII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x714CED0", Offset = "0x714BCD0", VA = "0x18714CED0")]
		public void FIHBJBGPOJD(IKSolverVR.Arm KEHIFHBIOHF, Transform OLOAIOEEBPN, Vector3 MBEEICPFGHJ, float FDODNPIEGEJ, Quaternion PDLNMFMDJJF, Vector3 OHNFIKLPBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x714DC10", Offset = "0x714CA10", VA = "0x18714DC10")]
		public DEDMHIIEBIG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum PAOPJLICEOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct PBKALCEGFLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NJPIKIHMJPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int ICGACLFCNKP;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int PANBMBOMKDE;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int EMCGANLGCNN;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int BAEPJMEJFAK;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int GPLCPNDMLAI;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int OEDJDAGPOKA;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int NAANJNHAAGE;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int DJBKHKNILLE;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int NENNBAJCMGA;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int OCNCMICKBDH;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int CHHGHKJJAHI;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int PFNGIAGIKAJ;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int HKHPIALGNIO;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int PFGNGOGNOGE;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int OLJMDBBJEFE;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int GANMOLDNNNB;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int DAEKIFBBMIK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int PNBBBAKFCPE;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int CIEAMEDCBHF;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int DOPAAGCGFAP;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int NBGINFFHHLN;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int COMPHGLIMNK;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int NGHLEHGEFCF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int JALGMLAMCCM;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int NGDGMPGAKDC;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int IPGLCHABJJI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int IMEJDFMPJJM;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int GBFJMKEIDAJ;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int EEDBBEIOKNF;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int OBBPDLBKOAK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int IKINNPPAFDE;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly Vector3 LOMINPHEJCI;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int GACFCNHLPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool MPAFHBCNFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool HBIIJKAEGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool CLHCEAHAKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool BANLAGHAIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool DHFDLAAJBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool NICEDMGNANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Vector3 ADKMOEHKKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private string ANACIAIPBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PHBKDCNCEFK? AOMPNCPOCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private EEBIEKIDDMF? PALCLPPBOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private BLEMPJHFGIL OFKOPADJKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private PEMELOCIHLO JAJDLKAKCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private LIKFABAHPMB PAGFBDONEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private LIKFABAHPMB MFHONPEBPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool CBMPFFFHGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool DGFEDOFPAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly COHDCPDGCBP DJFFNMHAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly NFJLPNDHHII MJLGDGNMPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int DBAOLMIKMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private float HBOOALBNJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GameObject EHBNIPFFKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform GBEFOEJCOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform GGCBHJFJGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform PBFLFNPKCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform EBBBLDGIPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float MAEEGIHHKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float IJAGBPBFBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 KEOFIPPDMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Quaternion KGDKNMHCFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform JPAHAMDMEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform LHPLDOEIBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform AJDDJLMDLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private EOHLKAIKBLF PJKCBBLIGPJ;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker DDKBMNDHONM;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker GNCBHIFGNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ProfilerMarker GHGGPDIEICI;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker MCEMGDFJPAB;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker AEJHMGFBIPK;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker DNOGMJPHMMK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly List<PIMOINFLBDK> HMLKPLFJMHC;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int EPAHHEJFPNJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> GNIGBGNCAAO;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static int MAIJAKNMIDJ;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int BGBIDKMAGEL;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int KPKHOFDMGGJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int ODHAIKIOPAF;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float JEBEOMFLDDL;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int OOLAAGMJGOL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static float DEAAHIBPHMC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float EAOPBIAOAFD;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float DNOECEKBAEO;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float HIKFHMJFHNE;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static IBLKNLOPMJI GPEABJIKKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float DDPNFBCGCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool OGNFHAGBLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float OKJJPAMCKBG;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly int BJJHJLGMCMJ;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly int DOKJBJOBPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private EDLMCHJAGNH LIAEMHCMDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private EDLMCHJAGNH DBKJEGIHJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float LJKMAJPDGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Vector3 BDIFPPOLHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Vector3 KMNACOCOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private bool KCMIBLCNNBL;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly Quaternion GOFFAIHMBDE;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly Quaternion FMEHIPAACBG;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly Vector3 LLGALFNDHMA;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Vector3 HFNCLINKADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float OCIMHGJPEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float DHGMEOCLPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private DEDMHIIEBIG DGJAGOKGKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private DEDMHIIEBIG BPKFLMJGOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private CMFLGIOECMD MBLBFKPIEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BKPIEBPMBAO FJIKPELNEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly BJJNDGFMEIE NDFFNBFFFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float ANMGJEJAEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float PHOPJFNPMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly BKPIEBPMBAO GMBHFCGMGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Vector3 PMHJIGDGNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 DGKAPFHLIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float GFGPJMNHMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float PPJABJCBEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly BKPIEBPMBAO PFIBAMPCGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly CMFLGIOECMD HBMDHGIDBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly BKPIEBPMBAO AMPJFCFFGOL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GAMKKEJCIBM GPPJCBFBONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GAMKKEJCIBM JFDKHPAFFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration ECHKFOMFBAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7147140", Offset = "0x7145F40", VA = "0x187147140", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ENGPMKLLDHI CLECPHMEMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x713D7C0", Offset = "0x713C5C0", VA = "0x18713D7C0", Slot = "23")]
		get
		{
			return default(ENGPMKLLDHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration MMLPKHDCLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7138D10", Offset = "0x7137B10", VA = "0x187138D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform ILLFFFFHFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7138F20", Offset = "0x7137D20", VA = "0x187138F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform CIEHIMAEJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7147910", Offset = "0x7146710", VA = "0x187147910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer HMLALJFDNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7133520", Offset = "0x7132320", VA = "0x187133520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] ENEOFGLGMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7146700", Offset = "0x7145500", VA = "0x187146700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] IEIHOIFFDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7141560", Offset = "0x7140360", VA = "0x187141560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator NGIBGLLBJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7147A10", Offset = "0x7146810", VA = "0x187147A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK JJKGKJDKDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x713B890", Offset = "0x713A690", VA = "0x18713B890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private EPMLCLIPPMA MCHJLGKLNLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7148D90", Offset = "0x7147B90", VA = "0x187148D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private EPMLCLIPPMA PJEANPPHPLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71395D0", Offset = "0x71383D0", VA = "0x1871395D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EPMLCLIPPMA HBIIPLJKJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x71406C0", Offset = "0x713F4C0", VA = "0x1871406C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private EPMLCLIPPMA DMLKACPPIBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7139F40", Offset = "0x7138D40", VA = "0x187139F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private EPMLCLIPPMA HLMGHFNKLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7143CA0", Offset = "0x7142AA0", VA = "0x187143CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private EPMLCLIPPMA MGFCJKIAFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x713C870", Offset = "0x713B670", VA = "0x18713C870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private EPMLCLIPPMA BNEIIOPDOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7145C20", Offset = "0x7144A20", VA = "0x187145C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private EPMLCLIPPMA PJJOLDIPKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x71407C0", Offset = "0x713F5C0", VA = "0x1871407C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EEBIEKIDDMF HADOIPMFKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7146E80", Offset = "0x7145C80", VA = "0x187146E80", Slot = "15")]
		get
		{
			return default(EEBIEKIDDMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PHGIHCICACD BIABJLBNCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC8E800", Offset = "0xC8D600", VA = "0x180C8E800", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EKOHFHHJFFI KIFJIADBJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC8E890", Offset = "0xC8D690", VA = "0x180C8E890", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CNGDBOGKMMI DFMCIHBGFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1BC8010", Offset = "0x1BC6E10", VA = "0x181BC8010", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CNGDBOGKMMI ADDJLEPJAOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1BC8000", Offset = "0x1BC6E00", VA = "0x181BC8000", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string HHLCFCKFPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform AIEDGBHAPFC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7141660", Offset = "0x7140460", VA = "0x187141660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform BJDKNBEMHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7139F00", Offset = "0x7138D00", VA = "0x187139F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform JPMHGNBOGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x713CD50", Offset = "0x713BB50", VA = "0x18713CD50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform HLKOAKPILPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7138900", Offset = "0x7137700", VA = "0x187138900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform ABBNKFLHHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7139EC0", Offset = "0x7138CC0", VA = "0x187139EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool LDOCDOHFDHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x71408C0", Offset = "0x713F6C0", VA = "0x1871408C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool DLJLIHDKFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x71408C0", Offset = "0x713F6C0", VA = "0x1871408C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Transform NLJCCIBFDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7146C80", Offset = "0x7145A80", VA = "0x187146C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GameObject IHNPMPCJPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x71307F0", Offset = "0x712F5F0", VA = "0x1871307F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HeadLogicOffsets OBIPCHPHAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7133E80", Offset = "0x7132C80", VA = "0x187133E80", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform ELMCEOOJFON
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1167640", Offset = "0x1166440", VA = "0x181167640", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform OAIOGKHEMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CECEE0", Offset = "0x1CEBCE0", VA = "0x181CECEE0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform KOCFBJJLAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB9B230", Offset = "0xB9A030", VA = "0x180B9B230", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform BHCDBOFMADO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x19D0FC0", Offset = "0x19CFDC0", VA = "0x1819D0FC0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 JPBJALIHNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7144890", Offset = "0x7143690", VA = "0x187144890", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float LBHGFJMAGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7141780", Offset = "0x7140580", VA = "0x187141780", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform EBDHKLHEMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7133840", Offset = "0x7132640", VA = "0x187133840", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform EJCFEEHKONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x201A4D0", Offset = "0x20192D0", VA = "0x18201A4D0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform KJNGAGHIPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x201A4C0", Offset = "0x20192C0", VA = "0x18201A4C0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform MECEJDMGBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19D1B90", Offset = "0x19D0990", VA = "0x1819D1B90", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool IDPBBJEPHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x713BEA0", Offset = "0x713ACA0", VA = "0x18713BEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool AHHGBBPCGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x713BE20", Offset = "0x713AC20", VA = "0x18713BE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool NGNLKBEKBNE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7140CA0", Offset = "0x713FAA0", VA = "0x187140CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7136770", Offset = "0x7135570", VA = "0x187136770")]
	private void DBDAHEHMCCB([In] MIJDFMEOCDB GDMGKHMMHIJ, [In] AvatarFullBodyConfiguration LHCHLNOABPH, bool FHDJPLNIMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7138940", Offset = "0x7137740", VA = "0x187138940")]
	private float DIBIOEBCBCO([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7131900", Offset = "0x7130700", VA = "0x187131900")]
	private float AGFMAGDLHCN([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7133A20", Offset = "0x7132820", VA = "0x187133A20")]
	private void BPEFFNKNOAI(MIJDFMEOCDB GDMGKHMMHIJ, AvatarFullBodyConfiguration LHCHLNOABPH, bool FHDJPLNIMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x713A8C0", Offset = "0x71396C0", VA = "0x18713A8C0")]
	private void EOFBFCMBKKL([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x713AB30", Offset = "0x7139930", VA = "0x18713AB30")]
	private void FHEJNILPOOP([In] MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7149F10", Offset = "0x7148D10", VA = "0x187149F10")]
	public PIMOINFLBDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71309E0", Offset = "0x712F7E0", VA = "0x1871309E0", Slot = "12")]
	public void AFDKFMILNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x713B990", Offset = "0x713A790", VA = "0x18713B990", Slot = "13")]
	public void GGBBOLHMBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x71416B0", Offset = "0x71404B0", VA = "0x1871416B0", Slot = "14")]
	public void KFGFFKOFFPB(bool BKEPBKOCBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7141410", Offset = "0x7140210", VA = "0x187141410", Slot = "25")]
	public Transform KDDKOOHGPLL(string DMOIKPMDPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7134D10", Offset = "0x7133B10", VA = "0x187134D10", Slot = "26")]
	public Vector3? CFDMELJMDPG(string DMOIKPMDPKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x71396D0", Offset = "0x71384D0", VA = "0x1871396D0", Slot = "7")]
	public void EGMOLIJGNHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7146D80", Offset = "0x7145B80", VA = "0x187146D80")]
	private void OACOAKJKMLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x71338A0", Offset = "0x71326A0", VA = "0x1871338A0")]
	private Vector3 BPCPFLGKGBP([In] MIJDFMEOCDB DKNLFDPIIII)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7134290", Offset = "0x7133090", VA = "0x187134290", Slot = "6")]
	public void CEPOBLDKDEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x713BFA0", Offset = "0x713ADA0", VA = "0x18713BFA0", Slot = "8")]
	public void HHFABONJCDC(float MKPLLHEBOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7141A60", Offset = "0x7140860", VA = "0x187141A60")]
	private void KHEGNIIPJHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x713E510", Offset = "0x713D310", VA = "0x18713E510", Slot = "4")]
	public void JHCHEPNMKPB(string GLHKGLOFEFF, PHBKDCNCEFK MONEBDLLCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x71362D0", Offset = "0x71350D0", VA = "0x1871362D0", Slot = "5")]
	public void DBBJGBFGPJK(EEBIEKIDDMF PMECDIABPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7133620", Offset = "0x7132420", VA = "0x187133620", Slot = "11")]
	public void BKCPBIIIKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7140910", Offset = "0x713F710", VA = "0x187140910", Slot = "24")]
	public void JNICMFGBHGO([Out] Vector3 EJEDALGOKIJ, [Out] Quaternion PDLNMFMDJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7148CE0", Offset = "0x7147AE0", VA = "0x187148CE0")]
	private void PHMHCABGNNB([In] MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x713CD40", Offset = "0x713BB40", VA = "0x18713CD40", Slot = "27")]
	public void IBLGIBPAGNA(float LMJDCFENCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7148670", Offset = "0x7147470", VA = "0x187148670", Slot = "28")]
	public void PHBPJAEFEDN(float JOFBCPHODNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7141AB0", Offset = "0x71408B0", VA = "0x187141AB0", Slot = "44")]
	public void KLDDDKEJCIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7131980", Offset = "0x7130780", VA = "0x187131980", Slot = "29")]
	public void AOCHMBHLHMN(bool FAGFKHBGDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7131C60", Offset = "0x7130A60", VA = "0x187131C60", Slot = "30")]
	public HandLogicOffsets BALADLMNCKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7133780", Offset = "0x7132580", VA = "0x187133780", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets BMOMDPHGNOH()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7148D10", Offset = "0x7147B10", VA = "0x187148D10")]
	private void PJJFCGPBLAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7138DA0", Offset = "0x7137BA0", VA = "0x187138DA0")]
	private void ECFCMHLENMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x713D1D0", Offset = "0x713BFD0", VA = "0x18713D1D0")]
	private void IICFEDFIOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x713DF60", Offset = "0x713CD60", VA = "0x18713DF60")]
	private void JCINNMPKDIJ(FHDFMCFBJMM FHLKKMJLIBO, bool CDNOMBACDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7146FB0", Offset = "0x7145DB0", VA = "0x187146FB0")]
	private void OBKOADBAGIB(FHDFMCFBJMM FHLKKMJLIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7148D40", Offset = "0x7147B40", VA = "0x187148D40")]
	public Vector3 PKGFKAFONCM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x713E250", Offset = "0x713D050", VA = "0x18713E250")]
	private void JEEJOAHCLJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7141B80", Offset = "0x7140980", VA = "0x187141B80")]
	private void KPPFGKJEILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x713A040", Offset = "0x7138E40", VA = "0x18713A040")]
	private void ENPNBGPADBA(MIJDFMEOCDB GDMGKHMMHIJ, AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x713D610", Offset = "0x713C410", VA = "0x18713D610")]
	private float ILOEKDBJKIL([In] MIJDFMEOCDB DKNLFDPIIII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7144920", Offset = "0x7143720", VA = "0x187144920")]
	private int MKAECFGEKPB([In] NJFGBINGHJA KOOJNPIAFMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7132FE0", Offset = "0x7131DE0", VA = "0x187132FE0")]
	private void BHBOMOEGDJD(MIJDFMEOCDB GDMGKHMMHIJ, bool JHBIIDNFLOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x71391D0", Offset = "0x7137FD0", VA = "0x1871391D0")]
	private static void EELPMCKIBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7131E70", Offset = "0x7130C70", VA = "0x187131E70")]
	private static void BDFNCNONCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x71393F0", Offset = "0x71381F0", VA = "0x1871393F0")]
	private float EFFGAALFOFN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x713DD20", Offset = "0x713CB20", VA = "0x18713DD20")]
	private static int JBGIKGOIMBB(PIMOINFLBDK PMKFIDCMLAN, PIMOINFLBDK BFOIKIBAAFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x713B650", Offset = "0x713A450", VA = "0x18713B650", Slot = "40")]
	public MIJDFMEOCDB FLBNNJDBDPP()
	{
		return default(MIJDFMEOCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7141B00", Offset = "0x7140900", VA = "0x187141B00")]
	public void KLIPOJFAPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x713DD50", Offset = "0x713CB50", VA = "0x18713DD50")]
	private (bool, bool) JBOBLLFFNNJ()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x713B470", Offset = "0x713A270", VA = "0x18713B470")]
	private (float, float) FJAAOJIDDLK([In] MIJDFMEOCDB DKNLFDPIIII)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7141BA0", Offset = "0x71409A0", VA = "0x187141BA0")]
	private void LAPJJBFJOCD([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x71489C0", Offset = "0x71477C0", VA = "0x1871489C0")]
	private void PHCEPJMCAJC([In] MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7148FA0", Offset = "0x7147DA0", VA = "0x187148FA0")]
	private void PMLNKNKMPOL([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH, AvatarFootSettings NBIIAEFKJKD, bool GDGACPBNBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x713B810", Offset = "0x713A610", VA = "0x18713B810")]
	private float FOGCEIHCIJJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7135740", Offset = "0x7134540", VA = "0x187135740")]
	private void CIIOFPKDKMB(MIJDFMEOCDB DKNLFDPIIII, AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x713B7C0", Offset = "0x713A5C0", VA = "0x18713B7C0")]
	private float FMFFGHFNMDP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7143610", Offset = "0x7142410", VA = "0x187143610")]
	private void LLNPNBFJLHM([In] MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x71445A0", Offset = "0x71433A0", VA = "0x1871445A0")]
	private void MIGGJPIJPJB([In] MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7147CB0", Offset = "0x7146AB0", VA = "0x187147CB0")]
	private void OLMDCIOMLDL([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x713D8C0", Offset = "0x713C6C0", VA = "0x18713D8C0")]
	private void IMHBLINOCIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x713C610", Offset = "0x713B410", VA = "0x18713C610")]
	private void HMPEMBBNFJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7147B10", Offset = "0x7146910", VA = "0x187147B10")]
	private void OJMLPLNKGPA([In] MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x71469F0", Offset = "0x71457F0", VA = "0x1871469F0")]
	private void NMDECLFBABP(LIKFABAHPMB CFKFFBGOOEM, IKSolverVR.Arm KEHIFHBIOHF, Transform LHCFOOJALEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7133F00", Offset = "0x7132D00", VA = "0x187133F00")]
	private void CDFKNJNLGGJ(MIJDFMEOCDB DKNLFDPIIII, AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7143AD0", Offset = "0x71428D0", VA = "0x187143AD0")]
	private void LMAGGCLKJPG(AFLEIIFMJPF OLLCJMEEKHE, CNGDBOGKMMI CFKFFBGOOEM, IKSolverVR.Arm KEHIFHBIOHF, float EMMBAJCDLJK, float AHEKMLHABIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x713C010", Offset = "0x713AE10", VA = "0x18713C010")]
	private void HLCECLJBDLC([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x713C970", Offset = "0x713B770", VA = "0x18713C970")]
	protected void IAKJKKCMCIB([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x71483A0", Offset = "0x71471A0", VA = "0x1871483A0")]
	private void PEILGKEKMAB([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7131A10", Offset = "0x7130810", VA = "0x187131A10")]
	protected void APOOPAENAAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x713AC30", Offset = "0x7139A30", VA = "0x18713AC30")]
	private void FICJMJLHHGD([In] MIJDFMEOCDB DKNLFDPIIII, [In] PAOPJLICEOG OGPJEFFKKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7139020", Offset = "0x7137E20", VA = "0x187139020")]
	private void EEGHOODEKDD(MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x71319D0", Offset = "0x71307D0", VA = "0x1871319D0")]
	private void AONHNDGEJKK([In] MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7135220", Offset = "0x7134020", VA = "0x187135220")]
	private Vector3 CGJKNDOAGMK([In] MIJDFMEOCDB DKNLFDPIIII)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x713BD50", Offset = "0x713AB50", VA = "0x18713BD50")]
	private void GOCGCKMBNDC([In] MIJDFMEOCDB DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x713CD80", Offset = "0x713BB80", VA = "0x18713CD80")]
	private float IHJBENOIBDN(float MJGIAEOCJGJ, [In] MIJDFMEOCDB DKNLFDPIIII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7130890", Offset = "0x712F690", VA = "0x187130890")]
	private void AEAKHOKBNEK(float MJGIAEOCJGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7140D20", Offset = "0x713FB20", VA = "0x187140D20")]
	private void KCGLAODGFJF([In] MIJDFMEOCDB DKNLFDPIIII, PAOPJLICEOG OGPJEFFKKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7138140", Offset = "0x7136F40", VA = "0x187138140")]
	private float DDOOELCLBLK([In] MIJDFMEOCDB GDMGKHMMHIJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7143DA0", Offset = "0x7142BA0", VA = "0x187143DA0")]
	private void MEELNDBCFEE(MIJDFMEOCDB DKNLFDPIIII, PAOPJLICEOG OGPJEFFKKBH, Vector3 GBDENJIIGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x713DB70", Offset = "0x713C970", VA = "0x18713DB70")]
	private static void IMIKLNOCKDK(Transform KAEMFHJNGPI, Quaternion CKABIAOPKPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7147240", Offset = "0x7146040", VA = "0x187147240")]
	private void OFGPDJCOBBL([In] MIJDFMEOCDB CNKPMEJAGLL, [In] NJFGBINGHJA KOOJNPIAFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7144A00", Offset = "0x7143800", VA = "0x187144A00")]
	private void MKAKGEHBFLC([In] MIJDFMEOCDB CNKPMEJAGLL, [In] NJFGBINGHJA KOOJNPIAFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7146800", Offset = "0x7145600", VA = "0x187146800")]
	private void NLANBDJHIMD(float EKCNLPKDKNC, [In] MIJDFMEOCDB GDMGKHMMHIJ, float IFAJJILMMMF = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7145450", Offset = "0x7144250", VA = "0x187145450")]
	private float NALCCGKKEGC([In] MIJDFMEOCDB GDMGKHMMHIJ, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x71480B0", Offset = "0x7146EB0", VA = "0x1871480B0")]
	private void PDEOAENLMBH([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7145D20", Offset = "0x7144B20", VA = "0x187145D20")]
	private void NGOANCMPFNO([In] MIJDFMEOCDB GDMGKHMMHIJ, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7147540", Offset = "0x7146340", VA = "0x187147540")]
	private void OFIGIBKLDMN([In] MIJDFMEOCDB GDMGKHMMHIJ, float LGMOKHLKHOE, float CJAPLADCPBA, Vector3 JOCJBLPNKDM, float IFAJJILMMMF = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7130F00", Offset = "0x712FD00", VA = "0x187130F00")]
	private void AFOPBEDOHBP(MIJDFMEOCDB GDMGKHMMHIJ, AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x71417D0", Offset = "0x71405D0", VA = "0x1871417D0")]
	private void KHDHKMDKEBL(MIJDFMEOCDB DKNLFDPIIII, AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x71389D0", Offset = "0x71377D0", VA = "0x1871389D0")]
	private void DIEALIDPBPM(MIJDFMEOCDB GDMGKHMMHIJ, AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7131CB0", Offset = "0x7130AB0", VA = "0x187131CB0")]
	public void BDEPPBDANDN([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7134EB0", Offset = "0x7133CB0", VA = "0x187134EB0")]
	public void CGELIFLDBGP([In] MIJDFMEOCDB DKNLFDPIIII, [In] AvatarFullBodyConfiguration LHCHLNOABPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x71452B0", Offset = "0x71440B0", VA = "0x1871452B0")]
	[CompilerGenerated]
	internal static void MKHNLPIJFAE(Transform BKEPLGJNEJH, IKSolverVR.Arm KEHIFHBIOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x713AA80", Offset = "0x7139880", VA = "0x18713AA80")]
	[CompilerGenerated]
	internal static void FECIJDIHEPD(Vector3 AOMNNLEDNAG, Vector3 DAFFMOJBOIC, PBKALCEGFLO P_2, NJPIKIHMJPD P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x71493C0", Offset = "0x71481C0", VA = "0x1871493C0")]
	[CompilerGenerated]
	internal static void PODAIOCDGNC(EDLMCHJAGNH KOBCCMAGEGP, EDLMCHJAGNH DJCCBOBJCHH, Vector3 MDDJPFPBKEI, float LKNDCPLLKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7148E90", Offset = "0x7147C90", VA = "0x187148E90")]
	[CompilerGenerated]
	internal static bool PLKKNLOIFCG(IKSolverVR.Arm KEHIFHBIOHF, FCPNONNPCCI DGPFICEJIPC, float EBOGFFIJLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7132BA0", Offset = "0x71319A0", VA = "0x187132BA0")]
	[CompilerGenerated]
	internal static float BDFNFKDCFDK(Vector3 MOADIGCCFIF, Vector3 HCBJAEDNMDN, Vector3 LKHIGOOOEEJ, MIJDFMEOCDB GDMGKHMMHIJ, AvatarFullBodyConfiguration LHCHLNOABPH, float DACBEFNKNPO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class GEPGCOGEHIK : ILJGGGHNIIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<string, HFCEBCMOEFA> AJMJBLJBJPG;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x714E3A0", Offset = "0x714D1A0", VA = "0x18714E3A0")]
	[FOLINPJCBJN.HMBDLNHFFEJ]
	internal static void PLDNPPOECPI(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x714DDF0", Offset = "0x714CBF0", VA = "0x18714DDF0", Slot = "4")]
	public HFCEBCMOEFA KADHICCMAHN(string MLGJJJGOFGD, AvatarSystemConfiguration MGICCGEPGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x714E1C0", Offset = "0x714CFC0", VA = "0x18714E1C0", Slot = "5")]
	public void OFAJANILABG(string MLGJJJGOFGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x714E010", Offset = "0x714CE10", VA = "0x18714E010", Slot = "6")]
	public string KLLPJFAJDIC(string BIDCJNPKMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x714E150", Offset = "0x714CF50", VA = "0x18714E150")]
	private string KMMLNLFAPAP(string BIDCJNPKMLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x714E410", Offset = "0x714D210", VA = "0x18714E410")]
	public GEPGCOGEHIK()
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
		public class MAPAEELKFEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private Dictionary<string, Transform> ADADFMCKJBC;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool HDHDIACPLJG
			{
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x7153FE0", Offset = "0x7152DE0", VA = "0x187153FE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7153E60", Offset = "0x7152C60", VA = "0x187153E60")]
			public void EAKIAOFGNEL(VRIK LDCHHKDHLHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
			public void EHHLLOAOOCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7153F90", Offset = "0x7152D90", VA = "0x187153F90")]
			public void GCNCDDFOOKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7154020", Offset = "0x7152E20", VA = "0x187154020")]
			public MAPAEELKFEF()
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
		[IAEEMABIONI(ADIKDNKOEBP.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[EECICDBJENE(ADIKDNKOEBP.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly MAPAEELKFEF MEDKBJIKOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private EILHJGIINON FDJEMALBPJN;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x714B6B0", Offset = "0x714A4B0", VA = "0x18714B6B0")]
		private void JEELJGCJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x714B660", Offset = "0x714A460", VA = "0x18714B660")]
		private bool FAECBAJECEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x714B990", Offset = "0x714A790", VA = "0x18714B990")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x714BA00", Offset = "0x714A800", VA = "0x18714BA00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x714B9A0", Offset = "0x714A7A0", VA = "0x18714B9A0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x714BC70", Offset = "0x714AA70", VA = "0x18714BC70")]
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

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7152EE0", Offset = "0x7151CE0", VA = "0x187152EE0")]
			public void EODJIAICOIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7152FC0", Offset = "0x7151DC0", VA = "0x187152FC0")]
			public (float, float) OPAAILBFGGB(Animator PGHCNKPLHCP, AnimatorStateInfo KDOFMGIPPEO)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
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

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7153100", Offset = "0x7151F00", VA = "0x187153100")]
		public void EODJIAICOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x71532F0", Offset = "0x71520F0", VA = "0x1871532F0")]
		public (float, float) GAAOBGFACFJ(Animator PGHCNKPLHCP)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7153500", Offset = "0x7152300", VA = "0x187153500")]
		private (float, float) KOKJHLBCFMC(Animator PGHCNKPLHCP, AnimatorStateInfo KDOFMGIPPEO)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x71536F0", Offset = "0x71524F0", VA = "0x1871536F0")]
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

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x71547A0", Offset = "0x71535A0", VA = "0x1871547A0", Slot = "4")]
		public override void OnStateEnter(Animator PGHCNKPLHCP, AnimatorStateInfo KDOFMGIPPEO, int HENJHMIPPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7154910", Offset = "0x7153710", VA = "0x187154910")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class DDPADBPDAMK<TInput, TOutput> : AKLGOFGEMIB<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected readonly LADPBGMMBAL GLBCCMFAHHB;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x60F7700", Offset = "0x60F6500", VA = "0x1860F7700")]
	protected DDPADBPDAMK(LADPBGMMBAL GLBCCMFAHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput FEIAPADJKML(TInput HEILFBEALON, [Out] IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x60F7660", Offset = "0x60F6460", VA = "0x1860F7660", Slot = "5")]
	public bool KOHDCJOCNHG(TInput HEILFBEALON, [Out] TOutput? LDEANEOLAOA, [Out] IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HLDENJBKDHO]
public static class OGONOMEAIAB
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly Regex EKOOHAICDCG;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7154BE0", Offset = "0x71539E0", VA = "0x187154BE0")]
	public static ABGDFPPCFIJ NDIFHDCOKOL(ENMEILKFHJI ACBJHMKLEKN, FFOIEOOLOLI HEKMOBKJILA, Guid? BPPLGODLNGD, Color? KMHACBPNALJ, GKHPEMHLGJO DNGHOGLAIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7154A80", Offset = "0x7153880", VA = "0x187154A80")]
	public static INIBBLLDHHA IDMMMPMKCEL(ABGDFPPCFIJ JOAPLPPIFPC)
	{
		return default(INIBBLLDHHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3485E40", Offset = "0x3484C40", VA = "0x183485E40")]
	internal static TModern? MAGKCNLJKKF<TModern>(string? HEILFBEALON, EKGHAOGKIJN<TModern> DBIDEIEPIMO, LADPBGMMBAL GLBCCMFAHHB, FMOINCBLGBD CBEAKDLIMGP, TModern KKPOJHMGGKO) where TModern : struct, OOGFPHLFINK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3485660", Offset = "0x3484460", VA = "0x183485660")]
	internal static HDMPDCOIAGP KNNAAGKFCNJ<TModern>(string? HEILFBEALON, EKGHAOGKIJN<TModern> DBIDEIEPIMO, LADPBGMMBAL GLBCCMFAHHB, FMOINCBLGBD CBEAKDLIMGP, TModern KKPOJHMGGKO) where TModern : struct, OOGFPHLFINK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7154930", Offset = "0x7153730", VA = "0x187154930")]
	internal static List<MIDEEOPAAHG> HENGLHEMINL(IEnumerable<FDBEIAJCOLB>? HIODDJFDJCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x34847E0", Offset = "0x34835E0", VA = "0x1834847E0")]
	internal static string GBAECPKEADP<TModern>(TModern HEILFBEALON, EKGHAOGKIJN<TModern> DBIDEIEPIMO, LADPBGMMBAL GLBCCMFAHHB) where TModern : OOGFPHLFINK
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class CGIDKEHDJJH : NMACEEKHOED
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public AKLGOFGEMIB<ABIBCFLEEAC, IICGJDJAKCL> NAIADOPPBCF
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public AKLGOFGEMIB<JDDHNOOKCGJ, PHAIHMHKJOH> ABPPDICHFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public AKLGOFGEMIB<JDDHNOOKCGJ, PHAIHMHKJOH> KNFBJMMCJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public AHDLPKPLPJG FEMLLNFALFO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public GCKKMBNGGOD ENHMBIGDGFF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x714BD50", Offset = "0x714AB50", VA = "0x18714BD50")]
	[FOLINPJCBJN.HMBDLNHFFEJ.EKAOCHOMHGE]
	[UsedImplicitly]
	internal static void EEDFJDPDFHM(IEPIHLKICIO BCNFHKMHIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x714BDC0", Offset = "0x714ABC0", VA = "0x18714BDC0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CGIDKEHDJJH([MHFJPMCEEAM("UnitySerialization")] KBNENBEFJAN GNBGAEDBFCA, [MHFJPMCEEAM(null)] PGNMPPJCBIM OFJNAFEEFDI, [MHFJPMCEEAM(null)] LADPBGMMBAL GLBCCMFAHHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum OFGDDHHCPPF
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
public class IHAFFNNMBEP : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7153BD0", Offset = "0x71529D0", VA = "0x187153BD0")]
	public IHAFFNNMBEP(string KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7153C00", Offset = "0x7152A00", VA = "0x187153C00")]
	public IHAFFNNMBEP(string KKBJAPCBOHH, Exception KHOADBPHPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7153C30", Offset = "0x7152A30", VA = "0x187153C30")]
	public IHAFFNNMBEP(OFGDDHHCPPF KAKBGJICBGD, string KKBJAPCBOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7153B90", Offset = "0x7152990", VA = "0x187153B90")]
	public IHAFFNNMBEP(OFGDDHHCPPF KAKBGJICBGD, string KKBJAPCBOHH, Exception KHOADBPHPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class GGBEEDEPDDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly KBNENBEFJAN GNBGAEDBFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly PGNMPPJCBIM OFJNAFEEFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly LADPBGMMBAL GLBCCMFAHHB;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x714FE00", Offset = "0x714EC00", VA = "0x18714FE00")]
	protected GGBEEDEPDDJ(KBNENBEFJAN GNBGAEDBFCA, PGNMPPJCBIM OFJNAFEEFDI, LADPBGMMBAL GLBCCMFAHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x714E4A0", Offset = "0x714D2A0", VA = "0x18714E4A0")]
	protected string HHLKBEAIDIG(IICGJDJAKCL NDCJJNCPEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x714F7B0", Offset = "0x714E5B0", VA = "0x18714F7B0")]
	protected string JMOLDBCHAPF(IICGJDJAKCL NDCJJNCPEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x714FAD0", Offset = "0x714E8D0", VA = "0x18714FAD0")]
	private AvatarOutfitSelectionData NDIFHDCOKOL(ABGDFPPCFIJ MMBGLGBGIFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x714F990", Offset = "0x714E790", VA = "0x18714F990")]
	private static AvatarCustomizationSettingsData.AnchorParams KGFMGGBNOAG(PACDKMEJBDN? EPGICENMKCD)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface AKLGOFGEMIB<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput FEIAPADJKML(TInput HEILFBEALON, [Out] IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KOHDCJOCNHG(TInput HEILFBEALON, [Out] TOutput? LDEANEOLAOA, [Out] IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NMACEEKHOED
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	AKLGOFGEMIB<ABIBCFLEEAC, IICGJDJAKCL> NAIADOPPBCF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	AKLGOFGEMIB<JDDHNOOKCGJ, PHAIHMHKJOH> KNFBJMMCJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	AHDLPKPLPJG FEMLLNFALFO
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum FMOINCBLGBD
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface GCKKMBNGGOD
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FIANECLMANC NPIKEPIONAB(IICGJDJAKCL JOAPLPPIFPC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface AHDLPKPLPJG
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JDDHNOOKCGJ NPIKEPIONAB(IICGJDJAKCL JOAPLPPIFPC, int CFNGNNDNPAC, string? PPKJBGAOBJL, string? CKLJLDLJILL, DAMMPNMOABG LGONAIKLBOC, List<MIDEEOPAAHG>? FHPJGNJKLPC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[HLDENJBKDHO]
internal class HPNNBLOHPGF : DDPADBPDAMK<ABIBCFLEEAC, IICGJDJAKCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly PGNMPPJCBIM OFJNAFEEFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly HPMLKGMHHKE PLAHCPPMMIG;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7152D10", Offset = "0x7151B10", VA = "0x187152D10")]
	public HPNNBLOHPGF(KBNENBEFJAN GNBGAEDBFCA, PGNMPPJCBIM OFJNAFEEFDI, LADPBGMMBAL GLBCCMFAHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7152A60", Offset = "0x7151860", VA = "0x187152A60", Slot = "6")]
	public override IICGJDJAKCL FEIAPADJKML(ABIBCFLEEAC HEILFBEALON, [Out] IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class DKAFMMGCPJD : KBNENBEFJAN
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class JAJLIMBJEKM : JsonConverter<HDMPDCOIAGP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7153D80", Offset = "0x7152B80", VA = "0x187153D80", Slot = "9")]
		public override void WriteJson(JsonWriter FEBAHPCKNJP, HDMPDCOIAGP? IPHILEOFJLB, JsonSerializer OJBOLHCJOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7153C60", Offset = "0x7152A60", VA = "0x187153C60", Slot = "10")]
		public override HDMPDCOIAGP ReadJson(JsonReader GGBMOFKDHMN, Type EFLHIFHHPPE, HDMPDCOIAGP? IMPPLFDBNDE, bool AJIIELDAIDH, JsonSerializer OJBOLHCJOOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7153E20", Offset = "0x7152C20", VA = "0x187153E20")]
		public JAJLIMBJEKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class AHGBPPEFFKA : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool BMNGOGFGEAN
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x714AAE0", Offset = "0x71498E0", VA = "0x18714AAE0", Slot = "5")]
		public override object ReadJson(JsonReader GGBMOFKDHMN, Type EFLHIFHHPPE, object? IMPPLFDBNDE, JsonSerializer OJBOLHCJOOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x714A700", Offset = "0x7149500", VA = "0x18714A700", Slot = "6")]
		public override bool CanConvert(Type EFLHIFHHPPE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x714AB40", Offset = "0x7149940", VA = "0x18714AB40", Slot = "4")]
		public override void WriteJson(JsonWriter FEBAHPCKNJP, object? IPHILEOFJLB, JsonSerializer OJBOLHCJOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x714A8E0", Offset = "0x71496E0", VA = "0x18714A8E0")]
		private static bool OLLGJMGDOEA(object IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public AHGBPPEFFKA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings PLJONEDBEPF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x714DC90", Offset = "0x714CA90", VA = "0x18714DC90")]
	internal DKAFMMGCPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3145140", Offset = "0x3143F40", VA = "0x183145140", Slot = "4")]
	public string AOBKHOELEKM<T>(T JOOHPPHJKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x31451A0", Offset = "0x3143FA0", VA = "0x1831451A0", Slot = "5")]
	public T PCPHFCIHPMJ<T>(string IPHILEOFJLB)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class IFDNDGHHJCA : KBNENBEFJAN
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x32E9C10", Offset = "0x32E8A10", VA = "0x1832E9C10", Slot = "4")]
	public string AOBKHOELEKM<T>(T JOOHPPHJKMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x32E9C90", Offset = "0x32E8A90", VA = "0x1832E9C90", Slot = "5")]
	public T PCPHFCIHPMJ<T>(string IPHILEOFJLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public IFDNDGHHJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HLDENJBKDHO]
internal class HPMLKGMHHKE : DDPADBPDAMK<JDDHNOOKCGJ, PHAIHMHKJOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly KBNENBEFJAN GNBGAEDBFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly PGNMPPJCBIM OFJNAFEEFDI;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x7152920", Offset = "0x7151720", VA = "0x187152920")]
	public HPMLKGMHHKE(KBNENBEFJAN GNBGAEDBFCA, PGNMPPJCBIM OFJNAFEEFDI, LADPBGMMBAL GLBCCMFAHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x71511D0", Offset = "0x714FFD0", VA = "0x1871511D0", Slot = "6")]
	public override PHAIHMHKJOH FEIAPADJKML(JDDHNOOKCGJ HEILFBEALON, [Out] IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7150920", Offset = "0x714F720", VA = "0x187150920")]
	internal void EGDMKALAFFK(string JLNLNBDADNF, IICGJDJAKCL NDCJJNCPEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7150A70", Offset = "0x714F870", VA = "0x187150A70")]
	public IEnumerable<ABGDFPPCFIJ> EGIGHDAHNDD(string FGGIHENCKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7152500", Offset = "0x7151300", VA = "0x187152500")]
	private IEnumerable<ABGDFPPCFIJ> PCGHDFLMNCM(string FGGIHENCKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x71504B0", Offset = "0x714F2B0", VA = "0x1871504B0")]
	internal IEnumerable<ABGDFPPCFIJ> EBIGGIDHOGN(string FGGIHENCKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7150B20", Offset = "0x714F920", VA = "0x187150B20")]
	private ABGDFPPCFIJ EIPJONGMBNB(AvatarOutfitSelectionData HNLDGKDPODI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7151B00", Offset = "0x7150900", VA = "0x187151B00")]
	private void MIEOGDLPHMC(AvatarCustomizationSettingsData IBIIIPEONKM, IICGJDJAKCL NDCJJNCPEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7150EB0", Offset = "0x714FCB0", VA = "0x187150EB0")]
	private ABGDFPPCFIJ EIPJONGMBNB(string IEHLHFEMHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7151800", Offset = "0x7150600", VA = "0x187151800")]
	internal static (GKHPEMHLGJO, string, string) HMHOJFBLNMF(string IEHLHFEMHLK, LADPBGMMBAL GLBCCMFAHHB)
	{
		return default((GKHPEMHLGJO, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7151600", Offset = "0x7150400", VA = "0x187151600")]
	private KKINHFDAKCH? HKFOBMDDKDB(string? OGOMDMBFOMG, Vector2 NGACLEMKAKC, float FKHIAEDEHMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x71523A0", Offset = "0x71511A0", VA = "0x1871523A0")]
	private static PACDKMEJBDN NFAOAIECBJB(AvatarCustomizationSettingsData.AnchorParams HEEDCEFGPEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HLDENJBKDHO]
internal class MHGGMLOIHFC : GGBEEDEPDDJ, GCKKMBNGGOD
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x714FE00", Offset = "0x714EC00", VA = "0x18714FE00")]
	public MHGGMLOIHFC(KBNENBEFJAN GNBGAEDBFCA, PGNMPPJCBIM OFJNAFEEFDI, LADPBGMMBAL GLBCCMFAHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x71543F0", Offset = "0x71531F0", VA = "0x1871543F0", Slot = "4")]
	public FIANECLMANC NPIKEPIONAB(IICGJDJAKCL JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x71542F0", Offset = "0x71530F0", VA = "0x1871542F0")]
	private string IJAEMKAFOIK(IICGJDJAKCL NDCJJNCPEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x71540B0", Offset = "0x7152EB0", VA = "0x1871540B0")]
	private string GGPPINAFHAB(ABGDFPPCFIJ MMBGLGBGIFE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[HLDENJBKDHO]
internal class HLPKGBOALKF : DDPADBPDAMK<JDDHNOOKCGJ, PHAIHMHKJOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly KBNENBEFJAN GNBGAEDBFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly AKLGOFGEMIB<JDDHNOOKCGJ, PHAIHMHKJOH> GELCNGBODDJ;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x71503B0", Offset = "0x714F1B0", VA = "0x1871503B0")]
	public HLPKGBOALKF(AKLGOFGEMIB<JDDHNOOKCGJ, PHAIHMHKJOH> GELCNGBODDJ, LADPBGMMBAL GLBCCMFAHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x714FF80", Offset = "0x714ED80", VA = "0x18714FF80", Slot = "6")]
	public override PHAIHMHKJOH FEIAPADJKML(JDDHNOOKCGJ HEILFBEALON, [Out] IReadOnlyList<MIDEEOPAAHG>? FHPJGNJKLPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HLDENJBKDHO]
internal class IFILGBDEJJJ : AHDLPKPLPJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly KBNENBEFJAN GNBGAEDBFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly GCKKMBNGGOD HADGIHAMHAJ;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7153AA0", Offset = "0x71528A0", VA = "0x187153AA0")]
	public IFILGBDEJJJ(GCKKMBNGGOD HADGIHAMHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7153700", Offset = "0x7152500", VA = "0x187153700", Slot = "4")]
	public JDDHNOOKCGJ NPIKEPIONAB(IICGJDJAKCL JOAPLPPIFPC, int CFNGNNDNPAC, string? PPKJBGAOBJL, string? CKLJLDLJILL, DAMMPNMOABG LGONAIKLBOC, List<MIDEEOPAAHG>? FHPJGNJKLPC)
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

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x714ACD0", Offset = "0x7149AD0", VA = "0x18714ACD0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CJAGPGCKPJB
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x714C320", Offset = "0x714B120", VA = "0x18714C320")]
	public static INIBBLLDHHA FEIAPADJKML(this EPPJOKMJMNL JOAPLPPIFPC)
	{
		return default(INIBBLLDHHA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x714C490", Offset = "0x714B290", VA = "0x18714C490")]
	public static EPPJOKMJMNL NPIKEPIONAB(this INIBBLLDHHA JLPLAJMBPPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x714C430", Offset = "0x714B230", VA = "0x18714C430")]
	public static bool HBGCHEGNMNB(this INIBBLLDHHA JLPLAJMBPPI)
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

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x5471CE0", Offset = "0x5470AE0", VA = "0x185471CE0")]
			public AnchorParams(Vector2 CICKNJJCJAA, Vector3 FOGAPCHLMGD, Vector3 AODCFFHHAIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x714AC20", Offset = "0x7149A20", VA = "0x18714AC20")]
			internal PACDKMEJBDN NPIKEPIONAB()
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
		private IOLJGGGKDHL useHelmetHair;

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

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x714B500", Offset = "0x714A300", VA = "0x18714B500")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4AA44B0", Offset = "0x4AA32B0", VA = "0x184AA44B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB72600", Offset = "0xB71400", VA = "0x180B72600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xDA62D0", Offset = "0xDA50D0", VA = "0x180DA62D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x10464E0", Offset = "0x10452E0", VA = "0x1810464E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B30", Offset = "0x8F6930", VA = "0x1808F7B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x714B5B0", Offset = "0x714A3B0", VA = "0x18714B5B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8F9CA0", Offset = "0x8F8AA0", VA = "0x1808F9CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAC8400", Offset = "0xAC7200", VA = "0x180AC8400")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xAC82A0", Offset = "0xAC70A0", VA = "0x180AC82A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8F4280", Offset = "0x8F3080", VA = "0x1808F4280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x714B5F0", Offset = "0x714A3F0", VA = "0x18714B5F0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xCE4AD0", Offset = "0xCE38D0", VA = "0x180CE4AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xEFA730", Offset = "0xEF9530", VA = "0x180EFA730")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x15271A0", Offset = "0x1525FA0", VA = "0x1815271A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8FBB10", Offset = "0x8FA910", VA = "0x1808FBB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8FBB20", Offset = "0x8FA920", VA = "0x1808FBB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1FA6C00", Offset = "0x1FA5A00", VA = "0x181FA6C00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xD0EF50", Offset = "0xD0DD50", VA = "0x180D0EF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x92BF30", Offset = "0x92AD30", VA = "0x18092BF30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x92BF90", Offset = "0x92AD90", VA = "0x18092BF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8FC440", Offset = "0x8FB240", VA = "0x1808FC440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8FC390", Offset = "0x8FB190", VA = "0x1808FC390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8FC450", Offset = "0x8FB250", VA = "0x1808FC450")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8FC3E0", Offset = "0x8FB1E0", VA = "0x1808FC3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8FC330", Offset = "0x8FB130", VA = "0x1808FC330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8FC490", Offset = "0x8FB290", VA = "0x1808FC490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA9F410", Offset = "0xA9E210", VA = "0x180A9F410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1133CC0", Offset = "0x1132AC0", VA = "0x181133CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8FC480", Offset = "0x8FB280", VA = "0x1808FC480")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8FC2E0", Offset = "0x8FB0E0", VA = "0x1808FC2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xB9BD70", Offset = "0xB9AB70", VA = "0x180B9BD70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xCFF660", Offset = "0xCFE460", VA = "0x180CFF660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x904730", Offset = "0x903530", VA = "0x180904730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x904790", Offset = "0x903590", VA = "0x180904790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xAD87F0", Offset = "0xAD75F0", VA = "0x180AD87F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xD01130", Offset = "0xCFFF30", VA = "0x180D01130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB54330", Offset = "0xB53130", VA = "0x180B54330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB50AA0", Offset = "0xB4F8A0", VA = "0x180B50AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public IOLJGGGKDHL UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xDAC540", Offset = "0xDAB340", VA = "0x180DAC540")]
			get
			{
				return default(IOLJGGGKDHL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xDAC310", Offset = "0xDAB110", VA = "0x180DAC310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xDACEE0", Offset = "0xDABCE0", VA = "0x180DACEE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA97680", Offset = "0xA96480", VA = "0x180A97680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x714B5D0", Offset = "0x714A3D0", VA = "0x18714B5D0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x714B610", Offset = "0x714A410", VA = "0x18714B610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x714B160", Offset = "0x7149F60", VA = "0x18714B160")]
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

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
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
		public GKHPEMHLGJO BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private CGADBJIFNLE? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x714B630", Offset = "0x714A430", VA = "0x18714B630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
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

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
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
