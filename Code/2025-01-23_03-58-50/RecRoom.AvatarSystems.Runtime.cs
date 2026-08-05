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
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DFEF40", Offset = "0x6DFD740", VA = "0x186DFEF40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B60", Offset = "0x8DF360", VA = "0x1808E0B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E0BA0", Offset = "0x8DF3A0", VA = "0x1808E0BA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1AE60", Offset = "0x6E19660", VA = "0x186E1AE60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21F3FE0", Offset = "0x21F27E0", VA = "0x1821F3FE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CEOCIAMIFJE]
internal class PBNABNHBDMI : CJOPPJDMMFO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NJCBFGHOOLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public PBNABNHBDMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public HBPDIAMDKLD avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EEFNMCFJKNG CCCIJFMJODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BFGPGIJBIKL PBGNFLCECPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NDMPBFFEDNH BEILDPMHMND;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF9B0", Offset = "0x6DFE1B0", VA = "0x186DFF9B0")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	[UsedImplicitly]
	internal static void HJHPAAGEIBP(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E008E0", Offset = "0x6DFF0E0", VA = "0x186E008E0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal PBNABNHBDMI([NDCFMLCHJCI(null)] EEFNMCFJKNG CCCIJFMJODL, [NDCFMLCHJCI(null)] BFGPGIJBIKL PBGNFLCECPK, [NDCFMLCHJCI(null)] NDMPBFFEDNH BEILDPMHMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF160", Offset = "0x6DFD960", VA = "0x186DFF160", Slot = "5")]
	public KCALCFCCDIJ GKHIHDCKCDH(HBPDIAMDKLD OAFFOKJEIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DFFC00", Offset = "0x6DFE400", VA = "0x186DFFC00", Slot = "4")]
	public KCALCFCCDIJ JOFPEONFOBI(HBPDIAMDKLD OAFFOKJEIOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF050", Offset = "0x6DFD850", VA = "0x186DFF050", Slot = "6")]
	public EPDCEENGFDC EOPCHGEICMO(KCALCFCCDIJ EBNFOODJNOB, int LKLDCOOMHLD, string? IKMKCMDHFDC, string? GNGHPLAJKAH, GINPKJDPNDP EJEAMKBKGJE, List<BHGOKAEJDGO>? BACGEPDOHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DFEFC0", Offset = "0x6DFD7C0", VA = "0x186DFEFC0", Slot = "7")]
	public bool AKHJIHNKDFE(EDBLHKFFKED FLNMMIHJAAF, [Out] KCALCFCCDIJ? BKGPNGLOPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E00660", Offset = "0x6DFEE60", VA = "0x186E00660", Slot = "8")]
	public bool JPNHFPOHKBJ(EPDCEENGFDC BAPOGHIPIHH, [Out] KCALCFCCDIJ? BKGPNGLOPKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF920", Offset = "0x6DFE120", VA = "0x186DFF920", Slot = "9")]
	public bool HIPKIGJFMNJ(EPDCEENGFDC BAPOGHIPIHH, [Out] MJBMEIHOHNJ? FLNMMIHJAAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3222490", Offset = "0x3220C90", VA = "0x183222490")]
	private bool FCFGOGINCPF<TInput, TOutput>(TInput AOJEAJGBMCP, IEKFNCCHIIA<TInput, TOutput> IFNKDKDJFEL, [Out] TOutput? HANDIANDCDI) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E00740", Offset = "0x6DFEF40", VA = "0x186E00740")]
	[CompilerGenerated]
	private NNFIHCFOBOK PHBKMMAFDFB(FaceFeatureType CMGPKDBAHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DFFA20", Offset = "0x6DFE220", VA = "0x186DFFA20")]
	[CompilerGenerated]
	private NNFIHCFOBOK IIANCKPPGDL(FaceFeatureType CMGPKDBAHKP, NJCBFGHOOLB P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[CEOCIAMIFJE]
internal class AFONOCBDJDK : EEFNMCFJKNG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void PIDKKDGFIBJ<in TData>(TData BKGPNGLOPKN, IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NDMPBFFEDNH BEILDPMHMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HPEADDKCNII DIBOKBALCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PIDKKDGFIBJ<KCALCFCCDIJ>?[] CCCIJFMJODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PIDKKDGFIBJ<MJBMEIHOHNJ>?[] LOOLHEINPCH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DFBA30", Offset = "0x6DFA230", VA = "0x186DFBA30")]
	[UsedImplicitly]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	internal static void HJHPAAGEIBP(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DFC710", Offset = "0x6DFAF10", VA = "0x186DFC710")]
	[RecRoom.NoEngine.Common.Preserve]
	internal AFONOCBDJDK([NDCFMLCHJCI(null)] NDMPBFFEDNH BEILDPMHMND, [NDCFMLCHJCI(null)] HPEADDKCNII DIBOKBALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DFB900", Offset = "0x6DFA100", VA = "0x186DFB900", Slot = "4")]
	public bool GEPJBIHNBGK(KCALCFCCDIJ BKGPNGLOPKN, IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6DFB7A0", Offset = "0x6DF9FA0", VA = "0x186DFB7A0", Slot = "5")]
	public bool GEPJBIHNBGK(MJBMEIHOHNJ FLNMMIHJAAF, IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DFBCD0", Offset = "0x6DFA4D0", VA = "0x186DFBCD0")]
	private void KEPDHNNBEKE(KCALCFCCDIJ BKGPNGLOPKN, IReadOnlyList<BHGOKAEJDGO>? FNGOEBINDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DFBAA0", Offset = "0x6DFA2A0", VA = "0x186DFBAA0")]
	private void IFOJBOBMNPL(KCALCFCCDIJ BKGPNGLOPKN, IReadOnlyList<BHGOKAEJDGO>? FNGOEBINDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DFBA00", Offset = "0x6DFA200", VA = "0x186DFBA00")]
	private void GPMCOOHGKPG(KCALCFCCDIJ BKGPNGLOPKN, IReadOnlyList<BHGOKAEJDGO>? FNGOEBINDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DFB770", Offset = "0x6DF9F70", VA = "0x186DFB770")]
	private void BDJJLIMIPHE(KCALCFCCDIJ BKGPNGLOPKN, IReadOnlyList<BHGOKAEJDGO>? FNGOEBINDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface EEFNMCFJKNG
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GEPJBIHNBGK(KCALCFCCDIJ BKGPNGLOPKN, IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEPJBIHNBGK(MJBMEIHOHNJ FLNMMIHJAAF, IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD);
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
		public GNNPAMCNOIL AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x6DFCAC0", Offset = "0x6DFB2C0", VA = "0x186DFCAC0")]
		public void BABFEEKAOGD(AnimationPoseSetting LIHCAHPMPHD, float OGHJFNDKHGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCBF0", Offset = "0x6DFB3F0", VA = "0x186DFCBF0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x6DFD500", Offset = "0x6DFBD00", VA = "0x186DFD500")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD4C0", Offset = "0x6DFBCC0", VA = "0x186DFD4C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6DFCC10", Offset = "0x6DFB410", VA = "0x186DFCC10")]
		private void JBMGIOBAIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D96F60", Offset = "0x6D95760", VA = "0x186D96F60", Slot = "4")]
		public void SetEnabled(bool KDHIKINJBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD530", Offset = "0x6DFBD30", VA = "0x186DFD530")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DFD570", Offset = "0x6DFBD70", VA = "0x186DFD570")]
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
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
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
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
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
		[Header("Foot Pinning")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
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
		[Header("Shoe Settings")]
		[Tooltip("Local offset from pelvis to foot center")]
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

		[Cpp2IlInjected.FieldOffset(Offset = "0x47C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("Default angle of the foot bone as seen in idle")]
		public float FootRestAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x480")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("Amount of movement applied to the hips based on head offset")]
		public AnimationCurve HipBalanceCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x488")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Constant scalar for the hip balance curve")]
		public float HipBalanceFactor;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD5F0", Offset = "0x6DFBDF0", VA = "0x186DFD5F0")]
		public AnimationPoseSetting OMIIAPAJODF(GNNPAMCNOIL AGEPGLPOLKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD5B0", Offset = "0x6DFBDB0", VA = "0x186DFD5B0")]
		public void LDJJIOLOFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6DFD620", Offset = "0x6DFBE20", VA = "0x186DFD620")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum IFIIAEAFIBM
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[AEOOJFCMMHH(CPHBAPBBNNI.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private IFIIAEAFIBM handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE100", Offset = "0x6DFC900", VA = "0x186DFE100")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE0C0", Offset = "0x6DFC8C0", VA = "0x186DFE0C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DFDAA0", Offset = "0x6DFC2A0", VA = "0x186DFDAA0")]
		private void JBMGIOBAIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D96F60", Offset = "0x6D95760", VA = "0x186D96F60", Slot = "4")]
		public void SetEnabled(bool KDHIKINJBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE130", Offset = "0x6DFC930", VA = "0x186DFE130")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, MACODCFJMGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Header("Configuration")]
		[SerializeField]
		private HBPDIAMDKLD avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		[AEOOJFCMMHH(CPHBAPBBNNI.SelfAndChildren, false, false, false)]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Header("Facial Animation")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		[Header("Watch")]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private Transform LeftHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private Transform RightHandWristMenuAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Header("Equipment Slots")]
		[SerializeField]
		private Transform ShoulderSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Transform LeftHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private Transform RightHipSlotAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private HHHOAOPGIDI DLAOFOBEBIJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HHHOAOPGIDI DGOIMDLHNCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9DB300", Offset = "0x9D9B00", VA = "0x1809DB300", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform OMHIIPPFPBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6DFEF20", Offset = "0x6DFD720", VA = "0x186DFEF20", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE160", Offset = "0x6DFC960", VA = "0x186DFE160")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6DFEDE0", Offset = "0x6DFD5E0", VA = "0x186DFEDE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6DFED90", Offset = "0x6DFD590", VA = "0x186DFED90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6DFED20", Offset = "0x6DFD520", VA = "0x186DFED20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE160", Offset = "0x6DFC960", VA = "0x186DFE160", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE4F0", Offset = "0x6DFCCF0", VA = "0x186DFE4F0", Slot = "6")]
		public HHHOAOPGIDI CreateAvatarSystem(string DGMCFNCHLMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DFED20", Offset = "0x6DFD520", VA = "0x186DFED20", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DFE220", Offset = "0x6DFCA20", VA = "0x186DFE220", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6DFEE30", Offset = "0x6DFD630", VA = "0x186DFEE30", Slot = "9")]
		public void UpdatePostIKAnimControllers(float HKMEEJMCKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class PFHGLMNICIP : HHHOAOPGIDI
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class KMKBDGGMAOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Vector3 IADBCHENANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Quaternion IKDAHKHNOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Vector3 LMEDHIKCDAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private Transform IJMNNDPLJEN;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 MPMLMCKIPFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x18EC8A0", Offset = "0x18EB0A0", VA = "0x1818EC8A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x18EC8C0", Offset = "0x18EB0C0", VA = "0x1818EC8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion KMOHLPIHHGG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xF00990", Offset = "0xEFF190", VA = "0x180F00990")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xF009D0", Offset = "0xEFF1D0", VA = "0x180F009D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float IIHLEEAGPFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xC73400", Offset = "0xC71C00", VA = "0x180C73400")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x1257850", Offset = "0x1256050", VA = "0x181257850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool BMJNNIGMHAH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8BD190", Offset = "0x8BB990", VA = "0x1808BD190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8BD210", Offset = "0x8BBA10", VA = "0x1808BD210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool ADHEGEAJADJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1F0", Offset = "0x8BB9F0", VA = "0x1808BD1F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1B0", Offset = "0x8BB9B0", VA = "0x1808BD1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool NJPNLODNDKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BBB70", VA = "0x1808BD370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8BD1A0", Offset = "0x8BB9A0", VA = "0x1808BD1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float NKBJECEICNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xC73420", Offset = "0xC71C20", VA = "0x180C73420")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x2191ED0", Offset = "0x21906D0", VA = "0x182191ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6E23FA0", Offset = "0x6E227A0", VA = "0x186E23FA0")]
		public void PLKHCHCGFIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6E23740", Offset = "0x6E21F40", VA = "0x186E23740")]
		public void JFIOKIFIEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6E23530", Offset = "0x6E21D30", VA = "0x186E23530")]
		public float DEJFBFDAHBK(Vector3 CKHAPICOHOK, Quaternion JAKOMPJFINE, [In] AvatarFootSettings JHPOOLIKCNC, float GFFHFMNOIEJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E23750", Offset = "0x6E21F50", VA = "0x186E23750")]
		public void KGLLMAFBCEE(Vector3 OMDCJPMCILL, Quaternion FHEFMFEDBDM, Transform PILJGNKFIBO, float FAIPPLDOBGG, bool CEOHGLNOPKL, bool DMMCPDOPLBI, float NLDNOFDMJIG, float FJFPANHFACF, Transform KAMAKIBPPKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6E23200", Offset = "0x6E21A00", VA = "0x186E23200")]
		public void CMMIJBFFIOP(Transform GEMLKJCDPIN, Transform KAMAKIBPPKG, bool FNGLDODLJNC, bool PMBDPFFMOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E23430", Offset = "0x6E21C30", VA = "0x186E23430")]
		private void DCFOANIIIGE(Transform KAMAKIBPPKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6E23E50", Offset = "0x6E22650", VA = "0x186E23E50")]
		public void NFPGCFCNONL(Transform KAMAKIBPPKG, AvatarFullBodyConfiguration MEGJMJCJPOE, Vector3 EBMDKHPMCAE, float LAIFNEBOFHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6E23E30", Offset = "0x6E22630", VA = "0x186E23E30")]
		public void LCHFNPDHKLC(float FJFPANHFACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6E23FB0", Offset = "0x6E227B0", VA = "0x186E23FB0")]
		public KMKBDGGMAOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private class OKDEJBLDMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private float KHBPEMPICDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private bool FCDFLOKIDJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AnimationPoseSetting PMGEFODIFMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private float FGKPCOEGKFG;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6E259B0", Offset = "0x6E241B0", VA = "0x186E259B0")]
		public void GHEBEAHNCJF(IKSolverVR.Arm CKDOBICDGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E25DC0", Offset = "0x6E245C0", VA = "0x186E25DC0")]
		public void ICALJMEGMBB(IKSolverVR.Arm CKDOBICDGJL, float CKIJGEGKEPE, bool FCDFLOKIDJE, AvatarFullBodyConfiguration MEGJMJCJPOE, float KJOMHGBFMLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E260A0", Offset = "0x6E248A0", VA = "0x186E260A0")]
		private void PJNIHDJBPFA(IKSolverVR.Arm CKDOBICDGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6E259E0", Offset = "0x6E241E0", VA = "0x186E259E0")]
		public void GPILDBNAJBF(IKSolverVR.Arm CKDOBICDGJL, Transform DAKIPOFKIFO, Transform PILJGNKFIBO, Quaternion OCNIIOJCKIC, Vector3 ADGJBEBNLHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6E24F20", Offset = "0x6E23720", VA = "0x186E24F20")]
		private (Vector3, Quaternion) EALKHKBDDPJ(PLLMCEELJMF FNNPHBIKCAG, Quaternion NPJIHDFNCHB, Vector3 BPEHJDPGIJJ)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E25F40", Offset = "0x6E24740", VA = "0x186E25F40")]
		public void NGJJCKFAFAO(PLLMCEELJMF FNNPHBIKCAG, IKSolverVR.Arm CKDOBICDGJL, Quaternion NPJIHDFNCHB, Vector3 BPEHJDPGIJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E253B0", Offset = "0x6E23BB0", VA = "0x186E253B0")]
		public void FJOKJCENJME(PLLMCEELJMF FNNPHBIKCAG, IKSolverVR.Arm CKDOBICDGJL, Quaternion NPJIHDFNCHB, Vector3 BPEHJDPGIJJ, [In] AvatarFullBodyConfiguration MEGJMJCJPOE, [In] IOOAEAENOEL LCFHGACCKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E25E00", Offset = "0x6E24600", VA = "0x186E25E00")]
		public void NGBOEKDEKOE(GNNPAMCNOIL FIIFGIBHNCG, AvatarFullBodyConfiguration MEGJMJCJPOE, IOOAEAENOEL LCFHGACCKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6E24A80", Offset = "0x6E23280", VA = "0x186E24A80")]
		public void DCFMIDOCHML(IKSolverVR.Arm CKDOBICDGJL, Transform DAKIPOFKIFO, Vector3 JJJJDCGLJAB, float CIAFBBFLMNL, Quaternion KCNOANPBOIE, Vector3 PMFAIOGKLCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6E260E0", Offset = "0x6E248E0", VA = "0x186E260E0")]
		public OKDEJBLDMHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum MNGOBAFALHE
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		ForceSnapIntoPlace
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LFFJJOFMIML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct HIMJJFDABON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int KPCAGFNNHAH;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int OIIJPJGDFJF;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int LCKHAPCBIDG;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int DCAKMCDMKMD;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int GLDFEKPHOJJ;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int IAEEHGLCOEF;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int BLICHAFEDHK;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly int CDFIIFLEGLP;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly int HGCMIHMKNNM;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int FJBIAKICBIG;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int PIJDCKHEBID;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int ICJGOMDILEK;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int CNFIIJEFENL;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int AOPGKNIMMPF;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int JIHBCCMKFBF;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int IGHEAFFIEGA;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int MAMNDLPJALN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int NIMEBGBLPHJ;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JCOEFBNDFBN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int IBGGIIMHGBB;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int ECNGNGELFKD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int NMFIJFEKKCA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int PCNLDDFNHBC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int GDOGJALEAFA;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int LABKIFNOGLE;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int PANLMLEGKNL;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int AFIBINNPLIN;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int ODGDCBOIEEI;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int KANGHPOEFPE;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int NHEIJCGABKI;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int BEPPEKOEPMG;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly Vector3 JNEELCMCAGL;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int BOLGECODFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool PJNFNFKDEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private bool MHMJDJLMKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool OPJNFCEDFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool IAMMPFGANDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool EHHGJALFKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private bool IOAAFIJDDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Vector3 OHCLPNMJILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private string EFKAFFBBLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private CBOPDGCOOKF? BAOPFPHMOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private PHOFPDIJLGI? HOMBEEHPBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NJFHCIPENBA DCBCHEGIMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private OJLMAKMHOOO DLLKENEPOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private PLLMCEELJMF DHEKPGMBODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private PLLMCEELJMF KECGAGFEGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool CINJOCINAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x279")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool MLDKNHHFFII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly AHHJNLIDFMF BKKOLNEEHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly EAJBHICCFFF HGFLFAHEOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int CMDHLMHMKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private float LPFALIJKKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private GameObject DOHAFBNJLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private Transform GFHLNCOKEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Transform EAMDJCEAPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private Transform AOCLMDBNHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private Transform BMFFLBKOEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private float GLGEMJJHPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private float KGOOMAPCKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private Vector3 MEOOJEMIJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Quaternion GAGDMNFLAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Transform DFHILODNPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private Transform KPBGKGCMAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform NIOPCCNEMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private CDGPIDHAIDC GJJKBOCGKFO;

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private static readonly ProfilerMarker GLHKOOGHBGJ;

	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private static readonly ProfilerMarker CKBLEHJAMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private ProfilerMarker IKEFPLHJJBP;

	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private static readonly ProfilerMarker BIONDOADCMO;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly ProfilerMarker LPIMOPOJBPI;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly ProfilerMarker MGHFPDBHOBN;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly List<PFHGLMNICIP> NDJHBMMKNKL;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static int EKGHOILEOCI;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> DGJIMENIFAN;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static int DCBNDNNGBHB;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static int BLFNGJBKDNE;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static int PLOOCPAGMCC;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static int EEIIOLHMCLE;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static float HHFMMFDKJFC;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static int CNBPLGLACIK;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static float JKPDJOICKEE;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static float JCLOOCBBADK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static float AELODNJPIHE;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static float LINCLHOELOF;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static KFHMIICIHGF PCDKJANOIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private float EBMBEAGBBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private bool IODJPBKCPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private float NCIGKBHCOBH;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly int CMMFPJKAHJF;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly int LDMLCCDKBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private KMKBDGGMAOF KEPJKMJMMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private KMKBDGGMAOF NAEGMFFJLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private float INLGJOGKAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private Vector3 DDKIHEMGHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private Vector3 KJAKGNMCCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool MNBNBNNMGBI;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static readonly Quaternion DCBLHPCKPNM;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly Quaternion HIMLKGPDJPK;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly Vector3 GGOAHNKGKGB;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly Vector3 JCLAEPKHIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private float DJJPDLDMEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private float NLBCANNNJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private OKDEJBLDMHE DKMBCDDLOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private OKDEJBLDMHE PACCOMEFGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private FJEOFMCAAGB OBKBLOFCLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private MMJPKFCJAPH HMODAKMNPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly LDIKCILGFGF DAFPCLKIOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private float LCKNHFBEEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x384")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private float MNFMLAFOHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly MMJPKFCJAPH CLFONADLFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private Vector3 FFMGKLLOPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x39C")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private Vector3 ACCDCNDFEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float BMPDJMFIMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3AC")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float ANELMELFOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly MMJPKFCJAPH FMDDMADNNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly FJEOFMCAAGB MOGMGDEEDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly MMJPKFCJAPH KAONMEKFGGP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GCOJJNPJFGN EJJCLIHPPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GCOJJNPJFGN OOJFDENCLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration DFOBANNLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6E04000", Offset = "0x6E02800", VA = "0x186E04000", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HBPDIAMDKLD GEODLHLDENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E19090", Offset = "0x6E17890", VA = "0x186E19090", Slot = "23")]
		get
		{
			return default(HBPDIAMDKLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration ALKIEBJEILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E10F20", Offset = "0x6E0F720", VA = "0x186E10F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform OMDMMKMMBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6E033C0", Offset = "0x6E01BC0", VA = "0x186E033C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform MBNHGBLDGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6E08AA0", Offset = "0x6E072A0", VA = "0x186E08AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer MBIADPBEAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6E04E30", Offset = "0x6E03630", VA = "0x186E04E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] DOCKDABBCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C150", Offset = "0x6E0A950", VA = "0x186E0C150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] MBNAGHDBMDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E03240", Offset = "0x6E01A40", VA = "0x186E03240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator EILBDLAKMON
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E12F30", Offset = "0x6E11730", VA = "0x186E12F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK DGBBBJACOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E08C10", Offset = "0x6E07410", VA = "0x186E08C10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private HMPFKGKOKMN CPBPJMPLHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0C4A0", Offset = "0x6E0ACA0", VA = "0x186E0C4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private HMPFKGKOKMN AMKLMPIEMJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6E13FC0", Offset = "0x6E127C0", VA = "0x186E13FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private HMPFKGKOKMN NBKCKIOAJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6E044D0", Offset = "0x6E02CD0", VA = "0x186E044D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private HMPFKGKOKMN PBJNHAMOEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6E122C0", Offset = "0x6E10AC0", VA = "0x186E122C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private HMPFKGKOKMN PAPCEJGGEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F190", Offset = "0x6E0D990", VA = "0x186E0F190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private HMPFKGKOKMN DJOAFOLKKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E14250", Offset = "0x6E12A50", VA = "0x186E14250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private HMPFKGKOKMN GNGCGMMEIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E183E0", Offset = "0x6E16BE0", VA = "0x186E183E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private HMPFKGKOKMN DHHACFLGDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E03140", Offset = "0x6E01940", VA = "0x186E03140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PHOFPDIJLGI BGJHEGACEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E19380", Offset = "0x6E17B80", VA = "0x186E19380", Slot = "15")]
		get
		{
			return default(PHOFPDIJLGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public JHNODDJNGEL FCJDKIHNMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9DB330", Offset = "0x9D9B30", VA = "0x1809DB330", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FGBCLENDEKC ECPAMDKEEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9DB420", Offset = "0x9D9C20", VA = "0x1809DB420", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BKBJJNPBHHC KOMMDGIKAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1800500", Offset = "0x17FED00", VA = "0x181800500", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BKBJJNPBHHC GALKFAMHKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xED12E0", Offset = "0xECFAE0", VA = "0x180ED12E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string MLLPMCOGDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8BB260", Offset = "0x8B9A60", VA = "0x1808BB260", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform CBLBEDEIJBL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6E03E00", Offset = "0x6E02600", VA = "0x186E03E00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform LEFHHFAIOPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0CDE0", Offset = "0x6E0B5E0", VA = "0x186E0CDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform LJPNEMNAELE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6E10D70", Offset = "0x6E0F570", VA = "0x186E10D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform IAGMKIJIKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E13140", Offset = "0x6E11940", VA = "0x186E13140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform JKBFMKBPDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E04490", Offset = "0x6E02C90", VA = "0x186E04490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool IAGPOCEJNGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E034C0", Offset = "0x6E01CC0", VA = "0x186E034C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool MCBNEILOBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6E034C0", Offset = "0x6E01CC0", VA = "0x186E034C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private Transform IBOHDHJOCDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6E18F90", Offset = "0x6E17790", VA = "0x186E18F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GameObject PBJIFBOBIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E09BA0", Offset = "0x6E083A0", VA = "0x186E09BA0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HeadLogicOffsets FPMDHKGOOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6E19190", Offset = "0x6E17990", VA = "0x186E19190", Slot = "32")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform DDJHGMKDHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x191CE40", Offset = "0x191B640", VA = "0x18191CE40", Slot = "33")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform GHHIAPLBGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x191D0E0", Offset = "0x191B8E0", VA = "0x18191D0E0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform BLMIDDHKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x191D0F0", Offset = "0x191B8F0", VA = "0x18191D0F0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform GDEMJCPMLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xED1950", Offset = "0xED0150", VA = "0x180ED1950", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 JHOIGBBAPAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6E04DA0", Offset = "0x6E035A0", VA = "0x186E04DA0", Slot = "37")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public float ECFCJHPIFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F310", Offset = "0x6E0DB10", VA = "0x186E0F310", Slot = "38")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform DJJBOCJDJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E10FB0", Offset = "0x6E0F7B0", VA = "0x186E10FB0", Slot = "39")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform FHBIBMJAFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1C34CB0", Offset = "0x1C334B0", VA = "0x181C34CB0", Slot = "41")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform GDIGMOMPLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1C34CA0", Offset = "0x1C334A0", VA = "0x181C34CA0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform JAAKKBACFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1737AF0", Offset = "0x17362F0", VA = "0x181737AF0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool MFBHIEAMNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E10E20", Offset = "0x6E0F620", VA = "0x186E10E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool EBEPMDKLFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F290", Offset = "0x6E0DA90", VA = "0x186E0F290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool KKMAENGCJED
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E19CC0", Offset = "0x6E184C0", VA = "0x186E19CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E09DC0", Offset = "0x6E085C0", VA = "0x186E09DC0")]
	private void DLHDEGEDDGG([In] IOOAEAENOEL ALIPOMKLEGE, [In] AvatarFullBodyConfiguration MEGJMJCJPOE, bool OJFPLFMJFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E184E0", Offset = "0x6E16CE0", VA = "0x186E184E0")]
	private float OBHAAABNEAC([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0DC80", Offset = "0x6E0C480", VA = "0x186E0DC80")]
	private float FOAKMGNCLDO([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E09400", Offset = "0x6E07C00", VA = "0x186E09400")]
	private void DDGDHMIFFHL(IOOAEAENOEL ALIPOMKLEGE, AvatarFullBodyConfiguration MEGJMJCJPOE, bool OJFPLFMJFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E16890", Offset = "0x6E15090", VA = "0x186E16890")]
	private void MPGLPJGCJII([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E101D0", Offset = "0x6E0E9D0", VA = "0x186E101D0")]
	private void HIKIINHFFMF([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A9C0", Offset = "0x6E191C0", VA = "0x186E1A9C0")]
	public PFHGLMNICIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E038E0", Offset = "0x6E020E0", VA = "0x186E038E0", Slot = "12")]
	public void ANEAKICEJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E19740", Offset = "0x6E17F40", VA = "0x186E19740", Slot = "13")]
	public void PJHPAPCBDFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E11010", Offset = "0x6E0F810", VA = "0x186E11010", Slot = "14")]
	public void IIOOMAPCCNK(bool ELHNEKJNAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CE20", Offset = "0x6E0B620", VA = "0x186E0CE20", Slot = "25")]
	public Transform FABIOFCHDFN(string JNPGLNANKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C300", Offset = "0x6E0AB00", VA = "0x186E0C300", Slot = "26")]
	public Vector3? EKCOCJKPFHE(string JNPGLNANKNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E14A90", Offset = "0x6E13290", VA = "0x186E14A90", Slot = "7")]
	public void MHCDHMPLLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BB90", Offset = "0x6E0A390", VA = "0x186E0BB90")]
	private void ECLJFEAFGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E09C40", Offset = "0x6E08440", VA = "0x186E09C40")]
	private Vector3 DJCAILEKFMM([In] IOOAEAENOEL LCFHGACCKAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E05590", Offset = "0x6E03D90", VA = "0x186E05590", Slot = "6")]
	public void CBBOOFEMODJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E08BA0", Offset = "0x6E073A0", VA = "0x186E08BA0", Slot = "8")]
	public void CJJLOADIKKI(float BPLFELCHJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E14200", Offset = "0x6E12A00", VA = "0x186E14200")]
	private void LHCCACFEHEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E06360", Offset = "0x6E04B60", VA = "0x186E06360", Slot = "4")]
	public void CGKJNFIPEFO(string DGMCFNCHLMF, CBOPDGCOOKF DDJIBBBJFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E18760", Offset = "0x6E16F60", VA = "0x186E18760", Slot = "5")]
	public void OJBDDGCOKDN(PHOFPDIJLGI ANPLJHEONOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E16260", Offset = "0x6E14A60", VA = "0x186E16260", Slot = "11")]
	public void MLGECPGCLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E13420", Offset = "0x6E11C20", VA = "0x186E13420", Slot = "24")]
	public void KJJPIJCEMOL([Out] Vector3 HBCNPLOLNHP, [Out] Quaternion KCNOANPBOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E180F0", Offset = "0x6E168F0", VA = "0x186E180F0")]
	private void NHECICHOCIC([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D1B0", Offset = "0x6E0B9B0", VA = "0x186E0D1B0", Slot = "27")]
	public void FHCBEPICOKC(float JHGEHGBMJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E06010", Offset = "0x6E04810", VA = "0x186E06010", Slot = "28")]
	public void CFGCFLKDMMB(float CBAGNOKGIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E129C0", Offset = "0x6E111C0", VA = "0x186E129C0", Slot = "44")]
	public void JDCAIBMFDIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CF70", Offset = "0x6E0B770", VA = "0x186E0CF70", Slot = "29")]
	public void FCJDGFDJKMK(bool LJBCHPFGMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E18710", Offset = "0x6E16F10", VA = "0x186E18710", Slot = "30")]
	public HandLogicOffsets OIGCJGINMIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E140C0", Offset = "0x6E128C0", VA = "0x186E140C0", Slot = "31")]
	public PlatformSpecificPlayerHandOffsets LDNDPIHIJFF()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BC90", Offset = "0x6E0A490", VA = "0x186E0BC90")]
	private void EEGFMKCHAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6E14650", Offset = "0x6E12E50", VA = "0x186E14650")]
	private void MCBKBBBCDIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E137B0", Offset = "0x6E11FB0", VA = "0x186E137B0")]
	private void KMLBOPACICA(LDJJPBBNOHE LDGCIAOJDOI, bool NCJCCAJKLJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6E09A10", Offset = "0x6E08210", VA = "0x186E09A10")]
	private void DHAOEOJICIP(LDJJPBBNOHE LDGCIAOJDOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E141B0", Offset = "0x6E129B0", VA = "0x186E141B0")]
	public Vector3 LGIPEHGEDBO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E18120", Offset = "0x6E16920", VA = "0x186E18120")]
	private void NJMGDDEBEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E18C00", Offset = "0x6E17400", VA = "0x186E18C00")]
	private void OKKGKHEHOIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6E16A50", Offset = "0x6E15250", VA = "0x186E16A50")]
	private void NEJABKDBCOO(IOOAEAENOEL ALIPOMKLEGE, AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E03E50", Offset = "0x6E02650", VA = "0x186E03E50")]
	private float APKMKHPKOIE([In] IOOAEAENOEL LCFHGACCKAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D3E0", Offset = "0x6E0BBE0", VA = "0x186E0D3E0")]
	private int FNDENOBNGJO([In] KCKHLAIGDBM JJHOBKAONKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6E16350", Offset = "0x6E14B50", VA = "0x186E16350")]
	private void MOMEPNCKMFK(IOOAEAENOEL ALIPOMKLEGE, bool GOIJEAEFCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D1C0", Offset = "0x6E0B9C0", VA = "0x186E0D1C0")]
	private static void FHNGFONFMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6E15530", Offset = "0x6E13D30", VA = "0x186E15530")]
	private static void MKJDMIGBJFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6E123C0", Offset = "0x6E10BC0", VA = "0x186E123C0")]
	private float IODEJPILEKH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E14180", Offset = "0x6E12980", VA = "0x186E14180")]
	private static int LEPLFAKHJND(PFHGLMNICIP CBNNCMPLCDK, PFHGLMNICIP OKJLFDLNFEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6E19210", Offset = "0x6E17A10", VA = "0x186E19210", Slot = "40")]
	public IOOAEAENOEL OOMJJAHJPMC()
	{
		return default(IOOAEAENOEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E03340", Offset = "0x6E01B40", VA = "0x186E03340")]
	public void AJNMJEOMFCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E13AA0", Offset = "0x6E122A0", VA = "0x186E13AA0")]
	private (bool, bool) KNFOGEHEBGG()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E02490", Offset = "0x6E00C90", VA = "0x186E02490")]
	private (float, float) AANAJIOCGBE([In] IOOAEAENOEL LCFHGACCKAF)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6E00A60", Offset = "0x6DFF260", VA = "0x186E00A60")]
	private void AAHPGMPGLHB([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E08D10", Offset = "0x6E07510", VA = "0x186E08D10")]
	private void CLCIFHABAJE([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F650", Offset = "0x6E0DE50", VA = "0x186E0F650")]
	private void HBIPKLPFACF([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E125A0", Offset = "0x6E10DA0", VA = "0x186E125A0")]
	private void IOHPOLPNMCO([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE, AvatarFootSettings JHPOOLIKCNC, bool PBKEGJPGBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E10DA0", Offset = "0x6E0F5A0", VA = "0x186E10DA0")]
	private float ICMEAAHFMAE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E17560", Offset = "0x6E15D60", VA = "0x186E17560")]
	private void NHCIOHDKFHJ(IOOAEAENOEL LCFHGACCKAF, AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E02CF0", Offset = "0x6E014F0", VA = "0x186E02CF0")]
	private float AEHALLEJBDN()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E0DFD0", Offset = "0x6E0C7D0", VA = "0x186E0DFD0")]
	private void GFEBLDNOBOP([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F360", Offset = "0x6E0DB60", VA = "0x186E0F360")]
	private void GPILDBNAJBF([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E02D40", Offset = "0x6E01540", VA = "0x186E02D40")]
	private void AFGAKDJHDBL([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6E15280", Offset = "0x6E13A80", VA = "0x186E15280")]
	private void MJBFPJMOHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E13180", Offset = "0x6E11980", VA = "0x186E13180")]
	private void KDAIJBFFFAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E10030", Offset = "0x6E0E830", VA = "0x186E10030")]
	private void HEGGGKNDNDL([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E172D0", Offset = "0x6E15AD0", VA = "0x186E172D0")]
	private void NFAOLAGPLNP(PLLMCEELJMF HPGMEIEFLEL, IKSolverVR.Arm CKDOBICDGJL, Transform IAPIMCOCGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E04100", Offset = "0x6E02900", VA = "0x186E04100")]
	private void BCNFIGBNDHH(IOOAEAENOEL LCFHGACCKAF, AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E19D40", Offset = "0x6E18540", VA = "0x186E19D40")]
	private void PNBBMCGMEOD(JBDMMOELPLB ECLIDJKPDMI, BKBJJNPBHHC HPGMEIEFLEL, IKSolverVR.Arm CKDOBICDGJL, float CKIJGEGKEPE, float EBCDLDLEOGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E084A0", Offset = "0x6E06CA0", VA = "0x186E084A0")]
	private void CHFEOAACKOL([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E03510", Offset = "0x6E01D10", VA = "0x186E03510")]
	protected void AMJMBFEBCFA([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E0DD00", Offset = "0x6E0C500", VA = "0x186E0DD00")]
	private void GCNMCPOBPJO([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B790", Offset = "0x6E09F90", VA = "0x186E0B790")]
	protected void DMODBNFPADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C5A0", Offset = "0x6E0ADA0", VA = "0x186E0C5A0")]
	private void EKNNKHFMFCF([In] IOOAEAENOEL LCFHGACCKAF, [In] MNGOBAFALHE FHJIHMNNOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B9E0", Offset = "0x6E0A1E0", VA = "0x186E0B9E0")]
	private void DOJBFDIPFPD(IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E133E0", Offset = "0x6E11BE0", VA = "0x186E133E0")]
	private void KDLCCHJDNFM([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E12A10", Offset = "0x6E11210", VA = "0x186E12A10")]
	private Vector3 JFDELAAEDEA([In] IOOAEAENOEL LCFHGACCKAF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E054C0", Offset = "0x6E03CC0", VA = "0x186E054C0")]
	private void BNJFEBMEKFA([In] IOOAEAENOEL LCFHGACCKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E0ED40", Offset = "0x6E0D540", VA = "0x186E0ED40")]
	private float GHOGALJOFJN(float FJFPANHFACF, [In] IOOAEAENOEL LCFHGACCKAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E04F30", Offset = "0x6E03730", VA = "0x186E04F30")]
	private void BNAHMLGHFPO(float FJFPANHFACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E02600", Offset = "0x6E00E00", VA = "0x186E02600")]
	private void ADBFEKBHNOJ([In] IOOAEAENOEL LCFHGACCKAF, MNGOBAFALHE FHJIHMNNOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E0D4C0", Offset = "0x6E0BCC0", VA = "0x186E0D4C0")]
	private float FNIKLPDFGPN([In] IOOAEAENOEL ALIPOMKLEGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E110E0", Offset = "0x6E0F8E0", VA = "0x186E110E0")]
	private void IKOCACAKFPF(IOOAEAENOEL LCFHGACCKAF, MNGOBAFALHE FHJIHMNNOKF, Vector3 JAICMPIAGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E09860", Offset = "0x6E08060", VA = "0x186E09860")]
	private static void DEPNJEOOFJP(Transform NBEDBEKEEBM, Quaternion OJEGGOKKPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E14350", Offset = "0x6E12B50", VA = "0x186E14350")]
	private void LPMKDMLDFOK([In] IOOAEAENOEL LLHHILENPIG, [In] KCKHLAIGDBM JJHOBKAONKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E0E490", Offset = "0x6E0CC90", VA = "0x186E0E490")]
	private void GGEGJKLHKFG([In] IOOAEAENOEL LLHHILENPIG, [In] KCKHLAIGDBM JJHOBKAONKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E0CFC0", Offset = "0x6E0B7C0", VA = "0x186E0CFC0")]
	private void FFNFFCIIHFD(float AAGHOKKCKLI, [In] IOOAEAENOEL ALIPOMKLEGE, float DDOOJNEPMGM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6E045D0", Offset = "0x6E02DD0", VA = "0x186E045D0")]
	private float BHCPLNHMJBH([In] IOOAEAENOEL ALIPOMKLEGE, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E13CD0", Offset = "0x6E124D0", VA = "0x186E13CD0")]
	private void KNGNHDHBIJE([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E118E0", Offset = "0x6E100E0", VA = "0x186E118E0")]
	private void IMJCHKOMHFP([In] IOOAEAENOEL ALIPOMKLEGE, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E09030", Offset = "0x6E07830", VA = "0x186E09030")]
	private void CLNICJLCEIF([In] IOOAEAENOEL ALIPOMKLEGE, float MABEEMKDHNN, float DCEPNIIIMPB, Vector3 PIENBLPHAJE, float DDOOJNEPMGM = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6E102D0", Offset = "0x6E0EAD0", VA = "0x186E102D0")]
	private void HJBBDJEHDGN(IOOAEAENOEL ALIPOMKLEGE, AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6E194B0", Offset = "0x6E17CB0", VA = "0x186E194B0")]
	private void PEDACPAFJFE(IOOAEAENOEL LCFHGACCKAF, AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E0BE10", Offset = "0x6E0A610", VA = "0x186E0BE10")]
	private void EGDGOIHKMIE(IOOAEAENOEL ALIPOMKLEGE, AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E19B00", Offset = "0x6E18300", VA = "0x186E19B00")]
	public void PKGPJAJFEKE([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E18C20", Offset = "0x6E17420", VA = "0x186E18C20")]
	public void OKMMMKHJIMH([In] IOOAEAENOEL LCFHGACCKAF, [In] AvatarFullBodyConfiguration MEGJMJCJPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E18570", Offset = "0x6E16D70", VA = "0x186E18570")]
	[CompilerGenerated]
	internal static void OHBMNKEMCFK(Transform HJDPFHBMCGB, IKSolverVR.Arm CKDOBICDGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E0C250", Offset = "0x6E0AA50", VA = "0x186E0C250")]
	[CompilerGenerated]
	internal static void EJPOLOLCKFJ(Vector3 AAGIMGILKJF, Vector3 GIHNIIGMMDH, LFFJJOFMIML P_2, HIMJJFDABON P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E10CD0", Offset = "0x6E0F4D0", VA = "0x186E10CD0")]
	[CompilerGenerated]
	internal static void HKIFKNKIMGG(KMKBDGGMAOF FNAODFKOBIF, KMKBDGGMAOF JDODPBKKNHB, Vector3 DCMCPEDFCME, float JBBHONJKFOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E13030", Offset = "0x6E11830", VA = "0x186E13030")]
	[CompilerGenerated]
	internal static bool JMKKGGMNONB(IKSolverVR.Arm CKDOBICDGJL, DMJBPFGPKPC AAFNBMMBJJB, float MOGMJGINNGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6E05080", Offset = "0x6E03880", VA = "0x186E05080")]
	[CompilerGenerated]
	internal static float BNBNFGKCAHL(Vector3 LLKHNABOEFA, Vector3 OFKLPMLBPEG, Vector3 EKKLDAOJKCL, IOOAEAENOEL ALIPOMKLEGE, AvatarFullBodyConfiguration MEGJMJCJPOE, float MHPJBPKHONI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[RecRoom.NoEngine.Common.Preserve]
internal class JFIFBJPIBNC : NBBIOKCPPLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Dictionary<string, HHHOAOPGIDI> KAHAAIICPAI;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6E23100", Offset = "0x6E21900", VA = "0x186E23100")]
	[PDAMAKFHAHC.GNFCFDNPMLH]
	internal static void GMGOOHPLJMA(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6E22BC0", Offset = "0x6E213C0", VA = "0x186E22BC0", Slot = "4")]
	public HHHOAOPGIDI GBABLHLILFL(string LOJEGDHBBJJ, AvatarSystemConfiguration FNDLCLGABCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E22DE0", Offset = "0x6E215E0", VA = "0x186E22DE0", Slot = "5")]
	public void GBIIKLBDAML(string LOJEGDHBBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E22FC0", Offset = "0x6E217C0", VA = "0x186E22FC0", Slot = "6")]
	public string GBJNFBENIPM(string KKIGJGGOMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6E22B50", Offset = "0x6E21350", VA = "0x186E22B50")]
	private string FAHIANOIACK(string KKIGJGGOMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E23170", Offset = "0x6E21970", VA = "0x186E23170")]
	public JFIFBJPIBNC()
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
		public class GLEHPPMACEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			private Dictionary<string, Transform> AHOLFHBDGIH;

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public bool KMEJBLAIFGB
			{
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x6E21B50", Offset = "0x6E20350", VA = "0x186E21B50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x6E21B90", Offset = "0x6E20390", VA = "0x186E21B90")]
			public void PBINOMNGBGP(VRIK LJNFLPIHCDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8B6AA0", Offset = "0x8B52A0", VA = "0x1808B6AA0")]
			public void AEBHKOIDICL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6E21B00", Offset = "0x6E20300", VA = "0x186E21B00")]
			public void FGGFCKBCIEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6E21CC0", Offset = "0x6E204C0", VA = "0x186E21CC0")]
			public GLEHPPMACEN()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[AMEMCNMOGMB(CPHBAPBBNNI.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[AEOOJFCMMHH(CPHBAPBBNNI.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly GLEHPPMACEN ILEKKNANPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private MACODCFJMGA EAELFECOODF;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E1C690", Offset = "0x6E1AE90", VA = "0x186E1C690")]
		private void EHFCOOMFLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1C640", Offset = "0x6E1AE40", VA = "0x186E1C640")]
		private bool DLCJFCDEEKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E1C970", Offset = "0x6E1B170", VA = "0x186E1C970")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E1C9E0", Offset = "0x6E1B1E0", VA = "0x186E1C9E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6E1C980", Offset = "0x6E1B180", VA = "0x186E1C980")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1CC50", Offset = "0x6E1B450", VA = "0x186E1CC50")]
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
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000107")]
				[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6E21FF0", Offset = "0x6E207F0", VA = "0x186E21FF0")]
			public void LDJJIOLOFEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6E21EB0", Offset = "0x6E206B0", VA = "0x186E21EB0")]
			public (float, float) KHDCINNAOJF(Animator GABMBKANBAC, AnimatorStateInfo CLPFIACHLDP)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6E224D0", Offset = "0x6E20CD0", VA = "0x186E224D0")]
		public void LDJJIOLOFEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6E222C0", Offset = "0x6E20AC0", VA = "0x186E222C0")]
		public (float, float) GKBAKMNLMAE(Animator GABMBKANBAC)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6E220D0", Offset = "0x6E208D0", VA = "0x186E220D0")]
		private (float, float) BPMLMBCALCM(Animator GABMBKANBAC, AnimatorStateInfo CLPFIACHLDP)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6E226C0", Offset = "0x6E20EC0", VA = "0x186E226C0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6E24820", Offset = "0x6E23020", VA = "0x186E24820", Slot = "4")]
		public override void OnStateEnter(Animator GABMBKANBAC, AnimatorStateInfo CLPFIACHLDP, int BLOKPHAHCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6E24990", Offset = "0x6E23190", VA = "0x186E24990")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal abstract class EEOHCLHEPLJ<TInput, TOutput> : IEKFNCCHIIA<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	protected readonly HPEADDKCNII DIBOKBALCMJ;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD460", Offset = "0x3CCBC60", VA = "0x183CCD460")]
	protected EEOHCLHEPLJ(HPEADDKCNII DIBOKBALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput KDFBDMHOPOO(TInput AOJEAJGBMCP, [Out] IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD3C0", Offset = "0x3CCBBC0", VA = "0x183CCD3C0", Slot = "5")]
	public bool FCFGOGINCPF(TInput AOJEAJGBMCP, [Out] TOutput? HANDIANDCDI, [Out] IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[CEOCIAMIFJE]
public static class PCJFCOELHAJ
{
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly Regex NLKKJJNBGBK;

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6E26410", Offset = "0x6E24C10", VA = "0x186E26410")]
	public static CINGJOHEHDA KEOKONAKADH(MCDELACKOKB GMIJFBCGEGE, HMKFGHFJBCL PJBGJOPLJLI, Guid? MPLJBDJDGNI, Color? OMNJIMKMKAO, AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6E26160", Offset = "0x6E24960", VA = "0x186E26160")]
	public static IHDHEKBLLBJ CDLGKFADMEH(CINGJOHEHDA EBNFOODJNOB)
	{
		return default(IHDHEKBLLBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x32226F0", Offset = "0x3220EF0", VA = "0x1832226F0")]
	internal static TModern? MMPINPKFAAE<TModern>(string? AOJEAJGBMCP, IOIPIFNBCPB<TModern> EFPDOABBILN, HPEADDKCNII DIBOKBALCMJ, JDEMPCOLPNI DDICHLGCPDE, TModern MONNACJIGHJ) where TModern : struct, NLLKPNMALIA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3224BC0", Offset = "0x32233C0", VA = "0x183224BC0")]
	internal static PCOOCDOHKMD NIGMFHFHAIK<TModern>(string? AOJEAJGBMCP, IOIPIFNBCPB<TModern> EFPDOABBILN, HPEADDKCNII DIBOKBALCMJ, JDEMPCOLPNI DDICHLGCPDE, TModern MONNACJIGHJ) where TModern : struct, NLLKPNMALIA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E262C0", Offset = "0x6E24AC0", VA = "0x186E262C0")]
	internal static List<BHGOKAEJDGO> GPPEIACGKBA(IEnumerable<INPADAEONFB>? MPEKLPOIHMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3223D40", Offset = "0x3222540", VA = "0x183223D40")]
	internal static string NDPGEODIEDG<TModern>(TModern AOJEAJGBMCP, IOIPIFNBCPB<TModern> EFPDOABBILN, HPEADDKCNII DIBOKBALCMJ) where TModern : NLLKPNMALIA
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class MOPLNFPNCDI : BFGPGIJBIKL
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IEKFNCCHIIA<EDBLHKFFKED, KCALCFCCDIJ> KNLDNHGOBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFF0", Offset = "0x8B97F0", VA = "0x1808BAFF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IEKFNCCHIIA<EPDCEENGFDC, MJBMEIHOHNJ> CAKOLHEIAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IEKFNCCHIIA<EPDCEENGFDC, MJBMEIHOHNJ> FBCCFDCBNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8B5260", Offset = "0x8B3A60", VA = "0x1808B5260", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CMBFEGDIFGJ KJIBGPFIBAF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8BAFD0", Offset = "0x8B97D0", VA = "0x1808BAFD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public PLIOJMEEBLG OBCOCOKEDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6E24250", Offset = "0x6E22A50", VA = "0x186E24250")]
	[PDAMAKFHAHC.GNFCFDNPMLH.BGLEOICIJCF]
	[UsedImplicitly]
	internal static void HJHPAAGEIBP(CMONJLKOOCI MFHCHOKEAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6E242C0", Offset = "0x6E22AC0", VA = "0x186E242C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MOPLNFPNCDI([NDCFMLCHJCI("UnitySerialization")] ENPLGLKBKJG EIOLHBCGEJO, [NDCFMLCHJCI(null)] ONADJBIIBGG LDJPLKPGKDN, [NDCFMLCHJCI(null)] HPEADDKCNII DIBOKBALCMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum ENKMMBGGHDN
{
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OCHIGAAEBIG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6E249F0", Offset = "0x6E231F0", VA = "0x186E249F0")]
	public OCHIGAAEBIG(string PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E24A50", Offset = "0x6E23250", VA = "0x186E24A50")]
	public OCHIGAAEBIG(string PJFOMDHJLBF, Exception OIFLGCNHIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E24A20", Offset = "0x6E23220", VA = "0x186E24A20")]
	public OCHIGAAEBIG(ENKMMBGGHDN KIEPLEFDLFJ, string PJFOMDHJLBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E249B0", Offset = "0x6E231B0", VA = "0x186E249B0")]
	public OCHIGAAEBIG(ENKMMBGGHDN KIEPLEFDLFJ, string PJFOMDHJLBF, Exception OIFLGCNHIPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal abstract class CFAJODFDBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly ENPLGLKBKJG EIOLHBCGEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected readonly ONADJBIIBGG LDJPLKPGKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	protected readonly HPEADDKCNII DIBOKBALCMJ;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BA80", Offset = "0x6E1A280", VA = "0x186E1BA80")]
	protected CFAJODFDBBF(ENPLGLKBKJG EIOLHBCGEJO, ONADJBIIBGG LDJPLKPGKDN, HPEADDKCNII DIBOKBALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D380", Offset = "0x6E1BB80", VA = "0x186E1D380")]
	protected string PLAOMHDPEHA(KCALCFCCDIJ BKGPNGLOPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CD30", Offset = "0x6E1B530", VA = "0x186E1CD30")]
	protected string JNNDGAHNKCJ(KCALCFCCDIJ BKGPNGLOPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CF10", Offset = "0x6E1B710", VA = "0x186E1CF10")]
	private AvatarOutfitSelectionData KEOKONAKADH(CINGJOHEHDA AMFFPLIEHAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D240", Offset = "0x6E1BA40", VA = "0x186E1D240")]
	private static AvatarCustomizationSettingsData.AnchorParams OPECCFIBNIJ(IOKFCBDBELC? GNONKEKBDJI)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface IEKFNCCHIIA<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput KDFBDMHOPOO(TInput AOJEAJGBMCP, [Out] IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FCFGOGINCPF(TInput AOJEAJGBMCP, [Out] TOutput? HANDIANDCDI, [Out] IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface BFGPGIJBIKL
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	IEKFNCCHIIA<EDBLHKFFKED, KCALCFCCDIJ> KNLDNHGOBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	IEKFNCCHIIA<EPDCEENGFDC, MJBMEIHOHNJ> FBCCFDCBNOE
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	CMBFEGDIFGJ KJIBGPFIBAF
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal enum JDEMPCOLPNI
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface PLIOJMEEBLG
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFDIONBIBLI KBGBIJFEDIC(KCALCFCCDIJ EBNFOODJNOB);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface CMBFEGDIFGJ
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EPDCEENGFDC KBGBIJFEDIC(KCALCFCCDIJ EBNFOODJNOB, int LKLDCOOMHLD, string? IKMKCMDHFDC, string? GNGHPLAJKAH, GINPKJDPNDP EJEAMKBKGJE, List<BHGOKAEJDGO>? BACGEPDOHKD);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CEOCIAMIFJE]
internal class IAFMIDOADCL : EEOHCLHEPLJ<EDBLHKFFKED, KCALCFCCDIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly ONADJBIIBGG LDJPLKPGKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly CONIHFFOGFK EDOKOJKPMJH;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E22980", Offset = "0x6E21180", VA = "0x186E22980")]
	public IAFMIDOADCL(ENPLGLKBKJG EIOLHBCGEJO, ONADJBIIBGG LDJPLKPGKDN, HPEADDKCNII DIBOKBALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E226D0", Offset = "0x6E20ED0", VA = "0x186E226D0", Slot = "6")]
	public override KCALCFCCDIJ KDFBDMHOPOO(EDBLHKFFKED AOJEAJGBMCP, [Out] IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[RecRoom.NoEngine.Common.Preserve]
internal class HBPCGNFKDOO : ENPLGLKBKJG
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class AKCIGBGJNII : JsonConverter<PCOOCDOHKMD>
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B2B0", Offset = "0x6E19AB0", VA = "0x186E1B2B0", Slot = "9")]
		public override void WriteJson(JsonWriter PAOHHJOJGFD, PCOOCDOHKMD? INDENPJBLHO, JsonSerializer JLOPIBLIBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B190", Offset = "0x6E19990", VA = "0x186E1B190", Slot = "10")]
		public override PCOOCDOHKMD ReadJson(JsonReader GKMNBDEFGCI, Type PPHCDIDAADF, PCOOCDOHKMD? KBFJIEABPNP, bool ONGIBGILEIP, JsonSerializer JLOPIBLIBPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B350", Offset = "0x6E19B50", VA = "0x186E1B350")]
		public AKCIGBGJNII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class CFFPEOMBOEH : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override bool CCKHMNBAMNK
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8FF830", Offset = "0x8FE030", VA = "0x1808FF830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EA50", Offset = "0x6E1D250", VA = "0x186E1EA50", Slot = "5")]
		public override object ReadJson(JsonReader GKMNBDEFGCI, Type PPHCDIDAADF, object? KBFJIEABPNP, JsonSerializer JLOPIBLIBPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E690", Offset = "0x6E1CE90", VA = "0x186E1E690", Slot = "6")]
		public override bool CanConvert(Type PPHCDIDAADF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1EAB0", Offset = "0x6E1D2B0", VA = "0x186E1EAB0", Slot = "4")]
		public override void WriteJson(JsonWriter PAOHHJOJGFD, object? INDENPJBLHO, JsonSerializer JLOPIBLIBPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E870", Offset = "0x6E1D070", VA = "0x186E1E870")]
		private static bool GCIGNLFJGNM(object INDENPJBLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		public CFFPEOMBOEH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly JsonSerializerSettings IHCECPGCMAL;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E21D50", Offset = "0x6E20550", VA = "0x186E21D50")]
	internal HBPCGNFKDOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x3083B90", Offset = "0x3082390", VA = "0x183083B90", Slot = "4")]
	public string BBJIMCFDMAJ<T>(T INCBEIDOHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x3083BF0", Offset = "0x30823F0", VA = "0x183083BF0", Slot = "5")]
	public T KCDLAGHLCHJ<T>(string INDENPJBLHO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[RecRoom.NoEngine.Common.Preserve]
internal class KOGAEEJAPLG : ENPLGLKBKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3106790", Offset = "0x3104F90", VA = "0x183106790", Slot = "4")]
	public string BBJIMCFDMAJ<T>(T INCBEIDOHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3106810", Offset = "0x3105010", VA = "0x183106810", Slot = "5")]
	public T KCDLAGHLCHJ<T>(string INDENPJBLHO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public KOGAEEJAPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[CEOCIAMIFJE]
internal class CONIHFFOGFK : EEOHCLHEPLJ<EPDCEENGFDC, MJBMEIHOHNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly ENPLGLKBKJG EIOLHBCGEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly ONADJBIIBGG LDJPLKPGKDN;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6E21000", Offset = "0x6E1F800", VA = "0x186E21000")]
	public CONIHFFOGFK(ENPLGLKBKJG EIOLHBCGEJO, ONADJBIIBGG LDJPLKPGKDN, HPEADDKCNII DIBOKBALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E20420", Offset = "0x6E1EC20", VA = "0x186E20420", Slot = "6")]
	public override MJBMEIHOHNJ KDFBDMHOPOO(EPDCEENGFDC AOJEAJGBMCP, [Out] IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6E20EB0", Offset = "0x6E1F6B0", VA = "0x186E20EB0")]
	internal void PNIGKKOGBHH(string KDIOPNHCKLB, KCALCFCCDIJ BKGPNGLOPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EB90", Offset = "0x6E1D390", VA = "0x186E1EB90")]
	public IEnumerable<CINGJOHEHDA> CBCNPPABADK(string FMPFPADPDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F4E0", Offset = "0x6E1DCE0", VA = "0x186E1F4E0")]
	private IEnumerable<CINGJOHEHDA> DLAAMNEDFLP(string FMPFPADPDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E1F900", Offset = "0x6E1E100", VA = "0x186E1F900")]
	internal IEnumerable<CINGJOHEHDA> FBDHNNNGJCE(string FMPFPADPDDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6E1FD70", Offset = "0x6E1E570", VA = "0x186E1FD70")]
	private CINGJOHEHDA GKDLNGDMCIM(AvatarOutfitSelectionData JCMAICMEMDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EC40", Offset = "0x6E1D440", VA = "0x186E1EC40")]
	private void CFHAEMPECFI(AvatarCustomizationSettingsData IKBHFKLDPJE, KCALCFCCDIJ BKGPNGLOPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6E20100", Offset = "0x6E1E900", VA = "0x186E20100")]
	private CINGJOHEHDA GKDLNGDMCIM(string EKHDLJBICOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E20BB0", Offset = "0x6E1F3B0", VA = "0x186E20BB0")]
	internal static (AEIOBEGHMKA, string, string) NNAEJEKKKHJ(string EKHDLJBICOL, HPEADDKCNII DIBOKBALCMJ)
	{
		return default((AEIOBEGHMKA, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6E209B0", Offset = "0x6E1F1B0", VA = "0x186E209B0")]
	private NNFIHCFOBOK? NKMPEEPGCMB(string? PLMJELCKKDA, Vector2 IOJIMOEKKDH, float FGDJALHEPCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6E20850", Offset = "0x6E1F050", VA = "0x186E20850")]
	private static IOKFCBDBELC KNBJPENOHMB(AvatarCustomizationSettingsData.AnchorParams FMLBLJEBPNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[CEOCIAMIFJE]
internal class AKILEEPEMJE : CFAJODFDBBF, PLIOJMEEBLG
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6E1BA80", Offset = "0x6E1A280", VA = "0x186E1BA80")]
	public AKILEEPEMJE(ENPLGLKBKJG EIOLHBCGEJO, ONADJBIIBGG LDJPLKPGKDN, HPEADDKCNII DIBOKBALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B6D0", Offset = "0x6E19ED0", VA = "0x186E1B6D0", Slot = "4")]
	public JFDIONBIBLI KBGBIJFEDIC(KCALCFCCDIJ EBNFOODJNOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B5D0", Offset = "0x6E19DD0", VA = "0x186E1B5D0")]
	private string IHPJMDGHCHC(KCALCFCCDIJ BKGPNGLOPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B390", Offset = "0x6E19B90", VA = "0x186E1B390")]
	private string BCAGLKHFACN(CINGJOHEHDA AMFFPLIEHAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[CEOCIAMIFJE]
internal class EOPMFODOEJN : EEOHCLHEPLJ<EPDCEENGFDC, MJBMEIHOHNJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly ENPLGLKBKJG EIOLHBCGEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly IEKFNCCHIIA<EPDCEENGFDC, MJBMEIHOHNJ> FDKIGKOJPPG;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6E21A00", Offset = "0x6E20200", VA = "0x186E21A00")]
	public EOPMFODOEJN(IEKFNCCHIIA<EPDCEENGFDC, MJBMEIHOHNJ> FDKIGKOJPPG, HPEADDKCNII DIBOKBALCMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6E215D0", Offset = "0x6E1FDD0", VA = "0x186E215D0", Slot = "6")]
	public override MJBMEIHOHNJ KDFBDMHOPOO(EPDCEENGFDC AOJEAJGBMCP, [Out] IReadOnlyList<BHGOKAEJDGO>? BACGEPDOHKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CEOCIAMIFJE]
internal class EDLBIABMFNA : CMBFEGDIFGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly ENPLGLKBKJG EIOLHBCGEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly PLIOJMEEBLG FFLAOLBPOOP;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6E214E0", Offset = "0x6E1FCE0", VA = "0x186E214E0")]
	public EDLBIABMFNA(PLIOJMEEBLG FFLAOLBPOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E21140", Offset = "0x6E1F940", VA = "0x186E21140", Slot = "4")]
	public EPDCEENGFDC KBGBIJFEDIC(KCALCFCCDIJ EBNFOODJNOB, int LKLDCOOMHLD, string? IKMKCMDHFDC, string? GNGHPLAJKAH, GINPKJDPNDP EJEAMKBKGJE, List<BHGOKAEJDGO>? BACGEPDOHKD)
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
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6E1BCB0", Offset = "0x6E1A4B0", VA = "0x186E1BCB0")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A90", Offset = "0x8B5290", VA = "0x1808B6A90")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class KPOKILJJJKP
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E24140", Offset = "0x6E22940", VA = "0x186E24140")]
	public static IHDHEKBLLBJ KDFBDMHOPOO(this COOJHLCLKNO EBNFOODJNOB)
	{
		return default(IHDHEKBLLBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6E24020", Offset = "0x6E22820", VA = "0x186E24020")]
	public static COOJHLCLKNO KBGBIJFEDIC(this IHDHEKBLLBJ KBCECCLKLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E23FC0", Offset = "0x6E227C0", VA = "0x186E23FC0")]
	public static bool ADBICBNJLAH(this IHDHEKBLLBJ KBCECCLKLDJ)
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
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x51A1DD0", Offset = "0x51A05D0", VA = "0x1851A1DD0")]
			public AnchorParams(Vector2 DKEBCCIFDJJ, Vector3 CDDPMBDFJJC, Vector3 ICEMFMMEPBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x6E1BC00", Offset = "0x6E1A400", VA = "0x186E1BC00")]
			internal IOKFCBDBELC KBGBIJFEDIC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private AAOHFBHHFPJ useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x6E1C4E0", Offset = "0x6E1ACE0", VA = "0x186E1C4E0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x8B5270", Offset = "0x8B3A70", VA = "0x1808B5270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4750AD0", Offset = "0x474F2D0", VA = "0x184750AD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xA89BA0", Offset = "0xA883A0", VA = "0x180A89BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB08640", Offset = "0xB06E40", VA = "0x180B08640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xDB9250", Offset = "0xDB7A50", VA = "0x180DB9250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB240", Offset = "0x8B9A40", VA = "0x1808BB240")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8BE310", Offset = "0x8BCB10", VA = "0x1808BE310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x6E1C590", Offset = "0x6E1AD90", VA = "0x186E1C590")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x8C1900", Offset = "0x8C0100", VA = "0x1808C1900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x924CA0", Offset = "0x9234A0", VA = "0x180924CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x14850A0", Offset = "0x14838A0", VA = "0x1814850A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x8BB220", Offset = "0x8B9A20", VA = "0x1808BB220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8BAFC0", Offset = "0x8B97C0", VA = "0x1808BAFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x6E1C5D0", Offset = "0x6E1ADD0", VA = "0x186E1C5D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0xA3CDF0", Offset = "0xA3B5F0", VA = "0x180A3CDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xC733C0", Offset = "0xC71BC0", VA = "0x180C733C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x1257310", Offset = "0x1255B10", VA = "0x181257310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8B7560", Offset = "0x8B5D60", VA = "0x1808B7560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8B7550", Offset = "0x8B5D50", VA = "0x1808B7550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x1BE8500", Offset = "0x1BE6D00", VA = "0x181BE8500")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xA87FC0", Offset = "0xA867C0", VA = "0x180A87FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8ED500", Offset = "0x8EBD00", VA = "0x1808ED500")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x8ED560", Offset = "0x8EBD60", VA = "0x1808ED560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x8BC110", Offset = "0x8BA910", VA = "0x1808BC110")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8BC160", Offset = "0x8BA960", VA = "0x1808BC160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x8BC100", Offset = "0x8BA900", VA = "0x1808BC100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8BC0C0", Offset = "0x8BA8C0", VA = "0x1808BC0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8BC0D0", Offset = "0x8BA8D0", VA = "0x1808BC0D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x8BBF90", Offset = "0x8BA790", VA = "0x1808BBF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x996E90", Offset = "0x995690", VA = "0x180996E90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xE8A230", Offset = "0xE88A30", VA = "0x180E8A230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x8BC140", Offset = "0x8BA940", VA = "0x1808BC140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x8BC010", Offset = "0x8BA810", VA = "0x1808BC010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA7DF10", Offset = "0xA7C710", VA = "0x180A7DF10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA7DEF0", Offset = "0xA7C6F0", VA = "0x180A7DEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8C0C70", Offset = "0x8BF470", VA = "0x1808C0C70")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8C0C80", Offset = "0x8BF480", VA = "0x1808C0C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x98AAD0", Offset = "0x9892D0", VA = "0x18098AAD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA90070", Offset = "0xA8E870", VA = "0x180A90070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x91CF50", Offset = "0x91B750", VA = "0x18091CF50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x91BB20", Offset = "0x91A320", VA = "0x18091BB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public AAOHFBHHFPJ UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xB0ED40", Offset = "0xB0D540", VA = "0x180B0ED40")]
			get
			{
				return default(AAOHFBHHFPJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xB0D530", Offset = "0xB0BD30", VA = "0x180B0D530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xB0EE00", Offset = "0xB0D600", VA = "0x180B0EE00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB0E3C0", Offset = "0xB0CBC0", VA = "0x180B0E3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6E1C5B0", Offset = "0x6E1ADB0", VA = "0x186E1C5B0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6E1C5F0", Offset = "0x6E1ADF0", VA = "0x186E1C5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6E1C140", Offset = "0x6E1A940", VA = "0x186E1C140")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AEIOBEGHMKA BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private PBFIHFHODOL? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x6E1C610", Offset = "0x6E1AE10", VA = "0x186E1C610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
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
