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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x735CFC0", Offset = "0x735BBC0", VA = "0x18735CFC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
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
		[Cpp2IlInjected.Address(RVA = "0x7376BA0", Offset = "0x73757A0", VA = "0x187376BA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HJLLPMMDIEM]
internal class KAGFEKJJOOP : JFEBBJALEAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct IAJHFBJBGCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public KAGFEKJJOOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CDKJOLAGBOC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HPONELNHBED GLENCLMILPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BLJDMBCMKOA IGCIEKBJNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NPHCFEAOGIE IOLMCMNCOBO;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x735B270", Offset = "0x7359E70", VA = "0x18735B270")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	[UsedImplicitly]
	internal static void KEKDPLFGAFF(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x735C090", Offset = "0x735AC90", VA = "0x18735C090")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KAGFEKJJOOP([GJMNBPKNJPO(null)] HPONELNHBED GLENCLMILPM, [GJMNBPKNJPO(null)] BLJDMBCMKOA IGCIEKBJNJD, [GJMNBPKNJPO(null)] NPHCFEAOGIE IOLMCMNCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x735A750", Offset = "0x7359350", VA = "0x18735A750", Slot = "5")]
	public DIKMCPOCMGD AFKHJIFCFJP(CDKJOLAGBOC IKFGPFGPALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x735B630", Offset = "0x735A230", VA = "0x18735B630", Slot = "4")]
	public DIKMCPOCMGD PNCCDOCOHPD(CDKJOLAGBOC IKFGPFGPALL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x735AF20", Offset = "0x7359B20", VA = "0x18735AF20", Slot = "6")]
	public DBFGDKELGJC BJMOFBGNPCH(DIKMCPOCMGD LLDJIJICLJF, int MOLBMOPPCBL, string? BGKKCEGMOKH, string? DNAAPJGFADE, MEPGBPIBEBN FLHJBEBOAIC, List<MEFKHEHCGHH>? CCPNLHGKJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x735B030", Offset = "0x7359C30", VA = "0x18735B030", Slot = "7")]
	public bool GGNBEIEDHOM(HBCEOCGAECD MAMECIPAEBA, [Out] DIKMCPOCMGD? MLDPAOODPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x735B4C0", Offset = "0x735A0C0", VA = "0x18735B4C0", Slot = "8")]
	public bool NMEGPEMILJH(DBFGDKELGJC JLHDGLKCDPG, [Out] DIKMCPOCMGD? MLDPAOODPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x735B5A0", Offset = "0x735A1A0", VA = "0x18735B5A0", Slot = "9")]
	public bool ONAPDFBFLMA(DBFGDKELGJC JLHDGLKCDPG, [Out] MBHFDHDMDAC? MAMECIPAEBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x34306A0", Offset = "0x342F2A0", VA = "0x1834306A0")]
	private bool BIPLHKKGPGL<TInput, TOutput>(TInput CPPOMEHPJCH, NJAGLGKGFII<TInput, TOutput> DCECBDDAHMC, [Out] TOutput? HBANOBDOKBJ) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x735B0C0", Offset = "0x7359CC0", VA = "0x18735B0C0")]
	[CompilerGenerated]
	private BHIKMOBHGNK JKAIKHCLCBA(FaceFeatureType FACNBFFLCDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x735B2E0", Offset = "0x7359EE0", VA = "0x18735B2E0")]
	[CompilerGenerated]
	private BHIKMOBHGNK KLOLJEFGGGE(FaceFeatureType FACNBFFLCDI, IAJHFBJBGCA P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HJLLPMMDIEM]
internal class DIDNDCFADEE : HPONELNHBED
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DNNKPOFIAGM<in TData>(TData MLDPAOODPLJ, IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NPHCFEAOGIE IOLMCMNCOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NFPCFNAHBIE PABJDHMLLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DNNKPOFIAGM<DIKMCPOCMGD>?[] GLENCLMILPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DNNKPOFIAGM<MBHFDHDMDAC>?[] FINKDLJAALH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7359660", Offset = "0x7358260", VA = "0x187359660")]
	[UsedImplicitly]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	internal static void KEKDPLFGAFF(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x735A390", Offset = "0x7358F90", VA = "0x18735A390")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DIDNDCFADEE([GJMNBPKNJPO(null)] NPHCFEAOGIE IOLMCMNCOBO, [GJMNBPKNJPO(null)] NFPCFNAHBIE PABJDHMLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7359830", Offset = "0x7358430", VA = "0x187359830", Slot = "4")]
	public bool LCHMPDFHNIJ(DIKMCPOCMGD MLDPAOODPLJ, IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73596D0", Offset = "0x73582D0", VA = "0x1873596D0", Slot = "5")]
	public bool LCHMPDFHNIJ(MBHFDHDMDAC MAMECIPAEBA, IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7359930", Offset = "0x7358530", VA = "0x187359930")]
	private void OPJNCBNLEOC(DIKMCPOCMGD MLDPAOODPLJ, IReadOnlyList<MEFKHEHCGHH>? LOJMCGAMMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7359400", Offset = "0x7358000", VA = "0x187359400")]
	private void CCAOLPMIKGB(DIKMCPOCMGD MLDPAOODPLJ, IReadOnlyList<MEFKHEHCGHH>? LOJMCGAMMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7359630", Offset = "0x7358230", VA = "0x187359630")]
	private void GHKGHPDKGFO(DIKMCPOCMGD MLDPAOODPLJ, IReadOnlyList<MEFKHEHCGHH>? LOJMCGAMMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x735A360", Offset = "0x7358F60", VA = "0x18735A360")]
	private void PNBOCEACFKN(DIKMCPOCMGD MLDPAOODPLJ, IReadOnlyList<MEFKHEHCGHH>? LOJMCGAMMAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface HPONELNHBED
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LCHMPDFHNIJ(DIKMCPOCMGD MLDPAOODPLJ, IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LCHMPDFHNIJ(MBHFDHDMDAC MAMECIPAEBA, IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML);
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
		public DFEFMANKBAC AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7356FD0", Offset = "0x7355BD0", VA = "0x187356FD0")]
		public void ILEJKNBCDPH(AnimationPoseSetting PELBNOCGOOJ, float JEEMBCFNNMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7357100", Offset = "0x7355D00", VA = "0x187357100")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x73579F0", Offset = "0x73565F0", VA = "0x1873579F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x73579B0", Offset = "0x73565B0", VA = "0x1873579B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7357120", Offset = "0x7355D20", VA = "0x187357120")]
		private void EMEDKKEPIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72EFFC0", Offset = "0x72EEBC0", VA = "0x1872EFFC0", Slot = "4")]
		public void SetEnabled(bool BEPIDPDHFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7357A20", Offset = "0x7356620", VA = "0x187357A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7357A60", Offset = "0x7356660", VA = "0x187357A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7357AE0", Offset = "0x73566E0", VA = "0x187357AE0")]
		public AnimationPoseSetting LKKAAMPABNN(DFEFMANKBAC CEHCJEJACGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7357AA0", Offset = "0x73566A0", VA = "0x187357AA0")]
		public void HGFFJCPBDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7357B10", Offset = "0x7356710", VA = "0x187357B10")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum IAEDHHBDAGL
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private IAEDHHBDAGL handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x73585C0", Offset = "0x73571C0", VA = "0x1873585C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7358580", Offset = "0x7357180", VA = "0x187358580")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7357F80", Offset = "0x7356B80", VA = "0x187357F80")]
		private void EMEDKKEPIEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72EFFC0", Offset = "0x72EEBC0", VA = "0x1872EFFC0", Slot = "4")]
		public void SetEnabled(bool BEPIDPDHFCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x73585F0", Offset = "0x73571F0", VA = "0x1873585F0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, ELFGKMJDHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Header("Configuration")]
		private CDKJOLAGBOC avatarBodyType;

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
		[NEHJBMHDGNH(EGFPEOBPDHA.SelfAndChildren, false, false, false)]
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
		private OFCBGNLPJGC ILJONGFLAPE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public OFCBGNLPJGC AOGFHOELJPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9C85A0", Offset = "0x9C71A0", VA = "0x1809C85A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform CHOIPFKKCPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x73593E0", Offset = "0x7357FE0", VA = "0x1873593E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7358620", Offset = "0x7357220", VA = "0x187358620")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x73592A0", Offset = "0x7357EA0", VA = "0x1873592A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7359250", Offset = "0x7357E50", VA = "0x187359250")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x73591E0", Offset = "0x7357DE0", VA = "0x1873591E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7358620", Offset = "0x7357220", VA = "0x187358620", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x73589B0", Offset = "0x73575B0", VA = "0x1873589B0", Slot = "6")]
		public OFCBGNLPJGC CreateAvatarSystem(string MJJOEJGFEJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x73591E0", Offset = "0x7357DE0", VA = "0x1873591E0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73586E0", Offset = "0x73572E0", VA = "0x1873586E0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x73592F0", Offset = "0x7357EF0", VA = "0x1873592F0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float BLINLOHDAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class PGHFJAOMGLE : OFCBGNLPJGC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class NNLPHCIACNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 GPAGIBGMJAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Quaternion IJEHIPGOAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 KOGDGMAGOPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Transform AGGBOFAAHHK;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 IIEAIGKBGLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x1C81CA0", Offset = "0x1C808A0", VA = "0x181C81CA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1C81CC0", Offset = "0x1C808C0", VA = "0x181C81CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion NEBBGLMMNGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x117D5C0", Offset = "0x117C1C0", VA = "0x18117D5C0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x117D410", Offset = "0x117C010", VA = "0x18117D410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float DIPKEHOOIGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xEDD070", Offset = "0xEDBC70", VA = "0x180EDD070")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1513410", Offset = "0x1512010", VA = "0x181513410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool NIFLOBIMPAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960270", VA = "0x180961670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x961680", Offset = "0x960280", VA = "0x180961680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool PEONDKLJPAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960230", VA = "0x180961630")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x961660", Offset = "0x960260", VA = "0x180961660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool HHCCMJCKKPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x961610", Offset = "0x960210", VA = "0x180961610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x961650", Offset = "0x960250", VA = "0x180961650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float CLPNOKBOAFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB42ED0", Offset = "0xB41AD0", VA = "0x180B42ED0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB43550", Offset = "0xB42150", VA = "0x180B43550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x735CFA0", Offset = "0x735BBA0", VA = "0x18735CFA0")]
		public void NECCMONNALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x735CF70", Offset = "0x735BB70", VA = "0x18735CF70")]
		public void GLOHFOPMLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x735C210", Offset = "0x735AE10", VA = "0x18735C210")]
		public float BFLGKHMGFGP(Vector3 BOENMGEDHKG, Quaternion PAOKPFPGJAN, [In] AvatarFootSettings IFLMEICJBOA, float JHGAEELEOKC)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x735C8A0", Offset = "0x735B4A0", VA = "0x18735C8A0")]
		public void FOMGFCJHCHD(Vector3 HBJMHLLHPLA, Quaternion BEKBJBPDHKG, Transform JMFFCDDOFEA, float HKFAODAODFO, bool MBCOFHONMLD, bool MHAOBJNMAND, float KHPOIHFHIDH, float GIFJBKLGHFG, Transform EBMDCHEPJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x735C670", Offset = "0x735B270", VA = "0x18735C670")]
		public void FJDEIAAGFGO(Transform DOLBOOIMAAN, Transform EBMDCHEPJIM, bool IIPPOJPCEKD, bool OLGEAIODGJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x735C420", Offset = "0x735B020", VA = "0x18735C420")]
		private void BIKAPCEJMNI(Transform EBMDCHEPJIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x735C520", Offset = "0x735B120", VA = "0x18735C520")]
		public void CBKLGDPBJBH(Transform EBMDCHEPJIM, AvatarFullBodyConfiguration BKDMEACEJJF, Vector3 NDAOCACIMEF, float KKJDKMAOLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x735CF80", Offset = "0x735BB80", VA = "0x18735CF80")]
		public void LMPGHAMHDNI(float GIFJBKLGHFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x735CFB0", Offset = "0x735BBB0", VA = "0x18735CFB0")]
		public NNLPHCIACNF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class HHNHJBACEGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float ODILDNAJECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool DCNDGFJBGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AnimationPoseSetting DGDDOEKNIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private float AEAEINLBMGO;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x737A990", Offset = "0x7379590", VA = "0x18737A990")]
		public void PBMOOAMNBBD(IKSolverVR.Arm DEMJMDBKBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x737A9C0", Offset = "0x73795C0", VA = "0x18737A9C0")]
		public void PCFHNJIFBFG(IKSolverVR.Arm DEMJMDBKBJB, float FPIBOMHEHOD, bool DCNDGFJBGOM, AvatarFullBodyConfiguration BKDMEACEJJF, float GCCEPHIJEAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x73794E0", Offset = "0x73780E0", VA = "0x1873794E0")]
		private void GFGNCPKCEEG(IKSolverVR.Arm DEMJMDBKBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x737A110", Offset = "0x7378D10", VA = "0x18737A110")]
		public void LDGJFFKMEHD(IKSolverVR.Arm DEMJMDBKBJB, Transform FCLIOGNDCBK, Transform JMFFCDDOFEA, Quaternion MIFBFKPAAMK, Vector3 BMKCNGIGAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7379B20", Offset = "0x7378720", VA = "0x187379B20")]
		private (Vector3, Quaternion) IBPIKIHHGKC(EOLPLJIAMOM IDOKNIBLCJL, Quaternion EIGKDLPKLGL, Vector3 JEAPAKIBJEP)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7379FB0", Offset = "0x7378BB0", VA = "0x187379FB0")]
		public void JDENPNMKAHP(EOLPLJIAMOM IDOKNIBLCJL, IKSolverVR.Arm DEMJMDBKBJB, Quaternion EIGKDLPKLGL, Vector3 JEAPAKIBJEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7379520", Offset = "0x7378120", VA = "0x187379520")]
		public void HJAMOAMLBHE(EOLPLJIAMOM IDOKNIBLCJL, IKSolverVR.Arm DEMJMDBKBJB, Quaternion EIGKDLPKLGL, Vector3 JEAPAKIBJEP, [In] AvatarFullBodyConfiguration BKDMEACEJJF, [In] ANGHBGIMLKK CMPEMMPBPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x73793A0", Offset = "0x7377FA0", VA = "0x1873793A0")]
		public void CFLKGCDMKII(DFEFMANKBAC EEAPCAMLEPF, AvatarFullBodyConfiguration BKDMEACEJJF, ANGHBGIMLKK CMPEMMPBPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x737A4F0", Offset = "0x73790F0", VA = "0x18737A4F0")]
		public void LHNICCDAIHC(IKSolverVR.Arm DEMJMDBKBJB, Transform FCLIOGNDCBK, Vector3 LHOHKHAKOLD, float FEMNHMKBONI, Quaternion DOMMEIONOMI, Vector3 BPFPKICEPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x737AA00", Offset = "0x7379600", VA = "0x18737AA00")]
		public HHNHJBACEGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum DEKEDINOIKB
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
	private struct MICNDOGJMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct IPIIOPNLHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int PLBGDGJAOGG;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int EHEHGHPCDCM;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int EGKNGHGKCKF;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int PNCLGKFIDGL;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int ILBFFCMJIAB;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int CIJLHGAKFIN;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int LFFHPLIGLOJ;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int BFICHALEFOD;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int BHBBGABJHBH;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int KKCFKLDEJCC;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int NDDJMKPGOBN;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int FILBMCPMHLH;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int KCOELGKPBJI;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int ALMBFAOMPBI;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int EPOPNCHKJNP;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int HCEHHPGHEAL;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int GLJAAPDDOGK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int OEHIPIELBJH;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int OLPMCLFNDKO;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JFOBAMDGOPE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int HJDBLGFJGEI;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int HFLNKGEPOAI;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int HEDLCOLCBOL;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int MGLHBIBOBBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int BGKCHCHIGLJ;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int BAHABENJNFI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int DELPLGGACNG;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int HBLEFAMJDGF;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int EOAMCAJJJDP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int EEJDKBJLPJH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int PGDKCEBFJCH;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly Vector3 OFKJKOBIGKG;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int CEFKGPPJMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool IMKLGKOCCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool FEJFKBGILMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool PPAAFAILLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool LCEHCMKOHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool GEIPEIFCJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool BGPHAEMAAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Vector3 BBKEKMBBJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private string PCKEIJILJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private NGPBJEDFNEL? IBHDKPPEAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private AMGLAECBIJH? NFGCLNBINDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private BIMECJEBEMD MEGGPACIFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private AJJOHEHAHEK CPBIJACNNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private EOLPLJIAMOM NDAPCOAAION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private EOLPLJIAMOM GFGHCLJABKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool OFMKBFGFMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool OFIPAOMJJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly PJFJNOPFDAF DLAPDHBPKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly AHBPHLJEJNL DEJIPCDMAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int HNPKBFCGEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private float BDANJPHPEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GameObject JIKLJMIIEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform OJGEMOGNMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform NBDCPFEHGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform PMBDJNOJFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform HIIPDPOHGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float CDNOKIAOCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float NIMBFDDIINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 FGAOLLNJEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Quaternion FOALJLEGJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform DIFOPKCACAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform DKMAPFPLOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform IAPGNBBODPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private DFALONLPHJD FNJHGOAHFPE;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker IDBBBPICCHH;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker PPLEPMNECGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ProfilerMarker FIPODILJEMK;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker NICBCNDMLPM;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker BOLDCJAPIHK;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker FJBMLJNADOH;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly List<PGHFJAOMGLE> LAANDABBDMO;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int DJOHHPAINEL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> EHCKGBLAKGB;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static int OBNACBEJOCO;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int GBKJBAMICHM;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int KDKPBEEMJBA;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int JOOODOEKGMJ;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float IKOIOBLILHB;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int COMFPLGDPEM;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static float ILJJDMDLHCC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float LGIKDEBBKII;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float LFFKAMOLAFG;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float OPGPJEOCDLG;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static EAOGDADHGEG OLABAMKMINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float LIFAMILODAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool NKNGALJCIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float HMBNHJPHPOO;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly int AHAKLJEPEJF;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly int DCHOEIPLNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private NNLPHCIACNF DPPJHOBJANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private NNLPHCIACNF JDCPGGLOPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float EOMIINKCNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Vector3 FFJMBIANJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Vector3 IKJLDEIOLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private bool FLAJNDPJIDL;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly Quaternion MEGEIAMNJAJ;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly Quaternion GBMHGHEHBBJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly Vector3 PJIGMFENJPC;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Vector3 GMDFMJDFIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float LBKLBPPOOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float PMNPELGICBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private HHNHJBACEGG EDNPENDIOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private HHNHJBACEGG NBOHFGDDBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private FKGKMCGPCHM NKEDDIPDLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BFHANADEOFG FLHKJALKFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly EEHGHOOODLH EODECPJLCCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float HHOEOKDCOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float CFECGHKNLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly BFHANADEOFG MDOMGLGOEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Vector3 FBNLBOACNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 IMNNFPHICGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float KGAFCAPJPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float HHFDGNHGGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly BFHANADEOFG MCOONGBLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly FKGKMCGPCHM MFCFHCBOHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly BFHANADEOFG PJNLOHJBAJM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NCEKLMPIJLO PNDEAKPCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NCEKLMPIJLO HKFGGBIALOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration ENPPDODKLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7372CC0", Offset = "0x73718C0", VA = "0x187372CC0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CDKJOLAGBOC MLGPOAJKFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x736E330", Offset = "0x736CF30", VA = "0x18736E330", Slot = "23")]
		get
		{
			return default(CDKJOLAGBOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration NMMIBGMCEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7367160", Offset = "0x7365D60", VA = "0x187367160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform LAAALGJKMPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7361C90", Offset = "0x7360890", VA = "0x187361C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform KAEMPFFADCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7364980", Offset = "0x7363580", VA = "0x187364980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer OMGALNDKLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7364B80", Offset = "0x7363780", VA = "0x187364B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] MDJDDLACGGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x735D040", Offset = "0x735BC40", VA = "0x18735D040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] MLPPMCMJGCN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73696B0", Offset = "0x73682B0", VA = "0x1873696B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator LPENFHLMLED
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x735D9F0", Offset = "0x735C5F0", VA = "0x18735D9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK LFEEPLIOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7364A80", Offset = "0x7363680", VA = "0x187364A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private LNDEJBPIJIN LMDGGJMDEME
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x736F3A0", Offset = "0x736DFA0", VA = "0x18736F3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private LNDEJBPIJIN EJMJHJGEJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7365C30", Offset = "0x7364830", VA = "0x187365C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private LNDEJBPIJIN AHNEDBEIJDH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x736FC90", Offset = "0x736E890", VA = "0x18736FC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private LNDEJBPIJIN DIFOBFBHKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7367060", Offset = "0x7365C60", VA = "0x187367060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private LNDEJBPIJIN KDEAAAALKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x73684F0", Offset = "0x73670F0", VA = "0x1873684F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private LNDEJBPIJIN DAGAHIIELFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x735DEC0", Offset = "0x735CAC0", VA = "0x18735DEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private LNDEJBPIJIN LMAHKLGDIIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x736C000", Offset = "0x736AC00", VA = "0x18736C000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private LNDEJBPIJIN FBIEIEMFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x735D1A0", Offset = "0x735BDA0", VA = "0x18735D1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AMGLAECBIJH JGGODCDOCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73705F0", Offset = "0x736F1F0", VA = "0x1873705F0", Slot = "15")]
		get
		{
			return default(AMGLAECBIJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DDHFIFHCKBI APJFNONAKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC4F380", Offset = "0xC4DF80", VA = "0x180C4F380", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ANLIIOJHHOE DEKALDBMGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC4F3F0", Offset = "0xC4DFF0", VA = "0x180C4F3F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public FLDOCHEELKL BCHJNJPCBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1BA0060", Offset = "0x1B9EC60", VA = "0x181BA0060", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FLDOCHEELKL IPBLPMJAFMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1BA0050", Offset = "0x1B9EC50", VA = "0x181BA0050", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string LOAPAONIPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform JHJPBMCANBN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7364C80", Offset = "0x7363880", VA = "0x187364C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform OINNNOLDCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7368A30", Offset = "0x7367630", VA = "0x187368A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform EPJFAHKOLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x736E6C0", Offset = "0x736D2C0", VA = "0x18736E6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform KFBPFLEFDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7373F10", Offset = "0x7372B10", VA = "0x187373F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform OAIIFAEKAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x735E010", Offset = "0x735CC10", VA = "0x18735E010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool LLCIGBFNHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x735DFC0", Offset = "0x735CBC0", VA = "0x18735DFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool JOIHPHMOPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x735DFC0", Offset = "0x735CBC0", VA = "0x18735DFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Transform OCAFFCLCKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x73671F0", Offset = "0x7365DF0", VA = "0x1873671F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GameObject PHPLOOLODCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7370550", Offset = "0x736F150", VA = "0x187370550", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HeadLogicOffsets CMCHEIIGJHK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7375C70", Offset = "0x7374870", VA = "0x187375C70", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform CMHPHFADEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA15280", Offset = "0xA13E80", VA = "0x180A15280", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform DPHMMOAGEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CDCBC0", Offset = "0x1CDB7C0", VA = "0x181CDCBC0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform ACMMJAPKKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA36C10", Offset = "0xA35810", VA = "0x180A36C10", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform HINDIKDAGGB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x19CF5D0", Offset = "0x19CE1D0", VA = "0x1819CF5D0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 INGHFBJGOGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x736B500", Offset = "0x736A100", VA = "0x18736B500", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float LPFKMAJDDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x735E730", Offset = "0x735D330", VA = "0x18735E730", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform FHKPJOPAJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x736C450", Offset = "0x736B050", VA = "0x18736C450", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform EMEPIDFCFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x200DE90", Offset = "0x200CA90", VA = "0x18200DE90", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform KADKDMJINAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x200DE80", Offset = "0x200CA80", VA = "0x18200DE80", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform PBNGJDDENPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19D01A0", Offset = "0x19CEDA0", VA = "0x1819D01A0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool MANMPCLGFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x736E7C0", Offset = "0x736D3C0", VA = "0x18736E7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool FFLPLDGHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7373AD0", Offset = "0x73726D0", VA = "0x187373AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool IBNKEJHBICK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7367AA0", Offset = "0x73666A0", VA = "0x187367AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x73602C0", Offset = "0x735EEC0", VA = "0x1873602C0")]
	private void DNHCNKIJDLI([In] ANGHBGIMLKK FGMLNCFMKMK, [In] AvatarFullBodyConfiguration BKDMEACEJJF, bool HOJAAEHOGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7362FD0", Offset = "0x7361BD0", VA = "0x187362FD0")]
	private float DPOGMMJKMFD([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7366100", Offset = "0x7364D00", VA = "0x187366100")]
	private float GAMOMOMOJJG([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x735EF50", Offset = "0x735DB50", VA = "0x18735EF50")]
	private void DCPPALBNLMA(ANGHBGIMLKK FGMLNCFMKMK, AvatarFullBodyConfiguration BKDMEACEJJF, bool HOJAAEHOGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7367B70", Offset = "0x7366770", VA = "0x187367B70")]
	private void HOKJDEKGKOL([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x736F2A0", Offset = "0x736DEA0", VA = "0x18736F2A0")]
	private void MKPALOPPIAM([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x73766F0", Offset = "0x73752F0", VA = "0x1873766F0")]
	public PGHFJAOMGLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x735E220", Offset = "0x735CE20", VA = "0x18735E220", Slot = "12")]
	public void CNFCOHNAILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7373B50", Offset = "0x7372750", VA = "0x187373B50", Slot = "13")]
	public void PCMPLFPMMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x736E6F0", Offset = "0x736D2F0", VA = "0x18736E6F0", Slot = "14")]
	public void MHBNCIMPOEG(bool GIPLHHBHLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x735D8A0", Offset = "0x735C4A0", VA = "0x18735D8A0", Slot = "25")]
	public Transform BCCBLMMIFAB(string HIPPPGOHLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x73647F0", Offset = "0x73633F0", VA = "0x1873647F0", Slot = "26")]
	public Vector3? FFAEFKKMOKE(string HIPPPGOHLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x736F4A0", Offset = "0x736E0A0", VA = "0x18736F4A0", Slot = "7")]
	public void MMMAKFKMJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73759C0", Offset = "0x73745C0", VA = "0x1873759C0")]
	private void POEMIGKAPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x735FF40", Offset = "0x735EB40", VA = "0x18735FF40")]
	private Vector3 DLNEBAMJHJA([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7369950", Offset = "0x7368550", VA = "0x187369950", Slot = "6")]
	public void JHKCCHGLAJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7368A70", Offset = "0x7367670", VA = "0x187368A70", Slot = "8")]
	public void IPEEBPAADBA(float DNGMFLABHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x736B590", Offset = "0x736A190", VA = "0x18736B590")]
	private void KGBGFKBIBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7370B10", Offset = "0x736F710", VA = "0x187370B10", Slot = "4")]
	public void OIJCEINKLEI(string MJJOEJGFEJD, NGPBJEDFNEL MCLFBJJEGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7367340", Offset = "0x7365F40", VA = "0x187367340", Slot = "5")]
	public void HKBBICKCDOP(AMGLAECBIJH MIHCMDHLMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x73656B0", Offset = "0x73642B0", VA = "0x1873656B0", Slot = "11")]
	public void FOLOAKCPANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x73661B0", Offset = "0x7364DB0", VA = "0x1873661B0", Slot = "24")]
	public void GFKIJBFMJHJ([Out] Vector3 NMOBCOGGHFB, [Out] Quaternion DOMMEIONOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x736C790", Offset = "0x736B390", VA = "0x18736C790")]
	private void LDPOIHIEDEK([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x735D140", Offset = "0x735BD40", VA = "0x18735D140", Slot = "27")]
	public void ABOJJHNGIJF(float IDNPBHJIOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x735D550", Offset = "0x735C150", VA = "0x18735D550", Slot = "28")]
	public void BBPOIBHDPEC(float KBEJFHKCJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x735D150", Offset = "0x735BD50", VA = "0x18735D150", Slot = "44")]
	public void ADJMDCNHOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7364760", Offset = "0x7363360", VA = "0x187364760", Slot = "29")]
	public void FCMJIPONHOK(bool MJDONHDKFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7367B20", Offset = "0x7366720", VA = "0x187367B20", Slot = "30")]
	public HandLogicOffsets HOAMEIBEJEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x735E050", Offset = "0x735CC50", VA = "0x18735E050", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets CMPNCABHGII()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7366180", Offset = "0x7364D80", VA = "0x187366180")]
	private void GAOMDLNELMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73730E0", Offset = "0x7371CE0", VA = "0x1873730E0")]
	private void ONPGNEADMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x73685F0", Offset = "0x73671F0", VA = "0x1873685F0")]
	private void IKLGJDKANBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x736E040", Offset = "0x736CC40", VA = "0x18736E040")]
	private void LJFEGMCJNAA(JKJFLLICHBF EFFPGFLKCIO, bool HDEDJGFEFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x735FDB0", Offset = "0x735E9B0", VA = "0x18735FDB0")]
	private void DIONMMIOJGG(JKJFLLICHBF EFFPGFLKCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x73672F0", Offset = "0x7365EF0", VA = "0x1873672F0")]
	public Vector3 HHKJBOMAKEK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x73677E0", Offset = "0x73663E0", VA = "0x1873677E0")]
	private void HKBGBALBJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7368160", Offset = "0x7366D60", VA = "0x187368160")]
	private void IGHOLNBLGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x736A490", Offset = "0x7369090", VA = "0x18736A490")]
	private void JIABCDPAMIO(ANGHBGIMLKK FGMLNCFMKMK, AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7375AC0", Offset = "0x73746C0", VA = "0x187375AC0")]
	private float POIKLLODECK([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7373260", Offset = "0x7371E60", VA = "0x187373260")]
	private int OOJKAAGFNFH([In] ELENBLCKDKB CMJJGAHGHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x73735A0", Offset = "0x73721A0", VA = "0x1873735A0")]
	private void PBCCFNPOEAM(ANGHBGIMLKK FGMLNCFMKMK, bool LHCDBHONJNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x736C7C0", Offset = "0x736B3C0", VA = "0x18736C7C0")]
	private static void LFGBNLGGGGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x73622A0", Offset = "0x7360EA0", VA = "0x1873622A0")]
	private static void DPNBHBOCNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x73733C0", Offset = "0x7371FC0", VA = "0x1873733C0")]
	private float PAPNIECBBAG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7372DC0", Offset = "0x73719C0", VA = "0x187372DC0")]
	private static int OLMHKOCFPNL(PGHFJAOMGLE NFOAKNOEKCL, PGHFJAOMGLE AFFPJGJMKFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x73632B0", Offset = "0x7361EB0", VA = "0x1873632B0", Slot = "40")]
	public ANGHBGIMLKK EECFKDGICGK()
	{
		return default(ANGHBGIMLKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7373340", Offset = "0x7371F40", VA = "0x187373340")]
	public void PAFINCKGFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73600C0", Offset = "0x735ECC0", VA = "0x1873600C0")]
	private (bool, bool) DMJPAAJGEMC()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x736B320", Offset = "0x7369F20", VA = "0x18736B320")]
	private (float, float) KBDEHGLCMII([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7373F50", Offset = "0x7372B50", VA = "0x187373F50")]
	private void PIEBEIEFOGE([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x736D190", Offset = "0x736BD90", VA = "0x18736D190")]
	private void LIGBBFGPBNA([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7365810", Offset = "0x7364410", VA = "0x187365810")]
	private void FONJJCLAEMN([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF, AvatarFootSettings IFLMEICJBOA, bool CFPILAAFPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7367D30", Offset = "0x7366930", VA = "0x187367D30")]
	private float IAHDNKEEGAG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x736D4B0", Offset = "0x736C0B0", VA = "0x18736D4B0")]
	private void LIJJMNKMFHI(ANGHBGIMLKK CMPEMMPBPLC, AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x736FD90", Offset = "0x736E990", VA = "0x18736FD90")]
	private float NGHBPCLFIPA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x73642A0", Offset = "0x7362EA0", VA = "0x1873642A0")]
	private void FCLDDMGGBIB([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x736C4B0", Offset = "0x736B0B0", VA = "0x18736C4B0")]
	private void LDGJFFKMEHD([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7370720", Offset = "0x736F320", VA = "0x187370720")]
	private void OGEMOAPOLNP([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x735D2A0", Offset = "0x735BEA0", VA = "0x18735D2A0")]
	private void ALBGBKFJHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7363060", Offset = "0x7361C60", VA = "0x187363060")]
	private void EBJKNHJDIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x736C2B0", Offset = "0x736AEB0", VA = "0x18736C2B0")]
	private void LBHNJGDFLDC([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7369420", Offset = "0x7368020", VA = "0x187369420")]
	private void JEJIMILPBIB(EOLPLJIAMOM AAAMHFMABPH, IKSolverVR.Arm DEMJMDBKBJB, Transform IHHBDLHNKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x73665E0", Offset = "0x73651E0", VA = "0x1873665E0")]
	private void GHONFHDIIOM(ANGHBGIMLKK CMPEMMPBPLC, AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x736B5E0", Offset = "0x736A1E0", VA = "0x18736B5E0")]
	private void KIJGACDBBKJ(MDIACNADPHH CMNPCGKMCGF, FLDOCHEELKL AAAMHFMABPH, IKSolverVR.Arm DEMJMDBKBJB, float FPIBOMHEHOD, float OKFIDFPGNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x736B7B0", Offset = "0x736A3B0", VA = "0x18736B7B0")]
	private void KJOCHCNOEJD([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x735DAF0", Offset = "0x735C6F0", VA = "0x18735DAF0")]
	protected void BPPBKDAIJBA([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x736AD10", Offset = "0x7369910", VA = "0x18736AD10")]
	private void JPBPDJOLMBC([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x736BDB0", Offset = "0x736A9B0", VA = "0x18736BDB0")]
	protected void KMPMOHIPJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x736EA70", Offset = "0x736D670", VA = "0x18736EA70")]
	private void MKHBNFEAGME([In] ANGHBGIMLKK CMPEMMPBPLC, [In] DEKEDINOIKB CACHANIKPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x736C100", Offset = "0x736AD00", VA = "0x18736C100")]
	private void KPBDLAMOIKO(ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x73647B0", Offset = "0x73633B0", VA = "0x1873647B0")]
	private void FEGGILLAEDE([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7361D90", Offset = "0x7360990", VA = "0x187361D90")]
	private Vector3 DPDGFLADFIA([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7364120", Offset = "0x7362D20", VA = "0x187364120")]
	private void EMIHCPEJNFF([In] ANGHBGIMLKK CMPEMMPBPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7363CD0", Offset = "0x73628D0", VA = "0x187363CD0")]
	private float EIJFKIKHDFC(float GIFJBKLGHFG, [In] ANGHBGIMLKK CMPEMMPBPLC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7368AE0", Offset = "0x73676E0", VA = "0x187368AE0")]
	private void JCNGIHAOECA(float GIFJBKLGHFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7366970", Offset = "0x7365570", VA = "0x187366970")]
	private void GIJBKLMMFNC([In] ANGHBGIMLKK CMPEMMPBPLC, DEKEDINOIKB CACHANIKPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x736C9D0", Offset = "0x736B5D0", VA = "0x18736C9D0")]
	private float LGFPEIDEIHP([In] ANGHBGIMLKK FGMLNCFMKMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7368C30", Offset = "0x7367830", VA = "0x187368C30")]
	private void JDPMFPKKBNL(ANGHBGIMLKK CMPEMMPBPLC, DEKEDINOIKB CACHANIKPNC, Vector3 MLBCGOBMFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x736E8C0", Offset = "0x736D4C0", VA = "0x18736E8C0")]
	private static void MKBDOCNENAA(Transform FDCDPIOJPOG, Quaternion APLHHNGOEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7370220", Offset = "0x736EE20", VA = "0x187370220")]
	private void OCMLBAFOHPO([In] ANGHBGIMLKK JIKKEDAFPKJ, [In] ELENBLCKDKB CMJJGAHGHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7363420", Offset = "0x7362020", VA = "0x187363420")]
	private void EEDMGGDFIPG([In] ANGHBGIMLKK JIKKEDAFPKJ, [In] ELENBLCKDKB CMJJGAHGHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7367DB0", Offset = "0x73669B0", VA = "0x187367DB0")]
	private void IDCKLDMHANM(float HPMCNKLOOGE, [In] ANGHBGIMLKK FGMLNCFMKMK, float NAOFFKPLGPK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x735E780", Offset = "0x735D380", VA = "0x18735E780")]
	private float DBJCDGFECAI([In] ANGHBGIMLKK FGMLNCFMKMK, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7372DF0", Offset = "0x73719F0", VA = "0x187372DF0")]
	private void OMCNMADAEFL([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7364CD0", Offset = "0x73638D0", VA = "0x187364CD0")]
	private void FLHJILCPDCD([In] ANGHBGIMLKK FGMLNCFMKMK, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7365D30", Offset = "0x7364930", VA = "0x187365D30")]
	private void GAEHJPOJICE([In] ANGHBGIMLKK FGMLNCFMKMK, float DAPJALJELPA, float HJJFJFKMCCB, Vector3 FILHAHBLIKJ, float NAOFFKPLGPK = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x735F3B0", Offset = "0x735DFB0", VA = "0x18735F3B0")]
	private void DHNHOLEFHCJ(ANGHBGIMLKK FGMLNCFMKMK, AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x736E430", Offset = "0x736D030", VA = "0x18736E430")]
	private void LLNGKEPJHKL(ANGHBGIMLKK CMPEMMPBPLC, AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x736AFE0", Offset = "0x7369BE0", VA = "0x18736AFE0")]
	private void JPGCAOOFNNO(ANGHBGIMLKK FGMLNCFMKMK, AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7367FA0", Offset = "0x7366BA0", VA = "0x187367FA0")]
	public void IDKJLHJGFOJ([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7368180", Offset = "0x7366D80", VA = "0x187368180")]
	public void IGNMBBNCKHJ([In] ANGHBGIMLKK CMPEMMPBPLC, [In] AvatarFullBodyConfiguration BKDMEACEJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x73697B0", Offset = "0x73683B0", VA = "0x1873697B0")]
	[CompilerGenerated]
	internal static void JHFNNBGDKPA(Transform CGPMLCFDDHA, IKSolverVR.Arm DEMJMDBKBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x73641F0", Offset = "0x7362DF0", VA = "0x1873641F0")]
	[CompilerGenerated]
	internal static void FACCJLOPCHF(Vector3 KBJODNLCMIB, Vector3 BKOKGGBKMGM, MICNDOGJMGO P_2, IPIIOPNLHDN P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7366540", Offset = "0x7365140", VA = "0x187366540")]
	[CompilerGenerated]
	internal static void GGFFOPDPLNK(NNLPHCIACNF LNLNEOPEKDF, NNLPHCIACNF HDJJKPOPPCP, Vector3 FBDFPPGBBMF, float AHPAHIHOBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x735E110", Offset = "0x735CD10", VA = "0x18735E110")]
	[CompilerGenerated]
	internal static bool CNAHCBBKDAE(IKSolverVR.Arm DEMJMDBKBJB, PBAPFDCNPKG OMDFMLICADD, float GEMIMMLDLKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x736FDE0", Offset = "0x736E9E0", VA = "0x18736FDE0")]
	[CompilerGenerated]
	internal static float NHFAJLPDGKK(Vector3 ENJBFEKHONB, Vector3 EDEHMEGPKON, Vector3 NGPCCHBNDDD, ANGHBGIMLKK FGMLNCFMKMK, AvatarFullBodyConfiguration BKDMEACEJJF, float KKHFKGIPICC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class LGILCDFHHFO : NPCLCFKKFOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<string, OFCBGNLPJGC> GCMBBIOLGCF;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x737BE20", Offset = "0x737AA20", VA = "0x18737BE20")]
	[DMDJPIBKEJJ.OHIIEKNFAKB]
	internal static void KPOPGJKKLGG(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x737BAC0", Offset = "0x737A6C0", VA = "0x18737BAC0", Slot = "4")]
	public OFCBGNLPJGC CNGCECIPCGI(string ONABKANHLCD, AvatarSystemConfiguration DEHIDHGOEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x737B8E0", Offset = "0x737A4E0", VA = "0x18737B8E0", Slot = "5")]
	public void CJCPKDLDLHD(string ONABKANHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x737BCE0", Offset = "0x737A8E0", VA = "0x18737BCE0", Slot = "6")]
	public string FOCDHGPOIDF(string GJMMLHMCILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x737B870", Offset = "0x737A470", VA = "0x18737B870")]
	private string CGEMJOMAMHG(string GJMMLHMCILE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x737BE90", Offset = "0x737AA90", VA = "0x18737BE90")]
	public LGILCDFHHFO()
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
		public class FNLBFPHCHIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private Dictionary<string, Transform> APHMEJENEKN;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool OIEJENPKAEM
			{
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x73792D0", Offset = "0x7377ED0", VA = "0x1873792D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x73791A0", Offset = "0x7377DA0", VA = "0x1873791A0")]
			public void NNCFAJFDBNB(VRIK PPJMEIADOGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
			public void FCJMPJMEDDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7379150", Offset = "0x7377D50", VA = "0x187379150")]
			public void EDPJFJHBEFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7379310", Offset = "0x7377F10", VA = "0x187379310")]
			public FNLBFPHCHIG()
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
		[FKADGLKHFBM(EGFPEOBPDHA.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[NEHJBMHDGNH(EGFPEOBPDHA.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly FNLBFPHCHIG EAHEGBAHOCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private ELFGKMJDHMK LDGPDDELCFF;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7377D40", Offset = "0x7376940", VA = "0x187377D40")]
		private void AIMKJDEKJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7378020", Offset = "0x7376C20", VA = "0x187378020")]
		private bool EKBAGFJKPEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7378070", Offset = "0x7376C70", VA = "0x187378070")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x73780E0", Offset = "0x7376CE0", VA = "0x1873780E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7378080", Offset = "0x7376C80", VA = "0x187378080")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7378350", Offset = "0x7376F50", VA = "0x187378350")]
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
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x737AA80", Offset = "0x7379680", VA = "0x18737AA80")]
			public void HGFFJCPBDPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x737AB60", Offset = "0x7379760", VA = "0x18737AB60")]
			public (float, float) LIIJKOAICPG(Animator FCCPAPCPCLD, AnimatorStateInfo HPNKINOPBME)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
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
		[Cpp2IlInjected.Address(RVA = "0x737ACA0", Offset = "0x73798A0", VA = "0x18737ACA0")]
		public void HGFFJCPBDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x737B080", Offset = "0x7379C80", VA = "0x18737B080")]
		public (float, float) NMNJAJAOOMF(Animator FCCPAPCPCLD)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x737AE90", Offset = "0x7379A90", VA = "0x18737AE90")]
		private (float, float) JGGHLAECIEI(Animator FCCPAPCPCLD, AnimatorStateInfo HPNKINOPBME)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x737B290", Offset = "0x7379E90", VA = "0x18737B290")]
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
		[Cpp2IlInjected.Address(RVA = "0x737E470", Offset = "0x737D070", VA = "0x18737E470", Slot = "4")]
		public override void OnStateEnter(Animator FCCPAPCPCLD, AnimatorStateInfo HPNKINOPBME, int ALGHOHHJLGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x737E5D0", Offset = "0x737D1D0", VA = "0x18737E5D0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class NDMLIIDPFCI<TInput, TOutput> : NJAGLGKGFII<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected readonly NFPCFNAHBIE PABJDHMLLBF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4DF22D0", Offset = "0x4DF0ED0", VA = "0x184DF22D0")]
	protected NDMLIIDPFCI(NFPCFNAHBIE PABJDHMLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput KOHMJABOPGF(TInput CPPOMEHPJCH, [Out] IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4DF2230", Offset = "0x4DF0E30", VA = "0x184DF2230", Slot = "5")]
	public bool BIPLHKKGPGL(TInput CPPOMEHPJCH, [Out] TOutput? HBANOBDOKBJ, [Out] IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HJLLPMMDIEM]
public static class PDOKNDAIMBG
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly Regex PBOEIDHOKOG;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x73810A0", Offset = "0x737FCA0", VA = "0x1873810A0")]
	public static LOKGHHNDHFD MMDONIPHAGF(JEOEJGIGBNL LIEJNFEMPFN, NDEJIOADGKC HFFELKDALKA, Guid? PCIMFMHGJDE, Color? NDBNNPICPKC, MNMFJNIJMID PPCPNOAGMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7380E00", Offset = "0x737FA00", VA = "0x187380E00")]
	public static MKBGJCIDLNA BDDNJPJKFKC(LOKGHHNDHFD LLDJIJICLJF)
	{
		return default(MKBGJCIDLNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x355ABA0", Offset = "0x35597A0", VA = "0x18355ABA0")]
	internal static TModern? EOMCINLLNHO<TModern>(string? CPPOMEHPJCH, NLJIGDMMGCM<TModern> GJLALBGIDNK, NFPCFNAHBIE PABJDHMLLBF, IAMIKLJOBMF LEODMDDPFBC, TModern EMDPINHGHBD) where TModern : struct, AECEOFBPHCP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x355C1F0", Offset = "0x355ADF0", VA = "0x18355C1F0")]
	internal static LMGNHDCPCIC MJHPJFNJEHI<TModern>(string? CPPOMEHPJCH, NLJIGDMMGCM<TModern> GJLALBGIDNK, NFPCFNAHBIE PABJDHMLLBF, IAMIKLJOBMF LEODMDDPFBC, TModern EMDPINHGHBD) where TModern : struct, AECEOFBPHCP
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7380F60", Offset = "0x737FB60", VA = "0x187380F60")]
	internal static List<MEFKHEHCGHH> FGNLALDBNPF(IEnumerable<PEELLFICLAL>? MAEAFHIEINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x355C9D0", Offset = "0x355B5D0", VA = "0x18355C9D0")]
	internal static string NCEIAHNOCNL<TModern>(TModern CPPOMEHPJCH, NLJIGDMMGCM<TModern> GJLALBGIDNK, NFPCFNAHBIE PABJDHMLLBF) where TModern : AECEOFBPHCP
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class KMALHKNDFPG : BLJDMBCMKOA
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NJAGLGKGFII<HBCEOCGAECD, DIKMCPOCMGD> CEMKFBKPDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NJAGLGKGFII<DBFGDKELGJC, MBHFDHDMDAC> NKECMECDCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NJAGLGKGFII<DBFGDKELGJC, MBHFDHDMDAC> JMJLHFMMGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JDOFGPIGGAD OLBANEDAAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public OLEBGOFLCPI ONGEICIMGBM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x737B2A0", Offset = "0x7379EA0", VA = "0x18737B2A0")]
	[DMDJPIBKEJJ.OHIIEKNFAKB.OKGKMEFLHLK]
	[UsedImplicitly]
	internal static void KEKDPLFGAFF(KPLLBHIBBNH AGGFAPJEEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x737B310", Offset = "0x7379F10", VA = "0x18737B310")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KMALHKNDFPG([GJMNBPKNJPO("UnitySerialization")] NDKCDHNKDNO IFKBLDLNMFO, [GJMNBPKNJPO(null)] MIIIOEHHIKG EEKACHJGOIK, [GJMNBPKNJPO(null)] NFPCFNAHBIE PABJDHMLLBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum AOPODCCKLBG
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
public class CADCNEIOONK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7378460", Offset = "0x7377060", VA = "0x187378460")]
	public CADCNEIOONK(string KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7378430", Offset = "0x7377030", VA = "0x187378430")]
	public CADCNEIOONK(string KBPDEFFIKOJ, Exception HPLHIDGGGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x73784D0", Offset = "0x73770D0", VA = "0x1873784D0")]
	public CADCNEIOONK(AOPODCCKLBG BODILIPNFGI, string KBPDEFFIKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7378490", Offset = "0x7377090", VA = "0x187378490")]
	public CADCNEIOONK(AOPODCCKLBG BODILIPNFGI, string KBPDEFFIKOJ, Exception HPLHIDGGGDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class PBEJFPHDODL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly NDKCDHNKDNO IFKBLDLNMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly MIIIOEHHIKG EEKACHJGOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly NFPCFNAHBIE PABJDHMLLBF;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x737F360", Offset = "0x737DF60", VA = "0x18737F360")]
	protected PBEJFPHDODL(NDKCDHNKDNO IFKBLDLNMFO, MIIIOEHHIKG EEKACHJGOIK, NFPCFNAHBIE PABJDHMLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x737F800", Offset = "0x737E400", VA = "0x18737F800")]
	protected string EECJNIPNNMO(DIKMCPOCMGD MLDPAOODPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x737F620", Offset = "0x737E220", VA = "0x18737F620")]
	protected string DHCKEDMBCIF(DIKMCPOCMGD MLDPAOODPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x7380AD0", Offset = "0x737F6D0", VA = "0x187380AD0")]
	private AvatarOutfitSelectionData MMDONIPHAGF(LOKGHHNDHFD FGGCALODLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x737F4E0", Offset = "0x737E0E0", VA = "0x18737F4E0")]
	private static AvatarCustomizationSettingsData.AnchorParams CLJBOPDODPA(IFMFMHOGADG? BFFCFPPKGGI)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface NJAGLGKGFII<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput KOHMJABOPGF(TInput CPPOMEHPJCH, [Out] IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BIPLHKKGPGL(TInput CPPOMEHPJCH, [Out] TOutput? HBANOBDOKBJ, [Out] IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BLJDMBCMKOA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	NJAGLGKGFII<HBCEOCGAECD, DIKMCPOCMGD> CEMKFBKPDGL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NJAGLGKGFII<DBFGDKELGJC, MBHFDHDMDAC> JMJLHFMMGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JDOFGPIGGAD OLBANEDAAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum IAMIKLJOBMF
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface OLEBGOFLCPI
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LHMLCOBNIPB DHDDBDHCOJI(DIKMCPOCMGD LLDJIJICLJF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface JDOFGPIGGAD
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBFGDKELGJC DHDDBDHCOJI(DIKMCPOCMGD LLDJIJICLJF, int MOLBMOPPCBL, string? BGKKCEGMOKH, string? DNAAPJGFADE, MEPGBPIBEBN FLHJBEBOAIC, List<MEFKHEHCGHH>? CCPNLHGKJML);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[HJLLPMMDIEM]
internal class AOGMJCEJHLF : NDMLIIDPFCI<HBCEOCGAECD, DIKMCPOCMGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly MIIIOEHHIKG EEKACHJGOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly LONONCCBDGA IBHCOBAHJFH;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x7377180", Offset = "0x7375D80", VA = "0x187377180")]
	public AOGMJCEJHLF(NDKCDHNKDNO IFKBLDLNMFO, MIIIOEHHIKG EEKACHJGOIK, NFPCFNAHBIE PABJDHMLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7376EE0", Offset = "0x7375AE0", VA = "0x187376EE0", Slot = "6")]
	public override DIKMCPOCMGD KOHMJABOPGF(HBCEOCGAECD CPPOMEHPJCH, [Out] IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class NPFNFOBLJDP : NDKCDHNKDNO
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class PHONEIGJEDG : JsonConverter<LMGNHDCPCIC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7381470", Offset = "0x7380070", VA = "0x187381470", Slot = "9")]
		public override void WriteJson(JsonWriter DGOPMEPLAFF, LMGNHDCPCIC? MPDLOLIOGJL, JsonSerializer EEPGGELCPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7381350", Offset = "0x737FF50", VA = "0x187381350", Slot = "10")]
		public override LMGNHDCPCIC ReadJson(JsonReader KLCLFHDKNAH, Type NCAKCNAOHMK, LMGNHDCPCIC? KFKMMPLHILJ, bool HAFPEKHNHND, JsonSerializer EEPGGELCPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7381510", Offset = "0x7380110", VA = "0x187381510")]
		public PHONEIGJEDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class NFNFCLIEKNM : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool LJHJLIAKMNL
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x737E9D0", Offset = "0x737D5D0", VA = "0x18737E9D0", Slot = "5")]
		public override object ReadJson(JsonReader KLCLFHDKNAH, Type NCAKCNAOHMK, object? KFKMMPLHILJ, JsonSerializer EEPGGELCPKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x737E7F0", Offset = "0x737D3F0", VA = "0x18737E7F0", Slot = "6")]
		public override bool CanConvert(Type NCAKCNAOHMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x737EA30", Offset = "0x737D630", VA = "0x18737EA30", Slot = "4")]
		public override void WriteJson(JsonWriter DGOPMEPLAFF, object? MPDLOLIOGJL, JsonSerializer EEPGGELCPKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x737E5F0", Offset = "0x737D1F0", VA = "0x18737E5F0")]
		private static bool AECLBPNPNPE(object MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public NFNFCLIEKNM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings DGEAKNFBBOD;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x737EB10", Offset = "0x737D710", VA = "0x18737EB10")]
	internal NPFNFOBLJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x34EC5E0", Offset = "0x34EB1E0", VA = "0x1834EC5E0", Slot = "4")]
	public string IPBOAOLOBED<T>(T CFMCKCBBBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x34EC550", Offset = "0x34EB150", VA = "0x1834EC550", Slot = "5")]
	public T HIPEOJLHCBH<T>(string MPDLOLIOGJL)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class GEODGJAFDBP : NDKCDHNKDNO
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3377470", Offset = "0x3376070", VA = "0x183377470", Slot = "4")]
	public string IPBOAOLOBED<T>(T CFMCKCBBBKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x33773F0", Offset = "0x3375FF0", VA = "0x1833773F0", Slot = "5")]
	public T HIPEOJLHCBH<T>(string MPDLOLIOGJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public GEODGJAFDBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HJLLPMMDIEM]
internal class LONONCCBDGA : NDMLIIDPFCI<DBFGDKELGJC, MBHFDHDMDAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly NDKCDHNKDNO IFKBLDLNMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly MIIIOEHHIKG EEKACHJGOIK;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x737E330", Offset = "0x737CF30", VA = "0x18737E330")]
	public LONONCCBDGA(NDKCDHNKDNO IFKBLDLNMFO, MIIIOEHHIKG EEKACHJGOIK, NFPCFNAHBIE PABJDHMLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x737D880", Offset = "0x737C480", VA = "0x18737D880", Slot = "6")]
	public override MBHFDHDMDAC KOHMJABOPGF(DBFGDKELGJC CPPOMEHPJCH, [Out] IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x737C120", Offset = "0x737AD20", VA = "0x18737C120")]
	internal void AKBKPOAFFEC(string DFHECLMKMDK, DIKMCPOCMGD MLDPAOODPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x737CDF0", Offset = "0x737B9F0", VA = "0x18737CDF0")]
	public IEnumerable<LOKGHHNDHFD> GBOANNNNPIH(string JGMMDFJAGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x737C9D0", Offset = "0x737B5D0", VA = "0x18737C9D0")]
	private IEnumerable<LOKGHHNDHFD> FIENGOGDFJG(string JGMMDFJAGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x737C580", Offset = "0x737B180", VA = "0x18737C580")]
	internal IEnumerable<LOKGHHNDHFD> ENECKNNOBEC(string JGMMDFJAGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x737DCA0", Offset = "0x737C8A0", VA = "0x18737DCA0")]
	private LOKGHHNDHFD NLEKNGHBMGH(AvatarOutfitSelectionData BKOKGCFHJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x737CEA0", Offset = "0x737BAA0", VA = "0x18737CEA0")]
	private void GILKMBIHJPF(AvatarCustomizationSettingsData JPECJHMGOLF, DIKMCPOCMGD MLDPAOODPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x737E020", Offset = "0x737CC20", VA = "0x18737E020")]
	private LOKGHHNDHFD NLEKNGHBMGH(string IBIMAIAODDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x737C280", Offset = "0x737AE80", VA = "0x18737C280")]
	internal static (MNMFJNIJMID, string, string) DJPBCANCGGI(string IBIMAIAODDO, NFPCFNAHBIE PABJDHMLLBF)
	{
		return default((MNMFJNIJMID, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x737BF20", Offset = "0x737AB20", VA = "0x18737BF20")]
	private BHIKMOBHGNK? AFIOJCAGLPE(string? IEIMOIIMGDN, Vector2 HGHCCCONBNM, float IEEJKDCNOLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x737D720", Offset = "0x737C320", VA = "0x18737D720")]
	private static IFMFMHOGADG JJMEJJFNHBH(AvatarCustomizationSettingsData.AnchorParams MBNFFJLKFIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HJLLPMMDIEM]
internal class OJNKEMAJCGJ : PBEJFPHDODL, OLEBGOFLCPI
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x737F360", Offset = "0x737DF60", VA = "0x18737F360")]
	public OJNKEMAJCGJ(NDKCDHNKDNO IFKBLDLNMFO, MIIIOEHHIKG EEKACHJGOIK, NFPCFNAHBIE PABJDHMLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x737EEB0", Offset = "0x737DAB0", VA = "0x18737EEB0", Slot = "4")]
	public LHMLCOBNIPB DHDDBDHCOJI(DIKMCPOCMGD LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x737F260", Offset = "0x737DE60", VA = "0x18737F260")]
	private string PNHNJGEJIHO(DIKMCPOCMGD MLDPAOODPLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x737EC70", Offset = "0x737D870", VA = "0x18737EC70")]
	private string BHLGNAKBJLN(LOKGHHNDHFD FGGCALODLFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[HJLLPMMDIEM]
internal class DDDILBNALBO : NDMLIIDPFCI<DBFGDKELGJC, MBHFDHDMDAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly NDKCDHNKDNO IFKBLDLNMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly NJAGLGKGFII<DBFGDKELGJC, MBHFDHDMDAC> KECHMKEOGLK;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7378BC0", Offset = "0x73777C0", VA = "0x187378BC0")]
	public DDDILBNALBO(NJAGLGKGFII<DBFGDKELGJC, MBHFDHDMDAC> KECHMKEOGLK, NFPCFNAHBIE PABJDHMLLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7378790", Offset = "0x7377390", VA = "0x187378790", Slot = "6")]
	public override MBHFDHDMDAC KOHMJABOPGF(DBFGDKELGJC CPPOMEHPJCH, [Out] IReadOnlyList<MEFKHEHCGHH>? CCPNLHGKJML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HJLLPMMDIEM]
internal class DDEOHHNLBEO : JDOFGPIGGAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly NDKCDHNKDNO IFKBLDLNMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly OLEBGOFLCPI MIJLONCNLBA;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7379060", Offset = "0x7377C60", VA = "0x187379060")]
	public DDEOHHNLBEO(OLEBGOFLCPI MIJLONCNLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7378CC0", Offset = "0x73778C0", VA = "0x187378CC0", Slot = "4")]
	public DBFGDKELGJC DHDDBDHCOJI(DIKMCPOCMGD LLDJIJICLJF, int MOLBMOPPCBL, string? BGKKCEGMOKH, string? DNAAPJGFADE, MEPGBPIBEBN FLHJBEBOAIC, List<MEFKHEHCGHH>? CCPNLHGKJML)
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
		[Cpp2IlInjected.Address(RVA = "0x7377400", Offset = "0x7376000", VA = "0x187377400")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CBPCCIOCBBE
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7378680", Offset = "0x7377280", VA = "0x187378680")]
	public static MKBGJCIDLNA KOHMJABOPGF(this AOBKJPCKMLI LLDJIJICLJF)
	{
		return default(MKBGJCIDLNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7378500", Offset = "0x7377100", VA = "0x187378500")]
	public static AOBKJPCKMLI DHDDBDHCOJI(this MKBGJCIDLNA EELLJOEFHJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7378620", Offset = "0x7377220", VA = "0x187378620")]
	public static bool FPPPCKHEHFC(this MKBGJCIDLNA EELLJOEFHJM)
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
			[Cpp2IlInjected.Address(RVA = "0x5619900", Offset = "0x5618500", VA = "0x185619900")]
			public AnchorParams(Vector2 IMJMGGODEDF, Vector3 MNELEMHHBKM, Vector3 KKKFMBELFLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7377350", Offset = "0x7375F50", VA = "0x187377350")]
			internal IFMFMHOGADG DHDDBDHCOJI()
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
		private GBOFEGMEOKI useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x7377BF0", Offset = "0x73767F0", VA = "0x187377BF0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4524D10", Offset = "0x4523910", VA = "0x184524D10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB46DD0", Offset = "0xB459D0", VA = "0x180B46DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xD6E740", Offset = "0xD6D340", VA = "0x180D6E740")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x1028750", Offset = "0x1027350", VA = "0x181028750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x7377C90", Offset = "0x7376890", VA = "0x187377C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x965EE0", Offset = "0x964AE0", VA = "0x180965EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xA9DE00", Offset = "0xA9CA00", VA = "0x180A9DE00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xA9E0E0", Offset = "0xA9CCE0", VA = "0x180A9E0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x95D110", Offset = "0x95BD10", VA = "0x18095D110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x7377CD0", Offset = "0x73768D0", VA = "0x187377CD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xCC4460", Offset = "0xCC3060", VA = "0x180CC4460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xEDD030", Offset = "0xEDBC30", VA = "0x180EDD030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x15263C0", Offset = "0x1524FC0", VA = "0x1815263C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x95F020", Offset = "0x95DC20", VA = "0x18095F020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x95F030", Offset = "0x95DC30", VA = "0x18095F030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1F99730", Offset = "0x1F98330", VA = "0x181F99730")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xCF2CD0", Offset = "0xCF18D0", VA = "0x180CF2CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x98F780", Offset = "0x98E380", VA = "0x18098F780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x98F7E0", Offset = "0x98E3E0", VA = "0x18098F7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x963230", Offset = "0x961E30", VA = "0x180963230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x963150", Offset = "0x961D50", VA = "0x180963150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x963180", Offset = "0x961D80", VA = "0x180963180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9631B0", Offset = "0x961DB0", VA = "0x1809631B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9631F0", Offset = "0x961DF0", VA = "0x1809631F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x963190", Offset = "0x961D90", VA = "0x180963190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA79300", Offset = "0xA77F00", VA = "0x180A79300")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1116760", Offset = "0x1115360", VA = "0x181116760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x963170", Offset = "0x961D70", VA = "0x180963170")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x9630D0", Offset = "0x961CD0", VA = "0x1809630D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xB8FC30", Offset = "0xB8E830", VA = "0x180B8FC30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xCE2060", Offset = "0xCE0C60", VA = "0x180CE2060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x95A600", Offset = "0x959200", VA = "0x18095A600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x95A5E0", Offset = "0x9591E0", VA = "0x18095A5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xAC2650", Offset = "0xAC1250", VA = "0x180AC2650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCF11F0", Offset = "0xCEFDF0", VA = "0x180CF11F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB0D350", Offset = "0xB0BF50", VA = "0x180B0D350")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB0A100", Offset = "0xB08D00", VA = "0x180B0A100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public GBOFEGMEOKI UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xD74FA0", Offset = "0xD73BA0", VA = "0x180D74FA0")]
			get
			{
				return default(GBOFEGMEOKI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xD746C0", Offset = "0xD732C0", VA = "0x180D746C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xD73280", Offset = "0xD71E80", VA = "0x180D73280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA70A10", Offset = "0xA6F610", VA = "0x180A70A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7377CB0", Offset = "0x73768B0", VA = "0x187377CB0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7377CF0", Offset = "0x73768F0", VA = "0x187377CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7377890", Offset = "0x7376490", VA = "0x187377890")]
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
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
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
		public MNMFJNIJMID BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private PAPMFHPLOJH? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x7377D10", Offset = "0x7376910", VA = "0x187377D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
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
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
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
