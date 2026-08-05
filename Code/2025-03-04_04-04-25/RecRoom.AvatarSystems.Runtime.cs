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
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
		[Cpp2IlInjected.Address(RVA = "0x73C6DB0", Offset = "0x73C53B0", VA = "0x1873C6DB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
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
		[Cpp2IlInjected.Address(RVA = "0x73C6E30", Offset = "0x73C5430", VA = "0x1873C6E30", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GAFKBMEFLIK]
internal class DKADGEEBINK : PKKLBBLHCMJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct BFIPMADPOCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public DKADGEEBINK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public PKOOKMMPLDP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LJMKFGLLKIF JAFCDDNFAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly NAGJADLJCMA GICAIHKOEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NBLGDMHJAEN PDLAIAJBAKN;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x73ABFF0", Offset = "0x73AA5F0", VA = "0x1873ABFF0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	[UsedImplicitly]
	internal static void IPHGFHNDJOJ(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x73ACF40", Offset = "0x73AB540", VA = "0x1873ACF40")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DKADGEEBINK([IBJCGEMJMJL(null)] LJMKFGLLKIF JAFCDDNFAAN, [IBJCGEMJMJL(null)] NAGJADLJCMA GICAIHKOEHF, [IBJCGEMJMJL(null)] NBLGDMHJAEN PDLAIAJBAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73AB840", Offset = "0x73A9E40", VA = "0x1873AB840", Slot = "5")]
	public PHGEAGLPDDM IDKDDCINLDM(PKOOKMMPLDP HMKELMICGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x73AC510", Offset = "0x73AAB10", VA = "0x1873AC510", Slot = "4")]
	public PHGEAGLPDDM NDOEDGOEBDP(PKOOKMMPLDP HMKELMICGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73AB730", Offset = "0x73A9D30", VA = "0x1873AB730", Slot = "6")]
	public OJDOIIFPLOL GMBAJNONNFE(PHGEAGLPDDM GIDGOODJFLJ, int CPNKOGECOFG, string? OMOOEGOLALI, string? NHLFNJPNHKL, IKKNJNIMHHO NBNPMENJBOH, List<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x73AC0F0", Offset = "0x73AA6F0", VA = "0x1873AC0F0", Slot = "7")]
	public bool JMLGBBJJIDO(JMICKPPNDJO NKILLPHANBF, [Out] PHGEAGLPDDM? ALBFPGNJIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x73AB650", Offset = "0x73A9C50", VA = "0x1873AB650", Slot = "8")]
	public bool FFBIILKFKIF(OJDOIIFPLOL JJDEENKABFF, [Out] PHGEAGLPDDM? ALBFPGNJIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x73AC060", Offset = "0x73AA660", VA = "0x1873AC060", Slot = "9")]
	public bool JJCHFPLLKIO(OJDOIIFPLOL JJDEENKABFF, [Out] IJBHONDDGJA? NKILLPHANBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3251410", Offset = "0x324FA10", VA = "0x183251410")]
	private bool FLMLPENGKEK<TInput, TOutput>(TInput IOJLNNHDMIE, KMANENIEGGA<TInput, TOutput> MADBDOIPJNJ, [Out] TOutput? BIEIOPPGBOB) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x73AC180", Offset = "0x73AA780", VA = "0x1873AC180")]
	[CompilerGenerated]
	private DALAGIAKGMF JPEGNGFLLDM(FaceFeatureType KGLDHIDPHPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x73AC330", Offset = "0x73AA930", VA = "0x1873AC330")]
	[CompilerGenerated]
	private DALAGIAKGMF MMIAKCFMNHB(FaceFeatureType KGLDHIDPHPP, BFIPMADPOCC P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[GAFKBMEFLIK]
internal class AMCJBEGLDFG : LJMKFGLLKIF
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void KAEJHOAOLOH<in TData>(TData ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NBLGDMHJAEN PDLAIAJBAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CCAOPILOOAO AJLMACGMCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KAEJHOAOLOH<PHGEAGLPDDM>?[] JAFCDDNFAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KAEJHOAOLOH<IJBHONDDGJA>?[] DAGFAFKFHPJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x73A8D20", Offset = "0x73A7320", VA = "0x1873A8D20")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	[UsedImplicitly]
	internal static void IPHGFHNDJOJ(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x73A8D90", Offset = "0x73A7390", VA = "0x1873A8D90")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AMCJBEGLDFG([IBJCGEMJMJL(null)] NBLGDMHJAEN PDLAIAJBAKN, [IBJCGEMJMJL(null)] CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x73A8C20", Offset = "0x73A7220", VA = "0x1873A8C20", Slot = "4")]
	public bool IHJNJICMFIC(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x73A8AC0", Offset = "0x73A70C0", VA = "0x1873A8AC0", Slot = "5")]
	public bool IHJNJICMFIC(IJBHONDDGJA NKILLPHANBF, IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x73A7C70", Offset = "0x73A6270", VA = "0x1873A7C70")]
	private void AJJBDHOAJBC(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x73A8890", Offset = "0x73A6E90", VA = "0x1873A8890")]
	private void IDODFMCMKLK(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x73A8860", Offset = "0x73A6E60", VA = "0x1873A8860")]
	private void GAFNFNKFINJ(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x73A8830", Offset = "0x73A6E30", VA = "0x1873A8830")]
	private void DENFILEDAMN(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x73A8760", Offset = "0x73A6D60", VA = "0x1873A8760")]
	private void CLLMJNOIOMI(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LJMKFGLLKIF
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHJNJICMFIC(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IHJNJICMFIC(IJBHONDDGJA NKILLPHANBF, IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);
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
		public IFFGGLLHIDG AnimationPoseType;

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

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x73A91E0", Offset = "0x73A77E0", VA = "0x1873A91E0")]
		public void KCNIDCGNHDF(AnimationPoseSetting OKCHLIEAIJP, float MMDPPNCKJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x73A9310", Offset = "0x73A7910", VA = "0x1873A9310")]
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
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
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

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x73A9C20", Offset = "0x73A8220", VA = "0x1873A9C20")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73A9BE0", Offset = "0x73A81E0", VA = "0x1873A9BE0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x73A9330", Offset = "0x73A7930", VA = "0x1873A9330")]
		private void CPMNJGPKHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x733A9B0", Offset = "0x7338FB0", VA = "0x18733A9B0", Slot = "4")]
		public void SetEnabled(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x73A9C50", Offset = "0x73A8250", VA = "0x1873A9C50")]
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

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x73A9C90", Offset = "0x73A8290", VA = "0x1873A9C90")]
		public AvatarFootSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		[Header("Turning")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering performing slow locomotion states.")]
		public float SlowSteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering based on velocity.")]
		public AnimationCurve SteeringRotationalFollowTimeAt180;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("Offset for the hip when prone using a bean body.")]
		public float VerticalHipOffsetWhenProneForBeans;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		[Header("Head Objects Placement")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x389")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("The duration of a lean.")]
		[Header("Leaning")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Speed for blending in screens animations.")]
		public float ScreensHandIkBlendInSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("Speed for blending in screens animations when idle.")]
		public float ScreensHandIkBlendInToIdleSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("Speed for blending out screens animations.")]
		public float ScreensHandIkBlendOutSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3DC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3EC")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("How much to twist shoulders when seated.")]
		[Header("Seated animation settings")]
		public float SeatedShoulderTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("Min/max value for vertical offset between animated and game head.")]
		public Vector2 SeatedLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("Pelvis weight used at the min and max limit based on the head offset. Pin on low to not sink through the seat, and allow to stand up when high.")]
		public Vector2 PelvisWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("Head weight used at the min and max limit based on the head offset.")]
		public Vector2 HeadWeightAtLimits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40C")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x414")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x418")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x440")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x444")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x448")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x450")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("How much the hips are locked to the pinned feet direction vs the desired body direction")]
		public float FootPinHipLockFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x454")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Max spine twist when locking feet")]
		public float FootPinMaxSpineTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x458")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AvatarFootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x460")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AvatarFootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x468")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x474")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x478")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x490")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x73A9D10", Offset = "0x73A8310", VA = "0x1873A9D10")]
		public AnimationPoseSetting DKHIGMLLGBE(IFFGGLLHIDG HPLCKDJMDBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x73A9CD0", Offset = "0x73A82D0", VA = "0x1873A9CD0")]
		public void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x73A9D40", Offset = "0x73A8340", VA = "0x1873A9D40")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum KKNOFIOJBHM
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private KKNOFIOJBHM handleType;

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

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x73AA810", Offset = "0x73A8E10", VA = "0x1873AA810")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x73AA7D0", Offset = "0x73A8DD0", VA = "0x1873AA7D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x73AA1B0", Offset = "0x73A87B0", VA = "0x1873AA1B0")]
		private void CPMNJGPKHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x733A9B0", Offset = "0x7338FB0", VA = "0x18733A9B0", Slot = "4")]
		public void SetEnabled(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x73AA840", Offset = "0x73A8E40", VA = "0x1873AA840")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, OOHCCBAOPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Header("Configuration")]
		private PKOOKMMPLDP avatarBodyType;

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
		[ALEFAIIJNEI(KCNGGJNCENB.SelfAndChildren, false, false, false)]
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
		[SerializeField]
		[Header("Facial Animation")]
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
		private IDDNGPPBDAI GPHFNFDKEBI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IDDNGPPBDAI KNJFGGHKLMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9BE9F0", Offset = "0x9BCFF0", VA = "0x1809BE9F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform CDCDMNLCAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x73AB630", Offset = "0x73A9C30", VA = "0x1873AB630", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x73AA870", Offset = "0x73A8E70", VA = "0x1873AA870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x73AB4F0", Offset = "0x73A9AF0", VA = "0x1873AB4F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x73AB4A0", Offset = "0x73A9AA0", VA = "0x1873AB4A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x73AB430", Offset = "0x73A9A30", VA = "0x1873AB430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x73AA870", Offset = "0x73A8E70", VA = "0x1873AA870", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x73AAC00", Offset = "0x73A9200", VA = "0x1873AAC00", Slot = "6")]
		public IDDNGPPBDAI CreateAvatarSystem(string MGIEGPEOHDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73AB430", Offset = "0x73A9A30", VA = "0x1873AB430", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x73AA930", Offset = "0x73A8F30", VA = "0x1873AA930", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x73AB540", Offset = "0x73A9B40", VA = "0x1873AB540", Slot = "9")]
		public void UpdatePostIKAnimControllers(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class NHEFKBAOHJL : IDDNGPPBDAI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class BALOIBDEDPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 IGKANPFKPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Quaternion NHKODHKLNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 NFLCCHMDBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Transform MGNNDGHPKNO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 CDKBMLLMCHP
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1CAB470", Offset = "0x1CA9A70", VA = "0x181CAB470")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1CAB490", Offset = "0x1CA9A90", VA = "0x181CAB490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion DIHBGLNNCIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x118BD40", Offset = "0x118A340", VA = "0x18118BD40")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x118BD50", Offset = "0x118A350", VA = "0x18118BD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float KKAIBNLLECI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xEEC120", Offset = "0xEEA720", VA = "0x180EEC120")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1510E50", Offset = "0x150F450", VA = "0x181510E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool GIJOHNIOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x956C70", Offset = "0x955270", VA = "0x180956C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x956C90", Offset = "0x955290", VA = "0x180956C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool EHAAIMFEGIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x956D20", Offset = "0x955320", VA = "0x180956D20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x956B00", Offset = "0x955100", VA = "0x180956B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool JLEGIIIPLCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x956D50", Offset = "0x955350", VA = "0x180956D50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x956CD0", Offset = "0x9552D0", VA = "0x180956CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float HFNELBBKDNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB45930", Offset = "0xB43F30", VA = "0x180B45930")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB45140", Offset = "0xB43740", VA = "0x180B45140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x73C82A0", Offset = "0x73C68A0", VA = "0x1873C82A0")]
		public void BEJBJJEMOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x73C8E10", Offset = "0x73C7410", VA = "0x1873C8E10")]
		public void MILFLGLIAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x73C82B0", Offset = "0x73C68B0", VA = "0x1873C82B0")]
		public float CFDCAIBGEFD(Vector3 PAEIDOAFBAO, Quaternion MAKGFJFKICI, [In] AvatarFootSettings DEJFCJMECLJ, float JPKKJDFGKMI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x73C84C0", Offset = "0x73C6AC0", VA = "0x1873C84C0")]
		public void HMBBPAFACDI(Vector3 KAKBBMINOOK, Quaternion KHFHJPMKDAL, Transform JDPJFMKKAEI, float JOEFAEEGMKM, bool NPLKHECDMBE, bool HBIIKMLGENI, float GIIFNCMCPJM, float DNKIMFGIPDP, Transform JGHOOBNHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x73C8E20", Offset = "0x73C7420", VA = "0x1873C8E20")]
		public void PJMAFCGAJBP(Transform KLKLKLMLBEN, Transform JGHOOBNHEJB, bool MNKBCCBAJFP, bool MCGLNFFIPLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x73C8D10", Offset = "0x73C7310", VA = "0x1873C8D10")]
		private void MAHKHLPIIFF(Transform JGHOOBNHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x73C8BC0", Offset = "0x73C71C0", VA = "0x1873C8BC0")]
		public void LNEOCKAGIFE(Transform JGHOOBNHEJB, AvatarFullBodyConfiguration HIGIOODIHPF, Vector3 COJIEECLAJE, float AELGJPDJBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x73C8BA0", Offset = "0x73C71A0", VA = "0x1873C8BA0")]
		public void IEJFMIAKMKO(float DNKIMFGIPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x73C9050", Offset = "0x73C7650", VA = "0x1873C9050")]
		public BALOIBDEDPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class DIHJEALGJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float ICOHGMAJDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool MEADLKMCNON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AnimationPoseSetting OKOFMALDBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private float NICLIOPEPFB;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x73CB420", Offset = "0x73C9A20", VA = "0x1873CB420")]
		public void MDEJCNPLCEK(IKSolverVR.Arm PKFMECEFJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x73CB3E0", Offset = "0x73C99E0", VA = "0x1873CB3E0")]
		public void LOLAHFJHLDG(IKSolverVR.Arm PKFMECEFJCK, float OCKGDAAALOM, bool MEADLKMCNON, AvatarFullBodyConfiguration HIGIOODIHPF, float GJIDBFHGEOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x73CA720", Offset = "0x73C8D20", VA = "0x1873CA720")]
		private void FDDMOOBOMPF(IKSolverVR.Arm PKFMECEFJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x73CA8C0", Offset = "0x73C8EC0", VA = "0x1873CA8C0")]
		public void HHGNPFAGNDA(IKSolverVR.Arm PKFMECEFJCK, Transform GPJJHFCHNAP, Transform JDPJFMKKAEI, Quaternion EFDNFIIDOGI, Vector3 NBJMCPHECLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x73C9DF0", Offset = "0x73C83F0", VA = "0x1873C9DF0")]
		private (Vector3, Quaternion) BIAIHFHPPLL(MNJGAOGMOGO CMGIOPNOPPF, Quaternion JJHKNKIFKLC, Vector3 NADACFGLLPB)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x73CA760", Offset = "0x73C8D60", VA = "0x1873CA760")]
		public void GNFLIDPMJCB(MNJGAOGMOGO CMGIOPNOPPF, IKSolverVR.Arm PKFMECEFJCK, Quaternion JJHKNKIFKLC, Vector3 NADACFGLLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x73CACA0", Offset = "0x73C92A0", VA = "0x1873CACA0")]
		public void JMOIFGEIBIG(MNJGAOGMOGO CMGIOPNOPPF, IKSolverVR.Arm PKFMECEFJCK, Quaternion JJHKNKIFKLC, Vector3 NADACFGLLPB, [In] AvatarFullBodyConfiguration HIGIOODIHPF, [In] MHPCHHPGEFC CEGAGHAOIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x73CB2A0", Offset = "0x73C98A0", VA = "0x1873CB2A0")]
		public void LDHGJKAHBIF(IFFGGLLHIDG DFOIMGIAHFM, AvatarFullBodyConfiguration HIGIOODIHPF, MHPCHHPGEFC CEGAGHAOIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x73CA280", Offset = "0x73C8880", VA = "0x1873CA280")]
		public void BPGHOBLEGMH(IKSolverVR.Arm PKFMECEFJCK, Transform GPJJHFCHNAP, Vector3 OKFHEBLMBFP, float KIDFJGNIONG, Quaternion CIIHGLMDKHO, Vector3 FDDMEDAODFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x73CB450", Offset = "0x73C9A50", VA = "0x1873CB450")]
		public DIHJEALGJLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum GNOANGAAJCA
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
	private struct LMOPPLDPKCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BCMLIPMBCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int IHPJHHNEJLB;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int NPOLHFCGNLF;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int JPFDLEDMPEG;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int JNAEBFGOHFB;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int CAACNMLBDEM;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int OPJPDBLCNCK;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int FLPAFMMEOBO;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int EAJPJDDCKAA;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int IODLIMOGGKI;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int LCALBAAFMNB;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int FNGIKKEJAGB;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int OJDBMCAPCME;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int DLMGLNLBHAB;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int FGBJCCFCHBD;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int GHBFMPMMOEG;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int AGIDGCLEPDK;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int IMBFDINKHDK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int JDIEKDIHIPJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int CGGDKKONGNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int GIDHLFMBPNM;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int EJBGEOKJFBG;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GFFOCAGHMKK;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int JBLEGOLKCHE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int FCJPDPEJGPA;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int NHODGPNAFPB;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int NIIMLBNPIBO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int MCMIOLNOBEL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int OBFCHAECGGM;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int GNDOMMFDFIC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int HHLLMGDEPMD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int BFFCBHPPAFI;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly Vector3 CHNBKEAHJOH;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int AEBKELJNPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool GCGAFPONJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool DAJJDNMIPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool LGDKJAGMNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool BAFDFGPECFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool ILPDCLGAONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool GOHLEABIBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Vector3 HNDHOBOBDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private string FKNBCDOEBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private EIBPNDHILPC? GCHMGNNGODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private JHIKEGLKIGM? BADAMHCAENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private ADOHCHALOBL HHDIOHFFFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private APDDFGMKIOL GMIJCCPBOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MNJGAOGMOGO PKJKEKAGLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private MNJGAOGMOGO CLFKCPDLIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool PIKOMELNOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool DFMKHANJJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly ANEBDMDAIKA JIANCOGBMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly IBIDNIBEJMN APPAHCDMMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int FPGHDELFCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private float PIGHMCPLCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GameObject GBHJLACICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform KDNFMAMKOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform DFLPLMENINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform PKEDPFPFIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform ILOFENKOOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float BBPKLGMMJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float DPHJJOAMMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 NAKKBBMCIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Quaternion MHHAIIKBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform EKAJNEALAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform GLENOLNNNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform NEMLCBMCHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PGOINNKIDBD LICKCKPMCDJ;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker KOHNNKDFJOE;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker OPCGNDOBBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ProfilerMarker CMJBPHJPCLE;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker IKPENMIOLAO;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker AGNAHDGCOEE;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker JPCGCFOBEGL;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly List<NHEFKBAOHJL> OJCECMONNCA;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int PAENLHGJAFB;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> IGDBMCDOMKI;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static int EBIHMCBOFLJ;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int NKKAPOCHJAP;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int MOAMEIOODNI;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int GBEENDNMPBD;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float KOKFGLKDBIH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int HFGNLFEKCCG;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static float ALNAAFBBENP;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float FNCAMMDIFBO;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float AIBIFMEEICB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float JOINIBJKOGB;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static DMNJILALDOD DNBILLIOMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float BLJIMDGPFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool ENDILCECCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float IMKNJMKCIPM;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly int GPLGGOJOFGD;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly int HMAMEHKGNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private BALOIBDEDPN OAOJKHIKLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private BALOIBDEDPN JAFHKHEAEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float IFIEBHOHIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Vector3 EIKIEIJJAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Vector3 ECNHHICGKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private bool HHKJGEKLJFP;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly Quaternion JNOJIENJJHO;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly Quaternion NDCMIPAAKJJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly Vector3 BLLFHHKDNBG;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Vector3 CIGBBCKBGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float BPCFHNJICKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float DACDDPIELDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private DIHJEALGJLM HJMOEKEGPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private DIHJEALGJLM JEIBLGEKFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DOMHNKOEMPK LFMCOFEEEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private KCPEMBEDOCH NBJIHDDDLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly EMEJJJFOJHP HBDNKEJPCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float CIPIANLPANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float MLCGGJMKPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly KCPEMBEDOCH OAHOJNEAJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Vector3 ALBCPECIBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 NHIFONPHHNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float NOBDCKGFOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float LBAAJDKIOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly KCPEMBEDOCH EEGAEIIBEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly DOMHNKOEMPK PKJOHHPCEIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly KCPEMBEDOCH GKDPGEMEFLJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FKDOIPNGGAF ANCAEJFHABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FKDOIPNGGAF MLCENMOLCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration LJNPOLOCLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x73B8890", Offset = "0x73B6E90", VA = "0x1873B8890", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PKOOKMMPLDP MFJBHKOKOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x73B9360", Offset = "0x73B7960", VA = "0x1873B9360", Slot = "23")]
		get
		{
			return default(PKOOKMMPLDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration IBEKKANLGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x73C2200", Offset = "0x73C0800", VA = "0x1873C2200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform BLKLODKKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x73ADB60", Offset = "0x73AC160", VA = "0x1873ADB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform AJEIOJEICCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x73C4AB0", Offset = "0x73C30B0", VA = "0x1873C4AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer FMOLKKFBKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x73B8E20", Offset = "0x73B7420", VA = "0x1873B8E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] OGDHLGKLDMN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x73B02A0", Offset = "0x73AE8A0", VA = "0x1873B02A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] LLNCHGBBMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x73B2E30", Offset = "0x73B1430", VA = "0x1873B2E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator EDMCKKPACCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x73C1E20", Offset = "0x73C0420", VA = "0x1873C1E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK AIJJKIOPBON
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x73C2100", Offset = "0x73C0700", VA = "0x1873C2100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private GGHNALLMHEG DCCANJGEOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x73B9260", Offset = "0x73B7860", VA = "0x1873B9260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private GGHNALLMHEG EGPIHCGPBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x73C3D80", Offset = "0x73C2380", VA = "0x1873C3D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private GGHNALLMHEG BGMJLHLLKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x73C13D0", Offset = "0x73BF9D0", VA = "0x1873C13D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private GGHNALLMHEG CLNJKJJDHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x73B67F0", Offset = "0x73B4DF0", VA = "0x1873B67F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private GGHNALLMHEG NAJOBFNBDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x73B8490", Offset = "0x73B6A90", VA = "0x1873B8490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private GGHNALLMHEG DJNGNNIACGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x73C0E10", Offset = "0x73BF410", VA = "0x1873C0E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private GGHNALLMHEG NGIKCPNNEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x73B01A0", Offset = "0x73AE7A0", VA = "0x1873B01A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private GGHNALLMHEG HLCCJMGODBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x73C4BB0", Offset = "0x73C31B0", VA = "0x1873C4BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public JHIKEGLKIGM HILBEJKMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x73C14D0", Offset = "0x73BFAD0", VA = "0x1873C14D0", Slot = "15")]
		get
		{
			return default(JHIKEGLKIGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AHBNJGDEGOO LMEODEAOMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC7EA00", Offset = "0xC7D000", VA = "0x180C7EA00", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JGOJAJEODNM MJHKIHENJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC7EA70", Offset = "0xC7D070", VA = "0x180C7EA70", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ODFMHACHCFM DIHHKCLABAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xFE9170", Offset = "0xFE7770", VA = "0x180FE9170", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ODFMHACHCFM NKCLBCHHOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1BDC330", Offset = "0x1BDA930", VA = "0x181BDC330", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string BAFPMMNNIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform ODOCHIJJCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73B09A0", Offset = "0x73AEFA0", VA = "0x1873B09A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform MKLGHIGCAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x73C0C90", Offset = "0x73BF290", VA = "0x1873C0C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform FHFJEGFIICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x73BA5B0", Offset = "0x73B8BB0", VA = "0x1873BA5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform JNNAKJFCDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x73B03A0", Offset = "0x73AE9A0", VA = "0x1873B03A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform KAEDNGEAHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x73AD270", Offset = "0x73AB870", VA = "0x1873AD270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool GLMEMLGGACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x73B8DD0", Offset = "0x73B73D0", VA = "0x1873B8DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool LENDKEFCMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x73B8DD0", Offset = "0x73B73D0", VA = "0x1873B8DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Transform JCLAPAFDPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x73BA9B0", Offset = "0x73B8FB0", VA = "0x1873BA9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GameObject HHDLNMHBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x73C17D0", Offset = "0x73BFDD0", VA = "0x1873C17D0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HeadLogicOffsets CACFDAGEDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x73C0D60", Offset = "0x73BF360", VA = "0x1873C0D60", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform PPBOCFGCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xA141B0", Offset = "0xA127B0", VA = "0x180A141B0", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform ELKCHGGECME
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1D07130", Offset = "0x1D05730", VA = "0x181D07130", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform MNLNOALGOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA28D50", Offset = "0xA27350", VA = "0x180A28D50", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform PAMMCNIKAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x19EE5D0", Offset = "0x19ECBD0", VA = "0x1819EE5D0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 PMOGIPJNBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x73BE490", Offset = "0x73BCA90", VA = "0x1873BE490", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float HGHCAACKMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x73C47D0", Offset = "0x73C2DD0", VA = "0x1873C47D0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform IKGIPHGCAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x73C5E00", Offset = "0x73C4400", VA = "0x1873C5E00", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform JPDPILMLMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2042B00", Offset = "0x2041100", VA = "0x182042B00", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform EHCHIDCABOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x204E980", Offset = "0x204CF80", VA = "0x18204E980", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform IBGGABFAJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x19EF190", Offset = "0x19ED790", VA = "0x1819EF190", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool BGNDGDGCKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x73BE520", Offset = "0x73BCB20", VA = "0x1873BE520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PGHLDGDKENE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x73C2290", Offset = "0x73C0890", VA = "0x1873C2290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DBCFNOKMDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x73BD430", Offset = "0x73BBA30", VA = "0x1873BD430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x73BB240", Offset = "0x73B9840", VA = "0x1873BB240")]
	private void IGMNCLLFAGK([In] MHPCHHPGEFC KGJIKMJICFB, [In] AvatarFullBodyConfiguration HIGIOODIHPF, bool JNALNEPEEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x73C0CD0", Offset = "0x73BF2D0", VA = "0x1873C0CD0")]
	private float KAJPGHOMBCG([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x73C41F0", Offset = "0x73C27F0", VA = "0x1873C41F0")]
	private float OJHLLOOCCBO([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73C3480", Offset = "0x73C1A80", VA = "0x1873C3480")]
	private void NNJLAIDNJJD(MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF, bool JNALNEPEEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x73B4340", Offset = "0x73B2940", VA = "0x1873B4340")]
	private void EEHLJONNEFO([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x73C2EF0", Offset = "0x73C14F0", VA = "0x1873C2EF0")]
	private void NMCOIEHDHNK([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x73C6910", Offset = "0x73C4F10", VA = "0x1873C6910")]
	public NHEFKBAOHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x73BE8B0", Offset = "0x73BCEB0", VA = "0x1873BE8B0", Slot = "12")]
	public void JHGLOIAGFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x73BAE80", Offset = "0x73B9480", VA = "0x1873BAE80", Slot = "13")]
	public void IGLKKEDCLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x73C3A60", Offset = "0x73C2060", VA = "0x1873C3A60", Slot = "14")]
	public void OAAMHNDBICL(bool DJDGOFPOMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x73C1600", Offset = "0x73BFC00", VA = "0x1873C1600", Slot = "25")]
	public Transform LAGNAACCCIM(string MHIJJLMKFIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x73C0820", Offset = "0x73BEE20", VA = "0x1873C0820", Slot = "26")]
	public Vector3? JKEKAGMHKCE(string MHIJJLMKFIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x73C5640", Offset = "0x73C3C40", VA = "0x1873C5640", Slot = "7")]
	public void POKEGKDFHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x73B7810", Offset = "0x73B5E10", VA = "0x1873B7810")]
	private void FGBLBKFCALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x73ADF60", Offset = "0x73AC560", VA = "0x1873ADF60")]
	private Vector3 APFCLDONAED([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x73AED10", Offset = "0x73AD310", VA = "0x1873AED10", Slot = "6")]
	public void BELCBLHMALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x73B03E0", Offset = "0x73AE9E0", VA = "0x1873B03E0", Slot = "8")]
	public void BONNHDBOBJI(float OEPALEOOGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x73B67A0", Offset = "0x73B4DA0", VA = "0x1873B67A0")]
	private void EOFBGOAEDGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x73B4530", Offset = "0x73B2B30", VA = "0x1873B4530", Slot = "4")]
	public void EKJJJJLJMLI(string MGIEGPEOHDN, EIBPNDHILPC CFBDHLLOGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x73B09F0", Offset = "0x73AEFF0", VA = "0x1873B09F0", Slot = "5")]
	public void CMDKOMDNGAM(JHIKEGLKIGM HEFCMACDPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x73B9FF0", Offset = "0x73B85F0", VA = "0x1873B9FF0", Slot = "11")]
	public void HLIBKEFJOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x73C4270", Offset = "0x73C2870", VA = "0x1873C4270", Slot = "24")]
	public void OMAFFLCDDMA([Out] Vector3 DKLKCPNCAJM, [Out] Quaternion CIIHGLMDKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x73B4500", Offset = "0x73B2B00", VA = "0x1873B4500")]
	private void EIMLALNGDBD([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x73B08E0", Offset = "0x73AEEE0", VA = "0x1873B08E0", Slot = "27")]
	public void CFGFHGBHJAM(float MNCGHHGLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x73C2310", Offset = "0x73C0910", VA = "0x1873C2310", Slot = "28")]
	public void NDJCNIPOLAP(float CHJELFACPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x73C2EA0", Offset = "0x73C14A0", VA = "0x1873C2EA0", Slot = "44")]
	public void NHGCNFNGFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x73B9210", Offset = "0x73B7810", VA = "0x1873B9210", Slot = "29")]
	public void HHHLAKECIBB(bool KHFPBEFDMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x73B0890", Offset = "0x73AEE90", VA = "0x1873B0890", Slot = "30")]
	public HandLogicOffsets CBLONHJHBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x73C4CB0", Offset = "0x73C32B0", VA = "0x1873C4CB0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets PFPBJPCCBPG()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73C0DE0", Offset = "0x73BF3E0", VA = "0x1873C0DE0")]
	private void KFCCDNBMNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x73C1CA0", Offset = "0x73C02A0", VA = "0x1873C1CA0")]
	private void MFEAIHHGKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x73B0450", Offset = "0x73AEA50", VA = "0x1873B0450")]
	private void CBABBMNEKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73B1560", Offset = "0x73AFB60", VA = "0x1873B1560")]
	private void DFFOHLOOOII(DOJENFHJKGB JGDAMODENLN, bool GAMHFCBCJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x73AF850", Offset = "0x73ADE50", VA = "0x1873AF850")]
	private void BFEOOPKCBGK(DOJENFHJKGB JGDAMODENLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x73C55F0", Offset = "0x73C3BF0", VA = "0x1873C55F0")]
	public Vector3 PMMJMIMEJPF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x73BA2F0", Offset = "0x73B88F0", VA = "0x1873BA2F0")]
	private void IADGGHNFJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x73AEAE0", Offset = "0x73AD0E0", VA = "0x1873AEAE0")]
	private void BDOLLGIJEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x73C4D70", Offset = "0x73C3370", VA = "0x1873C4D70")]
	private void PJOBLAOCEBG(MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x73B8590", Offset = "0x73B6B90", VA = "0x1873B8590")]
	private float GFCPIOOGJMC([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x73C3980", Offset = "0x73C1F80", VA = "0x1873C3980")]
	private int NPJNICGGNIK([In] BBKKLAGHEAC CMAIMKDNFKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x73BCC10", Offset = "0x73BB210", VA = "0x1873BCC10")]
	private void IIHCHGDNAOK(MHPCHHPGEFC KGJIKMJICFB, bool FFJNKEJBIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x73B6D10", Offset = "0x73B5310", VA = "0x1873B6D10")]
	private static void FCILDLMBBPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x73B2F30", Offset = "0x73B1530", VA = "0x1873B2F30")]
	private static void ECEDCLCBIGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x73B82B0", Offset = "0x73B68B0", VA = "0x1873B82B0")]
	private float FOEDIFFHBGB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x73C1C70", Offset = "0x73C0270", VA = "0x1873C1C70")]
	private static int MAJELMNDLGF(NHEFKBAOHJL HJGDMEAJFEI, NHEFKBAOHJL OHAJMMPIMHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x73B7950", Offset = "0x73B5F50", VA = "0x1873B7950", Slot = "40")]
	public MHPCHHPGEFC FLNOLEAADNB()
	{
		return default(MHPCHHPGEFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73C1750", Offset = "0x73BFD50", VA = "0x1873C1750")]
	public void LEHKJHAFKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x73AEB00", Offset = "0x73AD100", VA = "0x1873AEB00")]
	private (bool, bool) BEGILNIFANB()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x73C1F20", Offset = "0x73C0520", VA = "0x1873C1F20")]
	private (float, float) MIOJIDHFGIE([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x73BEDD0", Offset = "0x73BD3D0", VA = "0x1873BEDD0")]
	private void JJODHPCAGGA([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x73C3ED0", Offset = "0x73C24D0", VA = "0x1873C3ED0")]
	private void OICPELBPGKP([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x73B68F0", Offset = "0x73B4EF0", VA = "0x1873B68F0")]
	private void FCBDHCFFBJK([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF, AvatarFootSettings DEJFCJMECLJ, bool PKGOKAKIEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x73BD3B0", Offset = "0x73BB9B0", VA = "0x1873BD3B0")]
	private float IMDGICLPEJK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x73B9460", Offset = "0x73B7A60", VA = "0x1873B9460")]
	private void HLFAHPNAHIC(MHPCHHPGEFC CEGAGHAOIDD, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x73C3E80", Offset = "0x73C2480", VA = "0x1873C3E80")]
	private float OEJIEBNHKLF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x73C0F10", Offset = "0x73BF510", VA = "0x1873C0F10")]
	private void KHNJENJEECH([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x73B8F20", Offset = "0x73B7520", VA = "0x1873B8F20")]
	private void HHGNPFAGNDA([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x73C1870", Offset = "0x73BFE70", VA = "0x1873C1870")]
	private void MAEJFCPIAFP([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x73B1920", Offset = "0x73AFF20", VA = "0x1873B1920")]
	private void DLOMGNMNDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x73BD150", Offset = "0x73BB750", VA = "0x1873BD150")]
	private void IJHOHAPIDGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x73BA150", Offset = "0x73B8750", VA = "0x1873BA150")]
	private void HPLKJBBJMEF([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x73C4820", Offset = "0x73C2E20", VA = "0x1873C4820")]
	private void PAOMIEKPAGA(MNJGAOGMOGO OKBAPKKKGCK, IKSolverVR.Arm PKFMECEFJCK, Transform EGCCDMFGFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x73B0E90", Offset = "0x73AF490", VA = "0x1873B0E90")]
	private void DCAKLAJNNCI(MHPCHHPGEFC CEGAGHAOIDD, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x73C4600", Offset = "0x73C2C00", VA = "0x1873C4600")]
	private void OMAKKDABCOK(FKMNECDKODO HPBEFPPLKAJ, ODFMHACHCFM OKBAPKKKGCK, IKSolverVR.Arm PKFMECEFJCK, float OCKGDAAALOM, float AOKKAOKLBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x73B7CB0", Offset = "0x73B62B0", VA = "0x1873B7CB0")]
	private void FMNILLFDOJA([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x73BA5E0", Offset = "0x73B8BE0", VA = "0x1873BA5E0")]
	protected void IFEEJAMPJMC([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x73C09C0", Offset = "0x73BEFC0", VA = "0x1873C09C0")]
	private void JMALGPIAMGF([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x73C3B30", Offset = "0x73C2130", VA = "0x1873C3B30")]
	protected void ODGHAIBEGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x73C2660", Offset = "0x73C0C60", VA = "0x1873C2660")]
	private void NEDJIMABLLC([In] MHPCHHPGEFC CEGAGHAOIDD, [In] GNOANGAAJCA PJJJEGBHFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x73BD4B0", Offset = "0x73BBAB0", VA = "0x1873BD4B0")]
	private void IODBFJCCJMN(MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x73B7910", Offset = "0x73B5F10", VA = "0x1873B7910")]
	private void FJOHJJMEGEF([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x73B3E20", Offset = "0x73B2420", VA = "0x1873B3E20")]
	private Vector3 EDLJBCNBMGE([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x73B1850", Offset = "0x73AFE50", VA = "0x1873B1850")]
	private void DGLJNPBMCAA([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x73BD660", Offset = "0x73BBC60", VA = "0x1873BD660")]
	private float IOEBHJBGOCO(float DNKIMFGIPDP, [In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x73B8740", Offset = "0x73B6D40", VA = "0x1873B8740")]
	private void GGIBKJPDIFC(float DNKIMFGIPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x73B2740", Offset = "0x73B0D40", VA = "0x1873B2740")]
	private void DPNIHMDDFMO([In] MHPCHHPGEFC CEGAGHAOIDD, GNOANGAAJCA PJJJEGBHFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x73AF9E0", Offset = "0x73ADFE0", VA = "0x1873AF9E0")]
	private float BGKFCMCMENJ([In] MHPCHHPGEFC KGJIKMJICFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x73B1F40", Offset = "0x73B0540", VA = "0x1873B1F40")]
	private void DPKFHPDIMKC(MHPCHHPGEFC CEGAGHAOIDD, GNOANGAAJCA PJJJEGBHFKA, Vector3 OFBLDKPIPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x73AD0C0", Offset = "0x73AB6C0", VA = "0x1873AD0C0")]
	private static void AAKJGHMOGNI(Transform EJNLPEDOMDD, Quaternion MLMNPOCKAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x73ADC60", Offset = "0x73AC260", VA = "0x1873ADC60")]
	private void AMCCJDMHDGJ([In] MHPCHHPGEFC FOGHNNFMDBB, [In] BBKKLAGHEAC CMAIMKDNFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x73AD2B0", Offset = "0x73AB8B0", VA = "0x1873AD2B0")]
	private void AGDOHEEKLEA([In] MHPCHHPGEFC FOGHNNFMDBB, [In] BBKKLAGHEAC CMAIMKDNFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x73B7AC0", Offset = "0x73B60C0", VA = "0x1873B7AC0")]
	private void FMLGLONIHMN(float ELCOEBEMFIC, [In] MHPCHHPGEFC KGJIKMJICFB, float BDLOMHNDGHJ = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x73B7040", Offset = "0x73B5640", VA = "0x1873B7040")]
	private float FDJOLBOHGLP([In] MHPCHHPGEFC KGJIKMJICFB, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x73C2FF0", Offset = "0x73C15F0", VA = "0x1873C2FF0")]
	private void NMEGADELPJL([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x73BDAB0", Offset = "0x73BC0B0", VA = "0x1873BDAB0")]
	private void IOJDDBOOPMP([In] MHPCHHPGEFC KGJIKMJICFB, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x73BAAB0", Offset = "0x73B90B0", VA = "0x1873BAAB0")]
	private void IGIPNMPMEPH([In] MHPCHHPGEFC KGJIKMJICFB, float GHOKFNPAGCL, float HDKJAFIALBA, Vector3 DLOGEKEIILJ, float BDLOMHNDGHJ = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x73AE0E0", Offset = "0x73AC6E0", VA = "0x1873AE0E0")]
	private void BAAIGGJONLC(MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x73BE620", Offset = "0x73BCC20", VA = "0x1873BE620")]
	private void JGJCJLPMAIN(MHPCHHPGEFC CEGAGHAOIDD, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x73B1220", Offset = "0x73AF820", VA = "0x1873B1220")]
	private void DFDENDEOLIA(MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x73B3C60", Offset = "0x73B2260", VA = "0x1873B3C60")]
	public void ECIGHAKBOMH([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x73B1BD0", Offset = "0x73B01D0", VA = "0x1873B1BD0")]
	public void DMHKKDIFOHF([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x73C32E0", Offset = "0x73C18E0", VA = "0x1873C32E0")]
	[CompilerGenerated]
	internal static void NNFPNNJPKDC(Transform MOEBIEOOLFC, IKSolverVR.Arm PKFMECEFJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x73B08F0", Offset = "0x73AEEF0", VA = "0x1873B08F0")]
	[CompilerGenerated]
	internal static void CIMILDPDAOM(Vector3 IDDCHOIDIOJ, Vector3 LANOCBMPDMF, LMOPPLDPKCJ P_2, BCMLIPMBCFC P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x73C38E0", Offset = "0x73C1EE0", VA = "0x1873C38E0")]
	[CompilerGenerated]
	internal static void NNLJHIHOGPO(BALOIBDEDPN ILMKCJMOLHF, BALOIBDEDPN CICHLGNFEJH, Vector3 CPJLAKLCBPF, float IFMHONGNKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x73B6F30", Offset = "0x73B5530", VA = "0x1873B6F30")]
	[CompilerGenerated]
	internal static bool FCJEOLMAFPG(IKSolverVR.Arm PKFMECEFJCK, KKNLHOJPPLA JCFEMBBMLPO, float CMCKLBNNCNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x73B8990", Offset = "0x73B6F90", VA = "0x1873B8990")]
	[CompilerGenerated]
	internal static float HAAHFDGKGLJ(Vector3 GFEBLINPPLA, Vector3 CGLLMCBOFHL, Vector3 MMDCHGKBBEM, MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF, float FDJGEFDKBBO)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class KKIPCHDOBHP : FPBHBNMAAAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<string, IDDNGPPBDAI> CMJEFPEAJNG;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x73CEB30", Offset = "0x73CD130", VA = "0x1873CEB30")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void EODIPCMCMKN(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x73CE730", Offset = "0x73CCD30", VA = "0x1873CE730", Slot = "4")]
	public IDDNGPPBDAI CJIKKKGPHGE(string BKOKACECDGF, AvatarSystemConfiguration DJCGLEJFHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x73CE950", Offset = "0x73CCF50", VA = "0x1873CE950", Slot = "5")]
	public void DIEEIJKHCJE(string BKOKACECDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x73CE5F0", Offset = "0x73CCBF0", VA = "0x1873CE5F0", Slot = "6")]
	public string BJDPFBPCCEM(string GFJGMCEBCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x73CE580", Offset = "0x73CCB80", VA = "0x1873CE580")]
	private string BCNIODCNDCC(string GFJGMCEBCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x73CEBA0", Offset = "0x73CD1A0", VA = "0x1873CEBA0")]
	public KKIPCHDOBHP()
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
		public class JFHFEOMEOBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private Dictionary<string, Transform> NNHLFBICGKJ;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool PMLNJMJFBKO
			{
				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x73CE0A0", Offset = "0x73CC6A0", VA = "0x1873CE0A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x73CE0E0", Offset = "0x73CC6E0", VA = "0x1873CE0E0")]
			public void EMJCEIAPNCI(VRIK AJIEKEPEMCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
			public void EMKBHNHGJID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x73CE210", Offset = "0x73CC810", VA = "0x1873CE210")]
			public void KLOHADBCHCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x73CE260", Offset = "0x73CC860", VA = "0x1873CE260")]
			public JFHFEOMEOBJ()
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
		[AICMCMODPDA(KCNGGJNCENB.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[ALEFAIIJNEI(KCNGGJNCENB.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly JFHFEOMEOBJ GLMHJKIIHIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private OOHCCBAOPED CDALFEKICHH;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x73C7C00", Offset = "0x73C6200", VA = "0x1873C7C00")]
		private void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x73C7BB0", Offset = "0x73C61B0", VA = "0x1873C7BB0")]
		private bool DCJMBNABJBG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x73C7EE0", Offset = "0x73C64E0", VA = "0x1873C7EE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x73C7F50", Offset = "0x73C6550", VA = "0x1873C7F50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x73C7EF0", Offset = "0x73C64F0", VA = "0x1873C7EF0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x73C81C0", Offset = "0x73C67C0", VA = "0x1873C81C0")]
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
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x73CD400", Offset = "0x73CBA00", VA = "0x1873CD400")]
			public void CIDIOEOELJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x73CD4E0", Offset = "0x73CBAE0", VA = "0x1873CD4E0")]
			public (float, float) LAEHDFELPLF(Animator IHHOPFIAFJE, AnimatorStateInfo KFBKEKPJOII)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x73CD620", Offset = "0x73CBC20", VA = "0x1873CD620")]
		public void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x73CD810", Offset = "0x73CBE10", VA = "0x1873CD810")]
		public (float, float) EEJCGMAGNKB(Animator IHHOPFIAFJE)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x73CDA20", Offset = "0x73CC020", VA = "0x1873CDA20")]
		private (float, float) KCMEFNPPFOA(Animator IHHOPFIAFJE, AnimatorStateInfo KFBKEKPJOII)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x73CDC10", Offset = "0x73CC210", VA = "0x1873CDC10")]
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

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x73D1BC0", Offset = "0x73D01C0", VA = "0x1873D1BC0", Slot = "4")]
		public override void OnStateEnter(Animator IHHOPFIAFJE, AnimatorStateInfo KFBKEKPJOII, int FCMNJIBIOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x73D1D30", Offset = "0x73D0330", VA = "0x1873D1D30")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class PCOGNPKKELG<TInput, TOutput> : KMANENIEGGA<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected readonly CCAOPILOOAO AJLMACGMCAP;

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x50DE330", Offset = "0x50DC930", VA = "0x1850DE330")]
	protected PCOGNPKKELG(CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput GFOCOOKFNLL(TInput IOJLNNHDMIE, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x50DE290", Offset = "0x50DC890", VA = "0x1850DE290", Slot = "5")]
	public bool FLMLPENGKEK(TInput IOJLNNHDMIE, [Out] TOutput? BIEIOPPGBOB, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[GAFKBMEFLIK]
public static class OJOCCKNAJOD
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly Regex KCFHGMEOECE;

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x73D1F80", Offset = "0x73D0580", VA = "0x1873D1F80")]
	public static EAOMNNFPCNE CKJKEIMMBAB(FFPOHEDMPPG FMILLEPBLNC, MCCAPFKCCCM CJNNLDGPHAA, Guid? PJNPLPPKBKJ, Color? NOIMBMOFFKN, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x73D22E0", Offset = "0x73D08E0", VA = "0x1873D22E0")]
	public static HAHPCGIIIOL PKJDDPKHFHC(EAOMNNFPCNE GIDGOODJFLJ)
	{
		return default(HAHPCGIIIOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x35F3D90", Offset = "0x35F2390", VA = "0x1835F3D90")]
	internal static TModern? EEKGHGOAJAN<TModern>(string? IOJLNNHDMIE, BMLBHIEMCPF<TModern> BDPNMMOGOJJ, CCAOPILOOAO AJLMACGMCAP, LHLBCIMCCKA FDIHLCILGMO, TModern EFFCDLAOEMC) where TModern : struct, IFCLNAHLMPM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x35F6200", Offset = "0x35F4800", VA = "0x1835F6200")]
	internal static JBMDBFLHGFD OAGCIGPOLJB<TModern>(string? IOJLNNHDMIE, BMLBHIEMCPF<TModern> BDPNMMOGOJJ, CCAOPILOOAO AJLMACGMCAP, LHLBCIMCCKA FDIHLCILGMO, TModern EFFCDLAOEMC) where TModern : struct, IFCLNAHLMPM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x73D2190", Offset = "0x73D0790", VA = "0x1873D2190")]
	internal static List<CKNBNGCMGDD> PAPAHLKECLA(IEnumerable<CMJBKHNOCDN>? JMLIPEPAKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x35F53E0", Offset = "0x35F39E0", VA = "0x1835F53E0")]
	internal static string HMOHALJNPBF<TModern>(TModern IOJLNNHDMIE, BMLBHIEMCPF<TModern> BDPNMMOGOJJ, CCAOPILOOAO AJLMACGMCAP) where TModern : IFCLNAHLMPM
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class FMPMPMBJLAC : NAGJADLJCMA
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KMANENIEGGA<JMICKPPNDJO, PHGEAGLPDDM> NKJLGPHPABL
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> KKDBBPIDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> OKFLELBCDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FNEMIBADCNK GMIAAJDICEM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FKPEHJBGAMD OHNKDNHKPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x73CCE30", Offset = "0x73CB430", VA = "0x1873CCE30")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	[UsedImplicitly]
	internal static void IPHGFHNDJOJ(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x73CCEA0", Offset = "0x73CB4A0", VA = "0x1873CCEA0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal FMPMPMBJLAC([IBJCGEMJMJL("UnitySerialization")] CGBMLLAMNKD BIMDCCLIKDF, [IBJCGEMJMJL(null)] OPIFMDAOECG KAKBMLMFMPN, [IBJCGEMJMJL(null)] CCAOPILOOAO AJLMACGMCAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum LNGOMNEMHAO
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
public class NNFMFOLIJOH : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x73D1DF0", Offset = "0x73D03F0", VA = "0x1873D1DF0")]
	public NNFMFOLIJOH(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x73D1DC0", Offset = "0x73D03C0", VA = "0x1873D1DC0")]
	public NNFMFOLIJOH(string MIALAMIFNLM, Exception DIHKEEPHEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x73D1D50", Offset = "0x73D0350", VA = "0x1873D1D50")]
	public NNFMFOLIJOH(LNGOMNEMHAO FOBKIBNHAIN, string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x73D1D80", Offset = "0x73D0380", VA = "0x1873D1D80")]
	public NNFMFOLIJOH(LNGOMNEMHAO FOBKIBNHAIN, string MIALAMIFNLM, Exception DIHKEEPHEOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class EAEOBHDNMCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly CGBMLLAMNKD BIMDCCLIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly OPIFMDAOECG KAKBMLMFMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly CCAOPILOOAO AJLMACGMCAP;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x73C9C70", Offset = "0x73C8270", VA = "0x1873C9C70")]
	protected EAEOBHDNMCC(CGBMLLAMNKD BIMDCCLIKDF, OPIFMDAOECG KAKBMLMFMPN, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x73CB800", Offset = "0x73C9E00", VA = "0x1873CB800")]
	protected string JMAJCMCPNCI(PHGEAGLPDDM ALBFPGNJIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x73CCC50", Offset = "0x73CB250", VA = "0x1873CCC50")]
	protected string NMAHHNIODCM(PHGEAGLPDDM ALBFPGNJIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x73CB4D0", Offset = "0x73C9AD0", VA = "0x1873CB4D0")]
	private AvatarOutfitSelectionData CKJKEIMMBAB(EAOMNNFPCNE PIDIJCCONEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x73CCB10", Offset = "0x73CB110", VA = "0x1873CCB10")]
	private static AvatarCustomizationSettingsData.AnchorParams JNAEAAGNJAD(KOIFPCMFICK? KOIJGLMEEHK)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KMANENIEGGA<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput GFOCOOKFNLL(TInput IOJLNNHDMIE, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FLMLPENGKEK(TInput IOJLNNHDMIE, [Out] TOutput? BIEIOPPGBOB, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NAGJADLJCMA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KMANENIEGGA<JMICKPPNDJO, PHGEAGLPDDM> NKJLGPHPABL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> OKFLELBCDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FNEMIBADCNK GMIAAJDICEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum LHLBCIMCCKA
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface FKPEHJBGAMD
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJIPACLFKPD IMJDHHAECMF(PHGEAGLPDDM GIDGOODJFLJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FNEMIBADCNK
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJDOIIFPLOL IMJDHHAECMF(PHGEAGLPDDM GIDGOODJFLJ, int CPNKOGECOFG, string? OMOOEGOLALI, string? NHLFNJPNHKL, IKKNJNIMHHO NBNPMENJBOH, List<CKNBNGCMGDD>? NOFLCGFLKMC);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[GAFKBMEFLIK]
internal class IAMKFEPHJFP : PCOGNPKKELG<JMICKPPNDJO, PHGEAGLPDDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly OPIFMDAOECG KAKBMLMFMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly LOPLJAIKDMA CHEPPHBFAEB;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x73CDED0", Offset = "0x73CC4D0", VA = "0x1873CDED0")]
	public IAMKFEPHJFP(CGBMLLAMNKD BIMDCCLIKDF, OPIFMDAOECG KAKBMLMFMPN, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x73CDC20", Offset = "0x73CC220", VA = "0x1873CDC20", Slot = "6")]
	public override PHGEAGLPDDM GFOCOOKFNLL(JMICKPPNDJO IOJLNNHDMIE, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class OFGCKODCOBM : CGBMLLAMNKD
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class PDGPLNEGDGC : JsonConverter<JBMDBFLHGFD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x73D2600", Offset = "0x73D0C00", VA = "0x1873D2600", Slot = "9")]
		public override void WriteJson(JsonWriter BMEAHINCLAG, JBMDBFLHGFD? KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x73D24E0", Offset = "0x73D0AE0", VA = "0x1873D24E0", Slot = "10")]
		public override JBMDBFLHGFD ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, JBMDBFLHGFD? JOJNEODOMKD, bool EBNFLLPKKDF, JsonSerializer HICOCDDBAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x73D26A0", Offset = "0x73D0CA0", VA = "0x1873D26A0")]
		public PDGPLNEGDGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class BELAHFCIDAM : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool PHHCBEPNNBL
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x73C9440", Offset = "0x73C7A40", VA = "0x1873C9440", Slot = "5")]
		public override object ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, object? JOJNEODOMKD, JsonSerializer HICOCDDBAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x73C9060", Offset = "0x73C7660", VA = "0x1873C9060", Slot = "6")]
		public override bool CanConvert(Type FJCDLCFJEBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x73C94A0", Offset = "0x73C7AA0", VA = "0x1873C94A0", Slot = "4")]
		public override void WriteJson(JsonWriter BMEAHINCLAG, object? KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x73C9240", Offset = "0x73C7840", VA = "0x1873C9240")]
		private static bool OMJDHFBBNIE(object KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public BELAHFCIDAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings KPGGOJINIFF;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x73D1E20", Offset = "0x73D0420", VA = "0x1873D1E20")]
	internal OFGCKODCOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x35F2100", Offset = "0x35F0700", VA = "0x1835F2100", Slot = "4")]
	public string MNBGEBIAGNB<T>(T GMFKPONAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x35F2070", Offset = "0x35F0670", VA = "0x1835F2070", Slot = "5")]
	public T BPKHEGKOOKE<T>(string KBGCCIOIGBD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class KBHLIPFGEFO : CGBMLLAMNKD
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3497AC0", Offset = "0x34960C0", VA = "0x183497AC0", Slot = "4")]
	public string MNBGEBIAGNB<T>(T GMFKPONAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3497A40", Offset = "0x3496040", VA = "0x183497A40", Slot = "5")]
	public T BPKHEGKOOKE<T>(string KBGCCIOIGBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public KBHLIPFGEFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GAFKBMEFLIK]
internal class LOPLJAIKDMA : PCOGNPKKELG<OJDOIIFPLOL, IJBHONDDGJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly CGBMLLAMNKD BIMDCCLIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly OPIFMDAOECG KAKBMLMFMPN;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x73D1550", Offset = "0x73CFB50", VA = "0x1873D1550")]
	public LOPLJAIKDMA(CGBMLLAMNKD BIMDCCLIKDF, OPIFMDAOECG KAKBMLMFMPN, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x73CF530", Offset = "0x73CDB30", VA = "0x1873CF530", Slot = "6")]
	public override IJBHONDDGJA GFOCOOKFNLL(OJDOIIFPLOL IOJLNNHDMIE, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x73CF960", Offset = "0x73CDF60", VA = "0x1873CF960")]
	internal void IIBNNLJIAOA(string OMAABFNKJBP, PHGEAGLPDDM ALBFPGNJIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x73D0360", Offset = "0x73CE960", VA = "0x1873D0360")]
	public IEnumerable<EAOMNNFPCNE> JIJGGOEHPHO(string JHKMNGJCLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x73D1120", Offset = "0x73CF720", VA = "0x1873D1120")]
	private IEnumerable<EAOMNNFPCNE> PMGDJGCHNIA(string JHKMNGJCLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x73CF0C0", Offset = "0x73CD6C0", VA = "0x1873CF0C0")]
	internal IEnumerable<EAOMNNFPCNE> EADPLDCFELJ(string JHKMNGJCLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x73D0610", Offset = "0x73CEC10", VA = "0x1873D0610")]
	private EAOMNNFPCNE MAGMAIADEDN(AvatarOutfitSelectionData KKFAGDKNOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x73CFAC0", Offset = "0x73CE0C0", VA = "0x1873CFAC0")]
	private void IIPPEKKJFIB(AvatarCustomizationSettingsData FOMBEKJLCFE, PHGEAGLPDDM ALBFPGNJIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x73D09A0", Offset = "0x73CEFA0", VA = "0x1873D09A0")]
	private EAOMNNFPCNE MAGMAIADEDN(string INAPJMJDOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x73D0E20", Offset = "0x73CF420", VA = "0x1873D0E20")]
	internal static (OBJHNMCDGDL, string, string) OOLCNOCPKNK(string INAPJMJDOJG, CCAOPILOOAO AJLMACGMCAP)
	{
		return default((OBJHNMCDGDL, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x73D0410", Offset = "0x73CEA10", VA = "0x1873D0410")]
	private DALAGIAKGMF? KMGIKEPOKCB(string? JINNLDEOCMO, Vector2 ELJHIGPGIBG, float DHIKJADGNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x73D0CC0", Offset = "0x73CF2C0", VA = "0x1873D0CC0")]
	private static KOIFPCMFICK NGKGNNJEPLE(AvatarCustomizationSettingsData.AnchorParams FCEFAPAPCKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GAFKBMEFLIK]
internal class CANNPJMEKJG : EAEOBHDNMCC, FKPEHJBGAMD
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x73C9C70", Offset = "0x73C8270", VA = "0x1873C9C70")]
	public CANNPJMEKJG(CGBMLLAMNKD BIMDCCLIKDF, OPIFMDAOECG KAKBMLMFMPN, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x73C9580", Offset = "0x73C7B80", VA = "0x1873C9580", Slot = "4")]
	public GJIPACLFKPD IMJDHHAECMF(PHGEAGLPDDM GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x73C9930", Offset = "0x73C7F30", VA = "0x1873C9930")]
	private string LENPFBKKEJM(PHGEAGLPDDM ALBFPGNJIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x73C9A30", Offset = "0x73C8030", VA = "0x1873C9A30")]
	private string PGPDKHFJACN(EAOMNNFPCNE PIDIJCCONEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[GAFKBMEFLIK]
internal class MGMLOEGCJPB : PCOGNPKKELG<OJDOIIFPLOL, IJBHONDDGJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly CGBMLLAMNKD BIMDCCLIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> MEODFFDDHNP;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x73D1AC0", Offset = "0x73D00C0", VA = "0x1873D1AC0")]
	public MGMLOEGCJPB(KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> MEODFFDDHNP, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x73D1690", Offset = "0x73CFC90", VA = "0x1873D1690", Slot = "6")]
	public override IJBHONDDGJA GFOCOOKFNLL(OJDOIIFPLOL IOJLNNHDMIE, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[GAFKBMEFLIK]
internal class LIFADLMPEGP : FNEMIBADCNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly CGBMLLAMNKD BIMDCCLIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly FKPEHJBGAMD OCHIIFJHKFK;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x73CEFD0", Offset = "0x73CD5D0", VA = "0x1873CEFD0")]
	public LIFADLMPEGP(FKPEHJBGAMD OCHIIFJHKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x73CEC30", Offset = "0x73CD230", VA = "0x1873CEC30", Slot = "4")]
	public OJDOIIFPLOL IMJDHHAECMF(PHGEAGLPDDM GIDGOODJFLJ, int CPNKOGECOFG, string? OMOOEGOLALI, string? NHLFNJPNHKL, IKKNJNIMHHO NBNPMENJBOH, List<CKNBNGCMGDD>? NOFLCGFLKMC)
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

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x73C7220", Offset = "0x73C5820", VA = "0x1873C7220")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JOJPIGJLLGI
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x73CE2F0", Offset = "0x73CC8F0", VA = "0x1873CE2F0")]
	public static HAHPCGIIIOL GFOCOOKFNLL(this DAJNIKEGIHH GIDGOODJFLJ)
	{
		return default(HAHPCGIIIOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x73CE400", Offset = "0x73CCA00", VA = "0x1873CE400")]
	public static DAJNIKEGIHH IMJDHHAECMF(this HAHPCGIIIOL APNLALLMOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x73CE520", Offset = "0x73CCB20", VA = "0x1873CE520")]
	public static bool MFNBHIGCLMG(this HAHPCGIIIOL APNLALLMOMO)
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

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x56A4400", Offset = "0x56A2A00", VA = "0x1856A4400")]
			public AnchorParams(Vector2 NHEABMEEBBE, Vector3 GFMEDHAJNFG, Vector3 AAOMFNIJCFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x73C7170", Offset = "0x73C5770", VA = "0x1873C7170")]
			internal KOIFPCMFICK IMJDHHAECMF()
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
		private MLFKPMGCMHF useHelmetHair;

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
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x73C7A50", Offset = "0x73C6050", VA = "0x1873C7A50")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4559780", Offset = "0x4557D80", VA = "0x184559780")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB65960", Offset = "0xB63F60", VA = "0x180B65960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD7A6F0", Offset = "0xD78CF0", VA = "0x180D7A6F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x1036AF0", Offset = "0x10350F0", VA = "0x181036AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x73C7B00", Offset = "0x73C6100", VA = "0x1873C7B00")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x9529C0", Offset = "0x950FC0", VA = "0x1809529C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xA9A800", Offset = "0xA98E00", VA = "0x180A9A800")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xA9A820", Offset = "0xA98E20", VA = "0x180A9A820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x956B20", Offset = "0x955120", VA = "0x180956B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x73C7B40", Offset = "0x73C6140", VA = "0x1873C7B40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xCD2FE0", Offset = "0xCD15E0", VA = "0x180CD2FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xEEC0E0", Offset = "0xEEA6E0", VA = "0x180EEC0E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x1533D30", Offset = "0x1532330", VA = "0x181533D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x958C60", Offset = "0x957260", VA = "0x180958C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x958C70", Offset = "0x957270", VA = "0x180958C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x1FD9650", Offset = "0x1FD7C50", VA = "0x181FD9650")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xCFFD50", Offset = "0xCFE350", VA = "0x180CFFD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x988260", Offset = "0x986860", VA = "0x180988260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x9882C0", Offset = "0x9868C0", VA = "0x1809882C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x95C550", Offset = "0x95AB50", VA = "0x18095C550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x95C5C0", Offset = "0x95ABC0", VA = "0x18095C5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x95C640", Offset = "0x95AC40", VA = "0x18095C640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x95C4E0", Offset = "0x95AAE0", VA = "0x18095C4E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ABD0", VA = "0x18095C5D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x95C500", Offset = "0x95AB00", VA = "0x18095C500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA740D0", Offset = "0xA726D0", VA = "0x180A740D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x1127740", Offset = "0x1125D40", VA = "0x181127740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x95C620", Offset = "0x95AC20", VA = "0x18095C620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x95C600", Offset = "0x95AC00", VA = "0x18095C600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xB8B630", Offset = "0xB89C30", VA = "0x180B8B630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xCEE8F0", Offset = "0xCECEF0", VA = "0x180CEE8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x955950", Offset = "0x953F50", VA = "0x180955950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x955910", Offset = "0x953F10", VA = "0x180955910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xABD020", Offset = "0xABB620", VA = "0x180ABD020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xD04D20", Offset = "0xD03320", VA = "0x180D04D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB07810", Offset = "0xB05E10", VA = "0x180B07810")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB04350", Offset = "0xB02950", VA = "0x180B04350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public MLFKPMGCMHF UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xD7F310", Offset = "0xD7D910", VA = "0x180D7F310")]
			get
			{
				return default(MLFKPMGCMHF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xD7F8B0", Offset = "0xD7DEB0", VA = "0x180D7F8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xD7F610", Offset = "0xD7DC10", VA = "0x180D7F610")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA6AE40", Offset = "0xA69440", VA = "0x180A6AE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x73C7B20", Offset = "0x73C6120", VA = "0x1873C7B20")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x73C7B60", Offset = "0x73C6160", VA = "0x1873C7B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x73C76B0", Offset = "0x73C5CB0", VA = "0x1873C76B0")]
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

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
		public OBJHNMCDGDL BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private JECAOCDPOGB? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x73C7B80", Offset = "0x73C6180", VA = "0x1873C7B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
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
