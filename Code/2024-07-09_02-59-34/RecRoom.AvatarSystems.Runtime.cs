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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68A7540", Offset = "0x68A6140", VA = "0x1868A7540")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[OCDDNNLBGPA]
internal class CKHIPBABOII : LNJLCHAAKFG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private struct GCPEKKIJCIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CKHIPBABOII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public KLACEAHOGOL avatarBodyType;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly PALCFNOLHKH MDDGAIFIOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DEOGEBNANBE KCOGKHANMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JPLAALBLNCN MMLKDPDIIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly CMLDGCDNBOD KKBKEHBJBHF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x688F7F0", Offset = "0x688E3F0", VA = "0x18688F7F0")]
	[DHOHFCLMOGD(OBGPNJNCONH.Root, IDHBAGABJJA.GameOnly)]
	[UsedImplicitly]
	private static void IOMJOEFGMKK(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x688FBC0", Offset = "0x688E7C0", VA = "0x18688FBC0")]
	[Preserve]
	internal CKHIPBABOII([POJODGKFIMO(null)] PALCFNOLHKH MDDGAIFIOKD, [POJODGKFIMO(null)] DEOGEBNANBE KCOGKHANMPM, [POJODGKFIMO(null)] JPLAALBLNCN MMLKDPDIIDD, [POJODGKFIMO(null)] CMLDGCDNBOD KKBKEHBJBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x688F060", Offset = "0x688DC60", VA = "0x18688F060", Slot = "5")]
	public HKEEHAKOMGN IHDFBIGMBGL(bool EOINDNHPGMC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x688E550", Offset = "0x688D150", VA = "0x18688E550", Slot = "4")]
	public HKEEHAKOMGN BBMPAMAOJNJ(bool EOINDNHPGMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x688E440", Offset = "0x688D040", VA = "0x18688E440", Slot = "6")]
	public NEFICIJOBBJ AJGJCJJNKOL(HKEEHAKOMGN JGFKFMMOAJO, int HLLGOLOIKLA, string? LONKACOOPGJ, string? AGFPEFFNOBC, EMCFGHOJEPP NKOJACBBKBN, List<PIGNFJGILAH>? PAJMHKCIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x688EEF0", Offset = "0x688DAF0", VA = "0x18688EEF0", Slot = "7")]
	public bool CLBIIPKHIPD(IGAHDNPAOAH BNJPDANCNKG, [Out] HKEEHAKOMGN? KNLCFJMHCLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x688EF80", Offset = "0x688DB80", VA = "0x18688EF80", Slot = "8")]
	public bool DHNJAKFEBKK(NEFICIJOBBJ AKKDGEHPEBN, [Out] HKEEHAKOMGN? KNLCFJMHCLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x688FB30", Offset = "0x688E730", VA = "0x18688FB30", Slot = "9")]
	public bool PCGOOLEDOIB(NEFICIJOBBJ AKKDGEHPEBN, [Out] GGAPEJLBDID? BNJPDANCNKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x295C150", Offset = "0x295AD50", VA = "0x18295C150")]
	private bool ADBBMGADNPI<TInput, TOutput>(TInput NGMMAKENIFG, LLMJCOALPIN<TInput, TOutput> DGCCCJHFFGA, [Out] TOutput? KKIOBLFFGJH) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x688E2A0", Offset = "0x688CEA0", VA = "0x18688E2A0")]
	[CompilerGenerated]
	private IMALHEFMIAI AIFKOEIPDHO(FaceFeatureType FFEIFKLKPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x688F860", Offset = "0x688E460", VA = "0x18688F860")]
	[CompilerGenerated]
	private IMALHEFMIAI ONFHPFDKIMF(FaceFeatureType FFEIFKLKPPL, GCPEKKIJCIL P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OCDDNNLBGPA]
internal class ONAMJBPONPH : PALCFNOLHKH
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void CIDBHBCGFPC<in TData>(TData KNLCFJMHCLN, IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JPLAALBLNCN MMLKDPDIIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HLJCFCHLOHC IEHMKNPHDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CIDBHBCGFPC<HKEEHAKOMGN>?[] MDDGAIFIOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CIDBHBCGFPC<GGAPEJLBDID>?[] AJIHHPPHOCL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68A8220", Offset = "0x68A6E20", VA = "0x1868A8220")]
	[DHOHFCLMOGD(OBGPNJNCONH.Root, IDHBAGABJJA.GameOnly)]
	[UsedImplicitly]
	private static void IOMJOEFGMKK(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68A8520", Offset = "0x68A7120", VA = "0x1868A8520")]
	[Preserve]
	internal ONAMJBPONPH([POJODGKFIMO(null)] JPLAALBLNCN MMLKDPDIIDD, [POJODGKFIMO(null)] HLJCFCHLOHC IEHMKNPHDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68A8420", Offset = "0x68A7020", VA = "0x1868A8420", Slot = "4")]
	public bool MCJPPHKFFHO(HKEEHAKOMGN KNLCFJMHCLN, IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68A82C0", Offset = "0x68A6EC0", VA = "0x1868A82C0", Slot = "5")]
	public bool MCJPPHKFFHO(GGAPEJLBDID BNJPDANCNKG, IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x68A75C0", Offset = "0x68A61C0", VA = "0x1868A75C0")]
	private void COKHHNMEFGE(HKEEHAKOMGN KNLCFJMHCLN, IReadOnlyList<PIGNFJGILAH>? LDAADCAOFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68A7FF0", Offset = "0x68A6BF0", VA = "0x1868A7FF0")]
	private void IGGMCNMPKAL(HKEEHAKOMGN KNLCFJMHCLN, IReadOnlyList<PIGNFJGILAH>? LDAADCAOFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68A8290", Offset = "0x68A6E90", VA = "0x1868A8290")]
	private void KANOJFGMFJE(HKEEHAKOMGN KNLCFJMHCLN, IReadOnlyList<PIGNFJGILAH>? LDAADCAOFLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PALCFNOLHKH
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCJPPHKFFHO(HKEEHAKOMGN KNLCFJMHCLN, IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCJPPHKFFHO(GGAPEJLBDID BNJPDANCNKG, IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH);
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AnimationPoseSetting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[Tooltip("Type of pose")]
		public CJHKPNLBDLG AnimationPoseType;

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

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x688A2D0", Offset = "0x6888ED0", VA = "0x18688A2D0")]
		public void GKANKMDFCPL(AnimationPoseSetting HEIGABGMPLJ, float LHFMBNHEBGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x688A400", Offset = "0x6889000", VA = "0x18688A400")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, LFGCKEHOFJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
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
		[SerializeField]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
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
		private Vector3? LLEEMAGODKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool FFHMNJBJKHE;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x688A420", Offset = "0x6889020", VA = "0x18688A420", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x688AA20", Offset = "0x6889620", VA = "0x18688AA20", Slot = "4")]
		public void UpdateController(float GFJHAHMFGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xE91C40", Offset = "0xE90840", VA = "0x180E91C40", Slot = "6")]
		public void SetEnabled(bool IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x688A4C0", Offset = "0x68890C0", VA = "0x18688A4C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x688AE40", Offset = "0x6889A40", VA = "0x18688AE40")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, LFGCKEHOFJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private const float FCAAJDGMLOJ = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
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
		private Vector3 BNAHJBDJGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Vector3 FIAFIABJHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private bool FFHMNJBJKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private float FGDPHIOLPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float NCFFPFOAPEC;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x688B1C0", Offset = "0x6889DC0", VA = "0x18688B1C0", Slot = "4")]
		public void UpdateController(float GFJHAHMFGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xB7BA60", Offset = "0xB7A660", VA = "0x180B7BA60", Slot = "6")]
		public void SetEnabled(bool IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x688AEE0", Offset = "0x6889AE0", VA = "0x18688AEE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x688BC80", Offset = "0x688A880", VA = "0x18688BC80")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
		[SerializeField]
		private Transform bone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		[Tooltip("If the child bone is provided, this is used to draw the handle towards that child")]
		private Transform childBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		[Tooltip("If no Child Bone is provided, then use this value as the length of the bone")]
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

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x688C5A0", Offset = "0x688B1A0", VA = "0x18688C5A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x688C560", Offset = "0x688B160", VA = "0x18688C560")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x688BCB0", Offset = "0x688A8B0", VA = "0x18688BCB0")]
		private void IFNAMDDFPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x68555E0", Offset = "0x68541E0", VA = "0x1868555E0", Slot = "4")]
		public void SetEnabled(bool NODMMGDBLME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x688C5D0", Offset = "0x688B1D0", VA = "0x18688C5D0")]
		public AvatarFKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AvatarForearmRollController : MonoBehaviour, LFGCKEHOFJB
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
		private float FGDPHIOLPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private bool FFHMNJBJKHE;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x688C610", Offset = "0x688B210", VA = "0x18688C610", Slot = "4")]
		public void UpdateController(float GFJHAHMFGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xDE0C70", Offset = "0xDDF870", VA = "0x180DE0C70", Slot = "6")]
		public void SetEnabled(bool IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x688D0A0", Offset = "0x688BCA0", VA = "0x18688D0A0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	public class AvatarFullBodyBehaviour : MonoBehaviour, KONGAOEAGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarFullBodyConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[KJNKIIMENHL(OBLJNCJJPID.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected VRIK skeletonInverseKinematics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Header("Configuration")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private ELLPOHGPOAN IIBHKLAEJPN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public ELLPOHGPOAN DCKHMLHNLIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x688DE80", Offset = "0x688CA80", VA = "0x18688DE80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform GFACDNEFOGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x688DEC0", Offset = "0x688CAC0", VA = "0x18688DEC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x688D0D0", Offset = "0x688BCD0", VA = "0x18688D0D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x688DCB0", Offset = "0x688C8B0", VA = "0x18688DCB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x688DC60", Offset = "0x688C860", VA = "0x18688DC60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x688DBF0", Offset = "0x688C7F0", VA = "0x18688DBF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x688DB60", Offset = "0x688C760", VA = "0x18688DB60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x688DBF0", Offset = "0x688C7F0", VA = "0x18688DBF0", Slot = "6")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x688D830", Offset = "0x688C430", VA = "0x18688D830", Slot = "7")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x688DD90", Offset = "0x688C990", VA = "0x18688DD90", Slot = "8")]
		public void UpdatePostIKAnimControllers(float GFJHAHMFGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x688DD00", Offset = "0x688C900", VA = "0x18688DD00")]
		private void PFEFCPJEJHM(GameObject APKAFMDACKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x688D170", Offset = "0x688BD70", VA = "0x18688D170")]
		private ELLPOHGPOAN BCAOKEFFNKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public AvatarFullBodyBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarFullBodyConfiguration : AvatarConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Header("Turning")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("The number of seconds it takes for a rotational follow to catch up when steering.")]
		public float SteeringRotationalFollowTimeAtMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("An outer dead zone that has instantaneous effect.")]
		public float TurnDeadZoneAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("The maximum amount the skeleton is allowed to fall behind the head when turning.")]
		public float TurnMaxHeadDifference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("The maximum amount of turn allowed between the shoulders and the head.")]
		public float MaxLocalHeadTurn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Head rotation smoothing time.")]
		public float HeadRotationSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Header("Movement")]
		public float SkeletonPitchFollowTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public float SpeedChangeTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float SpeedStopTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public float TurnInPlaceDampTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public float LocomotionLeanAndTwistLayerWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float LocomotionLeanAndTwistBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float HeadAdditiveDisplacementAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float PitchRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[Tooltip("The time it takes to blend from moving to idle.")]
		public float MovementBlendTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[Tooltip("Vertical offset of head when moving.")]
		public float MovementHeadOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Tooltip("Vertical offset of head when looking up and down.")]
		public AnimationCurve VerticalHeadOffsetAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[Header("Hand Placement")]
		[Tooltip("Offsets applied to transforms on the players left hand")]
		public HandLogicOffsets LeftHandOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PlatformSpecificPlayerHandOffsets LeftPlayerHandPlatformOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[Tooltip("Curve that takes in the OpenClose float value from either a VR controller and then remaps the 0 to 1 space (open -> close space) to a new open to close space that will drive the animation of opening and closing the hand. This is useful since most VR controllers provide a pretty crappy approximation of how depressed the trigger buttons are.")]
		[FormerlySerializedAs("VRHandOpenCloseRemapCurve")]
		[Header("Hand Animation")]
		public AnimationCurve VRHandOpenCloseRemapAnimCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public HandPoseSettings HandPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[Tooltip("The local position offset of the clock face in the local wrist watch to have it sit on the full body's geometry")]
		[Header("Watch")]
		public Vector3 WatchClockFaceLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F4")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Tooltip("The local uniform scale to apply to the clock face to match the full body's geometry")]
		public float WatchClockFaceLocalUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[Range(0.01f, 10f)]
		[Tooltip("The weight given to each second since the last full update a particular avatar got. Higher values prioritize less recently updated avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		[Header("Performance Tuning")]
		public float RoundRobinWeightPerSecondSinceLastFullUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2FC")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[Range(0.01f, 1f)]
		[Tooltip("The weight given to each distance band an avatar is close to the local player. Higher values prioritize closer avatars. WARNING: when tuning this, make sure to test thoroughly in various avatar setups and watch out for potential avatar system starvation.")]
		public float RoundRobinWeightPerClosenessBandToLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Tooltip("If true, diagnostics will be shown on a diagnostics panel.")]
		public bool ShowDiagnostics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x301")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[Tooltip("If true, avatar colliders will be reparented under the avatar rig so they can follow the rig bone movement naturally as child transforms. If false, they will be moved to follow the avatar rig bones each frame and incur a bigger performance hit.")]
		public bool ReparentCollidersUnderAvatarRig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Header("Leaning")]
		[Tooltip("The duration of a lean.")]
		public float LeaningDurationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[Tooltip("The blend of a lean.")]
		public float LeaningBlendSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30C")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("How much the avatar leans.")]
		public float LeaningAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Tooltip("How much to offset the avatars center during a lean.")]
		public float LeaningOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x314")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[Tooltip("At what speed do we reach the maximum lean.")]
		public float LeaningMaxAtSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[Tooltip("Whats the max turn value allowed for the character to lean.")]
		public float LeaningMaxTurnAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Header("Hand Blending")]
		[Tooltip("The distance an hand needs to move before its considered moving")]
		public float VRMinHandMoveDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[Tooltip("The number of seconds a hand must be still before its blended out")]
		public float VRMinStableHandDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[Tooltip("The number of seconds a hand takes to blend in")]
		public float HandIkBlendInTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[Tooltip("The number of seconds a hand takes to blend out")]
		public float HandIkBlendOutTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while idle")]
		[Header("Body Twisting")]
		public float VRShoulderTwistIdle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[Tooltip("Value controlling how much the shoulder twists to face the head direction in VR while moving")]
		public float VRShoulderTwistMoving;

		[Cpp2IlInjected.FieldOffset(Offset = "0x334")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[Tooltip("Value controlling how much the shoulder twists based on hand position in VR")]
		public float VRShoulderTwistHands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[Tooltip("How much to twist shoulders to follow hands in screens mode.")]
		public float ShoulderTwistScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[Tooltip("Min distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMinDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Tooltip("Max distance between head and hand at where shoulders twist.")]
		public float ShoulderTwistMaxDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x344")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[Tooltip("Twistback factor when aiming down.")]
		public float ShoulderTwistDownFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[Tooltip("Amount of twisting applied to the body when climbing to face the look direction.")]
		public float ClimbingBodyTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[Tooltip("Amount of rotation allowed on the head when climbing.")]
		public float ClimbingHeadRotationAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[Tooltip("Smooth time for twisting based on hand position.")]
		public float ShoulderTwistSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x354")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[Tooltip("How much to twist shoulders to follow hands in first person screens mode.")]
		public float ShoulderTwistFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[Tooltip("Distance between game and physical hand that will allow a snap")]
		[Header("Hand Snapping")]
		public float MinSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x35C")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Tooltip("Distance between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[Tooltip("Angle between game and physical hand that will allow a snap")]
		public float MinSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x364")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[Tooltip("Angle between game and physical hand that will fully blend out from a snapped hand")]
		public float MaxSnapAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[FormerlySerializedAs("HandPoseSettings")]
		[Header("Hand Poses")]
		public AnimationPoseSetting[] AnimationPoseSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Tooltip("Control for how much the IK can deviate from the animated position")]
		public float MaxIKHeadPositionDeviationFraction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x374")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[Tooltip("Scalar to control the amount of leaning applied to the upper body applied when tracking the game head")]
		public Vector3 HeadLeanScalar;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[Tooltip("Offset applied to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		[Header("Foot Pinning")]
		public AnimationCurve FootPinHipOffsetHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[Tooltip("Offset applied (when crouched) to hip based on the difference between the pinned and animated foot distance. (less than 0 = feet pinned together, and greater = pinned further apart)")]
		public AnimationCurve FootPinHipOffsetHeightCrouched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[Tooltip("Blend threshold reached by first foot before unpinning second foot when moving")]
		public float UnpinWeightThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[Tooltip("Minimum local forward distance for a foot in motion to be considered stable")]
		public float MinStableLocalForwardDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[Tooltip("Minimum local height for a foot in motion to be considered stable")]
		public float MinStableLocalHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public FootSettings FootSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public FootSettings FootSettingsLocalVR;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x688DF10", Offset = "0x688CB10", VA = "0x18688DF10")]
		public AnimationPoseSetting OGPGGDIIJIO(CJHKPNLBDLG CNPNIKLFOGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x688DEE0", Offset = "0x688CAE0", VA = "0x18688DEE0")]
		public void KCBMKHLALEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x688DF40", Offset = "0x688CB40", VA = "0x18688DF40")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FootSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[Tooltip("Foot speed used when moving from pinned position to animated position")]
		public float FootPinSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[Tooltip("Foot speed used when error is high")]
		public float FootPinMaxSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[Tooltip("Distance at where the foot will unsnap. Based on idle distance between feet")]
		public float PinDistanceFractionThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[Tooltip("Angle at where the foot will unsnap")]
		public float PinAngleThresh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[Tooltip("Error allowed when in a stable state before feet gets unpinned")]
		public float ErrorThreshWhenStable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[Tooltip("How much the hips are offset due to pinned feet. 0 = head, 1 = pinned feet")]
		public float HipOffsetFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[Tooltip("Smoothness of hip offset changes")]
		public float HipOffsetSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[Tooltip("Vertical scalar for hip offset")]
		public float HipOffsetHeightScale;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6891800", Offset = "0x6890400", VA = "0x186891800")]
		public FootSettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FMNMACACDFH : HLHMBDNBENO
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static int MCJGHDGCMDP;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static int NPONPLJDBKJ;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static int HHPBHIININB;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static int OAMCFDOONAI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int FOFMLCFICNH;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static int CDFCEKHGEHJ;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static int GFOLFCKGDBD;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static int[] EOKMAJJLEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private FJOEBMLCDOJ GLHHGIKMGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private int KNDIENGKDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private float CNOGGGEDCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool GGNIAEJKAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Animator JJKGAEIJLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AvatarFullBodyConfiguration ABCGLGNJJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int NAOCIMGOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int BCCBPNBJBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int MDPFOOFOMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool HHEAAOPOMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private DIHIDCHNPMP CJHMHKOILHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private float MIDEDNALPBK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal Transform KNJNEJHBKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal Vector3 JKNKGPLDCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xDE88F0", Offset = "0xDE74F0", VA = "0x180DE88F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xDE8970", Offset = "0xDE7570", VA = "0x180DE8970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	internal Quaternion COOLKBKBJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1BC76E0", Offset = "0x1BC62E0", VA = "0x181BC76E0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D800", Offset = "0x1F4C400", VA = "0x181F4D800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	internal bool NACDMIBGEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x688FE80", Offset = "0x688EA80", VA = "0x18688FE80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x688FE40", Offset = "0x688EA40", VA = "0x18688FE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 LLMMOIPCHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x892C90", Offset = "0x891890", VA = "0x180892C90", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x892CD0", Offset = "0x8918D0", VA = "0x180892CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Quaternion EPKDDIDCJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x892ED0", Offset = "0x891AD0", VA = "0x180892ED0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x892B50", Offset = "0x891750", VA = "0x180892B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MOHACDPOFED DCGNNKOCEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1AAE340", Offset = "0x1AACF40", VA = "0x181AAE340", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(MOHACDPOFED);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x1AAE350", Offset = "0x1AACF50", VA = "0x181AAE350", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MOHACDPOFED OBLBONKOANP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9C1DD0", Offset = "0x9C09D0", VA = "0x1809C1DD0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(MOHACDPOFED);
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9C2480", Offset = "0x9C1080", VA = "0x1809C2480", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float DKAFPPKJAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1D77BD0", Offset = "0x1D767D0", VA = "0x181D77BD0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1D75AE0", Offset = "0x1D746E0", VA = "0x181D75AE0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool OKOMPIFMNBK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x688FE30", Offset = "0x688EA30", VA = "0x18688FE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool BGJPCKMHKNC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x688FE20", Offset = "0x688EA20", VA = "0x18688FE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool OBEHENMBPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x688FED0", Offset = "0x688EAD0", VA = "0x18688FED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x688FFE0", Offset = "0x688EBE0", VA = "0x18688FFE0", Slot = "21")]
	public void NJFEGHENHFC(FJOEBMLCDOJ DBFEODNANIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68905F0", Offset = "0x688F1F0", VA = "0x1868905F0", Slot = "22")]
	public void OJNHMILEDMK(PMCNHIBKFLA AHNGLDFAIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x688FF50", Offset = "0x688EB50", VA = "0x18688FF50", Slot = "12")]
	public void MMNOEDNEDKA(bool NCJAANPMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x68901A0", Offset = "0x688EDA0", VA = "0x1868901A0", Slot = "11")]
	public void NLKLFBJNOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6890600", Offset = "0x688F200", VA = "0x186890600")]
	private int PBDFDCCPNHH(MOHACDPOFED GLJHGPDBBAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68904C0", Offset = "0x688F0C0", VA = "0x1868904C0")]
	private void NMANGIAABOP(int JBAOBDNBIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x688FEB0", Offset = "0x688EAB0", VA = "0x18688FEB0", Slot = "13")]
	public bool HHPJGFDPHDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x688FF30", Offset = "0x688EB30", VA = "0x18688FF30", Slot = "14")]
	public bool MCAGCLLKIIP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x688FDD0", Offset = "0x688E9D0", VA = "0x18688FDD0")]
	private MOHACDPOFED AGDHGFMIDHI()
	{
		return default(MOHACDPOFED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1AA6400", Offset = "0x1AA5000", VA = "0x181AA6400", Slot = "15")]
	public void CLHCGEBOPIP(bool NCJAANPMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x688FF40", Offset = "0x688EB40", VA = "0x18688FF40", Slot = "10")]
	public void MLCIKLANBID(int JBAOBDNBIMJ, float LFLAKHPGKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x688FDB0", Offset = "0x688E9B0", VA = "0x18688FDB0", Slot = "8")]
	public void AEIIFCEAHDM(DIHIDCHNPMP FFBJIDDDHKC, bool NIKNNKAMGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x688FE70", Offset = "0x688EA70", VA = "0x18688FE70", Slot = "9")]
	public void DNPIDBMHOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x688FEE0", Offset = "0x688EAE0", VA = "0x18688FEE0", Slot = "16")]
	public void LDAEGPFMMOO(Transform DELFIACNBGK, Vector3 JBBEFLJOMLO, Quaternion GLCFOEGPNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6890A80", Offset = "0x688F680", VA = "0x186890A80")]
	public FMNMACACDFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class KNDBIMIMCKG : ELLPOHGPOAN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class FOFFFOPKDCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Vector3 HDOFGOEFNPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Quaternion HBCIDPCFLLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Vector3 LIFALFFPNMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Transform CDGMILOCCPH;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Vector3 CLAALKCOIMP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x13AD330", Offset = "0x13ABF30", VA = "0x1813AD330")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x13AD350", Offset = "0x13ABF50", VA = "0x1813AD350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Quaternion CKLPOBBCHCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB15E10", Offset = "0xB14A10", VA = "0x180B15E10")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0xB15D80", Offset = "0xB14980", VA = "0x180B15D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float IBKFJKNPEBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8D1CC0", Offset = "0x8D08C0", VA = "0x1808D1CC0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xEAEBF0", Offset = "0xEAD7F0", VA = "0x180EAEBF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool OBCEAAOPEPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x86FCD0", Offset = "0x86E8D0", VA = "0x18086FCD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x86FB50", Offset = "0x86E750", VA = "0x18086FB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool FKHKAEELIMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x86FC10", Offset = "0x86E810", VA = "0x18086FC10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x86FB20", Offset = "0x86E720", VA = "0x18086FB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool HLMOGMKMKNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x86FB30", Offset = "0x86E730", VA = "0x18086FB30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x86FCF0", Offset = "0x86E8F0", VA = "0x18086FCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float LBAKDBBNPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8D1CF0", Offset = "0x8D08F0", VA = "0x1808D1CF0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9C1540", Offset = "0x9C0140", VA = "0x1809C1540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6890C60", Offset = "0x688F860", VA = "0x186890C60")]
		public void COOKLDAMHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6891070", Offset = "0x688FC70", VA = "0x186891070")]
		public void NBBFDOBKFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6890A90", Offset = "0x688F690", VA = "0x186890A90")]
		public float BBJJMAGJABG(Transform NJEPOLEELKD, [In] FootSettings MEBEHDBKOEJ, float EFMEEOPABLA)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6891080", Offset = "0x688FC80", VA = "0x186891080")]
		public void NFBKMHFMJNH(Transform JGDLOFFPAGD, Transform EEAEFPGCEEG, float BAFCJNJHNML, bool INFCONFCLFK, bool GPHJJDGADMI, float KHCCEJAFEGK, float GHKINJJKKOC, Transform LNPGMAMPBAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6890C70", Offset = "0x688F870", VA = "0x186890C70")]
		public void IFBKBFPDDDC(Transform HOJNCPBKMIC, Transform LNPGMAMPBAC, bool JPBGMFGGJIM, bool LLFIKFAPNON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6890F70", Offset = "0x688FB70", VA = "0x186890F70")]
		private void MCJJLMFCNDL(Transform LNPGMAMPBAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6890EA0", Offset = "0x688FAA0", VA = "0x186890EA0")]
		public void JCPLCKKKBNI(Transform LNPGMAMPBAC, AvatarFullBodyConfiguration JOKNJOHCHIH, Vector3 IPIPPMIKIFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x68917E0", Offset = "0x68903E0", VA = "0x1868917E0")]
		public void ODNFPENCOGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x68917F0", Offset = "0x68903F0", VA = "0x1868917F0")]
		public FOFFFOPKDCM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class KMHLBBBFLML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private float HJBHMCCIIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private bool NKNJDILIMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AnimationPoseSetting FDIHJFDKJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private float MKPHAOLBPIN;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6891840", Offset = "0x6890440", VA = "0x186891840")]
		public void CJKONDLKPGN(IKSolverVR.Arm NEGHPFIJCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6891FD0", Offset = "0x6890BD0", VA = "0x186891FD0")]
		public void ILDNPCFNMFH(IKSolverVR.Arm NEGHPFIJCMA, float EMBPKHIDDJE, bool NKNJDILIMCL, AvatarFullBodyConfiguration JOKNJOHCHIH, float KPMOGOCODDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6892490", Offset = "0x6891090", VA = "0x186892490")]
		private void MMEOMPKPGCP(IKSolverVR.Arm NEGHPFIJCMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6892AA0", Offset = "0x68916A0", VA = "0x186892AA0")]
		public void PAJKKBPJMNE(IKSolverVR.Arm NEGHPFIJCMA, Transform MEBLFOGJKDM, Transform EEAEFPGCEEG, Quaternion EPFECLMHPHN, Vector3 NFNDNAKCMHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x68924D0", Offset = "0x68910D0", VA = "0x1868924D0")]
		private (Vector3, Quaternion) NFLOKIDJCHB(FMNMACACDFH GCIEGGAFKCB, Quaternion EGFFCBBGCJI, Vector3 PCIPNKPJMBM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6891870", Offset = "0x6890470", VA = "0x186891870")]
		public void DNDLBFEOHCB(FMNMACACDFH GCIEGGAFKCB, IKSolverVR.Arm NEGHPFIJCMA, Quaternion EGFFCBBGCJI, Vector3 PCIPNKPJMBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68919D0", Offset = "0x68905D0", VA = "0x1868919D0")]
		public void HPDLNLNNJEF(FMNMACACDFH GCIEGGAFKCB, IKSolverVR.Arm NEGHPFIJCMA, Quaternion EGFFCBBGCJI, Vector3 PCIPNKPJMBM, [In] AvatarFullBodyConfiguration JOKNJOHCHIH, [In] DNBDNPFFHFC FFBJIDDDHKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6892960", Offset = "0x6891560", VA = "0x186892960")]
		public void OPNKJMJDPBC(CJHKPNLBDLG CFEHDNJAECK, AvatarFullBodyConfiguration JOKNJOHCHIH, DNBDNPFFHFC FFBJIDDDHKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6892010", Offset = "0x6890C10", VA = "0x186892010")]
		public void MGCCPMLACJA(IKSolverVR.Arm NEGHPFIJCMA, Transform MEBLFOGJKDM, Vector3 IDCIDGDMGPJ, float MFHLPOEIGNN, Quaternion EBDBECBIELL, Vector3 FBEDLNLDPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6892E80", Offset = "0x6891A80", VA = "0x186892E80")]
		public KMHLBBBFLML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum CFDKAOKAPEK
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Smooth,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		BalancedBasedOnDeadzones,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		ForceSnapIntoPlace
	}

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int BDBACPPGOBH;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int DDODIIJMJLK;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int GALKHHJGDDB;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int KOKBBCEEKOP;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int CFEJMOCLCGA;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int NPMDDPIFABD;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int HDIMPNEHDMP;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int LKCDADIKFOE;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int ABCBPDIPBKH;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int KJOJEIMGKIJ;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int AFIOBKODCCI;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int CLGBBDLDHJP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int GMFABIADECC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int LGEKGKHJAMG;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int OKNGOGJBHCI;

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private static readonly int BCLHFOACGNJ;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int PNHNBMOPPEP;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int PHCADIMPONM;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int GNNKADCGHDE;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int PEMPDALHOPP;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int FGBDACDJNKB;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int MIKJLLMNINM;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int BHJLJMEHOAE;

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private static readonly int EABFCJMMANA;

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly int CNOIGKLOONK;

	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private static readonly int BCCLPIONDFO;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int BCGELKDAHBB;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int PGGFHCJBBND;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly int PLNDEAKKBEP;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly Vector3 HGMGKBGDOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool HALCLAIDGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private bool KFFKPADAJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private bool LEADGDHBGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private bool IDKGGKFNDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool JGEAPLHIEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Vector3 JLFAOAPGFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private LGINAHDHIGK? GLHHGIKMGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private PEPAIEEAPFC? ADEAAPALIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private HCCILOKOMGM KNCDOONOHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private PDBJCCFFMBI CNOILCGBOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private FMNMACACDFH IMBALIFGDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private FMNMACACDFH OCLILPFBPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool MCNJJDMGMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private bool FIKFPBFEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly PPDEDGIPHKO FNHHBNBHNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly MHBGEOGEBCB HEDBPJNDNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private int BPJCJKDFBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private float KEOKFAGFOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private GameObject PJAHAGFHOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Transform CFCIJBIBEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Transform PDKAFGJDPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float EFCNAMEIAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private float OBNEDLJKOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private Vector3 GBMBELNHIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private Quaternion OEGDFOGKJLC;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly ProfilerMarker HHIFNJPLKAK;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static readonly ProfilerMarker LGBPBBCFBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private ProfilerMarker PACNAPFHBNB;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static readonly ProfilerMarker FCJPFOJGPJD;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static readonly ProfilerMarker HNCDKPCDLMI;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static readonly ProfilerMarker GCLIMKDHKFL;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly List<KNDBIMIMCKG> AELBCBGKEHB;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static int EJOIIIEIJMO;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> JHKIIJOMIBP;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static int JEDAOBCJOKB;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static int DMENIMOPFMO;

	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private static int KMPFLLAMDJB;

	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static int FDGEEIHIMOD;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static float CFCACCHCHHF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int PCLBCPEDJNC;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static float PEPHBHKAJCB;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static float NMDEPLDOCNI;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static float LELCCFLOJMG;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static float LEPNFEAHNHN;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static NMKLNIEPIIN CBMELNPINEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float LGLGIJNFIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private bool CFDNHHKDMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private float DHEIEAPNBFN;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly int DCNMKBNHNFC;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly int AJCHLELPKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private FOFFFOPKDCM FHJLPBDPPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private FOFFFOPKDCM AOFLCODGPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private float DICGPBILOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Vector3 NFJNPHDNLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private Vector3 JBKPNFPHFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private bool CNJEEBLGMJK;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly Quaternion DKKMDPBGNOH;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly Quaternion ANDMADOJEFN;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly Vector3 DJNGNNDBILL;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly Vector3 ANHCEMKLGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private float OAIPINGNIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float MDACFADMNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private KMHLBBBFLML GAPLEOJDKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private KMHLBBBFLML BBGFBFCBIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private GHAFPKKCLFA BANMJGMLDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private GIIPJGNLJJH IEEHMCJIDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly LMPFIJJOMLK CJEJNLLFCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float BELAONEJILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private float CEGOCIKLMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly GIIPJGNLJJH FLIOFBIGJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private Vector3 DLJFOEBNPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private Vector3 DDGLAICFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private float JJMKEJKPKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x32C")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private float GLHBOBILGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly GIIPJGNLJJH PKMBJGEKJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly GHAFPKKCLFA ICNOBDJBMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly GIIPJGNLJJH BHINCPJGBAI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public MMAIJBDFGNK DPBAIELKCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MMAIJBDFGNK PGJEIDDKOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public AvatarConfiguration APKMPNMDHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68A0900", Offset = "0x689F500", VA = "0x1868A0900", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarFullBodyConfiguration BNCCIOPOODI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x689D130", Offset = "0x689BD30", VA = "0x18689D130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Transform GGJIGNPPPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68A23C0", Offset = "0x68A0FC0", VA = "0x1868A23C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Transform OBCNENBEPME
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68A3C70", Offset = "0x68A2870", VA = "0x1868A3C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private SkinnedMeshRenderer AHIPHPOLNJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x689FD80", Offset = "0x689E980", VA = "0x18689FD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private Renderer[] HDONFKAFLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68A65B0", Offset = "0x68A51B0", VA = "0x1868A65B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private GameObject[] GJAMNKMPFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6895270", Offset = "0x6893E70", VA = "0x186895270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private Animator ICDHDDGGEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x68983E0", Offset = "0x6896FE0", VA = "0x1868983E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private VRIK DADAFADHMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68A5C90", Offset = "0x68A4890", VA = "0x1868A5C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private LFGCKEHOFJB FBGOMEOHEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x68A5780", Offset = "0x68A4380", VA = "0x1868A5780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private LFGCKEHOFJB EEMCKDHKKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6896780", Offset = "0x6895380", VA = "0x186896780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private LFGCKEHOFJB AGLCAMIGDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x68A05C0", Offset = "0x689F1C0", VA = "0x1868A05C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private LFGCKEHOFJB HLNOEICMDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68A4E60", Offset = "0x68A3A60", VA = "0x1868A4E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private LFGCKEHOFJB JCJMABAOPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6895390", Offset = "0x6893F90", VA = "0x186895390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private LFGCKEHOFJB NJLPNGEAJNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x68A4230", Offset = "0x68A2E30", VA = "0x1868A4230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private LFGCKEHOFJB KPMBNKKEOED
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68A09E0", Offset = "0x689F5E0", VA = "0x1868A09E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private LFGCKEHOFJB DPFKODGGEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x68A5650", Offset = "0x68A4250", VA = "0x1868A5650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public PEPAIEEAPFC PLBIGCLBELA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68946C0", Offset = "0x68932C0", VA = "0x1868946C0", Slot = "33")]
		get
		{
			return default(PEPAIEEAPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public JGMGICCJDMN MGBMGPLIKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0770", VA = "0x1808D1B70", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public JEDFGLFPNJF POJEDHDDGDF
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB0DBE0", Offset = "0xB0C7E0", VA = "0x180B0DBE0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public HLHMBDNBENO HOLLEKHPGPA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xB0DC00", Offset = "0xB0C800", VA = "0x180B0DC00", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HLHMBDNBENO BIIOIPGPAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xB0C0E0", Offset = "0xB0ACE0", VA = "0x180B0C0E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private Transform CPJJGKEOLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68A6500", Offset = "0x68A5100", VA = "0x1868A6500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Transform EJEHMLOJEJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68990F0", Offset = "0x6897CF0", VA = "0x1868990F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Transform ECKDAJMMONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x689B660", Offset = "0x689A260", VA = "0x18689B660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private Transform GEHKCHEHCPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x68A5BB0", Offset = "0x68A47B0", VA = "0x1868A5BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public GameObject OJCNPGOLEHK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68991D0", Offset = "0x6897DD0", VA = "0x1868991D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Transform HPBBHNMNCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x13EC4F0", Offset = "0x13EB0F0", VA = "0x1813EC4F0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Transform IALEAABCKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1106CE0", Offset = "0x11058E0", VA = "0x181106CE0", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Vector3 GLJNBMBAEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6895350", Offset = "0x6893F50", VA = "0x186895350", Slot = "30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public float NIHMAEGKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6892F00", Offset = "0x6891B00", VA = "0x186892F00", Slot = "31")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform ALPMLBCFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68A5D70", Offset = "0x68A4970", VA = "0x1868A5D70", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private bool EBCODJCOAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68A6550", Offset = "0x68A5150", VA = "0x1868A6550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool FAOIGPNPFMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6897CB0", Offset = "0x68968B0", VA = "0x186897CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private bool LNAOKBFFMHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x68A06A0", Offset = "0x689F2A0", VA = "0x1868A06A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x68A0AC0", Offset = "0x689F6C0", VA = "0x1868A0AC0")]
	private void NCNIPMBOHKK([In] DNBDNPFFHFC CKEDAAOAPHI, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x68943B0", Offset = "0x6892FB0", VA = "0x1868943B0")]
	private void CELCOMEBFGE([In] DNBDNPFFHFC FFBJIDDDHKC, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x68A70B0", Offset = "0x68A5CB0", VA = "0x1868A70B0")]
	public KNDBIMIMCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6899270", Offset = "0x6897E70", VA = "0x186899270", Slot = "12")]
	public void IHBNGKFNGFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6893610", Offset = "0x6892210", VA = "0x186893610", Slot = "13")]
	public void BENOJCLPMBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x68A3BA0", Offset = "0x68A27A0", VA = "0x1868A3BA0", Slot = "14")]
	public void NJHOPHJLBHD(bool ONMGINNKBMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6898FA0", Offset = "0x6897BA0", VA = "0x186898FA0", Slot = "22")]
	public Transform HPDBCKKMKGH(string DAONFMLPOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6894530", Offset = "0x6893130", VA = "0x186894530", Slot = "23")]
	public Vector3? CEPHEIJKKIE(string DAONFMLPOKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6894870", Offset = "0x6893470", VA = "0x186894870", Slot = "7")]
	public void CHJBKJKNCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6896D50", Offset = "0x6895950", VA = "0x186896D50", Slot = "6")]
	public void EPLDLMAKBEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6899160", Offset = "0x6897D60", VA = "0x186899160", Slot = "8")]
	public void IBMOOIBGKBG(float NFFNILPGEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6898C60", Offset = "0x6897860", VA = "0x186898C60")]
	private void HMONHOILIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6899680", Offset = "0x6898280", VA = "0x186899680", Slot = "4")]
	public void INFINBPBMPJ(LGINAHDHIGK HICKPCDAICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x689D1C0", Offset = "0x689BDC0", VA = "0x18689D1C0", Slot = "5")]
	public void KGCCOKHHJDF(PEPAIEEAPFC AHNGLDFAIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6893900", Offset = "0x6892500", VA = "0x186893900", Slot = "11")]
	public void BHGCJOKHHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x68A0220", Offset = "0x689EE20", VA = "0x1868A0220", Slot = "21")]
	public void MKOPGGFHLGE([Out] Vector3 GAIOFIFECPN, [Out] Quaternion EBDBECBIELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x68A0720", Offset = "0x689F320", VA = "0x1868A0720")]
	private void MPKIBINCAOH([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x689D120", Offset = "0x689BD20", VA = "0x18689D120", Slot = "24")]
	public void KCBKIGAFEPP(float GBJPEIEGGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6892F30", Offset = "0x6891B30", VA = "0x186892F30", Slot = "25")]
	public void ALJFMCCIDDC(float OMINLCGMFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x68A5020", Offset = "0x68A3C20", VA = "0x1868A5020", Slot = "26")]
	public HandLogicOffsets ODENINHCHFN()
	{
		return default(HandLogicOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6896C90", Offset = "0x6895890", VA = "0x186896C90", Slot = "27")]
	public PlatformSpecificPlayerHandOffsets EOIJNODPDBL()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x689ED50", Offset = "0x689D950", VA = "0x18689ED50")]
	private void LFDOOCNOLKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x68A4310", Offset = "0x68A2F10", VA = "0x1868A4310")]
	private void OABOOHOOHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6898CB0", Offset = "0x68978B0", VA = "0x186898CB0")]
	private void HNGNBAMONLL(NIJCOMOFOFB CNGEPIJFACG, bool NOFJHFMCCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x68A4070", Offset = "0x68A2C70", VA = "0x1868A4070")]
	private void NNGPFENDLOG(NIJCOMOFOFB CNGEPIJFACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6897D30", Offset = "0x6896930", VA = "0x186897D30")]
	public Vector3 FIGEHMBACAI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6896700", Offset = "0x6895300", VA = "0x186896700")]
	private void EHAOCNMGAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x68947F0", Offset = "0x68933F0", VA = "0x1868947F0")]
	private void CHAKDNJDFBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x689ABB0", Offset = "0x68997B0", VA = "0x18689ABB0")]
	private void JAHDCBIFLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x68A50D0", Offset = "0x68A3CD0", VA = "0x1868A50D0")]
	private float ODFOCMINGHE([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x68A4F40", Offset = "0x68A3B40", VA = "0x1868A4F40")]
	private int ODDMBICEIPL([In] OFEGJJLCHOA DAABAOACMHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x689AF10", Offset = "0x6899B10", VA = "0x18689AF10")]
	private void JIIAJADAPJK(DNBDNPFFHFC CKEDAAOAPHI, bool HMHFAKEPDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x68A4C40", Offset = "0x68A3840", VA = "0x1868A4C40")]
	private static void OBMGEKAABAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x689E1C0", Offset = "0x689CDC0", VA = "0x18689E1C0")]
	private static void LDLHBKJMFOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x689FE60", Offset = "0x689EA60", VA = "0x18689FE60")]
	private float MAHHDBLCDEP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6897D80", Offset = "0x6896980", VA = "0x186897D80")]
	private static int FJEHLEBCKHC(KNDBIMIMCKG HDIFBMODGOB, KNDBIMIMCKG ADFEKOHGOPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x689D8B0", Offset = "0x689C4B0", VA = "0x18689D8B0")]
	public void KLDHAKKNCGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x68A5270", Offset = "0x68A3E70", VA = "0x1868A5270")]
	private (bool, bool) OFGGLNDPNNA()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x689BA40", Offset = "0x689A640", VA = "0x18689BA40")]
	private void KBCPKHEJFBA([In] DNBDNPFFHFC FFBJIDDDHKC, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6896860", Offset = "0x6895460", VA = "0x186896860")]
	private void EIJNAMAEBEO([In] DNBDNPFFHFC FFBJIDDDHKC, [In] AvatarFullBodyConfiguration JOKNJOHCHIH, FootSettings MEBEHDBKOEJ, bool JBHKJFLILPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x689ABD0", Offset = "0x68997D0", VA = "0x18689ABD0")]
	private float JCDEOMNJPDK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x689EE10", Offset = "0x689DA10", VA = "0x18689EE10")]
	private void LJAHBMOCNNK(DNBDNPFFHFC FFBJIDDDHKC, AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x68A5730", Offset = "0x68A4330", VA = "0x1868A5730")]
	private float OODGIBAOGIC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6894D80", Offset = "0x6893980", VA = "0x186894D80")]
	private void CLHIEBANCEL([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x68A5860", Offset = "0x68A4460", VA = "0x1868A5860")]
	private void PAJKKBPJMNE([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6895470", Offset = "0x6894070", VA = "0x186895470")]
	private void DOAIKBGOAGE([In] DNBDNPFFHFC FFBJIDDDHKC, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6898590", Offset = "0x6897190", VA = "0x186898590")]
	private void HFHEHENBOIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6893200", Offset = "0x6891E00", VA = "0x186893200")]
	private void AMIFNOEGNCF([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6897DB0", Offset = "0x68969B0", VA = "0x186897DB0")]
	private void FLKNKCEMCPN(FMNMACACDFH NOAEDABFPBK, IKSolverVR.Arm NEGHPFIJCMA, Transform ADAGEPNKKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x689B6D0", Offset = "0x689A2D0", VA = "0x18689B6D0")]
	private void KAODENLCLPN(DNBDNPFFHFC FFBJIDDDHKC, AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x68A3D50", Offset = "0x68A2950", VA = "0x1868A3D50")]
	private void NLKLFBJNOEJ(FNIEINJFJCL OBFBOCLJCLB, HLHMBDNBENO NOAEDABFPBK, IKSolverVR.Arm NEGHPFIJCMA, float EMBPKHIDDJE, float KCKKJJMFAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6896050", Offset = "0x6894C50", VA = "0x186896050")]
	private void EGDCBEOHNJC([In] DNBDNPFFHFC FFBJIDDDHKC, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x689CD90", Offset = "0x689B990", VA = "0x18689CD90")]
	protected void KBLJDBMEOCN([In] DNBDNPFFHFC FFBJIDDDHKC, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x689D5D0", Offset = "0x689C1D0", VA = "0x18689D5D0")]
	private void KGIEFPHAJNG([In] DNBDNPFFHFC FFBJIDDDHKC, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x689AC50", Offset = "0x6899850", VA = "0x18689AC50")]
	protected void JFGMKKMNGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x689F760", Offset = "0x689E360", VA = "0x18689F760")]
	private void LJJPPMCDLLF([In] DNBDNPFFHFC FFBJIDDDHKC, [In] CFDKAOKAPEK GAAIIBGKBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6895EA0", Offset = "0x6894AA0", VA = "0x186895EA0")]
	private void EECFCCMJBED(DNBDNPFFHFC FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6895A50", Offset = "0x6894650", VA = "0x186895A50")]
	private void EAIHAKPMDIF([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x68987A0", Offset = "0x68973A0", VA = "0x1868987A0")]
	private Vector3 HLCIMCFBNCG([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x68984C0", Offset = "0x68970C0", VA = "0x1868984C0")]
	private void HCEFFGILCPB([In] DNBDNPFFHFC FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x68A3320", Offset = "0x68A1F20", VA = "0x1868A3320")]
	private float NFFOLNEJJNN(float GHKINJJKKOC, [In] DNBDNPFFHFC FFBJIDDDHKC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x689B510", Offset = "0x689A110", VA = "0x18689B510")]
	private void JOMBNNMPAPA(float GHKINJJKKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x68939F0", Offset = "0x68925F0", VA = "0x1868939F0")]
	private void BJENKODOKJG([In] DNBDNPFFHFC FFBJIDDDHKC, CFDKAOKAPEK GAAIIBGKBAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6893FA0", Offset = "0x6892BA0", VA = "0x186893FA0")]
	private float CANKKNBFDJM([In] DNBDNPFFHFC CKEDAAOAPHI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x68A4720", Offset = "0x68A3320", VA = "0x1868A4720")]
	private void OBFGJJCDAPK(DNBDNPFFHFC FFBJIDDDHKC, CFDKAOKAPEK GAAIIBGKBAN, Vector3 CDANCIOFHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x68A54A0", Offset = "0x68A40A0", VA = "0x1868A54A0")]
	private static void OJCHFBGGLJH(Transform MENBKJEFCNP, Quaternion GPEICHFGELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6893310", Offset = "0x6891F10", VA = "0x186893310")]
	private void BDPLKIIEMGF([In] DNBDNPFFHFC KIDBNMFPDIO, [In] OFEGJJLCHOA DAABAOACMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x68A24A0", Offset = "0x68A10A0", VA = "0x1868A24A0")]
	private void NDHGLKELJBN([In] DNBDNPFFHFC KIDBNMFPDIO, [In] OFEGJJLCHOA DAABAOACMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x68A0750", Offset = "0x689F350", VA = "0x1868A0750")]
	private void NAADAJLBEIJ(float JGAOEPAAEJM, [In] DNBDNPFFHFC CKEDAAOAPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x68A2BD0", Offset = "0x68A17D0", VA = "0x1868A2BD0")]
	private float NEDFAGAHCIL([In] DNBDNPFFHFC CKEDAAOAPHI, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x689FFB0", Offset = "0x689EBB0", VA = "0x18689FFB0")]
	private void MEEFKJLMPJF([In] DNBDNPFFHFC CKEDAAOAPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x68A5DD0", Offset = "0x68A49D0", VA = "0x1868A5DD0")]
	private void PKBNHPINBBH([In] DNBDNPFFHFC CKEDAAOAPHI, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6898040", Offset = "0x6896C40", VA = "0x186898040")]
	private void GJCEDIFGNPH([In] DNBDNPFFHFC CKEDAAOAPHI, float DPJIMDKPLAE, float LABHKNAPNKE, Vector3 MFMDIOBBHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x689D8F0", Offset = "0x689C4F0", VA = "0x18689D8F0")]
	private void LDJOKPEIJOH(DNBDNPFFHFC CKEDAAOAPHI, AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6895A90", Offset = "0x6894690", VA = "0x186895A90")]
	private void EBIDKLMHNNM(DNBDNPFFHFC CKEDAAOAPHI, AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x68A3F20", Offset = "0x68A2B20", VA = "0x1868A3F20")]
	public void NMDCMDHCBPG([In] DNBDNPFFHFC FFBJIDDDHKC, [In] AvatarFullBodyConfiguration JOKNJOHCHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x689B440", Offset = "0x689A040", VA = "0x18689B440")]
	[CompilerGenerated]
	internal static void JJHBMINMPKB(FOFFFOPKDCM ABKNGIKFPNL, FOFFFOPKDCM DHPGIIFEPMF, Transform LANECIICECM, float JMMBJIBOIFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6893E90", Offset = "0x6892A90", VA = "0x186893E90")]
	[CompilerGenerated]
	internal static bool BKEAANPEBBI(IKSolverVR.Arm NEGHPFIJCMA, ECFFLCDNOJM PAJNCHFJAKC, float EJCMMHLEBKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x68A3760", Offset = "0x68A2360", VA = "0x1868A3760")]
	[CompilerGenerated]
	internal static float NGHHDCCNKIE(Vector3 NBMHNDMNBII, Vector3 IEJJENFEMOM, Vector3 ELMOCIKONAK, DNBDNPFFHFC CKEDAAOAPHI, AvatarFullBodyConfiguration JOKNJOHCHIH, float JEHLDDEOFLK)
	{
		return default(float);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum OINNJDKGIPN
		{
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
		[SerializeField]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private OINNJDKGIPN handleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		[FormerlySerializedAs("color")]
		private Color handleColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private float handleSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private bool drawAxisHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private float axisHandleScale;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x68A98C0", Offset = "0x68A84C0", VA = "0x1868A98C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x68A9880", Offset = "0x68A8480", VA = "0x1868A9880")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x68A9250", Offset = "0x68A7E50", VA = "0x1868A9250")]
		private void IFNAMDDFPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x68555E0", Offset = "0x68541E0", VA = "0x1868555E0", Slot = "4")]
		public void SetEnabled(bool NODMMGDBLME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68A98F0", Offset = "0x68A84F0", VA = "0x1868A98F0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarKneeBendTargetController : MonoBehaviour, LFGCKEHOFJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private Vector3 BNAHJBDJGDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private Vector3 ACJEPGAONOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private Vector3 NMFGKACKGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private Matrix4x4 PDHKNHHMIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private bool FFHMNJBJKHE;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x68A9D90", Offset = "0x68A8990", VA = "0x1868A9D90", Slot = "4")]
		public void UpdateController(float GFJHAHMFGFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68A9D80", Offset = "0x68A8980", VA = "0x1868A9D80", Slot = "6")]
		public void SetEnabled(bool IIPLJLPCLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x68A9920", Offset = "0x68A8520", VA = "0x1868A9920")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x68AA450", Offset = "0x68A9050", VA = "0x1868AA450")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[Preserve]
internal class DNCJDJCKNID : IHBPONKLCFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Dictionary<string, ELLPOHGPOAN> JDMOBDJEFCP;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DNFOEDOMFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x880D80", Offset = "0x87F980", VA = "0x180880D80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x68AB680", Offset = "0x68AA280", VA = "0x1868AB680")]
	[DHOHFCLMOGD(OBGPNJNCONH.Root, IDHBAGABJJA.None)]
	private static void JPFGINAKCJH(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x68AB6F0", Offset = "0x68AA2F0", VA = "0x1868AB6F0", Slot = "4")]
	public ELLPOHGPOAN KBIJOCEJEON(string DAEBMLBPNOF, AvatarSystemConfiguration AAPAGCKHJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x68AB890", Offset = "0x68AA490", VA = "0x1868AB890", Slot = "5")]
	public void PGDFNBFIDIB(string DAEBMLBPNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x68ABA70", Offset = "0x68AA670", VA = "0x1868ABA70")]
	public DNCJDJCKNID()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[ExecuteAlways]
	public class AvatarVRIKSimpleController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class MJJPBFINMMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			private Dictionary<string, Transform> BBOPOPLKCHA;

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool IEKHLJNNNBD
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x68B24E0", Offset = "0x68B10E0", VA = "0x1868B24E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x68B2520", Offset = "0x68B1120", VA = "0x1868B2520")]
			public void HOAPLPFJNLM(VRIK ILANEOMJAMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
			public void OGJKFELMMPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x68B2650", Offset = "0x68B1250", VA = "0x1868B2650")]
			public void LEJCELDJPNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x68B26A0", Offset = "0x68B12A0", VA = "0x1868B26A0")]
			public MJJPBFINMMH()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum ControllerExecMode
		{
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			EditorOnly,
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			RuntimeOnly,
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			EditorAndRuntime,
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			Disabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		[JIPFFEAJEBK(OBLJNCJJPID.SelfAndChildren, false, false, false)]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		[KJNKIIMENHL(OBLJNCJJPID.SelfAndChildren, false, false, false)]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private readonly MJJPBFINMMH LGBPLDELHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private KONGAOEAGDH JBDJFBNCEDI;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68AA4E0", Offset = "0x68A90E0", VA = "0x1868AA4E0")]
		private void NJFEGHENHFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x68AA490", Offset = "0x68A9090", VA = "0x1868AA490")]
		private bool DCHPHJLFKCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x68AA7A0", Offset = "0x68A93A0", VA = "0x1868AA7A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x68AA810", Offset = "0x68A9410", VA = "0x1868AA810")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x68AA7B0", Offset = "0x68A93B0", VA = "0x1868AA7B0")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x68AAA80", Offset = "0x68A9680", VA = "0x1868AAA80")]
		public AvatarVRIKSimpleController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class HandPoseSettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class HandPoseSetting
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			[Tooltip("Name of animation state(s)")]
			public string[] AnimationStates;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			[Tooltip("Parameter that drives the value")]
			public string AnimationParameter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private int AnimationParameterHash;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			[Tooltip("Curve controlling the open/closed value for the left hand (0-1)")]
			public AnimationCurve LeftHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			[Tooltip("Curve controlling the open/closed value for the right hand (0-1)")]
			public AnimationCurve RightHandOpenClosedAnimCurve;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			[Tooltip("Use a constant value instead of the curves")]
			public bool UseConstantValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			[Tooltip("Constant value to use if the flag is set to true")]
			public float ConstantValue;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public int[] AnimationStateHashes
			{
				[Cpp2IlInjected.Token(Token = "0x600011E")]
				[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011F")]
				[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x68ACA70", Offset = "0x68AB670", VA = "0x1868ACA70")]
			public void KCBMKHLALEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x68ACB50", Offset = "0x68AB750", VA = "0x1868ACB50")]
			public (float, float) MNNHGGLNFMP(Animator GNIIMMEBLHJ, AnimatorStateInfo NKEKBJIDGCB)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
			public HandPoseSetting()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float DefaultHandOpenCloseAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private HandPoseSetting[] HandPoseOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private Dictionary<int, HandPoseSetting> _handPoseDictionary;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x68AD0B0", Offset = "0x68ABCB0", VA = "0x1868AD0B0")]
		public void KCBMKHLALEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x68ACEA0", Offset = "0x68ABAA0", VA = "0x1868ACEA0")]
		public (float, float) GMMIDGFFBNK(Animator GNIIMMEBLHJ)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACC90", Offset = "0x68AB890", VA = "0x1868ACC90")]
		private (float, float) CAEGPDHOKCG(Animator GNIIMMEBLHJ, AnimatorStateInfo NKEKBJIDGCB)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x68AD2A0", Offset = "0x68ABEA0", VA = "0x1868AD2A0")]
		public HandPoseSettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MovementDirectionAnimationBehavior : StateMachineBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private static readonly int CURRENT_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private static readonly int HAS_LOCAL_MOVEMENT_ANGLE;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private static readonly int LOCAL_MOVEMENT_STRENGTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[Tooltip("The rotation of the animation. 0 = forward, -90 = left, 90 = right")]
		public float localMovementAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[Tooltip("The amount of offset the user input applies on top of the movement angle. 0 = no input rotation, 1 = rotate to face input")]
		public float localMovementStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[Tooltip("Set to true to enable. Set to false to clear the movement angle.")]
		public bool hasLocalMovement;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68B2730", Offset = "0x68B1330", VA = "0x1868B2730", Slot = "4")]
		public override void OnStateEnter(Animator GNIIMMEBLHJ, AnimatorStateInfo NKEKBJIDGCB, int CIGNKPLCAIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x68B28A0", Offset = "0x68B14A0", VA = "0x1868B28A0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class LFGFILIFKEA<TInput, TOutput> : LLMJCOALPIN<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly HLJCFCHLOHC IEHMKNPHDEC;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4253900", Offset = "0x4252500", VA = "0x184253900")]
	protected LFGFILIFKEA(HLJCFCHLOHC IEHMKNPHDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput GCPIDJEBGBI(TInput NGMMAKENIFG, [Out] IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4253860", Offset = "0x4252460", VA = "0x184253860", Slot = "5")]
	public bool ADBBMGADNPI(TInput NGMMAKENIFG, [Out] TOutput? KKIOBLFFGJH, [Out] IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[OCDDNNLBGPA]
public static class ILDHCPJCOHH
{
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static readonly Regex MMDGBBGILNM;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x68ADB70", Offset = "0x68AC770", VA = "0x1868ADB70")]
	public static HPGPCNLFDMN PEMBKICDPJK(FFKCOFENOPK FOAAMOPOOLI, PJILGJPEDNH HKGIHIPGMNC, Guid? KOEGFHCKJHC, Color? BPAOBHJOOLB, OJAMEGDJJME JLBPDFLBANG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x68AD880", Offset = "0x68AC480", VA = "0x1868AD880")]
	public static CMEPKGFHLPL PDMMJHLHJAP(HPGPCNLFDMN JGFKFMMOAJO)
	{
		return default(CMEPKGFHLPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7FA90", Offset = "0x2B7E690", VA = "0x182B7FA90")]
	internal static TModern? OGELEGLOPGH<TModern>(string? NGMMAKENIFG, AHDNMBAPFHG<TModern> JAMNCNEHHKN, HLJCFCHLOHC IEHMKNPHDEC, IEHKMOOCGMK JFLJDDDNHNG, TModern HPJKOKBEPDF) where TModern : struct, LNGABDMOONC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F280", Offset = "0x2B7DE80", VA = "0x182B7F280")]
	internal static GNGEIIMPPIF EAJLLAKJFCD<TModern>(string? NGMMAKENIFG, AHDNMBAPFHG<TModern> JAMNCNEHHKN, HLJCFCHLOHC IEHMKNPHDEC, IEHKMOOCGMK JFLJDDDNHNG, TModern HPJKOKBEPDF) where TModern : struct, LNGABDMOONC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x68ADD80", Offset = "0x68AC980", VA = "0x1868ADD80")]
	internal static List<PIGNFJGILAH> PIBJIHFJELB(IEnumerable<BDFNLAMGNMD>? HEIACNBOIKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E3F0", Offset = "0x2B7CFF0", VA = "0x182B7E3F0")]
	internal static string AOKBAEEIEIK<TModern>(TModern NGMMAKENIFG, AHDNMBAPFHG<TModern> JAMNCNEHHKN, HLJCFCHLOHC IEHMKNPHDEC) where TModern : LNGABDMOONC
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class IKMGFKDGBAI : DEOGEBNANBE
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LLMJCOALPIN<IGAHDNPAOAH, HKEEHAKOMGN> FEJANOACKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public LLMJCOALPIN<NEFICIJOBBJ, GGAPEJLBDID> FBBFANPIBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public LLMJCOALPIN<NEFICIJOBBJ, GGAPEJLBDID> AGLOIKJGFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public BGGKAMNBOPM MDFEGLBLHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public PBODDJMOADJ DDDFBDNEDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x68AD2B0", Offset = "0x68ABEB0", VA = "0x1868AD2B0")]
	[DHOHFCLMOGD(OBGPNJNCONH.Root, IDHBAGABJJA.GameOnly)]
	[UsedImplicitly]
	private static void IOMJOEFGMKK(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x68AD320", Offset = "0x68ABF20", VA = "0x1868AD320")]
	[Preserve]
	internal IKMGFKDGBAI([POJODGKFIMO("UnitySerialization")] NCDFIACMHPB FPHLIBFMLGC, [POJODGKFIMO(null)] NJHFEHHDIKB NHHHEBLKDKP, [POJODGKFIMO(null)] HLJCFCHLOHC IEHMKNPHDEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum BCLCKIBDHED
{
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	InvalidJsonOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	InvalidLegacyOutfitSelectionsFormat,
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	InvalidBodyPart,
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	InvalidGuid,
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	ModernGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	LegacyGuidMappingFailed,
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	InvalidJsonAvatarData,
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	MissingLegacyData
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class JIGFDNHLPEG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x68AF990", Offset = "0x68AE590", VA = "0x1868AF990")]
	public JIGFDNHLPEG(string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x68AF920", Offset = "0x68AE520", VA = "0x1868AF920")]
	public JIGFDNHLPEG(string NKAJDDICLFH, Exception PJELPOAIABL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x68AF9C0", Offset = "0x68AE5C0", VA = "0x1868AF9C0")]
	public JIGFDNHLPEG(BCLCKIBDHED GNNOHLIDBFM, string NKAJDDICLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x68AF950", Offset = "0x68AE550", VA = "0x1868AF950")]
	public JIGFDNHLPEG(BCLCKIBDHED GNNOHLIDBFM, string NKAJDDICLFH, Exception PJELPOAIABL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class JBLEALHBPDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly NCDFIACMHPB FPHLIBFMLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	protected readonly NJHFEHHDIKB NHHHEBLKDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	protected readonly HLJCFCHLOHC IEHMKNPHDEC;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x68AC270", Offset = "0x68AAE70", VA = "0x1868AC270")]
	protected JBLEALHBPDK(NCDFIACMHPB FPHLIBFMLGC, NJHFEHHDIKB NHHHEBLKDKP, HLJCFCHLOHC IEHMKNPHDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x68ADF70", Offset = "0x68ACB70", VA = "0x1868ADF70")]
	protected string BCAGIKMPCND(HKEEHAKOMGN KNLCFJMHCLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x68AF3D0", Offset = "0x68ADFD0", VA = "0x1868AF3D0")]
	protected string KHILLOFBONI(HKEEHAKOMGN KNLCFJMHCLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x68AF5B0", Offset = "0x68AE1B0", VA = "0x1868AF5B0")]
	private AvatarOutfitSelectionData PEMBKICDPJK(HPGPCNLFDMN NMOAMHCEKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x68AF290", Offset = "0x68ADE90", VA = "0x1868AF290")]
	private static AvatarCustomizationSettingsData.AnchorParams IMCJPLCJCDA(IBJDFNNFBEJ? OOJNBFBIFNH)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface LLMJCOALPIN<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput GCPIDJEBGBI(TInput NGMMAKENIFG, [Out] IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADBBMGADNPI(TInput NGMMAKENIFG, [Out] TOutput? KKIOBLFFGJH, [Out] IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface DEOGEBNANBE
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	LLMJCOALPIN<IGAHDNPAOAH, HKEEHAKOMGN> FEJANOACKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LLMJCOALPIN<NEFICIJOBBJ, GGAPEJLBDID> AGLOIKJGFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BGGKAMNBOPM MDFEGLBLHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum IEHKMOOCGMK
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PBODDJMOADJ
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCCAPJLJDIO CJJBNJOFCID(HKEEHAKOMGN JGFKFMMOAJO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface BGGKAMNBOPM
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NEFICIJOBBJ CJJBNJOFCID(HKEEHAKOMGN JGFKFMMOAJO, int HLLGOLOIKLA, string? LONKACOOPGJ, string? AGFPEFFNOBC, EMCFGHOJEPP NKOJACBBKBN, List<PIGNFJGILAH>? PAJMHKCIEPH);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[OCDDNNLBGPA]
internal class CGICCCIGGLH : LFGFILIFKEA<IGAHDNPAOAH, HKEEHAKOMGN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly NJHFEHHDIKB NHHHEBLKDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly MBIEMHBOPBK KPOEIMKHCFO;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x68AB4B0", Offset = "0x68AA0B0", VA = "0x1868AB4B0")]
	public CGICCCIGGLH(NCDFIACMHPB FPHLIBFMLGC, NJHFEHHDIKB NHHHEBLKDKP, HLJCFCHLOHC IEHMKNPHDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x68AB200", Offset = "0x68A9E00", VA = "0x1868AB200", Slot = "6")]
	public override HKEEHAKOMGN GCPIDJEBGBI(IGAHDNPAOAH NGMMAKENIFG, [Out] IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[Preserve]
internal class HDOAMGLJFKH : NCDFIACMHPB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class BAFBKBEKELK : JsonConverter<GNGEIIMPPIF>
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x68AAC80", Offset = "0x68A9880", VA = "0x1868AAC80", Slot = "9")]
		public override void WriteJson(JsonWriter PNCAPBLIAKM, GNGEIIMPPIF? IIPLJLPCLBC, JsonSerializer ELJHEBAHMEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x68AAB60", Offset = "0x68A9760", VA = "0x1868AAB60", Slot = "10")]
		public override GNGEIIMPPIF ReadJson(JsonReader KLAPEMMBNLL, Type MHKLNGFJGPA, GNGEIIMPPIF? BMDHJKEKMFB, bool NAMMAGBEDDH, JsonSerializer ELJHEBAHMEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x68AAD20", Offset = "0x68A9920", VA = "0x1868AAD20")]
		public BAFBKBEKELK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class HGIICMJNGFJ : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool LKHIJHMINPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x68AC930", Offset = "0x68AB530", VA = "0x1868AC930", Slot = "5")]
		public override object ReadJson(JsonReader KLAPEMMBNLL, Type MHKLNGFJGPA, object? BMDHJKEKMFB, JsonSerializer ELJHEBAHMEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x68AC750", Offset = "0x68AB350", VA = "0x1868AC750", Slot = "6")]
		public override bool CanConvert(Type MHKLNGFJGPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x68AC990", Offset = "0x68AB590", VA = "0x1868AC990", Slot = "4")]
		public override void WriteJson(JsonWriter PNCAPBLIAKM, object? IIPLJLPCLBC, JsonSerializer ELJHEBAHMEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x68AC550", Offset = "0x68AB150", VA = "0x1868AC550")]
		private static bool CLKJDKIFIHE(object IIPLJLPCLBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
		public HGIICMJNGFJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly JsonSerializerSettings BCIAKBKNBPK;

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x68AC3F0", Offset = "0x68AAFF0", VA = "0x1868AC3F0")]
	internal HDOAMGLJFKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2B3D910", Offset = "0x2B3C510", VA = "0x182B3D910", Slot = "4")]
	public string LGDNNHNBCEG<T>(T APKAFMDACKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2B3D880", Offset = "0x2B3C480", VA = "0x182B3D880", Slot = "5")]
	public T ALLKHHAFNNC<T>(string IIPLJLPCLBC)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[Preserve]
internal class NJJHHLHAGCB : NCDFIACMHPB
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA550", Offset = "0x2CA9150", VA = "0x182CAA550", Slot = "4")]
	public string LGDNNHNBCEG<T>(T APKAFMDACKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2CAA4D0", Offset = "0x2CA90D0", VA = "0x182CAA4D0", Slot = "5")]
	public T ALLKHHAFNNC<T>(string IIPLJLPCLBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public NJJHHLHAGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[OCDDNNLBGPA]
internal class MBIEMHBOPBK : LFGFILIFKEA<NEFICIJOBBJ, GGAPEJLBDID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly NCDFIACMHPB FPHLIBFMLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly NJHFEHHDIKB NHHHEBLKDKP;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x68B23A0", Offset = "0x68B0FA0", VA = "0x1868B23A0")]
	public MBIEMHBOPBK(NCDFIACMHPB FPHLIBFMLGC, NJHFEHHDIKB NHHHEBLKDKP, HLJCFCHLOHC IEHMKNPHDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x68B0B90", Offset = "0x68AF790", VA = "0x1868B0B90", Slot = "6")]
	public override GGAPEJLBDID GCPIDJEBGBI(NEFICIJOBBJ NGMMAKENIFG, [Out] IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x68B1F50", Offset = "0x68B0B50", VA = "0x1868B1F50")]
	internal void NKHHMCOPPBC(string FNHKKDENEGD, HKEEHAKOMGN KNLCFJMHCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x68B1D40", Offset = "0x68B0940", VA = "0x1868B1D40")]
	public IEnumerable<HPGPCNLFDMN> KGKNBANKMMB(string CLLEEGGKDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x68B1920", Offset = "0x68B0520", VA = "0x1868B1920")]
	private IEnumerable<HPGPCNLFDMN> KFKGJPBNNEF(string CLLEEGGKDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x68AFE80", Offset = "0x68AEA80", VA = "0x1868AFE80")]
	internal IEnumerable<HPGPCNLFDMN> AEDJOHCCCGC(string CLLEEGGKDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x68B11C0", Offset = "0x68AFDC0", VA = "0x1868B11C0")]
	private HPGPCNLFDMN JPAOCBHOEKC(AvatarOutfitSelectionData FLBOCBPDHEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x68B02F0", Offset = "0x68AEEF0", VA = "0x1868B02F0")]
	private void GCHOOKOIALG(AvatarCustomizationSettingsData IBEDAOLJNAJ, HKEEHAKOMGN KNLCFJMHCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x68B1590", Offset = "0x68B0190", VA = "0x1868B1590")]
	private HPGPCNLFDMN JPAOCBHOEKC(string HDFGJJMDKIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x68B20A0", Offset = "0x68B0CA0", VA = "0x1868B20A0")]
	internal static (OJAMEGDJJME, string, string) OKHLPODPPCD(string HDFGJJMDKIO, HLJCFCHLOHC IEHMKNPHDEC)
	{
		return default((OJAMEGDJJME, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68B0FC0", Offset = "0x68AFBC0", VA = "0x1868B0FC0")]
	private IMALHEFMIAI? GGIHPBHHFIL(string? GBCIBJHFOHP, Vector2 JBBEFLJOMLO, float HKIEDDODMMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x68B1DF0", Offset = "0x68B09F0", VA = "0x1868B1DF0")]
	private static IBJDFNNFBEJ MNACNNHENPC(AvatarCustomizationSettingsData.AnchorParams ADBHMCCNHMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[OCDDNNLBGPA]
internal class HBMGMOBCBKN : JBLEALHBPDK, PBODDJMOADJ
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x68AC270", Offset = "0x68AAE70", VA = "0x1868AC270")]
	public HBMGMOBCBKN(NCDFIACMHPB FPHLIBFMLGC, NJHFEHHDIKB NHHHEBLKDKP, HLJCFCHLOHC IEHMKNPHDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x68ABC00", Offset = "0x68AA800", VA = "0x1868ABC00", Slot = "4")]
	public DCCAPJLJDIO CJJBNJOFCID(HKEEHAKOMGN JGFKFMMOAJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x68ABB00", Offset = "0x68AA700", VA = "0x1868ABB00")]
	private string BLEFBGGOFCD(HKEEHAKOMGN KNLCFJMHCLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x68ABFB0", Offset = "0x68AABB0", VA = "0x1868ABFB0")]
	private string PFAOMFLJKNK(HPGPCNLFDMN NMOAMHCEKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[OCDDNNLBGPA]
internal class NLIGOFOCGDN : LFGFILIFKEA<NEFICIJOBBJ, GGAPEJLBDID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly NCDFIACMHPB FPHLIBFMLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private readonly LLMJCOALPIN<NEFICIJOBBJ, GGAPEJLBDID> IOJIAKCPHME;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x68B2CF0", Offset = "0x68B18F0", VA = "0x1868B2CF0")]
	public NLIGOFOCGDN(LLMJCOALPIN<NEFICIJOBBJ, GGAPEJLBDID> IOJIAKCPHME, HLJCFCHLOHC IEHMKNPHDEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x68B28C0", Offset = "0x68B14C0", VA = "0x1868B28C0", Slot = "6")]
	public override GGAPEJLBDID GCPIDJEBGBI(NEFICIJOBBJ NGMMAKENIFG, [Out] IReadOnlyList<PIGNFJGILAH>? PAJMHKCIEPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[OCDDNNLBGPA]
internal class KPDGPFIDIJI : BGGKAMNBOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly NCDFIACMHPB FPHLIBFMLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly PBODDJMOADJ PMCKEFICAED;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x68AFD90", Offset = "0x68AE990", VA = "0x1868AFD90")]
	public KPDGPFIDIJI(PBODDJMOADJ PMCKEFICAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x68AF9F0", Offset = "0x68AE5F0", VA = "0x1868AF9F0", Slot = "4")]
	public NEFICIJOBBJ CJJBNJOFCID(HKEEHAKOMGN JGFKFMMOAJO, int HLLGOLOIKLA, string? LONKACOOPGJ, string? AGFPEFFNOBC, EMCFGHOJEPP NKOJACBBKBN, List<PIGNFJGILAH>? PAJMHKCIEPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[Preserve]
internal class OKAKLKFFJHJ : CMLDGCDNBOD
{
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly Vector2 GOCFOKGHGGH;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static readonly Vector2 FKECAMGKDNE;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly Vector2 PLLKBBEJKPO;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly Vector2 CMEACNJHKJI;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly Vector2 JKMEEMMPMBK;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private static readonly Vector2 JKDJHJHAIFM;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private static readonly Vector2 JHGBPLKCJEL;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private static readonly Vector2 DNAGNANODJC;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly Vector2 ODEKFCBNNOM;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly Vector2 CMGNPDNDKLC;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly Vector2 DIJKMOMPAHJ;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly Vector2 MMJOOJEACND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private Dictionary<KLACEAHOGOL, AvatarConfiguration> JOAHFGEHBCF;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x68B4650", Offset = "0x68B3250", VA = "0x1868B4650")]
	[DHOHFCLMOGD(OBGPNJNCONH.Root, IDHBAGABJJA.None)]
	private static void PGNGBPILNOO(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x68B4A30", Offset = "0x68B3630", VA = "0x1868B4A30")]
	[Preserve]
	internal OKAKLKFFJHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68B46C0", Offset = "0x68B32C0", VA = "0x1868B46C0", Slot = "4")]
	public Vector2 PKIPOOLJHLK(FaceFeatureType FFEIFKLKPPL, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x68B2ED0", Offset = "0x68B1AD0", VA = "0x1868B2ED0", Slot = "5")]
	public float APGEBIJJGGH(FaceFeatureType FFEIFKLKPPL, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x68B41F0", Offset = "0x68B2DF0", VA = "0x1868B41F0", Slot = "6")]
	public void MJFHPEGEDPK(KLACEAHOGOL HDHCJEGBAPK, AvatarConfiguration AAPAGCKHJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x68B3570", Offset = "0x68B2170", VA = "0x1868B3570", Slot = "7")]
	public float FNODMODDPBF(FaceFeatureType LKOKPNNCBEM, float MKLJELEIIMG, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x68B30B0", Offset = "0x68B1CB0", VA = "0x1868B30B0", Slot = "8")]
	public float BIJCOLGABMG(FaceFeatureType LKOKPNNCBEM, float HKIEDDODMMD, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x68B3C90", Offset = "0x68B2890", VA = "0x1868B3C90", Slot = "10")]
	public Vector2 ILBLLICGDNO(FaceFeatureType LKOKPNNCBEM, Vector2 LLCPDDNFBMB, Vector2 KKGPEMOBMAI, Vector2 JKFBJAMCLHA, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68B30E0", Offset = "0x68B1CE0", VA = "0x1868B30E0", Slot = "9")]
	public Vector2 CBOCIBKLNGO(FaceFeatureType LKOKPNNCBEM, Vector2 ANMNNJMLCOB, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68B3E40", Offset = "0x68B2A40", VA = "0x1868B3E40")]
	private Vector2 ILLKILOPJJP(FaceFeatureType LKOKPNNCBEM, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68B4500", Offset = "0x68B3100", VA = "0x1868B4500")]
	private Vector2 PBIACIOIKNH(FaceFeatureType LKOKPNNCBEM, Vector2 LLCPDDNFBMB, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68B3820", Offset = "0x68B2420", VA = "0x1868B3820", Slot = "11")]
	public Vector2 IFAAFKLACCC(FaceFeatureType LKOKPNNCBEM, Vector2 ANMNNJMLCOB, Vector2 KKGPEMOBMAI, Vector2 JKFBJAMCLHA, KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x68B3EE0", Offset = "0x68B2AE0", VA = "0x1868B3EE0")]
	private float KBAAMIKMINK(float GMOAOGFMENJ, float BHHOPHAOKKI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x68B33F0", Offset = "0x68B1FF0", VA = "0x1868B33F0")]
	private Vector2 DIFMAHANAGL(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x68B4320", Offset = "0x68B2F20", VA = "0x1868B4320")]
	private Vector2 NIHHLGBACKJ(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x68B43A0", Offset = "0x68B2FA0", VA = "0x1868B43A0")]
	private Vector2 ODFAHMDNHEC(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x68B42A0", Offset = "0x68B2EA0", VA = "0x1868B42A0")]
	private Vector2 MOLMMOBPIMP(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x68B4260", Offset = "0x68B2E60", VA = "0x1868B4260")]
	private float MMAJKAKBOGG(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x68B3530", Offset = "0x68B2130", VA = "0x1868B3530")]
	private float EAEHKILELDN(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x68B2F90", Offset = "0x68B1B90", VA = "0x1868B2F90")]
	private float BHGCEMINOPM(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x68B2F50", Offset = "0x68B1B50", VA = "0x1868B2F50")]
	private float APNABGEIGBM(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x68B2FD0", Offset = "0x68B1BD0", VA = "0x1868B2FD0")]
	private Vector2 BICAOMEGIDN(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x68B3740", Offset = "0x68B2340", VA = "0x1868B3740")]
	private Vector2 GMIDHDOALNE(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x68B4050", Offset = "0x68B2C50", VA = "0x1868B4050")]
	private Vector2 KLELHDJCDLF(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x68B3310", Offset = "0x68B1F10", VA = "0x1868B3310")]
	private Vector2 CLCEMNFPKBD(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x68B35A0", Offset = "0x68B21A0", VA = "0x1868B35A0")]
	private Vector2 FNPFAHANCOJ(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x68B3BB0", Offset = "0x68B27B0", VA = "0x1868B3BB0")]
	private Vector2 IKLOFJDFHMA(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x68B3F70", Offset = "0x68B2B70", VA = "0x1868B3F70")]
	private Vector2 KFCKKJNEFMH(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x68B4420", Offset = "0x68B3020", VA = "0x1868B4420")]
	private Vector2 OEJNONCPEOI(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x68B2DF0", Offset = "0x68B19F0", VA = "0x1868B2DF0")]
	private Vector2 AMIBMIDMIBG(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x68B3470", Offset = "0x68B2070", VA = "0x1868B3470")]
	private Vector2 DNBCJALCAFA(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x68B4130", Offset = "0x68B2D30", VA = "0x1868B4130")]
	private Vector2 LEIGIBFFOGJ(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x68B3680", Offset = "0x68B2280", VA = "0x1868B3680")]
	private Vector2 GJDJCKBMCMM(KLACEAHOGOL HDHCJEGBAPK)
	{
		return default(Vector2);
	}
}
namespace RecRoom.Avatars.Animation.Utils
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[ExecuteAlways]
	public class AnimatorDebugUtil : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct PlayState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public string StateName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public int LayerIdx;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct ParamState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public string ParamName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public float ParamValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public AnimatorControllerParameterType ParamType;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		public PlayState[] PlayStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		public ParamState[] ParamStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private Animator Animator;

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x68A8900", Offset = "0x68A7500", VA = "0x1868A8900")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BEEEHILOHNB
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x68AAF10", Offset = "0x68A9B10", VA = "0x1868AAF10")]
	public static CMEPKGFHLPL GCPIDJEBGBI(this OALGKGFMNPI JGFKFMMOAJO)
	{
		return default(CMEPKGFHLPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x68AAD60", Offset = "0x68A9960", VA = "0x1868AAD60")]
	public static OALGKGFMNPI CJJBNJOFCID(this CMEPKGFHLPL NHICODBADNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x68AB190", Offset = "0x68A9D90", VA = "0x1868AB190")]
	public static bool KCHLJIGGCLA(this CMEPKGFHLPL NHICODBADNA)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	internal class AvatarCustomizationSettingsData
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		internal struct AnchorParams
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public Vector2 NormalizedPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public Vector3 HemisphereOffsets;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public Vector3 HemisphereRotations;

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x4CC9930", Offset = "0x4CC8530", VA = "0x184CC9930")]
			public AnchorParams(Vector2 LLCPDDNFBMB, Vector3 EKIPMKFBEEE, Vector3 PGHBEDDAPBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x68A8850", Offset = "0x68A7450", VA = "0x1868A8850")]
			internal IBJDFNNFBEJ CJJBNJOFCID()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private string? eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private string? eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		private string? noseId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private Vector2 nosePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private float noseScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private string? mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		private string? hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		private string? hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		private string? hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		[SerializeField]
		private string? beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		[SerializeField]
		private string? beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		private string? beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		private string? faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		[SerializeField]
		private string? bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		[SerializeField]
		private PCBGEGAPBCA useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private string? baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		internal static AnchorParams DefaultHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x68A9120", Offset = "0x68A7D20", VA = "0x1868A9120")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3846B20", Offset = "0x3845720", VA = "0x183846B20")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x1088690", Offset = "0x1087290", VA = "0x181088690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x8D15A0", Offset = "0x8D01A0", VA = "0x1808D15A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x9E5600", Offset = "0x9E4200", VA = "0x1809E5600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x867CC0", Offset = "0x8668C0", VA = "0x180867CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x68A91D0", Offset = "0x68A7DD0", VA = "0x1868A91D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x869F10", Offset = "0x868B10", VA = "0x180869F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8D1550", Offset = "0x8D0150", VA = "0x1808D1550")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x1092F20", Offset = "0x1091B20", VA = "0x181092F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x86C7D0", Offset = "0x86B3D0", VA = "0x18086C7D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x86C590", Offset = "0x86B190", VA = "0x18086C590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x68A9210", Offset = "0x68A7E10", VA = "0x1868A9210")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1CAD210", Offset = "0x1CABE10", VA = "0x181CAD210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8D1C30", Offset = "0x8D0830", VA = "0x1808D1C30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xEA9550", Offset = "0xEA8150", VA = "0x180EA9550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x86B540", Offset = "0x86A140", VA = "0x18086B540")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x86B510", Offset = "0x86A110", VA = "0x18086B510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4176C90", Offset = "0x4175890", VA = "0x184176C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x1CDB0A0", Offset = "0x1CD9CA0", VA = "0x181CDB0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x89B9E0", Offset = "0x89A5E0", VA = "0x18089B9E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x89BA40", Offset = "0x89A640", VA = "0x18089BA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x872470", Offset = "0x871070", VA = "0x180872470")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x872420", Offset = "0x871020", VA = "0x180872420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x8723D0", Offset = "0x870FD0", VA = "0x1808723D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8723A0", Offset = "0x870FA0", VA = "0x1808723A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x872460", Offset = "0x871060", VA = "0x180872460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x872360", Offset = "0x870F60", VA = "0x180872360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x9D34F0", Offset = "0x9D20F0", VA = "0x1809D34F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xA063A0", Offset = "0xA04FA0", VA = "0x180A063A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x872380", Offset = "0x870F80", VA = "0x180872380")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8724D0", Offset = "0x8710D0", VA = "0x1808724D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x9F9A50", Offset = "0x9F8650", VA = "0x1809F9A50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x9D84C0", Offset = "0x9D70C0", VA = "0x1809D84C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x86BD00", Offset = "0x86A900", VA = "0x18086BD00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x86BCB0", Offset = "0x86A8B0", VA = "0x18086BCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xB9E440", Offset = "0xB9D040", VA = "0x180B9E440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xBA63C0", Offset = "0xBA4FC0", VA = "0x180BA63C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xA4D7C0", Offset = "0xA4C3C0", VA = "0x180A4D7C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xD32580", Offset = "0xD31180", VA = "0x180D32580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public PCBGEGAPBCA UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x1D75B00", Offset = "0x1D74700", VA = "0x181D75B00")]
			get
			{
				return default(PCBGEGAPBCA);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x1D77C90", Offset = "0x1D76890", VA = "0x181D77C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xA7C800", Offset = "0xA7B400", VA = "0x180A7C800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0xA7C6A0", Offset = "0xA7B2A0", VA = "0x180A7C6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x68A91F0", Offset = "0x68A7DF0", VA = "0x1868A91F0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x68A9230", Offset = "0x68A7E30", VA = "0x1868A9230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x68A8D80", Offset = "0x68A7980", VA = "0x1868A8D80")]
		public AvatarCustomizationSettingsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class AvatarOutfitSelectionsData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public AvatarOutfitSelectionData[]? selections;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public AvatarOutfitSelectionsData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	internal class AvatarOutfitSelectionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public string? PrefabGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private string? CombinationGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public OJAMEGDJJME BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private IHENJGOPBKG? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x68AA460", Offset = "0x68A9060", VA = "0x1868AA460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public AvatarOutfitSelectionData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	internal class AvatarUgcOutfitData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Color BaseAvatarItemColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public string? CustomAvatarItemId;

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
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
