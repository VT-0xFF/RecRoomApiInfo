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
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0BD0", Offset = "0x6CBF5D0", VA = "0x186CC0BD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D78D0", Offset = "0x8D62D0", VA = "0x1808D78D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6CC2450", Offset = "0x6CC0E50", VA = "0x186CC2450", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2164780", Offset = "0x2163180", VA = "0x182164780")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AOOPPFIKPBO]
internal class IJEHMPCODNA : LOJCNOOHFEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CHJDKOANMKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public IJEHMPCODNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CNAPJFDNBAH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EPDLFMBOFFA PLNNEAPFHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IGCNCJPPCDN LPMMCNAECFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FEJFMNGJDJL MJLIHCGKKKE;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF0E0", Offset = "0x6CBDAE0", VA = "0x186CBF0E0")]
	[UsedImplicitly]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	internal static void DOGFOLHPBJG(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0A50", Offset = "0x6CBF450", VA = "0x186CC0A50")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IJEHMPCODNA([CCLEDEMDDDH(null)] EPDLFMBOFFA PLNNEAPFHMK, [CCLEDEMDDDH(null)] IGCNCJPPCDN LPMMCNAECFD, [CCLEDEMDDDH(null)] FEJFMNGJDJL MJLIHCGKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF230", Offset = "0x6CBDC30", VA = "0x186CBF230", Slot = "5")]
	public BPKALIODDHJ JOJGNADPPNF(CNAPJFDNBAH IFNFJLLNCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFD60", Offset = "0x6CBE760", VA = "0x186CBFD60", Slot = "4")]
	public BPKALIODDHJ MKOKIIIDEIJ(CNAPJFDNBAH IFNFJLLNCCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFA10", Offset = "0x6CBE410", VA = "0x186CBFA10", Slot = "6")]
	public BPDLNDFDPGN KFPOPAIAGCL(BPKALIODDHJ GGEMPJLCHFC, int JHMIOGNAOMC, string? JHJFHDOAMLG, string? BCAJBLCMFDH, HBMANPGAFHF MIBABAGCHGL, List<PADBJIIHKJA>? BEJHDMKKOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC07E0", Offset = "0x6CBF1E0", VA = "0x186CC07E0", Slot = "7")]
	public bool NOAKDDIFPPA(PNAMKNIHPME GFPLIJGIMMM, [Out] BPKALIODDHJ? EMODBHKBJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF150", Offset = "0x6CBDB50", VA = "0x186CBF150", Slot = "8")]
	public bool FPGFKFLECAG(BPDLNDFDPGN GPLCBDNFPNL, [Out] BPKALIODDHJ? EMODBHKBJEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFB20", Offset = "0x6CBE520", VA = "0x186CBFB20", Slot = "9")]
	public bool LPAGPIIHCBC(BPDLNDFDPGN GPLCBDNFPNL, [Out] OFGIDLJOADK? GFPLIJGIMMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2F282C0", Offset = "0x2F26CC0", VA = "0x182F282C0")]
	private bool PCNIDIJKBCI<TInput, TOutput>(TInput CPOLINJHFNA, FDCDIDPOFEP<TInput, TOutput> IHLBFBBFIBF, [Out] TOutput? KIBAOEBFCJF) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFBB0", Offset = "0x6CBE5B0", VA = "0x186CBFBB0")]
	[CompilerGenerated]
	private MGAEPMBOLCO LPNEBBLBGCA(FaceFeatureType BKCPEFEEFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0870", Offset = "0x6CBF270", VA = "0x186CC0870")]
	[CompilerGenerated]
	private MGAEPMBOLCO PNFNENIOFEA(FaceFeatureType BKCPEFEEFMI, CHJDKOANMKH P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AOOPPFIKPBO]
internal class CFMDJMCIDJI : EPDLFMBOFFA
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void GKNCGBCGMKL<in TData>(TData EMODBHKBJEE, IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly FEJFMNGJDJL MJLIHCGKKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly MKDIGONPDGF KDKHLEEPODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GKNCGBCGMKL<BPKALIODDHJ>?[] PLNNEAPFHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GKNCGBCGMKL<OFGIDLJOADK>?[] AKDDEBOIJPP;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE7C0", Offset = "0x6CBD1C0", VA = "0x186CBE7C0")]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	[UsedImplicitly]
	internal static void DOGFOLHPBJG(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CBECF0", Offset = "0x6CBD6F0", VA = "0x186CBECF0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal CFMDJMCIDJI([CCLEDEMDDDH(null)] FEJFMNGJDJL MJLIHCGKKKE, [CCLEDEMDDDH(null)] MKDIGONPDGF KDKHLEEPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE990", Offset = "0x6CBD390", VA = "0x186CBE990", Slot = "4")]
	public bool DONOHAFEBBB(BPKALIODDHJ EMODBHKBJEE, IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE830", Offset = "0x6CBD230", VA = "0x186CBE830", Slot = "5")]
	public bool DONOHAFEBBB(OFGIDLJOADK GFPLIJGIMMM, IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDD50", Offset = "0x6CBC750", VA = "0x186CBDD50")]
	private void AAILIGOOKMF(BPKALIODDHJ EMODBHKBJEE, IReadOnlyList<PADBJIIHKJA>? HBABIBCNPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEAC0", Offset = "0x6CBD4C0", VA = "0x186CBEAC0")]
	private void KIGBHOFFEFJ(BPKALIODDHJ EMODBHKBJEE, IReadOnlyList<PADBJIIHKJA>? HBABIBCNPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEA90", Offset = "0x6CBD490", VA = "0x186CBEA90")]
	private void ELDIFLOMLHO(BPKALIODDHJ EMODBHKBJEE, IReadOnlyList<PADBJIIHKJA>? HBABIBCNPCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE790", Offset = "0x6CBD190", VA = "0x186CBE790")]
	private void BFMGCAHLOHB(BPKALIODDHJ EMODBHKBJEE, IReadOnlyList<PADBJIIHKJA>? HBABIBCNPCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EPDLFMBOFFA
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DONOHAFEBBB(BPKALIODDHJ EMODBHKBJEE, IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DONOHAFEBBB(OFGIDLJOADK GFPLIJGIMMM, IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE);
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
		public BCJIGCGHCFG AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6CBBA10", Offset = "0x6CBA410", VA = "0x186CBBA10")]
		public void GIKIGGMLNJM(AnimationPoseSetting GDOGPMPJPOO, float OJDFBODCONB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6CBBB40", Offset = "0x6CBA540", VA = "0x186CBBB40")]
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
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x6CBC430", Offset = "0x6CBAE30", VA = "0x186CBC430")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC3F0", Offset = "0x6CBADF0", VA = "0x186CBC3F0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6CBBB60", Offset = "0x6CBA560", VA = "0x186CBBB60")]
		private void DMAOILDGEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6C43730", Offset = "0x6C42130", VA = "0x186C43730", Slot = "4")]
		public void SetEnabled(bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC460", Offset = "0x6CBAE60", VA = "0x186CBC460")]
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
		[Header("Head Objects Placement")]
		[Tooltip("Offsets applied to widgets around the head like voice lines and vfx emotes")]
		public HeadLogicOffsets HeadOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Tooltip("Offsets applied to transforms on the players left hand when in modern bean mode")]
		public HandLogicOffsets ModernBeanLeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Header("Hand Animation")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AvatarHandDisplaySettings AvatarHandDisplaySettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		[FormerlySerializedAs("WatchClockFaceLocalPosition")]
		public Vector3 FullBodyWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		[FormerlySerializedAs("WatchClockFaceLocalUniformScale")]
		public float FullBodyWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the modern bean body's geometry")]
		public Vector3 ModernBeanWatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("The local uniform scale to apply to the clock face to match the modern bean body's geometry")]
		public float ModernBeanWatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Header("Performance Tuning")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x361")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x36C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C4")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Velocity threshold where feet are blended in local space to avoid stretching")]
		public float LocalBlendVelocityThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3FC")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x410")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
		public Vector3 FootScaleCenterOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41C")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("Scalar to pick a slower or faster animation when using high heels")]
		public float LocomotionAnimationSelectionScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x420")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("Scalar for stride at 90 deg heel")]
		public float StrideScaleAt90DegHeel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x424")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("Length of foot")]
		public float HeelRotFootLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x428")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("Height offset from ground to center of toe bone")]
		public float ToeOffsetFromGround;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42C")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("Default angle of the foot bone as seen in idle")]
		public float FootRestAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x430")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x438")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC4E0", Offset = "0x6CBAEE0", VA = "0x186CBC4E0")]
		public AnimationPoseSetting KMPLEMNKIJK(BCJIGCGHCFG MKHHNLBGLAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC4A0", Offset = "0x6CBAEA0", VA = "0x186CBC4A0")]
		public void IGMCENCOPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC510", Offset = "0x6CBAF10", VA = "0x186CBC510")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF0A0", Offset = "0x6CBDAA0", VA = "0x186CBF0A0")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class AKDCOJJAKEG : DONKFOPABGD
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class BGLHKKAEOAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private Vector3 IBIJBKFDIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Quaternion IFIFNCABIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private Vector3 GPAECJIHALL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private Transform HLBLHINGOAL;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Vector3 ECJFOPPBAIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x18197A0", Offset = "0x18181A0", VA = "0x1818197A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x18197C0", Offset = "0x18181C0", VA = "0x1818197C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Quaternion PGODJELLKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xE56110", Offset = "0xE54B10", VA = "0x180E56110")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xE566A0", Offset = "0xE550A0", VA = "0x180E566A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public float GANDPILLHDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xBF08F0", Offset = "0xBEF2F0", VA = "0x180BF08F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x11DCF00", Offset = "0x11DB900", VA = "0x1811DCF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool ODAKGKCPNNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B0230", Offset = "0x8AEC30", VA = "0x1808B0230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8B00C0", Offset = "0x8AEAC0", VA = "0x1808B00C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool PMECMIOBLFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x8B0100", Offset = "0x8AEB00", VA = "0x1808B0100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B0250", Offset = "0x8AEC50", VA = "0x1808B0250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool CMCFHEGEHJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8B00A0", Offset = "0x8AEAA0", VA = "0x1808B00A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x8B0140", Offset = "0x8AEB40", VA = "0x1808B0140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public float JGKLMAPDAGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xBF0910", Offset = "0xBEF310", VA = "0x180BF0910")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x287CE60", Offset = "0x287B860", VA = "0x18287CE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6CBDD30", Offset = "0x6CBC730", VA = "0x186CBDD30")]
		public void MHAPDPKHGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD1F0", Offset = "0x6CBBBF0", VA = "0x186CBD1F0")]
		public void GBCMCHIKGHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD9D0", Offset = "0x6CBC3D0", VA = "0x186CBD9D0")]
		public float KIFFGHLDHBG(Vector3 CPCLNAKNFGM, Quaternion LFDKHOLPOGG, [In] FootSettings IIOPAKHDFLL, float LFAOLNBDPJA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD300", Offset = "0x6CBBD00", VA = "0x186CBD300")]
		public void JAPAHPBPHHO(Vector3 PFMJGFIJJBK, Quaternion FHLMJNNKKDF, Transform CIAEBAGJIGJ, float CGPOADGJKFM, bool JNOJGIILEGF, bool BNDIOJAOMGG, float HENEJOFCGHF, float CMDGLJJEGFG, Transform ELFANOAFHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCFC0", Offset = "0x6CBB9C0", VA = "0x186CBCFC0")]
		public void FMJHEGLKPAC(Transform OCBDHLEBDDG, Transform ELFANOAFHKM, bool OHEKLEODNBP, bool GGGBDCLFLDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6CBD200", Offset = "0x6CBBC00", VA = "0x186CBD200")]
		private void GMEOJFDIKEA(Transform ELFANOAFHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6CBDBE0", Offset = "0x6CBC5E0", VA = "0x186CBDBE0")]
		public void MCGLJKODHIC(Transform ELFANOAFHKM, AvatarFullBodyConfiguration BLHPPLPBDDE, Vector3 FNECBFHNPPH, float JPJNFIHMPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCFB0", Offset = "0x6CBB9B0", VA = "0x186CBCFB0")]
		public void CGLJGMLCODF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6CBDD40", Offset = "0x6CBC740", VA = "0x186CBDD40")]
		public BGLHKKAEOAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class PFGMCJPOJDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private float DAFDMECHEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool HHFDEKBGBJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public AnimationPoseSetting OLPCIPJINMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private float GIMPEPJPMHM;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2280", Offset = "0x6CC0C80", VA = "0x186CC2280")]
		public void LHECHKNLBIL(IKSolverVR.Arm HFHHGNPJOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CC13B0", Offset = "0x6CBFDB0", VA = "0x186CC13B0")]
		public void DIEFGHKFPBM(IKSolverVR.Arm HFHHGNPJOCN, float KDPPKFLKFDD, bool HHFDEKBGBJG, AvatarFullBodyConfiguration BLHPPLPBDDE, float BCADOEPDABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2100", Offset = "0x6CC0B00", VA = "0x186CC2100")]
		private void JOMEHIKPOOL(IKSolverVR.Arm HFHHGNPJOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1880", Offset = "0x6CC0280", VA = "0x186CC1880")]
		public void JLHHKFJJNNB(IKSolverVR.Arm HFHHGNPJOCN, Transform LDMNAIFEEAA, Transform CIAEBAGJIGJ, Quaternion BBBNEKODKNI, Vector3 CPKCBJEGNIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6CC13F0", Offset = "0x6CBFDF0", VA = "0x186CC13F0")]
		private (Vector3, Quaternion) IMEHIAFMHOJ(NHCNFCHGAEN COCBGFDGHFF, Quaternion DHCJAAIADHJ, Vector3 GIGJEGAOMEP)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0C50", Offset = "0x6CBF650", VA = "0x186CC0C50")]
		public void BEMOGFJMMCL(NHCNFCHGAEN COCBGFDGHFF, IKSolverVR.Arm HFHHGNPJOCN, Quaternion DHCJAAIADHJ, Vector3 GIGJEGAOMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0DB0", Offset = "0x6CBF7B0", VA = "0x186CC0DB0")]
		public void CCCNGDLOLOP(NHCNFCHGAEN COCBGFDGHFF, IKSolverVR.Arm HFHHGNPJOCN, Quaternion DHCJAAIADHJ, Vector3 GIGJEGAOMEP, [In] AvatarFullBodyConfiguration BLHPPLPBDDE, [In] JFLLNKPALIH DPGCKOGOMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2140", Offset = "0x6CC0B40", VA = "0x186CC2140")]
		public void LEMHONLPDOC(BCJIGCGHCFG ABGHEMOICIM, AvatarFullBodyConfiguration BLHPPLPBDDE, JFLLNKPALIH DPGCKOGOMEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1C60", Offset = "0x6CC0660", VA = "0x186CC1C60")]
		public void JMAGPLCAMMP(IKSolverVR.Arm HFHHGNPJOCN, Transform LDMNAIFEEAA, Vector3 MOFHOOKIIMN, float AHILKNACNBP, Quaternion KOAKOHCPOAH, Vector3 MHPKPAAHLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6CC22B0", Offset = "0x6CC0CB0", VA = "0x186CC22B0")]
		public PFGMCJPOJDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private enum LDPJGPCFAKA
	{
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct ALAAGDHFPPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct DAIPKHFDPNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static readonly int ILLMHIPLIHK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static readonly int OJPOHLLADNL;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly int BGEHJPFEAFH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly int AHHJHFLODAB;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static readonly int PPEPNBLLOBN;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private static readonly int BHLGGAANCBD;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private static readonly int HEOIEGJNKAN;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private static readonly int BJJNCLBMCFL;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly int IFHOLDEKMDK;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly int AEBLDPCDJLL;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private static readonly int PDBAODFMPIB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static readonly int KFNJNALAHLH;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private static readonly int PHBAJODDGPD;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly int NPBHEMKNAKP;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private static readonly int ENOCBMBGHNG;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static readonly int NLFNFMGEIFH;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private static readonly int OEEIMHFJBFI;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private static readonly int AMPLADPCMNI;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private static readonly int KDDLFLGFJDJ;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly int ALGNNGFALEL;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private static readonly int MACIPKDAKNG;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly int KHADJJILILH;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static readonly int NFNAPMJNBDI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly int NFMEMLPGGFC;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly int BLLLMOBEBFC;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly int GMMIIKCAFDN;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly int HLKAFFELMOI;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private static readonly int MBDGJAKPBKB;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private static readonly int EHOHIKBPGJK;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly int GMKFEHFEONO;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly int IPHIPLGILDK;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static readonly Vector3 ILIHFINHEMD;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private static readonly int CLICBLKCJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private bool CGKCBBGFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private bool JGDAIDJKPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool LNLMCPDKOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool JBBBHGMLIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool BKHOIMCHCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool LNLHDNILHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Vector3 CKJLKHLOLAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private string OHGFPHGJHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private JPOJNCJHFMP? LFEOGGPOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private HKGFJDCLMBF? DEFIBDDBAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private FNLOGGHCJGN DKEADOAHJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private HLHGOHCEHJI NAHDEFKHCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private NHCNFCHGAEN ICCDGNKOAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private NHCNFCHGAEN ELFIDCAKNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool PNNELFKMACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool HIHGIKFGMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly HIFEFJPJONN CKIACNMEEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly JGAHGAMLEHP IPIFCNFJIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private int DMONDLBDOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private float NHGCJIHPIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private GameObject JGBMOKPHIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Transform BONHDCBAKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Transform NGLCFJMCLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Transform DMNIAJMFGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Transform CPGKNOCHOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private float EKGNMPEGDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private float MDJBJBGLOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Vector3 LJMCIBAPGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Quaternion IMDEKJHEJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Transform EHKLBGJLICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Transform LOBLDJIKJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Transform DKMFKKKAICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private AIIJEJIPADL GDFBFAOBLCF;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly ProfilerMarker CKEKEGCIKAI;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly ProfilerMarker LMMANOOLCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private ProfilerMarker IEHIEOLCIEC;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly ProfilerMarker KEFDGMMCPPG;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly ProfilerMarker LMHLCKHKFMJ;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly ProfilerMarker HBOHAPOPNJJ;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly List<AKDCOJJAKEG> JLAKFFCPKHP;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static int HIDMIGBPKPH;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> GGNOLMIBMKO;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static int JNCLBOJCECA;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static int DMIKHGAJMPL;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static int BHCMANNAHJK;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static int EMNGABDAJEC;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static float BCDMOMGPNHC;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static int IDIDCEMKHIG;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static float HCLLMLLIBED;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static float ADNAKIPMIKL;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static float OEANJIEJPLL;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static float NONIBGFMNOO;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static NBCHLINKMJN AOKPJCFHEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private float OFFEGECBOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool KNCEJIIPHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private float NMMJJCFOAMC;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int LDDNAFIODMB;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int BBMDHLOMNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private BGLHKKAEOAH NADHGCKCGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private BGLHKKAEOAH IECOIINHDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float BMFNOFOAIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Vector3 NJOEJEOGIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Vector3 CKIJFCJOHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool GFHOKFAJALD;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly Quaternion HCNAOAEHNAL;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly Quaternion BAOLIJFDEMA;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly Vector3 EMEJCHLOPJA;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly Vector3 CIPBLEPLBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private float IEMNOLKHAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private float NCHFDOMCJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PFGMCJPOJDN LPEMLDLPKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private PFGMCJPOJDN BKNGMNAKFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private JDHDMDFAGLC MOLDAJDODDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private DLMLNHENFJD PPPPHIHGDPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly ICIGGJGMGID FHELHNIHEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private float NJNEHGJGKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private float PGNNCMHLHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly DLMLNHENFJD BEAHMKDFCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Vector3 AFAAFIPBCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private Vector3 MGDLBFNJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private float LCLLHMFNIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private float JFMDPBMIDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly DLMLNHENFJD LBFKDIALLEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly JDHDMDFAGLC EIABHADGAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private readonly DLMLNHENFJD NGHDNJDPGLA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public APNHDGDPKOI AAOEOMKGMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public APNHDGDPKOI NGOBHNFKGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AvatarConfiguration AKACPMOKNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD570", Offset = "0x6CABF70", VA = "0x186CAD570", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CNAPJFDNBAH FICNCNPGIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8030", Offset = "0x6CB6A30", VA = "0x186CB8030", Slot = "23")]
		get
		{
			return default(CNAPJFDNBAH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarFullBodyConfiguration AMLHGDLGCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3D10", Offset = "0x6CA2710", VA = "0x186CA3D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private Transform EJPPIKKELNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8370", Offset = "0x6CA6D70", VA = "0x186CA8370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private Transform MNDLJDCPFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6CB5830", Offset = "0x6CB4230", VA = "0x186CB5830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private SkinnedMeshRenderer NNGMJAPLPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD440", Offset = "0x6CABE40", VA = "0x186CAD440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Renderer[] OFHNCKIINMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6CA8470", Offset = "0x6CA6E70", VA = "0x186CA8470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private GameObject[] DLCBKIDKNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6CA94A0", Offset = "0x6CA7EA0", VA = "0x186CA94A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Animator NFGFNDCHBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC8F0", Offset = "0x6CAB2F0", VA = "0x186CAC8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private VRIK NIAFGOIEPHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6360", Offset = "0x6CA4D60", VA = "0x186CA6360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private LMJMCLOPILC MMPADHGGALH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB1B40", Offset = "0x6CB0540", VA = "0x186CB1B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private LMJMCLOPILC AIGFELLDBCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2C20", Offset = "0x6CA1620", VA = "0x186CA2C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private LMJMCLOPILC LGANNAILPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2CD0", Offset = "0x6CB16D0", VA = "0x186CB2CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private LMJMCLOPILC GLOPKLDFEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6CAEA80", Offset = "0x6CAD480", VA = "0x186CAEA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private LMJMCLOPILC JFEINAPDIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4F10", Offset = "0x6CA3910", VA = "0x186CA4F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private LMJMCLOPILC LDNLGFBMPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2820", Offset = "0x6CA1220", VA = "0x186CA2820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private LMJMCLOPILC IBNJPOIGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6540", Offset = "0x6CA4F40", VA = "0x186CA6540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private LMJMCLOPILC LBGJFPNBAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6CAE4D0", Offset = "0x6CACED0", VA = "0x186CAE4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public HKGFJDCLMBF DNKCIHPIJFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD770", Offset = "0x6CAC170", VA = "0x186CAD770", Slot = "15")]
		get
		{
			return default(HKGFJDCLMBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GIGKENLKLJE DOADFPLCOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x97E760", Offset = "0x97D160", VA = "0x18097E760", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AKDDLLHAOHM IHOFENBCDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x97E690", Offset = "0x97D090", VA = "0x18097E690", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FNNNPLJFKOG GKEJPLBBKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x97E780", Offset = "0x97D180", VA = "0x18097E780", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FNNNPLJFKOG LDFFEHCFLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1874340", Offset = "0x1872D40", VA = "0x181874340", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string HNDKNHLBFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8AD530", Offset = "0x8ABF30", VA = "0x1808AD530", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private Transform EMGPMAGEBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9C30", Offset = "0x6CB8630", VA = "0x186CB9C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private Transform GIDPGMJBDNL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA93A0", Offset = "0x6CA7DA0", VA = "0x186CA93A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform OJKOKFDJHIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF350", Offset = "0x6CADD50", VA = "0x186CAF350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private bool HGFDMJBNCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7F80", Offset = "0x6CA6980", VA = "0x186CA7F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform BLOKBLIBCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB61B0", Offset = "0x6CB4BB0", VA = "0x186CB61B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public GameObject NJFNKLJIFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6CAC9F0", Offset = "0x6CAB3F0", VA = "0x186CAC9F0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HeadLogicOffsets HDNIKHCFNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5850", Offset = "0x6CA4250", VA = "0x186CA5850", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public Transform NEBPPIGGDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1874090", Offset = "0x1872A90", VA = "0x181874090", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Transform IJMIFJNMLIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1874320", Offset = "0x1872D20", VA = "0x181874320", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Transform DKOMGHHNNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xE50420", Offset = "0xE4EE20", VA = "0x180E50420", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Transform ONKCDNAJCMO
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xE50250", Offset = "0xE4EC50", VA = "0x180E50250", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Vector3 EGNAJMMNNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7CD0", Offset = "0x6CB66D0", VA = "0x186CB7CD0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float MNBCFKNGJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8AD0", Offset = "0x6CB74D0", VA = "0x186CB8AD0", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform CMJMAPBPAID
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF3C0", Offset = "0x6CADDC0", VA = "0x186CAF3C0", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform BBAPNOILKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1B66F40", Offset = "0x1B65940", VA = "0x181B66F40", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform PIFBHDEFAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xD84380", Offset = "0xD82D80", VA = "0x180D84380", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform JKNBCHMKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1B67010", Offset = "0x1B65A10", VA = "0x181B67010", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private bool NOLNNOMEJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7F30", Offset = "0x6CB6930", VA = "0x186CB7F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private bool MFIINDNDCCD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6CAF2D0", Offset = "0x6CADCD0", VA = "0x186CAF2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private bool NMLDLBGBFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7020", Offset = "0x6CB5A20", VA = "0x186CB7020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CAFB20", Offset = "0x6CAE520", VA = "0x186CAFB20")]
	private void LHNNBLIBJAD([In] JFLLNKPALIH NKENNDGDIAJ, [In] AvatarFullBodyConfiguration BLHPPLPBDDE, bool EONBLAHKBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9410", Offset = "0x6CA7E10", VA = "0x186CA9410")]
	private float HFMBFNLMEBI([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA82F0", Offset = "0x6CA6CF0", VA = "0x186CA82F0")]
	private float FLPFMFODFBO([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC030", Offset = "0x6CAAA30", VA = "0x186CAC030")]
	private void IIMEIEALJPC(JFLLNKPALIH NKENNDGDIAJ, AvatarFullBodyConfiguration BLHPPLPBDDE, bool EONBLAHKBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8EB0", Offset = "0x6CB78B0", VA = "0x186CB8EB0")]
	private void PGKMDKGBDMD([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CABDA0", Offset = "0x6CAA7A0", VA = "0x186CABDA0")]
	private void IEKPFLPJMHA([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB560", Offset = "0x6CB9F60", VA = "0x186CBB560")]
	public AKDCOJJAKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6CADB60", Offset = "0x6CAC560", VA = "0x186CADB60", Slot = "12")]
	public void JGKBCKDDIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD080", Offset = "0x6CABA80", VA = "0x186CAD080", Slot = "13")]
	public void JCCLHIGNDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4360", Offset = "0x6CA2D60", VA = "0x186CA4360", Slot = "14")]
	public void BKPGKKMKOJM(bool DFPNDDDDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA360", Offset = "0x6CB8D60", VA = "0x186CBA360", Slot = "25")]
	public Transform PLHKHNEPJOC(string EJBPAJAJEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6CABEA0", Offset = "0x6CAA8A0", VA = "0x186CABEA0", Slot = "26")]
	public Vector3? IHANAEHADLL(string EJBPAJAJEGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5010", Offset = "0x6CA3A10", VA = "0x186CA5010", Slot = "7")]
	public void CMANGHDALHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD670", Offset = "0x6CAC070", VA = "0x186CAD670")]
	private void JDNCLIKOJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA9E0", Offset = "0x6CB93E0", VA = "0x186CBA9E0")]
	private Vector3 PPHDFMLLGEE([In] JFLLNKPALIH DPGCKOGOMEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1ED0", Offset = "0x6CB08D0", VA = "0x186CB1ED0", Slot = "6")]
	public void LNOBODLEKIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6CAEA10", Offset = "0x6CAD410", VA = "0x186CAEA10", Slot = "8")]
	public void JMAFDOKDGAE(float LMEFCJEMAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9F20", Offset = "0x6CA8920", VA = "0x186CA9F20")]
	private void IDEMOOLGIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2EE0", Offset = "0x6CB18E0", VA = "0x186CB2EE0", Slot = "4")]
	public void MAAIFCMKAMP(string BGPGNNIBJFI, JPOJNCJHFMP KKKMFMEBDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5310", Offset = "0x6CB3D10", VA = "0x186CB5310", Slot = "5")]
	public void MJAGFAMPJCE(HKGFJDCLMBF EDKFLPHBLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE5D0", Offset = "0x6CACFD0", VA = "0x186CAE5D0", Slot = "11")]
	public void JLFGKNGOPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5920", Offset = "0x6CA4320", VA = "0x186CA5920", Slot = "24")]
	public void DCGMNNPAJFH([Out] Vector3 LICKOCCDKOC, [Out] Quaternion KOAKOHCPOAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD540", Offset = "0x6CABF40", VA = "0x186CAD540")]
	private void JDBIEGPHEJD([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6260", Offset = "0x6CA4C60", VA = "0x186CA6260", Slot = "27")]
	public void DGNCPLBHOLO(float CGJJFFKAPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6CB98E0", Offset = "0x6CB82E0", VA = "0x186CB98E0", Slot = "28")]
	public void PHKINMJMDLO(float PAIPIHLCOBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6CB57A0", Offset = "0x6CB41A0", VA = "0x186CB57A0", Slot = "44")]
	public void MLGPHOFFCFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2BD0", Offset = "0x6CA15D0", VA = "0x186CA2BD0", Slot = "29")]
	public void ALNLCFKNPBP(bool GBANFOJGECF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6CA58D0", Offset = "0x6CA42D0", VA = "0x186CA58D0", Slot = "30")]
	public HandLogicOffsets DBBAAALDBPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8A10", Offset = "0x6CB7410", VA = "0x186CB8A10", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets PDIEEFMJKCJ()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CABC40", Offset = "0x6CAA640", VA = "0x186CABC40")]
	private void IDMDHBDBINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8570", Offset = "0x6CA6F70", VA = "0x186CA8570")]
	private void GIPHLNHLION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC490", Offset = "0x6CAAE90", VA = "0x186CAC490")]
	private void ILIPFOGCCIP(PLAOFEANGHJ BMJNLEMEHMD, bool IPPGFKCBGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5D70", Offset = "0x6CB4770", VA = "0x186CB5D70")]
	private void NEBACIDDMEM(PLAOFEANGHJ BMJNLEMEHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3120", Offset = "0x6CA1B20", VA = "0x186CA3120")]
	public Vector3 BBHMJBBEOCF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6CA89F0", Offset = "0x6CA73F0", VA = "0x186CA89F0")]
	private void GPFDFAPMOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA340", Offset = "0x6CB8D40", VA = "0x186CBA340")]
	private void PKKMPPHNMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3350", Offset = "0x6CA1D50", VA = "0x186CA3350")]
	private void BCNNDFEOJCJ(JFLLNKPALIH NKENNDGDIAJ, AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6000", Offset = "0x6CB4A00", VA = "0x186CB6000")]
	private float NGNPAIMNCHH([In] JFLLNKPALIH DPGCKOGOMEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6460", Offset = "0x6CA4E60", VA = "0x186CA6460")]
	private int EJFPDEDKGBD([In] PJIOFBFBPOG OLJIGPMHNNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA4B0", Offset = "0x6CB8EB0", VA = "0x186CBA4B0")]
	private void PMCNPICGBBG(JFLLNKPALIH NKENNDGDIAJ, bool LCNJKEKEDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF740", Offset = "0x6CAE140", VA = "0x186CAF740")]
	private static void LECDBCJBHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7250", Offset = "0x6CA5C50", VA = "0x186CA7250")]
	private static void FBKAALAJPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3170", Offset = "0x6CA1B70", VA = "0x186CA3170")]
	private float BBNNDFOKFFJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6FF0", Offset = "0x6CB59F0", VA = "0x186CB6FF0")]
	private static int OBIJJEABFNB(AKDCOJJAKEG FCKNABCAAPB, AKDCOJJAKEG JGIIKLPFBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8180", Offset = "0x6CA6B80", VA = "0x186CA8180", Slot = "40")]
	public JFLLNKPALIH FLGAIAPPBEO()
	{
		return default(JFLLNKPALIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6320", Offset = "0x6CA4D20", VA = "0x186CA6320")]
	public void EALGCKJAOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6CB87F0", Offset = "0x6CB71F0", VA = "0x186CB87F0")]
	private (bool, bool) PADBJHJIILN()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6CAC780", Offset = "0x6CAB180", VA = "0x186CAC780")]
	private (float, float) INPNLCPLDIJ([In] JFLLNKPALIH DPGCKOGOMEN)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA2A0", Offset = "0x6CA8CA0", VA = "0x186CAA2A0")]
	private void IDJCIOJABFJ([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF420", Offset = "0x6CADE20", VA = "0x186CAF420")]
	private void LCBMKMLPPJH([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6CA67F0", Offset = "0x6CA51F0", VA = "0x186CA67F0")]
	private void ELMBFAJLDMH([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2400", Offset = "0x6CA0E00", VA = "0x186CA2400")]
	private void ADLKJHIDNKG([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE, FootSettings IIOPAKHDFLL, bool OINBPGDCBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6CA71D0", Offset = "0x6CA5BD0", VA = "0x186CA71D0")]
	private float ENGGDLCKAGJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4430", Offset = "0x6CA2E30", VA = "0x186CA4430")]
	private void CGFHLBNNBAP(JFLLNKPALIH DPGCKOGOMEN, AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA89A0", Offset = "0x6CA73A0", VA = "0x186CA89A0")]
	private float GNDHAJDCJNG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA95A0", Offset = "0x6CA7FA0", VA = "0x186CA95A0")]
	private void HMFOBEEOLKG([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE6C0", Offset = "0x6CAD0C0", VA = "0x186CAE6C0")]
	private void JLHHKFJJNNB([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3DA0", Offset = "0x6CA27A0", VA = "0x186CA3DA0")]
	private void BGJGONJNJPH([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7A20", Offset = "0x6CB6420", VA = "0x186CB7A20")]
	private void OJEDICEFAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6CACA90", Offset = "0x6CAB490", VA = "0x186CACA90")]
	private void JBBBDAFLPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6E50", Offset = "0x6CB5850", VA = "0x186CB6E50")]
	private void NODBDJBKGGE([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1C40", Offset = "0x6CB0640", VA = "0x186CB1C40")]
	private void LMBCLHJMJBB(NHCNFCHGAEN KAKKFJOMIOJ, IKSolverVR.Arm HFHHGNPJOCN, Transform LABECMALJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B20", Offset = "0x6CB7520", VA = "0x186CB8B20")]
	private void PGKMDHFMLDL(JFLLNKPALIH DPGCKOGOMEN, AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7D60", Offset = "0x6CB6760", VA = "0x186CB7D60")]
	private void OLKMBMCADKG(NAOHDHLCBAH JDDKGAOHJIN, FNNNPLJFKOG KAKKFJOMIOJ, IKSolverVR.Arm HFHHGNPJOCN, float KDPPKFLKFDD, float BJDMDCFCBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8130", Offset = "0x6CB6B30", VA = "0x186CB8130")]
	private void OOBFPFECDDH([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2D20", Offset = "0x6CA1720", VA = "0x186CA2D20")]
	protected void BBFKNPEGKME([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9C40", Offset = "0x6CA8640", VA = "0x186CA9C40")]
	private void HPMIIMDDJDK([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6CAD8A0", Offset = "0x6CAC2A0", VA = "0x186CAD8A0")]
	protected void JFFDMJMKAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB70A0", Offset = "0x6CB5AA0", VA = "0x186CB70A0")]
	private void OCLLBNPPDIE([In] JFLLNKPALIH DPGCKOGOMEN, [In] LDPJGPCFAKA IALBBLKCHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9A90", Offset = "0x6CA8490", VA = "0x186CA9A90")]
	private void HMKGMGAMLAH(JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB57F0", Offset = "0x6CB41F0", VA = "0x186CB57F0")]
	private void MMHPCLMBMLG([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5CB0", Offset = "0x6CA46B0", VA = "0x186CA5CB0")]
	private Vector3 DDJPMKDCJON([In] JFLLNKPALIH DPGCKOGOMEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5F30", Offset = "0x6CB4930", VA = "0x186CB5F30")]
	private void NEIDPGBFDMK([In] JFLLNKPALIH DPGCKOGOMEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6CB4EE0", Offset = "0x6CB38E0", VA = "0x186CB4EE0")]
	private float MHKIMGAKPNI(float CMDGLJJEGFG, [In] JFLLNKPALIH DPGCKOGOMEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6CB78D0", Offset = "0x6CB62D0", VA = "0x186CB78D0")]
	private void OEJICLLKPON(float CMDGLJJEGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8CB0", Offset = "0x6CA76B0", VA = "0x186CA8CB0")]
	private void GPPMKLDHFAP([In] JFLLNKPALIH DPGCKOGOMEN, LDPJGPCFAKA IALBBLKCHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9C80", Offset = "0x6CB8680", VA = "0x186CB9C80")]
	private float PJKMGAIKJEH([In] JFLLNKPALIH NKENNDGDIAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6CB1350", Offset = "0x6CAFD50", VA = "0x186CB1350")]
	private void LKDBHAIAEMG(JFLLNKPALIH DPGCKOGOMEN, LDPJGPCFAKA IALBBLKCHJA, Vector3 OPOGJMHGDDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6640", Offset = "0x6CA5040", VA = "0x186CA6640")]
	private static void EKMLKPKFIBB(Transform FOBEMKFOBOH, Quaternion MHLCHCEFDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9F70", Offset = "0x6CA8970", VA = "0x186CA9F70")]
	private void IDGLCJLADNO([In] JFLLNKPALIH OEBJLDMOKFB, [In] PJIOFBFBPOG OLJIGPMHNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9070", Offset = "0x6CB7A70", VA = "0x186CB9070")]
	private void PHECNPIELCL([In] JFLLNKPALIH OEBJLDMOKFB, [In] PJIOFBFBPOG OLJIGPMHNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7FD0", Offset = "0x6CA69D0", VA = "0x186CA7FD0")]
	private void FFDBGDPIGBG(float GJLFFCANMDH, [In] JFLLNKPALIH NKENNDGDIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CAEB80", Offset = "0x6CAD580", VA = "0x186CAEB80")]
	private float KCLPHEKHGEL([In] JFLLNKPALIH NKENNDGDIAJ, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2A60", Offset = "0x6CB1460", VA = "0x186CB2A60")]
	private void LODBBHGFPDD([In] JFLLNKPALIH NKENNDGDIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1C20", Offset = "0x6CA0620", VA = "0x186CA1C20")]
	private void ABAKBOAJCCE([In] JFLLNKPALIH NKENNDGDIAJ, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CACCE0", Offset = "0x6CAB6E0", VA = "0x186CACCE0")]
	private void JBIPNBLOLLF([In] JFLLNKPALIH NKENNDGDIAJ, float FEGKDDFHMHG, float JDLFLADEPOP, Vector3 GMOPPGKAKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6450", Offset = "0x6CB4E50", VA = "0x186CB6450")]
	private void NMHHDMCACAE(JFLLNKPALIH NKENNDGDIAJ, AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2920", Offset = "0x6CA1320", VA = "0x186CA2920")]
	private void AKLABBFFKPK(JFLLNKPALIH DPGCKOGOMEN, AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CAE0F0", Offset = "0x6CACAF0", VA = "0x186CAE0F0")]
	private void JHFIFEHIEEE(JFLLNKPALIH NKENNDGDIAJ, AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CAF950", Offset = "0x6CAE350", VA = "0x186CAF950")]
	public void LFDGLCLKCED([In] JFLLNKPALIH DPGCKOGOMEN, [In] AvatarFullBodyConfiguration BLHPPLPBDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6CB62B0", Offset = "0x6CB4CB0", VA = "0x186CB62B0")]
	[CompilerGenerated]
	internal static void NKHLDNFPKKK(Transform GOJOFOOEGJK, IKSolverVR.Arm HFHHGNPJOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6270", Offset = "0x6CA4C70", VA = "0x186CA6270")]
	[CompilerGenerated]
	internal static void EABPMGNGINF(Vector3 OOGBHJCMCCG, Vector3 DMECNEAOFNO, ALAAGDHFPPK P_2, DAIPKHFDPNE P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA61C0", Offset = "0x6CA4BC0", VA = "0x186CA61C0")]
	[CompilerGenerated]
	internal static void DDNAAIFDLON(BGLHKKAEOAH NDMADGIEAIO, BGLHKKAEOAH JEPMOPHGBIJ, Vector3 JALBLKCHMMF, float BHAOKKINJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2DD0", Offset = "0x6CB17D0", VA = "0x186CB2DD0")]
	[CompilerGenerated]
	internal static bool LPBALDIEMGM(IKSolverVR.Arm HFHHGNPJOCN, HNMJCAEAOMO CLLNNCNFMMG, float CBPMCKEAFOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5930", Offset = "0x6CB4330", VA = "0x186CB5930")]
	[CompilerGenerated]
	internal static float NDLCOBILKKJ(Vector3 MBIKILAMHLJ, Vector3 CHPPCLDBMOH, Vector3 CJIHELCPAAE, JFLLNKPALIH NKENNDGDIAJ, AvatarFullBodyConfiguration BLHPPLPBDDE, float FDHHGENAMHL)
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
		public enum JNCGMFHHBIM
		{
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[ANCPDOHHLMJ(CAHCDFDGNOL.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[SerializeField]
		private JNCGMFHHBIM handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCF50", Offset = "0x6CBB950", VA = "0x186CBCF50")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCF10", Offset = "0x6CBB910", VA = "0x186CBCF10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6CBC910", Offset = "0x6CBB310", VA = "0x186CBC910")]
		private void DMAOILDGEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C43730", Offset = "0x6C42130", VA = "0x186C43730", Slot = "4")]
		public void SetEnabled(bool FNEAOIOIFKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6CBCF80", Offset = "0x6CBB980", VA = "0x186CBCF80")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, CPKMBNPNIIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[Header("Configuration")]
		[SerializeField]
		private CNAPJFDNBAH avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		[Header("Facial Animation")]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[Header("Watch")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private DONKFOPABGD PFANEOJMCGI;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public DONKFOPABGD IILECHOFHLA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x97E670", Offset = "0x97D070", VA = "0x18097E670", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Transform MIEFPHCCJHE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6CC40A0", Offset = "0x6CC2AA0", VA = "0x186CC40A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3210", Offset = "0x6CC1C10", VA = "0x186CC3210")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3F60", Offset = "0x6CC2960", VA = "0x186CC3F60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3F10", Offset = "0x6CC2910", VA = "0x186CC3F10")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3EA0", Offset = "0x6CC28A0", VA = "0x186CC3EA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3210", Offset = "0x6CC1C10", VA = "0x186CC3210", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6CC36A0", Offset = "0x6CC20A0", VA = "0x186CC36A0", Slot = "6")]
		public DONKFOPABGD CreateAvatarSystem(string BGPGNNIBJFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3EA0", Offset = "0x6CC28A0", VA = "0x186CC3EA0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6CC32D0", Offset = "0x6CC1CD0", VA = "0x186CC32D0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6CC3FB0", Offset = "0x6CC29B0", VA = "0x186CC3FB0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float OFFHKGFMEHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class PHGENPOJDJC : GCFGDDBFMMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Dictionary<string, DONKFOPABGD> DGMMIDDOOOJ;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6CCC330", Offset = "0x6CCAD30", VA = "0x186CCC330")]
	[EPFHFFCDLIN.KOJNBNLGEPK]
	internal static void IEBGPNBFPBJ(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6CCBF60", Offset = "0x6CCA960", VA = "0x186CCBF60", Slot = "4")]
	public DONKFOPABGD AIANLCIBIGP(string LAMNAEADAME, AvatarSystemConfiguration LPOEJEMCNMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6CCC3A0", Offset = "0x6CCADA0", VA = "0x186CCC3A0", Slot = "5")]
	public void NOJPKKPEEPE(string LAMNAEADAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6CCC1F0", Offset = "0x6CCABF0", VA = "0x186CCC1F0", Slot = "6")]
	public string DCNHHKICKKC(string LIKHJCIDJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6CCC180", Offset = "0x6CCAB80", VA = "0x186CCC180")]
	private string BBBKJCBBPGF(string LIKHJCIDJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6CCC520", Offset = "0x6CCAF20", VA = "0x186CCC520")]
	public PHGENPOJDJC()
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
		public class EGINIPABNOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private Dictionary<string, Transform> DPMAPNIHGGE;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public bool EFLKLBKLPDG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x6CC6CC0", Offset = "0x6CC56C0", VA = "0x186CC6CC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6CC6D50", Offset = "0x6CC5750", VA = "0x186CC6D50")]
			public void KJOAHOHIEED(VRIK PLLAMLMAFOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50")]
			public void KCGIIFAENAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6CC6D00", Offset = "0x6CC5700", VA = "0x186CC6D00")]
			public void ENPPBKGKMKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x6CC6E80", Offset = "0x6CC5880", VA = "0x186CC6E80")]
			public EGINIPABNOD()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[HBLGLBJJBJP(CAHCDFDGNOL.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		[ANCPDOHHLMJ(CAHCDFDGNOL.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private readonly EGINIPABNOD GAGDGHMDCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private CPKMBNPNIIO BBGOKAJNMIO;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6CC40F0", Offset = "0x6CC2AF0", VA = "0x186CC40F0")]
		private void GCHKJEOLKFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6CC43D0", Offset = "0x6CC2DD0", VA = "0x186CC43D0")]
		private bool JMHPAAIMNFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4420", Offset = "0x6CC2E20", VA = "0x186CC4420")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4490", Offset = "0x6CC2E90", VA = "0x186CC4490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4430", Offset = "0x6CC2E30", VA = "0x186CC4430")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4700", Offset = "0x6CC3100", VA = "0x186CC4700")]
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
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000102")]
				[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x6CC82D0", Offset = "0x6CC6CD0", VA = "0x186CC82D0")]
			public void IGMCENCOPJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6CC8190", Offset = "0x6CC6B90", VA = "0x186CC8190")]
			public (float, float) CGDHAKBLFAP(Animator HEALJCNKJHL, AnimatorStateInfo BHDLHGMAJHB)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6CC83B0", Offset = "0x6CC6DB0", VA = "0x186CC83B0")]
		public void IGMCENCOPJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8790", Offset = "0x6CC7190", VA = "0x186CC8790")]
		public (float, float) PFLNMMKKILG(Animator HEALJCNKJHL)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6CC85A0", Offset = "0x6CC6FA0", VA = "0x186CC85A0")]
		private (float, float) LLAOCDMOHKO(Animator HEALJCNKJHL, AnimatorStateInfo BHDLHGMAJHB)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6CC89A0", Offset = "0x6CC73A0", VA = "0x186CC89A0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9890", Offset = "0x6CC8290", VA = "0x186CC9890", Slot = "4")]
		public override void OnStateEnter(Animator HEALJCNKJHL, AnimatorStateInfo BHDLHGMAJHB, int CLAFNKFGEEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6CC99F0", Offset = "0x6CC83F0", VA = "0x186CC99F0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class JKODDGLHDNJ<TInput, TOutput> : FDCDIDPOFEP<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	protected readonly MKDIGONPDGF KDKHLEEPODK;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x443C590", Offset = "0x443AF90", VA = "0x18443C590")]
	protected JKODDGLHDNJ(MKDIGONPDGF KDKHLEEPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput DLDAMIHNNNK(TInput CPOLINJHFNA, [Out] IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x443C4F0", Offset = "0x443AEF0", VA = "0x18443C4F0", Slot = "5")]
	public bool PCNIDIJKBCI(TInput CPOLINJHFNA, [Out] TOutput? KIBAOEBFCJF, [Out] IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[AOOPPFIKPBO]
public static class EKPACFEFODO
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly Regex HOELKCBIIFP;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7070", Offset = "0x6CC5A70", VA = "0x186CC7070")]
	public static BFDOKLKPGBD ELOBBNAIFGI(FDADCHGPADP CDALCEGIBHB, LEPAIFLHDDH PMEDJEKNCPD, Guid? EMOKKAAEAEE, Color? NGHEMMCPEDN, MMMGGPPGMJP FHIDJIFAFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6F10", Offset = "0x6CC5910", VA = "0x186CC6F10")]
	public static KPJKPOMJGHE AELBHMJCCGE(BFDOKLKPGBD GGEMPJLCHFC)
	{
		return default(KPJKPOMJGHE);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2D48E50", Offset = "0x2D47850", VA = "0x182D48E50")]
	internal static TModern? FKLMCMOODIC<TModern>(string? CPOLINJHFNA, OHCBNEMNKEA<TModern> AOAOPFAOHKI, MKDIGONPDGF KDKHLEEPODK, GDOGMPPFIOA GLGFKACJOPG, TModern KEBOCHMLFJD) where TModern : struct, CHMODCOCIAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2D4A4A0", Offset = "0x2D48EA0", VA = "0x182D4A4A0")]
	internal static DLFPJNLHGPI JKJIEMKEFAL<TModern>(string? CPOLINJHFNA, OHCBNEMNKEA<TModern> AOAOPFAOHKI, MKDIGONPDGF KDKHLEEPODK, GDOGMPPFIOA GLGFKACJOPG, TModern KEBOCHMLFJD) where TModern : struct, CHMODCOCIAL
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7280", Offset = "0x6CC5C80", VA = "0x186CC7280")]
	internal static List<PADBJIIHKJA> LHKJMHMPFDA(IEnumerable<PLDEGKJNJKC>? KCCCMAMHMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2D4AC80", Offset = "0x2D49680", VA = "0x182D4AC80")]
	internal static string POJGLMCEGJN<TModern>(TModern CPOLINJHFNA, OHCBNEMNKEA<TModern> AOAOPFAOHKI, MKDIGONPDGF KDKHLEEPODK) where TModern : CHMODCOCIAL
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class HGNBBAGFPFO : IGCNCJPPCDN
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FDCDIDPOFEP<PNAMKNIHPME, BPKALIODDHJ> EBHFEGACIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8AD560", Offset = "0x8ABF60", VA = "0x1808AD560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FDCDIDPOFEP<BPDLNDFDPGN, OFGIDLJOADK> KKLFFJACPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public FDCDIDPOFEP<BPDLNDFDPGN, OFGIDLJOADK> HKKEPFLGENO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8AD770", Offset = "0x8AC170", VA = "0x1808AD770", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public PEPPNDHOCLG CIFIEJBCHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD950", Offset = "0x8AC350", VA = "0x1808AD950", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public ENBCGKAOKAE NLMFHOHFPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7BC0", Offset = "0x6CC65C0", VA = "0x186CC7BC0")]
	[EPFHFFCDLIN.KOJNBNLGEPK.HIPEJMKDIFP]
	[UsedImplicitly]
	internal static void DOGFOLHPBJG(KNPHAFHLPCE DNJEODDCEHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7C30", Offset = "0x6CC6630", VA = "0x186CC7C30")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HGNBBAGFPFO([CCLEDEMDDDH("UnitySerialization")] JJOKDGOELGN OIJGOCDMOGG, [CCLEDEMDDDH(null)] HELFAHKGAEL PLPPFFGIMJO, [CCLEDEMDDDH(null)] MKDIGONPDGF KDKHLEEPODK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum FMJFLKNFJJA
{
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AHHDOIFGPCN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2820", Offset = "0x6CC1220", VA = "0x186CC2820")]
	public AHHDOIFGPCN(string FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2780", Offset = "0x6CC1180", VA = "0x186CC2780")]
	public AHHDOIFGPCN(string FCMDIEEAPHD, Exception DMCKMBGEFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6CC27B0", Offset = "0x6CC11B0", VA = "0x186CC27B0")]
	public AHHDOIFGPCN(FMJFLKNFJJA LNMOKLDMMAH, string FCMDIEEAPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6CC27E0", Offset = "0x6CC11E0", VA = "0x186CC27E0")]
	public AHHDOIFGPCN(FMJFLKNFJJA LNMOKLDMMAH, string FCMDIEEAPHD, Exception DMCKMBGEFEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class DFPGGBGNFCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly JJOKDGOELGN OIJGOCDMOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	protected readonly HELFAHKGAEL PLPPFFGIMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected readonly MKDIGONPDGF KDKHLEEPODK;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6B40", Offset = "0x6CC5540", VA = "0x186CC6B40")]
	protected DFPGGBGNFCL(JJOKDGOELGN OIJGOCDMOGG, HELFAHKGAEL PLPPFFGIMJO, MKDIGONPDGF KDKHLEEPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5870", Offset = "0x6CC4270", VA = "0x186CC5870")]
	protected string FFBHJPHFOMB(BPKALIODDHJ EMODBHKBJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5210", Offset = "0x6CC3C10", VA = "0x186CC5210")]
	protected string DJAFMHDBEDA(BPKALIODDHJ EMODBHKBJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5540", Offset = "0x6CC3F40", VA = "0x186CC5540")]
	private AvatarOutfitSelectionData ELOBBNAIFGI(BFDOKLKPGBD PLNPLECCJIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5400", Offset = "0x6CC3E00", VA = "0x186CC5400")]
	private static AvatarCustomizationSettingsData.AnchorParams EHLGMPNNPLG(IJDPLHMEMPG? GGPOINLIANA)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FDCDIDPOFEP<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput DLDAMIHNNNK(TInput CPOLINJHFNA, [Out] IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCNIDIJKBCI(TInput CPOLINJHFNA, [Out] TOutput? KIBAOEBFCJF, [Out] IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface IGCNCJPPCDN
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	FDCDIDPOFEP<PNAMKNIHPME, BPKALIODDHJ> EBHFEGACIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	FDCDIDPOFEP<BPDLNDFDPGN, OFGIDLJOADK> HKKEPFLGENO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	PEPPNDHOCLG CIFIEJBCHEO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum GDOGMPPFIOA
{
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface ENBCGKAOKAE
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IOGCGGMGILL HLGBFIEHJDG(BPKALIODDHJ GGEMPJLCHFC);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface PEPPNDHOCLG
{
	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BPDLNDFDPGN HLGBFIEHJDG(BPKALIODDHJ GGEMPJLCHFC, int JHMIOGNAOMC, string? JHJFHDOAMLG, string? BCAJBLCMFDH, HBMANPGAFHF MIBABAGCHGL, List<PADBJIIHKJA>? BEJHDMKKOJE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[AOOPPFIKPBO]
internal class ELNEJAOKJHK : JKODDGLHDNJ<PNAMKNIHPME, BPKALIODDHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly HELFAHKGAEL PLPPFFGIMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private readonly OPCMGLGMHGL DMBLOILGCNO;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7700", Offset = "0x6CC6100", VA = "0x186CC7700")]
	public ELNEJAOKJHK(JJOKDGOELGN OIJGOCDMOGG, HELFAHKGAEL PLPPFFGIMJO, MKDIGONPDGF KDKHLEEPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7460", Offset = "0x6CC5E60", VA = "0x186CC7460", Slot = "6")]
	public override BPKALIODDHJ DLDAMIHNNNK(PNAMKNIHPME CPOLINJHFNA, [Out] IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class LFPJFBIOIKP : JJOKDGOELGN
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class LHDLBEDGIAK : JsonConverter<DLFPJNLHGPI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9320", Offset = "0x6CC7D20", VA = "0x186CC9320", Slot = "9")]
		public override void WriteJson(JsonWriter KPBMLLGEOOP, DLFPJNLHGPI? PKCLPFEIPFH, JsonSerializer AMJDPCEKLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9200", Offset = "0x6CC7C00", VA = "0x186CC9200", Slot = "10")]
		public override DLFPJNLHGPI ReadJson(JsonReader NIEHEDECLKP, Type OFKLGFNPKLA, DLFPJNLHGPI? GJOHENOJCPO, bool EFHIPBAKICM, JsonSerializer AMJDPCEKLNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6CC93C0", Offset = "0x6CC7DC0", VA = "0x186CC93C0")]
		public LHDLBEDGIAK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class BMNDMLAFEHA : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override bool MJHCCKGGEMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8F5BB0", Offset = "0x8F45B0", VA = "0x1808F5BB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4BA0", Offset = "0x6CC35A0", VA = "0x186CC4BA0", Slot = "5")]
		public override object ReadJson(JsonReader NIEHEDECLKP, Type OFKLGFNPKLA, object? GJOHENOJCPO, JsonSerializer AMJDPCEKLNF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6CC47E0", Offset = "0x6CC31E0", VA = "0x186CC47E0", Slot = "6")]
		public override bool CanConvert(Type OFKLGFNPKLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6CC4C00", Offset = "0x6CC3600", VA = "0x186CC4C00", Slot = "4")]
		public override void WriteJson(JsonWriter KPBMLLGEOOP, object? PKCLPFEIPFH, JsonSerializer AMJDPCEKLNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6CC49C0", Offset = "0x6CC33C0", VA = "0x186CC49C0")]
		private static bool DCAPDLKKNKE(object PKCLPFEIPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8D6960", Offset = "0x8D5360", VA = "0x1808D6960")]
		public BMNDMLAFEHA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private readonly JsonSerializerSettings KCHCEBPPDCA;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6CC90A0", Offset = "0x6CC7AA0", VA = "0x186CC90A0")]
	internal LFPJFBIOIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2FAE7E0", Offset = "0x2FAD1E0", VA = "0x182FAE7E0", Slot = "4")]
	public string JGBHJBHLCKD<T>(T BBNKFKDCOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2FAE840", Offset = "0x2FAD240", VA = "0x182FAE840", Slot = "5")]
	public T NIMMHFONBGM<T>(string PKCLPFEIPFH)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class MIMCPOELLIN : JJOKDGOELGN
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2FE07B0", Offset = "0x2FDF1B0", VA = "0x182FE07B0", Slot = "4")]
	public string JGBHJBHLCKD<T>(T BBNKFKDCOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2FE0830", Offset = "0x2FDF230", VA = "0x182FE0830", Slot = "5")]
	public T NIMMHFONBGM<T>(string PKCLPFEIPFH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
	public MIMCPOELLIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[AOOPPFIKPBO]
internal class OPCMGLGMHGL : JKODDGLHDNJ<BPDLNDFDPGN, OFGIDLJOADK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly JJOKDGOELGN OIJGOCDMOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly HELFAHKGAEL PLPPFFGIMJO;

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6CCBE20", Offset = "0x6CCA820", VA = "0x186CCBE20")]
	public OPCMGLGMHGL(JJOKDGOELGN OIJGOCDMOGG, HELFAHKGAEL PLPPFFGIMJO, MKDIGONPDGF KDKHLEEPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9A10", Offset = "0x6CC8410", VA = "0x186CC9A10", Slot = "6")]
	public override OFGIDLJOADK DLDAMIHNNNK(BPDLNDFDPGN CPOLINJHFNA, [Out] IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA6B0", Offset = "0x6CC90B0", VA = "0x186CCA6B0")]
	internal void GLLDICHLNMG(string LIMBEDADLNN, BPKALIODDHJ EMODBHKBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA810", Offset = "0x6CC9210", VA = "0x186CCA810")]
	public IEnumerable<BFDOKLKPGBD> HPIJNADKLDD(string LKPEKMAOMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB450", Offset = "0x6CC9E50", VA = "0x186CCB450")]
	private IEnumerable<BFDOKLKPGBD> OOEBHEJIEMF(string LKPEKMAOMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB870", Offset = "0x6CCA270", VA = "0x186CCB870")]
	internal IEnumerable<BFDOKLKPGBD> PJIBHDGDOBK(string LKPEKMAOMBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6CCADC0", Offset = "0x6CC97C0", VA = "0x186CCADC0")]
	private BFDOKLKPGBD JAHPOIIGPPL(AvatarOutfitSelectionData CFHIFGCHIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9E30", Offset = "0x6CC8830", VA = "0x186CC9E30")]
	private void EFHBEMBAOOO(AvatarCustomizationSettingsData KGDGGCOEHKI, BPKALIODDHJ EMODBHKBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB140", Offset = "0x6CC9B40", VA = "0x186CCB140")]
	private BFDOKLKPGBD JAHPOIIGPPL(string NMDENEPADFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6CCAAC0", Offset = "0x6CC94C0", VA = "0x186CCAAC0")]
	internal static (MMMGGPPGMJP, string, string) INBODIAOBNI(string NMDENEPADFF, MKDIGONPDGF KDKHLEEPODK)
	{
		return default((MMMGGPPGMJP, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA8C0", Offset = "0x6CC92C0", VA = "0x186CCA8C0")]
	private MGAEPMBOLCO? IKGKFPPHHND(string? MMGMNLELLKG, Vector2 IECLOFFBHJA, float EGIPEKJLBEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6CCBCC0", Offset = "0x6CCA6C0", VA = "0x186CCBCC0")]
	private static IJDPLHMEMPG POEDOOCOIMK(AvatarCustomizationSettingsData.AnchorParams DNNKGMFJIPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[AOOPPFIKPBO]
internal class KEJNPDFBEAE : DFPGGBGNFCL, ENBCGKAOKAE
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6B40", Offset = "0x6CC5540", VA = "0x186CC6B40")]
	public KEJNPDFBEAE(JJOKDGOELGN OIJGOCDMOGG, HELFAHKGAEL PLPPFFGIMJO, MKDIGONPDGF KDKHLEEPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8BF0", Offset = "0x6CC75F0", VA = "0x186CC8BF0", Slot = "4")]
	public IOGCGGMGILL HLGBFIEHJDG(BPKALIODDHJ GGEMPJLCHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8FA0", Offset = "0x6CC79A0", VA = "0x186CC8FA0")]
	private string NIMOJIKJDDP(BPKALIODDHJ EMODBHKBJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6CC89B0", Offset = "0x6CC73B0", VA = "0x186CC89B0")]
	private string EMCHNOMMJLA(BFDOKLKPGBD PLNPLECCJIC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[AOOPPFIKPBO]
internal class DAMEHINPJDD : JKODDGLHDNJ<BPDLNDFDPGN, OFGIDLJOADK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly JJOKDGOELGN OIJGOCDMOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly FDCDIDPOFEP<BPDLNDFDPGN, OFGIDLJOADK> LHIBHHJJAAL;

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6CC5110", Offset = "0x6CC3B10", VA = "0x186CC5110")]
	public DAMEHINPJDD(FDCDIDPOFEP<BPDLNDFDPGN, OFGIDLJOADK> LHIBHHJJAAL, MKDIGONPDGF KDKHLEEPODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4CE0", Offset = "0x6CC36E0", VA = "0x186CC4CE0", Slot = "6")]
	public override OFGIDLJOADK DLDAMIHNNNK(BPDLNDFDPGN CPOLINJHFNA, [Out] IReadOnlyList<PADBJIIHKJA>? BEJHDMKKOJE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[AOOPPFIKPBO]
internal class MJFIONNAEEN : PEPPNDHOCLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly JJOKDGOELGN OIJGOCDMOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly ENBCGKAOKAE JBKOOPEBLLC;

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6CC97A0", Offset = "0x6CC81A0", VA = "0x186CC97A0")]
	public MJFIONNAEEN(ENBCGKAOKAE JBKOOPEBLLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9400", Offset = "0x6CC7E00", VA = "0x186CC9400", Slot = "4")]
	public BPDLNDFDPGN HLGBFIEHJDG(BPKALIODDHJ GGEMPJLCHFC, int JHMIOGNAOMC, string? JHJFHDOAMLG, string? BCAJBLCMFDH, HBMANPGAFHF MIBABAGCHGL, List<PADBJIIHKJA>? BEJHDMKKOJE)
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
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2900", Offset = "0x6CC1300", VA = "0x186CC2900")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class FEAJCNFALFE
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC78D0", Offset = "0x6CC62D0", VA = "0x186CC78D0")]
	public static KPJKPOMJGHE DLDAMIHNNNK(this ENDFMMNOBMG GGEMPJLCHFC)
	{
		return default(KPJKPOMJGHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6CC79E0", Offset = "0x6CC63E0", VA = "0x186CC79E0")]
	public static ENDFMMNOBMG HLGBFIEHJDG(this KPJKPOMJGHE NGBNIFIABIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7B00", Offset = "0x6CC6500", VA = "0x186CC7B00")]
	public static bool LOPGLDBHCEH(this KPJKPOMJGHE NGBNIFIABIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7B60", Offset = "0x6CC6560", VA = "0x186CC7B60")]
	public static bool NPCNIHNJGDJ(this KPJKPOMJGHE NGBNIFIABIJ)
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
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x50A8C60", Offset = "0x50A7660", VA = "0x1850A8C60")]
			public AnchorParams(Vector2 EEEHNCAOKLP, Vector3 EFFDJLJEFNF, Vector3 OAKFOCGNLNL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6CC2850", Offset = "0x6CC1250", VA = "0x186CC2850")]
			internal IJDPLHMEMPG HLGBFIEHJDG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private EHJGPOKJPHL useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x6CC30F0", Offset = "0x6CC1AF0", VA = "0x186CC30F0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3FC3280", Offset = "0x3FC1C80", VA = "0x183FC3280")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA001E0", Offset = "0x9FEBE0", VA = "0x180A001E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAA7030", Offset = "0xAA5A30", VA = "0x180AA7030")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD30B10", Offset = "0xD2F510", VA = "0x180D30B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x8B00E0", Offset = "0x8AEAE0", VA = "0x1808B00E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3730", VA = "0x1808B4D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x6CC3190", Offset = "0x6CC1B90", VA = "0x186CC3190")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB20", Offset = "0x8AC520", VA = "0x1808ADB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xBB0090", Offset = "0xBAEA90", VA = "0x180BB0090")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x13E7A20", Offset = "0x13E6420", VA = "0x1813E7A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8B0160", Offset = "0x8AEB60", VA = "0x1808B0160")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x8B0120", Offset = "0x8AEB20", VA = "0x1808B0120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x6CC31D0", Offset = "0x6CC1BD0", VA = "0x186CC31D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x9DC420", Offset = "0x9DAE20", VA = "0x1809DC420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xBF08B0", Offset = "0xBEF2B0", VA = "0x180BF08B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x11DB1E0", Offset = "0x11D9BE0", VA = "0x1811DB1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8AB230", Offset = "0x8A9C30", VA = "0x1808AB230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8AB200", Offset = "0x8A9C00", VA = "0x1808AB200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x44BC3E0", Offset = "0x44BADE0", VA = "0x1844BC3E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA150D0", Offset = "0xA13AD0", VA = "0x180A150D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8E3260", Offset = "0x8E1C60", VA = "0x1808E3260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8E32C0", Offset = "0x8E1CC0", VA = "0x1808E32C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8B96F0", Offset = "0x8B80F0", VA = "0x1808B96F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8B9690", Offset = "0x8B8090", VA = "0x1808B9690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8B96A0", Offset = "0x8B80A0", VA = "0x1808B96A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8B96D0", Offset = "0x8B80D0", VA = "0x1808B96D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8B9770", Offset = "0x8B8170", VA = "0x1808B9770")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8B97E0", Offset = "0x8B81E0", VA = "0x1808B97E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x934310", Offset = "0x932D10", VA = "0x180934310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xE08460", Offset = "0xE06E60", VA = "0x180E08460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8B9840", Offset = "0x8B8240", VA = "0x1808B9840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8B9820", Offset = "0x8B8220", VA = "0x1808B9820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x9FF200", Offset = "0x9FDC00", VA = "0x1809FF200")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x9FF250", Offset = "0x9FDC50", VA = "0x1809FF250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8B69A0", Offset = "0x8B53A0", VA = "0x1808B69A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8B6910", Offset = "0x8B5310", VA = "0x1808B6910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9824B0", Offset = "0x980EB0", VA = "0x1809824B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xA0F4D0", Offset = "0xA0DED0", VA = "0x180A0F4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD32C50", Offset = "0xD31650", VA = "0x180D32C50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x106B450", Offset = "0x1069E50", VA = "0x18106B450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public EHJGPOKJPHL UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAAD1B0", Offset = "0xAABBB0", VA = "0x180AAD1B0")]
			get
			{
				return default(EHJGPOKJPHL);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xAACD90", Offset = "0xAAB790", VA = "0x180AACD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xAAB650", Offset = "0xAAA050", VA = "0x180AAB650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAAC7D0", Offset = "0xAAB1D0", VA = "0x180AAC7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x6CC31B0", Offset = "0x6CC1BB0", VA = "0x186CC31B0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x6CC31F0", Offset = "0x6CC1BF0", VA = "0x186CC31F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2D90", Offset = "0x6CC1790", VA = "0x186CC2D90")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public MMMGGPPGMJP BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private OHLBACBECAH? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6CC40C0", Offset = "0x6CC2AC0", VA = "0x186CC40C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
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
