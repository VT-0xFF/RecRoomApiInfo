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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7329AF0", Offset = "0x7328EF0", VA = "0x187329AF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7329B70", Offset = "0x7328F70", VA = "0x187329B70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
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
	[Cpp2IlInjected.Address(RVA = "0x730EE90", Offset = "0x730E290", VA = "0x18730EE90")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	[UsedImplicitly]
	internal static void IPHGFHNDJOJ(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x730FE10", Offset = "0x730F210", VA = "0x18730FE10")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DKADGEEBINK([IBJCGEMJMJL(null)] LJMKFGLLKIF JAFCDDNFAAN, [IBJCGEMJMJL(null)] NAGJADLJCMA GICAIHKOEHF, [IBJCGEMJMJL(null)] NBLGDMHJAEN PDLAIAJBAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x730E6C0", Offset = "0x730DAC0", VA = "0x18730E6C0", Slot = "5")]
	public PHGEAGLPDDM IDKDDCINLDM(PKOOKMMPLDP HMKELMICGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x730F3B0", Offset = "0x730E7B0", VA = "0x18730F3B0", Slot = "4")]
	public PHGEAGLPDDM NDOEDGOEBDP(PKOOKMMPLDP HMKELMICGGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x730E5B0", Offset = "0x730D9B0", VA = "0x18730E5B0", Slot = "6")]
	public OJDOIIFPLOL GMBAJNONNFE(PHGEAGLPDDM GIDGOODJFLJ, int CPNKOGECOFG, string? OMOOEGOLALI, string? NHLFNJPNHKL, IKKNJNIMHHO NBNPMENJBOH, List<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x730EF90", Offset = "0x730E390", VA = "0x18730EF90", Slot = "7")]
	public bool JMLGBBJJIDO(JMICKPPNDJO NKILLPHANBF, [Out] PHGEAGLPDDM? ALBFPGNJIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x730E4D0", Offset = "0x730D8D0", VA = "0x18730E4D0", Slot = "8")]
	public bool FFBIILKFKIF(OJDOIIFPLOL JJDEENKABFF, [Out] PHGEAGLPDDM? ALBFPGNJIFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x730EF00", Offset = "0x730E300", VA = "0x18730EF00", Slot = "9")]
	public bool JJCHFPLLKIO(OJDOIIFPLOL JJDEENKABFF, [Out] IJBHONDDGJA? NKILLPHANBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3208320", Offset = "0x3207720", VA = "0x183208320")]
	private bool FLMLPENGKEK<TInput, TOutput>(TInput IOJLNNHDMIE, KMANENIEGGA<TInput, TOutput> MADBDOIPJNJ, [Out] TOutput? BIEIOPPGBOB) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x730F020", Offset = "0x730E420", VA = "0x18730F020")]
	[CompilerGenerated]
	private DALAGIAKGMF JPEGNGFLLDM(FaceFeatureType KGLDHIDPHPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x730F1D0", Offset = "0x730E5D0", VA = "0x18730F1D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x730AE70", Offset = "0x730A270", VA = "0x18730AE70")]
	[UsedImplicitly]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	internal static void IPHGFHNDJOJ(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x730AEE0", Offset = "0x730A2E0", VA = "0x18730AEE0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AMCJBEGLDFG([IBJCGEMJMJL(null)] NBLGDMHJAEN PDLAIAJBAKN, [IBJCGEMJMJL(null)] CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x730AD70", Offset = "0x730A170", VA = "0x18730AD70", Slot = "4")]
	public bool IHJNJICMFIC(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x730AC10", Offset = "0x730A010", VA = "0x18730AC10", Slot = "5")]
	public bool IHJNJICMFIC(IJBHONDDGJA NKILLPHANBF, IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7309F30", Offset = "0x7309330", VA = "0x187309F30")]
	private void AJJBDHOAJBC(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x730A9E0", Offset = "0x7309DE0", VA = "0x18730A9E0")]
	private void IDODFMCMKLK(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x730A9B0", Offset = "0x7309DB0", VA = "0x18730A9B0")]
	private void GAFNFNKFINJ(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x730A980", Offset = "0x7309D80", VA = "0x18730A980")]
	private void DENFILEDAMN(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? MEBAFDHEDIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface LJMKFGLLKIF
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHJNJICMFIC(PHGEAGLPDDM ALBFPGNJIFO, IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
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

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x730B2A0", Offset = "0x730A6A0", VA = "0x18730B2A0")]
		public void KCNIDCGNHDF(AnimationPoseSetting OKCHLIEAIJP, float MMDPPNCKJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x730B3D0", Offset = "0x730A7D0", VA = "0x18730B3D0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x730BCE0", Offset = "0x730B0E0", VA = "0x18730BCE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x730BCA0", Offset = "0x730B0A0", VA = "0x18730BCA0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x730B3F0", Offset = "0x730A7F0", VA = "0x18730B3F0")]
		private void CPMNJGPKHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72A1BE0", Offset = "0x72A0FE0", VA = "0x1872A1BE0", Slot = "4")]
		public void SetEnabled(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x730BD10", Offset = "0x730B110", VA = "0x18730BD10")]
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
		[Cpp2IlInjected.Address(RVA = "0x730BD50", Offset = "0x730B150", VA = "0x18730BD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x730BDD0", Offset = "0x730B1D0", VA = "0x18730BDD0")]
		public AnimationPoseSetting DKHIGMLLGBE(IFFGGLLHIDG HPLCKDJMDBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x730BD90", Offset = "0x730B190", VA = "0x18730BD90")]
		public void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x730BE00", Offset = "0x730B200", VA = "0x18730BE00")]
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

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x730C8D0", Offset = "0x730BCD0", VA = "0x18730C8D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x730C890", Offset = "0x730BC90", VA = "0x18730C890")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x730C270", Offset = "0x730B670", VA = "0x18730C270")]
		private void CPMNJGPKHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x72A1BE0", Offset = "0x72A0FE0", VA = "0x1872A1BE0", Slot = "4")]
		public void SetEnabled(bool GCDMKJKGKMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x730C900", Offset = "0x730BD00", VA = "0x18730C900")]
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
		private IDDNGPPBDAI GPHFNFDKEBI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IDDNGPPBDAI KNJFGGHKLMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9B6ED0", Offset = "0x9B62D0", VA = "0x1809B6ED0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform CDCDMNLCAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x730D6F0", Offset = "0x730CAF0", VA = "0x18730D6F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x730C930", Offset = "0x730BD30", VA = "0x18730C930")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x730D5B0", Offset = "0x730C9B0", VA = "0x18730D5B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x730D560", Offset = "0x730C960", VA = "0x18730D560")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x730D4F0", Offset = "0x730C8F0", VA = "0x18730D4F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x730C930", Offset = "0x730BD30", VA = "0x18730C930", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x730CCC0", Offset = "0x730C0C0", VA = "0x18730CCC0", Slot = "6")]
		public IDDNGPPBDAI CreateAvatarSystem(string MGIEGPEOHDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x730D4F0", Offset = "0x730C8F0", VA = "0x18730D4F0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x730C9F0", Offset = "0x730BDF0", VA = "0x18730C9F0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x730D600", Offset = "0x730CA00", VA = "0x18730D600", Slot = "9")]
		public void UpdatePostIKAnimControllers(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
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
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x1C8A630", Offset = "0x1C89A30", VA = "0x181C8A630")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1C8A650", Offset = "0x1C89A50", VA = "0x181C8A650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion DIHBGLNNCIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x11761A0", Offset = "0x11755A0", VA = "0x1811761A0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x11761B0", Offset = "0x11755B0", VA = "0x1811761B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float KKAIBNLLECI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xED9A90", Offset = "0xED8E90", VA = "0x180ED9A90")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x14FA480", Offset = "0x14F9880", VA = "0x1814FA480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool GIJOHNIOEKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x94FC70", Offset = "0x94F070", VA = "0x18094FC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x94FC90", Offset = "0x94F090", VA = "0x18094FC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool EHAAIMFEGIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x94FD20", Offset = "0x94F120", VA = "0x18094FD20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x94FB00", Offset = "0x94EF00", VA = "0x18094FB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool JLEGIIIPLCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x94FD50", Offset = "0x94F150", VA = "0x18094FD50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x94FCD0", Offset = "0x94F0D0", VA = "0x18094FCD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float HFNELBBKDNO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB39E10", Offset = "0xB39210", VA = "0x180B39E10")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB396F0", Offset = "0xB38AF0", VA = "0x180B396F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x730D710", Offset = "0x730CB10", VA = "0x18730D710")]
		public void BEJBJJEMOOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x730E280", Offset = "0x730D680", VA = "0x18730E280")]
		public void MILFLGLIAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x730D720", Offset = "0x730CB20", VA = "0x18730D720")]
		public float CFDCAIBGEFD(Vector3 PAEIDOAFBAO, Quaternion MAKGFJFKICI, [In] AvatarFootSettings DEJFCJMECLJ, float JPKKJDFGKMI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x730D930", Offset = "0x730CD30", VA = "0x18730D930")]
		public void HMBBPAFACDI(Vector3 KAKBBMINOOK, Quaternion KHFHJPMKDAL, Transform JDPJFMKKAEI, float JOEFAEEGMKM, bool NPLKHECDMBE, bool HBIIKMLGENI, float GIIFNCMCPJM, float DNKIMFGIPDP, Transform JGHOOBNHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x730E290", Offset = "0x730D690", VA = "0x18730E290")]
		public void PJMAFCGAJBP(Transform KLKLKLMLBEN, Transform JGHOOBNHEJB, bool MNKBCCBAJFP, bool MCGLNFFIPLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x730E180", Offset = "0x730D580", VA = "0x18730E180")]
		private void MAHKHLPIIFF(Transform JGHOOBNHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x730E030", Offset = "0x730D430", VA = "0x18730E030")]
		public void LNEOCKAGIFE(Transform JGHOOBNHEJB, AvatarFullBodyConfiguration HIGIOODIHPF, Vector3 COJIEECLAJE, float AELGJPDJBBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x730E010", Offset = "0x730D410", VA = "0x18730E010")]
		public void IEJFMIAKMKO(float DNKIMFGIPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x730E4C0", Offset = "0x730D8C0", VA = "0x18730E4C0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x732D3A0", Offset = "0x732C7A0", VA = "0x18732D3A0")]
		public void MDEJCNPLCEK(IKSolverVR.Arm PKFMECEFJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x732D360", Offset = "0x732C760", VA = "0x18732D360")]
		public void LOLAHFJHLDG(IKSolverVR.Arm PKFMECEFJCK, float OCKGDAAALOM, bool MEADLKMCNON, AvatarFullBodyConfiguration HIGIOODIHPF, float GJIDBFHGEOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x732C6A0", Offset = "0x732BAA0", VA = "0x18732C6A0")]
		private void FDDMOOBOMPF(IKSolverVR.Arm PKFMECEFJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x732C840", Offset = "0x732BC40", VA = "0x18732C840")]
		public void HHGNPFAGNDA(IKSolverVR.Arm PKFMECEFJCK, Transform GPJJHFCHNAP, Transform JDPJFMKKAEI, Quaternion EFDNFIIDOGI, Vector3 NBJMCPHECLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x732BD70", Offset = "0x732B170", VA = "0x18732BD70")]
		private (Vector3, Quaternion) BIAIHFHPPLL(MNJGAOGMOGO CMGIOPNOPPF, Quaternion JJHKNKIFKLC, Vector3 NADACFGLLPB)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x732C6E0", Offset = "0x732BAE0", VA = "0x18732C6E0")]
		public void GNFLIDPMJCB(MNJGAOGMOGO CMGIOPNOPPF, IKSolverVR.Arm PKFMECEFJCK, Quaternion JJHKNKIFKLC, Vector3 NADACFGLLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x732CC20", Offset = "0x732C020", VA = "0x18732CC20")]
		public void JMOIFGEIBIG(MNJGAOGMOGO CMGIOPNOPPF, IKSolverVR.Arm PKFMECEFJCK, Quaternion JJHKNKIFKLC, Vector3 NADACFGLLPB, [In] AvatarFullBodyConfiguration HIGIOODIHPF, [In] MHPCHHPGEFC CEGAGHAOIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x732D220", Offset = "0x732C620", VA = "0x18732D220")]
		public void LDHGJKAHBIF(IFFGGLLHIDG DFOIMGIAHFM, AvatarFullBodyConfiguration HIGIOODIHPF, MHPCHHPGEFC CEGAGHAOIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x732C200", Offset = "0x732B600", VA = "0x18732C200")]
		public void BPGHOBLEGMH(IKSolverVR.Arm PKFMECEFJCK, Transform GPJJHFCHNAP, Vector3 OKFHEBLMBFP, float KIDFJGNIONG, Quaternion CIIHGLMDKHO, Vector3 FDDMEDAODFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x732D3D0", Offset = "0x732C7D0", VA = "0x18732D3D0")]
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
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FKDOIPNGGAF MLCENMOLCJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration LJNPOLOCLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x731B5A0", Offset = "0x731A9A0", VA = "0x18731B5A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PKOOKMMPLDP MFJBHKOKOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x731C070", Offset = "0x731B470", VA = "0x18731C070", Slot = "23")]
		get
		{
			return default(PKOOKMMPLDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration IBEKKANLGFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7324F30", Offset = "0x7324330", VA = "0x187324F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform BLKLODKKOAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7310A30", Offset = "0x730FE30", VA = "0x187310A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform AJEIOJEICCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x73277E0", Offset = "0x7326BE0", VA = "0x1873277E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer FMOLKKFBKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x731BB30", Offset = "0x731AF30", VA = "0x18731BB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] OGDHLGKLDMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7313070", Offset = "0x7312470", VA = "0x187313070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] LLNCHGBBMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7315C00", Offset = "0x7315000", VA = "0x187315C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator EDMCKKPACCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7324B50", Offset = "0x7323F50", VA = "0x187324B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK AIJJKIOPBON
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7324E30", Offset = "0x7324230", VA = "0x187324E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private GGHNALLMHEG DCCANJGEOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x731BF70", Offset = "0x731B370", VA = "0x18731BF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private GGHNALLMHEG EGPIHCGPBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7326AB0", Offset = "0x7325EB0", VA = "0x187326AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private GGHNALLMHEG BGMJLHLLKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7324100", Offset = "0x7323500", VA = "0x187324100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private GGHNALLMHEG CLNJKJJDHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7319500", Offset = "0x7318900", VA = "0x187319500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private GGHNALLMHEG NAJOBFNBDDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x731B1A0", Offset = "0x731A5A0", VA = "0x18731B1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private GGHNALLMHEG DJNGNNIACGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7323B40", Offset = "0x7322F40", VA = "0x187323B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private GGHNALLMHEG NGIKCPNNEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7312F70", Offset = "0x7312370", VA = "0x187312F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private GGHNALLMHEG HLCCJMGODBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x73278E0", Offset = "0x7326CE0", VA = "0x1873278E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public JHIKEGLKIGM HILBEJKMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7324200", Offset = "0x7323600", VA = "0x187324200", Slot = "15")]
		get
		{
			return default(JHIKEGLKIGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AHBNJGDEGOO LMEODEAOMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC485D0", Offset = "0xC479D0", VA = "0x180C485D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JGOJAJEODNM MJHKIHENJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC48640", Offset = "0xC47A40", VA = "0x180C48640", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ODFMHACHCFM DIHHKCLABAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1BBE6A0", Offset = "0x1BBDAA0", VA = "0x181BBE6A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ODFMHACHCFM NKCLBCHHOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1BBE690", Offset = "0x1BBDA90", VA = "0x181BBE690", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string BAFPMMNNIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform ODOCHIJJCLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7313770", Offset = "0x7312B70", VA = "0x187313770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform MKLGHIGCAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x73239C0", Offset = "0x7322DC0", VA = "0x1873239C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform FHFJEGFIICJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x731D2C0", Offset = "0x731C6C0", VA = "0x18731D2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform JNNAKJFCDBN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7313170", Offset = "0x7312570", VA = "0x187313170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform KAEDNGEAHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7310140", Offset = "0x730F540", VA = "0x187310140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool GLMEMLGGACG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x731BAE0", Offset = "0x731AEE0", VA = "0x18731BAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool LENDKEFCMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x731BAE0", Offset = "0x731AEE0", VA = "0x18731BAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Transform JCLAPAFDPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x731D6C0", Offset = "0x731CAC0", VA = "0x18731D6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GameObject HHDLNMHBJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7324500", Offset = "0x7323900", VA = "0x187324500", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HeadLogicOffsets CACFDAGEDMM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7323A90", Offset = "0x7322E90", VA = "0x187323A90", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform PPBOCFGCPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C690", Offset = "0xA0BA90", VA = "0x180A0C690", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform ELKCHGGECME
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CE5D60", Offset = "0x1CE5160", VA = "0x181CE5D60", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform MNLNOALGOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA21400", Offset = "0xA20800", VA = "0x180A21400", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform PAMMCNIKAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x19D3A20", Offset = "0x19D2E20", VA = "0x1819D3A20", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 PMOGIPJNBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x73211A0", Offset = "0x73205A0", VA = "0x1873211A0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float HGHCAACKMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7327500", Offset = "0x7326900", VA = "0x187327500", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform IKGIPHGCAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7328B30", Offset = "0x7327F30", VA = "0x187328B30", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform JPDPILMLMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2013B30", Offset = "0x2012F30", VA = "0x182013B30", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform EHCHIDCABOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x201F9B0", Offset = "0x201EDB0", VA = "0x18201F9B0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform IBGGABFAJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19D45D0", Offset = "0x19D39D0", VA = "0x1819D45D0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool BGNDGDGCKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7321230", Offset = "0x7320630", VA = "0x187321230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool PGHLDGDKENE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7324FC0", Offset = "0x73243C0", VA = "0x187324FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool DBCFNOKMDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7320140", Offset = "0x731F540", VA = "0x187320140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x731DF50", Offset = "0x731D350", VA = "0x18731DF50")]
	private void IGMNCLLFAGK([In] MHPCHHPGEFC KGJIKMJICFB, [In] AvatarFullBodyConfiguration HIGIOODIHPF, bool JNALNEPEEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7323A00", Offset = "0x7322E00", VA = "0x187323A00")]
	private float KAJPGHOMBCG([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7326F20", Offset = "0x7326320", VA = "0x187326F20")]
	private float OJHLLOOCCBO([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x73261B0", Offset = "0x73255B0", VA = "0x1873261B0")]
	private void NNJLAIDNJJD(MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF, bool JNALNEPEEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7317110", Offset = "0x7316510", VA = "0x187317110")]
	private void EEHLJONNEFO([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7325C20", Offset = "0x7325020", VA = "0x187325C20")]
	private void NMCOIEHDHNK([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7329640", Offset = "0x7328A40", VA = "0x187329640")]
	public NHEFKBAOHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x73215C0", Offset = "0x73209C0", VA = "0x1873215C0", Slot = "12")]
	public void JHGLOIAGFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x731DB90", Offset = "0x731CF90", VA = "0x18731DB90", Slot = "13")]
	public void IGLKKEDCLBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7326790", Offset = "0x7325B90", VA = "0x187326790", Slot = "14")]
	public void OAAMHNDBICL(bool DJDGOFPOMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7324330", Offset = "0x7323730", VA = "0x187324330", Slot = "25")]
	public Transform LAGNAACCCIM(string MHIJJLMKFIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7323550", Offset = "0x7322950", VA = "0x187323550", Slot = "26")]
	public Vector3? JKEKAGMHKCE(string MHIJJLMKFIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7328370", Offset = "0x7327770", VA = "0x187328370", Slot = "7")]
	public void POKEGKDFHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x731A520", Offset = "0x7319920", VA = "0x18731A520")]
	private void FGBLBKFCALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7310E30", Offset = "0x7310230", VA = "0x187310E30")]
	private Vector3 APFCLDONAED([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7311BE0", Offset = "0x7310FE0", VA = "0x187311BE0", Slot = "6")]
	public void BELCBLHMALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x73131B0", Offset = "0x73125B0", VA = "0x1873131B0", Slot = "8")]
	public void BONNHDBOBJI(float OEPALEOOGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x73194B0", Offset = "0x73188B0", VA = "0x1873194B0")]
	private void EOFBGOAEDGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7317300", Offset = "0x7316700", VA = "0x187317300", Slot = "4")]
	public void EKJJJJLJMLI(string MGIEGPEOHDN, EIBPNDHILPC CFBDHLLOGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x73137C0", Offset = "0x7312BC0", VA = "0x1873137C0", Slot = "5")]
	public void CMDKOMDNGAM(JHIKEGLKIGM HEFCMACDPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x731CD00", Offset = "0x731C100", VA = "0x18731CD00", Slot = "11")]
	public void HLIBKEFJOMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7326FA0", Offset = "0x73263A0", VA = "0x187326FA0", Slot = "24")]
	public void OMAFFLCDDMA([Out] Vector3 DKLKCPNCAJM, [Out] Quaternion CIIHGLMDKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x73172D0", Offset = "0x73166D0", VA = "0x1873172D0")]
	private void EIMLALNGDBD([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x73136B0", Offset = "0x7312AB0", VA = "0x1873136B0", Slot = "27")]
	public void CFGFHGBHJAM(float MNCGHHGLEND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7325040", Offset = "0x7324440", VA = "0x187325040", Slot = "28")]
	public void NDJCNIPOLAP(float CHJELFACPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7325BD0", Offset = "0x7324FD0", VA = "0x187325BD0", Slot = "44")]
	public void NHGCNFNGFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x731BF20", Offset = "0x731B320", VA = "0x18731BF20", Slot = "29")]
	public void HHHLAKECIBB(bool KHFPBEFDMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7313660", Offset = "0x7312A60", VA = "0x187313660", Slot = "30")]
	public HandLogicOffsets CBLONHJHBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x73279E0", Offset = "0x7326DE0", VA = "0x1873279E0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets PFPBJPCCBPG()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7323B10", Offset = "0x7322F10", VA = "0x187323B10")]
	private void KFCCDNBMNJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x73249D0", Offset = "0x7323DD0", VA = "0x1873249D0")]
	private void MFEAIHHGKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7313220", Offset = "0x7312620", VA = "0x187313220")]
	private void CBABBMNEKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7314330", Offset = "0x7313730", VA = "0x187314330")]
	private void DFFOHLOOOII(DOJENFHJKGB JGDAMODENLN, bool GAMHFCBCJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7312620", Offset = "0x7311A20", VA = "0x187312620")]
	private void BFEOOPKCBGK(DOJENFHJKGB JGDAMODENLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7328320", Offset = "0x7327720", VA = "0x187328320")]
	public Vector3 PMMJMIMEJPF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x731D000", Offset = "0x731C400", VA = "0x18731D000")]
	private void IADGGHNFJBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x73119B0", Offset = "0x7310DB0", VA = "0x1873119B0")]
	private void BDOLLGIJEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7327AA0", Offset = "0x7326EA0", VA = "0x187327AA0")]
	private void PJOBLAOCEBG(MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x731B2A0", Offset = "0x731A6A0", VA = "0x18731B2A0")]
	private float GFCPIOOGJMC([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x73266B0", Offset = "0x7325AB0", VA = "0x1873266B0")]
	private int NPJNICGGNIK([In] BBKKLAGHEAC CMAIMKDNFKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x731F920", Offset = "0x731ED20", VA = "0x18731F920")]
	private void IIHCHGDNAOK(MHPCHHPGEFC KGJIKMJICFB, bool FFJNKEJBIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7319A20", Offset = "0x7318E20", VA = "0x187319A20")]
	private static void FCILDLMBBPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7315D00", Offset = "0x7315100", VA = "0x187315D00")]
	private static void ECEDCLCBIGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x731AFC0", Offset = "0x731A3C0", VA = "0x18731AFC0")]
	private float FOEDIFFHBGB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x73249A0", Offset = "0x7323DA0", VA = "0x1873249A0")]
	private static int MAJELMNDLGF(NHEFKBAOHJL HJGDMEAJFEI, NHEFKBAOHJL OHAJMMPIMHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x731A660", Offset = "0x7319A60", VA = "0x18731A660", Slot = "40")]
	public MHPCHHPGEFC FLNOLEAADNB()
	{
		return default(MHPCHHPGEFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7324480", Offset = "0x7323880", VA = "0x187324480")]
	public void LEHKJHAFKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x73119D0", Offset = "0x7310DD0", VA = "0x1873119D0")]
	private (bool, bool) BEGILNIFANB()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7324C50", Offset = "0x7324050", VA = "0x187324C50")]
	private (float, float) MIOJIDHFGIE([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7321AE0", Offset = "0x7320EE0", VA = "0x187321AE0")]
	private void JJODHPCAGGA([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7326C00", Offset = "0x7326000", VA = "0x187326C00")]
	private void OICPELBPGKP([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7319600", Offset = "0x7318A00", VA = "0x187319600")]
	private void FCBDHCFFBJK([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF, AvatarFootSettings DEJFCJMECLJ, bool PKGOKAKIEBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x73200C0", Offset = "0x731F4C0", VA = "0x1873200C0")]
	private float IMDGICLPEJK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x731C170", Offset = "0x731B570", VA = "0x18731C170")]
	private void HLFAHPNAHIC(MHPCHHPGEFC CEGAGHAOIDD, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7326BB0", Offset = "0x7325FB0", VA = "0x187326BB0")]
	private float OEJIEBNHKLF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7323C40", Offset = "0x7323040", VA = "0x187323C40")]
	private void KHNJENJEECH([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x731BC30", Offset = "0x731B030", VA = "0x18731BC30")]
	private void HHGNPFAGNDA([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x73245A0", Offset = "0x73239A0", VA = "0x1873245A0")]
	private void MAEJFCPIAFP([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x73146F0", Offset = "0x7313AF0", VA = "0x1873146F0")]
	private void DLOMGNMNDHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x731FE60", Offset = "0x731F260", VA = "0x18731FE60")]
	private void IJHOHAPIDGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x731CE60", Offset = "0x731C260", VA = "0x18731CE60")]
	private void HPLKJBBJMEF([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7327550", Offset = "0x7326950", VA = "0x187327550")]
	private void PAOMIEKPAGA(MNJGAOGMOGO OKBAPKKKGCK, IKSolverVR.Arm PKFMECEFJCK, Transform EGCCDMFGFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7313C60", Offset = "0x7313060", VA = "0x187313C60")]
	private void DCAKLAJNNCI(MHPCHHPGEFC CEGAGHAOIDD, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7327330", Offset = "0x7326730", VA = "0x187327330")]
	private void OMAKKDABCOK(FKMNECDKODO HPBEFPPLKAJ, ODFMHACHCFM OKBAPKKKGCK, IKSolverVR.Arm PKFMECEFJCK, float OCKGDAAALOM, float AOKKAOKLBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x731A9C0", Offset = "0x7319DC0", VA = "0x18731A9C0")]
	private void FMNILLFDOJA([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x731D2F0", Offset = "0x731C6F0", VA = "0x18731D2F0")]
	protected void IFEEJAMPJMC([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x73236F0", Offset = "0x7322AF0", VA = "0x1873236F0")]
	private void JMALGPIAMGF([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7326860", Offset = "0x7325C60", VA = "0x187326860")]
	protected void ODGHAIBEGHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7325390", Offset = "0x7324790", VA = "0x187325390")]
	private void NEDJIMABLLC([In] MHPCHHPGEFC CEGAGHAOIDD, [In] GNOANGAAJCA PJJJEGBHFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x73201C0", Offset = "0x731F5C0", VA = "0x1873201C0")]
	private void IODBFJCCJMN(MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x731A620", Offset = "0x7319A20", VA = "0x18731A620")]
	private void FJOHJJMEGEF([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7316BF0", Offset = "0x7315FF0", VA = "0x187316BF0")]
	private Vector3 EDLJBCNBMGE([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7314620", Offset = "0x7313A20", VA = "0x187314620")]
	private void DGLJNPBMCAA([In] MHPCHHPGEFC CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7320370", Offset = "0x731F770", VA = "0x187320370")]
	private float IOEBHJBGOCO(float DNKIMFGIPDP, [In] MHPCHHPGEFC CEGAGHAOIDD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x731B450", Offset = "0x731A850", VA = "0x18731B450")]
	private void GGIBKJPDIFC(float DNKIMFGIPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7315510", Offset = "0x7314910", VA = "0x187315510")]
	private void DPNIHMDDFMO([In] MHPCHHPGEFC CEGAGHAOIDD, GNOANGAAJCA PJJJEGBHFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x73127B0", Offset = "0x7311BB0", VA = "0x1873127B0")]
	private float BGKFCMCMENJ([In] MHPCHHPGEFC KGJIKMJICFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7314D10", Offset = "0x7314110", VA = "0x187314D10")]
	private void DPKFHPDIMKC(MHPCHHPGEFC CEGAGHAOIDD, GNOANGAAJCA PJJJEGBHFKA, Vector3 OFBLDKPIPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x730FF90", Offset = "0x730F390", VA = "0x18730FF90")]
	private static void AAKJGHMOGNI(Transform EJNLPEDOMDD, Quaternion MLMNPOCKAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7310B30", Offset = "0x730FF30", VA = "0x187310B30")]
	private void AMCCJDMHDGJ([In] MHPCHHPGEFC FOGHNNFMDBB, [In] BBKKLAGHEAC CMAIMKDNFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7310180", Offset = "0x730F580", VA = "0x187310180")]
	private void AGDOHEEKLEA([In] MHPCHHPGEFC FOGHNNFMDBB, [In] BBKKLAGHEAC CMAIMKDNFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x731A7D0", Offset = "0x7319BD0", VA = "0x18731A7D0")]
	private void FMLGLONIHMN(float ELCOEBEMFIC, [In] MHPCHHPGEFC KGJIKMJICFB, float BDLOMHNDGHJ = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7319D50", Offset = "0x7319150", VA = "0x187319D50")]
	private float FDJOLBOHGLP([In] MHPCHHPGEFC KGJIKMJICFB, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7325D20", Offset = "0x7325120", VA = "0x187325D20")]
	private void NMEGADELPJL([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x73207C0", Offset = "0x731FBC0", VA = "0x1873207C0")]
	private void IOJDDBOOPMP([In] MHPCHHPGEFC KGJIKMJICFB, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x731D7C0", Offset = "0x731CBC0", VA = "0x18731D7C0")]
	private void IGIPNMPMEPH([In] MHPCHHPGEFC KGJIKMJICFB, float GHOKFNPAGCL, float HDKJAFIALBA, Vector3 DLOGEKEIILJ, float BDLOMHNDGHJ = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7310FB0", Offset = "0x73103B0", VA = "0x187310FB0")]
	private void BAAIGGJONLC(MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7321330", Offset = "0x7320730", VA = "0x187321330")]
	private void JGJCJLPMAIN(MHPCHHPGEFC CEGAGHAOIDD, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7313FF0", Offset = "0x73133F0", VA = "0x187313FF0")]
	private void DFDENDEOLIA(MHPCHHPGEFC KGJIKMJICFB, AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7316A30", Offset = "0x7315E30", VA = "0x187316A30")]
	public void ECIGHAKBOMH([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x73149A0", Offset = "0x7313DA0", VA = "0x1873149A0")]
	public void DMHKKDIFOHF([In] MHPCHHPGEFC CEGAGHAOIDD, [In] AvatarFullBodyConfiguration HIGIOODIHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7326010", Offset = "0x7325410", VA = "0x187326010")]
	[CompilerGenerated]
	internal static void NNFPNNJPKDC(Transform MOEBIEOOLFC, IKSolverVR.Arm PKFMECEFJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x73136C0", Offset = "0x7312AC0", VA = "0x1873136C0")]
	[CompilerGenerated]
	internal static void CIMILDPDAOM(Vector3 IDDCHOIDIOJ, Vector3 LANOCBMPDMF, LMOPPLDPKCJ P_2, BCMLIPMBCFC P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7326610", Offset = "0x7325A10", VA = "0x187326610")]
	[CompilerGenerated]
	internal static void NNLJHIHOGPO(BALOIBDEDPN ILMKCJMOLHF, BALOIBDEDPN CICHLGNFEJH, Vector3 CPJLAKLCBPF, float IFMHONGNKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7319C40", Offset = "0x7319040", VA = "0x187319C40")]
	[CompilerGenerated]
	internal static bool FCJEOLMAFPG(IKSolverVR.Arm PKFMECEFJCK, KKNLHOJPPLA JCFEMBBMLPO, float CMCKLBNNCNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x731B6A0", Offset = "0x731AAA0", VA = "0x18731B6A0")]
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

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7330AB0", Offset = "0x732FEB0", VA = "0x187330AB0")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void EODIPCMCMKN(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x73306B0", Offset = "0x732FAB0", VA = "0x1873306B0", Slot = "4")]
	public IDDNGPPBDAI CJIKKKGPHGE(string BKOKACECDGF, AvatarSystemConfiguration DJCGLEJFHCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x73308D0", Offset = "0x732FCD0", VA = "0x1873308D0", Slot = "5")]
	public void DIEEIJKHCJE(string BKOKACECDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7330570", Offset = "0x732F970", VA = "0x187330570", Slot = "6")]
	public string BJDPFBPCCEM(string GFJGMCEBCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x7330500", Offset = "0x732F900", VA = "0x187330500")]
	private string BCNIODCNDCC(string GFJGMCEBCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x7330B20", Offset = "0x732FF20", VA = "0x187330B20")]
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
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x7330020", Offset = "0x732F420", VA = "0x187330020")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7330060", Offset = "0x732F460", VA = "0x187330060")]
			public void EMJCEIAPNCI(VRIK AJIEKEPEMCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
			public void EMKBHNHGJID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x7330190", Offset = "0x732F590", VA = "0x187330190")]
			public void KLOHADBCHCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x73301E0", Offset = "0x732F5E0", VA = "0x1873301E0")]
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

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x732A940", Offset = "0x7329D40", VA = "0x18732A940")]
		private void HPHCPPKCEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x732A8F0", Offset = "0x7329CF0", VA = "0x18732A8F0")]
		private bool DCJMBNABJBG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x732AC20", Offset = "0x732A020", VA = "0x18732AC20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x732AC90", Offset = "0x732A090", VA = "0x18732AC90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x732AC30", Offset = "0x732A030", VA = "0x18732AC30")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x732AF00", Offset = "0x732A300", VA = "0x18732AF00")]
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
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x732F380", Offset = "0x732E780", VA = "0x18732F380")]
			public void CIDIOEOELJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x732F460", Offset = "0x732E860", VA = "0x18732F460")]
			public (float, float) LAEHDFELPLF(Animator IHHOPFIAFJE, AnimatorStateInfo KFBKEKPJOII)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x732F5A0", Offset = "0x732E9A0", VA = "0x18732F5A0")]
		public void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x732F790", Offset = "0x732EB90", VA = "0x18732F790")]
		public (float, float) EEJCGMAGNKB(Animator IHHOPFIAFJE)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x732F9A0", Offset = "0x732EDA0", VA = "0x18732F9A0")]
		private (float, float) KCMEFNPPFOA(Animator IHHOPFIAFJE, AnimatorStateInfo KFBKEKPJOII)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x732FB90", Offset = "0x732EF90", VA = "0x18732FB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7333B40", Offset = "0x7332F40", VA = "0x187333B40", Slot = "4")]
		public override void OnStateEnter(Animator IHHOPFIAFJE, AnimatorStateInfo KFBKEKPJOII, int FCMNJIBIOKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7333CB0", Offset = "0x73330B0", VA = "0x187333CB0")]
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

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x507FCF0", Offset = "0x507F0F0", VA = "0x18507FCF0")]
	protected PCOGNPKKELG(CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput GFOCOOKFNLL(TInput IOJLNNHDMIE, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x507FC50", Offset = "0x507F050", VA = "0x18507FC50", Slot = "5")]
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

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7333F00", Offset = "0x7333300", VA = "0x187333F00")]
	public static EAOMNNFPCNE CKJKEIMMBAB(FFPOHEDMPPG FMILLEPBLNC, MCCAPFKCCCM CJNNLDGPHAA, Guid? PJNPLPPKBKJ, Color? NOIMBMOFFKN, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7334260", Offset = "0x7333660", VA = "0x187334260")]
	public static HAHPCGIIIOL PKJDDPKHFHC(EAOMNNFPCNE GIDGOODJFLJ)
	{
		return default(HAHPCGIIIOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x35AFA10", Offset = "0x35AEE10", VA = "0x1835AFA10")]
	internal static TModern? EEKGHGOAJAN<TModern>(string? IOJLNNHDMIE, BMLBHIEMCPF<TModern> BDPNMMOGOJJ, CCAOPILOOAO AJLMACGMCAP, LHLBCIMCCKA FDIHLCILGMO, TModern EFFCDLAOEMC) where TModern : struct, IFCLNAHLMPM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x35B1E80", Offset = "0x35B1280", VA = "0x1835B1E80")]
	internal static JBMDBFLHGFD OAGCIGPOLJB<TModern>(string? IOJLNNHDMIE, BMLBHIEMCPF<TModern> BDPNMMOGOJJ, CCAOPILOOAO AJLMACGMCAP, LHLBCIMCCKA FDIHLCILGMO, TModern EFFCDLAOEMC) where TModern : struct, IFCLNAHLMPM
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7334110", Offset = "0x7333510", VA = "0x187334110")]
	internal static List<CKNBNGCMGDD> PAPAHLKECLA(IEnumerable<CMJBKHNOCDN>? JMLIPEPAKGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x35B1060", Offset = "0x35B0460", VA = "0x1835B1060")]
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
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> KKDBBPIDPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> OKFLELBCDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public FNEMIBADCNK GMIAAJDICEM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public FKPEHJBGAMD OHNKDNHKPOC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x732EDB0", Offset = "0x732E1B0", VA = "0x18732EDB0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	[UsedImplicitly]
	internal static void IPHGFHNDJOJ(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x732EE20", Offset = "0x732E220", VA = "0x18732EE20")]
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
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7333D70", Offset = "0x7333170", VA = "0x187333D70")]
	public NNFMFOLIJOH(string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7333D40", Offset = "0x7333140", VA = "0x187333D40")]
	public NNFMFOLIJOH(string MIALAMIFNLM, Exception DIHKEEPHEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7333CD0", Offset = "0x73330D0", VA = "0x187333CD0")]
	public NNFMFOLIJOH(LNGOMNEMHAO FOBKIBNHAIN, string MIALAMIFNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x7333D00", Offset = "0x7333100", VA = "0x187333D00")]
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

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x732BBF0", Offset = "0x732AFF0", VA = "0x18732BBF0")]
	protected EAEOBHDNMCC(CGBMLLAMNKD BIMDCCLIKDF, OPIFMDAOECG KAKBMLMFMPN, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x732D780", Offset = "0x732CB80", VA = "0x18732D780")]
	protected string JMAJCMCPNCI(PHGEAGLPDDM ALBFPGNJIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x732EBD0", Offset = "0x732DFD0", VA = "0x18732EBD0")]
	protected string NMAHHNIODCM(PHGEAGLPDDM ALBFPGNJIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x732D450", Offset = "0x732C850", VA = "0x18732D450")]
	private AvatarOutfitSelectionData CKJKEIMMBAB(EAOMNNFPCNE PIDIJCCONEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x732EA90", Offset = "0x732DE90", VA = "0x18732EA90")]
	private static AvatarCustomizationSettingsData.AnchorParams JNAEAAGNJAD(KOIFPCMFICK? KOIJGLMEEHK)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KMANENIEGGA<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput GFOCOOKFNLL(TInput IOJLNNHDMIE, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FLMLPENGKEK(TInput IOJLNNHDMIE, [Out] TOutput? BIEIOPPGBOB, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface NAGJADLJCMA
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	KMANENIEGGA<JMICKPPNDJO, PHGEAGLPDDM> NKJLGPHPABL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> OKFLELBCDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FNEMIBADCNK GMIAAJDICEM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
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
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJIPACLFKPD IMJDHHAECMF(PHGEAGLPDDM GIDGOODJFLJ);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface FNEMIBADCNK
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
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

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x732FE50", Offset = "0x732F250", VA = "0x18732FE50")]
	public IAMKFEPHJFP(CGBMLLAMNKD BIMDCCLIKDF, OPIFMDAOECG KAKBMLMFMPN, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x732FBA0", Offset = "0x732EFA0", VA = "0x18732FBA0", Slot = "6")]
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
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7334580", Offset = "0x7333980", VA = "0x187334580", Slot = "9")]
		public override void WriteJson(JsonWriter BMEAHINCLAG, JBMDBFLHGFD? KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7334460", Offset = "0x7333860", VA = "0x187334460", Slot = "10")]
		public override JBMDBFLHGFD ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, JBMDBFLHGFD? JOJNEODOMKD, bool EBNFLLPKKDF, JsonSerializer HICOCDDBAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7334620", Offset = "0x7333A20", VA = "0x187334620")]
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
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x732B3C0", Offset = "0x732A7C0", VA = "0x18732B3C0", Slot = "5")]
		public override object ReadJson(JsonReader AJLILPPHPPH, Type FJCDLCFJEBC, object? JOJNEODOMKD, JsonSerializer HICOCDDBAMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x732AFE0", Offset = "0x732A3E0", VA = "0x18732AFE0", Slot = "6")]
		public override bool CanConvert(Type FJCDLCFJEBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x732B420", Offset = "0x732A820", VA = "0x18732B420", Slot = "4")]
		public override void WriteJson(JsonWriter BMEAHINCLAG, object? KBGCCIOIGBD, JsonSerializer HICOCDDBAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x732B1C0", Offset = "0x732A5C0", VA = "0x18732B1C0")]
		private static bool OMJDHFBBNIE(object KBGCCIOIGBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public BELAHFCIDAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings KPGGOJINIFF;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x7333DA0", Offset = "0x73331A0", VA = "0x187333DA0")]
	internal OFGCKODCOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x35ADC80", Offset = "0x35AD080", VA = "0x1835ADC80", Slot = "4")]
	public string MNBGEBIAGNB<T>(T GMFKPONAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x35ADBF0", Offset = "0x35ACFF0", VA = "0x1835ADBF0", Slot = "5")]
	public T BPKHEGKOOKE<T>(string KBGCCIOIGBD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class KBHLIPFGEFO : CGBMLLAMNKD
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x344D5A0", Offset = "0x344C9A0", VA = "0x18344D5A0", Slot = "4")]
	public string MNBGEBIAGNB<T>(T GMFKPONAANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x344D520", Offset = "0x344C920", VA = "0x18344D520", Slot = "5")]
	public T BPKHEGKOOKE<T>(string KBGCCIOIGBD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x73334D0", Offset = "0x73328D0", VA = "0x1873334D0")]
	public LOPLJAIKDMA(CGBMLLAMNKD BIMDCCLIKDF, OPIFMDAOECG KAKBMLMFMPN, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x73314B0", Offset = "0x73308B0", VA = "0x1873314B0", Slot = "6")]
	public override IJBHONDDGJA GFOCOOKFNLL(OJDOIIFPLOL IOJLNNHDMIE, [Out] IReadOnlyList<CKNBNGCMGDD>? NOFLCGFLKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x73318E0", Offset = "0x7330CE0", VA = "0x1873318E0")]
	internal void IIBNNLJIAOA(string OMAABFNKJBP, PHGEAGLPDDM ALBFPGNJIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x73322E0", Offset = "0x73316E0", VA = "0x1873322E0")]
	public IEnumerable<EAOMNNFPCNE> JIJGGOEHPHO(string JHKMNGJCLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x73330A0", Offset = "0x73324A0", VA = "0x1873330A0")]
	private IEnumerable<EAOMNNFPCNE> PMGDJGCHNIA(string JHKMNGJCLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7331040", Offset = "0x7330440", VA = "0x187331040")]
	internal IEnumerable<EAOMNNFPCNE> EADPLDCFELJ(string JHKMNGJCLAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7332590", Offset = "0x7331990", VA = "0x187332590")]
	private EAOMNNFPCNE MAGMAIADEDN(AvatarOutfitSelectionData KKFAGDKNOAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7331A40", Offset = "0x7330E40", VA = "0x187331A40")]
	private void IIPPEKKJFIB(AvatarCustomizationSettingsData FOMBEKJLCFE, PHGEAGLPDDM ALBFPGNJIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7332920", Offset = "0x7331D20", VA = "0x187332920")]
	private EAOMNNFPCNE MAGMAIADEDN(string INAPJMJDOJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7332DA0", Offset = "0x73321A0", VA = "0x187332DA0")]
	internal static (OBJHNMCDGDL, string, string) OOLCNOCPKNK(string INAPJMJDOJG, CCAOPILOOAO AJLMACGMCAP)
	{
		return default((OBJHNMCDGDL, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7332390", Offset = "0x7331790", VA = "0x187332390")]
	private DALAGIAKGMF? KMGIKEPOKCB(string? JINNLDEOCMO, Vector2 ELJHIGPGIBG, float DHIKJADGNNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7332C40", Offset = "0x7332040", VA = "0x187332C40")]
	private static KOIFPCMFICK NGKGNNJEPLE(AvatarCustomizationSettingsData.AnchorParams FCEFAPAPCKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GAFKBMEFLIK]
internal class CANNPJMEKJG : EAEOBHDNMCC, FKPEHJBGAMD
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x732BBF0", Offset = "0x732AFF0", VA = "0x18732BBF0")]
	public CANNPJMEKJG(CGBMLLAMNKD BIMDCCLIKDF, OPIFMDAOECG KAKBMLMFMPN, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x732B500", Offset = "0x732A900", VA = "0x18732B500", Slot = "4")]
	public GJIPACLFKPD IMJDHHAECMF(PHGEAGLPDDM GIDGOODJFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x732B8B0", Offset = "0x732ACB0", VA = "0x18732B8B0")]
	private string LENPFBKKEJM(PHGEAGLPDDM ALBFPGNJIFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x732B9B0", Offset = "0x732ADB0", VA = "0x18732B9B0")]
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

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7333A40", Offset = "0x7332E40", VA = "0x187333A40")]
	public MGMLOEGCJPB(KMANENIEGGA<OJDOIIFPLOL, IJBHONDDGJA> MEODFFDDHNP, CCAOPILOOAO AJLMACGMCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7333610", Offset = "0x7332A10", VA = "0x187333610", Slot = "6")]
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

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7330F50", Offset = "0x7330350", VA = "0x187330F50")]
	public LIFADLMPEGP(FKPEHJBGAMD OCHIIFJHKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7330BB0", Offset = "0x732FFB0", VA = "0x187330BB0", Slot = "4")]
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

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7329F60", Offset = "0x7329360", VA = "0x187329F60")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JOJPIGJLLGI
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7330270", Offset = "0x732F670", VA = "0x187330270")]
	public static HAHPCGIIIOL GFOCOOKFNLL(this DAJNIKEGIHH GIDGOODJFLJ)
	{
		return default(HAHPCGIIIOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7330380", Offset = "0x732F780", VA = "0x187330380")]
	public static DAJNIKEGIHH IMJDHHAECMF(this HAHPCGIIIOL APNLALLMOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x73304A0", Offset = "0x732F8A0", VA = "0x1873304A0")]
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

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x5647640", Offset = "0x5646A40", VA = "0x185647640")]
			public AnchorParams(Vector2 NHEABMEEBBE, Vector3 GFMEDHAJNFG, Vector3 AAOMFNIJCFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7329EB0", Offset = "0x73292B0", VA = "0x187329EB0")]
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
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x732A790", Offset = "0x7329B90", VA = "0x18732A790")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x44FF530", Offset = "0x44FE930", VA = "0x1844FF530")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB3C450", Offset = "0xB3B850", VA = "0x180B3C450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xD6CA30", Offset = "0xD6BE30", VA = "0x180D6CA30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x1022A20", Offset = "0x1021E20", VA = "0x181022A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x94D470", Offset = "0x94C870", VA = "0x18094D470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x732A840", Offset = "0x7329C40", VA = "0x18732A840")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x94B9C0", Offset = "0x94ADC0", VA = "0x18094B9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xA928E0", Offset = "0xA91CE0", VA = "0x180A928E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xA92900", Offset = "0xA91D00", VA = "0x180A92900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x94FB20", Offset = "0x94EF20", VA = "0x18094FB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x732A880", Offset = "0x7329C80", VA = "0x18732A880")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xCBE8D0", Offset = "0xCBDCD0", VA = "0x180CBE8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xED9A50", Offset = "0xED8E50", VA = "0x180ED9A50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x151EAC0", Offset = "0x151DEC0", VA = "0x18151EAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x951C60", Offset = "0x951060", VA = "0x180951C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x951C70", Offset = "0x951070", VA = "0x180951C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1FAA9B0", Offset = "0x1FA9DB0", VA = "0x181FAA9B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xCEDBD0", Offset = "0xCECFD0", VA = "0x180CEDBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x981160", Offset = "0x980560", VA = "0x180981160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x9811C0", Offset = "0x9805C0", VA = "0x1809811C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x955550", Offset = "0x954950", VA = "0x180955550")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x9555C0", Offset = "0x9549C0", VA = "0x1809555C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x955640", Offset = "0x954A40", VA = "0x180955640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x9554E0", Offset = "0x9548E0", VA = "0x1809554E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x9555D0", Offset = "0x9549D0", VA = "0x1809555D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x955500", Offset = "0x954900", VA = "0x180955500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xA6B960", Offset = "0xA6AD60", VA = "0x180A6B960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x1112680", Offset = "0x1111A80", VA = "0x181112680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x955620", Offset = "0x954A20", VA = "0x180955620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x955600", Offset = "0x954A00", VA = "0x180955600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xB83C50", Offset = "0xB83050", VA = "0x180B83C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xCDF050", Offset = "0xCDE450", VA = "0x180CDF050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x94E950", Offset = "0x94DD50", VA = "0x18094E950")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x94E910", Offset = "0x94DD10", VA = "0x18094E910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xAB50D0", Offset = "0xAB44D0", VA = "0x180AB50D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCF2C30", Offset = "0xCF2030", VA = "0x180CF2C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xAFF540", Offset = "0xAFE940", VA = "0x180AFF540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAFC080", Offset = "0xAFB480", VA = "0x180AFC080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public MLFKPMGCMHF UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xD71650", Offset = "0xD70A50", VA = "0x180D71650")]
			get
			{
				return default(MLFKPMGCMHF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xD71BD0", Offset = "0xD70FD0", VA = "0x180D71BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xD71930", Offset = "0xD70D30", VA = "0x180D71930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA62730", Offset = "0xA61B30", VA = "0x180A62730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x732A860", Offset = "0x7329C60", VA = "0x18732A860")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x732A8A0", Offset = "0x7329CA0", VA = "0x18732A8A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x732A3F0", Offset = "0x73297F0", VA = "0x18732A3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x732A8C0", Offset = "0x7329CC0", VA = "0x18732A8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
