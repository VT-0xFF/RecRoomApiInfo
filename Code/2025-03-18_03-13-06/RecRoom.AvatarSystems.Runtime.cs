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
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x74C00B0", Offset = "0x74BF2B0", VA = "0x1874C00B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C0", Offset = "0x98C8C0", VA = "0x18098D6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x98D700", Offset = "0x98C900", VA = "0x18098D700")]
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
		[Cpp2IlInjected.Address(RVA = "0x74C0130", Offset = "0x74BF330", VA = "0x1874C0130", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ALDPDJHMICB]
internal class DKHIECODBEM : BOFIKHLIELE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CBBPADJHGIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public DKHIECODBEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public KJAEMCJAGMO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OKJCFINNBOE BLNLKKFGCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DPBGFALCFDJ LMFBEGAHIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GIKFDCNEIFA MCOPABLMNHG;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x74A45E0", Offset = "0x74A37E0", VA = "0x1874A45E0")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	[UsedImplicitly]
	internal static void IHPHHJOMFAA(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x74A4B00", Offset = "0x74A3D00", VA = "0x1874A4B00")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DKHIECODBEM([KMMHIEIDBEA(null)] OKJCFINNBOE BLNLKKFGCDI, [KMMHIEIDBEA(null)] DPBGFALCFDJ LMFBEGAHIEC, [KMMHIEIDBEA(null)] GIKFDCNEIFA MCOPABLMNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74A3C50", Offset = "0x74A2E50", VA = "0x1874A3C50", Slot = "5")]
	public CDBIINFMANM HLOBCLGLFHK(KJAEMCJAGMO PJNNOBDKNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x74A3000", Offset = "0x74A2200", VA = "0x1874A3000", Slot = "4")]
	public CDBIINFMANM DDHPIIOJCEE(KJAEMCJAGMO PJNNOBDKNHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74A3B40", Offset = "0x74A2D40", VA = "0x1874A3B40", Slot = "6")]
	public KPOBLAONNLH DDKPNNIKDMO(CDBIINFMANM LJELDKAOCJM, int JDBHPOPEKHM, string? MBDFMCIDAOB, string? HGHINACJKMG, NHEBJNLJFEG GHHCIIPBHNJ, List<HEIEKFIPJDC>? DFDDJAMNKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x74A4A70", Offset = "0x74A3C70", VA = "0x1874A4A70", Slot = "7")]
	public bool OGDAOABKPFO(CFKEFOBOAHH CNKLDCDOOAM, [Out] CDBIINFMANM? PHMGCMMAOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x74A4500", Offset = "0x74A3700", VA = "0x1874A4500", Slot = "8")]
	public bool ICHPDKILLCP(KPOBLAONNLH LBBKCJDMHNA, [Out] CDBIINFMANM? PHMGCMMAOFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74A49E0", Offset = "0x74A3BE0", VA = "0x1874A49E0", Slot = "9")]
	public bool NLDLLJBAPHA(KPOBLAONNLH LBBKCJDMHNA, [Out] AOMAMMEEDPL? CNKLDCDOOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x32D0290", Offset = "0x32CF490", VA = "0x1832D0290")]
	private bool NBPDDNOHICF<TInput, TOutput>(TInput GEDAGNGPIPL, OFHKCANJFFO<TInput, TOutput> IEAFDCHANMC, [Out] TOutput? CMLOHOMLNDL) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x74A4830", Offset = "0x74A3A30", VA = "0x1874A4830")]
	[CompilerGenerated]
	private CJAOLDPFAPJ LNFIMLBKMGM(FaceFeatureType GDOCGKIIGKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74A4650", Offset = "0x74A3850", VA = "0x1874A4650")]
	[CompilerGenerated]
	private CJAOLDPFAPJ LLIOEINHCBJ(FaceFeatureType GDOCGKIIGKM, CBBPADJHGIH P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ALDPDJHMICB]
internal class EDBNNCKOGCD : OKJCFINNBOE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void DKNJNKNHMBG<in TData>(TData PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly GIKFDCNEIFA MCOPABLMNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IDECIICAEAC GMEPCNOKEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DKNJNKNHMBG<CDBIINFMANM>?[] BLNLKKFGCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DKNJNKNHMBG<AOMAMMEEDPL>?[] GGPHONHPPKL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x74A4D90", Offset = "0x74A3F90", VA = "0x1874A4D90")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	[UsedImplicitly]
	internal static void IHPHHJOMFAA(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x74A5EB0", Offset = "0x74A50B0", VA = "0x1874A5EB0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal EDBNNCKOGCD([KMMHIEIDBEA(null)] GIKFDCNEIFA MCOPABLMNHG, [KMMHIEIDBEA(null)] IDECIICAEAC GMEPCNOKEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x74A5100", Offset = "0x74A4300", VA = "0x1874A5100", Slot = "4")]
	public bool OAGEHBCHLEC(CDBIINFMANM PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x74A5200", Offset = "0x74A4400", VA = "0x1874A5200", Slot = "5")]
	public bool OAGEHBCHLEC(AOMAMMEEDPL CNKLDCDOOAM, IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x74A5360", Offset = "0x74A4560", VA = "0x1874A5360")]
	private void OGLCKHIGMHL(CDBIINFMANM PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? JEBOOCGPANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x74A4ED0", Offset = "0x74A40D0", VA = "0x1874A4ED0")]
	private void KOGOMKOKOKP(CDBIINFMANM PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? JEBOOCGPANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74A4D60", Offset = "0x74A3F60", VA = "0x1874A4D60")]
	private void HNAOIONCHFD(CDBIINFMANM PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? JEBOOCGPANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74A4D30", Offset = "0x74A3F30", VA = "0x1874A4D30")]
	private void EMGFHPPHMEK(CDBIINFMANM PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? JEBOOCGPANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74A4E00", Offset = "0x74A4000", VA = "0x1874A4E00")]
	private void ILAOBMMGPND(CDBIINFMANM PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? JEBOOCGPANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74A4C80", Offset = "0x74A3E80", VA = "0x1874A4C80")]
	private void BENLGPNAIJK(CDBIINFMANM PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? JEBOOCGPANP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OKJCFINNBOE
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OAGEHBCHLEC(CDBIINFMANM PHMGCMMAOFN, IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OAGEHBCHLEC(AOMAMMEEDPL CNKLDCDOOAM, IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM);
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
		public KPFKBLJOHLN AnimationPoseType;

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

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74A0BD0", Offset = "0x749FDD0", VA = "0x1874A0BD0")]
		public void EKNKPHIMBJB(AnimationPoseSetting LDKNLBHIGFL, float BHKFOIGDLGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74A0D00", Offset = "0x749FF00", VA = "0x1874A0D00")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
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

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x74A15F0", Offset = "0x74A07F0", VA = "0x1874A15F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x74A15B0", Offset = "0x74A07B0", VA = "0x1874A15B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x74A0D20", Offset = "0x749FF20", VA = "0x1874A0D20")]
		private void LGPPELNCEBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7431D10", Offset = "0x7430F10", VA = "0x187431D10", Slot = "4")]
		public void SetEnabled(bool DOAMCAICJBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74A1620", Offset = "0x74A0820", VA = "0x1874A1620")]
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

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x74A1660", Offset = "0x74A0860", VA = "0x1874A1660")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		[Header("Watch")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D1")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x404")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x434")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x46C")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x494")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x498")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x49C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4A8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4B0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Local offset from pelvis to foot center")]
		[Header("Shoe Settings")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4BC")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4D8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x74A16A0", Offset = "0x74A08A0", VA = "0x1874A16A0")]
		public AnimationPoseSetting COEENOELMBP(KPFKBLJOHLN OOINGBANBKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x74A16D0", Offset = "0x74A08D0", VA = "0x1874A16D0")]
		public void EMBIHAFPMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x74A1710", Offset = "0x74A0910", VA = "0x1874A1710")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum LLEDCCFKKDP
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private LLEDCCFKKDP handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[FormerlySerializedAs("color")]
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

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x74A21C0", Offset = "0x74A13C0", VA = "0x1874A21C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x74A2180", Offset = "0x74A1380", VA = "0x1874A2180")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x74A1B80", Offset = "0x74A0D80", VA = "0x1874A1B80")]
		private void LGPPELNCEBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7431D10", Offset = "0x7430F10", VA = "0x187431D10", Slot = "4")]
		public void SetEnabled(bool DOAMCAICJBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x74A21F0", Offset = "0x74A13F0", VA = "0x1874A21F0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, ODJOFHGEPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[Header("Configuration")]
		[SerializeField]
		private KJAEMCJAGMO avatarBodyType;

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
		[KPPBIEPJJJL(ADOEJJMOABO.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		[Header("Configuration")]
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
		[Header("Arm Animation Controllers")]
		[SerializeField]
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
		[FormerlySerializedAs("HeadTweakBone")]
		private Transform HeadSizeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Header("Watch")]
		[SerializeField]
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
		private CCHMIHJCEII MBKLKPMOCMC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CCHMIHJCEII CHCGMDFGKGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9F4750", Offset = "0x9F3950", VA = "0x1809F4750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform CKICFMIEDBL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x74A2FE0", Offset = "0x74A21E0", VA = "0x1874A2FE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x74A2220", Offset = "0x74A1420", VA = "0x1874A2220")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x74A2EA0", Offset = "0x74A20A0", VA = "0x1874A2EA0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x74A2E50", Offset = "0x74A2050", VA = "0x1874A2E50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x74A2DE0", Offset = "0x74A1FE0", VA = "0x1874A2DE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x74A2220", Offset = "0x74A1420", VA = "0x1874A2220", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74A25B0", Offset = "0x74A17B0", VA = "0x1874A25B0", Slot = "6")]
		public CCHMIHJCEII CreateAvatarSystem(string EOMGKDMILIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74A2DE0", Offset = "0x74A1FE0", VA = "0x1874A2DE0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74A22E0", Offset = "0x74A14E0", VA = "0x1874A22E0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74A2EF0", Offset = "0x74A20F0", VA = "0x1874A2EF0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float JMHDFCLJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class HKPDMCIOIEI : CCHMIHJCEII
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class KLIJLALMOLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 LLHFOMIPOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Quaternion PIMFBBKFNIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 GCCBLNMALBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Transform EECEOHHEENL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 JMOBMDDKIOF
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1D0CE70", Offset = "0x1D0C070", VA = "0x181D0CE70")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x1D0CE90", Offset = "0x1D0C090", VA = "0x181D0CE90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion BMAKALLBLDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x11E60D0", Offset = "0x11E52D0", VA = "0x1811E60D0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x11E60C0", Offset = "0x11E52C0", VA = "0x1811E60C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float KCKGLFPKHKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xF3EC60", Offset = "0xF3DE60", VA = "0x180F3EC60")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x15783E0", Offset = "0x15775E0", VA = "0x1815783E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool BHEACPPJAIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x969940", VA = "0x18096A740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x96A6E0", Offset = "0x9698E0", VA = "0x18096A6E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool HHCAOMJPINN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x96A6C0", Offset = "0x9698C0", VA = "0x18096A6C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x96A730", Offset = "0x969930", VA = "0x18096A730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool MEHPFAENHDH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x96A6D0", Offset = "0x9698D0", VA = "0x18096A6D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x96A720", Offset = "0x969920", VA = "0x18096A720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float OBNGDIICHMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB97500", Offset = "0xB96700", VA = "0x180B97500")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB96860", Offset = "0xB95A60", VA = "0x180B96860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x74CA790", Offset = "0x74C9990", VA = "0x1874CA790")]
		public void NDHLAPJCDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x74CA0B0", Offset = "0x74C92B0", VA = "0x1874CA0B0")]
		public void MABDDLJACGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x74C9D80", Offset = "0x74C8F80", VA = "0x1874C9D80")]
		public float FEEJKFNFPGP(Vector3 HAFLPJFIJML, Quaternion HMDIKGPMBOO, [In] AvatarFootSettings KDIDGLMCDOL, float DEOIEABOPKG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x74CA0C0", Offset = "0x74C92C0", VA = "0x1874CA0C0")]
		public void MPENDOBBLFG(Vector3 FFHCIIFHJND, Quaternion NNCFFDEGEGP, Transform NLKAJABOJPK, float MCBFJFKGNKN, bool JJBNNADMPNA, bool DHIHOPBMKEF, float MAKADEJBGIA, float DLJILMACPAH, Transform BFPPPKIAFBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x74C9B50", Offset = "0x74C8D50", VA = "0x1874C9B50")]
		public void ALLHNAOHGON(Transform JNEOPKCPMKP, Transform BFPPPKIAFBG, bool JIDJIPGOADI, bool BLHFNIEACIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x74C9F90", Offset = "0x74C9190", VA = "0x1874C9F90")]
		private void GCLENOMCOFN(Transform BFPPPKIAFBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x74C9A00", Offset = "0x74C8C00", VA = "0x1874C9A00")]
		public void AHPBKEIDADP(Transform BFPPPKIAFBG, AvatarFullBodyConfiguration PEFAADKBJGB, Vector3 JJBKGBFOLKF, float ECHEAFANGCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x74CA090", Offset = "0x74C9290", VA = "0x1874CA090")]
		public void LGGDLLBFKHP(float DLJILMACPAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x74CA7A0", Offset = "0x74C99A0", VA = "0x1874CA7A0")]
		public KLIJLALMOLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class DJHMDPHBDBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float DBMKEMHMIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool KOHAKKJMNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AnimationPoseSetting OAPJPLAMGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private float IHHCGBFMKAF;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x74C7690", Offset = "0x74C6890", VA = "0x1874C7690")]
		public void FOEAOIICMGF(IKSolverVR.Arm ENPCPPJPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x74C7650", Offset = "0x74C6850", VA = "0x1874C7650")]
		public void FMOGFDFGMAP(IKSolverVR.Arm ENPCPPJPOPM, float PGBINNCCFGH, bool KOHAKKJMNBF, AvatarFullBodyConfiguration PEFAADKBJGB, float ALNCKHBPHAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x74C7E00", Offset = "0x74C7000", VA = "0x1874C7E00")]
		private void LLNOMDJDFFH(IKSolverVR.Arm ENPCPPJPOPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x74C7270", Offset = "0x74C6470", VA = "0x1874C7270")]
		public void FKIOCHNBDPA(IKSolverVR.Arm ENPCPPJPOPM, Transform LEHJGOAJBCF, Transform NLKAJABOJPK, Quaternion ABHBMPHHOOL, Vector3 LJIOAKEHCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x74C6C80", Offset = "0x74C5E80", VA = "0x1874C6C80")]
		private (Vector3, Quaternion) APDEGLFJKOL(INBOMMMFAFB HHPIMLILLJA, Quaternion NDJIOPCGEKP, Vector3 PFBJKNJIGOK)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x74C7110", Offset = "0x74C6310", VA = "0x1874C7110")]
		public void FKACLOKMIFB(INBOMMMFAFB HHPIMLILLJA, IKSolverVR.Arm ENPCPPJPOPM, Quaternion NDJIOPCGEKP, Vector3 PFBJKNJIGOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x74C76C0", Offset = "0x74C68C0", VA = "0x1874C76C0")]
		public void GCDCMBHKMPF(INBOMMMFAFB HHPIMLILLJA, IKSolverVR.Arm ENPCPPJPOPM, Quaternion NDJIOPCGEKP, Vector3 PFBJKNJIGOK, [In] AvatarFullBodyConfiguration PEFAADKBJGB, [In] NIOHGDOCKME LEOMHHEDCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x74C7CC0", Offset = "0x74C6EC0", VA = "0x1874C7CC0")]
		public void GFNFFMAEOPP(KPFKBLJOHLN ENCIJMEJBMH, AvatarFullBodyConfiguration PEFAADKBJGB, NIOHGDOCKME LEOMHHEDCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x74C7E40", Offset = "0x74C7040", VA = "0x1874C7E40")]
		public void MLPBFEPAMAN(IKSolverVR.Arm ENPCPPJPOPM, Transform LEHJGOAJBCF, Vector3 BFCMFMCCMDB, float LNIKFBLMINJ, Quaternion JHGLBAMGCKJ, Vector3 CDFKFDBFOIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x74C82E0", Offset = "0x74C74E0", VA = "0x1874C82E0")]
		public DJHMDPHBDBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum IKPKLGOAJKH
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
	private struct JGBLJAJEAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct MODELKMAOPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int CBPBOPCNEJG;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int NEBEAGIOPPA;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int GLNNPLECFAC;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int AHABCGEALCC;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int IOIBJFCCOOO;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int BIBHHLKDCJH;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int AKHBICBFDEO;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int GFLDPKJCECD;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int EGNDIHOFKOB;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int EJACNKDCDKF;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int NGDGPNLCOAD;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int CJCHFHCGIED;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int EJNCNLACOOB;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int LHJMPOAOMPA;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int HJNIMBALDEO;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int EIIGHGNJJMJ;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int DIJJOPNGMBB;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int LBOKFGEKBHP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int CLCINJIJJMG;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int LIAPCJNBIBJ;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int KKEEADIJKJG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int KBGFKGPJBGB;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int CNOMPMOIALL;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int GJMGFEBKEAE;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int PEGAEOGGIMP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int BIEBHAFKKLH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int MEGIGHFBIGJ;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int CGLDGDPFGOD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int HGAEDHAOPAG;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int DFEKJCBPCGJ;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int HGANOINIPBL;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly Vector3 KLIOEFNPBGM;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int NJEMKAGMMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool MPOCFGKJOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool CKAMKODEBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool MEEJAAOIGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool EGCENJLOEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool KFOBDJKPHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool JMCLENHEGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Vector3 INIFLCBKGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private string JGELMMNDGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private PENBGFFNGJO? GLHKOCGNGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private DHEOKFBNOJN? PHLDCLFPELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private AJDHBHPBHBB LDPOPKBJHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private PFPPBPEEKPK EPHPNFIPCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private INBOMMMFAFB CAEGAOAPMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private INBOMMMFAFB BEOIOEAFMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool JNFKLLOENMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool HIEAPABJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly CLFFGLDFHBD MBLHGDBPBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly DBEJLLNMCPK KLFGNAIELHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int FOPJCEKMAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private float IKOFCHCLHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GameObject BIDKJGADMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform IBCIMGFBIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform MANOOPABNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform FGPJPGPJKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform AKODHKFMPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float LIAEKAFPEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float DDDMJJMGAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 AINIAJKLFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Quaternion FCGCIDIAECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform PGFOIJCFNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform NFOHBEGNAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform NMNCNIGBOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private MEGDCOPAPID KIOMIOHHOOL;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker IDCKGLOGPOH;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker CHJEELFEHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ProfilerMarker ALLHPHAKGNJ;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker OOCAKECDIFE;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker CDKCGGHFELE;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker LEIOKAGFACG;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly List<HKPDMCIOIEI> CIIPJCBLFLL;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int EFDPFDHDKJJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> IIOBMFLECDE;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static int CNDCGPMPFIC;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int NOLLIFMMBBL;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int AGGMCGFKEEG;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int NJKNHONDJID;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float EHEHFOPGCFI;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int ANOJEOBKCMK;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static float ALBBJEMCAHC;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float DGOFKFOHABJ;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float APHNPGGKPKL;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float ANBLJAIGCPM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static BCHDFDLKLIM NOHFJCJAKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float FOOGEGJMEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool KEFKFNICLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float ABIFKEAIELA;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly int MNHDMFLFPAI;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly int GGPLHFHJELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private KLIJLALMOLL AKDJDGKDILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private KLIJLALMOLL NEEDDHFDCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float MJEDDMGEMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Vector3 KOKFHMNGBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Vector3 HCKAHNKCCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private bool JCBKEBFKDDL;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly Quaternion NGKLBLGFBMG;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly Quaternion BINLCGCLILA;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly Vector3 MHBKFJPAGJE;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Vector3 ALMPFPIJGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float MJOEAOFLIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float LFAFNOIJHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private DJHMDPHBDBE JOEJMJGGDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private DJHMDPHBDBE BCLBABDGAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private COGCONLJHCH OFMJABMHCCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BDGFBJPICAL EKJMMJKONOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly ILCDMMFHGLO ODDLPLDDLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float JFLJFOJOPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float NOAJNOOIOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly BDGFBJPICAL JGCHMMKFDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Vector3 KPHGNKPIIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 NILJMFLOHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float FFHDOCADJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float MHNENHJGGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly BDGFBJPICAL ADHLBFCKEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly COGCONLJHCH OCJLLCOJLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly BDGFBJPICAL PKFIODOFOAP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public MIOEGIOIKAG LMEBHHLCGJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MIOEGIOIKAG PGADDENLDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration IGAFFCFOMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74B7F70", Offset = "0x74B7170", VA = "0x1874B7F70", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KJAEMCJAGMO HFIFGIEOKLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74BE1A0", Offset = "0x74BD3A0", VA = "0x1874BE1A0", Slot = "23")]
		get
		{
			return default(KJAEMCJAGMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration IHKACFBHPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74AD8A0", Offset = "0x74ACAA0", VA = "0x1874AD8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform PDLKIGKMAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74B8070", Offset = "0x74B7270", VA = "0x1874B8070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform KBNPFNFBMNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x74BF110", Offset = "0x74BE310", VA = "0x1874BF110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer GAFGNDHHJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x74AE060", Offset = "0x74AD260", VA = "0x1874AE060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] HJODCEEOPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x74AF490", Offset = "0x74AE690", VA = "0x1874AF490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] KNOEJEEFHKH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x74AF340", Offset = "0x74AE540", VA = "0x1874AF340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator OEGHPGOACHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x74B9FC0", Offset = "0x74B91C0", VA = "0x1874B9FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK KBNOJFPLJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x74AAD60", Offset = "0x74A9F60", VA = "0x1874AAD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private HAMJLODNHGB BPAMNDAIPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x74B6F50", Offset = "0x74B6150", VA = "0x1874B6F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private HAMJLODNHGB BCGKBNENBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x74B0680", Offset = "0x74AF880", VA = "0x1874B0680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private HAMJLODNHGB FMIECFEHMCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x74AB6D0", Offset = "0x74AA8D0", VA = "0x1874AB6D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private HAMJLODNHGB KMABMMGNFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x74AB9D0", Offset = "0x74AABD0", VA = "0x1874AB9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private HAMJLODNHGB BMOKFHBAKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x74A63B0", Offset = "0x74A55B0", VA = "0x1874A63B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private HAMJLODNHGB EHGHGIJOKLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x74B3F80", Offset = "0x74B3180", VA = "0x1874B3F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private HAMJLODNHGB HNFLOJDLKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x74A8040", Offset = "0x74A7240", VA = "0x1874A8040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private HAMJLODNHGB GGMCPDEBAHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x74BC330", Offset = "0x74BB530", VA = "0x1874BC330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public DHEOKFBNOJN MACHNGIFLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x74AFC60", Offset = "0x74AEE60", VA = "0x1874AFC60", Slot = "15")]
		get
		{
			return default(DHEOKFBNOJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BMAGGMLBMKH COLMPENOLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCD6450", Offset = "0xCD5650", VA = "0x180CD6450", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EIDCFIKENAJ AHMHLAKDHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xCD64C0", Offset = "0xCD56C0", VA = "0x180CD64C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public CPPODONDALD DCGHPIACIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1054640", Offset = "0x1053840", VA = "0x181054640", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CPPODONDALD FENJBOAOJGC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1C48410", Offset = "0x1C47610", VA = "0x181C48410", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string CAFJGGNHHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform PPLJAPEJMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x74AF440", Offset = "0x74AE640", VA = "0x1874AF440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform NNNFFCCILMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x74AA490", Offset = "0x74A9690", VA = "0x1874AA490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform LOOFHABGMMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x74AE160", Offset = "0x74AD360", VA = "0x1874AE160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform KEAIDPKLGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x74A9210", Offset = "0x74A8410", VA = "0x1874A9210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform KHFOHAGIJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x74B69C0", Offset = "0x74B5BC0", VA = "0x1874B69C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool MPBIIKJMILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x74A7420", Offset = "0x74A6620", VA = "0x1874A7420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool NFJIHKOCOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x74A7420", Offset = "0x74A6620", VA = "0x1874A7420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Transform NBDECDOJNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x74A8540", Offset = "0x74A7740", VA = "0x1874A8540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GameObject LNIONOAAAEO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74B9560", Offset = "0x74B8760", VA = "0x1874B9560", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HeadLogicOffsets INLLHOGAMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x74B68D0", Offset = "0x74B5AD0", VA = "0x1874B68D0", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform ABAPJMEDLIM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA63090", Offset = "0xA62290", VA = "0x180A63090", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform FFNGCLJJMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1D67DB0", Offset = "0x1D66FB0", VA = "0x181D67DB0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform BIJJPKELJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA84BA0", Offset = "0xA83DA0", VA = "0x180A84BA0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform CHNGFLNAHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1A3BD40", Offset = "0x1A3AF40", VA = "0x181A3BD40", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 PILDCLHBOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x74A8140", Offset = "0x74A7340", VA = "0x1874A8140", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float CLGEFCDINIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x74B9F70", Offset = "0x74B9170", VA = "0x1874B9F70", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform KIACEFDLJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x74A70D0", Offset = "0x74A62D0", VA = "0x1874A70D0", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform DDBCCAJFBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20B4E50", Offset = "0x20B4050", VA = "0x1820B4E50", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform LLNHKKFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x20C0B90", Offset = "0x20BFD90", VA = "0x1820C0B90", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform NACJIPIFMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1A3C900", Offset = "0x1A3BB00", VA = "0x181A3C900", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool KJCOCOBOCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x74ADAD0", Offset = "0x74ACCD0", VA = "0x1874ADAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool KPMAPMDNLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74AE520", Offset = "0x74AD720", VA = "0x1874AE520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool FCCMODEAAOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x74B4F00", Offset = "0x74B4100", VA = "0x1874B4F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x74ABBE0", Offset = "0x74AADE0", VA = "0x1874ABBE0")]
	private void FDNPCMKGHED([In] NIOHGDOCKME EFJIJEKHOJN, [In] AvatarFullBodyConfiguration PEFAADKBJGB, bool HEJANBDKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x74B6240", Offset = "0x74B5440", VA = "0x1874B6240")]
	private float JIGDHJHGLLH([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74B9600", Offset = "0x74B8800", VA = "0x1874B9600")]
	private float MHKPJACLDMK([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x74B8680", Offset = "0x74B7880", VA = "0x1874B8680")]
	private void LBBKHPALKEP(NIOHGDOCKME EFJIJEKHOJN, AvatarFullBodyConfiguration PEFAADKBJGB, bool HEJANBDKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x74B7DB0", Offset = "0x74B6FB0", VA = "0x1874B7DB0")]
	private void KIFNMLACEKB([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x74B4080", Offset = "0x74B3280", VA = "0x1874B4080")]
	private void IIALHHLBIMI([In] NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x74BFC10", Offset = "0x74BEE10", VA = "0x1874BFC10")]
	public HKPDMCIOIEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x74B8170", Offset = "0x74B7370", VA = "0x1874B8170", Slot = "12")]
	public void KJHJJCAEDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x74BEB00", Offset = "0x74BDD00", VA = "0x1874BEB00", Slot = "13")]
	public void OIOCFOAAHGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x74A6840", Offset = "0x74A5A40", VA = "0x1874A6840", Slot = "14")]
	public void AIKCLEEAAIF(bool AADCIMFFDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x74AB880", Offset = "0x74AAA80", VA = "0x1874AB880", Slot = "25")]
	public Transform EKELKPJLHIG(string EHJOJGAKEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x74BC1A0", Offset = "0x74BB3A0", VA = "0x1874BC1A0", Slot = "26")]
	public Vector3? NIPNLFBPOAO(string EHJOJGAKEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x74BAD00", Offset = "0x74B9F00", VA = "0x1874BAD00", Slot = "7")]
	public void NEOKNNCPHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74B31C0", Offset = "0x74B23C0", VA = "0x1874B31C0")]
	private void IAMHBBFIIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74B8AE0", Offset = "0x74B7CE0", VA = "0x1874B8AE0")]
	private Vector3 LGNKJHLFCHL([In] NIOHGDOCKME LEOMHHEDCFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x74BA0C0", Offset = "0x74B92C0", VA = "0x1874BA0C0", Slot = "6")]
	public void NEHJIGNNMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x74B6950", Offset = "0x74B5B50", VA = "0x1874B6950", Slot = "8")]
	public void JNJDEOKNGHN(float BEONIIMKBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74B7210", Offset = "0x74B6410", VA = "0x1874B7210")]
	private void KHGAHPFCIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74B0780", Offset = "0x74AF980", VA = "0x1874B0780", Slot = "4")]
	public void HNOFLFLKDCD(string EOMGKDMILIJ, PENBGFFNGJO KGCGIKHNLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74AB0B0", Offset = "0x74AA2B0", VA = "0x1874AB0B0", Slot = "5")]
	public void EEJMFPDENAH(DHEOKFBNOJN JELKJGHFJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74BE790", Offset = "0x74BD990", VA = "0x1874BE790", Slot = "11")]
	public void OGMPMCOPOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x74AE190", Offset = "0x74AD390", VA = "0x1874AE190", Slot = "24")]
	public void FMICGFGLGKC([Out] Vector3 PIJPGEBBGOE, [Out] Quaternion JHGLBAMGCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x74A8220", Offset = "0x74A7420", VA = "0x1874A8220")]
	private void BLINDIEMGPA([In] NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x74AA0B0", Offset = "0x74A92B0", VA = "0x1874AA0B0", Slot = "27")]
	public void DGAEICGEDHK(float HDLDOOAHFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74AFDC0", Offset = "0x74AEFC0", VA = "0x1874AFDC0", Slot = "28")]
	public void HGPEGINGGND(float KPCBDLONPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x74ABB90", Offset = "0x74AAD90", VA = "0x1874ABB90", Slot = "44")]
	public void FDJDIMLCDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x74BB500", Offset = "0x74BA700", VA = "0x1874BB500", Slot = "29")]
	public void NFFHKKICMJG(bool MHMAJPIHLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x74B3B40", Offset = "0x74B2D40", VA = "0x1874B3B40", Slot = "30")]
	public HandLogicOffsets IDBMKLEKPLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74ABAD0", Offset = "0x74AACD0", VA = "0x1874ABAD0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets FCFCDKBCOAP()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x74AFD90", Offset = "0x74AEF90", VA = "0x1874AFD90")]
	private void HCFBJMKAFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x74AB550", Offset = "0x74AA750", VA = "0x1874AB550")]
	private void EGGDEINOPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x74B8C60", Offset = "0x74B7E60", VA = "0x1874B8C60")]
	private void LOEHLIODGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x74AD5B0", Offset = "0x74AC7B0", VA = "0x1874AD5B0")]
	private void FFIFMOLGLEL(KCAMGMHDEDF MNDDGFGDPEJ, bool IEBFLJEOPJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x74AABD0", Offset = "0x74A9DD0", VA = "0x1874AABD0")]
	private void EBFJLHLMMPJ(KCAMGMHDEDF MNDDGFGDPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x74A81D0", Offset = "0x74A73D0", VA = "0x1874A81D0")]
	public Vector3 BIACNBHIJGI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74A7130", Offset = "0x74A6330", VA = "0x1874A7130")]
	private void AOFNBEHBLDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x74A6390", Offset = "0x74A5590", VA = "0x1874A6390")]
	private void ABJOBHHPGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x74B32C0", Offset = "0x74B24C0", VA = "0x1874B32C0")]
	private void IDBAPCNKPMA(NIOHGDOCKME EFJIJEKHOJN, AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x74ADBD0", Offset = "0x74ACDD0", VA = "0x1874ADBD0")]
	private float FKAMCLDKCMF([In] NIOHGDOCKME LEOMHHEDCFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x74B4180", Offset = "0x74B3380", VA = "0x1874B4180")]
	private int IOKALGMACIH([In] CIABHEALBGL OCKCLOCDBHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x74AF590", Offset = "0x74AE790", VA = "0x1874AF590")]
	private void GMGENIGINMD(NIOHGDOCKME EFJIJEKHOJN, bool FIHBICBKILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x74BE8F0", Offset = "0x74BDAF0", VA = "0x1874BE8F0")]
	private static void OHJCCICLIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x74B5000", Offset = "0x74B4200", VA = "0x1874B5000")]
	private static void JFOHIHMIKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x74BDFC0", Offset = "0x74BD1C0", VA = "0x1874BDFC0")]
	private float OAHOJHLKKHJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x74B0650", Offset = "0x74AF850", VA = "0x1874B0650")]
	private static int HLNLLOKMBLM(HKPDMCIOIEI MGBGOAGHGOJ, HKPDMCIOIEI FCFMBBJABHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x74AED90", Offset = "0x74ADF90", VA = "0x1874AED90", Slot = "40")]
	public NIOHGDOCKME GAKFGNOPELP()
	{
		return default(NIOHGDOCKME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74A9290", Offset = "0x74A8490", VA = "0x1874A9290")]
	public void CMIGNEJFIMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x74BBB50", Offset = "0x74BAD50", VA = "0x1874BBB50")]
	private (bool, bool) NHPOHHCLPOB()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x74B6A00", Offset = "0x74B5C00", VA = "0x1874B6A00")]
	private (float, float) JPFOPHHAGKO([In] NIOHGDOCKME LEOMHHEDCFC)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x74BC430", Offset = "0x74BB630", VA = "0x1874BC430")]
	private void NKLHDCHLMFP([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x74B7260", Offset = "0x74B6460", VA = "0x1874B7260")]
	private void KHKLIHJEJNH([In] NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x74BE370", Offset = "0x74BD570", VA = "0x1874BE370")]
	private void ODHPBDPEPIL([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB, AvatarFootSettings KDIDGLMCDOL, bool MNMEHEPBLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x74B4F80", Offset = "0x74B4180", VA = "0x1874B4F80")]
	private float JDCBECOCIGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x74B4370", Offset = "0x74B3570", VA = "0x1874B4370")]
	private void IPLCHFGKCAE(NIOHGDOCKME LEOMHHEDCFC, AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x74B9680", Offset = "0x74B8880", VA = "0x1874B9680")]
	private float MLJGOFMNBDD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x74B90A0", Offset = "0x74B82A0", VA = "0x1874B90A0")]
	private void LONIPGKINDJ([In] NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x74ADD80", Offset = "0x74ACF80", VA = "0x1874ADD80")]
	private void FKIOCHNBDPA([In] NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x74B3B90", Offset = "0x74B2D90", VA = "0x1874B3B90")]
	private void IDCJCNGJEGN([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x74B0110", Offset = "0x74AF310", VA = "0x1874B0110")]
	private void HJGFJLMBPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x74AAE60", Offset = "0x74AA060", VA = "0x1874AAE60")]
	private void EDLKJGJLPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x74AD930", Offset = "0x74ACB30", VA = "0x1874AD930")]
	private void FHOAAPGBOHB([In] NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x74AA940", Offset = "0x74A9B40", VA = "0x1874AA940")]
	private void DPLLCFMACCF(INBOMMMFAFB OJAGLBPPOJC, IKSolverVR.Arm ENPCPPJPOPM, Transform GJCNHBBNDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x74A64B0", Offset = "0x74A56B0", VA = "0x1874A64B0")]
	private void AFNINKCIJAL(NIOHGDOCKME LEOMHHEDCFC, AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x74A9040", Offset = "0x74A8240", VA = "0x1874A9040")]
	private void CEIFGDBOPCC(MGEENGMJPGI PMLILFCFAFJ, CPPODONDALD OJAGLBPPOJC, IKSolverVR.Arm ENPCPPJPOPM, float PGBINNCCFGH, float POCJCIAFDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x74BB550", Offset = "0x74BA750", VA = "0x1874BB550")]
	private void NGLBLBEHHGA([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x74AA570", Offset = "0x74A9770", VA = "0x1874AA570")]
	protected void DNFMAPIGBOG([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x74B62D0", Offset = "0x74B54D0", VA = "0x1874B62D0")]
	private void JKKACHMIFFJ([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x74BEEC0", Offset = "0x74BE0C0", VA = "0x1874BEEC0")]
	protected void OPMHLOFJMGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x74B7580", Offset = "0x74B6780", VA = "0x1874B7580")]
	private void KHPIMEGOIKM([In] NIOHGDOCKME LEOMHHEDCFC, [In] IKPKLGOAJKH BDKDGELDCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x74A9650", Offset = "0x74A8850", VA = "0x1874A9650")]
	private void DCHJJJJLFCF(NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x74A9250", Offset = "0x74A8450", VA = "0x1874A9250")]
	private void CFKHBDOOMKJ([In] NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x74B5D30", Offset = "0x74B4F30", VA = "0x1874B5D30")]
	private Vector3 JGPAGNNNAKD([In] NIOHGDOCKME LEOMHHEDCFC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x74BE2A0", Offset = "0x74BD4A0", VA = "0x1874BE2A0")]
	private void OBEAFBEJFEC([In] NIOHGDOCKME LEOMHHEDCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x74BBD50", Offset = "0x74BAF50", VA = "0x1874BBD50")]
	private float NIEEGAPHJNN(float DLJILMACPAH, [In] NIOHGDOCKME LEOMHHEDCFC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x74BDE70", Offset = "0x74BD070", VA = "0x1874BDE70")]
	private void NPKLEMKFCAI(float DLJILMACPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x74B96D0", Offset = "0x74B88D0", VA = "0x1874B96D0")]
	private void NAFNKCBCNFB([In] NIOHGDOCKME LEOMHHEDCFC, IKPKLGOAJKH BDKDGELDCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x74A6910", Offset = "0x74A5B10", VA = "0x1874A6910")]
	private float AKJAEBAJCLP([In] NIOHGDOCKME EFJIJEKHOJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x74AE5A0", Offset = "0x74AD7A0", VA = "0x1874AE5A0")]
	private void FPNLHNOEIIM(NIOHGDOCKME LEOMHHEDCFC, IKPKLGOAJKH BDKDGELDCFJ, Vector3 CLCFOJEHPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x74B9DC0", Offset = "0x74B8FC0", VA = "0x1874B9DC0")]
	private static void NBAAHDMPHOI(Transform LBAHEDDLOKA, Quaternion GLMEOLPKLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x74B65A0", Offset = "0x74B57A0", VA = "0x1874B65A0")]
	private void JMFOCMGINEK([In] NIOHGDOCKME MIFEOHCLCHH, [In] CIABHEALBGL OCKCLOCDBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x74A9800", Offset = "0x74A8A00", VA = "0x1874A9800")]
	private void DDMBBLJCHDA([In] NIOHGDOCKME MIFEOHCLCHH, [In] CIABHEALBGL OCKCLOCDBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x74A7470", Offset = "0x74A6670", VA = "0x1874A7470")]
	private void BCGCBLLJJEN(float FLMNGHPHMLH, [In] NIOHGDOCKME EFJIJEKHOJN, float INMAFNAGADB = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x74B29F0", Offset = "0x74B1BF0", VA = "0x1874B29F0")]
	private float HOCFOHMEPLL([In] NIOHGDOCKME EFJIJEKHOJN, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x74A8250", Offset = "0x74A7450", VA = "0x1874A8250")]
	private void CBOIJHMAFLM([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x74A7660", Offset = "0x74A6860", VA = "0x1874A7660")]
	private void BEPNJJGAION([In] NIOHGDOCKME EFJIJEKHOJN, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x74AA0C0", Offset = "0x74A92C0", VA = "0x1874AA0C0")]
	private void DGCIDGJKKNN([In] NIOHGDOCKME EFJIJEKHOJN, float FHJHGALCPHN, float EECPAEAABJC, Vector3 IINFGFBHOCI, float INMAFNAGADB = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x74A8640", Offset = "0x74A7840", VA = "0x1874A8640")]
	private void CDPCIGOHBLH(NIOHGDOCKME EFJIJEKHOJN, AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x74B03C0", Offset = "0x74AF5C0", VA = "0x1874B03C0")]
	private void HKGDDLKFJBE(NIOHGDOCKME LEOMHHEDCFC, AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x74A9310", Offset = "0x74A8510", VA = "0x1874A9310")]
	private void CMNCKIKPIJB(NIOHGDOCKME EFJIJEKHOJN, AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x74B7050", Offset = "0x74B6250", VA = "0x1874B7050")]
	public void KHEDIKHAOAF([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x74B6BE0", Offset = "0x74B5DE0", VA = "0x1874B6BE0")]
	public void KEDNFAPPMEO([In] NIOHGDOCKME LEOMHHEDCFC, [In] AvatarFullBodyConfiguration PEFAADKBJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x74AFAC0", Offset = "0x74AECC0", VA = "0x1874AFAC0")]
	[CompilerGenerated]
	internal static void GOEEIIFKNAI(Transform HDPIMFNJLMN, IKSolverVR.Arm ENPCPPJPOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x74AB7D0", Offset = "0x74AA9D0", VA = "0x1874AB7D0")]
	[CompilerGenerated]
	internal static void EKDPPBJFDPJ(Vector3 AJMLLEGNOLP, Vector3 MCNHMOBBNFJ, JGBLJAJEAFG P_2, MODELKMAOPP P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x74AA4D0", Offset = "0x74A96D0", VA = "0x1874AA4D0")]
	[CompilerGenerated]
	internal static void DNCCPFDDIAJ(KLIJLALMOLL ADBGDHCMLJG, KLIJLALMOLL BHIMEOEDDJO, Vector3 GBMNFCAEBLK, float HHOJHACJLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x74B4260", Offset = "0x74B3460", VA = "0x1874B4260")]
	[CompilerGenerated]
	internal static bool IOOKGCICELK(IKSolverVR.Arm ENPCPPJPOPM, DHHDCJAODML IFMEPLLJIOM, float JLEAFABAPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x74AEF00", Offset = "0x74AE100", VA = "0x1874AEF00")]
	[CompilerGenerated]
	internal static float GDGGPPFENHA(Vector3 PHFMDIEOIJG, Vector3 CKMNEMIDMKI, Vector3 LPACBLBPLIM, NIOHGDOCKME EFJIJEKHOJN, AvatarFullBodyConfiguration PEFAADKBJGB, float DCNPLBBIONO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class FJBMLPPOPJI : CBPDLCPBACE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<string, CCHMIHJCEII> PJLNABBIAAE;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x74C8910", Offset = "0x74C7B10", VA = "0x1874C8910")]
	[LDKBBAENJDF.JPBGCAANJAC]
	internal static void MGFCHDKJOCJ(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x74C8680", Offset = "0x74C7880", VA = "0x1874C8680", Slot = "4")]
	public CCHMIHJCEII JABBLEBMABN(string OBPAAGBIKFO, AvatarSystemConfiguration OPNCBCHKJOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x74C8360", Offset = "0x74C7560", VA = "0x1874C8360", Slot = "5")]
	public void CBMKJDDFHKF(string OBPAAGBIKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x74C8540", Offset = "0x74C7740", VA = "0x1874C8540", Slot = "6")]
	public string IOPEONCFJHJ(string PFKNOHJLDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x74C88A0", Offset = "0x74C7AA0", VA = "0x1874C88A0")]
	private string KMAEBGDPGCA(string PFKNOHJLDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x74C8980", Offset = "0x74C7B80", VA = "0x1874C8980")]
	public FJBMLPPOPJI()
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
		public class OKPBNACHPLG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private Dictionary<string, Transform> GHCHNMFICGM;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool KHBFGBFEAPJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x74CB6A0", Offset = "0x74CA8A0", VA = "0x1874CB6A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x74CB6E0", Offset = "0x74CA8E0", VA = "0x1874CB6E0")]
			public void ONGOAFEAHOI(VRIK OAKAOKIPBAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
			public void EKHOBMHBJLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x74CB650", Offset = "0x74CA850", VA = "0x1874CB650")]
			public void DICECPNPBPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x74CB810", Offset = "0x74CAA10", VA = "0x1874CB810")]
			public OKPBNACHPLG()
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
		[CLMHABBIPJG(ADOEJJMOABO.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly OKPBNACHPLG ENDLBPDNGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private ODJOFHGEPKH GOKGNKBFCFB;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x74C1410", Offset = "0x74C0610", VA = "0x1874C1410")]
		private void PDAIGIIELDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x74C13B0", Offset = "0x74C05B0", VA = "0x1874C13B0")]
		private bool BFJEMLLPHFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x74C1400", Offset = "0x74C0600", VA = "0x1874C1400")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x74C1750", Offset = "0x74C0950", VA = "0x1874C1750")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x74C16F0", Offset = "0x74C08F0", VA = "0x1874C16F0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x74C19C0", Offset = "0x74C0BC0", VA = "0x1874C19C0")]
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
				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x74C8B50", Offset = "0x74C7D50", VA = "0x1874C8B50")]
			public void EMBIHAFPMPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x74C8A10", Offset = "0x74C7C10", VA = "0x1874C8A10")]
			public (float, float) AEHLPEJPPNE(Animator INJNALGDFPD, AnimatorStateInfo OBMKFFGCEMH)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x74C8C30", Offset = "0x74C7E30", VA = "0x1874C8C30")]
		public void EMBIHAFPMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x74C9010", Offset = "0x74C8210", VA = "0x1874C9010")]
		public (float, float) NBOBPJMCFOB(Animator INJNALGDFPD)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x74C8E20", Offset = "0x74C8020", VA = "0x1874C8E20")]
		private (float, float) MOICFHIFDPP(Animator INJNALGDFPD, AnimatorStateInfo OBMKFFGCEMH)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x74C9220", Offset = "0x74C8420", VA = "0x1874C9220")]
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

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x74CAA40", Offset = "0x74C9C40", VA = "0x1874CAA40", Slot = "4")]
		public override void OnStateEnter(Animator INJNALGDFPD, AnimatorStateInfo OBMKFFGCEMH, int PKNBHJLBCGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x74CABA0", Offset = "0x74C9DA0", VA = "0x1874CABA0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class FFLCPFNGNDI<TInput, TOutput> : OFHKCANJFFO<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected readonly IDECIICAEAC GMEPCNOKEEA;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x44BED70", Offset = "0x44BDF70", VA = "0x1844BED70")]
	protected FFLCPFNGNDI(IDECIICAEAC GMEPCNOKEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput ANADGBKPLNB(TInput GEDAGNGPIPL, [Out] IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM);

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x44BECD0", Offset = "0x44BDED0", VA = "0x1844BECD0", Slot = "5")]
	public bool NBPDDNOHICF(TInput GEDAGNGPIPL, [Out] TOutput? CMLOHOMLNDL, [Out] IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[ALDPDJHMICB]
public static class AKFNDDEAJBK
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly Regex FEJJKIOGBBI;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x74C05D0", Offset = "0x74BF7D0", VA = "0x1874C05D0")]
	public static DGJDKBEIGIE IKNCJMBHJFC(DBNNFNBKLPB HOHKDEHCGNG, KFKBHGMMOEG JGBBMMOMOID, Guid? DLBJLJBGNMD, Color? NHEBJDEJMOI, OCHNHLJBAPP GPIHEODLCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x74C0470", Offset = "0x74BF670", VA = "0x1874C0470")]
	public static BGAANIHBCHM DICAGEDCBJI(DGJDKBEIGIE LJELDKAOCJM)
	{
		return default(BGAANIHBCHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4E60", Offset = "0x3BD4060", VA = "0x183BD4E60")]
	internal static TModern? CFIKJFANFFF<TModern>(string? GEDAGNGPIPL, AHJHCCMBMGO<TModern> JFINBLEAPOP, IDECIICAEAC GMEPCNOKEEA, GKONKPAPAMB KANAACGJKMM, TModern JFBPKOLLFKC) where TModern : struct, AEJFKFOGKPI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3BD4680", Offset = "0x3BD3880", VA = "0x183BD4680")]
	internal static IALJOOANPCN CANALGJHNME<TModern>(string? GEDAGNGPIPL, AHJHCCMBMGO<TModern> JFINBLEAPOP, IDECIICAEAC GMEPCNOKEEA, GKONKPAPAMB KANAACGJKMM, TModern JFBPKOLLFKC) where TModern : struct, AEJFKFOGKPI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74C07E0", Offset = "0x74BF9E0", VA = "0x1874C07E0")]
	internal static List<HEIEKFIPJDC> LNNEIHADPOD(IEnumerable<JKBICMDOACD>? BOHDKBFLAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3BD3800", Offset = "0x3BD2A00", VA = "0x183BD3800")]
	internal static string BIMNINDPCMG<TModern>(TModern GEDAGNGPIPL, AHJHCCMBMGO<TModern> JFINBLEAPOP, IDECIICAEAC GMEPCNOKEEA) where TModern : AEJFKFOGKPI
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class KGDJDHOODOF : DPBGFALCFDJ
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OFHKCANJFFO<CFKEFOBOAHH, CDBIINFMANM> OKKIPFHJAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public OFHKCANJFFO<KPOBLAONNLH, AOMAMMEEDPL> ADHHFFEJNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OFHKCANJFFO<KPOBLAONNLH, AOMAMMEEDPL> OKIMCAGDJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CCKBBKBDMGG MGLGAEIMDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DNGECEGKCEL GKEFFLNFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x74C9430", Offset = "0x74C8630", VA = "0x1874C9430")]
	[LDKBBAENJDF.JPBGCAANJAC.KOPKNLHMHAB]
	[UsedImplicitly]
	internal static void IHPHHJOMFAA(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x74C94A0", Offset = "0x74C86A0", VA = "0x1874C94A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal KGDJDHOODOF([KMMHIEIDBEA("UnitySerialization")] JDJCAEMIMJF JFINKLNLCKA, [KMMHIEIDBEA(null)] OPMMEONFMCI CNLKGLJAPNF, [KMMHIEIDBEA(null)] IDECIICAEAC GMEPCNOKEEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum AFCODENBFLC
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
public class NLALIIPEPIK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x74CAC30", Offset = "0x74C9E30", VA = "0x1874CAC30")]
	public NLALIIPEPIK(string DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x74CABC0", Offset = "0x74C9DC0", VA = "0x1874CABC0")]
	public NLALIIPEPIK(string DCEACFEGBDC, Exception EBAOCMFIDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x74CAC60", Offset = "0x74C9E60", VA = "0x1874CAC60")]
	public NLALIIPEPIK(AFCODENBFLC GEDIIGIDHKB, string DCEACFEGBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x74CABF0", Offset = "0x74C9DF0", VA = "0x1874CABF0")]
	public NLALIIPEPIK(AFCODENBFLC GEDIIGIDHKB, string DCEACFEGBDC, Exception EBAOCMFIDOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class DDFFCHDFEHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly JDJCAEMIMJF JFINKLNLCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly OPMMEONFMCI CNLKGLJAPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly IDECIICAEAC GMEPCNOKEEA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x74C2190", Offset = "0x74C1390", VA = "0x1874C2190")]
	protected DDFFCHDFEHG(JDJCAEMIMJF JFINKLNLCKA, OPMMEONFMCI CNLKGLJAPNF, IDECIICAEAC GMEPCNOKEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x74C54A0", Offset = "0x74C46A0", VA = "0x1874C54A0")]
	protected string FGGGAFIAHFM(CDBIINFMANM PHMGCMMAOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x74C6AA0", Offset = "0x74C5CA0", VA = "0x1874C6AA0")]
	protected string OBDEAONNOJO(CDBIINFMANM PHMGCMMAOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x74C6770", Offset = "0x74C5970", VA = "0x1874C6770")]
	private AvatarOutfitSelectionData IKNCJMBHJFC(DGJDKBEIGIE IPFCDNMNPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x74C5360", Offset = "0x74C4560", VA = "0x1874C5360")]
	private static AvatarCustomizationSettingsData.AnchorParams DOCJBNPPHCA(FJJMJDFJPJG? EHNIJMNMNAM)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface OFHKCANJFFO<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput ANADGBKPLNB(TInput GEDAGNGPIPL, [Out] IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBPDDNOHICF(TInput GEDAGNGPIPL, [Out] TOutput? CMLOHOMLNDL, [Out] IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DPBGFALCFDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	OFHKCANJFFO<CFKEFOBOAHH, CDBIINFMANM> OKKIPFHJAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OFHKCANJFFO<KPOBLAONNLH, AOMAMMEEDPL> OKIMCAGDJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	CCKBBKBDMGG MGLGAEIMDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum GKONKPAPAMB
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DNGECEGKCEL
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LFLAHNHJHEB JEAAONFOJJH(CDBIINFMANM LJELDKAOCJM);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CCKBBKBDMGG
{
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPOBLAONNLH JEAAONFOJJH(CDBIINFMANM LJELDKAOCJM, int JDBHPOPEKHM, string? MBDFMCIDAOB, string? HGHINACJKMG, NHEBJNLJFEG GHHCIIPBHNJ, List<HEIEKFIPJDC>? DFDDJAMNKNM);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ALDPDJHMICB]
internal class BKAFGBHHPEB : FFLCPFNGNDI<CFKEFOBOAHH, CDBIINFMANM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly OPMMEONFMCI CNLKGLJAPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly BOMKMPMCDPP FACEFLAHDPB;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x74C25B0", Offset = "0x74C17B0", VA = "0x1874C25B0")]
	public BKAFGBHHPEB(JDJCAEMIMJF JFINKLNLCKA, OPMMEONFMCI CNLKGLJAPNF, IDECIICAEAC GMEPCNOKEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x74C2310", Offset = "0x74C1510", VA = "0x1874C2310", Slot = "6")]
	public override CDBIINFMANM ANADGBKPLNB(CFKEFOBOAHH GEDAGNGPIPL, [Out] IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class CBLDIEPMBNC : JDJCAEMIMJF
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class IPGDIGJMNNG : JsonConverter<IALJOOANPCN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x74C9350", Offset = "0x74C8550", VA = "0x1874C9350", Slot = "9")]
		public override void WriteJson(JsonWriter DKHAABKGBIG, IALJOOANPCN? OMFJNFBDJCA, JsonSerializer CLJAHMKEHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x74C9230", Offset = "0x74C8430", VA = "0x1874C9230", Slot = "10")]
		public override IALJOOANPCN ReadJson(JsonReader KLIFEKFIIAG, Type NOOGDGHCMBG, IALJOOANPCN? BOGEEMFBEMN, bool PMJJLHKMDDM, JsonSerializer CLJAHMKEHLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x74C93F0", Offset = "0x74C85F0", VA = "0x1874C93F0")]
		public IPGDIGJMNNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class COIBKIGDNLH : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool DCFOAAIHDCI
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x74C5220", Offset = "0x74C4420", VA = "0x1874C5220", Slot = "5")]
		public override object ReadJson(JsonReader KLIFEKFIIAG, Type NOOGDGHCMBG, object? BOGEEMFBEMN, JsonSerializer CLJAHMKEHLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x74C4E40", Offset = "0x74C4040", VA = "0x1874C4E40", Slot = "6")]
		public override bool CanConvert(Type NOOGDGHCMBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x74C5280", Offset = "0x74C4480", VA = "0x1874C5280", Slot = "4")]
		public override void WriteJson(JsonWriter DKHAABKGBIG, object? OMFJNFBDJCA, JsonSerializer CLJAHMKEHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x74C5020", Offset = "0x74C4220", VA = "0x1874C5020")]
		private static bool HONPHPLOEJI(object OMFJNFBDJCA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
		public COIBKIGDNLH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings KNCIOLDEMIH;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x74C4CE0", Offset = "0x74C3EE0", VA = "0x1874C4CE0")]
	internal CBLDIEPMBNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x3265400", Offset = "0x3264600", VA = "0x183265400", Slot = "4")]
	public string MOMKNIKBEMG<T>(T ONELFPFEALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x3265370", Offset = "0x3264570", VA = "0x183265370", Slot = "5")]
	public T AOHCEIBEPBO<T>(string OMFJNFBDJCA)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class KNDHANJIIBO : JDJCAEMIMJF
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x352D410", Offset = "0x352C610", VA = "0x18352D410", Slot = "4")]
	public string MOMKNIKBEMG<T>(T ONELFPFEALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x352D3A0", Offset = "0x352C5A0", VA = "0x18352D3A0", Slot = "5")]
	public T AOHCEIBEPBO<T>(string OMFJNFBDJCA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
	public KNDHANJIIBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ALDPDJHMICB]
internal class BOMKMPMCDPP : FFLCPFNGNDI<KPOBLAONNLH, AOMAMMEEDPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly JDJCAEMIMJF JFINKLNLCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly OPMMEONFMCI CNLKGLJAPNF;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x74C4BA0", Offset = "0x74C3DA0", VA = "0x1874C4BA0")]
	public BOMKMPMCDPP(JDJCAEMIMJF JFINKLNLCKA, OPMMEONFMCI CNLKGLJAPNF, IDECIICAEAC GMEPCNOKEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x74C2BA0", Offset = "0x74C1DA0", VA = "0x1874C2BA0", Slot = "6")]
	public override AOMAMMEEDPL ANADGBKPLNB(KPOBLAONNLH GEDAGNGPIPL, [Out] IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x74C4830", Offset = "0x74C3A30", VA = "0x1874C4830")]
	internal void GPJGHEAEOBK(string JCOCLLFGJBJ, CDBIINFMANM PHMGCMMAOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x74C4990", Offset = "0x74C3B90", VA = "0x1874C4990")]
	public IEnumerable<DGJDKBEIGIE> JDKDOJIIMEH(string FLLIKNDGLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x74C2780", Offset = "0x74C1980", VA = "0x1874C2780")]
	private IEnumerable<DGJDKBEIGIE> AEEGHLNCCPA(string FLLIKNDGLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x74C31C0", Offset = "0x74C23C0", VA = "0x1874C31C0")]
	internal IEnumerable<DGJDKBEIGIE> BCIKEFNNALC(string FLLIKNDGLFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x74C3E90", Offset = "0x74C3090", VA = "0x1874C3E90")]
	private DGJDKBEIGIE FPFDMBLIJOB(AvatarOutfitSelectionData OKPABEGKOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x74C3610", Offset = "0x74C2810", VA = "0x1874C3610")]
	private void EAHPFMDFHCB(AvatarCustomizationSettingsData DKJNIBNLOOG, CDBIINFMANM PHMGCMMAOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x74C4210", Offset = "0x74C3410", VA = "0x1874C4210")]
	private DGJDKBEIGIE FPFDMBLIJOB(string CCOPGKAFGPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x74C4530", Offset = "0x74C3730", VA = "0x1874C4530")]
	internal static (OCHNHLJBAPP, string, string) GLLNELJIICL(string CCOPGKAFGPG, IDECIICAEAC GMEPCNOKEEA)
	{
		return default((OCHNHLJBAPP, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x74C2FC0", Offset = "0x74C21C0", VA = "0x1874C2FC0")]
	private CJAOLDPFAPJ? AOBOOMJKEDK(string? FGPNICIMMFP, Vector2 AGLFFJJMOBJ, float DICDCKDEFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x74C4A40", Offset = "0x74C3C40", VA = "0x1874C4A40")]
	private static FJJMJDFJPJG LCJEBCJGECH(AvatarCustomizationSettingsData.AnchorParams FNCCLLILEHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[ALDPDJHMICB]
internal class BHKDCOBCNCA : DDFFCHDFEHG, DNGECEGKCEL
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x74C2190", Offset = "0x74C1390", VA = "0x1874C2190")]
	public BHKDCOBCNCA(JDJCAEMIMJF JFINKLNLCKA, OPMMEONFMCI CNLKGLJAPNF, IDECIICAEAC GMEPCNOKEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x74C1DE0", Offset = "0x74C0FE0", VA = "0x1874C1DE0", Slot = "4")]
	public LFLAHNHJHEB JEAAONFOJJH(CDBIINFMANM LJELDKAOCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x74C1CE0", Offset = "0x74C0EE0", VA = "0x1874C1CE0")]
	private string FKDOMACCHBM(CDBIINFMANM PHMGCMMAOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x74C1AA0", Offset = "0x74C0CA0", VA = "0x1874C1AA0")]
	private string DPAJEDOFBOJ(DGJDKBEIGIE IPFCDNMNPKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[ALDPDJHMICB]
internal class OCIKGMNGHIB : FFLCPFNGNDI<KPOBLAONNLH, AOMAMMEEDPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly JDJCAEMIMJF JFINKLNLCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly OFHKCANJFFO<KPOBLAONNLH, AOMAMMEEDPL> JAOPELJJHPP;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x74CB0C0", Offset = "0x74CA2C0", VA = "0x1874CB0C0")]
	public OCIKGMNGHIB(OFHKCANJFFO<KPOBLAONNLH, AOMAMMEEDPL> JAOPELJJHPP, IDECIICAEAC GMEPCNOKEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x74CAC90", Offset = "0x74C9E90", VA = "0x1874CAC90", Slot = "6")]
	public override AOMAMMEEDPL ANADGBKPLNB(KPOBLAONNLH GEDAGNGPIPL, [Out] IReadOnlyList<HEIEKFIPJDC>? DFDDJAMNKNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ALDPDJHMICB]
internal class OFHBKJKCIGC : CCKBBKBDMGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly JDJCAEMIMJF JFINKLNLCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly DNGECEGKCEL FCDFMCJGIAH;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x74CB560", Offset = "0x74CA760", VA = "0x1874CB560")]
	public OFHBKJKCIGC(DNGECEGKCEL FCDFMCJGIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x74CB1C0", Offset = "0x74CA3C0", VA = "0x1874CB1C0", Slot = "4")]
	public KPOBLAONNLH JEAAONFOJJH(CDBIINFMANM LJELDKAOCJM, int JDBHPOPEKHM, string? MBDFMCIDAOB, string? HGHINACJKMG, NHEBJNLJFEG GHHCIIPBHNJ, List<HEIEKFIPJDC>? DFDDJAMNKNM)
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

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x74C0A70", Offset = "0x74BFC70", VA = "0x1874C0A70")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MAJBNLHEMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x74CA7B0", Offset = "0x74C99B0", VA = "0x1874CA7B0")]
	public static BGAANIHBCHM ANADGBKPLNB(this IENJJIFEKEC LJELDKAOCJM)
	{
		return default(BGAANIHBCHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x74CA920", Offset = "0x74C9B20", VA = "0x1874CA920")]
	public static IENJJIFEKEC JEAAONFOJJH(this BGAANIHBCHM CPHPMAOLCBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x74CA8C0", Offset = "0x74C9AC0", VA = "0x1874CA8C0")]
	public static bool CGHMNDFMBKC(this BGAANIHBCHM CPHPMAOLCBE)
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

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x56AFC00", Offset = "0x56AEE00", VA = "0x1856AFC00")]
			public AnchorParams(Vector2 JIHHAGGDEOO, Vector3 CLMIKENBGKJ, Vector3 NFIDKIBCEOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x74C09C0", Offset = "0x74BFBC0", VA = "0x1874C09C0")]
			internal FJJMJDFJPJG JEAAONFOJJH()
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
		private PAOLLJPJFIC useHelmetHair;

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
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x74C1260", Offset = "0x74C0460", VA = "0x1874C1260")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x46391B0", Offset = "0x46383B0", VA = "0x1846391B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xBB6150", Offset = "0xBB5350", VA = "0x180BB6150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xDEFA00", Offset = "0xDEEC00", VA = "0x180DEFA00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x108E200", Offset = "0x108D400", VA = "0x18108E200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x74C1300", Offset = "0x74C0500", VA = "0x1874C1300")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x96EC10", Offset = "0x96DE10", VA = "0x18096EC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAE4140", Offset = "0xAE3340", VA = "0x180AE4140")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xAE43B0", Offset = "0xAE35B0", VA = "0x180AE43B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x964EF0", Offset = "0x9640F0", VA = "0x180964EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x74C1340", Offset = "0x74C0540", VA = "0x1874C1340")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xD2EC50", Offset = "0xD2DE50", VA = "0x180D2EC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xF3EC20", Offset = "0xF3DE20", VA = "0x180F3EC20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1592480", Offset = "0x1591680", VA = "0x181592480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x961600", Offset = "0x960800", VA = "0x180961600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x961660", Offset = "0x960860", VA = "0x180961660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x204A760", Offset = "0x2049960", VA = "0x18204A760")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xD2EF00", Offset = "0xD2E100", VA = "0x180D2EF00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x998AE0", Offset = "0x997CE0", VA = "0x180998AE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x998B40", Offset = "0x997D40", VA = "0x180998B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x970660", Offset = "0x96F860", VA = "0x180970660")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9707C0", Offset = "0x96F9C0", VA = "0x1809707C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9707D0", Offset = "0x96F9D0", VA = "0x1809707D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x970750", Offset = "0x96F950", VA = "0x180970750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x970710", Offset = "0x96F910", VA = "0x180970710")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x970670", Offset = "0x96F870", VA = "0x180970670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAD2120", Offset = "0xAD1320", VA = "0x180AD2120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x117A830", Offset = "0x1179A30", VA = "0x18117A830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x9707A0", Offset = "0x96F9A0", VA = "0x1809707A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9706F0", Offset = "0x96F8F0", VA = "0x1809706F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xBDB360", Offset = "0xBDA560", VA = "0x180BDB360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD5E830", Offset = "0xD5DA30", VA = "0x180D5E830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x969760", Offset = "0x968960", VA = "0x180969760")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x969740", Offset = "0x968940", VA = "0x180969740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12C30", VA = "0x180B13A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xD33230", Offset = "0xD32430", VA = "0x180D33230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB72F40", Offset = "0xB72140", VA = "0x180B72F40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB6EFE0", Offset = "0xB6E1E0", VA = "0x180B6EFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public PAOLLJPJFIC UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xDF9210", Offset = "0xDF8410", VA = "0x180DF9210")]
			get
			{
				return default(PAOLLJPJFIC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xDF9350", Offset = "0xDF8550", VA = "0x180DF9350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xDF71C0", Offset = "0xDF63C0", VA = "0x180DF71C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xAC3370", Offset = "0xAC2570", VA = "0x180AC3370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x74C1320", Offset = "0x74C0520", VA = "0x1874C1320")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x74C1360", Offset = "0x74C0560", VA = "0x1874C1360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x74C0F00", Offset = "0x74C0100", VA = "0x1874C0F00")]
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

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
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
		public OCHNHLJBAPP BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private FAFHJKJKKAE? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x74C1380", Offset = "0x74C0580", VA = "0x1874C1380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
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

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
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
