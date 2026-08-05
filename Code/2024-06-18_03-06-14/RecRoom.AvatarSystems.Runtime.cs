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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x679FCF0", Offset = "0x679E6F0", VA = "0x18679FCF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[FABAIOIDLJO]
internal class JFMCGAODHJH : BJLFDKCLCFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct DJCDGLAOJJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public JFMCGAODHJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public BOPNNGIGHPK avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HOPCKJMAADA GIJHJLNNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KLPEJMDPNBN MHHFDCNLPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DLFAFDJEKEB AEIMMOHAHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly GODGGHEMKPA FFBJMCJNKEP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x678BFE0", Offset = "0x678A9E0", VA = "0x18678BFE0")]
	[MHFEIEAPENL(ABEEEPGJOJM.Root, CMFCLNIIIKO.GameOnly)]
	[UsedImplicitly]
	private static void MCCHBBNBCLB(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x678C8C0", Offset = "0x678B2C0", VA = "0x18678C8C0")]
	[Preserve]
	internal JFMCGAODHJH([OHLKLPAILPF(null)] HOPCKJMAADA GIJHJLNNJNG, [OHLKLPAILPF(null)] KLPEJMDPNBN MHHFDCNLPNH, [OHLKLPAILPF(null)] DLFAFDJEKEB AEIMMOHAHJJ, [OHLKLPAILPF(null)] GODGGHEMKPA FFBJMCJNKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x678C130", Offset = "0x678AB30", VA = "0x18678C130", Slot = "5")]
	public ALDBLMAPDHF PHJDPGLMJII(bool HIMEPNJIJOD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x678B640", Offset = "0x678A040", VA = "0x18678B640", Slot = "4")]
	public ALDBLMAPDHF KGDMHPGMPGH(bool HIMEPNJIJOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x678B390", Offset = "0x6789D90", VA = "0x18678B390", Slot = "6")]
	public KGBMONFGDHD EFDBBOHFBHH(ALDBLMAPDHF EEOBDBMOHPL, int OGJAALGODGH, string? CCMEKJGADHN, string? JDDGHDDMMED, AHOFOGFBAHD NMLLEEDBKBP, List<AMFBJJFGIGL>? LEBGMIOOAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x678B270", Offset = "0x6789C70", VA = "0x18678B270", Slot = "7")]
	public bool BOEPINBPMPK(ALKCDDCCMFA GKHFHIILHMK, [Out] ALDBLMAPDHF? CGJOCNEAIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x678C050", Offset = "0x678AA50", VA = "0x18678C050", Slot = "8")]
	public bool NDNPKLDKNDA(KGBMONFGDHD CIAHOLAHLNL, [Out] ALDBLMAPDHF? CGJOCNEAIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x678B300", Offset = "0x6789D00", VA = "0x18678B300", Slot = "9")]
	public bool DKCCNJKOCLB(KGBMONFGDHD CIAHOLAHLNL, [Out] NCMDMPFPOCI? GKHFHIILHMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A6C0", Offset = "0x2B790C0", VA = "0x182B7A6C0")]
	private bool HKENCDKFLPJ<TInput, TOutput>(TInput CGAJJAALELM, CEFHEPEMHIF<TInput, TOutput> JPCFCFGKKKF, [Out] TOutput? EBPHIJANMPN) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x678B4A0", Offset = "0x6789EA0", VA = "0x18678B4A0")]
	[CompilerGenerated]
	private GKEPNIODDKM ENFCAKMIIJE(FaceFeatureType MHPJECMOEDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x678AFA0", Offset = "0x67899A0", VA = "0x18678AFA0")]
	[CompilerGenerated]
	private GKEPNIODDKM BCIGFOHKGGM(FaceFeatureType MHPJECMOEDF, DJCDGLAOJJA P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[FABAIOIDLJO]
internal class OGOJDBFEJMM : HOPCKJMAADA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void PKNDJEJDGGP<in TData>(TData CGJOCNEAIOK, IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DLFAFDJEKEB AEIMMOHAHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OLPJGLPPFIJ LPIGFFIELAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PKNDJEJDGGP<ALDBLMAPDHF>?[] GIJHJLNNJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PKNDJEJDGGP<NCMDMPFPOCI>?[] JMCEAMPGJGC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67A0C30", Offset = "0x679F630", VA = "0x1867A0C30")]
	[MHFEIEAPENL(ABEEEPGJOJM.Root, CMFCLNIIIKO.GameOnly)]
	[UsedImplicitly]
	private static void MCCHBBNBCLB(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67A0CA0", Offset = "0x679F6A0", VA = "0x1867A0CA0")]
	[Preserve]
	internal OGOJDBFEJMM([OHLKLPAILPF(null)] DLFAFDJEKEB AEIMMOHAHJJ, [OHLKLPAILPF(null)] OLPJGLPPFIJ LPIGFFIELAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67A07A0", Offset = "0x679F1A0", VA = "0x1867A07A0", Slot = "4")]
	public bool GMEKDCKFJHD(ALDBLMAPDHF CGJOCNEAIOK, IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x67A08A0", Offset = "0x679F2A0", VA = "0x1867A08A0", Slot = "5")]
	public bool GMEKDCKFJHD(NCMDMPFPOCI GKHFHIILHMK, IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x679FD70", Offset = "0x679E770", VA = "0x18679FD70")]
	private void AKCNBHFGMKG(ALDBLMAPDHF CGJOCNEAIOK, IReadOnlyList<AMFBJJFGIGL>? MAJFEBAGNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67A0A00", Offset = "0x679F400", VA = "0x1867A0A00")]
	private void IDFMGGOPMPJ(ALDBLMAPDHF CGJOCNEAIOK, IReadOnlyList<AMFBJJFGIGL>? MAJFEBAGNLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HOPCKJMAADA
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMEKDCKFJHD(ALDBLMAPDHF CGJOCNEAIOK, IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMEKDCKFJHD(NCMDMPFPOCI GKHFHIILHMK, IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF);
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct AnimationPoseSetting
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static AnimationPoseSetting Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Tooltip("Type of pose")]
		public CHIICFMKKAH AnimationPoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[Tooltip("How much of the head movement is applied to the hand movement")]
		public float HeadMovementWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[Tooltip("Weight between IK hand and Animated hand for position")]
		public float HandAnimationPosWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[Tooltip("Weight between IK hand and Animated hand for rotation")]
		public float HandAnimationRotWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[Tooltip("Weight between shoulders facing forward and alignment with hands")]
		public float ShoulderFollowWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Tooltip("How much the aim follows direction of feet vs head (0 = head, 1 = feet)")]
		public float FeetFollowWeight;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6783920", Offset = "0x6782320", VA = "0x186783920")]
		public void OBNFDLBEFGN(AnimationPoseSetting HENLEJBGFIE, float EFDIAOOFIGO)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, JKJNNLGEJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool DebugExecutionInEditor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Vector3? IIAGANMHLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool DHNIHOFNGIK;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6783AB0", Offset = "0x67824B0", VA = "0x186783AB0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67840B0", Offset = "0x6782AB0", VA = "0x1867840B0", Slot = "4")]
		public void UpdateController(float ECCGJGJKLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xE76270", Offset = "0xE74C70", VA = "0x180E76270", Slot = "6")]
		public void SetEnabled(bool DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6783B50", Offset = "0x6782550", VA = "0x186783B50")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67844D0", Offset = "0x6782ED0", VA = "0x1867844D0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, JKJNNLGEJBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float BFFLPJGKMLN = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Vector3 IGBEDMAACLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 NDLLANFJMOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool DHNIHOFNGIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float KLPFDIAGDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float BEHEHDAODCB;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6784850", Offset = "0x6783250", VA = "0x186784850", Slot = "4")]
		public void UpdateController(float ECCGJGJKLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xB5CC10", Offset = "0xB5B610", VA = "0x180B5CC10", Slot = "6")]
		public void SetEnabled(bool DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6784570", Offset = "0x6782F70", VA = "0x186784570")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6785420", Offset = "0x6783E20", VA = "0x186785420")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		[SerializeField]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
		[SerializeField]
		private float boneFakeLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private Color boneColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private float boneWidthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private float boneBloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private float axisHandleSize;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6785D40", Offset = "0x6784740", VA = "0x186785D40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6785D00", Offset = "0x6784700", VA = "0x186785D00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6785450", Offset = "0x6783E50", VA = "0x186785450")]
		private void BFBLCABLKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x674EFD0", Offset = "0x674D9D0", VA = "0x18674EFD0", Slot = "4")]
		public void SetEnabled(bool OPDIOPBPNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6785D70", Offset = "0x6784770", VA = "0x186785D70")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarForearmRollController : MonoBehaviour, JKJNNLGEJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private bool DHNIHOFNGIK;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6785DB0", Offset = "0x67847B0", VA = "0x186785DB0", Slot = "4")]
		public void UpdateController(float ECCGJGJKLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85E600", Offset = "0x85D000", VA = "0x18085E600", Slot = "6")]
		public void SetEnabled(bool DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6786530", Offset = "0x6784F30", VA = "0x186786530")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, KLAEPMLEANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[GBAJCKFHNAK(MJDOLBEDPIO.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		[Header("Configuration")]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private FAPOOABIGOE CLABIBLFCGJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public FAPOOABIGOE PEPEICNBEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x67872C0", Offset = "0x6785CC0", VA = "0x1867872C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform GODJEPIBGIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6787300", Offset = "0x6785D00", VA = "0x186787300", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67865F0", Offset = "0x6784FF0", VA = "0x1867865F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6787180", Offset = "0x6785B80", VA = "0x186787180")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6787130", Offset = "0x6785B30", VA = "0x186787130")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x67870C0", Offset = "0x6785AC0", VA = "0x1867870C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67869A0", Offset = "0x67853A0", VA = "0x1867869A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x67870C0", Offset = "0x6785AC0", VA = "0x1867870C0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6786670", Offset = "0x6785070", VA = "0x186786670", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x67871D0", Offset = "0x6785BD0", VA = "0x1867871D0", Slot = "8")]
		public void UpdatePostIKAnimControllers(float ECCGJGJKLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6786560", Offset = "0x6784F60", VA = "0x186786560")]
		private void APCDGKKFAHJ(GameObject GKHPLGCJCPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6786A20", Offset = "0x6785420", VA = "0x186786A20")]
		private FAPOOABIGOE LDGBEIMPBJH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public AvatarFullBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Header("Shuffle settings")]
		[Tooltip("The length of the shuffle state in seconds.")]
		public float ShuffleTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed.")]
		public float ShuffleDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("The maximum 2D distance from feet to head allowed before a shuffle is performed after the delay is completed.")]
		public float ShuffleInnerDeadZoneRadius;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a follow begins.")]
		public float ShuffleInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("The number of seconds it takes for a positional follow to catch up when steering.")]
		public float OffsetBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a turn.")]
		public float TurnTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[Tooltip("An inner dead zone that has a time-delayed effect.")]
		public float TurnInnerDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Tooltip("The number of seconds the inner dead zone must be exceeded before a turn starts.")]
		public float TurnInnerDeadZoneDelayTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[Space]
		[Tooltip("When just following the head, we use the \"...FollowTime\" settings, but when steering, we use 0 as the follow time. We need a way to smoothly transition between those two different follow times, and that's what this setting is.")]
		public float TypicalFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[Tooltip("Special-case smooth time for transitioning into flying to compensate for the considerably greateraccelerations and max speeds experienced while flying compared with other typical forms of locomotion.")]
		public float FlyingFollowTimeSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float MinWalkingBackwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public float MaxWalkingForwardAngleThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public float SteeringBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public float DirectionChangeDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		[Header("Hand Placement")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Hand Animation")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Header("Watch")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 10f)]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2EC")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Range(0.01f, 1f)]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F1")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		[Header("Hand Blending")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Header("Body Twisting")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR")]
		public float VRShoulderTwistBlend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Header("Hand Snapping")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Header("Hand Poses")]
		[Tooltip("Time it takes to blend between 2 animation pose settings")]
		public float AnimationPoseSettingBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[FormerlySerializedAs("HandPoseSettings")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6787320", Offset = "0x6785D20", VA = "0x186787320")]
		public AnimationPoseSetting OIKLPIHGGAA(CHIICFMKKAH CNFALHAAECH)
		{
			return default(AnimationPoseSetting);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6787370", Offset = "0x6785D70", VA = "0x186787370")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NKHPFMMHFCP : KLIJBAHHPNE
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static int HEBINPJADEK;

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static int NPFFIALEJDO;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static int COOIPLGKMMO;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static int DBOGNAJHHBF;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static int AHKDODMPEBE;

	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private static int MOLFEPMEEPD;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static int OGIKNOMAMAN;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static int EMMCHMCCGBG;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int KMNGFGJPAGL;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static int[] LJLFIGFBIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal bool BLKCEHBKJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private AAPCOIPLNKD PLADOJNKFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private int LILNLFPIODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float FLACKLNHKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool DCNJPBAKCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Animator OHMKNCBLLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private AvatarFullBodyConfiguration MBJJOHPGGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private int JHJGGKBGGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private int DNCAKAOGCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private int HDPKGEABIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool ACFFLCPKKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private GCBOGMDBBHF ECFNNBLDHFC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform HKADLFHILHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84EC30", Offset = "0x84D630", VA = "0x18084EC30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 EIGGOFLBLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xDB4030", Offset = "0xDB2A30", VA = "0x180DB4030")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xDB3F40", Offset = "0xDB2940", VA = "0x180DB3F40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion LONPENPFMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1BA36C0", Offset = "0x1BA20C0", VA = "0x181BA36C0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1F1C730", Offset = "0x1F1B130", VA = "0x181F1C730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 HHGPIEOJBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3E0E430", Offset = "0x3E0CE30", VA = "0x183E0E430", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EEE0", Offset = "0x3E0D8E0", VA = "0x183E0EEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Quaternion EGGPDBAAPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x10B1410", Offset = "0x10AFE10", VA = "0x1810B1410", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4E350C0", Offset = "0x4E33AC0", VA = "0x184E350C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JCPJICNIBCM KOGMGFCDNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85BF60", Offset = "0x85A960", VA = "0x18085BF60", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(JCPJICNIBCM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85BF40", Offset = "0x85A940", VA = "0x18085BF40", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JCPJICNIBCM NPKHOHCHBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1AA3600", Offset = "0x1AA2000", VA = "0x181AA3600", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(JCPJICNIBCM);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1AA3610", Offset = "0x1AA2010", VA = "0x181AA3610", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float PJBOJDEGOAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1D47920", Offset = "0x1D46320", VA = "0x181D47920", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1D49140", Offset = "0x1D47B40", VA = "0x181D49140", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool JGCPMELNGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x679F580", Offset = "0x679DF80", VA = "0x18679F580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool EPIMKIBEKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x679F280", Offset = "0x679DC80", VA = "0x18679F280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NAAHLLNLAJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x679F650", Offset = "0x679E050", VA = "0x18679F650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x679F0B0", Offset = "0x679DAB0", VA = "0x18679F0B0", Slot = "21")]
	public void CCPNKNOIBEC(AAPCOIPLNKD JJDDNLEFAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x679F270", Offset = "0x679DC70", VA = "0x18679F270", Slot = "22")]
	public void DHGCPKGCDNJ(DCIMNDGHMOF JNBHMGOHIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x679F660", Offset = "0x679E060", VA = "0x18679F660", Slot = "11")]
	public void LJKLFCPKJLE(bool MOPHDJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x679F2A0", Offset = "0x679DCA0", VA = "0x18679F2A0", Slot = "10")]
	public void DPOCCDKGPHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x679F700", Offset = "0x679E100", VA = "0x18679F700")]
	private int MGKHLHJFBDI(JCPJICNIBCM NEGNCKLFPNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x679F890", Offset = "0x679E290", VA = "0x18679F890")]
	private void OOCGDEONDBF(int IPHKKMMMLPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x679F0A0", Offset = "0x679DAA0", VA = "0x18679F0A0", Slot = "12")]
	public bool AEJOLGIJMJD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x679F880", Offset = "0x679E280", VA = "0x18679F880", Slot = "13")]
	public bool NOICANOHIPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x679F600", Offset = "0x679E000", VA = "0x18679F600")]
	private JCPJICNIBCM JHAMDGKNOLD()
	{
		return default(JCPJICNIBCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xEEBC60", Offset = "0xEEA660", VA = "0x180EEBC60", Slot = "14")]
	public void FDFMFGPHKFE(bool MOPHDJCHLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x679F290", Offset = "0x679DC90", VA = "0x18679F290", Slot = "9")]
	public void DJMLAPKIEIE(int IPHKKMMMLPJ, float INDJMICMPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x679F590", Offset = "0x679DF90", VA = "0x18679F590", Slot = "7")]
	public void JAMBIGLKNKI(GCBOGMDBBHF FAKDNFCMPPB, bool GEBFAKFHJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x679F6F0", Offset = "0x679E0F0", VA = "0x18679F6F0", Slot = "8")]
	public void MAKEJAHMGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x679F5B0", Offset = "0x679DFB0", VA = "0x18679F5B0", Slot = "15")]
	public void JFPCLKOLAMD(Transform EMNGIAIDBPA, Vector3 NOCCMNBAPEG, Quaternion CKFPNDJBJHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x679FCE0", Offset = "0x679E6E0", VA = "0x18679FCE0")]
	public NKHPFMMHFCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class KPBANONNHON : FAPOOABIGOE
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private class CLJBNHANLNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private float IBJALAJCMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Vector3 PCLJBMFEIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float MCJGKKPFKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private bool OICCAOKPDAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AnimationPoseSetting PHHEMDBFOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private float NODHFHAPOMK;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x678A850", Offset = "0x6789250", VA = "0x18678A850")]
		public void JCBKOFLGDHC(IKSolverVR.Arm EEEMMHGLPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67892E0", Offset = "0x6787CE0", VA = "0x1867892E0")]
		public void ADAGAPKJPPG(IKSolverVR.Arm EEEMMHGLPCA, Transform KPOGNEDALIL, bool AGBOGAJKGKP, AvatarFullBodyConfiguration FBFDHBHFJCB, float LNPLGEGIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x678AC60", Offset = "0x6789660", VA = "0x18678AC60")]
		public void LHNLLIIOHNI(IKSolverVR.Arm EEEMMHGLPCA, float MBBDCCNGJJE, bool OICCAOKPDAB, AvatarFullBodyConfiguration FBFDHBHFJCB, float LNPLGEGIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x67894D0", Offset = "0x6787ED0", VA = "0x1867894D0")]
		private void ADBCGLDOMGI(Transform KPOGNEDALIL, IKSolverVR.Arm EEEMMHGLPCA, float MJKCEKFAPFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x678A7B0", Offset = "0x67891B0", VA = "0x18678A7B0")]
		private void HLNHGGOKFAI(bool AGBOGAJKGKP, AvatarFullBodyConfiguration FBFDHBHFJCB, float LNPLGEGIEGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x678ACA0", Offset = "0x67896A0", VA = "0x18678ACA0")]
		private void OPFADNDGLHL(IKSolverVR.Arm EEEMMHGLPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x678A880", Offset = "0x6789280", VA = "0x18678A880")]
		public void KEOFAJPBALN(IKSolverVR.Arm EEEMMHGLPCA, Transform JFJLMNJBIKC, Transform IFCIBBODGIK, Quaternion GPOACEFKCBE, Vector3 HGJKMPGHBLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6789D00", Offset = "0x6788700", VA = "0x186789D00")]
		private (Vector3, Quaternion) FGBMPFFMKDG(NKHPFMMHFCP CPAECMMKKON, Quaternion AOKFIPPIPFE, Vector3 GBMNOFCAELC)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x67895C0", Offset = "0x6787FC0", VA = "0x1867895C0")]
		public void BNBOCCCCOPB(NKHPFMMHFCP CPAECMMKKON, IKSolverVR.Arm EEEMMHGLPCA, Quaternion AOKFIPPIPFE, Vector3 GBMNOFCAELC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6789710", Offset = "0x6788110", VA = "0x186789710")]
		public void EPKADKADPEE(NKHPFMMHFCP CPAECMMKKON, IKSolverVR.Arm EEEMMHGLPCA, Quaternion AOKFIPPIPFE, Vector3 GBMNOFCAELC, [In] AvatarFullBodyConfiguration FBFDHBHFJCB, [In] OFIEPFIPJJG FAKDNFCMPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x678A5F0", Offset = "0x6788FF0", VA = "0x18678A5F0")]
		public void HGMGANLPPIM(CHIICFMKKAH KCMLKFHNAPB, AvatarFullBodyConfiguration FBFDHBHFJCB, OFIEPFIPJJG FAKDNFCMPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x678A190", Offset = "0x6788B90", VA = "0x18678A190")]
		public void GAMJGEIJOOO(IKSolverVR.Arm EEEMMHGLPCA, Transform JFJLMNJBIKC, Vector3 GEBLIGMMHGB, float LLDJLBEJFON, Quaternion CFNNJJHJEHC, Vector3 PACLDDBNMEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x678ACE0", Offset = "0x67896E0", VA = "0x18678ACE0")]
		public CLJBNHANLNG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private enum FPLGNCNMHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Idle,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		FollowingTarget,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		LockedToTarget,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Step
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private enum FMEFCMMOCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int PEBDHFOJNDB;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int BPPNJBDIPPC;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int DJHOJGMJBIE;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int HHIKMJKEHNK;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int ADLILBICOKM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int PLMOIDBNKFK;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int NKJBBCMHBDK;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int OPNHLFCILMP;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int PNGCOIBIPEL;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int ENEFFINMAMJ;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int DFFAIAKFANH;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int FIADCKKGFKJ;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int KHAMEDIGMGC;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int JOHGMDOJICB;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int BCKFKFKLOOO;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int FBACHONFNAI;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int NFBODGJMPMF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int PJMJHOEPCKG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int HDEHCPOHCLK;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int KELIJEMIICC;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int HHNLIGENGMC;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int KPAFJNOGNEJ;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int KCFKELNDFDI;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int EFEIILBNEEG;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int EMCGMJBIKFF;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int IEFGKIHGBJE;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int GPJDOIDDPGP;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int BGKKNFHAHIG;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int LAGLOBGCNNP;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int CFONLNHDPDB;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int MNAENCFDKMN;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly Vector3 BAGKKHFGEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool GADILIMEMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private bool LHLEPBGAOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool ABNDNMJKJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool LAJNPFGDDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool APBLLMOJMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private Vector3 IDOILEJEKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private PPHKJMDKKGL? PLADOJNKFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private DKMICAFEOAL? OCLPGDEJMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private PAPIJKGPMIJ EJDHDIOJPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NHPHFHMMPOC CMOEPADDMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NKHPFMMHFCP PEKHOOIIIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NKHPFMMHFCP KNBAHBIGPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool OJNAGNICNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x221")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool DELNMJFNGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly DEBKIKFAMLO OHCBOCNDKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly EKFEJFAGNND PMNLLNBMIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private int IACELIDIGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private float LKCBJEMPJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private GameObject FBLPAGIFGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private Transform NPOFABOCDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private Transform ODNCHOFGIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private float PCMEMBHADJF;

	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private static readonly ProfilerMarker BJDFNPPGCDE;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker EGOAEOLNALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private ProfilerMarker EAFFLPFGDAF;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker LEOMMODNMPJ;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly ProfilerMarker HEKBCCEOOKH;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly ProfilerMarker GKCJALFIFAA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly List<KPBANONNHON> OMOFEFMDOBI;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int NOEAIFHDHAL;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> IOLADBHKMAN;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int CDHKOPGLJAN;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int KAIFGLINJHD;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static int HELJPKLEAHI;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int DJEMMGNBDDG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float MOCLJMGJOAH;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static int MLAPGJLKOBE;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float AJPMLCGCAPD;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float AOEDPEHGOIC;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static float KFGIACDADMP;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static float IJMEOHENKIM;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static JNEIKJEKECC IBAMEKEICEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float LMCJKDOHKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private bool BEKDOEANPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private float KEIKJLNNAHM;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly Quaternion AHJOFFKLFGH;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly Quaternion IFHBPPADPPD;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly Vector3 PELDJHKKJBH;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly Vector3 AGLIBKEADEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private CLJBNHANLNG OOKBHGIGHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private CLJBNHANLNG FADHCMEOHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private JKJENCJIMEJ ILDAHPMPGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private LLDHMBPLKIF IIAFFLDJONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private FPLGNCNMHEJ EOCCPLELBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private float PAOHIKJNGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly PNIGJABCMPJ KLOJCABDDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float APIKAFNNLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private float AEKMMOEHJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 DGEDHIHJODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly LLDHMBPLKIF CLKHDJHDPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly EMKBICLMHEI GDDDICCAPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private float OPGPIAFHGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private FPLGNCNMHEJ EKLLCIHOFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private Vector3 EDLEPKKEDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float KMLDBPHDEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float PDICICDIKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly LLDHMBPLKIF NKDKAAHLPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly JKJENCJIMEJ OEFJFIFOHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly LLDHMBPLKIF LGEINHLEKKC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public MNIMPDIHNFL NBFNHAKAPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MNIMPDIHNFL BIHFOBJLECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AvatarConfiguration ENACLEBELPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x679AE40", Offset = "0x6799840", VA = "0x18679AE40", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AvatarFullBodyConfiguration LNHJAKOBOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x679A000", Offset = "0x6798A00", VA = "0x18679A000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private Transform PGMADDOBNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x67973A0", Offset = "0x6795DA0", VA = "0x1867973A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform JFENPDFDHPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6798DA0", Offset = "0x67977A0", VA = "0x186798DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private SkinnedMeshRenderer COEDLDHHJBA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6799A10", Offset = "0x6798410", VA = "0x186799A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Renderer[] DALOCOOKKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x678FCD0", Offset = "0x678E6D0", VA = "0x18678FCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private GameObject[] NMPBFAGDKIA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6792180", Offset = "0x6790B80", VA = "0x186792180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private Animator MDPANIODDIL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x67959C0", Offset = "0x67943C0", VA = "0x1867959C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private VRIK GBDKEJIHAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6798E80", Offset = "0x6797880", VA = "0x186798E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private JKJNNLGEJBH COKIAHKIOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x67920A0", Offset = "0x6790AA0", VA = "0x1867920A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private JKJNNLGEJBH FCMNGJLJFKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x678EB00", Offset = "0x678D500", VA = "0x18678EB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private JKJNNLGEJBH MPOBKFNKLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6799910", Offset = "0x6798310", VA = "0x186799910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private JKJNNLGEJBH IPKGKDAHBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x679CCD0", Offset = "0x679B6D0", VA = "0x18679CCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private JKJNNLGEJBH FJJHBALDIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x67978F0", Offset = "0x67962F0", VA = "0x1867978F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private JKJNNLGEJBH HBEIEBAOIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6799F20", Offset = "0x6798920", VA = "0x186799F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private JKJNNLGEJBH ADKAHCNGDLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6799C90", Offset = "0x6798690", VA = "0x186799C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private JKJNNLGEJBH GIDDOCFLLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6799D70", Offset = "0x6798770", VA = "0x186799D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DKMICAFEOAL AGDBLJMDJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x678FBA0", Offset = "0x678E5A0", VA = "0x18678FBA0", Slot = "32")]
		get
		{
			return default(DKMICAFEOAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public BIJPKIHDHNF FGCDGNCPFGN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8BC340", Offset = "0x8BAD40", VA = "0x1808BC340", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FMHFBABHINA CIMNMOLFIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8BC150", Offset = "0x8BAB50", VA = "0x1808BC150", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public KLIJBAHHPNE NBEDJMAACKL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAED860", Offset = "0xAEC260", VA = "0x180AED860", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public KLIJBAHHPNE PLNCCEKEIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAEF360", Offset = "0xAEDD60", VA = "0x180AEF360", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject AOOABPFBFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6797480", Offset = "0x6795E80", VA = "0x186797480", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform NMIFOFCDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x13C1B30", Offset = "0x13C0530", VA = "0x1813C1B30", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform HKHNAHEEAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x13C2E50", Offset = "0x13C1850", VA = "0x1813C2E50", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Vector3 EAOCOCLIHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6792900", Offset = "0x6791300", VA = "0x186792900", Slot = "29")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public float KCICADLCEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6798180", Offset = "0x6796B80", VA = "0x186798180", Slot = "30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform GKMBCDPHBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x678FB40", Offset = "0x678E540", VA = "0x18678FB40", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private bool JJPCLCDFDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x67936B0", Offset = "0x67920B0", VA = "0x1867936B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private bool ADMFODPKPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x679CC50", Offset = "0x679B650", VA = "0x18679CC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x679B140", Offset = "0x6799B40", VA = "0x18679B140")]
	private void OKFFEINEJEA([In] OFIEPFIPJJG BNCNFFAMOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6793600", Offset = "0x6792000", VA = "0x186793600")]
	private void FLPGOLDHEAI(OFIEPFIPJJG BNCNFFAMOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6791A00", Offset = "0x6790400", VA = "0x186791A00")]
	private void DPOCCDKGPHC(NMIKOKHEDGB AMBCBOKJLNM, KLIJBAHHPNE POHJPJHONJJ, IKSolverVR.Arm EEEMMHGLPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x678CCF0", Offset = "0x678B6F0", VA = "0x18678CCF0")]
	private void ABCHNEPNCLD([In] OFIEPFIPJJG FAKDNFCMPPB, [In] AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x679EA30", Offset = "0x679D430", VA = "0x18679EA30")]
	public KPBANONNHON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67979D0", Offset = "0x67963D0", VA = "0x1867979D0", Slot = "12")]
	public void JNIFGCGFGMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6796F60", Offset = "0x6795960", VA = "0x186796F60", Slot = "13")]
	public void INMJPOOHJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6799E50", Offset = "0x6798850", VA = "0x186799E50", Slot = "14")]
	public void NAGAIKHGHCB(bool CFFJIANEKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x679C600", Offset = "0x679B000", VA = "0x18679C600", Slot = "22")]
	public Transform OKLNNKCAKHK(string OECDLIOPFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x678DDE0", Offset = "0x678C7E0", VA = "0x18678DDE0", Slot = "23")]
	public Vector3? AJJKAEJOKHM(string OECDLIOPFKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x67905D0", Offset = "0x678EFD0", VA = "0x1867905D0", Slot = "7")]
	public void DAHBHDKGNEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x678D160", Offset = "0x678BB60", VA = "0x18678D160", Slot = "6")]
	public void AGIBJKFKDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6798D30", Offset = "0x6797730", VA = "0x186798D30", Slot = "8")]
	public void KKNGPHKJFCF(float INJKGFHHFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6793880", Offset = "0x6792280", VA = "0x186793880")]
	private void GLKNKPHBPKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6795AA0", Offset = "0x67944A0", VA = "0x186795AA0", Slot = "4")]
	public void INLBNAINOFL(PPHKJMDKKGL LMHCANAKOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6797520", Offset = "0x6795F20", VA = "0x186797520", Slot = "5")]
	public void JHHHHHAKOPI(DKMICAFEOAL JNBHMGOHIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x67931B0", Offset = "0x6791BB0", VA = "0x1867931B0", Slot = "11")]
	public void FCBOMMMDEGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6797DE0", Offset = "0x67967E0", VA = "0x186797DE0", Slot = "21")]
	public void JOPJILBDMBM([Out] Vector3 LOIFAIEFDNM, [Out] Quaternion CFNNJJHJEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x678D130", Offset = "0x678BB30", VA = "0x18678D130")]
	private void AEMIEHCCLMB([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6798C80", Offset = "0x6797680", VA = "0x186798C80", Slot = "24")]
	public void KJPHHEBHIBL(float KEGNFOFLBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x678EBE0", Offset = "0x678D5E0", VA = "0x18678EBE0", Slot = "25")]
	public HandLogicOffsets AMEKMCACKCM()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6791940", Offset = "0x6790340", VA = "0x186791940", Slot = "26")]
	public PlatformSpecificPlayerHandOffsets DOJFBLHFLNE()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x67932A0", Offset = "0x6791CA0", VA = "0x1867932A0")]
	private void FDMBEOCEDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6790C60", Offset = "0x678F660", VA = "0x186790C60")]
	private void DAOLEJAEAGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6793710", Offset = "0x6792110", VA = "0x186793710")]
	private void GALHFAGMOCO(HMIKMKPGKPD BECLILGMONA, bool OLBIGMEKFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6791070", Offset = "0x678FA70", VA = "0x186791070")]
	private void DBEJKEPFAFG(HMIKMKPGKPD BECLILGMONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6798F60", Offset = "0x6797960", VA = "0x186798F60")]
	public Vector3 LGLFKEKKPGC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67998A0", Offset = "0x67982A0", VA = "0x1867998A0")]
	private void LOLOFFNCLAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67999F0", Offset = "0x67983F0", VA = "0x1867999F0")]
	private void MBCGFPOBGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6799AF0", Offset = "0x67984F0", VA = "0x186799AF0")]
	private float MGMMPCKEADM([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67942A0", Offset = "0x6792CA0", VA = "0x1867942A0")]
	private int HBLGKFPOMHM([In] JKFEBJECJCA JFJANFPMIAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x679A140", Offset = "0x6798B40", VA = "0x18679A140")]
	private void NFBFAPODEPB(OFIEPFIPJJG BNCNFFAMOGA, bool EJOJJNOLJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6799680", Offset = "0x6798080", VA = "0x186799680")]
	private static void LIODPNJDLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x678DF70", Offset = "0x678C970", VA = "0x18678DF70")]
	private static void ALGPHDDDHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67934B0", Offset = "0x6791EB0", VA = "0x1867934B0")]
	private float FKKKNJDINPJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6798D00", Offset = "0x6797700", VA = "0x186798D00")]
	private static int KKHLPHKMKNB(KPBANONNHON FKJLOGAHGLJ, KPBANONNHON MJMNBMLJKJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x679D3D0", Offset = "0x679BDD0", VA = "0x18679D3D0")]
	private void PPHMBDMEKBN(OFIEPFIPJJG FAKDNFCMPPB, AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x679CC10", Offset = "0x679B610", VA = "0x18679CC10")]
	private float PAHPNMCJNJH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6794380", Offset = "0x6792D80", VA = "0x186794380")]
	private void HEHCHGLJDHO([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67981B0", Offset = "0x6796BB0", VA = "0x1867981B0")]
	private void KEOFAJPBALN([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6792BF0", Offset = "0x67915F0", VA = "0x186792BF0")]
	private void FBNPNIOBFJM([In] OFIEPFIPJJG FAKDNFCMPPB, [In] AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x67994D0", Offset = "0x6797ED0", VA = "0x1867994D0")]
	private void LHKBANNPHAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6794ED0", Offset = "0x67938D0", VA = "0x186794ED0")]
	private void HMPFLEADFMN([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6792960", Offset = "0x6791360", VA = "0x186792960")]
	private void EOEFOGGGGJC(NKHPFMMHFCP POHJPJHONJJ, IKSolverVR.Arm EEEMMHGLPCA, Transform AHPCKHIEPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6792260", Offset = "0x6790C60", VA = "0x186792260")]
	private float EIFABFLFBCH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x67922E0", Offset = "0x6790CE0", VA = "0x1867922E0")]
	private void EIIPIHMBHHP([In] OFIEPFIPJJG FAKDNFCMPPB, [In] AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x67947B0", Offset = "0x67931B0", VA = "0x1867947B0", Slot = "33")]
	protected virtual void HEJAKGPDIFD([In] OFIEPFIPJJG FAKDNFCMPPB, [In] AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x679CDB0", Offset = "0x679B7B0", VA = "0x18679CDB0")]
	private void PJINGLMBMHE([In] OFIEPFIPJJG FAKDNFCMPPB, [In] FMEFCMMOCBJ BGCCIFJLFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x67915F0", Offset = "0x678FFF0", VA = "0x1867915F0")]
	private void DHBIMIDEIAB(OFIEPFIPJJG FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6792940", Offset = "0x6791340", VA = "0x186792940")]
	private void EMHOEBPEBDK(FPLGNCNMHEJ MHJKLCILBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x679AF20", Offset = "0x6799920", VA = "0x18679AF20")]
	private void OFNNOKMBHDG(float BLIIOFFCPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x678F3F0", Offset = "0x678DDF0", VA = "0x18678F3F0")]
	private void CAPEOIGILBO([In] OFIEPFIPJJG FAKDNFCMPPB, FMEFCMMOCBJ BGCCIFJLFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x679C750", Offset = "0x679B150", VA = "0x18679C750")]
	private Vector3 OKPHDCMNEMH([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x679AD70", Offset = "0x6799770", VA = "0x18679AD70")]
	private void NHELHLJDDJL([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6791200", Offset = "0x678FC00", VA = "0x186791200")]
	private float DDKLGLPGNCM(float BENNBNECEPO, [In] OFIEPFIPJJG FAKDNFCMPPB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x678EC90", Offset = "0x678D690", VA = "0x18678EC90")]
	private void BBBMKJBMMNM(FPLGNCNMHEJ MHJKLCILBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6797250", Offset = "0x6795C50", VA = "0x186797250")]
	private void IOOHEILBOKB(float BENNBNECEPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x678FF60", Offset = "0x678E960", VA = "0x18678FF60")]
	private void CKMKADAKFBP([In] OFIEPFIPJJG FAKDNFCMPPB, FMEFCMMOCBJ BGCCIFJLFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6794AC0", Offset = "0x67934C0", VA = "0x186794AC0")]
	private float HFAAGAPHJHG([In] OFIEPFIPJJG BNCNFFAMOGA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6798FB0", Offset = "0x67979B0", VA = "0x186798FB0")]
	private void LHFFJMJGPPC(OFIEPFIPJJG FAKDNFCMPPB, FMEFCMMOCBJ BGCCIFJLFIJ, Vector3 AKNKPDDHELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x67950E0", Offset = "0x6793AE0", VA = "0x1867950E0")]
	private static void IAJMEGFFAOD(Transform OFGHBAGNEDJ, Quaternion NGGFFKDNCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x678F0F0", Offset = "0x678DAF0", VA = "0x18678F0F0")]
	private void BOPBFKDJJPD([In] OFIEPFIPJJG NKEPOGKPILI, [In] JKFEBJECJCA JFJANFPMIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x679A670", Offset = "0x6799070", VA = "0x18679A670")]
	private void NFFKFDICDEH([In] OFIEPFIPJJG NKEPOGKPILI, [In] JKFEBJECJCA JFJANFPMIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6793360", Offset = "0x6791D60", VA = "0x186793360")]
	public void FGIGDLAAOJG([In] OFIEPFIPJJG FAKDNFCMPPB, [In] AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67938D0", Offset = "0x67922D0", VA = "0x1867938D0")]
	private void GNOBFOLKDIL([In] OFIEPFIPJJG FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x678FDB0", Offset = "0x678E7B0", VA = "0x18678FDB0")]
	private void CJIFLPBNOME(float MBOABFNIOMJ, [In] OFIEPFIPJJG BNCNFFAMOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6795290", Offset = "0x6793C90", VA = "0x186795290")]
	private float IAMKCADHIDE([In] OFIEPFIPJJG BNCNFFAMOGA, [In] AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6793C00", Offset = "0x6792600", VA = "0x186793C00")]
	private void GOJGNKBDGEF([In] OFIEPFIPJJG BNCNFFAMOGA, [In] AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6791BB0", Offset = "0x67905B0", VA = "0x186791BB0")]
	private void EGDJEHJDLKH([In] OFIEPFIPJJG BNCNFFAMOGA, float IHPCDJFCIJF, float LKBJKIOALGA, Vector3 PCIMEHIADJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6798480", Offset = "0x6796E80", VA = "0x186798480")]
	private void KHHGBKKENIN(OFIEPFIPJJG BNCNFFAMOGA, AvatarFullBodyConfiguration FBFDHBHFJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6794FE0", Offset = "0x67939E0", VA = "0x186794FE0")]
	[CompilerGenerated]
	internal static bool HNDJPLHENDL(IKSolverVR.Arm EEEMMHGLPCA, BKKMILPIPCA ACGEPKKMOAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x678ECB0", Offset = "0x678D6B0", VA = "0x18678ECB0")]
	[CompilerGenerated]
	internal static float BHBBOBAKPNG(Vector3 LDJCJDIEAHH, Vector3 HENLJDIEDOI, Vector3 PCEFGPJGEID, OFIEPFIPJJG BNCNFFAMOGA, AvatarFullBodyConfiguration FBFDHBHFJCB, float LJEHDHLGGJA)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public enum MJBGBIAEGLD
		{
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private MJBGBIAEGLD handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[FormerlySerializedAs("color")]
		[SerializeField]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6787C40", Offset = "0x6786640", VA = "0x186787C40")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6787C00", Offset = "0x6786600", VA = "0x186787C00")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x67875D0", Offset = "0x6785FD0", VA = "0x1867875D0")]
		private void BFBLCABLKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x674EFD0", Offset = "0x674D9D0", VA = "0x18674EFD0", Slot = "4")]
		public void SetEnabled(bool OPDIOPBPNGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6787C70", Offset = "0x6786670", VA = "0x186787C70")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarKneeBendTargetController : MonoBehaviour, JKJNNLGEJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		[GBAJCKFHNAK(MJDOLBEDPIO.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Vector3 IGBEDMAACLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private Vector3 LFCFJGGOKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private Vector3 IAANPFHEEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private Matrix4x4 OPNADPKMCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private bool DHNIHOFNGIK;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6788110", Offset = "0x6786B10", VA = "0x186788110", Slot = "4")]
		public void UpdateController(float ECCGJGJKLJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6788100", Offset = "0x6786B00", VA = "0x186788100", Slot = "6")]
		public void SetEnabled(bool DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6787CA0", Offset = "0x67866A0", VA = "0x186787CA0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x67887D0", Offset = "0x67871D0", VA = "0x1867887D0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Preserve]
internal class PCCBCFGCGFC : AANAOGHGNKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Dictionary<string, FAPOOABIGOE> JOABBPIOMEJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool JOCBJMPCINF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x67A0F50", Offset = "0x679F950", VA = "0x1867A0F50")]
	[MHFEIEAPENL(ABEEEPGJOJM.Root, CMFCLNIIIKO.None)]
	private static void DKDJOHOCNLH(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x67A1140", Offset = "0x679FB40", VA = "0x1867A1140", Slot = "4")]
	public FAPOOABIGOE NFFJFLHDPMA(string BEHODGENJFG, AvatarSystemConfiguration LBAJEDNDPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x67A0FC0", Offset = "0x679F9C0", VA = "0x1867A0FC0", Slot = "5")]
	public void EEMPGCJBABP(string BEHODGENJFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x67A1300", Offset = "0x679FD00", VA = "0x1867A1300")]
	public PCCBCFGCGFC()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class HGCDDEOKCPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private Dictionary<string, Transform> AGPLDIBMOGI;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			public bool DJEJGGIOHNN
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0x678ADA0", Offset = "0x67897A0", VA = "0x18678ADA0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x678ADE0", Offset = "0x67897E0", VA = "0x18678ADE0")]
			public void PHLNEKGAOCK(VRIK NIKKHIDPCON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50")]
			public void NJBDJHMNAJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x678AD50", Offset = "0x6789750", VA = "0x18678AD50")]
			public void GLMNPCAHJLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x678AF10", Offset = "0x6789910", VA = "0x18678AF10")]
			public HGCDDEOKCPH()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000161")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		[GAAOMKKOEKA(MJDOLBEDPIO.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[GBAJCKFHNAK(MJDOLBEDPIO.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly HGCDDEOKCPH OIGMPEOHMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private KLAEPMLEANI IOGGHGHKKMD;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6788830", Offset = "0x6787230", VA = "0x186788830")]
		private void CCPNKNOIBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x67887E0", Offset = "0x67871E0", VA = "0x1867887E0")]
		private bool BHKBPNGCPFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6788AF0", Offset = "0x67874F0", VA = "0x186788AF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6788B60", Offset = "0x6787560", VA = "0x186788B60")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6788B00", Offset = "0x6787500", VA = "0x186788B00")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6788D50", Offset = "0x6787750", VA = "0x186788D50")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x679EF10", Offset = "0x679D910", VA = "0x18679EF10", Slot = "4")]
		public override void OnStateEnter(Animator IGKLHNAAJIJ, AnimatorStateInfo OGFCBGAFMKL, int MHEENDJCNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x679F080", Offset = "0x679DA80", VA = "0x18679F080")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal abstract class LFHJAGJPCIO<TInput, TOutput> : CEFHEPEMHIF<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	protected readonly OLPJGLPPFIJ LPIGFFIELAK;

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4282D00", Offset = "0x4281700", VA = "0x184282D00")]
	protected LFHJAGJPCIO(OLPJGLPPFIJ LPIGFFIELAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput FIOJCIMJMME(TInput CGAJJAALELM, [Out] IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4282C60", Offset = "0x4281660", VA = "0x184282C60", Slot = "5")]
	public bool HKENCDKFLPJ(TInput CGAJJAALELM, [Out] TOutput? EBPHIJANMPN, [Out] IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[FABAIOIDLJO]
public static class CHECKBLINJA
{
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static readonly Regex NADOFPCAEDJ;

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6789030", Offset = "0x6787A30", VA = "0x186789030")]
	public static PCPEIICFLOP KNADGCJFNFE(GBHMJLHNKHN DFJBPKIEKMC, OMEPBNMDOOI JCKBAHHFKIF, Guid? AFOPNMBEAOM, Color? ICNAECANBHK, INEMDIPNFNK JBINPCPMLJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6788F80", Offset = "0x6787980", VA = "0x186788F80")]
	public static ONCNPAAFPAJ GFKPMKLCMBH(PCPEIICFLOP EEOBDBMOHPL)
	{
		return default(ONCNPAAFPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x292F140", Offset = "0x292DB40", VA = "0x18292F140")]
	internal static TModern? FOPGFIHJOFM<TModern>(string? CGAJJAALELM, JJLKMNEMLLL<TModern> BHCJKIJOFGE, OLPJGLPPFIJ LPIGFFIELAK, KIPGLPCEJIB GDIKMAHGOLO, TModern GCKEEIJFOAI) where TModern : struct, MIPPIMJAJNA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2930780", Offset = "0x292F180", VA = "0x182930780")]
	internal static GNEHILEKNAL MOPLCEHAODN<TModern>(string? CGAJJAALELM, JJLKMNEMLLL<TModern> BHCJKIJOFGE, OLPJGLPPFIJ LPIGFFIELAK, KIPGLPCEJIB GDIKMAHGOLO, TModern GCKEEIJFOAI) where TModern : struct, MIPPIMJAJNA
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6788E30", Offset = "0x6787830", VA = "0x186788E30")]
	internal static List<AMFBJJFGIGL> CIDKFGNPCBE(IEnumerable<JOGAKBPIOFN>? HKAPCPLPFMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2930F90", Offset = "0x292F990", VA = "0x182930F90")]
	internal static string OPEMBAJOANL<TModern>(TModern CGAJJAALELM, JJLKMNEMLLL<TModern> BHCJKIJOFGE, OLPJGLPPFIJ LPIGFFIELAK) where TModern : MIPPIMJAJNA
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal class JKGGDGOECHM : KLPEJMDPNBN
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CEFHEPEMHIF<ALKCDDCCMFA, ALDBLMAPDHF> JOLJLJJILIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public CEFHEPEMHIF<KGBMONFGDHD, NCMDMPFPOCI> OAHEANENNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CEFHEPEMHIF<KGBMONFGDHD, NCMDMPFPOCI> FECMFJNAOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x850E50", Offset = "0x84F850", VA = "0x180850E50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BIJJAEKOOEE KBCNNLJOBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x84EC50", Offset = "0x84D650", VA = "0x18084EC50", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HILHDCFMJAL GODAJLHACJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x678CAB0", Offset = "0x678B4B0", VA = "0x18678CAB0")]
	[MHFEIEAPENL(ABEEEPGJOJM.Root, CMFCLNIIIKO.GameOnly)]
	[UsedImplicitly]
	private static void MCCHBBNBCLB(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x678CB20", Offset = "0x678B520", VA = "0x18678CB20")]
	[Preserve]
	internal JKGGDGOECHM([OHLKLPAILPF("UnitySerialization")] HFGKEHKCDPO JMAMPNELNEK, [OHLKLPAILPF(null)] BPFFNPJOOHC LFAAEHJEHCF, [OHLKLPAILPF(null)] OLPJGLPPFIJ LPIGFFIELAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum DGMDEFPABNI
{
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BJKCJCBEJJD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x67A2D00", Offset = "0x67A1700", VA = "0x1867A2D00")]
	public BJKCJCBEJJD(string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x67A2D30", Offset = "0x67A1730", VA = "0x1867A2D30")]
	public BJKCJCBEJJD(string BDCMABOIIFF, Exception GOOPONCNKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x67A2CD0", Offset = "0x67A16D0", VA = "0x1867A2CD0")]
	public BJKCJCBEJJD(DGMDEFPABNI KIPEDCEMNBN, string BDCMABOIIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x67A2D60", Offset = "0x67A1760", VA = "0x1867A2D60")]
	public BJKCJCBEJJD(DGMDEFPABNI KIPEDCEMNBN, string BDCMABOIIFF, Exception GOOPONCNKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal abstract class LEIHLNFKINK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly HFGKEHKCDPO JMAMPNELNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly BPFFNPJOOHC LFAAEHJEHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected readonly OLPJGLPPFIJ LPIGFFIELAK;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x67A2120", Offset = "0x67A0B20", VA = "0x1867A2120")]
	protected LEIHLNFKINK(HFGKEHKCDPO JMAMPNELNEK, BPFFNPJOOHC LFAAEHJEHCF, OLPJGLPPFIJ LPIGFFIELAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x67A8570", Offset = "0x67A6F70", VA = "0x1867A8570")]
	protected string PCKBGAKIIEN(ALDBLMAPDHF CGJOCNEAIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x67A7EE0", Offset = "0x67A68E0", VA = "0x1867A7EE0")]
	protected string COHKMCCHCDK(ALDBLMAPDHF CGJOCNEAIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x67A8200", Offset = "0x67A6C00", VA = "0x1867A8200")]
	private AvatarOutfitSelectionData KNADGCJFNFE(PCPEIICFLOP GCKCINOMOCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x67A80C0", Offset = "0x67A6AC0", VA = "0x1867A80C0")]
	private static AvatarCustomizationSettingsData.AnchorParams ELLMMDNOMNH(IFEDJPPADLJ? KAEFKFCFOGK)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface CEFHEPEMHIF<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput FIOJCIMJMME(TInput CGAJJAALELM, [Out] IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKENCDKFLPJ(TInput CGAJJAALELM, [Out] TOutput? EBPHIJANMPN, [Out] IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KLPEJMDPNBN
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CEFHEPEMHIF<ALKCDDCCMFA, ALDBLMAPDHF> JOLJLJJILIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	CEFHEPEMHIF<KGBMONFGDHD, NCMDMPFPOCI> FECMFJNAOGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	BIJJAEKOOEE KBCNNLJOBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal enum KIPGLPCEJIB
{
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface HILHDCFMJAL
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CGIALAOAPNO KJCBMOAEMAH(ALDBLMAPDHF EEOBDBMOHPL);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface BIJJAEKOOEE
{
	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KGBMONFGDHD KJCBMOAEMAH(ALDBLMAPDHF EEOBDBMOHPL, int OGJAALGODGH, string? CCMEKJGADHN, string? JDDGHDDMMED, AHOFOGFBAHD NMLLEEDBKBP, List<AMFBJJFGIGL>? LEBGMIOOAPF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[FABAIOIDLJO]
internal class ABBABPJBAFB : LFHJAGJPCIO<ALKCDDCCMFA, ALDBLMAPDHF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly BPFFNPJOOHC LFAAEHJEHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly LDOLMFPBIOA OGKMGAKMBBI;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67A17E0", Offset = "0x67A01E0", VA = "0x1867A17E0")]
	public ABBABPJBAFB(HFGKEHKCDPO JMAMPNELNEK, BPFFNPJOOHC LFAAEHJEHCF, OLPJGLPPFIJ LPIGFFIELAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67A1530", Offset = "0x679FF30", VA = "0x1867A1530", Slot = "6")]
	public override ALDBLMAPDHF FIOJCIMJMME(ALKCDDCCMFA CGAJJAALELM, [Out] IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Preserve]
internal class KJCPHFEIDOP : HFGKEHKCDPO
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class KLBJCBCHJLB : JsonConverter<GNEHILEKNAL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x67A57E0", Offset = "0x67A41E0", VA = "0x1867A57E0", Slot = "9")]
		public override void WriteJson(JsonWriter AACOMNCLNFJ, GNEHILEKNAL? DBOBEHLEAAE, JsonSerializer GLLAODOIGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x67A56C0", Offset = "0x67A40C0", VA = "0x1867A56C0", Slot = "10")]
		public override GNEHILEKNAL ReadJson(JsonReader DGAMLJBEAIK, Type OKFFBBDMJCF, GNEHILEKNAL? AKINJDJPGCM, bool NKIFFNLFHGA, JsonSerializer GLLAODOIGMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x67A5880", Offset = "0x67A4280", VA = "0x1867A5880")]
		public KLBJCBCHJLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class CCMFELGNPOI : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool AAFILBKMOKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x67A3180", Offset = "0x67A1B80", VA = "0x1867A3180", Slot = "5")]
		public override object ReadJson(JsonReader DGAMLJBEAIK, Type OKFFBBDMJCF, object? AKINJDJPGCM, JsonSerializer GLLAODOIGMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x67A2DA0", Offset = "0x67A17A0", VA = "0x1867A2DA0", Slot = "6")]
		public override bool CanConvert(Type OKFFBBDMJCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x67A31E0", Offset = "0x67A1BE0", VA = "0x1867A31E0", Slot = "4")]
		public override void WriteJson(JsonWriter AACOMNCLNFJ, object? DBOBEHLEAAE, JsonSerializer GLLAODOIGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x67A2F80", Offset = "0x67A1980", VA = "0x1867A2F80")]
		private static bool NHOMMMEAKAE(object DBOBEHLEAAE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
		public CCMFELGNPOI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly JsonSerializerSettings PCAMAJPEHPD;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x67A5560", Offset = "0x67A3F60", VA = "0x1867A5560")]
	internal KJCPHFEIDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9BA0", Offset = "0x2BB85A0", VA = "0x182BB9BA0", Slot = "4")]
	public string HGPACGBFGJL<T>(T GKHPLGCJCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2BB9B10", Offset = "0x2BB8510", VA = "0x182BB9B10", Slot = "5")]
	public T FAMGHNDBEGF<T>(string DBOBEHLEAAE)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class PAHBBEEKFNH : HFGKEHKCDPO
{
	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0340", Offset = "0x2CCED40", VA = "0x182CD0340", Slot = "4")]
	public string HGPACGBFGJL<T>(T GKHPLGCJCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD02C0", Offset = "0x2CCECC0", VA = "0x182CD02C0", Slot = "5")]
	public T FAMGHNDBEGF<T>(string DBOBEHLEAAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
	public PAHBBEEKFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[FABAIOIDLJO]
internal class LDOLMFPBIOA : LFHJAGJPCIO<KGBMONFGDHD, NCMDMPFPOCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly HFGKEHKCDPO JMAMPNELNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly BPFFNPJOOHC LFAAEHJEHCF;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x67A7DA0", Offset = "0x67A67A0", VA = "0x1867A7DA0")]
	public LDOLMFPBIOA(HFGKEHKCDPO JMAMPNELNEK, BPFFNPJOOHC LFAAEHJEHCF, OLPJGLPPFIJ LPIGFFIELAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67A6780", Offset = "0x67A5180", VA = "0x1867A6780", Slot = "6")]
	public override NCMDMPFPOCI FIOJCIMJMME(KGBMONFGDHD CGAJJAALELM, [Out] IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x67A77E0", Offset = "0x67A61E0", VA = "0x1867A77E0")]
	internal void KKCAGIHPBOO(string IEMIFKDENEJ, ALDBLMAPDHF CGJOCNEAIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x67A6BB0", Offset = "0x67A55B0", VA = "0x1867A6BB0")]
	public IEnumerable<PCPEIICFLOP> HNPGCOLBPBI(string ICAFBOPNKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x67A6000", Offset = "0x67A4A00", VA = "0x1867A6000")]
	private IEnumerable<PCPEIICFLOP> DMANPHJFAEE(string ICAFBOPNKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x67A7930", Offset = "0x67A6330", VA = "0x1867A7930")]
	internal IEnumerable<PCPEIICFLOP> OFCOBJMFDEF(string ICAFBOPNKHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x67A58C0", Offset = "0x67A42C0", VA = "0x1867A58C0")]
	private PCPEIICFLOP AENEHAOOCFO(AvatarOutfitSelectionData MAMNIOABFGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x67A6F40", Offset = "0x67A5940", VA = "0x1867A6F40")]
	private void KGOJNKJJEPL(AvatarCustomizationSettingsData PONIDMBKDEA, ALDBLMAPDHF CGJOCNEAIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x67A5C90", Offset = "0x67A4690", VA = "0x1867A5C90")]
	private PCPEIICFLOP AENEHAOOCFO(string FMFOFOIEFJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x67A6C60", Offset = "0x67A5660", VA = "0x1867A6C60")]
	internal static (INEMDIPNFNK, string, string) IHNFNNDMHHE(string FMFOFOIEFJG, OLPJGLPPFIJ LPIGFFIELAK)
	{
		return default((INEMDIPNFNK, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x67A6580", Offset = "0x67A4F80", VA = "0x1867A6580")]
	private GKEPNIODDKM? FEOPMBCMNKG(string? JCMDDLFAGEN, Vector2 NOCCMNBAPEG, float KOPOBAJPPLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x67A6420", Offset = "0x67A4E20", VA = "0x1867A6420")]
	private static IFEDJPPADLJ EFAHGAFMJCK(AvatarCustomizationSettingsData.AnchorParams MDFBOLPPGON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[FABAIOIDLJO]
internal class AJGIAEJHDDG : LEIHLNFKINK, HILHDCFMJAL
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x67A2120", Offset = "0x67A0B20", VA = "0x1867A2120")]
	public AJGIAEJHDDG(HFGKEHKCDPO JMAMPNELNEK, BPFFNPJOOHC LFAAEHJEHCF, OLPJGLPPFIJ LPIGFFIELAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x67A1C70", Offset = "0x67A0670", VA = "0x1867A1C70", Slot = "4")]
	public CGIALAOAPNO KJCBMOAEMAH(ALDBLMAPDHF EEOBDBMOHPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x67A2020", Offset = "0x67A0A20", VA = "0x1867A2020")]
	private string MHJHBPMJMLB(ALDBLMAPDHF CGJOCNEAIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x67A19B0", Offset = "0x67A03B0", VA = "0x1867A19B0")]
	private string GHFDODGPKFF(PCPEIICFLOP GCKCINOMOCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[FABAIOIDLJO]
internal class JMPEGIHKLCI : LFHJAGJPCIO<KGBMONFGDHD, NCMDMPFPOCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly HFGKEHKCDPO JMAMPNELNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly CEFHEPEMHIF<KGBMONFGDHD, NCMDMPFPOCI> AIHMAOICDPF;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x67A36F0", Offset = "0x67A20F0", VA = "0x1867A36F0")]
	public JMPEGIHKLCI(CEFHEPEMHIF<KGBMONFGDHD, NCMDMPFPOCI> AIHMAOICDPF, OLPJGLPPFIJ LPIGFFIELAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x67A32C0", Offset = "0x67A1CC0", VA = "0x1867A32C0", Slot = "6")]
	public override NCMDMPFPOCI FIOJCIMJMME(KGBMONFGDHD CGAJJAALELM, [Out] IReadOnlyList<AMFBJJFGIGL>? LEBGMIOOAPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[FABAIOIDLJO]
internal class MKDKDOIBGFG : BIJJAEKOOEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly HFGKEHKCDPO JMAMPNELNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private readonly HILHDCFMJAL NFHKHOLAIFO;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x67A9C30", Offset = "0x67A8630", VA = "0x1867A9C30")]
	public MKDKDOIBGFG(HILHDCFMJAL NFHKHOLAIFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x67A9890", Offset = "0x67A8290", VA = "0x1867A9890", Slot = "4")]
	public KGBMONFGDHD KJCBMOAEMAH(ALDBLMAPDHF EEOBDBMOHPL, int OGJAALGODGH, string? CCMEKJGADHN, string? JDDGHDDMMED, AHOFOGFBAHD NMLLEEDBKBP, List<AMFBJJFGIGL>? LEBGMIOOAPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[Preserve]
internal class KFHNNPHEBPD : GODGGHEMKPA
{
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly Vector2 BOGNINHPHKG;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static readonly Vector2 CEAANHGPBKO;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly Vector2 FOPDIHMLNNB;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly Vector2 ONGOPKEKNMN;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly Vector2 MJNAADGCIGF;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly Vector2 FJCLLFFGFBG;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly Vector2 IBGKFBNOJMI;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static readonly Vector2 FINAJENBLDE;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static readonly Vector2 KKOFLOJPFKF;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static readonly Vector2 BOBBHPAIGML;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly Vector2 FBGOLLDGBGN;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static readonly Vector2 CDJIIIMGCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private Dictionary<BOPNNGIGHPK, AvatarConfiguration> MGHFPIMADHC;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x67A4370", Offset = "0x67A2D70", VA = "0x1867A4370")]
	[MHFEIEAPENL(ABEEEPGJOJM.Root, CMFCLNIIIKO.None)]
	private static void KFKHDEGBDCL(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x67A54B0", Offset = "0x67A3EB0", VA = "0x1867A54B0")]
	[Preserve]
	internal KFHNNPHEBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x67A4150", Offset = "0x67A2B50", VA = "0x1867A4150", Slot = "4")]
	public Vector2 ILFLOFEFDIN(FaceFeatureType MHPJECMOEDF, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x67A46D0", Offset = "0x67A30D0", VA = "0x1867A46D0", Slot = "5")]
	public float MDKKECEGAAF(FaceFeatureType MHPJECMOEDF, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x67A4540", Offset = "0x67A2F40", VA = "0x1867A4540", Slot = "6")]
	public void LBNLPNKMAJG(BOPNNGIGHPK PCDNHANKBKL, AvatarConfiguration LBAJEDNDPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x67A3A10", Offset = "0x67A2410", VA = "0x1867A3A10", Slot = "7")]
	public float ANIBEBFPKFH(FaceFeatureType MMNNNGBLLJC, float IPMNNGLJIIP, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x67A40A0", Offset = "0x67A2AA0", VA = "0x1867A40A0", Slot = "8")]
	public float HFBONKICLNI(FaceFeatureType MMNNNGBLLJC, float KOPOBAJPPLK, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x67A4D60", Offset = "0x67A3760", VA = "0x1867A4D60", Slot = "10")]
	public Vector2 PKHLDBFCJKH(FaceFeatureType MMNNNGBLLJC, Vector2 JHHDJGIFBGA, Vector2 JJKDLOGPPAG, Vector2 HEIOEDNANOF, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67A4B30", Offset = "0x67A3530", VA = "0x1867A4B30", Slot = "9")]
	public Vector2 PJMOEFGGJIC(FaceFeatureType MMNNNGBLLJC, Vector2 GJGJEGIJCGC, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x67A37F0", Offset = "0x67A21F0", VA = "0x1867A37F0")]
	private Vector2 ABKJKIMHGAM(FaceFeatureType MMNNNGBLLJC, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x67A4750", Offset = "0x67A3150", VA = "0x1867A4750")]
	private Vector2 NHKBOIKJPCD(FaceFeatureType MMNNNGBLLJC, Vector2 JHHDJGIFBGA, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x67A4F10", Offset = "0x67A3910", VA = "0x1867A4F10", Slot = "11")]
	public Vector2 PKMLJOGBAGH(FaceFeatureType MMNNNGBLLJC, Vector2 GJGJEGIJCGC, Vector2 JJKDLOGPPAG, Vector2 HEIOEDNANOF, BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x67A4AA0", Offset = "0x67A34A0", VA = "0x1867A4AA0")]
	private float PENCJKMNGOM(float MJGGCDOBPLJ, float NFEEPMFGNGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x67A3990", Offset = "0x67A2390", VA = "0x1867A3990")]
	private Vector2 AEGNPKBAFBC(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x67A3890", Offset = "0x67A2290", VA = "0x1867A3890")]
	private Vector2 ABNLAJGAMCA(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x67A3910", Offset = "0x67A2310", VA = "0x1867A3910")]
	private Vector2 ACCDJDNILEL(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x67A40D0", Offset = "0x67A2AD0", VA = "0x1867A40D0")]
	private Vector2 HOLHKHCLGFP(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x67A48A0", Offset = "0x67A32A0", VA = "0x1867A48A0")]
	private float NKKHKDPOGIE(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x67A45B0", Offset = "0x67A2FB0", VA = "0x1867A45B0")]
	private float MAEMNHAMKLI(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x67A3B20", Offset = "0x67A2520", VA = "0x1867A3B20")]
	private float BMDNHCMACGK(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x67A3EC0", Offset = "0x67A28C0", VA = "0x1867A3EC0")]
	private float FFLLJIMBPHG(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x67A3A40", Offset = "0x67A2440", VA = "0x1867A3A40")]
	private Vector2 BCJAKFBHMGJ(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x67A4460", Offset = "0x67A2E60", VA = "0x1867A4460")]
	private Vector2 KOHLHHMMBMD(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67A48E0", Offset = "0x67A32E0", VA = "0x1867A48E0")]
	private Vector2 OHHKKHOOMDJ(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x67A3B60", Offset = "0x67A2560", VA = "0x1867A3B60")]
	private Vector2 CJOKFMGKKAC(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x67A3D20", Offset = "0x67A2720", VA = "0x1867A3D20")]
	private Vector2 EELOIDFBHGB(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x67A3C40", Offset = "0x67A2640", VA = "0x1867A3C40")]
	private Vector2 DNBDIEIGOMM(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x67A49C0", Offset = "0x67A33C0", VA = "0x1867A49C0")]
	private Vector2 PDHBJKKNOHM(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x67A45F0", Offset = "0x67A2FF0", VA = "0x1867A45F0")]
	private Vector2 MAKMNMGNNOL(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x67A3F00", Offset = "0x67A2900", VA = "0x1867A3F00")]
	private Vector2 GHDKOABAMKF(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x67A3FE0", Offset = "0x67A29E0", VA = "0x1867A3FE0")]
	private Vector2 GNHKAGGLCIL(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x67A42B0", Offset = "0x67A2CB0", VA = "0x1867A42B0")]
	private Vector2 KCFELGJCMPG(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x67A3E00", Offset = "0x67A2800", VA = "0x1867A3E00")]
	private Vector2 EKIJAONKIJC(BOPNNGIGHPK PCDNHANKBKL)
	{
		return default(Vector2);
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
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x67A2350", Offset = "0x67A0D50", VA = "0x1867A2350")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NLHCHBPICBN
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x67A9D90", Offset = "0x67A8790", VA = "0x1867A9D90")]
	public static ONCNPAAFPAJ FIOJCIMJMME(this NHBKAPILBKI EEOBDBMOHPL)
	{
		return default(ONCNPAAFPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x67AA010", Offset = "0x67A8A10", VA = "0x1867AA010")]
	public static NHBKAPILBKI KJCBMOAEMAH(this ONCNPAAFPAJ LAHPGCKABNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67A9D20", Offset = "0x67A8720", VA = "0x1867A9D20")]
	public static bool BHEKLMOHGOO(this ONCNPAAFPAJ LAHPGCKABNJ)
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
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x4C24210", Offset = "0x4C22C10", VA = "0x184C24210")]
			public AnchorParams(Vector2 JHHDJGIFBGA, Vector3 NIBKOJACNJI, Vector3 LNKFNOHIKGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x67A22A0", Offset = "0x67A0CA0", VA = "0x1867A22A0")]
			internal IFEDJPPADLJ KJCBMOAEMAH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private ACNMLCNKKGJ useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x67A2B70", Offset = "0x67A1570", VA = "0x1867A2B70")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x84EC00", Offset = "0x84D600", VA = "0x18084EC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x4282C40", Offset = "0x4281640", VA = "0x184282C40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x1064C00", Offset = "0x1063600", VA = "0x181064C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB80", Offset = "0x8BA580", VA = "0x1808BBB80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9C8C90", Offset = "0x9C7690", VA = "0x1809C8C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x84EEA0", Offset = "0x84D8A0", VA = "0x18084EEA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x850E60", Offset = "0x84F860", VA = "0x180850E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x67A2C20", Offset = "0x67A1620", VA = "0x1867A2C20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x858CF0", Offset = "0x8576F0", VA = "0x180858CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8BBB30", Offset = "0x8BA530", VA = "0x1808BBB30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x1079FA0", Offset = "0x10789A0", VA = "0x181079FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x84EEB0", Offset = "0x84D8B0", VA = "0x18084EEB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x84EC10", Offset = "0x84D610", VA = "0x18084EC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x67A2C60", Offset = "0x67A1660", VA = "0x1867A2C60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1C82CE0", Offset = "0x1C816E0", VA = "0x181C82CE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x8BC210", Offset = "0x8BAC10", VA = "0x1808BC210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xE807E0", Offset = "0xE7F1E0", VA = "0x180E807E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851270", VA = "0x180852870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851280", VA = "0x180852880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x41881C0", Offset = "0x4186BC0", VA = "0x1841881C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x1CACBA0", Offset = "0x1CAB5A0", VA = "0x181CACBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x882CA0", Offset = "0x8816A0", VA = "0x180882CA0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x882D00", Offset = "0x881700", VA = "0x180882D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x8550A0", Offset = "0x853AA0", VA = "0x1808550A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x855150", Offset = "0x853B50", VA = "0x180855150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8550D0", Offset = "0x853AD0", VA = "0x1808550D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x855130", Offset = "0x853B30", VA = "0x180855130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x855180", Offset = "0x853B80", VA = "0x180855180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x855040", Offset = "0x853A40", VA = "0x180855040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9EA650", Offset = "0x9E9050", VA = "0x1809EA650")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x9EA630", Offset = "0x9E9030", VA = "0x1809EA630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x855000", Offset = "0x853A00", VA = "0x180855000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x855020", Offset = "0x853A20", VA = "0x180855020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x9DD510", Offset = "0x9DBF10", VA = "0x1809DD510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9BC650", Offset = "0x9BB050", VA = "0x1809BC650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x85B620", Offset = "0x85A020", VA = "0x18085B620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x85B590", Offset = "0x859F90", VA = "0x18085B590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xB7E120", Offset = "0xB7CB20", VA = "0x180B7E120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xB860D0", Offset = "0xB84AD0", VA = "0x180B860D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA310F0", Offset = "0xA2FAF0", VA = "0x180A310F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xD10C60", Offset = "0xD0F660", VA = "0x180D10C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ACNMLCNKKGJ UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x1D481F0", Offset = "0x1D46BF0", VA = "0x181D481F0")]
			get
			{
				return default(ACNMLCNKKGJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x1D478B0", Offset = "0x1D462B0", VA = "0x181D478B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA608D0", Offset = "0xA5F2D0", VA = "0x180A608D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA61830", Offset = "0xA60230", VA = "0x180A61830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x67A2C40", Offset = "0x67A1640", VA = "0x1867A2C40")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x67A2C80", Offset = "0x67A1680", VA = "0x1867A2C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x67A27D0", Offset = "0x67A11D0", VA = "0x1867A27D0")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public INEMDIPNFNK BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private ODBFAAJEAMN? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x67A2CA0", Offset = "0x67A16A0", VA = "0x1867A2CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
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
