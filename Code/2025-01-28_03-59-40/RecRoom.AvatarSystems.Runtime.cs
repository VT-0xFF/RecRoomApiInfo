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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x70EBF50", Offset = "0x70EB150", VA = "0x1870EBF50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70EBFD0", Offset = "0x70EB1D0", VA = "0x1870EBFD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[KHFOLODBECL]
internal class HILGECEOIHA : KHEDDDAOAMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct MCEPCFCBNMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public HILGECEOIHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public HCLDEAEBCAG avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly OKMNKIIHCEN EHDPDGMBKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DHNKOCPEDNN FFGOONBALIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LNIGABGJFDO ANBBDPIJFGL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x70EAF10", Offset = "0x70EA110", VA = "0x1870EAF10")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	[UsedImplicitly]
	internal static void HHBDFCKJHEK(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70EB010", Offset = "0x70EA210", VA = "0x1870EB010")]
	[RecRoom.NoEngine.Common.Preserve]
	internal HILGECEOIHA([FMJHJHHALCB(null)] OKMNKIIHCEN EHDPDGMBKCO, [FMJHJHHALCB(null)] DHNKOCPEDNN FFGOONBALIJ, [FMJHJHHALCB(null)] LNIGABGJFDO ANBBDPIJFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70E9C10", Offset = "0x70E8E10", VA = "0x1870E9C10", Slot = "5")]
	public FBHKJALFDHL EPECOAMIGPK(HCLDEAEBCAG EPMDONLDAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70EA3D0", Offset = "0x70E95D0", VA = "0x1870EA3D0", Slot = "4")]
	public FBHKJALFDHL FFENNOFJFLL(HCLDEAEBCAG EPMDONLDAKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x70E9B00", Offset = "0x70E8D00", VA = "0x1870E9B00", Slot = "6")]
	public EAPEJPICFLF ELFIEGEMJBC(FBHKJALFDHL LFDKFEEPNFP, int PPBIBKDPFPJ, string? LMOANCJLHKC, string? LDAALPHGCAJ, OAPBAHGKKDA LICPHCAMABI, List<GODGLDCALAM>? DIMPOPENGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70EAF80", Offset = "0x70EA180", VA = "0x1870EAF80", Slot = "7")]
	public bool LANJJGEDPAJ(NHLJMLCJJMC IJJKLLOJEBJ, [Out] FBHKJALFDHL? NAHENMKCODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70EAE30", Offset = "0x70EA030", VA = "0x1870EAE30", Slot = "8")]
	public bool FNJNEJHCPIG(EAPEJPICFLF FAJLOFBOFNB, [Out] FBHKJALFDHL? NAHENMKCODH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x70E96F0", Offset = "0x70E88F0", VA = "0x1870E96F0", Slot = "9")]
	public bool AEKAJIENPIM(EAPEJPICFLF FAJLOFBOFNB, [Out] LNHGELEJFDM? IJJKLLOJEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x32907A0", Offset = "0x328F9A0", VA = "0x1832907A0")]
	private bool NLLNCCPLHPC<TInput, TOutput>(TInput DFKGLBJBJGD, GAJMDHNHEDN<TInput, TOutput> FNMAJGPAFLK, [Out] TOutput? NJFLHCEDIDN) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x70E9780", Offset = "0x70E8980", VA = "0x1870E9780")]
	[CompilerGenerated]
	private JHNKMHNJONE BIEFOAFLAPE(FaceFeatureType NFDPMAHLOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x70E9920", Offset = "0x70E8B20", VA = "0x1870E9920")]
	[CompilerGenerated]
	private JHNKMHNJONE CDBPHFIOJAO(FaceFeatureType NFDPMAHLOIL, MCEPCFCBNMF P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[KHFOLODBECL]
internal class BAPEGICIKCK : OKMNKIIHCEN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void NAAOBBCALGP<in TData>(TData NAHENMKCODH, IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LNIGABGJFDO ANBBDPIJFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AMGPLCCFDEC OILOAKOCPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly NAAOBBCALGP<FBHKJALFDHL>?[] EHDPDGMBKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly NAAOBBCALGP<LNHGELEJFDM>?[] AIJGJDPPHEC;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70CEB60", Offset = "0x70CDD60", VA = "0x1870CEB60")]
	[UsedImplicitly]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	internal static void HHBDFCKJHEK(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x70CF870", Offset = "0x70CEA70", VA = "0x1870CF870")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BAPEGICIKCK([FMJHJHHALCB(null)] LNIGABGJFDO ANBBDPIJFGL, [FMJHJHHALCB(null)] AMGPLCCFDEC OILOAKOCPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70CEA30", Offset = "0x70CDC30", VA = "0x1870CEA30", Slot = "4")]
	public bool AHBCKHGCBCH(FBHKJALFDHL NAHENMKCODH, IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70CE8D0", Offset = "0x70CDAD0", VA = "0x1870CE8D0", Slot = "5")]
	public bool AHBCKHGCBCH(LNHGELEJFDM IJJKLLOJEBJ, IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70CEBD0", Offset = "0x70CDDD0", VA = "0x1870CEBD0")]
	private void MMNMJFBHLMN(FBHKJALFDHL NAHENMKCODH, IReadOnlyList<GODGLDCALAM>? PIEFIBOFCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70CF640", Offset = "0x70CE840", VA = "0x1870CF640")]
	private void OJGOJMAIHLM(FBHKJALFDHL NAHENMKCODH, IReadOnlyList<GODGLDCALAM>? PIEFIBOFCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70CF610", Offset = "0x70CE810", VA = "0x1870CF610")]
	private void NOPHLEEEIBJ(FBHKJALFDHL NAHENMKCODH, IReadOnlyList<GODGLDCALAM>? PIEFIBOFCOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x70CEB30", Offset = "0x70CDD30", VA = "0x1870CEB30")]
	private void ECNGABHAJFF(FBHKJALFDHL NAHENMKCODH, IReadOnlyList<GODGLDCALAM>? PIEFIBOFCOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface OKMNKIIHCEN
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AHBCKHGCBCH(FBHKJALFDHL NAHENMKCODH, IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AHBCKHGCBCH(LNHGELEJFDM IJJKLLOJEBJ, IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ);
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
		public EGCHKJAELMF AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x70CC460", Offset = "0x70CB660", VA = "0x1870CC460")]
		public void JPFIHBDFHCP(AnimationPoseSetting JAINJPLCLDO, float MBEFOJOFIAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70CC590", Offset = "0x70CB790", VA = "0x1870CC590")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x70CCEA0", Offset = "0x70CC0A0", VA = "0x1870CCEA0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70CCE60", Offset = "0x70CC060", VA = "0x1870CCE60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70CC5B0", Offset = "0x70CB7B0", VA = "0x1870CC5B0")]
		private void JNDJLJPGBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7066860", Offset = "0x7065A60", VA = "0x187066860", Slot = "4")]
		public void SetEnabled(bool MPKIENECBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x70CCED0", Offset = "0x70CC0D0", VA = "0x1870CCED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x70CCF10", Offset = "0x70CC110", VA = "0x1870CCF10")]
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
		[Cpp2IlInjected.Address(RVA = "0x70CCF50", Offset = "0x70CC150", VA = "0x1870CCF50")]
		public AnimationPoseSetting CLFJEAGCHNF(EGCHKJAELMF OMHALHCICMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x70CCF80", Offset = "0x70CC180", VA = "0x1870CCF80")]
		public void MDPAGNEJHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x70CCFC0", Offset = "0x70CC1C0", VA = "0x1870CCFC0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum PMKHKBFMIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[PJAPKCLJNLP(FFILGMALDDB.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private PMKHKBFMIJJ handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x70CDA90", Offset = "0x70CCC90", VA = "0x1870CDA90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x70CDA50", Offset = "0x70CCC50", VA = "0x1870CDA50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70CD430", Offset = "0x70CC630", VA = "0x1870CD430")]
		private void JNDJLJPGBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7066860", Offset = "0x7065A60", VA = "0x187066860", Slot = "4")]
		public void SetEnabled(bool MPKIENECBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70CDAC0", Offset = "0x70CCCC0", VA = "0x1870CDAC0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, JKKPEPIGDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[Header("Configuration")]
		private HCLDEAEBCAG avatarBodyType;

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
		[PJAPKCLJNLP(FFILGMALDDB.SelfAndChildren, false, false, false)]
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
		private MPEMGFAABKO OPCAGPLJOEO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MPEMGFAABKO PGCHBFJDOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x98B240", Offset = "0x98A440", VA = "0x18098B240", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform KMFNFBJKPCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x70CE8B0", Offset = "0x70CDAB0", VA = "0x1870CE8B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x70CDAF0", Offset = "0x70CCCF0", VA = "0x1870CDAF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x70CE770", Offset = "0x70CD970", VA = "0x1870CE770")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70CE720", Offset = "0x70CD920", VA = "0x1870CE720")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x70CE6B0", Offset = "0x70CD8B0", VA = "0x1870CE6B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x70CDAF0", Offset = "0x70CCCF0", VA = "0x1870CDAF0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x70CDE80", Offset = "0x70CD080", VA = "0x1870CDE80", Slot = "6")]
		public MPEMGFAABKO CreateAvatarSystem(string COBHAONNJDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x70CE6B0", Offset = "0x70CD8B0", VA = "0x1870CE6B0", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x70CDBB0", Offset = "0x70CCDB0", VA = "0x1870CDBB0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70CE7C0", Offset = "0x70CD9C0", VA = "0x1870CE7C0", Slot = "9")]
		public void UpdatePostIKAnimControllers(float NIMHBLEHMBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class CLODILMCKIC : MPEMGFAABKO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class LNCOKLLFHNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3 OOGAPDLHGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Quaternion OLDNIOAOKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 AEFEGKPMHGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Transform DGCBADHOEGO;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 OELPPAKDGDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x1C697F0", Offset = "0x1C689F0", VA = "0x181C697F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x1C69810", Offset = "0x1C68A10", VA = "0x181C69810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion EAMHMAEAKMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x1155A40", Offset = "0x1154C40", VA = "0x181155A40")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x1155A30", Offset = "0x1154C30", VA = "0x181155A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float MELCGFIEJIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xED58B0", Offset = "0xED4AB0", VA = "0x180ED58B0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x14E05A0", Offset = "0x14DF7A0", VA = "0x1814E05A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool JKBNMNGHIPP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x901960", Offset = "0x900B60", VA = "0x180901960")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x901970", Offset = "0x900B70", VA = "0x180901970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool GMBKGPFIGLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x901A60", Offset = "0x900C60", VA = "0x180901A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x901950", Offset = "0x900B50", VA = "0x180901950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IEOLFBBKCBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x901B20", Offset = "0x900D20", VA = "0x180901B20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x901990", Offset = "0x900B90", VA = "0x180901990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float MBGDKPCFHED
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xB24E30", Offset = "0xB24030", VA = "0x180B24E30")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB25A50", Offset = "0xB24C50", VA = "0x180B25A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x70EB4E0", Offset = "0x70EA6E0", VA = "0x1870EB4E0")]
		public void KLGMBMEJMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x70EBF30", Offset = "0x70EB130", VA = "0x1870EBF30")]
		public void PHMOMBBKBJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x70EB4F0", Offset = "0x70EA6F0", VA = "0x1870EB4F0")]
		public float KMLNMCBGDHE(Vector3 JJGLHFIFMEG, Quaternion JLDJAJCGJMJ, [In] AvatarFootSettings OAKKKEBGFCK, float DOHBNPPNIJL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x70EB850", Offset = "0x70EAA50", VA = "0x1870EB850")]
		public void PBNCCJLJHPB(Vector3 CHGBDDJLEFH, Quaternion KFKAEEACNDF, Transform KPHKDHNGBKH, float IJIHKEKKJMA, bool LKOLKGPJBKJ, bool JHHFFKOJFHP, float JDCCMNMEGPE, float PMLHOBHKDLI, Transform DONMCNODAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x70EB2B0", Offset = "0x70EA4B0", VA = "0x1870EB2B0")]
		public void KFCAMEHNELB(Transform EHCGFINPDHO, Transform DONMCNODAED, bool NFEHKDLKHOP, bool JKLPMFGJJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x70EB1B0", Offset = "0x70EA3B0", VA = "0x1870EB1B0")]
		private void DDOCDADFFCN(Transform DONMCNODAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x70EB700", Offset = "0x70EA900", VA = "0x1870EB700")]
		public void LDPKPJJALHB(Transform DONMCNODAED, AvatarFullBodyConfiguration LFKGAGFDDEM, Vector3 EMMMBKCPBHO, float KDGCKPIJPLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x70EB190", Offset = "0x70EA390", VA = "0x1870EB190")]
		public void AKHFOILEIIG(float PMLHOBHKDLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x70EBF40", Offset = "0x70EB140", VA = "0x1870EBF40")]
		public LNCOKLLFHNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class OLBNGJNMEFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float KKOAMGHMOED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private bool AAEFEJIOPBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AnimationPoseSetting PFBEPGOCAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private float CHDLGDLDFAF;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x70F5730", Offset = "0x70F4930", VA = "0x1870F5730")]
		public void FOEHDEMGKHB(IKSolverVR.Arm EAOBIPOIPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x70F5760", Offset = "0x70F4960", VA = "0x1870F5760")]
		public void GFJJBAIJHNH(IKSolverVR.Arm EAOBIPOIPNJ, float CDLFIPODNKJ, bool AAEFEJIOPBA, AvatarFullBodyConfiguration LFKGAGFDDEM, float JDOEILPOGPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x70F5DA0", Offset = "0x70F4FA0", VA = "0x1870F5DA0")]
		private void JDLJKFEDNNE(IKSolverVR.Arm EAOBIPOIPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x70F5F20", Offset = "0x70F5120", VA = "0x1870F5F20")]
		public void PODBOAKMJIC(IKSolverVR.Arm EAOBIPOIPNJ, Transform FMEDLPCKKNE, Transform KPHKDHNGBKH, Quaternion PNOPHPJLMCK, Vector3 CJMAELKAPOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x70F52A0", Offset = "0x70F44A0", VA = "0x1870F52A0")]
		private (Vector3, Quaternion) FKHFOAINPJH(KMCLCBCHDNC DFDIAEEMKLN, Quaternion LBGAJMIDELJ, Vector3 LLEENBEAKPM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x70F5140", Offset = "0x70F4340", VA = "0x1870F5140")]
		public void FALIKAECIEA(KMCLCBCHDNC DFDIAEEMKLN, IKSolverVR.Arm EAOBIPOIPNJ, Quaternion LBGAJMIDELJ, Vector3 LLEENBEAKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x70F57A0", Offset = "0x70F49A0", VA = "0x1870F57A0")]
		public void IHLLFOJDDKG(KMCLCBCHDNC DFDIAEEMKLN, IKSolverVR.Arm EAOBIPOIPNJ, Quaternion LBGAJMIDELJ, Vector3 LLEENBEAKPM, [In] AvatarFullBodyConfiguration LFKGAGFDDEM, [In] HNEODDMKAKI ONNLPKDFGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x70F5DE0", Offset = "0x70F4FE0", VA = "0x1870F5DE0")]
		public void OCMJEKBACBG(EGCHKJAELMF EKCMACHHNON, AvatarFullBodyConfiguration LFKGAGFDDEM, HNEODDMKAKI ONNLPKDFGPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x70F4CA0", Offset = "0x70F3EA0", VA = "0x1870F4CA0")]
		public void BNFFNLMBEPF(IKSolverVR.Arm EAOBIPOIPNJ, Transform FMEDLPCKKNE, Vector3 JDPEOHLFJMG, float GPLMDFLLPHN, Quaternion OEJLEINKHCO, Vector3 PIBOGHFNEJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x70F6300", Offset = "0x70F5500", VA = "0x1870F6300")]
		public OLBNGJNMEFB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum EJKAHLABIOI
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
	private struct CIDDMHKPEOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct EBGDCOEOMMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static readonly int LJEHKHDHIJC;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int LFCOIJDIKAO;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int KGDOGCFEBLG;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int APDAEJDKGPN;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int AGMFBMHPIOD;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int PGMHPGFKJOJ;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int EJAMDMOHKJO;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int AEEKDBBLHIM;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int ECECHNCPCKE;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int PBJCCPAJONM;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int PDKIAPEMOMF;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int MDOMHEILJPH;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int FCBKGGPOLDP;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int IDDJMOLFHFN;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int PGDIKAPHCGF;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int BPOIHBOJDKM;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int OOEJMCDIMNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int GBJMBECDLFL;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int DHHLDLLFHDE;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int MCCGJHGMDND;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int ONEMGPGIPKJ;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int DBNIMCHHNKI;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int CNEBCKDDNKH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int KDMGFJFAGHE;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int OMNOCFPCBPA;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int DLEKCJIELDH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int AJMLJPEFMEO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int ODPDCPEPLGJ;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int NMPDNHLPKOL;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int MOCJMDJGFMD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int LEEIEBJEMDM;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly Vector3 AJGICDKBOPJ;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int OAKDFOIICAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool GKFJEIILJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool CHJDLMFIHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool IGEPPNIHFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool MMNEHDINJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool NLLODPGLBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool LLAOEHHJIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Vector3 JHKOEKMDMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private string IFAGHNHAJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private AKLJIDLPBLJ? OIENPBDDPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private MOCEELKAFBB? BKFPKGBMHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private CHJEEJMPODN NPCKLMBMOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private LJLAFOEIIPL NDPBCFNJMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private KMCLCBCHDNC BMMDIMPJKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private KMCLCBCHDNC APJOHHDOMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool OLJAKDDEMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool KIFCBACENOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly MBNLKOBKMGH OLDIPAAFIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly CHCBJGMEFDK OGPCGNFOMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private int FPDNKNEIEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private float FKANBIEHCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GameObject KKMKGIMNIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Transform PBCKNJMLDFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform BMGJNHONIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform AFAAOIOOGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform EEMAPBPKOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private float MBIMONMEBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float OHEKOEGNOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private Vector3 HJMBCOFHNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Quaternion LJMFMCBMIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Transform NGJDAFPNPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform GKDJIFJMAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform IMIMEGBGLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private NGNEKLDBAHH GHIFDFNGLIG;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static readonly ProfilerMarker KDEMJGBAJFI;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker GGIADHHOHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ProfilerMarker IMLAEOONLFK;

	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private static readonly ProfilerMarker JEOBHIFILGO;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker MBFFLJOBBEC;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker DFCBMNCOMLL;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly List<CLODILMCKIC> COEGAIBAHND;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static int GECEGFPGOAD;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> LOLELNJFKJO;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static int AEEJHLLGKGO;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int KEKBDBCLBDI;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int LIICNLBDDOH;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int PKAPDNJNBPK;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static float MFJCFKNKCKF;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static int HIHOKEJOILF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static float CMGFDCCEALF;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float IMCKDCHPHND;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float BCEMEJDGHMN;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float KJCECLPALFP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static OLNKGMMMPGN GAFEDNHLDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private float GGPOKMONHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private bool CCCNHOAKNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private float BEMGKJGKNDE;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly int FOHAHKLPMNN;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly int MBKCPBELPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private LNCOKLLFHNL INCKFGMDHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private LNCOKLLFHNL EDCHFPMPNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private float LPPLJHEDGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private Vector3 BFOPMJGJJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Vector3 LDJOFAJAECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private bool AHFMDBGOFAI;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static readonly Quaternion BKMNPMLBEAA;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly Quaternion HHCAIJJCOOA;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly Vector3 NONPOHKBDNL;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Vector3 MPGBJKFMMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float EJEPIKKEALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float JLDBJMOOAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private OLBNGJNMEFB ABKOOCEALJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private OLBNGJNMEFB MLEEGGHHHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private GFOPAGFMICP JHJKCBLHENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private BJLPKCGECIO BBGNGFIALLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly NODIFDHGKDC BKIIOEGBPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float JGJKMKHDHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float MIHOEJFPMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly BJLPKCGECIO MKOJMIJFJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private Vector3 BIFOAMEPMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 MFIJKENAENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float FDLOJMOLFHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float CKKLNLBMLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly BJLPKCGECIO DDBDFHJNNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly GFOPAGFMICP KDCCIKFFJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly BJLPKCGECIO OHBJGHGOMKE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public AEJLNDNFINA NBCEDEKGOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AEJLNDNFINA HDKIKFCFJJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration DMDDNICMBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x70DE2B0", Offset = "0x70DD4B0", VA = "0x1870DE2B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HCLDEAEBCAG ILJHJDAPGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x70CFFA0", Offset = "0x70CF1A0", VA = "0x1870CFFA0", Slot = "23")]
		get
		{
			return default(HCLDEAEBCAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration KKFHEGONEMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x70D0680", Offset = "0x70CF880", VA = "0x1870D0680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform EICPFNGGDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x70E3020", Offset = "0x70E2220", VA = "0x1870E3020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform CDEMMINADLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x70D3DF0", Offset = "0x70D2FF0", VA = "0x1870D3DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer AHPKGOIIIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x70D1710", Offset = "0x70D0910", VA = "0x1870D1710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] JAFGMADDPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x70D9C80", Offset = "0x70D8E80", VA = "0x1870D9C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] OKOLBOLEIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x70DF230", Offset = "0x70DE430", VA = "0x1870DF230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator LGODBKCJGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x70DCAF0", Offset = "0x70DBCF0", VA = "0x1870DCAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK LKCLKCNPLBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x70E2F20", Offset = "0x70E2120", VA = "0x1870E2F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private IJPCFPJKLKA ENIPBLNHPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x70DD0B0", Offset = "0x70DC2B0", VA = "0x1870DD0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private IJPCFPJKLKA NCJDJMBEAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x70E25B0", Offset = "0x70E17B0", VA = "0x1870E25B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private IJPCFPJKLKA MMLIHONBBBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70D0F40", Offset = "0x70D0140", VA = "0x1870D0F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private IJPCFPJKLKA NHMKLDHOJJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x70D0B50", Offset = "0x70CFD50", VA = "0x1870D0B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private IJPCFPJKLKA JFOJHGLOFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x70DF330", Offset = "0x70DE530", VA = "0x1870DF330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private IJPCFPJKLKA AEJFOKCMGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x70E11A0", Offset = "0x70E03A0", VA = "0x1870E11A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private IJPCFPJKLKA FJEGNGOBIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x70DB210", Offset = "0x70DA410", VA = "0x1870DB210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private IJPCFPJKLKA JBOCFBFNGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x70D13C0", Offset = "0x70D05C0", VA = "0x1870D13C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MOCEELKAFBB EEHMOJIIOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x70D8040", Offset = "0x70D7240", VA = "0x1870D8040", Slot = "15")]
		get
		{
			return default(MOCEELKAFBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NMHKDIBMOMB HHDBNCMIBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xC70B30", Offset = "0xC6FD30", VA = "0x180C70B30", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public GJBMEOPCGOD NLGFBNIBHNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC70BC0", Offset = "0xC6FDC0", VA = "0x180C70BC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GNMICAIAGAB MGLKMEPCKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E380", Offset = "0x1B9D580", VA = "0x181B9E380", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GNMICAIAGAB EJEPJAMKBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E370", Offset = "0x1B9D570", VA = "0x181B9E370", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string DGGCAOPIPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform KJBFBHKKLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x70E1CE0", Offset = "0x70E0EE0", VA = "0x1870E1CE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform NPBBJIBPGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x70D5A90", Offset = "0x70D4C90", VA = "0x1870D5A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform JJFLNCBGJPA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x70DFCE0", Offset = "0x70DEEE0", VA = "0x1870DFCE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform HBCIKGPKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x70D6EB0", Offset = "0x70D60B0", VA = "0x1870D6EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform LAOLLJEMILL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x70D6E70", Offset = "0x70D6070", VA = "0x1870D6E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool LNFPKCJDIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x70DB420", Offset = "0x70DA620", VA = "0x1870DB420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool GJCABNMHLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70DB420", Offset = "0x70DA620", VA = "0x1870DB420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Transform GNLEFFPHMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x70D10E0", Offset = "0x70D02E0", VA = "0x1870D10E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GameObject GBMEGJCINPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x70D1040", Offset = "0x70D0240", VA = "0x1870D1040", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HeadLogicOffsets LONNIOLPHJG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x70DE920", Offset = "0x70DDB20", VA = "0x1870DE920", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform DCMNDHPJAOO
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1142B40", Offset = "0x1141D40", VA = "0x181142B40", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform NDHNOCOMKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1CC2810", Offset = "0x1CC1A10", VA = "0x181CC2810", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform FEHCKLNNFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB793F0", Offset = "0xB785F0", VA = "0x180B793F0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform KGPNMNDNFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x19AA7D0", Offset = "0x19A99D0", VA = "0x1819AA7D0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 DMDINHFKEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x70CFF10", Offset = "0x70CF110", VA = "0x1870CFF10", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float KDOPPOHCJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x70D9B50", Offset = "0x70D8D50", VA = "0x1870D9B50", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform DLACDECNMEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x70DD4A0", Offset = "0x70DC6A0", VA = "0x1870DD4A0", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform LDBEFNBCPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FEFF90", Offset = "0x1FEF190", VA = "0x181FEFF90", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform MEMLAJNHFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1FEFF80", Offset = "0x1FEF180", VA = "0x181FEFF80", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform MLJGIKJHHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19AB3A0", Offset = "0x19AA5A0", VA = "0x1819AB3A0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool NINEOGLGBGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x70D4C90", Offset = "0x70D3E90", VA = "0x1870D4C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool OCEIDBGDMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x70D3C10", Offset = "0x70D2E10", VA = "0x1870D3C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool BKIHJHBAHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x70DB190", Offset = "0x70DA390", VA = "0x1870DB190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x70E4760", Offset = "0x70E3960", VA = "0x1870E4760")]
	private void OPEBGDKLPOP([In] HNEODDMKAKI MNNCCMKFEDK, [In] AvatarFullBodyConfiguration LFKGAGFDDEM, bool PBLKICPMOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x70D3D60", Offset = "0x70D2F60", VA = "0x1870D3D60")]
	private float DGCDCDEDHNK([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x70D8170", Offset = "0x70D7370", VA = "0x1870D8170")]
	private float FOIPGNHOHMA([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x70E2AC0", Offset = "0x70E1CC0", VA = "0x1870E2AC0")]
	private void OEOGFIGNMKO(HNEODDMKAKI MNNCCMKFEDK, AvatarFullBodyConfiguration LFKGAGFDDEM, bool PBLKICPMOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x70E0FE0", Offset = "0x70E01E0", VA = "0x1870E0FE0")]
	private void MLLEEKJPLFD([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70D1610", Offset = "0x70D0810", VA = "0x1870D1610")]
	private void BNFCLGFNJFF([In] HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x70E9240", Offset = "0x70E8440", VA = "0x1870E9240")]
	public CLODILMCKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x70E1450", Offset = "0x70E0650", VA = "0x1870E1450", Slot = "12")]
	public void NBJPANMMJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x70D9740", Offset = "0x70D8940", VA = "0x1870D9740", Slot = "13")]
	public void GHNNCEBIPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x70E82F0", Offset = "0x70E74F0", VA = "0x1870E82F0", Slot = "14")]
	public void PCHMKLAGNAO(bool HLCLADEABKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x70D14C0", Offset = "0x70D06C0", VA = "0x1870D14C0", Slot = "25")]
	public Transform BKAOHMGFGGL(string OJGJBMBMAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70DB470", Offset = "0x70DA670", VA = "0x1870DB470", Slot = "26")]
	public Vector3? HLOBMFCINOJ(string OJGJBMBMAND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x70DA160", Offset = "0x70D9360", VA = "0x1870DA160", Slot = "7")]
	public void HBLPFHOJKEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x70E0BA0", Offset = "0x70DFDA0", VA = "0x1870E0BA0")]
	private void MHCEMPNIOHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x70E38E0", Offset = "0x70E2AE0", VA = "0x1870E38E0")]
	private Vector3 ONHECGBHOBG([In] HNEODDMKAKI ONNLPKDFGPA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x70DBC40", Offset = "0x70DAE40", VA = "0x1870DBC40", Slot = "6")]
	public void HPFDIDBCCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x70E83E0", Offset = "0x70E75E0", VA = "0x1870E83E0", Slot = "8")]
	public void PKHAEBDCCOA(float FDCPKHJKFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x70D9B00", Offset = "0x70D8D00", VA = "0x1870D9B00")]
	private void GKMGDNJHGJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x70E6160", Offset = "0x70E5360", VA = "0x1870E6160", Slot = "4")]
	public void PBDOFLECJHJ(string COBHAONNJDN, AKLJIDLPBLJ GAMIHICGGJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x70D55F0", Offset = "0x70D47F0", VA = "0x1870D55F0", Slot = "5")]
	public void EKEHOGHCHLB(MOCEELKAFBB NGECGPFBHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x70D87A0", Offset = "0x70D79A0", VA = "0x1870D87A0", Slot = "11")]
	public void GCHNAMMDBNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x70E26B0", Offset = "0x70E18B0", VA = "0x1870E26B0", Slot = "24")]
	public void OBLONNEHFLC([Out] Vector3 IKNNEMGFFIF, [Out] Quaternion OEJLEINKHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x70E2A90", Offset = "0x70E1C90", VA = "0x1870E2A90")]
	private void ODNCGJGHFOH([In] HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x70DA150", Offset = "0x70D9350", VA = "0x1870DA150", Slot = "27")]
	public void HBCCLAAHMKA(float PAGKOMNJKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x70E00E0", Offset = "0x70DF2E0", VA = "0x1870E00E0", Slot = "28")]
	public void LLOONNBNJFN(float KGNLOIODJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70E8450", Offset = "0x70E7650", VA = "0x1870E8450", Slot = "44")]
	public void PLPPBBFPBJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70E82A0", Offset = "0x70E74A0", VA = "0x1870E82A0", Slot = "29")]
	public void PCGMPPOBPPN(bool PMNNCFALDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x70DE8D0", Offset = "0x70DDAD0", VA = "0x1870DE8D0", Slot = "30")]
	public HandLogicOffsets JEFINHNBEOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x70E0020", Offset = "0x70DF220", VA = "0x1870E0020", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets LADJMCIDPMP()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x70DFEA0", Offset = "0x70DF0A0", VA = "0x1870DFEA0")]
	private void KMMAGCEMGNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x70DCC70", Offset = "0x70DBE70", VA = "0x1870DCC70")]
	private void IBNPOLJJHHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x70D0C50", Offset = "0x70CFE50", VA = "0x1870D0C50")]
	private void BEIMIFAAHKD(ELOCKNMGHMD HOFMDPNAKPK, bool OAPIJHCEDGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x70DFD10", Offset = "0x70DEF10", VA = "0x1870DFD10")]
	private void KKPOPIBDCPA(ELOCKNMGHMD HOFMDPNAKPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x70E2A40", Offset = "0x70E1C40", VA = "0x1870E2A40")]
	public Vector3 OBMFNKFGANL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x70D3900", Offset = "0x70D2B00", VA = "0x1870D3900")]
	private void CJPIKBBFMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x70E83C0", Offset = "0x70E75C0", VA = "0x1870E83C0")]
	private void PJMMOOLMBEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x70E1D30", Offset = "0x70E0F30", VA = "0x1870E1D30")]
	private void NNBMANICPKO(HNEODDMKAKI MNNCCMKFEDK, AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x70E12A0", Offset = "0x70E04A0", VA = "0x1870E12A0")]
	private float MNLENCHKPLI([In] HNEODDMKAKI ONNLPKDFGPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x70D9BA0", Offset = "0x70D8DA0", VA = "0x1870D9BA0")]
	private int GMDCIDPKJKP([In] ABFOEHHCHEP OONPGEGFAGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x70D0140", Offset = "0x70CF340", VA = "0x1870D0140")]
	private void AGLPAPOEGLI(HNEODDMKAKI MNNCCMKFEDK, bool DPBCLBJANLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x70D6560", Offset = "0x70D5760", VA = "0x1870D6560")]
	private static void FFBELIBOONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x70DD580", Offset = "0x70DC780", VA = "0x1870DD580")]
	private static void ILHPCPPKMLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x70D11E0", Offset = "0x70D03E0", VA = "0x1870D11E0")]
	private float BIGGFJHFICI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x70E6130", Offset = "0x70E5330", VA = "0x1870E6130")]
	private static int PAJPJELICFL(CLODILMCKIC LFOFDHEGDLC, CLODILMCKIC KMPLOMOLJCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x70D95D0", Offset = "0x70D87D0", VA = "0x1870D95D0", Slot = "40")]
	public HNEODDMKAKI GGLBEBAPJCP()
	{
		return default(HNEODDMKAKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x70DD500", Offset = "0x70DC700", VA = "0x1870DD500")]
	public void IJBGPOOMKBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x70D4A80", Offset = "0x70D3C80", VA = "0x1870D4A80")]
	private (bool, bool) DLBCHHLAHEA()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x70D93F0", Offset = "0x70D85F0", VA = "0x1870D93F0")]
	private (float, float) GFJBAHCEPOL([In] HNEODDMKAKI ONNLPKDFGPA)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x70D19D0", Offset = "0x70D0BD0", VA = "0x1870D19D0")]
	private void CCGMCEKMNNB([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x70E3A60", Offset = "0x70E2C60", VA = "0x1870E3A60")]
	private void OOAAJGEGJDP([In] HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x70DC6D0", Offset = "0x70DB8D0", VA = "0x1870DC6D0")]
	private void HPFHIDIHDMO([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM, AvatarFootSettings OAKKKEBGFCK, bool KIAMMMCAELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x70DCBF0", Offset = "0x70DBDF0", VA = "0x1870DCBF0")]
	private float IAPHJOFDCEM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x70D3EF0", Offset = "0x70D30F0", VA = "0x1870D3EF0")]
	private void DKECDBLPIHJ(HNEODDMKAKI ONNLPKDFGPA, AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x70D3BC0", Offset = "0x70D2DC0", VA = "0x1870D3BC0")]
	private float COPNIEHMNNJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70D3440", Offset = "0x70D2640", VA = "0x1870D3440")]
	private void CGDMHFOEKPA([In] HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x70E84A0", Offset = "0x70E76A0", VA = "0x1870E84A0")]
	private void PODBOAKMJIC([In] HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x70D81F0", Offset = "0x70D73F0", VA = "0x1870D81F0")]
	private void FPFOEDPHPIB([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x70DD1B0", Offset = "0x70DC3B0", VA = "0x1870DD1B0")]
	private void ICBIAJLJFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x70DB610", Offset = "0x70DA810", VA = "0x1870DB610")]
	private void HNAEAOOCPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x70E0E40", Offset = "0x70E0040", VA = "0x1870E0E40")]
	private void MLGMBFEJFPJ([In] HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x70DE9A0", Offset = "0x70DDBA0", VA = "0x1870DE9A0")]
	private void KBAIGGGIGBE(KMCLCBCHDNC BMECJHKIIHA, IKSolverVR.Arm EAOBIPOIPNJ, Transform ALAEPOMNOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x70D8890", Offset = "0x70D7A90", VA = "0x1870D8890")]
	private void GDIHIFEBHDC(HNEODDMKAKI ONNLPKDFGPA, AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x70E0920", Offset = "0x70DFB20", VA = "0x1870E0920")]
	private void MDOJIJEFCJB(CLIDDKPFEMJ LMFJNNFNBGF, GNMICAIAGAB BMECJHKIIHA, IKSolverVR.Arm EAOBIPOIPNJ, float CDLFIPODNKJ, float GKENJPFDEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x70DEC30", Offset = "0x70DDE30", VA = "0x1870DEC30")]
	private void KDKHHJOBKEP([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x70D9D80", Offset = "0x70D8F80", VA = "0x1870D9D80")]
	protected void GPNJNPCOKAE([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x70DE3B0", Offset = "0x70DD5B0", VA = "0x1870DE3B0")]
	private void JCGNOAONGNE([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x70DE680", Offset = "0x70DD880", VA = "0x1870DE680")]
	protected void JDGJKNLNOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x70DA950", Offset = "0x70D9B50", VA = "0x1870DA950")]
	private void HCGAFDGGNPJ([In] HNEODDMKAKI ONNLPKDFGPA, [In] EJKAHLABIOI MNCNEMMKKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x70E0770", Offset = "0x70DF970", VA = "0x1870E0770")]
	private void MAMDJPDPNLL(HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x70DD460", Offset = "0x70DC660", VA = "0x1870DD460")]
	private void ICEMEPMDBCE([In] HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x70D50D0", Offset = "0x70D42D0", VA = "0x1870D50D0")]
	private Vector3 EHJOHEHNJFI([In] HNEODDMKAKI ONNLPKDFGPA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x70D3C90", Offset = "0x70D2E90", VA = "0x1870D3C90")]
	private void DFBONGCJLAC([In] HNEODDMKAKI ONNLPKDFGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x70D6EF0", Offset = "0x70D60F0", VA = "0x1870D6EF0")]
	private float FMELKHHHKMB(float PMLHOBHKDLI, [In] HNEODDMKAKI ONNLPKDFGPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x70D4F80", Offset = "0x70D4180", VA = "0x1870D4F80")]
	private void EDICELMLBGD(float PMLHOBHKDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x70D6780", Offset = "0x70D5980", VA = "0x1870D6780")]
	private void FFLBHPGKFID([In] HNEODDMKAKI ONNLPKDFGPA, EJKAHLABIOI MNCNEMMKKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x70E3120", Offset = "0x70E2320", VA = "0x1870E3120")]
	private float OMFOHPOJGCB([In] HNEODDMKAKI MNNCCMKFEDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x70D5D60", Offset = "0x70D4F60", VA = "0x1870D5D60")]
	private void FEPKIHKMMBI(HNEODDMKAKI ONNLPKDFGPA, EJKAHLABIOI MNCNEMMKKCH, Vector3 FBOBHFADKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x70D85F0", Offset = "0x70D77F0", VA = "0x1870D85F0")]
	private static void FPLCDKDFKEP(Transform MCPAEAAAAAM, Quaternion EGIHDGHICMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x70D7D40", Offset = "0x70D6F40", VA = "0x1870D7D40")]
	private void FOICOGFBDOF([In] HNEODDMKAKI GDMAJLLKNDI, [In] ABFOEHHCHEP OONPGEGFAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x70DF430", Offset = "0x70DE630", VA = "0x1870DF430")]
	private void KFGLAOMDCJJ([In] HNEODDMKAKI GDMAJLLKNDI, [In] ABFOEHHCHEP OONPGEGFAGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x70D4D90", Offset = "0x70D3F90", VA = "0x1870D4D90")]
	private void EBNDEMHPEJG(float NINOMLIAHIK, [In] HNEODDMKAKI MNNCCMKFEDK, float GKCOOBJGDHL = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x70D8C20", Offset = "0x70D7E20", VA = "0x1870D8C20")]
	private float GEFAKPKIBHK([In] HNEODDMKAKI MNNCCMKFEDK, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x70CFC20", Offset = "0x70CEE20", VA = "0x1870CFC20")]
	private void ACFHCEIEKLE([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x70E3D80", Offset = "0x70E2F80", VA = "0x1870E3D80")]
	private void OOJAJONFMFD([In] HNEODDMKAKI MNNCCMKFEDK, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x70DB870", Offset = "0x70DAA70", VA = "0x1870DB870")]
	private void HNKGDMPPCHL([In] HNEODDMKAKI MNNCCMKFEDK, float KBDNKCMKNLO, float LIKGDEHPKMB, Vector3 IIGFEEJHGJM, float GKCOOBJGDHL = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x70D7340", Offset = "0x70D6540", VA = "0x1870D7340")]
	private void FMHLCKJBGLH(HNEODDMKAKI MNNCCMKFEDK, AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x70D5AD0", Offset = "0x70D4CD0", VA = "0x1870D5AD0")]
	private void FDIBCKMFPNL(HNEODDMKAKI ONNLPKDFGPA, AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x70E0430", Offset = "0x70DF630", VA = "0x1870E0430")]
	private void MALGMMMDCDH(HNEODDMKAKI MNNCCMKFEDK, AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x70D1810", Offset = "0x70D0A10", VA = "0x1870D1810")]
	public void CBOAHHNHLGJ([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x70E1970", Offset = "0x70E0B70", VA = "0x1870E1970")]
	public void NJELDEOGEBH([In] HNEODDMKAKI ONNLPKDFGPA, [In] AvatarFullBodyConfiguration LFKGAGFDDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x70E0CA0", Offset = "0x70DFEA0", VA = "0x1870E0CA0")]
	[CompilerGenerated]
	internal static void MHKNGBEGFDM(Transform BGKIOALJNDJ, IKSolverVR.Arm EAOBIPOIPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x70E0AF0", Offset = "0x70DFCF0", VA = "0x1870E0AF0")]
	[CompilerGenerated]
	internal static void MEKPIIAJEFO(Vector3 LBOABHAHIGM, Vector3 ACIBKFABAOB, CIDDMHKPEOP P_2, EBGDCOEOMMO P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x70D00A0", Offset = "0x70CF2A0", VA = "0x1870D00A0")]
	[CompilerGenerated]
	internal static void AFIMENEKMFM(LNCOKLLFHNL FPBEFMHOBJN, LNCOKLLFHNL EMACFAOFIFJ, Vector3 CHDKNMJOPMA, float GILNIHGCEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x70DB310", Offset = "0x70DA510", VA = "0x1870DB310")]
	[CompilerGenerated]
	internal static bool HJEIPBJFNGB(IKSolverVR.Arm EAOBIPOIPNJ, GICFBEFHJDI DJNFEPPONBN, float IMDLHPKLELP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x70D0710", Offset = "0x70CF910", VA = "0x1870D0710")]
	[CompilerGenerated]
	internal static float BBKNEJOAGMP(Vector3 KFENHEIFBAP, Vector3 LKFOBJBIMHM, Vector3 PMMEOIGLELF, HNEODDMKAKI MNNCCMKFEDK, AvatarFullBodyConfiguration LFKGAGFDDEM, float KLICPJBJAIA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class MGEIEIOKOPM : ICKMHICLFFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Dictionary<string, MPEMGFAABKO> CJDNELDOGFE;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x70F3880", Offset = "0x70F2A80", VA = "0x1870F3880")]
	[NAOGKPPNIGE.PBOHCEMILCE]
	internal static void LOPEKMMEFKE(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x70F38F0", Offset = "0x70F2AF0", VA = "0x1870F38F0", Slot = "4")]
	public MPEMGFAABKO NPDGLEHJEPF(string EHNPCABBJBE, AvatarSystemConfiguration MOBHLLFMNFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x70F34F0", Offset = "0x70F26F0", VA = "0x1870F34F0", Slot = "5")]
	public void ABJLGACNIBC(string EHNPCABBJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x70F3740", Offset = "0x70F2940", VA = "0x1870F3740", Slot = "6")]
	public string EAHEJFPEMCA(string OIAPLDJJKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x70F36D0", Offset = "0x70F28D0", VA = "0x1870F36D0")]
	private string DPDEHCKCNNJ(string OIAPLDJJKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x70F3B10", Offset = "0x70F2D10", VA = "0x1870F3B10")]
	public MGEIEIOKOPM()
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
		public class HIPMNIMLOHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private Dictionary<string, Transform> AKHGDNMFCLE;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool PHKHHDPEMAG
			{
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x70F1E80", Offset = "0x70F1080", VA = "0x1870F1E80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x70F1D50", Offset = "0x70F0F50", VA = "0x1870F1D50")]
			public void DGPMDDPCEJD(VRIK BMECFEFGIDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80")]
			public void CLKLLCKJEPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x70F1EC0", Offset = "0x70F10C0", VA = "0x1870F1EC0")]
			public void OKECIINHNOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x70F1F10", Offset = "0x70F1110", VA = "0x1870F1F10")]
			public HIPMNIMLOHJ()
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
		[HMLBDBMBBPE(FFILGMALDDB.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[PJAPKCLJNLP(FFILGMALDDB.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly HIPMNIMLOHJ BMHAMMPLGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private JKKPEPIGDLC HCFGGMDLPLJ;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x70ECE60", Offset = "0x70EC060", VA = "0x1870ECE60")]
		private void GGPOBANFNOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x70ECE10", Offset = "0x70EC010", VA = "0x1870ECE10")]
		private bool FKNAAMMAEJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x70ED140", Offset = "0x70EC340", VA = "0x1870ED140")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x70ED1B0", Offset = "0x70EC3B0", VA = "0x1870ED1B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x70ED150", Offset = "0x70EC350", VA = "0x1870ED150")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x70ED420", Offset = "0x70EC620", VA = "0x1870ED420")]
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
				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x70F22E0", Offset = "0x70F14E0", VA = "0x1870F22E0")]
			public void MDPAGNEJHAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x70F21A0", Offset = "0x70F13A0", VA = "0x1870F21A0")]
			public (float, float) EECGLCFPIHM(Animator KJOKLMCCHHK, AnimatorStateInfo KGKOCKLKAOC)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
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

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x70F25D0", Offset = "0x70F17D0", VA = "0x1870F25D0")]
		public void MDPAGNEJHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x70F23C0", Offset = "0x70F15C0", VA = "0x1870F23C0")]
		public (float, float) HIFMFJDKFMB(Animator KJOKLMCCHHK)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x70F27C0", Offset = "0x70F19C0", VA = "0x1870F27C0")]
		private (float, float) NEDKAPLILAL(Animator KJOKLMCCHHK, AnimatorStateInfo KGKOCKLKAOC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x70F29B0", Offset = "0x70F1BB0", VA = "0x1870F29B0")]
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

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x70F4680", Offset = "0x70F3880", VA = "0x1870F4680", Slot = "4")]
		public override void OnStateEnter(Animator KJOKLMCCHHK, AnimatorStateInfo KGKOCKLKAOC, int FPPFBDMCDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x70F47F0", Offset = "0x70F39F0", VA = "0x1870F47F0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class MNIFBELEDEA<TInput, TOutput> : GAJMDHNHEDN<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	protected readonly AMGPLCCFDEC OILOAKOCPML;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4C20760", Offset = "0x4C1F960", VA = "0x184C20760")]
	protected MNIFBELEDEA(AMGPLCCFDEC OILOAKOCPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput LAEIJKNHIPI(TInput DFKGLBJBJGD, [Out] IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4C206C0", Offset = "0x4C1F8C0", VA = "0x184C206C0", Slot = "5")]
	public bool NLLNCCPLHPC(TInput DFKGLBJBJGD, [Out] TOutput? NJFLHCEDIDN, [Out] IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[KHFOLODBECL]
public static class MDNBEBGEIHN
{
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly Regex BOLOOAAGNFG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x70F30E0", Offset = "0x70F22E0", VA = "0x1870F30E0")]
	public static EKADBAOMFIK HAKEIGIANBF(KFNFGKAFGLE ICHGECIHFKM, FLOHLNJAHJB PAABMKMJICH, Guid? IKEAMEFDCGA, Color? EEHMAKLAHAM, IEPCDHHNEOA EFKLNALJCMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x70F32F0", Offset = "0x70F24F0", VA = "0x1870F32F0")]
	public static PFMDOPPHAKG OMDLKGBFONK(EKADBAOMFIK LFDKFEEPNFP)
	{
		return default(PFMDOPPHAKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x3367F80", Offset = "0x3367180", VA = "0x183367F80")]
	internal static TModern? MBIKBBEIJEI<TModern>(string? DFKGLBJBJGD, LNKDLEOEFBN<TModern> LNIMMLBLNFM, AMGPLCCFDEC OILOAKOCPML, MJNLKBLJKOF FODGIFPLING, TModern DDEPCMEAHNC) where TModern : struct, GHLPHAHIDFB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x33695D0", Offset = "0x33687D0", VA = "0x1833695D0")]
	internal static FBJBJFDAGDM ODOFFNNELNL<TModern>(string? DFKGLBJBJGD, LNKDLEOEFBN<TModern> LNIMMLBLNFM, AMGPLCCFDEC OILOAKOCPML, MJNLKBLJKOF FODGIFPLING, TModern DDEPCMEAHNC) where TModern : struct, GHLPHAHIDFB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x70F2F90", Offset = "0x70F2190", VA = "0x1870F2F90")]
	internal static List<GODGLDCALAM> GBCINPMLMEC(IEnumerable<BJCHGNGDFMH>? JKOIPJGHICF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3367100", Offset = "0x3366300", VA = "0x183367100")]
	internal static string GJEJMDELABF<TModern>(TModern DFKGLBJBJGD, LNKDLEOEFBN<TModern> LNIMMLBLNFM, AMGPLCCFDEC OILOAKOCPML) where TModern : GHLPHAHIDFB
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class IAPOCHGPAGB : DHNKOCPEDNN
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public GAJMDHNHEDN<NHLJMLCJJMC, FBHKJALFDHL> FEFINCBGMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GAJMDHNHEDN<EAPEJPICFLF, LNHGELEJFDM> KFGDJBNLODC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GAJMDHNHEDN<EAPEJPICFLF, LNHGELEJFDM> GFEKPLICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public OAFMAENLFAB MAMMMFODPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KLNEMNFJBDF IFCLLCMCJNH
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x70F29C0", Offset = "0x70F1BC0", VA = "0x1870F29C0")]
	[NAOGKPPNIGE.PBOHCEMILCE.MHACPCJGMLG]
	[UsedImplicitly]
	internal static void HHBDFCKJHEK(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x70F2A30", Offset = "0x70F1C30", VA = "0x1870F2A30")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IAPOCHGPAGB([FMJHJHHALCB("UnitySerialization")] PIIICNLPBKG EEAILOEJBNL, [FMJHJHHALCB(null)] CNMCLAGJJKN EMCCLPHOODL, [FMJHJHHALCB(null)] AMGPLCCFDEC OILOAKOCPML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum LECPACFBEPF
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
public class AAJFDLBAPIN : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x70EC370", Offset = "0x70EB570", VA = "0x1870EC370")]
	public AAJFDLBAPIN(string CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x70EC300", Offset = "0x70EB500", VA = "0x1870EC300")]
	public AAJFDLBAPIN(string CBCJFCINKPJ, Exception EKNOIMPALPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x70EC3A0", Offset = "0x70EB5A0", VA = "0x1870EC3A0")]
	public AAJFDLBAPIN(LECPACFBEPF PEEENJNCMNA, string CBCJFCINKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x70EC330", Offset = "0x70EB530", VA = "0x1870EC330")]
	public AAJFDLBAPIN(LECPACFBEPF PEEENJNCMNA, string CBCJFCINKPJ, Exception EKNOIMPALPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class GFENLPKBCLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private readonly PIIICNLPBKG EEAILOEJBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected readonly CNMCLAGJJKN EMCCLPHOODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly AMGPLCCFDEC OILOAKOCPML;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x70F1BD0", Offset = "0x70F0DD0", VA = "0x1870F1BD0")]
	protected GFENLPKBCLE(PIIICNLPBKG EEAILOEJBNL, CNMCLAGJJKN EMCCLPHOODL, AMGPLCCFDEC OILOAKOCPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x70F05A0", Offset = "0x70EF7A0", VA = "0x1870F05A0")]
	protected string MBEOFHJEJKA(FBHKJALFDHL NAHENMKCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x70F19F0", Offset = "0x70F0BF0", VA = "0x1870F19F0")]
	protected string NHAAEFKCAEO(FBHKJALFDHL NAHENMKCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x70F0270", Offset = "0x70EF470", VA = "0x1870F0270")]
	private AvatarOutfitSelectionData HAKEIGIANBF(EKADBAOMFIK CEEFADGLJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x70F18B0", Offset = "0x70F0AB0", VA = "0x1870F18B0")]
	private static AvatarCustomizationSettingsData.AnchorParams MBIGFKEBIJD(APGOBKHECLL? MNBEDLICCLG)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface GAJMDHNHEDN<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput LAEIJKNHIPI(TInput DFKGLBJBJGD, [Out] IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NLLNCCPLHPC(TInput DFKGLBJBJGD, [Out] TOutput? NJFLHCEDIDN, [Out] IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface DHNKOCPEDNN
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GAJMDHNHEDN<NHLJMLCJJMC, FBHKJALFDHL> FEFINCBGMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	GAJMDHNHEDN<EAPEJPICFLF, LNHGELEJFDM> GFEKPLICHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	OAFMAENLFAB MAMMMFODPPA
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum MJNLKBLJKOF
{
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface KLNEMNFJBDF
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EEAPEPCEJLH LKDLAIOBOFF(FBHKJALFDHL LFDKFEEPNFP);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface OAFMAENLFAB
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EAPEJPICFLF LKDLAIOBOFF(FBHKJALFDHL LFDKFEEPNFP, int PPBIBKDPFPJ, string? LMOANCJLHKC, string? LDAALPHGCAJ, OAPBAHGKKDA LICPHCAMABI, List<GODGLDCALAM>? DIMPOPENGMJ);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KHFOLODBECL]
internal class MJGAOCCLAMJ : MNIFBELEDEA<NHLJMLCJJMC, FBHKJALFDHL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly CNMCLAGJJKN EMCCLPHOODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly FDKJBNFAINP BPICMGOOJAM;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x70F3E50", Offset = "0x70F3050", VA = "0x1870F3E50")]
	public MJGAOCCLAMJ(PIIICNLPBKG EEAILOEJBNL, CNMCLAGJJKN EMCCLPHOODL, AMGPLCCFDEC OILOAKOCPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x70F3BA0", Offset = "0x70F2DA0", VA = "0x1870F3BA0", Slot = "6")]
	public override FBHKJALFDHL LAEIJKNHIPI(NHLJMLCJJMC DFKGLBJBJGD, [Out] IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class MJJDJFAOLDJ : PIIICNLPBKG
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class HPDKOCOHPEL : JsonConverter<FBJBJFDAGDM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x70F20C0", Offset = "0x70F12C0", VA = "0x1870F20C0", Slot = "9")]
		public override void WriteJson(JsonWriter JPECNBJOJNA, FBJBJFDAGDM? OMEFCJCOLII, JsonSerializer PDHMGKJMMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x70F1FA0", Offset = "0x70F11A0", VA = "0x1870F1FA0", Slot = "10")]
		public override FBJBJFDAGDM ReadJson(JsonReader NHPBIOODHLE, Type GJIPAHMPFDJ, FBJBJFDAGDM? NOPDOCHAACL, bool GBJIAKCLCDI, JsonSerializer PDHMGKJMMCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x70F2160", Offset = "0x70F1360", VA = "0x1870F2160")]
		public HPDKOCOHPEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class MNDCIBBHOII : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool MCIBMHMMKHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x70F4540", Offset = "0x70F3740", VA = "0x1870F4540", Slot = "5")]
		public override object ReadJson(JsonReader NHPBIOODHLE, Type GJIPAHMPFDJ, object? NOPDOCHAACL, JsonSerializer PDHMGKJMMCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x70F4180", Offset = "0x70F3380", VA = "0x1870F4180", Slot = "6")]
		public override bool CanConvert(Type GJIPAHMPFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x70F45A0", Offset = "0x70F37A0", VA = "0x1870F45A0", Slot = "4")]
		public override void WriteJson(JsonWriter JPECNBJOJNA, object? OMEFCJCOLII, JsonSerializer PDHMGKJMMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x70F4360", Offset = "0x70F3560", VA = "0x1870F4360")]
		private static bool IFIALCOCBGL(object OMEFCJCOLII)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
		public MNDCIBBHOII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly JsonSerializerSettings MAHNKJFCIBK;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x70F4020", Offset = "0x70F3220", VA = "0x1870F4020")]
	internal MJJDJFAOLDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x3372AC0", Offset = "0x3371CC0", VA = "0x183372AC0", Slot = "4")]
	public string LFILBHCPIGC<T>(T LCACGJDNDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3372A30", Offset = "0x3371C30", VA = "0x183372A30", Slot = "5")]
	public T IAAGAGGPKNN<T>(string OMEFCJCOLII)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class BNPPODGCNAM : PIIICNLPBKG
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x30584C0", Offset = "0x30576C0", VA = "0x1830584C0", Slot = "4")]
	public string LFILBHCPIGC<T>(T LCACGJDNDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3058440", Offset = "0x3057640", VA = "0x183058440", Slot = "5")]
	public T IAAGAGGPKNN<T>(string OMEFCJCOLII)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
	public BNPPODGCNAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[KHFOLODBECL]
internal class FDKJBNFAINP : MNIFBELEDEA<EAPEJPICFLF, LNHGELEJFDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly PIIICNLPBKG EEAILOEJBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly CNMCLAGJJKN EMCCLPHOODL;

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x70F0130", Offset = "0x70EF330", VA = "0x1870F0130")]
	public FDKJBNFAINP(PIIICNLPBKG EEAILOEJBNL, CNMCLAGJJKN EMCCLPHOODL, AMGPLCCFDEC OILOAKOCPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x70EF1F0", Offset = "0x70EE3F0", VA = "0x1870EF1F0", Slot = "6")]
	public override LNHGELEJFDM LAEIJKNHIPI(EAPEJPICFLF DFKGLBJBJGD, [Out] IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x70EF0A0", Offset = "0x70EE2A0", VA = "0x1870EF0A0")]
	internal void KNCAGFLNPHJ(string KCNKKOIALOO, FBHKJALFDHL NAHENMKCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x70EDCC0", Offset = "0x70ECEC0", VA = "0x1870EDCC0")]
	public IEnumerable<EKADBAOMFIK> BBJGNGCIIGM(string PJBCODEEPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x70EDF70", Offset = "0x70ED170", VA = "0x1870EDF70")]
	private IEnumerable<EKADBAOMFIK> CPBGLPPCDAF(string PJBCODEEPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x70EE390", Offset = "0x70ED590", VA = "0x1870EE390")]
	internal IEnumerable<EKADBAOMFIK> EGMLBPMPEHI(string PJBCODEEPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x70EF940", Offset = "0x70EEB40", VA = "0x1870EF940")]
	private EKADBAOMFIK LHIPKBBGIDA(AvatarOutfitSelectionData OOLOHOMCOAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x70EE800", Offset = "0x70EDA00", VA = "0x1870EE800")]
	private void GFLBFKLJFPF(AvatarCustomizationSettingsData MJOPKHIBELJ, FBHKJALFDHL NAHENMKCODH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x70EF620", Offset = "0x70EE820", VA = "0x1870EF620")]
	private EKADBAOMFIK LHIPKBBGIDA(string MJGLIKOOAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x70EFE30", Offset = "0x70EF030", VA = "0x1870EFE30")]
	internal static (IEPCDHHNEOA, string, string) NIGHHOLBBAA(string MJGLIKOOAFK, AMGPLCCFDEC OILOAKOCPML)
	{
		return default((IEPCDHHNEOA, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x70EDD70", Offset = "0x70ECF70", VA = "0x1870EDD70")]
	private JHNKMHNJONE? CCAJLFBJPLG(string? IBPGMNEANFH, Vector2 MCDAIILGGGD, float JAMGJHKONOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x70EFCD0", Offset = "0x70EEED0", VA = "0x1870EFCD0")]
	private static APGOBKHECLL MDMAODGDJBA(AvatarCustomizationSettingsData.AnchorParams MNDLMAHMEPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KHFOLODBECL]
internal class PEBMJAMGEPK : GFENLPKBCLE, KLNEMNFJBDF
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x70F1BD0", Offset = "0x70F0DD0", VA = "0x1870F1BD0")]
	public PEBMJAMGEPK(PIIICNLPBKG EEAILOEJBNL, CNMCLAGJJKN EMCCLPHOODL, AMGPLCCFDEC OILOAKOCPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x70F65C0", Offset = "0x70F57C0", VA = "0x1870F65C0", Slot = "4")]
	public EEAPEPCEJLH LKDLAIOBOFF(FBHKJALFDHL LFDKFEEPNFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x70F6970", Offset = "0x70F5B70", VA = "0x1870F6970")]
	private string LKLFGGHAODO(FBHKJALFDHL NAHENMKCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x70F6380", Offset = "0x70F5580", VA = "0x1870F6380")]
	private string IAAHMPDKJBA(EKADBAOMFIK CEEFADGLJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[KHFOLODBECL]
internal class DFNIKKKPHCE : MNIFBELEDEA<EAPEJPICFLF, LNHGELEJFDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly PIIICNLPBKG EEAILOEJBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly GAJMDHNHEDN<EAPEJPICFLF, LNHGELEJFDM> EGHHJLIFAGL;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x70ED930", Offset = "0x70ECB30", VA = "0x1870ED930")]
	public DFNIKKKPHCE(GAJMDHNHEDN<EAPEJPICFLF, LNHGELEJFDM> EGHHJLIFAGL, AMGPLCCFDEC OILOAKOCPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x70ED500", Offset = "0x70EC700", VA = "0x1870ED500", Slot = "6")]
	public override LNHGELEJFDM LAEIJKNHIPI(EAPEJPICFLF DFKGLBJBJGD, [Out] IReadOnlyList<GODGLDCALAM>? DIMPOPENGMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[KHFOLODBECL]
internal class NDEMGPPJEPO : OAFMAENLFAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly PIIICNLPBKG EEAILOEJBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly KLNEMNFJBDF KPONDFCBLBE;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x70F4BB0", Offset = "0x70F3DB0", VA = "0x1870F4BB0")]
	public NDEMGPPJEPO(KLNEMNFJBDF KPONDFCBLBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x70F4810", Offset = "0x70F3A10", VA = "0x1870F4810", Slot = "4")]
	public EAPEJPICFLF LKDLAIOBOFF(FBHKJALFDHL LFDKFEEPNFP, int PPBIBKDPFPJ, string? LMOANCJLHKC, string? LDAALPHGCAJ, OAPBAHGKKDA LICPHCAMABI, List<GODGLDCALAM>? DIMPOPENGMJ)
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

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x70EC480", Offset = "0x70EB680", VA = "0x1870EC480")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class EINCFOCNDHM
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x70EDA90", Offset = "0x70ECC90", VA = "0x1870EDA90")]
	public static PFMDOPPHAKG LAEIJKNHIPI(this KKPLIGJAFEH LFDKFEEPNFP)
	{
		return default(PFMDOPPHAKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x70EDBA0", Offset = "0x70ECDA0", VA = "0x1870EDBA0")]
	public static KKPLIGJAFEH LKDLAIOBOFF(this PFMDOPPHAKG HAFOMBGFBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x70EDA30", Offset = "0x70ECC30", VA = "0x1870EDA30")]
	public static bool BKEPIKICMPP(this PFMDOPPHAKG HAFOMBGFBDB)
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

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x5491430", Offset = "0x5490630", VA = "0x185491430")]
			public AnchorParams(Vector2 GNOFMOJODPJ, Vector3 IAFFDLONLJF, Vector3 ELFEKCNNJNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x70EC3D0", Offset = "0x70EB5D0", VA = "0x1870EC3D0")]
			internal APGOBKHECLL LKDLAIOBOFF()
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
		private LHLBFAAIMNN useHelmetHair;

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
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x70ECCB0", Offset = "0x70EBEB0", VA = "0x1870ECCB0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8F7590", Offset = "0x8F6790", VA = "0x1808F7590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4834B40", Offset = "0x4833D40", VA = "0x184834B40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xB508B0", Offset = "0xB4FAB0", VA = "0x180B508B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xD67E50", Offset = "0xD67050", VA = "0x180D67E50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x1028400", Offset = "0x1027600", VA = "0x181028400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D40", Offset = "0x8F3F40", VA = "0x1808F4D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x70ECD60", Offset = "0x70EBF60", VA = "0x1870ECD60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x8FD6E0", Offset = "0x8FC8E0", VA = "0x1808FD6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAA2980", Offset = "0xAA1B80", VA = "0x180AA2980")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAA2820", Offset = "0xAA1A20", VA = "0x180AA2820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8F9240", Offset = "0x8F8440", VA = "0x1808F9240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x70ECDA0", Offset = "0x70EBFA0", VA = "0x1870ECDA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xCC4CE0", Offset = "0xCC3EE0", VA = "0x180CC4CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xED5870", Offset = "0xED4A70", VA = "0x180ED5870")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x1503E20", Offset = "0x1503020", VA = "0x181503E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8F21E0", Offset = "0x8F13E0", VA = "0x1808F21E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8F2230", Offset = "0x8F1430", VA = "0x1808F2230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x1F7BE30", Offset = "0x1F7B030", VA = "0x181F7BE30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xCDE5D0", Offset = "0xCDD7D0", VA = "0x180CDE5D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x929DE0", Offset = "0x928FE0", VA = "0x180929DE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x929E40", Offset = "0x929040", VA = "0x180929E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8F9230", Offset = "0x8F8430", VA = "0x1808F9230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8F9270", Offset = "0x8F8470", VA = "0x1808F9270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8F91E0", Offset = "0x8F83E0", VA = "0x1808F91E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8F92A0", Offset = "0x8F84A0", VA = "0x1808F92A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8F91C0", Offset = "0x8F83C0", VA = "0x1808F91C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8F9280", Offset = "0x8F8480", VA = "0x1808F9280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA8A360", Offset = "0xA89560", VA = "0x180A8A360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x110FBD0", Offset = "0x110EDD0", VA = "0x18110FBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8F9260", Offset = "0x8F8460", VA = "0x1808F9260")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8F9210", Offset = "0x8F8410", VA = "0x1808F9210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xB79F30", Offset = "0xB79130", VA = "0x180B79F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xCEA770", Offset = "0xCE9970", VA = "0x180CEA770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8F7850", Offset = "0x8F6A50", VA = "0x1808F7850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8F7890", Offset = "0x8F6A90", VA = "0x1808F7890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xAB89E0", Offset = "0xAB7BE0", VA = "0x180AB89E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xCF3C60", Offset = "0xCF2E60", VA = "0x180CF3C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xB31240", Offset = "0xB30440", VA = "0x180B31240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB2CD00", Offset = "0xB2BF00", VA = "0x180B2CD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public LHLBFAAIMNN UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xD6C5C0", Offset = "0xD6B7C0", VA = "0x180D6C5C0")]
			get
			{
				return default(LHLBFAAIMNN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xD6D9F0", Offset = "0xD6CBF0", VA = "0x180D6D9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xD6DA90", Offset = "0xD6CC90", VA = "0x180D6DA90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA75E70", Offset = "0xA75070", VA = "0x180A75E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x70ECD80", Offset = "0x70EBF80", VA = "0x1870ECD80")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x70ECDC0", Offset = "0x70EBFC0", VA = "0x1870ECDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x70EC910", Offset = "0x70EBB10", VA = "0x1870EC910")]
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

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
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
		public IEPCDHHNEOA BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private AMGFKNBBJGP? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x70ECDE0", Offset = "0x70EBFE0", VA = "0x1870ECDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
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

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
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
